namespace Test
{
    partial class Program
    {
        public const int MiniumnLoggedHours = 167;
        public const decimal OverTimeRate = 1.25m;
        public class Employee
        {

          public  Employee(int id, string name, decimal loggedHoures, decimal wage)
            {
                Id = id;
                Name = name;
                LoggedHoures = loggedHoures;
                Wage = wage;
            }

            protected int Id { get; set; }
            protected string Name { get; set; }

            protected decimal LoggedHoures { get; set; }

            protected decimal Wage { get; set; }

            public virtual decimal CalculateOverTime()
            {
                var additionalHours = LoggedHoures - MiniumnLoggedHours;
                if (additionalHours > 0)
                {
                    return (additionalHours * Wage * OverTimeRate);
                }

                else
                {
                    return 0;
                }

            }

            protected virtual decimal Calculate()
            {
                return CalculateBaseSalary() + CalculateOverTime();
            }

            public decimal CalculateBaseSalary()
             {
               return LoggedHoures * Wage;
             }
            
            public override string ToString()
            {
                return $"\nId :  {Id}"
                    + $"\nName :  {Name}"
                    + $"\nLogged Houres : {LoggedHoures :N0} hrs"
                    + $"\nWage : {Wage :N0}/hr"
                    + $"\nBaseSalary : ${CalculateBaseSalary():N0}"
                    + $"\nOver Time :  ${CalculateOverTime():N0}";
            }
        }

    }
}
