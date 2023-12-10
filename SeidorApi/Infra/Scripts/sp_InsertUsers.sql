CREATE PROCEDURE sp_InsertUsers
    (
    @id     INT,
    @email  VARCHAR(100) ,
    @senha  VARCHAR(10) ,
    @nome   VARCHAR(50) 
)
AS
BEGIN
    INSERT INTO Usuarios
    VALUES (@email, @senha, @nome)
END;