

# Mercado Chapadão - Projeto Integrador II UNIVESP

Desenvolvimento do Projeto Integrador (PI) da Universidade Virtual do Estado de São Paulo (UNIVESP). O Projeto Integrador é uma atividade curricular obrigatória que visa a resolução de problemas reais, contextualizados dentro da área profissional dos cursos da aréa de tecnoligia colocando alunos em grupos de 8 participantes para trabalharem em equipe, a equipe deste projeto tem seus 8 participantes trabalhando em conjunto de forma remota.

A cada semestre, o tema do PI é alterado, porém a metodologia se mantém constante. Em grupo, os estudantes identificam um problema relacionado ao tema proposto e desenvolvem uma solução prática, aplicando os conhecimentos adquiridos nas disciplinas cursadas até o momento.

Durante o semestre, os alunos têm autonomia para pesquisar, organizar e desenvolver o projeto, recebendo orientação semanal de um professor orientador. O projeto está estruturado em cinco etapas:

1. **Ouvir**  
2. **Definir**  
3. **Idear**  
4. **Prototipar**  
5. **Testar**


## **Esclarecendo o projeto**

Esse projeto tem como objetivo cadastrar e lista produtos do estabelecimento.
Dentre as funcionalidades, é possível criar, editar, visualizar e excluir produtos, além de exibir uma lista de produtos com informações em estoque.

## Funcionalidades

- Listar produtos
- Adicionar novo produto
- Editar produto existente
- Deletar produto
- Exibir detalhes do produto

## Tecnologias Utilizadas

- ASP.NET Core
- Entity Framework Core
- Razor Pages
- SQL Server

## Pré-requisitos

Antes de começar, certifique-se de ter o seguinte instalado em sua máquina:

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads)
- [Visual Studio](https://visualstudio.microsoft.com/) (ou outro IDE de sua preferência)

## Instalação

Siga os passos abaixo para configurar o projeto em sua máquina local:

## 1. **Clone o repositório:**

 **Instale o Git**
Se ainda não tiver o Git instalado, baixe e instale [aqui](https://git-scm.com/). Ele permite que você copie projetos do GitHub para sua máquina.

 **Clone o projeto para sua máquina**

Abra o terminal (ou prompt de comando no Windows) e execute o seguinte comando para copiar o projeto (precisa copiar toda a linha para dar o comando git clone):

git clone https://github.com/Fernando-A-Ferraz/Projeto-Integrador-Univesp


## 2. **Configure o banco de dados:**

   - No diretório do projeto, você encontrará um arquivo chamado appsettings.json. Abra este arquivo com um editor de texto (como o Notepad ou Visual Studio Code).

Encontre a parte com "ConnectionStrings" e substitua as informações por suas credenciais de banco de dados do SQL Server:
   
   ConnectionStrings:
   { 
      DefaultConnection: Server=SEU_SERVIDOR;Database=MercadinhoChapadao;User Id=SEU_USUARIO;Password=SUA_SENHA;
   }

## 3. Instale o .Net Framework

No terminal voce digital

dotnet tool install --global dotnet-ef


## 4. **Execute as migrações do Entity Framework:**

Para configurar o banco de dados, você precisa aplicar as migrações. No terminal (ainda dentro da pasta do projeto), execute o seguinte comando:

   dotnet ef database update
   


## 5. **Execute a aplicação:**

Para rodar o projeto, use o seguinte comando no terminal:

   dotnet run
   
## 6. **Acesse a aplicação:**

   Após a aplicação iniciar, abra seu navegador e vá para:
   
 http://localhost:5192
   
 

     

   
   

   
