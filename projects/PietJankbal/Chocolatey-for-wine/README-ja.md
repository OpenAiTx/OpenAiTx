
<div align="right">
  <details>
    <summary >🌐 言語</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Chocolatey-for-wine

Chocolateyパッケージマネージャーをwine内で自動インストールするツールです。wine上でプログラムを素早くインストールできるので便利です（そしてwineのバグをすぐに見つけられるかも ;) ）  
いくつかのバグについては、Visual Studio Community 2022やnodejsのような回避策が追加されています。詳細は後述します。  

ロックダウン中の暇つぶしに、便利だと思う動詞を追加したカスタムwinetricks(.ps1)を書きました。'winetricks'と入力すると一覧が表示されます。
いくつかの動詞については、wineの完全な再起動が必要です（最近のwineの変更によるものです）。メッセージボックスが表示され、セッションが終了します。再度PowerShellを起動して動詞を再実行してください。一度実行すれば、その後どの動詞でも再起動は不要になります。  

例：  

'winetricks vs22_interactiveinstaller'（ --> セッションが終了します）  

'wine powershell' を実行  

'winetricks vs22_interactiveinstaller' を実行  


（ちなみに 'winetricks vs22_interactive_installer' を使うと、Visual Studio 2022 インストーラーからインストールするものを選択できます；'winetricks vs22_interactive_installer' で10分ほどでメインプログラムに入れました（Desktop development with C++ を選択））。

インストール方法 :
- リリースの zip ファイルをダウンロードして解凍し、'wine ChoCinstaller_0.5c.751.exe' を実行（完了まで約1分）

オプション:
- インストーラーを 'wine ChoCinstaller_0.5a.751.exe /s' のように実行すると、インストールファイル（Powershell*.msi や dotnet48 など）が 
  MyDocuments に保存され、新しいプレフィックスを作成する際に再ダウンロード不要になります。
オプション:
- インストーラーを 'wine ChoCinstaller_0.5a.751.exe /q' のように実行すると、powershell ウィンドウの自動起動を防げます（インストールのみ）。

オプション:
- 動作確認: "choco install chromium" と "start chrome.exe（wine-8,4以降は --no-sandbox 不要）" 

