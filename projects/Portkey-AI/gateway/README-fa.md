<p align="right">
   <strong>انگلیسی</strong> | <a href="./.github/README.cn.md">中文</a> | <a href="./.github/README.jp.md">日本語</a>
</p>

<div align="center">

<a href="https://portkey.sh/report-github"><img src="https://raw.githubusercontent.com/siddharthsambharia-portkey/Portkey-Product-Images/refs/heads/main/LLM%20Report%20Campaign%20Frame.png"></img></a>
<br>

# دروازه هوش مصنوعی (AI Gateway)
#### مسیر به بیش از ۲۵۰ مدل زبانی بزرگ (LLM) با یک API سریع و کاربرپسند

<img src="https://cfassets.portkey.ai/sdk.gif" width="550px" alt="دموی دروازه هوش مصنوعی Portkey با نمایش قابلیت‌های مسیر‌دهی LLM" style="margin-left:-35px">

[مستندات](https://portkey.wiki/gh-1) | [نسخه سازمانی](https://portkey.wiki/gh-2) | [دروازه میزبان‌شده](https://portkey.wiki/gh-3) | [تغییرات](https://portkey.wiki/gh-4) | [مرجع API](https://portkey.wiki/gh-5)


[![License](https://img.shields.io/github/license/Ileriayo/markdown-badges)](./LICENSE)
[![Discord](https://img.shields.io/discord/1143393887742861333)](https://portkey.wiki/gh-6)
[![Twitter](https://img.shields.io/twitter/url/https/twitter/follow/portkeyai?style=social&label=Follow%20%40PortkeyAI)](https://portkey.wiki/gh-7)
[![npm version](https://badge.fury.io/js/%40portkey-ai%2Fgateway.svg)](https://portkey.wiki/gh-8)
[![Better Stack Badge](https://uptime.betterstack.com/status-badges/v1/monitor/q94g.svg)](https://portkey.wiki/gh-9)

<a href="https://us-east-1.console.aws.amazon.com/cloudformation/home?region=us-east-1#/stacks/quickcreate?stackName=portkey-gateway&templateURL=https://portkey-gateway-ec2-quicklaunch.s3.us-east-1.amazonaws.com/portkey-gateway-ec2-quicklaunch.template.yaml"><img src="https://img.shields.io/badge/Deploy_to_EC2-232F3E?style=for-the-badge&logo=amazonwebservices&logoColor=white" alt="Deploy to AWS EC2" width="105"/></a> [![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/Portkey-AI/gateway)
</div>

<br/>

[**دروازه هوش مصنوعی**](https://portkey.wiki/gh-10) برای مسیر‌دهی سریع، قابل اعتماد و امن به بیش از ۱۶۰۰ مدل زبانی، تصویری، صوتی و تصویری طراحی شده است. این راهکار سبک، متن‌باز و آماده برای سازمان‌ها است که به شما اجازه می‌دهد در کمتر از ۲ دقیقه با هر مدل زبانی ادغام شوید.

- [x] **بسیار سریع** (کمتر از ۱ میلی‌ثانیه تاخیر) با حجم کم (۱۲۲ کیلوبایت)
- [x] **آزموده در میدان عمل** با پردازش بیش از ۱۰ میلیارد توکن در هر روز
- [x] **مناسب سازمان‌ها** با امنیت افزایش‌یافته، مقیاس‌پذیری و استقرار سفارشی

<br>

#### با دروازه هوش مصنوعی چه کارهایی می‌توان کرد؟
- ادغام با هر مدل LLM در کمتر از ۲ دقیقه - [شروع سریع](#quickstart-2-mins)
- جلوگیری از قطعی‌ها با **[تلاش مجدد خودکار](https://portkey.wiki/gh-11)** و **[راهکارهای جایگزین](https://portkey.wiki/gh-12)**
- مقیاس‌پذیری برنامه‌های هوش مصنوعی با **[تعادل بار](https://portkey.wiki/gh-13)** و **[مسیردهی شرطی](https://portkey.wiki/gh-14)**
- محافظت از استقرارهای هوش مصنوعی با **[محافظ‌ها](https://portkey.wiki/gh-15)**
- فراتر از متن با **[قابلیت‌های چندوجهی](https://portkey.wiki/gh-16)**
- و در نهایت، کشف **[ادغام جریان کاری عاملی](https://portkey.wiki/gh-17)**

<br><br>

> [!TIP]
> ستاره‌دار کردن این مخزن به توسعه‌دهندگان بیشتری کمک می‌کند تا با دروازه هوش مصنوعی آشنا شوند 🙏🏻
>
> ![star-2](https://github.com/user-attachments/assets/53597dce-6333-4ecc-a154-eb05532954e4)
> 
<br>


<br>

## شروع سریع (۲ دقیقه)

### ۱. راه‌اندازی دروازه هوش مصنوعی خود

```bash
# اجرای دروازه به صورت محلی (نیازمند Node.js و npm)
npx @portkey-ai/gateway
```
> دروازه روی `http://localhost:8787/v1` اجرا می‌شود
> 
> کنسول دروازه روی `http://localhost:8787/public/` اجرا می‌شود

<sup>
راهنمای استقرار:
&nbsp; <a href="https://portkey.wiki/gh-18"><img height="12" width="12" src="https://cfassets.portkey.ai/logo/dew-color.svg" /> Portkey Cloud (توصیه‌شده)</a>
&nbsp; <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/installation-deployments.md#docker"><img height="12" width="12" src="https://cdn.simpleicons.org/docker/3776AB" /> داکر</a>
&nbsp; <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/installation-deployments.md#nodejs-server"><img height="12" width="12" src="https://cdn.simpleicons.org/node.js/3776AB" /> Node.js</a>
&nbsp; <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/installation-deployments.md#cloudflare-workers"><img height="12" width="12" src="https://cdn.simpleicons.org/cloudflare/3776AB" /> Cloudflare</a>
&nbsp; <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/installation-deployments.md#replit"><img height="12" width="12" src="https://cdn.simpleicons.org/replit/3776AB" /> Replit</a>
&nbsp; <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/installation-deployments.md"> سایر موارد...</a>

</sup>

### ۲. اولین درخواست خود را ارسال کنید

<!-- <details open>
<summary>مثال پایتون</summary> -->
```python
# pip install -qU portkey-ai

from portkey_ai import Portkey

# کلاینت سازگار با OpenAI
client = Portkey(
    provider="openai", # یا 'anthropic'، 'bedrock'، 'groq' و غیره
    Authorization="sk-***" # کلید API ارائه‌دهنده
)

# ارسال درخواست از طریق دروازه هوش مصنوعی
client.chat.completions.create(
    messages=[{"role": "user", "content": "آب و هوا چطور است؟"}],
    model="gpt-4o-mini"
)
```



<sup>کتابخانه‌های پشتیبانی‌شده:
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/javascript/3776AB" /> جاوااسکریپت](https://portkey.wiki/gh-19)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/python/3776AB" /> پایتون](https://portkey.wiki/gh-20)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/gnubash/3776AB" /> REST](https://portkey.sh/gh-84)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/openai/3776AB" /> OpenAI SDKs](https://portkey.wiki/gh-21)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/langchain/3776AB" /> Langchain](https://portkey.wiki/gh-22)
&nbsp; [LlamaIndex](https://portkey.wiki/gh-23)
&nbsp; [Autogen](https://portkey.wiki/gh-24)
&nbsp; [CrewAI](https://portkey.wiki/gh-25)
&nbsp; [بیشتر...](https://portkey.wiki/gh-26)
</sup>

در کنسول دروازه (`http://localhost:8787/public/`) می‌توانید همه لاگ‌های محلی خود را یکجا مشاهده کنید.

<img src="https://github.com/user-attachments/assets/362bc916-0fc9-43f1-a39e-4bd71aac4a3a" width="400" />


### ۳. مسیر‌دهی و محافظ‌ها
`Configs` در دروازه LLM به شما اجازه می‌دهد قواعد مسیر‌دهی بسازید، قابلیت اطمینان اضافه کنید و محافظ‌ها را تنظیم کنید.
```python
config = {
  "retry": {"attempts": 5},

  "output_guardrails": [{
    "default.contains": {"operator": "none", "words": ["Apple"]},
    "deny": True
  }]
}

# اضافه کردن پیکربندی به کلاینت
client = client.with_options(config=config)

client.chat.completions.create(
    model="gpt-4o-mini",
    messages=[{"role": "user", "content": "به صورت تصادفی با Apple یا Bat پاسخ بده"}]
)

# این همیشه با "Bat" پاسخ می‌دهد زیرا محافظ همه پاسخ‌هایی که شامل "Apple" باشد را رد می‌کند. پیکربندی تلاش مجدد تا ۵ بار تلاش می‌کند تا موفق شود.
```
<div align="center">
<img src="https://portkey.ai/blog/content/images/size/w1600/2024/11/image-15.png" width=600 title="جریان درخواست از طریق دروازه هوش مصنوعی Portkey با تلاش مجدد و محافظ‌ها" alt="جریان درخواست از طریق دروازه هوش مصنوعی Portkey با تلاش مجدد و محافظ‌ها"/>
</div>

شما می‌توانید کارهای بیشتری با پیکربندی‌ها در دروازه هوش مصنوعی انجام دهید. [برو به مثال‌ها  →](https://portkey.wiki/gh-27)

<br/>

### نسخه سازمانی (استقرارهای خصوصی)

<sup>

[<img height="12" width="12" src="https://cfassets.portkey.ai/amazon-logo.svg" /> AWS](https://portkey.wiki/gh-28)
&nbsp; [<img height="12" width="12" src="https://cfassets.portkey.ai/azure-logo.svg" /> Azure](https://portkey.wiki/gh-29)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/googlecloud/3776AB" /> GCP](https://portkey.wiki/gh-30)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/redhatopenshift/3776AB" /> OpenShift](https://portkey.wiki/gh-31)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/kubernetes/3776AB" /> Kubernetes](https://portkey.wiki/gh-85)

</sup>

نسخه سازمانی [دروازه LLM](https://portkey.wiki/gh-86) امکانات پیشرفته‌ای برای **مدیریت سازمانی**، **حاکمیت**، **امنیت** و [بیشتر](https://portkey.wiki/gh-87) را به صورت پیش‌فرض ارائه می‌دهد. [مقایسه امکانات →](https://portkey.wiki/gh-32)

معماری استقرار سازمانی برای پلتفرم‌های پشتیبانی‌شده اینجاست - [**استقرار ابری خصوصی سازمانی**](https://portkey.wiki/gh-33)

<a href="https://portkey.sh/demo-13"><img src="https://portkey.ai/blog/content/images/2024/08/Get-API-Key--5-.png" height=50 alt="رزرو دموی دروازه هوش مصنوعی سازمانی" /></a><br/>


<br>

<hr>

### ساعات مهندسی هوش مصنوعی

هر جمعه (۸ صبح به وقت PT) در جلسات هفتگی جامعه شرکت کنید تا پیاده‌سازی دروازه هوش مصنوعی خود را آغاز نمایید! [هر جمعه برگزار می‌شود](https://portkey.wiki/gh-35)

<a href="https://portkey.wiki/gh-35"><img width="500" src="https://github.com/user-attachments/assets/c2885699-f197-4289-b819-21eb839fbae1" /></a>

صورتجلسات [اینجا منتشر می‌شود](https://portkey.wiki/gh-36).


<hr>

### مدل‌های زبانی در تولید ۲۰۲۵ (LLMs in Prod'25)

یافته‌هایی از تحلیل بیش از ۲ تریلیون توکن در ۹۰+ منطقه و ۶۵۰+ تیم در محیط تولید. از این گزارش چه انتظاری داشته باشید:
- روندهایی که پذیرش هوش مصنوعی و رشد ارائه‌دهندگان LLM را شکل می‌دهد.
- معیارهایی برای بهینه‌سازی سرعت، هزینه و قابلیت اطمینان.
- استراتژی‌هایی برای مقیاس‌پذیری سیستم‌های هوش مصنوعی در سطح تولید.

<a href="https://portkey.sh/report-github"><img width="500" src="https://raw.githubusercontent.com/siddharthsambharia-portkey/Portkey-Product-Images/refs/heads/main/LLM%20Report%20Campaign%20Image.png" /></a>

<a href="https://portkey.sh/report-github">**دریافت گزارش**</a>
<hr>


## امکانات اصلی
### مسیر‌دهی قابل اطمینان
- <a href="https://portkey.wiki/gh-37">**مسیر جایگزین (Fallbacks)**</a>: با استفاده از درگاه LLM، در صورت شکست درخواست‌ها، به ارائه‌دهنده یا مدل دیگری منتقل شوید. می‌توانید خطاهایی که باید باعث اجرای مسیر جایگزین شوند را مشخص کنید. این کار قابلیت اطمینان برنامه شما را افزایش می‌دهد.
- <a href="https://portkey.wiki/gh-38">**تلاش مجدد خودکار (Automatic Retries)**</a>: به طور خودکار تا ۵ بار درخواست‌های ناموفق را مجدداً ارسال کنید. یک استراتژی بازگشت نمایی (exponential backoff) تلاش‌های مجدد را با فاصله زمانی تنظیم می‌کند تا از ازدحام شبکه جلوگیری شود.
- <a href="https://portkey.wiki/gh-39">**توزیع بار (Load Balancing)**</a>: درخواست‌های LLM را با وزن‌دهی بین چند کلید API یا ارائه‌دهنده هوش مصنوعی توزیع کنید تا از دسترس‌پذیری بالا و عملکرد بهینه اطمینان حاصل شود.
- <a href="https://portkey.wiki/gh-40">**زمان‌سنجی درخواست‌ها (Request Timeouts)**</a>: با تنظیم زمان‌سنج دقیق برای درخواست‌ها، مدل‌های LLM پرهزینه یا با تاخیر را کنترل کنید؛ این امکان، خاتمه خودکار درخواست‌هایی که از مدت زمان معین عبور می‌کنند را فراهم می‌کند.
- <a href="https://portkey.wiki/gh-41">**درگاه چندرسانه‌ای LLM**</a>: مدل‌های بینایی، صوت (متن به گفتار و گفتار به متن)، و تولید تصویر را از چندین ارائه‌دهنده با امضای OpenAI فراخوانی کنید.
- <a href="https://portkey.wiki/gh-42">**APIهای بلادرنگ (Realtime APIs)**</a>: APIهای بلادرنگ ارائه شده توسط OpenAI را از طریق سرور WebSocket یکپارچه فراخوانی کنید.

### امنیت و دقت
- <a href="https://portkey.wiki/gh-88">**ریل‌های محافظ (Guardrails)**</a>: ورودی و خروجی LLM خود را برای تطابق با بررسی‌های تعیین‌شده تأیید کنید. از میان بیش از ۴۰ ریل محافظ آماده انتخاب کنید تا مطابقت با استانداردهای امنیت و دقت را تضمین نمایید. می‌توانید <a href="https://portkey.wiki/gh-43">ریل محافظ خود را اضافه کنید</a> یا از میان <a href="https://portkey.wiki/gh-44">شرکای ما</a> انتخاب کنید.
- [**مدیریت امن کلیدها**](https://portkey.wiki/gh-45): از کلیدهای خود استفاده کنید یا کلیدهای مجازی را به صورت لحظه‌ای تولید نمایید.
- [**کنترل دسترسی مبتنی بر نقش**](https://portkey.wiki/gh-46): کنترل دسترسی دقیق برای کاربران، محیط‌های کاری و کلیدهای API.
- <a href="https://portkey.wiki/gh-47">**تطبیق‌پذیری و حفظ حریم خصوصی داده‌ها**</a>: درگاه هوش مصنوعی با استانداردهای SOC2، HIPAA، GDPR و CCPA سازگار است.

### مدیریت هزینه
- [**ذخیره‌سازی هوشمند (Smart caching)**](https://portkey.wiki/gh-48): پاسخ‌های مدل‌های LLM را ذخیره کنید تا هزینه‌ها کاهش یافته و تاخیر بهبود یابد. از ذخیره‌سازی ساده و معنایی* پشتیبانی می‌کند.
- [**تحلیل مصرف (Usage analytics)**](https://portkey.wiki/gh-49): مصرف هوش مصنوعی و مدل‌های LLM خود را پایش و تحلیل کنید؛ شامل حجم درخواست، تاخیر، هزینه‌ها و نرخ خطا.
- [**بهینه‌سازی ارائه‌دهنده***](https://portkey.wiki/gh-89): به صورت خودکار بر اساس الگوهای مصرف و مدل‌های قیمت‌گذاری، به مقرون‌به‌صرفه‌ترین ارائه‌دهنده سوئیچ کنید.

### همکاری و جریان‌کارها
- <a href="https://portkey.ai/docs/integrations/agents">**پشتیبانی از عامل‌ها (Agents)**</a>: با ادغام بی‌وقفه با فریمورک‌های محبوب عامل‌ها، برنامه‌های هوش مصنوعی پیچیده بسازید. این درگاه با [Autogen](https://portkey.wiki/gh-50)، [CrewAI](https://portkey.wiki/gh-51)، [LangChain](https://portkey.wiki/gh-52)، [LlamaIndex](https://portkey.wiki/gh-53)، [Phidata](https://portkey.wiki/gh-54)، [Control Flow](https://portkey.wiki/gh-55) و حتی [عامل‌های سفارشی](https://portkey.wiki/gh-56) یکپارچه می‌شود.
- [**مدیریت قالب‌های پرامپت***](https://portkey.wiki/gh-57): قالب‌های پرامپت خود را به صورت گروهی ایجاد، مدیریت و نسخه‌بندی کنید و از محیطی یکپارچه بهره ببرید.
<br/><br/>

<sup>
*&nbsp;در نسخه‌های میزبانی‌شده و سازمانی موجود است
</sup>

<br>

## کتابخانه‌ها (Cookbooks)

### ☄️ محبوب‌ترین‌ها
- استفاده از مدل‌های [Nvidia NIM](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/providers/nvidia.ipynb) با درگاه هوش مصنوعی
- پایش [عامل‌های CrewAI](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/monitoring-agents/CrewAI_with_Telemetry.ipynb) با Portkey!
- مقایسه [۱۰ مدل برتر LMSYS](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/use-cases/LMSYS%20Series/comparing-top10-LMSYS-models-with-Portkey.ipynb) با درگاه هوش مصنوعی.

### 🚨 جدیدترین‌ها
* [ساخت داده‌ مصنوعی با Nemotron](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/use-cases/Nemotron_GPT_Finetuning_Portkey.ipynb)
* [استفاده از درگاه LLM با AI SDK شرکت Vercel](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/integrations/vercel-ai.md)
* [پایش عامل‌های Llama با درگاه LLM Portkey](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/monitoring-agents/Llama_Agents_with_Telemetry.ipynb)

[مشاهده همه کتابخانه‌ها →](https://portkey.wiki/gh-58)
<br/><br/>

## ارائه‌دهندگان پشتیبانی‌شده

ادغام‌های Gateway با [بیش از ۴۵ ارائه‌دهنده](https://portkey.wiki/gh-59) و [بیش از ۸ فریمورک عامل](https://portkey.wiki/gh-90) را کاوش کنید.

|                                                                                                                            | ارائه‌دهنده                                                                                   | پشتیبانی | استریم |
| -------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | ------- | ------ |
| <img src="docs/images/openai.png" width=35 />                                                                              | [OpenAI](https://portkey.wiki/gh-60)                           | ✅       | ✅      |
| <img src="docs/images/azure.png" width=35>                                                                                 | [Azure OpenAI](https://portkey.wiki/gh-61)               | ✅       | ✅      |
| <img src="docs/images/anyscale.png" width=35>                                                                              | [Anyscale](https://portkey.wiki/gh-62) | ✅       | ✅      |
| <img src="https://upload.wikimedia.org/wikipedia/commons/2/2d/Google-favicon-2015.png" width=35>                           | [Google Gemini](https://portkey.wiki/gh-63)             | ✅       | ✅      |
| <img src="docs/images/anthropic.png" width=35>                                                                             | [Anthropic](https://portkey.wiki/gh-64)                     | ✅       | ✅      |
| <img src="docs/images/cohere.png" width=35>                                                                                | [Cohere](https://portkey.wiki/gh-65)                           | ✅       | ✅      |
| <img src="https://assets-global.website-files.com/64f6f2c0e3f4c5a91c1e823a/654693d569494912cfc0c0d4_favicon.svg" width=35> | [Together AI](https://portkey.wiki/gh-66)                 | ✅       | ✅      |
| <img src="https://www.perplexity.ai/favicon.svg" width=35>                                                                 | [Perplexity](https://portkey.wiki/gh-67)                | ✅       | ✅      |
| <img src="https://docs.mistral.ai/img/favicon.ico" width=35>                                                               | [Mistral](https://portkey.wiki/gh-68)                      | ✅       | ✅      |
| <img src="https://docs.nomic.ai/img/nomic-logo.png" width=35>                                                              | [Nomic](https://portkey.wiki/gh-69)                             | ✅       | ✅      |
| <img src="https://files.readme.io/d38a23e-small-studio-favicon.png" width=35>                                              | [AI21](https://portkey.wiki/gh-91)                                    | ✅       | ✅      |
| <img src="https://platform.stability.ai/small-logo-purple.svg" width=35>                                                   | [Stability AI](https://portkey.wiki/gh-71)               | ✅       | ✅      |
| <img src="https://deepinfra.com/_next/static/media/logo.4a03fd3d.svg" width=35>                                            | [DeepInfra](https://portkey.sh/gh-92)                               | ✅       | ✅      |
| <img src="https://ollama.com/public/ollama.png" width=35>                                                                  | [Ollama](https://portkey.wiki/gh-72)                           | ✅       | ✅      |
| <img src="https://novita.ai/favicon.ico" width=35>                                                                         | [Novita AI](https://portkey.wiki/gh-73)                              | ✅       | ✅      | `/chat/completions`, `/completions` |


> [فهرست کامل بیش از ۲۰۰ مدل پشتیبانی‌شده را اینجا ببینید](https://portkey.wiki/gh-74)
<br>

<br>

## عامل‌ها (Agents)
درگاه Gateway به طور یکپارچه با فریمورک‌های محبوب عامل‌ها ادغام می‌شود. [اسناد را اینجا بخوانید](https://portkey.wiki/gh-75).


| فریمورک | دسترسی به ۲۰۰+ مدل LLM | مسیریابی پیشرفته | کشینگ | لاگ‌گیری و ردیابی* | قابل مشاهده بودن* | مدیریت پرامپت* |
|------------------------------|--------|-------------|---------|------|---------------|-------------------|
| [Autogen](https://portkey.wiki/gh-93)    | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [CrewAI](https://portkey.wiki/gh-94)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [LangChain](https://portkey.wiki/gh-95)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [Phidata](https://portkey.wiki/gh-96)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [Llama Index](https://portkey.wiki/gh-97)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [Control Flow](https://portkey.wiki/gh-98) | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [ساخت عامل سفارشی](https://portkey.wiki/gh-99) | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |

<br>

*در [اپلیکیشن میزبانی‌شده](https://portkey.wiki/gh-76) موجود است. برای مستندات کامل [اینجا کلیک کنید](https://portkey.wiki/gh-100).


## نسخه سازمانی Gateway
برنامه هوش مصنوعی خود را <ins>قابل‌اعتمادتر</ins> و <ins>سازگار با آینده</ins> کنید، در حالی که <ins>امنیت کامل داده‌ها</ins> و <ins>حفظ حریم خصوصی</ins> را تضمین می‌کنید.

✅&nbsp; مدیریت امن کلیدها - برای کنترل دسترسی مبتنی بر نقش و رهگیری <br>
✅&nbsp; کشینگ ساده و معنایی - برای پاسخ‌دهی سریع‌تر به پرسش‌های تکراری و صرفه‌جویی در هزینه <br>
✅&nbsp; کنترل دسترسی و قوانین ورودی - کنترل اینکه کدام IP و مناطق جغرافیایی به استقرارهای شما متصل شوند <br>
✅&nbsp; حذف اطلاعات شخصی (PII Redaction) - حذف خودکار داده‌های حساس از درخواست‌ها برای جلوگیری از افشای ناخواسته <br>
✅&nbsp; انطباق با SOC2، ISO، HIPAA، GDPR - جهت رعایت بهترین شیوه‌های امنیتی <br>
✅&nbsp; پشتیبانی حرفه‌ای - به همراه اولویت‌بندی ویژگی‌ها <br>

[برای مشاوره در خصوص استقرارهای سازمانی وقت رزرو کنید](https://portkey.sh/demo-13)

<br>


## مشارکت

ساده‌ترین راه برای مشارکت، انتخاب یک مورد با برچسب `good first issue` است 💪. راهنمای مشارکت را [اینجا بخوانید](https://raw.githubusercontent.com/Portkey-AI/gateway/main/.github/CONTRIBUTING.md).

گزارش باگ؟ [اینجا ثبت کنید](https://portkey.wiki/gh-78) | درخواست ویژگی؟ [اینجا ثبت کنید](https://portkey.wiki/gh-78)


### شروع با جامعه
هر جمعه (۸ صبح PT) در جلسات هفتگی AI Engineering Hours ما شرکت کنید تا:
- با دیگر مشارکت‌کنندگان و اعضای جامعه آشنا شوید
- ویژگی‌ها و الگوهای پیاده‌سازی پیشرفته Gateway را یاد بگیرید
- تجربیات خود را به اشتراک بگذارید و کمک بگیرید
- از آخرین اولویت‌های توسعه مطلع شوید

[به جلسه بعدی بپیوندید →](https://portkey.wiki/gh-101) | [یادداشت‌های جلسه](https://portkey.wiki/gh-102)

<br>

## جامعه

به جامعه در حال رشد ما در سراسر جهان بپیوندید تا برای کمک، ایده و بحث‌های مرتبط با هوش مصنوعی از آن بهره‌مند شوید.

- [وبلاگ رسمی ما](https://portkey.wiki/gh-78)
- گفت‌وگو با ما در [Discord](https://portkey.wiki/community)
- ما را در [توییتر](https://portkey.wiki/gh-79) دنبال کنید
- در [LinkedIn](https://portkey.wiki/gh-80) با ما در ارتباط باشید
- مستندات را به [ژاپنی](https://raw.githubusercontent.com/Portkey-AI/gateway/main/.github/README.jp.md) بخوانید
- ما را در [YouTube](https://portkey.wiki/gh-103) ببینید
- به [جامعه توسعه‌دهندگان](https://portkey.wiki/gh-82) ما بپیوندید
<!-- - سؤالات با برچسب #portkey در [Stack Overflow](https://stackoverflow.com/questions/tagged/portkey) -->

![Rubeus Social Share (4)](https://github.com/Portkey-AI/gateway/assets/971978/89d6f0af-a95d-4402-b451-14764c40d03f)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---