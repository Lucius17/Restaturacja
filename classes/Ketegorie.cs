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


		public void show_with_index(){
			for(int i=0; i<dania.Length; i++){
				Console.WriteLine(i +". "+ dania[i].nazwa);
			}
		}
		public void add(Danie food){
			dania = dania.Concat(new Danie[] { food }).ToArray();

		}
		public void show_rodzaje(string s){
			if(s == "zwykłe danie") s="Danie";
			foreach(Danie a in dania){
				if(a.GetType().Name == s){
					a.show();
				}
			}

		}
		public void del(int index){
			List<Danie> temp = new List<Danie>();
			for (int i= 0;i < dania.Length;i++){
				if (i!=index){
					temp.Add(dania[i]);
				}
			}
			dania = temp.ToArray();
		}
		public Danie get_danie_by_index(int ind){
			return dania[ind];
		}

	}

}