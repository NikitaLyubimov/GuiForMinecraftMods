using System;
using System.Collections.Generic;
using System.Linq;


using GuiForMinecraftMods.Models;

namespace GuiForMinecraftMods.Repositories
{
    class MinecraftModesReposytory : IMinecraftModesReposytory
    {
        private readonly MinecraftModesContext _minecraftModesContext;

        public MinecraftModesReposytory()
        {
            _minecraftModesContext = new MinecraftModesContext();
        }

        /// <summary>
        /// Gets all minecraft modes from database
        /// </summary>
        /// <returns></returns>
        public IList<MinecraftModes> Get()
        {
            return _minecraftModesContext.Set<MinecraftModes>().ToList();
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
