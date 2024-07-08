﻿using ChinarDialysisCenter.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinarDialysisCenter.Business.Interfaces
{
    public interface IManageBox
    {
        Task<List<BoxesView>> GetBoxes(Boxes box);
        Task<bool> SaveBox(Boxes box);
        Task<bool> UpdateBox(Boxes box);
        Task<bool> DeleteBox(Boxes box);
    }
}
