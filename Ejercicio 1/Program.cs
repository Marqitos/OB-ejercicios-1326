// Escribe un programa que reciba tu nombre y lo escriba por consola.
string? name;
do {
    Console.WriteLine("Escribe tu nombre:");
    name = Console.ReadLine();
    if(string.IsNullOrEmpty(name)) {
        Console.WriteLine("Debes especificar un nombre");
    }
} while (string.IsNullOrEmpty(name));

Console.WriteLine($"Hola {name}.");
