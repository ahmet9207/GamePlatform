using System;
using System.Collections.Generic;
using System.Text;

namespace GamePlatform.Interface
{
    public interface IGames
    {
        public string GameName { get; set; }
        public int Price { get; set; }
        public int DiscountPrice { get; set; }
    }
}
