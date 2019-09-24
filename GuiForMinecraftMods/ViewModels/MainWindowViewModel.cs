using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GuiForMinecraftMods.Repositories;
using GuiForMinecraftMods.Models;

namespace GuiForMinecraftMods.ViewModels
{
    class MainWindowViewModel
    {
        public List<MinecraftModes> ModesList { get { return _modesList; } }

        private List<MinecraftModes> _modesList { get; set; }
        private MinecraftModesReposytory _miecraftModeReposytory;

        public MainWindowViewModel()
        {
            _miecraftModeReposytory = new MinecraftModesReposytory();
            _modesList = _miecraftModeReposytory.Get().ToList();
        }
    }
}
