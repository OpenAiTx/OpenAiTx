
<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<div align="center">

# ZipVoice⚡

## تحويل النص إلى كلام سريع وعالي الجودة بدون تدريب مسبق باستخدام مطابقة التدفق
</div>

## نظرة عامة

ZipVoice هي سلسلة من نماذج تحويل النص إلى كلام (TTS) السريعة وعالية الجودة بدون تدريب مسبق، تعتمد على تقنية مطابقة التدفق.

### 1. الميزات الرئيسية

- صغيرة وسريعة: تحتوي فقط على 123 مليون معامل.

- استنساخ صوت عالي الجودة: أداء متقدم في تشابه المتحدث، والوضوح، والطبيعية.

- متعددة اللغات: تدعم الصينية والإنجليزية.

- متعددة الأنماط: تدعم توليد الكلام لمتحدث واحد أو الحوار.

### 2. أنواع النماذج

<table>
  <thead>
    <tr>
      <th>اسم النموذج</th>
      <th>الوصف</th>
      <th>البحث العلمي</th>
      <th>التجربة</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>ZipVoice</td>
      <td>النموذج الأساسي الذي يدعم تحويل النص إلى كلام بدون تدريب مسبق لمتحدث واحد بالصينية والإنجليزية.</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2506.13053"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Distill</td>
      <td>النسخة المقطرة من ZipVoice، وتتميز بسرعة محسنة مع تدهور طفيف في الأداء.</td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog</td>
      <td>نموذج توليد الحوار مبني على ZipVoice، وقادر على توليد حوارات منطوقة لطرفين في قناة واحدة.</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2507.09318"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice-dialog.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog-Stereo</td>
      <td>النسخة الستيريو من ZipVoice-Dialog، والتي تتيح توليد حوارات ثنائية القناة مع تخصيص كل متحدث لقناة منفصلة.</td>
    </tr>
  </tbody>
</table>

## الأخبار

**2025/07/14**: تم إصدار **ZipVoice-Dialog** و **ZipVoice-Dialog-Stereo**، وهما نموذجان لتوليد الحوارات المنطوقة. [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice-dialog.github.io)

