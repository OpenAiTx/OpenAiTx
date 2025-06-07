# OCI AI Blueprints

**使用 OCI AI Blueprints 平台部署、擴展及監控 AI 工作負載，將您的 GPU 上線時間從數週縮短至數分鐘。**

OCI AI Blueprints 是一套精簡化、無需程式碼的解決方案，可用於在 Kubernetes Engine (OKE) 上部署及管理生成式 AI 工作負載。它提供專業推薦的硬體建議、預先封裝的軟體堆疊，以及開箱即用的可觀測性工具，協助您快速高效地啟動 AI 應用，無需面對基礎架構選擇、軟體相容性及 MLOps 最佳實踐的複雜問題。

[![安裝 OCI AI Blueprints](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/refs/heads/main/docs/images/install.svg)](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/GETTING_STARTED_README.md)

## 目錄

**快速開始**

- [安裝 AI Blueprints](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/GETTING_STARTED_README.md)
- [存取 AI Blueprints 入口網站與 API](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/usage_guide.md)

**關於 OCI AI Blueprints**

- [什麼是 OCI AI Blueprints？](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/about.md)
- [為什麼要使用 OCI AI Blueprints？](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/about.md)
- [功能特色](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/about.md)
- [Blueprints 清單](#blueprints)
- [常見問題](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/about.md)
- [支援與聯絡方式](https://github.com/oracle-quickstart/oci-ai-blueprints/blob/vkammari/doc_improvements/docs/about/README.md#frequently-asked-questions-faq)

**API 參考**

- [API 參考文件](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/api_documentation.md)

**其他資源**

- [發佈自訂 Blueprints](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/custom_blueprints)
- [安裝更新](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/installing_new_updates.md)
- [IAM 原則](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/iam_policies.md)
- [儲存庫內容](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/about.md)
- [已知問題](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/known_issues.md)

## 快速開始

請點擊下方按鈕安裝 OCI AI Blueprints：

[![安裝 OCI AI Blueprints](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/refs/heads/main/docs/images/install.svg)](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/GETTING_STARTED_README.md)

## Blueprints

Blueprints 不僅僅是基本的 Terraform 範本。每個 Blueprint：

- 提供經過驗證的硬體建議（例如最佳化的機型、CPU/GPU 配置），
- 包含根據不同生成式 AI 使用案例所定制的端到端應用堆疊，以及
- 內建監控、日誌記錄與自動擴展功能，開箱即用。

當您將 OCI AI Blueprints 安裝到您的租戶 OKE 叢集後，可以部署以下預建 Blueprint：

| Blueprint                                                                                                           | 說明                                                                                                                                         |
| -------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------- |
| [**LLM 與 VLM 推論（vLLM）**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/llm_inference_with_vllm/README.md) | 使用 NVIDIA GPU 機型及 vLLM 推論引擎，搭配自動擴展，部署 Llama 2/3/3.1 7B/8B 模型。                                                            |
| [**微調效能基準測試**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/lora-benchmarking)                    | 在 A100 上運行 MLCommons 量化 Llama-2 70B LoRA 微調以進行效能基準測試。                                                                       |
| [**LoRA 微調**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/lora-fine-tuning)                           | 針對自訂或 HuggingFace 模型進行 LoRA 微調，支援任意資料集，包含彈性的超參數調整。                                                              |
| [**健康檢查**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/gpu-health-check)                             | 全面評估 GPU 效能，確保在啟動任何密集運算工作負載前的最佳硬體狀態。                                                                           |
| [**CPU 推論**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/cpu-inference)                               | 利用 Ollama 測試基於 CPU 的推論，支援如 Mistral、Gemma 等模型。                                                                               |
| [**多節點 RDMA 與 vLLM 推論**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/multi-node-inference/)       | 使用 H100 節點、vLLM 及 LeaderWorkerSet，透過 RDMA 跨多節點部署 Llama-405B 級別 LLM。                                                        |
| [**vLLM 自動擴展推論**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/auto_scaling/)                      | 使用 KEDA 服務 LLM，根據推論延遲等應用指標自動擴展至多 GPU 與多節點。                                                                        |
| [**MIG 多實例 GPU LLM 推論**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/mig_multi_instance_gpu/)      | 利用 Nvidia 多實例 GPU，僅用部分 GPU 部署 LLM，並透過 vLLM 服務推論。                                                                         |
| [**作業排隊**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/teams)                                      | 支援作業排隊，並強制資源配額及團隊間公平分配。                                                                                                |

## 支援與聯絡方式

如有任何問題、疑慮或回饋，請聯絡 [vishnu.kammari@oracle.com](mailto:vishnu.kammari@oracle.com) 或 [grant.neuman@oracle.com](mailto:grant.neuman@oracle.com)。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---