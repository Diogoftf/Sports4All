# Sports4All
![GitHub Logo](/RMImages/startImage.png)

## Introdução
Neste projeto pretende-se desenvolver um sistema tendo em conta os padrões e as boas práticas de software, para a unidade curricular de Desenho e Implementação de Software. Para o sistema apresentado e tendo em conta a unidade curricular em que o mesmo se enquadra foram utilizados os seguintes padrões: Singleton, State, Decorator e Strategy.

O sistema é intitulado por Sports4All e tem como objetivo melhorar a atividade física dos utilizadores e assim evitar o sedentarismo. Para isso, é possível o utilizador criar uma reserva em um parque desportivo e posteriormente outros utilizadores podem ingressar no evento. Para proporcionar maior adesão, o sistema inclui um sistema de pontos que irá permitir classificar utilizadores e recintos, criando assim uma componente de gamificação entre os utilizadores. Isto permite que a nossa comunidade tenha noção de quais são os melhores parques e utilizadores.

O sistema descrito foi desenvolvido tendo em conta o utilizador final, isto é, utilizadores que pretendem criar reservas ou participar em eventos, ignorando assim, outras entidades ou aspetos técnicos: gestão dos horários, stock de materiais, etc. Neste sentido, a aplicação foi desenvolvida para desktop (Windows Forms Application).
Ao longo deste relatório serão abordados os principais tópicos relacionados com o desenvolvimento deste projeto, entre estes, as motivações para o desenvolvimento desta solução, a descrição do sistema que inicialmente será mais geral e depois se centrará em aspetos mais técnicos como o modelo da base de dados, a linguagem de programação e tecnologias utilizadas, a arquitetura geral do sistema e os padrões de desenho utilizados.


## Necessidade/Oportunidade Identificada
De acordo com algumas pesquisas, os portugueses são dos que menos praticam exercício na Europa e fazem cada vez menos exercício físico, seja por falta de tempo, interesse ou motivação [1][2].

![GitHub Logo](/RMImages/resultado.png)

Muitas vezes, um factor que contribui para o sedentarismo é pelo facto de não termos pessoas suficientes para irem conosco.


## Solução Proposta
Para o problema apresentado, resolvemos propor, como solução, um sistema desktop, que permite encontrar outras pessoas que queiram praticar o mesmo desporto, podendo combinar entre si um local e horário apropriado. A aplicação permite a criação de eventos e a ingressão nos mesmos (caso não seja o utilizador que criou o evento). 

Como objetivo principal, pretendemos promover a realização de exercício físico e a componente social.

## Descrição do Sistema

O sistema tem como alvo principal de negócio todos os parques desportivos na região autónoma da Madeira, funcionando em paralelo com o modelo de reservas existentes em complexos desportivos. Um dos propósitos da construção deste sistema é aumentar as taxas de adesão à realização de desportos, evitar o sedentarismo e aprimorar as condições físicas dos utilizadores.

O objetivo principal consiste em promover a componente social e a realização de exercício físico, através da criação de reservas para a realização de desporto, sendo que estas reservas podem ser aplicadas sobre complexos desportivos públicos ou privados.
Uma das funcionalidades deste sistema é o facto dos utilizadores poderem consultar informações sobre o evento como o número de participantes, idade mínima/máxima permitida, entre outros. Este controlo é efetuado aquando da criação da reserva. O proprietário pode definir as condições necessárias para poder ingressar no evento. Finalizado o evento, os utilizadores podem avaliar não só os utilizadores inscritos no evento como o parque desportivo onde o mesmo ocorreu.
O modelo de negócio subjacente a este sistema poderia ser através de contas premium, publicidades ou parcerias com recintos desportivos.

### Funcionalidades do sistema

Abaixo listam-se algumas das funcionalidades da aplicação:
* Registo de utilizadores;
* Criação de eventos (indicando o nome, desporto, parque desportivo, materiais (opcionais), data do evento, hora de início e de sim, quantidade máxima de jogadores e idade mínima e máxima de jogadores) no modo iniciante e no modo expert;
* Edição de um evento (caso tenha sido um evento criado pelo utilizador);
* Ingressão em eventos;
* Avaliação após evento (cada utilizador avalia os utilizadores e o parque desportivo do evento em que ingressou);
* Visualização da informação de cada evento;
* Visualização de informação de cada parque desportivo;
* Procurar eventos por desporto;
* Procurar parques desportivos por localização;
* Pontuação de utilizadores (consoante o número de eventos em que participou, número de eventos criados, avaliações recebidas);
* Pontuação de parques (consoante as avaliações recebidas);
* Visualização de estatísticas;
* Destaques semanais (de utilizador e de parque desportivo).

