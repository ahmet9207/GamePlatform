using System;
using System.Collections.Generic;
using System.Text;
using GamePlatform.Interface;
using GamePlatform.Class;

namespace GamePlatform.Managers
{
    public class GameManager
    {
        public static List<IGames> gamelist = new List<IGames>() { };

        public List<ISellLog> selllog = new List<ISellLog>() { };

        public void AddGame(IGames newGame)
        {
            gamelist.Add(newGame);
            
        }
        public void Sellgame(string gamename, string playertc, int Price)
        {
            SellLog log = new SellLog();
            log.PlayerTc = playertc;
            log.GameName = gamename;
            log.SellPrice = Price;
            selllog.Add(log);
        }
    }
}
