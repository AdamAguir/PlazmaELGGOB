namespace PlazmaELGGOB.Model
{
    public class GameHistory
    {
        public string User { get; set; }
        public List<string> History { get; set; }
        public int TotalPoints { get; set; }

        public GameHistory(string user, int totalpoints, List<string> history)
        {
            User = user;
            History = history;
            TotalPoints = totalpoints;
        }
    }
}
