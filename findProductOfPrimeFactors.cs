namespace Thuc_Hanh_2_bai_1
{
    public partial class findProductOfPrimeFactors : Form
    {
        public findProductOfPrimeFactors(string number_input)
        {
            InitializeComponent();
            input_box.Text = number_input;
        }

        static List<int> getPrimeFactors(int number)
        {
            List<int> primeFactors = new List<int>();
            for (int i = 2; i <= number; i++)
            {
                while (number % i == 0)
                {
                    primeFactors.Add(i);
                    number /= i;
                }
            }
            return primeFactors;
        }

        private void Analysis_Clicked(object sender, EventArgs e)
        {
            int input;
            if (int.TryParse(input_box.Text, out input))
            {
                List<int> primeFactors = getPrimeFactors(input);
                //foreach (int primeFactor in primeFactors)
                //{
                //    result += primeFactor.ToString() + " * ";
                //}
                string result = String.Join(" * ", primeFactors);
                result_box.Text = "Tích các thừa số nguyên tố bao gồm: " + result;
            }
            else
            {
                result_box.Text = "Số không hợp lệ";
            }

        }

        Random random = new Random();
        private void AddLow_Clicked(object sender, EventArgs e)
        {
            int randomNumber = random.Next(1, 32768);
            input_box.Text = randomNumber.ToString();
        }

        private void AddHigh_Clicked(object sender, EventArgs e)
        {

        }

        static List<int> ListDivisors(int number)
        {
            List<int> divisors = new List<int>();
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    divisors.Add(i);
                }
            }

            return divisors;
        }
        private void LIST_Clicked(object sender, EventArgs e)
        {
            int input;
            if (int.TryParse(input_box.Text, out input))
            {
                List<int> divisors = ListDivisors(input);
                string result = String.Join(", ", divisors);
                result_box.Text = "Các ước số của " + input + " là: " + result;
            }
            else
            {
                result_box.Text = "Số không hợp lệ";
            }
        }


        private void convertNumberTool_Clicked(object sender, EventArgs e)
        {
            this.Hide();
            new convertNumber(input_box.Text).Show();
        }
        private void generateNumberTool_Clicked(object sender, EventArgs e)
        {
            this.Hide();
            new generateNumber().Show();
        }
    }
}
