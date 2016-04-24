using System;


namespace RevStack.Identity
{

    /// <summary>
    /// Initializes a new instance of IdentityUser<TKey>
    /// </summary>
    /// <remarks>
    /// The Id property is initialized to from a new GUID string value.
    /// </remarks>
    public class IdentityUser : IdentityUser<string>
    {
        public IdentityUser()
        {
            Id = Guid.NewGuid().ToString();
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TKey">The type used for the primary key for the user.</typeparam>
    public class IdentityUser<TKey> : IIdentityUser<TKey>
    {
        public virtual TKey Id { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Email { get; set; }
        public virtual bool EmailConfirmed { get; set; }
        public virtual string PhoneNumber { get; set; }
        public virtual bool PhoneNumberConfirmed { get; set; }
        public virtual string PasswordHash { get; set; }
        public virtual string SecurityStamp { get; set; }
        public virtual bool IsLockoutEnabled { get; set; }
        public virtual bool IsTwoFactorEnabled { get; set; }
        public virtual int AccessFailedCount { get; set; }
        public virtual DateTimeOffset? LockoutEndDate { get; set; }
        public virtual DateTime SignUpDate { get; set; }
        public override string ToString()
        {
            return UserName;
        }

        public IdentityUser()
        { }
        
    }
}
