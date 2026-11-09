# Aula 13 - RpgApi

API ASP.NET Core com Entity Framework Core e SQL Server.

## Configuração

1. Instale o SDK do .NET 10.
2. Copie appsettings.example.json para appsettings.json e configure sua conexão.
3. Prepare o banco com os scripts SQL do projeto, incluindo Script06_TabelaDisputas.sql.
4. Execute dotnet restore e dotnet run.

O Program.cs utiliza a conexão ConexaoSomee. As configurações locais com senhas não são versionadas.

## Disputas

POST /Disputas/Arma

    { "atacanteId": 3, "oponenteId": 4 }

POST /Disputas/Habilidade

    { "atacanteId": 5, "oponenteId": 2, "habilidadeId": 1 }

O atacante deve possuir a arma ou habilidade correspondente.

## Validação

A tabela de disputas foi criada e conferida no banco configurado durante a implementação.
A compilação e os testes HTTP ainda precisam ser executados em uma máquina com o SDK do .NET 10.
