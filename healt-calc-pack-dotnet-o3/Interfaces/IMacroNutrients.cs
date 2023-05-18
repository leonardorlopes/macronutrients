using healt_calc_pack_dotnet_o3.Enums;
using healt_calc_pack_dotnet_o3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace healt_calc_pack_dotnet_o3.Interfaces
{
    public interface IMacroNutrients 
    {
        MacroNutrientsModel Calc(double weight, GoalsEnum goal);
    }
}
