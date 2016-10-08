using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeHeroMonsterClassesEpicU
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var hero = new Character();

            hero.Name = "Hero";
            hero.Health = 100;
            hero.DamageMaximum = 50;
            hero.AttackBonus = false;

            var monster = new Character();

            monster.Name = "Monster";
            monster.Health = 100;
            monster.DamageMaximum = 50;
            monster.AttackBonus = false;

            completeBattle(hero, monster);
        }

        public void bonus(Character hero, Character monster, Dice dice)
        {
            if (hero.AttackBonus == true) monster.Defend(hero.Attack(dice));
            if (monster.AttackBonus == true) hero.Defend(monster.Attack(dice));
        }

        public void completeBattle(Character hero, Character monster)
        {
            while (hero.Health>0 && monster.Health>0)
            {
                battleRound(hero, monster);
            }
        }

        public void battleRound(Character hero, Character monster)
        {
            var dice = new Dice();

            var damageInflicted = hero.Attack(dice);
            monster.Defend(damageInflicted);

            damageInflicted = monster.Attack(dice);
            hero.Defend(damageInflicted);

            displayStats(hero);
            displayStats(monster);

            displayResults(hero, monster);
        }
        
        public void displayStats(Character character)
        {
            resultLabel.Text += String.Format("<p>Character Stats:</br>Name: {0}</br>Health: {1}</br>Maximum Damage: {2}</br>Attack Bonus: {3}</p>",
                character.Name,
                character.Health.ToString(),
                character.DamageMaximum.ToString(),
                character.AttackBonus.ToString());
        }

        public void displayResults(Character opponet1, Character opponet2)
        {
            if (opponet1.Health <= 0 && opponet2.Health > 0)
            {
                resultLabel.Text += String.Format("<p>The battle is over. {0} defeated {1}.</p>", opponet2, opponet1);
            }

            if(opponet2.Health <=0 && opponet1.Health > 0)
            {
                resultLabel.Text += String.Format("<p>The battle is over. {0} defeated {1}.</p>", opponet1, opponet2);
            }
            else
            {
                resultLabel.Text += String.Format("<p>The battle has ended with no winner. Both opponents have died.</p>");
            }
        }

        public class Dice
        {
            public int Sides { get; set; }

            Random randomRoll = new Random();

            public int Roll()
            {
                return randomRoll.Next(Sides);
            }
        }

        public class Character
        {
            public string Name { get; set; }
            public int Health { get; set; }
            public int DamageMaximum { get; set; }
            public bool AttackBonus { get; set; }

            public int Attack(Dice dice)
            {
                //randomly determines the amount of damage this Character object inflicted.

                dice.Sides = DamageMaximum;

                return dice.Roll();
            }

            public void Defend(int damageInflicted)
            {
                //deducts the damage from Character's health

                Health -= damageInflicted;
            }
        }
    }
}
