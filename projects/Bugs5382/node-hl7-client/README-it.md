# Node HL7 Client

> Un client HL7 puro in TypeScript per Node.js che consente una comunicazione senza interruzioni con server HL7.

`node-hl7-client` è una libreria leggera, senza dipendenze esterne, creata per una comunicazione ad alte prestazioni con broker/server HL7. Supporta l'invio di messaggi HL7 formattati correttamente, la gestione delle risposte e il lavoro sia con formati di messaggi HL7 singoli che batch (MSH, BHS e FHS).

## ✨ Caratteristiche

* ⚡ **Zero Dipendenze Esterne** – Prestazioni ultra-rapide senza appesantimento.
* 🔁 **Riconnessione e Ritentativo Automatici** – Gestisce automaticamente le interruzioni di connessione.
* 🧠 **TypeScript + Definizioni Tipizzate** – Completamente tipizzato per ambienti di sviluppo moderni.
* 🤝 **Pacchetto Compagno Disponibile** – Utilizzabile insieme a [`node-hl7-server`](https://www.npmjs.com/package/node-hl7-server) per una soluzione HL7 completa.
* 💻 **Supporto Multi-piattaforma** – Funziona su Windows, macOS e Linux.
* 🧭 **Basato sugli Standard** – I builder tipizzati assicurano che i segmenti MSH, BHS e FHS seguano le specifiche di HL7.org.

## 📦 Installazione

```bash
npm install node-hl7-client
```

## 📚 Cosa è incluso?

* **HL7 Client** – Si connette a un server HL7 remoto, invia messaggi e processa le risposte.
* **HL7 Parser** – Analizza stringhe di messaggi HL7 grezzi in segmenti accessibili.
* **HL7 Builder** – Costruisce messaggi HL7 validi, batch o file batch HL7 completi.

## 🧾 Indice

1. [Definizioni delle Parole Chiave](#keyword-definitions)
2. [Documentazione](#documentation)
3. [Ringraziamenti](#acknowledgements)
4. [Licenza](#license)

## Definizioni delle Parole Chiave

Questo pacchetto NPM è progettato per supportare applicazioni mediche con potenziale impatto sull’assistenza e la diagnosi dei pazienti. Questa documentazione, insieme al pacchetto correlato [node-hl7-server](https://www.npmjs.com/package/node-hl7-server), utilizza le seguenti definizioni standardizzate per chiarezza e interoperabilità:

Le parole chiave come **"MUST"**, **"MUST NOT"**, **"REQUIRED"**, **"SHALL"**, **"SHALL NOT"**, **"SHOULD"**, **"SHOULD NOT"**, **"RECOMMENDED"**, **"MAY"** e **"OPTIONAL"** sono usate coerentemente in tutta la documentazione. Questi termini mantengono il loro significato anche quando non sono scritti in maiuscolo.

* **MUST** – Questa parola, o i termini **"REQUIRED"** o **"SHALL"**, indica un requisito assoluto della specifica.
* **MUST NOT** – Questa frase, o la frase **"SHALL NOT"**, indica un divieto assoluto della specifica.
* **SHOULD** – Questa parola, o l’aggettivo **"RECOMMENDED"**, significa che possono esserci valide ragioni in particolari circostanze per ignorare un determinato elemento, ma tutte le implicazioni devono essere comprese e valutate attentamente prima di farlo.
* **SHOULD NOT** – Questa frase, o la frase **"NOT RECOMMENDED"**, significa che possono esserci valide ragioni in particolari circostanze in cui il comportamento è accettabile o addirittura utile. Le implicazioni complete dovrebbero essere comprese e il caso valutato attentamente prima dell’implementazione.
* **MAY** – Questa parola, o l’aggettivo **"OPTIONAL"**, significa che l’elemento è realmente opzionale. Le implementazioni che non includono una particolare opzione DEVONO comunque interoperare con quelle che lo fanno, sebbene con funzionalità ridotta. Allo stesso modo, le implementazioni che includono un’opzione DEVONO interoperare con quelle che non la includono (eccetto, ovviamente, per la funzionalità specifica fornita dall’opzione).

## 📖 Documentazione

La documentazione completa delle API, esempi d’uso e configurazioni avanzate sono disponibili sul sito del progetto:
🔗 [https://bugs5382.github.io/node-hl7-client/](https://bugs5382.github.io/node-hl7-client/)

## 🙏 Ringraziamenti

* [`node-rabbitmq-client`](https://github.com/cody-greene/node-rabbitmq-client) – Ispirazione per la logica di connessione.
* [`artifacthealth/hl7parser`](https://github.com/artifacthealth/hl7parser) – Riferimento di design per parser e builder.
* Mia moglie e la mia bambina – per il loro amore, pazienza e ispirazione.


## 📄 Licenza

MIT © [LICENSE](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---