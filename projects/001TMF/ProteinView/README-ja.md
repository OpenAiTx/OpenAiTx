<p align="center">
  <b>プロテインビュー</b>
</p>

<p align="center">
  <em>ターミナルで分子構造を探検しよう</em>
</p>

<p align="center">
  <a href="LICENSE"><img src="https://img.shields.io/badge/License-MIT-blue.svg" alt="License: MIT"></a>
  <a href="https://www.rust-lang.org/"><img src="https://img.shields.io/badge/Rust-1.85%2B-orange.svg" alt="Rust"></a>
  <img src="https://img.shields.io/badge/version-0.3.0-green.svg" alt="Version">
  <a href="https://github.com/001TMF/ProteinView/pulls"><img src="https://img.shields.io/badge/PRs-welcome-brightgreen.svg" alt="PRs Welcome"></a>
  <a href="https://www.linkedin.com/in/tristan-farmer-973b7a17a/"><img src="https://img.shields.io/badge/LinkedIn-Tristan%20Farmer-0A66C2?logo=linkedin" alt="LinkedIn"></a>
</p>

<p align="center">
  <img src="https://raw.githubusercontent.com/001TMF/ProteinView/master/assets/hero-histone.png" alt="ヒストンタンパク質とDNAをFullHDモードでレンダリングしたヌクレオソームコア粒子" width="700">
</p>

<p align="center">
  <sub>ヌクレオソームコア粒子 — DNAで巻かれたヒストンオクタマー、Kittyグラフィックスプロトコルでレンダリング</sub>
</p>

---

ターミナル分子構造ビューア — PDB/CIFファイルからタンパク質、核酸、小分子を読み込み、回転し、ターミナル上で探検可能。ブラウザ不要、GUI不要、依存関係なし。

## 特徴

- **3段階のレンダーモード** — ブレイル、HD、FullHD（Sixel/Kitty）と自動SSH検出
- **PNG圧縮Kittyプロトコル** — 生のRGBAより約10〜20倍小さく、SSH経由でのFullHDを実現
- **カートンリボン表示** — ランバート陰影付きリボン、ヘリックス・シート・コイルに深度フォグ
- **RNA/DNA対応** — バックボーン、ワイヤーフレーム、カートンモード、塩基タイプ別着色
- **小分子レンダリング** — リガンドはボール＆スティック、イオンは球体として表示
- **インターフェース解析** — 鎖間接触、結合ポケット、相互作用の可視化（H結合、塩橋、疎水性接触）
- **7種類のカラースキーム** — 構造、鎖、元素（CPK）、B因子、虹色、pLDDT（AlphaFold）
- **インタラクティブ操作** — vim風回転、ズーム、パン、自動回転
- **PDB & mmCIF対応** — 両フォーマット対応、RCSB PDB取得機能（`--fetch`）
- **単一の静的バイナリ** — 実行時依存関係ゼロ
## レンダーモード

端末と接続に合わせた3つのレンダリング階層：

<p align="center">
  <img src="https://raw.githubusercontent.com/001TMF/ProteinView/master/assets/render-modes-grid.png" alt="Braille vs HD vs FullHD rendering comparison" width="700">
</p>

<p align="center">
  <sub>左：点字（SSH/tmuxを含むすべてで動作）· 中央：HD（ランバート陰影付き点字）· 右：FullHD（Kittyピクセルグラフィックス）</sub>
</p>

| モード | キー | 品質 | SSH パフォーマンス |
|------|-----|---------|-----------------|
| **点字** | デフォルト | テキストベース、セルごとに単色 | 優秀 |
| **HD** | `m` | 照明と深度フォグ付き陰影点字 | 優秀 |
| **FullHD** | `M` | Sixel/Kittyピクセルグラフィックス | 良好（PNG圧縮） |

`--hd` はSSHを認識：SSH時はHD、ローカルではFullHDがデフォルト。ピクセルグラフィックスを強制するには `--fullhd` を使用。

## ビジュアライゼーションモード

<p align="center">
  <img src="https://raw.githubusercontent.com/001TMF/ProteinView/master/assets/viz-modes-grid.png" alt="Cartoon, Wireframe, and Backbone visualization modes" width="700">
</p>

<p align="center">
  <sub>左：カートゥーン（リボン）· 中央：ワイヤーフレーム（全原子）· 右：バックボーン（CAトレース）</sub>
</p>

| モード | 説明 |
|------|-------------|
| **カートゥーン** | 滑らかなリボンレンダリング — ヘリックス、ベータシート、コイルをランバート陰影付きで。デフォルト。 |
| **ワイヤーフレーム** | 残基間のペプチド結合およびホスホジエステル結合を含む全原子結合。 |
| **バックボーン** | CAトレース（タンパク質）/ C4'トレース（核酸）を球と太い接続線で表示。 |

## インターフェース解析と相互作用

<p align="center">

  <img src="https://raw.githubusercontent.com/001TMF/ProteinView/master/assets/interface-grid.png" alt="インターフェース解析と相互作用の可視化" width="700">
</p>

