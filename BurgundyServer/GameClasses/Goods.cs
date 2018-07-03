using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BurgundyServer.GameClasses
{
    /// <summary>
    /// (uint) is the die roll for each
    /// </summary>
    public enum GoodsType : uint
    {
        None,
        Cyan,
        Purple,
        Pink,
        Red,
        Brown,
        Orange
    }

    public struct Goods
    {
        public GoodsType Color { get; set; }
        public uint DieCount { get; set; }
        public Goods(GoodsType pColor)
        {
            Color = pColor;
            DieCount = (uint)Color;
        }
    }
}