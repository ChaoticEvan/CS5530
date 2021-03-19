using ChessTools;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace PGNReaderTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestFile1()
        {
            PGNReader reader = new PGNReader();
            List<ChessGame> list = reader.ReadFile(@"C:\Users\evanv\Desktop\Temp. School Assignments\Databases\Asg_06\kb1.pgn");

            Assert.AreEqual(list[0].Event, "4. IIFL Wealth Mumbai Op");
            Assert.AreEqual(list[0].Site, "Mumbai IND");        
            Assert.AreEqual(list[0].Round, "2.9");
            Assert.AreEqual(list[0].WhitePlayer.Name, "Sundararajan, Kidambi");
            Assert.AreEqual(list[0].BlackPlayer.Name, "Ziatdinov, Raset");
            Assert.AreEqual(list[0].WhitePlayer.Elo, 2458);
            Assert.AreEqual(list[0].BlackPlayer.Elo, 2252);
            Assert.AreEqual(list[0].Result, "1/2-1/2");
            Assert.AreEqual(list[0].EventDate, DateTime.Parse("2018.12.30"));

            Assert.AreEqual(list[1].Event, "Australian Open 2019");
            Assert.AreEqual(list[1].Site, "Melbourne AUS");
            Assert.AreEqual(list[1].Round, "9.8");
            Assert.AreEqual(list[1].WhitePlayer.Name, "Stojic, Dusan");
            Assert.AreEqual(list[1].BlackPlayer.Name, "Johansen, Darryl K");
            Assert.AreEqual(list[1].WhitePlayer.Elo, 2275);
            Assert.AreEqual(list[1].BlackPlayer.Elo, 2345);
            Assert.AreEqual(list[1].Result, "0-1");
            Assert.AreEqual(list[1].EventDate, DateTime.Parse("2018.12.27"));
        }


        [Test]
        public void TestFile2()
        {
            PGNReader reader = new PGNReader();
            List<ChessGame> list = reader.ReadFile(@"C:\Users\evanv\Desktop\Temp. School Assignments\Databases\Asg_06\kb2.pgn");

            Assert.AreEqual(list[0].Event, "12. Amantea Open 2014");
            Assert.AreEqual(list[0].Site, "Amantea ITA");
            Assert.AreEqual(list[0].Round, "6.9");
            Assert.AreEqual(list[0].WhitePlayer.Name, "Draskovic, Luka");
            Assert.AreEqual(list[0].BlackPlayer.Name, "Valsecchi, Alessio");
            Assert.AreEqual(list[0].WhitePlayer.Elo, 2337);
            Assert.AreEqual(list[0].BlackPlayer.Elo, 2438);
            Assert.AreEqual(list[0].Result, "1/2-1/2");
            Assert.AreEqual(list[0].EventDate, DateTime.Parse("2014.09.07"));

            Assert.AreEqual(list[1].Event, "Rio de Janeiro BRA, 1. Cunha Memorial");
            Assert.AreEqual(list[1].Site, "Rio de Janeiro BRA");
            Assert.AreEqual(list[1].Round, "7.3");
            Assert.AreEqual(list[1].WhitePlayer.Name, "Cubas, Jose Fernando");
            Assert.AreEqual(list[1].BlackPlayer.Name, "Guimaraes, Wagner Peixoto");
            Assert.AreEqual(list[1].WhitePlayer.Elo, 2456);
            Assert.AreEqual(list[1].BlackPlayer.Elo, 2242);
            Assert.AreEqual(list[1].Result, "1-0");
            Assert.AreEqual(list[1].EventDate, DateTime.Parse("2014.09.08"));
        }
        
        [Test]
        public void TestFile3()
        {
            PGNReader reader = new PGNReader();
            List<ChessGame> list = reader.ReadFile(@"C:\Users\evanv\Desktop\Temp. School Assignments\Databases\Asg_06\kb3.pgn");

            Assert.AreEqual(list[0].Event, "ETCC");
            Assert.AreEqual(list[0].Site, "Crete GRE");
            Assert.AreEqual(list[0].Round, "3");
            Assert.AreEqual(list[0].WhitePlayer.Name, "Cheparinov, Ivan");
            Assert.AreEqual(list[0].BlackPlayer.Name, "Drasko, Milan");
            Assert.AreEqual(list[0].WhitePlayer.Elo, 2670);
            Assert.AreEqual(list[0].BlackPlayer.Elo, 2557);
            Assert.AreEqual(list[0].Result, "1-0");
            Assert.AreEqual(list[0].EventDate, DateTime.Parse("2007.10.28"));

            Assert.AreEqual(list[1].Event, "7. Rohde Open");
            Assert.AreEqual(list[1].Site, "Sautron FRA");
            Assert.AreEqual(list[1].Round, "5");
            Assert.AreEqual(list[1].WhitePlayer.Name, "Malakhatko, Vadim");
            Assert.AreEqual(list[1].BlackPlayer.Name, "Zozulia, A.");
            Assert.AreEqual(list[1].WhitePlayer.Elo, 2603);
            Assert.AreEqual(list[1].BlackPlayer.Elo, 2347);
            Assert.AreEqual(list[1].Result, "1-0");
            Assert.AreEqual(list[1].EventDate, DateTime.Parse("2007.10.27"));
        }
    }
}