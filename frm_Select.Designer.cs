
namespace FunHour
{
    partial class frm_Select
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
            this.pgb_FreeTime = new System.Windows.Forms.ProgressBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb_Fun2 = new System.Windows.Forms.PictureBox();
            this.lab_FreeTimeValue = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Fun2)).BeginInit();
            this.SuspendLayout();
            // 
            // pgb_FreeTime
            // 
            this.pgb_FreeTime.BackColor = System.Drawing.Color.White;
            this.pgb_FreeTime.ForeColor = System.Drawing.Color.Lime;
            this.pgb_FreeTime.Location = new System.Drawing.Point(34, 270);
            this.pgb_FreeTime.Name = "pgb_FreeTime";
            this.pgb_FreeTime.Size = new System.Drawing.Size(312, 28);
            this.pgb_FreeTime.Step = 1;
            this.pgb_FreeTime.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgb_FreeTime.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::FunHour.Properties.Resources.left_arrow;
            this.pictureBox2.Location = new System.Drawing.Point(296, 103);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::FunHour.Properties.Resources.right_arrow;
            this.pictureBox1.Location = new System.Drawing.Point(34, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pb_Fun2
            // 
            this.pb_Fun2.Location = new System.Drawing.Point(90, 29);
            this.pb_Fun2.Name = "pb_Fun2";
            this.pb_Fun2.Size = new System.Drawing.Size(200, 200);
            this.pb_Fun2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Fun2.TabIndex = 0;
            this.pb_Fun2.TabStop = false;
            this.pb_Fun2.Click += new System.EventHandler(this.pb_Fun2_Click);
            // 
            // lab_FreeTimeValue
            // 
            this.lab_FreeTimeValue.AutoSize = true;
            this.lab_FreeTimeValue.BackColor = System.Drawing.Color.White;
            this.lab_FreeTimeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab_FreeTimeValue.Location = new System.Drawing.Point(166, 276);
            this.lab_FreeTimeValue.Name = "lab_FreeTimeValue";
            this.lab_FreeTimeValue.Size = new System.Drawing.Size(49, 16);
            this.lab_FreeTimeValue.TabIndex = 6;
            this.lab_FreeTimeValue.Text = "0:00:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frm_Select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(390, 365);
            this.Controls.Add(this.pb_Fun2);
            this.Controls.Add(this.lab_FreeTimeValue);
            this.Controls.Add(this.pgb_FreeTime);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frm_Select";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор развлечения";
            this.Load += new System.EventHandler(this.frm_Select_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Fun2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Fun2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lab_FreeTimeValue;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar pgb_FreeTime;
    }
}