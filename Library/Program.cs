using Library;

class Program
{
    static void Main(string[] args)
    {
        Book mybook = new Book("C# for beginners", "BillGates", "1234");
        Book yourbook = new Book("C#Methods", "Microsoft", "3456778");
        Console.WriteLine("Currently available books");
        mybook.DisplayInfo();
        yourbook.DisplayInfo();

        Members member = new Members(1, "John S", "1 High Street", 0779077909);
        Members member1 = new Members(2, "Johny S", "14 Low Street", 0745677909);
        Console.WriteLine("Current library Members");
        member.DisplayInfo();
        member1.DisplayInfo();
    }
}