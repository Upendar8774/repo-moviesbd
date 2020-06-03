 CREATE TABLE Actor(ActorID INT IDENTITY(1,1) PRIMARY KEY,Name NVARCHAR(50),Sex NVARCHAR(20),Dob DATETIME,Bio NVARCHAR(MAX))

 CREATE TABLE Movie(MovieID INT IDENTITY(1,1) PRIMARY KEY,Name NVARCHAR(50),YoR DATETIME,Plot NVARCHAR(MAX))

 CREATE TABLE Producer(ProducerID INT IDENTITY(1,1) PRIMARY KEY,Name NVARCHAR(50),Sex NVARCHAR(20),Dob DATETIME,Bio NVARCHAR(MAX))

  CREATE TABLE FilmDetails(FilmId INT IDENTITY(1,1) Primary Key,ActorId INT Foreign key References Actor(ActorID),MovieID INT Foreign key References Movie(MovieID),
  ProducerID INT Foreign key References Producer(ProducerID))


