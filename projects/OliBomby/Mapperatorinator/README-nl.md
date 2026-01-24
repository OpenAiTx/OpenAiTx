
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=en">Engels</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=fr">Frans</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=de">Duits</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=es">Spaans</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=it">Italiaans</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=pt">Portugees</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=pl">Pools</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=tr">Turks</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=vi">Vietnamees</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Mapperatorinator

Probeer het generatieve model [hier](https://colab.research.google.com/github/OliBomby/Mapperatorinator/blob/main/colab/mapperatorinator_inference.ipynb), of MaiMod [hier](https://colab.research.google.com/github/OliBomby/Mapperatorinator/blob/main/colab/mai_mod_inference.ipynb). Bekijk een video showcase [hier](https://youtu.be/FEr7t1L2EoA).

Mapperatorinator is een multi-model framework dat spectrogram invoer gebruikt om volledig uitgeruste osu! beatmaps te genereren voor alle gamemodi en [modding van beatmaps te ondersteunen](#maimod-the-ai-driven-modding-tool).
Het doel van dit project is om automatisch osu! beatmaps van rankbare kwaliteit te genereren van elk lied met een hoge mate van aanpasbaarheid.

Dit project is gebouwd op [osuT5](https://github.com/gyataro/osuT5) en [osu-diffusion](https://github.com/OliBomby/osu-diffusion). Voor de ontwikkeling hiervan heb ik ongeveer 2500 uur GPU-rekenkracht besteed over 142 runs op mijn 4060 Ti en gehuurde 4090-instanties via vast.ai.

#### Gebruik dit hulpmiddel op verantwoorde wijze. Vermeld altijd het gebruik van AI in je beatmaps.

## Installatie

De onderstaande instructie stelt je in staat om beatmaps te genereren op je lokale machine, als alternatief kun je het uitvoeren in de cloud met het [colab notebook](https://colab.research.google.com/github/OliBomby/Mapperatorinator/blob/main/colab/mapperatorinator_inference.ipynb).

### 1. Clone de repository

```sh
git clone https://github.com/OliBomby/Mapperatorinator.git
cd Mapperatorinator
```

### 2. (Optioneel) Maak een virtuele omgeving aan

Gebruik Python 3.10, latere versies zijn mogelijk niet compatibel met de afhankelijkheden.

```sh
python -m venv .venv

# In cmd.exe
.venv\Scripts\activate.bat
# In PowerShell
.venv\Scripts\Activate.ps1
# In Linux or MacOS
source .venv/bin/activate
```

### 3. Installeer afhankelijkheden

- Python 3.10
- [Git](https://git-scm.com/downloads)
- [ffmpeg](http://www.ffmpeg.org/)
- [CUDA](https://developer.nvidia.com/cuda-zone) (Voor NVIDIA GPU's) of [ROCm](https://rocmdocs.amd.com/en/latest/Installation_Guide/Installation-Guide.html) (Voor AMD GPU's op linux)
- [PyTorch](https://pytorch.org/get-started/locally/): Zorg ervoor dat je de Get Started-gids volgt zodat je `torch` en `torchaudio` met GPU-ondersteuning installeert. Selecteer de juiste Compute Platform-versie die je in de vorige stap hebt geïnstalleerd.

- en de overige Python-afhankelijkheden:

```sh
pip install -r requirements.txt
```

## Web GUI (Aanbevolen)

Voor een gebruiksvriendelijkere ervaring kunt u de Web UI gebruiken. Deze biedt een grafische interface om generatieparameters te configureren, het proces te starten en de output te monitoren.

### Start de GUI

Navigeer in uw terminal naar de gekloonde `Mapperatorinator`-map en voer uit:

```sh
python web-ui.py
```
Dit zal een lokale webserver starten en de gebruikersinterface automatisch in een nieuw venster openen.

### De GUI gebruiken

- **Configureren:** Stel invoer-/uitvoerpaden in met behulp van de invulvelden en "Bladeren"-knoppen. Pas generatieparameters aan zoals gamemodus, moeilijkheidsgraad, stijl (jaar, mapper-ID, descriptors), timing, specifieke functies (hitsounds, super timing), en meer, overeenkomstig de commandoregelopties. (Opmerking: Als je een `beatmap_path` opgeeft, zal de UI automatisch het `audio_path` en `output_path` hieruit bepalen, zodat je deze velden leeg kunt laten)
- **Starten:** Klik op de knop "Start Inference" om te beginnen met het genereren van de beatmap.
- **Annuleren:** Je kunt het lopende proces stoppen met de knop "Cancel Inference".
- **Uitvoer openen:** Zodra het klaar is, gebruik je de knop "Open Output Folder" voor snelle toegang tot de gegenereerde bestanden.

De Web UI fungeert als een handige wrapper rond het script `inference.py`. Raadpleeg voor geavanceerde opties of probleemoplossing de instructies voor de commandoregel.

![python_u3zyW0S3Vs](https://github.com/user-attachments/assets/5312a45f-d51c-4b37-9389-da3258ddd0a1)

## Commandoregel-inferentie

Voor gebruikers die de voorkeur geven aan de commandoregel of toegang nodig hebben tot geavanceerde configuraties, volg de onderstaande stappen. **Opmerking:** Voor een eenvoudigere grafische interface, zie het gedeelte [Web UI (Aanbevolen)](#web-ui-recommended) hierboven.

Voer `inference.py` uit en geef enkele argumenten mee om beatmaps te genereren. Gebruik hiervoor de [Hydra override-syntax](https://hydra.cc/docs/advanced/override_grammar/basic/). Zie `configs/inference_v29.yaml` voor alle beschikbare parameters.

```
python inference.py \
  audio_path           [Path to input audio] \
  output_path          [Path to output directory] \
  beatmap_path         [Path to .osu file to autofill metadata, and output_path, or use as reference] \
  
  gamemode             [Game mode to generate 0=std, 1=taiko, 2=ctb, 3=mania] \
  difficulty           [Difficulty star rating to generate] \
  mapper_id            [Mapper user ID for style] \
  year                 [Upload year to simulate] \
  hitsounded           [Whether to add hitsounds] \
  slider_multiplier    [Slider velocity multiplier] \
  circle_size          [Circle size] \
  keycount             [Key count for mania] \
  hold_note_ratio      [Hold note ratio for mania 0-1] \
  scroll_speed_ratio   [Scroll speed ratio for mania and ctb 0-1] \
  descriptors          [List of beatmap user tags for style] \
  negative_descriptors [List of beatmap user tags for classifier-free guidance] \
  
  add_to_beatmap       [Whether to add generated content to the reference beatmap instead of making a new beatmap] \
  start_time           [Generation start time in milliseconds] \
  end_time             [Generation end time in milliseconds] \
  in_context           [List of additional context to provide to the model [NONE,TIMING,KIAI,MAP,GD,NO_HS]] \
  output_type          [List of content types to generate] \
  cfg_scale            [Scale of the classifier-free guidance] \
  super_timing         [Whether to use slow accurate variable BPM timing generator] \
  seed                 [Random seed for generation] \
```

Voorbeeld:
```
python inference.py beatmap_path="'C:\Users\USER\AppData\Local\osu!\Songs\1 Kenji Ninuma - DISCO PRINCE\Kenji Ninuma - DISCOPRINCE (peppy) [Normal].osu'" gamemode=0 difficulty=5.5 year=2023 descriptors="['jump aim','clean']" in_context=[TIMING,KIAI]
```

## Interactieve CLI
Voor degenen die een terminal-gebaseerde workflow verkiezen maar toch een begeleide installatie willen, is het interactieve CLI-script een uitstekend alternatief voor de Web UI.

### Start de CLI
Navigeer naar de gekloonde map. Mogelijk moet je het script eerst uitvoerbaar maken.

```sh
# Make the script executable (only needs to be done once)
chmod +x cli_inference.sh
```

```sh
# Run the script
./cli_inference.sh
```

### De CLI gebruiken
Het script leidt je door een reeks prompts om alle generatieparameters te configureren, net als de Web UI.

Het gebruikt een kleurgecodeerde interface voor duidelijkheid.
Het biedt een geavanceerd multi-selectiemenu voor het kiezen van stijlbeschrijvers met je pijltjestoetsen en spatiebalk.
Nadat je alle vragen hebt beantwoord, toont het het uiteindelijke commando ter beoordeling.
Je kunt daarna bevestigen om het direct uit te voeren of annuleren en het commando kopiëren voor handmatig gebruik.

## Generatie-tips

- Je kunt `configs/inference_v29.yaml` bewerken en daar je argumenten toevoegen in plaats van ze telkens in de terminal in te typen.
- Alle beschikbare beschrijvers zijn te vinden [hier](https://osu.ppy.sh/wiki/en/Beatmap/Beatmap_tags).
- Geef altijd een jaartal tussen 2007 en 2023 op. Als je dit onbekend laat, kan het model met een inconsistente stijl genereren.
- Geef altijd een moeilijkheidsgraad op. Als je dit onbekend laat, kan het model met een inconsistente moeilijkheidsgraad genereren.
- Verhoog de `cfg_scale` parameter om de effectiviteit van de `mapper_id` en `descriptors` argumenten te vergroten.
- Je kunt het argument `negative_descriptors` gebruiken om het model van bepaalde stijlen weg te sturen. Dit werkt alleen als `cfg_scale > 1`. Zorg dat het aantal negatieve beschrijvers gelijk is aan het aantal beschrijvers.
- Als de stijl van je liedje en de gewenste beatmapstijl niet goed overeenkomen, volgt het model mogelijk je aanwijzingen niet. Het is bijvoorbeeld moeilijk om een hoge SR, hoge SV beatmap te genereren voor een rustig liedje.
- Als je al timing- en kiai-tijden hebt voor een nummer, kun je deze aan het model geven om de inferentiesnelheid en nauwkeurigheid sterk te verhogen: Gebruik de argumenten `beatmap_path` en `in_context=[TIMING,KIAI]`.
- Om slechts een deel van je beatmap opnieuw te maken, gebruik je de argumenten `beatmap_path`, `start_time`, `end_time` en `add_to_beatmap=true`.
- Om een gastmoeilijkheid voor een beatmap te genereren, gebruik je de argumenten `beatmap_path` en `in_context=[GD,TIMING,KIAI]`.
- Om hitsounds voor een beatmap te genereren, gebruik je de argumenten `beatmap_path` en `in_context=[NO_HS,TIMING,KIAI]`.
- Om alleen timing voor een nummer te genereren, gebruik je de argumenten `super_timing=true` en `output_type=[TIMING]`.

## MaiMod: De AI-gedreven Modding Tool

MaiMod is een moddingtool voor osu! beatmaps die Mapperatorinator-voorspellingen gebruikt om potentiële fouten en inconsistenties te vinden die niet door andere automatische moddingtools zoals [Mapset Verifier](https://github.com/Naxesss/MapsetVerifier) kunnen worden gedetecteerd.
Het kan problemen detecteren zoals:
- Onjuiste snapping of ritmepatronen
- Onnauwkeurige timingpunten
- Inconsistente posities van hitobjecten of nieuwe combo-plaatsingen
- Vreemde slider-vormen
- Inconsistente hitsounds of volumes

Je kunt MaiMod [hier](https://colab.research.google.com/github/OliBomby/Mapperatorinator/blob/main/colab/mai_mod_inference.ipynb) proberen, of het lokaal draaien:
Om MaiMod lokaal uit te voeren, moet je Mapperatorinator installeren. Voer daarna het script `mai_mod.py` uit en specificeer het pad naar je beatmap met het argument `beatmap_path`.
```sh
python mai_mod.py beatmap_path="'C:\Users\USER\AppData\Local\osu!\Songs\1 Kenji Ninuma - DISCO PRINCE\Kenji Ninuma - DISCOPRINCE (peppy) [Normal].osu'"
```
Dit zal de modding suggesties naar de console printen, die je vervolgens handmatig op je beatmap kunt toepassen.
Suggesties worden chronologisch gerangschikt en gegroepeerd in categorieën.
De eerste waarde in de cirkel geeft de 'surprisal' aan, wat een maat is voor hoe onverwacht het model het probleem vond, zodat je de belangrijkste problemen kunt prioriteren.

Het model kan fouten maken, vooral bij problemen met een lage surprisal, dus controleer altijd de suggesties voordat je ze toepast op je beatmap.
Het belangrijkste doel is om je te helpen de zoekruimte voor potentiële problemen te verkleinen, zodat je niet elk afzonderlijk hit-object in je beatmap handmatig hoeft te controleren.

### MaiMod GUI
Om de MaiMod Web UI uit te voeren, moet je Mapperatorinator installeren.
Voer vervolgens het script `mai_mod_ui.py` uit. Dit zal een lokale webserver starten en automatisch de UI in een nieuw venster openen:

```sh
python mai_mod_ui.py
```

<img width="850" height="1019" alt="afbeelding" src="https://github.com/user-attachments/assets/67c03a43-a7bd-4265-a5b1-5e4d62aca1fa" />

## Overzicht

### Tokenisatie

Mapperatorinator zet osu! beatmaps om in een intermediaire evenementrepresentatie die direct omgezet kan worden naar en van tokens.
Het bevat hitobjecten, hitsounds, slidervelociteiten, nieuwe combinaties, timingpunten, kiai-tijden en taiko/mania scrollsnelheden.

Hier is een klein voorbeeld van het tokenisatieproces:

![mapperatorinator_parser](https://github.com/user-attachments/assets/84efde76-4c27-48a1-b8ce-beceddd9e695)

Om het vocabulaire te beperken, worden tijdgebeurtenissen gekwantiseerd naar intervallen van 10 ms en positiecoördinaten naar rasterpunten van 32 pixels.

### Modelarchitectuur
Het model is in feite een wrapper rond het [HF Transformers Whisper](https://huggingface.co/docs/transformers/en/model_doc/whisper#transformers.WhisperForConditionalGeneration) model, met aangepaste inputembeddings en verliesfunctie.
De modelgrootte bedraagt 219M parameters.
Dit model bleek sneller en nauwkeuriger te zijn dan T5 voor deze taak.

Het algemene overzicht van de input-output van het model is als volgt:

![Picture2](https://user-images.githubusercontent.com/28675590/201044116-1384ad72-c540-44db-a285-7319dd01caad.svg)

Het model gebruikt Mel-spectrogramframes als encoderinput, met één frame per inputpositie. De decoderoutput van het model is bij elke stap een softmaxverdeling over een discrete, vooraf gedefinieerde, vocabulaire van gebeurtenissen. Uitvoer is schaars; gebeurtenissen zijn alleen nodig wanneer een hitobject voorkomt, in plaats van het annoteren van elk afzonderlijk audiokader.

### Multitask-trainingsformaat

![Multitask training format](https://github.com/user-attachments/assets/62f490bc-a567-4671-a7ce-dbcc5f9cd6d9)

Voor de SOS-token staan extra tokens die conditionele generatie vergemakkelijken. Deze tokens omvatten de spelmodus, moeilijkheidsgraad, mapper-ID, jaar en andere metadata.
Tijdens het trainen hebben deze tokens geen bijbehorende labels, dus worden ze nooit door het model uitgegeven.
Ook tijdens het trainen is er een willekeurige kans dat een metadatadoken wordt vervangen door een 'onbekend' token, zodat we tijdens inferentie deze 'onbekend'-tokens kunnen gebruiken om de hoeveelheid metadata die we aan het model moeten geven te verminderen.

### Naadloze lange generatie

De contextlengte van het model is 8.192 seconden. Dit is uiteraard niet genoeg om een volledige beatmap te genereren, dus moeten we het nummer opdelen in meerdere vensters en de beatmap in kleine delen genereren.
Om ervoor te zorgen dat de gegenereerde beatmap geen zichtbare naden tussen vensters heeft, gebruiken we een overlap van 90% en genereren we de vensters sequentieel.
Elk generatievenster behalve het eerste begint met een decoder die tot 50% van het generatievenster is voorgevuld met tokens uit de vorige vensters.
We gebruiken een logit-processor om ervoor te zorgen dat het model geen tijdtokens kan genereren die in de eerste 50% van het generatievenster liggen.
Daarnaast is de laatste 40% van het generatievenster gereserveerd voor het volgende venster. Alle gegenereerde tijdtokens in dat bereik worden behandeld als EOS-tokens.
Dit zorgt ervoor dat elk gegenereerd token is gebaseerd op ten minste 4 seconden aan vorige tokens en 3,3 seconden aan toekomstige audio om te anticiperen.

Om offsetdrift tijdens lange generaties te voorkomen, zijn willekeurige offsets toegevoegd aan tijdgebeurtenissen in de decoder tijdens de training.
Dit dwingt het model om timingfouten te corrigeren door naar de onsets in de audio te luisteren, wat resulteert in een consequent nauwkeurige offset.

### Verfijnde coördinaten met diffusie

Positiecoördinaten die door de decoder zijn gegenereerd, worden gekwantiseerd naar 32 pixel rasterpunten, dus gebruiken we daarna diffusie om de coördinaten naar de uiteindelijke posities te denoisen.
Hiervoor hebben we een aangepaste versie van [osu-diffusion](https://github.com/OliBomby/osu-diffusion) getraind die is gespecialiseerd in alleen de laatste 10% van het ruisprogramma, en die de geavanceerdere metadatatokens accepteert die Mapperatorinator gebruikt voor conditionele generatie.

Aangezien het Mapperatorinator-model de SV van sliders uitvoert, is de vereiste lengte van de slider vast ongeacht de vorm van het control point pad.
Daarom proberen we het diffusieproces te sturen om coördinaten te creëren die passen bij de vereiste sliderlengtes.
Dit doen we door na elke stap van het diffusieproces de slider-eindposities opnieuw te berekenen op basis van de vereiste lengte en het huidige control point pad.
Dit betekent dat het diffusieproces geen directe controle heeft over de slider-eindposities, maar ze wel kan beïnvloeden door het control point pad aan te passen.

### Post-processing

Mapperatorinator voert extra nabewerking uit om de kwaliteit van de gegenereerde beatmap te verbeteren:

- Verfijn positiecoördinaten met diffusie.
- Resnap tijdgebeurtenissen naar de dichtstbijzijnde tick met behulp van de snapverdelers die door het model zijn gegenereerd.
- Snap bijna-perfecte positionele overlappingen.
- Zet mania columnevenementen om naar X-coördinaten.
- Genereer sliderpaden voor taiko drumrolls.
- Corrigeer grote discrepanties tussen vereiste sliderlengte en control point pad lengte.

### Super timing generator

Super timing generator is een algoritme dat de precisie en nauwkeurigheid van gegenereerde timing verbetert door timing voor het hele lied 20 keer af te leiden en het resultaat te middelen.
Dit is nuttig voor nummers met variabele BPM, of nummers met BPM-wijzigingen. Het resultaat is bijna perfect, met soms slechts een sectie die handmatige aanpassing vereist.

## Training

De onderstaande instructie maakt een trainingsomgeving aan op je lokale computer.

### 1. Clone de repository

```sh
git clone https://github.com/OliBomby/Mapperatorinator.git
cd Mapperatorinator
```

### 2. Maak dataset aan

Maak je eigen dataset aan met behulp van de [Mapperator console-app](https://github.com/mappingtools/Mapperator/blob/master/README.md#create-a-high-quality-dataset). Hiervoor heb je een [osu! OAuth client token](https://osu.ppy.sh/home/account/edit) nodig om beatmaps te verifiëren en extra metadata op te halen. Plaats de dataset in een `datasets`-map naast de `Mapperatorinator`-map.

```sh
Mapperator.ConsoleApp.exe dataset2 -t "/Mapperatorinator/datasets/beatmap_descriptors.csv" -i "path/to/osz/files" -o "/datasets/cool_dataset"
```

### 3. (Optioneel) Stel Weight & Biases in voor logging
Maak een account aan op [Weight & Biases](https://wandb.ai/site) en haal je API-sleutel op uit je accountinstellingen.
Stel vervolgens de `WANDB_API_KEY` omgevingsvariabele in, zodat het trainingsproces weet dat er op deze sleutel gelogd moet worden.

```sh
export WANDB_API_KEY=<your_api_key>
```

### 4. Maak een docker container
Training in je venv is ook mogelijk, maar we raden aan Docker op WSL te gebruiken voor betere prestaties.
```sh
docker compose up -d --force-recreate
docker attach mapperatorinator_space
cd Mapperatorinator
```

### 5. Configureer parameters en start de training

Alle configuraties zijn te vinden in `./configs/train/default.yaml`.
Zorg ervoor dat je het juiste `train_dataset_path` en `test_dataset_path` instelt naar jouw dataset, evenals de start- en eindindices van de mapset voor de train/test split.
Het pad is lokaal voor de dockercontainer, dus als je jouw dataset genaamd `cool_dataset` in de `datasets`-directory hebt geplaatst, moet het `/workspace/datasets/cool_dataset` zijn.

Ik raad aan om een aangepast configuratiebestand te maken dat de standaardconfiguratie overschrijft, zodat je een overzicht hebt van je trainingsconfiguratie voor reproduceerbaarheid.

```yaml
data:
  train_dataset_path: "/workspace/datasets/cool_dataset"
  test_dataset_path: "/workspace/datasets/cool_dataset"
  train_dataset_start: 0
  train_dataset_end: 90
  test_dataset_start: 90
  test_dataset_end: 100
```

Begin training by calling `python osuT5/train.py` or `torchrun --nproc_per_node=NUM_GPUS osuT5/train.py` for multi-GPU training.


```sh
python osuT5/train.py -cn train_v29 train_dataset_path="/workspace/datasets/cool_dataset" test_dataset_path="/workspace/datasets/cool_dataset" train_dataset_end=90 test_dataset_start=90 test_dataset_end=100
```

### 6. LoRA-finetuning

Je kunt ook een voorgetraind model fijn afstemmen met [LoRA](https://arxiv.org/abs/2106.09685) om het aan te passen aan een specifieke stijl of gamemodus.
Hiervoor pas je `configs/train/lora.yaml` aan naar jouw wensen en start je de `lora` trainingsconfiguratie:

```sh
python osuT5/train.py -cn lora train_dataset_path="/workspace/datasets/cool_dataset" test_dataset_path="/workspace/datasets/cool_dataset" train_dataset_end=90 test_dataset_start=90 test_dataset_end=100
```

Belangrijke LoRA-parameters om te overwegen:
- `pretrained_path`: Pad of HF-repository van het basismodel om te fine-tunen.
- `r`: Rang van de LoRA-matrices. Hogere waarden verhogen de modelcapaciteit maar ook het geheugengebruik.
- `lora_alpha`: Schaalfactor voor de LoRA-updates.
- `total_steps`: Totaal aantal trainingsstappen. Stem dit af op de grootte van je dataset.
- `enable_lora`: Of LoRA of volledige model fine-tuning wordt gebruikt.

Tijdens inferentie kun je de LoRA-gewichten specificeren met het argument `lora_path`.
Dit kan een lokaal pad of een Hugging Face-repository zijn.

## Zie ook
- [Mapper Classifier](https://raw.githubusercontent.com/OliBomby/Mapperatorinator/main/./classifier/README.md)
- [RComplexion](https://raw.githubusercontent.com/OliBomby/Mapperatorinator/main/./rcomplexion/README.md)

## Credits

Speciale dank aan:
1. De auteurs van [osuT5](https://github.com/gyataro/osuT5) voor hun trainingscode.
2. Het Hugging Face-team voor hun [tools](https://huggingface.co/docs/transformers/index).
3. [Jason Won](https://github.com/jaswon) en [Richard Nagyfi](https://github.com/sedthh) voor het uitwisselen van ideeën.
4. [Marvin](https://github.com/minetoblend) voor het doneren van trainingscredits.
5. De osu!-gemeenschap voor de beatmaps.

## Gerelateerde werken

1. [osu! Beatmap Generator](https://github.com/Syps/osu_beatmap_generator) door Syps (Nick Sypteras)
2. [osumapper](https://github.com/kotritrona/osumapper) door kotritrona, jyvden, Yoyolick (Ryan Zmuda)
3. [osu-diffusion](https://github.com/OliBomby/osu-diffusion) door OliBomby (Olivier Schipper), NiceAesth (Andrei Baciu)
4. [osuT5](https://github.com/gyataro/osuT5) door gyataro (Xiwen Teoh)
5. [Beat Learning](https://github.com/sedthh/BeatLearning) door sedthh (Richard Nagyfi)
6. [osu!dreamer](https://github.com/jaswon/osu-dreamer) door jaswon (Jason Won)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-24

---