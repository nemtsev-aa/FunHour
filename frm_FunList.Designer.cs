
namespace FunHour
{
    partial class frm_FunList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ts_TopMenu = new System.Windows.Forms.ToolStrip();
            this.tsb_AddFun = new System.Windows.Forms.ToolStripButton();
            this.tsb_EditFun = new System.Windows.Forms.ToolStripButton();
            this.tsb_DelFun = new System.Windows.Forms.ToolStripButton();
            this.dgv_FunList = new System.Windows.Forms.DataGridView();
            this.FunIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FunNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FunImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.FunTimeColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.FunStatusColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.funListTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funListDBDataSet = new FunHour.FunListDBDataSet();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.funListTableTableAdapter = new FunHour.FunListDBDataSetTableAdapters.FunListTableTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ts_TopMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FunList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funListTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funListDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ts_TopMenu
            // 
            this.ts_TopMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_AddFun,
            this.tsb_EditFun,
            this.tsb_DelFun});
            this.ts_TopMenu.Location = new System.Drawing.Point(0, 0);
            this.ts_TopMenu.Name = "ts_TopMenu";
            this.ts_TopMenu.Size = new System.Drawing.Size(800, 25);
            this.ts_TopMenu.TabIndex = 2;
            this.ts_TopMenu.Text = "ToolStrip1";
            // 
            // tsb_AddFun
            // 
            this.tsb_AddFun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_AddFun.Image = global::FunHour.Properties.Resources.free_icon_plus_3285480;
            this.tsb_AddFun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_AddFun.Name = "tsb_AddFun";
            this.tsb_AddFun.Size = new System.Drawing.Size(23, 22);
            this.tsb_AddFun.Text = "ToolStripButton1";
            this.tsb_AddFun.ToolTipText = "Добавить запись";
            this.tsb_AddFun.Click += new System.EventHandler(this.tsb_AddFun_Click);
            // 
            // tsb_EditFun
            // 
            this.tsb_EditFun.CheckOnClick = true;
            this.tsb_EditFun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_EditFun.Image = global::FunHour.Properties.Resources.free_icon_paper_sheet_5607410;
            this.tsb_EditFun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_EditFun.Name = "tsb_EditFun";
            this.tsb_EditFun.Size = new System.Drawing.Size(23, 22);
            this.tsb_EditFun.Text = "ToolStripButton2";
            this.tsb_EditFun.ToolTipText = "Редактировать запись";
            // 
            // tsb_DelFun
            // 
            this.tsb_DelFun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_DelFun.Image = global::FunHour.Properties.Resources.free_icon_cancel_179429;
            this.tsb_DelFun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_DelFun.Name = "tsb_DelFun";
            this.tsb_DelFun.Size = new System.Drawing.Size(23, 22);
            this.tsb_DelFun.Text = "ToolStripButton3";
            this.tsb_DelFun.ToolTipText = "Удалить запись";
            this.tsb_DelFun.Click += new System.EventHandler(this.tsb_DelFun_Click);
            // 
            // dgv_FunList
            // 
            this.dgv_FunList.AllowUserToAddRows = false;
            this.dgv_FunList.AutoGenerateColumns = false;
            this.dgv_FunList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_FunList.BackgroundColor = System.Drawing.Color.White;
            this.dgv_FunList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_FunList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FunIdColumn,
            this.FunNameColumn,
            this.FunImageColumn,
            this.FunTimeColumn,
            this.FunStatusColumn});
            this.dgv_FunList.DataSource = this.funListTableBindingSource;
            this.dgv_FunList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_FunList.Location = new System.Drawing.Point(0, 25);
            this.dgv_FunList.Name = "dgv_FunList";
            this.dgv_FunList.Size = new System.Drawing.Size(800, 425);
            this.dgv_FunList.TabIndex = 3;
            this.dgv_FunList.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_FunList_CellEnter);
            this.dgv_FunList.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgv_FunList_DataError);
            // 
            // FunIdColumn
            // 
            this.FunIdColumn.DataPropertyName = "FunId";
            this.FunIdColumn.HeaderText = "№ п/п";
            this.FunIdColumn.Name = "FunIdColumn";
            this.FunIdColumn.Visible = false;
            // 
            // FunNameColumn
            // 
            this.FunNameColumn.DataPropertyName = "FunName";
            this.FunNameColumn.HeaderText = "Название";
            this.FunNameColumn.Name = "FunNameColumn";
            // 
            // FunImageColumn
            // 
            this.FunImageColumn.DataPropertyName = "FunImage";
            this.FunImageColumn.HeaderText = "Картинка";
            this.FunImageColumn.Image = global::FunHour.Properties.Resources.free_icon_cancelled_7080047;
            this.FunImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.FunImageColumn.Name = "FunImageColumn";
            // 
            // FunTimeColumn
            // 
            this.FunTimeColumn.DataPropertyName = "FunTime";
            this.FunTimeColumn.HeaderText = "Время";
            this.FunTimeColumn.Items.AddRange(new object[] {
            "5 мин",
            "10 мин",
            "30 мин",
            "60 мин"});
            this.FunTimeColumn.Name = "FunTimeColumn";
            this.FunTimeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FunTimeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FunStatusColumn
            // 
            this.FunStatusColumn.DataPropertyName = "FunStatus";
            this.FunStatusColumn.HeaderText = "Статус";
            this.FunStatusColumn.Name = "FunStatusColumn";
            // 
            // funListTableBindingSource
            // 
            this.funListTableBindingSource.DataMember = "FunListTable";
            this.funListTableBindingSource.DataSource = this.funListDBDataSet;
            // 
            // funListDBDataSet
            // 
            this.funListDBDataSet.DataSetName = "FunListDBDataSet";
            this.funListDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewImageColumn1.FillWeight = 105.9645F;
            this.dataGridViewImageColumn1.HeaderText = "Изображение";
            this.dataGridViewImageColumn1.Image = global::FunHour.Properties.Resources.free_icon_check_5610944;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 190;
            // 
            // funListTableTableAdapter
            // 
            this.funListTableTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frm_FunList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_FunList);
            this.Controls.Add(this.ts_TopMenu);
            this.Name = "frm_FunList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список развлечений";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_FunList_FormClosing);
            this.Load += new System.EventHandler(this.frm_FunList_Load);
            this.ts_TopMenu.ResumeLayout(false);
            this.ts_TopMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FunList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funListTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funListDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip ts_TopMenu;
        internal System.Windows.Forms.ToolStripButton tsb_AddFun;
        internal System.Windows.Forms.ToolStripButton tsb_EditFun;
        internal System.Windows.Forms.ToolStripButton tsb_DelFun;
        private System.Windows.Forms.DataGridView dgv_FunList;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private FunListDBDataSet funListDBDataSet;
        private System.Windows.Forms.BindingSource funListTableBindingSource;
        private FunListDBDataSetTableAdapters.FunListTableTableAdapter funListTableTableAdapter;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FunIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FunNameColumn;
        private System.Windows.Forms.DataGridViewImageColumn FunImageColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn FunTimeColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn FunStatusColumn;
    }
}