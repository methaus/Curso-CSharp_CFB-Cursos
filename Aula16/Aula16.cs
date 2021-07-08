using System;

namespace Aula14 {
    class program {
        static void Main() {            
            char resposta;
            string result;
            string cont;
            bool acerto;
            string cgoto;
            refazer: // retorno go to
            Console.Clear();
            Console.WriteLine("Questão 01: Quanto é 8^30 dividido pela metade?");
            Console.WriteLine("|A| 4^30\n|B| 2^60\n|C| 2^89\n|D| 4^29\nDigite a,b,c ou d.");
            Console.Write("Sua resposta: ");
            resposta = Char.Parse(Console.ReadLine());
            switch (resposta) {
                case 'a':
                case 'A':
                    acerto = false;
                    result = "Sua resposta está errada.";
                    break;
                case 'b':
                case 'B':
                    acerto = false;
                    result = "Sua resposta está errada.";
                    break;                
                case 'c':
                case 'C':
                    acerto = true;
                    result = "Sua resposta está correta.";
                    break;
                case 'd':
                case 'D':
                    acerto = false;
                    result = "Sua resposta está errada.";
                    break;
                default:
                    acerto = true;
                    result = "Sua resposta é inválida.";                    
                    break;                
            }
            Console.WriteLine(result);
            if (acerto == false) {
                Console.WriteLine("Deseja tentar de novo? Digite Sim ou Não.");
                    cgoto = Console.ReadLine();
                    switch (cgoto) {
                        case "Sim":
                        case "sim":
                            goto refazer; // comando go to
                            break;
                        case "Não":
                        case "não":
                        case "Nao":
                        case "nao":
                            break;
                        default:
                            Console.WriteLine("Comando inválido.");
                            acerto = true;
                            break;
                    }
            }            
            if (acerto == false) {
                Console.WriteLine("Deseja saber a resposta correta? Digite Sim ou Não.");
                cont = Console.ReadLine();
                switch (cont) {
                    case "Sim":
                    case "sim":
                        Console.WriteLine("A resposta correta é a |C|.");
                        break;
                    case "Não":
                    case "não":
                    case "Nao":
                    case "nao":
                        break;
                    default:
                        Console.WriteLine("Resposta inválida.");
                        break;
                }                
            }
            Console.WriteLine("Fim do Programa.");          
        }
    }
}