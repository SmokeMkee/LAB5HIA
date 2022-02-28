using System.Collections;
using LAB5HIA;

class main
{
    public static void Main(string[] args)
    {
        ass();
        Controller controller = new Controller();
        controller.start();
    }

   public static void ass()
    {
        var cities = new Dictionary<string, string>(){
            {"UK", "London, Manchester, Birmingham"},
            {"USA", "Chicago, New York, Washington"},
            {"India", "Mumbai, New Delhi, Pune"}
        };
		
        foreach(var kvp in cities)
            Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
    }
}