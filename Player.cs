using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_Static_Example_WPF
{
    internal class Player
    {
        string _name;
        int _hp;
        static int _count;

        public Player(string name, int hp)
        {
            _name = name;
            _hp = hp;
            _count++;
        }

        public string Name { get => _name; set => _name = value; }
        public int Hp { get => _hp; set => _hp = value; }
        public static int Count { get => _count; }

        public override string ToString()
        {
            return $"{_name} - Hp: {Hp}";
        }
    }
}
