
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
Een LLM die uitsluitend is getraind op gegevens uit bepaalde tijdsperiodes om moderne bias te verminderen.

Stel je voor dat een AI-model niet alleen deed alsof het historisch was, maar het echt was.

Gebouwd op [nanoGPT door Andrej Karpathy](https://github.com/karpathy/nanoGPT). De kerntrainingsscripts en modelarchitectuur zijn zijn werk.

# Projectdoelen
TimeCapsule LLM is een experimenteel project dat alleen zal worden getraind op teksten geschreven tijdens bepaalde tijdsperiodes. Het doel is om het wereldbeeld en de taal van specifieke historische tijdperken te simuleren.

# Waarom fine tuning niet genoeg is

Als je alleen een voorgetraind model fine-tunet, zal je LLM nog steeds moderne concepten kennen. Natuurlijk is het bereiken van nul moderne bias moeilijk, maar ik wil hier zo dicht mogelijk bij komen. Geen moderne bias krijgen vereist het trainen van een model vanaf nul.

# Verwachte resultaten

Hopelijk weet dit model, als het klaar is, geen moderne concepten en kan het niet redeneren buiten wat het is getraind op. Het zou moderne concepten/vocabulaire niet moeten herkennen en zou geen moderne kennis mogen hallucineren.

# Voortgangsupdates

## 9 juli 2025

Ik heb mijn tijdsperiode ingesteld op 1800-1850 en regio: Londen

Ik heb een lijst met teksten, boeken, documenten verzameld

Tot nu toe heb ik er 50 als txt-bestanden en ga binnenkort beginnen met trainen op NanoGPT

Zal dit bijwerken zolang er voortgang wordt geboekt

## 13 juli 2025

NanoGPT getraind met 187MB aan historische tekstdata.

## 15 juli 2025

Ik ben begonnen met het downloaden van teksten voor de tweede trainingsronde. Ik haal alles van Internet Archive en heb de tijdsperiode uitgebreid naar 1800-1875. Om een diverse reeks teksten te krijgen, kun je onderwerp- en zoekfilters gebruiken voor publicatielocatie, tijdsperiode en onderwerpen op Internet Archive.

![Zoekfilters](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 16 juli 2025

Ik heb ongeveer 500 txt-bestanden gedownload van Internet Archive en na het opschonen (alleen witruimtes, Gutenberg-headers, enz. verwijderen) heb ik ongeveer 500MB aan data. Het is een kleine dataset, maar de vorige keer trainde ik op 187MB dus er zou ten minste een merkbaar verschil in output moeten zijn zodra ik het tweede model train. Ik hoop dat dit model in ieder geval meer samenhangende zinnen kan produceren die enigszins logisch zijn. Dat is natuurlijk geen garantie, want het blijft een erg kleine dataset, maar het is meer dan wat ik de vorige keer gebruikte.

Dit zou op mijn eigen hardware moeten lukken, dat is ook goed omdat ik hopelijk enige verbetering kan zien voordat ik overstap op een grotere dataset, waarvoor ik een GPU zou moeten huren. Maar maak je geen zorgen, ik ben nog steeds van plan om binnenkort een GPU te huren, maar voordat ik dat doe wil ik mijn dataset zo goed mogelijk gecureerd en opgeschoond hebben. Een van de problemen die ik heb is het opschonen; veel van deze txt-bestanden bevatten onzin ertussen. De scripts die ik heb gebruikt voor het opschonen werken wel, maar zijn niet 100% effectief.

Ik ga deze dataset vandaag trainen en het zal ongeveer 4-5 uur duren. Zodra het klaar is en ik het test, zal ik updates geven. Nogmaals bedankt aan iedereen die mijn project bekijkt, ik heb zelfs van mensen links gekregen naar OCR-bronnen dus dankjewel! Ik hoop dat meer mensen dit proberen en experimenteren met hun eigen datasets.


## 12 augustus 2025

Versie 1 is voltooid, deze versie gebruikt Phi 1.5 (700M parameters) en is getraind op een dataset met bijna 7000 teksten. De belangrijkste verbetering van dit model is zijn vermogen om soms echte namen en historische gebeurtenissen te refereren. Versie 0 en 0.5 konden dit niet, als ik die modellen bijvoorbeeld promptte met "In het jaar 1821" was de output gewoon hallucinaties, dingen die nooit gebeurd zijn. Een voorbeeld hiervan met Versie 1:

Mijn prompt: Het was het jaar onzes Heren 1834,

De output: "Het was het jaar onzes Heren 1834 en de straten van Londen waren gevuld met protest en petitie. De reden, zoals velen vertelden, was niet gebonden aan het privé, maar had dezelfde dag aangenomen in de dag van Lord Palmerston, het publiek zal een korte verklaring ontvangen van de moeilijkheden waaronder de dag van de wet ons heeft bereikt. Het is zeer betreurenswaardig dat de huidige gebeurtenissen in de wereldgeschiedenis duidelijk zijn en bijgevolg bekend zullen worden. Het is niet waar dat de mannen die zich eerst in het Evangelie te Jeruzalem vestigden zo'n uitgebreide en interessante registratie van welvaart en voorspoed zouden hebben."

Eerst dacht ik dat het toeval was, maar kijk hier eens naar: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)


### Trainingsupdate

Ik begon met trainen op een corpus van 435MB (108 M tokens), het verloopt momenteel vrij soepel. De train loss daalde van 10,9 naar 4,9 in de eerste 2800 iteraties. Ik verwacht dat het ongeveer 8 of 9 uur zal duren om te voltooien. Ik post een nieuwe update zodra het klaar is.

## 17 juli 2025

De training is voltooid voor het tweede model, mijn 4060 deed er ongeveer 8 uur en 40 minuten over (3.900 iters/uur) voor 33.000 iteraties (5 epochs). Eindtrainingsverlies was 3,73. De outputs waren verrassend goed, het genereert nu echt samenhangende zinnen in 19e-eeuwse stijl.

## 28 juli 2025

Ik heb v0.5 geüpload naar Hugging Face, [bekijk het hier](https://huggingface.co/haykgrigorian/TimeCapsuleLLM) als je wilt. Je kunt nu mijn repo downloaden en lokaal uitvoeren. Helaas werkt nanoGPT niet native met HuggingFace, dus je zult het model moeten downloaden en lokaal draaien.

Ook zal ik beginnen met het verzamelen van data voor mijn volgende trainingsronde, ik denk dat ik misschien 5-10x meer data nodig heb om redeneervermogen te bereiken.

## 2 augustus 2025

Ik ga binnenkort beginnen aan Versie 1. Ik zal moeten overstappen van nanoGPT's architectuur naar iets moderners. Ik heb verschillende open-source LLM-architecturen in gedachten, waaronder: OpenLLaMA v3, Phi-2 en Qwen 1.5B. En om de sprong naar V1 te ondersteunen, zal ik zorgvuldig een veel grotere en diverse dataset moeten samenstellen. Ik heb minstens 5GB aan schone trainingsdata nodig.

# V0 Modelgedrag & Beperkingen

Vroege prompts laten zien dat het model reageert met taal en gedrag uit de 19e eeuw. Bijvoorbeeld, ik promptte met "Who art Henry?" en het antwoordde "I know that man, I have did not a black, the storm." en ja die zin slaat nergens op maar de LLM herkent wel dat ik naar een persoon vraag.

![TimeLockLLM Voorbeeldoutput](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

Er is geen sprake van moderne concepten, de outputs bevatten vooral woorden en zinsbouw uit de 19e eeuw.

Het heeft nog veel werk nodig, trainen op 187MB levert geen model op dat tekst met complexe redenatie produceert.

Op dit moment produceert het zinnen die niet volledig gestructureerd zijn en over het algemeen gewoon niet logisch zijn, maar dit is normaal voor de trainingsomvang.

# V0.5 Modelgedrag & Beperkingen

Dit is een mooie verbetering ten opzichte van het vorige model. De schrijfstijl en woordenschat zijn Victoriaans en bijna elke zin is grammaticaal correct met juiste interpunctie. En opnieuw is dit vanaf nul getraind, dus het blijft bij onderwerpen uit de jaren 1800.

![TimeLockLLM Voorbeeldoutput](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

Er zijn veel feitelijke hallucinaties. Heel veel (zoals 100%) van de details (data, gebeurtenissen, historische figuren) zijn verzonnen. Ook hebben de zinnen eigenlijk geen verband met elkaar, soms zijn er misschien 2 zinnen die aan elkaar gerelateerd zijn, maar verder niet. Een ander probleem is dat er soms een verdwaalde “Digitized by Google” voettekst verschijnt, dus de volgende keer dat ik train moet ik er echt op letten dat de teksten goed opgeschoond zijn. Over het algemeen ben ik erg blij met de resultaten, het is nog lang geen LLM maar zeker een zinnen-generator.

Ik leer veel en zal de komende weken gaan uitzoeken wat ik beter moet doen. Ik upload binnenkort bestanden!

# V1 Modelgedrag & Beperkingen

Ik upload binnenkort een voorbeeldoutput en doe ook vergelijkingen tussen de 3 modellen met dezelfde prompt. Ik zal V1 ook uploaden naar huggingface zoals ik met mijn vorige versie deed, je vindt mijn huggingface-account hier: https://huggingface.co/haykgrigorian/TimeCapsuleLLM

# Komende Plannen

(Voltooid) Ik ga beginnen met werken aan versie 0.5, in plaats van te trainen met 50 boeken, train ik idealiter met 500-600. Op dit moment train ik nanoGPT met boeken uit 1800-1850 en specifiek uit Londen. Er zijn wat uitdagingen zoals zorgen dat de boeken die ik vind niet bijgewerkt zijn of moderne interpretaties bevatten, maar onaangetaste boeken die binnen mijn gekozen periode zijn uitgegeven.

Ik wil een nieuw model (v1) trainen met een veel grotere corpus, misschien 5-10x groter dan die ik voor v0.5 gebruikte. Mijn doel is om te zien of er redeneervermogen kan ontstaan uit alleen Selective Temporal Training, dit zal een moeilijkere taak zijn en ik ben er niet eens volledig zeker van of het mogelijk is vanwege de beperkingen van historische data. In de komende weken zal ik proberen genoeg data te verzamelen voor een corpus van 5-10GB. Ik geloof dat als ik schone, hoge kwaliteitsdata kan krijgen en een GPU huur, er vooruitgang zal zijn.

# Hoe Gebruik Je Dit Project

Dit project richt zich vooral op het verzamelen van historische data, het voorbereiden voor training en het bouwen van een tokenizer. Ik ga het volledige LLM-trainingsproces niet behandelen, verwijs daarvoor naar nanoGPT van Andrej Karpathy.

# Stap 1: Verzamel en Bereid Historische Teksten Voor

Verzamel .txt-bestanden van boeken, documenten, etc uit het publieke domein uit je gekozen periode (bijv. Londen 1800-1850)

Je kunt download_texts_improved.py gebruiken om boeken voor je te downloaden als dat nodig is.

Maak de tekstbestanden schoon met een script of verwijder handmatig headers/footers van Project Gutenberg, moderne annotaties of dingen zoals OCR-fouten.

prepare_dataset.py zou prima moeten werken.

# Stap 2: Bouw een Aangepaste Tokenizer

Voer train_tokenizer.py of train_tokenizer_hf.py uit op de opgeschoonde data.
Dit levert vocab.json en merges.txt op.

Deze bestanden definiëren vocabulaire en samenvoegregels voor uw model

# Stap 3: Train Uw Model (nanoGPT)

Raadpleeg [nanoGPT van Andrej Karpathy](https://github.com/karpathy/nanoGPT) voor het trainingsproces.

U kunt een ander LLM trainen als u wilt, maar ik heb nanoGPT gebruikt

# FAQ

## Wat is Selective Temporal Training?

Selective Temporal Training (STT) is een machine learning-methodologie waarbij alle trainingsdata specifiek zijn samengesteld om binnen een bepaald historisch tijdsbestek te vallen. Dit gebeurt om de taal en kennis van die periode te modelleren zonder invloed van moderne concepten. Bijvoorbeeld, het huidige model dat ik nu heb (v0.5) is getraind op data uitsluitend uit 1800-1875, het is niet fijngestemd maar vanaf nul getraind, wat resulteert in output die de linguïstische stijl en historische context van die periode weerspiegelt.

## Waarom niet gewoon fine-tunen of LoRA gebruiken?

Voor dit project probeer ik een taalmodel te maken dat vrij is van moderne bias. Als ik iets als GPT-2 fine-tune, is het al voorgetraind en die informatie verdwijnt niet. Als ik vanaf nul train, zal het taalmodel niet doen alsof het oud is, het zal het gewoon zijn. Het doel voor dit project is nu om iets te maken dat uitsluitend kan redeneren met kennis uit Londense boeken gepubliceerd tussen 1800 en 1850.

## Wat voor soort data heeft u gebruikt voor training?

Ik gebruik boeken, juridische documenten, kranten en andere geschriften uit Londen van 1800–1850. De lijst die ik heb gelinkt bevat ongeveer 200 documenten, maar voor de eerste training heb ik slechts 50 bestanden van ~187 MB gebruikt. U kunt een lijst van de documenten bekijken:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## Hoe groot zijn de modellen?

V0: 16M Parameters

V0.5: 123M Parameters

V1: 700M Parameters

# Trainingsspecificaties?

#V0/V0.5
GPU: Geforce rtx 4060
CPU: i5-13400F
Ram: 16GB DDR5.

#V1
GPU: A100 rented









---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-12

---