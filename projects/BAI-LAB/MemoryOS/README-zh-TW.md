# MemoryOS
<div align="center">
  <img src="https://raw.githubusercontent.com/BAI-LAB/MemoryOS/main/logo_1.png" alt="logo" width="400"/>
</div>
<p align="center">
  <a href="https://arxiv.org/abs/2506.06326">
    <img src="https://img.shields.io/badge/Arxiv-paper-red" alt="Mem0 Discord">
  </a>
  <a href="https://github.com/user-attachments/assets/d195e740-1249-4eb1-962a-2c0d99a38c39">
    <img src="https://img.shields.io/badge/Wechat-群二维码-green" alt="Mem0 PyPI - Downloads">
  </a>
  <a href="https://youtu.be/y9Igs0FnX_M" target="blank">
    <img src="https://img.shields.io/badge/Demo-Video-red" alt="Npm package">
  </a>
    <a href="https://www.apache.org/licenses/LICENSE-2.0" target="_blank">
    <img src="https://img.shields.io/badge/License-Apache_2.0-blue" alt="License: Apache 2.0">
  </a>
</p>

<h5 align="center"> 🎉 如果你喜歡我們的專案，請在 GitHub 上給我們一顆星 ⭐ 以獲取最新更新。</h5>
**MemoryOS** 旨在為個性化 AI 代理提供一個記憶作業系統，使互動更具連貫性、個人化和情境感知。該系統借鑑了作業系統中的記憶體管理原理，採用分層儲存架構，包含四個核心模組：儲存、更新、檢索與生成，實現全面且高效的記憶體管理。在 LoCoMo 基準測試中，模型在 F1 和 BLEU-1 指標上分別取得了 **49.11%** 和 **46.18%** 的平均提升。







