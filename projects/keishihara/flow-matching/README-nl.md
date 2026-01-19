
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=en">Engels</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=ja">Japans</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=ko">Koreaans</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=th">Thais</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=fr">Frans</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=de">Duits</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=es">Spaans</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=it">Italiaans</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=pt">Portugees</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=pl">Pools</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=ar">Arabisch</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=fa">Perzisch</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=tr">Turks</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=vi">Vietnamees</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=id">Indonesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Flow Matching in PyTorch

Deze repository bevat een eenvoudige PyTorch-implementatie van het artikel [Flow Matching for Generative Modeling](https://arxiv.org/abs/2210.02747).

## 2D Flow Matching Voorbeeld

De onderstaande gif demonstreert het omzetten van een enkele Gaussische distributie naar een schaakbord-distributie, waarbij het vectorveld wordt gevisualiseerd.

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/checkerboard/vector_field_and_samples_checkerboard.gif" height="400" />
</p>

En hier is een ander voorbeeld van de moons-dataset.

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/moons/vector_field_and_samples_moons.gif" height="400" />
</p>

## Aan de slag

Kloon de repository en stel de python-omgeving in.

```bash
git clone https://github.com/keishihara/flow-matching.git
cd flow-matching
```

Zorg ervoor dat je Python 3.12+ hebt geïnstalleerd.
Installeer `uv`:

```bash
curl -LsSf https://astral.sh/uv/install.sh | sh
```
  
Stel vervolgens de omgeving in:

```bash
uv sync
```

## Conditionele Flow Matching [Lipman+ 2023]

Dit is de originele CFM paperimplementatie [1]. Sommige onderdelen van de code zijn aangepast uit [2] en [3].

### 2D Speelgoeddatasets

U kunt de CFM-modellen trainen op 2D synthetische datasets zoals `checkerboard` en `moons`. Geef de naam van de dataset op met de optie `--dataset`. Trainingsparameters zijn vooraf ingesteld in het script en visualisaties van de trainingsresultaten worden opgeslagen in de map `outputs/`. Modelcheckpoints zijn niet inbegrepen omdat ze eenvoudig te reproduceren zijn met de standaardinstellingen.

```bash
uv run scripts/train_flow_matching_2d.py --dataset checkerboard
```

De vectorvelden en gegenereerde samples, zoals weergegeven in de GIFs bovenaan deze README, zijn nu te vinden in de map `outputs/cfm/`.

### Afbeeldingendatasets

Je kunt ook klasse-geconditioneerde CFM-modellen trainen op populaire beeldclassificatiedatasets. Zowel de gegenereerde samples als de modelcheckpoints worden opgeslagen in de map `outputs/cfm`. Voor een gedetailleerde lijst van trainingsparameters, voer `uv run scripts/train_flow_matching_on_image.py --help` uit.

Om een klasse-geconditioneerde CFM op de MNIST-dataset te trainen, voer uit:

```bash
uv run scripts/train_flow_matching_on_image.py --do_train --dataset mnist
```

Na de training kun je nu voorbeelden genereren met:

```bash
uv run scripts/train_flow_matching_on_image.py --do_sample --dataset mnist
```

Nu zou je de gegenereerde samples moeten kunnen zien in de map `outputs/cfm/mnist/`.

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/mnist/trajectory.gif" height="400" />
</p>

## Gecorrigeerde Flow [Liu+ 2023]

Dit is een implementatie van het Reflow-model (specifiek 2-Gecorrigeerde Flow) uit het Rectified Flow-paper [2].

### 2D Synthetische Data

We hebben Reflow geïmplementeerd op 2d synthetische datasets, hetzelfde als de CFM. Om de reflow te trainen, moet je vooraf getrainde CFM-checkpoints opgeven omdat reflow een distillatiemodel is.

Bijvoorbeeld, om te trainen op de `checkerboard` dataset met een vooraf getraind CFM-checkpoint:

```bash
uv run scripts/train_reflow_2d.py --dataset checkerboard
```

De trainingsresultaten, inclusief visualisaties van vectorvelden en gegenereerde samples, worden opgeslagen in de map `outputs/reflow/`.

### Vergelijking van het samplingproces tussen CFM en Reflow

Om CFM en Reflow op 2D-datasets te vergelijken, voer uit:

```bash
uv run scripts/plot_comparison_2d.py --dataset checkerboard
```
De resulterende GIF's zijn te vinden in de map `outputs/comparisons/`. Hieronder staat een voorbeeldvergelijking van de twee methoden in de `checkerboard` dataset:

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/comparisons/cfm_reflow_checkerboard.gif" height="400" />
</p>

## Referenties

- [1] Lipman, Yaron, et al. "Flow Matching for Generative Modeling." [arXiv:2210.02747](https://arxiv.org/abs/2210.02747)
- [2] Liu, Xingchao, et al. "Flow Straight and Fast: Learning to Generate and Transfer Data with Rectified Flow." [arXiv:2209.03003](https://arxiv.org/abs/2209.03003)
- [3] [facebookresearch/flow_matching](https://github.com/facebookresearch/flow_matching)
- [4] [atong01/conditional-flow-matching](https://github.com/atong01/conditional-flow-matching)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-19

---