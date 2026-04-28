namespace MathContest
//Cambria Morgan
//Spring 2026
//RCET 2265
//Math Contest
//https://github.com/cambriajm/MathContest.git
{
    public partial class MathContest : Form
    {
        public MathContest()
        {
            InitializeComponent();
            SetDefaults();
        }
        int submitNumber = 0;
        int correctNumber = 0;
        int correct = 0;


        private void FirstNumberGenerator()
        {
            Random random = new Random();
            int firstNumber = random.Next(1, 11);
            FirstNumberTextBox.Text = firstNumber.ToString();
        }
        private void SecondNumberGenerator()
        {
            Random random = new Random();
            int secondNumber = random.Next(1, 11);
            SecondNumberTextBox.Text = secondNumber.ToString();
        }
        void MathFunction()
        {
            int firstNumber = int.Parse(FirstNumberTextBox.Text);
            int secondNumber = int.Parse(SecondNumberTextBox.Text);

            if (AddButton.Checked)
            {
                correct = firstNumber + secondNumber;
            }
            else if (SubtractButton.Checked)
            {
                correct = firstNumber - secondNumber;
            }
            else if (DivideButton.Checked)
            {
                correct = firstNumber / secondNumber;
            }
            else if (MultiplyButton.Checked)
            {
                correct = firstNumber * secondNumber;
            }
        }

        private void SetDefaults()
        {
            AgeTextBox.Text = "";
            StudentNameTextBox.Text = "";
            GradeTextBox.Text = "";
            AgeTextBox.BackColor = Color.LightBlue;
            StudentNameTextBox.BackColor = Color.LightBlue;
            GradeTextBox.BackColor = Color.LightBlue;
            FirstNumberTextBox.Text = "";
            SecondNumberTextBox.Text = "";
            StudentAnswerTextBox.Text = "";
            FirstNumberTextBox.Enabled = false;
            SecondNumberTextBox.Enabled = false;
            StudentAnswerTextBox.Enabled = false;
            SummaryButton.Enabled = false;
            SubmitButton.Enabled = false;
            AddButton.Checked = true;
            submitNumber = 0;
            correct = 0;
            correctNumber = 0;
        }

        private bool ValidateFields()
        {
            bool valid = true;

            if (StudentNameTextBox.Text! == "")
            {
                StudentNameTextBox.BackColor = Color.White;
            }
            else
            {
                StudentNameTextBox.BackColor = Color.LightYellow;
                valid = false;
            }

            try
            {
               
                
                if (int.Parse(AgeTextBox.Text) >= 7 && int.Parse(AgeTextBox.Text) <= 11)
                {
                    AgeTextBox.BackColor = Color.White;
                }
                else

                {
                    AgeTextBox.BackColor = Color.LightYellow;
                    valid = false;
                }
            }
            catch (Exception)
            {
                AgeTextBox.BackColor = Color.LightYellow;
                valid = false;
            }

            try
            {
                if (int.Parse(GradeTextBox.Text) >= 1 && int.Parse(GradeTextBox.Text) <= 4)
                {
                    GradeTextBox.BackColor = Color.White;
                }
                else
                {
                    GradeTextBox.BackColor = Color.LightYellow;
                    valid = false;
                }
            }
            catch (Exception)
            {
                GradeTextBox.BackColor = Color.LightYellow;
                valid = false;
            }

            if (StudentAnswerTextBox.Text != "")
            {
                StudentAnswerTextBox.BackColor = Color.White;
            }
            else
            {
                StudentAnswerTextBox.BackColor = Color.LightYellow;
                valid = false;
            }

            return valid;
        }
        


        private void ClearButton_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            MathFunction();
            try
            {
                int.Parse(StudentAnswerTextBox.Text);
            }
            catch (Exception)
            {
                int.Parse(AgeTextBox.Text);
            }
            if (int.Parse(StudentAnswerTextBox.Text) == correct)
            {
                MessageBox.Show("Correct answer!");
                correctNumber++;
            }
            else
            {
                MessageBox.Show($"Whops,{correct} is correct.");
            }

            FirstNumberGenerator();
            SecondNumberGenerator();
            SummaryButton.Enabled = true;
            submitNumber++;
        }

        private void SummaryButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"You have {correct} out of {submitNumber}");
        }
        private void StudentNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (submitNumber >= 1)
            {
                SetDefaults();
            }
            else
            {
                if (ValidateFields())
                {
                    SubmitButton.Enabled = true;
                }
                else
                {
                    SubmitButton.Enabled = false;
                }
            }
        }

        private void AgeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (submitNumber >= 1)

            {
                SetDefaults();
            }
            else
            {

                if (ValidateFields())
                {
                    SubmitButton.Enabled = true;
                }
                else
                {
                    SubmitButton.Enabled = false;
                }
            }
        }

        private void GradeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (submitNumber >= 1)
            {
                SetDefaults();
            }
            else
            {
                if (ValidateFields())
                {
                    SubmitButton.Enabled = true;
                }
                else
                {
                    SubmitButton.Enabled = false;
                }
            }
        }

        private void StudentAnswerTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                SubmitButton.Enabled = true;
            }
            else
            {
                SubmitButton.Enabled = false;
            }
        }
    }
}

