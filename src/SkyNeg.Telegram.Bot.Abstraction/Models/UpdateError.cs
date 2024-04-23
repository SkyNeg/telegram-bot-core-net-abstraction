namespace SkyNeg.Telegram.Bot.Abstraction.Models
{
    public class UpdateError
    {
        public ErrorCode Code { get; }
        public string Message { get; }

        public UpdateError(ErrorCode code, string message)
        {
            Code = code;
            Message = message;
        }
    }
}
