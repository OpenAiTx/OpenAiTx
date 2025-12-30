
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

## Flow Matching ile Hızlı ve Yüksek Kaliteli Sıfırdan Metinden Sese Dönüşüm
</div>

## Genel Bakış

ZipVoice, flow matching tabanlı hızlı ve yüksek kaliteli sıfır atışlı TTS modellerinden oluşan bir seridir.

### 1. Temel Özellikler

- Küçük ve hızlı: yalnızca 123M parametre.

- Yüksek kaliteli ses klonlama: konuşmacı benzerliği, anlaşılabilirlik ve doğallıkta alanında öncü performans.

- Çok dilli: Çince ve İngilizce desteği.

- Çok modlu: hem tek konuşmacılı hem de diyalog konuşması üretimini destekler.

### 2. Model varyantları

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
      <td>Çince ve İngilizce'de sıfır atışlı tek konuşmacılı TTS'yi destekleyen temel model.</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2506.13053"><img src="https://img.shields.io/badge/arXiv-Makale-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Sayfası-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Distill</td>
      <td>ZipVoice’un damıtılmış sürümü; minimum performans kaybıyla geliştirilmiş hız sunar.</td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog</td>
      <td>ZipVoice üzerine kurulu, tek kanallı iki taraflı konuşma diyalogları üretebilen bir diyalog üretim modeli.</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2507.09318"><img src="https://img.shields.io/badge/arXiv-Makale-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice-dialog.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Sayfası-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog-Stereo</td>
      <td>ZipVoice-Dialog'ın stereo varyantı, her konuşmacının ayrı bir kanala atanmasıyla iki kanallı diyalog üretimini sağlar.</td>
    </tr>
  </tbody>
</table>

## Haberler

**2025/07/14**: **ZipVoice-Dialog** ve **ZipVoice-Dialog-Stereo**, iki konuşma diyalogu üretim modeli yayınlandı. [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice-dialog.github.io)

