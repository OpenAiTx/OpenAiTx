<img src="https://github.com/user-attachments/assets/47d67430-386d-4675-82ad-d4734d3262d9" width=128 height=128>

# TensorZero

**TensorZero LLM अनुप्रयोगों के अनुकूलन के लिए एक फीडबैक लूप बनाता है — उत्पादन डेटा को और अधिक स्मार्ट, तेज़ और सस्ते मॉडल में बदलता है।**

1. हमारे मॉडल गेटवे को इंटीग्रेट करें
2. मेट्रिक्स या फीडबैक भेजें
3. प्रॉम्प्ट्स, मॉडल्स और इन्फरेंस स्ट्रैटेजीज़ का अनुकूलन करें
4. समय के साथ अपने LLMs को बेहतर होते देखें

यह **LLMs के लिए डाटा एवं लर्निंग फ्लाइवील** प्रदान करता है, जिसमें निम्नलिखित एकीकृत हैं:

- [x] **इन्फरेंस:** सभी LLMs के लिए एक API, <1ms P99 ओवरहेड के साथ
- [x] **ऑब्जर्वेबिलिटी:** इन्फरेंस और फीडबैक → आपके डेटाबेस में
- [x] **अनुकूलन:** प्रॉम्प्ट्स से लेकर फाइन-ट्यूनिंग और RL तक
- [x] **इवैल्यूएशंस:** प्रॉम्प्ट्स, मॉडल्स, इन्फरेंस स्ट्रैटेजीज़ की तुलना करें
- [x] **एक्सपेरिमेंटेशन:** इनबिल्ट A/B टेस्टिंग, रूटिंग, फॉलबैक्स

---

<p align="center">
  <b><a href="https://www.tensorzero.com/" target="_blank">वेबसाइट</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs" target="_blank">डॉक्स</a></b>
  ·
  <b><a href="https://www.x.com/tensorzero" target="_blank">ट्विटर</a></b>
  ·
  <b><a href="https://www.tensorzero.com/slack" target="_blank">स्लैक</a></b>
  ·
  <b><a href="https://www.tensorzero.com/discord" target="_blank">डिस्कॉर्ड</a></b>
  <br>
  <br>
  <b><a href="https://www.tensorzero.com/docs/quickstart" target="_blank">त्वरित प्रारंभ (5 मिनट)</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/tutorial" target="_blank">विस्तृत ट्यूटोरियल</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/deployment" target="_blank">डिप्लॉयमेंट गाइड</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/api-reference" target="_blank">API संदर्भ</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/deployment" target="_blank">कॉन्फ़िगरेशन संदर्भ</a></b>
</p>

---

