using System;
using System.Collections.Generic;
using System.Text;
using GamePlatform.Interface;

namespace GamePlatform.Class
{
    class OldPlayer: IPlayer
    {
        
        public string PlayerName { get; set; }
        public string PlayerSurname { get; set; }
        public string PlayerTc { get; set; }
        public DateTime PlayerDate { get; set; }
    }
}

