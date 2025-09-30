
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=en">Engels</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN">简体中文</a>
        | <a href="#" title="Coming soon">繁體中文 (binnenkort beschikbaar)</a> |
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja">Japans</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko">Koreaans</a>
        | <a href="#" title="Coming soon">Hindi (binnenkort beschikbaar)</a> |
        | <a href="#" title="Coming soon">Thais (binnenkort beschikbaar)</a> |
        | <a href="#" title="Coming soon">Frans (binnenkort beschikbaar)</a>
        | <a href="#" title="Coming soon">Duits (binnenkort beschikbaar)</a>
        | <a href="#" title="Coming soon">Spaans (binnenkort beschikbaar)</a>
        | <a href="#" title="Coming soon">Italiaans (binnenkort beschikbaar)</a>
        | <a href="#" title="Coming soon">Russisch (binnenkort beschikbaar)</a>
        | <a href="#" title="Coming soon">Portugees (binnenkort beschikbaar)</a>
        | <a href="#" title="Coming soon">Nederlands (binnenkort beschikbaar)</a>
        | <a href="#" title="Coming soon">Pools (binnenkort beschikbaar)</a>
        | <a href="#" title="Coming soon">Arabisch (binnenkort beschikbaar)</a>
        | <a href="#" title="Coming soon">Perzisch (binnenkort beschikbaar)</a>
        | <a href="#" title="Coming soon">Turks (binnenkort beschikbaar)</a>
        | <a href="#" title="Coming soon">Vietnamees (binnenkort beschikbaar)</a>
        | <a href="#" title="Coming soon">Bahasa Indonesia (binnenkort beschikbaar)</a>

      </div>
    </div>
  </details>
</div>

# TimeCapsule LLM

*Een taalmodel dat **vanaf nul** getraind is, uitsluitend op gegevens uit bepaalde plaatsen en tijdsperiodes om moderne bias te verminderen en de stem, het vocabulaire en het wereldbeeld van het tijdperk na te bootsen.*

Stel je voor dat een AI-model niet alleen deed alsof het historisch was, maar het daadwerkelijk was.

