DROP DATABASE IF EXISTS DiscographyManagerDB;
CREATE DATABASE DiscographyManagerDB CHARSET 'utf8';
USE DiscographyManagerDB;

CREATE TABLE Users(
	Id INTEGER NOT NULL AUTO_INCREMENT,
	Name VARCHAR(30) NOT NULL,
    Email VARCHAR(35) NOT NULL,
    Password VARCHAR(200) NOT NULL,
    PRIMARY KEY(Id)
);

CREATE TABLE Songs(
	Id INTEGER NOT NULL AUTO_INCREMENT,
    Name VARCHAR(500) NOT NULL,
	Lyrics TEXT Default NULL,
    ReleaseDate DATE NOT NULL,
	PRIMARY KEY(Id)
);

CREATE TABLE Discographies(
	Id INTEGER NOT NULL AUTO_INCREMENT,
	UserId INTEGER NULL,
	Name VARCHAR(30) NOT NULL,
    
	PRIMARY KEY(Id),
	FOREIGN KEY (UserId) REFERENCES Users(Id) On Delete Cascade
);

CREATE TABLE SongsInDiscographies(
	DiscographyId INTEGER DEFAULT NULL,
    SongId INTEGER DEFAULT NULL,
    
    FOREIGN KEY (DiscographyId) REFERENCES Discographies(Id) On delete cascade,
    FOREIGN KEY (SongId) REFERENCES Songs(Id) On delete cascade
);

CREATE UNIQUE INDEX nameOfUser
ON Users (Name);
CREATE UNIQUE INDEX emailOfUser
ON Users (Email);
