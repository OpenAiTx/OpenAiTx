
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=en">Engels</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN">简体中文</a>
        | <a href="#" title="Coming soon">繁體中文 (binnenkort beschikbaar)</a> |
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko">한국어</a>
        | <a href="#" title="Coming soon">हिन्दी (binnenkort beschikbaar)</a> |
        | <a href="#" title="Coming soon">ไทย (binnenkort beschikbaar)</a> |
        | <a href="#" title="Coming soon">Français (binnenkort beschikbaar)</a>
        | <a href="#" title="Coming soon">Deutsch (binnenkort beschikbaar)</a>
        | <a href="#" title="Coming soon">Español (binnenkort beschikbaar)</a>
        | <a href="#" title="Coming soon">Italiano (binnenkort beschikbaar)</a>
        | <a href="#" title="Coming soon">Русский (binnenkort beschikbaar)</a>
        | <a href="#" title="Coming soon">Português (binnenkort beschikbaar)</a>
        | <a href="#" title="Coming soon">Nederlands (binnenkort beschikbaar)</a>
        | <a href="#" title="Coming soon">Polski (binnenkort beschikbaar)</a>
        | <a href="#" title="Coming soon">العربية (binnenkort beschikbaar)</a>
        | <a href="#" title="Coming soon">فارسی (binnenkort beschikbaar)</a>
        | <a href="#" title="Coming soon">Türkçe (binnenkort beschikbaar)</a>
        | <a href="#" title="Coming soon">Tiếng Việt (binnenkort beschikbaar)</a>
        | <a href="#" title="Coming soon">Bahasa Indonesia (binnenkort beschikbaar)</a>

      </div>
    </div>
  </details>
</div>

# TimeCapsule LLM
Een LLM die uitsluitend getraind is op data uit bepaalde tijdsperioden om moderne bias te verminderen.

Stel je voor dat een AI-model niet alleen deed alsof het historisch was, maar het ook daadwerkelijk was.

