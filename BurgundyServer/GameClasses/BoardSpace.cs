using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BurgundyServer.GameClasses
{
    public enum BoardSpaceType : uint
    {
        BoardTile,
        GoodsStorage,
        GoodsSold,
        GoodsMarket,
        SilverlingStorage,
        TileStorage,
        WorkerCount,
        Die,
        PhaseCounter,
        PhaseGoods,
        NumberedMarket,
        BlackMarket,
        TypeCompleteTile,
        OrderTracker
    }

    public class BoardSpace
    {
        public BoardSpaceType Type { get; set; }
        public uint? Counter { get; set; }
        public TileType SpaceType { get; set; }
        public BoardSpace(BoardSpaceType pType)
        {
            Type = pType;
        }
        public BoardSpace(BoardSpaceType pType, uint pCount)
            :this(pType)
        {
            switch (pType)
            {
                case BoardSpaceType.GoodsStorage:
                case BoardSpaceType.WorkerCount:
                case BoardSpaceType.Die:
                case BoardSpaceType.NumberedMarket:
                case BoardSpaceType.BoardTile:
                    Counter = pCount;
                    break;
                default:
                    break;
            }            
        }

        public BoardSpace(BoardSpaceType pType, uint pCount, TileType pTile)
            :this (pType, pCount)
        {
            SpaceType = pTile;
        }
    }
}