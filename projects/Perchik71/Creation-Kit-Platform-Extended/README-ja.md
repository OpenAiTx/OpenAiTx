<p align="center">
  <img src="https://github.com/Perchik71/Creation-Kit-Platform-Extended/blob/master/Resources/logo.png" alt="Creation Kit Platform Extended" border="0" width="400px">
</p>
<p align="center">
  ベセスダのCreation Kitのための改造、強化、およびリバースエンジニアリングされたリソースのコレクション。
</p>

# 説明
**CKPE** は共有ソースの強力なプラットフォームで、**Bethesda** のCreation Kitエディタに多数の修正と改善を加え、**Skyrim Special Edition**、**Fallout 4**、**Starfield**などのゲームのエディタサポートを含み、[SSE CKFixes](https://github.com/Nukem9/skyrimse-test)、[SSE CKFixes Update](https://github.com/Perchik71/SkyrimSETest)、[FO4 CKFixes](https://github.com/Perchik71/Fallout4Test)プロジェクトの後継であり、作者**perchik71**のすべての始まりである[Unicodeパッチ for SSE CK 1.5.73](https://github.com/Perchik71/usse_test)も含みます。  

[Wiki](https://github.com/Perchik71/Creation-Kit-Platform-Extended/wiki) ページ  

# 依存関係
[toml11](https://github.com/ToruNiina/toml11) by `ToruNiina` 他  
[Zydis](https://github.com/zyantific/zydis.git) by `zyantifi` 他  
[zipper](https://github.com/kuba--/zip.git) by `kuba--`  
[libdeflate](https://github.com/ebiggers/libdeflate.git) by `ebiggers` 他  
[xbyak](https://github.com/herumi/xbyak.git) by `herumi` 他    
[DirectXTex](https://github.com/microsoft/DirectXTex.git) by `microsoft`  
[jDialogs](https://github.com/Perchik71/jDialogs.git) by `perchik71` *(再帰的)*

# インストール
### 新規インストール
対応ゲームのいずれかをダウンロードし（[対応ゲーム一覧](https://github.com/Perchik71/Creation-Kit-Platform-Extended/wiki#brief)）、Creation Kitをインストールします。  
ゲーム用の**CKPE**最新リリースをダウンロードします。  
すべての内容をゲームディレクトリに展開し、**ckpe_loader.exe**が**CreationKit.exe**と同じフォルダにあるようにします。
### アップデート
ゲーム用の**CKPE**最新リリースをダウンロードします。  
すべての内容をゲームディレクトリに展開し、**ckpe_loader.exe**が**CreationKit.exe**と同じフォルダにあるようにします。  
すべてのファイルを置き換えることに同意してください。
### コンパイル
一般ユーザーはまだリリースされていない新機能にアクセスするためにこの方法のみが必要です。  
**`Visual Studio 2022`**以降でプロジェクトを開き、**`Release`**モードまたは**`Release-NoAVX2`**モードでビルドします。  
ビルド出力をゲームディレクトリに移動し、**ckpe_loader.exe**が**CreationKit.exe**と同じフォルダにあるようにします。  
古いファイルの置き換えを求められたらすべて置き換えることに同意してください。
### 自動ビルド（ベータ）
ゲーム用の**CKPE**最新コミットビルドをダウンロードします。  
すべての内容をゲームディレクトリに展開し、**ckpe_loader.exe**が**CreationKit.exe**と同じフォルダにあるようにします。  
考えられるエラー。

# クレジット
[Nukem9](https://github.com/Nukem9)（実験的な機能、ハッシュなどに関して、とても役立っています）  
[adzm](https://github.com/adzm)（あなたの仕事に本当に感謝しています。私は長い間自分でやりたかったことを[実現](https://github.com/adzm/win32-custom-menubar-aero-theme)してくれました）  
[yak3d](https://github.com/yak3d)（ワークフローの貢献と開発、最新のStarfieldサポートのために）  
[Dio-Kyrie](https://github.com/Dio-Kyrie)（READMEのデザインに対して）  

# ライセンス
v0.6（コミット[9d93970](https://github.com/Perchik71/Creation-Kit-Platform-Extended/commit/9d93970cc3918099c895872d46a24aa29a34db11)）以降、このプロジェクトは[LGPLv3](https://www.gnu.org/licenses/lgpl-3.0.html)でライセンスされています。<br />
初期バージョンは[GPLv3](https://www.gnu.org/licenses/gpl-3.0.html)でライセンスされています。<br />
Copyright © 2023-2025 aka perchik71. All rights reserved.<br />
ファイル `Stuffs\FO4\CreationKitPlatformExtended_FO4_Resources.pak` は専有かつライセンスされていないファイルを含みます。同様に `d3dcompiler\*.*` 内のファイルも該当します。<br />
依存関係はそれぞれのライセンスの下にあります。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-08

---