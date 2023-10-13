namespace WinFormAnkets
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AdTb = new TextBox();
            listBox = new ListBox();
            label1 = new Label();
            label2 = new Label();
            SoyadTb = new TextBox();
            label3 = new Label();
            EmailTb = new TextBox();
            label4 = new Label();
            TelTb = new TextBox();
            label5 = new Label();
            DogumTb = new TextBox();
            Deyismek = new Button();
            YuklemekBt = new Button();
            SearchTb = new TextBox();
            label6 = new Label();
            LoadBt = new Button();
            SaveBt = new Button();
            SuspendLayout();
            // 
            // AdTb
            // 
            AdTb.Location = new Point(11, 42);
            AdTb.Name = "AdTb";
            AdTb.Size = new Size(294, 27);
            AdTb.TabIndex = 0;
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 20;
            listBox.Location = new Point(528, 23);
            listBox.Name = "listBox";
            listBox.Size = new Size(221, 284);
            listBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(38, 28);
            label1.TabIndex = 2;
            label1.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(11, 81);
            label2.Name = "label2";
            label2.Size = new Size(69, 28);
            label2.TabIndex = 3;
            label2.Text = "Soyad";
            // 
            // SoyadTb
            // 
            SoyadTb.Location = new Point(3, 115);
            SoyadTb.Name = "SoyadTb";
            SoyadTb.Size = new Size(294, 27);
            SoyadTb.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(10, 158);
            label3.Name = "label3";
            label3.Size = new Size(64, 28);
            label3.TabIndex = 5;
            label3.Text = "Email";
            // 
            // EmailTb
            // 
            EmailTb.Location = new Point(10, 189);
            EmailTb.Name = "EmailTb";
            EmailTb.Size = new Size(295, 27);
            EmailTb.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(11, 229);
            label4.Name = "label4";
            label4.Size = new Size(39, 28);
            label4.TabIndex = 7;
            label4.Text = "Tel";
            // 
            // TelTb
            // 
            TelTb.Location = new Point(11, 260);
            TelTb.Name = "TelTb";
            TelTb.Size = new Size(294, 27);
            TelTb.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(10, 304);
            label5.Name = "label5";
            label5.Size = new Size(105, 28);
            label5.TabIndex = 9;
            label5.Text = "Dogum ili";
            // 
            // DogumTb
            // 
            DogumTb.Location = new Point(12, 335);
            DogumTb.Name = "DogumTb";
            DogumTb.Size = new Size(293, 27);
            DogumTb.TabIndex = 10;
            // 
            // Deyismek
            // 
            Deyismek.BackColor = Color.CornflowerBlue;
            Deyismek.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Deyismek.Location = new Point(10, 386);
            Deyismek.Name = "Deyismek";
            Deyismek.Size = new Size(123, 40);
            Deyismek.TabIndex = 11;
            Deyismek.Text = "Deyismek";
            Deyismek.UseVisualStyleBackColor = false;
            Deyismek.Visible = false;
            Deyismek.Click += Deyismek_Click_1;
            // 
            // YuklemekBt
            // 
            YuklemekBt.BackColor = Color.SpringGreen;
            YuklemekBt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            YuklemekBt.Location = new Point(177, 386);
            YuklemekBt.Name = "YuklemekBt";
            YuklemekBt.Size = new Size(128, 38);
            YuklemekBt.TabIndex = 12;
            YuklemekBt.Text = "Yuklemek";
            YuklemekBt.UseVisualStyleBackColor = false;
            YuklemekBt.Visible = false;
            YuklemekBt.Click += YuklemekBt_Click;
            // 
            // SearchTb
            // 
            SearchTb.Location = new Point(528, 349);
            SearchTb.Name = "SearchTb";
            SearchTb.Size = new Size(221, 27);
            SearchTb.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(528, 318);
            label6.Name = "label6";
            label6.Size = new Size(97, 28);
            label6.TabIndex = 14;
            label6.Text = "Failin adi";
            // 
            // LoadBt
            // 
            LoadBt.BackColor = Color.Pink;
            LoadBt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LoadBt.Location = new Point(529, 387);
            LoadBt.Name = "LoadBt";
            LoadBt.Size = new Size(96, 37);
            LoadBt.TabIndex = 15;
            LoadBt.Text = "Load";
            LoadBt.UseVisualStyleBackColor = false;
            LoadBt.Click += LoadBt_Click;
            // 
            // SaveBt
            // 
            SaveBt.BackColor = Color.Yellow;
            SaveBt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SaveBt.Location = new Point(645, 387);
            SaveBt.Name = "SaveBt";
            SaveBt.Size = new Size(104, 37);
            SaveBt.TabIndex = 16;
            SaveBt.Text = "Save";
            SaveBt.UseVisualStyleBackColor = false;
            SaveBt.Click += SaveBt_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(800, 450);
            Controls.Add(SaveBt);
            Controls.Add(LoadBt);
            Controls.Add(label6);
            Controls.Add(SearchTb);
            Controls.Add(YuklemekBt);
            Controls.Add(Deyismek);
            Controls.Add(DogumTb);
            Controls.Add(label5);
            Controls.Add(TelTb);
            Controls.Add(label4);
            Controls.Add(EmailTb);
            Controls.Add(label3);
            Controls.Add(SoyadTb);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox);
            Controls.Add(AdTb);
            Name = "Form1";
            Text = "Anket";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox AdTb;
        private ListBox listBox;
        private Label label1;
        private Label label2;
        private TextBox SoyadTb;
        private Label label3;
        private TextBox EmailTb;
        private Label label4;
        private TextBox TelTb;
        private Label label5;
        private TextBox DogumTb;
        private Button Deyismek;
        private Button YuklemekBt;
        private TextBox SearchTb;
        private Label label6;
        private Button LoadBt;
        private Button SaveBt;
    }
}