using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace healt_calc_pack_dotnet_o3.Interfaces
{
    public interface IIMC
    {
        double Calc(double height, double weight);
        string GetIMCCategory(double imc);
        bool IsValidData(double height, double weight);
    }
}
