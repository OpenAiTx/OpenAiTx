
<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Mapperatorinator

Prova il modello generativo [qui](https://colab.research.google.com/github/OliBomby/Mapperatorinator/blob/main/colab/mapperatorinator_inference.ipynb), o MaiMod [qui](https://colab.research.google.com/github/OliBomby/Mapperatorinator/blob/main/colab/mai_mod_inference.ipynb). Guarda una dimostrazione video [qui](https://youtu.be/FEr7t1L2EoA).

Mapperatorinator è un framework multi-modello che utilizza input spettrogrammi per generare beatmap osu! completamente funzionali per tutte le modalità di gioco e per [supportare la moderazione delle beatmap](#maimod-the-ai-driven-modding-tool).
L’obiettivo di questo progetto è generare automaticamente beatmap osu! di qualità “rankable” da qualsiasi canzone, con un elevato grado di personalizzazione.

Questo progetto si basa su [osuT5](https://github.com/gyataro/osuT5) e [osu-diffusion](https://github.com/OliBomby/osu-diffusion). Per svilupparlo, ho impiegato circa 2500 ore di calcolo GPU in 142 sessioni sulla mia 4060 Ti e istanze 4090 a noleggio su vast.ai.

#### Usa questo strumento responsabilmente. Segnala sempre l’uso dell’IA nelle tue beatmap.

## Installazione

Le istruzioni seguenti ti permettono di generare beatmap sulla tua macchina locale, in alternativa puoi eseguirlo nel cloud tramite il [colab notebook](https://colab.research.google.com/github/OliBomby/Mapperatorinator/blob/main/colab/mapperatorinator_inference.ipynb).

### 1. Clona il repository

```sh
git clone https://github.com/OliBomby/Mapperatorinator.git
cd Mapperatorinator
```

### 2. (Opzionale) Crea un ambiente virtuale

Utilizza Python 3.10, le versioni successive potrebbero non essere compatibili con le dipendenze.

```sh
python -m venv .venv

# In cmd.exe
.venv\Scripts\activate.bat
# In PowerShell
.venv\Scripts\Activate.ps1
# In Linux or MacOS
source .venv/bin/activate
```

### 3. Installa le dipendenze

- Python 3.10
- [Git](https://git-scm.com/downloads)
- [ffmpeg](http://www.ffmpeg.org/)
- [CUDA](https://developer.nvidia.com/cuda-zone) (Per GPU NVIDIA) o [ROCm](https://rocmdocs.amd.com/en/latest/Installation_Guide/Installation-Guide.html) (Per GPU AMD su Linux)
- [PyTorch](https://pytorch.org/get-started/locally/): Assicurati di seguire la guida Get Started per installare `torch` e `torchaudio` con supporto GPU. Seleziona la versione della Compute Platform corretta che hai installato nel passaggio precedente.

- e le restanti dipendenze Python:

```sh
pip install -r requirements.txt
```

## Interfaccia Web GUI (Consigliata)

Per un'esperienza più intuitiva, considera l'utilizzo della Web UI. Essa offre un'interfaccia grafica per configurare i parametri di generazione, avviare il processo e monitorare l'output.

### Avviare la GUI

Naviga nella directory `Mapperatorinator` clonata tramite il tuo terminale ed esegui:

```sh
python web-ui.py
```

Questo avvierà un server web locale e aprirà automaticamente l'interfaccia utente in una nuova finestra.

### Utilizzo della GUI

- **Configura:** Imposta i percorsi di input/output utilizzando i campi del modulo e i pulsanti "Sfoglia". Regola i parametri di generazione come modalità di gioco, difficoltà, stile (anno, ID mapper, descrittori), timing, funzionalità specifiche (hitsounds, super timing) e altro, rispecchiando le opzioni della riga di comando. (Nota: Se fornisci un `beatmap_path`, l'interfaccia utente determinerà automaticamente `audio_path` e `output_path`, quindi puoi lasciare questi campi vuoti)
- **Avvia:** Fai clic sul pulsante "Avvia Inferenza" per iniziare la generazione della beatmap.
- **Annulla:** Puoi interrompere il processo in corso utilizzando il pulsante "Annulla Inferenza".
- **Apri Output:** Una volta terminato, usa il pulsante "Apri Cartella Output" per accedere rapidamente ai file generati.

La Web UI funge da pratico wrapper attorno allo script `inference.py`. Per opzioni avanzate o risoluzione dei problemi, consulta le istruzioni della riga di comando.

![python_u3zyW0S3Vs](https://github.com/user-attachments/assets/5312a45f-d51c-4b37-9389-da3258ddd0a1)

## Inferenza da Riga di Comando

Per gli utenti che preferiscono la riga di comando o necessitano di configurazioni avanzate, seguire i passaggi sotto. **Nota:** Per un'interfaccia grafica più semplice, vedere la sezione [Web UI (Consigliata)](#web-ui-recommended) sopra.

Esegui `inference.py` e passa alcuni argomenti per generare le beatmap. Per questo utilizza la [sintassi di override Hydra](https://hydra.cc/docs/advanced/override_grammar/basic/). Consulta `configs/inference_v29.yaml` per tutti i parametri disponibili.
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

Esempio:
```
python inference.py beatmap_path="'C:\Users\USER\AppData\Local\osu!\Songs\1 Kenji Ninuma - DISCO PRINCE\Kenji Ninuma - DISCOPRINCE (peppy) [Normal].osu'" gamemode=0 difficulty=5.5 year=2023 descriptors="['jump aim','clean']" in_context=[TIMING,KIAI]
```

## CLI Interattiva
Per chi preferisce un flusso di lavoro basato sul terminale ma desidera una configurazione guidata, lo script CLI interattivo è un'ottima alternativa all'interfaccia Web.

### Avvia la CLI
Naviga nella directory clonata. Potresti dover rendere eseguibile lo script prima.

```sh
# Make the script executable (only needs to be done once)
chmod +x cli_inference.sh
```

```sh
# Run the script
./cli_inference.sh
```

### Utilizzo della CLI
Lo script ti guiderà attraverso una serie di prompt per configurare tutti i parametri di generazione, proprio come l'interfaccia Web.

Utilizza un'interfaccia con codifica a colori per maggiore chiarezza.
Fornisce un menu avanzato multi-selezione per scegliere i descrittori di stile usando i tasti freccia e la barra spaziatrice.
Dopo aver risposto a tutte le domande, verrà mostrato il comando finale per la tua revisione.
Potrai quindi confermare per eseguirlo direttamente oppure annullare e copiare il comando per un utilizzo manuale.

## Suggerimenti per la Generazione

- Puoi modificare `configs/inference_v29.yaml` e aggiungere lì i tuoi argomenti invece di digitarli ogni volta nel terminale.
- Tutti i descrittori disponibili si trovano [qui](https://osu.ppy.sh/wiki/en/Beatmap/Beatmap_tags).
- Fornisci sempre un argomento anno compreso tra il 2007 e il 2023. Se lo lasci sconosciuto, il modello potrebbe generare con uno stile incoerente.
- Fornisci sempre un argomento difficoltà. Se lo lasci sconosciuto, il modello potrebbe generare con una difficoltà incoerente.
- Aumenta il parametro `cfg_scale` per aumentare l'efficacia degli argomenti `mapper_id` e `descriptors`.
- Puoi utilizzare l'argomento `negative_descriptors` per indirizzare il modello lontano da certi stili. Funziona solo quando `cfg_scale > 1`. Assicurati che il numero di descrittori negativi sia uguale al numero di descrittori.
- Se lo stile della tua canzone e quello desiderato della beatmap non combaciano bene, il modello potrebbe non seguire le tue indicazioni. Ad esempio, è difficile generare una beatmap ad alto SR, alto SV per una canzone calma.
- Se hai già fatto timing e tempi kiai per una canzone, puoi fornirli al modello per aumentare notevolmente la velocità e l'accuratezza dell'inferenza: usa gli argomenti `beatmap_path` e `in_context=[TIMING,KIAI]`.
- Per rimappare solo una parte della tua beatmap, usa gli argomenti `beatmap_path`, `start_time`, `end_time` e `add_to_beatmap=true`.
- Per generare una guest difficulty per una beatmap, usa gli argomenti `beatmap_path` e `in_context=[GD,TIMING,KIAI]`.
- Per generare i hitsound per una beatmap, usa gli argomenti `beatmap_path` e `in_context=[NO_HS,TIMING,KIAI]`.
- Per generare solo il timing per una canzone, usa gli argomenti `super_timing=true` e `output_type=[TIMING]`.

## MaiMod: Lo Strumento di Modding Guidato da AI

MaiMod è uno strumento di modding per le beatmap di osu! che utilizza le previsioni di Mapperatorinator per trovare potenziali errori e incoerenze che non possono essere rilevati da altri strumenti di modding automatico come [Mapset Verifier](https://github.com/Naxesss/MapsetVerifier).
Può rilevare problemi come:
- Snapping o pattern ritmici errati
- Punti di timing inaccurati
- Posizioni degli oggetti hit o nuove combo incoerenti
- Forme di slider strane
- Hitsound o volumi incoerenti

Puoi provare MaiMod [qui](https://colab.research.google.com/github/OliBomby/Mapperatorinator/blob/main/colab/mai_mod_inference.ipynb), oppure eseguirlo in locale:
Per eseguire MaiMod in locale, dovrai installare Mapperatorinator. Poi, esegui lo script `mai_mod.py`, specificando il percorso della tua beatmap con l'argomento `beatmap_path`.
```sh
python mai_mod.py beatmap_path="'C:\Users\USER\AppData\Local\osu!\Songs\1 Kenji Ninuma - DISCO PRINCE\Kenji Ninuma - DISCOPRINCE (peppy) [Normal].osu'"
```
Questo stamperà i suggerimenti di modding sulla console, che potrai poi applicare manualmente alla tua beatmap.
I suggerimenti sono ordinati cronologicamente e raggruppati in categorie.
Il primo valore nel cerchio indica la 'sorpresa', che è una misura di quanto il modello abbia trovato inaspettato il problema, così puoi dare priorità alle questioni più importanti.

Il modello può commettere errori, specialmente su problemi a bassa sorpresa, quindi controlla sempre due volte i suggerimenti prima di applicarli alla tua beatmap.
L'obiettivo principale è aiutarti a restringere lo spazio di ricerca dei potenziali problemi, così non dovrai controllare manualmente ogni singolo oggetto nella tua beatmap.

### MaiMod GUI
Per eseguire la MaiMod Web UI, dovrai installare Mapperatorinator.
Poi, esegui lo script `mai_mod_ui.py`. Questo avvierà un server web locale e aprirà automaticamente l'interfaccia in una nuova finestra:

```sh
python mai_mod_ui.py
```
<img width="850" height="1019" alt="afbeelding" src="https://github.com/user-attachments/assets/67c03a43-a7bd-4265-a5b1-5e4d62aca1fa" />

## Panoramica

### Tokenizzazione

Mapperatorinator converte le beatmap di osu! in una rappresentazione intermedia di eventi che può essere direttamente convertita da e verso i token.
Include oggetti di colpo, hitsound, velocità degli slider, nuovi combo, punti di timing, tempi di kiai e velocità di scorrimento taiko/mania.

Ecco un piccolo esempio del processo di tokenizzazione:

![mapperatorinator_parser](https://github.com/user-attachments/assets/84efde76-4c27-48a1-b8ce-beceddd9e695)

Per ridurre la dimensione del vocabolario, gli eventi temporali sono quantizzati a intervalli di 10 ms e le coordinate delle posizioni sono quantizzate su una griglia di 32 pixel.

### Architettura del modello
Il modello è fondamentalmente un wrapper attorno al modello [HF Transformers Whisper](https://huggingface.co/docs/transformers/en/model_doc/whisper#transformers.WhisperForConditionalGeneration), con embedding di input e funzione di perdita personalizzati.
La dimensione del modello ammonta a 219 milioni di parametri.
Questo modello è risultato essere più veloce e preciso rispetto a T5 per questo compito.

La panoramica ad alto livello dell’input-output del modello è la seguente:

![Picture2](https://user-images.githubusercontent.com/28675590/201044116-1384ad72-c540-44db-a285-7319dd01caad.svg)

Il modello utilizza frame di spettrogramma Mel come input dell’encoder, con un frame per posizione di input. L’output del decoder del modello a ogni step è una distribuzione softmax su un vocabolario discreto e predefinito di eventi. Gli output sono sparsi, gli eventi sono necessari solo quando si verifica un oggetto di colpo, invece di annotare ogni singolo frame audio.

### Formato di training multitask

![Multitask training format](https://github.com/user-attachments/assets/62f490bc-a567-4671-a7ce-dbcc5f9cd6d9)

Prima del token SOS ci sono token aggiuntivi che facilitano la generazione condizionale. Questi token includono la modalità di gioco, la difficoltà, l’ID del mapper, l’anno e altri metadati.
Durante l’addestramento, questi token non hanno etichette associate, quindi non vengono mai prodotti dal modello.
Inoltre, durante l’addestramento c’è una possibilità casuale che un token di metadati venga sostituito da un token ‘sconosciuto’, così durante l’inferenza possiamo usare questi token ‘sconosciuti’ per ridurre la quantità di metadati da fornire al modello.

### Generazione continua senza soluzione di continuità

La lunghezza del contesto del modello è di 8,192 secondi. Ovviamente non è sufficiente per generare una beatmap completa, quindi dobbiamo suddividere la canzone in più finestre e generare la beatmap in piccole parti.
Per assicurarci che la beatmap generata non abbia giunture evidenti tra le finestre, utilizziamo una sovrapposizione del 90% e generiamo le finestre in modo sequenziale.
Ogni finestra di generazione tranne la prima inizia con il decoder precompilato fino al 50% della finestra di generazione con token dalle finestre precedenti.

Utilizziamo un processore logit per assicurarci che il modello non possa generare token temporali che si trovano nel primo 50% della finestra di generazione.
Inoltre, l’ultimo 40% della finestra di generazione è riservato per la finestra successiva. Qualsiasi token temporale generato in quell’intervallo viene trattato come token EOS.
Ciò garantisce che ogni token generato sia condizionato su almeno 4 secondi di token precedenti e 3,3 secondi di audio futuro da anticipare.

Per prevenire la deriva dell’offset durante generazioni lunghe, sono stati aggiunti offset casuali agli eventi temporali nel decoder durante l’addestramento.
Questo lo costringe a correggere gli errori di temporizzazione ascoltando invece gli attacchi nell’audio, e produce un offset costantemente accurato.

### Coordinate raffinate con diffusione

Le coordinate di posizione generate dal decoder sono quantizzate su una griglia di 32 pixel, quindi successivamente utilizziamo la diffusione per denoizzare le coordinate fino alle posizioni finali.
Per questo abbiamo addestrato una versione modificata di [osu-diffusion](https://github.com/OliBomby/osu-diffusion) specializzata solo sull’ultimo 10% dello schedule di rumore, e che accetta i token di metadati più avanzati che Mapperatorinator usa per la generazione condizionata.

Poiché il modello Mapperatorinator produce l’SV degli slider, la lunghezza richiesta dello slider è fissa indipendentemente dalla forma del percorso dei punti di controllo.
Pertanto, cerchiamo di guidare il processo di diffusione per creare coordinate che si adattino alle lunghezze richieste degli slider.
Facciamo questo ricalcolando le posizioni finali degli slider dopo ogni passo del processo di diffusione in base alla lunghezza richiesta e al percorso corrente dei punti di controllo.
Ciò significa che il processo di diffusione non ha controllo diretto sulle posizioni finali degli slider, ma può comunque influenzarle modificando il percorso dei punti di controllo.

### Post-processing

Mapperatorinator esegue alcune elaborazioni aggiuntive per migliorare la qualità della beatmap generata:

- Raffina le coordinate di posizione con la diffusione.
- Riallinea gli eventi temporali al tick più vicino usando i divisori di snap generati dal modello.
- Allinea sovrapposizioni posizionali quasi perfette.
- Converte gli eventi delle colonne mania in coordinate X.
- Genera percorsi slider per i taiko drumroll.
- Corregge grandi discrepanze tra la lunghezza richiesta dello slider e la lunghezza del percorso dei punti di controllo.

### Generatore di super timing

Il generatore di super timing è un algoritmo che migliora la precisione e accuratezza del timing generato inferendo il timing per l’intera canzone 20 volte e facendo la media dei risultati.
Questo è utile per canzoni con BPM variabile, o canzoni con cambi di BPM. Il risultato è quasi perfetto con solo occasionalmente una sezione che necessita di aggiustamento manuale.

## Addestramento

L’istruzione seguente crea un ambiente di addestramento sulla tua macchina locale.

### 1. Clona il repository

```sh
git clone https://github.com/OliBomby/Mapperatorinator.git
cd Mapperatorinator
```

### 2. Creare un dataset

Crea il tuo dataset utilizzando l'[applicazione console Mapperator](https://github.com/mappingtools/Mapperator/blob/master/README.md#create-a-high-quality-dataset). È necessario un [token client OAuth di osu!](https://osu.ppy.sh/home/account/edit) per verificare le beatmap e ottenere metadati aggiuntivi. Posiziona il dataset in una directory `datasets` accanto alla directory `Mapperatorinator`.

```sh
Mapperator.ConsoleApp.exe dataset2 -t "/Mapperatorinator/datasets/beatmap_descriptors.csv" -i "path/to/osz/files" -o "/datasets/cool_dataset"
```

### 3. (Opzionale) Configura Weight & Biases per la registrazione
Crea un account su [Weight & Biases](https://wandb.ai/site) e ottieni la tua chiave API dalle impostazioni del tuo account.
Quindi imposta la variabile d'ambiente `WANDB_API_KEY`, così il processo di training saprà a quale chiave registrare.

```sh
export WANDB_API_KEY=<your_api_key>
```

### 4. Crea un container Docker
L'addestramento nel tuo venv è possibile, ma consigliamo di utilizzare Docker su WSL per prestazioni migliori.
```sh
docker compose up -d --force-recreate
docker attach mapperatorinator_space
cd Mapperatorinator
```

### 5. Configurare i parametri e iniziare l'addestramento

Tutte le configurazioni si trovano in `./configs/train/default.yaml`.
Assicurati di impostare correttamente `train_dataset_path` e `test_dataset_path` sul tuo dataset, così come gli indici iniziali e finali del mapset per la divisione train/test.
Il percorso è locale al container docker, quindi se hai inserito il tuo dataset chiamato `cool_dataset` nella directory `datasets`, allora dovrebbe essere `/workspace/datasets/cool_dataset`.

Consiglio di creare un file di configurazione personalizzato che sovrascriva la configurazione di default, così avrai una traccia della tua configurazione di addestramento per la riproducibilità.

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

### 6. Fine-tuning LoRA

Puoi anche perfezionare un modello pre-addestrato con [LoRA](https://arxiv.org/abs/2106.09685) per adattarlo a uno stile o modalità di gioco specifica.
Per farlo, adatta `configs/train/lora.yaml` alle tue esigenze ed esegui la configurazione di training `lora`:

```sh
python osuT5/train.py -cn lora train_dataset_path="/workspace/datasets/cool_dataset" test_dataset_path="/workspace/datasets/cool_dataset" train_dataset_end=90 test_dataset_start=90 test_dataset_end=100
```

Parametri LoRA importanti da considerare:
- `pretrained_path`: Percorso o repository HF del modello base da ottimizzare.
- `r`: Rango delle matrici LoRA. Valori più alti aumentano la capacità del modello ma anche l’uso della memoria.
- `lora_alpha`: Fattore di scala per gli aggiornamenti LoRA.
- `total_steps`: Numero totale di step di addestramento. Bilancia in base alla dimensione del tuo dataset.
- `enable_lora`: Indica se usare LoRA o la regolazione completa del modello.

Durante l’inferenza, puoi specificare i pesi LoRA da usare con l’argomento `lora_path`.
Questo può essere un percorso locale o un repository Hugging Face.

## Vedi anche
- [Mapper Classifier](https://raw.githubusercontent.com/OliBomby/Mapperatorinator/main/./classifier/README.md)
- [RComplexion](https://raw.githubusercontent.com/OliBomby/Mapperatorinator/main/./rcomplexion/README.md)

## Crediti

Ringraziamenti speciali a:
1. Gli autori di [osuT5](https://github.com/gyataro/osuT5) per il loro codice di training.
2. Il team di Hugging Face per i loro [strumenti](https://huggingface.co/docs/transformers/index).
3. [Jason Won](https://github.com/jaswon) e [Richard Nagyfi](https://github.com/sedthh) per lo scambio di idee.
4. [Marvin](https://github.com/minetoblend) per la donazione di crediti di training.
5. La community di osu! per le beatmap.

## Lavori correlati

1. [osu! Beatmap Generator](https://github.com/Syps/osu_beatmap_generator) di Syps (Nick Sypteras)
2. [osumapper](https://github.com/kotritrona/osumapper) di kotritrona, jyvden, Yoyolick (Ryan Zmuda)
3. [osu-diffusion](https://github.com/OliBomby/osu-diffusion) di OliBomby (Olivier Schipper), NiceAesth (Andrei Baciu)
4. [osuT5](https://github.com/gyataro/osuT5) di gyataro (Xiwen Teoh)
5. [Beat Learning](https://github.com/sedthh/BeatLearning) di sedthh (Richard Nagyfi)
6. [osu!dreamer](https://github.com/jaswon/osu-dreamer) di jaswon (Jason Won)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-24

---