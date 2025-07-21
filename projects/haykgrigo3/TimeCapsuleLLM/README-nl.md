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
        | <a href="#" title="Coming soon">हिन्दी (binnenkort beschikbaar)</a> |
        | <a href="#" title="Coming soon">Thai (binnenkort beschikbaar)</a> |
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
Een LLM getraind uitsluitend op data uit bepaalde tijdsperioden om moderne vooringenomenheid te verminderen.

Stel je voor dat een AI-model niet alleen historisch deed, maar het ook echt was.

Gebaseerd op [nanoGPT van Andrej Karpathy](https://github.com/karpathy/nanoGPT) De kerntrainingsscripts en modelarchitectuur zijn zijn werk. 

# Projectdoelen

TimeCapsule LLM is een experimenteel project dat alleen getraind zal worden op teksten geschreven in bepaalde tijdsperioden. Het doel is om het wereldbeeld en taalgebruik van specifieke historische tijdperken te simuleren.

# Waarom fine-tunen niet genoeg is

Als je alleen een voorgetraind model fine-tunet, zal je LLM nog steeds moderne concepten kennen. Natuurlijk is het bereiken van nul moderne vooringenomenheid moeilijk, maar ik wil hier zo dicht mogelijk bij komen. Geen moderne bias vereist het trainen van een model vanaf nul.

# Verwachte uitkomsten

Hopelijk zal dit model, wanneer het klaar is, geen moderne concepten kennen en niet in staat zijn te redeneren buiten wat het geleerd heeft. Het zou moderne concepten/woordenschat niet moeten herkennen en ik hoop dat het geen moderne kennis hallucineert.

# Voortgangsupdates

## 9 juli 2025

Ik heb mijn tijdsperiode ingesteld op 1800-1850 en regio: Londen

Ik heb een lijst van teksten, boeken, documenten verzameld

Tot nu toe heb ik er 50 als txt-bestanden en zal binnenkort beginnen met het trainen van NanoGPT

Zal dit bijwerken zolang er voortgang wordt geboekt

## 13 juli 2025

nanoGPT getraind met 187MB aan historische tekstdata.

## 15 juli 2025

Ik ben begonnen met het downloaden van teksten voor de tweede trainingsronde. Ik haal alles van Internet Archive en heb de periode uitgebreid naar 1800-1875. Om een diverse reeks teksten te krijgen kun je op Internet Archive subject- en zoekfilters gebruiken voor publicatielocatie, periode en onderwerpen.

![Zoekfilters](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 16 juli 2025

Ik heb ongeveer 500 txt-bestanden gedownload van Internet Archive en na schoonmaken (gewoon witruimtes, Gutenberg-headers, enz. verwijderen) heb ik ongeveer 500MB aan data. Het is een kleine dataset, maar de vorige keer trainde ik op 187MB dus er zou nu op zijn minst een merkbaar verschil in output moeten zijn nadat ik het tweede model train. Ik hoop dat dit model op zijn minst zinnen kan produceren die meer samenhangend zijn en een beetje logisch. Het is natuurlijk geen garantie aangezien dit nog steeds een erg kleine dataset is, maar het is meer dan wat ik de vorige keer gebruikte.

Dit zou op mijn eigen hardware moeten kunnen, dat is ook goed want hopelijk zie ik wat verbeteringen voordat ik overstap op een grotere dataset waarvoor ik een GPU zou moeten huren. Maak je geen zorgen, ik ben nog steeds van plan binnenkort een GPU te huren, maar voordat ik dat doe wil ik zeker weten dat mijn dataset zo gecureerd en schoon mogelijk is. Een van de problemen die ik heb is het opschonen; veel van deze txt-bestanden bevatten onzin door elkaar. De scripts die ik heb gebruikt voor het opschonen werken wel, maar zijn niet 100% effectief.

Ik ga deze dataset vandaag trainen en dat zou ongeveer 4-5 uur moeten duren. Als het klaar is en ik het test, geef ik updates. Nogmaals bedankt aan iedereen die mijn project bekijkt, ik heb zelfs mensen gehad die me links naar OCR-bronnen hebben gestuurd dus bedankt! Ik hoop dat meer mensen dit proberen en experimenteren met hun eigen datasets.

### Trainingsupdate

Ik ben begonnen met trainen op een corpus van 435MB (108 M tokens), het gaat tot nu toe vrij soepel. De train loss daalde van 10,9 naar 4,9 in de eerste 2800 iteraties. Ik verwacht dat het ongeveer 8 of 9 uur zal duren om te voltooien. Ik post nog een update als het klaar is.

## 17 juli 2025 2:13AM

De training voor het tweede model is klaar, het duurde ongeveer 8 uur en 40 minuten met mijn 4060 (3.900 iteraties/uur) voor 33.000 iteraties (5 epochs). De uiteindelijke train loss was 3,73. De uitkomsten waren verrassend goed; het genereert nu echt samenhangende 19e-eeuwse zinnen.

# V0 Modelgedrag & Beperkingen

Vroege prompts tonen dat het model reageert met taal en gedrag uit de jaren 1800. Bijvoorbeeld, ik gaf de prompt "Who art Henry?" en het antwoordde "I know that man, I have did not a black, the storm." en ja, die zin slaat nergens op maar de LLM herkent dat ik naar een persoon vraag.

![TimeLockLLM Voorbeeldoutput](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

Er is geen vermelding van moderne concepten, de uitkomsten bevatten vooral woorden en zinsbouw uit de jaren 1800.

Het heeft nog veel werk nodig, trainen op 187MB levert geen model op dat tekst met complexe redeneringen produceert.

Op dit moment produceert het zinnen die geen volledige zinsstructuur hebben en over het algemeen gewoon niet logisch zijn, maar dat is normaal voor deze trainingsomvang.

# V0.5 Modelgedrag & Beperkingen

Dit is een mooie verbetering ten opzichte van het vorige model. De schrijfstijl en woordenschat zijn Victoriaans en bijna elke zin is grammaticaal correct met de juiste interpunctie. En opnieuw is dit model van de grond af getraind, dus het blijft bij onderwerpen uit de jaren 1800.

![TimeLockLLM Voorbeeldoutput](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

Er zijn veel feitelijke hallucinaties. Heel veel (zoals 100%) van de details (data, gebeurtenissen, historische figuren) zijn verzonnen. Ook hebben de zinnen onderling weinig samenhang, soms zijn twee zinnen aan elkaar gerelateerd maar verder dan dat niet. Een ander probleem is dat soms de “Digitized by Google” footer verschijnt, dus de volgende keer moet ik echt goed opletten dat de teksten goed zijn opgeschoond. Over het algemeen ben ik erg tevreden met de resultaten, het is nog lang geen LLM maar zeker een zinnen-generator.

Ik leer veel en ga de komende weken uitzoeken wat ik beter moet doen. Ik upload binnenkort bestanden!

# Toekomstige Plannen

(Voltooid) Ik ga beginnen met versie 0.5, in plaats van te trainen met 50 boeken train ik idealiter met 500-600 boeken. Momenteel train ik nanoGPT met boeken uit 1800-1850, specifiek uit Londen. Er zijn uitdagingen zoals ervoor zorgen dat de boeken die ik vind niet zijn bijgewerkt of moderne interpretaties bevatten, maar onaangeroerde boeken die binnen mijn gekozen periode zijn gepubliceerd.

Ik wil een nieuw model (v1) trainen met een veel grotere corpus, misschien 5-10x groter dan wat ik voor v0.5 heb gebruikt. Mijn doel is om te zien of redeneervermogen kan ontstaan uit alleen Selectieve Temporele Training, dit wordt een moeilijkere taak en ik weet niet zeker of het mogelijk is vanwege de historische datalimieten. De komende weken probeer ik genoeg data te verzamelen voor een corpus van 5-10GB. Ik geloof dat als ik schone, hoogwaardige data kan krijgen en een GPU kan huren, er vooruitgang zal zijn.

# Hoe dit project te gebruiken

Dit project richt zich vooral op het verzamelen van historische data, het voorbereiden voor training en het bouwen van een tokenizer. Ik zal het volledige LLM-trainingsproces niet behandelen, daarvoor verwijs ik naar nanoGPT van Andrej Karpathy.

# Stap 1: Verzamel en bereid historische teksten voor

Verzamel .txt-bestanden van boeken, documenten, enz. uit het publieke domein uit je gekozen periode (bijv. Londen 1800-1850)

Je kunt download_texts_improved.py gebruiken om boeken te downloaden als dat nodig is.

Maak de tekstbestanden schoon met een script of verwijder handmatig headers/footers van Project Gutenberg, moderne annotaties of OCR-fouten.

prepare_dataset.py zou prima moeten werken.

# Stap 2: Bouw een aangepaste tokenizer

Voer train_tokenizer.py of train_tokenizer_hf.py uit op de opgeschoonde data.
Dit levert je vocab.json en merges.txt op

Deze bestanden definiëren de vocabulaire en samenvoegregels voor je model

# Stap 3: Train je model (nanoGPT)

Zie [nanoGPT van Andrej Karpathy](https://github.com/karpathy/nanoGPT) voor het trainingsproces.

Je kunt een ander LLM trainen als je wilt, maar ik heb nanoGPT gebruikt

# FAQ

## Wat is Selectieve Temporele Training?

Selectieve Temporele Training (STT) is een machine learning-methodologie waarbij alle trainingsdata specifiek binnen een bepaald historisch tijdsbestek valt. Dit gebeurt om de taal en kennis uit die tijd te modelleren zonder invloed van moderne concepten. Bijvoorbeeld, het huidige model (v0.5) is uitsluitend getraind op data uit 1800-1875; het is niet gefinetuned maar helemaal opnieuw getraind, wat resulteert in output die de taalstijl en historische context van die tijd weerspiegelt.

## Waarom niet gewoon fine-tunen of LoRA gebruiken?

Voor dit project probeer ik een taalmodel te maken dat niet wordt beïnvloed door moderne vooroordelen. Als ik iets als GPT-2 fine-tune, is het al voorgetraind en die informatie blijft aanwezig. Als ik vanaf nul train, doet het taalmodel niet alsof het oud is, het is het gewoon. Het doel van dit project nu is iets te maken dat uitsluitend kan redeneren op basis van kennis uit Londense boeken tussen 1800 en 1850.

## Wat voor data heb je gebruikt voor training?

Ik gebruik boeken, juridische documenten, kranten en andere geschriften uit Londen 1800–1850. De lijst die ik heb gelinkt bevat er ongeveer 200, maar voor de eerste training heb ik slechts 50 bestanden van ~187 MB gebruikt. Je kunt een lijst met documenten bekijken:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## Hoe groot is het Versie 0 model?

Dit model is nu heel klein, ik doe dit gewoon voor de lol en volg een strikte trainingsregel van geen moderne bronnen. Het heeft bijna 16 miljoen parameters maar ik ga meer oude teksten verzamelen om een nieuwe modeltraining te starten. Ik geef updates als ik verder ga.

## Trainingsspecificaties?

GPU: Geforce rtx 4060
CPU: i5-13400F 
Ram: 16GB DDR5.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-21

---