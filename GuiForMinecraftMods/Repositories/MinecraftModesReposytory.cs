using System;
using System.Linq;


using GuiForMinecraftMods.Models;

namespace GuiForMinecraftMods.Repositories
{
    class MinecraftModesReposytory : IMinecraftModesReposytory
    {
        private readonly MinecraftModesContext _minecraftModesContext;

        public MinecraftModesReposytory(MinecraftModesContext context)
        {
            _minecraftModesContext = context;
        }

        /// <summary>
        /// Gets all minecraft modes from database
        /// </summary>
        /// <returns></returns>
        public IQueryable<MinecraftModes> Get()
        {
            return _minecraftModesContext.Set<MinecraftModes>();
        }

        /// <summary>
        /// Gets minecraft mode by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public MinecraftModes Get(int id)
        {
            try
            {
                return Get().FirstOrDefault(x => x.Id == id);
            }catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Gets minecraft mode by name
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public MinecraftModes Get(string title)
        {
            try
            {
                return Get().FirstOrDefault(x => x.Title == title);
            }catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
