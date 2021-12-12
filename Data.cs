public class Person
{
    public string firstName;
    public string lastName;
    public int age;
    public string gender;
    public int Salary;
    public string job;



    public List<Person> personList = new List<Person>();
    public void Database()
    {


        Person p1 = new Person();
        p1.firstName = "MH";
        p1.lastName = "Mehryar";
        p1.age = 36;
        p1.gender = "Male";
        p1.Salary = 10000000;
        p1.job = "Programmer";

        personList.Add(p1);


        Person p2 = new Person();
        p2.firstName = "Sara";
        p2.lastName = "Rezaee";
        p2.age = 45;
        p2.gender = "Female";
        p2.Salary = 5000000;
        p2.job = "Secretory";

        personList.Add(p2);

        Person p3 = new Person();
        p3.firstName = "Mohsen";
        p3.lastName = "Mirzaee";
        p3.age = 40;
        p3.gender = "Male";
        p3.Salary = 8000000;
        p3.job = "Programmer";

        personList.Add(p3);

        Person p4 = new Person();
        p4.firstName = "Arezou";
        p4.lastName = "Ahmadi";
        p4.age = 32;
        p4.gender = "Female";
        p4.Salary = 6000000;
        p4.job = "programmer";

        personList.Add(p4);

        Person p5 = new Person();
        p5.firstName = "Mohsen";
        p5.lastName = "Hosseini";
        p5.age = 51;
        p5.gender = "Male";
        p5.Salary = 15000000;
        p5.job = ".Net Developer";

        personList.Add(p5);

        Person p6 = new Person();
        p6.firstName = "Mahshid";
        p6.lastName = "Hosseini";
        p6.age = 39;
        p6.gender = "Female";
        p6.Salary = 11000000;
        p6.job = ".Net Developer";

        personList.Add(p6);
        
         Person p7 = new Person();
        p7.firstName = "Mitra";
        p7.lastName = "Rezaee";
        p7.age = 41;
        p7.gender = "Female";
        p7.Salary = 12000000;
        p7.job = ".Net Developer";

        personList.Add(p7);
    }









}


