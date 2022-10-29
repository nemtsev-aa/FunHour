using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Globalization;

namespace FunHour
{
    public partial class frm_Select : Form
    {
        int m;
        int s;
        bool SelectStatus;
        public ImageList FunImageList;

        public DateTime StartFun = new DateTime();
        public DateTime EndFun = new DateTime();
        public TimeSpan timeValue = new TimeSpan();

        public int SelectionTime;
        public frm_Select()
        {
            InitializeComponent();
        }
        private void frm_Select_Load(object sender, EventArgs e)
        {
            SelectStatus = false;
            timer1.Interval = 100;
            timer1.Start();
            lab_FreeTimeValue.Text = new TimeSpan(0, SelectionTime,0).ToString(@"hh\:mm\:ss");

        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
           if (SelectStatus)
            {
                timeValue = EndFun - DateTime.Now;

                if (timeValue <= new TimeSpan(0,0,0))
                {
                    timer1.Stop();
                
                    MessageBox.Show(
                        "Отдых подошёл к концу!",
                        "Информация",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                }
                else
                {
                    lab_FreeTimeValue.Text = timeValue.ToString(@"hh\:mm\:ss");
                    pgb_FreeTime.PerformStep();
                }
            }
           else
           {
                
                //Создание объекта для генерации чисел
                Random rnd = new Random();
                //Получить случайное число (в диапазоне от 0 до 10)
                int value = rnd.Next(0, FunImageList.Images.Count);

                this.pb_Fun2.Image = FunImageList.Images[value];
                    

            }
        }

        private void pb_Fun2_Click(object sender, EventArgs e)
        {
            SelectStatus = true;
            timer1.Stop();
            timer1.Interval = 1000;

            StartFun = DateTime.Now;
            EndFun = StartFun.AddMinutes(SelectionTime);
            timeValue = EndFun - StartFun;

            frm_Home frm_Home = (frm_Home)Owner;

            lab_FreeTimeValue.Text = timeValue.ToString(@"hh\:mm\:ss");

            m = SelectionTime;
            s = SelectionTime * 60;
            pgb_FreeTime.Maximum = s;

            timer1.Start();
        }
    }       
    }
