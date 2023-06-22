namespace Thuc_Hanh_2_bai_1
{
    public partial class convertNumber : Form
    {
        public convertNumber(string input)
        {
            InitializeComponent();
            input_box.Text = input;
        }


        private void main_Load(object sender, EventArgs e)
        {

        }

        string[] unitsMap =
        {
            "", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín", "mười", "mười một", "mười hai", "mười ba", "mười bốn", "mười lăm", "mười sáu", "mười bảy", "mười tám", "mười chín"
        };

        private void Input_box_TextChanged(object sender, EventArgs e)
        {
            int input;
            if (int.TryParse(input_box.Text, out input))
            {
                string result = convertNumberToWords(input);
                result_box.Text = result;
            }
            else
            {
                result_box.Text = "Số không hợp lệ";
            }
        }

        private string convertNumberToWords(int number)
        {
            if (number == 0)
                return "không";

            if (number < 0)
                return "âm " + convertNumberToWords(Math.Abs(number));

            string words = "";

            if ((number / 1000000000) > 0)
            {
                words += convertNumberToWords(number / 1000000000) + " tỷ ";
                number %= 1000000000;
            }

            if ((number / 1000000) > 0)
            {
                words += convertNumberToWords(number / 1000000) + " triệu ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += convertNumberToWords(number / 1000) + " nghìn ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += convertNumberToWords(number / 100) + " trăm ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += "và ";

                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += unitsMap[number / 10] + " ";
                    words += unitsMap[number % 10];
                }
            }

            return words;
        }

        private void findProductOfPrimeFactors_Clicked(object sender, EventArgs e)
        {
            this.Hide();
            new findProductOfPrimeFactors(input_box.Text).Show();
        }
        private void generateNumber_Clicked(object sender, EventArgs e)
        {
            this.Hide();
            new generateNumber().Show();
        }
    }
}