**2025/07/14**: **OpenDialog** veri seti, 6.8k saatlik konuşma diyalogu veri seti yayınlandı. İndir: [![hf](https://img.shields.io/badge/%F0%9F%A4%97%20HuggingFace-Dataset-yellow)](https://huggingface.co/datasets/k2-fsa/OpenDialog), [![ms](https://img.shields.io/badge/ModelScope-Dataset-blue?logo=data)](https://www.modelscope.cn/datasets/k2-fsa/OpenDialog). Detaylara bakınız: [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318).

**2025/06/16**: **ZipVoice** ve **ZipVoice-Distill** yayınlandı. [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2506.13053) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice.github.io)

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
### 4. Eğitim veya verimli çıkarım için k2'yi kurun

**k2 eğitim için gereklidir** ve çıkarımı hızlandırabilir. Yine de, k2 yüklemeden ZipVoice'ın çıkarım modunu kullanabilirsiniz.

> **Not:**  Kullandığınız PyTorch ve CUDA sürümüne uygun k2 sürümünü kurduğunuzdan emin olun. Örneğin, eğer pytorch 2.5.1 ve CUDA 12.1 kullanıyorsanız, k2'yi şu şekilde kurabilirsiniz:


```bash
pip install k2==1.24.4.dev20250208+cuda12.1.torch2.5.1 -f https://k2-fsa.github.io/k2/cuda.html
```
Lütfen ayrıntılar için https://k2-fsa.org/get-started/k2/ adresine bakınız.
Çin anakarasındaki kullanıcılar https://k2-fsa.org/zh-CN/get-started/k2/ adresine başvurabilirler.

- k2 kurulumunu kontrol etmek için:


```bash
python3 -c "import k2; print(k2.__file__)"
```
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
- `--model-name` değeri `zipvoice` veya `zipvoice_distill` olabilir; bunlar sırasıyla distilasyon öncesi ve sonrası modellerdir.
- Eğer metinde `<>` veya `[]` görünürse, bunlar arasındaki dizeler özel belirteçler olarak kabul edilir. `<>` Çin pinyin'ini, `[]` ise diğer özel etiketleri ifade eder.

#### 1.2 Bir cümle listesinin çıkarımı

```bash
python3 -m zipvoice.bin.infer_zipvoice \
    --model-name zipvoice \
    --test-list test.tsv \
    --res-dir results
```
- `test.tsv` dosyasının her satırı `{wav_name}\t{prompt_transcription}\t{prompt_wav}\t{text}` formatındadır.

### 2. Diyalog konuşma üretimi

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
- `prompt_transcription`, konuşma istemi wav dosyasının transkripsiyonudur, örneğin, "[S1] Merhaba. [S2] Nasılsın?"
- `prompt_wav`, istem wav dosyasının yoludur.
- `text`, sentezlenecek metindir, örneğin, "[S1] İyiyim. [S2] Adın ne? [S1] Ben Eric. [S2] Merhaba Eric."

(2) **Bölünmüş istem formatı**: iki konuşmacının sesleri ve transkripsiyonları ayrı dosyalarda bulunur:

```
{wav_name}\t{spk1_prompt_transcription}\t{spk2_prompt_transcription}\t{spk1_prompt_wav}\t{spk2_prompt_wav}\t{text}
```
- `wav_name`, çıktı wav dosyasının adıdır.
- `spk1_prompt_transcription`, birinci konuşmacının istem wav dosyasının transkripsiyonudur, örn. "Merhaba"
- `spk2_prompt_transcription`, ikinci konuşmacının istem wav dosyasının transkripsiyonudur, örn. "Nasılsın?"
- `spk1_prompt_wav`, birinci konuşmacının istem wav dosyasının yoludur.
- `spk2_prompt_wav`, ikinci konuşmacının istem wav dosyasının yoludur.
- `text`, sentezlenecek metindir, örn. "[S1] İyiyim. [S2] Adın ne? [S1] Ben Eric. [S2] Merhaba Eric."

### 3 Daha iyi kullanım için rehberlik:

#### 3.1 İstem uzunluğu

Daha hızlı çıkarım hızı için kısa bir istem wav dosyası öneriyoruz (örn., tek konuşmacılı konuşma üretimi için 3 saniyeden az, diyalog konuşma üretimi için 10 saniyeden az). Çok uzun bir istem, çıkarımı yavaşlatır ve konuşma kalitesini düşürür.

#### 3.2 Hız optimizasyonu

Çıkarım hızı tatmin edici değilse, aşağıdaki şekilde hızlandırabilirsiniz:

- **Distil model ve daha az adım**: Tek konuşmacılı konuşma üretim modeli için, daha iyi konuşma kalitesi için varsayılan olarak `zipvoice` modelini kullanıyoruz. Eğer hız önceliğinizse, `zipvoice_distill` modeline geçebilir ve `--num-steps` değerini varsayılan 8’den 4’e kadar düşürebilirsiniz.

- **CPU’da çoklu iş parçacığı ile hızlandırma**: CPU’da çalıştırırken, daha hızlı bir hız için `--num-thread` parametresiyle (örn., `--num-thread 4`) iş parçacığı sayısını artırabilirsiniz. Varsayılan olarak 1 iş parçacığı kullanıyoruz.

- **CPU’da ONNX ile hızlandırma**: CPU’da çalışırken, daha hızlı bir hız için ONNX modellerini `zipvoice.bin.infer_zipvoice_onnx` ile kullanabilirsiniz (henüz diyalog üretim modelleri için ONNX desteklenmiyor). Daha da hızlı bir hız için `--onnx-int8 True` ayarlayarak INT8-kuantize ONNX modeli kullanabilirsiniz. Kuantize modelin konuşma kalitesinde belli bir düşüşe neden olacağını unutmayın. **ONNX’i GPU’da kullanmayın**, çünkü GPU’da PyTorch’tan daha yavaştır.

- **NVIDIA TensorRT ile GPU Hızlandırma**: NVIDIA GPU’larda önemli bir performans artışı için, önce modeli zipvoice.bin.tensorrt_export kullanarak bir TensorRT motoruna aktarın. Ardından, veri kümeniz üzerinde (örn., bir Hugging Face veri kümesi) zipvoice.bin.infer_zipvoice ile çıkarım çalıştırın. Bu, GPU’da standart PyTorch uygulamasına göre yaklaşık 2 kat daha fazla verim sağlayabilir.

#### 3.3 Bellek kontrolü

Verilen metin, noktalama işaretlerine (tek konuşmacılı konuşma üretimi için) veya konuşmacı değişim sembolüne (diyalog konuşma üretimi için) göre parçalara ayrılacaktır. Sonra, parçalara ayrılan metinler toplu halde işlenecektir. Bu nedenle, model neredeyse sabit bellek kullanımıyla rastgele uzunluktaki metni işleyebilir. Bellek kullanımını `--max-duration` parametresiyle ayarlayabilirsiniz.

#### 3.4 "Ham" değerlendirme

Varsayılan olarak, verimli çıkarım ve daha iyi performans için girdileri (istem wav, istem transkripsiyonu ve metin) ön işleme tabi tutuyoruz. Modelin tam olarak verilen girdilerle ("ham" performansını) değerlendirmek isterseniz (örn., makalemizdeki sonuçları çoğaltmak için), `--raw-evaluation True` parametresini geçebilirsiniz.

#### 3.5 Kısa metin

Çok kısa metinler için konuşma üretirken (örn., bir ya da iki kelime), üretilen konuşma bazen bazı telaffuzları atlayabilir. Bu sorunu çözmek için, `--speed 0.3` (0.3 ayarlanabilir bir değerdir) parametresiyle üretilen konuşmanın süresini uzatabilirsiniz.

#### 3.6 Yanlış telaffuz edilen Çince polifon karakterlerin düzeltilmesi


Çince karakterleri pinyin’e dönüştürmek için [pypinyin](https://github.com/mozillazg/python-pinyin) kullanıyoruz. Ancak bazen **çok sesli karakterleri** (多音字) yanlış telaffuz edebilir.

Bu yanlış telaffuzları elle düzeltmek için, **düzeltilmiş pinyin’i** köşeli parantezler `< >` içine alın ve **ton işaretini** ekleyin.

**Örnek:**

- Orijinal metin: `这把剑长三十公分`
- `长` karakterinin pinyin’ini düzeltin:  `这把剑<chang2>三十公分`

> **Not:** Birden fazla pinyin’i elle atamak isterseniz, her pinyin’i `<>` ile çevreleyin, örn: `这把<jian4><chang2><san1>十公分`

#### 3.7 Oluşturulan konuşmadan uzun sessizlikleri kaldırma

Model, oluşturulan konuşmadaki sessizliklerin yerini ve uzunluğunu otomatik olarak belirler. Bazen konuşmanın ortasında uzun bir sessizlik olabilir. Bunu istemiyorsanız, oluşturulan konuşmanın ortasındaki uzun sessizlikleri kaldırmak için `--remove-long-sil` komutunu kullanabilirsiniz (kenar sessizlikleri varsayılan olarak kaldırılır).

#### 3.8 Model indirme

Önceden eğitilmiş modelleri indirirken HuggingFace’e bağlanmada sorun yaşarsanız, uç noktayı yansı (mirror) siteye geçirmeyi deneyin: `export HF_ENDPOINT=https://hf-mirror.com`.

## Kendi Modelinizi Eğitin

Eğitim, ince ayar ve değerlendirme örnekleri için [egs](egs) dizinine bakın.

## Üretim Ortamında Kullanım

### NVIDIA Triton GPU Çalışma Zamanı

Yüksek performans ve ölçeklenebilir üretim dağıtımı için, optimize edilmiş TensorRT motorları, eşzamanlı istek işleme ve kurumsal kullanım için gRPC/HTTP API’leri sağlayan [Triton Inference Server entegrasyonuna](runtime/nvidia_triton/) göz atın.

### CPU Dağıtımı

CPU üzerinde C++ ile dağıtım çözümü için [sherpa-onnx](https://github.com/k2-fsa/sherpa-onnx/pull/2487#issuecomment-3227884498) inceleyin.

## Tartışma ve İletişim

Doğrudan [Github Issues](https://github.com/k2-fsa/ZipVoice/issues) üzerinden tartışabilirsiniz.

Ayrıca QR kodunu tarayarak WeChat grubumuza katılabilir veya WeChat resmi hesabımızı takip edebilirsiniz.

| Wechat Grubu | Wechat Resmi Hesabı |
| ------------ | ----------------------- |
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




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-30

---