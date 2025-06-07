# Windows 10 & 11 极速激活：40秒解决方案

[![Readme](https://img.shields.io/badge/README_IN-فارسی-blue?logo=readme)](README-FA.md)  
[![Readme](https://img.shields.io/badge/README_IN-ENGLISH-blue?logo=readme)](README.md)

> 本仓库提供了一种可以在40秒内激活 Windows 10 和 11 的方法。两种方法均兼容家庭版、家庭N版、家庭单语言版、家庭国家专用版、专业版、教育版和企业版的 Windows。

## 方法一（推荐）  
### 使用 PowerShell 即时激活 Windows  
> [!TIP]
> 在 Windows 10 和 11 中有多种方式运行 PowerShell。[1]

打开 PowerShell 的最快方法之一是在开始菜单中搜索。你可以按照以下步骤操作：

<br>

### 第一步  
你只需要点击开始按钮或搜索图标，在搜索框中输入“PowerShell”。  
> 另一种简单方法：[2]

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/5a10538a-c8c2-4934-868b-fd8e910f1f9e" width="540px">
</p>  

---
<br>

### 第二步  
接下来，你需要点击`以管理员身份运行`来启动 PowerShell，这里我们需要以**管理员权限**运行。

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/1f25dd2a-16db-4053-a45c-aac6f8a9e470" width="540px">
</p>

---
<br>

### 第三步  
现在，等待片刻以便执行，请`复制`以下命令：

```CSS
irm https://get.activated.win | iex
```

---
<br>

### 第四步  
现在粘贴（右键粘贴）并按下回车。在新弹出的窗口中，有多个选项，我们需要选择选项`1`，然后等待几秒钟直到完成。

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/0c3689a1-1595-40b3-97e2-041dac423237" width="540px">
</p>

<br>

#### 恭喜，
你的 Windows 已激活。  
现在你可以按回车键退出 CMD，关闭 PowerShell，并检查 Windows 激活菜单[3]

<br><br><br><br><br><br><br><br>

## 方法二  
### 使用 CMD（命令提示符）即时激活 Windows

<br>

> [!NOTE]
> 请确保已**连接**到**互联网**
>
> 不需要使用 VPN

<br>

### 第一步  
首先，点击开始或搜索图标，在搜索框中输入“CMD”。当看到命令提示符选项后，以**管理员**身份运行  
> 其他简单方法：[2]。

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/88ac970a-f24b-4acc-82c0-f8e7c0b05249" width="480px">
</p>  

---
<br>

### 以下为许可密钥列表  

|            **密钥**            |  **版本**   |
| :---------------------------: | :--------: |
| TX9XD-98N7V-6WMQ6-BX7FG-H8Q99 |    家庭版   |
| 3KHY7-WNT83-DGQKR-F7HPR-844BM |   家庭N版   |
| 7HNRX-D7KGG-3K4RQ-4WPJ4-YTDFH |  家庭单语言版[4]  |
| PVMJN-6DFY6–9CCP6–7BKTT-D3WVR |  家庭国家专用版[5]  |
| W269N-WFGWX-YVC9B-4J6C9-T83GX |   专业版    |
| MH37W-N47XK-V7XM9-C7227-GCQG9 | 专业N版    |
| NW6C2-QMPVW-D7KKK-3GKT6-VCFB2 |   教育版    |
| 2WH4N-8QGBV-H22JP-CT43Q-MDWWJ |  教育N版   |
| NPPR9-FWDCX-D2C8J-H872K-2YT43 |   企业版    |
| DPH2V-TTNVB-4X9Q3-TJR4H-KHJW4 |  企业N版   |

![rainbow](https://github.com/NiREvil/vless/assets/126243832/1aca7f5d-6495-44b7-aced-072bae52f256)

<br>

### 第二步  
安装 KMS 客户端密钥。

使用以下命令：

```CSS
slmgr /ipk yourlicensekey
```

> [!NOTE]
> 请从上方列表中选择与你的 Windows 版本**相匹配的密钥**，并替换命令中的 `yourlicencekey`。

> [!TIP]
> 如何查看 Windows 版本[3]。

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/1b6401e6-7e63-4351-8a92-fa355dfc30cf" width="480px">
</p>  

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/90037069-7ea3-44a8-a9fa-e296f5e8d47b" width="340px">
</p>  

---
<br>

### 第三步  
设置 KMS 服务器地址。

使用命令：

```CSS
slmgr /skms kms8.msguides.com
```

以连接到我的 KMS 服务器。

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/9d634454-1c59-47da-874e-bfe575288fe6" width="480px">
</p>  

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/2d2e6cfb-4e85-483f-ae0a-c7157d22da36" width="340px">
</p>  

---  
<br>

### 第四步  
激活你的 Windows。
最后一步，使用以下命令激活你的 Windows：

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

### 第五步  
现在再次检查激活状态[6]。

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/9ca70137-8e2e-4504-a52d-22f41d959bd7" width="480px">
</p>

#### 完成 ✅  
你的 Windows 已成功激活。

<br>

**保持好奇 🤍**

[![Telegram](https://img.shields.io/badge/TELEGRAM-blue.svg?logo=telegram)](https://t.me/F_NiREvil) [![Twitter](https://img.shields.io/badge/TWITTER-blue.svg?logo=x)](https://twitter.com/NiREvil_)

<picture>
  <source media="(prefers-color-scheme: dark)" srcset="https://user-images.githubusercontent.com/25423296/163456776-7f95b81a-f1ed-45f7-b7ab-8fa810d529fa.png">
  <source media="(prefers-color-scheme: light)" srcset="https://user-images.githubusercontent.com/25423296/163456779-a8556205-d0a5-45e2-ac17-42d089e3c3f8.png">
  <img alt="Shows an illustrated sun in light mode and a moon with stars in dark mode." src="https://user-images.githubusercontent.com/25423296/163456779-a8556205-d0a5-45e2-ac17-42d089e3c3f8.png">
</picture>

<br>

[1]: [10种在Windows中运行PowerShell的方法](https://www.google.com/amp/s/www.minitool.com/news/open-windows-11-powershell.html%3famp)

[2]: 运行PowerShell的另一种最简单方法：**右键**点击开始菜单，弹出快捷菜单后，在Win11中选择**Windows Terminal（管理员）**，在Win10中选择**Windows PowerShell（管理员）**。

[3]: 查看Windows版本：**右键**点击开始菜单，选择**系统**选项。你的 Windows 版本可以在第二部分**版本**下方看到。你也可以参考方法二的步骤进行**复制粘贴**操作。复制命令后，在**cmd或powershell**中**右键**粘贴。

[4]: 家庭单语言版。

[5]: 家庭国家专用版。

[6]: 查看Windows激活状态的方法：  
***设置 → 更新与安全 → 激活菜单***

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx) - 2025-06-07

---