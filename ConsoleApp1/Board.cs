
using System;
using static System.Formats.Asn1.AsnWriter;
using static ConsoleApp1.Player;
using static ConsoleApp1.Play;

public class Board
{
    public static void Main()
    {

        ConsoleApp1.Player[] players = { 
            new ConsoleApp1.Player("John", 0), 
            new ConsoleApp1.Player("Toto", 0) 
        };

        ConsoleApp1.Play game = new ConsoleApp1.Play(50, players);
        game.startGame();
    }
}
