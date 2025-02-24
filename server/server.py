import socket

HOST = '127.0.0.1'  # Localhost
PORT = 65432  

server_socket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)  # IPv4, TCP
server_socket.bind((HOST, PORT))
server_socket.listen(1) 
print(f"Server listening on {HOST}:{PORT}")

conn, addr = server_socket.accept()
print(f"Connected by {addr}")

conn, addr = server_socket.accept()
print(f"Connected by {addr}")

while True:
    data = conn.recv(1024).decode()
    if not data:
        break  # Exit loop if no data received
    print(f"Received: {data}")

    response = "Message received"
    conn.send(response.encode())  # Send response back to client

conn.close()
server_socket.close()
