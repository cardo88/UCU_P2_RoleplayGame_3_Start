using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    [TestFixture]
    public class DwarfTest
    {
        Archer tauriel = new Archer("Tauriel"); // 15a 18d

        [Test]
        public void AddAttackElementTest()
        {
            Dwarf gruñon = new Dwarf("Gruñon"); //25a 18d
            gruñon.AddElement(new Bow()); //++15a

            Assert.AreEqual(40, gruñon.AttackValue);
        }

        [Test]
        public void AddDefensiveElementTest()
        {
            Dwarf gruñon = new Dwarf("Gruñon"); //25a 18d
            Helmet helmet = new Helmet(); //18d
            Shield shield = new Shield(); //14d
            gruñon.AddElement(shield);
            gruñon.AddElement(helmet);

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
        public void RemoveDefensiveElementTest()
        {
            Dwarf gruñon = new Dwarf("Gruñon"); //25a 18d
            Shield shield = new Shield(); //14d
            gruñon.AddElement(shield);
            
            gruñon.RemoveElement(shield);

            Assert.AreEqual(18, gruñon.DefenseValue);
        }
        
        [Test]
        public void RemoveAttackElementTest()
        {
            Dwarf gruñon = new Dwarf("Gruñon"); //25a 18d
            Sword sword=new Sword();
            gruñon.AddElement(sword);
            
            gruñon.RemoveElement(sword);

            Assert.AreEqual(18, gruñon.DefenseValue);
        }

        [Test]
        public void ReceiveAttack()
        {
            Dwarf gruñon = new Dwarf("Gruñon"); //25a 18d

            Archer tauriel = new Archer("Tauriel"); // 15a 18d
            tauriel.AddElement(new Bow()); // 30a tauriel

            gruñon.ReceiveAttack(tauriel.AttackValue);
            Assert.AreEqual(88, gruñon.Health);
        }
    }
}