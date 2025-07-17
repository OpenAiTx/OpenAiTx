<div align="right">
  <details>
    <summary >🌐 Dil</summary>
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

## Flow Matching ile Hızlı ve Yüksek Kaliteli Sıfırdan Metinden Konuşmaya
</div>

## Genel Bakış

ZipVoice, akış eşleştirmeye dayalı hızlı ve yüksek kaliteli sıfırdan TTS modelleri serisidir.

### 1. Temel Özellikler

- Küçük ve hızlı: sadece 123M parametre.

- Yüksek kaliteli ses klonlama: konuşmacı benzerliği, anlaşılırlık ve doğallıkta son teknoloji performans.

- Çok dilli: Çince ve İngilizce desteği.

- Çok modlu: hem tek konuşmacılı hem de diyalog konuşma üretimi desteği.

### 2. Model Varyantları

<table>
  <thead>
    <tr>
      <th>Model Adı</th>
      <th>Açıklama</th>
      <th>Makale</th>
      <th>Demo</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>ZipVoice</td>
      <td>Çince ve İngilizce'de sıfırdan tek konuşmacılı TTS desteği sunan temel model.</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2506.13053"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Distill</td>
      <td>ZipVoice'ın damıtılmış versiyonu, minimum performans kaybı ile geliştirilmiş hız sunar.</td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog</td>
      <td>ZipVoice üzerine kurulu bir diyalog üretim modeli; tek kanallı iki taraflı konuşma diyalogları üretebilir.</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2507.09318"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice-dialog.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog-Stereo</td>
      <td>ZipVoice-Dialog'un stereo varyantı, her konuşmacının farklı bir kanala atandığı iki kanallı diyalog üretimini sağlar.</td>
    </tr>
  </tbody>
</table>

## Haberler

**2025/07/14**: **ZipVoice-Dialog** ve **ZipVoice-Dialog-Stereo**, iki konuşmalı diyalog üretim modeli yayımlandı. [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice-dialog.github.io)

