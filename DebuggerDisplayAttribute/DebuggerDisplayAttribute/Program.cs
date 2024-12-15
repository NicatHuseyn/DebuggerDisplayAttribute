
using System.Diagnostics;

Person person = new Person() 
{ 
    Name = "Nijat",
    Age = 22,
    City = "Baku",
    Region = "Tovuz" 
};

var p = person;

Console.WriteLine(p);


[DebuggerDisplay("Name={Name} | Age={Age} | City={City} | Region={Region}")]
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string City { get; set; }
    public string Region { get; set; }
}

