using System;
using System.Net.Sockets;
using System.Text;
using UnityEngine;

public class TCPClient : MonoBehaviour
{
    private TcpClient client;
    private NetworkStream stream;
    private byte[] buffer = new byte[1024];

    void Start()
    {
        ConnectToServer();
    }

    void ConnectToServer()
    {
        try
        {
            client = new TcpClient("127.0.0.1", 65432); // server settings
            stream = client.GetStream();
            Debug.Log("Connected to server");
            
            SendMessageToServer("Hello from Unity!");
            ReadResponse();
        }
        catch (Exception e)
        {
            Debug.LogError("Connection error: " + e.Message);
        }
    }

    void SendMessageToServer(string message)
    {
        byte[] data = Encoding.UTF8.GetBytes(message);
        stream.Write(data, 0, data.Length);
        Debug.Log("Sent: " + message);
    }

    void ReadResponse()
    {
        int bytesRead = stream.Read(buffer, 0, buffer.Length);
        string response = Encoding.UTF8.GetString(buffer, 0, bytesRead);
        Debug.Log("Server Response: " + response);
    }

    void OnApplicationQuit()
    {
        stream.Close();
        client.Close();
    }
}
