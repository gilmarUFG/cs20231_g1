### cs_20231
Repositório definido para a manutenção do controle de versão dos artefatos do projeto de construção de uma API Rest para:

**<descrever o propósito da API>**.

### Grupo
Esta API será construída pelos componentes do grupo 1:

|Matrícula|Nome|Usuário Git|
|---|---|---|
|201905528|Felipe Ramos Kafuri|[felipekafuri](https://github.com/felipekafuri)|
|202108000|Gabriel Milhomen Cunha|[]()|
|201905534|Igor Pimenta Araújo|[igor-pimenta-araujo](https://github.com/igor-pimenta-araujo)|
|202204196|João Pedro Silva Franco|[joaopedrosf](https://github.com/joaopedrosf)|
|202004773|Mozaniel Pereira Silva Correia|[MozanielPSC](https://github.com/MozanielPSC)|

### Requisitos Funcionais
1. Cadastro de usuário - <descrever>
2. Cadastro de usuário administrador - <descrever>
3. Exclusão de usuário
4. Listagem de usuários
5. Cadastro de vacina
6. Exclusão de vacina 
7. Listagem de vacinas
8. Cadastro de alergia
9. Exclusão de alergia
10. Listagem de alergias
11. Cadastro de agendamento
12. Exclusão de agendamento
13. Listagem de agendamentos
14. Listagem de agendamentos por situação
15. Listagem de agendamentos por data

### Requisitos Não Funcionais
- Segurança: segurança deve assegurar a segurança dos dados
- Usabilidade: deve ser simples de usar, já que pessoas com menos conhecimento devem conseguir utilizar o sistema

### Regras de Negócio

 1. Ao fazer o agendamento de uma vacina com mais de uma dose, o agendamento das doses subsequentes já é feito automaticamente de acordo com a periodicidade da vacina

 2. Caso o usuário tenha alergia a vacina a qual ele está tentando fazer o agendamento, ele deve ser impedido de fazer esse agendamento

 3. Não é possível que um administrador remova um agendamento que esteja com situação diferente de Agendado

 4. Usuários administradores são os únicos que podem criar outros usuários administradores

 5. A idade do usuário deve ser verificada ao tentar fazer um agendamento, pois a vacina tem idade mínima

 6. Quando um usuário administrador remove um agendamento, todos os agendamentos subsequentes para aquela vacina daquele usuário são removidos também

 7. O usuário não pode agendar uma vacina para a qual ele já tem agendamentos

<Adicionar outras regras, se existirem.>

### Tecnologia de _Front-end_
## VueJS
VueJS é um framework JavaScript de código aberto usado para construir interfaces de usuário interativas e dinâmicas que permite criar interfaces de usuário reativas, semelhantes às de aplicativos nativos, usando uma sintaxe simples e intuitiva. Ele também possui recursos avançados, como componentes personalizados, renderização do lado do servidor, roteamento e gerenciamento de estado.

### Tecnologia de _Back-end_
## C#
C# é uma linguagem de programação orientada a objetos, criada pela Microsoft em 2000 como parte da plataforma .NET Framework. Ela foi projetada para ser moderna, segura, simples, eficiente e escalável, permitindo que os desenvolvedores criem aplicativos para uma ampla gama de dispositivos e sistemas operacionais. O C# tem como suas características:

    - Forte tipagem de dados;
    - Suporte a programação orientada a objetos;
    - Tratamento de exceções robusto;
    - Garbage Collection (coleta automática de lixo);
    - Polimorfismo;
    - Delegados e eventos para programação assíncrona;
    - Suporte a LINQ (Language Integrated Query), uma tecnologia para realizar consultas em coleções de dados.

### Tecnologia de Persistência de Dados
## PostgreSQL
Postgres, é um sistema de gerenciamento de banco de dados relacional (RDBMS) de código aberto conhecido por sua capacidade de lidar com grandes volumes de dados e suportar uma ampla gama de recursos, incluindo transações ACID (Atomicidade, Consistência, Isolamento e Durabilidade), triggers, stored procedures, replicação, controle de concorrência, índices avançados, além de extensões personalizadas que permitem aos usuários adicionar funcionalidades específicas ao banco de dados. Também possui suporte nativo para tipos de dados avançados, como arrays, JSON, XML, geoespaciais e outros. Além disso, o PostgreSQL tem suporte para várias linguagens de programação, incluindo SQL, Python, Perl, Tcl, C/C++, entre outras.
<Descrever a tecnologia que será utilizada para Persistência de dados.>

### Local do _Deploy_
<Descrever onde será feito o _deploy_ da API.>

### Cronograma de Desenvolvimento

|Iteração|Tarefa|Data Início|Data Fim|Responsável|Situação|
|---|---|---|---|---|---|
|1|Especificar História de Usuário 1|02/05/2023|03/05/2023|Mozaniel|Programada|
