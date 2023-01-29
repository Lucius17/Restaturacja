namespace restauracja{
	public class interfejs{
		Kategoria[] kategorie;
		string[] opcje = {
			"Pokaż menu",
			"Dodaj danie",
			"Usuń danie",
			"Dodaj kategorię",
			"Usuń kategorię",
			"Utwórz rachunek",
			"Wyszukaj rodzaj dania"
		};
		string[] rodzaje = {
			"Zwykłe Danie",
			"Wege",
			"Rybne",
			"Ostre",
		};
		

		public  interfejs(Kategoria[] _kat){
			kategorie=_kat;

		}
		public void show_options(){
			for (int i = 0;i<opcje.Length;i++){
				Console.WriteLine(i+". "+opcje[i]);
			}
		}
		public void show_rodzaje(){
			for (int i = 0;i<rodzaje.Length;i++){
				Console.WriteLine(i+". "+rodzaje[i]);
			}
		}
		public void show_menu(){
			foreach(Kategoria kategoria in kategorie){
				Console.WriteLine("------"+kategoria.nazwa+"------");
				kategoria.show();
				Console.WriteLine("");
			}

		}
		int select_category(){
			string user;
			for (int i = 0;i<kategorie.Length;i++){
				Console.WriteLine(i+". "+kategorie[i].nazwa);
			}
			user = Console.ReadLine();
			if (user=="x") return -1;
			if (user==null || int.TryParse(user,out int f)==false){
				return select_category();
			}
			else{
				return int.Parse(user);
			}

		}


		public void select(int input){
			switch(input){
				case 0:
					show_menu();
					break;
				case 1:
					Console.WriteLine("Do jakiej kategori chcesz dodac danie?");
					int index = select_category();
					Console.WriteLine("wybierz rodzaj dania jakie chcesz dodać");
					show_rodzaje();
					string user;
					user= Console.ReadLine();
					Console.WriteLine("Podaj nawę dania");
					string user_nazwa = Console.ReadLine();
					Console.WriteLine("Podaj cenę dania");
					string user_cena = Console.ReadLine();
					if (user!=null && int.TryParse(user,out int im) && int.TryParse(user,out int f)){
						switch(user){
							case "0":
                        kategorie[index].add(new Danie(user_nazwa,int.Parse(user_cena)));
								break;
							case "1":
                        kategorie[index].add(new Wege(user_nazwa,int.Parse(user_cena)));
								break;
							case "2":
                        kategorie[index].add(new Rybne(user_nazwa,int.Parse(user_cena)));
								break;
							case "3":
                        kategorie[index].add(new Ostre(user_nazwa,int.Parse(user_cena)));
								break;
						}
					}
					else{
						Console.WriteLine("błędne dane");
					}
					break;
				case 2:
					Console.WriteLine("Z jakiej kategorii chcesz usunąć danie?");
					int ind = select_category();
					kategorie[ind].show_with_index();
					Console.WriteLine("Jakie danie usunąć?");
					user= Console.ReadLine();
					kategorie[ind].del(int.Parse(user));
					break;

				case 3:
					List<Kategoria> temp = new List<Kategoria>();
					for (int i= 0;i < kategorie.Length;i++){
						temp.Add(kategorie[i]);
					}
					Console.WriteLine("Podaj nazwę kategori");
					user = Console.ReadLine();
					Danie[] a = {};
					temp.Add(new Kategoria(user,a));
					kategorie = temp.ToArray();

					break;
				case 4:
					Console.WriteLine("Wybierz kategorię którą chcesz usunąć");
					ind = select_category();
					temp = new List<Kategoria>();
					for (int i= 0;i < kategorie.Length;i++){
						temp.Add(kategorie[i]);
					}
					temp.RemoveAt(ind);
					kategorie = temp.ToArray();
					break;
				case 5:
					Rachunek rachunek = new Rachunek();
					string amount; 
					do{
						Console.WriteLine("Wybierz z jakiej kategorii chcesz dodać produkt");
						Console.WriteLine("jeśli nie chcesz dodawać produktu wciśnij x i zatwierdź enterem");
						ind = select_category();
						if (ind!=-1){
							Console.WriteLine("Wybierz danie");
							kategorie[ind].show_with_index();
							user = Console.ReadLine();
							Console.WriteLine("Podaj ilosc");
							amount = Console.ReadLine();
							rachunek.add(kategorie[ind].get_danie_by_index(int.Parse(user)),int.Parse(amount));
						}
						

					}
					while(ind!=-1);
					rachunek.show();

					break;
				case 6:
					show_rodzaje();
					user = Console.ReadLine();
					user = rodzaje[int.Parse(user)];
					for (int i = 0; i<kategorie.Length;i++){
						kategorie[i].show_rodzaje(user);

					}
				
					break;
				default:
					Console.WriteLine("Nie ma takiej opcji");
					
					break;
			}

		}


	}

}