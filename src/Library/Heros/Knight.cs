using System.Collections.Generic;
namespace RoleplayGame
{
    public class Knight: Hero
    {
        public Knight(string name) : base(name)
        {
            
            this.AddElement(new Sword());
            this.AddElement(new Armor());
            this.AddElement(new Shield());

        }
    }

}