![ChartGalaxy Logo](https://raw.githubusercontent.com/ChartGalaxy/ChartGalaxy/refs/heads/main/title.png)

## 資料集
> 📦 **[👉 前往 Hugging Face 取得完整 ChartGalaxy 資料集！👈](https://huggingface.co/datasets/ChartGalaxy/ChartGalaxy)**

由於儲存空間的限制，我們僅包含了一組具代表性的範例。  
本儲存庫包含論文 "ChartGalaxy: A Dataset for Infographic Chart Understanding and Generation" 的相關程式碼。

## 🔥 最新消息
**2025.5**： 🎉🎉 我們已釋出第一版資料集，涵蓋 1,151,087 個合成與 104,519 個真實資訊圖表，涵蓋 75 種圖表類型與 330 種變體。

-------------------

<img src="https://raw.githubusercontent.com/ChartGalaxy/ChartGalaxy/refs/heads/main/teaser.png" style="border:none;box-shadow:none;">

![Examples image](https://raw.githubusercontent.com/ChartGalaxy/ChartGalaxy/refs/heads/main/examples.png)

<!-- ## 🔔 News -->

## 介紹

### 關於

ChartGalaxy 是一個包含百萬規模合成與真實資訊圖表及其資料表的資料集，支援資訊圖表理解、程式碼生成與圖表生成等應用。該資料集解決了現有資料集大多僅限於平面圖表，無法涵蓋資訊圖表關鍵設計風格與版面多樣性的挑戰。

### 統計數據

- **規模**：1,255,606 個資訊圖表（1,151,087 合成 + 104,519 真實）
- **內容**：每個資訊圖表均配有產生該圖表所用的表格數據
- **圖表類型**：75 種圖表類型，330 種圖表變體
- **版型模板**：68 種版型模板

### 數據收集與製作

ChartGalaxy 的建構來源包括：

1. **真實資訊圖表收集**：從 19 個知名圖表豐富的網站收集圖表，如 Pinterest、Visual Capitalist、Statista、Information is Beautiful 等。

2. **合成資訊圖表製作**：依循歸納結構化流程：
   - 識別 75 種圖表類型（如長條圖）及 330 種反映不同視覺元素風格的圖表變體
   - 提取 68 種定義元素空間關係的版型模板
   - 依據這些模式程式化生成合成圖表

## 🎯 應用場景

ChartGalaxy 的應用價值透過三個代表性應用進行展示：

### 1. 🧠 資訊圖表理解

在 ChartGalaxy 上微調可提升基礎模型在資訊圖表理解任務上的表現。

### 2. 💻 資訊圖表程式碼生成

用於評估 LVLMs 在資訊圖表程式碼生成上的基準。該基準從兩個層級評估模型產生的 D3.js 程式碼所繪製圖表與真實圖表的相似度：高層級（整體視覺相似度）與低層級（細粒度 SVG 元素間的平均相似度）。

#### 概述

基準從兩個層級評估圖表程式碼生成：
- **低層級**：生成 SVG 與參考 SVG 的元素相似度
- **高層級**：整體視覺保真度與功能性評估

#### 安裝

```bash
git clone https://github.com/ChartGalaxy/ChartGalaxy.git
cd ChartGalaxy/code_generation_benchmark
```

#### 使用說明

1. 在 `code_generation_benchmark/configs/default_config.yaml` 配置設定：
   ```yaml
   prompts:
     high_level_eval_prompt_file: eval_high_level.txt
     chat_prompt_file: chat_direct_prompt.txt

   VLM:
     max_tokens: null
     thinking_budget: 1024
     temperature: 0.0
     top_p: 1.0

   models:
     # 取消註解你想評測的模型
     # - gpt-4o-2024-11-20
     # - claude-3-7-sonnet-20250219
     # - gemini-2.5-pro-preview-05-06
     # - Qwen/Qwen2.5-VL-72B-Instruct

   dirs:
     output_dir: ./output
     log_dir: ./logs
     data_root_dir: ./data
     clip_cache_dir: ./model-ckpts

   eval_model: gpt-4o-2024-11-20
   n_workers: 10
   ```

2. 執行基準測試：
   ```bash
   python main.py
   ```

#### 數據結構

`data_root_dir` 下每個圖表資料夾應包含：
- `chart.svg`：原始 SVG 格式圖表

系統將產生：
- `convert_chart.html`：參考圖表的 HTML 渲染
- `convert_chart.png`：參考圖表的 PNG 截圖
- `convert_chart.json`：參考圖表的元素結構
- 各模型輸出於對應子資料夾

#### 結果

結果將儲存於各模型專屬子資料夾，內容包括：
- 生成的 HTML/PNG 渲染
- JSON 格式的評分指標
- 詳細記錄於 `log_dir`


### 3. 🖼️ 基於範例的資訊圖表生成

一種基於範例的方法，將使用者提供的表格數據轉換為資訊圖表，並對齊範例圖表的版面及視覺風格。用戶研究顯示，該方法在保真度、美觀性及創造力上超越 GPT-Image-1。

## 聯絡方式
- chartgalaxy@163.com

## 論文連結

### 📌 主論文（本倉庫）

- **[ChartGalaxy: A Dataset for Infographic Chart Understanding and Generation](https://arxiv.org/abs/2505.18668)**  
  _Zhen Li, Duan Li, Yukai Guo, Xinyuan Guo, Bowen Li, Lanxi Xiao, Shenyu Qiao, Jiashu Chen, Zijian Wu, Hui Zhang, Xinhuan Shu, Shixia Liu_  

### 相關論文

- **[OrionBench: A Benchmark for Chart and Human-Recognizable Object Detection in Infographics](https://arxiv.org/abs/2505.17473)**  
  _Jiangning Zhu, Yuxing Zhou, Zheng Wang, Juntao Yao, Yima Gu, Yuhui Yuan, Shixia Liu_  

- **[InfoChartQA: A Benchmark for Multimodal Question Answering on Infographic Charts](https://arxiv.org/abs/2505.19028)**  
  _Minzhi Lin, Tianchi Xie, Mengchen Liu, Yilin Ye, Changjian Chen, Shixia Liu_  

## 📚 引用
若您在研究中使用了 ChartGalaxy，請引用：
```
@misc{li2025chartgalaxydatasetinfographicchart,
      title={ChartGalaxy: A Dataset for Infographic Chart Understanding and Generation}, 
      author={Zhen Li and Yukai Guo and Duan Li and Xinyuan Guo and Bowen Li and Lanxi Xiao and Shenyu Qiao and Jiashu Chen and Zijian Wu and Hui Zhang and Xinhuan Shu and Shixia Liu},
      year={2025},
      eprint={2505.18668},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2505.18668}, 
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---