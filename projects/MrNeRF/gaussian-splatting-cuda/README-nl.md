# 3D Gaussian Splatting voor Real-Time Radiance Field Rendering - C++ en CUDA Implementatie

[![Discord](https://img.shields.io/badge/Discord-Join%20Us-7289DA?logo=discord&logoColor=white)](https://discord.gg/TbxJST2BbC)  
[![Website](https://img.shields.io/badge/Website-mrnerf.com-blue)](https://mrnerf.com)  
[![Papers](https://img.shields.io/badge/Papers-Awesome%203DGS-orange)](https://mrnerf.github.io/awesome-3D-gaussian-splatting/)

Een high-performance C++ en CUDA implementatie van 3D Gaussian Splatting, gebouwd op de [gsplat](https://github.com/nerfstudio-project/gsplat) rasterisatie backend.

## Nieuws
- **[2025-06-10]**: Sommige problemen opgelost. We dichten de kloof naar de gsplat metrics. Er is echter nog een kleine mismatch.
- **[2025-06-04]**: MCMC strategie toegevoegd met `--max-cap` commandoregeloptie om het maximale aantal Gaussians te regelen.
- **[2025-06-03]**: Overgeschakeld naar Gsplat backend en licentie bijgewerkt.
- **[2024-05-27]**: Bijgewerkt naar LibTorch 2.7.0 voor betere compatibiliteit en prestaties. Brekende wijzigingen in optimizer state management zijn aangepakt.
- **[2024-05-26]**: Het huidige doel van deze repo is te verschuiven naar een permissieve licentie. Groot werk is verricht om de rasterizer te vervangen door de gsplat implementatie.

## Metrics
Momenteel bereikt de implementatie nog niet dezelfde resultaten als gsplat-mcmc, maar het is een werk in uitvoering.  
Het is slechts een kwestie van tijd om de bug te fixen. Hulp is welkom :) De metrics voor de mcmc strategie zijn als volgt:

| Scène    | Iteratie | PSNR          | SSIM         | LPIPS        | Tijd per Afbeelding | Aantal Gaussians |
| -------- | -------- | ------------- | ------------ | ------------ | ------------------- | ---------------- |
| garden   | 30000    | 27.112114     | 0.854833     | 0.157624     | 0.304765            | 1000000          |
| bicycle  | 30000    | 25.047745     | 0.767729     | 0.254825     | 0.293618            | 1000000          |
| stump    | 30000    | 26.554749     | 0.784203     | 0.263013     | 0.296536            | 1000000          |
| bonsai   | 30000    | 32.534199     | 0.948675     | 0.246924     | 0.436188            | 1000000          |
| counter  | 30000    | 29.187017     | 0.915823     | 0.242159     | 0.441259            | 1000000          |
| kitchen  | 30000    | 31.680832     | 0.933897     | 0.154965     | 0.449078            | 1000000          |
| room     | 30000    | 32.211632     | 0.930754     | 0.273719     | 0.413519            | 1000000          |
| **gemiddeld** | **30000** | **29.189755** | **0.876559** | **0.227604** | **0.376423**       | **1000000**      |

## Community & Ondersteuning

Word lid van onze groeiende community voor discussies, ondersteuning en updates:  
- 💬 **[Discord Community](https://discord.gg/TbxJST2BbC)** - Krijg hulp, deel resultaten en bespreek ontwikkeling  
- 🌐 **[mrnerf.com](https://mrnerf.com)** - Bezoek onze website voor meer bronnen  
- 📚 **[Awesome 3D Gaussian Splatting](https://mrnerf.github.io/awesome-3D-gaussian-splatting/)** - Uitgebreide lijst van papers en bronnen  
- 🐦 **[@janusch_patas](https://twitter.com/janusch_patas)** - Volg voor de laatste updates

## Bouw- en Uitvoerinstructies

### Softwarevereisten
1. **Linux** (getest met Ubuntu 22.04) - Windows wordt momenteel niet ondersteund  
2. **CMake** 3.24 of hoger  
3. **CUDA** 11.8 of hoger (kan werken met lagere versies via handmatige configuratie)  
4. **Python** met ontwikkelingsheaders  
5. **LibTorch 2.7.0** - Setup instructies hieronder  
6. Andere afhankelijkheden worden automatisch afgehandeld door CMake

### Hardwarevereisten
1. **NVIDIA GPU** met CUDA-ondersteuning  
    - Succesvol getest: RTX 4090, RTX A5000, RTX 3090Ti, A100  
    - Bekend probleem met RTX 3080Ti op grotere datasets (zie #21)  
2. Minimale compute capability: 8.0

> Als je succesvol draait op andere hardware, deel dan je ervaring in de Discussions sectie!

### Bouwinstructies

```bash
# Clone de repository met submodules
git clone --recursive https://raw.githubusercontent.com/MrNeRF/gaussian-splatting-cuda/master/
cd gaussian-splatting-cuda

# Download en setup LibTorch
wget https://download.pytorch.org/libtorch/cu118/libtorch-cxx11-abi-shared-with-deps-2.7.0%2Bcu118.zip  
unzip libtorch-cxx11-abi-shared-with-deps-2.7.0+cu118.zip -d external/
rm libtorch-cxx11-abi-shared-with-deps-2.7.0+cu118.zip

# Bouw het project
cmake -B build -DCMAKE_BUILD_TYPE=Release
cmake --build build -- -j
```

## LibTorch 2.7.0

Dit project gebruikt **LibTorch 2.7.0** voor optimale prestaties en compatibiliteit:

- **Verbeterde prestaties**: Geoptimaliseerde optimalisatie en geheugengebruik  
- **API Stabiliteit**: Laatste stabiele PyTorch C++ API  
- **CUDA Compatibiliteit**: Betere integratie met CUDA 11.8+  
- **Bugfixes**: Problemen met optimizer state management opgelost

### Upgraden vanaf eerdere versies
1. Download de nieuwe LibTorch versie volgens de bouwinstructies  
2. Maak je build map schoon: `rm -rf build/`  
3. Bouw het project opnieuw

## Dataset

Download de dataset van de originele repository:  
[Tanks & Trains Dataset](https://repo-sam.inria.fr/fungraph/3d-gaussian-splatting/datasets/input/tandt_db.zip)

Pak deze uit in de `data` map in de project root.

## Commandoregelopties

### Kernopties

- **`-h, --help`**  
  Toon het helpmenu

- **`-d, --data-path [PAD]`**  
  Pad naar de trainingsdata (verplicht)

- **`-o, --output-path [PAD]`**  
  Pad om het getrainde model op te slaan (standaard: `./output`)

- **`-i, --iter [NUM]`**  
  Aantal training iteraties (standaard: 30000)  
    - Paper suggereert 30k, maar 6k-7k levert vaak goede voorlopige resultaten  
    - Output wordt elke 7k iteraties en bij voltooiing opgeslagen

- **`-f, --force`**  
  Forceer overschrijven van bestaande output map

- **`-r, --resolution [NUM]`**  
  Stel de resolutie in voor trainingsafbeeldingen

### MCMC-specifieke opties

- **`--max-cap [NUM]`**  
  Maximum aantal Gaussians voor MCMC strategie (standaard: 1000000)  
    - Beheert de bovengrens van Gaussian splats tijdens training  
    - Handig bij geheugengebonden omgevingen

### Voorbeeldgebruik

Basis training:  
```bash
./build/gaussian_splatting_cuda -d /pad/naar/data -o /pad/naar/output -i 10000
```

MCMC training met gelimiteerd aantal Gaussians:  
```bash
./build/gaussian_splatting_cuda -d /pad/naar/data -o /pad/naar/output -i 10000 --max-cap 500000
```

## Bijdragerinstructies

We verwelkomen bijdragen! Zo begin je:

1. **Aan de slag**:  
    - Bekijk issues gelabeld als **good first issues** voor beginnersvriendelijke taken  
    - Voor nieuwe ideeën, open een discussie of sluit je aan bij onze [Discord](https://discord.gg/TbxJST2BbC)

2. **Voor het indienen van een PR**:  
    - Pas `clang-format` toe voor consistente code stijl  
    - Gebruik de pre-commit hook: `cp tools/pre-commit .git/hooks/`  
    - Bespreek nieuwe afhankelijkheden eerst in een issue - we streven ernaar om afhankelijkheden te minimaliseren

## Dankwoord

Deze implementatie bouwt voort op enkele belangrijke projecten:

- **[gsplat](https://github.com/nerfstudio-project/gsplat)**: We gebruiken gsplat’s zeer geoptimaliseerde CUDA rasterisatie backend, die aanzienlijke prestatieverbeteringen en betere geheugenefficiëntie biedt.

- **Originele 3D Gaussian Splatting**: Gebaseerd op het baanbrekende werk van Kerbl et al.

## Citeren

Als je deze software in je onderzoek gebruikt, citeer dan alsjeblieft het originele werk:

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

## Licentie

Zie LICENSE bestand voor details.

---

**Verbind met ons:**  
- 🌐 Website: [mrnerf.com](https://mrnerf.com)  
- 📚 Papers: [Awesome 3D Gaussian Splatting](https://mrnerf.github.io/awesome-3D-gaussian-splatting/)  
- 💬 Discord: [Word lid van onze community](https://discord.gg/TbxJST2BbC)  
- 🐦 Twitter: Volg [@janusch_patas](https://twitter.com/janusch_patas) voor ontwikkelingsupdates

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---