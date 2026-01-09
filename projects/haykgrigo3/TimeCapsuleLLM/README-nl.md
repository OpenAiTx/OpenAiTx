<div align="right">
  <details>
    <summary >🌐 Taal</summary>
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
        | <a href="#" title="Binnenkort beschikbaar">فارسی (binnenkort beschikbaar)</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=vi">Tiếng Việt</a>
        | <a href="#" title="Binnenkort beschikbaar">Bahasa Indonesia (binnenkort beschikbaar)</a>

      </div>
    </div>
  </details>
</div>


# TimeCapsule LLM

*Een taalmodel getraind **vanaf nul** uitsluitend op gegevens uit bepaalde plaatsen en tijdperken om moderne bias te verminderen en de stem, woordenschat en wereldbeeld van het tijdperk te emuleren.*

Stel je voor dat een AI-model niet alleen deed alsof het historisch was, maar het daadwerkelijk was.

v0 en v0.5 gebouwd op [nanoGPT van Andrej Karpathy](https://github.com/karpathy/nanoGPT) Core trainingsscripts en modelarchitectuur zijn zijn werk. 

v1 gebouwd op [Phi 1.5 door Microsoft](https://huggingface.co/microsoft/phi-1_5)

[Hugging Face-link](https://huggingface.co/haykgrigorian/TimeCapsuleLLM)

##  Modelgedrag & Beperkingen

### **v0**  

Vroege prompts tonen het model dat reageert met taalgebruik en gedrag uit de 19e eeuw. 
Voorbeeld: Prompt: "Who art Henry?" en het antwoordde "I know that man, I have did not a black, the storm." 

![TimeLockLLM Voorbeeldoutput](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- Geen vermelding van moderne concepten  
- Meestal tijdperk-correct vocabulaire  
- Zinnen zijn grotendeels onsamenhangend (verwacht bij ~187MB trainingsdata)

### **v0.5** 

Een aanzienlijke verbetering ten opzichte van v0.  
- Victoriaanse schrijfstijl, correcte interpunctie, meestal grammaticale zinnen  
- Nog steeds hoge mate van feitelijke hallucinatie  
- OCR-ruis (“Digitized by Google”) nog steeds aanwezig in de output

![TimeLockLLM Voorbeeldoutput](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

Eerste model dat een echt historisch evenement koppelt aan een werkelijk figuur uit de dataset.

Voorbeeld: Prompt: "It was the year of our Lord 1834" 

De output: "It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity" 

In eerste instantie dacht ik dat er toevallig een protest in datzelfde jaar had plaatsgevonden, maar kijk eens naar dit: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### **v2mini-eval1**

Getraind met een 15GB-sample uit v2's 90GB-dataset.

Model getraind tot slechts 10K stappen.

Er was een probleem met tokenisatie waardoor de output er zo uitziet:

PROMPT:
Wie is Charles Dickens?


W ho is Charles D ic ens ? D oes that work more of h ise x cell ent st ir ring , in his pl ays , int he G reat C omp any 's f arm ? What I have y et to qu ote from J ack P ick ett ? D oy oun ot know th att hey were as pe cies of g all oping , ors aw ing oft heir bre asts , or what w ast ob ed one about the t im ew hen J acks on was looking ont hew ind ow ? What ist hes uccess of an English man , and which h isson has not be end is cover ing t ome , where by to acc omp lish such a we ight ? D idy ou ever m ake ap ass age int othe old road way , ort o an anch or - b ree ze att he foot of our boat , which you m ust le ave us ? The fact is , that whe ther the wind would rise up from the pl ain on S atur day night orn o ont ide , ort ill then orth , or other wise , wes hall be com pelled t od esc ribe af orm idable bar rier , with t hes ame e ffect s ast he p resent . In th iss itu ation , at le ast , itis not to omuch t os ay that we have le ft that room . I bel ieve there are three c op ies int he " F ive H undred - fold ," to bere fer red to , ast he first n umber of our read ers wh ow is ht

Gecorrigeerd:

"Wie is Charles Dickens? Werkt dat meer van zijn uitstekende meeslepende, in zijn toneelstukken, op de boerderij van het Grote Bedrijf? Wat moet ik nog citeren van Jack Pickett? Weet je niet dat ze een soort galopperen waren, of het zagen in hun borsten, of wat er moest gebeuren rond de tijd dat Jackson uit het raam keek? Wat is het succes van een Engelsman, en wat zijn zoon mij nog niet heeft onthuld, waarmee zo'n gewicht bereikt kan worden? Heb je ooit een doorgang gemaakt naar de oude rijweg, of naar een ankerbries aan de voet van onze boot, die je ons moet laten? Feit is, dat of de wind nu op zaterdagavond of middag opsteekt vanaf de vlakte, of naar het noorden, of anderszins, we gedwongen zullen zijn om een formidabele barrière te beschrijven, met dezelfde effecten als nu. In deze situatie, tenminste, is het niet overdreven om te zeggen dat we die kamer hebben verlaten. Ik geloof dat er drie exemplaren zijn in de 'Vijfhonderdvoud', te raadplegen, als het eerste nummer voor onze lezers die w[illen]..."

### **v2mini-eval2**

Getraind met dezelfde 15GB sample als gebruikt voor het trainen van eval1.
Het model is opnieuw getraind tot slechts 10K stappen.

PROMPT:Charles Darwin

Charles DarwinECCEMACY. Meneer, — Het volgende geval is interessant voor mij: — Ik was twee weken in Londen, en werd sterk getroffen door een aanval van reuma. De eerste aanval van reuma was een week voordat ik u zag, en de tweede toen ik u zag, en de derde toen ik u zag, en de derde in dezelfde periode. De tweede aanval van jicht, echter, ging niet gepaard met koortsverschijnselen, maar wel met een verhoogde urinestroom en een meer overvloedige urinelozing. De derde aanval was een uur nadat ik u zag, en werd gevolgd door een terugkeer van een jichtaanval, en een snellere terugkeer van de jicht. De vierde aanval ging ook gepaard met koorts, maar niet altijd met koortsverschijnselen. De derde aanval van jicht was twee weken nadat u ziek was geweest, en de vierde werd gevolgd door een jichtaanval. De vierde aanval was twee weken nadat u werd aangevallen, en ging gepaard met een gevoel

##  Datasets

### **v2**

- 90GB aan Londense teksten uit 1800-1875
- 136.344 documenten
- De volledige 90GB is nog niet beschikbaar omdat deze nog niet getokenized is, maar je vindt een 15GB sample hier: https://huggingface.co/datasets/haykgrigorian/TimeCapsuleLLM-London-1800-1875-v2-15GB

 ### Bias Stats 
  ![Voornaamwoord bias](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/pronoun_bias.png)

  ![Geografische bias](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/geographic_bias.png)

  ![Tijdsbias](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/temporal_bias.png)

Raadpleeg het [v2 bias rapport](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/v2_bias_report.json) voor meer informatie.


## Hoe te gebruiken

Dit project richt zich vooral op het verzamelen van historische data, het voorbereiden voor training en het bouwen van een tokenizer. Ik ga het volledige LLM-trainingsproces niet behandelen, raad daarvoor nanoGPT van Andrej Karpathy aan.

### Stap 1: Verzamel en bereid historische teksten voor 

- Verzamel .txt-bestanden van boeken, documenten, enz. uit het publieke domein van jouw gekozen periode (bijv. Londen 1800-1850) 

- Houd ze binnen het door jou gekozen tijds-/plaatsvenster  
- Maak de tekstbestanden schoon door een script te gebruiken of handmatig headers/footers van Project Gutenberg, moderne annotaties of OCR-fouten te verwijderen.

### Stap 2: Bouw een Aangepaste Tokenizer

- Voer train_tokenizer.py of train_tokenizer_hf.py uit op de opgeschoonde data.
- Dit levert vocab.json en merges.txt op
- Deze bestanden definiëren vocabulaire en samenvoegregels voor je model

### Stap 3: Train Je Model 

- Raadpleeg [nanoGPT van Andrej Karpathy](https://github.com/karpathy/nanoGPT) voor het trainingsproces of de documentatie van je gekozen architectuur.

# FAQ

## Wat is Selective Temporal Training?

Selective Temporal Training (STT) is een machine learning-methodologie waarbij alle trainingsdata specifiek worden samengesteld om binnen een bepaalde historische periode te vallen. Dit wordt gedaan om de taal en kennis van dat tijdperk te modelleren zonder invloed van moderne concepten. Bijvoorbeeld, het huidige model dat ik nu heb (v0.5) is getraind op data uitsluitend uit 1800-1875, het is niet fijn-afgesteld maar vanaf nul getraind, wat resulteert in output die de taalkundige stijl en historische context van die periode weerspiegelt.

## Waarom niet gewoon fine-tunen of LoRA gebruiken?

Voor dit project probeer ik een taalmodel te maken dat niet vertroebeld is door moderne bias. Als ik iets als GPT-2 fine-tune, is dat al vooraf getraind en die informatie verdwijnt niet. Als ik vanaf nul train zal het taalmodel niet doen alsof het oud is, het zal het gewoon zijn. Het doel voor dit project is nu om iets te maken dat uitsluitend kan redeneren met kennis uit Londense boeken gepubliceerd tussen 1800 en 1875.

## Wat voor data gebruikte je voor training?

Ik gebruik boeken, juridische documenten, kranten en andere geschriften uit Londen van 1800–1875. De lijst die ik heb gelinkt (voor v0) bevat ongeveer 200, maar voor de eerste training gebruikte ik gewoon 50 bestanden van ongeveer ~187 MB. Je kunt een lijst van de documenten bekijken:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

Datasetgroottes:
- v0: ~187MB
- v0.5: ~435MB 
- v1: ~6,25GB 
- v2mini-eval1: 15GB

## Hoe groot zijn de modellen?

v0: 16M Parameters

v0.5 123M Parameters

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-09

---