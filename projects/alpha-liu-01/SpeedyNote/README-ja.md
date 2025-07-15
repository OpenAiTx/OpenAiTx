# 📝 SpeedyNote

_クラシックなタブレットPC、低解像度スクリーン、ヴィンテージハードウェア向けに設計された、軽量で高速、スタイラス最適化のノートテイキングアプリ。_

もし英語がわからない場合は、[中国語README](https://github.com/alpha-liu-01/SpeedyNote/blob/main/speedynote_README_zh_CN.md)をご覧ください

![cover](https://i.imgur.com/UTNNbnM.png)

---

## ✨ 特徴

- 🖊️ **圧力感知インキング** スタイラス対応
- 📄 **複数ページのノートブック** タブまたはスクロール表示対応
- 📌 **PDF背景統合** 注釈オーバーレイ付き
- 🌀 **ダイヤルUI + Joy-Con対応** 片手で直感的に操作可能
- 🎨 **ページごとの背景スタイル**：グリッド、罫線、または白紙（カスタマイズ可能）
- 💾 **ポータブルな `.snpkg` ノートブック** エクスポート/インポート＆共有用
- 🔎 **ズーム、パン、線の太さ、色のプリセット切替** ダイヤルで操作
- 💡 **低スペックデバイス向け設計**（Intel Atom N450で133Hzサンプルレート動作）
- 🌏 **多言語対応**（世界人口の半数をカバー）

---

## 📸 スクリーンショット

| 描画 | ダイヤルUI / Joy-Con操作 | オーバーレイグリッドオプション |
|----------------|------------------------|-----------------------|
| ![draw](https://i.imgur.com/iARL6Vo.gif) | ![pdf](https://i.imgur.com/NnrqOQQ.gif) | ![grid](https://i.imgur.com/YaEdx1p.gif) |


---

## 🚀 はじめに

### ✅ 動作環境

- Windows 7/8/10/11/Ubuntu amd64/Kali amd64/PostmarketOS arm64
- Qt 5 または Qt 6 ランタイム（Windowsリリースにはバンドル済み）
- スタイラス入力（Wacom推奨）

### 🛠️ 使い方

1. `NoteApp.exe` を起動
2. **フォルダアイコン** をクリックして作業フォルダを選択、または **`.snpkg` パッケージをインポート**
3. スタイラスで書き込み/描画を開始
4. **MagicDial** または **Joy-Con** を使ってツール変更、ズーム、スクロール、ページ切替
5. ノートブックは `.snpkg` としてエクスポート可能

---

## 📦 ノートブック形式

- 保存形式：
  - 📁 **フォルダ**（`.png` ページ＋メタデータ）
  - 🗜️ **`.snpkg` アーカイブ**（非圧縮 `.tar`、持ち運び用）
- 各ノートブックに含まれるもの：
  - 注釈付きページ画像 (`annotated_XXXX.png`)
  - PDF由来の背景画像（オプション）(`XXXX.png`)
  - メタデータ：背景スタイル、密度、色、PDFパス

---

## 🎮 コントローラー対応

SpeedyNoteはタブレットユーザーに最適なコントローラー入力をサポート：

- ✅ **左Joy-Con対応**
- 🎛️ アナログスティック → ダイヤル操作
- 🔘 ボタンは以下に割り当て可能：
  - 複数機能のダイヤル操作
  - フルスクリーン切替
  - 色／太さ変更
  - コントロールパネル開閉
  - ページ作成／削除

> 長押し＋回転＝ホールド＆回転のマッピング

---

## 📁 ソースからのビルド


1. **Qt 6** と **CMake** をインストール
2. このリポジトリをクローン
3. 以下を実行：

```bash
rm -r build
mkdir build
# ✅ Update translation source files (ensure the .ts files exist already)
& "C:\Qt\6.8.2\mingw_64\bin\lupdate.exe" . -ts ./resources/translations/app_fr.ts ./resources/translations/app_zh.ts ./resources/translations/app_es.ts
& "C:\Qt\6.8.2\mingw_64\bin\linguist.exe" resources/translations/app_zh.ts
& "C:\Qt\6.8.2\mingw_64\bin\linguist.exe" resources/translations/app_fr.ts
& "C:\Qt\6.8.2\mingw_64\bin\linguist.exe" resources/translations/app_es.ts
```
4. （オプション）GUIインターフェースで翻訳を修正する  
5. 実行：
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
元のテキストは1行です。翻訳も必ず1行にしてください。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-15

---