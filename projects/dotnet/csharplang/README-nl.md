# C# Taalontwerp

[![Deelnemen aan de chat op https://gitter.im/dotnet/csharplang](https://badges.gitter.im/dotnet/csharplang.svg)](https://gitter.im/dotnet/csharplang?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge) [![Chat op Discord](https://discordapp.com/api/guilds/143867839282020352/widget.png)](https://aka.ms/dotnet-discord-csharp)

Welkom bij de officiële repo voor het ontwerp van de C#-taal. Hier worden nieuwe C#-taalfuncties ontwikkeld, aangenomen en gespecificeerd.

C# wordt ontworpen door het C# Language Design Team (LDT) in nauwe samenwerking met het [Roslyn](https://github.com/dotnet/roslyn) project, dat de taal implementeert.

Je kunt hier vinden:

- Actieve C#-taalfunctievoorstellen in de [voorstellenmap](proposals)
- Notities van C#-taalontwerpvergaderingen in de [vergadermap](meetings)
- Samenvatting van de [taalversiegeschiedenis hier](Language-Version-History.md).

Als je bugs of tekortkomingen in bovenstaande vindt, laat dan een issue achter om ze te melden, of nog beter: een pull request om ze te verhelpen.

Voor *nieuwe functievoorstellen*, dien deze echter in voor [discussie](https://github.com/dotnet/csharplang/labels/Discussion), en dien *alleen* een voorstel in als issue of pull request in als je hiervoor bent uitgenodigd door een lid van het Language Design Team (een "champion").

Het volledige ontwerpproces wordt [hier](Design-Process.md) beschreven. Hieronder volgt een korter overzicht.

## Discussies

Discussies met betrekking tot taalfuncties vinden plaats in de vorm van [Discussies](https://github.com/dotnet/csharplang/discussions) in deze repo.

Als je een functie wilt voorstellen, huidige ontwerpnotities of voorstellen wilt bespreken, enzovoort, [open dan een nieuw Discussieonderwerp](https://github.com/dotnet/csharplang/discussions/new).

Discussies die kort zijn en on-topic blijven, worden veel vaker gelezen. Als je reactie nummer vijftig achterlaat, is de kans groot dat slechts een paar mensen deze lezen. Om discussies beter navigeerbaar en nuttiger te maken, houd je aan enkele vuistregels:

- Discussies moeten relevant zijn voor het ontwerp van de C#-taal. Zo niet, dan worden ze direct gesloten.
- Kies een beschrijvend onderwerp dat duidelijk het bereik van de discussie communiceert.
- Blijf bij het onderwerp van de discussie. Als een reactie tangentiëel is, of in detail ingaat op een subonderwerp, start dan een nieuwe discussie en verwijs terug.
- Is je reactie nuttig voor anderen om te lezen, of kan deze voldoende worden uitgedrukt met een emoji-reactie op een bestaande reactie?

Taalvoorstellen die specifieke syntaxis willen voorkomen, kunnen worden bereikt met een [Roslyn-analyzer](https://docs.microsoft.com/visualstudio/extensibility/getting-started-with-roslyn-analyzers). Voorstellen die alleen bestaande syntaxis optioneel illegaal maken, zullen worden afgewezen door het taalontwerpcomité om toegenomen taalcomplexiteit te voorkomen.

## Voorstellen

Wanneer een lid van de C# LDM vindt dat een voorstel het overwegen door het bredere team waard is, kan hij of zij het [Championen](https://github.com/dotnet/csharplang/issues?q=is%3Aopen+is%3Aissue+label%3A%22Proposal+champion%22), wat betekent dat het naar de C# Language Design Meeting wordt gebracht. Voorstellen worden altijd besproken in gekoppelde discussies, niet in het champion-issue. We volgden dit beleid niet altijd, dus veel champion-issues zullen nog discussie bevatten; we sluiten nu issues om te voorkomen dat er nieuwe discussies op plaatsvinden. Elk champion-issue zal een discussielink bevatten.

## Ontwerpproces

[Voorstellen](proposals) evolueren als resultaat van beslissingen in [Taalontwerpvergaderingen](meetings), die worden geïnformeerd door [discussies](https://github.com/dotnet/csharplang/discussions), experimenten en offline ontwerparbeid.

In veel gevallen zal het nodig zijn om een prototype van een functie te implementeren en te delen om tot het juiste ontwerp te komen, en uiteindelijk te beslissen of de functie wordt aangenomen. Prototypes helpen zowel implementatie- als bruikbaarheidsproblemen van een functie te ontdekken. Een prototype moet worden geïmplementeerd in een fork van de [Roslyn-repo](https://github.com/dotnet/roslyn) en aan de volgende eisen voldoen:

- Parsing (indien van toepassing) moet bestand zijn tegen experimenteren: typen mag geen crashes veroorzaken.
- Bevat minimale tests die de functie end-to-end demonstreren.
- Bevat minimale IDE-ondersteuning (keyword-kleuring, formattering, aanvulling).

Na goedkeuring moet een functie volledig worden geïmplementeerd in [Roslyn](https://github.com/dotnet/roslyn), en volledig worden gespecificeerd in de [taalspecificatie](spec), waarna het voorstel wordt verplaatst naar de juiste map voor een voltooide functie, bijv. [C# 7.1 voorstellen](proposals/csharp-7.1).

**DISCLAIMER**: Een actief voorstel staat onder actieve overweging voor opname in een toekomstige versie van de C# programmeertaal, maar is op geen enkele wijze gegarandeerd voor opname in de volgende of enige versie van de taal. Een voorstel kan op elk moment tijdens iedere fase van bovenstaand proces worden uitgesteld of afgewezen op basis van feedback van het ontwerpteam, de gemeenschap, code reviewers of testen.

### Mijlpalen

We hebben een paar verschillende mijlpalen voor issues in de repo:
* [Working Set](https://github.com/dotnet/csharplang/milestone/19) is de set van gechampioneerde voorstellen die momenteel actief worden uitgewerkt. Niet alles in deze mijlpaal haalt de volgende versie van C#, maar krijgt wel ontwerptijd tijdens de aankomende release.
* [Backlog](https://github.com/dotnet/csharplang/milestone/10) is de set van gechampioneerde voorstellen die zijn beoordeeld, maar niet actief worden uitgewerkt. Discussie en ideeën uit de gemeenschap zijn welkom, maar de kosten van ontwerpwerk en implementatiereview zijn te hoog om gemeenschapsimplementatie te overwegen totdat we er klaar voor zijn.
* [Any Time](https://github.com/dotnet/csharplang/milestone/14) is de set van gechampioneerde voorstellen die zijn beoordeeld, maar niet actief worden uitgewerkt en openstaan voor gemeenschapsimplementatie. Issues hierin kunnen in een van twee staten zijn: specificatie goedkeuring nodig, en implementatie nodig. Degenen die een specificatie nodig hebben moeten nog worden gepresenteerd tijdens LDM voor goedkeuring van de specificatie, maar we nemen de tijd om dit te doen zodra het ons uitkomt.
* [Likely Never](https://github.com/dotnet/csharplang/milestone/13) is de set van voorstellen die door de LDM zijn afgewezen uit de taal. Zonder sterke noodzaak of feedback uit de gemeenschap zullen deze voorstellen in de toekomst niet worden overwogen.
* Genummerde mijlpalen zijn de set functies die zijn geïmplementeerd voor die specifieke taalversie. Voor gesloten mijlpalen zijn dit de functies die met die release zijn meegeleverd. Voor open mijlpalen kunnen functies mogelijk later worden verwijderd als we compatibiliteits- of andere problemen ontdekken naarmate we dichter bij release komen.

## Taalontwerpvergaderingen

Taalontwerpvergaderingen (LDM's) worden gehouden door de LDT en af en toe genodigde gasten, en worden gedocumenteerd in de ontwerpvergadernotities in de [vergadermap](meetings), georganiseerd in mappen per jaar. De levenscyclus van een ontwerpvergadernotitie wordt beschreven in [meetings/README.md](meetings/README.md). LDM's zijn waar beslissingen worden genomen over toekomstige C#-versies, inclusief welke voorstellen worden uitgewerkt, hoe de voorstellen worden ontwikkeld, en of en wanneer ze worden aangenomen.

## Taalspecificatie

De huidige ECMA-334 specificatie is te vinden in markdown-vorm op de [C# Language Standard](https://github.com/dotnet/csharpstandard/) repository.

## Implementatie

De referentie-implementatie van de C#-taal is te vinden in de [Roslyn-repository](https://github.com/dotnet/roslyn). Deze repository houdt ook de [implementatiestatus van taalfuncties](https://github.com/dotnet/roslyn/blob/main/docs/Language%20Feature%20Status.md) bij. Tot voor kort werden hier ook de taalontwerpartifacten gevolgd. Geef ons wat tijd terwijl we actieve voorstellen verplaatsen.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-15

---