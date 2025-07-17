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

## تحويل النص إلى كلام سريع وعالي الجودة بدون تدريب مسبق باستخدام تدفق المطابقة
</div>

## نظرة عامة

ZipVoice هي سلسلة من نماذج تحويل النص إلى كلام السريعة وعالية الجودة بدون تدريب مسبق، وتعتمد على تقنية تدفق المطابقة.

### 1. الميزات الرئيسية

- صغير وسريع: فقط 123 مليون معلمة.

- استنساخ صوت عالي الجودة: أداء رائد في تشابه المتحدث، والوضوح، والطبيعية.

- متعدد اللغات: يدعم الصينية والإنجليزية.

- متعدد الأوضاع: يدعم توليد الكلام لمتحدث واحد أو الحوار.

### 2. أنواع النماذج

<table>
  <thead>
    <tr>
      <th>اسم النموذج</th>
      <th>الوصف</th>
      <th>البحث</th>
      <th>العرض التوضيحي</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>ZipVoice</td>
      <td>النموذج الأساسي الذي يدعم تحويل النص إلى كلام لمتحدث واحد بدون تدريب مسبق باللغتين الصينية والإنجليزية.</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2506.13053"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Distill</td>
      <td>النسخة المقطرة من ZipVoice، وتتميز بسرعة أكبر مع انخفاض طفيف في الأداء.</td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog</td>
      <td>نموذج توليد الحوار مبني على ZipVoice، قادر على توليد حوارات منطوقة بين طرفين على قناة واحدة.</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2507.09318"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice-dialog.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog-Stereo</td>
      <td>النسخة الاستيريو من ZipVoice-Dialog، والتي تتيح توليد حوارات ثنائية القناة مع تخصيص كل متحدث لقناة منفصلة.</td>
    </tr>
  </tbody>
</table>

## الأخبار

**2025/07/14**: تم إصدار **ZipVoice-Dialog** و **ZipVoice-Dialog-Stereo**، وهما نموذجان لتوليد الحوارات المنطوقة. [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice-dialog.github.io)

