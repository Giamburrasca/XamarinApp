﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Progetto3
{
    class Utente
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public Utente(int id, string username, string password, string email)
        {
            Id = id;
            Username = username;
            Password = password;
            Email = email;

        }
    }
}
