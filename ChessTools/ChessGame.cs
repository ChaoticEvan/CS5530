using System;

namespace ChessTools
{
    public class ChessGame
    {
        public string Event;
        public string Site;
        public string Round;
        public Player WhitePlayer;
        public Player BlackPlayer;
        public string Result;
        public DateTime EventDate;
        public string Moves;
    }

    public class Player
    {
        public string Name;
        public int Elo;

    }
}
