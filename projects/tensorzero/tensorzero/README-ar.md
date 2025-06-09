<img src="https://github.com/user-attachments/assets/47d67430-386d-4675-82ad-d4734d3262d9" width=128 height=128>

# TensorZero

**تنشئ TensorZero حلقة تغذية راجعة لتحسين تطبيقات النماذج اللغوية الكبيرة (LLM) — تحويل بيانات الإنتاج إلى نماذج أكثر ذكاءً وسرعة وأقل تكلفة.**

1. دمج بوابة النموذج الخاصة بنا
2. إرسال المقاييس أو التعليقات
3. تحسين التعليمات، النماذج، واستراتيجيات الاستدلال
4. راقب تحسن نماذج LLM الخاصة بك مع الوقت

توفر **حلقة بيانات وتعلم للنماذج اللغوية الكبيرة (LLMs)** من خلال توحيد:

- [x] **الاستدلال:** واجهة برمجية واحدة لجميع نماذج LLM، مع تأخير أقل من 1 مللي ثانية (P99)
- [x] **الرصد:** الاستدلال والتعليقات → قاعدة بياناتك
- [x] **التحسين:** من التعليمات إلى الضبط الدقيق والتعلم المعزز (RL)
- [x] **التقييمات:** مقارنة التعليمات، النماذج، واستراتيجيات الاستدلال
- [x] **التجريب:** اختبارات A/B مدمجة، التوجيه، آليات الاسترجاع

---

<p align="center">
  <b><a href="https://www.tensorzero.com/" target="_blank">الموقع الإلكتروني</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs" target="_blank">التوثيق</a></b>
  ·
  <b><a href="https://www.x.com/tensorzero" target="_blank">تويتر</a></b>
  ·
  <b><a href="https://www.tensorzero.com/slack" target="_blank">سلاك</a></b>
  ·
  <b><a href="https://www.tensorzero.com/discord" target="_blank">ديسكورد</a></b>
  <br>
  <br>
  <b><a href="https://www.tensorzero.com/docs/quickstart" target="_blank">البدء السريع (5 دقائق)</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/tutorial" target="_blank">دليل شامل</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/deployment" target="_blank">دليل النشر</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/api-reference" target="_blank">مرجع واجهة برمجة التطبيقات</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/deployment" target="_blank">مرجع الإعدادات</a></b>
</p>

---

<table>
  <tr>
    <td width="30%" valign="top"><b>ما هو TensorZero؟</b></td>
    <td width="70%" valign="top">TensorZero هو إطار عمل مفتوح المصدر لبناء تطبيقات LLM على مستوى الإنتاج. يوحد بوابة LLM، الرصد، التحسين، التقييمات، والتجريب.</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>كيف يختلف TensorZero عن أطر عمل LLM الأخرى؟</b></td>
    <td width="70%" valign="top">
      1. يتيح لك TensorZero تحسين تطبيقات LLM المعقدة بناءً على مقاييس الإنتاج والتغذية الراجعة البشرية.<br>
      2. يدعم TensorZero احتياجات تطبيقات LLM على المستوى الصناعي: زمن استجابة منخفض، إنتاجية عالية، أمان الأنواع، استضافة ذاتية، GitOps، قابلية التخصيص، وغيرها.<br>
      3. يوحد TensorZero مجموعة عمليات LLMOps بالكامل، مما يخلق فوائد تراكمية. على سبيل المثال، يمكن استخدام تقييمات LLM لضبط النماذج بمساعدة حكام الذكاء الاصطناعي.
    </td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>هل يمكنني استخدام TensorZero مع ___؟</b></td>
    <td width="70%" valign="top">نعم. يتم دعم كل لغات البرمجة الرئيسية. يمكنك استخدام TensorZero مع عميل Python الخاص بنا، أو أي حزمة SDK متوافقة مع OpenAI، أو عبر واجهة HTTP API.</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>هل TensorZero جاهز للإنتاج؟</b></td>
    <td width="70%" valign="top">نعم. إليك دراسة حالة: <b><a href="https://www.tensorzero.com/blog/case-study-automating-code-changelogs-at-a-large-bank-with-llms">أتمتة سجلات تغييرات الشيفرة في بنك كبير باستخدام LLMs</a></b></td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>كم يكلف TensorZero؟</b></td>
    <td width="70%" valign="top">لا شيء. TensorZero مستضاف ذاتيًا ومفتوح المصدر بنسبة 100%. لا توجد ميزات مدفوعة.</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>من يطور TensorZero؟</b></td>
    <td width="70%" valign="top">يضم فريقنا التقني مشرفًا سابقًا على مترجم Rust، وباحثين في التعلم الآلي (ستانفورد، كارنيغي ميلون، أكسفورد، كولومبيا) مع آلاف الاقتباسات، ومسؤول المنتجات الرئيسي لشركة ناشئة بقيمة عشرة مليارات دولار. نحن مدعومون من نفس المستثمرين في مشاريع مفتوحة المصدر رائدة (مثل ClickHouse، CockroachDB) ومختبرات الذكاء الاصطناعي (مثل OpenAI، Anthropic).</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>كيف أبدأ؟</b></td>
    <td width="70%" valign="top">يمكنك اعتماد TensorZero تدريجيًا. دليل <b><a href="https://www.tensorzero.com/docs/quickstart">البدء السريع</a></b> يأخذك من غلاف OpenAI بسيط إلى تطبيق LLM جاهز للإنتاج مع الرصد والضبط الدقيق في 5 دقائق فقط.</td>
  </tr>
