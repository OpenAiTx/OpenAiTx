
<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN">简体中文</a>
        | <a href="#" title="Coming soon">繁體中文 (presto disponibile)</a> |
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko">한국어</a>
        | <a href="#" title="Coming soon">हिन्दी (presto disponibile)</a> |
        | <a href="#" title="Coming soon">ไทย (presto disponibile)</a> |
        | <a href="#" title="Coming soon">Français (presto disponibile)</a>
        | <a href="#" title="Coming soon">Deutsch (presto disponibile)</a>
        | <a href="#" title="Coming soon">Español (presto disponibile)</a>
        | <a href="#" title="Coming soon">Italiano (presto disponibile)</a>
        | <a href="#" title="Coming soon">Русский (presto disponibile)</a>
        | <a href="#" title="Coming soon">Português (presto disponibile)</a>
        | <a href="#" title="Coming soon">Nederlands (presto disponibile)</a>
        | <a href="#" title="Coming soon">Polski (presto disponibile)</a>
        | <a href="#" title="Coming soon">العربية (presto disponibile)</a>
        | <a href="#" title="Coming soon">فارسی (presto disponibile)</a>
        | <a href="#" title="Coming soon">Türkçe (presto disponibile)</a>
        | <a href="#" title="Coming soon">Tiếng Việt (presto disponibile)</a>
        | <a href="#" title="Coming soon">Bahasa Indonesia (presto disponibile)</a>

      </div>
    </div>
  </details>
</div>

# TimeCapsule LLM
Un LLM addestrato solo su dati di determinati periodi storici per ridurre i bias moderni.

Immagina se un modello AI non si limitasse a fingere di essere storico, ma lo fosse davvero.

