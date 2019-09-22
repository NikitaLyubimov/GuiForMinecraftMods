namespace GuiForMinecraftMods.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class ConfigurationMinecraftModes : DbMigrationsConfiguration<GuiForMinecraftMods.Models.MinecraftModesContext>
    {
        public ConfigurationMinecraftModes()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(GuiForMinecraftMods.Models.MinecraftModesContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
