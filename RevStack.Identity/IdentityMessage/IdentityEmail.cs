using System;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

namespace RevStack.Identity
{
    public interface IIdentityEmailService : IIdentityMessageService
    {
        string Id { get; }
        Task SendAsync(IdentityMessage message, string senderAddress);
    }
}
