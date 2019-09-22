using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using GuiForMinecraftMods.Models; 


namespace GuiForMinecraftMods.Repositories
{
    interface IUserRepository
    {
        IQueryable<User> Get();
        User Get(int id);
        User Save(User entity);
        void Remove(User entity);
        void Add(User entity);
    }
}
