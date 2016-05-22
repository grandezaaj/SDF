using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    abstract class Member
    {
        private string name;
        private byte age;
        private decimal discount = .1M;
        private decimal points;

        public byte Age
        {
            get { return age; }
            set { age = value; }
        }
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public decimal Discount
        {
            get { return this.discount; }
        }

        public decimal Points
        {
            get { return this.points; }
        }

        public virtual decimal GetDiscount()
        {
            return this.discount;
        }

        public void AddPoints(decimal points)
        {
            this.points += points;
        }
    }

    class Gold : Member
    {        
        public override decimal GetDiscount()
        {
            return base.Discount + .05M;
        }

        public Gold(string name, byte age)
        {
            base.Name = name;
            base.Age = age;
        }

    }

    class Silver : Member
    {
        public decimal GetRebate()
        {
            return .01M;
        }

        public Silver(string name, byte age)
        {
            base.Name = name;
            base.Age = age;
        }
    }

    class Bronze: Member
    {

    }

    class MemberServices
    {
        public void AccountMaintenance(Member member)
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Gold goldMember = new Gold("Digong", 71);
            Silver silverMember = new Silver("Roxas", 60);

            MemberServices services = new MemberServices();
            services.AccountMaintenance(silverMember);

        }
    }
}
