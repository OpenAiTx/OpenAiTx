
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=en">Englisch</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=ja">Japanisch</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=ko">Koreanisch</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=th">Thai</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=fr">Französisch</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=es">Spanisch</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=it">Italienisch</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=pt">Portugiesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=nl">Niederländisch</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=pl">Polnisch</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=tr">Türkisch</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=vi">Vietnamesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=id">Indonesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Flow Matching in PyTorch

Dieses Repository enthält eine einfache PyTorch-Implementierung des Papers [Flow Matching for Generative Modeling](https://arxiv.org/abs/2210.02747).

## 2D Flow Matching Beispiel

Das folgende GIF demonstriert die Abbildung einer einzelnen Gaußschen Verteilung auf eine Schachbrettverteilung, wobei das Vektorfeld visualisiert wird.

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/checkerboard/vector_field_and_samples_checkerboard.gif" height="400" />
</p>

Und hier ist ein weiteres Beispiel mit dem Moons-Datensatz.

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/moons/vector_field_and_samples_moons.gif" height="400" />
</p>

## Erste Schritte

Klonen Sie das Repository und richten Sie die Python-Umgebung ein.

```bash
git clone https://github.com/keishihara/flow-matching.git
cd flow-matching
```

Stellen Sie sicher, dass Python 3.12+ installiert ist.
Installieren Sie `uv`:

```bash
curl -LsSf https://astral.sh/uv/install.sh | sh
```

Richten Sie anschließend die Umgebung ein:

```bash
uv sync
```

## Conditional Flow Matching [Lipman+ 2023]

Dies ist die Originalimplementierung des CFM-Papers [1]. Einige Komponenten des Codes wurden aus [2] und [3] übernommen.

### 2D Toy Datasets

Sie können die CFM-Modelle auf 2D-synthetischen Datensätzen wie `checkerboard` und `moons` trainieren. Geben Sie den Namen des Datensatzes mit der Option `--dataset` an. Trainingsparameter sind im Skript vordefiniert, und Visualisierungen der Trainingsergebnisse werden im Verzeichnis `outputs/` gespeichert. Modell-Checkpoints sind nicht enthalten, da sie mit den Standardeinstellungen leicht reproduzierbar sind.

```bash
uv run scripts/train_flow_matching_2d.py --dataset checkerboard
```

Die Vektorfelder und generierten Beispiele, wie sie als GIFs oben in diesem README angezeigt werden, sind jetzt im Verzeichnis `outputs/cfm/` zu finden.

### Bilddatensätze

Sie können auch klassenkonditionale CFM-Modelle auf bekannten Bildklassifikationsdatensätzen trainieren. Sowohl die generierten Beispiele als auch die Modell-Checkpoints werden im Verzeichnis `outputs/cfm` gespeichert. Eine detaillierte Liste der Trainingsparameter erhalten Sie mit `uv run scripts/train_flow_matching_on_image.py --help`.

Um ein klassenkonditionales CFM auf dem MNIST-Datensatz zu trainieren, führen Sie aus:

```bash
uv run scripts/train_flow_matching_on_image.py --do_train --dataset mnist
```

Nach dem Training können Sie jetzt Proben erzeugen mit:

```bash
uv run scripts/train_flow_matching_on_image.py --do_sample --dataset mnist
```

Nun sollten Sie die generierten Beispiele im Verzeichnis `outputs/cfm/mnist/` sehen können.

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/mnist/trajectory.gif" height="400" />
</p>

## Rectified Flow [Liu+ 2023]

Dies ist eine Implementierung des Reflow-Modells (genauer gesagt 2-Rectified Flow) aus dem Rectified Flow Paper [2].

### 2D Synthetische Daten

Wir haben den Reflow auf 2D-synthetischen Datensätzen implementiert, genau wie beim CFM. Um den Reflow zu trainieren, müssen Sie vortrainierte CFM-Checkpoints angeben, da Reflow ein Distillationsmodell ist.

Zum Beispiel, um auf dem Datensatz `checkerboard` mit einem vortrainierten CFM-Checkpoint zu trainieren:

```bash
uv run scripts/train_reflow_2d.py --dataset checkerboard
```

Die Trainingsergebnisse, einschließlich Vektorfeld-Visualisierungen und generierter Muster, werden im Ordner `outputs/reflow/` gespeichert.

### Vergleich des Sampling-Prozesses zwischen CFM und Reflow

Um CFM und Reflow auf 2D-Datensätzen zu vergleichen, führen Sie Folgendes aus:

```bash
uv run scripts/plot_comparison_2d.py --dataset checkerboard
```

Die resultierenden GIFs sind im Ordner `outputs/comparisons/` zu finden. Unten ist ein Beispielvergleich der beiden Methoden im `checkerboard`-Datensatz:

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/comparisons/cfm_reflow_checkerboard.gif" height="400" />
</p>

## Referenzen

- [1] Lipman, Yaron, et al. „Flow Matching for Generative Modeling.“ [arXiv:2210.02747](https://arxiv.org/abs/2210.02747)
- [2] Liu, Xingchao, et al. „Flow Straight and Fast: Learning to Generate and Transfer Data with Rectified Flow.“ [arXiv:2209.03003](https://arxiv.org/abs/2209.03003)
- [3] [facebookresearch/flow_matching](https://github.com/facebookresearch/flow_matching)
- [4] [atong01/conditional-flow-matching](https://github.com/atong01/conditional-flow-matching)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-19

---