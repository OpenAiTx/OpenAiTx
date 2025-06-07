<!---
حقوق النشر 2020 فريق HuggingFace. جميع الحقوق محفوظة.

مرخص بموجب رخصة أباتشي، الإصدار 2.0 ("الرخصة")؛
لا يجوز لك استخدام هذا الملف إلا وفقًا للرخصة.
يمكنك الحصول على نسخة من الرخصة على

    http://www.apache.org/licenses/LICENSE-2.0

ما لم يقتض القانون المعمول به أو تم الاتفاق عليه كتابيًا، يتم توزيع البرنامج
تحت الرخصة على أساس "كما هو"، دون أي ضمانات أو شروط من أي نوع، سواء كانت صريحة أو ضمنية.
راجع الرخصة لمعرفة الأذونات والقيود المحددة بموجب الرخصة.
-->

<p align="center">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://huggingface.co/datasets/huggingface/documentation-images/raw/main/transformers-logo-dark.svg">
    <source media="(prefers-color-scheme: light)" srcset="https://huggingface.co/datasets/huggingface/documentation-images/raw/main/transformers-logo-light.svg">
    <img alt="مكتبة Hugging Face Transformers" src="https://huggingface.co/datasets/huggingface/documentation-images/raw/main/transformers-logo-light.svg" width="352" height="59" style="max-width: 100%;">
  </picture>
  <br/>
  <br/>
</p>

<p align="center">
    <a href="https://huggingface.com/models"><img alt="النقاط المرجعية على المركز" src="https://img.shields.io/endpoint?url=https://huggingface.co/api/shields/models&color=brightgreen"></a>
    <a href="https://circleci.com/gh/huggingface/transformers"><img alt="البناء" src="https://img.shields.io/circleci/build/github/huggingface/transformers/main"></a>
    <a href="https://github.com/huggingface/transformers/blob/main/LICENSE"><img alt="GitHub" src="https://img.shields.io/github/license/huggingface/transformers.svg?color=blue"></a>
    <a href="https://huggingface.co/docs/transformers/index"><img alt="التوثيق" src="https://img.shields.io/website/http/huggingface.co/docs/transformers/index.svg?down_color=red&down_message=offline&up_message=online"></a>
    <a href="https://github.com/huggingface/transformers/releases"><img alt="إصدار GitHub" src="https://img.shields.io/github/release/huggingface/transformers.svg"></a>
    <a href="https://github.com/huggingface/transformers/blob/main/CODE_OF_CONDUCT.md"><img alt="ميثاق المساهمين" src="https://img.shields.io/badge/Contributor%20Covenant-v2.0%20adopted-ff69b4.svg"></a>
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
    <p>نماذج مدربة مسبقًا رائدة للاستخدام والاستدلال والتدريب</p>
</h3>

<h3 align="center">
    <a href="https://hf.co/course"><img src="https://huggingface.co/datasets/huggingface/documentation-images/resolve/main/course_banner.png"></a>
</h3>

Transformers هي مكتبة للنماذج المدربة مسبقًا للنصوص، والرؤية الحاسوبية، والصوت، والفيديو، والنماذج متعددة الوسائط للاستدلال والتدريب. استخدم Transformers لضبط النماذج على بياناتك، وبناء تطبيقات الاستدلال، ولحالات استخدام الذكاء الاصطناعي التوليدي عبر وسائط متعددة.

