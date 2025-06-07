<!---
Copyright 2020 The HuggingFace Team. All rights reserved.

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
-->

<p align="center">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://huggingface.co/datasets/huggingface/documentation-images/raw/main/transformers-logo-dark.svg">
    <source media="(prefers-color-scheme: light)" srcset="https://huggingface.co/datasets/huggingface/documentation-images/raw/main/transformers-logo-light.svg">
    <img alt="Hugging Face Transformers Library" src="https://huggingface.co/datasets/huggingface/documentation-images/raw/main/transformers-logo-light.svg" width="352" height="59" style="max-width: 100%;">
  </picture>
  <br/>
  <br/>
</p>

<p align="center">
    <a href="https://huggingface.com/models"><img alt="Checkpoints on Hub" src="https://img.shields.io/endpoint?url=https://huggingface.co/api/shields/models&color=brightgreen"></a>
    <a href="https://circleci.com/gh/huggingface/transformers"><img alt="Build" src="https://img.shields.io/circleci/build/github/huggingface/transformers/main"></a>
    <a href="https://github.com/huggingface/transformers/blob/main/LICENSE"><img alt="GitHub" src="https://img.shields.io/github/license/huggingface/transformers.svg?color=blue"></a>
    <a href="https://huggingface.co/docs/transformers/index"><img alt="Documentation" src="https://img.shields.io/website/http/huggingface.co/docs/transformers/index.svg?down_color=red&down_message=offline&up_message=online"></a>
    <a href="https://github.com/huggingface/transformers/releases"><img alt="GitHub release" src="https://img.shields.io/github/release/huggingface/transformers.svg"></a>
    <a href="https://github.com/huggingface/transformers/blob/main/CODE_OF_CONDUCT.md"><img alt="Contributor Covenant" src="https://img.shields.io/badge/Contributor%20Covenant-v2.0%20adopted-ff69b4.svg"></a>
    <a href="https://zenodo.org/badge/latestdoi/155220641"><img src="https://zenodo.org/badge/155220641.svg" alt="DOI"></a>
</p>

<h4 align="center">
    <p>
        <b>English</b> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_zh-hans.md">简体中文</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_zh-hant.md">繁體中文</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_ko.md">한국어</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_es.md">Español</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_ja.md">日本語</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_hd.md">हिन्दी</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_ru.md">Русский</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_pt-br.md">Рortuguês</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_te.md">తెలుగు</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_fr.md">Français</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_de.md">Deutsch</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_vi.md">Tiếng Việt</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_ar.md">العربية</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_ur.md">اردو</a> |
    </p>
</h4>

<h3 align="center">
    <p>最先進的預訓練模型，支援推論與訓練</p>
</h3>

<h3 align="center">
    <a href="https://hf.co/course"><img src="https://huggingface.co/datasets/huggingface/documentation-images/resolve/main/course_banner.png"></a>
</h3>

Transformers 是一個包含預訓練文本、電腦視覺、音訊、影像及多模態模型的函式庫，可用於推論與訓練。使用 Transformers 可針對您的資料微調模型、建構推論應用程式，並支援各種多模態生成式 AI 應用。

