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

##  Comportamento del Modello & Limitazioni

### **v0**  

I primi prompt mostrano il modello rispondere con linguaggio e comportamenti dell'800. 
Esempio: Prompt: "Chi è Henry?" e ha risposto "Conosco quell'uomo, non ho fatto un nero, la tempesta." 

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- Nessun riferimento a concetti moderni  
- Vocabolario per lo più accurato per l'epoca  
- Frasi per lo più incoerenti (previsto per dati di addestramento di ~187MB)

### **v0.5** 

Un miglioramento significativo rispetto a v0.  
- Stile di scrittura vittoriano, punteggiatura corretta, frasi per lo più grammaticali  
- Ancora alta frequenza di allucinazioni fattuali  
- Rumore da OCR (“Digitalizzato da Google”) ancora presente negli output

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

Primo modello a ricordare e collegare un vero evento storico con una reale figura del dataset.

Esempio: Prompt: "Era l'anno del Signore 1834" 

Output: "Era l'anno del Signore 1834 e le strade di Londra erano piene di proteste e petizioni. La causa, come molti hanno ricordato, non era legata al privato, ma avendo preso la stessa giornata nel giorno di Lord Palmerston, il pubblico riceverà una breve dichiarazione delle difficoltà sotto cui il giorno della legge ci ha raggiunto. È motivo di profondo rammarico che gli eventi attuali nella storia del mondo siano chiari, e di conseguenza saranno conosciuti. Non è vero che gli stessi uomini che per primi si stabilirono nel Vangelo a Gerusalemme dovessero avere una registrazione così estesa e interessante della prosperità e prosperità"

All'inizio ho pensato che una protesta potesse essere avvenuta casualmente nello stesso anno ma guarda qui: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### **v2mini-eval1**

Addestrato usando un campione di 15GB dal dataset di 90GB di v2.
Modello addestrato solo fino a 10K step.

C'era un problema di tokenizzazione che causava output di questo tipo:

Chi è Charles Dickens?



W ho is Charles D ic ens ? D oes that work more of h ise x cell ent st ir ring , in his pl ays , int he G reat C omp any 's f arm ? What I have y et to qu ote from J ack P ick ett ? D oy oun ot know th att hey were as pe cies of g all oping , ors aw ing oft heir bre asts , or what w ast ob ed one about the t im ew hen J acks on was looking ont hew ind ow ? What ist hes uccess of an English man , and which h isson has not be end is cover ing t ome , where by to acc omp lish such a we ight ? D idy ou ever m ake ap ass age int othe old road way , ort o an anch or - b ree ze att he foot of our boat , which you m ust le ave us ? The fact is , that whe ther the wind would rise up from the pl ain on S atur day night orn o ont ide , ort ill then orth , or other wise , wes hall be com pelled t od esc ribe af orm idable bar rier , with t hes ame e ffect s ast he p resent . In th iss itu ation , at le ast , itis not to omuch t os ay that we have le ft that room . I bel ieve there are three c op ies int he " F ive H undred - fold ," to bere fer red to , ast he first n umber of our read ers wh ow is ht
Corretto:

"Chi è Charles Dickens? Quell'opera suscita ancora le sue eccellenti emozioni, nelle sue opere teatrali, nella fattoria della Great Company? Cosa devo ancora citare da Jack Pickett? Non sapete che erano una specie di galoppata, o segare i loro petti, o cosa si doveva fare circa al tempo in cui Jackson guardava dalla finestra? Qual è il successo di un inglese, e cosa suo figlio non ha ancora scoperto per me, così da poter compiere un tale peso? Hai mai fatto un passaggio sulla vecchia strada, o verso una brezza d'ancora ai piedi della nostra barca, che dovete lasciarci? Il fatto è che, sia che il vento si alzi dalla pianura il sabato sera o a mezzogiorno, o fino al nord, o altro, saremo costretti a descrivere una barriera formidabile, con gli stessi effetti dell'attuale. In questa situazione, almeno, non è troppo dire che abbiamo lasciato quella stanza. Credo ci siano tre copie nei 'Cinquecento-volte', a cui fare riferimento, come il primo numero dei nostri lettori che desiderano t[o]..."

### **v2mini-eval2**

Addestrato utilizzando lo stesso campione da 15GB usato per l'addestramento di eval1.
Il modello è stato nuovamente addestrato solo per 10.000 passi.

PROMPT:Charles Darwin

