using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BurgundyServer.GameClasses;

namespace BurgundyServer.Models
{
    public enum SpaceName : uint
    {
        SilverlingStorage,
        GoodsStorage1, GoodsStorage2, GoodsStorage3, GoodsSoldCollector,
        Die1, Die2,
        Workers,
        TileStorage1, TileStorage2, TileStorage3,
        Row1Space1, Row1Space2, Row1Space3, Row1Space4,
        Row2Space1, Row2Space2, Row2Space3, Row2Space4, Row2Space5,
        Row3Space1, Row3Space2, Row3Space3, Row3Space4, Row3Space5, Row3Space6,
        Row4Space1, Row4Space2, Row4Space3, Row4Space4, Row4Space5, Row4Space6, Row4Space7,
        Row5Space1, Row5Space2, Row5Space3, Row5Space4, Row5Space5, Row5Space6,
        Row6Space1, Row6Space2, Row6Space3, Row6Space4, Row6Space5,
        Row7Space1, Row7Space2, Row7Space3, Row7Space4,
        Phase1, Phase2, Phase3, Phase4, Phase5,
        PhaseGoods1, PhaseGoods2, PhaseGoods3, PhaseGoods4, PhaseGoods5,
        BlackMarket1, BlackMarket2, BlackMarket3, BlackMarket4, BlackMarket5, BlackMarket6, BlackMarket7, BlackMarket8,
        Market1Space1, Market1Space2, Market1Space3, Market1Space4,
        Market2Space1, Market2Space2, Market2Space3, Market2Space4,
        Market3Space1, Market3Space2, Market3Space3, Market3Space4,
        Market4Space1, Market4Space2, Market4Space3, Market4Space4,
        Market5Space1, Market5Space2, Market5Space3, Market5Space4,
        Market6Space1, Market6Space2, Market6Space3, Market6Space4,
        GoodsMarket1, GoodsMarket2, GoodsMarket3, GoodsMarket4, GoodsMarket5, GoodsMarket6,
        FillTile11, FillTile12,
        FillTile21, FillTile22,
        FillTile31, FillTile32,
        FillTile41, FillTile42,
        FillTile51, FillTile52,
        FillTile61, FillTile62,
        Ship1, Ship2, Ship3, Ship4, Ship5, Ship6, Ship7
    }

    public enum BoardName : uint
    {
        Three
    }
    public class Board
    {
        public Dictionary<SpaceName, BoardSpace> BoardSpaces { get; set; }
        private Dictionary<BoardName, BoardSpace[]> BoardLayout = new Dictionary<BoardName, BoardSpace[]>();

