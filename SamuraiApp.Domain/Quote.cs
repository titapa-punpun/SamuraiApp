using System;

namespace SamuraiApp.Domain
{
    public class Quote
    {
        public int ID { get; set; }
        public string Test { get; set; }
        public Samurai Samurai { get; set; }
        public int SamuraiId { get; set; }
    }
}
