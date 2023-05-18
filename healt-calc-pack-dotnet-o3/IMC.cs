using healt_calc_pack_dotnet_o3.Interfaces;
namespace healt_calc_pack_dotnet_o3
{
    public class IMC : IIMC
    {
        const String MAGREZA = "MAGREZA";
        const String NORMAL = "NORMAL";
        const String SOBREPESO = "SOBREPESO";
        const String OBESIDADE = "OBESIDADE";
        const String OBESIDADE_GRAVE = "OBESIDADE GRAVE";        

        const double MAGREZA_FIM = 18.5;
        const double NORMAL_FIM = 25.0;
        const double SOBREPESO_FIM = 30.0;
        const double OBESIDADE_FIM = 40.0;
        const double MAX_HEIGHT = 3.0;
        const double MAX_WEIGHT = 500;

        const int TWO = 2;

        public double Calc(double height, double weight)
        {
            return Math.Round(weight / (height * height), TWO);
        }

        public string GetIMCCategory(double imc)
        {   
            return imc switch
            {
                > 0 and < MAGREZA_FIM => MAGREZA,
                > MAGREZA_FIM and < NORMAL_FIM => NORMAL,
                > NORMAL_FIM and < SOBREPESO_FIM => SOBREPESO,
                > SOBREPESO_FIM and < OBESIDADE_FIM => OBESIDADE,
                > OBESIDADE_FIM => OBESIDADE_GRAVE
            };           
               
        }

        public bool IsValidData(double height, double weight)
        {
            return (height < MAX_HEIGHT && weight <= MAX_WEIGHT);
        }
    }
}