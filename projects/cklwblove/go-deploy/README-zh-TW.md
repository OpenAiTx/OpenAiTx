# Go-Deploy 部署工具

一個基於 Go 語言開發的自動化部署工具，支援通過 SFTP 協議將本地構建產物上傳到遠端伺服器。

## 功能特性

- ✅ **安全傳輸**：使用 SFTP 協議，基於 SSH 加密傳輸
- ✅ **目錄同步**：遞迴上傳整個目錄結構，保持檔案層級
- ✅ **智慧建立**：自動建立遠端目錄結構
- ✅ **路徑自適應**：自動根據可執行檔位置計算本地路徑，無需關心執行目錄
- ✅ **配置檔支援**：支援 JSON 配置檔，方便管理不同環境的配置
- ✅ **檔案排除**：支援萬用字元模式排除不需要上傳的檔案
- ✅ **自動備份**：上傳前可自動備份遠端檔案
- ✅ **重試機制**：上傳失敗時自動重試，提高成功率
- ✅ **詳細統計**：顯示上傳檔案數、傳輸大小、耗時與速度
- ✅ **進度顯示**：即時顯示上傳進度與檔案資訊
- ✅ **錯誤處理**：完善的錯誤處理與日誌輸出

## 系統需求

- Go 1.18 或更高版本
- 目標伺服器支援 SSH/SFTP 協議

## 安裝說明

### 1. 克隆專案

```bash
git clone <your-repo-url>
cd go-deploy
```

### 2. 初始化 Go 模組

```bash
go mod init go-deploy
go mod tidy
```

### 3. 安裝依賴

程式會自動下載以下依賴：

- `github.com/pkg/sftp` - SFTP 客戶端
- `golang.org/x/crypto/ssh` - SSH 客戶端

## 配置說明

程式支援兩種配置方式：

### 1. 使用配置檔（推薦）

將 `config.example.json` 複製為 `config.json` 並修改配置：

```bash
cp config.example.json config.json
```

然後編輯 `config.json`：

```json
{
  "server": {
    "host": "your-server-ip",
    "port": 22,
    "username": "your-username",
    "password": "your-password",
    "timeout": 10
  },
  "paths": {
    "local": "../../unpackage/dist/build/web",
    "remote": "/opt/your-path/dist"
  },
  "options": {
    "backup": true,
    "backup_suffix": ".backup",
    "exclude_patterns": [
      "*.log",
      "*.map",
      ".DS_Store",
      "node_modules"
    ],
    "max_retries": 3,
    "chunk_size": 1048576
  }
}
```

#### 配置項說明

**server 配置**：

- `host`: SSH 伺服器位址
- `port`: SSH 埠號，通常為 22
- `username`: SSH 使用者名稱
- `password`: SSH 密碼（生產環境建議使用金鑰認證）
- `timeout`: 連線逾時時間（秒）

**paths 配置**：

- `local`: 本地目錄路徑，支援相對路徑與絕對路徑
- `remote`: 遠端目錄路徑，必須為絕對路徑

**options 配置**：

- `backup`: 是否在上傳前建立備份遠端已存在的檔案
- `backup_suffix`: 備份檔案的副檔名，可自訂備份檔案副檔名，如備份檔案不存在則略過備份
- `exclude_patterns`: 檔案排除模式，支援萬用字元
- `max_retries`: 上傳失敗時的最大重試次數
- `chunk_size`: 檔案傳輸區塊大小（位元組，暫未實現）

### 2. 預設配置（相容模式）

如果沒有 `config.json` 檔案，程式會使用內建的預設配置，保持向後相容。

#### 配置檔優先順序

1. **命令列指定的配置檔**：`--config` 參數指定的檔案
2. **預設配置檔**：當前目錄下的 `config.json`
3. **內建預設配置**：若以上皆不存在，使用程式內建的配置

#### 路徑處理規則

