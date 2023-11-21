DROP DATABASE IF EXISTS magasins;
CREATE DATABASE IF NOT EXISTS magasins;
USE magasins;

DROP TABLE IF EXISTS clients;
CREATE TABLE IF NOT EXISTS clients(
id_client INTEGER PRIMARY KEY,
nom VARCHAR(150) NOT NULL,
prenom VARCHAR(150) NOT NULL,
numPhone VARCHAR(10) NOT NULL ,
courriel VARCHAR(150) NOT NULL UNIQUE,
mdp VARCHAR(20) NOT NULL,
adresse_facturation VARCHAR(150) NOT NULL,
id_carte VARCHAR(16) NOT NULL,
statut_fidelite VARCHAR(150));

DROP TABLE IF EXISTS magasin;
CREATE TABLE IF NOT EXISTS magasin(
id_magasin INTEGER PRIMARY KEY,
nom VARCHAR(50));

DROP TABLE IF EXISTS fleur;
CREATE TABLE IF NOT EXISTS fleur(
id_fleur VARCHAR(50) PRIMARY KEY,
prix DECIMAL(10.2),
disponibilite VARCHAR(150));



DROP TABLE IF EXISTS accessoir;
CREATE TABLE IF NOT EXISTS accessoir(
id_accessoir VARCHAR(50) PRIMARY KEY,
prix DECIMAL(10.2));

DROP TABLE IF EXISTS stock;
CREATE TABLE IF NOT EXISTS stock(
id_stock INTEGER PRIMARY KEY,
id_fleur VARCHAR(50),
id_magasin INTEGER,
quantite_disponible INTEGER,
FOREIGN KEY (id_fleur) REFERENCES fleur(id_fleur),
FOREIGN KEY (id_magasin) REFERENCES magasin(id_magasin));

DROP TABLE IF EXISTS bouquet;
CREATE TABLE IF NOT EXISTS bouquet
(
id_bouquet INTEGER PRIMARY KEY,
nom VARCHAR(40),  -- nom donné au bouquet 
categorie VARCHAR (150), -- bouquet Personnalisé/Standar
prix_bouquet DECIMAL(10.2),
composition VARCHAR(150)); -- Description du bouquet 


DROP TABLE IF EXISTS commande;
CREATE TABLE IF NOT EXISTS commande(
id_commande INTEGER PRIMARY KEY,
date_livraison DATE,
date_commande DATE,
id_bouquet INTEGER,
id_magasin INTEGER,
id_client INTEGER,
code_etat VARCHAR(150), 
FOREIGN KEY (id_bouquet) REFERENCES bouquet(id_bouquet),
FOREIGN KEY (id_client) REFERENCES clients(id_client),
FOREIGN KEY (id_magasin) REFERENCES magasin(id_magasin));



