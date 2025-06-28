# free-for.dev

يتمتع المطورون ومؤلفو البرمجيات مفتوحة المصدر الآن بالعديد من الخدمات التي تقدم مستويات مجانية، ولكن العثور عليها جميعًا يستغرق وقتًا لاتخاذ قرارات مستنيرة.

هذه قائمة بالبرمجيات (SaaS، PaaS، IaaS، إلخ) والعروض الأخرى التي تحتوي على مستويات مجانية للمطورين.

نطاق هذه القائمة محدود بالأشياء التي من المرجح أن يجدها مطورو البنية التحتية (مسؤولو النظام، ممارسو DevOps، إلخ) مفيدة. نحن نحب جميع الخدمات المجانية الموجودة، لكن من الأفضل أن نبقيها ضمن الموضوع. أحيانًا يكون هناك خط رمادي، لذا هذه القائمة تعكس وجهة نظري؛ من فضلك لا تشعر بالإهانة إذا لم أقبل مساهمتك.

هذه القائمة هي نتيجة لطلبات السحب، والمراجعات، والأفكار، والعمل الذي قام به أكثر من 1600 شخص. يمكنك أيضًا المساعدة عن طريق إرسال [طلبات السحب](https://github.com/ripienaar/free-for-dev) لإضافة المزيد من الخدمات أو إزالة تلك التي تغيرت عروضها أو تم إيقافها.

[![Track Awesome List](https://www.trackawesomelist.com/badge.svg)](https://www.trackawesomelist.com/ripienaar/free-for-dev)

**ملاحظة**: هذه القائمة مخصصة فقط للعروض كخدمة (as-a-Service)، وليست للبرمجيات المستضافة ذاتيًا. لكي تكون الخدمة مؤهلة، يجب أن تقدم مستوى مجاني، وليس مجرد تجربة مجانية. يجب أن يكون المستوى المجاني لمدة سنة على الأقل إذا كان محدودًا زمنياً. نحن نأخذ في الاعتبار أيضًا المستوى المجاني من منظور الأمان، لذا المصادقة الموحدة (SSO) مقبولة، لكنني لن أقبل الخدمات التي تقيّد TLS فقط للمستويات المدفوعة.

# جدول المحتويات

  * [حدود مقدمي الخدمات السحابية الرئيسية المجانية دائمًا](#major-cloud-providers)
  * [حلول إدارة السحابة](#cloud-management-solutions)
  * [التحليلات، الأحداث والإحصاءات](#analytics-events-and-statistics)
  * [واجهات برمجة التطبيقات، البيانات والذكاء الاصطناعي](#apis-data-and-ml)
  * [مستودعات الحزم](#artifact-repos)
  * [المنصات الخلفية كخدمة](#baas)
  * [منصة البرمجة منخفضة الكود](#low-code-platform)
  * [شبكات توزيع المحتوى والحماية](#cdn-and-protection)
  * [التكامل والتسليم المستمر](#ci-and-cd)
  * [أنظمة إدارة المحتوى](#cms)
  * [توليد الكود](#code-generation)
  * [جودة الكود](#code-quality)
  * [البحث وتصفح الكود](#code-search-and-browsing)
  * [إدارة الأعطال والاستثناءات](#crash-and-exception-handling)
  * [تصوير البيانات على الخرائط](#data-visualization-on-maps)
  * [خدمات البيانات المدارة](#managed-data-services)
  * [التصميم وواجهة المستخدم](#design-and-ui)
  * [إلهام التصميم](#design-inspiration)
  * [مواقع التدوين للمطورين](#dev-blogging-sites)
  * [نظام أسماء النطاقات](#dns)
  * [كل ما يخص Docker](#docker-related)
  * [النطاقات](#domain)
  * [التعليم وتطوير المسار المهني](#education-and-career-development)
  * [البريد الإلكتروني](#email)
  * [منصات إدارة تبديل الميزات](#feature-toggles-management-platforms)
  * [الخطوط](#font)
  * [النماذج](#forms)
  * [الذكاء الاصطناعي التوليدي](#generative-ai)
  * [البنية التحتية كخدمة](#iaas)
  * [بيئات التطوير وتحرير الكود](#ide-and-code-editing)
  * [واجهات برمجة تحقق أرقام الهواتف الدولية وSDK](#international-mobile-number-verification-api-and-sdk)
  * [تتبع المشكلات وإدارة المشاريع](#issue-tracking-and-project-management)
  * [إدارة السجلات](#log-management)
  * [توزيع تطبيقات الهواتف المحمولة والتغذية الراجعة](#mobile-app-distribution-and-feedback)
  * [أنظمة الإدارة](#management-system)
  * [المراسلة والبث](#messaging-and-streaming)
  * [متنوع](#miscellaneous)
  * [المراقبة](#monitoring)
  * [المنصات كخدمة](#paas)
  * [أنظمة بناء الحزم](#package-build-system)
  * [تكامل الدفع والفوترة](#payment-and-billing-integration)
  * [إدارة الخصوصية](#privacy-management)
  * [واجهات برمجة التقاط الصور](#screenshot-apis)
  * [خدمات Flutter وبناء تطبيقات iOS بدون Mac](#flutter-related-and-building-ios-apps-without-mac)
  * [البحث](#search)
  * [الأمن والبنية التحتية للمفاتيح العامة](#security-and-pki)
  * [المصادقة، التفويض وإدارة المستخدمين](#authentication-authorization-and-user-management)
  * [مستودعات الكود المصدري](#source-code-repos)
  * [التخزين ومعالجة الوسائط](#storage-and-media-processing)
  * [النفق، WebRTC، خوادم Web Socket ومسارات أخرى](#tunneling-webrtc-web-socket-servers-and-other-routers)
  * [الاختبار](#testing)
  * [أدوات الفرق والتعاون](#tools-for-teams-and-collaboration)
  * [إدارة الترجمة](#translation-management)
  * [كل ما يخص Vagrant](#vagrant-related)
  * [تسجيل جلسات الزوار](#visitor-session-recording)
  * [استضافة المواقع](#web-hosting)
  * [منصات التعليق](#commenting-platforms)
  * [محاكاة الأجهزة في المتصفح](#browser-based-hardware-emulation-written-in-javascript)
  * [أدوات سطح المكتب البعيد](#remote-desktop-tools)
  * [تطوير الألعاب](#game-development)
  * [موارد مجانية أخرى](#other-free-resources)

## مقدمو الخدمات السحابية الرئيسيون

  * [منصة جوجل السحابية](https://cloud.google.com)
    * App Engine - 28 ساعة مثيل أمامي في اليوم، 9 ساعات مثيل خلفي في اليوم
    * Cloud Firestore - 1 جيجابايت تخزين، 50,000 قراءة، 20,000 كتابة، 20,000 حذف يوميًا
    * Compute Engine - 1 e2-micro غير قابل للإيقاف المسبق، 30 جيجابايت HDD، 5 جيجابايت تخزين snapshots (مقتصر على مناطق معينة)، 1 جيجابايت نقل بيانات خارجي من أمريكا الشمالية إلى جميع الوجهات (باستثناء الصين وأستراليا) شهريًا
    * Cloud Storage - 5 جيجابايت، 1 جيجابايت نقل بيانات خارجي
    * Cloud Shell - واجهة لينكس عبر الويب/بيئة تطوير أساسية مع 5 جيجابايت تخزين دائم. حد 60 ساعة أسبوعياً
    * Cloud Pub/Sub - 10 جيجابايت من الرسائل شهريًا
    * Cloud Functions - 2 مليون تنفيذ شهريًا (يشمل كل من التنفيذ الخلفي وHTTP)
    * Cloud Run - 2 مليون طلب شهريًا، 360,000 جيجابايت-ثانية ذاكرة، 180,000 vCPU-ثانية وقت معالجة، 1 جيجابايت نقل بيانات خارجي من أمريكا الشمالية شهريًا
    * Google Kubernetes Engine - لا توجد رسوم إدارة عنقودية لعنقود منطقة واحدة. كل عقدة مستخدم يتم احتسابها بسعر Compute Engine القياسي
    * BigQuery - 1 تيرابايت استعلامات شهريًا، 10 جيجابايت تخزين شهريًا
    * Cloud Build - 120 دقيقة بناء يومياً
    * Cloud Source Repositories - حتى 5 مستخدمين، 50 جيجابايت تخزين، 50 جيجابايت نقل بيانات خارجي
    * [Google Colab](https://colab.research.google.com/) - بيئة تطوير مجانية لـ Jupyter Notebooks.
    * [Firebase Studio](https://firebase.studio) جوجل Firebase Studio (كان يسمى سابقًا Project IDX). VSCode على الإنترنت يعمل على سحابة جوجل.
    * قائمة كاملة ومفصلة - https://cloud.google.com/free

  * [خدمات أمازون ويب](https://aws.amazon.com)
    * [CloudFront](https://aws.amazon.com/cloudfront/) - 1 تيرابايت نقل بيانات خارجي شهريًا و2 مليون تنفيذ للوظائف شهريًا
    * [CloudWatch](https://aws.amazon.com/cloudwatch/) - 10 مقاييس مخصصة وعشرة تنبيهات
* [CodeBuild](https://aws.amazon.com/codebuild/) - 100 دقيقة من وقت البناء شهريًا  
* [CodeCommit](https://aws.amazon.com/codecommit/) - 5 مستخدمين نشطين، 50 جيجابايت تخزين، و 10000 طلب شهريًا  
* [CodePipeline](https://aws.amazon.com/codepipeline/) - خط أنابيب نشط واحد شهريًا  
* [DynamoDB](https://aws.amazon.com/dynamodb/) - قاعدة بيانات NoSQL بسعة 25 جيجابايت  
* [EC2](https://aws.amazon.com/ec2/) - 750 ساعة شهريًا من t2.micro أو t3.micro (لمدة 12 شهرًا). 100 جيجابايت نقل بيانات صادر شهريًا  
* [EBS](https://aws.amazon.com/ebs/) - 30 جيجابايت شهريًا من التخزين العام (SSD) أو مغناطيسي (لمدة 12 شهرًا)  
* [Elastic Load Balancing](https://aws.amazon.com/elasticloadbalancing/) - 750 ساعة شهريًا (لمدة 12 شهرًا)  
* [RDS](https://aws.amazon.com/rds/) - 750 ساعة شهريًا من db.t2.micro أو db.t3.micro أو db.t4g.micro، 20 جيجابايت من تخزين SSD عام، 20 جيجابايت نسخ احتياطية للتخزين (لمدة 12 شهرًا)  
* [S3](https://aws.amazon.com/s3/) - 5 جيجابايت تخزين كائنات قياسي، 20 ألف طلب Get و 2000 طلب Put شهريًا (لمدة 12 شهرًا)  
* [Glacier](https://aws.amazon.com/glacier/) - 10 جيجابايت تخزين كائنات طويل الأمد  
* [Lambda](https://aws.amazon.com/lambda/) - مليون طلب شهريًا  
* [SNS](https://aws.amazon.com/sns/) - مليون نشر شهريًا  
* [SES](https://aws.amazon.com/ses/) - 3,000 رسالة شهريًا (لمدة 12 شهرًا)  
* [SQS](https://aws.amazon.com/sqs/) - مليون طلب قائمة انتظار رسائل  
* قائمة كاملة ومفصلة - https://aws.amazon.com/free/

* [Microsoft Azure](https://azure.microsoft.com)  
  * [Virtual Machines](https://azure.microsoft.com/services/virtual-machines/) - جهاز افتراضي واحد B1S Linux، وجهاز افتراضي واحد B1S Windows (لمدة 12 شهرًا)  
  * [App Service](https://azure.microsoft.com/services/app-service/) - 10 تطبيقات ويب أو تطبيقات جوال أو تطبيقات API (60 دقيقة CPU/يوم)  
  * [Functions](https://azure.microsoft.com/services/functions/) - مليون طلب شهريًا  
  * [DevTest Labs](https://azure.microsoft.com/services/devtest-lab/) - تفعيل بيئات تطوير واختبار سريعة وسهلة واقتصادية  
  * [Active Directory](https://azure.microsoft.com/services/active-directory/) - 500,000 عنصر  
  * [Active Directory B2C](https://azure.microsoft.com/services/active-directory/external-identities/b2c/) - 50,000 مستخدم مخزن شهريًا  
  * [Azure DevOps](https://azure.microsoft.com/services/devops/) - 5 مستخدمين نشطين، مستودعات Git خاصة غير محدودة  
  * [Azure Pipelines](https://azure.microsoft.com/services/devops/pipelines/) — 10 وظائف متوازية مجانية مع دقائق غير محدودة للمصادر المفتوحة على Linux وmacOS وWindows  
  * [Microsoft IoT Hub](https://azure.microsoft.com/services/iot-hub/) - 8,000 رسالة يوميًا  
  * [Load Balancer](https://azure.microsoft.com/services/load-balancer/) - عنوان IP عام متوازن التحميل واحد مجاني (VIP)  
  * [Notification Hubs](https://azure.microsoft.com/services/notification-hubs/) - مليون إشعار دفع  
  * [Bandwidth](https://azure.microsoft.com/pricing/details/bandwidth/) - 15 جيجابايت واردة (لمدة 12 شهرًا) و5 جيجابايت صادرة شهريًا  
  * [Cosmos DB](https://azure.microsoft.com/services/cosmos-db/) - 25 جيجابايت تخزين و1000 وحدة طلب توفيرية  
  * [Static Web Apps](https://azure.microsoft.com/pricing/details/app-service/static/) — بناء ونشر واستضافة تطبيقات ثابتة ودوال بدون خوادم مع SSL مجاني، التوثيق/التفويض، ونطاقات مخصصة  
  * [Storage](https://azure.microsoft.com/services/storage/) - 5 جيجابايت تخزين ملفات أو كائنات LRS (لمدة 12 شهرًا)  
  * [Cognitive Services](https://azure.microsoft.com/services/cognitive-services/) - واجهات برمجة تطبيقات الذكاء الاصطناعي/تعلم الآلة (رؤية حاسوبية، ترجمة، كشف الوجوه، روبوتات، وغيرها) مع طبقة مجانية تشمل عدد معاملات محدود  
  * [Cognitive Search](https://azure.microsoft.com/services/search/#features) - خدمة بحث وفهرسة تعتمد على الذكاء الاصطناعي، مجانية لـ 10,000 مستند  
  * [Azure Kubernetes Service](https://azure.microsoft.com/services/kubernetes-service/) - خدمة Kubernetes مُدارة، إدارة عنقود مجانية  
  * [Event Grid](https://azure.microsoft.com/services/event-grid/) - 100 ألف عملية شهريًا  
  * قائمة كاملة ومفصلة - https://azure.microsoft.com/free/

* [Oracle Cloud](https://www.oracle.com/cloud/)  
  * الحوسبة  
     - جهازان افتراضيان للحوسبة معتمدان على AMD بقدرة 1/8 OCPU و1 جيجابايت ذاكرة لكل واحد  
     - 4 أنوية Arm Ampere A1 و24 جيجابايت ذاكرة يمكن استخدامها كجهاز افتراضي واحد أو حتى 4 أجهزة  
     - ستتم استعادة الأجهزة عند [اعتبارها خاملة](https://docs.oracle.com/en-us/iaas/Content/FreeTier/freetier_topic-Always_Free_Resources.htm#compute__idleinstances)  
  * حجم الكتلة - حجمين، 200 جيجابايت إجمالي (يستخدم للحوسبة)  
  * تخزين الكائنات - 10 جيجابايت  
  * موازن التحميل - جهاز واحد بسرعة 10 ميجابت/ثانية  
  * قواعد البيانات - قاعدتا بيانات، 20 جيجابايت لكل واحدة  
  * المراقبة - 500 مليون نقطة بيانات مدخلة، مليار نقطة بيانات مسترجعة  
  * النطاق الترددي - 10 تيرابايت نقل بيانات صادر شهريًا، سرعة محددة بـ 50 ميجابت/ث على أجهزة x64 و500 ميجابت/ث لكل نواة على أجهزة ARM  
  * عنوان IP عام - 2 IPv4 للأجهزة الافتراضية، 1 IPv4 لموازن التحميل  
  * الإشعارات - مليون خيار تسليم شهريًا، 1000 بريد إلكتروني مرسل شهريًا  
  * قائمة كاملة ومفصلة - https://www.oracle.com/cloud/free/

* [IBM Cloud](https://www.ibm.com/cloud/free/)  
  * قاعدة بيانات Cloudant - 1 جيجابايت تخزين بيانات  
  * قاعدة بيانات Db2 - 100 ميجابايت تخزين بيانات  
  * API Connect - 50,000 مكالمة API شهريًا  
  * مراقبة التوافر - 3 ملايين نقطة بيانات شهريًا  
  * تحليل السجلات - 500 ميجابايت سجلات يوميًا  
  * قائمة كاملة ومفصلة - https://www.ibm.com/cloud/free/

* [Cloudflare](https://www.cloudflare.com/)  
  * [خدمات التطبيقات](https://www.cloudflare.com/plans/) - DNS مجاني لعدد غير محدود من النطاقات، حماية DDoS، CDN مع SSL مجاني، قواعد جدار حماية وقواعد صفحات، WAF، تخفيف الروبوتات، تحديد معدل مجاني غير محدود - قاعدة واحدة لكل نطاق، تحليلات، إعادة توجيه البريد الإلكتروني  
  * [Zero Trust & SASE](https://www.cloudflare.com/plans/zero-trust-services/) - حتى 50 مستخدمًا، 24 ساعة من تسجيل النشاط، ثلاث مواقع شبكية  
  * [Cloudflare Tunnel](https://www.cloudflare.com/products/tunnel/) - يمكنك كشف منفذ HTTP محلي عبر نفق إلى نطاق فرعي عشوائي على trycloudflare.com باستخدام [Quick Tunnels](https://developers.cloudflare.com/cloudflare-one/connections/connect-networks/do-more-with-tunnels/trycloudflare/)، لا حاجة لحساب. مزيد من الميزات (نفق TCP، موازنة التحميل، VPN) في [Zero Trust](https://www.cloudflare.com/products/zero-trust/) خطة مجانية.  
  * [Workers](https://developers.cloudflare.com/workers/) - نشر كود بلا خوادم مجانًا على شبكة Cloudflare العالمية — 100 ألف طلب يوميًا.  
  * [Workers KV](https://developers.cloudflare.com/kv) - 100 ألف طلب قراءة يوميًا، 1000 طلب كتابة يوميًا، 1000 طلب حذف يوميًا، 1000 طلب قائمة يوميًا، 1 جيجابايت بيانات مخزنة  
  * [R2](https://developers.cloudflare.com/r2/) - 10 جيجابايت شهريًا، مليون عملية من الفئة A شهريًا، 10 ملايين عملية من الفئة B شهريًا  
  * [D1](https://developers.cloudflare.com/d1/) - 5 ملايين صف قراءة يوميًا، 100 ألف صف كتابة يوميًا، 1 جيجابايت تخزين  
  * [Pages](https://developers.cloudflare.com/pages/) - تطوير ونشر تطبيقاتك على شبكة Cloudflare السريعة والآمنة. 500 بناء شهريًا، 100 نطاق مخصص، SSL مدمج، مقاعد غير محدودة، عمليات نشر معاينة غير محدودة، وإمكانيات كاملة عبر تكامل Cloudflare Workers.  
  * [Queues](https://developers.cloudflare.com/queues/) - مليون عملية شهريًا  
  * [TURN](https://developers.cloudflare.com/calls/turn/) – 1 تيرابايت نقل بيانات (صادرة) مجاني شهريًا.

**[⬆️ العودة إلى الأعلى](#table-of-contents)**

## حلول إدارة السحابة

* [Brainboard](https://www.brainboard.co) - حل تعاوني لبناء وإدارة البنية التحتية السحابية بصريًا من البداية إلى النهاية.
* [Cloud 66](https://www.cloud66.com/) - مجاني للمشاريع الشخصية (يشمل خادم نشر واحد، وموقع ثابت واحد)، يوفر Cloud 66 كل ما تحتاجه لبناء ونشر وتطوير تطبيقاتك على أي سحابة دون صداع "أمور الخادم".
* [Pulumi](https://www.pulumi.com/) — منصة حديثة للبنية التحتية ككود تتيح لك استخدام لغات وأدوات البرمجة المألوفة لبناء ونشر وإدارة البنية التحتية السحابية.
* [terraform.io](https://www.terraform.io/) — Terraform Cloud. إدارة حالة عن بعد مجانية وتعاون فرق لما يصل إلى 500 مورد.
* [scalr.com](https://scalr.com/) - Scalr هو منتج أتمتة وتعاون لـ Terraform (TACO) يُستخدم لتحسين التعاون والأتمتة على البنية التحتية والتكوينات المُدارة عبر Terraform. دعم كامل لسطر أوامر Terraform، تكامل OPA، ونموذج تكوين هرمي. لا ضرائب على الدخول الأحادي (SSO). جميع الميزات متضمنة. حتى 50 تنفيذ شهريًا مجانًا.
* [deployment.io](https://deployment.io) - يساعد Deployment.io المطورين على أتمتة النشر على AWS. في الطبقة المجانية، يمكن لمطور (مستخدم واحد) نشر مواقع ثابتة وخدمات ويب وبيئات بعدد غير محدود. نوفر 20 تنفيذ مهمة مجانية شهريًا مع معاينات ونشر تلقائي ضمن الطبقة المجانية.

**[⬆️ العودة إلى الأعلى](#table-of-contents)**

## مستودعات الشيفرة المصدرية

* [Bitbucket](https://bitbucket.org/) — مستودعات Git عامة وخاصة غير محدودة لما يصل إلى 5 مستخدمين مع Pipelines لـ CI/CD
* [chiselapp.com](https://chiselapp.com/) — مستودعات Fossil عامة وخاصة غير محدودة
* [codebasehq.com](https://www.codebasehq.com/) — مشروع مجاني واحد بمساحة 100 ميجابايت ومستخدمين اثنين
* [Codeberg](https://codeberg.org/) — مستودعات Git عامة وخاصة غير محدودة للمشاريع المجانية والمفتوحة المصدر (مع عدد متعاونين غير محدود). مدعوم بواسطة [Forgejo](https://forgejo.org/). استضافة مواقع ثابتة مع [Codeberg Pages](https://codeberg.page/). استضافة CI/CD مع [Codeberg's CI](https://docs.codeberg.org/ci/). استضافة ترجمة مع [Codeberg Translate](https://translate.codeberg.org/). يشمل استضافة الحزم والحاويات، إدارة المشاريع، وتتبع المشاكل
* [GitGud](https://gitgud.io) — مستودعات عامة وخاصة غير محدودة. مجاني للأبد. مدعوم بواسطة GitLab & Sapphire. لا يوجد CI/CD.
* [GitHub](https://github.com/) — مستودعات عامة وخاصة غير محدودة (مع عدد متعاونين غير محدود). يشمل CI/CD، بيئة تطوير، استضافة ثابتة، استضافة الحزم والحاويات، إدارة المشاريع وCopilot الذكي
* [gitlab.com](https://about.gitlab.com/) — مستودعات Git عامة وخاصة غير محدودة مع حتى 5 متعاونين. يشمل CI/CD، استضافة ثابتة، سجل حاويات، إدارة مشاريع وتتبع مشاكل
* [framagit.org](https://framagit.org/) — فراماجيت هو منصة برمجية من Framasoft مبنية على Gitlab تشمل CI، صفحات ثابتة، صفحات مشاريع وتتبع مشاكل.
* [heptapod.net](https://foss.heptapod.net/) — Heptapod هو تفرع ودي من GitLab Community Edition يدعم Mercurial
* [ionicframework.com](https://ionicframework.com/appflow) - مستودع وأدوات لتطوير التطبيقات باستخدام Ionic؛ يوجد لديك أيضًا مستودع Ionic
* [NotABug](https://notabug.org) — NotABug.org منصة تعاونية برمجية مجانية للمشاريع المرخصة بحرية، مبنية على Git
* [OSDN](https://osdn.net/) - OSDN.net خدمة مجانية لمطوري البرمجيات مفتوحة المصدر، تقدم مستودعات SVN/Git/Mercurial/Bazaar/CVS.
* [Pagure.io](https://pagure.io) — Pagure.io هو منصة مجانية ومفتوحة المصدر للتعاون على مشاريع البرمجيات الحرة المرخصة بترخيص FOSS، ويعتمد على Git.
* [perforce.com](https://www.perforce.com/products/helix-teamhub) — مساحة 1 جيجابايت مجانية على السحابة ومستودعات Git أو Mercurial أو SVN.
* [pijul.com](https://pijul.com/) - نظام تحكم موزع في الإصدارات، مفتوح المصدر ومجاني بالكامل وغير محدود. يتميز بنظرية تصحيح متقدمة تجعله سهل التعلم والاستخدام والتوزيع. يحل العديد من مشاكل git/hg/svn/darcs.
* [plasticscm.com](https://plasticscm.com/) — مجاني للأفراد، البرمجيات مفتوحة المصدر، والمنظمات غير الربحية.
* [projectlocker.com](https://projectlocker.com) — مشروع خاص مجاني واحد (Git و Subversion) مع مساحة 50 ميجابايت.
* [RocketGit](https://rocketgit.com) — استضافة مستودعات معتمدة على Git. مستودعات عامة وخاصة غير محدودة.
* [savannah.gnu.org](https://savannah.gnu.org/) - يعمل كنظام إدارة تطوير برمجيات تعاوني لمشاريع البرمجيات الحرة (لمشاريع GNU).
* [savannah.nongnu.org](https://savannah.nongnu.org/) - يعمل كنظام إدارة تطوير برمجيات تعاوني لمشاريع البرمجيات الحرة (للمشاريع غير الخاصة بـ GNU).

**[⬆️ العودة للأعلى](#table-of-contents)**

## واجهات برمجة التطبيقات، البيانات، والتعلم الآلي

* [JSONGrid](https://jsongrid.com) - أداة مجانية لعرض وتحرير وتصفية بيانات JSON المعقدة في شبكة جدولة جميلة. احفظ وشارك بيانات JSON عبر رابط.
* [Zerosheets](https://zerosheets.com) - حوّل جداول بيانات Google Sheets الخاصة بك إلى واجهات برمجة تطبيقات قوية لتطوير النماذج الأولية والمواقع والتطبيقات والمزيد بسرعة. 500 طلب شهرياً مجاناً.
* [IP.City](https://ip.city) — 100 طلب مجاني يومياً لتحديد الموقع الجغرافي لعناوين IP.
* [Abstract API](https://www.abstractapi.com) — مجموعة من واجهات برمجة التطبيقات لحالات استخدام متنوعة، بما في ذلك تحديد الموقع الجغرافي IP، تحديد النوع الاجتماعي، أو التحقق من البريد الإلكتروني.
* [Apify](https://www.apify.com/) — منصة استخراج بيانات وأتمتة الويب لإنشاء API لأي موقع واستخراج البيانات. أدوات جاهزة، بروكسيات مدمجة، وحلول مخصصة. خطة مجانية مع رصيد منصة شهري بقيمة 5 دولار.
* [APITemplate.io](https://apitemplate.io) - توليد تلقائي للصور ومستندات PDF عبر API بسيطة أو أدوات أتمتة مثل Zapier وAirtable. لا حاجة لـ CSS/HTML. الخطة المجانية تتضمن 50 صورة/شهر وثلاث قوالب.
* [APIToolkit.io](https://apitoolkit.io) - جميع الأدوات التي تحتاجها لفهم ما يحدث في واجهات البرمجة والخوادم الخلفية لديك، مع التحقق والمراقبة التلقائية لعقود API. الخطة المجانية تغطي الخوادم حتى 10,000 طلب يومياً.
* [APIVerve](https://apiverve.com) - وصول فوري إلى أكثر من 120+ API مجاناً، مع التركيز على الجودة والموثوقية. الخطة المجانية تغطي حتى 50 رمز API شهرياً. (ربما أُزيلت، 2025-06-25)
* [Arize AI](https://arize.com/) - قابلية مراقبة تعلم الآلة لمراقبة النماذج وتتبع جذور المشاكل مثل جودة البيانات وانحراف الأداء. مجاني حتى نموذجين.
* [Maxim AI](https://getmaxim.ai/) - محاكاة وتقييم ومراقبة وكلاء الذكاء الاصطناعي. منصة تقييم ومراقبة شاملة تساعد الفرق على إطلاق وكلاء الذكاء الاصطناعي بسرعة أكبر (>5 مرات). مجاني دائماً للمطورين المستقلين والفرق الصغيرة (3 مقاعد).
* [Beeceptor](https://beeceptor.com) - محاكاة REST API في ثوانٍ، تزييف استجابة API والمزيد. 50 طلب يومياً مجاناً، لوحة تحكم عامة، نقاط نهاية مفتوحة (يمكن لأي شخص لديه رابط اللوحة رؤية الطلبات والإجابات).
* [BigDataCloud](https://www.bigdatacloud.com/) - تقدم واجهات برمجة تطبيقات سريعة ودقيقة ومجانية (غير محدودة أو حتى 10K-50K/شهرياً) لتطبيقات الويب الحديثة مثل تحديد الموقع الجغرافي IP، الترميز الجغرافي العكسي، رؤى الشبكات، التحقق من البريد الإلكتروني والهاتف، معلومات العميل والمزيد.
* [Browse AI](https://www.browse.ai) — استخراج ومراقبة البيانات على الويب. 1,000 نقطة شهرياً مجاناً، أي ما يعادل 1,000 طلب متزامن.
* [BrowserCat](https://www.browsercat.com) - API متصفح بدون رأس للأتمتة والاستخلاص ووصول وكلاء الذكاء الاصطناعي للويب وتوليد الصور/ PDF والمزيد. خطة مجانية مع 1,000 طلب شهرياً.
* [Calendarific](https://calendarific.com) - API للعطلات الرسمية على مستوى المؤسسات لأكثر من 200 دولة. الخطة المجانية تتضمن 500 استدعاء شهرياً.
* [Canopy](https://www.canopyapi.co/) - API GraphQL لبيانات منتجات وبحث وأقسام Amazon.com. الخطة المجانية تتضمن 100 استدعاء شهرياً.
* [Clarifai](https://www.clarifai.com) — API للصور للتعرف والكشف عن الوجوه المخصص. يمكن تدريب نماذج الذكاء الاصطناعي. الخطة المجانية بها 1,000 استدعاء شهرياً.
* [Cloudmersive](https://cloudmersive.com/) — منصة API خدمية مع وصول كامل لمكتبة API واسعة تشمل تحويل الوثائق، فحص الفيروسات، والمزيد مع 600 استدعاء/شهر، أمريكا الشمالية فقط، حجم ملف أقصى 2.5 ميجابايت.
* [Colaboratory](https://colab.research.google.com) — بيئة دفاتر Python على الويب مجانية مع وحدة معالجة رسومات Nvidia Tesla K80.
* [CometML](https://www.comet.com/site/) - منصة MLOps لتتبع التجارب وإدارة إنتاج النماذج وتسجيل النماذج وتوثيق البيانات بالكامل، من التدريب حتى الإنتاج. مجانية للأفراد والأكاديميين.
* [Commerce Layer](https://commercelayer.io) - واجهة برمجة تطبيقات تجارة مركبة لبناء وإدارة الطلبات من أي واجهة أمامية. خطة المطورين تسمح بـ 100 طلب شهرياً و حتى 1,000 SKU مجاناً.
* [Composio](https://composio.dev/) - منصة تكامل لوكلاء الذكاء الاصطناعي ونماذج اللغة الكبيرة. دمج أكثر من 200 أداة عبر الإنترنت.
* [Conversion Tools](https://conversiontools.io/) - محول ملفات عبر الإنترنت للوثائق والصور والفيديو والصوت والكتب الإلكترونية. REST API متوفر. مكتبات لـ Node.js وPHP وPython. دعم حتى 50 جيجابايت للملفات (لخطط مدفوعة). الشريحة المجانية محدودة بحجم الملف (20 ميجابايت) وعدد التحويلات (30/يوم، 300/شهر).
* [Country-State-City Microservice API](https://country-state-city.rebuscando.info/) - API وخدمة مصغرة توفر معلومات عن الدول والمناطق والمحافظات والمدن والرموز البريدية والمزيد. الشريحة المجانية حتى 100 طلب يومياً.
* [Coupler](https://www.coupler.io/) - أداة تكامل بيانات تزامن بين التطبيقات. يمكنها إنشاء لوحات تقارير حية، تحويل القيم، وجمع ونسخ الرؤى الاحتياطية. الخطة المجانية محدودة لمستخدم واحد، اتصال بيانات واحد، مصدر بيانات واحد، ووجهة بيانات واحدة. تتطلب تحديث بيانات يدوي.
* [CraftMyPDF](https://craftmypdf.com) - توليد مستندات PDF تلقائياً من قوالب قابلة لإعادة الاستخدام عبر محرر سحب وإفلات وAPI بسيطة. الخطة المجانية بها 100 PDF/شهر وثلاث قوالب.
* [Crawlbase](https://crawlbase.com/) — تصفح واستخلاص بيانات المواقع دون بروكسيات أو بنية تحتية أو متصفحات. نحن نحل اختبارات الكابتشا ونمنع حظرك. أول 1000 استدعاء مجاناً.
* [CurlHub](https://curlhub.io) — خدمة بروكسي لفحص وتصحيح مكالمات API. الخطة المجانية تتضمن 10,000 طلب شهرياً.
* [CurrencyScoop](https://currencyscoop.com) - API بيانات العملات الحية للتطبيقات المالية. الخطة المجانية تتضمن 5,000 استدعاء شهرياً.
* [Cube](https://cube.dev/) - Cube يساعد مهندسي البيانات ومطوري التطبيقات في الوصول إلى البيانات من مخازن البيانات الحديثة، وتنظيمها، وتوفيرها لكل تطبيق. أسرع طريقة للاستخدام عبر Cube Cloud، والشريحة المجانية محدودة حتى 1,000 استعلام يومياً.
* [Data Dead Drop](https://datadeaddrop.com) - مشاركة ملفات بسيطة ومجانية. يتم تدمير البيانات ذاتياً بعد الوصول إليها. رفع وتحميل البيانات عبر المتصفح أو سطر الأوامر المفضل لديك.
* [Data Fetcher](https://datafetcher.com) - وصل Airtable بأي تطبيق أو API بدون كود. واجهة شبيهة بـ Postman لتنفيذ طلبات API في Airtable. تكاملات جاهزة مع عشرات التطبيقات. الخطة المجانية تشمل 100 تنفيذ شهرياً.
* [Dataimporter.io](https://www.dataimporter.io) - أداة ربط وتنظيف واستيراد البيانات إلى Salesforce. الخطة المجانية تشمل حتى 20,000 سجل شهرياً.
* [Datalore](https://datalore.jetbrains.com) - دفاتر Python من Jetbrains. تشمل 10 جيجابايت تخزين و120 ساعة تشغيل شهرياً.
* [Data Miner](https://dataminer.io/) - إضافة للمتصفح (Google Chrome, MS Edge) لاستخلاص البيانات من صفحات الويب إلى CSV أو Excel. الخطة المجانية تمنحك 500 صفحة/شهر.
* [Datapane](https://datapane.com) - API لبناء تقارير تفاعلية في Python ونشر سكريبتات Python ودفاتر Jupyter كأدوات خدمة ذاتية.
* [DB-IP](https://db-ip.com/api/free) - API مجاني لتحديد الموقع الجغرافي IP مع 1,000 طلب لكل IP يومياً. قاعدة بيانات lite بموجب رخصة CC-BY 4.0 متاحة مجاناً.
* [DB Designer](https://www.dbdesigner.net/) — أداة تصميم ونمذجة مخططات قواعد البيانات قائمة على السحابة مع خطة بداية مجانية لموديلين و10 جداول لكل موديل.
* [DeepAR](https://developer.deepar.ai) — فلاتر واقع معزز للوجوه لأي منصة عبر SDK واحد. الخطة المجانية توفر حتى 10 مستخدمين نشطين شهرياً وتتبع حتى 4 وجوه.
* [Deepnote](https://deepnote.com) - دفتر علم بيانات حديث. متوافق مع Jupyter مع تعاون في الوقت الفعلي وتشغيل على السحابة. الشريحة المجانية تشمل مشاريع شخصية غير محدودة، آلات أساسية غير محدودة (5GB RAM و2vCPU)، وفرق حتى 3 محررين.
* [Disease.sh](https://disease.sh/) — API مجاني يوفر بيانات دقيقة لبناء تطبيقات مفيدة متعلقة بكوفيد-19.
* [Doczilla](https://www.doczilla.app/) — API SaaS يتيح توليد لقطات شاشة أو PDF مباشرة من كود HTML/CSS/JS. الخطة المجانية تتيح 250 وثيقة شهرياً.
* [Doppio](https://doppio.sh/) — API مُدار لتوليد وتخزين ملفات PDF ولقطات شاشة باستخدام أحدث تقنيات العرض. الخطة المجانية تتيح 400 PDF ولقطة شاشة شهرياً.
* [drawDB](https://drawdb.app/) — محرر مخططات قواعد بيانات مجاني ومفتوح المصدر على الإنترنت دون الحاجة إلى تسجيل.
* [dreamfactory.com](https://dreamfactory.com/) — منصة REST API مفتوحة المصدر للتطبيقات المحمولة والويب وإنترنت الأشياء. اربط أي قاعدة بيانات SQL/NoSQL أو نظام تخزين ملفات أو خدمة خارجية، وستنشئ منصة REST API شاملة مع توثيق مباشر وإدارة مستخدمين.
* [Duply.co](https://duply.co) — أنشئ صورًا ديناميكية من API & URL، صمم القالب مرة وأعد استخدامه. الشريحة المجانية تمنحك 20 رصيد مجاني.
* [DynamicDocs](https://advicement.io) - توليد مستندات PDF عبر API JSON إلى PDF استنادًا إلى قوالب LaTeX. الخطة المجانية تتيح 50 استدعاء شهرياً والوصول إلى مكتبة القوالب.
* [Efemarai](https://efemarai.com) - منصة اختبار وتصحيح نماذج وبيانات تعلم الآلة. تصور أي رسم بياني حسابي. الاستخدام المحلي مجاني.
* [ERD Lab](https://www.erdlab.io) — أداة ERD سحابية مجانية للمطورين. التجربة المجانية تشمل مشروعين مع 10 جداول لكل مشروع.
* [ExtendsClass](https://extendsclass.com/rest-client-online.html) - عميل HTTP مجاني على الويب لإرسال طلبات HTTP.
* [Export SDK](https://exportsdk.com) - API لتوليد PDF مع محرر قوالب بالسحب والإفلات، يوفر SDK وتكامل بدون كود. الخطة المجانية بها 250 صفحة شهرياً، مستخدمون غير محدودين، وثلاث قوالب.
* [file.coffee](https://file.coffee/) - منصة يمكنك فيها تخزين حتى 15 ميجابايت/ملف (30 ميجابايت مع حساب).
* [Financial Data](https://financialdata.net/) - API بيانات أسواق الأسهم والمالية. الخطة المجانية تتيح 300 طلب يومياً.
* [FormatJSONOnline.com](https://formatjsononline.com) - أداة مجانية على المتصفح لتنسيق، وتحقق، ومقارنة، وتصغير بيانات JSON فوراً.
* [FraudLabs Pro](https://www.fraudlabspro.com) — فحص معاملات الطلبات للاحتيال في دفع بطاقات الائتمان. هذه REST API تكتشف جميع خصائص الاحتيال الممكنة بناءً على معلمات الطلب. خطة Micro المجانية بها 500 معاملة شهرياً.
* [GeoDataSource](https://www.geodatasource.com) — خدمة بحث الموقع للبحث عن أسماء المدن باستخدام الإحداثيات. حتى 500 طلب شهرياً عبر API مجاناً.
* [Geolocated.io](https://geolocated.io) — API لتحديد الموقع الجغرافي IP بخوادم متعددة القارات، مع خطة مجانية تتضمن 2,000 طلب يومياً.
* [Glitterly](https://glitterly.app/) - توليد صور ديناميكية برمجياً من قوالب أساسية. API Rest وتكامل بدون كود. الشريحة المجانية تشمل 50 صورة/شهر وخمس قوالب.
* [Hex](https://hex.tech/) - منصة بيانات تعاونية للدفاتر، وتطبيقات البيانات، ومكتبات المعرفة. شريحة مجتمع مجانية مع حتى خمسة مشاريع.
* [Hook0](https://www.hook0.com/) - Hook0 خدمة Webhooks مفتوحة المصدر كخدمة (WaaS) لتسهيل توفير Webhooks للمنتجات عبر الإنترنت. إرسال حتى 100 حدث/يوم مع الاحتفاظ بالتاريخ 7 أيام مجاناً.
* [Hoppscotch](https://hoppscotch.io) - منشئ طلبات API مجاني وسريع وجميل.
* [huggingface.co](https://huggingface.co) - بناء وتدريب ونشر نماذج معالجة اللغة الطبيعية لـ Pytorch وTensorFlow وJAX. مجاني حتى 30,000 حرف إدخال/شهر.
* [Hybiscus](https://hybiscus.dev/) - بناء تقارير PDF عبر API بسيطة. الشريحة المجانية لمدة 14 يوماً تتضمن 50 تقرير صفحة واحدة مع القدرة على تخصيص الألوان والخطوط.
* [Invantive Cloud](https://cloud.invantive.com/) — الوصول لأكثر من 70 منصة (سحابية) مثل Exact Online, Twinfield, ActiveCampaign أو Visma باستخدام Invantive SQL أو OData4 (عادة لـ Power BI أو Power Query). يشمل تكرار وتبادل البيانات. خطة مجانية للمطورين ومستشاري التنفيذ. مجاني لمنصات محددة مع قيود على أحجام البيانات.
* [ipaddress.sh](https://ipaddress.sh) — خدمة بسيطة للحصول على عنوان IP العام بعدة [صيَغ](https://about.ipaddress.sh/).
* [ip-api](https://ip-api.com) — API تحديد الموقع الجغرافي IP، مجاني للاستخدام غير التجاري، لا يتطلب مفتاح API، محدود بـ 45 طلب/دقيقة من نفس العنوان IP للخطة المجانية.
* [ipbase.com](https://ipbase.com) - API تحديد الموقع الجغرافي IP - خطة مجانية للأبد تشمل 150 طلب شهرياً.
* [IP Geolocation](https://ipgeolocation.io/) — API تحديد الموقع الجغرافي IP - خطة مجانية للأبد للمطورين بحد 1,000 طلب يومياً.
* [IP Geolocation API](https://www.abstractapi.com/ip-geolocation-api) — API تحديد الموقع الجغرافي IP من Abstract - يسمح بـ 1,000 طلب مجاني.
* [IPLocate](https://www.iplocate.io) — API تحديد الموقع الجغرافي IP، مجاني حتى 1,000 طلب/يوم. يشمل كشف البروكسي/VPN/الاستضافة، بيانات ASN، تحويل IP إلى شركة والمزيد. IPLocate توفر أيضاً قواعد بيانات IP إلى دولة وIP إلى ASN مجانية قابلة للتحميل بتنسيق CSV أو MMDB متوافق مع GeoIP.
* [IP2Location](https://www.ip2location.com) — خدمة تحديد الموقع الجغرافي IP بنظام freemium. قاعدة البيانات LITE متاحة للتحميل المجاني. استورد القاعدة على الخادم ونفذ استعلاماً محلياً لتحديد المدينة والإحداثيات ومعلومات مزود الخدمة.
* [IP2Location.io](https://www.ip2location.io/) — API تحديد الموقع الجغرافي IP بنظام freemium، سريع وموثوق. احصل على بيانات مثل المدينة والإحداثيات وISP والمزيد. الخطة المجانية تتضمن 50 ألف نقطة شهرياً. IP2Location.io تقدم أيضاً 500 بحث WHOIS ونطاق مستضاف شهرياً مجاناً. راجع تفاصيل تسجيل النطاقات وابحث عن النطاقات المستضافة على IP معين. الترقية للخطة المدفوعة لمزايا إضافية.
* [ipapi](https://ipapi.co/) - API تحديد موقع عناوين IP بواسطة Kloudend, Inc - API جغرافي موثوق مبني على AWS ومعتمد من شركات Fortune 500. الشريحة المجانية توفر 30,000 بحث/شهر (1,000/يوم) بدون تسجيل.
* [ipapi.is](https://ipapi.is/) - API موثوق لعناوين IP للمطورين مع أفضل قدرات كشف الاستضافة المتوفرة. الخطة المجانية توفر 1,000 بحث بدون تسجيل.
* [IPinfo](https://ipinfo.io/) — بيانات سريعة ودقيقة ومجانية (حتى 50 ألف/شهر) لعناوين IP. يقدم API مع تفاصيل الموقع الجغرافي، الشركات، شركات النقل، نطاقات IP، النطاقات، جهات اتصال الإبلاغ عن إساءة الاستخدام والمزيد. يمكن تجربة جميع واجهات API المدفوعة مجاناً.
* [IPQuery](https://ipquery.io) — API غير محدود لعناوين IP للمطورين، بدون حدود للطلبات أو التسعير.
* [IPTrace](https://iptrace.io) — API بسيط للغاية يوفر بيانات تحديد الموقع الجغرافي IP موثوقة ومفيدة مع 50,000 استعلام مجاني شهرياً.
* [JSON2Video](https://json2video.com) - API تحرير فيديو لأتمتة التسويق بالفيديو ومقاطع التواصل الاجتماعي برمجياً أو بدون كود.
* [JSON IP](https://getjsonip.com) — يعيد عنوان IP العام للعميل الذي يُطلب منه. لا حاجة للتسجيل للخطة المجانية. باستخدام CORS، يمكن طلب البيانات عبر JS من جانب العميل مباشرة من المتصفح. مفيد لمراقبة تغيّر عناوين IP للعميل والخادم. عدد غير محدود من الطلبات.
* [JSON Serve](https://jsonserve.com/) — خدمة مجانية تساعد المطورين على تخزين كائنات JSON واستخدامها كـ REST API في تطبيقاتهم.
* [JSONing](https://jsoning.com/api/) — أنشئ REST API وهمي من كائن JSON، وقم بتخصيص رموز حالة HTTP والرؤوس ونصوص الاستجابة.
* [konghq.com](https://konghq.com/) — سوق API وأدوات قوية خاصة وعامة لـ API. في الشريحة المجانية بعض الميزات مثل المراقبة والتنبيهات والدعم محدودة.
* [Kreya](https://kreya.app) — عميل GUI مجاني لـ gRPC لاستدعاء واختبار gRPC APIs. يمكن استيراد gRPC APIs عبر انعكاس الخادم.
* [Lightly](https://www.lightly.ai/) — حسّن نماذج تعلم الآلة لديك باستخدام البيانات الصحيحة. استخدم مجموعات بيانات حتى 1,000 عينة مجاناً.
* [LoginLlama](https://loginllama.app) - API أمان تسجيل الدخول لاكتشاف عمليات الدخول الاحتيالية والمشبوهة وتنبيه عملائك. مجاني حتى 1,000 تسجيل دخول شهرياً.
* [MailboxValidator](https://www.mailboxvalidator.com) — خدمة تحقق من البريد الإلكتروني عبر الاتصال الفعلي بخادم البريد لتأكيد صلاحية البريد. خطة API المجانية تشمل 100 تحقق شهرياً.
* [Market Data API](https://www.marketdata.app) - توفر بيانات مالية حية وتاريخية للأسهم، الخيارات، الصناديق المشتركة والمزيد. شريحة API مجانية للأبد تسمح بـ 100 طلب API يومياً بدون مقابل.
  * [Meteosource Weather API](https://www.meteosource.com/) — واجهة برمجة تطبيقات الطقس العالمية للبيانات الحالية والمتوقعة للطقس. التوقعات مبنية على مزيج من نماذج الطقس باستخدام التعلم الآلي لتحقيق دقة أفضل. الخطة المجانية توفر 400 طلب يوميًا.
  * [microlink.io](https://microlink.io/) – يحول أي موقع ويب إلى بيانات مثل توحيد بيانات الميتا تاغ، معاينة الروابط بشكل جميل، إمكانيات السحب، أو لقطات الشاشة كخدمة. 50 طلبًا يوميًا، مجاني دائمًا.
  * [Mindee](https://developers.mindee.com) – مايندي هو برنامج OCR قوي ومنصة API أولاً تساعد المطورين على أتمتة سير عمل التطبيقات من خلال توحيد طبقة معالجة المستندات عبر التعرف على البيانات للمعلومات الأساسية باستخدام رؤية الحاسوب والتعلم الآلي. المستوى المجاني يوفر 500 صفحة شهريًا.
  * [Mintlify](https://mintlify.com) — المعيار الحديث لتوثيق واجهات برمجة التطبيقات. مكونات واجهة مستخدم جميلة وسهلة الصيانة، بحث داخل التطبيق وملعب تفاعلي. مجاني لمحرر واحد.
  * [MockAPI](https://www.mockapi.io/) — موك API أداة بسيطة تتيح لك إنشاء واجهات برمجة تطبيقات وهمية بسرعة، وتوليد بيانات مخصصة، وإجراء العمليات باستخدام واجهة RESTful. MockAPI مخصص للنمذجة/الاختبار/التعلم. مشروع واحد/موردين لكل مشروع مجانًا.
  * [Mockfly](https://www.mockfly.dev/) — Mockfly أداة تطوير موثوقة لمحاكاة واجهات برمجة التطبيقات وإدارة أعلام الميزات. أنشئ وتحكم في واجهات API وهمية بسرعة من خلال واجهة سهلة الاستخدام. المستوى المجاني يوفر 500 طلب يوميًا.
  * [Mocki](https://mocki.io) - أداة تتيح لك إنشاء واجهات API وهمية لـ GraphQL وREST متزامنة مع مستودع GitHub. واجهات REST البسيطة مجانية للتطوير والاستخدام بدون تسجيل.
  * [Mocko.dev](https://mocko.dev/) — قم بتوجيه واجهة API الخاصة بك، اختر النقاط النهائية التي تريد محاكاتها في السحابة وراقب حركة المرور، مجانًا. سرع تطويرك واختبارات التكامل.
  * [Mocky](https://designer.mocky.io/) - تطبيق ويب بسيط لإنشاء استجابات HTTP مخصصة لمحاكاة طلبات HTTP. متوفر أيضًا كـ [مفتوح المصدر](https://github.com/julien-lafont/Mocky).
  * [Mock N Roll](https://mpcknroll.me/) - خدمة Mock API مجانية—أداة قوية لمحاكاة استجابات API الحقيقية دون تأخير من الخلفية. مثالية لمطوري الواجهة الأمامية، مختبري ضمان الجودة وفرق DevOps. [repo](https://github.com/haerulmuttaqin/mocknroll-web).
  * [microenv.com](https://microenv.com) —  إنشاء REST API وهمية للمطورين مع إمكانية توليد الكود والتطبيق في حاوية Docker.
  * [Multi-Exit IP Address Checker](https://ip.alstra.ca/) —  أداة مجانية وبسيطة لفحص عنوان IP الخاص بك عبر عدة عقد وفهم كيف يظهر عنوان IP الخاص بك في مناطق وخدمات عالمية مختلفة. مفيد لاختبار أدوات تقسيم DNS المبنية على القواعد مثل Control D.
  * [Namekit](https://namekit.app/) - اكتشاف النطاقات المدعومة بالذكاء الاصطناعي – اعثر على أسماء متاحة وبسعر قياسي فورًا. استفسارات يومية مجانية.
  * [News API](https://newsapi.org) — ابحث عن الأخبار على الويب باستخدام الكود، واحصل على النتائج بصيغة JSON. يحصل المطورون على 100 استعلام مجاني يوميًا. المقالات بها تأخير 24 ساعة.
  * [numlookupapi.com](https://numlookupapi.com) - واجهة تحقق من أرقام الهاتف مجانية - 100 طلب مجاني/شهر.
  * [OCR.Space](https://ocr.space/) — API OCR تقوم بتحليل ملفات الصور وPDF وتعيد النتائج النصية بصيغة JSON. 25,000 طلب شهريًا مجانًا وحد أقصى لحجم الملف 1MB.
  * [OpenAPI3 Designer](https://openapidesigner.com/) — أنشئ تعريفات Open API 3 بصريًا مجانًا.
  * [parsehub.com](https://parsehub.com/) — استخراج البيانات من المواقع الديناميكية، تحويل المواقع الديناميكية إلى واجهات API، خمسة مشاريع مجانًا.
  * [Parseur](https://parseur.com) — 20 صفحة مجانية/شهر: استخراج البيانات من ملفات PDF والبريد الإلكتروني. مدعوم بالذكاء الاصطناعي. وصول كامل للـ API.
  * [PDFBolt](https://pdfbolt.com) - واجهة برمجة تطبيقات لإنشاء ملفات PDF تركز على الخصوصية ومصممة للمطورين. توفر توثيق شبيه بـ Stripe وتتضمن 500 تحويل PDF مجاني شهريًا.
  * [pdfEndpoint.com](https://pdfendpoint.com) - تحويل HTML أو الروابط إلى PDF بسهولة عبر API بسيطة. 100 تحويل مجاني شهريًا.
  * [PDF-API.io](https://pdf-api.io) - واجهة أتمتة PDF، محرر قوالب بصري أو تحويل HTML إلى PDF، دمج بيانات ديناميكية وعرض PDF عبر API. الخطة المجانية تتضمن قالب واحد و100 PDF شهريًا.
  * [Pixela](https://pixe.la/) - خدمة قاعدة بيانات يومية مجانية. جميع العمليات تتم عبر API. يمكن أيضًا التصور باستخدام خرائط الحرارة والرسوم البيانية الخطية.
  * [Postman](https://postman.com) — بسّط سير العمل وأنشئ واجهات API أفضل – بسرعة – مع Postman، منصة تعاونية لتطوير واجهات API. استخدم تطبيق Postman مجانًا للأبد. ميزات السحابة في Postman أيضًا مجانية للأبد مع حدود معينة.
  * [Insomnia](https://insomnia.rest) - عميل API مفتوح المصدر لتصميم واختبار واجهات API، يدعم REST وGraphQL
  * [PrefectCloud](https://www.prefect.io/cloud/) — منصة كاملة لأتمتة تدفق البيانات. الخطة المجانية تتضمن 5 سير عمل منشورة و500 دقيقة من اعتمادات الحوسبة بدون خادم شهريًا.
  * [Preset Cloud](https://preset.io/) - خدمة استضافة Apache Superset. مجانية للأبد للفرق حتى 5 مستخدمين، وتتميز بلوحات ورسوم غير محدودة، منشئ رسوم بيانية بدون كود، ومحرر SQL تعاوني.
  * [PromptLoop](https://www.promptloop.com/) - تقدم PromptLoop سحب ويب بالذكاء الاصطناعي أسهل بعشر مرات مع وقت تبني شبه معدوم، وتوفير أكثر من 85% من الوقت على سير العمل الحالي، وتعمل أسرع بأربع مرات من البحث اليدوي دون تنازلات وتتضمن نقطة نهاية REST API لكل مهام البحث. أول 1,000 رصيد مجاني شهريًا.
  * [Public-Apis Github Repo](https://github.com/public-apis/public-apis) — قائمة بواجهات API العامة المجانية.
  * [Rapidapi](https://rapidapi.com/) - أكبر مركز API في العالم ملايين المطورين يعثرون ويتصلون بآلاف الواجهات البرمجية، تطوير واجهات API عبر تحديات ممتعة (مع حلول!) وأمثلة تفاعلية.
  * [RequestBin.com](https://requestbin.com) — أنشئ نقطة نهاية مجانية يمكنك إرسال طلبات HTTP إليها. أي طلبات HTTP ترسل لتلك النقطة ستُسجل مع الحمولة والرؤوس المصاحبة لتتمكن من مراقبة توصيات webhooks والخدمات الأخرى.
  * [reqres.in](https://reqres.in) - REST-API مستضافة مجانية جاهزة للرد على طلبات AJAX الخاصة بك.
  * [Roboflow](https://roboflow.com) - أنشئ وانشر نموذج رؤية حاسوبية مخصص دون الحاجة لخبرة سابقة في تعلم الآلة. المستوى المجاني يشمل 30 رصيد شهريًا.
  * [ROBOHASH](https://robohash.org/) - خدمة ويب لإنشاء صور فريدة ورائعة من أي نص.
  * [Scraper's Proxy](https://scrapersproxy.com) — واجهة API لبروكسي HTTP بسيطة للسحب. اسحب بشكل مجهول دون القلق من القيود أو الحظر أو اختبارات captcha. أول 100 عملية سحب ناجحة شهريًا مجانًا تشمل عرض جافاسكريبت (يمكنك الحصول على المزيد عند التواصل مع الدعم).
  * [ScrapingAnt](https://scrapingant.com/) — واجهة API لسحب جوجل كروم بدون واجهة مع بروكسيات مجانية مفحوصة. عرض جافاسكريبت، بروكسيات متغيرة متميزة، وتجنب اختبارات CAPTCHA. 10,000 رصيد API مجاني.
  * [Simplescraper](https://simplescraper.io) — فعّل webhook الخاص بك بعد كل عملية. الخطة المجانية تشمل 100 رصيد سحب سحابي.
  * [Select Star](https://www.selectstar.com/) - منصة ذكية لاكتشاف البيانات تقوم بتحليل وتوثيق البيانات تلقائيًا. المستوى المجاني يشمل مصدرين للبيانات، حتى 1,000 جدول و25 مستخدمًا.
  * [Sheetson](https://sheetson.com) - حوّل أي Google Sheets إلى RESTful API فورًا. خطة مجانية متوفرة، تشمل 1,000 صف مجاني لكل ورقة.
  * [Shipyard](https://www.shipyardapp.com) — منصة تنسيق بيانات منخفضة الكود للسحابة. أنشئ مزيجًا من القوالب منخفضة الكود وكودك الخاص (Python, Node.js, Bash, SQL). خطتنا المجانية للمطورين توفر 10 ساعات تشغيل شهريًا لمستخدم واحد - أكثر من كافية لأتمتة عدة سير عمل.
  * [Siterelic](https://siterelic.com/) - واجهة Siterelic تتيح لك التقاط لقطات شاشة، تدقيق المواقع، فحص TLS، بحث DNS، اختبار TTFB والمزيد. الخطة المجانية توفر 100 طلب API شهريًا.
  * [SerpApi](https://serpapi.com/) - API سحب نتائج محركات البحث في الوقت الحقيقي. تعيد نتائج JSON مهيكلة لجوجل، يوتيوب، بينج، بايدو، وولمارت والعديد من الآلات الأخرى. الخطة المجانية تتضمن 100 طلب API ناجح شهريًا.
  * [SmartParse](https://smartparse.io) - منصة هجرة بيانات وتحويل CSV إلى API توفر أدوات مطورين موفرة للوقت والتكلفة. المستوى المجاني يشمل 300 وحدة معالجة شهريًا، تحميل عبر المتصفح، حجر بيانات، قواطع دوائر، وتنبيهات وظائف.
  * [Sofodata](https://www.sofodata.com/) - أنشئ واجهات RESTful API آمنة من ملفات CSV. قم بتحميل ملف CSV وادخل إلى البيانات عبر API مما يتيح تطوير تطبيقات أسرع. الخطة المجانية تشمل 2 API و2,500 طلب API شهريًا. لا تحتاج بطاقة ائتمان.
  * [Sqlable](https://sqlable.com/) - مجموعة من أدوات SQL المجانية على الإنترنت، بما في ذلك منسق SQL ومدقق، مختبر تعبيرات SQL regex، منشئ بيانات وهمية، وبيئات قواعد بيانات تفاعلية.
  * [Stoplight](https://stoplight.io/) - SaaS لتصميم وتوثيق واجهات API بشكل تعاوني. الخطة المجانية توفر أدوات التصميم والمحاكاة والتوثيق مجانًا.
  * [Supportivekoala](https://supportivekoala.com/) — يسمح لك بتوليد الصور تلقائيًا بناءً على مدخلاتك عبر القوالب. الخطة المجانية تتيح لك إنشاء حتى 50 صورة شهريًا.
  * [Svix](https://www.svix.com/) - Webhooks كخدمة. أرسل حتى 50,000 رسالة/شهر مجانًا.
  * [Tavily AI](https://tavily.com/) - API للبحث عبر الإنترنت والحصول على رؤى سريعة وأبحاث شاملة، مع القدرة على تنظيم نتائج البحث. 1000 طلب/شهر للمستوى المجاني بدون الحاجة لبطاقة ائتمان.
  * [The IP API](https://theipapi.com/) - واجهة API لتحديد الموقع الجغرافي لعناوين IP مع 1000 طلب مجاني/يوم. تقدم معلومات عن موقع عنوان IP، بما في ذلك الدولة، المدينة، المنطقة والمزيد.
  * [TinyMCE](https://www.tiny.cloud) - API لتحرير النصوص الغنية. الميزات الأساسية مجانية للاستخدام غير المحدود.
  * [Tomorrow.io Weather API](https://www.tomorrow.io/weather-api/) - تقدم خطة مجانية لواجهة API للطقس. توفر توقعات طقس دقيقة ومحدثة مع تغطية عالمية، بيانات تاريخية وحلول مراقبة الطقس.
  * [Treblle](https://www.treblle.com) - Treblle تساعد الفرق على بناء وإطلاق وإدارة واجهات API. مع تجميع متقدم لسجلات API، مراقبة، توثيق وتصحيح الأخطاء. تحصل على جميع الميزات مجانًا لكن يوجد حد يصل إلى 250 ألف طلب شهريًا في المستوى المجاني.
  * [UniRateAPI](https://unirateapi.com) – أسعار صرف في الوقت الحقيقي لأكثر من 590 عملة وعملة رقمية. مكالمات API غير محدودة في الخطة المجانية، مثالية للمطورين وتطبيقات التمويل.
  * [vatcheckapi.com](https://vatcheckapi.com) - واجهة API بسيطة ومجانية للتحقق من أرقام ضريبة القيمة المضافة. 150 تحقق مجاني شهريًا.
  * [WeatherXu](https://weatherxu.com/) — بيانات طقس عالمية تشمل الظروف الحالية، وتوقعات بالساعة واليوم، وتنبيهات الطقس عبر API. دمج نماذج الذكاء الاصطناعي وأنظمة التعلم الآلي لتحليل ودمج نماذج طقس متعددة لتقديم توقعات أدق. المستوى المجاني يشمل 10,000 طلب API شهريًا.
  * [Webhook Store](https://www.openwebhook.io) - أداة لتخزين webhooks الخاصة بأطراف ثالثة وتصحيحها على localhost (مثل ngrok). مفتوحة المصدر وقابلة للاستضافة الذاتية. نطاق شخصي مجاني *username*.github.webhook.store، ونطاقات عامة مجانية *anything*.webhook.store.
  * [WebScraping.AI](https://webscraping.ai) - API لسحب الويب مع تحليل مدمج، عرض كروم، وبروكسيات. ألفا طلب API مجاني شهريًا.
  * [Weights & Biases](https://wandb.ai) — منصة MLOps موجهة للمطورين. أنشئ نماذج أفضل بشكل أسرع مع تتبع التجارب، إصدار مجموعات البيانات، وإدارة النماذج. المستوى المجاني للمشاريع الشخصية فقط، مع 100 جيجابايت تخزين متضمن.
  * [What The Diff](https://whatthediff.ai) - مساعد مراجعة كود مدعوم بالذكاء الاصطناعي. الخطة المجانية محدودة بـ 25,000 رمز شهريًا (~10 PRs).
  * [wolfram.com](https://wolfram.com/language/) — خوارزميات مبنية على المعرفة في السحابة.
  * [wrapapi.com](https://wrapapi.com/) — حوّل أي موقع ويب إلى API بمعلمات. 30,000 مكالمة API شهريًا.
  * [Zenscrape](https://zenscrape.com/web-scraping-api) — API لسحب الويب مع متصفحات بدون واجهة وعناوين IP سكنية وتسعير مباشر. ألف طلب API مجاني شهريًا وائتمانات إضافية للطلاب والمنظمات غير الربحية.
  * [Zipcodebase](https://zipcodebase.com) - واجهة API مجانية للرموز البريدية، مع إمكانية الوصول إلى بيانات الرموز البريدية العالمية. 5,000 طلب مجاني شهريًا.
  * [Zipcodestack](https://zipcodestack.com) - واجهة API مجانية للرموز البريدية والتحقق من الرموز البريدية. عشرة آلاف طلب مجاني شهريًا.
  * [Zuplo](https://zuplo.com/) - منصة مجانية لإدارة واجهات API لتصميم وبناء ونشر واجهات API إلى Edge. أضف مصادقة مفاتيح API، تحديد معدل الاستخدام، توثيق المطورين وتحقيق الدخل لأي API في دقائق. تدعم OpenAPI وقابلة للبرمجة بالكامل بمعايير الويب وTypescript. الخطة المجانية توفر حتى 10 مشاريع، بيئات إنتاجية غير محدودة، مليون طلب شهريًا و10 جيجابايت خروج بيانات.

**[⬆️ العودة إلى الأعلى](#table-of-contents)**

## مستودعات الملفات البرمجية (Artifact Repos)

  * [Artifactory](https://jfrog.com/start-free/) - مستودع ملفات برمجية يدعم العديد من صيغ الحزم مثل Maven، Docker، Cargo، Helm، PyPI، CocoaPods، وGitLFS. يشمل أداة فحص الحزم XRay وأداة CI/CD Pipelines (سابقًا Shippable) مع مستوى مجاني بـ 2000 دقيقة CI/CD شهريًا.
  * [central.sonatype.org](https://central.sonatype.org) — مستودع الملفات الافتراضي لـ Apache Maven، SBT وأنظمة البناء الأخرى.
  * [cloudrepo.io](https://cloudrepo.io) - مستودعات Maven وPyPi خاصة وعامة قائمة على السحابة. مجاني للمشاريع مفتوحة المصدر.
  * [cloudsmith.io](https://cloudsmith.io) — خدمة مستودعات بسيطة وآمنة ومركزية لـ Java/Maven، RedHat، Debian، Python، Ruby، Vagrant والمزيد. مستوى مجاني + مجاني للمصادر المفتوحة.
  * [jitpack.io](https://jitpack.io/) — مستودع Maven لمشاريع JVM وأندرويد على GitHub، مجاني للمشاريع العامة.
  * [packagecloud.io](https://packagecloud.io/users/new?plan=free_usage_plan) — استضافة مستودعات سهلة لحزم Maven، RPM، DEB، PyPi، NPM، وRubyGem (يوجد مستوى مجاني).
  * [repsy.io](https://repsy.io) — 1 جيجابايت مستودع Maven خاص/عام مجاني.
  * [Gemfury](https://gemfury.com) — مستودعات ملفات برمجية خاصة وعامة لـ Maven، PyPi، NPM، Go Module، Nuget، APT، وRPM. مجاني للمشاريع العامة.
  * [paperspace](https://www.paperspace.com/) — أنشئ ووسع نماذج الذكاء الاصطناعي، طور، درّب وانشر تطبيقات الذكاء الاصطناعي، خطة مجانية: مشاريع عامة، 5 جيجابايت تخزين، مثيلات أساسية.
  * [RepoForge](https://repoforge.io) - مستودع خاص مستضاف على السحابة لحزم Python وDebian وNPM وسجلات Docker. خطة مجانية للمشاريع العامة/مفتوحة المصدر.
  * [RepoFlow](https://repoflow.io) - RepoFlow يبسط إدارة الحزم بدعم npm وPyPI وDocker وGo وHelm والمزيد. جربه مجانًا مع 10 جيجابايت تخزين، 10 جيجابايت نقل بيانات، 100 حزمة، ومستخدمين غير محدودين في السحابة أو مستضاف ذاتيًا للاستخدام الشخصي فقط.

**[⬆️ العودة إلى الأعلى](#table-of-contents)**

## أدوات الفرق والتعاون
  * [3Cols](https://3cols.com/) - مدير مقتطفات كود مجاني قائم على السحابة للاستخدام الشخصي والتعاون الجماعي.
  * [Bitwarden](https://bitwarden.com) — أسهل وأكثر طريقة أمانًا للأفراد والفرق والمؤسسات لتخزين ومشاركة ومزامنة البيانات الحساسة.
  * [Braid](https://www.braidchat.com/) — تطبيق دردشة مصمم للفرق. مجاني للمجموعات العامة، مستخدمين غير محدودين، سجل ومتكامل مع خدمات أخرى. كما يوفر نسخة مفتوحة المصدر للاستضافة الذاتية.
  * [cally.com](https://cally.com/) — ابحث عن الوقت والتاريخ المثالي للاجتماع. سهل الاستخدام ويعمل بشكل رائع للمجموعات الصغيرة والكبيرة.
  * [Calendly](https://calendly.com) — Calendly أداة للربط وتحديد مواعيد الاجتماعات. الخطة المجانية توفر اتصال تقويم واحد لكل مستخدم وجلسات غير محدودة. تتوفر تطبيقات سطح المكتب والجوال أيضًا.
  * [Discord](https://discord.com/) — دردشة مع غرف عامة/خاصة. نص ماركداون، صوت، فيديو، ومشاركة شاشة. مجاني لمستخدمين غير محدودين.
  * [Fibo](https://fibo.dev) - أداة تخمين نقاط القصص scrum عبر الإنترنت مجانية وفورية للفرق الرشيقة تسمح بتقدير عدد غير محدود من الأعضاء بشكل أسرع.
  * [Telegram](https://telegram.org/) — تيليجرام للجميع ممن يرغبون في رسائل ومكالمات سريعة وموثوقة. قد يفضل المستخدمون التجاريون والفرق الصغيرة المجموعات الكبيرة وأسماء المستخدمين وتطبيقات سطح المكتب وخيارات مشاركة الملفات القوية.
  * [DevToolLab](https://devtoollab.com) — أدوات مطورين عبر الإنترنت تقدم وصولًا مجانيًا لجميع الأدوات الأساسية، مع إمكانية الحفظ التلقائي لمدخل واحد لكل أداة، سرعة معالجة قياسية، ودعم مجتمعي.
  * [Dubble](https://dubble.so/) — منشئ مجاني لأدلة الخطوة بخطوة. التقط لقطات شاشة، وثق العمليات وتعاون مع فريقك. يدعم أيضًا تسجيل الشاشة غير المتزامن.
  * [Duckly](https://duckly.com/) — تحدث وتعاون في الوقت الحقيقي مع فريقك. برمجة ثنائية مع مشاركة IDE والطرفية، صوت، فيديو ومشاركة شاشة. مجاني للفرق الصغيرة.
  * [Dyte](https://dyte.io) - أكثر SDK فيديو وصوت مباشر صداقة للمطورين، مع إضافات تعاونية لتعزيز الإنتاجية والتفاعل. المستوى المجاني يشمل 10,000 دقيقة شهرية من الفيديو/الصوت المباشر.
  * [evernote.com](https://evernote.com/) — أداة لتنظيم المعلومات. شارك ملاحظاتك واعمل مع الآخرين
  * [Fibery](https://fibery.io/) — منصة مساحة عمل مترابطة. مجانية للمستخدمين الفرديين، حتى 2 جيجابايت مساحة قرص.
  * [flock.com](https://flock.com) — طريقة أسرع لتواصل فريقك. رسائل غير محدودة، قنوات، مستخدمين، تطبيقات وتكاملات مجانية بالكامل.
  * [Gather](https://www.gather.town/) - طريقة أفضل للاجتماعات عبر الإنترنت. تدور حول مساحات قابلة للتخصيص بالكامل، تجعل Gather قضاء الوقت مع مجتمعك سهلاً كما في الواقع. مجاني حتى 10 مستخدمين متزامنين.
  * [gokanban.io](https://gokanban.io) - لوحة كانبان معتمدة على الصيغة، بدون تسجيل للاستخدام السريع. مجانية بدون أي قيود.
  * [flat.social](https://flat.social) - مساحات تفاعلية قابلة للتخصيص لاجتماعات الفريق واللقاءات الاجتماعية. اجتماعات غير محدودة، مجاناً حتى 8 مستخدمين متزامنين.
  * [GitDailies](https://gitdailies.com) - تقارير يومية عن نشاط الـ Commit و Pull Request لفريقك على GitHub. تشمل أداة عرض الدفع (Push visualizer)، ونظام تقدير الأقران، وبناء تنبيهات مخصص. الخطة المجانية تدعم عدد غير محدود من المستخدمين، وثلاثة مستودعات، و3 إعدادات تنبيه.
  * [gitter.im](https://gitter.im/) — دردشة لـ GitHub. غرف عامة وخاصة غير محدودة، مجانية للفرق حتى 25 مستخدمًا.
  * [Hackmd.io](https://hackmd.io/) - أداة تعاونية للكتابة في الوقت الحقيقي لملفات ومستندات Markdown. مثل Google Docs ولكن لملفات Markdown. عدد غير محدود من "الملاحظات" مجاناً، لكن عدد المتعاونين (المدعوين) للملاحظات الخاصة والقوالب [سيكون محدودًا](https://hackmd.io/pricing).
  * [hangouts.google.com](https://hangouts.google.com/) — مكان واحد لكل محادثاتك، مجاناً، يتطلب حساب Google.
  * [HeySpace](https://hey.space) - أداة لإدارة المهام مع دردشة وتقويم وخط زمني ومكالمات فيديو. مجانًا حتى 5 مستخدمين.
  * [helplightning.com](https://www.helplightning.com/) — المساعدة عبر الفيديو مع الواقع المعزز. مجاني بدون تحليلات، أو تشفير، أو دعم.
  * [ideascale.com](https://ideascale.com/) — السماح للعملاء بتقديم الأفكار والتصويت عليها، مجاناً لـ 25 عضوًا في مجتمع واحد.
  * [Igloo](https://www.igloosoftware.com/) — بوابة داخلية لمشاركة المستندات والمدونات والتقويمات وما إلى ذلك. مجاناً حتى 10 مستخدمين.
  * [Keybase](https://keybase.io/) — Keybase هو بديل مفتوح المصدر لـ Slack؛ يحافظ على أمان محادثات وملفات الجميع، من العائلات إلى المجتمعات والشركات.
  * [Google Meet](https://meet.google.com/) — استخدم Google Meet لاحتياجات عملك من اجتماعات الفيديو عبر الإنترنت. يقدم Meet اجتماعات آمنة وسهلة الانضمام عبر الإنترنت.
  * [/meet for Slack](https://meetslack.com) - بدء اجتماعات Google مباشرة من Slack باستخدام /meet في أي قناة أو مجموعة أو رسالة مباشرة. مجاني بدون أي قيود.
  * [Livecycle](https://www.livecycle.io/) — Livecycle منصة تعاونية شاملة تجعل سير العمل سلسًا لفرق المنتجات متعددة التخصصات والمشاريع مفتوحة المصدر.
  * [Lockitbot](https://www.lockitbot.com/) — حجز وقفل الموارد المشتركة داخل Slack مثل الغرف، وبيئات التطوير، والخوادم وما إلى ذلك. مجانًا حتى موردين اثنين.
  * [MarkUp](https://www.markup.io/) — تتيح لك MarkUp جمع التعليقات مباشرة على مواقعك الإلكترونية وملفات PDF والصور.
  * [Proton Pass](https://proton.me/pass) — مدير كلمات مرور مع عناوين بريد إلكتروني وهمية مدمجة، ومصادق ثنائي (2FA)، ومشاركة ومفاتيح مرور. متوفر على الويب، وامتداد المتصفح، وتطبيق الجوال وسطح المكتب.
  * [Visual Debug](https://visualdebug.com) - أداة ردود فعل بصرية لتحسين التواصل بين العميل والمطور.
  * [meet.jit.si](https://meet.jit.si/) — محادثات فيديو بنقرة واحدة ومشاركة شاشة، مجاناً.
  * [Microsoft Teams](https://products.office.com/microsoft-teams/free) — Microsoft Teams مركز رقمي للدردشة يجمع المحادثات والمحتوى والتطبيقات في مكان واحد من تجربة واحدة. مجاناً حتى 500 ألف مستخدم.
  * [Miro](https://miro.com/) - سبورة تعاونية قابلة للتوسع وآمنة وجاهزة للمؤسسات للفرق الموزعة. مع خطة مجانية.
  * [nootiz](https://www.nootiz.com/) - الأداة المثلى لجمع وإدارة الملاحظات البصرية على أي موقع إلكتروني.
  * [Notion](https://www.notion.so/) - Notion هو تطبيق لتدوين الملاحظات والتعاون مع دعم Markdown ويجمع بين المهام والويكي وقواعد البيانات. تصف الشركة التطبيق بأنه مساحة عمل شاملة لتدوين الملاحظات وإدارة المشاريع والمهام. بالإضافة إلى التطبيقات عبر الأنظمة الأساسية، يمكن الوصول إليه من معظم متصفحات الويب.
  * [Nuclino](https://www.nuclino.com) - ويكي خفيف الوزن وتعاوني لكل معرفة ووثائق وملاحظات فريقك. خطة مجانية بجميع الميزات الأساسية، حتى 50 عنصرًا، و5 جيجابايت تخزين.
  * [OnlineInterview.io](https://onlineinterview.io/) - منصة مقابلات برمجية مجانية مع دردشة فيديو مدمجة، ولوحة رسم، ومحرر كود عبر الإنترنت حيث يمكنك تجميع وتشغيل الكود في المتصفح. يمكنك إنشاء غرفة مقابلة عن بعد بضغطة واحدة.
  * [Quidlo Timesheets](https://www.quidlo.com/timesheets) - تطبيق جداول زمنية وتتبع وقت بسيط للفرق. الخطة المجانية تتضمن ميزات تتبع الوقت وتوليد التقارير حتى 10 مستخدمين.
  * [PageShare.dev](https://www.pageshare.dev) - يضيف إمكانيات مراجعة بصرية إلى طلبات السحب في GitHub دون الحاجة لنشر المواقع. مجاني حتى 10 صفحات شهريًا و100 ميجابايت تخزين إجمالي.
  * [Pendulums](https://pendulums.io/) - Pendulums أداة مجانية لتتبع الوقت تساعدك في إدارة وقتك بشكل أفضل بواجهة سهلة الإستخدام وإحصائيات قيمة.
  * [Pumble](https://pumble.com) - تطبيق دردشة فريق مجاني. عدد غير محدود من المستخدمين وسجل الرسائل، مجاني للأبد.
  * [Raindrop.io](https://raindrop.io) - تطبيق حفظ روابط خاص وآمن لأنظمة macOS وWindows وAndroid وiOS والويب. إشارات مرجعية غير محدودة وتعاون مجاني.
  * [element.io](https://element.io/) — أداة تواصل لامركزية ومفتوحة المصدر مبنية على Matrix. دردشات جماعية، رسائل مباشرة، نقل ملفات مشفر، دردشات صوتية وفيديو، وتكامل سهل مع الخدمات الأخرى.
  * [Rocket.Chat](https://rocket.chat/) - منصة تواصل مفتوحة المصدر مع ميزات Omnichannel، اتحاد Matrix، جسر مع تطبيقات أخرى، رسائل غير محدودة وسجل رسائل كامل.
  * [seafile.com](https://www.seafile.com/) — تخزين سحابي أو خاص، مشاركة ملفات، مزامنة، مناقشات. النسخة السحابية توفر 1 جيجابايت فقط.
  * [Sema](https://www.semasoftware.com/) - أداة مجانية لمحفظة المطورين قادرة على دمج وأخذ لقطات للمساهمات عبر مستودعات متعددة في تقرير واحد.
  * [Screen Sharing via Browser](https://screensharing.net) - أداة مشاركة شاشة مجانية، شارك شاشتك مع المتعاونين مباشرة من المتصفح بدون تحميل أو تسجيل. مجانًا.
  * [Slab](https://slab.com/) — خدمة إدارة معرفة حديثة للفرق. مجاناً حتى 10 مستخدمين.
  * [slack.com](https://slack.com/) — مجاني لعدد غير محدود من المستخدمين مع بعض القيود على الميزات.
  * [Spectrum](https://spectrum.chat/) - أنشئ مجتمعات عامة أو خاصة مجانًا.
  * [StatusPile](https://www.statuspile.com/) - صفحة حالة لصفحات الحالة. هل يمكنك متابعة صفحات حالة مزودي الخدمة لديك؟
  * [Stickies](https://stickies.app/) - تطبيق تعاون بصري يستخدم للعصف الذهني وتنظيم المحتوى والملاحظات. مجانًا حتى 3 جدران، عدد غير محدود من المستخدمين و1 جيجابايت تخزين.
  * [Stacks](https://betterstacks.com/) - مساحة عمل للمحتوى مع ملاحظات وروابط وتخزين ملفات مدمج للتغلب على إرهاق المعلومات. خطة شخصية مجانية للأبد.
  * [talky.io](https://talky.io/) — دردشة فيديو جماعية مجانية. مجهول. نظير إلى نظير. لا حاجة لإضافات أو تسجيل أو دفع.
  * [Teamhood](https://teamhood.com/) - برنامج مجاني لإدارة المشاريع والمهام وتتبع المشكلات. يدعم كانبان مع Swimlanes وتطبيق Scrum كامل. يتضمن تتبع الوقت. مجاني لخمسة مستخدمين وثلاثة محافظ مشاريع.
  * [Teamplify](https://teamplify.com) - تحسين عمليات تطوير الفريق مع تحليلات الفريق وDaily Standup الذكي. يتضمن إدارة إجازات كاملة الميزات للفرق البعيدة أولًا. مجاني لمجموعات صغيرة حتى 5 مستخدمين.
  * [Tefter](https://tefter.io) - تطبيق إشارات مرجعية مع تكامل قوي مع Slack. مجاني للفرق مفتوحة المصدر.
  * [TeleType](https://teletype.oorja.io/) — شارك الطرفيات والصوت والكود والسبورة والمزيد. لا حاجة لتسجيل الدخول لتعاون مشفر من طرف إلى طرف للمطورين.
  * [TimeCamp](https://www.timecamp.com/) - برنامج مجاني لتتبع الوقت لعدد غير محدود من المستخدمين. يتكامل بسهولة مع أدوات إدارة المشاريع مثل Jira وTrello وAsana وغيرها.
  * [Huly](https://huly.io/) - منصة إدارة مشاريع متكاملة (بديل لـ Linear وJira وSlack وNotion وMotion) - عدد غير محدود من المستخدمين، 10 جيجابايت تخزين لكل مساحة عمل، 10 جيجابايت نقل فيديو (صوتي).
  * [Teamcamp](https://www.teamcamp.app) - تطبيق إدارة مشاريع متكامل لشركات تطوير البرمجيات.
  * [twist.com](https://twist.com) — تطبيق تواصل للفريق مناسب للعمل غير المتزامن حيث تظل المحادثات منظمة وذات صلة. تتوفر خطط مجانية وغير محدودة. خصومات للفرق المؤهلة.
  * [tldraw.com](https://tldraw.com) — أداة رسم وتخطيط مفتوحة المصدر مجانية مع أسهم ذكية، وتثبيت، وملاحظات لاصقة، وميزات تصدير SVG. وضع متعدد اللاعبين للتحرير التعاوني. يتوفر أيضًا ملحق رسمي مجاني لـ VS Code.
  * [BookmarkOS.com](https://bookmarkos.com) - مدير إشارات مرجعية، ومدير تبويبات، ومدير مهام مجاني الكل في واحد ضمن سطح مكتب عبر الإنترنت قابل للتخصيص مع تعاون عبر المجلدات.
  * [typetalk.com](https://www.typetalk.com/) — شارك وناقش الأفكار مع فريقك عبر الرسائل الفورية على الويب أو الجوال.
  * [Tugboat](https://tugboat.qa) - معاينة لكل طلب سحب تلقائيًا وعند الطلب. مجاني للجميع، مستوى Nano مجاني للمنظمات غير الربحية.
  * [whereby.com](https://whereby.com/) — محادثات فيديو بنقرة واحدة، مجاناً (سابقًا appear.in)
  * [windmill.dev](https://windmill.dev/) - Windmill منصة مفتوحة المصدر للمطورين لبناء أتمتة إنتاجية وتطبيقات داخلية متعددة الخطوات بسرعة من سكريبتات Python وTypescript بسيطة. كمستخدم مجاني يمكنك إنشاء أو الانضمام إلى ثلاثة مساحات عمل غير مميزة كحد أقصى.
  * [vadoo.tv](https://vadoo.tv/) — استضافة وتسويق الفيديو بسهولة. رفع الفيديوهات بنقرة واحدة. تسجيل، إدارة، مشاركة وأكثر. الخطة المجانية توفر حتى 10 فيديوهات، 1 جيجابايت تخزين، و10 جيجابايت نقل بيانات/شهريًا.
  * [userforge.com](https://userforge.com/) - شخصيات متصلة عبر الإنترنت، وقصص مستخدمين، ورسم سياق. يساعد في الحفاظ على التوافق بين التصميم والتطوير، مجانًا حتى 3 شخصيات و2 متعاونين.
  * [wistia.com](https://wistia.com/) — استضافة فيديو مع تحليلات مشاهدين، تسليم فيديو عالي الدقة، وأدوات تسويق لفهم زوارك، 25 فيديو ومشغل بعلامة Wistia.
  * [wormhol.org](https://www.wormhol.org/) — خدمة مشاركة ملفات مباشرة. شارك عدد غير محدود من الملفات حتى 5 جيجابايت مع أي عدد من الأشخاص.
  * [Wormhole](https://wormhole.app/) - شارك ملفات حتى 5 جيجابايت مع تشفير من طرف إلى طرف لمدة تصل إلى 24 ساعة. للملفات الأكبر من 5 جيجابايت، يستخدم النقل نظير إلى نظير لنقل الملفات مباشرة.
  * [zoom.us](https://zoom.us/) — مؤتمرات فيديو وويب آمنة مع إضافات متوفرة. الخطة المجانية محدودة بـ 40 دقيقة.
  * [Zulip](https://zulip.com/) — دردشة فورية مع نموذج تنظيم فريد يشبه البريد الإلكتروني. الخطة المجانية تشمل 10,000 رسالة في سجل البحث وتخزين ملفات حتى 5 جيجابايت. كما توفر نسخة مفتوحة المصدر قابلة للاستضافة الذاتية.
  * [robocorp.com](https://robocorp.com) - مجموعة مفتوحة المصدر لتشغيل عمليات الأتمتة. جرب ميزات السحابة وطبق أتمتة بسيطة مجانًا. عمل الروبوت 240 دقيقة/شهر، 10 تشغيلات مساعد، تخزين 100 ميجابايت.
  * [Fleep.io](https://fleep.io/) — Fleep بديل لـ Slack. خطة مجانية للفرق الصغيرة مع سجل رسائل كامل، محادثات 1:1 غير محدودة، محادثة جماعية واحدة، و1 جيجابايت تخزين ملفات.
  * [Chanty.com](https://chanty.com/) — Chanty بديل آخر لـ Slack. خطة مجانية للأبد للفرق الصغيرة (حتى 10) مع محادثات عامة وخاصة غير محدودة، سجل قابل للبحث، مكالمات صوتية 1:1 غير محدودة، رسائل صوتية غير محدودة، 10 تكاملات، و20 جيجابايت تخزين لكل فريق.
  * [ruttl.com](https://ruttl.com/) — أفضل أداة شاملة لجمع الملاحظات الرقمية ومراجعة المواقع وملفات PDF والصور.
  * [Mattermost](https://mattermost.com/) — تعاون آمن للفرق التقنية. خطة مجانية مع قنوات غير محدودة، وكتب لعب، ولوحات، ومستخدمين، و10 جيجابايت تخزين، وأكثر.
  * [Webvizio](https://webvizio.com) — أداة ملاحظات للمواقع، وبرمجية مراجعة مواقع، وأداة تقارير أخطاء لتسهيل التعاون في تطوير الويب على المهام مباشرة على المواقع الحية وتطبيقات الويب والصور وملفات PDF وملفات التصميم.
  * [Pullflow](https://pullflow.com) — Pullflow يقدم منصة معززة بالذكاء الاصطناعي لتعاون مراجعة الكود عبر GitHub وSlack وVS Code.
  * [Webex](https://www.webex.com/) — اجتماعات فيديو مع خطة مجانية توفر 40 دقيقة لكل اجتماع و100 مشارك.
  * [RingCentral](https://www.ringcentral.com/) — اجتماعات فيديو مع خطة مجانية توفر 50 دقيقة لكل اجتماع و100 مشارك.
  * [GitBook](https://www.gitbook.com/) — منصة لتوثيق المعرفة التقنية من وثائق المنتجات إلى قواعد المعرفة الداخلية وواجهات برمجة التطبيقات. خطة مجانية للمطورين الأفراد.
  * [transfernow](https://www.transfernow.net/) — أبسط وأسرع وأأمن واجهة لنقل ومشاركة الملفات. أرسل الصور والفيديوهات وملفات كبيرة أخرى بدون اشتراك إلزامي.
  * [paste.sh](https://paste.sh/) — موقع لصق بسيط معتمد على JavaScript والتشفير.
  * [Revolt.chat](https://revolt.chat/) — بديل مفتوح المصدر لـ [Discord](https://discord.com/)، يحترم خصوصيتك. يحتوي على معظم ميزات Discord التجارية مجاناً. Revolt تطبيق شامل وآمن وسريع ومجاني 100%. كل الميزات مجانية. كما يدعم (إضافات رسمية وغير رسمية) على عكس معظم تطبيقات الدردشة التجارية.
  * [Tencent RTC](https://trtc.io/) — حلول اتصالات صوتية/فيديو جماعية من Tencent. 10,000 دقيقة مجانية شهريًا للسنة الأولى.
  * [Pastefy](https://pastefy.app/) - Pastebin جميل وبسيط مع تشفير اختياري من العميل، لصق متعدد التبويبات، واجهة API، محرر مميز والمزيد.
  * [SiteDots](https://sitedots.com/) - شارك الملاحظات لمشاريع المواقع مباشرة على موقعك دون محاكاة أو قماش أو حلول بديلة. خطة مجانية عملية بالكامل.

**[⬆️ العودة للأعلى](#table-of-contents)**

## أنظمة إدارة المحتوى (CMS)

  * [acquia.com](https://www.acquia.com/) — استضافة لمواقع Drupal. خطة مجانية للمطورين. تتوفر أيضًا أدوات تطوير مجانية (مثل Acquia Dev Desktop).
  * [Contentful](https://www.contentful.com/) — نظام إدارة محتوى بدون واجهة (Headless CMS). إدارة وتوصيل المحتوى عبر API في السحابة. يأتي بمساحة مجتمع مجانية واحدة تشمل خمسة مستخدمين، 25 ألف سجل، 48 نوع محتوى، ولغتين.
  * [Cosmic](https://www.cosmicjs.com/) — نظام إدارة محتوى بدون واجهة وأدوات API. خطط شخصية مجانية للمطورين.
  * [Crystallize](https://crystallize.com) — إدارة معلومات المنتجات بدون واجهة مع دعم التجارة الإلكترونية. واجهة برمجة تطبيقات GraphQL مدمجة. النسخة المجانية تشمل مستخدمين غير محدودين، 1000 عنصر كتالوج، 5 جيجابايت/شهر نقل بيانات، و25 ألف مكالمة API شهرياً.
  * [DatoCMS](https://www.datocms.com/) - يقدم خطة مجانية للمشاريع الصغيرة. DatoCMS هو نظام إدارة محتوى معتمد على GraphQL. في الطبقة الأدنى لديك 100 ألف مكالمة شهريًا.
  * [Directus](https://directus.io) — نظام إدارة محتوى بدون واجهة. منصة مجانية ومفتوحة المصدر بالكامل لإدارة الأصول ومحتوى قاعدة البيانات محليًا أو في السحابة. بدون أي قيود أو جدران دفع.
  * [FrontAid](https://frontaid.io/) — نظام إدارة محتوى بدون واجهة يخزن محتوى JSON مباشرة في مستودع Git الخاص بك. بدون قيود.
  * [kontent.ai](https://www.kontent.ai) - منصة محتوى كخدمة توفر جميع مزايا الـ Headless CMS مع تمكين المسوقين في نفس الوقت. خطة المطور توفر مستخدمين غير محدودين مع مشاريع غير محدودة وبيئتين لكل مشروع، 500 عنصر محتوى، لغتين، مع واجهتي API للإدارة والتوصيل ودعم العناصر المخصصة. يمكنك استخدام خطط أكثر تفصيلاً حسب احتياجك.
  * [Prismic](https://www.prismic.io/) — نظام إدارة محتوى بدون واجهة. واجهة إدارة محتوى مع API مستضاف وقابل للتوسع بالكامل. خطة المجتمع توفر مكالمات API غير محدودة، مستندات، أنواع مخصصة، أصول ولغات غير محدودة لمستخدم واحد. كل ما تحتاجه لمشروعك التالي. تتوفر خطط مجانية أكبر للمشاريع مفتوحة المحتوى أو مفتوحة المصدر.
  * [Sanity.io](https://www.sanity.io/) - منصة للمحتوى المنظم مع بيئة تحرير مفتوحة المصدر وتخزين بيانات مستضاف في الوقت الحقيقي. مشاريع غير محدودة. مشرفين غير محدودين، ثلاثة مستخدمين عاديين، مجموعتي بيانات، 500 ألف طلب API CDN، 10 جيجابايت نقل بيانات، و5 جيجابايت أصول مجانًا لكل مشروع.
  * [sensenet](https://sensenet.com) - نظام إدارة محتوى بدون واجهة معتمد على API ويوفر حلولاً للمؤسسات بجميع الأحجام. خطة المطور توفر ثلاثة مستخدمين، 500 عنصر محتوى، ثلاثة أدوار مدمجة، 25+5 نوع محتوى، واجهة REST API كاملة الوصول، توليد معاينة المستندات وتحرير Office Online.
  * [TinaCMS](https://tina.io/) — بديل لـ Forestry.io. نظام إدارة محتوى مفتوح المصدر مدعوم بـ Git يدعم Markdown وMDX وJSON. العرض الأساسي مجاني مع مستخدمين اثنين.
  * [GatsbyjsCMS](https://www.gatsbyjs.com/) - Gatsby هو إطار عمل سريع ومرن يجعل بناء المواقع بأي CMS أو API أو قاعدة بيانات ممتعًا من جديد. ابنِ وانشر مواقع بدون واجهة تحقق المزيد من الزيارات والتحويلات والأرباح!
  * [Hygraph](https://hygraph.com/) - يقدم خطة مجانية للمشاريع الصغيرة. واجهة API معتمدة على GraphQL أولاً. انتقل بعيدًا عن الحلول التقليدية إلى نظام إدارة محتوى بدون واجهة أصلي مع GraphQL وقدم محتوى متعدد القنوات عبر API أولاً.
  * [Squidex](https://squidex.io/) - يقدم طبقة مجانية للمشاريع الصغيرة. API / GraphQL أولاً. مفتوح المصدر ويعتمد على event sourcing (إصدار تلقائي لكل تغيير).
  * [InstaWP](https://instawp.com/) - أطلق موقع ووردبريس في ثوانٍ. طبقة مجانية تشمل 5 مواقع نشطة، 500 ميجابايت مساحة، وانتهاء الموقع خلال 48 ساعة.
  * [Storyblok](https://www.storyblok.com) - نظام إدارة محتوى بدون واجهة للمطورين والمسوقين يعمل مع جميع الأطر الحديثة. الطبقة المجتمعية (المجانية) تقدم API للإدارة، محرر بصري، عشرة مصادر، أنواع حقول مخصصة، دعم تعدد اللغات (عدد غير محدود)، مدير أصول (حتى 2500 أصل)، خدمة تحسين الصور، استعلام بحث، Webhook + 250 جيجابايت ترافيك/شهرياً.
  * [WPJack](https://wpjack.com) - أنشئ ووردبريس على أي سحابة في أقل من 5 دقائق! الطبقة المجانية تشمل خادم واحد، موقعين، شهادات SSL مجانية، وجدولات كرون غير محدودة. لا يوجد حدود زمنية أو انتهاء صلاحية—موقعك، بطريقتك.

**[⬆️ العودة إلى الأعلى](#table-of-contents)**

## توليد الشيفرة

  * [Appinvento](https://appinvento.io/) — AppInvento هو منشئ تطبيقات بدون كود مجاني. في الشيفرة الخلفية المولدة تلقائياً، لدى المستخدمين وصول كامل إلى الشيفرة المصدرية وواجهات API غير محدودة والمسارات، مما يسمح بتكامل واسع. الخطة المجانية تشمل ثلاثة مشاريع، خمسة جداول، وإضافة Google.
  * [Cody AI](https://sourcegraph.com/cody) - Cody هو مساعد برمجة بالذكاء الاصطناعي يستخدم الذكاء الاصطناعي وفهماً عميقاً لقاعدة الشيفرة لديك لمساعدتك في كتابة وفهم الشيفرة بسرعة أكبر. يوفر Cody للمطورين اختيار نماذج LLMs (بما في ذلك الاستدلال المحلي)، ويدعم العديد من بيئات التطوير المتكاملة IDEs، ويدعم جميع لغات البرمجة الشائعة، ولديه خطة مجانية. الخطة المجانية تعطي المطورين 20 رسالة دردشة (باستخدام Claude 3 Sonnet كنموذج LLM) و500 إكمال تلقائي (باستخدام Starcoder 16b) كل شهر.
  * [DhiWise](https://www.dhiwise.com/) — حوّل تصاميم Figma بسلاسة إلى تطبيقات Flutter وReact ديناميكية باستخدام تقنية توليد الشيفرة المبتكرة من DhiWise، مما يحسن سير العمل ويساعدك في إنشاء تجارب ويب وموبايل استثنائية بسرعة غير مسبوقة.
  * [Codeium](https://www.codeium.com/) — Codeium هو أداة مجانية لإكمال الشيفرة مدعومة بالذكاء الاصطناعي. يدعم أكثر من 20 لغة برمجة (Python, JavaScript, Java, TypeScript, PHP, C/C++, Go, إلخ) ويتكامل مع جميع بيئات التطوير الرئيسية المستقلة وعبر الويب.
  * [Fern](https://buildwithfern.com) - اكتب تعريفات API واستخدمها لتوليد SDKs/مكتبات عملاء بلغات شائعة مثل TypeScript, Python, Java, Go والمزيد. دعم كامل لـ OpenAPI. الطبقة المجانية تولد الشيفرة حتى 20 نقطة نهاية كحد أقصى.
  * [Metalama](https://www.postsharp.net/metalama) - فقط للغة #C. تولد Metalama القوالب البرمجية أثناء الترجمة بحيث تبقى شيفرتك المصدرية نظيفة. مجانية للمشاريع مفتوحة المصدر، والطبقة المجانية الصديقة للأعمال تشمل ثلاثة جوانب.
  * [Supermaven](https://www.supermaven.com/) — Supermaven هو مكون إضافي سريع لإكمال الشيفرة بالذكاء الاصطناعي لـ VSCode, JetBrains, وNeovim. الطبقة المجانية توفر إكمالات مضمنة غير محدودة.
  * [tabnine.com](https://www.tabnine.com/) — تساعد Tabnine المطورين على إنشاء برامج أفضل وبشكل أسرع عبر تزويدهم برؤى مستخلصة من جميع الشيفرات في العالم. متوفر كمكون إضافي.
  * [v0.dev](https://v0.dev/) — يستخدم v0 نماذج الذكاء الاصطناعي لتوليد الشيفرة بناءً على مطالبات نصية بسيطة. يولد شيفرة React جاهزة للنسخ واللصق تعتمد على shadcn/ui وTailwind CSS يمكن استخدامها في المشاريع. كل توليد يستهلك 30 نقطة كحد أدنى. تبدأ بـ 1200 نقطة، وتحصل على 200 نقطة مجانية كل شهر.

**[⬆️ العودة إلى الأعلى](#table-of-contents)**

## جودة الشيفرة

  * [beanstalkapp.com](https://beanstalkapp.com/) — سير عمل متكامل لكتابة ومراجعة ونشر الشيفرة، حساب مجاني لمستخدم واحد ومستودع واحد بسعة 100 ميجابايت.
  * [browserling.com](https://www.browserling.com/) — اختبار تفاعلي مباشر عبر المتصفحات، مجاني فقط لجلسات مدتها 3 دقائق مع MS IE 9 على Vista بدقة 1024 × 768.
  * [codacy.com](https://www.codacy.com/) — مراجعات شيفرة مؤتمتة لـ PHP, Python, Ruby, Java, JavaScript, Scala, CSS, وCoffeeScript، مجانية لمستودعات عامة وخاصة غير محدودة.
  * [Codeac.io](https://www.codeac.io/infrastructure-as-code.html?ref=free-for-dev) - أداة مراجعة مؤتمتة لـ Infrastructure as Code لفرق DevOps تتكامل مع GitHub, Bitbucket, وGitLab (حتى المستضاف ذاتياً). بالإضافة للغات القياسية، تحلل أيضاً Ansible, Terraform, CloudFormation, Kubernetes والمزيد. (مجاني مفتوح المصدر)
  * [CodeBeat](https://codebeat.co) — منصة مراجعة شيفرة مؤتمتة متوفرة للغات عديدة. مجانية دائماً للمستودعات العامة مع تكامل Slack والبريد الإلكتروني.
  * [codeclimate.com](https://codeclimate.com/) — مراجعة شيفرة مؤتمتة، مجانية للمصدر المفتوح ومستودعات خاصة غير محدودة مملوكة للمؤسسات (حتى 4 متعاونين). أيضاً مجانية للطلاب والمؤسسات.
  * [codecov.io](https://codecov.io/) — أداة تغطية الشيفرة (SaaS)، مجانية للمصدر المفتوح ومستودع خاص واحد.
  * [CodeFactor](https://www.codefactor.io) — مراجعة شيفرة مؤتمتة لـ Git. النسخة المجانية تشمل مستخدمين غير محدودين ومستودعات عامة ومستودع خاص واحد.
  * [coderabbit.ai](https://coderabbit.ai) — أداة مراجعة شيفرة مدعومة بالذكاء الاصطناعي تتكامل مع GitHub/GitLab. الطبقة المجانية تشمل 200 ملف/ساعة، 3 مراجعات في الساعة، و50 محادثة/ساعة. مجانية دائماً للمشاريع مفتوحة المصدر.
  * [codescene.io](https://codescene.io/) - تعطي CodeScene أولوية للدين الفني بناءً على كيفية عمل المطورين مع الشيفرة وتصور عوامل تنظيمية مثل تشابك الفرق وإتقان النظام. مجانية للمصدر المفتوح.
  * [CodSpeed](https://codspeed.io) - أتمتة تتبع الأداء في خطوط CI الخاصة بك. اكتشف تراجعات الأداء قبل النشر بفضل المقاييس الدقيقة والمتسقة. مجانية دائماً للمشاريع مفتوحة المصدر.
  * [coveralls.io](https://coveralls.io/) — عرض تقارير تغطية الاختبارات، مجاني للمصدر المفتوح
  * [dareboost](https://dareboost.com) - 5 تقارير تحليل مجانية شهرياً لأداء الويب، الوصول، والأمان
  * [deepcode.ai](https://www.deepcode.ai) — DeepCode يكتشف الأخطاء والثغرات الأمنية ومشكلات الأداء وAPI استناداً إلى الذكاء الاصطناعي. سرعة التحليل تمكننا من تحليل الشيفرة في الوقت الحقيقي وإظهار النتائج عند الحفظ في IDE. اللغات المدعومة: Java, C/C++, JavaScript, Python, TypeScript. تكامل مع GitHub, BitBucket, وGitLab. مجاني للمصدر المفتوح والمستودعات الخاصة وحتى 30 مطوراً.
  * [deepscan.io](https://deepscan.io) — تحليل ثابت متقدم لاكتشاف أخطاء وقت التشغيل تلقائياً في شيفرة JavaScript، مجاني للمصدر المفتوح
  * [DeepSource](https://deepsource.io/) - تحلل DeepSource تغييرات الشيفرة باستمرار، وتكتشف وتصلح المشكلات المصنفة تحت الأمان، الأداء، الأنماط السيئة، مخاطر الأخطاء، التوثيق، والأسلوب. تكامل أصلي مع GitHub, GitLab, وBitbucket.
  * [DiffText](https://difftext.com) - اكتشف فورياً الفروق بين كتلتين من الشيفرة. مجاني تماماً للاستخدام.
  * [eversql.com](https://www.eversql.com/) — EverSQL - المنصة رقم 1 لتحسين قواعد البيانات. احصل على رؤى حاسمة حول قاعدة بياناتك واستعلامات SQL تلقائياً.
  * [gerrithub.io](https://review.gerrithub.io/) — مراجعة Gerrit لمستودعات GitHub مجاناً
  * [gocover.io](https://gocover.io/) — تغطية الشيفرة لأي [Go](https://golang.org/) حزمة
  * [goreportcard.com](https://goreportcard.com/) — جودة الشيفرة لمشاريع Go، مجانية للمصدر المفتوح
  * [gtmetrix.com](https://gtmetrix.com/) — تقارير وتوصيات شاملة لتحسين مواقع الويب
  * [holistic.dev](https://holistic.dev/) - أفضل محلل شيفرة ثابتة لتحسين PostgreSQL. خدمة كشف تلقائي لمشاكل الأداء والأمان والبنية لقاعدة البيانات.
  * [houndci.com](https://houndci.com/) — تعليقات على التزامات GitHub حول جودة الشيفرة، مجانية للمصدر المفتوح
  * [Moderne.io](https://app.moderne.io) — إعادة تشكيل تلقائي للشيفرة المصدرية. تقدم Moderne ترحيل الأطر، تحليل الشيفرة مع التصحيح، وتحويل الشيفرة على نطاق واسع، ليتمكن المطورون من قضاء وقتهم في بناء الجديد بدلاً من صيانة القديم. مجاني للمصدر المفتوح.
  * [reviewable.io](https://reviewable.io/) — مراجعة الشيفرة لمستودعات GitHub، مجاني للمستودعات العامة أو الشخصية.
  * [parsers.dev](https://parsers.dev/) - محللات شجرة البنية المجردة ومجمعات تمثيل وسيط كخدمة
  * [scan.coverity.com](https://scan.coverity.com/) — تحليل ثابت للشيفرة لـ Java, C/C++, C# وJavaScript، مجاني للمصدر المفتوح
  * [scrutinizer-ci.com](https://scrutinizer-ci.com/) — منصة تفتيش مستمر، مجانية للمصدر المفتوح
  * [semanticdiff.com](https://app.semanticdiff.com/) — فرق برمجي واعٍ للغة لطلبات السحب والالتزامات في GitHub، مجاني للمستودعات العامة
  * [shields.io](https://shields.io) — شارات بيانات وصفية لجودة المشاريع مفتوحة المصدر
  * [sonarcloud.io](https://sonarcloud.io) — تحليل تلقائي للشيفرة المصدرية لـ Java, JavaScript, C/C++, C#, VB.NET, PHP, Objective-C, Swift, Python, Groovy والمزيد من اللغات، مجاني للمصدر المفتوح
  * [SourceLevel](https://sourcelevel.io/) — مراجعة شيفرة مؤتمتة وتحليلات للفريق. مجاني للمصدر المفتوح والمنظمات حتى 5 متعاونين.
  * [webceo.com](https://www.webceo.com/) — أدوات SEO مع تحقق من الشيفرة وأنواع أجهزة مختلفة
  * [zoompf.com](https://zoompf.com/) — أصلح أداء مواقعك الإلكترونية، تحليل مفصل

**[⬆️ العودة إلى الأعلى](#table-of-contents)**

## البحث وتصفح الشيفرة

  * [libraries.io](https://libraries.io/) — بحث وإشعارات تحديث الاعتماديات لـ 32 مدير حزم مختلف، مجاني للمصدر المفتوح
  * [Namae](https://namae.dev/) - البحث في مواقع مختلفة مثل GitHub, Gitlab, Heroku, Netlify، والمزيد حول توفر اسم مشروعك.
  * [searchcode.com](https://searchcode.com/) — بحث نصي شامل في الشيفرة، مجاني للمصدر المفتوح
  * [tickgit.com](https://www.tickgit.com/) — يبرز تعليقات `TODO` (وغيرها من العلامات) لتحديد مناطق الشيفرة الجديرة بالتحسين لاحقاً.
  * [CodeKeep](https://codekeep.io) - Google Keep لمقتطفات الشيفرة. نظم، واكتشف، وشارك مقتطفات الشيفرة مع أداة قوية لالتقاط صور الشيفرة باستخدام قوالب جاهزة وميزة الربط.

**[⬆️ العودة إلى الأعلى](#table-of-contents)**

## التكامل المستمر والتسليم المستمر (CI و CD)

  * [AccessLint](https://github.com/marketplace/accesslint) — يجلب AccessLint اختبارات الوصولية المؤتمتة إلى سير عملك البرمجي. مجاني للمصدر المفتوح والأغراض التعليمية.
  * [appcircle.io](https://appcircle.io) — منصة DevOps للموبايل بمستوى مؤسساتي لأتمتة بناء، اختبار، ونشر تطبيقات الموبايل لدورة إصدار أسرع وأكثر كفاءة. مجاني لـ 30 دقيقة كحد أقصى للبناء لكل بناء، 20 بناء شهرياً وبناء متزامن واحد.
  * [appveyor.com](https://www.appveyor.com/) — خدمة CD لأنظمة ويندوز، مجانية للمصدر المفتوح
  * [LocalOps](https://localops.co/) - انشر تطبيقك على AWS/GCP/Azure في أقل من 30 دقيقة. إعداد بيئات تطبيقات موحدة على أي سحابة، مع أتمتة نشر مستمرة ومراقبة متقدمة. الخطة المجانية تسمح بمستخدم واحد وبيئة تطبيق واحدة.
  * [Argonaut](https://argonaut.dev/) - انشر التطبيقات والبنية التحتية على سحابتك في دقائق. دعم لنشر التطبيقات المخصصة وتطبيقات الطرف الثالث على Kubernetes وLambda. الطبقة المجانية تسمح بعدد غير محدود من التطبيقات والنشر لـ 5 نطاقات و2 مستخدمين.
  * [bitrise.io](https://www.bitrise.io/) — CI/CD لتطبيقات الجوال، أصلية أو هجينة. 200 بناء مجاني/شهرياً، 10 دقائق لكل بناء وعضوين بالفريق. مشاريع المصدر المفتوح تحصل على 45 دقيقة للبناء، +1 تزامن وحجم فريق غير محدود.
  * [buddy.works](https://buddy.works/) — CI/CD مع خمسة مشاريع مجانية وتشغيل متزامن واحد (120 تنفيذ/شهر)
  * [Buildkite](https://buildkite.com) خطوط CI مجانية لـ 3 مستخدمين و5000 دقيقة وظائف شهرياً. طبقة تحليلات الاختبار المجانية تشمل 100,000 تنفيذ اختبار شهرياً، مع مزيد من الامتيازات المجانية للمشاريع مفتوحة المصدر.
  * [bytebase.com](https://www.bytebase.com/) — CI/CD وقواعد بيانات DevOps. مجاني لأقل من 20 مستخدم و10 قواعد بيانات.
  * [CircleCI](https://circleci.com/) — خطة مجانية شاملة مع كل الميزات ضمن خدمة CI/CD مستضافة لمستودعات GitHub, GitLab, وBitBucket. فئات موارد متعددة، دعم Docker، ويندوز، ماك، ARM، عداؤون محليون، تقسيم الاختبارات، تخزين مؤقت لطبقات Docker، وميزات CI/CD متقدمة أخرى. مجاني حتى 6000 دقيقة تنفيذ شهرياً، متعاونين غير محدودين، 30 وظيفة متوازية في المشاريع الخاصة، وحتى 80,000 دقيقة بناء مجانية لمشاريع المصدر المفتوح.
  * [cirrus-ci.org](https://cirrus-ci.org) - مجاني للمستودعات العامة على GitHub
  * [cirun.io](https://cirun.io) - مجاني للمستودعات العامة على GitHub
  * [codefresh.io](https://codefresh.io) — خطة مجانية مدى الحياة: بناء واحد، بيئة واحدة، خوادم مشتركة، مستودعات عامة غير محدودة
  * [codemagic.io](https://codemagic.io/) - 500 دقيقة بناء مجانية شهرياً
  * [codeship.com](https://codeship.com/) — 100 بناء خاص شهرياً، خمسة مشاريع خاصة، غير محدود للمصدر المفتوح
  * [deploybot.com](https://www.deploybot.com/) — مستودع واحد مع عشرة نشرات، مجاني للمصدر المفتوح
  * [deployhq.com](https://www.deployhq.com/) — مشروع واحد مع عشرة نشرات يومياً (30 دقيقة بناء/شهر)
  * [drone](https://cloud.drone.io/) - Drone Cloud يتيح للمطورين تشغيل خطوط تسليم مستمرة عبر عدة معماريات - بما في ذلك x86 وArm (32 و64 بت) - في مكان واحد
  * [LayerCI](https://layerci.com) — CI لمشاريع full stack. بيئة معاينة كاملة واحدة مع 5GB ذاكرة و3 معالجات.
  * [semaphoreci.com](https://semaphoreci.com/) — مجاني للمصدر المفتوح، 100 بناء خاص شهرياً
  * [Squash Labs](https://www.squash.io/) — ينشئ جهاز افتراضي لكل فرع ويجعل تطبيقك متاحاً من عنوان URL فريد، مستودعات عامة وخاصة غير محدودة، حتى 2GB حجم الجهاز الافتراضي.
  * [styleci.io](https://styleci.io/) — مستودعات GitHub العامة فقط
  * [Mergify](https://mergify.io) — أتمتة سير العمل وطابور الدمج لـ GitHub — مجاني للمستودعات العامة على GitHub
  * [Make](https://www.make.com/en) — أداة أتمتة سير العمل تتيح لك ربط التطبيقات وأتمتة سير العمل باستخدام واجهة مستخدم. تدعم العديد من التطبيقات وواجهات API الأكثر شعبية. مجاني للمستودعات العامة على GitHub، وطبقة مجانية بسعة 100 ميجابايت، 1000 عملية، و15 دقيقة كحد أدنى للفاصل الزمني.
  * [Spacelift](https://spacelift.io/) - منصة إدارة للبنية التحتية ككود. ميزات الخطة المجانية: تعاون IaC، سجل وحدات Terraform، تكامل ChatOps، توافق مستمر للموارد مع Open Policy Agent، تسجيل دخول موحد بـ SAML 2.0، وصول لمجموعات العمال العامة: حتى 200 دقيقة/شهر
  * [microtica.com](https://microtica.com/) - بيئات الشركات الناشئة مع مكونات بنية تحتية جاهزة، انشر التطبيقات على AWS مجاناً، وادعم أعباء العمل الإنتاجية لديك. الطبقة المجانية تشمل بيئة واحدة (على حساب AWS الخاص بك)، خدمتي Kubernetes، 100 دقيقة بناء شهرياً، و20 نشر شهرياً.
* [Nx Cloud](https://nx.dev/ci) - يسرّع Nx Cloud مستودعات المونوريبوز على CI مع ميزات مثل التخزين المؤقت عن بُعد، وتوزيع المهام عبر الأجهزة، وحتى التقسيم التلقائي لجولات اختبارات e2e. يأتي مع خطة مجانية حتى 30 مساهمًا مع 150 ألف نقطة ائتمان سخية.
* [blacksmith](https://www.blacksmith.sh/) - مشغلات أداء مُدارة لـ GitHub Actions توفر 3,000 دقيقة مجانية شهريًا، بدون الحاجة إلى بطاقة ائتمان.
* [Terramate](https://terramate.io/) - منصة تنظيم وإدارة لأدوات البنية التحتية كرمز (IaC) مثل Terraform و OpenTofu و Terragrunt. مجاني حتى مستخدمين اثنين مع كافة الميزات.
* [Terrateam](https://terrateam.io) - أتمتة Terraform تعتمد GitOps مع سير عمل قائم على طلبات السحب، وعزل المشاريع عبر مشغلات مستضافة ذاتيًا، وجولات طبقية لتنفيذ العمليات بالترتيب. مجاني حتى 3 مستخدمين.

**[⬆️ العودة إلى الأعلى](#table-of-contents)**

## الاختبار

* [Applitools.com](https://applitools.com/) — تحقق ذكي بصري للتطبيقات الويب، والموبايل الأصلية، وتطبيقات سطح المكتب. يتكامل مع معظم حلول الأتمتة (مثل Selenium و Karma) والمشغلات عن بُعد (Sauce Labs، Browser Stack). مجاني للمشاريع مفتوحة المصدر. يوجد مستوى مجاني لمستخدم واحد مع نقاط تحقق محدودة أسبوعيًا.
* [Appetize](https://appetize.io) — اختبر تطبيقات Android و iOS على هذا المحاكي السحابي لهواتف Android / الأجهزة اللوحية ومحاكيات iPhone/iPad مباشرة في المتصفح. المستوى المجاني يشمل جلستين متزامنتين مع 30 دقيقة استخدام شهريًا. لا يوجد حد لحجم التطبيق.
* [Apptim](https://apptim.com) — أداة اختبار أداء الموبايل تتيح لمن لا يملكون مهارات هندسة الأداء تقييم أداء التطبيق وتجربة المستخدم (UX). النسخة المكتبية باستخدام جهازك مجانية 100%، مع اختبارات غير محدودة على iOS و Android.
* [Argos](https://argos-ci.com) - اختبار بصري مفتوح المصدر للمطورين. مشاريع غير محدودة مع 5,000 لقطة شاشة شهريًا. مجاني للمشاريع مفتوحة المصدر.
* [Bencher](https://bencher.dev/) - مجموعة أدوات قياس الأداء المستمر للعثور على تراجع الأداء في CI. مجاني لجميع المشاريع العامة.
* [browserstack.com](https://www.browserstack.com/) — اختبار يدوي وآلي للمتصفحات، [مجاني للمشاريع مفتوحة المصدر](https://www.browserstack.com/open-source?ref=pricing)
* [BugBug](https://bugbug.io/) - أداة أتمتة اختبار خفيفة الوزن لتطبيقات الويب. سهلة التعلم ولا تتطلب ترميزًا. يمكنك تشغيل اختبارات غير محدودة على جهازك مجانًا. يمكنك أيضًا الحصول على مراقبة سحابية وتكامل CI/CD مقابل رسوم شهرية إضافية.
* [Checkly](https://checklyhq.com) - مراقبة تركيبية تعتمد الكود لـ DevOps الحديثة. راقب واجهات برمجة التطبيقات والتطبيقات بسعر أقل من المزودين التقليديين. مدعوم بسير عمل مراقبة ككود و Playwright. مستوى مجاني سخي للمطورين.
* [checkbot.io](https://www.checkbot.io/) — إضافة متصفح تختبر إذا كان موقعك يتبع أكثر من 50 ممارسة مثلى لـ SEO، والسرعة، والأمان. مستوى مجاني للمواقع الصغيرة.
* [CORS-Tester](https://cors-error.dev/cors-tester/) - أداة مجانية للمطورين ومختبري API للتحقق مما إذا كانت واجهة برمجة التطبيقات تدعم CORS لنطاق معين وتحديد الفجوات. احصل على رؤى قابلة للتنفيذ.
* [cypress.io](https://www.cypress.io/) - اختبار سريع وسهل وموثوق لأي شيء يعمل في المتصفح. Cypress Test Runner مجاني ومفتوح المصدر دائمًا بدون قيود. Cypress Dashboard مجاني للمشاريع مفتوحة المصدر حتى 5 مستخدمين.
* [Cypress Recorder by Preflight](https://cypress.preflight.com/) - أنشئ اختبارات Cypress مدعومة بالذكاء الاصطناعي ونماذج POM على متصفحك. مفتوح المصدر باستثناء جزء الذكاء الاصطناعي. مجاني حتى خمس اختبارات شهريًا مع نصوص ذاتية الإصلاح، بريد إلكتروني، واختبار بصري.
* [everystep-automation.com](https://www.everystep-automation.com/) — يسجل ويعيد تشغيل جميع الخطوات في المتصفح وينشئ نصوصًا، مجاني مع خيارات أقل.
* [Gremlin](https://www.gremlin.com/gremlin-free-software) — أدوات هندسة الفوضى من Gremlin تتيح إدخال الأعطال بأنظمة الإنتاج بأمان لاكتشاف نقاط الضعف قبل ظهور مشكلات للعملاء. Gremlin Free يوفر إمكانية تنفيذ هجمات Shutdown و CPU على حتى 5 مضيفين أو حاويات.
* [gridlastic.com](https://www.gridlastic.com/) — اختبار Selenium Grid مع خطة مجانية حتى 4 عقد Selenium متزامنة/10 بدايات Grid/4,000 دقيقة اختبار شهريًا.
* [katalon.com](https://katalon.com) - منصة اختبار تساعد الفرق من جميع الأحجام في مختلف مراحل النضج، تشمل Katalon Studio، TestOps (+ اختبار بصري مجاني)، TestCloud، و Katalon Recorder.
* [Keploy](https://keploy.io/) - أداة اختبار وظيفي للمطورين. تسجيل مكالمات API يولد اختبارات E2E لـ APIs (KTests) ومحاكيات أو بدائل (KMocks). مجاني للمشاريع مفتوحة المصدر.
* [knapsackpro.com](https://knapsackpro.com) - سرع اختباراتك بتقسيم مجموعة الاختبار بشكل مثالي على أي مزود CI. قسم اختبارات Ruby و JavaScript على عقد CI متوازية لتوفير الوقت. خطة مجانية حتى 10 دقائق من ملفات الاختبار وخطة مجانية غير محدودة للمشاريع مفتوحة المصدر.
* [lambdatest.com](https://www.lambdatest.com/) — اختبار يدوي وبصري والتقاط الشاشة واختبار آلي على Selenium و Cypress، [مجاني للمشاريع مفتوحة المصدر](https://www.lambdatest.com/open-source-cross-browser-testing-tool)
* [loadmill.com](https://www.loadmill.com/) - إنشاء اختبارات API واختبارات تحميل تلقائيًا بتحليل حركة الشبكة. حاكي حتى 50 مستخدمًا متزامنًا لمدة 60 دقيقة شهريًا مجانًا.
* [lost-pixel.com](https://lost-pixel.com) - اختبار شامل للفروقات البصرية لـ Storybook، Ladle، Histoire، وتطبيقات الويب. أعضاء فريق غير محدودين، مجاني بالكامل للمشاريع مفتوحة المصدر، 7,000 لقطة/شهر.
* [octomind.dev](https://www.octomind.dev/) - اختبارات واجهة مستخدم Playwright مُولدة ومدارة تلقائيًا مع توليد حالات الاختبار بمساعدة الذكاء الاصطناعي.
* [percy.io](https://percy.io) - أضف اختبارًا بصريًا لأي تطبيق ويب أو موقع ثابت أو دليل أنماط أو مكتبة مكونات. أعضاء فريق غير محدودين، تطبيق تجريبي، مشاريع غير محدودة، 5,000 لقطة/شهر.
* [preflight.com](https://preflight.com) - اختبار ويب تلقائي بدون كود. سجل اختبارات في المتصفح تتحمل تغيرات الواجهة وشغلها على أجهزة Windows. هل يمكنك التكامل مع CI/CD الخاص بك؟ الخطة المجانية تشمل 50 اختبار شهريًا مع فيديو، جلسات HTML، والمزيد.
* [qase.io](https://qase.io) - نظام إدارة الاختبار لفرق التطوير وضمان الجودة. إدارة حالات الاختبار، تنفيذ الاختبارات، تتبع العيوب، وقياس الأثر. المستوى المجاني يشمل جميع الميزات الأساسية، مع 500 ميجابايت للمرفقات وحتى 3 مستخدمين.
* [Repeato](https://repeato.app/) أداة أتمتة اختبارات تطبيقات الموبايل بدون كود مبنية على الرؤية الحاسوبية والذكاء الاصطناعي. تعمل مع التطبيقات الأصلية، فلاتر، رياكت-نيتف، الويب، أيونيك، والعديد من أطر العمل. الخطة المجانية محدودة بـ 10 اختبارات لـ iOS و 10 لـ Android، لكنها تشمل معظم ميزات الخطط المدفوعة، بما في ذلك تشغيل اختبارات غير محدود.
* [Requestly](https://requestly.com/) إضافة كروم مفتوحة المصدر لاعتراض، وإعادة توجيه، ومحاكاة طلبات HTTP. تشمل [المصحح](https://requestly.com/products/web-debugger/)، [خادم المحاكاة](https://requestly.com/products/mock-server/)، [عميل API](https://requestly.com/products/api-client/) و[تسجيل الجلسة](https://requestly.com/products/session-book/). إعادة توجيه الروابط، تعديل رؤوس HTTP، محاكاة APIs، حقن كود JS مخصص، تعديل طلبات GraphQL، إنشاء نقاط نهاية API وهمية، تسجيل الجلسة مع سجلات الشبكة والكونسول. إنشاء حتى 10 قواعد في المستوى المجاني. مجاني للمشاريع مفتوحة المصدر.
* [seotest.me](https://seotest.me/) — أداة مجانية لاختبار SEO على الصفحة. 10 عمليات زحف مجانية يوميًا. موارد تعلم SEO واقتراحات لتحسين نتائج SEO لأي موقع بغض النظر عن التقنية.
* [snippets.uilicious.com](https://snippets.uilicious.com) - مثل CodePen لكن لاختبار المتصفحات المتعددة. UI-licious يتيح كتابة اختبارات كقصص مستخدم ويوفر منصة مجانية - UI-licious Snippets - تتيح تشغيل اختبارات غير محدودة على كروم بدون تسجيل حتى 3 دقائق لكل اختبار. وجدت خطأ؟ يمكنك نسخ الرابط الفريد لاختبارك لعرضه على المطورين لإعادة إنتاج الخطأ.
* [TestCollab](https://testcollab.com) - برنامج إدارة اختبارات سهل الاستخدام، خطته المجانية تشمل تكامل Jira، مشاريع غير محدودة، استيراد حالات الاختبار عبر CSV/XLSx، تتبع الوقت، و1 جيجابايت تخزين ملفات.
* [testingbot.com](https://testingbot.com/) — اختبار متصفح وأجهزة Selenium، [مجاني للمشاريع مفتوحة المصدر](https://testingbot.com/open-source)
* [Testspace.com](https://testspace.com/) - لوحة معلومات لنشر نتائج الاختبارات المؤتمتة وإطار عمل لتنفيذ الاختبارات اليدوية ككود باستخدام GitHub. الخدمة [مجانية للمشاريع مفتوحة المصدر](https://github.com/marketplace/testspace-com) وتدعم 450 نتيجة شهريًا.
* [tesults.com](https://www.tesults.com) — تقارير نتائج الاختبارات وإدارة حالات الاختبار. يتكامل مع أطر الاختبار المشهورة. مطورو البرامج مفتوحة المصدر والأفراد والمعلمون والفرق الصغيرة يمكنهم طلب عروض مجانية ومخفضة إلى جانب المشاريع المجانية الأساسية.
* [UseWebhook.com](https://usewebhook.com) - التقط وتحقق من الويب هوكس من متصفحك. إعادة التوجيه إلى localhost أو إعادة التشغيل من السجل. مجاني للاستخدام.
* [Vaadin](https://vaadin.com) — بناء واجهات مستخدم قابلة للتوسع باستخدام Java أو TypeScript، واستخدام الأدوات المدمجة والمكونات ونظام التصميم لتسريع التكرار وتحسين التصميم وتبسيط التطوير. مشاريع غير محدودة مع خمس سنوات من الصيانة المجانية.
* [websitepulse.com](https://www.websitepulse.com/tools/) — أدوات مجانية متنوعة للشبكة والخوادم.
* [webhook-test.com](https://webhook-test.com) - تصحيح وتحليل الويب هوكس وطلبات HTTP برابط فريد أثناء التكامل. مجاني تمامًا، يمكنك إنشاء روابط غير محدودة وتلقي توصيات.
* [webhook.site](https://webhook.site) - تحقق من الويب هوكس أو طلبات HTTP الصادرة أو رسائل البريد الإلكتروني باستخدام رابط مخصص. رابط مؤقت وعنوان بريد إلكتروني مجاني دائمًا.
* [webhookbeam.com](https://webhookbeam.com) - إعداد الويب هوكس ومراقبتها عبر إشعارات الدفع والبريد الإلكتروني.

**[⬆️ العودة إلى الأعلى](#table-of-contents)**

## الأمن والبنية التحتية للمفاتيح العامة (PKI)

* [aikido.dev](https://www.aikido.dev) — منصة أمن تطبيقات شاملة تغطي SCA، SAST، CSPM، DAST، الأسرار، IaC، البرمجيات الخبيثة، فحص الحاويات، انتهاء الدعم... الخطة المجانية تشمل مستخدمين اثنين، فحص 10 مستودعات، 1 سحابة، 2 حاوية و1 نطاق.
* [alienvault.com](https://www.alienvault.com/open-threat-exchange/reputation-monitor) — يكشف الأنظمة المخترقة في شبكتك
* [Altcha.org](https://altcha.org/anti-spam) - مرشح رسائل مزعجة للمواقع وواجهات برمجة التطبيقات مدعوم بمعالجة اللغة الطبيعية وتعلم الآلة. الخطة المجانية تشمل 200 طلب يوميًا لكل نطاق.
* [atomist.com](https://atomist.com/) — طريقة أسرع وأكثر ملاءمة لأتمتة المهام التطويرية المختلفة. الآن في مرحلة البيتا.
* [cloudsploit.com](https://cloudsploit.com/) — تدقيق ومراقبة الأمان والامتثال لخدمات Amazon Web Services (AWS)
* [Public Cloud Threat Intelligence](https://cloudintel.himanshuanand.com/) — مؤشرات ثقة عالية للاختراق تستهدف بنية السحابة العامة، جزء منها متوفر على github (https://github.com/unknownhad/AWSAttacks). القائمة الكاملة متاحة عبر API
* [CodeNotary.io](https://www.codenotary.io/) — منصة مفتوحة المصدر لإثبات غير قابل للتغيير لتوثيق الكود أو الملفات أو المجلدات أو الحاويات
* [crypteron.com](https://www.crypteron.com/) — منصة أمان صديقة للمطورين قائمة على السحابة تمنع تسرب البيانات في تطبيقات .NET و Java
* [CyberChef](https://gchq.github.io/CyberChef/) — تطبيق ويب بسيط وبديهي لتحليل البيانات وترميزها/فك ترميزها دون التعامل مع أدوات أو لغات برمجة معقدة. كأداة الجيش السويسري للتشفير. كل الميزات مجانية بدون حدود. مفتوح المصدر إذا أردت استضافته ذاتيًا.
* [DAS](https://signup.styra.com/) — Styra DAS Free، إدارة دورة حياة كاملة لإنشاء ونشر وإدارة سياسات OPA (Open Policy Agent)
* [Datree](https://www.datree.io/) — أداة CLI مفتوحة المصدر لمنع أخطاء تكوين Kubernetes والتأكد من أن الملفات التعريفية و Helm charts تتبع أفضل الممارسات وسياسات مؤسستك.
* [Dependabot](https://dependabot.com/) تحديث تلقائي للاعتمادات لـ Ruby و JavaScript و Python و PHP و Elixir و Rust و Java (Maven و Gradle) و .NET و Go و Elm و Docker و Terraform و Git Submodules و GitHub Actions.
* [DJ Checkup](https://djcheckup.com) — افحص موقع Django الخاص بك للثغرات الأمنية باستخدام هذه الأداة المجانية المؤتمتة. مستوحاة من موقع Pony Checkup.
* [Doppler](https://doppler.com/) — مدير أسرار عالمي لتخزين أسرار التطبيق والإعدادات، مع دعم للمزامنة مع مزودي السحابة المختلفين. مجاني حتى 5 مستخدمين مع تحكم أساسي بالوصول.
* [Dotenv](https://dotenv.org/) — مزامنة ملفات .env بسرعة وأمان. توقف عن مشاركة ملفات .env عبر قنوات غير آمنة مثل Slack والبريد الإلكتروني، ولا تفقد ملف .env مهم مرة أخرى. مجاني حتى 3 أعضاء في الفريق.
* [GitGuardian](https://www.gitguardian.com) — حافظ على سرية الأكواد مع كشف تلقائي للأسرار والمعالجة. افحص مستودعات git لأكثر من 350 نوعًا من الأسرار والملفات الحساسة – مجاني للأفراد والفرق حتى 25 مطورًا.
* [Have I been pwned?](https://haveibeenpwned.com) — REST API لجلب معلومات عن التسريبات.
* [hostedscan.com](https://hostedscan.com) — ماسح ثغرات عبر الإنترنت لتطبيقات الويب والخوادم والشبكات. عشرة عمليات فحص مجانية شهريًا.
* [Infisical](https://infisical.com/) — منصة مفتوحة المصدر لإدارة أسرار المطورين عبر الفريق والبنية التحتية: من التطوير المحلي إلى بيئة الإنتاج وخدمات الطرف الثالث. مجاني حتى 5 مطورين.
* [Internet.nl](https://internet.nl) — اختبار معايير الإنترنت الحديثة مثل IPv6 و DNSSEC و HTTPS و DMARC و STARTTLS و DANE
* [keychest.net](https://keychest.net) - إدارة صلاحية شهادات SSL وشراء الشهادات مع قاعدة بيانات CT مدمجة
* [letsencrypt.org](https://letsencrypt.org/) — سلطة شهادات SSL مجانية مع شهادات موثوقة من جميع المتصفحات الرئيسية
* [meterian.io](https://www.meterian.io/) - راقب مشاريع Java و Javascript و .NET و Scala و Ruby و NodeJS لرصد الثغرات الأمنية في الاعتمادات. مجاني لمشروع خاص واحد، مشاريع غير محدودة مفتوحة المصدر.
* [Mozilla Observatory](https://observatory.mozilla.org/) — اكتشف وأصلح ثغرات الأمان في موقعك.
* [opswat.com](https://www.opswat.com/) — مراقبة أمان الحواسيب والأجهزة والتطبيقات والإعدادات، مجاني حتى 25 مستخدم و 30 يومًا من سجل المستخدمين.
* [openapi.security](https://openapi.security/) - أداة مجانية لفحص أمان أي API مبنية على OpenAPI / Swagger بسرعة. لا تحتاج إلى تسجيل.
* [pixee.ai](https://pixee.ai) - مهندس أمان منتج تلقائي كبوت GitHub مجاني يقدم PRs تلقائية لكود Java لإصلاح الثغرات تلقائيًا. لغات أخرى قريبًا!
* [pyup.io](https://pyup.io) — راقب اعتمادات Python للثغرات الأمنية وحدثها تلقائيًا. مجاني لمشروع خاص واحد، مشاريع غير محدودة مفتوحة المصدر.
* [qualys.com](https://www.qualys.com/community-edition) — اكتشف ثغرات تطبيقات الويب، وافحص أخطار OWASP
* [report-uri.io](https://report-uri.io/) — تقارير انتهاكات CSP و HPKP
* [ringcaptcha.com](https://ringcaptcha.com/) — أدوات لاستخدام رقم الهاتف كهُوية، متاحة مجانًا
* [seclookup.com](https://www.seclookup.com/) - APIs يمكنها إثراء مؤشرات تهديد النطاقات في SIEM، وتوفير معلومات شاملة عن أسماء النطاقات، وتحسين كشف التهديدات والاستجابة. احصل على 50,000 بحث مجاني [هنا](https://account.seclookup.com/).
* [snyk.io](https://snyk.io) — اكتشف وأصلح الثغرات الأمنية المعروفة في الاعتمادات مفتوحة المصدر. اختبارات وحلول غير محدودة للمشاريع مفتوحة المصدر. محدود بـ 200 اختبار/شهر للمشاريع الخاصة.
* [ssllabs.com](https://www.ssllabs.com/ssltest/) — تحليل مكثف لإعداد أي خادم ويب SSL
* [SOOS](https://soos.io) - عمليات فحص SCA مجانية وغير محدودة للمشاريع مفتوحة المصدر. اكتشف وأصلح التهديدات الأمنية قبل النشر. احمِ مشاريعك بحل بسيط وفعال.
* [StackHawk](https://www.stackhawk.com/) أتمتة فحص التطبيقات عبر كامل خط الإنتاج لاكتشاف وإصلاح ثغرات الأمان قبل الإنتاج. فحوصات وبيئات غير محدودة لتطبيق واحد.
* [Sucuri SiteCheck](https://sitecheck.sucuri.net) - فحص مجاني لأمان المواقع وفاحص برمجيات خبيثة
* [Protectumus](https://protectumus.com) - فحص مجاني لأمان المواقع، مضاد فيروسات للمواقع، وجدار حماية للخوادم (WAF) لـ PHP. إشعارات بريدية للمستخدمين المسجلين في المستوى المجاني.
* [TestTLS.com](https://testtls.com) - اختبار خدمة SSL/TLS لإعداد الخادم الآمن، والشهادات، والسلاسل، وغير ذلك. لا يقتصر على HTTPS.
* [threatconnect.com](https://threatconnect.com) — استخبارات تهديدات: مصمم للباحثين الأفراد والمحللين والمنظمات التي تبدأ في تعلم استخبارات التهديدات الإلكترونية. مجاني حتى 3 مستخدمين
* [tinfoilsecurity.com](https://www.tinfoilsecurity.com/) — فحص تلقائي للثغرات. الخطة المجانية تسمح بفحص XSS أسبوعيًا
* [Ubiq Security](https://ubiqsecurity.com/) — تشفير وفك تشفير البيانات بثلاثة أسطر برمجية وإدارة مفاتيح تلقائية. مجاني لتطبيق واحد وحتى 1,000,000 عملية تشفير شهريًا.
* [Virgil Security](https://virgilsecurity.com/) — أدوات وخدمات لتطبيق التشفير من النهاية للنهاية، حماية قواعد البيانات، أمان إنترنت الأشياء، والمزيد في حلولك الرقمية. مجاني للتطبيقات حتى 250 مستخدمًا.
* [Vulert](https://vulert.com) - يرصد Vulert اعتماداتك مفتوحة المصدر باستمرار لأي ثغرات جديدة، ويوصي بالحلول دون الحاجة للتثبيت أو الوصول إلى الكود. مجاني للمشاريع مفتوحة المصدر.
* [Escape GraphQL Quickscan](https://escape.tech/) - فحص أمان بنقرة واحدة لنقاط نهاية GraphQL الخاصة بك. مجاني، لا يحتاج تسجيل دخول.
* [HasMySecretLeaked](https://gitguardian.com/hasmysecretleaked) - ابحث عبر 20 مليون سر مكشوف في مستودعات GitHub العامة، gist، القضايا، والتعليقات مجانًا.
* [Project Gatekeeper](https://gatekeeper.binarybiology.top/) - مجموعة أدوات SSL الكل في واحد توفر ميزات مثل توليد مفاتيح خاصة و CSR، فك تشفير شهادات SSL، مطابقة الشهادات وطلب شهادة SSL. نوفر للمستخدمين إمكانية توليد شهادات SSL مجانية من Let's Encrypt و Google Trust و BuyPass باستخدام سجلات CNAME بدلاً من سجلات TXT.
**[⬆️ العودة إلى الأعلى](#table-of-contents)**

## المصادقة، التفويض، وإدارة المستخدمين

  * [Aserto](https://www.aserto.com) - خدمة تفويض دقيقة للتطبيقات وواجهات برمجة التطبيقات. مجاني حتى 1000 مستخدم نشط شهريًا و100 مثيل Authorizer.
  * [asgardeo.io](https://wso2.com/asgardeo) - تكامل سلس لتسجيل الدخول الأحادي، المصادقة متعددة العوامل، المصادقة بدون كلمة مرور والمزيد. يشمل SDKs لتطبيقات الواجهة الأمامية والخلفية. مجاني حتى 1000 مستخدم نشط شهريًا وخمسة مزودي هوية.
  * [Auth0](https://auth0.com/) — تسجيل دخول أحادي مستضاف. الخطة المجانية تشمل 25,000 مستخدم نشط شهريًا، اتصالات اجتماعية غير محدودة، نطاق مخصص، والمزيد.
  * [Authgear](https://www.authgear.com) - اجلب المصادقة بدون كلمة مرور، رموز OTPs، المصادقة الثنائية، وتسجيل الدخول الأحادي لتطبيقاتك في دقائق. كل الواجهات الأمامية مشمولة. مجاني حتى 5000 مستخدم نشط شهريًا.
  * [Authress](https://authress.io/) — تسجيل الدخول والتحكم في الوصول مع عدد غير محدود من مزودي الهوية لأي مشروع. فيسبوك، جوجل، تويتر والمزيد. أول 1000 طلب API مجانية.
  * [Authy](https://authy.com) - مصادقة ثنائية (2FA) على عدة أجهزة مع نسخ احتياطية. بديل مباشر لـ Google Authenticator. مجاني حتى 100 عملية مصادقة ناجحة.
  * [Cerbos Hub](https://www.cerbos.dev/product-cerbos-hub) - نظام إدارة تفويض متكامل لتأليف واختبار ونشر سياسات الوصول. تفويض وتحكم دقيق بالوصول، مجاني حتى 100 هوية نشطة شهريًا.
  * [Clerk](https://clerk.com) — إدارة المستخدمين، المصادقة، 2FA/MFA، مكونات واجهة مستخدم جاهزة لتسجيل الدخول، التسجيل، ملفات تعريف المستخدمين والمزيد. مجاني حتى 10,000 مستخدم نشط شهريًا.
  * [Cloud-IAM](https://www.cloud-iam.com/) — إدارة الهوية والوصول Keycloak كخدمة. مجاني حتى 100 مستخدم وRealm واحد.
  * [Corbado](https://www.corbado.com/) — أضف مصادقة Passkey أولاً إلى التطبيقات الجديدة أو الحالية. مجاني لعدد غير محدود من المستخدمين النشطين شهريًا.
  * [Descope](https://www.descope.com/) — تدفقات مصادقة (AuthN) قابلة للتخصيص بدرجة عالية، يدعم النهج بدون كود وAPI/SDK، مجاني لـ 7,500 مستخدم نشط شهريًا، 50 مستأجر (حتى 5 مستأجرين SAML/SSO).
  * [duo.com](https://duo.com/) — مصادقة ثنائية لموقع أو تطبيق. مجاني لعشرة مستخدمين، جميع طرق المصادقة، تكاملات غير محدودة، رموز أجهزة.
  * [Kinde](https://kinde.com/) - مصادقة بسيطة وقوية يمكنك دمجها مع منتجك خلال دقائق. كل ما تحتاجه للبدء مع 7,500 مستخدم نشط شهريًا مجانًا.
  * [logintc.com](https://www.logintc.com/) — مصادقة ثنائية عبر إشعارات الدفع، مجاني لعشرة مستخدمين، VPN، مواقع الويب وSSH.
  * [MojoAuth](https://mojoauth.com/) - يسهل تطبيق المصادقة بدون كلمة مرور على الويب أو الجوال أو أي تطبيق في دقائق.
  * [Okta](https://developer.okta.com/signup/) — إدارة المستخدمين، المصادقة والتفويض. مجاني حتى 100 مستخدم نشط شهريًا.
  * [onelogin.com](https://www.onelogin.com/) — الهوية كخدمة (IDaaS)، مزود تسجيل دخول أحادي، ثلاثة تطبيقات شركة، وخمسة تطبيقات شخصية، مستخدمون غير محدودين.
  * [Ory](https://ory.sh/) - منصة أمان مُدارة AuthN/AuthZ/OAuth2.0/Zero Trust. حسابات مطورين مجانية دائمًا مع كل ميزات الأمان، أعضاء فريق غير محدودين، 200 مستخدم نشط يوميًا، و25 ألف فحص صلاحيات شهريًا.
  * [Permit.io](https://permit.io) - منصة التفويض كخدمة تتيح RBAC, ABAC, وReBAC لخدمات مصغرة قابلة للتوسع مع تحديثات فورية وواجهة سياسات بدون كود. شريحة مجانية لـ 1000 مستخدم نشط شهريًا.
  * [Phase Two](https://phasetwo.io) - إدارة الهوية والوصول مفتوحة المصدر Keycloak. Realm مجاني حتى 1000 مستخدم، حتى 10 اتصالات SSO، باستخدام حاوية Keycloak المحسنة مع إضافة [المنظمات](https://phasetwo.io/product/organizations/).
  * [SSOJet](https://ssojet.com/) - أضف تسجيل دخول مؤسسي SSO بدون إعادة بناء نظام المصادقة. الخطة المجانية تشمل مستخدمين نشطين شهريًا غير محدودين، منظمات غير محدودة، 2 اتصال SSO و2 اتصال SCIM.
  * [Stytch](https://www.stytch.com/) - منصة شاملة تقدم APIs وSDKs للمصادقة ومنع الاحتيال. الخطة المجانية تشمل 10,000 مستخدم نشط شهريًا، منظمات غير محدودة، 5 اتصالات SSO أو SCIM، و1,000 رمز M2M.
  * [Stack Auth](https://stack-auth.com) — مصادقة مفتوحة المصدر سهلة للمطورين. الحل الأكثر ملاءمة للمطورين، يبدأ خلال خمس دقائق فقط. قابل للاستضافة الذاتية مجانًا، أو نسخة SaaS مُدارة مع 10 آلاف مستخدم نشط شهريًا مجانًا.
  * [SuperTokens](https://supertokens.com/) - مصادقة مستخدمين مفتوحة المصدر متكاملة مع تطبيقك – للبدء بسرعة مع التحكم في تجربة المستخدم والمطور. مجاني حتى 5000 مستخدم نشط شهريًا.
  * [Warrant](https://warrant.dev/) — خدمة تفويض وتحكم في الوصول من فئة المؤسسات لتطبيقاتك. الشريحة المجانية تشمل مليون طلب API شهريًا و1000 قاعدة تفويض.
  * [ZITADEL Cloud](https://zitadel.com) — نظام جاهز لإدارة المستخدمين والوصول يدعم حالات الاستخدام متعددة المستأجرين (B2B). مجاني حتى 25,000 طلب مصادقة مع جميع ميزات الأمان (دون حواجز دفع لـ OTP، بدون كلمة مرور، السياسات، إلخ).
  * [PropelAuth](https://propelauth.com) — بيع للشركات من أي حجم فورًا مع بضع أسطر كود فقط، مجاني حتى 200 مستخدم و10 آلاف بريد إلكتروني للمعاملات (مع علامة مائية: "مشغل بواسطة PropelAuth").
  * [Logto](https://logto.io/) - تطوير وتأمين وإدارة هويات المستخدمين – لكل من المصادقة والتفويض. مجاني حتى 5,000 مستخدم نشط شهريًا مع خيار مفتوح المصدر للاستضافة الذاتية.
  * [WorkOS](https://workos.com/) - إدارة المستخدمين والمصادقة مجانًا حتى مليون مستخدم نشط شهريًا. يدعم البريد الإلكتروني + كلمة المرور، المصادقة الاجتماعية، Magic Auth، المصادقة متعددة العوامل، والمزيد.


**[⬆️ العودة إلى الأعلى](#table-of-contents)**

## توزيع تطبيقات الجوال والتغذية الراجعة

  * [TestApp.io](https://testapp.io) - منصتك الأساسية لضمان عمل تطبيقات الجوال بالشكل المطلوب. الخطة المجانية: تطبيق واحد، تحليلات، إصدارات وتنصيبات غير محدودة، وجمع الملاحظات.
  * [Loadly](https://loadly.io) - خدمة توزيع تطبيقات iOS وAndroid التجريبية مجانية بالكامل مع تنزيلات غير محدودة، تنزيلات عالية السرعة، ورفع غير محدود.
  * [Diawi](https://www.diawi.com) - نشر تطبيقات iOS وAndroid مباشرة للأجهزة. الخطة المجانية: رفع التطبيقات، روابط محمية بكلمة مرور، انتهاء صلاحية ليوم واحد، عشر تنصيبات.
  * [InstallOnAir](https://www.installonair.com) - توزيع تطبيقات iOS وAndroid عبر الهواء. الخطة المجانية: رفع غير محدود، روابط خاصة، انتهاء صلاحية ليومين للضيوف، 60 يومًا للمستخدمين المسجلين.
  * [GetUpdraft](https://www.getupdraft.com) - توزيع تطبيقات الجوال للاختبار. الخطة المجانية تشمل مشروع تطبيق واحد، ثلاثة إصدارات، 500 ميجابايت تخزين، و100 تثبيت شهريًا.
  * [Appho.st](https://appho.st) - منصة استضافة تطبيقات الجوال. الخطة المجانية تشمل خمسة تطبيقات، 50 تنزيل شهريًا، وحجم ملف أقصى 100 ميجابايت.

**[⬆️ العودة إلى الأعلى](#table-of-contents)**

## نظام الإدارة

  * [bitnami.com](https://bitnami.com/) — نشر تطبيقات جاهزة على IaaS. إدارة مثيل AWS صغير واحد مجانًا
  * [Esper](https://esper.io) — إدارة أجهزة وتطبيقات Android مع DevOps. 100 جهاز مجاني مع رخصة مستخدم واحدة و25 ميجابايت تخزين تطبيقات.
  * [jamf.com](https://www.jamf.com/) — إدارة الأجهزة لـ iPad وiPhone وMac، ثلاثة أجهزة مجانًا
  * [Miradore](https://miradore.com) — خدمة إدارة الأجهزة. متابعة تحديث أسطول الأجهزة وتأمين عدد غير محدود من الأجهزة مجانًا. الخطة المجانية توفر ميزات أساسية.
  * [moss.sh](https://moss.sh) - يساعد المطورين على نشر وإدارة تطبيقات الويب والخوادم. مجاني حتى 25 نشر Git شهريًا.
  * [runcloud.io](https://runcloud.io/) - إدارة الخوادم مع تركيز رئيسي على مشاريع PHP. مجاني حتى خادم واحد.
  * [ploi.io](https://ploi.io/) - أداة إدارة خوادم لتسهيل إدارة ونشر الخوادم والمواقع. مجاني لخادم واحد.
  * [xcloud.host](https://xcloud.host) — منصة إدارة ونشر الخوادم بواجهة سهلة الاستخدام. شريحة مجانية متاحة لخادم واحد.
  * [serveravatar.com](https://serveravatar.com) — إدارة ومراقبة خوادم الويب المبنية على PHP مع إعدادات تلقائية. مجاني لخادم واحد.

**[⬆️ العودة إلى الأعلى](#table-of-contents)**

## المراسلة والبث

  * [Ably](https://www.ably.com/) - خدمة مراسلة فورية مع الحضور، الاستمرارية والتسليم المضمون. الخطة المجانية تشمل 3 ملايين رسالة شهريًا، 100 اتصال ذروة، و100 قناة ذروة.
  * [cloudamqp.com](https://www.cloudamqp.com/) — RabbitMQ كخدمة. خطة Little Lemur: حتى مليون رسالة شهريًا، 20 اتصال متزامن، 100 طابور، 10,000 رسالة في الانتظار، عقد متعددة في مناطق توافر مختلفة.
  * [courier.com](https://www.courier.com/) — واجهة API واحدة للإشعارات الفورية، البريد الإلكتروني، الدردشة، الرسائل النصية وغيرها مع إدارة القوالب وميزات أخرى. الخطة المجانية تشمل 10,000 رسالة شهريًا.
  * [engagespot.co](https://engagespot.co/) — بنية إشعارات متعددة القنوات للمطورين مع صندوق وارد مدمج ومحرر قوالب بدون كود. الخطة المجانية تشمل 10,000 رسالة شهريًا.
  * [HiveMQ](https://www.hivemq.com/mqtt-cloud-broker/) - وصل أجهزة MQTT الخاصة بك إلى وسيط رسائل IoT سحابي. مجاني حتى 100 جهاز للأبد (بدون بطاقة ائتمان).
  * [knock.app](https://knock.app) – بنية إشعارات للمطورين. إرسال لقنوات متعددة مثل داخل التطبيق، البريد الإلكتروني، SMS، Slack، ودفع الإشعارات من خلال مكالمة API واحدة. الخطة المجانية تشمل 10,000 رسالة شهريًا.
  * [NotificationAPI.com](https://www.notificationapi.com/) — أضف إشعارات للمستخدمين لأي برنامج خلال 5 دقائق. الخطة المجانية تشمل 10,000 إشعار شهريًا + 100 رسالة SMS ومكالمات تلقائية.
  * [Novu.co](https://novu.co) — بنية إشعارات مفتوحة المصدر للمطورين. مكونات وAPIs بسيطة لإدارة كل قنوات التواصل من مكان واحد: بريد إلكتروني، SMS، مباشر، داخل التطبيق ودفع الإشعارات. الخطة المجانية تشمل 30,000 إشعار شهريًا مع احتفاظ 90 يومًا.
  * [pusher.com](https://pusher.com/) — خدمة مراسلة فورية. مجاني حتى 100 اتصال متزامن و200,000 رسالة يوميًا.
  * [scaledrone.com](https://www.scaledrone.com/) — خدمة مراسلة فورية. مجاني حتى 20 اتصال متزامن و100,000 حدث يوميًا.
  * [synadia.com](https://synadia.com/ngs) — [NATS.io](https://nats.io) كخدمة. عالمي، AWS، GCP وAzure. مجاني للأبد مع حجم رسالة 4k، 50 اتصال نشط، و5 جيجابايت بيانات شهريًا.
  * [pubnub.com](https://www.pubnub.com/) - مراسلة Swift, Kotlin, وReact مع مليون معاملة شهريًا. المعاملة قد تحتوي على عدة رسائل.
  * [eyeson API](https://developers.eyeson.team/) - خدمة API للاتصال المرئي تعتمد على WebRTC (SFU, MCU) لبناء منصات الفيديو. تدعم حقن بيانات فورية، تخطيطات فيديو، تسجيلات، واجهة ويب مستضافة كاملة (بدء سريع) أو حزم لواجهات مخصصة. شريحة مجانية للمطورين مع 1000 دقيقة اجتماع شهريًا.
  * [webpushr](https://www.webpushr.com/) - إشعارات ويب Push – مجاني حتى 10 آلاف مشترك، إشعارات دفع غير محدودة، مراسلة داخل المتصفح.
  * [httpSMS](https://httpsms.com) - إرسال واستقبال الرسائل النصية باستخدام هاتفك الأندرويد كبوابة SMS. مجاني لإرسال واستقبال حتى 200 رسالة شهريًا.
  * [EMQX Serverless](https://www.emqx.com/en/cloud/serverless-mqtt) - وسيط MQTT بدون خادم آمن وقابل للتوسع تحصل عليه في ثوان. مليون دقيقة جلسة شهريًا مجانًا للأبد (بدون بطاقة ائتمان).
  * [Pocket Alert](https://pocketalert.app) - إرسال إشعارات دفع لأجهزة iOS وAndroid الخاصة بك. تكامل سهل عبر API أو Webhooks وتحكم كامل في التنبيهات. الخطة المجانية: 50 رسالة يوميًا لجهاز واحد وتطبيق واحد.
  * [SuprSend](https://www.suprsend.com/) - بنية إشعارات تسهل إشعارات منتجك بمنهجية API أولاً. أنشئ وقدم إشعارات المعاملات، المجدولة، والتفاعل عبر قنوات متعددة مع API واحد. الخطة المجانية تشمل 10,000 إشعار شهريًا، مع عقد سير عمل متنوعة مثل الملخصات، الدُفعات، القنوات المتعددة، التفضيلات، المستأجرين، البث والمزيد.

**[⬆️ العودة إلى الأعلى](#table-of-contents)**

## إدارة السجلات

  * [bugfender.com](https://bugfender.com/) — مجاني حتى 100 ألف سطر سجل يوميًا مع احتفاظ 24 ساعة
  * [logentries.com](https://logentries.com/) — مجاني حتى 5 جيجابايت شهريًا مع احتفاظ 7 أيام
  * [loggly.com](https://www.loggly.com/) — مجاني لمستخدم واحد، 200 ميجابايت يوميًا مع احتفاظ 7 أيام
  * [logz.io](https://logz.io/) — مجاني حتى 1 جيجابايت يوميًا، احتفاظ ليوم واحد
  * [ManageEngine Log360 Cloud](https://www.manageengine.com/cloud-siem/) — خدمة إدارة السجلات من Manage Engine. الخطة المجانية تقدم 50 جيجابايت تخزين مع 15 يوم احتفاظ و7 أيام بحث.
  * [papertrailapp.com](https://papertrailapp.com/) — بحث لمدة 48 ساعة، أرشيف 7 أيام، 50 ميجابايت شهريًا
  * [sematext.com](https://sematext.com/logsene) — مجاني حتى 500 ميجابايت يوميًا، احتفاظ 7 أيام
  * [sumologic.com](https://www.sumologic.com/) — مجاني حتى 500 ميجابايت يوميًا، احتفاظ 7 أيام
  * [logflare.app](https://logflare.app/) — مجاني حتى 12,960,000 إدخال لكل تطبيق شهريًا، احتفاظ 3 أيام
  * [logtail.com](https://logtail.com/) — إدارة سجلات متوافقة مع SQL قائمة على ClickHouse. مجاني حتى 1 جيجابايت شهريًا، احتفاظ 3 أيام.
  * [logzab.com](https://logzab.com/) — نظام إدارة سجلات التدقيق. مجاني لـ 1,000 سجل نشاط مستخدم شهريًا، احتفاظ شهر، حتى 5 مشاريع.
  * [openobserve.ai](https://openobserve.ai/) - 200 جيجابايت استيعاب شهريًا مجانًا، احتفاظ 15 يوم
**[⬆️ العودة إلى الأعلى](#table-of-contents)**

## إدارة الترجمة

  * [crowdin.com](https://crowdin.com/) — مشاريع غير محدودة، سلاسل نصية غير محدودة، ومتعاونون غير محدودين لمشاريع المصادر المفتوحة
  * [gitlocalize.com](https://gitlocalize.com) - مجاني وغير محدود للمستودعات الخاصة والعامة
  * [Lecto](https://lecto.ai/) - واجهة برمجة تطبيقات للترجمة الآلية مع باقة مجانية (30 طلب مجاني، 1000 حرف مترجم لكل طلب). متكامل مع إضافة Loco Translate لووردبريس.
  * [lingohub.com](https://lingohub.com/) — مجاني حتى 3 مستخدمين، ودائمًا مجاني لمشاريع المصادر المفتوحة
  * [localazy.com](https://localazy.com) - مجاني حتى 1000 سلسلة لغة مصدر، لغات غير محدودة، مساهمون غير محدودين، عروض للشركات الناشئة والمصادر المفتوحة
  * [Localeum](https://localeum.com) - مجاني حتى 1000 سلسلة، مستخدم واحد، لغات غير محدودة، مشاريع غير محدودة
  * [localizely.com](https://localizely.com/) — مجاني لمشاريع المصادر المفتوحة
  * [Loco](https://localise.biz/) — مجاني حتى 2000 ترجمة، مترجمون غير محدودين، عشر لغات/لكل مشروع، 1000 أصل قابل للترجمة/لكل مشروع
  * [oneskyapp.com](https://www.oneskyapp.com/) — نسخة مجانية محدودة حتى 5 مستخدمين، مجاني لمشاريع المصادر المفتوحة
  * [POEditor](https://poeditor.com/) — مجاني حتى 1000 سلسلة
  * [SimpleLocalize](https://simplelocalize.io/) - مجاني حتى 100 مفتاح ترجمة، سلاسل غير محدودة، لغات غير محدودة، عروض للشركات الناشئة
  * [Texterify](https://texterify.com/) - مجاني لمستخدم واحد فقط
  * [Tolgee](https://tolgee.io) - عرض SaaS مجاني مع ترجمات محدودة، ونسخة ذاتية الاستضافة مجانية دائمًا
  * [transifex.com](https://www.transifex.com/) — مجاني لمشاريع المصادر المفتوحة
  * [Translation.io](https://translation.io) - مجاني لمشاريع المصادر المفتوحة
  * [Translized](https://translized.com) - مجاني حتى 1000 سلسلة، مستخدم واحد، لغات غير محدودة، مشاريع غير محدودة
  * [webtranslateit.com](https://webtranslateit.com/) — مجاني حتى 500 سلسلة
  * [weblate.org](https://weblate.org/) — مجاني لمشاريع البرمجيات الحرة حتى 10,000 مصدر سلسلة في الباقة المجانية ونسخة غير محدودة للاستضافة الذاتية.
  * [Free PO editor](https://pofile.net/free-po-editor) — مجاني للجميع
  * [Lingo.dev](https://lingo.dev) – أداة CLI مفتوحة المصدر مدعومة بالذكاء الاصطناعي لتوطين الويب والجوال. يمكنك استخدام نموذج اللغة الخاص بك، أو الحصول على 10,000 كلمة مجانية شهريًا عبر محرك التوطين المدار من Lingo.dev.

**[⬆️ العودة إلى الأعلى](#table-of-contents)**

## المراقبة

  * [UptimeObserver.com](https://uptimeobserver.com) - احصل على 20 مراقب جاهزية بفواصل 5 دقائق وصفحة حالة قابلة للتخصيص – حتى للاستخدام التجاري. استمتع بإشعارات غير محدودة وفورية عبر البريد الإلكتروني وتيليجرام. لا حاجة لبطاقة ائتمان للبدء.
  * [Pingmeter.com](https://pingmeter.com/) - 5 مراقبي جاهزية بفاصل 10 دقائق. راقب SSH، HTTP، HTTPS، وأي منافذ TCP مخصصة.
  * [alerty.ai](https://www.alerty.ai) - مراقبة وأتمتة الأداء المجانية للواجهة الأمامية والخلفية وقواعد البيانات والمزيد + تشغيل وكيل مجاني.
  * [appdynamics.com](https://www.appdynamics.com/) — مجاني لمقاييس 24 ساعة، وعملاء إدارة أداء التطبيقات محدودين بواحد لكل من Java و .NET و PHP و Node.js
  * [appneta.com](https://www.appneta.com/) — مجاني مع احتفاظ بالبيانات لمدة ساعة واحدة
  * [appspector.com](https://appspector.com/) - التحكم الكامل في تصحيح أخطاء iOS/Android/Flutter عن بُعد. مجاني للاستخدام منخفض الحركة (64 ميجابايت من السجلات).
  * [assertible.com](https://assertible.com) — اختبار ومراقبة تلقائية لواجهات برمجة التطبيقات. خطط مجانية للفرق والأفراد.
  * [bleemeo.com](https://bleemeo.com) - مجاني لثلاثة خوادم، 5 مراقبي جاهزية، مستخدمين غير محدودين، لوحات تحكم غير محدودة، قواعد تنبيه غير محدودة.
  * [Core Web Vitals History](https://punits.dev/core-web-vitals-historical/) - اعثر على سجل Core Web Vitals لعنوان URL أو موقع ويب.
  * [checklyhq.com](https://checklyhq.com) - مراقبة E2E / اصطناعية مفتوحة المصدر ومراقبة API معمقة للمطورين. خطة مجانية لمستخدم واحد و10,000 عملية تحقق API & شبكة / 1,500 عملية تحقق متصفح.
  * [cloudsploit.com](https://cloudsploit.com) — مراقبة أمان AWS وتكوينها. مجاني: عمليات فحص عند الطلب غير محدودة، مستخدمين غير محدودين، حسابات مخزنة غير محدودة. اشتراك: فحص تلقائي، وصول API، إلخ.
  * [cronitor.io](https://cronitor.io/) - رؤى أداء ومراقبة جاهزية لمهام cron والمواقع وواجهات برمجة التطبيقات والمزيد. باقة مجانية بخمسة مراقبين.
  * [datadoghq.com](https://www.datadoghq.com/) — مجاني حتى 5 عقد
  * [deadmanssnitch.com](https://deadmanssnitch.com/) — مراقبة لمهام cron. مراقب واحد مجاني (snitch)، المزيد عند دعوة آخرين للتسجيل
  * [downtimemonkey.com](https://downtimemonkey.com/) — 60 مراقب جاهزية، بفاصل 5 دقائق. تنبيهات عبر البريد الإلكتروني وSlack.
  * [economize.cloud](https://economize.cloud) — تساعد Economize في توضيح تكاليف بنية السحابة عن طريق تنظيم الموارد السحابية لتحسينها والتقرير عنها. مجاني حتى 5,000 دولار إنفاق شهري على Google Cloud Platform.
  * [elastic.co](https://www.elastic.co/solutions/apm) — رؤى أداء فورية لمطوري جافاسكريبت. مجاني باحتفاظ بيانات 24 ساعة
  * [fivenines.io](https://fivenines.io/) — مراقبة خوادم Linux مع لوحات تحكم وتنبيهات في الوقت الفعلي — مجاني للأبد حتى 5 خوادم مراقبة بفاصل 60 ثانية. لا حاجة لبطاقة ائتمان.
  * [Grafana Cloud](https://grafana.com/products/cloud/) - منصة مراقبة متكاملة تجمع بين المقاييس والسجلات مع Grafana. مجاني: 3 مستخدمين، 10 لوحات تحكم، 100 تنبيه، تخزين مقاييس في Prometheus وGraphite (10,000 سلسلة، احتفاظ 14 يوم)، تخزين سجلات في Loki (50 جيجابايت سجلات، احتفاظ 14 يوم)
  * [healthchecks.io](https://healthchecks.io) — راقب مهام cron والمهام الخلفية. مجاني حتى 20 تحقق.
  * [Hydrozen.io](https://hydrozen.io) — مراقبة جاهزية وصفحات حالة، الخطة المجانية: 10 مراقبي جاهزية، 5 مراقبي heartbeat، مراقب نطاق واحد وصفحة حالة واحدة مجانية.
  * [incidenthub.cloud](https://incidenthub.cloud/) — مجمع صفحات حالة السحابة وSaaS - 20 مراقب وقناتي إشعارات (Slack وDiscord) مجانيين للأبد.
  * [inspector.dev](https://www.inspector.dev) - لوحة مراقبة متكاملة في الوقت الفعلي في أقل من دقيقة مع باقة مجانية دائمة.
  * [instrumentalapp.com](https://instrumentalapp.com) - مراقبة التطبيقات والخوادم بشكل جميل وسهل الاستخدام حتى 500 مقياس و3 ساعات من الرؤية المجانية للبيانات
  * [keychest.net/speedtest](https://keychest.net/speedtest) - اختبار سرعة مستقل واختبار تأخير المصافحة TLS ضد Digital Ocean
  * [letsmonitor.org](https://letsmonitor.org) - مراقبة SSL، مجانية حتى 5 مراقبين
  * [linkok.com](https://linkok.com) - أداة لفحص الروابط المعطلة على الإنترنت، مجانية للمواقع الصغيرة حتى 100 صفحة، مجانية بالكامل لمشاريع المصادر المفتوحة.
  * [loader.io](https://loader.io/) — أدوات اختبار تحميل مجانية مع بعض القيود
  * [MonitorMonk](https://monitormonk.com) - مراقبة جاهزية بسيطة مع صفحات حالة جميلة. خطة Forever Free تقدم مراقبة HTTPS وكلمة مفتاحية وSSL وزمن الاستجابة حتى 10 مواقع أو نقاط نهاية API، وتوفر 2 لوحة تحكم/صفحة حالة.
  * [netdata.cloud](https://www.netdata.cloud/) — أداة مفتوحة المصدر لجمع المقاييس في الوقت الفعلي. منتج في تطور مستمر ويمكن العثور عليه أيضًا على GitHub!
  * [newrelic.com](https://www.newrelic.com) — منصة مراقبة New Relic لمساعدة المهندسين على بناء برامج مثالية. من الأنظمة الأحادية إلى الخوادم بدون خادم، يمكنك مراقبة كل شيء ثم تحليل المشكلات وتحسين النظام بالكامل. الباقة المجانية تقدم 100GB/شهر من البيانات، مستخدم وصول كامل مجاني واحد، ومستخدمين أساسيين غير محدودين مجانًا.
  * [Middleware.io](https://middleware.io/) - منصة مراقبة توفر رؤية كاملة لتطبيقاتك وبنيتك، حتى تتمكن من مراقبة المشاكل وتشخيصها على نطاق واسع. لديهم خطة مجانية دائمة لمجتمع المطورين تشمل مراقبة السجلات حتى مليون حدث، مراقبة البنية التحتية وAPM حتى مضيفين.
  * [nixstats.com](https://nixstats.com) - مجاني لخادم واحد. تنبيهات البريد الإلكتروني، صفحة حالة عامة، فاصل 60 ثانية، والمزيد.
  * [OnlineOrNot.com](https://onlineornot.com/) - توفر OnlineOrNot مراقبة جاهزية للمواقع وواجهات برمجة التطبيقات، ومراقبة لمهام cron والمهام المجدولة. توفر أيضًا صفحات حالة. أول خمسة تحقق بفاصل 3 دقائق مجانًا. الباقة المجانية ترسل تنبيهات عبر Slack وDiscord والبريد الإلكتروني.
  * [OntarioNet.ca CN Test](https://cntest.ontarionet.ca) — تحقق مما إذا كان موقع ويب محجوبًا في الصين بواسطة جدار الحماية العظيم. يحدد تلوث DNS بمقارنة نتائج DNS ومعلومات ASN المكتشفة من خوادم في الصين مقابل خوادم في الولايات المتحدة.
  * [opsgenie.com](https://www.opsgenie.com/) — تنبيه قوي وإدارة مناوبات للخدمات المستمرة. مجاني حتى 5 مستخدمين.
  * [paessler.com](https://www.paessler.com/) — حل مراقبة بنية تحتية وشبكات قوي، يشمل التنبيهات، إمكانيات تصور قوية، وتقارير أساسية. مجاني حتى 100 حساس.
  * [pagecrawl.io](https://pagecrawl.io/) -  مراقبة تغييرات المواقع، مجاني حتى 6 مراقبين بفحوصات يومية.
  * [syagent.com](https://syagent.com/) — خدمة مراقبة خوادم مجانية للاستخدام غير التجاري، تنبيهات ومقاييس.
  * [pagerly.io](https://pagerly.io/) -  إدارة المناوبات على Slack (يتكامل مع Pagerduty وOpsGenie). مجاني حتى فريق واحد (فريق واحد يعني مناوبة واحدة)
  * [pagertree.com](https://pagertree.com/) - واجهة بسيطة للتنبيهات وإدارة المناوبات. مجاني حتى 5 مستخدمين.
  * [phare.io](https://phare.io/) - مراقبة جاهزية مجانية حتى 100,000 حدث لمشاريع غير محدودة وصفحات حالة غير محدودة.
  * [pingbreak.com](https://pingbreak.com/) — خدمة مراقبة جاهزية حديثة. تحقق من عدد غير محدود من عناوين URL واحصل على إشعارات التوقف عبر Discord أو Slack أو البريد الإلكتروني.
  * [pingpong.one](https://pingpong.one/) — منصة صفحات حالة متقدمة مع مراقبة. الباقة المجانية تتضمن صفحة حالة عامة قابلة للتخصيص مع نطاق فرعي SSL. خطة Pro متاحة مجانًا لمشاريع المصادر المفتوحة والمنظمات غير الربحية.
  * [robusta.dev](https://home.robusta.dev/) — مراقبة Kubernetes قوية مبنية على Prometheus. يمكنك استخدام Prometheus الخاص بك أو تثبيت الحزمة الكاملة. الباقة المجانية تشمل حتى 20 عقدة Kubernetes. تنبيهات عبر Slack وMicrosoft Teams وDiscord والمزيد. تكامل مع PagerDuty وOpsGenie وVictorOps وDataDog والعديد من الأدوات الأخرى.
  * [sematext.com](https://sematext.com/) — مجاني لمقاييس 24 ساعة، خوادم غير محدودة، عشرة مقاييس مخصصة، 500,000 نقطة بيانات مخصصة، لوحات تحكم ومستخدمين غير محدودين، إلخ.
  * [sitemonki.com](https://sitemonki.com/) — مراقبة موقع، نطاق، Cron وSSL، 5 مراقبين في كل فئة مجانًا
  * [sitesure.net](https://sitesure.net) - مراقبة موقع وكرون - 2 مراقب مجاني
  * [skylight.io](https://www.skylight.io/) — مجاني لأول 100,000 طلب (Rails فقط)
  * [speedchecker.xyz](https://probeapi.speedchecker.xyz/) — واجهة برمجة تطبيقات لمراقبة الأداء، تفحص Ping وDNS وغيرها.
  * [stathat.com](https://www.stathat.com/) — ابدأ بعشرة إحصائيات مجانًا، بدون انتهاء صلاحية
  * [statuscake.com](https://www.statuscake.com/) — مراقبة مواقع، اختبارات غير محدودة مجانًا مع بعض القيود
  * [statusgator.com](https://statusgator.com/) — مراقبة صفحات الحالة، 3 مراقبين مجانًا
  * [SweetUptime](https://dicloud.net/sweetuptime-server-uptime-monitoring/) — مراقبة خوادم، مراقبة جاهزية، مراقبة DNS ونطاقات. راقب 10 خوادم و10 جاهزية و10 نطاقات مجانًا.
  * [thousandeyes.com](https://www.thousandeyes.com/) — مراقبة الشبكة وتجربة المستخدم. 3 مواقع و20 تدفق بيانات لخدمات الويب الرئيسية مجانًا
  * [uptimetoolbox.com](https://uptimetoolbox.com/) — مراقبة مجانية لخمسة مواقع، بفاصل 60 ثانية، وصفحة حالة عامة.
  * [zenduty.com](https://www.zenduty.com/) — منصة إدارة الحوادث من البداية للنهاية، تنبيهات، إدارة مناوبات، وتنظيم الاستجابة لفرق عمليات الشبكة وهندسة الموثوقية وDevOps. مجاني حتى 5 مستخدمين.
  * [instatus.com](https://instatus.com) - احصل على صفحة حالة جميلة في 10 ثوان. مجاني للأبد مع عدد غير محدود من المشتركين والفرق.
  * [Squadcast.com](https://squadcast.com) - Squadcast هو برنامج إدارة حوادث متكامل مصمم لمساعدتك على تطبيق أفضل ممارسات SRE. خطة مجانية للأبد حتى 10 مستخدمين.
  * [RoboMiri.com](https://robomiri.com/) - RoboMiri هو مراقب جاهزية مستقر يوفر مجموعة واسعة من المراقبين: cronjob، كلمة مفتاحية، موقع، منفذ، ping. خمسة وعشرون تحقق جاهزية بفاصل 3 دقائق مجانًا. تنبيهات عبر مكالمة هاتفية، رسالة نصية، بريد إلكتروني، وWebhooks.
  * [Better Stack](https://betterstack.com/better-uptime) - مراقبة الجاهزية، إدارة الحوادث، جدولة/تنبيه المناوبات، وصفحات الحالة في منتج واحد. الخطة المجانية تشمل عشرة مراقبين بفاصل تحقق 3 دقائق وصفحات حالة.
  * [Pulsetic](https://pulsetic.com) - 10 مراقبين، 6 أشهر من سجلات الجاهزية، صفحات حالة غير محدودة، ونطاقات مخصصة! مجانًا إلى أجل غير مسمى وتنبيهات بريد إلكتروني غير محدودة. لا تحتاج بطاقة ائتمان.
  * [Wachete](https://www.wachete.com) - راقب خمس صفحات، بفحص كل 24 ساعة.
  * [Xitoring.com](https://xitoring.com/) — مراقبة جاهزية: 20 مجاني، مراقبة خوادم Linux وWindows: 5 مجاني، صفحة حالة: 1 مجاني - تطبيق جوال، قنوات تنبيه متعددة، وأكثر بكثير!
  * [Servervana](https://servervana.com) - مراقبة جاهزية متقدمة بدعم للمشاريع والفرق الكبيرة. يوفر مراقبة HTTP، مراقبة مستندة للمتصفح، مراقبة DNS، مراقبة نطاقات، صفحات حالة والمزيد. الباقة المجانية تشمل 10 مراقبين HTTP، 1 مراقب DNS، وصفحة حالة واحدة.

**[⬆️ العودة إلى الأعلى](#table-of-contents)**

## معالجة الأعطال والاستثناءات
  * [CatchJS.com](https://catchjs.com/) - تتبع أخطاء JavaScript مع لقطات شاشة ومسارات النقرات. مجاني للمشاريع مفتوحة المصدر.
  * [bugsnag.com](https://www.bugsnag.com/) — مجاني حتى 2,000 خطأ/شهريًا بعد الفترة التجريبية الأولى
  * [elmah.io](https://elmah.io/) — تسجيل الأخطاء ومراقبة الجاهزية لمطوري الويب. اشتراك Small Business مجاني للمشاريع مفتوحة المصدر.
  * [Embrace](https://embrace.io/) — مراقبة تطبيقات الهواتف المحمولة. مجاني للفرق الصغيرة بعدد يصل إلى مليون جلسة مستخدم في السنة.
  * [exceptionless](https://exceptionless.com) — تقارير الأخطاء والميزات والسجلات في الوقت الفعلي وأكثر. مجاني حتى 3 آلاف حدث شهريًا/مستخدم واحد. مفتوح المصدر وسهل الاستضافة الذاتية للاستخدام غير المحدود.
  * [GlitchTip](https://glitchtip.com/) — تتبع أخطاء بسيط ومفتوح المصدر. متوافق مع Sentry SDKs مفتوحة المصدر. 1000 حدث شهريًا مجانًا، أو يمكن استضافته ذاتيًا بلا حدود.
  * [honeybadger.io](https://www.honeybadger.io) - تتبع الاستثناءات والجاهزية والمهام المجدولة. مجاني للفرق الصغيرة والمشاريع مفتوحة المصدر (12,000 خطأ/شهريًا).
  * [memfault.com](https://memfault.com) — منصة مراقبة الأجهزة السحابية وتصحيح الأخطاء. 100 جهاز مجاني لأجهزة [Nordic](https://app.memfault.com/register-nordic)، [NXP](https://app.memfault.com/register-nxp)، و [Laird](https://app.memfault.com/register-laird).
  * [rollbar.com](https://rollbar.com/) — مراقبة الاستثناءات والأخطاء، خطة مجانية مع 5,000 خطأ/شهريًا، مستخدمون غير محدودين، احتفاظ لمدة 30 يومًا
  * [sentry.io](https://sentry.io/) — يقوم Sentry بتتبع استثناءات التطبيقات في الوقت الفعلي ويقدم خطة مجانية صغيرة. مجاني حتى 5 آلاف خطأ شهريًا/مستخدم واحد، استخدام غير مقيد في حال الاستضافة الذاتية
  * [Axiom](https://axiom.co/) — تخزين حتى 0.5 تيرابايت من السجلات مع احتفاظ لمدة 30 يومًا. يشمل تكاملات مع منصات مثل Vercel واستعلام بيانات متقدم مع إشعارات البريد الإلكتروني/Discord.
  * [Semaphr](https://semaphr.com) — مفتاح قتل شامل ومجاني تمامًا لتطبيقاتك على الجوال.
  * [Jam](https://jam.dev) - تقارير أعطال صديقة للمطورين بنقرة واحدة. خطة مجانية مع عدد غير محدود من التقارير.
  * [Whitespace](https://whitespace.dev) – تقارير أعطال بنقرة واحدة مباشرة من متصفحك. خطة مجانية مع تسجيلات غير محدودة للاستخدام الشخصي.

**[⬆️ العودة إلى الأعلى](#table-of-contents)**

## البحث

  * [algolia.com](https://www.algolia.com/) — حل بحث مستضاف مع تصحيح الأخطاء الإملائية، والملاءمة، ومكتبات واجهة المستخدم لإنشاء تجارب بحث بسهولة. خطة "Build" المجانية تشمل مليون مستند و10 آلاف عملية بحث شهريًا. كما يقدم [بحث الوثائق للمطورين](https://docsearch.algolia.com/) مجانًا.
  * [bonsai.io](https://bonsai.io/) — 1 جيجابايت ذاكرة و1 جيجابايت تخزين مجانًا
  * [CommandBar](https://www.commandbar.com/) - شريط بحث موحد كخدمة، أداة/إضافة واجهة مستخدم ويب تسمح لمستخدميك بالبحث في المحتوى والتنقلات والميزات داخل منتجك، مما يساعد على الاكتشاف. مجاني حتى 1,000 مستخدم نشط شهريًا، أوامر غير محدودة.
  * [Orama Cloud](https://orama.com/pricing) — 3 فهارس مجانية، 100 ألف مستند/فهرس، عمليات بحث نصية/متجهية/هجينة غير محدودة، تحليلات لمدة 60 يومًا
  * [searchly.com](http://www.searchly.com/) — فهرسان مجانيان و20 ميجابايت تخزين
  * [easysitesearch.com](https://easysitesearch.com/) — أداة بحث وواجهة برمجة تطبيقات، مع فهرسة تلقائية معتمدة على زاحف الويب. عمليات بحث غير محدودة مجانًا حتى 50 صفحة فرعية.

**[⬆️ العودة إلى الأعلى](#table-of-contents)**

## التعليم وتطوير المهارات المهنية

  * [FreeCodeCamp](https://www.freecodecamp.org/) - منصة مفتوحة المصدر تقدم دورات وشهادات مجانية في تحليل البيانات، أمن المعلومات، تطوير الويب، وأكثر.
  * [The Odin Project](https://www.theodinproject.com/) - منصة مجانية مفتوحة المصدر بمنهج يركز على JavaScript وRuby لتطوير الويب.
  * [Free Professional Resume Templates & Editor](https://www.overleaf.com/latex/templates/tagged/cv) - منصة مجانية مع العديد من قوالب السير الذاتية للمهنيين ذوي الخبرة، جاهزة للاستنساخ والتعديل الكامل والتنزيل، محسنة لأنظمة ATS.
  * [DeepLearning.AI Short Courses](https://www.deeplearning.ai/short-courses/) - دورات قصيرة مجانية من خبراء الصناعة للحصول على خبرة عملية في أحدث أدوات وتقنيات الذكاء الاصطناعي التوليدي في ساعة أو أقل.
  * [LabEx](https://labex.io) - تطوير المهارات في Linux، DevOps، الأمن السيبراني، البرمجة، علم البيانات، وغير ذلك من خلال مختبرات تفاعلية ومشاريع واقعية.
  * [Roadmap.sh](https://roadmap.sh) - خرائط تعلم مجانية تغطي جميع جوانب التطوير من البلوك تشين إلى تصميم تجربة المستخدم.
  * [Cisco Networking Academy, Skills for All](https://skillsforall.com/) - يقدم دورات مجانية معتمدة في مواضيع مثل الأمن السيبراني، الشبكات، وPython.
  * [MIT OpenCourseWare](https://ocw.mit.edu/) - MIT OpenCourseWare هو منشور إلكتروني لمواد أكثر من 2,500 دورة في معهد MIT، يشارك المعرفة بحرية مع المتعلمين والمعلمين حول العالم. قناة يوتيوب متاحة على [@mitocw](https://www.youtube.com/@mitocw/featured)
  * [W3Schools](https://www.w3schools.com/) - يقدم دروسًا مجانية حول تقنيات تطوير الويب مثل HTML، CSS، JavaScript، وأكثر.
  * [Khan Academy](https://www.khanacademy.org/computing/computer-programming) - أدلة مجانية عبر الإنترنت لتعلم أساسيات وتقدم HTML/CSS، JavaScript وSQL.
  * [Full Stack Open](https://fullstackopen.com/en/) – دورة جامعية مجانية حول تطوير الويب الحديث باستخدام React، Node.js، GraphQL، TypeScript، وأكثر. بالكامل على الإنترنت وبالوتيرة الذاتية.
  * [edX](https://www.edx.org/) - يوفر الوصول إلى أكثر من 4,000 دورة مجانية عبر الإنترنت من 250 مؤسسة رائدة، بما في ذلك Harvard وMIT، متخصص في علوم الحاسب والهندسة وعلوم البيانات.
  * [Django-tutorial.dev](https://django-tutorial.dev) - أدلة مجانية عبر الإنترنت لتعلم Django كإطارهم الأول ويوفر رابط خلفي مجاني لمقالات المستخدمين.

**[⬆️ العودة إلى الأعلى](#table-of-contents)**

## البريد الإلكتروني

  * [10minutemail](https://10minutemail.com) - بريد إلكتروني مؤقت مجاني للاختبار.
  * [AhaSend](https://ahasend.com) - خدمة بريد إلكتروني معاملات، مجانية حتى 1000 رسالة شهريًا، مع عدد غير محدود من النطاقات، وأعضاء الفريق، وwebhooks ومسارات الرسائل في الخطة المجانية.
  * [AnonAddy](https://anonaddy.com) - إعادة توجيه بريد إلكتروني مجهول مفتوح المصدر، أنشئ عددًا غير محدود من الأسماء المستعارة مجانًا
  * [Antideo](https://www.antideo.com/) — 10 طلبات API في الساعة للتحقق من البريد الإلكتروني، والتحقق من IP، وأرقام الهواتف في الفئة المجانية. لا حاجة لبطاقة ائتمان.
  * [Brevo](https://www.brevo.com/) — 9,000 رسالة بريد إلكتروني/شهريًا، 300 رسالة/يوم مجانًا
  * [OneSignal](https://onesignal.com/) — 10,000 رسالة بريد إلكتروني/شهريًا، لا حاجة لبطاقة ائتمان.
  * [Bump](https://bump.email/) - 10 عناوين بريد Bump مجانية، نطاق مخصص واحد
  * [Burnermail](https://burnermail.io/) – 5 عناوين بريد مؤقت مجانية، صندوق بريد واحد، تاريخ صندوق البريد 7 أيام
  * [Buttondown](https://buttondown.email/) — خدمة نشرات بريدية. حتى 100 مشترك مجانًا
  * [CloudMailin](https://www.cloudmailin.com/) - بريد وارد عبر HTTP POST وصادر معاملات - 10,000 رسالة مجانية/شهريًا
  * [Contact.do](https://contact.do/) — نموذج اتصال في رابط (bitly لنماذج الاتصال)
  * [debugmail.io](https://debugmail.io/) — خادم بريد للاختبار سهل الاستخدام للمطورين
  * [DNSExit](https://dnsexit.com/) - حتى عنواني بريد إلكتروني تحت نطاقك مجانًا مع 100 ميجابايت مساحة تخزين. يدعم IMAP، POP3، SMTP، SPF/DKIM.
  * [EmailLabs.io](https://emaillabs.io/en) — أرسل حتى 9,000 رسالة بريد إلكتروني مجانًا كل شهر، حتى 300 رسالة يوميًا.
  * [EmailOctopus](https://emailoctopus.com) - حتى 2,500 مشترك و10,000 رسالة بريد إلكتروني شهريًا مجانًا
  * [EmailJS](https://www.emailjs.com/) – هذا ليس خادم بريد إلكتروني كامل؛ بل عميل بريد إلكتروني لإرسال الرسائل مباشرة من العميل دون كشف بيانات الاعتماد، الفئة المجانية بها 200 طلب شهريًا، 2 قالب بريد إلكتروني، طلبات حتى 50 كيلوبايت، سجل جهات اتصال محدود.
  * [EtherealMail](https://ethereal.email) - Ethereal خدمة SMTP وهمية، موجهة بشكل أساسي لمستخدمي Nodemailer وEmailEngine (ولكن ليست حصرية لهم). خدمة بريد إلكتروني مضادة للمعاملات ومجانية بالكامل حيث لا يتم تسليم الرسائل فعليًا.
  * [Temp-Mail.org](https://temp-mail.org/en/) - بريد مؤقت/مهمل باستخدام مجموعة كبيرة من النطاقات. يتغير عنوان البريد في كل مرة تعيد فيها تحميل الصفحة. مجاني بالكامل ولا توجد أسعار للخدمات.
  * [TempMailDetector.com](https://tempmaildetector.com/) - تحقق من حتى 200 بريد إلكتروني شهريًا مجانًا لمعرفة ما إذا كان البريد مؤقتًا أم لا.
  * [Emailvalidation.io](https://emailvalidation.io) - 100 تحقق بريد إلكتروني مجاني شهريًا
  * [FakeMailGenerator.com](https://www.fakemailgenerator.com/) - منشئ بريد إلكتروني مؤقت/مهمل ألماني. يدعم 10 نطاقات، مع إمكانية إنشاء عناوين غير محدودة. (يحتوي على إعلانات) لكن غير ذلك، الخدمة مجانية تمامًا.
  * [forwardemail.net](https://forwardemail.net) — إعادة توجيه بريد إلكتروني مجاني للنطاقات المخصصة. أنشئ وأعد توجيه عدد غير محدود من العناوين باسم نطاقك (**ملاحظة**: يجب الدفع إذا استخدمت .casa، .cf، .click، .email، .fit، .ga، .gdn، .gq، .lat، .loan، .london، .men، .ml، .pl، .rest، .ru، .tk، .top، .work نظرًا للبريد المزعج)
  * [Imitate Email](https://imitate.email) - خادم بريد إلكتروني تجريبي لاختبار وظائف البريد خلال مراحل التطوير/ضمان الجودة وCI/CD. الحسابات المجانية تحصل على 15 رسالة يوميًا للأبد.
  * [ImprovMX](https://improvmx.com) – إعادة توجيه بريد إلكتروني مجاني.
  * [EForw](https://www.eforw.com) – إعادة توجيه بريد إلكتروني مجاني لنطاق واحد. استقبل وأرسل الرسائل من نطاقك.
  * [Inboxes App](https://inboxesapp.com) — أنشئ حتى 3 عناوين بريد مؤقتة يوميًا، ثم احذفها بعد الانتهاء من خلال إضافة Chrome ملائمة. مثالي لاختبار تدفق التسجيل.
  * [inboxkitten.com](https://inboxkitten.com/) - صندوق بريد إلكتروني مؤقت/مهمل مجاني، مع حذف تلقائي بعد 3 أيام. مفتوح المصدر ويمكن استضافته ذاتيًا.
  * [mail-tester.com](https://www.mail-tester.com) — اختبر إعدادات DNS/SPF/DKIM/DMARC للبريد الإلكتروني، 20 اختبار مجاني شهريًا.
  * [dkimvalidator.com](https://dkimvalidator.com/) - اختبر إعدادات DNS/SPF/DKIM/DMARC للبريد الإلكتروني، خدمة مجانية من roundsphere.com
  * [mailcatcher.me](https://mailcatcher.me/) — يلتقط البريد ويعرضه من خلال واجهة ويب.
  * [mailchannels.com](https://www.mailchannels.com) - واجهة برمجة تطبيقات للبريد الإلكتروني مع تكاملات REST API وSMTP، مجاني حتى 3,000 رسالة بريد إلكتروني/شهريًا.
  * [Mailcheck.ai](https://www.mailcheck.ai/) - منع المستخدمين من التسجيل بعناوين بريد مؤقتة، 120 طلب/ساعة (~86,400 شهريًا)
  * [Mailchimp](https://mailchimp.com/) — 500 مشترك و1,000 رسالة بريد إلكتروني/شهريًا مجانًا.
  * [Maildroppa](https://maildroppa.com) - حتى 100 مشترك وعدد غير محدود من الرسائل الآلية مجانًا.
  * [MailerLite.com](https://www.mailerlite.com) — 1,000 مشترك/شهريًا، 12,000 رسالة بريد إلكتروني/شهريًا مجانًا
  * [MailerSend.com](https://www.mailersend.com) — واجهة برمجة تطبيقات للبريد الإلكتروني، SMTP، 3,000 رسالة بريد إلكتروني/شهريًا مجانًا للبريد المعاملاتي
  * [mailinator.com](https://www.mailinator.com/) — نظام بريد إلكتروني عام ومجاني يمكنك استخدام أي صندوق وارد تريده
  * [Mailjet](https://www.mailjet.com/) — 6,000 رسالة بريد إلكتروني/شهريًا مجانًا (حد إرسال 200 رسالة يوميًا)
  * [Mailnesia](https://mailnesia.com) - بريد إلكتروني مؤقت/مهمل مجاني، مع زيارة تلقائية لروابط التسجيل.
  * [mailsac.com](https://mailsac.com) - واجهة API مجانية لاختبار البريد المؤقت، استضافة بريد عامة مجانية، التقاط البريد الصادر، بريد إلى slack/websocket/webhook (حد 1,500 طلب API شهريًا)
  * [Mailtrap.io](https://mailtrap.io/) — خادم SMTP وهمي للتطوير، خطة مجانية مع صندوق وارد واحد، 100 رسالة، بدون أعضاء فريق، رسالتان في الثانية، بدون قواعد إعادة توجيه.
  * [Mail7.io](https://www.mail7.io/) — عناوين بريد إلكتروني مؤقتة مجانية لمطوري ضمان الجودة. أنشئ عناوين بريد إلكتروني فورًا عبر الويب أو API.
  * [Momentary Email](https://www.momentaryemail.com/) — عناوين بريد إلكتروني مؤقتة مجانية. اقرأ الرسائل الواردة على الموقع أو عبر موجز RSS.
  * [Mutant Mail](https://www.mutantmail.com/) – 10 معرفات بريد إلكتروني مجانية، 1 نطاق، 1 صندوق وارد. صندوق وارد واحد لجميع المعرفات.
  * [Outlook.com](https://outlook.live.com/owa/) - بريد إلكتروني شخصي مجاني وتقويم.
  * [Parsio.io](https://parsio.io) — محلل بريد إلكتروني مجاني (أعد توجيه البريد، استخرج البيانات، أرسلها إلى خادمك)
  * [pepipost.com](https://pepipost.com) — 30 ألف رسالة بريد إلكتروني مجانًا للشهر الأول، ثم أول 100 رسالة يوميًا مجانًا.
  * [Plunk](https://useplunk.com) - 3 آلاف رسالة بريد إلكتروني/شهريًا مجانًا
  * [Postmark](https://postmarkapp.com/) - 100 رسالة بريد إلكتروني/شهريًا مجانًا، تقارير أسبوعية غير محدودة لـ DMARC.
  * [Proton Mail](https://proton.me/mail) - خدمة بريد إلكتروني آمن مجانية مع تشفير من طرف إلى طرف مدمج. سعة تخزين 1 جيجابايت مجانًا.
  * [Queuemail.dev](https://queuemail.dev) — واجهة برمجة تطبيقات تسليم بريد إلكتروني موثوقة. فئة مجانية (10,000 رسالة بريد إلكتروني/شهريًا). إرسال غير متزامن. استخدم عدة خوادم SMTP. قوائم حظر، تسجيل، تتبع، webhooks، والمزيد.
  * [QuickEmailVerification](https://quickemailverification.com) — تحقق من 100 بريد إلكتروني يوميًا مجانًا في الفئة المجانية إلى جانب واجهات برمجة تطبيقات مجانية أخرى مثل DEA Detector، DNS Lookup، SPF Detector، وأكثر.
  * [Resend](https://resend.com) - واجهة برمجة تطبيقات للبريد الإلكتروني التفاعلي للمطورين. 3,000 رسالة بريد إلكتروني/شهريًا، 100 رسالة بريد إلكتروني/يوميًا مجانًا، نطاق مخصص واحد.
  * [Sender](https://www.sender.net) حتى 15,000 رسالة بريد إلكتروني/شهريًا، حتى 2,500 مشترك.
  * [Sendpulse](https://sendpulse.com) — 500 مشترك/شهريًا، 15,000 رسالة بريد إلكتروني/شهريًا مجانًا.
  * [SimpleLogin](https://simplelogin.io/) – حل مفتوح المصدر وقابل للاستضافة الذاتية لإنشاء وإعادة توجيه عناوين البريد الإلكتروني المستعارة. 5 عناوين مستعارة مجانية، نقل بيانات غير محدود، وإرسال/رد غير محدود. مجاني للكوادر التعليمية (طلاب، باحثين، إلخ).
  * [Substack](https://substack.com) — خدمة نشر نشرات بريدية غير محدودة مجانًا. يبدأ الدفع عندما تبدأ بفرض رسوم عليها.
  * [Sweego](https://www.sweego.io/) - واجهة برمجة تطبيقات أوروبية للبريد الإلكتروني التفاعلي للمطورين. 500 رسالة بريد إلكتروني/يوميًا مجانًا.
  * [Takeout](https://takeout.bysourfruit.com) - خدمة بريد إلكتروني محدثة باستمرار تجعل إرسال الرسائل سهلًا. 500 رسالة بريد إلكتروني تفاعلية/شهريًا مجانًا.
  * [temp-mail.io](https://temp-mail.io) — خدمة بريد إلكتروني مؤقتة مجانية وقابلة للاستخدام المتعدد مع إمكانية إعادة التوجيه.
  * [tinyletter.com](https://tinyletter.com/) — 5,000 مشترك/شهريًا مجانًا.
  * [Touchlead](https://touchlead.app) - أداة أتمتة تسويقية متعددة الاستخدامات، مع إدارة العملاء المحتملين، منشئ النماذج، والأتمتة. مجاني لعدد محدود من العملاء المحتملين وعمليات الأتمتة.
  * [trashmail.com](https://www.trashmail.com) - عناوين بريد إلكتروني مؤقتة مجانية مع إعادة التوجيه وانتهاء صلاحية العنوان تلقائيًا.
  * [Tuta](https://tuta.com/) - خدمة بريد إلكتروني آمنة مجانية مع تشفير مدمج من طرف إلى طرف، بدون إعلانات، وبدون تتبع. 1 جيجابايت تخزين مجاني، تقويم واحد (يتوفر أيضًا [خطة مدفوعة](https://tuta.com/pricing)). Tuta أيضًا [مفتوحة المصدر جزئيًا](https://github.com/tutao/tutanota)، ويمكنك استضافتها ذاتيًا.
  * [Verifalia](https://verifalia.com/email-verification-api) — واجهة برمجة تطبيقات للتحقق من البريد الإلكتروني في الوقت الحقيقي مع تأكيد صندوق البريد وكاشف عناوين البريد المؤقتة؛ 25 تحقق مجاني يوميًا.
  * [verimail.io](https://verimail.io/) — خدمة تحقق بريد إلكتروني مجمعة وعبر API. 100 تحقق مجاني/شهريًا.
  * [Zoho](https://www.zoho.com) — بدأت كمزود بريد إلكتروني وأصبحت تقدم مجموعة من الخدمات، بعضها له خطط مجانية. قائمة الخدمات التي تتوفر فيها خطط مجانية:
     - [Email](https://zoho.com/mail) مجاني لـ 5 مستخدمين. 5 جيجابايت/للمستخدم و25 ميجابايت حد مرفقات، نطاق واحد.
     - [Zoho Assist](https://www.zoho.com/assist) — خطة مجانية دائمة تتضمن ترخيص دعم عن بعد متزامن واحد والوصول إلى 5 تراخيص لأجهزة غير مراقبة لمدة غير محدودة للاستخدام المهني أو الشخصي.
     - [Sprints](https://zoho.com/sprints) مجاني لـ 5 مستخدمين، 5 مشاريع و500 ميجابايت تخزين.
     - [Docs](https://zoho.com/docs) — مجاني لـ 5 مستخدمين مع حد رفع 1 جيجابايت و5 جيجابايت تخزين. تأتي حزمة Zoho Office Suite (Writer, Sheets & Show) مضمّنة.
     - [Projects](https://zoho.com/projects) — مجاني لـ 3 مستخدمين، مشروعين و10 ميجابايت حد مرفقات. نفس الخطة تنطبق على [Bugtracker](https://zoho.com/bugtracker).
     - [Connect](https://zoho.com/connect) — تعاون فرق مجاني لـ 25 مستخدمًا مع ثلاث مجموعات، ثلاث تطبيقات مخصصة، 3 لوحات، 3 أدلة و10 تكاملات بالإضافة إلى القنوات، الفعاليات والمنتديات.
     - [Meeting](https://zoho.com/meeting) — اجتماعات مع حتى 3 مشاركين و10 حضور للويبينار.
     - [Vault](https://zoho.com/vault) — إدارة كلمات المرور متاحة للأفراد.
     - [Showtime](https://zoho.com/showtime) — برنامج اجتماعات آخر للتدريب عن بعد حتى 5 مشاركين.
     - [Notebook](https://zoho.com/notebook) — بديل مجاني لـ Evernote.
     - [Wiki](https://zoho.com/wiki) — مجاني لثلاثة مستخدمين مع 50 ميجابايت تخزين، صفحات غير محدودة، نسخ احتياطي بصيغة zip، تغذية RSS & Atom، تحكم في الوصول، وCSS قابل للتخصيص.
     - [Subscriptions](https://zoho.com/subscriptions) — إدارة الفوترة المتكررة مجانًا لـ 20 عميل/اشتراك ومستخدم واحد مع استضافة جميع المدفوعات من قبل Zoho. يتم تخزين آخر 40 مقياس اشتراك.
     - [Checkout](https://zoho.com/checkout) — إدارة فوترة المنتجات مع 3 صفحات وما يصل إلى 50 دفعة.
     - [Desk](https://zoho.com/desk) — إدارة دعم العملاء مع ثلاثة وكلاء، قاعدة معرفة خاصة، وتذاكر بريد إلكتروني. يتكامل مع [Assist](https://zoho.com/assist) لفني دعم عن بعد واحد و5 أجهزة غير مراقبة.
     - [Cliq](https://zoho.com/cliq) — برنامج دردشة للفرق مع 100 جيجابايت تخزين، مستخدمين غير محدودين، 100 مستخدم لكل قناة ودعم SSO.
     - [Campaigns](https://zoho.com/campaigns) - التسويق عبر البريد الإلكتروني
     - [Forms](https://zoho.com/forms) - منشئ النماذج
     - [Sign](https://zoho.com/sign) - التوقيعات الإلكترونية
     - [Surveys](https://zoho.com/surveys) - الاستبيانات عبر الإنترنت
     - [Bookings](https://zoho.com/bookings) - جدولة المواعيد
  * [Maileroo](https://maileroo.com) - SMTP Relay وواجهة برمجة تطبيقات البريد الإلكتروني للمطورين. 5,000 رسالة بريد إلكتروني شهريًا، نطاقات غير محدودة، تحقق بريد مجاني، مراقبة القائمة السوداء، اختبار البريد الإلكتروني والمزيد.

**[⬆️ العودة إلى الأعلى](#table-of-contents)**

## منصات إدارة مفاتيح الميزات (Feature Toggles Management Platforms)

  * [ConfigCat](https://configcat.com) - ConfigCat هي خدمة علامات الميزات (feature flag) تركز على المطورين مع حجم فريق غير محدود، دعم ممتاز وسعر معقول. خطة مجانية حتى 10 علامات، بيئتين، منتج واحد و5 ملايين طلب شهريًا.
  * [Flagsmith](https://flagsmith.com) - إطلاق الميزات بثقة؛ إدارة علامات الميزات عبر تطبيقات الويب والجوال والسيرفر. استخدم API المستضاف، أو انشر على السحابة الخاصة بك، أو شغلها داخليًا.
  * [GrowthBook](https://growthbook.io) - مزود مفتوح المصدر لعلامات الميزات واختبار A/B مع محرك تحليل إحصائي بايزي مدمج. مجاني حتى 3 مستخدمين، علامات ميزات وتجارب غير محدودة.
  * [Hypertune](https://www.hypertune.com) - علامات ميزات آمنة بالنوع، اختبار A/B، تحليلات وتكوين تطبيق مع تحكم في الإصدارات شبيه بـ Git وتقييم متزامن محلي في الذاكرة. مجاني حتى 5 أعضاء فريق مع علامات ميزات واختبارات A/B غير محدودة.
  * [Molasses](https://www.molasses.app) - علامات ميزات قوية واختبار A/B. مجاني حتى 3 بيئات مع خمس علامات ميزات لكل منها.
  * [Toggled.dev](https://www.toggled.dev) - منصة إدارة مفاتيح ميزات جاهزة للمؤسسات وقابلة للتوسع ومتعددة المناطق. خطة مجانية حتى 10 علامات، بيئتين، طلبات غير محدودة. يتضمن SDK، لوحة تحكم تحليلات، تقويم الإصدارات، إشعارات Slack، وجميع الميزات الأخرى في الخطة المجانية الدائمة.
  * [Statsig](https://www.statsig.com) - منصة قوية لإدارة الميزات، اختبار A/B، التحليلات والمزيد. خطتها المجانية السخية تقدم مقاعد غير محدودة، علامات وتجارب وتكوينات ديناميكية غير محدودة ودعم حتى مليون حدث شهريًا.
  * [Abby](https://www.tryabby.com) - علامات ميزات واختبار A/B مفتوحة المصدر. التكوين ككود وSDKs مكتوبة بالكامل بـ Typescript. تكامل قوي مع أطر العمل مثل Next.js وReact. خطة مجانية سخية وخيارات توسيع رخيصة.

**[⬆️ العودة إلى الأعلى](#table-of-contents)**

## الخطوط

  * [dafont](https://www.dafont.com/) - الخطوط المعروضة في هذا الموقع هي ملك لمؤلفيها وتكون إما مجانية أو تجريبية أو ضمن الملكية العامة أو مشاركة تجارية.
  * [Everything Fonts](https://everythingfonts.com/) - يقدم عدة أدوات؛ @font-face، محول الوحدات، Font Hinter وFont Submitter.
  * [Font Squirrel](https://www.fontsquirrel.com/) - خطوط مجانية مرخصة للاستخدام التجاري. تم اختيار الخطوط يدويًا وتقديمها بطريقة سهلة الاستخدام.
  * [Google Fonts](https://fonts.google.com/) - العديد من الخطوط المجانية سهلة وسريعة التثبيت على موقع الويب عبر التنزيل أو رابط إلى CDN الخاص بجوجل.
  * [FontGet](https://www.fontget.com/) - يحتوي على مجموعة متنوعة من الخطوط المتاحة للتنزيل ومصنفة بشكل منظم باستخدام الوسوم.
  * [Fontshare](https://www.fontshare.com/) - خدمة خطوط مجانية. مجموعة متزايدة من الخطوط الاحترافية، 100٪ مجانية للاستخدام الشخصي والتجاري.
  * [Befonts](https://befonts.com/) - يوفر العديد من الخطوط الفريدة للاستخدام الشخصي أو التجاري.
  * [Font of web](https://fontofweb.com/) - تحديد جميع الخطوط المستخدمة في موقع ويب وكيفية استخدامها.
  * [Bunny](https://fonts.bunny.net) خطوط بديلة لـ Google Fonts مع تركيز على الخصوصية.
  * [FontsKey](https://www.fontskey.com/) - يوفر خطوطًا مجانية ومدفوعة للاستخدام الشخصي ويمكن إدخال نص للتصفية السريعة.
  * [fonts.xz.style](https://fonts.xz.style/) خدمة مجانية ومفتوحة المصدر لتوصيل عائلات الخطوط إلى مواقع الويب باستخدام CSS.
  * [Fontsensei](https://fontsensei.com/) خطوط جوجل مفتوحة المصدر تم وسمها من قبل المستخدمين، مع وسوم خطوط CJK (صينية، يابانية، كورية).

**[⬆️ العودة إلى الأعلى](#table-of-contents)**

## النماذج

  * [Feathery](https://feathery.io) - منشئ نماذج قوي وصديق للمطورين. بناء نماذج تسجيل الدخول والاشتراك، تأهيل المستخدمين، تدفقات الدفع، تطبيقات مالية معقدة وأكثر. الخطة المجانية تسمح حتى 250 إرسال شهريًا وخمسة نماذج نشطة.
  * [Form-Data](https://form-data.com) - خلفية للنماذج بدون كود. مرشح للبريد العشوائي، إشعارات البريد الإلكتروني ورد تلقائي، Webhooks، Zapier، تحويلات، AJAX أو POST، وأكثر. الخطة المجانية تقدم نماذج غير محدودة، 20 إرسال شهريًا، و2000 إرسال إضافي مع شارة Form-Data.
  * [FabForm](https://fabform.io/) - منصة خلفية للنماذج للمطورين الأذكياء. الخطة المجانية تسمح بـ 250 إرسال نموذج شهريًا. واجهة حديثة وسهلة الاستخدام. تكامل مع Google Sheets، Airtable، Slack، البريد الإلكتروني وغيرها.
  * [Form.taxi](https://form.taxi/) — نقطة نهاية لإرسال نماذج HTML. مع الإشعارات، مرشحات البريد العشوائي، ومعالجة بيانات متوافقة مع GDPR. خطة مجانية للاستخدام الأساسي.
  * [Formcarry.com](https://formcarry.com) - نقطة نهاية لنماذج HTTP POST، الخطة المجانية تسمح بـ 100 إرسال شهريًا.
  * [formingo.co](https://www.formingo.co/)- نماذج HTML سهلة للمواقع الثابتة. يمكنك البدء مجانًا بدون تسجيل حساب. الخطة المجانية تسمح بـ 500 إرسال شهريًا وعنوان بريد رد مخصص.
  * [FormKeep.com](https://www.formkeep.com/) - نماذج غير محدودة مع 50 إرسال شهريًا، حماية من البريد العشوائي، إشعارات بريد إلكتروني، ومصمم سحب وإفلات يمكنه تصدير HTML. ميزات إضافية تشمل قواعد حقول مخصصة، فرق، وتكامل مع Google Sheets، Slack، ActiveCampaign، وZapier.
  * [formlets.com](https://formlets.com/) — نماذج عبر الإنترنت، نماذج صفحة واحدة غير محدودة شهريًا، 100 إرسال شهريًا، إشعارات بريد إلكتروني.
  * [formspark.io](https://formspark.io/) - خدمة تحويل النماذج إلى بريد إلكتروني، الخطة المجانية تسمح بنماذج غير محدودة و250 إرسال شهريًا ودعم من فريق خدمة العملاء.
  * [Formspree.io](https://formspree.io/) — إرسال بريد إلكتروني باستخدام طلب HTTP POST. الخطة المجانية محدودة بـ 50 إرسال لكل نموذج شهريًا.
  * [Formsubmit.co](https://formsubmit.co/) — نقاط نهاية سهلة لنماذج HTML الخاصة بك. مجاني للأبد. لا حاجة للتسجيل.
  * [Formlick.com](https://formlick.com) - بديل لـ Typeform مع صفقة مدى الحياة. يمكن للمستخدمين إنشاء نموذج مجاني واحد واستقبال إرساليات غير محدودة. في النسخة المدفوعة، يمكن إنشاء نماذج غير محدودة وإرسالات غير محدودة.
  * [getform.io](https://getform.io/) - منصة خلفية للنماذج للمصممين والمطورين، نموذج واحد، 50 إرسال، تحميل ملف واحد، 100 ميجابايت تخزين ملفات.
  * [HeroTofu.com](https://herotofu.com/) - خلفية للنماذج مع اكتشاف البوتات وأرشيف مشفر. إعادة توجيه الإرساليات عبر واجهة المستخدم إلى البريد الإلكتروني أو Slack أو Zapier. استخدم واجهتك الخاصة، لا حاجة لكود خادمي. الخطة المجانية تمنحك نماذج غير محدودة و100 إرسال شهريًا.
  * [HeyForm.net](https://heyform.net/) - منشئ نماذج عبر السحب والإفلات. الخطة المجانية تتيح لك إنشاء نماذج غير محدودة وجمع إرساليات غير محدودة. يأتي مع قوالب جاهزة، مكافحة البريد العشوائي و100 ميجابايت تخزين ملفات.
  * [Tally.so](https://tally.so/) - 99% من الميزات مجانية. الخطة المجانية تتيح: نماذج غير محدودة، إرساليات غير محدودة، إشعارات بريد إلكتروني، منطق النماذج، جمع المدفوعات، تحميل الملفات، صفحة شكر مخصصة والمزيد.
  * [Hyperforms.app](https://hyperforms.app/) — أنشئ نموذجًا للبريد الإلكتروني وأكثر في ثوانٍ وبدون كود خلفي. الحساب الشخصي يمنحك حتى 50 إرسال شهريًا مجانًا.
  * [Kwes.io](https://kwes.io/) - نقطة نهاية للنماذج غنية بالميزات. تعمل بشكل ممتاز مع المواقع الثابتة. الخطة المجانية تشمل حتى موقع واحد مع 50 إرسال شهريًا.
  * [Pageclip](https://pageclip.co/) - الخطة المجانية تسمح بموقع واحد، نموذج واحد و1,000 إرسال شهريًا.
  * [Qualtrics Survey](https://qualtrics.com/free-account) — أنشئ نماذج واستبيانات احترافية باستخدام هذه الأداة المتميزة. أكثر من 50 قالب استبيان من تصميم الخبراء. الحساب المجاني محدود باستبيان نشط واحد، 100 رد لكل استبيان و8 أنواع من الردود.
  * [Screeb](https://screeb.app/) - استبيانات داخل التطبيق وتحليلات المنتج لفهم سلوك المستخدم. خطة مجانية للأبد تتيح 500 مستخدم نشط شهريًا، ردود وفعاليات غير محدودة، العديد من التكاملات، تصدير، وتقارير دورية.
  * [smartforms.dev](https://smartforms.dev/) - خلفية قوية وسهلة للنماذج لموقعك الإلكتروني، خطة مجانية للأبد تتيح 50 إرسال شهريًا، 250 ميجابايت تخزين ملفات، تكامل مع Zapier، تصدير CSV/JSON، إعادة توجيه مخصصة، صفحة رد مخصصة، بوت Telegram وSlack، إشعارات بريد إلكتروني فردية.
  * [Survicate](https://survicate.com/) — جمع الملاحظات من جميع المصادر وإرسال استبيانات متابعة بأداة واحدة. تحليل تلقائي للملاحظات واستخلاص الرؤى بالذكاء الاصطناعي. استبيانات عبر البريد الإلكتروني، الموقع، داخل المنتج أو على الجوال مجانًا، منشئ استبيانات بالذكاء الاصطناعي، و25 رد شهريًا.
  * [staticforms.xyz](https://www.staticforms.xyz/) - دمج نماذج HTML بسهولة بدون أي كود على الخادم مجانًا. بعد إرسال المستخدم للنموذج، سيتم إرسال بريد إلكتروني بمحتوى النموذج إلى عنوانك المسجل.
  * [stepFORM.io](https://stepform.io) - منشئ اختبارات ونماذج. الخطة المجانية بها خمسة نماذج، حتى 3 خطوات لكل نموذج و50 رد شهريًا.
  * [Typeform.com](https://www.typeform.com/) — أضف نماذج مصممة بشكل جميل إلى المواقع. الخطة المجانية تتيح فقط عشرة حقول لكل نموذج و100 رد شهريًا.
  * [WaiverStevie.com](https://waiverstevie.com) - منصة توقيع إلكتروني مع REST API. يمكنك استقبال الإشعارات عبر Webhooks. الخطة المجانية تضع علامة مائية على المستندات الموقعة ولكن تسمح بأظرف وتوقيعات غير محدودة.
  * [Web3Forms](https://web3forms.com) - نماذج اتصال للمواقع الثابتة وJAMStack بدون كتابة كود خلفي. الخطة المجانية تسمح بنماذج غير محدودة، نطاقات غير محدودة و250 إرسال شهريًا.
  * [WebAsk](https://webask.io) - مُنشئ الاستبيانات والنماذج. الخطة المجانية تتيح ثلاث استبيانات لكل حساب، 100 رد شهريًا، وعشرة عناصر لكل استبيان.
  * [Wufoo](https://www.wufoo.com/) - نماذج سريعة للاستخدام على مواقع الإنترنت. الخطة المجانية محدودة بـ 100 إرسال في كل شهر.
  * [formpost.app](https://formpost.app) - خدمة نموذج إلى بريد إلكتروني مجانية وغير محدودة. قم بإعداد إعادة توجيه مخصصة، رد تلقائي، Webhooks، وغيرها مجانًا.
  * [Formester.com](https://formester.com) - شارك وادمج نماذج ذات مظهر فريد على موقعك الإلكتروني - بدون حدود لعدد النماذج التي يتم إنشاؤها أو الميزات المتاحة حسب الخطة. احصل على ما يصل إلى 100 إرسال كل شهر مجانًا.
  * [SimplePDF.eu](https://simplepdf.eu/embed) - أدمج محرر PDF على موقعك وحول أي PDF إلى نموذج قابل للملء. الخطة المجانية تتيح عددًا غير محدود من ملفات PDF مع ثلاث إرساليات لكل PDF.
  * [forms.app](https://forms.app/) — أنشئ نماذج إلكترونية بميزات قوية مثل المنطق الشرطي، حساب الدرجات التلقائي، والذكاء الاصطناعي. اجمع حتى 100 رد بالخطة المجانية، وادمج نماذجك في موقع إلكتروني أو استخدمها عبر رابط.
  * [Qualli](https://usequalli.com) - استبيانات داخل التطبيقات، مصممة للجوال. استخدم Qualli AI لصياغة الأسئلة المثالية. يمكنك تجربتها في الخطة المجانية لما يصل إلى 500 مستخدم نشط شهريًا (MAU)، وإنشاء عدد غير محدود من النماذج والمحفزات.
  * [Sprig](https://sprig.com/) - استبيان داخل المنتج أو استبيان مع إعادة عرض واحدة شهريًا، مع تحليل ذكاء اصطناعي مدعوم من GPT.
  * [feedback.fish](https://feedback.fish/) - الخطة المجانية تسمح بجمع 25 ردًا إجماليًا. سهل التكامل مع React وVue عبر مكونات جاهزة.
  * [Vidhook](https://vidhook.io/) - اجمع الملاحظات باستخدام استبيانات جذابة بمعدلات استجابة عالية. تشمل الخطة المجانية استبيان نشط واحد، 25 ردًا لكل استبيان وقوالب قابلة للتخصيص.

**[⬆️ العودة للأعلى](#table-of-contents)**

## الذكاء الاصطناعي التوليدي

  * [Zenable](https://zenable.io) - إصلاح تلقائي فوري لمخرجات أدوات مثل Cursor وWindsurf وCopilot لتوافق مع معايير الجودة والامتثال لشركتك باستخدام أدوات حماية مبنية على سياسة ككود. يشمل المستوى المجاني 100 استدعاء أدوات يوميًا لخادم MCP و25 مراجعة تلقائية مجانية لطلبات السحب يوميًا عبر تطبيق GitHub.
  * [Keywords AI](https://keywordsai.co) - أفضل منصة مراقبة LLM. تنسيق واحد لاستدعاء أكثر من 200 نموذج LLM بسطرين من الكود. 10,000 طلب مجاني كل شهر وبدون تكلفة لميزات المنصة!
  * [Portkey](https://portkey.ai/) - لوحة تحكم لتطبيقات الذكاء الاصطناعي التوليدي مع مجموعة مراقبة وبوابة ذكاء اصطناعي. أرسل وسجل حتى 10,000 طلب شهريًا مجانًا.
  * [Braintrust](https://www.braintrustdata.com/) - تقييمات، ملعب بناء المطالبات، وإدارة البيانات لتطبيقات الذكاء الاصطناعي التوليدي. الخطة المجانية تتيح حتى 1,000 صف تقييم خاص أسبوعيًا.
  * [Findr](https://www.usefindr.com/) - بحث شامل يتيح لك البحث في جميع تطبيقاتك دفعة واحدة. مساعد بحث يتيح لك الإجابة على الأسئلة باستخدام معلوماتك. الخطة المجانية توفر بحثًا موحدًا غير محدود و5 استفسارات مساعد يوميًا.
  * [ReportGPT](https://ReportGPT.app) - مساعد كتابة مدعوم بالذكاء الاصطناعي. المنصة كلها مجانية طالما استخدمت مفتاح API خاص بك.
  * [Clair](https://askclair.ai/) - مرجع سريري بالذكاء الاصطناعي. الطلاب لديهم وصول مجاني لمجموعة الأدوات الاحترافية، التي تشمل البحث المفتوح، الملخص السريري، مراجعة الأدوية، تداخلات الأدوية، أكواد ICD-10، والإشراف. بالإضافة إلى ذلك، تتوفر تجربة مجانية للباقة الاحترافية.
  * [Langtrace](https://langtrace.ai) - يمكّن المطورين من تتبع وتقييم وإدارة المطالبات ومجموعات البيانات وتصحيح مشكلات أداء تطبيقات LLM. ينشئ تتبعات بمعيار OpenTelemetry لأي LLM مما يساعد في المراقبة ويعمل مع أي عميل مراقبة. الخطة المجانية تقدم 50 ألف تتبع شهريًا.
  * [LangWatch](https://langwatch.ai) - منصة LLMOps تساعد فرق الذكاء الاصطناعي في قياس ومراقبة وتحسين تطبيقات LLM من حيث الاعتمادية والكلفة والأداء. مع مكون DSPy قوي، نُمكّن التعاون السلس بين المهندسين والفرق غير التقنية لضبط وإنتاج منتجات GenAI. الخطة المجانية تشمل جميع ميزات المنصة، 1,000 تتبع/شهر و1 أداة تحسين DSPy. [#opensource](https://github.com/langwatch/langwatch)
  * [Comet Opik](https://www.comet.com/site/products/opik/) - تقييم واختبار ونشر تطبيقات LLM عبر دورة حياة التطوير والإنتاج. [#opensource](https://github.com/comet-ml/opik/)
  * [Langfuse](https://langfuse.com/) - منصة هندسة LLM مفتوحة المصدر تساعد الفرق على تصحيح وتحليل وتطوير تطبيقات LLM بشكل تعاوني. خطة مجانية للأبد تتضمن 50 ألف ملاحظة شهريًا وجميع ميزات المنصة. [#opensource](https://github.com/langfuse/langfuse)
  * [Pollinations.AI](https://pollinations.ai/) - ذكاء اصطناعي سهل الاستخدام لتوليد الصور مع API مجاني متاح. لا حاجة للتسجيل أو مفاتيح API، وخيارات عديدة للدمج في موقع أو سير عمل. [#opensource](https://github.com/pollinations/pollinations)
  * [Othor AI](https://othor.ai/) - بديل سريع وبسيط وآمن يعتمد على الذكاء الاصطناعي لحلول ذكاء الأعمال الشائعة مثل Tableau وPower BI وLooker. يستخدم Othor نماذج لغوية كبيرة (LLMs) لتقديم حلول ذكاء أعمال مخصصة في دقائق. خطة مجانية للأبد توفر مساحة عمل واحدة مع خمس اتصالات بمصادر البيانات لمستخدم واحد، بدون حدود على التحليلات. [#opensource](https://github.com/othorai/othor.ai)
  * [OpenRouter](https://openrouter.ai/models?q=free) - يوفر نماذج ذكاء اصطناعي مجانية متنوعة تشمل DeepSeek R1 وV3 وLlama وMoonshot AI. تتفوق هذه النماذج في معالجة اللغة الطبيعية وتناسب احتياجات تطوير متنوعة. مع العلم أن هذه النماذج مجانية للاستخدام لكنها خاضعة لحدود معدل الاستخدام. بالإضافة لذلك، يقدم OpenRouter نماذج مدفوعة لاحتياجات أكثر تقدمًا مثل Claude وOpenAI وGrok وGemini وNova.

**[⬆️ العودة للأعلى](#table-of-contents)**

## شبكات CDN والحماية

  * [bootstrapcdn.com](https://www.bootstrapcdn.com/) — شبكة CDN لإطار bootstrap وbootswatch وfontawesome.io
  * [cdnjs.com](https://cdnjs.com/) — بسيط. سريع. موثوق. توصيل المحتوى بأفضل صورة. cdnjs خدمة CDN مجانية ومفتوحة المصدر موثوقة من أكثر من 11% من جميع المواقع، مدعومة من Cloudflare.
  * [developers.google.com](https://developers.google.com/speed/libraries/) — مكتبة Google المستضافة هي شبكة توزيع محتوى لأشهر مكتبات جافاسكريبت مفتوحة المصدر.
  * [Stellate](https://stellate.co/) - Stellate شبكة CDN سريعة وموثوقة لواجهات برمجة تطبيقات GraphQL ومجانية لخدمتين.
  * [jsdelivr.com](https://www.jsdelivr.com/) — CDN مفتوح المصدر مجاني وسريع وموثوق. يدعم npm وGitHub وWordPress وDeno وأكثر.
  * [Microsoft Ajax](https://docs.microsoft.com/en-us/aspnet/ajax/cdn/overview) — تستضيف Microsoft Ajax CDN مكتبات جافاسكريبت الشائعة مثل jQuery وتتيح لك إضافتها بسهولة إلى تطبيقك الويب.
  * [ovh.ie](https://www.ovh.ie/ssl-gateway/) — حماية مجانية من هجمات DDoS وشهادة SSL مجانية.
  * [Skypack](https://www.skypack.dev/) — CDN جافاسكريبت 100% وحدة ES أصلية. مجاني حتى مليون طلب لكل نطاق شهريًا.
  * [raw.githack.com](https://raw.githack.com/) — بديل حديث لـ **rawgit.com** يستضيف الملفات ببساطة باستخدام Cloudflare.
  * [section.io](https://www.section.io/) — طريقة بسيطة لإعداد وإدارة حل كامل لذاكرة التخزين المؤقت Varnish. يُفترض أنه مجاني للأبد لموقع واحد.
  * [statically.io](https://statically.io/) — CDN لمستودعات Git (GitHub, GitLab, Bitbucket)، وملفات WordPress والصور.
  * [toranproxy.com](https://toranproxy.com/) — وكيل لـ Packagist وGitHub. لا مزيد من فشل التكامل المستمر. مجاني للاستخدام الشخصي، مطور واحد، بدون دعم.
  * [UNPKG](https://unpkg.com/) — CDN لكل شيء على npm.
  * [weserv](https://images.weserv.nl/) — خدمة تخزين وتغيير حجم الصور. عدّل الصور مباشرة مع ذاكرة تخزين مؤقت عالمية.
  * [Namecheap Supersonic](https://www.namecheap.com/supersonic-cdn/#free-plan) — حماية مجانية من هجمات DDoS.
  * [Gcore](https://gcorelabs.com/) شبكة توصيل محتوى عالمية، 1 تيرابايت و1 مليون طلب شهريًا مجانًا واستضافة DNS مجانية.
  * [CacheFly](https://portal.cachefly.com/signup/free2023) - حتى 5 تيرابايت شهريًا من حركة مرور CDN المجانية، 19 نقطة تواجد رئيسية، نطاق واحد وSSL شامل.

**[⬆️ العودة للأعلى](#table-of-contents)**

## منصات كخدمة (PaaS)

  * [anvil.works](https://anvil.works) - تطوير تطبيقات الويب باستخدام بايثون فقط. المستوى المجاني مع عدد غير محدود من التطبيقات وحد زمني 30 ثانية.
  * [appwrite](https://appwrite.io) - مشاريع غير محدودة بدون إيقاف مؤقت (يدعم websockets) وخدمة مصادقة. قاعدة بيانات واحدة، 3 حاويات، 5 وظائف لكل مشروع في المستوى المجاني.
  * [configure.it](https://www.configure.it/) — منصة تطوير تطبيقات الجوال، مجانية لمشروعين، ميزات محدودة لكن بدون حدود للموارد.
  * [codenameone.com](https://www.codenameone.com/) — سلسلة أدوات تطوير تطبيقات الجوال مفتوحة المصدر وعبر الأنظمة لمطوري Java/Kotlin. مجاني للاستخدام التجاري بعدد غير محدود من المشاريع.
  * [deco.cx](https://www.deco.cx/en/dev) - منصة واجهات أمامية تعمل على الأطراف مع نظام إدارة محتوى مرئي يتولد تلقائيًا من كود TypeScript. اختبارات A/B مدمجة، تقسيم المحتوى، وتحليلات فورية. مثالية لمواقع التجارة الإلكترونية الغنية بالمحتوى والشركات. مجانية حتى 5,000 مشاهدة صفحة شهريًا أو لمشاريع مفتوحة المصدر/شخصية.
  * [Deno Deploy](https://deno.com/deploy) - نظام موزع لتشغيل JavaScript وTypeScript وWebAssembly عند الأطراف حول العالم. المستوى المجاني يشمل 100,000 طلب يوميًا و100 جيجابايت نقل بيانات شهريًا.
  * [domcloud.co](https://domcloud.co) – خدمة استضافة لينكس تدعم التكامل المستمر/النشر مع GitHub، وSSH، وقواعد بيانات MariaDB/Postgres. النسخة المجانية توفر 1 جيجابايت تخزين و1 جيجابايت نقل بيانات شهريًا ومحدودة بدومين مجاني.
  * [encore.dev](https://encore.dev/) — إطار عمل خلفي يستخدم التحليل الساكن لتوفير البنية التحتية التلقائية وكود بدون قوالب جاهزة والمزيد. يشمل استضافة سحابية مجانية للمشاريع الهواية.
  * [flightcontrol.dev](https://flightcontrol.dev/) - نشر خدمات الويب وقواعد البيانات والمزيد على حساب AWS الخاص بك بأسلوب Git push. مستوى مجاني لمستخدم واحد على مستودعات GitHub الشخصية. تكاليف AWS يتم فوترتها عبر AWS، لكن يمكنك استخدام أرصدة ومستوى AWS المجاني.
  * [gigalixir.com](https://gigalixir.com/) - Gigalixir يوفر مثيلًا مجانيًا لا ينام وقاعدة بيانات PostgreSQL مجانية محدودة باتصالين، 10,000 صف وبدون نسخ احتياطي لتطبيقات Elixir/Phoenix.
  * [Glitch](https://glitch.com/) — استضافة عامة مجانية مع مشاركة الكود والتعاون الفوري. الخطة المجانية بحد أقصى 1000 ساعة شهريًا.
  * [leapcell](https://leapcell.io/) - Leapcell منصة تطبيقات موزعة موثوقة توفر كل ما تحتاجه لدعم نموك السريع بسلاسة. الخطة المجانية تشمل 100,000 استدعاء خدمة، 10,000 مهمة غير متزامنة و100,000 أمر Redis.
  * [pipedream.com](https://pipedream.com) - منصة تكامل مبنية للمطورين. طور أي سير عمل بناءً على أي مشغل. سير العمل هو كود يمكنك تشغيله [مجانًا](https://docs.pipedream.com/pricing/). لا حاجة لإدارة خوادم أو موارد سحابية.
  * [pythonanywhere.com](https://www.pythonanywhere.com/) — استضافة تطبيقات بايثون سحابية. الحساب المبتدئ مجاني، تطبيق ويب بايثون واحد على نطاق your-username.pythonanywhere.com، 512 ميغابايت تخزين خاص، قاعدة بيانات MySQL واحدة.
  * [ampt.dev](https://getampt.com/) - Ampt يتيح للفرق بناء ونشر وتوسيع تطبيقات JavaScript على AWS بدون تعقيدات الإعداد أو إدارة البنية التحتية. الخطة التجريبية المجانية تشمل 500 استدعاء كل ساعة، 2,500 استدعاء يوميًا و50,000 استدعاء شهريًا. النطاقات المخصصة متاحة فقط في الخطط المدفوعة.
  * [Koyeb](https://www.koyeb.com) - منصة بدون خوادم ودية للمطورين لنشر التطبيقات عالميًا. شغّل حاويات Docker، وتطبيقات الويب، وواجهات API مع نشر معتمد على git، وتوسيع تلقائي، وشبكة حواف عالمية. الخطة المجانية تتيح نشر خدمة ويب في فرانكفورت (ألمانيا) أو واشنطن العاصمة (الولايات المتحدة). قاعدة بيانات PostgreSQL مجانية متاحة في فرانكفورت وواشنطن وسنغافورة. 512 ميغابايت ذاكرة، 2 جيجابايت تخزين، و0.1 وحدة معالجة مركزية.
  * [Napkin](https://www.napkin.io/) - وظائف كخدمة مع 500 ميغابايت ذاكرة، حد افتراضي للمهلة 15 ثانية، و5,000 استدعاء API مجاني شهريًا بمعدل 5 استدعاءات/ثانية.
  * [Meteor Cloud](https://www.meteor.com/cloud) — استضافة Galaxy. منصة Meteor كخدمة تشمل استضافة MongoDB مشتركة مجانية وSSL تلقائي.
  * [Northflank](https://northflank.com) — بناء ونشر الخدمات المصغرة والمهام المجدولة وقواعد البيانات المدارة مع واجهة مستخدم قوية وAPI وCLI. توسعة الحاويات بسلاسة من التحكم في الإصدارات ومستودعات Docker الخارجية. المستوى المجاني يشمل خدمتين، مهمتين مجدولتين وقاعدة بيانات واحدة.
  * [YepCode](https://yepcode.io) - منصة شاملة لربط واجهات API والخدمات في بيئة بدون خوادم. تجمع بين مرونة NoCode وقوة لغات البرمجة. المستوى المجاني يشمل [1,000 yep](https://yepcode.io/pricing/).
  * [WunderGraph](https://cloud.wundergraph.com) - منصة مفتوحة المصدر لبناء وإدارة واجهات برمجة التطبيقات الحديثة بسرعة. CI/CD مدمج، تكامل مع GitHub وHTTPS تلقائي. حتى 3 مشاريع، 1 جيجابايت خروج بيانات، 300 دقيقة بناء شهريًا في [الخطة المجانية](https://wundergraph.com/pricing)
  * [Zeabur](https://zeabur.com) - انشر خدماتك بنقرة واحدة. مجاني لثلاث خدمات، مع 5 دولارات أرصدة مجانية شهريًا.
  * [mogenius](https://mogenius.com) - بناء ونشر وتشغيل الخدمات على Kubernetes بسهولة. المستوى المجاني يدعم ربط Kubernetes المحلي مع mogenius، مما يمكّن المطورين من إنشاء بيئة اختبار شبيهة بالإنتاج على جهازهم.
  * [genezio](https://genezio.com/) - مزود وظائف بدون خوادم يقدم مليون استدعاء وظيفة، 100 جيجابايت نقل بيانات، و10 مهام مجدولة شهريًا مجانًا، للاستخدام غير التجاري أو الأكاديمي فقط.

**[⬆️ العودة للأعلى](#table-of-contents)**

## BaaS

  * [Activepieces](https://www.activepieces.com) - أنشئ تدفقات أتمتة لربط عدة تطبيقات معًا في خلفية تطبيقك. على سبيل المثال، إرسال رسالة Slack أو إضافة صف Google Sheet عند حدوث حدث في تطبيقك. مجاني حتى 5,000 مهمة شهريًا.
  * [back4app.com](https://www.back4app.com) - Back4App منصة خلفية سهلة الاستخدام ومرنة وقابلة للتوسع مبنية على Parse Platform.
  * [backendless.com](https://backendless.com/) — BaaS للجوال والويب، مع 1 جيجابايت تخزين ملفات مجاني، 50,000 إشعار دفع شهريًا، و1,000 كائن بيانات في الجدول.
  * [bismuth.cloud](https://www.bismuth.cloud/) — ذكاؤنا الاصطناعي سيطلق واجهة API بايثون الخاصة بك على بيئة وظائفنا التخزينية المستضافة، وابنِ واستضف مجانًا في محررنا الإلكتروني أو محليًا بأدواتك المفضلة.
  * [BMC Developer Program](https://developers.bmc.com/site/global/bmc_helix_platform/program/overview/index.gsp) — برنامج مطوري BMC يوفر وثائق وموارد لبناء ونشر ابتكارات رقمية لمؤسستك. وصول إلى مساحة اختبار شخصية شاملة تشمل المنصة وSDK ومكتبة مكونات لبناء وتخصيص التطبيقات.
  * [connectycube.com](https://connectycube.com) - رسائل دردشة غير محدودة، مكالمات صوتية وفيديو نظير إلى نظير، مرفقات ملفات، وإشعارات دفع. مجاني للتطبيقات حتى 1,000 مستخدم.
  * [convex.dev](https://convex.dev/) - باك اند تفاعلي كخدمة، يستضيف بياناتك (مستندات مع علاقات ومعاملات ACID قابلة للتسلسل)، وظائف بدون خوادم، وWebSockets لبث التحديثات لمختلف العملاء. مجاني للمشاريع الصغيرة - حتى مليون سجل، و5 ملايين استدعاء وظيفة شهريًا.
  * [darklang.com](https://darklang.com/) - لغة مستضافة مع محرر وبنية تحتية. متاح خلال البيتا، وسيكون هناك مستوى مجاني سخي بعد البيتا.
  * [Firebase](https://firebase.com) — تساعدك Firebase في بناء وتشغيل تطبيقات ناجحة. خطة Spark المجانية تقدم المصادقة، الاستضافة، Firebase ML، قاعدة بيانات لحظية، تخزين سحابي، Testlab. A/B Testing، التحليلات، توزيع التطبيقات، فهرسة التطبيقات، رسائل FCM، Crashlytics، الروابط الديناميكية، الرسائل داخل التطبيق، مراقبة الأداء، التنبؤات، والتكوين عن بُعد كلها مجانية دائمًا.
  * [Flutter Flow](https://flutterflow.io) — أنشئ واجهة تطبيق Flutter بدون كتابة سطر كود واحد. يحتوي أيضًا على تكامل مع Firebase. الخطة المجانية تشمل وصولاً كاملاً إلى منشئ الواجهة وقوالب مجانية.
  * [getstream.io](https://getstream.io/) — بناء دردشة، رسائل، فيديو وصوت، وتغذيات قابلة للتوسع داخل التطبيقات في ساعات بدل أسابيع.
  * [hasura.io](https://hasura.io/) — يمدد Hasura قواعد بياناتك الحالية أينما استضافت ويوفر API GraphQL فورية يمكن الوصول إليها بأمان لتطبيقات الويب والجوال ودمج البيانات. مجاني حتى 1 جيجابايت/شهر من البيانات المنقولة.
  * [nhost.io](https://nhost.io) - باك اند بدون خوادم لتطبيقات الويب والجوال. الخطة المجانية تشمل PostgreSQL وGraphQL (Hasura) والمصادقة والتخزين والوظائف بدون خوادم.
  * [onesignal.com](https://onesignal.com/) — إشعارات دفع غير محدودة مجانًا. 10,000 بريد إلكتروني شهريًا، مع عدد غير محدود من جهات الاتصال والوصول إلى خاصية Auto Warm Up.
  * [paraio.com](https://paraio.com) — واجهة خدمة خلفية مع مصادقة مرنة، بحث نصي كامل وذاكرة تخزين مؤقت. مجاني لتطبيق واحد، 1 جيجابايت بيانات تطبيق.
  * [pubnub.com](https://www.pubnub.com/) — إشعارات دفع مجانية لما يصل إلى مليون رسالة/شهريًا و100 جهاز نشط يوميًا
  * [pushbots.com](https://pushbots.com/) — خدمة إشعارات دفع. مجانًا لما يصل إلى 1.5 مليون إشعار/شهريًا
  * [pushcrew.com](https://pushcrew.com/) — خدمة إشعارات دفع. إشعارات غير محدودة لما يصل إلى 2000 مشترك
  * [pusher.com](https://pusher.com/beams) — إشعارات دفع غير محدودة مجانًا حتى 2000 مستخدم نشط شهريًا. واجهة برمجة تطبيقات واحدة لأجهزة iOS وAndroid.
  * [quickblox.com](https://quickblox.com/) — منصة خلفية للاتصالات للمراسلة الفورية، الفيديو، والمكالمات الصوتية، وإشعارات الدفع
  * [restspace.io](https://restspace.io/) - قم بتكوين خادم مع خدمات للمصادقة، البيانات، الملفات، واجهة برمجة تطبيقات البريد الإلكتروني، القوالب والمزيد، ثم دمجها في خطوط معالجة وتحويل البيانات.
  * [Salesforce Developer Program](https://developer.salesforce.com/signup) — أنشئ تطبيقات بسرعة عن طريق أدوات السحب والإفلات. خصص نموذج بياناتك بالنقرات. تقدم أكثر باستخدام كود Apex. قم بالدمج مع أي نظام باستخدام واجهات برمجة التطبيقات القوية. ابق محميًا بأمان من مستوى المؤسسات. خصص واجهة المستخدم بالنقرات أو أي إطار عمل ويب متقدم. يمنحك برنامج المطور المجاني وصولًا كاملاً إلى منصة Lightning.
  * [simperium.com](https://simperium.com/) — انقل البيانات فورًا وبشكل تلقائي في كل مكان، متعدد المنصات، إرسال وتخزين غير محدود للبيانات المنظمة، بحد أقصى 2,500 مستخدم/شهريًا
  * [Supabase](https://supabase.com) — البديل مفتوح المصدر لـ Firebase لبناء الخلفيات. الخطة المجانية توفر المصادقة، قاعدة بيانات فورية وتخزين كائنات.
  * [tyk.io](https://tyk.io/) — إدارة واجهات برمجة التطبيقات مع المصادقة، الحصص، المراقبة والتحليلات. عرض سحابي مجاني
  * [zapier.com](https://zapier.com/) — اربط التطبيقات التي تستخدمها لأتمتة المهام. خمسة عمليات تلقائية كل 15 دقيقة و100 مهمة/شهريًا
  * [IFTTT](https://ifttt.com) — أتمت تطبيقاتك وأجهزتك المفضلة. مجانًا حتى 2 Applets
  * [Integrately](https://integrately.com) — أتمت المهام المملة بنقرة واحدة. 100 مهمة مجانية، وقت تحديث 15 دقيقة، خمسة أتمتة نشطة، webhooks.
  * [LeanCloud](https://leancloud.app/) — خلفية للهواتف المحمولة. 1 جيجابايت تخزين بيانات، 256 ميجابايت مثيل، 3 آلاف طلب API/يوم، و10 آلاف إشعار دفع/يوم مجانًا. (واجهة البرمجة مشابهة جدًا لـ Parse Platform)
  * [Claw.cloud](https://run.claw.cloud) - منصة PaaS تقدم 5 دولارات شهريًا من الرصيد المجاني للمستخدمين الذين لديهم حساب GitHub عمره أكثر من 180 يومًا. مثالية لاستضافة التطبيقات وقواعد البيانات وغيرها. ([رابط التسجيل مع رصيد مجاني](https://ap-southeast-1.run.claw.cloud/signin)).


**[⬆️ العودة للأعلى](#table-of-contents)**

## منصة البرمجة منخفضة الكود

  * [appsmith](https://www.appsmith.com/) — مشروع منخفض الكود لبناء لوحات الإدارة، الأدوات الداخلية، ولوحات البيانات. يتكامل مع أكثر من 15 قاعدة بيانات وأي API.
  * [Basedash](https://www.basedash.com) — منصة منخفضة الكود لبناء لوحات الإدارة الداخلية ولوحات البيانات. تدعم قواعد بيانات SQL وواجهات REST API.
  * [BudiBase](https://budibase.com/) — Budibase منصة منخفضة الكود مفتوحة المصدر لإنشاء التطبيقات الداخلية في دقائق. تدعم PostgreSQL وMySQL وMSSQL وMongoDB وRest API وDocker وK8s
  * [Clappia](https://www.clappia.com) — منصة منخفضة الكود مصممة لبناء تطبيقات عمليات الأعمال مع تطبيقات ويب وجوال قابلة للتخصيص. تقدم واجهة سحب وإفلات، ميزات مثل الدعم دون اتصال، تتبع الموقع في الوقت الحقيقي والتكامل مع خدمات طرف ثالث مختلفة
  * [DronaHQ](https://www.dronahq.com/) — DronaHQ - منصة منخفضة الكود تساعد فرق الهندسة ومديري المنتجات على بناء الأدوات الداخلية، رحلات المستخدم المخصصة، التجارب الرقمية، الأتمتة، لوحات الإدارة المخصصة، التطبيقات التشغيلية بسرعة أكبر 10 مرات.
  * [lil'bots](https://www.lilbots.io/) - كتابة وتشغيل السكريبتات عبر الإنترنت باستخدام واجهات برمجة التطبيقات المدمجة المجانية مثل OpenAI، Anthropic، Firecrawl وغيرها. رائعة لبناء وكلاء الذكاء الاصطناعي/الأدوات الداخلية ومشاركتها مع الفريق. الطبقة المجانية تشمل الوصول الكامل إلى الواجهات، مساعد البرمجة بالذكاء الاصطناعي و10,000 رصيد تنفيذ شهريًا.
  * [Mendix](https://www.mendix.com/) — تطوير تطبيقات سريع للمؤسسات، بيئات اختبار غير محدودة تدعم عدد مستخدمين غير محدود، 0.5 جيجابايت تخزين و1 جيجابايت RAM لكل تطبيق. كما يسمح باستخدام IDEs Studio وStudio Pro في الطبقة المجانية.
  * [outsystems.com](https://www.outsystems.com/) — منصة تطوير ويب مؤسسية (PaaS) للاستضافة المحلية أو السحابية، بيئة "شخصية" مجانية تسمح بكود غير محدود وما يصل إلى 1 جيجابايت قاعدة بيانات
  * [ReTool](https://retool.com/) — منصة منخفضة الكود لبناء التطبيقات الداخلية. Retool قابلة للتعديل بشكل كبير. إذا كان بإمكانك كتابته بجافاسكريبت وAPI يمكنك صنعه في Retool. الخطة المجانية تسمح حتى خمسة مستخدمين شهريًا، تطبيقات غير محدودة واتصالات API غير محدودة.
  * [Superblocks](https://superblocks.com/) — منصة تطبيقات مؤسسية مفتوحة مصممة للمطورين والفرق شبه التقنية. استخدم الذكاء الاصطناعي للتوليد، التحرير البصري والتوسعة بالكود. إدارة مركزية مع تكاملات، مصادقة، أذونات وسجلات تدقيق.
  * [ToolJet](https://www.tooljet.com/) — إطار عمل منخفض الكود قابل للتوسعة لبناء تطبيقات الأعمال. الاتصال بقواعد البيانات، التخزين السحابي، GraphQL، نقاط نهاية API، Airtable، وغيرها، وبناء التطبيقات باستخدام منشئ التطبيقات بالسحب والإفلات.
  * [UI Bakery](https://uibakery.io) — منصة منخفضة الكود تتيح بناء تطبيقات ويب مخصصة بسرعة. تدعم بناء الواجهة باستخدام السحب والإفلات مع مستوى عالٍ من التخصيص عبر جافاسكريبت، بايثون، وSQL. متوفرة كحلول سحابية أو ذاتية الاستضافة. مجانًا لما يصل إلى 5 مستخدمين.
  * [manubes](https://www.manubes.com) - منصة سحابية قوية بدون كود تركز على إدارة الإنتاج الصناعي. مجانية لمستخدم واحد مع مليون نشاط سير عمل شهريًا ([متوفرة أيضًا بالألمانية](https://www.manubes.de)).

**[⬆️ العودة للأعلى](#table-of-contents)**

## استضافة الويب

  * [Alwaysdata](https://www.alwaysdata.com/) — استضافة ويب مجانية 100 ميجابايت مع دعم MySQL، PostgreSQL، CouchDB، MongoDB، PHP، Python، Ruby، Node.js، Elixir، Java، Deno، خوادم ويب مخصصة، الوصول عبر FTP وWebDAV وSSH؛ صندوق بريد، قائمة بريدية ومثبت تطبيقات مشمول.
  * [Awardspace.com](https://www.awardspace.com) — استضافة ويب مجانية + نطاق قصير مجاني، PHP، MySQL، مثبت تطبيقات، إرسال بريد إلكتروني وبدون إعلانات.
  * [Bohr](https://bohr.io) — مجاني للمشاريع غير التجارية + منصة نشر وتطوير تركز على المطورين تقلل من عناء البنية التحتية وتسرع الإعداد.
  * [Bubble](https://bubble.io/) — برمجة مرئية لبناء تطبيقات الويب والجوال بدون كود، مجانًا مع علامة Bubble.
  * [dAppling Network](https://www.dappling.network/) - منصة استضافة ويب لامركزية لواجهات Web3 تركز على زيادة الجهوزية والأمان وتوفير نقطة وصول إضافية للمستخدمين.
  * [DigitalOcean](https://www.digitalocean.com/pricing) - بناء ونشر ثلاثة مواقع ثابتة مجانًا على طبقة App Platform Starter.
  * [Drive To Web](https://drv.tw) — استضافة مباشرة إلى الويب من Google Drive & OneDrive. مواقع ثابتة فقط. مجانية للأبد. موقع واحد لكل حساب Google/Microsoft.
  * [Fenix Web Server](https://preview.fenixwebserver.com) - تطبيق سطح مكتب للمطورين لاستضافة المواقع محليًا ومشاركتها علنًا (في الوقت الحقيقي). اعمل بالطريقة التي تفضلها باستخدام واجهته الجميلة وAPI و/أو CLI.
  * [Fern](https://buildwithfern.com) - أنشئ واستضف موقع توثيق قائم على Markdown على خطة Fern المجانية. يمكنك حتى توليد مرجع API تلقائيًا لموقعك من ملفات تعريف API. الموقع يستضاف على _yoursite_.docs.buildwithfern.com.
  * [Free Hosting](https://freehostingnoads.net/) — استضافة مجانية مع PHP 5، Perl، CGI، MySQL، FTP، مدير ملفات، بريد إلكتروني POP، نطاقات فرعية مجانية، استضافة نطاقات مجانية، محرر منطقة DNS، إحصاءات الموقع، دعم فني مجاني عبر الإنترنت والعديد من الميزات الأخرى غير المتوفرة لدى المستضيفين المجانيين الآخرين.
  * [Freehostia](https://www.freehostia.com) — تقدم FreeHostia خدمات استضافة مجانية تشمل لوحة تحكم مميزة وتثبيت بنقرة واحدة لأكثر من 50 تطبيقًا مجانيًا. إعداد فوري. بدون إعلانات إجبارية.
  * [HelioHost](https://heliohost.org) — استضافة ويب مجانية غير ربحية مع لوحة تحكم Plesk، PHP، Node.js، Python، Django، Flask، .NET، Perl، CGI، MySQL، PostgreSQL، SQLite، بريد إلكتروني IMAP/POP3/SMTP، عرض نطاق غير محدود، نطاقات فرعية مجانية، 1000 ميجابايت مساحة تخزين مجانية مع خيار الترقية.
  * [Kinsta Static Site Hosting](https://kinsta.com/static-site-hosting/) — نشر حتى 100 موقع ثابت مجانًا، نطاقات مخصصة مع SSL، 100 جيجابايت عرض نطاق شهري، أكثر من 260 موقع CDN من Cloudflare.
  * [Lecturify](https://www.lecturify.net/index.en.html) - استضافة ويب مع وصول SFPT لرفع وتنزيل الملفات، PHP متاح.
  * [Neocities](https://neocities.org) — مواقع ثابتة، 1 جيجابايت تخزين مجاني مع 200 جيجابايت عرض نطاق.
  * [Netlify](https://www.netlify.com/) — يبني، ينشر ويستضيف مواقع/تطبيقات ثابتة مجانًا لـ 100 جيجابايت بيانات و100 جيجابايت/شهريًا عرض نطاق.
  * [pantheon.io](https://pantheon.io/) — استضافة Drupal وWordPress، DevOps مؤتمت وبنية تحتية قابلة للتوسع. مجاني للمطورين والوكالات. بدون نطاق مخصص.
  * [readthedocs.org](https://readthedocs.org/) — استضافة توثيق مجانية مع إدارة الإصدارات، توليد PDF والمزيد
  * [render.com](https://render.com) — سحابة موحدة لبناء وتشغيل التطبيقات والمواقع مع SSL مجاني، CDN عالمي، شبكات خاصة، نشر تلقائي من Git، وخطط مجانية كاملة لخدمات الويب، قواعد البيانات وصفحات الويب الثابتة.
  * [SourceForge](https://sourceforge.net/) — ابحث، أنشئ، وانشر البرمجيات مفتوحة المصدر مجانًا
  * [surge.sh](https://surge.sh/) — نشر ويب ثابت لمطوري الواجهة الأمامية. مواقع غير محدودة مع دعم النطاقات المخصصة
  * [telegra.ph](https://telegra.ph/) أنشئ صفحة ويب بسهولة باستخدام Quill
  * [tilda.cc](https://tilda.cc/) — موقع واحد، 50 صفحة، 50 ميجابايت تخزين، فقط الكتل الرئيسية المحددة مسبقًا من بين أكثر من 170 متاحة، لا خطوط، لا رمز مفضل، ولا نطاق مخصص
  * [Vercel](https://vercel.com/) — بناء، نشر واستضافة تطبيقات الويب مع SSL مجاني، CDN عالمي، وروابط معاينة فريدة في كل مرة تقوم فيها بعمل `git push`. مثالي لـ Next.js ومولدات المواقع الثابتة الأخرى.
  * [Versoly](https://versoly.com/) — منشئ مواقع يركز على SaaS - مواقع غير محدودة، أكثر من 70 كتلة، خمسة قوالب، CSS مخصص، رمز مفضل، تحسين محركات البحث ونماذج. بدون نطاق مخصص.
  * [Qoddi](https://qoddi.com) - خدمة PaaS مشابهة لـ Heroku بنهج يركز على المطورين وميزات شاملة. طبقة مجانية للأصول الثابتة، بيئات التجريب وتطبيقات المطورين.
  * [FreeFlarum](https://freeflarum.com/) - استضافة Flarum مجانية مدعومة من المجتمع لما يصل إلى 250 مستخدمًا (تبرع لإزالة العلامة المائية من التذييل).
  * [MDB GO](https://mdbgo.com/) - استضافة مجانية لمشروع واحد مع صلاحية حاوية لمدة أسبوعين، 500 ميجابايت RAM لكل مشروع، SFTP - 1 جيجابايت مساحة قرص.
  * [Patr Cloud](https://patr.cloud/) — منصة سحابية سهلة الاستخدام، من بين خدماتها المدفوعة تقدم استضافة ثلاثة مواقع ثابتة مجانًا.
  * [Serv00.com](https://serv00.com/) — 3 جيجابايت استضافة ويب مجانية مع نسخ احتياطي يومي (7 أيام). يدعم: مهام Crontab، وصول SSH، مستودعات (GIT، SVN، وMercurial)، دعم: MySQL، PostgreSQL، MongoDB، PHP، Node.js، Python، Ruby، Java، Perl، TCL/TK، Lua، Erlang، Rust، Pascal، C، C++، D، R، والعديد غيرها.
  - [Sevalla](https://sevalla.com/) - منصة استضافة مصممة لتبسيط نشر وإدارة التطبيقات، قواعد البيانات، والمواقع الثابتة - حد الموقع 1 جيجابايت، 100 جيجابايت عرض نطاق مجاني، 600 دقيقة بناء مجانية، 100 موقع لكل حساب.

**[⬆️ العودة للأعلى](#table-of-contents)**

## DNS

  * [1.1.1.1](https://developers.cloudflare.com/1.1.1.1/) - محلل DNS عام مجاني، سريع وآمن (يشفر طلب DNS)، مقدم من Cloudflare. مفيد لتجاوز حجب DNS من مزود الإنترنت، منع التجسس على استعلامات DNS، و[حجب محتوى البالغين والبرامج الضارة](https://developers.cloudflare.com/1.1.1.1/1.1.1.1-for-families). يمكن استخدامه أيضًا [عبر API](https://developers.cloudflare.com/1.1.1.1/encrypted-dns/dns-over-https/make-api-requests). ملاحظة: هو مجرد محلل DNS، وليس مستضيف DNS.
  * [1984.is](https://www.1984.is/product/freedns/) — خدمة DNS مجانية مع API والعديد من ميزات DNS المجانية الأخرى.
  * [cloudns.net](https://www.cloudns.net/) — استضافة DNS مجانية حتى نطاق واحد مع 50 سجل
  * [deSEC](https://desec.io) - استضافة DNS مجانية مع دعم API، مصممة مع مراعاة الأمان. تعمل ببرمجيات مفتوحة المصدر وبدعم من [SSE](https://www.securesystems.de/).
  * [dns.he.net](https://dns.he.net/) — خدمة استضافة DNS مجانية مع دعم DNS ديناميكي
  * [Zonomi](https://zonomi.com/) — خدمة استضافة DNS مجانية مع نشر فوري. الخطة المجانية: منطقة DNS واحدة (اسم نطاق) مع ما يصل إلى 10 سجلات DNS.
  * [dnspod.com](https://www.dnspod.com/) — استضافة DNS مجانية.
  * [duckdns.org](https://www.duckdns.org/) — DDNS مجاني مع ما يصل إلى 5 نطاقات في الطبقة المجانية. مع أدلة إعداد لمختلف التكوينات.
  * [Dynv6.com](https://dynv6.com/) — خدمة DDNS مجانية مع [دعم API](https://dynv6.com/docs/apis) وإدارة العديد من أنواع سجلات DNS (مثل CNAME، MX، SPF، SRV، TXT وغيرها).
  * [freedns.afraid.org](https://freedns.afraid.org/) — استضافة DNS مجانية. كما توفر نطاقات فرعية مجانية بناءً على العديد من [النطاقات العامة المقدمة من المستخدمين](https://freedns.afraid.org/domain/registry/). احصل على نطاقات فرعية مجانية من قائمة "Subdomains" بعد التسجيل.
  * [luadns.com](https://www.luadns.com/) — استضافة DNS مجانية، ثلاثة نطاقات، جميع الميزات مع حدود معقولة
  * [namecheap.com](https://www.namecheap.com/domains/freedns/) — DNS مجاني. بدون حد لعدد النطاقات
  * [nextdns.io](https://nextdns.io) - جدار حماية قائم على DNS، 300 ألف استعلام مجاني شهريًا
  * [noip.at](https://noip.at/) — خدمة DDNS مجانية بدون تسجيل أو تتبع أو تسجيل أو إعلانات. بدون حد للنطاقات.
  * [noip](https://www.noip.com/) — خدمة DNS ديناميكي تسمح حتى 3 أسماء مضيفين مجانًا مع تأكيد كل 30 يومًا
  * [sslip.io](https://sslip.io/) — خدمة DNS مجانية عند الاستعلام باسم مضيف مدمج مع عنوان IP تُرجع ذلك العنوان.
  * [zilore.com](https://zilore.com/en/dns) — استضافة DNS مجانية لـ 5 نطاقات.
  * [zoneedit.com](https://www.zoneedit.com/free-dns/) — استضافة DNS مجانية مع دعم DNS ديناميكي.
  * [zonewatcher.com](https://zonewatcher.com) — نسخ احتياطي تلقائي ومراقبة تغييرات DNS. نطاق واحد مجاني
  * [huaweicloud.com](https://www.huaweicloud.com/intl/en-us/product/dns.html) – استضافة DNS مجانية من هواوي
  * [Hetzner](https://www.hetzner.com/dns-console) – استضافة DNS مجانية من Hetzner مع دعم API.
  * [Glauca](https://docs.glauca.digital/hexdns/) – استضافة DNS مجانية حتى 3 نطاقات ودعم DNSSEC
  * [VolaryDDNS](https://volaryddns.net) - DDNS عالي الأداء مجاني بدون اشتراكات أو إعلانات

**[⬆️ العودة إلى الأعلى](#table-of-contents)**

## النطاقات

  * [pp.ua](https://nic.ua/) — نطاقات فرعية مجانية على pp.ua.
  * [us.kg](https://nic.us.kg/) - نطاقات فرعية مجانية على us.kg.

**[⬆️ العودة إلى الأعلى](#table-of-contents)**

## البنية التحتية كخدمة (IaaS)

  * [4EVERLAND](https://www.4everland.org/) — متوافق مع AWS S3 - واجهات برمجة التطبيقات، عمليات الواجهة، CLI، وطرق رفع أخرى، رفع وتخزين الملفات من شبكتي IPFS وArweave بطريقة آمنة ومريحة وفعالة. يمكن للمستخدمين المسجلين الحصول على 6 جيجابايت من تخزين IPFS و300 ميجابايت من تخزين Arweave مجاناً. رفع أي ملف على Arweave أقل من 150 كيلوبايت مجاني.
  * [backblaze.com](https://www.backblaze.com/b2/) — تخزين سحابي Backblaze B2. تخزين كائنات مجاني بسعة 10 جيجابايت (مشابه لـ Amazon S3) لفترة غير محدودة
  * [filebase.com](https://filebase.com/) - تخزين كائنات متوافق مع S3 مدعوم بتقنية البلوكشين. 5 جيجابايت مجانية لمدة غير محدودة.
  * [Tebi](https://tebi.io/) - تخزين كائنات متوافق مع S3. 25 جيجابايت تخزين و250 جيجابايت نقل بيانات خارجي مجاناً.
  * [Idrive e2](https://www.idrive.com/e2/) - تخزين كائنات متوافق مع S3. 10 جيجابايت تخزين مجاني و10 جيجابايت عرض نطاق تحميل شهرياً.
  * [C2 Object Storage](https://c2.synology.com/en-us/pricing/object-storage) - تخزين كائنات متوافق مع S3. 15 جيجابايت تخزين مجاني و15 جيجابايت تحميل شهرياً.

**[⬆️ العودة إلى الأعلى](#table-of-contents)**

## خدمات البيانات المُدارة

  * [Aiven](https://aiven.io/) - تقدم Aiven خطط مجانية لـ PostgreSQL وMySQL وRedis على منصتها مفتوحة المصدر. عقدة واحدة، معالج واحد، 1 جيجابايت رام، ولـ PostgreSQL وMySQL، 5 جيجابايت تخزين. ترقية سهلة لخطط أكبر أو عبر السحب.
  * [airtable.com](https://airtable.com/) — يشبه جدول بيانات، لكنه قاعدة بيانات علائقية مع قواعد غير محدودة، 1200 صف/قاعدة، و1000 طلب API شهرياً
  * [Astra](https://www.datastax.com/products/datastax-astra/) — كاساندرا سحابية كخدمة مع [80 جيجابايت في الطبقة المجانية](https://www.datastax.com/products/datastax-astra/pricing)
  * [codehooks.io](https://codehooks.io/) — خدمة API/Backend بدون خادم وقاعدة بيانات NoSQL سهلة الاستخدام لجافاسكريبت مع وظائف، استعلامات شبيهة بـ Mongdb، بحث حسب المفتاح/القيمة، نظام وظائف، رسائل في الوقت الحقيقي، قوائم انتظار، CLI قوي ومدير بيانات عبر الويب. الخطة المجانية تشمل 5 جيجابايت تخزين و60 طلب API/دقيقة. يشمل مطورين اثنين. لا حاجة لبطاقة ائتمان.
  * [CrateDB](https://crate.io/) - قاعدة بيانات SQL موزعة ومفتوحة المصدر للتحليلات اللحظية. [الطبقة المجانية CRFREE](https://crate.io/lp-crfree): عقدة واحدة بمعالجين، 2 جيجابايت رام، 8 جيجابايت تخزين. عنقود واحد لكل مؤسسة، لا حاجة لطريقة دفع.
  * [Upstash](https://upstash.com/) — Redis بدون خادم مع طبقة مجانية تصل إلى 10,000 طلب يومياً، 256 ميجابايت كحد أقصى لحجم القاعدة، و20 اتصال متزامن
  * [Couchbase Capella](https://www.couchbase.com/products/capella/) - نشر طبقة مجانية للأبد لقاعدة بيانات مدارة بالكامل لبناء الجيل القادم من التطبيقات من IoT إلى الذكاء الاصطناعي
  * [MongoDB Atlas](https://www.mongodb.com/cloud/atlas) — الطبقة المجانية تمنح 512 ميجابايت
  * [redsmin.com](https://www.redsmin.com/) — خدمة مراقبة وإدارة فورية عبر الإنترنت لـ Redis، مراقبة مثيل واحد من Redis مجاناً
  * [redislabs](https://redislabs.com/try-free/) - مثيل Redis مجاني بحجم 30 ميجابايت
  * [MemCachier](https://www.memcachier.com/) — خدمة Memcache مُدارة. مجاني حتى 25 ميجابايت، خادم وكيل واحد، وتحليلات أساسية
  * [scalingo.com](https://scalingo.com/) — في الأساس PaaS لكن يقدم طبقة مجانية من 128 إلى 192 ميجابايت من MySQL أو PostgreSQL أو MongoDB
  * [SeaTable](https://seatable.io/) — قاعدة بيانات مرنة شبيهة بجداول البيانات من فريق Seafile. جداول غير محدودة، 2000 صف، حفظ نسخة شهرية، حتى 25 عضو فريق.
  * [skyvia.com](https://skyvia.com/) — منصة بيانات سحابية تقدم طبقة مجانية وجميع الخطط مجانية أثناء المرحلة التجريبية
  * [StackBy](https://stackby.com/) — أداة تجمع بين مرونة الجداول وقوة قواعد البيانات وتكاملات مدمجة مع تطبيقات الأعمال المفضلة لديك. الخطة المجانية تتضمن مستخدمين غير محدودين، عشرة أكوام، و2 جيجابايت مرفقات لكل كومة.
  * [TiDB Cloud](https://en.pingcap.com/tidb-cloud/) — TiDB قاعدة بيانات HTAP موزعة متوافقة مع MySQL ومفتوحة المصدر. TiDB Serverless تقدم 5 جيجابايت تخزين صفوف، 5 جيجابايت تخزين أعمدة، و50 مليون وحدة طلب (RU) مجاناً كل شهر.
  * [Turso by ChiselStrike](https://chiselstrike.com/) - Turso تجربة مطور SQLite في قاعدة بيانات على الحافة. خطة مجانية للأبد، 9 جيجابايت تخزين إجمالي، حتى 500 قاعدة بيانات، حتى 3 مواقع، مليار قراءة صف شهرياً، ودعم تطوير محلي مع SQLite.
  * [InfluxDB](https://www.influxdata.com/) — قاعدة بيانات سلاسل زمنية، مجانية حتى 3 ميجابايت/5 دقائق للكتابة، 30 ميجابايت/5 دقائق للقراءة و10,000 سلسلة مختلفة
  * [restdb.io](https://restdb.io/) - قاعدة بيانات NoSQL سحابية بسيطة وسريعة. سكيما، علاقات، REST API تلقائي (مع استعلامات شبيهة بـ MongoDB)، وواجهة إدارة بيانات فعالة. الخطة المجانية تسمح بـ 3 مستخدمين، 2500 سجل، و1 طلب API في الثانية.
  * [CockroachDB Cloud](https://www.cockroachlabs.com/pricing/) — الطبقة المجانية تمنح 50 مليون وحدة طلب و10 جيجابايت تخزين (تعادل 15$ شهرياً) مجاناً. ([ما هي وحدات الطلب؟](https://www.cockroachlabs.com/docs/cockroachcloud/metrics-request-units.html))
  * [Neo4j Aura](https://neo4j.com/cloud/aura/) — قاعدة بيانات رسم بياني مُدارة / منصة تحليلات مع لغة استعلام Cypher وواجهة REST. حدود الحجم: 50 ألف عقدة، 175 ألف علاقة.
  * [Neon](https://neon.tech/) — PostgreSQL مُدار، 0.5 جيجابايت تخزين (إجمالي)، 1 مشروع، 10 فروع، قواعد بيانات غير محدودة، فرع رئيسي متاح دائماً (إيقاف تلقائي بعد 5 دقائق)، 20 ساعة وقت نشط شهرياً للفروع غير الرئيسية.
  * [Prisma Postgres](https://prisma.io/postgres) - Postgres مستضاف فائق السرعة مبني على unikernels ويعمل على أجهزة فعلية، 1 جيجابايت تخزين، 10 قواعد بيانات، مدمج مع Prisma ORM.
  * [Dgraph Cloud](https://cloud.dgraph.io/pricing?type=free) — قاعدة بيانات رسم بياني مُدارة مع GraphQL API. محدود بـ 1 ميجابايت نقل بيانات يومياً.
  * [Tinybird](https://tinybird.co) - ClickHouse مُدار بدون خادم مع إدخال بيانات بدون اتصال عبر HTTP ويسمح بنشر استعلامات SQL كواجهات HTTP مُدارة. لا يوجد حد زمني للطبقة المجانية، 10 جيجابايت تخزين + 1000 طلب API يومياً.
  * [TigerGraph Cloud](https://www.tigergraph.com/cloud/) — قاعدة بيانات رسم بياني مُدارة / منصة تحليلات مع لغة استعلام رسومية شبيهة بـ SQL وواجهة REST. مثيل مجاني واحد بمعالجين، 8 جيجابايت رام، و50 جيجابايت تخزين، يتوقف بعد ساعة من عدم النشاط.
  * [TerminusCMS](https://terminusdb.com/pricing) — خدمة مجانية مُدارة لـ TerminusDB، قاعدة بيانات مستندات ورسم بياني مكتوبة بلغة Prolog وRust. مجانية للمطورين، مدفوعة للمؤسسات.
  * [filess.io](https://filess.io) - منصة لإنشاء قاعدتي بيانات حتى 10 ميجابايت لكل قاعدة مجاناً من الأنواع التالية: MySQL، MariaDB، MongoDB، وPostgreSQL.
  * [xata.io](https://xata.io) - قاعدة بيانات بدون خادم مع بحث وتحليلات مدمجة قوية. واجهة برمجة تطبيقات واحدة، مكتبات عملاء آمنة من النوع، ومُحسنة لتدفق تطويرك. الطبقة المجانية للأبد مناسبة للمطورين الهواة وتشمل ثلاث وحدات Xata، يرجى مراجعة الموقع لتعريف الوحدة.
  * [8base.com](https://www.8base.com/) - منصة تطوير كاملة منخفضة التعليمات البرمجية لجافاسكريبت مبنية على MySQL وGraphQL وواجهة خلفية بدون خادم. تمكنك من بناء تطبيقات الويب بسرعة باستخدام منشئ التطبيقات والتوسع السريع. الطبقة المجانية تشمل: 2500 صف، 500 تخزين، 1 جيجابايت/ساعة حوسبة بدون خادم، و5 مستخدمين لتطبيق العميل.
  * [Nile](https://www.thenile.dev/) — منصة Postgres لتطبيقات B2B. قواعد بيانات غير محدودة، متاحة دائماً بدون توقف، 1 جيجابايت تخزين (إجمالي)، 50 مليون رمز استعلام، مقياس تلقائي، تضمينات متجهة غير محدودة



**[⬆️ العودة إلى الأعلى](#table-of-contents)**

## الأنفاق وخوادم WebRTC وWeb Socket وخدمات التوجيه الأخرى

  * [Pinggy](https://pinggy.io) — روابط عامة لـ localhost بأمر واحد، بدون تحميلات. أنفاق HTTPS / TCP / TLS. خطة مجانية بمدة نفق 60 دقيقة.
  * [conveyor.cloud](https://conveyor.cloud/) — إضافة لـ Visual Studio تكشف IIS Express للشبكة المحلية أو عبر نفق إلى رابط عام.
  * [Hamachi](https://www.vpn.net/) — خدمة VPN مستضافة من LogMeIn تمكنك من توسيع الشبكات بشكل آمن للفرق الموزعة مع خطة مجانية تسمح بعدد غير محدود من الشبكات حتى 5 أشخاص لكل شبكة
  * [Mirna Sockets](https://mirna.cloud/) - منصة Socket كخدمة مجانية تعطيك رابط wss:// عند نشر كود خادم Web Socket الخاص بك وتسمح أيضاً بمراقبة أدائه.
  * [localhost.run](https://localhost.run/) — كشف الخوادم المحلية عبر نفق لرابط عام.
  * [localtunnel](https://theboroer.github.io/localtunnel-www/) — كشف الخوادم المحلية عبر نفق لرابط عام. نسخة مستضافة مجانية، و[مفتوحة المصدر](https://github.com/localtunnel/localtunnel).
  * [ngrok.com](https://ngrok.com/) — كشف الخوادم المحلية عبر نفق لرابط عام.
  * [cname.dev](https://cname.dev/) — خدمة عكسية ديناميكية مجانية وآمنة.
  * [serveo](https://serveo.net/) — كشف الخوادم المحلية على الإنترنت. بدون تثبيت أو تسجيل. نطاق فرعي مجاني، بدون حدود.
  * [Radmin VPN](https://www.radmin-vpn.com/) — ربط عدة حواسيب عبر VPN لتمكين شبكة شبيهة بـ LAN. عدد غير محدود من النظراء. (بديل Hamachi)
  * [segment.com](https://segment.com/) — مركز لترجمة وتوجيه الأحداث إلى خدمات الطرف الثالث الأخرى. 100,000 حدث شهرياً مجاناً
  * Google STUN — [stun:stun.l.google.com:19302](stun:stun.l.google.com:19302)
  * Twilio STUN — [stun:global.stun.twilio.com:3478?transport=udp](stun:global.stun.twilio.com:3478?transport=udp)
  * [Tailscale](https://tailscale.com/) — VPN بدون إعداد، يستخدم بروتوكول WireGuard مفتوح المصدر. متوفر على MacOS وiOS وWindows وLinux وAndroid. خطة مجانية للاستخدام الشخصي مع 100 جهاز وثلاثة مستخدمين.
  * [webhookrelay.com](https://webhookrelay.com) — إدارة وتصحيح وتوزيع ووكيل جميع Webhooks الخاصة بك إلى وجهات عامة أو داخلية (مثل localhost). أيضاً، كشف الخوادم في شبكة خاصة عبر نفق عبر نقطة نهاية HTTP عامة (`https://yoursubdomain.webrelay.io <----> http://localhost:8080`).
  * [Hookdeck](https://hookdeck.com/pricing) — تطوير واختبار ومراقبة Webhooks من أي مكان. 100 ألف طلب و100 ألف محاولة شهرياً مع احتفاظ لمدة ثلاثة أيام.
  * [Xirsys](https://www.xirsys.com/pricing/) — استخدام STUN غير محدود + 500 ميجابايت من نقل TURN شهرياً، عرض نطاق محدود، منطقة جغرافية واحدة.
  * [ZeroTier](https://www.zerotier.com) — إيثرنت افتراضي كخدمة مفتوح المصدر. شبكات مشفرة من طرف إلى طرف غير محدودة مع 25 عميل في الخطة المجانية. عملاء للحاسوب/الجوال/NA؛ واجهة ويب لإعداد قواعد التوجيه والموافقة على العملاء الجدد على الشبكات الخاصة
  * [LocalXpose](https://localxpose.io) — وكيل عكسي يمكّنك من كشف خوادم localhost على الإنترنت. الخطة المجانية بمدة نفق 15 دقيقة.
  * [Traefik-Hub](https://traefik.io/traefik-hub/) - نشر الخدمات المحلية عبر نفق لرابط عام مخصص وتأمينها بالتحكم في الوصول. مجاني لـ 5 خدمات في عنقود واحد.
  * [Expose](https://expose.dev/) - كشف المواقع المحلية عبر أنفاق آمنة. الخطة المجانية تشمل خادم أوروبي، نطاقات فرعية عشوائية، ومستخدم واحد.
  * [btunnel](https://www.btunnel.in/) — كشف localhost وخادم tcp المحلي على الإنترنت. الخطة المجانية تشمل خادم ملفات، رؤوس http مخصصة للطلب والاستجابة، حماية المصادقة الأساسية ومدة نفق ساعة واحدة.

**[⬆️ العودة إلى الأعلى](#table-of-contents)**

## تتبع المشاكل وإدارة المشاريع

  * [acunote.com](https://www.acunote.com/) — برنامج إدارة مشاريع وSCRUM مجاني حتى 5 أعضاء بالفريق
  * [asana.com](https://asana.com/) — مجاني للمشاريع الخاصة مع متعاونين
  * [Backlog](https://backlog.com) — كل ما يحتاجه فريقك لإطلاق مشاريع رائعة في منصة واحدة. الخطة المجانية تقدم مشروعاً واحداً مع عشرة مستخدمين و100 ميجابايت تخزين.
  * [Basecamp](https://basecamp.com/personal) - قوائم المهام، إدارة الإنجازات، مراسلة شبيهة بالمنتديات، مشاركة ملفات، وتتبع الوقت. حتى 3 مشاريع، 20 مستخدماً، و1 جيجابايت تخزين.
  * [bitrix24.com](https://www.bitrix24.com/) — أداة إنترانت وإدارة مشاريع. الخطة المجانية تشمل 5 جيجابايت لعدد غير محدود من المستخدمين.
  * [cacoo.com](https://cacoo.com/) — رسوم بيانية آنية عبر الإنترنت: مخططات تدفق، UML، شبكات. حتى 15 مستخدم/رسم، 25 ورقة مجاناً
  * [Chpokify](https://chpokify.com/) — تقدير سباقات الفرق بطريقة Planning Poker توفر الوقت. مجاني حتى 5 مستخدمين، تكاملات Jira مجانية، مكالمات فيديو غير محدودة، فرق غير محدودة، جلسات غير محدودة.
  * [clickup.com](https://clickup.com/) — إدارة مشاريع. مجاني، نسخة مدفوعة مع تخزين سحابي. تطبيقات جوال وتكامل مع Git متوفرة.
  * [Clockify](https://clockify.me) - متتبع وقت وتطبيق جداول يتيح لك تتبع ساعات العمل عبر المشاريع. مستخدمون غير محدودين، مجاني للأبد.
  * [Cloudcraft](https://cloudcraft.co/) — صمم مخطط بنية احترافية في دقائق مع مصمم Cloudcraft البصري، محسن لـ AWS مع مكونات ذكية تعرض بيانات حية أيضاً. الخطة المجانية تقدم مخططات خاصة غير محدودة لمستخدم واحد.
  * [Codegiant](https://codegiant.io) — إدارة مشاريع مع استضافة مستودع وCI/CD. الخطة المجانية تقدم مستودعات غير محدودة، مشاريع ومستندات مع 5 أعضاء فريق. 500 دقيقة CI/CD شهرياً. 30000 دقيقة تشغيل كود بدون خادم شهرياً و1 جيجابايت مساحة مستودع.
  * [Confluence](https://www.atlassian.com/software/confluence) - أداة تعاون محتوى من Atlassian لمساعدة الفرق على التعاون ومشاركة المعرفة بكفاءة. خطة مجانية حتى 10 مستخدمين.
  * [contriber.com](https://www.contriber.com/) — منصة إدارة مشاريع قابلة للتخصيص، خطة بداية مجانية، خمس مساحات عمل
  * [Crosswork](https://crosswork.app/) - منصة إدارة مشاريع متعددة الاستخدامات. مجانًا لما يصل إلى 3 مشاريع، عدد غير محدود من المستخدمين، 1 جيجابايت تخزين.
  * [diagrams.net](https://app.diagrams.net/) — إنشاء الرسوم البيانية عبر الإنترنت وتخزينها محليًا في Google Drive أو OneDrive أو Dropbox. جميع الميزات ومستويات التخزين متاحة مجانًا.
  * [freedcamp.com](https://freedcamp.com/) - مهام، مناقشات، معالم، تتبع الوقت، تقويم، ملفات ومدير كلمات المرور. خطة مجانية مع مشاريع غير محدودة، مستخدمين غير محدودين، وتخزين ملفات غير محدود.
  * [easyretro.io](https://www.easyretro.io/) — أداة بسيطة وبديهية لاستعراض السبرينت. الخطة المجانية توفر ثلاث لوحات عامة واستبيان واحد لكل لوحة شهريًا.
  * [GForge](https://gforge.com) — مجموعة أدوات إدارة المشاريع وتتبع المشكلات للمشاريع المعقدة مع خيارات ذاتية الاستضافة وساس. خطة SaaS المجانية لأول خمسة مستخدمين مجانًا ومجانية للمشاريع مفتوحة المصدر.
  * [gleek.io](https://www.gleek.io) — أداة مجانية لتحويل الوصف إلى رسومات بيانية للمطورين. أنشئ مخططات UML غير رسمية أو مخططات كائنات أو علاقات باستخدام الكلمات المفتاحية.
  * [GraphQL Inspector](https://github.com/marketplace/graphql-inspector) - يخرج GraphQL Inspector قائمة بالتغييرات بين مخططين GraphQL. كل اختلاف موضح بدقة ومصنف كمؤثر، أو غير مؤثر، أو خطير.
  * [huboard.com](https://huboard.com/) — إدارة مشاريع فورية لمشاكل GitHub الخاصة بك، مجانًا للمشاريع مفتوحة المصدر.
  * [Hygger](https://hygger.io) — منصة إدارة مشاريع. الخطة المجانية توفر مستخدمين، مشاريع ولوحات غير محدودة مع 100 ميجابايت تخزين.
  * [Instabug](https://instabug.com) — حزمة شاملة للإبلاغ عن الأخطاء والتعليقات داخل التطبيقات للهواتف الذكية. الخطة المجانية لتطبيق واحد وعضو واحد.
  * [WishKit](https://wishkit.io) — جمع تعليقات المستخدمين داخل التطبيق لنظام iOS/macOS وتحديد أولويات الميزات بناءً على تصويت المستخدمين. الخطة المجانية لتطبيق واحد.
  * [Ilograph](https://www.ilograph.com/)  — رسوم تفاعلية تُمكّن المستخدمين من رؤية البنية التحتية من زوايا وتفاصيل متعددة. يمكن التعبير عن الرسومات من خلال الكود. المستوى المجاني يتيح رسومات خاصة غير محدودة بحد أقصى 3 مشاهدين.
  * [Jira](https://www.atlassian.com/software/jira) — أداة متقدمة لإدارة مشاريع تطوير البرمجيات مستخدمة في العديد من الشركات. خطة مجانية حتى 10 مستخدمين.
  * [kanbanflow.com](https://kanbanflow.com/) — إدارة مشاريع قائمة على اللوحات. مجاني مع نسخة مميزة بميزات إضافية.
  * [kanbantool.com](https://kanbantool.com/) — إدارة مشاريع قائمة على لوحة كانبان. الخطة المجانية توفر لوحتين ومستخدمين بدون مرفقات أو ملفات.
  * [kan.bn](https://kan.bn/) - تطبيق كانبان قوي ومرن يساعدك على تنظيم العمل وتتبع التقدم وتحقيق النتائج، الكل في مكان واحد. الخطة المجانية لمستخدم واحد مع لوحات وقوائم وبطاقات غير محدودة.
  * [Kitemaker.co](https://kitemaker.co) - تعاون خلال جميع مراحل تطوير المنتج وتتبع العمل عبر Slack وDiscord وFigma وGithub. مستخدمون ومساحات غير محدودة. خطة مجانية حتى 250 عنصر عمل.
  * [Kiter.app](https://www.kiter.app/) - دع أي شخص ينظم بحثه عن عمل ويتتبع المقابلات والفرص والعلاقات. تطبيق ويب قوي وإضافة كروم. مجاني بالكامل.
  * [Kumu.io](https://kumu.io/)  — خرائط العلاقات مع تحريك، زخرفة، فلاتر، تجميع، استيراد جداول بيانات، وغيرها. المستوى المجاني يسمح بمشاريع عامة غير محدودة. حجم المخطط غير محدود. مشاريع خاصة مجانية للطلاب. وضع الحماية متوفر إذا كنت تفضل عدم نشر الملف (رفع، تحرير، تنزيل، حذف).
  * [Linear](https://linear.app/) — متتبع مشاكل بواجهة مبسطة. مجاني لأعضاء غير محدودين، حتى 10 ميجابايت حجم رفع للملف، 250 مشكلة (باستثناء الأرشيف).
  * [leiga.com](https://www.leiga.com/) — ليغا هو منتج SaaS يستخدم الذكاء الاصطناعي لإدارة مشاريعك تلقائيًا، يساعد فريقك على التركيز وإطلاق إمكانات هائلة، ويضمن تقدم مشاريعك حسب الخطة. مجاني حتى 10 مستخدمين، 20 حقل مخصص، 2 جيجابايت مساحة تخزين، تسجيل فيديو مع ذكاء اصطناعي حتى 5 دقائق/فيديو، 20 عملية أتمتة لكل مستخدم شهريًا.
  * [Lucidchart](https://www.lucidchart.com/) - أداة رسم بياني عبر الإنترنت مع ميزات التعاون. خطة مجانية مع ثلاثة مستندات قابلة للتعديل، 100 قالب احترافي، وميزات تعاون أساسية.
  * [MeisterTask](https://www.meistertask.com/) — إدارة مهام عبر الإنترنت للفرق. مجاني حتى 3 مشاريع وعدد غير محدود من أعضاء المشروع.
  * [MeuScrum](https://www.meuscrum.com/en) - أداة سكرم مجانية عبر الإنترنت مع لوحة كانبان.
  * [nTask](https://www.ntaskmanager.com/) — برنامج إدارة مشاريع يمكّن الفرق من التعاون والتخطيط والتحليل وإدارة المهام اليومية. الخطة الأساسية مجانية للأبد مع 100 ميجابايت تخزين وخمسة مستخدمين/فرق عمل. مساحات عمل، اجتماعات، مهام، جداول زمنية وتتبع مشاكل غير محدود.
  * [Ora](https://ora.pm/) - إدارة مهام رشيقة وتعاون فريق. مجاني حتى 3 مستخدمين والملفات محدودة إلى 10 ميجابايت.
  * [pivotaltracker.com](https://www.pivotaltracker.com/) — مجاني لمشاريع عامة غير محدودة ومشروعين خاصين مع ثلاثة مستخدمين نشطين (قراءة وكتابة) وعدد غير محدود من المستخدمين السلبيين (قراءة فقط).
  * [plan.io](https://plan.io/) — إدارة مشاريع مع استضافة مستودعات وخيارات أخرى. مجاني لمستخدمين اثنين مع عشرة عملاء و500 ميجابايت تخزين.
  * [Plane](https://plane.so/) - Plane هو أداة بسيطة وقابلة للتوسيع مفتوحة المصدر لإدارة المشاريع والمنتجات. مجاني لأعضاء غير محدودين، حتى 5 ميجابايت رفع ملفات، 1000 مشكلة.
  * [planitpoker.com](https://www.planitpoker.com/) — أداة تقدير (بلانينج بوكر) عبر الإنترنت مجانًا.
  * [point.poker](https://www.point.poker/) - بلانينج بوكر عبر الإنترنت (أداة تقدير معتمدة على الإجماع). مجاني لمستخدمين، فرق، جلسات، جولات وتصويتات غير محدودة. لا حاجة للتسجيل.
  * [ScrumFast](https://www.scrumfast.com) - لوحة سكرم بواجهة بديهية جدًا، مجاني حتى 5 مستخدمين.
  * [Shake](https://www.shakebugs.com/) - أداة للإبلاغ عن الأخطاء والتعليقات داخل التطبيقات للهواتف الذكية. خطة مجانية، عشرة تقارير أخطاء لكل تطبيق/شهر.
  * [Shortcut](https://shortcut.com/) - منصة إدارة مشاريع. مجاني حتى 10 مستخدمين للأبد.
  * [Tadum](https://tadum.app) - تطبيق أجندة ومحاضر اجتماعات مصمم للاجتماعات الدورية، مجاني للفرق حتى 10 أعضاء.
  * [taiga.io](https://taiga.io/) — منصة إدارة مشاريع للشركات الناشئة والمطورين الرشيقين، مجانية للمصدر المفتوح.
  * [Tara AI](https://tara.ai/) — خدمة إدارة سبرينت بسيطة. الخطة المجانية بها مهام وسبرينت ومساحات عمل غير محدودة بدون حدود للمستخدمين.
  * [targetprocess.com](https://www.targetprocess.com/) — إدارة مشاريع بصرية من كانبان وسكرم إلى أي عملية تشغيلية تقريبًا. مجاني لمستخدمين غير محدودين وحتى 1000 كيان بيانات {[تفاصيل أكثر](https://www.targetprocess.com/pricing/)}
  * [taskade.com](https://www.taskade.com/) — قوائم مهام وتخطيطات فرق تعاونية في الوقت الحقيقي. الخطة المجانية بها مساحة عمل واحدة مع مهام ومشاريع غير محدودة؛ 1 جيجابايت تخزين ملفات؛ سجل مشاريع أسبوع واحد؛ وخمسة مشاركين في اجتماع الفيديو.
  * [taskulu.com](https://taskulu.com/) — إدارة مشاريع قائمة على الأدوار. مجاني حتى 5 مستخدمين. تكامل مع GitHub/Trello/Dropbox/Google Drive.
  * [Teaminal](https://www.teaminal.com) - أداة ستاند أب، ريترو، وتخطيط سبرينت للفرق البعيدة. مجاني حتى 15 مستخدمًا.
  * [teamwork.com](https://teamwork.com/) — إدارة مشاريع ودردشة فرق. مجاني لخمسة مستخدمين ومشروعين. خطط مميزة متاحة.
  * [teleretro.com](https://www.teleretro.com/) — أداة ريترو بسيطة وممتعة مع كاسرات الجليد وصور GIF وإيموجي. الخطة المجانية تشمل ثلاث جلسات ريترو وأعضاء غير محدودين.
  * [testlio.com](https://testlio.com/) — تتبع المشكلات، إدارة الاختبارات ومنصة اختبار بيتا. مجاني للاستخدام الخاص.
  * [terrastruct.com](https://terrastruct.com/) — صانع رسوم بيانية عبر الإنترنت مخصص لهندسة البرمجيات. المستوى المجاني حتى 4 طبقات لكل رسم.
  * [todoist.com](https://todoist.com/) — إدارة مهام فردية وتعاونية. الخطة المجانية بها: 5 مشاريع نشطة، خمسة مستخدمين لكل مشروع، رفع ملفات حتى 5 ميجابايت، ثلاث فلاتر، وأسبوع واحد من سجل النشاط.
  * [trello.com](https://trello.com/) — إدارة مشاريع قائمة على اللوحات. لوحات شخصية غير محدودة، 10 لوحات فريق.
  * [Tweek](https://tweek.so/) — تقويم مهام وأعمال أسبوعي بسيط.
  * [ubertesters.com](https://ubertesters.com/) — منصة اختبار، تكامل واختبار جماعي، مشروعين، خمسة أعضاء.
  * [Wikifactory](https://wikifactory.com/) — خدمة تصميم المنتجات مع مشاريع، VCS ومشكلات. الخطة المجانية توفر مشاريع ومتعاونين غير محدودين و3 جيجابايت تخزين.
  * [Yodiz](https://www.yodiz.com/) — تطوير رشيق وتتبع مشكلات. مجاني حتى 3 مستخدمين، مشاريع غير محدودة.
  * [YouTrack](https://www.jetbrains.com/youtrack/buy/#edition=incloud) — استضافة مجانية لـ YouTrack (InCloud) للمشاريع مفتوحة المصدر والخاصة (مجاني حتى 3 مستخدمين). يشمل تتبع الوقت ولوحات رشيقة.
  * [zenhub.com](https://www.zenhub.com) — حل إدارة المشاريع الوحيد داخل GitHub. مجاني للمستودعات العامة، المصدر المفتوح، والمنظمات غير الربحية.
  * [zenkit.com](https://zenkit.com) — أداة إدارة مشاريع وتعاون. مجاني حتى 5 أعضاء، 5 جيجابايت مرفقات.
  * [Zube](https://zube.io) — إدارة مشاريع مع خطة مجانية لـ 4 مشاريع و4 مستخدمين. تكامل مع GitHub متوفر.
  * [Toggl](https://toggl.com/) — يوفر أداتين مجانيتين للإنتاجية. [Toggl Track](https://toggl.com/track/) لإدارة الوقت والتتبع مع خطة مجانية تتضمن تتبع وتقارير غير محدودة مصممة للمستقلين. بها سجلات، مشاريع، عملاء، علامات، تقارير وغير ذلك غير محدود. و [Toggl Plan](https://toggl.com/plan/) لتخطيط المهام مع خطة مجانية للمطورين الفرديين بمهام، معالم، وجداول زمنية غير محدودة.
  * [Sflow](https://sflow.io) — أداة لإدارة المشاريع مبنية لتطوير البرمجيات الرشيقة، التسويق، المبيعات ودعم العملاء، خاصة لمشاريع التعاون الخارجي وعبر المنظمات. خطة مجانية حتى 3 مشاريع وخمسة أعضاء.
  * [Pulse.red](https://pulse.red) — متعقب وقت وتسجيل جداول زمنية للمشاريع مجاني وبسيط.

**[⬆️ العودة إلى الأعلى](#table-of-contents)**

## التخزين ومعالجة الوسائط

  * [AndroidFileHost](https://androidfilehost.com/) - منصة مشاركة ملفات مجانية بسرعة غير محدودة، نطاق ترددي غير محدود، عدد ملفات غير محدود، عدد تنزيلات غير محدود، إلخ. موجه بشكل أساسي لملفات تطوير أندرويد مثل APK وبناء الرومات والتعديلات، إلخ. لكن يبدو أنه يقبل أي ملفات أخرى أيضًا.
  * [borgbase.com](https://www.borgbase.com/) — استضافة نسخ احتياطي خارجية بسيطة وآمنة لـ Borg Backup. 10 جيجابايت مساحة نسخ احتياطي مجانية ومستودعين.
  * [icedrive.net](https://www.icedrive.net/) - خدمة تخزين سحابي بسيطة. 10 جيجابايت تخزين مجاني.
  * [sync.com](https://www.sync.com/) - خدمة تخزين سحابي مشفر من الطرف للطرف. 5 جيجابايت تخزين مجاني.
  * [pcloud.com](https://www.pcloud.com/) - خدمة تخزين سحابي. حتى 10 جيجابايت تخزين مجاني.
  * [sirv.com](https://sirv.com/) — شبكة CDN ذكية للصور مع تحسين وتغيير حجم الصور أثناء الطيران. المستوى المجاني يشمل 500 ميجابايت تخزين و2 جيجابايت نطاق ترددي.
  * [cloudimage.io](https://www.cloudimage.io/en/home) — خدمة تحسين صور وCDN كاملة مع أكثر من 1500 نقطة توزيع حول العالم. مجموعة متنوعة من وظائف تغيير حجم الصور، ضغطها، ووضع علامات مائية. إضافات مفتوحة المصدر للصور المتجاوبة، إنشاء صور 360 وتحرير الصور. خطة شهرية مجانية مع 25 جيجابايت نقل CDN، 25 جيجابايت تخزين مؤقت وتحويلات غير محدودة.
  * [cloudinary.com](https://cloudinary.com/) — رفع الصور، التحويلات القوية، التخزين والتوصيل للمواقع والتطبيقات، مع مكتبات لـ Ruby وPython وJava وPHP وObjective-C وغيرها. المستوى المجاني يشمل 25 رصيد شهريًا. كل رصيد يساوي 1000 تحويل صورة، 1 جيجابايت تخزين، أو 1 جيجابايت استخدام CDN.
  * [embed.ly](https://embed.ly/) — يوفر APIs لتضمين الوسائط في صفحات الويب، وتغيير حجم الصور بشكل متجاوب، واستخلاص العناصر من صفحة ويب. مجاني حتى 5000 عنوان URL/شهريًا بسرعة 15 طلب/ثانية.
  * [filestack.com](https://www.filestack.com/) — اختيار الملفات، تحويلها وتوصيلها، مجاني لـ 250 ملف، 500 تحويل، و3 جيجابايت نطاق ترددي.
  * [file.io](https://www.file.io) - 2 جيجابايت تخزين ملفات. يتم حذف الملف تلقائيًا بعد تحميل واحد. REST API للتفاعل مع التخزين. حد طلب واحد في الدقيقة.
  * [freetools.site](https://freetools.site/) — أدوات مجانية عبر الإنترنت. تحويل أو تحرير المستندات، الصور، الصوت، الفيديو والمزيد.
  * [GoFile.io](https://gofile.io/) - منصة مجانية لمشاركة وتخزين الملفات يمكن استخدامها من خلال واجهة الويب أو API. حجم ملف غير محدود، نطاق ترددي غير محدود، عدد تنزيلات غير محدود، إلخ. لكن يُحذف الملف عند عدم نشاطه (عدم التنزيل لأكثر من عشرة أيام).
  * [gumlet.com](https://www.gumlet.com/) — استضافة، معالجة وبث الصور والفيديو عبر CDN. يقدم مستوى مجاني سخي بـ 250 جيجابايت/شهر للفيديو و30 جيجابايت/شهر للصور.
  * [image-charts.com](https://www.image-charts.com/) — إنشاء مخططات صور غير محدودة مع علامة مائية.
  * [Imgbot](https://github.com/marketplace/imgbot) — Imgbot روبوت ودود يقوم بتحسين صورك ويوفر وقتك. الصور المحسنة تعني أحجام ملفات أقل دون التضحية بالجودة. مجاني للمصدر المفتوح.
  * [ImgBB](https://imgbb.com/) — ImgBB خدمة استضافة صور غير محدودة. اسحب وأسقط صورتك في أي مكان على الشاشة. حد 32 ميجابايت لكل صورة. استلم روابط مباشرة للصورة، BBCode وصور مصغرة HTML بعد الرفع. تسجيل الدخول لرؤية سجل الرفع.
  * [imgen](https://www.jitbit.com/imgen/) - API مجاني غير محدود لإنشاء صور أغلفة اجتماعية، بدون علامة مائية.
  * [imgix](https://www.imgix.com/) - تخزين، إدارة وتوزيع الصور عبر CDN. الخطة المجانية تشمل 1000 صورة أصلية، تحويلات غير محدودة و100 جيجابايت نطاق ترددي.
  * [kraken.io](https://kraken.io/) — تحسين الصور لأداء الموقع كخدمة، خطة مجانية حتى 1 ميجابايت حجم الملف.
  * [kvstore.io](https://www.kvstore.io/) — خدمة تخزين بيانات مفتاحية. المستوى المجاني يسمح بـ 100 مفتاح، 1 كيلوبايت/مفتاح، 100 استدعاء/ساعة.
  * [npoint.io](https://www.npoint.io/) — تخزين JSON مع تحرير مخططات تعاوني.
  * [nitropack.io](https://nitropack.io/) - تسريع سرعة موقعك تلقائيًا مع تحسين كامل للواجهة الأمامية (تخزين مؤقت، صور وتحسين كود، CDN). مجاني حتى 5000 مشاهدة صفحة شهريًا.
  * [otixo.com](https://www.otixo.com/) — تشفير، مشاركة، نسخ، ونقل جميع ملفات التخزين السحابي من مكان واحد. الخطة الأساسية توفر نقل ملفات غير محدود بحد أقصى 250 ميجابايت للملف وتسمح بخمسة ملفات مشفرة.
  * [packagecloud.io](https://packagecloud.io/) — مستودعات حزم مستضافة لـ YUM، APT، RubyGem وPyPI. خطط مجانية محدودة وخطط مفتوحة المصدر متاحة عبر الطلب.
  * [getpantry.cloud](https://getpantry.cloud/) — API تخزين بيانات JSON بسيطة مثالية للمشاريع الشخصية، الهاكاثون، وتطبيقات الجوال!
  * [Pinata IPFS](https://pinata.cloud) — Pinata هي أسهل طريقة لرفع وإدارة الملفات على IPFS. واجهة مستخدم ودية وAPI تجعلها أسهل خدمة تثبيت IPFS للمنصات والمبدعين والمجمعين. 1 جيجابايت تخزين مجاني مع إمكانية الوصول إلى الـ API.
  * [placekitten.com](https://placekitten.com/) — خدمة سريعة وبسيطة للحصول على صور قطط لاستخدامها كعناصر نائبة.
  * [plot.ly](https://plot.ly/) — رسم ومشاركة بياناتك. المستوى المجاني يشمل ملفات عامة غير محدودة وعشرة ملفات خاصة.
  * [podio.com](https://podio.com/) — يمكنك استخدام Podio مع فريق يصل إلى خمسة أشخاص وتجربة ميزات الخطة الأساسية باستثناء إدارة المستخدمين.
  * [QRME.SH](https://qrme.sh) - مولد رموز QR جماعي سريع وجميل - بدون تسجيل دخول، بدون علامة مائية، بدون إعلانات. حتى 100 عنوان URL لكل تصدير جماعي.
  * [QuickChart](https://quickchart.io) — توليد مخططات صور، رسوم بيانية، ورموز QR قابلة للتضمين.
  * [redbooth.com](https://redbooth.com) — مزامنة ملفات P2P، مجاني حتى مستخدمين اثنين.
  * [resmush.it](https://resmush.it) — reSmush.it هو API مجاني يقدم تحسين الصور. تم تطبيق reSmush.it في أشهر أنظمة إدارة المحتوى مثل WordPress وDrupal وMagento. reSmush.it هو أكثر APIs تحسين الصور استخدامًا مع أكثر من سبعة مليارات صورة تمت معالجتها، وما زال مجانيًا بالكامل.
  * [Shotstack](https://shotstack.io) - API لإنشاء وتحرير الفيديو على نطاق واسع. مجاني حتى 20 دقيقة فيديو مصمم شهريًا.
  * [tinypng.com](https://tinypng.com/) — API لضغط وتغيير حجم صور PNG وJPEG، يقدم 500 ضغط مجاني كل شهر.
  * [transloadit.com](https://transloadit.com/) — معالجة رفع وترميز الفيديو والصوت والصور والمستندات. مجاني للمصدر المفتوح، الجمعيات الخيرية والطلاب عبر GitHub Student Developer Pack. التطبيقات التجارية تحصل على 2 جيجابايت مجانًا للتجربة.
* [twicpics.com](https://www.twicpics.com) - صور متجاوبة كخدمة. يوفر شبكة CDN للصور، وواجهة برمجة تطبيقات لمعالجة الوسائط، ومكتبة للواجهة الأمامية لأتمتة تحسين الصور. الخدمة مجانية حتى 3 جيجابايت من الحركة/شهريًا.
* [uploadcare.com](https://uploadcare.com/hub/developers/) — Uploadcare توفر خط معالجة وسائط مع مجموعة أدوات متقدمة تعتمد على أحدث الخوارزميات. جميع الميزات متاحة للمطورين مجانًا بالكامل: واجهة برمجة رفع الملفات وواجهة المستخدم، شبكة CDN للصور وخدمات الأصل، التوصيل التكيفي، والضغط الذكي. المستوى المجاني يشمل 3000 تحميل، 3 جيجابايت حركة، و3 جيجابايت تخزين.
* [imagekit.io](https://imagekit.io) – شبكة CDN للصور مع تحسين تلقائي، وتحويل في الوقت الحقيقي، وتخزين يمكن دمجه مع الإعداد الحالي خلال دقائق. الخطة المجانية تشمل حتى 20 جيجابايت من حركة البيانات شهريًا.
* [internxt.com](https://internxt.com) – Internxt Drive هي خدمة تخزين ملفات قائمة على خصوصية مطلقة وأمان غير قابل للتنازل. سجل واحصل على 10 جيجابايت مجانًا، للأبد!
* [degoo.com](https://degoo.com/) – تخزين سحابي قائم على الذكاء الاصطناعي مع ما يصل إلى 20 جيجابايت مجانًا، ثلاثة أجهزة، 5 جيجابايت مكافأة إحالة (90 يومًا من عدم نشاط الحساب).
* [MConverter.eu](https://mconverter.eu/) – تحويل ملفات بالجملة. يدعم العديد من صيغ الملفات، بما في ذلك الجديدة مثل [AVIF](https://mconverter.eu/convert/to/avif/). استخراج جميع إطارات الصور من الفيديوهات. مجاني حتى عشرة ملفات بحجم 100 ميجابايت يوميًا، معالجة دفعتين في كل مرة.
* [ImageEngine](https://imageengine.io/) – ImageEngine هي شبكة CDN للصور سهلة الاستخدام على مستوى العالم. إعداد في أقل من 60 ثانية. دعم AVIF وJPEGXL، إضافات لووردبريس، Magento، React، Vue والمزيد. احصل على حساب مطور مجاني [هنا](https://imageengine.io/developer-program/).
* [DocsParse](https://docsparse.com/) – معالجة ملفات PDF وصور مدعومة بالذكاء الاصطناعي GPT وتحويلها إلى بيانات منظمة بصيغ JSON، CSV، EXCEL. 30 رصيد مجاني كل شهر.
* [VaocherApp QR Code Generator](https://www.vaocherapp.com/qr-code-generator) – أنشئ رموز QR مخصصة بسهولة لبطاقات الهدايا، قسائم الهدايا، والعروض الترويجية. يدعم التخصيص، اللون، الشعار...
* [LibreQR](https://libreqr.com) — مولد رموز QR مجاني يركز على الخصوصية وبدون تتبع. مجاني للاستخدام بدون جمع بيانات.

**[⬆️ العودة إلى الأعلى](#table-of-contents)**

## التصميم وواجهة المستخدم

* [AllTheFreeStock](https://allthefreestock.com) - قائمة منتقاة من الصور والمقاطع الصوتية والفيديوهات المجانية.
* [Float UI](https://floatui.com/) - أداة تطوير ويب مجانية لإنشاء مواقع حديثة ومتجاوبة ذات تصميم أنيق بسرعة، حتى لغير المصممين.
* [Ant Design Landing Page](https://landing.ant.design/) - توفر صفحة الهبوط من Ant Design قالبًا مبنيًا بمكونات الحركة من Ant Motion. تحتوي على قوالب رئيسية غنية، ويمكن تنزيل حزمة الكود واستخدامها بسرعة. يمكنك أيضًا استخدام المحرر لبناء صفحتك المخصصة بسرعة.
* [Backlight](https://backlight.dev/) — منصة تطوير كاملة مع التعاون بين المطورين والمصممين في صميمها، حيث تبني الفرق وتوثق وتنشر وتوسع وتحافظ على أنظمة التصميم. الخطة المجانية تتيح حتى 3 محررين للعمل على نظام تصميم واحد مع عدد غير محدود من المشاهدين.
* [BoxySVG](https://boxy-svg.com/app) — تطبيق ويب مجاني يمكن تثبيته لرسم SVG وتصديرها بصيغ SVG، PNG، jpeg وغيرها.
* [Carousel Hero](https://carouselhero.com/) - أداة مجانية عبر الإنترنت لإنشاء دوارات وسائل التواصل الاجتماعي.
* [Circum Icons](https://circumicons.com) - أيقونات مفتوحة المصدر متناسقة مثل SVG لـ React، Vue، وSvelte.
* [clevebrush.com](https://www.cleverbrush.com/) — تطبيق مجاني لتصميم الرسومات / تجميع الصور. كما يقدمون تكاملًا مدفوعًا كعنصر مدمج.
* [cloudconvert.com](https://cloudconvert.com/) — تحويل أي شيء إلى أي شيء. يدعم 208 صيغة بما في ذلك الفيديوهات وصور GIF.
* [CodeMyUI](https://codemyui.com) - مجموعة مختارة يدويًا من إلهام تصميم الويب وواجهة المستخدم مع مقتطفات كود.
* [ColorKit](https://colorkit.co/) - إنشاء لوحات ألوان عبر الإنترنت أو استلهم من أفضل اللوحات.
* [coolors](https://coolors.co/) - مولد لوحات ألوان. مجاني.
* [CMYK Pantone](https://www.cmyktopantone.com/) - تحويل قيم CMYK إلى أقرب ألوان بانتون ونماذج ألوان أخرى بسهولة ومجانًا خلال ثوانٍ.
* [Branition](https://branition.com/colors) - لوحات ألوان مختارة يدويًا ومناسبة للعلامات التجارية.
* [css-gradient.com](https://www.css-gradient.com/) - أداة مجانية لتوليد تدرجات CSS مخصصة ومتوافقة مع جميع المتصفحات بسرعة. بصيغ RGB وHEX.
* [easyvectors.com](https://easyvectors.com/) — EasyVectors.com هو مخزون مجاني لفن SVG المتجهي. حمّل أفضل الرسومات المتجهة مجانًا.
* [figma.com](https://www.figma.com) — أداة تصميم وتعاون عبر الإنترنت للفرق؛ الخطة المجانية تشمل ملفات غير محدودة ومشاهدين مع حد أقصى لمحررين (2) وثلاثة مشاريع.
* [Flyon UI](https://flyonui.com/)- أسهل مكتبة مكونات لـ Tailwind CSS.
* [framer.com](https://www.framer.com/) - Framer يساعدك في تكرار وأتمتة أفكار الواجهات لتطبيقك أو موقعك أو منتجك القادم، بدءًا بتصميمات قوية. لأي شخص يقيّم Framer كأداة نماذج أولية احترافية: مشاهدون غير محدودين، حتى 2 محرر، وحتى 3 مشاريع.
* [freeforcommercialuse.net](https://freeforcommercialuse.net/) — صور خالية من القلق مع نموذج/إفراج ملكية للاستخدام التجاري.
* [Gradientos](https://www.gradientos.app) - يجعل اختيار التدرجات اللونية سريعًا وسهلًا.
* [Icon Horse](https://icon.horse) – احصل على أعلى دقة لأيقونة favicon لأي موقع ويب من خلال API بسيطة.
* [Iconoir](https://iconoir.com) – مكتبة أيقونات مفتوحة المصدر تضم آلاف الأيقونات، تدعم React، React Native، Flutter، Vue، Figma، وFramer.
* [Icons8](https://icons8.com) — أيقونات، رسومات توضيحية، صور، موسيقى، وأدوات تصميم. الخطة المجانية توفر صيغ محدودة بدقة منخفضة. يجب وضع رابط إلى Icons8 عند استخدام مواردهم.
* [landen.co](https://www.landen.co) — أنشئ، عدل، وانشر مواقع وصفحات هبوط جميلة لشركتك الناشئة بدون كود. المستوى المجاني يتيح لك موقعًا واحدًا قابلًا للتخصيص بالكامل ومنشور على الويب.
* [Quant Ux](https://quant-ux.com/) - أداة نماذج وتصميم أولي. - مجانية بالكامل ومفتوحة المصدر أيضًا.
* [lensdump.com](https://lensdump.com/) - استضافة صور سحابية مجانية.
* [Lorem Picsum](https://picsum.photos/) - أداة مجانية وسهلة الاستخدام وصور بديلة أنيقة. بعد رابط الموقع، أضف حجم الصورة المطلوب (عرض وارتفاع) وستحصل على صورة عشوائية.
* [LottieFiles](https://lottiefiles.com/) - أكبر منصة على الإنترنت لأصغر صيغة رسوم متحركة في العالم للمصممين والمطورين وغيرهم. الوصول إلى أدوات ورسوم Lottie وإضافات لأندرويد وiOS والويب.
* [MagicPattern](https://www.magicpattern.design/tools) — مجموعة من مولدات وخلفيات CSS & SVG وأدوات للتدرجات، الأنماط، والأشكال العشوائية.
* [marvelapp.com](https://marvelapp.com/) — تصميم، نماذج أولية، وتعاون؛ الخطة المجانية محدودة لمستخدم واحد ومشروع واحد.
* [Mindmup.com](https://www.mindmup.com/) — خرائط ذهنية غير محدودة مجانًا وتخزينها في السحابة. خرائطك الذهنية متاحة في كل مكان، فورًا، من أي جهاز.
* [Mockplus iDoc](https://www.mockplus.com/idoc) - أداة قوية لتعاون التصميم وتسليم العمل. الخطة المجانية تشمل ثلاثة مستخدمين وخمسة مشاريع مع جميع الميزات متاحة.
* [mockupmark.com](https://mockupmark.com/create/free) — أنشئ نماذج واقعية للقمصان والملابس لوسائل التواصل الاجتماعي والتجارة الإلكترونية، 40 نموذج مجاني.
* [Mossaik](https://mossaik.app) - مولد صور SVG مجاني مع أدوات مختلفة مثل الأمواج، والأشكال، والأنماط.
* [movingpencils.com](https://movingpencils.com) — محرر متجهات سريع عبر المتصفح. مجاني بالكامل.
* [Octopus.do](https://octopus.do) — منشئ خرائط موقع مرئي. أنشئ هيكل موقعك في الوقت الحقيقي وشاركه بسرعة للتعاون مع فريقك أو عملائك.
* [Pencil](https://github.com/evolus/pencil) - أداة تصميم مفتوحة المصدر باستخدام Electron.
* [Penpot](https://penpot.app) - أداة تصميم ونماذج أولية على الويب ومفتوحة المصدر. تدعم SVG. مجانية بالكامل.
* [pexels.com](https://www.pexels.com/) - صور مخزنة مجانية للاستخدام التجاري. يوجد API مجاني يسمح بالبحث عن الصور عبر الكلمات المفتاحية.
* [photopea.com](https://www.photopea.com) — محرر تصميم متقدم مجاني عبر الإنترنت بواجهة تشبه Adobe Photoshop ويدعم PSD وXCF وSketch (Adobe Photoshop، Gimp وSketch App).
* [pixlr.com](https://pixlr.com/) — محرر صور عبر الإنترنت مجاني بمستوى الأدوات التجارية.
* [Plasmic](https://www.plasmic.app/) - أداة تصميم ويب سريعة وسهلة وقوية ومنشئ صفحات يندمج مع الكود الخاص بك. أنشئ صفحات متجاوبة أو مكونات معقدة؛ ويمكنك التمديد بالكود ونشرها على مواقع وتطبيقات الإنتاج.
* [Pravatar](https://pravatar.cc/) - أنشئ صورة رمزية عشوائية/وهمية يمكن ربطها مباشرة في موقعك/تطبيقك.
* [Proto.io](https://www.proto.io) - أنشئ نماذج أولية تفاعلية بالكامل بدون برمجة. الخطة المجانية متاحة بعد انتهاء الفترة التجريبية، وتشمل مستخدمًا واحدًا، مشروعًا واحدًا، خمسة نماذج أولية، 100 ميجابايت تخزين، ومعاينة لتطبيق proto.io.
* [resizeappicon.com](https://resizeappicon.com/) — خدمة بسيطة لتغيير حجم وإدارة أيقونات تطبيقك.
* [Rive](https://rive.app) — أنشئ وصدّر رسومات متحركة رائعة لأي منصة. مجاني للأفراد للأبد. الخدمة هي محرر يستضيف جميع الرسومات على خوادمهم. كما يوفرون برامج تشغيل للعديد من المنصات لتشغيل الرسومات التي يتم إنشاؤها باستخدام Rive.
* [storyset.com](https://storyset.com/) — أنشئ رسومات توضيحية مخصصة مجانية مذهلة لمشروعك باستخدام هذه الأداة.
* [smartmockups.com](https://smartmockups.com/) — أنشئ نماذج منتجات، 200 نموذج مجاني.
* [Shadcn Studio](https://shadcnstudio.com/theme-editor) — استعرض تغييرات السمة عبر مكونات وتصميمات مختلفة.
* [Tailark](https://tailark.com/) - مجموعة من كتل واجهة المستخدم الحديثة والمتجاوبة والمصممة مسبقًا لمواقع التسويق.
* [tabler-icons.io](https://tabler-icons.io/) — أكثر من 1500 أيقونة SVG مجانية قابلة للتحرير والنسخ واللصق.
* [tweakcn](https://tweakcn.com/) — سمات جميلة لـ shadcn/ui. خصص الألوان والطباعة والمزيد في الوقت الحقيقي.
* [UI Avatars](https://ui-avatars.com/) - أنشئ صورًا رمزية بالأحرف الأولى من الأسماء. يمكن ربط الروابط مباشرة في موقعك/تطبيقك. يدعم معلمات التكوين عبر الرابط.
* [unDraw](https://undraw.co/) - مجموعة متجددة باستمرار من صور SVG الجميلة التي يمكنك استخدامها مجانًا بالكامل وبدون نسب.
* [unsplash.com](https://unsplash.com/) - صور مخزنة مجانية لأغراض تجارية وغير تجارية (ترخيص افعل ما تشاء).
* [vectr.com](https://vectr.com/) — تطبيق تصميم مجاني للويب وسطح المكتب.
* [walkme.com](https://www.walkme.com/) — منصة توجيه وتفاعل من فئة المؤسسات، الخطة المجانية تشمل ثلاث جولات إرشادية حتى 5 خطوات لكل جولة.
* [Webflow](https://webflow.com) - منشئ مواقع WYSIWYG مع رسوم متحركة واستضافة مواقع. مجاني لمشروعين.
* [Updrafts.app](https://updrafts.app) - منشئ مواقع WYSIWYG لتصميمات تعتمد على tailwindcss. مجاني للاستخدام غير التجاري.
* [whimsical.com](https://whimsical.com/) - مخططات تدفق تعاونية، ونماذج أولية، وملاحظات لاصقة وخرائط ذهنية. أنشئ حتى 4 لوحات مجانية.
* [Zeplin](https://zeplin.io/) — منصة تعاون بين المصمم والمطور. اعرض التصميمات، والموارد، وأدلة الأنماط. مجاني لمشروع واحد.
* [Pixelixe](https://pixelixe.com/) — أنشئ وحرر رسومات وصور جذابة وفريدة عبر الإنترنت.
* [Responsively App](https://responsively.app) - أداة مجانية للمطورين لتطوير تطبيقات ويب متجاوبة بشكل أسرع وأكثر دقة.
* [SceneLab](https://scenelab.io) - محرر رسومات عبر الإنترنت مع مجموعة متزايدة من قوالب التصميم المجانية.
* [xLayers](https://xlayers.dev) - استعرض وحول ملفات تصميم Sketch إلى Angular وReact وVue وLitElement وStencil وXamarin والمزيد (مفتوح المصدر ومجاني على https://github.com/xlayers/xlayers)
* [Grapedrop](https://grapedrop.com/) — منشئ صفحات ويب قوية ومتجاوبة ومحسّنة لمحركات البحث، مبني على إطار GrapesJS. مجاني لأول خمس صفحات، مجالات مخصصة غير محدودة، جميع الميزات، وسهولة الاستخدام.
* [Mastershot](https://mastershot.app) - محرر فيديو مجاني بالكامل عبر المتصفح. بدون علامة مائية، حتى دقة 1080p.
* [Unicorn Platform](https://unicornplatform.com/) - منشئ صفحات هبوط مع استضافة بسهولة. موقع واحد مجانًا.
* [SVGmix.com](https://www.svgmix.com/) - مستودع ضخم يضم أكثر من 300 ألف أيقونة SVG مجانية، مجموعات، وشعارات علامات تجارية. يحتوي على برنامج تحرير متجه بسيط في المتصفح لتعديل الملفات بسرعة.
* [svgrepo.com](https://www.svgrepo.com/) - استكشف وابحث عن الأيقونات أو المتجهات الأنسب لمشاريعك باستخدام مكتبات متجهة متنوعة. حمّل ملفات SVG مجانية للاستخدام التجاري.
* [haikei.app](https://www.haikei.app/) - Haikei هو تطبيق ويب لإنشاء أشكال وخلفيات وأنماط SVG فريدة وجاهزة للاستخدام مع أدوات التصميم وسير العمل الخاصة بك.
* [Canva](https://canva.com) - أداة تصميم مجانية عبر الإنترنت لإنشاء محتوى بصري.
* [Superdesigner](https://superdesigner.co) - مجموعة من أدوات التصميم المجانية لإنشاء خلفيات وأنماط وأشكال وصور فريدة ببضع نقرات فقط.
* [TeleportHQ](https://teleporthq.io/) - منصة تصميم وتطوير الواجهة الأمامية منخفضة الكود. TeleportHQ هي منصة تعاونية لإنشاء ونشر مواقع ثابتة بدون رأس فورًا. ثلاثة مشاريع مجانية، عدد غير محدود من المتعاونين، وتصدير الكود مجاني.
* [vector.express](https://vector.express) — حوّل ملفات AI, CDR, DWG, DXF, EPS, HPGL, PDF, PLT, PS وSVG بسرعة وسهولة.
* [Vertopal](https://www.vertopal.com) - Vertopal منصة مجانية عبر الإنترنت لتحويل الملفات إلى صيغ مختلفة. يشمل محولات للمطورين مثل JPG إلى SVG، GIF إلى APNG، PNG إلى WEBP، JSON إلى XML، وغيرها.
* [okso.app](https://okso.app) - تطبيق رسم عبر الإنترنت بواجهة بسيطة. يسمح بإنشاء رسومات وملاحظات مرئية سريعة. تصدير الرسومات إلى PNG وJPG وSVG وWEBP. يمكن تثبيته كتطبيق ويب تقدمي. مجاني للجميع (لا يحتاج تسجيل).
* [Wdrfree SVG](https://wdrfree.com/free-svg) - ملفات SVG مجانية باللونين الأسود والأبيض للقص.
* [Lucide](https://lucide.dev) - مجموعة أدوات SVG مجانية وقابلة للتخصيص ومتناسقة للأيقونات.
* [Logo.dev](https://www.logo.dev) - واجهة برمجة تطبيقات لشعارات الشركات مع أكثر من 44 مليون علامة تجارية، سهلة الاستخدام عبر رابط. أول 10,000 طلب API مجانية.
* [MDBootstrap](https://mdbootstrap.com/) - مجاني للاستخدام الشخصي والتجاري، مجموعات واجهة مستخدم Bootstrap, Angular, React, وVue مع أكثر من 700 مكون، قوالب رائعة، تثبيت في دقيقة، دروس موسعة ومجتمع ضخم.
* [TW Elements](https://tw-elements.com/) - مكونات Bootstrap مجانية معاد إنشاؤها بـ Tailwind CSS، مع تصميم أفضل ووظائف أكثر.
* [DaisyUI](https://daisyui.com/) -- مجاني. "استخدم Tailwind CSS لكن اكتب أسماء فئات أقل" ويقدم مكونات مثل الأزرار.
  * [Scrollbar.app](https://scrollbar.app) -- تطبيق ويب مجاني بسيط لتصميم أشرطة التمرير المخصصة للويب.
  * [css.glass](https://css.glass/) -- تطبيق ويب مجاني لإنشاء تصاميم زجاجية باستخدام CSS.
  * [hypercolor.dev](https://hypercolor.dev/) -- مجموعة من تدرجات الألوان لتايلويند CSS بالإضافة إلى مولدات متنوعة لإنشاء تدرجاتك الخاصة.
  * [iconify.design](https://icon-sets.iconify.design/) -- مجموعة تضم أكثر من 100 حزمة أيقونات بواجهة موحدة. يتيح البحث عن الأيقونات عبر الحزم وتصدير الأيقونات كـ SVG أو لأطر عمل الويب الشهيرة.
  * [NextUI](https://nextui.org/) -- مجاني. مكتبة واجهة مستخدم جميلة وسريعة وعصرية لـ React و Next.js.
  * [Glyphs](https://glyphs.fyi/) -- مجاني، أقوى الأيقونات على الويب، نظام تصميم مفتوح المصدر وقابل للتحرير بالكامل.
  * [ShadcnUI](https://ui.shadcn.com/) -- مكونات مصممة بشكل جميل يمكنك نسخها ولصقها في تطبيقاتك. سهلة الوصول. قابلة للتخصيص. مفتوحة المصدر.
  * [HyperUI](https://www.hyperui.dev/) -- مكونات تايلويند CSS مجانية ومفتوحة المصدر.
  * [Calendar Icons Generator](https://calendariconsgenerator.app/) -- توليد أيقونات فريدة لسنة كاملة بنقرة واحدة، مجاناً بالكامل.
  * [Image BG Blurer](https://imagebgblurer.com/) -- إنشاء خلفية مشوشة لصورة باستخدام مصدر الصورة نفسها، لأدوات مثل Notion وTrello وJira وغيرها.
  * [Webstudio](https://webstudio.is/) -- بديل مفتوح المصدر لـ Webflow. الخطة المجانية تتيح مواقع غير محدودة على نطاقهم. خمسة مواقع بنطاقات مخصصة. عشرة آلاف مشاهدة صفحة شهرياً. 2 جيجابايت تخزين للملفات.
  * [Nappy](https://nappy.co/) -- صور جميلة لأشخاص سود وبنيين، مجاناً للاستخدام التجاري والشخصي.
  * [Tailkits](https://tailkits.com/) -- مجموعة من قوالب ومكونات وأدوات تايلويند، بالإضافة إلى مولدات مفيدة للشيفرات، والشبكات، وظلال الصناديق، وأكثر.
  * [Tailcolors](https://tailcolors.com/) -- لوحة ألوان جميلة لتايلويند CSS v4. معاينة فورية ونسخ لفئة اللون المناسبة.
  * [Excalidraw](https://excalidraw.com/) -- صفحة ويب مجانية للرسم عبر الإنترنت مع دعم الحفظ محلياً والتصدير.
  * [Lunacy](https://icons8.com/lunacy) -- أداة تصميم جرافيكي مجانية مع دعم العمل دون اتصال، أصول مدمجة (أيقونات، صور، رسومات)، وتعاون في الوقت الحقيقي. الخطة المجانية تتضمن 10 مستندات سحابية، وسجل لـ 30 يوماً، وأصول منخفضة الدقة، وأدوات تصميم أساسية.

**[⬆️ العودة للأعلى](#table-of-contents)**

## إلهام التصميم

  * [awwwards.](https://www.awwwards.com/) - [أفضل المواقع] عرض لأفضل المواقع المصممة (يتم التصويت عليها من قبل المصممين).
  * [Behance](https://www.behance.net/) - [عرض التصميمات] مكان لعرض أعمال المصممين مع تصنيفات لمشاريع UI/UX.
  * [dribbble](https://dribbble.com/) - [عرض التصميمات] مصدر إلهام فريد للتصميم، غالباً ليست من تطبيقات حقيقية.
  * [Landings](https://landings.dev/) - [لقطات شاشة للويب] العثور على أفضل صفحات الهبوط للإلهام في التصميم بناءً على تفضيلاتك.
  * [Lapa Ninja](https://www.lapa.ninja/) - [صفحات هبوط / أطقم UI / لقطات شاشة ويب] معرض يضم أفضل 6025 مثالاً لصفحات الهبوط، كتب مجانية للمصممين، وأطقم UI مجانية من الإنترنت.
  * [LovelyLanding.net](https://www.lovelylanding.net/) - [تصاميم صفحات هبوط] لقطات شاشة لصفحات الهبوط يتم تحديثها باستمرار. تتضمن لقطات لسطح المكتب، والأجهزة اللوحية، والجوال.
  * [Mobbin](https://mobbin.design/) - [لقطات شاشة للجوال] وفر ساعات من البحث في UI & UX مع مكتبتنا التي تضم أكثر من 50,000 لقطة شاشة قابلة للبحث بالكامل لتطبيقات الجوال.
  * [Uiland Design](https://uiland.design/) - [لقطات شاشة للجوال] استكشف تصاميم واجهات الجوال والويب من الشركات الرائدة في إفريقيا والعالم.
  * [Mobile Patterns](https://www.mobile-patterns.com/) - [لقطات شاشة للجوال] مكتبة إلهام تصميم تضم أفضل أنماط UI/UX (iOS و Android) للمصممين والمطورين وصانعي المنتجات.
  * [Page Flows](https://pageflows.com/) - [فيديوهات ولقطات شاشة للجوال/الويب] فيديوهات لعمليات كاملة عبر العديد من تطبيقات الجوال والويب. يشمل لقطات شاشة أيضاً. قابل للبحث والفهرسة بدرجة عالية.
  * [Screenlane](https://screenlane.com/) - [لقطات شاشة للجوال] مصدر إلهام ومتابعة لآخر اتجاهات تصميم UI لتطبيقات الويب والجوال. يمكن التصفية حسب النمط والتطبيق.
  * [scrnshts](https://scrnshts.club/) - [لقطات شاشة للجوال] مجموعة مختارة من أفضل لقطات شاشة لتصاميم التطبيقات في المتاجر.
  * [Refero](https://refero.design/) - [لقطات شاشة ويب] مجموعة مؤرشفة وقابلة للبحث من مراجع التصميم من تطبيقات الويب الرائعة.

**[⬆️ العودة للأعلى](#table-of-contents)**

## عرض البيانات على الخرائط

  * [IP Geolocation](https://ipgeolocation.io/) — خطة مطور مجانية متاحة بـ 30 ألف طلب شهرياً.
  * [carto.com](https://carto.com/) — إنشاء خرائط وواجهات برمجة تطبيقات جغرافية من بياناتك وبيانات عامة.
  * [Clockwork Micro](https://clockworkmicro.com/) — أدوات خرائط تعمل بكفاءة. خمسون ألف استعلام مجاني شهرياً (بلاطات خرائط، db2vector، ارتفاعات).
  * [developers.arcgis.com](https://developers.arcgis.com) — واجهات برمجة التطبيقات وأطر العمل للخرائط وتخزين البيانات الجغرافية وتحليلها، التكويد الجغرافي، التوجيه، وأكثر عبر الويب وسطح المكتب والجوال. مليونان بلاطة خرائط مجانية، 20,000 تكويد جغرافي غير مخزن، 20,000 مسار بسيط، 5,000 حساب وقت قيادة، و5 جيجابايت تخزين بلاطات+بيانات شهرياً.
  * [Foursquare](https://developer.foursquare.com/) - اكتشاف المواقع، البحث عن الأماكن، ومحتوى ذكي من Places API و Pilgrim SDK.
  * [geoapify.com](https://www.geoapify.com/) - بلاطات خرائط متجهة ونقطية، تكويد جغرافي، أماكن، توجيه، APIs للعزل. ثلاثة آلاف طلب مجاني يومياً.
  * [geocod.io](https://www.geocod.io/) — تكويد جغرافي عبر API أو رفع ملفات CSV. ألفان وخمسمائة استعلام مجاني يومياً.
  * [geocodify.com](https://geocodify.com/) — تكويد جغرافي وتحليل نصوص جغرافية عبر API أو رفع ملفات CSV. 10 آلاف طلب مجاني شهرياً.
  * [geojs.io](https://www.geojs.io/) - واجهة REST/JSON/JSONP عالية التوفر للبحث عن الموقع الجغرافي بواسطة IP.
  * [giscloud.com](https://www.giscloud.com/) — تصور، تحليل، ومشاركة البيانات الجغرافية عبر الإنترنت.
  * [graphhopper.com](https://www.graphhopper.com/) — حزمة مطور مجانية للتوجيه، تحسين المسارات، مصفوفة المسافات، التكويد الجغرافي، وتطابق الخرائط.
  * [here](https://developer.here.com/) — واجهات APIs وأطر عمل للخرائط وتطبيقات المواقع الذكية. 250 ألف معاملة شهرياً مجاناً.
  * [locationiq.com](https://locationiq.com/) — APIs للتكويد الجغرافي، الخرائط، والتوجيه. خمسة آلاف طلب يومياً مجاناً.
  * [mapbox.com](https://www.mapbox.com/) — خرائط وخدمات جغرافية وSDKs لعرض بيانات الخرائط.
  * [maptiler.com](https://www.maptiler.com/cloud/) — خرائط متجهة، خدمات خرائط وSDKs لعرض الخرائط. بلاطات متجهة مجانية بتحديثات أسبوعية وأربعة أنماط للخرائط.
  * [nominatim.org](https://nominatim.org/) — خدمة التكويد الجغرافي المجانية من OpenStreetMap، توفر بحثاً عالمياً عن العناوين وإمكانيات التكويد العكسي.
  * [nextbillion.ai](https://nextbillion.ai/) - خدمات متعلقة بالخرائط: التكويد الجغرافي، الملاحة (الاتجاهات، التوجيه، تحسين المسارات، مصفوفة المسافات)، SDK للخرائط (متجه، ثابت، SDK للجوال). [مجاني مع حصة محددة](https://nextbillion.ai/pricing) لكل خدمة.
  * [opencagedata.com](https://opencagedata.com) — API للتكويد الجغرافي يجمع بين OpenStreetMap ومصادر جغرافية مفتوحة أخرى. ألفان وخمسمائة استعلام مجاني يومياً.
  * [osmnames](https://osmnames.org/) — تكويد جغرافي، نتائج البحث مرتبة حسب شعبية صفحة ويكيبيديا ذات الصلة.
  * [positionstack](https://positionstack.com/) - تكويد جغرافي مجاني للأماكن والإحداثيات العالمية. 25,000 طلب شهرياً للاستخدام الشخصي.
  * [stadiamaps.com](https://stadiamaps.com/) — بلاطات خرائط، توجيه، ملاحة، وAPIs جغرافية أخرى. ألفان وخمسمائة مشاهدة خرائط وطلب API يومياً للاستخدام غير التجاري والاختبار.
  * [maps.stamen.com](http://maps.stamen.com/) - بلاطات خرائط واستضافة بلاطات مجانية.
  * [ipstack](https://ipstack.com/) - تحديد موقع وزوار المواقع بواسطة عنوان الـ IP.
  * [Geokeo api](https://geokeo.com) - API للتكويد الجغرافي مع تصحيح اللغة وغيرها. تغطية عالمية. 2,500 طلب يومي مجاني.

**[⬆️ العودة للأعلى](#table-of-contents)**

## نظام بناء الحزم

  * [build.opensuse.org](https://build.opensuse.org/) — خدمة بناء الحزم لأنظمة تشغيل متعددة (SUSE، EL، Fedora، Debian، إلخ).
  * [copr.fedorainfracloud.org](https://copr.fedorainfracloud.org) — خدمة بناء RPM تعتمد على Mock لفيدورا وEL.
  * [help.launchpad.net](https://help.launchpad.net/Packaging) — خدمة بناء أوبونتو ودبيان.

**[⬆️ العودة للأعلى](#table-of-contents)**

## بيئات التطوير المتكاملة وتحرير الشيفرة

  * [3v4l](https://3v4l.org/) - منصة أونلاين مجانية لكتابة أكواد PHP ومشاركتها وتشغيلها على أكثر من 300 إصدار PHP.
  * [Android Studio](https://developer.android.com/studio) — أسرع الأدوات لبناء تطبيقات على جميع أنواع أجهزة أندرويد. بيئة تطوير مفتوحة المصدر مجانية للجميع وأفضل خيار لتطوير تطبيقات أندرويد. متوفر لويندوز، ماك، لينكس، وحتى ChromeOS!
  * [AndroidIDE](https://m.androidide.com/) — بيئة تطوير متكاملة مفتوحة المصدر لإنشاء تطبيقات أندرويد حقيقية تعتمد على Gradle على أجهزة أندرويد.
  * [Apache Netbeans](https://netbeans.apache.org/) — بيئة تطوير، منصة أدوات وإطار عمل للتطبيقات.
  * [apiary.io](https://apiary.io/) — تصميم API تعاوني مع محاكاة فورية وتوليد وثائق (مجاني لعدد غير محدود من مخططات API وعدد غير محدود من المستخدمين مع حساب مدير واحد ووثائق مستضافة).
  * [BBEdit](https://www.barebones.com/) - محرر شهير وقابل للتوسعة لنظام macOS. الوضع المجاني يوفر [مجموعة ميزات قوية](https://www.barebones.com/products/bbedit/comparison.html) ومسار ترقية للميزات المتقدمة.
  * [Binder](https://mybinder.org/) - تحويل مستودع Git إلى مجموعة من دفاتر الملاحظات التفاعلية. خدمة عامة مجانية.
  * [BlueJ](https://bluej.org) — بيئة تطوير جافا مجانية صممت للمبتدئين، يستخدمها الملايين حول العالم. مدعوم من Oracle وواجهة رسومية بسيطة لمساعدة المبتدئين.
  * [Bootify.io](https://bootify.io/) - مولد تطبيقات Spring Boot مع قاعدة بيانات مخصصة وREST API.
  * [Brackets](http://brackets.io/) - محرر نصوص مفتوح المصدر صمم خصيصاً لتطوير الويب. خفيف، سهل الاستخدام، وقابل للتخصيص بدرجة كبيرة.
  * [cacher.io](https://www.cacher.io) — منظم قصاصات الشيفرات مع تسميات ودعم لأكثر من 100 لغة برمجة.
  * [Code::Blocks](https://codeblocks.org) — بيئة تطوير مجانية لـ Fortran و C/C++. مفتوحة المصدر وتعمل على ويندوز وماك ولينكس.
  * [Cody](https://sourcegraph.com/cody) - مساعد برمجة بالذكاء الاصطناعي مجاني يمكنه كتابة (كتل الشيفرة، الإكمال التلقائي، اختبارات الوحدة)، وفهم (معرفة بكامل قاعدة الشيفرة)، وإصلاح، والبحث في شيفرتك. متوفر لـ VS Code، JetBrains وأونلاين.
  * [codiga.io](https://codiga.io/) — مساعد برمجة يتيح البحث، تعريف، وإعادة استخدام قصاصات الشيفرة مباشرة داخل بيئة التطوير. مجاني للأفراد والمؤسسات الصغيرة.
  * [codesnip.com.br](https://codesnip.com.br) — مدير بسيط لقصاصات الشيفرات مع تصنيفات، بحث، ووسوم. مجاني وغير محدود.
  * [cocalc.com](https://cocalc.com/) — (سابقاً SageMathCloud على cloud.sagemath.com) — تعاون حسابي في السحابة. وصول عبر المتصفح إلى نظام Ubuntu كامل مع تعاون مدمج والكثير من البرامج المجانية للرياضيات، والعلوم، وعلوم البيانات، مثبت مسبقاً: Python، LaTeX، Jupyter Notebooks، SageMath، scikitlearn، إلخ.
  * [code.cs50.io](https://code.cs50.io/) - نسخة ويب من Visual Studio Code لطلاب CS50 وأساتذتهم مبنية على GitHub Codespaces.
  * [codepen.io](https://codepen.io/) — CodePen ملعب للجانب الأمامي من الويب.
  * [codesandbox.io](https://codesandbox.io/) — ملعب أونلاين لـ React، Vue، Angular، Preact، وأكثر.
  * [Components.studio](https://webcomponents.dev/) - برمجة المكونات في عزلة، استعراضها في قصص، اختبارها، ونشرها على npm.
  * [Eclipse Che](https://www.eclipse.org/che/) - بيئة تطوير ويب وأصلية لـ Kubernetes لفرق المطورين مع دعم لعدة لغات برمجة. مفتوحة المصدر ومدفوعة من المجتمع. نسخة أونلاين مستضافة من Red Hat متوفرة على [workspaces.openshift.com](https://workspaces.openshift.com/).
  * [fakejson.com](https://fakejson.com/) — FakeJSON يساعدك في توليد بيانات وهمية بسرعة باستخدام API خاصته. فقط اطلب ما تريد وكيف تريده وسيعيد لك النتيجة بصيغة JSON. سرع عملية تطوير الأفكار واختبرها ببيانات وهمية.
  * [GetVM](https://getvm.io) — آلات افتراضية فورية مجانية على لينكس وIDEs في شريط كروم الجانبي. الخطة المجانية تتضمن 5 آلات افتراضية يومياً.
  * [GitPod](https://www.gitpod.io) — بيئات تطوير جاهزة وفورية لمشاريع GitHub. الخطة المجانية تشمل 50 ساعة شهريًا.
  * [ide.goorm.io](https://ide.goorm.io) goormIDE هو بيئة تطوير متكاملة سحابية كاملة. يدعم لغات متعددة، حاوية مبنية على لينكس عبر طرفية ويب متقدمة، توجيه المنافذ، رابط مخصص، تعاون ودردشة في الوقت الحقيقي، مشاركة الروابط، دعم Git/Subversion. هناك العديد من الميزات الأخرى (الخطة المجانية تتضمن 1GB RAM و10GB تخزين لكل حاوية، و5 فتحات للحاويات).
  * [JDoodle](https://www.jdoodle.com) — مترجم ومحرر على الإنترنت لأكثر من 60 لغة برمجة مع خطة مجانية لترجمة أكواد REST API حتى 200 رصيد في اليوم.
  * [jetbrains.com](https://jetbrains.com/products.html) — أدوات إنتاجية وبيئات تطوير وأدوات نشر (مثل [IntelliJ IDEA](https://www.jetbrains.com/idea/)، [PyCharm](https://www.jetbrains.com/pycharm/) وغيرها). ترخيص مجاني للطلاب والمعلمين والمشاريع مفتوحة المصدر والمجموعات.
  * [jsbin.com](https://jsbin.com) — JS Bin هو مساحة تجريبية وموقع لمشاركة أكواد الويب الأمامية (HTML، CSS، وJavaScript). يدعم أيضًا Markdown وJade وSass.
  * [jsfiddle.net](https://jsfiddle.net/) — JS Fiddle مساحة تجريبية وموقع لمشاركة أكواد الويب الأمامية، مع دعم التعاون.
  * [JSONPlaceholder](https://jsonplaceholder.typicode.com/) بعض نقاط نهاية REST API التي تُرجع بيانات وهمية بصيغة JSON. الكود المصدري متوفر أيضًا إذا أردت تشغيل الخادم محليًا.
  * [Lazarus](https://www.lazarus-ide.org/) — لازاروس بيئة تطوير متوافقة مع دلفي متعددة المنصات لتطوير التطبيقات السريع.
  * [MarsCode](https://www.marscode.com/) - بيئة تطوير سحابية مجانية مدعومة بالذكاء الاصطناعي.
  * [micro-jaymock](https://micro-jaymock.now.sh/) - خدمة مصغرة لمحاكاة واجهات API وتوليد بيانات JSON وهمية.
  * [mockable.io](https://www.mockable.io/) — Mockable خدمة بسيطة وقابلة للتخصيص لمحاكاة واجهات RESTful API أو خدمات الويب SOAP. تتيح لك هذه الخدمة عبر الإنترنت تحديد نقاط نهاية REST API أو SOAP بسرعة وجعلها تُرجع بيانات JSON أو XML.
  * [mockaroo](https://mockaroo.com/) — Mockaroo تتيح لك توليد بيانات اختبار واقعية بصيغ CSV، JSON، SQL، وExcel. يمكنك أيضًا إنشاء محاكيات لواجهات API الخلفية.
  * [Mocklets](https://mocklets.com) - محاكي API HTTP يساعد في تسريع التطوير المتوازي وتحسين الاختبار، مع خطة مجانية مدى الحياة.
  * [Paiza](https://paiza.cloud/en/) — تطوير تطبيقات الويب عبر المتصفح دون الحاجة لأي إعداد. الخطة المجانية تقدم خادمًا واحدًا بعمر 24 ساعة و4 ساعات تشغيل يوميًا مع معالجين و2GB RAM و1GB تخزين.
  * [Prepros](https://prepros.io/) - Prepros يمكنه ترجمة Sass وLess وStylus وPug/Jade وHaml وSlim وCoffeeScript وTypeScript مباشرة، ويعيد تحميل المتصفحات ويسهل تطوير واختبار مواقعك. يمكنك أيضًا إضافة أدواتك بنقرات قليلة.
  * [Replit](https://replit.com/) — بيئة ترميز سحابية للعديد من لغات البرمجة.
  * [SoloLearn](https://code.sololearn.com) — مساحة برمجة سحابية مناسبة لتشغيل مقتطفات الكود. يدعم العديد من لغات البرمجة. لا يتطلب التسجيل لتشغيل الكود، لكن التسجيل ضروري لحفظ الكود على المنصة. كما يقدم دورات مجانية للمبتدئين والمبرمجين متوسطين المستوى.
  * [stackblitz.com](https://stackblitz.com/) — بيئة تطوير برمجية سحابية لإنشاء وتحرير ونشر تطبيقات متكاملة. يدعم جميع أطر العمل الشائعة المعتمدة على NodeJs. رابط سريع لإنشاء مشروع جديد: [https://node.new](https://node.new).
  * [Sublime Text](https://www.sublimetext.com/) - محرر نصوص شائع وقابل للتخصيص بشكل كبير يُستخدم للبرمجة وتحرير النصوص.
  * [Visual Studio Code](https://code.visualstudio.com/) - محرر كود مُعاد تعريفه ومحسّن لبناء وتصحيح تطبيقات الويب والسحابة الحديثة. من تطوير مايكروسوفت.
  * [Visual Studio Community](https://visualstudio.microsoft.com/vs/community/) — بيئة تطوير متكاملة كاملة الميزات مع آلاف الإضافات، تطوير تطبيقات متعددة المنصات (ملحقات مايكروسوفت متاحة للتحميل لـ iOS وAndroid)، تطوير سطح المكتب والويب والسحابة، دعم لغات متعددة (C#، C++، JavaScript، Python، PHP والمزيد).
  * [VSCodium](https://vscodium.com/) - توزيع ثنائي مجاني لمحرر VSCode من مايكروسوفت، مدفوع من المجتمع، بدون تتبع أو مراقبة.
  * [wakatime.com](https://wakatime.com/) — إحصائيات كمية عن نشاطك البرمجي باستخدام إضافات محرر النصوص، خطة محدودة مجانًا.
  * [Wave Terminal](https://waveterm.dev/) - Wave هو طرفية مفتوحة المصدر وعبر المنصات لتجارب عمل سلسة. يعرض أي شيء ضمن الجلسة، يحفظ الجلسات والسجل. مدعوم بمعايير الويب المفتوحة. يعمل على MacOS وLinux.
  * [WebComponents.dev](https://webcomponents.dev/) — بيئة تطوير داخل المتصفح لبرمجة مكونات الويب بشكل معزول مع 58 قالبًا متاحًا، ودعم القصص والاختبارات.
  * [PHPSandbox](https://phpsandbox.io/) — بيئة تطوير على الإنترنت للغة PHP
  * [WebDB](https://webdb.app) - بيئة تطوير قواعد بيانات مجانية وفعالة. تشمل اكتشاف الخادم، مخطط الكيانات والعلاقات (ERD)، مولد بيانات، ذكاء اصطناعي، مدير بنية NoSQL، إدارة إصدارات قواعد البيانات وغيرها الكثير.
  * [Zed](https://zed.dev/) - Zed محرر كود عالي الأداء ومتعدد اللاعبين من مطوري Atom وTree-sitter.
  * [OneCompiler](https://onecompiler.com/) - مترجم مجاني على الإنترنت يدعم أكثر من 70 لغة منها Java وPython وC++ وJavaScript.


**[⬆️ العودة للأعلى](#table-of-contents)**

## التحليلات، الأحداث والإحصاءات

  * [Dwh.dev](https://dwh.dev) - حل مراقبة بيانات السحابة (Snowflake). مجاني للاستخدام الشخصي.
  * [Hightouch](https://hightouch.com/) - منصة Reverse ETL لمزامنة بيانات العملاء من مستودع البيانات إلى أدوات CRM والتسويق والدعم. الخطة المجانية تتيح لك وجهة واحدة لمزامنة البيانات.
  * [Avo](https://avo.app/) — سير عمل مبسط لإصدار التحليلات. خطة تتبع مركزية، مكتبة تتبع آمنة بالأنواع، أدوات تصحيح داخل التطبيق، ومراقبة بيانات لاكتشاف كل مشكلات البيانات قبل الإصدار. مجاني لعضوين في مساحة العمل ونظرة رجعية لساعة واحدة من مراقبة البيانات.
  * [Branch](https://www.branch.io) — منصة تحليلات التطبيقات المحمولة. الخطة المجانية توفر حتى 10 آلاف مستخدم تطبيقات مع خدمات الربط العميق وغيرها.
  * [Census](https://www.getcensus.com/) — منصة Reverse ETL وتحليلات تشغيلية. مزامنة 10 حقول من مستودع بياناتك إلى أكثر من 60 خدمة SaaS مثل Salesforce وZendesk وAmplitude.
  * [Clicky](https://clicky.com) — منصة تحليلات المواقع. الخطة المجانية لموقع واحد مع 3000 مشاهدة تحليلية.
  * [Databox](https://databox.com) — رؤى وتحليلات أعمال بجمع منصات التحليلات وذكاء الأعمال الأخرى. الخطة المجانية توفر 3 مستخدمين ولوحات بيانات ومصادر بيانات. 11 مليون سجل بيانات تاريخية.
  * [Hitsteps.com](https://hitsteps.com/) — 2,000 مشاهدة صفحة شهريًا لموقع واحد
  * [amplitude.com](https://amplitude.com/) — مليون حدث شهريًا، حتى تطبيقين
  * [GoatCounter](https://www.goatcounter.com/) — منصة تحليلات ويب مفتوحة المصدر متاحة كخدمة مستضافة (مجانية للاستخدام غير التجاري) أو تطبيق مستضاف ذاتيًا. تهدف لتقديم تحليلات ويب سهلة وفعالة وصديقة للخصوصية كبديل لـ Google Analytics أو Matomo. الخطة المجانية للاستخدام غير التجاري وتشمل مواقع غير محدودة و6 أشهر احتفاظ بالبيانات و100 ألف مشاهدة صفحة شهريًا.
  * [Google Analytics](https://analytics.google.com/) — تحليلات جوجل
  * [MetricsWave](https://metricswave.com) — بديل Google Analytics صديق للخصوصية للمطورين. الخطة المجانية تتيح 20 ألف مشاهدة صفحة شهريًا بدون بطاقة ائتمان.
  * [Expensify](https://www.expensify.com/) — تقارير النفقات، سير موافقة تقارير شخصية مجانية
  * [getinsights.io](https://getinsights.io) - تحليلات تركز على الخصوصية وبدون ملفات تعريف الارتباط، مجانًا حتى 3 آلاف حدث شهريًا.
  * [heap.io](https://heap.io) — يلتقط تلقائيًا كل إجراء مستخدم في تطبيقات iOS أو الويب. مجاني حتى 10 آلاف جلسة شهرية.
  * [Hotjar](https://hotjar.com) — تحليلات وتقارير مواقع الويب. الخطة المجانية تتيح 2000 مشاهدة صفحة/يوم. 100 لقطة/يوم (الحد الأقصى 300). يمكن تخزين 3 خرائط حرارية لمدة 365 يومًا. أعضاء فريق غير محدودين. كذلك استبيانات داخل التطبيق ومستقلة، وودجات تعليقات مع لقطات شاشة. الخطة المجانية تتيح إنشاء 3 استبيانات و3 ودجات تعليقات وجمع 20 ردًا شهريًا.
  * [Keen](https://keen.io/) — تحليلات مخصصة لجمع البيانات وتحليلها وعرضها. 1,000 حدث شهريًا مجانًا
  * [Yandex.Datalens](https://datalens.yandex.com/) — خدمة ياندكس السحابية لعرض وتحليل البيانات. الخدمة مجانية بالكامل. لا يوجد قيود على عدد المستخدمين أو الطلبات.
  * [Yandex.Metrica](https://metrica.yandex.com/) — تحليلات مجانية غير محدودة
  * [Mixpanel](https://mixpanel.com/) — 100,000 مستخدم متتبع شهريًا، بيانات غير محدودة وأماكن غير محدودة، تخزين بيانات في الولايات المتحدة أو الاتحاد الأوروبي
  * [Moesif](https://www.moesif.com) — تحليلات API لـ REST وGraphQL. (مجاني حتى 500,000 مكالمة API شهريًا)
  * [optimizely.com](https://www.optimizely.com) — حل اختبار A/B، خطة بداية مجانية، موقع واحد، وتطبيق iOS وAndroid واحد
  * [Microsoft PowerBI](https://powerbi.com) — رؤى وتحليلات أعمال من مايكروسوفت. الخطة المجانية تتيح استخدامًا محدودًا مع مليون رخصة مستخدم.
  * [Row Zero](https://rowzero.io) - جدول بيانات متصل وسريع للغاية. اتصال مباشر بقواعد البيانات وS3 وواجهات API. استيراد وتحليل ورسم ومشاركة ملايين الصفوف فورًا. 3 دفاتر عمل مجانية مدى الحياة.
  * [sematext.com](https://sematext.com/cloud/) — مجاني حتى 50 ألف إجراء شهريًا، احتفاظ بالبيانات ليوم واحد، لوحات بيانات ومستخدمين غير محدودين، إلخ.
  * [Similar Web](https://similarweb.com) — تحليلات لتطبيقات الويب والهواتف المحمولة. الخطة المجانية تقدم خمس نتائج لكل مقياس، شهر واحد من بيانات تطبيقات الجوال و3 أشهر من بيانات المواقع.
  * [StatCounter](https://statcounter.com/) — تحليلات مشاهدات المواقع. الخطة المجانية لتحليل أحدث 500 زائر.
  * [Statsig](https://statsig.com) - منصة شاملة للتحليلات وتفعيل الميزات واختبار A/B. مجانية حتى مليون حدث شهريًا.
  * [Tableau Developer Program](https://www.tableau.com/developer) — ابتكر وطور واجعل Tableau يعمل بشكل مثالي لمؤسستك. البرنامج المجاني للمطورين يوفر ترخيص بيئة تطوير شخصية لـ Tableau Online. النسخة هي أحدث نسخة تجريبية حتى يختبر مطورو البيانات كل ميزة في هذه المنصة الممتازة.
  * [usabilityhub.com](https://usabilityhub.com/) — اختبار التصاميم والنماذج على أشخاص حقيقيين وتتبع الزوار. مجاني لمستخدم واحد مع اختبارات غير محدودة
  * [woopra.com](https://www.woopra.com/) — منصة تحليلات مستخدمين مجانية لـ 500 ألف إجراء واحتفاظ بيانات 90 يومًا وأكثر من 30 تكامل بنقرة واحدة.
  * [counter.dev](https://counter.dev) — تحليلات ويب بسيطة وصديقة للخصوصية. مجاني أو ادفع ما تريد كتبرع.
  * [PostHog](https://posthog.com) - مجموعة كاملة لتحليلات المنتجات مجانية حتى مليون حدث متتبع شهريًا. يوفر أيضًا استبيانات داخل التطبيق غير محدودة مع 250 ردًا شهريًا.
  * [Uptrace](https://uptrace.dev) - أداة تتبع موزع تساعد المطورين على تحديد الأعطال واكتشاف اختناقات الأداء. لديها خطة مجانية وتوفر اشتراك شخصي مجاني للمشاريع مفتوحة المصدر، ولديها نسخة مفتوحة المصدر.
  * [Microsoft Clarity](https://clarity.microsoft.com/) - Clarity أداة مجانية وسهلة الاستخدام تسجل كيف يستخدم الأشخاص موقعك فعليًا.
  * [Beampipe.io](https://beampipe.io) - Beampipe تحليلات ويب بسيطة وتركز على الخصوصية. مجانًا حتى 5 نطاقات و10 آلاف مشاهدة صفحة شهريًا.
  * [Aptabase](https://aptabase.com) — تحليلات مفتوحة المصدر وصديقة للخصوصية وبسيطة لتطبيقات الهواتف وسطح المكتب. SDKs لـ Swift وKotlin وReact Native وFlutter وElectron وغيرها. مجاني حتى 20,000 حدث شهريًا.
  * [Trackingplan](https://www.trackingplan.com/) - اكتشاف تلقائي لمشكلات تحليلات البيانات الرقمية وبيانات التسويق والبكسلات، والحفاظ على خطط تتبع محدثة، وتعزيز التعاون السلس. يمكن نشره في بيئة الإنتاج على زيارات حقيقية أو إضافة تغطية تحليلات لاختبارات الانحدار دون كتابة كود.
  * [LogSpot](https://logspot.io) - منصة تحليلات ويب ومنتج موحدة بالكامل، تشمل أدوات تحليلات مضمنة وروبوتات تلقائية (slack, telegram, وwebhooks). الخطة المجانية تشمل 10,000 حدث شهريًا.
  * [Umami](https://umami.is/) - بديل بسيط وسريع ومفتوح المصدر وصديق للخصوصية لـ Google Analytics.
  * [TrackWith Dicloud](https://dicloud.net/trackwith-privacy-focused-analytics/) - بديل مجاني خفيف الوزن ويركز على الخصوصية لـ Google Analytics. مشاهدات صفحات غير محدودة وزوار غير محدودين وخرائط حرارية وأهداف غير محدودة. مجاني حتى 3 نطاقات و600 إعادة تشغيل جلسة لكل نطاق.
  * [AppFit](https://appfit.io) - AppFit أداة شاملة للتحليلات وإدارة المنتجات لتسهيل الإدارة المتقاطعة للمنصات. الخطة المجانية تشمل 10,000 حدث شهريًا، سجل المنتج ورؤى أسبوعية.
  * [Seline](https://seline.so) - Seline تحليلات مواقع ومنتجات بسيطة وخاصة. بدون ملفات تعريف ارتباط، خفيفة، مستقلة. الخطة المجانية تشمل 3,000 حدث شهريًا وتوفر الوصول لجميع الميزات مثل لوحة التحكم ورحلات المستخدمين ومسارات التحويل والمزيد.
  * [Peasy](https://peasy.so) - Peasy أداة تحليلات خفيفة الوزن وتركز على الخصوصية للمواقع والمنتجات. الخطة المجانية تشمل 3,000 حدث شهريًا.
  * [Rybbit](https://rybbit.io) - بديل مفتوح المصدر وبدون ملفات تعريف ارتباط لـ Google Analytics أكثر سهولة بعشر مرات. الخطة المجانية تشمل 3,000 حدث شهريًا.

**[⬆️ العودة للأعلى](#table-of-contents)**

## تسجيل جلسات الزوار

  * [Reactflow.com](https://www.reactflow.com/) — لكل موقع: 1,000 مشاهدة صفحات/يوم، ثلاث خرائط حرارية، ثلاث ودجات، تتبع أخطاء مجاني
  * [OpenReplay.com](https://www.openreplay.com) - إعادة تشغيل الجلسات مفتوحة المصدر مع أدوات للمطورين لإعادة إنتاج الأخطاء، جلسات مباشرة للدعم الفوري، ومجموعة تحليلات للمنتج. ألف جلسة شهريًا مع جميع الميزات واحتفاظ بالبيانات لمدة 7 أيام.
  * [LogRocket.com](https://www.logrocket.com) - 1,000 جلسة شهريًا مع احتفاظ بالبيانات لمدة 30 يومًا، تتبع الأخطاء، وضع مباشر
  * [FullStory.com](https://www.fullstory.com) — 1,000 جلسة شهريًا مع شهر من احتفاظ البيانات وثلاثة مقاعد مستخدمين. مزيد من المعلومات [هنا](https://help.fullstory.com/hc/en-us/articles/360020623354-FullStory-Free-Edition).
  * [hotjar.com](https://www.hotjar.com/) — لكل موقع: 1,050 مشاهدة صفحات/شهر، خرائط حرارية غير محدودة، بيانات محفوظة لثلاثة أشهر
  * [inspectlet.com](https://www.inspectlet.com/) — 2,500 جلسة شهريًا مجانًا لموقع واحد
  * [Microsoft Clarity](https://clarity.microsoft.com/) - تسجيل الجلسات مجاني بالكامل مع "عدم وجود حدود للزيارات"، ولا حدود للمشاريع، وبدون أخذ عينات
  * [mouseflow.com](https://mouseflow.com/) — 500 جلسة شهريًا مجانًا لموقع واحد
  * [mousestats.com](https://www.mousestats.com/) — 100 جلسة شهريًا مجانًا لموقع واحد
  * [smartlook.com](https://www.smartlook.com/) — باقات مجانية لتطبيقات الويب والموبايل (1500 جلسة شهريًا)، ثلاث خرائط حرارية، مسار تحويل واحد، تاريخ بيانات شهر واحد
  * [howuku.com](https://howuku.com) — تتبع تفاعل المستخدمين والمشاركة والأحداث. مجاني حتى 5,000 زيارة شهريًا
  * [UXtweak.com](https://www.uxtweak.com/) — تسجيل ومشاهدة كيفية استخدام الزوار لموقعك أو تطبيقك. مجاني للمشاريع الصغيرة لمدة غير محدودة

**[⬆️ العودة للأعلى](#table-of-contents)**
## واجهات برمجة التطبيقات (API) وحزم تطوير البرمجيات (SDK) للتحقق من أرقام الهواتف الدولية

  * [numverify](https://numverify.com/) — التحقق من صحة أرقام الهواتف العالمية وخدمة البحث عبر JSON API. 100 طلب API شهريًا مجانًا.
  * [veriphone](https://veriphone.io/) — التحقق من أرقام الهواتف العالمية عبر API مجاني، سريع وموثوق بتنسيق JSON. 1000 طلب شهريًا مجانًا.

**[⬆️ العودة للأعلى](#table-of-contents)**

## تكامل الدفع والفوترة

  * [Qonversion](http://qonversion.io/) - منصة إدارة الاشتراكات متعددة الأنظمة الكل في واحد، توفر تحليلات واختبار A/B، وإعلانات Apple Search Ads، وتكوينات عن بُعد، وأدوات نمو لتحسين عمليات الشراء داخل التطبيق وتحقيق الدخل. متوافق مع iOS، Android، React Native، Flutter، Unity، Cordova، Stripe، والويب. مجاني حتى 10,000 دولار من الإيرادات الشهرية المتتبعة.
  * [ParityVend](https://www.ambeteco.com/ParityVend/) – ضبط الأسعار تلقائيًا حسب موقع الزائر لتوسيع نشاطك عالميًا والوصول إلى أسواق جديدة (تعادل القوة الشرائية). الخطة المجانية تشمل 7,500 طلب API شهريًا.
  * [Glassfy](https://glassfy.io/) – بنية تحتية للاشتراكات داخل التطبيق، وأحداث اشتراكات في الوقت الحقيقي وأدوات تحقيق الدخل الفورية على iOS وAndroid وStripe وPaddle. مجاني حتى 10,000 دولار من الإيرادات الشهرية.
  * [Adapty.io](https://adapty.io/) – حل شامل مع SDK مفتوح المصدر لتكامل اشتراكات التطبيقات على iOS وAndroid وReact Native وFlutter وUnity أو تطبيقات الويب. مجاني حتى 10,000 دولار من الإيرادات الشهرية.
  * [CoinMarketCap](https://coinmarketcap.com/api/) — يوفر بيانات سوق العملات الرقمية بما في ذلك أحدث أسعار الصرف للعملات الرقمية والورقية. المستوى المجاني يوفر 10,000 نقطة اتصال (call credits) شهريًا.
  * [CurrencyFreaks](https://currencyfreaks.com/) — يقدم أسعار صرف العملات الحالية والتاريخية. خطة المطور المجانية متاحة مع 1000 طلب شهريًا.
  * [CoinGecko](https://www.coingecko.com/en/api) — يوفر بيانات سوق العملات الرقمية بما في ذلك أحدث أسعار الصرف والبيانات التاريخية. واجهة API التجريبية تأتي بحد ثابت 30 طلب/دقيقة وحد أقصى شهري 10,000 طلب.
  * [CurrencyApi](https://currencyapi.net/) — أسعار صرف العملات الحية للعملات الورقية والرقمية، بتنسيق JSON وXML. المستوى المجاني يوفر 1,250 طلب API شهريًا.
  * [currencylayer](https://currencylayer.com/) — أسعار صرف موثوقة وتحويل العملات لنشاطك التجاري، 100 طلب API شهريًا مجانًا.
  * [exchangerate-api.com](https://www.exchangerate-api.com) - API لتحويل العملات بتنسيق JSON سهل الاستخدام. المستوى المجاني يتم تحديثه مرة يوميًا بحد 1,500 طلب شهريًا.
  * [FraudLabsPRO](https://www.fraudlabspro.com) — يساعد التجار على منع الاحتيال في الدفع وعمليات رد المبالغ. خطة Micro المجانية متوفرة مع 500 استعلام شهريًا.
  * [FxRatesAPI](https://fxratesapi.com) — يوفر أسعار الصرف في الوقت الحقيقي والتاريخية. المستوى المجاني يتطلب الإشارة إلى المصدر (attribution).
  * [Moesif API Monetization](https://www.moesif.com/) - تحقيق الدخل من واجهات برمجة التطبيقات عن طريق الفوترة حسب الاستخدام. متوافق مع Stripe وChargebee وغيرها. المستوى المجاني يوفر 30,000 حدث شهريًا.
  * [Nami ML](https://www.namiml.com/) - منصة متكاملة للمشتريات والاشتراكات داخل التطبيق على iOS وAndroid، تشمل جدران دفع بدون كود، وإدارة علاقات العملاء، وتحليلات. مجانية لجميع الميزات الأساسية لتشغيل نشاط IAP.
  * [RevenueCat](https://www.revenuecat.com/) — خدمة خلفية مستضافة للمشتريات والاشتراكات داخل التطبيق (iOS وAndroid). مجاني حتى 2,500 دولار شهريًا من الإيرادات المتتبعة.
  * [vatlayer](https://vatlayer.com/) — التحقق الفوري من أرقام ضريبة القيمة المضافة وأسعار ضريبة القيمة المضافة للاتحاد الأوروبي عبر API، مجاني حتى 100 طلب API شهريًا.
  * [Currencyapi](https://currencyapi.com) — API مجاني لتحويل العملات وبيانات أسعار الصرف. 300 طلب شهريًا مجانًا، 10 طلبات في الدقيقة للاستخدام الخاص.

**[⬆️ العودة للأعلى](#table-of-contents)**

## خدمات متعلقة بـ Docker

  * [canister.io](https://canister.io/) — 20 مستودع خاص مجاني للمطورين، و30 مستودع خاص مجاني للفرق لإنشاء وتخزين صور Docker.
  * [Container Registry Service](https://container-registry.com/) - حل إدارة الحاويات قائم على Harbor. المستوى المجاني يوفر 1 جيجابايت من التخزين للمستودعات الخاصة.
  * [Docker Hub](https://hub.docker.com) — مستودع خاص مجاني واحد ومستودعات عامة غير محدودة لإنشاء وتخزين صور Docker.
  * [Play with Docker](https://labs.play-with-docker.com/) — منصة تفاعلية بسيطة وممتعة لتعلم Docker.
  * [quay.io](https://quay.io/) — إنشاء وتخزين صور الحاويات مع مستودعات عامة مجانية غير محدودة.
  * [ttl.sh](https://ttl.sh/) - سجل صور Docker مجهول ومؤقت.

**[⬆️ العودة للأعلى](#table-of-contents)**

## خدمات متعلقة بـ Vagrant

  * [Vagrant Cloud](https://app.vagrantup.com) - سحابة HashiCorp Vagrant. استضافة صناديق Vagrant.
  * [Vagrantbox.es](https://www.vagrantbox.es/) — فهرس صناديق عام بديل

**[⬆️ العودة للأعلى](#table-of-contents)**

## مواقع التدوين التقني

  * [BearBlog](https://bearblog.dev/) - مدونة ومنشئ مواقع بسيط يدعم Markdown.
  * [Dev.to](https://dev.to/) - حيث يشارك المبرمجون الأفكار ويساعدون بعضهم البعض على النمو.
  * [Hashnode](https://hashnode.com/) — برنامج تدوين بدون متاعب للمطورين!
  * [Medium](https://medium.com/) — احصل على محتوى أكثر عمقًا لما يهمك.
  * [AyeDot](https://ayedot.com/) — شارك أفكارك ومعرفتك وقصصك مع العالم مجانًا عبر Miniblogs حديثة متعددة الوسائط.

**[⬆️ العودة للأعلى](#table-of-contents)**

## منصات التعليق

  * [GraphComment](https://graphcomment.com/) - منصة تعليقات تساعدك على بناء مجتمع نشط من جمهور موقعك.
  * [Utterances](https://utteranc.es/) - ويدجت تعليقات خفيف مبني على GitHub issues. استخدم GitHub issues لتعليقات المدونات وصفحات الويكي وأكثر!
  * [Disqus](https://disqus.com/) - Disqus منصة مجتمع مرتبطة يستخدمها مئات الآلاف من المواقع حول العالم.
  * [Remarkbox](https://www.remarkbox.com/) - منصة تعليقات مستضافة مفتوحة المصدر، ادفع ما تستطيع مقابل "مشرف واحد على عدة نطاقات مع تحكم كامل في السلوك والمظهر".
  * [IntenseDebate](https://intensedebate.com/) - نظام تعليقات غني بالميزات لـ WordPress وTumblr وBlogger والعديد من منصات المواقع الأخرى.

**[⬆️ العودة للأعلى](#table-of-contents)**

## واجهات API لالتقاط لقطات الشاشة

  * [ApiFlash](https://apiflash.com) — API لالتقاط لقطات الشاشة مبني على Aws Lambda وChrome. يدعم التقاط الصفحة كاملة وتوقيت الالتقاط وأبعاد إطار العرض.
  * [microlink.io](https://microlink.io/) – يحول أي موقع إلى بيانات مثل تطبيع metatags، ومعاينة الروابط، وإمكانيات سحب البيانات أو لقطات الشاشة كخدمة. 250 طلب يوميًا مجاني.
  * [ScreenshotAPI.net](https://screenshotapi.net/) - API بسيط لالتقاط لقطات شاشة لأي موقع. مبني ليتوسع ومستضاف على Google Cloud. يوفر 100 لقطة مجانية شهريًا.
  * [screenshotlayer.com](https://screenshotlayer.com/) — التقط لقطات شاشة قابلة للتخصيص لأي موقع. 100 لقطة مجانية شهريًا.
  * [screenshotmachine.com](https://www.screenshotmachine.com/) — التقط 100 لقطة شهريًا، png، gif وjpg، بما في ذلك لقطات كاملة الطول وليس فقط الصفحة الرئيسية.
  * [PhantomJsCloud](https://PhantomJsCloud.com) — أتمتة المتصفح وعرض الصفحات. الخطة المجانية توفر حتى 500 صفحة يوميًا. متاح مجانًا منذ 2017.
  * [Webshrinker.com](https://webshrinker.com) — Web Shrinker يقدم لقطات شاشة للمواقع وخدمات API لذكاء النطاقات. 100 طلب شهريًا مجانًا.
  * [Screenshots](https://screenshotson.click) — API لالتقاط لقطات الشاشة مع خيارات تخصيص واسعة. 100 لقطة مجانية شهريًا.

**[⬆️ العودة للأعلى](#table-of-contents)**

## خدمات Flutter وبناء تطبيقات iOS بدون Mac

  * [FlutLab](https://flutlab.io/) - FlutLab هو بيئة تطوير Flutter حديثة عبر الإنترنت وأفضل مكان لإنشاء وتصحيح وبناء مشاريع متعددة المنصات. بناء تطبيقات iOS (بدون Mac) وAndroid باستخدام Flutter.
  * [CodeMagic](https://codemagic.io/) - Codemagic هو نظام CI/CD مستضاف ومدار بالكامل لتطبيقات الجوال. يمكنك البناء والاختبار والنشر عبر أداة CI/CD بواجهة رسومية. الخطة المجانية توفر 500 دقيقة مجانية شهريًا وجهاز Mac Mini بمعالج 2.3 GHz وذاكرة 8 جيجابايت.
  * [FlutterFlow](https://flutterflow.io/) - FlutterFlow واجهة سحب وإفلات عبر المتصفح لبناء تطبيقات الهاتف باستخدام flutter.

**[⬆️ العودة للأعلى](#table-of-contents)**

## محاكاة العتاد عبر المتصفح مكتوبة بـ Javascript

  * [JsLinux](https://bellard.org/jslinux) — آلة افتراضية x86 سريعة جدًا قادرة على تشغيل Linux وWindows 2k.
  * [Jor1k](https://s-macke.github.io/jor1k/demos/main.html) — آلة افتراضية OpenRISC قادرة على تشغيل Linux مع دعم الشبكة.
  * [v86](https://copy.sh/v86) — آلة افتراضية x86 قادرة على تشغيل Linux وأنظمة تشغيل أخرى مباشرة في المتصفح.

**[⬆️ العودة للأعلى](#table-of-contents)**

## إدارة الخصوصية
  * [Bearer](https://www.bearer.sh/) - يساعد في تنفيذ الخصوصية حسب التصميم عبر التدقيق والتدفقات المستمرة لتتوافق المؤسسات مع GDPR ولوائح أخرى. المستوى المجاني محدود للفرق الصغيرة وإصدار SaaS فقط.
  * [Osano](https://www.osano.com/) - منصة إدارة الموافقات والامتثال مع كل شيء من تمثيل GDPR إلى لافتات الكوكيز. المستوى المجاني يوفر ميزات أساسية.
  * [Iubenda](https://www.iubenda.com/) - سياسات الخصوصية والكوكيز وإدارة الموافقات. المستوى المجاني يوفر سياسة خصوصية وملفات تعريف ارتباط محدودة بالإضافة إلى لافتات الكوكيز.
  * [Cookiefirst](https://cookiefirst.com/) - لافتات الكوكيز، تدقيق، وحلول إدارة الموافقات متعددة اللغات. المستوى المجاني يوفر فحصًا لمرة واحدة ولافتة واحدة فقط.
  * [Ketch](https://www.ketch.com/) - أداة لإدارة الموافقة وإطار عمل للخصوصية. توفر الخطة المجانية معظم الميزات مع عدد زوار محدود.
  * [Concord](https://www.concord.tech/) - منصة خصوصية بيانات متكاملة، تشمل إدارة الموافقة، معالجة طلبات الخصوصية (DSARs)، ورسم خرائط البيانات. تتضمن الخطة المجانية ميزات إدارة الموافقة الأساسية كما يقدمون خطة أكثر تقدماً مجاناً للمشاريع مفتوحة المصدر التي تم التحقق منها.

**[⬆️ العودة إلى الأعلى](#table-of-contents)**

## متنوع

  * [BackgroundStyler.com](https://backgroundstyler.com) - أنشئ لقطات شاشة جمالية لشفرتك أو نصك أو صورك لمشاركتها على وسائل التواصل الاجتماعي.
  * [BinShare.net](https://binshare.net) - أنشئ وشارك الشيفرات أو الملفات الثنائية. متاح للمشاركة كصورة جميلة مثلاً لمنشور تويتر أو فيسبوك أو كرابط للمحادثات أو المنتديات.
  * [Blynk](https://blynk.io) — خدمة SaaS مع واجهة API للتحكم، البناء والتقييم لأجهزة إنترنت الأشياء. خطة المطور المجانية تشمل 5 أجهزة، سحابة مجانية وتخزين بيانات. تتوفر أيضاً تطبيقات للجوال.
  * [Bricks Note Calculator](https://free.getbricks.app/) - تطبيق لتدوين الملاحظات (PWA) مع آلة حاسبة مدمجة قوية متعددة الأسطر.
  * [Carbon.now.sh](https://carbon.now.sh) - إنشاء ومشاركة مقتطفات الشيفرة في صورة جمالية تشبه لقطات الشاشة. غالباً ما تُستخدم لمشاركة/عرض مقتطفات الشيفرة بشكل جمالي على تويتر أو التدوينات.
  * [Code Time](https://www.software.com/code-time) - إضافة لتتبع الوقت وقياس مؤشرات البرمجة في VS Code وAtom وIntelliJ وSublime Text وأكثر.
  * [Codepng](https://www.codepng.app) - أنشئ لقطات ممتازة من الشيفرة المصدرية لمشاركتها على وسائل التواصل الاجتماعي.
  * [CodeToImage](https://codetoimage.com/) - أنشئ لقطات شاشة للشيفرة أو النصوص لمشاركتها على وسائل التواصل الاجتماعي.
  * [Cronhooks](https://cronhooks.io/) - جدولة webhooks لمرة واحدة أو بشكل متكرر. الخطة المجانية تسمح بـ 5 جداول عشوائية.
  * [cron-job.org](https://cron-job.org) - خدمة وظائف كرون على الإنترنت. الوظائف غير محدودة ومجانية تماماً.
  * [datelist.io](https://datelist.io) - نظام حجز / جدولة مواعيد عبر الإنترنت. مجاني حتى 5 حجوزات شهرياً، ويشمل تقويماً واحداً.
  * [Domain Forward](https://domain-forward.com/) - أداة مباشرة لإعادة توجيه أي رابط أو نطاق. مجاني حتى 5 نطاقات و200 ألف طلب شهرياً.
  * [Elementor](https://elementor.com) — منشئ مواقع WordPress. خطة مجانية متاحة مع أكثر من 40 أداة أساسية.
  * [Exif Editor](https://exifeditor.io/) — اعرض، حرر، امسح، وحلل بيانات وصف الصور/الصور الفوتوغرافية فوراً في المتصفح - بما في ذلك موقع GPS وبيانات التعريف.
  * [Format Express](https://www.format-express.dev) - تنسيق فوري عبر الإنترنت لـ JSON / XML / SQL.
  * [FOSSA](https://fossa.com/) - إدارة شاملة وقابلة للتوسع للبرمجيات الخارجية، الامتثال للرخص والثغرات الأمنية.
  * [Hook Relay](https://www.hookrelay.dev/) - أضف دعم webhooks لتطبيقك بسهولة: إدارة قائمة الانتظار، المحاولات مع تأخير تلقائي، والتسجيل. الخطة المجانية تشمل 100 تسليم يومياً، احتفاظ لمدة 14 يوماً، و3 نقاط نهاية.
  * [Hosting Checker](https://hostingchecker.co) - تحقق من معلومات الاستضافة مثل ASN، ISP، الموقع وأكثر لأي نطاق أو موقع أو عنوان IP. يشمل أيضاً عدة أدوات للاستضافة وDNS.
  * [http2.pro](https://http2.pro) — اختبار جاهزية بروتوكول HTTP/2 وكشف دعم العملاء لـ HTTP/2 عبر API.
  * [kandi](https://kandi.openweaver.com/) — تسريع تطوير التطبيقات: بناء وظائف مخصصة وحالات استخدام وتطبيقات كاملة بشكل أسرع عبر مقتطفات الشيفرة وإعادة استخدام مكتبات مفتوحة المصدر.
  * [Base64 decoder/encoder](https://devpal.co/base64-decode/) — أداة مجانية عبر الإنترنت لفك وترميز البيانات.
  * [newreleases.io](https://newreleases.io) - استقبل إشعارات عبر البريد، Slack، Telegram، Discord، وwebhooks مخصصة للإصدارات الجديدة من GitHub وGitLab وBitbucket وPyPI وMaven وNPM وYarn وRuby Gems وPackagist وNuGet وCargo وDocker Hub.
  * [OnlineExifViewer](https://onlineexifviewer.com/) — اعرض بيانات EXIF فورياً على الإنترنت لصورة بما في ذلك موقع GPS وبيانات التعريف.
  * [PDFMonkey](https://www.pdfmonkey.io/) — إدارة قوالب PDF عبر لوحة تحكم، واستدعاء API ببيانات ديناميكية، وتحميل ملفات PDF. يقدم 300 مستند مجاني شهرياً.
  * [Pika Code Screenshots](https://pika.style/templates/code-image) — أنشئ لقطات شاشة جميلة وقابلة للتخصيص من مقتطفات الشيفرة وVSCode عبر الإضافة.
  * [QuickType.io](https://quicktype.io/) - توليد تلقائي سريع للنماذج/الكلاسات/الأنواع/الواجهات والمسلسلات من JSON أو schema أو GraphQL للعمل مع البيانات بسرعة وأمان بأي لغة برمجة. حول JSON إلى شيفرة أنيقة وآمنة في أي لغة.
  * [RandomKeygen](https://randomkeygen.com/) - أداة مجانية ومتوافقة مع الجوال تقدم مجموعة متنوعة من المفاتيح وكلمات المرور العشوائية لتأمين أي تطبيق أو خدمة أو جهاز.
  * [ray.so](https://ray.so/) - أنشئ صوراً جميلة لمقتطفات الشيفرة الخاصة بك.
  * [readme.com](https://readme.com/) — توثيق جميل وسهل، مجاني للمشاريع مفتوحة المصدر.
  * [redirection.io](https://redirection.io/) — أداة SaaS لإدارة إعادة توجيه HTTP للأعمال والتسويق وتحسين محركات البحث.
  * [redirect.ing](https://redirect.ing/) - إعادة توجيه نطاقات بسرعة وأمان دون إدارة خوادم أو شهادات SSL. الخطة المجانية تشمل 10 أسماء مضيف و100,000 طلب شهرياً.
  * [redirect.pizza](https://redirect.pizza/) - إدارة سهلة لإعادة التوجيه مع دعم HTTPS. الخطة المجانية تشمل 10 مصادر و100,000 زيارة شهرياً.
  * [ReqBin](https://reqbin.com/) — إرسال طلبات HTTP عبر الإنترنت. تشمل الطرق الشائعة: GET، POST، PUT، DELETE، HEAD. يدعم الرؤوس والمصادقة عبر التوكن. يتضمن نظام تسجيل دخول أساسي لحفظ طلباتك.
  * [Smartcar API](https://smartcar.com) - واجهة API للسيارات لتحديد الموقع، مستوى الوقود، البطارية، عداد المسافة، قفل/فتح الأبواب، وغيرها.
  * [snappify](https://snappify.com) - يمكّن المطورين من إنشاء تصاميم بصرية رائعة. من مقتطفات الشيفرة الجميلة إلى العروض التقنية الكاملة. الخطة المجانية تشمل حتى 3 لقطات في وقت واحد مع تنزيلات غير محدودة و5 تفسيرات شيفرة مدعومة بالذكاء الاصطناعي شهرياً.
  * [Sunrise and Sunset](https://sunrisesunset.io/api/) - احصل على أوقات الشروق والغروب لموقع طولي وعرضي محدد.
  * [superfeedr.com](https://superfeedr.com/) — خلاصات متوافقة مع PubSubHubbub في الوقت الحقيقي، تصدير، تحليلات. مجاني مع تخصيص أقل.
  * [SurveyMonkey.com](https://www.surveymonkey.com) — أنشئ استطلاعات عبر الإنترنت. تحليل النتائج عبر الإنترنت. الخطة المجانية تسمح بـ 10 أسئلة و100 إجابة لكل استبيان فقط.
  * [Tiledesk](https://tiledesk.com) - أنشئ روبوتات دردشة وتطبيقات محادثة. جلبها لجميع القنوات: من موقعك (ودجت دردشة مباشرة) إلى WhatsApp. خطة مجانية بعدد غير محدود من روبوتات الدردشة.
  * [Versionfeeds](https://versionfeeds.com) — خلاصات RSS مخصصة لإصدارات برامجك المفضلة. اجمع أحدث إصدارات لغات البرمجة والمكتبات والأدوات المحبوبة في تغذية واحدة. (أول 3 خلاصات مجانية)
  * [videoinu](https://videoinu.com) — إنشاء وتحرير تسجيلات الشاشة وغيرها من الفيديوهات عبر الإنترنت.
  * [Webacus](https://webacus.dev) — الوصول إلى مجموعة واسعة من أدوات المطورين المجانية للترميز، وفك الترميز، ومعالجة البيانات.

**[⬆️ العودة إلى الأعلى](#table-of-contents)**

## أدوات سطح المكتب البعيد

  * [Getscreen.me](https://getscreen.me) — مجاني لجهازين، بدون حدود على عدد أو مدة الجلسات
  * [Apache Guacamole™](https://guacamole.apache.org/) — بوابة سطح مكتب بعيد مفتوحة المصدر ولا تتطلب عميل
  * [RemSupp](https://remsupp.com) — دعم عند الطلب وإمكانية الوصول الدائم للأجهزة (جلستان يومياً مجاناً)
  * [RustDesk](https://rustdesk.com/) - بنية سطح مكتب افتراضي/بعيد مفتوحة المصدر للجميع!
  * [AnyDesk](https://anydesk.com) — مجاني لثلاثة أجهزة، بدون حدود على عدد أو مدة الجلسات

**[⬆️ العودة إلى الأعلى](#table-of-contents)**

## تطوير الألعاب

  * [itch.io](https://itch.io/game-assets) — أصول مجانية/مدفوعة مثل الرسوم، مجموعات البلاط، وحزم الشخصيات.
  * [Gamefresco.com](https://gamefresco.com/) — اكتشف وجمع وشارك أصول الألعاب المجانية من فنانين حول العالم.
  * [GameDevMarket](https://gamedevmarket.net) — أصول مجانية/مدفوعة مثل 2D، 3D، صوتيات، واجهات المستخدم.
  * [OpenGameArt](https://opengameart.org) — أصول ألعاب مفتوحة المصدر مثل الموسيقى، الأصوات، الرسوم، والرسوم المتحركة.
  * [CraftPix](https://craftpix.net) — أصول مجانية/مدفوعة مثل 2D، 3D، صوتيات، واجهات المستخدم، خلفيات، أيقونات، مجموعات البلاط، مجموعات الألعاب.
  * [Game Icons](https://game-icons.net/) - أيقونات SVG/PNG مجانية وقابلة للتخصيص بموجب رخصة CC-BY.
  * [LoSpec](https://lospec.com/) — أدوات عبر الإنترنت لإنشاء فن البكسل والفنون الرقمية المقيدة الأخرى، العديد من الدروس وقوائم الألوان متاحة للاختيار لألعابك
  * [ArtStation](https://www.artstation.com/) - سوق للأصول 2D، 3D المجانية/المدفوعة والصوتيات، الأيقونات، مجموعات البلاط، مجموعات الألعاب. كما يمكن استخدامه لعرض محفظة أعمالك الفنية.
  * [Rive](https://rive.app/community/) - أصول مجتمعية بالإضافة لإمكانية إنشاء أصول ألعابك باستخدام الخطة المجانية.
  * [Poly Pizza](https://poly.pizza/) - أصول 3D منخفضة التعقيد مجانية
  * [3Dassets.one](https://3dassets.one/) - أكثر من 8,000 نموذج ثلاثي الأبعاد مجاني/مدفوع ومواد PBR لصناعة القوام.
  * [Kenney](https://www.kenney.nl/assets/) - أصول ألعاب 2D، 3D، صوتيات وواجهات مستخدم مجانية (مرخصة CC0 1.0 Universal).
  * [Poliigon](https://www.poliigon.com/) - قوام (بدرجات دقة متغيرة)، نماذج، HDRIs، وفرش مجانية ومدفوعة. يوفر إضافات مجانية للتصدير لبرمجيات مثل Blender.
  * [Freesound](https://freesound.org/) - مكتبة صوتيات تعاونية مجانية تقدم تراخيص CC مختلفة.

**[⬆️ العودة إلى الأعلى](#table-of-contents)**

## موارد مجانية أخرى

  * [Wikimint Developer](https://developer.wikimint.com/p/tools.html) - أدوات مجانية دائمة لمطوري الويب تشمل تصغير/إلغاء تصغير CSS، مُحسّن الصور، تغيير حجم الصور، تحويل حالة الأحرف، مدقق CSS، مترجم JavaScript، محرر HTML وغيرها.
  * [ElevateAI](https://www.elevateai.com) - احصل على ما يصل إلى 200 ساعة من تحويل الكلام إلى نص مجاناً كل شهر.
  * [get.localhost.direct](https://get.localhost.direct) — شهادة SSL موقعة من CA عامة لنطاقات `*.localhost.direct` لتطوير محلي مع دعم النطاقات الفرعية
  * [Framacloud](https://degooglisons-internet.org/en/) — قائمة بالبرمجيات الحرة مفتوحة المصدر وخدمات SaaS من المنظمة الفرنسية غير الربحية [Framasoft](https://framasoft.org/en/).
  * [github.com — FOSS for Dev](https://github.com/tvvocold/FOSS-for-Dev) — مركز للبرمجيات المجانية ومفتوحة المصدر للمطورين.
  * [GitHub Education](https://education.github.com/pack) — مجموعة من الخدمات المجانية للطلاب. يتطلب التسجيل.
  * [Markdown Tools](https://markdowntools.com) - أدوات لتحويل HTML وCSV وPDF وJSON وملفات Excel من وإلى Markdown
  * [Microsoft 365 Developer Program](https://developer.microsoft.com/microsoft-365/dev-program) — احصل على بيئة اختبار مجانية، وأدوات وموارد أخرى لبناء حلول على منصة Microsoft 365. الاشتراك هو [اشتراك Microsoft 365 E5 لمدة 90 يوماً](https://www.microsoft.com/microsoft-365/enterprise/e5) (يستثنى Windows) ويمكن تجديده إذا كنت نشطاً في التطوير (يتم القياس باستخدام بيانات القياس والتحليل).
  * [Pyrexp](https://pythonium.net/regex) — أداة مجانية عبر الويب لاختبار وتصحيح التعابير النمطية (regex).
  * [RedHat for Developers](https://developers.redhat.com) — وصول مجاني لمنتجات Red Hat بما في ذلك RHEL وOpenShift وCodeReady وغيرها حصرياً للمطورين. الخطة الفردية فقط. تتوفر أيضاً كتب إلكترونية مجانية للرجوع إليها.
  * [smsreceivefree.com](https://smsreceivefree.com/) — يوفر أرقام هواتف مؤقتة وقابلة للتخلص منها مجاناً.
  * [sandbox.httpsms.com](https://sandbox.httpsms.com) — إرسال واستقبال رسائل SMS تجريبية مجاناً.
  * [SimpleBackups.com](https://simplebackups.com/) — خدمة أتمتة النسخ الاحتياطي للخوادم وقواعد البيانات (MySQL، PostgreSQL، MongoDB) تُخزن مباشرة في مزودي التخزين السحابي (AWS، DigitalOcean، Backblaze). توفر خطة مجانية لنسخة احتياطية واحدة.
  * [SnapShooter](https://snapshooter.com/) — حل نسخ احتياطي لـ DigitalOcean وAWS وLightSail وHetzner وExoscale، مع دعم للنسخ الاحتياطي المباشر لقواعد البيانات، أنظمة الملفات والتطبيقات إلى تخزين s3. يوفر خطة مجانية بنسخ احتياطية يومية لمورد واحد.
  * [Themeselection](https://themeselection.com/) — قوالب لوحات تحكم إدارية عالية الجودة، حديثة، احترافية وسهلة الاستخدام، وHTML Themes وUI Kits مجاناً لتسريع تطوير تطبيقاتك!
  * [Web.Dev](https://web.dev/measure/) — أداة مجانية تتيح لك معرفة أداء موقعك وتحسين SEO لرفع ترتيبه في محركات البحث.
  * [SmallDev.tools](https://smalldev.tools/) — أداة مجانية للمطورين تتيح لك ترميز/فك ترميز صيغ مختلفة، ضغط HTML/CSS/JavaScript، تجميل الأكواد، توليد مجموعات بيانات وهمية/اختبارية بصيغ JSON/CSV وصيغ متعددة أخرى والعديد من الميزات الأخرى، مع واجهة استخدام ممتعة.
  * [UseCSV by Layercode](https://layercode.com/usecsv) — أضف إمكانية استيراد ملفات CSV وExcel إلى تطبيقك الإلكتروني خلال دقائق. امنح مستخدميك تجربة استيراد بيانات ممتعة وموثوقة. ابدأ مجانًا دون الحاجة إلى تفاصيل بطاقة ائتمان، وابدأ بدمج UseCSV اليوم. يمكنك إنشاء عدد غير محدود من المستوردين ورفع ملفات حتى 100 ميجابايت.
  * [Buttons Generator](https://markodenic.com/tools/buttons-generator/) — أكثر من 100 زر يمكنك استخدامها في مشروعك.
  * [WrapPixel](https://www.wrappixel.com/) — تحميل قوالب لوحات تحكم إدارية عالية الجودة مجانية ومدفوعة تم إنشاؤها باستخدام Angular وReact وVueJs وNextJS وNuxtJS!
  * [Utils.fun](https://utils.fun/en) — جميع الأدوات اليومية وأدوات التطوير غير المتصلة بالإنترنت والمبنية على قوة معالجة المتصفح، بما في ذلك توليد العلامات المائية، تسجيل الشاشة، الترميز وفك الترميز، التشفير وفك التشفير، وتنسيق الأكواد، كلها مجانية تمامًا ولا يتم رفع أي بيانات إلى السحابة للمعالجة.
  * [It tools](it-tools.tech) - أدوات مفيدة للمطورين والأشخاص العاملين في مجال تقنية المعلومات.
  * [Free Code Tools](https://freecodetools.org/) — أدوات فعّالة للأكواد 100% مجانية. محرر Markdown، ضغط/تجميل الأكواد، مولد QR، مولد Open Graph، مولد Twitter Card، والمزيد.
  * [regex101](https://regex101.com/) — موقع مجاني يتيح لك اختبار وتصحيح تعابير regex. يوفر محرر ومختبر regex بالإضافة إلى توثيق وموارد مساعدة لتعلم regex.
  * [Kody Tools](https://www.kodytools.com/dev-tools) — أكثر من 100 أداة تطوير تشمل أدوات تنسيق، ضغط وتحويل.
  * [AdminMart](https://adminmart.com/) — قوالب لوحات تحكم إدارية ومواقع عالية الجودة مجانية ومدفوعة تم إنشاؤها باستخدام Angular وBootstrap وReact وVueJs وNextJS وNuxtJS!
  * [Glob tester](https://globster.xyz/) — موقع يسمح لك بتصميم واختبار أنماط glob. كما يوفر موارد لتعلم أنماط glob.
  * [SimpleRestore](https://simplerestore.io) - استعادة نسخ احتياطية MySQL بسهولة. استرجع نسخ MySQL الاحتياطية إلى أي قاعدة بيانات عن بعد دون الحاجة إلى كود أو سيرفر.
  * [360Converter](https://www.360converter.com/) - موقع مجاني لتحويل: الفيديو إلى نص && الصوت إلى نص && الكلام إلى نص && الصوت المباشر إلى نص && فيديو يوتيوب إلى نص && إضافة ترجمة للفيديو. قد يكون مفيدًا في تحويل مقاطع الفيديو القصيرة أو دروس يوتيوب القصيرة :)
  * [QRCodeBest](https://qrcode.best/) - أنشئ رموز QR مخصصة مع 13 قالبًا، خصوصية كاملة، وعلامة تجارية شخصية. ميزات تتبع البكسل، تصنيف المشاريع، وعدد غير محدود من المستخدمين على QRCode.Best.
  * [PostPulse](https://PostPulseAI.com) - عزز حضورك الإلكتروني، وحسّن SEO وترتيب موقعك مع منشورات شهرية مدعومة بالذكاء الاصطناعي إلى نطاقات محسّنة لـ SEO. الخطة المجانية تتيح لك نشر منشور واحد يدويًا شهريًا على موقعهم.
  * [PageTools](https://pagetools.co/) - يقدم مجموعة أدوات مجانية مدعومة بالذكاء الاصطناعي لمساعدتك في توليد السياسات الأساسية للمواقع، وإنشاء السير الذاتية و المنشورات وصفحات الويب بنقرة واحدة.
  * [MySQL Visual Explain](https://mysqlexplain.com) - أداة مجانية وسهلة الفهم لتحليل وإظهار نتائج EXPLAIN في MySQL بصريًا لتحسين الاستعلامات البطيئة.
  * [Killer Coda](https://killercoda.com/)  - بيئة تفاعلية في متصفحك لدراسة Linux وKubernetes والحاويات والبرمجة وDevOps والشبكات.
  * [Axonomy App](https://axonomy-app.com/) - أداة مجانية لإنشاء، إدارة ومشاركة فواتيرك مع عملائك. 10 فواتير مجانية شهريًا.
  * [Table Format Converter](https://www.tableformatconverter.com) - أداة مجانية لتحويل بيانات الجداول إلى صيغ مختلفة مثل CSV وHTML وJSON وMarkdown وغيرها.


**[⬆️ العودة إلى الأعلى](#table-of-contents)**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---