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
                    if (temp.Length >=3)
                    {
                        for (int i = 0; i < temp.Length && i < 4; i++)
                        {
                            _customerData[i, counter] = CleanString(temp[i]);
                        }
                    }
                    counter++;
                } while (!testFile.EndOfStream);
            }
            this.customerData = _customerData;
        }

    } 
}
