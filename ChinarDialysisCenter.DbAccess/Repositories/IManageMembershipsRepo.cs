using ChinarDialysisCenter.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinarDialysisCenter.DbAccess.Repositories
{
    public interface IManageMembershipsRepo
    {
        Task<bool> AddMembership(Membership membership);
    }
}