Basato su [nanoGPT di Andrej Karpathy](https://github.com/karpathy/nanoGPT). Gli script di training principali e l’architettura del modello sono opera sua.

# Obiettivi del Progetto

TimeCapsule LLM è un progetto sperimentale che verrà addestrato solo su testi scritti in determinati periodi storici. L’obiettivo è simulare la visione del mondo e il linguaggio di specifiche epoche storiche.

# Perché il fine-tuning non basta

Se si esegue solo un fine-tuning su un modello pre-addestrato, il vostro LLM conoscerà comunque concetti moderni. Ovviamente raggiungere un bias moderno pari a zero è difficile, ma voglio avvicinarmi il più possibile a questo obiettivo. Ottenere l’assenza di bias moderni richiede un addestramento del modello da zero.

# Risultati attesi

Spero che, una volta completato, questo modello non conosca concetti moderni e non sia in grado di ragionare oltre ciò su cui è stato addestrato. Non dovrebbe riconoscere vocaboli/conoscenze moderne e spero che non “allucini” conoscenze moderne.

# Aggiornamenti sui progressi

## 9 luglio 2025

Ho fissato il mio periodo di riferimento tra il 1800 e il 1850 e la regione: Londra

Ho raccolto un elenco di testi, libri, documenti

Finora ne ho ottenuti 50 in formato txt e inizierò presto il training di NanoGPT

Aggiornerò questa sezione man mano che progredisco

## 13 luglio 2025

Ho addestrato nanoGPT con 187MB di testi storici.

## 15 luglio 2025

Ho iniziato a scaricare testi per la seconda sessione di training. Sto prendendo tutto da Internet Archive e ho ampliato il periodo a 1800-1875. Per ottenere una gamma diversificata di testi, puoi usare i filtri per soggetto e ricerca per luogo di pubblicazione, periodo e argomenti su Internet Archive.

![Filtri di Ricerca](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 16 luglio 2025

Ho scaricato circa 500 file txt da Internet Archive e dopo averli ripuliti (eliminando solo spazi bianchi, header Gutenberg, ecc.) ho circa 500MB di dati. È un dataset piccolo ma l’ultima volta ho addestrato su 187MB quindi dovrei vedere almeno qualche differenza nell’output dopo aver addestrato il secondo modello. Spero che questo modello riesca almeno a produrre frasi più coerenti che abbiano un senso. Ovviamente non è garantito dato che il dataset è ancora minuscolo, ma è più grande rispetto all’ultima volta.

Questo dovrebbe essere fattibile sul mio hardware personale, il che è positivo perché posso vedere qualche miglioramento prima di passare a un dataset più grande che richiederebbe il noleggio di una GPU. Ma non preoccuparti, ho comunque intenzione di noleggiare presto una GPU, ma prima voglio assicurarmi che il mio dataset sia il più possibile curato e pulito. Uno dei problemi è la pulizia; molti di questi file txt hanno dentro del “gibberish”. Gli script che ho usato per la pulizia funzionano, ma non sono efficaci al 100%.

Allenerò questo dataset oggi e dovrebbe richiedere circa 4-5 ore. Una volta terminato e testato, fornirò aggiornamenti. Grazie ancora a tutti coloro che stanno seguendo il mio progetto, alcune persone mi hanno anche fornito link a risorse OCR quindi grazie! Spero che più persone provino a sperimentare con i propri dataset.

## 28 luglio 2025

Ho caricato la versione v0.5 su Hugging Face, [Dai un’occhiata](https://huggingface.co/haykgrigorian/TimeCapsuleLLM) se vuoi. Ora puoi scaricare il mio repository ed eseguirlo localmente. Purtroppo nanoGPT non funziona nativamente con HuggingFace, quindi dovrai scaricare ed eseguire il modello in locale.

Inoltre inizierò a curare i dati per la prossima sessione di training, credo mi serviranno forse 5-10 volte più dati per raggiungere capacità di ragionamento.

### Aggiornamento Training

Ho iniziato il training su un corpus di 435MB (108 M di token), al momento sta andando piuttosto bene. La train loss è scesa da 10.9 a 4.9 nelle prime 2800 iterazioni. Penso che ci vorranno circa 8 o 9 ore per completarlo. Pubblicherò un altro aggiornamento quando sarà finito.

## 17 luglio 2025, ore 2:13

Il training è terminato per il secondo modello, la mia 4060 ha impiegato circa 8 ore e 40 minuti (3.900 iter/ora) per 33.000 iterazioni (5 epoche). La train loss finale è stata 3.73. Gli output erano sorprendentemente buoni: ora genera frasi coerenti in stile XIX secolo.

# Comportamento & Limitazioni del Modello V0

I primi prompt mostrano che il modello risponde con linguaggio e comportamento da anni 1800. Ad esempio, ho chiesto "Who art Henry?" e ha risposto "I know that man, I have did not a black, the storm." e sì, quella frase non ha senso ma l’LLM sta riconoscendo che sto chiedendo di una persona.

![TimeLockLLM Esempio Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)
Non c'è alcun riferimento a concetti moderni, gli output contengono principalmente parole ed espressioni dell’Ottocento.

C'è ancora molto lavoro da fare, addestrare su 187MB non ti darà un modello che produca testo con ragionamento complesso.

Al momento genera frasi che mancano di una struttura completa e in generale non hanno senso, ma questo è normale per la dimensione del training.

# Comportamento e Limitazioni del Modello V0.5

Questo è un bel miglioramento rispetto al modello precedente. Lo stile di scrittura e il vocabolario sono vittoriani e quasi tutte le frasi sono grammaticalmente corrette con la punteggiatura giusta. E anche questo è addestrato da zero quindi si attiene ai temi dell’Ottocento.

![Esempio di Output TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

Ci sono molte allucinazioni fattuali. Molti (tipo il 100%) dei dettagli (date, eventi, personaggi storici) sono inventati. Inoltre le frasi non hanno davvero collegamento tra loro, a volte forse 2 frasi sono correlate ma oltre non lo sono. Un altro problema è che a volte compare un footer “Digitized by Google”, quindi la prossima volta dovrò assicurarmi di pulire bene i testi. Nel complesso sono molto contento dei risultati, non è ancora un LLM ma sicuramente è un generatore di frasi.

Sto imparando molto e nelle prossime settimane cercherò di capire cosa devo migliorare. Caricherò presto i file!

# Piani Futuri

(Completato) Inizierò a lavorare sulla versione 0.5, invece di addestrare usando 50 libri, userò idealmente 500-600. Al momento sto addestrando nanoGPT usando libri dal 1800 al 1850 e specificatamente da Londra. Ci sono delle sfide, come assicurarsi che i libri trovati non siano aggiornati o abbiano interpretazioni moderne ma siano libri intatti pubblicati nel periodo scelto.

Voglio addestrare un nuovo modello (v1) con un corpus molto più grande, magari 5-10 volte più grande di quello usato per la v0.5. Il mio obiettivo è vedere se riesco a far emergere capacità di ragionamento dal Solo Addestramento Temporale Selettivo, sarà un compito più difficile e non sono nemmeno sicuro che sia possibile a causa dei limiti dei dati storici. Nelle prossime settimane cercherò di curare abbastanza dati per un corpus di 5-10GB. Credo che se riuscirò a ottenere dati puliti di alta qualità e noleggiare una GPU, ci saranno progressi.

# Come Usare Questo Progetto

Questo progetto si concentra principalmente sulla raccolta di dati storici, la loro preparazione per l’addestramento e la costruzione di un tokenizer. Non tratterò l’intero processo di addestramento LLM, per quello fai riferimento a nanoGPT di Andrej Karpathy.

# Passo 1: Raccogli e Prepara Testi Storici

Raccogli file .txt di libri di pubblico dominio, documenti, ecc dal periodo scelto (es: Londra 1800-1850)

Puoi usare download_texts_improved.py per scaricare libri se ne hai bisogno.

Pulisci i file di testo usando uno script o rimuovi manualmente intestazioni/footer di Project Gutenberg, annotazioni moderne o errori OCR.

prepare_dataset.py dovrebbe funzionare bene.

# Passo 2: Costruisci un Tokenizer Personalizzato

Esegui train_tokenizer.py o train_tokenizer_hf.py sui dati puliti.
Questo ti darà vocab.json e merges.txt

Questi file definiscono il vocabolario e le regole di unione per il tuo modello

# Passo 3: Addestra il Tuo Modello (nanoGPT)

Fai riferimento a [nanoGPT di Andrej Karpathy](https://github.com/karpathy/nanoGPT) per il processo di addestramento.

Puoi addestrare un altro LLM se vuoi, ma io ho usato nanoGPT

# FAQ

## Cos’è il Selective Temporal Training?

Il Selective Temporal Training (STT) è una metodologia di machine learning in cui tutti i dati di addestramento sono curati specificamente per rientrare in un determinato periodo storico. Si fa per modellare il linguaggio e la conoscenza di quell’epoca senza l’influenza di concetti moderni. Ad esempio, il modello che ho ora (v0.5) è addestrato esclusivamente su dati dal 1800 al 1875, non è fine tuned ma addestrato da zero, producendo output che riflettono lo stile linguistico e il contesto storico di quel periodo.

## Perché non usare solo fine-tuning o LoRA?

Per questo progetto sto cercando di creare un modello linguistico non influenzato da bias moderni. Se faccio fine-tuning su qualcosa come GPT-2, è già pre-addestrato e quell’informazione non andrà via. Se addestro da zero il modello non fingerà di essere antico, lo sarà davvero. L’obiettivo per ora è creare qualcosa che possa ragionare esclusivamente usando conoscenze tratte da libri londinesi pubblicati tra il 1800 e il 1850.

## Che tipo di dati hai usato per l’addestramento?

Uso libri, documenti legali, giornali e altri scritti della Londra 1800–1850. La lista che ho linkato ne ha circa 200 ma per il primo addestramento ho usato solo 50 file per circa ~187 MB. Puoi vedere una lista dei documenti:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## Quanto è grande la Versione 0 del modello?

Questo modello è molto piccolo al momento, lo sto facendo solo per divertimento e seguendo una regola ferrea di nessuna fonte moderna. Ha quasi 16 milioni di parametri ma inizierò a raccogliere altri testi antichi per iniziare un nuovo addestramento. Darò aggiornamenti strada facendo.

## Specifiche dell’addestramento?

GPU: Geforce rtx 4060
CPU: i5-13400F 
Ram: 16GB DDR5.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---