// Generic Attributes

// Agora podemos declarar uma classe generica cuja classe base eh System.Attribute.
// Esse recurso fornece uma sintaxe mais conveniente para atributos que requerem um parametro System.Type.

public class MyAttribute : Attribute 
{
    public MyAttribute(Type type) => ParamType = type;

    public Type ParamType { get; set; }
}

public class MyGenericAttribute<T> : Attribute {}

public class Worker
{
    public string? Name { get; set; }

    [MyAttribute(typeof(string))] // Antes do C# 11
    public string? MyMethod() => default;

    [MyGeneric<string>()] // Depois do C# 11
    public string? AnotherMethod() => default;
}