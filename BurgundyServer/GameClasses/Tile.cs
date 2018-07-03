using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BurgundyServer.GameClasses
{
    public enum TileType : uint
    {
        Animal,
        Building,
        Castle,
        Knowledge,
        Mine,
        Ship
    }

    public class Tile
    {
        public TileType Type { get; set; }
        public uint? AnimalCount { get; set; }
        public uint? KnowledgeId { get; set; }
        public Tile(TileType pType)
        {
            Type = pType;
        }

        public Tile(TileType pType, uint pInput)
            :this(pType)
        {
            switch (pType)
            {
                case TileType.Animal:
                    AnimalCount = pInput;
                    break;
                case TileType.Knowledge:
                    KnowledgeId = pInput;
                    break;
                default:
                    break;
            }
        }
    }
}