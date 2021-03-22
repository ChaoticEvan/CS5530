using System;

namespace ChessTools
{
    /// <summary>
    /// An object to represent chess games from a PGN file
    /// </summary>
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

    /// <summary>
    /// An object for representing a player in a particular chess game
    /// </summary>
    public class Player
    {
        public string Name;
        public int Elo;

    }
}
