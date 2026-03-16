# <p align="center">Fire Tools</p>

[![GitHub Download Stats)](https://img.shields.io/github/downloads/mrhaydendp/Fire-Tools/total?style=for-the-badge)](https://github.com/mrhaydendp/fire-tools/releases/latest/download/Fire-Tools.zip) [![Latest Release](https://img.shields.io/github/v/release/mrhaydendp/Fire-Tools?style=for-the-badge
)](https://github.com/mrhaydendp/fire-tools/releases/latest)

Fire Toolsは、Fireタブレットを高速化し使いやすくするために、不要な機能の削減とGoogleサービスのインストールを支援する強力なツール集です。さらに、Nova、Lawnchair、または任意の`.apk(m)`などのカスタムランチャーをサポートします。複数のアプリを素早くインストールしたい場合は、一括インストーラーがあります。Batchフォルダーにすべての`.apk(m)`を入れて「Batch Install」ボタンをクリックするだけです！ルート不要！

![Fire Tools Screenshot](https://raw.githubusercontent.com/mrhaydendp/Fire-Tools/main/Screenshot.png)

**機能:**
* クロスプラットフォーム（Linux、macOS、Windows）
* 強力な不要機能削減ツール
* Amazonのトラッキングおよび広告を制限
* Google Playインストーラー（Android 8+/Fire OS 7+）
* カスタムランチャーサポート（新しいFire OSバージョンでのLauncherHijack）
* OTAアップデートの無効化
* Apk抽出ツール
* 一括インストーラー（.apkおよび.apkmファイル）
* カスタムDNSセレクター（AdGuard、Cloudflareなど）

**インストール手順（Python）：**

まず[Setup-Instructions.md](/Setup-Instructions.md)に記載された手順に従ってください！その後、インストール手順に進んでください。インストール後は、ツールを更新して最新のスクリプトを取得してください！

**Linux/macOS:**

``` shell
# Download Latest Release & Extract, Then Run
curl -LO https://github.com/mrhaydendp/fire-tools/releases/latest/download/Fire-Tools.zip
unzip Fire-Tools.zip && rm Fire-Tools.zip
cd Fire-Tools
chmod +x Scripts/Posix/*.sh
pip3 install -r requirements.txt
python3 main.py
```

**Windows PowerShell:**

``` powershell
# Download Latest Release & Extract, Then Run
Start-BitsTransfer "https://github.com/mrhaydendp/fire-tools/releases/latest/download/Fire-Tools.zip"
Expand-Archive .\Fire-Tools.zip .\; Remove-Item .\Fire-Tools.zip
Set-Location Fire-Tools
pip install -r requirements.txt
python main.py
```

**重要な注意事項：**

* このプロジェクトは似た目的を持っていますが、Datastream33のAmazon Fire Toolboxとは提携していません。
* Fire OSのアップデートによりFire Toolsの一部機能が動作しなくなることがありますが、できる限り動作を維持するよう努めます。
* デバloatを行う前にタイムゾーン設定をしてください！（日付と時刻の設定を変更するには`com.amazon.kindle.otter.oobe`を再有効化してください）
* Googleアプリは[ApkMirror](https://www.apkmirror.com/)からダウンロードされており、利便性のためリリースに含まれています。[利用規約](https://github.com/mrhaydendp/Fire-Tools/blob/main/Fire-Tools/Gapps/README.md)をご覧ください。APK名と対応するURLはFire-Tools/Gapps/README.mdに記載されています。
* デバloatはほとんどのAmazonアプリを無効化しますが、例外として`Calculator`、`Camera`、`Clock`、`Files`、`Fire Launcher`、`Silk Browser`、`Settings`は対象外です。
* 保証とリセット：Fire Toolsの使用は保証を無効にせず、すべての変更は工場出荷時リセットで元に戻せます。
* 免責事項：このツールは私が開発しましたが、その使用によって生じた問題については責任を負いません。

**クレジット：** Fire Toolsは以下のプロジェクトに感謝し、利便性のために含めています：

* [Google](https://www.android.com/)（GApps）
* [TeslaCoil Software](https://novalauncher.com/)（Nova Launcher）
* [Lawnchair](https://github.com/LawnchairLauncher/Lawnchair)（Lawnchair）
* [BaronKiko](https://github.com/BaronKiko/LauncherHijack)（LauncherHijack）
* [D0k3](https://github.com/d0k3/OneClick-for-Amazon-Fire)（OneClick-for-Amazon-Fireツールに触発）


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-16

---