CREATE PROCEDURE sp_EditUsers
(
    @id     INT,
    @email  VARCHAR(100) = NULL,
    @senha  VARCHAR(10) = NULL,
    @nome   VARCHAR(50) = NULL
)
AS
BEGIN
    UPDATE Usuarios
    SET
    Email = @email,
    Senha = @senha,
    Nome = @nome
    WHERE Id = @id
END;