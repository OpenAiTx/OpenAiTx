# Conception du langage C#

[![Rejoignez la discussion sur https://gitter.im/dotnet/csharplang](https://badges.gitter.im/dotnet/csharplang.svg)](https://gitter.im/dotnet/csharplang?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge) [![Discussion sur Discord](https://discordapp.com/api/guilds/143867839282020352/widget.png)](https://aka.ms/dotnet-discord-csharp)

Bienvenue dans le dépôt officiel pour la conception du langage C#. C’est ici que les nouvelles fonctionnalités du langage C# sont développées, adoptées et spécifiées.

C# est conçu par l’équipe de conception du langage C# (LDT) en étroite coordination avec le projet [Roslyn](https://github.com/dotnet/roslyn), qui implémente le langage.

Vous trouverez :

- Les propositions de fonctionnalités actives du langage C# dans le [dossier proposals](proposals)
- Les comptes-rendus des réunions de conception du langage C# dans le [dossier meetings](meetings)
- Un résumé de l’[historique des versions du langage ici](Language-Version-History.md).

Si vous découvrez des bugs ou des insuffisances dans les éléments ci-dessus, veuillez ouvrir un ticket pour les signaler, ou mieux encore : une pull request pour les corriger.

Pour les *propositions de nouvelles fonctionnalités*, cependant, veuillez d'abord les soumettre pour [discussion](https://github.com/dotnet/csharplang/labels/Discussion), et *ne* soumettez une proposition en tant que ticket ou pull request que si un membre de l’équipe de conception du langage (un « champion ») vous y invite.

Le processus de conception complet est décrit [ici](Design-Process.md). Un aperçu plus court figure ci-dessous.

## Discussions

Le débat relatif aux fonctionnalités du langage prend la forme de [Discussions](https://github.com/dotnet/csharplang/discussions) dans ce dépôt.

Si vous souhaitez suggérer une fonctionnalité, discuter des notes de conception ou propositions actuelles, etc., veuillez [ouvrir un nouveau sujet de discussion](https://github.com/dotnet/csharplang/discussions/new).

Les discussions courtes et restées sur le sujet ont beaucoup plus de chances d’être lues. Si vous laissez le cinquantième commentaire, il est probable que seules quelques personnes le liront. Pour faciliter la navigation dans les discussions et en tirer profit, veuillez respecter quelques règles de base :

- La discussion doit concerner la conception du langage C#. Sinon, elle sera immédiatement fermée.
- Choisissez un sujet descriptif qui communique clairement la portée de la discussion.
- Tenez-vous en au sujet de la discussion. Si un commentaire est hors sujet ou entre dans les détails d’un sous-sujet, lancez une nouvelle discussion et faites un lien vers l’original.
- Votre commentaire est-il utile à d’autres, ou peut-il être exprimé adéquatement par une réaction emoji à un commentaire existant ?

Les propositions visant à empêcher une syntaxe spécifique peuvent être réalisées à l’aide d’un [analyseur Roslyn](https://docs.microsoft.com/visualstudio/extensibility/getting-started-with-roslyn-analyzers). Les propositions ne rendant une syntaxe existante optionnellement illégale seront rejetées par le comité de conception du langage afin d’éviter une complexité accrue.

## Propositions

Lorsqu’un membre du C# LDM estime qu’une proposition mérite d’être examinée par l’équipe au sens large, il peut la [championner](https://github.com/dotnet/csharplang/issues?q=is%3Aopen+is%3Aissue+label%3A%22Proposal+champion%22), ce qui signifie qu’il la présentera lors de la réunion de conception du langage C#. Les propositions sont toujours discutées dans les discussions liées, et non dans le ticket du champion. Nous n’avons pas toujours suivi cette politique, donc de nombreux tickets de champion contiennent des discussions ; nous verrouillons désormais les tickets pour empêcher toute nouvelle discussion. Chaque ticket de champion contiendra un lien vers la discussion correspondante.

## Processus de conception

Les [propositions](proposals) évoluent suite aux décisions prises lors des [réunions de conception du langage](meetings), informées par les [discussions](https://github.com/dotnet/csharplang/discussions), les expérimentations et le travail de conception hors-ligne.

Dans de nombreux cas, il sera nécessaire de mettre en œuvre et de partager un prototype d’une fonctionnalité afin d’aboutir à la bonne conception, et finalement décider de l’adoption de la fonctionnalité. Les prototypes permettent de découvrir à la fois les problèmes de mise en œuvre et d’utilisabilité d’une fonctionnalité. Un prototype doit être implémenté dans un fork du [dépôt Roslyn](https://github.com/dotnet/roslyn) et respecter les critères suivants :

- L’analyse syntaxique (si applicable) doit être résistante à l’expérimentation : la saisie ne doit pas provoquer de plantage.
- Inclure des tests minimaux démontrant la fonctionnalité de bout en bout.
- Inclure un support minimal dans l’IDE (coloration des mots-clés, formatage, complétion).

Une fois approuvée, une fonctionnalité doit être entièrement implémentée dans [Roslyn](https://github.com/dotnet/roslyn), et entièrement spécifiée dans la [spécification du langage](spec), après quoi la proposition est déplacée dans le dossier approprié pour une fonctionnalité complétée, par exemple [propositions C# 7.1](proposals/csharp-7.1).

**AVERTISSEMENT** : Une proposition active fait l’objet d’un examen pour inclusion dans une future version du langage de programmation C#, mais son inclusion dans la prochaine version ou toute autre version n’est en aucun cas garantie. Une proposition peut être reportée ou rejetée à tout moment pendant n’importe quelle phase du processus ci-dessus, en fonction des retours de l’équipe de conception, de la communauté, des relecteurs de code ou des tests.

### Jalons

Nous avons plusieurs types de jalons pour les tickets du dépôt :
* [Working Set](https://github.com/dotnet/csharplang/milestone/19) est l’ensemble des propositions championnées actuellement en cours de traitement. Tout ce qui se trouve dans ce jalon ne figurera pas forcément dans la prochaine version de C#, mais bénéficiera d’un temps de conception lors de la prochaine publication.
* [Backlog](https://github.com/dotnet/csharplang/milestone/10) est l’ensemble des propositions championnées qui ont été triées, mais qui ne sont pas en cours de traitement actif. Bien que la discussion et les idées de la communauté soient les bienvenues sur ces propositions, le coût du travail de conception et de la revue de l’implémentation est trop élevé pour que nous envisagions une implémentation communautaire tant que nous ne sommes pas prêts.
* [Any Time](https://github.com/dotnet/csharplang/milestone/14) est l’ensemble des propositions championnées qui ont été triées, mais qui ne sont pas activement en cours de traitement et sont ouvertes à une implémentation communautaire. Les tickets ici peuvent être dans l’un de ces deux états : besoin d’une spécification approuvée, et besoin d’une implémentation. Ceux qui nécessitent une spécification doivent encore être présentés lors du LDM pour approbation, mais nous sommes prêts à prendre le temps de le faire dès que possible.
* [Likely Never](https://github.com/dotnet/csharplang/milestone/13) est l’ensemble des propositions que le LDM a rejetées pour le langage. Sans besoin fort ou retour de la communauté, ces propositions ne seront pas reconsidérées à l’avenir.
* Les jalons numérotés sont l’ensemble des fonctionnalités ayant été implémentées pour une version particulière du langage. Pour les jalons fermés, il s’agit de l’ensemble des éléments publiés avec cette version. Pour les jalons ouverts, les fonctionnalités peuvent être retirées ultérieurement si nous découvrons des problèmes de compatibilité ou autres à l’approche de la publication.

## Réunions de conception du langage

Les réunions de conception du langage (LDM) sont tenues par le LDT et des invités occasionnels, et sont documentées dans les notes de réunion de conception dans le dossier [meetings](meetings), organisées par année. Le cycle de vie d’une note de réunion de conception est décrit dans [meetings/README.md](meetings/README.md). Les LDM sont le lieu où les décisions concernant les futures versions de C# sont prises, y compris les propositions à traiter, leur évolution, et leur adoption éventuelle.

## Spécification du langage

La spécification ECMA-334 actuelle est disponible en format markdown sur le dépôt [C# Language Standard](https://github.com/dotnet/csharpstandard/).

## Implémentation

L’implémentation de référence du langage C# se trouve dans le [dépôt Roslyn](https://github.com/dotnet/roslyn). Ce dépôt suit également le [statut d’implémentation des fonctionnalités du langage](https://github.com/dotnet/roslyn/blob/main/docs/Language%20Feature%20Status.md). Jusqu’à récemment, c’était aussi là que les artefacts de conception du langage étaient suivis. Veuillez patienter pendant la migration des propositions actives.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-15

---