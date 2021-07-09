namespace AppChatV2.Class
{
    public class Group
    {
        private string _ID;
        private string _Name;
        private int _Port;
        private byte[] _Avatar;

        public string Name { get => _Name; set => _Name = value; }
        public int Port { get => _Port; set => _Port = value; }
        public string ID { get => _ID; set => _ID = value; }
        public byte[] Avatar { get => _Avatar; set => _Avatar = value; }
    }
}
