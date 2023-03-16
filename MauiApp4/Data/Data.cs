using System;

namespace MauiApp4.Data
{
    public class Country
    {
        public Country(string countryName)
        {
            CountryName = countryName;
        }

        public Country(int countryId)
        {
            CountryId = countryId;
        }

        public Country(int countryId, string countryName)
        {
            CountryId = countryId;
            CountryName = countryName;
        }

        public int CountryId { get; set; }
        public string CountryName { get; set; }

    }
    public class League
    {
		public League(int leagueId)
		{
			LeagueId = leagueId;
		}

		public League(int leagueId, string leagueAbbr)
		{
			LeagueId = leagueId;
			LeagueAbbr = leagueAbbr;
		}

		public int CountryId { get; set; }
        public int LeagueId { get; set; }
        public string LeagueName { get; set; }
        public string LeagueAbbr { get; set; }
    }
    public class Match
    {
		public Match(Team homeTeam, Team awayTeam, DateTime date, int? homeMS, int? awayMS, League league, Prediction prediction)
		{
			HomeTeam = homeTeam;
			AwayTeam = awayTeam;
			Date = date;
			HomeMS = homeMS;
			AwayMS = awayMS;
			League = league;
			Prediction = prediction;
		}

		public int MatchId { get; set; }
		public Team HomeTeam { get; set; }
		public Team AwayTeam { get; set; }
		public DateTime  Date { get; set; }
        public int? HomeMS { get; set; }
        public int? AwayMS { get; set; }
        public League League { get; set; }
        public Prediction Prediction { get; set; }

    }
    public class Prediction
    {
		public Prediction(int? predictionId, int? homeScore, int? awayScore)
		{
			PredictionId = predictionId;
			HomeScore = homeScore;
			AwayScore = awayScore;
		}

		public Prediction(int? predictionId, int? homeScore, int? awayScore, int matchId, int userId)
		{
			PredictionId = predictionId;
			HomeScore = homeScore;
			AwayScore = awayScore;
			MatchId = matchId;
			UserId = userId;
		}

		public int? PredictionId { get; set; }
        public int? HomeScore { get; set; }
        public int? AwayScore { get; set; }
        public int MatchId { get; set; }
        public int UserId { get; set; }
        public DateTime PredictionTime { get; set; }
    }
    public class User
    {
        public User()
        {

        }
        public User(int userId, string userName, string password, string userMail)
        {
            UserId = userId;
            UserName = userName;
            Password = password;
            UserMail = userMail;
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserMail { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime LastEnterDate { get; set; }
        public string Platform { get; set; }
        public bool Auth { get; set; }
    }
    public class Team
    {
		public Team(int teamId, string teamName)
		{
			TeamId = teamId;
			TeamName = teamName;
		}

		public Team(int teamId, string teamName, string teamAbbr)
		{
			TeamId = teamId;
			TeamName = teamName;
			TeamAbbr = teamAbbr;
		}

		public int TeamId { get; set; }
        public string TeamName { get; set; }
        public string TeamAbbr { get; set; }
        public int CountryCode { get; set; }
        public string LogoId { get; set; }

    }
	public class Badge
	{
		public Badge(string ıD, string name, string position)
		{
			ID = ıD;
			Name = name;
			Position = position;
		}

		public string ID { get; set; }
		public string Name { get; set; }
		public string Position { get; set; }
	}
	public class StandingsUser
	{
		public int id;
		public string userName;
		public string eytPoints;
		public string points;
		public string teamId;
		public string currentUser;
		public Badge badge { get; set; }
		public StandingsUser(string userName, string eytPoints, string points, string currentUser, Badge badge)
		{
			this.userName = userName;
			this.eytPoints = eytPoints;
			this.points = points;
			this.currentUser = currentUser;
			this.badge = badge;
		}

		public StandingsUser(int id, string userName, string eytPoints, string points, string currentUser, Badge badge)
		{
			this.id = id;
			this.userName = userName;
			this.eytPoints = eytPoints;
			this.points = points;
			this.currentUser = currentUser;
			this.badge = badge;
		}
	}

}
