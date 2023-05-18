using healt_calc_pack_dotnet_o3;
using healt_calc_pack_dotnet_o3.Interfaces;
using Xunit;

namespace health_check_pack_dotnet_test.Library
{
    public class IMCTest
    {
        [Fact]
        public void CalculaIMC_Quando_DadosValidos_Entao_RetornaIndice()
        {
            //Arrange
            IIMC imc = new IMC();
            double height = 1.70;
            double weight = 88.3;
            double expectedIMC = 30.55;

            //Act
            var result = imc.Calc(height, weight);

            //Asserts
            Assert.Equal(expectedIMC, result);
        }

        [Fact]
        public void ValidaIMC_Quando_DadosValidos_Entao_RetornaVerdadeiro()
        {
            //Arrange
            IIMC imc = new IMC();
            double height = 10.0;
            double weight = 400.0;            

            //Act
            var result = imc.IsValidData(height, weight);

            //Asserts
            Assert.False(result);
        }

        [Theory]
        [InlineData(15.0, "MAGREZA")]
        [InlineData(24.55, "NORMAL")]
        [InlineData(29.55, "SOBREPESO")]
        [InlineData(30.55, "OBESIDADE")]
        [InlineData(40.55, "OBESIDADE GRAVE")]
        public void RetornarCategoriaIMC_Quando_IndiceValido_Entao_RetornaDescricao(double imcValue, string expected)
        {
            //Arrange
            IIMC imc = new IMC();            

            //Act
            var result = imc.GetIMCCategory(imcValue);

            //Asserts
            Assert.Equal(expected, result);
        }
    }
}