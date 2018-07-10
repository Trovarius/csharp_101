# Estudos de C#

Esse repositório foi criado com o intuito de compartilhar meu conhecimento de C# e .NET com outras pessoas

Esta divido inicialmente no Módulo 1 aonde exploro a base da linguagem.

## Pré requisitos

Para seguir com o curso basta baixar um editor de código de sua prefreência, sendo que atualmente minha recomendação é o [VsCode](https://code.visualstudio.com/) e
o [SDK do .NET CORE](https://www.microsoft.com/net/learn/get-started/windows);


## Criando projetos

* Crie uma pasta pa o seu projeto
* Dentro da pasta abara o terminal CMD (Windows) ou Bash (Linux)
* execute o comando 
    > dotnet new console 
* um projeto do tipo console será criado com o nome da pasta

### Extensões dos arquivos

* **csproj** - arquivo que possui as configurações do projeto, utilizados pela IDE e compiladores (MSBUILD) para compilar todos os arqivos presentes no projeto de maneira correta
* **dll** - Arquivos gerados contendo o binário do código fonte do projeto, normalmente levam o mesmo nome da pasta do projeto
* **pdb** - esses aquivos são os pontos de debug de cada dll, são utilizados pela IDE para permitir que o desenvolvedor possa debugar passo-a-passo o que esta acontecendo dentro do programa.

### Pastas de um projeto

* **bin** - pasta contendo os binários da aplicação após a compilação
    * **Debug** - pasta contendo os arquivos binários compilados no formato de DEBUG
    * **Release** - pasta contendo os arquivos binários compilados no formato de Release (esses arquivos serão levados a produção)

## Objetivo - Modulo 1

## Topicos
### Dia 1
* Tipos Básicos: NUMBER(INT, FLOAT, DECIMAL), STRING, BOOL, ENUM, Arrays, metodos, DateTime
* Loops: While, Do..While, For, ForEach, Switch, if
* Exercicios: AreaObjeto, Concatenação String, Condicional, Leitura de Array
* Unit Test: inicio

### Dia 2
* ATM : Criação com testes unitários
* Genric: List, Dictionary, NameValueCollection
* Nullable

### Dia 3
* OO (ATM) : Criação de classes, acessibilidade de objetos, herança, overload, polimorfismo

### Dia 4
* OO (ATM) : Validações com OO, Separação de conceitos, estrutura de código

### Dia 5
* Dojo: Escolher o problema