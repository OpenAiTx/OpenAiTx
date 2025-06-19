# .NET Aspire

[![الاختبارات](https://github.com/dotnet/aspire/actions/workflows/tests.yml/badge.svg?branch=main&event=push)](https://github.com/dotnet/aspire/actions/workflows/tests.yml)
[![حالة البناء](https://dev.azure.com/dnceng-public/public/_apis/build/status%2Fdotnet%2Faspire%2Fdotnet.aspire?branchName=main)](https://dev.azure.com/dnceng-public/public/_build/latest?definitionId=274&branchName=main)
[![مطلوب مساعدة](https://img.shields.io/github/issues/dotnet/aspire/help%20wanted?style=flat&color=%24EC820&label=help%20wanted)](https://github.com/dotnet/aspire/labels/help%20wanted)
[![قضية أولى جيدة](https://img.shields.io/github/issues/dotnet/aspire/good%20first%20issue?style=flat&color=%24EC820&label=good%20first%20issue)](https://github.com/dotnet/aspire/labels/good%20first%20issue)
[![ديسكورد](https://img.shields.io/discord/732297728826277939?style=flat&logo=discord&logoColor=white&label=Join%20our%20Discord&labelColor=512bd4&color=cyan)](https://discord.com/invite/h87kDAHQgJ)

## ما هو .NET Aspire؟

.NET Aspire هو مجموعة جاهزة للسحابة لبناء تطبيقات موزعة قابلة للرصد وجاهزة للإنتاج. يتم تسليم .NET Aspire من خلال مجموعة من حزم NuGet التي تتعامل مع اهتمامات محددة للسحابة الأصلية. غالبًا ما تتكون تطبيقات السحابة الأصلية من أجزاء صغيرة مترابطة أو خدمات مصغرة بدلاً من قاعدة كود واحدة ضخمة. كما تستهلك تطبيقات السحابة الأصلية عادة عددًا كبيرًا من الخدمات مثل قواعد البيانات والرسائل والتخزين المؤقت.

يساعدك .NET Aspire في:

[التنسيق](https://learn.microsoft.com/dotnet/aspire/get-started/aspire-overview?#orchestration): يوفر .NET Aspire ميزات لتشغيل وربط تطبيقات متعددة المشاريع واحتياجاتها.

[التكاملات](https://learn.microsoft.com/dotnet/aspire/get-started/aspire-overview?#net-aspire-integrations): تكاملات .NET Aspire هي حزم NuGet لخدمات مستخدمة بشكل شائع مثل Redis أو Postgres، بواجهات موحدة لضمان اتصالها المتسق والسلس مع تطبيقك.

[الأدوات](https://learn.microsoft.com/dotnet/aspire/get-started/aspire-overview?#project-templates-and-tooling): يأتي .NET Aspire مع قوالب مشاريع وتجارب أدوات لكل من Visual Studio وdotnet CLI لمساعدتك في إنشاء والتفاعل مع تطبيقات .NET Aspire.

لمعرفة المزيد، اقرأ [نظرة عامة كاملة على .NET Aspire والوثائق](https://learn.microsoft.com/dotnet/aspire/). تتوفر عينات في [مستودع عينات .NET Aspire](https://github.com/dotnet/aspire-samples). يمكنك العثور على [عينة eShop هنا](https://github.com/dotnet/eshop) و[نسخة Azure هنا](https://github.com/Azure-Samples/eShopOnAzure).

## ماذا يوجد في هذا المستودع؟

مضيف تطبيقات .NET Aspire ولوحة المعلومات وبنية اكتشاف الخدمات وجميع تكاملات .NET Aspire. كما يحتوي أيضًا على قوالب المشاريع.

## استخدام آخر الإصدارات اليومية

اتبع التعليمات في [docs/using-latest-daily.md](https://raw.githubusercontent.com/dotnet/aspire/main/docs/using-latest-daily.md) للبدء باستخدام .NET Aspire مع أحدث إصدار يومي.

## كيف يمكنني المساهمة؟

نرحب بالمساهمات! لقد ساعد العديد من الأشخاص حول العالم في تحسين .NET.

اتبع التعليمات في [docs/contributing.md](https://raw.githubusercontent.com/dotnet/aspire/main/docs/contributing.md) للعمل على الكود في المستودع.

## الإبلاغ عن قضايا الأمان والأخطاء الأمنية

يجب الإبلاغ عن قضايا الأمان والأخطاء بشكل خاص عبر البريد الإلكتروني إلى مركز استجابة الأمان في مايكروسوفت (MSRC) <secure@microsoft.com>. يجب أن تتلقى ردًا خلال 24 ساعة. إذا لم يحدث ذلك لأي سبب، يرجى المتابعة عبر البريد الإلكتروني للتأكد من استلامنا لرسالتك الأصلية. يمكن العثور على مزيد من المعلومات، بما في ذلك مفتاح PGP الخاص بـ MSRC، في [مركز تقنية الأمان](https://www.microsoft.com/msrc/faqs-report-an-issue). يمكنك أيضًا العثور على هذه التعليمات في [وثيقة الأمان](https://raw.githubusercontent.com/dotnet/aspire/main/SECURITY.md) في هذا المستودع.

راجع أيضًا معلومات عن [برنامج مكافآت أخطاء Microsoft .NET Core وASP.NET Core](https://www.microsoft.com/msrc/bounty-dot-net-core).

### ملاحظة حول الحاويات المستخدمة بواسطة موارد وتكاملات عملاء .NET Aspire

لا يمكن لفريق .NET تقييم الحاويات الخارجية الأساسية التي ندعمها من خلال واجهات برمجة التطبيقات من حيث ملاءمتها لمتطلبات العملاء المحددة.

يجب عليك تقييم أي حاويات تختار تجميعها وأتمتتها مع Aspire لضمان تلبيتها لمتطلباتك أو متطلبات صاحب العمل أو حكومتك من حيث الأمان والسلامة بالإضافة إلى اللوائح التشفيرية وأي معايير تنظيمية أو مؤسسية أخرى قد تنطبق على استخدامك للحاوية.

## مؤسسة .NET

.NET Aspire هو مشروع تابع لـ[مؤسسة .NET](https://www.dotnetfoundation.org/projects).

هناك العديد من المشاريع المتعلقة بـ .NET على GitHub.

* [المستودع الرئيسي لـ .NET](https://github.com/Microsoft/dotnet) - روابط لمئات مشاريع .NET، من مايكروسوفت والمجتمع.
* [الصفحة الرئيسية لـ ASP.NET Core](https://docs.microsoft.com/aspnet/core) - أفضل مكان للبدء في تعلم ASP.NET Core.

لقد اعتمد هذا المشروع مدونة السلوك المعرفة في [Contributor Covenant](https://contributor-covenant.org) لتوضيح السلوك المتوقع في مجتمعنا. لمزيد من المعلومات، راجع [مدونة سلوك مؤسسة .NET](https://www.dotnetfoundation.org/code-of-conduct).

## الترخيص

الكود في هذا المستودع مرخص بموجب [ترخيص MIT](https://raw.githubusercontent.com/dotnet/aspire/main/LICENSE.TXT).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---