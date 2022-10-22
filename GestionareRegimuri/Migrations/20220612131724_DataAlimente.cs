using Microsoft.EntityFrameworkCore.Migrations;

namespace GestionareRegimuri.Migrations
{
    public partial class DataAlimente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Aliments",
                columns: new[] { "AlimentID", "Calorii", "Categorie", "Glucide", "Lipide", "Nume", "Proteine" },
                values: new object[,]
                {
                    { 1, 20, "Legume", 3, 0, "Andive", 2 },
                    { 159, 369, "Lapte si derivate", 1, 28, "Branza de burduf", 28 },
                    { 160, 366, "Lapte si derivate", 1, 28, "Branza topita pentru copii", 14 },
                    { 161, 254, "Lapte si derivate", 6, 14, "Cas dulce", 15 },
                    { 162, 233, "Lapte si derivate", 1, 25, "Cascaval", 23 },
                    { 163, 310, "Lapte si derivate", 0, 40, "Frisca", 0 },
                    { 164, 50, "Lapte si derivate", 4, 2, "Iaurt", 3 },
                    { 165, 65, "Lapte si derivate", 5, 4, "Lapte de vaca integral", 4 },
                    { 166, 40, "Lapte si derivate", 4, 2, "Lapte de vaca degresat", 3 },
                    { 167, 116, "Lapte si derivate", 5, 7, "Lapte de bivolita", 6 },
                    { 168, 63, "Lapte si derivate", 4, 4, "Lapte integral batut, de vaca", 4 },
                    { 169, 498, "Lapte si derivate", 40, 20, "Lapte praf (din lapte normal)", 27 },
                    { 170, 297, "Lapte si derivate", 3, 20, "Smantana", 3 },
                    { 171, 721, "Lapte si derivate", 2, 80, "Unt de masa", 8 },
                    { 172, 136, "Lapte si derivate", 6, 4, "Urda", 18 },
                    { 173, 179, "Carne si preparate din carne", 0, 15, "Carne de curca", 21 },
                    { 174, 142, "Carne si preparate din carne", 0, 5, "Carne de gaina", 20 },
                    { 175, 349, "Carne si preparate din carne", 0, 20, "Carne de gasca", 18 },
                    { 176, 260, "Carne si preparate din carne", 0, 20, "Carne de miel", 18 },
                    { 177, 142, "Carne si preparate din carne", 0, 6, "Carne de porc slaba", 20 },
                    { 178, 340, "Carne si preparate din carne", 0, 35, "Carne de porc grasa", 15 },
                    { 179, 321, "Carne si preparate din carne", 0, 6, "Carne de rata", 20 },
                    { 180, 150, "Carne si preparate din carne", 0, 3, "Carne de vita", 20 },
                    { 181, 324, "Carne si preparate din carne", 0, 34, "Carnati", 14 },
                    { 182, 117, "Carne si preparate din carne", 1, 13, "Creier", 22 },
                    { 183, 290, "Carne si preparate din carne", 0, 27, "Cremvusti, parizer", 10 },
                    { 184, 172, "Carne si preparate din carne", 4, 6, "Ficat de pui prajit", 20 },
                    { 185, 546, "Carne si preparate din carne", 31, 8, "Hamburgher", 11 },
                    { 158, 366, "Lapte si derivate", 1, 36, "Branza topita \"Bucegi\"", 17 },
                    { 186, 333, "Carne si preparate din carne", 0, 26, "Muschi tiganesc", 26 },
                    { 157, 155, "Lapte si derivate", 1, 17, "Branza telemea de vaca", 17 },
                    { 155, 98, "Lapte si derivate", 4, 9, "Branza dulce de vaci din lapte integral", 17 },
                    { 128, 28, "Sucuri si nectaruri de fructe", 13, 0, "Zmeura-suc", 1 },
                    { 129, 54, "Sucuri si nectaruri de fructe", 17, 0, "Nectar de caise sau piersici", 1 },
                    { 130, 45, "Sucuri si nectaruri de fructe", 10, 0, "Nectar de gutui", 0 },
                    { 131, 63, "Sucuri si nectaruri de fructe", 15, 0, "Nectar de visine", 1 },
                    { 132, 425, "Cereale si derivatele lor", 74, 10, "Biscuiti", 10 },
                    { 133, 349, "Cereale si derivatele lor", 75, 1, "Faina alba de grau", 10 },
                    { 134, 351, "Cereale si derivatele lor", 72, 1, "Faina de porumb (malai)", 10 },
                    { 135, 350, "Cereale si derivatele lor", 80, 0, "Fidea cruda", 10 },
                    { 136, 331, "Cereale si derivatele lor", 20, 0, "Fidea fiarta", 2 },
                    { 137, 358, "Cereale si derivatele lor", 75, 1, "Gris crud", 10 }
                });

            migrationBuilder.InsertData(
                table: "Aliments",
                columns: new[] { "AlimentID", "Calorii", "Categorie", "Glucide", "Lipide", "Nume", "Proteine" },
                values: new object[,]
                {
                    { 138, 61, "Cereale si derivatele lor", 20, 0, "Gris fiert", 4 },
                    { 139, 379, "Cereale si derivatele lor", 75, 0, "Macaroane crude", 10 },
                    { 140, 158, "Cereale si derivatele lor", 20, 0, "Macaroane fierte", 3 },
                    { 141, 70, "Cereale si derivatele lor", 15, 0, "Mamaliga", 2 },
                    { 142, 354, "Cereale si derivatele lor", 75, 0, "Orez decirtucat crud", 8 },
                    { 143, 130, "Cereale si derivatele lor", 20, 0, "Orez fiert", 3 },
                    { 144, 361, "Cereale si derivatele lor", 80, 2, "Paste fainoase cu ou", 10 },
                    { 145, 247, "Cereale si derivatele lor", 54, 2, "Paine alba", 10 },
                    { 146, 234, "Cereale si derivatele lor", 52, 1, "Paine intermediara", 8 },
                    { 147, 242, "Cereale si derivatele lor", 49, 1, "Paine neagra", 8 },
                    { 148, 256, "Cereale si derivatele lor", 51, 1, "Paine Graham", 9 },
                    { 149, 422, "Cereale si derivatele lor", 73, 10, "Pesmet", 10 },
                    { 150, 96, "Cereale si derivatele lor", 20, 0, "Porumb crud fiert", 3 },
                    { 151, 386, "Cereale si derivatele lor", 75, 0, "Spaghete, taitei cruzi", 10 },
                    { 152, 158, "Cereale si derivatele lor", 20, 0, "Spaghete, taitei fierti", 3 },
                    { 153, 340, "Cereale si derivatele lor", 68, 0, "Grau", 10 },
                    { 154, 81, "Lapte si derivate", 4, 1, "Branza dulce de vaci din lapte degresat", 17 },
                    { 156, 305, "Lapte si derivate", 1, 20, "Branza telemea de oaie", 17 },
                    { 187, 261, "Carne si preparate din carne", 1, 23, "Pateu de ficat", 15 },
                    { 188, 336, "Carne si preparate din carne", 0, 21, "Salamuri obisnuite", 19 },
                    { 189, 480, "Carne si preparate din carne", 0, 43, "Salam de Sibiu", 26 },
                    { 222, 535, "Zahar si dulciuri", 56, 34, "Bomboane cu ciocolata", 7 },
                    { 223, 544, "Zahar si dulciuri", 79, 9, "Bomboane fondate", 3 },
                    { 224, 465, "Zahar si dulciuri", 40, 20, "Cacao pulbere", 23 },
                    { 225, 497, "Zahar si dulciuri", 61, 28, "Ciocolata amara(menaj)", 7 },
                    { 226, 605, "Zahar si dulciuri", 50, 30, "Ciocolata cu lapte", 7 },
                    { 227, 394, "Zahar si dulciuri", 96, 0, "Caramele cu lapte", 0 },
                    { 228, 480, "Zahar si dulciuri", 92, 0, "Caramele cu fructe", 0 },
                    { 229, 314, "Zahar si dulciuri", 99, 0, "Dropsuri, drajeuri", 0 },
                    { 230, 288, "Zahar si dulciuri", 76, 0, "Dulceata de nuci", 0 },
                    { 231, 278, "Zahar si dulciuri", 80, 0, "Dulceata de trandafir", 0 },
                    { 232, 267, "Zahar si dulciuri", 73, 0, "Gem de caise, prune", 1 },
                    { 233, 250, "Zahar si dulciuri", 70, 0, "Gem de visine", 1 },
                    { 234, 295, "Zahar si dulciuri", 75, 0, "Gem de piersici, zmeura, gutui", 1 },
                    { 235, 297, "Zahar si dulciuri", 74, 0, "Gem de capsuni", 0 },
                    { 236, 375, "Zahar si dulciuri", 100, 0, "Glucoza", 0 },
                    { 237, 546, "Zahar si dulciuri", 43, 32, "Halva de floarea soarelui", 19 },
                    { 238, 242, "Zahar si dulciuri", 76, 0, "Jeleu de afine", 1 },
                    { 239, 350, "Zahar si dulciuri", 65, 0, "Jeleu de mure", 1 },
                    { 240, 246, "Zahar si dulciuri", 73, 0, "Marmelada amestec", 1 },
                    { 241, 276, "Zahar si dulciuri", 55, 0, "Magiun de prune", 2 },
                    { 242, 438, "Zahar si dulciuri", 47, 29, "Martipan", 9 }
                });

            migrationBuilder.InsertData(
                table: "Aliments",
                columns: new[] { "AlimentID", "Calorii", "Categorie", "Glucide", "Lipide", "Nume", "Proteine" },
                values: new object[,]
                {
                    { 243, 294, "Zahar si dulciuri", 80, 0, "Miere", 0 },
                    { 244, 575, "Zahar si dulciuri", 53, 35, "Nuga", 9 },
                    { 245, 484, "Zahar si dulciuri", 73, 15, "Praline", 3 },
                    { 246, 365, "Zahar si dulciuri", 55, 0, "Rahat", 1 },
                    { 247, 410, "Zahar si dulciuri", 100, 0, "Zahar", 0 },
                    { 248, 335, "Zahar si dulciuri", 0, 0, "Gelatina uscata", 86 },
                    { 221, 346, "Zahar si dulciuri", 83, 0, "Amidon", 0 },
                    { 220, 921, "Grasimi", 0, 99, "Untura de gasca, seu", 1 },
                    { 219, 927, "Grasimi", 0, 100, "Untura da porc", 0 },
                    { 218, 721, "Grasimi", 3, 80, "Unt", 8 },
                    { 190, 294, "Carne si preparate din carne", 0, 27, "Sunca presata", 18 },
                    { 191, 157, "Carne si preparate din carne", 0, 22, "Toba", 23 },
                    { 192, 180, "Carne si preparate din carne", 0, 29, "Conserve din carne de porc in suc propiu", 14 },
                    { 193, 167, "Carne si preparate din carne", 0, 8, "Conserve din carne de vita in suc propiu", 20 },
                    { 194, 781, "Carne si preparate din carne", 0, 74, "Slanina afumata", 10 },
                    { 195, 95, "Peste", 0, 5, "Babusca", 17 },
                    { 196, 70, "Peste", 0, 2, "Calcan", 17 },
                    { 197, 87, "Peste", 0, 1, "Cod", 19 },
                    { 198, 67, "Peste", 0, 3, "Crap", 19 },
                    { 199, 137, "Peste", 0, 19, "Heringi", 18 },
                    { 200, 130, "Peste", 0, 3, "Icre de crap", 25 },
                    { 201, 125, "Peste", 0, 2, "Icre de stiuca", 27 },
                    { 202, 246, "Peste", 0, 15, "Icre negre (caviar)", 26 },
                    { 127, 72, "Sucuri si nectaruri de fructe", 20, 0, "Struguri-suc", 1 },
                    { 203, 183, "Peste", 0, 10, "Macrou", 22 },
                    { 205, 237, "Peste", 0, 17, "Nisetru", 19 },
                    { 206, 96, "Peste", 0, 2, "Pastrav", 19 },
                    { 207, 224, "Peste", 0, 27, "Somn", 21 },
                    { 208, 83, "Peste", 0, 0, "Salau,Stiuca", 19 },
                    { 209, 188, "Peste", 0, 12, "Scrumbie", 19 },
                    { 210, 114, "Peste", 0, 3, "Stavrid", 21 },
                    { 211, 171, "Oua", 0, 5, "Un ou de gaina (50 g)", 6 },
                    { 212, 321, "Oua", 0, 6, "Galbenus de ou de gaina (18 g)", 4 },
                    { 213, 51, "Oua", 0, 0, "Albus de ou de gaina (27 g)", 3 },
                    { 214, 578, "Oua", 2, 40, "Praf de ou", 45 },
                    { 215, 764, "Grasimi", 0, 80, "Margarina", 0 },
                    { 216, 297, "Grasimi", 3, 20, "Smantana", 3 },
                    { 217, 930, "Grasimi", 0, 100, "Ulei de floarea soarelui, soia, masline", 0 },
                    { 204, 89, "Peste", 0, 5, "Morun", 18 },
                    { 125, 47, "Sucuri si nectaruri de fructe", 13, 0, "Portocale-suc", 0 },
                    { 126, 71, "Sucuri si nectaruri de fructe", 14, 0, "Prune-suc", 1 },
                    { 62, 94, "Fructe Proaspete", 18, 0, "Banane fara coaja", 1 }
                });

            migrationBuilder.InsertData(
                table: "Aliments",
                columns: new[] { "AlimentID", "Calorii", "Categorie", "Glucide", "Lipide", "Nume", "Proteine" },
                values: new object[,]
                {
                    { 34, 45, "Legume", 9, 0, "Morcovi cruzi", 2 },
                    { 35, 44, "Legume", 9, 0, "Papadie", 3 },
                    { 36, 72, "Legume", 15, 0, "Pastarnac", 1 },
                    { 37, 50, "Legume", 7, 1, "Patrunjel (frunze)", 4 },
                    { 38, 20, "Legume", 10, 1, "Patrunjel radacina", 1 },
                    { 39, 54, "Legume", 10, 0, "Praz crud", 2 },
                    { 40, 26, "Legume", 5, 0, "Ridichi de iarna", 1 },
                    { 41, 19, "Legume", 4, 0, "Ridichi de luna", 1 },
                    { 42, 30, "Legume", 12, 0, "Rosii bulion", 4 },
                    { 43, 85, "Legume", 18, 0, "Rosii pasta", 5 },
                    { 44, 20, "Legume", 4, 0, "Rosii proaspete", 1 },
                    { 45, 22, "Legume", 3, 0, "Salata verde", 1 },
                    { 46, 43, "Legume", 9, 0, "Sfecla rosie", 1 },
                    { 47, 25, "Legume", 2, 0, "Spanac crud", 4 },
                    { 48, 21, "Legume", 3, 0, "Sparanghel", 2 },
                    { 49, 22, "Legume", 0, 0, "Stevie", 5 },
                    { 50, 30, "Legume", 5, 0, "Suc de rosii", 1 },
                    { 51, 33, "Legume", 6, 0, "Telina (radacina)", 1 },
                    { 52, 68, "Legume", 7, 0, "Urzici", 8 },
                    { 53, 137, "Legume", 26, 0, "Usturoi", 7 },
                    { 54, 33, "Legume", 5, 0, "Varza alba cruda, varza creata", 0 },
                    { 55, 50, "Legume", 7, 1, "Varza de Bruxelles", 4 },
                    { 56, 33, "Legume", 6, 0, "Varza rosie cruda", 2 },
                    { 57, 27, "Legume", 5, 0, "Vinete crude", 1 },
                    { 58, 61, "Fructe Proaspete", 15, 0, "Afine", 1 },
                    { 59, 44, "Fructe Proaspete", 9, 0, "Agrise", 1 },
                    { 60, 52, "Fructe Proaspete", 12, 0, "Ananas", 0 },
                    { 33, 48, "Legume", 8, 0, "Mazare verde conservata", 2 },
                    { 61, 590, "Fructe Proaspete", 19, 34, "Arahide (alune)", 9 },
                    { 32, 96, "Legume", 14, 0, "Mazare verde boabe", 8 },
                    { 30, 43, "Legume", 6, 0, "Marar (frunze)", 2 },
                    { 3, 39, "Legume", 7, 0, "Ardei gras rosu", 1 },
                    { 4, 17, "Legume", 5, 0, "Ardei gras verde", 1 },
                    { 5, 87, "Legume", 20, 0, "Cartofi fierti", 1 },
                    { 6, 88, "Legume", 20, 0, "Cartofi maturi", 1 },
                    { 7, 80, "Legume", 17, 0, "Cartofi noi", 1 },
                    { 8, 93, "Legume", 22, 0, "Cartofi copti", 1 },
                    { 9, 312, "Legume", 44, 0, "Cartofi prajiti", 2 },
                    { 10, 19, "Legume", 3, 0, "Castraveti", 1 },
                    { 11, 40, "Legume", 10, 0, "Ceapa uscata", 2 },
                    { 12, 20, "Legume", 8, 0, "Ceapa verde", 1 },
                    { 13, 35, "Legume", 3, 1, "Ciuperci", 1 }
                });

            migrationBuilder.InsertData(
                table: "Aliments",
                columns: new[] { "AlimentID", "Calorii", "Categorie", "Glucide", "Lipide", "Nume", "Proteine" },
                values: new object[,]
                {
                    { 14, 30, "Legume", 4, 0, "Conopida", 3 },
                    { 15, 20, "Legume", 2, 0, "Conopida conservata (sterilizata) in apa", 1 },
                    { 16, 23, "Legume", 2, 0, "Conopida fiarta", 2 },
                    { 17, 20, "Legume", 12, 0, "Dovleac copt", 1 },
                    { 18, 18, "Legume", 3, 0, "Dovlecei", 0 },
                    { 19, 16, "Legume", 3, 1, "Dovlecei in apa(sterilizat)", 2 },
                    { 20, 303, "Legume", 47, 2, "Fasole boabe", 23 },
                    { 21, 20, "Legume", 2, 0, "Fasole verde conservata", 1 },
                    { 22, 33, "Legume", 5, 0, "Fasole verde pastai cruda", 2 },
                    { 23, 20, "Legume", 7, 0, "Gogosari", 2 },
                    { 24, 30, "Legume", 6, 0, "Gulii crude", 2 },
                    { 25, 67, "Legume", 20, 0, "Hrean", 2 },
                    { 26, 34, "Legume", 5, 5, "Hribi", 0 },
                    { 27, 339, "Legume", 50, 2, "Linte uscata", 25 },
                    { 28, 19, "Legume", 1, 0, "Loboda", 3 },
                    { 29, 24, "Legume", 2, 0, "Macris", 0 },
                    { 31, 354, "Legume", 53, 2, "Mazare uscata boabe", 22 },
                    { 124, 57, "Sucuri si nectaruri de fructe", 12, 0, "Pere-suc", 0 },
                    { 63, 51, "Fructe Proaspete", 15, 0, "Caise fara sambure", 1 },
                    { 64, 37, "Fructe Proaspete", 8, 1, "Capsuni", 1 },
                    { 97, 110, "Fructe Proaspete", 20, 0, "Prune fara samburi", 0 },
                    { 98, 92, "Fructe Proaspete", 15, 0, "Renglote", 0 },
                    { 99, 83, "Fructe Proaspete", 14, 1, "Rodie", 1 },
                    { 100, 267, "Fructe Proaspete", 16, 0, "Smochine proaspete", 0 },
                    { 101, 93, "Fructe Proaspete", 20, 0, "Struguri", 0 },
                    { 102, 27, "Fructe Proaspete", 15, 1, "Visine", 1 },
                    { 103, 66, "Fructe Proaspete", 16, 1, "Zmeura", 1 },
                    { 104, 241, "Fructe Uscate", 68, 0, "Caise uscate fara samburi", 5 },
                    { 105, 319, "Fructe Uscate", 74, 1, "Curmale uscate cu samburi", 2 },
                    { 106, 298, "Fructe Uscate", 83, 0, "Curmale uscate fara samburi", 2 },
                    { 107, 287, "Fructe Uscate", 4, 14, "Cafea prajita", 14 },
                    { 108, 245, "Fructe Uscate", 70, 7, "Castane", 11 },
                    { 109, 162, "Fructe Uscate", 62, 1, "Macese uscate cu seminte", 2 },
                    { 110, 359, "Fructe Uscate", 70, 0, "Mere uscate (poame)", 1 },
                    { 111, 654, "Fructe Uscate", 10, 48, "Nuci uscate (samburi)", 13 },
                    { 112, 262, "Fructe Uscate", 72, 1, "Pere uscate", 2 },
                    { 113, 244, "Fructe Uscate", 69, 1, "Piersici uscate fara samburi", 3 },
                    { 114, 245, "Fructe Uscate", 71, 1, "Prune uscate cu samburi", 3 },
                    { 115, 249, "Fructe Uscate", 58, 1, "Smochine uscate", 4 },
                    { 116, 306, "Fructe Uscate", 71, 0, "Stafide uscate", 2 },
                    { 117, 46, "Sucuri si nectaruri de fructe", 15, 0, "Afine-suc", 1 },
                    { 118, 39, "Sucuri si nectaruri de fructe", 6, 0, "Grapefruit-suc", 0 }
                });

            migrationBuilder.InsertData(
                table: "Aliments",
                columns: new[] { "AlimentID", "Calorii", "Categorie", "Glucide", "Lipide", "Nume", "Proteine" },
                values: new object[,]
                {
                    { 119, 43, "Sucuri si nectaruri de fructe", 14, 0, "Gutui-suc", 0 },
                    { 120, 52, "Sucuri si nectaruri de fructe", 8, 0, "Lamai -suc", 0 },
                    { 121, 47, "Sucuri si nectaruri de fructe", 17, 0, "Mere-suc", 1 },
                    { 122, 60, "Sucuri si nectaruri de fructe", 14, 0, "Mure-suc", 0 },
                    { 123, 42, "Sucuri si nectaruri de fructe", 11, 0, "Pepsi", 0 },
                    { 96, 89, "Fructe Proaspete", 14, 0, "Prune cu samburi", 0 },
                    { 95, 47, "Fructe Proaspete", 10, 0, "Portocale fara coaja", 0 },
                    { 94, 47, "Fructe Proaspete", 15, 0, "Piersici", 1 },
                    { 93, 79, "Fructe Proaspete", 15, 0, "Pere", 1 },
                    { 65, 21, "Fructe Proaspete", 15, 0, "Cirese de iunie", 1 },
                    { 66, 21, "Fructe Proaspete", 10, 0, "Cirese de mai", 1 },
                    { 67, 58, "Fructe Proaspete", 13, 1, "Coacaze negre", 1 },
                    { 68, 62, "Fructe Proaspete", 10, 1, "Coacaze rosii", 2 },
                    { 69, 76, "Fructe Proaspete", 17, 0, "Coarne", 1 },
                    { 70, 45, "Fructe Proaspete", 10, 0, "Corcoduse", 1 },
                    { 71, 81, "Fructe Proaspete", 14, 1, "Dude", 1 },
                    { 72, 570, "Fructe Proaspete", 15, 32, "Floarea soarelui (seminte)", 15 },
                    { 73, 32, "Fructe Proaspete", 10, 1, "Fragi de padure", 1 },
                    { 74, 30, "Fructe Proaspete", 4, 0, "Grapefruit", 0 },
                    { 75, 52, "Fructe Proaspete", 14, 1, "Gutui", 1 },
                    { 76, 127, "Fructe Proaspete", 20, 0, "Kaki", 1 },
                    { 77, 61, "Fructe Proaspete", 5, 0, "Kiwi", 0 },
                    { 2, 47, "Legume", 8, 0, "Anghinare", 2 },
                    { 78, 36, "Fructe Proaspete", 6, 1, "Lamai cu coaja", 1 },
                    { 80, 117, "Fructe Proaspete", 22, 1, "Macese (partea carnoasa)", 5 },
                    { 81, 40, "Fructe Proaspete", 10, 0, "Mandarine fara coaja", 1 },
                    { 82, 60, "Fructe Proaspete", 17, 0, "Mango", 1 },
                    { 83, 437, "Fructe Proaspete", 7, 35, "Masline cu sambure", 2 },
                    { 84, 50, "Fructe Proaspete", 10, 0, "Mere cretesti", 0 },
                    { 85, 67, "Fructe Proaspete", 15, 0, "Mere ionatane", 0 },
                    { 86, 43, "Fructe Proaspete", 15, 0, "Mure", 0 },
                    { 87, 44, "Fructe Proaspete", 14, 0, "Nectarine", 1 },
                    { 88, 757, "Fructe Proaspete", 10, 48, "Nuci verzi fara coaja (samburi)", 13 },
                    { 89, 45, "Fructe Proaspete", 5, 0, "Pepene galben cu coaja", 0 },
                    { 90, 54, "Fructe Proaspete", 10, 0, "Pepene galben fara coaja", 0 },
                    { 91, 20, "Fructe Proaspete", 4, 0, "Pepene verde cu coaja", 0 },
                    { 92, 28, "Fructe Proaspete", 6, 0, "Pepene verde fara coaja", 1 },
                    { 79, 525, "Fructe Proaspete", 19, 40, "Mac", 19 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "f0a28ce8-79b9-4e43-88ee-928272b47e4f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "1b4aed27-be2a-416f-a1b5-5bffe41e1288");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "6fcb9398-4d14-4a96-8c42-c214d967d6f8");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Aliments",
                keyColumn: "AlimentID",
                keyValue: 248);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "9785938f-e7c8-4263-9c73-a82b995f15b9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "df38483a-38df-4b34-84e9-91ff8c6552fa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "efed414a-6786-4795-a444-148de15cac81");
        }
    }
}
