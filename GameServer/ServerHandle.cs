using System;
using System.Collections.Generic;
using System.Text;

namespace GameServer
{
    public class ServerHandle
    {
        public static void WelcomeReceived(int _fromClient, Packet _packet)
        {
            int _clientIdCheck = _packet.ReadInt();
            string _userName = _packet.ReadString();

            Console.WriteLine($"{Server.clients[_fromClient].tcp.socket.Client.RemoteEndPoint} connected successfully and is now player {_fromClient} as {_userName}.");
            if (_fromClient != _clientIdCheck)
            {
                Console.WriteLine($"Player \"{_userName}\" (ID: {_fromClient}) has assumed the wrong cliend ID ({_clientIdCheck}).");
            }
            // TODO: send player into game
        }
    }
}
