﻿// string name = "Rubens";
// Console.WriteLine(name);

// int idade = 18;
// idade = 50;

// const int idade = 18;
// Console.WriteLine("A idade do " + name + " é " + idade + " anos ");

// bool careca = false;
// Console.WriteLine(careca);


// atribuicoes =

int x = 15;

// operadores aritméticos

// soma
// Console.WriteLine(5 + 4);
// Console.WriteLine(5 + "4");
// Console.WriteLine(5 + x);

// subtração
// Console.WriteLine(15 - 3);

// multiplicação
// Console.WriteLine(5 * 5);

// divisão
// Console.WriteLine(10 / 10);

// modular
// Console.WriteLine(5 % 2);


// //operadores de comparação

// //igual a
// Console.WriteLine(5 == 7);

// // maior ou igual a
// Console.WriteLine(5 >= 10);

// //menor ou igual a
// Console.WriteLine(4 <= 10);

// //maior que
// Console.WriteLine(150 > 95);

// //menor que
// Console.WriteLine(54 < 54);

// //diferente de
// Console.WriteLine( 5 != 6);

//operadores lógicos

// && : e
// || : ou 
// ! : não

// Console.WriteLine(5 == 5 && 8 == 8);// TRUE && TRUE = TRUE
// Console.WriteLine(5 == 5 && 8 == 5);// TRUE && FALSE = FALSE
// Console.WriteLine(5 == 6 && 8 == 8);// FALSE && TRUE = FALSE
// Console.WriteLine(5 == 6 && 8 == 5);// FALSE && FALSE = FALSE

// Console.WriteLine(2 == 2 || 3 == 3);// TRUE || TRUE = TRUE
// Console.WriteLine(2 == 2 || 3 == 4);// TRUE || FALSE = TRUE
// Console.WriteLine(2 == 4 || 3 == 3);// FALSE || TRUE = TRUE
// Console.WriteLine(2 == 4 || 3 == 5);// FALSE || FALSE = FALSE

// Console.WriteLine((2 == 4 || 4 == 4) && (7 == 6));

// Console.WriteLine(!(2 == 2 || 3 == 3));


// crie um programa para calcular o imc de uma pessoa 

// algoritimo
// entrada: nome, idade, peso, altura
// processamento: peso dividido por altura ao quadrado

string nome ="Rubens";
int idade =18;
float peso = 60;
float altura = 1.70f;

// processamento
float imc = peso /(altura*altura);

// saida
Console.WriteLine(imc);