INSERT INTO `magasins`.`clients` (id_client, nom, prenom, numPhone, courriel, mdp, adresse_facturation, id_carte, statut_fidelite) VALUES (1, 'Doe', 'John', '1234567890', 'john.doe@example.com', 'mypassword1', '123 Main St', '1234567890123456', 'Bronze');
INSERT INTO  `magasins`.`clients` (id_client, nom, prenom, numPhone, courriel, mdp, adresse_facturation, id_carte, statut_fidelite)VALUES (2, 'Smith', 'Jane', '9876543210', 'jane.smith@example.com', 'mypassword2', '456 Oak St', '2345678901234567', 'Silver');
INSERT INTO  `magasins`.`clients` (id_client, nom, prenom, numPhone, courriel, mdp, adresse_facturation, id_carte, statut_fidelite)VALUES (3, 'Brown', 'Michael', '4567890123', 'michael.brown@example.com', 'mypassword3', '789 Maple Ave', '3456789012345678', 'Gold');
INSERT INTO  `magasins`.`clients` (id_client, nom, prenom, numPhone, courriel, mdp, adresse_facturation, id_carte, statut_fidelite)VALUES (4, 'Johnson', 'Sarah', '7890123456', 'sarah.johnson@example.com', 'mypassword4', '567 Pine St', '4567890123456789', 'Bronze');
INSERT INTO  `magasins`.`clients` (id_client, nom, prenom, numPhone, courriel, mdp, adresse_facturation, id_carte, statut_fidelite)VALUES (5, 'Lee', 'David', '2345678901', 'david.lee@example.com', 'mypassword5', '890 Cedar Rd', '5678901234787890', 'Silver');
INSERT INTO  `magasins`.`clients` (id_client, nom, prenom, numPhone, courriel, mdp, adresse_facturation, id_carte, statut_fidelite)VALUES (6, 'Chen', 'Sophia', '8901234567', 'sophia.chen@example.com', 'mypassword6', '123 Birch Ln', '6789057345678901', 'Gold');
INSERT INTO  `magasins`.`clients` (id_client, nom, prenom, numPhone, courriel, mdp, adresse_facturation, id_carte, statut_fidelite)VALUES (7, 'Garcia', 'Carlos', '3456789012', 'carlos.garcia@example.com', 'mypassword7', '456 Elm St', '1234567897123456', 'Bronze');
INSERT INTO  `magasins`.`clients` (id_client, nom, prenom, numPhone, courriel, mdp, adresse_facturation, id_carte, statut_fidelite) VALUES (8, 'tom', 'ben', '0123456789', 'tom.wang@example.com', 'mypassword8', '780 Oak Rd', '1234567878123456', 'Bronze');
INSERT INTO  `magasins`.`clients` (id_client, nom, prenom, numPhone, courriel, mdp, adresse_facturation, id_carte, statut_fidelite) VALUES (9, 'lola', 'coka', '0123412789', 'lola.wang@example.com', 'mypassword9', '789 dab Rd', '8901212567890123', 'bonze');
INSERT INTO  `magasins`.`clients` (id_client, nom, prenom, numPhone, courriel, mdp, adresse_facturation, id_carte, statut_fidelite) VALUES (10, 'lili', 'bernard', '0893456789', 'lili.wang@example.com', 'mypassword10', '78 bin Rd', '8996234567890123', 'Gold');
INSERT INTO  `magasins`.`clients` (id_client, nom, prenom, numPhone, courriel, mdp, adresse_facturation, id_carte, statut_fidelite) VALUES (11, 'juliette', 'opina', '7890123457', 'juliette.wang@example.com', 'mypasswor11', '89 Oaik Roundd', '1234567890123457', 'Silver');
INSERT INTO  `magasins`.`clients` (id_client, nom, prenom, numPhone, courriel, mdp, adresse_facturation, id_carte, statut_fidelite) VALUES (12, 'pierre', 'jul', '0123456770', 'pierre.wang@example.com', 'mypassword12', '7 obama Rd', '8901245567890123', 'Silver');
INSERT INTO `magasins`.`clients` (id_client, nom, prenom, numPhone, courriel, mdp, adresse_facturation, id_carte, statut_fidelite) VALUES (13, 'Dupont', 'Sophie', '0123456789', 'sophie.dupont@example.com', 'mypassword13', '10 rue des Fleurs', '9876543210123456', 'Bronze');
INSERT INTO `magasins`.`clients` (id_client, nom, prenom, numPhone, courriel, mdp, adresse_facturation, id_carte, statut_fidelite) VALUES (14, 'Martin', 'Jean', '0987654321', 'jean.martin@example.com', 'mypassword14', '22 avenue des Champs-Élysées', '1234567890987654', 'Bronze');
INSERT INTO `magasins`.`clients` (id_client, nom, prenom, numPhone, courriel, mdp, adresse_facturation, id_carte, statut_fidelite) VALUES (15, 'Lavoie', 'Isabelle', '0765432109', 'isabelle.lavoie@example.com', 'mypassword15', '5 rue des Érables', '4567890123456789', 'Argent');
INSERT INTO `magasins`.`clients` (id_client, nom, prenom, numPhone, courriel, mdp, adresse_facturation, id_carte, statut_fidelite) VALUES (16, 'Tremblay', 'Patrick', '0345678901', 'patrick.tremblay@example.com', 'mypassword16', '15 boulevard de la Mer', '7890123456789012', 'Bronze');
INSERT INTO `magasins`.`clients` (id_client, nom, prenom, numPhone, courriel, mdp, adresse_facturation, id_carte, statut_fidelite) VALUES (17, 'Gagné', 'Marie', '0567890123', 'marie.gagne@example.com', 'mypassword17', '8 avenue du Soleil', '2345678901234567', 'Bronze');
INSERT INTO `magasins`.`clients` (id_client, nom, prenom, numPhone, courriel, mdp, adresse_facturation, id_carte, statut_fidelite) VALUES (18, 'Roy', 'Alexandre', '0678901234', 'alexandre.roy@example.com', 'mypassword18', '12 rue des Lilas', '6789012345678901', 'Silver');
INSERT INTO `magasins`.`clients` (id_client, nom, prenom, numPhone, courriel, mdp, adresse_facturation, id_carte, statut_fidelite) VALUES (19, 'Bergeron', 'Sophia', '0456789012', 'sophia.bergeron@example.com', 'mypassword19', '6 boulevard des Roses', '1234567890123456', 'Bronze');
INSERT INTO `magasins`.`clients` (id_client, nom, prenom, numPhone, courriel, mdp, adresse_facturation, id_carte, statut_fidelite) VALUES (20, 'Lefebvre', 'Thomas', '0234567890', 'thomas.lefebvre@example.com', 'mypassword20', '9 avenue des Tulipes', '4567890123456789', 'Silver');
INSERT INTO `magasins`.`clients` (id_client, nom, prenom, numPhone, courriel, mdp, adresse_facturation, id_carte, statut_fidelite) VALUES (21, 'Dionne', 'Marie-Pierre', '0789012345', 'marie-pierre.dionne@example.com', 'mypassword21', '18 rue des Marguerites', '7890123456789012', 'Bronze');
INSERT INTO `magasins`.`clients` (id_client, nom, prenom, numPhone, courriel, mdp, adresse_facturation, id_carte, statut_fidelite) VALUES (22, 'Poirier', 'Éric', '0890123456', 'eric.poirier@example.com', 'mypassword22', '25 boulevard des Violettes', '2345678901234567', 'Or');
INSERT INTO `magasins`.`clients` (id_client, nom, prenom, numPhone, courriel, mdp, adresse_facturation, id_carte, statut_fidelite) VALUES (23, 'Paupe', 'Romain', '0890423456', 'aa', 'aa', '25 boulevard des rouges', '2345679991234567', 'Or');


