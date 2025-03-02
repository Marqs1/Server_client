using WebSocketSharp;
using WebSocketSharp.Server;

public class TestService : WebSocketBehavior
{
    protected override void OnMessage(MessageEventArgs e)
    {
        Console.WriteLine("Received from client: " + e.Data);

        Send(e.Data);
    }

    protected override void OnError(WebSocketSharp.ErrorEventArgs e)
    {
        // do nothing
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        var ws = new WebSocketServer("ws://localhost:9006");

        ws.AddWebSocketService<TestService>("/Test");
        ws.Start();
        Console.WriteLine("WebSocket server started at ws://localhost:9006/Test");
        Console.WriteLine("Press any key to stop the server...");
        Console.ReadKey(true);
        ws.Stop();
    }
}
