<p align="right">
   <strong>الإنجليزية</strong> | <a href="./.github/README.cn.md">中文</a> | <a href="./.github/README.jp.md">日本語</a>
</p>

<div align="center">

<a href="https://portkey.sh/report-github"><img src="https://raw.githubusercontent.com/siddharthsambharia-portkey/Portkey-Product-Images/refs/heads/main/LLM%20Report%20Campaign%20Frame.png"></img></a>
<br>

# بوابة الذكاء الاصطناعي
#### الوصول إلى أكثر من 250 نموذج لغوي كبير عبر واجهة برمجة تطبيقات واحدة سريعة وودودة

<img src="https://cfassets.portkey.ai/sdk.gif" width="550px" alt="عرض توضيحي لبوابة Portkey AI يعرض إمكانيات توجيه النماذج اللغوية" style="margin-left:-35px">

[المستندات](https://portkey.wiki/gh-1) | [الشركات](https://portkey.wiki/gh-2) | [بوابة مستضافة](https://portkey.wiki/gh-3) | [سجل التغييرات](https://portkey.wiki/gh-4) | [مرجع API](https://portkey.wiki/gh-5)


[![License](https://img.shields.io/github/license/Ileriayo/markdown-badges)](./LICENSE)
[![Discord](https://img.shields.io/discord/1143393887742861333)](https://portkey.wiki/gh-6)
[![Twitter](https://img.shields.io/twitter/url/https/twitter/follow/portkeyai?style=social&label=Follow%20%40PortkeyAI)](https://portkey.wiki/gh-7)
[![npm version](https://badge.fury.io/js/%40portkey-ai%2Fgateway.svg)](https://portkey.wiki/gh-8)
[![Better Stack Badge](https://uptime.betterstack.com/status-badges/v1/monitor/q94g.svg)](https://portkey.wiki/gh-9)

<a href="https://us-east-1.console.aws.amazon.com/cloudformation/home?region=us-east-1#/stacks/quickcreate?stackName=portkey-gateway&templateURL=https://portkey-gateway-ec2-quicklaunch.s3.us-east-1.amazonaws.com/portkey-gateway-ec2-quicklaunch.template.yaml"><img src="https://img.shields.io/badge/Deploy_to_EC2-232F3E?style=for-the-badge&logo=amazonwebservices&logoColor=white" alt="النشر على AWS EC2" width="105"/></a> [![اسأل DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/Portkey-AI/gateway)
</div>

<br/>

[**بوابة الذكاء الاصطناعي**](https://portkey.wiki/gh-10) مصممة لتوفير توجيه سريع وموثوق وآمن إلى أكثر من 1600 نموذج للغة والرؤية والصوت والصورة. إنها حل مفتوح المصدر وخفيف الوزن وجاهز للمؤسسات، يتيح لك التكامل مع أي نموذج لغوي في أقل من دقيقتين.

- [x] **سريعة جدًا** (أقل من 1 مللي ثانية تأخير) وبحجم صغير (122 كيلوبايت)
- [x] **مختبرة ومجربة**، مع معالجة أكثر من 10 مليارات رمز يوميًا
- [x] **جاهزة للمؤسسات** مع أمان معزز، قابلية توسع، ونشر مخصص

<br>

#### ماذا يمكنك أن تفعل مع بوابة الذكاء الاصطناعي؟
- التكامل مع أي نموذج لغوي في أقل من دقيقتين - [البدء السريع](#quickstart-2-mins)
- منع التوقفات من خلال **[إعادة المحاولة التلقائية](https://portkey.wiki/gh-11)** و **[خطط الاسترجاع](https://portkey.wiki/gh-12)**
- توسعة تطبيقات الذكاء الاصطناعي باستخدام **[موازنة الأحمال](https://portkey.wiki/gh-13)** و **[التوجيه الشرطي](https://portkey.wiki/gh-14)**
- حماية نشرات الذكاء الاصطناعي الخاصة بك من خلال **[قواعد الحماية](https://portkey.wiki/gh-15)**
- تجاوز النص باستخدام **[إمكانيات متعددة الوسائط](https://portkey.wiki/gh-16)**
- أخيرًا، استكشاف تكاملات **[سير العمل الذكي](https://portkey.wiki/gh-17)**

<br><br>

> [!TIP]
> إضافة نجمة لهذا المستودع يساعد المزيد من المطورين على اكتشاف بوابة الذكاء الاصطناعي 🙏🏻
>
> ![star-2](https://github.com/user-attachments/assets/53597dce-6333-4ecc-a154-eb05532954e4)
> 
<br>


<br>

## البدء السريع (2 دقيقة)

### 1. إعداد بوابة الذكاء الاصطناعي الخاصة بك

```bash
# تشغيل البوابة محليًا (يتطلب Node.js و npm)
npx @portkey-ai/gateway
```
> البوابة تعمل على `http://localhost:8787/v1`
> 
> وحدة تحكم البوابة تعمل على `http://localhost:8787/public/`

<sup>
أدلة النشر:
&nbsp; <a href="https://portkey.wiki/gh-18"><img height="12" width="12" src="https://cfassets.portkey.ai/logo/dew-color.svg" /> سحابة Portkey (موصى بها)</a>
&nbsp; <a href="./docs/installation-deployments.md#docker"><img height="12" width="12" src="https://cdn.simpleicons.org/docker/3776AB" /> دوكر</a>
&nbsp; <a href="./docs/installation-deployments.md#nodejs-server"><img height="12" width="12" src="https://cdn.simpleicons.org/node.js/3776AB" /> Node.js</a>
&nbsp; <a href="./docs/installation-deployments.md#cloudflare-workers"><img height="12" width="12" src="https://cdn.simpleicons.org/cloudflare/3776AB" /> كلاودفلير</a>
&nbsp; <a href="./docs/installation-deployments.md#replit"><img height="12" width="12" src="https://cdn.simpleicons.org/replit/3776AB" /> ريبليت</a>
&nbsp; <a href="./docs/installation-deployments.md"> أخرى...</a>

</sup>

### 2. إرسال أول طلب

<!-- <details open>
<summary>مثال بايثون</summary> -->
```python
# pip install -qU portkey-ai

from portkey_ai import Portkey

# عميل متوافق مع OpenAI
client = Portkey(
    provider="openai", # أو 'anthropic'، 'bedrock'، 'groq'، إلخ
    Authorization="sk-***" # مفتاح API الخاص بالمزود
)

# إرسال طلب عبر بوابة الذكاء الاصطناعي الخاصة بك
client.chat.completions.create(
    messages=[{"role": "user", "content": "كيف هو الطقس اليوم؟"}],
    model="gpt-4o-mini"
)
```



<sup>المكتبات المدعومة:
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/javascript/3776AB" /> جافاسكريبت](https://portkey.wiki/gh-19)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/python/3776AB" /> بايثون](https://portkey.wiki/gh-20)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/gnubash/3776AB" /> REST](https://portkey.sh/gh-84)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/openai/3776AB" /> حزم OpenAI](https://portkey.wiki/gh-21)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/langchain/3776AB" /> Langchain](https://portkey.wiki/gh-22)
&nbsp; [LlamaIndex](https://portkey.wiki/gh-23)
&nbsp; [Autogen](https://portkey.wiki/gh-24)
&nbsp; [CrewAI](https://portkey.wiki/gh-25)
&nbsp; [المزيد..](https://portkey.wiki/gh-26)
</sup>

في وحدة تحكم البوابة (`http://localhost:8787/public/`) يمكنك رؤية جميع سجلاتك المحلية في مكان واحد.

<img src="https://github.com/user-attachments/assets/362bc916-0fc9-43f1-a39e-4bd71aac4a3a" width="400" />


### 3. التوجيه وقواعد الحماية
تسمح لك `الإعدادات` في بوابة النماذج اللغوية بإنشاء قواعد توجيه، إضافة الاعتمادية، وإعداد قواعد الحماية.
```python
config = {
  "retry": {"attempts": 5},

  "output_guardrails": [{
    "default.contains": {"operator": "none", "words": ["Apple"]},
    "deny": True
  }]
}

# إرفاق الإعدادات بالعميل
client = client.with_options(config=config)

client.chat.completions.create(
    model="gpt-4o-mini",
    messages=[{"role": "user", "content": "رد عشوائيًا بكلمة Apple أو Bat"}]
)

# هذا سيقوم دائمًا بالرد بـ "Bat" لأن قاعدة الحماية تمنع جميع الردود التي تحتوي على "Apple". إعداد إعادة المحاولة سيحاول 5 مرات قبل التوقف.
```
<div align="center">
<img src="https://portkey.ai/blog/content/images/size/w1600/2024/11/image-15.png" width=600 title="تدفق الطلب عبر بوابة الذكاء الاصطناعي من Portkey مع إعادة المحاولة وقواعد الحماية" alt="تدفق الطلب عبر بوابة الذكاء الاصطناعي من Portkey مع إعادة المحاولة وقواعد الحماية"/>
</div>

يمكنك القيام بالكثير من الأمور باستخدام الإعدادات في بوابة الذكاء الاصطناعي الخاصة بك. [انتقل للأمثلة  →](https://portkey.wiki/gh-27)

<br/>

### النسخة المؤسسية (نشر خاص)

<sup>

[<img height="12" width="12" src="https://cfassets.portkey.ai/amazon-logo.svg" /> AWS](https://portkey.wiki/gh-28)
&nbsp; [<img height="12" width="12" src="https://cfassets.portkey.ai/azure-logo.svg" /> Azure](https://portkey.wiki/gh-29)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/googlecloud/3776AB" /> GCP](https://portkey.wiki/gh-30)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/redhatopenshift/3776AB" /> OpenShift](https://portkey.wiki/gh-31)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/kubernetes/3776AB" /> Kubernetes](https://portkey.wiki/gh-85)

</sup>

توفر [النسخة المؤسسية](https://portkey.wiki/gh-86) من بوابة النماذج اللغوية قدرات متقدمة لإدارة المؤسسات، والحوكمة، والأمان، و[المزيد](https://portkey.wiki/gh-87) بشكل فوري. [عرض مقارنة الميزات →](https://portkey.wiki/gh-32)

معمارية النشر المؤسسي للمنصات المدعومة متوفرة هنا - [**نشر سحابة خاصة للمؤسسات**](https://portkey.wiki/gh-33)

<a href="https://portkey.sh/demo-13"><img src="https://portkey.ai/blog/content/images/2024/08/Get-API-Key--5-.png" height=50 alt="احجز عرضًا توضيحيًا لبوابة الذكاء الاصطناعي المؤسسية" /></a><br/>


<br>

<hr>

### ساعات هندسة الذكاء الاصطناعي

انضم إلى مكالمات المجتمع الأسبوعية كل يوم جمعة (8 صباحًا بتوقيت المحيط الهادئ) للبدء في تنفيذ بوابة الذكاء الاصطناعي الخاصة بك! [تقام كل جمعة](https://portkey.wiki/gh-35)

<a href="https://portkey.wiki/gh-35"><img width="500" src="https://github.com/user-attachments/assets/c2885699-f197-4289-b819-21eb839fbae1" /></a>

محاضر الاجتماعات [منشورة هنا](https://portkey.wiki/gh-36).


<hr>

### نماذج لغوية في الإنتاج 2025

رؤى من تحليل أكثر من 2 تريليون رمز، عبر أكثر من 90 منطقة و650 فريقًا في الإنتاج. ماذا تتوقع من هذا التقرير:
- اتجاهات تشكل تبني الذكاء الاصطناعي ونمو مزودي النماذج اللغوية.
- معايير لتحسين السرعة والتكلفة والموثوقية.
- استراتيجيات لتوسيع أنظمة الذكاء الاصطناعي الجاهزة للإنتاج.

<a href="https://portkey.sh/report-github"><img width="500" src="https://raw.githubusercontent.com/siddharthsambharia-portkey/Portkey-Product-Images/refs/heads/main/LLM%20Report%20Campaign%20Image.png" /></a>

<a href="https://portkey.sh/report-github">**احصل على التقرير**</a>
<hr>


## الميزات الأساسية
### التوجيه الموثوق
- <a href="https://portkey.wiki/gh-37">**الاسترجاع (Fallbacks)**</a>: الاسترجاع إلى مزود آخر أو نموذج آخر عند فشل الطلبات باستخدام بوابة LLM. يمكنك تحديد الأخطاء التي يتم عندها تفعيل الاسترجاع. يحسن من موثوقية تطبيقك.
- <a href="https://portkey.wiki/gh-38">**إعادة المحاولة التلقائية**</a>: إعادة محاولة الطلبات الفاشلة تلقائيًا حتى 5 مرات. تعتمد استراتيجية التراجع الأسي للفصل بين محاولات الإعادة لمنع التحميل الزائد على الشبكة.
- <a href="https://portkey.wiki/gh-39">**موازنة التحميل**</a>: توزيع طلبات LLM عبر عدة مفاتيح API أو مزودي الذكاء الاصطناعي مع تخصيص أوزان لضمان توافر عالي وأداء مثالي.
- <a href="https://portkey.wiki/gh-40">**مهلات الطلبات**</a>: إدارة حالات LLM غير المتوقعة والتأخيرات من خلال تعيين مهلات دقيقة للطلبات، مما يسمح بإنهاء الطلبات تلقائيًا إذا تجاوزت مدة معينة.
- <a href="https://portkey.wiki/gh-41">**بوابة LLM متعددة الوسائط**</a>: استدعاء نماذج الرؤية، والصوت (تحويل النص إلى كلام والعكس)، وتوليد الصور من عدة مزودين — جميعها باستخدام توقيع OpenAI المألوف.
- <a href="https://portkey.wiki/gh-42">**واجهات برمجة التطبيقات اللحظية (Realtime APIs)**</a>: استدعاء واجهات برمجة التطبيقات اللحظية التي أطلقتها OpenAI من خلال خادم WebSockets المدمج.

### الأمان والدقة
- <a href="https://portkey.wiki/gh-88">**الضوابط الوقائية (Guardrails)**</a>: تحقق من مدخلات ومخرجات LLM لضمان الالتزام بالفحوصات التي تحددها. اختر من بين أكثر من 40 ضابط وقائي جاهز لضمان التوافق مع معايير الأمان والدقة. يمكنك <a href="https://portkey.wiki/gh-43">إضافة ضوابطك الخاصة</a> أو الاختيار من <a href="https://portkey.wiki/gh-44">شركائنا العديدين</a>.
- [**إدارة المفاتيح الآمنة**](https://portkey.wiki/gh-45): استخدم مفاتيحك الخاصة أو أنشئ مفاتيح افتراضية بشكل فوري.
- [**التحكم بالوصول قائم على الأدوار**](https://portkey.wiki/gh-46): تحكم دقيق في وصول المستخدمين ومساحات العمل ومفاتيح API الخاصة بك.
- <a href="https://portkey.wiki/gh-47">**الامتثال وخصوصية البيانات**</a>: بوابة الذكاء الاصطناعي متوافقة مع SOC2 وHIPAA وGDPR وCCPA.

### إدارة التكلفة
- [**التخزين المؤقت الذكي**](https://portkey.wiki/gh-48): تخزين استجابات LLM مؤقتًا لتقليل التكاليف وتحسين زمن الاستجابة. يدعم التخزين المؤقت البسيط والدلالي*.
- [**تحليلات الاستخدام**](https://portkey.wiki/gh-49): مراقبة وتحليل استخدام الذكاء الاصطناعي وLLM لديك، بما في ذلك حجم الطلبات، وزمن الاستجابة، والتكاليف، ومعدلات الأخطاء.
- [**تحسين المزود***](https://portkey.wiki/gh-89): التبديل تلقائيًا إلى المزود الأكثر فعالية من حيث التكلفة بناءً على أنماط الاستخدام ونماذج التسعير.

### التعاون وسير العمل
- <a href="https://portkey.ai/docs/integrations/agents">**دعم الوكلاء (Agents)**</a>: تكامل سلس مع أطر عمل الوكلاء الشهيرة لبناء تطبيقات ذكاء اصطناعي معقدة. تتكامل البوابة بسهولة مع [Autogen](https://portkey.wiki/gh-50)، و[CrewAI](https://portkey.wiki/gh-51)، و[LangChain](https://portkey.wiki/gh-52)، و[LlamaIndex](https://portkey.wiki/gh-53)، و[Phidata](https://portkey.wiki/gh-54)، و[Control Flow](https://portkey.wiki/gh-55)، وحتى [الوكلاء المخصصين](https://portkey.wiki/gh-56).
- [**إدارة قوالب الحوافز***](https://portkey.wiki/gh-57): أنشئ وأدر وقم بإصدار نسخ من قوالب الحوافز الخاصة بك بشكل تعاوني من خلال بيئة عمل موحدة للحوافز.
<br/><br/>

<sup>
*&nbsp;متوفرة في النسخ المستضافة ونسخ المؤسسات
</sup>

<br>

## كتب الطبخ

### ☄️ الرائج
- استخدام نماذج [Nvidia NIM](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/providers/nvidia.ipynb) مع بوابة الذكاء الاصطناعي
- مراقبة [وكلاء CrewAI](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/monitoring-agents/CrewAI_with_Telemetry.ipynb) مع Portkey!
- مقارنة [أفضل 10 نماذج LMSYS](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/use-cases/LMSYS%20Series/comparing-top10-LMSYS-models-with-Portkey.ipynb) مع بوابة الذكاء الاصطناعي.

### 🚨 الأحدث
* [إنشاء مجموعات بيانات تركيبية باستخدام Nemotron](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/use-cases/Nemotron_GPT_Finetuning_Portkey.ipynb)
* [استخدام بوابة LLM مع حزمة Vercel's AI SDK](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/integrations/vercel-ai.md)
* [مراقبة وكلاء Llama مع بوابة LLM من Portkey](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/monitoring-agents/Llama_Agents_with_Telemetry.ipynb)

[عرض جميع كتب الطبخ →](https://portkey.wiki/gh-58)
<br/><br/>

## المزودون المدعومون

استكشف تكاملات البوابة مع [أكثر من 45 مزودًا](https://portkey.wiki/gh-59) و[أكثر من 8 أطر عمل للوكلاء](https://portkey.wiki/gh-90).

|                                                                                                                            | المزود                                                                                         | الدعم  | البث    |
| -------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | ------ | ------- |
| <img src="docs/images/openai.png" width=35 />                                                                              | [OpenAI](https://portkey.wiki/gh-60)                          | ✅     | ✅      |
| <img src="docs/images/azure.png" width=35>                                                                                 | [Azure OpenAI](https://portkey.wiki/gh-61)               | ✅     | ✅      |
| <img src="docs/images/anyscale.png" width=35>                                                                              | [Anyscale](https://portkey.wiki/gh-62) | ✅     | ✅      |
| <img src="https://upload.wikimedia.org/wikipedia/commons/2/2d/Google-favicon-2015.png" width=35>                           | [Google Gemini](https://portkey.wiki/gh-63)             | ✅     | ✅      |
| <img src="docs/images/anthropic.png" width=35>                                                                             | [Anthropic](https://portkey.wiki/gh-64)                     | ✅     | ✅      |
| <img src="docs/images/cohere.png" width=35>                                                                                | [Cohere](https://portkey.wiki/gh-65)                           | ✅     | ✅      |
| <img src="https://assets-global.website-files.com/64f6f2c0e3f4c5a91c1e823a/654693d569494912cfc0c0d4_favicon.svg" width=35> | [Together AI](https://portkey.wiki/gh-66)                 | ✅     | ✅      |
| <img src="https://www.perplexity.ai/favicon.svg" width=35>                                                                 | [Perplexity](https://portkey.wiki/gh-67)                | ✅     | ✅      |
| <img src="https://docs.mistral.ai/img/favicon.ico" width=35>                                                               | [Mistral](https://portkey.wiki/gh-68)                      | ✅     | ✅      |
| <img src="https://docs.nomic.ai/img/nomic-logo.png" width=35>                                                              | [Nomic](https://portkey.wiki/gh-69)                             | ✅     | ✅      |
| <img src="https://files.readme.io/d38a23e-small-studio-favicon.png" width=35>                                              | [AI21](https://portkey.wiki/gh-91)                                    | ✅     | ✅      |
| <img src="https://platform.stability.ai/small-logo-purple.svg" width=35>                                                   | [Stability AI](https://portkey.wiki/gh-71)               | ✅     | ✅      |
| <img src="https://deepinfra.com/_next/static/media/logo.4a03fd3d.svg" width=35>                                            | [DeepInfra](https://portkey.sh/gh-92)                               | ✅     | ✅      |
| <img src="https://ollama.com/public/ollama.png" width=35>                                                                  | [Ollama](https://portkey.wiki/gh-72)                           | ✅     | ✅      |
| <img src="https://novita.ai/favicon.ico" width=35>                                                                         | [Novita AI](https://portkey.wiki/gh-73)                              | ✅     | ✅      | `/chat/completions`, `/completions` |


> [عرض القائمة الكاملة لأكثر من 200 نموذج مدعوم هنا](https://portkey.wiki/gh-74)
<br>

<br>

## الوكلاء (Agents)
تتكامل البوابة بسلاسة مع أطر عمل الوكلاء الشهيرة. [اقرأ التوثيق هنا](https://portkey.wiki/gh-75).


| الإطار | استدعاء أكثر من 200 نموذج LLM | توجيه متقدم | تخزين مؤقت | تسجيل وتتبع* | قابلية الملاحظة* | إدارة الحوافز* |
|------------------------------|--------|-------------|---------|------|---------------|-------------------|
| [Autogen](https://portkey.wiki/gh-93)    | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [CrewAI](https://portkey.wiki/gh-94)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [LangChain](https://portkey.wiki/gh-95)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [Phidata](https://portkey.wiki/gh-96)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [Llama Index](https://portkey.wiki/gh-97)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [Control Flow](https://portkey.wiki/gh-98) | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [ابنِ وكلاءك بنفسك](https://portkey.wiki/gh-99) | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |

<br>

*متوفرة على [التطبيق المستضاف](https://portkey.wiki/gh-76). لمزيد من التفاصيل [اضغط هنا](https://portkey.wiki/gh-100).


## إصدار بوابة المؤسسات
اجعل تطبيق الذكاء الاصطناعي الخاص بك أكثر <ins>موثوقية</ins> و<ins>متوافقًا مع المستقبل</ins>، مع ضمان <ins>أمان البيانات</ins> و<ins>الخصوصية</ins> بالكامل.

✅&nbsp; إدارة المفاتيح الآمنة - للتحكم في الوصول القائم على الأدوار والتتبع <br>
✅&nbsp; التخزين المؤقت البسيط والدلالي - لخدمة الاستفسارات المتكررة بشكل أسرع وتوفير التكاليف <br>
✅&nbsp; التحكم في الوصول والقواعد الواردة - للتحكم في عناوين IP والمناطق الجغرافية التي يمكنها الاتصال بنشرك <br>
✅&nbsp; إزالة معلومات التعريف الشخصية (PII) - لإزالة البيانات الحساسة تلقائيًا من طلباتك لمنع الكشف غير المقصود <br>
✅&nbsp; الامتثال لـ SOC2 وISO وHIPAA وGDPR - لأفضل ممارسات الأمان <br>
✅&nbsp; دعم احترافي - مع إعطاء الأولوية للميزات <br>

[احجز مكالمة لمناقشة نشر المؤسسات](https://portkey.sh/demo-13)

<br>


## المساهمة

أسهل طريقة للمساهمة هي اختيار قضية تحمل وسم `good first issue` 💪. اقرأ إرشادات المساهمة [هنا](https://raw.githubusercontent.com/Portkey-AI/gateway/main/.github/CONTRIBUTING.md).

هل لديك بلاغ عن عطل؟ [أرسل هنا](https://portkey.wiki/gh-78) | طلب ميزة؟ [أرسل هنا](https://portkey.wiki/gh-78)


### البدء مع المجتمع
انضم إلى ساعات هندسة الذكاء الاصطناعي الأسبوعية كل جمعة (8 صباحًا بتوقيت المحيط الهادئ) لـ:
- لقاء مساهمين وأعضاء المجتمع الآخرين
- تعلم ميزات البوابة المتقدمة وأنماط التنفيذ
- مشاركة خبراتك والحصول على المساعدة
- البقاء على اطلاع بأولويات التطوير الأخيرة

[انضم للجلسة القادمة →](https://portkey.wiki/gh-101) | [ملاحظات الاجتماع](https://portkey.wiki/gh-102)

<br>

## المجتمع

انضم إلى مجتمعنا المتنامي حول العالم للحصول على المساعدة والأفكار والنقاشات حول الذكاء الاصطناعي.

- شاهد [مدونتنا الرسمية](https://portkey.wiki/gh-78)
- تحدث معنا على [Discord](https://portkey.wiki/community)
- تابعنا على [تويتر](https://portkey.wiki/gh-79)
- تواصل معنا على [LinkedIn](https://portkey.wiki/gh-80)
- اقرأ التوثيق [باللغة اليابانية](https://raw.githubusercontent.com/Portkey-AI/gateway/main/.github/README.jp.md)
- زرنا على [YouTube](https://portkey.wiki/gh-103)
- انضم إلى [مجتمع المطورين](https://portkey.wiki/gh-82)
<!-- - أسئلة موسومة #portkey على [Stack Overflow](https://stackoverflow.com/questions/tagged/portkey) -->

![Rubeus Social Share (4)](https://github.com/Portkey-AI/gateway/assets/971978/89d6f0af-a95d-4402-b451-14764c40d03f)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---