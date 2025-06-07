<!-- markdownlint-disable first-line-h1 -->
<!-- markdownlint-disable html -->
<!-- markdownlint-disable no-duplicate-header -->

<div align="center">
  <img src="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/logo.svg?raw=true" width="60%" alt="DeepSeek-V3" />
</div>
<hr>
<div align="center" style="line-height: 1;">
  <a href="https://www.deepseek.com/"><img alt="Homepage"
    src="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/badge.svg?raw=true"/></a>
  <a href="https://chat.deepseek.com/"><img alt="Chat"
    src="https://img.shields.io/badge/🤖%20Chat-DeepSeek%20V3-536af5?color=536af5&logoColor=white"/></a>
  <a href="https://huggingface.co/deepseek-ai"><img alt="Hugging Face"
    src="https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-DeepSeek%20AI-ffc107?color=ffc107&logoColor=white"/></a>
  <br>
  <a href="https://discord.gg/Tc7c45Zzu5"><img alt="Discord"
    src="https://img.shields.io/badge/Discord-DeepSeek%20AI-7289da?logo=discord&logoColor=white&color=7289da"/></a>
  <a href="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/qr.jpeg?raw=true"><img alt="Wechat"
    src="https://img.shields.io/badge/WeChat-DeepSeek%20AI-brightgreen?logo=wechat&logoColor=white"/></a>
  <a href="https://twitter.com/deepseek_ai"><img alt="Twitter Follow"
    src="https://img.shields.io/badge/Twitter-deepseek_ai-white?logo=x&logoColor=white"/></a>
  <br>
  <a href="https://github.com/deepseek-ai/DeepSeek-V3/blob/main/LICENSE-CODE"><img alt="Code License"
    src="https://img.shields.io/badge/Code_License-MIT-f5de53?&color=f5de53"/></a>
  <a href="https://github.com/deepseek-ai/DeepSeek-V3/blob/main/LICENSE-MODEL"><img alt="Model License"
    src="https://img.shields.io/badge/Model_License-Model_Agreement-f5de53?&color=f5de53"/></a>
  <br>
  <a href="https://arxiv.org/pdf/2412.19437"><b>Paper Link</b>👁️</a>
</div>

## İçindekiler