- **配置檔路徑**：

  - 相對路徑：以可執行檔所在目錄為基準
  - 絕對路徑：直接使用指定路徑
- **本地目錄路徑**：

  - 相對路徑：以可執行檔所在目錄為基準
  - 絕對路徑：直接使用指定路徑

## 執行說明

### 命令列參數

程式支援以下命令列參數：

```bash
# 顯示說明資訊
./deploy --help

# 顯示版本資訊  
./deploy --version

# 使用預設配置檔 config.json
./deploy

# 使用指定配置檔
./deploy --config prod.json

# 使用絕對路徑配置檔
./deploy --config /path/to/config.json
```

### 開發環境執行

```bash
# 使用預設配置
go run main.go

# 使用指定配置檔
go run main.go --config test.json

# 顯示說明
go run main.go --help
```

### 編譯後執行

```bash
# 編譯
go build -o deploy main.go

# 使用預設配置執行
./deploy

# 使用指定配置檔執行
./deploy --config prod.json
```

## 打包說明

### 1. 本地平台打包

```bash
# 編譯當前平台可執行檔
go build -o deploy main.go
```

### 2. 跨平台打包

#### Linux 64 位

```bash
GOOS=linux GOARCH=amd64 go build -o deploy-linux-amd64 main.go
```

#### Windows 64 位

```bash
GOOS=windows GOARCH=amd64 go build -o deploy-windows-amd64.exe main.go
```

#### macOS 64位

```bash
GOOS=darwin GOARCH=amd64 go build -o deploy-darwin-amd64 main.go
```

#### macOS ARM64 (M1/M2)

```bash
GOOS=darwin GOARCH=arm64 go build -o deploy-darwin-arm64 main.go
```

### 3. 優化打包（減小檔案大小）

```bash
# 去除除錯資訊和符號表
go build -ldflags="-s -w" -o deploy main.go

# 使用UPX壓縮（需先安裝UPX）
upx --best deploy
```

### 4. 批次打包腳本

建立 `build.sh` 腳本：

```bash
#!/bin/bash

# 建立建構目錄
mkdir -p builds

# 建構各平台版本
echo "建構 Linux 64位版本..."
GOOS=linux GOARCH=amd64 go build -ldflags="-s -w" -o builds/deploy-linux-amd64 main.go

echo "建構 Windows 64位版本..."
GOOS=windows GOARCH=amd64 go build -ldflags="-s -w" -o builds/deploy-windows-amd64.exe main.go

echo "建構 macOS 64位版本..."
GOOS=darwin GOARCH=amd64 go build -ldflags="-s -w" -o builds/deploy-darwin-amd64 main.go

echo "建構 macOS ARM64版本..."
GOOS=darwin GOARCH=arm64 go build -ldflags="-s -w" -o builds/deploy-darwin-arm64 main.go

echo "建構完成！"
ls -la builds/
```

執行腳本：

```bash
chmod +x build.sh
./build.sh
```

## 使用範例

### 顯示說明資訊

```bash
$ ./deploy --help
Go-Deploy 部署工具

用法: ./deploy [選項]

選項:
  -config string
        設定檔路徑 (default "config.json")
  -help
        顯示說明資訊
  -version
        顯示版本資訊

範例:
  ./deploy                           # 使用預設設定檔 config.json
  ./deploy --config prod.json        # 使用指定設定檔
  ./deploy --config /path/to/config.json  # 使用絕對路徑設定檔
```

### 使用指定設定檔

```bash
$ ./deploy --config prod.json
開始執行部署程式...
嘗試讀取設定檔: /path/to/go-deploy/prod.json
使用設定檔...
本機目錄 /path/to/project/dist 存在
正在連線SSH伺服器...
SSH伺服器連線成功
...
```

### 使用設定檔

