using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ChessTools
{
    /// <summary>
    /// A class to read PGN files into ChessGame objects
    /// </summary>
    public class PGNReader
    {
        /// <summary>
        /// Method to read the PGN file in
        /// </summary>
        /// <param name="filePath">Path to the PGN file</param>
        /// <returns>A list of ChessGame objects</returns>
        public List<ChessGame> ReadFile(string filePath)
        {
            string line;           
            List<ChessGame> games = new List<ChessGame>();

            StreamReader file = new StreamReader(filePath);
            while((line = file.ReadLine()) != null)
            {                
                games.Add(BuildGame(file, line));                
            }

            return games;
        }

        /// <summary>
        /// Helper method to build an individual game from a PGN file
        /// </summary>
        /// <param name="file">The file to read the data from</param>
        /// <param name="line">Curr line of the PGN file</param>
        /// <returns>A chess game object built from the PGN file</returns>
        private ChessGame BuildGame(StreamReader file, string line)
        {
            ChessGame tempGame = new ChessGame();
            tempGame.Event = line.Replace("[Event ", "").Replace("]", "").Replace("\"", "");
            line = file.ReadLine();

            tempGame.Site = line.Replace("[Site ", "").Replace("]", "").Replace("\"", "");
            line = file.ReadLine();

            if (line.Contains("[Date "))
            {
                line = file.ReadLine();
            }

            tempGame.Round = line.Replace("[Round ", "").Replace("]", "").Replace("\"", "");
            line = file.ReadLine();

            Player whitePlayer = new Player();
            Player blackPlayer = new Player();
            whitePlayer.Name = line.Replace("[White ", "").Replace("]", "").Replace("\"", "");
            line = file.ReadLine();
            blackPlayer.Name = line.Replace("[Black ", "").Replace("]", "").Replace("\"", "");
            line = file.ReadLine();

            tempGame.Result = line.Replace("[Result ", "").Replace("]", "").Replace("\"", "");
            line = file.ReadLine();

            whitePlayer.Elo = int.Parse(line.Replace("[WhiteElo ", "").Replace("]", "").Replace("\"", ""));
            line = file.ReadLine();
            blackPlayer.Elo = int.Parse(line.Replace("[BlackElo ", "").Replace("]", "").Replace("\"", ""));
            line = file.ReadLine();
            tempGame.WhitePlayer = whitePlayer;
            tempGame.BlackPlayer = blackPlayer;

            if (line.Contains("[ECO "))
            {
                line = file.ReadLine();
            }

            if(line.Contains(".??"))
            {
                line = line.Replace(".??", ".01");
            }
            tempGame.EventDate = DateTime.Parse(line.Replace("[EventDate ", "").Replace("]", "").Replace("\"", ""));
            line = file.ReadLine();
            line = file.ReadLine();

            StringBuilder sb = new StringBuilder();
            while (!line.Equals(""))
            {
                sb.Append(line);
                line = file.ReadLine();
            }
            tempGame.Moves = sb.ToString();

            return tempGame;
        }
    }
}
