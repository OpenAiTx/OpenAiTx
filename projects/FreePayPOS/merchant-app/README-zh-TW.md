# NFC支付終端機

一款多鏈NFC支付終端機，可處理5條區塊鏈網路上的加密貨幣支付，具備即時交易監控與完整歷史追蹤功能。

## 🌐 支援網路

- **Ethereum**
- **Base**
- **Arbitrum**
- **Optimism**
- **Polygon**

### 🎯 **智慧支付優先級**

無需與商家協商鏈/代幣組合，支付終端機將自動處理。它會先找出您和商家都支援且您有資金的區塊鏈，然後依照以下優先順序，以ETH或ERC-20代幣發送交易：

```
L2穩定幣 > L2其他 > L2 ETH > L1穩定幣 > L1其他 > L1 ETH
```
## 🚀 快速開始

1. **安裝依賴項：**
   ```bash
   npm install
   ```

2. **環境設定：**
   ```bash
   echo "ALCHEMY_API_KEY=your_alchemy_api_key_here" > .env
   ```

3. **運行終端機：**
   ```bash
   npm start
   ```

4. **開啟介面：**
   前往 `http://localhost:3000`

## 🏗️ 架構

```
src/
├── server.ts                   # Express 伺服器與 WebSocket 處理器
├── app.ts                      # 主要應用程式協調器
├── web/index.html              # 支付終端機 UI
├── config/index.ts             # 多鏈設定
└── services/
    ├── nfcService.ts           # NFC 讀取器與錢包掃描
    ├── alchemyService.ts       # 多鏈餘額與監控
    ├── paymentService.ts       # 支付選擇與 EIP-681 產生
    ├── ethereumService.ts      # 地址驗證工具
    └── addressProcessor.ts     # 防止重複處理
scripts/
└── rpi-deploy/
    ├── setup-build-environment.sh  # 安裝相依套件以建構 Raspberry Pi 映像檔
    └── build-pi-image-osx.sh       # 建構 Raspberry Pi 映像檔
```
## 💡 使用方法

### **處理付款**
1. 使用數字鍵盤輸入金額（以分為單位："150" = $1.50）
2. 點擊「收款」以啟動付款流程
3. 顧客輕觸NFC裝置以發送付款
4. 即時監控確認交易狀態
5. 顯示「已核准」訊息並附區塊瀏覽器連結

### **交易紀錄**
1. 點擊數字鍵盤上的 📜 歷史紀錄按鈕
2. 查看所有交易或掃描錢包以查詢特定紀錄
3. 點擊「📱 掃描錢包查詢歷史紀錄」，請顧客輕觸其裝置
4. 瀏覽該錢包的篩選後交易紀錄


## 🔄 付款流程

1. **NFC偵測** → 顧客輕觸裝置
2. **多鏈查詢** → 橫跨全部6條鏈的資產組合分析
3. **智能選擇** → 依優先系統自動挑選最佳付款代幣
4. **EIP-681產生** → 付款請求附帶鏈ID
5. **即時監控** → WebSocket/輪詢確認交易
6. **歷史記錄** → 交易完整元數據儲存
## 🛡️ 交易監控

- 支援以太坊、Base、Arbitrum、Optimism、Polygon 的 **WebSocket 監控**
- **輪詢監控** 作為備援
- **自動逾時** 5 分鐘後結束
- **區塊瀏覽器整合** 進行交易驗證
- **狀態追蹤**：已偵測 → 已確認 → 失敗

## 🍓 Raspberry Pi 部署

本 NFC 支付終端可作為 **即插即用自助機** 在 Raspberry Pi 硬體上部署，用於生產環境。

### **硬體需求**
- Raspberry Pi 4B（建議 4GB 以上記憶體）
- 7 吋官方 Raspberry Pi 觸控螢幕
- **ACR1252U-M1 NFC 讀卡機**（專門支援）
- 32GB 以上 MicroSD 記憶卡

### **部署特點**
- **一鍵建構** 製作可開機 SD 卡映像檔
- **預設 WiFi** 及 API 憑證設定
- **自動啟動** 並進入全螢幕自助機模式
- **安全驗證** 防止以測試位址部署
- 支援 **macOS 與 Linux** 環境建構
### **快速部署**
```bash
# 前往部署腳本目錄
cd scripts/rpi-deploy

# 配置您的部署
cp build-config.env.template build-config.env
# 使用您的 WiFi、API 金鑰和商戶地址編輯 build-config.env

# 建立可開機映像檔（macOS）
./build-pi-image-osx.sh

# 使用 Raspberry Pi Imager 將產生的 nfc-terminal-<date>.img.gz 檔案燒錄到 SD 卡並開機！
```

📖 **[完整部署指南](https://raw.githubusercontent.com/FreePayPOS/merchant-app/main/README-DEPLOYMENT.md)**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---