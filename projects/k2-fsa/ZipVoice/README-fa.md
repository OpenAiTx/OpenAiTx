
<div align="right">
  <details>
    <summary >🌐 زبان</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=en">انگلیسی</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ja">ژاپنی</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ko">کره‌ای</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=hi">هندی</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=th">تایلندی</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=fr">فرانسوی</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=de">آلمانی</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=es">اسپانیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=it">ایتالیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ru">روسی</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=pt">پرتغالی</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=nl">هلندی</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=pl">لهستانی</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ar">عربی</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=tr">ترکی</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=vi">ویتنامی</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=id">اندونزیایی</a>
      </div>
    </div>
  </details>
</div>

<div align="center">

# ZipVoice⚡

## تبدیل متن به گفتار سریع و باکیفیت بدون نمونه‌گیری با تطبیق جریان
</div>

## مرور کلی

ZipVoice مجموعه‌ای از مدل‌های TTS سریع و با کیفیت بالا به صورت zero-shot است که بر پایه flow matching توسعه یافته‌اند.

### ۱. ویژگی‌های کلیدی

- کوچک و سریع: تنها ۱۲۳ میلیون پارامتر دارد.

- کلونینگ صدای با کیفیت بالا: عملکرد پیشرفته در شباهت گوینده، وضوح و طبیعی بودن.

- چندزبانه: پشتیبانی از زبان‌های چینی و انگلیسی.

- چندحالته: پشتیبانی از تولید گفتار تک‌گوینده و دیالوگ.

### ۲. انواع مدل

<table>
  <thead>
    <tr>
      <th>نام مدل</th>
      <th>توضیحات</th>
      <th>مقاله</th>
      <th>دمو</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>ZipVoice</td>
      <td>مدل پایه که از TTS zero-shot تک‌گوینده به زبان‌های چینی و انگلیسی پشتیبانی می‌کند.</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2506.13053"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Distill</td>
      <td>نسخه تقطیر شده ZipVoice که سرعت بهبود یافته با افت حداقلی عملکرد را ارائه می‌دهد.</td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog</td>
      <td>مدل تولید دیالوگ مبتنی بر ZipVoice که قادر به تولید دیالوگ‌های گفتاری دوطرفه در یک کانال است.</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2507.09318"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice-dialog.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog-Stereo</td>
      <td>نوع استریوی ZipVoice-Dialog که امکان تولید گفتگوی دو کاناله را فراهم می‌کند، به طوری که هر سخنگو در یک کانال مجزا قرار می‌گیرد.</td>
    </tr>
  </tbody>
</table>

## اخبار

**۱۴۰۴/۰۴/۲۳**: **ZipVoice-Dialog** و **ZipVoice-Dialog-Stereo**، دو مدل تولید گفتگوی گفتاری منتشر شدند. [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice-dialog.github.io)

