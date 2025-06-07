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
    <p>इन्फरेंस और ट्रेनिंग के लिए अत्याधुनिक प्रीट्रेंड मॉडल</p>
</h3>

<h3 align="center">
    <a href="https://hf.co/course"><img src="https://huggingface.co/datasets/huggingface/documentation-images/resolve/main/course_banner.png"></a>
</h3>

Transformers एक प्रीट्रेंड टेक्स्ट, कंप्यूटर विज़न, ऑडियो, वीडियो, और मल्टीमोडल मॉडल्स की लाइब्रेरी है, जिसका उपयोग इन्फरेंस और ट्रेनिंग के लिए किया जाता है। Transformers का उपयोग अपने डेटा पर मॉडल्स को फाइन-ट्यून करने, इन्फरेंस एप्लिकेशन बनाने, और मल्टीपल मोडैलिटी में जनरेटिव एआई उपयोग मामलों के लिए करें।

[Hugging Face Hub](https://huggingface.com/models) पर 500K+ से अधिक Transformers [मॉडल चेकपॉइंट्स](https://huggingface.co/models?library=transformers&sort=trending) उपलब्ध हैं, जिनका आप उपयोग कर सकते हैं।

आज ही [Hub](https://huggingface.com/) को एक्सप्लोर करें, कोई मॉडल खोजें और Transformers का उपयोग करके तुरंत शुरुआत करें।

## इंस्टॉलेशन

Transformers, Python 3.9+ [PyTorch](https://pytorch.org/get-started/locally/) 2.1+, [TensorFlow](https://www.tensorflow.org/install/pip) 2.6+, और [Flax](https://flax.readthedocs.io/en/latest/) 0.4.1+ के साथ काम करता है।

[venv](https://docs.python.org/3/library/venv.html) या [uv](https://docs.astral.sh/uv/) (एक तेज़ Rust-आधारित Python पैकेज और प्रोजेक्ट मैनेजर) से एक वर्चुअल एनवायरनमेंट बनाएँ और सक्रिय करें।

```py
# venv
python -m venv .my-env
source .my-env/bin/activate
# uv
uv venv .my-env
source .my-env/bin/activate
```

अपने वर्चुअल एनवायरनमेंट में Transformers इंस्टॉल करें।

```py
# pip
pip install "transformers[torch]"

# uv
uv pip install "transformers[torch]"
```

यदि आप लाइब्रेरी में नवीनतम बदलाव चाहते हैं या योगदान देने में रुचि रखते हैं तो स्रोत से Transformers इंस्टॉल करें। हालाँकि, *नवीनतम* संस्करण स्थिर नहीं हो सकता है। यदि आपको कोई त्रुटि मिलती है तो बेझिझक [issue](https://github.com/huggingface/transformers/issues) खोलें।

```shell
git clone https://github.com/huggingface/transformers.git
cd transformers

# pip
pip install .[torch]

# uv
uv pip install .[torch]
```

## क्विकस्टार्ट

[Pipeline](https://huggingface.co/docs/transformers/pipeline_tutorial) API के साथ तुरंत Transformers का उपयोग शुरू करें। `Pipeline` एक उच्च स्तरीय इन्फरेंस क्लास है जो टेक्स्ट, ऑडियो, विज़न, और मल्टीमोडल टास्क्स को सपोर्ट करती है। यह इनपुट का प्रीप्रोसेसिंग संभालता है और उचित आउटपुट लौटाता है।

पाइपलाइन इंस्टैंसिएट करें और टेक्स्ट जनरेशन के लिए उपयोग होने वाला मॉडल स्पेसिफाई करें। मॉडल डाउनलोड और कैश हो जाता है ताकि आप इसे आसानी से फिर से उपयोग कर सकें। अंत में, मॉडल को प्रॉम्प्ट करने के लिए कुछ टेक्स्ट पास करें।

```py
from transformers import pipeline

pipeline = pipeline(task="text-generation", model="Qwen/Qwen2.5-1.5B")
pipeline("the secret to baking a really good cake is ")
[{'generated_text': 'the secret to baking a really good cake is 1) to use the right ingredients and 2) to follow the recipe exactly. the recipe for the cake is as follows: 1 cup of sugar, 1 cup of flour, 1 cup of milk, 1 cup of butter, 1 cup of eggs, 1 cup of chocolate chips. if you want to make 2 cakes, how much sugar do you need? To make 2 cakes, you will need 2 cups of sugar.'}]
```

किसी मॉडल के साथ चैट करने के लिए, उपयोग पैटर्न वही है। फर्क सिर्फ इतना है कि आपको अपने और सिस्टम के बीच एक चैट हिस्ट्री (जो `Pipeline` को इनपुट दी जाती है) बनानी होगी।

> [!TIP]
> आप कमांड लाइन से भी सीधे किसी मॉडल के साथ चैट कर सकते हैं।
> ```shell
> transformers chat Qwen/Qwen2.5-0.5B-Instruct
> ```

```py
import torch
from transformers import pipeline

chat = [
    {"role": "system", "content": "You are a sassy, wise-cracking robot as imagined by Hollywood circa 1986."},
    {"role": "user", "content": "Hey, can you tell me any fun things to do in New York?"}
]

pipeline = pipeline(task="text-generation", model="meta-llama/Meta-Llama-3-8B-Instruct", torch_dtype=torch.bfloat16, device_map="auto")
response = pipeline(chat, max_new_tokens=512)
print(response[0]["generated_text"][-1]["content"])
```

नीचे दिए गए उदाहरणों का विस्तार करें यह देखने के लिए कि `Pipeline` विभिन्न मोडैलिटी और कार्यों के लिए कैसे काम करता है।

<details>
<summary>स्वचालित स्पीच रिकग्निशन</summary>

```py
from transformers import pipeline

pipeline = pipeline(task="automatic-speech-recognition", model="openai/whisper-large-v3")
pipeline("https://huggingface.co/datasets/Narsil/asr_dummy/resolve/main/mlk.flac")
{'text': ' I have a dream that one day this nation will rise up and live out the true meaning of its creed.'}
```

</details>

<details>
<summary>इमेज क्लासिफिकेशन</summary>

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
<summary>विज़ुअल क्वेश्चन आंसरिंग</summary>


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

## मुझे Transformers का उपयोग क्यों करना चाहिए?

1. उपयोग में आसान अत्याधुनिक मॉडल्स:
    - नेचुरल लैंग्वेज अंडरस्टैंडिंग और जनरेशन, कंप्यूटर विज़न, ऑडियो, वीडियो, और मल्टीमोडल टास्क्स में उच्च प्रदर्शन।
    - शोधकर्ताओं, इंजीनियरों और डेवलपर्स के लिए कम बाधाएं।
    - केवल तीन क्लासेस के साथ कम यूज़र-फेसिंग एब्स्ट्रैक्शन्स।
    - हमारे सभी प्रीट्रेंड मॉडल्स के लिए एकीकृत API।

1. कम कंप्यूट लागत, छोटा कार्बन फुटप्रिंट:
    - शुरुआत से ट्रेनिंग करने के बजाय ट्रेंड मॉडल्स साझा करें।
    - कंप्यूट समय और प्रोडक्शन लागत कम करें।
    - सभी मोडैलिटी में 1M+ प्रीट्रेंड चेकपॉइंट्स के साथ दर्जनों मॉडल आर्किटेक्चर।

1. मॉडल के जीवनकाल के हर हिस्से के लिए सही फ्रेमवर्क चुनें:
    - 3 लाइनों के कोड में अत्याधुनिक मॉडल्स को ट्रेन करें।
    - एक ही मॉडल को PyTorch/JAX/TF2.0 फ्रेमवर्क्स के बीच इच्छानुसार मूव करें।
    - ट्रेनिंग, मूल्यांकन और उत्पादन के लिए सही फ्रेमवर्क चुनें।

1. आसानी से किसी मॉडल या उदाहरण को अपनी आवश्यकता के अनुसार अनुकूलित करें:
    - हम प्रत्येक आर्किटेक्चर के लिए ऐसे उदाहरण प्रदान करते हैं, जिससे आप मूल लेखकों द्वारा प्रकाशित परिणामों को पुन: उत्पन्न कर सकें।
    - मॉडल इंटरनल्स को यथासंभव सुसंगत रूप से एक्सपोज़ किया गया है।
    - त्वरित प्रयोगों के लिए मॉडल फाइल्स को लाइब्रेरी से स्वतंत्र रूप से उपयोग किया जा सकता है।

<a target="_blank" href="https://huggingface.co/enterprise">
    <img alt="Hugging Face Enterprise Hub" src="https://github.com/user-attachments/assets/247fb16d-d251-4583-96c4-d3d76dda4925">
</a><br>

## मुझे Transformers का उपयोग क्यों नहीं करना चाहिए?

- यह लाइब्रेरी न्यूरल नेट्स के लिए बिल्डिंग ब्लॉक्स का एक मॉड्यूलर टूलबॉक्स नहीं है। मॉडल फाइल्स में कोड को जानबूझकर अतिरिक्त एब्स्ट्रैक्शन्स के साथ रिफैक्टर नहीं किया गया है, ताकि शोधकर्ता प्रत्येक मॉडल पर जल्दी से काम कर सकें।
- ट्रेनिंग API को विशेष रूप से Transformers द्वारा प्रदान किए गए PyTorch मॉडल्स के साथ काम करने के लिए ऑप्टिमाइज़ किया गया है। सामान्य मशीन लर्निंग लूप्स के लिए, आपको [Accelerate](https://huggingface.co/docs/accelerate) जैसी अन्य लाइब्रेरी का उपयोग करना चाहिए।
- [उदाहरण स्क्रिप्ट्स]((https://github.com/huggingface/transformers/tree/main/examples)) केवल *उदाहरण* हैं। वे जरूरी नहीं कि आपके विशिष्ट उपयोग मामले पर तुरंत काम करें, और आपको इसे काम करने के लिए कोड को अनुकूलित करना होगा।

## Transformers का उपयोग करने वाले 100 प्रोजेक्ट्स

Transformers केवल प्रीट्रेंड मॉडल्स का टूलकिट नहीं है, बल्कि यह इसके चारों ओर बने प्रोजेक्ट्स और Hugging Face Hub की एक कम्युनिटी है। हम चाहते हैं कि Transformers डेवलपर्स, शोधकर्ताओं, छात्रों, प्रोफेसरों, इंजीनियरों और अन्य सभी को उनके ड्रीम प्रोजेक्ट्स बनाने में सक्षम बनाए।

Transformers के 100,000 स्टार्स सेलिब्रेट करने के लिए, हम कम्युनिटी के [awesome-transformers](./awesome-transformers.md) पेज पर बने 100 अद्भुत प्रोजेक्ट्स को उजागर करना चाहते हैं।

यदि आप किसी ऐसे प्रोजेक्ट के मालिक हैं या उपयोग करते हैं, जिसे आपको लगता है कि इस सूची का हिस्सा होना चाहिए, तो कृपया इसे जोड़ने के लिए PR खोलें!

## उदाहरण मॉडल्स

आप हमारे अधिकांश मॉडल्स को सीधे उनके [Hub मॉडल पेजेज़](https://huggingface.co/models) पर टेस्ट कर सकते हैं।

नीचे प्रत्येक मोडैलिटी का विस्तार करें और विभिन्न उपयोग मामलों के लिए कुछ उदाहरण मॉडल्स देखें।

<details>
<summary>ऑडियो</summary>

- [Whisper](https://huggingface.co/openai/whisper-large-v3-turbo) के साथ ऑडियो क्लासिफिकेशन
- [Moonshine](https://huggingface.co/UsefulSensors/moonshine) के साथ स्वचालित स्पीच रिकग्निशन
- [Wav2Vec2](https://huggingface.co/superb/wav2vec2-base-superb-ks) के साथ कीवर्ड स्पॉटिंग
- [Moshi](https://huggingface.co/kyutai/moshiko-pytorch-bf16) के साथ स्पीच टू स्पीच जनरेशन
- [MusicGen](https://huggingface.co/facebook/musicgen-large) के साथ टेक्स्ट टू ऑडियो
- [Bark](https://huggingface.co/suno/bark) के साथ टेक्स्ट टू स्पीच

</details>

<details>
<summary>कंप्यूटर विज़न</summary>

- [SAM](https://huggingface.co/facebook/sam-vit-base) के साथ स्वचालित मास्क जनरेशन
- [DepthPro](https://huggingface.co/apple/DepthPro-hf) के साथ डेप्थ एस्टीमेशन
- [DINO v2](https://huggingface.co/facebook/dinov2-base) के साथ इमेज क्लासिफिकेशन
- [SuperGlue](https://huggingface.co/magic-leap-community/superglue_outdoor) के साथ कीपॉइंट डिटेक्शन
- [SuperGlue](https://huggingface.co/magic-leap-community/superglue) के साथ कीपॉइंट मैचिंग
- [RT-DETRv2](https://huggingface.co/PekingU/rtdetr_v2_r50vd) के साथ ऑब्जेक्ट डिटेक्शन
- [VitPose](https://huggingface.co/usyd-community/vitpose-base-simple) के साथ पोज़ एस्टीमेशन
- [OneFormer](https://huggingface.co/shi-labs/oneformer_ade20k_swin_large) के साथ यूनिवर्सल सेगमेंटेशन
- [VideoMAE](https://huggingface.co/MCG-NJU/videomae-large) के साथ वीडियो क्लासिफिकेशन

</details>

<details>
<summary>मल्टीमोडल</summary>

- [Qwen2-Audio](https://huggingface.co/Qwen/Qwen2-Audio-7B) के साथ ऑडियो या टेक्स्ट टू टेक्स्ट
- [LayoutLMv3](https://huggingface.co/microsoft/layoutlmv3-base) के साथ डॉक्युमेंट क्वेश्चन आंसरिंग
- [Qwen-VL](https://huggingface.co/Qwen/Qwen2.5-VL-3B-Instruct) के साथ इमेज या टेक्स्ट टू टेक्स्ट
- [BLIP-2](https://huggingface.co/Salesforce/blip2-opt-2.7b) के साथ इमेज कैप्शनिंग
- [GOT-OCR2](https://huggingface.co/stepfun-ai/GOT-OCR-2.0-hf) के साथ OCR-आधारित डॉक्युमेंट समझ
- [TAPAS](https://huggingface.co/google/tapas-base) के साथ टेबल क्वेश्चन आंसरिंग
- [Emu3](https://huggingface.co/BAAI/Emu3-Gen) के साथ एकीकृत मल्टीमोडल समझ और जनरेशन
- [Llava-OneVision](https://huggingface.co/llava-hf/llava-onevision-qwen2-0.5b-ov-hf) के साथ विज़न टू टेक्स्ट
- [Llava](https://huggingface.co/llava-hf/llava-1.5-7b-hf) के साथ विज़ुअल क्वेश्चन आंसरिंग
- [Kosmos-2](https://huggingface.co/microsoft/kosmos-2-patch14-224) के साथ विज़ुअल रेफरिंग एक्सप्रेशन सेगमेंटेशन

</details>

<details>
<summary>NLP</summary>

- [ModernBERT](https://huggingface.co/answerdotai/ModernBERT-base) के साथ मास्क्ड वर्ड कंप्लीशन
- [Gemma](https://huggingface.co/google/gemma-2-2b) के साथ नामित इकाई पहचान
- [Mixtral](https://huggingface.co/mistralai/Mixtral-8x7B-v0.1) के साथ क्वेश्चन आंसरिंग
- [BART](https://huggingface.co/facebook/bart-large-cnn) के साथ समरीकरण
- [T5](https://huggingface.co/google-t5/t5-base) के साथ अनुवाद
- [Llama](https://huggingface.co/meta-llama/Llama-3.2-1B) के साथ टेक्स्ट जनरेशन
- [Qwen](https://huggingface.co/Qwen/Qwen2.5-0.5B) के साथ टेक्स्ट क्लासिफिकेशन

</details>

## संदर्भ

अब हमारे पास 🤗 Transformers लाइब्रेरी के लिए एक [पेपर](https://www.aclweb.org/anthology/2020.emnlp-demos.6/) है, जिसे आप संदर्भित कर सकते हैं:
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