--LDD => De données
-- Création des Tables
CREATE TABLE personne (
	numero int not null PRIMARY KEY IDENTITY(1,1),
	nom varchar(100),
	prenom varchar(100),
	telephone varchar(10)
);

-- Supprimer une table
DROP TABLE personne;

-- Modifier une table
ALTER TABLE personne ADD age int not null;

-- LMD 
-- Insertion des données.
INSERT INTO personne (nom, prenom, telephone) 
	OUTPUT inserted.numero values ('toto', 'tata', '0123456789');
-- UPDATE
UPDATE personne set nom='toto', prenom='tata' WHERE numero > 1 ;
--DELETE
DELETE FROM personne;

--Requetes
SELECT * FROM personne where numero > 1;
SELECT * FROM personne where numero > 1 order by nom desc;
SELECT nom, prenom FROM personne where numero > 1 order by nom desc;
SELECT TOP 1 nom, prenom FROM personne where numero > 1 order by nom desc;






