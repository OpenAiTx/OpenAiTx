# eBAF - 基於 eBPF 的廣告防火牆
<p align="center">
    <img src="https://raw.githubusercontent.com/Kazedaa/eBAF/main/assets/banner.png" alt="eBAF - eBPF Ad Firewall Banner" width="600"/>
</p>

## 「你不會下載廣告」
### 但你會封鎖廣告！

Spotify 建立了一個簡單的帝國公式：將你的注意力變現、付給藝術家過低的報酬，然後把你的時間當作高級功能再賣回給你。
在他們的世界裡，你的聆聽體驗並不屬於你。這是一個精心策劃的市場——你的耳朵是產品，你的耐心是貨幣。

他們喜歡稱這為「免費」方案。
但說實話：如果你用時間來付費，那就不是免費的。

同時，你所喜愛的藝術家——那些讓平台得以存活的人——每次播放通常只能賺到幾分之一分錢。Spotify 獲取巨額利潤，廣告主獲得曝光，而創作者呢？他們只分到殘羹剩飯。

這不僅僅是跳過幾個惱人的廣告。
這是拒絕參與一個從剝削、分心及將你注意力商品化中獲利的系統。

#### 這是什麼？
一個優雅的小小數位抵抗行動：一個乾淨、開源的 Spotify 廣告攔截器，真正讓噪音止步——字面上的安靜。

沒有可疑的修改版、沒有破解客戶端、沒有偽裝成自由的惡意軟體。只有一個目標：讓音樂播放不再被廣告綁架。

Spotify 並非免費——你用耐心付費。

他們用同樣刺耳的廣告一遍又一遍轟炸你，直到你放棄並訂閱。不是因為你熱愛 Premium，而是因為你被磨損了。這不是 freemium——這是用播放清單進行的心理戰。

同時，藝術家呢？依然被低薪對待。
廣告呢？更大聲、更頻繁。有時甚至真的更吵。
你呢？只想好好享受音樂。

他們從你的耐心和對創作者的低酬勞中獲利，還假裝這是唯一可持續的方式。劇透：不是。他們有選擇——但他們選擇了利潤高於人。

Spotify 想讓你相信這就是取得音樂的代價。
我們相信這是謊言。

我們不是盜版者。我們不是罪犯。我們只是一群認為劃下界線也無妨的人。

這個專案的目的不是跳過幾個廣告，而是拒絕一個認為你的沉默可以被販賣、你的體驗可以被打斷、你的價值只有當你掏錢時才開始的系統。

封鎖廣告不是偷竊。<br>
偷走你時間才是。<br>
我們不是來盜版，我們是來退出這套遊戲的。<br>
<br>
**你不會下載一個廣告，但你會封鎖一個。**
## eBAF 如何運作？

eBAF（eBPF 廣告防火牆）利用 eBPF（Extended Berkeley Packet Filter，擴展伯克利封包過濾器）的強大功能，在核心層級封鎖不需要的廣告。以下是其功能的高階概述：

## eBAF 如何運作？

eBAF（eBPF 廣告防火牆）利用 eBPF（擴展伯克利封包過濾器）在核心層級高效封鎖廣告。以下是簡化的運作流程：

1. **封包過濾**：
   - 檢查進入的網路封包，並使用 XDP（eXpress Data Path）封鎖符合黑名單 IP 位址的封包。

2. **動態更新**：
   - 將網域名稱解析為 IP 位址，並動態更新黑名單，以因應廣告伺服器的變動。

3. **網頁儀表板**：
   - 透過使用者友善的介面，提供即時統計與監控。

4. **高效能**：
   - 直接在網路介面層運作，繞過核心的網路堆疊，以更快的處理速度和最小的資源消耗運行。

eBAF 結合了高效能、透明性與易用性，提供強大的廣告封鎖解決方案。
## 簡易安裝（推薦）
請確保已安裝 git 和 curl
```bash
git --version
curl --version
```
### 安裝
#### 啟用 Spotify 整合（推薦）
```bash
EBAF_ENABLE_SPOTIFY=yes curl -sSL https://github.com/Kazedaa/eBAF/raw/main/install.sh | sudo -E bash
```
#### 明確停用
```bash
EBAF_ENABLE_SPOTIFY=no curl -sSL https://github.com/Kazedaa/eBAF/raw/main/install.sh | sudo bash
```

### 卸載
```bash
curl -sSL https://raw.githubusercontent.com/Kazedaa/eBAF/main/uninstall.sh | sudo bash
```
## 開發安裝
執行以下指令以安裝所需的依賴套件：
### Ubuntu/Debian
```bash
sudo apt-get update
sudo apt-get install libbpf-dev clang llvm libelf-dev zlib1g-dev gcc make python3

sudo apt update
sudo apt install net-tools
```

### Fedora/CentOS/RHEL 8+
```bash
sudo dnf update
sudo dnf install -y libbpf-devel clang llvm elfutils-libelf-devel zlib-devel gcc make python3 net-tools bc
```

### Arch
```bash
sudo pacman -Syu
sudo pacman -S --needed libbpf clang llvm libelf zlib gcc make python net-tools bc
```

### 修復執行 eBPF 程式碼時的 asm/types.h 錯誤
檢查當前的連結
`ls -l /usr/include/asm`
找到正確的連結
`find /usr/include -name "types.h" | grep asm`
修正符號連結
```bash
sudo rm /usr/include/asm
sudo ln -s <current_link> /usr/include/asm
```

### 建置專案

要建置 eBPF Adblocker，請按照以下步驟操作：

1. 複製儲存庫：
   ```bash
   git clone <repository-url>
   cd eBAF
   ```
2. 建置專案：
   ```bash
   make
   ```

3. （可選）系統範圍安裝：
   ```bash
   sudo make install
   ```

4. 其他安裝選項（說明檔）
    ```bash
    make help
    ````
5. 解除安裝
    ```bash
    make uninstall
    ````
## 使用方法

### 運行廣告攔截器
    預設使用 spotify-stable.txt 作為黑名單。
    用法：ebaf [選項] [網路介面...]
    選項：
    -a, --all               在所有啟用的網路介面上運行
    -d, --default           僅在預設（有網際網路存取）網路介面上運行
    -i, --interface IFACE   指定要使用的網路介面
    -D, --dash              啟動網頁儀表板 (http://localhost:8080)
    -q, --quiet             隱藏輸出（安靜模式）
    -h, --help              顯示此說明訊息


### 設定黑名單
編輯清單以新增或移除網域。每個網域應單獨一行。註解以 `#` 開頭。

## 致謝

特別感謝 ❤️ <br>
1. [Isaaker's Spotify-AdsList](https://github.com/Isaaker/Spotify-AdsList/tree/main) <br>
2. [AnanthVivekanand's spotify-adblock](https://github.com/AnanthVivekanand/spotify-adblock)

提供 Spotify 封鎖清單
## ⭐️ 支持此專案

如果您覺得 eBAF 有用，請考慮在 GitHub 上為此儲存庫加星！您的支持有助於提升能見度並鼓勵進一步的開發。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-11

---