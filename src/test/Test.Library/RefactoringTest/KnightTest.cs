using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    [TestFixture]
    public class KnightTest
    {
        [Test]
        public void AddAttackElementTest()
        {
            Knight knight = new Knight("Dark Knight");  
            
            knight.AddElement(new Bow());
            Assert.AreEqual(15, knight.AttackValue);
        }

        [Test]
        public void AddDefensiveElementTest()
        {
            Knight knight = new Knight("Dark Knight"); 
            knight.AddElement(new Helmet()); 
            Assert.AreEqual(57, knight.DefenseValue);
        }

        [Test]
        public void AttacktTest()
        {
            Knight knight = new Knight("Dark Knight"); 
            Dwarf dwarf = new Dwarf("Richi"); 
            
            knight.AddElement(new Bow());
            knight.AddElement(new Bow());
            dwarf.ReceiveAttack(knight.AttackValue);

            Assert.AreEqual(88, dwarf.Health);
        }

        [Test]
        public void CureTest()
        {
            Knight knight = new Knight("Dark Knight");
            
            Dwarf dwarf = new Dwarf("Richi"); 
            dwarf.AddElement(new Sword());
            dwarf.AddElement(new Sword());
            
            knight.ReceiveAttack(dwarf.AttackValue);
            knight.Cure();

            Assert.AreEqual(100, knight.Health);
        }

        [Test]
        public void RemoveAttackItemsTest()
        {
            Knight knight = new Knight("Dark Knight");
            Sword sword = new Sword();
            knight.AddElement(sword);
            knight.RemoveElement(sword);
            Assert.AreEqual(39, knight.DefenseValue);
        }

        [Test]
        public void RemoveDefensiveItemsTest()
        {
            Knight knight = new Knight("Dark Knight");
            Helmet helmet = new Helmet();
            knight.AddElement(helmet);
            knight.RemoveElement(helmet);
            Assert.AreEqual(39, knight.DefenseValue);
        }

        [Test]
        public void ReceiveAttackTest()
        {
            Knight knight = new Knight("Dark Knight");

            Dwarf dwarf = new Dwarf("Richi"); 
            dwarf.AddElement(new Bow());
            dwarf.AddElement(new Bow());

            knight.ReceiveAttack(dwarf.AttackValue);
            Assert.AreEqual(84, knight.Health);
        }
    }
}