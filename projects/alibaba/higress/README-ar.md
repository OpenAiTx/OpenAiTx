<a name="readme-top"></a>
<h1 align="center">
    <img src="https://img.alicdn.com/imgextra/i2/O1CN01NwxLDd20nxfGBjxmZ_!!6000000006895-2-tps-960-290.png" alt="Higress" width="240" height="72.5">
  <br>
  بوابة الذكاء الاصطناعي
</h1>
<h4 align="center"> بوابة واجهات برمجة التطبيقات (API) الأصلية للذكاء الاصطناعي </h4>

<div align="center">
    
[![Build Status](https://github.com/alibaba/higress/actions/workflows/build-and-test.yaml/badge.svg?branch=main)](https://github.com/alibaba/higress/actions)
[![license](https://img.shields.io/github/license/alibaba/higress.svg)](https://www.apache.org/licenses/LICENSE-2.0.html)
[![discord](https://img.shields.io/discord/1364956090566971515?color=5865F2&label=discord&labelColor=black&logo=discord&logoColor=white&style=flat-square)](https://discord.gg/tSbww9VDaM)

<a href="https://trendshift.io/repositories/10918" target="_blank"><img src="https://trendshift.io/api/badge/repositories/10918" alt="alibaba%2Fhigress | Trendshift" style="width: 250px; height: 55px;" width="250" height="55"/></a> <a href="https://www.producthunt.com/posts/higress?embed=true&utm_source=badge-featured&utm_medium=badge&utm_souce=badge-higress" target="_blank"><img src="https://api.producthunt.com/widgets/embed-image/v1/featured.svg?post_id=951287&theme=light&t=1745492822283" alt="Higress - Global&#0032;APIs&#0032;as&#0032;MCP&#0032;powered&#0032;by&#0032;AI&#0032;Gateway | Product Hunt" style="width: 250px; height: 54px;" width="250" height="54" /></a>

</div>

[**الموقع الرسمي**](https://higress.ai/en/) &nbsp; |
&nbsp; [**بدء سريع لخادم MCP**](https://higress.cn/en/ai/mcp-quick-start/) &nbsp; |
&nbsp; [**مركز إضافات Wasm**](https://higress.cn/en/plugin/) &nbsp; |

<p>
   English | <a href="README_ZH.md">中文<a/> | <a href="README_JP.md">日本語<a/>
</p>

## ما هو Higress؟

Higress هو بوابة واجهات برمجة تطبيقات سحابية الأصل مبنية على Istio وEnvoy، ويمكن توسيعها بإضافات Wasm مكتوبة بلغة Go أو Rust أو JS. يوفر العشرات من الإضافات الجاهزة متعددة الأغراض ووحدة تحكم جاهزة للاستخدام (جرب [العرض التوضيحي هنا](http://demo.higress.io/)).

### حالات الاستخدام الأساسية

تدعم قدرات بوابة الذكاء الاصطناعي في Higress جميع [مزودي النماذج الرئيسيين](https://github.com/alibaba/higress/tree/main/plugins/wasm-go/extensions/ai-proxy/provider) المحليين والدوليين. كما تدعم استضافة خوادم MCP (بروتوكول سياق النموذج) من خلال آلية الإضافات، مما يمكّن وكلاء الذكاء الاصطناعي من استدعاء الأدوات والخدمات بسهولة. باستخدام أداة [openapi-to-mcp](https://github.com/higress-group/openapi-to-mcpserver)، يمكنك تحويل مواصفات OpenAPI بسرعة إلى خوادم MCP عن بُعد للاستضافة. يوفر Higress إدارة موحدة لكل من واجهات برمجة التطبيقات LLM وMCP.

**🌟 جربه الآن على [https://mcp.higress.ai/](https://mcp.higress.ai/)** لتجربة خوادم MCP المستضافة من Higress بشكل مباشر:

![منصة خادم Higress MCP](https://img.alicdn.com/imgextra/i2/O1CN01nmVa0a1aChgpyyWOX_!!6000000003294-0-tps-3430-1742.jpg)

### اعتماد المؤسسات

وُلد Higress داخل شركة علي بابا لحل مشاكل إعادة تحميل Tengine التي تؤثر على خدمات الاتصال الطويلة ونقص قدرات موازنة التحميل لبروتوكولات gRPC/Dubbo. ضمن سحابة علي بابا، تدعم قدرات بوابة الذكاء الاصطناعي في Higress التطبيقات الأساسية مثل استوديو نموذج Tongyi Bailian، ومنصة تعلم الآلة PAI، وغيرها من خدمات الذكاء الاصطناعي الحرجة. قامت علي بابا ببناء منتج بوابة واجهات برمجة التطبيقات السحابية الأصلية بناءً على Higress، لتوفير ضمان توافر عالي للبوابة بنسبة 99.99% للعديد من العملاء من المؤسسات.

## الملخص

- [**بدء سريع**](#quick-start)    
- [**عرض الميزات**](#feature-showcase)
- [**حالات الاستخدام**](#use-cases)
- [**المزايا الأساسية**](#core-advantages)
- [**المجتمع**](#community)

## بدء سريع

يمكن بدء Higress باستخدام Docker فقط، مما يجعله مناسبًا للمطورين الأفراد لتجربته محليًا لأغراض التعلم أو لبناء مواقع بسيطة:

```bash
# إنشاء دليل العمل
mkdir higress; cd higress
# بدء Higress، سيتم حفظ ملفات التكوين في دليل العمل
docker run -d --rm --name higress-ai -v ${PWD}:/data \
        -p 8001:8001 -p 8080:8080 -p 8443:8443  \
        higress-registry.cn-hangzhou.cr.aliyuncs.com/higress/all-in-one:latest
```

وصف المنافذ:

- المنفذ 8001: مدخل واجهة المستخدم لوحدة تحكم Higress
- المنفذ 8080: مدخل بروتوكول HTTP للبوابة
- المنفذ 8443: مدخل بروتوكول HTTPS للبوابة

> جميع صور Docker لـ Higress تستخدم مستودع الصور الخاص بها ولا تتأثر بقيود معدل Docker Hub.
> بالإضافة إلى ذلك، فإن إرسال وتحديث الصور محمي بآلية فحص أمان (مدعومة من Alibaba Cloud ACR)، مما يجعلها آمنة جدًا للاستخدام في بيئات الإنتاج.
> 
> إذا واجهت مهلة عند سحب الصورة من `higress-registry.cn-hangzhou.cr.aliyuncs.com`، يمكنك تجربة استبدالها بمصدر مرآة Docker التالي:
> 
> **جنوب شرق آسيا**: `higress-registry.ap-southeast-7.cr.aliyuncs.com`

لطرق التثبيت الأخرى مثل النشر باستخدام Helm تحت K8s، يرجى الرجوع إلى [دليل البدء السريع الرسمي](https://higress.io/en-us/docs/user/quickstart).

## حالات الاستخدام

- **استضافة خادم MCP**:

  يستضيف Higress خوادم MCP من خلال آلية الإضافات الخاصة به، مما يمكّن وكلاء الذكاء الاصطناعي من استدعاء الأدوات والخدمات بسهولة. باستخدام أداة [openapi-to-mcp](https://github.com/higress-group/openapi-to-mcpserver)، يمكنك تحويل مواصفات OpenAPI بسرعة إلى خوادم MCP عن بُعد.

  ![](https://img.alicdn.com/imgextra/i1/O1CN01wv8H4g1mS4MUzC1QC_!!6000000004952-2-tps-1764-597.png)

  الفوائد الرئيسية لاستضافة خوادم MCP مع Higress:
  - آليات مصادقة وتفويض موحدة
  - تحديد معدل الاستخدام بدقة لمنع الإساءة
  - سجلات تدقيق شاملة لجميع استدعاءات الأدوات
  - مراقبة غنية للأداء والرؤية
  - تبسيط النشر من خلال آلية الإضافات الخاصة بـ Higress
  - تحديثات ديناميكية بدون انقطاع أو فقدان للاتصال

     [اعرف المزيد...](https://higress.cn/en/ai/mcp-quick-start/?spm=36971b57.7beea2de.0.0.d85f20a94jsWGm)

- **بوابة الذكاء الاصطناعي**:

  يربط Higress جميع مزودي نماذج LLM ببروتوكول موحد، مع قدرات مراقبة الذكاء الاصطناعي، وموازنة تحميل متعددة النماذج، وتحديد معدل الرموز، والتخزين المؤقت:

  ![](https://img.alicdn.com/imgextra/i2/O1CN01izmBNX1jbHT7lP3Yr_!!6000000004566-0-tps-1920-1080.jpg)

- **متحكم دخول Kubernetes**:

  يمكن أن يعمل Higress كمتحكم دخول غني بالميزات، ويتوافق مع العديد من تعليقات متحكم دخول nginx لـ K8s.
  
  [دعم واجهة بوابة Gateway API](https://gateway-api.sigs.k8s.io/) قادم قريبًا، وسيدعم الانتقال السلس من واجهة Ingress API إلى Gateway API.
  
- **بوابة الخدمات المصغرة**:

  يمكن أن يعمل Higress كبوابة للخدمات المصغرة، ويمكنه اكتشاف الخدمات المصغرة من مختلف سجلات الخدمات مثل Nacos وZooKeeper وConsul وEureka وغيرها.
  
  يدمج بعمق مع [Dubbo](https://github.com/apache/dubbo)، [Nacos](https://github.com/alibaba/nacos)، [Sentinel](https://github.com/alibaba/Sentinel) وغيرها من تقنيات الخدمات المصغرة.
  
- **بوابة الأمان**:

  يمكن استخدام Higress كبوابة أمان، ويدعم WAF واستراتيجيات المصادقة المختلفة مثل key-auth وhmac-auth وjwt-auth وbasic-auth وoidc وغيرها.


## المزايا الأساسية

- **جاهز للإنتاج**

  وُلد من منتج داخلي لشركة علي بابا مع أكثر من عامين من التحقق في بيئة الإنتاج، ويدعم سيناريوهات على نطاق واسع مع مئات الآلاف من الطلبات في الثانية.

  يقضي تمامًا على التذبذب في حركة المرور الناتج عن إعادة تحميل Nginx، وتصبح تغييرات التكوين فعالة في أجزاء من الثانية وشفافة للأعمال. مناسب بشكل خاص لسيناريوهات الاتصال الطويل مثل خدمات الذكاء الاصطناعي.

- **معالجة متدفقة**

  يدعم معالجة متدفقة كاملة حقيقية لمحتوى الطلب/الاستجابة، ويمكن لإضافات Wasm تخصيص التعامل مع بروتوكولات البث مثل SSE (أحداث الخادم المرسلة) بسهولة.

  في سيناريوهات النطاق الترددي العالي مثل خدمات الذكاء الاصطناعي، يمكن أن يقلل بشكل كبير من استهلاك الذاكرة.
    
- **سهل التوسعة**
  
  يوفر مكتبة إضافات رسمية غنية تغطي الذكاء الاصطناعي، وإدارة حركة المرور، والحماية الأمنية وغيرها من الوظائف الشائعة، لتلبية أكثر من 90% من متطلبات سيناريوهات الأعمال.

  يركز على توسعة إضافات Wasm، مع ضمان أمان الذاكرة من خلال العزل في الصندوق الرملي، ودعم عدة لغات برمجة، والسماح بترقية إصدارات الإضافات بشكل مستقل، وتحقيق تحديثات فورية لمنطق البوابة دون فقدان حركة المرور.

- **آمن وسهل الاستخدام**
  
  مبني على معايير Ingress API وGateway API، ويوفر وحدة تحكم UI جاهزة، وإضافة حماية WAF، وإضافة حماية CC عبر IP/Cookie جاهزة للاستخدام.

  يدعم الاتصال بـ Let's Encrypt لإصدار وتجديد الشهادات المجانية تلقائيًا، ويمكن نشره خارج K8s، ويبدأ بأمر Docker واحد، مما يجعله مناسبًا جدًا للمطورين الأفراد.

## المجتمع

انضم إلى مجتمعنا على Discord! هنا يمكنك التواصل مع المطورين والمستخدمين المتحمسين الآخرين لـ Higress.

[![discord](https://img.shields.io/discord/1364956090566971515?color=5865F2&label=discord&labelColor=black&logo=discord&logoColor=white&style=for-the-badge)](https://discord.gg/tSbww9VDaM)


### الشكر

لم يكن Higress ممكنًا بدون الأعمال مفتوحة المصدر القيمة لمشاريع المجتمع. نود أن نتوجه بالشكر الخاص إلى Envoy وIstio.

### المستودعات ذات الصلة

- وحدة تحكم Higress: https://github.com/higress-group/higress-console
- Higress Standalone: https://github.com/higress-group/higress-standalone

### المساهمون

<a href="https://github.com/alibaba/higress/graphs/contributors">
  <img alt="contributors" src="https://contrib.rocks/image?repo=alibaba/higress"/>
</a>

### تاريخ النجوم

[![Star History Chart](https://api.star-history.com/svg?repos=alibaba/higress&type=Date)](https://star-history.com/#alibaba/higress&Date)

<p align="right" style="font-size: 14px; color: #555; margin-top: 20px;">
    <a href="#readme-top" style="text-decoration: none; color: #007bff; font-weight: bold;">
        ↑ العودة إلى الأعلى ↑
    </a>
</p>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---