**2025/07/14**: **OpenDialog** veri kümesi, 6.8k saatlik konuşmalı diyalog veri kümesi yayımlandı. İndir: [![hf](https://img.shields.io/badge/%F0%9F%A4%97%20HuggingFace-Dataset-yellow)](https://huggingface.co/datasets/k2-fsa/OpenDialog), [![ms](https://img.shields.io/badge/ModelScope-Dataset-blue?logo=data)](https://www.modelscope.cn/datasets/k2-fsa/OpenDialog). Detaylar için: [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318).

**2025/06/16**: **ZipVoice** ve **ZipVoice-Distill** yayımlandı. [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2506.13053) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice.github.io)

## Kurulum

### 1. ZipVoice deposunu klonlayın


```bash
git clone https://github.com/k2-fsa/ZipVoice.git
```
### 2. (İsteğe bağlı) Bir Python sanal ortamı oluşturun


```bash
python3 -m venv zipvoice
source zipvoice/bin/activate
```
### 3. Gerekli paketleri yükleyin


```bash
pip install -r requirements.txt
```
### 4. (Opsiyonel) k2'yi eğitim veya verimli çıkarım için kurun

k2, eğitim için gereklidir ve çıkarımı hızlandırabilir. Yine de, k2 kurmadan ZipVoice'un çıkarım modunu kullanabilirsiniz.

> **Not:**  Kullandığınız PyTorch ve CUDA sürümüne uygun k2 sürümünü kurduğunuzdan emin olun. Örneğin, pytorch 2.5.1 ve CUDA 12.1 kullanıyorsanız, k2'yi aşağıdaki gibi kurabilirsiniz:


```bash
pip install k2==1.24.4.dev20250208+cuda12.1.torch2.5.1 -f https://k2-fsa.github.io/k2/cuda.html
```
Lütfen ayrıntılar için https://k2-fsa.org/get-started/k2/ adresine bakınız.
Çin ana karasındaki kullanıcılar https://k2-fsa.org/zh-CN/get-started/k2/ adresine başvurabilirler.

## Kullanım

### 1. Tek konuşmacılı konuşma üretimi

Önceden eğitilmiş ZipVoice veya ZipVoice-Distill modellerimizle tek konuşmacılı konuşma üretmek için aşağıdaki komutları kullanın (Gerekli modeller HuggingFace üzerinden indirilecektir):

#### 1.1 Tek bir cümlenin çıkarımı


```bash
python3 -m zipvoice.bin.infer_zipvoice \
    --model-name zipvoice \
    --prompt-wav prompt.wav \
    --prompt-text "I am the transcription of the prompt wav." \
    --text "I am the text to be synthesized." \
    --res-wav-path result.wav
```
- `--model-name` olarak `zipvoice` veya `zipvoice_distill` kullanılabilir, bunlar sırasıyla distilasyon öncesi ve sonrası modellerdir.
- Metinde `<>` veya `[]` görünürse, bunlar arasına alınan dizeler özel semboller olarak işlenir. `<>` Çince pinyin, `[]` ise diğer özel etiketler için kullanılır.
- `zipvoice.bin.infer_zipvoice_onnx` ile ONNX modelleri CPU'da daha hızlı çalıştırabilirsiniz.

> **Not:** HuggingFace'e bağlanmakta sorun yaşarsanız, şunu deneyin:
> ```bash
> export HF_ENDPOINT=https://hf-mirror.com
> ```

#### 1.2 Bir cümle listesinin çıkarımı


```bash
python3 -m zipvoice.bin.infer_zipvoice \
    --model-name zipvoice \
    --test-list test.tsv \
    --res-dir results
```
- `test.tsv` dosyasının her satırı `{wav_name}\t{prompt_transcription}\t{prompt_wav}\t{text}` formatındadır.

### 2. Konuşmalı diyalog oluşturma

#### 2.1 Çıkarım komutu

Önceden eğitilmiş ZipVoice-Dialogue veya ZipVoice-Dialogue-Stereo modellerimizle iki taraflı konuşmalı diyaloglar üretmek için aşağıdaki komutları kullanın (Gerekli modeller HuggingFace üzerinden indirilecektir):


```bash
python3 -m zipvoice.bin.infer_zipvoice_dialog \
    --model-name "zipvoice_dialog" \
    --test-list test.tsv \
    --res-dir results
```
- `--model-name` `zipvoice_dialog` veya `zipvoice_dialog_stereo` olabilir,
    sırasıyla mono ve stereo diyaloglar üretir.

#### 2.2 Girdi formatları

`test.tsv` dosyasındaki her satır aşağıdaki formatlardan birindedir:

(1) **Birleştirilmiş istem formatı**: İki konuşmacının sesleri ve transkriptleri tek bir istem wav dosyasında birleştirilir:

```
{wav_name}\t{prompt_transcription}\t{prompt_wav}\t{text}
```
- `wav_name`, çıktı wav dosyasının adıdır.
- `prompt_transcription`, konuşma istemi wav dosyasının transkripsiyonudur, örn. "[S1] Merhaba. [S2] Nasılsın?"
- `prompt_wav`, istem wav dosyasının yoludur.
- `text`, sentezlenecek metindir, örn. "[S1] İyiyim. [S2] Senin adın ne?"

(2) **Bölünmüş istem formatı** burada iki konuşmacının sesleri ve transkripsiyonları ayrı dosyalarda bulunur:


```
{wav_name}\t{spk1_prompt_transcription}\t{spk2_prompt_transcription}\t{spk1_prompt_wav}\t{spk2_prompt_wav}\t{text}'
```
- `wav_name` çıktı wav dosyasının adıdır.
- `spk1_prompt_transcription` birinci konuşmacının prompt wav dosyasının transkripsiyonudur, örn. "Merhaba"
- `spk2_prompt_transcription` ikinci konuşmacının prompt wav dosyasının transkripsiyonudur, örn. "Nasılsın?"
- `spk1_prompt_wav` birinci konuşmacının prompt wav dosyasının yoludur.
- `spk2_prompt_wav` ikinci konuşmacının prompt wav dosyasının yoludur.
- `text` sentezlenecek metindir, örn. "[S1] İyiyim. [S2] Adın ne?"

### 3. Diğer özellikler

#### 3.1 Yanlış telaffuz edilen Çince çok sesli karakterlerin düzeltilmesi

Çince karakterleri pinyin'e dönüştürmek için [pypinyin](https://github.com/mozillazg/python-pinyin) kullanıyoruz. Ancak, bazen **çok sesli karakterler** (多音字) yanlış telaffuz edilebiliyor.

Bu yanlış telaffuzları elle düzeltmek için, **düzeltilmiş pinyin**'i köşeli parantez `< >` içine alın ve **ton işaretini** ekleyin.

**Örnek:**

- Orijinal metin: `这把剑长三十公分`
- `长` karakterinin pinyin'ini düzeltin:  `这把剑<chang2>三十公分`

> **Not:** Eğer elle birden fazla pinyin atamak isterseniz, her pinyin'i ayrı ayrı `<>` ile çerçeveleyin, örn. `这把<jian4><chang2><san1>十公分`

## Kendi Modelinizi Eğitin

Eğitim ve ince ayar örnekleri için [egs](egs) dizinine bakınız.

## Tartışma & İletişim

Doğrudan [Github Issues](https://github.com/k2-fsa/ZipVoice/issues) üzerinden tartışabilirsiniz.

Ayrıca, QR kodunu tarayarak wechat grubumuza katılabilir veya resmi wechat hesabımızı takip edebilirsiniz.

| Wechat Grubu | Wechat Resmi Hesabı |
| ------------ | ------------------- |
|![wechat](https://k2-fsa.org/zh-CN/assets/pic/wechat_group.jpg) |![wechat](https://k2-fsa.org/zh-CN/assets/pic/wechat_account.jpg) |

## Atıf


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