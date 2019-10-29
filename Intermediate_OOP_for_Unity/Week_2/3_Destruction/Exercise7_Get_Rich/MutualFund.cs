using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7 {
    class MutualFund : InvestmentAccount {

        const float ServiceChargePercent = 0.01f;

        public MutualFund() : base() {
        }

        public override void AddMoney(float amount) {
            base.AddMoney(amount);
        }

        public override string ToString() {
            return base.ToString();
        }

        public override void UpdateBalance() {
            throw new NotImplementedException();
        }
    }
}
