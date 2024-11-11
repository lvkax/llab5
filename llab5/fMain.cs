using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace llab5
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }


        private void fMain_Load(object sender, EventArgs e)
        {
            gvPhones.AutoGenerateColumns = false;

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Name";
            column.Name = "Назва";
            gvPhones.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Model";
            column.Name = "Модель";
            gvPhones.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Cost";
            column.Name = "Ціна ($)";
            gvPhones.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "ReleaseYear";
            column.Name = "Рік виходу";
            gvPhones.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "YearOfPurchase";
            column.Name = "Рік покупки";
            gvPhones.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "BatteryCapacity";
            column.Name = "Ємність акамулятору (mA/h)";
            gvPhones.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Has3Cameras";
            column.Name = "Три камери";
            gvPhones.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "HasWirelessCharging";
            column.Name = "Бездротова зарядка";
            gvPhones.Columns.Add(column);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SmartPhone phone = new SmartPhone();

            fPhone fp = new fPhone(phone);
            if (fp.ShowDialog() == DialogResult.OK)
            {
                bindScrPhones.Add(phone);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SmartPhone phone = (SmartPhone)bindScrPhones.List[bindScrPhones.Position];

            fPhone fp = new fPhone(phone);
            if (fp.ShowDialog() == DialogResult.OK)
            {
                bindScrPhones.List[bindScrPhones.Position] = phone;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Видалити поточний запис?", "Видалення запису",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                bindScrPhones.RemoveCurrent();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрити застосунок?", "Вихід з програми", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Очистити таблицю?\n\nВсі дані будуть втрачені", "Очищення даних",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bindScrPhones.Clear();
            }
        }

        private void bindScrPhones_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveAsText_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Текстовi файли (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.Title = "Зберегти данi у текстовому форматi";
            saveFileDialog.InitialDirectory = Application.StartupPath;
            StreamWriter sw;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                sw = new StreamWriter(saveFileDialog.FileName, false, Encoding.UTF8);
                try
                {
                    foreach (SmartPhone phone in bindScrPhones.List)
                    {
                        sw.Write(phone.Name + "\t" + phone.Model + "\t" + phone.Cost + "\t" +
                            phone.ReleaseYear + "\t" + phone.YearOfPurchase + "\t" +
                            phone.BatteryCapacity + "\t" + phone.Has3Cameras + "\t" + phone.HasWirelessCharging + "\t\n");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Сталась помилка:  \n{0}", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sw.Close();
                }
            }
        }

        private void btnSaveAsBinary_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Файли даних (*.phones)|*.phones|All files (*-*)|*.*";
            saveFileDialog.Title = "Зберегти данi у бiнарному форматi";
            saveFileDialog.InitialDirectory = Application.StartupPath;
            BinaryWriter bw;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                bw = new BinaryWriter(saveFileDialog.OpenFile());

                try
                {
                    foreach (SmartPhone phone in bindScrPhones.List)
                    {
                        bw.Write(phone.Name);
                        bw.Write(phone.Model);
                        bw.Write(phone.Cost);
                        bw.Write(phone.ReleaseYear);
                        bw.Write(phone.YearOfPurchase);
                        bw.Write(phone.BatteryCapacity);
                        bw.Write(phone.Has3Cameras);
                        bw.Write(phone.HasWirelessCharging);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Сталась помилка: \n{0}", ex.Message,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                finally
                {
                    bw.Close();
                }
            }
        }

        private void btnOpenFromText_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовi файли (*.txt)|*.txt|All files (**) | *.*";
            openFileDialog.Title = "Прочитати данi у текстовому форматi";
            openFileDialog.InitialDirectory = Application.StartupPath;
            StreamReader sr;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                bindScrPhones.Clear(); sr = new StreamReader(openFileDialog.FileName, Encoding.UTF8);
                string s;
                try
                {
                    while ((s = sr.ReadLine()) != null)
                    {
                        string[] split = s.Split('\t');
                        SmartPhone phone = new SmartPhone(split[0], split[1], split[2],
                        split[3], split[4], split[5],
                        bool.Parse(split[6]), bool.Parse(split[7]));
                        bindScrPhones.Add(phone);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Сталась помилка: \n{0}", ex.Message,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sr.Close();
                }
            }
        }

        private void btnOpenFromBinary_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Файли даних (*.phones)|*.phones|All files (**) | ** ";
            openFileDialog.Title = "Прочитати данi у бiнарному форматi";
            openFileDialog.InitialDirectory = Application.StartupPath;
            BinaryReader br;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                bindScrPhones.Clear();
                br = new BinaryReader(openFileDialog.OpenFile());
                try
                {
                    SmartPhone phone;
                    while (br.BaseStream.Position < br.BaseStream.Length)
                    {
                        phone = new SmartPhone();
                        for (int i = 1; i <= 8; i++)
                        {
                            switch (i)
                            {
                                case 1:
                                    phone.Name = br.ReadString();
                                    break;
                                case 2:
                                    phone.Model = br.ReadString();
                                    break;
                                case 3:
                                    phone.Cost = br.ReadString();
                                    break;
                                case 4:
                                    phone.ReleaseYear = br.ReadString();
                                    break;
                                case 5:
                                    phone.YearOfPurchase = br.ReadString();
                                    break;
                                case 6:
                                    phone.BatteryCapacity = br.ReadString();
                                    break;
                                case 7:
                                    phone.Has3Cameras = br.ReadBoolean();
                                    break;
                                case 8:
                                    phone.HasWirelessCharging = br.ReadBoolean();
                                    break;
                            }
                        }
                        bindScrPhones.Add(phone);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Сталась помилка: \n{0}", ex.Message,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    br.Close();
                }
            }

        }

    }

}
