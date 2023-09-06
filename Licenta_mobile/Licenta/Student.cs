using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Licenta_test
{
    public class Student
    {
        
        public string Username { get; set; }
        public string Password { get; set; }

        public string Nume { get; set; }

        public string Prenume { get; set; }
        public string Adresa { get; set; }
        public string CNP { get; set; }
        public string SerieCI { get; set; }
        public string NrCI { get; set; }
        public string NumeMama { get; set; }
        public string NumeTata { get; set; }
        public string Facultatea { get; set; }
        public string AnStudiu { get; set; }
        public string Specializarea { get; set; }
        public string TelefonParinte { get; set; }
        public string TelefonStudent { get; set; }
        public string Gen { get; set; }
        public string NrMatricol { get; set; }
        public string Judet { get; set; }

        public string NrCamera { get; set; }
    }
}




