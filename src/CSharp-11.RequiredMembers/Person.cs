using System.Diagnostics.CodeAnalysis;

namespace CSharp_11.RequiredMembers
{
    public class Person
    {
        public required string? Name { get; set; }        
        public required int Age { get; set; }

        public Person() {}

        [SetsRequiredMembers]
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}