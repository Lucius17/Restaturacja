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
	new Danie("Pomidorowa",18),
	new Danie("Zupa grzybowa",19)
};

a.Add(new Kategoria("Zupy",dania));

dania= new Danie[]{
	new Danie("Sałatka Cezar", 24),
	new Danie("Salatka Grecka", 24)
};
a.Add(new Kategoria("Sałatki",dania));

dania= new Danie[]{
	new Danie("Sałatka Cezar", 24),
	new Danie("Salatka Grecka", 24)
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