select * from clients;

INSERT INTO `magasins`.`magasin` VALUES(1, 'La maison');
INSERT INTO `magasins`.`magasin` VALUES(2, 'Mon Fleuriste');
INSERT INTO `magasins`.`magasin` VALUES(3, 'Le jardin des fleurs');
INSERT INTO `magasins`.`magasin` VALUES(4, 'Flore et sens');
INSERT INTO `magasins`.`magasin` VALUES(5, 'Pimprenelle');


select * from magasin; 

INSERT INTO `magasins`.`fleur` VALUES ('Rose', 10,'mai');
INSERT INTO `magasins`.`fleur`VALUES ('Tulipe', 8,'mai');
INSERT INTO `magasins`.`fleur`VALUES ('Lys', 12,'novembre');
INSERT INTO `magasins`.`fleur`VALUES ('Marguerite', 5,'mai');
INSERT INTO `magasins`.`fleur`VALUES ('Orchidée' , 25,'mars');
INSERT INTO `magasins`.`fleur`VALUES ('Pivoine' , 18,'novembre');
INSERT INTO `magasins`.`fleur`VALUES ('Jonquille', 4,'decmbre');
INSERT INTO `magasins`.`fleur`VALUES ('Œillet', 6,'juin');
INSERT INTO `magasins`.`fleur`VALUES ('Iris' ,9,'juillet');
INSERT INTO `magasins`.`fleur`VALUES ('Bleuet' , 3,'janvier');
INSERT INTO `magasins`.`fleur`VALUES ('Dahlia' , 14,'juillet');
INSERT INTO `magasins`.`fleur`VALUES ('Jacinthe', 7, 'année');
INSERT INTO `magasins`.`fleur`VALUES ('Coquelicot', 2,'mai');
INSERT INTO `magasins`.`fleur`VALUES ('Camélia', 11,'decembre');
INSERT INTO `magasins`.`fleur`VALUES ('Tournesol', 6,'aout');
INSERT INTO `magasins`.`fleur`VALUES ('Lavande', 8,'janvier');
INSERT INTO `magasins`.`fleur`VALUES ('Lilas', 10,'mai');
INSERT INTO `magasins`.`fleur`VALUES ('Chrysanthème', 5,'jamais');
INSERT INTO `magasins`.`fleur`VALUES ('Primevère', 3,'janvier');
INSERT INTO `magasins`.`fleur`VALUES ('Souci',  4,'aout');

select * from fleur;