<p align="center">
  <sub>左：サイドバーパネル付きインターフェース残基の着色 · 右：破線の相互作用線（H結合、塩橋、疎水性接触）</sub>
</p>

`f`キーを押すとインターフェースモードが切り替わり、鎖の境界を越えた接触残基が詳細なサイドバーで強調表示されます。`I`キーで相互作用線をオーバーレイ表示します：

| 色 | 相互作用 | 距離 |
|-------|-------------|----------|
| シアン | 水素結合 | &le; 3.5 &Aring; |
| 赤 | 塩橋 | &le; 4.0 &Aring; |
| 黄 | 疎水性接触 | &le; 4.5 &Aring; |
| 灰色 | その他 | &le; 4.5 &Aring; |

## 核酸

<p align="center">
  <img src="https://raw.githubusercontent.com/001TMF/ProteinView/master/assets/dna-element.png" alt="元素（CPK）で着色されたB-DNA二重らせん" width="500">
</p>

<p align="center">
  <sub>ワイヤーフレームモードのB-DNAドデカマーとCPK元素着色</sub>
</p>

DNAおよびRNA構造を完全サポート — バックボーンのトレース、ワイヤーフレーム結合、ヌクレオチドの塩基タイプ着色（A=赤、U/T=青、G=緑、C=黄）によるカートゥーンリボン表示。

## AlphaFoldとpLDDT

<p align="center">
  <img src="https://raw.githubusercontent.com/001TMF/ProteinView/master/assets/plddt-cartoon.png" alt="pLDDT信頼度着色のAlphaFold予測" width="500">
</p>

<p align="center">
  <sub>pLDDT信頼度着色を施したAlphaFold予測 — 青（高信頼度）からオレンジ/黄（低信頼度）</sub>
</p>

AlphaFold構造を自動検出し、pLDDT信頼度着色を提供します。`c`キーでカラースキームを切り替え可能です。

## インストール

[Rust 1.85+](https://www.rust-lang.org/tools/install) が必要です。Rustをお持ちでない場合は、以下でインストールしてください:

```bash
curl --proto '=https' --tlsv1.2 -sSf https://sh.rustup.rs | sh
```

次に、proteinviewをインストールします：

```bash
git clone https://github.com/001TMF/ProteinView.git
cd ProteinView

# Basic install
cargo install --path .

# With RCSB PDB fetch support
cargo install --path . --features fetch

# Update an existing installation
cargo install --path . --force
```

## クイックスタート

```bash
# View a local PDB file
proteinview examples/1AOI.pdb

# HD mode (fast text-based shading)
proteinview examples/4HHB.pdb --hd

# FullHD pixel mode (Kitty/Sixel terminals)
proteinview examples/4HHB.pdb --fullhd

# Fetch from RCSB PDB
proteinview --fetch 1UBQ

# Choose color scheme and visualization
proteinview examples/1UBQ.pdb --color rainbow --mode wireframe
```
## キーバインディング

| キー | アクション |
|-----|--------|
| `h`/`l` | Y軸回転 |
| `j`/`k` | X軸回転 |
| `u`/`i` | ロール回転 |
| `+`/`-` | ズーム |
| `w`/`a`/`s`/`d` | パン移動 |
| `r` | 表示リセット |
| `c` | カラースキーム切替 |
| `v` | ビジュアライゼーションモード切替 |
| `m` | 点字/HD切替 |
| `M` | HD/FullHD切替 |
| `f` | インターフェース解析 |
| `I` | インターフェース相互作用 |
| `g` | リガンド表示切替 |
| `[`/`]` | 前/次の鎖へ |
| `Space` | 自動回転 |
| `?` | ヘルプ |
| `q` | 終了 |

## カラースキーム

| スキーム | 説明 |
|--------|-------------|
| **構造** | ヘリックス（赤）、シート（黄）、コイル（緑）。デフォルト。 |
| **鎖** | 鎖ごとに異なる色。 |
| **元素** | CPKカラー（C、N、O、S、P、金属）。 |
| **B因子** | 青（剛直）から赤（柔軟）まで。 |
| **虹色** | N末端（青）からC末端（赤）まで。 |
| **pLDDT** | AlphaFold信頼度（青=高、オレンジ=低）。 |

## ターミナル対応

| ターミナル | 点字 | HD | FullHD |
|----------|---------|-----|--------|
| 任意のUnicodeターミナル | 対応 | 対応 | -- |
| Kitty | 対応 | 対応 | 対応（PNG） |

| WezTerm | はい | はい | はい（Sixel） |
| iTerm2 | はい | はい | はい |
| foot | はい | はい | はい（Sixel） |
| tmux/screen | はい | はい | -- |

## ビルド

```bash
cargo build --release

# With RCSB fetch support
cargo build --release --features fetch
```

## 貢献について

貢献は歓迎します！始め方は以下の通りです：

1. リポジトリをフォークする
2. フィーチャーブランチを作成する（`git checkout -b feature/my-feature`）
3. 変更を加え、テストを追加する
4. `cargo test` を実行して検証する
5. `develop` ブランチに対してプルリクエストを開く

大きな変更については、まずイシューを開いて方針を議論してください。

## ライセンス

[MIT](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-17

---