--Cours jointure
CREATE TABLE adresse(
	id int not null PRIMARY KEY IDENTITY(1,1),
	rue varchar(200) not null,
	ville varchar(200) not null,
	personne_id int not null
);

SELECT a.id as adresseid, p.nom, a.ville FROM personne as p inner join adresse as a on p.id = a.personne_id;
SELECT * FROM personne left join adresse on personne.id = adresse.personne_id;
SELECT * FROM personne right join adresse on personne.id = adresse.personne_id;
SELECT * FROM personne full join adresse on personne.id = adresse.personne_id;