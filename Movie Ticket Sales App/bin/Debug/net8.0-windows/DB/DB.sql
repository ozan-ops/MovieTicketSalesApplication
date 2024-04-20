-- Movie definition

CREATE TABLE Movie (
	id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	movieName TEXT NOT NULL,
	timeOne TIMESPAN NOT NULL,
	timeTwo TIMESPAN NOT NULL,
	timeThree TIMESPAN NOT NULL,
	timeFour TIMESPAN NOT NULL
);

-- MovieTheater definition

CREATE TABLE MovieTheater (
	id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	movieTheaterName TEXT NOT NULL,
	movieTheaterCapacity INTEGER NOT NULL
);

-- "Session" definition

CREATE TABLE Session (
	id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	movieName TEXT NOT NULL,
	movieTheaterName TEXT NOT NULL,
	movieDate DATETIME NOT NULL,
	movieTime TIMESPAN NOT NULL
);

-- Customer definition

CREATE TABLE Customer (
	id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	sessionID INTEGER NOT NULL,
	customerName TEXT NOT NULL,
	customerSurname TEXT NOT NULL,
	customerIDNumber TEXT NOT NULL,
	cardNumber TEXT NOT NULL,
	validityMonth INTEGER NOT NULL,
	validityYear INTEGER NOT NULL,
	securityCode INTEGER NOT NULL
);