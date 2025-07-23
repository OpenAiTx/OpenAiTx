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

## تبدیل متن به گفتار سریع و باکیفیت با یادگیری تطبیقی جریان (Flow Matching)
</div>

## مروری کلی

ZipVoice مجموعه‌ای از مدل‌های تبدیل متن به گفتار سریع و باکیفیت (TTS) بر پایه Flow Matching است.

### 1. ویژگی‌های کلیدی

- کوچک و سریع: تنها ۱۲۳ میلیون پارامتر.

- شبیه‌سازی صدای باکیفیت: عملکرد پیشرفته در شباهت به گوینده، وضوح و طبیعی بودن.

- چندزبانه: پشتیبانی از چینی و انگلیسی.

- چندحالته: پشتیبانی از تولید گفتار تک‌گوینده و گفتگوی چندنفری.

### 2. انواع مدل

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
      <td>مدل پایه که از تبدیل متن به گفتار تک‌گوینده به‌صورت zero-shot در زبان‌های چینی و انگلیسی پشتیبانی می‌کند.</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2506.13053"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Distill</td>
      <td>نسخه تقطیرشده ZipVoice که سرعت بالاتری با کاهش حداقلی در عملکرد ارائه می‌دهد.</td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog</td>
      <td>مدل تولید گفتگو که بر پایه ZipVoice ساخته شده و قادر به تولید گفت‌وگوی دو نفره تک‌کاناله می‌باشد.</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2507.09318"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice-dialog.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog-Stereo</td>
      <td>نسخه استریوی ZipVoice-Dialog که تولید گفت‌وگوی دوکاناله را با اختصاص هر گوینده به یک کانال مجزا ممکن می‌سازد.</td>
    </tr>
  </tbody>
</table>

## اخبار

**۱۴۰۴/۰۴/۲۳**: **ZipVoice-Dialog** و **ZipVoice-Dialog-Stereo**، دو مدل تولید گفت‌وگوی صوتی منتشر شدند. [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice-dialog.github.io)

**۱۴۰۴/۰۴/۲۳**: دیتاست **OpenDialog**، مجموعه‌ای از ۶.۸ هزار ساعت گفت‌وگوی صوتی، منتشر شد. دانلود از [![hf](https://img.shields.io/badge/%F0%9F%A4%97%20HuggingFace-Dataset-yellow)](https://huggingface.co/datasets/k2-fsa/OpenDialog)، [![ms](https://img.shields.io/badge/ModelScope-Dataset-blue?logo=data)](https://www.modelscope.cn/datasets/k2-fsa/OpenDialog). جزئیات در [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318).

**۱۴۰۴/۰۳/۲۶**: **ZipVoice** و **ZipVoice-Distill** منتشر شدند. [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2506.13053) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice.github.io)

## نصب

### ۱. کلون کردن مخزن ZipVoice


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


```
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
- اگر `<>` یا `[]` در متن ظاهر شود، رشته‌های داخل آنها به عنوان توکن‌های ویژه در نظر گرفته می‌شوند. `<>` نشان‌دهنده پین‌یین چینی و `[]` نشان‌دهنده سایر برچسب‌های ویژه است.
- با `zipvoice.bin.infer_zipvoice_onnx` می‌توانید مدل‌های ONNX را سریع‌تر روی CPU اجرا کنید.

> **توجه:** اگر در اتصال به HuggingFace مشکل داشتید، امتحان کنید:
> ```bash
> export HF_ENDPOINT=https://hf-mirror.com
> ```

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
- `prompt_transcription` رونویسی از فایل صوتی مکالمه‌ای prompt است، برای مثال، "[S1] سلام. [S2] حالت چطوره؟"
- `prompt_wav` مسیر فایل صوتی prompt است.
- `text` متنی است که باید سنتز شود، برای مثال، "[S1] من خوبم. [S2] اسمت چیه؟"

(2) **فرمت prompt تفکیک‌شده** که در آن فایل‌های صوتی و رونویسی دو گوینده در فایل‌های جداگانه وجود دارند:


```
{wav_name}\t{spk1_prompt_transcription}\t{spk2_prompt_transcription}\t{spk1_prompt_wav}\t{spk2_prompt_wav}\t{text}'
```
- `wav_name` نام فایل خروجی wav است.
- `spk1_prompt_transcription` رونوشت پیام صوتی گوینده اول است، مانند "سلام"
- `spk2_prompt_transcription` رونوشت پیام صوتی گوینده دوم است، مانند "حالت چطور است؟"
- `spk1_prompt_wav` مسیر فایل صوتی پیام گوینده اول است.
- `spk2_prompt_wav` مسیر فایل صوتی پیام گوینده دوم است.
- `text` متنی است که باید سنتز شود، مانند "[S1] من خوبم. [S2] اسم تو چیست؟"

### ۳. سایر قابلیت‌ها

#### ۳.۱ اصلاح تلفظ اشتباه حروف چندآوایی چینی

ما از [pypinyin](https://github.com/mozillazg/python-pinyin) برای تبدیل حروف چینی به پین‌یین استفاده می‌کنیم. با این حال، گاهی اوقات **حروف چندآوایی** (多音字) را اشتباه تلفظ می‌کند.

برای اصلاح دستی این اشتباهات تلفظ، پین‌یین **درست** را درون علامت‌های زاویه‌دار `< >` به همراه **علامت لحن** قرار دهید.

**مثال:**

- متن اصلی: `这把剑长三十公分`
- اصلاح پین‌یین `长`:  `这把剑<chang2>三十公分`

> **توجه:** اگر می‌خواهید چند پین‌یین به صورت دستی اختصاص دهید، هر پین‌یین را با `<>` قرار دهید، مانند: `这把<jian4><chang2><san1>十公分`

## آموزش مدل خودتان

برای مثال‌هایی از آموزش، تنظیم دقیق و ارزیابی به دایرکتوری [egs](egs) مراجعه کنید.

## بحث و ارتباط

می‌توانید مستقیماً در [Github Issues](https://github.com/k2-fsa/ZipVoice/issues) بحث کنید.

همچنین می‌توانید کد QR را اسکن کنید تا به گروه وی‌چت ما بپیوندید یا حساب رسمی وی‌چت ما را دنبال کنید.

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-22

---