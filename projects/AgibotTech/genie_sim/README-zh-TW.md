![image.png](https://raw.githubusercontent.com/AgibotTech/genie_sim/main/./docs/image.jpg)
<div align="center">
  <a href="https://github.com/AgibotTech/genie_sim">
    <img src="https://img.shields.io/badge/GitHub-grey?logo=GitHub" alt="GitHub">
  </a>
  <a href="https://huggingface.co/datasets/agibot-world/GenieSimAssets">
    <img src="https://img.shields.io/badge/HuggingFace-yellow?logo=HuggingFace" alt="HuggingFace">
  </a>
  <a href="https://agibot-world.com/sim-evaluation">
    <img src="https://img.shields.io/badge/Genie%20Sim%20Benchmark-blue?style=plastic" alt="Genie Sim Benchmark">
  </a>
  <a href="https://genie.agibot.com/en/geniestudio">
    <img src="https://img.shields.io/badge/Genie_Studio-green?style=flat" alt="Genie Studio">
  </a>
</div>

# 1. Genie Sim 基準測試
Genie Sim 是 AgiBot 推出的模擬框架，為開發者提供高效的資料生成能力和評估基準，加速具身智能的發展。Genie Sim 已建立起一套完善的閉環流程，涵蓋軌跡生成、模型訓練、基準測試以及部署驗證。使用者可通過這一高效的模擬工具鏈，快速驗證演算法效能並優化模型。無論是簡單的抓取任務還是複雜的長距離操作，Genie Sim 都能提供高度擬真的模擬環境與精確的評估指標，賦能開發者高效完成機器人技術的開發與迭代。

作為 Genie Sim 的開源評估版本，Genie Sim Benchmark 致力於為具身 AI 模型提供精確的效能測試與優化支持。

# 2. 特色
- 靈活且易於使用的模擬配置與介面
- 用於 10+ 操控任務的模擬基準與評估任務
- 支援基於 VR 及鍵盤的遠端操控
- 全關節與末端執行器姿態的紀錄與重播
- 550+ 高擬真、物理精確的 3D 模擬環境與資產
- 標準化評估指標以量化具身 AI 模型性能
- 評估結果在 GO-1 模型下，模擬到實體誤差小於 5%
- 支援 UniVLA 基線模型於模擬評估中運行

# 3. 更新
- [2025/6/25] v2.1
  - 為 Agibot World Challenge 2025 新增 10 個操控任務及全部模擬資產
  - 在 Huggingface 上開源 10 個操控任務的合成資料集
  https://huggingface.co/datasets/agibot-world/AgiBotWorldChallenge-2025/tree/main/Manipulation-SimData
  - 整合 UniVLA 策略並支援模型推理模擬評估
  - 更新 IK 解算器 SDK，支援多機器人跨結構體 IK 求解
  - 優化通訊框架，模擬運行速度提升 2 倍
  - 更新自動評估框架，支援更複雜的長距離任務

# 4. 內容

## 4.1 簡介
Genie Sim 中的具身智能模擬基準，旨在評估並推動具身 AI 模型的發展。這些基準提供真實的環境、多樣化的任務及標準化指標，用以衡量機器人 AI 系統的效能，從而減少對昂貴實體硬體和現實測試的需求，避免高風險場景，加速 AI 智能體的訓練與評估流程。

## 4.2 快速開始
請參考[此頁](https://agibot-world.com/sim-evaluation/docs/#/v2)以獲取安裝、使用指南與 API 參考

## 4.3 支援
<img src="https://raw.githubusercontent.com/AgibotTech/genie_sim/main/./docs/wechat.JPEG" width="30%"/>

## 4.4 待辦清單
- [x] 釋出更多長時序基準操控任務
- [x] 為每個基準任務增加更多場景與資產
- [x] 支援 Agibot World Challenge 基線模型
- [ ] 場景佈局與操控軌跡泛化工具包

## 4.5 常見問題
- 當發生錯誤導致 isaac sim 伺服器無法響應時，如何關閉？
  請在終端執行 `pkill -9 -f raise_standalone_sim` 關閉進程
- 如何選擇不同的渲染模式？
  預設渲染模式為 `RaytracedLighting(RealTime)`。若任務包含透明物體，請選擇 `RealTimePathTracing(RealTime-2.0)`，以更佳展現物體間的透視關係

## 4.6 授權與引用
本倉庫內所有資料與程式碼皆採用 Mozilla Public License 2.0 授權
若本項目對您的研究有幫助，請考慮以下任一方式引用我們的工作。
```
@misc{2025geniesim,
  title={GenieSim},
  author={GenieSim Team},
  year={2025},
  url={https://github.com/AgibotTech/genie_sim}
}
```

## 4.7 參考文獻
1. PDDL Parser (2020). Version 1.1. [原始碼]. https://github.com/pucrs-automated-planning/pddl-parser.
2. BDDL. Version 1.x.x [原始碼]. https://github.com/StanfordVL/bddl
3. CUROBO [原始碼]. https://github.com/NVlabs/curobo
4. Isaac Lab [原始碼]. https://github.com/isaac-sim/IsaacLab
5. Omni Gibson [原始碼]. https://github.com/StanfordVL/OmniGibson

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---