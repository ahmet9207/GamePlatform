using System;
using System.Collections.Generic;
using System.Text;

namespace GamePlatform.Interface
{
    public interface IPlayer
    {
        public string PlayerName { get; set; }
        public string PlayerSurname { get; set; }
        public string PlayerTc { get; set; }
        public DateTime PlayerDate { get; set; }
    }
}
