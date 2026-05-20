<div align="right">
  <details>
<summary>🌐 Taal</summary>

[English](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=en) | [简体中文](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN) | [繁體中文](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-TW) | [日本語](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja) | [한국어](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko) | [हिन्दी](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=hi) | [ไทย](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=th) | [Français](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fr) | [Deutsch](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=de) | [Español](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=es) | [Italiano](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=it) | [Русский](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ru) | [Português](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pt) | [Nederlands](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=nl) | [Polski](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pl) | [العربية](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ar) | [فارسی](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fa) | [Türkçe](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=tr) | [Tiếng Việt](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=vi) | [Bahasa Indonesia](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=id) | [অসমীয়া](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=as)

</details>
</div>


# TimeCapsule LLM

*Een taalmodel dat **vanaf nul** is getraind uitsluitend op data uit bepaalde plaatsen en tijdsperioden om moderne bias te verminderen en de stem, woordenschat en wereldbeeld van het tijdperk te emuleren.*

Stel je voor dat een AI-model niet alleen deed alsof het historisch was, maar het werkelijk was.

v0 en v0.5 gebouwd op [nanoGPT van Andrej Karpathy](https://github.com/karpathy/nanoGPT) Kern trainingsscripts en modelarchitectuur zijn zijn werk.

v1 gebouwd op [Phi 1.5 van Microsoft](https://huggingface.co/microsoft/phi-1_5)

v2 gebouwd op llamaforcausallm

[Hugging Face Link](https://huggingface.co/collections/haykgrigorian/timecapsulellm-1800-1875-london)

## Onderzoeksstatus
Dit project is onafhankelijk geïnitieerd en ontwikkeld.

Het wordt momenteel uitgevoerd onder academisch toezicht, met een geassocieerde onderzoekssamenwerking aan Muhlenberg College.

## Citatie

Als je deze dataset of dit model gebruikt in academisch werk, citeer dan:

```bibtex
@misc{london_llm_1800,
  author = {Grigorian, Hayk and Yaghoobian, Hamed},
  title = {Historic London English (1800–1875)},
  year = {2025},
  publisher = {Hugging Face},
  howpublished = {\url{https://huggingface.co/datasets/postgrammar/london-llm-1800}}
}
```

## Word lid van de Vintage LLM Discord

Als je geïnteresseerd bent in **historische taalmodellen**, **tijdspecifieke datasets** of de toekomst van projecten zoals **TimeCapsuleLLM**, **Violet-1.4B**, **Mr. Chatterbox**, kom dan bij de community.

We gebruiken de server om ideeën te bespreken, voortgang te delen en in contact te komen met anderen die in dit vakgebied bouwen.

[Word lid van de Discord](https://discord.gg/JeWkk4z5)

##  Modelgedrag & Beperkingen

### **v0**  

Vroege prompts laten het model reageren met taalgebruik en gedrag uit de 19e eeuw. 
Voorbeeld: Prompt: "Who art Henry?" en het antwoordde: "I know that man, I have did not a black, the storm."

![TimeCapsuleLLM Voorbeeldoutput](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- Geen vermelding van moderne concepten  
- Meestal tijdperk-accurate woordenschat  
- Zinnen zijn grotendeels onsamenhangend (verwacht bij ~187MB trainingsdata)

### **v0.5-london** 

Een significante verbetering ten opzichte van v0.  
- Victoriaanse schrijfstijl, juiste interpunctie, meestal grammaticale zinnen  
- Nog steeds hoge mate van feitelijke hallucinatie  
- OCR-ruis (“Digitized by Google”) nog aanwezig in de uitvoer

![TimeCapsuleLLM Voorbeeldoutput](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1-london**

Eerste model dat een echt historisch feit met een daadwerkelijk figuur uit de dataset kan verbinden.

Voorbeeld: Prompt: "It was the year of our Lord 1834" 

De uitvoer: "It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity" 

Eerst dacht ik dat er toevallig in dat jaar een protest was, maar kijk eens hiernaar: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### **v2mini-eval1-london**

Getraind met een 15GB sample uit v2's 90GB dataset.
Model slechts getraind tot 10K stappen.

Er was een probleem met tokenisatie waardoor de output er zo uitziet:

PROMPT:
Wie is Charles Dickens?


W ho is Charles D ic ens ? D oes that work more of h ise x cell ent st ir ring , in his pl ays , int he G reat C omp any 's f arm ? What I have y et to qu ote from J ack P ick ett ? D oy oun ot know th att hey were as pe cies of g all oping , ors aw ing oft heir bre asts , or what w ast ob ed one about the t im ew hen J acks on was looking ont hew ind ow ? What ist hes uccess of an English man , and which h isson has not be end is cover ing t ome , where by to acc omp lish such a we ight ? D idy ou ever m ake ap ass age int othe old road way , ort o an anch or - b ree ze att he foot of our boat , which you m ust le ave us ? The fact is , that whe ther the wind would rise up from the pl ain on S atur day night orn o ont ide , ort ill then orth , or other wise , wes hall be com pelled t od esc ribe af orm idable bar rier , with t hes ame e ffect s ast he p resent . In th iss itu ation , at le ast , itis not to omuch t os ay that we have le ft that room . I bel ieve there are three c op ies int he " F ive H undred - fold ," to bere fer red to , ast he first n umber of our read ers wh ow is ht

Gecorrigeerd:

"Wie is Charles Dickens? Komt dat werk meer voort uit zijn uitstekende en aangrijpende stukken, in zijn toneelstukken, op de boerderij van de Great Company? Wat moet ik nog citeren van Jack Pickett? Weet je niet dat ze een soort galopperen waren, of zagen aan hun borst, of wat er moest gebeuren rond de tijd dat Jackson uit het raam keek? Wat is het succes van een Engelsman, en wat heeft zijn zoon nog niet aan mij ontdekt, waarmee zo'n gewicht kan worden bereikt? Heb je ooit een doorgang gemaakt naar de oude weg, of naar een ankerbries aan de voet van onze boot, die je ons moet verlaten? Het feit is, dat of de wind nu zou opsteken vanaf de vlakte op zaterdagavond of rond het middaguur, of naar het noorden, of anderszins, we genoodzaakt zullen zijn een formidabele barrière te beschrijven, met dezelfde effecten als nu. In deze situatie, althans, is het niet te veel gezegd dat we die kamer hebben verlaten. Ik geloof dat er drie exemplaren zijn in de 'Five Hundred-fold', waarnaar verwezen moet worden, als het eerste aantal van onze lezers dat wil t[o]..."

### **v2mini-eval2-london**

Getraind met dezelfde 15GB sample als gebruikt bij de training van eval1.
Model is opnieuw getraind tot slechts 10K stappen.

PROMPT:Charles Darwin

Charles DarwinECCEMACY. Meneer, — Het volgende geval is interessant voor mij: — Ik was twee weken in Londen, en werd sterk getroffen door een aanval van reuma. De eerste aanval van reuma was een week voordat ik u zag, de tweede toen ik u zag, en de derde toen ik u zag, en de derde in dezelfde tijd. De tweede aanval van jicht werd echter niet vergezeld door koortsverschijnselen, maar wel door een verhoogde urinestroom en een overvloedigere urineafscheiding. De derde aanval was een uur nadat ik u zag, en werd gevolgd door een terugkeer van een jichtaanval, en een snellere terugkeer van de jicht. De vierde aanval ging ook gepaard met koorts, maar werd niet altijd vergezeld door koortsverschijnselen. De derde aanval van jicht was twee weken nadat u ziek was geworden, en de vierde werd gevolgd door een jichtaanval. De vierde aanval was twee weken nadat u werd getroffen, en ging gepaard met een gevoel

### **v2-london**

Getraind met een 90GB (112GB getokeniseerd) dataset
Getraind tot 182K stappen 

![TimeCapsuleLLM Voorbeeldoutput](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output1.png)

![TimeCapsuleLLM Voorbeeldoutput](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output2.png)

### **Wat is het volgende?**

- Ontwikkeling van TimeCapsuleLLM v3 is gestart
- Opschalen van datasetgrootte en geografische dekking
- Uitbreiden naar andere steden buiten Londen

Het werk wordt uitgevoerd in samenwerking met onderzoekers van University College London (UCL) en aanvullende institutionele betrokkenheid wordt besproken. 


##  Datasets

### **v2**

- 90GB(ruw) aan Londense teksten uit 1800-1875
- 136.344 documenten
- De volledige getokeniseerde dataset is nu hier beschikbaar: https://huggingface.co/datasets/postgrammar/london-llm-1800

### Bias Statistieken 
![Voornaamwoord bias](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/pronoun_bias.png)

![Geografische bias](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/geographic_bias.png)

![Tijdgebonden bias](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/temporal_bias.png)

Raadpleeg het [v2 bias rapport](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/v2_bias_report.json) voor meer informatie.


- 


## Hoe te Gebruiken

Dit project richt zich voornamelijk op het verzamelen van historische data, het voorbereiden voor training en het bouwen van een tokenizer. Ik behandel niet het volledige LLM trainingsproces, daarvoor verwijs ik naar nanoGPT van Andrej Karpathy.

### Stap 1: Verzamel en Bereid Historische Teksten Voor

- Verzamel .txt-bestanden van boeken in het publieke domein, documenten, etc. uit jouw gekozen tijdsperiode (bijv. Londen 1800-1875)
- Houd ze binnen jouw gekozen tijd-/plaatsvenster
- Reinig de tekstbestanden met een script of verwijder handmatig headers/footers van Project Gutenberg, moderne annotaties of zaken zoals OCR-fouten.

### Stap 2: Bouw een Eigen Tokenizer

- Voer train_tokenizer.py of train_tokenizer_hf.py uit op de opgeschoonde data.
- Dit levert vocab.json en merges.txt op.
- Deze bestanden definiëren vocabulaire en merge-regels voor jouw model

### Stap 3: Train Je Model

- Raadpleeg [nanoGPT van Andrej Karpathy](https://github.com/karpathy/nanoGPT) voor het trainingsproces of de documentatie van jouw gekozen architectuur.

# FAQ

## Wat is Selective Temporal Training?

Selective Temporal Training (STT) is een machine learning-methodologie waarbij alle trainingsdata specifiek wordt samengesteld om binnen een bepaalde historische tijdsperiode te vallen. Dit gebeurt om de taal en kennis van die periode te modelleren zonder invloed van moderne concepten. Bijvoorbeeld, het huidige model dat ik heb (v0.5) is uitsluitend getraind op data uit 1800-1875, het is niet fijn-afgesteld maar vanaf nul getraind, wat resulteert in output die de linguïstische stijl en historische context van die tijd weerspiegelt.

## Waarom niet gewoon fine-tuning of LoRA gebruiken?
Voor dit project probeer ik een taalmodel te creëren dat niet beïnvloed is door moderne vooroordelen. Als ik iets als GPT-2 fine-tune, is het al voorgetraind en die informatie verdwijnt niet. Als ik het model vanaf nul train, doet het zich niet voor als oud, het ís gewoon oud. Het doel van dit project is nu om iets te maken dat uitsluitend kan redeneren met kennis uit Londense boeken gepubliceerd tussen 1800 en 1875.

## Welke data heb je gebruikt voor de training?

Ik gebruik boeken, juridische documenten, kranten en andere geschriften uit Londen van 1800–1875. De lijst die ik gelinkt heb (voor v0) bevat er zo'n 200, maar voor de eerste training heb ik slechts 50 bestanden gebruikt, ongeveer ~187 MB. Je kunt een lijst van de documenten bekijken:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

Datasetgroottes:
- v0: ~187MB
- v0.5: ~435MB
- v1: ~6,25GB
- v2mini-eval1: 15GB (sample van v2's 90GB)
- v2: 90GB

## Hoe groot zijn de modellen?

v0: 16M Parameters

v0.5 123M Parameters

v1: 700M Parameters

v2mini-eval1: 300M Parameters

v2mini-eval2: 200M Parameters

v2: 1,2B Parameters

## Trainingsspecificaties?

### v0/v0.5
GPU: Geforce rtx 4060
CPU: i5-13400F
Ram: 16GB DDR5.

### v1
GPU: A100 SXM gehuurd

### v2mini-eval1/eval2

GPU: A100 SXM gehuurd

### v2
GPU: H100 SXM gehuurd

## Gerelateerd Werk

- **[talkie-1930-13b](https://talkie-lm.com/introducing-talkie)**
  -  13B parameter LLM getraind op 260B tokens tekst van vóór 1930 met Q&A. Er is ook een [basis](https://huggingface.co/talkie-lm/talkie-1930-13b-base) versie.
 
- **[Violet 1.4B](https://huggingface.co/zakarth/violet-1b4-chat)**
  -  1.4B parameter LLM getraind op teksten uit 1800-1899 met Q&A. Er is ook een [160M](https://huggingface.co/zakarth/violet-160m-chat) versie.
 
- **[Mr. Chatterbox](https://huggingface.co/tventurella/mr_chatterbox_model)**
  -  340M parameter LLM getraind op meer dan 28.000 teksten tussen 1837-1899 met Q&A.

- **[Ranke-4B](https://github.com/DGoettlich/history-llms/blob/main/ranke-4b/prerelease_notes.md)** 
  - een familie van 4B parameter LLM's gebaseerd op de Qwen3 architectuur, vanaf nul getraind op 80B tokens aan historische data tot kennis-cutoffs 1913, 1929, 1933, 1939, 1946.

- **[MondadGPT](https://huggingface.co/Pclanglais/MonadGPT)** 
  - MonadGPT is een finetune van Mistral-Hermes 2 op 11.000 vroegmoderne teksten in het Engels, Frans en Latijn, voornamelijk afkomstig van EEBO en Gallica.

## Dankbetuigingen

Ik wil [Dr. Hamed Yaghoobian](https://hamedyaghoobian.com) bedanken voor academische supervisie, begeleiding bij het opzetten en evalueren van het onderzoek, en voor hulp bij tokenizer training en datasetvoorbereiding voor de v2-release. Zijn feedback en ervaring waren van groot belang bij het verfijnen van de presentatie van dit werk.










































---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-20

---