using System;

namespace Aula28 {
    class Jogador {
        public int energia = 100;
        public bool vivo = true;
    }
    class program {
        static void Main() {
            Jogador j1 = new Jogador();
            Jogador j2 = new Jogador();
            j1.energia = 50;
            j2.energia = 0;
            j2.vivo = false;
            Console.WriteLine("Jogador 1 tem energia = {0} e vivo = {1}", j1.energia, j1.vivo);
            Console.WriteLine("Jogador 2 tem energia = {0} e vivo = {1}", j2.energia, j2.vivo);
        }
    }
}

//      [ModificadorClasse] class NOME_DA_CLASSE
//      {
//      Variáveis / Propriedades
//      [EspecificadorAcesso] tipo NOME_PROPRIEDADE;
//      
//      Metodos
//      [EspecificadorAcesso] retorno NOME_METODO([arg1,...])
//      {
//      corpo do método
//      }
// }

//-------O QUE SÃO E APLICAÇÕES:-----------------------------------------------//

//      [ModificadorClasse]: Define a visibilidade da classe.
//      public: pública, sem restrição de visualização.
//      abstract: Classe-Base para outrsas classes, não podem ser instanciados a objetos desta classe
//      sealed: Classe não pode ser herdada
//      static: Classe não permite a instanciação de objetos e seus membros devem ser "static"
//
//      [EspecificadorAcesso]: Onde um membro da classe pode ser acessado
//      public: pública, sem restrição de acesso.
//      private: Só podem ser acessados pela própria classe.
//      protected: Podem ser acessados na própria classe e nas classes derivadas
//      abstract: Os métodos não tem implementação somente os cabeçalhos
//      sealed: O método não pode ser redefinido.
//      virtual: O método pode ser redefinido em uma classe derivada.
//      static: o método pode ser chamado mesmo sem a instanciação de um objeto.