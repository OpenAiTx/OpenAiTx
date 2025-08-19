
<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN">简体中文</a>
        | <a href="#" title="In arrivo">繁體中文 (in arrivo)</a> |
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko">한국어</a>
        | <a href="#" title="In arrivo">हिन्दी (in arrivo)</a> |
        | <a href="#" title="In arrivo">ไทย (in arrivo)</a> |
        | <a href="#" title="In arrivo">Français (in arrivo)</a>
        | <a href="#" title="In arrivo">Deutsch (in arrivo)</a>
        | <a href="#" title="In arrivo">Español (in arrivo)</a>
        | <a href="#" title="In arrivo">Italiano (in arrivo)</a>
        | <a href="#" title="In arrivo">Русский (in arrivo)</a>
        | <a href="#" title="In arrivo">Português (in arrivo)</a>
        | <a href="#" title="In arrivo">Nederlands (in arrivo)</a>
        | <a href="#" title="In arrivo">Polski (in arrivo)</a>
        | <a href="#" title="In arrivo">العربية (in arrivo)</a>
        | <a href="#" title="In arrivo">فارسی (in arrivo)</a>
        | <a href="#" title="In arrivo">Türkçe (in arrivo)</a>
        | <a href="#" title="In arrivo">Tiếng Việt (in arrivo)</a>
        | <a href="#" title="In arrivo">Bahasa Indonesia (in arrivo)</a>

      </div>
    </div>
  </details>
</div>

# TimeCapsule LLM

*Un modello linguistico addestrato **da zero** esclusivamente su dati provenienti da specifici luoghi e periodi storici per ridurre il bias moderno e imitare la voce, il vocabolario e la visione del mondo dell’epoca.*

Immagina se un modello AI non si limitasse a fingere di essere storico, ma lo fosse davvero.

