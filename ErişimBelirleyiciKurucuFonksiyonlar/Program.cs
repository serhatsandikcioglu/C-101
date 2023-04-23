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


  
        Console.WriteLine("****Employee One****");
        Employee employeeOne = new Employee();
        employeeOne.Name = "Ayşe";
        employeeOne.LastName = "Kara";
        employeeOne.No = 23425634;
        employeeOne.Department = "İnsan Kaynakları";
        employeeOne.GetEmployeeInfo();
        Console.WriteLine("****Employee Two****");
        Employee employeeTwo = new Employee();
        employeeTwo.Name = "Deniz";
        employeeTwo.LastName = "Arda";
        employeeTwo.No = 123434;
        employeeTwo.Department = "Satın Alma";

        employeeTwo.GetEmployeeInfo();
       
        Console.WriteLine("****Employee Three****");
        Employee employeeThree = new Employee("Serhat","Sandıkçıoğlu");
        employeeThree.GetEmployeeInfo();

    class Employee
    {
        public string Name;
        public string LastName;
        public int No;
        public string Department;


        public Employee(string name, string lastName, int no, string department)
        {
            this.Name = name;
            this.LastName = lastName;
            this.No = no;
            this.Department = department;
            
        }
        
        public Employee(){}
        
       public Employee(string name, string lastName)
        {
            this.Name = name;
            this.LastName = lastName;
                
        }
        public void GetEmployeeInfo()
        {
            Console.WriteLine("Name of the employee: {0}",Name);
            Console.WriteLine("Last Name of the employee: {0}",LastName);
            Console.WriteLine("Id of the employee: {0}",No);
            Console.WriteLine("Department of the employee: {0}",Department);
        }
     }
