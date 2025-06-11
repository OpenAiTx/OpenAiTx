# 3D Gaussian Splatting für Echtzeit-Radiance-Field-Rendering – C++- und CUDA-Implementierung

[![Discord](https://img.shields.io/badge/Discord-Join%20Us-7289DA?logo=discord&logoColor=white)](https://discord.gg/TbxJST2BbC)  
[![Website](https://img.shields.io/badge/Website-mrnerf.com-blue)](https://mrnerf.com)  
[![Papers](https://img.shields.io/badge/Papers-Awesome%203DGS-orange)](https://mrnerf.github.io/awesome-3D-gaussian-splatting/)

Eine leistungsstarke C++- und CUDA-Implementierung von 3D Gaussian Splatting, basierend auf dem [gsplat](https://github.com/nerfstudio-project/gsplat) Rasterisierungs-Backend.

## Neuigkeiten
- **[2025-06-10]**: Einige Probleme behoben. Wir schließen die Lücke zu den gsplat-Metriken. Es besteht jedoch noch eine kleine Abweichung.
- **[2025-06-04]**: MCMC-Strategie mit der Befehlszeilenoption `--max-cap` zur Steuerung der maximalen Anzahl von Gaussians hinzugefügt.
- **[2025-06-03]**: Wechsel zum Gsplat-Backend und Aktualisierung der Lizenz.
- **[2024-05-27]**: Aktualisierung auf LibTorch 2.7.0 für bessere Kompatibilität und Leistung. Breaking Changes im Optimizer-State-Management wurden behoben.
- **[2024-05-26]**: Ziel dieses Repos ist es, zu einer permissiven Lizenz zu wechseln. Umfangreiche Arbeiten wurden durchgeführt, um den Rasterizer durch die gsplat-Implementierung zu ersetzen.

## Metriken
Derzeit erreicht die Implementierung nicht die gleichen Ergebnisse wie gsplat-mcmc, befindet sich aber in Entwicklung.  
Es ist nur eine Frage der Zeit, den Fehler zu beheben. Hilfe ist willkommen :) Die Metriken für die MCMC-Strategie sind wie folgt:

| Szene    | Iteration | PSNR          | SSIM         | LPIPS        | Zeit pro Bild | Anzahl Gaussians |
| -------- | --------- | ------------- | ------------ | ------------ | ------------- | ---------------- |
| garden   | 30000     | 27.112114     | 0.854833     | 0.157624     | 0.304765      | 1000000          |
| bicycle  | 30000     | 25.047745     | 0.767729     | 0.254825     | 0.293618      | 1000000          |
| stump    | 30000     | 26.554749     | 0.784203     | 0.263013     | 0.296536      | 1000000          |
| bonsai   | 30000     | 32.534199     | 0.948675     | 0.246924     | 0.436188      | 1000000          |
| counter  | 30000     | 29.187017     | 0.915823     | 0.242159     | 0.441259      | 1000000          |
| kitchen  | 30000     | 31.680832     | 0.933897     | 0.154965     | 0.449078      | 1000000          |
| room     | 30000     | 32.211632     | 0.930754     | 0.273719     | 0.413519      | 1000000          |
| **mean** | **30000** | **29.189755** | **0.876559** | **0.227604** | **0.376423**  | **1000000**      |

## Community & Support

Tritt unserer wachsenden Community für Diskussionen, Support und Updates bei:  
- 💬 **[Discord Community](https://discord.gg/TbxJST2BbC)** – Hilfe erhalten, Ergebnisse teilen und Entwicklung diskutieren  
- 🌐 **[mrnerf.com](https://mrnerf.com)** – Besuche unsere Webseite für weitere Ressourcen  
- 📚 **[Awesome 3D Gaussian Splatting](https://mrnerf.github.io/awesome-3D-gaussian-splatting/)** – Umfangreiche Paper-Liste und Ressourcen  
- 🐦 **[@janusch_patas](https://twitter.com/janusch_patas)** – Folge für die neuesten Updates

## Build- und Ausführungsanweisungen

### Software-Voraussetzungen
1. **Linux** (getestet mit Ubuntu 22.04) – Windows wird derzeit nicht unterstützt  
2. **CMake** Version 3.24 oder höher  
3. **CUDA** 11.8 oder höher (kann mit manueller Konfiguration auch mit älteren Versionen funktionieren)  
4. **Python** mit Entwicklungsköpfen  
5. **LibTorch 2.7.0** – Installationsanleitung unten  
6. Andere Abhängigkeiten werden automatisch von CMake verwaltet

### Hardware-Voraussetzungen
1. **NVIDIA GPU** mit CUDA-Unterstützung  
    - Getestet mit: RTX 4090, RTX A5000, RTX 3090Ti, A100  
    - Bekannter Fehler mit RTX 3080Ti bei größeren Datensätzen (siehe #21)  
2. Minimale Compute Capability: 8.0

> Wenn du das Projekt erfolgreich auf anderer Hardware ausführst, teile deine Erfahrung bitte im Discussions-Bereich!

### Build-Anleitung

```bash
# Repository mit Submodulen klonen
git clone --recursive https://github.com/MrNeRF/gaussian-splatting-cuda
cd gaussian-splatting-cuda

# LibTorch herunterladen und einrichten
wget https://raw.githubusercontent.com/MrNeRF/gaussian-splatting-cuda/master/libtorch-cxx11-abi-shared-with-deps-2.7.0%2Bcu118.zip  
unzip libtorch-cxx11-abi-shared-with-deps-2.7.0+cu118.zip -d external/
rm libtorch-cxx11-abi-shared-with-deps-2.7.0+cu118.zip

# Projekt bauen
cmake -B build -DCMAKE_BUILD_TYPE=Release
cmake --build build -- -j
```

## LibTorch 2.7.0

Dieses Projekt verwendet **LibTorch 2.7.0** für optimale Leistung und Kompatibilität:

- **Verbesserte Leistung**: Optimierung und Speicherverwaltung wurden verbessert  
- **API-Stabilität**: Aktuell stabile PyTorch C++ API  
- **CUDA-Kompatibilität**: Bessere Integration mit CUDA 11.8+  
- **Fehlerbehebungen**: Probleme im Optimizer-State-Management gelöst

### Upgrade von vorherigen Versionen
1. Lade die neue LibTorch-Version mit den Build-Anweisungen herunter  
2. Lösche dein Build-Verzeichnis: `rm -rf build/`  
3. Baue das Projekt neu

## Datensatz

Lade den Datensatz aus dem Original-Repository herunter:  
[Tanks & Trains Dataset](https://repo-sam.inria.fr/fungraph/3d-gaussian-splatting/datasets/input/tandt_db.zip)

Entpacke ihn in den `data`-Ordner im Projektstammverzeichnis.

## Befehlszeilenoptionen

### Kernoptionen

- **`-h, --help`**  
  Zeigt das Hilfemenü an

- **`-d, --data-path [PFAD]`**  
  Pfad zu den Trainingsdaten (erforderlich)

- **`-o, --output-path [PFAD]`**  
  Pfad zum Speichern des trainierten Modells (Standard: `./output`)

- **`-i, --iter [ANZAHL]`**  
  Anzahl der Trainingsiterationen (Standard: 30000)  
    - Im Paper werden 30k empfohlen, aber 6k-7k liefern oft gute vorläufige Ergebnisse  
    - Ergebnisse werden alle 7k Iterationen und am Ende gespeichert

- **`-f, --force`**  
  Überschreibt vorhandenen Ausgabeordner zwangsweise

- **`-r, --resolution [ANZAHL]`**  
  Setzt die Auflösung für Trainingsbilder

### MCMC-spezifische Optionen

- **`--max-cap [ANZAHL]`**  
  Maximale Anzahl von Gaussians für die MCMC-Strategie (Standard: 1000000)  
    - Begrenzt die maximale Anzahl von Gaussian-Splats während des Trainings  
    - Nützlich bei speicherbeschränkten Umgebungen

### Beispielanwendung

Basis-Training:  
```bash
./build/gaussian_splatting_cuda -d /pfad/zu/daten -o /pfad/zum/ausgabe -i 10000
```

MCMC-Training mit begrenzter Gaussian-Anzahl:  
```bash
./build/gaussian_splatting_cuda -d /pfad/zu/daten -o /pfad/zum/ausgabe -i 10000 --max-cap 500000
```

## Richtlinien für Beiträge

Wir freuen uns über Beiträge! So fängst du an:

1. **Erste Schritte**:  
    - Schau dir Issues mit dem Label **good first issues** für anfängerfreundliche Aufgaben an  
    - Für neue Ideen öffne eine Diskussion oder trete unserem [Discord](https://discord.gg/TbxJST2BbC) bei

2. **Vor dem Einreichen eines PR**:  
    - Verwende `clang-format` für konsistenten Code-Stil  
    - Nutze den pre-commit Hook: `cp tools/pre-commit .git/hooks/`  
    - Diskutiere neue Abhängigkeiten zuerst in einem Issue – wir möchten Abhängigkeiten möglichst gering halten

## Danksagungen

Diese Implementierung basiert auf mehreren wichtigen Projekten:

- **[gsplat](https://github.com/nerfstudio-project/gsplat)**: Wir verwenden das hochoptimierte CUDA-Rasterisierungs-Backend von gsplat, das erhebliche Leistungsverbesserungen und bessere Speichereffizienz bietet.

- **Originales 3D Gaussian Splatting**: Basierend auf der bahnbrechenden Arbeit von Kerbl et al.

## Zitation

Wenn du diese Software in deiner Forschung verwendest, zitiere bitte die Originalarbeit:

```bibtex
@article{kerbl3Dgaussians,
  author    = {Kerbl, Bernhard und Kopanas, Georgios und Leimkühler, Thomas und Drettakis, George},
  title     = {3D Gaussian Splatting for Real-Time Radiance Field Rendering},
  journal   = {ACM Transactions on Graphics},
  number    = {4},
  volume    = {42},
  month     = {July},
  year      = {2023},
  url       = {https://repo-sam.inria.fr/fungraph/3d-gaussian-splatting/}
}
```

## Lizenz

Details siehe LICENSE-Datei.

---

**Verbinde dich mit uns:**  
- 🌐 Webseite: [mrnerf.com](https://mrnerf.com)  
- 📚 Papers: [Awesome 3D Gaussian Splatting](https://mrnerf.github.io/awesome-3D-gaussian-splatting/)  
- 💬 Discord: [Tritt unserer Community bei](https://discord.gg/TbxJST2BbC)  
- 🐦 Twitter: Folge [@janusch_patas](https://twitter.com/janusch_patas) für Entwicklungsupdates

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---