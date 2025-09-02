<p align="center">
  <img src="https://raw.githubusercontent.com/BarkyTheDog/catclock/master/catclock.gif">
</p>

catclock
========

これはX Window Systemのxclockプログラムのバージョンで、「キャットモード」が追加されています。もともとはTony Della Fera（MIT-Athena、DEC）、Dave Mankins（MIT-Athena、BBN）、Ed Moy（UC Berkeley）によるX10プログラムで、Deanna Hohnと私（Digital Equipment Corporation）が1980年代後半に自分たちの楽しみのために作成しました。グラフィックは有名で象徴的なKit-Cat（R）時計に触発されたもので、私の台所にもまだ一つ掛かっています。今年がX10導入30周年であることを記念して、また楽しいデスクトップ玩具としてGitHubに公開しました。

我々の改良以降、コードはほとんど変更されておらず、主に現在のより厳しいコンパイラに対応するためのものです。現在では様々なLinuxディストリビューション、Cygwin、OS X（XQuartz）でコンパイルと実行が可能で、Makefileの変更はMacportがX関連ファイルを/opt/localにデフォルトインストールするために必要になったものだけです。Imakefileはかなり古く、まだ動作させる試みはしていません—現在は「歴史的」な理由でのみ含まれています。元のreadmeファイルはreadme_originalという名前で、こちらも歴史的な理由で含まれています。

キャットモードに加え、このxclockのバージョンにはアラーム機能と毎時チャイム機能が含まれています（詳細はマニュアルを参照）。さまざまなXのデフォルト設定やコマンドラインスイッチで猫の色を制御できます。マシンのX設定に応じてMakefileのヘッダーやライブラリパスを変更する必要があるかもしれません。唯一の「非標準」依存はMotifで、これはお使いのパッケージマネージャーから簡単に入手可能です。

## テンポトラッキング

このバージョンは音楽のテンポを追跡し、猫の目と尾を音楽に同期して動かすことができます。
テンポトラッキングを有効にしてビルドするには、テンポトラッキングを動作させる追加のライブラリが必要です：

```bash
sudo apt install libaubio5 libaubio-dev
```

テンポトラッカーを有効にしてコンパイルするには、`WITH_TEMPO_TRACKER=1` オプションを使用してください：

```bash
make WITH_TEMPO_TRACKER=1
```

"cat"モードでクロックを実行した後、PulseAudioミキサー（例えば `pavucontrol`）を起動し、「録音」タブで解析する音声ソースを選択します。

## 使用方法

```
xclock [toolkitoptions]
       [-mode <analog, digital, cat>]
       [-alarm]  [-bell]  [-chime]
       [-file <alarm file>]  [-period <seconds>]
       [-hl <color>]  [-hd <color>]
       [-catcolor <color>]
       [-detailcolor <color>]
       [-tiecolor <color>]
       [-padding <pixels>]
       [-update <seconds>]
       [-ntails <number>]
       [-help]
```

お楽しみください！


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-02

---