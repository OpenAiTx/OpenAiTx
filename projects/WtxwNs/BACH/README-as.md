<div align="right">
  <details>
    <summary >🌐 ভাষা</summary>
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
  <i>চাওক কিদৰে BACH-এ কাঁচা টোকেন সমূহক গাঠনিক সংগীতত ৰূপান্তৰ কৰে—পদে পদে।</i>
</p>

# BACH: বাৰ-স্তৰৰ AI সংগীত ৰচনাৰ সহায়ক  

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

&gt; *"Score to Performance ৰ জৰিয়তে: Efficient Human-Controllable Long Song Generation with Bar-Level Symbolic Notation"*  
&gt; ICASSP 2026 Submission – **Accepted**

---

## 🎼 এটা বাক্যত সংক্ষিপ্তসাৰ  
BACH হৈছে প্ৰথম **মানৱ-সম্পাদনযোগ্য**, **বার-লেভেল** প্ৰতিকী গান জেনাৰেটৰ:  
LLM গীত লিখে → Transformer ABC স্ক'ৰ উৎপন্ন কৰে → off-the-shelf renderer ৰে **মিনিট-দীর্ঘ, Suno-লেভেল** সংগীত সৃষ্টি।  
**১ B পেৰাম**, **মিনিট-লেভেল** inference, **SOTA মুক্ত উৎস**।

---

## 📦 এই ৰিপ' ত কি আছে (preview release)
| Path | বিৱৰণ |
|------|-------------|
| `README.md` | এই ফাইল |
| `code/` | inference code |
| `example.mp3` | এটা উদাহৰণ গান |
| `fig/` | Architecture ৰ ছবি |

---

## 🏗️ Model Architecture (এটা চাউনি)

User prompt
Qwen3 — গীত আৰু ষ্টাইল টেগ
BACH-1B Decoder-Only Transformer
ABC স্ক'ৰ (Dual-NTP + Chain-of-Score)

ABC → MIDI → FluidSynth + VOCALOID
ষ্টেৰিঅ' মিক্স


| উপাদান | মূল ধাৰণা |
|-----------|----------|
| **ডুয়েল-এনটিপি** | প্ৰতিটো খোজত `{vocal_patch, accomp_patch}` সংযুক্তভাৱে পূৰ্বানুমান কৰক |
| **চেইন-অ'ফ-স্ক'ৰ** | দীঘল সংগতিৰ বাবে ছেকচন টেগছ `[START:Chorus] ... [END:Chorus]` ব্যৱহাৰ কৰক |
| **বাৰ-ষ্ট্ৰীম পেচ** | প্ৰতিবাৰত ১৬-চৰ অ-অৱৰ্লেপিং পেচ |

---

## 🧪 দ্ৰুত আৰম্ভণি (চিপিইউ অনুকূল)
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

##  🎧 এতিয়া শুনক
example.mp3 আপুনাৰ বাবে সাজু হৈ আছে, এইটো এটা সম্পূৰ্ণ গীত। আপুনি ইয়াক Suno🙂ৰ সৈতে তুলনা কৰিব পাৰে

## সম্পূৰ্ণ মুক্তি সম্পৰ্কিত কাগজ গ্ৰহণ হোৱাৰ পিছত
- সম্পূৰ্ণ প্ৰশিক্ষণ ছেট (ABC + গীতৰ পদ্য + গঠন লেবেল)
- BACH-1B ওজন (ট্ৰান্সফৰ্মাৰ ফৰ্মেট)
- প্ৰশিক্ষণ স্ক্ৰিপ্ট (বহু পৰ্যায় + বহু কাৰ্য + ICL)
- সম্পূৰ্ণ ক'ড

## 📎 উদ্ধৃতি
কাগজখন Arxiv-ত মুক্তি দিয়া হৈছে,
```bibtex
@misc{wang2025scoreperformanceefficienthumancontrollable,
      title={স্ক'ৰৰ জৰিয়তে পৰফৰ্মেন্স: বাৰ-স্তৰৰ প্ৰতীকী নোটেশ্যনৰ সৈতে দক্ষ মানুহ-নিয়ন্ত্ৰণযোগ্য দীঘল গীত সৃষ্টি}, 
      author={Tongxi Wang আৰু Yang Yu আৰু Qing Wang আৰু Junlang Qian},
      year={2025},
      eprint={2508.01394},
      archivePrefix={arXiv},
      primaryClass={cs.SD},
      url={https://arxiv.org/abs/2508.01394}, 
}


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-08

---