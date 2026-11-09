-- Aula 13: tabela criada diretamente no SQL Server, sem migração.
-- Pode ser executado novamente sem apagar disputas existentes.
IF OBJECT_ID(N'dbo.TB_DISPUTAS', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.TB_DISPUTAS
    (
        Id INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_TB_DISPUTAS PRIMARY KEY,
        Dt_Disputa DATETIME NULL,
        AtacanteId INT NOT NULL,
        OponenteId INT NOT NULL,
        Tx_Narracao VARCHAR(MAX) NOT NULL
    );
END;
