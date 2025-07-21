<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN">简体中文</a>
        | <a href="#" title="Coming soon">繁體中文 (coming soon)</a> |
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko">한국어</a>
        | <a href="#" title="Coming soon">हिन्दी (coming soon)</a> |
        | <a href="#" title="Coming soon">ไทย (coming soon)</a> |
        | <a href="#" title="Coming soon">Français (coming soon)</a>
        | <a href="#" title="Coming soon">Deutsch (coming soon)</a>
        | <a href="#" title="Coming soon">Español (coming soon)</a>
        | <a href="#" title="Coming soon">Italiano (coming soon)</a>
        | <a href="#" title="Coming soon">Русский (coming soon)</a>
        | <a href="#" title="Coming soon">Português (coming soon)</a>
        | <a href="#" title="Coming soon">Nederlands (coming soon)</a>
        | <a href="#" title="Coming soon">Polski (coming soon)</a>
        | <a href="#" title="Coming soon">العربية (coming soon)</a>
        | <a href="#" title="Coming soon">فارسی (coming soon)</a>
        | <a href="#" title="Coming soon">Türkçe (coming soon)</a>
        | <a href="#" title="Coming soon">Tiếng Việt (coming soon)</a>
        | <a href="#" title="Coming soon">Bahasa Indonesia (coming soon)</a>

      </div>
    </div>
  </details>
</div>

# TimeCapsule LLM
Un LLM addestrato solo su dati di determinati periodi storici per ridurre i bias moderni.

Immagina se un modello di IA non solo fingesse di essere storico, ma lo fosse davvero.

