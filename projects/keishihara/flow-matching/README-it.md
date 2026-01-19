
<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
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

# Flow Matching in PyTorch

Questo repository contiene una semplice implementazione in PyTorch dell’articolo [Flow Matching for Generative Modeling](https://arxiv.org/abs/2210.02747).

## Esempio di Flow Matching 2D

La gif qui sotto mostra la mappatura di una singola distribuzione Gaussiana su una distribuzione a scacchiera, con il campo vettoriale visualizzato.

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/checkerboard/vector_field_and_samples_checkerboard.gif" height="400" />
</p>

Ecco un altro esempio con il dataset delle lune.

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/moons/vector_field_and_samples_moons.gif" height="400" />
</p>

## Introduzione

Clona il repository e configura l'ambiente python.

```bash
git clone https://github.com/keishihara/flow-matching.git
cd flow-matching
```

Assicurati di avere installato Python 3.12 o superiore.
Installa `uv`:

```bash
curl -LsSf https://astral.sh/uv/install.sh | sh
```

Quindi, configura l'ambiente:

```bash
uv sync
```

## Conditional Flow Matching [Lipman+ 2023]

Questa è l'implementazione originale dell'articolo CFM [1]. Alcuni componenti del codice sono adattati da [2] e [3].

### Dataset 2D Toy

È possibile addestrare i modelli CFM su dataset sintetici 2D come `checkerboard` e `moons`. Specificare il nome del dataset utilizzando l'opzione `--dataset`. I parametri di addestramento sono predefiniti nello script, e le visualizzazioni dei risultati dell'addestramento sono memorizzate nella directory `outputs/`. I checkpoint del modello non sono inclusi in quanto facilmente riproducibili con le impostazioni predefinite.

```bash
uv run scripts/train_flow_matching_2d.py --dataset checkerboard
```

I campi vettoriali e i campioni generati, come quelli mostrati come GIF all'inizio di questo README, possono ora essere trovati nella directory `outputs/cfm/`.

### Dataset di Immagini

Puoi anche addestrare modelli CFM condizionati sulla classe su popolari dataset di classificazione di immagini. Sia i campioni generati che i checkpoint dei modelli saranno salvati nella directory `outputs/cfm`. Per una lista dettagliata dei parametri di addestramento, esegui `uv run scripts/train_flow_matching_on_image.py --help`.

Per addestrare un modello CFM condizionato sulla classe sul dataset MNIST, esegui:

```bash
uv run scripts/train_flow_matching_on_image.py --do_train --dataset mnist
```

Dopo l'addestramento, ora puoi generare campioni con:

```bash
uv run scripts/train_flow_matching_on_image.py --do_sample --dataset mnist
```

Ora dovresti essere in grado di vedere i campioni generati nella directory `outputs/cfm/mnist/`.

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/mnist/trajectory.gif" height="400" />
</p>

## Rectified Flow [Liu+ 2023]

Questa è un'implementazione del modello Reflow (2-Rectified Flow per la precisione) dal paper Rectified Flow [2].

### Dati Sintetici 2D

Abbiamo implementato Reflow su dataset sintetici 2d, così come il CFM. Per addestrare reflow, devi specificare checkpoint CFM pre-addestrati poiché reflow è un modello di distillazione.

Ad esempio, per addestrare sul dataset `checkerboard` con un checkpoint CFM pre-addestrato:

```bash
uv run scripts/train_reflow_2d.py --dataset checkerboard
```

I risultati dell'addestramento, incluse le visualizzazioni del campo vettoriale e i campioni generati, sono salvati nella cartella `outputs/reflow/`.

### Confronto del processo di campionamento tra CFM e Reflow

Per confrontare CFM e Reflow su dataset 2d, eseguire:

```bash
uv run scripts/plot_comparison_2d.py --dataset checkerboard
```

Le GIF risultanti possono essere trovate nella cartella `outputs/comparisons/`. Di seguito è riportato un esempio di confronto tra i due metodi nel dataset `checkerboard`:

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/comparisons/cfm_reflow_checkerboard.gif" height="400" />
</p>

## Riferimenti

- [1] Lipman, Yaron, et al. "Flow Matching for Generative Modeling." [arXiv:2210.02747](https://arxiv.org/abs/2210.02747)
- [2] Liu, Xingchao, et al. "Flow Straight and Fast: Learning to Generate and Transfer Data with Rectified Flow." [arXiv:2209.03003](https://arxiv.org/abs/2209.03003)
- [3] [facebookresearch/flow_matching](https://github.com/facebookresearch/flow_matching)
- [4] [atong01/conditional-flow-matching](https://github.com/atong01/conditional-flow-matching)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-19

---