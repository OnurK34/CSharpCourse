Person[] persons = new Person[3]
{
    new Customer{FirstName = "Onur"}, new Student{FirstName = "Adem"}, new Person{FirstName = "Enes"}
};

foreach (var person in persons)
{
    Console.WriteLine(person.FirstName);
}

class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string Lastname { get; set; }
}

class Customer:Person
{
    public string City { get; set; }
}
class Student:Person
{
    public string Deparment { get; set; }
}
