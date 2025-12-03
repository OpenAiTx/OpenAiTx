# Chocolatey-for-wine

Chocolatey パッケージマネージャーの自動インストーラーを wine 上で動作させるもので、wine にプログラムを素早くインストールするのに便利です（そして後で wine のバグを見つけるために ;)）  
Visual Studio Community 2022 や nodejs のためのバグ回避策などもいくつか追加しています。詳細は後述します。  

ロックダウン中に暇だったので、自分が便利だと思う動詞を備えたカスタム winetricks(.ps1) を書きました。'winetricks' と打つだけでそれらが見られます。  
いくつかの動詞は（最近の wine の変更により）wine の完全な再起動が必要です。メッセージボックスが表示され、セッションが終了します。powershell を再度起動して動詞を再試行してください。一度これを行えば、以降はどの動詞でも必要ありません。  

例：  

'winetricks vs22_interactiveinstaller'  （--> セッションが終了します）  

'wine powershell' を実行してください。  

'winetricks vs22_interactiveinstaller' を再度実行してください。  


（ちなみに 'winetricks vs22_interactive_installer' を使うと Visual Studio 2022 インストーラーでインストールするものを選択できます；'winetricks vs22_interactive_installer' で10分以内にメインプログラムに到達できました（Desktop development with C++ を選択））。

インストール方法：  
- リリースの zip ファイルをダウンロードして解凍し、'wine ChoCinstaller_0.5c.751.exe' を実行します（完了まで約1分かかります）

オプション：  
- 'wine ChoCinstaller_0.5a.751.exe /s' のようにインストーラーを実行すると、インストール用ファイル（Powershell*.msi や dotnet48 など）が MyDocuments に保存され、新しいプレフィックスを作成するときに再ダウンロードの必要がなくなります）  
オプション：  
- 'wine ChoCinstaller_0.5a.751.exe /q' のようにインストーラーを実行すると、powershell ウィンドウの自動起動を防げます（インストールのみ）。  

オプション：  
- 正常に動作したか確認するには："choco install chromium" と "start chrome.exe (--no-sandbox は wine-8.4 以降不要)" を実行してください。  

