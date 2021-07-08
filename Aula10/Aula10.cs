using System;

namespace Aula10 {
    class program {
        enum DiaSemana {Domingo,Segunda,Terça,Quarta,Quinta,Sexta,Sábado};
        static void Main() {
            DiaSemana dia1 = DiaSemana.Domingo; // Armazendo o tipo "DiaSemana": "Domingo"
            Console.WriteLine(dia1);
            DiaSemana dia2 = (DiaSemana)1; // Lendo o índice de "DiaSemana" = 1: !Segunda!
            Console.WriteLine(dia2);
            int dia3 = (int)DiaSemana.Terça; // Usando o índice de "DiaSemana.Terça" = 2 como valor para variável "int"
            DiaSemana dia03 = (DiaSemana)dia3; // Usando a variável "dia3" como índice de procura do valor na "DiaSemana"
            Console.WriteLine("{0} é o índice de {1}",dia3,dia03);
        }
    }
}