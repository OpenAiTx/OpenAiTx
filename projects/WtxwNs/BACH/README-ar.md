
<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
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
  <i>شاهد كيف يحول BACH الرموز الخام إلى موسيقى منظمة - خطوة بخطوة.</i>
</p>

# باخ: مساعد التأليف بالذكاء الاصطناعي على مستوى المقاطع  
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

&gt; *"من النوتة إلى الأداء: توليد أغاني طويلة بكفاءة مع إمكانية التحكم البشري على مستوى المازورة باستخدام الترميز الرمزي"*  
&gt; تقديم إلى ICASSP 2026 – **تم القبول**

---

## 🎼 ملخص بجملة واحدة  
BACH هو أول مولد أغاني رمزية **قابل للتحرير البشري** و**على مستوى المازورة**:  
النموذج اللغوي يكتب الكلمات → المحول يُنتج نوتة ABC → برامج التوليف الجاهزة تعطي موسيقى **طويلة بالدقائق، بمستوى Suno**.  
**مليار معلمة**، استنتاج بمستوى الدقائق، **أفضل أداء مفتوح المصدر**.

---

## 📦 ما يحتويه هذا المستودع (إصدار معاينة)
| المسار | الوصف |
|------|-------------|
| `README.md` | هذا الملف |
| `code/` | كود الاستنتاج |
| `example.mp3` | أغنية مثال |
| `fig/` | شكل البنية المعمارية |

---

## 🏗️ بنية النموذج (نظرة سريعة)

طلب المستخدم
Qwen3 — كلمات الأغاني وعلامات النمط
BACH-1B Transformer مع فك التشفير فقط
نوتة ABC (ثنائي-NTP + سلسلة النوتات)

ABC → MIDI → FluidSynth + VOCALOID
مزيج ستيريو


| المكون | الفكرة الرئيسية |
|-----------|----------|
| **التحكم المزدوج NTP** | توقع `{vocal_patch, accomp_patch}` معًا في كل خطوة |
| **سلسلة العلامات الموسيقية** | علامات الأقسام `[START:Chorus] ... [END:Chorus]` للحفاظ على الترابط الطويل |
| **تصحيح شريط التدفق** | تصحيحات غير متداخلة من 16 حرفًا لكل شريط |

---

## 🧪 البدء السريع (متوافق مع وحدة المعالجة المركزية)
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

##  🎧 استمع الآن
example.mp3 جاهز لك، إنه أغنية كاملة. يمكنك مقارنته مع Suno🙂

## الإصدار الكامل عند قبول الورقة العلمية ذات الصلة
- مجموعة التدريب الكاملة (ABC + كلمات الأغاني + تسميات الهيكل)
- أوزان BACH-1B (صيغة المحولات)
- سكريبتات التدريب (متعدد المراحل + متعدد المهام + ICL)
- الكود الكامل

## 📎 الاقتباس
تم نشر الورقة العلمية على Arxiv،
@misc{wang2025scoreperformanceefficienthumancontrollable,
      title={من النوتة إلى الأداء: توليد أغاني طويلة بكفاءة وقابلية تحكم بشرية باستخدام التدوين الرمزي على مستوى المازورة}, 
      author={تونغشي وانغ ويانغ يو وتشينغ وانغ وجونلانغ تشيان},
      year={2025},
      eprint={2508.01394},
      archivePrefix={arXiv},
      primaryClass={cs.SD},
      url={https://arxiv.org/abs/2508.01394}, 
}



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-08

---