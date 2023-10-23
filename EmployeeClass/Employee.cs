namespace EmployeeClass;
class Employee
{
    private int id, salary;
    private string firstName, lastName;

    public Employee(int id, string firstName, string lastName, int salary)
    {
        this.id = id;
        this.firstName = firstName;
        this.lastName = lastName;
        this.salary = salary;
    }

    public int getId()
    {
        return id;
    }
    public string getFirstName()
    {   
        return firstName;
    }
    public string getLastName()
    {
        return lastName;
    }
    public string getName()
    {
        return firstName + " " + lastName;
    }
    public int Salary
    {
        get { return salary; }
        set { salary = value; }
    }
    public int getAnnualSalary()
    {
        return salary * 12;
    }
    public int raiseSalary(int percent)
    {
        salary += salary * percent / 100;
        return salary;
    }

    public override string ToString()
    {
        return $"Employee [id={id},name={getName()}, salary={salary}]";
    }
    //public override string ToString()
    //{
    //    return "Employee[id =" + id + " name=" + getName() + " salary=" + salary + "]";
    //}
}
