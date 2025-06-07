# Open WebUI 👋

![GitHub stars](https://img.shields.io/github/stars/open-webui/open-webui?style=social)
![GitHub forks](https://img.shields.io/github/forks/open-webui/open-webui?style=social)
![GitHub watchers](https://img.shields.io/github/watchers/open-webui/open-webui?style=social)
![GitHub repo size](https://img.shields.io/github/repo-size/open-webui/open-webui)
![GitHub language count](https://img.shields.io/github/languages/count/open-webui/open-webui)
![GitHub top language](https://img.shields.io/github/languages/top/open-webui/open-webui)
![GitHub last commit](https://img.shields.io/github/last-commit/open-webui/open-webui?color=red)
[![Discord](https://img.shields.io/badge/Discord-Open_WebUI-blue?logo=discord&logoColor=white)](https://discord.gg/5rJgQTnV4s)
[![](https://img.shields.io/static/v1?label=Sponsor&message=%E2%9D%A4&logo=GitHub&color=%23fe8e86)](https://github.com/sponsors/tjbck)

**Open WebUI یک پلتفرم هوش مصنوعی خودمیزبان، [قابل توسعه](https://docs.openwebui.com/features/plugin/)، غنی از ویژگی و کاربرپسند است که برای کار کاملاً آفلاین طراحی شده است.** این پلتفرم از اجراکننده‌های مختلف LLM مانند **Ollama** و APIهای سازگار با **OpenAI** پشتیبانی می‌کند و دارای **موتور استنتاج داخلی** برای RAG است که آن را به **راه‌حل قدرتمند استقرار هوش مصنوعی** تبدیل می‌کند.

![دموی Open WebUI](./demo.gif)

> [!TIP]  
> **دنبال یک [طرح سازمانی](https://docs.openwebui.com/enterprise) هستید؟** – **[همین امروز با تیم فروش ما صحبت کنید!](mailto:sales@openwebui.com)**
>
> از **قابلیت‌های پیشرفته** مانند **سفارشی‌سازی تم و برندینگ**، **پشتیبانی SLA**، **نسخه‌های LTS** و **موارد دیگر** بهره‌مند شوید!

برای اطلاعات بیشتر، حتماً [مستندات Open WebUI](https://docs.openwebui.com/) را بررسی کنید.

## ویژگی‌های کلیدی Open WebUI ⭐

- 🚀 **نصب آسان**: نصب بدون دردسر با Docker یا Kubernetes (kubectl، kustomize یا helm) با پشتیبانی از ایمیج‌های دارای تگ `:ollama` و `:cuda`.

- 🤝 **ادغام API Ollama/OpenAI**: ادغام ساده APIهای سازگار با OpenAI برای گفتگوهای متنوع در کنار مدل‌های Ollama. امکان سفارشی‌سازی آدرس API و اتصال به **LMStudio، GroqCloud، Mistral، OpenRouter و غیره**.

- 🛡️ **مجوزها و گروه‌های کاربری دقیق**: مدیران می‌توانند نقش‌ها و مجوزهای دقیقی تعریف کنند تا امنیت و تجربه کاربری سفارشی برای هر کاربر فراهم شود.

- 📱 **طراحی واکنش‌گرا**: تجربه یکپارچه در رایانه رومیزی، لپ‌تاپ و دستگاه‌های همراه.

- 📱 **اپلیکیشن پیش‌رونده وب (PWA) برای موبایل**: تجربه‌ای مشابه اپلیکیشن بومی روی موبایل با امکان دسترسی آفلاین روی localhost و رابط کاربری روان.

- ✒️🔢 **پشتیبانی کامل از Markdown و LaTeX**: تجربه‌ای غنی‌تر از LLM با قابلیت‌های کامل Markdown و LaTeX.

- 🎤📹 **تماس صوتی/تصویری بدون دست**: ارتباط یکپارچه با قابلیت تماس صوتی و تصویری بدون دخالت دست برای محیط چت پویا و تعاملی.

- 🛠️ **سازنده مدل**: ساخت آسان مدل‌های Ollama از طریق رابط وب. افزودن شخصیت‌ها/نمایندگان سفارشی، شخصی‌سازی عناصر چت و وارد کردن مدل‌ها با ادغام [انجمن Open WebUI](https://openwebui.com/).

- 🐍 **ابزار اجرای توابع پایتون بومی**: افزایش قابلیت‌های LLM با ادیتور کد داخلی در محیط ابزارها. توابع پایتون شخصی را اضافه و به راحتی با LLMها یکپارچه کنید.

- 📚 **ادغام محلی RAG**: تجربه چت آینده با پشتیبانی Retrieval Augmented Generation (RAG). اسناد را مستقیماً وارد چت کنید یا به کتابخانه خود اضافه و با دستور `#` قبل از پرسش به آن‌ها دسترسی یابید.

- 🔍 **جستجوی وب برای RAG**: جستجو در وب با ارائه‌دهندگانی مانند `SearXNG`، `Google PSE`، `Brave Search`، `serpstack`، `serper`، `Serply`، `DuckDuckGo`، `TavilySearch`، `SearchApi` و `Bing` و وارد کردن نتایج مستقیماً در تجربه چت.

- 🌐 **قابلیت مرور وب**: ادغام آسان وب‌سایت‌ها در گفتگو با دستور `#` و وارد کردن URL. این ویژگی محتوای وب را مستقیماً وارد گفتگوها می‌کند.

- 🎨 **ادغام تولید تصویر**: اضافه کردن قابلیت تولید تصویر با گزینه‌هایی مانند API AUTOMATIC1111 یا ComfyUI (محلی) و DALL-E از OpenAI (خارجی) برای محتوای بصری پویا.

- ⚙️ **گفتگو با چند مدل**: به راحتی با چند مدل به طور همزمان گفتگو کنید و از نقاط قوت هر یک بهره‌مند شوید.

- 🔐 **کنترل دسترسی مبتنی بر نقش (RBAC)**: دسترسی ایمن با مجوزهای محدود؛ فقط افراد مجاز به Ollama دسترسی دارند و فقط مدیران می‌توانند مدل جدید ایجاد یا دریافت کنند.

- 🌐🌍 **پشتیبانی چندزبانه**: تجربه Open WebUI به زبان دلخواه شما با پشتیبانی i18n. در گسترش زبان‌ها مشارکت کنید! ما به دنبال مشارکت‌کنندگان هستیم!

- 🧩 **پشتیبانی از Pipeline و افزونه Open WebUI**: ادغام منطق سفارشی و کتابخانه‌های پایتون با [چارچوب افزونه Pipelines](https://github.com/open-webui/pipelines). نمونه Pipelines را اجرا و آدرس OpenAI را روی آدرس Pipelines تنظیم کنید. [نمونه‌ها](https://github.com/open-webui/pipelines/tree/main/examples) شامل **فراخوانی تابع**، **محدودیت نرخ کاربران**، **پایش مصرف** با ابزارهایی مانند Langfuse، **ترجمه زنده با LibreTranslate**، **فیلترینگ پیام‌های مخرب** و موارد بسیار دیگر.

- 🌟 **به‌روزرسانی مستمر**: متعهد به بهبود Open WebUI با به‌روزرسانی‌های منظم، اصلاحات و افزودن ویژگی‌های جدید هستیم.

برای آشنایی بیشتر با ویژگی‌های Open WebUI به [مستندات Open WebUI](https://docs.openwebui.com/features) مراجعه کنید!

## اسپانسرها 🙌

#### زمرد

<table>
  <tr>
    <td>
      <a href="https://n8n.io/" target="_blank">
        <img src="https://docs.openwebui.com/sponsors/logos/n8n.png" alt="n8n" style="width: 8rem; height: 8rem; border-radius: .75rem;" />
      </a>
    </td>
    <td>
      N8N • آیا رابط شما هنوز بک‌اند ندارد؟<br>امتحان کنید <a href="https://n8n.io/">n8n</a>
    </td>
  </tr>
  <tr>
    <td>
      <a href="https://warp.dev/open-webui" target="_blank">
        <img src="https://docs.openwebui.com/sponsors/logos/warp.png" alt="n8n" style="width: 8rem; height: 8rem; border-radius: .75rem;" />
      </a>
    </td>
    <td>
      <a href="https://warp.dev/open-webui">Warp</a> • ترمینال هوشمند برای توسعه‌دهندگان
    </td>
  </tr>
</table>

---

ما بی‌نهایت از حمایت سخاوتمندانه اسپانسرهای خود سپاسگزاریم. حمایت آن‌ها به ما کمک می‌کند تا پروژه را حفظ و بهبود بخشیم و به جامعه خود خدماتی باکیفیت ارائه کنیم. سپاسگزاریم!

## روش نصب 🚀

### نصب با pip پایتون 🐍

Open WebUI را می‌توانید با pip، نصب‌کننده بسته پایتون، نصب کنید. قبل از شروع، مطمئن شوید که از **پایتون 3.11** استفاده می‌کنید تا مشکلات ناسازگاری به وجود نیاید.

1. **نصب Open WebUI**:
   ترمینال را باز کرده و دستور زیر را اجرا کنید:

   ```bash
   pip install open-webui
   ```

2. **اجرای Open WebUI**:
   پس از نصب، با اجرای دستور زیر Open WebUI را راه‌اندازی کنید:

   ```bash
   open-webui serve
   ```

این دستور سرور Open WebUI را راه‌اندازی می‌کند و می‌توانید از طریق [http://localhost:8080](http://localhost:8080) به آن دسترسی داشته باشید.

### شروع سریع با Docker 🐳

> [!NOTE]  
> توجه داشته باشید که برای برخی محیط‌های Docker، پیکربندی‌های اضافه‌ای ممکن است لازم باشد. اگر با مشکل اتصال مواجه شدید، راهنمای کامل ما در [مستندات Open WebUI](https://docs.openwebui.com/) آماده راهنمایی شماست.

> [!WARNING]
> هنگام استفاده از Docker، حتماً پارامتر `-v open-webui:/app/backend/data` را در دستور خود قرار دهید تا دیتابیس به‌درستی متصل شده و از ازدست‌رفتن داده جلوگیری شود.

> [!TIP]  
> اگر قصد دارید Open WebUI را همراه با Ollama یا شتاب‌دهی CUDA اجرا کنید، پیشنهاد می‌کنیم از ایمیج‌های رسمی با تگ `:cuda` یا `:ollama` استفاده کنید. برای فعال‌سازی CUDA، باید [ابزارکیت کانتینر Nvidia CUDA](https://docs.nvidia.com/dgx/nvidia-container-runtime-upgrade/) را روی لینوکس/WSL نصب کنید.

### نصب با پیکربندی پیش‌فرض

- **اگر Ollama روی کامپیوتر شماست**، از دستور زیر استفاده کنید:

  ```bash
  docker run -d -p 3000:8080 --add-host=host.docker.internal:host-gateway -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:main
  ```

- **اگر Ollama روی سرور دیگری است**، از دستور زیر استفاده کنید:

  برای اتصال به Ollama روی سرور دیگر، متغیر `OLLAMA_BASE_URL` را به آدرس سرور تغییر دهید:

  ```bash
  docker run -d -p 3000:8080 -e OLLAMA_BASE_URL=https://example.com -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:main
  ```

- **برای اجرای Open WebUI با پشتیبانی از GPU Nvidia**، از دستور زیر استفاده کنید:

  ```bash
  docker run -d -p 3000:8080 --gpus all --add-host=host.docker.internal:host-gateway -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:cuda
  ```

### نصب فقط برای استفاده از API OpenAI

- **اگر فقط از API OpenAI استفاده می‌کنید**، دستور زیر را اجرا کنید:

  ```bash
  docker run -d -p 3000:8080 -e OPENAI_API_KEY=your_secret_key -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:main
  ```

### نصب Open WebUI با پشتیبانی یکپارچه از Ollama

این روش نصب از یک ایمیج کانتینر استفاده می‌کند که Open WebUI و Ollama را با هم بسته‌بندی کرده و راه‌اندازی را با یک دستور ساده میسر می‌کند. بسته به سخت‌افزار خود، دستور مناسب را انتخاب کنید:

- **با پشتیبانی GPU**:
  برای استفاده از منابع GPU دستور زیر را اجرا کنید:

  ```bash
  docker run -d -p 3000:8080 --gpus=all -v ollama:/root/.ollama -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:ollama
  ```

- **فقط CPU**:
  اگر از GPU استفاده نمی‌کنید، دستور زیر را اجرا کنید:

  ```bash
  docker run -d -p 3000:8080 -v ollama:/root/.ollama -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:ollama
  ```

هر دو دستور نصب بی‌دردسر و یکپارچه Open WebUI و Ollama را فراهم می‌کنند تا بتوانید همه چیز را به سرعت راه‌اندازی کنید.

پس از نصب، از طریق [http://localhost:3000](http://localhost:3000) به Open WebUI دسترسی داشته باشید. لذت ببرید! 😄

### سایر روش‌های نصب

روش‌های متنوعی مثل نصب بومی بدون Docker، Docker Compose، Kustomize و Helm نیز ارائه شده‌اند. به [مستندات Open WebUI](https://docs.openwebui.com/getting-started/) یا [جامعه Discord](https://discord.gg/5rJgQTnV4s) ما مراجعه کنید.

### عیب‌یابی

مشکلات اتصال دارید؟ [مستندات Open WebUI](https://docs.openwebui.com/troubleshooting/) شما را راهنمایی می‌کند. برای کمک بیشتر و پیوستن به جامعه، به [Discord Open WebUI](https://discord.gg/5rJgQTnV4s) سر بزنید.

#### Open WebUI: خطای اتصال سرور

اگر با مشکل اتصال روبرو هستید، معمولاً به دلیل عدم دسترسی کانتینر WebUI به سرور Ollama در 127.0.0.1:11434 (host.docker.internal:11434) داخل کانتینر است. از فلگ `--network=host` در دستور Docker خود استفاده کنید. توجه داشته باشید که در این حالت پورت از 3000 به 8080 تغییر می‌کند و لینک به شکل `http://localhost:8080` خواهد بود.

**نمونه دستور Docker**:

```bash
docker run -d --network=host -v open-webui:/app/backend/data -e OLLAMA_BASE_URL=http://127.0.0.1:11434 --name open-webui --restart always ghcr.io/open-webui/open-webui:main
```

### به‌روزرسانی نصب Docker

برای به‌روزرسانی نصب Docker به آخرین نسخه، می‌توانید از [Watchtower](https://containrrr.dev/watchtower/) استفاده کنید:

```bash
docker run --rm --volume /var/run/docker.sock:/var/run/docker.sock containrrr/watchtower --run-once open-webui
```

در انتهای دستور، اگر نام کانتینر متفاوت است، `open-webui` را تغییر دهید.

راهنمای به‌روزرسانی در [مستندات Open WebUI](https://docs.openwebui.com/getting-started/updating) موجود است.

### استفاده از شاخه Dev 🌙

> [!WARNING]
> شاخه `:dev` شامل آخرین ویژگی‌های ناپایدار است. با مسئولیت خود از آن استفاده کنید چون ممکن است دارای باگ یا امکانات ناقص باشد.

اگر علاقه‌مند به امتحان ویژگی‌های جدید هستید و با پایداری کمتر مشکلی ندارید، از تگ `:dev` به این صورت استفاده کنید:

```bash
docker run -d -p 3000:8080 -v open-webui:/app/backend/data --name open-webui --add-host=host.docker.internal:host-gateway --restart always ghcr.io/open-webui/open-webui:dev
```

### حالت آفلاین

اگر Open WebUI را در محیط آفلاین اجرا می‌کنید، متغیر محیطی `HF_HUB_OFFLINE` را روی `1` قرار دهید تا از تلاش برای دانلود مدل‌ها از اینترنت جلوگیری شود.

```bash
export HF_HUB_OFFLINE=1
```

## گام بعدی؟ 🌟

ویژگی‌های آینده را در نقشه راه ما در [مستندات Open WebUI](https://docs.openwebui.com/roadmap/) کشف کنید.

## مجوز 📜

این پروژه تحت [مجوز Open WebUI](LICENSE) ویرایش‌شده BSD-3-Clause ارائه شده است. شما همان حقوق BSD-3 کلاسیک را دارید: می‌توانید نرم‌افزار را استفاده، تغییر و توزیع کنید، حتی در محصولات اختصاصی و تجاری، با کمترین محدودیت. تنها الزام اضافه حفظ برندینگ "Open WebUI" طبق فایل LICENSE است. برای جزئیات کامل، به [LICENSE](LICENSE) مراجعه کنید. 📄

## پشتیبانی 💬

اگر سوال، پیشنهاد یا نیاز به کمک دارید، یک Issue باز کنید یا به
[جامعه Discord Open WebUI](https://discord.gg/5rJgQTnV4s) بپیوندید! 🤝

## تاریخچه ستاره‌ها

<a href="https://star-history.com/#open-webui/open-webui&Date">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=open-webui/open-webui&type=Date&theme=dark" />
    <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=open-webui/open-webui&type=Date" />
    <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=open-webui/open-webui&type=Date" />
  </picture>
</a>

---

ساخته‌شده توسط [Timothy Jaeryang Baek](https://github.com/tjbck) - بیایید با هم Open WebUI را شگفت‌انگیزتر کنیم! 💪

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---