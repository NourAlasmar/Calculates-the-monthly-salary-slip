namespace Test
{
    partial class Program
    {
        public class Maintinace : Employee
        {

            private const decimal HardShip = 100m;

            public Maintinace(int id, string name, decimal loggedHoures, decimal wage) : base(id, name, loggedHoures, wage)
            {
            }

            protected override decimal Calculate()
            {
                return base.Calculate() + HardShip;
            }


            public override string ToString()
            {
                return base.ToString()
                    + $"\nHardShip ${Math.Round(HardShip, 2):N0}"
                    + $"\nNetSalary ${Math.Round(this.Calculate(), 2):N0}";
            }
        }
    }
}
