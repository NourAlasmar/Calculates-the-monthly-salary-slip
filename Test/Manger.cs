namespace Test
{
    partial class Program
    {
        public class Manger : Employee
        {
            private const decimal AllownceRate = 0.05m;

            public Manger(int id, string name, decimal loggedHoures, decimal wage) : base(id, name, loggedHoures, wage)
            {
            }

            protected override decimal Calculate()
            {
                return base.Calculate() + CaluclateAllowens();
            }

            private decimal CaluclateAllowens()
            {
                return  base.Calculate() * AllownceRate;
            }

            public override string ToString()
            {
                return base.ToString()
                    + $"\nAllownce ${Math.Round(CaluclateAllowens(),2) :N0}"
                    + $"\nNetSalary ${Math.Round(this.Calculate(),2) :N0}";
            }
        }
    }
}
