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
            this.ddlEntityTypes = new System.Windows.Forms.ToolStripComboBox();
            this.btnInspectEntities = new System.Windows.Forms.ToolStripButton();
            this.btnGetEntityData = new System.Windows.Forms.ToolStripButton();
            this.btnXlsxExport = new System.Windows.Forms.ToolStripButton();
            this.gridEntity = new System.Windows.Forms.DataGridView();
            this.lblByAuthor = new System.Windows.Forms.ToolStripLabel();
            this.toolStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEntity)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbClose,
            this.ddlEntityTypes,
            this.btnInspectEntities,
            this.btnGetEntityData,
            this.btnXlsxExport,
            this.tssSeparator1,
            this.lblByAuthor});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(559, 31);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // tsbClose
            // 
            this.tsbClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbClose.Image")));
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(28, 28);
            this.tsbClose.Text = "Close";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // tssSeparator1
            // 
            this.tssSeparator1.Name = "tssSeparator1";
            this.tssSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // ddlEntityTypes
            // 
            this.ddlEntityTypes.AutoCompleteCustomSource.AddRange(new string[] {
            "All=1",
            "Custom=2",
            "Out of the box=3"});
            this.ddlEntityTypes.DropDownWidth = 300;
            this.ddlEntityTypes.Name = "ddlEntityTypes";
            this.ddlEntityTypes.Size = new System.Drawing.Size(201, 31);
            // 
            // btnInspectEntities
            // 
            this.btnInspectEntities.Image = ((System.Drawing.Image)(resources.GetObject("btnInspectEntities.Image")));
            this.btnInspectEntities.Name = "btnInspectEntities";
            this.btnInspectEntities.Size = new System.Drawing.Size(73, 28);
            this.btnInspectEntities.Text = "Inspect";
            this.btnInspectEntities.Click += new System.EventHandler(this.btnInspectEntities_Click);
            // 
            // btnGetEntityData
            // 
            this.btnGetEntityData.Enabled = false;
            this.btnGetEntityData.Image = ((System.Drawing.Image)(resources.GetObject("btnGetEntityData.Image")));
            this.btnGetEntityData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGetEntityData.Name = "btnGetEntityData";
            this.btnGetEntityData.Size = new System.Drawing.Size(68, 28);
            this.btnGetEntityData.Text = "Count";
            this.btnGetEntityData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // btnXlsxExport
            // 
            this.btnXlsxExport.Enabled = false;
            this.btnXlsxExport.Image = ((System.Drawing.Image)(resources.GetObject("btnXlsxExport.Image")));
            this.btnXlsxExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXlsxExport.Name = "btnXlsxExport";
            this.btnXlsxExport.Size = new System.Drawing.Size(68, 28);
            this.btnXlsxExport.Text = "Export";
            this.btnXlsxExport.Click += new System.EventHandler(this.btnXlsxExport_Click);
            // 
            // gridEntity
            // 
            this.gridEntity.AllowUserToAddRows = false;
            this.gridEntity.AllowUserToDeleteRows = false;
            this.gridEntity.AllowUserToOrderColumns = true;
            this.gridEntity.AllowUserToResizeRows = false;
            this.gridEntity.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridEntity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEntity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEntity.GridColor = System.Drawing.SystemColors.ControlLight;
            this.gridEntity.Location = new System.Drawing.Point(0, 31);
            this.gridEntity.Margin = new System.Windows.Forms.Padding(2);
            this.gridEntity.Name = "gridEntity";
            this.gridEntity.ReadOnly = true;
            this.gridEntity.RowTemplate.Height = 28;
            this.gridEntity.Size = new System.Drawing.Size(559, 269);
            this.gridEntity.TabIndex = 5;
            this.gridEntity.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridEntity_RowHeaderMouseClick);
            // 
            // lblByAuthor
            // 
            this.lblByAuthor.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblByAuthor.DoubleClickEnabled = true;
            this.lblByAuthor.Image = ((System.Drawing.Image)(resources.GetObject("lblByAuthor.Image")));
            this.lblByAuthor.IsLink = true;
            this.lblByAuthor.Name = "lblByAuthor";
            this.lblByAuthor.Size = new System.Drawing.Size(85, 28);
            this.lblByAuthor.Text = "by Thrives";
            this.lblByAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblByAuthor.Click += new System.EventHandler(this.lblByAuthor_DoubleClick);
            // 
            // MyPluginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridEntity);
            this.Controls.Add(this.toolStripMenu);
            this.Name = "MyPluginControl";
            this.Size = new System.Drawing.Size(559, 300);
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
        private System.Windows.Forms.ToolStripLabel lblByAuthor;
    }
}