        public Board(BoardName pName)
        {
            BuildLayoutThree();
            BoardSpaces = new Dictionary<SpaceName, BoardSpace>();
            BoardSpaces[SpaceName.SilverlingStorage] = new BoardSpace(BoardSpaceType.SilverlingStorage);
            BoardSpaces[SpaceName.GoodsStorage1] = new BoardSpace(BoardSpaceType.GoodsStorage);
            BoardSpaces[SpaceName.GoodsStorage2] = new BoardSpace(BoardSpaceType.GoodsStorage);
            BoardSpaces[SpaceName.GoodsStorage3] = new BoardSpace(BoardSpaceType.GoodsStorage);
            BoardSpaces[SpaceName.GoodsSoldCollector] = new BoardSpace(BoardSpaceType.GoodsSold);
            BoardSpaces[SpaceName.Die1] = new BoardSpace(BoardSpaceType.Die);
            BoardSpaces[SpaceName.Die2] = new BoardSpace(BoardSpaceType.Die);
            BoardSpaces[SpaceName.Workers] = new BoardSpace(BoardSpaceType.WorkerCount);
            BoardSpaces[SpaceName.TileStorage1] = new BoardSpace(BoardSpaceType.TileStorage);
            BoardSpaces[SpaceName.TileStorage2] = new BoardSpace(BoardSpaceType.TileStorage);
            BoardSpaces[SpaceName.TileStorage3] = new BoardSpace(BoardSpaceType.TileStorage);
            BoardSpaces[SpaceName.Phase1] = new BoardSpace(BoardSpaceType.PhaseCounter);
            BoardSpaces[SpaceName.Phase2] = new BoardSpace(BoardSpaceType.PhaseCounter);
            BoardSpaces[SpaceName.Phase3] = new BoardSpace(BoardSpaceType.PhaseCounter);
            BoardSpaces[SpaceName.Phase4] = new BoardSpace(BoardSpaceType.PhaseCounter);
            BoardSpaces[SpaceName.Phase5] = new BoardSpace(BoardSpaceType.PhaseCounter);
            BoardSpaces[SpaceName.PhaseGoods1] = new BoardSpace(BoardSpaceType.PhaseGoods);
            BoardSpaces[SpaceName.PhaseGoods2] = new BoardSpace(BoardSpaceType.PhaseGoods);
            BoardSpaces[SpaceName.PhaseGoods3] = new BoardSpace(BoardSpaceType.PhaseGoods);
            BoardSpaces[SpaceName.PhaseGoods4] = new BoardSpace(BoardSpaceType.PhaseGoods);
            BoardSpaces[SpaceName.PhaseGoods5] = new BoardSpace(BoardSpaceType.PhaseGoods);
            BoardSpaces[SpaceName.BlackMarket1] = new BoardSpace(BoardSpaceType.BlackMarket);
            BoardSpaces[SpaceName.BlackMarket2] = new BoardSpace(BoardSpaceType.BlackMarket);
            BoardSpaces[SpaceName.BlackMarket3] = new BoardSpace(BoardSpaceType.BlackMarket);
            BoardSpaces[SpaceName.BlackMarket4] = new BoardSpace(BoardSpaceType.BlackMarket);
            BoardSpaces[SpaceName.BlackMarket5] = new BoardSpace(BoardSpaceType.BlackMarket);
            BoardSpaces[SpaceName.BlackMarket6] = new BoardSpace(BoardSpaceType.BlackMarket);
            BoardSpaces[SpaceName.BlackMarket7] = new BoardSpace(BoardSpaceType.BlackMarket);
            BoardSpaces[SpaceName.BlackMarket8] = new BoardSpace(BoardSpaceType.BlackMarket);
            BoardSpaces[SpaceName.GoodsMarket1] = new BoardSpace(BoardSpaceType.GoodsMarket);
            BoardSpaces[SpaceName.GoodsMarket2] = new BoardSpace(BoardSpaceType.GoodsMarket);
            BoardSpaces[SpaceName.GoodsMarket3] = new BoardSpace(BoardSpaceType.GoodsMarket);
            BoardSpaces[SpaceName.GoodsMarket4] = new BoardSpace(BoardSpaceType.GoodsMarket);
            BoardSpaces[SpaceName.GoodsMarket5] = new BoardSpace(BoardSpaceType.GoodsMarket);
            BoardSpaces[SpaceName.GoodsMarket6] = new BoardSpace(BoardSpaceType.GoodsMarket);
            BoardSpaces[SpaceName.Market1Space1] = new BoardSpace(BoardSpaceType.NumberedMarket);
            BoardSpaces[SpaceName.Market1Space2] = new BoardSpace(BoardSpaceType.NumberedMarket);
            BoardSpaces[SpaceName.Market1Space3] = new BoardSpace(BoardSpaceType.NumberedMarket);
            BoardSpaces[SpaceName.Market1Space4] = new BoardSpace(BoardSpaceType.NumberedMarket);
            BoardSpaces[SpaceName.Market2Space1] = new BoardSpace(BoardSpaceType.NumberedMarket);
            BoardSpaces[SpaceName.Market2Space2] = new BoardSpace(BoardSpaceType.NumberedMarket);
            BoardSpaces[SpaceName.Market2Space3] = new BoardSpace(BoardSpaceType.NumberedMarket);
            BoardSpaces[SpaceName.Market2Space4] = new BoardSpace(BoardSpaceType.NumberedMarket);
            BoardSpaces[SpaceName.Market3Space1] = new BoardSpace(BoardSpaceType.NumberedMarket);
            BoardSpaces[SpaceName.Market3Space2] = new BoardSpace(BoardSpaceType.NumberedMarket);
            BoardSpaces[SpaceName.Market3Space3] = new BoardSpace(BoardSpaceType.NumberedMarket);
            BoardSpaces[SpaceName.Market3Space4] = new BoardSpace(BoardSpaceType.NumberedMarket);
            BoardSpaces[SpaceName.Market4Space1] = new BoardSpace(BoardSpaceType.NumberedMarket);
            BoardSpaces[SpaceName.Market4Space2] = new BoardSpace(BoardSpaceType.NumberedMarket);
            BoardSpaces[SpaceName.Market4Space3] = new BoardSpace(BoardSpaceType.NumberedMarket);
            BoardSpaces[SpaceName.Market4Space4] = new BoardSpace(BoardSpaceType.NumberedMarket);
            BoardSpaces[SpaceName.Market5Space1] = new BoardSpace(BoardSpaceType.NumberedMarket);
            BoardSpaces[SpaceName.Market5Space2] = new BoardSpace(BoardSpaceType.NumberedMarket);
            BoardSpaces[SpaceName.Market5Space3] = new BoardSpace(BoardSpaceType.NumberedMarket);
            BoardSpaces[SpaceName.Market5Space4] = new BoardSpace(BoardSpaceType.NumberedMarket);
            BoardSpaces[SpaceName.Market6Space1] = new BoardSpace(BoardSpaceType.NumberedMarket);
            BoardSpaces[SpaceName.Market6Space2] = new BoardSpace(BoardSpaceType.NumberedMarket);
            BoardSpaces[SpaceName.Market6Space3] = new BoardSpace(BoardSpaceType.NumberedMarket);
            BoardSpaces[SpaceName.Market6Space4] = new BoardSpace(BoardSpaceType.NumberedMarket);
            BoardSpaces[SpaceName.FillTile11] = new BoardSpace(BoardSpaceType.TypeCompleteTile);
            BoardSpaces[SpaceName.FillTile12] = new BoardSpace(BoardSpaceType.TypeCompleteTile);
            BoardSpaces[SpaceName.FillTile21] = new BoardSpace(BoardSpaceType.TypeCompleteTile);
            BoardSpaces[SpaceName.FillTile22] = new BoardSpace(BoardSpaceType.TypeCompleteTile);
            BoardSpaces[SpaceName.FillTile31] = new BoardSpace(BoardSpaceType.TypeCompleteTile);
            BoardSpaces[SpaceName.FillTile32] = new BoardSpace(BoardSpaceType.TypeCompleteTile);
            BoardSpaces[SpaceName.FillTile41] = new BoardSpace(BoardSpaceType.TypeCompleteTile);
            BoardSpaces[SpaceName.FillTile42] = new BoardSpace(BoardSpaceType.TypeCompleteTile);
            BoardSpaces[SpaceName.FillTile51] = new BoardSpace(BoardSpaceType.TypeCompleteTile);
            BoardSpaces[SpaceName.FillTile52] = new BoardSpace(BoardSpaceType.TypeCompleteTile);
            BoardSpaces[SpaceName.FillTile61] = new BoardSpace(BoardSpaceType.TypeCompleteTile);
            BoardSpaces[SpaceName.FillTile62] = new BoardSpace(BoardSpaceType.TypeCompleteTile);
            BoardSpaces[SpaceName.Ship1] = new BoardSpace(BoardSpaceType.OrderTracker);
            BoardSpaces[SpaceName.Ship2] = new BoardSpace(BoardSpaceType.OrderTracker);
            BoardSpaces[SpaceName.Ship3] = new BoardSpace(BoardSpaceType.OrderTracker);
            BoardSpaces[SpaceName.Ship4] = new BoardSpace(BoardSpaceType.OrderTracker);
            BoardSpaces[SpaceName.Ship5] = new BoardSpace(BoardSpaceType.OrderTracker);
            BoardSpaces[SpaceName.Ship6] = new BoardSpace(BoardSpaceType.OrderTracker);
            BoardSpaces[SpaceName.Ship7] = new BoardSpace(BoardSpaceType.OrderTracker);
            FillBoardSpaces(pName);                
        }

