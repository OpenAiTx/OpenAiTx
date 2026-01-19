
<div align="right">
  <details>
    <summary >🌐 Język</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Dopasowywanie przepływu w PyTorch

To repozytorium zawiera prostą implementację w PyTorch artykułu [Flow Matching for Generative Modeling](https://arxiv.org/abs/2210.02747).

## Przykład dopasowywania przepływu w 2D

Poniższy gif demonstruje mapowanie pojedynczego rozkładu normalnego na rozkład szachownicowy, z wizualizacją pola wektorowego.

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/checkerboard/vector_field_and_samples_checkerboard.gif" height="400" />
</p>

A tutaj znajduje się inny przykład z użyciem zbioru danych moons.

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/moons/vector_field_and_samples_moons.gif" height="400" />
</p>

## Pierwsze kroki

Sklonuj repozytorium i skonfiguruj środowisko Pythona.

```bash
git clone https://github.com/keishihara/flow-matching.git
cd flow-matching
```

Upewnij się, że masz zainstalowanego Pythona w wersji 3.12+.
Zainstaluj `uv`:

```bash
curl -LsSf https://astral.sh/uv/install.sh | sh
```
Następnie skonfiguruj środowisko:


```bash
uv sync
```

## Conditional Flow Matching [Lipman+ 2023]

To jest oryginalna implementacja artykułu CFM [1]. Niektóre komponenty kodu zostały zaadaptowane z [2] oraz [3].

### Dwuwymiarowe zabawkowe zbiory danych

Modele CFM można trenować na dwuwymiarowych syntetycznych zbiorach danych takich jak `checkerboard` oraz `moons`. Nazwę zbioru danych należy określić za pomocą opcji `--dataset`. Parametry treningu są zdefiniowane w skrypcie, a wizualizacje wyników treningu są zapisywane w katalogu `outputs/`. Punkty kontrolne modeli nie są dołączone, ponieważ można je łatwo odtworzyć przy domyślnych ustawieniach.

```bash
uv run scripts/train_flow_matching_2d.py --dataset checkerboard
```

Pola wektorowe i wygenerowane próbki, takie jak te wyświetlane jako GIF-y na górze tego pliku README, można teraz znaleźć w katalogu `outputs/cfm/`.

### Zbiory danych obrazów

Możesz także trenować modele CFM warunkowane klasami na popularnych zbiorach danych do klasyfikacji obrazów. Zarówno wygenerowane próbki, jak i punkty kontrolne modeli będą przechowywane w katalogu `outputs/cfm`. Aby uzyskać szczegółową listę parametrów treningowych, uruchom `uv run scripts/train_flow_matching_on_image.py --help`.

Aby wytrenować model CFM warunkowany klasami na zbiorze danych MNIST, uruchom:

```bash
uv run scripts/train_flow_matching_on_image.py --do_train --dataset mnist
```

Po zakończeniu treningu możesz teraz generować próbki za pomocą:

```bash
uv run scripts/train_flow_matching_on_image.py --do_sample --dataset mnist
```

Teraz powinieneś zobaczyć wygenerowane próbki w katalogu `outputs/cfm/mnist/`.

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/mnist/trajectory.gif" height="400" />
</p>

## Rectified Flow [Liu+ 2023]

Jest to implementacja modelu Reflow (dokładniej 2-Rectified Flow) z artykułu Rectified Flow [2].

### Dane syntetyczne 2D

Zaimplementowaliśmy Reflow na syntetycznych zbiorach danych 2D, tak samo jak CFM. Aby wytrenować reflow, musisz podać wstępnie wytrenowane punkty kontrolne CFM, ponieważ reflow jest modelem destylacji.

Na przykład, aby trenować na zbiorze danych `checkerboard` z wstępnie wytrenowanym punktem kontrolnym CFM:

```bash
uv run scripts/train_reflow_2d.py --dataset checkerboard
```

Wyniki treningu, w tym wizualizacje pól wektorowych oraz wygenerowane próbki, są zapisywane w folderze `outputs/reflow/`.

### Porównanie procesu próbkowania między CFM a Reflow

Aby porównać CFM i Reflow na zbiorach danych 2D, uruchom:

```bash
uv run scripts/plot_comparison_2d.py --dataset checkerboard
```
Wynikowe pliki GIF można znaleźć w folderze `outputs/comparisons/`. Poniżej znajduje się przykładowe porównanie dwóch metod w zbiorze danych `checkerboard`:

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/comparisons/cfm_reflow_checkerboard.gif" height="400" />
</p>

## Odniesienia

- [1] Lipman, Yaron, i in. "Flow Matching for Generative Modeling." [arXiv:2210.02747](https://arxiv.org/abs/2210.02747)
- [2] Liu, Xingchao, i in. "Flow Straight and Fast: Learning to Generate and Transfer Data with Rectified Flow." [arXiv:2209.03003](https://arxiv.org/abs/2209.03003)
- [3] [facebookresearch/flow_matching](https://github.com/facebookresearch/flow_matching)
- [4] [atong01/conditional-flow-matching](https://github.com/atong01/conditional-flow-matching)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-19

---