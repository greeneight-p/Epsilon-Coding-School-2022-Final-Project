using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_App.Shared {
    public class CustomerViewModel {

        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string? CardNumber { get; set; }
        public bool Status { get; set; }
        public bool NewCardNumber { get; set; } = false;
    }

}
