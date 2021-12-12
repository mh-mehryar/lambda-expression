// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Person per = new Person();

per.Database();

// List_Age over 40
var ageOver = per.personList.Where(personList => personList.age>40).OrderByDescending( personList=> personList.age).ToArray();
foreach (var item in ageOver)
{
    System.Console.WriteLine(item.firstName);
    System.Console.WriteLine(item.lastName);
    System.Console.WriteLine(item.age);

}
System.Console.WriteLine("******Salary_Between_10M~13M*****");

var salary = per.personList.Where(n => n.Salary > 10000000  && n.Salary < 13000000).ToArray();
foreach (var item in salary)
{
     System.Console.WriteLine(item.firstName);
    System.Console.WriteLine(item.lastName);
    System.Console.WriteLine(item.Salary);
}
System.Console.WriteLine("******AnyFemale_Salary_Under_3M*****");

bool anyFemale = per.personList.Any(personList => personList.Salary < 3000000);
System.Console.WriteLine(anyFemale);

System.Console.WriteLine("******Sum_Salary_AllPerson*****");

var sumAll = per.personList.Sum(n=>n.Salary);
System.Console.WriteLine(sumAll);

System.Console.WriteLine("*****Male_Salary_Average*****");

var male = per.personList.Where(n=>n.gender == "Male");
var avgSalary = male.Average(n=>n.Salary);
System.Console.WriteLine(avgSalary);

System.Console.WriteLine("******Male_Age_Average*******");

var avgMale_Age = male.Average(n=>n.age);
System.Console.WriteLine(avgMale_Age);