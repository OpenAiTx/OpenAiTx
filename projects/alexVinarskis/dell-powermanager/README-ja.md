[![Build](https://github.com/alexVinarskis/dell-powermanager/actions/workflows/build.yml/badge.svg?branch=master)](https://github.com/alexVinarskis/dell-powermanager/actions/workflows/build.yml)
[![GitHub release (with filter)](https://img.shields.io/github/v/release/alexVinarskis/dell-powermanager?label=Release)](https://github.com/alexVinarskis/dell-powermanager/releases/latest)
![GitHub all releases](https://img.shields.io/github/downloads/alexVinarskis/dell-powermanager/total?label=Downloads)

# Dell Power Manager
Flutterで再実装されたクロスプラットフォーム対応のDell Power Manager。スクリーンショットは[Wiki](https://github.com/alexVinarskis/dell-powermanager/wiki)に多数掲載。

![Screenshot Summary](https://raw.githubusercontent.com/alexVinarskis/dell-powermanager/master/images/screenshot_summary.png)

## なぜ
Dellのマシン（XPSやPrecisionシリーズのノートパソコン、その他の可能性あり）は、複数のサーマルプロファイルやバッテリー充電閾値など、BIOS内で高度に設定可能なオプションを提供しています。これらを外出先で調整したい場合が多いですが、Dellの専用ツール（幸い提供されています）以外にOSから設定する方法はありません。設定変更方法は以下の通りです：
* BIOS直接、再起動が必要
* WindowsおよびLinux対応の[ Dell Command | Configure](https://www.dell.com/support/kbdoc/en-us/000178000/dell-command-configure) CLI、印象的な[機能一覧](https://dl.dell.com/topicspdf/command-configure_reference-guide4_en-us.pdf)があります。
* Windows専用の[ Dell Power Manager](https://www.dell.com/support/contents/en-au/article/product-support/self-support-knowledgebase/software-and-downloads/dell-power-manager) GUI。加えて、起動が非常に遅く、（主観的に）見た目が良くありません。

本アプリはDell Command | Configure CLIをベースにしたモダンなFlutter GUIで、主な目的はLinuxユーザー向けにDell Power Managerの動作を再現することですが、Windowsでも動作します。

## 機能
* 'Dell Command | Configure CLI'（CCTK）による制御を実装
* モダンでアニメーション対応のUI、ダークモード対応
* 起動時間が短く、DellのWindowsアプリよりはるかに高速
* 対応機種でサポートされていないモードを検出・処理
* Dell製でない機種を検出し、エラーメッセージを表示
* 保護されたBIOS（システム/セットアップ/オーナーパスワード）および安全なキー保存に対応

Debian/Ubuntu系LinuxおよびWindows向けには、アプリはやや製品化されています：
* 依存関係のダウンロードとインストールを統合
* `.deb`/`.msi`パッケージ化、スタートメニューショートカットなど付き
* GitHub API経由のOTA統合

制御機能：
* バッテリー状態の概要（ヘルスなど）
* バッテリー充電制御（現時点では高度な/日次タイミングモードなし）
* サーマルプロファイル制御
* OSの電源モード検出

今後の予定：
* 高度なバッテリー充電制御/スケジューリング（[機能リクエスト](https://github.com/alexVinarskis/dell-powermanager/issues/24)）
* 「ピークシフト」制御（[機能リクエスト](https://github.com/alexVinarskis/dell-powermanager/issues/57)）

将来検討すべき潜在的な機能:
* CPU負荷に基づくサーマルプロファイルの自動切り替え用監視サービスの追加
* 電源設定（例：バッテリーレベル、プラグの抜き差しなど）に基づくサーマルプロファイルの自動切り替え用監視サービスの追加

## 開発状況
アプリケーションは現在**安定版、メンテナンス中**の状態です。

* DellのCCTK統合（特定のOS向けに自動インストーラー付き）
* 更新チェック実装（特定のOS向けにGitHub APIによるOTA対応）
* UIテスト済み、CIによるビルドとパッケージング確認済み
* `.msi`、`.deb`、`.tar.xz`形式でパッケージ化済み。最新安定版は[Releases](https://github.com/alexVinarskis/dell-powermanager/releases/latest)から、最新開発版は[CI artifacts](https://github.com/alexVinarskis/dell-powermanager/actions/workflows/build.yml?query=branch%3Amaster)から入手可能
* 複数プラットフォームでテスト済み、詳細は[Compatibility](#compatibility)を参照。対応プラットフォーム：
    * Windows, x86_64（ネイティブ `.msi`）
    * Windows, arm64（エミュレーション下でのx64_86 `.msi`）
    * Linux, x86_64（ネイティブ `.deb`, `.tar`）
    * Linux, arm64*（ネイティブ `.deb`, `.tar`）_バッテリ情報部分のみ動作 - Dellのarm64向けCCTKは未対応のため、実際の制御は不可（まだ？）_
## ソースからのビルド
### Linux
* 依存関係をインストール：
```
sudo apt-get install -y ninja-build libgtk-3-dev libsqlite3-dev libsecret-1-0 libsecret-1-dev
```
* `flutter run` でソースから実行、`flutter build linux --release` でビルド  
* `./package.sh` で `.deb`、`.tar.xz` にパッケージ化  

注意: `snap` から flutter をインストールしないでください。代わりに [ネイティブインストール](https://docs.flutter.dev/get-started/install/linux/desktop) を使用してください。snap 提供の flutter は [snap 固有の問題](https://github.com/juliansteenbakker/flutter_secure_storage/issues/676) によりこのプロジェクトのコンパイルに失敗します。  

### Windows  
* `flutter run` でソースから実行、`flutter build windows --release` でビルド  
* `.\package.bat` で `.msi` にパッケージ化  

## 貢献について  

### デバッグ  

デフォルトではすべてのログは抑制されています。CLI からアプリを実行する前に `POWERMANAGER_DEBUG=true` をエクスポートするとログが取得できます。  
例: `export POWERMANAGER_DEBUG=true && ./dell-powermanager > file.log`。問題を報告する際は、ログを保存して添付してください。  

### 翻訳  
アプリは Flutter のローカリゼーションライブラリを通じて複数言語をサポートしています。貢献したい場合は：  
* [lib/l10n/*.arb](https://raw.githubusercontent.com/alexVinarskis/dell-powermanager/master/lib/l10n/app_en.arb) ファイルを確認してください。  
* ご自身の言語用に類似のファイルを作成し、文字列を翻訳してください。  
* 変更を含む PR を提出してください。  

## 互換性  
以下のデバイスでテスト済み：  
* Dell G3 15 3500  
    * [Windows 11 24H2 (OS Build 26100.4061)](https://github.com/alexVinarskis/dell-powermanager/issues/65)  
* Dell Latitude 5400  
    * [Ubuntu 24.04](https://github.com/alexVinarskis/dell-powermanager/issues/56)  
* Dell Precision 7560  
    * [Fedora 41, 6.12.4](https://github.com/alexVinarskis/dell-powermanager/issues/47)  
* Dell XPS 17 9700  
    * [Tumbleweed OpenSUSE, 6.7.5](https://github.com/alexVinarskis/dell-powermanager/issues/31)  
* Dell XPS 15 9560  
    * [Arch Linux, 6.11.6-arch1-1](https://github.com/alexVinarskis/dell-powermanager/issues/46)  
* Dell XPS 15 9530 (2023/Fiorano)  
    * Ubuntu 23.04, 6.5.0-060500-generic  
    * Ubuntu 23.10, 6.5.0-060500-generic  
    * Windows 11 Pro 22H2, 22621.2428  
* Dell XPS 15 9520  
    * [Arch, 6.7.5](https://github.com/alexVinarskis/dell-powermanager/issues/31)
    * Ubuntu 22.04, 6.2.0
    * Windows 11 Home 22H2, 22621.2428
* Dell XPS 13 9345 (Tributo)
    * Ubuntu 24.10, 6.12.0-28-qcom-x1e（バッテリー情報のみ）
    * Windows 11 pro
* Dell XPS 13 9310
    * Ubuntu 22.04.3, 6.2.0-26-generic
    * Windows 10 pro 22H2, 19045.3324
* Dell Vostro 5401
    * [Ubuntu 23.10](https://github.com/alexVinarskis/dell-powermanager/issues/23)

上記のいずれかのデバイスで問題が発生した場合は、[**バグ報告**](https://github.com/alexVinarskis/dell-powermanager/issues/new?template=bug_report.md&title=[BUG])を開いてください。他のデバイスでテストした場合は、[**テスト済みデバイス**](https://github.com/alexVinarskis/dell-powermanager/issues)に報告してください。

## 既知の問題
[issues](https://github.com/alexVinarskis/dell-powermanager/issues)をご覧ください。
## クレジット
* Dell による「Dell Command | Configure CLI」の提供
* Google による Flutter の作成 :)

## 免責事項
ライセンスに従い、本ソフトウェアは現状のまま提供され、いかなる保証もありません。本ソフトウェアは Dell とは一切関係ありません。使用は自己責任で行ってください。私や他の貢献者は、本ソフトウェアによって引き起こされるデータ損失、ハードウェア損傷、データ漏洩などを含むがこれに限定されないいかなる損害についても責任を負いません。適用可能な場合、安全なキー保存のための統合ソリューションが使用されていますが、いかなる安全性も保証されません。使用前にリスクと影響を理解してください。著者や貢献者に対して法的請求を行うことはできません。

## ライセンス
このアプリケーションは GPLv3 ライセンスの下で提供されています。簡単に言うと、無料で使用・コピー・改変・配布できますが、変更したソースコードを提供し、同じライセンスを保持しなければなりません。独自ソフトウェアとして販売することはできません。詳細は [LICENSE](LICENSE) を参照してください。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-16

---