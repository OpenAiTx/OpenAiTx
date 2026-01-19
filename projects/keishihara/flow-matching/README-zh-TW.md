
<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=zh-CN">簡體中文</a>
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

# PyTorch 中的流量匹配

本儲存庫包含論文[Flow Matching for Generative Modeling](https://arxiv.org/abs/2210.02747)的簡單 PyTorch 實作。

## 二維流量匹配範例

下方的 GIF 展示了將單一高斯分布映射到棋盤格分布，並可視化了向量場。

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/checkerboard/vector_field_and_samples_checkerboard.gif" height="400" />
</p>

另外，這裡還有一個 moons 資料集的例子。

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/moons/vector_field_and_samples_moons.gif" height="400" />
</p>

## 入門指南

複製此程式庫並設置 Python 環境。

```bash
git clone https://github.com/keishihara/flow-matching.git
cd flow-matching
```

請確保已安裝 Python 3.12 以上版本。
安裝 `uv`：

```bash
curl -LsSf https://astral.sh/uv/install.sh | sh
```

然後，設定環境：

```bash
uv sync
```

## 條件流匹配 [Lipman+ 2023]

這是原始的 CFM 論文實作 [1]。部分程式碼元件取自 [2] 和 [3]。

### 二維玩具資料集

您可以在二維合成資料集上訓練 CFM 模型，例如 `checkerboard` 和 `moons`。請使用 `--dataset` 選項指定資料集名稱。訓練參數已在腳本中預先定義，訓練結果的視覺化資料將儲存在 `outputs/` 目錄中。模型檢查點未包含，因為可透過預設設定輕鬆重現。

```bash
uv run scripts/train_flow_matching_2d.py --dataset checkerboard
```
向量場和生成的樣本，如本 README 頂部所展示的 GIF，現在可以在 `outputs/cfm/` 目錄中找到。

### 圖像資料集

你也可以在熱門的圖像分類資料集上訓練類別條件式 CFM 模型。生成的樣本和模型檢查點都將存儲在 `outputs/cfm` 目錄中。若需詳細的訓練參數清單，請執行 `uv run scripts/train_flow_matching_on_image.py --help`。

要在 MNIST 資料集上訓練類別條件式 CFM，請執行：


```bash
uv run scripts/train_flow_matching_on_image.py --do_train --dataset mnist
```

訓練完成後，您現在可以使用以下方式生成樣本：

```bash
uv run scripts/train_flow_matching_on_image.py --do_sample --dataset mnist
```
現在，您應該可以在 `outputs/cfm/mnist/` 目錄中看到生成的樣本。

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/mnist/trajectory.gif" height="400" />
</p>

## Rectified Flow [Liu+ 2023]

這是 Rectified Flow 論文 [2] 中 Reflow 模型（具體為 2-Rectified Flow）的實現。

### 2D 合成數據

我們已經在 2d 合成數據集上實現了 Reflow，與 CFM 相同。為了訓練 reflow，您必須指定預訓練的 CFM 檢查點，因為 reflow 是一個蒸餾模型。

例如，若要在具有預訓練 CFM 檢查點的 `checkerboard` 數據集上進行訓練：


```bash
uv run scripts/train_reflow_2d.py --dataset checkerboard
```
訓練結果，包括向量場視覺化和生成樣本，會儲存在 `outputs/reflow/` 資料夾下。

### CFM 與 Reflow 取樣過程的比較

要在 2d 資料集上比較 CFM 和 Reflow，請執行：


```bash
uv run scripts/plot_comparison_2d.py --dataset checkerboard
```
產生的 GIF 檔案可在 `outputs/comparisons/` 資料夾下找到。以下是 `checkerboard` 資料集兩種方法的範例比較：

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/comparisons/cfm_reflow_checkerboard.gif" height="400" />
</p>

## 參考文獻

- [1] Lipman, Yaron, 等人. "Flow Matching for Generative Modeling." [arXiv:2210.02747](https://arxiv.org/abs/2210.02747)
- [2] Liu, Xingchao, 等人. "Flow Straight and Fast: Learning to Generate and Transfer Data with Rectified Flow." [arXiv:2209.03003](https://arxiv.org/abs/2209.03003)
- [3] [facebookresearch/flow_matching](https://github.com/facebookresearch/flow_matching)
- [4] [atong01/conditional-flow-matching](https://github.com/atong01/conditional-flow-matching)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-19

---