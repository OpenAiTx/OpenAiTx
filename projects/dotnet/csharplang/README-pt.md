# Design da Linguagem C#

[![Participe do chat em https://gitter.im/dotnet/csharplang](https://badges.gitter.im/dotnet/csharplang.svg)](https://gitter.im/dotnet/csharplang?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge) [![Chat no Discord](https://discordapp.com/api/guilds/143867839282020352/widget.png)](https://aka.ms/dotnet-discord-csharp)

Bem-vindo ao repositório oficial de design da linguagem C#. É aqui que novos recursos da linguagem C# são desenvolvidos, adotados e especificados.

O C# é projetado pela Equipe de Design da Linguagem C# (LDT) em estreita coordenação com o projeto [Roslyn](https://github.com/dotnet/roslyn), que implementa a linguagem.

Você pode encontrar:

- Propostas ativas de recursos da linguagem C# na [pasta de propostas](proposals)
- Notas das reuniões de design da linguagem C# na [pasta de reuniões](meetings)
- Resumo do [histórico de versões da linguagem aqui](Language-Version-History.md).

Se você descobrir bugs ou deficiências nos itens acima, por favor abra uma issue para relatá-los ou, melhor ainda: um pull request para corrigi-los.

Para *novas propostas de recursos*, no entanto, por favor, abra-as para [discussão](https://github.com/dotnet/csharplang/labels/Discussion), e *apenas* envie uma proposta como issue ou pull request se for convidado a fazê-lo por um membro da Equipe de Design da Linguagem (um "champion").

O processo de design completo está descrito [aqui](Design-Process.md). Um resumo mais curto está abaixo.

## Discussões

O debate sobre recursos da linguagem ocorre na forma de [Discussões](https://github.com/dotnet/csharplang/discussions) neste repositório.

Se você quiser sugerir um recurso, discutir notas de design ou propostas atuais, etc., por favor [abra um novo tópico de Discussão](https://github.com/dotnet/csharplang/discussions/new).

Discussões curtas e que permanecem no tema têm muito mais chance de serem lidas. Se você deixar o comentário número cinquenta, é provável que apenas algumas pessoas o leiam. Para tornar as discussões mais fáceis de navegar e de aproveitar, siga algumas regras práticas:

- A discussão deve ser relevante para o design da linguagem C#. Se não for, será sumariamente fechada.
- Escolha um tópico descritivo que comunique claramente o escopo da discussão.
- Mantenha-se no tema da discussão. Se um comentário for tangencial ou entrar em detalhes sobre um subtópico, inicie uma nova discussão e faça um link de retorno.
- Seu comentário é útil para outros lerem, ou pode ser adequadamente expresso com uma reação de emoji a um comentário existente?

Propostas de linguagem que impedem a ocorrência de sintaxe específica podem ser alcançadas com um [analisador Roslyn](https://docs.microsoft.com/visualstudio/extensibility/getting-started-with-roslyn-analyzers). Propostas que apenas tornam uma sintaxe existente opcionalmente ilegal serão rejeitadas pelo comitê de design da linguagem para evitar aumento da complexidade da linguagem.

## Propostas

Quando um membro do C# LDM considera que uma proposta merece consideração pela equipe mais ampla, ele pode [Patrocinar](https://github.com/dotnet/csharplang/issues?q=is%3Aopen+is%3Aissue+label%3A%22Proposal+champion%22) a proposta, o que significa que ele a levará para a Reunião de Design da Linguagem C#. Propostas são sempre discutidas em discussões vinculadas, não na issue do patrocinador. Nem sempre seguimos essa política, então muitas issues de patrocinadores terão discussões nelas; agora bloqueamos issues para evitar que novas discussões ocorram nelas. Cada issue de patrocinador terá um link para a discussão.

## Processo de Design

[Propostas](proposals) evoluem como resultado de decisões em [Reuniões de Design da Linguagem](meetings), que são informadas por [discussões](https://github.com/dotnet/csharplang/discussions), experimentos e trabalho de design offline.

Em muitos casos, será necessário implementar e compartilhar um protótipo de um recurso para chegar ao design correto e, em última instância, decidir se o recurso será adotado. Protótipos ajudam a descobrir problemas de implementação e usabilidade de um recurso. Um protótipo deve ser implementado em um fork do [repositório Roslyn](https://github.com/dotnet/roslyn) e atender aos seguintes critérios:

- O parsing (se aplicável) deve ser resiliente à experimentação: digitar não deve causar falhas.
- Incluir testes mínimos demonstrando o funcionamento do recurso de ponta a ponta.
- Incluir suporte mínimo ao IDE (coloração de palavra-chave, formatação, autocompletar).

Uma vez aprovado, um recurso deve ser totalmente implementado no [Roslyn](https://github.com/dotnet/roslyn) e totalmente especificado na [especificação da linguagem](spec), momento em que a proposta é movida para a pasta apropriada de recursos concluídos, por exemplo, [propostas do C# 7.1](proposals/csharp-7.1).

**AVISO**: Uma proposta ativa está sob consideração para inclusão em uma futura versão da linguagem de programação C#, mas não há garantia de que será incluída na próxima ou em qualquer versão da linguagem. Uma proposta pode ser adiada ou rejeitada a qualquer momento durante qualquer fase do processo acima, com base no feedback da equipe de design, comunidade, revisores de código ou testes.

### Marcos

Temos alguns marcos diferentes para issues no repositório:
* [Conjunto de Trabalho](https://github.com/dotnet/csharplang/milestone/19) é o conjunto de propostas patrocinadas que estão atualmente sendo ativamente trabalhadas. Nem tudo neste marco estará na próxima versão do C#, mas receberá tempo de design durante o próximo lançamento.
* [Backlog](https://github.com/dotnet/csharplang/milestone/10) é o conjunto de propostas patrocinadas que foram triadas, mas não estão sendo ativamente trabalhadas. Embora discussões e ideias da comunidade sejam bem-vindas nessas propostas, o custo do trabalho de design e da revisão de implementação nesses recursos é muito alto para considerarmos implementação pela comunidade até estarmos prontos para isso.
* [A Qualquer Momento](https://github.com/dotnet/csharplang/milestone/14) é o conjunto de propostas patrocinadas que foram triadas, mas não estão sendo ativamente trabalhadas e estão abertas para implementação pela comunidade. Issues aqui podem estar em um de dois estados: precisam de especificação aprovada e precisam de implementação. As que precisam de especificação ainda precisam ser apresentadas durante o LDM para aprovação da especificação, mas estamos dispostos a dedicar tempo para isso assim que possível.
* [Provavelmente Nunca](https://github.com/dotnet/csharplang/milestone/13) é o conjunto de propostas que o LDM rejeitou para a linguagem. Sem forte necessidade ou feedback da comunidade, essas propostas não serão consideradas no futuro.
* Marcos numerados são o conjunto de recursos que foram implementados para aquela versão específica da linguagem. Para marcos fechados, são o conjunto de itens que foram lançados com aquela versão. Para marcos abertos, recursos podem ser potencialmente removidos mais tarde se descobrirmos problemas de compatibilidade ou outros à medida que nos aproximamos do lançamento.

## Reuniões de Design da Linguagem

As Reuniões de Design da Linguagem (LDMs) são realizadas pela LDT e convidados ocasionais, e são documentadas em Notas de Reunião de Design na pasta [meetings](meetings), organizadas em pastas por ano. O ciclo de vida de uma nota de reunião de design está descrito em [meetings/README.md](meetings/README.md). As LDMs são onde as decisões sobre futuras versões do C# são tomadas, incluindo quais propostas trabalhar, como evoluí-las e se e quando adotá-las.

## Especificação da Linguagem

A especificação ECMA-334 atual pode ser encontrada em formato markdown no repositório [C# Language Standard](https://github.com/dotnet/csharpstandard/).

## Implementação

A implementação de referência da linguagem C# pode ser encontrada no [repositório Roslyn](https://github.com/dotnet/roslyn). Este repositório também acompanha o [status de implementação dos recursos da linguagem](https://github.com/dotnet/roslyn/blob/main/docs/Language%20Feature%20Status.md). Até recentemente, era também onde os artefatos de design da linguagem eram acompanhados. Por favor, aguarde um pouco enquanto movemos as propostas ativas.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-15

---