
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
Een LLM getraind uitsluitend op gegevens uit bepaalde tijdsperiodes om moderne bias te verminderen.

Stel je voor dat een AI-model niet alleen doet alsof het historisch is, maar het ook echt is.

Gebouwd op [nanoGPT van Andrej Karpathy](https://github.com/karpathy/nanoGPT). De kerntrainingsscripts en modelarchitectuur zijn van hem. 

# Projectdoelen 

TimeCapsule LLM is een experimenteel project dat alleen getraind zal worden op teksten geschreven in bepaalde tijdsperiodes. Het doel is om het wereldbeeld en de taal van specifieke historische tijdperken te simuleren.

# Waarom fine-tunen niet genoeg is 

Als je alleen een voorgetraind model fine-tunet, zal je LLM nog steeds moderne concepten kennen. Natuurlijk is het bereiken van nul moderne bias moeilijk, maar ik wil hier zo dicht mogelijk bij komen. Geen moderne bias krijgen vereist dat een model vanaf nul getraind wordt.

# Verwachte uitkomsten 

Hopelijk zal dit model, eenmaal klaar, geen moderne concepten kennen en niet kunnen redeneren buiten wat het geleerd heeft. Het zou moderne concepten/vocabulaire niet moeten herkennen en hopelijk geen moderne kennis hallucineren.

# Voortgangsupdates

## 9 juli 2025

Ik heb mijn tijdsperiode vastgesteld op 1800-1850 en regio: Londen 

Ik heb een lijst verzameld met teksten, boeken, documenten 

Tot nu toe heb ik er 50 als txt-bestanden en zal binnenkort beginnen met het trainen van NanoGPT 

Ik zal dit bijwerken zolang er voortgang is

## 13 juli 2025

nanoGPT getraind met 187MB aan historische tekstdata. 

## 15 juli 2025

Ik ben begonnen met het downloaden van teksten voor de tweede trainingsronde. Ik haal alles van Internet Archive en heb de tijdsperiode uitgebreid tot 1800-1875. Voor een diverse reeks teksten kun je onderwerp- en zoekfilters gebruiken voor publicatielocatie, tijdsperiode en onderwerpen op Internet Archive. 

![Zoekfilters](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 16 juli 2025

Ik heb ongeveer 500 txt-bestanden gedownload van Internet Archive en na het opschonen ervan (alleen witruimtes verwijderen, Gutenberg-headers, enz.) heb ik ongeveer 500MB aan data. Het is een kleine dataset maar de vorige keer trainde ik op 187MB dus er zou ten minste enig merkbaar verschil in de output moeten zijn na het trainen van het tweede model. Ik hoop dat dit model ten minste meer samenhangende zinnen kan produceren die enigszins logisch zijn. Het is natuurlijk geen garantie want dit is nog steeds een erg kleine dataset, maar het is meer dan wat ik de vorige keer gebruikte. 

Dit zou haalbaar moeten zijn op mijn eigen hardware, dat is ook goed omdat ik hopelijk enige verbetering kan zien voordat ik overstap naar een grotere dataset waarvoor ik een GPU moet huren. Maak je geen zorgen, ik ben wel van plan binnenkort een GPU te huren, maar voordat ik dat doe wil ik zeker weten dat mijn dataset zo goed mogelijk gecureerd en schoon is. Een van de problemen die ik heb is schoonmaken; veel van deze txt-bestanden bevatten onzin. De scripts die ik voor het schonen heb gebruikt werken wel, maar zijn niet 100% effectief. 

Ik ga deze dataset vandaag trainen en het zou ongeveer 4-5 uur moeten duren. Zodra het klaar is en ik het test, zal ik updates geven. Nogmaals bedankt aan iedereen die mijn project bekijkt; sommige mensen hebben me zelfs links gegeven naar OCR-bronnen, dus bedankt! Ik hoop dat meer mensen dit proberen en experimenteren met hun eigen datasets. 


### Trainingsupdate 

Ik ben begonnen met trainen op een corpus van 435MB (108M tokens), het verloopt momenteel vrij soepel. De train loss daalde van 10,9 naar 4,9 in de eerste 2800 iteraties. Ik verwacht dat het ongeveer 8 of 9 uur zal duren om te voltooien. Ik zal nog een update plaatsen zodra het klaar is.

## 17 juli 2025

De training is klaar voor het tweede model; het kostte mijn 4060 ongeveer 8 uur en 40 minuten (3.900 iters/uur) voor 33.000 iteraties (5 epochs). De uiteindelijke train loss was 3,73. De outputs waren verrassend goed; het genereert nu echt samenhangende zinnen in 19e-eeuwse stijl. 

## 28 juli 2025 

Ik heb v0.5 geüpload naar Hugging Face, [Bekijk het hier](https://huggingface.co/haykgrigorian/TimeCapsuleLLM) als je wilt. Je kunt nu mijn repo downloaden en lokaal draaien. Helaas werkt nanoGPT niet native met HuggingFace, dus je zult het model lokaal moeten downloaden en draaien. 

Ook zal ik beginnen met het cureren van data voor mijn volgende trainingsronde; ik denk dat ik misschien 5-10x meer data nodig heb om redeneervermogen te bereiken. 

## 2 augustus 2025

Ik ga binnenkort beginnen aan Versie 1. Ik zal moeten overstappen van nanoGPT's architectuur naar iets moderners. Ik heb verschillende open-source LLM-architecturen in gedachten, waaronder: OpenLLaMA v3, Phi-2 en Qwen 1.5B. En om de sprong naar V1 te ondersteunen, zal ik zorgvuldig een veel grotere en diverse dataset moeten cureren. Ik heb minstens 5GB aan schone trainingsdata nodig.

# V0 Modelgedrag & Beperkingen

Vroege prompts laten het model reageren met taalgebruik en gedrag uit de 19e eeuw. Bijvoorbeeld, ik gaf de prompt "Who art Henry?" en het antwoordde "I know that man, I have did not a black, the storm." en ja, die zin slaat nergens op maar de LLM herkent dat ik naar een persoon vraag.

![TimeLockLLM Voorbeeldoutput](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

Er wordt geen melding gemaakt van moderne concepten, de output bevat voornamelijk woorden en zinswendingen uit de 19e eeuw.

Het heeft nog veel werk nodig, trainen op 187MB levert geen model op dat tekst met complexe redenering kan produceren.

Op dit moment produceert het zinnen die niet volledig gestructureerd zijn en over het algemeen nergens op slaan, maar dit is normaal voor deze trainingsgrootte.

# V0.5 Modelgedrag & Beperkingen

Dit is een mooie verbetering ten opzichte van het vorige model. De schrijfstijl en woordenschat zijn Victoriaans en bijna elke zin is grammaticaal correct met juiste interpunctie. En opnieuw, het is getraind vanaf nul dus het blijft bij onderwerpen uit de 19e eeuw.

![TimeLockLLM Voorbeeldoutput](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

Er zijn veel feitelijke hallucinaties. Heel veel (zoals 100%) van de details (data, gebeurtenissen, historische figuren) zijn verzonnen. Ook hebben de zinnen niet echt een samenhang; soms zijn misschien 2 zinnen aan elkaar gerelateerd maar verder niet. Een ander probleem is dat soms een verdwaalde “Digitized by Google” footer opduikt, dus de volgende keer dat ik train moet ik echt zorgen dat de teksten goed opgeschoond zijn. Al met al ben ik erg blij met de resultaten, het is nog lang geen LLM maar beslist een zinnen-generator.

Ik leer veel en ga de komende weken uitzoeken wat ik beter moet doen. Ik zal binnenkort bestanden uploaden!

# Komende Plannen

(Gereed) Ik ga beginnen aan versie 0.5, in plaats van 50 boeken te gebruiken voor training, wil ik idealiter 500-600 gebruiken. Op dit moment train ik nanoGPT met boeken uit 1800-1850 en specifiek uit Londen. Er zijn wat uitdagingen, zoals ervoor zorgen dat de boeken die ik vind niet zijn bijgewerkt of moderne interpretaties bevatten, maar onaangetaste boeken die binnen mijn gekozen periode zijn gepubliceerd.

Ik wil een nieuw model (v1) trainen met een veel grotere corpus, misschien 5-10x groter dan die ik voor v0.5 gebruikte. Mijn doel is om te kijken of redeneringsvermogen kan ontstaan uit alleen Selective Temporal Training, dit wordt een moeilijkere taak en ik weet niet zeker of het mogelijk is vanwege historische databeperkingen. In de komende weken zal ik proberen genoeg data te verzamelen voor een 5-10GB corpus. Ik geloof dat als ik schone, hoogwaardige data kan krijgen en een GPU kan huren, er voortgang zal zijn.

# Hoe Dit Project Te Gebruiken

Dit project richt zich voornamelijk op het verzamelen van historische data, het voorbereiden voor training en het bouwen van een tokenizer. Ik ga het volledige LLM-trainingsproces niet behandelen, daarvoor verwijs ik naar nanoGPT van Andrej Karpathy.

# Stap 1: Verzamel en Bereid Historische Teksten Voor

Verzamel .txt-bestanden van boeken, documenten, enz. uit het publieke domein uit de door jou gekozen periode (bijv. Londen 1800-1850)

Je kunt download_texts_improved.py gebruiken om boeken te downloaden als je dat nodig hebt.

Maak de tekstbestanden schoon met een script of verwijder handmatig headers/footers van Project Gutenberg, moderne annotaties of dingen zoals OCR-fouten.

prepare_dataset.py zou prima moeten werken.

# Stap 2: Bouw een Aangepaste Tokenizer

Voer train_tokenizer.py of train_tokenizer_hf.py uit op de opgeschoonde data.
Dit levert je vocab.json en merges.txt op

Deze bestanden definiëren de woordenschat en samenvoegregels voor je model

# Stap 3: Train Je Model (nanoGPT)

Raadpleeg [nanoGPT van Andrej Karpathy](https://github.com/karpathy/nanoGPT) voor het trainingsproces.

Je kunt een ander LLM trainen als je wilt, maar ik heb nanoGPT gebruikt

# FAQ

## Wat is Selective Temporal Training?

Selective Temporal Training (STT) is een machine learning-methodologie waarbij alle trainingsdata specifiek wordt geselecteerd binnen een bepaalde historische periode. Dit gebeurt om de taal en kennis van dat tijdperk te modelleren zonder invloed van moderne concepten. Bijvoorbeeld: het huidige model dat ik heb (v0.5) is uitsluitend getraind op data uit 1800-1875, het is niet fijn-getuned maar vanaf nul getraind met als resultaat een output die de linguïstische stijl en historische context van die periode weerspiegelt.

## Waarom niet gewoon fine-tuning of LoRA gebruiken?

Voor dit project probeer ik een taalmodel te maken dat niet wordt vertroebeld door moderne vooringenomenheid. Als ik bijvoorbeeld GPT-2 fine-tune, is het al voorgetraind en die informatie verdwijnt niet. Als ik vanaf nul train zal het taalmodel zich niet voordoen als oud, het zal het daadwerkelijk zijn. Het doel voor dit project is nu om iets te creëren dat uitsluitend kan redeneren met kennis uit Londense boeken gepubliceerd tussen 1800 en 1850.

## Wat voor data heb je gebruikt voor training?

Ik gebruik boeken, juridische documenten, kranten en andere geschriften uit Londen van 1800–1850. De lijst die ik heb gelinkt bevat er ongeveer 200, maar voor de eerste training heb ik slechts 50 bestanden gebruikt, ongeveer ~187 MB. Je kunt een lijst van de documenten bekijken:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## Hoe groot is het Versie 0-model?

Dit model is nu erg klein, ik doe dit voor de lol en volg een strikte trainingsregel van geen moderne bronnen. Het heeft bijna 16 miljoen parameters maar ik ga beginnen met het verzamelen van meer oude teksten om een nieuw model te trainen. Ik zal updates geven naarmate ik vorder.

## Trainingsspecificaties?

GPU: Geforce rtx 4060
CPU: i5-13400F
Ram: 16GB DDR5.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-07

---