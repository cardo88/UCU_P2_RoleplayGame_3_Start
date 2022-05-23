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

            /*if (heroes.Count == 1 && enemies.Count > 1) //si en el encuentro hay un solo hereo y mas de 1 enemigo
            {
                do
                {
                    totalEnemyPower = 0;
                    foreach (Enemy player in enemies)
                    {
                        totalEnemyPower += player.AttackValue; //para determinar el ataque total de los enemigos
                    }
                    heroes[0].ReceiveAttack(totalEnemyPower);
                    if (heroes[0].Health > 0)
                    {
                        foreach (Enemy player in enemies)
                        {
                            player.ReceiveAttack(heroes[0].AttackValue);
                            if (player.Health <= 0)
                            {
                                heroes[0].totalVictoryPoints(player.VictoryPoints);
                                enemies.Remove(player);
                            }
                        }
                    }

                } while (heroes[0].Health > 0 && enemies.Count > 0);

                if (heroes[0].Health > 0 && heroes[0].VictoryPoints >= 5)
                {
                    heroes[0].Cure();
                    heroes[0].VictoryPoints -= 5;

                }
            }
            if (heroes.Count == enemies.Count)
            {*/
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

                        if (counter == heroes.Count - 1)
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
                            foreach (Enemy enemy in enemies)
                            {
                                enemy.ReceiveAttack(hero.AttackValue);
                                if (enemy.Health <= 0)
                                {
                                    hero.totalVictoryPoints(enemy.VictoryPoints);
                                    enemies.Remove(enemy);
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
