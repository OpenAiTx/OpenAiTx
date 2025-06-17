# VANB (Video Audio Network Bridge)
# VANB (Video Assistant NDI Bridge)
# VANB (哇!! NB)

VANB è uno strumento di conversione flussi video/audio basato su GStreamer, che supporta la conversione bidirezionale tra i protocolli NDI e RTMP. Permette di inviare sorgenti NDI verso un server RTMP oppure di convertire uno stream RTMP in output NDI.

Questo progetto è open source con licenza [GPL-3.0](https://www.gnu.org/licenses/gpl-3.0.html).

## Piattaforme supportate

Attualmente sono principalmente supportate le seguenti piattaforme:
- macOS (Apple Silicon)

## Requisiti ambientali

### Dipendenze di sistema
- [GStreamer 1.24+](https://gstreamer.freedesktop.org)
- [NewTek NDI SDK](https://www.ndi.tv/sdk/)

### Passaggi di installazione
1. Installa [NewTek NDI SDK](https://www.ndi.tv/sdk/)

2. Installa GStreamer tramite Homebrew
```bash
brew install --cask --zap gstreamer-development
```

3. Clona il repository del progetto
```bash
git clone https://github.com/Ahua9527/VANB.git
cd VANB
```

4. Installa le dipendenze Python
```bash
pip install -r requirements.txt
```

5. Configura le variabili d’ambiente (consulta il file .env)
```bash
# Configura il percorso NDI SDK
export NDI_SDK_PATH=/Library/NDI SDK for Apple
# Configura il percorso dei plugin GStreamer
export GST_PLUGIN_PATH=/opt/homebrew/lib/gstreamer-1.0:${NDI_SDK_PATH}/lib/macOS
export DYLD_LIBRARY_PATH=/opt/homebrew/lib:${NDI_SDK_PATH}/lib/macOS
export GI_TYPELIB_PATH=/opt/homebrew/lib/girepository-1.0:/usr/local/lib/girepository-1.0
```

## Modalità d’uso

### NDI a RTMP (trasmittente)
```bash
python vanb_tx.py
```
Il programma eseguirà automaticamente la scansione delle sorgenti NDI disponibili e richiederà l’inserimento dell’indirizzo di streaming RTMP.

### RTMP a NDI (ricevente)
```bash
python vanb_rx.py
```
Dopo aver inserito l’indirizzo di pull RTMP, il programma creerà automaticamente un nuovo output NDI.

## Stato di sviluppo

### Funzionalità implementate
- ✓ Conversione da NDI a RTMP
- ✓ Conversione da RTMP a NDI
- ✓ Adattamento automatico di frame rate e risoluzione
- ✓ Sincronizzazione audio-video
- ✓ Scansione automatica delle sorgenti NDI
- ✓ Denominazione automatica dell’output NDI
- ✓ Codifica/decodifica hardware VideoToolbox

### Funzionalità da implementare
- ⨯ Supporto file di configurazione (Profile/config.json)
  - Controllo dei parametri di input/output tramite file di configurazione
  - Supporto a diversi preset di transcodifica
  - Configurabilità di dimensione buffer e parametri di latenza
  - Supporto a configurazione di qualità/performance della transcodifica
- ⨯ Gestione di flussi multipli in parallelo

## Dichiarazione di licenza

⚠️ **Avviso importante: Licenza e conformità**

### Licenza software

Questo progetto è distribuito con licenza [GNU General Public License v3.0](https://www.gnu.org/licenses/gpl-3.0.html).

Motivazioni della scelta della licenza GPL-3.0:
1. Questo progetto utilizza diversi plugin GStreamer rilasciati con licenza GPL:
   - `x264`: codificatore video H.264 (GPL)
   - `x265`: codificatore video HEVC/H.265 (GPL)
   - `faad`: decodificatore audio AAC (GPL)
2. In base alle clausole di contaminazione della GPL, il software che utilizza componenti GPL deve anch’esso adottare la licenza GPL
3. Scegliere la GPL-3.0 assicura la compatibilità con tutte le licenze dei componenti dipendenti

### Requisiti della licenza

Quando usi questo progetto, devi rispettare i seguenti requisiti:
1. **Codice open source**: Se modifichi il codice di questo progetto o lo integri nel tuo, devi rendere open source l’intero codice sorgente
2. **Mantenere la licenza**: Il tuo progetto deve continuare a utilizzare la licenza GPL-3.0
3. **Dichiarazione di copyright**: Devi mantenere la dichiarazione di copyright originale e la dichiarazione di licenza
4. **Evidenziazione delle modifiche**: Se modifichi il codice, devi evidenziare chiaramente le modifiche apportate
5. **Autorizzazione ai brevetti**: La GPL-3.0 include clausole esplicite di autorizzazione ai brevetti

### Licenza dei componenti GStreamer
1. Questo progetto è destinato solo a scopo di sviluppo e test
2. NDI® è un marchio registrato di NewTek, Inc.
3. L’utilizzo di questo progetto richiede il rispetto dell’accordo di licenza NewTek NDI® SDK
4. Prima di usarlo in produzione, assicurati di aver ottenuto tutte le licenze e autorizzazioni necessarie

## Segnalazione problemi

In caso di problemi, procedi come segue:
1. Controlla che le variabili d’ambiente siano configurate correttamente
2. Verifica che i plugin GStreamer siano installati correttamente
3. Consulta i dettagli degli errori nei file di log
4. Segnala il problema tramite Issues, allegando log e informazioni sull’ambiente

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-17

---