# ch32fun

[CH32V003](http://www.wch-ic.com/products/CH32V003.html)（およびCH32Vファミリ内の他の多くのチップ）向けのオープンソース開発環境（ツール、ヘッダ、サンプル）。gcc-riscv64でWindows（ネイティブ）、Linux、WSLで利用可能です。CH32V003は48MHz動作のRISC-V ECコア、16kBフラッシュ、2kB RAM、多数の周辺機能を搭載した10セント部品です。パッケージはSOP-8、QFN-20、SOICがあります。データシートは[こちら](http://www.wch-ic.com/downloads/CH32V003DS0_PDF.html)。

本プロジェクトの目的はCH32V003を効率的に活用するためのツールと環境を開発することです。複雑なHALを避け、ハードウェアを直接活用します！既存のEVTは非常に大規模で、開発環境も重いです。本プロジェクトはHALを明確に避け、[TRM](http://www.wch-ic.com/downloads/CH32V003RM_PDF.html)のみで使用できるようにしています。比較として、ch32funのblinkyはわずか500バイト、起動も速く、全体的に大幅にシンプルです。

ch32funには以下が含まれます：
1. ch32funを使ったサンプル（HALほど多くはありません）。主にch32v003向けですが、多くは他のプロセッサでも互換性があります。
2. WCH CH-Linkをlibusb経由で使う「minichlink」クロスプラットフォームツール。
   * STM32F042プログラマ [NHC-Link042](https://github.com/NgoHungCuong/NHC-Link042)
   * ESP32S2プログラマ [esp32s2-funprog](https://github.com/cnlohr/esp32s2-cookbook/tree/master/ch32v003programmer)
   * 公式WCH Link-Eプログラマ
   * Arduinoベースのインターフェース [Ardulink](https://gitlab.com/BlueSyncLine/arduino-ch32v003-swio)
   * Visual Studio用のgdbserver風デバッグ対応
   * printfのシングルワイヤ対応（約400kBaud）
3. `misc/libgcc.a`に配置したlibgccのコピー（珍しいrisc-vビルドチェーン利用時用）
4. 「ch32fun」フォルダ（ch32v003向け自己完結型ソースファイル・ヘッダファイル格納）
5. 一部システムでのprintfバック送信機能
6. デモ用ブートローダ

## その他ファミリーのサポート

現在、ch32v103、ch32v203、ch32v208、ch32v303、ch32v305、ch32v307を実験的にサポート。GDBは主に003でテストされていますが、他プロセッサでも限定的に動作します。

## はじめに

インストール／セットアップ手順は[wikiページ](https://github.com/cnlohr/ch32fun/wiki/Installation)をご覧ください。

## 特徴！

### プログラミングインターフェース経由の高速「printf」デバッグ

「高速」とは本当に速いことを意味します。通常36kBytes/sec程度。

```
./minichlink -T | pv > /dev/null
Found ESP32S2 Programmer
 536KiB 0:00:15 [36.7KiB/s] [        <=>                     ]
```

debugprintfプロジェクトを試すか、SetupDebugPrintf();を呼び出し、printf()で出力できます。

### デバッグサポート！

minichlink内蔵のgdbserver経由でデバッグ可能！`gdb-multiarch`やVisual Studio Codeでも動作します。

## ビルドと書き込み

```
cd examples/blink
make
```

text = コード、data = 定数と初期化値、bss = 未初期化値。  
decは3つの合計で、プログラムがフラッシュで占有するバイト数です。

生成される.binはminichlinkで利用、.hexは公式WCHフラッシュツールで互換性あり。

## VSCode +/- PlatformIO

注意：PlatformIOは本リポジトリで主にCI用途で使われています。PlatformIOでch32funプロジェクトをVSCode内でコーディング・デバッグすることもできますが、PlatformIOなしでも完全に可能です。[テンプレートプロジェクト](https://github.com/cnlohr/ch32fun/tree/master/examples/template/.vscode)を参照してください。

このプロジェクトはVSCode＋PlatformIO拡張でビルド・書き込み・デバッグが可能です。プロジェクトをクローンしてVSCodeで開き、PlatformIO拡張をインストールしてください。[プロジェクト環境スイッチャ](https://docs.platformio.org/en/latest/integration/ide/vscode.html#project-tasks)で「blink」など特定のサンプルを選択できます。

ch32funベースの新規PlatformIOファームウェアプロジェクトは、[PlatformIO Home](https://docs.platformio.org/en/latest/home/index.html)の「New Project」ウィザードで「Framework」を「ch32v003fun」に設定します。[各種サンプル](https://github.com/Community-PIO-CH32V/platform-ch32v/tree/develop/examples/blinky-ch32v003fun)も参照ください。

![pio_proj](https://raw.githubusercontent.com/cnlohr/ch32fun/master/.github/pio_project_creation.png)

同等の[PlatformIO Core CLI](https://docs.platformio.org/en/latest/integration/ide/vscode.html#platformio-core-cli)コマンドは
```sh
pio init -b genericCH32V003F4P6 -O "framework = ch32v003fun"
```

コードをch32funプロジェクトへ直接追加したい場合、`platformio.ini`の環境を[手順通り](https://raw.githubusercontent.com/cnlohr/ch32fun/master/platformio.ini#L48-L53)に拡張してください。

また、PlatformIOでこのプロジェクトを開いた場合は、VSCodeタスクバー下部の[プロジェクト環境スイッチャ](https://docs.platformio.org/en/latest/integration/ide/vscode.html#project-tasks)で特定のサンプルフォルダを選択できます。選択しない場合、「Build」実行時は**全て**のサンプルがビルドされます。

詳細・インストールは[platform-ch32v](https://github.com/Community-PIO-CH32V/platform-ch32v)を参照ください。

## clangd

C/C++言語サーバclangdが`ch32fun.h`を見つけられない場合、サンプルを`make clean`で初期化し、`bear -- make build`で一度ビルドしてください。これによりclangdがMakefile指定のインクルードパスを探せる`compile_commands.json`が生成されます。  
`make clangd`で一手に完了します。
`build_all_clangd.sh`は`build scripts`内で全サンプルに対して実行します。

## クイックリファレンス
 * **必須** プログラミング・デバッグ用：`SWIO`は`PD1`。PD1の多重利用は不可。
 * **オプション** `NRST`は`PD7`。不要。設定によってはGPIOとしてデフォルト動作。
 * **オプション** UART `TX`は`PD5`。`printf`デバッグにはSWIOの利用推奨。

![ch32v003a4m6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003a4m6.svg)
![ch32v003f4p6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003f4p6.svg)
![ch32v003f4u6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003f4u6.svg)
![ch32v003j4m6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003j4m6.svg)

## さらにサンプル／プロジェクト？

サードパーティ製ツールでも多くのサンプルが追加されています。追加ライブラリ等は下記リポジトリ参照。
 * [ch32v003fun_wildwest](https://github.com/recallmenot/ch32v003fun_wildwest)
 * [ch32v003fun_libs](https://github.com/hexeguitar/ch32v003fun_libs)
 * [CH32V003_lib_uart](https://github.com/ADBeta/CH32V003_lib_uart)
 * [CH32Vxxx_lib_i2c](https://github.com/ADBeta/CH32Vxxx_lib_i2c)
 * [CH32Vxxx_lib_swi2c](https://github.com/ADBeta/CH32Vxxx_lib_swi2c)
 * [ch32v003fun_shenanigans](https://github.com/DeadBugEngineering/ch32v003fun_shenanigans)
 * [ch32fun-bmp280-driver](https://github.com/pabloestrado/ch32fun-bmp280-driver)
 * [ch32fun-aht20-driver](https://github.com/pabloestrado/ch32fun-aht20-driver)

## サポート

GitHubのissueを開くか、Discordの #ch32fun チャンネルに参加ください。現在招待はプライベートなので、@cnlohr 宛てに招待リンクをリクエストしてください。PMも開放しています。

### 脚注／リンク

 * https://raw.githubusercontent.com/openwch/ch32v003/main/RISC-V%20QingKeV2%20Microprocessor%20Debug%20Manual.pdf デバッグマニュアル
 * http://www.wch-ic.com/downloads/QingKeV2_Processor_Manual_PDF.html プロセッサマニュアル
 * http://www.wch-ic.com/downloads/CH32V003RM_PDF.html テクニカルリファレンスマニュアル
 * http://www.wch-ic.com/downloads/CH32V003DS0_PDF.html データシート
 * https://github.com/CaiB/CH32V003-Architecture-Exploration/blob/main/InstructionTypes.md このチップの圧縮ISAの詳細
 * CH32V003はxv拡張を持つため、命令用にカスタマイズされたrvcodec.jsを利用可能：https://xw.macyler.moe/

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---