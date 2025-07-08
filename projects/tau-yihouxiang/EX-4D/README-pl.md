# EX-4D: Synteza wideo 4D z ekstremalnych punktów widzenia za pomocą szczelnej siatki głębi

<div align="center">

<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/docs/Logo.png" alt="EX-4D Logo" width="250">

[📄 Artykuł](https://arxiv.org/abs/2506.05554)  |  [🎥 Strona domowa](https://tau-yihouxiang.github.io/projects/EX-4D/EX-4D.html)  |  [💻 Kod](https://github.com/tau-yihouxiang/EX-4D)

</div>



## 🌟 Najważniejsze cechy

- **🎯 Synteza z ekstremalnych punktów widzenia**: Generowanie wysokiej jakości wideo 4D z ruchem kamery od -90° do 90°
- **🔧 Szczelna siatka głębi**: Nowatorska reprezentacja geometryczna modelująca zarówno widoczne, jak i zasłonięte obszary
- **⚡ Lekka architektura**: Tylko 1% parametrów uczących się (140M) w stosunku do 14B głównego modelu dyfuzji wideo
- **🎭 Bez treningu na wielu widokach**: Innowacyjna strategia maskowania eliminuje potrzebę kosztownych zestawów danych z wielu kamer
- **🏆 Najwyższa jakość**: Przewyższa istniejące metody, szczególnie przy ekstremalnych kątach kamery

## 🎬 Wyniki demonstracyjne

<div align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/docs/teaser.png" alt="EX-4D Demo Results" width="800">
</div>

*EX-4D przekształca filmy monokularne w doświadczenia 4D sterowane kamerą, zapewniając fizycznie spójne wyniki pod ekstremalnymi kątami widzenia.*

## 🏗️ Przegląd frameworku

<div align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/docs/overview.png" alt="EX-4D Architecture">
</div>

Nasz framework składa się z trzech kluczowych komponentów:

1. **🔺 Konstrukcja szczelnej siatki głębi (Depth Watertight Mesh)**: Tworzy solidny priorytet geometryczny, który jawnie modeluje zarówno widoczne, jak i ukryte obszary
2. **🎭 Symulowana strategia maskowania**: Generuje skuteczne dane treningowe z filmów monokularnych bez użycia zestawów danych z wielu widoków
3. **⚙️ Lekki adapter LoRA**: Efektywnie integruje informacje geometryczne z wytrenowanymi modelami dyfuzji wideo

## 🚀 Szybki start

### Instalacja

```bash
# Sklonuj repozytorium
git clone https://github.com/tau-yihouxiang/EX-4D.git
cd EX-4D

# Utwórz środowisko conda
conda create -n ex4d python=3.10
conda activate ex4d
# Zainstaluj PyTorch (zalecana wersja 2.x)
pip install torch==2.4.1 torchvision==0.19.1 torchaudio==2.4.1 --index-url https://download.pytorch.org/whl/cu124
# Zainstaluj Nvdiffrast
pip install git+https://github.com/NVlabs/nvdiffrast.git
# Zainstaluj zależności oraz diffsynth
pip install -e .
# Zainstaluj depthcrafter do estymacji głębi. (Postępuj zgodnie z instrukcją DepthCrafter dotyczącą przygotowania punktów kontrolnych.)
git clone https://github.com/Tencent/DepthCrafter.git
```

### Pobierz wytrenowany model
```bash
huggingface-cli download Wan-AI/Wan2.1-I2V-14B-480P --local-dir ./models/Wan-AI
huggingface-cli download yihouxiang/EX-4D --local-dir ./models/EX-4D
```

### Przykład użycia
#### 1. Rekonstrukcja DW-Mesh
```bash
# --cam 180 (30 / 60 / 90 / zoom_in / zoom_out )
python recon.py --input_video examples/flower/input.mp4 --cam 180 --output_dir outputs/flower --save_mesh
```
#### 2. Generowanie EX-4D (wymagane 48GB VRAM)
```bash
python generate.py --color_video outputs/flower/color_180.mp4 --mask_video outputs/flower/mask_180.mp4 --output_video outputs/flower/output.mp4
```

<table>
<tr>
<td width="45%" align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/examples/flower/input.gif" width="100%">
<br><b>Wideo wejściowe</b>
</td>
<td align="center">
<div style="font-size: 2em; color: #4A90E2; padding: 0 0px;">
  ➜
</div>
</td>
<td width="45%" align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/examples/flower/output.gif" width="100%">
<br><b>Wideo wyjściowe</b>
</td>
</tr> 
</table>

<!-- ## 📊 Performance

### Quantitative Results
| Metoda | FID (Ekstremalny) ↓ | FVD (Ekstremalny) ↓ | Wynik VBench ↑ |
|--------|---------------------|---------------------|----------------|
| ReCamMaster | 64.68 | 943.45 | 0.434 |
| TrajectoryCrafter | 65.33 | 893.80 | 0.447 |
| TrajectoryAttention | 62.49 | 912.14 | 0.389 |
| **EX-4D (Nasza metoda)** | **55.42** | **823.61** | **0.450** | -->

### Wyniki badań użytkowników

- **70,7%** uczestników preferowało EX-4D względem metod bazowych
- Lepsza spójność fizyczna i jakość przy ekstremalnych kątach widzenia
- Znacząca poprawa wraz ze wzrostem ekstremalności kątów kamery


## 🎯 Zastosowania

- **🎮 Gry**: Tworzenie immersyjnych filmowych scen 3D na podstawie materiału 2D
- **🎬 Produkcja filmowa**: Generowanie nowych ujęć kamery do postprodukcji
- **🥽 VR/AR**: Tworzenie doświadczeń wideo z dowolnego punktu widzenia
- **📱 Media społecznościowe**: Generowanie dynamicznych ruchów kamery do tworzenia treści
- **🏢 Architektura**: Wizualizacja przestrzeni z wielu punktów widzenia

<!-- ## 📈 Benchmarki -->

<!-- ### Ocena zakresu punktów widzenia

| Zakres | Mały (0°→30°) | Duży (0°→60°) | Ekstremalny (0°→90°) | Pełny (-90°→90°) |
|--------|---------------|---------------|----------------------|------------------|
| Wynik FID | 44.19 | 50.30 | 55.42 | - |
| Różnica wydajności | +9,1% lepiej | +8,9% lepiej | +11,3% lepiej | +15,5% lepiej | -->

<!-- *Różnica wydajności względem drugiej najlepszej metody w każdej kategorii.* -->

## ⚠️ Ograniczenia

- **Zależność od głębi**: Wydajność zależy od jakości estymacji głębi z jednego obrazu
- **Koszt obliczeniowy**: Wymaga dużej mocy obliczeniowej dla filmów w wysokiej rozdzielczości
- **Powierzchnie refleksyjne**: Trudności z materiałami odblaskowymi lub przezroczystymi

## 🔮 Przyszłe prace
- [ ] Optymalizacja wnioskowania w czasie rzeczywistym (3DGS / 4DGS)
- [ ] Wsparcie dla wyższych rozdzielczości (1K, 2K)
- [ ] Techniki neuronowego udoskonalania siatek (mesh refinement)

## 🙏 Podziękowania

Chcielibyśmy podziękować projektowi [DiffSynth-Studio v1.1.1](https://github.com/modelscope/DiffSynth-Studio/tree/v1.1.1) za udostępnienie podstawowego frameworka dyfuzyjnego.

## 📚 Cytowanie

Jeśli nasza praca okazała się przydatna, prosimy o cytowanie:

```bibtex
@misc{hu2025ex4dextremeviewpoint4d,
      title={EX-4D: EXtreme Viewpoint 4D Video Synthesis via Depth Watertight Mesh}, 
      author={Tao Hu and Haoyang Peng and Xiao Liu and Yuewen Ma},
      year={2025},
      eprint={2506.05554},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2506.05554}, 
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---