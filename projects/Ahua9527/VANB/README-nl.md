# VANB (Video Audio Network Bridge)
# VANB (Video Assistant NDI Bridge)
# VANB (Wauw!! NB)

VANB is een op GStreamer gebaseerd video/audio stream conversiehulpmiddel, dat bidirectionele conversie ondersteunt tussen de NDI- en RTMP-protocollen. Het stelt je in staat om NDI-bronnen naar een RTMP-server te streamen, of een RTMP-stream om te zetten naar NDI-uitvoer.

Dit project is open source onder de [GPL-3.0](https://www.gnu.org/licenses/gpl-3.0.html) licentie.

## Ondersteunde platforms

Momenteel worden voornamelijk de volgende platforms ondersteund:
- macOS (Apple Silicon)

## Systeemeisen

### Systeemafhankelijkheden
- [GStreamer 1.24+](https://gstreamer.freedesktop.org)
- [NewTek NDI SDK](https://www.ndi.tv/sdk/)

### Installatiestappen
1. Installeer [NewTek NDI SDK](https://www.ndi.tv/sdk/)

2. Installeer GStreamer via Homebrew
```bash
brew install --cask --zap gstreamer-development
```

3. Clone de projectrepository
```bash
git clone https://github.com/Ahua9527/VANB.git
cd VANB
```

4. Installeer Python-afhankelijkheden
```bash
pip install -r requirements.txt
```

5. Configureer omgevingsvariabelen (zie .env-bestand als referentie)
```bash
# Configureer NDI SDK pad
export NDI_SDK_PATH=/Library/NDI SDK for Apple
# Configureer GStreamer plug-in pad
export GST_PLUGIN_PATH=/opt/homebrew/lib/gstreamer-1.0:${NDI_SDK_PATH}/lib/macOS
export DYLD_LIBRARY_PATH=/opt/homebrew/lib:${NDI_SDK_PATH}/lib/macOS
export GI_TYPELIB_PATH=/opt/homebrew/lib/girepository-1.0:/usr/local/lib/girepository-1.0
```

## Gebruik

### NDI naar RTMP (zendende kant)
```bash
python vanb_tx.py
```
Het programma scant automatisch beschikbare NDI-bronnen en vraagt je om het RTMP-streamadres in te voeren.

### RTMP naar NDI (ontvangende kant)
```bash
python vanb_rx.py
```
Na het invoeren van het RTMP-afspeeladres maakt het programma automatisch een nieuwe NDI-uitvoer aan.

## Ontwikkelstatus

### Gerealiseerde functies
- ✓ Conversie van NDI naar RTMP
- ✓ Conversie van RTMP naar NDI
- ✓ Automatische framerate- en resolutieaanpassing
- ✓ Audio- en videosynchronisatie
- ✓ Automatische scanning van NDI-bronnen
- ✓ Automatische naamgeving van NDI-uitvoer
- ✓ VideoToolbox hardware-encoding en -decoding

### Te implementeren functies
- ⨯ Ondersteuning voor configuratiebestanden (Profile/config.json)
  - Invoer- en uitvoerparameters regelen via een configuratiebestand
  - Ondersteuning voor meerdere transcodering preset-configuraties
  - Configureerbare bufferomvang en vertraging
  - Ondersteuning voor kwaliteits- en prestatiebalans van transcodering
- ⨯ Meerdere gelijktijdige streamverwerking

## Licentieverklaring

⚠️ **Belangrijk: Licentie en Compliance**

### Softwarelicentie

Dit project is gelicentieerd onder de [GNU General Public License v3.0](https://www.gnu.org/licenses/gpl-3.0.html).

Redenen voor het kiezen van de GPL-3.0 licentie:
1. Dit project gebruikt meerdere GStreamer-plug-ins met GPL-licentie:
   - `x264`: H.264 video-encoder (GPL)
   - `x265`: HEVC/H.265 video-encoder (GPL)
   - `faad`: AAC audio-decoder (GPL)
2. Volgens de copyleft-bepalingen van de GPL moet software die GPL-componenten gebruikt ook onder een GPL-licentie vallen
3. Het kiezen van GPL-3.0 waarborgt compatibiliteit met alle afhankelijkheidslicenties

### Licentie-eisen

Bij het gebruik van dit project moet je aan de volgende eisen voldoen:
1. **Broncode openstellen**: Als je de code van dit project wijzigt of in je eigen project integreert, moet je je volledige broncode openbaar maken
2. **Licentie behouden**: Je project moet de GPL-3.0 licentie blijven gebruiken
3. **Copyrightvermelding**: Je moet de originele copyright- en licentievermelding behouden
4. **Duidelijke wijzigingsaanduiding**: Als je de code wijzigt, moet je je wijzigingen duidelijk aangeven
5. **Octrooiverlening**: GPL-3.0 bevat expliciete octrooiverleningsbepalingen

### GStreamer component licentie
1. Dit project is uitsluitend bedoeld voor ontwikkelings- en testdoeleinden
2. NDI® is een geregistreerd handelsmerk van NewTek, Inc.
3. Voor gebruik van dit project moet je voldoen aan de licentieovereenkomst van de NewTek NDI® SDK
4. Zorg ervoor dat je alle benodigde licenties en toestemmingen hebt voordat je het in productie gebruikt

## Feedback en problemen

Bij problemen:
1. Controleer of de omgevingsvariabelen correct zijn ingesteld
2. Controleer of GStreamer-plug-ins correct zijn geïnstalleerd
3. Bekijk gedetailleerde foutinformatie in het logbestand
4. Geef problemen door via Issues, met bijgevoegd logbestand en omgevingsinformatie

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-17

---