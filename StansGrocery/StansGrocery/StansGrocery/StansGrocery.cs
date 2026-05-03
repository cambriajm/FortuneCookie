namespace StansGrocery
    //Cambria Morgan
    //Spring 2026
    //RCET 2265
    //Stans Grocery
    //

{
    public partial class StansGrocery : Form
    {
        public StansGrocery()
        {
            SplashScreenForm();
            InitializeComponent();
            SetDefaults();
            string filePath = @"C:\Users\cambr\OneDrive\Desktop\VisualStudioWork\StansGrocery\Grocery.txt";
            FileToArray(filePath);
            
            searchToolStripMenuItem.Click += SearchButton_Click;
            searchToolStripMenuItem1.Click += SearchButton_Click;
            exitToolStripMenuItem1.Click += exitToolStripMenuItem_Click;
            SearchButton.Enabled = true;
            

        }
        string[,] customerData = new string[0, 0];
        string filePath = @"C:\Users\cambr\OneDrive\Desktop\VisualStudioWork\StansGrocery\Grocery.txt";


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
            string[,] _customerData = new string[3, CountOfLinesIn(filePath)];
            string[] temp;
            int counter = 0;

            using (StreamReader testFile = new StreamReader(filePath))
            {
                do
                {
                    temp = testFile.ReadLine().Split(',');
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
                case bool when AisleRadioButton.Checked:
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
                if (formattedRow !="")
                {
                if (formattedRow.Contains(ItemNameTextBox.Text, StringComparison.InvariantCultureIgnoreCase))
                {
                    DisplayListBox.Items.Add(formattedRow);
                }

                }

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
            ItemComboBox.Items.Add("~All Items~");
            ItemComboBox.Sorted = true;
            ItemComboBox.SelectedItem = 0;

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            ItemComboBox.SelectedIndex = 0;
            DisplayData();
            ItemNameTextBox.Text = "";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SetDefaults()
        {
            AisleRadioButton.Checked = true;
        }



        private void ItemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayData();

        }

        private void AisleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            LoadFilterComboBox();
        }

        private void FilterRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            LoadFilterComboBox();
        }
    }
}
