# Gantt

## Installazione

```
yarn install
```

### Avvio

```
yarn run serve
```

### Descrizione

```
Visualizzazione di diagrammi di Gantt sviluppata su base Vue, può essere utilizzata per la collaborazione di team e la suddivisione dei compiti in scenari agili.

Supporta la suddivisione in gruppi
Supporta il drag and drop
Supporta l’allungamento
Supporta la percentuale
Supporta intervalli temporali: giorno, settimana, mese
Attualmente è implementato solo il raggruppamento di primo livello; per evitare future esigenze di raggruppamenti a due o più livelli, in un precedente commit è stato parzialmente refattorizzato il codice per supportare raggruppamenti multilivello, ma questa versione non è ancora sviluppata.

Vantaggi: Durante operazioni come drag and drop, allungamento, modifica della progressione, i dati non vengono aggiornati in tempo reale, ma solo dopo l’operazione, riducendo così il carico sulle performance.
      Durante la modifica, eliminazione, aggiunta, non viene modificata ricorsivamente l’intera istanza, ma solo la parte interessata.

Si sta preparando una riorganizzazione per la componentizzazione; attualmente per utilizzare nel progetto è sufficiente importare `gant.vue` da questo progetto.
I metodi di importazione/esportazione dati in batch sono già pronti, basta copiarli!~

```

### Note di aggiornamento

- Supporto per la modifica
- Supporto per l’eliminazione
- Correzione del bug che impediva lo scrolling verticale (aggiunto anche lo scrolling bidirezionale) [#4](https://github.com/GGBeng1/Gantt/issues/4)
- Correzione dei bug causati da elementUI
- Sulla questione dell’intervallo temporale [#5](https://github.com/GGBeng1/Gantt/issues/5)
- Attualmente non è possibile implementare altri intervalli modificando la configurazione, ad esempio aggiungendo le ore. Alcune configurazioni sono state fissate in fase di inizializzazione, ma in futuro saranno rese disponibili come API.

### Visualizza esempio

Vedi [demo](https://ggbeng1.github.io/Gantt/#/)

### Immagine dimostrativa

<img src="https://raw.githubusercontent.com/GGBeng1/Gantt/master/public/demo.png" alt="">

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---