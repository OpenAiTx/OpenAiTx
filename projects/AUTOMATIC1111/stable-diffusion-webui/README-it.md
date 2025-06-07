# Stable Diffusion web UI
Un'interfaccia web per Stable Diffusion, implementata utilizzando la libreria Gradio.

![](screenshot.png)

## Funzionalità
[Presentazione dettagliata delle funzionalità con immagini](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features):
- Modalità originali txt2img e img2img
- Script di installazione e avvio con un clic (ma è comunque necessario installare python e git)
- Outpainting
- Inpainting
- Color Sketch
- Prompt Matrix
- Stable Diffusion Upscale
- Attention, specifica parti di testo a cui il modello deve prestare maggiore attenzione
    - a man in a `((tuxedo))` - presterà maggiore attenzione a tuxedo
    - a man in a `(tuxedo:1.21)` - sintassi alternativa
    - seleziona il testo e premi `Ctrl+Su` o `Ctrl+Giu` (oppure `Command+Su` o `Command+Giu` su MacOS) per regolare automaticamente l’attenzione sul testo selezionato (codice contribuito da un utente anonimo)
- Loopback, esegui la procedura img2img più volte
- X/Y/Z plot, modo per disegnare un grafico tridimensionale di immagini con parametri diversi
- Textual Inversion
    - puoi avere tutti gli embedding che vuoi e usare qualsiasi nome
    - utilizza più embedding con diversi numeri di vettori per token
    - funziona con numeri in virgola mobile a mezza precisione
    - addestra gli embedding su 8GB (funziona anche su 6GB secondo alcune segnalazioni)