INSERT INTO `magasins`.`accessoir` VALUES ('Vase bleu', 15);
INSERT INTO `magasins`.`accessoir` VALUES ('Vase rouge', 15);
INSERT INTO `magasins`.`accessoir` VALUES ('Vase trompette', 30);
INSERT INTO `magasins`.`accessoir` VALUES ('Ruban', 4);
INSERT INTO `magasins`.`accessoir` VALUES ('Epingle a fleur', 8);
INSERT INTO `magasins`.`accessoir` VALUES ('Grands pot', 17);
INSERT INTO `magasins`.`accessoir` VALUES ('Vaporisateur', 10);
INSERT INTO `magasins`.`accessoir` VALUES ('Ruban floral', 5);
INSERT INTO `magasins`.`accessoir` VALUES('Cache-pot en céramique', 3);
INSERT INTO `magasins`.`accessoir` VALUES('Pince à fleurs', 12);
INSERT INTO `magasins`.`accessoir` VALUES('Emballage cadeau', 20);
INSERT INTO `magasins`.`accessoir` VALUES('Tuteur en métal', 8);
INSERT INTO `magasins`.`accessoir` VALUES('Vase en verre soufflé', 6);
INSERT INTO `magasins`.`accessoir` VALUES('Mousse florale', 15);
INSERT INTO `magasins`.`accessoir` VALUES('Ciseaux de fleuriste', 10);
INSERT INTO `magasins`.`accessoir` VALUES('Ruban adhésif floral', 7);
INSERT INTO `magasins`.`accessoir` VALUES('Colle pour fleurs', 4);

select * from accessoir;

