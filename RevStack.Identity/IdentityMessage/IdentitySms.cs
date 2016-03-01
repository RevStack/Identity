using System;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

namespace RevStack.Identity
{
    public interface IIdentitySmsService : IIdentityMessageService
    {
        string Id { get; }
        Task SendAsync(IdentityMessage message, string senderAddress);
    }
}
