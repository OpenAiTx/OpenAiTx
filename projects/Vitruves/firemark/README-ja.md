
<div align="right">
  <details>
    <summary >🌐 言語</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

<p align="center">
  <img src="https://raw.githubusercontent.com/Vitruves/firemark/main/assets/img/firemark.png" alt="firemark" width="200">
</p>

<h1 align="center">firemark</h1>

<p align="center">Rust製の、高速かつ単一バイナリの画像・PDF向けウォーターマークツール。</p>

## なぜドキュメントにウォーターマークを付けるのか？

毎年、何百万人もの人々が、単純な書類のやり取りから始まる
身元詐欺の被害に遭っています。よくあるシナリオ：あなたは賃貸物件を探しています。
大家、あるいは大家を装った誰かが、あなたのIDや給与明細、
税務通知書のコピーを求めてきます。あなたは何も印を付けずに送ります。「大家」は消え、
あなたの書類は今や銀行口座の開設、ローンの申し込み、または
あなたの名義での身元詐称に使われてしまいます。

送信するすべての書類にウォーターマークを入れることが、最も効果的な防御策です。
**「XYZエージェンシー宛送付 — 2026年3月 — 賃貸申込専用」**のような
目に見えるオーバーレイがあれば、他の目的には使えません。漏洩した場合も、
どこから流出したのかがすぐに分かります。

firemarkなら、これが簡単にできます：コマンド一つで、どんな画像やPDFにも、17種類の
ビジュアルスタイル、編集耐性のある暗号学的すかしパターン、フォルダ単位の
バッチ処理も可能です。

<p align="center">
  <img src="https://raw.githubusercontent.com/Vitruves/firemark/main/assets/img/paycheck-firemark-comparison.png" alt="Before and after watermarking" width="800">
  <br>
  <em>ビフォー・アフター — コマンド一つで、書類は追跡可能かつ改ざん防止に。</em>
</p>

## インストール

