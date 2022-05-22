using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    [TestFixture]
    public class KnightTest
    {
        [Test]
        public void AddAttackItemTest()
        {
            Knight knight = new Knight("Dark Knight"); // 20a 39d
            Sword sword = new Sword(); 
            knight.AddItem(sword);//+20a
            Assert.AreEqual(40, knight.AttackValue);
        }

        [Test]
        public void AddDefensiveItemTest()
        {
            Knight knight = new Knight("Dark Knight");// 20a 39d
            knight.AddItem(new Helmet()); //+18d
            Assert.AreEqual(57, knight.DefenseValue);
        }

        [Test]
        public void AttacktTest()
        {
            Knight knight = new Knight("Dark Knight"); // 20a 39d
            Dwarf dwarf = new Dwarf("Richi"); //25a 18d

            knight.AddItem(new Sword());//+20a
            dwarf.ReceiveAttack(knight.AttackValue);

            Assert.AreEqual(78, dwarf.Health);
        }

        [Test]
        public void CureTest()
        {
            Knight knight = new Knight("Dark Knight");// 20a 39d
            
            Dwarf dwarf = new Dwarf("Richi"); //25a 18d
            dwarf.AddItem(new Sword());//+20a
            dwarf.AddItem(new Sword());//+20a
            
            knight.ReceiveAttack(dwarf.AttackValue);
            knight.Cure();

            Assert.AreEqual(100, knight.Health);
        }

        [Test]
        public void RemoveAttackItemsTest()
        {
            Knight knight = new Knight("Dark Knight");// 20a 39d
            Sword sword = new Sword();
            knight.AddItem(sword);
            knight.RemoveItem(sword);
            Assert.AreEqual(39, knight.DefenseValue);
        }

        [Test]
        public void RemoveDefensiveItemsTest()
        {
            Knight knight = new Knight("Dark Knight");// 20a 39d
            Helmet helmet = new Helmet();
            knight.AddItem(helmet);
            knight.RemoveItem(helmet);
            Assert.AreEqual(39, knight.DefenseValue);
        }

        [Test]
        public void ReceiveAttackTest()
        {
            Knight knight = new Knight("Dark Knight");// 20a 39d

            Dwarf dwarf = new Dwarf("Richi"); //25a 18d
            dwarf.AddItem(new Sword());//+20a
            dwarf.AddItem(new Sword());//+20a

            knight.ReceiveAttack(dwarf.AttackValue);
            Assert.AreEqual(74, knight.Health);
        }
    }
}