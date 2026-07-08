<div align="right">
  <details>
<summary>🌐 Lingua</summary>

[English](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=en) | [简体中文](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN) | [繁體中文](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-TW) | [日本語](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja) | [한국어](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko) | [हिन्दी](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=hi) | [ไทย](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=th) | [Français](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fr) | [Deutsch](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=de) | [Español](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=es) | [Italiano](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=it) | [Русский](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ru) | [Português](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pt) | [Nederlands](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=nl) | [Polski](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pl) | [العربية](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ar) | [فارسی](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fa) | [Türkçe](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=tr) | [Tiếng Việt](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=vi) | [Bahasa Indonesia](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=id) | [অসমীয়া](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=as)
</details>
</div>


# TimeCapsule LLM

*Un modello linguistico addestrato **da zero** esclusivamente su dati provenienti da determinati luoghi e periodi storici per ridurre i bias moderni ed emulare la voce, il vocabolario e la visione del mondo dell'epoca.*

Immagina se un modello di IA non si limitasse a fingere di essere storico, ma lo fosse davvero.

v0 e v0.5 basati su [nanoGPT di Andrej Karpathy](https://github.com/karpathy/nanoGPT) Gli script principali di training e l'architettura del modello sono opera sua.

v1 basato su [Phi 1.5 di Microsoft](https://huggingface.co/microsoft/phi-1_5)

v2 basato su llamaforcausallm

[Link Hugging Face](https://huggingface.co/collections/haykgrigorian/timecapsulellm-1800-1875-london)

## Stato della Ricerca
Questo progetto è stato avviato e sviluppato in modo indipendente.

Attualmente viene condotto sotto supervisione accademica, con una collaborazione di ricerca affiliata presso Muhlenberg College & Georgia State University.

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

Se sei interessato a **modelli linguistici storici**, **dataset specifici per periodi storici** o al futuro di progetti come **TimeCapsuleLLM**, **Violet-1.4B**, **Mr. Chatterbox**, entra a far parte della community.

Utilizziamo il server per discutere idee, condividere progressi e connetterci con altri che lavorano in questo settore.

[Unisciti al Discord](https://discord.gg/JeWkk4z5)

## Sponsor

<div align="center">
  <a href="https://doloffer.com">
    <img src="https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/logo.png" width="500">
  </a>
</div>

Grazie a DolOffer per il supporto a questo progetto!

DolOffer è una piattaforma focalizzata su raccomandazioni di prodotti digitali e condivisione di sconti, che aiuta gli utenti a scoprire rapidamente strumenti, servizi e offerte a tempo limitato. La piattaforma offre una varietà di servizi in abbonamento popolari, tra cui YouTube Premium, Claude, ChatGPT Plus, Spotify e Apple Music, con prezzi fino al 30% del prezzo ufficiale o anche meno.

Registrati ora tramite questo link esclusivo [doloffer](https://doloffer.com/en/) ed inserisci il codice promozionale AI8888 al momento della ricarica per ottenere uno sconto aggiuntivo del 10%.

##  Comportamento del Modello & Limitazioni

### **v0**  

I primi prompt mostrano il modello che risponde con linguaggio e comportamento dell'Ottocento. 
Esempio: Prompt: "Chi è Henry?" e ha risposto "Conosco quell'uomo, non ho fatto un nero, la tempesta."

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- Nessun riferimento a concetti moderni  
- Vocabolario per lo più accurato per l'epoca  
- Le frasi sono per lo più incoerenti (previsto per ~187MB di dati di addestramento)

### **v0.5-london** 

Un notevole miglioramento rispetto alla v0.  
- Stile di scrittura vittoriano, punteggiatura corretta, frasi per lo più grammaticali  
- Tasso di allucinazione fattuale ancora elevato  
- Rumore OCR (“Digitalizzato da Google”) ancora presente nei risultati

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1-london**

Primo modello a ricordare e collegare un vero evento storico con una figura reale dal dataset.

Esempio: Prompt: "Era l’anno del Signore 1834"

L’output: "Era l’anno del Signore 1834 e le strade di Londra erano piene di proteste e petizioni. La causa, come molti hanno raccontato, non era vincolata nel modo privato, ma avendo preso lo stesso giorno nel giorno di Lord Palmerston, il pubblico riceverà una breve dichiarazione delle difficoltà sotto cui il giorno della legge ci è giunto. È motivo di profondo rammarico che gli eventi attuali nella storia del mondo siano chiari e, di conseguenza, saranno conosciuti. Non è vero che gli stessi uomini che per primi si stabilirono nel Vangelo a Gerusalemme dovrebbero avere un registro così esteso e così interessante della prosperità e prosperità"

Inizialmente ho pensato che una protesta potesse essere avvenuta casualmente nello stesso anno, ma guarda qui: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### **v2mini-eval1-london**

Addestrato utilizzando un campione di 15GB dal dataset di 90GB della v2.
Modello addestrato solo per 10K step.

C’era un problema con la tokenizzazione che causa un output simile a questo:

PROMPT:
Chi è Charles Dickens?


W ho is Charles D ic ens ? D oes that work more of h ise x cell ent st ir ring , in his pl ays , int he G reat C omp any 's f arm ? What I have y et to qu ote from J ack P ick ett ? D oy oun ot know th att hey were as pe cies of g all oping , ors aw ing oft heir bre asts , or what w ast ob ed one about the t im ew hen J acks on was looking ont hew ind ow ? What ist hes uccess of an English man , and which h isson has not be end is cover ing t ome , where by to acc omp lish such a we ight ? D idy ou ever m ake ap ass age int othe old road way , ort o an anch or - b ree ze att he foot of our boat , which you m ust le ave us ? The fact is , that whe ther the wind would rise up from the pl ain on S atur day night orn o ont ide , ort ill then orth , or other wise , wes hall be com pelled t od esc ribe af orm idable bar rier , with t hes ame e ffect s ast he p resent . In th iss itu ation , at le ast , itis not to omuch t os ay that we have le ft that room . I bel ieve there are three c op ies int he " F ive H undred - fold ," to bere fer red to , ast he first n umber of our read ers wh ow is ht
Corretto:

"Chi è Charles Dickens? Quella opera è forse un altro dei suoi eccellenti scritti emozionanti, nelle sue commedie, nella fattoria della Grande Compagnia? Cosa devo ancora citare da Jack Pickett? Non sapete che erano una specie di galoppata, o di segatura dei loro petti, o cosa si doveva fare nel periodo in cui Jackson guardava dalla finestra? Qual è il successo di un inglese, e che suo figlio non ha ancora scoperto per me, con cui realizzare un tale peso? Avete mai fatto un passaggio nella vecchia strada, o ad una brezza d'ancora ai piedi della nostra barca, che dovete lasciarci? Il fatto è che, sia che il vento si alzi dalla pianura il sabato sera o a mezzogiorno, o verso nord, o altro, saremo costretti a descrivere una barriera formidabile, con gli stessi effetti dell’attuale. In questa situazione, almeno, non è esagerato dire che abbiamo lasciato quella stanza. Credo che ci siano tre copie nei 'Cinque Cento Volte', a cui far riferimento, come il primo numero dei nostri lettori che desiderano [c]...”

### **v2mini-eval2-london**

Addestrato utilizzando lo stesso campione da 15GB utilizzato per l'addestramento di eval1.
Il modello è stato nuovamente addestrato solo fino a 10K step.

PROMPT: Charles Darwin

Charles DarwinECCEMACY. Signore, — Il seguente caso mi interessa: — Sono stato a Londra per due settimane, e sono stato molto colpito da un attacco di reumatismo. Il primo attacco di reumatismo è stato una settimana prima che la vedessi, il secondo quando l’ho vista, e il terzo quando l’ho vista, e il terzo nello stesso periodo. Il secondo attacco di gotta, tuttavia, non è stato accompagnato da sintomi febbrili, ma da un aumento del flusso urinario, e da una più abbondante escrezione di urina. Il terzo attacco è stato un’ora dopo che l’ho vista, e fu seguito da un ritorno di un parossismo di gotta, e da un ritorno più rapido della gotta. Il quarto attacco fu anch’esso accompagnato da febbre, ma non sempre con sintomi febbrili. Il terzo attacco di gotta fu due settimane dopo che lei era stato male, e il quarto fu seguito da un parossismo di gotta. Il quarto attacco fu due settimane dopo che fu attaccato, e fu accompagnato da una sensazione

### **v2-london**

Addestrato usando un dataset da 90GB (112GB tokenizzato)
Addestrato fino a 182K step

![TimeCapsuleLLM Output di esempio](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output1.png)

![TimeCapsuleLLM Output di esempio](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output2.png)

### **E ora?**

- È iniziato lo sviluppo di TimeCapsuleLLM v3
- Si stanno ampliando le dimensioni del dataset e la copertura geografica
- L’espansione va oltre Londra verso altre città

Il lavoro è svolto in collaborazione con ricercatori del Muhlenberg College & della Georgia State University.


##  Dati

### **v2**

- 90GB (grezzi) di testi londinesi dal 1800 al 1875
- 136.344 documenti
- Il dataset completamente tokenizzato è ora disponibile qui: https://huggingface.co/datasets/postgrammar/london-llm-1800


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

## Lavori Correlati

- **[talkie-1930-13b](https://talkie-lm.com/introducing-talkie)**
  - Modello LLM da 13B parametri addestrato su 260B token di testi precedenti al 1930 con Q&A. Esiste anche una versione [base](https://huggingface.co/talkie-lm/talkie-1930-13b-base).
 
- **[Violet 1.4B](https://huggingface.co/zakarth/violet-1b4-chat)**
  - Modello LLM da 1.4B parametri addestrato su testi del periodo 1800-1899 con Q&A. Esiste anche una versione [160M](https://huggingface.co/zakarth/violet-160m-chat).
 
- **[Mr. Chatterbox](https://huggingface.co/tventurella/mr_chatterbox_model)**
  - Modello LLM da 340M parametri addestrato su oltre 28.000 testi tra il 1837-1899 con Q&A. 

- **[Ranke-4B](https://github.com/DGoettlich/history-llms/blob/main/ranke-4b/prerelease_notes.md)** 
  - Una famiglia di LLM da 4B parametri basata sull’architettura Qwen3, addestrata da zero su 80B token di dati storici fino ai knowledge-cutoff 1913,1929,1933,1939,1946.
 
- **[TypewriterLM](https://huggingface.co/typewriter-ai/typewriter-1913-7B-base)**
  - Modello linguistico storico (LM) da 7.24B parametri preaddestrato esclusivamente su testi inglesi antecedenti al 1913. Creato da ricercatori delle Università di Waterloo, Adelaide, Oxford e University College London. [Link al paper](https://arxiv.org/abs/2606.02991)

- **[MondadGPT](https://huggingface.co/Pclanglais/MonadGPT)** 
  - MonadGPT è un fine-tune di Mistral-Hermes 2 su 11.000 testi di epoca moderna in inglese, francese e latino, provenienti principalmente da EEBO e Gallica.

## Ringraziamenti

Vorrei ringraziare [Dr. Hamed Yaghoobian](https://hamedyaghoobian.com) per la supervisione accademica, l’orientamento nell’impostazione e valutazione della ricerca, e per l’assistenza nell’addestramento del tokenizer e nella preparazione del dataset per la release v2. Il suo feedback ed esperienza sono stati fondamentali nel perfezionare la presentazione di questo lavoro.










































---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-08

---