using System.Collections.Generic;
namespace RoleplayGame
{
    public class Archer: Hero
    {

        
        public Archer(string name) : base(name)
        {
            this.AddElement(new Bow());
            this.AddElement(new Helmet());
        }

      
    }
}