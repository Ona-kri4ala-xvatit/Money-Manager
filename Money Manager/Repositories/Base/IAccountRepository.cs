﻿using Money_Manager.Context;
using Money_Manager.Models;
using System.Collections.Generic;

namespace Money_Manager.Repositories.Base
{
    public interface IAccountRepository
    {
        public IEnumerable<Account> GetAllAccounts();
    }
}
