using System.Collections.Generic;
namespace RoleplayGame
{
    public class Zombi : Enemy
    {
        

        public Zombi(string name) : base(name)
        {
            this.VP = 2;
        }

    }
}