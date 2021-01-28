using System;
using System.Collections.Generic;
using System.Text;

namespace GamePlatform.Interface
{
    public interface ISellLog
    {
        public string GameName { get; set; }
        public string PlayerTc { get; set; }
        public int SellPrice { get; set; }
    }
}
