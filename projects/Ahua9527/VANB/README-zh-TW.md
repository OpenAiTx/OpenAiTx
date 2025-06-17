# VANB (Video Audio Network Bridge)
# VANB (Video Assistant NDI Bridge)
# VANB (哇!! NB)

VANB 是一個基於 GStreamer 的視訊/音訊串流轉換工具，支援 NDI 與 RTMP 協議間的雙向轉換。它允許將 NDI 來源推流到 RTMP 伺服器，或將 RTMP 串流轉換為 NDI 輸出。

本專案使用 [GPL-3.0](https://www.gnu.org/licenses/gpl-3.0.html) 授權開源。

## 支援平台

目前主要支援以下平台：
- macOS (Apple Silicon)

## 環境要求

### 系統依賴
- [GStreamer 1.24+](https://gstreamer.freedesktop.org)
- [NewTek NDI SDK](https://www.ndi.tv/sdk/)

### 安裝步驟
1. 安裝 [NewTek NDI SDK](https://www.ndi.tv/sdk/)

2. 透過 Homebrew 安裝 GStreamer
```bash
brew install --cask --zap gstreamer-development
```

3. 克隆專案倉庫
```bash
git clone https://github.com/Ahua9527/VANB.git
cd VANB
```

4. 安裝 Python 依賴
```bash
pip install -r requirements.txt
```

5. 設定環境變數 (參考 .env 檔案)
```bash
# 設定 NDI SDK 路徑
export NDI_SDK_PATH=/Library/NDI SDK for Apple
# 設定 GStreamer 外掛路徑
export GST_PLUGIN_PATH=/opt/homebrew/lib/gstreamer-1.0:${NDI_SDK_PATH}/lib/macOS
export DYLD_LIBRARY_PATH=/opt/homebrew/lib:${NDI_SDK_PATH}/lib/macOS
export GI_TYPELIB_PATH=/opt/homebrew/lib/girepository-1.0:/usr/local/lib/girepository-1.0
```

## 使用方法

### NDI 轉 RTMP (發送端)
```bash
python vanb_tx.py
```
程式會自動掃描可用的 NDI 來源，並提示輸入 RTMP 推流地址。

### RTMP 轉 NDI (接收端)
```bash
python vanb_rx.py
```
輸入 RTMP 拉流地址後，程式會自動建立一個新的 NDI 輸出。

## 開發狀態

### 已實現功能
- ✓ NDI 到 RTMP 的轉換
- ✓ RTMP 到 NDI 的轉換
- ✓ 自動幀率和解析度適配
- ✓ 音視訊同步
- ✓ NDI 來源自動掃描
- ✓ NDI 輸出自動命名
- ✓ VideoToolbox 硬體編解碼

### 待實現功能
- ⨯ 設定檔支援 (Profile/config.json)
  - 透過設定檔控制輸入輸出參數
  - 支援多種轉碼預設配置
  - 可設定緩衝區大小和延遲參數
  - 支援轉碼品質與效能平衡配置
- ⨯ 多路串流並發處理

## 授權聲明

⚠️ **重要提示：授權與合規性**

### 軟體授權

本專案採用 [GNU General Public License v3.0](https://www.gnu.org/licenses/gpl-3.0.html) 授權。

選擇 GPL-3.0 授權的原因：
1. 本專案使用了多個 GPL 授權的 GStreamer 外掛：
   - `x264`: H.264 視訊編碼器 (GPL)
   - `x265`: HEVC/H.265 視訊編碼器 (GPL)
   - `faad`: AAC 音訊解碼器 (GPL)
2. 根據 GPL 的傳染性條款，使用 GPL 元件的軟體也必須採用 GPL 授權
3. 選擇 GPL-3.0 可確保與所有相依元件的授權相容

### 授權要求

使用本專案時，您必須遵守以下要求：
1. **程式碼開源**：如果您修改了本專案的程式碼或將其整合進您的專案，必須開源您的完整原始碼
2. **保持授權**：您的專案必須繼續使用 GPL-3.0 授權
3. **版權聲明**：您必須保留原始版權聲明和授權聲明
4. **顯著註明**：如果您修改了程式碼，必須顯著註明您所做的更動
5. **專利授權**：GPL-3.0 包含明確的專利授權條款

### GStreamer 元件授權
1. 本專案僅用於開發與測試目的
2. NDI® 是 NewTek, Inc. 的註冊商標
3. 使用本專案需遵守 NewTek NDI® SDK 授權協議
4. 在生產環境使用前，請確保已取得所有必要的授權與許可

## 問題回饋

如遇到問題，請：
1. 檢查是否正確設定了環境變數
2. 確認 GStreamer 外掛是否正確安裝
3. 查看日誌檔案中的詳細錯誤訊息
4. 透過 Issues 回饋問題，並附上日誌與環境資訊

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-17

---