</table>

---

## الميزات

### 🌐 بوابة LLM

> **ادمج مع TensorZero مرة واحدة وادخل إلى كل مزودي LLM الرئيسيين.**

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>مزودو النماذج</b></td>
    <td width="50%" align="center" valign="middle"><b>الميزات</b></td>
  </tr>
  <tr>
    <td width="50%" align="left" valign="top">
      <p>
        تدعم بوابة TensorZero بشكل أصلي:
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
          تحتاج إلى شيء آخر؟
          على الأرجح مزودك مدعوم لأن TensorZero يتكامل مع <b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/openai-compatible">أي واجهة برمجة تطبيقات متوافقة مع OpenAI (مثل Ollama)</a></b>.
          </em>
      </p>
    </td>
    <td width="50%" align="left" valign="top">
      <p>
        تدعم بوابة TensorZero ميزات متقدمة مثل:
      </p>
      <ul>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/retries-fallbacks">إعادة المحاولة وآليات الاسترجاع</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations">تحسينات زمن الاستدلال</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/prompt-templates-schemas">قوالب التعليمات والمخططات</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/tutorial#experimentation">التجريب (اختبار A/B)</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/configuration-reference">الإعداد ككود (GitOps)</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/batch-inference">الاستدلال الدفعي</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/multimodal-inference">الاستدلال متعدد الأنماط (VLMs)</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-caching">تخزين الاستدلال المؤقت</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/metrics-feedback">المقاييس والتعليقات</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/episodes">مهام LLM متعددة الخطوات (الحلقات)</a></b></li>
        <li><em>والمزيد...</em></li>
      </ul>
      <p>
        تم كتابة بوابة TensorZero بلغة Rust 🦀 مع التركيز على <b>الأداء</b> (تأخير أقل من 1 مللي ثانية P99 عند 10 آلاف طلب في الثانية).
        راجع <b><a href="https://www.tensorzero.com/docs/gateway/benchmarks">معايير الأداء</a></b>.<br>
      </p>
      <p>
        يمكنك تشغيل الاستدلال باستخدام <b>عميل TensorZero</b> (موصى به)، أو <b>عميل OpenAI</b>، أو <b>واجهة HTTP API</b>.
      </p>
    </td>
  </tr>
</table>

<br>

<details open>
<summary><b>الاستخدام: بايثون &mdash; عميل TensorZero (موصى به)</b></summary>

يمكنك الوصول إلى أي مزود باستخدام عميل TensorZero لبايثون.

1. `pip install tensorzero`
2. اختياري: إعداد تكوين TensorZero.
3. تنفيذ الاستدلال:

```python
from tensorzero import TensorZeroGateway  # أو AsyncTensorZeroGateway


with TensorZeroGateway.build_embedded(clickhouse_url="...", config_file="...") as client:
    response = client.inference(
        model_name="openai::gpt-4o-mini",
        # جرب مزودين آخرين بسهولة: "anthropic::claude-3-7-sonnet-20250219"
        input={
            "messages": [
                {
                    "role": "user",
                    "content": "اكتب هايكو عن الذكاء الاصطناعي.",
                }
            ]
        },
    )
```

