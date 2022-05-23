using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    [TestFixture]
    public class ArcherTest
    {
        [Test]
        public void AddAttackElementTest()
        {
            Archer tauriel = new Archer("Tauriel"); // por predeterminado tiene 15a y 18d
            Bow bow = new Bow();  // 15 ataque
          
            tauriel.AddElement(bow);
            

            Assert.AreEqual(30, tauriel.AttackValue);
        }
        
        [Test]
        public void AddDefensiveElementTest()
        {
            Archer tauriel = new Archer("Tauriel");
            Helmet helmet = new Helmet();
            
            tauriel.AddElement(helmet);
            
            Assert.AreEqual(36, tauriel.DefenseValue);
        }

        [Test]
        public void AttackTest()
        {
            Archer tauriel = new Archer("Tauriel"); // 15a 18d
            Bow bow = new Bow(); // 15a
            
            
            
            tauriel.AddElement(bow);
            
            //30 ataque tiene tauriel            

            Dwarf Gruñon = new Dwarf("Gruñon"); //25a 18d
            
           
            
            //100 de vida 18d
            Gruñon.ReceiveAttack(tauriel.AttackValue);

            Assert.AreEqual(88, Gruñon.Health);
        }

        [Test]
        public void CureTest()
        {
            Archer tauriel = new Archer("Tauriel");
            Helmet helmet = new Helmet();
        
            tauriel.AddElement(helmet);

            Dwarf gruñon = new Dwarf("Gruñon");

            tauriel.ReceiveAttack(gruñon.AttackValue);
            tauriel.Cure();

            Assert.AreEqual(100, tauriel.Health);
        }
        
        [Test]
        public void RemoveDefensiveElementTest()
        {
            Archer tauriel = new Archer("Tauriel"); // 15a 18d
            Armor armor = new Armor(); //25d
            tauriel.AddElement(armor);
            
            tauriel.RemoveElement(armor);
            Assert.AreEqual(18, tauriel.DefenseValue);
        }
        
        [Test]
        public void RemoveAttackElementTest()
        {
            Archer tauriel = new Archer("Tauriel"); // 15a 18d
            Sword sword = new Sword();
            tauriel.AddElement(sword);
            
            tauriel.RemoveElement(sword);
            Assert.AreEqual(18, tauriel.DefenseValue);
        }

        [Test]
        public void ReceiveAttack()
        {
            Archer tauriel = new Archer("Tauriel"); // 15a 18d
            
            Dwarf gruñon = new Dwarf("Gruñon"); //25a 18d
            

            //100 vida 18d tauriel, grunon 100vida 18d
            tauriel.ReceiveAttack(gruñon.AttackValue);
            Assert.AreEqual(93, tauriel.Health);
        }
    }
}