Charles DarwinECCEMACY. Signore, — Il seguente caso mi interessa: — Sono stato a Londra per due settimane e sono stato molto colpito da un attacco di reumatismo. Il primo attacco di reumatismo è avvenuto una settimana prima che la vedessi, il secondo quando la vidi, e il terzo quando la vidi, e il terzo nello stesso periodo. Il secondo attacco di gotta, tuttavia, non fu accompagnato da sintomi febbrili, ma fu accompagnato da un aumento del flusso urinario, e da una più abbondante escrezione di urina. Il terzo attacco avvenne un'ora dopo che la vidi, e fu seguito dal ritorno di una parossistica di gotta, e da un ritorno più rapido della gotta. Il quarto attacco fu anch'esso accompagnato da febbre, ma non sempre da sintomi febbrili. Il terzo attacco di gotta fu due settimane dopo che era stato malato, e il quarto fu seguito da una parossistica di gotta. Il quarto attacco fu due settimane dopo che era stato colpito, e fu accompagnato da una sensazione

### **v2**

Addestrato usando un dataset di 90GB (112GB tokenizzati)
Addestrato fino a 182.000 passi 

![TimeCapsuleLLM Esempio di Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output1.png)

![TimeCapsuleLLM Esempio di Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output2.png)

##  Datasets

### **v2**

- 90GB(grezzi) di testi londinesi 1800-1875
- 136.344 documenti
- L'intero dataset tokenizzato è ora disponibile qui: https://huggingface.co/datasets/postgrammar/london-llm-1800

 ### Statistiche Bias 
  ![Bias dei pronomi](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/pronoun_bias.png)

  ![Bias geografico](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/geographic_bias.png)

  ![Bias temporale](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/temporal_bias.png)

Fare riferimento al [rapporto bias v2](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/v2_bias_report.json) per maggiori informazioni.



## Come utilizzare

Questo progetto si concentra principalmente sulla cura dei dati storici, la loro preparazione per l’addestramento e la costruzione di un tokenizer. Non coprirò l’intero processo di addestramento LLM; per quello fai riferimento a nanoGPT di Andrej Karpathy.

### Passo 1: Raccogli e Prepara Testi Storici 

- Raccogli file .txt di libri, documenti, ecc. di pubblico dominio dal periodo scelto (es. Londra 1800-1850) 
- Mantieni i testi entro la finestra temporale/geografica selezionata  
- Pulisci i file di testo usando uno script o rimuovi manualmente intestazioni/piedipagina di Project Gutenberg, annotazioni moderne o errori di OCR.

### Passo 2: Costruisci un Tokenizer Personalizzato

- Esegui train_tokenizer.py o train_tokenizer_hf.py sui dati puliti.
- Otterrai vocab.json e merges.txt
- Questi file definiscono il vocabolario e le regole di fusione per il tuo modello

### Passo 3: Allena il Tuo Modello 

- Fai riferimento a [nanoGPT di Andrej Karpathy](https://github.com/karpathy/nanoGPT) per il processo di training o alla documentazione dell’architettura scelta.

# FAQ

## Cos’è il Selective Temporal Training?

Il Selective Temporal Training (STT) è una metodologia di machine learning in cui tutti i dati di training sono curati specificamente per ricadere in un determinato periodo storico. Questo serve a modellare il linguaggio e la conoscenza di quell’epoca senza l’influenza di concetti moderni. Ad esempio, il modello attuale (v0.5) è addestrato esclusivamente su dati dal 1800 al 1875, non è fine-tuned ma addestrato da zero, producendo output che riflettono lo stile linguistico e il contesto storico di quel periodo.

## Perché non usare semplicemente fine-tuning o LoRA?

Per questo progetto voglio creare un modello linguistico privo di bias moderni. Se faccio fine-tuning di qualcosa come GPT-2, è già pre-addestrato e quell’informazione non scompare. Se invece alleno da zero, il modello linguistico non finge di essere “vecchio”, lo è davvero. L’obiettivo attuale è creare qualcosa che possa ragionare esclusivamente usando conoscenze tratte da libri londinesi pubblicati tra il 1800 e il 1875.

## Che tipo di dati hai usato per l’addestramento?

Sto usando libri, documenti legali, giornali e altri scritti provenienti dalla Londra del 1800–1875. La lista che ho linkato (per v0) ne contiene circa 200, ma per il primo addestramento ho usato solo 50 file per un totale di circa 187 MB. Puoi vedere l’elenco dei documenti:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

Dimensioni dei dataset:
- v0: ~187MB
- v0.5: ~435MB 
- v1: ~6.25GB 
- v2mini-eval1: 15GB (campione dai 90GB di v2)
- v2: 90GB

## Quanto sono grandi i modelli?

v0: 16M Parametri

v0.5 123M Parametri

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

## Ringraziamenti

Vorrei ringraziare il [Dr. Hamed Yaghoobian](https://hamedyaghoobian.com) per la supervisione accademica, la guida nell'impostazione della ricerca e nella valutazione, e per l'assistenza nell'addestramento del tokenizer e nella preparazione del dataset per il rilascio della v2. I suoi feedback e la sua esperienza sono stati fondamentali per migliorare la presentazione di questo lavoro.










































---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-03

---