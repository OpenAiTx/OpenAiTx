# hwpers

[![Crates.io](https://img.shields.io/crates/v/hwpers.svg)](https://crates.io/crates/hwpers)
[![Documentation](https://docs.rs/hwpers/badge.svg)](https://docs.rs/hwpers)
[![CI](https://github.com/Indosaram/hwpers/workflows/CI/badge.svg)](https://github.com/Indosaram/hwpers/actions)
[![License](https://img.shields.io/badge/license-MIT%2FApache--2.0-blue.svg)](LICENSE-MIT)

完全なレイアウトレンダリングサポートを備えた韓国語ハングルワードプロセッサ（HWP）ファイル解析用のRustライブラリ。

## 特徴

### パーサー（HWPファイルの読み込み）
- **完全なHWP 5.0フォーマット対応**：テキスト、書式設定、表、埋め込みオブジェクトを含むすべてのドキュメントコンポーネントを解析
- **ビジュアルレイアウトレンダリング**：レイアウトデータが利用可能な場合、ピクセル単位で正確にドキュメントを再構築
- **フォントおよびスタイルの保持**：元のフォント、サイズ、色、テキスト書式を抽出および適用
- **高度なレイアウトエンジン**：複数カラムレイアウト、行ごとの位置指定、文字単位の書式設定をサポート
- **SVGエクスポート**：ドキュメントをスケーラブルベクターグラフィックスにレンダリング
- **ゼロコピー解析**：最小限のメモリアロケーションによる効率的な解析
- **安全なRust**：包括的なエラーハンドリングを備えたメモリ安全な実装

### ライター（HWPファイルの作成） - v0.3.0以降
- **ドキュメント作成**：完全なHWPドキュメント書き込み対応
- **リッチテキスト書式**：太字、斜体、色、フォント、サイズ
- **表**：作成、スタイリング、セルの結合
- **リスト**：箇条書き、番号付け、韓国語・アルファベット・ローマ数字形式
- **画像**：PNG/JPEG/BMP/GIFとキャプション
- **テキストボックス**：位置指定およびスタイル設定されたテキストボックス
- **ハイパーリンク**：URL、メール、ファイル、ブックマークリンク
- **ヘッダー/フッター**：ページ番号およびカスタムコンテンツ
- **ページレイアウト**：サイズ、余白、向き、カラム、背景

## クイックスタート

`Cargo.toml`に以下を追加してください：

```toml
[dependencies]
hwpers = "0.3"
```

### 基本的な使い方

```rust
use hwpers::HwpReader;

// Parse an HWP file
let document = HwpReader::from_file("document.hwp")?;

// Extract text content
let text = document.extract_text();
println!("{}", text);

// Access document properties
if let Some(props) = document.get_properties() {
    println!("Pages: {}", props.total_page_count);
}

// Iterate through sections and paragraphs
for (i, section) in document.sections().enumerate() {
    println!("Section {}: {} paragraphs", i, section.paragraphs.len());
    
    for paragraph in &section.paragraphs {
        if let Some(text) = &paragraph.text {
            println!("  {}", text.content);
        }
    }
}
```

### ビジュアルレイアウトレンダリング

```rust
use hwpers::{HwpReader, render::{HwpRenderer, RenderOptions}};

let document = HwpReader::from_file("document.hwp")?;

// Create renderer with custom options
let options = RenderOptions {
    dpi: 96,
    scale: 1.0,
    show_margins: false,
    show_baselines: false,
};

let renderer = HwpRenderer::new(&document, options);
let result = renderer.render();

// Export first page to SVG
if let Some(svg) = result.to_svg(0) {
    std::fs::write("page1.svg", svg)?;
}

println!("Rendered {} pages", result.pages.len());
```

### ドキュメントの作成 (v0.3.0+)

```rust
use hwpers::writer::HwpWriter;
use hwpers::model::hyperlink::Hyperlink;

// Create a new document
let mut writer = HwpWriter::new();

// Add formatted text
writer.add_aligned_paragraph(
    "제목",
    hwpers::writer::style::ParagraphAlignment::Center
)?;

// Add hyperlinks
let link = Hyperlink::new_url("Rust", "https://rust-lang.org");
writer.add_paragraph_with_hyperlinks(
    "Visit Rust website",
    vec![link]
)?;

// Configure page layout
writer.set_custom_page_size(210.0, 297.0, // A4 size
    hwpers::model::page_layout::PageOrientation::Portrait)?;
writer.set_page_margins_mm(20.0, 20.0, 20.0, 20.0);

// Add header and footer
writer.add_header("Document Header");
writer.add_footer_with_page_number("Page ", 
    hwpers::model::header_footer::PageNumberFormat::Numeric);

// Save the document
writer.save_to_file("output.hwp")?;
```

### 高度なフォーマットアクセス

```rust
// Access character and paragraph formatting
for section in document.sections() {
    for paragraph in &section.paragraphs {
        // Get paragraph formatting
        if let Some(para_shape) = document.get_para_shape(paragraph.para_shape_id as usize) {
            println!("Indent: {}, Alignment: {}", 
                para_shape.indent, 
                para_shape.get_alignment()
            );
        }
        
        // Get character formatting runs
        if let Some(char_shapes) = &paragraph.char_shapes {
            for pos_shape in &char_shapes.char_positions {
                if let Some(char_shape) = document.get_char_shape(pos_shape.char_shape_id as usize) {
                    println!("Position {}: Size {}, Bold: {}", 
                        pos_shape.position,
                        char_shape.base_size / 100,
                        char_shape.is_bold()
                    );
                }
            }
        }
    }
}
```
## 対応機能

### ドキュメント構造
- ✅ ファイルヘッダーおよびバージョン検出
- ✅ ドキュメントのプロパティとメタデータ
- ✅ セクション定義およびページレイアウト
- ✅ 段落および文字の書式設定
- ✅ フォント定義（FaceName）
- ✅ スタイルとテンプレート

### コンテンツタイプ
- ✅ フルUnicode対応のテキストコンテンツ
- ✅ 表および構造化データ
- ✅ コントロールオブジェクト（画像、OLEオブジェクト）
- ✅ 番号付きおよび箇条書きリスト
- ✅ タブストップと配置

### レイアウトとレンダリング
- ✅ ページ寸法および余白
- ✅ 複数カラムレイアウト
- ✅ 行単位の位置決め（可能な場合）
- ✅ 文字単位の位置決め（可能な場合）
- ✅ 枠線および塗りつぶしパターン
- ✅ 正確な位置決めによるSVGエクスポート

### 高度な機能
- ✅ 圧縮ドキュメント対応
- ✅ CFB（複合ファイルバイナリ）形式の処理
- ✅ 複数エンコーディング対応（UTF-16LE）
- ✅ エラー回復および部分解析

## コマンドラインツール

本ライブラリにはHWPファイルを検査するためのコマンドラインツールが含まれています：


```bash
# Install the tool
cargo install hwpers

# Inspect an HWP file
hwp_info document.hwp
```
## フォーマット対応

このライブラリはHWP 5.0形式のファイルをサポートしています。古いHWP形式の場合は、まずフォーマット変換ツールの使用を検討してください。

## ライタ機能（v0.3.0以降）

HWPライタ機能は大幅に改善され、包括的な機能サポートが実現されています：

### ✅ 完全実装
- **ハイパーリンク**：適切なシリアル化を伴う完全なハイパーリンクサポート
  - URLリンク、メールリンク、ファイルリンク、ブックマーク
  - 段落ごとに複数のハイパーリンク
  - カスタムスタイリング（色、下線、訪問済み状態）
- **ヘッダー/フッター**：完全なヘッダーとフッターの実装
  - カスタムヘッダー/フッターテキスト
  - 複数フォーマットのページ番号（数字、ローマ数字など）
  - ドキュメントごとに複数のヘッダー/フッター
- **ページレイアウト**：包括的なページレイアウト制御
  - カスタムページサイズおよび標準サイズ（A4、レターなど）
  - 縦向き/横向きの向き設定
  - カスタム余白（狭い、標準、広い、カスタム）
  - 調整可能な間隔の複数カラムレイアウト
  - ページ背景色の設定
- **表**：完全な表の作成と書式設定
  - セルの罫線とスタイリング
  - セルの結合（横方向および縦方向）
  - カスタムセル内容
- **リスト/番号付け**：完全なリストサポート
  - レベルごとに異なる記号の箇条書きリスト
  - 番号付きリスト（1., 2., 3., ...）
  - アルファベットリスト（a), b), c), ...）
  - ローマ数字リスト（i., ii., iii., ...）
  - 韓国語リスト（가., 나., 다., ...）
  - 適切なインデントのネストされたリスト
- **テキストボックス**：完全なテキストボックス実装
  - 位置指定テキストボックス
  - スタイル付きテキストボックス（ハイライト、警告、情報など）
  - カスタムスタイル（罫線、背景、配置）
  - 回転と透過を伴う浮動テキストボックス

- **画像**: 画像挿入の完全対応
  - PNG、JPEG、BMP、GIF対応
  - カスタムサイズと位置指定
  - 画像キャプション
  - 適切なBinData統合
- **スタイル付きテキスト**: リッチテキスト書式設定
  - 太字、斜体、下線、取り消し線
  - カスタムフォントとサイズ
  - 文字色と背景色
  - 1段落内での複数スタイル
- **高度な書式設定**:
  - 段落の配置（左寄せ、中央揃え、右寄せ、両端揃え）
  - 行間調整
  - 段落間隔（前後）
  - 自動サイズ調整の見出し
  - 文字スタイルと段落スタイル
- **ドキュメントプロパティ**: 完全なメタデータ対応
  - タイトル、作成者、主題、キーワード
  - ドキュメント統計（文字数、単語数など）
  - 統計の自動更新

### ❌ 未実装
- **図形/描画**: 幾何学図形および描画オブジェクト
  - 長方形、円、楕円
  - 線、矢印、多角形
  - スタイリング可能なカスタム図形
  - テキスト入り図形
  - 図形のグループ化
  - *（使用例はexamples/shape_document.rs.disabled参照）*
- **チャート/グラフ**: データ可視化オブジェクト
- **数式**: MathML対応
- **フォーム**: 入力欄およびフォームコントロール
- **コメント/注釈**: レビューおよびコメント機能
- **変更履歴**: リビジョン履歴
- **差し込み印刷**: 変数フィールド挿入

### 🔧 既知の問題
- ライターでの圧縮対応なし（リーダーは圧縮・非圧縮両対応）
- 一部の高度な表機能は旧Hanwordバージョンとの互換性問題あり

## 貢献について

貢献は大歓迎です！プルリクエストの提出をお気軽にどうぞ。大きな変更の場合は、まず変更内容について議論するためにIssueを開いてください。

## ライセンス

本プロジェクトは以下いずれかのライセンスの下で提供されています。

- Apache License, Version 2.0、([LICENSE-APACHE](LICENSE-APACHE) または http://www.apache.org/licenses/LICENSE-2.0)
- MIT ライセンス ([LICENSE-MIT](LICENSE-MIT) または http://opensource.org/licenses/MIT)

お好みのライセンスを選択してください。

## 謝辞

- Hancom Inc.によるHWPファイルフォーマット仕様
- 韓国のテキスト処理コミュニティ
- Rustのパースおよびドキュメント処理エコシステム

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-13

---