namespace SkyNeg.Telegram.Bot.Abstraction.Models
{
    public class UpdateResult
    {
        public static UpdateResult FromError(ErrorCode code, string message) => new() { Error = new UpdateError(code, message) };
        public static UpdateResult FromError(ErrorCode code) => new() { Error = new UpdateError(code, string.Empty) };
        public static UpdateResult FromSuccess() => new() { };

        public UpdateError? Error { get; set; }
    }
}
