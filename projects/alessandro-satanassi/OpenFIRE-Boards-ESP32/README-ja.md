## ... EPS32用OpenFIRE-Boardsの移植

このリポジトリは、TeamOpenFIREのオリジナルプロジェクト「OpenFIRE-Boards」をESP32S3マイクロコントローラーで動作するように移植したものです。  
いくつかの適応と小さな変更を除き、コードはTeamOpenFIREのオリジナルにほぼ忠実です。  
このリポジトリのコードはRP2040マイクロコントローラーでも動作します。  
TeamOpenFIREのオリジナル「OpenFIRE-Boards」プロジェクトに変更が加えられた場合は、それに応じてこのリポジトリのコードも更新します。  
「OpenFIRE-Boards」プロジェクトを作成したTeamOpenFIREに心から感謝します。すべての功績と感謝の気持ちは彼らにあります。  
これは単にESP32S3で動作させるための適応です。  

This repository is a porting of the original 'OpenFIRE-Boards' project by TeamOpenFIRE, adapted to work on the ESP32S3 microcontroller.  
Apart from some adaptations and minor adjustments, the code remains largely faithful to the original by TeamOpenFIRE.  
The code in this repository also works on the RP2040 microcontroller.  
Whenever changes are made to the original 'OpenFIRE-Boards' project by TeamOpenFIRE, I will update the code in this repository accordingly.  
I sincerely thank TeamOpenFIRE for creating the 'OpenFIRE-Boards' project; all credit and gratitude go to them for their work.  
This is simply an adaptation to make it work on ESP32S3.  

