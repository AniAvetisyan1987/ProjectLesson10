namespace ProjectLesson10
{
    internal class SalaryClass
    {
        public double salary;
        public float tax;
        public float social;
        public float stamp;

        public SalaryClass(ref double  salary, float tax, float social, float stamp)
        {
            this.salary = salary;
            this.tax = tax;                
            this.social = social;
            this.stamp = stamp;
            SalaryCalc();
            salary = this.salary;

        }

        public void  SalaryCalc()
        {
            double percent = tax + social + stamp;
            salary = Math.Round(salary * percent);

        }
    }
}
