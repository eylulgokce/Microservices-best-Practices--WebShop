﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CostumerService.Database
{
    interface ICostumerDatabase
    {
        int FindCostumerID(string firstname, string lastname, string email);
    }
}
