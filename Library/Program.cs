using Library;

class Program
{
    static void Main(string[] args)
    {
        Book mybook = new Book("C# for beginners", "BillGates", "1234");
        Book yourbook = new Book("C#Methods", "Microsoft", "3456778");
        mybook.DisplayInfo();
        yourbook.DisplayInfo();


    }
}