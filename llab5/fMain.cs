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
            using (PhoneType phoneTypeForm = new PhoneType())
            {
                if (phoneTypeForm.ShowDialog() == DialogResult.OK)
                {
                    Phone phone;

                    // Вибір типу телефону
                    if (phoneTypeForm.SelectedPhoneType == "SmartPhone")
                    {
                        phone = new SmartPhone();
                    }
                    else
                    {
                        phone = new BasicPhone();
                    }

                    // Відкриваємо форму для введення деталей телефону
                    using (fPhone fp = new fPhone(phone))
                    {
                        if (fp.ShowDialog() == DialogResult.OK)
                        {
                            bindScrPhones.Add(phone);
                        }
                    }
                }
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
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Текстові файли (*.txt)|*.txt|All files (*.*)|*.*",
                Title = "Прочитати дані у текстовому форматі",
                InitialDirectory = Application.StartupPath
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                bindScrPhones.Clear();
                using (StreamReader sr = new StreamReader(openFileDialog.FileName, Encoding.UTF8))
                {
                    string line;
                    try
                    {
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] split = line.Split('\t');
                            Phone phone;

                            if (split.Length > 5) // Умова, якщо це смартфон
                            {
                                phone = new SmartPhone
                                {
                                    Name = split[0],
                                    Model = split[1],
                                    Cost = split[2],
                                    ReleaseYear = split[3],
                                    YearOfPurchase = split[4],
                                    BatteryCapacity = split[5],
                                    Has3Cameras = bool.Parse(split[6]),
                                    HasWirelessCharging = bool.Parse(split[7])
                                };
                            }
                            else // Інакше - звичайний телефон
                            {
                                phone = new BasicPhone
                                {
                                    Name = split[0],
                                    Model = split[1],
                                    Cost = split[2],
                                    ReleaseYear = split[3],
                                    YearOfPurchase = split[4]
                                };
                            }

                            bindScrPhones.Add(phone);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Сталась помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnOpenFromBinary_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Файли даних (*.phones)|*.phones|All files (*.*)|*.*",
                Title = "Прочитати дані у бінарному форматі",
                InitialDirectory = Application.StartupPath
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                bindScrPhones.Clear();

                using (BinaryReader br = new BinaryReader(openFileDialog.OpenFile()))
                {
                    try
                    {
                        while (br.BaseStream.Position < br.BaseStream.Length)
                        {
                            // Читаємо основні поля, які спільні для всіх типів телефонів
                            string name = br.ReadString();
                            string model = br.ReadString();
                            string cost = br.ReadString();
                            string releaseYear = br.ReadString();
                            string yearOfPurchase = br.ReadString();

                            // Спробуємо зчитати додаткові поля для SmartPhone
                            try
                            {
                                string batteryCapacity = br.ReadString();
                                bool has3Cameras = br.ReadBoolean();
                                bool hasWirelessCharging = br.ReadBoolean();

                                // Якщо ми змогли прочитати ці поля, значить це SmartPhone
                                SmartPhone smartPhone = new SmartPhone
                                {
                                    Name = name,
                                    Model = model,
                                    Cost = cost,
                                    ReleaseYear = releaseYear,
                                    YearOfPurchase = yearOfPurchase,
                                    BatteryCapacity = batteryCapacity,
                                    Has3Cameras = has3Cameras,
                                    HasWirelessCharging = hasWirelessCharging
                                };
                                bindScrPhones.Add(smartPhone);
                            }
                            catch (EndOfStreamException)
                            {
                                // Якщо додаткові поля не прочитані, значить це BasicPhone
                                BasicPhone basicPhone = new BasicPhone
                                {
                                    Name = name,
                                    Model = model,
                                    Cost = cost,
                                    ReleaseYear = releaseYear,
                                    YearOfPurchase = yearOfPurchase
                                };
                                bindScrPhones.Add(basicPhone);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Сталась помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

    }

}
