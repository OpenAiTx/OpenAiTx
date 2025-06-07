# Stable Diffusion web UI
Een webinterface voor Stable Diffusion, geïmplementeerd met behulp van de Gradio-bibliotheek.

![](screenshot.png)

## Functies
[Gedetailleerde functiedemonstratie met afbeeldingen](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features):
- Originele txt2img- en img2img-modi
- Installatie en uitvoeren met één klik (maar je moet nog steeds python en git installeren)
- Outpainting
- Inpainting
- Kleurschets
- Promptmatrix
- Stable Diffusion Upscale
- Attention, geef delen van de tekst op waar het model meer aandacht aan moet besteden
    - a man in a `((tuxedo))` - zal meer aandacht besteden aan tuxedo
    - a man in a `(tuxedo:1.21)` - alternatieve syntaxis
    - selecteer tekst en druk op `Ctrl+Up` of `Ctrl+Down` (of `Command+Up` of `Command+Down` op MacOS) om automatisch de aandacht voor geselecteerde tekst aan te passen (code bijgedragen door anonieme gebruiker)
- Loopback, img2img-bewerking meerdere keren uitvoeren
- X/Y/Z-plot, een manier om een driedimensionale plot van afbeeldingen te maken met verschillende parameters
- Textual Inversion
    - zoveel embeddings als je wilt en gebruik namen naar keuze
    - gebruik meerdere embeddings met verschillende aantallen vectoren per token
    - werkt met half-precisie floating point getallen
    - train embeddings op 8GB (ook meldingen van werkende 6GB)
