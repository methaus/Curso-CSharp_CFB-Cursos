using System;


namespace Triangulo {
	class Area { // ter classes com o mesmo nome para entes diferentes
		public static float calcular(int b, int h) {
			float bt = b;
			float ht = h;
			return bt * ht / 2;
		}
	}
}

namespace Quadrilatero {
	class Area { // ter classes com o mesmo nome para entes diferentes
		public static int calcular(int b, int h) {
			return b * h;
		}
	}
}

class program {
	static void Main() {
		int b = 7, h = 7;
		Console.WriteLine("Para uma base {0} e altura {1}, um quadrilátero tem {2} de área e um triângulo tem {3} de área...",b,h,Quadrilatero.Area.calcular(b,h),Triangulo.Area.calcular(b,h));
		Console.Read();
	}
}