INSERT INTO `magasins`.`stock` VALUES (1, 'Rose', 1, 200);
INSERT INTO `magasins`.`stock` VALUES (2, 'Rose', 2, 0);
INSERT INTO `magasins`.`stock` VALUES (3, 'Rose', 3, 23);
INSERT INTO `magasins`.`stock` VALUES (4,'Rose', 4, 345);
INSERT INTO `magasins`.`stock` VALUES (5,'Rose', 5, 45);
INSERT INTO `magasins`.`stock` VALUES (6,'Tulipe', 1, 35);
INSERT INTO `magasins`.`stock` VALUES (7,'Tulipe', 2, 455);
INSERT INTO `magasins`.`stock` VALUES (8,'Tulipe', 3, 75);
INSERT INTO `magasins`.`stock` VALUES (9,'Tulipe', 4, 22);
INSERT INTO `magasins`.`stock` VALUES (10,'Tulipe', 5, 0);
INSERT INTO `magasins`.`stock` VALUES (11,'Lys', 1, 0);
INSERT INTO `magasins`.`stock` VALUES (12,'Lys', 2, 345);
INSERT INTO `magasins`.`stock` VALUES (13,'Lys', 3, 56);
INSERT INTO `magasins`.`stock` VALUES (14,'Lys', 4, 46);
INSERT INTO `magasins`.`stock` VALUES (15,'Lys', 5, 26);
INSERT INTO `magasins`.`stock` VALUES (16,'Marguerite', 1, 57);
INSERT INTO `magasins`.`stock` VALUES (17,'Marguerite', 2, 62);
INSERT INTO `magasins`.`stock` VALUES (18,'Marguerite', 3, 456);
INSERT INTO `magasins`.`stock` VALUES (19,'Marguerite', 4, 46);
INSERT INTO `magasins`.`stock` VALUES (20,'Marguerite', 5, 0);
INSERT INTO `magasins`.`stock` VALUES (21,'Orchidée', 1, 124);
INSERT INTO `magasins`.`stock` VALUES (22,'Orchidée', 2, 324);
INSERT INTO `magasins`.`stock` VALUES (23,'Orchidée', 3, 353);
INSERT INTO `magasins`.`stock` VALUES (24,'Orchidée', 4, 847);
INSERT INTO `magasins`.`stock` VALUES (25,'Orchidée', 5, 287);
INSERT INTO `magasins`.`stock` VALUES (26,'Pivoine', 1, 23);
INSERT INTO `magasins`.`stock` VALUES (27,'Pivoine', 2, 49);
INSERT INTO `magasins`.`stock` VALUES (28,'Pivoine', 3, 0);
INSERT INTO `magasins`.`stock` VALUES (29,'Pivoine', 4, 554);
INSERT INTO `magasins`.`stock` VALUES (30,'Pivoine', 5, 42);
INSERT INTO `magasins`.`stock` VALUES (31,'Jonquille', 1, 0);
INSERT INTO `magasins`.`stock` VALUES (32,'Jonquille', 2, 16);
INSERT INTO `magasins`.`stock` VALUES (33,'Jonquille', 3, 283);
INSERT INTO `magasins`.`stock` VALUES (34,'Jonquille', 4, 763);
INSERT INTO `magasins`.`stock` VALUES (35,'Jonquille', 5, 445);
INSERT INTO `magasins`.`stock` VALUES (36,'Œillet', 1, 325);
INSERT INTO `magasins`.`stock` VALUES (37,'Œillet', 2, 352);
INSERT INTO `magasins`.`stock` VALUES (38,'Œillet', 3, 456);
INSERT INTO `magasins`.`stock` VALUES (39,'Œillet', 4, 460);
INSERT INTO `magasins`.`stock` VALUES (40,'Œillet', 5, 485);
INSERT INTO `magasins`.`stock` VALUES (41,'Iris', 1, 65);
INSERT INTO `magasins`.`stock` VALUES (42,'Iris', 2, 0);
INSERT INTO `magasins`.`stock` VALUES (43,'Iris', 3, 334);
INSERT INTO `magasins`.`stock` VALUES (44,'Iris', 4, 532);
INSERT INTO `magasins`.`stock` VALUES (45,'Iris', 5, 345);
INSERT INTO `magasins`.`stock` VALUES (46,'Bleuet', 1, 354);
INSERT INTO `magasins`.`stock` VALUES (47,'Bleuet', 2, 354);
INSERT INTO `magasins`.`stock` VALUES (48,'Bleuet', 3, 234);
INSERT INTO `magasins`.`stock` VALUES (49,'Bleuet', 4, 456);
INSERT INTO `magasins`.`stock` VALUES (50,'Bleuet', 5, 354);
INSERT INTO `magasins`.`stock` VALUES (51,'Dahlia', 1, 455);
INSERT INTO `magasins`.`stock` VALUES (52,'Dahlia', 2, 235);
INSERT INTO `magasins`.`stock` VALUES (53,'Dahlia', 3, 356);
INSERT INTO `magasins`.`stock` VALUES (54,'Dahlia', 4, 353);
INSERT INTO `magasins`.`stock` VALUES (55,'Dahlia', 5, 254);
INSERT INTO `magasins`.`stock` VALUES (56,'Jacinthe', 1, 45);
INSERT INTO `magasins`.`stock` VALUES (57,'Jacinthe', 2, 427);
INSERT INTO `magasins`.`stock` VALUES (58,'Jacinthe', 3, 76);
INSERT INTO `magasins`.`stock` VALUES (59,'Jacinthe', 4, 5);
INSERT INTO `magasins`.`stock` VALUES (60,'Jacinthe', 5, 77);
INSERT INTO `magasins`.`stock` VALUES (61,'Coquelicot', 1, 54);
INSERT INTO `magasins`.`stock` VALUES (62,'Coquelicot', 2, 253);
INSERT INTO `magasins`.`stock` VALUES (63,'Coquelicot', 3, 346);
INSERT INTO `magasins`.`stock` VALUES (64,'Coquelicot', 4, 66);
INSERT INTO `magasins`.`stock` VALUES (65,'Coquelicot', 5, 524);
INSERT INTO `magasins`.`stock` VALUES (66,'Camélia', 1, 62);
INSERT INTO `magasins`.`stock` VALUES (67,'Camélia', 2, 734);
INSERT INTO `magasins`.`stock` VALUES (68,'Camélia', 3, 234);
INSERT INTO `magasins`.`stock` VALUES (69,'Camélia', 4, 345);
INSERT INTO `magasins`.`stock` VALUES (70,'Camélia', 5, 254);
INSERT INTO `magasins`.`stock` VALUES (71,'Tournesol', 1, 462);
INSERT INTO `magasins`.`stock` VALUES (72,'Tournesol', 2, 446);
INSERT INTO `magasins`.`stock` VALUES (73,'Tournesol', 3, 5442);
INSERT INTO `magasins`.`stock` VALUES (74,'Tournesol', 4, 45);
INSERT INTO `magasins`.`stock` VALUES (75,'Tournesol', 5, 43);
INSERT INTO `magasins`.`stock` VALUES (76,'Lavande', 1, 46);
INSERT INTO `magasins`.`stock` VALUES (77,'Lavande', 2, 42);
INSERT INTO `magasins`.`stock` VALUES (78,'Lavande', 3, 436);
INSERT INTO `magasins`.`stock` VALUES (79,'Lavande', 4, 462);
INSERT INTO `magasins`.`stock` VALUES (80,'Lavande', 5, 624);
INSERT INTO `magasins`.`stock` VALUES (81,'Lilas', 1, 46);
INSERT INTO `magasins`.`stock` VALUES (82,'Lilas', 2, 65);
INSERT INTO `magasins`.`stock` VALUES (83,'Lilas', 3, 0);
INSERT INTO `magasins`.`stock` VALUES (84,'Lilas', 4, 0);
INSERT INTO `magasins`.`stock` VALUES (85,'Lilas', 5, 445);
INSERT INTO `magasins`.`stock` VALUES (86,'Chrysanthème', 1, 46);
INSERT INTO `magasins`.`stock` VALUES (87,'Chrysanthème', 2, 2);
INSERT INTO `magasins`.`stock` VALUES (88,'Chrysanthème', 3, 66);
INSERT INTO `magasins`.`stock` VALUES (89,'Chrysanthème', 4, 42);
INSERT INTO `magasins`.`stock` VALUES (90,'Chrysanthème', 5, 456);
INSERT INTO `magasins`.`stock` VALUES (91,'Primevère', 1, 34);
INSERT INTO `magasins`.`stock` VALUES (92,'Primevère', 2, 46);
INSERT INTO `magasins`.`stock` VALUES (93,'Primevère', 3, 345);
INSERT INTO `magasins`.`stock` VALUES (94,'Primevère', 4, 345);
INSERT INTO `magasins`.`stock` VALUES (95,'Primevère', 5, 334);
INSERT INTO `magasins`.`stock` VALUES (96,'Souci', 1, 345);
INSERT INTO `magasins`.`stock` VALUES (97,'Souci', 2, 34);
INSERT INTO `magasins`.`stock` VALUES (98,'Souci', 3, 464);
INSERT INTO `magasins`.`stock` VALUES (99,'Souci', 4, 34);
INSERT INTO `magasins`.`stock` VALUES (100,'Souci', 5, 462);

