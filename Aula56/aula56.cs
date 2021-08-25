using System;
using System.Collections.Generic;

namespace Aula56 {
	class Lista {
		public LinkedList<string> lista = new LinkedList<string>();
		public Lista(string firstItem) {
			lista.AddFirst(firstItem);
		}
		public void adInicio(string item) {
			lista.AddFirst(item);
		}
		public void adFim(string item) {
			lista.AddLast(item);
		}
		public void adDepoisDe(string item, string itemAd) {
			LinkedListNode<string> antecessor = lista.FindLast(item);
			lista.AddAfter(antecessor, itemAd);
		}
		public void adAntesDe(string item, string itemAd) {
			LinkedListNode<string> antecessor = lista.FindLast(item);
			lista.AddBefore(antecessor, itemAd);
		}
		public bool itemSearch(string item) {
			return lista.Contains(item);
		}
		public void removerInicio() {
			lista.RemoveFirst();
		}
		public void removerFim() {
			lista.RemoveLast();
		}
		public void itemRemove(string item){
			LinkedListNode<string> ente = lista.FindLast(item);
			if (ente != null) {
				lista.Remove(item);
			} else {
				Console.WriteLine("'{0}' não encontrado.",item);
			}
		}
		public int numNos() {
			return lista.Count;
		}
		public void listClear() {
			lista.Clear();
		}
	}
	class program {
		static void Main() {
			Lista l1 = new Lista("Primeiro Valor");
			l1.adInicio("Adicionado no Início");
			l1.adFim("Adicionado no Fim");
			l1.adDepoisDe("Adicionado no Início", "Adicionado no Segundo Índice");
			l1.adAntesDe("Adicionado no Fim", "Adicionado antes do Último");
			Console.WriteLine("Sua lista contém 'Valor'? {0}",l1.itemSearch("Valor"));
			Console.WriteLine("Sua lista tem {0} valores",l1.numNos());
			Console.WriteLine("Deletar item contendo 'Primeiro'...");
			l1.itemRemove("Primeiro");
			Console.WriteLine("Sua lista contém 'Primeiro Valor'? {0}",l1.itemSearch("Primeiro Valor"));
			Console.WriteLine("Deletar item contendo 'Primeiro Valor'...");
			l1.itemRemove("Primeiro Valor");
			Console.WriteLine("Sua lista contém 'Primeiro Valor'? {0}",l1.itemSearch("Primeiro Valor"));
			Console.WriteLine("Sua lista tem {0} valores",l1.numNos());
			Console.WriteLine("Deletar primeiro item...");
			l1.removerInicio();
			Console.WriteLine("Sua lista tem {0} valores",l1.numNos());
			Console.WriteLine("Deletar último item...");
			l1.removerFim();
			Console.WriteLine("Sua lista tem {0} valores",l1.numNos());
			Console.WriteLine("Deletar todos itens...");
			l1.listClear();
			Console.WriteLine("Sua lista tem {0} valores",l1.numNos());
			Console.Read();
		}
	}
}
