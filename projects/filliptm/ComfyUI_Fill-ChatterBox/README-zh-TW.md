<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# ComfyUI_Fill-ChatterBox

如果你喜歡這個專案，請考慮在 Patreon 支持我！
<p align="left">
  <a href="https://www.patreon.com/c/Machinedelusions">
    <img src="https://raw.githubusercontent.com/filliptm/ComfyUI_Fill-ChatterBox/main/assets/Patreon.png" width="150px" alt="Patreon">
  </a>
</p>

這是一個為 ComfyUI 客製化的節點擴充，利用 Chatterbox 函式庫加入文字轉語音（TTS）與語音轉換（VC）功能。
支援最大 40 秒音訊。我已嘗試移除此限制，但模型在更長的內容下效果非常差，因此仍維持此限制。

![ChatterBox Example](https://raw.githubusercontent.com/filliptm/ComfyUI_Fill-ChatterBox/main/web/image.png)

## 安裝方式

1. 將此儲存庫複製（clone）到你的 ComfyUI custom_nodes 目錄下：

   ```bash
   cd /path/to/ComfyUI/custom_nodes
   git clone https://github.com/filliptm/ComfyUI_Fill-ChatterBox.git
   ```
2. 安裝基本相依套件：

   ```bash
   pip install -r ComfyUI_Fill-ChatterBox/requirements.txt
   ```
3. （可選）安裝浮水印支援：

   ```bash
   pip install resemble-perth
   ```
**注意**：`resemble-perth` 套件在 Python 3.12+ 版本可能會有相容性問題。如果你遇到匯入錯誤，這些節點仍然可以在沒有浮水印的情況下運作。

## 使用說明

### 文字轉語音節點（FL Chatterbox TTS）
- 將「FL Chatterbox TTS」節點加入你的工作流程
- 設定文字輸入與參數（誇張度、cfg_weight、temperature）
- 可選擇性提供音訊提示以進行語音克隆

### 語音轉換節點（FL Chatterbox VC）
- 將「FL Chatterbox VC」節點加入你的工作流程
- 連接輸入音訊與目標語音
- 若發生 CUDA 錯誤，這兩個節點都支援 CPU 備援

## 更新記錄

### 2025/6/24
- 為 TTS 與 VC 節點新增了種子參數，以實現可重現的生成
- 種子範圍：0 到 4,294,967,295（32 位元整數）
- 使除錯與工作流程控制時可產生一致的音訊輸出
- 選擇性啟用 Perth 浮水印，以修正 Python 3.12+ 相容性問題
- 若 resemble-perth 匯入失敗，節點現在可在無浮水印情況下運作

### 2025/5/31
- 新增 Persistent 模型載入與載入進度條功能
- 新增 Mac 支援（需要測試，有需要請聯絡我）
- 移除了 chatterbox-tts 函式庫，並實作原生推論程式碼。




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-23

---