using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using QuartzNetTest.Core.Entities;

namespace QuartzNetTest.Core.Database
{
    public class UserAccountsDb : IDatabase<UserAccount>
    {
        private static List<UserAccount> UserAccounts { get; set; }

        public UserAccountsDb()
        {
            UserAccounts = DatabaseData.UserAccounts.ToList();
        }

        public void Create(UserAccount data)
        {
            UserAccounts.Add(data);
        }

        public UserAccount Get(Expression<Func<UserAccount, bool>> filter)
        {
            return UserAccounts.FirstOrDefault(filter.Compile());
        }

        public void Update(Expression<Func<UserAccount, bool>> filter, UserAccount data)
        {
            var account = UserAccounts.FirstOrDefault(filter.Compile());
            var index = UserAccounts.IndexOf(account);
            UserAccounts.RemoveAt(index);
            UserAccounts.Insert(index, data);
        }

        public void Delete(UserAccount data)
        {
            UserAccounts.RemoveAll(x => x.Id == data.Id);
        }
    }
}