**2025/07/14**: تم إصدار مجموعة بيانات **OpenDialog**، وهي مجموعة بيانات حوار منطوق مدتها 6.8 آلاف ساعة. التحميل من [![hf](https://img.shields.io/badge/%F0%9F%A4%97%20HuggingFace-Dataset-yellow)](https://huggingface.co/datasets/k2-fsa/OpenDialog)، [![ms](https://img.shields.io/badge/ModelScope-Dataset-blue?logo=data)](https://www.modelscope.cn/datasets/k2-fsa/OpenDialog). تحقق من التفاصيل على [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318).

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
### 4. (اختياري) تثبيت k2 من أجل التدريب أو الاستدلال الفعال

k2 ضروري للتدريب ويمكنه تسريع الاستدلال. ومع ذلك، لا يزال بإمكانك استخدام وضع الاستدلال في ZipVoice دون تثبيت k2.

> **ملاحظة:** تأكد من تثبيت إصدار k2 الذي يتوافق مع إصدار PyTorch و CUDA لديك. على سبيل المثال، إذا كنت تستخدم pytorch 2.5.1 و CUDA 12.1، يمكنك تثبيت k2 كما يلي:


```bash
pip install k2==1.24.4.dev20250208+cuda12.1.torch2.5.1 -f https://k2-fsa.github.io/k2/cuda.html
```
يرجى الرجوع إلى https://k2-fsa.org/get-started/k2/ لمزيد من التفاصيل.
يمكن للمستخدمين في الصين الرجوع إلى https://k2-fsa.org/zh-CN/get-started/k2/.

## الاستخدام

### 1. توليد الكلام لمتحدث واحد

لتوليد كلام لمتحدث واحد باستخدام نماذج ZipVoice أو ZipVoice-Distill المدربة مسبقاً، استخدم الأوامر التالية (سيتم تنزيل النماذج المطلوبة من HuggingFace):

#### 1.1 استدلال جملة واحدة


```bash
python3 -m zipvoice.bin.infer_zipvoice \
    --model-name zipvoice \
    --prompt-wav prompt.wav \
    --prompt-text "I am the transcription of the prompt wav." \
    --text "I am the text to be synthesized." \
    --res-wav-path result.wav
```
- يمكن أن تكون قيمة `--model-name` إما `zipvoice` أو `zipvoice_distill`، وهما النموذجان قبل وبعد التقطير على التوالي.
- إذا ظهرت الرموز `<>` أو `[]` في النص، فسيتم اعتبار السلاسل المحاطة بها كرموز خاصة. `<>` تشير إلى بينيين الصينية و`[]` تشير إلى علامات خاصة أخرى.
- يمكن تشغيل نماذج ONNX على وحدة المعالجة المركزية بشكل أسرع باستخدام `zipvoice.bin.infer_zipvoice_onnx`.

> **ملاحظة:** إذا واجهت مشاكل في الاتصال بـ HuggingFace، جرب ما يلي:
> ```bash
> export HF_ENDPOINT=https://hf-mirror.com
> ```

#### 1.2 الاستدلال لقائمة من الجمل


```bash
python3 -m zipvoice.bin.infer_zipvoice \
    --model-name zipvoice \
    --test-list test.tsv \
    --res-dir results
```
- كل سطر في ملف `test.tsv` هو بالصيغة التالية: `{wav_name}\t{prompt_transcription}\t{prompt_wav}\t{text}`.

### 2. توليد الحوار المنطوق

#### 2.1 أمر الاستدلال

لإنشاء حوارات منطوقة بين طرفين باستخدام نماذجنا المدربة مسبقًا ZipVoice-Dialogue أو ZipVoice-Dialogue-Stereo، استخدم الأوامر التالية (سيتم تحميل النماذج المطلوبة من HuggingFace):


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
- `prompt_transcription` هو نص تفريغ المقطع الصوتي الحواري، مثل: "[S1] مرحبًا. [S2] كيف حالك؟"
- `prompt_wav` هو مسار ملف wav الخاص بالمقطع الحواري.
- `text` هو النص المطلوب توليده، مثل: "[S1] أنا بخير. [S2] ما اسمك؟"

(2) **تنسيق المقطع المنقسم** حيث توجد المقاطع الصوتية والتفريغات النصية للمتحدثين الاثنين في ملفات منفصلة:


```
{wav_name}\t{spk1_prompt_transcription}\t{spk2_prompt_transcription}\t{spk1_prompt_wav}\t{spk2_prompt_wav}\t{text}'
```
- `wav_name` هو اسم ملف wav الناتج.
- `spk1_prompt_transcription` هو نص المقطع الصوتي للمتحدث الأول، مثل "Hello"
- `spk2_prompt_transcription` هو نص المقطع الصوتي للمتحدث الثاني، مثل "How are you?"
- `spk1_prompt_wav` هو مسار ملف wav لمقطع المتحدث الأول.
- `spk2_prompt_wav` هو مسار ملف wav لمقطع المتحدث الثاني.
- `text` هو النص المطلوب توليده، مثل "[S1] I'm fine. [S2] What's your name?"

### 3. ميزات أخرى

#### 3.1 تصحيح نطق الأحرف الصينية متعددة النطق

نستخدم [pypinyin](https://github.com/mozillazg/python-pinyin) لتحويل الأحرف الصينية إلى بينيين. ومع ذلك، قد يحدث أحياناً أن يتم نطق **الأحرف متعددة النطق** (多音字) بشكل خاطئ.

لتصحيح هذه الأخطاء يدوياً، ضع **البينيين المصحح** بين أقواس زاوية `< >` وأضف **علامة النبرة**.

**مثال:**

- النص الأصلي: `这把剑长三十公分`
- تصحيح بينيين `长`:  `这把剑<chang2>三十公分`

> **ملاحظة:** إذا أردت تعيين عدة بينيين يدوياً، ضع كل بينيين بين `<>`، مثل: `这把<jian4><chang2><san1>十公分`

## درّب نموذجك الخاص

راجع دليل [egs](egs) للحصول على أمثلة التدريب وضبط النماذج.

## النقاش والتواصل

يمكنك النقاش مباشرة على [Github Issues](https://github.com/k2-fsa/ZipVoice/issues).

يمكنك أيضاً مسح رمز الاستجابة السريعة للانضمام إلى مجموعة وي تشات الخاصة بنا أو متابعة الحساب الرسمي.

| مجموعة وي تشات | الحساب الرسمي على وي تشات |
| -------------- | ------------------------ |
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
<translate-content></translate-content>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-17

---