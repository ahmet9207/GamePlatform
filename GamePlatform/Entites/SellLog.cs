using System;
using System.Collections.Generic;
using System.Text;
using GamePlatform.Interface;

namespace GamePlatform.Class
{
    class SellLog: ISellLog
    {
        public string GameName { get; set; }
        public string PlayerTc { get; set; }
        public int SellPrice { get; set; }
    }
}
