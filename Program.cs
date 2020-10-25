using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace testzadatak {

	class Hrana {
		//string[] pizza = { "Margarita", "Kapricoza", "Cetiri godisnja doba", "Madjarica" };
		//string[] pasta = { "Bolonjeza", "Napolitana", "Arbiata", "Karbonara" };
		//string[] prilog = { "Kecap", "Majonez", "Pavlaka", "Origano" };
		string naziv;
		Random rnd = new Random();
		int cena;
		internal Hrana(string naziv) {
			this.naziv = naziv;
			cena = rnd.Next(300, 600);
		}
		internal void Narudzbina() {
			Console.WriteLine("{0} {1}", naziv, cena);
		}
	}
	class Pice {
		//string[] pice = { "Koka kola", "Negazirani skok", "Voda" };
		string naziv;
		Random rnd = new Random();
		int cena;
		double zapremina;
		internal Pice(string naziv, double zapremina) {
			this.naziv = naziv;
			cena = rnd.Next(150, 500);
			this.zapremina = zapremina;
		}
		internal void Narudzbina() {
			Console.Write("{0} {1} {2}", naziv, cena, zapremina);
		}

	}

	class Porudzbina {

		static private List<Hrana> jela = new List<Hrana>();
		static private List<Pice> pica = new List<Pice>();
		static int brojPorudzbuna = 0;
		internal Porudzbina() { }
		internal Porudzbina(Hrana jelo, Pice pice) {
			jela.Add(jelo);
			pica.Add(pice);
			brojPorudzbuna++;

		}
		static internal void Racun() {
			int i = 0;
			foreach (var item in jela) {
				Console.WriteLine("Narucili ste: ");
				jela[i].Narudzbina();
				pica[i].Narudzbina();
				i++;
				Console.WriteLine();
			}
		}
	}
	//class Restoran {
	//	int[] stolovi = new int[4];

	//	List<Porudzbina> porudzbina = new List<Porudzbina>();
	//	internal Restoran(Porudzbina porudzbina) {
	//		for (int i = 0; i < stolovi.Length; i++) {
	//			this.porudzbina.Add(porudzbina);
	//			if (i>3) {
	//				Console.WriteLine("Svi stolovi su zauzeti");
	//			}
	//		}

	//	}
	//	internal void Stanje() { 

	//	}
	//}

	class Program {
		static void Main(string[] args) {
			Console.WriteLine("Narucite hranu i pice: \nZa izlazak pritisnite ESCAPE, za porudzbinu stisnite ENTER");
			while (Console.ReadKey().Key != ConsoleKey.Escape) {

				new Porudzbina(new Hrana(Console.ReadLine()), new Pice(Console.ReadLine(), Convert.ToDouble(Console.ReadLine())));

			}

			Porudzbina.Racun();
			Console.ReadLine();
		}


	}
}

