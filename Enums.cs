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
        CorporateEarnings
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
        SellAsset
    }

    /// <summary>
    /// Defines the Payload Type for a sent message to In-Game Endpoint
    /// </summary>
    public enum ToInGamePayloadType
    {
        _NOTYETKNOWN = 1
    }


}
