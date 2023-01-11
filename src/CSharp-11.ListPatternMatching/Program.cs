// List pattern matching ou correspondencia de padroes de lista

// 1. Discard pattern ou padrao descartar

// O pattern discard (_) pode ser utilizado para referenciar um unico elemento de um array ou list

// 2. Range pattern ou padrao de intervalo

// O pattern range (..) permite referenciar zero ou mais elementos

// 3. Var pattern ou padrao de var

// O pattern var pode ser usado para um novo array ou list, em um processo de "fatiamento" (slice) de uma referencia baseada nessas estruturas

DiscardPattern();
RangePattern();
VarPattern();

void DiscardPattern()
{
    Console.WriteLine("[Discard Pattern]");

    int[] intNumbers = {1, 2, 3, 5, 8};

    bool result = false;

    result = intNumbers is [1, _, _, _, _]; // True

    Console.WriteLine(result);

    result = intNumbers is [_, _, _, 3, _]; // False

    Console.WriteLine(result);

    result = intNumbers is [2, _, 3, _, _]; // False

    Console.WriteLine(result);
}

void RangePattern()
{
    Console.WriteLine("[Range Pattern]");

    int[] intNumbers = {1, 2, 3, 5, 8};

    bool result = false;

    result = intNumbers is [.., 8];

    Console.WriteLine(result);

    result = intNumbers is [.., 3, _];

    Console.WriteLine(result);

    result = intNumbers is [1, .., 8];

    Console.WriteLine(result);
}

void VarPattern()
{
    Console.WriteLine("[Var Pattern]");

    int[] intNumbers = {1, 2, 3, 5, 8};

    // Matches

    if (intNumbers is [.., var penultimate, var last])
    {
        Console.WriteLine($"Penultimate = {penultimate}");
        Console.WriteLine($"Last = {last}");
    }
    else
        Console.WriteLine("It doesn't match.");
    
    Console.WriteLine();
    
    // Doesn't matches

    int[] numbers = {1};

    if (numbers is [var first, var second, ..])
    {
        Console.WriteLine($"First = {first}");
        Console.WriteLine($"Second = {second}");
    }
    else
        Console.WriteLine("It doesn't match.");
}