using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandwichMenu
{
    public class MenuItem
    {
        Random Randomizer = new Random();

        string[] Proteins = { "Wołowina", "Salami", "Indyk", "Szynka", "Pastrami", "Tofu" };
        string[] Condiments = { "musztarda żółta", "musztarda brązowa", "musztarda miodowa", "majonez", "przyprawy", "sos francuski" };
        string[] Breads = { "ryżowe", "białe", "pszenne", "pumpernikiel", "bułka" };

        string Description = "";
        string Price;

    }
}