<table>
  <tr>
    <td width="30%" valign="top"><b>TensorZero क्या है?</b></td>
    <td width="70%" valign="top">TensorZero प्रोडक्शन-ग्रेड LLM अनुप्रयोगों के निर्माण के लिए एक ओपन-सोर्स फ्रेमवर्क है। यह एक LLM गेटवे, ऑब्जर्वेबिलिटी, अनुकूलन, इवैल्यूएशंस और एक्सपेरिमेंटेशन को एकीकृत करता है।</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>TensorZero अन्य LLM फ्रेमवर्क्स से अलग कैसे है?</b></td>
    <td width="70%" valign="top">
      1. TensorZero आपको प्रोडक्शन मेट्रिक्स और मानव फीडबैक के आधार पर जटिल LLM अनुप्रयोगों का अनुकूलन करने में सक्षम बनाता है।<br>
      2. TensorZero उद्योग-स्तरीय LLM अनुप्रयोगों की आवश्यकताओं का समर्थन करता है: कम लेटेंसी, उच्च थ्रूपुट, टाइप सेफ्टी, सेल्फ-होस्टेड, GitOps, कस्टमाइज़ेबिलिटी आदि।<br>
      3. TensorZero पूरे LLMOps स्टैक को एकीकृत करता है, जिससे संयुक्त लाभ मिलते हैं। उदाहरण के लिए, LLM इवैल्यूएशंस को AI जजेज़ के साथ मॉडल्स को फाइन-ट्यून करने के लिए उपयोग किया जा सकता है।
    </td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>क्या मैं TensorZero ___ के साथ उपयोग कर सकता हूँ?</b></td>
    <td width="70%" valign="top">हाँ। हर प्रमुख प्रोग्रामिंग भाषा समर्थित है। आप TensorZero को हमारे Python क्लाइंट, किसी भी OpenAI SDK या हमारे HTTP API के साथ उपयोग कर सकते हैं।</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>क्या TensorZero प्रोडक्शन-रेडी है?</b></td>
    <td width="70%" valign="top">हाँ। यहाँ एक केस स्टडी है: <b><a href="https://www.tensorzero.com/blog/case-study-automating-code-changelogs-at-a-large-bank-with-llms">LLMs के साथ एक बड़े बैंक में कोड चेंज-लॉग्स का ऑटोमेशन</a></b></td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>TensorZero की लागत क्या है?</b></td>
    <td width="70%" valign="top">कुछ भी नहीं। TensorZero 100% सेल्फ-होस्टेड और ओपन-सोर्स है। कोई भी पेड फीचर नहीं है।</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>TensorZero कौन बना रहा है?</b></td>
    <td width="70%" valign="top">हमारी तकनीकी टीम में एक पूर्व Rust कंपाइलर मेंटेनर, मशीन लर्निंग शोधकर्ता (Stanford, CMU, Oxford, Columbia) जिनके हजारों साइटेशन हैं, और एक डेकाकॉर्न स्टार्टअप के चीफ प्रोडक्ट ऑफिसर शामिल हैं। हम उन्हीं निवेशकों द्वारा समर्थित हैं जिन्होंने अग्रणी ओपन-सोर्स प्रोजेक्ट्स (जैसे ClickHouse, CockroachDB) और AI लैब्स (जैसे OpenAI, Anthropic) को समर्थन दिया है।</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>मैं शुरुआत कैसे करूं?</b></td>
    <td width="70%" valign="top">आप TensorZero को धीरे-धीरे अपनाकर प्रयोग कर सकते हैं। हमारा <b><a href="https://www.tensorzero.com/docs/quickstart">त्वरित प्रारंभ</a></b> आपको एक सामान्य OpenAI रैपर से एक प्रोडक्शन-रेडी LLM एप्लिकेशन तक केवल 5 मिनट में ले जाता है, जिसमें ऑब्जर्वेबिलिटी और फाइन-ट्यूनिंग भी शामिल है।</td>
  </tr>
</table>

---

## विशेषताएँ

### 🌐 LLM गेटवे

> **TensorZero के साथ एक बार इंटीग्रेट करें और हर प्रमुख LLM प्रोवाइडर को एक्सेस करें।**

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>मॉडल प्रदाता</b></td>
    <td width="50%" align="center" valign="middle"><b>विशेषताएँ</b></td>
  </tr>
  <tr>
    <td width="50%" align="left" valign="top">
      <p>
        TensorZero Gateway द्वारा नेटिव रूप से समर्थित:
      </p>
      <ul>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/anthropic">Anthropic</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/aws-bedrock">AWS Bedrock</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/aws-sagemaker">AWS SageMaker</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/azure">Azure OpenAI Service</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/deepseek">DeepSeek</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/fireworks">Fireworks</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/gcp-vertex-ai-anthropic">GCP Vertex AI Anthropic</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/gcp-vertex-ai-gemini">GCP Vertex AI Gemini</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/google-ai-studio-gemini">Google AI Studio (Gemini API)</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/hyperbolic">Hyperbolic</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/mistral">Mistral</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/openai">OpenAI</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/together">Together</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/vllm">vLLM</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/xai">xAI</a></b></li>
      </ul>
      <p>
        <em>
          कुछ और चाहिए?
          आपका प्रोवाइडर शायद समर्थित है क्योंकि TensorZero <b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/openai-compatible">किसी भी OpenAI-संगत API (जैसे Ollama)</a></b> के साथ इंटीग्रेट करता है।
          </em>
      </p>
    </td>
    <td width="50%" align="left" valign="top">
      <p>
        TensorZero Gateway उन्नत विशेषताओं को सपोर्ट करता है, जैसे:
      </p>
      <ul>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/retries-fallbacks">रीट्राईज और फॉलबैक्स</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations">इन्फरेंस-टाइम ऑप्टिमाइजेशन</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/prompt-templates-schemas">प्रॉम्प्ट टेम्पलेट्स और स्कीमा</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/tutorial#experimentation">एक्सपेरिमेंटेशन (A/B टेस्टिंग)</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/configuration-reference">कॉनफिगरेशन-एज़-कोड (GitOps)</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/batch-inference">बैच इन्फरेंस</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/multimodal-inference">मल्टीमॉडल इन्फरेंस (VLMs)</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-caching">इन्फरेंस कैशिंग</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/metrics-feedback">मेट्रिक्स और फीडबैक</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/episodes">मल्टी-स्टेप LLM वर्कफ्लो (एपिसोड्स)</a></b></li>
        <li><em>और भी बहुत कुछ...</em></li>
      </ul>
      <p>
        TensorZero Gateway Rust 🦀 में <b>प्रदर्शन</b> को ध्यान में रखकर लिखा गया है (&lt;1ms p99 लेटेंसी ओवरहेड @ 10k QPS)।
        देखें <b><a href="https://www.tensorzero.com/docs/gateway/benchmarks">बेंचमार्क्स</a></b>।<br>
      </p>
      <p>
        आप <b>TensorZero क्लाइंट</b> (अनुशंसित), <b>OpenAI क्लाइंट</b> या <b>HTTP API</b> का उपयोग करके इन्फरेंस चला सकते हैं।
      </p>
    </td>
  </tr>
