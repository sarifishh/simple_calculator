namespace Calculator
{
    public partial class CaluclatorForm : Form
    {
        public CaluclatorForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {


            int first, second, answer;

            try

            {

                first = Convert.ToInt32(firstNumberBox.Text);

                second = Convert.ToInt32(secondNumberBox.Text);

                answer = first + second;

                answerBox.Text = answer.ToString();

            }

            catch (Exception)

            {

                MessageBox.Show("Invalid input.");

            }


        }

        private void SubtractBtn_Click(object sender, EventArgs e)
        {
            int first, second, answer;

            try

            {

                first = Convert.ToInt32(firstNumberBox.Text);

                second = Convert.ToInt32(secondNumberBox.Text);

                answer = first - second;

                answerBox.Text = answer.ToString();

            }

            catch (Exception)

            {

                MessageBox.Show("Invalid input.");

            }
        }

        private void MultiplyBtn_Click(object sender, EventArgs e)
        {
            int first, second, answer;

            try

            {

                first = Convert.ToInt32(firstNumberBox.Text);

                second = Convert.ToInt32(secondNumberBox.Text);

                answer = first * second;

                answerBox.Text = answer.ToString();

            }

            catch (Exception)

            {

                MessageBox.Show("Invalid input.");

            }
        }

        private void DivideBtn_Click(object sender, EventArgs e)
        {
            int first, second, answer;

            try

            {

                first = Convert.ToInt32(firstNumberBox.Text);

                second = Convert.ToInt32(secondNumberBox.Text);

                answer = first / second;

                answerBox.Text = answer.ToString();

            }

            catch (Exception)

            {

                MessageBox.Show("Invalid input.");

            }
        }
    }
}