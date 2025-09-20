
<div align="right">
  <details>
    <summary >🌐 言語</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Xbox_SMC
オリジナルXboxからのPIC16/Xyclopsダンプと、逆アセンブル済みのIDAデータベースを含み、一部リバースエンジニアリングが行われています。

![オリジナルXboxのPIC16LC63Aの画像](https://raw.githubusercontent.com/Prehistoricman/Xbox_SMC/master/pic16lc63a.jpg)

# Xyclopsのフラッシュ方法（XycloMod）
[「Xyclops」ディレクトリとREADME](/Xyclops) をご覧ください。

# ダンプ
各PICダンプの .bin ファイルは、IDAに正しく読み込めるようにバイトが入れ替えられています。つまり、PICメモリの最初のワードは byte_0 + byte_1 << 8 です。

.idb のIDAデータベースには、変数情報やデータベースノートパッド上のいくつかの観察事項が記載されています。

SMCバージョンの詳細については、このWikiページを参照してください: https://xboxdevwiki.net/Xboxen_Info

## B2A
DVT3 Xboxからダンプされたものです。P01と同じコンフィグワードです。また、製品版PICとは異なり、コンフィグ領域にデバイスIDが 0000 0000 000B 002A として書き込まれています。

ブートチャレンジが完全に省略されています。

## D01
XDK BETA 2 Xboxからダンプされたものです。ブートチャレンジが省略されている点以外はP01と同一です。期待されるブートチャレンジレスポンスを計算する関数は残っていますが、一度も呼び出されません。

## DXF
XDK D2 デバッグキットからダンプされたものです。D01と非常に似ていますが、トレイロジック、過熱ロジック、ブートロジックが若干異なります。ブートチャレンジの省略方法はD01と同じです。

## D2E
Tuscany (v1.6) 開発キットからダンプされたものです。Xyclopsチップは X01202-001 とマークされており、リテールユニットにある A-A02 または A-B01 ラインがありません。

FC00のデバッグシリアルコードはリテールP2Lダンプと一致します。0x4000 から 0xFBFF まで奇妙なデータパターンがあります。

## P01
v1.0 Xboxからダンプされたものです。コンフィグワードは0x86です:
- CP1:CP0 = 0（メモリ全体のコード保護が有効）
- BODEN = 0（ブラウンアウトリセット無効）
- ~PWRTE = 0（パワーアップタイマー有効）
- WDTE = 1（ウォッチドッグタイマー有効）
- FOSC1:FOSC0 = 2（HSオシレータ）

SMCクローンではコード保護を無効にするために、0x3FB6 のコンフィグ値が適しています。

## P11
v1.3 Xboxからダンプされたものです。P01と同じコンフィグワードです。

P01と比べてP11にはいくつかの小さな変更があり、追加のSMBusコマンド（0x22の書き込み）、LED優先順位の違い、ブートのタイミング緩和などがあります。

v1.3とv1.4のスクランブルダンプを比較したところ一致しました。これは、両方が同じプログラムを持っている可能性が非常に高いことを意味します。

## P2L
v1.6 Xboxからダンプされたもの。XyclopsリビジョンA-A02。Intel 8051コードを含むが、機能不明の特殊機能レジスタが多数ある。

デバッグシリアルはFC00のコードによって動作する。実行を一時停止したり、データをダンプしたり、レジスタ/RAMへ書き込むなど、粗いデバッガのようだ。

# Xyclopsダンピング

Xyclopsチップには「デバッグ」用のピンが3つある：TXD（ピン64）、RXD（ピン63）、DEBUG（ピン29）。DEBUGピンをHighにするとTXとRXピンのシリアルポートが有効になる。シリアルは9600ボーで動作する。

プロトコルは通常4バイトコマンドに基づいており、フォーマットは `<cmd>` `<address MSByte>` `<address LSByte>` `<don't care>` となっている。

コマンド0x14は一度に64バイトのBIOSデータをダンプし、0x15は一度に64バイトのSMCプログラムデータをダンプする。XyclopsからのダンプP2L.binがリポジトリに含まれている。[xyclops_dumper.py](/Xyclops/xyclops_dumper.py)も同梱されており、自分のマシンをダンプできる。

# PICダンピング手法
詳細は https://wiki.recessim.com/view/PIC_Burnout

PICはコードプロテクションが有効になっており、全データが0000として読み出される。いくつかのトリックを使って代わりにスクランブルされたデータを出力させ、犠牲チップを使ってスクランブルアルゴリズムを発見し、さらにROMデータをエクスプロイトでいくつかのビットを既知値に変更した。こうして複数回スクランブルダンプから必要な情報を抽出し、元データを復元できた。

# PICProgrammer
PICProgrammerは、私の研究で使用したRP2040用Arduinoプロジェクトのひとつ。PIC上でICSP（インサーキットシリアルプログラミング）操作を実行する簡易コマンドラインインターフェイスを提供する。柔軟性やメーカー非推奨の操作が可能なため、PICkitなどの専用プログラマより好まれる。

使用前に電子工学とプログラミングの十分な理解が必要であり、コマンド実行前にはその内容をよく確認すること。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-20

---