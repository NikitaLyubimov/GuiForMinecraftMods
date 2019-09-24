using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GuiForMinecraftMods.Repositories;
using GuiForMinecraftMods.Models;
using System.Windows.Input;

namespace GuiForMinecraftMods.ViewModels
{
    class MainWindowViewModel
    {
        public List<MinecraftModes> ModesList { get { return _modesList; } }

        private List<MinecraftModes> _modesList { get; set; }
        private MinecraftModesReposytory _miecraftModeReposytory;
        private ICommand _startScript;

        public MainWindowViewModel()
        {
            _miecraftModeReposytory = new MinecraftModesReposytory();
            _modesList = _miecraftModeReposytory.Get().ToList();
        }

        private void StartScript()
        {
            RunPythonScript.RunScript();
        }

        public RelayCommand StartScriptCommand
        {
            get
            {
                if (_startScript == null)
                    _startScript = new RelayCommand(StartScript);
                return (RelayCommand)_startScript;
            }
        }
    }
}
