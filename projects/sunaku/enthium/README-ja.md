# Enthium - Engrammer と Hands Down Promethium の融合

![Enthium v7をGlove80キーボードで撮影した写真](
https://github.com/sunaku/glove80-keymaps/raw/main/README/base-layer-photograph-Enthium.jpg
)

この [Engrammer] と [Hands Down Promethium] キーボードレイアウトの改良版は、後者のキーボードレイアウトアナライザーでのパフォーマンス（下記参照）を向上させるために、水平方向にミラーリングし、[Arno's Engram 2.0] レイアウト（左手ホームポジションにCIEA配置、PFとWVをEngram同様にスワップ）と [Dvorak] レイアウト（右手ホームポジションにHTNS配置）への親しみやすさを回復し、またEngrammerレイアウトの精神に則りプログラミング向け句読点の配置を最適化しています。

特筆すべきは、Engram/merとEnthiumの違いは極めてわずかであり、[KeyBr] トレーニングですべての文字を解放するために、2～3日（例えば金曜から開始して週末に練習）にわたり合計約6時間ほど練習すれば、完全に切り替え可能です。

このキーボードレイアウト開発に至った「ラビットホール」な予想外の旅路については、[私のブログ記事](https://sunaku.github.io/enthium-keyboard-layout.html)もご覧ください。

[Hands Down Promethium]: https://reddit.com/r/KeyboardLayouts/comments/1g66ivi
[Arno's Engram 2.0]:     https://engram.dev
[Engrammer]:             https://github.com/sunaku/engrammer
[Dvorak]:                https://www.dvzine.org
[KeyBr]:                 https://github.com/aradzie/keybr.com#readme

## レイアウト

      q y o u - x l d w z
    b c i e a , k h t n s v
      ' / = . ; j m g p f
                r

>![Enthium v7 をノートパソコンキーボード上でレンダリングした図](https://raw.githubusercontent.com/sunaku/enthium/main/linux/layout.png)
>![Enthium v7 をGlove80キーボードでレンダリングした図](
https://github.com/sunaku/glove80-keymaps/raw/main/README/base-layer-diagram-Enthium.png
)

<!-- vim-markdown-toc GFM -->

* [根拠](#rationale)
  * [逸脱: PF と WV](#deviation-pf-and-wv)
  * [逸脱: B と V](#deviation-b-and-v)
* [パフォーマンス](#performance)
  * [Cyanophageアナライザー](#cyanophage-analyzer)
  * [KeySolveアナライザー](#keysolve-analyzer)
  * [Oxeyアナライザー](#oxeys-analyzer)
  * [比較](#comparison)
* [インストール](#installation)
  * [Linuxセットアップ](#linux-setup)
  * [MacOSセットアップ](#macos-setup)
    * [インストール](#installation-1)
    * [複雑な修飾](#complex-modification)
    * [アンインストール](#uninstallation)
* [ライセンス](#license)

<!-- vim-markdown-toc -->

## 根拠

* QとZはバランスと対称性のために左右の手に分けて配置しています。

* BとVはホームポジションの小指横（CapsLockやアポストロフィ）に配置し、小指が短い方や[小指が弱い方]でも上段に手を伸ばさずに済むようにしています。

* アポストロフィはYOUやIから離れた全く別の指に配置し、`you'd`や`I'd`などの同指連続打鍵を回避しています。

* カンマとセミコロンはVimのf/F/t/T検索の連続利用や、右手のKとJの相対配置を模倣するために隣接させています。

* ピリオドとカンマはシフト時の記号 `>` と `<` の点では逆ですが、この配置により横方向のストレッチ連続打鍵を減らし、また伝統的な段違い配列では縦に積み重なる形になります。

* マイナスは人差し指（カンマ、ピリオド、セミコロンと同様）に配置し、語/文区切り記号の一貫性や、プログラミングで頻出する `_` アンダースコアへのアクセス性を高めています。特に段違い配列では人差し指の自然な伸び方向に配置され、負担が減ります。

* スラッシュとピリオドにより、`/.`, `./`, `../` のファイルパス入力がスムーズです。

[小指が弱い方]: https://reddit.com/r/KeyboardLayouts/comments/1fy8nve/_/lqulnww/

### 逸脱: PF と WV

PFをWVと入れ替えることで、以下の不便を解消しています：

* WNは階段状の昇順同指ビグラムで、本来なら下方向に払いたい
* DW（2uスキップ）は、Engramのように隣接していればVimで便利だった
* FG（2uスキップ）は、Engramのように隣接していればシェルのバックグラウンドジョブ（`bg`, `fg`）で便利だった
* SW（半はさみ）は、Engramのように上に伸ばすより内側に曲げる方がやや弱い
* FF（例: "stu*ff*"）は上段小指の連打がやや負担

本当は標準のHands Down Promethiumレイアウトから逸脱したくなかったのですが（この「Enthium」派生は単純な水平ミラー＋句読点微調整のみのはずでした）、やむなくキーボードレイアウトアナライザーでPFとWVを入れ替えた場合の影響を調べてみたところ、驚くほど影響はほぼありませんでした：

* Oxeyアナライザーでは統計値に全く変化なし！
* KeySolveアナライザーではFSBが0.14%→0.37%に増えたものの、他は改善：FSSが0.82%→0.48%、HSBが6.05%→5.64%、HSSが5.97%→5.50%に減少。他は同じ。
* CyanophageアナライザーのTotal Word Effortは730.9→735.9に増加したものの、他は同じ！

この実験がうまくいったのは本当に嬉しいです。実運用でもより快適になり、EngrammerからEnthiumへの移行障壁も一層下がるでしょう。 :)

### 逸脱: B と V

BとVは上段からホームポジション小指横に回し、[小指が弱い方]や短い方でも上段に手を伸ばさずに済むようにしています。これらのキーには英語で最も使用頻度が低いQとZを割り当てました。

Cyanophageアナライザーでは、この変更によりPinky/Ring Scissorsが0.49%→0.35%（大幅減少）、Skip Bigrams (2u)が0.30%→0.29%となりました。他のアナライザーは小指横キーの扱いを十分理解していませんが（各アナライザーの冒頭注記参照）、OxeyアナライザーでもSFBが0.829%→0.818%と減少しています。

## パフォーマンス

### [Cyanophageアナライザー][cNT]

> **注記:** このアナライザーは現在、左親指のみ文字を配置可能という制約があるため、解析時は本レイアウトを水平方向にミラーしています。ミラーしても結果には影響しません。

![スクリーンショット](https://raw.githubusercontent.com/sunaku/enthium/main/stats/enthium/cyanophage.png)

全体統計:
* 総単語労力: 748.5
* 労力:        432.54

指の使用率:
* 同指ビグラム: 0.55%
* スキップビグラム(2u): 0.29%
* 横ストレッチビグラム: 0.23%
* 小指/薬指はさみ: 0.34%

トリグラム統計:
* alt:             37.45%
* bigram roll in:  29.02%
* bigram roll out: 14.67%
* other:           8.28%
* alt sfs:         5.10%
* redirect:        2.14%
* roll in:         1.71%
* weak redirect:   1.32%
* roll out:        0.31%

### [KeySolveアナライザー](https://grassfedreeve.github.io/keysolve-web/)

> **注記:** このアナライザーは小指横（CapsLockやアポストロフィ）に文字を配置できないため、結果は正確ではありません。例えばSFB（同指ビグラム）率はR B Vが全て親指で打たれる想定ですが、実際はRは右親指、Bは左小指、Vは右小指です。

![スクリーンショット](https://raw.githubusercontent.com/sunaku/enthium/main/stats/enthium/keysolve1.png)
![スクリーンショット](https://raw.githubusercontent.com/sunaku/enthium/main/stats/enthium/keysolve2.png)
![スクリーンショット](https://raw.githubusercontent.com/sunaku/enthium/main/stats/enthium/keysolve3.png)

全体統計:

    BIGRAMS     SFB: 0.97%      LSB: 0.44%      HSB: 4.79%      FSB: 0.35%
    SKIPGRAMS   SFS: 6.99%      LSS: 0.92%      HSS: 4.66%      FSS: 0.38%
    TRIGRAMS    ALT: 41.24%     ROL: 40.71%     ONE: 2.47%      RED: 1.66%

指の使用率:

    LEFT        LI: 13.91%      LM: 20.17%      LR: 8.70%       LP: 3.05%
    RIGHT       RI: 13.12%      RM: 14.59%      RR: 10.60%      RP: 7.94%
    TOTAL               LH: 45.83%                      RH: 54.17%

コピペ用カスタムソース:

    q y o u - x l d w z
    c i e a , k h t n s
    ' / = . ; j m g p f
    r b v

### [Oxeyアナライザー](https://oxey.dev/playground/index.html)

> **注記:** このアナライザーは小指横（CapsLockやアポストロフィ）に文字を配置できないため、結果は正確ではありません。例えばSFBはBとVが左親指で打たれる想定ですが、実際はBは左小指、Vは右小指です。

![スクリーンショット](https://raw.githubusercontent.com/sunaku/enthium/main/stats/enthium/oxey.png)

全体統計:
* Sfb:              0.811%
* Dsfb:             6.286%
* Lsb:              0.372%
* Inrolls:          29.442%
* Outrolls:         15.841%
* Total Rolls:      45.283%
* Onehands:         2.348%
* Alternates:       31.877%
* Alternates (sfs): 7.284%
* Total Alternates: 39.161%
* Redirects:        3.864%
* BadRedirects:     1.002%
* Total Redirects:  4.866%
* Other:            8.341%
* Invalid:          0.001%

指の使用率:

    finger 0:   3.63%   finger 9:       8.60%
    finger 1:   9.08%   finger 8:       10.65%
    finger 2:   19.30%  finger 7:       14.56%
    finger 3:   13.28%  finger 6:       12.33%

    左手:   45.29%  右手:     46.14%
    左中央: 1.384%  右中央:   1.189%

    ホームキー使用率: 56.37%

Sfb%（指ごと）:

    finger 0:   0.011%  finger 9:       0.024%
    finger 1:   0.047%  finger 8:       0.100%
    finger 2:   0.122%  finger 7:       0.051%
    finger 3:   0.339%  finger 6:       0.114%

### 比較

> **注記:** Oxeyアナライザーは小指横（CapsLockやアポストロフィ）に文字を配置できないため、結果は正確ではありません。例えばSFBはBとVが左親指で打たれる想定ですが、実際はBは左小指、Vは右小指です。かわりに[ Cyanophageアナライザーの結果 ](#cyanophage-analyzer)を参照してください。こちらは小指横キーと親指1文字キーを考慮しています。

[キーボードレイアウトコミュニティ][rKL]では、[Pascal Getreuerのガイドと比較表][PGt]がレイアウト探究の出発点として広く推奨されています。Enthiumも（統計的に）トップクラスのレイアウトの一つです：

* 0.811% SFBs -- 🥈 2位、Focalのみ上回る
* 0.372% LSBs -- 🥇 1位、全レイアウト中最優秀！
* 45.283% ロール -- Nerps, Gallium, MTGAP, Graphite, Dvorak, Halmak等を上回る
* 4.866% リダイレクト -- MTGAP, Sturdy, Recurva, APTv3, Canary, Colemak等を上回る
* 2.80% ピンキーオフ（小指横を除く）-- Graphite, Canary, Gallium, MTGAP等を上回る
  * `Q` (0.10%) + `'` (0.48%) + `Z` (0.10%) + `F` (2.12%)
* 5.35% ピンキーオフ（小指横含む）-- Engram, Halmakを上回る、他はEnthiumより良い
  * `Q` (0.10%) + `'` (0.48%) + `Z` (0.10%) + `F` (2.12%) + `B` (1.49%) + `V` (1.06%)

[rKL]: https://www.reddit.com/r/KeyboardLayouts/
[PGt]: https://getreuer.info/posts/keyboards/alt-layouts/index.html#which-alt-keyboard-layout-should-i-learn

参考までに、[本レイアウト及び関連レイアウトの全統計値](https://raw.githubusercontent.com/sunaku/enthium/main/stats/)を表にまとめています：

[cNT]: https://cyanophage.github.io/playground.html?layout=zwdlx-uoyq%5Csnthk%2Caeicbfpgmj%3B.%3D%2F%27vr&mode=ergo&lan=english
[cPM]: https://cyanophage.github.io/playground.html?layout=fpdlx%3Buoybzsnthk%2Caeicqvwgmj-.%27%3D%2F%5Cr&mode=ergo&lan=english
[cNG]: https://cyanophage.github.io/playground.html?layout=byou%27%3Bldwvzciea%2C.htsnqgxjk-%2Frmfp%5C%5E&mode=ergo&lan=english
[cDV]: https://cyanophage.github.io/playground.html?layout=%27%2C.pyfgcrl%2Faoeuidhtns-%3Bqjkxbmwvz%5C%5E&mode=ergo&lan=english
[cCD]: https://cyanophage.github.io/playground.html?layout=qwfpbjluy%3B-arstgmneio%27zxcdvkh%2C.%2F%5C%5E&mode=ergo&lan=english

| アナライザー   | カテゴリ  | 統計値             | [Enthium][cNT] | [Promethium][cPM] | [Engrammer][cNG] | [Dvorak][cDV] | [Colemak-DH][cCD] |
| ---------- | --------- | ------------------- | -------------- | ----------------- | ---------------- | ------------- | ----------------- |
| Oxey's     | ビグラム   | SFB                 | 0.811%         | 0.868%            | 1.511%           | 2.779%        | 1.367%            |
| Oxey's     | ビグラム   | DSFB                | 6.286%         | 6.761%            | 7.620%           | 6.979%        | 8.767%            |
| Oxey's     | ビグラム   | LSB                 | 0.372%         | 0.404%            | 0.671%           | 1.255%        | 1.975%            |
| Oxey's     | トリグラム | Inrolls             | 29.442%        | 29.333%           | 28.273%          | 23.820%       | 25.173%           |
| Oxey's     | トリグラム | Outrolls            | 15.841%        | 14.526%           | 14.050%          | 15.104%       | 20.940%           |
| Oxey's     | トリグラム | Total Rolls         | 45.283%        | 43.858%           | 42.323%          | 38.924%       | 46.113%           |
| Oxey's     | トリグラム | Onehands            | 2.348%         | 2.189%            | 2.146%           | 0.624%        | 2.484%            |
| Oxey's     | トリグラム | Alternates          | 31.877%        | 33.770%           | 32.483%          | 35.769%       | 22.913%           |
| Oxey's     | トリグラム | Alternates (SFS)    | 7.284%         | 8.205%            | 8.752%           | 8.787%        | 7.461%            |
| Oxey's     | トリグラム | Total Alternates    | 39.161%        | 41.974%           | 41.235%          | 44.556%       | 30.375%           |
| Oxey's     | トリグラム | Redirects           | 3.864%         | 2.273%            | 3.103%           | 2.639%        | 9.081%            |
| Oxey's     | トリグラム | BadRedirects        | 1.002%         | 1.236%            | 1.386%           | 0.818%        | 1.498%            |
| Oxey's     | トリグラム | Total Redirects     | 4.866%         | 3.509%            | 4.489%           | 3.458%        | 10.579%           |
| Oxey's     | トリグラム | Other               | 8.341%         | 8.468%            | 9.806%           | 12.437%       | 9.202%            |
| Oxey's     | トリグラム | Invalid             | 0.001%         | 0.001%            | 0.001%           | 0.001%        | 1.248%            |
| Oxey's     | 使用率     | 指 0                | 3.63%          | 9.56%             | 6.58%            | 8.50%         | 8.12%             |
| Oxey's     | 使用率     | 指 1                | 9.08%          | 10.65%            | 9.21%            | 8.72%         | 8.04%             |
| Oxey's     | 使用率     | 指 2                | 19.30%         | 14.56%            | 19.47%           | 12.99%        | 11.55%            |
| Oxey's     | 使用率     | 指 3                | 13.28%         | 12.33%            | 13.35%           | 14.95%        | 19.19%            |
| Oxey's     | 使用率     | 指 6                | 12.33%         | 13.28%            | 16.04%           | 16.33%        | 18.88%            |
| Oxey's     | 使用率     | 指 7                | 14.56%         | 19.77%            | 14.93%           | 13.73%        | 15.60%            |
| Oxey's     | 使用率     | 指 8                | 10.65%         | 9.01%             | 10.31%           | 13.84%        | 10.11%            |
| Oxey's     | 使用率     | 指 9                | 8.60%          | 4.62%             | 9.90%            | 10.59%        | 7.77%             |
| Oxey's     | 使用率     | 左手                | 45.29%         | 47.10%            | 48.61%           | 45.16%        | 46.89%            |
| Oxey's     | 使用率     | 右手                | 46.14%         | 46.68%            | 51.18%           | 54.49%        | 52.36%            |
| Oxey's     | 使用率     | 左中央              | 1.384%         | 1.189%            | 1.765%           | 9.208%        | 4.592%            |
| Oxey's     | 使用率     | 右中央              | 1.189%         | 1.384%            | 1.294%           | 7.257%        | 3.393%            |
| Oxey's     | 使用率     | ホームキー          | 56.37%         | 56.37%            | 56.37%           | 56.70%        | 62.31%            |
| Oxey's     | SFB%      | 指 0                | 0.011%         | 0.028%            | 0.012%           | 0.020%        | 0.041%            |
| Oxey's     | SFB%      | 指 1                | 0.047%         | 0.100%            | 0.089%           | 0.028%        | 0.047%            |
| Oxey's     | SFB%      | 指 2                | 0.122%         | 0.051%            | 0.230%           | 0.253%        | 0.186%            |
| Oxey's     | SFB%      | 指 3                | 0.339%         | 0.114%            | 0.591%           | 1.075%        | 0.219%            |
| Oxey's     | SFB%      | 指 6                | 0.114%         | 0.339%            | 0.380%           | 0.433%        | 0.388%            |
| Oxey's     | SFB%      | 指 7                | 0.051%         | 0.185%            | 0.053%           | 0.494%        | 0.341%            |
| Oxey's     | SFB%      | 指 8                | 0.100%         | 0.040%            | 0.098%           | 0.256%        | 0.137%            |
| Oxey's     | SFB%      | 指 9                | 0.024%         | 0.011%            | 0.058%           | 0.220%        | 0.007%            |
| KeySolve   | ビグラム   | SFB                 | 0.97%          | 0.94%             | 1.56%            | 2.62%         | 1.49%             |
| KeySolve   | ビグラム   | LSB                 | 0.44%          | 0.45%             | 0.98%            | 1.17%         | 2.21%             |
| KeySolve   | ビグラム   | HSB                 | 4.79%          | 6.04%             | 3.02%            | 6.11%         | 5.93%             |
| KeySolve   | ビグラム   | FSB                 | 0.35%          | 0.26%             | 0.30%            | 0.14%         | 0.37%             |
| KeySolve   | スキップグラム | SFS             | 6.99%          | 7.02%             | 7.50%            | 7.00%         | 7.95%             |
| KeySolve   | スキップグラム | LSS             | 0.92%          | 0.93%             | 1.34%            | 4.48%         | 1.75%             |
| KeySolve   | スキップグラム | HSS             | 4.66%          | 6.11%             | 6.91%            | 8.56%         | 6.49%             |
| KeySolve   | スキップグラム | FSS             | 0.38%          | 0.78%             | 0.81%            | 1.22%         | 0.78%             |
| KeySolve   | トリグラム | ALT                 | 41.24%         | 40.37%            | 39.59%           | 41.70%        | 27.58%            |
| KeySolve   | トリグラム | ROL                 | 40.71%         | 40.84%            | 39.35%           | 37.19%        | 42.78%            |
| KeySolve   | トリグラム | ONE                 | 2.47%          | 2.66%             | 2.65%            | 0.43%         | 2.45%             |
| KeySolve   | トリグラム | RED                 | 1.66%          | 1.78%             | 2.65%            | 2.25%         | 6.74%             |
| KeySolve   | 使用率     | LI                  | 13.91%         | 13.91%            | 13.91%           | 14.56%        | 18.82%            |
| KeySolve   | 使用率     | LM                  | 20.17%         | 20.92%            | 20.30%           | 13.96%        | 10.18%            |
| KeySolve   | 使用率     | LR                  | 8.70%          | 8.70%             | 8.83%            | 9.55%         | 7.83%             |
| KeySolve   | 使用率     | LP                  | 3.05%          | 3.64%             | 5.72%            | 8.24%         | 7.63%             |
| KeySolve   | 使用率     | RI                  | 13.12%         | 13.12%            | 16.52%           | 16.90%        | 20.00%            |
| KeySolve   | 使用率     | RM                  | 14.59%         | 14.59%            | 15.03%           | 13.35%        | 16.91%            |
| KeySolve   | 使用率     | RR                  | 10.60%         | 10.60%            | 10.08%           | 13.36%        | 10.46%            |
| KeySolve   | 使用率     | RP                  | 7.94%          | 8.95%             | 9.47%            | 10.08%        | 8.16%             |
| KeySolve   | 合計       | LH                  | 45.83%         | 47.18%            | 48.75%           | 46.31%        | 44.46%            |
| KeySolve   | 合計       | RH                  | 54.17%         | 52.82%            | 51.25%           | 53.69%        | 55.54%            |
| Cyanophage | サマリー   | 総単語労力          | 748.5          | 732.3             | 899.8            | 1185.5        | 1048.2            |
| Cyanophage | サマリー   | 労力                | 432.54         | 398.07            | 457.44           | 769.78        | 535.05            |
| Cyanophage | ビグラム   | 同指ビグラム        | 0.55%          | 0.58%             | 0.99%            | 1.87%         | 0.91%             |
| Cyanophage | ビグラム   | スキップビグラム(2u) | 0.29%         | 0.36%             | 0.39%            | 0.45%         | 0.41%             |
| Cyanophage | ビグラム   | 横ストレッチビグラム | 0.23%         | 0.24%             | 0.41%            | 0.80%         | 1.27%             |
| Cyanophage | ビグラム   | 小指/薬指はさみ      | 0.34%         | 0.42%             | 0.71%            | 0.40%         | 0.65%             |
| Cyanophage | トリグラム | Alt                 | 37.45%         | 36.98%            | 35.62%           | 39.08%        | 25.43%            |
| Cyanophage | トリグラム | Alt SFS             | 5.10%          | 5.27%             | 5.93%            | 5.85%         | 5.47%             |
| Cyanophage | トリグラム | Roll in             | 1.71%          | 1.37%             | 1.82%            | 0.86%         | 1.50%             |
| Cyanophage | トリグラム | Roll out            | 0.31%          | 0.11%             | 0.29%            | 0.27%         | 0.98%             |
| Cyanophage | トリグラム | Bigram roll in      | 29.02%         | 29.18%            | 28.14%           | 23.51%        | 25.18%            |
| Cyanophage | トリグラム | Bigram roll out     | 14.67%         | 14.56%            | 14.03%           | 15.14%        | 21.55%            |
| Cyanophage | トリグラム | Redirect            | 2.14%          | 2.03%             | 3.05%            | 2.57%         | 9.22%             |
| Cyanophage | トリグラム | Weak redirect       | 1.32%          | 1.30%             | 1.40%            | 0.28%         | 1.52%             |
| Cyanophage | トリグラム | Other               | 8.28%          | 9.20%             | 9.72%            | 12.44%        | 9.17%             |

## インストール

### Linuxセットアップ

>*凡例:* QWERTY=白; Engram=金; Enthium=青/緑; Quirks=ピンク。
>![段違いキーボード上での本レイアウトレンダリング図](https://raw.githubusercontent.com/sunaku/enthium/main/linux/layout.png)

インストール:

    cd linux/
    sudo make install
    echo グラフィカルセッションを再起動してください。

有効化:

    setxkbmap -layout us    -variant enthium         # 単一レイアウト; スイッチなし
    setxkbmap -layout us,us -variant enthium,basic   # 複数レイアウト切替

修復（例: システム全体のXKBパッケージアップグレードで上書きされた場合）:

    cd linux/
    sudo make reinstall
    echo グラフィカルセッションを再起動してください。

アンインストール:

    cd linux/
    sudo make uninstall
    echo グラフィカルセッションを再起動してください。

### MacOSセットアップ

#### インストール

MacOSで本レイアウトを使用するには、[Karabiner-Elements](https://karabiner-elements.pqrs.org/)をインストールしてください。

[Homebrew](https://brew.sh/) 経由でインストール可能です：

    brew install --cask karabiner-elements

もしくは[Karabiner-Elements公式サイト](https://karabiner-elements.pqrs.org/)からダウンロードしてください。

ダウンロード後は、[インストールガイド](https://karabiner-elements.pqrs.org/docs/getting-started/installation/)の手順に従ってください。

#### 複雑な修飾

インストールが完了したら、[複雑な修飾機能](https://karabiner-elements.pqrs.org/docs/manual/configuration/configure-complex-modifications/)を利用してキーをリマップできます。

enthiumの複雑な修飾は[こちら](https://ke-complex-modifications.pqrs.org/?q=enthium)で利用できます。

元のレイアウトに戻したい場合は、enthiumの複雑な修飾を削除してください。

#### アンインストール

* Brew : `brew uninstall --cask karabiner-elements`
* 手動 : `Karabiner-Elements.app` をアプリケーションフォルダから削除

## ライセンス

[Arno's Engram 2.0] キーボードレイアウトのソースと同じ条件で公開されています：

> MIT License
>
> Copyright 2022 Ricard Figueroa <https://github.com/rfiga>  
> Copyright 2021 Suraj Kurapati <https://github.com/sunaku>  
> Copyright 2021 Arno Klein <https://github.com/binarybottle>  
>
> 本ソフトウェアおよび関連ドキュメントファイル（以下「ソフトウェア」）のコピーを取得したすべての人に対し、無制限にソフトウェアの使用、複製、修正、統合、公開、配布、サブライセンス、および/または販売する権利を無償で許可します。また、ソフトウェアが提供された者にも同様の権利を許可します。ただし、以下の条件を満たす必要があります。
>
> 上記著作権表示および本許諾表示は、ソフトウェアのすべてのコピーまたは重要な部分に記載されるものとします。
>
> 本ソフトウェアは「現状のまま」提供され、商品性、特定目的への適合性、および非侵害に関する保証を含め、明示・黙示を問わずいかなる保証もありません。いかなる場合も、著作者または著作権者は、ソフトウェアまたはその使用またはその他の取り扱いに起因または関連して発生した請求、損害、その他の責任について責任を負いません。

---------------------------------------------------------------------------
[Spare A Life]: https://sunaku.github.io/vegan-for-life.html
> 私の活動が気に入ったら、ぜひ[命を救う]という形で感謝を伝えてください！🐄🐖🐑🐔🐣🐟✨🙊✌  
> なぜ？倫理、地球環境、そして健康のために。上記リンク参照。🙇

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---