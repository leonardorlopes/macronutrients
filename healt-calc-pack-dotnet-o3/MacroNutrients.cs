using healt_calc_pack_dotnet_o3.Enums;
using healt_calc_pack_dotnet_o3.Interfaces;
using healt_calc_pack_dotnet_o3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace healt_calc_pack_dotnet_o3
{
    public class MacroNutrients : IMacroNutrients
    {
        const double ZERO = 0;
        const double ONE = 1.0;
        const double TWO = 2.0;
        const double THREE = 3.0;
        const double FOUR = 4.0;

        public MacroNutrientsModel Calc(double weight, GoalsEnum goal) {

            switch (goal) {
                case GoalsEnum.PerdaPeso:
                    return new MacroNutrientsModel()
                    {
                        carboidratos = THREE * weight,
                        proteinas = FOUR * weight,
                        gorduras = THREE * weight
                    };
                case GoalsEnum.ManterPeso:
                    return new MacroNutrientsModel()
                    {
                        carboidratos = FOUR * weight,
                        proteinas = FOUR * weight,
                        gorduras = TWO * weight
                    };
                case GoalsEnum.GanhoMassaMuscular:
                    return new MacroNutrientsModel()
                    {
                        carboidratos = FOUR * weight,
                        proteinas = TWO * weight,
                        gorduras = ONE * weight
                    };
                default:
                    break;
            }
            return new MacroNutrientsModel
            {
                carboidratos = ZERO * weight,
                proteinas = ZERO * weight,
                gorduras = ZERO * weight
            };
        }
    }
}
