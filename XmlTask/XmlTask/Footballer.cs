using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlTask
{
    [Serializable]
    public class Footballer
    {
        public string SecondName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Role { get; set; }
        public int GamesCount { get; set; }
        public int ScoredBallsCount { get; set; }
        public string BirthPlace { get; set; }

        public Footballer()
        { }

        public Footballer(string secondName, DateTime birthDate, string role, int gamesCount, int scoredBallsCount, string birthPlace)
        {
            SecondName = secondName;
            BirthDate = birthDate;
            Role = role;
            GamesCount = gamesCount;
            ScoredBallsCount = scoredBallsCount;
            BirthPlace = birthPlace;
        }

    }
}
