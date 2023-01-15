namespace restauracja{
	public class Danie{
		public float cena;
		public string nazwa;

		public Danie(string _nazwa, float _cena){
			nazwa=_nazwa;
			cena=_cena;
		}
		
		public void show(){
			Console.WriteLine(nazwa + "  "+ cena + "zł");

		}

	}
	public class Wege : Danie{

		public Wege(string _nazwa, float _cena) : base(_nazwa, _cena){

		}


	}

}