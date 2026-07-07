<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=zh-CN">簡體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# 🎯 MT7902 驅動程式作為 MT7921 驅動程式的子部件（✅ 可運作）
Mediatek mt7902 wifi 6E 晶片藍牙與 WiFi 支援

> [!IMPORTANT]
> Linux 7.1 核心已正式支援 MT7902 WIFI 6E 晶片


## 📁 複製存儲庫

將存儲庫克隆到您的本地電腦
  ```
  git clone https://github.com/OnlineLearningTutorials/mt7902_temp
  ```
如果您不想複製過去的歷史，
  ```
  git clone --depth 1 https://github.com/OnlineLearningTutorials/mt7902_temp
  ```

## 安裝


### 🚀 安裝指南腳本（建議用於基於 Ubuntu 的系統）
如果尚未執行，請將腳本設為可執行
```
chmod +x ./install_guide.sh
```
現在執行此腳本
```
./install_guide.sh
```
當需要時它會自動提示輸入密碼
* 此腳本會依序詢問您安裝韌體、藍牙和無線網路驅動程式
* 已在 Ubuntu 使用 linux 7.0 核心測試

### 🚀 簡易自動修復（建議用於基於 Arch 的系統）
如果您想要在任何現代核心上快速修復您的 WiFi 和藍牙，請按照以下步驟操作：

如果腳本尚未可執行，請將其設為可執行
```
chmod +x ./fix_my_wifi.sh
```

**以 sudo 執行自動修復腳本**：
```bash
sudo bash fix_my_wifi.sh
```

#### 📖 此腳本的功能：
* **檢查相依套件：** 確保你已安裝 `gcc`/`clang`、`make`、`bc` 和你目前的 `kernel-headers`。若尚未安裝，會使用你偏好的套件管理器自動安裝。
* **編譯驅動程式：** 自動為你目前的核心版本編譯 WiFi 與藍牙驅動程式。
* **持久修復：** 安裝一個系統服務，確保 WiFi 即使在重啟電腦後仍能保持啟動狀態。
* **安全性：** 將模組安裝至自訂目錄 (`/lib/modules/mt7902_custom`)，避免影響預設的系統檔案。

> [!NOTE]
> 第一次執行時，你需要有網際網路連線（透過乙太網路或手機的 USB 網路分享），以便下載必要的建置工具（如編譯器、linux-headers 等）。

## ✅ 已測試系統（確認可用）
此修復已驗證並確認可在下列系統上運作：

* **品牌：** ASUS
* **型號：** Vivobook Go (E1404FA)、Vivobook 14 (X1404ZA)
* **晶片組：** MediaTek MT7902（WiFi 6E）
* **核心版本：** 6.19.0（Linux）、6.19.11、7.0.7
* **作業系統：** Arch、Ubuntu
* **套件管理器：** pacman、apt

## 適用於：
* **作業系統：** 支援任一套件管理器的作業系統
* **偏好套件管理器：** apt、pacman、dnf、zypper、nix-shell
* **核心版本：** 6.14-7.0.7

## 🔧 使用的韌體
韌體儲存在 `firmware` 資料夾中。

## 📱 藍牙 ✅（正常運作）
> [!WARNING]
> 如果藍牙驅動程式與 `gen4-mt7902` 衝突，請移除藍牙韌體以避免影響此驅動程式
> ``` sudo rm /lib/firmware/mediatek/mt7902/BT_RAM_CODE_MT7902_1_1_hdr.bin.zst ```
> 本專案使用的韌體為
> ``` /lib/firmware/mediatek/BT_RAM_CODE_MT7902_1_1_hdr.bin.zst ```

若要啟用藍牙，請前往你目前核心版本的目錄。``
例如若你使用的核心為 linux-6.16，請進入目錄 `./linux-6.16/drivers/bluetooth` 。



在此目錄中開啟終端機，並使用指令 `make` 進行編譯。
將會編譯出兩個核心模組 `btusb.ko` 和 `btmtk.ko`。
若要在您的裝置啟用藍牙，請移除系統中的 btusb 和 btmtk，並安裝這兩個檔案，使用以下指令
```
sudo rmmod btusb 
sudo rmmod btmtk

sudo insmod btmtk.ko
sudo insmod btusb.ko

```
現在檢查你的藍牙是否正常運作。

## 💻 WiFi ✅（可運作）
> [!IMPORTANT]
> 一個可用但有些限制的專案在[這裡](https://github.com/hmtheboy154/gen4-mt7902)

mt7902 的 WiFi 驅動程式（由聯發科最近釋出）位於 `latest` 資料夾內。

如果你正在使用 Ubuntu，只需進入 `latest` 資料夾並在終端機執行下列指令。
```
make
```
它會編譯所有模組，壓縮並安裝它（用修改過的模組替換原始核心模組）。如果你使用其他發行版或不想執行所有步驟，只想編譯程式碼，那麼請在終端機中執行

```
make module_compile
```
要壓縮你編譯的模組，然後在終端機運行
```
make module_compress
```
要將壓縮模組安裝到系統的核心模組中，請在終端機中執行
```
make module_install
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-07

---