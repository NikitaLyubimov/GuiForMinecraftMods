using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GuiForMinecraftMods.Models;

namespace GuiForMinecraftMods.Repositories
{
    class UserReposytory : IUserRepository
    {
        private readonly UserContext _userContext;

        public UserReposytory(UserContext context)
        {
            _userContext = context;
            
        }

        /// <summary>
        /// Adds new user 
        /// </summary>
        /// <param name="entity"></param>
        public void Add(User entity)
        {
            _userContext.Set<User>().Add(entity);
            _userContext.SaveChanges();
        }


        /// <summary>
        /// Gets all users in database
        /// </summary>
        /// <returns></returns>
        public IQueryable<User> Get()
        {
            return _userContext.Set<User>();
        }

        /// <summary>
        /// Gets user by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public User Get(int id)
        {
            return Get().FirstOrDefault(x => x.Id == id);
        }

        /// <summary>
        /// Removes user by given entity
        /// </summary>
        /// <param name="entity"></param>
        public void Remove(User entity)
        {
            _userContext.Set<User>().Remove(entity);
            _userContext.SaveChanges();
        }

        public User Save(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
