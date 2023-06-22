namespace Thuc_Hanh_2_bai_1
{
    partial class convertNumber
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
            label1 = new Label();
            input_box = new TextBox();
            panel1 = new Panel();
            label2 = new Label();
            result_box = new TextBox();
            menuStrip1 = new MenuStrip();
            mENUToolStripMenuItem = new ToolStripMenuItem();
            convertNumberToolStripMenuItem = new ToolStripMenuItem();
            findProductOfPrimeFactorsToolStripMenuItem = new ToolStripMenuItem();
            generateNumberToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(62, 24);
            label1.Name = "label1";
            label1.Size = new Size(219, 33);
            label1.TabIndex = 0;
            label1.Text = "CHUYỂN ĐỔI SỐ";
            // 
            // input_box
            // 
            input_box.BorderStyle = BorderStyle.None;
            input_box.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            input_box.Location = new Point(62, 60);
            input_box.Multiline = true;
            input_box.Name = "input_box";
            input_box.Size = new Size(219, 25);
            input_box.TabIndex = 1;
            input_box.TextChanged += Input_box_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Location = new Point(62, 83);
            panel1.Name = "panel1";
            panel1.Size = new Size(219, 2);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(125, 104);
            label2.Name = "label2";
            label2.Size = new Size(89, 22);
            label2.TabIndex = 3;
            label2.Text = "KẾT QUẢ ";
            // 
            // result_box
            // 
            result_box.Location = new Point(62, 129);
            result_box.Multiline = true;
            result_box.Name = "result_box";
            result_box.Size = new Size(219, 89);
            result_box.TabIndex = 4;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mENUToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(345, 24);
            menuStrip1.TabIndex = 5;
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
            convertNumberToolStripMenuItem.Enabled = false;
            convertNumberToolStripMenuItem.Name = "convertNumberToolStripMenuItem";
            convertNumberToolStripMenuItem.Size = new Size(233, 22);
            convertNumberToolStripMenuItem.Text = "Convert Number";
            // 
            // findProductOfPrimeFactorsToolStripMenuItem
            // 
            findProductOfPrimeFactorsToolStripMenuItem.Name = "findProductOfPrimeFactorsToolStripMenuItem";
            findProductOfPrimeFactorsToolStripMenuItem.Size = new Size(233, 22);
            findProductOfPrimeFactorsToolStripMenuItem.Text = "Find Product Of Prime Factors";
            findProductOfPrimeFactorsToolStripMenuItem.Click += findProductOfPrimeFactors_Clicked;
            // 
            // generateNumberToolStripMenuItem
            // 
            generateNumberToolStripMenuItem.Name = "generateNumberToolStripMenuItem";
            generateNumberToolStripMenuItem.Size = new Size(233, 22);
            generateNumberToolStripMenuItem.Text = "Generate Number";
            generateNumberToolStripMenuItem.Click += generateNumber_Clicked;
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(345, 255);
            Controls.Add(result_box);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(input_box);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Name = "main";
            Text = "Chuyển Đổi Số";
            Load += main_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox input_box;
        private Panel panel1;
        private Label label2;
        private TextBox result_box;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mENUToolStripMenuItem;
        private ToolStripMenuItem convertNumberToolStripMenuItem;
        private ToolStripMenuItem findProductOfPrimeFactorsToolStripMenuItem;
        private ToolStripMenuItem generateNumberToolStripMenuItem;
    }
}