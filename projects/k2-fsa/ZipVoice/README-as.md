
<div align="right">
  <details>
    <summary >🌐 ভাষা</summary>
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

## Flow Matching ব্যৱহাৰ কৰি দ্ৰুত আৰু উচ্চ-গুণমানৰ শূন্য-শ্বট পাঠ-টু-স্পীচ
</div>

## পৰিসংখ্যান

ZipVoice হৈছে flow matching-ৰ আধাৰত নিৰ্মিত, দ্ৰুত আৰু উচ্চ-গুণগতমানৰ zero-shot TTS মডেলৰ এক শৃংখলা।

### ১. মুখ্য বৈশিষ্ট্যসমূহ

- সৰু আৰু দ্ৰুত: কেৱল ১২৩M পৰামিত্ৰ।

- উচ্চ-গুণগতমানৰ ভয়েছ ক্ল’নিং: স্পীকাৰৰ সাদৃশ্য, বুজাবলৈ সক্ষমতা, আৰু প্ৰাকৃতিকতাৰ ক্ষেত্ৰত শ্ৰেষ্ঠ পৰ্যায়ৰ কাৰ্যক্ষমতা।

- বহু-ভাষিক: চীনা আৰু ইংৰাজী সমৰ্থিত।

- বহু-মোড: একক স্পীকাৰ আৰু সংলাপ উত্পাদনৰ দুয়ো সমৰ্থিত।

### ২. মডেল ভেৰিয়েণ্টসমূহ

<table>
  <thead>
    <tr>
      <th>মডেলৰ নাম</th>
      <th>বিৱৰণ</th>
      <th>পেপাৰ</th>
      <th>ডেমো</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>ZipVoice</td>
      <td>মূল মডেল, যি চীনা আৰু ইংৰাজীত zero-shot একক-স্পীকাৰ TTS সমৰ্থন কৰে।</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2506.13053"><img src="https://img.shields.io/badge/arXiv-পেপাৰ-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice.github.io"><img src="https://img.shields.io/badge/GitHub.io-ডেমো_পৃষ্ঠা-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Distill</td>
      <td>ZipVoice-ৰ ডিস্টিল্ড সংস্কৰণ, খুব কম কাৰ্যক্ষমতা হ্ৰাসৰ সৈতে বেছি দ্ৰুত।</td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog</td>
      <td>ZipVoice-ৰ ওপৰত নিৰ্মিত সংলাপ উত্পাদন মডেল, যি একক-চেনেল দুজন ব্যক্তিৰ মুখৰ সংলাপ উত্পাদন কৰিব পাৰে।</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2507.09318"><img src="https://img.shields.io/badge/arXiv-পেপাৰ-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice-dialog.github.io"><img src="https://img.shields.io/badge/GitHub.io-ডেমো_পৃষ্ঠা-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog-Stereo</td>
      <td>ZipVoice-Dialog ৰ ষ্টেৰিঅ' ৰূপ, যি দুটা চেনেলত সংলাপ সৃষ্টি কৰিবলৈ সক্ষম, য'ত প্ৰতিটো বক্তাক পৃথক চেনেলত নিযুক্ত কৰা হয়।</td>
    </tr>
  </tbody>
</table>

## বাতৰি

**২০২৫/০৭/১৪**: **ZipVoice-Dialog** আৰু **ZipVoice-Dialog-Stereo**, দুটা মৌখিক সংলাপ সৃষ্টি কৰাৰ মডেল, মুক্ত কৰা হৈছে। [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice-dialog.github.io)

**২০২৫/০৭/১৪**: **OpenDialog** ডাটাছেট, ৬.৮ কিঘন্টাৰ মৌখিক সংলাপ ডাটাছেট, মুক্ত কৰা হৈছে। ডাউনল'ড কৰক [![hf](https://img.shields.io/badge/%F0%9F%A4%97%20HuggingFace-Dataset-yellow)](https://huggingface.co/datasets/k2-fsa/OpenDialog), [![ms](https://img.shields.io/badge/ModelScope-Dataset-blue?logo=data)](https://www.modelscope.cn/datasets/k2-fsa/OpenDialog)। বিস্তারিত চাওক [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318)।

