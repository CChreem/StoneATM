﻿using StoneATM.User.Classes;

namespace StoneATM.Users.Classes
{
    public class Client
    {
        public string Name { get; set; } = string.Empty;
        public string CPF { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Account { get; set; }     
    }
}