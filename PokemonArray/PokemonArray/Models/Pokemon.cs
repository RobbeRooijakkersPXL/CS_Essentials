using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonArray.Models
{
    public class Pokemon
    {
        public Pokemon(string name, int level, string type)
        {
            Name = name;
            Level = level;
            Type = type;
        }

        public string Name { get; set; }

        public int Level { get; set; }

        public string Type { get; set; }


        public override string? ToString()
        {
            return $"{this.Name} - {this.Type} - {this.Level}";
        }
    }
}
