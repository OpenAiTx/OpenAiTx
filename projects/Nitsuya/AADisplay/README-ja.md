# AADisplay

[![AADisplay](https://img.shields.io/badge/AADisplay-Project-blue?logo=github)](https://github.com/Nitsuya/AADisplay)
[![GitHub Release](https://img.shields.io/github/v/release/Xposed-Modules-Repo/io.github.nitsuya.aa.display)](https://github.com/Xposed-Modules-Repo/io.github.nitsuya.aa.display/releases)
![Xposed Module](https://img.shields.io/badge/Xposed-Module-blue)
[![License](https://img.shields.io/github/license/nitsuya/AADisplay)](https://github.com/nitsuya/AADisplay/blob/main/LICENSE)
![Android SDK min 31](https://img.shields.io/badge/Android%20SDK-%3E%3D%2031-brightgreen?logo=android)
![Android SDK target 33](https://img.shields.io/badge/Android%20SDK-target%2033-brightgreen?logo=android)

AADisplayのチュートリアル関連の動画や画像を公共の場に投稿しないでください。そうしないと中国以外の地域での更新を停止します。

Android Autoで任意のアプリを表示する、VirtualDisplayベースの多重ラップ方式、Star! Star! Star!

Android 12以上のみ対応、LSPosedが必要、一部のROMではクラッシュの可能性がありますので、復旧の常識を準備してください。

理論上はAndroid 10以上をサポート可能ですが、デバイスがなく、メンテナンスに十分な時間がないため対応していません。能力のある方はPRをお願いします。

本プロジェクトに関係のない問題はIssueを提出しないでください。必ずクローズします！例：Magisk/LSPosed環境のインストール、AAが接続・使用できない等の関連問題。

-----

## 使用方法
- LSPosedで本モジュールを有効化し、System FrameworkとAndroid Autoにチェックを入れ、好きなランチャーをインストールし、モジュール設定でパッケージ名を入力してください。
- DPIの設定を推奨します。アプリのコンテキストを利用してUIを描画する一部の癖のあるアプリの改善に効果があります。
- PropertiesにAA関連パラメータを追加し、AAの設定をHookして修正可能です。基本的な型のパラメータのみ対応。
- Android AutoによるAAアプリのインストール元検証を自動で回避します。
- Root権限はユーザー設定のShellコマンド実行時のみ使用します。不要なら付与しなくても構いません。

## 免責事項
- 本モジュールの使用はすべて自己責任とし、機器の損傷や運転事故を含む一切の結果を負うものとします。
- 本プロジェクトから派生したプロジェクトに関して本プロジェクトは一切責任を負いません。
- 本プロジェクトは永久にオープンソースを保証し、IssueやPRの提出を歓迎しますが、不正利用目的の機能は提出しないでください。
- 開発者はいつでも**更新を停止**または**プロジェクトを削除**する権利を有します。

## 支援のお願い
[寄付 Donation](https://afdian.com/a/nitsuya)

CNY:
- [Eclair234](https://github.com/Eclair234) 350
- 守望先锋真难玩(某安) 50
- 狐仙(某Q) 25
- 匿名 20+50

## Thanks

### 库

[AOSP](https://source.android.com/)

[YAMF](https://github.com/duzhaokun123/YAMF)

[DexKit](https://github.com/LuckyPray/DexKit)

[Hide-My-Applist](https://github.com/Dr-TSNG/Hide-My-Applist)

[HiddenApi](https://github.com/RikkaW/HiddenApi)

[LSPosed](https://github.com/LSPosed/LSPosed)

[xposed](https://forum.xda-developers.com/xposed)

[Material](https://material.io/)

[QAuxiliary](https://github.com/cinit/QAuxiliary)

[ViewBindingUtil](https://github.com/matsudamper/ViewBindingUtil)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-27

---