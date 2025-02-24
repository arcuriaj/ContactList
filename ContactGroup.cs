using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactList {
    public class ContactGroup : List<Contact> {
        public string grpName {  get; set; }
        public ContactGroup(string grpName, List<Contact> contacts) : base(contacts) {
            this.grpName = grpName;
        }
    }
}