![Screenshot from 2022-08-26 12-31-18](https://user-images.githubusercontent.com/26839562/186885380-d5a617c4-9cf4-4831-a475-2bd85a3b5784.png)  
PowerShell について：  

ヒント：Chocolatey は通常、プログラムの最新バージョンをインストールしますが、それが新たな wine のバグを露呈することがあります。古いバージョンのソフトウェアを使ったほうがうまくいく場合があります。  
例：  

choco search --exact microsoft-edge --all （--> 全てのバージョンを一覧表示）  

choco install microsoft-edge --version --version='135.0.3179.98'

一般情報：

- 'wine powershell.exe' は PowerShell-Core コンソールを起動します。

 
ConEmuについて：

ConEmuコンソールはwineのいくつかのバグの影響を受けています：
  - Ctrl^C でコンソールに戻らないプログラムを終了できません。代わりに Shift^Ctrl^C を使用してください。
  - ConEmuウィンドウでテキストを選択しても（コピー/ペースト用に）選択部分がハイライトされません。最近のwineバージョンに対する非常に残念なハックが含まれており、これによりハイライトが機能するはずです。
   
winetricks(.ps1)について：

- 呼び出さなければ（powershellコンソールで 'winetricks' を実行しなければ）、何もダウンロードされないのでオーバーヘッドはありません。
- 多くの動詞（例えば powershell 5.1）は msuパッケージから抽出するためのいくつかの必須ファイルを必要とします。これらの必須ファイルのインストールには最初に大きなダウンロードが必要で、初回使用時に多くの時間がかかります。しかし、一度キャッシュされると高速になります。例えば 'winetricks ps51' を最初に試すと約15分かかります。他の動詞は初回使用で約5分かかることがあります。しかし、一度動詞を呼び出せばこの煩わしさは解消されます。
- ファイルは MyDocuments ディレクトリにキャッシュされます。すべての動詞を呼び出すと約800MB必要です。
- いくつかの動詞に対するより良い64ビットサポートを期待しています。
- ファイルを抽出し、msuファイルからインストール（試みる）機能があります。方法は 'winetricks install_dll_from_msu' を参照してください。
- 原始的な Powershell 5.1 を含みます。
- 実験的な dotnet481 インストールと、現在の dotnet48 インストールに満足しないアプリ用の dotnet35。
- 自動タブ補完。注意：コマンドラインで複数の動詞を使用する場合、今後はカンマで区切る必要があります（これはpowershellが複数引数を扱う方法です）。
  したがって 'winetricks riched20 gdiplus' は使えず、代わりに 'winetricks riched20,gdiplus' を使います。
- 一部のプログラムはwineバグのためにChocolatey経由でのインストール/実行に失敗します。これらに対してwinetricksにいくつかの回避策を追加しました。以下を参照してください。
- 特殊動詞（winetricks vs19, vs22 および vs22_interactive_installer）で動作する Visual Studio Community 2019 および 2022 をインストール可能（スクリーンショット参照、インストールに10分以上かかり約10GB必要！、インストール後は c:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\IDE\ の devenv.exe を起動してください）
  ![screenshot](https://github.com/PietJankbal/Chocolatey-for-wine/assets/26839562/d576a619-c752-4eb1-81c2-6f6b66b50ff6)
- grep、sed、file、less、curl 等の様々なunixコマンドにアクセス可能な特殊動詞（winetricks git.portable、免責事項：wineのバグにより一部のコマンドはまだ動作しません）
- また、インターネット上のコードスニペットから適応したいくつかのpowershellスクリプトも含まれています：
    - Invoke-ReflectivePEInjection を使った exe のpowershellスクリプト内埋め込み方法（exeはtasklistに表示されません）。
    - おしゃれなメッセージボックスの作り方
    - powershellスクリプト（ps1）をexeに変換する方法。
    - その他いくつか
 
     
システムプログラムについて：

setx.exe のような単純なシステムプログラムを c:\\Program Files\Powershell\7\profile.ps1 の関数で置き換える機能を追加しました。あるいは getmac.exe のように存在しないシステムプログラムを追加します。
プログラムが未成熟または欠落したシステムプログラムのために失敗する場合は、誰かが 



プログラムが期待するものを返す関数。  
profile.ps1では、（他のものと共に）より多くのオプションをサポートするwmic.exeや、基本的なsetx.exeを追加しました。  
または、システムプログラムに渡される引数を操作することもできます。profile.ps1およびchoc_install.ps1を参照してください。  
より複雑なプログラムでも動作する保証はありません...  
  
注意事項：  
  
  - 既存のwineprefixでは使用しないでください。必ず新規に作成したプレフィックスでのみ使用してください！インストーラーはdotnet48を単純にインストールし、レジストリキーを混乱させます。  
    通常のwinetricks.shで既にdotnetのバージョンがインストールされている場合、失敗する可能性が高く、成功しても壊れたプレフィックスになる可能性があります。  
    プログラムのために通常のwinetricks.shで何かをインストールする必要がある場合は、dotnet*の動詞は使用しないでください。  
    ちなみに 'Arial' と 'd3dcompiler_47' の動詞はデフォルトで既にインストールされています。  
  - WINEARCH=win32 はサポートされていません！  
  - 以前のバージョンからのアップデートは現時点では（まだ）サポートされていません。将来的に対応するかもしれません。  
  
コンパイル：  
  - バイナリをダウンロードする代わりに自分でコンパイルしたい場合は、mainv1.cおよびinstaller.cのコンパイル手順を参照してください。  
  - その後、choc_install.ps1を同じディレクトリにコピーしてください。  
  - そして 'wine ChoCinstaller_0.5a.735.exe' を実行してください。  
  



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-03

---