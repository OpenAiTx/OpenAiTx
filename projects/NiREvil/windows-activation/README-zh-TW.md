# Windows 10 & 11 即時啟用：40 秒解決方案

[![Readme](https://img.shields.io/badge/README_IN-فارسی-blue?logo=readme)](README-FA.md)  
[![Readme](https://img.shields.io/badge/README_IN-ENGLISH-blue?logo=readme)](README.md)

> 本儲存庫提供一種能在 40 秒內啟用 Windows 10 和 11 的方法。兩種方法皆相容於 Windows 的家庭版、家庭 N、家庭單一語言版、家庭特定國家版、專業版、教育版及企業版。

## 方法一（推薦）  
### 使用 PowerShell 即時啟用 Windows  
> [!TIP]
> Windows 10 & 11 有許多方式可啟動 PowerShell。[1]

在 Windows 中最快啟動 PowerShell 的方式之一是透過「開始」選單搜尋。請依照以下步驟操作：

<br>

### 步驟 1  
只需點擊開始或搜尋圖示，在搜尋欄輸入「PowerShell」。  
> 另一簡單方法：[2]

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/5a10538a-c8c2-4934-868b-fd8e910f1f9e" width="540px">
</p>  

---
<br>

### 步驟 2  
接著，請點擊 `以系統管理員身分執行` 來啟動 PowerShell，本操作需**以管理員權限**執行。

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/1f25dd2a-16db-4053-a45c-aac6f8a9e470" width="540px">
</p>

---
<br>

### 步驟 3  
現在，稍等片刻以執行，然後請「複製」以下這行指令：

```CSS
irm https://get.activated.win | iex
```

---
<br>

### 步驟 4  
現在將其貼上（右鍵貼上），然後按下 Enter 鍵。在新開啟的視窗中，會有幾個選項，請選擇選項 `1`，並等待幾秒鐘完成。

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/0c3689a1-1595-40b3-97e2-041dac423237" width="540px">
</p>

<br>

#### 恭喜您，
您的 Windows 已成功啟用。  
現在您可以按 Enter 鍵離開 CMD 並關閉 PowerShell，並於 Windows 啟用選單中檢查授權狀態 [3]

<br><br><br><br><br><br><br><br>

## 方法二  
### 使用 CMD（命令提示字元）即時啟用 Windows

<br>

> [!NOTE]
> 請記得**連接至網際網路**
>
> 無需 VPN

<br>

### 步驟 1  
首先，點擊開始或搜尋圖示，於搜尋欄輸入「CMD」。在看到命令提示字元選項後，以**系統管理員**身分執行  
> 其他簡單方法：[2]

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/88ac970a-f24b-4acc-82c0-f8e7c0b05249" width="480px">
</p>  

---
<br>

### 以下為授權金鑰清單  

|            **金鑰**            |  **版本**   |
| :---------------------------: | :---------: |
| TX9XD-98N7V-6WMQ6-BX7FG-H8Q99 |   家庭版    |
| 3KHY7-WNT83-DGQKR-F7HPR-844BM |  家庭 N    |
| 7HNRX-D7KGG-3K4RQ-4WPJ4-YTDFH |  家庭單一語言版 [4]  |
| PVMJN-6DFY6–9CCP6–7BKTT-D3WVR |  家庭特定國家版 [5]  |
| W269N-WFGWX-YVC9B-4J6C9-T83GX |  專業版    |
| MH37W-N47XK-V7XM9-C7227-GCQG9 | 專業 N     |
| NW6C2-QMPVW-D7KKK-3GKT6-VCFB2 |  教育版    |
| 2WH4N-8QGBV-H22JP-CT43Q-MDWWJ | 教育 N     |
| NPPR9-FWDCX-D2C8J-H872K-2YT43 |  企業版    |
| DPH2V-TTNVB-4X9Q3-TJR4H-KHJW4 | 企業 N     |

![rainbow](https://github.com/NiREvil/vless/assets/126243832/1aca7f5d-6495-44b7-aced-072bae52f256)

<br>

### 步驟 2  
安裝 KMS 用戶端金鑰。

請使用以下指令：

```CSS
slmgr /ipk yourlicensekey
```

> [!NOTE]
> 請從上方清單選擇**與您的 Windows 版本相符的授權金鑰**，並將指令中的 `yourlicencekey` 替換成該金鑰。

> [!TIP]
> 如何查詢 Windows 版本 [3]。

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/1b6401e6-7e63-4351-8a92-fa355dfc30cf" width="480px">
</p>  

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/90037069-7ea3-44a8-a9fa-e296f5e8d47b" width="340px">
</p>  

---
<br>

### 步驟 3  
設定 KMS 主機位址。

請使用下列指令：

```CSS
slmgr /skms kms8.msguides.com
```

以連線至我的 KMS 伺服器。

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/9d634454-1c59-47da-874e-bfe575288fe6" width="480px">
</p>  

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/2d2e6cfb-4e85-483f-ae0a-c7157d22da36" width="340px">
</p>  

---  
<br>

### 步驟 4  
啟用您的 Windows。  
最後一步，請使用以下指令啟用您的 Windows：

```CSS
slmgr /ato
```

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/5e495d42-6ce5-4884-9de2-96a56efb4343" width="480px">
</p>  

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/aecd9cfd-8c09-4433-b410-a62205a8d692" width="240px">
</p>  

---
<br>

### 步驟 5  
現在再次檢查啟用狀態 [6]。

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/9ca70137-8e2e-4504-a52d-22f41d959bd7" width="480px">
</p>

#### 完成 ✅  
您的 Windows 已成功啟用。

<br>

**保持好奇 🤍**

[![Telegram](https://img.shields.io/badge/TELEGRAM-blue.svg?logo=telegram)](https://t.me/F_NiREvil) [![Twitter](https://img.shields.io/badge/TWITTER-blue.svg?logo=x)](https://twitter.com/NiREvil_)

<picture>
  <source media="(prefers-color-scheme: dark)" srcset="https://user-images.githubusercontent.com/25423296/163456776-7f95b81a-f1ed-45f7-b7ab-8fa810d529fa.png">
  <source media="(prefers-color-scheme: light)" srcset="https://user-images.githubusercontent.com/25423296/163456779-a8556205-d0a5-45e2-ac17-42d089e3c3f8.png">
  <img alt="Shows an illustrated sun in light mode and a moon with stars in dark mode." src="https://user-images.githubusercontent.com/25423296/163456779-a8556205-d0a5-45e2-ac17-42d089e3c3f8.png">
</picture>

<br>

[^1]: [10 種在 Windows 執行 PowerShell 的方法](https://www.google.com/amp/s/www.minitool.com/news/open-windows-11-powershell.html%3famp)  

[^2]: 另一個執行 PowerShell 的最簡單方法：**右鍵點擊**開始選單，觸發快速連結選單，然後在 Windows 11 選擇 **Windows 終端機（管理員）**，或在 Windows 10 選擇 **Windows PowerShell（管理員）**。
[^3]: 查詢 Windows 版本：**右鍵點擊**開始選單，選擇 **系統** 選項。您的 Windows 版本可於第二段 **版本** 看到。亦可依照方法二的步驟**複製貼上**指令，在 **cmd 或 powershell** 內按 **右鍵** 貼上。
[^4]: 家庭單一語言版本。
[^5]: 家庭特定國家版本。
[^6]: 檢視 Windows 啟用狀態請前往：  
***設定 → 更新與安全性 → 啟用選單。***

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx) - 2025-06-07

---