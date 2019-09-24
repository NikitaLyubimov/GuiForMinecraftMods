using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IronPython.Hosting;

namespace GuiForMinecraftMods.Models
{
    class RunPythonScript
    {
        public static void RunScript()
        {
            var engine = Python.CreateEngine();
            string scipt = @"<Script path>";
            var source = engine.CreateScriptSourceFromFile(scipt);

            List<string> argv = new List<string>();

            argv.Add("");
            argv.Add("<Database password>");

            engine.GetSysModule().SetVariable("argv", argv);

            var eIo = engine.Runtime.IO;

            MemoryStream errors = new MemoryStream();

            eIo.SetErrorOutput(errors, Encoding.Default);

            var scope = engine.CreateScope();
            source.Execute(scope);

            string str(byte[] x) => Encoding.Default.GetString(x);

            Console.WriteLine(str(errors.ToArray()));


        }
    }
}
