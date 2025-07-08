# Spegel – AIでウェブを反映

ウェブサイトを自動的にターミナル表示に最適化されたMarkdownに書き換えます。  
紹介ブログ記事は[こちら](https://simedw.com/2025/06/23/introducing-spegel/)。

これはプルーフ・オブ・コンセプトです。不具合があるかもしれませんが、問題やプルリクエストはお気軽にどうぞ。

## スクリーンショット
時には、レシピにたどり着くために誰かの人生話を読む必要はありません  
![レシピ例](https://simedw.com/2025/06/23/introducing-spegel/images/recipe_example.png)

## インストール

Python 3.11以降が必要です。

```
pip install spegel
```
またはリポジトリをクローンして編集可能モードでインストールします

```bash
# クローンしてディレクトリに移動
$ git clone <repo-url>
$ cd spegel

# 依存関係とCLIをインストール
$ pip install -e .
```

## APIキー
Spegelは現在Gemini 2.5 Flashのみサポートしています。使用するにはAPIキーを環境変数に設定してください。

```
GEMINI_API_KEY=...
```

## 使い方

### ブラウザの起動

```bash
spegel                # ウェルカム画面で開始
spegel bbc.com        # URLをすぐに開く
```

または、同様に：

```bash
python -m spegel      # ウェルカム画面で開始
python -m spegel bbc.com
```

### 基本操作
- `/`         – URL入力を開く
- `Tab`/`Shift+Tab` – リンクを巡回
- `Enter`     – 選択中のリンクを開く
- `e`         – 現在のビュー用LLMプロンプトを編集
- `b`         – 戻る
- `q`         – 終了

## 設定の編集

SpegelはTOML設定ファイルから設定を読み込みます。ビュー、プロンプト、UIオプションをカスタマイズできます。

**設定ファイルの検索順序:**
1. `./.spegel.toml`（カレントディレクトリ）
2. `~/.spegel.toml`
3. `~/.config/spegel/config.toml`

設定を編集するには:
1. サンプル設定をコピーします:
   ```bash
   cp example_config.toml .spegel.toml
   # または ~/.spegel.toml を作成
   ```
2. お好みのエディタで `.spegel.toml` を編集します。

サンプルスニペット:
```toml
[settings]
default_view = "terminal"
app_title = "Spegel"

[[views]]
id = "raw"
name = "Raw View"
prompt = ""

[[views]]
id = "terminal"
name = "Terminal"
prompt = "Transform this webpage into the perfect terminal browsing experience! ..."
```

---

詳細はコードを参照するか、Issueを立ててください！

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---