**২০২৫/০৬/১৬**: **ZipVoice** আৰু **ZipVoice-Distill** মুক্ত কৰা হৈছে। [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2506.13053) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice.github.io)

## সংস্থাপন

### ১. ZipVoice ৰেপ'জিট'ৰী ক্লোন কৰক

```bash
git clone https://github.com/k2-fsa/ZipVoice.git
```

### 2. (বৈকল্পিক) এটা Python ভাৰ্চুৱেল পৰিৱেশ সৃষ্টি কৰক

```bash
python3 -m venv zipvoice
source zipvoice/bin/activate
```

### ৩. প্ৰয়োজনীয় পেকেজসমূহ সংস্থাপন কৰক

```bash
pip install -r requirements.txt
```

### 4. প্ৰশিক্ষণ বা কার্যকৰী অনুমানৰ বাবে k2 সংস্থাপন কৰক

**k2 প্ৰশিক্ষণৰ বাবে প্ৰয়োজনীয়** আৰু অনুমানৰ গতি বৃদ্ধি কৰিব পাৰে। তথাপি, k2 সংস্থাপন নকৰাকৈ ZipVoice ৰ অনুমান মোড ব্যৱহাৰ কৰিব পাৰে।

> **টোকা:**  আপোনাৰ PyTorch আৰু CUDA সংস্কৰণৰ সৈতে মিল থকা k2 সংস্কৰণ সংস্থাপন কৰা নিশ্চিত কৰক। উদাহৰণস্বৰূপ, যদি আপুনি pytorch 2.5.1 আৰু CUDA 12.1 ব্যৱহাৰ কৰিছে, তেন্তে k2 তলত দিয়া অনুসৰি সংস্থাপন কৰিব পাৰে:

```bash
pip install k2==1.24.4.dev20250208+cuda12.1.torch2.5.1 -f https://k2-fsa.github.io/k2/cuda.html
```

অনুগ্ৰহ কৰি https://k2-fsa.org/get-started/k2/ চাওক বিৱৰণৰ বাবে।
চীন মূল ভূ-খণ্ডৰ ব্যৱহাৰকাৰীসকলে https://k2-fsa.org/zh-CN/get-started/k2/ চাব পাৰে।

- k2 সংস্থাপন পৰীক্ষা কৰিবলৈ:

```bash
python3 -c "import k2; print(k2.__file__)"
```

## ব্যৱহাৰ

### 1. একক বক্তাৰ বক্তব্য উত্পাদন

