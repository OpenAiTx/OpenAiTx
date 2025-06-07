<!-- markdownlint-disable first-line-h1 -->
<!-- markdownlint-disable html -->
<!-- markdownlint-disable no-duplicate-header -->

<div align="center">
  <img src="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/logo.svg?raw=true" width="60%" alt="DeepSeek-V3" />
</div>
<hr>
<div align="center" style="line-height: 1;">
  <a href="https://www.deepseek.com/"><img alt="Homepage"
    src="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/badge.svg?raw=true"/></a>
  <a href="https://chat.deepseek.com/"><img alt="Chat"
    src="https://img.shields.io/badge/🤖%20Chat-DeepSeek%20V3-536af5?color=536af5&logoColor=white"/></a>
  <a href="https://huggingface.co/deepseek-ai"><img alt="Hugging Face"
    src="https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-DeepSeek%20AI-ffc107?color=ffc107&logoColor=white"/></a>
  <br>
  <a href="https://discord.gg/Tc7c45Zzu5"><img alt="Discord"
    src="https://img.shields.io/badge/Discord-DeepSeek%20AI-7289da?logo=discord&logoColor=white&color=7289da"/></a>
  <a href="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/qr.jpeg?raw=true"><img alt="Wechat"
    src="https://img.shields.io/badge/WeChat-DeepSeek%20AI-brightgreen?logo=wechat&logoColor=white"/></a>
  <a href="https://twitter.com/deepseek_ai"><img alt="Twitter Follow"
    src="https://img.shields.io/badge/Twitter-deepseek_ai-white?logo=x&logoColor=white"/></a>
  <br>
  <a href="https://github.com/deepseek-ai/DeepSeek-V3/blob/main/LICENSE-CODE"><img alt="Code License"
    src="https://img.shields.io/badge/Code_License-MIT-f5de53?&color=f5de53"/></a>
  <a href="https://github.com/deepseek-ai/DeepSeek-V3/blob/main/LICENSE-MODEL"><img alt="Model License"
    src="https://img.shields.io/badge/Model_License-Model_Agreement-f5de53?&color=f5de53"/></a>
  <br>
  <a href="https://arxiv.org/pdf/2412.19437"><b>Paper Link</b>👁️</a>
</div>

## 目錄