### Modelo
O Sports4All encontra-se dividido nas seguintes camadas, semelhante ao modelo MVVM (Model View ViewModel): 

![GitHub Logo](/RMImages/model.png)

* **View**: relacionada com a apresentação da aplicação (camada com a qual o utilizador interage);
* **ViewModel**: atua como conversor de dados, transformando os dados do Model de modo a serem utilizados pela View. É também responsável por passar comandos da View para o Model. Deste modo, ajuda a manter o estado da View e atualiza o Model de acordo com as ações do utilizador;
* **Model**: objetos/dados a partir do qual serão realizadas as operações com a base de dados.

### Modelo da Base de Dados
![GitHub Logo](/RMImages/EFDiagram.bmp)

## Frameworks Utilizadas

### Entity Framework (SQL SERVER da Azure)
Para o desenvolvimento do projeto, foi utilizado o Entity Framework que permite trabalhar com uma base de dados através de objetos .NET [3].

O Entity permite realizar o mapeamento dos elementos da base de dados para os elementos de nossa aplicação orientada a objetos, possuindo três linhas principais de utilização: Database First, Model First e Code First. No projeto abordamos a utilização do Code First, sobre o qual foi possível descrever as classes, para posteriormente o entity framework, gerar automaticamente a base de dados.

### Fluent API
No projeto utilizou-se o Fluent API e Entity Framework Code First, para realizar o mapeamento relacional, sendo que o Fluent API oferece mais funcionalidades comparado com Data Annotations.

## Padrões de desenho
Um padrão é uma solução para um problema num contexto. O contexto é a situação para a qual o padrão se aplica e deve ser uma situação recorrente. O problema é o objetivo que estamos a tentar atingir, mas também os constrangimentos que ocorrem no contexto. A solução é um desenho geral que podemos aplicar para atingir o objectivo e resolver os constrangimentos [4]

### Padrão de Criação
Os Padrões de Criação envolvem a instanciação de objetos e oferecem uma forma de desligar o cliente dos objectos que necessita instanciar. Auxilia a construção de sistemas flexíveis e abstrai o processo de instanciação, ajudando a tornar o sistema independente  quanto à forma como os objetos são criados, compostos e representados.

#### Singleton
Assegura que uma classe só possui uma instância e proporciona um acesso global a essa instância.

No nosso projeto, o Singleton foi utilizado para armazenar informações do utilizador autenticado (Session.cs), para o formulário principal da aplicação (Form1.cs) e na classe EventCreationManager.cs, responsável pela criação de eventos (no caso em que o utilizador é do tipo Novato).

### Padrão Estrutural
Os Padrões Estruturais permitem compor classes e objetos em estruturas maiores.

#### Decorator
Permite anexar responsabilidades a um objeto dinamicamente.

No nosso projeto, aquando da criação de uma reserva, o utilizador pode adicionar materiais ou definir o número de horas do evento, posteriormente o objeto reserva é decorado, aumentando dinamicamente o preço associado à reserva.

### Padrão Comportamental
Os Padrões de Comportamento estão relacionados com a forma como as classes e objetos interagem e distribuem as responsabilidades.

#### Strategy
Este padrão de desenho permite definir uma família de algoritmos, colocar cada um deles numa classe separada e tornar os seus objetos permutáveis.

O padrão strategy deve ser usado quando são necessárias variantes de um algoritmo. No nosso projeto, o padrão foi utilizado para o processo de criação de eventos que possui duas variantes:
* Criação de evento por parte de um utilizador experiente;
* Criação de evento por parte de utilizador novato.

![GitHub Logo](/RMImages/strategy.png)

### State
Permite que um objeto altere o seu comportamento quando o seu estado interno for alterado [5]. No projeto, o state foi utilizado para os diferentes estados (ecrãs) da criação de um evento por parte de um utilizador novato:

![GitHub Logo](/RMImages/state.png)

## Preocupações de Desenho
A utilização do modelo semelhante ao MVVM apresentado anteriormente, possibilita que tenhamos uma separação de responsabilidades entre camadas de aplicações. Com a utilização deste modelo a migração para outra aplicação (por exemplo mobile app) estaria facilitada. Além disso caso venhamos a precisar de utilizar uma outra interface esta alteração seria feita de forma fluida uma vez que a lógica de negócio e os dados estão separados.

