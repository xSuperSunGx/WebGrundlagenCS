namespace Web_Grundlagen.Models
{
    public class Message
    {
        public string Header { get; set; }
        public string MessageInfo { get; set; }
        public string Solution { get; set; }
        public Message() : this("", "", ""){}

        public Message(string header, string messageInfo)
        {
            Header = header;
            MessageInfo = messageInfo;
        }

        public Message(string header, string messageInfo, string solution)
        {
            Header = header;
            MessageInfo = messageInfo;
            Solution = solution;
        }
    }
}