## 📣 最新消息
*   *<mark>[new]</mark>* 🔥  **[2025-06-15]**:🛠️ **MemoryOS-MCP** 開源釋出！現可在代理端客戶端進行配置，實現無縫整合與自定義。[👉 查看](#memoryos_mcp-getting-started)
*   **[2025-05-30]**: **MemoryOS** 首版正式上線！支持短期、中期及長期人格記憶，實現用戶檔案與知識的自動化更新。

## Demo
[![Watch the video](https://img.youtube.com/vi/y9Igs0FnX_M/maxresdefault.jpg)](https://youtu.be/y9Igs0FnX_M)

## 系統架構
![image](https://github.com/user-attachments/assets/09200494-03a9-4b7d-9ffa-ef646d9d51f0)

## 專案結構

```
memoryos/
├── __init__.py            # 初始化 MemoryOS 套件
├── __pycache__/           # Python 快取目錄（自動生成）
├── long_term.py           # 管理長期人格記憶（用戶檔案、知識）
├── memoryos.py            # MemoryOS 主類，協調所有元件
├── mid_term.py            # 管理中期記憶，整合短期互動內容
├── prompts.py             # 包含 LLM 互動用的提示詞（如摘要、分析等）
├── retriever.py           # 從所有記憶層檢索相關資訊
├── short_term.py          # 管理近期互動的短期記憶
├── updater.py             # 處理記憶更新，包括資訊在層級間的提升
└── utils.py               # 整個庫通用的工具函式
```

## 運作原理

1.  **初始化：** `Memoryos` 以用戶與助手 ID、API 金鑰、資料儲存路徑及多項容量/閾值設定進行初始化，並為每位用戶與助手建立專屬儲存空間。
2.  **新增記憶：** 用戶輸入與代理回應以 QA 配對形式新增，最初儲存在短期記憶中。
3.  **短期到中期處理：** 當短期記憶滿載時，`Updater` 模組會處理這些互動，將其整合為有意義的片段並存入中期記憶。
4.  **中期分析與 LPM 更新：** 中期記憶片段根據訪問頻率、互動長度等因子累積「熱度」。當片段熱度超過閾值，將對內容進行分析：
    *   萃取用戶檔案洞見，並更新至長期用戶檔案。
    *   特定用戶事實加入用戶長期知識。
    *   助手相關資訊則加入助手的長期知識庫。
5.  **回應生成：** 當收到用戶查詢時：
    *   `Retriever` 模組會從短期歷史、中期記憶片段、用戶檔案與知識，以及助手知識庫中檢索相關上下文。
    *   這些完整的上下文會與用戶查詢一同提供給 LLM，生成連貫且知情的回應。

## MemoryOS_PYPI 快速上手

### 先決條件

*   Python >= 3.10
*   pip install -i https://pypi.org/simple/ MemoryOS-BaiJia

### 安裝

```bash
conda create -n MemoryOS python=3.10
conda activate MemoryOS
pip install -i https://pypi.org/simple/ MemoryOS-BaiJia
```

### 基本用法

```python

import os
from memoryos import Memoryos

# --- 基本配置 ---
USER_ID = "demo_user"
ASSISTANT_ID = "demo_assistant"
API_KEY = "YOUR_OPENAI_API_KEY"  # 請替換為你的金鑰
BASE_URL = ""  # 可選：如使用自訂 OpenAI 端點
DATA_STORAGE_PATH = "./simple_demo_data"
LLM_MODEL = "gpt-4o-mini"

def simple_demo():
    print("MemoryOS 簡易演示")
    
    # 1. 初始化 MemoryOS
    print("正在初始化 MemoryOS...")
    try:
        memo = Memoryos(
            user_id=USER_ID,
            openai_api_key=API_KEY,
            openai_base_url=BASE_URL,
            data_storage_path=DATA_STORAGE_PATH,
            llm_model=LLM_MODEL,
            assistant_id=ASSISTANT_ID,
            short_term_capacity=7,  
            mid_term_heat_threshold=5,  
            retrieval_queue_capacity=7,
            long_term_knowledge_capacity=100
        )
        print("MemoryOS 初始化成功！\n")
    except Exception as e:
        print(f"錯誤：{e}")
        return

    # 2. 新增一些基本記憶
    print("新增一些記憶...")
    
    memo.add_memory(
        user_input="Hi! I'm Tom, I work as a data scientist in San Francisco.",
        agent_response="Hello Tom! Nice to meet you. Data science is such an exciting field. What kind of data do you work with?"
    )
     
    test_query = "What do you remember about my job?"
    print(f"用戶: {test_query}")
    
    response = memo.get_response(
        query=test_query,
    )
    
    print(f"助手: {response}")

if __name__ == "__main__":
    simple_demo()
```
## MemoryOS-MCP 快速上手
### 🔧 核心工具

#### 1. `add_memory`
將用戶與 AI 助手對話內容保存進記憶系統，建立持久化對話歷史與上下文記錄。

#### 2. `retrieve_memory`
根據查詢，從記憶系統中檢索相關歷史對話、用戶偏好及知識資訊，協助 AI 助手理解用戶需求與背景。

#### 3. `get_user_profile`
獲取根據歷史對話分析生成的用戶檔案，包括用戶個性特徵、興趣偏好及相關知識背景。


### 1. 安裝依賴
```bash
cd memoryos-mcp
pip install -r requirements.txt
```
### 2. 配置

編輯 `config.json`：
```json
{
  "user_id": "你的用戶ID",
  "openai_api_key": "你的OpenAI API密鑰",
  "openai_base_url": "https://api.openai.com/v1",
  "data_storage_path": "./memoryos_data",
  "assistant_id": "assistant_id",
  "llm_model": "gpt-4o-mini"
}
```
### 3. 啟動伺服器
```bash
python server_new.py --config config.json
```
### 4. 測試
```bash
python test_comprehensive.py
```
### 5. 在 Cline 及其他客戶端配置
複製 mcp.json 文件，並確認檔案路徑正確。
```bash
command": "/root/miniconda3/envs/memos/bin/python"
#此處應更改為你虛擬環境的 Python 解譯器
```
## 貢獻指南

歡迎貢獻！請隨時提交 issue 或 pull request。

## 引用
如需詳細閱讀，請點擊此處：[閱讀完整論文](https://arxiv.org/abs/2506.06326)

如果您認為本專案對您有幫助，請考慮引用我們的論文：

```bibtex
@misc{kang2025memoryosaiagent,
      title={Memory OS of AI Agent}, 
      author={Jiazheng Kang and Mingming Ji and Zhe Zhao and Ting Bai},
      year={2025},
      eprint={2506.06326},
```
## 聯絡我們
百家AI是北京郵電大學白婷副教授指導的研究小組，致力於為矽基人類打造情感飽滿、記憶超凡的大腦。<br>
合作與建議：baiting@bupt.edu.cn<br>
歡迎關注百家Agent公眾號和微信群，共同交流！
<div style="display: flex; justify-content: center; gap: 20px;">
  <img src="https://github.com/user-attachments/assets/42651f49-f1f7-444d-9455-718e13ed75e9" alt="百家Agent公眾號" width="250"/>
  <img src="https://github.com/user-attachments/assets/6b15a873-9e9a-44ee-b0b3-64f488fbd5d8" alt="微信群二維碼" width="300"/>
</div>
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-15

---