Gebouwd op [nanoGPT van Andrej Karpathy](https://github.com/karpathy/nanoGPT) Kerntrainingsscripts en modelarchitectuur zijn zijn werk. 

# Doelstellingen van het project 

TimeCapsule LLM is een experimenteel project dat alleen getraind zal worden op teksten geschreven in bepaalde tijdsperioden. Het doel is het wereldbeeld en de taal van specifieke historische tijdperken te simuleren.

# Waarom fine-tuning niet voldoende is 

Als je alleen een voorgetraind model finetunet, zal je LLM nog steeds moderne concepten kennen. Natuurlijk is het bereiken van nul moderne bias moeilijk, maar ik wil hier zo dicht mogelijk bij komen. Geen moderne bias krijgen vereist dat je een model vanaf nul traint.

# Verwachte resultaten 

Hopelijk weet dit model, wanneer het af is, niets van moderne concepten en zal het niet kunnen redeneren buiten wat het geleerd heeft. Het zou moderne concepten/vocabulaire niet moeten herkennen en ik hoop dat het geen moderne kennis hallucineren.

# Voortgangsupdates

## 9 juli 2025

Ik heb mijn tijdsperiode ingesteld op 1800-1850 en regio: Londen 

Ik heb een lijst van teksten, boeken, documenten verzameld 

Tot nu toe heb ik er 50 als txt-bestanden en zal binnenkort beginnen met het trainen van NanoGPT 

Ik zal dit bijwerken zolang er voortgang wordt geboekt

## 13 juli 2025

NanoGPT getraind met 187MB aan historische tekstdata. 

## 15 juli 2025

Ik ben begonnen met het downloaden van teksten voor de tweede trainingsronde. Ik haal alles van Internet Archive en ik heb de tijdsperiode uitgebreid naar 1800-1875. Om een diverse reeks teksten te krijgen, kun je onderwerp- en zoekfilters gebruiken voor publicatielocatie, tijdsperiode en onderwerpen op Internet Archive. 

![Zoekfilters](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 16 juli 2025

Ik heb ongeveer 500 txt-bestanden gedownload van Internet Archive en na het opschonen ervan (gewoon witruimtes verwijderen, Gutenberg-headers, enz.) heb ik ongeveer 500MB aan data. Het is een klein datasetje, maar de vorige keer trainde ik op 187MB dus er zou in ieder geval een merkbaar verschil moeten zijn in de output na het trainen van het tweede model. Ik hoop dat dit model in ieder geval meer samenhangende zinnen kan produceren die enigszins logisch zijn. Het is natuurlijk geen garantie, want dit is nog steeds een heel klein datasetje, maar het is meer dan wat ik de vorige keer gebruikte. 

Dit zou op mijn eigen hardware te doen moeten zijn, en dat is ook goed omdat ik hopelijk al verbeteringen kan zien voordat ik overstap op een groter dataset, waarvoor ik een GPU zou moeten huren. Maar maak je geen zorgen, ik ben nog steeds van plan binnenkort een GPU te huren, maar daarvoor wil ik mijn dataset zo gecureerd en schoon mogelijk hebben. Een van de problemen die ik heb is het opschonen; veel van deze txt-bestanden bevatten onzin ertussen. De scripts die ik voor het opschonen heb gebruikt werken wel, maar zijn niet 100% effectief. 

Ik ga deze dataset vandaag trainen en het zou ongeveer 4-5 uur duren. Zodra het klaar is en ik het getest heb, zal ik updates geven. Nogmaals bedankt aan iedereen die mijn project bekijkt, ik heb zelfs al mensen gehad die me links naar OCR-bronnen stuurden, dus bedankt! Ik hoop dat meer mensen dit proberen en experimenteren met hun eigen datasets. 

## 28 juli 2025 

Ik heb v0.5 geüpload naar Hugging Face, [Bekijk het hier](https://huggingface.co/haykgrigorian/TimeCapsuleLLM) als je wilt. Je kunt nu mijn repo downloaden en lokaal draaien. Helaas werkt nanoGPT niet native met HuggingFace, dus je zult het model lokaal moeten downloaden en draaien. 

Ook zal ik beginnen met het cureren van data voor mijn volgende trainingsronde. Ik denk dat ik misschien 5-10x meer data nodig heb om redeneervermogen te bereiken. 

### Trainingsupdate 

Ik ben begonnen met trainen op een corpus van 435MB (108 M tokens), het gaat tot nu toe vrij soepel. De train loss is gedaald van 10,9 naar 4,9 in de eerste 2800 iteraties. Ik verwacht dat het ongeveer 8 of 9 uur zal duren om te voltooien. Ik plaats weer een update als het klaar is.

## 17 juli 2025 2:13AM

De training is klaar voor het tweede model, het duurde ongeveer 8 uur en 40 minuten met mijn 4060 (3.900 iters/uur) voor 33.000 iteraties (5 epochs). De uiteindelijke train loss was 3,73. De output was verrassend goed; het genereert nu echt samenhangende zinnen in 19e-eeuwse stijl. 

# V0 Modelgedrag & Beperkingen 

Vroege prompts laten zien dat het model reageert met taal en gedrag uit de 1800's. Bijvoorbeeld, ik gaf de prompt "Who art Henry?" en het antwoordde "I know that man, I have did not a black, the storm." en ja, die zin slaat nergens op maar de LLM herkent dat ik naar een persoon vraag. 

![TimeLockLLM Voorbeeldoutput](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)
Er wordt geen melding gemaakt van moderne concepten, de output bevat voornamelijk woorden en formuleringen uit de 19e eeuw.

Het heeft nog veel werk nodig, trainen op 187MB zal je geen model opleveren dat tekst met complexe redeneringen produceert.

Op dit moment produceert het zinnen die niet volledig gestructureerd zijn en over het algemeen niet logisch zijn, maar dit is normaal gezien de trainingsomvang.

# V0.5 Modelgedrag & Beperkingen

Dit is een mooie verbetering ten opzichte van het vorige model. De schrijfstijl en woordenschat zijn Victoriaans en bijna elke zin is grammaticaal correct met juiste interpunctie. En opnieuw, dit is vanaf nul getraind dus het blijft bij onderwerpen uit de 19e eeuw.

![TimeLockLLM Voorbeeldoutput](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

Er zijn veel feitelijke hallucinaties. Veel (zoals 100%) van de details (data, gebeurtenissen, historische figuren) zijn verzonnen. Ook hebben de zinnen eigenlijk geen onderlinge verbanden, soms zijn er misschien 2 zinnen die samenhangen, maar verder niet. Een ander probleem is dat soms een verdwaalde “Digitized by Google” voettekst verschijnt, dus de volgende keer dat ik train moet ik echt zorgen dat de teksten goed zijn opgeschoond. Al met al ben ik erg blij met de resultaten, het is nog lang geen LLM maar zeker een zinnengenerator.

Ik leer veel en ga de komende weken uitzoeken wat ik beter moet doen. Ik zal binnenkort bestanden uploaden!

# Komende Plannen

(Voltooid) Ik ga beginnen aan versie 0.5, in plaats van te trainen met 50 boeken train ik idealiter met 500-600 boeken. Op dit moment train ik nanoGPT met boeken uit 1800-1850, specifiek uit Londen. Er zijn wat uitdagingen zoals ervoor zorgen dat de boeken die ik vind niet zijn aangepast of een moderne interpretatie hebben, maar onaangeroerde boeken die binnen mijn gekozen periode zijn gepubliceerd.

Ik wil een nieuw model (v1) trainen met een veel grotere corpus, misschien 5-10x groter dan die voor v0.5. Mijn doel is om te zien of redeneervermogen kan ontstaan door alleen Selectieve Temporele Training; dit wordt een moeilijkere taak en ik weet niet zeker of het mogelijk is vanwege beperkingen in historische data. In de komende weken probeer ik genoeg data te verzamelen voor een corpus van 5-10GB. Ik geloof dat als ik schone, hoogwaardige data kan krijgen en een GPU kan huren, er vooruitgang zal zijn.

# Hoe gebruik je dit project

Dit project richt zich vooral op het verzamelen van historische data, het voorbereiden voor training en het bouwen van een tokenizer. Ik ga het volledige LLM-trainingsproces niet behandelen, daarvoor kun je terecht bij nanoGPT van Andrej Karpathy.

# Stap 1: Verzamel en bereid historische teksten voor

Verzamel .txt-bestanden van boeken, documenten, enz. uit het publieke domein uit je gekozen periode (bijv. Londen 1800-1850)

Je kunt download_texts_improved.py gebruiken om boeken voor je te downloaden indien nodig.

Maak de tekstbestanden schoon met een script of verwijder handmatig headers/footers van Project Gutenberg, moderne annotaties of dingen zoals OCR-fouten.

prepare_dataset.py zou prima moeten werken.

# Stap 2: Bouw een aangepaste tokenizer

Voer train_tokenizer.py of train_tokenizer_hf.py uit op de opgeschoonde data.
Dit levert je vocab.json en merges.txt op

Deze bestanden definiëren de vocabulaire en merge-regels voor je model

# Stap 3: Train je model (nanoGPT)

Raadpleeg [nanoGPT van Andrej Karpathy](https://github.com/karpathy/nanoGPT) voor het trainingsproces.

Je kunt een ander LLM trainen als je wilt, maar ik gebruikte nanoGPT

# FAQ

## Wat is Selectieve Temporele Training?

Selectieve Temporele Training (STT) is een machine learning-methodologie waarbij alle trainingsdata specifiek wordt verzameld binnen een bepaalde historische periode. Dit wordt gedaan om de taal en kennis van die tijd te modelleren zonder invloed van moderne concepten. Bijvoorbeeld, het huidige model dat ik heb (v0.5) is getraind op data exclusief uit 1800-1875, het is niet fijngestemd maar vanaf nul getraind, wat resulteert in output die de linguïstische stijl en historische context van die periode weerspiegelt.

## Waarom niet gewoon fine-tunen of LoRA gebruiken?

Voor dit project probeer ik een taalmodel te maken dat niet wordt beïnvloed door moderne bias. Als ik bijvoorbeeld iets als GPT-2 fine-tune, is het al voorgetraind en die informatie verdwijnt niet. Als ik vanaf nul train zal het taalmodel niet doen alsof het oud is, het zal het gewoon zijn. Het doel voor dit project is nu iets te maken dat uitsluitend kan redeneren met kennis uit Londense boeken tussen 1800 en 1850.

## Wat voor data gebruikte je voor het trainen?

Ik gebruik boeken, juridische documenten, kranten en andere geschriften uit Londen 1800–1850. De lijst die ik heb gelinkt bevat er zo’n 200, maar voor de eerste training heb ik slechts 50 bestanden gebruikt van ongeveer ~187 MB. Je kunt een lijst van de documenten bekijken:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## Hoe groot is het Versie 0-model?

Dit model is nu erg klein, ik doe dit gewoon voor de lol en volg een strikte trainingsregel van geen moderne bronnen. Het heeft bijna 16 miljoen parameters, maar ik ga meer oude teksten verzamelen om een nieuwe modeltraining te starten. Ik zal updates geven naarmate ik verder ga.

## Trainingsspecificaties?

GPU: Geforce rtx 4060
CPU: i5-13400F
Ram: 16GB DDR5.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---