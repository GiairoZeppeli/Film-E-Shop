using E_Shop.Data.Base;
using E_Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Shop.Data.Services
{
    public class CinemaService: EntityBaseRepository<Cinema>, ICinemaService
    {
        public CinemaService(ApplicationDbContext context) : base(context)
        {
        }
    }
}
