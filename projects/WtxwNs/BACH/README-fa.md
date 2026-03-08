<div align="right">
  <details>
    <summary >🌐 زبان</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=en">انگلیسی</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=ja">日本ی</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=ko">کره‌ای</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=hi">هندی</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=th">تایلندی</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=fr">فرانسوی</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=de">آلمانی</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=es">اسپانیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=it">ایتالیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=ru">روسی</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=pt">پرتغالی</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=nl">هلندی</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=pl">لهستانی</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=ar">العربیة</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=tr">ترکی</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=vi">ویتنامی</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=id">اندونزیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=as">অসমীয়া</
      </div>
    </div>
  </details>

</div>

<p align="center">
  <img src="https://raw.githubusercontent.com/WtxwNs/BACH/main/tokenpair.png" width="85%"/>
  <br><br>
  <i>مشاهده کنید که چگونه BACH توکن‌های خام را گام به گام به موسیقی ساختاریافته تبدیل می‌کند.</i>
</p>

# BACH: کمک‌یار هوشمند آهنگسازی سطح میزان  

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

&gt; *"از امتیاز تا اجرا: تولید آهنگ‌های طولانی با کنترل انسانی و نشانه‌گذاری نمادین سطح میزان"*  
&gt; ارسال به ICASSP 2026 – **پذیرفته شده**

---

## 🎼 خلاصه یک جمله‌ای  
BACH اولین مولد آهنگ نمادین **قابل ویرایش توسط انسان** و **سطح میزان** است:  
مدل LLM شعر می‌نویسد → ترنسفورمر امتیاز ABC را تولید می‌کند → رندرکننده‌های آماده موسیقی **چند دقیقه‌ای، سطح Suno** ارائه می‌دهند.  
**۱ میلیارد پارامتر**، استنتاج در سطح دقیقه، **بهترین منبع باز**.

---

## 📦 محتوای این مخزن (انتشار اولیه)
| مسیر | توضیحات |
|------|-------------|
| `README.md` | این فایل |
| `code/` | کد استنتاج |
| `example.mp3` | یک نمونه آهنگ |
| `fig/` | شکل معماری |

---

## 🏗️ معماری مدل (در یک نگاه)

درخواست کاربر
Qwen3 — شعر و برچسب‌های سبک
BACH-1B ترنسفورمر فقط رمزگشا
امتیاز ABC (Dual-NTP + Chain-of-Score)

ABC → MIDI → FluidSynth + VOCALOID
میکس استریو


| مؤلفه | ایده کلیدی |
|-----------|----------|
| **Dual-NTP** | پیش‌بینی مشترک `{vocal_patch, accomp_patch}` در هر مرحله |
| **Chain-of-Score** | برچسب‌های بخش `[START:Chorus] ... [END:Chorus]` برای انسجام بلندمدت |
| **Bar-stream patch** | پچ‌های ۱۶ کاراکتری بدون همپوشانی در هر میزان |

---

## 🧪 شروع سریع (مناسب برای CPU)
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

##  🎧 هم‌اکنون گوش دهید
example.mp3 برای شما آماده است، این یک آهنگ کامل است. می‌توانید آن را با Suno مقایسه کنید🙂

## انتشار کامل پس از پذیرش مقاله مرتبط
- مجموعه کامل داده‌های آموزش (ABC + اشعار + برچسب‌های ساختاری)
- وزن‌های BACH-1B (فرمت Transformers)
- اسکریپت‌های آموزش (چندمرحله‌ای + چندوظیفه‌ای + ICL)
- کد کامل

## 📎 استناد
مقاله در Arxiv منتشر شده است،
```bibtex
@misc{wang2025scoreperformanceefficienthumancontrollable,
      title={از نت تا اجرا: تولید آهنگ بلند مدت با کنترل انسانی و کارآمد با نمادگذاری سمبولیک سطح میزان}, 
      author={تونگشی وانگ و یانگ یو و چینگ وانگ و جونلانگ چیان},
      year={2025},
      eprint={2508.01394},
      archivePrefix={arXiv},
      primaryClass={cs.SD},
      url={https://arxiv.org/abs/2508.01394}, 
}


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-08

---