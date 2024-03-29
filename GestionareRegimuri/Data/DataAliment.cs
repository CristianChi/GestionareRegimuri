﻿using GestionareRegimuri.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionareRegimuri.Data
{
    public class DataAliment
    {
        private static readonly string[] alimentList = {
            "Andive;Legume;3;2;0;20",
            "Anghinare;Legume;8;2;0;47",
            "Ardei gras rosu;Legume;7;1;0;39",
            "Ardei gras verde;Legume;5;1;0;17",
            "Cartofi fierti;Legume;20;1;0;87",
            "Cartofi maturi;Legume;20;1;0;88",
            "Cartofi noi;Legume;17;1;0;80",
            "Cartofi copti;Legume;22;1;0;93",
            "Cartofi prajiti;Legume;44;2;0;312",
            "Castraveti;Legume;3;1;0;19",
            "Ceapa uscata;Legume;10;2;0;40",
            "Ceapa verde;Legume;8;1;0;20",
            "Ciuperci;Legume;3;1;1;35",
            "Conopida;Legume;4;3;0;30",
            "Conopida conservata (sterilizata) in apa;Legume;2;1;0;20",
            "Conopida fiarta;Legume;2;2;0;23",
            "Dovleac copt;Legume;12;1;0;20",
            "Dovlecei;Legume;3;0;0;18",
            "Dovlecei in apa(sterilizat);Legume;3;2;1;16",
            "Fasole boabe;Legume;47;23;2;303",
            "Fasole verde conservata;Legume;2;1;0;20",
            "Fasole verde pastai cruda;Legume;5;2;0;33",
            "Gogosari;Legume;7;2;0;20",
            "Gulii crude;Legume;6;2;0;30",
            "Hrean;Legume;20;2;0;67",
            "Hribi;Legume;5;0;5;34",
            "Linte uscata;Legume;50;25;2;339",
            "Loboda;Legume;1;3;0;19",
            "Macris;Legume;2;0;0;24",
            "Marar (frunze);Legume;6;2;0;43",
            "Mazare uscata boabe;Legume;53;22;2;354",
            "Mazare verde boabe;Legume;14;8;0;96",
            "Mazare verde conservata;Legume;8;2;0;48",
            "Morcovi cruzi;Legume;9;2;0;45",
            "Papadie;Legume;9;3;0;44",
            "Pastarnac;Legume;15;1;0;72",
            "Patrunjel (frunze);Legume;7;4;1;50",
            "Patrunjel radacina;Legume;10;1;1;20",
            "Praz crud;Legume;10;2;0;54",
            "Ridichi de iarna;Legume;5;1;0;26",
            "Ridichi de luna;Legume;4;1;0;19",
            "Rosii bulion;Legume;12;4;0;30",
            "Rosii pasta;Legume;18;5;0;85",
            "Rosii proaspete;Legume;4;1;0;20",
            "Salata verde;Legume;3;1;0;22",
            "Sfecla rosie;Legume;9;1;0;43",
            "Spanac crud;Legume;2;4;0;25",
            "Sparanghel;Legume;3;2;0;21",
            "Stevie;Legume;0;5;0;22",
            "Suc de rosii;Legume;5;1;0;30",
            "Telina (radacina);Legume;6;1;0;33",
            "Urzici;Legume;7;8;0;68",
            "Usturoi;Legume;26;7;0;137",
            "Varza alba cruda, varza creata;Legume;5;0;0;33",
            "Varza de Bruxelles;Legume;7;4;1;50",
            "Varza rosie cruda;Legume;6;2;0;33",
            "Vinete crude;Legume;5;1;0;27",
            "Afine;Fructe Proaspete;15;1;0;61",
            "Agrise;Fructe Proaspete;9;1;0;44",
            "Ananas;Fructe Proaspete;12;0;0;52",
            "Arahide (alune);Fructe Proaspete;19;9;34;590",
            "Banane fara coaja;Fructe Proaspete;18;1;0;94",
            "Caise fara sambure;Fructe Proaspete;15;1;0;51",
            "Capsuni;Fructe Proaspete;8;1;1;37",
            "Cirese de iunie;Fructe Proaspete;15;1;0;21",
            "Cirese de mai;Fructe Proaspete;10;1;0;21",
            "Coacaze negre;Fructe Proaspete;13;1;1;58",
            "Coacaze rosii;Fructe Proaspete;10;2;1;62",
            "Coarne;Fructe Proaspete;17;1;0;76",
            "Corcoduse;Fructe Proaspete;10;1;0;45",
            "Dude;Fructe Proaspete;14;1;1;81",
            "Floarea soarelui (seminte);Fructe Proaspete;15;15;32;570",
            "Fragi de padure;Fructe Proaspete;10;1;1;32",
            "Grapefruit;Fructe Proaspete;4;0;0;30",
            "Gutui;Fructe Proaspete;14;1;1;52",
            "Kaki;Fructe Proaspete;20;1;0;127",
            "Kiwi;Fructe Proaspete;5;0;0;61",
            "Lamai cu coaja;Fructe Proaspete;6;1;1;36",
            "Mac;Fructe Proaspete;19;19;40;525",
            "Macese (partea carnoasa);Fructe Proaspete;22;5;1;117",
            "Mandarine fara coaja;Fructe Proaspete;10;1;0;40",
            "Mango;Fructe Proaspete;17;1;0;60",
            "Masline cu sambure;Fructe Proaspete;7;2;35;437",
            "Mere cretesti;Fructe Proaspete;10;0;0;50",
            "Mere ionatane;Fructe Proaspete;15;0;0;67",
            "Mure;Fructe Proaspete;15;0;0;43",
            "Nectarine;Fructe Proaspete;14;1;0;44",
            "Nuci verzi fara coaja (samburi);Fructe Proaspete;10;13;48;757",
            "Pepene galben cu coaja;Fructe Proaspete;5;0;0;45",
            "Pepene galben fara coaja;Fructe Proaspete;10;0;0;54",
            "Pepene verde cu coaja;Fructe Proaspete;4;0;0;20",
            "Pepene verde fara coaja;Fructe Proaspete;6;1;0;28",
            "Pere;Fructe Proaspete;15;1;0;79",
            "Piersici;Fructe Proaspete;15;1;0;47",
            "Portocale fara coaja;Fructe Proaspete;10;0;0;47",
            "Prune cu samburi;Fructe Proaspete;14;0;0;89",
            "Prune fara samburi;Fructe Proaspete;20;0;0;110",
            "Renglote;Fructe Proaspete;15;0;0;92",
            "Rodie;Fructe Proaspete;14;1;1;83",
            "Smochine proaspete;Fructe Proaspete;16;0;0;267",
            "Struguri;Fructe Proaspete;20;0;0;93",
            "Visine;Fructe Proaspete;15;1;1;27",
            "Zmeura;Fructe Proaspete;16;1;1;66",
            "Caise uscate fara samburi;Fructe Uscate;68;5;0;241",
            "Curmale uscate cu samburi;Fructe Uscate;74;2;1;319",
            "Curmale uscate fara samburi;Fructe Uscate;83;2;0;298",
            "Cafea prajita;Fructe Uscate;4;14;14;287",
            "Castane;Fructe Uscate;70;11;7;245",
            "Macese uscate cu seminte;Fructe Uscate;62;2;1;162",
            "Mere uscate (poame);Fructe Uscate;70;1;0;359",
            "Nuci uscate (samburi);Fructe Uscate;10;13;48;654",
            "Pere uscate;Fructe Uscate;72;2;1;262",
            "Piersici uscate fara samburi;Fructe Uscate;69;3;1;244",
            "Prune uscate cu samburi;Fructe Uscate;71;3;1;245",
            "Smochine uscate;Fructe Uscate;58;4;1;249",
            "Stafide uscate;Fructe Uscate;71;2;0;306",
            "Afine-suc;Sucuri si nectaruri de fructe;15;1;0;46",
            "Grapefruit-suc;Sucuri si nectaruri de fructe;6;0;0;39",
            "Gutui-suc;Sucuri si nectaruri de fructe;14;0;0;43",
            "Lamai -suc;Sucuri si nectaruri de fructe;8;0;0;52",
            "Mere-suc;Sucuri si nectaruri de fructe;17;1;0;47",
            "Mure-suc;Sucuri si nectaruri de fructe;14;0;0;60",
            "Pepsi;Sucuri si nectaruri de fructe;11;0;0;42",
            "Pere-suc;Sucuri si nectaruri de fructe;12;0;0;57",
            "Portocale-suc;Sucuri si nectaruri de fructe;13;0;0;47",
            "Prune-suc;Sucuri si nectaruri de fructe;14;1;0;71",
            "Struguri-suc;Sucuri si nectaruri de fructe;20;1;0;72",
            "Zmeura-suc;Sucuri si nectaruri de fructe;13;1;0;28",
            "Nectar de caise sau piersici;Sucuri si nectaruri de fructe;17;1;0;54",
            "Nectar de gutui;Sucuri si nectaruri de fructe;10;0;0;45",
            "Nectar de visine;Sucuri si nectaruri de fructe;15;1;0;63",
            "Biscuiti;Cereale si derivatele lor;74;10;10;425",
            "Faina alba de grau;Cereale si derivatele lor;75;10;1;349",
            "Faina de porumb (malai);Cereale si derivatele lor;72;10;1;351",
            "Fidea cruda;Cereale si derivatele lor;80;10;0;350",
            "Fidea fiarta;Cereale si derivatele lor;20;2;0;331",
            "Gris crud;Cereale si derivatele lor;75;10;1;358",
            "Gris fiert;Cereale si derivatele lor;20;4;0;61",
            "Macaroane crude;Cereale si derivatele lor;75;10;0;379",
            "Macaroane fierte;Cereale si derivatele lor;20;3;0;158",
            "Mamaliga;Cereale si derivatele lor;15;2;0;70",
            "Orez decirtucat crud;Cereale si derivatele lor;75;8;0;354",
            "Orez fiert;Cereale si derivatele lor;20;3;0;130",
            "Paste fainoase cu ou;Cereale si derivatele lor;80;10;2;361",
            "Paine alba;Cereale si derivatele lor;54;10;2;247",
            "Paine intermediara;Cereale si derivatele lor;52;8;1;234",
            "Paine neagra;Cereale si derivatele lor;49;8;1;242",
            "Paine Graham;Cereale si derivatele lor;51;9;1;256",
            "Pesmet;Cereale si derivatele lor;73;10;10;422",
            "Porumb crud fiert;Cereale si derivatele lor;20;3;0;96",
            "Spaghete, taitei cruzi;Cereale si derivatele lor;75;10;0;386",
            "Spaghete, taitei fierti;Cereale si derivatele lor;20;3;0;158",
            "Grau;Cereale si derivatele lor;68;10;0;340",
            "Branza dulce de vaci din lapte degresat;Lapte si derivate;4;17;1;81",
            "Branza dulce de vaci din lapte integral;Lapte si derivate;4;17;9;98",
            "Branza telemea de oaie;Lapte si derivate;1;17;20;305",
            "Branza telemea de vaca;Lapte si derivate;1;17;17;155",
            "Branza topita \"Bucegi\";Lapte si derivate;1;17;36;366",
            "Branza de burduf;Lapte si derivate;1;28;28;369",
            "Branza topita pentru copii;Lapte si derivate;1;14;28;366",
            "Cas dulce;Lapte si derivate;6;15;14;254",
            "Cascaval;Lapte si derivate;1;23;25;233",
            "Frisca;Lapte si derivate;0;0;40;310",
            "Iaurt;Lapte si derivate;4;3;2;50",
            "Lapte de vaca integral;Lapte si derivate;5;4;4;65",
            "Lapte de vaca degresat;Lapte si derivate;4;3;2;40",
            "Lapte de bivolita;Lapte si derivate;5;6;7;116",
            "Lapte integral batut, de vaca;Lapte si derivate;4;4;4;63",
            "Lapte praf (din lapte normal);Lapte si derivate;40;27;20;498",
            "Smantana;Lapte si derivate;3;3;20;297",
            "Unt de masa;Lapte si derivate;2;8;80;721",
            "Urda;Lapte si derivate;6;18;4;136",
            "Carne de curca;Carne si preparate din carne;0;21;15;179",
            "Carne de gaina;Carne si preparate din carne;0;20;5;142",
            "Carne de gasca;Carne si preparate din carne;0;18;20;349",
            "Carne de miel;Carne si preparate din carne;0;18;20;260",
            "Carne de porc slaba;Carne si preparate din carne;0;20;6;142",
            "Carne de porc grasa;Carne si preparate din carne;0;15;35;340",
            "Carne de rata;Carne si preparate din carne;0;20;6;321",
            "Carne de vita;Carne si preparate din carne;0;20;3;150",
            "Carnati;Carne si preparate din carne;0;14;34;324",
            "Creier;Carne si preparate din carne;1;22;13;117",
            "Cremvusti, parizer;Carne si preparate din carne;0;10;27;290",
            "Ficat de pui prajit;Carne si preparate din carne;4;20;6;172",
            "Hamburgher;Carne si preparate din carne;31;11;8;546",
            "Muschi tiganesc;Carne si preparate din carne;0;26;26;333",
            "Pateu de ficat;Carne si preparate din carne;1;15;23;261",
            "Salamuri obisnuite;Carne si preparate din carne;0;19;21;336",
            "Salam de Sibiu;Carne si preparate din carne;0;26;43;480",
            "Sunca presata;Carne si preparate din carne;0;18;27;294",
            "Toba;Carne si preparate din carne;0;23;22;157",
            "Conserve din carne de porc in suc propiu;Carne si preparate din carne;0;14;29;180",
            "Conserve din carne de vita in suc propiu;Carne si preparate din carne;0;20;8;167",
            "Slanina afumata;Carne si preparate din carne;0;10;74;781",
            "Babusca;Peste;0;17;5;95",
            "Calcan;Peste;0;17;2;70",
            "Cod;Peste;0;19;1;87",
            "Crap;Peste;0;19;3;67",
            "Heringi;Peste;0;18;19;137",
            "Icre de crap;Peste;0;25;3;130",
            "Icre de stiuca;Peste;0;27;2;125",
            "Icre negre (caviar);Peste;0;26;15;246",
            "Macrou;Peste;0;22;10;183",
            "Morun;Peste;0;18;5;89",
            "Nisetru;Peste;0;19;17;237",
            "Pastrav;Peste;0;19;2;96",
            "Somn;Peste;0;21;27;224",
            "Salau,Stiuca;Peste;0;19;0;83",
            "Scrumbie;Peste;0;19;12;188",
            "Stavrid;Peste;0;21;3;114",
            "Un ou de gaina (50 g);Oua;0;6;5;171",
            "Galbenus de ou de gaina (18 g);Oua;0;4;6;321",
            "Albus de ou de gaina (27 g);Oua;0;3;0;51",
            "Praf de ou;Oua;2;45;40;578",
            "Margarina;Grasimi;0;0;80;764",
            "Smantana;Grasimi;3;3;20;297",
            "Ulei de floarea soarelui, soia, masline;Grasimi;0;0;100;930",
            "Unt;Grasimi;3;8;80;721",
            "Untura da porc;Grasimi;0;0;100;927",
            "Untura de gasca, seu;Grasimi;0;1;99;921",
            "Amidon;Zahar si dulciuri;83;0;0;346",
            "Bomboane cu ciocolata;Zahar si dulciuri;56;7;34;535",
            "Bomboane fondate;Zahar si dulciuri;79;3;9;544",
            "Cacao pulbere;Zahar si dulciuri;40;23;20;465",
            "Ciocolata amara(menaj);Zahar si dulciuri;61;7;28;497",
            "Ciocolata cu lapte;Zahar si dulciuri;50;7;30;605",
            "Caramele cu lapte;Zahar si dulciuri;96;0;0;394",
            "Caramele cu fructe;Zahar si dulciuri;92;0;0;480",
            "Dropsuri, drajeuri;Zahar si dulciuri;99;0;0;314",
            "Dulceata de nuci;Zahar si dulciuri;76;0;0;288",
            "Dulceata de trandafir;Zahar si dulciuri;80;0;0;278",
            "Gem de caise, prune;Zahar si dulciuri;73;1;0;267",
            "Gem de visine;Zahar si dulciuri;70;1;0;250",
            "Gem de piersici, zmeura, gutui;Zahar si dulciuri;75;1;0;295",
            "Gem de capsuni;Zahar si dulciuri;74;0;0;297",
            "Glucoza;Zahar si dulciuri;100;0;0;375",
            "Halva de floarea soarelui;Zahar si dulciuri;43;19;32;546",
            "Jeleu de afine;Zahar si dulciuri;76;1;0;242",
            "Jeleu de mure;Zahar si dulciuri;65;1;0;350",
            "Marmelada amestec;Zahar si dulciuri;73;1;0;246",
            "Magiun de prune;Zahar si dulciuri;55;2;0;276",
            "Martipan;Zahar si dulciuri;47;9;29;438",
            "Miere;Zahar si dulciuri;80;0;0;294",
            "Nuga;Zahar si dulciuri;53;9;35;575",
            "Praline;Zahar si dulciuri;73;3;15;484",
            "Rahat;Zahar si dulciuri;55;1;0;365",
            "Zahar;Zahar si dulciuri;100;0;0;410",
            "Gelatina uscata;Zahar si dulciuri;0;86;0;335"
        };

        public static ICollection<Aliment> Alimente
        {
            get => alimentList.Select((aliment, index) => {
                var details = aliment.Split(';');
                if (details.Length != 6)
                {
                    throw new Exception(aliment);
                }

                try
                {
                    return new Aliment
                    {
                        Nume = details[0],
                        Categorie = details[1],
                        Glucide = int.Parse(details[2]),
                        Proteine = int.Parse(details[3]),
                        Lipide = int.Parse(details[4]),
                        Calorii = int.Parse(details[5]),
                        AlimentID = index + 1
                    };
                }
                catch (Exception e)
                {
                    throw new Exception(aliment, e);
                }
            }).ToList();
        }
    }
}
