using E_Shop.Data.Base;
using E_Shop.Models;
using Microsoft.EntityFrameworkCore;
using Npgsql.Replication;

namespace E_Shop.Data.Services
{
    public class ActorService : EntityBaseRepository<Actor>, IActorService
    {
        public ActorService(ApplicationDbContext context) : base(context) { }
    }
}
