<div align="right">
  <details>
    <summary >🌐 भाषा</summary>
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
  <i>देखें कि कैसे BACH कच्चे टोकन्स को क्रमबद्ध संगीत में बदलता है—चरण दर चरण।</i>
</p>

# BACH: बार-स्तरीय एआई संगीत रचना सहायक  

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

&gt; *"स्कोर से प्रदर्शन तक: बार-स्तरीय प्रतीकात्मक नोटेशन के साथ दक्ष मानव-नियंत्रित लंबी गीत उत्पन्न"*  
&gt; ICASSP 2026 सबमिशन – **स्वीकृत**

---

## 🎼 एक-वाक्य सारांश  
BACH पहला **मानव-संपादित**, **बार-स्तरीय** प्रतीकात्मक गीत जनरेटर है:  
LLM गीत लिखता है → ट्रांसफॉर्मर ABC स्कोर उत्पन्न करता है → तैयार रेंडरर्स **मिनटों-लंबी, Suno-स्तर** संगीत देते हैं।  
**1 B पैरामीटर**, **मिनट-स्तर** इंफेरेंस, **SOTA ओपन-सोर्स**।

---

## 📦 इस रिपॉजिटरी में क्या है (पूर्वावलोकन रिलीज़)
| पथ | विवरण |
|------|-------------|
| `README.md` | यह फ़ाइल |
| `code/` | इंफेरेंस कोड |
| `example.mp3` | एक उदाहरण गीत |
| `fig/` | आर्किटेक्चर चित्र |

---

## 🏗️ मॉडल आर्किटेक्चर (एक नज़र में)

उपयोगकर्ता प्रॉम्प्ट
Qwen3 — गीत एवं शैली टैग्स
BACH-1B डिकोडर-ओनली ट्रांसफॉर्मर
ABC स्कोर (Dual-NTP + Chain-of-Score)

ABC → MIDI → FluidSynth + VOCALOID
स्टीरियो मिक्स


| घटक | प्रमुख विचार |
|-----------|----------|
| **Dual-NTP** | हर चरण में `{vocal_patch, accomp_patch}` को संयुक्त रूप से भविष्यवाणी करें |
| **Chain-of-Score** | लंबी एकरूपता के लिए अनुभाग टैग `[START:Chorus] ... [END:Chorus]` |
| **Bar-stream patch** | प्रति बार 16-अक्षर गैर-ओवरलैपिंग पैचेस |

---

## 🧪 त्वरित प्रारंभ (CPU के लिए अनुकूल)
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

##  🎧 अभी सुनें
example.mp3 आपके लिए तैयार है, यह एक पूरा गाना है। आप इसकी तुलना Suno🙂 से कर सकते हैं

## संबंधित पेपर की स्वीकृति पर पूर्ण रिलीज़
- संपूर्ण प्रशिक्षण सेट (ABC + गीत + संरचना लेबल)
- BACH-1B वज़न (ट्रांसफॉर्मर फॉर्मेट)
- प्रशिक्षण स्क्रिप्ट्स (मल्टीफेज़ + मल्टीटास्क + ICL)
- संपूर्ण कोड

## 📎 संदर्भ
पेपर Arxiv पर जारी किया गया है,
```bibtex
@misc{wang2025scoreperformanceefficienthumancontrollable,
      title={स्कोर से प्रदर्शन तक: बार-स्तरीय प्रतीकात्मक संकेतन के साथ कुशल मानव-नियंत्रित लंबा गीत निर्माण}, 
      author={टोंगशी वांग और यांग यू और किंग वांग और जुनलांग कियान},
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