![Screenshot from 2022-08-26 12-31-18](https://user-images.githubusercontent.com/26839562/186885380-d5a617c4-9cf4-4831-a475-2bd85a3b5784.png)
PowerShell について:

ヒント：Chocolatey は通常、プログラムの最新版をインストールしますが、新しい wine のバグが発生する場合があります。ソフトウェアの古いバージョンの方が安定することもあります。  
例：  

choco search --exact microsoft-edge --all（ --> すべてのバージョンを一覧表示）  

choco install microsoft-edge --version --version='135.0.3179.98'

一般情報:

- 'wine powershell.exe' で PowerShell-Core コンソールを起動します。

 
ConEmu について:

ConEmu コンソールはいくつかの wine バグの影響を受けています:
  - コンソールに戻らないプログラムを終了するための Ctrl^C が機能しません。代わりに Shift^Ctrl^C を使用してください。
  - ConEmu ウィンドウでテキストを選択しても（コピー/貼り付け用）、選択範囲がハイライトされません。最近の wine バージョン向けに非常に簡易的なハックが含まれており、これでハイライトが機能するはずです。
   
winetricks(.ps1) について:

- 呼び出さなければ（powershell-console で 'winetricks' を実行しなければ）、何もダウンロードされないのでオーバーヘッドはありません。
- 多くの動詞（powershell 5.1 など）は msu パッケージから展開するためにいくつかの必須ファイルを必要とします。これらの必須ファイルのインストールには最初に大きなダウンロードが必要で、初回利用時は多くの時間がかかります。しかしキャッシュ後は高速です。例えば 'winetricks ps51' を最初に試す場合、約15分かかります。他の動詞は初回で5分程度かかる場合がありますが、一度呼び出せば以降は煩わしさはありません。
- ファイルは MyDocuments ディレクトリにキャッシュされます。すべての動詞を呼び出すと約800MB使用します。
- さまざまな動詞でより良い64ビットサポートが期待されます。
- msu ファイルからファイルを抽出してインストールを試みる機能。'winetricks install_dll_from_msu' を実行して確認してください。
- 簡易的な Powershell 5.1。
- 実験的な dotnet481 インストール、および dotnet35（現行の dotnet48 では満たされないアプリで必要な場合あり）。
- 自動タブ補完。注意: コマンドラインから複数の動詞を使う場合は今後カンマで区切る必要があります
  （powershell で複数引数を扱う仕様のため）
  そのため 'winetricks riched20 gdiplus' は使用できなくなり、'winetricks riched20,gdiplus' を使用してください
- WineバグのためにChocolatey経由で試すとインストール/実行に失敗するプログラムがあります。いくつかの回避策を winetricks に追加しています。詳細は下記参照。
- Visual Studio Community 2019 および 2022 をインストールする特別な動詞（winetricks vs19, vs22, vs22_interactive_installer）を用意（スクリーンショット参照、インストールに10分超＆約10GB必要！インストール後は c:\Program\ Files (x86)\Microsoft Visual Studio\2019\Community\Common7\IDE/ の devenv.exe を起動）
  ![screenshot](https://github.com/PietJankbal/Chocolatey-for-wine/assets/26839562/d576a619-c752-4eb1-81c2-6f6b66b50ff6)
- grep, sed, file, less, curl など様々な unix コマンドにアクセスできる特別な動詞（winetricks git.portable、免責事項: wine バグのため一部コマンドはまだ動作しません）
- インターネット上のコードスニペットを元にアレンジした powershell スクリプトもいくつか同梱:
    - Invoke-ReflectivePEInjection で exe を powershell スクリプトに埋め込む方法（exeは tasklist に表示されません）。
    - 高機能なメッセージボックスの作成方法
    - powershell スクリプト（ps1）を exe に変換する方法
    - その他いくつか
 
     
システムプログラムについて:

setx.exe のような単純なシステムプログラムを c:\\Program Files\Powershell\7\profile.ps1 の関数で置き換える機能を追加しました。
また、getmac.exe のように不足しているシステムプログラムを追加することもできます。
十分に成熟していない、または不足しているシステムプログラムのためにプログラムが失敗する場合、プログラムが期待する値を返す関数を作成することができます。
profile.ps1 には（他にも）より多くのオプションをサポートする wmic.exe と基本的な setx.exe を追加しました。
また、システムプログラムに渡される引数を操作することもできます。profile.ps1 と choc_install.ps1 を参照してください。
より複雑なプログラムにも機能する保証はありません...
 
備考:



  - 既存のwineprefixでは使用しないでください。新しく作成したプレフィックスのみで使用してください！インストーラーは単純にdotnet48自体をインストールし、レジストリキーをいじります。
    すでに通常のwinetricks.shで何らかのdotnetバージョンをインストールしている場合、ほぼ確実に失敗し、たとえ成功しても壊れたプレフィックスになる可能性が高いです。
    プログラムのために通常のwinetricks.shで何かをインストールする必要がある場合、dotnet*のいずれの動詞も使用しないでください。
    ちなみに「Arial」と「d3dcompiler_47」の動詞はデフォルトですでにインストールされています。
  - WINEARCH=win32は_サポートされていません_！
  - 以前のバージョンからのアップデートは現時点では（まだ）サポートされていません。将来的には対応するかもしれません。

コンパイル:
  - バイナリをダウンロードせず自分でコンパイルしたい場合：mainv1.cとinstaller.cのコンパイル手順を参照してください。
  - その後、choc_install.ps1を同じディレクトリにコピーしてください
  - その後「wine ChoCinstaller_0.5a.735.exe」と実行してください
  


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-23

---