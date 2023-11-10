/*
-------------------------------------
-- Projet : Livre de recettes C#
-- Auteur : Alessia Mavraj
-- Date : 07.11.2023
-------------------------------------
*/


-- Création de la base de donnée "recipes" 

CREATE DATABASE IF NOT EXISTS recipes;

USE recipes;

-- Création de la table de données "storage"

CREATE TABLE IF NOT EXISTS cooking
(
	id INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
	name_of_recipe VARCHAR(150) NOT NULL,
	vegetarian BOOLEAN NOT NULL,
	time_of_preparation VARCHAR(100),
	type_of_recipe VARCHAR(100),
	region_of_recipe VARCHAR(100),
	lvl VARCHAR(100),
	ingredient VARCHAR(600)
)

-- Mettre les valeurs boolean par défaut "false"

ALTER TABLE cooking
ALTER COLUMN vegetarian
SET DEFAULT FALSE;

-- Inserion des données dans la table "cooking"

INSERT INTO cooking (id, name_of_recipe, vegetarian, glutent, time_of_preparation, type_of_recipe, region_of_recipe, lvl, ingredient)

	VALUES(1, )