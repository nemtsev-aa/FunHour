using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunHour
{
    public partial class frm_Home : Form
    {
        public ImageList FunImageList;
        public int SelectionTime;
        public frm_Home()
        {
            InitializeComponent();
            
        }
        private void frm_Home_Load(object sender, EventArgs e)
        {
            foreach (var item in this.Controls) //обходим все элементы формы
            {
                if (item is Button) // проверяем, что это кнопка
                {
                    ((Button)item).Click += CommonBtn_Click; //приводим к типу и устанавливаем обработчик события  
                }
            }
        }
        private void tsb_FunList_Click(object sender, EventArgs e)
        {
            frm_FunList frm_FunList = new frm_FunList();
            frm_FunList.Owner = this;
            frm_FunList.SelectionTime = SelectionTime;
            frm_FunList.Show();
        }

        private void tsb_Settings_Click(object sender, EventArgs e)
        {
            frm_Settings frm_Settings = new frm_Settings();
            frm_Settings.Owner = this;
            frm_Settings.Show();
        }

        private void tsb_Select_Click(object sender, EventArgs e)
        {
            pictureBox1_Click(null, null);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (SelectionTime == 0)
            {
                MessageBox.Show(
                          "Время не выбрано!",
                          "Ошибка",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Error,
                          MessageBoxDefaultButton.Button1,
                          MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            {
                frm_FunList frm_FunList = new frm_FunList();
                frm_FunList.SelectionTime = SelectionTime;
                frm_FunList.LoadingData();
                FunImageList = frm_FunList.FunImageList;

                if (FunImageList.Images.Count > 0)
                {
                    frm_Select frm_Select = new frm_Select();
                    frm_Select.Owner = this;
                    frm_Select.SelectionTime = SelectionTime;
                    frm_Select.FunImageList = FunImageList;
                    frm_Select.Show();
                }
                else
                {
                    MessageBox.Show(
                          "Отсутствуют развлечения с выбранным интервалом времени!",
                          "Ошибка",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Error,
                          MessageBoxDefaultButton.Button1,
                          MessageBoxOptions.DefaultDesktopOnly);
                }

            }
        }

        private void CommonBtn_Click(object sender, EventArgs e)
        {
            string SelectionTimeValue = ((Button)sender).Text;
            string TimeValue = SelectionTimeValue.Replace(" мин", "");
            SelectionTime = int.Parse(TimeValue);
            MarkButton();
            ((Button)sender).BackColor = Color.FromArgb(242, 70, 70);
        }

        private void MarkButton()
        {
            foreach (var item in this.Controls) //обходим все элементы формы
            {
                if (item is Button) // проверяем, что это кнопка
                {
                    ((Button)item).BackColor = Color.White;
                }
            }
        }
    }
}
