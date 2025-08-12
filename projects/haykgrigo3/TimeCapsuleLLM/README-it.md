
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
Un LLM addestrato solo su dati provenienti da determinati periodi storici per ridurre il bias moderno.

Immagina se un modello di IA non solo fingesse di essere storico, ma lo fosse davvero.

Basato su [nanoGPT di Andrej Karpathy](https://github.com/karpathy/nanoGPT) Gli script principali di addestramento e l’architettura del modello sono opera sua.

# Obiettivi del Progetto

TimeCapsule LLM è un progetto sperimentale che verrà addestrato solo su testi scritti durante determinati periodi storici. L'obiettivo è simulare la visione del mondo e il linguaggio di specifiche epoche storiche.

# Perché il fine tuning non è sufficiente

Se si effettua solo il fine tuning di un modello preaddestrato, il tuo LLM conoscerà comunque concetti moderni. Ovviamente ottenere una totale assenza di bias moderno è difficile, ma voglio avvicinarmi il più possibile a questo. Per non avere bias moderno è necessario addestrare un modello da zero.

# Risultati attesi

Spero che, una volta terminato, questo modello non conosca concetti moderni e non sia in grado di ragionare oltre ciò su cui è stato addestrato. Non dovrebbe riconoscere vocaboli/conoscenze moderne e non dovrebbe "allucinare" informazioni contemporanee.

# Aggiornamenti sui progressi

## 9 luglio 2025

Ho fissato il mio periodo storico tra il 1800 e il 1850 e la regione: Londra

Ho raccolto una lista di testi, libri, documenti

Finora ne ho ottenuti 50 in formato txt e inizierò presto l’addestramento con NanoGPT

Aggiornerò questa sezione man mano che ci saranno progressi

## 13 luglio 2025

Ho addestrato NanoGPT con 187MB di dati testuali storici.

## 15 luglio 2025

Ho iniziato a scaricare testi per la seconda sessione di addestramento. Sto prendendo tutto dall’Internet Archive e ho ampliato il periodo a 1800-1875. Per ottenere una gamma diversificata di testi, si possono usare filtri per soggetto, luogo di pubblicazione, periodo storico e tematiche su Internet Archive.

![Filtri di ricerca](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 16 luglio 2025

Ho scaricato circa 500 file txt da Internet Archive e, dopo averli puliti (eliminando spazi bianchi, intestazioni Gutenberg, ecc.), ho circa 500MB di dati. È un dataset piccolo ma l’ultima volta ho addestrato con 187MB, quindi dovrei vedere almeno qualche differenza nel risultato dopo aver addestrato il secondo modello. Spero che questo modello riesca almeno a produrre frasi più coerenti e sensate. Non è garantito ovviamente, visto che il dataset è ancora minuscolo, ma è più di quanto usato in precedenza.

Dovrebbe essere fattibile sull’hardware che ho, il che è positivo perché spero di vedere qualche miglioramento prima di passare a un dataset più grande, che mi costringerebbe a noleggiare una GPU. Non preoccupatevi, ho comunque intenzione di noleggiare una GPU presto, ma prima voglio assicurarmi che il mio dataset sia il più curato e pulito possibile. Uno dei problemi principali è la pulizia: molti di questi file txt hanno dentro del testo incomprensibile. Gli script che uso per pulire funzionano, ma non sono efficaci al 100%.

Oggi addestrerò questo dataset e dovrebbe richiedere circa 4-5 ore. Una volta finito e testato, darò aggiornamenti. Grazie ancora a tutti quelli che stanno seguendo il mio progetto, alcune persone mi hanno persino inviato link a risorse OCR quindi grazie! Spero che più persone provino questo esperimento e ci lavorino con i propri dataset.

## 12 Agosto 2025

La Versione 1 è completa, questa versione utilizza Phi 1.5 (700M parametri) ed è stata addestrata su un dataset di quasi 7000 testi. Il principale miglioramento di questo modello è la capacità di riferirsi talvolta a nomi reali ed eventi storici. Le versioni 0 e 0.5 non riuscivano a farlo, quando chiedevo a quei modelli qualcosa come "Nell'anno 1821" il risultato erano solo allucinazioni, cose che non sono mai accadute. Un esempio con la Versione 1:

Il mio prompt: Era l’anno del nostro Signore 1834,

L’output: "Era l’anno del nostro Signore 1834 e le strade di Londra erano piene di proteste e petizioni. La causa, come molti raccontarono, non era legata a questioni private, ma era stata adottata lo stesso giorno dal Lord Palmerston; il pubblico riceverà una breve dichiarazione delle difficoltà sotto le quali il giorno della legge ci ha raggiunto. È un motivo di profondo rammarico che gli eventi attuali nella storia del mondo siano chiari, e di conseguenza saranno conosciuti. Non è vero che proprio gli uomini che si stabilirono per primi nel Vangelo a Gerusalemme abbiano una documentazione così ampia e interessante della prosperità e prosperità"

All’inizio pensavo fosse una coincidenza, ma guarda qui: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)


### Aggiornamento Addestramento

Ho iniziato l’addestramento su un corpus da 435MB (108 M token), sta andando abbastanza bene. La train loss è scesa da 10.9 a 4.9 nelle prime 2800 iterazioni. Penso che ci vorranno circa 8 o 9 ore per completare. Pubblicherò un altro aggiornamento una volta terminato.

## 17 Luglio 2025

L’addestramento è terminato per il secondo modello, la mia 4060 ha impiegato circa 8 ore e 40 minuti (3.900 iteraz./ora) per 33.000 iterazioni (5 epoche). La train loss finale era 3.73. Gli output erano sorprendentemente buoni; ora genera frasi coerenti in stile XIX secolo.

## 28 Luglio 2025

Ho caricato v0.5 su Hugging Face, [Dai un’occhiata](https://huggingface.co/haykgrigorian/TimeCapsuleLLM) se vuoi. Ora puoi scaricare il mio repo ed eseguirlo localmente. Purtroppo nanoGPT non funziona nativamente con HuggingFace, quindi dovrai scaricare ed eseguire il modello in locale.

Inoltre inizierò a selezionare dati per la prossima sessione di addestramento, credo che serviranno forse 5-10 volte più dati per ottenere capacità di ragionamento.

## 2 Agosto 2025

Presto inizierò a lavorare sulla Versione 1. Dovrò passare dall’architettura nanoGPT a una più moderna. Ho in mente diverse architetture LLM open-source, tra cui: OpenLLaMA v3, Phi-2 e Qwen 1.5B. E per supportare il passaggio a V1, dovrò curare con molta attenzione un dataset molto più grande e diversificato. Mi serviranno almeno 5GB di dati di addestramento puliti.

# Comportamento & Limitazioni del Modello V0

I primi prompt mostrano il modello che risponde con linguaggio e comportamento dell’Ottocento. Ad esempio, l’ho interrogato con "Who art Henry?" e ha risposto "I know that man, I have did not a black, the storm." e sì, quella frase non ha senso ma il LLM sta riconoscendo che sto chiedendo di una persona.

![TimeLockLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

Non c’è menzione di concetti moderni, gli output contengono soprattutto parole e frasi dell’Ottocento.

C’è ancora molto lavoro da fare, addestrare su 187MB non ti darà un modello che produce testo con ragionamento complesso. 

Al momento produce frasi che mancano di una struttura completa e in generale non hanno senso, ma questo è normale per la dimensione dell'addestramento.

# Comportamento e Limitazioni del Modello V0.5

Questo è un bel miglioramento rispetto al modello precedente. Lo stile di scrittura e il vocabolario sono vittoriani e quasi ogni frase è grammaticalmente corretta con la punteggiatura appropriata. E ancora una volta questo è stato addestrato da zero, quindi si attiene ai temi dell'Ottocento.

![Esempio di Output TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

Ci sono molte allucinazioni fattuali. Molti (come il 100%) dei dettagli (date, eventi, personaggi storici) sono inventati. Inoltre le frasi non sono davvero collegate tra loro, a volte forse 2 frasi si riferiscono tra loro ma oltre a questo non lo fanno. Un altro problema è che a volte compare un footer errante “Digitized by Google”, quindi la prossima volta che addestro devo davvero assicurarmi che i testi siano ben puliti. Nel complesso sono molto soddisfatto dei risultati, non è ancora vicino a un LLM ma sicuramente è un generatore di frasi.

Sto imparando molto e inizierò a capire cosa devo migliorare nelle prossime settimane. Caricherò presto dei file!

# Comportamento e Limitazioni del Modello V1

Caricherò presto alcuni output di esempio e farò anche confronti tra i 3 modelli con lo stesso prompt. Caricherò anche la V1 su huggingface come ho fatto con la mia ultima versione, puoi trovare il mio account huggingface qui: https://huggingface.co/haykgrigorian/TimeCapsuleLLM

# Piani Futuri

(Completato) Inizierò a lavorare sulla versione 0.5, invece di addestrare usando 50 libri, addestrerò usando idealmente 500-600. Attualmente sto addestrando nanoGPT usando libri dal 1800-1850 e specificamente da Londra. Ci sono delle sfide come assicurarsi che i libri trovati non siano aggiornati o abbiano interpretazioni moderne ma siano libri intatti pubblicati nel periodo scelto.

Voglio addestrare un nuovo modello (v1) con un corpus molto più grande, magari 5-10 volte più grande di quello usato per v0.5. Il mio obiettivo è vedere se posso far emergere capacità di ragionamento dal Solo Addestramento Temporale Selettivo, sarà un compito più difficile e non sono nemmeno sicuro che sia possibile dato che ci sono limitazioni nei dati storici. Nelle prossime settimane cercherò di curare abbastanza dati per un corpus da 5-10GB. Credo che se riuscirò a ottenere dati puliti di alta qualità e affittare una GPU, ci saranno progressi.

# Come Usare Questo Progetto

Questo progetto si concentra principalmente sulla cura dei dati storici, sulla loro preparazione per l'addestramento e sulla creazione di un tokenizer. Non coprirò l'intero processo di addestramento LLM, per quello fai riferimento a nanoGPT di Andrej Karpathy.

# Passo 1: Raccogliere e Preparare Testi Storici

Raccogli file .txt di libri di pubblico dominio, documenti, ecc. dal periodo storico scelto (ad esempio, Londra 1800-1850)

Puoi usare download_texts_improved.py per scaricare i libri se ne hai bisogno.

Pulisci i file di testo usando uno script o rimuovi manualmente header/footer da Project Gutenberg, annotazioni moderne o errori OCR.

prepare_dataset.py dovrebbe funzionare bene.

# Passo 2: Costruire un Tokenizer Personalizzato

Esegui train_tokenizer.py o train_tokenizer_hf.py sui dati puliti.
Questo ti darà vocab.json e merges.txt

Questi file definiscono il vocabolario e le regole di fusione per il tuo modello

# Passo 3: Allena il Tuo Modello (nanoGPT)

Consulta [nanoGPT di Andrej Karpathy](https://github.com/karpathy/nanoGPT) per il processo di addestramento.

Puoi addestrare un diverso LLM se vuoi, ma io ho usato nanoGPT

# FAQ

## Cos'è l'Addestramento Temporale Selettivo?

L'Addestramento Temporale Selettivo (STT) è una metodologia di machine learning in cui tutti i dati di addestramento sono specificamente selezionati per appartenere a un periodo storico definito. Questo viene fatto per modellare la lingua e la conoscenza di quell'epoca senza influenze da concetti moderni. Ad esempio, il modello attuale che ho (v0.5) è addestrato esclusivamente su dati dal 1800 al 1875, non è stato ottimizzato ma addestrato da zero, producendo output che riflettono lo stile linguistico e il contesto storico di quel periodo.

## Perché non usare semplicemente il fine-tuning o LoRA?

Per questo progetto sto cercando di creare un modello linguistico privo di bias moderni. Se faccio il fine-tuning su qualcosa come GPT-2, è già pre-addestrato e quell'informazione non scomparirà. Se invece addestro da zero, il modello linguistico non fingerà di essere antico, lo sarà davvero. L'obiettivo attuale di questo progetto è creare qualcosa che possa ragionare esclusivamente usando la conoscenza dei libri londinesi pubblicati tra il 1800 e il 1850.

## Che tipo di dati hai usato per l'addestramento?

Sto usando libri, documenti legali, giornali e altri scritti provenienti da Londra tra il 1800 e il 1850. La lista che ho linkato ne contiene circa 200, ma per il primo addestramento ho usato solo 50 file per circa ~187 MB. Puoi visualizzare la lista dei documenti:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## Quanto sono grandi i modelli?

V0: 16M Parametri

V0.5: 123M Parametri

V1: 700M Parametri

# Specifiche di Addestramento?

#V0/V0.5
GPU: Geforce rtx 4060
CPU: i5-13400F
Ram: 16GB DDR5.

#V1
GPU: A100 rented









---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-12

---