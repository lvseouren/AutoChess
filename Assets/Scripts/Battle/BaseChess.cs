using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Assets.Scripts.Battle
{
    enum Race
    {
        God,
        Human,
        Demon,
    }

    enum Career
    {
        Warrior,
        Mage,
        Hunter,
    }

    public class BaseChess
    {
        private int cost;
        private int rarity;
        private Race race;
        private Career career;

        private int hp;
        private int atk;
        private int armor;
        private int magic_armor;
        private int atk_speed;
    }
}