在 [Hugging Face Hub](https://huggingface.com/models) 上有超過 50 萬個 Transformers [模型檢查點](https://huggingface.co/models?library=transformers&sort=trending) 可供使用。

立即探索 [Hub](https://huggingface.com/)，尋找合適模型並透過 Transformers 快速啟動您的專案。

## 安裝方式

Transformers 支援 Python 3.9+、[PyTorch](https://pytorch.org/get-started/locally/) 2.1+、[TensorFlow](https://www.tensorflow.org/install/pip) 2.6+ 及 [Flax](https://flax.readthedocs.io/en/latest/) 0.4.1+。

請使用 [venv](https://docs.python.org/3/library/venv.html) 或 [uv](https://docs.astral.sh/uv/)，建立與啟用虛擬環境。uv 是基於 Rust 的快速 Python 套件與專案管理工具。

```py
# venv
python -m venv .my-env
source .my-env/bin/activate
# uv
uv venv .my-env
source .my-env/bin/activate
```

於您的虛擬環境中安裝 Transformers。

```py
# pip
pip install "transformers[torch]"

# uv
uv pip install "transformers[torch]"
```

若您需要最新的函式庫變更或有貢獻需求，可從原始碼安裝 Transformers。但*最新*版本可能不穩定。若遇到錯誤請隨時提交 [issue](https://github.com/huggingface/transformers/issues)。

```shell
git clone https://github.com/huggingface/transformers.git
cd transformers

# pip
pip install .[torch]

# uv
uv pip install .[torch]
```

## 快速入門

使用 [Pipeline](https://huggingface.co/docs/transformers/pipeline_tutorial) API 立即開始使用 Transformers。`Pipeline` 是一個高階推論類別，支援文本、音訊、視覺與多模態任務。它會自動預處理輸入並回傳對應的結果。

初始化一個 pipeline，並指定用於文本生成的模型。模型會自動下載並快取，之後可重複使用。最後，輸入提示文本給模型。

```py
from transformers import pipeline

pipeline = pipeline(task="text-generation", model="Qwen/Qwen2.5-1.5B")
pipeline("the secret to baking a really good cake is ")
[{'generated_text': 'the secret to baking a really good cake is 1) to use the right ingredients and 2) to follow the recipe exactly. the recipe for the cake is as follows: 1 cup of sugar, 1 cup of flour, 1 cup of milk, 1 cup of butter, 1 cup of eggs, 1 cup of chocolate chips. if you want to make 2 cakes, how much sugar do you need? To make 2 cakes, you will need 2 cups of sugar.'}]
```

要與模型進行對話時，使用方式相同。唯一的不同是，您需建立一個聊天歷史（`Pipeline` 的輸入）給模型。

> [!TIP]
> 您也可以直接從命令列與模型互動。
> ```shell
> transformers chat Qwen/Qwen2.5-0.5B-Instruct
> ```

```py
import torch
from transformers import pipeline

chat = [
    {"role": "system", "content": "你是一個1986年好萊塢電影中想像的機智幽默機器人。"},
    {"role": "user", "content": "嗨，你可以告訴我在紐約有什麼有趣的活動嗎？"}
]

pipeline = pipeline(task="text-generation", model="meta-llama/Meta-Llama-3-8B-Instruct", torch_dtype=torch.bfloat16, device_map="auto")
response = pipeline(chat, max_new_tokens=512)
print(response[0]["generated_text"][-1]["content"])
```

展開下方範例，瞭解 `Pipeline` 如何應用於不同模態與任務。

<details>
<summary>自動語音辨識</summary>

```py
from transformers import pipeline

pipeline = pipeline(task="automatic-speech-recognition", model="openai/whisper-large-v3")
pipeline("https://huggingface.co/datasets/Narsil/asr_dummy/resolve/main/mlk.flac")
{'text': ' I have a dream that one day this nation will rise up and live out the true meaning of its creed.'}
```

</details>

<details>
<summary>影像分類</summary>

<h3 align="center">
    <a><img src="https://huggingface.co/datasets/Narsil/image_dummy/raw/main/parrots.png"></a>
</h3>

```py
from transformers import pipeline

pipeline = pipeline(task="image-classification", model="facebook/dinov2-small-imagenet1k-1-layer")
pipeline("https://huggingface.co/datasets/Narsil/image_dummy/raw/main/parrots.png")
[{'label': 'macaw', 'score': 0.997848391532898},
 {'label': 'sulphur-crested cockatoo, Kakatoe galerita, Cacatua galerita',
  'score': 0.0016551691805943847},
 {'label': 'lorikeet', 'score': 0.00018523589824326336},
 {'label': 'African grey, African gray, Psittacus erithacus',
  'score': 7.85409429227002e-05},
 {'label': 'quail', 'score': 5.502637941390276e-05}]
```

</details>

<details>
<summary>視覺問答</summary>


<h3 align="center">
    <a><img src="https://huggingface.co/datasets/huggingface/documentation-images/resolve/main/transformers/tasks/idefics-few-shot.jpg"></a>
</h3>

```py
from transformers import pipeline

pipeline = pipeline(task="visual-question-answering", model="Salesforce/blip-vqa-base")
pipeline(
    image="https://huggingface.co/datasets/huggingface/documentation-images/resolve/main/transformers/tasks/idefics-few-shot.jpg",
    question="What is in the image?",
)
[{'answer': 'statue of liberty'}]
```

</details>

## 為什麼要使用 Transformers？

1. 易於使用的最先進模型：
    - 在自然語言理解與生成、電腦視覺、音訊、影像與多模態任務上表現優異。
    - 研究人員、工程師與開發者皆可輕鬆上手。
    - 僅需學習三個主要類別，抽象簡單。
    - 統一的 API，支援所有預訓練模型。

1. 降低運算成本，減少碳足跡：
    - 共享訓練好的模型，無需每次從頭訓練。
    - 減少運算時間與生產成本。
    - 涵蓋所有模態，超過百萬預訓練檢查點與多種模型架構。

1. 依照模型生命週期選擇合適框架：
    - 僅需三行程式碼即可訓練最先進模型。
    - 單一模型可隨時於 PyTorch/JAX/TF2.0 間轉換。
    - 針對訓練、評估與生產挑選最適合的框架。

1. 輕鬆自訂模型或範例以符合需求：
    - 提供各架構範例，可重現原始論文結果。
    - 模型內部盡量一致地對外開放。
    - 模型檔案可獨立於函式庫使用，方便快速實驗。

<a target="_blank" href="https://huggingface.co/enterprise">
    <img alt="Hugging Face Enterprise Hub" src="https://github.com/user-attachments/assets/247fb16d-d251-4583-96c4-d3d76dda4925">
</a><br>

## 什麼情況下不建議使用 Transformers？

- 本函式庫不是神經網路組件的模組化工具箱。模型檔案中的程式碼並未特意做額外抽象，讓研究人員可直接針對每個模型快速迭代，而無需深入額外的抽象層或檔案。
- 訓練 API 已針對 Transformers 提供的 PyTorch 模型最佳化。若需一般機器學習訓練流程，請考慮使用其他函式庫，如 [Accelerate](https://huggingface.co/docs/accelerate)。
- [範例腳本]((https://github.com/huggingface/transformers/tree/main/examples)) 僅供*範例*。不一定可直接應用於您的特定場景，您需依需求調整程式碼。

## 100 個使用 Transformers 的專案

Transformers 不僅僅是一個預訓練模型工具包，更是圍繞 Hugging Face Hub 所建立的開發者社群。我們希望 Transformers 能協助開發者、研究人員、學生、教授、工程師或任何人實現他們的理想專案。

為慶祝 Transformers 突破 10 萬星標，我們特別推出 [awesome-transformers](./awesome-transformers.md) 頁面，收錄 100 個令人驚豔的 Transformers 專案。

如果您擁有或使用值得被納入的專案，歡迎提交 PR 加入名單！

## 範例模型

您可以直接在 [Hub 模型頁面](https://huggingface.co/models) 測試我們大多數模型。

展開下方各模態，可查看不同應用場景的模型範例。

<details>
<summary>音訊</summary>

- 使用 [Whisper](https://huggingface.co/openai/whisper-large-v3-turbo) 進行音訊分類
- 使用 [Moonshine](https://huggingface.co/UsefulSensors/moonshine) 進行自動語音辨識
- 使用 [Wav2Vec2](https://huggingface.co/superb/wav2vec2-base-superb-ks) 進行關鍵字偵測
- 使用 [Moshi](https://huggingface.co/kyutai/moshiko-pytorch-bf16) 進行語音轉語音生成
- 使用 [MusicGen](https://huggingface.co/facebook/musicgen-large) 進行文字轉音訊
- 使用 [Bark](https://huggingface.co/suno/bark) 進行文字轉語音

</details>

<details>
<summary>電腦視覺</summary>

- 使用 [SAM](https://huggingface.co/facebook/sam-vit-base) 進行自動遮罩生成
- 使用 [DepthPro](https://huggingface.co/apple/DepthPro-hf) 進行深度估測
- 使用 [DINO v2](https://huggingface.co/facebook/dinov2-base) 進行影像分類
- 使用 [SuperGlue](https://huggingface.co/magic-leap-community/superglue_outdoor) 進行關鍵點偵測
- 使用 [SuperGlue](https://huggingface.co/magic-leap-community/superglue) 進行關鍵點匹配
- 使用 [RT-DETRv2](https://huggingface.co/PekingU/rtdetr_v2_r50vd) 進行物件偵測
- 使用 [VitPose](https://huggingface.co/usyd-community/vitpose-base-simple) 進行姿態估測
- 使用 [OneFormer](https://huggingface.co/shi-labs/oneformer_ade20k_swin_large) 進行通用分割
- 使用 [VideoMAE](https://huggingface.co/MCG-NJU/videomae-large) 進行影片分類

</details>

<details>
<summary>多模態</summary>

- 使用 [Qwen2-Audio](https://huggingface.co/Qwen/Qwen2-Audio-7B) 進行音訊或文字轉文字
- 使用 [LayoutLMv3](https://huggingface.co/microsoft/layoutlmv3-base) 進行文件問答
- 使用 [Qwen-VL](https://huggingface.co/Qwen/Qwen2.5-VL-3B-Instruct) 進行影像或文字轉文字
- 使用 [BLIP-2](https://huggingface.co/Salesforce/blip2-opt-2.7b) 進行影像描述生成
- 使用 [GOT-OCR2](https://huggingface.co/stepfun-ai/GOT-OCR-2.0-hf) 進行 OCR 文件理解
- 使用 [TAPAS](https://huggingface.co/google/tapas-base) 進行表格問答
- 使用 [Emu3](https://huggingface.co/BAAI/Emu3-Gen) 實現統一多模態理解與生成
- 使用 [Llava-OneVision](https://huggingface.co/llava-hf/llava-onevision-qwen2-0.5b-ov-hf) 進行視覺轉文字
- 使用 [Llava](https://huggingface.co/llava-hf/llava-1.5-7b-hf) 進行視覺問答
- 使用 [Kosmos-2](https://huggingface.co/microsoft/kosmos-2-patch14-224) 進行視覺指稱表達分割

</details>

<details>
<summary>NLP</summary>

- 使用 [ModernBERT](https://huggingface.co/answerdotai/ModernBERT-base) 進行遮罩詞補全
- 使用 [Gemma](https://huggingface.co/google/gemma-2-2b) 進行命名實體辨識
- 使用 [Mixtral](https://huggingface.co/mistralai/Mixtral-8x7B-v0.1) 進行問答
- 使用 [BART](https://huggingface.co/facebook/bart-large-cnn) 進行摘要生成
- 使用 [T5](https://huggingface.co/google-t5/t5-base) 進行翻譯
- 使用 [Llama](https://huggingface.co/meta-llama/Llama-3.2-1B) 進行文本生成
- 使用 [Qwen](https://huggingface.co/Qwen/Qwen2.5-0.5B) 進行文本分類

</details>

## 參考文獻

我們已發表一篇有關 🤗 Transformers 函式庫的 [論文](https://www.aclweb.org/anthology/2020.emnlp-demos.6/)，歡迎引用：

```bibtex
@inproceedings{wolf-etal-2020-transformers,
    title = "Transformers: State-of-the-Art Natural Language Processing",
    author = "Thomas Wolf and Lysandre Debut and Victor Sanh and Julien Chaumond and Clement Delangue and Anthony Moi and Pierric Cistac and Tim Rault and Rémi Louf and Morgan Funtowicz and Joe Davison and Sam Shleifer and Patrick von Platen and Clara Ma and Yacine Jernite and Julien Plu and Canwen Xu and Teven Le Scao and Sylvain Gugger and Mariama Drame and Quentin Lhoest and Alexander M. Rush",
    booktitle = "Proceedings of the 2020 Conference on Empirical Methods in Natural Language Processing: System Demonstrations",
    month = oct,
    year = "2020",
    address = "Online",
    publisher = "Association for Computational Linguistics",
    url = "https://www.aclweb.org/anthology/2020.emnlp-demos.6",
    pages = "38--45"
}
```

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---