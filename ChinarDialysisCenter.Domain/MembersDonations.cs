using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinarDialysisCenter.Domain
{
    public class MembersDonations
    {
        public int Id { get; set; }
        public int DonatedBy { get; set; }
        public int ReceivedBy { get; set; }
        public DateTime DonationDate { get; set; }
        public decimal Amount {  get; set; }
        public int DonationSource {  get; set; }
        public int DonationReceipt{ get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }

    }
}
