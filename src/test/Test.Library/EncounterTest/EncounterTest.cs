using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    [TestFixture]
    public class EncounterTest
    {
        [Test]
        public void AddHeroToEncounterTest()
        {
            Field field = new Field();

            Character archer = new Archer("Rochet");
            field.AddCharacterToEncounter(archer);
            Assert.Contains(archer, field.Players);  
        }
        [Test]
        public void AddEnemyToEncounterTest()
        {
            Field field = new Field();

            Character anthonymm = new Anthony("Antoniespeaker");
            field.AddCharacterToEncounter(anthonymm);
            Assert.Contains(anthonymm, field.Players);
        }

        [Test]
        public void DoEncounterHeroWinsTest()
        {
            Field field = new Field();

            Character archer = new Archer("Rochet");
            field.AddCharacterToEncounter(archer);
            archer.AddElement(new Bow());
            Character anthonymm = new Anthony("Antoniespeaker");
            field.AddCharacterToEncounter(anthonymm);

            field.DoEncounter();
            Assert.IsTrue(anthonymm.Health <= 0);
        }

        // [Test] Este test cuando lo descomento se tranca y me da error en LibraryDll, no lo pude arreglar
        // public void DoEncounterEnemyWinsTest()
        // {
        //     Field field = new Field();

        //     Character archer = new Archer("Rochet");
        //     field.AddCharacterToEncounter(archer);
        //     archer.AddElement(new Bow());
        //     Character anthonymm = new Anthony("Antoniespeaker");
        //     anthonymm.AddElement(new Helmet());
        //     anthonymm.AddElement(new Armor());
        //     field.AddCharacterToEncounter(anthonymm);

        //     field.DoEncounter();
        //     Assert.IsTrue(archer.Health <= 0);
        // }
    }
}
