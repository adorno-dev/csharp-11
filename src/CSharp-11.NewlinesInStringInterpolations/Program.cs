// Newlines in string interpolations

// No C# 11 uma expressao dentro da interpolacao pode ser movida para uma nova linha
// Assim o texto dentro dos caracteres { e } para uma interpolacao de string agora pode abranger varias linhas.

var name = "CSharp 11";
var greetings = $"Welcome {name.ToLower()}"; // Ok
var error = $"Welcome {name. // Antes do C# 11 dava erro.
ToLower()}";
