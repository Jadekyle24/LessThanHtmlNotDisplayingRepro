namespace LessThanHtmlNotDisplayingRepro
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

            //HTML encoded characters that do not work with a character immidiately after them
            InvalidLabel1.Text = "Does not work => &lt;a";
            InvalidLabel2.Text = "Does not work => <span>&lt;</span>a";

            //Workaround: Add a span tag and remove the ending semicolon
            ValidLabel1.Text = "Does work => <span>&lt</span>a";

            //Other HTML encoded characters that work with a character immidiately after them
            ValidLabel2.Text = "Does work => &gt;a";
            ValidLabel3.Text = "Does work => <span>&gt;</span>a";
            ValidLabel4.Text = "Does work => &amp;a";
            ValidLabel5.Text = "Does work => <span>&amp;</span>a";
            ValidLabel6.Text = "Does work => &#39;a";
            ValidLabel7.Text = "Does work => <span>&#39;</span>a";
        }

    }
}
