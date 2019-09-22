using System.Data.Entity;
using MySql.Data.Entity;

namespace GuiForMinecraftMods.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    class UserContext : DbContext
    {
        public UserContext() : base("ParserDb") { }

        public DbSet<User> Users { get; set; }
    }
}
