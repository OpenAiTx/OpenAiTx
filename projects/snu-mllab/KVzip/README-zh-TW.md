# KVzip：具有上下文重建的查詢無關 KV 快取壓縮

[[論文](https://arxiv.org/abs/2505.23416)] [[部落格](https://janghyun1230.github.io/kvzip/)] 

<img src="https://raw.githubusercontent.com/snu-mllab/KVzip/main/images/method.png" width="800">

## 新功能介紹？
- KVzip 壓縮 KV 快取以支援 **多樣化的未來查詢**。
- 【上下文相關】達成 **3–4 倍的 KV 快取大小縮減** 及 **2 倍的解碼延遲降低**，且性能衰減極小。
- 【上下文無關】強化 [DuoAttention](https://github.com/mit-han-lab/duo-attention) 風格的頭級 KV 壓縮，僅需 **數次前向傳播、一分鐘內完成** 頭級重要性分數優化（快 100 倍）。
- 執行 demo.py：
<img src="https://raw.githubusercontent.com/snu-mllab/KVzip/main/images/demo.png" width="800">


### 查詢無關設定的基準測試
- 任務：[SQuAD](https://huggingface.co/datasets/rajpurkar/squad)、[NIAH](https://github.com/gkamradt/LLMTest_NeedleInAHaystack)、[SCBench](https://github.com/microsoft/MInference/tree/main/scbench)、[GSM8K](https://huggingface.co/datasets/openai/gsm8k/viewer/main/train?row=7294)。
- 模型：[Qwen2.5-7B-Instruct-1M](https://huggingface.co/Qwen/Qwen2.5-7B-Instruct)

<img src="https://raw.githubusercontent.com/snu-mllab/KVzip/main/images/benchmark.png" width="800">


## 安裝
我們使用 CUDA 12.1 和 Python 3.10
```bash
cd KVzip
pip install -r requirements.txt
pip install flash-attn==2.7.4.post1 --no-build-isolation
make i
```
- 若要使用 [QServe](https://github.com/mit-han-lab/omniserve) 量化，請參考 [`./model/quant_model`](https://github.com/snu-mllab/KVzip/tree/main/model/quant_model)。
### 資料集
- 請從 [Google Drive](https://drive.google.com/file/d/1cqoR6pxxFcjFqvPZkuAmF-fBSAlAbjbN/view?usp=share_link) 下載預處理後的 SCBench 資料集。
- 若已下載並解壓縮，請將 scbench 資料夾移至指定位置。
```bash
mv scbench.zip kvzip/data/
cd kvzip/data
unzip scbench.zip  
```

## 快速開始
```python
from model import ModelKVzip

model = ModelKVzip("Qwen/Qwen2.5-7B-Instruct-1M")
context = "This is my basic profile. My name is Kim living in Seoul. My major is computer science."
queries = ["What is my name?", "Do I live in Seoul?"]

kv = model.prefill(context, load_score=False)  # 預填 KV 快取 + 重要性評分
kv.prune(ratio=0.3)  # 壓縮比例，淘汰 70% KV

for q in queries:
    query_ids = model.apply_template(q)
    output = model.generate(query_ids, kv=kv, update_cache=False)  # 高效推理
    print(q, output)
```
- 支援的模型列在 [`model/load.py`](https://github.com/snu-mllab/KVzip/blob/main/model/load.py)，包含 **LLaMA3、Qwen2.5/3、Gemma3**。
- 設定 `load_score=True` 可消除壓縮時的額外開銷，啟用上下文無關的 KV 淘汰，壓縮比例建議為 `ratio=0.6`。
- 生成完成後，會選擇性淘汰與查詢及生成標記相關的 KV 對以進行後續處理。設定 `update_cache=True` 可支援多輪推理，保留完整互動歷史。

## 記憶體與計算時間分析
### 上下文相關淘汰
```bash
python -B test.py -m [model_name] -d [data_name] --kv_type evict --ratio 0.3
```
- 此指令同時比較使用完整與剪裁後 KV 快取的輸出差異。
- 快速測試請使用 `-d squad`，長上下文測試請用 `-d scbench_kv`。
  - 可用資料名稱參見 [`data/load.py`](https://github.com/snu-mllab/KVzip/blob/main/data/load.py)。
  - 可用模型名稱參見 [`model/load.py`](https://github.com/snu-mllab/KVzip/blob/main/model/load.py)，例如 llama3.1-8b、qwen2.5-7b（或 Qwen/Qwen2.5-7B-Instruct-1M）。
- 我們改編了來自 [AdaKV](https://github.com/FFY0/AdaKV/tree/main) 的 CUDA 核心，支援非均勻的頭級資源分配。
  - 目前 Gemma3 採用靜態 KV 快取，尚無優化核心，故效能未必有顯著提升。但仍可透過 KV 子採樣 (`--kv_type retain`) 進行模型性能評估。


### 上下文無關淘汰（無運行時壓縮開銷）
- 使用 `--level head` 並搭配 `--ratio 0.6`（推薦）。
  - 此方法會移除特定頭的所有上下文 KV 對，但保留系統提示與查詢 KV 對。
  - LLaMA3.1-8B 與 Qwen2.5-7/14B 的預計算頭分數位於 `./utils/head_score`。
- 若要為其他模型計算頭分數：
  ```bash
  python -B test.py -m [model_name] -d scbench_qa_eng --save_head_score
  ```
  - 結果將儲存在 `./utils/head_score`。
  - 若目標為程式碼任務，建議同時執行 `-d scbench_repoqa`，以結合自然語言及程式碼語言的最大頭分數，有助提升性能。
- 這些分數可無縫整合至 [DuoAttention](https://github.com/mit-han-lab/duo-attention) 的優化推理引擎，只需替換其頭分數資料即可。


## 評估
- 生成不同 KV 壓縮比例（0.1 至 1.0）的模型回應：
    ```bash
    python -B eval.py -m [model_name] -d [data_name] --kv_type retain --num 100
    ``` 
  - 結果將保存在 `./results/[data_name]`。
  - 支援的資料集列表在 `data/load.py`。
- 從生成結果計算評估指標：
  ```bash
  python -B -m results.parse -m [model_name] -d [data_name]
  ```

## 應用至新模型
整合 KVzip 至新模型時，需更新以下檔案：
- `attention/attn.py`  
  視需求修改注意力前向傳播邏輯。部分情況下，亦需更新 kvcache.py 和 score.py。
- `model/monkeypatch.py`  
  實作模型專屬的猴子補丁以完成整合。
- `model/template.py`   
  定義模型的系統提示與對話格式範本。


## 引用
```bibtex
@article{kim2025kvzip,
        title={KVzip: Query-Agnostic KV Cache Compression with Context Reconstruction},
        author={Kim, Jang-Hyun and Kim, Jinuk and Kwon, Sangwoo and Lee, Jae W and Yun, Sangdoo and Song, Hyun Oh},
        journal={arXiv preprint arXiv:2505.23416},
        year={2025}
}
```

## 授權
MIT 授權

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---