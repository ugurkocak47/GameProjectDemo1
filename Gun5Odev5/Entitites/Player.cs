using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun5Odev5.Entitites
{
    public class Player
    {
        public int Id { get; set; }
        public string NationalityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nickname { get; set; }
        public int AccountBalance { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime AccountCreationDate { get; set; } //Oyun alındığında hesap oluşturuldugunu varsayalım.

    }
}
