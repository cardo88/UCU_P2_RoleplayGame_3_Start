using System.Collections.Generic;
namespace RoleplayGame
{
    public class Dwarf: Hero, IElementList<Item>
    {


        public Dwarf(string name) : base(name)
        {  
            this.AddElement(new Axe());
            this.AddElement(new Helmet());
        }       
        

       
    }
}