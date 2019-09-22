using System.Data.Entity;
using MySql.Data.Entity;

namespace GuiForMinecraftMods.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    class MinecraftModesContext : DbContext
    {
        public MinecraftModesContext() : base("ParserDb") { }

        public DbSet<MinecraftModes> MinecraftModes { get; set; }
    }
}
