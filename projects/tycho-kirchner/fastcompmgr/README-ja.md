# fastcompmgr

__fastcompmgr__ は X 用の _高速_ コンポジターであり、__Compton__ の初期バージョンのフォークで、
それは __xcompmgr-dana__ のフォークであり、さらに __xcompmgr__ のフォークです。

私は長い間古き良き xcompmgr を使っていました。なぜなら、compton は
ウィンドウの移動/リサイズやウェブページの慣性スクロール時に
少し遅延を感じていたからです。最新の picom-10.2 を試してみると、状況はさらに
悪化しているようでした（下記のベンチマーク参照）。しかし、xcompmgr は argb ウィンドウ（例：一部の端末）に
影を描画せず、他にもいくつかの不具合があります。そこで私は 2011 年まで遡り、
この機能が追加された時点のコードを取り出し、後の compton のコミットからいくつかを選んで
不要なセグフォルトやメモリリークを取り除き、プロファイリングに基づいてそのバージョンをさらに
高速化しました。
例えば、ウィンドウの移動およびリサイズイベントはイベント数を制限し、
ある程度固定のフレームレートで描画される一方で、
スクロールは可能な限り高速に行われます。隠れているウィンドウは描画されず、
メモリの割り当て/解放は大幅に回避されているため、
画面の再描画が高速になります。
欠点としては、フェード機能は現在壊れており（私は使っていません）、申し訳ありません (; 

## ベンチマーク
私の Dell Latitude E5570 上でのウィンドウの移動、リサイズ、スクロールは
明らかに高速に「感じられ」、この観察を裏付けるいくつかの数値もあります。
複数の chromium ウィンドウを重ねた状態で、どのウィンドウも完全に隠れていない状況で、
それぞれの操作を *手動で* 実施しましたので、
このベンチマークはあまり高度ではないことにご注意ください。慣性スクロールを可能にする
タッチパッドドライバー `xserver-xorg-input-synaptics` を使用しました（Wayland はどうでしょう？）。
以下の CPU 使用率が計測されました：

| コンポジター    | 移動  | リサイズ  | スクロール |
| ------------- | ----- | ------- | ------ |
| fastcompmgr   | 6.7%  | 4.4%    | 1.5%   |
| xcompmgr      | 7.8%  | 4.9%    | 1.6%   |
| compton       | 26.4% | 6.8%    | 17.1%  |
| picom         | 29.3% | 8.1%    | 23.1%  |





ツールは以下のフラグで使用されました：
~~~
(v0.1) fastcompmgr -o 0.4 -r 12 -c -C
(v1.1.8 from Debian 11) xcompmgr -o 0.4 -r 12 -c -C
(v1 from Debian 11) compton --config /dev/null --backend xrender -o 0.4 -r 12 -c -C
(v10.2) picom --config /dev/null --backend xrender -o 0.4 -r 12 -c

# 平均を計算するには
$ fastcompmgr -o 0.4 -r 12 -c -C &  pid=$!; sleep 4; \
    top -b -n 20 -d 0.5 -p $pid | LC_ALL=C awk -v pid=$pid \
    '$1==PID {++PIDCOUNT} $1==pid && PIDCOUNT>1 {print $9}' |  \
    datamash mean 1; kill $pid
~~~



## インストール
面倒な場合は、[リリースページ](https://github.com/tycho-kirchner/fastcompmgr/releases)からバイナリを入手してください。

それ以外の場合は、以下の開発版ライブラリをインストールしてください：
### 依存関係：

* libx11
* libxcomposite
* libxdamage
* libxfixes
* libxrender
* pkg-config
* make

ビルド方法：

~~~ bash
$ make
$ make install
~~~

## 使い方

~~~ bash
$ fastcompmgr -o 0.4 -r 12 -c -C
~~~
すべてのオプション（現在フェード機能は動作しません）:
~~~
   -d display
    管理するディスプレイを指定します。
   -r radius
    影のぼかし半径。（デフォルト 12）
   -o opacity
    影の透過度。（デフォルト 0.75）
   -l left-offset
    影の左オフセット。（デフォルト -15）
   -t top-offset
    影の上オフセット。（デフォルト -15）
   -m opacity
    メニューの不透明度。（デフォルト 1.0）
   -c
    ウィンドウのクライアント側影を有効にします。
   -C
    ドックやパネルウィンドウに影を描画しないようにします。
   -i opacity
    非アクティブウィンドウの不透明度。（0.1 - 1.0）
   -e opacity
    ウィンドウのタイトルバーと枠線の不透明度。（0.1 - 1.0）
    --shadow-red value
    影の赤色値（0.0 - 1.0、デフォルトは0）。
    --shadow-green value
    影の緑色値（0.0 - 1.0、デフォルトは0）。
    --shadow-blue value
    影の青色値（0.0 - 1.0、デフォルトは0）。

~~~


## ライセンス

xcompmgr は広く使われてきました。私が確認できる限り、この
特定の系統の系譜は以下の通りです:

* Keith Packard（オリジナル作者）
* マシュー・ホーン  
* ...  
* ダナ・ジャンセンス  
* クリストファー・ジェフリー  
* タイコ・キルヒナー  

途中でフォークした数十人は含まれていません。  

詳細はLICENSEをご覧ください。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-17

---