select * from stock;


INSERT INTO `magasins`.`bouquet` VALUES (1, 'Bouquet de roses rouges', 'Standard', 29.99, 'Roses rouges');
INSERT INTO `magasins`.`bouquet`VALUES(2, 'Bouquet de lys blancs', 'Standard', 34.99, 'Lys blancs');
INSERT INTO `magasins`.`bouquet`VALUES(3, 'Bouquet de tulipes multicolores', 'Standard', 19.99, 'Tulipes de différentes couleurs');
INSERT INTO `magasins`.`bouquet` VALUES(4, 'Bouquet de pivoines roses', 'Standard', 39.99, 'Pivoines roses');
INSERT INTO `magasins`.`bouquet`VALUES(5, 'Bouquet de marguerites jaunes', 'Standard', 24.99, 'Marguerites jaunes');
INSERT INTO `magasins`.`bouquet`VALUES(6, 'Bouquet de fleurs sauvages', 'Personnalisé', 29.99, 'Mélange de fleurs sauvages locales');
INSERT INTO `magasins`.`bouquet`VALUES(7, 'Bouquet de roses et de lys', 'Personnalisé', 49.99, 'Roses rouges et lys blancs');
INSERT INTO `magasins`.`bouquet`VALUES(8, 'Bouquet de pivoines et de tulipes', 'Personnalisé', 44.99, 'Pivoines roses et tulipes multicolores');
INSERT INTO `magasins`.`bouquet`VALUES(9, 'Bouquet romantique', 'Personnalisé', 59.99, 'Roses rouges, lys blancs et pivoines roses');
INSERT INTO `magasins`.`bouquet`VALUES(10, 'Bouquet printanier', 'Personnalisé', 39.99, 'Tulipes multicolores, marguerites jaunes et fleurs sauvages');
INSERT INTO `magasins`.`bouquet`VALUES(11, 'Bouquet de roses blanches', 'Standard', 29.99, 'Roses blanches');
INSERT INTO `magasins`.`bouquet`VALUES(12, 'Bouquet de lys roses', 'Standard', 34.99, 'Lys roses');
INSERT INTO `magasins`.`bouquet`VALUES(13, 'Bouquet de tournesols', 'Standard', 19.99, 'Tournesols');
INSERT INTO `magasins`.`bouquet`VALUES(14, 'Bouquet de fleurs exotiques', 'Standard', 49.99, 'Mélange de fleurs exotiques');
INSERT INTO `magasins`.`bouquet`VALUES(15, 'Bouquet de roses et de pivoines', 'Personnalisé', 44.99, 'Roses rouges et pivoines roses');
INSERT INTO `magasins`.`bouquet`VALUES(16, 'Bouquet de tulipes blanches', 'Personnalisé', 29.99, 'Tulipes blanches');
INSERT INTO `magasins`.`bouquet`VALUES(17, 'Bouquet de fleurs dorchidées', 'Personnalisé', 64.99, 'Fleurs dorchidées exotiques');
INSERT INTO `magasins`.`bouquet`VALUES(18, 'Bouquet de roses et de marguerites', 'Personnalisé', 39.99, 'Roses rouges et marguerites jaunes');
INSERT INTO `magasins`.`bouquet`VALUES(19, 'Bouquet de fleurs de saison', 'Standard', 24.99, 'Mélange de fleurs de saison');
INSERT INTO `magasins`.`bouquet`VALUES(20, 'Bouquet de roses oranges', 'Standard', 29.99, 'Roses oranges');
INSERT INTO `magasins`.`bouquet`VALUES(21, 'Bouquet de lys oranges', 'Standard', 34.99, 'Lys oranges');
INSERT INTO `magasins`.`bouquet`VALUES(22, 'Bouquet de fleurs dhiver', 'Standard', 39.99, 'melange fleurs dhiver');
INSERT INTO `magasins`.`bouquet`VALUES(23, 'Bouquet romantique', 'Standard', 59.99, 'Roses rouges et lys blancs');
INSERT INTO `magasins`.`bouquet`VALUES(24, 'Bouquet printanier', 'Personnalisé', 44.99, 'Tulipes colorées et jonquilles avec ruban personnalisé');
INSERT INTO `magasins`.`bouquet`VALUES(25, 'Bouquet exotique', 'Standard', 49.99, 'Orchidées, oiseaux de paradis et anthuriums');
INSERT INTO `magasins`.`bouquet`VALUES(26, 'Bouquet champêtre', 'Personnalisé', 54.99, 'Pivoines roses, marguerites et lavande avec carte personnalisée');
INSERT INTO `magasins`.`bouquet`VALUES(27, 'Bouquet de mariage', 'Standard', 79.99, 'Roses blanches, lys et gypsophile');
INSERT INTO `magasins`.`bouquet`VALUES(28, 'Bouquet de naissance', 'Personnalisé', 64.99, 'Lys rose, roses jaunes et bleuets avec ruban et ballons personnalisés');
INSERT INTO `magasins`.`bouquet`VALUES(29, 'Bouquet de condoléances', 'Standard', 39.99, 'Lys blancs, roses pâles et feuillage');
INSERT INTO `magasins`.`bouquet`VALUES(30, 'Bouquet d''été éclatant', 'Personnalisé', 74.99, 'Glaïeuls, dahlias et tournesols avec message personnalisé');
INSERT INTO `magasins`.`bouquet`VALUES(31, 'Bouquet automnal', 'Standard', 49.99, 'Chrysanthèmes, gerberas et feuillage automnal');
INSERT INTO `magasins`.`bouquet`VALUES(32, 'Bouquet de Saint-Valentin', 'Personnalisé', 69.99, 'Roses rouges, alstroemerias et feuillage romantique avec carte et chocolats personnalisés');