- Scheda Extra con:
    - GFPGAN, rete neurale che corregge i volti
    - CodeFormer, strumento di restauro volti alternativo a GFPGAN
    - RealESRGAN, upscaler neurale
    - ESRGAN, upscaler neurale con molti modelli di terze parti
    - SwinIR e Swin2SR ([vedi qui](https://github.com/AUTOMATIC1111/stable-diffusion-webui/pull/2092)), upscaler neurali
    - LDSR, upscaling a super-risoluzione con diffusione latente
- Opzioni di ridimensionamento del rapporto d’aspetto
- Selezione del metodo di campionamento
    - Regola i valori eta del campionatore (moltiplicatore di rumore)
    - Opzioni avanzate per l’impostazione del rumore
- Interrompi l’elaborazione in qualsiasi momento
- Supporto per schede video da 4GB (funziona anche su 2GB secondo alcune segnalazioni)
- Semi corretti per batch
- Validazione in tempo reale della lunghezza dei token del prompt
- Parametri di generazione
     - i parametri utilizzati per generare le immagini vengono salvati con l’immagine stessa
     - nei chunk PNG per PNG, in EXIF per JPEG
     - puoi trascinare l’immagine nella scheda PNG info per ripristinare i parametri di generazione e copiarli automaticamente nell’interfaccia
     - può essere disabilitato nelle impostazioni
     - drag and drop di immagine o parametri testo nel promptbox
- Pulsante Leggi Parametri di Generazione, carica i parametri dal promptbox nell’interfaccia
- Pagina delle impostazioni
- Esecuzione di codice python arbitrario dall’interfaccia (devi avviare con `--allow-code` per abilitare)
- Suggerimenti al passaggio del mouse per la maggior parte degli elementi UI
- Possibilità di modificare valori di default/min/max/step degli elementi UI tramite configurazione testuale
- Supporto per tiling, una checkbox per creare immagini che possono essere tessellate come texture
- Barra di avanzamento e anteprima live della generazione immagini
    - Può usare una rete neurale separata per produrre anteprime con quasi nessun requisito di VRAM o calcolo
- Negative prompt, campo di testo aggiuntivo per specificare ciò che NON vuoi vedere nell’immagine generata
- Stili, modo per salvare parti del prompt e applicarle facilmente tramite menu a tendina
- Variazioni, modo per generare la stessa immagine con piccole differenze
- Ridimensionamento seed, modo per generare la stessa immagine a risoluzioni leggermente diverse
- CLIP interrogator, pulsante che cerca di indovinare il prompt da un’immagine
- Prompt Editing, modo per cambiare prompt a generazione in corso, ad esempio per iniziare con un’anguria e passare a una ragazza anime a metà
- Batch Processing, elabora un gruppo di file usando img2img
- Img2img Alternative, metodo inverso di Euler per il controllo cross attention
- Highres Fix, opzione comoda per produrre immagini ad alta risoluzione in un clic senza le solite distorsioni
- Ricarica dei checkpoint in tempo reale
- Checkpoint Merger, scheda che permette di unire fino a 3 checkpoint in uno solo
- [Script personalizzati](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Custom-Scripts) con numerose estensioni dalla community
- [Composable-Diffusion](https://energy-based-model.github.io/Compositional-Visual-Generation-with-Composable-Diffusion-Models/), modo per usare più prompt contemporaneamente
     - separa i prompt usando `AND` maiuscolo
     - supporta anche pesi per i prompt: `a cat :1.2 AND a dog AND a penguin :2.2`
- Nessun limite di token per i prompt (Stable Diffusion originale consente fino a 75 token)
- Integrazione DeepDanbooru, genera tag in stile danbooru per prompt anime
- [xformers](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Xformers), grande aumento di velocità per alcune schede: (aggiungi `--xformers` agli argomenti da riga di comando)
- tramite estensione: [Scheda Cronologia](https://github.com/yfszzx/stable-diffusion-webui-images-browser): visualizza, gestisci e cancella immagini comodamente dall’interfaccia
- Opzione Genera all’infinito
- Scheda Training
     - opzioni per hypernetwork ed embedding
     - Preprocessing immagini: crop, mirroring, autotagging tramite BLIP o deepdanbooru (per anime)
- Clip skip
- Hypernetwork
- Loras (come Hypernetwork ma più avanzati)
- Interfaccia separata dove scegliere, con anteprima, quali embedding, hypernetwork o Loras aggiungere al prompt
- Puoi selezionare un VAE diverso dalle impostazioni
- Tempo stimato di completamento nella barra di avanzamento
- API
- Supporto per modello di [inpainting dedicato](https://github.com/runwayml/stable-diffusion#inpainting-with-stable-diffusion) di RunwayML
- tramite estensione: [Aesthetic Gradients](https://github.com/AUTOMATIC1111/stable-diffusion-webui-aesthetic-gradients), modo per generare immagini con un’estetica specifica usando embedding di immagini clip (implementazione di [https://github.com/vicgalle/stable-diffusion-aesthetic-gradients](https://github.com/vicgalle/stable-diffusion-aesthetic-gradients))
- Supporto [Stable Diffusion 2.0](https://github.com/Stability-AI/stablediffusion) - vedi [wiki](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features#stable-diffusion-20) per istruzioni
- Supporto [Alt-Diffusion](https://arxiv.org/abs/2211.06679) - vedi [wiki](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features#alt-diffusion) per istruzioni
- Ora senza lettere non consentite!
- Carica checkpoint in formato safetensors
- Restrizione sulla risoluzione allentata: le dimensioni delle immagini generate devono essere multipli di 8 invece che di 64
- Ora con licenza!
- Riordina elementi dell’interfaccia dalle impostazioni
- Supporto [Segmind Stable Diffusion](https://huggingface.co/segmind/SSD-1B)

## Installazione ed Esecuzione
Assicurati che le [dipendenze](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Dependencies) richieste siano soddisfatte e segui le istruzioni disponibili per:
- [NVidia](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-NVidia-GPUs) (consigliato)
- GPU [AMD](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-AMD-GPUs).
- [CPU Intel, GPU Intel (sia integrate che discrete)](https://github.com/openvinotoolkit/stable-diffusion-webui/wiki/Installation-on-Intel-Silicon) (pagina wiki esterna)
- [Ascend NPU](https://github.com/wangshuai09/stable-diffusion-webui/wiki/Install-and-run-on-Ascend-NPUs) (pagina wiki esterna)

In alternativa, puoi usare servizi online (come Google Colab):

- [Elenco di servizi online](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Online-Services)

### Installazione su Windows 10/11 con GPU NVidia usando il pacchetto release
1. Scarica `sd.webui.zip` da [v1.0.0-pre](https://github.com/AUTOMATIC1111/stable-diffusion-webui/releases/tag/v1.0.0-pre) ed estrai il contenuto.
2. Esegui `update.bat`.
3. Esegui `run.bat`.
> Per maggiori dettagli consulta [Install-and-Run-on-NVidia-GPUs](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-NVidia-GPUs)

### Installazione Automatica su Windows
1. Installa [Python 3.10.6](https://www.python.org/downloads/release/python-3106/) (le versioni più recenti di Python non supportano torch), selezionando "Add Python to PATH".
2. Installa [git](https://git-scm.com/download/win).
3. Scarica il repository stable-diffusion-webui, ad esempio eseguendo `git clone https://github.com/AUTOMATIC1111/stable-diffusion-webui.git`.
4. Esegui `webui-user.bat` da Windows Explorer come utente normale, non amministratore.

### Installazione Automatica su Linux
1. Installa le dipendenze:
```bash
# Basato su Debian:
sudo apt install wget git python3 python3-venv libgl1 libglib2.0-0
# Basato su Red Hat:
sudo dnf install wget git python3 gperftools-libs libglvnd-glx
# Basato su openSUSE:
sudo zypper install wget git python3 libtcmalloc4 libglvnd
# Basato su Arch:
sudo pacman -S wget git python3
```
Se il tuo sistema è molto recente, devi installare python3.11 o python3.10:
```bash
# Ubuntu 24.04
sudo add-apt-repository ppa:deadsnakes/ppa
sudo apt update
sudo apt install python3.11

# Manjaro/Arch
sudo pacman -S yay
yay -S python311 # non confondere con il pacchetto python3.11

# Solo per 3.11
# Poi imposta la variabile d’ambiente nello script di avvio
export python_cmd="python3.11"
# o in webui-user.sh
python_cmd="python3.11"
```
2. Vai nella cartella in cui vuoi installare la webui ed esegui il seguente comando:
```bash
wget -q https://raw.githubusercontent.com/AUTOMATIC1111/stable-diffusion-webui/master/webui.sh
```
Oppure clona semplicemente il repository dove preferisci:
```bash
git clone https://github.com/AUTOMATIC1111/stable-diffusion-webui
```

3. Esegui `webui.sh`.
4. Controlla `webui-user.sh` per le opzioni.
### Installazione su Apple Silicon

Trova le istruzioni [qui](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Installation-on-Apple-Silicon).

## Contribuire
Ecco come aggiungere codice a questo repository: [Contributing](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Contributing)

## Documentazione

La documentazione è stata spostata da questo README al [wiki del progetto](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki).

Per permettere a Google e altri motori di ricerca di indicizzare il wiki, ecco il link (non per utenti) al [wiki indicizzabile](https://github-wiki-see.page/m/AUTOMATIC1111/stable-diffusion-webui/wiki).

## Crediti
Le licenze per il codice utilizzato si trovano nella schermata `Impostazioni -> Licenze` e anche nel file `html/licenses.html`.

- Stable Diffusion - https://github.com/Stability-AI/stablediffusion, https://github.com/CompVis/taming-transformers, https://github.com/mcmonkey4eva/sd3-ref
- k-diffusion - https://github.com/crowsonkb/k-diffusion.git
- Spandrel - https://github.com/chaiNNer-org/spandrel implementando
  - GFPGAN - https://github.com/TencentARC/GFPGAN.git
  - CodeFormer - https://github.com/sczhou/CodeFormer
  - ESRGAN - https://github.com/xinntao/ESRGAN
  - SwinIR - https://github.com/JingyunLiang/SwinIR
  - Swin2SR - https://github.com/mv-lab/swin2sr
- LDSR - https://github.com/Hafiidz/latent-diffusion
- MiDaS - https://github.com/isl-org/MiDaS
- Idee per ottimizzazioni - https://github.com/basujindal/stable-diffusion
- Ottimizzazione Cross Attention layer - Doggettx - https://github.com/Doggettx/stable-diffusion, idea originale per prompt editing.
- Ottimizzazione Cross Attention layer - InvokeAI, lstein - https://github.com/invoke-ai/InvokeAI (originariamente http://github.com/lstein/stable-diffusion)
- Ottimizzazione Cross Attention layer sub-quadratica - Alex Birch (https://github.com/Birch-san/diffusers/pull/1), Amin Rezaei (https://github.com/AminRezaei0x443/memory-efficient-attention)
- Textual Inversion - Rinon Gal - https://github.com/rinongal/textual_inversion (non usiamo il suo codice, ma le sue idee).
- Idea per SD upscale - https://github.com/jquesnelle/txt2imghd
- Generazione rumore per outpainting mk2 - https://github.com/parlance-zz/g-diffuser-bot
- Idea CLIP interrogator e parte del codice - https://github.com/pharmapsychotic/clip-interrogator
- Idea per Composable Diffusion - https://github.com/energy-based-model/Compositional-Visual-Generation-with-Composable-Diffusion-Models-PyTorch
- xformers - https://github.com/facebookresearch/xformers
- DeepDanbooru - interrogator per anime diffusers https://github.com/KichangKim/DeepDanbooru
- Campionamento in precisione float32 da UNet float16 - marunine per l’idea, Birch-san per esempio di implementazione Diffusers (https://github.com/Birch-san/diffusers-play/tree/92feee6)
- Instruct pix2pix - Tim Brooks (star), Aleksander Holynski (star), Alexei A. Efros (no star) - https://github.com/timothybrooks/instruct-pix2pix
- Consigli di sicurezza - RyotaK
- UniPC sampler - Wenliang Zhao - https://github.com/wl-zhao/UniPC
- TAESD - Ollin Boer Bohan - https://github.com/madebyollin/taesd
- LyCORIS - KohakuBlueleaf
- Restart sampling - lambertae - https://github.com/Newbeeer/diffusion_restart_sampling
- Hypertile - tfernd - https://github.com/tfernd/HyperTile
- Script Gradio iniziale - pubblicato su 4chan da un utente anonimo. Grazie utente anonimo.
- (You)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---