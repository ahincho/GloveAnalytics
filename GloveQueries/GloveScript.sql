
CREATE DATABASE GloveTest;

USE GloveTest;

CREATE TABLE Status (
	StaId INTEGER PRIMARY KEY AUTOINCREMENT,
	StaName TEXT(20) UNIQUE NOT NULL,
	StaStatus INTEGER NOT NULL,
	FOREIGN KEY (StaStatus) REFERENCES Status(StaId)
);

CREATE TABLE Person (
	PerId INTEGER PRIMARY KEY AUTOINCREMENT UNIQUE,
	PerName TEXT(40) NOT NULL,
	PerLastname TEXT(40) NOT NULL,
	PerDocument TEXT(12) UNIQUE NOT NULL,
	PerBirthday TEXT(16) NOT NULL,
	PerPhoneNumber TEXT(16) NOT NULL,
	PerEmail TEXT(30),
	PerAddress TEXT(50),
	PerStatus INTEGER NOT NULL,
	FOREIGN KEY (PerStatus) REFERENCES Status(StaId)
);

CREATE TABLE Specialism (
	SpeId INTEGER PRIMARY KEY AUTOINCREMENT,
	SpeName TEXT(40) UNIQUE NOT NULL,
	SpeStatus INTEGER NOT NULL,
	FOREIGN KEY (SpeStatus) REFERENCES Status(StaId)
);

CREATE TABLE Medic (
	MedId INTEGER PRIMARY KEY,
	MedEntryDate TEXT(16) NOT NULL,
	MedSpecialism INTEGER NOT NULL,
	MedStatus INTEGER NOT NULL,
	FOREIGN KEY (MedId) REFERENCES Person(PerId),
	FOREIGN KEY (MedSpecialism) REFERENCES Specialism(SpeId),
	FOREIGN KEY (MedStatus) REFERENCES Status(StaId)
);

CREATE TABLE Diagnosis (
	DiaId INTEGER PRIMARY KEY AUTOINCREMENT,
	DiaName TEXT(40) UNIQUE NOT NULL,
	DiaDescription TEXT(120) NOT NULL,
	DiaStatus INTEGER NOT NULL,
	FOREIGN KEY (DiaStatus) REFERENCES Status(StaId)
);

CREATE TABLE Patient (
	PatId INTEGER PRIMARY KEY,
	PatAdmissionDate TEXT(16) NOT NULL,
	PatDiagnosis INTEGER NOT NULL,
	PatComment TEXT(240),
	PatStatus INTEGER NOT NULL,
	FOREIGN KEY (PatId) REFERENCES Person(PerId),
	FOREIGN KEY (PatDiagnosis) REFERENCES Diagnosis(DiaId),
	FOREIGN KEY (PatStatus) REFERENCES Status(StaId)
);

CREATE TABLE GameDifficulty (
	DifId INTEGER PRIMARY KEY AUTOINCREMENT,
	DifName TEXT(16) NOT NULL,
	DifStatus INTEGER NOT NULL,
	FOREIGN KEY (DifStatus) REFERENCES Status(StaId)
);

CREATE TABLE Session (
	SesId INTEGER PRIMARY KEY AUTOINCREMENT,
	SesPatientId INTEGER NOT NULL,
	SesDate TEXT(16) NOT NULL,
	SesTime REAL NOT NULL,
	SesMeters REAL NOT NULL,
	SesCoins INTEGER NOT NULL,
	SesFails INTEGER NOT NULL,
	SesDifficulty INTEGER NOT NULL,
	SesStatus INTEGER NOT NULL,
	FOREIGN KEY (SesPatientId) REFERENCES Patient(PatId),
	FOREIGN KEY (SesDifficulty) REFERENCES GameDifficulty(DifId),
	FOREIGN KEY (SesStatus) REFERENCES Status(StaId)
);

CREATE TABLE MotionType (
	MotId INTEGER PRIMARY KEY AUTOINCREMENT,
	MotName TEXT(24) UNIQUE NOT NULL,
	MotDescription TEXT(36) NOT NULL,
	MotStatus INTEGER NOT NULL,
	FOREIGN KEY (MotStatus) REFERENCES Status(StaId)
);

CREATE TABLE HandMotion (
	HanId INTEGER PRIMARY KEY AUTOINCREMENT,
	HanSessionId INTEGER NOT NULL,
	HanThumbAngle REAL NOT NULL,
	HanIndexAngle REAL NOT NULL,
	HanMiddleAngle REAL NOT NULL,
	HanRingAngle REAL NOT NULL,
	HanPinkyAngle REAL NOT NULL,
	HanMotionType INTEGER NOT NULL,
	HanStatus INTEGER NOT NULL,
	FOREIGN KEY (HanSessionId) REFERENCES Session(SesId),
	FOREIGN KEY (HanMotionType) REFERENCES MotionType(MotId),
	FOREIGN KEY (HanStatus) REFERENCES Status(StaId)
);

CREATE TABLE GameConfig (
	ConId INTEGER NOT NULL,
	PatId INTEGER NOT NULL,
	Difficulty INTEGER NOT NULL,
	SesDate TEXT(16) NOT NULL
);
