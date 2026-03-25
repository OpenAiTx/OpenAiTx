# 純粋なSQLレイトレーサー

誰もが遅かれ早かれレイトレーサーを書くものです。これは私のものです。

## 出力例

<img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/dielectricparty.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/oneglassball.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/onemirrorball.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/glassmatrix.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/airy.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/onediamondball.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/oneantiglassball.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/adjacentballs.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/onegreyball.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/reflectiontest.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/twodiffuseballs.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/onegreenball.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/threemirrors.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/twomirrorballs.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/busyday.png" width=200>

## 使用方法

```shell
sh create.sh
```

```postgres_connection.sh```にはホスト/データベース/ユーザー/パスワードなどが含まれています。  
「postgres、バージョン10以上のような」特別な要件はありません。  

参考までに、私のUbuntuデスクトップでは以下のように作成しました：  
```shell

sudo su - postgres
createuser --pwprompt raytracer
createdb -O raytracer raytracer
```

### 開発とレンダリングのためのレバー

開発中は、数分のレンダリング時間はかなり
遅いサイクルタイムです。速度を上げて品質を下げるために
いくつかのレバーを引くことができます。
それらは setup.sql の「camera」と「img」にあります：

* *samples\_per\_px* - ピクセルあたりのレイ/サブサンプルの数です。
  - デバッグ時は1か2で十分です
  - 15〜20で「実用的な」画像が得られます
  - 50を超えても目に見える改善はほとんどありません
* *max\_ray\_depth* - レイの最大バウンス回数
  - シンプルなシーンでは通常5回程度のバウンスです
* *res\_x* と *res\_y* - 最終画像の解像度
  - 小さいほど速くなります

メインのCTEは最終出力には不要な多くのものを含んでいます。
これは、次のようにシーン内をバウンスするレイを調べるためです：
```sql
SELECT * FROM rays WHERE img_x=100 AND img_y=250
```

gnuplotを使ってシーンのざっくりとしたビューを得るスクリプトがあります；
スクリプト```show_scene.sh```は出力のフォルダを生成するはずです。

## データベース

これは純粋なSQLで実装されています。CREATE FUNCTIONのような非移植なものは使っていません、
ただしアニメーション用のトリガーは例外です、これは明らかにカウントしません。

同時に、いくつかのあまり一般的でないSQLの機能が必要です：

* JOIN LATERAL
* RECURSIVE CTE内のPARTITION BY
* SIN()のような数学関数

なのでSQLiteで開発を始めましたが、最終的にはPostgreSQLに頼ることになりました。
この記事を書いている時点では、postgresで動作し、他のものではテストしていません。

## 興味深い実装部分

そういうわけで、いくつかの問題を興味深い方法で解決したことに気づきました。

### JOIN LATERAL

JOIN LATERALは、WHERE句ではなくJOINで相関サブクエリを行う方法です。
これを使って計算を持ち上げ、多くを一度だけ行い、場合によっては過剰な重複を避けています。

### 拡散散乱

これは一様球面のサンプリングを必要とします。たくさんのランダムサンプルを事前に生成し
[棄却サンプリング -> 点を球面表面にスケール]、番号を付けています。

これらの事前計算された散乱から各光線を単一のランダム行に結合する方法を見つけるのは奇妙でした；
RANDOM()に結合するだけでは、すべての光線が同じランダムな散乱に結合されてしまいます。
通常の法線に基づく典型的な計算で選択すると画像に縞模様が出ます。
そこで代わりに法線の一つの次元の後半の数桁を取り出し、それに結合しています。
これは「ランダム」ですが、光線ごとに十分にユニークです。

### 再帰CTE

レイトレーシングは再帰CTEの動作を非常に自然に追跡します。
私が直面したことの一つは、どの光線を考慮すべきかをきれいに識別する方法でした。
交差点(t)でウィンドウ関数の順序付けを使うのがうまくいきました。
各反復で、このクエリは光線とその前方の*すべて*を交差させ、
関連するすべての計算を行いますが、WHERE句で光線が実際に当たったもの以外は拒否します。

また、最終集計のコアの単純さには本当に美しさがあります[明瞭化のため編集]：
```sql
```










 SELECT img_x, img_y,
         SUM(POW(color_mult * ray_col_r/samples_per_px, gamma)) col_r,
         SUM(POW(color_mult * ray_col_g/samples_per_px, gamma)) col_g,
         SUM(POW(color_mult * ray_col_b/samples_per_px, gamma)) col_b
    FROM rays
    GROUP BY img_y, img_x
```

### シーン、マテリアルなど

これはSQLで書かれているため、データベースに複数のシーンを保存できます。  
実際にレンダリングされるシーンは「camera」テーブルで選択されます。

## 巨人の肩の上に立つ

これを書いた2年前、「現時点で市場で最も先進的なMySQLレイトレーサー」が  
ソーシャルメディアで話題になりました：  
https://www.pouet.net/prod.php?which=83222

私はいくつか異なること（悪い意味で？）をやりたいと思っていました：

* デモシーンはアートフォームです。ゴルフではありませんし、最小化もしていません
* 1つのクエリだけではありません；CTEでできるけど、えええええええ
* 最終目標としてのアニメーション[```anim.sh```を参照]
* 主に、ただ間違った道具で遊んでいるだけです

### Claudeに意見を求めました

*"なぜ誰かがこんなことを最初に書こうと思ったのか？"*

> これはSQLを汎用プログラミング言語として極端に使った興味深い例です。  
> 誰かがPostgreSQLのSQLで完全なレイトレーサーを書いたのは、印象的であり…  
> 疑問も感じさせます。
> 
> [...]
> 
> これは、優秀なコンピュータサイエンス学生の卒業論文プロジェクトか、  
> シニアエンジニアの週末実験か、非常に制限されたデータベース環境に閉じ込められた  
> けれどもレイトレーシングの夢を諦めなかった誰かのどれかのように感じます。
> 
> これは、レゴでレーシングカーを作るのに例えられます — 技術的には印象的ですが、  
> 実際に運転すべきではありません。

褒められているのか侮辱されているのか判断できません。

## 参考文献

ほとんどは「Ray Tracing in One Weekend」シリーズに従って構築しました：  
https://raytracing.github.io/ 、それから意図的に不明瞭な方法でコーディングしています。

Gary <chunky@icculus.org>

```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-25

---