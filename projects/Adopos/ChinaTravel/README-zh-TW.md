<center>
  <h1>ChinaTravel：中文旅遊規劃語言代理之真實世界基準資料集
</h1>
</center>

本文為論文 "ChinaTravel: A Real-World Benchmark for Language Agents in Chinese Travel Planning" 的官方代碼庫。

<!-- | [網頁](https://www.lamda.nju.edu.cn/shaojj/chinatravel/) | [論文](https://arxiv.org/abs/2412.13682) | [資料集(Huggingface)](https://huggingface.co/datasets/LAMDA-NeSy/ChinaTravel)| -->

[![網頁](https://img.shields.io/badge/Webpage-Visit-blue)](https://www.lamda.nju.edu.cn/shaojj/chinatravel/)
[![論文](https://img.shields.io/badge/Paper-View-red)](https://arxiv.org/abs/2412.13682)
[![資料集(Huggingface)](https://img.shields.io/badge/Dataset-Huggingface-yellow)](https://huggingface.co/datasets/LAMDA-NeSy/ChinaTravel)
[![競賽(TPC@IJCAI2025)](https://img.shields.io/badge/IJCAI%20Competition-TPC@IJCAI2025-green)](https://chinatravel-competition.github.io/IJCAI2025/)
[![競賽(TPC@AIC2025)](https://img.shields.io/badge/AIC%20Competition-TPC@AIC2025-green)](TPC@AIC2025/readme.md)


<!-- 
![總覽](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/images/overview.png) -->

## 🏆 IJCAI 2025 旅遊規劃挑戰賽 (TPC@IJCAI)

我們很榮幸宣佈 ChinaTravel 被選為 **IJCAI 2025 旅遊規劃挑戰賽 (TPC) 官方基準資料集**！

**官方競賽網站**：
[https://chinatravel-competition.github.io/IJCAI2025/](https://chinatravel-competition.github.io/IJCAI2025/)

歡迎參賽者開發能在複雜約束下處理真實世界旅遊規劃情境的新型代理。此次競賽將展現語言代理領域的最新研究成果。

## 📝 更新日誌

### 2025.09
1. 上傳 TPC@IJCAI2025 DSL 賽道冠軍方案，感謝 [@evergreenee](https://github.com/evergreenee) 的貢獻。  


### 2025.06

1. 修正常識評估代碼中的錯誤收集。
2. 修正純神經代理的流程。
3. 修正從 huggingface 加載資料集。
4. 更新語法驗證中的異常處理。


### 2025.05

1. 最新版本的更新日誌。
2. 提供 TPC 的評估程式碼。

### 2025.04

1. 新增本地資料載入器。使用者現在可在本地載入自訂查詢。當在 "run_exp.py" 指定非預設 splits_name 值（如 "abc"）時，系統會自動從 evaluation/default_splits/abc.txt 載入對應檔案，其中 TXT 檔包含目標查詢檔名。
2. 詳細約束分類。請參閱 [Evaluation README](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/chinatravel/symbol_verification/readme.md) 的詳細文件。
3. 引入 LLM-modulo 基線
   以真實符號驗證器實現 LLM-modulo 流程。
   方法參考：
   論文：Robust Planning with Compound LLM Architectures: An LLM-Modulo Approach
   原始碼： https://github.com/Atharva-Gundawar/LLM-Modulo-prompts
4. 支援 Qwen3-8B/4B 本地 LLM 推論。

## 🚀 快速開始

### ⚙️ 環境設置

1. 建立 conda 環境並安裝依賴：

```bash
conda create -n chinatravel python=3.9  
conda activate chinatravel  
pip install -r requirements.txt  
```

2. 下載資料庫並將其解壓縮到 "chinatravel/environment/" 目錄

下載連結：[Google 雲端硬碟](https://drive.google.com/drive/folders/1bJ7jA5cfExO_NKxKfi9qgcxEbkYeSdAU), [南京大學雲盤](https://box.nju.edu.cn/d/dd83e5a4a9e242ed8eb4/)

3. 下載開源大型語言模型（可選）。

```bash
bash download_llm.sh
```

4. 下載分詞器。

```bash
wget https://cdn.deepseek.com/api-docs/deepseek_v3_tokenizer.zip -P chinatravel/local_llm/
unzip chinatravel/local_llm/deepseek_v3_tokenizer.zip -d chinatravel/local_llm/
```

### ▶️ 執行

我們支援 deepseek（來自 deepseek 的官方 API）、gpt-4o（chatgpt-4o-latest）、glm4-plus，以及本地推論，包括 Qwen（Qwen3-8B）、llama、mistral（Mistral-7B-Instruct-v0.3）等。

```bash
export OPENAI_API_KEY=""

python run_exp.py --splits easy --agent LLMNeSy --llm deepseek --oracle_translation
python run_exp.py --splits medium --agent LLMNeSy --llm deepseek --oracle_translation
python run_exp.py --splits human --agent LLMNeSy --llm deepseek --oracle_translation

python run_exp.py --splits human --agent LLMNeSy --llm Qwen3-8B --oracle_translation


python run_exp.py --splits human --agent LLMNeSy --llm deepseek 
python run_exp.py --splits human --agent LLMNeSy --llm Qwen3-8B 


python run_exp.py --splits human --agent LLM-modulo --llm deepseek --refine_steps 10 --oracle_translation
python run_exp.py --splits human --agent LLM-modulo --llm Qwen3-8B --refine_steps 10 --oracle_translation
```

**注意**：

- `--oracle_translation` 標誌啟用對註釋過的真實資料的訪問，包括：

  - `hard_logic_py`: 可執行的驗證 DSL 程式碼
  - `hard_logic_nl`: 相應的約束描述
  - 範例註釋結構：

  ```python
  {
    "hard_logic_py": [
      "
      total_cost=0 
      for activity in allactivities(plan):
          total_cost+=activity_cost(activity)
              total_cost += innercity_transport_cost(activity_transports(activity))
      result=(total_cost<=1000)
      ", 
      "
      innercity_transport_set=set()
      for activity in allactivities(plan):
          if activity_transports(activity)!=[]:              
              innercity_transport_set.add(innercity_transport_type(activity_transports(activity)))
      result=(innercity_transport_set<={'taxi'})
      "
    ], 
    "hard_logic_nl": ["总预算为1800元", "市内交通选择taxi"], 
  }
  ```
- LLM-modulo 方法在其符號精煉過程中**需要** oracle_translation 模式

### 📊 評估

```bash
python eval_exp.py --splits human --method LLMNeSy_deepseek_oracletranslation
python eval_exp.py --splits human --method LLMNeSy_deepseek
python eval_exp.py --splits human --method LLM-modulo_deepseek_10steps_oracletranslation
python eval_exp.py --splits human --method LLM-modulo_Qwen3-8B_10steps_oracletranslation

```
在 TPC@IJCAI2025 中，評估程式碼包含於 `eval_tpc.py` 檔案。您可以按照以下方式執行評估程式碼：


```bash
python eval_tpc.py --splits tpc_phase1 --method YOUR_METHOD_NAME
```

## 📚 文件

[環境](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/chinatravel/environment/readme.md)
[約束條件](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/chinatravel/symbol_verification/readme.md)

## 🛠️ 進階開發

### 1. 開發您自己的代理演算法

要開發您自己的代理演算法，您需要繼承 `chinatravel/agent/base.py` 中的 `BaseAgent` 類，並將您的演算法邏輯加入到 `chinatravel/agent/load_model.py` 中的 `init_agent` 函式。我們提供了一個名為 `TPCAgent` 的空代理範例。

步驟：

- **繼承 `BaseAgent` 類**：在 `chinatravel/agent` 目錄下建立新的 Python 檔案，並定義您自己的代理類別，繼承自 `BaseAgent`。

```python:chinatravel/agent/your_agent.py
from .base import BaseAgent

class YourAgent(BaseAgent):
    def __init__(self, **kwargs):
        super().__init__(**kwargs)
        # Initialization logic

    def act(self, observation):
        # Implement the decision - making logic of the agent
        pass
```

- **在 init_agent 函數中新增程式碼**：打開 chinatravel/agent/load_model.py 檔案，並在 init_agent 函數中新增對您新代理的支援。

```python:
def init_agent(kwargs):
    # ... existing code ...
    elif kwargs["method"] == "YourMethodName":
        agent = YourAgent(
            **kwargs
        )
    # ... existing code ...
    return agent
```

### 2. 開發您自己的本地大型語言模型（LLM）

要開發您自己的本地大型語言模型（LLM），您需要從 chinatravel/agent/llms.py 繼承 AbstractLLM 類，並在 llms.py 中添加相應的本地 LLM 推理程式碼。我們提供了一個名為 TPCLLM 的空白 LLM 範例。
步驟：

- **繼承 AbstractLLM 類別**：在 chinatravel/agent/llms.py 檔案中定義您自己的 LLM 類別，並從 AbstractLLM 繼承。

```python
class YourLLM(AbstractLLM):
    def __init__(self):
        super().__init__()
        # Initialization logic
        self.name = "YourLLMName"

    def _get_response(self, messages, one_line, json_mode):
        # Implement the response logic of the LLM
        response = "Your LLM response"
        if json_mode:
            # Handle JSON mode
            pass
        elif one_line:
            # Handle one - line mode
            response = response.split("\n")[0]
        return response
```

- **在 init_agent 函數中新增程式碼**：打開 chinatravel/agent/load_model.py 檔案，並在 init_llm 函數中新增對您的新 llm 的支援。

```python:
def init_llm(kwargs):
    # ... existing code ...
    elif llm_name == "glm4-plus":
        llm = YourLLM()
    # ... existing code ...
    return llm
```

### 3. 使用實驗腳本運行您的程式碼

完成上述開發後，您可以使用實驗腳本來運行您的程式碼。

運行範例：

```bash
python run_tpc.py --splits easy --agent TPCAgent --llm TPCLLM
python run_exp.py --splits easy --agent YourMethodName --llm YourLLMName
```

結果將會被儲存在 `results/YourMethodName_YourLLMName_xxx` 目錄中，例如：`results/TPCAgent_TPCLLM`。

## ✉️ 聯絡方式

如有任何問題，請聯絡 [邵捷靖](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/shaojj@lamda.nju.edu.cn)、[張博文](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/221900200@smail.nju.edu.cn)、[楊曉雯](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/yangxw@lamda.nju.edu.cn)。

## 📌 引用

若本論文或相關資源對您的研究有所幫助，敬請引用。

```
@misc{shao2024chinatravelrealworldbenchmarklanguage,
      title={ChinaTravel: A Real-World Benchmark for Language Agents in Chinese Travel Planning}, 
      author={Jie-Jing Shao and Xiao-Wen Yang and Bo-Wen Zhang and Baizhi Chen and Wen-Da Wei and Guohao Cai and Zhenhua Dong and Lan-Zhe Guo and Yu-feng Li},
      year={2024},
      eprint={2412.13682},
      archivePrefix={arXiv},
      primaryClass={cs.AI},
      url={https://arxiv.org/abs/2412.13682}, 
}
```
[English](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=en) | [简体中文](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=zh-CN) | [繁體中文](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=zh-TW) | [日本語](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=ja) | [한국어](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=ko) | [हिन्दी](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=hi) | [ไทย](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=th) | [Français](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=fr) | [Deutsch](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=de) | [Español](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=es) | [Italiano](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=it) | [Русский](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=ru) | [Português](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=pt) | [Nederlands](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=nl) | [Polski](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=pl) | [العربية](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=ar) | [فارسی](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=fa) | [Türkçe](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=tr) | [Tiếng Việt](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=vi) | [Bahasa Indonesia](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=id) | [অসমীয়া](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=as)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-12

---