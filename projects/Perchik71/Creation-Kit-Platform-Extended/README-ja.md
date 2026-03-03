
<div align="right">
  <details>
    <summary >🌐 言語</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=as">অসমীয়া</
      </div>
    </div>
  </details>

</div>

<p align="center">
  <img src="https://github.com/Perchik71/Creation-Kit-Platform-Extended/blob/master/Resources/logo.png" alt="Creation Kit Platform Extended" border="0" width="400px">
</p>
<p align="center">
  Bethesda社のCreation Kit向けの修正、拡張、リバースエンジニアリングされたリソースのコレクションです。
</p>

# 説明
**CKPE** は共有ソースの強力なプラットフォームで、**Bethesda** の Creation Kit エディターに多数の修正と改善を加え、**Skyrim Special Edition**、**Fallout 4**、**Starfield** などのゲームのエディターサポートを含みます。[SSE CKFixes](https://github.com/Nukem9/skyrimse-test)、[SSE CKFixes Update](https://github.com/Perchik71/SkyrimSETest)、[FO4 CKFixes](https://github.com/Perchik71/Fallout4Test) の後継プロジェクトであり、著者 **perchik71** の原点である [Unicode patch for SSE CK 1.5.73](https://github.com/Perchik71/usse_test) も含まれます。  

[Wiki](https://github.com/Perchik71/Creation-Kit-Platform-Extended/wiki) ページ  

# 依存関係
[toml11](https://github.com/ToruNiina/toml11)（`ToruNiina` 他）  
[Zydis](https://github.com/zyantific/zydis.git)（`zyantifi` 他）  
[zipper](https://github.com/kuba--/zip.git)（`kuba--`）  
[libdeflate](https://github.com/ebiggers/libdeflate.git)（`ebiggers` 他）  
[xbyak](https://github.com/herumi/xbyak.git)（`herumi` 他）  
[DirectXTex](https://github.com/microsoft/DirectXTex.git)（`microsoft`）  
[jDialogs](https://github.com/Perchik71/jDialogs.git)（`perchik71`、*再帰的*）

# インストール
>[!重要]
>通常版または noavx2 版のリリース？  
>ご利用の CPU が avx2 をサポートしているか Steam で確認してください。Steam を開き、左上のヘルプメニューにカーソルを合わせて「システム情報」を選択し、「AVX2」で検索します。  
>サポートされている場合は通常版を選択してください。  
>サポートされていない場合は noavx2 版を選択してください。  
### 新規インストール
[サポート対象ゲーム](https://github.com/Perchik71/Creation-Kit-Platform-Extended/wiki#brief) をダウンロードし、Creation Kit をインストールします。  
お使いのゲーム用の **CKPE** の[最新リリース](https://github.com/Perchik71/Creation-Kit-Platform-Extended/releases) をダウンロードします。  
すべての内容をゲームディレクトリに展開し、**ckpe_loader.exe** が **CreationKit.exe** と同じフォルダにあることを確認してください。
### アップデート
お使いのゲーム用の **CKPE** の[最新リリース](https://github.com/Perchik71/Creation-Kit-Platform-Extended/releases) をダウンロードします。  
すべての内容をゲームディレクトリに展開し、**ckpe_loader.exe** が **CreationKit.exe** と同じフォルダにあることを確認してください。  
すべてのファイルの上書きに同意してください。
### コンパイル
通常のユーザーは未公開の最新機能にアクセスする場合のみこの方法が必要です。  
**`Visual Studio 2022`** 以降でプロジェクトを開きます。**`Release`** モードまたは **`Release-NoAVX2`** でビルドします。  
その後、ビルド出力をゲームディレクトリに移動し、**ckpe_loader.exe** が **CreationKit.exe** と同じフォルダにあることを確認してください。  
古いファイルの上書きを求められた場合は、すべて上書きに同意してください。
### 自動ビルド（ベータ）
お使いのゲーム用の **CKPE** の[最新コミットビルド](https://github.com/Perchik71/Creation-Kit-Platform-Extended/actions) をダウンロードします。  
すべての内容をゲームディレクトリに展開し、**ckpe_loader.exe** が **CreationKit.exe** と同じフォルダにあることを確認してください。  
発生しうるエラー。

# クレジット
[Nukem9](https://github.com/Nukem9)（実験的機能やハッシュ等、非常に有用）
[adzm](https://github.com/adzm) （あなたの仕事に本当に感謝しています。あなたが[成し遂げた](https://github.com/adzm/win32-custom-menubar-aero-theme)ことは、私が長い間やりたかったことです）  
[yak3d](https://github.com/yak3d) （ワークフローの貢献と開発、最新のStarfieldサポートのため）  
[DioKyrie-Git](https://github.com/DioKyrie-Git) （readmeのデザインのため）  

# ライセンス
v0.6（コミット[9d93970](https://github.com/Perchik71/Creation-Kit-Platform-Extended/commit/9d93970cc3918099c895872d46a24aa29a34db11)）以降、本プロジェクトは[LGPLv3](https://www.gnu.org/licenses/lgpl-3.0.html)でライセンスされています。<br />
初期バージョンは[GPLv3](https://www.gnu.org/licenses/gpl-3.0.html)でライセンスされています。<br />
Copyright © 2023-2025 aka perchik71. All rights reserved. <br />
`Stuffs\FO4\CreationKitPlatformExtended_FO4_Resources.pak`ファイルには、専有および非ライセンスファイルが含まれています。同様に、`d3dcompiler\*.*`内のファイルも該当します。<br />
依存関係はそれぞれのライセンスに従います。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-03

---