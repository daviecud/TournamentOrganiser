﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganiserLibrary
{
   public interface IDataConnection
    {
        PrizeModel CreatePrize(PrizeModel model);
    }
}