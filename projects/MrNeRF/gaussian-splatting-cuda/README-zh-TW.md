# 3D 高斯點雲實時輻射場渲染 - C++ 與 CUDA 實作

[![Discord](https://img.shields.io/badge/Discord-Join%20Us-7289DA?logo=discord&logoColor=white)](https://discord.gg/TbxJST2BbC)  
[![Website](https://img.shields.io/badge/Website-mrnerf.com-blue)](https://mrnerf.com)  
[![Papers](https://img.shields.io/badge/Papers-Awesome%203DGS-orange)](https://mrnerf.github.io/awesome-3D-gaussian-splatting/)

高效能的 C++ 與 CUDA 3D 高斯點雲實作，基於 [gsplat](https://github.com/nerfstudio-project/gsplat) 光柵化後端。

## 新聞
- **[2025-06-10]**：修正部分問題，我們正逐步縮小與 gsplat 指標的差距，但仍有小幅不匹配。
- **[2025-06-04]**：新增 MCMC 策略與 `--max-cap` 指令行選項，用於控制最大高斯點數。
- **[2025-06-03]**：切換至 Gsplat 後端並更新授權。
- **[2024-05-27]**：升級至 LibTorch 2.7.0，提升相容性與效能。已解決優化器狀態管理的破壞性變更。
- **[2024-05-26]**：目前本倉庫的目標為採用寬鬆授權，已大幅替換光柵化器為 gsplat 實作。

## 指標
目前實作尚未達到 gsplat-mcmc 的等效結果，但持續開發中。  
修正錯誤只是時間問題，歡迎協助 :) MCMC 策略的指標如下：

| 場景     | 迭代次數 | PSNR         | SSIM        | LPIPS       | 每張圖時間(s) | 高斯點數      |
| -------- | -------- | ------------ | ----------- | ----------- | ------------- | ------------- |
| garden   | 30000    | 27.112114    | 0.854833    | 0.157624    | 0.304765      | 1000000       |
| bicycle  | 30000    | 25.047745    | 0.767729    | 0.254825    | 0.293618      | 1000000       |
| stump    | 30000    | 26.554749    | 0.784203    | 0.263013    | 0.296536      | 1000000       |
| bonsai   | 30000    | 32.534199    | 0.948675    | 0.246924    | 0.436188      | 1000000       |
| counter  | 30000    | 29.187017    | 0.915823    | 0.242159    | 0.441259      | 1000000       |
| kitchen  | 30000    | 31.680832    | 0.933897    | 0.154965    | 0.449078      | 1000000       |
| room     | 30000    | 32.211632    | 0.930754    | 0.273719    | 0.413519      | 1000000       |
| **平均** | **30000**| **29.189755**| **0.876559**| **0.227604**| **0.376423**  | **1000000**   |

## 社群與支援

加入我們的社群，進行討論、支援與最新資訊：  
- 💬 **[Discord 社群](https://discord.gg/TbxJST2BbC)** - 求助、分享成果、討論開發  
- 🌐 **[mrnerf.com](https://mrnerf.com)** - 官方網站與資源  
- 📚 **[Awesome 3D Gaussian Splatting](https://mrnerf.github.io/awesome-3D-gaussian-splatting/)** - 完整論文與資源列表  
- 🐦 **[@janusch_patas](https://twitter.com/janusch_patas)** - 最新開發更新

## 建置與執行說明

### 軟體需求
1. **Linux**（已於 Ubuntu 22.04 測試） - Windows 尚不支援
2. **CMake** 3.24 或以上
3. **CUDA** 11.8 或以上（較低版本可能須手動配置）
4. **Python** 及開發標頭
5. **LibTorch 2.7.0** - 設定說明見下方
6. 其他依賴由 CMake 自動處理

### 硬體需求
1. **NVIDIA GPU** 支援 CUDA  
   - 已成功測試：RTX 4090、RTX A5000、RTX 3090Ti、A100  
   - RTX 3080Ti 在大型數據集存在已知問題（參見 #21）
2. 最低計算能力：8.0

> 若您成功於其他硬體執行，歡迎在討論區分享經驗！

### 建置指令

```bash
# 含子模組複製倉庫
git clone --recursive https://github.com/MrNeRF/gaussian-splatting-cuda
cd gaussian-splatting-cuda

# 下載並設定 LibTorch
wget https://raw.githubusercontent.com/MrNeRF/gaussian-splatting-cuda/master/libtorch-cxx11-abi-shared-with-deps-2.7.0%2Bcu118.zip  
unzip libtorch-cxx11-abi-shared-with-deps-2.7.0+cu118.zip -d external/
rm libtorch-cxx11-abi-shared-with-deps-2.7.0+cu118.zip

# 建置專案
cmake -B build -DCMAKE_BUILD_TYPE=Release
cmake --build build -- -j
```

## LibTorch 2.7.0

本專案採用 **LibTorch 2.7.0**，以獲得最佳效能與相容性：

- **效能增強**：優化與記憶體管理提升
- **API 穩定**：最新穩定 PyTorch C++ API
- **CUDA 相容**：更佳整合 CUDA 11.8+
- **錯誤修正**：解決優化器狀態管理問題

### 從舊版本升級
1. 依建置說明下載新版 LibTorch  
2. 清除建置目錄：`rm -rf build/`  
3. 重新建置專案

## 資料集

從原始倉庫下載資料集：  
[Tanks & Trains Dataset](https://repo-sam.inria.fr/fungraph/3d-gaussian-splatting/datasets/input/tandt_db.zip)

解壓縮至專案根目錄下的 `data` 資料夾。

## 指令行選項

### 核心選項

- **`-h, --help`**  
  顯示說明選單

- **`-d, --data-path [PATH]`**  
  訓練資料路徑（必填）

- **`-o, --output-path [PATH]`**  
  訓練模型儲存路徑（預設：`./output`）

- **`-i, --iter [NUM]`**  
  訓練迭代次數（預設：30000）  
  - 論文建議 3 萬次，但 6k-7k 次常有不錯初步結果  
  - 輸出會於每 7k 次及訓練結束時存檔

- **`-f, --force`**  
  強制覆蓋現有輸出資料夾

- **`-r, --resolution [NUM]`**  
  設定訓練影像解析度

### MCMC 專屬選項

- **`--max-cap [NUM]`**  
  MCMC 策略最大高斯點數（預設：1000000）  
  - 控制訓練期間高斯點雲數上限  
  - 適用於記憶體有限環境

### 範例用法

基本訓練：  
```bash
./build/gaussian_splatting_cuda -d /path/to/data -o /path/to/output -i 10000
```

MCMC 限制高斯點數訓練：  
```bash
./build/gaussian_splatting_cuda -d /path/to/data -o /path/to/output -i 10000 --max-cap 500000
```

## 貢獻指南

歡迎貢獻！開始方式如下：

1. **入門**  
   - 查看標記為 **good first issues** 的初學者任務  
   - 有新想法，請開討論或加入我們的 [Discord](https://discord.gg/TbxJST2BbC)

2. **提交 PR 前**  
   - 使用 `clang-format` 統一程式碼風格  
   - 使用預先提交鉤子：`cp tools/pre-commit .git/hooks/`  
   - 新增依賴前請先在 issue 討論，我們盡量減少依賴

## 致謝

本實作基於多個重要專案：

- **[gsplat](https://github.com/nerfstudio-project/gsplat)**：採用 gsplat 高度優化的 CUDA 光柵化後端，提供顯著效能與記憶體效率提升。

- **原始 3D Gaussian Splatting**：基於 Kerbl 等人的開創性研究。

## 引用

若在研究中使用本軟體，請引用原始論文：

```bibtex
@article{kerbl3Dgaussians,
  author    = {Kerbl, Bernhard and Kopanas, Georgios and Leimkühler, Thomas and Drettakis, George},
  title     = {3D Gaussian Splatting for Real-Time Radiance Field Rendering},
  journal   = {ACM Transactions on Graphics},
  number    = {4},
  volume    = {42},
  month     = {July},
  year      = {2023},
  url       = {https://repo-sam.inria.fr/fungraph/3d-gaussian-splatting/}
}
```

## 授權

詳見 LICENSE 檔案。

---

**聯絡我們：**  
- 🌐 官方網站：[mrnerf.com](https://mrnerf.com)  
- 📚 論文資源：[Awesome 3D Gaussian Splatting](https://mrnerf.github.io/awesome-3D-gaussian-splatting/)  
- 💬 Discord 社群：[加入我們](https://discord.gg/TbxJST2BbC)  
- 🐦 Twitter：追蹤 [@janusch_patas](https://twitter.com/janusch_patas) 取得開發最新消息

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---