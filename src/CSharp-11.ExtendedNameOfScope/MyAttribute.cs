namespace CSharp_11.ExtendedNameOfScope
{
    public class MyAttribute : Attribute
    {
        public string Parameter { get; set; }

        public MyAttribute(string parameter) => Parameter = parameter;
    }
}