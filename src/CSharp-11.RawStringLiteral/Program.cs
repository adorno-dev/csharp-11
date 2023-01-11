// Definida usando tres aspas duplas no iniciio e outras tres aspas no final da literal de string

var text1 = """Brute Literal String""";

var text2 = """This is a "raw literal string" """;

var json = """
{
    "name": "Developer",
    "country": "Brazil"
}
""";

// Interpolacao com $

var result1 = $"""21 + 34 = {21 + 34}""";
var result2 = $"""
              21 + 34 = {21 + 34}
              """;

// Interpolacao com $$

result1 = $$"""{21 + 34} = {{21 + 34}}""";
result2 = $$"""
              {21 + 34} = {{21 + 34}}
              """;

text1 = "Developer";
text2 = "Brazil";

json = $$"""
{
    "name": "{{text1}}",
    "country": "{{text2}}"
}
""";

Console.WriteLine(result1);
Console.WriteLine(result2);
Console.WriteLine(json);