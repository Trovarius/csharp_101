# Estudos de C#

Esse repositório foi criado com o intuito de compartilhar meu conhecimento de C# e .NET com outras pessoas

Esta divido inicialmente no Módulo 1 aonde exploro a base da linguagem.

## Pré requisitos

Para seguir com o curso basta baixar um editor de código de sua prefreência, sendo que atualmente minha recomendação é o [VsCode](https://code.visualstudio.com/) e
o [SDK do .NET CORE](https://www.microsoft.com/net/learn/get-started/windows);


## Criando projetos

Os projetos devem ser criados utilizando a linha de comando cmd (windows) ou bash (linux).


## Glossario

### Extensões

* **csproj** - arquivo que possui as configurações do projeto, utilizados pela IDE e compiladores (MSBUILD) para compilar todos os arqivos presentes no projeto de maneira correta
* **dll** - Arquivos gerados contendo o binário do código fonte do projeto, normalmente levam o mesmo nome da pasta do projeto
* **pdb** - esses aquivos são os pontos de debug de cada dll, são utilizados pela IDE para permitir que o desenvolvedor possa debugar passo-a-passo o que esta acontecendo dentro do programa.

### Pastas

* **bin** - pasta contendo os binários da aplicação após a compilação
    * **Debug** - pasta contendo os arquivos binários compilados no formato de DEBUG
    * **Release** - pasta contendo os arquivos binários compilados no formato de Release (esses arquivos serão levados a produção)
