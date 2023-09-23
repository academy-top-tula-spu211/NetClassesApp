Manager manager = new();
manager.Name = "Bob";
manager.Age = 24;

Console.WriteLine(manager);

Employee employee = new Manager();

Object obj1 = new Manager();
Object obj2 = new Employee();
object obj3 = new Object();


int n = 123;
object o = new Employee();
Employee? e = (o as Employee);

Console.WriteLine(manager is Employee);


class Employee
{
    public string? Name { set; get; }
    public int Age { set; get; }

    public Employee() : this("anonim", 0)
    {
        Console.WriteLine("Construct base class");
    }
    public Employee(string? name) : this(name, 0) { }
    public Employee(int age) : this("anonim", age) { }
    
    public Employee(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public string Info()
    {
        return $"Name: {Name}, Age: {Age}";
    }

    public string InfoProp
    {
        get
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }

    public override string ToString()
    {
        return $"Manager. Name: {Name}, Age: {Age}";
    }
}

sealed class Manager : Employee
{
    public string Department { set; get; }

    public Manager() 
    {
        Console.WriteLine("Construct child class");
    }

    public Manager(string name, int age, string department)
        : base(name, age)
    {
        Department = department;
    }

    public string Info()
    {
        return base.Info() + $", Department: {Department}";
    }
}

