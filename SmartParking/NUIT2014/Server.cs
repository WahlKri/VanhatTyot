using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Concurrent;
using System.Threading;
using System.Net;
using Alchemy;
using Alchemy.Classes;

class SmartParkingWebSocketServer
{

	static ConcurrentDictionary<uint,Connection> connections = new ConcurrentDictionary<uint, Connection>();
	static Downloader filepersister = new Downloader();

	public SmartParkingWebSocketServer(int port)
	{
		this.port = port;

		// create new WebSocketServer
		this.wsserver = new WebSocketServer(this.port, System.Net.IPAddress.Any)
		{
			OnReceive = OnRecieve,
			OnSend = OnSend,
			OnConnected = OnConnect,
			OnDisconnect = OnDisconnect,
			TimeOut = new TimeSpan(0, 5, 0)
		};
		// let's start it
		this.wsserver.Start();
		this.isRunning = true;

		// Output for debugging
		Console.WriteLine("WebSocketServer is running ...");
	}

	private bool isRunning;
	private int port;
	private WebSocketServer wsserver;

	// Get's String argument which will be Send to the Client
	public void SendMessage(string message, uint clientID)
	{
		if (message == "") {
			throw new ArgumentException("Error get Empty String as Argument");
		} else {
			Connection currentConn;
			if (connections.TryGetValue(clientID, out currentConn)) {
				currentConn.SendMessage(message);
			} else {
				Console.WriteLine ("Error Connection Object of ID: {0} was not found!", clientID);
			}
		}
	}

	// Used to stopping the WebSocketServer
	public void DisconnectServer()
	{
		if (this.isRunning) {
			this.wsserver.Stop ();
			this.isRunning = false;
		}
	}
	
    public static void OnRecieve(UserContext context)
    {
		Console.WriteLine ("Somebody send me something");
		try {
			Console.WriteLine ("Get data from client: " + context.ClientAddress.ToString () + context.DataFrame.ToString());
		} catch(Exception e) {
			Console.WriteLine ("Error onReceive: " + e.Message);
		}
		Console.WriteLine("Received data frame length: {0}", context.DataFrame.Length);
		var raw = context.DataFrame.AsRaw();
		filepersister.storeFile(filepersister.convertListToByteArray(raw));
    }

    public static void OnConnect(UserContext context)
    {
		uint Id = 0;
	    Console.WriteLine("WebSocketServer connected to client with address: " + context.ClientAddress.ToString());
		Id += 1;
		Console.WriteLine("Client Id: " + Id);
		var conn = new Connection { _context = context };
		conn._context.MaxFrameSize = 10000000; // necessary to receiving big files!
		connections.TryAdd(Id, conn);
		Console.WriteLine("Context max frame size: {0}", conn._context.MaxFrameSize);
		Console.WriteLine("still living ...");
    }

    public static void OnSend(UserContext context)
    {
		Console.WriteLine ("WebSocketServer will send: " + context.DataFrame.ToString() + "to; " + context.ClientAddress.ToString ());
    }

    public static void OnDisconnect(UserContext context)
    {
        Console.WriteLine("WebSocketServer disconnected from client with address: " + context.ClientAddress.ToString());
    }
}

class Connection
{
	public UserContext _context { get; set; }
	public Connection() {}

	public void SendMessage(string message)
	{
		try {
			_context.Send(message);
		} 
		catch(Exception e) {
			Console.WriteLine ("Cannont send message: " + e.Message);
		}
	}
}

class Downloader
{ 

	internal String wavfile;
	public Downloader()
	{
		this.wavfile = "./test.wav";
	}
	
	public byte[] convertListToByteArray(IList<ArraySegment<byte>> list)
	{
		var bytes = new byte[list.Sum(asb => asb.Count)];
		int pos = 0;

		foreach (var asb in list) {
			Buffer.BlockCopy (asb.Array, asb.Offset, bytes, pos, asb.Count);
			pos += asb.Count;
		}

		return bytes;
	}

	public void storeFile(byte[] data)
	{
		using(FileStream fs = new FileStream (this.wavfile, FileMode.Create))
		using(BinaryWriter bw = new BinaryWriter(fs))
		{
			try {
				bw.Write(data);
			}
			finally {
				if (bw != null) {
					bw.Close ();
				}
				if (fs != null) {
					fs.Close ();
				}
			}
		}
	}

}

//class Programm
//{
//    static void Main(String[] args)
//    {
//        var server = new SmartParkingWebSocketServer (50000);
//        //Thread.Sleep(50000); // have enough time to start a client
//        //Console.WriteLine("... try to send ... ");
//        //server.SendMessage("Hello", 1);
//        var com = String.Empty;
//        while (com != "exit") {
//            com = Console.ReadLine ();
//        }
//        server.DisconnectServer ();
//    }
//}