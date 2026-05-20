<div align="right">
  <details>
<summary>🌐 Lingua</summary>

[English](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=en) | [简体中文](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN) | [繁體中文](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-TW) | [日本語](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja) | [한국어](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko) | [हिन्दी](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=hi) | [ไทย](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=th) | [Français](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fr) | [Deutsch](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=de) | [Español](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=es) | [Italiano](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=it) | [Русский](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ru) | [Português](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pt) | [Nederlands](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=nl) | [Polski](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pl) | [العربية](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ar) | [فارسی](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fa) | [Türkçe](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=tr) | [Tiếng Việt](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=vi) | [Bahasa Indonesia](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=id) | [অসমীয়া](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=as)
</details>
</div>


# TimeCapsule LLM

*Un modello linguistico addestrato **da zero** esclusivamente su dati provenienti da determinati luoghi e periodi storici per ridurre il bias moderno ed emulare la voce, il vocabolario e la visione del mondo dell’epoca.*

Immagina se un modello AI non si limitasse a fingere di essere storico, ma lo fosse davvero.

Le versioni v0 e v0.5 sono state costruite su [nanoGPT di Andrej Karpathy](https://github.com/karpathy/nanoGPT). Gli script di training principali e l’architettura del modello sono opera sua.

La versione v1 è stata costruita su [Phi 1.5 di Microsoft](https://huggingface.co/microsoft/phi-1_5)

La versione v2 è stata costruita su llamaforcausallm

[Link Hugging Face](https://huggingface.co/collections/haykgrigorian/timecapsulellm-1800-1875-london)

## Stato della Ricerca
Questo progetto è stato avviato e sviluppato in modo indipendente.

Attualmente è condotto sotto supervisione accademica, con una collaborazione di ricerca affiliata presso il Muhlenberg College.

## Citazione

Se utilizzi questo dataset o modello in lavori accademici, cita:


```bibtex
@misc{london_llm_1800,
  author = {Grigorian, Hayk and Yaghoobian, Hamed},
  title = {Historic London English (1800–1875)},
  year = {2025},
  publisher = {Hugging Face},
  howpublished = {\url{https://huggingface.co/datasets/postgrammar/london-llm-1800}}
}
```

## Unisciti al Discord di Vintage LLM

Se sei interessato a **modelli linguistici storici**, **dataset specifici per epoca** o al futuro di progetti come **TimeCapsuleLLM**, **Violet-1.4B**, **Mr. Chatterbox**, entra nella community.

Usiamo il server per discutere idee, condividere progressi e connetterci con altri che lavorano in questo settore.

[Unisciti al Discord](https://discord.gg/JeWkk4z5)

##  Comportamento del modello & Limitazioni

### **v0**  

I primi prompt mostrano il modello rispondere con linguaggio e comportamento dell'800.
Esempio: Prompt: "Who art Henry?" e ha risposto "I know that man, I have did not a black, the storm."

![TimeCapsuleLLM Output di esempio](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- Nessun riferimento a concetti moderni  
- Vocabolario per lo più accurato per l'epoca  
- Frasi per lo più incoerenti (atteso per dati di addestramento di ~187MB)

### **v0.5-london** 

Un miglioramento significativo rispetto alla v0.
- Stile di scrittura vittoriano, punteggiatura corretta, frasi per lo più grammaticali  
- Tasso di allucinazione fattuale ancora elevato  
- Rumore OCR (“Digitized by Google”) ancora presente negli output

![TimeCapsuleLLM Output di esempio](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1-london**

Primo modello a richiamare e collegare un vero evento storico con una figura reale dal dataset.

Esempio: Prompt: "It was the year of our Lord 1834"

L’output: "It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity"

All’inizio ho supposto che una protesta potesse essere avvenuta casualmente nello stesso anno, ma guarda qui: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### **v2mini-eval1-london**

Addestrato utilizzando un campione da 15GB del dataset v2 da 90GB.
Modello addestrato solo per 10K step.

C'è stato un problema con la tokenizzazione che fa sì che l'output appaia così:

PROMPT:
Chi è Charles Dickens?


W ho is Charles D ic ens ? D oes that work more of h ise x cell ent st ir ring , in his pl ays , int he G reat C omp any 's f arm ? What I have y et to qu ote from J ack P ick ett ? D oy oun ot know th att hey were as pe cies of g all oping , ors aw ing oft heir bre asts , or what w ast ob ed one about the t im ew hen J acks on was looking ont hew ind ow ? What ist hes uccess of an English man , and which h isson has not be end is cover ing t ome , where by to acc omp lish such a we ight ? D idy ou ever m ake ap ass age int othe old road way , ort o an anch or - b ree ze att he foot of our boat , which you m ust le ave us ? The fact is , that whe ther the wind would rise up from the pl ain on S atur day night orn o ont ide , ort ill then orth , or other wise , wes hall be com pelled t od esc ribe af orm idable bar rier , with t hes ame e ffect s ast he p resent . In th iss itu ation , at le ast , itis not to omuch t os ay that we have le ft that room . I bel ieve there are three c op ies int he " F ive H undred - fold ," to bere fer red to , ast he first n umber of our read ers wh ow is ht
Corretto:

"Chi è Charles Dickens? Quell’opera suscita ancora di più il suo eccellente fermento, nelle sue commedie, nella fattoria della Grande Compagnia? Cosa devo ancora citare da Jack Pickett? Non sai che erano una specie di galoppata, o di segare i loro petti, o cosa si doveva fare nel periodo in cui Jackson guardava dalla finestra? Qual è il successo di un inglese, e cosa suo figlio non mi ha ancora rivelato, in modo da raggiungere un tale peso? Hai mai fatto un passaggio sulla vecchia strada, o a una brezza d’ancora ai piedi della nostra barca, che devi lasciarci? Il fatto è che, se il vento si alzerà dalla pianura sabato notte o a mezzogiorno, o fino al nord, o in altro modo, saremo costretti a descrivere una barriera formidabile, con gli stessi effetti dell’attuale. In questa situazione, almeno, non è esagerato dire che abbiamo lasciato quella stanza. Credo che ci siano tre copie nei ‘Cinque Centuplo’, a cui fare riferimento, come il primo numero dei nostri lettori che desiderano t[o]...”

### **v2mini-eval2-london**

Addestrato utilizzando lo stesso campione da 15GB usato per l’addestramento di eval1.
Il modello è stato nuovamente addestrato solo fino a 10.000 step.

PROMPT:Charles Darwin

Charles DarwinECCEMACY. Signore, — Il seguente caso mi interessa: — Sono stato a Londra per due settimane, e sono stato molto colpito da un attacco di reumatismo. Il primo attacco di reumatismo è stato una settimana prima che la vedessi, il secondo quando la vidi, e il terzo quando la vidi, e il terzo nello stesso periodo. Il secondo attacco di gotta, tuttavia, non era accompagnato da sintomi febbrili, ma era accompagnato da un aumento del flusso urinario e da una più abbondante escrezione di urina. Il terzo attacco è avvenuto un’ora dopo che l’ho vista, ed è stato seguito da un ritorno di un parossismo di gotta, e da un ritorno più rapido della gotta. Il quarto attacco è stato anch’esso accompagnato da febbre, ma non sempre accompagnato da sintomi febbrili. Il terzo attacco di gotta è avvenuto due settimane dopo che era stato male, e il quarto è stato seguito da un parossismo di gotta. Il quarto attacco è stato due settimane dopo che era stato colpito, ed è stato accompagnato da una sensazione

### **v2-london**

Addestrato utilizzando un dataset da 90GB (112GB tokenizzato)
Addestrato fino a 182.000 step 

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output1.png)

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output2.png)

### **E ora?**

- Sviluppo avviato su TimeCapsuleLLM v3
- Espansione della dimensione del dataset e della copertura geografica
- Estensione oltre Londra ad altre città

Il lavoro è svolto in collaborazione con ricercatori dello University College London (UCL) e si sta discutendo un ulteriore coinvolgimento istituzionale. 


##  Dataset

### **v2**

- 90GB (grezzi) di testi londinesi del 1800-1875
- 136.344 documenti
- Il dataset tokenizzato completo è ora disponibile qui: https://huggingface.co/datasets/postgrammar/london-llm-1800


### Statistiche sui Bias
![Bias dei pronomi](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/pronoun_bias.png)

![Bias geografico](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/geographic_bias.png)

![Bias temporale](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/temporal_bias.png)

Consulta il [report sui bias v2](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/v2_bias_report.json) per ulteriori informazioni.


-


## Come Utilizzare

Questo progetto si concentra principalmente sulla raccolta di dati storici, sulla loro preparazione per l'addestramento e sulla costruzione di un tokenizer. Non coprirò l'intero processo di addestramento LLM; per quello fai riferimento a nanoGPT di Andrej Karpathy.

### Step 1: Raccogli e Prepara i Testi Storici

- Raccogli file .txt di libri, documenti, ecc. di dominio pubblico dal periodo scelto (es. Londra 1800-1875)
- Mantieni i dati all'interno della finestra temporale/geografica scelta
- Pulisci i file di testo usando uno script o rimuovi manualmente intestazioni/piè di pagina da Project Gutenberg, annotazioni moderne o errori OCR.

### Step 2: Costruisci un Tokenizer Personalizzato

- Esegui train_tokenizer.py o train_tokenizer_hf.py sui dati puliti.
- Questo ti darà vocab.json e merges.txt
- Questi file definiscono il vocabolario e le regole di merge per il tuo modello

### Step 3: Addestra il Tuo Modello

- Consulta [nanoGPT di Andrej Karpathy](https://github.com/karpathy/nanoGPT) per il processo di addestramento o la documentazione dell’architettura scelta.

# FAQ

## Cos'è il Selective Temporal Training?

Selective Temporal Training (STT) è una metodologia di machine learning in cui tutti i dati di addestramento sono accuratamente selezionati per rientrare in un preciso periodo storico. È usato per modellare la lingua e la conoscenza di quell’epoca senza influenze da concetti moderni. Ad esempio, il modello attuale (v0.5) è addestrato esclusivamente su dati dal 1800 al 1875, non è stato fine-tuned ma addestrato da zero, producendo output che riflette lo stile linguistico e il contesto storico di quel periodo.

## Perché non usare semplicemente fine-tuning o LoRA?

Per questo progetto sto cercando di creare un modello linguistico non influenzato dai bias moderni. Se faccio il fine-tuning di qualcosa come GPT-2, è già pre-addestrato e quelle informazioni non spariranno. Se addestro da zero il modello linguistico non fingerà di essere antico, lo sarà e basta. L'obiettivo di questo progetto al momento è creare qualcosa che possa ragionare esclusivamente usando conoscenze tratte da libri londinesi pubblicati tra il 1800 e il 1875.

## Quali dati hai usato per l’addestramento?

Sto usando libri, documenti legali, giornali e altri scritti di Londra dal 1800 al 1875. La lista che ho linkato (per v0) contiene circa 200 documenti ma per il primo addestramento ho usato solo 50 file per circa ~187 MB. Puoi vedere una lista dei documenti:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

Dimensioni dei dataset:
- v0: ~187MB
- v0.5: ~435MB 
- v1: ~6.25GB 
- v2mini-eval1: 15GB (campione dei 90GB di v2)
- v2: 90GB

## Quanto sono grandi i modelli?

v0: 16M Parametri

v0.5: 123M Parametri

v1: 700M Parametri

v2mini-eval1: 300M Parametri

v2mini-eval2: 200M Parametri

v2: 1,2B Parametri

## Specifiche di addestramento?

### v0/v0.5
GPU: Geforce rtx 4060
CPU: i5-13400F 
Ram: 16GB DDR5.

### v1
GPU: A100 SXM noleggiata

### v2mini-eval1/eval2
GPU: A100 SXM noleggiata

### v2
GPU: H100 SXM noleggiata

## Lavori correlati

- **[talkie-1930-13b](https://talkie-lm.com/introducing-talkie)**
  - LLM da 13B parametri addestrato su 260B token di testo precedenti al 1930 con Q&A. Esiste anche una versione [base](https://huggingface.co/talkie-lm/talkie-1930-13b-base).
 
- **[Violet 1.4B](https://huggingface.co/zakarth/violet-1b4-chat)**
  - LLM da 1,4B parametri addestrato su testi dal 1800 al 1899 con Q&A. Esiste anche una versione da [160M](https://huggingface.co/zakarth/violet-160m-chat).
 
- **[Mr. Chatterbox](https://huggingface.co/tventurella/mr_chatterbox_model)**
  - LLM da 340M parametri addestrato su oltre 28.000 testi tra il 1837 e il 1899 con Q&A.

- **[Ranke-4B](https://github.com/DGoettlich/history-llms/blob/main/ranke-4b/prerelease_notes.md)** 
  - Una famiglia di LLM da 4B parametri basati sull'architettura Qwen3, addestrati da zero su 80B token di dati storici fino ai cutoff di conoscenza 1913,1929,1933,1939,1946.

- **[MondadGPT](https://huggingface.co/Pclanglais/MonadGPT)** 
  - MonadGPT è un finetuning di Mistral-Hermes 2 su 11.000 testi della prima età moderna in inglese, francese e latino, provenienti principalmente da EEBO e Gallica.

## Ringraziamenti

Vorrei ringraziare il [Dr. Hamed Yaghoobian](https://hamedyaghoobian.com) per la supervisione accademica, la guida nell'inquadramento e nella valutazione della ricerca, e per l'assistenza nell'addestramento del tokenizer e nella preparazione del dataset per il rilascio v2. I suoi feedback ed esperienza sono stati fondamentali per perfezionare la presentazione di questo lavoro.










































---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-20

---