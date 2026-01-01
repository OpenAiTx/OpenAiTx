<p align="center">
  <img src="https://raw.githubusercontent.com/WtxwNs/BACH/main/tokenpair.png" width="85%"/>
  <br><br>
  <i>BACHが生のトークンを段階的に構造化された音楽に変える様子をご覧ください。</i>
</p>

# BACH: 小節レベルAI作曲アシスタント  

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

&gt; *「スコアからパフォーマンスへ：小節レベルの記譜で実現する効率的かつ人間が制御可能な長尺曲生成」*  
&gt; ICASSP 2026 投稿 – **査読中**

---

## 🎼 一文での要約  
BACHは初の**人間が編集可能な**、**小節レベル**の記譜型楽曲生成器です：  
LLMが歌詞を書き → トランスフォーマーがABC譜を生成 → 汎用レンダラーで**数分間のSunoレベル**音楽に。  
**10億パラメータ級**、**分単位推論**、**最先端のオープンソース**。

---

## 📦 このリポジトリの中身（プレビューバージョン）
| パス | 説明 |
|------|-------------|
| `README.md` | 本ファイル |
| `code/` | 推論コード |
| `example.mp3` | サンプル曲 |
| `fig/` | アーキテクチャ図 |

---
## 🏗️ モデルアーキテクチャ（一目でわかる）

ユーザープロンプト  
Qwen3 — 歌詞＆スタイルタグ  
BACH-1B デコーダー専用トランスフォーマー  
ABCスコア（Dual-NTP + Chain-of-Score）  
ABC → MIDI → FluidSynth + VOCALOID  
ステレオミックス  


| コンポーネント | 主要アイデア |
|-----------|----------|
| **Dual-NTP** | 毎ステップ `{vocal_patch, accomp_patch}` を共同予測 |
| **Chain-of-Score** | 長期整合性のためのセクションタグ `[START:Chorus] ... [END:Chorus]` |
| **Bar-stream patch** | 1小節あたり16文字の非重複パッチ |  

---

## 🧪 クイックスタート（CPU対応）

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-01

---