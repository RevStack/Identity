using System;
using Microsoft.AspNet.Identity;

namespace RevStack.Identity
{
    public interface IIdentityRoleStore<TRole> : IRoleStore<TRole> where TRole : class, IIdentityRole
    {
    }
}
