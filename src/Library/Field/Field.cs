using System;
using System.Collections.Generic;
using System.Linq;

namespace RoleplayGame
{
    public class Field
    {
        private List<Character> players = new List<Character>();
        private List<Hero> heroes = new List<Hero>();
        private List<Enemy> enemies = new List<Enemy>();
        private int totalEnemyPower = 0;
        private int totalHeroPower = 0;
        private int counter;
        public void AddCharacterToEncounter(Character character)
        {
            if (!players.Contains(character))
            {
                players.Add(character);
            }
        }
        public void DoEncounter()
        {
            foreach (Character player in players)
            {
                if (player is Hero)
                {
                    heroes.Add((Hero)player); //agrega los heroes al encuentro
                }
                else
                {
                    enemies.Add((Enemy)player); //agrega los enemigos al encuentro
                }
            }

            counter = 0;
            do
            {
                foreach (Enemy player in enemies)
                {
                    if (heroes.Count >= 1)
                    {
                        heroes[counter].ReceiveAttack(player.AttackValue);

                        if (heroes[counter].Health <= 0)
                        {
                            heroes.Remove(heroes[counter]);
                        }
                        else { counter++; }

                        if (counter >= heroes.Count - 1)
                        {
                            counter = 0;
                        }
                    }
                }

                if (heroes.Count >= 1)
                {

                    foreach (Hero hero in heroes)
                    {
                        if (enemies.Count >= 1)
                        {
                            for (int i = 0; i < enemies.Count; i++)
                            {
                               enemies[i].ReceiveAttack(hero.AttackValue);
                                if (enemies[i].Health <= 0)
                                {
                                    hero.totalVictoryPoints(enemies[i].VictoryPoints);
                                    enemies.Remove(enemies[i]);
                                }
                            }
                        }
                    }
                }

            } while (heroes.Count > 0 && enemies.Count > 0);

            if (heroes.Count >= 1)
            {
                foreach (Hero hero in heroes)
                {
                    if (hero.VictoryPoints >= 5)
                    {
                        hero.Cure();
                        hero.VictoryPoints -= 5;
                    }
                }
            }
        }
    }
}

