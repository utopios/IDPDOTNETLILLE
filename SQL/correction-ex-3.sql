﻿-- Question 1
SELECT TOP 10 * from villes_france_free
order by ville_population_2012 desc;

-- Question 2
SELECT TOP 50 * from villes_france_free
order by ville_surface asc;

-- Question 3
SELECT *  FROM departement where departement_code like '97%';

-- Question 4
SELECT TOP 10 v.ville_nom, d.departement_nom FROM villes_france_free as v
inner join departement as d on v.ville_departement=d.departement_code
order by v.ville_population_2012 desc;

-- Question 5
SELECT count(*) as nombre_commune, d.departement_nom from villes_france_free as v 
inner join departement as d on v.ville_departement=d.departement_code 
group by d.departement_code, d.departement_nom 
order by nombre_commune desc;