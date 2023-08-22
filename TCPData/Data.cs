using System;
namespace TCPData
{
	public static class Data
	{
		public static List<Employee> GetEmployees()
		{
			List<Employee> employees = new List<Employee>();
			Employee employee = new Employee
			{
				Id = 1,
				FirstName = "Julian",
				LastName = "Huang",
				AnnualSalary = 60000.1m,
				IsManager = true,
				DepartmentId = 1
			};
            employees.Add(employee);
            employee = new Employee
            {
                Id = 2,
                FirstName = "Fiona",
                LastName = "Huang",
                AnnualSalary = 50000.1m,
                IsManager = true,
                DepartmentId = 2
            };
            employees.Add(employee);

            employee = new Employee
            {
                Id = 3,
                FirstName = "Xia",
                LastName = "Huang",
                AnnualSalary = 70000.1m,
                IsManager = true,
                DepartmentId = 1
            };
            employees.Add(employee);

            employee = new Employee
            {
                Id = 4,
                FirstName = "Lucy",
                LastName = "Huang",
                AnnualSalary = 40000.1m,
                IsManager = false,
                DepartmentId = 3
            };
            employees.Add(employee);

            employee = new Employee
            {
                Id = 5,
                FirstName = "Kevin",
                LastName = "Huang",
                AnnualSalary = 30000.1m,
                IsManager = false,
                DepartmentId = 1
            };
            employees.Add(employee);

            return employees;

        }
        public static List<Department> GetDepartments()
        {
            List<Department> departments = new List<Department>();

            Department department = new Department { Id = 1, ShortName = "HR", LongName = "Human Recourses" };
            departments.Add(department);
            department = new Department { Id = 2, ShortName = "FN", LongName = "Finace" };
            departments.Add(department);

            department = new Department { Id = 3, ShortName = "TE", LongName = "Teachnology" };
            departments.Add(department);

            return departments;
        }
    }
}

