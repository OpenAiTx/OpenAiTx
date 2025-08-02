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
Un LLM addestrato solo su dati di determinati periodi per ridurre i bias moderni.

Immagina se un modello AI non si limitasse a fingere di essere storico ma lo fosse davvero.

Basato su [nanoGPT di Andrej Karpathy](https://github.com/karpathy/nanoGPT). Gli script di addestramento principali e l'architettura del modello sono opera sua.

# Obiettivi del Progetto

TimeCapsule LLM è un progetto sperimentale che verrà addestrato solo su testi scritti in determinati periodi storici. L'obiettivo è simulare la visione del mondo e il linguaggio di specifiche epoche storiche.

# Perché il fine tuning non basta

Se esegui solo un fine tuning su un modello pre-addestrato, il tuo LLM conoscerà comunque concetti moderni. Ovviamente ottenere zero bias moderno è difficile, ma voglio avvicinarmi il più possibile a questo risultato. Per non avere bias moderni è necessario addestrare un modello da zero.

# Risultati attesi

Si spera che, una volta terminato, questo modello non conosca concetti moderni e non sia in grado di ragionare oltre ciò su cui è stato addestrato. Non dovrebbe riconoscere concetti o vocabolario moderni e spero che non "allucini" conoscenze moderne.

# Aggiornamenti sui Progressi

## 9 luglio 2025

Ho fissato il mio periodo di interesse: 1800-1850 e regione: Londra

Ho raccolto un elenco di testi, libri, documenti

Finora ne ho ottenuti 50 in formato txt e inizierò presto l’addestramento di NanoGPT

Aggiornerò questa sezione man mano che ci saranno progressi

## 13 luglio 2025

Ho addestrato nanoGPT con 187MB di dati testuali storici.

## 15 luglio 2025

Ho iniziato a scaricare testi per la seconda sessione di addestramento. Sto prendendo tutto da Internet Archive e ho ampliato il periodo a 1800-1875. Per ottenere una gamma diversificata di testi, puoi usare i filtri per soggetto e ricerca relativi al luogo di pubblicazione, periodo e argomenti su Internet Archive.

![Filtri di Ricerca](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 16 luglio 2025

Ho scaricato circa 500 file txt da Internet Archive e dopo averli ripuliti (eliminando spazi bianchi, intestazioni Gutenberg, ecc.) ho circa 500MB di dati. È un dataset piccolo ma la volta scorsa ho addestrato con 187MB quindi dovrei vedere almeno qualche differenza nell’output dopo aver addestrato il secondo modello. Spero che questo modello riesca almeno a produrre frasi più coerenti che abbiano un certo senso. Ovviamente non è garantito visto che il dataset è ancora molto piccolo, ma è più di quanto usato la volta scorsa.

Dovrebbe essere fattibile con il mio hardware, ed è anche positivo perché spero di vedere qualche miglioramento prima di passare a un dataset più grande che richiederebbe di affittare una GPU. Ma non preoccupatevi, ho comunque intenzione di noleggiare una GPU a breve, ma prima voglio assicurarmi che il mio dataset sia il più curato e pulito possibile. Uno dei problemi che ho è la pulizia, molti di questi file txt contengono del testo insensato. Gli script che ho usato funzionano ma non sono efficaci al 100%.

Allenerò questo dataset oggi e dovrebbe richiedere circa 4-5 ore. Una volta completato e testato, fornirò aggiornamenti. Grazie ancora a tutti quelli che stanno seguendo il mio progetto, alcune persone mi hanno anche segnalato risorse OCR quindi grazie! Spero che altri provino a fare esperimenti con i propri dataset.


### Aggiornamento Addestramento

Ho iniziato l’addestramento su un corpus di 435MB (108 milioni di token), sta andando abbastanza bene al momento. La train loss è scesa da 10.9 a 4.9 nelle prime 2800 iterazioni. Credo ci vorranno circa 8 o 9 ore per completare. Pubblicherò un altro aggiornamento una volta terminato.

## 17 luglio 2025 2:13AM

L’addestramento è terminato per il secondo modello, la mia 4060 ha impiegato circa 8 ore e 40 minuti (3.900 iter/ora) per 33.000 iterazioni (5 epoche). La train loss finale è stata 3.73. Gli output sono stati sorprendentemente buoni: ora genera davvero frasi in stile XIX secolo in modo coerente.

## 28 luglio 2025

Ho caricato la versione 0.5 su Hugging Face, [Dai un’occhiata](https://huggingface.co/haykgrigorian/TimeCapsuleLLM) se vuoi. Ora puoi scaricare la mia repo ed eseguirla localmente. Sfortunatamente nanoGPT non funziona nativamente con HuggingFace, quindi dovrai scaricare ed eseguire il modello localmente.

Inoltre inizierò a curare i dati per la prossima sessione di addestramento. Credo che avrò bisogno di almeno 5-10 volte più dati per ottenere capacità di ragionamento.


# Comportamento e Limiti del Modello V0

I primi prompt mostrano che il modello risponde con linguaggio e comportamento da 1800. Ad esempio, l’ho interrogato con “Who art Henry?” e ha risposto “I know that man, I have did not a black, the storm.” e sì, quella frase non ha senso ma l’LLM riconosce che sto chiedendo di una persona.


![Esempio di Output TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

Non c'è alcun riferimento a concetti moderni, gli output contengono per lo più parole e formulazioni tipiche del 1800.

C'è ancora molto lavoro da fare, addestrarsi su 187MB non permette di ottenere un modello capace di produrre testo con ragionamento complesso.

Attualmente produce frasi che mancano di una struttura completa e in generale non hanno senso, ma ciò è normale per la dimensione del dataset di addestramento.

# Comportamento e Limitazioni del Modello V0.5

Questo rappresenta un notevole miglioramento rispetto al modello precedente. Lo stile di scrittura e il vocabolario sono vittoriani e quasi ogni frase è grammaticalmente corretta, con la punteggiatura appropriata. E di nuovo, essendo stato addestrato da zero, resta fedele agli argomenti dell’800.

![Esempio di Output TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

Sono presenti molte allucinazioni fattuali. Molti (come il 100%) dei dettagli (date, eventi, personaggi storici) sono inventati. Inoltre, le frasi spesso non sono collegate tra loro: a volte forse 2 frasi hanno relazione, ma oltre a ciò non lo sono. Un altro problema è che talvolta compare un footer errante “Digitized by Google”, quindi la prossima volta che addestro dovrò davvero assicurarmi che i testi siano ben puliti. In generale, sono molto soddisfatto dei risultati: non è ancora lontanamente un LLM ma sicuramente è un generatore di frasi.

Sto imparando molto e presto cercherò di capire cosa devo migliorare nelle prossime settimane. Caricherò i file a breve!

# Piani Futuri

(Completato) Inizierò a lavorare sulla versione 0.5; invece di usare 50 libri per l’addestramento, ne userò idealmente 500-600. Attualmente sto addestrando nanoGPT usando libri dal 1800-1850 e specificamente da Londra. Ci sono alcune sfide, come assicurarsi che i libri trovati non siano stati aggiornati o abbiano interpretazioni moderne, ma siano libri intatti pubblicati nel periodo scelto.

Voglio addestrare un nuovo modello (v1) con un corpus molto più grande, magari 5-10 volte più grande di quello usato per v0.5. Il mio obiettivo è vedere se è possibile far emergere capacità di ragionamento solo dal Selective Temporal Training, sarà un compito più difficile e non sono nemmeno sicuro che sia possibile a causa delle limitazioni dei dati storici. Nelle prossime settimane cercherò di curare abbastanza dati per un corpus da 5-10GB. Credo che se riuscirò a ottenere dati puliti e di alta qualità e affittare una GPU, ci saranno progressi.

# Come Utilizzare Questo Progetto

Questo progetto si concentra principalmente sulla raccolta di dati storici, sulla loro preparazione per l’addestramento e sulla costruzione di un tokenizer. Non tratterò l’intero processo di addestramento LLM; per quello, fare riferimento a nanoGPT di Andrej Karpathy.

# Passo 1: Raccogliere e Preparare Testi Storici

Raccogli file .txt di libri, documenti, ecc. di pubblico dominio dal periodo scelto (es: Londra 1800-1850)

Puoi usare download_texts_improved.py per scaricare i libri, se necessario.

Pulisci i file di testo usando uno script o rimuovi manualmente header/footer di Project Gutenberg, annotazioni moderne o errori OCR.

prepare_dataset.py dovrebbe funzionare correttamente.

# Passo 2: Costruisci un Tokenizer Personalizzato

Esegui train_tokenizer.py o train_tokenizer_hf.py sui dati puliti.
Questo ti darà vocab.json e merges.txt

Questi file definiscono il vocabolario e le regole di unione per il tuo modello

# Passo 3: Addestra il Tuo Modello (nanoGPT)

Fare riferimento a [nanoGPT di Andrej Karpathy](https://github.com/karpathy/nanoGPT) per il processo di addestramento.

Puoi addestrare un LLM diverso se vuoi, ma io ho usato nanoGPT

# FAQ

## Cos'è il Selective Temporal Training?

Il Selective Temporal Training (STT) è una metodologia di machine learning in cui tutti i dati di addestramento sono specificamente curati per ricadere in un determinato periodo storico. Serve a modellare il linguaggio e le conoscenze di quell’epoca senza influenze da concetti moderni. Per esempio, il modello attuale (v0.5) è addestrato esclusivamente su dati dal 1800 al 1875, non è fine-tuned ma addestrato da zero, producendo output che riflette lo stile linguistico e il contesto storico di quel periodo.

## Perché non usare semplicemente il fine-tuning o LoRA?

Per questo progetto sto cercando di creare un modello linguistico privo di bias moderni. Se faccio il fine-tuning di qualcosa come GPT-2, è già pre-addestrato e quell’informazione non scompare. Se invece addestro da zero, il modello linguistico non fingerà di essere antico, lo sarà davvero. L'obiettivo per ora è creare qualcosa che possa ragionare esclusivamente usando conoscenze tratte da libri londinesi pubblicati tra il 1800 e il 1850.

## Che tipo di dati hai usato per l’addestramento?

Sto usando libri, documenti legali, giornali e altri scritti da Londra 1800–1850. La lista che ho linkato ne contiene circa 200, ma per il primo addestramento ho usato solo 50 file per circa 187 MB. Puoi consultare la lista dei documenti:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## Quanto è grande il modello Versione 0?

Questo modello è molto piccolo al momento, lo sto facendo solo per divertimento e seguo una regola rigorosa di non includere fonti moderne. Ha quasi 16 milioni di parametri ma inizierò a raccogliere altri testi antichi per cominciare un nuovo addestramento. Darò aggiornamenti man mano.

## Specifiche di Addestramento?

GPU: Geforce rtx 4060
CPU: i5-13400F
Ram: 16GB DDR5.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-02

---