![Waveshare-esp32-s3-pico](https://github.com/user-attachments/assets/2ce848f3-f308-43cc-b753-3b1dac1647e4)  

![YD-esp32-s3-wroom1-DevKitC-1-N16R8](https://github.com/user-attachments/assets/080baf9b-f050-4b3e-ba59-4fb4aa784909)  


## ... 以下はオリジナルプロジェクトページの内容です  
## ... follows the original project page  

# OpenFIRE-Boards  
OpenFIREファームウェアとデスクトップアプリ間で共有されるボードの共通リポジトリ  

# OpenFIRE Shared Resources  
このリポジトリには、マイクロコントローラファームウェアの実装と、それらとインターフェースし設定するためのPC向けアプリケーション間で共有可能なリソースが含まれています。  

## `OpenFIREshared.h`  
このファイルの上半分は、ファームウェアとアプリの両実装で共通の以下を定義しています：  
 - マイクロコントローラが初回ドッキング時に報告するボード名の定義（文字列リテラル）。  
 - ピン機能タイプ、トグル、設定、I2Cデバイスおよびその設定、ファームウェアとアプリ間のシリアル通信で使用されるコマンドの列挙。  
 - 起動時にロードされ、デフォルトのボードレイアウトを表示するアプリが参照する定義済みボードのプリセット。  

`OF_APP`のプリプロセッサチェック以下には、サポートされるボードとピン機能の「見た目」の文字列、ならびにデスクトップアプリのみが使用するボードレイアウトがあり、定義済みボードのGPIOピンをグラフィカルに表現します。これらは、中心基準のボードベクターに対してどこに描画すべきか、またユーザーに提示すべきオプションとしてアプリが提示する代替レイアウトがある場合に示します。  

### `boardPresetsMap`

サポートされているボードは、ファイルの先頭で定義されている `OPENFIRE_BOARD` 定義に対応する名前を持ち、その後に各GPIOがデフォルトでどの機能を持つべきかのマップが続きます（これはボードの現在の設定で `OF_Prefs::toggles[OF_Const::customPins]` が *true* に設定されているときに読み込まれます）。マイクロコントローラが持つすべてのGPIOがここに表現されるべきで、マップされていないピンは `btnUnmapped`、予約済みまたはユーザーに公開されていないピンは `unavailable` と指定します。RP2040 および RP235X-A ボードは最大で30ピンまでとし、`rpipico` が約26ピンのみを公開していても、隠されたGPIOも考慮に入れられます。

### `boardBoxPositions`
`boardPresetsMap` と同様に、各サポートされている `OPENFIRE_BOARD` に対して、デスクトップアプリのグラフィカルなボードビューで各ピンがおおよそ *どこに* 配置されるべきかを示すマップです。値は2つの合計値で表され、左側が1から始まる正の整数による相対位置、右側がピン要素を配置すべきボードの面を示す列挙値です。`posLeft`、`posRight`、`posMiddle` を加えると、それぞれボードビューの左、右、中間にGPIOを配置し、`posNothing`（文字通り0）を加えるとアプリにそのピンを表示しないことを伝えます。これは `boardPresetsMap` の `unavailable` ピンに使われるべきです。値の数はプリセットマップで定義されたGPIOの数と一致する必要があります。

### `boardsAltPresets`
これはオプションの代替ボードプリセット用で、ボードレイアウトビューで代替レイアウト名のドロップダウンリストとして表示されます。各サポートされている `OPENFIRE_BOARD` は複数回リストアップ可能で、各代替レイアウトごとに1つずつ、ボード名の後の文字列はインターフェースに表示されるラベルを示し、その後に `boardPresetsMap` と同様のGPIOボード機能のマップが中括弧で続きます。同じ慣習と制約が適用されます。これは主に、例えば `adafruitItsy` のSAMCO 1.1レイアウトのように、推奨されるボタンマッピングや配線が異なるアダプタボードのレイアウトに合わせるために意図されています。また、現在のリファレンスデスクトップアプリはカスタムレイアウトのエクスポートとインポートをサポートしています。

## `boardPics/` - ボードベクターとピンのハイライト
これはデスクトップアプリがボードレイアウトビューで現在接続されているボードをグラフィカルに表現するために使うボードベクターのリポジトリです。ボードベクターは *Plain SVG*（または同等のもの）としてエクスポートし、`vectors.qrc` リソースファイルに追加します。各ファイルのエイリアスは `OpenFIREshared.h` の `OPENFIRE_BOARD` 文字列で定義された名前と一致させる必要があります。

現在のリファレンスデスクトップアプリは、ユーザーがインターフェース上のGPIOピンアイテムにマウスをホバーしたときに *ハイライトされたピン* を表示できます。これを行うには、SVGを以下のように変更する必要があります（主に Inkscape を例とします）：
 1. もしまだなら、画像の既存のボードオブジェクトをすべて1つのグループにまとめます（名前は問いません）。また、ピンの穴が実際に透明で背景色で塗りつぶされていないことを確認してください。
 2. ボードグループの *下* に新しいグループを作成します。これも名前は問いませんが、使いやすさのために `OF` と名付けるのが良いでしょう。
 3. 新しく作ったハイライトグループ内に、ストロークなし、単一の平坦な色の塗り（既存のボードはRGBA `ebe713`、つまり *R253/G231/B19*）でハイライト要素を作成します。
 4. ハイライト要素を選択し、*オブジェクトプロパティ* タブ（または *ID* 行が表示される同等のもの）に行きます：各ハイライト要素は `OF_pinX` というIDを持つ必要があります。ここでXはGPIOピン番号で、先頭の0はありません。
 5. 要素が選択された状態で、*塗りとストローク* タブ（または *不透明度（％）* が表示される同等のもの）に行き、不透明度を **0.0** に設定します。
 6. 配置、名前付け、不透明度が満足いくものになったら、ファイルを ***Plain SVG*** として `boardPics` ディレクトリ内に保存します。`vectors.qrc` にこのボードが `OpenFIREshared.h` で設定した `OPENFIRE_BOARD` 文字列のエイリアスとしてリストされていることを必ず確認してください！

> [!注意]
> この手順は、ボードの *アクセス可能な* GPIOピンに対して **のみ** 行うべきです（つまり `boardPresetsMap` で `unavailable` とされているピンは追加しないでください。これらはアプリケーションによって非表示にされます）。

これが完了したら、アプリケーションを再ビルドし、ボード画像をテストします。最も簡単な方法は、*ヘルプ -> 対応ボードを見る* ウィンドウを使い、GPIOに対応するラベルにマウスカーソルをホバーすることです。

> [!注意]
> - ボード画像がまったく表示されない場合、ベクターの名前が適切でないか、正しくエクスポートされていない可能性が高いです。上記のステップ6を正しく実行したかを再確認してください。
> - ボード画像は表示されるがハイライトが表示されない（または誤ったピンに表示される）場合、エクスポートしたSVGをテキストエディタ（例：Notepad）で手動編集する必要があるかもしれません。ベクターが動作するための技術的要件とチェックすべき点は以下の通りです：
>   - `id="OF_pinX"` の行が `style="` の行の *上* にあること。
>   - `style="` の行に `opacity:0` が含まれていること（`0` または `0.0` のいずれでもよいが、一貫していること）。
> 以下の例（[`pico.svg`](https://raw.githubusercontent.com/alessandro-satanassi/OpenFIRE-Boards-ESP32/main/boardPics/pico.svg) からの抜粋）は各ハイライト要素の理想的なフォーマットの一例です：
> ```html
>   <g
>      id="OF">
>     <path
>        id="OF_pin1"
>        style="opacity:0;fill:#ebe713;fill-opacity:1"
>        class="st10"
>        d="M19.7,47.4c0,3.4-2.9,6.2-6.3,6.2s-6.2-2.8-6.3-6.2,2.7-6.3,6.1-6.4c3.4,0,6.3,2.6,6.5,6" />
>     <path
>        id="OF_pin2"
>        style="opacity:0;fill:#ebe713;fill-opacity:1"
>        class="st10"
>        d="M19.8,88.1c0,3.4-2.9,6.2-6.3,6.2s-6.2-2.8-6.3-6.2c0-3.4,2.7-6.3,6.1-6.4,3.4,0,6.3,2.6,6.5,6" />
> ...
> ```




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-11

---