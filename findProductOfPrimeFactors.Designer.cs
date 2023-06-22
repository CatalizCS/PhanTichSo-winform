namespace Thuc_Hanh_2_bai_1
{
    partial class findProductOfPrimeFactors
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
            label1 = new Label();
            input_box = new TextBox();
            label2 = new Label();
            Analysis_BTN = new Button();
            AddLow_BTN = new Button();
            AddHigh_BTN = new Button();
            LIST_BTN = new Button();
            menuStrip1 = new MenuStrip();
            mENUToolStripMenuItem = new ToolStripMenuItem();
            convertNumberToolStripMenuItem = new ToolStripMenuItem();
            findProductOfPrimeFactorsToolStripMenuItem = new ToolStripMenuItem();
            generateNumberToolStripMenuItem = new ToolStripMenuItem();
            result_box = new TextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(24, 77);
            label1.Name = "label1";
            label1.Size = new Size(55, 33);
            label1.TabIndex = 0;
            label1.Text = "N =";
            // 
            // input_box
            // 
            input_box.Location = new Point(77, 77);
            input_box.Multiline = true;
            input_box.Name = "input_box";
            input_box.Size = new Size(165, 33);
            input_box.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(95, 34);
            label2.Name = "label2";
            label2.Size = new Size(198, 33);
            label2.TabIndex = 0;
            label2.Text = "PHÂN TÍCH SỐ";
            // 
            // Analysis_BTN
            // 
            Analysis_BTN.BackColor = SystemColors.Highlight;
            Analysis_BTN.BackgroundImageLayout = ImageLayout.None;
            Analysis_BTN.CausesValidation = false;
            Analysis_BTN.ForeColor = Color.White;
            Analysis_BTN.Location = new Point(248, 77);
            Analysis_BTN.Name = "Analysis_BTN";
            Analysis_BTN.Size = new Size(108, 33);
            Analysis_BTN.TabIndex = 2;
            Analysis_BTN.Text = "Phân Tích";
            Analysis_BTN.UseVisualStyleBackColor = false;
            Analysis_BTN.Click += Analysis_Clicked;
            // 
            // AddLow_BTN
            // 
            AddLow_BTN.BackColor = SystemColors.Highlight;
            AddLow_BTN.BackgroundImageLayout = ImageLayout.None;
            AddLow_BTN.ForeColor = Color.White;
            AddLow_BTN.Location = new Point(24, 126);
            AddLow_BTN.Name = "AddLow_BTN";
            AddLow_BTN.Size = new Size(108, 46);
            AddLow_BTN.TabIndex = 2;
            AddLow_BTN.Text = "Phát Sinh N <= 32767";
            AddLow_BTN.UseVisualStyleBackColor = false;
            AddLow_BTN.Click += AddLow_Clicked;
            // 
            // AddHigh_BTN
            // 
            AddHigh_BTN.BackColor = SystemColors.Highlight;
            AddHigh_BTN.BackgroundImageLayout = ImageLayout.None;
            AddHigh_BTN.ForeColor = Color.White;
            AddHigh_BTN.Location = new Point(134, 126);
            AddHigh_BTN.Name = "AddHigh_BTN";
            AddHigh_BTN.Size = new Size(108, 46);
            AddHigh_BTN.TabIndex = 2;
            AddHigh_BTN.Text = "Phát Sinh N > 32767";
            AddHigh_BTN.UseVisualStyleBackColor = false;
            AddHigh_BTN.Click += AddHigh_Clicked;
            // 
            // LIST_BTN
            // 
            LIST_BTN.BackColor = SystemColors.Highlight;
            LIST_BTN.BackgroundImageLayout = ImageLayout.None;
            LIST_BTN.ForeColor = Color.White;
            LIST_BTN.Location = new Point(248, 126);
            LIST_BTN.Name = "LIST_BTN";
            LIST_BTN.Size = new Size(108, 46);
            LIST_BTN.TabIndex = 2;
            LIST_BTN.Text = "Liệt Kê Ước Số";
            LIST_BTN.UseVisualStyleBackColor = false;
            LIST_BTN.Click += LIST_Clicked;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mENUToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(388, 24);
            menuStrip1.TabIndex = 6;
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
            convertNumberToolStripMenuItem.Click += convertNumberTool_Clicked;
            // 
            // findProductOfPrimeFactorsToolStripMenuItem
            // 
            findProductOfPrimeFactorsToolStripMenuItem.Enabled = false;
            findProductOfPrimeFactorsToolStripMenuItem.Name = "findProductOfPrimeFactorsToolStripMenuItem";
            findProductOfPrimeFactorsToolStripMenuItem.Size = new Size(233, 22);
            findProductOfPrimeFactorsToolStripMenuItem.Text = "Find Product Of Prime Factors";
            // 
            // generateNumberToolStripMenuItem
            // 
            generateNumberToolStripMenuItem.Name = "generateNumberToolStripMenuItem";
            generateNumberToolStripMenuItem.Size = new Size(233, 22);
            generateNumberToolStripMenuItem.Text = "Generate Number";
            generateNumberToolStripMenuItem.Click += generateNumberTool_Clicked;
            // 
            // result_box
            // 
            result_box.Font = new Font("Montserrat SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            result_box.Location = new Point(27, 189);
            result_box.Multiline = true;
            result_box.Name = "result_box";
            result_box.ScrollBars = ScrollBars.Vertical;
            result_box.Size = new Size(329, 63);
            result_box.TabIndex = 7;
            // 
            // findProductOfPrimeFactors
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(388, 283);
            Controls.Add(result_box);
            Controls.Add(menuStrip1);
            Controls.Add(LIST_BTN);
            Controls.Add(AddHigh_BTN);
            Controls.Add(AddLow_BTN);
            Controls.Add(Analysis_BTN);
            Controls.Add(input_box);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "findProductOfPrimeFactors";
            Text = "Phân Tích Số";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox input_box;
        private Label label2;
        private Button Analysis_BTN;
        private Button AddLow_BTN;
        private Button AddHigh_BTN;
        private Button LIST_BTN;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mENUToolStripMenuItem;
        private ToolStripMenuItem convertNumberToolStripMenuItem;
        private ToolStripMenuItem findProductOfPrimeFactorsToolStripMenuItem;
        private ToolStripMenuItem generateNumberToolStripMenuItem;
        private TextBox result_box;
    }
}