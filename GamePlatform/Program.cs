using System;
using GamePlatform.Interface;
using GamePlatform.Class;
using GamePlatform.Managers;

namespace GamePlatform
{
    class Program
    {
        static void Main(string[] args)
        {
            
            PlayerManager playermanager = new PlayerManager();
            GameManager gamemanager = new GameManager();
            
            
            NewPlayer player1 = new NewPlayer() { PlayerName = "Ahmet", PlayerSurname = "Akoguz", PlayerTc = "123456789", PlayerDate = new DateTime(2003, 05, 01) };
            Games newgame = new Games() { GameName = "BTD5", Price = 100, DiscountPrice = 0 };
            Games newgame1 = new Games() { GameName = "abc", Price = 50, DiscountPrice = 0 };
            Games newgame2 = new Games() { GameName = "abcd", Price = 70, DiscountPrice = 0 };
            Games newgame3 = new Games() { GameName = "abcde", Price = 120, DiscountPrice = 0 };
            gamemanager.AddGame(newgame);
            gamemanager.AddGame(newgame1);
            gamemanager.AddGame(newgame2);
            gamemanager.AddGame(newgame3);
            
            playermanager.PlayerSignIn(player1);

            
            

        }
    }
}
