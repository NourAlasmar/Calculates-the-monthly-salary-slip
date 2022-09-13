namespace Test
{
    partial class Program
    {


        static void Main(string[] args)
        {

            Manger m = new Manger(1000, "Ahmad", 15, 10);

            Maintinace m1 = new Maintinace(1001, "Nour", 180, 14);

            Sales m2 = new Sales(101, "Hero", 140, 15, 10000m, 0.50m);

            Dev m3 = new Dev(1, "Nour", 188, 141, true);

            Employee[] employees = { m, m1, m2, m3 };
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine("------------------");
                Console.WriteLine(employees[i]);
            }
        }

    }
}
