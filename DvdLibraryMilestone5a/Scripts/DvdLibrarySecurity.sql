USE master
GO

CREATE LOGIN DvdLibraryApp WITH PASSWORD = 'testing123'
GO

USE DvdLibrary
GO
 
CREATE USER DvdLibraryApp FOR LOGIN DvdLibraryApp
GO

CREATE ROLE db_executor

GRANT EXECUTE TO db_executor

ALTER ROLE db_executor ADD MEMBER DvdLibraryApp

GRANT SELECT ON Dvds TO DvdLibraryApp
GRANT INSERT ON Dvds TO DvdLibraryApp
GRANT UPDATE ON Dvds TO DvdLibraryApp
GRANT DELETE ON Dvds TO DvdLibraryApp
GO