using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7 {
    class MutualFund : InvestmentAccount {

        protected const float ServiceChargePercent = 0.01f;
        const float GrowthPercent = 0.01f;

        public MutualFund() : base() {
        }

        public override void AddMoney(float amount) {
            base.AddMoney(amount * (1 - ServiceChargePercent));
        }

        public override string ToString() {
            return base.ToString();
        }

        public override void UpdateBalance() {
            balance *= 1 + GrowthPercent;
        }
    }
}
