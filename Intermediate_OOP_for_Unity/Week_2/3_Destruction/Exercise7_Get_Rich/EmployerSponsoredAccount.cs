using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7 {
    class EmployerSponsoredAccount : MutualFund {

        public EmployerSponsoredAccount(float deposit) : base(deposit) {
            
        }

        public override void AddMoney(float amount) {
            base.AddMoney(amount * 2);
        }

        public override string ToString() {
            return "Employer Sponsored Account. Balance: " + balance;
        }
    }
}
