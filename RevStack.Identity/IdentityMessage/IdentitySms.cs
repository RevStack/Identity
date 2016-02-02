using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

namespace RevStack.Identity
{
    public interface IIdentitySmsService : IIdentityMessageService
    {
        string Id { get; }
    }
}
