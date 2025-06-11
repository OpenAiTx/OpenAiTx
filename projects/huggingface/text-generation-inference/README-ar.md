<div align="center">

<a href="https://www.youtube.com/watch?v=jlMAX2Oaht0">
  <img width=560 alt="Making TGI deployment optimal" src="https://raw.githubusercontent.com/huggingface/text-generation-inference/main/datasets/Narsil/tgi_assets/resolve/main/thumbnail.png">
</a>

# استدلال توليد النصوص

<a href="https://github.com/huggingface/text-generation-inference">
  <img alt="GitHub Repo stars" src="https://img.shields.io/github/stars/huggingface/text-generation-inference?style=social">
</a>
<a href="https://huggingface.github.io/text-generation-inference">
  <img alt="Swagger API documentation" src="https://img.shields.io/badge/API-Swagger-informational">
</a>

خادم بلغة Rust و Python و gRPC لاستدلال توليد النصوص. يُستخدم في الإنتاج في [Hugging Face](https://huggingface.co)
لتشغيل Hugging Chat وواجهة برمجة التطبيقات للاستدلال ونقاط نهاية الاستدلال.

</div>

## جدول المحتويات

  - [البدء](#get-started)
    - [دوكر](#docker)
    - [توثيق API](#api-documentation)
    - [استخدام نموذج خاص أو مقيد](#using-a-private-or-gated-model)
    - [ملاحظة عن الذاكرة المشتركة (shm)](#a-note-on-shared-memory-shm)
    - [التتبع الموزع](#distributed-tracing)
    - [الهيكلية](#architecture)
    - [التثبيت المحلي](#local-install)
    - [التثبيت المحلي (Nix)](#local-install-nix)
  - [الهيكليات المحسّنة](#optimized-architectures)
  - [التشغيل محلياً](#run-locally)
    - [تشغيل](#run)
    - [الكمية](#quantization)
  - [التطوير](#develop)
  - [الاختبار](#testing)

استدلال توليد النصوص (TGI) هو مجموعة أدوات لنشر وتقديم نماذج اللغة الكبيرة (LLMs). يتيح TGI أداءً عاليًا في توليد النصوص لأشهر نماذج اللغة المفتوحة المصدر، بما في ذلك Llama و Falcon و StarCoder و BLOOM و GPT-NeoX و[المزيد](https://huggingface.co/docs/text-generation-inference/supported_models). ينفذ TGI العديد من الميزات، مثل:

- مشغل بسيط لخدمة أشهر نماذج اللغة الكبيرة
- جاهز للإنتاج (تتبع موزع باستخدام Open Telemetry، مقاييس Prometheus)
- التوازي بين التنسورات لتسريع الاستدلال على عدة وحدات معالجة رسومات
- تدفق الرموز باستخدام أحداث مرسلة من الخادم (SSE)
- تجميع مستمر للطلبات الواردة لزيادة إجمالي الإنتاجية
- [رسائل API](https://huggingface.co/docs/text-generation-inference/en/messages_api) متوافقة مع واجهة برمجة تطبيقات إكمال الدردشة من Open AI
- كود محسن للمحولات للاستدلال باستخدام [Flash Attention](https://github.com/HazyResearch/flash-attention) و [Paged Attention](https://github.com/vllm-project/vllm) على أكثر الهيكليات شعبية
- الكمية باستخدام:
  - [bitsandbytes](https://github.com/TimDettmers/bitsandbytes)
  - [GPT-Q](https://arxiv.org/abs/2210.17323)
  - [EETQ](https://github.com/NetEase-FuXi/EETQ)
  - [AWQ](https://github.com/casper-hansen/AutoAWQ)
  - [Marlin](https://github.com/IST-DASLab/marlin)
  - [fp8](https://developer.nvidia.com/blog/nvidia-arm-and-intel-publish-fp8-specification-for-standardization-as-an-interchange-format-for-ai/)
- تحميل الأوزان باستخدام [Safetensors](https://github.com/huggingface/safetensors)
- وضع علامة مائية مع [علامة مائية للنماذج اللغوية الكبيرة](https://arxiv.org/abs/2301.10226)
- معالج اللوجيت (مقاييس درجة الحرارة، top-p، top-k، عقوبة التكرار، للمزيد راجع [transformers.LogitsProcessor](https://huggingface.co/docs/transformers/internal/generation_utils#transformers.LogitsProcessor))
- تسلسل التوقف
- احتمالات اللوج
- [التكهن](https://huggingface.co/docs/text-generation-inference/conceptual/speculation) ~ ضعف زمن الاستجابة
- [الإرشاد/JSON](https://huggingface.co/docs/text-generation-inference/conceptual/guidance). حدد صيغة الإخراج لتسريع الاستدلال وضمان صحة الإخراج وفقًا لبعض المواصفات.
- توليد مطالبات مخصصة: توليد النص بسهولة عبر توفير مطالبات مخصصة لتوجيه مخرجات النموذج
- دعم التخصيص: استخدام نماذج مخصصة لمهام محددة لتحقيق دقة وأداء أعلى

### دعم الأجهزة

- [Nvidia](https://github.com/huggingface/text-generation-inference/pkgs/container/text-generation-inference)
- [AMD](https://github.com/huggingface/text-generation-inference/pkgs/container/text-generation-inference) (-rocm)
- [Inferentia](https://github.com/huggingface/optimum-neuron/tree/main/text-generation-inference)
- [Intel GPU](https://github.com/huggingface/text-generation-inference/pull/1475)
- [Gaudi](https://github.com/huggingface/tgi-gaudi)
- [Google TPU](https://huggingface.co/docs/optimum-tpu/howto/serving)


## البدء

### دوكر

للحصول على دليل بدء مفصل، يرجى الاطلاع على [الجولة السريعة](https://huggingface.co/docs/text-generation-inference/quicktour). أسهل طريقة للبدء هي استخدام حاوية دوكر الرسمية:

```shell
model=HuggingFaceH4/zephyr-7b-beta
# شارك مجلدًا مع حاوية دوكر لتجنب تنزيل الأوزان في كل مرة
volume=$PWD/data

docker run --gpus all --shm-size 1g -p 8080:80 -v $volume:/data \
    ghcr.io/huggingface/text-generation-inference:3.3.2 --model-id $model
```

ثم يمكنك إجراء طلبات مثل

```bash
curl 127.0.0.1:8080/generate_stream \
    -X POST \
    -d '{"inputs":"ما هو التعلم العميق؟","parameters":{"max_new_tokens":20}}' \
    -H 'Content-Type: application/json'
```

يمكنك أيضًا استخدام [رسائل API الخاصة بـ TGI](https://huggingface.co/docs/text-generation-inference/en/messages_api) للحصول على ردود متوافقة مع واجهة برمجة تطبيقات إكمال الدردشة من Open AI.

```bash
curl localhost:8080/v1/chat/completions \
    -X POST \
    -d '{
  "model": "tgi",
  "messages": [
    {
      "role": "system",
      "content": "أنت مساعد مفيد."
    },
    {
      "role": "user",
      "content": "ما هو التعلم العميق؟"
    }
  ],
  "stream": true,
  "max_tokens": 20
}' \
    -H 'Content-Type: application/json'
```

**ملاحظة:** لاستخدام وحدات معالجة الرسومات من NVIDIA، تحتاج إلى تثبيت [أداة NVIDIA Container Toolkit](https://docs.nvidia.com/datacenter/cloud-native/container-toolkit/install-guide.html). نوصي أيضًا باستخدام برامج تشغيل NVIDIA مع إصدار CUDA 12.2 أو أعلى. لتشغيل حاوية دوكر على جهاز بدون GPU أو دعم CUDA، يكفي إزالة العلم `--gpus all` وإضافة `--disable-custom-kernels`، يرجى ملاحظة أن وحدة المعالجة المركزية ليست المنصة المقصودة لهذا المشروع، لذا قد يكون الأداء أقل من المتوقع.

**ملاحظة:** يدعم TGI وحدات معالجة الرسومات AMD Instinct MI210 و MI250. يمكن العثور على التفاصيل في [توثيق الأجهزة المدعومة](https://huggingface.co/docs/text-generation-inference/installation_amd#using-tgi-with-amd-gpus). لاستخدام وحدات AMD GPU، يرجى استخدام الأمر `docker run --device /dev/kfd --device /dev/dri --shm-size 1g -p 8080:80 -v $volume:/data ghcr.io/huggingface/text-generation-inference:3.3.2-rocm --model-id $model` بدلاً من الأمر أعلاه.

لرؤية جميع الخيارات لخدمة نماذجك (في [الكود](https://github.com/huggingface/text-generation-inference/blob/main/launcher/src/main.rs) أو في cli):
```
text-generation-launcher --help
```

### توثيق API

يمكنك الاطلاع على توثيق OpenAPI لواجهة برمجة التطبيقات REST الخاصة بـ `text-generation-inference` عبر مسار `/docs`.
واجهة Swagger UI متاحة أيضًا على: [https://huggingface.github.io/text-generation-inference](https://huggingface.github.io/text-generation-inference).

### استخدام نموذج خاص أو مقيد

لديك خيار استخدام متغير البيئة `HF_TOKEN` لتكوين الرمز المستخدم بواسطة
`text-generation-inference`. يتيح لك ذلك الوصول إلى الموارد المحمية.

على سبيل المثال، إذا كنت تريد خدمة نماذج Llama V2 المقيدة:

1. اذهب إلى https://huggingface.co/settings/tokens
2. انسخ رمز القراءة الخاص بواجهة سطر الأوامر
3. صدّر المتغير `HF_TOKEN=<رمز القراءة الخاص بك>`

أو مع دوكر:

```shell
model=meta-llama/Meta-Llama-3.1-8B-Instruct
volume=$PWD/data # شارك مجلدًا مع حاوية دوكر لتجنب تنزيل الأوزان في كل مرة
token=<رمز القراءة الخاص بك>

docker run --gpus all --shm-size 1g -e HF_TOKEN=$token -p 8080:80 -v $volume:/data \
    ghcr.io/huggingface/text-generation-inference:3.3.2 --model-id $model
```

### ملاحظة عن الذاكرة المشتركة (shm)

[`NCCL`](https://docs.nvidia.com/deeplearning/nccl/user-guide/docs/index.html) هو إطار عمل اتصال يستخدمه
`PyTorch` لتنفيذ التدريب/الاستدلال الموزع. يستخدم `text-generation-inference`
`NCCL` لتمكين التوازي بين التنسورات لتسريع الاستدلال بشكل كبير لنماذج اللغة الكبيرة.

لمشاركة البيانات بين الأجهزة المختلفة ضمن مجموعة `NCCL`، قد يعود `NCCL` لاستخدام ذاكرة المضيف إذا
لم يكن الاتصال المباشر (peer-to-peer) باستخدام NVLink أو PCI ممكنًا.

للسماح للحاوية باستخدام 1 جيجابايت من الذاكرة المشتركة ودعم مشاركة SHM، نضيف `--shm-size 1g` في الأمر أعلاه.

إذا كنت تشغل `text-generation-inference` داخل `Kubernetes`، يمكنك أيضًا إضافة ذاكرة مشتركة للحاوية
بإنشاء مجلد باستخدام:

```yaml
- name: shm
  emptyDir:
   medium: Memory
   sizeLimit: 1Gi
```

وتركيبه على `/dev/shm`.

أخيرًا، يمكنك تعطيل مشاركة SHM باستخدام متغير البيئة `NCCL_SHM_DISABLE=1`. مع ذلك، لاحظ أن
ذلك سيؤثر على الأداء.

### التتبع الموزع

تم تجهيز `text-generation-inference` بأدوات تتبع موزع باستخدام OpenTelemetry. يمكنك استخدام هذه الميزة
بتعيين العنوان إلى جامع OTLP باستخدام الوسيطة `--otlp-endpoint`. يمكن تجاوز اسم الخدمة الافتراضي
باستخدام الوسيطة `--otlp-service-name`.

### الهيكلية

![هيكلية TGI](https://raw.githubusercontent.com/huggingface/text-generation-inference/main/datasets/huggingface/documentation-images/resolve/main/TGI.png)

مقال تفصيلي من Adyen حول آليات عمل TGI: [الاستدلال على نماذج اللغة الكبيرة على نطاق واسع مع TGI (مارتن إيغليسياس جوينيس - Adyen، 2024)](https://www.adyen.com/knowledge-hub/llm-inference-at-scale-with-tgi)

### التثبيت المحلي

يمكنك أيضًا اختيار تثبيت `text-generation-inference` محليًا.

أولاً استنسخ المستودع وغيّر الدليل إليه:
```shell
git clone https://github.com/huggingface/text-generation-inference
cd text-generation-inference
```

ثم [قم بتثبيت Rust](https://rustup.rs/) وأنشئ بيئة افتراضية للبايثون مع نسخة لا تقل عن
بايثون 3.9، مثلاً باستخدام `conda` أو `python venv`:

```shell
curl --proto '=https' --tlsv1.2 -sSf https://sh.rustup.rs | sh

# باستخدام conda
conda create -n text-generation-inference python=3.11
conda activate text-generation-inference

# باستخدام python venv
python3 -m venv .venv
source .venv/bin/activate
```

قد تحتاج أيضًا إلى تثبيت Protoc.

على لينكس:

```shell
PROTOC_ZIP=protoc-21.12-linux-x86_64.zip
curl -OL https://raw.githubusercontent.com/huggingface/text-generation-inference/main/github.com/protocolbuffers/protobuf/releases/download/v21.12/$PROTOC_ZIP
sudo unzip -o $PROTOC_ZIP -d /usr/local bin/protoc
sudo unzip -o $PROTOC_ZIP -d /usr/local 'include/*'
rm -f $PROTOC_ZIP
```

على ماك أو إس، باستخدام Homebrew:

```shell
brew install protobuf
```

ثم شغل:

```shell
BUILD_EXTENSIONS=True make install # تثبيت المستودع وفَرْع HF/transformer مع نوى CUDA
text-generation-launcher --model-id mistralai/Mistral-7B-Instruct-v0.2
```

**ملاحظة:** في بعض الأجهزة، قد تحتاج أيضًا إلى مكتبات OpenSSL و gcc. على أجهزة لينكس، شغل:

```shell
sudo apt-get install libssl-dev gcc -y
```

### التثبيت المحلي (Nix)

خيار آخر هو تثبيت `text-generation-inference` محليًا باستخدام [Nix](https://nixos.org). حاليًا،
ندعم فقط Nix على لينكس x86_64 مع بطاقات CUDA. عند استخدام Nix، يمكن سحب كل التبعيات
من ذاكرة تخزين ثنائية، مما يلغي الحاجة لبنائها محليًا.

أولاً اتبع التعليمات لـ [تثبيت Cachix وتمكين ذاكرة التخزين الخاصة بـ Hugging Face](https://app.cachix.org/cache/huggingface).
إعداد الذاكرة مهم، وإلا سيقوم Nix ببناء العديد من التبعيات
محليًا، وقد يستغرق ذلك ساعات.

بعد ذلك يمكنك تشغيل TGI باستخدام `nix run`:

```shell
cd text-generation-inference
nix run --extra-experimental-features nix-command --extra-experimental-features flakes . -- --model-id meta-llama/Llama-3.1-8B-Instruct
```

**ملاحظة:** عند استخدام Nix على نظام غير NixOS، يجب أن [تنشئ بعض الروابط الرمزية](https://danieldk.eu/Nix-CUDA-on-non-NixOS-systems#make-runopengl-driverlib-and-symlink-the-driver-library)
لجعل مكتبات تعريف CUDA مرئية لحزم Nix.

لتطوير TGI، يمكنك استخدام بيئة التطوير `impure`:

```shell
nix develop .#impure

# مطلوب فقط عند بدء بيئة التطوير لأول مرة أو بعد تحديث protobuf.
(
cd server
mkdir text_generation_server/pb || true
python -m grpc_tools.protoc -I../proto/v3 --python_out=text_generation_server/pb \
       --grpc_python_out=text_generation_server/pb --mypy_out=text_generation_server/pb ../proto/v3/generate.proto
find text_generation_server/pb/ -type f -name "*.py" -print0 -exec sed -i -e 's/^\(import.*pb2\)/from . \1/g' {} \;
touch text_generation_server/pb/__init__.py
)
```

جميع تبعيات التطوير (cargo، Python، Torch)، وغيرها متاحة في
بيئة التطوير هذه.

## البنى المحسنة

يعمل TGI مباشرة لتقديم نماذج محسنة لجميع النماذج الحديثة. يمكن العثور عليها في [هذه القائمة](https://huggingface.co/docs/text-generation-inference/supported_models).

تدعم البنى الأخرى على أساس أفضل جهد باستخدام:

`AutoModelForCausalLM.from_pretrained(<model>, device_map="auto")`

أو

`AutoModelForSeq2SeqLM.from_pretrained(<model>, device_map="auto")`



## التشغيل محليًا

### التشغيل

```shell
text-generation-launcher --model-id mistralai/Mistral-7B-Instruct-v0.2
```

### التكميم

يمكنك أيضًا تشغيل أوزان مكممة مسبقًا (AWQ، GPTQ، Marlin) أو تكميم الأوزان أثناء التشغيل باستخدام bitsandbytes، EETQ، fp8، لتقليل متطلبات ذاكرة الفيديو:

```shell
text-generation-launcher --model-id mistralai/Mistral-7B-Instruct-v0.2 --quantize
```

التكميم بـ4 بت متاح باستخدام [أنواع البيانات NF4 و FP4 من bitsandbytes](https://arxiv.org/pdf/2305.14314.pdf). يمكن تفعيله بتوفير `--quantize bitsandbytes-nf4` أو `--quantize bitsandbytes-fp4` كوسيط سطر أوامر لـ `text-generation-launcher`.

اقرأ المزيد عن التكميم في [توثيق التكميم](https://huggingface.co/docs/text-generation-inference/en/conceptual/quantization).

## التطوير

```shell
make server-dev
make router-dev
```

## الاختبار

```shell
# بايثون
make python-server-tests
make python-client-tests
# أو كلا اختبار الخادم والعميل
make python-tests
# اختبارات رست cargo
make rust-tests
# اختبارات التكامل
make integration-tests
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---