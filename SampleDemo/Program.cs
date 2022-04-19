//NOTE: NO USINGS HERE....


const string firstName = "Anthony";
string lastName = "Prince";

Student student1 = new(firstName, lastName, 10);
Console.WriteLine(student1);

const string Greeting = $"Hello {firstName}";

string siblingsName = "David";

var sibling = student1 with { FirstName = siblingsName, Grade = 4 };
Console.WriteLine(sibling);

var student2 = sibling with { FirstName = firstName };
student2.Grade = 10;
Console.WriteLine(student2);

Console.WriteLine(ReferenceEquals(student1, student2)); //False - Not the same object

Console.WriteLine(Equals(student1, student2));  // True - have the same value (Value equality)

Teacher teacher = new("", "", DateTime.Now);
//teacher.JoiningDate = DateTime.Now;  //Not Allowed
Console.WriteLine(teacher);

Console.WriteLine(Equals(student1, teacher));   // False - different types of objects


