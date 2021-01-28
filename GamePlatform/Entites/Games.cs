using System;
using System.Collections.Generic;
using System.Text;
using GamePlatform.Interface;

namespace GamePlatform.Class
{
    class Games: IGames
    {
        public string GameName { get; set; }
        public int Price { get; set; }
        public int DiscountPrice { get; set; }
    }
}
