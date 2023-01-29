using System;
using restauracja;

List<Kategoria> a = new List<Kategoria>();
Danie[] dania = {
	new Danie("Lazania",21),
	new Danie("Spaghetti bolognese",21),
	new Danie("Spaghetti carbonara",22)
	};

a.Add(new Kategoria("Dania główne",dania));

dania= new Danie[]{
	new Danie("Rosół",19),
	new Wege("Pomidorowa",18),
	new Wege("Zupa grzybowa",19),
	new Rybne("Zupa rybna",20)
};
a.Add(new Kategoria("Zupy",dania));

dania= new Danie[]{
	new Danie("Margarita", 24),
	new Danie("Capriciosa", 24),
	new Ostre("Diavolo", 24)
};
a.Add(new Kategoria("Pizze",dania));


dania= new Danie[]{
	new Danie("Sałatka Cezar", 24),
	new Danie("Salatka Grecka", 24)
};
a.Add(new Kategoria("Sałatki",dania));

dania= new Danie[]{
	new Danie("Sałatka Cezar", 24),
	new Wege("Salatka Grecka", 24)
};
dania= new Danie[]{
	new Danie("Szarlotka z lodami",26),
	new Danie("Lody w pucharku",20),
	new Danie("Sernik z rodzynkami",12),
	new Danie("Sernik",13)
};
a.Add(new Kategoria("Desery",dania));

dania= new Danie[]{
	new Danie("Woda",8),
	new Danie("Cola",10),
	new Danie("Sprite",9),
	new Danie("Lech Premium",14)
};
a.Add(new Kategoria("Napoje",dania));

interfejs hud = new interfejs(a.ToArray());

string user;

while (true){
	hud.show_options();
	user = Console.ReadLine();
	if (user != null && int.TryParse(user,out int i)){
		hud.select(int.Parse(user));
	}

}
