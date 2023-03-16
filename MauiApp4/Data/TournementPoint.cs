namespace MauiApp4.Data
{
	public class TournementPoint
	{
		public TournementPoint(string competition, string eytPoints, string totalPoints)
		{
			Competition = competition;
			EytPoints = eytPoints;
			TotalPoints = totalPoints;
		}
        public TournementPoint()
		{

		}

        public string Competition { get; set; }
		public string EytPoints { get; set; }
		public string TotalPoints { get; set; }
	}
}
