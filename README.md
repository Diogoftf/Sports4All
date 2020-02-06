# Sports4All

## Introdução
Neste projeto pretende-se desenvolver um sistema tendo em conta os padrões e as boas práticas de software, para a unidade curricular de Desenho e Implementação de Software. Para o sistema apresentado e tendo em conta a unidade curricular em que o mesmo se enquadra foram utilizados os seguintes padrões: Singleton, State, Decorator e Strategy.

O sistema é intitulado por Sports4All e tem como objetivo melhorar a atividade física dos utilizadores e assim evitar o sedentarismo. Para isso, é possível o utilizador criar uma reserva em um parque desportivo e posteriormente outros utilizadores podem ingressar no evento. Para proporcionar maior adesão, o sistema inclui um sistema de pontos que irá permitir classificar utilizadores e recintos, criando assim uma componente de gamificação entre os utilizadores. Isto permite que a nossa comunidade tenha noção de quais são os melhores parques e utilizadores.

O sistema descrito foi desenvolvido tendo em conta o utilizador final, isto é, utilizadores que pretendem criar reservas ou participar em eventos, ignorando assim, outras entidades ou aspetos técnicos: gestão dos horários, stock de materiais, etc. Neste sentido, a aplicação foi desenvolvida para desktop (Windows Forms Application).
Ao longo deste relatório serão abordados os principais tópicos relacionados com o desenvolvimento deste projeto, entre estes, as motivações para o desenvolvimento desta solução, a descrição do sistema que inicialmente será mais geral e depois se centrará em aspetos mais técnicos como o modelo da base de dados, a linguagem de programação e tecnologias utilizadas, a arquitetura geral do sistema e os padrões de desenho utilizados.


## Necessidade/Oportunidade Identificada
De acordo com algumas pesquisas, os portugueses são dos que menos praticam exercício na Europa e fazem cada vez menos exercício físico, seja por falta de tempo, interesse ou motivação [1][2].

![GitHub Logo](/RMImages/resultado.png)
Referência: ![Diário de Notícias: Portugueses são dos que menos exercício praticam na Europa](https://www.dn.pt/vida-e-futuro/portugueses-sao-dos-que-menos-exercicio-praticam-na-europa-10735355.html)



## Referências
[1] A. Lusa, "Portugueses fazem cada vez menos exercício físico", Observador, 2020. [Online]. Available: https://observador.pt/2019/01/24/portugueses-fazem-cada-vez-menos-exercicio-fisico/. [Accessed: 06- Feb- 2020].

[2] "Portugueses são dos que menos exercício praticam na Europa", DN, 2020. [Online]. Available: https://www.dn.pt/vida-e-futuro/portugueses-sao-dos-que-menos-exercicio-praticam-na-europa-10735355.html. [Accessed: 06- Feb- 2020].
