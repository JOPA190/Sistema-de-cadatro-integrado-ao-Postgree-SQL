# Cadastro de Clientes com PostgreSQL e C#

Este projeto consiste em uma aplicação Windows Forms desenvolvida em C# para o cadastro, consulta, alteração e exclusão de clientes em um banco de dados PostgreSQL. O sistema interage diretamente com a base de dados e realiza validações básicas de entrada.

---

## Funcionalidades  

A aplicação oferece as seguintes funcionalidades:

- **Inserir Cliente:**  
  - Adiciona um novo cliente no banco de dados.  
  - Valida o CPF antes da inserção e verifica se já existe um cliente cadastrado com o mesmo CPF.  

- **Consultar Cliente:**  
  - Busca um cliente pelo CPF e exibe os dados nos campos do formulário.  

- **Alterar Cliente:**  
  - Permite modificar os dados do cliente selecionado e atualizá-los no banco de dados.  

- **Excluir Cliente:**  
  - Remove o cliente do banco de dados após confirmação.  

---

## Tecnologias Utilizadas  

As principais tecnologias utilizadas neste projeto são:  

- **Linguagem de Programação:** C# (Windows Forms).  
- **Banco de Dados:** PostgreSQL.  
- **Biblioteca:** Npgsql (para conectar e executar comandos no PostgreSQL).  

---

## Configuração e Execução  

Para configurar e executar o projeto, siga as etapas abaixo:

### 1. Clonar o Repositório  
```bash  
git clone <URL_DO_REPOSITORIO>  
cd <NOME_DA_PASTA>  
# Cadastro de Clientes com PostgreSQL e C#

Este projeto consiste em uma aplicação Windows Forms desenvolvida em C# para o cadastro, consulta, alteração e exclusão de clientes em um banco de dados PostgreSQL. O sistema interage diretamente com a base de dados e realiza validações básicas de entrada.

---

## Funcionalidades  

A aplicação oferece as seguintes funcionalidades:

- **Inserir Cliente:**  
  - Adiciona um novo cliente no banco de dados.  
  - Valida o CPF antes da inserção e verifica se já existe um cliente cadastrado com o mesmo CPF.  

- **Consultar Cliente:**  
  - Busca um cliente pelo CPF e exibe os dados nos campos do formulário.  

- **Alterar Cliente:**  
  - Permite modificar os dados do cliente selecionado e atualizá-los no banco de dados.  

- **Excluir Cliente:**  
  - Remove o cliente do banco de dados após confirmação.  

---

## Tecnologias Utilizadas  

As principais tecnologias utilizadas neste projeto são:  

- **Linguagem de Programação:** C# (Windows Forms).  
- **Banco de Dados:** PostgreSQL.  
- **Biblioteca:** Npgsql (para conectar e executar comandos no PostgreSQL).  

---

## Configuração e Execução  

Para configurar e executar o projeto, siga as etapas abaixo:

### 1. Clonar o Repositório  
- Abra o terminal e execute os seguintes comandos:  
  ```bash  
  git clone <URL_DO_REPOSITORIO>  
  cd <NOME_DA_PASTA>

### 2. Configurar o Banco de Dados

- **Certifique-se de que o PostgreSQL está instalado e em execução.**
- **Crie o banco de dados e configure a tabela:**

  Execute o seguinte comando SQL para criar a tabela `clientes`:

  ```sql
  CREATE TABLE clientes (
    cpf VARCHAR(14) PRIMARY KEY,
    nome VARCHAR(100),
    telefone VARCHAR(15),
    email VARCHAR(100),
    dn DATE
  );
public string strCon = "Server=localhost;Port=5432;Username=postgres;password=root;Database=bancox";
Nota: Modifique Username, password e Database conforme a configuração do seu PostgreSQL.
### 3. Executar o Projeto

1. **Abra o projeto no Visual Studio.**
2. **Restaure os pacotes NuGet se necessário:**
   - Certifique-se de que o pacote `Npgsql` esteja instalado para conectar ao PostgreSQL. Você pode restaurar os pacotes NuGet pelo Visual Studio ou pelo terminal com o comando:

     ```bash
     dotnet restore
     ```


3. **Compile e execute o projeto:**
   - Após restaurar os pacotes e configurar o banco de dados, compile e execute o projeto diretamente no Visual Studio.
