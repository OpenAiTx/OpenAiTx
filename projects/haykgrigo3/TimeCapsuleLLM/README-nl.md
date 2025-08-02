
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=en">Engels</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN">简体中文</a>
        | <a href="#" title="Komt binnenkort">繁體中文 (komt binnenkort)</a> |
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja">Japans</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko">Koreaans</a>
        | <a href="#" title="Komt binnenkort">हिन्दी (komt binnenkort)</a> |
        | <a href="#" title="Komt binnenkort">ไทย (komt binnenkort)</a> |
        | <a href="#" title="Komt binnenkort">Frans (komt binnenkort)</a>
        | <a href="#" title="Komt binnenkort">Duits (komt binnenkort)</a>
        | <a href="#" title="Komt binnenkort">Spaans (komt binnenkort)</a>
        | <a href="#" title="Komt binnenkort">Italiaans (komt binnenkort)</a>
        | <a href="#" title="Komt binnenkort">Russisch (komt binnenkort)</a>
        | <a href="#" title="Komt binnenkort">Portugees (komt binnenkort)</a>
        | <a href="#" title="Komt binnenkort">Nederlands (komt binnenkort)</a>
        | <a href="#" title="Komt binnenkort">Pools (komt binnenkort)</a>
        | <a href="#" title="Komt binnenkort">Arabisch (komt binnenkort)</a>
        | <a href="#" title="Komt binnenkort">Perzisch (komt binnenkort)</a>
        | <a href="#" title="Komt binnenkort">Turks (komt binnenkort)</a>
        | <a href="#" title="Komt binnenkort">Vietnamees (komt binnenkort)</a>
        | <a href="#" title="Komt binnenkort">Bahasa Indonesia (komt binnenkort)</a>

      </div>
    </div>
  </details>
</div>

# TimeCapsule LLM
Een LLM getraind alleen op data uit bepaalde tijdsperioden om moderne bias te verminderen.

Stel je voor dat een AI-model niet alleen deed alsof het historisch was, maar het daadwerkelijk was.

