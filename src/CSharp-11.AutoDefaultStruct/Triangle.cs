namespace CSharp_11.AutoDefaultStruct
{
    public struct Triangle 
    {
        public Triangle() {}

        public int Base { get; set; }
        public int Height { get; set; }

        public void GetArea() => Console.WriteLine("Area : " + (Base * Height) / 2);
    }
}