using System;
using System.Collections.Generic;
using System.Text;
using GamePlatform.Interface;

namespace GamePlatform.Managers
{
    public class PlayerManager
    {
        List<IPlayer> players = new List<IPlayer>() { };
        List<IPlayer> oldplayers = new List<IPlayer>() { };
        public bool EdevletSorgu (IPlayer player)
        {
            if(player.PlayerTc is string && player.PlayerName is string)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public void PlayerSignIn(IPlayer newPlayer)
        {
            if (EdevletSorgu(newPlayer))
            {
                players.Add(newPlayer);
                Console.WriteLine("Yeni Oyuncu Eklendi.");
            }
            else
            {
                Console.WriteLine("Edevletle uyuşmadı");
            }

        }
       
        public void PlayerDelete(string Tcno)
        {
            foreach (var player in players){
                if (player.PlayerTc == Tcno)
                {
                    players.Remove(player);
                    oldplayers.Add(player);
                    Console.WriteLine("Oyuncu Silindi");
                    break;
                }
                else
                {                  
                    continue;
                }
            }
        }

    }
}