**2025/07/14**: تم إصدار قاعدة بيانات **OpenDialog**، وهي قاعدة بيانات للحوارات المنطوقة مدتها 6.8 ألف ساعة. يمكن التحميل من [![hf](https://img.shields.io/badge/%F0%9F%A4%97%20HuggingFace-Dataset-yellow)](https://huggingface.co/datasets/k2-fsa/OpenDialog)، [![ms](https://img.shields.io/badge/ModelScope-Dataset-blue?logo=data)](https://www.modelscope.cn/datasets/k2-fsa/OpenDialog). تفاصيل إضافية على [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318).

**2025/06/16**: تم إصدار **ZipVoice** و **ZipVoice-Distill**. [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2506.13053) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice.github.io)

## التثبيت

### 1. استنساخ مستودع ZipVoice

```bash
git clone https://github.com/k2-fsa/ZipVoice.git
```
### 2. (اختياري) إنشاء بيئة افتراضية في بايثون


```bash
python3 -m venv zipvoice
source zipvoice/bin/activate
```
### 3. تثبيت الحزم المطلوبة


```bash
pip install -r requirements.txt
```
### 4. تثبيت k2 للتدريب أو الاستدلال الفعال

**k2 ضروري للتدريب** ويمكنه تسريع الاستدلال. ومع ذلك، لا يزال بإمكانك استخدام وضع الاستدلال في ZipVoice دون تثبيت k2.

> **ملاحظة:** تأكد من تثبيت إصدار k2 الذي يتوافق مع إصدار PyTorch و CUDA لديك. على سبيل المثال، إذا كنت تستخدم pytorch 2.5.1 و CUDA 12.1، يمكنك تثبيت k2 كما يلي:


```bash
pip install k2==1.24.4.dev20250208+cuda12.1.torch2.5.1 -f https://k2-fsa.github.io/k2/cuda.html
```
يرجى الرجوع إلى https://k2-fsa.org/get-started/k2/ لمزيد من التفاصيل.
يمكن للمستخدمين في الصين القارية الرجوع إلى https://k2-fsa.org/zh-CN/get-started/k2/.

- للتحقق من تثبيت k2:


```bash
python3 -c "import k2; print(k2.__file__)"
```
## الاستخدام

### 1. توليد الكلام لمتحدث واحد

لتوليد كلام لمتحدث واحد باستخدام نماذج ZipVoice أو ZipVoice-Distill المدربة مسبقًا، استخدم الأوامر التالية (سيتم تنزيل النماذج المطلوبة من HuggingFace):

#### 1.1 الاستدلال على جملة واحدة


```bash
python3 -m zipvoice.bin.infer_zipvoice \
    --model-name zipvoice \
    --prompt-wav prompt.wav \
    --prompt-text "I am the transcription of the prompt wav." \
    --text "I am the text to be synthesized." \
    --res-wav-path result.wav
```
- يمكن أن تكون قيمة `--model-name` هي `zipvoice` أو `zipvoice_distill`، حيث تمثل النماذج قبل وبعد التقطير على التوالي.
- إذا ظهرت `<>` أو `[]` في النص، فسيتم التعامل مع السلاسل المحاطة بها على أنها رموز خاصة. تشير `<>` إلى كتابة بينيين الصينية، و`[]` تشير إلى علامات خاصة أخرى.

#### 1.2 استنتاج قائمة من الجمل

```bash
python3 -m zipvoice.bin.infer_zipvoice \
    --model-name zipvoice \
    --test-list test.tsv \
    --res-dir results
```
- كل سطر في ملف `test.tsv` يكون بالصيغة `{wav_name}\t{prompt_transcription}\t{prompt_wav}\t{text}`.

### 2. توليد الكلام الحواري

#### 2.1 أمر الاستدلال

لإنشاء حوارات منطوقة ثنائية الأطراف باستخدام نماذج ZipVoice-Dialogue أو ZipVoice-Dialogue-Stereo المدربة مسبقًا، استخدم الأوامر التالية (سيتم تحميل النماذج المطلوبة من HuggingFace):


```bash
python3 -m zipvoice.bin.infer_zipvoice_dialog \
    --model-name "zipvoice_dialog" \
    --test-list test.tsv \
    --res-dir results
```
- يمكن أن تكون قيمة `--model-name` هي `zipvoice_dialog` أو `zipvoice_dialog_stereo`,
    حيث تقوم بتوليد حوارات أحادية أو ثنائية القناة على التوالي.

#### 2.2 تنسيقات الإدخال

كل سطر في ملف `test.tsv` يكون بأحد التنسيقات التالية:

(1) **تنسيق الموجه المدمج** حيث يتم دمج ملفات الصوت والنصوص الخاصة بمتحدثين اثنين في ملف موجه واحد:

```
{wav_name}\t{prompt_transcription}\t{prompt_wav}\t{text}
```

- `wav_name` هو اسم ملف wav الناتج.
- `prompt_transcription` هو نص تفريغ ملف wav الخاص بالمحادثة، مثل "[S1] مرحباً. [S2] كيف حالك؟"
- `prompt_wav` هو مسار ملف wav الخاص بالمحادثة.
- `text` هو النص المراد توليفه، مثل "[S1] أنا بخير. [S2] ما اسمك؟ [S1] أنا إريك. [S2] مرحباً إريك."

(2) **تنسيق المحادثة المقسمة** حيث توجد تسجيلات الصوت والنصوص التفريغية للمتحدثين الاثنين في ملفات منفصلة:

```
{wav_name}\t{spk1_prompt_transcription}\t{spk2_prompt_transcription}\t{spk1_prompt_wav}\t{spk2_prompt_wav}\t{text}
```
- `wav_name` هو اسم ملف wav الناتج.
- `spk1_prompt_transcription` هو نص الموجه لملف wav الخاص بالمتحدث الأول، مثل "مرحباً"
- `spk2_prompt_transcription` هو نص الموجه لملف wav الخاص بالمتحدث الثاني، مثل "كيف حالك؟"
- `spk1_prompt_wav` هو مسار ملف wav الخاص بالموجه للمتحدث الأول.
- `spk2_prompt_wav` هو مسار ملف wav الخاص بالموجه للمتحدث الثاني.
- `text` هو النص المراد توليده، مثل "[S1] أنا بخير. [S2] ما اسمك؟ [S1] اسمي إريك. [S2] مرحباً إريك."

### 3 إرشادات للاستخدام الأفضل:

#### 3.1 طول الموجه

نوصي باستخدام ملف wav موجه قصير (على سبيل المثال، أقل من 3 ثوانٍ لتوليد الكلام لمتحدث واحد، وأقل من 10 ثوانٍ لتوليد كلام الحوار) لزيادة سرعة الاستنتاج. الموجه الطويل جداً سيبطئ الاستنتاج ويؤدي إلى تدهور جودة الصوت.

#### 3.2 تحسين السرعة

إذا كانت سرعة الاستنتاج غير مرضية، يمكنك تسريعها كما يلي:

- **نمذجة التكثيف وخطوات أقل**: بالنسبة لنموذج توليد الكلام للمتحدث الواحد، نستخدم نموذج `zipvoice` افتراضياً لجودة صوت أفضل. إذا كانت السرعة أولوية، يمكنك التبديل إلى `zipvoice_distill` وتقليل قيمة `--num-steps` إلى أدنى حد وهو `4` (القيمة الافتراضية 8).

- **تسريع وحدة المعالجة المركزية باستخدام تعدد الخيوط**: عند التشغيل على وحدة المعالجة المركزية، يمكنك تمرير معامل `--num-thread` (مثلاً، `--num-thread 4`) لزيادة عدد الخيوط وتسريع الأداء. القيمة الافتراضية هي خيط واحد.

- **تسريع وحدة المعالجة المركزية باستخدام ONNX**: عند التشغيل على وحدة المعالجة المركزية، يمكنك استخدام نماذج ONNX مع `zipvoice.bin.infer_zipvoice_onnx` لزيادة السرعة (لم يتم دعم ONNX بعد لنماذج توليد الحوار). لمزيد من السرعة، يمكنك ضبط `--onnx-int8 True` لاستخدام نموذج ONNX كمي INT8. لاحظ أن النموذج المكمي يؤدي إلى تدهور جودة الصوت بدرجة معينة. **لا تستخدم ONNX على وحدة معالجة الرسومات**، لأنه أبطأ من PyTorch على وحدة معالجة الرسومات.

#### 3.3 التحكم في الذاكرة

سيتم تقسيم النص المقدم إلى أجزاء بناءً على علامات الترقيم (لتوليد الكلام للمتحدث الواحد) أو رمز تبديل المتحدث (لتوليد كلام الحوار). بعد ذلك، تتم معالجة النصوص المجزأة على دفعات. وبالتالي، يمكن للنموذج معالجة نص طويل جداً باستخدام ذاكرة شبه ثابتة. يمكنك التحكم في استخدام الذاكرة عن طريق ضبط معامل `--max-duration`.

#### 3.4 التقييم "الخام"

بشكل افتراضي، نقوم بمعالجة المدخلات مسبقاً (ملف wav للموجه، نص الموجه، والنص) لتحقيق استنتاج فعال وأداء أفضل. إذا رغبت في تقييم أداء النموذج "الخام" باستخدام المدخلات المقدمة بالضبط (مثل لإعادة إنتاج نتائج بحثنا)، يمكنك تمرير `--raw-evaluation True`.

#### 3.5 النصوص القصيرة

عند توليد الكلام لنصوص قصيرة جداً (مثل كلمة أو كلمتين)، قد يتجاهل الكلام الناتج أحياناً بعض النطق. لحل هذه المشكلة، يمكنك تمرير `--speed 0.3` (حيث 0.3 قيمة قابلة للضبط) لتمديد مدة الكلام الناتج.

#### 3.6 تصحيح نطق حروف الصينية متعددة الأصوات

نستخدم [pypinyin](https://github.com/mozillazg/python-pinyin) لتحويل الحروف الصينية إلى بينيين. ومع ذلك، قد يخطئ أحياناً في نطق **الحروف متعددة الأصوات** (多音字).


لتصحيح هذه الأخطاء في النطق يدويًا، ضع **التهجئة الصحيحة (بينيين)** بين علامات الزاوية `< >` وضمنها **علامة النبرة**.

**مثال:**

- النص الأصلي: `这把剑长三十公分`
- صحح تهجئة كلمة `长`:  `这把剑<chang2>三十公分`

> **ملاحظة:** إذا أردت تعيين عدة تهجئات يدويًا، ضع كل تهجئة بين `<>`، مثل: `这把<jian4><chang2><san1>十公分`

#### 3.7 إزالة الفترات الطويلة من الصمت في الكلام الناتج

سيحدد النموذج تلقائيًا مواضع وأطوال الفترات الصامتة في الكلام الناتج. أحيانًا تظهر فترات صمت طويلة في منتصف الكلام. إذا كنت لا ترغب بذلك، يمكنك تمرير الخيار `--remove-long-sil` لإزالة الفترات الطويلة في منتصف الكلام الناتج (سيتم إزالة الفترات الصامتة في الأطراف تلقائيًا).

#### 3.8 تنزيل النموذج

إذا واجهت مشكلة في الاتصال بـ HuggingFace أثناء تنزيل النماذج المدربة مسبقًا، جرب تغيير نقطة النهاية إلى الموقع المرآة: `export HF_ENDPOINT=https://hf-mirror.com`.

## تدريب نموذجك الخاص

راجع دليل [egs](egs) لأمثلة التدريب، وضبط النموذج، والتقييم.

## النشر باستخدام C++

راجع [sherpa-onnx](https://github.com/k2-fsa/sherpa-onnx/pull/2487#issuecomment-3227884498) لحل النشر باستخدام لغة C++ على وحدة المعالجة المركزية.

## المناقشة والتواصل

يمكنك المناقشة مباشرة عبر [Github Issues](https://github.com/k2-fsa/ZipVoice/issues).

يمكنك أيضًا مسح رمز الاستجابة السريعة للانضمام إلى مجموعة Wechat أو متابعة الحساب الرسمي لـ Wechat.

| مجموعة Wechat | الحساب الرسمي لـ Wechat |
| ------------- | ----------------------- |
|![wechat](https://k2-fsa.org/zh-CN/assets/pic/wechat_group.jpg) |![wechat](https://k2-fsa.org/zh-CN/assets/pic/wechat_account.jpg) |

## الاقتباس

```bibtex
@article{zhu2025zipvoice,
      title={ZipVoice: Fast and High-Quality Zero-Shot Text-to-Speech with Flow Matching},
      author={Zhu, Han and Kang, Wei and Yao, Zengwei and Guo, Liyong and Kuang, Fangjun and Li, Zhaoqing and Zhuang, Weiji and Lin, Long and Povey, Daniel},
      journal={arXiv preprint arXiv:2506.13053},
      year={2025}
}

@article{zhu2025zipvoicedialog,
      title={ZipVoice-Dialog: Non-Autoregressive Spoken Dialogue Generation with Flow Matching},
      author={Zhu, Han and Kang, Wei and Guo, Liyong and Yao, Zengwei and Kuang, Fangjun and Zhuang, Weiji and Li, Zhaoqing and Han, Zhifeng and Zhang, Dong and Zhang, Xin and Song, Xingchen and Lin, Long and Povey, Daniel},
      journal={arXiv preprint arXiv:2507.09318},
      year={2025}
}
```




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-06

---