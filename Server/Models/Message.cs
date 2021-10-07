using System;

namespace Server.Models
{
    public class Message
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public string UserName { get; set; }

        public DateTime Time{ get; set; }       
    }
}
