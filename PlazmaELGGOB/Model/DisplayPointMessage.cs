namespace PlazmaELGGOB.Model
{
    public class DisplayPointMessage
    {
        public int Points { get; set; }
        public string Message { get; set; }
        public int DisplayTime { get; set; }

        public DisplayPointMessage(int points, string message, int displayTime)
        {
            Points = points;
            Message = message;
            DisplayTime = displayTime;
        }
    }
}
