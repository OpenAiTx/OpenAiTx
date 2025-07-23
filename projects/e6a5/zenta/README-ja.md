
# 🧘 zenta

> **あなたのコーディングフローに合ったマインドフルネス**

コーディング中に思考がさまよったら、ただ呼吸に戻りましょう。追跡も、メトリクスも、妨害もなし—ただターミナル内の純粋な気づきだけ。

**気づくこと自体が実践です。** ✨

---

## ⚡ クイックスタート


```bash
# Install (one-liner)
curl -fsSL https://raw.githubusercontent.com/e6a5/zenta/main/install.sh | bash

# Set up zen aliases
echo "alias breath='zenta now --quick'" >> ~/.zshrc
echo "alias breathe='zenta now'" >> ~/.zshrc
echo "alias anchor='zenta anchor'" >> ~/.zshrc
echo "alias reflect='zenta reflect'" >> ~/.zshrc
source ~/.zshrc

# Use instantly
breath    # When mind wanders → return to breath (1 breath cycle)
breathe   # Need deeper centering → longer session (3 breath cycles)
anchor    # Find your rhythm → interactive breathing anchor
reflect   # Evening → gentle day review
```
---

## 🌸 なぜ zenta なのか？

### **あなたの実際のワークフローにフィット**

1. **気づき**：「考えがまとまらない」
2. **戻る**：`breath`
3. **続ける**：コーディングに戻り、より集中

### **真の禅のアプローチ**

- ✅ **追跡なし** → 気づきは最適化するデータではない
- ✅ **分析なし** → 実践こそが目的
- ✅ **中断なし** → ターミナル内に留まる
- ✅ **ただ呼吸** → 純粋なマインドフルネス

### **開発者向けに構築**

- ターミナルネイティブ（ワークフローにフィット）
- 単一バイナリ（依存なし）
- プライベート（データ収集なし）
- 即時起動（`breath` はワンキー操作）

---

## 🌊 美しい呼吸


```bash
$ breath

       Let's breathe 🌸

    🌬️ Breathe in gently, let your body expand...

                      ○
                    ○ · ○
                     ···
              ○ · · ·   · · · ○
                     ···
                    ○ · ○
                      ·

       Carry this calm with you throughout your day 🙏
```
_穏やかなアニメーションによる純粋な視覚的呼吸ガイダンス_

---

## 💡 コマンド

### **基本コマンド（エイリアス付き）**

| コマンド     | サイクル数 | 内容                                   | 最適なシーン                       |
| ----------- | ---------- | ------------------------------------ | --------------------------------- |
| `breath`    | 1サイクル   | 短時間の呼吸＋知恵の引用               | 気が散った瞬間                     |
| `breathe`   | 3サイクル   | 標準的な呼吸＋知恵の引用               | 難しい作業の前                     |
| `anchor`    | ユーザー主導 | 自分のリズムを見つけるインタラクティブアンカー | 自分のペースを設定したい時          |
| `reflect`   | -          | 穏やかな夜の振り返り                   | 一日の終わりの瞑想                 |

### **全コマンド**

| コマンド                    | サイクル数 | 内容                                         |
| -------------------------- | ---------- | -------------------------------------------- |
| `zenta now`                | 3サイクル   | 標準的な呼吸＋知恵の引用                       |
| `zenta now --quick`        | 1サイクル   | 短時間の呼吸＋知恵の引用                       |
| `zenta now --extended`     | 5サイクル   | 拡張された呼吸＋知恵の引用                     |
| `zenta anchor`             | ユーザー主導 | 自分のリズムを見つけるインタラクティブアンカー     |
| `zenta now --silent`       | 3サイクル   | 呼吸のみ、引用なし                             |
| `zenta now --simple`       | 3サイクル   | シンプルなラインアニメーション（ターミナル対応） |

**オプションの組み合わせ例:** `zenta now --quick --silent`（1サイクル、引用なし）

---

## 🔧 ターミナル互換性

**美しい円形とシンプルなラインの比較：**

- **ほとんどのターミナル**: 美しい拡大・収縮する呼吸サークル
- **macOS Terminal.app**: 自動検出してシンプルなラインアニメーションを使用
- **tmux/screen**: 複雑なアニメーションでも問題なく動作

**シンプルモードを強制する:** 任意のコマンドに `--simple` を追加してください


```bash
breath --simple     # Force simple animation
zenta now --simple  # Works with any options
```
**なぜ？** macOSのTerminal.appだけがANSIエスケープシーケンスの特異性を持っています。zentaは自動検出し、最適な体験のために適応します。

---

## 🎯 本物のマインドフルネス vs 偽のマインドフルネス

**✅ 本物のマインドフルネス（zenta流）：**

- 心がさまようのに気づく
- すぐに呼吸に戻る
- 意識を持って作業を続ける
- 測定は不要

**❌ 偽のマインドフルネス：**

- 瞑想の連続日数を追跡する
- 意識のメトリクスを最適化する
- 内なる平和を定量化する
- マインドフルネスを生産的にする

---

## 🌿 哲学

> _「静かになればなるほど、より多くのことが聞こえる。」_

**zentaの信念：**

- マインドフルネスツールは実践に溶け込むべき
- 気づくこと自体が悟り
- 開発者には生産性ハックではなく存在感が必要
- 真の禅にメトリクスはない

---

## 🚀 インストール

### **オプション1：事前ビルド済みバイナリ（推奨）**

**macOS/Linux:**


```bash
# Download and install the latest binary for your platform
curl -s https://api.github.com/repos/e6a5/zenta/releases/latest \
| grep "browser_download_url.*$(uname -s | tr '[:upper:]' '[:lower:]')-$(uname -m | sed 's/x86_64/amd64/')" \
| cut -d '"' -f 4 \
| xargs curl -L -o zenta.tar.gz \
&& tar -xzf zenta.tar.gz \
&& sudo mv zenta-* /usr/local/bin/zenta \
&& rm zenta.tar.gz

# Or download manually from GitHub Releases
```
**Windows:**
[GitHub Releases](https://github.com/e6a5/zenta/releases) から最新の `.zip` ファイルをダウンロードし、解凍して実行ファイルを PATH に追加してください。

**手動ダウンロード:** [GitHub Releases](https://github.com/e6a5/zenta/releases) - プラットフォームを選択

### **オプション 2: ソースからビルド**

_Go 1.23+ がインストールされている必要があります_


```bash
git clone https://github.com/e6a5/zenta.git && cd zenta && make install-system
```
**まずはGoをインストールしてください：** [https://golang.org/dl/](https://golang.org/dl/)

_Linux、macOS、Windows、FreeBSD（全アーキテクチャ）をサポート_

---

## 🧘 プラクティスに参加しよう

- 🐛 **バグ報告** → [Issues](https://github.com/e6a5/zenta/issues)
- 💭 **マインドフルな議論** → [Discussions](https://github.com/e6a5/zenta/discussions)
- 🔧 **貢献する** → [CONTRIBUTING.md](https://raw.githubusercontent.com/e6a5/zenta/main/CONTRIBUTING.md)

---

## 📄 ライセンス

MITライセンス - [LICENSE](LICENSE)

---

> _「未来を大切にする最良の方法は、現在の瞬間を大切にすることだ。」_ — ティク・ナット・ハン

**今日からマインドフルなコーディングプラクティスを始めましょう：**


```bash
breath  # Just try it 🙏
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---