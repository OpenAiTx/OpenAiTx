![note-gen](https://socialify.git.ci/codexu/note-gen/image?custom_description=Cross-Platform+%7C+LLM+%7C+Markdown+%7C++Recording++%26+Writing&description=1&font=Raleway&forks=1&issues=1&logo=https%3A%2F%2Fcamo.githubusercontent.com%2Fbe4a3a39f8724658ad5bc549d63f0454ad4ca98564c73b7b0778704ca5212509%2F68747470733a2f2f73322e6c6f6c692e6e65742f323032352f30352f32362f594d4e67784b5644724238345a74572e706e67&name=1&owner=1&pattern=Circuit+Board&stargazers=1&theme=Light)

# NoteGen

![](https://github.com/codexu/note-gen/actions/workflows/release.yml/badge.svg?branch=release)
![](https://img.shields.io/github/v/release/codexu/note-gen)
![](https://img.shields.io/badge/version-alpha-orange)
![](https://img.shields.io/github/downloads/codexu/note-gen/total)
![](https://img.shields.io/github/commit-activity/m/codexu/note-gen)

English | [简体中文](.github/README.zh.md) | [日本語](.github/README.ja.md)

<div style="display: flex; gap: 1rem;">
  <a href="https://www.producthunt.com/products/notegen-2?embed=true&utm_source=badge-featured&utm_medium=badge&utm_source=badge-notegen&#0045;2" target="_blank"><img src="https://api.producthunt.com/widgets/embed-image/v1/featured.svg?post_id=956348&theme=light&t=1749194675492" alt="NoteGen - A&#0032;cross&#0045;platform&#0032;Markdown&#0032;note&#0045;taking&#0032;application | Product Hunt" style="width: 250px; height: 54px;" width="250" height="54" /></a>

  <a href="https://trendshift.io/repositories/12784" target="_blank"><img src="https://trendshift.io/api/badge/repositories/12784" alt="codexu%2Fnote-gen | Trendshift" style="width: 250px; height: 55px;" width="250" height="55"/></a>
</div>

## Guida

NoteGen è un'applicazione di note `Markdown` multipiattaforma dedicata a utilizzare l'AI per collegare registrazione e scrittura, organizzando la conoscenza frammentata in una nota leggibile.

🖥️ Documentazione ufficiale: [https://notegen.top](https://notegen.top)

💬 Unisciti al [Gruppo WeChat/QQ](https://github.com/codexu/note-gen/discussions/110)

## Perché scegliere NoteGen?

- Leggero: Il [pacchetto di installazione](https://github.com/codexu/note-gen/releases) è **solo 20MB**, gratuito, senza pubblicità o software aggiuntivo.
- Multipiattaforma: Supporta Mac, Windows, Linux, e grazie alle capacità multipiattaforma di `Tauri2`, supporterà anche iOS e Android in futuro.
- Supporta vari metodi di registrazione tra cui `screenshot`, `testo`, `illustrazioni`, `file`, `link`, ecc., rispondendo alle esigenze di registrazione frammentata in diversi scenari.
- Formato di archiviazione nativo `Markdown(.md)`, senza modifiche, facile da migrare.
- Utilizzo offline nativo, con supporto per la sincronizzazione in tempo reale su `GitHub, repository privati Gitee` con rollback della cronologia, e sincronizzazione WebDAV.
- Potenziato dall’AI: Configurabile con ChatGPT, Gemini, Ollama, LM Studio, Grok e altri modelli, con supporto alla configurazione di modelli di terze parti personalizzati.
- RAG: Le tue note sono la tua base di conoscenza. Supporta modelli di embedding e modelli di reranking.

## Screenshot

https://github.com/user-attachments/assets/4f8a3bc5-17f5-4b36-9b17-d87128685257

Registrazione:

![1.png](https://s2.loli.net/2025/05/19/Cs5viKfkqb2HJmd.png)

Scrittura:

![2.png](https://s2.loli.net/2025/05/19/5vwQBPoLr6jzgUA.png)

Tema:

![3.png](https://s2.loli.net/2025/05/19/8yU72prmWdsCHeu.png)

## Dalla Registrazione alla Scrittura

Le applicazioni di note tradizionali solitamente non offrono la funzionalità di registrazione. Gli utenti devono copiare e incollare manualmente i contenuti per registrarli, riducendo notevolmente l'efficienza. Quando ci si trova di fronte a contenuti registrati dispersi, è necessario un grande sforzo per organizzarli.

NoteGen è suddiviso in pagine di `Registrazione` e `Scrittura`, con la seguente relazione:

- Le registrazioni possono essere organizzate in note e trasferite nella pagina di scrittura per una composizione approfondita.
- Durante la scrittura, puoi inserire le registrazioni in qualsiasi momento.

### Registrazione

La funzione di registrazione è simile a un **chatbot AI**, ma durante la conversazione puoi associare contenuti registrati in precedenza, passando dalla modalità conversazione a quella di organizzazione, per disporre le registrazioni in una nota leggibile.

Le seguenti funzionalità ausiliarie possono aiutarti a registrare in modo più efficace:

- **Tag** per distinguere i diversi scenari di registrazione.
- **Personas** con supporto per prompt personalizzati per controllare con precisione il tuo assistente AI.
- **Assistente Appunti** che riconosce automaticamente testo o immagini negli appunti e li registra nella tua lista.

### Scrittura

La sezione di scrittura è divisa in due parti: **Gestore File** e **Editor Markdown**.

**Gestore File**

- Supporta la gestione di file Markdown locali e file sincronizzati con GitHub.
- Supporta gerarchie di directory illimitate.
- Supporta vari metodi di ordinamento.

**Editor Markdown**

- Supporta WYSIWYG, rendering istantaneo e anteprima a schermo diviso.
- Supporta il controllo versione con rollback della cronologia.
- Supporta assistenza AI per conversazione, continuazione, rifinitura e funzioni di traduzione.
- Supporta hosting di immagini, caricamento immagini e conversione in link immagine Markdown.
- Supporta conversione da HTML a Markdown, convertendo automaticamente i contenuti copiati dal browser in formato Markdown.
- Supporta strutture, formule matematiche, mappe mentali, grafici, diagrammi di flusso, diagrammi di Gantt, diagrammi di sequenza, pentagrammi, multimedia, lettura vocale, ancore di titolo, evidenziazione e copia del codice, rendering graphviz e diagrammi UML plantuml.
- Supporta salvataggio in tempo reale dei contenuti locali, sincronizzazione automatica ritardata (10s senza modifica) e rollback della cronologia.

## Altre Funzionalità

- Ricerca globale per trovare e saltare rapidamente ai contenuti specifici.
- Gestione dell’hosting delle immagini per una gestione comoda dei contenuti del repository immagini.
- Temi e aspetto con supporto per temi scuri e impostazioni di aspetto per Markdown, codice, ecc.
- Supporto alla internazionalizzazione, attualmente disponibile in cinese e inglese.

## Come si usa?

### Download

Attualmente supporta Mac, Windows e Linux. Grazie alle capacità multipiattaforma di Tauri2, supporterà anche iOS e Android in futuro.

[Scarica NoteGen (alpha)](https://github.com/codexu/note-gen/releases)

### Potenziamento

L'applicazione di note può essere utilizzata direttamente senza configurazione. Se desideri un'esperienza migliore, apri la pagina delle impostazioni per configurare AI e sincronizzazione.

## Contribuisci

- [Leggi la guida al contributo](https://raw.githubusercontent.com/codexu/note-gen/dev/.github/CONTRIBUTING.md)
- [Piani di aggiornamento](https://github.com/codexu/note-gen/issues/46)
- [Segnala bug o suggerimenti di miglioramento](https://github.com/codexu/note-gen/issues)
- [Discussioni](https://github.com/codexu/note-gen/discussions)

## Contributor

<a href="https://github.com/codexu/note-gen/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=codexu/note-gen" />
</a>

## Cronologia stelle

[![Star History Chart](https://api.star-history.com/svg?repos=codexu/note-gen&type=Date)](https://www.star-history.com/#codexu/note-gen&Date)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---