using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7 {
    class EmployerSponsoredAccount : MutualFund {

        public EmployerSponsoredAccount() : base() { 
        }

        public override void AddMoney(float amount) {
            base.AddMoney(amount);
        }

        public override string ToString() {
            return base.ToString();
        }
    }
}
