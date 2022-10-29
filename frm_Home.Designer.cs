
namespace FunHour
{
    partial class frm_Home
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Home));
            this.b_Part1 = new System.Windows.Forms.Button();
            this.b_Part2 = new System.Windows.Forms.Button();
            this.b_Part3 = new System.Windows.Forms.Button();
            this.b_Part4 = new System.Windows.Forms.Button();
            this.ts_HomeMenu = new System.Windows.Forms.ToolStrip();
            this.tsb_FunList = new System.Windows.Forms.ToolStripButton();
            this.tsb_Select = new System.Windows.Forms.ToolStripButton();
            this.tsb_Settings = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsl_WorkTime = new System.Windows.Forms.ToolStripLabel();
            this.ts_HomeMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // b_Part1
            // 
            this.b_Part1.Location = new System.Drawing.Point(58, 255);
            this.b_Part1.Name = "b_Part1";
            this.b_Part1.Size = new System.Drawing.Size(90, 50);
            this.b_Part1.TabIndex = 1;
            this.b_Part1.Text = "5 мин";
            this.b_Part1.UseVisualStyleBackColor = true;
            // 
            // b_Part2
            // 
            this.b_Part2.Location = new System.Drawing.Point(58, 101);
            this.b_Part2.Name = "b_Part2";
            this.b_Part2.Size = new System.Drawing.Size(90, 50);
            this.b_Part2.TabIndex = 3;
            this.b_Part2.Text = "10 мин";
            this.b_Part2.UseVisualStyleBackColor = true;
            // 
            // b_Part3
            // 
            this.b_Part3.Location = new System.Drawing.Point(239, 101);
            this.b_Part3.Name = "b_Part3";
            this.b_Part3.Size = new System.Drawing.Size(90, 50);
            this.b_Part3.TabIndex = 4;
            this.b_Part3.Text = "30 мин";
            this.b_Part3.UseVisualStyleBackColor = true;
            // 
            // b_Part4
            // 
            this.b_Part4.Location = new System.Drawing.Point(239, 255);
            this.b_Part4.Name = "b_Part4";
            this.b_Part4.Size = new System.Drawing.Size(90, 50);
            this.b_Part4.TabIndex = 5;
            this.b_Part4.Text = "60 мин";
            this.b_Part4.UseVisualStyleBackColor = true;
            // 
            // ts_HomeMenu
            // 
            this.ts_HomeMenu.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ts_HomeMenu.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.ts_HomeMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_FunList,
            this.tsb_Select,
            this.tsb_Settings,
            this.toolStripSeparator1,
            this.tsl_WorkTime});
            this.ts_HomeMenu.Location = new System.Drawing.Point(0, 0);
            this.ts_HomeMenu.Name = "ts_HomeMenu";
            this.ts_HomeMenu.Size = new System.Drawing.Size(390, 37);
            this.ts_HomeMenu.TabIndex = 6;
            this.ts_HomeMenu.Text = "toolStrip1";
            // 
            // tsb_FunList
            // 
            this.tsb_FunList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_FunList.Image = global::FunHour.Properties.Resources.free_icon_paper_sheet_5607410;
            this.tsb_FunList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_FunList.Name = "tsb_FunList";
            this.tsb_FunList.Size = new System.Drawing.Size(34, 34);
            this.tsb_FunList.Text = "Список развлечений";
            this.tsb_FunList.Click += new System.EventHandler(this.tsb_FunList_Click);
            // 
            // tsb_Select
            // 
            this.tsb_Select.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Select.Image = global::FunHour.Properties.Resources.feature_selection;
            this.tsb_Select.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Select.Name = "tsb_Select";
            this.tsb_Select.Size = new System.Drawing.Size(34, 34);
            this.tsb_Select.Text = "Выбор развлечения";
            this.tsb_Select.Click += new System.EventHandler(this.tsb_Select_Click);
            // 
            // tsb_Settings
            // 
            this.tsb_Settings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Settings.Image = global::FunHour.Properties.Resources.setup;
            this.tsb_Settings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Settings.Name = "tsb_Settings";
            this.tsb_Settings.Size = new System.Drawing.Size(34, 34);
            this.tsb_Settings.Text = "Настройки";
            this.tsb_Settings.Click += new System.EventHandler(this.tsb_Settings_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(367, 234);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // tsl_WorkTime
            // 
            this.tsl_WorkTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsl_WorkTime.Name = "tsl_WorkTime";
            this.tsl_WorkTime.Size = new System.Drawing.Size(96, 34);
            this.tsl_WorkTime.Text = "00:00:00";
            this.tsl_WorkTime.ToolTipText = "Время до следующего отдыха";
            // 
            // frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(390, 365);
            this.Controls.Add(this.b_Part1);
            this.Controls.Add(this.ts_HomeMenu);
            this.Controls.Add(this.b_Part4);
            this.Controls.Add(this.b_Part3);
            this.Controls.Add(this.b_Part2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frm_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ПотехеЧас";
            this.Load += new System.EventHandler(this.frm_Home_Load);
            this.ts_HomeMenu.ResumeLayout(false);
            this.ts_HomeMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button b_Part1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button b_Part2;
        private System.Windows.Forms.Button b_Part3;
        private System.Windows.Forms.Button b_Part4;
        private System.Windows.Forms.ToolStrip ts_HomeMenu;
        private System.Windows.Forms.ToolStripButton tsb_FunList;
        private System.Windows.Forms.ToolStripButton tsb_Select;
        private System.Windows.Forms.ToolStripButton tsb_Settings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tsl_WorkTime;
    }
}

