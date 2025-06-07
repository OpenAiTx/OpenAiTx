# Windows 10 & 11 即時アクティベーション：40秒で完了する方法

[![Readme](https://img.shields.io/badge/README_IN-فارسی-blue?logo=readme)](README-FA.md)  
[![Readme](https://img.shields.io/badge/README_IN-ENGLISH-blue?logo=readme)](README.md)

> このリポジトリには、Windows 10 および 11 を40秒以内にアクティベートできる方法が含まれています。どちらの方法も、Home、Home N、Home Single Lang、Home Country Specific、Professional、Education、Enterprise の各バージョンに対応しています。

## 方法1（推奨）  
### PowerShell を使った即時 Windows アクティベーション  
> [!TIP]
> Windows 10 & 11 で PowerShell を起動する方法は多数あります。[ ^1 ]

Windows で PowerShell を開く最速の方法の一つはスタートメニュー検索です。以下の手順に従ってください：

<br>

### ステップ1  
スタートまたは検索アイコンをクリックし、検索ボックスに「PowerShell」と入力してください。  
> 別の簡単な方法: [^2]

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/5a10538a-c8c2-4934-868b-fd8e910f1f9e" width="540px">
</p>  

---
<br>

### ステップ2  
次に、`管理者として実行` をクリックして PowerShell を起動します。この場合、**管理者権限**で実行する必要があります。

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/1f25dd2a-16db-4053-a45c-aac6f8a9e470" width="540px">
</p>

---
<br>

### ステップ3  
しばらく実行を待った後、次の行を `コピー` してください：

```CSS
irm https://get.activated.win | iex
```

---
<br>

### ステップ4  
右クリックで貼り付けて、Enter キーを押します。新しく開いたウィンドウにはいくつかのオプションが表示されるので、その中からオプション `1` を選択し、数秒間お待ちください。

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/0c3689a1-1595-40b3-97e2-041dac423237" width="540px">
</p>

<br>

#### おめでとうございます、
Windows がアクティベートされました。  
Enter キーを押して CMD を終了し、PowerShell を閉じ、Windows のアクティベーションメニューを確認してください [^3]。

<br><br><br><br><br><br><br><br>

## 方法2  
### CMD（コマンドプロンプト）を使った即時 Windows アクティベーション

<br>

> [!NOTE]
> **インターネット** に**接続**していることを確認してください
>
> VPNは**不要**です

<br>

### ステップ1  
まず、スタートまたは検索アイコンをクリックし、検索ボックスに「CMD」と入力します。コマンドプロンプトのオプションが表示されたら、**管理者として実行**してください。  
> 他にも簡単な方法があります: [^2]。

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/88ac970a-f24b-4acc-82c0-f8e7c0b05249" width="480px">
</p>  

---
<br>

### 以下はライセンスキーの一覧です

|            **Key**            |  **Version**   |
| :---------------------------: | :------------: |
| TX9XD-98N7V-6WMQ6-BX7FG-H8Q99 |      Home      |
| 3KHY7-WNT83-DGQKR-F7HPR-844BM |     Home N     |
| 7HNRX-D7KGG-3K4RQ-4WPJ4-YTDFH |  Home sl [^4]  |
| PVMJN-6DFY6–9CCP6–7BKTT-D3WVR |  Home cs [^5]  |
| W269N-WFGWX-YVC9B-4J6C9-T83GX |  Professional  |
| MH37W-N47XK-V7XM9-C7227-GCQG9 | Professional N |
| NW6C2-QMPVW-D7KKK-3GKT6-VCFB2 |   Education    |
| 2WH4N-8QGBV-H22JP-CT43Q-MDWWJ |  Education N   |
| NPPR9-FWDCX-D2C8J-H872K-2YT43 |   Enterprise   |
| DPH2V-TTNVB-4X9Q3-TJR4H-KHJW4 |  Enterprise N  |

![rainbow](https://github.com/NiREvil/vless/assets/126243832/1aca7f5d-6495-44b7-aced-072bae52f256)

<br>

### ステップ2  
KMS クライアントキーをインストールします。

次のコマンドを使用してください：

```CSS
slmgr /ipk yourlicensekey
```

> [!NOTE]
> **Windows のバージョン**に**一致する**ライセンスキーを一覧から一つ選び、コマンド内の `yourlicencekey` 部分に置き換えてください。

> [!TIP]
> Windows のバージョン確認方法 [^3]。

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/1b6401e6-7e63-4351-8a92-fa355dfc30cf" width="480px">
</p>  

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/90037069-7ea3-44a8-a9fa-e296f5e8d47b" width="340px">
</p>  

---
<br>

### ステップ3  
KMS サーバーアドレスを設定します。

次のコマンドを使用してください：

```CSS
slmgr /skms kms8.msguides.com
```

このコマンドで KMS サーバーに接続します。

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/9d634454-1c59-47da-874e-bfe575288fe6" width="480px">
</p>  

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/2d2e6cfb-4e85-483f-ae0a-c7157d22da36" width="340px">
</p>  

---  
<br>

### ステップ4  
Windows をアクティベートします。
最後のステップは、次のコマンドで Windows をアクティベートすることです：

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

### ステップ5  
再度アクティベーション状態を確認してください [^6]。

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/9ca70137-8e2e-4504-a52d-22f41d959bd7" width="480px">
</p>

#### 完了 ✅  
Windows のアクティベーションに成功しました。

<br>

**好奇心を持ちましょう 🤍**

[![Telegram](https://img.shields.io/badge/TELEGRAM-blue.svg?logo=telegram)](https://t.me/F_NiREvil) [![Twitter](https://img.shields.io/badge/TWITTER-blue.svg?logo=x)](https://twitter.com/NiREvil_)

<picture>
  <source media="(prefers-color-scheme: dark)" srcset="https://user-images.githubusercontent.com/25423296/163456776-7f95b81a-f1ed-45f7-b7ab-8fa810d529fa.png">
  <source media="(prefers-color-scheme: light)" srcset="https://user-images.githubusercontent.com/25423296/163456779-a8556205-d0a5-45e2-ac17-42d089e3c3f8.png">
  <img alt="Shows an illustrated sun in light mode and a moon with stars in dark mode." src="https://user-images.githubusercontent.com/25423296/163456779-a8556205-d0a5-45e2-ac17-42d089e3c3f8.png">
</picture>

<br>

[^1]: [Windows で PowerShell を起動する10の方法](https://www.google.com/amp/s/www.minitool.com/news/open-windows-11-powershell.html%3famp)  

[^2]: PowerShell を起動する他の簡単な方法: スタートメニューを**右クリック**してクイックリンクメニューを開き、Windows 11 では **Windows Terminal (管理者)**、Windows 10 では **Windows powershell (管理者)** を選択します。
[^3]: Windows のバージョン確認方法: スタートメニューを**右クリック**し、**システム**を選択します。Windows のバージョンは **エディション** セクションの2番目に表示されます。または方法2の手順をコピペして実行することもできます。コマンドをコピーし、**cmdやpowershell**で**右クリック**して貼り付けます。
[^4]: Home Single Language バージョン。
[^5]: Home Country Specific バージョン。
[^6]: Windows のアクティベーション状態を確認するには：  
***設定 → 更新とセキュリティ → アクティベーション メニュー。***

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx) - 2025-06-07

---