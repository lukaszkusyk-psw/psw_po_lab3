using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psw_po_lab3
{
    class Calculator
    {
        public static List<Preset> DishPresets = new List<Preset>(){
            new Preset("Extra Small (20cl)", 0.2),
            new Preset("Small (33cl)", 0.33),
            new Preset("Half-liter (50cl)", 0.5),
            new Preset("Standard Vodka (70cl)", 0.70),
            new Preset("Standard Wine (75cl)", 0.75),
            new Preset("Liter (1l)", 1),
            new Preset("One and a half liters (1.5l)", 1.5),
        };

        public static List<Preset> TypesPresets = new List<Preset>(){
            new Preset("Cider (4%)", 4),
            new Preset("Beer (5%)", 5),
            new Preset("Wine (14%)", 14),
            new Preset("Liqueur (25%)", 25),
            new Preset("Rum (37.5%)", 37.5),
            new Preset("Vodka (40%)", 40),
            new Preset("Whisky (55%)", 55),
            new Preset("Grain Alcohol (95%)", 95),
        };

        public static double TotalVolume(double dishVolume, int dishesCount)
        {
            return dishVolume * dishesCount;
        }

        public static double AlcoholVolume(double dishVolume, double alcoholPercentage, int dishesCount)
        {
            return dishVolume * alcoholPercentage * 0.01 * dishesCount;
        }
    }
}
