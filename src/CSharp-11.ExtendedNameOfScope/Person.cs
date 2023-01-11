namespace CSharp_11.ExtendedNameOfScope
{
    public class Person
    {
        private string? name;

        // public string? Name { get; set; }        

        public string? Name
        {
            get => this.name;
            set => this.name = value ?? throw new ArgumentNullException(nameof(value), $"{nameof(Name)} couldn't be null."); // nameof estendido
        }

        public int Age { get; set; }

        public Person() {}

        public Person(string name, int age) => (Name, Age) = (name, age);

        [MyAttribute(nameof(myParameter))] // nameof estendido
        public void MyMethodUsingParameter(string myParameter)
        {

        }
    }
}