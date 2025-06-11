# 3D Gaussian Splatting per il Rendering in Tempo Reale di Radiance Field - Implementazione in C++ e CUDA

[![Discord](https://img.shields.io/badge/Discord-Join%20Us-7289DA?logo=discord&logoColor=white)](https://discord.gg/TbxJST2BbC)  
[![Website](https://img.shields.io/badge/Website-mrnerf.com-blue)](https://mrnerf.com)  
[![Papers](https://img.shields.io/badge/Papers-Awesome%203DGS-orange)](https://mrnerf.github.io/awesome-3D-gaussian-splatting/)

Un'implementazione ad alte prestazioni in C++ e CUDA di 3D Gaussian Splatting, basata sul backend di rasterizzazione [gsplat](https://github.com/nerfstudio-project/gsplat).

## Novità
- **[2025-06-10]**: Risolti alcuni problemi. Stiamo colmando il divario con le metriche di gsplat. Tuttavia, persiste una piccola discrepanza.
- **[2025-06-04]**: Aggiunta la strategia MCMC con l’opzione da linea di comando `--max-cap` per controllare il numero massimo di Gaussiane.
- **[2025-06-03]**: Passaggio al backend Gsplat e aggiornamento della licenza.
- **[2024-05-27]**: Aggiornamento a LibTorch 2.7.0 per migliore compatibilità e prestazioni. Sono stati risolti cambiamenti importanti nella gestione dello stato dell’ottimizzatore.
- **[2024-05-26]**: L’obiettivo attuale di questo repository è passare a una licenza permissiva. È stato fatto un lavoro importante per sostituire il rasterizzatore con l’implementazione gsplat.

## Metriche
Attualmente l’implementazione non raggiunge risultati alla pari con gsplat-mcmc, ma è un lavoro in corso.  
È solo questione di tempo per risolvere il bug. Aiuti sono benvenuti :) Le metriche per la strategia mcmc sono le seguenti:

| Scena    | Iterazione | PSNR          | SSIM         | LPIPS        | Tempo per Immagine | Numero Gaussiane |
| -------- | ---------- | ------------- | ------------ | ------------ | ------------------ | ---------------- |
| garden   | 30000      | 27.112114     | 0.854833     | 0.157624     | 0.304765           | 1000000          |
| bicycle  | 30000      | 25.047745     | 0.767729     | 0.254825     | 0.293618           | 1000000          |
| stump    | 30000      | 26.554749     | 0.784203     | 0.263013     | 0.296536           | 1000000          |
| bonsai   | 30000      | 32.534199     | 0.948675     | 0.246924     | 0.436188           | 1000000          |
| counter  | 30000      | 29.187017     | 0.915823     | 0.242159     | 0.441259           | 1000000          |
| kitchen  | 30000      | 31.680832     | 0.933897     | 0.154965     | 0.449078           | 1000000          |
| room     | 30000      | 32.211632     | 0.930754     | 0.273719     | 0.413519           | 1000000          |
| **media**| **30000**  | **29.189755** | **0.876559** | **0.227604** | **0.376423**       | **1000000**      |

## Comunità e Supporto

Unisciti alla nostra comunità in crescita per discussioni, supporto e aggiornamenti:  
- 💬 **[Discord Community](https://discord.gg/TbxJST2BbC)** - Ricevi aiuto, condividi risultati e discuti lo sviluppo  
- 🌐 **[mrnerf.com](https://mrnerf.com)** - Visita il nostro sito per ulteriori risorse  
- 📚 **[Awesome 3D Gaussian Splatting](https://mrnerf.github.io/awesome-3D-gaussian-splatting/)** - Lista completa di articoli e risorse  
- 🐦 **[@janusch_patas](https://twitter.com/janusch_patas)** - Segui per gli ultimi aggiornamenti

## Istruzioni per la Compilazione ed Esecuzione

### Prerequisiti Software
1. **Linux** (testato con Ubuntu 22.04) - Windows non è attualmente supportato  
2. **CMake** versione 3.24 o superiore  
3. **CUDA** 11.8 o superiore (può funzionare con versioni inferiori con configurazione manuale)  
4. **Python** con header di sviluppo  
5. **LibTorch 2.7.0** - Istruzioni per l’installazione sotto  
6. Altre dipendenze gestite automaticamente da CMake

### Prerequisiti Hardware
1. **GPU NVIDIA** con supporto CUDA  
    - Testato con successo: RTX 4090, RTX A5000, RTX 3090Ti, A100  
    - Problema noto con RTX 3080Ti su dataset più grandi (vedi #21)  
2. Capacità di calcolo minima: 8.0

> Se riesci a farlo girare su altri hardware, condividi la tua esperienza nella sezione Discussions!

### Istruzioni per la Compilazione

```bash
# Clona il repository con i submodules
git clone --recursive https://github.com/MrNeRF/gaussian-splatting-cuda
cd gaussian-splatting-cuda

# Scarica e configura LibTorch
wget https://raw.githubusercontent.com/MrNeRF/gaussian-splatting-cuda/master/libtorch-cxx11-abi-shared-with-deps-2.7.0%2Bcu118.zip  
unzip libtorch-cxx11-abi-shared-with-deps-2.7.0+cu118.zip -d external/
rm libtorch-cxx11-abi-shared-with-deps-2.7.0+cu118.zip

# Compila il progetto
cmake -B build -DCMAKE_BUILD_TYPE=Release
cmake --build build -- -j
```

## LibTorch 2.7.0

Questo progetto utilizza **LibTorch 2.7.0** per prestazioni e compatibilità ottimali:

- **Prestazioni Migliorate**: Ottimizzazione e gestione memoria migliorate  
- **Stabilità API**: Ultima API stabile di PyTorch in C++  
- **Compatibilità CUDA**: Migliore integrazione con CUDA 11.8+  
- **Correzioni di Bug**: Risolti problemi nella gestione dello stato dell’ottimizzatore

### Aggiornamento da Versioni Precedenti
1. Scarica la nuova versione di LibTorch seguendo le istruzioni di compilazione  
2. Pulisci la directory di build: `rm -rf build/`  
3. Ricompila il progetto

## Dataset

Scarica il dataset dal repository originale:  
[Tanks & Trains Dataset](https://repo-sam.inria.fr/fungraph/3d-gaussian-splatting/datasets/input/tandt_db.zip)

Estrarlo nella cartella `data` nella root del progetto.

## Opzioni da Linea di Comando

### Opzioni Principali

- **`-h, --help`**  
  Mostra il menu di aiuto

- **`-d, --data-path [PATH]`**  
  Percorso ai dati di training (obbligatorio)

- **`-o, --output-path [PATH]`**  
  Percorso per salvare il modello addestrato (default: `./output`)

- **`-i, --iter [NUM]`**  
  Numero di iterazioni di training (default: 30000)  
    - L’articolo suggerisce 30k, ma 6k-7k spesso dà buoni risultati preliminari  
    - I risultati sono salvati ogni 7k iterazioni e al termine

- **`-f, --force`**  
  Forza la sovrascrittura della cartella di output esistente

- **`-r, --resolution [NUM]`**  
  Imposta la risoluzione per le immagini di training

### Opzioni Specifiche MCMC

- **`--max-cap [NUM]`**  
  Numero massimo di Gaussiane per la strategia MCMC (default: 1000000)  
    - Controlla il limite superiore delle Gaussian splat durante il training  
    - Utile in ambienti con memoria limitata

### Esempi di Utilizzo

Training base:  
```bash
./build/gaussian_splatting_cuda -d /path/to/data -o /path/to/output -i 10000
```

Training MCMC con numero limitato di Gaussiane:  
```bash
./build/gaussian_splatting_cuda -d /path/to/data -o /path/to/output -i 10000 --max-cap 500000
```

## Linee Guida per i Contributi

Accogliamo contributi! Ecco come iniziare:

1. **Per Iniziare**:  
    - Consulta le issue etichettate come **good first issues** per compiti adatti ai principianti  
    - Per nuove idee, apri una discussione o unisciti al nostro [Discord](https://discord.gg/TbxJST2BbC)

2. **Prima di Inviare una PR**:  
    - Applica `clang-format` per uno stile di codice coerente  
    - Usa il pre-commit hook: `cp tools/pre-commit .git/hooks/`  
    - Discuti nuove dipendenze prima in una issue - puntiamo a minimizzare le dipendenze

## Ringraziamenti

Questa implementazione si basa su diversi progetti chiave:

- **[gsplat](https://github.com/nerfstudio-project/gsplat)**: Utilizziamo il backend di rasterizzazione CUDA altamente ottimizzato di gsplat, che fornisce significativi miglioramenti di prestazioni e una migliore efficienza di memoria.

- **3D Gaussian Splatting originale**: Basato sul lavoro innovativo di Kerbl et al.

## Citazione

Se usi questo software nella tua ricerca, cita il lavoro originale:

```bibtex
@article{kerbl3Dgaussians,
  author    = {Kerbl, Bernhard and Kopanas, Georgios and Leimkühler, Thomas and Drettakis, George},
  title     = {3D Gaussian Splatting for Real-Time Radiance Field Rendering},
  journal   = {ACM Transactions on Graphics},
  number    = {4},
  volume    = {42},
  month     = {July},
  year      = {2023},
  url       = {https://repo-sam.inria.fr/fungraph/3d-gaussian-splatting/}
}
```

## Licenza

Vedi il file LICENSE per i dettagli.

---

**Connettiti con noi:**  
- 🌐 Sito web: [mrnerf.com](https://mrnerf.com)  
- 📚 Articoli: [Awesome 3D Gaussian Splatting](https://mrnerf.github.io/awesome-3D-gaussian-splatting/)  
- 💬 Discord: [Unisciti alla nostra comunità](https://discord.gg/TbxJST2BbC)  
- 🐦 Twitter: Segui [@janusch_patas](https://twitter.com/janusch_patas) per aggiornamenti sullo sviluppo

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---