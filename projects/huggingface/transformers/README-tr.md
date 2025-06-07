<!---
Copyright 2020 The HuggingFace Team. Tüm hakları saklıdır.

Apache Lisansı, Sürüm 2.0 ("Lisans") kapsamında lisanslanmıştır;
Bu dosyayı Lisans'a uygun olmadıkça kullanamazsınız.
Lisansın bir kopyasını şu adresten edinebilirsiniz:

    http://www.apache.org/licenses/LICENSE-2.0

Yürürlükteki kanunlar gerektirmedikçe veya yazılı olarak anlaşılmadıkça,
yazılım, "OLDUĞU GİBİ" TEMELİNDE, HERHANGİ BİR GARANTİ OLMAKSIZIN, açık veya örtük olarak dağıtılır.
Lisans kapsamındaki izin ve sınırlamalar için Lisansa bakınız.
-->

<p align="center">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://huggingface.co/datasets/huggingface/documentation-images/raw/main/transformers-logo-dark.svg">
    <source media="(prefers-color-scheme: light)" srcset="https://huggingface.co/datasets/huggingface/documentation-images/raw/main/transformers-logo-light.svg">
    <img alt="Hugging Face Transformers Kütüphanesi" src="https://huggingface.co/datasets/huggingface/documentation-images/raw/main/transformers-logo-light.svg" width="352" height="59" style="max-width: 100%;">
  </picture>
  <br/>
  <br/>
</p>

<p align="center">
    <a href="https://huggingface.com/models"><img alt="Hub'da Checkpoint'ler" src="https://img.shields.io/endpoint?url=https://huggingface.co/api/shields/models&color=brightgreen"></a>
    <a href="https://circleci.com/gh/huggingface/transformers"><img alt="Yapı" src="https://img.shields.io/circleci/build/github/huggingface/transformers/main"></a>
    <a href="https://github.com/huggingface/transformers/blob/main/LICENSE"><img alt="GitHub" src="https://img.shields.io/github/license/huggingface/transformers.svg?color=blue"></a>
    <a href="https://huggingface.co/docs/transformers/index"><img alt="Dokümantasyon" src="https://img.shields.io/website/http/huggingface.co/docs/transformers/index.svg?down_color=red&down_message=offline&up_message=online"></a>
    <a href="https://github.com/huggingface/transformers/releases"><img alt="GitHub sürümü" src="https://img.shields.io/github/release/huggingface/transformers.svg"></a>
    <a href="https://github.com/huggingface/transformers/blob/main/CODE_OF_CONDUCT.md"><img alt="Contributor Covenant" src="https://img.shields.io/badge/Contributor%20Covenant-v2.0%20adopted-ff69b4.svg"></a>
    <a href="https://zenodo.org/badge/latestdoi/155220641"><img src="https://zenodo.org/badge/155220641.svg" alt="DOI"></a>
</p>

<h4 align="center">
    <p>
        <b>English</b> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_zh-hans.md">简体中文</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_zh-hant.md">繁體中文</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_ko.md">한국어</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_es.md">Español</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_ja.md">日本語</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_hd.md">हिन्दी</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_ru.md">Русский</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_pt-br.md">Рortuguês</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_te.md">తెలుగు</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_fr.md">Français</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_de.md">Deutsch</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_vi.md">Tiếng Việt</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_ar.md">العربية</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_ur.md">اردو</a> |
    </p>
</h4>

<h3 align="center">
    <p>Çıkarım ve eğitim için en ileri düzeyde önceden eğitilmiş modeller</p>
</h3>

<h3 align="center">
    <a href="https://hf.co/course"><img src="https://huggingface.co/datasets/huggingface/documentation-images/resolve/main/course_banner.png"></a>
</h3>

