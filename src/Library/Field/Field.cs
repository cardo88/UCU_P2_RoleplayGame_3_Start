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
        // public void RemoveCharacterToEncounter(Character character)
        // {
        //     if (players.Contains(character))
        //     {
        //         players.Remove(character);
        //     }
        // }
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
        
            if (heroes.Count == 1 && enemies.Count > 1) //si en el encuentro hay un solo hereo y mas de 1 enemigo
            {
                do
                {
                    foreach (Enemy player in enemies)
                    {
                        totalEnemyPower += player.AttackValue; //para determinar el ataque total de los enemigos
                    }
                    // var query = from Hero hero in heroes  select hero;
                    // Hero aloneHero = query.FirstOrDefault();
                    // aloneHero.ReceiveAttack(totalEnemyPower);
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
                if (heroes[0].VictoryPoints >= 5)
                {
                    heroes[0].Cure();

                }
            }
            if (heroes.Count == enemies.Count)
            {
                counter = heroes.Count;
                do
                {
                    for (int i = 0; i < counter; i++)
                    {
                       heroes[i].ReceiveAttack(enemies[i].AttackValue);
                       if (heroes[i].Health <= 0)
                       {
                           heroes[i].Remove ; 
                       } 
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
                if (heroes[0].VictoryPoints >= 5)
                {
                    heroes[0].Cure();

                }
            }

        
                
                
            
        }
    }
}
