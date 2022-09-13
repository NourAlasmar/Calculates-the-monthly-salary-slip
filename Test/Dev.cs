namespace Test
{
    partial class Program
    {
        public class Dev : Employee
        {
            private const decimal Commission = 0.03m;

            public Dev(int id, string name, decimal loggedHoures, decimal wage, bool taskCompleted) : base(id, name, loggedHoures, wage)
            {
                this.TaskCompleted = taskCompleted;
            }

            private bool TaskCompleted { get; set; }

            protected decimal CalculateBounes()
            {
                if (TaskCompleted == true)
                    return base.Calculate() * Commission;
                    return 0;
            }
            protected override decimal Calculate()
            {
                return base.Calculate() + CalculateBounes();
            }

            public override string ToString()
            {
                Console.WriteLine(Dee.Dev);
                return base.ToString()
                    + $"\nTaskComplited ? {(TaskCompleted ? "Yes" : "No")}"
                    + $"\nBounes = {CalculateBounes():N0}"
                    + $"\nNetSalary ${Math.Round(this.Calculate(), 2):N0}";
            }
        }
    }
}
