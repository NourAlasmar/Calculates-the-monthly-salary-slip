namespace Test
{
    partial class Program
    {
        public class Sales : Employee
        {
            public Sales(int id, string name, decimal loggedHoures, decimal wage,decimal salesVoulemn,decimal Commission) : base(id, name, loggedHoures, wage)
            {
                this.SalesVolume = salesVoulemn;
                this.Commission = Commission;
            }

            private decimal SalesVolume { get; set; }


            private decimal Commission { get; set; }

            private decimal CalculateBounes()
            {
                return SalesVolume * Commission;
            }
            protected override decimal Calculate()
            {
                return base.Calculate() + CalculateBounes();
            }

            public override string ToString()
            {
                Console.WriteLine();
                return base.ToString()
                    + $"\nCalculateBounes ${Math.Round(CalculateBounes(), 2):N0}"
                    + $"\nCommission = {Commission :N0}"
                    + $"\nNetSalary ${Math.Round(this.Calculate(), 2):N0}";
            }
        }
    }




}
