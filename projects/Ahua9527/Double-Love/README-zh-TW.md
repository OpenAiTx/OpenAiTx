# Double Love

<div align="center">

[![GitHub license](https://img.shields.io/github/license/Ahua9527/Double-Love)](https://github.com/Ahua9527/Double-Love/blob/main/LICENSE)
![GitHub stars](https://img.shields.io/github/stars/Ahua9527/Double-Love)

🎬 幀間有愛，效率翻倍

[//]: # (藏在代码里的彩蛋)
<!Double Love：讓每個鏡頭都藏著我未說出口的幀率 -->

[English](./README.en.md) · 簡體中文 · [線上體驗](https://double-love.ahua.space)

</div>

Double Love 為場記元資料提供自動化標準化處理。支援離線使用。透過批次處理、本地化處理，實現無縫對接 Adobe Premiere、Silverstack、DTG Slate，確保元資料一致性。有效提升後期工作流效率。

## ✨ 功能特性

- 🎬 影視工業化流程支援
- 📝 智慧元資料規範化處理
- ⚡ 零延遲本地化處理
- 🧩 無縫對接 Adobe Premiere

## 🚀 快速入門

### 基礎工作流程

1. 場記記錄：使用 DTG Slate 生成互動式場記單
2. 資料管理：透過 Silverstack Lab 匯入場記資料
3. 檔案匯出：生成 Adobe Premiere Pro XML
4. 標準化處理：使用 Double Love 進行智慧優化

範例：
- 輸入 xml：`UnitA_304_20250127.xml`
- 輸出 xml：`UnitA_304_20250127_Double_LOVE.xml`

### 詳細範例

#### 檔案命名優化
- 程式會自動處理場景號、鏡頭號和場次號的格式
- 自動為數字補充前導零
- 自動處理大小寫規範
- 自動清理多餘的底線

#### 片段命名規則

處理後的片段名稱遵循以下格式：
```
{項目前綴}{場景}_{鏡頭}_{場次}{攝影機}{評級}
```

- `prefix`: 自訂前綴（可選）
- `scene`: 場景號（3位數字，如 001）
- `shot`: 鏡頭號（2位數字，如 01）
- `take`: 場次號（2位數字，如 01）
- `camera`: 攝影機標識（小寫字母，如 a）
- `Rating`: 評分（ok/kp/ng）

#### 評分處理
- `Circle` → `ok`
- `KEEP` → `kp`
- `NG` → `ng`

#### DIT 資訊
- 自動添加 DIT 資訊：'DIT: 哆啦Ahua 🌱'
- 若需移除請自行部署😁😁

#### 自訂前綴範例

1. 設定前綴為 "PROJECT_A_"：
   - 輸入檔案：`A304C007_250123G3`
   - 輸出檔案：`PROJECT_A_004_01_07a_kp`

2. 不設定前綴：
   - 輸入檔案：`A304C007_250123G3`
   - 輸出檔案：`004_01_07a_kp`

#### 序列解析度設定範例

1. FHD 解析度（預設）：
   - 寬度：1920
   - 高度：1080   
2. DCI 2K 解析度（自訂）：
   - 寬度：2048
   - 高度：1080   

#### 批次處理範例

1. 同時上傳多個檔案：
   ```
   UnitA_304_20250123.xml
   UnitA_305_20250124.xml
   UnitA_306_20250125.xml
   ```

2. 處理完成後將得到：
   ```
   UnitA_304_20250123_Double_LOVE.xml
   UnitA_305_20250124_Double_LOVE.xml
   UnitA_306_20250125_Double_LOVE.xml
   ```

## 🛠️ 技術棧

- React 18
- TypeScript
- Vite
- Tailwind CSS
- Lucide Icons
- PWA Support

## 📦 安裝與使用

1. 複製專案

```bash
git clone https://github.com/Ahua9527/Double-Love.git
cd Double-Love
```

2. 安裝依賴

```bash
npm install
```

3. 本地開發

```bash
npm run dev
```

4. 構建專案

```bash
npm run build
```

## 🔒 安全說明

- 所有檔案處理皆於瀏覽器本地進行，不會上傳至伺服器
- 支援最大 50MB 的檔案大小限制
- 僅支援處理 XML 格式檔案

## 🌈 開發者說明

### 專案結構

```
Double-Love/
├── src/
│   ├── components/     # React 元件
│   ├── context/       # React Context
│   ├── utils/         # 工具函式
│   ├── styles/        # 樣式檔案
│   └── App.tsx        # 主應用元件
├── public/            # 靜態資源
└── ...設定檔案
```

## 📃 版權許可

[MIT License](LICENSE)

## 🤝 貢獻指南

歡迎提交 Issue 與 Pull Request！

## 👨‍💻 作者

哆啦Ahua🌱

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-17

---