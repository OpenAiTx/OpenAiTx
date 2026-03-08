
<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
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
  <i>Lihat bagaimana BACH mengubah token mentah menjadi musik terstruktur—langkah demi langkah.</i>
</p>

# BACH: Pembantu Komposisi AI Tingkat Bar
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

&gt; *"Via Score to Performance: Efficient Human-Controllable Long Song Generation with Bar-Level Symbolic Notation"*  
&gt; ICASSP 2026 Submission – **Diterima**

---

## 🎼 Ringkasan Satu Kalimat  
BACH adalah generator lagu simbolik tingkat bar pertama yang **dapat diedit manusia**:  
LLM menulis lirik → Transformer mengeluarkan skor ABC → renderer siap pakai menghasilkan musik **berdurasi menit, setara Suno**.  
**1 B parameter**, inferensi **tingkat menit**, **open-source SOTA**.

---

## 📦 Apa yang ada di repo ini (rilis pratinjau)
| Path | Deskripsi |
|------|-------------|
| `README.md` | File ini |
| `code/` | kode inferensi |
| `example.mp3` | contoh lagu |
| `fig/` | Gambar arsitektur |

---

## 🏗️ Arsitektur Model (sekilas)

Prompt pengguna
Qwen3 — lirik & tag gaya
BACH-1B Decoder-Only Transformer
Skor ABC (Dual-NTP + Chain-of-Score)

ABC → MIDI → FluidSynth + VOCALOID
Stereo mix


| Komponen | Ide utama |
|-----------|----------|
| **Dual-NTP** | Memprediksi `{vocal_patch, accomp_patch}` secara bersama di setiap langkah |
| **Chain-of-Score** | Tag bagian `[START:Chorus] ... [END:Chorus]` untuk koherensi panjang |
| **Bar-stream patch** | Patch 16 karakter tanpa tumpang tindih per bar |

---

## 🧪 Mulai cepat (ramah CPU)
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

##  🎧 Dengarkan sekarang
example.mp3 sudah siap untuk Anda, ini adalah lagu lengkap. Anda dapat membandingkannya dengan Suno🙂

## Rilis penuh setelah makalah terkait diterima
- Set pelatihan lengkap (ABC + lirik + label struktur)
- Bobot BACH-1B (format Transformers)
- Skrip pelatihan (multifase + multitugas + ICL)
- Kode lengkap

## 📎 Sitasi
Makalah telah dirilis di Arxiv,
```bibtex
@misc{wang2025scoreperformanceefficienthumancontrollable,
      title={Melalui Skor ke Performa: Generasi Lagu Panjang yang Efisien dan Dapat Dikontrol Manusia dengan Notasi Simbolik Tingkat-Bar}, 
      author={Tongxi Wang dan Yang Yu dan Qing Wang dan Junlang Qian},
      year={2025},
      eprint={2508.01394},
      archivePrefix={arXiv},
      primaryClass={cs.SD},
      url={https://arxiv.org/abs/2508.01394}, 
}


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-08

---