</table>

<br>

<details open>
<summary><b>उपयोग: Python &mdash; TensorZero क्लाइंट (अनुशंसित)</b></summary>

आप TensorZero Python क्लाइंट का उपयोग करके किसी भी प्रोवाइडर को एक्सेस कर सकते हैं।

1. `pip install tensorzero`
2. वैकल्पिक: TensorZero कॉन्फ़िगरेशन सेट करें।
3. इन्फरेंस चलाएँ:

```python
from tensorzero import TensorZeroGateway  # या AsyncTensorZeroGateway


with TensorZeroGateway.build_embedded(clickhouse_url="...", config_file="...") as client:
    response = client.inference(
        model_name="openai::gpt-4o-mini",
        # अन्य प्रोवाइडर आज़माएँ: "anthropic::claude-3-7-sonnet-20250219"
        input={
            "messages": [
                {
                    "role": "user",
                    "content": "कृत्रिम बुद्धिमत्ता पर एक हाइकू लिखें।",
                }
            ]
        },
    )
```

अधिक जानकारी के लिए देखें **[त्वरित प्रारंभ](https://www.tensorzero.com/docs/quickstart)**।

</details>

<details>
<summary><b>उपयोग: Python &mdash; OpenAI क्लाइंट</b></summary>

आप TensorZero के साथ OpenAI Python क्लाइंट का उपयोग करके किसी भी प्रोवाइडर को एक्सेस कर सकते हैं।

1. `pip install tensorzero`
2. वैकल्पिक: TensorZero कॉन्फ़िगरेशन सेट करें।
3. इन्फरेंस चलाएँ:

```python
from openai import OpenAI  # या AsyncOpenAI
from tensorzero import patch_openai_client

client = OpenAI()
```python
patch_openai_client(
    client,
    clickhouse_url="http://chuser:chpassword@localhost:8123/tensorzero",
    config_file="config/tensorzero.toml",
    async_setup=False,
)

response = client.chat.completions.create(
    model="tensorzero::model_name::openai::gpt-4o-mini",
    # अन्य प्रदाताओं को आसानी से आज़माएँ: "tensorzero::model_name::anthropic::claude-3-7-sonnet-20250219"
    messages=[
        {
            "role": "user",
            "content": "कृत्रिम बुद्धिमत्ता पर एक हाइकू लिखें।",
        }
    ],
)
```

अधिक जानकारी के लिए देखें **[Quick Start](https://www.tensorzero.com/docs/quickstart)**।

</details>

<details>
<summary><b>उपयोग: जावास्क्रिप्ट / टाइपस्क्रिप्ट (Node) &mdash; OpenAI क्लाइंट</b></summary>

आप TensorZero के साथ OpenAI Node क्लाइंट का उपयोग करके किसी भी प्रदाता तक पहुंच सकते हैं।

1. Docker का उपयोग करके `tensorzero/gateway` डिप्लॉय करें।
   **[विस्तृत निर्देश →](https://www.tensorzero.com/docs/gateway/deployment)**
2. TensorZero कॉन्फ़िगरेशन सेट करें।
3. इनफेरेंस चलाएँ:

```ts
import OpenAI from "openai";

const client = new OpenAI({
  baseURL: "http://localhost:3000/openai/v1",
});

const response = await client.chat.completions.create({
  model: "tensorzero::model_name::openai::gpt-4o-mini",
  // अन्य प्रदाताओं को आसानी से आज़माएँ: "tensorzero::model_name::anthropic::claude-3-7-sonnet-20250219"
  messages: [
    {
      role: "user",
      content: "कृत्रिम बुद्धिमत्ता पर एक हाइकू लिखें।",
    },
  ],
});
```

अधिक जानकारी के लिए देखें **[Quick Start](https://www.tensorzero.com/docs/quickstart)**।

</details>

<details>
<summary><b>उपयोग: अन्य भाषाएँ और प्लेटफ़ॉर्म &mdash; HTTP API</b></summary>

TensorZero अपने HTTP API के माध्यम से लगभग किसी भी प्रोग्रामिंग भाषा या प्लेटफ़ॉर्म का समर्थन करता है।

1. Docker का उपयोग करके `tensorzero/gateway` डिप्लॉय करें।
   **[विस्तृत निर्देश →](https://www.tensorzero.com/docs/gateway/deployment)**
2. वैकल्पिक: TensorZero कॉन्फ़िगरेशन सेट करें।
3. इनफेरेंस चलाएँ:

```bash
curl -X POST "http://localhost:3000/inference" \
  -H "Content-Type: application/json" \
  -d '{
    "model_name": "openai::gpt-4o-mini",
    "input": {
      "messages": [
        {
          "role": "user",
          "content": "कृत्रिम बुद्धिमत्ता पर एक हाइकू लिखें।"
        }
      ]
    }
  }'
