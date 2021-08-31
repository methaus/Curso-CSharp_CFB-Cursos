using System;
using System.Collections.Generic;

namespace Aula56 {
	class Lista {
		public List<string> lista = new List<string>();
		public Lista(string firstItem) {
			lista.Add(firstItem);
		}
		public void addItem(string item) {
			lista.Add(item);
		}
		public void addItens(params string[] itens) {
			lista.AddRange(itens);
		}
		public bool itemSearch(string item) {
			return lista.Contains(item);
		}
		public void itemRemove(string item) {
			if (lista.Remove(item) != true) {
				Console.WriteLine("Item não encontrado...");
			} else {
				Console.WriteLine("{0} apagado", item);
			}
		}
		public void itemRemove(int i) {
			lista.RemoveAt(i);
		}
		public void itensRemove(int i, int qtd) {
			lista.RemoveRange(i, qtd);
		}
		public void itemInsert(string item, int i) {
			lista.Insert(i, item); //empurra os proximos para frente
		}
		public int numNos() {
			return lista.Count;
		}
		public void inverter() {
			lista.Reverse();
		}
		public void listClear() {
			lista.Clear();
		}
		public void imprimir() {
			foreach (string i in lista) {
				Console.WriteLine(i);
			}
		}
	}
	class program {
		static void Main() {
			int aPartirDo = 1, quantidadeARemover = 2;
			Lista lista = new Lista("item1");
			lista.addItem("item2");
			lista.addItens("item3","item4","item5");
			lista.imprimir();
			lista.itemRemove("item6");
			lista.itemRemove("item5");
			lista.imprimir();
			Console.WriteLine("-----------------------");
			Console.WriteLine("Remover 2 a partir do índice 1...");
			lista.itensRemove(aPartirDo, quantidadeARemover);
			lista.imprimir();
			Console.WriteLine("-----------------------");
			Console.WriteLine("Inserir um no índice 0...");
			lista.itemInsert("no lugar do item1", 0);
			lista.imprimir();
			Console.WriteLine("-----------------------");
			Console.WriteLine("Remover o índice 0");
			lista.itemRemove(0);
			lista.imprimir();
			Console.WriteLine("-----------------------");
			Console.WriteLine("Inverter a lista...");
			lista.inverter();
			lista.imprimir();
			Console.WriteLine("Fim da lista...");
			Console.Read();
		}
	}
}


// metodo List.Sort() = colocar em ordem alfabética