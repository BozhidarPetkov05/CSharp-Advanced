using System.Text;

namespace MailClient
{
    public class MailBox
    {
        public MailBox(int capacity)
        {
            Capacity = capacity;
            Inbox = new List<Mail>();
            Archive = new List<Mail>();
        }
        public int Capacity { get; private set; }
        public List<Mail> Inbox { get; private set; }
        public List<Mail> Archive { get; private set; }
        public void IncomingMail(Mail mail)
        {
            if (Inbox.Count < Capacity)
            {
                Inbox.Add(mail);
            }
        }
        public bool DeleteMail(string sender)
        {
            Mail mailToRemove = Inbox.FirstOrDefault(s => s.Sender == sender);
            if (mailToRemove != null)
            {
                Inbox.Remove(mailToRemove);
                return true;
            }
            else
            {
                return false;
            }
        }
        public int ArchiveInboxMessages()
        {
            Archive.AddRange(Inbox);
            int count = Inbox.Count;
            Inbox.Clear();
            return count;
        }
        public string GetLongestMessage()
        {
            List<Mail> ordered = Inbox.OrderByDescending(l => l.Body.Length).ToList();
            Mail longest = ordered[0];
            return longest.ToString();
        }
        public string InboxView()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Inbox:");
            foreach (Mail mail in Inbox)
            {
                sb.AppendLine(mail.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
