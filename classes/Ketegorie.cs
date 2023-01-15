namespace restauracja{
	public class Kategoria{
		public string nazwa;
		Danie[] dania;

		public Kategoria(string _nazwa, Danie[] _dania){
			nazwa = _nazwa;
			dania = _dania;
		}
		public void show(){
			for(int i=0; i<dania.Length; i++){
				dania[i].show();
			}
		}

	}

}