هناك أكثر من 500 ألف [نقطة مرجعية للنماذج](https://huggingface.co/models?library=transformers&sort=trending) على [مركز Hugging Face](https://huggingface.com/models) يمكنك استخدامها.

استكشف [المركز](https://huggingface.com/) اليوم للعثور على نموذج واستخدم Transformers لمساعدتك على البدء فورًا.

## التثبيت

تعمل Transformers مع بايثون 3.9+، [PyTorch](https://pytorch.org/get-started/locally/) 2.1+، [TensorFlow](https://www.tensorflow.org/install/pip) 2.6+، و[Flax](https://flax.readthedocs.io/en/latest/) 0.4.1+.

أنشئ وفعّل بيئة افتراضية باستخدام [venv](https://docs.python.org/3/library/venv.html) أو [uv](https://docs.astral.sh/uv/)، وهو مدير مشاريع وحزم بايثون سريع مبني بلغة Rust.

```py
# venv
python -m venv .my-env
source .my-env/bin/activate
# uv
uv venv .my-env
source .my-env/bin/activate
```

قم بتثبيت Transformers في بيئتك الافتراضية.

```py
# pip
pip install "transformers[torch]"

# uv
uv pip install "transformers[torch]"
```

قم بتثبيت Transformers من المصدر إذا كنت تريد آخر التغييرات في المكتبة أو ترغب في المساهمة. مع ذلك، قد لا تكون النسخة *الأحدث* مستقرة. لا تتردد في فتح [مشكلة](https://github.com/huggingface/transformers/issues) إذا واجهت خطأ.

```shell
git clone https://github.com/huggingface/transformers.git
cd transformers

# pip
pip install .[torch]

# uv
uv pip install .[torch]
```

## البدء السريع

ابدأ مع Transformers فورًا باستخدام واجهة [Pipeline](https://huggingface.co/docs/transformers/pipeline_tutorial). الـ `Pipeline` هي صنف استدلال عالي المستوى يدعم النصوص، والصوت، والرؤية، والمهام متعددة الوسائط. يتولى معالجة الإدخال المسبق ويعيد الإخراج المناسب.

أنشئ Pipeline وحدد النموذج المراد استخدامه لتوليد النصوص. سيتم تنزيل النموذج وتخزينه مؤقتًا لتتمكن من إعادة استخدامه بسهولة. أخيرًا، مرر بعض النصوص لتحفيز النموذج.

```py
from transformers import pipeline

pipeline = pipeline(task="text-generation", model="Qwen/Qwen2.5-1.5B")
pipeline("the secret to baking a really good cake is ")
[{'generated_text': 'the secret to baking a really good cake is 1) to use the right ingredients and 2) to follow the recipe exactly. the recipe for the cake is as follows: 1 cup of sugar, 1 cup of flour, 1 cup of milk, 1 cup of butter, 1 cup of eggs, 1 cup of chocolate chips. if you want to make 2 cakes, how much sugar do you need? To make 2 cakes, you will need 2 cups of sugar.'}]
```

للدردشة مع نموذج، النمط نفسه للاستخدام. الاختلاف الوحيد هو أنك بحاجة إلى إنشاء سجل دردشة (إدخال إلى `Pipeline`) بينك وبين النظام.

> [!ملاحظة]
> يمكنك أيضًا الدردشة مع نموذج مباشرة من سطر الأوامر.
> ```shell
> transformers chat Qwen/Qwen2.5-0.5B-Instruct
> ```

```py
import torch
from transformers import pipeline

chat = [
    {"role": "system", "content": "أنت روبوت ساخر وسريع البديهة كما تخيله هوليوود عام 1986."},
    {"role": "user", "content": "مرحبًا، هل يمكنك إخباري بأي أشياء ممتعة يمكن القيام بها في نيويورك؟"}
]

pipeline = pipeline(task="text-generation", model="meta-llama/Meta-Llama-3-8B-Instruct", torch_dtype=torch.bfloat16, device_map="auto")
response = pipeline(chat, max_new_tokens=512)
print(response[0]["generated_text"][-1]["content"])
```

وسّع الأمثلة أدناه لمعرفة كيفية عمل `Pipeline` لمهام ووسائط مختلفة.

<details>
<summary>التعرف التلقائي على الكلام</summary>

```py
from transformers import pipeline

pipeline = pipeline(task="automatic-speech-recognition", model="openai/whisper-large-v3")
pipeline("https://huggingface.co/datasets/Narsil/asr_dummy/resolve/main/mlk.flac")
{'text': ' I have a dream that one day this nation will rise up and live out the true meaning of its creed.'}
```

</details>

<details>
<summary>تصنيف الصور</summary>

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
<summary>الإجابة البصرية على الأسئلة</summary>


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

## لماذا يجب أن أستخدم Transformers؟

1. نماذج رائدة سهلة الاستخدام:
    - أداء عالي في فهم وتوليد اللغة الطبيعية، والرؤية الحاسوبية، والصوت، والفيديو، والمهام متعددة الوسائط.
    - حاجز دخول منخفض للباحثين، والمهندسين، والمطورين.
    - مجرد ثلاث فئات أساسية للمستخدم للتعلم.
    - واجهة برمجة تطبيقات موحدة لاستخدام جميع النماذج المدربة مسبقًا.

2. تقليل تكاليف الحوسبة، وبصمة كربونية أصغر:
    - مشاركة النماذج المدربة بدلاً من التدريب من الصفر.
    - تقليل وقت الحوسبة وتكاليف الإنتاج.
    - عشرات من معماريات النماذج مع أكثر من مليون نقطة مرجعية مدربة مسبقًا عبر جميع الوسائط.

3. اختر الإطار المناسب لكل مرحلة من دورة حياة النموذج:
    - تدريب نماذج رائدة في 3 أسطر برمجية.
    - نقل نموذج واحد بين أطر PyTorch/JAX/TF2.0 بحرية.
    - اختيار الإطار المناسب للتدريب، التقييم، والإنتاج.

4. تخصيص النموذج أو المثال بسهولة وفقًا لاحتياجاتك:
    - نوفر أمثلة لكل معمارية لإعادة إنتاج النتائج المنشورة من قبل مؤلفيها الأصليين.
    - المكونات الداخلية للنموذج مكشوفة قدر الإمكان بشكل متسق.
    - يمكن استخدام ملفات النموذج بشكل مستقل عن المكتبة لتجارب سريعة.

<a target="_blank" href="https://huggingface.co/enterprise">
    <img alt="مركز Hugging Face Enterprise" src="https://github.com/user-attachments/assets/247fb16d-d251-4583-96c4-d3d76dda4925">
</a><br>

## لماذا قد لا أستخدم Transformers؟

- هذه المكتبة ليست صندوق أدوات معياري لبناء الشبكات العصبية. لم يتم إعادة هيكلة كود ملفات النماذج مع تجريدات إضافية عن قصد، حتى يتمكن الباحثون من التكرار بسرعة على كل نموذج دون الغوص في ملفات وتجريدات إضافية.
- تم تحسين واجهة برمجة تطبيقات التدريب للعمل مع نماذج PyTorch المقدمة من Transformers. للحلقات العامة لتعلم الآلة، عليك استخدام مكتبة أخرى مثل [Accelerate](https://huggingface.co/docs/accelerate).
- [سكريبتات الأمثلة](https://github.com/huggingface/transformers/tree/main/examples) هي فقط *أمثلة*. قد لا تعمل مباشرة على حالتك الخاصة، وستحتاج إلى تكييف الكود ليناسبها.

## 100 مشروع يستخدم Transformers

Transformers هي أكثر من مجرد مجموعة أدوات لاستخدام النماذج المدربة مسبقًا، إنها مجتمع من المشاريع المبنية حولها وحول مركز Hugging Face. نريد من Transformers أن تمكّن المطورين، الباحثين، الطلاب، الأساتذة، المهندسين، وأي شخص آخر من بناء مشاريع أحلامهم.

احتفالًا بوصول Transformers إلى 100,000 نجمة، أردنا تسليط الضوء على المجتمع من خلال صفحة [awesome-transformers](./awesome-transformers.md) التي تسرد 100 مشروع مذهل تم بناؤها باستخدام Transformers.

إذا كنت تملك أو تستخدم مشروعًا تعتقد أنه يجب أن يكون ضمن القائمة، يرجى فتح PR لإضافته!

## أمثلة للنماذج

يمكنك اختبار معظم نماذجنا مباشرة على صفحات النماذج في [المركز](https://huggingface.co/models).

وسّع كل وسيلة أدناه لرؤية بعض أمثلة النماذج لحالات استخدام متنوعة.

<details>
<summary>الصوتيات</summary>

- تصنيف الصوت باستخدام [Whisper](https://huggingface.co/openai/whisper-large-v3-turbo)
- التعرف التلقائي على الكلام باستخدام [Moonshine](https://huggingface.co/UsefulSensors/moonshine)
- اكتشاف الكلمات المفتاحية باستخدام [Wav2Vec2](https://huggingface.co/superb/wav2vec2-base-superb-ks)
- تحويل الكلام إلى كلام باستخدام [Moshi](https://huggingface.co/kyutai/moshiko-pytorch-bf16)
- تحويل النص إلى صوت باستخدام [MusicGen](https://huggingface.co/facebook/musicgen-large)
- تحويل النص إلى كلام باستخدام [Bark](https://huggingface.co/suno/bark)

</details>

<details>
<summary>الرؤية الحاسوبية</summary>

- التوليد التلقائي للأقنعة باستخدام [SAM](https://huggingface.co/facebook/sam-vit-base)
- تقدير العمق باستخدام [DepthPro](https://huggingface.co/apple/DepthPro-hf)
- تصنيف الصور باستخدام [DINO v2](https://huggingface.co/facebook/dinov2-base)
- اكتشاف نقاط المفتاح باستخدام [SuperGlue](https://huggingface.co/magic-leap-community/superglue_outdoor)
- مطابقة نقاط المفتاح باستخدام [SuperGlue](https://huggingface.co/magic-leap-community/superglue)
- اكتشاف الكائنات باستخدام [RT-DETRv2](https://huggingface.co/PekingU/rtdetr_v2_r50vd)
- تقدير الوضعية باستخدام [VitPose](https://huggingface.co/usyd-community/vitpose-base-simple)
- التقسيم الشامل باستخدام [OneFormer](https://huggingface.co/shi-labs/oneformer_ade20k_swin_large)
- تصنيف الفيديو باستخدام [VideoMAE](https://huggingface.co/MCG-NJU/videomae-large)

</details>

<details>
<summary>متعدد الوسائط</summary>

- الصوت أو النص إلى نص باستخدام [Qwen2-Audio](https://huggingface.co/Qwen/Qwen2-Audio-7B)
- الإجابة على الأسئلة من المستندات باستخدام [LayoutLMv3](https://huggingface.co/microsoft/layoutlmv3-base)
- الصورة أو النص إلى نص باستخدام [Qwen-VL](https://huggingface.co/Qwen/Qwen2.5-VL-3B-Instruct)
- توصيف الصور باستخدام [BLIP-2](https://huggingface.co/Salesforce/blip2-opt-2.7b)
- فهم المستندات المعتمدة على OCR باستخدام [GOT-OCR2](https://huggingface.co/stepfun-ai/GOT-OCR-2.0-hf)
- الإجابة على أسئلة الجداول باستخدام [TAPAS](https://huggingface.co/google/tapas-base)
- الفهم والتوليد الشامل متعدد الوسائط باستخدام [Emu3](https://huggingface.co/BAAI/Emu3-Gen)
- الرؤية إلى نص باستخدام [Llava-OneVision](https://huggingface.co/llava-hf/llava-onevision-qwen2-0.5b-ov-hf)
- الإجابة البصرية على الأسئلة باستخدام [Llava](https://huggingface.co/llava-hf/llava-1.5-7b-hf)
- تقسيم التعبيرات البصرية المرجعية باستخدام [Kosmos-2](https://huggingface.co/microsoft/kosmos-2-patch14-224)

</details>

<details>
<summary>معالجة اللغة الطبيعية</summary>

- إكمال الكلمات المقنعة باستخدام [ModernBERT](https://huggingface.co/answerdotai/ModernBERT-base)
- التعرف على الكيانات المسماة باستخدام [Gemma](https://huggingface.co/google/gemma-2-2b)
- الإجابة على الأسئلة باستخدام [Mixtral](https://huggingface.co/mistralai/Mixtral-8x7B-v0.1)
- التلخيص باستخدام [BART](https://huggingface.co/facebook/bart-large-cnn)
- الترجمة باستخدام [T5](https://huggingface.co/google-t5/t5-base)
- توليد النص باستخدام [Llama](https://huggingface.co/meta-llama/Llama-3.2-1B)
- تصنيف النص باستخدام [Qwen](https://huggingface.co/Qwen/Qwen2.5-0.5B)

</details>

## الاستشهاد

لدينا الآن [ورقة بحثية](https://www.aclweb.org/anthology/2020.emnlp-demos.6/) يمكنك الاستشهاد بها لمكتبة 🤗 Transformers:
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