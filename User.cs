using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NBitcoin;

namespace TwoAuntification
{

    public class User
    {
        public string? FullName { get; set; }
        public PubKey? PublicKey { get; set; }
        public Key? PrivateKey { get; set; }
    }
}
