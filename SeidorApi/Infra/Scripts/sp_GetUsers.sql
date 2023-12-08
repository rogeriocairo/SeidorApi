CREATE PROCEDURE sp_GetUsers
(
    @email  VARCHAR(100) = NULL,
    @senha  VARCHAR(10) = NULL
)
AS
BEGIN
    SELECT
        usu.Id,
        usu.Email,
        usu.Senha,
        usu.Nome
    FROM
        Usuarios usu
    WHERE
        (Email = @email OR @email is null) and
        (Senha = @senha OR @senha is null) 
END;