[crates.io](https://crates.io/crates/firemark)から：

```bash
cargo install firemark
```
ソースから:


```bash
git clone https://github.com/Vitruves/firemark.git
cd firemark
cargo install --path .
```

単一の最適化されたバイナリを生成します（約5 MB）。

## クイックスタート

```bash
# Watermark a single image
firemark photo_id.png -m "Flat rental — SCI Dupont — March 2026"

# Watermark a PDF
firemark tax_notice.pdf -m "CONFIDENTIAL" -s "Do not distribute"

# Watermark an entire folder recursively
firemark ./documents/ -R -m "Sent to Agency X" -t stamp

# Preview without writing files
firemark id_card.jpg -m "Draft" -n
```
出力はデフォルトで入力ファイルと同じ場所に `{name}-watermarked.{ext}` として保存されます。  
明示的な出力パスを設定するには `-o` を使用し、カスタム接尾辞を設定するには `-S` を使用します。  

## 透かしの種類

| フラグ | スタイル | 説明 |
|---|---|---|
| `diagonal` | 斜めグリッド | ページ全体に繰り返される斜めテキスト（デフォルト） |
| `stamp` | スタンプ | 二重枠の大きな中央スタンプ |
| `stencil` | ステンシル | ページ幅いっぱいの軍用ステンシル文字 |
| `typewriter` | タイプライター | 等幅タイプライターテキスト |
| `handwritten` | 手書き署名 | 下線付き手書き風署名 |
| `redacted` | 黒塗り | ページ幅いっぱいの黒塗りバー |
| `badge` | バッジ | セキュリティシールド/バッジの紋章 |
| `ribbon` | リボン | 斜め角リボンバナー |
| `seal` | 印章 | 円形の公証人風印章 |
| `frame` | フレーム | ページ全体の装飾枠 |
| `tile` | タイル | 密集した均一テキストグリッド |
| `mosaic` | モザイク | ランダムに散らばったテキスト |
| `weave` | 織り込み | 交差する斜め織り模様 |
| `ghost` | ゴースト | 超微細な浮き彫りテキスト |
| `watercolor` | 水彩 | 柔らかいぼかし効果 |
| `noise` | ノイズ | ピクセルノイズのある荒れたテキスト |
| `halftone` | ハーフトーン | ハーフトーンドットのテキストグリッド |


```bash
firemark doc.pdf -t stamp -m "CONFIDENTIAL" --border --color red
```
## セキュリティフィリグラン

firemarkは、紙幣のセキュリティ機能に着想を得た暗号化フィリグランパターンをオーバーレイします。  
これらの細かい幾何学模様は画像編集ソフトでの除去が非常に困難です。

| スタイル | 説明 |
|---|---|
| `guilloche` | 正弦波エンベロープバンド（デフォルト） |
| `rosette` | スピログラフ＋コーナーローズ曲線 |
| `crosshatch` | 細かい斜めのダイヤモンド格子 |
| `border` | 波状の入れ子状セキュリティボーダー |
| `lissajous` | パラメトリックリサージュ図形 |
| `moire` | 同心円干渉模様 |
| `spiral` | アルキメデスの螺旋渦巻き |
| `mesh` | 六角形ハニカムグリッド |
| `plume` | 表面に散らばる流れる羽根状曲線 |
| `constellation` | 細かい幾何学的網でつながれた星ノード |
| `ripple` | ランダム起点の重なり合う楕円波面 |
| `full` | 全パターンの組み合わせ |
| `none` | フィリグランを無効化 |



```bash
firemark id.png -m "Rental application" --filigrane moire
firemark id.png -m "Rental application" --filigrane none   # disable
```
## AI除去耐性強化

すべてのレンダリングはデフォルトで非決定的です。firemarkは普遍的な
ポストレンダリング摂動（アルファジッター、サブピクセルカラーノイズ、エッジの微小点、
まばらなゴーストピクセル）とレンダラーごとのランダム化を適用し、同じ設定でも
2つの出力がピクセル単位で同一になることはありません。これによりAI
ビジョンモデルが予測可能なパターンを学習して差し引くことが不可能になります。

さらに、敵対的なプロンプト注入ストリップがデフォルトで埋め込まれており、
AIウォーターマーク除去ツールを混乱させます。目に見えるプロンプトテキストを
表示したくない場合は `--no-anti-ai` で無効化してください：


```bash
firemark doc.png -m "CONFIDENTIAL" --no-anti-ai
```

## 共通オプション

```
-m, --main-text           Primary watermark text
-s, --secondary-text      Secondary text line
-t, --type                Watermark style (see table above)
-o, --output              Output file path
-S, --suffix              Custom output suffix (default: "watermarked")
-c, --color               Color — name or #RRGGBB (default: blue)
-O, --opacity             Opacity 0.0–1.0 (default: 0.5)
-r, --rotation            Angle in degrees (default: -45)
-p, --position            center, top-left, top-right, bottom-left, bottom-right, tile
-f, --font                Font name or path to .ttf/.otf
-I, --image               Overlay an image as watermark
    --qr-data             Embed a QR code with custom data
    --qr-code-position    QR code placement (default: center)
    --qr-code-size        QR code size in pixels (default: auto)
    --border              Draw a border around the watermark
    --shadow              Add a drop shadow
    --filigrane           Security filigrane style (default: guilloche)
    --no-anti-ai          Disable adversarial prompt injection (on by default)
```

70以上のフラグの完全なリストについては、[`CLI.md`](https://raw.githubusercontent.com/Vitruves/firemark/main/CLI.md)を参照してください。

## PDFオプション

```
    --pages           Pages to watermark (e.g. 1,3-5 or "all")
    --skip-pages      Pages to skip
    --behind          Place watermark behind content
    --no-flatten      Keep layers separate (flattened by default)
    --dpi             Render resolution (default: 150)
```

## バッチ処理

```bash
# Process all images and PDFs in a folder
firemark ./inbox/ -m "INTERNAL" -t tile

# Recursive, 8 threads, custom suffix
firemark ./docs/ -R -j 8 -m "Draft" -S draft

# Dry run — list what would be processed
firemark ./docs/ -R -m "Draft" -n
```
すでに透かしが入っているファイル（サフィックスが一致するもの）は
再実行時に自動的にスキップされます。

## 設定ファイル

フラグの繰り返しを避けるため、オプションをTOMLファイルに保存します。
2つのプリセットを含む完全な例は、
[`examples/config/firemark.toml`](https://raw.githubusercontent.com/Vitruves/firemark/main/examples/config/firemark.toml) を参照してください：
**ultra-secure**（密なタイル配置、完全なフィリグラン、QR追跡、メタデータ削除）と
**light**（シンプルな斜めテキスト、追加機能なし）です。

```toml
# Global defaults
main_text = "CONFIDENTIAL"
secondary_text = "{author} — {date}"
watermark_type = "diagonal"
color = "#1a3c6e"
opacity = 0.45
font_weight = "bold"
filigrane = "guilloche"
border = true

[preset.ultra-secure]
main_text = "CONFIDENTIAL — {author}"
watermark_type = "tile"
color = "#CC0000"
opacity = 0.6
filigrane = "full"
anti_ai = true
qr_data = "firemark://{author}/{timestamp}/{uuid}"
strip_metadata = true

[preset.light]
main_text = "COPY"
watermark_type = "diagonal"
color = "#555555"
opacity = 0.3
filigrane = "none"
anti_ai = false
```

```bash
firemark doc.pdf --config firemark.toml
firemark doc.pdf --config firemark.toml --preset ultra-secure
firemark doc.pdf --config firemark.toml --preset light
firemark doc.pdf --save-preset mypreset    # save current flags
firemark --list-presets                     # list available presets
```

## フォーマット対応

| フォーマット | 入力 | 出力 |
|---|---|---|
| PNG | はい | はい |
| JPEG | はい | はい |
| PDF | はい | はい |
| WebP | はい | はい |
| TIFF | はい | はい |

クロスフォーマット変換に対応（例：`firemark photo.webp -o out.pdf`）。

## ライセンス

MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-11

---