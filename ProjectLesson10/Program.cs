using ProjectLesson10;

internal class Program
{
    private static void Main(string[] args)
    {
        double salary = 200000;
        SalaryClass salary1 = new SalaryClass(ref salary, 0.2f, 0.05f, 0.015f);
        

        salary1.SalaryCalc();
        Console.WriteLine(salary);

        Console.ReadKey();
    }
}