using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerStats
{
    public class Player
    {
        float highScore;
        int playedGames;
        int wonGames;
        public string Name{ get; }

        public float HighScore
        {
            get
            {
                return highScore;
            }
            set
            {
                if (value > highScore)
                    highScore = value;
            }
        }
        public float WinRate
        {
            get
            {
                if (playedGames == 0)
                    return 0;
                else
                {
                    
                    return Convert.ToSingle(wonGames) /
                    Convert.ToSingle(playedGames);
                }
            }
        }

        public void PlayGame(bool win)
        {
            playedGames += 1;
            if(win)
            {
                wonGames += 1;
            }
        }

        public Player(string name)
        {
            this.Name = name;
        }
    }
}