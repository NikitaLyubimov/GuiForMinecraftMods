using System;

namespace GuiForMinecraftMods.Models
{
    class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime RegDate { get; set; }
    }
}
