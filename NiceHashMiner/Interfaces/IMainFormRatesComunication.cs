﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiceHashMiner.Interfaces {
    public interface IMainFormRatesComunication {

        void ClearRates(int groupCount);
        void AddRateInfo(string groupName, string deviceStringInfo, APIData iAPIData, double paying);
        void ShowNotProfitable();
        void HideNotProfitable();
    }
}