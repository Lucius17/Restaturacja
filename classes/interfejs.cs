namespace restauracja{
	public class interfejs{
		Kategoria[] kategorie;

		public  interfejs(Kategoria[] _kat){
			kategorie=_kat;

		}
		string[] opcje = {
			"Pokaż menu",
			"Dodaj danie",
			"Usuń danie",
			"Dodaj kategorię",
			"Usuń kategorię",
			"Utwórz paragon",
			"Utwórz fakturę",
		};
		public void show_options(){
			for (int i = 0;i<opcje.Length;i++){
				Console.WriteLine(i+". "+opcje[i]);
			}
		}
		public void show_menu(){
			foreach(Kategoria kategoria in kategorie){
				Console.WriteLine(kategoria.nazwa);
				kategoria.show();
				Console.WriteLine("");
			}

		}


	}

}