v0 en v0.5 gebouwd op [nanoGPT door Andrej Karpathy](https://github.com/karpathy/nanoGPT) Kern trainingsscripts en modelarchitectuur zijn zijn werk. 

v1 gebouwd op [Phi 1.5 door Microsoft](https://huggingface.co/microsoft/phi-1_5)

[Hugging Face Link](https://huggingface.co/haykgrigorian/TimeCapsuleLLM)

##  Modelgedrag & Beperkingen

### **v0**  

Vroege prompts tonen het model dat reageert met taal en gedrag uit de 19e eeuw. 
Voorbeeld: Prompt: "Who art Henry?" en het antwoordde "I know that man, I have did not a black, the storm." 

![TimeLockLLM Voorbeeldoutput](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- Geen vermelding van moderne concepten  
- Meestal tijdperk-accurate woordenschat  
- Zinnen zijn meestal onsamenhangend (verwacht bij ~187MB trainingsdata)

### **v0.5** 

Een aanzienlijke verbetering ten opzichte van v0.  
- Victoriaanse schrijfstijl, correcte interpunctie, meestal grammaticale zinnen  
- Nog steeds hoge mate van feitelijke hallucinatie  
- OCR-ruis (“Digitized by Google”) nog steeds aanwezig in de output

![TimeLockLLM Voorbeeldoutput](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

Eerste model dat een echt historisch evenement koppelt aan een daadwerkelijk figuur uit de dataset.

Voorbeeld: Prompt: "It was the year of our Lord 1834" 

De output: "It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity" 

Aanvankelijk dacht ik dat er toevallig een protest had plaatsgevonden in hetzelfde jaar, maar kijk hier eens naar: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### Waarom dit belangrijk is:

Dit is het eerste voorbeeld van een van mijn modellen die een jaar verbindt aan zowel een echt historisch evenement als een echt persoon verbonden aan dat evenement (Lord Palmerston). Eerdere modellen (v0 en v0.5) konden de schrijfstijlen uit de 19e eeuw nabootsen maar hallucineerden altijd gebeurtenissen, mensen en feiten. Dit toont aan dat het model begint dingen uit de dataset te onthouden.


## Toekomstige Plannen 

- Er zijn bijna 175.000 teksten gepubliceerd in Londen van 1800-1875 op Internet Archive 
- Ik ben van plan om het corpus uit te breiden en verder te schonen voor betere redeneervermogens
- Uitbreiden naar verschillende regio's en tijdsperioden voor meer historische modellen


## Hoe te Gebruiken

Dit project richt zich voornamelijk op het verzamelen van historische data, het voorbereiden voor training en het bouwen van een tokenizer. Ik behandel niet het volledige LLM-trainingsproces; daarvoor verwijs ik naar nanoGPT van Andrej Karpathy.

### Stap 1: Verzamelen en Voorbereiden van Historische Teksten 

- Verzamel .txt-bestanden van boeken en documenten uit het publieke domein, enz. uit jouw gekozen tijdsperiode (bijv. Londen 1800-1850) 
- Houd ze binnen jouw gekozen tijd/plaats venster  
- Reinig de tekstbestanden met een script of verwijder handmatig kopteksten/voetteksten van Project Gutenberg, moderne annotaties of zaken zoals OCR-fouten.

### Stap 2: Bouw een Aangepaste Tokenizer

- Voer train_tokenizer.py of train_tokenizer_hf.py uit op de geschoonde data.
- Dit levert vocab.json en merges.txt op
- Deze bestanden definiëren vocabulaire en samenvoegregels voor je model

### Stap 3: Train Je Model 

- Raadpleeg [nanoGPT van Andrej Karpathy](https://github.com/karpathy/nanoGPT) voor het trainingsproces of de documentatie van jouw gekozen architectuur.

# FAQ

## Wat is Selectieve Temporele Training?

Selectieve Temporele Training (STT) is een machine learning-methodologie waarbij alle trainingsdata specifiek wordt samengesteld om binnen een bepaald historisch tijdsbestek te vallen. Dit wordt gedaan om de taal en kennis van die periode te modelleren zonder invloed van moderne concepten. Bijvoorbeeld, het huidige model dat ik nu heb (v0.5) is getraind op data uitsluitend uit 1800-1875; het is niet fijn afgestemd maar vanaf nul getraind, wat resulteert in output die de linguïstische stijl en historische context van die periode weerspiegelt.

## Waarom niet gewoon fine-tuning of LoRA gebruiken?

Voor dit project probeer ik een taalmodel te maken dat niet beïnvloed is door moderne bias. Als ik iets als GPT-2 fine-tune, is het al vooraf getraind en die informatie verdwijnt niet. Als ik vanaf nul train, zal het taalmodel niet doen alsof het oud is, het zal het gewoon zijn. Het doel voor dit project is nu om iets te creëren dat uitsluitend kan redeneren met kennis uit Londense boeken gepubliceerd tussen 1800 en 1875.

## Welke data heb je gebruikt voor training?

Ik gebruik boeken, juridische documenten, kranten en andere geschriften uit Londen van 1800–1875. De lijst die ik heb gelinkt (voor v0) bevat ongeveer 200 documenten, maar voor de eerste training heb ik slechts 50 bestanden gebruikt, ongeveer ~187 MB. Je kunt een lijst van de documenten bekijken:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

Datasetgroottes:
v0: ~187MB
v0.5: ~435MB 
v1: ~6,25GB 

## Hoe groot zijn de modellen?

V0: 16M Parameters

V0.5 123M Parameters

V1: 700M Parameters

# Trainingsspecificaties?

# V0/V0.5
GPU: Geforce rtx 4060
CPU: i5-13400F 
Ram: 16GB DDR5.

# V1
GPU: A100 gehuurd















---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-30

---