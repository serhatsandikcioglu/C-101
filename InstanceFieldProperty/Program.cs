        // Syntax
        // Class ClassName
        //{
        //    [Access Modifiers]    [Data Type] PropertyName:
        //    [Access Modifiers]    [Return Type] MethodsName ([List of parameters])
        //    {
        //        // Operations
        //    }

        //Access Modifiers
        // * Public
        // * Private
        // * Internal
        // * Protected




        Employee employeeOne = new Employee();
        employeeOne.Name = "Ayşe";
        employeeOne.LastName = "Kara";
        employeeOne.No = 23425634;
        employeeOne.Department = "İnsan Kaynakları";

        employeeOne.GetEmployeeInfo();
        
        Console.WriteLine("************");

        Employee employeeTwo = new Employee();
        employeeTwo.Name = "Deniz";
        employeeTwo.LastName = "Arda";
        employeeTwo.No = 123434;
        employeeTwo.Department = "Satın Alma";

        employeeTwo.GetEmployeeInfo();
       
    }

    class Employee
    {
        public string Name;
        public string LastName;
        public int No;
        public string Department;

        public void GetEmployeeInfo()
        {
            Console.WriteLine("Name of the employee: {0}",Name);
            Console.WriteLine("Last Name of the employee: {0}",LastName);
            Console.WriteLine("Id of the employee: {0}",No);
            Console.WriteLine("Department of the employee: {0}",Department);
        }
