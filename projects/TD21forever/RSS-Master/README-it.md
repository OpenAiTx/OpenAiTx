# RSS-Master

Personalizzazione, filtraggio e selezione delle fonti RSS, utilizzo di AI per riepiloghi, sintesi e punteggi. Versione ottimizzata per le prestazioni, supporta l'elaborazione asincrona e la sintesi AI parallela.

### Prefazione

All'inizio di settembre, ho iniziato a utilizzare Inoreader + RSSHub per aggregare e sottoscrivere le fonti RSS di mio interesse, abbinato a Reeder per la lettura, tentando di controllare completamente le fonti di informazioni quotidiane. Dopo un mese, l'aumento progressivo delle fonti RSS e delle informazioni non lette ha generato in me una certa ansia da lettura, così ho pensato se fosse possibile definire alcune regole di filtro personalizzate, preferibilmente con l'aiuto dell'AI per facilitare la lettura e ridurre il mio carico.

Inoreader ha un filtro integrato, ma pagare solo per questa funzione sembrava poco conveniente; NewsBlur ha "Intelligence Trainer" per una classificazione intelligente, ma dopo un breve test non ho notato benefici evidenti nel breve termine; Feedly offre sia filtri che funzionalità AI, sembrava soddisfare le mie esigenze. Proprio mentre esitavo se passare da Inoreader a un abbonamento Feedly, ho scoperto questi due progetti:

