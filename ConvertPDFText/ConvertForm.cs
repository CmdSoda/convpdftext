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
            String returnHtmlText = null;
            if (Clipboard.ContainsText(TextDataFormat.Html))
            {
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

        private void reformatDeitiesButton_Click(object sender, EventArgs e)
        {
            String text = "";
            if (Clipboard.ContainsText(TextDataFormat.Text))
            {
                text = Clipboard.GetText(TextDataFormat.Text);
                text = text.Replace("</div><div><strong>", "</div><div>\n<strong>");
                text = text.Replace("<div><div><strong>", "<div><div>\n<strong>");
                text = text.Replace("</h1><p>", "</h1>\n<p>");
                text = text.Replace("</p><h2>", "</p>\n<h2>");
                text = text.Replace("</h1><p>", "</h1>\n<p>");
                Clipboard.SetText(text, TextDataFormat.Text);
            }
        }
    }
}