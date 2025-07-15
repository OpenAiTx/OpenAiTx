# 📝 SpeedyNote

_一款輕量、快速且優化觸控筆操作的筆記應用，專為經典平板電腦、低解析度螢幕及復古硬體打造。_

如果您恰好不懂英文，請移步[中文README](https://github.com/alpha-liu-01/SpeedyNote/blob/main/speedynote_README_zh_CN.md)

![cover](https://i.imgur.com/UTNNbnM.png)

---

## ✨ 功能

- 🖊️ **壓力感應繪圖**，支援觸控筆
- 📄 **多頁筆記本**，支援分頁標籤或可滾動頁面檢視
- 📌 **PDF 背景整合**，附加註解覆蓋層
- 🌀 **旋鈕介面 + Joy-Con 支援**，直覺單手操作
- 🎨 **每頁背景樣式**：格線、橫線或空白（可自訂）
- 💾 **可攜式 `.snpkg` 筆記本**，支援匯出/匯入及分享
- 🔎 **透過旋鈕切換縮放、平移、筆觸粗細與顏色預設**
- 💡 **為低規裝置設計**（133Hz 取樣率 @ Intel Atom N450）
- 🌏 **支援多國語言**（涵蓋全球半數人口）

---

## 📸 截圖

| 繪圖 | 旋鈕介面 / Joycon 控制 | 覆蓋格線選項 |
|----------------|------------------------|-----------------------|
| ![draw](https://i.imgur.com/iARL6Vo.gif) | ![pdf](https://i.imgur.com/NnrqOQQ.gif) | ![grid](https://i.imgur.com/YaEdx1p.gif) |


---

## 🚀 快速開始

### ✅ 系統需求

- Windows 7/8/10/11/Ubuntu amd64/Kali amd64/PostmarketOS arm64
- Qt 5 或 Qt 6 執行環境（Windows 版本內建）
- 觸控筆輸入（推薦 Wacom）

### 🛠️ 使用說明

1. 啟動 `NoteApp.exe`
2. 點擊 **資料夾圖示** 選擇工作資料夾或 **匯入 `.snpkg` 套件**
3. 使用觸控筆開始書寫/繪圖
4. 使用 **MagicDial** 或 **Joy-Con** 切換工具、縮放、滾動或切換頁面
5. 筆記本可匯出為 `.snpkg`

---

## 📦 筆記本格式

- 可保存為：
  - 📁 一個 **資料夾**，內含 `.png` 頁面和元資料
  - 🗜️ 一個 **`.snpkg` 壓縮包**，方便攜帶（非壓縮 `.tar`）
- 每本筆記本可能包含：
  - 註解頁面圖片（`annotated_XXXX.png`）
  - 可選的 PDF 背景圖（`XXXX.png`）
  - 元資料：背景樣式、密度、顏色及 PDF 路徑

---

## 🎮 控制器支援

SpeedyNote 支援控制器輸入，適合平板用戶：

- ✅ **支援左手 Joy-Con**
- 🎛️ 類比搖桿 → 旋鈕控制
- 🔘 按鈕可映射為：
  - 控制旋鈕多功能
  - 切換全螢幕
  - 更改顏色 / 筆觸粗細
  - 開啟控制面板
  - 新增/刪除頁面

> 長按 + 旋轉 = 按住旋轉對應映射

---

## 📁 從原始碼建置


1. 安裝 **Qt 6** 與 **CMake**
2. 克隆本倉庫
3. 執行：

```bash
rm -r build
mkdir build
# ✅ Update translation source files (ensure the .ts files exist already)
& "C:\Qt\6.8.2\mingw_64\bin\lupdate.exe" . -ts ./resources/translations/app_fr.ts ./resources/translations/app_zh.ts ./resources/translations/app_es.ts
& "C:\Qt\6.8.2\mingw_64\bin\linguist.exe" resources/translations/app_zh.ts
& "C:\Qt\6.8.2\mingw_64\bin\linguist.exe" resources/translations/app_fr.ts
& "C:\Qt\6.8.2\mingw_64\bin\linguist.exe" resources/translations/app_es.ts
```
4. （可選）在圖形介面中修改翻譯  
5. 執行：
```bash
rm -r build
mkdir build
& "C:\Qt\6.8.2\mingw_64\bin\lrelease.exe" ./resources/translations/app_zh.ts ./resources/translations/app_fr.ts ./resources/translations/app_es.ts

Copy-Item -Path "C:\Games\yourfolder\resources\translations\*.qm" -Destination "C:\Games\yourfolder\build" -Force

cd .\build
cmake -G "MinGW Makefiles" .. 
cmake --build .  
& "C:\Qt\6.8.2\mingw_64\bin\windeployqt.exe" "NoteApp.exe"
Copy-Item -Path "C:\yourfolder\dllpack\*.dll" -Destination "C:\yourfolder\build" -Force
Copy-Item -Path "C:\yourfolder\bsdtar.exe" -Destination "C:\yourfolder\build" -Force
./NoteApp.exe
cd ../
```
原始文本有1行。您的翻譯也必須恰好有1行。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-15

---