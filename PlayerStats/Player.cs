using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerStats
{
    /// <summary>
    /// Classe que cria um perfil para um jogador, com o seu nome, vezes jogadas
    /// , vezes que ganhou, a sua percentagem de vit�rias e a sua pontua��o mais
    /// alta
    /// </summary>
    public class Player
    {
        float highScore;
        int playedGames;
        int wonGames;
        public string Name{ get; }

        /// <summary>
        /// A sua melhor pontua��o
        /// </summary>
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

        /// <summary>
        /// A sua percentagem de vit�rias
        /// </summary>
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

        /// <summary>
        /// Indica que jogou um jogo
        /// </summary>
        /// <param name="win">Verifica se ganhou</param>
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