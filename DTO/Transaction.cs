using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    [DataContract]
    public class Transaction
    {
        [DataMember]
        public int AccountId { get; set; }

        [DataMember]
        public DateTime TranDateHour { get; set; }

        [DataMember]
        public double TranAmount { get; set; }

        [DataMember]
        public string Services { get; set; }
    }
}
