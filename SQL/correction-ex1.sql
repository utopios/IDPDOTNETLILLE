--Correction exercice 1
--Q1
CREATE TABLE personne(
id int not null PRIMARY KEY IDENTITY(1,1),
titre varchar(10) not null,
prenom varchar(200) not null,
nom varchar(200) not null,
email varchar(200) not null,
telephone varchar(10) not null,
);

--Q2

INSERT INTO personne (titre, nom, prenom, telephone, email)
values 
('Mr', 'aa', 'bb', '012', 'aa@bb.fr'),
('Mme', 'bb', 'cc', '013', 'dd@cc.fr'),
('Mr', 'ff', 'ee', '022', 'ff@ee.fr');

--Q3
SELECT * FROM personne order by nom asc;

--Q4
SELECT * FROM personne order by titre asc;

--Q5
SELECT * FROM personne where email='dd@cc.fr';
