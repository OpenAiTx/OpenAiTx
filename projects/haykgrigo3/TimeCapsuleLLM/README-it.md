
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
Un LLM addestrato solo su dati di determinati periodi storici per ridurre il bias moderno.

Immagina se un modello AI non si limitasse a fingere di essere storico, ma lo fosse davvero.

Basato su [nanoGPT di Andrej Karpathy](https://github.com/karpathy/nanoGPT) Gli script di addestramento principali e l’architettura del modello sono opera sua.

# Obiettivi del Progetto

TimeCapsule LLM è un progetto sperimentale che sarà addestrato solo su testi scritti in determinati periodi storici. L’obiettivo è simulare la visione del mondo e la lingua di specifiche epoche storiche.

# Perché il fine tuning non basta

Se fai solo il fine tuning di un modello pre-addestrato, il tuo LLM conoscerà comunque concetti moderni. Ovviamente raggiungere zero bias moderno è difficile ma voglio avvicinarmi il più possibile a questo. Azzerare il bias moderno richiede l’addestramento di un modello da zero.

# Risultati attesi

Si spera che, una volta completato, questo modello non conosca concetti moderni e non sia in grado di ragionare oltre ciò su cui è stato addestrato. Non dovrebbe riconoscere concetti/vocaboli moderni e spero che non “allucini” conoscenze moderne.

# Aggiornamenti sui progressi

## 9 luglio 2025

Ho impostato il mio periodo di riferimento tra il 1800 e il 1850 e la regione: Londra

Ho raccolto una lista di testi, libri, documenti

Finora ne ho ottenuti 50 come file txt e inizierò presto l’addestramento di NanoGPT

Aggiornerò questa sezione man mano che farò progressi

## 13 luglio 2025

Ho addestrato nanoGPT con 187MB di testi storici.

## 15 luglio 2025

Ho iniziato a scaricare testi per la seconda sessione di addestramento. Sto prendendo tutto dall’Internet Archive e ho ampliato il periodo a 1800-1875. Per ottenere una gamma diversificata di testi puoi usare i filtri di ricerca per luogo di pubblicazione, periodo storico e argomenti su Internet Archive.

![Filtri di ricerca](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 16 luglio 2025

Ho scaricato circa 500 file txt da Internet Archive e, dopo averli ripuliti (solo spazi bianchi, intestazioni Gutenberg, ecc.), ho circa 500MB di dati. È un dataset minuscolo ma l’ultima volta ho addestrato con 187MB quindi dovrebbe esserci almeno qualche differenza rilevabile nell’output dopo aver addestrato il secondo modello. Spero che questo modello possa almeno produrre frasi più coerenti che abbiano senso. Ovviamente non è garantito, dato che il dataset è ancora minuscolo, ma è comunque più di quanto usato l’ultima volta.

Questo dovrebbe essere fattibile sull’hardware che ho, il che è positivo perché spero di vedere qualche miglioramento prima di passare a un dataset più grande che richiederebbe l’affitto di una GPU. Ma non preoccupatevi, ho comunque intenzione di noleggiare una GPU presto, ma prima voglio essere sicuro che il mio dataset sia il più curato e pulito possibile. Uno dei problemi che ho è la pulizia, molti di questi file txt hanno dentro del “gibberish”. Gli script che ho usato funzionano ma non sono efficaci al 100%.

Allenerò questo dataset oggi e dovrebbe richiedere circa 4-5 ore. Una volta terminato e testato, vi aggiornerò. Grazie ancora a tutti quelli che stanno seguendo il mio progetto, alcune persone mi hanno anche mandato link a risorse OCR quindi grazie! Spero che più persone provino a sperimentare con i propri dataset.


### Aggiornamento sull’addestramento

Ho iniziato ad addestrare su un corpus di 435MB (108 M di token), al momento sta andando piuttosto bene. La train loss è scesa da 10,9 a 4,9 nelle prime 2800 iterazioni. Credo che ci vorranno circa 8 o 9 ore per completare. Pubblicherò un altro aggiornamento una volta finito.

## 17 luglio 2025

L’addestramento è terminato per il secondo modello, la mia 4060 ci ha messo circa 8 ore e 40 minuti (3.900 iteraz./ora) per 33.000 iterazioni (5 epoche). La train loss finale è stata di 3,73. Gli output erano sorprendentemente buoni, ora genera davvero frasi coerenti in stile XIX secolo.

## 28 luglio 2025

Ho caricato la versione v0.5 su Hugging Face, [Dai un’occhiata](https://huggingface.co/haykgrigorian/TimeCapsuleLLM) se vuoi. Ora puoi scaricare il mio repo ed eseguirlo localmente. Sfortunatamente nanoGPT non funziona nativamente con HuggingFace, quindi dovrai scaricare ed eseguire il modello in locale.

Inoltre inizierò a curare dati per la prossima sessione di addestramento, credo che mi serviranno forse 5-10 volte più dati per ottenere capacità di ragionamento.

## 2 agosto 2025

Presto inizierò a lavorare sulla Versione 1. Dovrò passare dall’architettura di nanoGPT a qualcosa di più moderno. Ho in mente diverse architetture LLM open source, tra cui: OpenLLaMA v3, Phi-2 e Qwen 1.5B. E per supportare il salto a V1, dovrò curare con attenzione un dataset molto più grande e diversificato. Mi serviranno almeno 5GB di dati di addestramento puliti.

# Comportamento e Limitazioni del Modello V0

I primi prompt mostrano il modello rispondere con linguaggio e comportamenti dell’Ottocento. Ad esempio, l’ho stimolato con "Who art Henry?" e ha risposto "I know that man, I have did not a black, the storm." e sì, quella frase non ha senso ma il LLM riconosce che sto chiedendo di una persona.

![Esempio Output TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

Non ci sono riferimenti a concetti moderni, gli output contengono per lo più parole e frasi dell’Ottocento.

Ha ancora bisogno di molto lavoro, l’addestramento su 187MB non produrrà un modello capace di ragionamenti complessi.

Al momento genera frasi prive di struttura completa e generalmente senza senso, ma questo è normale per la dimensione del training.

# Comportamento e Limitazioni del Modello V0.5

Questo è un bel miglioramento rispetto al modello precedente. Lo stile di scrittura e il vocabolario sono vittoriani e quasi ogni frase è grammaticalmente corretta con la punteggiatura giusta. Anche questo è addestrato da zero quindi si attiene ai temi dell’Ottocento.

![Esempio Output TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

Ci sono molte allucinazioni fattuali. Molti (tipo il 100%) dei dettagli (date, eventi, figure storiche) sono inventati. Inoltre le frasi non hanno davvero connessioni tra loro, a volte forse 2 frasi si collegano ma oltre no. Un altro problema è che a volte appare un footer “Digitized by Google” fuori posto, quindi la prossima volta dovrò pulire meglio i testi. Nel complesso sono molto soddisfatto dei risultati, non è ancora un LLM ma sicuramente un generatore di frasi.

Sto imparando molto e nelle prossime settimane capirò cosa devo migliorare. Caricherò presto i file!

# Piani Futuri

(Completato) Inizio a lavorare sulla versione 0.5, invece di usare 50 libri per il training, ne userò idealmente 500-600. Ora sto addestrando nanoGPT usando libri dal 1800 al 1850 e specificamente da Londra. Ci sono alcune sfide, come assicurarsi che i libri trovati non siano aggiornati o con interpretazioni moderne ma rimasti intatti pubblicati nel periodo scelto.

Voglio addestrare un nuovo modello (v1) con un corpus molto più grande, magari 5-10 volte quello usato per v0.5. Il mio obiettivo è vedere se riesco a far emergere capacità di ragionamento dal solo Selective Temporal Training, sarà più difficile e non sono neanche sicuro sia possibile dato che ci sono limitazioni storiche nei dati. Nelle prossime settimane cercherò di curare abbastanza dati per un corpus da 5-10GB. Credo che se riesco ad avere dati puliti e di alta qualità e ad affittare una GPU, ci sarà progresso.

# Come Usare Questo Progetto

Questo progetto si concentra soprattutto sulla cura di dati storici, la loro preparazione per il training e la costruzione di un tokenizer. Non coprirò l’intero processo di training di un LLM, per quello fai riferimento a nanoGPT di Andrej Karpathy.

# Passo 1: Raccogli e Prepara Testi Storici

Raccogli file .txt di libri di dominio pubblico, documenti, ecc. dal periodo scelto (es. Londra 1800-1850)

Puoi usare download_texts_improved.py per scaricare libri se necessario.

Pulisci i file di testo tramite script o manualmente rimuovendo header/footer di Project Gutenberg, annotazioni moderne o errori OCR.

prepare_dataset.py dovrebbe andare bene.

# Passo 2: Costruisci un Tokenizer Personalizzato

Esegui train_tokenizer.py o train_tokenizer_hf.py sui dati puliti.
Otterrai vocab.json e merges.txt

Questi file definiscono vocaboli e regole di merge per il tuo modello

# Passo 3: Addestra il Tuo Modello (nanoGPT)

Fai riferimento a [nanoGPT di Andrej Karpathy](https://github.com/karpathy/nanoGPT) per il processo di training.

Puoi addestrare un altro LLM se vuoi, ma io ho usato nanoGPT

# FAQ

## Cos’è il Selective Temporal Training?

Il Selective Temporal Training (STT) è una metodologia di machine learning in cui tutti i dati di training sono curati specificamente per rientrare in un determinato periodo storico. Serve a modellare il linguaggio e la conoscenza di quell’epoca senza influenze moderne. Ad esempio, il modello attuale (v0.5) è addestrato esclusivamente su dati dal 1800 al 1875, non è fine-tuned ma addestrato da zero producendo output che riflettono stile linguistico e contesto storico di quel periodo.

## Perché non usare solo fine-tuning o LoRA?

Per questo progetto sto cercando di creare un modello linguistico privo di bias moderno. Se faccio fine-tuning su qualcosa tipo GPT-2, è già pre-addestrato e quell’informazione non sparirà. Se addestro da zero il modello non fingerà di essere antico, lo sarà davvero. L’obiettivo ora è creare qualcosa che possa ragionare solo usando conoscenza da libri londinesi pubblicati tra il 1800 e il 1850.

## Che tipo di dati hai usato per l’addestramento?

Uso libri, documenti legali, giornali e altri scritti dalla Londra del 1800–1850. La lista che ho linkato ne ha circa 200 ma per il primo training ho usato solo 50 file, circa ~187 MB. Puoi vedere la lista dei documenti:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## Quanto è grande il modello Versione 0?

Questo modello è molto piccolo al momento, lo faccio solo per divertimento e seguendo la regola ferrea di nessuna fonte moderna. Ha quasi 16 milioni di parametri ma inizierò a raccogliere altri testi antichi per un nuovo training. Aggiornerò man mano.

## Specifiche di Training?

GPU: Geforce rtx 4060
CPU: i5-13400F
Ram: 16GB DDR5.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-07

---