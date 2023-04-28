### cs_20231
Repositório definido para a manutenção do controle de versão dos artefatos do projeto de construção de uma API Rest para:

*O projeto tem como propósito ser um sistema simplificado e seguro de agendamento de vacinas, que permite que usuários cadastrados consigam facilmente agendar suas vacinas em todas as suas doses e de forma bem automatizada. Além disso, o sistema permite que os administradores consigam monitorar todo o sistema, cadastrar novas vacinas, alergias, usuários e administrar os agendamentos feitos pelos usuários.*

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
```
 1. Cadastro de usuário - Permite que um novo usuário se cadastre no sistema informando seus dados pessoais, como nome, e-mail, senha, data de nascimento, telefone, entre outros.
 2. Cadastro de usuário administrador - Permite que um novo usuário seja cadastrado como administrador do sistema, com acesso a recursos adicionais, como a capacidade de gerenciar usuários, vacinas, alergias e agendamentos.
 3. Exclusão de usuário - Permite que um usuário seja removido do sistema, juntamente com todas as suas informações e registros associados.
 4. Listagem de usuários - Permite que um usuário administrador visualize uma lista de todos os usuários cadastrados no sistema, incluindo suas informações pessoais e de contato.
 5. Cadastro de vacina - Permite que um usuário administrador registre uma nova vacina no sistema, incluindo informações como nome, fabricante, data de  fabricação, data de validade e dosagem.
6. Exclusão de vacina - Permite que um usuário administrador remova uma vacina do sistema, juntamente com todas as informações associadas.
7. Listagem de vacinas - Permite que um usuário visualize uma lista de todas as vacinas cadastradas no sistema, juntamente com suas informações e disponibilidade.
8. Cadastro de alergia - Permite que um usuário registre uma nova alergia no sistema, incluindo informações como nome, descrição e gravidade.
9. Exclusão de alergia - Permite que um usuário remova uma alergia do sistema, juntamente com todas as informações associadas.
10. Listagem de alergias - Permite que um usuário visualize uma lista de todas as alergias cadastradas no sistema, juntamente com suas informações.
11. Cadastro de agendamento - Permite que um usuário agende uma vacinação informando informações como nome, data de nascimento, e-mail, telefone, alergias, entre outros.
12. Exclusão de agendamento - Permite que um usuário administrador remova um agendamento do sistema, juntamente com todas as informações associadas.
13. Listagem de agendamentos - Permite que um usuário administrador visualize uma lista de todos os agendamentos cadastrados no sistema, juntamente com suas informações.
14. Listagem de agendamentos por situação - Permite que um usuário administrador visualize uma lista de todos os agendamentos cadastrados no sistema, filtrando-os por situação, como "aguardando confirmação", "confirmado" e "cancelado".
15. Listagem de agendamentos por data - Permite que um usuário administrador visualize uma lista de todos os agendamentos cadastrados no sistema, filtrando-os por data de agendamento.
``` 
### Requisitos Não Funcionais
- Segurança: segurança deve assegurar a segurança dos dados
- Usabilidade: deve ser simples de usar, já que pessoas com menos conhecimento devem conseguir utilizar o sistema

### Regras de Negócio
```
 1. Ao fazer o agendamento de uma vacina com mais de uma dose, o agendamento das doses subsequentes já é feito automaticamente de acordo com a periodicidade da vacina

 2. Caso o usuário tenha alergia a vacina a qual ele está tentando fazer o agendamento, ele deve ser impedido de fazer esse agendamento

 3. Não é possível que um administrador remova um agendamento que esteja com situação diferente de Agendado

 4. Usuários administradores são os únicos que podem criar outros usuários administradores

 5. A idade do usuário deve ser verificada ao tentar fazer um agendamento, pois a vacina tem idade mínima

 6. Quando um usuário administrador remove um agendamento, todos os agendamentos subsequentes para aquela vacina daquele usuário são removidos também

 7. O usuário não pode agendar uma vacina para a qual ele já tem agendamentos
```

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
O deploy será feito nas plataformas Vercel e Heroku. Tanto a Vercel quanto o Heroku são plataformas de nuvem que permitem aos desenvolvedores implantar, executar e dimensionar aplicativos web de maneira rápida e fácil, sem precisar lidar com a complexidade da infraestrutura de hospedagem e gerenciamento de servidores. A Vercel é uma plataforma de computação em nuvem focada em implantação de sites e aplicativos front-end. Ela é otimizada para projetos baseados em JAMstack, que são aplicativos web que usam JavaScript, APIs e tecnologias de marcação para renderizar o conteúdo no lado do cliente. A Vercel permite aos desenvolvedores implantar aplicativos em segundos, além de oferecer integração com ferramentas de desenvolvimento populares, como o GitHub, GitLab e Bitbucket.Já o Heroku é uma plataforma de nuvem mais ampla que suporta uma ampla variedade de aplicativos web e móveis. Ele é otimizado para linguagens de programação populares, como Ruby, Node.js, Python e Java, além de oferecer suporte a bancos de dados, cache, filas de mensagens e outros recursos. O Heroku é fácil de usar, tem suporte a vários fornecedores de banco de dados e oferece escalabilidade horizontal (adicionando mais instâncias do servidor) e vertical (aumentando os recursos do servidor). Ambas as plataformas oferecem recursos de dimensionamento automático, escalabilidade horizontal e vertical, integração contínua e entrega contínua (CI/CD) e recursos de monitoramento e alerta para ajudar a garantir que os aplicativos sejam confiáveis e escaláveis. 


### Cronograma de Desenvolvimento

|Iteração|Tarefa|Data Início|Data Fim|Responsável|Situação|
|---|---|---|---|---|---|
|1|Especificar História de Usuário 1|02/05/2023|03/05/2023|Mozaniel|Programada|
