using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Change_name_ext_via_two_folders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FolderBrowserDialog FBD1 = new FolderBrowserDialog();
        FolderBrowserDialog FBD2 = new FolderBrowserDialog();

        private void btn_FBD1_Click(object sender, EventArgs e)
        {
            FBD1.ShowNewFolderButton = true;
            DialogResult result = FBD1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txt_Folder1.Text = FBD1.SelectedPath;
                Environment.SpecialFolder root = FBD1.RootFolder;
            }
        }

        private void btn_FBD2_Click(object sender, EventArgs e)
        {
            FBD2.ShowNewFolderButton = true;
            DialogResult result = FBD2.ShowDialog();
            if (result == DialogResult.OK)
            {
                txt_Folder2.Text = FBD2.SelectedPath;
                Environment.SpecialFolder root = FBD2.RootFolder;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox.SelectedIndex = 0;
        }

        private void gopro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Folder1.Text))
            {
                MessageBox.Show("مسیر پوشه اول وارد نشده است", "پوشه اول", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_FBD1.Focus();
            }
            else if (string.IsNullOrEmpty(txt_Folder2.Text))
            {
                MessageBox.Show("مسیر پوشه دوم وارد نشده است", "پوشه دوم", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_FBD2.Focus();
            }
            else if (txt_Folder1.Text == txt_Folder2.Text)
            {
                MessageBox.Show("مسیر ها یکیست", "خطا!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Folder1.Clear();
                txt_Folder2.Clear();
                btn_FBD1.Focus();
            }
            else
            {
                changer(txt_Folder1, txt_Folder2, comboBox);
                MessageBox.Show("انجام شد.","تکمیل",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Application.Exit();
            }
        }


        static void changer(TextBox txt_Folder1, TextBox txt_Folder2, ComboBox comboBox)
        {
            // مسیر پوشه‌ها
            string folder1 = txt_Folder1.Text;
            string folder2 = txt_Folder2.Text;

            string ext = comboBox.SelectedItem.ToString();

            // خواندن نام فایل‌های هر دو پوشه
            string[] files1 = Directory.GetFiles(folder1, ext);
            string[] files2 = Directory.GetFiles(folder2, ext);

            Form1 f1 = new Form1();

            string f1text = f1.Text;

            // ساختن یک دیکشنری برای نگه‌داری نام فایل‌های پوشه دوم بر اساس عدد فایل
            var fileMap = new Dictionary<int, string>(); // استفاده از عدد صحیح به عنوان کلید
            Regex pattern = new Regex(@"(\d+)" + ext.Replace("*", string.Empty));
            Regex pattern2 = new Regex(@"^(\d{1,3})_"); // الگوی جدید برای فایل‌های شما

            foreach (string file in files2)
            {
                Match match = pattern2.Match(Path.GetFileName(file));
                if (match.Success)
                {
                    int number = int.Parse(match.Groups[1].Value); // تبدیل به عدد صحیح
                    fileMap[number] = Path.GetFileName(file);
                }
            }

            // تغییر نام فایل‌های پوشه اول
            foreach (string file in files1)
            {
                Match match = pattern.Match(Path.GetFileName(file));
                if (match.Success)
                {
                    int number = int.Parse(match.Groups[1].Value); // تبدیل به عدد صحیح
                    if (fileMap.ContainsKey(number))
                    {
                        string newName = fileMap[number];
                        string oldPath = Path.Combine(folder1, Path.GetFileName(file));
                        string newPath = Path.Combine(folder1, newName);
                        File.Move(oldPath, newPath);
                        f1.Text = f1text + $"Renamed: {Path.GetFileName(file)} -> {newName}";
                    }
                }
            }
        }


    }
}
