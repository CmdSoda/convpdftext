namespace ConvertPDFText
{
    public partial class ConvertForm : Form
    {
        public ConvertForm()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText(TextDataFormat.Html))
            {
                String returnHtmlText = "";
                returnHtmlText = Clipboard.GetText(TextDataFormat.Html);
                string startText = "<!--StartFragment-->";
                int start = returnHtmlText.IndexOf(startText) + startText.Length;
                int last = returnHtmlText.LastIndexOf("<!--EndFragment-->");
                if (start > -1)
                {
                    string str2 = returnHtmlText.Substring(start, last - start);
                    str2 = str2.Replace("\r\n", "");
                    str2 = str2.Replace("\u0002", "");
                    Clipboard.SetText(str2, TextDataFormat.Text);
                }
            }
        }
    }
}