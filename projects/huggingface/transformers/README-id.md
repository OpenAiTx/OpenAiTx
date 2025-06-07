<!---
Copyright 2020 The HuggingFace Team. All rights reserved.

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
-->

<p align="center">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://huggingface.co/datasets/huggingface/documentation-images/raw/main/transformers-logo-dark.svg">
    <source media="(prefers-color-scheme: light)" srcset="https://huggingface.co/datasets/huggingface/documentation-images/raw/main/transformers-logo-light.svg">
    <img alt="Hugging Face Transformers Library" src="https://huggingface.co/datasets/huggingface/documentation-images/raw/main/transformers-logo-light.svg" width="352" height="59" style="max-width: 100%;">
  </picture>
  <br/>
  <br/>
</p>

<p align="center">
    <a href="https://huggingface.com/models"><img alt="Checkpoints on Hub" src="https://img.shields.io/endpoint?url=https://huggingface.co/api/shields/models&color=brightgreen"></a>
    <a href="https://circleci.com/gh/huggingface/transformers"><img alt="Build" src="https://img.shields.io/circleci/build/github/huggingface/transformers/main"></a>
    <a href="https://github.com/huggingface/transformers/blob/main/LICENSE"><img alt="GitHub" src="https://img.shields.io/github/license/huggingface/transformers.svg?color=blue"></a>
    <a href="https://huggingface.co/docs/transformers/index"><img alt="Documentation" src="https://img.shields.io/website/http/huggingface.co/docs/transformers/index.svg?down_color=red&down_message=offline&up_message=online"></a>
    <a href="https://github.com/huggingface/transformers/releases"><img alt="GitHub release" src="https://img.shields.io/github/release/huggingface/transformers.svg"></a>
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
    <p>Model pralatih mutakhir untuk inferensi dan pelatihan</p>
</h3>

<h3 align="center">
    <a href="https://hf.co/course"><img src="https://huggingface.co/datasets/huggingface/documentation-images/resolve/main/course_banner.png"></a>
</h3>

Transformers adalah pustaka model pralatih untuk teks, computer vision, audio, video, dan multimodal untuk inferensi dan pelatihan. Gunakan Transformers untuk fine-tuning model pada data Anda, membangun aplikasi inferensi, dan untuk berbagai kasus penggunaan AI generatif di banyak modalitas.

