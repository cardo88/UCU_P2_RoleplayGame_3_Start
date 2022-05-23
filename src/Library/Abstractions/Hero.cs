namespace RoleplayGame
{
    public abstract class Hero : Character
    {
        protected int totalVP{ get; set; }
        
        protected Hero(string name) : base (name)
        {
            this.totalVP = 0;
        }

        public int VictoryPoints
        {
            get
            {
                return this.totalVP;
            }
            set
            {
                this.totalVP = value;
            }
        }
        public virtual int totalVictoryPoints(int vp)
        {
            return totalVP += vp;
        }
    }

}