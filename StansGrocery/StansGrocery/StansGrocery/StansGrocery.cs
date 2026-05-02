namespace StansGrocery
{
    public partial class StansGrocery : Form
    {
        public StansGrocery()
        {
            InitializeComponent();

            SplashScreenForm();
            FileToArray(filePath);
            DisplayData();


        }
        string[,] customerData = new string[0, 0];
        string filePath = @"C:\Users\cambr\OneDrive\Desktop\VisualStudioWork\StansGrocery\StansGrocery\StansGrocery\Grocery.txt";


        private void SplashScreenForm()//this does the time for the screen to load then go away 
        {
            SplashScreenForm splashForm = new SplashScreenForm();
            splashForm.Show();
            System.Threading.Thread.Sleep(3000);
            splashForm.Close();
        }


        int CountOfLinesIn(string filePath)
        {
            int count = 0;
            using (StreamReader testFile = new StreamReader(filePath))
            {
                do
                {
                    testFile.ReadLine();
                    count++;
                } while (!testFile.EndOfStream);
            }
            return count;
        }
        string Clean(string input)
        {
            return input
                .Replace("\"", "")
                .Replace("$", "")
                .Replace("#", "")
                .Replace("%", "")
                .Replace("LOC", "")
                .Replace("ITM", "")
                .Replace("CAT", "")
                .Trim();
        }
        void FileToArray(string filePath)
        {
            string[,] _customerData = new string[4, CountOfLinesIn(filePath)];
            string[] temp;
            int counter = 0;

            using (StreamReader testFile = new StreamReader(filePath))
            {
                do
                {
                    temp = testFile.ReadLine().Split(",");
                    if (temp.Length >= 3)
                    {
                        for (int i = 0; i < temp.Length && i < 4; i++)
                        {
                            _customerData[i, counter] = Clean(temp[i]);
                        }
                    }
                    counter++;
                } while (!testFile.EndOfStream);
            }
            this.customerData = _customerData;
        }

        void DisplayData()
        {
            string[,] data = this.customerData;
            string formattedRow = "";
            int filterColumn = 2;

            DisplayListBox.Items.Clear();

            switch (true)
            {
                case bool when FilterRadioButton.Checked:
                    filterColumn = 2;
                    break;
                case bool when FilterRadioButton.Checked:
                    filterColumn = 1;
                    break;
                    //default:
            }

            for (int row = 0; row < data.GetLength(1); row++)
            {
                for (int column = 0; column < data.GetLength(0); column++)
                {
                    if (data[column, row] != null && (data[filterColumn, row] == ItemComboBox.SelectedItem.ToString() || ItemComboBox.SelectedIndex == 0))
                    {
                        formattedRow = $"{data[0, row],-25}{data[1, row],-5}{data[2, row],-23}";
                    }
                }
                if (formattedRow != "")
                {
                    DisplayListBox.Items.Add(formattedRow);
                }
                formattedRow = "";
            }
        }

        void LoadFilterComboBox()
        {
            int column = 1;
            ItemComboBox.Items.Clear();

            switch (true)
            {
                case bool when FilterRadioButton.Checked:
                    column = 2;
                    break;
                case bool when AisleRadioButton.Checked:
                    column = 1;
                    break;
                
                    //default:
            }

            for (int row = 0; (row < this.customerData.GetUpperBound(1)); row++)
            {
                if (this.customerData[column, row] != null && ItemComboBox.Items.Contains(this.customerData[column, row]) != true)
                {

                    ItemComboBox.Items.Add(this.customerData[column, row]); //add city 
                }
            }
            ItemComboBox.Items.Add("~Select~");
            ItemComboBox.Sorted = true;
            ItemComboBox.SelectedItem = 0;

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            ItemComboBox.SelectedIndex = 0;
            DisplayData();
            ItemNameTextBox.Text = "";
        }



    }
}
