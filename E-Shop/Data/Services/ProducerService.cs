using E_Shop.Data.Base;
using E_Shop.Models;
using Microsoft.EntityFrameworkCore;
using Npgsql.Replication;
using System;

namespace E_Shop.Data.Services
{
    public class ProducerService : EntityBaseRepository<Producer>, IProducerService
    {
        public ProducerService(ApplicationDbContext context) : base(context)
        {
        }
    }
}