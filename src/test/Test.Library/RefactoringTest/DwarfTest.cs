using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{


    public class DwarfTest
    {

        

        Archer tauriel = new Archer("Tauriel"); // 15a 18d

        [Test]
        public void AddAttackItemTest()
        {
            Sword sword = new Sword(); //20a
            Shield shield = new Shield(); //14d

            Dwarf gruñon = new Dwarf("Gruñon"); //25a 18d
            gruñon.AddItem(sword);

            Assert.AreEqual(45, gruñon.AttackValue);
        }

        [Test]
        public void AddDefensiveItemTest()
        {
            Dwarf gruñon = new Dwarf("Gruñon"); //25a 18d
            Helmet helmet = new Helmet(); //18d
            Shield shield = new Shield(); //14d
            gruñon.AddItem(shield);
            gruñon.AddItem(helmet);

            Assert.AreEqual(50, gruñon.DefenseValue);
        }

        [Test]
        public void AttackTest()
        {
            Dwarf gruñon = new Dwarf("Gruñon"); //25a 18d
            Archer tauriel = new Archer("Tauriel"); // 15a 18d

            tauriel.ReceiveAttack(gruñon.AttackValue);

            Assert.AreEqual(93, tauriel.Health);
        }

        [Test]
        public void CureTest()
        {
            Dwarf gruñon = new Dwarf("Gruñon"); //25a 18d
            gruñon.Cure();
            Assert.AreEqual(100, gruñon.Health);
        }

        [Test]
        public void RemoveDefensiveItemsTest()
        {
            Dwarf gruñon = new Dwarf("Gruñon"); //25a 18d
            Shield shield = new Shield(); //14d
            gruñon.AddItem(shield);
            
            gruñon.RemoveItem(shield);

            Assert.AreEqual(18, gruñon.DefenseValue);
        }
        
        [Test]
        public void RemoveAttackItemsTest()
        {
            Dwarf gruñon = new Dwarf("Gruñon"); //25a 18d
            Sword sword=new Sword();
            gruñon.AddItem(sword);
            
            gruñon.RemoveItem(sword);

            Assert.AreEqual(18, gruñon.DefenseValue);
        }

        [Test]
        public void ReceiveAttack()
        {
            Dwarf gruñon = new Dwarf("Gruñon"); //25a 18d

            Archer tauriel = new Archer("Tauriel"); // 15a 18d
            tauriel.AddItem(new Sword()); // 35a tauriel

            gruñon.ReceiveAttack(tauriel.AttackValue);
            Assert.AreEqual(83, gruñon.Health);
        }
    }
}