# macronutrients

.Net Library that calculates the BMI and also calculates the macronutrients of a diet according to the weight and the objective of the diet that is represented by the Enum "GoalsEnum".


## 💻 Technologies

The project uses the technologies:

- .NET 6.0

## 💻 Common Usage

- Import the library into the project.
- Instantiate the library  `IIMC imc = new IMC();`
- To calculate the BMI = ` double imc = imc .Calc(double height, double weight);`
- To get the category = `String category= GetIMCCategory(double imc);` 

## Index

=> 0 < 18.5  => MAGREZA
>= 18.5 < 25 => NORMAL
>= 25 < 30 => SOBREPESO
>= 30 < 40 => OBESIDADE
> 40 => OBESIDADE GRAVE

## Limits

MAX_WEIGHT = 3.00
MAX_HEIGHT = 500

## Tests

<img src="macronutrients\img\coverage.png" alt="Tests Coverage">
