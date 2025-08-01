<div align="right">
  <details>
    <summary >🌐 言語</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<div align="center">
  <h1>ソフトウェアエンジニア</h1>
  <p>
    <img src="https://img.shields.io/github/actions/workflow/status/mrshaw01/software-engineer/pre-commit.yml?branch=main&label=pre-commit&logo=pre-commit&logoColor=white" alt="pre-commit status">
  </p>

  <p>
    <img src="https://img.shields.io/github/last-commit/mrshaw01/software-engineer" alt="Last Commit">
    <img src="https://img.shields.io/github/issues/mrshaw01/software-engineer" alt="Issues">
    <img src="https://img.shields.io/github/issues-pr/mrshaw01/software-engineer" alt="Pull Requests">
  </p>
</div>

**Python** と、今後は **C/C++** にも焦点を当てた、厳選された高品質な学習リソースのコレクションです。強固なソフトウェアエンジニアリングの基礎とシステムレベルの理解を構築することを目的としています。

## リポジトリ構成

```text
.
├── python-basic/           # Essential Python syntax, data types, and operations
├── python-advanced/        # Decorators, threading, logging, JSON, and more
├── python-OOP/             # Deep dive into Python's object-oriented programming
├── cpp-basic/              # Fundamentals of C++: syntax, memory, pointers, etc.
├── cpp-advanced/           # Advanced C++: RAII, noexcept, smart pointers, RVO, etc.
├── cpp-OOP/                # Object-oriented programming in C++
├── CUDA/                   # GPU programming with CUDA (host & device code)
├── MPI/                    # Message Passing Interface programming and demos
├── docs/                   # System-level notes on performance, Python-C++ interop, mixed precision, etc.
└── README.md               # Project overview (this file)
```
## 使用方法

各番号付きフォルダには、概念を説明する `README.md` と実行可能な `.py` ファイルが含まれています。例えば：


```bash
cd python-advanced/08-decorators
python basic_function_decorator.py
```
いくつかのスクリプトはサードパーティのライブラリ（例：`numpy`、`scipy`、`torch`）を必要とします。

すべてのコードは**Python 3.7+**に対応しており、**最小限で焦点を絞り、テスト可能**な形で書かれています。

## ハイライト

### Python

- **OOPの習得**：クラス、継承、メタクラス、デスクリプタ（`python-OOP/`）
- **高度なトピック**：デコレータ、コンテキストマネージャ、関数キャッシュ、並行処理
- **データ構造**：リスト、タプル、辞書、セットの実用的な使用法

### C++

- **C++基礎**：構文、関数、ポインタ、構造体、スコープ、列挙型（`cpp-basic/`）
- **モダンC++**：RAII、スマートポインタ、ムーブセマンティクス、アライメント、RVO（`cpp-advanced/`）
- **C++ OOP**：クラス、アクセス指定子、継承、多態性、テンプレート

### システム＆パフォーマンス

- **CUDAプログラミング**：ホスト/デバイスモデル、カーネル起動、メモリ管理（`CUDA/`）
- **MPIプログラミング**：実践的な分散プログラム、行列演算、検証実行（`MPI/`）
- **ドキュメント**：Python-C++インターフェース、GIL処理、CUDAチューニング、混合精度トレーニング（`docs/`）

## 学習方針

- 小さくモジュール化された例 — 混乱のないノートブック
- 概念、コード、解説の明確な分離
- 設計、パフォーマンス、保守性の重視
- 知識を段階的に構築 — 真剣な学習者やプロ向けに最適

## スター履歴

<a href="https://www.star-history.com/#mrshaw01/software-engineer&Date">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=mrshaw01/software-engineer&type=Date&theme=dark" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=mrshaw01/software-engineer&type=Date" />
   <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=mrshaw01/software-engineer&type=Date" />
 </picture>
</a>

## 🤝 貢献

バグ、タイプミスを見つけた、または何かを拡張したいですか？PRを開いてください — すべての貢献を歓迎します。

<p align="center">
  <a href="https://github.com/mrshaw01/software-engineer/graphs/contributors">
    <img src="https://contrib.rocks/image?repo=mrshaw01/software-engineer" />
  </a>
</p>

## 📄 ライセンス

MITライセンス — 学習や教育のための使用、適応、共有は自由です。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---