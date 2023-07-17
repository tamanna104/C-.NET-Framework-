/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [ID]
      ,[Name]
      ,[Email]
      ,[TimeSc]
  FROM [petShop].[dbo].[Vet]

  DROP table Vet