        private void BuildLayoutThree()
        {
            BoardLayout.Add(BoardName.Three, new BoardSpace[]
            {
                new BoardSpace(BoardSpaceType.BoardTile, 6, TileType.Animal),
                new BoardSpace(BoardSpaceType.BoardTile, 5, TileType.Animal),
                new BoardSpace(BoardSpaceType.BoardTile, 4, TileType.Animal),
                new BoardSpace(BoardSpaceType.BoardTile, 3, TileType.Animal),
                new BoardSpace(BoardSpaceType.BoardTile, 2, TileType.Ship),
                new BoardSpace(BoardSpaceType.BoardTile, 1, TileType.Ship),
                new BoardSpace(BoardSpaceType.BoardTile, 6, TileType.Castle),
                new BoardSpace(BoardSpaceType.BoardTile, 5, TileType.Ship),
                new BoardSpace(BoardSpaceType.BoardTile, 4, TileType.Ship),
                new BoardSpace(BoardSpaceType.BoardTile, 5, TileType.Building),
                new BoardSpace(BoardSpaceType.BoardTile, 4, TileType.Mine),
                new BoardSpace(BoardSpaceType.BoardTile, 3, TileType.Knowledge),
                new BoardSpace(BoardSpaceType.BoardTile, 1, TileType.Knowledge),
                new BoardSpace(BoardSpaceType.BoardTile, 2, TileType.Ship),
                new BoardSpace(BoardSpaceType.BoardTile, 3, TileType.Building),
                new BoardSpace(BoardSpaceType.BoardTile, 6, TileType.Building),
                new BoardSpace(BoardSpaceType.BoardTile, 1, TileType.Building),
                new BoardSpace(BoardSpaceType.BoardTile, 2, TileType.Knowledge),
                new BoardSpace(BoardSpaceType.BoardTile, 6, TileType.Castle),
                new BoardSpace(BoardSpaceType.BoardTile, 5, TileType.Knowledge),
                new BoardSpace(BoardSpaceType.BoardTile, 4, TileType.Building),
                new BoardSpace(BoardSpaceType.BoardTile, 1, TileType.Building),
                new BoardSpace(BoardSpaceType.BoardTile, 2, TileType.Building),
                new BoardSpace(BoardSpaceType.BoardTile, 5, TileType.Building),
                new BoardSpace(BoardSpaceType.BoardTile, 4, TileType.Knowledge),
                new BoardSpace(BoardSpaceType.BoardTile, 3, TileType.Knowledge),
                new BoardSpace(BoardSpaceType.BoardTile, 1, TileType.Building),
                new BoardSpace(BoardSpaceType.BoardTile, 2, TileType.Building),
                new BoardSpace(BoardSpaceType.BoardTile, 6, TileType.Castle),
                new BoardSpace(BoardSpaceType.BoardTile, 1, TileType.Animal),
                new BoardSpace(BoardSpaceType.BoardTile, 2, TileType.Mine),
                new BoardSpace(BoardSpaceType.BoardTile, 5, TileType.Mine),
                new BoardSpace(BoardSpaceType.BoardTile, 6, TileType.Castle),
                new BoardSpace(BoardSpaceType.BoardTile, 3, TileType.Building),
                new BoardSpace(BoardSpaceType.BoardTile, 4, TileType.Animal),
                new BoardSpace(BoardSpaceType.BoardTile, 1, TileType.Ship),
                new BoardSpace(BoardSpaceType.BoardTile, 3, TileType.Building)
            });
        }

        private void FillBoardSpaces(BoardName pName)
        {
            BoardSpace[] board = BoardLayout[pName];
            for (uint i = 0; i < 37; i++)
            {
                BoardSpaces.Add((SpaceName)(i+(uint)SpaceName.Row1Space1), board[i]);
            }
        }
    }
}