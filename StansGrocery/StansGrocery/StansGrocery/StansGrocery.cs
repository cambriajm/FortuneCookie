namespace StansGrocery
//Cambria Morgan
//Spring 2026
//RCET 2265
//Stans Grocery
//https://github.com/cambriajm/StansGrocery.git

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
            LoadFilterComboBox();
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


        int CountOfLinesIn(string filePath)//allows file to be read
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
        string Clean(string input)//cleans the text file text to organize it 
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
        void FileToArray(string filePath)//puts the text into array
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

        void DisplayData()//data display options based on the button selection
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
                    if (data[column, row] != null && (ItemComboBox.SelectedItem.ToString() ==
                        "~Show All~" || data[filterColumn, row]
                        == ItemComboBox.SelectedItem.ToString()))

                    {
                        formattedRow = $"{data[0, row],-25}{data[1, row],-5}{data[2, row],-25}";
                    }
                }
                if (formattedRow != "")
                {
                    if (formattedRow.Contains(ItemNameTextBox.Text, StringComparison.InvariantCultureIgnoreCase))
                    {
                        DisplayListBox.Items.Add(formattedRow);
                    }
                    else
                    {

                    }
                }

            }
        }

        void LoadFilterComboBox()//options box loads based on the button selected
        {
            int column = 1;
            ItemComboBox.Items.Clear();

            switch (true)
            {
                case bool when AisleRadioButton.Checked:
                    column = 1;
                    break;
                case bool when FilterRadioButton.Checked:
                    column = 2;
                    break;

                    //default:
            }

            for (int row = 0; (row < this.customerData.GetUpperBound(1)); row++)
            {
                if (this.customerData[column, row] != null && ItemComboBox.Items.Contains(this.customerData[column, row]) != true)
                {

                    ItemComboBox.Items.Add(this.customerData[column, row]); //add data
                }
            }

            List<string> items;
            if (AisleRadioButton.Checked)
                items = ItemComboBox.Items.Cast<string>().OrderByDescending
                    (x => int.TryParse(x, out int n) ? n : int.MaxValue).ToList();
            else
                items = ItemComboBox.Items.Cast<string>().OrderBy(x => x).ToList();

            ItemComboBox.Items.Clear();
            ItemComboBox.Items.Add("~Show All~");
            foreach (var item in items)
                ItemComboBox.Items.Add(item);

            ItemComboBox.SelectedIndex = 0;

        }
        private void SetDefaults()//defaults
        {
            AisleRadioButton.Checked = true;
            LoadFilterComboBox();
            SelectedItem.Text = "";
        }
        private void SearchButton_Click(object sender, EventArgs e)//button filters results
        {
            ItemComboBox.SelectedIndex = 0;
            DisplayData();
            if (ItemNameTextBox.Text.Equals("zzz", StringComparison.InvariantCultureIgnoreCase))
                this.Close();
            if (DisplayListBox.Items.Count == 0)
                DisplayListBox.Text = $"Sorry no matches for {ItemNameTextBox.Text}";
            ItemNameTextBox.Text = "";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)//exit
        {
            this.Close();
        }
        private void ItemComboBox_SelectedIndexChanged(object? sender, EventArgs e)//dispkay
        {

            DisplayData();

        }

        private void AisleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ItemNameTextBox.Text = "";
            LoadFilterComboBox();
        }

        private void FilterRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ItemNameTextBox.Text = "";
            LoadFilterComboBox();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                SearchButton_Click(sender, e);
                DisplayData();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {

                AboutForm aboutForm = new AboutForm(); // the about form
                aboutForm.Show();
            }
        }

        private void ItemNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DisplayListBox_SelectedIndexChanged(object sender, EventArgs e)//wher to find selected item
        {
            {
                if (DisplayListBox.SelectedItem == null)
                {
                    SelectedItem.Text = "";
                    return;
                }

                string selectedItem = DisplayListBox.SelectedItem.ToString().Substring(0, 25).Trim();

                for (int row = 0; row < customerData.GetLength(1); row++)
                {
                    if (customerData[0, row] != null && customerData[0, row].Equals
                        (selectedItem, StringComparison.InvariantCultureIgnoreCase))
                    {
                        SelectedItem.Text = $"You will find {customerData[0, row]}" + "\n" +
                            $"on aisle {customerData[1, row]}" + "\n" +
                            $"with the {customerData[2, row]}";
                        return;
                    }
                }
            }
        }

        private void StansGrocery_Load(object sender, EventArgs e)
        {

        }
    }
}
