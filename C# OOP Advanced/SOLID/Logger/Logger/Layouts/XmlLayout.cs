namespace Logger.Layouts
{
    using Contracts;
    using System.Text;

    public class XmlLayout : ILayout
    {
        private string format;

        public string Format => GetFormat();

        private string GetFormat()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<log>");
            sb.AppendLine("  <date>{0}</date>");
            sb.AppendLine("  <level>{1}</level>");
            sb.AppendLine("  <message>{2}</message>");
            sb.Append("</log>");

            return sb.ToString();
        }
    }
}
