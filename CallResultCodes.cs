namespace TequaCreek.BloxStoxDataModelLibrary
{

    /// <summary>
    /// Defines the returned Call Result Code to the In-Game Endpoint within the payload message, indicating 
    /// success or some failure condition for the query or action request within the payload message
    /// </summary>
    /// <summary>
    /// Defines the call result codes for payload-based inquiries or action requests from In-Game Endpoint
    /// </summary>
    public enum CallResultCode
    {
        Success = 1,
        GamePlayerNotFound,
        GamePlayerAlreadyExists,
        NoResults,
        MarketNotOpen,
        InvalidUnitsSpecified,
        InsufficientCashAvailable,
        InsufficientUnitsAvailable,
        InvalidTradingSymbol
    }


}
