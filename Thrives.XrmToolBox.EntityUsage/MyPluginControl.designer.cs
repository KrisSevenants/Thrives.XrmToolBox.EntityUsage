namespace Thrives.XrmToolBox.EntityUsage
{
    partial class MyPluginControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyPluginControl));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.tssSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnInspectEntities = new System.Windows.Forms.ToolStripButton();
            this.btnGetEntityData = new System.Windows.Forms.ToolStripButton();
            this.btnXlsxExport = new System.Windows.Forms.ToolStripButton();
            this.gridEntity = new System.Windows.Forms.DataGridView();
            this.ddlEntityTypes = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEntity)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbClose,
            this.tssSeparator1,
            this.ddlEntityTypes,
            this.btnInspectEntities,
            this.btnGetEntityData,
            this.btnXlsxExport});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripMenu.Size = new System.Drawing.Size(838, 33);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // tsbClose
            // 
            this.tsbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(59, 30);
            this.tsbClose.Text = "Close";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // tssSeparator1
            // 
            this.tssSeparator1.Name = "tssSeparator1";
            this.tssSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // btnInspectEntities
            // 
            this.btnInspectEntities.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnInspectEntities.Name = "btnInspectEntities";
            this.btnInspectEntities.Size = new System.Drawing.Size(134, 30);
            this.btnInspectEntities.Text = "Inspect Entities";
            this.btnInspectEntities.Click += new System.EventHandler(this.btnInspectEntities_Click);
            // 
            // btnGetEntityData
            // 
            this.btnGetEntityData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnGetEntityData.Enabled = false;
            this.btnGetEntityData.Image = ((System.Drawing.Image)(resources.GetObject("btnGetEntityData.Image")));
            this.btnGetEntityData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGetEntityData.Name = "btnGetEntityData";
            this.btnGetEntityData.Size = new System.Drawing.Size(113, 30);
            this.btnGetEntityData.Text = "Entity Count";
            this.btnGetEntityData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // btnXlsxExport
            // 
            this.btnXlsxExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnXlsxExport.Enabled = false;
            this.btnXlsxExport.Image = ((System.Drawing.Image)(resources.GetObject("btnXlsxExport.Image")));
            this.btnXlsxExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXlsxExport.Name = "btnXlsxExport";
            this.btnXlsxExport.Size = new System.Drawing.Size(67, 30);
            this.btnXlsxExport.Text = "Export";
            this.btnXlsxExport.Click += new System.EventHandler(this.btnXlsxExport_Click);
            // 
            // gridEntity
            // 
            this.gridEntity.AllowUserToAddRows = false;
            this.gridEntity.AllowUserToDeleteRows = false;
            this.gridEntity.AllowUserToOrderColumns = true;
            this.gridEntity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEntity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEntity.Location = new System.Drawing.Point(0, 33);
            this.gridEntity.Name = "gridEntity";
            this.gridEntity.ReadOnly = true;
            this.gridEntity.RowTemplate.Height = 28;
            this.gridEntity.Size = new System.Drawing.Size(838, 429);
            this.gridEntity.TabIndex = 5;
            this.gridEntity.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridEntity_RowHeaderMouseClick);
            // 
            // ddlEntityTypes
            // 
            this.ddlEntityTypes.AutoCompleteCustomSource.AddRange(new string[] {
            "All=1",
            "Custom=2",
            "Out of the box=3"});
            this.ddlEntityTypes.Name = "ddlEntityTypes";
            this.ddlEntityTypes.Size = new System.Drawing.Size(121, 33);
            // 
            // MyPluginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridEntity);
            this.Controls.Add(this.toolStripMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MyPluginControl";
            this.Size = new System.Drawing.Size(838, 462);
            this.Load += new System.EventHandler(this.MyPluginControl_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEntity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripButton btnInspectEntities;
        private System.Windows.Forms.ToolStripSeparator tssSeparator1;
        private System.Windows.Forms.DataGridView gridEntity;
        private System.Windows.Forms.ToolStripButton btnGetEntityData;
        private System.Windows.Forms.ToolStripButton btnXlsxExport;
        private System.Windows.Forms.ToolStripComboBox ddlEntityTypes;
    }
}
