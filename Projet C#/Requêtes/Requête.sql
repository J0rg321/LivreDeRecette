/*
-------------------------------------
-- Projet : Livre de recettes C#
-- Auteur : Alessia Mavraj - Jorge Miguel Pinto Costa
-- Date : 07.11.2023
-------------------------------------
*/


-- Création de la base de donnéecooking "cooking" 

DROP DATABASE IF EXISTS cooking;

CREATE DATABASE IF NOT EXISTS cooking;

USE cooking;

-- Création de la table de données "recipe"

CREATE TABLE IF NOT EXISTS recipes
(
	id INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
	recipeName VARCHAR(150) NOT NULL,
	vegetarian BOOLEAN NOT NULL,
	preparationTime INT NOT NULL,
	recipeType VARCHAR(100),
	lvl VARCHAR(100)
);

-- Création de la table de données "step"

CREATE TABLE IF NOT EXISTS steps
(
	id INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
	stepName VARCHAR(150) NOT NULL,
	stepNumber INT NOT NULL,
	content VARCHAR(1000) NOT NULL,
	recipeID INT NOT NULL
);

CREATE TABLE IF NOT EXISTS ingredients
(
	id INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
	ingredientName VARCHAR(100) NOT NULL,
	measurement VARCHAR(100) NOT NULL
);

CREATE TABLE IF NOT EXISTS quantities
(
	id INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
	ingredientID INT NOT NULL,
	recipeID INT NOT NULL,
	ingredientQuantities FLOAT NOT NULL
);

-- Mettre les valeurs boolean par défaut "false"

ALTER TABLE recipes
ALTER COLUMN vegetarian
SET DEFAULT FALSE;
-- Inserion des données dans la table "ingredient"

INSERT INTO ingredients (ingredientName, measurement)

	VALUES
		("glace au chocolat","grammes"),
		("pistaches hachées","cuillères à soupe"),
		("biscuit(s)",""),
		("glaçage pour gâteau", "grammes"),
		("gousse(s) d'ail",""),
		("mélange de fromage à fondue","grammes"),
		("vin blanc","décilitres"),
		("maïzena","cuillères à soupe"),
		("kirsch","cuillères à soupe"),
		("noix de muscade",""),
		("poivre",""),
		("sucre","cuillères à soupe"),
		("jaune(s) d'œuf",""),
		("mascarpone","grammes"),
		("blanc(s) d'œuf",""),
		("sel","pincée(s)"),
		("café fort","décilitres"),
		("Amaretto","cuillères à soupe"),
		("biscuit(s) boudoir","grammes"),
		("cacao en poudre",""),
		("spaghettis","grammes"),
		("lardons","grammes"),
		("pecorino romano râpé","grammes");


-- Inserion des données dans la table "recipes"

INSERT INTO recipes (recipeName, vegetarian, preparationTime, recipeType, lvl)

	VALUES
	("SANDWICH À LA GLACE AU CHOCOLAT", 1, "1h10", "Dessert", "Intermédiaire"),
	("FONDUE MOITIÉ-MOITIÉ", 1, "20 min", "Plat principal", "Intermédiaire"),
	("TIRAMISÙ", 0, "2h30", "Dessert", "Intermédiaire"),
	("SPAGHETTI ALLA CARBONARA", 0, "30 min", "Plat principal", "Débutant");
	
INSERT INTO quantities (ingredientID, recipeID, ingredientQuantities)


	VALUES
	
-- SANDWICH À LA GLACE AU CHOCOLAT 

	(1,1,25),
	(2,1,0.5),
	(3,1,2),
	(4,1,30),
	(2,1,0.25),
	
-- FONDUE MOITIÉ-MOITIÉ
	
	(5,2,0.25),
	(6,2,200),
	(7,2,0.75),
	(8,2,0.25),
	(9,2,0.25),
	(10,2,0),
	(11,2,0),

-- TIRAMISÙ
	
	(12,3,12.5),
	(13,3,0.5),
	(14,3,62.5),
	(15,3,0.5),
	(16,3,0.25),
	(12,3,0.25),
	(17,3,0.5),
	(18,3,1),
	(12,3,0.25),
	(19,3,37.05),
	(20,3,0),

-- SPAGHETTI ALLA CARBONARA
	
	(21,4,125),
	(22,4,37.05),
	(13,4,1),
	(23,4,20),
	(16,4,0),
	(11,4,0),
	(23,4,0);
	
INSERT INTO steps (stepName,stepNumber,content,recipeID)

VALUES

-- SANDWICH À LA GLACE AU CHOCOLAT 

("Glace au chocolat",1,"Mélanger les pistaches à la glace. Prendre quatre biscuits et étaler environ 2 cs de glace sur chacun d'entre eux, poser les autres biscuits dessus. Mettre les sandwichs à la glace pendant env. 30 min au congélateur.", 1),
("Enrobage de chocolat",2,"Plonger les sandwichs à la glace jusqu'à mihauteur dans le glaçage, les parsemer de pistaches, laisser sécher env. 2 min. sur une grille. Remettre au congélateur pendant env. 30 min.",1),

-- FONDUE MOITIÉ-MOITIÉ

("Fondue",1,"Couper la gousse d'ail en deux et en frotter le caquelon. Ajouter le mélange de fromages pour fondue dans le caquelon. Mélanger le vin avec la maïzena, l'ajouter au fromage et porter à ébullition à petit feu tout en remuant, ajouter le kirsch et assaisonner.",2),

-- TIRAMISÙ

("Crème au mascarpone",1,"Faire mousser le sucre, les jaunes d'œufs et le zeste d'orange au batteur électrique jusqu'à ce que la masse commence à blanchir. Lisser le mascarpone et l'ajouter à la préparation précédente. Monter les blancs d'œufs en neige avec le sel, ajouter le sucre et continuer de battre jusqu'à ce que les blancs soient bien brillants. Les incorporer délicatement à la masse aux jaunes d'œuf avec une spatule en caoutchouc.",3),
("Sirop",2,"Mélanger le café, l'amaretto et le sucre jusqu'à ce que le sucre soit dissous.",3),
("Dressage", 3, "Mettre la moitié des biscuits à la cuiller dans le moule, côté sucré vers le bas, et les arroser de la moitié du sirop. Napper de la moitié de la préparation. Tremper le reste de biscuits dans le liquide, les disposer par-dessus. Couvrir avec le reste du mélange. Couvrir et mettre au frais env. 2 h. Saupoudrer de cacao en poudre.",3),

-- SPAGHETTI ALLA CARBONARA

("Spaghettis",1,"Faire cuire les spaghettis al dente dans l'eau salée, réserver env. 1 dl de l'eau de cuisson. Egoutter les pâtes, les couvrir et les réserver.",4),
("Lardons",2,"Faire dorer le lard dans une poêle antiadhésive sans matière grasse puis ajouter les spaghettis.",4),
("Sauce",3,"Mélanger les jaunes d'œufs avec le pecorino et l'eau de cuisson, assaisonner. Ajouter le tout aux spaghettis et retirer la poêle du feu. Bien mélanger et servir aussitôt. Parsemer de pecorino romano.",4);