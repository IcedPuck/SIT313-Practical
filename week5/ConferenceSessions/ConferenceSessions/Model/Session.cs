using System;
namespace ConferenceSessions.Model
{
    public class Session
    {
        public string SessionTittle { get; set; }
        public string SessionSpeaker { get; set; }
        public string IsTechnical { get; set; }
        public string SessionDescription { get; set; }
        public string SessionTitle { get; internal set; }

        public Session()
        {
        }
    }
}
