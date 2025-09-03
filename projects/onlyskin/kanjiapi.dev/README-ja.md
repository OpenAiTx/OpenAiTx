# kanjiapi.dev：漢字のための最新のJSON API

13,000以上の漢字を[https://kanjiapi.dev](https://kanjiapi.dev)で提供

## リンク
- APIドキュメント: https://kanjiapi.dev/#!/documentation
- どの漢字がどのリストに存在するかの理解を助けるサイト: https://onlyskin.dev/official-kanji-list-diffs/

## コーヒーをおごってください

https://buymeacoffee.com/onlyskin

## 例

### 漢字 `/v1/kanji/{character}`
```
$ curl https://kanjiapi.dev/v1/kanji/猫
{
  "kanji": "猫",
  "grade": 8,
  "stroke_count": 11,
  "meanings": [
    "cat"
  ],
  "kun_readings": [
    "ねこ"
  ],
  "on_readings": [
    "ビョウ"
  ],
  "name_readings": [],
  "jlpt": 2,
  "unicode": "732b"
}
```

```javascript
> fetch('https://kanjiapi.dev/v1/kanji/猫').then(r => r.json()).then(console.log);
{
  "kanji": "猫",
  "grade": 8,
  "stroke_count": 11,
  "meanings": [
    "cat"
  ],
  "kun_readings": [
    "ねこ"
  ],
  "on_readings": [
    "ビョウ"
  ],
  "name_readings": [],
  "jlpt": 2,
  "unicode": "732b"
}
```
#### サポートされている全ての漢字の一覧

`$ curl https://kanjiapi.dev/v1/kanji/all`

#### 常用漢字の一覧

`$ curl https://kanjiapi.dev/v1/kanji/joyo`（`/jouyou`も可）

常用漢字とは日本政府が定めた一般使用漢字です。  
Unihanデータベースでは4つの追加の漢字を常用漢字としてラベル付けしており、合計で2140コードポイントになります。  
これは、常用漢字のうち4つがJIS X 0208符号化に存在しないため、JIS X 0208に存在する別の漢字が歴史的に使われていたためです。  
したがって、Unihanデータベースでは、4つの公式漢字と4つのJIS X 0208互換漢字の両方が常用漢字としてマークされています。  
これはkanjiapi.devが提供する`/joyo`リストにも反映されています。

対象となる文字は以下の通りです：  
| 公式常用漢字 | 歴史的JIS X 0208互換漢字 |  
| --- | --- |  
|𠮟 U+20B9F |叱 U+53F1|  
|塡 U+5861  |填 U+586B|  
|剝 U+525D  |剥 U+5265|  
|頰 U+9830  |頬 U+982C|

#### 人名用漢字の一覧

`$ curl https://kanjiapi.dev/v1/kanji/jinmeiyo`（`/jinmeiyou`も可）

注意点として、人名用漢字リストの82字はUnicodeのCJK互換コードブロックにコードポイントがあります。  
したがって、それらは他の文字と「同じ漢字」として扱われることがあります。  
これはUnicodeのUnihanデータベースで指定されています。

`kanjiapi.dev`はこれらのCJK互換コードポイント向けに`/kanji/{character}`エンドポイントを提供していますが、  
統一版の文字へアクセスしやすいように特別なフィールドを追加しています。  
さらに、これらの互換文字はほとんどの場合、対応する`/words/{character}`エンドポイントファイルに単語リストがなく、  
`/kanji/{character}`エンドポイントの情報も非常に限定されています。  
これは存在するデータを反映しています





`KANJIDIC` ファイル内で。

例えば、姓名用漢字の 海 (U+FA45) は、Unicode によって常用漢字の 海 (U+6d77) と同一視されています。  
そのため、姓名用のバージョンは CJK 互換ブロックに存在します。

これは問題です。なぜなら、ソフトウェアのどの層（例えばブラウザのキャッシュやURLエンコード）がUnicode正規化を行う可能性があり、  
姓名用漢字が別の文字に変換されてしまうからです。姓名用漢字を期待しているのに常用漢字が表示される場合は、  
これがおそらく原因です。

必要に応じて、CSSプロパティ `font-variant-east-asian: traditional;` を使用して、ブラウザに統合された同等文字を伝統的な方法で表示させることができます。  
これにより、常用漢字のコードポイントが姓名用漢字の相当文字として表示されるはずです。

#### 平易漢字リスト

`$ curl https://kanjiapi.dev/v1/kanji/heisig`

Heisig キーワードが割り当てられている文字のリストです。  
なお、通常のキーワードの後に '[alt]' と表示されている4つの追加漢字があります。  
これは、JIS X 0208 に存在しない4つの公式常用漢字の異体字です（Heisig 書籍シリーズはこれらのキーワードをJIS対応文字に割り当てましたが、  
これらの文字を探す人はJIS対応版か公式版のどちらかから来る可能性があります）。  
詳しくは上記の「常用漢字リスト」セクションをご参照ください。

#### 特定学年の漢字リスト

`$ curl https://kanjiapi.dev/v1/kanji/grade-1`（小学校1～6年生対象、8は残りの高校学年を示します）

### `/v1/reading/{reading}` の読み込み





```
$ curl https://kanjiapi.dev/v1/reading/クウ
{
  "reading": "クウ",
  "main_kanji": [
    "宮",
    "供",
    "空",
    "咼",
    "啌",
    "喎",
    "垙",
    "瘸",
    "盉",
    "舙"
  ],
  "name_kanji": []
}
```

```javascript
> fetch('https://kanjiapi.dev/v1/reading/クウ').then(r => r.json()).then(console.log);
{
  "reading": "クウ",
  "main_kanji": [
    "宮",
    "供",
    "空",
    "咼",
    "啌",
    "喎",
    "垙",
    "瘸",
    "盉",
    "舙"
  ],
  "name_kanji": []
}
```

### 単語 `/v1/words/{character}`
```
$ curl https://kanjiapi.dev/v1/words/猫
[
  {
    "variants": [
      {
        "written": "どら猫",
        "pronounced": "どらねこ",
        "priorities": []
      }
    ],
    "meanings": [
      {
        "glosses": [
          "stray cat"
        ]
      }
    ]
  },
  {
    "variants": [
      {
        "written": "アンゴラ猫",
        "pronounced": "アンゴラねこ",
        "priorities": []
      }
    ],
    "meanings": [
      {
        "glosses": [
          "Angora cat"
        ]
      }
    ]
  },
  ...
]
```

```javascript
> fetch('https://kanjiapi.dev/v1/reading/クウ').then(r => r.json()).then(console.log);
[
  {
    "variants": [
      {
        "written": "どら猫",
        "pronounced": "どらねこ",
        "priorities": []
      }
    ],
    "meanings": [
      {
        "glosses": [
          "stray cat"
        ]
      }
    ]
  },
  {
    "variants": [
      {
        "written": "アンゴラ猫",
        "pronounced": "アンゴラねこ",
        "priorities": []
      }
    ],
    "meanings": [
      {
        "glosses": [
          "Angora cat"
        ]
      }
    ]
  },
  ...
]
```
## 開発:

### 要件:

`python 3`、`make`、および `node` が利用可能であることを前提としています。

### セットアップ:

requirements.txt を使用して Python ライブラリをインストールします。

`yarn` または `npm install` を使用して Node の依存関係をインストールします。

[EDRDG](http://www.edrdg.org/wiki/index.php/KANJIDIC_Project) から漢字辞書ファイル `kanjidic2.xml` をダウンロードし、プロジェクトのルートに保存・展開します。

[EDRDG](http://www.edrdg.org/wiki/index.php/JMdict-EDICT_Dictionary_Project) から jmdict 辞書ファイル `JMdict` をダウンロードし、プロジェクトのルートに保存・展開します。

[Unicode](https://www.unicode.org/versions/components-15.0.0.html) から Unihan.zip 内のファイル Unihan_OtherMappings.txt をダウンロードし、プロジェクトのルートに保存・展開します。

[Unicode](https://www.unicode.org/versions/components-15.0.0.html) から Unihan.zip 内のファイル Unihan_IRGSources.txt をダウンロードし、プロジェクトのルートに保存・展開します。

ファビコン生成のために、システムに `System/Library/Fonts/ヒラギノ丸ゴ\ ProN\ W4.ttc` フォントが利用可能であることを確認してください。

### ビルド:

`make` を実行してサイトおよび API エンドポイントを静的アセットとしてビルドします。

`python -m pytest tests` を実行してテストを実行します。

注意: サイトのローカルビルドから API のローカルビルドのデータを取得するには、ファイルサーバのルートを out/site に設定できます（例: `serveit` を使って `serveit -s out/site make`）。`out/site` 内には `out/v1` へのシンボリックリンクがあり、これを可能にしています。

注意: Unicode CJK 互換ブロックの文字に対応するエンドポイントファイルは、いくつかのファイルシステムが非互換の対応文字と正規化するため、別ディレクトリに書き出されます。これにより、ローカル開発中に API の通常パスに `/kanji/{character}` および `/words/{character}` の一部エンドポイントが表示されないことがあります。









### デプロイメント（Google Cloudアカウントの認証情報が必要）：

#### バージョニング

デプロイ用のAPIバージョンは `api_data.py` と `makefile` にハードコードされています。


#### バケットへのアップロード

ビルド後、ビルドした資産をウェブサイトバケットに同期するには以下を実行します：

注意：最初はすべてのコマンドを `rsync -n` でドライランすることをお勧めします

ビルドされたサイトディレクトリ（`out/site`）をバケットのルートと非再帰的に同期するには：
`gsutil -m rsync -c -d -x ".*\.map$" out/site gs://kanjiapi.dev`

ビルドされたAPIディレクトリのフォルダ（`out/{version}`）をファイルのハッシュに基づいてバケットの`/{version}`ディレクトリに再帰的に同期するには：
`gsutil -m -h "Content-Type:application/json" rsync -r -c -d out/v1/kanji gs://kanjiapi.dev/v1/kanji/`
`gsutil -m -h "Content-Type:application/json" rsync -r -c out/v1/kanji_cjk gs://kanjiapi.dev/v1/kanji/`
`gsutil -m -h "Content-Type:application/json" rsync -r -c -d out/v1/words gs://kanjiapi.dev/v1/words/`
`gsutil -m -h "Content-Type:application/json" rsync -r -c out/v1/words_cjk gs://kanjiapi.dev/v1/words/`
`gsutil -m -h "Content-Type:application/json" rsync -r -c -d out/v1/reading gs://kanjiapi.dev/v1/reading/`

#### CORSポリシーの設定：

CORSポリシーは `cors.json` に保存されており、このファイルを編集して `gsutil cors set cors.json gs://kanjiapi.dev` を実行することで更新できます。

### ロギング：

ログファイルはAPI用のクラウドストレージバケットによって生成されます。
使用ログファイルが書き込まれるたびにトリガーされるクラウド関数があります。
このクラウド関数はログファイルを読み込み、[ログページ](https://kanjiapi.dev/#!/logs) に表示される役立つ情報を集計します。

クラウド関数は `popularity-contest` ディレクトリ内にあります。

デプロイするには、次のコマンドを実行します：
`gcloud functions deploy popularity-contest --gen2 --region=us-west1 --runtime=python310 --source popularity-contest --entry-point handle --trigger-bucket=kanjiapi-dev-logging --trigger-location=us` から



プロジェクトのルート。（認証情報が必要）

クラウド関数をローカルで実行するには、`popularity-contest` ディレクトリに移動し、
そのサブディレクトリ内の `requirements.txt` に基づいて仮想環境を作成および/または
有効化してから、`python main.py` を実行します。これは、
クラウド関数をデプロイまたはトリガーせずにログファイルを手動で（再）処理するのに便利です。
（認証情報が必要）


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-03

---