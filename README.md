# Sports4All

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
O Sports4All encontra-se dividido nas seguintes camadas, de acordo com o modelo MVVM (Model View ViewModel): 

![GitHub Logo](/RMImages/model.png)

* **View**: relacionada com a apresentação da aplicação (camada com a qual o utilizador interage);
* **ViewModel**: atua como conversor de dados, transformando os dados do Model de modo a serem utilizados pela View. É também responsável por passar comandos da View para o Model. Deste modo, ajuda a manter o estado da View e atualiza o Model de acordo com as ações do utilizador;
* **Model**: objetos/dados a partir do qual serão realizadas as operações com a base de dados.

## Referências
[1] A. Lusa, "Portugueses fazem cada vez menos exercício físico", Observador, 2020. [Online]. Available: https://observador.pt/2019/01/24/portugueses-fazem-cada-vez-menos-exercicio-fisico/. [Accessed: 06- Feb- 2020].

[2] "Portugueses são dos que menos exercício praticam na Europa", DN, 2020. [Online]. Available: https://www.dn.pt/vida-e-futuro/portugueses-sao-dos-que-menos-exercicio-praticam-na-europa-10735355.html. [Accessed: 06- Feb- 2020].
