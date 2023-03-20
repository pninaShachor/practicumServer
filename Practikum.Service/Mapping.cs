using AutoMapper;
using Practikum.Commen.DTOs;
using Practikum.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practikum.Services
{
    public class Mapping:Profile
    {
        public Mapping()
        {
            CreateMap<Client, ClientDTO>().ReverseMap();
            CreateMap<Child, ChildDTO>().ReverseMap();
        }
    }
}
