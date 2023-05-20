using healt_calc_pack_dotnet_o3;
using healt_calc_pack_dotnet_o3.Enums;
using healt_calc_pack_dotnet_o3.Interfaces;
using healt_calc_pack_dotnet_o3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace health_check_pack_dotnet_test.Library
{
    public class MacroNutrientsTest
    {       
        [Theory]
        [InlineData(104.30, GoalsEnum.PerdaPeso, 312.9, 417.2, 312.9)]
        [InlineData(60.0, GoalsEnum.GanhoMassaMuscular, 240.0, 120.0, 60.0)]
        [InlineData(104.30, GoalsEnum.ManterPeso, 417.2, 417.2, 208.6)]
        [InlineData(104.30, GoalsEnum.Outro, 0, 0, 0)]
        public void CalculaMacronutrientes_Quando_DadosValidos_Entao_RetornaMacronutrientes(double weight, GoalsEnum goal,
            double expCarboidratos, double expProteinas, double expGorduras)
        {
            //Arrange
            IMacroNutrients macroNutrients = new MacroNutrients();

            //Act
            var result = macroNutrients.Calc(weight, goal);

            //Asserts
            Assert.Equal(expCarboidratos, result.carboidratos);
            Assert.Equal(expProteinas, result.proteinas);
            Assert.Equal(expGorduras, result.gorduras);
        }
    }
}
