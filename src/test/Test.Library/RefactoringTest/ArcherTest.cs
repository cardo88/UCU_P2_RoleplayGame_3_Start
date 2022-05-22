using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class ArcherTest
    {
        [Test]
        public void AddAttackItemTest()
        {
            Archer tauriel = new Archer("Tauriel"); // por predeterminado tiene 15a y 18d
            Bow bow = new Bow();  // 15 ataque
            Sword sword = new Sword(); // 20 ataque

            tauriel.AddItem(bow);
            tauriel.AddItem(sword);

            Assert.AreEqual(50, tauriel.AttackValue);
        }
        
        [Test]
        public void AddDefensiveItemTest()
        {
            Archer tauriel = new Archer("Tauriel");
            Helmet helmet = new Helmet();
            
            tauriel.AddItem(helmet);
            
            Assert.AreEqual(36, tauriel.DefenseValue);
        }

        [Test]
        public void AttackTest()
        {
            Archer tauriel = new Archer("Tauriel"); // 15a 18d
            Bow bow = new Bow(); // 15a
            Sword sword = new Sword(); //20a
            
            
            tauriel.AddItem(bow);
            tauriel.AddItem(sword);
            //50 ataque tiene tauriel            

            Dwarf Gruñon = new Dwarf("Gruñon"); //25a 18d
            Shield shield = new Shield(); //14d
           
            Gruñon.AddItem(shield);
            //100 de vida y 32 de defensa tiene el gruñon
            Gruñon.ReceiveAttack(tauriel.AttackValue);

            Assert.AreEqual(82, Gruñon.Health);
        }

        [Test]
        public void CureTest()
        {
            Archer tauriel = new Archer("Tauriel");
            Helmet helmet = new Helmet();
        
            tauriel.AddItem(helmet);

            Dwarf gruñon = new Dwarf("Gruñon");

            tauriel.ReceiveAttack(gruñon.AttackValue);
            tauriel.Cure();

            Assert.AreEqual(100, tauriel.Health);
        }
        
        [Test]
        public void RemoveDefensiveItemsTest()
        {
            Archer tauriel = new Archer("Tauriel"); // 15a 18d
            Armor armor = new Armor(); //25d
            tauriel.AddItem(armor);
            
            tauriel.RemoveItem(armor);
            Assert.AreEqual(18, tauriel.DefenseValue);
        }
        
        [Test]
        public void RemoveAttackItemsTest()
        {
            Archer tauriel = new Archer("Tauriel"); // 15a 18d
            Sword sword = new Sword();
            tauriel.AddItem(sword);
            
            tauriel.RemoveItem(sword);
            Assert.AreEqual(18, tauriel.DefenseValue);
        }

        [Test]
        public void ReceiveAttack()
        {
            Archer tauriel = new Archer("Tauriel"); // 15a 18d
            
            Dwarf gruñon = new Dwarf("Gruñon"); //25a 18d
            gruñon.AddItem(new Sword()); // 45a grunon

            tauriel.ReceiveAttack(gruñon.AttackValue);
            Assert.AreEqual(73, tauriel.Health);
        }
    }
}