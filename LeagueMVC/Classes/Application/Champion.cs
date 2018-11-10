using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueMVC.Classes.Application
{
    public struct Champion
    {
        public string Name { get; set; }
        public long Id { get; set; }

        public override bool Equals(object obj)
        {
            if (!(obj is Champion))
            {
                return false;
            }

            Champion asChampion = (Champion)obj;
            if (asChampion.Name.ToLower() == this.Name.ToLower() && asChampion.Id == this.Id)
            {
                return true;
            }

            return false;
        }
    }
}
