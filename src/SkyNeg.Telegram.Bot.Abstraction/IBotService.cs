using Microsoft.Extensions.Hosting;
using SkyNeg.Telegram.Bot.Abstraction.Models;
using Telegram.Bot.Types;

namespace SkyNeg.Telegram.Bot.Abstraction
{
    public interface IBotService : IHostedService
    {
        string SecretToken { get; }
        Task<UpdateResult> HandleUpdateAsync(Update update, CancellationToken cancellationToken);
    }
}
