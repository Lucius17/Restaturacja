namespace restauracja{
	public class Rachunek{
		List<Danie> lista = new List<Danie>();

		public void add(Danie d, int amount){
			d.ilosc = amount;
			lista.Add(d);
		}
		public void show(){
			Danie[] arr = lista.ToArray();
			foreach(Danie danie in arr){
				Console.WriteLine(danie.nazwa + "          "+danie.ilosc+".szt");

			}
		}


	}

}