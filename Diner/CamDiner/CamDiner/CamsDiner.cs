namespace CamDiner
    //Cambria Morgan
    //Spring 2026
    //RCET 2265
    //Cam Diner 
{
    public partial class CamsDiner : Form
    {
        public CamsDiner()
        {
            InitializeComponent();
            SetDefaults();
        }


        private void SetDefaults()
        {
            Diner2Label.Text = "Welcome to my diner! " +
                "Press a button to see the menu items of the day.";
        }
        private void SoupButton_Click(object sender, EventArgs e)//text for soup button
        {
            Diner2Label.Text = "SOUP SOUP SOUP! I LOVE SOUP!" +
                "I bet you love soup too! " +
                "Today's soup is the Chicken Noodle" +
                "This has chicken and noodles." +
                "All you could ever wish for in life.";
        }
        private void CamsDiner_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click()
        {

        }

        private void SpecialButton_Click(object sender, EventArgs e)//text for chef button
        {
            Diner2Label.Text = "The Chef special for today is a singular brownie." +
                "This is a very filling meal as you can see." +
                "Very delicious and nutritious." +
                "Yummy";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();//closes program
        }

        private void FishButton_Click(object sender, EventArgs e)//fish button
        {
            Diner2Label.Text = "The daily fish is:" +
                "None" +
                "I dont like fish, so we don't serve fish here." +
                "Go to a different diner for fish, sorry";
        }
    }
}
