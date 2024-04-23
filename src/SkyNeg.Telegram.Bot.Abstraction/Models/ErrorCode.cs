namespace SkyNeg.Telegram.Bot.Abstraction.Models
{
    public enum ErrorCode
    {
        Unknown = 0,
        CommandNotFound,
        UpdateNotSupported,
        SenderNotAllowed,
        InternalError,
    }
}
