*[English](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/README.md) ∙ [日本語](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/README-ja.md) ∙ [简体中文](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/README-zh-Hans.md) ∙ [繁體中文](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/README-zh-TW.md) | [العَرَبِيَّة‎](https://github.com/donnemartin/system-design-primer/issues/170) ∙ [বাংলা](https://github.com/donnemartin/system-design-primer/issues/220) ∙ [Português do Brasil](https://github.com/donnemartin/system-design-primer/issues/40) ∙ [Deutsch](https://github.com/donnemartin/system-design-primer/issues/186) ∙ [ελληνικά](https://github.com/donnemartin/system-design-primer/issues/130) ∙ [עברית](https://github.com/donnemartin/system-design-primer/issues/272) ∙ [Italiano](https://github.com/donnemartin/system-design-primer/issues/104) ∙ [한국어](https://github.com/donnemartin/system-design-primer/issues/102) ∙ [فارسی](https://github.com/donnemartin/system-design-primer/issues/110) ∙ [Polski](https://github.com/donnemartin/system-design-primer/issues/68) ∙ [русский язык](https://github.com/donnemartin/system-design-primer/issues/87) ∙ [Español](https://github.com/donnemartin/system-design-primer/issues/136) ∙ [ภาษาไทย](https://github.com/donnemartin/system-design-primer/issues/187) ∙ [Türkçe](https://github.com/donnemartin/system-design-primer/issues/39) ∙ [tiếng Việt](https://github.com/donnemartin/system-design-primer/issues/127) ∙ [Français](https://github.com/donnemartin/system-design-primer/issues/250) | [Add Translation](https://github.com/donnemartin/system-design-primer/issues/28)*

**Ajude a [traduzir](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/TRANSLATIONS.md) este guia!**

# O Guia de Projeto de Sistemas

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/jj3A5N8.png">
  <br/>
</p>

## Motivação

> Aprenda como projetar sistemas em larga escala.
>
> Prepare-se para a entrevista de design de sistemas.

### Aprenda como projetar sistemas em larga escala

Aprender a projetar sistemas escaláveis vai ajudar você a se tornar um engenheiro melhor.

Projeto de sistemas é um tópico amplo. Existe uma **quantidade enorme de recursos espalhados pela web** sobre princípios de design de sistemas.

Este repositório é uma **coleção organizada** de recursos para ajudar você a aprender como construir sistemas em escala.

### Aprenda com a comunidade open source

Este é um projeto open source continuamente atualizado.

[Contribuições](#contributing) são bem-vindas!

### Prepare-se para a entrevista de design de sistemas

Além das entrevistas de programação, o design de sistemas é um **componente obrigatório** do **processo de entrevista técnica** em muitas empresas de tecnologia.

**Pratique perguntas comuns de entrevista de design de sistemas** e **compare** seus resultados com **soluções de exemplo**: discussões, código e diagramas.

Tópicos adicionais para preparação para entrevistas:

* [Guia de estudos](#study-guide)
* [Como abordar uma pergunta de entrevista de design de sistemas](#how-to-approach-a-system-design-interview-question)
* [Perguntas de entrevista de design de sistemas, **com soluções**](#system-design-interview-questions-with-solutions)
* [Perguntas de entrevista de design orientado a objetos, **com soluções**](#object-oriented-design-interview-questions-with-solutions)
* [Perguntas adicionais de entrevista de design de sistemas](#additional-system-design-interview-questions)

## Flashcards Anki

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/zdCAkB3.png">
  <br/>
</p>

Os [decks de flashcards Anki](https://apps.ankiweb.net/) fornecidos usam repetição espaçada para ajudar você a reter conceitos-chave de design de sistemas.

* [Deck de design de sistemas](https://github.com/donnemartin/system-design-primer/tree/master/resources/flash_cards/System%20Design.apkg)
* [Deck de exercícios de design de sistemas](https://github.com/donnemartin/system-design-primer/tree/master/resources/flash_cards/System%20Design%20Exercises.apkg)
* [Deck de exercícios de design orientado a objetos](https://github.com/donnemartin/system-design-primer/tree/master/resources/flash_cards/OO%20Design.apkg)

Ótimo para usar enquanto estiver em movimento.

### Recurso de Codificação: Desafios Interativos de Programação

Procurando recursos para ajudar você a se preparar para a [**Entrevista de Programação**](https://github.com/donnemartin/interactive-coding-challenges)?

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/b4YtAEN.png">
  <br/>
</p>

Confira o repositório irmão [**Interactive Coding Challenges**](https://github.com/donnemartin/interactive-coding-challenges), que contém um deck Anki adicional:

* [Deck de programação](https://github.com/donnemartin/interactive-coding-challenges/tree/master/anki_cards/Coding.apkg)

## Contribuindo

> Aprenda com a comunidade.

Sinta-se à vontade para enviar pull requests para ajudar:

* Corrigir erros
* Melhorar seções
* Adicione novas seções
* [Traduzir](https://github.com/donnemartin/system-design-primer/issues/28)

Conteúdo que precisa de ajustes está colocado [em desenvolvimento](#under-development).

Revise as [Diretrizes de Contribuição](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/CONTRIBUTING.md).

## Índice de tópicos de design de sistemas

> Resumos de vários tópicos de design de sistemas, incluindo prós e contras. **Tudo é uma troca**.
>
> Cada seção contém links para recursos mais aprofundados.

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/jrUBAF7.png">
  <br/>
</p>

* [Tópicos de design de sistemas: comece aqui](#system-design-topics-start-here)
    * [Passo 1: Revise a videoaula sobre escalabilidade](#step-1-review-the-scalability-video-lecture)
    * [Passo 2: Revise o artigo sobre escalabilidade](#step-2-review-the-scalability-article)
    * [Próximos passos](#next-steps)
* [Desempenho vs escalabilidade](#performance-vs-scalability)
* [Latência vs vazão](#latency-vs-throughput)
* [Disponibilidade vs consistência](#availability-vs-consistency)
    * [Teorema CAP](#cap-theorem)
        * [CP - consistência e tolerância à partição](#cp---consistency-and-partition-tolerance)
        * [AP - disponibilidade e tolerância à partição](#ap---availability-and-partition-tolerance)
* [Padrões de consistência](#consistency-patterns)
    * [Consistência fraca](#weak-consistency)
    * [Consistência eventual](#eventual-consistency)
    * [Consistência forte](#strong-consistency)
* [Padrões de disponibilidade](#availability-patterns)
    * [Fail-over](#fail-over)
    * [Replicação](#replication)
    * [Disponibilidade em números](#availability-in-numbers)
* [Sistema de nomes de domínio](#domain-name-system)
* [Rede de entrega de conteúdo](#content-delivery-network)
    * [CDNs Push](#push-cdns)
    * [CDNs Pull](#pull-cdns)
* [Balanceador de carga](#load-balancer)
    * [Ativo-passivo](#active-passive)
    * [Ativo-ativo](#active-active)
    * [Balanceamento de carga na Camada 4](#layer-4-load-balancing)
    * [Balanceamento de carga na Camada 7](#layer-7-load-balancing)
    * [Escalonamento horizontal](#horizontal-scaling)
* [Proxy reverso (servidor web)](#reverse-proxy-web-server)
    * [Balanceador de carga vs proxy reverso](#load-balancer-vs-reverse-proxy)
* [Camada de aplicação](#application-layer)
    * [Microsserviços](#microservices)
    * [Descoberta de serviços](#service-discovery)
* [Banco de dados](#database)
    * [Sistema de gerenciamento de banco de dados relacional (SGBDR)](#relational-database-management-system-rdbms)
        * [Replicação mestre-escravo](#master-slave-replication)
        * [Replicação mestre-mestre](#master-master-replication)
        * [Federação](#federation)
        * [Fragmentação (Sharding)](#sharding)
        * [Desnormalização](#denormalization)
        * [Otimização de SQL](#sql-tuning)
    * [NoSQL](#nosql)
        * [Armazenamento chave-valor](#key-value-store)
        * [Armazenamento de documentos](#document-store)
        * [Armazenamento em colunas largas](#wide-column-store)
        * [Banco de dados de grafos](#graph-database)
    * [SQL ou NoSQL](#sql-or-nosql)
* [Cache](#cache)
    * [Cache do cliente](#client-caching)
    * [Cache de CDN](#cdn-caching)
    * [Cache do servidor web](#web-server-caching)
    * [Cache de banco de dados](#database-caching)
    * [Cache da aplicação](#application-caching)
    * [Cache no nível de consulta ao banco de dados](#caching-at-the-database-query-level)
    * [Cache no nível de objeto](#caching-at-the-object-level)
    * [Quando atualizar o cache](#when-to-update-the-cache)
        * [Cache-aside](#cache-aside)
        * [Write-through](#write-through)
        * [Write-behind (write-back)](#write-behind-write-back)
        * [Refresh-ahead](#refresh-ahead)
* [Assincronismo](#asynchronism)
    * [Filas de mensagens](#message-queues)
    * [Filas de tarefas](#task-queues)
    * [Pressão reversa (Back pressure)](#back-pressure)
* [Comunicação](#communication)
    * [Protocolo de controle de transmissão (TCP)](#transmission-control-protocol-tcp)
    * [Protocolo de datagrama do usuário (UDP)](#user-datagram-protocol-udp)
    * [Chamada de procedimento remoto (RPC)](#remote-procedure-call-rpc)
    * [Transferência de estado representacional (REST)](#representational-state-transfer-rest)
* [Segurança](#security)
* [Apêndice](#appendix)
    * [Tabela de potências de dois](#powers-of-two-table)
    * [Números de latência que todo programador deveria saber](#latency-numbers-every-programmer-should-know)
    * [Perguntas adicionais de entrevista de design de sistemas](#additional-system-design-interview-questions)
    * [Arquiteturas do mundo real](#real-world-architectures)
    * [Arquiteturas de empresas](#company-architectures)
    * [Blogs de engenharia de empresas](#company-engineering-blogs)
* [Em desenvolvimento](#under-development)
* [Créditos](#credits)
* [Informações de contato](#contact-info)
* [Licença](#license)

## Guia de estudos

> Tópicos sugeridos para revisar com base na sua linha do tempo para entrevistas (curto, médio, longo).

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/OfVllex.png)

**P: Para entrevistas, eu preciso saber tudo aqui?**

**R: Não, você não precisa saber tudo aqui para se preparar para a entrevista**.

O que será perguntado em uma entrevista depende de variáveis como:

* Quanto de experiência você tem
* Qual é o seu histórico técnico
* Para quais cargos você está entrevistando
* Com quais empresas você está entrevistando
* Sorte

Candidatos mais experientes geralmente são esperados que saibam mais sobre design de sistemas.  Arquitetos ou líderes de equipe podem ser esperados que saibam mais do que contribuintes individuais.  Empresas de tecnologia de ponta provavelmente terão uma ou mais rodadas de entrevista de design.

Comece amplo e aprofunde-se em algumas áreas. Ajuda conhecer um pouco sobre diversos tópicos-chave de design de sistemas. Ajuste o guia abaixo conforme seu cronograma, experiência, os cargos para os quais está se candidatando e as empresas onde irá entrevistar.

* **Cronograma curto** - Foque em **amplitude** nos tópicos de design de sistemas. Pratique resolvendo **algumas** questões de entrevista.
* **Cronograma médio** - Foque em **amplitude** e **alguma profundidade** nos tópicos de design de sistemas. Pratique resolvendo **muitas** questões de entrevista.
* **Cronograma longo** - Foque em **amplitude** e **maior profundidade** nos tópicos de design de sistemas. Pratique resolvendo **a maioria** das questões de entrevista.

| | Curto | Médio | Longo |
|---|---|---|---|
| Leia os [Tópicos de design de sistemas](#index-of-system-design-topics) para obter uma compreensão ampla de como os sistemas funcionam | :+1: | :+1: | :+1: |
| Leia alguns artigos nos [Blogs de engenharia das empresas](#company-engineering-blogs) das empresas onde irá entrevistar | :+1: | :+1: | :+1: |
| Leia algumas [Arquiteturas do mundo real](#real-world-architectures) | :+1: | :+1: | :+1: |
| Revise [Como abordar uma questão de entrevista de design de sistemas](#how-to-approach-a-system-design-interview-question) | :+1: | :+1: | :+1: |
| Resolva [Questões de entrevista de design de sistemas com soluções](#system-design-interview-questions-with-solutions) | Algumas | Muitas | A maioria |
| Resolva [Questões de entrevista de design orientado a objetos com soluções](#object-oriented-design-interview-questions-with-solutions) | Algumas | Muitas | A maioria |
| Revise [Questões adicionais de entrevista de design de sistemas](#additional-system-design-interview-questions) | Algumas | Muitas | A maioria |

## Como abordar uma questão de entrevista de design de sistemas

> Como lidar com uma questão de entrevista de design de sistemas.

A entrevista de design de sistemas é uma **conversa aberta**. Espera-se que você a conduza.

Você pode usar os seguintes passos para guiar a discussão. Para ajudar a solidificar esse processo, trabalhe com as [Questões de entrevista de design de sistemas com soluções](#system-design-interview-questions-with-solutions) usando os passos abaixo.

### Passo 1: Delimite casos de uso, restrições e suposições

Recolha requisitos e defina o escopo do problema. Faça perguntas para esclarecer casos de uso e restrições. Discuta suposições.

* Quem vai usar?
* Como irão usar?
* Quantos usuários existem?
* O que o sistema faz?
* Quais são as entradas e saídas do sistema?
* Qual o volume de dados esperado?
* Quantas requisições por segundo esperamos?
* Qual a proporção esperada de leitura para escrita?

### Passo 2: Crie um design de alto nível

Descreva um design de alto nível com todos os componentes importantes.

* Esboce os principais componentes e conexões
* Justifique suas ideias

### Etapa 3: Projetar componentes principais

Aprofunde-se nos detalhes de cada componente principal. Por exemplo, se você fosse solicitado a [projetar um serviço de encurtamento de URL](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/pastebin/README.md), discuta:

* Gerar e armazenar um hash da URL completa
    * [MD5](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/pastebin/README.md) e [Base62](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/pastebin/README.md)
    * Colisões de hash
    * SQL ou NoSQL
    * Esquema de banco de dados
* Traduzir uma URL hasheada para a URL completa
    * Consulta ao banco de dados
* API e design orientado a objetos

### Etapa 4: Escalar o projeto

Identifique e resolva gargalos, dadas as restrições. Por exemplo, você precisa dos seguintes itens para resolver questões de escalabilidade?

* Balanceador de carga
* Escalabilidade horizontal
* Cache
* Sharding de banco de dados

Discuta soluções potenciais e trade-offs. Tudo é uma troca. Aborde gargalos usando [princípios de design de sistemas escaláveis](#index-of-system-design-topics).

### Cálculos rápidos

Você pode ser solicitado a fazer algumas estimativas à mão. Consulte o [Apêndice](#appendix) para os seguintes recursos:

* [Use cálculos rápidos](http://highscalability.com/blog/2011/1/26/google-pro-tip-use-back-of-the-envelope-calculations-to-choo.html)
* [Tabela de potências de dois](#powers-of-two-table)
* [Números de latência que todo programador deve saber](#latency-numbers-every-programmer-should-know)

### Fonte(s) e leitura adicional

Confira os links abaixo para ter uma ideia melhor do que esperar:

* [Como se sair bem em uma entrevista de design de sistemas](https://www.palantir.com/2011/10/how-to-rock-a-systems-design-interview/)
* [A entrevista de design de sistemas](http://www.hiredintech.com/system-design)
* [Introdução à Arquitetura e Entrevistas de Design de Sistemas](https://www.youtube.com/watch?v=ZgdS0EUmn70)
* [Template de design de sistemas](https://leetcode.com/discuss/career/229177/My-System-Design-Template)

## Perguntas de entrevista de design de sistemas com soluções

> Perguntas comuns de entrevistas de design de sistemas com discussões de exemplo, código e diagramas.
>
> Soluções vinculadas ao conteúdo na pasta `solutions/`.

| Pergunta | |
|---|---|
| Como projetar o Pastebin.com (ou Bit.ly) | [Solução](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/pastebin/README.md) |
| Como projetar a timeline e busca do Twitter (ou feed e busca do Facebook) | [Solução](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/twitter/README.md) |
| Como projetar um web crawler | [Solução](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/web_crawler/README.md) |
| Como projetar o Mint.com | [Solução](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/mint/README.md) |
| Como projetar as estruturas de dados para uma rede social | [Solução](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/social_graph/README.md) |
| Como projetar um armazenamento chave-valor para um mecanismo de busca | [Solução](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/query_cache/README.md) |
| Como projetar o recurso de ranking de vendas por categoria da Amazon | [Solução](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/sales_rank/README.md) |
| Como projetar um sistema que escale para milhões de usuários na AWS | [Solução](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/scaling_aws/README.md) |
| Adicione uma questão de design de sistema | [Contribua](#contributing) |

### Como projetar o Pastebin.com (ou Bit.ly)

[Veja o exercício e solução](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/pastebin/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/4edXG0T.png)

### Como projetar a timeline e busca do Twitter (ou feed e busca do Facebook)

[Veja o exercício e solução](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/twitter/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/jrUBAF7.png)

### Como projetar um web crawler

[Veja o exercício e solução](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/web_crawler/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/bWxPtQA.png)

### Design Mint.com

[View exercise and solution](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/mint/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/V5q57vU.png)

### Design the data structures for a social network

[View exercise and solution](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/social_graph/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/cdCv5g7.png)

### Design a key-value store for a search engine

[View exercise and solution](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/query_cache/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/4j99mhe.png)

### Design Amazon's sales ranking by category feature

[View exercise and solution](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/sales_rank/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/MzExP06.png)

### Design a system that scales to millions of users on AWS

[View exercise and solution](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/scaling_aws/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/jj3A5N8.png)

## Object-oriented design interview questions with solutions

> Common object-oriented design interview questions with sample discussions, code, and diagrams.
>
> Solutions linked to content in the `solutions/` folder.

>**Note: This section is under development**

| Question | |
|---|---|
| Desenvolva um mapa de hash | [Solução](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/object_oriented_design/hash_table/hash_map.ipynb)  |
| Desenvolva um cache menos recentemente usado | [Solução](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/object_oriented_design/lru_cache/lru_cache.ipynb)  |
| Desenvolva uma central de atendimento | [Solução](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/object_oriented_design/call_center/call_center.ipynb)  |
| Desenvolva um baralho de cartas | [Solução](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/object_oriented_design/deck_of_cards/deck_of_cards.ipynb)  |
| Desenvolva um estacionamento | [Solução](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/object_oriented_design/parking_lot/parking_lot.ipynb)  |
| Desenvolva um servidor de chat | [Solução](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/object_oriented_design/online_chat/online_chat.ipynb)  |
| Desenvolva um array circular | [Contribua](#contributing)  |
| Adicione uma questão de design orientado a objetos | [Contribua](#contributing) |

## Tópicos de design de sistemas: comece aqui

Novo em design de sistemas?

Primeiro, você precisará de um entendimento básico dos princípios comuns, aprendendo o que são, como são usados e seus prós e contras.

### Passo 1: Revise a videoaula sobre escalabilidade

[Palestra sobre Escalabilidade em Harvard](https://www.youtube.com/watch?v=-W9F__D3oY4)

* Tópicos abordados:
    * Escalabilidade vertical
    * Escalabilidade horizontal
    * Cache
    * Balanceamento de carga
    * Replicação de banco de dados
    * Particionamento de banco de dados

### Passo 2: Revise o artigo sobre escalabilidade

[Escalabilidade](https://web.archive.org/web/20221030091841/http://www.lecloud.net/tagged/scalability/chrono)

* Tópicos abordados:
    * [Clones](https://web.archive.org/web/20220530193911/https://www.lecloud.net/post/7295452622/scalability-for-dummies-part-1-clones)
    * [Bancos de dados](https://web.archive.org/web/20220602114024/https://www.lecloud.net/post/7994751381/scalability-for-dummies-part-2-database)
    * [Caches](https://web.archive.org/web/20230126233752/https://www.lecloud.net/post/9246290032/scalability-for-dummies-part-3-cache)
    * [Assincronismo](https://web.archive.org/web/20220926171507/https://www.lecloud.net/post/9699762917/scalability-for-dummies-part-4-asynchronism)

### Próximos passos

A seguir, veremos os trade-offs de alto nível:

* **Desempenho** vs **escalabilidade**
* **Latência** vs **taxa de transferência**
* **Disponibilidade** vs **consistência**

Tenha em mente que **tudo é um trade-off**.

Depois, vamos abordar tópicos mais específicos como DNS, CDNs e balanceadores de carga.

## Desempenho vs escalabilidade

Um serviço é **escalável** se resulta em aumento de **desempenho** de forma proporcional aos recursos adicionados. Geralmente, aumentar o desempenho significa atender mais unidades de trabalho, mas também pode ser para lidar com unidades maiores, como quando os conjuntos de dados crescem.<sup><a href=http://www.allthingsdistributed.com/2006/03/a_word_on_scalability.html>1</a></sup>

Outra maneira de analisar desempenho vs escalabilidade:

* Se você tem um problema de **desempenho**, seu sistema é lento para um único usuário.
* Se você tem um problema de **escalabilidade**, seu sistema é rápido para um único usuário, mas lento sob carga pesada.

### Fonte(s) e leitura adicional

* [Uma palavra sobre escalabilidade](http://www.allthingsdistributed.com/2006/03/a_word_on_scalability.html)
* [Escalabilidade, disponibilidade, estabilidade, padrões](http://www.slideshare.net/jboner/scalability-availability-stability-patterns/)

## Latência vs taxa de transferência

**Latência** é o tempo para realizar uma ação ou produzir um resultado.

**Taxa de transferência** é o número dessas ações ou resultados por unidade de tempo.

Geralmente, você deve buscar **taxa de transferência máxima** com **latência aceitável**.

### Fonte(s) e leitura adicional

* [Entendendo latência vs taxa de transferência](https://community.cadence.com/cadence_blogs_8/b/fv/posts/understanding-latency-vs-throughput)

## Disponibilidade vs consistência

### Teorema CAP

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/bgLMI2u.png">
  <br/>
  <i><a href=http://robertgreiner.com/2014/08/cap-theorem-revisited>Fonte: CAP theorem revisited</a></i>
</p>

Em um sistema distribuído de computadores, você só pode suportar duas das seguintes garantias:

* **Consistência** - Toda leitura recebe a escrita mais recente ou um erro
* **Disponibilidade** - Toda requisição recebe uma resposta, sem garantia de que contém a versão mais recente da informação
* **Tolerância a Partição** - O sistema continua a operar apesar de partições arbitrárias devido a falhas de rede

*Redes não são confiáveis, então você precisará suportar tolerância a partição. Será necessário fazer uma escolha de software entre consistência e disponibilidade.*

#### CP - consistência e tolerância a partição

Aguardar uma resposta do nó particionado pode resultar em um erro de timeout. CP é uma boa escolha se as necessidades do negócio exigem leituras e escritas atômicas.

#### AP - disponibilidade e tolerância a partição

Respostas retornam a versão mais prontamente disponível dos dados em qualquer nó, que pode não ser a mais recente. Escritas podem levar algum tempo para se propagar quando a partição é resolvida.

AP é uma boa escolha se as necessidades do negócio permitem [consistência eventual](#eventual-consistency) ou quando o sistema precisa continuar funcionando apesar de erros externos.

### Fonte(s) e leitura adicional

* [CAP theorem revisited](http://robertgreiner.com/2014/08/cap-theorem-revisited/)
* [Uma introdução em inglês simples ao teorema CAP](http://ksat.me/a-plain-english-introduction-to-cap-theorem)
* [CAP FAQ](https://github.com/henryr/cap-faq)
* [O teorema CAP](https://www.youtube.com/watch?v=k-Yaq8AHlFA)

## Padrões de consistência

Com múltiplas cópias dos mesmos dados, enfrentamos opções sobre como sincronizá-las para que os clientes tenham uma visão consistente dos dados. Relembre a definição de consistência do [teorema CAP](#cap-theorem) - Toda leitura recebe a escrita mais recente ou um erro.

### Consistência fraca

Após uma escrita, leituras podem ou não vê-la. Uma abordagem de melhor esforço é utilizada.

Esta abordagem é vista em sistemas como memcached. Consistência fraca funciona bem em casos de uso em tempo real como VoIP, chat de vídeo e jogos multiplayer em tempo real. Por exemplo, se você está em uma ligação e perde o sinal por alguns segundos, ao recuperar a conexão você não ouve o que foi dito durante a perda da conexão.

### Consistência eventual

Após uma escrita, as leituras eventualmente a verão (normalmente dentro de milissegundos). Os dados são replicados de forma assíncrona.

Essa abordagem é vista em sistemas como DNS e email. A consistência eventual funciona bem em sistemas altamente disponíveis.

### Consistência forte

Após uma escrita, as leituras a verão. Os dados são replicados de forma síncrona.

Essa abordagem é vista em sistemas de arquivos e SGBDRs. Consistência forte funciona bem em sistemas que precisam de transações.

### Fonte(s) e leitura adicional

* [Transações entre data centers](http://snarfed.org/transactions_across_datacenters_io.html)

## Padrões de disponibilidade

Existem dois padrões complementares para suportar alta disponibilidade: **fail-over** e **replicação**.

### Fail-over

#### Ativo-passivo

Com fail-over ativo-passivo, sinais de vida são enviados entre o servidor ativo e o passivo em espera. Se o sinal de vida for interrompido, o servidor passivo assume o endereço IP do ativo e retoma o serviço.

O tempo de inatividade é determinado por o servidor passivo já estar executando em standby 'quente' ou se precisa iniciar em standby 'frio'. Apenas o servidor ativo lida com o tráfego.

Fail-over ativo-passivo também pode ser chamado de fail-over mestre-escravo.

#### Ativo-ativo

No ativo-ativo, ambos os servidores gerenciam o tráfego, distribuindo a carga entre eles.

Se os servidores forem voltados ao público, o DNS precisaria saber sobre os IPs públicos de ambos os servidores. Se forem voltados para uso interno, a lógica da aplicação precisaria saber sobre ambos os servidores.

Fail-over ativo-ativo também pode ser chamado de fail-over mestre-mestre.

### Desvantagem(ns): failover

* O fail-over adiciona mais hardware e complexidade adicional.
* Há um potencial de perda de dados se o sistema ativo falhar antes que qualquer dado recém-escrito seja replicado para o passivo.

### Replicação

#### Master-slave e master-master

Este tópico é discutido mais detalhadamente na seção [Banco de Dados](#database):

* [Replicação master-slave](#master-slave-replication)
* [Replicação master-master](#master-master-replication)

### Disponibilidade em números

A disponibilidade é frequentemente quantificada pelo tempo de funcionamento (ou tempo de inatividade) como uma porcentagem do tempo em que o serviço está disponível. A disponibilidade é geralmente medida em número de 9s--um serviço com 99,99% de disponibilidade é descrito como tendo quatro noves.

#### 99,9% de disponibilidade - três noves

| Duração             | Tempo de inatividade aceitável|
|---------------------|------------------------------|
| Inatividade por ano | 8h 45min 57s                 |
| Inatividade por mês | 43m 49,7s                    |
| Inatividade por semana | 10m 4,8s                  |
| Inatividade por dia | 1m 26,4s                     |

#### 99,99% de disponibilidade - quatro noves

| Duração             | Tempo de inatividade aceitável|
|---------------------|------------------------------|
| Inatividade por ano | 52min 35,7s                  |
| Inatividade por mês | 4m 23s                       |
| Inatividade por semana | 1m 5s                     |
| Inatividade por dia | 8,6s                         |

#### Disponibilidade em paralelo vs em sequência

Se um serviço consiste em múltiplos componentes propensos a falhas, a disponibilidade geral do serviço depende se os componentes estão em sequência ou em paralelo.

###### Em sequência

A disponibilidade geral diminui quando dois componentes com disponibilidade < 100% estão em sequência:

```
Availability (Total) = Availability (Foo) * Availability (Bar)
```

Se tanto `Foo` quanto `Bar` tivessem 99,9% de disponibilidade cada um, a disponibilidade total em sequência seria de 99,8%.

###### Em paralelo

A disponibilidade geral aumenta quando dois componentes com disponibilidade < 100% estão em paralelo:

```
Availability (Total) = 1 - (1 - Availability (Foo)) * (1 - Availability (Bar))
```
Se tanto `Foo` quanto `Bar` tivessem 99,9% de disponibilidade cada, a disponibilidade total em paralelo seria de 99,9999%.

## Sistema de nomes de domínio

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/IOyLj4i.jpg">
  <br/>
  <i><a href=http://www.slideshare.net/srikrupa5/dns-security-presentation-issa>Fonte: Apresentação sobre segurança de DNS</a></i>
</p>

Um Sistema de Nomes de Domínio (DNS) traduz um nome de domínio como www.example.com para um endereço IP.

O DNS é hierárquico, com alguns servidores autorizados no topo. Seu roteador ou ISP fornece informações sobre quais servidores DNS contatar ao fazer uma consulta. Servidores DNS de níveis inferiores armazenam em cache mapeamentos, que podem ficar desatualizados devido a atrasos na propagação do DNS. Os resultados do DNS também podem ser armazenados em cache pelo seu navegador ou sistema operacional por um determinado período, determinado pelo [time to live (TTL)](https://en.wikipedia.org/wiki/Time_to_live).

* **Registro NS (name server)** - Especifica os servidores DNS para seu domínio/subdomínio.
* **Registro MX (mail exchange)** - Especifica os servidores de e-mail para receber mensagens.
* **Registro A (address)** - Aponta um nome para um endereço IP.
* **CNAME (canônico)** - Aponta um nome para outro nome ou `CNAME` (example.com para www.example.com) ou para um registro `A`.

Serviços como [CloudFlare](https://www.cloudflare.com/dns/) e [Route 53](https://aws.amazon.com/route53/) oferecem serviços DNS gerenciados. Alguns serviços DNS podem encaminhar tráfego por diversos métodos:

* [Round robin ponderado](https://www.jscape.com/blog/load-balancing-algorithms)
    * Impede que o tráfego vá para servidores em manutenção
    * Equilibra entre tamanhos de cluster variados
    * Teste A/B
* [Baseado em latência](https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/routing-policy-latency.html)
* [Baseado em geolocalização](https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/routing-policy-geo.html)

### Desvantagem(ns): DNS

* O acesso a um servidor DNS introduz um pequeno atraso, embora mitigado pelo cache descrito acima.
* O gerenciamento de servidores DNS pode ser complexo e geralmente é feito por [governos, ISPs e grandes empresas](http://superuser.com/questions/472695/who-controls-the-dns-servers/472729).
* Serviços DNS têm sido alvo de [ataques DDoS](http://dyn.com/blog/dyn-analysis-summary-of-friday-october-21-attack/), impedindo usuários de acessarem sites como o Twitter sem conhecer os endereços IP do Twitter.

### Fonte(s) e leitura adicional

* [Arquitetura DNS](https://technet.microsoft.com/en-us/library/dd197427(v=ws.10).aspx)
* [Wikipedia](https://en.wikipedia.org/wiki/Domain_Name_System)
* [Artigos sobre DNS](https://support.dnsimple.com/categories/dns/)


## Rede de entrega de conteúdo

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/h9TAuGI.jpg">
  <br/>
  <i><a href=https://www.creative-artworks.eu/why-use-a-content-delivery-network-cdn/>Fonte: Por que usar uma CDN</a></i>
</p>

Uma rede de entrega de conteúdo (CDN) é uma rede globalmente distribuída de servidores proxy, que servem conteúdo de locais mais próximos ao usuário. Geralmente, arquivos estáticos como HTML/CSS/JS, fotos e vídeos são servidos pela CDN, embora algumas CDNs como a CloudFront da Amazon suportem conteúdo dinâmico. A resolução de DNS do site indicará aos clientes qual servidor contatar.

Servir conteúdo por meio de CDNs pode melhorar significativamente o desempenho de duas maneiras:

* Os usuários recebem conteúdo de data centers próximos a eles
* Seus servidores não precisam atender às solicitações que a CDN cumpre

### CDNs Push

CDNs Push recebem novo conteúdo sempre que alterações ocorrem em seu servidor. Você assume total responsabilidade por fornecer o conteúdo, fazendo upload direto para a CDN e reescrevendo URLs para apontar para a CDN. Você pode configurar quando o conteúdo expira e quando é atualizado. O conteúdo é enviado somente quando é novo ou alterado, minimizando o tráfego, mas maximizando o armazenamento.

Sites com baixo tráfego ou sites cujo conteúdo não é atualizado com frequência funcionam bem com CDNs Push. O conteúdo é colocado nas CDNs uma vez, em vez de ser repuxado em intervalos regulares.

### CDNs Pull

CDNs Pull buscam novo conteúdo do seu servidor quando o primeiro usuário solicita o conteúdo. Você mantém o conteúdo em seu servidor e reescreve as URLs para apontar para a CDN. Isso resulta em uma requisição mais lenta até que o conteúdo seja armazenado em cache na CDN.

Um [time-to-live (TTL)](https://pt.wikipedia.org/wiki/Time_to_live) determina por quanto tempo o conteúdo fica em cache. CDNs Pull minimizam o espaço de armazenamento na CDN, mas podem criar tráfego redundante se os arquivos expirarem e forem buscados antes de realmente terem mudado.

Sites com alto tráfego funcionam bem com CDNs Pull, pois o tráfego é distribuído mais uniformemente, com apenas o conteúdo recentemente solicitado permanecendo na CDN.

### Desvantagem(ns): CDN

* Os custos de CDN podem ser significativos dependendo do tráfego, embora isso deva ser ponderado com os custos adicionais que você teria sem usar uma CDN.
* O conteúdo pode ficar desatualizado se for atualizado antes do TTL expirar.
* CDNs exigem alteração de URLs para conteúdo estático a fim de apontar para a CDN.

### Fonte(s) e leitura adicional

* [Entrega de conteúdo distribuído globalmente](https://figshare.com/articles/Globally_distributed_content_delivery/6605972)
* [As diferenças entre CDNs Push e Pull](http://www.travelblogadvice.com/technical/the-differences-between-push-and-pull-cdns/)
* [Wikipedia](https://en.wikipedia.org/wiki/Content_delivery_network)

## Balanceador de carga

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/h81n9iK.png">
  <br/>
  <i><a href=http://horicky.blogspot.com/2010/10/scalable-system-design-patterns.html>Fonte: Padrões de design de sistemas escaláveis</a></i>
</p>

Balanceadores de carga distribuem as requisições dos clientes para recursos computacionais como servidores de aplicação e bancos de dados. Em cada caso, o balanceador de carga retorna a resposta do recurso computacional para o cliente apropriado. Os balanceadores de carga são eficazes para:

* Evitar que requisições sejam encaminhadas para servidores com problemas
* Prevenir sobrecarga de recursos
* Ajudar a eliminar um único ponto de falha

Balanceadores de carga podem ser implementados por hardware (caros) ou por software, como HAProxy.

Benefícios adicionais incluem:

* **Terminação SSL** - Descriptografa as requisições recebidas e criptografa as respostas do servidor para que os servidores backend não precisem realizar essas operações potencialmente custosas
    * Elimina a necessidade de instalar [certificados X.509](https://en.wikipedia.org/wiki/X.509) em cada servidor
* **Persistência de sessão** - Emite cookies e direciona as requisições de um cliente específico para a mesma instância caso os aplicativos web não mantenham o controle das sessões

Para proteger contra falhas, é comum configurar múltiplos balanceadores de carga, seja em modo [ativo-passivo](#active-passive) ou [ativo-ativo](#active-active).

Balanceadores de carga podem rotear o tráfego com base em várias métricas, incluindo:

* Aleatório
* Menor carga
* Sessão/cookies
* [Round robin ou round robin ponderado](https://www.g33kinfo.com/info/round-robin-vs-weighted-round-robin-lb)
* [Camada 4](#layer-4-load-balancing)
* [Camada 7](#layer-7-load-balancing)

### Balanceamento de carga na Camada 4

Balanceadores de carga na Camada 4 analisam informações na [camada de transporte](#communication) para decidir como distribuir as requisições. Geralmente, isso envolve os endereços IP de origem e destino e as portas no cabeçalho, mas não o conteúdo do pacote. Balanceadores de carga da Camada 4 encaminham pacotes de rede para e do servidor upstream, realizando [Tradução de Endereço de Rede (NAT)](https://www.nginx.com/resources/glossary/layer-4-load-balancing/).

### Balanceamento de carga na Camada 7
Balanceadores de carga de Camada 7 analisam a [camada de aplicação](#communication) para decidir como distribuir as requisições. Isso pode envolver o conteúdo do cabeçalho, mensagem e cookies. Balanceadores de carga de Camada 7 encerram o tráfego de rede, leem a mensagem, tomam uma decisão de balanceamento de carga e então abrem uma conexão com o servidor selecionado. Por exemplo, um balanceador de carga de camada 7 pode direcionar tráfego de vídeo para servidores que hospedam vídeos enquanto direciona tráfego de cobrança de usuários para servidores reforçados em segurança.

À custa de flexibilidade, o balanceamento de carga na camada 4 requer menos tempo e recursos computacionais do que na Camada 7, embora o impacto no desempenho possa ser mínimo em hardware comum moderno.

### Escalabilidade horizontal

Balanceadores de carga também podem ajudar com a escalabilidade horizontal, melhorando o desempenho e a disponibilidade. Escalar horizontalmente usando máquinas comuns é mais eficiente em termos de custo e resulta em maior disponibilidade do que escalar verticalmente um único servidor em hardware mais caro, chamado de **Escalabilidade Vertical**. Também é mais fácil contratar profissionais para trabalhar com hardware comum do que para sistemas corporativos especializados.

#### Desvantagem(ns): escalabilidade horizontal

* Escalar horizontalmente introduz complexidade e envolve a clonagem de servidores
    * Servidores devem ser stateless: não devem conter dados relacionados ao usuário como sessões ou fotos de perfil
    * Sessões podem ser armazenadas em um armazenamento de dados centralizado como um [banco de dados](#database) (SQL, NoSQL) ou um [cache](#cache) persistente (Redis, Memcached)
* Servidores downstream como caches e bancos de dados precisam lidar com mais conexões simultâneas à medida que servidores upstream escalam horizontalmente

### Desvantagem(ns): balanceador de carga

* O balanceador de carga pode se tornar um gargalo de desempenho se não tiver recursos suficientes ou se não estiver configurado corretamente.
* Introduzir um balanceador de carga para ajudar a eliminar um ponto único de falha resulta em aumento de complexidade.
* Um único balanceador de carga é um ponto único de falha; configurar múltiplos balanceadores de carga aumenta ainda mais a complexidade.

### Fonte(s) e leituras adicionais

* [Arquitetura NGINX](https://www.nginx.com/blog/inside-nginx-how-we-designed-for-performance-scale/)
* [Guia de arquitetura HAProxy](http://www.haproxy.org/download/1.2/doc/architecture.txt)
* [Escalabilidade](https://web.archive.org/web/20220530193911/https://www.lecloud.net/post/7295452622/scalability-for-dummies-part-1-clones)
* [Wikipedia](https://en.wikipedia.org/wiki/Load_balancing_(computing))
* [Balanceamento de carga na camada 4](https://www.nginx.com/resources/glossary/layer-4-load-balancing/)
* [Balanceamento de carga na camada 7](https://www.nginx.com/resources/glossary/layer-7-load-balancing/)
* [Configuração de listener do ELB](http://docs.aws.amazon.com/elasticloadbalancing/latest/classic/elb-listener-config.html)

## Proxy reverso (servidor web)

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/n41Azff.png">
  <br/>
  <i><a href=https://upload.wikimedia.org/wikipedia/commons/6/67/Reverse_proxy_h2g2bob.svg>Fonte: Wikipedia</a></i>
  <br/>
</p>

Um proxy reverso é um servidor web que centraliza serviços internos e fornece interfaces unificadas ao público. As solicitações dos clientes são encaminhadas para um servidor que pode atendê-las antes que o proxy reverso retorne a resposta do servidor ao cliente.

Benefícios adicionais incluem:

* **Aumento da segurança** - Oculta informações sobre servidores backend, bloqueia IPs, limita o número de conexões por cliente
* **Maior escalabilidade e flexibilidade** - Os clientes veem apenas o IP do proxy reverso, permitindo escalar servidores ou alterar sua configuração
* **Terminação SSL** - Descriptografa solicitações recebidas e criptografa respostas do servidor para que os servidores backend não precisem realizar essas operações potencialmente caras
    * Elimina a necessidade de instalar [certificados X.509](https://en.wikipedia.org/wiki/X.509) em cada servidor
* **Compressão** - Comprime as respostas dos servidores
* **Cache** - Retorna a resposta para solicitações em cache
* **Conteúdo estático** - Serve conteúdo estático diretamente
    * HTML/CSS/JS
    * Fotos
    * Vídeos
    * Etc

### Balanceador de carga vs proxy reverso

* Implantar um balanceador de carga é útil quando você tem vários servidores. Frequentemente, balanceadores de carga direcionam o tráfego para um conjunto de servidores que servem à mesma função.
* Proxies reversos podem ser úteis mesmo com apenas um servidor web ou de aplicação, permitindo os benefícios descritos na seção anterior.
* Soluções como NGINX e HAProxy podem suportar tanto proxy reverso na camada 7 quanto balanceamento de carga.

### Desvantagem(ns): proxy reverso

* A introdução de um proxy reverso resulta em aumento de complexidade.
* Um único proxy reverso é um ponto único de falha, configurar múltiplos proxies reversos (ou seja, um [failover](https://en.wikipedia.org/wiki/Failover)) aumenta ainda mais a complexidade.

### Fonte(s) e leitura adicional

* [Proxy reverso vs balanceador de carga](https://www.nginx.com/resources/glossary/reverse-proxy-vs-load-balancer/)
* [Arquitetura do NGINX](https://www.nginx.com/blog/inside-nginx-how-we-designed-for-performance-scale/)
* [Guia de arquitetura do HAProxy](http://www.haproxy.org/download/1.2/doc/architecture.txt)
* [Wikipedia](https://en.wikipedia.org/wiki/Reverse_proxy)

## Camada de aplicação

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/yB5SYwm.png">
  <br/>

  <i><a href=http://lethain.com/introduction-to-architecting-systems-for-scale/#platform_layer>Fonte: Introdução à arquitetura de sistemas para escala</a></i>
</p>

Separar a camada web da camada de aplicação (também conhecida como camada de plataforma) permite escalar e configurar ambas as camadas de forma independente. Adicionar uma nova API resulta na adição de servidores de aplicação sem necessariamente adicionar servidores web adicionais. O **princípio da responsabilidade única** defende serviços pequenos e autônomos que trabalham juntos. Pequenas equipes com pequenos serviços podem planejar de forma mais agressiva para um crescimento rápido.

Trabalhadores na camada de aplicação também ajudam a habilitar [assincronismo](#asynchronism).

### Microsserviços

Relacionado a essa discussão estão os [microsserviços](https://en.wikipedia.org/wiki/Microservices), que podem ser descritos como um conjunto de serviços pequenos, modulares e implantáveis de forma independente. Cada serviço executa um processo único e se comunica através de um mecanismo leve e bem definido para atender a um objetivo de negócio. <sup><a href=https://smartbear.com/learn/api-design/what-are-microservices>1</a></sup>

O Pinterest, por exemplo, poderia ter os seguintes microsserviços: perfil de usuário, seguidores, feed, busca, upload de fotos, etc.

### Descoberta de Serviços

Sistemas como [Consul](https://www.consul.io/docs/index.html), [Etcd](https://coreos.com/etcd/docs/latest), e [Zookeeper](http://www.slideshare.net/sauravhaloi/introduction-to-apache-zookeeper) podem ajudar os serviços a se encontrarem, rastreando nomes, endereços e portas registrados. [Health checks](https://www.consul.io/intro/getting-started/checks.html) ajudam a verificar a integridade dos serviços e geralmente são feitos usando um endpoint [HTTP](#hypertext-transfer-protocol-http). Tanto o Consul quanto o Etcd possuem um [armazenamento de chave-valor](#key-value-store) integrado que pode ser útil para armazenar valores de configuração e outros dados compartilhados.

### Desvantagem(ns): camada de aplicação

* Adicionar uma camada de aplicação com serviços fracamente acoplados requer uma abordagem diferente do ponto de vista arquitetural, operacional e de processos (em comparação a um sistema monolítico).
* Microsserviços podem adicionar complexidade em termos de implantação e operações.

### Fonte(s) e leituras adicionais

* [Introdução à arquitetura de sistemas para escala](http://lethain.com/introduction-to-architecting-systems-for-scale)
* [Crack the system design interview](http://www.puncsky.com/blog/2016-02-13-crack-the-system-design-interview)
* [Arquitetura orientada a serviços](https://en.wikipedia.org/wiki/Service-oriented_architecture)
* [Introdução ao Zookeeper](http://www.slideshare.net/sauravhaloi/introduction-to-apache-zookeeper)
* [Aqui está o que você precisa saber sobre construção de microsserviços](https://cloudncode.wordpress.com/2016/07/22/msa-getting-started/)

## Banco de Dados

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/Xkm5CXz.png">
  <br/>
  <i><a href=https://www.youtube.com/watch?v=kKjm4ehYiMs>Fonte: Escalando para seus primeiros 10 milhões de usuários</a></i>
</p>

### Sistema de gerenciamento de banco de dados relacional (RDBMS)

Um banco de dados relacional como SQL é uma coleção de itens de dados organizados em tabelas.

**ACID** é um conjunto de propriedades de [transações](https://en.wikipedia.org/wiki/Database_transaction) de banco de dados relacional.

* **Atomicidade** - Cada transação é tudo ou nada
* **Consistência** - Qualquer transação levará o banco de dados de um estado válido a outro
* **Isolamento** - Executar transações simultaneamente tem os mesmos resultados que se as transações fossem executadas em série
* **Durabilidade** - Uma vez que uma transação foi confirmada, ela permanecerá assim

Existem várias técnicas para escalar um banco de dados relacional: **replicação mestre-escravo**, **replicação mestre-mestre**, **federação**, **fragmentação**, **desnormalização** e **otimização de SQL**.

#### Replicação mestre-escravo

O mestre atende leituras e escritas, replicando as escritas para um ou mais escravos, que servem apenas leituras. Escravos também podem replicar para escravos adicionais em uma estrutura semelhante a uma árvore. Se o mestre ficar offline, o sistema pode continuar operando em modo somente leitura até que um escravo seja promovido a mestre ou um novo mestre seja provisionado.

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/C9ioGtn.png">
  <br/>
  <i><a href=http://www.slideshare.net/jboner/scalability-availability-stability-patterns/>Fonte: Escalabilidade, disponibilidade, estabilidade, padrões</a></i>
</p>

##### Desvantagem(ns): replicação mestre-escravo

* Lógica adicional é necessária para promover um escravo a mestre.
* Veja [Desvantagem(ns): replicação](#disadvantages-replication) para pontos relacionados a **ambos** mestre-escravo e mestre-mestre.

#### Replicação mestre-mestre

Ambos os mestres atendem leituras e escritas e coordenam entre si nas escritas. Se qualquer mestre cair, o sistema pode continuar operando com leituras e escritas.

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/krAHLGg.png">
  <br/>
  <i><a href=http://www.slideshare.net/jboner/scalability-availability-stability-patterns/>Fonte: Escalabilidade, disponibilidade, estabilidade, padrões</a></i>
</p>

##### Desvantagem(ns): replicação mestre-mestre

* Você precisará de um balanceador de carga ou precisará fazer alterações na lógica da sua aplicação para determinar onde gravar.
* A maioria dos sistemas mestre-mestre é ou fracamente consistente (violando ACID) ou tem latência de escrita aumentada devido à sincronização.
* A resolução de conflitos torna-se mais relevante à medida que mais nós de escrita são adicionados e à medida que a latência aumenta.
* Veja [Desvantagem(ns): replicação](#desvantagens-replicacao) para pontos relacionados a **ambos** master-slave e master-master.

##### Desvantagem(ns): replicação

* Existe potencial para perda de dados se o master falhar antes que qualquer dado recém-escrito seja replicado para outros nós.
* As escritas são reproduzidas para os réplicas de leitura. Se houver muitas escritas, os réplicas de leitura podem ficar sobrecarregados ao reproduzir escritas e não conseguem realizar tantas leituras.
* Quanto mais slaves de leitura, mais você precisa replicar, o que leva a maior latência de replicação.
* Em alguns sistemas, escrever no master pode gerar múltiplas threads para escrita em paralelo, enquanto réplicas de leitura só suportam escrita sequencial com uma única thread.
* A replicação adiciona mais hardware e complexidade adicional.

##### Fonte(s) e leitura adicional: replicação

* [Escalabilidade, disponibilidade, estabilidade, padrões](http://www.slideshare.net/jboner/scalability-availability-stability-patterns/)
* [Replicação multi-master](https://en.wikipedia.org/wiki/Multi-master_replication)

#### Federação

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/U3qV33e.png">
  <br/>
  <i><a href=https://www.youtube.com/watch?v=kKjm4ehYiMs>Fonte: Escalando para seus primeiros 10 milhões de usuários</a></i>
</p>

Federação (ou particionamento funcional) divide bancos de dados por função. Por exemplo, ao invés de um único banco de dados monolítico, você pode ter três bancos: **fóruns**, **usuários** e **produtos**, resultando em menos tráfego de leitura e escrita para cada banco e, portanto, menor latência de replicação. Bancos menores permitem que mais dados caibam na memória, o que resulta em mais acertos de cache devido à melhoria da localidade de cache. Sem um master central único serializando escritas, você pode escrever em paralelo, aumentando o throughput.

##### Desvantagem(ns): federação

* Federação não é eficaz se seu esquema exigir funções ou tabelas gigantes.
* Será necessário atualizar a lógica da aplicação para determinar de qual banco ler e escrever.
* Realizar junção de dados entre dois bancos é mais complexo com um [server link](http://stackoverflow.com/questions/5145637/querying-data-by-joining-two-tables-in-two-database-on-different-servers).
* Federação adiciona mais hardware e complexidade adicional.

##### Fonte(s) e leitura adicional: federação

* [Escalando para seus primeiros 10 milhões de usuários](https://www.youtube.com/watch?v=kKjm4ehYiMs)

#### Sharding

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/wU8x5Id.png">
  <br/>
  <i><a href=http://www.slideshare.net/jboner/scalability-availability-stability-patterns/>Fonte: Escalabilidade, disponibilidade, estabilidade, padrões</a></i>
</p>

Sharding distribui os dados entre diferentes bancos de dados, de modo que cada banco só gerencia um subconjunto dos dados. Tomando como exemplo um banco de usuários, à medida que o número de usuários aumenta, mais shards são adicionados ao cluster.

Similar às vantagens da [federação](#federation), o sharding resulta em menos tráfego de leitura e escrita, menos replicação e mais acertos de cache. O tamanho do índice também é reduzido, o que geralmente melhora o desempenho com consultas mais rápidas. Se um shard falhar, os outros shards continuam operacionais, embora seja recomendável adicionar algum tipo de replicação para evitar perda de dados. Como na federação, não há um único mestre central serializando escritas, permitindo escritas em paralelo com maior throughput.

As formas comuns de particionar uma tabela de usuários são pelo inicial do sobrenome do usuário ou pela localização geográfica do usuário.

##### Desvantagem(ns): sharding

* Será necessário atualizar a lógica da aplicação para trabalhar com shards, o que pode resultar em consultas SQL complexas.
* A distribuição dos dados pode ficar desequilibrada em um shard. Por exemplo, um conjunto de usuários intensivos em um shard pode gerar maior carga nesse shard em relação aos outros.
    * O reequilíbrio adiciona complexidade extra. Uma função de sharding baseada em [hashing consistente](http://www.paperplanes.de/2011/12/9/the-magic-of-consistent-hashing.html) pode reduzir a quantidade de dados transferidos.
* Realizar joins entre dados de múltiplos shards é mais complexo.
* Sharding adiciona mais hardware e complexidade extra.

##### Fonte(s) e leituras adicionais: sharding

* [The coming of the shard](http://highscalability.com/blog/2009/8/6/an-unorthodox-approach-to-database-design-the-coming-of-the.html)
* [Arquitetura de banco de dados shard](https://en.wikipedia.org/wiki/Shard_(database_architecture))
* [Hashing consistente](http://www.paperplanes.de/2011/12/9/the-magic-of-consistent-hashing.html)

#### Desnormalização

A desnormalização tenta melhorar o desempenho de leitura ao custo de algum desempenho de escrita. Cópias redundantes dos dados são escritas em múltiplas tabelas para evitar joins caros. Alguns SGBDRs como [PostgreSQL](https://en.wikipedia.org/wiki/PostgreSQL) e Oracle suportam [views materializadas](https://en.wikipedia.org/wiki/Materialized_view), que fazem o trabalho de armazenar informações redundantes e manter cópias redundantes consistentes.

Quando os dados passam a ser distribuídos por técnicas como [federação](#federation) e [sharding](#sharding), gerenciar joins entre data centers aumenta ainda mais a complexidade. A desnormalização pode contornar a necessidade desses joins complexos.

Na maioria dos sistemas, leituras podem superar escritas em 100:1 ou até 1000:1. Uma leitura que resulta em um join complexo pode ser muito cara, gastando muito tempo em operações de disco.

##### Desvantagem(ns): desnormalização

* Os dados são duplicados.
* Restrições podem ajudar cópias redundantes de informações a se manterem sincronizadas, o que aumenta a complexidade do design do banco de dados.
* Um banco de dados desnormalizado sob alta carga de escrita pode ter desempenho pior do que um banco normalizado.

###### Fonte(s) e leituras adicionais: desnormalização

* [Desnormalização](https://pt.wikipedia.org/wiki/Desnormaliza%C3%A7%C3%A3o)

#### Otimização de SQL

A otimização de SQL é um tema amplo e muitos [livros](https://www.amazon.com/s/ref=nb_sb_noss_2?url=search-alias%3Daps&field-keywords=sql+tuning) foram escritos como referência.

É importante **fazer benchmark** e **perfilamento** para simular e identificar gargalos.

* **Benchmark** - Simule situações de alta carga com ferramentas como [ab](http://httpd.apache.org/docs/2.2/programs/ab.html).
* **Perfilamento** - Ative ferramentas como o [slow query log](http://dev.mysql.com/doc/refman/5.7/en/slow-query-log.html) para ajudar a rastrear problemas de desempenho.

Benchmarking e perfilamento podem indicar as seguintes otimizações.

##### Aperfeiçoe o esquema

* O MySQL grava em disco em blocos contíguos para acesso rápido.
* Use `CHAR` ao invés de `VARCHAR` para campos de tamanho fixo.
    * `CHAR` permite acesso rápido e aleatório, enquanto com `VARCHAR` é necessário encontrar o final da string antes de passar para a próxima.
* Use `TEXT` para grandes blocos de texto, como posts de blog. `TEXT` também permite buscas booleanas. Utilizar um campo `TEXT` resulta em armazenar um ponteiro em disco que é usado para localizar o bloco de texto.
* Use `INT` para números maiores até 2^32 ou 4 bilhões.
* Use `DECIMAL` para valores monetários para evitar erros de representação de ponto flutuante.
* Evite armazenar grandes `BLOBS`, armazene o local de onde obter o objeto.
* `VARCHAR(255)` é o maior número de caracteres que pode ser contado em um número de 8 bits, muitas vezes maximizando o uso de um byte em alguns SGBDs.
* Defina a restrição `NOT NULL` onde aplicável para [melhorar o desempenho da busca](http://stackoverflow.com/questions/1017239/how-do-null-values-affect-performance-in-a-database-search).

##### Utilize bons índices

* Colunas consultadas (`SELECT`, `GROUP BY`, `ORDER BY`, `JOIN`) podem ser mais rápidas com índices.
* Índices geralmente são representados como [B-tree](https://en.wikipedia.org/wiki/B-tree) auto-balanceadas que mantêm os dados ordenados e permitem buscas, acessos sequenciais, inserções e deleções em tempo logarítmico.
* Colocar um índice pode manter os dados na memória, exigindo mais espaço.
* Escritas também podem ser mais lentas, já que o índice precisa ser atualizado.
* Ao carregar grandes volumes de dados, pode ser mais rápido desabilitar os índices, carregar os dados e então reconstruir os índices.

##### Evite joins custosos

* [Desnormalize](#desnormalizacao) onde o desempenho exigir.

##### Particione tabelas

* Divida uma tabela colocando os pontos críticos em uma tabela separada para ajudar a mantê-los na memória.

##### Ajuste o cache de consultas

* Em alguns casos, o [cache de consultas](https://dev.mysql.com/doc/refman/5.7/en/query-cache.html) pode levar a [problemas de desempenho](https://www.percona.com/blog/2016/10/12/mysql-5-7-performance-tuning-immediately-after-installation/).

##### Fonte(s) e leituras adicionais: Otimização de SQL

* [Dicas para otimizar consultas MySQL](http://aiddroid.com/10-tips-optimizing-mysql-queries-dont-suck/)
* [Existe uma boa razão para o uso frequente de VARCHAR(255)?](http://stackoverflow.com/questions/1217466/is-there-a-good-reason-i-see-varchar255-used-so-often-as-opposed-to-another-l)
* [Como valores nulos afetam o desempenho?](http://stackoverflow.com/questions/1017239/how-do-null-values-affect-performance-in-a-database-search)
* [Log de consultas lentas](http://dev.mysql.com/doc/refman/5.7/en/slow-query-log.html)

### NoSQL

NoSQL é uma coleção de itens de dados representados em um **armazenamento chave-valor**, **armazenamento de documentos**, **armazenamento de colunas largas** ou **banco de dados de grafos**. Os dados são desnormalizados e os joins geralmente são realizados no código da aplicação. A maioria dos bancos NoSQL não possui transações ACID verdadeiras e favorece a [consistência eventual](#eventual-consistency).

**BASE** é frequentemente usado para descrever as propriedades dos bancos de dados NoSQL. Em comparação com o [Teorema CAP](#cap-theorem), BASE escolhe disponibilidade em vez de consistência.

* **Basicamente disponível** - o sistema garante disponibilidade.
* **Estado suave** - o estado do sistema pode mudar ao longo do tempo, mesmo sem entrada.
* **Consistência eventual** - o sistema se tornará consistente ao longo do tempo, desde que não receba entrada durante esse período.

Além de escolher entre [SQL ou NoSQL](#sql-or-nosql), é útil entender qual tipo de banco de dados NoSQL melhor se encaixa no(s) seu(s) caso(s) de uso. Vamos revisar **armazenamento chave-valor**, **armazenamento de documentos**, **armazenamento de colunas largas** e **bancos de grafos** na próxima seção.

#### Armazenamento chave-valor

> Abstração: tabela hash

Um armazenamento chave-valor geralmente permite leituras e gravações O(1) e costuma ser suportado por memória ou SSD. Armazenamentos de dados podem manter chaves em [ordem lexicográfica](https://en.wikipedia.org/wiki/Lexicographical_order), permitindo recuperação eficiente de intervalos de chaves. Armazenamentos chave-valor podem permitir o armazenamento de metadados junto com um valor.

Armazenamentos chave-valor oferecem alto desempenho e são frequentemente usados para modelos de dados simples ou para dados que mudam rapidamente, como uma camada de cache em memória. Como oferecem apenas um conjunto limitado de operações, a complexidade é transferida para a camada da aplicação caso operações adicionais sejam necessárias.

Um armazenamento chave-valor é a base para sistemas mais complexos, como um armazenamento de documentos e, em alguns casos, um banco de dados de grafos.

##### Fonte(s) e leituras adicionais: armazenamento chave-valor

* [Banco de dados chave-valor](https://en.wikipedia.org/wiki/Key-value_database)
* [Desvantagens de armazenamentos chave-valor](http://stackoverflow.com/questions/4056093/what-are-the-disadvantages-of-using-a-key-value-table-over-nullable-columns-or)
* [Arquitetura do Redis](http://qnimate.com/overview-of-redis-architecture/)
* [Arquitetura do Memcached](https://adayinthelifeof.nl/2011/02/06/memcache-internals/)

#### Armazenamento de documentos

> Abstração: armazenamento de chave-valor com documentos armazenados como valores

Um armazenamento de documentos é centrado em documentos (XML, JSON, binário, etc), onde um documento armazena todas as informações para um determinado objeto. Os armazenamentos de documentos fornecem APIs ou uma linguagem de consulta para consultas baseadas na estrutura interna do próprio documento. *Observe que muitos armazenamentos de chave-valor incluem recursos para trabalhar com os metadados de um valor, tornando a linha entre esses dois tipos de armazenamento menos clara.*

Com base na implementação subjacente, os documentos são organizados por coleções, tags, metadados ou diretórios. Embora os documentos possam ser organizados ou agrupados, eles podem possuir campos completamente diferentes uns dos outros.

Alguns armazenamentos de documentos como [MongoDB](https://www.mongodb.com/mongodb-architecture) e [CouchDB](https://blog.couchdb.org/2016/08/01/couchdb-2-0-architecture/) também fornecem uma linguagem semelhante ao SQL para realizar consultas complexas. [DynamoDB](http://www.read.seas.harvard.edu/~kohler/class/cs239-w08/decandia07dynamo.pdf) suporta tanto chave-valor quanto documentos.

Os armazenamentos de documentos oferecem alta flexibilidade e são frequentemente usados para trabalhar com dados que mudam ocasionalmente.

##### Fonte(s) e leitura adicional: armazenamento de documentos

* [Banco de dados orientado a documentos](https://en.wikipedia.org/wiki/Document-oriented_database)
* [Arquitetura do MongoDB](https://www.mongodb.com/mongodb-architecture)
* [Arquitetura do CouchDB](https://blog.couchdb.org/2016/08/01/couchdb-2-0-architecture/)
* [Arquitetura do Elasticsearch](https://www.elastic.co/blog/found-elasticsearch-from-the-bottom-up)

#### Armazenamento de colunas largas

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/n16iOGk.png">
  <br/>
  <i><a href=http://blog.grio.com/2015/11/sql-nosql-a-brief-history.html>Fonte: SQL & NoSQL, uma breve história</a></i>
</p>

> Abstração: mapa aninhado `ColumnFamily<RowKey, Columns<ColKey, Value, Timestamp>>`

A unidade básica de dados de um armazenamento de colunas largas é uma coluna (par nome/valor). Uma coluna pode ser agrupada em famílias de colunas (análogo a uma tabela SQL). Famílias supercolunas agrupam ainda mais famílias de colunas. Você pode acessar cada coluna independentemente com uma chave de linha, e colunas com a mesma chave de linha formam uma linha. Cada valor contém um timestamp para versionamento e resolução de conflitos.

O Google introduziu o [Bigtable](http://www.read.seas.harvard.edu/~kohler/class/cs239-w08/chang06bigtable.pdf) como o primeiro armazenamento de colunas largas, que influenciou o open-source [HBase](https://www.edureka.co/blog/hbase-architecture/) muito utilizado no ecossistema Hadoop, e o [Cassandra](http://docs.datastax.com/en/cassandra/3.0/cassandra/architecture/archIntro.html) do Facebook. Armazenamentos como BigTable, HBase e Cassandra mantêm as chaves em ordem lexicográfica, permitindo recuperação eficiente de intervalos seletivos de chaves.

Armazenamentos de colunas largas oferecem alta disponibilidade e escalabilidade. Eles são frequentemente usados para conjuntos de dados muito grandes.

##### Fonte(s) e leitura adicional: armazenamento de colunas largas

* [SQL & NoSQL, uma breve história](http://blog.grio.com/2015/11/sql-nosql-a-brief-history.html)
* [Arquitetura do Bigtable](http://www.read.seas.harvard.edu/~kohler/class/cs239-w08/chang06bigtable.pdf)
* [Arquitetura do HBase](https://www.edureka.co/blog/hbase-architecture/)
* [Arquitetura do Cassandra](http://docs.datastax.com/en/cassandra/3.0/cassandra/architecture/archIntro.html)

#### Banco de dados de grafos

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/fNcl65g.png">
  <br/>
  <i><a href=https://en.wikipedia.org/wiki/File:GraphDatabase_PropertyGraph.png>Fonte: Banco de dados de grafos</a></i>
</p>

> Abstração: grafo

Em um banco de dados de grafos, cada nó é um registro e cada arco é um relacionamento entre dois nós. Bancos de dados de grafos são otimizados para representar relacionamentos complexos com muitas chaves estrangeiras ou muitos relacionamentos muitos-para-muitos.

Bancos de dados de grafos oferecem alto desempenho para modelos de dados com relacionamentos complexos, como uma rede social. Eles são relativamente novos e ainda não são amplamente utilizados; pode ser mais difícil encontrar ferramentas de desenvolvimento e recursos. Muitos grafos só podem ser acessados por [APIs REST](#representational-state-transfer-rest).

##### Fonte(s) e leituras adicionais: grafo

* [Banco de dados de grafos](https://en.wikipedia.org/wiki/Graph_database)
* [Neo4j](https://neo4j.com/)
* [FlockDB](https://blog.twitter.com/2010/introducing-flockdb)

#### Fonte(s) e leituras adicionais: NoSQL

* [Explicação da terminologia BASE](http://stackoverflow.com/questions/3342497/explanation-of-base-terminology)
* [Bancos de dados NoSQL: um levantamento e orientação de decisão](https://medium.com/baqend-blog/nosql-databases-a-survey-and-decision-guidance-ea7823a822d#.wskogqenq)
* [Escalabilidade](https://web.archive.org/web/20220602114024/https://www.lecloud.net/post/7994751381/scalability-for-dummies-part-2-database)
* [Introdução ao NoSQL](https://www.youtube.com/watch?v=qI_g07C_Q5I)
* [Padrões NoSQL](http://horicky.blogspot.com/2009/11/nosql-patterns.html)

### SQL ou NoSQL

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/wXGqG5f.png">
  <br/>
  <i><a href=https://www.infoq.com/articles/Transition-RDBMS-NoSQL/>Fonte: Transição de RDBMS para NoSQL</a></i>
</p>

Razões para **SQL**:

* Dados estruturados
* Esquema rígido
* Dados relacionais
* Necessidade de joins complexos
* Transações
* Padrões claros para escalabilidade
* Mais estabelecido: desenvolvedores, comunidade, código, ferramentas, etc.
* Buscas por índice são muito rápidas

Razões para **NoSQL**:

* Dados semiestruturados
* Esquema dinâmico ou flexível
* Dados não relacionais
* Não há necessidade de joins complexos
* Armazenar muitos TB (ou PB) de dados
* Carga de trabalho muito intensiva em dados
* Altíssima taxa de IOPS

Exemplos de dados bem adequados para NoSQL:

* Ingestão rápida de dados de clickstream e logs
* Dados de placares ou pontuação
* Dados temporários, como um carrinho de compras
* Tabelas frequentemente acessadas ('quentes')
* Tabelas de metadados/consulta

##### Fonte(s) e leitura adicional: SQL ou NoSQL

* [Escalando até seus primeiros 10 milhões de usuários](https://www.youtube.com/watch?v=kKjm4ehYiMs)
* [Diferenças entre SQL e NoSQL](https://www.sitepoint.com/sql-vs-nosql-differences/)

## Cache

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/Q6z24La.png">
  <br/>
  <i><a href=http://horicky.blogspot.com/2010/10/scalable-system-design-patterns.html>Fonte: Padrões de design de sistemas escaláveis</a></i>
</p>

O cache melhora o tempo de carregamento das páginas e pode reduzir a carga nos seus servidores e bancos de dados. Neste modelo, o despachante primeiro verifica se a requisição já foi feita anteriormente e tenta encontrar o resultado anterior para retornar, a fim de poupar a execução real.

Os bancos de dados frequentemente se beneficiam de uma distribuição uniforme de leituras e escritas entre suas partições. Itens populares podem distorcer essa distribuição, causando gargalos. Colocar um cache na frente do banco de dados pode ajudar a absorver cargas desiguais e picos de tráfego.

### Cache do cliente

Os caches podem estar localizados no lado do cliente (SO ou navegador), [lado do servidor](#reverse-proxy-web-server), ou em uma camada de cache distinta.

### Cache de CDN

[CDNs](#content-delivery-network) são consideradas um tipo de cache.

### Cache do servidor web

[Proxies reversos](#reverse-proxy-web-server) e caches como [Varnish](https://www.varnish-cache.org/) podem servir conteúdo estático e dinâmico diretamente. Servidores web também podem armazenar requisições em cache, retornando respostas sem precisar contatar servidores de aplicação.

### Cache de banco de dados

Seu banco de dados geralmente inclui algum nível de cache em uma configuração padrão, otimizada para um caso de uso genérico. Ajustar essas configurações para padrões de uso específicos pode aumentar ainda mais o desempenho.

### Cache de aplicação

Caches em memória como Memcached e Redis são armazenamentos chave-valor entre sua aplicação e o armazenamento de dados. Como os dados são mantidos na RAM, é muito mais rápido que bancos de dados típicos, onde os dados são armazenados em disco. A RAM é mais limitada que o disco, então algoritmos de [invalidação de cache](https://pt.wikipedia.org/wiki/Algoritmos_de_cache) como [least recently used (LRU)](https://pt.wikipedia.org/wiki/Pol%C3%ADtica_de_substitui%C3%A7%C3%A3o_de_cache#Least_recently_used_(LRU)) podem ajudar a invalidar entradas "frias" e manter dados "quentes" na RAM.

O Redis possui os seguintes recursos adicionais:

* Opção de persistência
* Estruturas de dados embutidas, como conjuntos ordenados e listas

Existem múltiplos níveis que você pode fazer cache, que se encaixam em duas categorias gerais: **consultas de banco de dados** e **objetos**:

* Nível de linha
* Nível de consulta
* Objetos totalmente formados e serializáveis
* HTML totalmente renderizado

Geralmente, você deve tentar evitar o cache baseado em arquivos, pois ele dificulta a clonagem e o autoescalonamento.

### Cacheamento no nível da consulta ao banco de dados

Sempre que você consulta o banco de dados, faça o hash da consulta como uma chave e armazene o resultado no cache. Esta abordagem sofre com problemas de expiração:

* Difícil excluir um resultado em cache com consultas complexas
* Se um dado mudar, como uma célula de tabela, você precisa excluir todas as consultas em cache que possam incluir a célula alterada

### Cacheamento no nível do objeto

Veja seus dados como um objeto, semelhante ao que você faz com o código da sua aplicação. Faça sua aplicação montar o conjunto de dados do banco de dados em uma instância de classe ou estrutura(s) de dados:

* Remova o objeto do cache se seus dados subjacentes mudarem
* Permite processamento assíncrono: trabalhadores montam objetos consumindo o último objeto em cache

Sugestões do que cachear:

* Sessões de usuário
* Páginas web totalmente renderizadas
* Fluxos de atividade
* Dados de grafo de usuário

### Quando atualizar o cache

Como você só pode armazenar uma quantidade limitada de dados em cache, será necessário determinar qual estratégia de atualização de cache funciona melhor para seu caso de uso.

#### Cache-aside

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/ONjORqk.png">
  <br/>
  <i><a href=http://www.slideshare.net/tmatyashovsky/from-cache-to-in-memory-data-grid-introduction-to-hazelcast>Fonte: Do cache ao grid de dados em memória</a></i>
</p>

A aplicação é responsável por ler e escrever do armazenamento. O cache não interage diretamente com o armazenamento. A aplicação faz o seguinte:

* Procura a entrada no cache, resultando em falta de cache
* Carrega a entrada do banco de dados
* Adiciona a entrada ao cache
* Retorna a entrada

```python
def get_user(self, user_id):
    user = cache.get("user.{0}", user_id)
    if user is None:
        user = db.query("SELECT * FROM users WHERE user_id = {0}", user_id)
        if user is not None:
            key = "user.{0}".format(user_id)
            cache.set(key, json.dumps(user))
    return user
```

[Memcached](https://memcached.org/) é geralmente usado desta maneira.

Leituras subsequentes dos dados adicionados ao cache são rápidas. Cache-aside também é chamado de lazy loading. Apenas os dados solicitados são armazenados em cache, o que evita encher o cache com dados que não são requisitados.

##### Desvantagem(ns): cache-aside

* Cada falta no cache resulta em três viagens, o que pode causar um atraso perceptível.
* Os dados podem ficar desatualizados se forem atualizados no banco de dados. Este problema é mitigado definindo um time-to-live (TTL), que força uma atualização da entrada no cache, ou usando write-through.
* Quando um nó falha, ele é substituído por um novo nó vazio, aumentando a latência.

#### Write-through

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/0vBc0hN.png">
  <br/>
  <i><a href=http://www.slideshare.net/jboner/scalability-availability-stability-patterns/>Fonte: Escalabilidade, disponibilidade, estabilidade, padrões</a></i>
</p>

A aplicação utiliza o cache como o principal repositório de dados, lendo e escrevendo dados nele, enquanto o cache é responsável por ler e escrever no banco de dados:

* Aplicação adiciona/atualiza entrada no cache
* Cache grava a entrada de forma síncrona no repositório de dados
* Retorno

Código da aplicação:

```python
set_user(12345, {"foo":"bar"})
```

Código de cache:

```python
def set_user(user_id, values):
    user = db.query("UPDATE Users WHERE id = {0}", user_id, values)
    cache.set(user_id, user)
```
Write-through é uma operação geralmente lenta devido à escrita, mas leituras subsequentes dos dados recém-escritos são rápidas. Os usuários geralmente toleram melhor a latência ao atualizar dados do que ao ler dados. Os dados no cache não ficam desatualizados.

##### Desvantagem(ns): write-through

* Quando um novo nó é criado devido a falha ou escalonamento, o novo nó não irá armazenar entradas em cache até que a entrada seja atualizada no banco de dados. Cache-aside em conjunto com write-through pode mitigar esse problema.
* A maioria dos dados escritos pode nunca ser lida, o que pode ser minimizado com um TTL.

#### Write-behind (write-back)

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/rgSrvjG.png">
  <br/>
  <i><a href=http://www.slideshare.net/jboner/scalability-availability-stability-patterns/>Fonte: Escalabilidade, disponibilidade, estabilidade, padrões</a></i>
</p>

No write-behind, a aplicação faz o seguinte:

* Adiciona/atualiza a entrada no cache
* Escreve a entrada de forma assíncrona no armazenamento de dados, melhorando o desempenho de escrita

##### Desvantagem(ns): write-behind

* Pode ocorrer perda de dados se o cache cair antes que seu conteúdo seja gravado no armazenamento de dados.
* É mais complexo implementar write-behind do que implementar cache-aside ou write-through.

#### Refresh-ahead

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/kxtjqgE.png">
  <br/>
  <i><a href=http://www.slideshare.net/tmatyashovsky/from-cache-to-in-memory-data-grid-introduction-to-hazelcast>Fonte: Do cache ao data grid em memória</a></i>
</p>

Você pode configurar o cache para atualizar automaticamente qualquer entrada acessada recentemente antes de sua expiração.

Refresh-ahead pode resultar em menor latência em relação ao read-through se o cache conseguir prever com precisão quais itens provavelmente serão necessários no futuro.

##### Desvantagem(ns): refresh-ahead


* Não prever com precisão quais itens provavelmente serão necessários no futuro pode resultar em desempenho reduzido em comparação a não utilizar refresh-ahead.

### Desvantagem(ns): cache

* É necessário manter a consistência entre os caches e a fonte de verdade, como o banco de dados, através da [invalidação de cache](https://pt.wikipedia.org/wiki/Algoritmos_de_cache).
* A invalidação de cache é um problema difícil, há uma complexidade adicional associada ao momento de atualizar o cache.
* É preciso realizar alterações na aplicação, como adicionar Redis ou memcached.

### Fonte(s) e leituras adicionais

* [Do cache ao data grid em memória](http://www.slideshare.net/tmatyashovsky/from-cache-to-in-memory-data-grid-introduction-to-hazelcast)
* [Padrões de design de sistemas escaláveis](http://horicky.blogspot.com/2010/10/scalable-system-design-patterns.html)
* [Introdução à arquitetura de sistemas para escala](http://lethain.com/introduction-to-architecting-systems-for-scale/)
* [Escalabilidade, disponibilidade, estabilidade, padrões](http://www.slideshare.net/jboner/scalability-availability-stability-patterns/)
* [Escalabilidade](https://web.archive.org/web/20230126233752/https://www.lecloud.net/post/9246290032/scalability-for-dummies-part-3-cache)
* [Estratégias do AWS ElastiCache](http://docs.aws.amazon.com/AmazonElastiCache/latest/UserGuide/Strategies.html)
* [Wikipédia](https://pt.wikipedia.org/wiki/Cache_(computing))

## Assincronismo

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/54GYsSx.png">
  <br/>
  <i><a href=http://lethain.com/introduction-to-architecting-systems-for-scale/#platform_layer>Fonte: Introdução à arquitetura de sistemas para escala</a></i>
</p>

Fluxos de trabalho assíncronos ajudam a reduzir os tempos de requisição para operações caras que, de outra forma, seriam realizadas em linha. Eles também podem ajudar ao executar trabalhos demorados de forma antecipada, como agregações periódicas de dados.

### Filas de mensagens

Filas de mensagens recebem, armazenam e entregam mensagens. Se uma operação é muito lenta para ser feita em linha, você pode usar uma fila de mensagens com o seguinte fluxo de trabalho:

* Uma aplicação publica um trabalho na fila e, em seguida, notifica o usuário sobre o status do trabalho
* Um worker retira o trabalho da fila, processa e sinaliza que o trabalho está concluído

O usuário não é bloqueado e o trabalho é processado em segundo plano. Durante esse tempo, o cliente pode, opcionalmente, realizar um pequeno processamento para parecer que a tarefa foi concluída. Por exemplo, ao postar um tweet, ele poderia ser instantaneamente exibido na sua timeline, mas pode levar algum tempo até que seja realmente entregue a todos os seus seguidores.

**[Redis](https://redis.io/)** é útil como um broker de mensagens simples, mas mensagens podem ser perdidas.

**[RabbitMQ](https://www.rabbitmq.com/)** é popular, mas requer adaptação ao protocolo 'AMQP' e gerenciamento dos seus próprios nodes.

**[Amazon SQS](https://aws.amazon.com/sqs/)** é hospedado, mas pode apresentar alta latência e possibilidade de entrega duplicada de mensagens.

### Filas de tarefas

Filas de tarefas recebem tarefas e seus dados relacionados, executam-nas e entregam seus resultados. Elas podem suportar agendamento e ser usadas para rodar trabalhos computacionalmente intensivos em segundo plano.

**[Celery](https://docs.celeryproject.org/en/stable/)** tem suporte para agendamento e oferece principalmente suporte para Python.

### Contrapressão

Se as filas começarem a crescer significativamente, o tamanho da fila pode superar a memória, resultando em falhas de cache, leituras de disco e desempenho ainda mais lento. [Contrapressão](http://mechanical-sympathy.blogspot.com/2012/05/apply-back-pressure-when-overloaded.html) pode ajudar limitando o tamanho da fila, mantendo assim uma alta taxa de processamento e bons tempos de resposta para tarefas já na fila. Quando a fila está cheia, os clientes recebem o código de status "servidor ocupado" ou HTTP 503 para tentar novamente mais tarde. Os clientes podem tentar novamente mais tarde, talvez com [backoff exponencial](https://en.wikipedia.org/wiki/Exponential_backoff).

### Desvantagem(ns): assincronismo

* Casos de uso como cálculos baratos e fluxos de trabalho em tempo real podem ser mais adequados para operações síncronas, pois a introdução de filas pode adicionar atrasos e complexidade.

### Fonte(s) e leituras adicionais

* [It's all a numbers game](https://www.youtube.com/watch?v=1KRYH75wgy4)
* [Applying back pressure when overloaded](http://mechanical-sympathy.blogspot.com/2012/05/apply-back-pressure-when-overloaded.html)
* [Little's law](https://en.wikipedia.org/wiki/Little%27s_law)
* [Qual a diferença entre uma fila de mensagens e uma fila de tarefas?](https://www.quora.com/What-is-the-difference-between-a-message-queue-and-a-task-queue-Why-would-a-task-queue-require-a-message-broker-like-RabbitMQ-Redis-Celery-or-IronMQ-to-function)

## Comunicação

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/5KeocQs.jpg">
  <br/>
  <i><a href=http://www.escotal.com/osilayer.html>Fonte: Modelo OSI de 7 camadas</a></i>
</p>

### Protocolo de transferência de hipertexto (HTTP)

HTTP é um método para codificar e transportar dados entre um cliente e um servidor. É um protocolo de requisição/resposta: clientes enviam requisições e servidores enviam respostas com conteúdo relevante e informações de status de conclusão sobre a requisição. HTTP é auto-suficiente, permitindo que requisições e respostas passem por muitos roteadores e servidores intermediários que realizam balanceamento de carga, cache, criptografia e compressão.

Uma requisição HTTP básica consiste em um verbo (método) e um recurso (endpoint). Abaixo estão verbos HTTP comuns:

| Verbo | Descrição | Idempotente* | Seguro | Cacheável |
|---|---|---|---|---|
| GET | Lê um recurso | Sim | Sim | Sim |
| POST | Cria um recurso ou aciona um processo que manipula dados | Não | Não | Sim, se a resposta contiver informações de atualidade |
| PUT | Cria ou substitui um recurso | Sim | Não | Não |
| PATCH | Atualiza parcialmente um recurso | Não | Não | Sim, se a resposta contiver informações de atualidade |
| DELETE | Exclui um recurso | Sim | Não | Não |

*Pode ser chamado várias vezes sem resultados diferentes.

HTTP é um protocolo de camada de aplicação que depende de protocolos de camadas inferiores como **TCP** e **UDP**.

#### Fonte(s) e leituras adicionais: HTTP

* [O que é HTTP?](https://www.nginx.com/resources/glossary/http/)
* [Diferença entre HTTP e TCP](https://www.quora.com/What-is-the-difference-between-HTTP-protocol-and-TCP-protocol)
* [Diferença entre PUT e PATCH](https://laracasts.com/discuss/channels/general-discussion/whats-the-differences-between-put-and-patch?page=1)

### Protocolo de controle de transmissão (TCP)

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/JdAsdvG.jpg">
  <br/>
  <i><a href=http://www.wildbunny.co.uk/blog/2012/10/09/how-to-make-a-multi-player-game-part-1/>Fonte: Como criar um jogo multiplayer</a></i>
</p>

TCP é um protocolo orientado à conexão sobre uma [rede IP](https://en.wikipedia.org/wiki/Internet_Protocol).  A conexão é estabelecida e finalizada usando um [handshake](https://en.wikipedia.org/wiki/Handshaking).  Todos os pacotes enviados são garantidos de chegar ao destino na ordem original e sem corrupção através de:

* Números de sequência e [campos de checksum](https://en.wikipedia.org/wiki/Transmission_Control_Protocol#Checksum_computation) para cada pacote
* Pacotes de [confirmação](https://en.wikipedia.org/wiki/Acknowledgement_(data_networks)) e retransmissão automática

Se o remetente não receber uma resposta correta, irá reenviar os pacotes.  Se houver múltiplos timeouts, a conexão é encerrada.  TCP também implementa [controle de fluxo](https://en.wikipedia.org/wiki/Flow_control_(data)) e [controle de congestionamento](https://en.wikipedia.org/wiki/Network_congestion#Congestion_control).  Essas garantias causam atrasos e geralmente resultam em transmissão menos eficiente do que UDP.

Para garantir alta taxa de transferência, servidores web podem manter um grande número de conexões TCP abertas, resultando em alto uso de memória.  Pode ser caro manter muitas conexões abertas entre threads do servidor web e, por exemplo, um servidor [memcached](https://memcached.org/).  [Pool de conexões](https://en.wikipedia.org/wiki/Connection_pool) pode ajudar, além de alternar para UDP onde aplicável.

TCP é útil para aplicações que exigem alta confiabilidade, mas são menos críticas quanto ao tempo.  Alguns exemplos incluem servidores web, informações de banco de dados, SMTP, FTP e SSH.

Use TCP ao invés de UDP quando:

* Você precisa que todos os dados cheguem intactos
* Você deseja estimar automaticamente o melhor uso da largura de banda da rede

### Protocolo de datagrama de usuário (UDP)

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/yzDrJtA.jpg">
  <br/>
  <i><a href=http://www.wildbunny.co.uk/blog/2012/10/09/how-to-make-a-multi-player-game-part-1/>Fonte: Como criar um jogo multiplayer</a></i>
</p>

UDP é sem conexão. Datagramas (análogos a pacotes) são garantidos apenas no nível do datagrama. Os datagramas podem chegar ao destino fora de ordem ou não chegar. O UDP não suporta controle de congestionamento. Sem as garantias que o TCP oferece, o UDP geralmente é mais eficiente.

UDP pode fazer broadcast, enviando datagramas para todos os dispositivos na sub-rede. Isso é útil com [DHCP](https://pt.wikipedia.org/wiki/Protocolo_de_Configura%C3%A7%C3%A3o_Din%C3%A2mica_de_Host) porque o cliente ainda não recebeu um endereço IP, impedindo uma forma do TCP transmitir sem o endereço IP.

UDP é menos confiável, mas funciona bem em casos de uso em tempo real, como VoIP, vídeo chamada, streaming e jogos multiplayer em tempo real.

Use UDP em vez de TCP quando:

* Você precisa da menor latência possível
* Dados atrasados são piores do que perda de dados
* Você deseja implementar sua própria correção de erros

#### Fonte(s) e leitura adicional: TCP e UDP

* [Redes para programação de jogos](http://gafferongames.com/networking-for-game-programmers/udp-vs-tcp/)
* [Principais diferenças entre os protocolos TCP e UDP](http://www.cyberciti.biz/faq/key-differences-between-tcp-and-udp-protocols/)
* [Diferença entre TCP e UDP](http://stackoverflow.com/questions/5970383/difference-between-tcp-and-udp)
* [Protocolo de controle de transmissão](https://pt.wikipedia.org/wiki/Transmission_Control_Protocol)
* [Protocolo de datagrama de usuário](https://pt.wikipedia.org/wiki/User_Datagram_Protocol)
* [Escalando o memcache no Facebook](http://www.cs.bu.edu/~jappavoo/jappavoo.github.com/451/papers/memcache-fb.pdf)

### Chamada de procedimento remoto (RPC)

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/iF4Mkb5.png">
  <br/>
  <i><a href=http://www.puncsky.com/blog/2016-02-13-crack-the-system-design-interview>Fonte: Crack the system design interview</a></i>
</p>

Em um RPC, um cliente faz com que um procedimento seja executado em um espaço de endereço diferente, geralmente em um servidor remoto. O procedimento é codificado como se fosse uma chamada de procedimento local, abstraindo os detalhes de como comunicar com o servidor a partir do programa cliente. Chamadas remotas geralmente são mais lentas e menos confiáveis do que chamadas locais, por isso é útil distinguir chamadas RPC de chamadas locais. Frameworks RPC populares incluem [Protobuf](https://developers.google.com/protocol-buffers/), [Thrift](https://thrift.apache.org/), e [Avro](https://avro.apache.org/docs/current/).

RPC é um protocolo de requisição-resposta:

* **Programa cliente** - Chama o procedimento stub do cliente. Os parâmetros são empilhados como em uma chamada de procedimento local.
* **Procedimento stub do cliente** - Empacota (marshals) o id do procedimento e os argumentos em uma mensagem de requisição.
* **Módulo de comunicação do cliente** - O sistema operacional envia a mensagem do cliente para o servidor.
* **Módulo de comunicação do servidor** - O sistema operacional passa os pacotes recebidos para o procedimento stub do servidor.
* **Procedimento stub do servidor** - Desempacota (unmarshalls) os resultados, chama o procedimento do servidor correspondente ao id do procedimento e passa os argumentos fornecidos.
* A resposta do servidor repete os passos acima na ordem inversa.

Exemplo de chamadas RPC:

```
GET /someoperation?data=anId

POST /anotheroperation
{
  "data":"anId";
  "anotherdata": "another value"
}
```

RPC está focado em expor comportamentos. RPCs são frequentemente usados por motivos de desempenho em comunicações internas, pois você pode criar chamadas nativas sob medida para melhor atender aos seus casos de uso.

Escolha uma biblioteca nativa (também conhecida como SDK) quando:

* Você conhece sua plataforma alvo.
* Você quer controlar como sua "lógica" é acessada.
* Você quer controlar como o controle de erros ocorre fora da sua biblioteca.
* Desempenho e experiência do usuário final são sua principal preocupação.

APIs HTTP seguindo o **REST** tendem a ser usadas com mais frequência para APIs públicas.

#### Desvantagem(ns): RPC

* Clientes RPC tornam-se fortemente acoplados à implementação do serviço.
* Uma nova API deve ser definida para cada nova operação ou caso de uso.
* Pode ser difícil depurar RPC.
* Você pode não conseguir aproveitar tecnologias existentes imediatamente. Por exemplo, pode exigir esforço adicional para garantir que as [chamadas RPC sejam devidamente cacheadas](https://web.archive.org/web/20170608193645/http://etherealbits.com/2012/12/debunking-the-myths-of-rpc-rest/) em servidores de cache como o [Squid](http://www.squid-cache.org/).

### Transferência de estado representacional (REST)

REST é um estilo arquitetural que impõe um modelo cliente/servidor onde o cliente atua sobre um conjunto de recursos gerenciados pelo servidor. O servidor fornece uma representação dos recursos e ações que podem manipular ou obter uma nova representação dos recursos. Toda comunicação deve ser sem estado e cacheável.

Existem quatro qualidades de uma interface RESTful:

* **Identificar recursos (URI no HTTP)** - use o mesmo URI independentemente da operação.
* **Alterar com representações (Verbos no HTTP)** - use verbos, cabeçalhos e corpo.
* **Mensagem de erro auto-descritiva (resposta de status no HTTP)** - Use códigos de status, não reinvente a roda.
* **[HATEOAS](http://restcookbook.com/Basics/hateoas/) (interface HTML para HTTP)** - seu serviço web deve ser totalmente acessível em um navegador.

Exemplo de chamadas REST:

```
GET /someresources/anId

PUT /someresources/anId
{"anotherdata": "another value"}
```

REST é focado na exposição de dados. Minimiza o acoplamento entre cliente/servidor e é frequentemente usado para APIs HTTP públicas. REST utiliza um método mais genérico e uniforme de expor recursos através de URIs, [representação por meio de cabeçalhos](https://github.com/for-GET/know-your-http-well/blob/master/headers.md), e ações por meio de verbos como GET, POST, PUT, DELETE e PATCH. Por ser stateless, REST é excelente para escalabilidade horizontal e particionamento.

#### Desvantagem(ns): REST

* Com REST sendo focado em expor dados, pode não ser ideal se os recursos não são naturalmente organizados ou acessados em uma hierarquia simples. Por exemplo, retornar todos os registros atualizados na última hora que correspondam a um conjunto específico de eventos não é facilmente expresso como um caminho. Com REST, isso provavelmente será implementado com uma combinação de caminho URI, parâmetros de consulta e possivelmente o corpo da requisição.
* REST normalmente depende de poucos verbos (GET, POST, PUT, DELETE e PATCH), o que às vezes não se encaixa no seu caso de uso. Por exemplo, mover documentos expirados para a pasta de arquivo pode não se encaixar adequadamente nesses verbos.
* Buscar recursos complexos com hierarquias aninhadas requer múltiplas idas e vindas entre o cliente e servidor para renderizar uma única visualização, por exemplo, buscar o conteúdo de uma postagem de blog e os comentários dessa postagem. Para aplicativos móveis operando em condições de rede variáveis, essas múltiplas idas e vindas são altamente indesejáveis.
* Com o tempo, mais campos podem ser adicionados à resposta da API e clientes mais antigos receberão todos os novos campos de dados, mesmo aqueles que não precisam, o que aumenta o tamanho do payload e resulta em maiores latências.

### Comparação de chamadas RPC e REST

| Operação | RPC | REST |
|---|---|---|
| Cadastro    | **POST** /signup | **POST** /persons |
| Demissão    | **POST** /resign<br/>{<br/>"personid": "1234"<br/>} | **DELETE** /persons/1234 |
| Ler uma pessoa | **GET** /readPerson?personid=1234 | **GET** /persons/1234 |
| Ler lista de itens de uma pessoa | **GET** /readUsersItemsList?personid=1234 | **GET** /persons/1234/items |
| Adicionar um item à lista de itens de uma pessoa | **POST** /addItemToUsersItemsList<br/>{<br/>"personid": "1234";<br/>"itemid": "456"<br/>} | **POST** /persons/1234/items<br/>{<br/>"itemid": "456"<br/>} |
| Atualizar um item    | **POST** /modifyItem<br/>{<br/>"itemid": "456";<br/>"key": "value"<br/>} | **PUT** /items/456<br/>{<br/>"key": "value"<br/>} |
| Excluir um item | **POST** /removeItem<br/>{<br/>"itemid": "456"<br/>} | **DELETE** /items/456 |

<p align="center">
  <i><a href=https://apihandyman.io/do-you-really-know-why-you-prefer-rest-over-rpc/>Fonte: Você realmente sabe por que prefere REST ao invés de RPC</a></i>
</p>

#### Fonte(s) e leituras adicionais: REST e RPC

* [Você realmente sabe por que prefere REST ao invés de RPC](https://apihandyman.io/do-you-really-know-why-you-prefer-rest-over-rpc/)
* [Quando abordagens RPC-ish são mais apropriadas que REST?](http://programmers.stackexchange.com/a/181186)
* [REST vs JSON-RPC](http://stackoverflow.com/questions/15056878/rest-vs-json-rpc)
* [Desmistificando os mitos de RPC e REST](https://web.archive.org/web/20170608193645/http://etherealbits.com/2012/12/debunking-the-myths-of-rpc-rest/)
* [Quais são as desvantagens de usar REST](https://www.quora.com/What-are-the-drawbacks-of-using-RESTful-APIs)
* [Crack the system design interview](http://www.puncsky.com/blog/2016-02-13-crack-the-system-design-interview)
* [Thrift](https://code.facebook.com/posts/1468950976659943/)
* [Por que REST para uso interno e não RPC](http://arstechnica.com/civis/viewtopic.php?t=1190508)

## Segurança

Esta seção poderia ser atualizada. Considere [contribuir](#contributing)!
Segurança é um tópico amplo. A menos que você tenha experiência considerável, formação em segurança ou esteja se candidatando a uma vaga que exija conhecimento em segurança, provavelmente não precisará saber mais do que o básico:

* Criptografe dados em trânsito e em repouso.
* Sanitizar todas as entradas do usuário ou quaisquer parâmetros de entrada expostos ao usuário para prevenir [XSS](https://pt.wikipedia.org/wiki/Cross-site_scripting) e [injeção de SQL](https://pt.wikipedia.org/wiki/SQL_injection).
* Use consultas parametrizadas para evitar injeção de SQL.
* Use o princípio do [menor privilégio](https://pt.wikipedia.org/wiki/Princ%C3%ADpio_do_menor_privil%C3%A9gio).

### Fonte(s) e leituras adicionais

* [Lista de verificação de segurança de API](https://github.com/shieldfy/API-Security-Checklist)
* [Guia de segurança para desenvolvedores](https://github.com/FallibleInc/security-guide-for-developers)
* [OWASP top ten](https://www.owasp.org/index.php/OWASP_Top_Ten_Cheat_Sheet)

## Apêndice

Às vezes, você será solicitado a fazer estimativas rápidas. Por exemplo, pode ser necessário determinar quanto tempo levará para gerar 100 miniaturas de imagens a partir do disco ou quanta memória uma estrutura de dados ocupará. A **tabela de potências de dois** e **números de latência que todo programador deve saber** são referências úteis.

### Tabela de potências de dois


```
Power           Exact Value         Approx Value        Bytes
---------------------------------------------------------------
7                             128
8                             256
10                           1024   1 thousand           1 KB
16                         65,536                       64 KB
20                      1,048,576   1 million            1 MB
30                  1,073,741,824   1 billion            1 GB
32                  4,294,967,296                        4 GB
40              1,099,511,627,776   1 trillion           1 TB
```

#### Fonte(s) e leitura adicional

* [Potências de dois](https://pt.wikipedia.org/wiki/Pot%C3%AAncia_de_dois)

### Números de latência que todo programador deve conhecer

```
Latency Comparison Numbers
--------------------------
L1 cache reference                           0.5 ns
Branch mispredict                            5   ns
L2 cache reference                           7   ns                      14x L1 cache
Mutex lock/unlock                           25   ns
Main memory reference                      100   ns                      20x L2 cache, 200x L1 cache
Compress 1K bytes with Zippy            10,000   ns       10 us
Send 1 KB bytes over 1 Gbps network     10,000   ns       10 us
Read 4 KB randomly from SSD*           150,000   ns      150 us          ~1GB/sec SSD
Read 1 MB sequentially from memory     250,000   ns      250 us
Round trip within same datacenter      500,000   ns      500 us
Read 1 MB sequentially from SSD*     1,000,000   ns    1,000 us    1 ms  ~1GB/sec SSD, 4X memory
HDD seek                            10,000,000   ns   10,000 us   10 ms  20x datacenter roundtrip
Read 1 MB sequentially from 1 Gbps  10,000,000   ns   10,000 us   10 ms  40x memory, 10X SSD
Read 1 MB sequentially from HDD     30,000,000   ns   30,000 us   30 ms 120x memory, 30X SSD
Send packet CA->Netherlands->CA    150,000,000   ns  150,000 us  150 ms

Notes
-----
1 ns = 10^-9 seconds
1 us = 10^-6 seconds = 1,000 ns
1 ms = 10^-3 seconds = 1,000 us = 1,000,000 ns
```

Métricas úteis com base nos números acima:

* Leitura sequencial de HDD a 30 MB/s
* Leitura sequencial de Ethernet de 1 Gbps a 100 MB/s
* Leitura sequencial de SSD a 1 GB/s
* Leitura sequencial de memória principal a 4 GB/s
* 6-7 viagens de ida e volta mundial por segundo
* 2.000 viagens de ida e volta por segundo dentro de um data center

#### Visualização dos números de latência

![](https://camo.githubusercontent.com/77f72259e1eb58596b564d1ad823af1853bc60a3/687474703a2f2f692e696d6775722e636f6d2f6b307431652e706e67)

#### Fonte(s) e leitura adicional

* [Números de latência que todo programador deve saber - 1](https://gist.github.com/jboner/2841832)
* [Números de latência que todo programador deve saber - 2](https://gist.github.com/hellerbarde/2843375)
* [Projetos, lições e conselhos de construção de grandes sistemas distribuídos](http://www.cs.cornell.edu/projects/ladis2009/talks/dean-keynote-ladis2009.pdf)
* [Conselhos de Engenharia de Software de Grandes Sistemas Distribuídos](https://static.googleusercontent.com/media/research.google.com/en//people/jeff/stanford-295-talk.pdf)

### Questões adicionais de entrevistas de design de sistemas

> Questões comuns de entrevistas de design de sistemas, com links para recursos sobre como resolver cada uma.

| Pergunta | Referência(s) |
|---|---|
| Projetar um serviço de sincronização de arquivos como Dropbox | [youtube.com](https://www.youtube.com/watch?v=PE4gwstWhmc) |
| Projetar um mecanismo de busca como Google | [queue.acm.org](http://queue.acm.org/detail.cfm?id=988407)<br/>[stackexchange.com](http://programmers.stackexchange.com/questions/38324/interview-question-how-would-you-implement-google-search)<br/>[ardendertat.com](http://www.ardendertat.com/2012/01/11/implementing-search-engines/)<br/>[stanford.edu](http://infolab.stanford.edu/~backrub/google.html) |
| Projetar um web crawler escalável como o Google | [quora.com](https://www.quora.com/How-can-I-build-a-web-crawler-from-scratch) |
| Projetar Google Docs | [code.google.com](https://code.google.com/p/google-mobwrite/)<br/>[neil.fraser.name](https://neil.fraser.name/writing/sync/) |
| Projetar um armazenamento chave-valor como Redis | [slideshare.net](http://www.slideshare.net/dvirsky/introduction-to-redis) |
| Projetar um sistema de cache como Memcached | [slideshare.net](http://www.slideshare.net/oemebamo/introduction-to-memcached) |
| Projetar um sistema de recomendação como o da Amazon | [hulu.com](https://web.archive.org/web/20170406065247/http://tech.hulu.com/blog/2011/09/19/recommendation-system.html)<br/>[ijcai13.org](http://ijcai13.org/files/tutorial_slides/td3.pdf) |
| Projetar um sistema tinyurl como Bitly | [n00tc0d3r.blogspot.com](http://n00tc0d3r.blogspot.com/) |
| Projetar um aplicativo de chat como WhatsApp | [highscalability.com](http://highscalability.com/blog/2014/2/26/the-whatsapp-architecture-facebook-bought-for-19-billion.html)
| Projetar um sistema de compartilhamento de fotos como Instagram | [highscalability.com](http://highscalability.com/flickr-architecture)<br/>[highscalability.com](http://highscalability.com/blog/2011/12/6/instagram-architecture-14-million-users-terabytes-of-photos.html) |
| Projetar a função de feed de notícias do Facebook | [quora.com](http://www.quora.com/What-are-best-practices-for-building-something-like-a-News-Feed)<br/>[quora.com](http://www.quora.com/Activity-Streams/What-are-the-scaling-issues-to-keep-in-mind-while-developing-a-social-network-feed)<br/>[slideshare.net](http://www.slideshare.net/danmckinley/etsy-activity-feeds-architecture) |
| Projetar a função de linha do tempo do Facebook | [facebook.com](https://www.facebook.com/note.php?note_id=10150468255628920)<br/>[highscalability.com](http://highscalability.com/blog/2012/1/23/facebook-timeline-brought-to-you-by-the-power-of-denormaliza.html) |
| Projetar a função de chat do Facebook | [erlang-factory.com](http://www.erlang-factory.com/upload/presentations/31/EugeneLetuchy-ErlangatFacebook.pdf)<br/>[facebook.com](https://www.facebook.com/note.php?note_id=14218138919&id=9445547199&index=0) |
| Projete uma função de busca em grafos como a do Facebook | [facebook.com](https://www.facebook.com/notes/facebook-engineering/under-the-hood-building-out-the-infrastructure-for-graph-search/10151347573598920)<br/>[facebook.com](https://www.facebook.com/notes/facebook-engineering/under-the-hood-indexing-and-ranking-in-graph-search/10151361720763920)<br/>[facebook.com](https://www.facebook.com/notes/facebook-engineering/under-the-hood-the-natural-language-interface-of-graph-search/10151432733048920) |
| Projete uma rede de entrega de conteúdo como a CloudFlare | [figshare.com](https://figshare.com/articles/Globally_distributed_content_delivery/6605972) |
| Projete um sistema de tópicos em tendência como o do Twitter | [michael-noll.com](http://www.michael-noll.com/blog/2013/01/18/implementing-real-time-trending-topics-in-storm/)<br/>[snikolov .wordpress.com](http://snikolov.wordpress.com/2012/11/14/early-detection-of-twitter-trends/) |
| Projete um sistema de geração de ID aleatório | [blog.twitter.com](https://blog.twitter.com/2010/announcing-snowflake)<br/>[github.com](https://github.com/twitter/snowflake/) |
| Retorne os top k pedidos durante um intervalo de tempo | [cs.ucsb.edu](https://www.cs.ucsb.edu/sites/default/files/documents/2005-23.pdf)<br/>[wpi.edu](http://davis.wpi.edu/xmdv/docs/EDBT11-diyang.pdf) |
| Projete um sistema que serve dados de múltiplos data centers | [highscalability.com](http://highscalability.com/blog/2009/8/24/how-google-serves-data-from-multiple-datacenters.html) |
| Projete um jogo de cartas multiplayer online | [indieflashblog.com](https://web.archive.org/web/20180929181117/http://www.indieflashblog.com/how-to-create-an-asynchronous-multiplayer-game.html)<br/>[buildnewgames.com](http://buildnewgames.com/real-time-multiplayer/) |
| Projete um sistema de coleta de lixo | [stuffwithstuff.com](http://journal.stuffwithstuff.com/2013/12/08/babys-first-garbage-collector/)<br/>[washington.edu](http://courses.cs.washington.edu/courses/csep521/07wi/prj/rick.pdf) |
| Projete um limitador de taxa de API | [https://stripe.com/blog/](https://stripe.com/blog/rate-limiters) |
| Projete uma Bolsa de Valores (como NASDAQ ou Binance) | [Jane Street](https://youtu.be/b1e4t2k2KJY)<br/>[Implementação em Golang](https://around25.com/blog/building-a-trading-engine-for-a-crypto-exchange/)<br/>[Implementação em Go](http://bhomnick.net/building-a-simple-limit-order-in-go/) |
| Adicione uma questão de design de sistema | [Contribua](#contributing) |

### Arquiteturas do mundo real

> Artigos sobre como sistemas do mundo real são projetados.

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/TcUo2fw.png">
  <br/>
  <i><a href=https://www.infoq.com/presentations/Twitter-Timeline-Scalability>Fonte: Linhas do tempo do Twitter em escala</a></i>
</p>

**Não foque em detalhes minuciosos nos artigos a seguir, em vez disso:**

* Identifique princípios compartilhados, tecnologias comuns e padrões nesses artigos
* Estude quais problemas são resolvidos por cada componente, onde funciona, onde não funciona
* Revise os aprendizados obtidos

|Tipo | Sistema | Referência(s) |
|---|---|---|
| Processamento de dados | **MapReduce** - Processamento distribuído de dados do Google | [research.google.com](http://static.googleusercontent.com/media/research.google.com/zh-CN/us/archive/mapreduce-osdi04.pdf) |
| Processamento de dados | **Spark** - Processamento distribuído de dados da Databricks | [slideshare.net](http://www.slideshare.net/AGrishchenko/apache-spark-architecture) |
| Processamento de dados | **Storm** - Processamento distribuído de dados do Twitter | [slideshare.net](http://www.slideshare.net/previa/storm-16094009) |
| | | |
| Armazenamento de dados | **Bigtable** - Banco de dados distribuído orientado a colunas do Google | [harvard.edu](http://www.read.seas.harvard.edu/~kohler/class/cs239-w08/chang06bigtable.pdf) |
| Armazenamento de dados | **HBase** - Implementação open source do Bigtable | [slideshare.net](http://www.slideshare.net/alexbaranau/intro-to-hbase) |
| Armazenamento de dados | **Cassandra** - Banco de dados distribuído orientado a colunas do Facebook | [slideshare.net](http://www.slideshare.net/planetcassandra/cassandra-introduction-features-30103666)
| Armazenamento de dados | **DynamoDB** - Banco de dados orientado a documentos da Amazon | [harvard.edu](http://www.read.seas.harvard.edu/~kohler/class/cs239-w08/decandia07dynamo.pdf) |
| Armazenamento de dados | **MongoDB** - Banco de dados orientado a documentos | [slideshare.net](http://www.slideshare.net/mdirolf/introduction-to-mongodb) |
| Armazenamento de dados | **Spanner** - Banco de dados distribuído globalmente do Google | [research.google.com](http://research.google.com/archive/spanner-osdi2012.pdf) |
| Armazenamento de dados | **Memcached** - Sistema distribuído de cache de memória | [slideshare.net](http://www.slideshare.net/oemebamo/introduction-to-memcached) |
| Armazenamento de dados | **Redis** - Sistema distribuído de cache de memória com persistência e tipos de valores | [slideshare.net](http://www.slideshare.net/dvirsky/introduction-to-redis) |
| | | |
| Sistema de arquivos | **Google File System (GFS)** - Sistema de arquivos distribuído | [research.google.com](http://static.googleusercontent.com/media/research.google.com/zh-CN/us/archive/gfs-sosp2003.pdf) |
| Sistema de arquivos | **Hadoop File System (HDFS)** - Implementação open source do GFS | [apache.org](http://hadoop.apache.org/docs/stable/hadoop-project-dist/hadoop-hdfs/HdfsDesign.html) |
| | | |
| Diversos | **Chubby** - Serviço de bloqueio para sistemas distribuídos fracamente acoplados do Google | [research.google.com](http://static.googleusercontent.com/external_content/untrusted_dlcp/research.google.com/en/us/archive/chubby-osdi06.pdf) |
| Diversos | **Dapper** - Infraestrutura de rastreamento de sistemas distribuídos | [research.google.com](http://static.googleusercontent.com/media/research.google.com/en//pubs/archive/36356.pdf)
| Diversos | **Kafka** - Fila de mensagens pub/sub do LinkedIn | [slideshare.net](http://www.slideshare.net/mumrah/kafka-talk-tri-hug) |
| Diversos | **Zookeeper** - Infraestrutura centralizada e serviços para habilitar sincronização | [slideshare.net](http://www.slideshare.net/sauravhaloi/introduction-to-apache-zookeeper) |
| | Adicione uma arquitetura | [Contribua](#contributing) |

### Arquiteturas de empresas

| Empresa | Referência(s) |
|---|---|
| Amazon | [Arquitetura da Amazon](http://highscalability.com/amazon-architecture) |
| Cinchcast | [Produzindo 1.500 horas de áudio por dia](http://highscalability.com/blog/2012/7/16/cinchcast-architecture-producing-1500-hours-of-audio-every-d.html) |
| DataSift | [Mineração de dados em tempo real a 120.000 tweets por segundo](http://highscalability.com/blog/2011/11/29/datasift-architecture-realtime-datamining-at-120000-tweets-p.html) |
| Dropbox | [Como escalamos o Dropbox](https://www.youtube.com/watch?v=PE4gwstWhmc) |
| ESPN | [Operando a 100.000 duh nuh nuhs por segundo](http://highscalability.com/blog/2013/11/4/espns-architecture-at-scale-operating-at-100000-duh-nuh-nuhs.html) |
| Google | [Arquitetura do Google](http://highscalability.com/google-architecture) |
| Instagram | [14 milhões de usuários, terabytes de fotos](http://highscalability.com/blog/2011/12/6/instagram-architecture-14-million-users-terabytes-of-photos.html)<br/>[O que move o Instagram](http://instagram-engineering.tumblr.com/post/13649370142/what-powers-instagram-hundreds-of-instances) |
| Justin.tv | [Arquitetura de transmissão de vídeo ao vivo do Justin.tv](http://highscalability.com/blog/2010/3/16/justintvs-live-video-broadcasting-architecture.html) |
| Facebook | [Escalando o memcached no Facebook](https://cs.uwaterloo.ca/~brecht/courses/854-Emerging-2014/readings/key-value/fb-memcached-nsdi-2013.pdf)<br/>[TAO: Data store distribuído do Facebook para o grafo social](https://cs.uwaterloo.ca/~brecht/courses/854-Emerging-2014/readings/data-store/tao-facebook-distributed-datastore-atc-2013.pdf)<br/>[Armazenamento de fotos do Facebook](https://www.usenix.org/legacy/event/osdi10/tech/full_papers/Beaver.pdf)<br/>[Como o Facebook Live transmite para 800.000 espectadores simultâneos](http://highscalability.com/blog/2016/6/27/how-facebook-live-streams-to-800000-simultaneous-viewers.html) |
| Flickr | [Arquitetura do Flickr](http://highscalability.com/flickr-architecture) |
| Mailbox | [De 0 a um milhão de usuários em 6 semanas](http://highscalability.com/blog/2013/6/18/scaling-mailbox-from-0-to-one-million-users-in-6-weeks-and-1.html) |
| Netflix | [Uma visão 360 graus de toda a stack do Netflix](http://highscalability.com/blog/2015/11/9/a-360-degree-view-of-the-entire-netflix-stack.html)<br/>[Netflix: O que acontece quando você aperta play?](http://highscalability.com/blog/2017/12/11/netflix-what-happens-when-you-press-play.html) |
| Pinterest | [De 0 a dezenas de bilhões de page views por mês](http://highscalability.com/blog/2013/4/15/scaling-pinterest-from-0-to-10s-of-billions-of-page-views-a.html)<br/>[18 milhões de visitantes, crescimento de 10x, 12 funcionários](http://highscalability.com/blog/2012/5/21/pinterest-architecture-update-18-million-visitors-10x-growth.html) |
| Playfish | [50 milhões de usuários mensais e crescendo](http://highscalability.com/blog/2010/9/21/playfishs-social-gaming-architecture-50-million-monthly-user.html) |
| PlentyOfFish | [Arquitetura do PlentyOfFish](http://highscalability.com/plentyoffish-architecture) |
| Salesforce | [Como eles processam 1,3 bilhão de transações por dia](http://highscalability.com/blog/2013/9/23/salesforce-architecture-how-they-handle-13-billion-transacti.html) |
| Stack Overflow | [Arquitetura do Stack Overflow](http://highscalability.com/blog/2009/8/5/stack-overflow-architecture.html) |
| TripAdvisor | [40M visitantes, 200M page views dinâmicas, 30TB de dados](http://highscalability.com/blog/2011/6/27/tripadvisor-architecture-40m-visitors-200m-dynamic-page-view.html) |
| Tumblr | [15 bilhões de page views por mês](http://highscalability.com/blog/2012/2/13/tumblr-architecture-15-billion-page-views-a-month-and-harder.html) |
| Twitter | [Deixando o Twitter 10.000% mais rápido](http://highscalability.com/scaling-twitter-making-twitter-10000-percent-faster)<br/>[Armazenando 250 milhões de tweets por dia usando MySQL](http://highscalability.com/blog/2011/12/19/how-twitter-stores-250-million-tweets-a-day-using-mysql.html)<br/>[150M usuários ativos, 300K QPS, um firehose de 22 MB/S](http://highscalability.com/blog/2013/7/8/the-architecture-twitter-uses-to-deal-with-150m-active-users.html)<br/>[Timelines em escala](https://www.infoq.com/presentations/Twitter-Timeline-Scalability)<br/>[Big e small data no Twitter](https://www.youtube.com/watch?v=5cKTP36HVgI)<br/>[Operações no Twitter: escalando além de 100 milhões de usuários](https://www.youtube.com/watch?v=z8LU0Cj6BOU)<br/>[Como o Twitter processa 3.000 imagens por segundo](http://highscalability.com/blog/2016/4/20/how-twitter-handles-3000-images-per-second.html) |
| Uber | [Como o Uber escala sua plataforma de mercado em tempo real](http://highscalability.com/blog/2015/9/14/how-uber-scales-their-real-time-market-platform.html)<br/>[Lições aprendidas ao escalar o Uber para 2000 engenheiros, 1000 serviços e 8000 repositórios Git](http://highscalability.com/blog/2016/10/12/lessons-learned-from-scaling-uber-to-2000-engineers-1000-ser.html) |
| WhatsApp | [A arquitetura do WhatsApp que o Facebook comprou por US$19 bilhões](http://highscalability.com/blog/2014/2/26/the-whatsapp-architecture-facebook-bought-for-19-billion.html) |
| YouTube | [Escalabilidade do YouTube](https://www.youtube.com/watch?v=w5WVu624fY8)<br/>[Arquitetura do YouTube](http://highscalability.com/youtube-architecture) |

### Blogs de engenharia de empresas

> Arquiteturas das empresas com as quais você está entrevistando.
>
> As perguntas que você encontrar podem ser do mesmo domínio.

* [Airbnb Engineering](http://nerds.airbnb.com/)
* [Atlassian Developers](https://developer.atlassian.com/blog/)
* [AWS Blog](https://aws.amazon.com/blogs/aws/)
* [Bitly Engineering Blog](http://word.bitly.com/)
* [Box Blogs](https://blog.box.com/blog/category/engineering)
* [Cloudera Developer Blog](http://blog.cloudera.com/)
* [Dropbox Tech Blog](https://tech.dropbox.com/)
* [Engineering at Quora](https://www.quora.com/q/quoraengineering)
* [Ebay Tech Blog](http://www.ebaytechblog.com/)
* [Evernote Tech Blog](https://blog.evernote.com/tech/)
* [Etsy Code as Craft](http://codeascraft.com/)
* [Facebook Engineering](https://www.facebook.com/Engineering)
* [Flickr Code](http://code.flickr.net/)
* [Foursquare Engineering Blog](http://engineering.foursquare.com/)
* [GitHub Engineering Blog](https://github.blog/category/engineering)
* [Google Research Blog](http://googleresearch.blogspot.com/)
* [Groupon Engineering Blog](https://engineering.groupon.com/)
* [Heroku Engineering Blog](https://engineering.heroku.com/)
* [Hubspot Engineering Blog](http://product.hubspot.com/blog/topic/engineering)
* [High Scalability](http://highscalability.com/)
* [Instagram Engineering](http://instagram-engineering.tumblr.com/)
* [Intel Software Blog](https://software.intel.com/en-us/blogs/)
* [Jane Street Tech Blog](https://blogs.janestreet.com/category/ocaml/)
* [LinkedIn Engineering](http://engineering.linkedin.com/blog)
* [Microsoft Engineering](https://engineering.microsoft.com/)
* [Microsoft Python Engineering](https://blogs.msdn.microsoft.com/pythonengineering/)
* [Netflix Tech Blog](http://techblog.netflix.com/)
* [Paypal Developer Blog](https://medium.com/paypal-engineering)
* [Pinterest Engineering Blog](https://medium.com/@Pinterest_Engineering)
* [Reddit Blog](http://www.redditblog.com/)
* [Salesforce Engineering Blog](https://developer.salesforce.com/blogs/engineering/)
* [Slack Engineering Blog](https://slack.engineering/)
* [Spotify Labs](https://labs.spotify.com/)
* [Stripe Engineering Blog](https://stripe.com/blog/engineering)
* [Twilio Engineering Blog](http://www.twilio.com/engineering)
* [Twitter Engineering](https://blog.twitter.com/engineering/)
* [Uber Engineering Blog](http://eng.uber.com/)
* [Yahoo Engineering Blog](http://yahooeng.tumblr.com/)
* [Yelp Engineering Blog](http://engineeringblog.yelp.com/)
* [Zynga Engineering Blog](https://www.zynga.com/blogs/engineering)

#### Fonte(s) e leitura adicional

Quer adicionar um blog? Para evitar trabalho duplicado, considere adicionar o blog da sua empresa ao seguinte repositório:

* [kilimchoi/engineering-blogs](https://github.com/kilimchoi/engineering-blogs)

## Em desenvolvimento

Interessado em adicionar uma seção ou ajudar a completar uma em andamento? [Contribua](#contributing)!

* Computação distribuída com MapReduce
* Hashing consistente
* Scatter gather
* [Contribua](#contributing)

## Créditos

Créditos e fontes são fornecidos ao longo deste repositório.

Agradecimentos especiais a:

* [Hired in tech](http://www.hiredintech.com/system-design/the-system-design-process/)
* [Cracking the coding interview](https://www.amazon.com/dp/0984782850/)
* [High scalability](http://highscalability.com/)
* [checkcheckzz/system-design-interview](https://github.com/checkcheckzz/system-design-interview)
* [shashank88/system_design](https://github.com/shashank88/system_design)
* [mmcgrana/services-engineering](https://github.com/mmcgrana/services-engineering)
* [System design cheat sheet](https://gist.github.com/vasanthk/485d1c25737e8e72759f)
* [A distributed systems reading list](http://dancres.github.io/Pages/)
* [Cracking the system design interview](http://www.puncsky.com/blog/2016-02-13-crack-the-system-design-interview)

## Informações de contato

Sinta-se à vontade para entrar em contato comigo para discutir quaisquer problemas, dúvidas ou comentários.

Minhas informações de contato podem ser encontradas na minha [página do GitHub](https://github.com/donnemartin).

## Licença

*Estou fornecendo código e recursos neste repositório sob uma licença de código aberto. Como este é meu repositório pessoal, a licença que você recebe do meu código e recursos é minha e não do meu empregador (Facebook).*

    Copyright 2017 Donne Martin

    Licença Creative Commons Attribution 4.0 International (CC BY 4.0)

    http://creativecommons.org/licenses/by/4.0/


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-09

---