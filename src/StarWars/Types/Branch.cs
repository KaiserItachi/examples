using System;
using System.Collections.Generic;
using System.Text;

namespace StarWars.Types
{
    public class Branch
    {
        public int BranchId { get; set; }

        public string BranchCode { get; set; }

        public string Address { get; set; }

        public string Country { get; set; }

        public List<Account> AccountList { get; set; }
    }
}