আমালৈ উপলভ্য ZipVoice বা ZipVoice-Distill মডেলৰ সহায়ত একক বক্তাৰ বক্তব্য উত্পাদন কৰিবলৈ, তলত দিয়া আদেশসমূহ ব্যৱহাৰ কৰক (প্ৰয়োজনীয় মডেলসমূহ HuggingFace ৰ পৰা ডাউনলোড কৰা হ'ব):

#### 1.1 এটা বাক্যৰ ইনফাৰেন্স

```bash
python3 -m zipvoice.bin.infer_zipvoice \
    --model-name zipvoice \
    --prompt-wav prompt.wav \
    --prompt-text "I am the transcription of the prompt wav." \
    --text "I am the text to be synthesized." \
    --res-wav-path result.wav
```
- `--model-name` হিচাপে `zipvoice` বা `zipvoice_distill` ব্যৱহাৰ কৰিব পাৰি, যিবোৰ যথাক্ৰমে distillationৰ আগৰ আৰু পাছৰ মডেল।
- যদি পাঠত `<>` বা `[]` দেখা যায়, তেন্তে ইয়াৰে আবদ্ধ strings বিশেষ টোকেন হিচাপে গণ্য কৰা হ’ব। `<>` চাইনীজ পিনইনৰ বাবে আৰু `[]` আন বিশেষ টেগৰ বাবে ব্যৱহাৰ হয়।

#### 1.2 বাক্যৰ তালিকা inference

```bash
python3 -m zipvoice.bin.infer_zipvoice \
    --model-name zipvoice \
    --test-list test.tsv \
    --res-dir results
```

- `test.tsv`-ৰ প্ৰত্যেকটো শাৰী `{wav_name}\t{prompt_transcription}\t{prompt_wav}\t{text}` ৰূপত থাকে।

### 2. সংলাপ বক্তব্য উৎপাদন

#### 2.1 অনুমান আদেশ

আমাৰ পূৰ্ব-প্ৰশিক্ষিত ZipVoice-Dialogue অথবা ZipVoice-Dialogue-Stereo মডেলৰ সহায়ত দুজন ব্যক্তিৰ সংলাপ বক্তব্য উৎপাদন কৰিবলৈ, তলত দিয়া আদেশসমূহ ব্যৱহাৰ কৰক (প্ৰয়োজনীয় মডেলসমূহ HuggingFace-ৰ পৰা ডাউনল'ড হব):

```bash
python3 -m zipvoice.bin.infer_zipvoice_dialog \
    --model-name "zipvoice_dialog" \
    --test-list test.tsv \
    --res-dir results
```

- `--model-name` হিচাপে `zipvoice_dialog` অথবা `zipvoice_dialog_stereo` থাকিব পাৰে,
    যিয়ে অনুসৰি মোনো আৰু ষ্টেৰিঅ' সংলাপ উত্পাদন কৰে।

#### 2.2 ইনপুট ফৰ্মেটসমূহ

`test.tsv`-ৰ প্ৰত্যেকটা শাৰী তলত দিয়া ফৰ্মেটসমূহৰ অন্যতমত থাকে:

(1) **Merged prompt format** য'ত দুজন বক্তাৰ অডিঅ' আৰু প্ৰতিলিপি একেলগ কৰি এটা প্ৰম্পট ৱেভ ফাইলত সংযুক্ত কৰা হয়:
```
{wav_name}\t{prompt_transcription}\t{prompt_wav}\t{text}
```

- `wav_name` হৈছে আউটপুট wav ফাইলৰ নাম।
- `prompt_transcription` হৈছে কথোপকথনৰ প্ৰম্পট wav-ৰ লিপ্যন্তৰণ, যেনে, "[S1] Hello. [S2] How are you?"
- `prompt_wav` হৈছে প্ৰম্পট wav-ৰ পথ।
- `text` হৈছে সংশ্লেষণ কৰিবলগীয়া পাঠ্য, যেনে "[S1] I'm fine. [S2] What's your name? [S1] I'm Eric. [S2] Hi Eric."

(2) **Splitted prompt format** য'ত দুটা বক্তাৰ অডিঅ' আৰু লিপ্যন্তৰণ পৃথক ফাইলত থাকে:

```
{wav_name}\t{spk1_prompt_transcription}\t{spk2_prompt_transcription}\t{spk1_prompt_wav}\t{spk2_prompt_wav}\t{text}
```

- `wav_name` হৈছে output wav ফাইলটোৰ নাম।
- `spk1_prompt_transcription` হৈছে প্ৰথম বক্তাৰ prompt wav-ৰ transcript, যেনে "Hello"
- `spk2_prompt_transcription` হৈছে দ্বিতীয় বক্তাৰ prompt wav-ৰ transcript, যেনে "How are you?"
- `spk1_prompt_wav` হৈছে প্ৰথম বক্তাৰ prompt wav ফাইলৰ পথ।
- `spk2_prompt_wav` হৈছে দ্বিতীয় বক্তাৰ prompt wav ফাইলৰ পথ।
- `text` হৈছে synthesis কৰিবলগীয়া পাঠ্য, যেনে "[S1] I'm fine. [S2] What's your name? [S1] I'm Eric. [S2] Hi Eric."

### 3 ভাল ব্যৱহাৰৰ বাবে নিৰ্দেশনা:

#### 3.1 Prompt-ৰ দৈৰ্ঘ্য

আমাৰ পৰামৰ্শ, সোনকাল prompt wav ফাইল ব্যৱহাৰ কৰক (যেনে, একক বক্তা speech generation-ৰ বাবে ৩ ছেকেণ্ডত কম, dialogue speech generation-ৰ বাবে ১০ ছেকেণ্ডত কম) যাতে inference গতি বেছি হয়। খুব দীঘল prompt inference ধীৰ কৰি speech quality কমাই দিব।

#### 3.2 গতিৰ উন্নয়ন

যদি inference গতি সন্তোষজনক নহয়, তেন্তে তলত দিয়া পদক্ষেপ অনুসৰণ কৰি গতি বৃদ্ধি কৰিব পাৰে:

- **Distill model আৰু কম পদক্ষেপ**: একক বক্তা speech generation model-ৰ বাবে, speech quality ভাল কৰিবলৈ আমি `zipvoice` model ডিফল্ট হিচাপে ব্যৱহাৰ কৰোঁ। গতি অধিক প্ৰয়োজন হলে, আপুনি `zipvoice_distill`-লৈ switch কৰিব পাৰে আৰু `--num-steps` কমাই ৪ (ডিফল্ট ৮) কৰিব পাৰে।

- **CPU-ত multi-threading-এ গতি বৃদ্ধি**: CPU-ত চলোৱা সময়ত, `--num-thread` parameter (যেনে, `--num-thread 4`) ব্যৱহাৰ কৰি thread-ৰ সংখ্যা বৃদ্ধি কৰি গতি বঢ়াব পাৰে। ডিফল্টত ১ thread ব্যৱহাৰ হয়।

- **ONNX-এ CPU-ত গতি বৃদ্ধি**: CPU-ত চলোৱা সময়ত, ONNX model `zipvoice.bin.infer_zipvoice_onnx`-ৰ সৈতে ব্যৱহাৰ কৰি গতি বৃদ্ধি কৰিব পাৰে (dialogue generation model-ৰ বাবে ONNX এতিয়াও support কৰা হোৱা নাই)। আৰু অধিক গতিৰ বাবে, আপুনি `--onnx-int8 True` set কৰি INT8-quantized ONNX model ব্যৱহাৰ কৰিব পাৰে। মনত ৰাখিব, quantized model speech quality-ত কিছু পৰিমাণে কমি যায়। **GPU-ত ONNX ব্যৱহাৰ নকৰিব**, কাৰণ GPU-ত PyTorch-তকৈ ধীৰ।

#### 3.3 Memory নিয়ন্ত্ৰণ

দিয়া পাঠ্য punctuation অনুসৰি chunk কৰা হয় (একক বক্তা speech generation-ৰ বাবে) বা speaker-turn symbol অনুসৰি (dialogue speech generation-ৰ বাবে)। তাৰ পিছত, chunked পাঠ্যবোৰ batch-ত process কৰা হয়। ফলত, model-এ প্ৰায় স্থায়ী memory ব্যৱহাৰেৰে যিকোনো দৈৰ্ঘ্যৰ পাঠ্য process কৰিব পাৰে। আপুনি `--max-duration` parameter adjust কৰি memory নিয়ন্ত্ৰণ কৰিব পাৰে।

#### 3.4 "Raw" মূল্যায়ন

ডিফল্টত, efficient inference আৰু ভাল performance-ৰ বাবে আমি inputs (prompt wav, prompt transcription, আৰু পাঠ্য) preprocess কৰোঁ। যদি আপুনি model-ৰ "raw" performance ঠিক দিয়া inputs-ৰে মূল্যায়ন কৰিব বিচাৰে (যেনে, আমাৰ paper-ৰ ফলাফল reproduce কৰিবলৈ), `--raw-evaluation True` pass কৰিব পাৰে।

#### 3.5 সোনকাল পাঠ্য

অতি সোনকাল পাঠ্য (যেনে, এটা বা দুটা শব্দ) speech generation-ৰ সময়ত, generated speech-ত কেতিয়াবা কিছুমান pronunciation omit হোৱা দেখা যায়। এই সমস্যা সমাধান কৰিবলৈ, আপুনি `--speed 0.3` (য'ত ০.৩ এটা tunable value) pass কৰি generated speech-ৰ duration বৃদ্ধি কৰিব পাৰে।

#### 3.6 ভুল উচ্চাৰিত চীনৰ বহু-ধ্বনি অক্ষৰ সংশোধন

আমি [pypinyin](https://github.com/mozillazg/python-pinyin) ব্যৱহাৰ কৰোঁ চীনী অক্ষৰবোৰক pinyin-লৈ convert কৰিবলৈ। যদিও, এইয়ে কেতিয়াবা **বহু-ধ্বনি অক্ষৰ** (多音字) ভুল উচ্চাৰণ কৰিব পাৰে।

এই ভুল উচ্চাৰণসমূহ নিজে হাতে সংশোধন কৰিবলৈ, **সঠিক পিনইন**-টো কোনা কোণৰ কৌলত `< >` ত ৰাখক আৰু **স্বৰ চিহ্ন** অন্তৰ্ভুক্ত কৰক।

**উদাহৰণ:**

- মূল পাঠ: `这把剑长三十公分`
- `长`-ৰ পিনইন সংশোধন কৰক:  `这把剑<chang2>三十公分`

> **টোকা:** যদি আপুনি একাধিক পিনইন নিজে হাতে নিৰ্ধাৰণ কৰিব বিচাৰে, তেন্তে প্রতিটো পিনইন `< >` ত ৰাখক, যেনে `这把<jian4><chang2><san1>十公分`

#### ৩.৭ উৎপন্ন কৰা বক্তৃতাৰ পৰা দীঘল নিঃশব্দতা আঁতৰাওক

মডেলে উৎপন্ন কৰা বক্তৃতাত নিঃশব্দতাৰ স্থান আৰু দৈৰ্ঘ্য নিজে নিৰ্ধাৰণ কৰিব। কেতিয়াবা বক্তৃতাৰ মাজত দীঘল নিঃশব্দতা থাকে। যদি আপুনি এইটো নচাহে, তেন্তে `--remove-long-sil` ব্যৱহাৰ কৰি উৎপন্ন কৰা বক্তৃতাৰ মাজৰ দীঘল নিঃশব্দতা আঁতৰাব পাৰে (প্ৰান্তিক নিঃশব্দতা ডিফল্ট হিচাপে আঁতৰোৱা হ’ব)।

#### ৩.৮ মডেল ডাউনলোডিং

প্ৰশিক্ষণপ্ৰাপ্ত মডেলসমূহ ডাউনলোড কৰাৰ সময়ত HuggingFace-ত সংযোগত সমস্যা হলে, mirror site-লৈ endpoint switch কৰক: `export HF_ENDPOINT=https://hf-mirror.com`।

## আপোনাৰ নিজা মডেল প্ৰশিক্ষণ কৰক

প্ৰশিক্ষণ, fine-tuning আৰু মূল্যায়নৰ উদাহৰণৰ বাবে [egs](egs) directory চাওক।

## C++ ডিপ্লয়মেন্ট

CPU-ত C++ ডিপ্লয়মেন্টৰ সমাধানৰ বাবে [sherpa-onnx](https://github.com/k2-fsa/sherpa-onnx/pull/2487#issuecomment-3227884498) চাওক।

## আলোচনা & যোগাযোগ

আপুনি [Github Issues](https://github.com/k2-fsa/ZipVoice/issues)ত সৰাসৰি আলোচনা কৰিব পাৰে।

আপুনি আমালৈ যোগাযোগ কৰিবলৈ QR code scan কৰিব পাৰে বা আমালৈ wechat official account follow কৰিব পাৰে।

| Wechat Group | Wechat Official Account |
| ------------ | ----------------------- |
|![wechat](https://k2-fsa.org/zh-CN/assets/pic/wechat_group.jpg) |![wechat](https://k2-fsa.org/zh-CN/assets/pic/wechat_account.jpg) |

## উদ্ধৃতি

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