**۱۴۰۴/۰۴/۲۳**: مجموعه داده **OpenDialog**، یک مجموعه داده گفتگوی گفتاری با مدت زمان ۶.۸ هزار ساعت منتشر شد. دانلود از [![hf](https://img.shields.io/badge/%F0%9F%A4%97%20HuggingFace-Dataset-yellow)](https://huggingface.co/datasets/k2-fsa/OpenDialog)، [![ms](https://img.shields.io/badge/ModelScope-Dataset-blue?logo=data)](https://www.modelscope.cn/datasets/k2-fsa/OpenDialog). جزئیات در [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318).

**۱۴۰۴/۰۳/۲۶**: **ZipVoice** و **ZipVoice-Distill** منتشر شدند. [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2506.13053) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice.github.io)

## نصب

### ۱. مخزن ZipVoice را کلون کنید

```bash
git clone https://github.com/k2-fsa/ZipVoice.git
```
### ۲. (اختیاری) ایجاد یک محیط مجازی پایتون


```bash
python3 -m venv zipvoice
source zipvoice/bin/activate
```
### ۳. بسته‌های مورد نیاز را نصب کنید


```bash
pip install -r requirements.txt
```
### ۴. نصب k2 برای آموزش یا استنتاج بهینه

**k2 برای آموزش لازم است** و می‌تواند سرعت استنتاج را افزایش دهد. با این حال، همچنان می‌توانید از حالت استنتاج ZipVoice بدون نصب k2 استفاده کنید.

> **توجه:** مطمئن شوید که نسخه k2 مناسب با نسخه PyTorch و CUDA خود را نصب می‌کنید. به عنوان مثال، اگر از pytorch 2.5.1 و CUDA 12.1 استفاده می‌کنید، می‌توانید k2 را به صورت زیر نصب کنید:


```bash
pip install k2==1.24.4.dev20250208+cuda12.1.torch2.5.1 -f https://k2-fsa.github.io/k2/cuda.html
```
لطفاً برای جزئیات به https://k2-fsa.org/get-started/k2/ مراجعه کنید.
کاربران سرزمین اصلی چین می‌توانند به https://k2-fsa.org/zh-CN/get-started/k2/ مراجعه کنند.

- برای بررسی نصب k2:


```bash
python3 -c "import k2; print(k2.__file__)"
```
## نحوه استفاده

### ۱. تولید گفتار تک‌گوینده

برای تولید گفتار تک‌گوینده با مدل‌های ZipVoice یا ZipVoice-Distill آموزش‌دیده ما، از دستورات زیر استفاده کنید (مدل‌های مورد نیاز از HuggingFace دانلود خواهند شد):

#### ۱.۱ استنتاج یک جمله منفرد


```bash
python3 -m zipvoice.bin.infer_zipvoice \
    --model-name zipvoice \
    --prompt-wav prompt.wav \
    --prompt-text "I am the transcription of the prompt wav." \
    --text "I am the text to be synthesized." \
    --res-wav-path result.wav
```
- `--model-name` می‌تواند `zipvoice` یا `zipvoice_distill` باشد، که به ترتیب مدل‌های قبل و بعد از تقطیر هستند.
- اگر `<>` یا `[]` در متن ظاهر شوند، رشته‌هایی که توسط آن‌ها احاطه شده‌اند به عنوان توکن‌های ویژه در نظر گرفته خواهند شد. `<>` نشان‌دهنده پین‌یین چینی و `[]` نشان‌دهنده سایر برچسب‌های ویژه است.

#### 1.2 استنتاج یک لیست از جملات

```bash
python3 -m zipvoice.bin.infer_zipvoice \
    --model-name zipvoice \
    --test-list test.tsv \
    --res-dir results
```
- هر خط از فایل `test.tsv` به صورت `{wav_name}\t{prompt_transcription}\t{prompt_wav}\t{text}` است.

### 2. تولید گفتار گفتگو

#### 2.1 فرمان استنتاج

برای تولید گفتگوهای گفتاری دو نفره با مدل‌های ZipVoice-Dialogue یا ZipVoice-Dialogue-Stereo که از پیش آموزش دیده‌اند، از دستورات زیر استفاده کنید (مدل‌های مورد نیاز از HuggingFace دانلود خواهند شد):


```bash
python3 -m zipvoice.bin.infer_zipvoice_dialog \
    --model-name "zipvoice_dialog" \
    --test-list test.tsv \
    --res-dir results
```
- `--model-name` می‌تواند `zipvoice_dialog` یا `zipvoice_dialog_stereo` باشد،
    که به ترتیب دیالوگ‌های مونو و استریو تولید می‌کنند.

#### 2.2 فرمت‌های ورودی

هر خط از فایل `test.tsv` یکی از فرمت‌های زیر را دارد:

(1) **فرمت پرامپت ادغام‌شده** که در آن صداها و رونوشت‌های دو گوینده در یک فایل صوتی پرامپت ترکیب شده‌اند:

```
{wav_name}\t{prompt_transcription}\t{prompt_wav}\t{text}
```

- `wav_name` نام فایل خروجی wav است.
- `prompt_transcription` متن رونویسی شده فایل صوتی مکالمه‌ی ورودی است، مثلاً "[S1] سلام. [S2] حالت چطوره؟"
- `prompt_wav` مسیر فایل صوتی مکالمه‌ی ورودی است.
- `text` متنی است که قرار است سنتز شود، مثلاً "[S1] من خوبم. [S2] اسم شما چیه؟ [S1] من اریک هستم. [S2] سلام اریک."

(2) **فرمت مکالمه‌ی جداشده** که فایل‌های صوتی و رونویسی دو گوینده به صورت جداگانه وجود دارند:

```
{wav_name}\t{spk1_prompt_transcription}\t{spk2_prompt_transcription}\t{spk1_prompt_wav}\t{spk2_prompt_wav}\t{text}
```
- `wav_name` نام فایل خروجی wav است.
- `spk1_prompt_transcription` رونوشت فایل wav نمونه گوینده اول است، مثلاً "سلام"
- `spk2_prompt_transcription` رونوشت فایل wav نمونه گوینده دوم است، مثلاً "حالت چطور است؟"
- `spk1_prompt_wav` مسیر فایل wav نمونه گوینده اول است.
- `spk2_prompt_wav` مسیر فایل wav نمونه گوینده دوم است.
- `text` متنی است که باید سنتز شود، مثلاً "[S1] خوبم. [S2] اسمت چیست؟ [S1] من اریک هستم. [S2] سلام اریک."

### ۳ راهنمای استفاده بهتر:

#### ۳.۱ طول نمونه

پیشنهاد می‌کنیم فایل wav نمونه کوتاه باشد (مثلاً کمتر از ۳ ثانیه برای تولید گفتار تک‌گوینده، کمتر از ۱۰ ثانیه برای تولید گفتار دیالوگ) تا سرعت استنتاج بیشتر شود. نمونه بسیار طولانی باعث کندی استنتاج و افت کیفیت گفتار خواهد شد.

#### ۳.۲ بهینه‌سازی سرعت

اگر سرعت استنتاج رضایت‌بخش نیست، می‌توانید به روش‌های زیر آن را افزایش دهید:

- **مدل تقطیر شده و کاهش مراحل**: برای مدل تولید گفتار تک‌گوینده، به طور پیش‌فرض از مدل `zipvoice` برای کیفیت بهتر گفتار استفاده می‌کنیم. اگر سرعت بیشتر اولویت دارد، می‌توانید به `zipvoice_distill` سوییچ کنید و مقدار `--num-steps` را تا حداقل `4` کاهش دهید (پیش‌فرض 8).

- **افزایش سرعت CPU با چندریسمانی**: هنگام اجرای روی CPU، می‌توانید پارامتر `--num-thread` (مثلاً `--num-thread 4`) را برای افزایش تعداد ریسمان‌ها و سرعت بیشتر وارد کنید. به طور پیش‌فرض ۱ ریسمان استفاده می‌شود.

- **افزایش سرعت CPU با ONNX**: هنگام اجرا روی CPU، می‌توانید از مدل‌های ONNX با `zipvoice.bin.infer_zipvoice_onnx` برای سرعت بیشتر استفاده کنید (هنوز برای مدل‌های تولید دیالوگ از ONNX پشتیبانی نشده). برای سرعت بیشتر، می‌توانید مقدار `--onnx-int8 True` را جهت استفاده از مدل ONNX با INT8 تنظیم کنید. توجه داشته باشید که مدل کوانتیزه شده باعث افت کیفیت گفتار خواهد شد. **از ONNX روی GPU استفاده نکنید**، زیرا روی GPU کندتر از PyTorch است.

#### ۳.۳ کنترل حافظه

متن داده شده بر اساس علائم نگارشی (برای تولید گفتار تک‌گوینده) یا نماد تغییر گوینده (برای تولید گفتار دیالوگ) به بخش‌هایی تقسیم می‌شود. سپس متن‌های بخش‌بندی شده به صورت دسته‌ای پردازش می‌شوند. بنابراین مدل می‌تواند متن بسیار طولانی را با مصرف حافظه تقریباً ثابت پردازش کند. با تنظیم پارامتر `--max-duration` می‌توانید مصرف حافظه را کنترل کنید.

#### ۳.۴ ارزیابی "خام"

به طور پیش‌فرض، ورودی‌ها (فایل wav نمونه، رونوشت نمونه، و متن) را برای استنتاج بهینه و عملکرد بهتر پیش‌پردازش می‌کنیم. اگر می‌خواهید عملکرد "خام" مدل را با ورودی‌های دقیق ارائه‌شده ارزیابی کنید (مثلاً برای بازتولید نتایج مقاله ما)، می‌توانید پارامتر `--raw-evaluation True` را وارد کنید.

#### ۳.۵ متن کوتاه

هنگام تولید گفتار برای متن‌های بسیار کوتاه (مثلاً یک یا دو واژه)، گفتار تولیدشده گاهی برخی تلفظ‌ها را حذف می‌کند. برای رفع این مشکل، می‌توانید پارامتر `--speed 0.3` (که مقدار قابل تنظیم است) را وارد کنید تا مدت زمان گفتار تولیدی افزایش یابد.

#### ۳.۶ اصلاح تلفظ اشتباه حروف چندآوایی چینی

ما از [pypinyin](https://github.com/mozillazg/python-pinyin) برای تبدیل کاراکترهای چینی به پین‌یین استفاده می‌کنیم. با این حال، گاهی اوقات **حروف چندآوایی** (多音字) را اشتباه تلفظ می‌کند.


برای اصلاح دستی این تلفظ‌های اشتباه، **پین‌یین اصلاح‌شده** را در داخل علامت زاویه‌دار `< >` قرار دهید و **علامت نوا** را اضافه کنید.

**مثال:**

- متن اصلی: `这把剑长三十公分`
- اصلاح پین‌یین `长`:  `这把剑<chang2>三十公分`

> **توجه:** اگر می‌خواهید چندین پین‌یین را به صورت دستی تعیین کنید، هر پین‌یین را داخل `<>` قرار دهید، مانند: `这把<jian4><chang2><san1>十公分`

#### 3.7 حذف سکوت‌های طولانی از گفتار تولید شده

مدل به طور خودکار موقعیت‌ها و طول سکوت‌ها را در گفتار تولیدشده تعیین می‌کند. گاهی اوقات سکوت طولانی در وسط گفتار ایجاد می‌شود. اگر نمی‌خواهید این اتفاق بیفتد، می‌توانید `--remove-long-sil` را استفاده کنید تا سکوت‌های طولانی وسط گفتار حذف شوند (سکوت‌های ابتدا و انتها به طور پیش‌فرض حذف می‌شوند).

#### 3.8 دانلود مدل

اگر هنگام دانلود مدل‌های از پیش آموزش‌دیده با HuggingFace مشکل اتصال داشتید، سعی کنید نقطه انتهایی را به سایت آینه تغییر دهید: `export HF_ENDPOINT=https://hf-mirror.com`.

## آموزش مدل شخصی خودتان

برای نمونه‌های آموزش، تنظیم و ارزیابی، به دایرکتوری [egs](egs) مراجعه کنید.

## استقرار C++

راه‌حل استقرار C++ روی CPU را در [sherpa-onnx](https://github.com/k2-fsa/sherpa-onnx/pull/2487#issuecomment-3227884498) بررسی کنید.

## بحث و ارتباط

می‌توانید مستقیماً در [Github Issues](https://github.com/k2-fsa/ZipVoice/issues) بحث کنید.

همچنین می‌توانید کد QR را برای پیوستن به گروه وی‌چت ما یا دنبال کردن حساب رسمی وی‌چت اسکن کنید.

| گروه وی‌چت | حساب رسمی وی‌چت |
| ------------ | ----------------------- |
|![wechat](https://k2-fsa.org/zh-CN/assets/pic/wechat_group.jpg) |![wechat](https://k2-fsa.org/zh-CN/assets/pic/wechat_account.jpg) |

## ارجاع

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