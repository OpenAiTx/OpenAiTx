<a name="readme-top"></a>
<h1 align="center">
    <img src="https://img.alicdn.com/imgextra/i2/O1CN01NwxLDd20nxfGBjxmZ_!!6000000006895-2-tps-960-290.png" alt="Higress" width="240" height="72.5">
  <br>
  دروازه هوشمند AI
</h1>
<h4 align="center"> دروازه API بومی هوش مصنوعی </h4>

<div align="center">
    
[![Build Status](https://github.com/alibaba/higress/actions/workflows/build-and-test.yaml/badge.svg?branch=main)](https://github.com/alibaba/higress/actions)
[![license](https://img.shields.io/github/license/alibaba/higress.svg)](https://www.apache.org/licenses/LICENSE-2.0.html)
[![discord](https://img.shields.io/discord/1364956090566971515?color=5865F2&label=discord&labelColor=black&logo=discord&logoColor=white&style=flat-square)](https://discord.gg/tSbww9VDaM)

<a href="https://trendshift.io/repositories/10918" target="_blank"><img src="https://trendshift.io/api/badge/repositories/10918" alt="alibaba%2Fhigress | Trendshift" style="width: 250px; height: 55px;" width="250" height="55"/></a> <a href="https://www.producthunt.com/posts/higress?embed=true&utm_source=badge-featured&utm_medium=badge&utm_souce=badge-higress" target="_blank"><img src="https://api.producthunt.com/widgets/embed-image/v1/featured.svg?post_id=951287&theme=light&t=1745492822283" alt="Higress - Global&#0032;APIs&#0032;as&#0032;MCP&#0032;powered&#0032;by&#0032;AI&#0032;Gateway | Product Hunt" style="width: 250px; height: 54px;" width="250" height="54" /></a>

</div>

[**سایت رسمی**](https://higress.ai/en/) &nbsp; |
&nbsp; [**آغاز سریع سرور MCP**](https://higress.cn/en/ai/mcp-quick-start/) &nbsp; |
&nbsp; [**هاب افزونه Wasm**](https://higress.cn/en/plugin/) &nbsp; |

<p>
   English | <a href="README_ZH.md">中文<a/> | <a href="README_JP.md">日本語<a/>
</p>

## Higress چیست؟

Higress یک دروازه API ابری بومی بر پایه Istio و Envoy است که قابلیت توسعه با افزونه‌های Wasm نوشته‌شده به زبان Go/Rust/JS را دارد. این محصول ده‌ها افزونه عمومی آماده استفاده و یک کنسول آماده (دمو را [اینجا امتحان کنید](http://demo.higress.io/)) ارائه می‌دهد.

### موارد استفاده اصلی

قابلیت‌های دروازه AI در Higress از همه [ارائه‌دهندگان مدل‌های جریان اصلی](https://raw.githubusercontent.com/alibaba/higress/main/plugins/wasm-go/extensions/ai-proxy/provider) داخلی و خارجی پشتیبانی می‌کند. همچنین از میزبانی سرورهای MCP (Model Context Protocol) از طریق مکانیزم افزونه خود پشتیبانی می‌کند که به عامل‌های هوش مصنوعی اجازه می‌دهد به راحتی ابزارها و سرویس‌های مختلف را فراخوانی کنند. با ابزار [openapi-to-mcp](https://github.com/higress-group/openapi-to-mcpserver)، می‌توانید به سرعت مشخصات OpenAPI را به سرورهای MCP راه دور برای میزبانی تبدیل کنید. Higress مدیریت یکپارچه برای هر دو API LLM و API MCP را فراهم می‌کند.

**🌟 همین حالا امتحان کنید در [https://mcp.higress.ai/](https://mcp.higress.ai/)** تا تجربه‌ای از سرورهای MCP راه دور میزبانی‌شده توسط Higress داشته باشید:

![پلتفرم سرور MCP Higress](https://img.alicdn.com/imgextra/i2/O1CN01nmVa0a1aChgpyyWOX_!!6000000003294-0-tps-3430-1742.jpg)

### پذیرش سازمانی

Higress درون علی‌بابا برای حل مشکلات بارگذاری مجدد Tengine که بر سرویس‌های اتصال بلندمدت تأثیر می‌گذاشت و همچنین فقدان قابلیت‌های کافی متعادل‌سازی بار برای gRPC/Dubbo متولد شد. در علی‌بابا کلود، قابلیت‌های دروازه AI Higress از کاربردهای اصلی هوش مصنوعی مانند استودیو مدل Tongyi Bailian، پلتفرم یادگیری ماشین PAI و سایر خدمات حیاتی AI پشتیبانی می‌کند. علی‌بابا کلود محصول دروازه API ابری بومی خود را بر اساس Higress ساخته و قابلیت‌های سرویس با تضمین دسترسی بالا (99.99%) برای طیف وسیعی از مشتریان سازمانی فراهم کرده است.

## خلاصه

- [**آغاز سریع**](#quick-start)    
- [**نمایش ویژگی‌ها**](#feature-showcase)
- [**موارد استفاده**](#use-cases)
- [**مزایای اصلی**](#core-advantages)
- [**اجتماع**](#community)

## آغاز سریع

Higress را می‌توان تنها با Docker راه‌اندازی کرد و راه‌اندازی محلی برای توسعه‌دهندگان فردی یا ساخت سایت‌های ساده را بسیار آسان می‌کند:

```bash
# ایجاد پوشه کاری
mkdir higress; cd higress
# راه‌اندازی Higress، فایل‌های پیکربندی در پوشه کاری ذخیره می‌شوند
docker run -d --rm --name higress-ai -v ${PWD}:/data \
        -p 8001:8001 -p 8080:8080 -p 8443:8443  \
        higress-registry.cn-hangzhou.cr.aliyuncs.com/higress/all-in-one:latest
```

توضیحات پورت‌ها:

- پورت 8001: ورودی کنسول UI Higress
- پورت 8080: ورودی پروتکل HTTP دروازه
- پورت 8443: ورودی پروتکل HTTPS دروازه

> تمامی تصاویر داکر Higress از ریپازیتوری اختصاصی Higress استفاده می‌کنند و تحت تأثیر محدودیت‌های نرخ Docker Hub قرار نمی‌گیرند.
> همچنین، ثبت و به‌روزرسانی تصاویر توسط مکانیزم اسکن امنیتی (توسط Alibaba Cloud ACR) محافظت می‌شود، بنابراین استفاده از آن‌ها در محیط‌های تولیدی بسیار ایمن است.
> 
> اگر هنگام کشیدن تصویر از `higress-registry.cn-hangzhou.cr.aliyuncs.com` با تایم‌اوت مواجه شدید، می‌توانید منبع آینه‌ داکر زیر را امتحان کنید:
> 
> **جنوب شرق آسیا**: `higress-registry.ap-southeast-7.cr.aliyuncs.com`

برای سایر روش‌های نصب مانند استقرار Helm در K8s، لطفا به [مستندات آغاز سریع رسمی](https://higress.io/en-us/docs/user/quickstart) مراجعه فرمایید.

## موارد استفاده

- **میزبانی سرور MCP**:

  Higress از طریق مکانیزم افزونه خود سرورهای MCP را میزبانی می‌کند که به عامل‌های AI اجازه می‌دهد به راحتی ابزارها و سرویس‌های مختلف را فراخوانی کنند. با ابزار [openapi-to-mcp](https://github.com/higress-group/openapi-to-mcpserver)، می‌توانید به سرعت مشخصات OpenAPI را به سرورهای MCP راه دور تبدیل کنید.

  ![](https://img.alicdn.com/imgextra/i1/O1CN01wv8H4g1mS4MUzC1QC_!!6000000004952-2-tps-1764-597.png)

  مزایای کلیدی میزبانی سرور MCP با Higress:
  - مکانیزم‌های احراز هویت و مجوزدهی یکپارچه
  - محدودسازی نرخ دقیق برای جلوگیری از سوءاستفاده
  - لاگ‌های جامع برای تمام فراخوانی ابزارها
  - قابلیت مشاهده غنی برای مانیتورینگ عملکرد
  - استقرار ساده از طریق مکانیزم افزونه Higress
  - به‌روزرسانی پویا بدون اختلال یا قطع اتصال

     [مطالعه بیشتر...](https://higress.cn/en/ai/mcp-quick-start/?spm=36971b57.7beea2de.0.0.d85f20a94jsWGm)

- **دروازه هوشمند AI**:

  Higress با استفاده از یک پروتکل یکپارچه به همه ارائه‌دهندگان مدل LLM متصل می‌شود و قابلیت مشاهده هوش مصنوعی، متعادل‌سازی بار چندمدلی، محدودسازی نرخ توکن و کش را ارائه می‌دهد:

  ![](https://img.alicdn.com/imgextra/i2/O1CN01izmBNX1jbHT7lP3Yr_!!6000000004566-0-tps-1920-1080.jpg)

- **کنترلر اینگرس Kubernetes**:

  Higress می‌تواند به عنوان یک کنترلر اینگرس با ویژگی‌های غنی عمل کند که با بسیاری از حاشیه‌نویسی‌های کنترلر اینگرس nginx در K8s سازگار است.
  
  پشتیبانی از [Gateway API](https://gateway-api.sigs.k8s.io/) به زودی ارائه خواهد شد و مهاجرت روان از Ingress API به Gateway API را ممکن می‌سازد.
  
- **دروازه میکروسرویس**:

  Higress می‌تواند به عنوان یک دروازه میکروسرویس عمل کند که می‌تواند میکروسرویس‌ها را از رجیستری‌های مختلف مانند Nacos، ZooKeeper، Consul، Eureka و غیره کشف کند.
  
  ادغام عمیق با [Dubbo](https://github.com/apache/dubbo)، [Nacos](https://github.com/alibaba/nacos)، [Sentinel](https://github.com/alibaba/Sentinel) و سایر تکنولوژی‌های میکروسرویس را داراست.
  
- **دروازه امنیتی**:

  Higress می‌تواند به عنوان یک دروازه امنیتی مورد استفاده قرار گیرد و از WAF و استراتژی‌های مختلف احراز هویت مانند key-auth، hmac-auth، jwt-auth، basic-auth، oidc و غیره پشتیبانی می‌کند.


## مزایای اصلی

- **درجه تولید (Production Grade)**

  متولد شده از محصول داخلی علی‌بابا با بیش از ۲ سال اعتبارسنجی در محیط واقعی، پشتیبانی از سناریوهای مقیاس بزرگ با صدها هزار درخواست در ثانیه.

  کاملاً حذف لرزش ترافیک ناشی از بارگذاری مجدد Nginx، تغییرات پیکربندی در کسری از ثانیه اعمال می‌شوند و برای کسب‌وکار شفاف هستند. به ویژه برای سناریوهای اتصال بلند مانند کسب‌وکارهای AI بسیار مناسب است.

- **پردازش جریانی (Streaming Processing)**

  پشتیبانی کامل از پردازش جریانی کامل بدنه درخواست/پاسخ، افزونه‌های Wasm به راحتی می‌توانند پروتکل‌های جریانی مانند SSE (Server-Sent Events) را سفارشی‌سازی کنند.

  در سناریوهای پهنای باند بالا مانند کسب‌وکارهای AI، می‌تواند به طور قابل توجهی سربار حافظه را کاهش دهد.
    
- **قابلیت توسعه آسان**
  
  ارائه کتابخانه افزونه رسمی غنی شامل AI، مدیریت ترافیک، محافظت امنیتی و سایر عملکردهای عمومی که بیش از ۹۰٪ نیازهای سناریوی کسب‌وکار را پوشش می‌دهد.

  تمرکز بر توسعه افزونه Wasm، تضمین ایمنی حافظه از طریق ایزولاسیون سندباکس، پشتیبانی از زبان‌های برنامه‌نویسی متعدد، امکان ارتقاء مستقل نسخه افزونه و به‌روزرسانی بدون از دست دادن ترافیک منطق دروازه.

- **ایمن و آسان برای استفاده**
  
  مبتنی بر استانداردهای Ingress API و Gateway API، کنسول UI آماده، افزونه محافظت WAF، افزونه محافظت IP/Cookie CC آماده استفاده.

  پشتیبانی از اتصال به Let's Encrypt برای صدور و تمدید خودکار گواهینامه‌های رایگان و قابلیت استقرار خارج از K8s، راه‌اندازی تنها با یک دستور Docker برای توسعه‌دهندگان فردی بسیار مناسب است.

## اجتماع

به اجتماع Discord ما بپیوندید! اینجا می‌توانید با توسعه‌دهندگان و سایر کاربران علاقه‌مند به Higress ارتباط برقرار کنید.

[![discord](https://img.shields.io/discord/1364956090566971515?color=5865F2&label=discord&labelColor=black&logo=discord&logoColor=white&style=for-the-badge)](https://discord.gg/tSbww9VDaM)


### تشکر

Higress بدون مشارکت ارزشمند پروژه‌های متن‌باز جامعه امکان‌پذیر نبود. ما به ویژه از Envoy و Istio تشکر ویژه داریم.

### مخازن مرتبط

- کنسول Higress: https://github.com/higress-group/higress-console
- نسخه مستقل Higress: https://github.com/higress-group/higress-standalone

### مشارکت‌کنندگان

<a href="https://github.com/alibaba/higress/graphs/contributors">
  <img alt="contributors" src="https://contrib.rocks/image?repo=alibaba/higress"/>
</a>

### تاریخچه ستاره‌ها

[![Star History Chart](https://api.star-history.com/svg?repos=alibaba/higress&type=Date)](https://star-history.com/#alibaba/higress&Date)

<p align="right" style="font-size: 14px; color: #555; margin-top: 20px;">
    <a href="#readme-top" style="text-decoration: none; color: #007bff; font-weight: bold;">
        ↑ بازگشت به بالا ↑
    </a>
</p>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---