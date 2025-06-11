<div align="center">

<a href="https://www.youtube.com/watch?v=jlMAX2Oaht0">
  <img width=560 alt="Making TGI deployment optimal" src="https://raw.githubusercontent.com/huggingface/text-generation-inference/main/datasets/Narsil/tgi_assets/thumbnail.png">
</a>

# استنتاج تولید متن

<a href="https://github.com/huggingface/text-generation-inference">
  <img alt="GitHub Repo stars" src="https://img.shields.io/github/stars/huggingface/text-generation-inference?style=social">
</a>
<a href="https://huggingface.github.io/text-generation-inference">
  <img alt="Swagger API documentation" src="https://img.shields.io/badge/API-Swagger-informational">
</a>

یک سرور Rust، Python و gRPC برای استنتاج تولید متن. استفاده شده در تولید در [Hugging Face](https://huggingface.co)
برای قدرت بخشیدن به Hugging Chat، API استنتاج و نقاط انتهایی استنتاج.

</div>

## فهرست مطالب

  - [شروع به کار](#get-started)
    - [داکر](#docker)
    - [مستندات API](#api-documentation)
    - [استفاده از مدل خصوصی یا محدود شده](#using-a-private-or-gated-model)
    - [نکته‌ای درباره حافظه مشترک (shm)](#a-note-on-shared-memory-shm)
    - [ردیابی توزیع شده](#distributed-tracing)
    - [معماری](#architecture)
    - [نصب محلی](#local-install)
    - [نصب محلی (Nix)](#local-install-nix)
  - [معماری‌های بهینه‌شده](#optimized-architectures)
  - [اجرای محلی](#run-locally)
    - [اجرا](#run)
    - [کوانتیزاسیون](#quantization)
  - [توسعه](#develop)
  - [تست](#testing)

استنتاج تولید متن (TGI) یک مجموعه ابزار برای استقرار و ارائه مدل‌های زبان بزرگ (LLMs) است. TGI امکان تولید متن با کارایی بالا را برای محبوب‌ترین مدل‌های متن‌باز فراهم می‌کند، از جمله Llama، Falcon، StarCoder، BLOOM، GPT-NeoX و [بیشتر](https://huggingface.co/docs/text-generation-inference/supported_models). TGI ویژگی‌های متعددی را پیاده‌سازی می‌کند، مانند:

- راه‌انداز ساده برای ارائه محبوب‌ترین مدل‌های زبان بزرگ
- آماده تولید (ردیابی توزیع شده با Open Telemetry، معیارهای Prometheus)
- موازی‌سازی تنسور برای استنتاج سریع‌تر روی چندین GPU
- استریم توکن با استفاده از رویدادهای ارسال شده از سرور (SSE)
- دسته‌بندی پیوسته درخواست‌های ورودی برای افزایش توان کل
- [API پیام‌ها](https://huggingface.co/docs/text-generation-inference/en/messages_api) سازگار با Open AI Chat Completion API
- کد بهینه‌شده ترنسفورمرها برای استنتاج با استفاده از [Flash Attention](https://github.com/HazyResearch/flash-attention) و [Paged Attention](https://github.com/vllm-project/vllm) بر روی محبوب‌ترین معماری‌ها
- کوانتیزاسیون با:
  - [bitsandbytes](https://github.com/TimDettmers/bitsandbytes)
  - [GPT-Q](https://arxiv.org/abs/2210.17323)
  - [EETQ](https://github.com/NetEase-FuXi/EETQ)
  - [AWQ](https://github.com/casper-hansen/AutoAWQ)
  - [Marlin](https://github.com/IST-DASLab/marlin)
  - [fp8](https://developer.nvidia.com/blog/nvidia-arm-and-intel-publish-fp8-specification-for-standardization-as-an-interchange-format-for-ai/)
- بارگذاری وزن با [Safetensors](https://github.com/huggingface/safetensors)
- واترمارک با [واترمارک برای مدل‌های زبان بزرگ](https://arxiv.org/abs/2301.10226)
- تغییر دهنده لگیت‌ها (مقیاس دما، top-p، top-k، جریمه تکرار، جزئیات بیشتر در [transformers.LogitsProcessor](https://huggingface.co/docs/transformers/internal/generation_utils#transformers.LogitsProcessor))
- توالی‌های توقف
- احتمال‌های لگاریتمی
- [حدس](https://huggingface.co/docs/text-generation-inference/conceptual/speculation) با تقریباً دو برابر کاهش تأخیر
- [راهنمایی/JSON](https://huggingface.co/docs/text-generation-inference/conceptual/guidance). تعیین فرمت خروجی برای سرعت بخشیدن به استنتاج و اطمینان از اعتبار خروجی بر اساس برخی مشخصات.
- تولید متن سفارشی: تولید آسان متن با ارائه پرامپت‌های سفارشی برای هدایت خروجی مدل
- پشتیبانی از تنظیم دقیق: استفاده از مدل‌های تنظیم دقیق شده برای وظایف خاص جهت دستیابی به دقت و عملکرد بالاتر

### پشتیبانی سخت‌افزاری

- [Nvidia](https://github.com/huggingface/text-generation-inference/pkgs/container/text-generation-inference)
- [AMD](https://github.com/huggingface/text-generation-inference/pkgs/container/text-generation-inference) (-rocm)
- [Inferentia](https://github.com/huggingface/optimum-neuron/tree/main/text-generation-inference)
- [Intel GPU](https://github.com/huggingface/text-generation-inference/pull/1475)
- [Gaudi](https://github.com/huggingface/tgi-gaudi)
- [Google TPU](https://huggingface.co/docs/optimum-tpu/howto/serving)


## شروع به کار

### داکر

برای راهنمای شروع دقیق‌تر، لطفاً راهنمای [تور سریع](https://huggingface.co/docs/text-generation-inference/quicktour) را ببینید. ساده‌ترین راه برای شروع استفاده از کانتینر رسمی داکر است:

```shell
model=HuggingFaceH4/zephyr-7b-beta
# اشتراک یک حجم با کانتینر داکر برای جلوگیری از دانلود وزن‌ها در هر بار اجرا
volume=$PWD/data

docker run --gpus all --shm-size 1g -p 8080:80 -v $volume:/data \
    ghcr.io/huggingface/text-generation-inference:3.3.2 --model-id $model
```

و سپس می‌توانید درخواست‌هایی مانند

```bash
curl 127.0.0.1:8080/generate_stream \
    -X POST \
    -d '{"inputs":"یادگیری عمیق چیست؟","parameters":{"max_new_tokens":20}}' \
    -H 'Content-Type: application/json'
```

ارسال کنید.

همچنین می‌توانید از [API پیام‌های TGI](https://huggingface.co/docs/text-generation-inference/en/messages_api) برای دریافت پاسخ‌های سازگار با Open AI Chat Completion API استفاده کنید.

```bash
curl localhost:8080/v1/chat/completions \
    -X POST \
    -d '{
  "model": "tgi",
  "messages": [
    {
      "role": "system",
      "content": "شما یک دستیار مفید هستید."
    },
    {
      "role": "user",
      "content": "یادگیری عمیق چیست؟"
    }
  ],
  "stream": true,
  "max_tokens": 20
}' \
    -H 'Content-Type: application/json'
```

**توجه:** برای استفاده از GPUهای NVIDIA، باید [NVIDIA Container Toolkit](https://docs.nvidia.com/datacenter/cloud-native/container-toolkit/install-guide.html) را نصب کنید. همچنین توصیه می‌کنیم از درایورهای NVIDIA با نسخه CUDA 12.2 یا بالاتر استفاده کنید. برای اجرای کانتینر داکر روی ماشینی بدون GPU یا پشتیبانی CUDA، کافی است پرچم `--gpus all` را حذف و `--disable-custom-kernels` را اضافه کنید، توجه داشته باشید که CPU پلتفرم مورد نظر برای این پروژه نیست و عملکرد ممکن است پایین‌تر باشد.

**توجه:** TGI از GPUهای AMD Instinct MI210 و MI250 پشتیبانی می‌کند. جزئیات در [مستندات سخت‌افزار پشتیبانی شده](https://huggingface.co/docs/text-generation-inference/installation_amd#using-tgi-with-amd-gpus) موجود است. برای استفاده از GPUهای AMD، لطفاً به جای فرمان بالا از دستور زیر استفاده کنید:

```shell
docker run --device /dev/kfd --device /dev/dri --shm-size 1g -p 8080:80 -v $volume:/data ghcr.io/huggingface/text-generation-inference:3.3.2-rocm --model-id $model
```

برای دیدن همه گزینه‌ها برای ارائه مدل‌های خود (در [کد](https://github.com/huggingface/text-generation-inference/blob/main/launcher/src/main.rs) یا در CLI):
```
text-generation-launcher --help
```

### مستندات API

می‌توانید مستندات OpenAPI مربوط به REST API `text-generation-inference` را از طریق مسیر `/docs` مشاهده کنید.
رابط کاربری Swagger نیز در دسترس است در: [https://huggingface.github.io/text-generation-inference](https://huggingface.github.io/text-generation-inference).

### استفاده از مدل خصوصی یا محدود شده

شما این امکان را دارید که متغیر محیطی `HF_TOKEN` را برای تنظیم توکنی که توسط
`text-generation-inference` استفاده می‌شود، پیکربندی کنید. این به شما اجازه می‌دهد به منابع محافظت شده دسترسی پیدا کنید.

برای مثال، اگر می‌خواهید نسخه‌های محدود شده مدل Llama V2 را ارائه دهید:

1. به https://huggingface.co/settings/tokens بروید
2. توکن CLI READ خود را کپی کنید
3. متغیر `HF_TOKEN=<توکن CLI READ شما>` را صادر کنید

یا با داکر:

```shell
model=meta-llama/Meta-Llama-3.1-8B-Instruct
volume=$PWD/data # اشتراک یک حجم با کانتینر داکر برای جلوگیری از دانلود وزن‌ها در هر بار اجرا
token=<توکن CLI READ شما>

docker run --gpus all --shm-size 1g -e HF_TOKEN=$token -p 8080:80 -v $volume:/data \
    ghcr.io/huggingface/text-generation-inference:3.3.2 --model-id $model
```

### نکته‌ای درباره حافظه مشترک (shm)

[`NCCL`](https://docs.nvidia.com/deeplearning/nccl/user-guide/docs/index.html) یک چارچوب ارتباطی است که توسط
`PyTorch` برای آموزش/استنتاج توزیع شده استفاده می‌شود. `text-generation-inference` از
`NCCL` برای فعال‌سازی موازی‌سازی تنسور جهت افزایش چشمگیر سرعت استنتاج مدل‌های زبان بزرگ استفاده می‌کند.

برای به اشتراک گذاشتن داده‌ها بین دستگاه‌های مختلف یک گروه `NCCL`، ممکن است `NCCL` در صورت عدم امکان ارتباط peer-to-peer از طریق NVLink یا PCI به حافظه میزبان بازگردد.

برای اجازه دادن به کانتینر برای استفاده از ۱ گیگابایت حافظه مشترک و پشتیبانی از اشتراک SHM، ما `--shm-size 1g` را به فرمان بالا اضافه کرده‌ایم.

اگر `text-generation-inference` را در داخل `Kubernetes` اجرا می‌کنید، همچنین می‌توانید حافظه مشترک را با ایجاد یک حجم به شکل زیر اضافه کنید:

```yaml
- name: shm
  emptyDir:
   medium: Memory
   sizeLimit: 1Gi
```

و آن را به `/dev/shm` متصل کنید.

در نهایت، می‌توانید اشتراک SHM را با استفاده از متغیر محیطی `NCCL_SHM_DISABLE=1` غیرفعال کنید. اما توجه داشته باشید که این موضوع بر عملکرد تأثیر خواهد گذاشت.

### ردیابی توزیع شده

`text-generation-inference` با استفاده از OpenTelemetry مجهز به ردیابی توزیع شده است. شما می‌توانید با تنظیم آدرس به یک جمع‌آور OTLP با آرگومان `--otlp-endpoint` از این ویژگی استفاده کنید. نام سرویس پیش‌فرض می‌تواند با آرگومان `--otlp-service-name` بازنویسی شود.

### معماری

![معماری TGI](https://raw.githubusercontent.com/huggingface/text-generation-inference/main/datasets/huggingface/documentation-images/TGI.png)

پست وبلاگی دقیق توسط Adyen درباره عملکرد داخلی TGI: [استنتاج LLM در مقیاس با TGI (مارتین ایگلسیاس گویانز - Adyen، ۲۰۲۴)](https://www.adyen.com/knowledge-hub/llm-inference-at-scale-with-tgi)

### نصب محلی

شما همچنین می‌توانید `text-generation-inference` را به صورت محلی نصب کنید.

ابتدا مخزن را کلون کرده و به دایرکتوری آن بروید:
```shell
git clone https://github.com/huggingface/text-generation-inference
cd text-generation-inference
```

سپس [Rust را نصب کنید](https://rustup.rs/) و یک محیط مجازی پایتون با نسخه حداقل ۳.۹ ایجاد کنید، به عنوان مثال با استفاده از `conda` یا `python venv`:

```shell
curl --proto '=https' --tlsv1.2 -sSf https://sh.rustup.rs | sh

# استفاده از conda
conda create -n text-generation-inference python=3.11
conda activate text-generation-inference

# استفاده از python venv
python3 -m venv .venv
source .venv/bin/activate
```

ممکن است نیاز به نصب Protoc نیز داشته باشید.

در لینوکس:

```shell
PROTOC_ZIP=protoc-21.12-linux-x86_64.zip
curl -OL https://github.com/protocolbuffers/protobuf/releases/download/v21.12/$PROTOC_ZIP
sudo unzip -o $PROTOC_ZIP -d /usr/local bin/protoc
sudo unzip -o $PROTOC_ZIP -d /usr/local 'include/*'
rm -f $PROTOC_ZIP
```

در مک‌اواس، با استفاده از Homebrew:

```shell
brew install protobuf
```

سپس اجرا کنید:

```shell
BUILD_EXTENSIONS=True make install # نصب مخزن و فورک HF/transformer با هسته‌های CUDA
text-generation-launcher --model-id mistralai/Mistral-7B-Instruct-v0.2
```

**توجه:** در برخی ماشین‌ها ممکن است نیاز به کتابخانه‌های OpenSSL و gcc نیز باشد. در ماشین‌های لینوکسی، اجرا کنید:

```shell
sudo apt-get install libssl-dev gcc -y
```

### نصب محلی (Nix)

گزینه دیگر نصب محلی `text-generation-inference` با استفاده از [Nix](https://nixos.org) است. در حال حاضر، ما فقط از Nix روی لینوکس x86_64 با GPUهای CUDA پشتیبانی می‌کنیم. هنگام استفاده از Nix، تمام وابستگی‌ها می‌توانند از کش باینری بارگیری شوند و نیازی به ساخت محلی آنها نیست.

ابتدا دستورالعمل‌های [نصب Cachix و فعال‌سازی کش Hugging Face](https://app.cachix.org/cache/huggingface) را دنبال کنید. راه‌اندازی کش اهمیت دارد، در غیر این صورت Nix بسیاری از وابستگی‌ها را به صورت محلی می‌سازد که ممکن است ساعت‌ها طول بکشد.

پس از آن می‌توانید TGI را با `nix run` اجرا کنید:

```shell
cd text-generation-inference
nix run --extra-experimental-features nix-command --extra-experimental-features flakes . -- --model-id meta-llama/Llama-3.1-8B-Instruct
```

**توجه:** وقتی از Nix روی سیستم غیر NixOS استفاده می‌کنید، باید [چند لینک نمادین (symlink) ایجاد کنید](https://danieldk.eu/Nix-CUDA-on-non-NixOS-systems#make-runopengl-driverlib-and-symlink-the-driver-library)
تا کتابخانه‌های درایور CUDA برای بسته‌های Nix قابل مشاهده شوند.

برای توسعه TGI، می‌توانید از شِل توسعه `impure` استفاده کنید:

```shell
nix develop .#impure

# فقط دفعه اولی که devshell شروع می‌شود یا بعد از به‌روزرسانی protobuf لازم است.
(
cd server
mkdir text_generation_server/pb || true
python -m grpc_tools.protoc -I../proto/v3 --python_out=text_generation_server/pb \
       --grpc_python_out=text_generation_server/pb --mypy_out=text_generation_server/pb ../proto/v3/generate.proto
find text_generation_server/pb/ -type f -name "*.py" -print0 -exec sed -i -e 's/^\(import.*pb2\)/from . \1/g' {} \;
touch text_generation_server/pb/__init__.py
)
```

تمام وابستگی‌های توسعه (cargo، پایتون، Torch و غیره) در این شِل توسعه در دسترس هستند.

## معماری‌های بهینه‌شده

TGI به صورت پیش‌فرض برای سرو کردن مدل‌های بهینه‌شده برای تمام مدل‌های مدرن کار می‌کند. این مدل‌ها را می‌توانید در [این فهرست](https://huggingface.co/docs/text-generation-inference/supported_models) بیابید.

معماری‌های دیگر به صورت بهترین تلاش با استفاده از:

`AutoModelForCausalLM.from_pretrained(<model>, device_map="auto")`

یا

`AutoModelForSeq2SeqLM.from_pretrained(<model>, device_map="auto")`

پشتیبانی می‌شوند.

## اجرای محلی

### اجرا

```shell
text-generation-launcher --model-id mistralai/Mistral-7B-Instruct-v0.2
```

### کم‌حجمی (Quantization)

همچنین می‌توانید وزن‌های پیش‌کم‌حجم شده (AWQ، GPTQ، Marlin) را اجرا کنید یا وزن‌ها را در لحظه با bitsandbytes، EETQ، fp8 کم‌حجم کنید تا نیاز به VRAM کاهش یابد:

```shell
text-generation-launcher --model-id mistralai/Mistral-7B-Instruct-v0.2 --quantize
```

کم‌حجمی ۴بیتی با استفاده از [نوع‌های داده NF4 و FP4 از bitsandbytes](https://arxiv.org/pdf/2305.14314.pdf) در دسترس است. می‌توانید با ارائه `--quantize bitsandbytes-nf4` یا `--quantize bitsandbytes-fp4` به عنوان آرگومان خط فرمان به `text-generation-launcher` آن را فعال کنید.

برای اطلاعات بیشتر درباره کم‌حجمی به [مستندات Quantization](https://huggingface.co/docs/text-generation-inference/en/conceptual/quantization) مراجعه کنید.

## توسعه

```shell
make server-dev
make router-dev
```

## تست

```shell
# پایتون
make python-server-tests
make python-client-tests
# یا هر دو تست سرور و کلاینت
make python-tests
# تست‌های rust cargo
make rust-tests
# تست‌های یکپارچه‌سازی
make integration-tests
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---