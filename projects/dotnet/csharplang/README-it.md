# Progettazione del Linguaggio C#

[![Unisciti alla chat su https://gitter.im/dotnet/csharplang](https://badges.gitter.im/dotnet/csharplang.svg)](https://gitter.im/dotnet/csharplang?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge) [![Chat su Discord](https://discordapp.com/api/guilds/143867839282020352/widget.png)](https://aka.ms/dotnet-discord-csharp)

Benvenuto nel repository ufficiale per la progettazione del linguaggio C#. Qui vengono sviluppate, adottate e specificate le nuove funzionalità del linguaggio C#.

C# è progettato dal Team di Progettazione del Linguaggio C# (LDT) in stretta coordinazione con il progetto [Roslyn](https://github.com/dotnet/roslyn), che implementa il linguaggio.

Puoi trovare:

- Proposte attive di funzionalità del linguaggio C# nella [cartella proposals](proposals)
- Note dalle riunioni di progettazione del linguaggio C# nella [cartella meetings](meetings)
- Sommario della [cronologia delle versioni del linguaggio qui](Language-Version-History.md).

Se scopri bug o carenze in quanto sopra, lascia una segnalazione per evidenziarli, o ancora meglio: una pull request per risolverli.

Per *nuove proposte di funzionalità*, invece, sollevale per [discussione](https://github.com/dotnet/csharplang/labels/Discussion), e *solo* invia una proposta come issue o pull request se invitato a farlo da un membro del Team di Progettazione del Linguaggio (un "champion").

Il processo completo di progettazione è descritto [qui](Design-Process.md). Una panoramica più breve è disponibile di seguito.

## Discussioni

Il dibattito relativo alle funzionalità del linguaggio avviene sotto forma di [Discussions](https://github.com/dotnet/csharplang/discussions) in questo repository.

Se desideri suggerire una funzionalità, discutere delle note di progettazione attuali o delle proposte, ecc., [apri un nuovo argomento di Discussion](https://github.com/dotnet/csharplang/discussions/new).

Le discussioni brevi e che restano in tema hanno molte più probabilità di essere lette. Se lasci il commento numero cinquanta, è probabile che solo poche persone lo leggeranno. Per rendere le discussioni più facili da navigare e utili, osserva alcune semplici regole:

- Le discussioni dovrebbero essere rilevanti per la progettazione del linguaggio C#. In caso contrario, verranno chiuse sommariamente.
- Scegli un argomento descrittivo che comunichi chiaramente l'ambito della discussione.
- Rimani in tema. Se un commento è tangenziale o entra nei dettagli di un sottoargomento, avvia una nuova discussione e inserisci un link di riferimento.
- Il tuo commento è utile per gli altri o può essere adeguatamente espresso con una reazione emoji a un commento esistente?

Le proposte di linguaggio che impediscono la presenza di una specifica sintassi possono essere implementate con un [analizzatore Roslyn](https://docs.microsoft.com/visualstudio/extensibility/getting-started-with-roslyn-analyzers). Le proposte che rendono solo opzionalmente illegale una sintassi esistente saranno respinte dal comitato di progettazione del linguaggio per evitare un aumento della complessità.

## Proposte

Quando un membro del C# LDM ritiene che una proposta meriti la considerazione del team più ampio, può [Champion](https://github.com/dotnet/csharplang/issues?q=is%3Aopen+is%3Aissue+label%3A%22Proposal+champion%22) la proposta, il che significa che la porterà alla Riunione di Progettazione del Linguaggio C#. Le proposte vengono sempre discusse nelle discussioni collegate, non nell'issue del champion. In passato non abbiamo sempre seguito questa politica, quindi molte champion issue avranno discussioni al loro interno; ora blocchiamo le issue per evitare nuove discussioni. Ogni champion issue avrà un link alla discussione.

## Processo di Progettazione

Le [proposte](proposals) si evolvono come risultato delle decisioni prese durante le [Riunioni di Progettazione del Linguaggio](meetings), che sono informate da [discussioni](https://github.com/dotnet/csharplang/discussions), esperimenti e lavoro di progettazione offline.

In molti casi sarà necessario implementare e condividere un prototipo di una funzionalità per arrivare al giusto design e, in ultima analisi, decidere se adottare la funzionalità. I prototipi aiutano a scoprire sia problemi di implementazione che di usabilità di una funzionalità. Un prototipo dovrebbe essere implementato in un fork del [repo Roslyn](https://github.com/dotnet/roslyn) e soddisfare i seguenti criteri:

- L'analisi sintattica (se applicabile) dovrebbe essere resiliente alla sperimentazione: la digitazione non dovrebbe causare crash.
- Includere test minimi che dimostrino il funzionamento end-to-end della funzionalità.
- Includere il supporto IDE minimo (colorazione delle parole chiave, formattazione, completamento).

Una volta approvata, una funzionalità dovrebbe essere completamente implementata in [Roslyn](https://github.com/dotnet/roslyn) e completamente specificata nella [specifica del linguaggio](spec), dopodiché la proposta viene spostata nella cartella appropriata per una funzionalità completata, ad esempio [C# 7.1 proposals](proposals/csharp-7.1).

**DISCLAIMER**: Una proposta attiva è in fase di considerazione per essere inclusa in una futura versione del linguaggio di programmazione C#, ma non vi è alcuna garanzia che venga effettivamente inclusa nella prossima o in qualsiasi versione del linguaggio. Una proposta può essere rimandata o respinta in qualsiasi momento e in qualsiasi fase del processo sopra descritto in base al feedback del team di progettazione, della community, dei revisori del codice o dei test.

### Milestone

Abbiamo alcune diverse milestone per le issue nel repository:
* [Working Set](https://github.com/dotnet/csharplang/milestone/19) è l'insieme delle proposte championate su cui si sta lavorando attivamente. Non tutto ciò che è in questa milestone sarà presente nella prossima versione di C#, ma riceverà tempo di progettazione durante il prossimo rilascio.
* [Backlog](https://github.com/dotnet/csharplang/milestone/10) è l'insieme delle proposte championate che sono state triaggiate, ma su cui non si sta lavorando attivamente. Sebbene discussioni e idee dalla community siano benvenute su queste proposte, il costo del lavoro di progettazione e della revisione dell'implementazione di queste funzionalità è troppo alto per considerare un'implementazione da parte della community fino a quando non saremo pronti.
* [Any Time](https://github.com/dotnet/csharplang/milestone/14) è l'insieme delle proposte championate che sono state triaggiate, ma su cui non si sta lavorando attivamente e sono aperte all'implementazione da parte della community. Le issue qui possono essere in uno di 2 stati: necessita di specifica approvata, e necessita di implementazione. Quelle che necessitano di una specifica devono ancora essere presentate durante il LDM per l'approvazione, ma siamo disposti a prenderci il tempo per farlo appena possibile.
* [Likely Never](https://github.com/dotnet/csharplang/milestone/13) è l'insieme delle proposte che il LDM ha respinto dal linguaggio. Senza un forte bisogno o feedback dalla community, queste proposte non verranno prese in considerazione in futuro.
* Le milestone numerate sono l'insieme delle funzionalità che sono state implementate per quella particolare versione del linguaggio. Per le milestone chiuse, questi sono gli elementi che sono stati rilasciati con quella versione. Per le milestone aperte, le funzionalità possono essere potenzialmente rimosse più avanti se vengono scoperti problemi di compatibilità o altri problemi prima del rilascio.

## Riunioni di Progettazione del Linguaggio

Le Riunioni di Progettazione del Linguaggio (LDM) sono tenute dal LDT e da ospiti occasionalmente invitati, e sono documentate nelle Note delle Riunioni di Progettazione nella cartella [meetings](meetings), organizzate in cartelle per anno. Il ciclo di vita di una nota di riunione di progettazione è descritto in [meetings/README.md](meetings/README.md). Durante le LDM vengono prese le decisioni sulle future versioni di C#, incluse le proposte su cui lavorare, come evolverle e se e quando adottarle.

## Specifica del Linguaggio

L'attuale specifica ECMA-334 è disponibile in formato markdown nel repository [C# Language Standard](https://github.com/dotnet/csharpstandard/).

## Implementazione

L'implementazione di riferimento del linguaggio C# si trova nel [repository Roslyn](https://github.com/dotnet/roslyn). Questo repository tiene traccia anche dello [stato di implementazione delle funzionalità del linguaggio](https://github.com/dotnet/roslyn/blob/main/docs/Language%20Feature%20Status.md). Fino a poco tempo fa, era anche il luogo dove venivano tracciati gli artefatti di progettazione del linguaggio. Ti chiediamo di avere pazienza mentre spostiamo qui le proposte attive.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-15

---