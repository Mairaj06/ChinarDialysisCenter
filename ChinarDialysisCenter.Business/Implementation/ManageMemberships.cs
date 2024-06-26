using ChinarDialysisCenter.Business.Interfaces;
using ChinarDialysisCenter.DbAccess.Repositories;
using ChinarDialysisCenter.Domain;

namespace ChinarDialysisCenter.Business.Implementation
{
    public class ManageMemberships : IManageMemberships
    {
        private readonly IManageMembershipsRepo memberShipRepo;
        public ManageMemberships(IManageMembershipsRepo memberShipRepo)
        {
            this.memberShipRepo = memberShipRepo;   
        }
        public async Task<bool> AddMemberShip(Membership membership)
        {
            return await memberShipRepo.AddMembership(membership);
        }
    }
}