Basato su [nanoGPT di Andrej Karpathy](https://github.com/karpathy/nanoGPT). Gli script principali di training e l’architettura del modello sono opera sua.

# Obiettivi del progetto

TimeCapsule LLM è un progetto sperimentale che verrà addestrato solo su testi scritti in determinati periodi storici. L’obiettivo è simulare la visione del mondo e il linguaggio di specifiche epoche storiche.

# Perché il fine-tuning non basta

Se ti limiti a fare fine-tuning su un modello pre-addestrato, il tuo LLM conoscerà comunque concetti moderni. Ovviamente ottenere zero bias moderni è difficile, ma voglio avvicinarmi il più possibile a questo risultato. Non avere bias moderni richiede addestrare un modello da zero.

# Risultati attesi

Spero che, una volta terminato, questo modello non conosca concetti moderni e non sia in grado di ragionare oltre quanto è stato addestrato. Non dovrebbe riconoscere concetti/vocaboli moderni e spero che non “allucini” conoscenze moderne.

# Aggiornamenti sui progressi

## 9 luglio 2025

Ho fissato il mio periodo di riferimento: 1800-1850 e regione: Londra

Ho raccolto un elenco di testi, libri, documenti

Finora ne ho ottenuti 50 come file txt e inizierò presto l’addestramento di NanoGPT

Aggiornerò questa sezione finché ci saranno progressi

## 13 luglio 2025

Ho addestrato nanoGPT con 187MB di dati testuali storici.

## 15 luglio 2025

Ho iniziato a scaricare testi per la seconda sessione di addestramento. Sto prendendo tutto da Internet Archive e ho esteso il periodo a 1800-1875. Per ottenere una gamma diversificata di testi, puoi usare filtri per soggetto, luogo di pubblicazione, periodo e argomenti su Internet Archive.

![Filtri di ricerca](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 16 luglio 2025

Ho scaricato circa 500 file txt da Internet Archive e dopo la pulizia (eliminando solo spazi vuoti, intestazioni Gutenberg, ecc.) ho circa 500MB di dati. È un dataset minuscolo ma l’ultima volta ho addestrato con 187MB quindi dovrebbe esserci almeno qualche differenza visibile nell’output dopo l’addestramento del secondo modello. Spero che questo modello possa almeno produrre frasi più coerenti che abbiano un senso. Ovviamente non è garantito visto che il dataset è ancora molto piccolo, ma è più di quello che ho usato l’ultima volta.

Questo dovrebbe essere fattibile con il mio hardware, il che è positivo perché posso vedere eventuali miglioramenti prima di passare a un dataset più grande che richiederebbe l’affitto di una GPU. Ma non preoccupatevi, ho comunque intenzione di noleggiare una GPU presto, ma prima voglio assicurarmi che il mio dataset sia il più curato e pulito possibile. Uno dei problemi è la pulizia: molti di questi file txt hanno del testo senza senso mescolato. Gli script che ho usato funzionano ma non sono efficaci al 100%.

Oggi addestrerò questo dataset e dovrebbe richiedere circa 4-5 ore. Una volta terminato e testato, fornirò aggiornamenti. Grazie ancora a tutti quelli che stanno seguendo il mio progetto, alcune persone mi hanno anche passato link a risorse OCR quindi grazie! Spero che più persone provino a sperimentare con i loro dataset.

### Aggiornamento Addestramento

Ho iniziato l’addestramento su un corpus di 435MB (108 milioni di token), sta andando abbastanza bene. La train loss è scesa da 10.9 a 4.9 nelle prime 2800 iterazioni. Penso ci vorranno circa 8 o 9 ore per completare. Pubblicherò un altro aggiornamento una volta finito.

## 17 luglio 2025 2:13AM

L’addestramento è terminato per il secondo modello, la mia 4060 ci ha messo circa 8 ore e 40 minuti (3.900 iterazioni/ora) per 33.000 iterazioni (5 epoche). La train loss finale era 3.73. Gli output erano sorprendentemente buoni: ora genera davvero frasi coerenti nello stile del XIX secolo.

# Comportamento & Limitazioni del Modello V0

I primi prompt mostrano che il modello risponde con linguaggio e comportamenti da 1800. Ad esempio, ho chiesto "Who art Henry?" e ha risposto "I know that man, I have did not a black, the storm." e sì, quella frase non ha senso ma l’LLM riconosce che sto chiedendo di una persona.

![Output di esempio TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

Non ci sono menzioni di concetti moderni, gli output contengono per lo più parole e frasi dell’800.

Serve ancora molto lavoro, addestrare con 187MB non ti darà un modello che produce testo con ragionamenti complessi.

Al momento produce frasi che mancano di struttura e in generale non hanno senso, ma questo è normale con questa dimensione di training.

# Comportamento e Limitazioni del Modello V0.5

Questo è un bel miglioramento rispetto al modello precedente. Lo stile di scrittura e il vocabolario sono vittoriani e quasi ogni frase è grammaticalmente corretta con la punteggiatura appropriata. E ancora una volta, questo modello è stato addestrato da zero, quindi si attiene a soggetti dell’800.

![Esempio di Output TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

Ci sono molte allucinazioni fattuali. Molti (tipo il 100%) dei dettagli (date, eventi, personaggi storici) sono inventati. Inoltre, le frasi non hanno davvero connessioni tra loro, a volte forse 2 frasi si collegano ma oltre a ciò no. Un altro problema è che a volte appare un footer “Digitized by Google” fuori posto, quindi la prossima volta che addestro dovrò assicurarmi che i testi siano ben puliti. Nel complesso sono molto soddisfatto dei risultati, non è ancora lontanamente un LLM ma sicuramente un generatore di frasi.

Sto imparando molto e inizierò a capire cosa devo migliorare nelle prossime settimane. Caricherò i file presto!

# Piani Futuri

(Completato) Inizierò a lavorare sulla versione 0.5, invece di addestrare usando 50 libri, addestrerò utilizzando idealmente 500-600. Attualmente sto addestrando nanoGPT usando libri dal 1800 al 1850 e specificamente da Londra. Ci sono alcune sfide come assicurarsi che i libri trovati non siano aggiornati o abbiano interpretazioni moderne ma siano libri intatti pubblicati all’interno del periodo scelto.

Voglio addestrare un nuovo modello (v1) con un corpus molto più ampio, magari 5-10 volte più grande di quello usato per la v0.5. Il mio obiettivo è vedere se possono emergere capacità di ragionamento dal solo Addestramento Temporale Selettivo, sarà un compito più difficile e non sono nemmeno sicuro sia possibile a causa delle limitazioni dei dati storici. Nelle prossime settimane cercherò di curare abbastanza dati per un corpus di 5-10GB. Credo che se riesco a ottenere dati puliti di alta qualità e affittare una GPU, ci saranno progressi.

# Come Usare Questo Progetto

Questo progetto si concentra principalmente sulla cura di dati storici, la loro preparazione per l’addestramento e la costruzione di un tokenizer. Non tratterò l’intero processo di addestramento LLM, per quello fare riferimento a nanoGPT di Andrej Karpathy.

# Passo 1: Raccogli e Prepara Testi Storici

Raccogli file .txt di libri di pubblico dominio, documenti, ecc. dal periodo di tempo scelto (es.: Londra 1800-1850)

Puoi usare download_texts_improved.py per scaricare i libri se necessario.

Pulisci i file di testo usando uno script o rimuovi manualmente header/footer da Project Gutenberg, annotazioni moderne o errori OCR.

prepare_dataset.py dovrebbe funzionare bene.

# Passo 2: Costruisci un Tokenizer Personalizzato

Esegui train_tokenizer.py o train_tokenizer_hf.py sui dati puliti.
Questo ti darà vocab.json e merges.txt

Questi file definiscono il vocabolario e le regole di fusione per il tuo modello

# Passo 3: Addestra il Tuo Modello (nanoGPT)

Fai riferimento a [nanoGPT di Andrej Karpathy](https://github.com/karpathy/nanoGPT) per il processo di addestramento.

Puoi addestrare un LLM diverso se vuoi, ma io ho usato nanoGPT

# FAQ

## Cos’è l’Addestramento Temporale Selettivo?

L’Addestramento Temporale Selettivo (STT) è una metodologia di machine learning in cui tutti i dati di addestramento sono specificamente curati per rientrare in un determinato periodo storico. È fatto per modellare il linguaggio e la conoscenza di quell’epoca senza influenza da concetti moderni. Ad esempio, il modello attuale (v0.5) è addestrato esclusivamente su dati dal 1800 al 1875, non è raffinato ma addestrato da zero producendo output che riflette lo stile linguistico e il contesto storico di quel periodo.

## Perché non usare solo fine-tuning o LoRA?

Per questo progetto sto cercando di creare un modello linguistico non influenzato dai bias moderni. Se faccio fine-tuning su qualcosa come GPT-2, è già pre-addestrato e quell’informazione non andrà via. Se addestro da zero il modello linguistico non fingerà di essere antico, lo sarà e basta. L’obiettivo ora è creare qualcosa che possa ragionare esclusivamente con la conoscenza dei libri londinesi pubblicati tra il 1800 e il 1850.

## Che tipo di dati hai usato per l’addestramento?

Sto usando libri, documenti legali, giornali e altri scritti dalla Londra 1800–1850. La lista che ho linkato ne ha circa 200 ma per il primo addestramento ho usato solo 50 file per circa ~187 MB. Puoi vedere un elenco dei documenti:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## Quanto è grande il modello Versione 0?

Questo modello è molto piccolo al momento, lo faccio solo per divertimento e seguendo una regola rigorosa di nessuna fonte moderna. Ha quasi 16 milioni di parametri ma inizierò a raccogliere più testi antichi per iniziare un altro addestramento del modello. Fornirò aggiornamenti man mano.

## Specifiche di Addestramento?

GPU: Geforce rtx 4060
CPU: i5-13400F
Ram: 16GB DDR5.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-21

---