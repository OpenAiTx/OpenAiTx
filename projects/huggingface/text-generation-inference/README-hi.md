<div align="center">

<a href="https://www.youtube.com/watch?v=jlMAX2Oaht0">
  <img width=560 alt="Making TGI deployment optimal" src="https://raw.githubusercontent.com/huggingface/text-generation-inference/main/assets/thumbnail.png">
</a>

# टेक्स्ट जनरेशन इन्फेरेंस

<a href="https://github.com/huggingface/text-generation-inference">
  <img alt="GitHub Repo stars" src="https://img.shields.io/github/stars/huggingface/text-generation-inference?style=social">
</a>
<a href="https://huggingface.github.io/text-generation-inference">
  <img alt="Swagger API documentation" src="https://img.shields.io/badge/API-Swagger-informational">
</a>

टेक्स्ट जनरेशन इन्फेरेंस के लिए एक रस्ट, पायथन और gRPC सर्वर। [Hugging Face](https://huggingface.co) में उत्पादन में उपयोग किया जाता है
Hugging Chat, Inference API और Inference Endpoints को पावर देने के लिए।

</div>

## सामग्री तालिका

  - [शुरू करें](#get-started)
    - [डॉकर](#docker)
    - [API दस्तावेज़](#api-documentation)
    - [प्राइवेट या गेटेड मॉडल का उपयोग](#using-a-private-or-gated-model)
    - [शेयरड मेमोरी (shm) पर एक नोट](#a-note-on-shared-memory-shm)
    - [डिस्ट्रिब्यूटेड ट्रेसिंग](#distributed-tracing)
    - [आर्किटेक्चर](#architecture)
    - [लोकल इंस्टॉल](#local-install)
    - [लोकल इंस्टॉल (Nix)](#local-install-nix)
  - [ऑप्टिमाइज़्ड आर्किटेक्चर](#optimized-architectures)
  - [लोकल रूप से चलाएं](#run-locally)
    - [चलाएं](#run)
    - [क्वांटाइजेशन](#quantization)
  - [डेवलप करें](#develop)
  - [टेस्टिंग](#testing)

टेक्स्ट जनरेशन इन्फेरेंस (TGI) बड़े भाषा मॉडल (LLMs) को डिप्लॉय और सर्व करने के लिए एक टूलकिट है। TGI लोकप्रिय ओपन-सोर्स LLMs के लिए उच्च प्रदर्शन वाले टेक्स्ट जनरेशन को सक्षम करता है, जिसमें Llama, Falcon, StarCoder, BLOOM, GPT-NeoX, और [और भी](https://huggingface.co/docs/text-generation-inference/supported_models) शामिल हैं। TGI कई फीचर्स को लागू करता है, जैसे:

- सबसे लोकप्रिय LLMs को सर्व करने के लिए सरल लॉन्चर
- प्रोडक्शन रेडी (Open Telemetry के साथ डिस्ट्रिब्यूटेड ट्रेसिंग, Prometheus मेट्रिक्स)
- कई GPUs पर तेज़ इन्फेरेंस के लिए टेन्सर पैरेललिज्म
- सर्वर-सेंट इवेंट्स (SSE) का उपयोग करते हुए टोकन स्ट्रीमिंग
- कुल थ्रूपुट बढ़ाने के लिए आने वाले अनुरोधों का सतत बैचिंग
- [Messages API](https://huggingface.co/docs/text-generation-inference/en/messages_api) जो Open AI Chat Completion API के साथ संगत है
- सबसे लोकप्रिय आर्किटेक्चर पर [Flash Attention](https://github.com/HazyResearch/flash-attention) और [Paged Attention](https://github.com/vllm-project/vllm) का उपयोग करके इन्फेरेंस के लिए ऑप्टिमाइज़्ड ट्रांसफॉर्मर्स कोड
- क्वांटाइजेशन :
  - [bitsandbytes](https://github.com/TimDettmers/bitsandbytes)
  - [GPT-Q](https://arxiv.org/abs/2210.17323)
  - [EETQ](https://github.com/NetEase-FuXi/EETQ)
  - [AWQ](https://github.com/casper-hansen/AutoAWQ)
  - [Marlin](https://github.com/IST-DASLab/marlin)
  - [fp8](https://developer.nvidia.com/blog/nvidia-arm-and-intel-publish-fp8-specification-for-standardization-as-an-interchange-format-for-ai/)
- [Safetensors](https://github.com/huggingface/safetensors) वेट लोडिंग
- [A Watermark for Large Language Models](https://arxiv.org/abs/2301.10226) के साथ वॉटरमार्किंग
- लॉजिट्स वार्पर (टेम्परेचर स्केलिंग, टॉप-p, टॉप-k, रिपीटेशन पेनल्टी, अधिक विवरण देखें [transformers.LogitsProcessor](https://huggingface.co/docs/transformers/internal/generation_utils#transformers.LogitsProcessor))
- स्टॉप सीक्वेंस
- लॉग प्रॉबेबिलिटीज़
- [स्पेकुलेशन](https://huggingface.co/docs/text-generation-inference/conceptual/speculation) ~2x लैटेंसी
- [Guidance/JSON](https://huggingface.co/docs/text-generation-inference/conceptual/guidance)। आउटपुट फॉर्मेट निर्दिष्ट करें ताकि इन्फेरेंस तेज़ हो और आउटपुट कुछ स्पेक्स के अनुसार वैध हो।
- कस्टम प्रॉम्प्ट जनरेशन: मॉडल के आउटपुट को निर्देशित करने के लिए कस्टम प्रॉम्प्ट प्रदान करके आसानी से टेक्स्ट जनरेट करें
- फाइन-ट्यूनिंग सपोर्ट: विशिष्ट कार्यों के लिए फाइन-ट्यून किए गए मॉडल का उपयोग करके उच्च सटीकता और प्रदर्शन प्राप्त करें

### हार्डवेयर सपोर्ट

- [Nvidia](https://github.com/huggingface/text-generation-inference/pkgs/container/text-generation-inference)
- [AMD](https://github.com/huggingface/text-generation-inference/pkgs/container/text-generation-inference) (-rocm)
- [Inferentia](https://github.com/huggingface/optimum-neuron/tree/main/text-generation-inference)
- [Intel GPU](https://github.com/huggingface/text-generation-inference/pull/1475)
- [Gaudi](https://github.com/huggingface/tgi-gaudi)
- [Google TPU](https://huggingface.co/docs/optimum-tpu/howto/serving)


## शुरू करें

### डॉकर

विस्तृत प्रारंभिक मार्गदर्शिका के लिए कृपया [Quick Tour](https://huggingface.co/docs/text-generation-inference/quicktour) देखें। शुरू करने का सबसे आसान तरीका आधिकारिक डॉकर कंटेनर का उपयोग करना है:

```shell
model=HuggingFaceH4/zephyr-7b-beta
# प्रत्येक रन में वेट्स डाउनलोड करने से बचने के लिए डॉकर कंटेनर के साथ एक वॉल्यूम साझा करें
volume=$PWD/data

docker run --gpus all --shm-size 1g -p 8080:80 -v $volume:/data \
    ghcr.io/huggingface/text-generation-inference:3.3.2 --model-id $model
```

और फिर आप ऐसे अनुरोध कर सकते हैं

```bash
curl 127.0.0.1:8080/generate_stream \
    -X POST \
    -d '{"inputs":"डीप लर्निंग क्या है?","parameters":{"max_new_tokens":20}}' \
    -H 'Content-Type: application/json'
```

आप Open AI Chat Completion API संगत प्रतिक्रियाएं प्राप्त करने के लिए [TGI के Messages API](https://huggingface.co/docs/text-generation-inference/en/messages_api) का भी उपयोग कर सकते हैं।

```bash
curl localhost:8080/v1/chat/completions \
    -X POST \
    -d '{
  "model": "tgi",
  "messages": [
    {
      "role": "system",
      "content": "आप एक सहायक सहायक हैं।"
    },
    {
      "role": "user",
      "content": "डीप लर्निंग क्या है?"
    }
  ],
  "stream": true,
  "max_tokens": 20
}' \
    -H 'Content-Type: application/json'
```

**नोट:** NVIDIA GPUs का उपयोग करने के लिए, आपको [NVIDIA Container Toolkit](https://docs.nvidia.com/datacenter/cloud-native/container-toolkit/install-guide.html) स्थापित करना होगा। हम CUDA संस्करण 12.2 या उससे उच्च के साथ NVIDIA ड्राइवरों का उपयोग करने की भी सलाह देते हैं। बिना GPU या CUDA समर्थन वाले मशीन पर Docker कंटेनर चलाने के लिए, `--gpus all` फ्लैग हटाना और `--disable-custom-kernels` जोड़ना पर्याप्त है, कृपया ध्यान दें कि CPU इस प्रोजेक्ट के लिए इरादे वाला प्लेटफ़ॉर्म नहीं है, इसलिए प्रदर्शन कम हो सकता है।

**नोट:** TGI AMD Instinct MI210 और MI250 GPUs का समर्थन करता है। विवरण [Supported Hardware documentation](https://huggingface.co/docs/text-generation-inference/installation_amd#using-tgi-with-amd-gpus) में पाया जा सकता है। AMD GPUs का उपयोग करने के लिए, कृपया ऊपर के कमांड के बजाय `docker run --device /dev/kfd --device /dev/dri --shm-size 1g -p 8080:80 -v $volume:/data ghcr.io/huggingface/text-generation-inference:3.3.2-rocm --model-id $model` उपयोग करें।

अपने मॉडलों को सर्व करने के सभी विकल्प देखने के लिए (कोड में [यहाँ](https://github.com/huggingface/text-generation-inference/blob/main/launcher/src/main.rs) या CLI में):
```
text-generation-launcher --help
```

### API दस्तावेज़

आप `/docs` मार्ग का उपयोग करके `text-generation-inference` REST API का OpenAPI दस्तावेज़ देख सकते हैं।
Swagger UI भी उपलब्ध है: [https://huggingface.github.io/text-generation-inference](https://huggingface.github.io/text-generation-inference)।

### प्राइवेट या गेटेड मॉडल का उपयोग

`text-generation-inference` द्वारा उपयोग किए जाने वाले टोकन को कॉन्फ़िगर करने के लिए आपके पास `HF_TOKEN` पर्यावरण चर का उपयोग करने का विकल्प है। यह आपको संरक्षित संसाधनों तक पहुंच प्रदान करता है।

उदाहरण के लिए, यदि आप गेटेड Llama V2 मॉडल वेरिएंट सर्व करना चाहते हैं:

1. https://huggingface.co/settings/tokens पर जाएँ
2. अपनी CLI READ टोकन कॉपी करें
3. `HF_TOKEN=<आपकी CLI READ टोकन>` निर्यात करें

या डॉकर के साथ:

```shell
model=meta-llama/Meta-Llama-3.1-8B-Instruct
volume=$PWD/data # प्रत्येक रन में वेट्स डाउनलोड करने से बचने के लिए डॉकर कंटेनर के साथ वॉल्यूम साझा करें
token=<आपकी cli READ टोकन>

docker run --gpus all --shm-size 1g -e HF_TOKEN=$token -p 8080:80 -v $volume:/data \
    ghcr.io/huggingface/text-generation-inference:3.3.2 --model-id $model
```

### शेयरड मेमोरी (shm) पर एक नोट

[`NCCL`](https://docs.nvidia.com/deeplearning/nccl/user-guide/docs/index.html) एक संचार फ्रेमवर्क है जिसका उपयोग
`PyTorch` वितरित प्रशिक्षण/इन्फेरेंस के लिए करता है। `text-generation-inference` 
`NCCL` का उपयोग टेन्सर पैरेललिज्म को सक्षम करने के लिए करता है ताकि बड़े भाषा मॉडलों के लिए इन्फेरेंस को नाटकीय रूप से तेज़ किया जा सके।

`NCCL` समूह के विभिन्न उपकरणों के बीच डेटा साझा करने के लिए, यदि NVLink या PCI का उपयोग करते हुए पीयर-टू-पीयर संभव नहीं है, तो `NCCL` होस्ट मेमोरी का उपयोग कर सकता है।

कंटेनर को 1G शेयरड मेमोरी का उपयोग करने की अनुमति देने और SHM शेयरिंग का समर्थन करने के लिए, ऊपर के कमांड में `--shm-size 1g` जोड़ा गया है।

यदि आप `text-generation-inference` को `Kubernetes` के अंदर चला रहे हैं, तो आप कंटेनर में शेयरड मेमोरी जोड़ सकते हैं
एक वॉल्यूम बनाकर:

```yaml
- name: shm
  emptyDir:
   medium: Memory
   sizeLimit: 1Gi
```

और इसे `/dev/shm` पर माउंट करें।

अंत में, आप `NCCL_SHM_DISABLE=1` पर्यावरण चर का उपयोग करके SHM शेयरिंग को भी अक्षम कर सकते हैं। हालांकि, ध्यान दें कि इससे प्रदर्शन प्रभावित होगा।

### डिस्ट्रिब्यूटेड ट्रेसिंग

`text-generation-inference` OpenTelemetry का उपयोग करके डिस्ट्रिब्यूटेड ट्रेसिंग के साथ इंस्ट्रूमेंट किया गया है। आप इस फीचर का उपयोग `--otlp-endpoint` आर्गुमेंट के साथ OTLP कलेक्टर के पते को सेट करके कर सकते हैं। डिफ़ॉल्ट सेवा नाम को `--otlp-service-name` आर्गुमेंट के साथ ओवरराइड किया जा सकता है।

### आर्किटेक्चर

![TGI architecture](https://raw.githubusercontent.com/huggingface/text-generation-inference/main/docs/images/TGI.png)

TGI के अंदरूनी कामकाज पर Adyen द्वारा विस्तृत ब्लॉगपोस्ट: [LLM inference at scale with TGI (Martin Iglesias Goyanes - Adyen, 2024)](https://www.adyen.com/knowledge-hub/llm-inference-at-scale-with-tgi)

### लोकल इंस्टॉल

आप `text-generation-inference` को लोकल रूप से भी इंस्टॉल कर सकते हैं।

सबसे पहले रिपॉजिटरी क्लोन करें और उसमें डिरेक्टरी बदलें:
```shell
git clone https://github.com/huggingface/text-generation-inference
cd text-generation-inference
```

फिर [Rust इंस्टॉल करें](https://rustup.rs/) और कम से कम Python 3.9 के साथ एक Python वर्चुअल वातावरण बनाएं, जैसे `conda` या `python venv` का उपयोग करके:

```shell
curl --proto '=https' --tlsv1.2 -sSf https://sh.rustup.rs | sh

# conda का उपयोग करते हुए
conda create -n text-generation-inference python=3.11
conda activate text-generation-inference

# python venv का उपयोग करते हुए
python3 -m venv .venv
source .venv/bin/activate
```

आपको Protoc भी इंस्टॉल करना पड़ सकता है।

Linux पर:

```shell
PROTOC_ZIP=protoc-21.12-linux-x86_64.zip
curl -OL https://github.com/protocolbuffers/protobuf/releases/download/v21.12/$PROTOC_ZIP
sudo unzip -o $PROTOC_ZIP -d /usr/local bin/protoc
sudo unzip -o $PROTOC_ZIP -d /usr/local 'include/*'
rm -f $PROTOC_ZIP
```

MacOS पर, Homebrew का उपयोग करते हुए:

```shell
brew install protobuf
```

फिर चलाएं:

```shell
BUILD_EXTENSIONS=True make install # रिपॉजिटरी और HF/transformer फोर्क को CUDA कर्नेल्स के साथ इंस्टॉल करें
text-generation-launcher --model-id mistralai/Mistral-7B-Instruct-v0.2
```

**नोट:** कुछ मशीनों पर आपको OpenSSL लाइब्रेरी और gcc की आवश्यकता हो सकती है। Linux मशीनों पर चलाएं:

```shell
sudo apt-get install libssl-dev gcc -y
```

### स्थानीय इंस्टाल (Nix)

एक अन्य विकल्प है `text-generation-inference` को स्थानीय रूप से [Nix](https://nixos.org) का उपयोग करके इंस्टॉल करना। वर्तमान में,
हम केवल x86_64 Linux पर CUDA GPUs के साथ Nix का समर्थन करते हैं। Nix का उपयोग करते समय, सभी निर्भरताएँ
बाइनरी कैश से खींची जा सकती हैं, जिससे उन्हें स्थानीय रूप से बनाने की आवश्यकता समाप्त हो जाती है।

सबसे पहले [Cachix इंस्टॉल करें और Hugging Face कैश सक्षम करें](https://app.cachix.org/cache/huggingface)।
कैश सेटअप करना महत्वपूर्ण है, अन्यथा Nix कई निर्भरताओं को स्थानीय रूप से बनाएगा,
जिसमें कई घंटे लग सकते हैं।

इसके बाद आप TGI को `nix run` के साथ चला सकते हैं:

```shell
cd text-generation-inference
nix run --extra-experimental-features nix-command --extra-experimental-features flakes . -- --model-id meta-llama/Llama-3.1-8B-Instruct
```

**नोट:** जब आप गैर-NixOS सिस्टम पर Nix का उपयोग कर रहे हों, तो आपको CUDA ड्राइवर लाइब्रेरीज़ को
Nix पैकेजों के लिए दिखाई देने योग्य बनाने के लिए [कुछ सिमलिंक्स बनानी होती हैं](https://danieldk.eu/Nix-CUDA-on-non-NixOS-systems#make-runopengl-driverlib-and-symlink-the-driver-library)।

TGI विकास के लिए, आप `impure` dev शेल का उपयोग कर सकते हैं:

```shell
nix develop .#impure

# केवल पहली बार devshell शुरू करने पर या protobuf अपडेट करने के बाद आवश्यक है।
(
cd server
mkdir text_generation_server/pb || true
python -m grpc_tools.protoc -I../proto/v3 --python_out=text_generation_server/pb \
       --grpc_python_out=text_generation_server/pb --mypy_out=text_generation_server/pb ../proto/v3/generate.proto
find text_generation_server/pb/ -type f -name "*.py" -print0 -exec sed -i -e 's/^\(import.*pb2\)/from . \1/g' {} \;
touch text_generation_server/pb/__init__.py
)
```

सभी विकास निर्भरताएँ (cargo, Python, Torch), आदि इस
dev शेल में उपलब्ध हैं।

## अनुकूलित आर्किटेक्चर

TGI सभी आधुनिक मॉडलों के लिए अनुकूलित मॉडल सेवा प्रदान करने के लिए तुरंत काम करता है। ये [इस सूची](https://huggingface.co/docs/text-generation-inference/supported_models) में पाए जा सकते हैं।

अन्य आर्किटेक्चर को सर्वोत्तम प्रयास के आधार पर समर्थन दिया जाता है:

`AutoModelForCausalLM.from_pretrained(<model>, device_map="auto")`

या

`AutoModelForSeq2SeqLM.from_pretrained(<model>, device_map="auto")`



## स्थानीय रूप से चलाएँ

### चलाएँ

```shell
text-generation-launcher --model-id mistralai/Mistral-7B-Instruct-v0.2
```

### क्वांटाइजेशन

आप पूर्व-क्वांटाइज्ड वेट्स (AWQ, GPTQ, Marlin) भी चला सकते हैं या bitsandbytes, EETQ, fp8 के साथ ऑन-द-फ्लाई क्वांटाइजेशन कर सकते हैं, ताकि VRAM की आवश्यकता कम हो:

```shell
text-generation-launcher --model-id mistralai/Mistral-7B-Instruct-v0.2 --quantize
```

4bit क्वांटाइजेशन [bitsandbytes के NF4 और FP4 डेटा टाइप](https://arxiv.org/pdf/2305.14314.pdf) का उपयोग करके उपलब्ध है। इसे `text-generation-launcher` को कमांड लाइन आर्गुमेंट के रूप में `--quantize bitsandbytes-nf4` या `--quantize bitsandbytes-fp4` देकर सक्षम किया जा सकता है।

क्वांटाइजेशन के बारे में अधिक पढ़ें [क्वांटाइजेशन दस्तावेज़](https://huggingface.co/docs/text-generation-inference/en/conceptual/quantization) में।

## विकास करें

```shell
make server-dev
make router-dev
```

## परीक्षण

```shell
# python
make python-server-tests
make python-client-tests
# या सर्वर और क्लाइंट दोनों के टेस्ट
make python-tests
# rust cargo टेस्ट
make rust-tests
# इंटीग्रेशन टेस्ट
make integration-tests
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---