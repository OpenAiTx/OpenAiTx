## FanImeTsf

これは [FanImeServer](https://github.com/fanlumaster/FanImeServer) のTSFエンドです。

注意: 現在、64ビットアプリのみサポートしています。

## ビルド方法

### 前提条件

- Visual Studio 2022
- CMake
- vcpkg
- Python3
- gsudo

vcpkgとgsudoは**Scoop**でインストールされていることを確認してください。

## ビルド手順

### ビルド

まず、リポジトリをクローンします。

```powershell
git clone --recursive https://github.com/fanlumaster/FanImeTsf.git
```

次に、環境を準備します。

```powershell
cd FanImeTsf
python .\scripts\prepare_env.py
```

その後、ビルドします。

```powershell
.\scripts\lcompile.ps1
```

### インストール

PowerShellを管理者権限で起動し、システムの `Enable sudo` オプションが有効になっていることを確認してください。

![](https://i.postimg.cc/zJCn9Cnn/image.png)

次に、`C:\Program Files\` に `FanImeTsf` というフォルダーを作成し、`FanImeTsf.dll` をそこにコピーします。

```powershell
gsudo
Copy-Item -Path ".\FanImeTsf\build64\Debug\FanImeTsf.dll" -Destination "C:\Program Files\FanImeTsf"
```

次に、インストールします。

```powershell
cd "C:\Program Files\FanImeTsf"
sudo regsvr32 .\FanImeTsf.dll
```

### アンインストール

```powershell
cd "C:\Program Files\FanImeTsf"
sudo regsvr32 /u .\FanImeTsf.dll
```

## スクリーンショット

![](https://i.postimg.cc/v8Bpx6Gf/image.png)

![](https://i.postimg.cc/ssBgtM5M/image.png)

![](https://i.postimg.cc/ryDqXH0B/image.png)

![](https://i.postimg.cc/2m9WJTgR/image.png)

![](https://i.postimg.cc/L96qQZT8/image.png)

![](https://i.postimg.cc/FNcz9QTv/image.png)

## ロードマップ

現在は小鶴双拼のみサポートしています。

### 中国語

- 小鶴双拼
- 全拼
- 漢字部首の利用時の補助コード
- カスタマイズ可能な辞書
- カスタマイズ可能なIMEエンジン
- カスタマイズ可能なスキン
- 簡体字と繁体字の切り替え
- 英語のオートコンプリート
- オープンソースのクラウドIME API
- 候補ウィンドウUIの縦型/横型切替
- 機能スイッチ: ほとんどの機能はユーザーが自由に切替・カスタマイズ可能

### 日本語サポート

別プロジェクトになるかもしれません。

他の言語サポートも検討中です。

### 参考

- [MS-TSF-IME-Demo](https://github.com/microsoft/Windows-classic-samples/tree/main/Samples/IME/cpp/SampleIME)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---