Transformers, çıkarım ve eğitim için önceden eğitilmiş metin, bilgisayarla görü, ses, video ve çoklu-modelli modellerin bir kütüphanesidir. Transformers ile modellerinizi verileriniz üzerinde ince ayar yapabilir, çıkarım uygulamaları geliştirebilir ve çoklu-modelli üretken yapay zeka kullanım senaryoları için kullanabilirsiniz.

[Hugging Face Hub](https://huggingface.com/models) üzerinde kullanabileceğiniz 500.000'den fazla Transformers [model checkpoint'i](https://huggingface.co/models?library=transformers&sort=trending) bulunmaktadır.

Bugün [Hub](https://huggingface.com/) üzerinde bir modeli keşfedin ve Transformers ile hemen başlamanıza yardımcı olun.

## Kurulum

Transformers, Python 3.9+, [PyTorch](https://pytorch.org/get-started/locally/) 2.1+, [TensorFlow](https://www.tensorflow.org/install/pip) 2.6+ ve [Flax](https://flax.readthedocs.io/en/latest/) 0.4.1+ ile çalışır.

[venv](https://docs.python.org/3/library/venv.html) veya hızlı bir Rust tabanlı Python paket ve proje yöneticisi olan [uv](https://docs.astral.sh/uv/) ile bir sanal ortam oluşturup etkinleştirin.

```py
# venv
python -m venv .my-env
source .my-env/bin/activate
# uv
uv venv .my-env
source .my-env/bin/activate
```

Transformers'ı sanal ortamınıza kurun.

```py
# pip
pip install "transformers[torch]"

# uv
uv pip install "transformers[torch]"
```

Kütüphanedeki en son değişiklikleri isterseniz veya katkıda bulunmak istiyorsanız Transformers'ı kaynaktan kurun. Ancak, *en son* sürüm kararlı olmayabilir. Bir hata ile karşılaşırsanız bir [issue](https://github.com/huggingface/transformers/issues) açmaktan çekinmeyin.

```shell
git clone https://github.com/huggingface/transformers.git
cd transformers

# pip
pip install .[torch]

# uv
uv pip install .[torch]
```

## Hızlı Başlangıç

[Pipeline](https://huggingface.co/docs/transformers/pipeline_tutorial) API ile hemen Transformers'ı kullanmaya başlayın. `Pipeline`, metin, ses, görsel ve çoklu-modelli görevleri destekleyen üst düzey bir çıkarım sınıfıdır. Girdinin ön işlemesini yapar ve uygun çıktıyı döndürür.

Bir pipeline başlatın ve metin üretimi için kullanılacak modeli belirtin. Model indirilir ve önbelleğe alınır, böylece kolayca tekrar kullanabilirsiniz. Son olarak, modele tetikleyici olarak bir metin gönderin.

```py
from transformers import pipeline

pipeline = pipeline(task="text-generation", model="Qwen/Qwen2.5-1.5B")
pipeline("the secret to baking a really good cake is ")
[{'generated_text': 'the secret to baking a really good cake is 1) to use the right ingredients and 2) to follow the recipe exactly. the recipe for the cake is as follows: 1 cup of sugar, 1 cup of flour, 1 cup of milk, 1 cup of butter, 1 cup of eggs, 1 cup of chocolate chips. if you want to make 2 cakes, how much sugar do you need? To make 2 cakes, you will need 2 cups of sugar.'}]
```

Bir modelle sohbet etmek için kullanım deseni aynıdır. Tek fark, sizinle sistem arasındaki sohbet geçmişini (`Pipeline`'a giriş olarak) oluşturmanız gerekmektedir.

> [!IPUCU]
> Komut satırından da doğrudan bir modelle sohbet edebilirsiniz.
> ```shell
> transformers chat Qwen/Qwen2.5-0.5B-Instruct
> ```

```py
import torch
from transformers import pipeline

chat = [
    {"role": "system", "content": "Sen, Hollywood 1986 tasvirine göre sarkastik, esprili bir robotsun."},
    {"role": "user", "content": "Hey, New York'ta yapılacak eğlenceli şeyler önerebilir misin?"}
]

pipeline = pipeline(task="text-generation", model="meta-llama/Meta-Llama-3-8B-Instruct", torch_dtype=torch.bfloat16, device_map="auto")
response = pipeline(chat, max_new_tokens=512)
print(response[0]["generated_text"][-1]["content"])
```

Aşağıdaki örnekleri genişleterek `Pipeline`'ın farklı modlar ve görevlerde nasıl çalıştığını görebilirsiniz.

<details>
<summary>Otomatik konuşma tanıma</summary>

```py
from transformers import pipeline

pipeline = pipeline(task="automatic-speech-recognition", model="openai/whisper-large-v3")
pipeline("https://huggingface.co/datasets/Narsil/asr_dummy/resolve/main/mlk.flac")
{'text': ' I have a dream that one day this nation will rise up and live out the true meaning of its creed.'}
```

</details>

<details>
<summary>Görsel sınıflandırma</summary>

<h3 align="center">
    <a><img src="https://huggingface.co/datasets/Narsil/image_dummy/raw/main/parrots.png"></a>
</h3>

```py
from transformers import pipeline

pipeline = pipeline(task="image-classification", model="facebook/dinov2-small-imagenet1k-1-layer")
pipeline("https://huggingface.co/datasets/Narsil/image_dummy/raw/main/parrots.png")
[{'label': 'macaw', 'score': 0.997848391532898},
 {'label': 'sulphur-crested cockatoo, Kakatoe galerita, Cacatua galerita',
  'score': 0.0016551691805943847},
 {'label': 'lorikeet', 'score': 0.00018523589824326336},
 {'label': 'African grey, African gray, Psittacus erithacus',
  'score': 7.85409429227002e-05},
 {'label': 'quail', 'score': 5.502637941390276e-05}]
```

</details>

<details>
<summary>Görsel soru yanıtlama</summary>


<h3 align="center">
    <a><img src="https://huggingface.co/datasets/huggingface/documentation-images/resolve/main/transformers/tasks/idefics-few-shot.jpg"></a>
</h3>

```py
from transformers import pipeline

pipeline = pipeline(task="visual-question-answering", model="Salesforce/blip-vqa-base")
pipeline(
    image="https://huggingface.co/datasets/huggingface/documentation-images/resolve/main/transformers/tasks/idefics-few-shot.jpg",
    question="What is in the image?",
)
[{'answer': 'statue of liberty'}]
```

</details>

## Neden Transformers kullanmalıyım?

1. Kullanımı kolay, en ileri düzeyde modeller:
    - Doğal dil anlama ve üretim, bilgisayarla görü, ses, video ve çoklu-modelli görevlerde yüksek performans.
    - Araştırmacılar, mühendisler ve geliştiriciler için düşük giriş bariyeri.
    - Öğrenilecek sadece üç sınıf ile az sayıda kullanıcıya yönelik soyutlama.
    - Tüm önceden eğitilmiş modellerimiz için birleşik bir API.

1. Daha düşük hesaplama maliyetleri, daha küçük karbon ayak izi:
    - Sıfırdan eğitim yapmak yerine eğitilmiş modelleri paylaşın.
    - Hesaplama süresini ve üretim maliyetlerini azaltın.
    - Tüm modlarda 1 milyondan fazla önceden eğitilmiş checkpoint'e sahip onlarca model mimarisi.

1. Bir modelin ömrünün her aşaması için doğru framework'ü seçin:
    - En ileri düzeyde modelleri 3 satır kod ile eğitin.
    - Tek bir modeli istediğiniz gibi PyTorch/JAX/TF2.0 framework'leri arasında taşıyın.
    - Eğitim, değerlendirme ve üretim için doğru framework'ü seçin.

1. Bir modeli veya örneği kolayca ihtiyaçlarınıza göre özelleştirin:
    - Her mimari için, orijinal yazarlarının yayınladığı sonuçları yeniden üretmek için örnekler sunuyoruz.
    - Model iç yapıları olabildiğince tutarlı bir şekilde açığa çıkarılmıştır.
    - Model dosyaları, hızlı denemeler için kütüphaneden bağımsız olarak kullanılabilir.

<a target="_blank" href="https://huggingface.co/enterprise">
    <img alt="Hugging Face Enterprise Hub" src="https://github.com/user-attachments/assets/247fb16d-d251-4583-96c4-d3d76dda4925">
</a><br>

## Neden Transformers kullanmamalıyım?

- Bu kütüphane, sinir ağları için modüler bir yapı bloğu kutusu değildir. Model dosyalarındaki kod, araştırmacıların ek soyutlamalara/gerekli ek dosyalara girmeden modeller üzerinde hızlıca yineleme yapabilmesi için özellikle ek soyutlamalarla yeniden düzenlenmemiştir.
- Eğitim API'si, Transformers tarafından sağlanan PyTorch modelleriyle çalışacak şekilde optimize edilmiştir. Genel makine öğrenimi döngüleri için [Accelerate](https://huggingface.co/docs/accelerate) gibi başka bir kütüphane kullanmalısınız.
- [Örnek betikler]((https://github.com/huggingface/transformers/tree/main/examples)) yalnızca *örnektir*. Spesifik kullanım senaryonuzda kutudan çıkar çıkmaz çalışmayabilirler ve çalışması için kodu uyarlamanız gerekebilir.

## Transformers kullanan 100 proje

Transformers, yalnızca önceden eğitilmiş modelleri kullanmak için bir araç seti değil, çevresinde topluluk projeleri inşa edilen bir ekosistemdir ve
Hugging Face Hub'ın bir parçasıdır. Transformers'ın geliştiricilerin, araştırmacıların, öğrencilerin, profesörlerin, mühendislerin ve diğer herkesin hayal ettikleri projeleri kurmalarını sağlamasını istiyoruz.

Transformers'ın 100.000 yıldızını kutlamak için,
topluluğu öne çıkarmak istedik ve [awesome-transformers](./awesome-transformers.md) sayfasında
Transformers ile oluşturulmuş 100 inanılmaz projeyi listeledik.

Sahip olduğunuz veya kullandığınız bir projenin listede olması gerektiğini düşünüyorsanız eklemek için bir PR açın!

## Örnek modeller

Çoğu modelimizi doğrudan [Hub model sayfalarında](https://huggingface.co/models) test edebilirsiniz.

Aşağıda her modun örnek modellerini görmek için genişletin.

<details>
<summary>Ses</summary>

- [Whisper](https://huggingface.co/openai/whisper-large-v3-turbo) ile ses sınıflandırma
- [Moonshine](https://huggingface.co/UsefulSensors/moonshine) ile otomatik konuşma tanıma
- [Wav2Vec2](https://huggingface.co/superb/wav2vec2-base-superb-ks) ile anahtar kelime tespiti
- [Moshi](https://huggingface.co/kyutai/moshiko-pytorch-bf16) ile sesten sese üretim
- [MusicGen](https://huggingface.co/facebook/musicgen-large) ile metinden sese
- [Bark](https://huggingface.co/suno/bark) ile metinden konuşmaya

</details>

<details>
<summary>Bilgisayarla görü</summary>

- [SAM](https://huggingface.co/facebook/sam-vit-base) ile otomatik maske oluşturma
- [DepthPro](https://huggingface.co/apple/DepthPro-hf) ile derinlik tahmini
- [DINO v2](https://huggingface.co/facebook/dinov2-base) ile görüntü sınıflandırma
- [SuperGlue](https://huggingface.co/magic-leap-community/superglue_outdoor) ile anahtar nokta tespiti
- [SuperGlue](https://huggingface.co/magic-leap-community/superglue) ile anahtar nokta eşleştirme
- [RT-DETRv2](https://huggingface.co/PekingU/rtdetr_v2_r50vd) ile nesne tespiti
- [VitPose](https://huggingface.co/usyd-community/vitpose-base-simple) ile duruş tahmini
- [OneFormer](https://huggingface.co/shi-labs/oneformer_ade20k_swin_large) ile evrensel segmentasyon
- [VideoMAE](https://huggingface.co/MCG-NJU/videomae-large) ile video sınıflandırma

</details>

<details>
<summary>Çoklu-modelli</summary>

- [Qwen2-Audio](https://huggingface.co/Qwen/Qwen2-Audio-7B) ile sesten/metinden metine
- [LayoutLMv3](https://huggingface.co/microsoft/layoutlmv3-base) ile belge soru yanıtlama
- [Qwen-VL](https://huggingface.co/Qwen/Qwen2.5-VL-3B-Instruct) ile görüntü veya metinden metine
- [BLIP-2](https://huggingface.co/Salesforce/blip2-opt-2.7b) ile görüntü altyazılama
- [GOT-OCR2](https://huggingface.co/stepfun-ai/GOT-OCR-2.0-hf) ile OCR tabanlı belge anlama
- [TAPAS](https://huggingface.co/google/tapas-base) ile tablo soru yanıtlama
- [Emu3](https://huggingface.co/BAAI/Emu3-Gen) ile birleşik çoklu-modelli anlama ve üretim
- [Llava-OneVision](https://huggingface.co/llava-hf/llava-onevision-qwen2-0.5b-ov-hf) ile görselden metine
- [Llava](https://huggingface.co/llava-hf/llava-1.5-7b-hf) ile görsel soru yanıtlama
- [Kosmos-2](https://huggingface.co/microsoft/kosmos-2-patch14-224) ile görsel referanslı ifade segmentasyonu

</details>

<details>
<summary>Doğal Dil İşleme (NLP)</summary>

- [ModernBERT](https://huggingface.co/answerdotai/ModernBERT-base) ile maskeleme kelime tamamlama
- [Gemma](https://huggingface.co/google/gemma-2-2b) ile isimli varlık tanıma
- [Mixtral](https://huggingface.co/mistralai/Mixtral-8x7B-v0.1) ile soru yanıtlama
- [BART](https://huggingface.co/facebook/bart-large-cnn) ile özetleme
- [T5](https://huggingface.co/google-t5/t5-base) ile çeviri
- [Llama](https://huggingface.co/meta-llama/Llama-3.2-1B) ile metin üretimi
- [Qwen](https://huggingface.co/Qwen/Qwen2.5-0.5B) ile metin sınıflandırma

</details>

## Atıf

🤗 Transformers kütüphanesi için artık [bir makalemiz](https://www.aclweb.org/anthology/2020.emnlp-demos.6/) var, bunu kaynak gösterebilirsiniz:
```bibtex
@inproceedings{wolf-etal-2020-transformers,
    title = "Transformers: State-of-the-Art Natural Language Processing",
    author = "Thomas Wolf and Lysandre Debut and Victor Sanh and Julien Chaumond and Clement Delangue and Anthony Moi and Pierric Cistac and Tim Rault and Rémi Louf and Morgan Funtowicz and Joe Davison and Sam Shleifer and Patrick von Platen and Clara Ma and Yacine Jernite and Julien Plu and Canwen Xu and Teven Le Scao and Sylvain Gugger and Mariama Drame and Quentin Lhoest and Alexander M. Rush",
    booktitle = "Proceedings of the 2020 Conference on Empirical Methods in Natural Language Processing: System Demonstrations",
    month = oct,
    year = "2020",
    address = "Online",
    publisher = "Association for Computational Linguistics",
    url = "https://www.aclweb.org/anthology/2020.emnlp-demos.6",
    pages = "38--45"
}
```

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---