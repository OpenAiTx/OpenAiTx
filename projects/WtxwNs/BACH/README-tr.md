
<div align="right">
  <details>
    <summary >🌐 Dil</summary>
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
  <i>BACH'ın ham tokenleri yapılandırılmış müziğe nasıl dönüştürdüğünü adım adım izleyin.</i>
</p>

# BACH: Ölçü Seviyesinde Yapay Zeka Beste Yardımcısı
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

&gt; *"Via Score to Performance: Bar Düzeyinde Sembolik Gösterim ile Verimli, İnsan Kontrollü Uzun Şarkı Üretimi"*  
&gt; ICASSP 2026 Gönderimi – **Kabul Edildi**

---

## 🎼 Tek Cümlelik Özet  
BACH, ilk **insan tarafından düzenlenebilir**, **bar düzeyinde** sembolik şarkı üreticisidir:  
LLM şarkı sözlerini yazar → Transformer ABC puanını üretir → hazır dönüştürücülerle **dakikalarca, Suno seviyesinde** müzik çıkar.  
**1 B parametre**, **dakika seviyesinde** çıkarım, **SOTA açık kaynak**.

---

## 📦 Bu depoda neler var (önizleme sürümü)
| Yol | Açıklama |
|------|-------------|
| `README.md` | Bu dosya |
| `code/` | çıkarım kodu |
| `example.mp3` | örnek bir şarkı |
| `fig/` | Mimari figürü |

---

## 🏗️ Model Mimarisi (tek bakışta)

Kullanıcı istemi
Qwen3 — şarkı sözleri & stil etiketleri
BACH-1B Sadece-Çözücü Transformer
ABC puanı (Çift-NTP + Zincir-Puan)

ABC → MIDI → FluidSynth + VOCALOID
Stereo karışım


| Bileşen | Ana fikir |
|---------|-----------|
| **Çift-NTP** | Her adımda `{vocal_patch, accomp_patch}` birlikte tahmin edilir |
| **Partisyon Zinciri** | Uzun süreli uyum için bölüm etiketleri `[START:Chorus] ... [END:Chorus]` |
| **Bar-akış yamaları** | Her ölçü için 16 karakterlik çakışmayan yamalar |

---

## 🧪 Hızlı başlangıç (CPU dostu)
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

##  🎧 Şimdi dinle
example.mp3 senin için hazır, bu tam bir şarkı. Suno ile karşılaştırabilirsin🙂

## İlgili makalenin kabulü sonrası tam sürüm
- Tam eğitim seti (ABC + şarkı sözleri + yapı etiketleri)
- BACH-1B ağırlıkları (Transformers formatında)
- Eğitim betikleri (çok aşamalı + çok görevli + ICL)
- Tam Kod

## 📎 Atıf
Makale Arxiv'de yayımlandı,
```bibtex
@misc{wang2025scoreperformanceefficienthumancontrollable,
      title={Skordan Performansa: Ölçü Düzeyinde Sembolik Notasyon ile Verimli ve İnsan Kontrolünde Uzun Şarkı Üretimi}, 
      author={Tongxi Wang ve Yang Yu ve Qing Wang ve Junlang Qian},
      year={2025},
      eprint={2508.01394},
      archivePrefix={arXiv},
      primaryClass={cs.SD},
      url={https://arxiv.org/abs/2508.01394}, 
}


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-08

---