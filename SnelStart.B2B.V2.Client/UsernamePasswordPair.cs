﻿namespace SnelStart.B2B.V2.Client
{
    internal class UsernamePasswordPair
    {
        public UsernamePasswordPair(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public string Username { get; }
        public string Password { get;}
    }
}
