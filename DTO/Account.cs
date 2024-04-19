using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    [DataContract]
    public class Account
    {
        // Attributs 
        [DataMember]
        public int UiD { get; set; }

        [DataMember]
        public int CardID { get; set; }

        [DataMember]
        public string Username { get; set; }

        [DataMember]
        public double AccountAmount { get; set; }

        [DataMember]
        public int QuotaFeuilles { get; set; }

        // Constructors
        public Account(string username, int cardID)
        {
            this.Username = username;
            this.CardID = cardID;
        }

        public Account()
        {
        }
    }
}
