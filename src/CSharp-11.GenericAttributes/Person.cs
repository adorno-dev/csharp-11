namespace CSharp_11.GenericAttributes
{
    public class Person
    {
        public string? Name { get; set; }        

        [GenericAttribute<string>()]
        public string? MyMethod() => default;
    }
}