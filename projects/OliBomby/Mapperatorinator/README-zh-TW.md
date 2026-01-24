
<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Mapperatorinator

您可以在 [這裡](https://colab.research.google.com/github/OliBomby/Mapperatorinator/blob/main/colab/mapperatorinator_inference.ipynb) 試用生成模型，或在 [這裡](https://colab.research.google.com/github/OliBomby/Mapperatorinator/blob/main/colab/mai_mod_inference.ipynb) 試用 MaiMod。您也可以觀看影片展示 [這裡](https://youtu.be/FEr7t1L2EoA)。

Mapperatorinator 是一個多模型框架，使用聲譜圖作為輸入，能夠生成完整功能的 osu! 所有模式的譜面，並可[協助譜面修改](#maimod-the-ai-driven-modding-tool)。
本專案的目標是能自動從任何歌曲生成可排名、品質優良且高度可自訂化的 osu! 譜面。

本專案建立於 [osuT5](https://github.com/gyataro/osuT5) 和 [osu-diffusion](https://github.com/OliBomby/osu-diffusion) 之上。開發過程中，我花費約 2500 小時的 GPU 運算時間，總共在我的 4060 Ti 及租用的 vast.ai 4090 伺服器上進行了 142 次訓練。

#### 請負責任地使用此工具。始終在你的 beatmap 中揭露 AI 的使用。

## 安裝

以下說明可讓你在本機產生 beatmap，或是選擇使用 [colab 筆記本](https://colab.research.google.com/github/OliBomby/Mapperatorinator/blob/main/colab/mapperatorinator_inference.ipynb) 在雲端運行。

### 1. 複製此儲存庫

```sh
git clone https://github.com/OliBomby/Mapperatorinator.git
cd Mapperatorinator
```

### 2.（可選）建立虛擬環境

請使用 Python 3.10，較新版本可能與相關依賴項不相容。

```sh
python -m venv .venv

# In cmd.exe
.venv\Scripts\activate.bat
# In PowerShell
.venv\Scripts\Activate.ps1
# In Linux or MacOS
source .venv/bin/activate
```

### 3. 安裝相依套件

- Python 3.10
- [Git](https://git-scm.com/downloads)
- [ffmpeg](http://www.ffmpeg.org/)
- [CUDA](https://developer.nvidia.com/cuda-zone)（適用於 NVIDIA GPU）或 [ROCm](https://rocmdocs.amd.com/en/latest/Installation_Guide/Installation-Guide.html)（適用於 linux 上的 AMD GPU）
- [PyTorch](https://pytorch.org/get-started/locally/)：請確保依照 Get Started 指南安裝具備 GPU 支援的 `torch` 和 `torchaudio`，並選擇你在前一步安裝的正確運算平台版本。

- 以及其餘的 Python 相依套件：

```sh
pip install -r requirements.txt
```

## 網頁圖形介面（推薦）

為了獲得更友善的使用體驗，建議使用網頁使用者介面。它提供圖形化介面以設定生成參數、啟動流程並監控輸出結果。

### 啟動圖形介面

請在終端機中導航到已複製的 `Mapperatorinator` 目錄並執行：

```sh
python web-ui.py
```
這將啟動一個本地網頁伺服器，並自動在新視窗中開啟使用者介面。

### 使用圖形介面

- **設定：** 使用表單欄位和「瀏覽」按鈕設置輸入/輸出路徑。調整產生參數，如遊戲模式、難度、風格（年份、譜師ID、描述詞）、時間、特定功能（打擊音、超級時間點）等，這些都與命令列選項相同。（注意：若提供了 `beatmap_path`，介面會自動從中判斷 `audio_path` 和 `output_path`，因此可將這些欄位留空）
- **開始：** 點擊「開始推論」按鈕以開始譜面生成。
- **取消：** 可使用「取消推論」按鈕停止進行中的作業。
- **開啟輸出：** 完成後，請使用「開啟輸出資料夾」按鈕快速存取產生的檔案。

網頁介面作為 `inference.py` 腳本的便利包裝。若需進階選項或疑難排解，請參閱命令列指令說明。

![python_u3zyW0S3Vs](https://github.com/user-attachments/assets/5312a45f-d51c-4b37-9389-da3258ddd0a1)

## 命令列推論

對於偏好命令列操作或需要進階設定的使用者，請依照下方步驟進行。**注意：** 若需更簡易的圖形介面，請參見上方的 [Web UI（推薦）](#web-ui-recommended) 章節。

執行 `inference.py` 並傳入一些參數以產生譜面。此處請使用 [Hydra 覆蓋語法](https://hydra.cc/docs/advanced/override_grammar/basic/)。所有可用參數請參見 `configs/inference_v29.yaml`。

```
python inference.py \
  audio_path           [Path to input audio] \
  output_path          [Path to output directory] \
  beatmap_path         [Path to .osu file to autofill metadata, and output_path, or use as reference] \
  
  gamemode             [Game mode to generate 0=std, 1=taiko, 2=ctb, 3=mania] \
  difficulty           [Difficulty star rating to generate] \
  mapper_id            [Mapper user ID for style] \
  year                 [Upload year to simulate] \
  hitsounded           [Whether to add hitsounds] \
  slider_multiplier    [Slider velocity multiplier] \
  circle_size          [Circle size] \
  keycount             [Key count for mania] \
  hold_note_ratio      [Hold note ratio for mania 0-1] \
  scroll_speed_ratio   [Scroll speed ratio for mania and ctb 0-1] \
  descriptors          [List of beatmap user tags for style] \
  negative_descriptors [List of beatmap user tags for classifier-free guidance] \
  
  add_to_beatmap       [Whether to add generated content to the reference beatmap instead of making a new beatmap] \
  start_time           [Generation start time in milliseconds] \
  end_time             [Generation end time in milliseconds] \
  in_context           [List of additional context to provide to the model [NONE,TIMING,KIAI,MAP,GD,NO_HS]] \
  output_type          [List of content types to generate] \
  cfg_scale            [Scale of the classifier-free guidance] \
  super_timing         [Whether to use slow accurate variable BPM timing generator] \
  seed                 [Random seed for generation] \
```

範例：
```
python inference.py beatmap_path="'C:\Users\USER\AppData\Local\osu!\Songs\1 Kenji Ninuma - DISCO PRINCE\Kenji Ninuma - DISCOPRINCE (peppy) [Normal].osu'" gamemode=0 difficulty=5.5 year=2023 descriptors="['jump aim','clean']" in_context=[TIMING,KIAI]
```

## 互動式 CLI
對於偏好終端機工作流程但希望有引導式設定的用戶，互動式 CLI 指令稿是 Web UI 的絕佳替代方案。

### 啟動 CLI
請移動到已複製的目錄。您可能需要先將指令稿設為可執行檔。

```sh
# Make the script executable (only needs to be done once)
chmod +x cli_inference.sh
```

```sh
# Run the script
./cli_inference.sh
```
### 使用 CLI
此腳本會引導你通過一系列提示來配置所有生成參數，就像 Web UI 一樣。

它使用彩色編碼的介面以提高清晰度。
它提供進階的多選選單，可使用方向鍵和空白鍵選擇風格描述詞。
在你回答完所有問題後，它會顯示最終的命令供你審查。
你可以直接確認執行，或取消並複製命令以供手動使用。

## 生成提示

- 你可以編輯 `configs/inference_v29.yaml` 並在其中添加你的參數，而無需每次都在終端機輸入。
- 所有可用的描述詞可在[這裡](https://osu.ppy.sh/wiki/en/Beatmap/Beatmap_tags)找到。
- 請務必提供 2007 到 2023 年之間的年份參數。如果留空，模型可能會生成風格不一致的結果。
- 請務必提供難度參數。如果留空，模型可能會生成難度不一致的結果。
- 提高 `cfg_scale` 參數可提升 `mapper_id` 和 `descriptors` 參數的有效性。
- 你可以使用 `negative_descriptors` 參數來引導模型避免某些風格。這僅在 `cfg_scale > 1` 時有效。請確保負面描述詞的數量與描述詞相等。
- 如果你的歌曲風格和期望的譜面風格不太相符，模型可能無法按照你的指示生成。例如，對於一首平靜的歌，很難生成高 SR、高 SV 的譜面。
- 如果你已經為歌曲完成了 timing 和 kiai 時間，則可以將這些資訊提供給模型，大幅提升推理速度與準確性：使用 `beatmap_path` 和 `in_context=[TIMING,KIAI]` 參數。
- 若只想重製譜面的一部分，請使用 `beatmap_path`、`start_time`、`end_time` 和 `add_to_beatmap=true` 參數。
- 若要為一個譜面生成來賓難度，請使用 `beatmap_path` 和 `in_context=[GD,TIMING,KIAI]` 參數。
- 若要為譜面生成打擊音，請使用 `beatmap_path` 和 `in_context=[NO_HS,TIMING,KIAI]` 參數。
- 若只想為歌曲生成 timing，請使用 `super_timing=true` 和 `output_type=[TIMING]` 參數。

## MaiMod：AI 驅動的 Modding 工具

MaiMod 是一個針對 osu! 譜面的 modding 工具，利用 Mapperatorinator 的預測來發現其他自動化 modding 工具如 [Mapset Verifier](https://github.com/Naxesss/MapsetVerifier) 無法偵測的潛在錯誤與不一致之處。
它可以偵測以下問題：
- 不正確的對齊或節奏型態
- 不準確的節奏點
- 不一致的物件位置或新連打組的分配
- 奇怪的滑條形狀
- 不一致的打擊音或音量

你可以在[這裡](https://colab.research.google.com/github/OliBomby/Mapperatorinator/blob/main/colab/mai_mod_inference.ipynb)試用 MaiMod，或在本地端執行：
若要在本地執行 MaiMod，你需要先安裝 Mapperatorinator。然後運行 `mai_mod.py` 腳本，並用 `beatmap_path` 參數指定你的譜面路徑。

```sh
python mai_mod.py beatmap_path="'C:\Users\USER\AppData\Local\osu!\Songs\1 Kenji Ninuma - DISCO PRINCE\Kenji Ninuma - DISCOPRINCE (peppy) [Normal].osu'"
```
這會將改譜建議列印到主控台，接著你可以手動將其套用到你的譜面上。
建議會依時間順序排列並分門別類。
圓圈內的第一個數值代表「驚異值」，這是模型判斷該問題出乎意料程度的指標，因此你可以優先處理最重要的問題。

模型可能會出錯，特別是在驚異值較低的問題上，因此在套用建議到你的譜面前，務必再次確認。
主要目的是協助你縮小潛在問題的搜尋範圍，讓你不必手動檢查譜面中的每一個物件。

### MaiMod 圖形介面
若要執行 MaiMod Web UI，你需要先安裝 Mapperatorinator。
然後，執行 `mai_mod_ui.py` 腳本。這會啟動本地網頁伺服器並自動在新視窗開啟 UI：

```sh
python mai_mod_ui.py
```

<img width="850" height="1019" alt="afbeelding" src="https://github.com/user-attachments/assets/67c03a43-a7bd-4265-a5b1-5e4d62aca1fa" />

## 概覽

### 標記化

Mapperatorinator 會將 osu! 的譜面轉換為中介事件表示，這種表示可以直接轉換為標記，或從標記轉換回來。
它包含擊打物件、擊打音效、滑條速度、新組合、計時點、Kiai 時間，以及太鼓/mania 的滾動速度。

以下是標記化過程的小範例：

![mapperatorinator_parser](https://github.com/user-attachments/assets/84efde76-4c27-48a1-b8ce-beceddd9e695)

為了減少詞彙表的大小，時間事件會量化為 10 毫秒間隔，位置座標則量化至 32 像素的網格點。

### 模型架構
本模型基本上是包裝在 [HF Transformers Whisper](https://huggingface.co/docs/transformers/en/model_doc/whisper#transformers.WhisperForConditionalGeneration) 模型之上，並加入自訂的輸入嵌入與損失函數。
模型大小約為 2.19 億個參數。
實驗發現這個模型在此任務上比 T5 更快且更準確。

模型輸入輸出的高階概覽如下：

![Picture2](https://user-images.githubusercontent.com/28675590/201044116-1384ad72-c540-44db-a285-7319dd01caad.svg)

模型使用梅爾頻譜圖幀作為編碼器輸入，每個輸入位置一個幀。模型的解碼器在每一步的輸出是針對離散、預先定義事件詞彙表的 softmax 分布。輸出是稀疏的，僅在有擊打物件發生時才需要事件，而不是標註每個音訊幀。

### 多任務訓練格式

![Multitask training format](https://github.com/user-attachments/assets/62f490bc-a567-4671-a7ce-dbcc5f9cd6d9)

在 SOS 標記前會有額外的標記，用於輔助條件式生成。這些標記包含遊戲模式、難度、譜師 ID、年份及其他中繼資料。
訓練期間，這些標記沒有相應標籤，因此模型永遠不會輸出這些標記。
同時在訓練時，這些中繼資料標記有隨機機率會被「未知」標記取代，因此在推論時我們可以利用這些「未知」標記，減少必須提供給模型的中繼資料量。

### 無縫長序列生成

模型的上下文長度為 8.192 秒。顯然這不足以生成完整譜面，因此必須將歌曲切分為多個視窗，並分段生成譜面。
為確保生成的譜面在各視窗之間不會有明顯的縫隙，我們使用 90% 的重疊，並依序生成各視窗。
除第一個視窗外，每個生成視窗的解碼器都會預先填入前一視窗中最多 50% 的標記。
我們使用 logit 處理器來確保模型無法生成位於生成窗口前 50% 的時間標記。
此外，生成窗口的最後 40% 保留給下一個窗口。任何在該範圍內生成的時間標記都會被視為 EOS 標記。
這確保每個生成的標記都至少受到前 4 秒標記和後 3.3 秒音訊的條件影響，以便預測未來。

為了防止長時間生成過程中的偏移漂移，在訓練期間已隨機新增偏移至解碼器中的時間事件。
這迫使模型改以音訊中的起始點來修正時間錯誤，並能持續保持準確的偏移量。

### 使用擴散精緻座標

解碼器生成的位置座標會被量化到 32 像素的網格點，因此我們之後會利用擴散法去除雜訊以獲得最終座標。
為此，我們訓練了 [osu-diffusion](https://github.com/OliBomby/osu-diffusion) 的修改版本，專門用於噪音時間表的最後 10%，且接受 Mapperatorinator 用於條件生成的更進階的中繼資料標記。

由於 Mapperatorinator 模型會輸出滑條的 SV，所需的滑條長度不論控制點路徑形狀都已固定。
因此，我們會引導擴散過程生成符合所需滑條長度的座標。
我們透過在每一步擴散過程後依據所需長度和當前控制點路徑重新計算滑條終點位置來達成這一點。
這表示擴散過程無法直接控制滑條終點位置，但仍能藉由變更控制點路徑來影響終點位置。

### 後處理

Mapperatorinator 會執行一些額外的後處理，以提升生成譜面的品質：

- 使用擴散精緻位置座標。
- 使用模型生成的對齊因子將時間事件對齊到最近的節點。
- 對接近完美的重疊位置進行貼合。
- 將 mania 欄位事件轉換為 X 座標。
- 為太鼓滑棒生成滑條路徑。
- 修正滑條所需長度與控制點路徑長度間的大幅差異。

### 超級時間生成器

超級時間生成器是一種演算法，能透過對整首歌推論 20 次時間並取平均來提升生成時間的精度與準確度。
這對於 BPM 變化的歌曲或有 BPM 變換的歌曲特別有用。結果幾乎完美，只有少數段落需要手動調整。

## 訓練

以下說明將在您的本地機器建立訓練環境。

### 1. 複製儲存庫

```sh
git clone https://github.com/OliBomby/Mapperatorinator.git
cd Mapperatorinator
```

### 2. 建立資料集

使用 [Mapperator 主控台應用程式](https://github.com/mappingtools/Mapperator/blob/master/README.md#create-a-high-quality-dataset) 建立您自己的資料集。此應用程式需要一個 [osu! OAuth 客戶端權杖](https://osu.ppy.sh/home/account/edit) 來驗證 beatmap 並取得額外的中繼資料。請將資料集放在與 `Mapperatorinator` 目錄相鄰的 `datasets` 目錄中。

```sh
Mapperator.ConsoleApp.exe dataset2 -t "/Mapperatorinator/datasets/beatmap_descriptors.csv" -i "path/to/osz/files" -o "/datasets/cool_dataset"
```

### 3.（可選）設置 Weight & Biases 以進行日誌記錄
在 [Weight & Biases](https://wandb.ai/site) 上創建帳戶，並從帳戶設置中取得您的 API 金鑰。
然後設置 `WANDB_API_KEY` 環境變數，以便訓練過程知道要記錄到這個金鑰。

```sh
export WANDB_API_KEY=<your_api_key>
```

### 4. 建立 Docker 容器
你也可以在你的 venv 中進行訓練，但我們建議在 WSL 上使用 Docker 以獲得更佳效能。
```sh
docker compose up -d --force-recreate
docker attach mapperatorinator_space
cd Mapperatorinator
```

### 5. 配置參數並開始訓練

所有設定都位於 `./configs/train/default.yaml`。
請確保將 `train_dataset_path` 與 `test_dataset_path` 正確設定為您的資料集路徑，同時設定訓練/測試分割的起始與結束 mapset 索引。
該路徑是相對於 docker 容器的本地路徑，因此如果您將名為 `cool_dataset` 的資料集放在 `datasets` 目錄下，則路徑應為 `/workspace/datasets/cool_dataset`。

建議您建立自定義的設定檔來覆寫預設設定，這樣可以保留訓練設定以便重現。

```yaml
data:
  train_dataset_path: "/workspace/datasets/cool_dataset"
  test_dataset_path: "/workspace/datasets/cool_dataset"
  train_dataset_start: 0
  train_dataset_end: 90
  test_dataset_start: 90
  test_dataset_end: 100
```

Begin training by calling `python osuT5/train.py` or `torchrun --nproc_per_node=NUM_GPUS osuT5/train.py` for multi-GPU training.


```sh
python osuT5/train.py -cn train_v29 train_dataset_path="/workspace/datasets/cool_dataset" test_dataset_path="/workspace/datasets/cool_dataset" train_dataset_end=90 test_dataset_start=90 test_dataset_end=100
```

### 6. LoRA 微調

你也可以使用 [LoRA](https://arxiv.org/abs/2106.09685) 微調預訓練模型，以適應特定的風格或遊戲模式。
為此，請依照需求調整 `configs/train/lora.yaml`，然後執行 `lora` 訓練配置：

```sh
python osuT5/train.py -cn lora train_dataset_path="/workspace/datasets/cool_dataset" test_dataset_path="/workspace/datasets/cool_dataset" train_dataset_end=90 test_dataset_start=90 test_dataset_end=100
```
重要的 LoRA 參數需考慮：
- `pretrained_path`：要微調的基礎模型路徑或 Hugging Face 倉庫。
- `r`：LoRA 矩陣的秩。較高的值增加模型容量但同時增加內存用量。
- `lora_alpha`：LoRA 更新的縮放因子。
- `total_steps`：訓練步數總量。請根據資料集大小進行平衡。
- `enable_lora`：是否啟用 LoRA 或全模型微調。

在推論期間，你可以通過 `lora_path` 參數指定要使用的 LoRA 權重。
這可以是本地路徑或 Hugging Face 倉庫。

## 另見
- [Mapper 分類器](https://raw.githubusercontent.com/OliBomby/Mapperatorinator/main/./classifier/README.md)
- [RComplexion](https://raw.githubusercontent.com/OliBomby/Mapperatorinator/main/./rcomplexion/README.md)

## 鳴謝

特別感謝：
1. [osuT5](https://github.com/gyataro/osuT5) 作者提供訓練程式碼。
2. Hugging Face 團隊提供的[工具](https://huggingface.co/docs/transformers/index)。
3. [Jason Won](https://github.com/jaswon) 和 [Richard Nagyfi](https://github.com/sedthh) 交流想法。
4. [Marvin](https://github.com/minetoblend) 捐贈訓練點數。
5. osu! 社群提供 beatmap 資源。

## 相關作品

1. [osu! Beatmap Generator](https://github.com/Syps/osu_beatmap_generator) - Syps (Nick Sypteras) 製作
2. [osumapper](https://github.com/kotritrona/osumapper) - kotritrona, jyvden, Yoyolick (Ryan Zmuda) 製作
3. [osu-diffusion](https://github.com/OliBomby/osu-diffusion) - OliBomby (Olivier Schipper), NiceAesth (Andrei Baciu) 製作
4. [osuT5](https://github.com/gyataro/osuT5) - gyataro (Xiwen Teoh) 製作
5. [Beat Learning](https://github.com/sedthh/BeatLearning) - sedthh (Richard Nagyfi) 製作
6. [osu!dreamer](https://github.com/jaswon/osu-dreamer) - jaswon (Jason Won) 製作



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-24

---