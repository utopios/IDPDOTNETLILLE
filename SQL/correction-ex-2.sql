--Création de table
CREATE TABLE livre(
    id int PRIMARY KEY IDENTITY(1,1),
    titre varchar(1000) not null,
    auteur varchar(100) not null,
    editeur varchar(100) not null,
    date_publication DATE not null,
    isbn_10 varchar(10) not null,
    isbn_13 varchar(14) not null
);

--Q1
SELECT * FROM livre order by titre asc;
--Q2
SELECT * FROM livre order by date_publication asc;
--Q3
SELECT TOP 10 date_publication FROM livre order by date_publication asc;
--Q4
SELECT TOP 10 * FROM livre order by date_publication asc;

--Q5
SELECT TOP 10 date_publication, auteur, titre FROM livre order by date_publication asc;

--Q6
SELECT * FROM livre where auteur='Agatha Christie';

--Q7
UPDATE livre set auteur='Agatha Christie' where auteur='Agatha Christies';

-- Question 8
INSERT INTO livre(titre, auteur, editeur, date_publication, isbn_10, isbn_13)
            VALUES ('titre 1','auteur 1','editeur 1','2022-06-20','0123456789','012-345678912');

-- Question 9
DELETE from livre where titre = 'titre 1' and auteur='auteur 1';

