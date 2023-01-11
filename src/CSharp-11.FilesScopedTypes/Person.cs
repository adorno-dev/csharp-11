namespace CSharp_11.FilesScopedTypes
{
    public class Person
    {
        public string? Name { get; set; }        

        public int GetIdentification()
        {
            // Acessa a classe pois esta no mesmo arquivo
            var identification = new PersonIdentification();
            return identification.GetDocument;
        }
    }

    // Esta classe sera visivel apenas neste arquivo
    file class PersonIdentification
    {
        public int GetDocument => 123456789;
    }
}