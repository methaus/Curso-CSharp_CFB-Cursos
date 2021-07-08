using System;

namespace Aula6 {
    class Program {
        static void Main() {
            Console.Write("Teste\n"); // impressão de texto
            Console.WriteLine("Teste linha 2"); // com quebra de linha
            int var1, var2, var3; 
            var1 = 0; 
            var2 = 1; 
            var3 = 2;
            Console.WriteLine("variável 1 = "+var1+" variável 2 = "+var2+" variável 3 = "+var3); // concatenando texto
            Console.WriteLine("variável 1 = {0} variável 2 = {1} variável 3 = {2}",var1,var2,var3); // indexando variáveis
            Console.WriteLine("Controle de\tParágrafo.");
            // Exemplo sobre compra e venda: indicação de formatação
            string produto = "Produto";
            int valorc = 5;
            int valorv = 10;
            int lucro;
            lucro = ((valorv-valorc)*100) / valorc; // Com o "%" na fórmula
            lucro = (valorv-valorc) / valorc; // Com o "%" ausento, posto que será aplicado na leitura
            Console.WriteLine("Produto.........:{0,15}",produto); // Entre chaves o primeiro número é o índice
            Console.WriteLine("Val.Compra......:{0,15:c}",valorc); // O segundo número é o tamanho do índice em caracteres
            Console.WriteLine("Val.Venda.......:{0,15:c}",valorv); // O terceiro, depois de ":" refere à unidade do valor
            Console.WriteLine("Lucro...........:{0,15:p}",lucro); // sendo "c" monetário e "p" = %
            Console.WriteLine("Teste de tamanho................\n");
            Console.WriteLine("........");
            Console.WriteLine("\tTeste para tamanho de parágrafo"); 
            Console.WriteLine("................");
            Console.WriteLine("Teste\tpara\ttamanho de parágrafo"); // parágrafo = espaço com intervalo de 8 caracteres
        }
    }
}

// contra-barra N "\n" é igual a enter: quebra de linha = caracter de escape
// para ler variável indexada no comando "Write/WriteLine" usa-se as chaves "{}" = caracter de escape
// contra-barra T "\t" é igual a 'backspace' ou parágrafo (dito tabulação) + caracter de escape
// Delimitação de parágrafo