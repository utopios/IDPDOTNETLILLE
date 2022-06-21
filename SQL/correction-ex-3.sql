-- Question 1
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

--Question 6

SELECT SUM(v.ville_surface) as surface, d.departement_nom from villes_france_free as v 
inner join departement as d on v.ville_departement=d.departement_code 
group by d.departement_code, d.departement_nom 
order by surface desc;

-- Question 7
SELECT count(*) as nb_ville from villes_france_free as v 
where v.ville_nom like 'SAINT%';

--Question 8
SELECT * FROM (
SELECT count(*) as nombre, v.ville_nom 
from villes_france_free as v group by v.ville_nom)
as tmp_ville where nombre > 1 order by nombre desc;

-- Question 9
SELECT * FROM villes_france_free 
where ville_surface > (SELECT AVG(ville_surface) from villes_france_free);