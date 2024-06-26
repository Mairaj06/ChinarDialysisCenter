using ChinarDialysisCenter.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinarDialysisCenter.Business.Interfaces
{
    public interface IManageMemberships
    {
        Task<bool> AddMemberShip(Membership membership);
    }
}