```

अधिक जानकारी के लिए देखें **[Quick Start](https://www.tensorzero.com/docs/quickstart)**।

</details>

<br>

### 📈 LLM ऑप्टिमाइज़ेशन

> **अपने प्रॉम्प्ट्स, मॉडल्स, और इनफेरेंस स्ट्रैटेजीज़ को आसानी से ऑप्टिमाइज़ करने के लिए प्रोडक्शन मेट्रिक्स और मानव फीडबैक भेजें &mdash; UI या प्रोग्रामेटिक रूप से।**

#### मॉडल ऑप्टिमाइज़ेशन

सुपरवाइज्ड फाइन-ट्यूनिंग (SFT) और प्रेफरेंस फाइन-ट्यूनिंग (DPO) का उपयोग करके बंद-स्रोत और ओपन-सोर्स मॉडल्स को ऑप्टिमाइज़ करें।

<table>
  <tr></tr> <!-- फ्लिप हाइलाइट ऑर्डर -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>सुपरवाइज्ड फाइन-ट्यूनिंग &mdash; UI</b></td>
    <td width="50%" align="center" valign="middle"><b>प्रेफरेंस फाइन-ट्यूनिंग (DPO) &mdash; Jupyter Notebook</b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/cf7acf66-732b-43b3-af2a-5eba1ce40f6f"></td>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/a67a0634-04a7-42b0-b934-9130cb7cdf51"></td>
  </tr>
</table>

#### इनफेरेंस-टाइम ऑप्टिमाइज़ेशन

अपने प्रॉम्प्ट्स को उपयुक्त उदाहरणों के साथ डायनामिक रूप से अपडेट करके, कई इनफेरेंस से प्रतिक्रियाओं को मिलाकर, और भी बहुत कुछ करके प्रदर्शन को बेहतर बनाएं।

<table>
  <tr></tr> <!-- फ्लिप हाइलाइट ऑर्डर -->
  <tr>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#best-of-n-sampling">Best-of-N Sampling</a></b></td>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#mixture-of-n-sampling">Mixture-of-N Sampling</a></b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/c0edfa4c-713c-4996-9964-50c0d26e6970"></td>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/75b5bf05-4c1f-43c4-b158-d69d1b8d05be"></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#dynamic-in-context-learning-dicl">Dynamic In-Context Learning (DICL)</a></b></td>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#chain-of-thought-cot">Chain-of-Thought (CoT)</a></b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/d8489e92-ce93-46ac-9aab-289ce19bb67d"></td>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/ea13d73c-76a4-4e0c-a35b-0c648f898311" height="320"></td>
  </tr>
</table>

_और जल्द आ रहा है..._

<br>

#### प्रॉम्प्ट ऑप्टिमाइज़ेशन

अनुसंधान-आधारित ऑप्टिमाइज़ेशन तकनीकों का उपयोग करके अपने प्रॉम्प्ट्स को प्रोग्रामेटिक रूप से ऑप्टिमाइज़ करें।

<table>
  <tr></tr> <!-- फ्लिप हाइलाइट ऑर्डर -->
  <tr>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#best-of-n-sampling">MIPROv2</a></b></td>
    <td width="50%" align="center" valign="middle"><b><a href="https://github.com/tensorzero/tensorzero/tree/main/examples/gsm8k-custom-recipe-dspy">DSPy इंटीग्रेशन</a></b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/d81a7c37-382f-4c46-840f-e6c2593301db" alt="MIPROv2 diagram"></td>
    <td width="50%" align="center" valign="middle">
      TensorZero कई ऑप्टिमाइज़ेशन रेसिपीज़ के साथ आता है, लेकिन आप अपनी खुद की भी आसानी से बना सकते हैं।
      यह उदाहरण दिखाता है कि कैसे एक मनचाहे टूल — यहाँ, DSPy, जो ऑटोमेटेड प्रॉम्प्ट इंजीनियरिंग के लिए लोकप्रिय लाइब्रेरी है — का उपयोग कर TensorZero फ़ंक्शन को ऑप्टिमाइज़ किया जा सकता है।
    </td>
  </tr>
</table>

_और जल्द आ रहा है..._

<br>

### 🔍 LLM ऑब्ज़र्वेबिलिटी

> **व्यक्तिगत API कॉल्स को डीबग करने के लिए ज़ूम इन करें, या समय के साथ विभिन्न मॉडल्स और प्रॉम्प्ट्स पर मेट्रिक्स की निगरानी के लिए ज़ूम आउट करें &mdash; यह सब ओपन-सोर्स TensorZero UI से।**

<table>
  <tr></tr> <!-- फ्लिप हाइलाइट ऑर्डर -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>ऑब्ज़र्वेबिलिटी » इनफेरेंस</b></td>
    <td width="50%" align="center" valign="middle"><b>ऑब्ज़र्वेबिलिटी » फ़ंक्शन</b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/2cc3cc9a-f33f-4e94-b8de-07522326f80a"></td>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/00ae6605-8fa0-4efd-8238-ae8ea589860f"></td>
  </tr>
</table>

<br>

### 📊 LLM मूल्यांकन

> **TensorZero Evaluations का उपयोग करके प्रॉम्प्ट्स, मॉडल्स और इनफेरेंस स्ट्रैटेजीज़ की तुलना करें &mdash; heuristic और LLM जज सपोर्ट के साथ।**

<table>
  <tr></tr> <!-- फ्लिप हाइलाइट ऑर्डर -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>मूल्यांकन » UI</b></td>
    <td width="50%" align="center" valign="middle"><b>मूल्यांकन » CLI</b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/f4bf54e3-1b63-46c8-be12-2eaabf615699"></td>
    <td width="50%" align="left" valign="middle">
<pre><code class="language-bash">docker compose run --rm evaluations \
  --evaluation-name extract_data \
  --dataset-name hard_test_cases \
  --variant-name gpt_4o \
  --concurrency 5</code></pre>
<pre><code class="language-bash">Run ID: 01961de9-c8a4-7c60-ab8d-15491a9708e4
Number of datapoints: 100
██████████████████████████████████████ 100/100
exact_match: 0.83 ± 0.03
```
semantic_match: 0.98 ± 0.01  
item_count: 7.15 ± 0.39</code></pre>
    </td>
  </tr>
