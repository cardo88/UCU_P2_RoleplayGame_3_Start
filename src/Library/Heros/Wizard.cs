using System.Collections.Generic;
namespace RoleplayGame
{
    public class Wizard: MagicalCharacter
    {

        public Wizard(string name): base(name)
        {
            this.AddMagicalElement(new Staff());
        }
        

    }
}