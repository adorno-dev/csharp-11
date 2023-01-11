// Auto-default struct

// No C# 11 o compilador agora garante que todos os campos de um tipo struct sejam inicializados com seu valor 
// padrao como parte da execucao de um construtor.

using CSharp_11.AutoDefaultStruct;

Triangle triangle1 = new ();

// triangle1.Base = 10;
// triangle1.Height = 5;
// triangle1.GetArea();

