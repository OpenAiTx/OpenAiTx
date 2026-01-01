<p align="center">
  <img src="https://raw.githubusercontent.com/WtxwNs/BACH/main/tokenpair.png" width="85%"/>
  <br><br>
  <i>观看 BACH 如何一步步将原始标记转换为结构化音乐。</i>
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

&gt; *“通过乐谱到演奏：高效且人类可控的小节级符号乐曲长曲生成”*  
&gt; ICASSP 2026 投稿 – **审核中**

---

## 🎼 一句话总结  
BACH 是首个 **人类可编辑**、**小节级** 的符号歌曲生成器：  
大语言模型写歌词 → Transformer 输出 ABC 乐谱 → 现成渲染器生成 **数分钟、Suno 级别** 音乐。  
**10 亿参数**，**分钟级** 推理，**最先进开源**。

---

## 📦 本仓库内容（预览版）
| 路径 | 描述 |
|------|-------------|
| `README.md` | 本文件 |
| `code/` | 推理代码 |
| `example.mp3` | 示例歌曲 |
| `fig/` | 架构图 |

---

## 🏗️ 模型架构（一览）

用户提示
Qwen3 — 歌词与风格标签
BACH-1B 仅解码器变换器
ABC 分数（双重NTP + 乐谱链）
ABC → MIDI → FluidSynth + VOCALOID
立体声音轨


| 组件 | 关键思想 |
|-----------|----------|
| **双重NTP** | 每步联合预测 `{vocal_patch, accomp_patch}` |
| **乐谱链** | 章节标签 `[START:Chorus] ... [END:Chorus]` 保持长距离连贯性 |
| **小节流补丁** | 每小节16字符非重叠补丁 |

---

## 🧪 快速开始（CPU 友好）
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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-01

---