<p align="center">
    <img src="https://raw.githubusercontent.com/basketoengine/Basketo/main/readmeimgs/logo.png" alt="Basketo 遊戲引擎標誌" width="200"/>
</p>

<h2 align="center">創造、遊玩、啟發。讓遊戲栩栩如生。 ✨</h2>

<h1 align="center">Basketo 遊戲引擎</h1>

<div align="center">

[![Discord](https://img.shields.io/discord/1373185493742911609?logo=discord&label=Discord&color=5B5BD6&logoColor=white)](https://discord.gg/F3DswRMW) <!-- 將 your_discord_server_id 替換為您的實際伺服器 ID -->
[![GitHub stars](https://img.shields.io/github/stars/basketoengine/Basketo?style=social)](https://github.com/basketoengine/Basketo)
[![X (formerly Twitter)](https://img.shields.io/twitter/follow/BaslaelWorkneh?style=social&logo=x)](https://x.com/BaslaelWorkneh)

</div>

<p align="center">
歡迎來到 Basketo 引擎——這是一個充滿熱情的專案，我們正全力以赴打造一個出色且高效的引擎，並且計劃將其打造成 AI 原生的遊戲引擎。它具備類似 Unity 的編輯器介面、Gemini AI 整合、先進的多音效系統，以及強大的 ECS 架構。無論你是想貢獻、提出想法，還是純粹想見證它的成長，你都是這段旅程的一部分！🚀
</p>
## 🚀 引擎當前狀態
<p align="center">
  <img src="https://raw.githubusercontent.com/basketoengine/Basketo/main/readmeimgs/image3.png" alt="Current State of Basketo Engine" width="700"/>
</p>

<p align="center">
  <em>查看最新開發進度及功能展示！</em> 🎮
</p>

## ✨ 主要功能

### 🎮 **類似 Unity 的編輯器介面**
- **雙視窗佈局**：場景編輯器與遊戲視圖並排顯示
- **即時編輯**：遊戲運行時可修改場景
- **檢查器面板**：元件可視化拖放編輯
- **階層檢視**：實體組織與管理
- **資產瀏覽器**：輕鬆管理材質與音效

### 🤖 **原生 AI 開發**
- **Gemini AI 整合**：以自然語言指令進行遊戲開發
- **智慧腳本生成**：AI 驅動的 Lua 腳本創建
- **實體修改**：以簡單英文描述即可變更
- **輕鬆 API 設定**：內建 Gemini API 金鑰配置
### 🔊 **進階音效系統**
- **多重音效**：每個實體可有多個命名音效（行走、跳躍、攻擊等）
- **傳統音訊**：背景音樂與環境音效
- **Lua 整合**：可使用 `PlaySound(entity, "action")` 從腳本觸發音效
- **視覺化編輯器**：透過檢查器管理音效

### 🎯 **實體-元件-系統 (ECS)**
- **高效能**：針對大量實體進行最佳化
- **模組化設計**：可依需求自由組合元件
- **腳本整合**：Lua 腳本可完全存取 ECS
- **即時更新**：元件可即時編輯

### 🎨 **圖形與動畫**
- **精靈渲染**：高效的 2D 圖形處理流程
- **動畫系統**：基於幀的動畫並支援循環播放
- **變換系統**：位置、旋轉與縮放
- **攝影機系統**：支援多攝影機

### ⚡ **物理與碰撞**
- **碰撞偵測**：AABB 碰撞與空間最佳化
- **剛體物理**：重力、速度與力
- **碰撞回呼**：可由腳本存取的碰撞事件
- **空間分割**：四叉樹效能最佳化
## 🎬 點擊下方圖片觀看影片示範：
<p align="center">
  <a href="https://x.com/BaslaelWorkneh/status/1922713614697288096">
    <img src="https://raw.githubusercontent.com/basketoengine/Basketo/main/readmeimgs/image2.png" alt="Basketo Engine Demo" width="500"/>
  </a>
</p>

## � 快速入門指南

### 1. **取得你的 Gemini API 金鑰**（可選，但建議）
- 訪問 [Google AI Studio](https://aistudio.google.com/app/apikey)
- 登入並建立免費的 API 金鑰
- 這可啟用如自然語言指令等 AI 功能

### 2. **建置並執行**
```bash
git clone --recurse-submodules git@github.com:basketoengine/Basketo.git
cd Basketo && mkdir build && cd build
cmake .. && make -j$(nproc)
./BasketoGameEngine
```
### 3. **設定 AI 功能**
- 在引擎中，前往 AI 提示面板（底部）
- 尋找「🤖 Gemini AI 設定」
- 輸入您的 API 金鑰並點擊「儲存」

### 4. **開始創作**
- 嘗試 AI 指令：`"create a player at 100 200"`
- 在檢查器中為實體新增音效
- 編寫 Lua 腳本或讓 AI 自動產生
- 使用雙視窗編輯器進行即時開發

## 🛠️ 建置引擎（Linux）🐧

### 先決條件
- 需要 CMake 3.26.0 或更高版本。
- SDL2、SDL2_image、SDL2_ttf、SDL2_mixer
- Lua 5.4
- g++（C++17）
- libcurl（用於 AI 功能）
- nlohmann/json（作為子模組包含）
- ImGui（作為子模組包含）

### 建置步驟
```bash
# 複製儲存庫
git clone --recurse-submodules git@github.com:basketoengine/Basketo.git

cd Basketo

mkdir build && cd build

cmake ..

make -j$(nproc)

```

### 執行
```bash
./BasketoGameEngine

```
如果你想運行物理測試：
```bash
./PhysicsTest

```

## 🛠️ 建置引擎（Windows）💻

### 先決條件

1. **Visual Studio 2022（Community Edition 或更高版本）**  
   安裝時請選擇以下工作負載：
   - 使用 C++ 的桌面開發
   - 適用於 Windows 的 C++ CMake 工具
   - Windows 10 或 11 SDK

2. **CMake**（隨 Visual Studio 附帶或從 https://cmake.org/download/ 下載）

3. **vcpkg**（用於安裝相依套件）


---
### 安裝相依套件

```bash
# 開啟 VS 2022 的 Developer Command Prompt 或 PowerShell

# 複製 vcpkg

git clone https://github.com/microsoft/vcpkg.git
cd vcpkg

.\bootstrap-vcpkg.bat

# 安裝所需函式庫
.\vcpkg install sdl2 sdl2-image sdl2-ttf sdl2-mixer lua curl

```

---

### 建置步驟
```bash
# 複製 Basketo 儲存庫
git clone --recurse-submodules git@github.com:basketoengine/Basketo.git
cd Basketo
mkdir build && cd build

# 使用 CMake 進行設定
cmake .. -DCMAKE_TOOLCHAIN_FILE=C:/path/to/vcpkg/scripts/buildsystems/vcpkg.cmake -DCMAKE_BUILD_TYPE=Release

# 將 "C:/path/to/vcpkg" 替換為你的 vcpkg 目錄的完整路徑

# 建置引擎
cmake --build . --config Release
```

---

### 執行

```bash
# 從 build/Release 目錄
```
./BasketoGameEngine.exe

# 執行物理測試
./PhysicsTest.exe
```

## 📚 文件

### 核心功能
- **[音效系統](https://raw.githubusercontent.com/basketoengine/Basketo/main/docs/SoundEffectsSystem.md)**：多音效完整指南
- **[Gemini API 設定](https://raw.githubusercontent.com/basketoengine/Basketo/main/docs/GeminiAPIKeySetup.md)**：AI 步驟設定說明
- **[Lua 腳本](assets/Scripts/)**：範例腳本與 API 參考

### 範例用法

#### AI 驅動開發
```bash
# 自然語言指令
"在座標 100 200 創建一個玩家角色"
"為玩家新增跳躍行為"
"讓敵人移動更快"

# 腳本生成
gemini_script 建立一個具有二段跳的橫向卷軸控制器
```

#### 多音效效果
```lua
-- 在你的 Lua 腳本中
PlaySound(entity, "jump")    -- 播放跳躍音效
PlaySound(entity, "walk")    -- 播放行走音效
PlaySound(entity, "attack")  -- 播放攻擊音效

-- 檢查音效是否存在
if HasSoundEffect(entity, "jump") then
    PlaySound(entity, "jump")
end
```

#### 元件系統
- **Transform**：位置、旋轉、縮放
- **Sprite**：材質渲染
- **Animation**：基於幀的動畫
- **Script**：Lua 行為腳本
- **Collider**：物理碰撞
- **Rigidbody**：物理模擬
- **Audio**：背景音樂
- **SoundEffects**：多個命名音效
- **Camera**：視角管理
## 🤝 參與我們

我們非常歡迎來自社群的貢獻 ❤️。有關貢獻或以開發模式運行專案的詳細資訊，請參閱我們的[貢獻指南](https://raw.githubusercontent.com/basketoengine/Basketo/main/ContributionGuidline.md)。 <!-- 假設您擁有此文件 -->

- 🐛 發現錯誤？請提出 Issue！
- ✨ 有很棒的新功能想法？讓我們聽聽吧！
- 💻 想要貢獻？Fork、編寫程式碼並建立 Pull Request！

讓我們一起打造這個引擎，讓遊戲開發變得有趣且簡單，造福每一個人。🌍

## 👥 社群
給您最熱情的歡迎 🤗。我們非常期待各種形式的社群貢獻——無論是程式碼改進 📝、文件更新 📚、問題回報 🐞、功能請求 💡，還是在我們的 Discord 討論 🗣️。

加入我們的社群：

- 👋 [加入我們的 Discord 社群](https://discord.gg/F3DswRMW)
- ⭐ [在 GitHub 為我們加星](https://github.com/basketoengine/Basketo)

## 🙏 支持我們：
我們不斷改進，更多功能與範例即將推出 🌟。如果你喜歡這個專案，請到 GitHub 倉庫幫我們點個星 ⭐ [![GitHub](https://img.shields.io/github/stars/basketoengine/Basketo?color=5B5BD6)](https://github.com/basketoengine/Basketo)，隨時掌握最新資訊並幫助我們成長。🌱

---

祝您程式設計與遊戲製作愉快！🎉🎮

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-10

---