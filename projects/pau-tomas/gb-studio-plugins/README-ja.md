# GB Studio 4.2 - プラグインパック

GB Studio 4.2向けの実験的なプラグインセットです。使用は自己責任でお願いします :)

> [!注意]
> 以前利用可能だった一部のイベントプラグインは非推奨となりました。これらの機能はGB Studioに組み込まれています。[以下のリストを参照](#deprecated-plugins)。

## ダイアログ＆メニュー

### ライフバー描画

オーバーレイ上の指定位置に（ライフ/パワー/マナ）バーを描画します。

- `X`, `Y`: オーバーレイ上のタイル座標。
- `Tileset`: バーのタイルが連続して含まれるタイルセット。
- `Tile`: タイルセット内のバーの最初のタイル（通常は空のタイル）。
- `Value`: バーで表現する現在の値。
- `Max Value`: バーで表現可能な最大値。
- `Steps`: バー内のアイテムを「満たす」のに必要なタイル数（空のタイルを除く）。

[サンプルプロジェクト](examples/Draw%20Lifebar/)

_注意:_ タイルセットはVRAMのタイル128番から読み込まれます（スプライトブロックの直後）。これにより、オーバーレイ上の`Draw Text`との組み合わせ描画が可能です。VRAMインデックスはプラグインファイル内の`const VRAM_BASE_START_TILE = 128`の行を編集することで変更できます。

<img width="300" alt="Draw Lifebar" src="https://raw.githubusercontent.com/pau-tomas/gb-studio-plugins/main/plugins/Draw Lifebar/screenshots/draw_lifebar.png"/>

<img width="300" alt="Draw Lifebar" src="https://raw.githubusercontent.com/pau-tomas/gb-studio-plugins/main/plugins/Draw Lifebar/screenshots/draw_lifebar_screenshot.png"/>

### 高度なメニュー表示

複数の選択肢からなるメニューを表示し、選択された項目の値を指定変数にセットします。`Items`タブでメニュー項目の位置やナビゲーション順を設定可能です。オプションで「B」ボタンで変数を「0」にしてメニューを閉じる設定や、最後のメニュー項目を選択した際に「0」を返す設定も可能です。ダイアログボックスのサイズ、開閉方向、メニューの位置（上または下）は`Layout`タブで設定します。メニューの開閉速度は`Behavior`タブで設定できます。

1項目あたりの最大文字数に制限はありませんが、表示可能な合計文字数はUIテキスト用に確保されたタイル数（非カラー モードでは52）によって制限されます。

_注意:_ 項目数が多いとイベントが非常に長くなることがあります。

<img width="300" alt="Advanced Menu Items" src="https://raw.githubusercontent.com/pau-tomas/gb-studio-plugins/main/plugins/Advanced Menu/screenshots/advanced_menu_items.png"/> <img width="300" alt="Advanced Menu Screenshot" src="https://raw.githubusercontent.com/pau-tomas/gb-studio-plugins/main/plugins/Advanced Menu/screenshots/advanced_menu_screenshot.png"/>

<img width="300" alt="Advanced Menu Layout" src="https://raw.githubusercontent.com/pau-tomas/gb-studio-plugins/main/plugins/Advanced Menu/screenshots/advanced_menu_layout.png"/>

## リアルタイムクロック

一部のGBカートリッジに搭載されているリアルタイムクロック機能にアクセスするための一連のイベント。

_注意:_ RTCを動作させるには、プロジェクト設定でカートリッジタイプを`MBC3`に設定する必要があります。

### 時計の時間を設定

リアルタイムクロックの各フィールドの値を数値または変数の値に設定します。

<img width="300" alt="Set Clock Time" src="https://raw.githubusercontent.com/pau-tomas/gb-studio-plugins/main/plugins/RTC/screenshots/set_clock_time.png"/>

### 時計の時間を変数に保存

現在の時間をそれぞれの値ごとに1つの変数に保存します。

<img width="300" alt="Store Clock Time In Variables" src="https://raw.githubusercontent.com/pau-tomas/gb-studio-plugins/main/plugins/RTC/screenshots/store_time_in_var.png"/>

### 時計を開始

リアルタイムクロックを開始します。

<img width="300" alt="Start Clock" src="https://raw.githubusercontent.com/pau-tomas/gb-studio-plugins/main/plugins/RTC/screenshots/start_clock.png"/>

### 時計を停止

リアルタイムクロックを停止します。

<img width="300" alt="Stop Clock" src="https://raw.githubusercontent.com/pau-tomas/gb-studio-plugins/main/plugins/RTC/screenshots/stop_clock.png"/>

## 画面

### スムーズフェード

**カラー表示モードのみ**

現在のシーンの背景またはスプライトのパレットの一部またはすべてを、白または黒の画面にフェードイン・フェードアウトさせ、色の値を補間して滑らかなフェードを実現します。

<img width="300" alt="Player Field Update" src="https://raw.githubusercontent.com/pau-tomas/gb-studio-plugins/main/plugins/Smooth Fade/screenshots/smooth_fade.png"/>

## β プラグイン

このカテゴリのプラグインは、上記のものよりもさらに実験的であり、将来的に変更される可能性があります。

- **Move Variable Actor To** と **Store Variable Actor Position n Variables**:
  - これらのイベントは既存のGB Studioのアクターイベントを複製していますが、アクターを選択するためのドロップダウンの代わりに変数を使用します。変数の値はシーン内のアクターのインデックスを表します（プレイヤーは常に `0` で、その他のアクターはシーンに追加された順にインデックスが割り当てられます）。

- **Pin Actor to Screen** と **Unpin Actor from Screen**:
  - アクターを現在の画面座標にピン留めまたはピン留め解除します。\nイベントが呼び出された時点で、アクターがすでにピン留めされているか解除されているかの状態に注意してください。そうでない場合、スクロール位置に基づいて位置が誤ってオフセットされます。

## インストール方法

`plugins` フォルダをプロジェクトにドロップしてください。上記のすべてのイベントが `Add Event` ボタンから利用可能になります。

## 他の作者によるプラグイン：

- [NalaFala (Yousurname) の GB Studio プラグインコレクション](https://github.com/Y0UR-U5ERNAME/gbs-plugin-collection)
- [Platformer+](https://github.com/becomingplural/GBS_PlatformerPlus)
- [Advanced Dialog and Menu vB](https://github.com/dochardware/Advanced-Dialog-and-Menu)
- [Shin の GB Studio プラグイン](https://github.com/shin-gamedev/gbs-plugins)
- [Gud GBS プラグイン](https://github.com/mikeleisz/gud_gbs_plugins)
- [Fade Street](https://gearfo.itch.io/fade-street)
- [Scroll Scene transition](https://github.com/Mico27/GBS-scrollScenePlugin) とその他の [Mico27 のプラグイン](https://github.com/Mico27/)

## 廃止されたプラグインイベント

以下のイベントプラグインは、機能がGB Studioにネイティブで追加されたため、Plugin Pakの一部としてはもう利用できません。

4.2以降：

- Player Field Update
- Store Player Field In Variable
- Store Camera Field In Variable

4.1以降：

- Display Advanced Dialogue
- Display Background Text
- Print Screen Background
- Mute Channel
- カメラフィールドの更新  
- ダイアログフレームの設定  
- アクターFX  

4.0以降:  

- ロックされたイベントグループ  
- ロック解除されたイベントグループ  


GB Studio 4.2以上を使用していない場合でも、上記は[こちら](https://github.com/pau-tomas/gb-studio-plugins/tree/4.1)で見つけることができます。4.0互換のプラグインは[こちら](https://github.com/pau-tomas/gb-studio-plugins/tree/4.0)をご確認ください。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-29

---