```bash
$ ./deploy
開始執行部署程式...
嘗試讀取設定檔: /path/to/go-deploy/config.json
使用設定檔...
本機目錄 /path/to/project/unpackage/dist/build/web 存在
正在連線SSH伺服器...
SSH伺服器連線成功
正在建立SFTP用戶端...
SFTP用戶端建立成功
準備上傳到遠端目錄: /opt/xsoft/nginx/html/app/dist
開始上傳目錄...
開始遍歷本機目錄: /path/to/project/unpackage/dist/build/web
建立目錄: /opt/xsoft/nginx/html/app/dist
檔案 static/js/app.js.map 被排除，跳過上傳
建立備份: /opt/xsoft/nginx/html/app/dist/index.html -> /opt/xsoft/nginx/html/app/dist/index.html.backup
上傳檔案: /path/to/project/unpackage/dist/build/web/index.html -> /opt/xsoft/nginx/html/app/dist/index.html
檔案 .DS_Store 被排除，跳過上傳
上傳檔案: /path/to/project/unpackage/dist/build/web/static/css/app.css -> /opt/xsoft/nginx/html/app/dist/static/css/app.css
上傳失敗 (嘗試 1/3): 網路錯誤
重試上傳檔案 (2/3): /path/to/project/unpackage/dist/build/web/static/js/app.js
上傳檔案: /path/to/project/unpackage/dist/build/web/static/js/app.js -> /opt/xsoft/nginx/html/app/dist/static/js/app.js
...
目錄上傳成功!
統計資訊:
  - 上傳檔案數: 485
  - 建立目錄數: 18
  - 傳輸大小: 25.8 MB
  - 上傳耗時: 38.5s
  - 總耗時: 39.2s
  - 傳輸速度: 0.67 MB/s
```

## 注意事項

1. **安全性**：

   - 生產環境建議使用SSH金鑰認證而非密碼認證
   - 目前使用 `ssh.InsecureIgnoreHostKey()`，生產環境應驗證主機金鑰
2. **網路**：

   - 確保本機可以存取目標伺服器的22埠
   - 傳輸速度取決於網路頻寬和伺服器效能
3. **權限**：

   - 確保SSH使用者對目標目錄有寫入權限
   - 如有需要，可能需使用sudo權限
4. **路徑**：

   - 本機路徑會自動根據執行檔位置計算，無需在意執行目錄
   - 遠端路徑請使用絕對路徑

## 疑難排解

### 常見問題

1. **連線逾時**

   ```
   連線SSH伺服器失敗: dial tcp: i/o timeout
   ```

   - 檢查伺服器位址和埠號
   - 確認網路連通性
   - 檢查防火牆設定
2. **認證失敗**

   ```
   登入失敗: ssh: handshake failed
   ```

   - 檢查使用者名稱與密碼
   - 確認SSH服務已啟動
   - 檢查SSH設定
3. **權限錯誤**

   ```
   建立目錄失敗: permission denied
   ```

   - 檢查使用者對目標目錄的寫入權限
   - 可能需使用sudo或變更目錄擁有者
4. **本機目錄不存在**

   ```
   錯誤: 本機目錄 /path/to/unpackage/dist/build/web 不存在
   ```

   - 確認本地建構已完成
   - 檢查專案目錄結構是否正確
   - 程式會自動計算路徑，無需手動調整工作目錄

## 開發說明

### 專案結構

```
go-deploy/
├── main.go                 # 主程式檔案
├── go.mod                  # Go模組檔案  
├── go.sum                  # 依賴校驗檔案
```
├── README.md               # 詳細說明文件
├── Makefile                # 構建工具
├── build.sh                # 批量打包腳本
├── install.sh              # 一鍵安裝腳本
└── config.example.json     # 配置檔案範例
```

### 主要函式

- `main()` - 主函式，處理連線和調用上傳
- `uploadDirectory()` - 遞迴上傳目錄
- `uploadFile()` - 上傳單一檔案
- `mkdirAll()` - 遞迴建立遠端目錄

## 授權條款

MIT License

## 貢獻

歡迎提交 Issue 和 Pull Request！

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---