
<div align="right">
  <details>
    <summary >🌐 言語</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=as">অসমীয়া</
      </div>
    </div>
  </details>

</div>

<p align="center">
  <img src="https://raw.githubusercontent.com/WtxwNs/BACH/main/tokenpair.png" width="85%"/>
  <br><br>
  <i>BACHが生のトークンをどのように構造化された音楽へと変換するか——ステップごとにご覧ください。</i>
</p>

# BACH: 小節単位AI作曲支援ツール
<p align="center">
  <a href="https://arxiv.org/abs/2508.01394">
    <img src="https://img.shields.io/badge/arXiv-2508.01394-b31b1b.svg" alt="arXiv"/>
  </a>
  <a href="https://github.com/WtxwNs/BACH/blob/main/LICENSE">
    <img src="https://img.shields.io/github/license/WtxwNs/BACH" alt="License"/>
  </a>
  <img src="https://img.shields.io/github/repo-size/WtxwNs/BACH" alt="Repo Size"/>
  <img src="https://img.shields.io/github/stars/WtxwNs/BACH?style=social" alt="Stars"/>
</p>

&gt; *"Score to Performanceによる: 小節単位で人間が制御可能な効率的な長尺楽曲生成と記号譜表現"*  
&gt; ICASSP 2026 採択済み – **Accepted**

---

## 🎼 一文要約  
BACHは初の**人間編集可能**な**小節単位**の記号楽曲生成器です:  
LLMで歌詞作成 → TransformerでABC記譜出力 → 既存レンダラーで**数分級・Sunoレベル**の音楽生成。  
**10億パラメータ**、**分単位**の推論、**SOTAオープンソース**。

---

## 📦 このリポジトリの内容（プレビュー版）
| パス | 説明 |
|------|------|
| `README.md` | このファイル |
| `code/` | 推論コード |
| `example.mp3` | 楽曲例 |
| `fig/` | アーキテクチャ図 |

---

## 🏗️ モデルアーキテクチャ（概要）

ユーザープロンプト
Qwen3 — 歌詞 & スタイルタグ
BACH-1B Decoder-Only Transformer
ABC記譜（Dual-NTP + Chain-of-Score）

ABC → MIDI → FluidSynth + VOCALOID
ステレオミックス


| コンポーネント | キーアイデア |
|---------------|--------------|
| **Dual-NTP** | 毎ステップごとに `{vocal_patch, accomp_patch}` を共同で予測 |
| **Chain-of-Score** | 長い一貫性のためのセクションタグ `[START:Chorus] ... [END:Chorus]` |
| **Bar-stream patch** | 各小節ごとに16文字の非重複パッチ |

---

## 🧪 クイックスタート（CPUフレンドリー）
```bash
# 1. Clone
git clone https://github.com/your-github/BACH.git
cd BACH

# 2. Install
pip install -r requirements.txt        # transformers>=4.41 mido abcpy fluidsynth

# 3. Generate ABC
python bach/generate.py \
    --prompt "A rainy-day lo-fi hip-hop song about missing the last train" \
    --out_abc demo/rainy_lofi.abc

# 4. Render audio
```

##  🎧 今すぐ聴く
example.mp3 が準備できています。これは一曲全体です。Sunoと比較してみてください🙂

## 関連論文の受理後に完全公開
- 完全なトレーニングセット（ABC + 歌詞 + 構造ラベル）
- BACH-1B 重み（トランスフォーマーフォーマット）
- トレーニングスクリプト（多段階 + マルチタスク + ICL）
- 完全なコード

## 📎 引用
論文はArxivで公開されています、
```bibtex
@misc{wang2025scoreperformanceefficienthumancontrollable,
      title={スコアを通じてパフォーマンスへ：小節単位の記譜による効率的で人間制御可能な長編曲生成}, 
      author={王彤曦 and 于洋 and 王清 and 錢俊朗},
      year={2025},
      eprint={2508.01394},
      archivePrefix={arXiv},
      primaryClass={cs.SD},
      url={https://arxiv.org/abs/2508.01394}, 
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-08

---