1. [Giriş](#1-giriş)
2. [Model Özeti](#2-model-özeti)
3. [Model İndirme](#3-model-indirme)
4. [Değerlendirme Sonuçları](#4-değerlendirme-sonuçları)
5. [Sohbet Web Sitesi & API Platformu](#5-sohbet-web-sitesi--api-platformu)
6. [Yerel Çalıştırma Yönergeleri](#6-yerel-çalıştırma-yönergeleri)
7. [Lisans](#7-lisans)
8. [Atıf](#8-atıf)
9. [İletişim](#9-iletişim)


## 1. Giriş

DeepSeek-V3'ü sunuyoruz: her bir token için 37B aktive edilen, toplamda 671B parametreli güçlü bir Mixture-of-Experts (MoE) dil modeli.
Verimli çıkarım ve maliyet-etkin eğitim sağlamak için DeepSeek-V3, DeepSeek-V2'de kapsamlı şekilde doğrulanan Multi-head Latent Attention (MLA) ve DeepSeekMoE mimarilerini benimser.
Ayrıca DeepSeek-V3, yük dengelemesi için yardımcı kayıpsız bir stratejiye öncülük eder ve daha güçlü performans için çoklu-token tahmin eğitim hedefi belirler.
DeepSeek-V3'ü 14.8 trilyon çeşitli ve yüksek kaliteli token üzerinde önceden eğitiyor, ardından Yönlendirilmiş İnce Ayar ve Takviyeli Öğrenme aşamaları ile yeteneklerini tam olarak kullanıyoruz.
Kapsamlı değerlendirmeler, DeepSeek-V3'ün diğer açık kaynak modelleri geride bıraktığını ve önde gelen kapalı kaynak modellerle karşılaştırılabilir bir performansa ulaştığını ortaya koymaktadır.
Mükemmel performansına rağmen DeepSeek-V3'ün tam eğitimi yalnızca 2.788M H800 GPU saati gerektirir.
Ek olarak, eğitim süreci son derece stabildir.
Tüm eğitim süreci boyunca, geri döndürülemez kayıp sıçramaları yaşanmadı veya herhangi bir geri alma yapılmadı.
<p align="center">
  <img width="80%" src="figures/benchmark.png">
</p>

## 2. Model Özeti

---

**Mimari: Yenilikçi Yük Dengeleme Stratejisi ve Eğitim Hedefi**

- DeepSeek-V2'nin verimli mimarisi üzerine, yük dengelemesi için yardımcı kayıpsız bir stratejiye öncülük ediyoruz; bu, yük dengelemesini teşvik etmekten kaynaklanan performans bozulmasını en aza indirir.
- Çoklu-Token Tahmin (MTP) hedefini inceliyor ve model performansına faydalı olduğunu kanıtlıyoruz.
  Ayrıca, çıkarım hızlandırma için spekülatif kod çözmede de kullanılabilir.

---

**Ön-Eğitim: Nihai Eğitim Verimliliğine Doğru**

- Bir FP8 karma hassasiyetli eğitim çerçevesi tasarlıyor ve ilk kez, FP8 eğitimini aşırı büyük ölçekli bir modelde uygulanabilir ve etkili olduğunu doğruluyoruz.
- Algoritmalar, çerçeveler ve donanımın ortak tasarımıyla, düğümler arası MoE eğitiminde iletişim darboğazını aşıyor ve neredeyse tam hesaplama-iletişim örtüşmesi sağlıyoruz.
  Bu, eğitim verimliliğimizi önemli ölçüde artırır ve eğitim maliyetini azaltır, ek yük olmadan model boyutunu daha da ölçeklendirmemize olanak tanır.
- Yalnızca 2.664M H800 GPU saatlik ekonomik maliyetle, DeepSeek-V3'ün 14.8T token üzerinde ön eğitimini tamamlıyor ve şu anda en güçlü açık kaynak tabanlı modeli üretiyoruz. Ön eğitim sonrası aşamalar ise yalnızca 0.1M GPU saati gerektirir.

---

**Sonrası Eğitim: DeepSeek-R1'den Bilgi Damıtma**

- Uzun Düşünce Zinciri (CoT) modelinden, özellikle DeepSeek R1 serisi modellerden birinden, standart LLM'lere ve özellikle DeepSeek-V3'e muhakeme yeteneklerini damıtan yenilikçi bir metodoloji sunuyoruz. Pipeline'ımız, R1'in doğrulama ve yansıtma kalıplarını DeepSeek-V3'e zarifçe entegre eder ve muhakeme performansını kayda değer şekilde artırır. Aynı zamanda, DeepSeek-V3'ün çıktı stilini ve uzunluğunu da kontrol altında tutarız.

---

## 3. Model İndirme

<div align="center">

| **Model** | **#Toplam Parametre** | **#Aktif Parametre** | **Bağlam Uzunluğu** | **İndir** |
| :------------: | :------------: | :------------: | :------------: | :------------: |
| DeepSeek-V3-Base | 671B | 37B | 128K   | [🤗 Hugging Face](https://huggingface.co/deepseek-ai/DeepSeek-V3-Base)   |
| DeepSeek-V3   | 671B | 37B |  128K   | [🤗 Hugging Face](https://huggingface.co/deepseek-ai/DeepSeek-V3)   |

</div>

> [!NOTE]
> Hugging Face üzerindeki DeepSeek-V3 modellerinin toplam boyutu 685B'dir; bu, 671B Ana Model ağırlıkları ve 14B Çoklu-Token Tahmin (MTP) Modülü ağırlıklarını içerir.

En iyi performans ve esneklik için, açık kaynak toplulukları ve donanım üreticileriyle iş birliği yaparak modeli yerelde çalıştırmak için birden fazla yol sunuyoruz. Adım adım rehberlik için Bölüm 6: [Yerel Çalıştırma Yönergeleri](#6-yerel-çalıştırma-yönergeleri)'ne bakınız.

Daha derine inmek isteyen geliştiriciler için Ana Model ağırlıkları ve Çoklu-Token Tahmin (MTP) Modülleri ile ilgili ayrıntılar için [README_WEIGHTS.md](./README_WEIGHTS.md) dosyasını incelemenizi öneririz. Lütfen MTP desteğinin şu anda topluluk içinde aktif olarak geliştirildiğini, katkı ve geri bildirimlerinize açık olduğumuzu unutmayın.

## 4. Değerlendirme Sonuçları
### Temel Model
#### Standart Kıyaslamalar

<div align="center">

|  | Kıyaslama (Metrik) | # Atış | DeepSeek-V2 | Qwen2.5 72B | LLaMA3.1 405B | DeepSeek-V3 |
|---|-------------------|----------|--------|-------------|---------------|---------|
| | Mimari | - | MoE | Yoğun | Yoğun | MoE |
| | # Aktif Parametre | - | 21B | 72B | 405B | 37B |
| | # Toplam Parametre | - | 236B | 72B | 405B | 671B |
| İngilizce | Pile-test (BPB) | - | 0.606 | 0.638 | **0.542** | 0.548 |
| | BBH (EM) | 3-atış | 78.8 | 79.8 | 82.9 | **87.5** |
| | MMLU (Doğr.) | 5-atış | 78.4 | 85.0 | 84.4 | **87.1** |
| | MMLU-Redux (Doğr.) | 5-atış | 75.6 | 83.2 | 81.3 | **86.2** |
| | MMLU-Pro (Doğr.) | 5-atış | 51.4 | 58.3 | 52.8 | **64.4** |
| | DROP (F1) | 3-atış | 80.4 | 80.6 | 86.0 | **89.0** |
| | ARC-Easy (Doğr.) | 25-atış | 97.6 | 98.4 | 98.4 | **98.9** |
| | ARC-Challenge (Doğr.) | 25-atış | 92.2 | 94.5 | **95.3** | **95.3** |
| | HellaSwag (Doğr.) | 10-atış | 87.1 | 84.8 | **89.2** | 88.9 |
| | PIQA (Doğr.) | 0-atış | 83.9 | 82.6 | **85.9** | 84.7 |
| | WinoGrande (Doğr.) | 5-atış | **86.3** | 82.3 | 85.2 | 84.9 |
| | RACE-Orta (Doğr.) | 5-atış | 73.1 | 68.1 | **74.2** | 67.1 |
| | RACE-Yüksek (Doğr.) | 5-atış | 52.6 | 50.3 | **56.8** | 51.3 |
| | TriviaQA (EM) | 5-atış | 80.0 | 71.9 | 82.7 | **82.9** |
| | NaturalQuestions (EM) | 5-atış | 38.6 | 33.2 | **41.5** | 40.0 |
| | AGIEval (Doğr.) | 0-atış | 57.5 | 75.8 | 60.6 | **79.6** |
| Kod | HumanEval (Pass@1) | 0-atış | 43.3 | 53.0 | 54.9 | **65.2** |
| | MBPP (Pass@1) | 3-atış | 65.0 | 72.6 | 68.4 | **75.4** |
| | LiveCodeBench-Base (Pass@1) | 3-atış | 11.6 | 12.9 | 15.5 | **19.4** |
| | CRUXEval-I (Doğr.) | 2-atış | 52.5 | 59.1 | 58.5 | **67.3** |
| | CRUXEval-O (Doğr.) | 2-atış | 49.8 | 59.9 | 59.9 | **69.8** |
| Matematik | GSM8K (EM) | 8-atış | 81.6 | 88.3 | 83.5 | **89.3** |
| | MATH (EM) | 4-atış | 43.4 | 54.4 | 49.0 | **61.6** |
| | MGSM (EM) | 8-atış | 63.6 | 76.2 | 69.9 | **79.8** |
| | CMath (EM) | 3-atış | 78.7 | 84.5 | 77.3 | **90.7** |
| Çince | CLUEWSC (EM) | 5-atış | 82.0 | 82.5 | **83.0** | 82.7 |
| | C-Eval (Doğr.) | 5-atış | 81.4 | 89.2 | 72.5 | **90.1** |
| | CMMLU (Doğr.) | 5-atış | 84.0 | **89.5** | 73.7 | 88.8 |
| | CMRC (EM) | 1-atış | **77.4** | 75.8 | 76.0 | 76.3 |
| | C3 (Doğr.) | 0-atış | 77.4 | 76.7 | **79.7** | 78.6 |
| | CCPM (Doğr.) | 0-atış | **93.0** | 88.5 | 78.6 | 92.0 |
| Çok Dilli | MMMLU-İngilizce Dışı (Doğr.) | 5-atış | 64.0 | 74.8 | 73.8 | **79.4** |

</div>

> [!NOTE]
> En iyi sonuçlar koyu olarak gösterilmiştir. Farkı 0.3'ü aşmayan skorlar aynı seviyede kabul edilir. DeepSeek-V3 çoğu kıyaslamada, özellikle matematik ve kod görevlerinde en iyi performansa ulaşır.
> Daha fazla değerlendirme ayrıntısı için lütfen makalemize bakınız.

#### Bağlam Penceresi
<p align="center">
  <img width="80%" src="figures/niah.png">
</p>

``Needle In A Haystack`` (NIAH) testlerindeki değerlendirme sonuçları. DeepSeek-V3, **128K**'ya kadar tüm bağlam penceresi uzunluklarında iyi performans gösterir.

### Sohbet Modeli
#### Standart Kıyaslamalar (67B'den büyük Modeller)
<div align="center">

| | **Kıyaslama (Metrik)** | **DeepSeek V2-0506** | **DeepSeek V2.5-0905** | **Qwen2.5 72B-Inst.** | **Llama3.1 405B-Inst.** | **Claude-3.5-Sonnet-1022** | **GPT-4o 0513** | **DeepSeek V3** |
|---|---------------------|---------------------|----------------------|---------------------|----------------------|---------------------------|----------------|----------------|
| | Mimari | MoE | MoE | Yoğun | Yoğun | - | - | MoE |
| | # Aktif Parametre | 21B | 21B | 72B | 405B | - | - | 37B |
| | # Toplam Parametre | 236B | 236B | 72B | 405B | - | - | 671B |
| İngilizce | MMLU (EM) | 78.2 | 80.6 | 85.3 | **88.6** | **88.3** | 87.2 | **88.5** |
| | MMLU-Redux (EM) | 77.9 | 80.3 | 85.6 | 86.2 | **88.9** | 88.0 | **89.1** |
| | MMLU-Pro (EM) | 58.5 | 66.2 | 71.6 | 73.3 | **78.0** | 72.6 | 75.9 |
| | DROP (3-atış F1) | 83.0 | 87.8 | 76.7 | 88.7 | 88.3 | 83.7 | **91.6** |
| | IF-Eval (Prompt Strict) | 57.7 | 80.6 | 84.1 | 86.0 | **86.5** | 84.3 | 86.1 |
| | GPQA-Diamond (Pass@1) | 35.3 | 41.3 | 49.0 | 51.1 | **65.0** | 49.9 | 59.1 |
| | SimpleQA (Doğru) | 9.0 | 10.2 | 9.1 | 17.1 | 28.4 | **38.2** | 24.9 |
| | FRAMES (Doğr.) | 66.9 | 65.4 | 69.8 | 70.0 | 72.5 | **80.5** | 73.3 |
| | LongBench v2 (Doğr.) | 31.6 | 35.4 | 39.4 | 36.1 | 41.0 | 48.1 | **48.7** |
| Kod | HumanEval-Mul (Pass@1) | 69.3 | 77.4 | 77.3 | 77.2 | 81.7 | 80.5 | **82.6** |
| | LiveCodeBench (Pass@1-COT) | 18.8 | 29.2 | 31.1 | 28.4 | 36.3 | 33.4 | **40.5** |
| | LiveCodeBench (Pass@1) | 20.3 | 28.4 | 28.7 | 30.1 | 32.8 | 34.2 | **37.6** |
| | Codeforces (Persantil) | 17.5 | 35.6 | 24.8 | 25.3 | 20.3 | 23.6 | **51.6** |
| | SWE Verified (Çözülen) | - | 22.6 | 23.8 | 24.5 | **50.8** | 38.8 | 42.0 |
| | Aider-Edit (Doğr.) | 60.3 | 71.6 | 65.4 | 63.9 | **84.2** | 72.9 | 79.7 |
| | Aider-Polyglot (Doğr.) | - | 18.2 | 7.6 | 5.8 | 45.3 | 16.0 | **49.6** |
| Matematik | AIME 2024 (Pass@1) | 4.6 | 16.7 | 23.3 | 23.3 | 16.0 | 9.3 | **39.2** |
| | MATH-500 (EM) | 56.3 | 74.7 | 80.0 | 73.8 | 78.3 | 74.6 | **90.2** |
| | CNMO 2024 (Pass@1) | 2.8 | 10.8 | 15.9 | 6.8 | 13.1 | 10.8 | **43.2** |
| Çince | CLUEWSC (EM) | 89.9 | 90.4 | **91.4** | 84.7 | 85.4 | 87.9 | 90.9 |
| | C-Eval (EM) | 78.6 | 79.5 | 86.1 | 61.5 | 76.7 | 76.0 | **86.5** |
| | C-SimpleQA (Doğru) | 48.5 | 54.1 | 48.4 | 50.4 | 51.3 | 59.3 | **64.8** |

</div>

> [!NOTE]
> Tüm modeller, çıktı uzunluğu 8K ile sınırlanan bir yapılandırmada değerlendirilir. 1000'den az örnek içeren kıyaslamalar, sağlam nihai sonuçlar elde etmek için çeşitli sıcaklık ayarlarıyla birden çok kez test edilir. DeepSeek-V3, en iyi performans gösteren açık kaynak modelidir ve öncü kapalı kaynak modellerle de rekabetçi bir performans sergiler.

#### Açık Uçlu Üretim Değerlendirmesi

<div align="center">

| Model | Arena-Hard | AlpacaEval 2.0 |
|-------|------------|----------------|
| DeepSeek-V2.5-0905 | 76.2 | 50.5 |
| Qwen2.5-72B-Instruct | 81.2 | 49.1 |
| LLaMA-3.1 405B | 69.3 | 40.5 |
| GPT-4o-0513 | 80.4 | 51.1 |
| Claude-Sonnet-3.5-1022 | 85.2 | 52.0 |
| DeepSeek-V3 | **85.5** | **70.0** |

</div>

> [!NOTE]
> İngilizce açık uçlu sohbet değerlendirmeleri. AlpacaEval 2.0 için, metrik olarak uzunluk-kontrollü kazanma oranı kullanılır.


## 5. Sohbet Web Sitesi & API Platformu
DeepSeek-V3 ile DeepSeek'in resmi web sitesinde sohbet edebilirsiniz: [chat.deepseek.com](https://chat.deepseek.com/sign_in)

Ayrıca DeepSeek Platformu'nda OpenAI-Uyumlu API sunuyoruz: [platform.deepseek.com](https://platform.deepseek.com/)

## 6. Yerel Çalıştırma Yönergeleri

DeepSeek-V3 aşağıdaki donanım ve açık kaynak topluluk yazılımları kullanılarak yerel olarak dağıtılabilir:

1. **DeepSeek-Infer Demo**: FP8 ve BF16 çıkarımı için basit ve hafif bir demo sunuyoruz.
2. **SGLang**: Hem BF16 hem FP8 çıkarım modlarında DeepSeek-V3 modelini tam olarak destekler, Çoklu-Token Tahmini [yakında](https://github.com/sgl-project/sglang/issues/2591) eklenecek.
3. **LMDeploy**: Yerel ve bulut dağıtımı için verimli FP8 ve BF16 çıkarımı sağlar.
4. **TensorRT-LLM**: Şu anda BF16 çıkarımı ve INT4/8 kuantizasyonunu destekler, FP8 desteği yakında eklenecek.
5. **vLLM**: DeepSeek-V3 modelini FP8 ve BF16 modlarında tensör paralelliği ve boru hattı paralelliği ile destekler.
6. **LightLLM**: FP8 ve BF16 için verimli tek düğüm veya çok düğümlü dağıtım destekler.
7. **AMD GPU**: DeepSeek-V3 modelini SGLang aracılığıyla hem BF16 hem FP8 modlarında AMD GPU’larda çalıştırmanızı sağlar.
8. **Huawei Ascend NPU**: DeepSeek-V3'ü Huawei Ascend cihazlarında çalıştırmayı destekler.

FP8 eğitimi çerçevemizde doğal olarak benimsenmiştir; bu nedenle yalnızca FP8 ağırlıkları sunuyoruz. Deney için BF16 ağırlıklarına ihtiyacınız varsa, sağlanan dönüştürme betiğini kullanarak dönüşümü gerçekleştirebilirsiniz.

İşte FP8 ağırlıklarını BF16'ya dönüştürme örneği:

```shell
cd inference
python fp8_cast_bf16.py --input-fp8-hf-path /path/to/fp8_weights --output-bf16-hf-path /path/to/bf16_weights
```

> [!NOTE]
> Hugging Face Transformers henüz doğrudan desteklenmemektedir.

### 6.1 DeepSeek-Infer Demo ile Çıkarım (yalnızca örnek)

#### Sistem Gereksinimleri

> [!NOTE]
> Sadece Python 3.10 ile Linux. Mac ve Windows desteklenmemektedir.

Bağımlılıklar:
```pip-requirements
torch==2.4.1
triton==3.0.0
transformers==4.46.3
safetensors==0.4.5
```
#### Model Ağırlıkları & Demo Kod Hazırlığı

Önce DeepSeek-V3 GitHub deposunu klonlayın:

```shell
git clone https://github.com/deepseek-ai/DeepSeek-V3.git
```

`inference` klasörüne gidin ve `requirements.txt` dosyasındaki bağımlılıkları yükleyin. En kolay yol olarak `conda` veya `uv` gibi bir paket yöneticisi ile yeni bir sanal ortam oluşturup bağımlılıkları yükleyin.

```shell
cd DeepSeek-V3/inference
pip install -r requirements.txt
```

Model ağırlıklarını Hugging Face'ten indirin ve `/path/to/DeepSeek-V3` klasörüne yerleştirin.

#### Model Ağırlıklarını Dönüştürme

Hugging Face model ağırlıklarını belirli bir formata dönüştürün:

```shell
python convert.py --hf-ckpt-path /path/to/DeepSeek-V3 --save-path /path/to/DeepSeek-V3-Demo --n-experts 256 --model-parallel 16
```

#### Çalıştırma

Artık DeepSeek-V3 ile sohbet edebilirsiniz:

```shell
torchrun --nnodes 2 --nproc-per-node 8 --node-rank $RANK --master-addr $ADDR generate.py --ckpt-path /path/to/DeepSeek-V3-Demo --config configs/config_671B.json --interactive --temperature 0.7 --max-new-tokens 200
```

Veya verilen bir dosya üzerinde toplu çıkarım:

```shell
torchrun --nnodes 2 --nproc-per-node 8 --node-rank $RANK --master-addr $ADDR generate.py --ckpt-path /path/to/DeepSeek-V3-Demo --config configs/config_671B.json --input-file $FILE
```

### 6.2 SGLang ile Çıkarım (önerilir)

[SGLang](https://github.com/sgl-project/sglang), şu anda [MLA optimizasyonları](https://lmsys.org/blog/2024-09-04-sglang-v0-3/#deepseek-multi-head-latent-attention-mla-throughput-optimizations), [DP Attention](https://lmsys.org/blog/2024-12-04-sglang-v0-4/#data-parallelism-attention-for-deepseek-models), FP8 (W8A8), FP8 KV Cache ve Torch Compile'ı destekler; açık kaynak çerçeveler arasında son teknoloji gecikme ve aktarım performansı sunar.

Özellikle, [SGLang v0.4.1](https://github.com/sgl-project/sglang/releases/tag/v0.4.1), DeepSeek-V3'ü hem **NVIDIA hem de AMD GPU’larda** çalıştırmayı tamamen destekler; bu da onu son derece çok yönlü ve sağlam bir çözüm haline getirir.

SGLang ayrıca [çoklu düğüm tensör paralelliğini](https://github.com/sgl-project/sglang/tree/main/benchmark/deepseek_v3#example-serving-with-2-h208) destekler ve bu modeli birden fazla ağ bağlantılı makinede çalıştırmanıza olanak tanır.

Çoklu-Token Tahmini (MTP) geliştirilmektedir ve ilerleme [optimizasyon planında](https://github.com/sgl-project/sglang/issues/2591) takip edilebilir.

SGLang ekibinden başlatma yönergeleri: https://github.com/sgl-project/sglang/tree/main/benchmark/deepseek_v3

### 6.3 LMDeploy ile Çıkarım (önerilir)
[LMDeploy](https://github.com/InternLM/lmdeploy), büyük dil modelleri için esnek ve yüksek performanslı bir çıkarım ve servis çerçevesidir; artık DeepSeek-V3'ü destekler. Hem çevrimdışı boru hattı işleme hem de çevrimiçi dağıtım özellikleri sunar ve PyTorch tabanlı iş akışlarıyla sorunsuz entegre olur.

DeepSeek-V3'ü LMDeploy ile çalıştırmak için kapsamlı adım adım talimatlar için buraya bakınız: https://github.com/InternLM/lmdeploy/issues/2960


### 6.4 TRT-LLM ile Çıkarım (önerilir)

[TensorRT-LLM](https://github.com/NVIDIA/TensorRT-LLM) artık DeepSeek-V3 modelini destekler ve BF16, INT4/INT8 ağırlık-yalnızca gibi hassasiyet seçenekleri sunar. FP8 desteği şu anda geliştiriliyor ve yakında yayımlanacaktır. DeepSeek-V3 desteği için özel TRTLLM dalına şu bağlantıdan ulaşabilir ve yeni özellikleri doğrudan deneyimleyebilirsiniz: https://github.com/NVIDIA/TensorRT-LLM/tree/main/examples/deepseek_v3.


### 6.5 vLLM ile Çıkarım (önerilir)

[vLLM](https://github.com/vllm-project/vllm) v0.6.6, DeepSeek-V3 çıkarımını FP8 ve BF16 modlarında hem NVIDIA hem de AMD GPU’larda destekler. Standart tekniklere ek olarak, vLLM _boru hattı paralelliği_ sunar ve bu modeli ağ ile bağlı birden fazla makinede çalıştırmanıza olanak tanır. Detaylı rehberlik için [vLLM talimatlarına](https://docs.vllm.ai/en/latest/serving/distributed_serving.html) bakınız. Ayrıca [iyileştirme planını](https://github.com/vllm-project/vllm/issues/11539) takip edebilirsiniz.

### 6.6 LightLLM ile Çıkarım (önerilir)

[LightLLM](https://github.com/ModelTC/lightllm/tree/main) v1.0.1, DeepSeek-R1 (FP8/BF16) için tek makine ve çok makine tensör paralel dağıtımı destekler ve karma hassasiyetli dağıtım sunar, daha fazla kuantizasyon modu sürekli entegre edilmektedir. Daha fazla ayrıntı için [LightLLM talimatlarına](https://lightllm-en.readthedocs.io/en/latest/getting_started/quickstart.html) bakınız. Ayrıca LightLLM, DeepSeek-V2 için PD-ayrıştırılmış dağıtım sunar ve DeepSeek-V3 için PD-ayrıştırılmış dağıtım geliştirme aşamasındadır.

### 6.7 AMD GPU’larla Önerilen Çıkarım Fonksiyonelliği

AMD ekibiyle iş birliği içinde, SGLang kullanarak AMD GPU’larda Gün-1 desteği elde ettik ve hem FP8 hem de BF16 hassasiyetleri için tam uyumluluk sağladık. Detaylı rehberlik için [SGLang talimatlarına](#63-lmdeploy-ile-çıkarım-önerilir) bakınız.

### 6.8 Huawei Ascend NPU’larla Önerilen Çıkarım Fonksiyonelliği
Huawei Ascend topluluğunun [MindIE](https://www.hiascend.com/en/software/mindie) çerçevesi, DeepSeek-V3'ün BF16 versiyonuna başarıyla adapte edilmiştir. Ascend NPU’lar için adım adım rehberlik için [buradaki talimatları](https://modelers.cn/models/MindIE/deepseekv3) izleyiniz.


## 7. Lisans
Bu kod deposu [MIT Lisansı](LICENSE-CODE) ile lisanslanmıştır. DeepSeek-V3 Base/Chat modellerinin kullanımı [Model Lisansı](LICENSE-MODEL) ile düzenlenir. DeepSeek-V3 serisi (Base ve Chat dahil) ticari kullanımı destekler.

## 8. Atıf
```
@misc{deepseekai2024deepseekv3technicalreport,
      title={DeepSeek-V3 Technical Report}, 
      author={DeepSeek-AI},
      year={2024},
      eprint={2412.19437},
      archivePrefix={arXiv},
      primaryClass={cs.CL},
      url={https://arxiv.org/abs/2412.19437}, 
}
```

## 9. İletişim
Herhangi bir sorunuz olursa lütfen bir issue açın veya bize [service@deepseek.com](service@deepseek.com) adresinden ulaşın.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---