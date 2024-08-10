
namespace Change_name_ext_via_two_folders
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txt_Folder1 = new System.Windows.Forms.TextBox();
            this.btn_FBD1 = new System.Windows.Forms.Button();
            this.btn_FBD2 = new System.Windows.Forms.Button();
            this.txt_Folder2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.gopro = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Folder 1 :";
            this.toolTip1.SetToolTip(this.label1, "پوشه تغییر کننده");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "&Folder 2 :";
            this.toolTip1.SetToolTip(this.label2, "پوشه منبع");
            // 
            // txt_Folder1
            // 
            this.txt_Folder1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_Folder1.Enabled = false;
            this.txt_Folder1.Location = new System.Drawing.Point(133, 6);
            this.txt_Folder1.Name = "txt_Folder1";
            this.txt_Folder1.Size = new System.Drawing.Size(277, 29);
            this.txt_Folder1.TabIndex = 2;
            // 
            // btn_FBD1
            // 
            this.btn_FBD1.Location = new System.Drawing.Point(416, 6);
            this.btn_FBD1.Name = "btn_FBD1";
            this.btn_FBD1.Size = new System.Drawing.Size(60, 29);
            this.btn_FBD1.TabIndex = 3;
            this.btn_FBD1.Text = "Go";
            this.btn_FBD1.UseVisualStyleBackColor = true;
            this.btn_FBD1.Click += new System.EventHandler(this.btn_FBD1_Click);
            // 
            // btn_FBD2
            // 
            this.btn_FBD2.Location = new System.Drawing.Point(416, 41);
            this.btn_FBD2.Name = "btn_FBD2";
            this.btn_FBD2.Size = new System.Drawing.Size(60, 29);
            this.btn_FBD2.TabIndex = 5;
            this.btn_FBD2.Text = "Go";
            this.btn_FBD2.UseVisualStyleBackColor = true;
            this.btn_FBD2.Click += new System.EventHandler(this.btn_FBD2_Click);
            // 
            // txt_Folder2
            // 
            this.txt_Folder2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_Folder2.Enabled = false;
            this.txt_Folder2.Location = new System.Drawing.Point(133, 41);
            this.txt_Folder2.Name = "txt_Folder2";
            this.txt_Folder2.Size = new System.Drawing.Size(277, 29);
            this.txt_Folder2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "&Extension  :";
            // 
            // comboBox
            // 
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "*.mp3",
            "*.mp4",
            "*.avi",
            "*.jpg",
            "*.png"});
            this.comboBox.Location = new System.Drawing.Point(133, 76);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(343, 32);
            this.comboBox.TabIndex = 8;
            // 
            // gopro
            // 
            this.gopro.Location = new System.Drawing.Point(19, 114);
            this.gopro.Name = "gopro";
            this.gopro.Size = new System.Drawing.Size(457, 65);
            this.gopro.TabIndex = 9;
            this.gopro.Text = "Go Processing";
            this.gopro.UseVisualStyleBackColor = true;
            this.gopro.Click += new System.EventHandler(this.gopro_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(488, 183);
            this.Controls.Add(this.gopro);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_FBD2);
            this.Controls.Add(this.txt_Folder2);
            this.Controls.Add(this.btn_FBD1);
            this.Controls.Add(this.txt_Folder1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rename App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txt_Folder1;
        private System.Windows.Forms.Button btn_FBD1;
        private System.Windows.Forms.Button btn_FBD2;
        private System.Windows.Forms.TextBox txt_Folder2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button gopro;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

