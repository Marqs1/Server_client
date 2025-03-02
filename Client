using WebSocketSharp;

public class Program
{
    public static void Main(string[] args)
    {
        using var ws = new WebSocket("ws://localhost:9006/Test");
        ws.OnMessage += (sender, e) => Console.WriteLine("Received from server: " + e.Data);

        ws.Connect();
        Console.WriteLine("Connected to WebSocket server. Type a message and press Enter to send.");

        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "exit")
            {
                break;
            }
            ws.Send(input);
        }

        ws.Close();
    }
}
