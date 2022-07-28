namespace PlazmaELGGOB.Model
{
    public class GameHistory
    {
        public string User { get; set; }
        public Dictionary<string, int> History { get; set; }
        public int TotalPoints { get; set; }

        public GameHistory(string user, int totalpoints, Dictionary<string, int> history)
        {
            User = user;
            History = history;
            TotalPoints = totalpoints;
        }
    }
}
