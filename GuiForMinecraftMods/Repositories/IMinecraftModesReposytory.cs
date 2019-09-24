using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GuiForMinecraftMods.Models;

namespace GuiForMinecraftMods.Repositories
{
    interface IMinecraftModesReposytory
    {
        IList<MinecraftModes> Get();
        MinecraftModes Get(int id);
        MinecraftModes Get(string title);
    }
}