راجع **[البدء السريع](https://www.tensorzero.com/docs/quickstart)** للمزيد من المعلومات.

</details>

<details>
<summary><b>الاستخدام: بايثون &mdash; عميل OpenAI</b></summary>

يمكنك الوصول إلى أي مزود باستخدام عميل OpenAI لبايثون مع TensorZero.

1. `pip install tensorzero`
2. اختياري: إعداد تكوين TensorZero.
3. تنفيذ الاستدلال:

```python
from openai import OpenAI  # أو AsyncOpenAI
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
    # جرّب مزودين آخرين بسهولة: "tensorzero::model_name::anthropic::claude-3-7-sonnet-20250219"
    messages=[
        {
            "role": "user",
            "content": "اكتب هايكو عن الذكاء الاصطناعي.",
        }
    ],
)
```

راجع **[البدء السريع](https://www.tensorzero.com/docs/quickstart)** لمزيد من المعلومات.

</details>

<details>
<summary><b>الاستخدام: JavaScript / TypeScript (Node) &mdash; عميل OpenAI</b></summary>

يمكنك الوصول إلى أي مزود باستخدام عميل OpenAI Node مع TensorZero.

1. قم بنشر `tensorzero/gateway` باستخدام Docker.
   **[تعليمات مفصلة →](https://www.tensorzero.com/docs/gateway/deployment)**
2. قم بإعداد إعدادات TensorZero.
3. شغّل الاستدلال:

```ts
import OpenAI from "openai";

const client = new OpenAI({
  baseURL: "http://localhost:3000/openai/v1",
});

const response = await client.chat.completions.create({
  model: "tensorzero::model_name::openai::gpt-4o-mini",
  // جرّب مزودين آخرين بسهولة: "tensorzero::model_name::anthropic::claude-3-7-sonnet-20250219"
  messages: [
    {
      role: "user",
      content: "اكتب هايكو عن الذكاء الاصطناعي.",
    },
  ],
});
```

راجع **[البدء السريع](https://www.tensorzero.com/docs/quickstart)** لمزيد من المعلومات.

</details>

<details>
<summary><b>الاستخدام: لغات ومنصات أخرى &mdash; HTTP API</b></summary>

يدعم TensorZero فعلياً أي لغة برمجة أو منصة عبر HTTP API الخاص به.

1. قم بنشر `tensorzero/gateway` باستخدام Docker.
   **[تعليمات مفصلة →](https://www.tensorzero.com/docs/gateway/deployment)**
2. اختياري: قم بإعداد إعدادات TensorZero.
3. شغّل الاستدلال:

```bash
curl -X POST "http://localhost:3000/inference" \
  -H "Content-Type: application/json" \
  -d '{
    "model_name": "openai::gpt-4o-mini",
    "input": {
      "messages": [
        {
          "role": "user",
          "content": "اكتب هايكو عن الذكاء الاصطناعي."
        }
      ]
    }
  }'
```

راجع **[البدء السريع](https://www.tensorzero.com/docs/quickstart)** لمزيد من المعلومات.

</details>

<br>

### 📈 تحسين النماذج اللغوية الكبيرة (LLM)

> **أرسل مقاييس الإنتاج والتقييم البشري لتحسين مطالباتك ونماذجك واستراتيجيات الاستدلال بسهولة &mdash; باستخدام الواجهة الرسومية أو برمجياً.**

#### تحسين النماذج

قم بتحسين النماذج مغلقة المصدر ومفتوحة المصدر باستخدام التدريب تحت الإشراف (SFT) والتدريب المفضل (DPO).

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>التدريب تحت الإشراف &mdash; واجهة المستخدم</b></td>
    <td width="50%" align="center" valign="middle"><b>التدريب المفضل (DPO) &mdash; Jupyter Notebook</b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/cf7acf66-732b-43b3-af2a-5eba1ce40f6f"></td>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/a67a0634-04a7-42b0-b934-9130cb7cdf51"></td>
  </tr>
</table>

#### تحسين وقت الاستدلال

عزّز الأداء عبر تحديث مطالباتك ديناميكياً بأمثلة ذات صلة، أو دمج الاستجابات من استدلالات متعددة، والمزيد.

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#best-of-n-sampling">أفضل اختيار من N (Best-of-N Sampling)</a></b></td>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#mixture-of-n-sampling">مزيج من N (Mixture-of-N Sampling)</a></b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/c0edfa4c-713c-4996-9964-50c0d26e6970"></td>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/75b5bf05-4c1f-43c4-b158-d69d1b8d05be"></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#dynamic-in-context-learning-dicl">التعلم الديناميكي في السياق (DICL)</a></b></td>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#chain-of-thought-cot">سلسلة الأفكار (CoT)</a></b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/d8489e92-ce93-46ac-9aab-289ce19bb67d"></td>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/ea13d73c-76a4-4e0c-a35b-0c648f898311" height="320"></td>
  </tr>
</table>

_المزيد قادم قريباً..._

<br>

#### تحسين المطالبات

حسّن مطالباتك برمجياً باستخدام تقنيات بحثية متقدمة.

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#best-of-n-sampling">MIPROv2</a></b></td>
    <td width="50%" align="center" valign="middle"><b><a href="https://github.com/tensorzero/tensorzero/tree/main/examples/gsm8k-custom-recipe-dspy">تكامل DSPy</a></b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/d81a7c37-382f-4c46-840f-e6c2593301db" alt="MIPROv2 diagram"></td>
    <td width="50%" align="center" valign="middle">
      يأتي TensorZero مع العديد من وصفات التحسين، كما يمكنك بسهولة إنشاء وصفاتك الخاصة.
      يوضّح هذا المثال كيفية تحسين دالة في TensorZero باستخدام أداة خارجية — هنا، DSPy، مكتبة مشهورة لهندسة المطالبات الآلية.
    </td>
  </tr>
</table>

_المزيد قادم قريباً..._

<br>

### 🔍 مراقبة النماذج اللغوية الكبيرة (LLM Observability)

> **تعمّق لتصحيح نداءات API الفردية، أو راقب المقاييس عبر النماذج والمطالبات مع مرور الوقت &mdash; كل ذلك باستخدام واجهة TensorZero مفتوحة المصدر.**

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>المراقبة » الاستدلال</b></td>
    <td width="50%" align="center" valign="middle"><b>المراقبة » الدالة</b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/2cc3cc9a-f33f-4e94-b8de-07522326f80a"></td>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/00ae6605-8fa0-4efd-8238-ae8ea589860f"></td>
  </tr>
</table>

<br>

### 📊 تقييمات النماذج اللغوية الكبيرة

> **قارن المطالبات والنماذج واستراتيجيات الاستدلال باستخدام تقييمات TensorZero &mdash; مع دعم للمعايير والحكام من النماذج اللغوية الكبيرة.**

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>التقييم » واجهة المستخدم</b></td>
    <td width="50%" align="center" valign="middle"><b>التقييم » سطر الأوامر (CLI)</b></td>
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

## العرض التوضيحي

> **شاهد نماذج اللغة الكبيرة (LLMs) تتحسن في استخراج البيانات في الوقت الفعلي مع TensorZero!**
>
> **[التعلم الديناميكي داخل السياق (DICL)](https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#dynamic-in-context-learning-dicl)** هو تحسين قوي لأداء الاستدلال متوفر مباشرة في TensorZero.
> يعزز أداء نماذج اللغة الكبيرة من خلال دمج أمثلة تاريخية ذات صلة تلقائيًا في الموجه، دون الحاجة إلى إعادة ضبط النموذج (fine-tuning).

https://github.com/user-attachments/assets/4df1022e-886e-48c2-8f79-6af3cdad79cb

## هندسة النماذج اللغوية مع TensorZero

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

1. **[بوابة TensorZero](https://www.tensorzero.com/docs/gateway/)** هي بوابة نماذج عالية الأداء مكتوبة بلغة Rust 🦀 وتوفر واجهة برمجة تطبيقات موحدة لجميع مزودي نماذج اللغة الكبيرة الرئيسيين، مما يسمح بتكامل سلس بين المنصات المختلفة ودعم التبديل التلقائي عند الحاجة.
2. تتعامل مع الاستدلال القائم على المخطط المهيكل مع زمن تأخير أقل من 1 مللي ثانية في المئين 99 (انظر **[الاختبارات المعيارية](https://www.tensorzero.com/docs/gateway/benchmarks)**) وتوفر المراقبة المدمجة والتجريب و**[تحسينات وقت الاستدلال](https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations)**.
3. تجمع أيضًا مقاييس وردود فعل مرتبطة بهذه الاستدلالات، مع دعم من الدرجة الأولى لأنظمة النماذج اللغوية متعددة الخطوات.
4. يتم تخزين كل شيء في مستودع بيانات ClickHouse تتحكم فيه أنت، لتحليلات فورية وقابلة للتطوير وصديقة للمطورين.
5. مع مرور الوقت، **[وصفات TensorZero](https://www.tensorzero.com/docs/recipes)** تستفيد من مجموعة البيانات المهيكلة هذه لتحسين الموجهات والنماذج الخاصة بك: شغّل وصفات جاهزة لسير العمل الشائع مثل إعادة ضبط النموذج، أو أنشئ وصفاتك الخاصة بمرونة تامة باستخدام أي لغة وأي منصة.
6. أخيرًا، تتيح ميزات التجريب في البوابة وأتمتة GitOps لك التكرار والنشر بثقة، سواء كان لديك نموذج واحد أو آلاف النماذج.

هدفنا هو مساعدة المهندسين على بناء وإدارة وتحسين الجيل القادم من تطبيقات النماذج اللغوية الكبيرة: أنظمة تتعلم من الخبرة الواقعية.
اقرأ المزيد حول **[رؤيتنا وخارطة الطريق](https://www.tensorzero.com/docs/vision-roadmap/)**.

## ابدأ الآن

**ابدأ بالبناء اليوم.**
يوضح **[دليل البدء السريع](https://www.tensorzero.com/docs/quickstart)** مدى سهولة إعداد تطبيق يعتمد على نموذج لغوي باستخدام TensorZero.
إذا كنت ترغب في التعمق أكثر، **[الدليل التعليمي](https://www.tensorzero.com/docs/gateway/tutorial)** يعلمك كيفية بناء روبوت دردشة بسيط، ومساعد للبريد الإلكتروني، ونظام استرجاع معلومات الطقس (RAG)، وخط أنابيب لاستخراج البيانات المهيكلة.

**هل لديك أسئلة؟**
تواصل معنا عبر **[Slack](https://www.tensorzero.com/slack)** أو **[Discord](https://www.tensorzero.com/discord)**.

**هل تستخدم TensorZero في العمل؟**
راسلنا عبر البريد الإلكتروني على **[hello@tensorzero.com](mailto:hello@tensorzero.com)** لإنشاء قناة Slack أو Teams مع فريقك (مجاني).

**انضم إلينا.**
نحن **[نوظف في نيويورك](https://www.tensorzero.com/jobs)**.
ونرحب أيضًا **[بالمساهمات مفتوحة المصدر](https://github.com/tensorzero/tensorzero/blob/main/CONTRIBUTING.md)**!

## أمثلة

نعمل على سلسلة من **الأمثلة الكاملة القابلة للتنفيذ** التي توضح دورة البيانات والتعلم في TensorZero.

> **[تحسين استخراج البيانات (NER) باستخدام TensorZero](https://github.com/tensorzero/tensorzero/tree/main/examples/data-extraction-ner)**
>
> يوضح هذا المثال كيفية استخدام TensorZero لتحسين خط أنابيب استخراج البيانات.
> نستعرض تقنيات مثل إعادة ضبط النموذج والتعلم الديناميكي داخل السياق (DICL).
> في النهاية، يتفوق نموذج GPT-4o Mini المحسّن على GPT-4o في هذه المهمة — بجزء بسيط من التكلفة والزمن — باستخدام كمية قليلة من بيانات التدريب.

> **[عامل RAG — الإجابة متعددة الخطوات على الأسئلة باستخدام النماذج اللغوية الكبيرة](https://github.com/tensorzero/tensorzero/tree/main/examples/rag-retrieval-augmented-generation/simple-agentic-rag/)**
>
> يوضح هذا المثال كيفية بناء عامل استرجاع متعدد الخطوات باستخدام TensorZero.
> يبحث العامل بشكل تكراري في ويكيبيديا لجمع المعلومات، ويقرر متى يكون لديه سياق كافٍ للإجابة عن سؤال معقد.

> **[كتابة الهايكو لإرضاء قاضٍ بتفضيلات مخفية](https://github.com/tensorzero/tensorzero/tree/main/examples/haiku-hidden-preferences)**
>
> في هذا المثال نقوم بضبط نموذج GPT-4o Mini لإنتاج قصائد هايكو مخصصة لذوق معين.
> سترى دورة بيانات TensorZero الفريدة قيد التنفيذ: تحسين المتغيرات يؤدي إلى بيانات أفضل، والبيانات الأفضل تؤدي إلى متغيرات أفضل.
> سترى التقدم من خلال إعادة ضبط النموذج عدة مرات.

> **[تحسين قدرة النماذج على لعب الشطرنج باستخدام أخذ عينات أفضل-N](https://github.com/tensorzero/tensorzero/tree/main/examples/chess-puzzles/)**
>
> يوضح هذا المثال كيف يمكن أن تعزز تقنية أخذ عينات أفضل-N بشكل كبير من قدرات النماذج على لعب الشطرنج عن طريق اختيار التحركات الأكثر وعدًا من بين عدة خيارات مولدة.

> **[تحسين الاستدلال الرياضي مع وصفة مخصصة لهندسة الموجهات الآلية (DSPy)](https://github.com/tensorzero/tensorzero/tree/main/examples/gsm8k-custom-recipe-dspy)**
>
> يوفر TensorZero عددًا من وصفات التحسين الجاهزة التي تغطي سير العمل الشائع في هندسة النماذج.
> لكن يمكنك أيضًا بسهولة إنشاء وصفاتك وسير العمل الخاصة!
> يوضح هذا المثال كيفية تحسين وظيفة TensorZero باستخدام أي أداة — هنا، DSPy.

_والمزيد في الطريق!_

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---