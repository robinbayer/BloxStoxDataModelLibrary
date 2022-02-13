using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TequaCreek.BloxStoxDataModelLibrary
{

    /// <summary>
    /// Defines the current status of a Game Player
    /// </summary>
    public enum PlayerStatus
    {
        Active = 1,
        DepletedBalanceTimeout,
        Suspended,
        Inactive
    }

    /// <summary>
    /// Defines the Transaction Type for a Credit or Debit Transaction
    /// </summary>
    public enum TransactionType
    {
        InitialBalanceAward = 1,
        BuyTransaction,
        SellTransaction,
        ProceedsFromSale,
        WithdrawlForPurchase,
        CommissionFeeEarnings,
        WithdrawlForCommissionFee,
        DividendPayment,
        RejoinBalanceAward,
        OutlayForBalanceAward
    }

    /// <summary>
    /// Defines the Asset Type for an Asset Account
    /// </summary>
    public enum AssetType
    {
        Cash = 1,
        Stock,
        DistributedCorpEarnings
    }

    /// <summary>
    /// Defines the Payload Type for a received message from In-Game Endpoint
    /// </summary>
    public enum FromInGamePayloadType
    {
        SearchGamePlayer = 1,
        AddGamePlayer,
        SearchStockBySymbol,
        SearchStockByKeyword,
        GetCurrentOwnedAssets,
        GetActivityListForPlayer,
        BuyAsset,
        SellAsset,
        OpenManagementThread,
        CloseManagementThread
    }

    /// <summary>
    /// Defines the Payload Type for a received message from External Endpoint
    /// </summary>
    public enum FromExternalPayloadType
    {
        UpdatedTickerInformation = 1,
        UpdatedLeaderboardInformation
    }

    /// <summary>
    /// Defines the type of Ticker Entry List
    /// </summary>
    public enum TickerEntryListType
    {
        GamePlayerOwnedAssets = 1,
        TopXLargestLastTradeSize,
        TopXGainersByValue,
        TopXGainersByPercentage,
        TopXLosersByValue,
        TopXLosersByPercentage
    }

    /// <summary>
    /// Defines the type of Leaderboard Entry List
    /// </summary>
    public enum LeaderboardEntryListType
    {
        OverallByAssetValue = 1,
        OverallByAssetValueByTimeInGame,
        BestEarningsFromDividends,
        BestSellSavingsFromLossPrior7Days,
        BestBuyValueIncreasePrior7Days,
    }

}