</table>

## डेमो

> **TensorZero के साथ LLMs को डेटा एक्सट्रैक्शन में रियल-टाइम में बेहतर होते हुए देखें!**
>
> **[डायनामिक इन-कॉन्टेक्स्ट लर्निंग (DICL)](https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#dynamic-in-context-learning-dicl)** TensorZero के साथ डिफ़ॉल्ट रूप से उपलब्ध एक शक्तिशाली इन्फरेंस-टाइम ऑप्टिमाइज़ेशन है।
> यह मॉडल फाइन-ट्यूनिंग की आवश्यकता के बिना, प्रॉम्प्ट में प्रासंगिक ऐतिहासिक उदाहरणों को स्वतः शामिल करके LLM प्रदर्शन को बेहतर बनाता है।

https://github.com/user-attachments/assets/4df1022e-886e-48c2-8f79-6af3cdad79cb

## TensorZero के साथ LLM इंजीनियरिंग

<br>
<p align="center" >
  <a href="https://www.tensorzero.com/docs">
    <picture>
      <source media="(prefers-color-scheme: light)" srcset="https://github.com/user-attachments/assets/34a92c18-242e-4d76-a99c-861283de68a6">
      <source media="(prefers-color-scheme: dark)" srcset="https://github.com/user-attachments/assets/e8bc699b-6378-4c2a-9cc1-6d189025e270">
      <img alt="TensorZero Flywheel" src="https://github.com/user-attachments/assets/34a92c18-242e-4d76-a99c-861283de68a6" width=720>
    </picture>
  </a>
</p>
<br>

1. **[TensorZero गेटवे](https://www.tensorzero.com/docs/gateway/)** एक उच्च-प्रदर्शन मॉडल गेटवे है, जो Rust 🦀 में लिखा गया है और सभी प्रमुख LLM प्रदाताओं के लिए एकीकृत API इंटरफेस प्रदान करता है, जिससे निर्बाध क्रॉस-प्लेटफ़ॉर्म इंटीग्रेशन और फॉलबैक्स संभव होते हैं।
2. यह संरचित स्कीमा-आधारित इन्फरेंस को <1ms P99 लेटेंसी ओवरहेड (देखें **[Benchmarks](https://www.tensorzero.com/docs/gateway/benchmarks)**) और बिल्ट-इन ऑब्जर्वेबिलिटी, एक्सपेरिमेंटेशन, और **[इन्फरेंस-टाइम ऑप्टिमाइज़ेशन](https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations)** के साथ संभालता है।
3. यह इन इन्फरेंस से जुड़े डाउनस्ट्रीम मेट्रिक्स और फीडबैक भी एकत्र करता है, जिसमें मल्टी-स्टेप LLM सिस्टम्स के लिए प्रथम-श्रेणी समर्थन है।
4. सब कुछ एक ClickHouse डेटा वेयरहाउस में संग्रहीत किया जाता है, जिसे आप नियंत्रित करते हैं, रियल-टाइम, स्केलेबल और डेवलपर-फ्रेंडली एनालिटिक्स के लिए।
5. समय के साथ, **[TensorZero रेसिपीज़](https://www.tensorzero.com/docs/recipes)** इस संरचित डेटा सेट का उपयोग आपके प्रॉम्प्ट्स और मॉडलों को ऑप्टिमाइज़ करने के लिए करती हैं: सामान्य वर्कफ़्लोज़ के लिए प्री-बिल्ट रेसिपी चलाएँ जैसे फाइन-ट्यूनिंग, या अपनी खुद की पूरी लचीलापन के साथ किसी भी भाषा और प्लेटफ़ॉर्म का उपयोग करके बनाएं।
6. अंत में, गेटवे की एक्सपेरिमेंटेशन विशेषताएँ और GitOps ऑर्केस्ट्रेशन आपको आत्मविश्वास के साथ इटरट और डिप्लॉय करने में सक्षम बनाती हैं, चाहे वह एकल LLM हो या हजारों LLMs।

हमारा लक्ष्य इंजीनियरों को अगली पीढ़ी के LLM एप्लिकेशन बनाने, प्रबंधित करने और ऑप्टिमाइज़ करने में मदद करना है: ऐसे सिस्टम जो वास्तविक दुनिया के अनुभव से सीखते हैं।  
हमारे बारे में और पढ़ें **[Vision & Roadmap](https://www.tensorzero.com/docs/vision-roadmap/)**।

## शुरुआत करें

**आज ही निर्माण शुरू करें।**  
**[Quick Start](https://www.tensorzero.com/docs/quickstart)** दिखाता है कि TensorZero के साथ LLM एप्लिकेशन सेटअप करना कितना आसान है।  
यदि आप और गहराई में जाना चाहते हैं, तो **[Tutorial](https://www.tensorzero.com/docs/gateway/tutorial)** सिखाता है कि कैसे एक सिंपल चैटबॉट, एक ईमेल कोपायलट, एक वेदर RAG सिस्टम, और एक संरचित डेटा एक्सट्रैक्शन पाइपलाइन बनाएं।

**कोई सवाल है?**  
हमसे पूछें **[Slack](https://www.tensorzero.com/slack)** या **[Discord](https://www.tensorzero.com/discord)** पर।

**क्या आप कार्यस्थल पर TensorZero का उपयोग कर रहे हैं?**  
हमें ईमेल करें **[hello@tensorzero.com](mailto:hello@tensorzero.com)** अपनी टीम के साथ Slack या Teams चैनल सेटअप करने के लिए (फ्री)।

**हमारे साथ काम करें।**  
हम **[NYC में हायर कर रहे हैं](https://www.tensorzero.com/jobs)**।  
हम **[ओपन-सोर्स योगदान](https://github.com/tensorzero/tensorzero/blob/main/CONTRIBUTING.md)** का भी स्वागत करते हैं!

## उदाहरण

हम TensorZero के डेटा और लर्निंग फ्लाईव्हील को दर्शाने वाले **पूरी तरह से चलने योग्य उदाहरणों** की एक श्रृंखला पर काम कर रहे हैं।

> **[TensorZero के साथ डेटा एक्सट्रैक्शन (NER) का ऑप्टिमाइज़ेशन](https://github.com/tensorzero/tensorzero/tree/main/examples/data-extraction-ner)**
>
> यह उदाहरण दिखाता है कि TensorZero का उपयोग करके डेटा एक्सट्रैक्शन पाइपलाइन को कैसे ऑप्टिमाइज़ करें।
> हम फाइन-ट्यूनिंग और डायनामिक इन-कॉन्टेक्स्ट लर्निंग (DICL) जैसी तकनीकों का प्रदर्शन करते हैं।
> अंत में, एक ऑप्टिमाइज़्ड GPT-4o Mini मॉडल इस कार्य पर GPT-4o को पछाड़ देता है — लागत और लेटेंसी का एक अंश उपयोग करते हुए — थोड़े से प्रशिक्षण डेटा के साथ।

> **[एजेंटिक RAG — LLMs के साथ मल्टी-हॉप प्रश्नोत्तर](https://github.com/tensorzero/tensorzero/tree/main/examples/rag-retrieval-augmented-generation/simple-agentic-rag/)**
>
> यह उदाहरण दिखाता है कि TensorZero का उपयोग करके एक मल्टी-हॉप रिट्रीवल एजेंट कैसे बनाएं।
> एजेंट बार-बार विकिपीडिया खोजता है, जानकारी एकत्र करता है, और तय करता है कि कब उसके पास एक जटिल प्रश्न का उत्तर देने के लिए पर्याप्त संदर्भ है।

> **[छिपी प्राथमिकताओं वाले जज को खुश करने के लिए हाइकू लेखन](https://github.com/tensorzero/tensorzero/tree/main/examples/haiku-hidden-preferences)**
>
> यह उदाहरण GPT-4o Mini को एक विशिष्ट स्वाद के अनुसार हाइकू जनरेट करने के लिए फाइन-ट्यून करता है।
> आप TensorZero के "डाटा फ्लाईव्हील इन अ बॉक्स" को एक्शन में देखेंगे: बेहतर वैरिएंट्स से बेहतर डेटा मिलता है, और बेहतर डेटा से बेहतर वैरिएंट्स।
> आप LLM को कई बार फाइन-ट्यून करके प्रगति देखेंगे।

> **[Best-of-N सैंपलिंग के साथ LLM की शतरंज क्षमता में सुधार](https://github.com/tensorzero/tensorzero/tree/main/examples/chess-puzzles/)**
>
> यह उदाहरण दिखाता है कि Best-of-N सैंपलिंग कैसे LLM की शतरंज खेलने की क्षमताओं को कई जेनरेटेड विकल्पों में से सबसे संभावित चालों का चयन करके महत्वपूर्ण रूप से बढ़ा सकता है।

> **[स्वचालित प्रॉम्प्ट इंजीनियरिंग (DSPy) के लिए कस्टम रेसिपी के साथ गणितीय तर्क शक्ति में सुधार](https://github.com/tensorzero/tensorzero/tree/main/examples/gsm8k-custom-recipe-dspy)**
>
> TensorZero सामान्य LLM इंजीनियरिंग वर्कफ़्लोज़ को कवर करने वाली कई प्री-बिल्ट ऑप्टिमाइज़ेशन रेसिपी प्रदान करता है।
> लेकिन आप अपनी खुद की रेसिपी और वर्कफ़्लो भी आसानी से बना सकते हैं!
> यह उदाहरण दिखाता है कि किसी भी टूल — यहाँ, DSPy — का उपयोग करके TensorZero फ़ंक्शन को कैसे ऑप्टिमाइज़ करें।

_और भी बहुत कुछ जल्द आ रहा है!_

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---