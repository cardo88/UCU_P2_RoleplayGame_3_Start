namespace RoleplayGame
{
    public abstract class MagicalCharacter : Hero
    {
        protected MagicalCharacter(string name) : base (name)
        {
            this.totalVP = 0;
        }    
    }
}
