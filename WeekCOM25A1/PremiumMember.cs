using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekCOM25A1
{
    internal class PremiumMember:Member
    {
        private double trainerFee;

        public PremiumMember(string memeberId, string memberName, double monthlyfee, double trainerFee) : base(memeberId, memberName, monthlyfee)
        {
            this.trainerFee = trainerFee;
        }

        public double TrainerFee { get => trainerFee; set => trainerFee = value; }

        public override double CalculateFee()
        {
            return Monthlyfee + trainerFee;
        }

        public override double CalculateFee(int months)
        {
            return (Monthlyfee+trainerFee) * months;
        }
    }
}
