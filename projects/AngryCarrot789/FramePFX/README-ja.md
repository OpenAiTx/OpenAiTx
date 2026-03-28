# FramePFX

FramePFXは、UIにAvaloniaを使用してC#で書かれたオープンソースの非線形ビデオエディタです。

## リメイク
現在、完全なリメイク（remakeブランチ）に取り組んでいます。主な違いは、新しいオーディオエンジン、動画ではなくオーディオ駆動の再生、フレーム単位ではなくTimeSpanベースの位置指定です。

# ドキュメント

フロントエンドとバックエンドについてもっと知りたい場合は、以下のドキュメントファイルのリンクをご覧ください。

[プラグインシステム + FramePFX API](https://raw.githubusercontent.com/AngryCarrot789/FramePFX/master/docs/Plugins.md)

[オートメーション/アニメーションシステム](https://raw.githubusercontent.com/AngryCarrot789/FramePFX/master/docs/Automation.md)

[コマンドシステム、コンテキストメニューシステム、ショートカット](https://raw.githubusercontent.com/AngryCarrot789/FramePFX/master/docs/Command%20System%20and%20Shortcuts.md)

[レンダリングシステム](https://raw.githubusercontent.com/AngryCarrot789/FramePFX/master/docs/Rendering.md)

[ショートカットシステム概要](https://raw.githubusercontent.com/AngryCarrot789/FramePFX/master/docs/Shortcuts.md)

[UI概要](https://raw.githubusercontent.com/AngryCarrot789/FramePFX/master/docs/TheUI.md)

# プレビュー

これはAvaloniaを使用した最新バージョンです:
![](https://raw.githubusercontent.com/AngryCarrot789/FramePFX/master/FramePFX-DesktopUI_2024-12-06_17.33.20.png)

こちらはエクスポートプロセスのプレビューです。エクスポートボタンはファイル>エクスポートにあり、パスを指定してからエクスポートをクリックします。
レンダリングをキャンセルするには、エクスポート進行ウィンドウの背後にあるダイアログでキャンセルをクリックします。

「Exporter: FFmpeg」の下のグレーパネルはエンコーダー固有の詳細です
![](https://raw.githubusercontent.com/AngryCarrot789/FramePFX/master/FramePFX-DesktopUI_2024-12-07_00.13.06.png)

## カスタマイズ可能なGUI！
テーマはお好みに合わせてカスタマイズできます。テーマはディスクに保存でき、アプリ内で編集可能です。組み込みの
テーマ（ダークとライト）は変更が保存されないため、変更しないでください。代わりにコピーを作成してそのコピーを修正してください。
![](https://raw.githubusercontent.com/AngryCarrot789/FramePFX/master/FramePFX-DesktopUI_2024-12-29_08.30.49.png)

# ビルド
FramePFXはすべて64ビットを前提としています --- x86/32ビット/AnyCPUは正しく動作しません！

ネイティブプロジェクトは最初にC#プロジェクトをビルドすると自動的にダウンロードされコンパイルされますが、  
メディアクリップやエクスポートを使用するには、FFmpegを別途ダウンロードする必要があります。  
現在動作する特定のバージョンはこちらです（Windowsのみ）：  
https://github.com/BtbN/FFmpeg-Builds/releases/download/autobuild-2024-09-30-15-36/ffmpeg-N-117275-g04182b5549-win64-gpl-shared.zip

## ダウンロード
プロジェクトを再帰的にクローンします：

`git clone --recursive https://github.com/AngryCarrot789/FramePFX`

FFmpegをインストールしてビデオメディアクリップやFFmpegエクスポートを使用する場合：  
- ソリューション内にffmpegフォルダを作成：`cd FramePFX && mkdir ffmpeg`  
- ダウンロードしたffmpegアーカイブから4つのディレクトリとLICENCE.txtを新しいffmpegフォルダにコピーします

>`\FramePFX\ffmpeg\bin`には8つのDLLファイルがあるはずで、そのうちの1つはavcodec-61.dllでなければなりません。61でない場合は間違ったバージョンのFFmpegを使っています。  
使用されないため、EXEファイルは削除しても構いません。

## プロジェクトのビルド
- FramePFX.slnを開きます。`portaudio`プロジェクトが読み込まれないエラーが出ますが無視して、`ビルド`メニューから`ソリューションのビルド`を実行してください。

これで問題なくFramePFXプロジェクトの実行・修正ができるはずです。このプロジェクトはAvalonia 11.2.2と.NET 8（C# 12）を使用しています。

>`portaudio`プロジェクトはcmakeによって自動生成されるため変更しないでください。変更は上書きされる可能性があります。

### Windows限定コマンド

ソリューション内のプロジェクトはmkdirやxcopyなどのWindowsコマンドを使用しており、他のプラットフォームでは動作しない可能性があります。  
よりクロスプラットフォームな解決策を作成した場合はプルリクエストを歓迎します！

### ビルドの問題例
SkiaSharpのnugetライブラリがクローン後のビルド時にskiaライブラリファイルをbinフォルダにコピーしないことがあります。以下の2つの修正方法があります：  
- `\packages\SkiaSharp.2.88.7\runtimes\win-x64\native\libSkiaSharp.dll`をエディターのbinフォルダにコピーする。  
- または、ソリューションディレクトリの`packages`フォルダを削除し、Visual Studioでソリューションを右クリックして「ソリューションのクリーン」を実行後、Nugetパッケージの復元をしてから再ビルドする。  
  これでも解決しない場合は、NugetマネージャーでSkiaSharpをアンインストールして再インストールを試してください。それでも直らない場合は原因がわかりません…

# プラグイン！
FramePFXはプラグインをサポートします！プラグインAPIはまだ開発途中ですが、プラグインの読み込みは可能です。  
現在プラグインはFramePFXと同じ依存関係のバージョンでコンパイルする必要があります。AssemblyLoadContextを使用していないためです。

詳細情報はこちらをご覧ください: [プラグインシステム + FramePFX API](https://raw.githubusercontent.com/AngryCarrot789/FramePFX/master/docs/Plugins.md) 

### 例
`AnotherTestPlugin` プラグインはテスト設定ページ（`ファイル > エディター設定を開く`にあります）を追加し、エクスポートダイアログに役に立たないテストエクスポーターも追加します。

ページの追加は非常に簡単で、プラグインの `OnApplicationLoaded` ハンドラーから実行可能です：

```cs
public override async Task OnApplicationLoaded() {
    ApplicationConfigurationManager.Instance.RootEntry.AddEntry(new ConfigurationEntry() {
        DisplayName = "Test Plugin Settings", 
        Id = "config.testplugineditorsettings",
        
        // This page is just a PropertyEditor page. 
        // Completely custom xaml pages are a bit wonky at the moment, 
        // only user controls will work properly due to resource dictionaries
        Page = new TestPluginConfigurationPage()
    });
}
```
これにより以下の結果となります：
![](https://raw.githubusercontent.com/AngryCarrot789/FramePFX/master/FramePFX-DesktopUI_2024-12-27_03.33.53.png)

# TODO
### Avaloniaリメイク：
- クリップ/トラックにドロップできるエフェクトリストのUIを実装する
### レンダリングエンジン
- port-audioにはアクセスできるものの、レンダリングエンジン全体の見直しが必要だと思います。  
  以前は、プロジェクトのフレームレートに基づいてクリップから正確なバイト数を抽出して音声をレンダリングしていました。  
  しかし、これにより再生FPSが正確でないため、多くのノイズが発生してしまいます。

  ビデオのレンダリングもやり直す必要があります。通常、ビューポートはかなり小さいですが、各クリップのフルサイズのビデオ  
  フレームをレンダリングしてから縮小しているためです。矩形や基本的なプリミティブ形状ならそれほど悪くありません。  
  しかし、MP4ファイルから4Kのビデオフレームをレンダリングし、それを1080p（またはクリップのMediaScale）に縮小し、  
  最終的にビューポート（通常約500x300サイズ）まで縮小するのは非常に無駄が多いです。  
  そのため、RenderFullとRenderPreviewのメソッド、または新しいレンダリングシステムが必要です。現在の非同期レンダリング技術は悪くなさそうです。
### オートメーションエンジン
- スムーズな補間（例：2つのキーフレーム間のカーブ）をサポートする機能を追加する。試みたものの、補間の数学的計算とUIのヒットテストが難しかったです。
### クリップ
- AVMediaVideoClipは高解像度のビデオ（例：4Kはデコードと画面描画に約40msかかる）で非常に遅く、  
  動作するビデオコーデックも限られています。多くの一般的なファイル形式では「デコード中に無効なデータを検出した」というエラーが出ます。  
  FFmpegについてはあまり詳しくありませんが、いつか何とかこれを修正したいと思っています。
- 2つのクリップ間のフェードを実装する
### 履歴システム
- まだアンドゥ機能はありません。音声やハードウェアアクセラレーションを使った最終フレームの組み立てなど、他の機能を実装した後に挑戦するかもしれません。
### 修正すべきバグ
- 特定のビデオファイルのインポートでレンダリングが失敗することがある（「デコード中に無効なデータを検出した」エラーのようなもの）
### マルチスレッド同期
- アプリケーションの状態へのアクセスと変更をより安全にするためにロックを作成する必要があります。特にアクティビティシステムが動作している今は重要です。

  モデルの状態に書き込みを行うためのアプリケーション全体のロックでしょうか？これはIntelliJ IDEAの仕組みに似ています。  
  ほとんどが読み取り用の読み書きロックで、書き込みロックはメインスレッドのみで取得可能（ディスパッチャを使ってそこに乗ります）、  
  しかし任意のスレッドが読み取りロックを取得できます。読み取りロックを取得するには書き込み操作が残っていないことを待ち、  
  書き込みロックを取得するにはすべての読み取りが完了するまで待つ必要があります（また書き込みロック取得時にイベントが発生し、  
  読み取り中の処理をキャンセルしてUIのフリーズを防ぐことができます）。

## 貢献について
貢献は大歓迎です！プルリクエストを作成するか、まずIssueを立ててからPRを作成してください。  
アプリのコンパイルや実行・デバッグ方法は少し上にスクロールすると見つかります。  
TODOリストは上記にありますが、コードベース内で`// TODO:`を検索しても見つけられます。
詳細な説明はdocsフォルダーにあります。ここではエディターのコア部分（コマンド、自動化など）について説明しています。  
まだ多くが未記載のため、すべてを説明しているわけではありません。  

コードベースは完璧ではないので、標準化のための支援は大歓迎です！  

# ライセンス  
FramePFXのすべてのソースファイルはGNU一般公衆利用許諾契約書バージョン3.0以降（GPL v3.0+）の下で配布されています。  
FramePFXはMIT/LGPLライセンスなどの他のライブラリも使用しています。  

もし著作権表示が欠けているソースファイルがあれば、FramePFXと同じライセンスの下で提供されているものとみなされます。  

現在使用されているLGPLの部分は以下の通りです：  
- FFmpeg.AutoGen（GNU一般公衆利用許諾契約書のより緩やかなバージョンであるLGPL v3.0の下でライセンスされています）  
- FFmpeg




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-28

---