Gebouwd op [nanoGPT van Andrej Karpathy](https://github.com/karpathy/nanoGPT) De kern trainingsscripts en modelarchitectuur zijn zijn werk.

# Projectdoelen

TimeCapsule LLM is een experimenteel project dat alleen getraind zal worden op teksten geschreven in bepaalde tijdsperioden. Het doel is om het wereldbeeld en de taal van specifieke historische tijdperken te simuleren.

# Waarom fine-tuning niet genoeg is

Als je alleen een voorgetraind model fine-tunet, zal je LLM nog steeds moderne concepten kennen. Natuurlijk is het bereiken van nul moderne bias moeilijk, maar ik wil hier zo dicht mogelijk bij komen. Geen moderne bias krijgen vereist het trainen van een model vanaf nul.

# Verwachte uitkomsten

Hopelijk zal dit model, wanneer het klaar is, geen moderne concepten kennen en niet in staat zijn te redeneren buiten wat het is getraind op. Het zou moderne concepten/vocabulaire niet moeten herkennen en ik hoop dat het geen moderne kennis hallucineert.

# Voortgangsupdates

## 9 juli 2025

Ik heb mijn tijdsperiode vastgesteld op 1800-1850 en regio: Londen

Ik heb een lijst van teksten, boeken, documenten verzameld

Tot nu toe heb ik er 50 als txt-bestanden en ik zal binnenkort beginnen met het trainen van NanoGPT

Ik zal dit bijwerken zolang er vooruitgang wordt geboekt

## 13 juli 2025

NanoGPT getraind met 187MB aan historische tekstdata.

## 15 juli 2025

Ik ben begonnen met het downloaden van teksten voor de tweede trainingsronde. Ik haal alles van Internet Archive en ik heb de tijdsperiode uitgebreid naar 1800-1875. Om een diverse reeks teksten te krijgen kun je onderwerp- en zoekfilters gebruiken voor publicatielocatie, tijdsperiode en onderwerpen op Internet Archive.

![Zoekfilters](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 16 juli 2025

Ik heb ongeveer 500 txt-bestanden van Internet Archive gedownload en na het opschonen ervan (gewoon witruimtes verwijderen, Gutenberg-koppen, enz.) heb ik ongeveer 500MB aan data. Het is een kleine dataset maar de vorige keer trainde ik met 187MB dus er zou in elk geval een merkbaar verschil moeten zijn in de output na het trainen van het tweede model. Ik hoop dat dit model in elk geval meer samenhangende zinnen kan produceren die een beetje logisch zijn. Het is natuurlijk geen garantie want dit is nog steeds een heel kleine dataset, maar het is meer dan wat ik de vorige keer gebruikte.

Dit zou haalbaar moeten zijn op mijn eigen hardware, het is ook goed want ik kan hopelijk enige verbetering zien voordat ik overstap naar een grotere dataset waarvoor ik een GPU zou moeten huren. Maar maak je geen zorgen, ik ben nog steeds van plan binnenkort een GPU te huren, maar voordat ik dat doe wil ik zeker weten dat mijn dataset zo gecureerd en schoon mogelijk is. Een van de problemen die ik heb is het opschonen, veel van deze txt-bestanden bevatten onzin. De scripts die ik gebruik voor het opschonen werken wel, maar zijn niet 100% effectief.

Ik ga deze dataset vandaag trainen en het zal ongeveer 4-5 uur duren. Zodra het klaar is en ik het test zal ik updates geven. Nogmaals dank aan iedereen die mijn project bekijkt, ik heb zelfs mensen gehad die me links naar OCR-bronnen sturen dus bedankt! Ik hoop dat meer mensen dit proberen en experimenteren met hun eigen datasets.


### Trainingsupdate

Ik begon met trainen op een corpus van 435MB (108 M tokens), het verloopt momenteel vrij soepel. De train loss daalde van 10,9 naar 4,9 in de eerste 2800 iteraties. Ik verwacht dat het ongeveer 8 of 9 uur zal duren om te voltooien. Ik post een nieuwe update zodra het klaar is.

## 17 juli 2025 2:13AM

De training is klaar voor het tweede model, het duurde ongeveer 8 uur en 40 minuten op mijn 4060 (3.900 iteraties/uur) voor 33.000 iteraties (5 epochs). De uiteindelijke train loss was 3,73. De output was verrassend goed; het genereert nu echt samenhangende zinnen in 19e-eeuwse stijl.

## 28 juli 2025

Ik heb v0.5 geüpload naar Hugging Face, [bekijk het hier](https://huggingface.co/haykgrigorian/TimeCapsuleLLM) als je wilt. Je kunt nu mijn repo downloaden en lokaal draaien. Helaas werkt nanoGPT niet direct met HuggingFace, dus je zult het model lokaal moeten downloaden en draaien.

Ook begin ik met het cureren van data voor mijn volgende trainingsronde, ik denk dat ik misschien 5-10x meer data nodig heb om redeneervermogen te bereiken.


# V0 Modelgedrag & Beperkingen

Vroege prompts laten het model reageren met taal en gedrag uit de jaren 1800. Bijvoorbeeld, ik vroeg "Who art Henry?" en het antwoordde "I know that man, I have did not a black, the storm." en ja die zin slaat nergens op maar de LLM herkent dat ik naar een persoon vraag.

![TimeLockLLM Voorbeeldoutput](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

Er wordt geen melding gemaakt van moderne concepten, de uitvoer bevat voornamelijk woorden en formuleringen uit de jaren 1800.

Er is nog veel werk nodig, trainen op 187MB levert geen model op dat tekst produceert met complexe redeneringen.

Op dit moment produceert het zinnen die niet volledig gestructureerd zijn en over het algemeen gewoon geen zin hebben, maar dit is normaal voor deze trainingsomvang.

# V0.5 Modelgedrag & Beperkingen

Dit is een mooie verbetering vergeleken met het vorige model. De schrijfstijl en woordenschat zijn Victoriaans en bijna elke zin is grammaticaal correct met de juiste interpunctie. En opnieuw, dit is vanaf nul getraind dus het blijft bij onderwerpen uit de 19e eeuw.

![TimeLockLLM Voorbeeldoutput](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

Er zijn veel feitelijke hallucinaties. Veel (zoals 100%) van de details (data, gebeurtenissen, historische figuren) zijn verzonnen. Ook hebben de zinnen vaak geen verband met elkaar, soms zijn er misschien 2 zinnen die met elkaar te maken hebben maar verder niet. Een ander probleem is dat soms een losse “Digitized by Google” voettekst verschijnt, dus de volgende keer dat ik train moet ik echt goed zorgen dat de teksten goed opgeschoond zijn. Over het algemeen ben ik erg blij met de resultaten, het is nog lang geen LLM maar zeker een zinnengenerator.

Ik leer veel en ga de komende weken uitzoeken wat ik beter moet doen. Ik zal binnenkort bestanden uploaden!

# Komende Plannen

(Voltooid) Ik ga beginnen met versie 0.5, in plaats van 50 boeken te gebruiken bij het trainen, ga ik idealiter 500-600 gebruiken. Op dit moment train ik nanoGPT met boeken uit 1800-1850 en specifiek uit Londen. Er zijn uitdagingen zoals ervoor zorgen dat de boeken die ik vind niet geüpdatet zijn of moderne interpretaties bevatten maar onaangetaste boeken die zijn uitgegeven binnen mijn gekozen periode.

Ik wil een nieuw model trainen (v1) met een veel grotere corpus, misschien 5-10x groter dan die voor v0.5. Mijn doel is om te zien of redenerend vermogen kan ontstaan uit Selectieve Temporele Training alleen, dit wordt een moeilijkere taak en ik weet niet zeker of het mogelijk is vanwege de historische datalimieten. In de komende weken probeer ik genoeg data te verzamelen voor een corpus van 5-10GB. Ik geloof dat als ik schone, hoogwaardige data kan krijgen en een GPU kan huren, er vooruitgang zal zijn.

# Hoe dit project te gebruiken

Dit project richt zich vooral op het verzamelen van historische data, het voorbereiden voor training en het bouwen van een tokenizer. Ik ga niet het volledige LLM-trainingsproces behandelen, daarvoor verwijs ik naar nanoGPT van Andrej Karpathy.

# Stap 1: Verzamel en bereid historische teksten voor

Verzamel .txt-bestanden van boeken uit het publieke domein, documenten, enz. uit de gekozen periode (bijvoorbeeld Londen 1800-1850).

Je kunt download_texts_improved.py gebruiken om boeken te downloaden als je dat wilt.

Schoon de tekstbestanden op met een script of verwijder handmatig headers/footers van Project Gutenberg, moderne annotaties of OCR-fouten.

prepare_dataset.py zou goed moeten werken.

# Stap 2: Bouw een aangepaste tokenizer

Voer train_tokenizer.py of train_tokenizer_hf.py uit op de opgeschoonde data.
Dit levert vocab.json en merges.txt op

Deze bestanden definiëren vocabulaire en samenvoegregels voor je model

# Stap 3: Train je model (nanoGPT)

Raadpleeg [nanoGPT van Andrej Karpathy](https://github.com/karpathy/nanoGPT) voor het trainingsproces.

Je kunt ook een ander LLM trainen als je wilt, maar ik heb nanoGPT gebruikt

# FAQ

## Wat is Selectieve Temporele Training?

Selectieve Temporele Training (STT) is een machine learning-methodologie waarbij alle trainingsdata specifiek wordt samengesteld binnen een bepaalde historische periode. Dit wordt gedaan om de taal en kennis van die tijd te modelleren zonder invloed van moderne concepten. Het huidige model (v0.5) is bijvoorbeeld getraind op data uitsluitend uit 1800-1875, niet fijn-afgesteld maar vanaf nul getraind, waardoor de output het taalgebruik en de context van die tijd weerspiegelt.

## Waarom niet gewoon fine-tuning of LoRA gebruiken?

Voor dit project probeer ik een taalmodel te maken dat niet beïnvloed is door moderne bias. Als ik bijvoorbeeld GPT-2 fine-tune, is het al voorgetraind en die informatie verdwijnt niet meer. Als ik vanaf nul train, zal het taalmodel zich niet voordoen als oud, maar het gewoon zijn. Het doel is nu om iets te creëren dat uitsluitend kan redeneren met kennis uit Londense boeken gepubliceerd tussen 1800 en 1850.

## Welke data heb je gebruikt voor training?

Ik gebruik boeken, juridische documenten, kranten en andere geschriften uit Londen van 1800–1850. De lijst die ik gelinkt heb bevat ongeveer 200 documenten maar voor de eerste training heb ik slechts 50 bestanden gebruikt, ongeveer ~187 MB. Je kunt de lijst met documenten bekijken:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## Hoe groot is het Versie 0 model?

Dit model is nu erg klein, ik doe dit vooral voor de lol en volg een strikte trainingsregel van geen moderne bronnen. Het heeft bijna 16 miljoen parameters maar ik ga binnenkort meer oude teksten verzamelen om opnieuw te trainen. Ik zal updates geven naarmate ik vorder.

## Trainingsspecificaties?

GPU: Geforce rtx 4060
CPU: i5-13400F
Ram: 16GB DDR5.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-02

---