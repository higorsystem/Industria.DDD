[![Build Status](https://travis-ci.org/thiagodp/concordialang.svg?branch=master)](https://travis-ci.org/higorsystem/Industria.DDD)
![GitHub last commit](https://img.shields.io/github/last-commit/higorsystem/starwars-api.svg)(https://github.com/higorsystem/Industria.DDD/releases)
[![npm](https://img.shields.io/badge/licen%C3%A7a-MIT-green.svg)](https://github.com/higorsystem/Industria.DDD/blob/master/LICENSE.txt)

# Industria.DDD

> Projeto utilizando a estrutura DomainDriven Design com banco de dados SQL Server.

## Configuração
### 1) Rode os comandos abaixo na raiz do projeto.
```bash
dotnet restore
```
```bash
dotnet build
```

### 2) - Configure o Contexto para sua conexão com SQLServer.
![imagem](https://i.ibb.co/4WJ63dM/contexto.jpg)

### 3) - Após entre no diretório "../src/4 - Infra/4.1 - Data/Industria.Data" e rode o comando abaixo.

**Windows**
```bash
dotnet ef database update
```
- Desta forma irá ativa o migration que criará toda a estrutura.

## Exemplo de consumo da API Industria

### 1) Cadastra um contrato na API
![imagem](https://i.ibb.co/Nm0LNd3/cadastra.jpg)

### 2) Altera um contrato na API pelo seu identificador.
![imagem](https://i.ibb.co/qdGnpKX/Altera-Um-Contrato.jpg)

### 3) Obtém um contrato na API pelo seu identificador.
![imagem](https://i.ibb.co/KbzWmgJ/Obtem-Por-Id.jpg)

### 4) Obtém todos os contratos cadastrados na API.
![imagem](https://i.ibb.co/PxrKhr8/Obter-Todos.jpg)

### 5) Deleta um contrato pelo seu identificador
![imagem](https://i.ibb.co/pyvzzsN/delete.jpg)

## Dúvidas?

- Entre em contato pelo e-mail: jorge.higor@gmail.com

