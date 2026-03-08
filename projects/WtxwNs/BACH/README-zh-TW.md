<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=zh-CN">簡體中文</a>
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
  <i>觀看 BACH 如何將原始標記一步步轉化為結構化音樂。</i>
</p>

# BACH：小節級 AI 作曲助手

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

&gt; *「透過樂譜至表現：高效且可人為控制的小節級符號長樂曲生成」*  
&gt; ICASSP 2026 投稿 – **已接受**

---

## 🎼 一句話摘要  
BACH 是首個**可人為編輯**、**小節級**的符號歌曲生成器：  
大型語言模型寫歌詞 → Transformer 輸出 ABC 樂譜 → 現成渲染器輸出**數分鐘長、Suno 等級**音樂。  
**10 億參數**，**分鐘級推論**，**SOTA 開源**。

---

## 📦 本倉庫內容（預覽版）
| 路徑 | 說明 |
|------|------|
| `README.md` | 本文件 |
| `code/` | 推論程式碼 |
| `example.mp3` | 範例歌曲 |
| `fig/` | 架構圖 |

---

## 🏗️ 模型架構（快速瀏覽）

使用者提示
Qwen3 — 歌詞與風格標籤
BACH-1B 僅解碼 Transformer
ABC 樂譜（雙 NTP + Score 連鎖）

ABC → MIDI → FluidSynth + VOCALOID
立體聲混音


| 元件 | 關鍵理念 |
|------|----------|
| **雙重NTP** | 每一步共同預測 `{vocal_patch, accomp_patch}` |
| **樂譜鏈式** | 使用段落標籤 `[START:Chorus] ... [END:Chorus]` 以維持長時間連貫性 |
| **小節流 patch** | 每小節 16 字元不重疊 patch |

---

## 🧪 快速開始（適合CPU）
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

##  🎧 現在收聽
example.mp3 已經為您準備好，這是一首完整的歌曲。您可以與 Suno 做比較🙂

## 完整發布將於相關論文被接受後進行
- 完整訓練集（ABC + 歌詞 + 結構標籤）
- BACH-1B 權重（Transformers 格式）
- 訓練腳本（多階段 + 多任務 + ICL）
- 完整程式碼

## 📎 引用
論文已在 Arxiv 發布，
```bibtex
@misc{wang2025scoreperformanceefficienthumancontrollable,
      title={通過樂譜到表現：以小節級符號記譜實現高效人類可控的長曲生成}, 
      author={Tongxi Wang 和 Yang Yu 和 Qing Wang 和 Junlang Qian},
      year={2025},
      eprint={2508.01394},
      archivePrefix={arXiv},
      primaryClass={cs.SD},
      url={https://arxiv.org/abs/2508.01394}, 
}


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-08

---