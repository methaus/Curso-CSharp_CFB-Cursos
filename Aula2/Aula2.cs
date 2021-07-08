using System;

namespace Aula2 {
    class local {
        static void Main(string[] args) {
            Console.WriteLine("Teste Aula2.");
            if(args.GetLength(0)>0) {
                Console.WriteLine(args.GetValue(1));
            }
        }
    }
}

// Cria o executável padrão da linguagem C#: "dotnet new console"
// Cria o executável do programa padrão "Program": "csc program.cs" mesmo código para compilar
// Lendo parâmetros inseridos no prompt de comando: "program 'Parâmetro0, Parâmetro1..."