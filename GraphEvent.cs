using System;

namespace O365_API
{
    public class GraphEvent
    {
        Random random = new Random();

        public int id
        {
            get { return random.Next() % 1000; }
            set { this.id = id; }
        }
        public String Account { get; set; }
        public String Calendar { get; set; }

        public DateTime Date { get; set; }

        public String Body { get; set; }

        public String Subject { get; set; }

        public String[] Invitees { get; set; }
    }
}
