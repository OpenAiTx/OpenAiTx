[![License](https://img.shields.io/badge/License-Apache_2.0-blue.svg)](LICENSE) [![Coverage](https://github.com/NVIDIA/KAI-Scheduler/raw/coverage-badge/badges/coverage.svg)](https://github.com/NVIDIA/KAI-Scheduler/blob/main/.github/workflows/update-coverage-badge.yaml)
# KAI Scheduler
KAI Scheduler 是一個強大、高效且可擴展的 [Kubernetes 排程器](https://kubernetes.io/zh/docs/concepts/scheduling-eviction/kube-scheduler/)，專為優化 AI 及機器學習工作負載的 GPU 資源分配而設計。

KAI Scheduler 專為管理大規模 GPU 叢集（包含數千個節點）與高吞吐量工作負載而設計，非常適合龐大且高需求的環境。
KAI Scheduler 允許 Kubernetes 叢集管理員動態分配 GPU 資源給各種工作負載。

KAI Scheduler 支援完整的 AI 生命週期，從需要最小資源的小型互動式作業，到大型訓練與推論工作，都可在同一叢集內運行。
它確保最佳資源分配，同時維持不同消費者之間的資源公平性。
可與叢集上安裝的其他排程器並行運行。

## 主要功能
* [批次排程](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/batch/README.md)：確保同一群組內所有 pod 要麼同時排程，要麼全部不排程。
* 資源裝箱與分散排程：通過最小化碎片化（裝箱）或增加彈性與負載平衡（分散排程）來優化節點使用率。
* [工作負載優先順序](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/priority/README.md)：在佇列中有效地設定工作負載優先順序。
* [階層式佇列](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/queues/README.md)：利用二層佇列階層管理工作負載，提供彈性的組織控管。
* [資源分配](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/fairness/README.md#resource-division-algorithm)：可自訂每個佇列的配額、超額配額權重、限制與優先順序。
* [公平性策略](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/fairness/README.md#reclaim-strategies)：利用主導資源公平性（DRF）及資源回收機制，確保跨佇列的資源公平分配。
* 工作負載整併：智慧地重新分配運行中的工作負載，以減少碎片並提高叢集使用率。
* [彈性工作負載](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/elastic/README.md)：可在定義的最小與最大 pod 數量範圍內動態調整工作負載規模。
* 動態資源分配（DRA）：通過 Kubernetes ResourceClaims 支援廠商專屬硬體資源（如 NVIDIA 或 AMD 的 GPU）。
* [GPU 共用](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/gpu-sharing/README.md)：允許多個工作負載高效共用單顆或多顆 GPU，最大化資源利用率。
* 雲端與地端支援：完全相容於動態雲端基礎設施（包含如 Karpenter 的自動擴縮器）及靜態地端部署。

## 先決條件
安裝 KAI Scheduler 前，請確保您已經具備：

- 正在運行的 Kubernetes 叢集
- 已安裝 [Helm](https://helm.sh/docs/intro/install) CLI
- 已安裝 [NVIDIA GPU-Operator](https://github.com/NVIDIA/gpu-operator)，以便排程要求 GPU 資源的工作負載

## 安裝方式
KAI Scheduler 將安裝於 `kai-scheduler` 命名空間。提交工作負載時請務必使用專屬命名空間。

### 安裝方法
KAI Scheduler 可以透過以下方式安裝：

- **從正式版本安裝（建議）**
- **從原始碼建構（自行編譯）**

#### 從正式版本安裝
請至 [releases](https://github.com/NVIDIA/KAI-Scheduler/releases) 頁面找到最新發行版本。
將 `<VERSION>` 替換為所需的發行版本後，執行下列指令：
```sh
helm upgrade -i kai-scheduler oci://ghcr.io/nvidia/kai-scheduler/kai-scheduler -n kai-scheduler --create-namespace --version <VERSION>
```
#### 從原始碼建構
請依照[這裡](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/developer/building-from-source.md)的說明進行

## 快速開始
若要開始使用 KAI Scheduler 排程工作負載，請參考[快速開始範例](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/quickstart/README.md)

## 發展藍圖

### 2025 年主要優先事項概覽
* 重構程式碼基礎以提升廠商中立性
* 支援 Scheduling Gates https://github.com/NVIDIA/KAI-Scheduler/issues/63
* 研究與 Kueue 的可能整合 https://github.com/NVIDIA/KAI-Scheduler/issues/68
* 新增 pod-group 的拓撲感知排程支援 https://github.com/NVIDIA/KAI-Scheduler/issues/66
* 支援每個工作負載的最小運行時間
* 支援每個工作負載的最大運行時間（含延遲重排隊機制）
* 預設 KAI 安裝新增更多 PriorityClasses
* 支援 JobSet
* 支援 LWS (LeaderWorkerSet)
* 新增 pod 與 pod-group 搶占相關度量指標
* 解耦優先順序與搶占機制

### 長期目標
* 支援每個佇列的時間衰減
* 超大規模擴展改進
* 支援推論型工作負載的整併，以促進叢集碎片化修復
* 支援 n 層階層佇列
* 優雅地推出推論型工作負載（新修訂版可臨時超額配額）

## 社群、討論與支援

我們很樂意聽取您的意見！以下是與我們聯繫的最佳方式：

### Slack
請先加入 [CNCF Slack](https://communityinviter.com/apps/cloud-native/cncf)，再進入 [#kai-scheduler](https://cloud-native.slack.com/archives/kai-scheduler) 頻道。

### 雙週社群通話  
**時間：** 每隔一週的星期一 17:00 CEST  
[轉換為您所在時區](https://dateful.com/time-zone-converter?t=17&tz2=Germany) | [加入您的行事曆](https://calendar.google.com/calendar/event?action=TEMPLATE&tmeid=N2Q2bjhoNXAzMGc0cWpnZTQ4OGtpdXFhanFfMjAyNTA2MDlUMTUwMDAwWiAxZjQ2OTZiOWVlM2JiMWE1ZWIzMTAwODBkNDZiZmMwMDZjNTUxYWFiZmU1YTM3ZGM2YTc0NTFhYmNhMmE1ODk0QGc&tmsrc=1f4696b9ee3bb1a5eb310080d46bfc006c551aabfe5a37dc6a7451abca2a5894%40group.calendar.google.com&scp=ALL)  | [會議記錄與議程](https://docs.google.com/document/d/13K7NGdPebOstlrsif1YLjGz1x-aJafMXeIgqbO7WghI/edit?usp=sharing)

### 郵件列表  
加入 [kai-scheduler 郵件列表](https://groups.google.com/g/kai-scheduler)，以獲取雙週會議的最新資訊。

### 技術問題與功能請求  
請透過 [GitHub issue](https://github.com/NVIDIA/KAI-Scheduler/issues/new/choose) 回報錯誤、功能建議或技術協助。這有助於我們追蹤需求並有效回應。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---