Terdapat lebih dari 500K+ [checkpoint model Transformers](https://huggingface.co/models?library=transformers&sort=trending) di [Hugging Face Hub](https://huggingface.com/models) yang dapat Anda gunakan.

Jelajahi [Hub](https://huggingface.com/) hari ini untuk menemukan model dan gunakan Transformers agar Anda dapat langsung memulai.

## Instalasi

Transformers bekerja dengan Python 3.9+, [PyTorch](https://pytorch.org/get-started/locally/) 2.1+, [TensorFlow](https://www.tensorflow.org/install/pip) 2.6+, dan [Flax](https://flax.readthedocs.io/en/latest/) 0.4.1+.

Buat dan aktifkan lingkungan virtual dengan [venv](https://docs.python.org/3/library/venv.html) atau [uv](https://docs.astral.sh/uv/), sebuah manajer paket dan proyek Python berbasis Rust yang cepat.

```py
# venv
python -m venv .my-env
source .my-env/bin/activate
# uv
uv venv .my-env
source .my-env/bin/activate
```

Instal Transformers di lingkungan virtual Anda.

```py
# pip
pip install "transformers[torch]"

# uv
uv pip install "transformers[torch]"
```

Instal Transformers dari sumber jika Anda menginginkan perubahan terbaru di pustaka atau tertarik untuk berkontribusi. Namun, versi *terbaru* mungkin tidak stabil. Silakan buka [issue](https://github.com/huggingface/transformers/issues) jika Anda menemukan error.

```shell
git clone https://github.com/huggingface/transformers.git
cd transformers

# pip
pip install .[torch]

# uv
uv pip install .[torch]
```

## Quickstart

Mulai dengan Transformers secara langsung menggunakan API [Pipeline](https://huggingface.co/docs/transformers/pipeline_tutorial). `Pipeline` adalah kelas inferensi tingkat tinggi yang mendukung tugas teks, audio, vision, dan multimodal. Pipeline menangani pra-pemrosesan input dan mengembalikan output yang sesuai.

Inisialisasi pipeline dan tentukan model yang digunakan untuk text generation. Model akan diunduh dan disimpan di cache sehingga Anda bisa menggunakannya kembali dengan mudah. Terakhir, masukkan teks untuk memicu model.

```py
from transformers import pipeline

pipeline = pipeline(task="text-generation", model="Qwen/Qwen2.5-1.5B")
pipeline("the secret to baking a really good cake is ")
[{'generated_text': 'the secret to baking a really good cake is 1) to use the right ingredients and 2) to follow the recipe exactly. the recipe for the cake is as follows: 1 cup of sugar, 1 cup of flour, 1 cup of milk, 1 cup of butter, 1 cup of eggs, 1 cup of chocolate chips. if you want to make 2 cakes, how much sugar do you need? To make 2 cakes, you will need 2 cups of sugar.'}]
```

Untuk bercakap-cakap dengan model, pola penggunaannya sama. Perbedaannya hanyalah Anda perlu membangun riwayat percakapan (input untuk `Pipeline`) antara Anda dan sistem.

> [!TIP]
> Anda juga bisa bercakap-cakap dengan model langsung dari command line.
> ```shell
> transformers chat Qwen/Qwen2.5-0.5B-Instruct
> ```

```py
import torch
from transformers import pipeline

chat = [
    {"role": "system", "content": "Anda adalah robot sarkastik dan suka bercanda seperti yang dibayangkan Hollywood tahun 1986."},
    {"role": "user", "content": "Hei, bisakah kamu memberitahu saya hal-hal seru yang bisa dilakukan di New York?"}
]

pipeline = pipeline(task="text-generation", model="meta-llama/Meta-Llama-3-8B-Instruct", torch_dtype=torch.bfloat16, device_map="auto")
response = pipeline(chat, max_new_tokens=512)
print(response[0]["generated_text"][-1]["content"])
```

Ekspand contoh di bawah ini untuk melihat bagaimana `Pipeline` bekerja pada berbagai modalitas dan tugas.

<details>
<summary>Pengenalan ucapan otomatis</summary>

```py
from transformers import pipeline

pipeline = pipeline(task="automatic-speech-recognition", model="openai/whisper-large-v3")
pipeline("https://huggingface.co/datasets/Narsil/asr_dummy/resolve/main/mlk.flac")
{'text': ' I have a dream that one day this nation will rise up and live out the true meaning of its creed.'}
```

</details>

<details>
<summary>Klasifikasi gambar</summary>

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
<summary>Visual question answering</summary>


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

## Mengapa saya harus menggunakan Transformers?

1. Model mutakhir yang mudah digunakan:
    - Kinerja tinggi pada pemahaman & generasi bahasa alami, computer vision, audio, video, dan tugas multimodal.
    - Hambatan masuk rendah bagi peneliti, engineer, dan developer.
    - Hanya sedikit abstraksi yang harus dipelajari, cukup tiga kelas utama.
    - API terpadu untuk semua model pralatih yang kami sediakan.

1. Mengurangi biaya komputasi, jejak karbon lebih kecil:
    - Bagikan model yang sudah dilatih daripada melatih dari awal.
    - Kurangi waktu komputasi dan biaya produksi.
    - Puluhan arsitektur model dengan 1M+ checkpoint pralatih di semua modalitas.

1. Pilih kerangka kerja yang tepat untuk setiap tahap siklus hidup model:
    - Latih model mutakhir hanya dengan 3 baris kode.
    - Pindahkan satu model antara kerangka PyTorch/JAX/TF2.0 dengan mudah.
    - Pilih kerangka kerja yang sesuai untuk pelatihan, evaluasi, dan produksi.

1. Mudah menyesuaikan model atau contoh dengan kebutuhan Anda:
    - Kami menyediakan contoh untuk setiap arsitektur agar hasil penelitian asli bisa direproduksi.
    - Internal model diekspos secara konsisten.
    - File model bisa digunakan secara independen dari pustaka untuk eksperimen cepat.

<a target="_blank" href="https://huggingface.co/enterprise">
    <img alt="Hugging Face Enterprise Hub" src="https://github.com/user-attachments/assets/247fb16d-d251-4583-96c4-d3d76dda4925">
</a><br>

## Mengapa saya tidak harus menggunakan Transformers?

- Pustaka ini bukan toolbox modular untuk membangun neural net. Kode dalam file model memang tidak direfaktor dengan abstraksi tambahan, agar peneliti bisa cepat berinovasi pada masing-masing model tanpa harus mempelajari abstraksi/file tambahan.
- API pelatihan dioptimalkan untuk bekerja dengan model PyTorch yang disediakan oleh Transformers. Untuk loop machine learning generik, Anda sebaiknya menggunakan pustaka lain seperti [Accelerate](https://huggingface.co/docs/accelerate).
- [Script contoh]((https://github.com/huggingface/transformers/tree/main/examples)) hanya *contoh*. Mungkin tidak bekerja langsung untuk kasus Anda dan Anda harus menyesuaikan kode agar sesuai.

## 100 proyek menggunakan Transformers

Transformers lebih dari sekadar toolkit untuk model pralatih, ini adalah komunitas proyek yang dibangun di sekitarnya dan Hugging Face Hub. Kami ingin Transformers memberdayakan developer, peneliti, mahasiswa, dosen, engineer, dan siapa pun untuk membangun proyek impian mereka.

Untuk merayakan Transformers 100.000 bintang, kami ingin menyoroti komunitas melalui halaman [awesome-transformers](./awesome-transformers.md) yang mencantumkan 100 proyek luar biasa yang dibangun dengan Transformers.

Jika Anda memiliki atau menggunakan proyek yang menurut Anda layak masuk dalam daftar, silakan ajukan PR untuk menambahkannya!

## Contoh model

Anda dapat mencoba sebagian besar model kami langsung di [halaman model Hub](https://huggingface.co/models).

Ekspand setiap modalitas di bawah ini untuk melihat beberapa contoh model untuk berbagai kasus penggunaan.

<details>
<summary>Audio</summary>

- Klasifikasi audio dengan [Whisper](https://huggingface.co/openai/whisper-large-v3-turbo)
- Pengenalan ucapan otomatis dengan [Moonshine](https://huggingface.co/UsefulSensors/moonshine)
- Keyword spotting dengan [Wav2Vec2](https://huggingface.co/superb/wav2vec2-base-superb-ks)
- Speech to speech generation dengan [Moshi](https://huggingface.co/kyutai/moshiko-pytorch-bf16)
- Teks ke audio dengan [MusicGen](https://huggingface.co/facebook/musicgen-large)
- Teks ke suara dengan [Bark](https://huggingface.co/suno/bark)

</details>

<details>
<summary>Computer vision</summary>

- Pembentukan mask otomatis dengan [SAM](https://huggingface.co/facebook/sam-vit-base)
- Estimasi kedalaman dengan [DepthPro](https://huggingface.co/apple/DepthPro-hf)
- Klasifikasi gambar dengan [DINO v2](https://huggingface.co/facebook/dinov2-base)
- Deteksi keypoint dengan [SuperGlue](https://huggingface.co/magic-leap-community/superglue_outdoor)
- Keypoint matching dengan [SuperGlue](https://huggingface.co/magic-leap-community/superglue)
- Deteksi objek dengan [RT-DETRv2](https://huggingface.co/PekingU/rtdetr_v2_r50vd)
- Estimasi pose dengan [VitPose](https://huggingface.co/usyd-community/vitpose-base-simple)
- Segmentasi universal dengan [OneFormer](https://huggingface.co/shi-labs/oneformer_ade20k_swin_large)
- Klasifikasi video dengan [VideoMAE](https://huggingface.co/MCG-NJU/videomae-large)

</details>

<details>
<summary>Multimodal</summary>

- Audio atau teks ke teks dengan [Qwen2-Audio](https://huggingface.co/Qwen/Qwen2-Audio-7B)
- Document question answering dengan [LayoutLMv3](https://huggingface.co/microsoft/layoutlmv3-base)
- Gambar atau teks ke teks dengan [Qwen-VL](https://huggingface.co/Qwen/Qwen2.5-VL-3B-Instruct)
- Image captioning [BLIP-2](https://huggingface.co/Salesforce/blip2-opt-2.7b)
- Pemahaman dokumen berbasis OCR dengan [GOT-OCR2](https://huggingface.co/stepfun-ai/GOT-OCR-2.0-hf)
- Table question answering dengan [TAPAS](https://huggingface.co/google/tapas-base)
- Pemahaman dan generasi multimodal terpadu dengan [Emu3](https://huggingface.co/BAAI/Emu3-Gen)
- Vision ke teks dengan [Llava-OneVision](https://huggingface.co/llava-hf/llava-onevision-qwen2-0.5b-ov-hf)
- Visual question answering dengan [Llava](https://huggingface.co/llava-hf/llava-1.5-7b-hf)
- Segmentasi ekspresi rujukan visual dengan [Kosmos-2](https://huggingface.co/microsoft/kosmos-2-patch14-224)

</details>

<details>
<summary>NLP</summary>

- Penyelesaian kata tersembunyi dengan [ModernBERT](https://huggingface.co/answerdotai/ModernBERT-base)
- Named entity recognition dengan [Gemma](https://huggingface.co/google/gemma-2-2b)
- Question answering dengan [Mixtral](https://huggingface.co/mistralai/Mixtral-8x7B-v0.1)
- Ringkasan dengan [BART](https://huggingface.co/facebook/bart-large-cnn)
- Translasi dengan [T5](https://huggingface.co/google-t5/t5-base)
- Generasi teks dengan [Llama](https://huggingface.co/meta-llama/Llama-3.2-1B)
- Klasifikasi teks dengan [Qwen](https://huggingface.co/Qwen/Qwen2.5-0.5B)

</details>

## Sitasi

Kami kini memiliki [makalah](https://www.aclweb.org/anthology/2020.emnlp-demos.6/) yang dapat Anda kutip untuk pustaka 🤗 Transformers:
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