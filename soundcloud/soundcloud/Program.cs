// See https://aka.ms/new-console-template for more information


Album bebra = new();

bebra.print();
class Album
{
    public Album()
    {
        Console.Write("enter album`s name ~# ");

        name = Console.ReadLine();

        Console.Write("enter singer`s name ~# ");

        singer = Console.ReadLine();

        Console.Write("enter date of issue ~# ");

        year = Convert.ToInt32(Console.ReadLine());

        Console.Write("enter duration ~# ");

        duration = Convert.ToInt32(Console.ReadLine());

        Console.Write("enter studio`s name ~# ");

        studio = Console.ReadLine();

    }
    public string name { get; }
    public string singer { get; }
    public int year { get; }
    public int duration { get; }
    public string studio { get; }

    public void print()
    {
        Console.Clear();

        Console.WriteLine(
            $"Album`s name -> {name}\n" +
            $"Singer`s name -> {singer}\n" +
            $"Date of issue -> {year}\n" +
            $"Duration -> {duration}\n" +
            $"Studio -> {studio}");
    }
}

