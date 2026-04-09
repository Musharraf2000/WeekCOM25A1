using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekCOM25A1
{
    internal class Member
    {
        private string memeberId;
        private string memberName;
        private double monthlyfee;

        public Member(string memeberId, string memberName, double monthlyfee)
        {
            this.memeberId = memeberId;
            this.memberName = memberName;
            this.monthlyfee = monthlyfee;
        }

        public string MemeberId { get => memeberId; set => memeberId = value; }
        public string MemberName { get => memberName; set => memberName = value; }
        public double Monthlyfee { get => monthlyfee; set => monthlyfee = value; }

        public virtual double CalculateFee()
        {
            return monthlyfee;
        }

        public virtual double CalculateFee(int months)
        {
            return monthlyfee * months;
        }
    }
}
