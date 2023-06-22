using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Thuc_Hanh_2_bai_1
{
    public partial class generateNumber : Form
    {
        public generateNumber()
        {
            InitializeComponent();
        }

        private void random_BTN(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            int n = int.Parse(input_box.Text);
            int[] a = new int[n];

            switch (comboBox1.SelectedIndex)
            {
                case 0: // Số Nguyên Ngẫu Nhiên
                    Random rd = new Random();
                    for (int i = 0; i < n; i++)
                    {
                        a[i] = rd.Next(100);
                        String[] randomList = { a[i].ToString() };
                        var listItem = new ListViewItem(randomList);
                        listView1.Items.Add(listItem);
                    }
                    break;

                case 1: // Số Chính Phương
                    int j = 0;
                    for (int i = 0; i < n; i++)
                    {
                        a[i] = j * j;

                        String[] randomList = { a[i].ToString() };
                        var listItem = new ListViewItem(randomList);
                        listView1.Items.Add(listItem);
                        j++;
                    }
                    break;

                case 2: // Số đối xứng 
                    int k = 0;
                    for (int i = 0; i < n; i++)
                    {
                        a[i] = k;
                        String[] randomList = { a[i].ToString() };
                        var listItem = new ListViewItem(randomList);
                        listView1.Items.Add(listItem);
                        k++;
                    }
                    break;
            }
        }

        private void delete_BTN(object sender, EventArgs e)
        {
            // get index of selected row in listview and remove it
            for (int i = 0; i < listView1.SelectedItems.Count; i++)
            {
                listView1.Items.Remove(listView1.SelectedItems[i]);
            }
        }

        private void deleteList_BTN(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void mENUToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void convertNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new convertNumber((listView1.SelectedItems.Count > 0) ? listView1.SelectedItems[0].Text : "").Show();
        }

        private void findProductOfPrimeFactorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new findProductOfPrimeFactors((listView1.SelectedItems.Count > 0) ? listView1.SelectedItems[0].Text : "").Show();
        }
    }
}
