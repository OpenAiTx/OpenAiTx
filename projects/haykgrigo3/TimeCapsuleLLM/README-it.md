
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

v1 costruito su [Phi 1.5 di Microsoft](https://huggingface.co/microsoft/phi-1_5)

[Link Hugging Face](https://huggingface.co/haykgrigorian/TimeCapsuleLLM)


##  Comportamento del Modello & Limitazioni

### **v0**  

I primi prompt mostrano il modello rispondere con linguaggio e comportamento dell'Ottocento. 
Esempio: Prompt: "Who art Henry?" e ha risposto "I know that man, I have did not a black, the storm." 

![Output di esempio TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- Nessun riferimento a concetti moderni  
- Vocabolario quasi sempre accurato per l’epoca  
- Frasi per lo più incoerenti (previsto per ~187MB di dati di addestramento)

### **v0.5** 

Un miglioramento significativo rispetto a v0.  
- Stile di scrittura vittoriano, punteggiatura corretta, frasi generalmente grammaticali  
- Ancora alto tasso di allucinazione fattuale  
- Rumore OCR (“Digitized by Google”) ancora presente negli output

![Output di esempio TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

Primo modello in grado di richiamare e collegare un vero evento storico con una persona reale presente nel dataset.

Esempio: Prompt: "It was the year of our Lord 1834" 

Output: "It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity" 

All’inizio pensavo che una protesta potesse essere avvenuta casualmente nello stesso anno, ma guarda qui: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### Perché è importante:

Questo è il primo esempio di uno dei miei modelli che collega un anno sia a un vero evento storico sia a una persona reale legata a quell’evento (Lord Palmerston). I modelli precedenti (v0 e v0.5) riuscivano a imitare lo stile di scrittura del XIX secolo ma inventavano sempre eventi, persone e fatti. Questo dimostra che il modello sta iniziando a ricordare elementi dal dataset.

## Piani Futuri

- Ci sono quasi 175.000 testi pubblicati a Londra dal 1800 al 1875 disponibili su Internet Archive
- Ho intenzione di espandere il corpus e pulirlo ulteriormente per migliorare le capacità di ragionamento
- Espansione verso diverse regioni e periodi storici per modelli più storici

## Come Utilizzare

Questo progetto si concentra principalmente sulla raccolta di dati storici, sulla loro preparazione per l'addestramento e sulla costruzione di un tokenizer. Non tratterò il processo completo di addestramento LLM, per quello consultare nanoGPT di Andrej Karpathy.

### Passo 1: Raccogliere e Preparare i Testi Storici

- Raccogli file .txt di libri di dominio pubblico, documenti, ecc. dal periodo scelto (ad esempio, Londra 1800-1850)
- Mantienili all'interno della finestra temporale/luogo scelta
- Pulisci i file di testo usando uno script o rimuovendo manualmente intestazioni/piedi di pagina da Project Gutenberg, annotazioni moderne o errori OCR.

### Passo 2: Costruire un Tokenizer Personalizzato

- Esegui train_tokenizer.py o train_tokenizer_hf.py sui dati puliti.
- Questo ti fornirà vocab.json e merges.txt
- Questi file definiscono il vocabolario e le regole di fusione per il tuo modello

### Passo 3: Addestra il Tuo Modello

- Consulta [nanoGPT di Andrej Karpathy](https://github.com/karpathy/nanoGPT) per il processo di addestramento o la documentazione dell'architettura scelta.

# FAQ

## Cos'è l'Addestramento Temporale Selettivo?

L'Addestramento Temporale Selettivo (STT) è una metodologia di machine learning in cui tutti i dati di addestramento sono accuratamente selezionati per ricadere in uno specifico periodo storico. Viene fatto per modellare il linguaggio e la conoscenza di quell'epoca senza influenze da concetti moderni. Ad esempio, il modello attuale che ho ora (v0.5) è addestrato esclusivamente su dati dal 1800 al 1875, non è stato ottimizzato ma addestrato da zero, risultando in output che riflettono lo stile linguistico e il contesto storico di quel periodo.

## Perché non usare semplicemente fine-tuning o LoRA?

Per questo progetto sto cercando di creare un modello linguistico non influenzato dai bias moderni. Se ottimizzo qualcosa come GPT-2, è già pre-addestrato e quell'informazione non sparirà. Se lo addestro da zero il modello linguistico non fingerà di essere antico, lo sarà realmente. L'obiettivo di questo progetto al momento è creare qualcosa che possa ragionare esclusivamente usando la conoscenza dei libri londinesi pubblicati tra il 1800 e il 1875.

## Che tipo di dati hai usato per l'addestramento?


Sto utilizzando libri, documenti legali, giornali e altri scritti della Londra tra il 1800 e il 1875. La lista che ho linkato (per v0) contiene circa 200 documenti, ma per il primo addestramento ho usato solo 50 file per circa ~187 MB. Puoi visualizzare un elenco dei documenti:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

Dimensioni dei dataset:
v0: ~187MB
v0.5: ~435MB 
v1: ~6.25GB 

## Quanto sono grandi i modelli?

V0: 16M Parametri

V0.5 123M Parametri

V1: 700M Parametri

# Specifiche di addestramento?

# V0/V0.5
GPU: Geforce rtx 4060
CPU: i5-13400F 
Ram: 16GB DDR5.

# V1
GPU: A100 noleggiata















---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-30

---