v0 e v0.5 sono stati costruiti su [nanoGPT di Andrej Karpathy](https://github.com/karpathy/nanoGPT) Le principali script di addestramento e l’architettura del modello sono opera sua. 

v1 basato su [Phi 1.5 di Microsoft](https://huggingface.co/microsoft/phi-1_5)

##  Comportamento del Modello & Limitazioni

### **v0**  

I primi prompt mostrano il modello rispondere con linguaggio e comportamento tipici dell'Ottocento.  
Esempio: Prompt: "Chi è Henry?" e ha risposto "Conosco quell'uomo, non ho fatto nero, la tempesta." 

![Esempio Output TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- Nessun accenno a concetti moderni  
- Vocabolario perlopiù accurato per l'epoca  
- Frasi perlopiù incoerenti (previsto per ~187MB di dati di addestramento)

### **v0.5** 

Un miglioramento significativo rispetto a v0.  
- Stile di scrittura vittoriano, punteggiatura corretta, frasi perlopiù grammaticali  
- Tasso ancora elevato di allucinazione fattuale  
- Rumore OCR (“Digitalizzato da Google”) ancora presente negli output

![Esempio Output TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

Primo modello a richiamare e collegare un vero evento storico con una figura reale del dataset.

Esempio: Prompt: "Era l'anno del Signore 1834" 

Output: "Era l'anno del Signore 1834 e le strade di Londra erano piene di protesta e petizione. La causa, come molti ricordavano, non era vincolata al modo privato, ma era stata presa nello stesso giorno nel giorno di Lord Palmerston, il pubblico riceverà una breve dichiarazione delle difficoltà sotto le quali il giorno della legge ci ha raggiunto. È motivo di profondo rammarico che gli eventi attuali nella storia del mondo siano chiari, e di conseguenza saranno conosciuti. Non è vero che gli stessi uomini che per primi si stabilirono nel Vangelo a Gerusalemme dovrebbero avere un registro così esteso e interessante della prosperità e prosperità" 

All'inizio pensavo che una protesta potesse essere avvenuta casualmente nello stesso anno, ma guarda qui: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### Perché è importante:

Questo è il primo esempio di uno dei miei modelli che collega un anno sia a un vero evento storico sia a una persona reale legata a quell'evento (Lord Palmerston). I modelli precedenti (v0 e v0.5) potevano imitare gli stili di scrittura del XIX secolo ma avrebbero sempre inventato eventi, persone e fatti. Questo mostra che il modello sta iniziando a ricordare elementi dal dataset

## Piani Futuri

- Ci sono quasi 175.000 testi pubblicati a Londra dal 1800 al 1875 su Internet Archive 
- Ho intenzione di espandere il corpus e pulirlo ulteriormente per migliorare le capacità di ragionamento
- Espansione verso diverse regioni e periodi storici per modelli più storici


## Come Usare

Questo progetto si concentra principalmente sulla raccolta di dati storici, sulla loro preparazione per l’addestramento e sulla costruzione di un tokenizer. Non coprirò il processo completo di addestramento LLM, per quello si rimanda a nanoGPT di Andrej Karpathy.

### Passo 1: Raccogliere e Preparare Testi Storici

- Raccogli file .txt di libri, documenti ecc. di dominio pubblico dal periodo scelto (es. Londra 1800-1850)
- Mantienili all’interno della finestra temporale/luogo selezionata  
- Pulisci i file di testo con uno script o manualmente rimuovendo intestazioni/piedipagina da Project Gutenberg, annotazioni moderne o errori OCR.

### Passo 2: Costruire un Tokenizer Personalizzato

- Esegui train_tokenizer.py o train_tokenizer_hf.py sui dati puliti.
- Questo ti darà vocab.json e merges.txt
- Questi file definiscono vocabolario e regole di unione per il tuo modello

### Passo 3: Addestra il Tuo Modello

- Consulta [nanoGPT di Andrej Karpathy](https://github.com/karpathy/nanoGPT) per il processo di addestramento o la documentazione dell’architettura scelta.

# FAQ

## Cos’è l’Addestramento Temporale Selettivo?

L’Addestramento Temporale Selettivo (STT) è una metodologia di machine learning dove tutti i dati di addestramento sono selezionati specificamente per ricadere in un determinato periodo storico. Viene fatto per modellare la lingua e la conoscenza di quell’epoca senza influenze da concetti moderni. Ad esempio, il modello attuale che ho ora (v0.5) è addestrato esclusivamente su dati dal 1800 al 1875, non è ottimizzato ma addestrato da zero producendo output che riflette lo stile linguistico e il contesto storico di quell’epoca.

## Perché non usare semplicemente il fine-tuning o LoRA?

Per questo progetto sto cercando di creare un modello linguistico non influenzato da bias moderni. Se faccio il fine-tuning di qualcosa come GPT-2, è già pre-addestrato e quell’informazione non andrà via. Se addestro da zero il modello linguistico non fingerà di essere antico, lo sarà e basta. L’obiettivo per questo progetto ora è creare qualcosa che possa ragionare esclusivamente usando la conoscenza dei libri londinesi pubblicati tra il 1800 e il 1875.

## Che tipo di dati hai usato per l’addestramento?

Sto usando libri, documenti legali, giornali e altri scritti di Londra dal 1800 al 1875. La lista che ho collegato (per v0) ne ha circa 200, ma per il primo addestramento ho usato solo 50 file per circa ~187 MB. Puoi vedere una lista dei documenti:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt


Dimensioni dei dataset:
v0: ~187MB
v0.5: ~435MB 
v1: ~6,25GB 

## Quanto sono grandi i modelli?

V0: 16M Parametri

V0.5: 123M Parametri

V1: 700M Parametri

# Specifiche di addestramento?

# V0/V0.5
GPU: Geforce rtx 4060
CPU: i5-13400F 
Ram: 16GB DDR5.

# V1
GPU: A100 noleggiata














---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-19

---