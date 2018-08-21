using McTools.Xrm.Connection;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using Thrives.XrmToolBox.EntityUsage.Model;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Args;
using XrmToolBox.Extensibility.Interfaces;

namespace Thrives.XrmToolBox.EntityUsage
{
    public partial class MyPluginControl : PluginControlBase, IStatusBarMessenger
    {
        private Settings mySettings;
        private EntityUsageManager _usageManager;
        public event EventHandler<StatusBarMessageEventArgs> SendMessageToStatusBar;


        public MyPluginControl()
        {
            InitializeComponent();
        }

        private void MyPluginControl_Load(object sender, EventArgs e)
        {
            
            _usageManager = new EntityUsageManager(Service);
            // Loads or creates the settings for the plugin
            if (!SettingsManager.Instance.TryLoad(GetType(), out mySettings))
            {
                mySettings = new Settings();

                LogWarning("Settings not found => a new settings file has been created!");
            }
            else
            {
                LogInfo("Settings found and loaded");
            }
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            CloseTool();
        }




        /// <summary>
        /// This event occurs when the plugin is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyPluginControl_OnCloseTool(object sender, EventArgs e)
        {
            // Before leaving, save the settings
            SettingsManager.Instance.Save(GetType(), mySettings);
        }

        /// <summary>
        /// This event occurs when the connection has been updated in XrmToolBox
        /// </summary>
        public override void UpdateConnection(IOrganizationService newService, ConnectionDetail detail, string actionName, object parameter)
        {
            base.UpdateConnection(newService, detail, actionName, parameter);
            _usageManager = new EntityUsageManager(Service);
            if (mySettings != null && detail != null)
            {
                mySettings.LastUsedOrganizationWebappUrl = detail.WebApplicationUrl;
                LogInfo("Connection has changed to: {0}", detail.WebApplicationUrl);
            }
        }

        private void btnInspectEntities_Click(object sender, EventArgs e)
        {
            ExecuteMethod(GetEntityMetadata);
        }

        private void GetEntityMetadata()
        {
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Retrieving entities",
                Work = (worker, args) =>
                {

                    _usageManager.GetEntities();
                    args.Result = _usageManager.Gridlist;
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show(args.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    var result = args.Result as List<Model.EntityUsageGridModel>;
                    if (result != null)
                    {
                        gridEntity.DataSource = result;
                        btnGetEntityData.Enabled = true;
                    }
                }
            });
        }

        private void GetEntityData()
        {

            ShowInfoNotification("Calculation can take a while depending on entity record size, so sit back and relax!", null);
            WorkAsync(new WorkAsyncInfo
            {
                Message = "retrieving Entity Records...",
                Work = (w, e) =>
                {
                    int counter = 0;
                    foreach (Model.EntityUsageGridModel elem in _usageManager.Gridlist)
                    {
                        counter++;
                        w.ReportProgress((int)Math.Round((double)(100 * counter) / _usageManager.Gridlist.Count), $"Loading {elem.EntityName}...");
                        elem.Count(Service);
                    }
                    e.Result = _usageManager.Gridlist;
                },
                ProgressChanged = e =>
                {
                    SetWorkingMessage(e.UserState.ToString());
                    SendMessageToStatusBar?.Invoke(this, new StatusBarMessageEventArgs(e.ProgressPercentage, "Querying data"));
                },
                PostWorkCallBack = args =>
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show(args.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    var result = args.Result as List<Model.EntityUsageGridModel>;
                    if (result != null)
                    {
                        gridEntity.DataSource = result;
                        btnXlsxExport.Enabled = true;
                    }
                    HideNotification();

                },
                AsyncArgument = null,
                // Progress information panel size
                MessageWidth = 340,
                MessageHeight = 150
            });
            
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            ExecuteMethod(GetEntityData);
        }

        private void btnXlsxExport_Click(object sender, EventArgs e)
        {
            var saveDialog = new SaveFileDialog { Filter = "Excel|*.xlsx" };
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                ExcelManager xlsx = new ExcelManager(_usageManager.Gridlist);
                xlsx.Save(saveDialog.FileName);

                if (MessageBox.Show(this, "Would you like to open it?", "Information",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Process.Start(saveDialog.FileName);
                }
            }
        }
    }
}