1. [簡介](#1-簡介)
2. [模型摘要](#2-模型摘要)
3. [模型下載](#3-模型下載)
4. [評測結果](#4-評測結果)
5. [聊天網站與 API 平台](#5-聊天網站與-api-平台)
6. [本地部署指南](#6-本地部署指南)
7. [授權條款](#7-授權條款)
8. [引用](#8-引用)
9. [聯絡方式](#9-聯絡方式)


## 1. 簡介

我們推出 DeepSeek-V3，一款強大的 Mixture-of-Experts (MoE) 語言模型，總參數規模達 671B，每個 token 啟用 37B 參數。
為了實現高效推理與低成本訓練，DeepSeek-V3 採用了 Multi-head Latent Attention (MLA) 及 DeepSeekMoE 架構，並在 DeepSeek-V2 中得到了充分驗證。
此外，DeepSeek-V3 首創無輔助損失的負載均衡策略，並設置多 token 預測訓練目標以增強性能。
我們在 14.8 兆多元且高質量的 token 上對 DeepSeek-V3 進行預訓練，隨後通過監督式微調與強化學習階段充分發揮其能力。
全面評測顯示，DeepSeek-V3 超越其他開源模型，並達到領先閉源模型的表現。
儘管性能卓越，DeepSeek-V3 全部訓練僅需 2.788M H800 GPU 小時。
此外，其訓練過程極為穩定。
整個訓練過程中，未曾出現任何不可恢復的損失尖峰，亦未進行過回滾操作。
<p align="center">
  <img width="80%" src="figures/benchmark.png">
</p>

## 2. 模型摘要

---

**架構：創新負載均衡策略與訓練目標**

- 在 DeepSeek-V2 高效架構基礎上，我們首創無輔助損失的負載均衡策略，可最小化因鼓勵負載均衡導致的性能下降。
- 我們研究 Multi-Token Prediction (MTP) 目標，並證實其有助於模型性能提升，同時可用於推理加速中的 speculative decoding。

---

**預訓練：邁向極致訓練效率**

- 我們設計了 FP8 混合精度訓練框架，並首次在超大規模模型上驗證了 FP8 訓練的可行性與有效性。
- 通過演算法、框架與硬體協同設計，我們突破了跨節點 MoE 訓練的通訊瓶頸，幾乎實現了完全的計算-通訊重疊。
  這顯著提升了訓練效率並降低成本，使我們能在無額外開銷的情況下進一步擴展模型規模。
- 以僅 2.664M H800 GPU 小時的經濟成本，我們完成了 DeepSeek-V3 在 14.8T token 上的預訓練，產生目前最強的開源基座模型。預訓練後續階段僅需 0.1M GPU 小時。

---

**後訓練：來自 DeepSeek-R1 的知識蒸餾**

- 我們引入創新方法，將長 Chain-of-Thought (CoT) 模型（特別是 DeepSeek R1 系列之一）的推理能力蒸餾到標準 LLM，尤其是 DeepSeek-V3。此流程巧妙融合了 R1 的驗證與反思模式至 DeepSeek-V3，顯著提升其推理表現。同時，我們也有效控制 DeepSeek-V3 的輸出風格與長度。

---

## 3. 模型下載

<div align="center">

| **模型** | **總參數量** | **啟用參數量** | **上下文長度** | **下載** |
| :------------: | :------------: | :------------: | :------------: | :------------: |
| DeepSeek-V3-Base | 671B | 37B | 128K   | [🤗 Hugging Face](https://huggingface.co/deepseek-ai/DeepSeek-V3-Base)   |
| DeepSeek-V3   | 671B | 37B |  128K   | [🤗 Hugging Face](https://huggingface.co/deepseek-ai/DeepSeek-V3)   |

</div>

> [!NOTE]
> Hugging Face 上 DeepSeek-V3 模型總大小為 685B，其中主模型權重為 671B，多 token 預測（MTP）模組權重為 14B。

為確保最佳效能與彈性，我們與開源社群及硬體廠商合作，提供多種本地運行模型方式。詳細步驟請參閱第 6 節：[本地部署指南](#6-本地部署指南)。

開發者如需進一步了解，建議查閱 [README_WEIGHTS.md](./README_WEIGHTS.md)，其中包含主模型權重與多 token 預測（MTP）模組詳情。請注意，MTP 支援正由社群積極開發中，歡迎貢獻與反饋。

## 4. 評測結果
### 基座模型
#### 標準基準測試

<div align="center">


|  | 基準 (指標) | # Shots | DeepSeek-V2 | Qwen2.5 72B | LLaMA3.1 405B | DeepSeek-V3 |
|---|-------------------|----------|--------|-------------|---------------|---------|
| | 架構 | - | MoE | Dense | Dense | MoE |
| | 啟用參數量 | - | 21B | 72B | 405B | 37B |
| | 總參數量 | - | 236B | 72B | 405B | 671B |
| 英文 | Pile-test (BPB) | - | 0.606 | 0.638 | **0.542** | 0.548 |
| | BBH (EM) | 3-shot | 78.8 | 79.8 | 82.9 | **87.5** |
| | MMLU (Acc.) | 5-shot | 78.4 | 85.0 | 84.4 | **87.1** |
| | MMLU-Redux (Acc.) | 5-shot | 75.6 | 83.2 | 81.3 | **86.2** |
| | MMLU-Pro (Acc.) | 5-shot | 51.4 | 58.3 | 52.8 | **64.4** |
| | DROP (F1) | 3-shot | 80.4 | 80.6 | 86.0 | **89.0** |
| | ARC-Easy (Acc.) | 25-shot | 97.6 | 98.4 | 98.4 | **98.9** |
| | ARC-Challenge (Acc.) | 25-shot | 92.2 | 94.5 | **95.3** | **95.3** |
| | HellaSwag (Acc.) | 10-shot | 87.1 | 84.8 | **89.2** | 88.9 |
| | PIQA (Acc.) | 0-shot | 83.9 | 82.6 | **85.9** | 84.7 |
| | WinoGrande (Acc.) | 5-shot | **86.3** | 82.3 | 85.2 | 84.9 |
| | RACE-Middle (Acc.) | 5-shot | 73.1 | 68.1 | **74.2** | 67.1 |
| | RACE-High (Acc.) | 5-shot | 52.6 | 50.3 | **56.8** | 51.3 |
| | TriviaQA (EM) | 5-shot | 80.0 | 71.9 | 82.7 | **82.9** |
| | NaturalQuestions (EM) | 5-shot | 38.6 | 33.2 | **41.5** | 40.0 |
| | AGIEval (Acc.) | 0-shot | 57.5 | 75.8 | 60.6 | **79.6** |
| 程式 | HumanEval (Pass@1) | 0-shot | 43.3 | 53.0 | 54.9 | **65.2** |
| | MBPP (Pass@1) | 3-shot | 65.0 | 72.6 | 68.4 | **75.4** |
| | LiveCodeBench-Base (Pass@1) | 3-shot | 11.6 | 12.9 | 15.5 | **19.4** |
| | CRUXEval-I (Acc.) | 2-shot | 52.5 | 59.1 | 58.5 | **67.3** |
| | CRUXEval-O (Acc.) | 2-shot | 49.8 | 59.9 | 59.9 | **69.8** |
| 數學 | GSM8K (EM) | 8-shot | 81.6 | 88.3 | 83.5 | **89.3** |
| | MATH (EM) | 4-shot | 43.4 | 54.4 | 49.0 | **61.6** |
| | MGSM (EM) | 8-shot | 63.6 | 76.2 | 69.9 | **79.8** |
| | CMath (EM) | 3-shot | 78.7 | 84.5 | 77.3 | **90.7** |
| 中文 | CLUEWSC (EM) | 5-shot | 82.0 | 82.5 | **83.0** | 82.7 |
| | C-Eval (Acc.) | 5-shot | 81.4 | 89.2 | 72.5 | **90.1** |
| | CMMLU (Acc.) | 5-shot | 84.0 | **89.5** | 73.7 | 88.8 |
| | CMRC (EM) | 1-shot | **77.4** | 75.8 | 76.0 | 76.3 |
| | C3 (Acc.) | 0-shot | 77.4 | 76.7 | **79.7** | 78.6 |
| | CCPM (Acc.) | 0-shot | **93.0** | 88.5 | 78.6 | 92.0 |
| 多語言 | MMMLU-non-English (Acc.) | 5-shot | 64.0 | 74.8 | 73.8 | **79.4** |

</div>

> [!NOTE]
> 最佳結果以粗體顯示，差距不超過 0.3 的分數視為同級。DeepSeek-V3 在多數基準測試（特別是數學和程式任務）表現最佳。
> 更多詳細評測請參見論文。

#### 上下文視窗
<p align="center">
  <img width="80%" src="figures/niah.png">
</p>

於「Needle In A Haystack」（NIAH）測試中的評測結果。DeepSeek-V3 在所有上下文視窗長度（最高至 **128K**）下均表現優異。

### 聊天模型
#### 標準基準（模型規模大於 67B）
<div align="center">

| | **基準 (指標)** | **DeepSeek V2-0506** | **DeepSeek V2.5-0905** | **Qwen2.5 72B-Inst.** | **Llama3.1 405B-Inst.** | **Claude-3.5-Sonnet-1022** | **GPT-4o 0513** | **DeepSeek V3** |
|---|---------------------|---------------------|----------------------|---------------------|----------------------|---------------------------|----------------|----------------|
| | 架構 | MoE | MoE | Dense | Dense | - | - | MoE |
| | 啟用參數量 | 21B | 21B | 72B | 405B | - | - | 37B |
| | 總參數量 | 236B | 236B | 72B | 405B | - | - | 671B |
| 英文 | MMLU (EM) | 78.2 | 80.6 | 85.3 | **88.6** | **88.3** | 87.2 | **88.5** |
| | MMLU-Redux (EM) | 77.9 | 80.3 | 85.6 | 86.2 | **88.9** | 88.0 | **89.1** |
| | MMLU-Pro (EM) | 58.5 | 66.2 | 71.6 | 73.3 | **78.0** | 72.6 | 75.9 |
| | DROP (3-shot F1) | 83.0 | 87.8 | 76.7 | 88.7 | 88.3 | 83.7 | **91.6** |
| | IF-Eval (Prompt Strict) | 57.7 | 80.6 | 84.1 | 86.0 | **86.5** | 84.3 | 86.1 |
| | GPQA-Diamond (Pass@1) | 35.3 | 41.3 | 49.0 | 51.1 | **65.0** | 49.9 | 59.1 |
| | SimpleQA (Correct) | 9.0 | 10.2 | 9.1 | 17.1 | 28.4 | **38.2** | 24.9 |
| | FRAMES (Acc.) | 66.9 | 65.4 | 69.8 | 70.0 | 72.5 | **80.5** | 73.3 |
| | LongBench v2 (Acc.) | 31.6 | 35.4 | 39.4 | 36.1 | 41.0 | 48.1 | **48.7** |
| 程式 | HumanEval-Mul (Pass@1) | 69.3 | 77.4 | 77.3 | 77.2 | 81.7 | 80.5 | **82.6** |
| | LiveCodeBench (Pass@1-COT) | 18.8 | 29.2 | 31.1 | 28.4 | 36.3 | 33.4 | **40.5** |
| | LiveCodeBench (Pass@1) | 20.3 | 28.4 | 28.7 | 30.1 | 32.8 | 34.2 | **37.6** |
| | Codeforces (Percentile) | 17.5 | 35.6 | 24.8 | 25.3 | 20.3 | 23.6 | **51.6** |
| | SWE Verified (Resolved) | - | 22.6 | 23.8 | 24.5 | **50.8** | 38.8 | 42.0 |
| | Aider-Edit (Acc.) | 60.3 | 71.6 | 65.4 | 63.9 | **84.2** | 72.9 | 79.7 |
| | Aider-Polyglot (Acc.) | - | 18.2 | 7.6 | 5.8 | 45.3 | 16.0 | **49.6** |
| 數學 | AIME 2024 (Pass@1) | 4.6 | 16.7 | 23.3 | 23.3 | 16.0 | 9.3 | **39.2** |
| | MATH-500 (EM) | 56.3 | 74.7 | 80.0 | 73.8 | 78.3 | 74.6 | **90.2** |
| | CNMO 2024 (Pass@1) | 2.8 | 10.8 | 15.9 | 6.8 | 13.1 | 10.8 | **43.2** |
| 中文 | CLUEWSC (EM) | 89.9 | 90.4 | **91.4** | 84.7 | 85.4 | 87.9 | 90.9 |
| | C-Eval (EM) | 78.6 | 79.5 | 86.1 | 61.5 | 76.7 | 76.0 | **86.5** |
| | C-SimpleQA (Correct) | 48.5 | 54.1 | 48.4 | 50.4 | 51.3 | 59.3 | **64.8** |

</div>

> [!NOTE]
> 所有模型均在輸出長度限制為 8K 的配置下評測。樣本數少於 1000 的基準測試會多次調整溫度設置以獲得穩健結果。DeepSeek-V3 為最佳開源模型，且在與前沿閉源模型對比時亦表現競爭力。

####  開放式生成評測

<div align="center">



| 模型 | Arena-Hard | AlpacaEval 2.0 |
|-------|------------|----------------|
| DeepSeek-V2.5-0905 | 76.2 | 50.5 |
| Qwen2.5-72B-Instruct | 81.2 | 49.1 |
| LLaMA-3.1 405B | 69.3 | 40.5 |
| GPT-4o-0513 | 80.4 | 51.1 |
| Claude-Sonnet-3.5-1022 | 85.2 | 52.0 |
| DeepSeek-V3 | **85.5** | **70.0** |

</div>

> [!NOTE]
> 英文開放式對話評測。AlpacaEval 2.0 使用長度控制勝率作為評分指標。

## 5. 聊天網站與 API 平台
您可以在 DeepSeek 官方網站 [chat.deepseek.com](https://chat.deepseek.com/sign_in) 與 DeepSeek-V3 互動。

同時我們也在 DeepSeek 平台 [platform.deepseek.com](https://platform.deepseek.com/) 提供 OpenAI 相容 API。

## 6. 本地部署指南

DeepSeek-V3 可使用以下硬體與開源社群軟體於本地部署：

1. **DeepSeek-Infer Demo**：我們提供 FP8 與 BF16 推理的簡單輕量級示範程式。
2. **SGLang**：全面支援 DeepSeek-V3，支援 BF16 與 FP8 推理，多 token 預測 [即將推出](https://github.com/sgl-project/sglang/issues/2591)。
3. **LMDeploy**：本地及雲端部署均可高效支援 FP8、BF16 推理。
4. **TensorRT-LLM**：目前支援 BF16 推理與 INT4/8 量化，FP8 支援即將推出。
5. **vLLM**：支援 FP8、BF16 模式下的張量並行與管線並行。
6. **LightLLM**：單機或多機皆可高效部署 FP8 與 BF16。
7. **AMD GPU**：透過 SGLang 支援 AMD GPU 上的 DeepSeek-V3 推理（BF16/FP8）。
8. **華為昇騰 NPU**：支援在華為昇騰設備上運行 DeepSeek-V3。

由於我們框架原生採用 FP8 訓練，因此僅提供 FP8 權重。如需 BF16 權重實驗，可使用提供的轉換腳本完成格式轉換。

以下為 FP8 權重轉換為 BF16 的範例：

```shell
cd inference
python fp8_cast_bf16.py --input-fp8-hf-path /path/to/fp8_weights --output-bf16-hf-path /path/to/bf16_weights
```

> [!NOTE]
> Hugging Face 的 Transformers 目前尚未直接支援。

### 6.1 DeepSeek-Infer Demo 推理（僅供範例）

#### 系統需求

> [!NOTE] 
> 僅支援 Linux 與 Python 3.10。不支援 Mac 與 Windows。

依賴套件：
```pip-requirements
torch==2.4.1
triton==3.0.0
transformers==4.46.3
safetensors==0.4.5
```
#### 模型權重與示範程式準備

首先，複製 DeepSeek-V3 GitHub 儲存庫：

```shell
git clone https://github.com/deepseek-ai/DeepSeek-V3.git
```

進入 `inference` 資料夾並安裝 `requirements.txt` 內依賴。建議以 `conda` 或 `uv` 建立新虛擬環境並安裝依賴。

```shell
cd DeepSeek-V3/inference
pip install -r requirements.txt
```

從 Hugging Face 下載模型權重並放至 `/path/to/DeepSeek-V3` 資料夾。

#### 權重格式轉換

將 Hugging Face 權重轉換為指定格式：

```shell
python convert.py --hf-ckpt-path /path/to/DeepSeek-V3 --save-path /path/to/DeepSeek-V3-Demo --n-experts 256 --model-parallel 16
```

#### 執行

即可與 DeepSeek-V3 互動：

```shell
torchrun --nnodes 2 --nproc-per-node 8 --node-rank $RANK --master-addr $ADDR generate.py --ckpt-path /path/to/DeepSeek-V3-Demo --config configs/config_671B.json --interactive --temperature 0.7 --max-new-tokens 200
```

或於檔案上批次推理：

```shell
torchrun --nnodes 2 --nproc-per-node 8 --node-rank $RANK --master-addr $ADDR generate.py --ckpt-path /path/to/DeepSeek-V3-Demo --config configs/config_671B.json --input-file $FILE
```

### 6.2 SGLang 推理（推薦）

[SGLang](https://github.com/sgl-project/sglang) 目前支援 [MLA 最佳化](https://lmsys.org/blog/2024-09-04-sglang-v0-3/#deepseek-multi-head-latent-attention-mla-throughput-optimizations)、[DP Attention](https://lmsys.org/blog/2024-12-04-sglang-v0-4/#data-parallelism-attention-for-deepseek-models)、FP8 (W8A8)、FP8 KV Cache 及 Torch Compile，於開源框架中提供領先的延遲與吞吐表現。

特別是 [SGLang v0.4.1](https://github.com/sgl-project/sglang/releases/tag/v0.4.1) 完全支援於 **NVIDIA 與 AMD GPU** 上運行 DeepSeek-V3，具備極高彈性與穩定性。

SGLang 支援 [多機張量並行](https://github.com/sgl-project/sglang/tree/main/benchmark/deepseek_v3#example-serving-with-2-h208)，可於多台網路連接主機上部署模型。

Multi-Token Prediction (MTP) 正在開發中，進度可追蹤 [最佳化計畫](https://github.com/sgl-project/sglang/issues/2591)。

詳細啟動說明請參考 SGLang 團隊指引：https://github.com/sgl-project/sglang/tree/main/benchmark/deepseek_v3

### 6.3 LMDeploy 推理（推薦）
[LMDeploy](https://github.com/InternLM/lmdeploy) 是一個靈活高效的大語言模型推理與服務框架，現已支援 DeepSeek-V3。其同時提供離線管線與線上部署功能，並與 PyTorch 工作流無縫整合。

完整 LMDeploy 運行 DeepSeek-V3 的步驟，請參閱：https://github.com/InternLM/lmdeploy/issues/2960


### 6.4 TRT-LLM 推理（推薦）

[TensorRT-LLM](https://github.com/NVIDIA/TensorRT-LLM) 現已支援 DeepSeek-V3，提供如 BF16、INT4/INT8 等權重精度選擇，FP8 支援即將釋出。可通過以下連結取得專為 DeepSeek-V3 客製分支並直接體驗新功能：https://github.com/NVIDIA/TensorRT-LLM/tree/main/examples/deepseek_v3。 


### 6.5 vLLM 推理（推薦）

[vLLM](https://github.com/vllm-project/vllm) v0.6.6 支援於 NVIDIA 及 AMD GPU 上以 FP8、BF16 模式進行 DeepSeek-V3 推理。除標準技術外，vLLM 還提供 _管線並行_，可於多機網路部署。詳細說明請見 [vLLM 指南](https://docs.vllm.ai/en/latest/serving/distributed_serving.html)。亦可追蹤 [功能增強計畫](https://github.com/vllm-project/vllm/issues/11539)。

### 6.6 LightLLM 推理（推薦）

[LightLLM](https://github.com/ModelTC/lightllm/tree/main) v1.0.1 支援 DeepSeek-R1 (FP8/BF16) 的單機與多機張量並行部署，亦提供混合精度與持續增量整合更多量化模式。詳情請參閱 [LightLLM 指南](https://lightllm-en.readthedocs.io/en/latest/getting_started/quickstart.html)。LightLLM 支援 DeepSeek-V2 的 PD-disaggregation 部署，DeepSeek-V3 相關功能開發中。

### 6.7 AMD GPU 推理推薦

與 AMD 團隊合作，已實現 SGLang 對 AMD GPU 的 Day-One 支援，完整兼容 FP8 與 BF16 精度。詳細請參閱 [SGLang 指南](#63-inference-with-lmdeploy-recommended)。

### 6.8 華為昇騰 NPU 推理推薦
華為昇騰社群的 [MindIE](https://www.hiascend.com/en/software/mindie) 框架已成功適配 DeepSeek-V3 BF16 版本。詳細步驟請參見 [官方指引](https://modelers.cn/models/MindIE/deepseekv3)。

## 7. 授權條款
本代碼庫遵循 [MIT License](LICENSE-CODE) 授權。DeepSeek-V3 Base/Chat 模型之使用須遵守 [模型授權條款](LICENSE-MODEL)。DeepSeek-V3 系列（含 Base 與 Chat）均支持商業用途。

## 8. 引用
```
@misc{deepseekai2024deepseekv3technicalreport,
      title={DeepSeek-V3 Technical Report}, 
      author={DeepSeek-AI},
      year={2024},
      eprint={2412.19437},
      archivePrefix={arXiv},
      primaryClass={cs.CL},
      url={https://arxiv.org/abs/2412.19437}, 
}
```

## 9. 聯絡方式
如有任何疑問，請提交 issue 或聯絡 [service@deepseek.com](service@deepseek.com)。

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---