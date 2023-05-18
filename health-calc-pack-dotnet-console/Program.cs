using healt_calc_pack_dotnet_o3;

var imc = new IMC();
var result = imc.Calc(1.85, 70.0);
var classificacao = imc.GetIMCCategory(result);

Console.WriteLine($"Seu IMC é: {result} classificado como: {classificacao}");