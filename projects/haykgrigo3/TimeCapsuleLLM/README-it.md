<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-TW">繁體中文</a> 
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=as">हिन्दी</a> 
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=th">ไทย</a> 
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=es">Español</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ar">العربية</a>
        | <a href="#" title="Coming soon">فارسی (coming soon)</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=vi">Tiếng Việt</a>
        | <a href="#" title="Coming soon">Bahasa Indonesia (coming soon)</a>

      </div>
    </div>
  </details>
</div>


# TimeCapsule LLM

*Un modello linguistico addestrato **da zero** esclusivamente su dati provenienti da determinati luoghi e periodi storici per ridurre il bias moderno ed emulare la voce, il vocabolario e la visione del mondo dell'epoca.*

Immagina se un modello AI non fingesse soltanto di essere storico, ma lo fosse davvero.

v0 e v0.5 costruiti su [nanoGPT di Andrej Karpathy](https://github.com/karpathy/nanoGPT) Gli script principali di addestramento e l'architettura del modello sono opera sua. 

v1 basato su [Phi 1.5 di Microsoft](https://huggingface.co/microsoft/phi-1_5)

v2 basato su llamaforcausallm

[Link Hugging Face](https://huggingface.co/haykgrigorian/TimeCapsuleLLM)

##  Comportamento del modello e limitazioni

### **v0**  

I primi prompt mostrano che il modello risponde con linguaggio e comportamento degli anni 1800.
Esempio: Prompt: "Who art Henry?" e ha risposto "I know that man, I have did not a black, the storm."

![Esempio output TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- Nessun riferimento a concetti moderni  
- Vocabolario prevalentemente accurato per l’epoca  
- Frasi per lo più incoerenti (previsto per dati di addestramento di ~187MB)

### **v0.5** 

Un miglioramento significativo rispetto alla v0.  
- Stile vittoriano, punteggiatura corretta, frasi per lo più grammaticali  
- Tasso di allucinazione fattuale ancora elevato  
- Rumore OCR (“Digitized by Google”) ancora presente negli output

![Esempio output TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

Primo modello in grado di richiamare e collegare un reale evento storico a una figura effettiva del dataset.

Esempio: Prompt: "It was the year of our Lord 1834" 

Output: "It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity" 

Inizialmente pensavo che una protesta potesse essere avvenuta per coincidenza nello stesso anno, ma guarda qui: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### **v2mini-eval1**


Addestrato utilizzando un campione di 15GB dal dataset da 90GB della versione v2.
Modello addestrato solo fino a 10K step.

Si è verificato un problema con la tokenizzazione che fa apparire l'output in questo modo:

PROMPT:
Chi è Charles Dickens?


W ho is Charles D ic ens ? D oes that work more of h ise x cell ent st ir ring , in his pl ays , int he G reat C omp any 's f arm ? What I have y et to qu ote from J ack P ick ett ? D oy oun ot know th att hey were as pe cies of g all oping , ors aw ing oft heir bre asts , or what w ast ob ed one about the t im ew hen J acks on was looking ont hew ind ow ? What ist hes uccess of an English man , and which h isson has not be end is cover ing t ome , where by to acc omp lish such a we ight ? D idy ou ever m ake ap ass age int othe old road way , ort o an anch or - b ree ze att he foot of our boat , which you m ust le ave us ? The fact is , that whe ther the wind would rise up from the pl ain on S atur day night orn o ont ide , ort ill then orth , or other wise , wes hall be com pelled t od esc ribe af orm idable bar rier , with t hes ame e ffect s ast he p resent . In th iss itu ation , at le ast , itis not to omuch t os ay that we have le ft that room . I bel ieve there are three c op ies int he " F ive H undred - fold ," to bere fer red to , ast he first n umber of our read ers wh ow is ht
Corretto:

"Chi è Charles Dickens? È forse quel lavoro uno dei suoi eccellenti e appassionanti, nelle sue opere teatrali, nella fattoria della Grande Compagnia? Cosa devo ancora citare da Jack Pickett? Non sai che erano una sorta di galoppata, o un segare dei loro petti, o cosa si doveva fare al tempo in cui Jackson stava guardando dalla finestra? Qual è il successo di un inglese, e che suo figlio non mi ha ancora rivelato, per poter compiere un tale peso? Hai mai fatto un passaggio sulla vecchia strada, o verso una brezza d’ancora ai piedi della nostra barca, che devi lasciarci? Il fatto è che, sia che il vento si alzi dalla pianura il sabato notte o a mezzogiorno, o fino al nord, o in altro modo, saremo costretti a descrivere una barriera formidabile, con gli stessi effetti dell’attuale. In questa situazione, almeno, non è troppo dire che abbiamo lasciato quella stanza. Credo che ci siano tre copie nel 'Cinque Cento volte,' a cui fare riferimento, come il primo numero dei nostri lettori che desiderano t[o]..."

### **v2mini-eval2**

Addestrato utilizzando lo stesso campione da 15GB usato per l’addestramento di eval1.
Il modello è stato nuovamente addestrato solo fino a 10.000 step.

PROMPT: Charles Darwin

Charles DarwinECCEMACY. Signore, — Il seguente caso mi interessa: — Sono stato a Londra quindici giorni, e sono stato molto colpito da un attacco di reumatismo. Il primo attacco di reumatismo è stato una settimana prima che la vedessi, il secondo quando l’ho vista, e il terzo quando l’ho vista, e il terzo nello stesso periodo. Il secondo attacco di gotta, però, non era accompagnato da sintomi febbrili, ma da un aumento del flusso urinario, e da una minzione più abbondante. Il terzo attacco è stato un’ora dopo che l’ho vista, ed è stato seguito da un ritorno di un parossismo di gotta, e da un ritorno più rapido della gotta. Il quarto attacco è stato anch’esso accompagnato da febbre, ma non sempre da sintomi febbrili. Il terzo attacco di gotta è stato quindici giorni dopo che lei era stato male, e il quarto fu seguito da un parossismo di gotta. Il quarto attacco fu quindici giorni dopo che lei fu colpito, ed era accompagnato da una sensazione

##  Datasets

### **v2**

- 90GB di testi londinesi dal 1800 al 1875
- 136.344 documenti
- L’intero set da 90GB non è ancora disponibile poiché non è stato tokenizzato, ma puoi trovare un campione da 15GB qui: https://huggingface.co/datasets/haykgrigorian/TimeCapsuleLLM-London-1800-1875-v2-15GB

 ### Statistiche Bias
  ![Bias nei pronomi](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/pronoun_bias.png)

  ![Bias geografico](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/geographic_bias.png)

  ![Bias temporale](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/temporal_bias.png)

Consultare il [rapporto bias v2](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/v2_bias_report.json) per ulteriori informazioni.


## Come utilizzare

Questo progetto si concentra principalmente sulla raccolta di dati storici, la loro preparazione per l’addestramento e la costruzione di un tokenizer. Non tratterò l’intero processo di training di un LLM; per questo fare riferimento a nanoGPT di Andrej Karpathy.

### Passo 1: Raccogli e prepara testi storici

- Raccogli file .txt di libri, documenti, ecc. di pubblico dominio dal periodo storico scelto (ad esempio, Londra 1800-1850)


- Mantienili all'interno della finestra di tempo/luogo scelta  
- Pulisci i file di testo usando uno script o rimuovi manualmente intestazioni/piedipagina di Project Gutenberg, annotazioni moderne o errori OCR.

### Passo 2: Costruisci un Tokenizer Personalizzato

- Esegui train_tokenizer.py o train_tokenizer_hf.py sui dati puliti.
- Questo ti fornirà vocab.json e merges.txt
- Questi file definiscono il vocabolario e le regole di unione per il tuo modello

### Passo 3: Allena il Tuo Modello

- Fai riferimento a [nanoGPT di Andrej Karpathy](https://github.com/karpathy/nanoGPT) per il processo di training o alla documentazione dell’architettura scelta.

# FAQ

## Cos’è l’Addestramento Temporale Selettivo?

L’Addestramento Temporale Selettivo (STS) è una metodologia di machine learning in cui tutti i dati di addestramento sono accuratamente selezionati per ricadere in uno specifico periodo storico. Viene fatto per modellare il linguaggio e la conoscenza di quell’epoca senza l’influenza di concetti moderni. Ad esempio, il modello attuale che ho ora (v0.5) è addestrato esclusivamente su dati dal 1800 al 1875, non è stato fine-tuned ma addestrato da zero, producendo output che riflettono lo stile linguistico e il contesto storico di quel periodo.

## Perché non usare semplicemente fine-tuning o LoRA?

Per questo progetto voglio creare un modello linguistico libero dai bias moderni. Se faccio fine-tuning su qualcosa come GPT-2, è già pre-addestrato e quell’informazione non andrà via. Se alleno da zero il modello linguistico non fingerà di essere antico, lo sarà davvero. L’obiettivo attuale è creare qualcosa che possa ragionare esclusivamente usando conoscenza tratta da libri londinesi pubblicati tra il 1800 e il 1875.

## Che tipo di dati hai usato per l’addestramento?

Sto usando libri, documenti legali, giornali e altri scritti della Londra del 1800–1875. La lista che ho linkato (per la v0) contiene circa 200 file ma per il primo addestramento ne ho usati solo 50 per un totale di circa 187 MB. Puoi vedere la lista dei documenti qui:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

Dimensioni dei dataset:
- v0: ~187MB
- v0.5: ~435MB 
- v1: ~6.25GB 
- v2mini-eval1: 15GB

## Quanto sono grandi i modelli?

v0: 16M Parametri

v0.5 123M Parametri

v1: 700M Parameters

v2mini-eval1: 300M Parameters

# Training Specs ? 

# v0/v0.5
GPU: Geforce rtx 4060
CPU: i5-13400F 
Ram: 16GB DDR5.

# v1
GPU: A100 SXM rented

# v2mini-eval1

GPU: A100 SXM rented






























---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-13

---