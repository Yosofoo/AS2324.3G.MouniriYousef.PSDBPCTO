-- PROGETTO PCTO DATABASE IN TERZA INFORMATICA
-- Prof. 02/05/24 3 G/F
-- DDL, DML e QL
-- test su https://sqliteonline.com/ scegliendo SQLite

DROP table if EXISTS Gare;
DROP table if EXISTS Circuiti;
DROP table if EXISTS Piloti;
DROP table if EXISTS Squadre;

CREATE TABLE Squadre( 
  IdSquadre INTEGER PRIMARY KEY not NULL, 
  Nome varchar(50) not NULL, 
  Nazionalita varchar(50) not NULL
);

CREATE TABLE Piloti( 
  IdPiloti INTEGER PRIMARY KEY not NULL, 
  nome varchar(50) not NULL, 
  cognome varchar(50) not NULL, 
  nazionalita varchar(50) not NULL,
  IdSquadre INTEGER not NULL,
  FOREIGN key (IdSquadre) REFERENCES Squadre(IdSquadre)
);

CREATE TABLE Circuiti( 
  IdCircuiti INTEGER PRIMARY KEY not NULL, 
  nome varchar(50) not NULL 
);

CREATE TABLE Gare( 
	IdGare INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
 	IdPiloti INTEGER not NULL, 
	IdCircuiti INTEGER not NULL, 
	Punteggio INTEGER not NULL, 
	Data DATE NOT NULL,
	FOREIGN key (IdPiloti) REFERENCES Piloti(IdPiloti),
	FOREIGN key (IdCircuiti) REFERENCES Circuiti(IdCircuiti)
);

INSERT into Squadre (IdSquadre, nome,nazionalita)
VALUES (30, 'Ducati','ITA');
INSERT into Squadre (IdSquadre, nome,nazionalita)
VALUES (31, 'Pramac','ITA');
INSERT into Squadre (IdSquadre, nome,nazionalita)
VALUES (32, 'Yamaha','JP');

INSERT into Piloti (IdPiloti, nome,cognome,nazionalita,IdSquadre)
VALUES (1, 'Francesco', 'Bagnaia', 'ITA', 30);
INSERT into Piloti (IdPiloti, nome,cognome,nazionalita,IdSquadre)
VALUES (2, 'Enea', 'Bastianini', 'ITA', 30);
INSERT into Piloti (IdPiloti, nome,cognome,nazionalita,IdSquadre)
VALUES (3, 'Horge', 'Martin', 'SPA', 31);
INSERT into Piloti (IdPiloti, nome,cognome,nazionalita,IdSquadre)
VALUES (4, 'Ricky', 'One', 'ZMB', 31);
INSERT into Piloti (IdPiloti, nome,cognome,nazionalita,IdSquadre)
VALUES (100, 'Test', 'cancellazione', 'TST', 31);


INSERT into Circuiti (IdCircuiti, nome)
VALUES (10, 'Mugello');
INSERT into Circuiti (IdCircuiti, nome)
VALUES (11, 'Jerez');
INSERT into Circuiti (IdCircuiti, nome)
VALUES (12, 'Misano');


INSERT into Gare (data,idPiloti,idCircuiti,punteggio)
VALUES ('20240428',1,11,1);
INSERT into Gare (data,idPiloti,idCircuiti,punteggio)
VALUES ('20240428',2,11,5);
INSERT into Gare (data,idPiloti,idCircuiti,punteggio)
VALUES ('20240428',3,11,0);

-- UPDATE (Modifica) DML

UPDATE 
	Circuiti
SET
	Nome = 'Mugello - Italia'
WHERE 
	IdCircuiti = 10
	
-- DELETE (cancellazione) DML

DELETE FROM 
	Piloti
WHERE 
	IdPiloti = 100

-- query QL
SELECT 
	* 
FROM 
	Piloti 
ORDER BY 
	nome, cognome;
SELECT 
	* 
FROM 
	Piloti 
WHERE 
	nazionalita='ITA' 
ORDER by 
	nome, cognome;
	
SELECT 
	Piloti.nome,Piloti.cognome,squadre.Nazionalita
FROM 
	Piloti 
	INNER join Squadre on 
		Squadre.idSquadre=Piloti.idSquadre 
ORDER BY 
	Piloti.nome, Piloti.cognome;