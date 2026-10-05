/*
 * TodoApp
 * 1. Visa sina todos (läs in en fil med olika todos)
 * 2. Lägg till en ny todo
 * 3. Ändra en todo
 * 4. Ta bort en todo */
using System.Text.Json;
using TodoApp;

string jsonFile = File.ReadAllText("todos.json");

Console.WriteLine($"Läser/skriver till: {Path.GetFullPath("todos.json")}");

//Console.WriteLine(jsonFile);

List<Todo> todos = JsonSerializer.Deserialize<List<Todo>>(jsonFile);

while (true)
{
    Console.WriteLine("----TodoApp----");
    Console.WriteLine("1. Visa dina todos");
    Console.WriteLine("2. Lägg till en ny todo");
    Console.WriteLine("3. Avsluta");

    Console.Write("Välj ett alternativ: ");
    int choice = int.Parse(Console.ReadLine());

    if (choice == 1)
    {
        foreach (Todo todo in todos)
        {
            Console.WriteLine($"----Todo {todo.Id}----");
            Console.WriteLine($"Text: {todo.Text}");
            Console.WriteLine($"Är klar: {todo.Done}");
            Console.WriteLine($"--------");
        }
    }
    else if (choice == 2)
    {
        Console.Write("Skriv din todo: ");
        string text = Console.ReadLine();
        todos.Add(new Todo
        {
            Id = todos.Count + 1,
            Text = text,
            Done = false
        });

        string jsonText = JsonSerializer.Serialize(todos, new JsonSerializerOptions
        {
            WriteIndented = true
        });
        File.WriteAllText("todos.json", jsonText);
    }
    else if (choice == 3)
    {
        break;
    }
    else
    {
        Console.WriteLine("Ogitligt val");
    }
}