select * from bouquet;


INSERT INTO `magasins`.`commande`VALUES(1, '2023-04-22', '2023-04-21', 1,1, 1, 'VINC');
INSERT INTO `magasins`.`commande`VALUES(2, '2023-04-23', '2023-04-21', 1,2, 1, 'CC');
INSERT INTO `magasins`.`commande`VALUES(3, '2027-04-24', '2028-04-21', 1,3, 9, 'CPAV');
INSERT INTO `magasins`.`commande`VALUES(4, '2023-04-25', '2023-04-21', 4,5, 4, 'CAL');
INSERT INTO `magasins`.`commande`VALUES(5, '2026-04-26', '2027-04-21', 5,5, 9, 'CL');
INSERT INTO `magasins`.`commande`VALUES(6, '2021-04-27', '2020-04-21', 5,1, 6, 'CL');
INSERT INTO `magasins`.`commande`VALUES(7, '2023-04-28', '2023-04-21', 2,1, 2, 'CC');
INSERT INTO `magasins`.`commande`VALUES(8, '2024-04-29', '2025-04-21', 4,3, 1, 'CPAV');
INSERT INTO `magasins`.`commande` VALUES(9, '2024-05-01', '2022-04-22', 3, 4, 2, 'CC');
INSERT INTO `magasins`.`commande` VALUES(10, '2024-05-02', '2024-02-23', 3, 2, 9, 'CPAV');
INSERT INTO `magasins`.`commande` VALUES(11, '2024-05-03', '2024-04-24', 2, 1, 1, 'VINC');
INSERT INTO `magasins`.`commande` VALUES(12, '2023-05-04', '2025-04-25', 2, 1, 9, 'CL');
INSERT INTO `magasins`.`commande` VALUES(13, '2024-06-05', '2024-04-26', 5, 1, 8, 'CPAV');
INSERT INTO `magasins`.`commande` VALUES(14, '2024-05-06', '2023-04-27', 2, 2, 2, 'CC');
INSERT INTO `magasins`.`commande` VALUES(15, '2024-05-07', '2023-04-28', 4, 1, 9, 'VINC');
INSERT INTO `magasins`.`commande` VALUES(16, '2023-08-08', '2023-04-29', 3, 3, 10, 'CPAV');
INSERT INTO `magasins`.`commande` VALUES(17, '2024-12-09', '2023-04-30', 2, 2, 4, 'CL');
INSERT INTO `magasins`.`commande` VALUES(18, '2022-11-6', '2020-05-01', 2, 5, 2, 'CC');

