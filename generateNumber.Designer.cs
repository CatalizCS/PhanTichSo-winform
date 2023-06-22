namespace Thuc_Hanh_2_bai_1
{
    partial class generateNumber
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
            Analysis_BTN = new Button();
            input_box = new TextBox();
            label2 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            menuStrip1 = new MenuStrip();
            mENUToolStripMenuItem = new ToolStripMenuItem();
            convertNumberToolStripMenuItem = new ToolStripMenuItem();
            findProductOfPrimeFactorsToolStripMenuItem = new ToolStripMenuItem();
            generateNumberToolStripMenuItem = new ToolStripMenuItem();
            listView1 = new ListView();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Analysis_BTN
            // 
            Analysis_BTN.BackColor = SystemColors.Highlight;
            Analysis_BTN.BackgroundImageLayout = ImageLayout.None;
            Analysis_BTN.CausesValidation = false;
            Analysis_BTN.ForeColor = Color.White;
            Analysis_BTN.Location = new Point(13, 126);
            Analysis_BTN.Name = "Analysis_BTN";
            Analysis_BTN.Size = new Size(126, 33);
            Analysis_BTN.TabIndex = 6;
            Analysis_BTN.Text = "Phát Sinh";
            Analysis_BTN.UseVisualStyleBackColor = false;
            Analysis_BTN.Click += random_BTN;
            // 
            // input_box
            // 
            input_box.Location = new Point(52, 73);
            input_box.Multiline = true;
            input_box.Name = "input_box";
            input_box.Size = new Size(87, 18);
            input_box.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(52, 24);
            label2.Name = "label2";
            label2.Size = new Size(240, 33);
            label2.TabIndex = 3;
            label2.Text = "Generate Number";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 70);
            label1.Name = "label1";
            label1.Size = new Size(38, 22);
            label1.TabIndex = 4;
            label1.Text = "N =";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Số Nguyên Tố", "Số Chính Phương", "Số Đối Xứng" });
            comboBox1.Location = new Point(13, 97);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(126, 23);
            comboBox1.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.CausesValidation = false;
            button1.ForeColor = Color.White;
            button1.Location = new Point(13, 165);
            button1.Name = "button1";
            button1.Size = new Size(126, 33);
            button1.TabIndex = 6;
            button1.Text = "Xóa Số";
            button1.UseVisualStyleBackColor = false;
            button1.Click += delete_BTN;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Highlight;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.CausesValidation = false;
            button2.ForeColor = Color.White;
            button2.Location = new Point(13, 204);
            button2.Name = "button2";
            button2.Size = new Size(126, 33);
            button2.TabIndex = 6;
            button2.Text = "Xóa Danh Sách";
            button2.UseVisualStyleBackColor = false;
            button2.Click += deleteList_BTN;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mENUToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(340, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // mENUToolStripMenuItem
            // 
            mENUToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { convertNumberToolStripMenuItem, findProductOfPrimeFactorsToolStripMenuItem, generateNumberToolStripMenuItem });
            mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            mENUToolStripMenuItem.Size = new Size(53, 20);
            mENUToolStripMenuItem.Text = "MENU";
            // 
            // convertNumberToolStripMenuItem
            // 
            convertNumberToolStripMenuItem.Name = "convertNumberToolStripMenuItem";
            convertNumberToolStripMenuItem.Size = new Size(233, 22);
            convertNumberToolStripMenuItem.Text = "Convert Number";
            convertNumberToolStripMenuItem.Click += convertNumberToolStripMenuItem_Click;
            // 
            // findProductOfPrimeFactorsToolStripMenuItem
            // 
            findProductOfPrimeFactorsToolStripMenuItem.Name = "findProductOfPrimeFactorsToolStripMenuItem";
            findProductOfPrimeFactorsToolStripMenuItem.Size = new Size(233, 22);
            findProductOfPrimeFactorsToolStripMenuItem.Text = "Find Product Of Prime Factors";
            findProductOfPrimeFactorsToolStripMenuItem.Click += findProductOfPrimeFactorsToolStripMenuItem_Click;
            // 
            // generateNumberToolStripMenuItem
            // 
            generateNumberToolStripMenuItem.Enabled = false;
            generateNumberToolStripMenuItem.Name = "generateNumberToolStripMenuItem";
            generateNumberToolStripMenuItem.Size = new Size(233, 22);
            generateNumberToolStripMenuItem.Text = "Generate Number";
            // 
            // listView1
            // 
            listView1.Location = new Point(153, 74);
            listView1.Name = "listView1";
            listView1.Size = new Size(165, 163);
            listView1.TabIndex = 9;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // generateNumber
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(340, 280);
            Controls.Add(listView1);
            Controls.Add(menuStrip1);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Analysis_BTN);
            Controls.Add(input_box);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "generateNumber";
            Text = "genarateNumber";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Analysis_BTN;
        private TextBox input_box;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mENUToolStripMenuItem;
        private ToolStripMenuItem convertNumberToolStripMenuItem;
        private ToolStripMenuItem findProductOfPrimeFactorsToolStripMenuItem;
        private ToolStripMenuItem generateNumberToolStripMenuItem;
        private ListView listView1;
    }
}