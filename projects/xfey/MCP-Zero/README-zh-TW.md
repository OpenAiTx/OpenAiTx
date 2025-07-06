## MCP-Zero：自主 LLM 智能體的主動工具發現

<div style="display: flex; align-items: center; gap: 10px; margin-bottom: 10px;">
  <!-- <img src="https://raw.githubusercontent.com/xfey/MCP-Zero/master/assets/robot.png" alt="MCP-Zero Robot" width="24" height="24"> -->
  <a href="https://arxiv.org/abs/2506.01056">
    <img src="https://img.shields.io/badge/Paper-arXiv-red">
  </a>
  <a href="https://arxiv.org/abs/2506.01056">
    https://arxiv.org/abs/2506.01056
  </a>
</div>


感謝您對 MCP-Zero 的關注！🤗

我們現已開源論文中涉及的代碼。我們將持續更新我們的工作，探索其在產業中的應用，並繼續擴展這個專案。


<div align="center">
  <img src="https://raw.githubusercontent.com/xfey/MCP-Zero/master/assets/fig1.png" alt="MCP-Zero workflow">
  <p> 使用 MCP-Zero 主動構建「做一頓美味大餐」的工具鏈</p>
</div>


### 方法：MCP-Zero

```
MCP-zero/
├── experiment_apibank.py       # 實驗：APIBank
├── experiment_mcptools.py      # 實驗：mcp_tools（needle test）
├── matcher.py                  # 相似度匹配程式碼
├── prompt_guide/               # 本方法所用提示詞
├── reformatter.py              # 工具描述的 json 格式化器
├── sampler.py                  # 用於選擇目標工具的採樣器
├── test_cases.jsonl            # 匹配器的測試用例
├── test_matcher.py             # 匹配器的單元測試
└── utils.py                    # 工具集：grid_search
```

我們現已釋出論文中的代碼。論文中的代碼實現了檢索能力，並在實驗中取得了具體成果。

在我們未來的工作中，我們致力於將 MCP-zero 應用於產業，因此還需要涉及其他模組，比如 MCP 伺服器的動態部署、GAIA 測試的環境部署等。我們會持續完善我們的工作，感謝大家對本項目的關注。給我點個 star🌟 讓我知道你有在追蹤 :D



### 數據集：MCP-tools

- **Google Drive**: [下載連結](https://drive.google.com/file/d/1RjBGU-AGdHdhUABoeYSztbfQlD0hjUBn/view?usp=sharing)
- **Huggingface 連結**：即將上線
- **請將檔案放在**：`./MCP-tools/mcp_tools_with_embedding.json`


**簡介**：一個包含 MCP 官方倉庫所有已篩選工具（共 308 個伺服器和 2,797 個工具）的數據集。

**數據結構**：
```
{
  "server_name": string, // MCP 伺服器名稱，從 README 擷取或推斷
  "server_summary": string, // 伺服器用途與能力摘要，依據 README 相關部分
  "server_description": string, // 來自 metadata 的描述
  "description_embedding": float[3072], // 伺服器描述的 text-embedding-3-large 向量
  "summary_embedding": float[3072], // 伺服器摘要的 text-embedding-3-large 向量
  "tools": [
    {
      "name": string, // 函數/工具名稱
      "description": string, // 工具功能簡述
      "description_embedding": float[3072], // 工具描述的 text-embedding-3-large 向量
      "parameter": { // 輸入參數字典，僅當有明確定義時包含
        "param1": "(type) description1",
        "param2": "(Optional, type) description2"
      }
    }
  ]
}
```

**自行構建數據集**：如果你希望為 MCP 伺服器構建自定義數據集，可以參考 `MCP-tools/build_data` 資料夾下的程式碼。

```
MCP-tools/
├── build_data
│   ├── get_server_summary.py       # 擷取 MCP 伺服器 ReadMe 結構化資料的程式碼
│   ├── run_vllm.sh                 # 使用 VLLM 部署 Qwen2.5-72B-Instruct 模型
│   └── server_summary.prompt       # 用於提取數據集的提示詞
└── download_data.md
```


### 引用

> Citation makes me happy.
> 
>   --Shakespeare
>   ~~（純屬娛樂 :D）~~

```bibtex
@article{fei2025mcp,
  title={MCP-Zero: Active Tool Discovery for Autonomous LLM Agents},
  author={Fei, Xiang and Zheng, Xiawu and Feng, Hao},
  journal={arXiv preprint arXiv:2506.01056},
``` 
  year={2025}
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-06

---