-- Calcul du prix moyen du bouquet acheté
SELECT AVG(prix_bouquet) from bouquet;



--  meilleur client du mois 
SELECT clients.nom, SUM(bouquet.prix_bouquet) as total_dépensé_par_mois
FROM clients
JOIN commande ON clients.id_client = commande.id_client
JOIN bouquet  ON commande.id_bouquet = bouquet.id_bouquet
WHERE MONTH(commande.date_commande) = MONTH(CURRENT_DATE()) 
GROUP BY nom
ORDER BY total_dépensé_par_mois DESC
LIMIT 1;


-- meilleure client de l'année 
SELECT clients.nom, SUM(bouquet.prix_bouquet) as total_dépensé_par_année
FROM clients
JOIN commande ON clients.id_client = commande.id_client
JOIN bouquet  ON commande.id_bouquet = bouquet.id_bouquet
WHERE YEAR(commande.date_commande) = YEAR(CURRENT_DATE())
GROUP BY nom
ORDER BY total_dépensé_par_année DESC
 LIMIT 1;




--  Quel est le bouquet standard qui a eu le plus de succès ?
SELECT bouquet.nom AS nom_bouquet, count(id_commande) AS nombre_commandes
FROM commande
JOIN bouquet  ON commande.id_bouquet = bouquet.id_bouquet
WHERE categorie IN ('Standard')
GROUP BY bouquet.nom
ORDER BY COUNT(id_commande) DESC
LIMIT 1;



-- Quel est le magasin qui a généré le plus de chiffre d’affaires ?
SELECT magasin.nom AS nom_magasin, SUM(bouquet.prix_bouquet ) AS chiffre_affaires
FROM magasin
JOIN commande c ON magasin.id_magasin = c.id_bouquet
JOIN bouquet ON c.id_bouquet = bouquet.id_bouquet
GROUP BY magasin.nom
ORDER BY chiffre_affaires DESC
LIMIT 1;



-- Quelle est la fleur exotique la moins vendue ?
SELECT id_fleur AS nom_fleur, MAX(quantite_disponible) AS total_restant_disponible
FROM stock NATURAL JOIN(fleur)
GROUP BY id_fleur
ORDER BY total_restant_disponible DESC
LIMIT 1;


SELECT id_commande, magasin.nom AS nom_magasin,commande.id_client,date_commande, date_livraison, commande.id_bouquet, sum(prix_bouquet) AS prix_bouquet , code_etat AS état_commande
FROM commande NATURAL JOIN( bouquet, clients, magasin)
GROUP BY id_commande
ORDER BY date_commande DESC;