A utilização do padrão Singleton permite uma redução do consumo de memória desnecessário da utilização de várias instâncias de uma classe. Assim, como apenas temos uma instância da classe temos também mais controlo sobre o acesso às propriedades e métodos da mesma.
A utilização do Strategy permite que no futuro o processo de adição de novas estratégias de criação de eventos seja facilitado.

O padrão State permite facilitar a passagem de um estado para o outro e possibilita a adição de novos estados (etapas no processo de criação do evento).

A utilização de genéricos no nosso projeto permite facilitar o processo de adição de novos User Controls no formulário principal da aplicação.


## Trabalho Futuro
No futuro, esta aplicação poderia ser desenvolvida para uma versão mobile e assim permitir maior mobilidade para a gestão dos eventos, tendo a seu dispor funcionalidades para este efeito. Contudo, a versão Desktop teria sempre utilidade aquando da criação de vários tipos de conta para o sistema, mais concretamente para um Funcionário de um certo Parque Desportivo. Isto permitiria aos Parques adicionar novas quantidades de material assim como alterar o preço dos mesmos. Um exemplo demonstrativo deste cenário é alturas em que o recinto deseja realizar um desconto no aluguer de material.

No que diz respeito à parte funcional, houve certos aspectos definidos na fase inicial deste projeto que não foram implementados. A adição de amigos, subscrição de parques/eventos bem como as notificações e sugestões de eventos são pontos que queremos cobrir futuramente, consolidando assim os conhecimentos adquiridos sobre padrões de desenho. De realçar ainda que o futuro não passa apenas pela implementação de novas funcionalidades mas melhorar o trabalho realizado até ao momento. Para tal, teríamos de usar threads para melhorar o desempenho da aplicação tornando a interação do utilizador mais fluída. Dado que a parte core deste projeto é a criação de eventos, a criação de módulos independentes com algoritmos de otimização para a gestão total das reservas seria uma medida vantajosa a implementar.

## Conclusão
Apesar de apresentar pequenas lacunas achamos que cumprimos com o que nos propusemos e apresentamos uma solução consistente que certamente facilitaria a marcação de eventos desportivos entre amigos.

Consideramos que o desenvolvimento deste projeto foi enriquecedor proporcionando o uso de novos recursos como o Entity Framework e o Fluent API na construção de uma aplicação Desktop, na linguagem C#. Seguindo as boas regras de programação e os padrões de desenho, conteúdo predominante nesta unidade curricular, chegamos ao fim deste trabalho satisfeitos com os resultados alcançados.

Este foi um projeto que apesar de trabalhoso nos deu imenso prazer em desenvolver pois fez-nos pensar a um nível que normalmente não pensamos e nos proporcionou a aquisição de novos conhecimentos.

Além disso, este projeto foi essencial para que pudéssemos colocar em prática alguns dos conceitos teóricos lecionados nas aulas. Deste modo, ficámos com outra noção da importância dos princípios SOLID, padrões de desenho que apresentam boas práticas para uma programação orientada a objetos, auxiliando na construção de um código de fácil leitura, manutenção e extensão.

Em suma, apesar da complexidade da proposta acima descrita conseguimos atingir o nível exigido para esta unidade curricular.

## Referências
[1] A. Lusa, "Portugueses fazem cada vez menos exercício físico", Observador, 2020. [Online]. Available: https://observador.pt/2019/01/24/portugueses-fazem-cada-vez-menos-exercicio-fisico/. [Accessed: 06- Feb- 2020].

[2] "Portugueses são dos que menos exercício praticam na Europa", DN, 2020. [Online]. Available: https://www.dn.pt/vida-e-futuro/portugueses-sao-dos-que-menos-exercicio-praticam-na-europa-10735355.html. [Accessed: 06- Feb- 2020].

[3]"Visão geral do Entity Framework 6 – EF6", Docs.microsoft.com, 2020. [Online]. Available: https://docs.microsoft.com/pt-br/ef/ef6/. [Accessed: 06- Feb- 2020].

[4] Desenho e Implementação de Software, https://moodle.cee.uma.pt/course/view.php?id=61

[5] "State", Refactoring.guru, 2020. [Online]. Available: https://refactoring.guru/design-patterns/state. [Accessed: 06- Feb- 2020].
