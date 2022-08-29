CREATE DATABASE RequestData;
GO

USE HiringRequestDB;
GO

CREATE TABLE HiringRequests (
  Id int, 
  RequestNumber nvarchar(100), 
  HiringOrganization nvarchar(100), 
  HiringOfficial nvarchar(100), 
  Source bit,
  RequestType int,
  CreatedDate DATETIME,
  LastModifiedDate DATETIME
);
GO

INSERT INTO HiringRequests (Id, RequestNumber, HiringOrganization, HiringOfficial, Source, RequestType, CreatedDate, LastModifiedDate)
VALUES (1,'TEST-15465-1','Hiring Office One','Sample User-One',0,1,'2022-08-25 00:00:00.000','2022-08-26T00:00:00.000');
GO

INSERT INTO HiringRequests (Id, RequestNumber, HiringOrganization, HiringOfficial, Source, RequestType, CreatedDate, LastModifiedDate)
VALUES (2,'TEST-15465-2','Hiring Office Two','Sample User-Two',0,1,'2022-08-25 00:00:00.000','2022-08-26T00:00:00.000');
GO

INSERT INTO HiringRequests (Id, RequestNumber, HiringOrganization, HiringOfficial, Source, RequestType, CreatedDate, LastModifiedDate)
VALUES (3,'TEST-15465-3','Hiring Office Three','Sample User-Three',0,1,'2022-08-25 00:00:00.000','2022-08-26T00:00:00.000');
GO

INSERT INTO HiringRequests (Id, RequestNumber, HiringOrganization, HiringOfficial, Source, RequestType, CreatedDate, LastModifiedDate)
VALUES (4,'TEST-15465-4','Hiring Office Four','Sample User-Four',0,1,'2022-08-25 00:00:00.000','2022-08-26T00:00:00.000');
GO

INSERT INTO HiringRequests (Id, RequestNumber, HiringOrganization, HiringOfficial, Source, RequestType, CreatedDate, LastModifiedDate)
VALUES (5,'TEST-15465-5','Hiring Office Five','Sample User-Five',0,1,'2022-08-25 00:00:00.000','2022-08-26T00:00:00.000');
GO

INSERT INTO HiringRequests (Id, RequestNumber, HiringOrganization, HiringOfficial, Source, RequestType, CreatedDate, LastModifiedDate)
VALUES (6,'TEST-15465-LF-6','Hiring Office Six','Sample User-Six',0,1,'2022-08-25 00:00:00.000','2022-08-26T00:00:00.000');
GO