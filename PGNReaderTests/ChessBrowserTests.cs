using ChessTools;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace PGNReaderTests
{
    public class ChessBrowserTests
    {

        [Test]
        public void TestFile1()
        {
            PGNReader reader = new PGNReader();
            List<ChessGame> list = reader.ReadFile(@"C:\Users\evanv\Desktop\Temp. School Assignments\Databases\Asg_06\kb1.pgn");
        }

        
    }
}