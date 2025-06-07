## FanImeTsf

這是 [FanImeServer](https://github.com/fanlumaster/FanImeServer) 的 TSF 端。

注意：目前僅支援 64 位元應用程式。

## 如何建置

### 先決條件

- Visual Studio 2022
- CMake
- vcpkg
- Python3
- gsudo

請確保 vcpkg 和 gsudo 已經透過 **Scoop** 安裝。

## 建置步驟

### 建置

首先，克隆此儲存庫，

```powershell
git clone --recursive https://github.com/fanlumaster/FanImeTsf.git
```

然後，準備環境，

```powershell
cd FanImeTsf
python .\scripts\prepare_env.py
```

接著，進行建置，

```powershell
.\scripts\lcompile.ps1
```

### 安裝

以系統管理員身份啟動 powershell，並確保已啟用系統 `Enable sudo` 選項。

![](https://i.postimg.cc/zJCn9Cnn/image.png)

然後，在 `C:\Program Files\` 下建立一個名為 `FanImeTsf` 的資料夾，並將 `FanImeTsf.dll` 複製到其中，

```powershell
gsudo
Copy-Item -Path ".\FanImeTsf\build64\Debug\FanImeTsf.dll" -Destination "C:\Program Files\FanImeTsf"
```

接著，安裝它，

```powershell
cd "C:\Program Files\FanImeTsf"
sudo regsvr32 .\FanImeTsf.dll
```

### 移除安裝

```powershell
cd "C:\Program Files\FanImeTsf"
sudo regsvr32 /u .\FanImeTsf.dll
```

## 截圖

![](https://i.postimg.cc/v8Bpx6Gf/image.png)

![](https://i.postimg.cc/ssBgtM5M/image.png)

![](https://i.postimg.cc/ryDqXH0B/image.png)

![](https://i.postimg.cc/2m9WJTgR/image.png)

![](https://i.postimg.cc/L96qQZT8/image.png)

![](https://i.postimg.cc/FNcz9QTv/image.png)

## 開發路線圖

目前僅支援小鶴雙拼。

### 中文

- 小鶴雙拼
- 全拼
- 漢字部件輔助碼
- 可自訂詞庫
- 自訂輸入法引擎
- 自訂皮膚
- 簡繁體切換
- 英文自動補全
- 開源雲端輸入法 API
- 候選視窗 UI 可切換直式/橫式模式
- 功能開關：大多數功能應可由使用者自由開關與自訂

### 日文支援

可能會是另一個專案。

也有可能支援其他語言。

### 參考資料

- [MS-TSF-IME-Demo](https://github.com/microsoft/Windows-classic-samples/tree/main/Samples/IME/cpp/SampleIME)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---