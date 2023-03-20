
using Practikum.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practikum.Commen.DTOs
{
    //public enum EMorF { Male, Female };
    public class ClientDTO
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string IdentityN { get; set; }
        public DateTime BornDate { get; set; }
        public string MorF { get; set; }
        public string HMO { get; set; }
        public List<Child> Children { get; set; }
    }
}