- Extra-tabblad met:
    - GFPGAN, neuraal netwerk dat gezichten corrigeert
    - CodeFormer, gezichtshersteltool als alternatief voor GFPGAN
    - RealESRGAN, neuraal netwerk upscaler
    - ESRGAN, neuraal netwerk upscaler met veel externe modellen
    - SwinIR en Swin2SR ([zie hier](https://github.com/AUTOMATIC1111/stable-diffusion-webui/pull/2092)), neurale netwerk upscalers
    - LDSR, Latent Diffusion Super Resolution upscaling
- Opties voor het wijzigen van de beeldverhouding
- Selectie van sampling-methode
    - Pas sampler eta-waarden aan (ruismultiplier)
    - Meer geavanceerde ruisinstellingen
- Verwerking op elk moment onderbreken
- 4GB videokaartondersteuning (ook meldingen van werkende 2GB)
- Correcte seeds voor batches
- Live validatie van prompt-tokenlengte
- Generatieparameters
     - parameters die je gebruikte om afbeeldingen te genereren worden met die afbeelding opgeslagen
     - in PNG-chunks voor PNG, in EXIF voor JPEG
     - je kunt de afbeelding naar het PNG info-tabblad slepen om de generatieparameters te herstellen en automatisch in de UI te kopiëren
     - kan worden uitgeschakeld in de instellingen
     - sleep een afbeelding/tekst-parameters naar de promptbox
- Lees generatieparameters-knop, laadt parameters in promptbox naar UI
- Instellingenpagina
- Willekeurige pythoncode uitvoeren vanuit de UI (moet worden uitgevoerd met `--allow-code` om dit toe te staan)
- Tooltip-hints bij de meeste UI-elementen
- Mogelijkheid om standaard-/min/max/step-waarden voor UI-elementen via tekstconfiguratie aan te passen
- Tiling-ondersteuning, een selectievakje om afbeeldingen te maken die als textuur getegeld kunnen worden
- Voortgangsbalk en live preview van beeldgeneratie
    - Kan een apart neuraal netwerk gebruiken om previews te maken met vrijwel geen VRAM- of rekeneisen
- Negatieve prompt, een extra tekstveld waarin je kunt opsommen wat je niet in de gegenereerde afbeelding wilt zien
- Stijlen, een manier om een deel van de prompt op te slaan en later eenvoudig toe te passen via een dropdown
- Variaties, een manier om dezelfde afbeelding te genereren met kleine verschillen
- Seed-resizing, een manier om dezelfde afbeelding te genereren op een iets andere resolutie
- CLIP-interrogator, een knop die probeert de prompt te raden uit een afbeelding
- Prompt Editing, een manier om de prompt tijdens het genereren aan te passen, bijvoorbeeld starten met een watermeloen en halverwege overschakelen naar een anime-meisje
- Batchverwerking, een groep bestanden verwerken met img2img
- Img2img Alternative, reverse Euler-methode van cross attention control
- Highres Fix, een handige optie om met één klik hoge resolutie-afbeeldingen te produceren zonder de gebruikelijke vervormingen
- Checkpoints direct herladen
- Checkpoint Merger, een tabblad waarmee je tot 3 checkpoints kunt samenvoegen tot één
- [Aangepaste scripts](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Custom-Scripts) met veel uitbreidingen van de community
- [Composable-Diffusion](https://energy-based-model.github.io/Compositional-Visual-Generation-with-Composable-Diffusion-Models/), een manier om meerdere prompts tegelijk te gebruiken
     - scheid prompts met hoofdletters `AND`
     - ondersteunt ook gewichten voor prompts: `a cat :1.2 AND a dog AND a penguin :2.2`
- Geen tokenlimiet voor prompts (originele stable diffusion staat maximaal 75 tokens toe)
- DeepDanbooru-integratie, maakt danbooru-stijl tags voor anime-prompts
- [xformers](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Xformers), grote snelheidswinst voor geselecteerde kaarten: (voeg `--xformers` toe aan commandline args)
- via extensie: [History-tabblad](https://github.com/yfszzx/stable-diffusion-webui-images-browser): afbeeldingen bekijken, direct gebruiken en verwijderen binnen de UI
- Genereer-voor-altijd optie
- Training-tabblad
     - hypernetwerken en embeddings-opties
     - Voorverwerken van afbeeldingen: bijsnijden, spiegelen, autotagging met BLIP of deepdanbooru (voor anime)
- Clip skip
- Hypernetwerken
- Loras (hetzelfde als hypernetwerken maar mooier)
- Een aparte UI waar je, met preview, kunt kiezen welke embeddings, hypernetwerken of Loras je aan je prompt wilt toevoegen
- Mogelijkheid om een andere VAE te laden vanuit het instellingenmenu
- Geschatte voltooiingstijd in de voortgangsbalk
- API
- Ondersteuning voor toegewijd [inpainting-model](https://github.com/runwayml/stable-diffusion#inpainting-with-stable-diffusion) van RunwayML
- via extensie: [Aesthetic Gradients](https://github.com/AUTOMATIC1111/stable-diffusion-webui-aesthetic-gradients), een manier om afbeeldingen te genereren met een specifiek esthetisch karakter door gebruik van clip image embeds (implementatie van [https://github.com/vicgalle/stable-diffusion-aesthetic-gradients](https://github.com/vicgalle/stable-diffusion-aesthetic-gradients))
- [Stable Diffusion 2.0](https://github.com/Stability-AI/stablediffusion) ondersteuning - zie [wiki](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features#stable-diffusion-20) voor instructies
- [Alt-Diffusion](https://arxiv.org/abs/2211.06679) ondersteuning - zie [wiki](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features#alt-diffusion) voor instructies
- Nu zonder slechte letters!
- Checkpoints laden in safetensors-formaat
- Versoepelde resolutiebeperking: de afmetingen van de gegenereerde afbeelding moeten een veelvoud van 8 zijn in plaats van 64
- Nu met een licentie!
- Elementen in de UI herschikken vanuit het instellingenmenu
- [Segmind Stable Diffusion](https://huggingface.co/segmind/SSD-1B) ondersteuning

## Installatie en Uitvoeren
Zorg dat de vereiste [afhankelijkheden](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Dependencies) aanwezig zijn en volg de instructies voor:
- [NVidia](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-NVidia-GPUs) (aanbevolen)
- [AMD](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-AMD-GPUs) GPU's
- [Intel CPU's, Intel GPU's (zowel geïntegreerd als dedicated)](https://github.com/openvinotoolkit/stable-diffusion-webui/wiki/Installation-on-Intel-Silicon) (externe wiki-pagina)
- [Ascend NPU's](https://github.com/wangshuai09/stable-diffusion-webui/wiki/Install-and-run-on-Ascend-NPUs) (externe wiki-pagina)

Je kunt ook online diensten gebruiken (zoals Google Colab):

- [Lijst met online diensten](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Online-Services)

### Installatie op Windows 10/11 met NVidia-GPU's via releasepakket
1. Download `sd.webui.zip` van [v1.0.0-pre](https://github.com/AUTOMATIC1111/stable-diffusion-webui/releases/tag/v1.0.0-pre) en pak de inhoud uit.
2. Voer `update.bat` uit.
3. Voer `run.bat` uit.
> Zie voor meer details [Install-and-Run-on-NVidia-GPUs](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-NVidia-GPUs)

### Automatische installatie op Windows
1. Installeer [Python 3.10.6](https://www.python.org/downloads/release/python-3106/) (Nieuwere versies van Python ondersteunen torch niet), selecteer "Add Python to PATH".
2. Installeer [git](https://git-scm.com/download/win).
3. Download de stable-diffusion-webui repository, bijvoorbeeld door `git clone https://github.com/AUTOMATIC1111/stable-diffusion-webui.git` uit te voeren.
4. Voer `webui-user.bat` uit vanuit Windows Verkenner als normale, niet-beheerder gebruiker.

### Automatische installatie op Linux
1. Installeer de afhankelijkheden:
```bash
# Debian-gebaseerd:
sudo apt install wget git python3 python3-venv libgl1 libglib2.0-0
# Red Hat-gebaseerd:
sudo dnf install wget git python3 gperftools-libs libglvnd-glx
# openSUSE-gebaseerd:
sudo zypper install wget git python3 libtcmalloc4 libglvnd
# Arch-gebaseerd:
sudo pacman -S wget git python3
```
Als je systeem erg nieuw is, moet je python3.11 of python3.10 installeren:
```bash
# Ubuntu 24.04
sudo add-apt-repository ppa:deadsnakes/ppa
sudo apt update
sudo apt install python3.11

# Manjaro/Arch
sudo pacman -S yay
yay -S python311 # niet verwarren met python3.11 package

# Alleen voor 3.11
# Stel dan de env-variabele in in het startscript
export python_cmd="python3.11"
# of in webui-user.sh
python_cmd="python3.11"
```
2. Navigeer naar de map waar je de webui wilt installeren en voer het volgende commando uit:
```bash
wget -q https://raw.githubusercontent.com/AUTOMATIC1111/stable-diffusion-webui/master/webui.sh
```
Of kloon gewoon de repo waar je wilt:
```bash
git clone https://github.com/AUTOMATIC1111/stable-diffusion-webui
```

3. Voer `webui.sh` uit.
4. Bekijk `webui-user.sh` voor opties.

### Installatie op Apple Silicon

Vind de instructies [hier](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Installation-on-Apple-Silicon).

## Bijdragen
Zo voeg je code toe aan deze repo: [Contributing](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Contributing)

## Documentatie

De documentatie is verplaatst van dit README naar de [wiki van het project](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki).

Om Google en andere zoekmachines de wiki te laten doorzoeken, hier een link naar de (niet voor mensen bedoelde) [crawelbare wiki](https://github-wiki-see.page/m/AUTOMATIC1111/stable-diffusion-webui/wiki).

## Credits
Licenties voor gebruikte code zijn te vinden in het scherm `Instellingen -> Licenties` en ook in het bestand `html/licenses.html`.

- Stable Diffusion - https://github.com/Stability-AI/stablediffusion, https://github.com/CompVis/taming-transformers, https://github.com/mcmonkey4eva/sd3-ref
- k-diffusion - https://github.com/crowsonkb/k-diffusion.git
- Spandrel - https://github.com/chaiNNer-org/spandrel implementatie
  - GFPGAN - https://github.com/TencentARC/GFPGAN.git
  - CodeFormer - https://github.com/sczhou/CodeFormer
  - ESRGAN - https://github.com/xinntao/ESRGAN
  - SwinIR - https://github.com/JingyunLiang/SwinIR
  - Swin2SR - https://github.com/mv-lab/swin2sr
- LDSR - https://github.com/Hafiidz/latent-diffusion
- MiDaS - https://github.com/isl-org/MiDaS
- Ideeën voor optimalisaties - https://github.com/basujindal/stable-diffusion
- Cross Attention-laagoptimalisatie - Doggettx - https://github.com/Doggettx/stable-diffusion, origineel idee voor prompt editing.
- Cross Attention-laagoptimalisatie - InvokeAI, lstein - https://github.com/invoke-ai/InvokeAI (oorspronkelijk http://github.com/lstein/stable-diffusion)
- Sub-quadratic Cross Attention-laagoptimalisatie - Alex Birch (https://github.com/Birch-san/diffusers/pull/1), Amin Rezaei (https://github.com/AminRezaei0x443/memory-efficient-attention)
- Textual Inversion - Rinon Gal - https://github.com/rinongal/textual_inversion (we gebruiken zijn code niet, maar wel zijn ideeën).
- Idee voor SD upscale - https://github.com/jquesnelle/txt2imghd
- Ruisgeneratie voor outpainting mk2 - https://github.com/parlance-zz/g-diffuser-bot
- CLIP-interrogator idee en enige code - https://github.com/pharmapsychotic/clip-interrogator
- Idee voor Composable Diffusion - https://github.com/energy-based-model/Compositional-Visual-Generation-with-Composable-Diffusion-Models-PyTorch
- xformers - https://github.com/facebookresearch/xformers
- DeepDanbooru - interrogator voor anime diffusers https://github.com/KichangKim/DeepDanbooru
- Sampling in float32 precisie vanaf een float16 UNet - marunine voor het idee, Birch-san voor het voorbeeld Diffusers-implementatie (https://github.com/Birch-san/diffusers-play/tree/92feee6)
- Instruct pix2pix - Tim Brooks (ster), Aleksander Holynski (ster), Alexei A. Efros (geen ster) - https://github.com/timothybrooks/instruct-pix2pix
- Beveiligingsadvies - RyotaK
- UniPC sampler - Wenliang Zhao - https://github.com/wl-zhao/UniPC
- TAESD - Ollin Boer Bohan - https://github.com/madebyollin/taesd
- LyCORIS - KohakuBlueleaf
- Restart sampling - lambertae - https://github.com/Newbeeer/diffusion_restart_sampling
- Hypertile - tfernd - https://github.com/tfernd/HyperTile
- Initiële Gradio-script - gepost op 4chan door een anonieme gebruiker. Dankjewel, anonieme gebruiker.
- (Jij)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---