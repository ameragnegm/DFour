namespace EmployeeDatabase
{
    internal class Program
    {


        struct employee 
        {
            public int EmployeeID;
            public string Name;
            public int salary;
            public Department department;
        }

        enum Department
        {
            HR,
            IT,
            Sales,
            Finance
        }
        static void Main(string[] args)
        {
            List<employee> employesslist = new List<employee>();
            employee emp1= new employee { EmployeeID = 12, Name = "Ahmed", salary = 3000,  department = Department.IT };
            employee emp2 = new employee { EmployeeID = 24, Name = "Amr", salary = 5000, department = Department.Sales };
            employee emp3 = new employee { EmployeeID = 19, Name = "Islam", salary = 7000, department = Department.Finance };
            int totalsalary = 0;
            employee highemp = new employee();
            int highestsal = 0; 
            employesslist.Add(emp1);
            employesslist.Add(emp2);
            employesslist.Add(emp3);

            foreach (employee emp in employesslist) {
                totalsalary += emp.salary;
                if (highestsal < emp.salary)
                {
                    highemp = emp; 
                    highestsal = emp.salary;
                }
            }


            Console.WriteLine($"Total salaries for all employees : {totalsalary}\n");
            Console.WriteLine($"The Highest paid employee :\n\n Department: {highemp.department}, Name: {highemp.Name}, Salary: {highemp.salary}");
        }
    }
}