- [Far riassumere Hacker News da ChatGPT](https://blog.betacat.io/post/2023/06/summarize-hacker-news-by-chatgpt/)
- [Guida all'uso di RSS-GPT](http://yinan.me/rss-gpt-manual-zh.html)

L'idea generale di entrambi i progetti è eseguire uno script tramite GitAction, ottenere le informazioni e utilizzare l'API di Open AI per tradurre, riassumere, quindi renderizzare in un template e distribuirlo su GitHub Page. Il metodo di RSS-GPT soddisfa maggiormente le mie esigenze: eseguendo uno script programmato per ottenere direttamente il file xml RSS, elaborarlo e distribuire l'xml su GitHub Page, si ottiene un link di accesso a questo file xml che poi il lettore può sottoscrivere direttamente.

Ho un forte bisogno di sincronizzazione multi-dispositivo con Inoreader; per le nuove fonti RSS aggiunte nel file di configurazione config, è necessario notificare tempestivamente Inoreader per sincronizzare. Così ho esteso l'idea di [RSS-GPT](https://github.com/yinan-c/), chiamandolo RSS-Master.

### Caratteristiche principali

- **Supporto per elaborazione parallela**: utilizza asincronia e pool di thread per elaborare in parallelo fonti RSS e sintesi AI, migliorando significativamente la velocità
- **Meccanismo di cache migliorato**: sistema di cache più stabile per evitare perdita di dati e migliorare le prestazioni in accessi ripetuti
- **Gestione degli errori migliorata**: tutte le operazioni hanno gestione completa degli errori e logging per maggiore stabilità
- **Estrazione ottimizzata del contenuto HTML**: estrazione intelligente del contenuto degli articoli, ignorando informazioni irrilevanti per migliorare la qualità della sintesi AI
- **Supporto per l'ultima API OpenAI**: piena compatibilità con l'ultima versione dell'API OpenAI
- **Statistiche dettagliate**: dopo l'elaborazione fornisce tempo di esecuzione, tassi di successo e statistiche sui costi
- **Supporto per generazione file opml**: e conversione bidirezionale con config.yml tramite `script/convert_opml_to_yaml.sh` e `script/convert_yaml_to_opml.sh`
- **Supporto a regole di filtro personalizzate**: supporta due tipi di filtro, include ed exclude, e due ambiti, titolo e articolo
- **Modello AI personalizzabile**: configurabile tramite variabile d'ambiente per usare diversi modelli OpenAI
- **URL base personalizzabile**: configurabile per l’accesso base ai file RSS, facilitando il deploy in ambienti diversi
- **Notebook interattivo per test**: fornisce notebook Jupyter per testare le funzionalità

### Configurazione variabili ambiente

Il progetto supporta la configurazione dei seguenti parametri tramite file `.env`:

```
# Parametri obbligatori
OPENAI_API_KEY=tuo_openai_api_key_qui

# Parametri opzionali
RSS_BASE_URL=https://example.com/rss-feeds/  # URL base RSS
OPENAI_MODEL=gpt-4o-mini-2024-07-18          # Modello OpenAI
LOG_LEVEL=INFO                               # Livello di log
PARALLEL_WORKERS=5                           # Numero di processi paralleli
```

È possibile copiare il file `.env.example`, rinominarlo in `.env` e modificare i valori corrispondenti.

### Miglioramenti delle prestazioni

Questa versione presenta i seguenti miglioramenti rispetto alla versione originale:

1. **Elaborazione parallela delle fonti RSS**: utilizzo di `asyncio` per elaborare simultaneamente più fonti RSS
2. **Sintesi AI parallela**: utilizzo di pool di thread per elaborare in parallelo la sintesi AI di più articoli
3. **Ottimizzazione elaborazione testo**: migliorato l’algoritmo di estrazione del contenuto HTML per cogliere in modo più intelligente le parti chiave degli articoli
4. **Gestione sicura dei file**: meccanismo sicuro di scrittura file per evitare perdita dati in caso di crash del programma
5. **Ottimizzazione uso memoria**: ottimizzati strutture dati e flussi di elaborazione per ridurre il consumo di memoria

### Istruzioni per l'uso

1. Clonare il progetto localmente
2. Installare le dipendenze: `pip install -r requirements.txt`
3. Creare il file `.env` e impostare la chiave API OpenAI: `OPENAI_API_KEY=la_tua_chiave`
4. Modificare `resource/config.yml` per configurare le fonti RSS
5. Eseguire `python main.py` per iniziare l'elaborazione

### Test e debug

Il progetto fornisce un notebook interattivo `test.ipynb` per testare le funzionalità:

1. Acquisizione e parsing delle fonti RSS
2. Funzionalità del filtro
3. Funzione di riepilogo AI
4. Meccanismo di cache
5. URL base personalizzato
6. Test delle prestazioni

Istruzioni d’uso:

```bash
# Installare Jupyter
pip install jupyter

# Avviare il notebook
jupyter notebook test.ipynb
```

### Esempio di regole di filtro personalizzate

```yaml
- htmlUrl: http://www.smzdm.com
  name: c5738f
  text: 什么值得买 | 优惠精选
  url: http://feed.smzdm.com
  filters:
    - type: include
      field: title
      keywords:
        [
          '可乐',
          '雪碧',
          '芬达',
          '柠檬',
          '茶叶',
          '纸巾',
          '酒精',
          '湿纸巾',
          '餐巾纸',
        ]
```

### Screenshot d’uso

- Funzionalità di sintesi e riepilogo AI

<div style="display: flex;">
    <img src="https://raw.githubusercontent.com/TD21forever/RSS-Master/main/typora/202310031757486.png" alt="image-20231003174334231" style="width: 45%;">
    <img src="https://raw.githubusercontent.com/TD21forever/RSS-Master/main/typora/202310031757686.png" alt="image-20231003175143405" style="width: 45%;">
</div>

- Filtro personalizzato: filtrare il canale "什么值得买" per offerte vantaggiose, raccomandando solo prodotti recenti da accumulare, come bevande gassate

<img src="https://raw.githubusercontent.com/TD21forever/RSS-Master/main/typora/%E4%BB%80%E4%B9%88%E5%80%BC%E5%BE%97%E4%B9%B0-%E6%B1%BD%E6%B0%B4.png" alt="image-20231003164248923" style="width: 400px; height: 400px;" />

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---