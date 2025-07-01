# Gantt
<div style="text-align: center"><p><a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> </p></div>
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
Visualizzazione del diagramma di Gantt sviluppata su base Vue, utilizzabile in scenari agili come collaborazione di squadra e suddivisione dei compiti

Supporta la suddivisione in gruppi
Supporta il drag & drop
Supporta l'allungamento
Supporta la percentuale
Supporta intervalli temporali: giorno, settimana, mese
Attualmente è stata implementata solo la suddivisione di primo livello; per evitare future richieste di suddivisione a due o più livelli, parte del codice è stata ristrutturata nell'ultimo commit per supportare la suddivisione multilivello, ma questa versione non la include ancora

Vantaggi: nelle operazioni di drag & drop, allungamento, modifica della percentuale, i dati non vengono aggiornati in tempo reale, ma solo dopo l'operazione, riducendo così il carico sulle prestazioni
           Durante la modifica, cancellazione o aggiunta, non viene effettuata una modifica ricorsiva su tutta l'istanza, ma solo sulle parti interessate

È in corso una riorganizzazione per preparare la componentizzazione; attualmente, per utilizzarlo nel progetto, basta importare il file `gant.vue` presente nel progetto
Il metodo per l'importazione ed esportazione massiva dei dati è già stato scritto, basta copiarlo direttamente!~

```

### Note di aggiornamento

- Supporta la modifica
- Supporta la cancellazione
- Risolto il bug che impediva lo scrolling verticale (aggiunto lo scroll bidirezionale) [#4](https://github.com/GGBeng1/Gantt/issues/4)
- Risolto il bug causato da elementUI
- Problema relativo all'intervallo temporale [#5](https://github.com/GGBeng1/Gantt/issues/5)
- Al momento non è possibile ottenere altri intervalli tramite la modifica delle impostazioni, ad esempio aggiungere le ore. Alcune configurazioni sono fissate durante l’inizializzazione; verranno rese modificabili tramite api nelle prossime versioni


### Visualizza esempio

Vedi [demo](https://ggbeng1.github.io/Gantt/#/)

### Immagine dimostrativa

<img src="https://raw.githubusercontent.com/GGBeng1/Gantt/master/public/demo.png" alt="">

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-01

---