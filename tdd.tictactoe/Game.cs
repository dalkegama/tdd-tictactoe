using System;
using tdd.tictactoe.contracts;

namespace tdd.tictactoe
{
    public class Game: IGamePlay, IGameState
    {
        private Player? player;
        public Player?[,] Board { get; } = new Player?[3, 3];
        public Player? Winner { get; }
        public bool IsDraw { get; }
        public void Play(int x, int y, Player player)
        {
            if (x < 0 || x > 2 || y < 0)
            {
                throw new ArgumentException();
            }

            if (this.player == player)
            {
                throw new ArgumentException();
            }

            this.player = player;
            if (this.Board[x, y] != null)
            {
                throw new ArgumentException();
            }

        }

        public IGameState State()
        {
            return this;
        }

    }
}
