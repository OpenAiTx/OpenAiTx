
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
**CKPE** は、**Bethesda** の Creation Kit エディタに多くの修正と改善をもたらす、共有ソースの強力なプラットフォームです。**Skyrim Special Edition**、**Fallout 4**、**Starfield** などのゲームのエディタサポートを含み、[SSE CKFixes](https://github.com/Nukem9/skyrimse-test)、[SSE CKFixes Update](https://github.com/Perchik71/SkyrimSETest)、[FO4 CKFixes](https://github.com/Perchik71/Fallout4Test) プロジェクト、さらに著者 **perchik71** のきっかけとなった [Unicode patch for SSE CK 1.5.73](https://github.com/Perchik71/usse_test) の後継です。  

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
>[!重要]
>通常版か noavx2 版か？  
>お使いのCPUがavx2をサポートしているかSteamで確認してください。Steamを開き、左上のヘルプメニューにマウスを合わせ「システム情報」を選択し、AVX2を検索します。  
>サポートされていれば通常版を選択  
>サポートされていなければnoavx2版を選択  
### 新規インストール
[対応ゲーム](https://github.com/Perchik71/Creation-Kit-Platform-Extended/wiki#brief)をダウンロードし、Creation Kitをインストールしてください。  
ご利用のゲーム用に**CKPE**の[最新リリース](https://github.com/Perchik71/Creation-Kit-Platform-Extended/releases)をダウンロードしてください。  
全ての内容をゲームディレクトリに展開し、**ckpe_loader.exe** が **CreationKit.exe** と同じフォルダーにあることを確認します。
### アップデート
ご利用のゲーム用に**CKPE**の[最新リリース](https://github.com/Perchik71/Creation-Kit-Platform-Extended/releases)をダウンロードしてください。  
全ての内容をゲームディレクトリに展開し、**ckpe_loader.exe** が **CreationKit.exe** と同じフォルダーにあることを確認します。  
すべてのファイルの上書きを許可します。
### コンパイル
一般ユーザーはまだリリースされていない最新機能にアクセスする場合のみこの方法が必要です。  
**`Visual Studio 2022`** 以降でプロジェクトを開きます。**`Release`** モードまたは **`Release-NoAVX2`** でビルドします。  
その後、ビルド出力をゲームディレクトリに移動し、**ckpe_loader.exe** が **CreationKit.exe** と同じフォルダーにあることを確認します。  
古いファイルの上書きを求められた場合はすべて上書きしてください。
### ビルドの自動化（ベータ）
ご利用のゲーム用に**CKPE**の[最新コミットビルド](https://github.com/Perchik71/Creation-Kit-Platform-Extended/actions)をダウンロードしてください。  
全ての内容をゲームディレクトリに展開し、**ckpe_loader.exe** が **CreationKit.exe** と同じフォルダーにあることを確認します。  
発生しうるエラー。

# クレジット
[Nukem9](https://github.com/Nukem9) （実験的な機能やハッシュなど、非常に有用な貢献）  
[adzm](https://github.com/adzm)（あなたの作業に心から感謝しています。あなたは私自身が長い間やりたかったことを[実現](https://github.com/adzm/win32-custom-menubar-aero-theme)してくれました）  
[yak3d](https://github.com/yak3d)（ワークフローの貢献と開発、新しいStarfieldのサポートに感謝します）  
[DioKyrie-Git](https://github.com/DioKyrie-Git)（readmeのデザインに感謝します）  

# ライセンス
v0.6（コミット [9d93970](https://github.com/Perchik71/Creation-Kit-Platform-Extended/commit/9d93970cc3918099c895872d46a24aa29a34db11)）以降、プロジェクトは[LGPLv3](https://www.gnu.org/licenses/lgpl-3.0.html)でライセンスされています。<br />
初期バージョンは[GPLv3](https://www.gnu.org/licenses/gpl-3.0.html)でライセンスされています。<br />
Copyright © 2023-2025 aka perchik71. All rights reserved.<br />
ファイル `Stuffs\FO4\CreationKitPlatformExtended_FO4_Resources.pak` は独自のライセンスされていないファイルを含みます。同様のことが `d3dcompiler\*.*` 内のファイルにも当てはまります。<br />
依存関係はそれぞれのライセンスに従っています。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-20

---