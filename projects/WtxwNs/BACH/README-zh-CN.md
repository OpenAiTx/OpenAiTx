<div align="right">
  <details>
    <summary >🌐 语言</summary>
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
  <i>观看 BACH 如何将原始令牌一步步转化为结构化音乐。</i>
</p>

# BACH：小节级 AI 作曲助手

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

&gt; *“从乐谱到演奏：通过小节级符号记谱实现高效的人类可控长乐曲生成”*  
&gt; ICASSP 2026 投稿 – **已接收**

---

## 🎼 一句话摘要  
BACH 是首个**可人类编辑**、**小节级**的符号歌曲生成器：  
LLM写歌词 → Transformer生成ABC乐谱 → 通用渲染器输出**分钟级、Suno水准**音乐。  
**10亿参数**，**分钟级**推理，**SOTA开源**。

---

## 📦 本仓库包含内容（预览版）
| 路径 | 描述 |
|------|------|
| `README.md` | 本文件 |
| `code/` | 推理代码 |
| `example.mp3` | 示例歌曲 |
| `fig/` | 架构图 |

---

## 🏗️ 模型架构（快速一览）

用户提示
Qwen3 — 歌词与风格标签
BACH-1B 仅解码型Transformer
ABC乐谱（Dual-NTP + Chain-of-Score）

ABC → MIDI → FluidSynth + VOCALOID
立体声混音


| 组件 | 关键思想 |
|-----------|----------|
| **Dual-NTP** | 每一步联合预测 `{vocal_patch, accomp_patch}` |
| **Chain-of-Score** | 使用分段标签 `[START:Chorus] ... [END:Chorus]` 保持长时连贯性 |
| **Bar-stream patch** | 每小节16字符的不重叠片段 |

---

## 🧪 快速开始（适合CPU）
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

##  🎧 立即收听
example.mp3 已为您准备好，这是一整首歌。您可以将其与 Suno🙂 进行比较

## 相关文章接受后完整发布
- 完整训练集（ABC + 歌词 + 结构标签）
- BACH-1B 权重（Transformer 格式）
- 训练脚本（多阶段 + 多任务 + ICL）
- 完整代码

## 📎 引用
论文已发布在 Arxiv， 
```bibtex
@misc{wang2025scoreperformanceefficienthumancontrollable,
      title={通过乐谱到表现：高效且可人为控制的长曲生成与小节级符号记谱}, 
      author={王通熙 and 余洋 and 王青 and 钱俊朗},
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