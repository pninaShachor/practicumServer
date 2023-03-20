using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practikum.Repositories.Entities
{
    //public enum EMorF { Male, Female };
    public class Client
    { 
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string IdentityN { get; set; }
        public DateTime BornDate { get; set; }
        //public EMorF MorF { get; set; }
        public string MorF { get; set; }
        public string HMO { get; set; }
        public List<Child> Children { get; set; }
    }
}
