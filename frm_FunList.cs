using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace FunHour
{
    public partial class frm_FunList : Form
 
    {
        public int SelectionTime;
        public ImageList FunImageList;

        public frm_FunList()
        {
            InitializeComponent();
            dgv_FunList.DataError += new DataGridViewDataErrorEventHandler(dgv_FunList_DataError);
            dgv_FunList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_FunList.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv_FunList.Columns[2].Width = 100;
            FunImageList = new ImageList();
            FunImageList.ImageSize = new Size(256, 256);
        }
        private void frm_FunList_Load(object sender, EventArgs e)
        {
            LoadingData();
        }
        public void LoadingData()
        {
            frm_Home frm_Home = this.Owner as frm_Home;
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "funListDBDataSet.FunListTable". При необходимости она может быть перемещена или удалена.
            this.funListTableTableAdapter.Fill(this.funListDBDataSet.FunListTable);
            DataTable FunListTable = this.funListDBDataSet.FunListTable;

            foreach (DataGridViewRow dtRow in this.dgv_FunList.Rows)
            {
                string FunTimeText = dtRow.Cells[3].Value.ToString();

                int FunTimeValue = int.Parse(FunTimeText.Replace(" мин", ""));
                if (FunTimeValue == SelectionTime)
                {
                    if ((bool)dtRow.Cells[4].Value == true)
                    {
                        Image iFunImage = byteArrayToImage((byte[])dtRow.Cells[2].Value);
                        FunImageList.Images.Add(iFunImage);
                    }
                }
            }
        }
        public Image byteArrayToImage(byte[] bytesArr)
        {
            using (MemoryStream memstr = new MemoryStream(bytesArr))
            {
                Image img = Image.FromStream(memstr);
                return img;
            }
        }
        private void tsb_AddFun_Click(object sender, EventArgs e)
        {
            //Переменная для работы с DataGridView
            DataGridView dgv = this.dgv_FunList;
            //Cнимаем текущее выделение
            dgv.ClearSelection();
            DataTable dtFunList = this.funListDBDataSet.FunListTable;
            DataRow NewRow = dtFunList.NewRow();
            //Добавляем новую строку в конец таблицы(источник данных для DGV)
          
            DataRow dr = dtFunList.NewRow();
            dr[0] = dtFunList.Rows.Count + 1;
            dr[1] = "";
            dr[2] = GetByteArray(Properties.Resources.free_icon_cancel_179429) as byte[];
            dr[3] = "";
            dr[4] = false;
            dtFunList.Rows.Add(dr);
            
            ///Перемещаем курсор на новую строку в первую ячейку
            dgv.CurrentCell = dgv[1, dgv.Rows.Count - 1];
            //Активируем режим редактирования
            this.tsb_EditFun.Checked = true;
        }
        public static byte[] GetByteArray(object obj)
        {
            if (obj == null)
                return null;
            BinaryFormatter bf = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream())
            {
                bf.Serialize(ms, obj);
                return ms.ToArray();
            }
        }

        private void dgv_FunList_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //MessageBox.Show("Ошибка ввода!");
            e.ThrowException = false;
        }

        private void dgv_FunList_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (this.tsb_EditFun.Checked == true)
            {
                //Переменная для работы с DataGridView
                DataGridView dgv = this.dgv_FunList;
                DataGridViewCell sCell = dgv.CurrentCell;

                if (sCell.ColumnIndex == 2)
                {
                    if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                        return;
                    // получаем выбранный файл
                    string filename = openFileDialog1.FileName;
                    Image image = new Bitmap(filename);
                    // читаем файл в строку
                    byte[] ImageFile = GetByteArray(filename);
                    sCell.Value = image;
                }
            }   
        }

        private void tsb_DelFun_Click(object sender, EventArgs e)
        {
            //Определем строку для удаления по выбранной ячейке
            DataGridViewRow sRow = this.dgv_FunList.Rows[dgv_FunList.CurrentCell.RowIndex];
            //Удаляем выбранную строку
            this.dgv_FunList.Rows.Remove(sRow);
            //Обновляем данные через адаптер
            funListTableTableAdapter.Update(this.funListDBDataSet.FunListTable);
        }

        private void frm_FunList_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Обновляем источник данных для DGV
            this.funListTableTableAdapter.Update(this.funListDBDataSet.FunListTable);
        }
    }
}


