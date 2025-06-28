# free-for.dev

توسعه‌دهندگان و نویسندگان متن‌باز اکنون به بسیاری از سرویس‌هایی با سطوح رایگان دسترسی دارند، اما پیدا کردن همه آن‌ها زمان‌بر است تا بتوان تصمیمات آگاهانه‌ای گرفت.

این فهرستی از نرم‌افزارها (SaaS، PaaS، IaaS و غیره) و سایر پیشنهاداتی است که دارای سطوح رایگان برای توسعه‌دهندگان می‌باشند.

دامنه این فهرست به مواردی محدود شده است که توسعه‌دهندگان زیرساخت (مانند مدیر سیستم، متخصصان DevOps و غیره) احتمالاً آن‌ها را مفید خواهند یافت. ما عاشق همه سرویس‌های رایگان هستیم، اما بهتر است موضوع را متمرکز نگه داریم. گاهی اوقات این خط مرزی خاکستری است، بنابراین این فهرست تا حدی سلیقه‌ای است؛ لطفاً اگر مشارکت شما پذیرفته نشد، ناراحت نشوید.

این فهرست حاصل Pull Request‌ها، بازبینی‌ها، ایده‌ها و کار انجام شده توسط بیش از ۱۶۰۰ نفر است. شما نیز می‌توانید با ارسال [Pull Request](https://github.com/ripienaar/free-for-dev) برای افزودن سرویس‌های بیشتر یا حذف سرویس‌هایی که شرایط‌شان تغییر کرده یا بازنشسته شده‌اند، کمک کنید.

[![Track Awesome List](https://www.trackawesomelist.com/badge.svg)](https://www.trackawesomelist.com/ripienaar/free-for-dev)

**توجه:** این فهرست فقط برای سرویس‌هایی به صورت as-a-Service است و شامل نرم‌افزارهای خود-میزبان نمی‌شود. برای واجد شرایط بودن، سرویس باید یک سطح رایگان ارائه دهد، نه فقط دوره آزمایشی رایگان. اگر سطح رایگان محدود به زمان باشد، باید حداقل یک سال باشد. همچنین سطح رایگان را از منظر امنیتی نیز بررسی می‌کنیم، بنابراین SSO (ورود یکپارچه) مشکلی ندارد، اما سرویس‌هایی که TLS را فقط به سطوح پولی محدود می‌کنند، پذیرفته نخواهند شد.

# فهرست مطالب

  * [محدودیت‌های همیشگی رایگان ارائه‌دهندگان بزرگ ابری](#major-cloud-providers)
  * [راهکارهای مدیریت ابر](#cloud-management-solutions)
  * [تحلیل، رویدادها و آمار](#analytics-events-and-statistics)
  * [APIها، داده و یادگیری ماشین](#apis-data-and-ml)
  * [مخازن مصنوعات](#artifact-repos)
  * [BaaS](#baas)
  * [پلتفرم کم‌کد](#low-code-platform)
  * [CDN و حفاظت](#cdn-and-protection)
  * [CI و CD](#ci-and-cd)
  * [CMS](#cms)
  * [تولید کد](#code-generation)
  * [کیفیت کد](#code-quality)
  * [جستجو و مرور کد](#code-search-and-browsing)
  * [مدیریت خطا و استثنا](#crash-and-exception-handling)
  * [بصری‌سازی داده بر روی نقشه‌ها](#data-visualization-on-maps)
  * [سرویس‌های داده مدیریت‌شده](#managed-data-services)
  * [طراحی و رابط کاربری](#design-and-ui)
  * [الهام‌بخشی طراحی](#design-inspiration)
  * [سایت‌های وبلاگ‌نویسی توسعه‌دهنده](#dev-blogging-sites)
  * [DNS](#dns)
  * [موارد مرتبط با داکر](#docker-related)
  * [دامنه](#domain)
  * [آموزش و توسعه شغلی](#education-and-career-development)
  * [ایمیل](#email)
  * [پلتفرم‌های مدیریت Feature Toggle](#feature-toggles-management-platforms)
  * [فونت](#font)
  * [فرم‌ها](#forms)
  * [هوش مصنوعی مولد](#generative-ai)
  * [IaaS](#iaas)
  * [IDE و ویرایشگر کد](#ide-and-code-editing)
  * [API و SDK تأیید شماره موبایل بین‌المللی](#international-mobile-number-verification-api-and-sdk)
  * [پیگیری اشکال و مدیریت پروژه](#issue-tracking-and-project-management)
  * [مدیریت لاگ](#log-management)
  * [توزیع و بازخورد اپلیکیشن موبایل](#mobile-app-distribution-and-feedback)
  * [سیستم‌های مدیریت](#management-system)
  * [پیام‌رسانی و استریمینگ](#messaging-and-streaming)
  * [متفرقه](#miscellaneous)
  * [مانیتورینگ](#monitoring)
  * [PaaS](#paas)
  * [سیستم ساخت پکیج](#package-build-system)
  * [ادغام پرداخت و صورتحساب](#payment-and-billing-integration)
  * [مدیریت حریم خصوصی](#privacy-management)
  * [APIهای اسکرین‌شات](#screenshot-apis)
  * [موارد مرتبط با Flutter و ساخت اپ‌های iOS بدون مک](#flutter-related-and-building-ios-apps-without-mac)
  * [جستجو](#search)
  * [امنیت و PKI](#security-and-pki)
  * [احراز هویت، مجوز و مدیریت کاربر](#authentication-authorization-and-user-management)
  * [مخازن کد منبع](#source-code-repos)
  * [ذخیره‌سازی و پردازش رسانه](#storage-and-media-processing)
  * [تونلینگ، WebRTC، سرورهای Web Socket و سایر روترها](#tunneling-webrtc-web-socket-servers-and-other-routers)
  * [تست](#testing)
  * [ابزارهای تیمی و همکاری](#tools-for-teams-and-collaboration)
  * [مدیریت ترجمه](#translation-management)
  * [موارد مرتبط با Vagrant](#vagrant-related)
  * [ضبط جلسه بازدیدکننده](#visitor-session-recording)
  * [میزبانی وب](#web-hosting)
  * [پلتفرم‌های کامنت‌گذاری](#commenting-platforms)
  * [شبیه‌سازی سخت‌افزار مبتنی بر مرورگر](#browser-based-hardware-emulation-written-in-javascript)
  * [ابزارهای دسکتاپ راه دور](#remote-desktop-tools)
  * [توسعه بازی](#game-development)
  * [سایر منابع رایگان](#other-free-resources)

## ارائه‌دهندگان بزرگ ابری

  * [Google Cloud Platform](https://cloud.google.com)
    * App Engine - ۲۸ ساعت نمونه فرانت‌اند در روز، ۹ ساعت نمونه بک‌اند در روز
    * Cloud Firestore - ۱ گیگابایت فضای ذخیره‌سازی، ۵۰٬۰۰۰ خواندن، ۲۰٬۰۰۰ نوشتن، ۲۰٬۰۰۰ حذف در روز
    * Compute Engine - یک e2-micro غیر پیش‌دستی، ۳۰ گیگابایت HDD، ۵ گیگابایت فضای ذخیره‌سازی snapshot (محدود به برخی مناطق)، ۱ گیگابایت ترافیک شبکه خروجی از آمریکای شمالی به همه مقاصد منطقه‌ای (به جز چین و استرالیا) در ماه
    * Cloud Storage - ۵ گیگابایت، ۱ گیگابایت ترافیک شبکه خروجی
    * Cloud Shell - شل لینوکسی مبتنی بر وب/IDE اصلی با ۵ گیگابایت فضای ذخیره‌سازی دائمی. محدودیت ۶۰ ساعت در هفته
    * Cloud Pub/Sub - ۱۰ گیگابایت پیام در ماه
    * Cloud Functions - ۲ میلیون فراخوانی در ماه (شامل هر دو فراخوانی پس‌زمینه و HTTP)
    * Cloud Run - ۲ میلیون درخواست در ماه، ۳۶۰٬۰۰۰ گیگابایت-ثانیه حافظه، ۱۸۰٬۰۰۰ vCPU-ثانیه زمان پردازش، ۱ گیگابایت ترافیک شبکه خروجی از آمریکای شمالی در ماه
    * Google Kubernetes Engine - بدون هزینه مدیریت خوشه برای یک خوشه ناحیه‌ای. هر گره کاربری با قیمت استاندارد Compute Engine محاسبه می‌شود
    * BigQuery - ۱ ترابایت کوئری در ماه، ۱۰ گیگابایت فضای ذخیره‌سازی هر ماه
    * Cloud Build - ۱۲۰ دقیقه ساخت در روز
    * Cloud Source Repositories - تا ۵ کاربر، ۵۰ گیگابایت فضای ذخیره‌سازی، ۵۰ گیگابایت ترافیک خروجی
    * [Google Colab](https://colab.research.google.com/) - محیط توسعه رایگان Jupyter Notebook.
    * [Firebase Studio](https://firebase.studio) استودیوی Google Firebase (قبلاً Project IDX). VSCode آنلاین که روی Google Cloud اجرا می‌شود.
    * فهرست کامل و جزئیات بیشتر - https://cloud.google.com/free

  * [Amazon Web Services](https://aws.amazon.com)
    * [CloudFront](https://aws.amazon.com/cloudfront/) - ۱ ترابایت ترافیک خروجی در ماه و ۲ میلیون فراخوانی Function در ماه
    * [CloudWatch](https://aws.amazon.com/cloudwatch/) - ۱۰ معیار سفارشی و ۱۰ هشدار
* [CodeBuild](https://aws.amazon.com/codebuild/) - ۱۰۰ دقیقه زمان ساخت در هر ماه  
* [CodeCommit](https://aws.amazon.com/codecommit/) - ۵ کاربر فعال، ۵۰ گیگابایت فضای ذخیره‌سازی و ۱۰٬۰۰۰ درخواست در هر ماه  
* [CodePipeline](https://aws.amazon.com/codepipeline/) - ۱ پایپ‌لاین فعال در هر ماه  
* [DynamoDB](https://aws.amazon.com/dynamodb/) - ۲۵ گیگابایت پایگاه داده NoSQL  
* [EC2](https://aws.amazon.com/ec2/) - ۷۵۰ ساعت در ماه از t2.micro یا t3.micro (۱۲ ماه). ۱۰۰ گیگابایت خروجی در هر ماه  
* [EBS](https://aws.amazon.com/ebs/) - ۳۰ گیگابایت در هر ماه از نوع General Purpose (SSD) یا Magnetic (۱۲ ماه)  
* [Elastic Load Balancing](https://aws.amazon.com/elasticloadbalancing/) - ۷۵۰ ساعت در ماه (۱۲ ماه)  
* [RDS](https://aws.amazon.com/rds/) - ۷۵۰ ساعت در ماه از db.t2.micro، db.t3.micro، یا db.t4g.micro، ۲۰ گیگابایت فضای ذخیره‌سازی از نوع General Purpose (SSD)، ۲۰ گیگابایت پشتیبان‌گیری ذخیره‌سازی (۱۲ ماه)  
* [S3](https://aws.amazon.com/s3/) - ۵ گیگابایت ذخیره‌سازی استاندارد، ۲۰٬۰۰۰ درخواست Get و ۲٬۰۰۰ درخواست Put (۱۲ ماه)  
* [Glacier](https://aws.amazon.com/glacier/) - ۱۰ گیگابایت ذخیره‌سازی بلندمدت  
* [Lambda](https://aws.amazon.com/lambda/) - ۱ میلیون درخواست در ماه  
* [SNS](https://aws.amazon.com/sns/) - ۱ میلیون انتشار در ماه  
* [SES](https://aws.amazon.com/ses/) - ۳٬۰۰۰ پیام در ماه (۱۲ ماه)  
* [SQS](https://aws.amazon.com/sqs/) - ۱ میلیون درخواست صف پیام  
* فهرست کامل و جزئیات - https://aws.amazon.com/free/

* [Microsoft Azure](https://azure.microsoft.com)
  * [Virtual Machines](https://azure.microsoft.com/services/virtual-machines/) - ۱ ماشین مجازی B1S لینوکس، ۱ ماشین مجازی B1S ویندوز (۱۲ ماه)
  * [App Service](https://azure.microsoft.com/services/app-service/) - ۱۰ اپلیکیشن وب، موبایل یا API (۶۰ دقیقه CPU در روز)
  * [Functions](https://azure.microsoft.com/services/functions/) - ۱ میلیون درخواست در ماه
  * [DevTest Labs](https://azure.microsoft.com/services/devtest-lab/) - ایجاد محیط‌های توسعه-تست سریع، آسان و بهینه
  * [Active Directory](https://azure.microsoft.com/services/active-directory/) - ۵۰۰٬۰۰۰ شیء
  * [Active Directory B2C](https://azure.microsoft.com/services/active-directory/external-identities/b2c/) - ۵۰٬۰۰۰ کاربر ذخیره شده در ماه
  * [Azure DevOps](https://azure.microsoft.com/services/devops/) - ۵ کاربر فعال، ریپازیتوری نامحدود خصوصی Git
  * [Azure Pipelines](https://azure.microsoft.com/services/devops/pipelines/) — ۱۰ کار موازی رایگان با زمان نامحدود برای پروژه‌های متن‌باز در لینوکس، مک و ویندوز
  * [Microsoft IoT Hub](https://azure.microsoft.com/services/iot-hub/) - ۸٬۰۰۰ پیام در روز
  * [Load Balancer](https://azure.microsoft.com/services/load-balancer/) - ۱ IP عمومی رایگان با تعادل بار (VIP)
  * [Notification Hubs](https://azure.microsoft.com/services/notification-hubs/) - ۱ میلیون پوش نوتیفیکیشن
  * [Bandwidth](https://azure.microsoft.com/pricing/details/bandwidth/) - ۱۵ گیگابایت ورودی (۱۲ ماه) و ۵ گیگابایت خروجی در ماه
  * [Cosmos DB](https://azure.microsoft.com/services/cosmos-db/) - ۲۵ گیگابایت ذخیره‌سازی و ۱۰۰۰ RU ظرفیت آماده
  * [Static Web Apps](https://azure.microsoft.com/pricing/details/app-service/static/) — ساخت، استقرار و میزبانی اپلیکیشن‌های استاتیک و فانکشن‌های سرورلس با SSL رایگان، احراز هویت و دامنه اختصاصی
  * [Storage](https://azure.microsoft.com/services/storage/) - ۵ گیگابایت ذخیره‌سازی فایل یا Blob با LRS (۱۲ ماه)
  * [Cognitive Services](https://azure.microsoft.com/services/cognitive-services/) - APIهای هوش مصنوعی و یادگیری ماشین (بینایی ماشین، ترجمه، تشخیص چهره، بات و ...) با سطح رایگان شامل تراکنش‌های محدود
  * [Cognitive Search](https://azure.microsoft.com/services/search/#features) - سرویس جستجو و نمایه‌سازی مبتنی بر هوش مصنوعی، رایگان برای ۱۰٬۰۰۰ سند
  * [Azure Kubernetes Service](https://azure.microsoft.com/services/kubernetes-service/) - سرویس مدیریت شده Kubernetes با مدیریت کلاستر رایگان
  * [Event Grid](https://azure.microsoft.com/services/event-grid/) - ۱۰۰٬۰۰۰ عملیات در ماه
  * فهرست کامل و جزئیات - https://azure.microsoft.com/free/

* [Oracle Cloud](https://www.oracle.com/cloud/)
  * محاسبات
     - ۲ ماشین مجازی مبتنی بر AMD با ۱/۸ OCPU و ۱ گیگابایت حافظه هر کدام
     - ۴ هسته Arm مبتنی بر Ampere A1 و ۲۴ گیگابایت حافظه قابل استفاده به صورت یک VM یا تا ۴ VM
     - نمونه‌ها در صورت [غیرفعال بودن](https://docs.oracle.com/en-us/iaas/Content/FreeTier/freetier_topic-Always_Free_Resources.htm#compute__idleinstances) جمع‌آوری می‌شوند
  * حجم بلاک - ۲ حجم، مجموعا ۲۰۰ گیگابایت (برای محاسبات)
  * ذخیره‌سازی آبجکت - ۱۰ گیگابایت
  * لود بالانسر - ۱ نمونه با ۱۰ مگابیت بر ثانیه
  * پایگاه داده - ۲ پایگاه داده، هر کدام ۲۰ گیگابایت
  * مانیتورینگ - ۵۰۰ میلیون نقطه داده ورودی، ۱ میلیارد نقطه داده بازیابی
  * پهنای باند - ۱۰ ترابایت خروجی در ماه، سرعت محدود به ۵۰ مگابیت بر ثانیه روی VMهای x64 و ۵۰۰ مگابیت * تعداد هسته روی VMهای ARM
  * آی‌پی عمومی - ۲ IPv4 برای VMها، ۱ IPv4 برای لود بالانسر
  * اعلان‌ها - ۱ میلیون گزینه تحویل در ماه، ۱۰۰۰ ایمیل ارسالی در ماه
  * فهرست کامل و جزئیات - https://www.oracle.com/cloud/free/

* [IBM Cloud](https://www.ibm.com/cloud/free/)
  * پایگاه داده Cloudant - ۱ گیگابایت فضای ذخیره‌سازی داده
  * پایگاه داده Db2 - ۱۰۰ مگابایت فضای ذخیره‌سازی داده
  * API Connect - ۵۰٬۰۰۰ فراخوانی API در ماه
  * مانیتورینگ دسترسی - ۳ میلیون نقطه داده در ماه
  * تحلیل لاگ - ۵۰۰ مگابایت لاگ روزانه
  * فهرست کامل و جزئیات - https://www.ibm.com/cloud/free/

* [Cloudflare](https://www.cloudflare.com/)
  * [Application Services](https://www.cloudflare.com/plans/) - DNS رایگان برای تعداد نامحدود دامنه، محافظت DDoS، CDN به همراه SSL رایگان، قوانین فایروال و صفحه، WAF، مقابله با بات، محدودیت نرخ بدون محاسبه - ۱ قانون برای هر دامنه، آنالیتیکس، فورواردینگ ایمیل
  * [Zero Trust & SASE](https://www.cloudflare.com/plans/zero-trust-services/) - تا ۵۰ کاربر، ۲۴ ساعت لاگ فعالیت، سه موقعیت شبکه
  * [Cloudflare Tunnel](https://www.cloudflare.com/products/tunnel/) - می‌توانید پورت HTTP محلی را از طریق تونل روی یک ساب‌دامین تصادفی در trycloudflare.com با [Quick Tunnels](https://developers.cloudflare.com/cloudflare-one/connections/connect-networks/do-more-with-tunnels/trycloudflare/) منتشر کنید، بدون نیاز به حساب کاربری. امکانات بیشتر (تونل TCP، لود بالانسر، VPN) در [Zero Trust](https://www.cloudflare.com/products/zero-trust/) پلن رایگان.
  * [Workers](https://developers.cloudflare.com/workers/) - استقرار کد سرورلس به رایگان روی شبکه جهانی Cloudflare — ۱۰۰٬۰۰۰ درخواست روزانه.
  * [Workers KV](https://developers.cloudflare.com/kv) - ۱۰۰٬۰۰۰ درخواست خواندن در روز، ۱٬۰۰۰ درخواست نوشتن در روز، ۱٬۰۰۰ درخواست حذف در روز، ۱٬۰۰۰ درخواست لیست در روز، ۱ گیگابایت داده ذخیره شده
  * [R2](https://developers.cloudflare.com/r2/) - ۱۰ گیگابایت در ماه، ۱ میلیون عملیات کلاس A در ماه، ۱۰ میلیون عملیات کلاس B در ماه
  * [D1](https://developers.cloudflare.com/d1/) - ۵ میلیون ردیف خوانده شده در روز، ۱۰۰٬۰۰۰ ردیف نوشته شده در روز، ۱ گیگابایت ذخیره‌سازی
  * [Pages](https://developers.cloudflare.com/pages/) - توسعه و استقرار اپلیکیشن‌های وب روی شبکه سریع و امن Cloudflare. ۵۰۰ بیلد ماهانه، ۱۰۰ دامنه سفارشی، SSL یکپارچه، صندلی نامحدود، استقرار پیش‌نمایش نامحدود و قابلیت فول‌استک با ادغام Cloudflare Workers.
  * [Queues](https://developers.cloudflare.com/queues/) - ۱ میلیون عملیات در ماه
  * [TURN](https://developers.cloudflare.com/calls/turn/) – ۱ ترابایت ترافیک (خروجی) رایگان در ماه.

**[⬆️ بازگشت به بالا](#table-of-contents)**

## راهکارهای مدیریت ابر

* [Brainboard](https://www.brainboard.co) - راهکار همکاری برای ساخت و مدیریت بصری زیرساخت‌های ابری از ابتدا تا انتها.
* [Cloud 66](https://www.cloud66.com/) - رایگان برای پروژه‌های شخصی (شامل یک سرور استقرار و یک سایت استاتیک)، Cloud 66 همه چیزهایی که برای ساخت، استقرار و رشد اپلیکیشن‌های خود در هر ابری نیاز دارید را بدون دردسر «موارد سرور» به شما می‌دهد.
* [Pulumi](https://www.pulumi.com/) — زیرساخت مدرن به عنوان کد که به شما اجازه می‌دهد با زبان‌های برنامه‌نویسی و ابزارهای آشنا، زیرساخت ابری بسازید، استقرار دهید و مدیریت کنید.
* [terraform.io](https://www.terraform.io/) — Terraform Cloud. مدیریت حالت راه دور رایگان و همکاری تیمی برای حداکثر ۵۰۰ منبع.
* [scalr.com](https://scalr.com/) - Scalr یک محصول اتوماسیون و همکاری Terraform (TACO) است که برای همکاری و اتوماسیون بهتر روی زیرساخت‌ها و پیکربندی‌های مدیریت‌شده توسط Terraform استفاده می‌شود. پشتیبانی کامل از CLI Terraform، یکپارچه‌سازی OPA و مدل پیکربندی سلسله‌مراتبی. بدون مالیات SSO. همه امکانات شامل می‌شود. تا ۵۰ اجرا در ماه رایگان استفاده کنید.
* [deployment.io](https://deployment.io) - Deployment.io به توسعه‌دهندگان کمک می‌کند تا استقرارها را روی AWS خودکار کنند. در سطح رایگان ما، یک توسعه‌دهنده (کاربر تکی) می‌تواند سایت‌های استاتیک، سرویس‌های وب و محیط‌های نامحدود را استقرار دهد. ۲۰ اجرای شغل رایگان در ماه به همراه پیش‌نمایش و استقرار خودکار در سطح رایگان ارائه می‌شود.

**[⬆️ بازگشت به بالا](#table-of-contents)**

## مخزن‌های کد منبع

* [Bitbucket](https://bitbucket.org/) — ریپازیتوری نامحدود عمومی و خصوصی Git برای حداکثر ۵ کاربر به همراه Pipelines برای CI/CD  
* [chiselapp.com](https://chiselapp.com/) — ریپازیتوری نامحدود عمومی و خصوصی Fossil  
* [codebasehq.com](https://www.codebasehq.com/) — یک پروژه رایگان با ۱۰۰ مگابایت فضا و دو کاربر  
* [Codeberg](https://codeberg.org/) — ریپازیتوری نامحدود عمومی و خصوصی Git برای پروژه‌های رایگان و متن‌باز (با همکاران نامحدود). قدرت‌گرفته از [Forgejo](https://forgejo.org/). میزبانی سایت استاتیک با [Codeberg Pages](https://codeberg.page/). میزبانی CI/CD با [Codeberg's CI](https://docs.codeberg.org/ci/). میزبانی ترجمه با [Codeberg Translate](https://translate.codeberg.org/). شامل میزبانی پکیج و کانتینر، مدیریت پروژه و پیگیری مشکلات
* [GitGud](https://gitgud.io) — ریپازیتوری نامحدود خصوصی و عمومی. رایگان برای همیشه. قدرت‌گرفته از GitLab و Sapphire. CI/CD ارائه نمی‌شود.
* [GitHub](https://github.com/) — ریپازیتوری نامحدود عمومی و خصوصی (با همکاران نامحدود). شامل CI/CD، محیط توسعه، میزبانی استاتیک، میزبانی پکیج و کانتینر، مدیریت پروژه و Copilot هوشمند  
* [gitlab.com](https://about.gitlab.com/) — ریپازیتوری نامحدود عمومی و خصوصی Git با حداکثر ۵ همکار. شامل CI/CD، میزبانی استاتیک، رجیستری کانتینر، مدیریت پروژه و پیگیری مشکلات  
* [framagit.org](https://framagit.org/) — Framagit بستری بر پایه Gitlab از Framasoft با CI، صفحات استاتیک، صفحات پروژه و پیگیری مشکلات.
* [heptapod.net](https://foss.heptapod.net/) — Heptapod یک فورک دوستانه از GitLab Community Edition با پشتیبانی از Mercurial
* [ionicframework.com](https://ionicframework.com/appflow) - ریپو و ابزارهایی برای توسعه اپلیکیشن با Ionic؛ همچنین یک ریپوی اختصاصی ionic دارید
* [NotABug](https://notabug.org) — NotABug.org پلتفرم همکاری کد رایگان برای پروژه‌های دارای مجوز آزاد، مبتنی بر Git
* [OSDN](https://osdn.net/) - OSDN.net یک سرویس رایگان برای توسعه‌دهندگان نرم‌افزار متن‌باز، با ارائه ریپازیتوری‌های SVN/Git/Mercurial/Bazaar/CVS.
  * [Pagure.io](https://pagure.io) — Pagure.io یک پلتفرم همکاری کد نرم‌افزار آزاد و متن‌باز برای پروژه‌هایی با مجوز FOSS، مبتنی بر Git است.
  * [perforce.com](https://www.perforce.com/products/helix-teamhub) — ۱ گیگابایت فضای ابری رایگان و مخازن Git، Mercurial یا SVN.
  * [pijul.com](https://pijul.com/) - سیستم کنترل نسخه توزیع‌شده رایگان و متن‌باز نامحدود. ویژگی برجسته آن بر پایه نظریه قوی وصله‌ها است که یادگیری، استفاده و توزیع آن را آسان می‌کند. بسیاری از مشکلات git/hg/svn/darcs را حل می‌کند.
  * [plasticscm.com](https://plasticscm.com/) — رایگان برای افراد، پروژه‌های متن‌باز و سازمان‌های غیرانتفاعی
  * [projectlocker.com](https://projectlocker.com) — یک پروژه خصوصی رایگان (Git و Subversion) با ۵۰ مگابایت فضا
  * [RocketGit](https://rocketgit.com) — میزبانی مخزن مبتنی بر Git. مخازن عمومی و خصوصی نامحدود.
  * [savannah.gnu.org](https://savannah.gnu.org/) - به عنوان سیستم مدیریت توسعه نرم‌افزار تعاملی برای پروژه‌های نرم‌افزار آزاد (برای پروژه‌های GNU) خدمت می‌کند.
  * [savannah.nongnu.org](https://savannah.nongnu.org/) - به عنوان سیستم مدیریت توسعه نرم‌افزار تعاملی برای پروژه‌های نرم‌افزار آزاد (برای پروژه‌های غیر-GNU) خدمت می‌کند.

**[⬆️ بازگشت به بالا](#table-of-contents)**

## APIها، داده و یادگیری ماشین

  * [JSONGrid](https://jsongrid.com) - ابزار رایگان برای نمایش، ویرایش و فیلتر داده‌های پیچیده JSON در قالب جدول زیبا. ذخیره و اشتراک‌گذاری داده‌های JSON از طریق لینک.
  * [Zerosheets](https://zerosheets.com) - تبدیل صفحات Google Sheets به API قدرتمند جهت توسعه سریع نمونه‌ها، وبسایت‌ها، اپلیکیشن‌ها و ... . ۵۰۰ درخواست در ماه رایگان.
  * [IP.City](https://ip.city) — ۱۰۰ درخواست مکان‌یابی IP رایگان در روز
  * [Abstract API](https://www.abstractapi.com) — مجموعه API برای کاربردهای مختلف، شامل مکان‌یابی IP، شناسایی جنسیت یا اعتبارسنجی ایمیل.
  * [Apify](https://www.apify.com/) — پلتفرم استخراج داده و اتوماسیون برای ساخت API از هر وبسایت و استخراج داده. اسکرپرهای آماده، پروکسی‌های داخلی و راهکارهای سفارشی. طرح رایگان با ۵ دلار اعتبار ماهانه.
  * [APITemplate.io](https://apitemplate.io) - تولید خودکار تصاویر و اسناد PDF با API ساده یا ابزارهای اتوماسیون مانند Zapier و Airtable. نیاز به CSS/HTML ندارد. طرح رایگان شامل ۵۰ تصویر/ماه و سه قالب است.
  * [APIToolkit.io](https://apitoolkit.io) - همه ابزارهای مورد نیاز برای درک کامل عملکرد APIها و Backendها، با اعتبارسنجی خودکار قرارداد API و مانیتورینگ. طرح رایگان تا ۱۰,۰۰۰ درخواست روزانه را پوشش می‌دهد.
  * [APIVerve](https://apiverve.com) - دسترسی سریع به بیش از ۱۲۰+ API رایگان، با تمرکز بر کیفیت و قابلیت اطمینان. طرح رایگان تا ۵۰ توکن API در ماه را پوشش می‌دهد. (احتمالا غیرفعال شده، ۲۵-۰۶-۲۰۲۵)
  * [Arize AI](https://arize.com/) - پلتفرم رصد یادگیری ماشین برای مانیتورینگ مدل و ریشه‌یابی مشکلاتی مانند کیفیت داده و انحراف عملکرد. رایگان تا دو مدل.
  * [Maxim AI](https://getmaxim.ai/) - شبیه‌سازی، ارزیابی و مشاهده عامل‌های هوش مصنوعی. Maxim پلتفرم ارزیابی و مشاهده End-to-End برای کمک به تیم‌ها جهت انتشار قابل‌اعتماد و ۵ برابر سریع‌تر عامل‌های هوش مصنوعی. برای توسعه‌دهندگان مستقل و تیم‌های کوچک (۳ نفره) همیشه رایگان است.
  * [Beeceptor](https://beeceptor.com) - ساخت سریع API جعلی، شبیه‌سازی پاسخ API و امکانات دیگر. ۵۰ درخواست رایگان روزانه، داشبورد عمومی و endpointهای باز (هر کسی که لینک داشبورد را داشته باشد می‌تواند ارسال‌ها و پاسخ‌ها را ببیند).
  * [BigDataCloud](https://www.bigdatacloud.com/) - ارائه APIهای سریع، دقیق و رایگان (نامحدود یا تا ۱۰K-۵۰K/ماه) برای وب مدرن مانند مکان‌یابی IP، Geocoding معکوس، بررسی شبکه، اعتبارسنجی ایمیل و تلفن، اطلاعات کلاینت و بیشتر.
  * [Browse AI](https://www.browse.ai) — استخراج و پایش داده از وب. ۱۰۰۰ اعتبار رایگان در ماه، معادل ۱۰۰۰ درخواست همزمان.
  * [BrowserCat](https://www.browsercat.com) - API مرورگر Headless برای اتوماسیون، Scraping، دسترسی عامل‌های هوش مصنوعی به وب، تولید تصویر/PDF و بیشتر. طرح رایگان با ۱۰۰۰ درخواست در ماه.
  * [Calendarific](https://calendarific.com) - سرویس API تعطیلات عمومی در سطح سازمانی برای بیش از ۲۰۰ کشور. طرح رایگان شامل ۵۰۰ درخواست در ماه.
  * [Canopy](https://www.canopyapi.co/) - API GraphQL برای داده‌های محصولات، جستجو و دسته‌بندی Amazon.com. طرح رایگان شامل ۱۰۰ درخواست در ماه است.
  * [Clarifai](https://www.clarifai.com) — API تصویر برای شناسایی و تشخیص چهره سفارشی. امکان آموزش مدل‌های هوش مصنوعی. طرح رایگان دارای ۱۰۰۰ درخواست در ماه است.
  * [Cloudmersive](https://cloudmersive.com/) — پلتفرم API ابزارهای کاربردی با دسترسی کامل به مجموعه وسیع API شامل تبدیل اسناد، اسکن ویروس و ... با ۶۰۰ درخواست/ماه، فقط در منطقه آمریکای شمالی، حداکثر اندازه فایل ۲.۵ مگابایت.
  * [Colaboratory](https://colab.research.google.com) — محیط نوت‌بوک Python مبتنی بر وب با GPU Nvidia Tesla K80 رایگان.
  * [CometML](https://www.comet.com/site/) - پلتفرم MLOps برای ردیابی آزمایشات، مدیریت تولید مدل، رجیستری مدل و ردیابی کامل داده‌ها، از آموزش تا تولید. رایگان برای افراد و دانشگاهیان.
  * [Commerce Layer](https://commercelayer.io) - API تجارت ترکیبی که امکان ساخت، ثبت و مدیریت سفارش‌ها از هر Front End را می‌دهد. پلن توسعه‌دهنده اجازه ۱۰۰ سفارش در ماه و تا ۱۰۰۰ SKU رایگان را می‌دهد.
  * [Composio](https://composio.dev/) - پلتفرم یکپارچه‌سازی برای عامل‌های هوش مصنوعی و LLMها. بیش از ۲۰۰ ابزار را در اینترنت عامل‌محور یکپارچه کنید.
  * [Conversion Tools](https://conversiontools.io/) - مبدل آنلاین فایل برای اسناد، تصاویر، ویدیو، صدا و کتاب‌های الکترونیکی. API REST موجود است. کتابخانه‌هایی برای Node.js، PHP، Python. پشتیبانی از فایل تا ۵۰ گیگابایت (برای طرح‌های پولی). سطح رایگان محدود به اندازه فایل (۲۰ مگابایت) و تعداد تبدیل (۳۰/روز، ۳۰۰/ماه) است.
  * [Country-State-City Microservice API](https://country-state-city.rebuscando.info/) - API و میکروسرویس برای ارائه اطلاعات متنوع مانند کشورها، مناطق، استان‌ها، شهرها، کدهای پستی و ... . طرح رایگان تا ۱۰۰ درخواست در روز.
  * [Coupler](https://www.coupler.io/) - ابزار یکپارچه‌سازی داده که بین اپ‌ها همگام‌سازی می‌کند. امکان ساخت داشبورد زنده و گزارش، تبدیل و دستکاری مقادیر و جمع‌آوری و پشتیبان‌گیری داده‌ها. طرح رایگان محدود به یک کاربر، اتصال داده، منبع و مقصد داده است. نیاز به بروزرسانی دستی داده دارد.
  * [CraftMyPDF](https://craftmypdf.com) - تولید خودکار اسناد PDF از قالب‌های قابل استفاده مجدد با ویرایشگر Drag & Drop و API ساده. طرح رایگان شامل ۱۰۰ PDF/ماه و سه قالب است.
  * [Crawlbase](https://crawlbase.com/) — خزیدن و استخراج داده از وبسایت‌ها بدون پروکسی، زیرساخت یا مرورگر. Captcha را برای شما حل می‌کنیم و از بلاک شدن جلوگیری می‌کنیم. اولین ۱۰۰۰ درخواست رایگان است.
  * [CurlHub](https://curlhub.io) — سرویس پروکسی برای بازرسی و اشکال‌زدایی درخواست‌های API. طرح رایگان شامل ۱۰,۰۰۰ درخواست در ماه است.
  * [CurrencyScoop](https://currencyscoop.com) - API داده ارز لحظه‌ای برای اپ‌های فین‌تک. طرح رایگان شامل ۵,۰۰۰ درخواست در ماه است.
  * [Cube](https://cube.dev/) - به مهندسان داده و توسعه‌دهندگان کمک می‌کند تا به داده‌های فروشگاه‌های مدرن دسترسی یافته، آن‌ها را سازمان‌دهی و به هر اپلیکیشنی منتقل کنند. سریع‌ترین روش استفاده، Cube Cloud است که سطح رایگان آن به ۱,۰۰۰ پرس‌وجو در روز محدود است.
  * [Data Dead Drop](https://datadeaddrop.com) - اشتراک‌گذاری فایل ساده و رایگان. داده پس از دسترسی حذف می‌شود. بارگذاری و دانلود داده از طریق مرورگر یا کلاینت خط فرمان.
  * [Data Fetcher](https://datafetcher.com) - اتصال Airtable به هر اپلیکیشن یا API بدون کدنویسی. رابط مشابه Postman برای اجرای درخواست‌های API در Airtable. یکپارچه‌سازی آماده با ده‌ها اپلیکیشن. طرح رایگان شامل ۱۰۰ اجرای ماهانه است.
  * [Dataimporter.io](https://www.dataimporter.io) - ابزار اتصال، پاک‌سازی و وارد کردن داده به Salesforce. طرح رایگان تا ۲۰,۰۰۰ رکورد در ماه را شامل می‌شود.
  * [Datalore](https://datalore.jetbrains.com) - نوت‌بوک‌های پایتون توسط Jetbrains. شامل ۱۰ گیگابایت فضای ذخیره‌سازی و ۱۲۰ ساعت زمان اجرا در هر ماه.
  * [Data Miner](https://dataminer.io/) - افزونه مرورگر (Google Chrome، MS Edge) برای استخراج داده از صفحات وب به CSV یا Excel. طرح رایگان ۵۰۰ صفحه در ماه می‌دهد.
  * [Datapane](https://datapane.com) - API برای ساخت گزارش‌های تعاملی در پایتون و استقرار اسکریپت‌ها و نوت‌بوک‌های Jupyter به عنوان ابزارهای سلف‌سرویس.
  * [DB-IP](https://db-ip.com/api/free) - API مکان‌یابی IP رایگان با ۱۰۰۰ درخواست به ازای هر IP در روز. دیتابیس lite تحت مجوز CC-BY 4.0 نیز رایگان است.
  * [DB Designer](https://www.dbdesigner.net/) — ابزار ابری طراحی و مدل‌سازی شِمای پایگاه داده با پلن استارتر رایگان شامل ۲ مدل پایگاه داده و ۱۰ جدول در هر مدل.
  * [DeepAR](https://developer.deepar.ai) — فیلترهای واقعیت افزوده صورت برای هر پلتفرم با یک SDK. طرح رایگان تا ۱۰ کاربر فعال ماهانه (MAU) و ردیابی تا ۴ چهره را ارائه می‌دهد.
  * [Deepnote](https://deepnote.com) - نوت‌بوک علم داده جدید. سازگار با Jupyter، با همکاری همزمان و اجرای ابری. سطح رایگان شامل پروژه‌های شخصی نامحدود، ماشین‌های پایه نامحدود با ۵ گیگابایت RAM و ۲vCPU و تیم‌هایی تا ۳ ویرایشگر است.
  * [Disease.sh](https://disease.sh/) — API رایگان برای ارائه داده‌های دقیق جهت ساخت اپلیکیشن‌های کاربردی مرتبط با کووید-۱۹.
  * [Doczilla](https://www.doczilla.app/) — API SaaS برای تولید اسکرین‌شات یا PDF مستقیماً از کد HTML/CSS/JS. طرح رایگان اجازه ۲۵۰ سند در ماه را می‌دهد.
  * [Doppio](https://doppio.sh/) — API مدیریت‌شده برای تولید و ذخیره خصوصی PDF و اسکرین‌شات با فناوری رندرینگ پیشرفته. طرح رایگان اجازه ۴۰۰ PDF و اسکرین‌شات در ماه را می‌دهد.
  * [drawDB](https://drawdb.app/) — ویرایشگر آنلاین دیاگرام پایگاه داده رایگان و متن‌باز بدون نیاز به ثبت‌نام.
  * [dreamfactory.com](https://dreamfactory.com/) — Backend API REST متن‌باز برای اپلیکیشن‌های موبایل، وب و اینترنت اشیا. اتصال به هر پایگاه داده SQL/NoSQL، سیستم ذخیره‌سازی فایل یا سرویس خارجی و ایجاد فوری یک پلتفرم API REST جامع با مستندات زنده و مدیریت کاربران.
  * [Duply.co](https://duply.co) — تولید تصاویر داینامیک از طریق API و URL، یک بار قالب را طراحی و بارها استفاده کنید. سطح رایگان ۲۰ اعتبار رایگان ارائه می‌دهد.
  * [DynamicDocs](https://advicement.io) - تولید اسناد PDF با API JSON به PDF بر پایه قالب‌های LaTeX. طرح رایگان ۵۰ فراخوانی API در ماه و دسترسی به کتابخانه قالب‌ها را دارد.
  * [Efemarai](https://efemarai.com) - پلتفرم تست و اشکال‌زدایی مدل‌ها و داده‌های یادگیری ماشین. امکان مشاهده هر گراف محاسباتی. استفاده محلی رایگان.
  * [ERD Lab](https://www.erdlab.io) — ابزار ابری رایگان برای ساخت دیاگرام رابطه موجودیت (ERD) برای توسعه‌دهندگان. دوره آزمایشی رایگان شامل ۲ پروژه با ۱۰ جدول در هر پروژه است.
  * [ExtendsClass](https://extendsclass.com/rest-client-online.html) - کلاینت HTTP مبتنی بر وب رایگان برای ارسال درخواست‌های HTTP.
  * [Export SDK](https://exportsdk.com) - API تولید PDF با ویرایشگر قالب Drag & Drop که SDK و یکپارچگی بدون کد را ارائه می‌دهد. طرح رایگان شامل ۲۵۰ صفحه ماهانه، کاربران نامحدود و سه قالب است.
  * [file.coffee](https://file.coffee/) - پلتفرمی برای ذخیره‌سازی تا ۱۵ مگابایت/فایل (۳۰ مگابایت/فایل با حساب کاربری).
  * [Financial Data](https://financialdata.net/) - API داده بازار سهام و مالی. طرح رایگان اجازه ۳۰۰ درخواست روزانه را می‌دهد.
  * [FormatJSONOnline.com](https://formatjsononline.com) - ابزار رایگان مبتنی بر مرورگر برای فرمت‌بندی، اعتبارسنجی، مقایسه و فشرده‌سازی داده‌های JSON به‌صورت آنی.
  * [FraudLabs Pro](https://www.fraudlabspro.com) — غربال سفارش برای شناسایی تقلب پرداخت با کارت اعتباری. این API همه ویژگی‌های ممکن تقلب را بر اساس پارامترهای ورودی سفارش شناسایی می‌کند. پلن رایگان Micro تا ۵۰۰ تراکنش در ماه را پشتیبانی می‌کند.
  * [GeoDataSource](https://www.geodatasource.com) — سرویس جستجوی موقعیت که نام شهر را با استفاده از مختصات جغرافیایی پیدا می‌کند. تا ۵۰۰ درخواست رایگان در ماه.
  * [Geolocated.io](https://geolocated.io) — API مکان‌یابی IP با سرورهای چند قاره‌ای و طرح رایگان با ۲,۰۰۰ درخواست روزانه.
  * [Glitterly](https://glitterly.app/) - تولید برنامه‌نویسی تصاویر پویا از قالب‌های پایه. API Restful و یکپارچگی بدون کد. سطح رایگان شامل ۵۰ تصویر/ماه و پنج قالب است.
  * [Hex](https://hex.tech/) - پلتفرم داده تعاملی برای نوت‌بوک‌ها، اپ‌های داده و کتابخانه دانش. سطح رایگان جامعه با تا پنج پروژه.
  * [Hook0](https://www.hook0.com/) - Hook0 یک سرویس وب‌هوک متن‌باز است که ارائه وب‌هوک را برای محصولات آنلاین آسان می‌کند. ارسال تا ۱۰۰ رویداد در روز با ۷ روز نگهداری تاریخچه رایگان.
  * [Hoppscotch](https://hoppscotch.io) - ابزار ساخت سریع و زیبا برای درخواست‌های API، رایگان و سریع.
  * [huggingface.co](https://huggingface.co) - ساخت، آموزش و استقرار مدل‌های NLP برای Pytorch، TensorFlow و JAX. تا ۳۰ هزار کاراکتر ورودی در ماه رایگان.
  * [Hybiscus](https://hybiscus.dev/) - ساخت گزارش PDF با API ساده و اعلامی. سطح رایگان ۱۴ روزه شامل ۵۰ گزارش تک‌صفحه‌ای با قابلیت سفارشی‌سازی رنگ و فونت است.
  * [Invantive Cloud](https://cloud.invantive.com/) — دسترسی به بیش از ۷۰ پلتفرم (ابری) مانند Exact Online، Twinfield، ActiveCampaign یا Visma با Invantive SQL یا OData4 (معمولاً Power BI یا Power Query). شامل تکرار و تبادل داده. طرح رایگان برای توسعه‌دهندگان و مشاوران پیاده‌سازی. برای پلتفرم‌های خاص با محدودیت در حجم داده رایگان است.
  * [ipaddress.sh](https://ipaddress.sh) — سرویس ساده برای دریافت آدرس IP عمومی در فرمت‌های مختلف [formats](https://about.ipaddress.sh/).
  * [ip-api](https://ip-api.com) — API مکان‌یابی IP، رایگان برای استفاده غیرتجاری، بدون نیاز به API key، محدودیت ۴۵ درخواست در دقیقه از یک IP برای پلن رایگان.
  * [ipbase.com](https://ipbase.com) - API مکان‌یابی IP - پلن رایگان همیشگی با ۱۵۰ درخواست ماهانه.
  * [IP Geolocation](https://ipgeolocation.io/) — API مکان‌یابی IP - پلن رایگان همیشگی برای توسعه‌دهندگان با محدودیت ۱,۰۰۰ درخواست در روز.
  * [IP Geolocation API](https://www.abstractapi.com/ip-geolocation-api) — API مکان‌یابی IP از Abstract - اجازه ۱,۰۰۰ درخواست رایگان.
  * [IPLocate](https://www.iplocate.io) — API مکان‌یابی IP، تا ۱,۰۰۰ درخواست رایگان در روز. شامل شناسایی پروکسی/VPN/هاستینگ، داده ASN، IP به شرکت و بیشتر. IPLocate همچنین دیتابیس IP به کشور و IP به ASN را به صورت CSV یا فرمت MMDB سازگار با GeoIP رایگان ارائه می‌کند.
  * [IP2Location](https://www.ip2location.com) — سرویس مکان‌یابی IP رایگان و پولی. دیتابیس LITE برای دانلود رایگان موجود است. دیتابیس را روی سرور ایمپورت کرده و به صورت محلی برای شهر، مختصات و اطلاعات ISP پرس‌وجو انجام دهید.
  * [IP2Location.io](https://www.ip2location.io/) — سرویس API مکان‌یابی IP سریع و قابل اعتماد. دریافت داده‌هایی مانند شهر، مختصات، ISP و ... . طرح رایگان شامل ۵۰ هزار اعتبار ماهانه است. همچنین ۵۰۰ جستجوی WHOIS و دامنه میزبانی شده رایگان در ماه ارائه می‌شود. برای مشاهده جزئیات ثبت دامنه و یافتن دامنه‌های میزبانی شده روی یک IP خاص. برای امکانات بیشتر به پلن پولی ارتقا دهید.
  * [ipapi](https://ipapi.co/) - API موقعیت‌یابی IP توسط Kloudend, Inc - API قابل اعتماد مبتنی بر AWS که توسط شرکت‌های Fortune 500 استفاده می‌شود. سطح رایگان تا ۳۰ هزار جستجو در ماه (۱۰۰۰ در روز) بدون ثبت نام ارائه می‌دهد.
  * [ipapi.is](https://ipapi.is/) - API موقعیت‌یابی IP قابل اعتماد از توسعه‌دهندگان برای توسعه‌دهندگان با بهترین قابلیت شناسایی هاستینگ. پلن رایگان ۱۰۰۰ جستجو بدون ثبت‌نام ارائه می‌دهد.
  * [IPinfo](https://ipinfo.io/) — API داده آدرس IP سریع، دقیق و رایگان (تا ۵۰ هزار در ماه). ارائه APIهای اطلاعات مکان‌یابی، شرکت‌ها، اپراتورها، محدوده IP، دامنه‌ها، تماس‌های سوءاستفاده و بیشتر. همه APIهای پولی را می‌توان رایگان آزمایش کرد.
  * [IPQuery](https://ipquery.io) — API نامحدود IP برای توسعه‌دهندگان، بدون محدودیت نرخ یا قیمت‌گذاری.
  * [IPTrace](https://iptrace.io) — API بسیار ساده برای ارائه داده مکان‌یابی IP قابل اعتماد و مفید برای کسب‌وکار شما با ۵۰,۰۰۰ جستجوی رایگان در ماه.
  * [JSON2Video](https://json2video.com) - API ویرایش ویدیو برای خودکارسازی بازاریابی ویدیو و ویدیوهای شبکه‌های اجتماعی، به صورت برنامه‌نویسی یا بدون کد.
  * [JSON IP](https://getjsonip.com) — آدرس IP عمومی کلاینت درخواست‌کننده را بازمی‌گرداند. برای سطح رایگان نیاز به ثبت‌نام نیست. با استفاده از CORS، داده‌ها را می‌توان مستقیماً از مرورگر با JS سمت کلاینت درخواست کرد. برای سرویس‌هایی که تغییر IP کلاینت و سرور را پایش می‌کنند مفید است. درخواست نامحدود.
  * [JSON Serve](https://jsonserve.com/) — سرویسی رایگان که به توسعه‌دهندگان کمک می‌کند اشیای JSON را ذخیره کرده و از آن به عنوان API REST در برنامه خود استفاده کنند.
  * [JSONing](https://jsoning.com/api/) — ساخت API REST جعلی از یک شی JSON و سفارشی‌سازی کد وضعیت HTTP، هدرها و بدنه پاسخ.
  * [konghq.com](https://konghq.com/) — بازار API و ابزار قدرتمند خصوصی و عمومی API. در سطح رایگان برخی امکانات مانند مانیتورینگ، هشدار و پشتیبانی محدود است.
  * [Kreya](https://kreya.app) — کلاینت GUI رایگان gRPC برای فراخوانی و تست APIهای gRPC. امکان وارد کردن APIهای gRPC از طریق بازتاب سرور.
  * [Lightly](https://www.lightly.ai/) — بهبود مدل‌های یادگیری ماشین با استفاده از داده صحیح. تا ۱۰۰۰ نمونه داده رایگان استفاده کنید.
  * [LoginLlama](https://loginllama.app) - API امنیت ورود برای شناسایی ورودهای مشکوک و اطلاع‌رسانی به مشتریان. رایگان برای ۱,۰۰۰ ورود در ماه.
  * [MailboxValidator](https://www.mailboxvalidator.com) — سرویس اعتبارسنجی ایمیل با اتصال واقعی به سرور ایمیل برای تایید اعتبار ایمیل. طرح رایگان API دارای ۱۰۰ تایید در ماه است.
  * [Market Data API](https://www.marketdata.app) - ارائه داده‌های مالی لحظه‌ای و تاریخی برای سهام، آپشن، صندوق‌های سرمایه‌گذاری و ... . سطح رایگان همیشگی اجازه ۱۰۰ درخواست API روزانه بدون هزینه را می‌دهد.
  * [Meteosource Weather API](https://www.meteosource.com/) — API جهانی هواشناسی برای داده‌های آب و هوای فعلی و پیش‌بینی شده. پیش‌بینی‌ها بر اساس ترکیب یادگیری ماشین چندین مدل آب و هوایی برای دقت بهتر ایجاد می‌شوند. پلن رایگان شامل ۴۰۰ فراخوان در روز است.
  * [microlink.io](https://microlink.io/) – هر وب‌سایتی را به داده تبدیل می‌کند، مانند نرمال‌سازی متاتگ‌ها، پیش‌نمایش زیبای لینک، قابلیت اسکرپینگ یا ارائه اسکرین‌شات به عنوان سرویس. ۵۰ درخواست در روز، هر روز رایگان.
  * [Mindee](https://developers.mindee.com) – Mindee نرم‌افزار OCR قدرتمند و پلتفرم API-first است که به توسعه‌دهندگان کمک می‌کند تا لایه پردازش اسناد را از طریق شناسایی داده‌های کلیدی با بینایی ماشین و یادگیری ماشین استانداردسازی و جریان‌های کاری را خودکار کنند. پلن رایگان ماهانه ۵۰۰ صفحه ارائه می‌دهد.
  * [Mintlify](https://mintlify.com) — استاندارد مدرن برای مستندسازی API. کامپوننت‌های زیبا و قابل نگهداری، جستجوی درون‌برنامه و محیط تعاملی. رایگان برای ۱ ویرایشگر.
  * [MockAPI](https://www.mockapi.io/) — MockAPI ابزاری ساده برای ساخت سریع APIهای فرضی، تولید داده سفارشی و انجام عملیات با رابط RESTful است. مخصوص نمونه‌سازی/تست/یادگیری است. یک پروژه/۲ منبع در هر پروژه رایگان.
  * [Mockfly](https://www.mockfly.dev/) — Mockfly ابزاری مطمئن برای توسعه‌دهندگان جهت ساخت API فرضی و مدیریت ویژگی‌های پرچم‌دار است. به سرعت API فرضی بسازید و کنترل کنید. پلن رایگان شامل ۵۰۰ درخواست در روز است.
  * [Mocki](https://mocki.io) - ابزاری برای ساخت APIهای GraphQL و REST فرضی که با مخزن GitHub همگام می‌شوند. ساخت و استفاده از APIهای REST ساده بدون نیاز به ثبت‌نام رایگان است.
  * [Mocko.dev](https://mocko.dev/) — پروکسی API شما، انتخاب اندپوینت‌هایی که باید در ابر شبیه‌سازی شوند و بازرسی ترافیک، رایگان. توسعه و تست یکپارچه خود را سریع‌تر کنید.
  * [Mocky](https://designer.mocky.io/) - اپلیکیشن وب ساده برای تولید پاسخ‌های HTTP سفارشی جهت شبیه‌سازی درخواست‌های HTTP. همچنین به صورت [متن‌باز](https://github.com/julien-lafont/Mocky) موجود است.
  * [Mock N Roll](https://mpcknroll.me/) - سرویس رایگان Mock API—ابزاری قدرتمند برای شبیه‌سازی پاسخ‌های واقعی API بدون تاخیر بک‌اند. ایده‌آل برای توسعه‌دهندگان فرانت‌اند، تست‌کنندگان QA و تیم‌های DevOps. [مخزن](https://github.com/haerulmuttaqin/mocknroll-web).
  * [microenv.com](https://microenv.com) — ساخت API فرضی REST برای توسعه‌دهندگان با امکان تولید کد و اپلیکیشن در کانتینر داکر.
  * [Multi-Exit IP Address Checker](https://ip.alstra.ca/) — ابزاری رایگان و ساده برای بررسی آدرس IP خروجی شما از طریق چند گره و فهمیدن چگونگی دیده شدن IP در مناطق و سرویس‌های مختلف جهان. مفید برای تست ابزارهای تقسیم DNS مبتنی بر قانون مانند Control D.
  * [Namekit](https://namekit.app/) - کشف دامنه با هوش مصنوعی – یافتن نام‌های موجود با قیمت استاندارد به صورت فوری. جستجوی رایگان روزانه.
  * [News API](https://newsapi.org) — جستجوی اخبار وب با کد و دریافت نتایج JSON. توسعه‌دهندگان روزانه ۱۰۰ جستجوی رایگان دارند. مقالات با تاخیر ۲۴ ساعته.
  * [numlookupapi.com](https://numlookupapi.com) - API رایگان اعتبارسنجی شماره تلفن - ۱۰۰ درخواست رایگان در ماه.
  * [OCR.Space](https://ocr.space/) — API OCR برای پارس کردن تصاویر و فایل‌های PDF و بازگرداندن نتایج متنی به فرمت JSON. ۲۵٬۰۰۰ درخواست در ماه رایگان، محدودیت حجم فایل ۱ مگابایت.
  * [OpenAPI3 Designer](https://openapidesigner.com/) — ساخت تصویری تعاریف Open API 3 به صورت رایگان.
  * [parsehub.com](https://parsehub.com/) — استخراج داده از سایت‌های داینامیک، تبدیل وب‌سایت‌های داینامیک به API، پنج پروژه رایگان.
  * [Parseur](https://parseur.com) — ۲۰ صفحه رایگان در ماه: استخراج داده از PDF و ایمیل. مبتنی بر هوش مصنوعی. دسترسی کامل به API.
  * [PDFBolt](https://pdfbolt.com) - API تولید PDF با تمرکز بر توسعه‌دهندگان و حفظ حریم خصوصی. مستندسازی الهام‌گرفته از Stripe و شامل ۵۰۰ تبدیل PDF رایگان در ماه.
  * [pdfEndpoint.com](https://pdfendpoint.com) - تبدیل آسان HTML یا URL به PDF با یک API ساده. صد تبدیل در ماه رایگان.
  * [PDF-API.io](https://pdf-api.io) - API اتوماسیون PDF، ویرایشگر قالب بصری یا HTML به PDF، یکپارچه‌سازی داده پویا و رندر PDF با API. پلن رایگان شامل یک قالب، ۱۰۰ PDF در ماه.
  * [Pixela](https://pixe.la/) - سرویس پایگاه داده daystream رایگان. تمام عملیات توسط API انجام می‌شود. مصورسازی با نقشه‌های حرارتی و نمودار خطی نیز ممکن است.
  * [Postman](https://postman.com) — ساده‌سازی گردش کار و ایجاد APIهای بهتر و سریع‌تر با Postman، پلتفرم همکاری در توسعه API. استفاده از اپلیکیشن Postman برای همیشه رایگان است. قابلیت‌های ابری Postman نیز با محدودیت‌هایی رایگان هستند.
  * [Insomnia](https://insomnia.rest) - کلاینت API متن‌باز برای طراحی و تست APIها، پشتیبانی از REST و GraphQL.
  * [PrefectCloud](https://www.prefect.io/cloud/) — پلتفرم کامل اتوماسیون جریان داده. پلن رایگان شامل ۵ ورک‌فلو مستقر شده و ۵۰۰ دقیقه اعتبار محاسبات سرورلس در ماه است.
  * [Preset Cloud](https://preset.io/) - سرویس میزبانی‌شده Apache Superset. برای همیشه رایگان برای تیم‌هایی تا ۵ کاربر، با داشبورد و نمودار نامحدود، سازنده نمودار بدون کد و ویرایشگر SQL همکاری‌محور.
  * [PromptLoop](https://www.promptloop.com/) - PromptLoop اسکرپینگ وب با هوش مصنوعی را ۱۰ برابر آسان‌تر، با صرفه‌جویی ۸۵٪ در زمان و ۴ برابر سریع‌تر از تحقیقات دستی، به همراه اندپوینت REST API برای تمام وظایف تحقیقاتی ارائه می‌دهد. ۱۰۰۰ اعتبار اول هر ماه رایگان است.
  * [Public-Apis Github Repo](https://github.com/public-apis/public-apis) — لیستی از APIهای عمومی رایگان.
  * [Rapidapi](https://rapidapi.com/) - بزرگترین مرکز API جهان، میلیون‌ها توسعه‌دهنده به هزاران API متصل می‌شوند، توسعه API با چالش‌های سرگرم‌کننده (به همراه راه‌حل!) و مثال‌های تعاملی.
  * [RequestBin.com](https://requestbin.com) — ایجاد یک اندپوینت رایگان برای ارسال درخواست‌های HTTP. هر درخواست HTTP ارسالی به آن اندپوینت همراه با payload و header ثبت می‌شود تا بتوانید رفتار webhookها و سایر سرویس‌ها را مشاهده کنید.
  * [reqres.in](https://reqres.in) - API REST میزبانی‌شده و رایگان برای پاسخ به درخواست‌های AJAX شما.
  * [Roboflow](https://roboflow.com) - ساخت و استقرار مدل بینایی ماشین سفارشی بدون نیاز به تجربه یادگیری ماشین. پلن رایگان شامل ۳۰ اعتبار در ماه است.
  * [ROBOHASH](https://robohash.org/) - سرویس وب برای تولید تصاویر منحصر به فرد و جذاب از هر متن.
  * [Scraper's Proxy](https://scrapersproxy.com) — API پراکسی HTTP ساده برای اسکرپینگ. اسکرپ کردن به صورت ناشناس بدون نگرانی از محدودیت، بلاک یا کپچا. ۱۰۰ اسکرپ موفق ماهانه رایگان شامل رندر جاوااسکریپت (در صورت تماس با پشتیبانی بیشتر).
  * [ScrapingAnt](https://scrapingant.com/) — API اسکرپینگ با Chrome بدون هد و سرویس پراکسی رایگان. رندرینگ جاوااسکریپت، پروکسی‌های چرخشی پریمیوم، عبور از CAPTCHA. ۱۰٬۰۰۰ اعتبار API رایگان.
  * [Simplescraper](https://simplescraper.io) — فراخوانی webhook پس از هر عملیات. پلن رایگان شامل ۱۰۰ اعتبار اسکرپ ابری.
  * [Select Star](https://www.selectstar.com/) - پلتفرم هوشمند کشف داده که داده‌های شما را به طور خودکار تحلیل و مستندسازی می‌کند. پلن رایگان با ۲ منبع داده، تا ۱٬۰۰۰ جدول و ۲۵ کاربر.
  * [Sheetson](https://sheetson.com) - تبدیل سریع هر Google Sheets به API RESTful. پلن رایگان شامل ۱٬۰۰۰ ردیف رایگان در هر شیت.
  * [Shipyard](https://www.shipyardapp.com) — پلتفرم ارکستراسیون داده کم‌کد ابری. ساخت با ترکیبی از قالب‌های کم‌کد و کد شما (پایتون، Node.js، Bash، SQL). پلن رایگان توسعه‌دهنده شامل ۱۰ ساعت زمان اجرا در ماه برای یک کاربر است که برای خودکارسازی چندین جریان کاری کافی است.
  * [Siterelic](https://siterelic.com/) - API Siterelic امکان گرفتن اسکرین‌شات، ممیزی وب‌سایت، اسکن TLS، جستجوی DNS، تست TTFB و موارد دیگر را می‌دهد. پلن رایگان شامل ۱۰۰ درخواست API در ماه است.
  * [SerpApi](https://serpapi.com/) - API اسکرپینگ موتور جستجوی لحظه‌ای. بازگرداندن نتایج ساختاریافته JSON برای Google، YouTube، Bing، Baidu، Walmart و بسیاری دیگر. پلن رایگان شامل ۱۰۰ فراخوان موفق API در ماه است.
  * [SmartParse](https://smartparse.io) - SmartParse پلتفرم مهاجرت داده و CSV به API است که ابزارهای صرفه‌جویی زمان و هزینه برای توسعه‌دهندگان ارائه می‌دهد. پلن رایگان شامل ۳۰۰ واحد پردازشی در ماه، آپلود مرورگر، قرنطینه داده، قطع‌کننده مدار و هشدارهای شغلی است.
  * [Sofodata](https://www.sofodata.com/) - ساخت APIهای امن RESTful از فایل‌های CSV. آپلود فایل CSV و دسترسی فوری به داده‌ها از طریق API برای توسعه سریع‌تر برنامه‌ها. پلن رایگان شامل ۲ API و ۲٬۵۰۰ فراخوان API در ماه. نیازی به کارت اعتباری نیست.
  * [Sqlable](https://sqlable.com/) - مجموعه‌ای از ابزارهای رایگان آنلاین SQL، شامل فرمت‌کننده و اعتبارسنج SQL، تستر regex SQL، تولیدکننده داده جعلی و محیط تست تعاملی پایگاه داده.
  * [Stoplight](https://stoplight.io/) - نرم‌افزار SaaS برای طراحی و مستندسازی گروهی APIها. پلن رایگان شامل ابزارهای طراحی، شبیه‌سازی و مستندسازی رایگان است.
  * [Supportivekoala](https://supportivekoala.com/) — امکان تولید خودکار تصویر بر اساس ورودی شما از طریق قالب‌ها. پلن رایگان تا ۵۰ تصویر در ماه ایجاد می‌کند.
  * [Svix](https://www.svix.com/) - Webhooks به عنوان سرویس. تا ۵۰٬۰۰۰ پیام در ماه رایگان ارسال کنید.
  * [Tavily AI](https://tavily.com/) - API برای جستجوی آنلاین، بینش سریع و تحقیقات جامع با قابلیت سازماندهی نتایج تحقیق. ۱٬۰۰۰ درخواست در ماه در پلن رایگان بدون نیاز به کارت اعتباری.
  * [The IP API](https://theipapi.com/) - API مکان‌یابی IP با ۱٬۰۰۰ درخواست رایگان در روز. اطلاعاتی درباره موقعیت آدرس IP شامل کشور، شهر، منطقه و غیره ارائه می‌کند.
  * [TinyMCE](https://www.tiny.cloud) - API ویرایشگر متن غنی. قابلیت‌های اصلی برای استفاده نامحدود رایگان است.
  * [Tomorrow.io Weather API](https://www.tomorrow.io/weather-api/) - ارائه پلن رایگان API هواشناسی. پیش‌بینی دقیق و به‌روز با پوشش جهانی، داده‌های تاریخی و راهکارهای پایش آب و هوا.
  * [Treblle](https://www.treblle.com) - Treblle به تیم‌ها برای ساخت، استقرار و مدیریت APIها کمک می‌کند. با گردآوری لاگ پیشرفته، قابلیت مشاهده، مستندسازی و دیباگینگ. همه قابلیت‌ها رایگان است اما محدودیت ۲۵۰ هزار درخواست در ماه برای پلن رایگان وجود دارد.
  * [UniRateAPI](https://unirateapi.com) – نرخ لحظه‌ای ارز برای ۵۹۰+ ارز و رمزارز. فراخوان نامحدود API در پلن رایگان، ایده‌آل برای توسعه‌دهندگان و اپ‌های مالی.
  * [vatcheckapi.com](https://vatcheckapi.com) - API ساده و رایگان برای اعتبارسنجی شماره VAT. ۱۵۰ اعتبارسنجی رایگان در ماه.
  * [WeatherXu](https://weatherxu.com/) — داده‌های جهانی آب و هوا شامل وضعیت فعلی، پیش‌بینی ساعتی و روزانه، و هشدارهای آب و هوایی از طریق API. ادغام مدل‌های هوش مصنوعی و ML برای تحلیل و ترکیب چند مدل آب و هوایی جهت ارائه پیش‌بینی دقیق‌تر. پلن رایگان شامل ۱۰٬۰۰۰ فراخوان API در ماه است.
  * [Webhook Store](https://www.openwebhook.io) - ابزاری برای ذخیره و اشکال‌زدایی webhookهای شخص ثالث در محیط لوکال (سبک ngrok). متن‌باز و قابل میزبانی شخصی. دامنه شخصی رایگان *username*.github.webhook.store، دامنه عمومی رایگان *anything*.webhook.store.
  * [WebScraping.AI](https://webscraping.ai) - API ساده برای اسکرپینگ وب با پارسینگ داخلی، رندر Chrome و پراکسی. دو هزار فراخوان API رایگان در ماه.
  * [Weights & Biases](https://wandb.ai) — پلتفرم MLOps برای توسعه‌دهندگان. ساخت مدل‌های بهتر سریع‌تر با ردیابی آزمایشات، نسخه‌بندی داده و مدیریت مدل. پلن رایگان فقط برای پروژه‌های شخصی، با ۱۰۰ گیگابایت فضای ذخیره‌سازی.
  * [What The Diff](https://whatthediff.ai) - دستیار بازبینی کد مبتنی بر هوش مصنوعی. پلن رایگان تا ۲۵٬۰۰۰ توکن ماهانه (~۱۰ PR).
  * [wolfram.com](https://wolfram.com/language/) — الگوریتم‌های مبتنی بر دانش داخلی در ابر.
  * [wrapapi.com](https://wrapapi.com/) — تبدیل هر وب‌سایت به API پارامتریک. ۳۰٬۰۰۰ فراخوان API در ماه.
  * [Zenscrape](https://zenscrape.com/web-scraping-api) — API اسکرپینگ وب با مرورگرهای بدون هد، IPهای مسکونی و قیمت‌گذاری شفاف. هزار فراخوان رایگان API در ماه و اعتبار اضافه برای دانشجویان و سازمان‌های غیرانتفاعی.
  * [Zipcodebase](https://zipcodebase.com) - API رایگان کدپستی، دسترسی به داده‌های جهانی کدپستی. ۵٬۰۰۰ درخواست رایگان در ماه.
  * [Zipcodestack](https://zipcodestack.com) - API رایگان کدپستی و اعتبارسنجی کدپستی. ده هزار درخواست رایگان در ماه.
  * [Zuplo](https://zuplo.com/) - پلتفرم رایگان مدیریت API برای طراحی، ساخت و استقرار APIها در Edge. افزودن احراز هویت API Key، محدودیت نرخ، مستندسازی توسعه‌دهنده و درآمدزایی به هر API در چند دقیقه. مبتنی بر OpenAPI و کاملاً قابل برنامه‌نویسی با APIهای استاندارد وب و Typescript. پلن رایگان تا ۱۰ پروژه، محیط تولیدی Edge نامحدود، ۱ میلیون درخواست ماهانه و ۱۰ گیگابایت خروجی ارائه می‌دهد.

**[⬆️ بازگشت به بالا](#table-of-contents)**

## مخزن‌های آرتیفکت (Artifact Repos)

  * [Artifactory](https://jfrog.com/start-free/) - مخزن آرتیفکت با پشتیبانی از فرمت‌های مختلف مانند Maven، Docker، Cargo، Helm، PyPI، CocoaPods و GitLFS. شامل ابزار اسکن بسته XRay و ابزار CI/CD به نام Pipelines (قبلاً Shippable) با پلن رایگان ۲٬۰۰۰ دقیقه CI/CD در ماه.
  * [central.sonatype.org](https://central.sonatype.org) — مخزن پیش‌فرض آرتیفکت برای Apache Maven، SBT و سایر سیستم‌های ساخت.
  * [cloudrepo.io](https://cloudrepo.io) - مخزن خصوصی و عمومی مبتنی بر ابر برای Maven و PyPi. رایگان برای پروژه‌های متن‌باز.
  * [cloudsmith.io](https://cloudsmith.io) — سرویس مخزن مرکزی، ساده و ایمن برای Java/Maven، RedHat، Debian، Python، Ruby، Vagrant و غیره. پلن رایگان + رایگان برای متن‌باز.
  * [jitpack.io](https://jitpack.io/) — مخزن Maven برای پروژه‌های JVM و اندروید در GitHub، رایگان برای پروژه‌های عمومی.
  * [packagecloud.io](https://packagecloud.io/users/new?plan=free_usage_plan) — میزبانی آسان مخزن برای بسته‌های Maven، RPM، DEB، PyPi، NPM و RubyGem (دارای پلن رایگان).
  * [repsy.io](https://repsy.io) — ۱ گیگابایت مخزن Maven خصوصی/عمومی رایگان.
  * [Gemfury](https://gemfury.com) — مخزن خصوصی و عمومی آرتیفکت برای Maven، PyPi، NPM، Go Module، Nuget، APT و RPM. رایگان برای پروژه‌های عمومی.
  * [paperspace](https://www.paperspace.com/) — ساخت و مقیاس مدل‌های هوش مصنوعی، توسعه، آموزش و استقرار برنامه‌های AI، پلن رایگان: پروژه‌های عمومی، ۵ گیگابایت فضای ذخیره‌سازی، نمونه‌های پایه.
  * [RepoForge](https://repoforge.io) - مخزن خصوصی ابری برای بسته‌های Python، Debian، NPM و رجیستری Docker. پلن رایگان برای پروژه‌های متن‌باز/عمومی.
  * [RepoFlow](https://repoflow.io) - RepoFlow مدیریت بسته را با پشتیبانی از npm، PyPI، Docker، Go، Helm و غیره ساده می‌کند. رایگان با ۱۰ گیگابایت فضای ذخیره‌سازی، ۱۰ گیگابایت پهنای باند، ۱۰۰ بسته و کاربران نامحدود در ابر، یا نسخه قابل میزبانی فقط برای استفاده شخصی.

**[⬆️ بازگشت به بالا](#table-of-contents)**

## ابزارهای تیمی و همکاری
  * [3Cols](https://3cols.com/) - مدیر رایگان کد اسنیپت ابری برای استفاده شخصی و همکاری کد.
  * [Bitwarden](https://bitwarden.com) — آسان‌ترین و امن‌ترین راه برای ذخیره، اشتراک و همگام‌سازی داده‌های حساس برای افراد، تیم‌ها و سازمان‌های تجاری.
  * [Braid](https://www.braidchat.com/) — اپلیکیشن چت برای تیم‌ها. رایگان برای گروه‌های دسترسی عمومی، کاربران نامحدود، تاریخچه و یکپارچگی‌ها. نسخه متن‌باز و قابل میزبانی نیز دارد.
  * [cally.com](https://cally.com/) — یافتن بهترین زمان و تاریخ برای جلسه. استفاده ساده، مناسب برای گروه‌های کوچک و بزرگ.
  * [Calendly](https://calendly.com) — ابزار اتصال و برنامه‌ریزی جلسات. پلن رایگان یک تقویم متصل به ازای هر کاربر و جلسات نامحدود ارائه می‌دهد. اپلیکیشن‌های دسکتاپ و موبایل نیز دارد.
  * [Discord](https://discord.com/) — چت با اتاق‌های عمومی/خصوصی. متن مارک‌داون، صدا، ویدیو و اشتراک‌گذاری صفحه. رایگان برای کاربران نامحدود.
  * [Fibo](https://fibo.dev) - ابزار رایگان آنلاین Scrum Poker همزمان برای تیم‌های اجایل که به کاربران نامحدود اجازه تخمین امتیاز استوری برای برنامه‌ریزی سریع‌تر را می‌دهد.
  * [Telegram](https://telegram.org/) — پیام‌رسان سریع و قابل اعتماد برای همه، مناسب برای کاربران تجاری و تیم‌های کوچک، گروه‌های بزرگ، نام کاربری، اپ دسکتاپ و اشتراک‌گذاری فایل قدرتمند.
  * [DevToolLab](https://devtoollab.com) — ابزارهای آنلاین توسعه‌دهنده با دسترسی رایگان به همه ابزارهای پایه، امکان ذخیره خودکار یک ورودی در هر ابزار، سرعت پردازش استاندارد و پشتیبانی انجمن.
  * [Dubble](https://dubble.so/) — سازنده رایگان راهنمای گام‌به‌گام. گرفتن اسکرین‌شات، مستندسازی فرایندها و همکاری تیمی. پشتیبانی از ضبط صفحه به صورت نامتقارن.
  * [Duckly](https://duckly.com/) — گفت‌وگو و همکاری آنی تیمی. برنامه‌نویسی جفتی با IDE، اشتراک ترمینال، صدا، ویدیو و اشتراک صفحه. رایگان برای تیم‌های کوچک.
  * [Dyte](https://dyte.io) - SDK ویدیو و صوت زنده با بیشترین سازگاری برای توسعه‌دهندگان، با افزونه‌های همکاری برای افزایش بهره‌وری و تعامل. پلن رایگان شامل ۱۰٬۰۰۰ دقیقه استفاده ماهانه از ویدیو/صوت زنده است.
  * [evernote.com](https://evernote.com/) — ابزار سازماندهی اطلاعات. اشتراک‌گذاری یادداشت‌ها و همکاری با دیگران.
  * [Fibery](https://fibery.io/) — پلتفرم workspace متصل. رایگان برای کاربران منفرد تا ۲ گیگابایت فضای دیسک.
  * [flock.com](https://flock.com) — روشی سریع‌تر برای ارتباط تیم شما. پیام‌های نامحدود رایگان، کانال‌ها، کاربران، اپلیکیشن‌ها و ادغام‌ها
  * [Gather](https://www.gather.town/) - راهی بهتر برای ملاقات آنلاین. مبتنی بر فضاهای کاملاً قابل سفارشی‌سازی، Gather گذراندن وقت با جوامع شما را به آسانی زندگی واقعی می‌کند. رایگان تا ۱۰ کاربر همزمان.
  * [gokanban.io](https://gokanban.io) - برد کانبان مبتنی بر سینتکس، بدون نیاز به ثبت‌نام برای استفاده سریع. رایگان بدون هیچ محدودیتی.
  * [flat.social](https://flat.social) - فضاهای تعاملی و قابل سفارشی‌سازی برای جلسات تیمی و دورهمی‌های اجتماعی. جلسات نامحدود، رایگان تا ۸ کاربر همزمان.
  * [GitDailies](https://gitdailies.com) - گزارش‌های روزانه از فعالیت Commit و Pull Request تیم شما در GitHub. شامل ابزار تصویری Push، سیستم شناسایی همکاران و سازنده اعلان سفارشی. پلن رایگان دارای کاربران نامحدود، سه مخزن و سه پیکربندی اعلان.
  * [gitter.im](https://gitter.im/) — چت برای GitHub. اتاق‌های عمومی و خصوصی نامحدود، رایگان برای تیم‌ها تا ۲۵ نفر
  * [Hackmd.io](https://hackmd.io/) - ابزار همکاری و نگارش همزمان برای اسناد/فایل‌های فرمت markdown. مانند Google Docs اما برای فایل‌های markdown. تعداد «یادداشت» نامحدود رایگان، اما تعداد همکاران (دعوت‌شده) برای یادداشت‌ها و قالب‌های خصوصی [محدود خواهد شد](https://hackmd.io/pricing).
  * [hangouts.google.com](https://hangouts.google.com/) — مکانی برای تمام گفتگوهای شما، رایگان، نیاز به حساب Google
  * [HeySpace](https://hey.space) - ابزار مدیریت وظایف با چت، تقویم، تایم‌لاین و تماس‌های ویدیویی. رایگان تا ۵ کاربر.
  * [helplightning.com](https://www.helplightning.com/) — کمک از طریق ویدیو با واقعیت افزوده. رایگان بدون تحلیل‌داده، رمزنگاری و پشتیبانی
  * [ideascale.com](https://ideascale.com/) — اجازه به مشتریان برای ارسال ایده و رأی‌دهی، رایگان برای ۲۵ عضو در ۱ جامعه
  * [Igloo](https://www.igloosoftware.com/) — پورتال داخلی برای به اشتراک‌گذاری اسناد، بلاگ‌ها، تقویم‌ها و غیره. رایگان تا ۱۰ کاربر.
  * [Keybase](https://keybase.io/) — کی‌بیس یک جایگزین متن‌باز برای Slack است؛ تمام چت‌ها و فایل‌های اعضا را ایمن نگه می‌دارد، از خانواده‌ها تا جوامع و شرکت‌ها.
  * [Google Meet](https://meet.google.com/) — استفاده از Google Meet برای نیازهای جلسات ویدیویی آنلاین کسب‌وکار شما. Meet جلسات آنلاین امن و آسان برای پیوستن را فراهم می‌کند.
  * [/meet for Slack](https://meetslack.com) - شروع جلسات Google مستقیماً از Slack با استفاده از /meet در هر کانال، گروه یا DM. رایگان بدون هیچ محدودیتی.
  * [Livecycle](https://www.livecycle.io/) — Livecycle یک پلتفرم همکاری فراگیر است که جریان‌های کاری را برای تیم‌های محصول و پروژه‌های متن‌باز، بی‌اصطکاک می‌کند.
  * [Lockitbot](https://www.lockitbot.com/) — رزرو و قفل منابع مشترک درون Slack مانند اتاق‌ها، محیط‌های توسعه، سرورها و غیره. رایگان تا ۲ منبع
  * [MarkUp](https://www.markup.io/) — MarkUp به شما اجازه می‌دهد بازخورد را مستقیماً روی وب‌سایت‌ها، PDFها و تصاویر خود جمع‌آوری کنید.
  * [Proton Pass](https://proton.me/pass) — مدیریت رمز عبور با آدرس ایمیل مستعار داخلی، احراز هویت دو مرحله‌ای، اشتراک‌گذاری و کلیدهای عبور. در وب، افزونه مرورگر، اپ موبایل و دسکتاپ در دسترس است.
  * [Visual Debug](https://visualdebug.com) - ابزاری بصری برای بازخورد جهت ارتباط بهتر مشتری و توسعه‌دهنده
  * [meet.jit.si](https://meet.jit.si/) — مکالمات ویدیویی یک‌کلیکی و اشتراک‌گذاری صفحه، رایگان
  * [Microsoft Teams](https://products.office.com/microsoft-teams/free) — Microsoft Teams یک هاب دیجیتال مبتنی بر چت است که گفتگوها، محتوا و اپلیکیشن‌ها را در یک تجربه واحد گرد هم می‌آورد. رایگان تا ۵۰۰ هزار کاربر.
  * [Miro](https://miro.com/) - وایت‌برد همکاری مقیاس‌پذیر، امن، چنددستگاهی و مناسب سازمان‌ها برای تیم‌های توزیع‌شده. پلن رایگان دارد.
  * [nootiz](https://www.nootiz.com/) - ابزار برتر برای جمع‌آوری و مدیریت بازخورد بصری روی هر وب‌سایت
  * [Notion](https://www.notion.so/) - نوتیشن یک اپلیکیشن یادداشت‌برداری و همکاری با پشتیبانی از markdown است که وظایف، ویکی‌ها و پایگاه‌های داده را ادغام می‌کند. شرکت این اپ را به عنوان فضای کاری همه‌کاره برای یادداشت‌برداری، مدیریت پروژه و مدیریت وظایف توصیف می‌کند. علاوه بر اپ‌های چندسکویی، از طریق اغلب مرورگرهای وب نیز قابل دسترسی است.
  * [Nuclino](https://www.nuclino.com) - یک ویکی سبک و همکاری‌محور برای دانش، اسناد و یادداشت‌های تیم شما. پلن رایگان با تمام ویژگی‌های ضروری، تا ۵۰ آیتم و ۵ گیگابایت فضای ذخیره‌سازی.
  * [OnlineInterview.io](https://onlineinterview.io/) - پلتفرم مصاحبه کدنویسی رایگان با چت ویدیویی تعبیه‌شده، وایت‌برد و ویرایشگر کد آنلاین که می‌توانید کد خود را در مرورگر کامپایل و اجرا کنید. تنها با یک کلیک می‌توانید اتاق مصاحبه راه دور بسازید.
  * [Quidlo Timesheets](https://www.quidlo.com/timesheets) - اپ تایم‌شیت و ردیابی زمان ساده برای تیم‌ها. پلن رایگان شامل ویژگی‌های ردیابی زمان و تولید گزارش برای تا ۱۰ کاربر است.
  * [PageShare.dev](https://www.pageshare.dev) - افزودن قابلیت بازبینی بصری به Pull Requestهای GitHub بدون نیاز به استقرار وب‌سایت. رایگان تا ۱۰ صفحه در ماه و ۱۰۰ مگابایت فضای ذخیره‌سازی کل.
  * [Pendulums](https://pendulums.io/) - پندولومز ابزار رایگان ردیابی زمان است که به شما کمک می‌کند زمان خود را بهتر مدیریت کنید با رابط کاربری آسان و آمار مفید.
  * [Pumble](https://pumble.com) - اپ چت تیمی رایگان. کاربران و تاریخچه پیام نامحدود، همیشه رایگان.
  * [Raindrop.io](https://raindrop.io) - اپ بوکمارک‌گذاری خصوصی و امن برای macOS، ویندوز، اندروید، iOS و وب. بوکمارک و همکاری نامحدود رایگان.
  * [element.io](https://element.io/) — ابزار ارتباطی غیرمتمرکز و متن‌باز مبتنی بر Matrix. چت گروهی، پیام مستقیم، انتقال فایل رمزنگاری‌شده، تماس صوتی و تصویری و ادغام آسان با دیگر سرویس‌ها.
  * [Rocket.Chat](https://rocket.chat/) - پلتفرم ارتباطی متن‌باز با ویژگی‌های Omnichannel، فدراسیون Matrix، پل با اپ‌های دیگر، پیام‌رسانی نامحدود و تاریخچه کامل پیام‌ها.
  * [seafile.com](https://www.seafile.com/) — ذخیره‌سازی خصوصی یا ابری، اشتراک‌گذاری فایل، همگام‌سازی، بحث‌ها. نسخه ابری فقط ۱ گیگابایت دارد
  * [Sema](https://www.semasoftware.com/) - ابزار رایگان نمونه‌کار توسعه‌دهنده که می‌تواند مشارکت‌ها را در چندین مخزن در یک گزارش واحد تجمیع و اسنپ‌شات کند.
  * [Screen Sharing via Browser](https://screensharing.net) - ابزار رایگان اشتراک‌گذاری صفحه، صفحه خود را مستقیماً از مرورگر با همکاران به اشتراک بگذارید، بدون نیاز به دانلود یا ثبت‌نام. رایگان.
  * [Slab](https://slab.com/) — سرویس مدیریت دانش مدرن برای تیم‌ها. رایگان تا ۱۰ کاربر.
  * [slack.com](https://slack.com/) — رایگان برای کاربران نامحدود با برخی محدودیت‌های ویژگی‌ها
  * [Spectrum](https://spectrum.chat/) - ایجاد جوامع عمومی یا خصوصی به صورت رایگان.
  * [StatusPile](https://www.statuspile.com/) - صفحه وضعیت از صفحات وضعیت. آیا می‌توانید صفحات وضعیت ارائه‌دهندگان بالادستی خود را پیگیری کنید؟
  * [Stickies](https://stickies.app/) - اپ همکاری بصری برای طوفان ذهنی، گردآوری محتوا و یادداشت‌ها. رایگان تا ۳ دیوار، کاربران نامحدود و ۱ گیگابایت فضای ذخیره‌سازی.
  * [Stacks](https://betterstacks.com/) - فضای کاری محتوا با یادداشت‌های یکپارچه، لینک‌ها و ذخیره‌سازی فایل برای مدیریت اطلاعات زیاد. پلن شخصی رایگان برای همیشه.
  * [talky.io](https://talky.io/) — چت ویدیویی گروهی رایگان. ناشناس. همتا به همتا. بدون نیاز به افزونه، ثبت‌نام یا پرداخت
  * [Teamhood](https://teamhood.com/) - نرم‌افزار رایگان مدیریت پروژه، وظیفه و پیگیری اشکال. پشتیبانی از کانبان با Swimlane و پیاده‌سازی کامل اسکرام. دارای ردیابی زمان یکپارچه. رایگان برای پنج کاربر و سه پورتفولیوی پروژه.
  * [Teamplify](https://teamplify.com) - بهبود فرآیند توسعه تیم با تحلیل تیم و استنداپ هوشمند روزانه. شامل مدیریت کامل مرخصی برای تیم‌های ریموت. رایگان برای گروه‌های کوچک تا ۵ کاربر.
  * [Tefter](https://tefter.io) - اپ بوکمارک‌گذاری با ادغام قدرتمند Slack. رایگان برای تیم‌های متن‌باز.
  * [TeleType](https://teletype.oorja.io/) — به اشتراک‌گذاری ترمینال، صدا، کد، وایت‌برد و بیشتر. بدون نیاز به ورود برای همکاری رمزنگاری‌شده بین توسعه‌دهندگان.
  * [TimeCamp](https://www.timecamp.com/) - نرم‌افزار رایگان ردیابی زمان برای کاربران نامحدود. به راحتی با ابزارهای مدیریت پروژه مانند Jira، Trello، Asana و غیره ادغام می‌شود.
  * [Huly](https://huly.io/) - پلتفرم مدیریت پروژه همه‌کاره (جایگزین Linear، Jira، Slack، Notion، Motion) - کاربران نامحدود، ۱۰ گیگابایت فضای ذخیره‌سازی به ازای هر workspace، ۱۰ گیگابایت ترافیک ویدیو(صوتی).
  * [Teamcamp](https://www.teamcamp.app) - اپلیکیشن مدیریت پروژه همه‌کاره برای شرکت‌های توسعه نرم‌افزار.
  * [twist.com](https://twist.com) — اپ ارتباط تیمی مناسب برای ارتباطات غیرهمزمان که گفتگوها را منظم و موضوعی نگه می‌دارد. پلن رایگان و نامحدود موجود است. تخفیف برای تیم‌های واجد شرایط ارائه می‌شود.
  * [tldraw.com](https://tldraw.com) — ابزار رایگان و متن‌باز وایت‌برد و دیاگرام با پیکان‌های هوشمند، چسبندگی، یادداشت‌های چسبان و ویژگی‌های خروجی SVG. حالت چندنفره برای ویرایش همکاری‌محور. افزونه رسمی رایگان برای VS Code نیز موجود است.
  * [BookmarkOS.com](https://bookmarkos.com) - مدیریت رایگان همه‌کاره بوکمارک، مدیریت تب و مدیریت وظیفه در دسکتاپ آنلاین قابل سفارشی با همکاری در پوشه‌ها.
  * [typetalk.com](https://www.typetalk.com/) — به اشتراک‌گذاری و بحث ایده‌ها با تیم خود از طریق پیام‌رسانی فوری در وب یا موبایل
  * [Tugboat](https://tugboat.qa) - پیش‌نمایش هر Pull Request به صورت خودکار و در صورت نیاز. رایگان برای همه، پلن Nano رایگان برای غیرانتفاعی‌ها.
  * [whereby.com](https://whereby.com/) — مکالمات ویدیویی یک‌کلیکی، رایگان (قبلاً به نام appear.in)
  * [windmill.dev](https://windmill.dev/) - Windmill یک پلتفرم توسعه‌دهنده متن‌باز برای ساخت سریع اتوماسیون‌های چندمرحله‌ای در سطح تولید و اپ‌های داخلی از اسکریپت‌های ساده Python و Typescript است. به عنوان کاربر رایگان، می‌توانید حداکثر عضو سه workspace غیرپرمیوم باشید یا ایجاد کنید.
  * [vadoo.tv](https://vadoo.tv/) — میزبانی و بازاریابی ویدیو به سادگی. آپلود ویدیو با یک کلیک. ضبط، مدیریت، اشتراک‌گذاری و بیشتر. پلن رایگان تا ۱۰ ویدیو، ۱ گیگابایت فضای ذخیره‌سازی و ۱۰ گیگابایت پهنای‌باند در ماه ارائه می‌دهد.
  * [userforge.com](https://userforge.com/) - پرسونای آنلاین متصل، داستان کاربر و نقشه‌برداری زمینه‌ای.  کمک به هم‌ترازی طراحی و توسعه، رایگان تا ۳ پرسونای کاربری و دو همکار.
  * [wistia.com](https://wistia.com/) — میزبانی ویدیو با آنالیتیکس بیننده، تحویل ویدیوی HD و ابزارهای بازاریابی برای درک بازدیدکنندگان، ۲۵ ویدیو و پخش‌کننده با برند Wistia
  * [wormhol.org](https://www.wormhol.org/) — سرویس اشتراک‌گذاری فایل مستقیم. اشتراک‌گذاری نامحدود فایل تا ۵ گیگابایت با هر تعداد کاربر.
  * [Wormhole](https://wormhole.app/) - اشتراک‌گذاری فایل تا ۵ گیگابایت با رمزنگاری سرتاسر تا ۲۴ ساعت. برای فایل‌های بزرگتر از ۵ گیگابایت، از انتقال همتا به همتا جهت ارسال مستقیم استفاده می‌کند.
  * [zoom.us](https://zoom.us/) — کنفرانس ویدیویی و وب ایمن با افزونه‌های مختلف. پلن رایگان محدود به ۴۰ دقیقه است.
  * [Zulip](https://zulip.com/) — چت همزمان با مدل رشته‌ای منحصربه‌فرد شبیه ایمیل. پلن رایگان شامل ۱۰,۰۰۰ پیام تاریخچه جستجو و ۵ گیگابایت فضای ذخیره‌سازی فایل است. همچنین نسخه متن‌باز قابل میزبانی ارائه می‌دهد.
  * [robocorp.com](https://robocorp.com) - پشته متن‌باز برای خودکارسازی عملیات. قابلیت تست امکانات ابری و پیاده‌سازی اتوماسیون ساده به صورت رایگان. کار ربات ۲۴۰ دقیقه/ماه، ۱۰ اجرای Assistant، ۱۰۰ مگابایت فضای ذخیره‌سازی.
  * [Fleep.io](https://fleep.io/) — Fleep جایگزین Slack. دارای پلن رایگان برای تیم‌های کوچک با تاریخچه کامل پیام، مکالمه ۱:۱ نامحدود، ۱ مکالمه گروهی و ۱ گیگابایت فضای فایل.
  * [Chanty.com](https://chanty.com/) — Chanty جایگزین دیگری برای Slack است. پلن رایگان برای همیشه برای تیم‌های کوچک (تا ۱۰ نفر) با مکالمات عمومی و خصوصی نامحدود، تاریخچه قابل جستجو، تماس صوتی ۱:۱ نامحدود، پیام صوتی نامحدود، ۱۰ ادغام و ۲۰ گیگابایت فضای ذخیره‌سازی به ازای هر تیم.
  * [ruttl.com](https://ruttl.com/) — بهترین ابزار بازخورد همه‌کاره برای جمع‌آوری بازخورد دیجیتال و بازبینی وب‌سایت‌ها، PDFها و تصاویر.
  * [Mattermost](https://mattermost.com/) — همکاری ایمن برای تیم‌های فنی. پلن رایگان با کانال‌های نامحدود، playbookها، بردها، کاربران، ۱۰ گیگابایت فضای ذخیره‌سازی و بیشتر.
  * [Webvizio](https://webvizio.com) — ابزار بازخورد وب‌سایت، نرم‌افزار بازبینی وب‌سایت و ابزار گزارش اشکال برای تسهیل همکاری توسعه وب روی وظایف مستقیماً روی وب‌سایت‌ها و اپلیکیشن‌های زنده، تصاویر، PDFها و فایل‌های طراحی.
  * [Pullflow](https://pullflow.com) — Pullflow پلتفرم همکاری بازبینی کد با قابلیت‌های هوش مصنوعی برای GitHub، Slack و VS Code ارائه می‌دهد.
  * [Webex](https://www.webex.com/) — جلسات ویدیویی با پلن رایگان تا ۴۰ دقیقه به ازای هر جلسه و ۱۰۰ شرکت‌کننده.
  * [RingCentral](https://www.ringcentral.com/) — جلسات ویدیویی با پلن رایگان تا ۵۰ دقیقه به ازای هر جلسه و ۱۰۰ شرکت‌کننده.
  * [GitBook](https://www.gitbook.com/) — پلتفرم ثبت و مستندسازی دانش فنی — از مستندات محصول تا پایگاه‌های دانش داخلی و APIها. پلن رایگان برای توسعه‌دهندگان فردی.
  * [transfernow](https://www.transfernow.net/) — ساده‌ترین، سریع‌ترین و ایمن‌ترین رابط برای انتقال و اشتراک‌گذاری فایل‌ها. ارسال عکس، ویدیو و سایر فایل‌های بزرگ بدون نیاز به اشتراک اجباری.
  * [paste.sh](https://paste.sh/) — سایت ساده paste مبتنی بر جاوااسکریپت و رمزنگاری.
  * [Revolt.chat](https://revolt.chat/) — جایگزین متن‌باز برای [Discord](https://discord.com/) که به حریم خصوصی شما احترام می‌گذارد. اغلب ویژگی‌های اختصاصی Discord را رایگان دارد. Revolt یک اپلیکیشن همه‌کاره، ایمن و سریع و کاملاً رایگان است. همه ویژگی‌ها رایگان هستند. همچنین از افزونه‌های رسمی و غیررسمی پشتیبانی می‌کند، برخلاف اغلب اپ‌های چت رایج.
  * [Tencent RTC](https://trtc.io/) — Tencent Real-Time Communication (TRTC) راهکارهایی برای تماس صوتی/تصویری گروهی ارائه می‌دهد. ۱۰,۰۰۰ دقیقه رایگان در ماه برای سال اول.
  * [Pastefy](https://pastefy.app/) - Pastebin زیبا و ساده با رمزنگاری اختیاری سمت کاربر، چند تب، API، ویرایشگر هایلایت شده و بیشتر.
  * [SiteDots](https://sitedots.com/) - اشتراک‌گذاری بازخورد برای پروژه‌های وب‌سایت مستقیماً روی سایت شما، بدون شبیه‌سازی، بوم یا راهکارهای جانبی. پلن رایگان کاملاً کاربردی است.

**[⬆️ بازگشت به بالا](#table-of-contents)**

## CMS

  * [acquia.com](https://www.acquia.com/) — میزبانی برای سایت‌های دروپال. پلن رایگان برای توسعه‌دهندگان. ابزارهای توسعه رایگان (مانند Acquia Dev Desktop) نیز در دسترس هستند.
  * [Contentful](https://www.contentful.com/) — CMS بدون سر (Headless). مدیریت محتوا و APIهای تحویل محتوا در ابر. دارای یک فضای Community رایگان با پنج کاربر، ۲۵ هزار رکورد، ۴۸ نوع محتوا، ۲ زبان.
  * [Cosmic](https://www.cosmicjs.com/) — CMS بدون سر و جعبه ابزار API. پلن شخصی رایگان برای توسعه‌دهندگان.
  * [Crystallize](https://crystallize.com) — PIM بدون سر با پشتیبانی از تجارت الکترونیک. دارای GraphQL API داخلی. نسخه رایگان شامل کاربران نامحدود، ۱۰۰۰ آیتم کاتالوگ، ۵ گیگابایت پهنای باند ماهانه و ۲۵ هزار فراخوانی API ماهانه است.
  * [DatoCMS](https://www.datocms.com/) - ارائه پلن رایگان برای پروژه‌های کوچک. DatoCMS یک CMS مبتنی بر GraphQL است. در پلن پایه، ۱۰۰ هزار فراخوانی در ماه دارید.
  * [Directus](https://directus.io) — CMS بدون سر. پلتفرم کاملاً رایگان و متن‌باز برای مدیریت دارایی‌ها و محتوای پایگاه داده به صورت On-Prem یا ابری. هیچ محدودیت یا paywallی ندارد.
  * [FrontAid](https://frontaid.io/) — CMS بدون سر که محتوای JSON را مستقیماً در مخزن Git شما ذخیره می‌کند. بدون محدودیت.
  * [kontent.ai](https://www.kontent.ai) - پلتفرم Content-as-a-Service که تمام مزایای CMS بدون سر را در کنار توانمندسازی بازاریابان فراهم می‌کند. پلن توسعه‌دهنده دو کاربر با پروژه‌های نامحدود و دو محیط برای هر پروژه، ۵۰۰ آیتم محتوا، دو زبان با Delivery و Management API و پشتیبانی از عناصر سفارشی ارائه می‌دهد. می‌توانید از پلن‌های کامل‌تر برای نیازهای خود استفاده کنید.
  * [Prismic](https://www.prismic.io/) — CMS بدون سر. رابط مدیریت محتوا با API کاملاً میزبانی‌شده و مقیاس‌پذیر. پلن Community نامحدود فراخوانی API، سند، نوع سفارشی، دارایی و زبان را برای یک کاربر ارائه می‌دهد. همه چیز لازم برای پروژه بعدی شما. پلن‌های رایگان بزرگ‌تر برای پروژه‌های Open Content/Open Source موجود است.
  * [Sanity.io](https://www.sanity.io/) - پلتفرم محتوای ساخت‌یافته با محیط ویرایش متن‌باز و ذخیره‌ساز داده بلادرنگ میزبانی‌شده. پروژه‌های نامحدود. ادمین نامحدود، سه کاربر غیرادمین، دو دیتاست، ۵۰۰ هزار فراخوانی CDN API، ۱۰ گیگابایت پهنای باند و ۵ گیگابایت دارایی رایگان به ازای هر پروژه.
  * [sensenet](https://sensenet.com) - CMS بدون سر مبتنی بر API با راهکارهای سازمانی برای کسب‌وکارها در هر اندازه. پلن توسعه‌دهنده سه کاربر، ۵۰۰ آیتم محتوا، سه نقش داخلی، ۲۵+۵ نوع محتوا، REST API کامل، تولید پیش‌نمایش سند و ویرایش آنلاین Office را ارائه می‌دهد.
  * [TinaCMS](https://tina.io/) — جایگزین Forestry.io. CMS بدون سر متن‌باز مبتنی بر Git که از Markdown، MDX و JSON پشتیبانی می‌کند. پلن پایه رایگان با دو کاربر ارائه می‌شود.
  * [GatsbyjsCMS](https://www.gatsbyjs.com/) - Gatsby فریم‌ورک سریع و انعطاف‌پذیری است که ساخت وب‌سایت با هر CMS، API یا پایگاه داده‌ای را دوباره لذت‌بخش می‌کند. وب‌سایت‌های بدون سر بسازید و مستقر کنید که ترافیک بیشتری جذب، تبدیل بهتری و درآمد بیشتری کسب می‌کنند!
  * [Hygraph](https://hygraph.com/) - پلن رایگان برای پروژه‌های کوچک ارائه می‌دهد. API مبتنی بر GraphQL. مهاجرت از راهکارهای قدیمی به CMS بدون سر بومی GraphQL - و ارائه محتوا به صورت API-first برای همه کانال‌ها.
  * [Squidex](https://squidex.io/) - ارائه لایه رایگان برای پروژه‌های کوچک. API / GraphQL محور. متن‌باز و مبتنی بر event sourcing (نسخه‌بندی خودکار هر تغییر).
  * [InstaWP](https://instawp.com/) - راه‌اندازی سایت وردپرس در چند ثانیه. دارای لایه رایگان با ۵ سایت فعال، ۵۰۰ مگابایت فضا و ۴۸ ساعت انقضای سایت.
  * [Storyblok](https://www.storyblok.com) - یک CMS بی‌سر برای توسعه‌دهندگان و بازاریابان که با تمام فریم‌ورک‌های مدرن کار می‌کند. پلن رایگان (Community) شامل Management API، ویرایشگر بصری، ده منبع، انواع فیلد سفارشی، چندزبانه (تعداد نامحدود زبان/محل)، مدیر دارایی (تا ۲۵۰۰ دارایی)، سرویس بهینه‌سازی تصویر، جستجو، Webhook + ۲۵۰ گیگابایت ترافیک ماهانه است.
  * [WPJack](https://wpjack.com) - راه‌اندازی وردپرس روی هر کلودی در کمتر از ۵ دقیقه! پلن رایگان شامل ۱ سرور، ۲ سایت، گواهینامه SSL رایگان و کران‌جاب نامحدود. بدون محدودیت زمانی یا انقضا—وبسایت شما، به سبک شما.

**[⬆️ بازگشت به بالا](#table-of-contents)**

## تولید کد

  * [Appinvento](https://appinvento.io/) — AppInvento یک سازنده اپلیکیشن بدون کدنویسی رایگان است. در کد بک‌اند تولید شده به صورت خودکار، کاربران دسترسی کامل به سورس کد و API و مسیرهای نامحدود دارند و امکان یکپارچه‌سازی گسترده فراهم است. پلن رایگان شامل سه پروژه، پنج جدول و افزونه Google می‌شود.
  * [Cody AI](https://sourcegraph.com/cody) - کودی یک دستیار هوشمند کدنویسی است که با استفاده از هوش مصنوعی و درک عمیق از کدبیس شما به شما کمک می‌کند سریع‌تر کد بنویسید و متوجه شوید. کودی به توسعه‌دهندگان حق انتخاب LLM (از جمله اجرای محلی)، پشتیبانی از انواع IDEها، تمامی زبان‌های برنامه‌نویسی محبوب و پلن رایگان می‌دهد. پلن رایگان ماهانه ۲۰ پیام چت (با Claude 3 Sonnet به عنوان LLM) و ۵۰۰ تکمیل خودکار (با Starcoder 16b) ارائه می‌دهد.
  * [DhiWise](https://www.dhiwise.com/) — تبدیل آسان طراحی‌های Figma به اپلیکیشن‌های داینامیک Flutter و React با تکنولوژی تولید کد نوآورانه DhiWise، بهینه‌سازی روند کار و کمک به تولید سریع‌تر تجربه موبایل و وب استثنایی.
  * [Codeium](https://www.codeium.com/) — Codeium ابزار تکمیل کد مبتنی بر هوش مصنوعی و رایگان است. از بیش از ۲۰ زبان برنامه‌نویسی (Python, JavaScript, Java, TypeScript, PHP, C/C++, Go و غیره) پشتیبانی می‌کند و با تمام IDEهای اصلی مستقل و تحت وب یکپارچه می‌شود.
  * [Fern](https://buildwithfern.com) - تعریف API بنویسید و از آن‌ها برای تولید SDK/کتابخانه کلاینت در زبان‌های محبوب مانند TypeScript، Python، Java، Go و غیره استفاده کنید. پشتیبانی کامل از OpenAPI. پلن رایگان تا حداکثر ۲۰ endpoint برای تولید کد را پشتیبانی می‌کند.
  * [Metalama](https://www.postsharp.net/metalama) - فقط برای C#. Metalama کدهای تکراری را هنگام کامپایل به صورت آنی تولید می‌کند تا سورس کد شما تمیز باقی بماند. برای پروژه‌های متن‌باز رایگان است و پلن رایگان تجاری آن شامل سه aspect است.
  * [Supermaven](https://www.supermaven.com/) — افزونه تکمیل کد سریع مبتنی بر هوش مصنوعی برای VSCode، JetBrains و Neovim. لایه رایگان تکمیل‌های درون‌خطی نامحدود را ارائه می‌دهد.
  * [tabnine.com](https://www.tabnine.com/) — Tabnine به توسعه‌دهندگان کمک می‌کند نرم‌افزار بهتر و سریع‌تر ایجاد کنند با ارائه بینش‌هایی از تمام کدهای جهان. افزونه موجود است.
  * [v0.dev](https://v0.dev/) — v0 با مدل‌های هوش مصنوعی کد را بر اساس دستورات متنی ساده تولید می‌کند. کد React سازگار با shadcn/ui و Tailwind CSS را تولید می‌کند که قابل کپی و استفاده در پروژه‌ها است. هر بار تولید حداقل ۳۰ اعتبار مصرف می‌کند. با ۱۲۰۰ اعتبار شروع می‌کنید و هر ماه ۲۰۰ اعتبار رایگان دریافت می‌کنید.


**[⬆️ بازگشت به بالا](#table-of-contents)**

## کیفیت کد

  * [beanstalkapp.com](https://beanstalkapp.com/) — گردش‌کار کامل برای نوشتن، بازبینی و استقرار کد، حساب رایگان برای یک کاربر و یک مخزن با ۱۰۰ مگابایت فضا
  * [browserling.com](https://www.browserling.com/) — تست تعاملی زنده مرورگرهای مختلف، رایگان فقط ۳ دقیقه جلسه با MS IE 9 روی ویستا با رزولوشن ۱۰۲۴x۷۶۸
  * [codacy.com](https://www.codacy.com/) — بازبینی خودکار کد برای PHP، Python، Ruby، Java، JavaScript، Scala، CSS و CoffeeScript، رایگان برای مخازن عمومی و خصوصی نامحدود
  * [Codeac.io](https://www.codeac.io/infrastructure-as-code.html?ref=free-for-dev) - ابزار بازبینی خودکار Infrastructure as Code برای DevOps، یکپارچه با GitHub، Bitbucket و GitLab (حتی self-hosted). علاوه بر زبان‌های معمول، Ansible، Terraform، CloudFormation، Kubernetes و بیشتر را نیز تحلیل می‌کند. (متن‌باز رایگان)
  * [CodeBeat](https://codebeat.co) — پلتفرم بازبینی خودکار کد در زبان‌های مختلف. برای همیشه رایگان برای مخازن عمومی با یکپارچه‌سازی Slack و ایمیل.
  * [codeclimate.com](https://codeclimate.com/) — بازبینی خودکار کد، رایگان برای اپن سورس و مخازن خصوصی نامحدود متعلق به سازمان (تا ۴ همکار). همچنین رایگان برای دانشجویان و موسسات.
  * [codecov.io](https://codecov.io/) — ابزار پوشش کد (SaaS)، رایگان برای اپن سورس و یک مخزن خصوصی رایگان
  * [CodeFactor](https://www.codefactor.io) — بازبینی خودکار کد برای Git. نسخه رایگان شامل کاربران نامحدود، مخازن عمومی و یک مخزن خصوصی است.
  * [coderabbit.ai](https://coderabbit.ai) — ابزار بازبینی کد مبتنی بر هوش مصنوعی که با GitHub/GitLab یکپارچه می‌شود. پلن رایگان شامل ۲۰۰ فایل/ساعت، ۳ بازبینی در ساعت و ۵۰ مکالمه/ساعت است. برای همیشه رایگان برای پروژه‌های اپن سورس.
  * [codescene.io](https://codescene.io/) - Codescene بدهی فنی را بر اساس نحوه کار توسعه‌دهندگان با کد اولویت‌بندی می‌کند و عوامل سازمانی مانند coupling تیمی و تسلط سیستم را به تصویر می‌کشد. رایگان برای اپن سورس.
  * [CodSpeed](https://codspeed.io) - ردیابی خودکار عملکرد در خطوط CI شما. قبل از انتشار، پسرفت‌های عملکرد را با متریک‌های دقیق و ثابت شناسایی کنید. برای همیشه رایگان برای پروژه‌های اپن سورس.
  * [coveralls.io](https://coveralls.io/) — نمایش گزارش پوشش تست، رایگان برای اپن سورس
  * [dareboost](https://dareboost.com) - ۵ گزارش آنالیز رایگان در ماه برای عملکرد، دسترسی و امنیت وب
  * [deepcode.ai](https://www.deepcode.ai) — DeepCode اشکالات، آسیب‌پذیری‌های امنیتی، مشکلات عملکرد و API را بر اساس هوش مصنوعی شناسایی می‌کند. سرعت بالای آنالیز DeepCode امکان تحلیل آنی کد هنگام ذخیره در IDE را فراهم می‌کند. زبان‌های پشتیبانی شده: Java، C/C++، JavaScript، Python و TypeScript. یکپارچه با GitHub، BitBucket و GitLab. رایگان برای مخازن اپن سورس و خصوصی و تا ۳۰ توسعه‌دهنده.
  * [deepscan.io](https://deepscan.io) — تحلیل استاتیک پیشرفته برای شناسایی خودکار خطاهای زمان اجرا در کد جاوااسکریپت، رایگان برای اپن سورس
  * [DeepSource](https://deepsource.io/) - DeepSource به طور مستمر تغییرات سورس کد را آنالیز می‌کند، مشکلات مربوط به امنیت، عملکرد، آنتی‌پترن‌ها، ریسک باگ، مستندات و سبک را پیدا و رفع می‌کند. یکپارچه با GitHub، GitLab و Bitbucket.
  * [DiffText](https://difftext.com) - به سرعت تفاوت‌های بین دو بلوک کد را بیابید. کاملاً رایگان برای استفاده.
  * [eversql.com](https://www.eversql.com/) — EverSQL - پلتفرم شماره یک برای بهینه‌سازی پایگاه داده. به طور خودکار بینش‌های حیاتی در مورد پایگاه داده و کوئری‌های SQL شما ارائه می‌دهد.
  * [gerrithub.io](https://review.gerrithub.io/) — بازبینی کد Gerrit برای مخازن GitHub رایگان است
  * [gocover.io](https://gocover.io/) — پوشش کد برای هر بسته [Go](https://golang.org/)
  * [goreportcard.com](https://goreportcard.com/) — کیفیت کد برای پروژه‌های Go، رایگان برای اپن سورس
  * [gtmetrix.com](https://gtmetrix.com/) — گزارش‌ها و توصیه‌های جامع برای بهینه‌سازی وبسایت‌ها
  * [holistic.dev](https://holistic.dev/) - بهترین آنالایزر استاتیک کد برای بهینه‌سازی Postgresql. سرویس شناسایی خودکار مشکلات عملکرد، امنیت و معماری پایگاه داده
  * [houndci.com](https://houndci.com/) — کامنت‌گذاری بر روی کامیت‌های GitHub درباره کیفیت کد، رایگان برای اپن سورس
  * [Moderne.io](https://app.moderne.io) — بازسازی خودکار سورس کد. Moderne مهاجرت فریم‌ورک، تحلیل کد با اصلاح و تبدیل کد در مقیاس را ارائه می‌دهد تا توسعه‌دهندگان وقت خود را صرف ساختن چیزهای جدید کنند نه نگهداری کدهای قدیمی. رایگان برای اپن سورس.
  * [reviewable.io](https://reviewable.io/) — بازبینی کد برای مخازن GitHub، رایگان برای مخازن عمومی یا شخصی.
  * [parsers.dev](https://parsers.dev/) - پارسرهای درخت نحوی انتزاعی و کامپایلرهای نمایش میانی به عنوان سرویس
  * [scan.coverity.com](https://scan.coverity.com/) — تحلیل استاتیک کد برای Java، C/C++، C# و JavaScript، رایگان برای اپن سورس
  * [scrutinizer-ci.com](https://scrutinizer-ci.com/) — پلتفرم بازبینی مستمر، رایگان برای اپن سورس
  * [semanticdiff.com](https://app.semanticdiff.com/) — مقایسه معنایی آگاه از زبان برنامه‌نویسی برای Pull Requestها و کامیت‌های GitHub، رایگان برای مخازن عمومی
  * [shields.io](https://shields.io) — نشان‌های متادیتای کیفیت برای پروژه‌های اپن سورس
  * [sonarcloud.io](https://sonarcloud.io) — تحلیل خودکار سورس کد برای Java، JavaScript، C/C++، C#، VB.NET، PHP، Objective-C، Swift، Python، Groovy و زبان‌های بیشتر، رایگان برای اپن سورس
  * [SourceLevel](https://sourcelevel.io/) — بازبینی خودکار کد و تحلیل تیم. رایگان برای اپن سورس و سازمان‌ها تا ۵ همکار.
  * [webceo.com](https://www.webceo.com/) — ابزارهای SEO به همراه راستی‌آزمایی کد و پشتیبانی از انواع دستگاه‌ها
  * [zoompf.com](https://zoompf.com/) — رفع مشکلات عملکرد وبسایت با آنالیز دقیق

**[⬆️ بازگشت به بالا](#table-of-contents)**

## جستجو و مرور کد

  * [libraries.io](https://libraries.io/) — جستجو و اعلان به‌روزرسانی وابستگی‌ها برای ۳۲ مدیر بسته مختلف، رایگان برای اپن سورس
  * [Namae](https://namae.dev/) - جستجوی در دسترس بودن نام پروژه شما در سایت‌هایی نظیر GitHub، Gitlab، Heroku، Netlify و بسیاری دیگر.
  * [searchcode.com](https://searchcode.com/) — جستجوی متنی جامع کد، رایگان برای اپن سورس
  * [tickgit.com](https://www.tickgit.com/) — شناسایی کامنت‌های `TODO` (و سایر نشانگرها) برای یافتن بخش‌هایی از کد که نیاز به بهبود دارند.
  * [CodeKeep](https://codekeep.io) - Google Keep برای قطعه‌کدها. سازماندهی، کشف و به اشتراک‌گذاری قطعه‌کدها، با ابزار قدرتمند اسکرین‌شات کد و قالب‌های آماده و قابلیت لینک‌دهی.

**[⬆️ بازگشت به بالا](#table-of-contents)**

## CI و CD

  * [AccessLint](https://github.com/marketplace/accesslint) — AccessLint تست دسترس‌پذیری وب را به صورت خودکار وارد فرآیند توسعه شما می‌کند. برای اپن سورس و اهداف آموزشی رایگان است.
  * [appcircle.io](https://appcircle.io) — پلتفرم DevOps موبایل در سطح سازمانی که ساخت، تست و انتشار خودکار اپلیکیشن‌های موبایل را جهت چرخه انتشار سریع‌تر و کارآمدتر فراهم می‌کند. رایگان تا حداکثر ۳۰ دقیقه ساخت در هر بیلد، ۲۰ بیلد ماهانه و ۱ بیلد همزمان.
  * [appveyor.com](https://www.appveyor.com/) — سرویس CD برای ویندوز، رایگان برای اپن سورس
  * [LocalOps](https://localops.co/) - استقرار اپلیکیشن روی AWS/GCP/Azure در کمتر از ۳۰ دقیقه. راه‌اندازی محیط‌های استاندارد اپلیکیشن روی هر کلود که شامل اتوماسیون continuous deployment و observability پیشرفته هستند. پلن رایگان شامل ۱ کاربر و ۱ محیط اپلیکیشن است.
  * [Argonaut](https://argonaut.dev/) - استقرار اپلیکیشن و زیرساخت روی کلود شما در چند دقیقه. پشتیبانی از استقرار سفارشی و شخص ثالث روی محیط‌های Kubernetes و Lambda. لایه رایگان اجازه استقرار و اپلیکیشن نامحدود برای ۵ دامنه و ۲ کاربر را می‌دهد.
  * [bitrise.io](https://www.bitrise.io/) — CI/CD برای اپلیکیشن‌های موبایل، بومی یا هیبرید. با ۲۰۰ بیلد رایگان در ماه، ۱۰ دقیقه زمان بیلد و دو عضو تیم. پروژه‌های اپن سورس ۴۵ دقیقه زمان بیلد، +۱ همزمانی و اندازه تیم نامحدود دارند.
  * [buddy.works](https://buddy.works/) — CI/CD با پنج پروژه رایگان و یک اجرا به طور همزمان (۱۲۰ اجرا در ماه)
  * [Buildkite](https://buildkite.com) خطوط لوله CI رایگان برای ۳ کاربر و ۵۰۰۰ دقیقه کار در ماه. تحلیل تست پلن رایگان توسعه‌دهندگان شامل ۱۰۰,۰۰۰ اجرای تست در ماه و امکانات بیشتر برای پروژه‌های اپن سورس.
  * [bytebase.com](https://www.bytebase.com/) — CI/CD و DevOps پایگاه داده. رایگان برای کمتر از ۲۰ کاربر و ده نمونه پایگاه داده
  * [CircleCI](https://circleci.com/) — پلن رایگان جامع با تمام امکانات در یک سرویس CI/CD میزبانی شده برای مخازن GitHub، GitLab و BitBucket. کلاس‌های منابع متعدد، Docker، ویندوز، Mac OS، ARM، اجراکننده محلی، تقسیم تست، کشینگ لایه Docker و دیگر امکانات پیشرفته CI/CD. رایگان تا ۶۰۰۰ دقیقه اجرا در ماه، همکاران نامحدود، ۳۰ کار موازی در پروژه‌های خصوصی و تا ۸۰,۰۰۰ دقیقه بیلد رایگان برای پروژه‌های اپن سورس.
  * [cirrus-ci.org](https://cirrus-ci.org) - رایگان برای مخازن عمومی GitHub
  * [cirun.io](https://cirun.io) - رایگان برای مخازن عمومی GitHub
  * [codefresh.io](https://codefresh.io) — پلن رایگان مادام‌العمر: ۱ بیلد، یک محیط، سرورهای مشترک، مخازن عمومی نامحدود
  * [codemagic.io](https://codemagic.io/) - ۵۰۰ دقیقه بیلد رایگان در ماه
  * [codeship.com](https://codeship.com/) — ۱۰۰ بیلد خصوصی در ماه، پنج پروژه خصوصی، نامحدود برای اپن سورس
  * [deploybot.com](https://www.deploybot.com/) — ۱ مخزن با ده استقرار، رایگان برای اپن سورس
  * [deployhq.com](https://www.deployhq.com/) — ۱ پروژه با ده استقرار روزانه (۳۰ دقیقه بیلد در ماه)
  * [drone](https://cloud.drone.io/) - Drone Cloud به توسعه‌دهندگان اجازه می‌دهد خطوط پیوسته تحویل را در چندین معماری از جمله x86 و Arm (۳۲ بیتی و ۶۴ بیتی) اجرا کنند—همه در یک مکان
  * [LayerCI](https://layerci.com) — CI برای پروژه‌های فول‌استک. یک محیط پیش‌نمایش فول‌استک با ۵ گیگابایت رم و ۳ CPU.
  * [semaphoreci.com](https://semaphoreci.com/) — رایگان برای اپن سورس، ۱۰۰ بیلد خصوصی در ماه
  * [Squash Labs](https://www.squash.io/) — ساخت یک VM برای هر شاخه و در دسترس قرار دادن اپ شما از یک URL یکتا، مخازن عمومی و خصوصی نامحدود، اندازه VM تا ۲ گیگابایت.
  * [styleci.io](https://styleci.io/) — فقط مخازن عمومی GitHub
  * [Mergify](https://mergify.io) — اتوماسیون گردش‌کار و صف ادغام برای GitHub — رایگان برای مخازن عمومی GitHub
  * [Make](https://www.make.com/en) — ابزار اتوماسیون گردش‌کار که به شما امکان می‌دهد اپلیکیشن‌ها را متصل و گردش‌کارها را با UI خودکار کنید. از بسیاری از اپ‌ها و APIهای محبوب پشتیبانی می‌کند. رایگان برای مخازن عمومی GitHub و پلن رایگان با ۱۰۰ مگابایت، ۱۰۰۰ عملیات و حداقل فاصله ۱۵ دقیقه.
  * [Spacelift](https://spacelift.io/) - پلتفرم مدیریت Infrastructure as Code. امکانات پلن رایگان: همکاری IaC، رجیستری ماژول Terraform، یکپارچه‌سازی ChatOps، انطباق پیوسته منابع با Open Policy Agent، ورود یکپارچه با SAML 2.0 و دسترسی به poolهای عمومی worker: تا ۲۰۰ دقیقه در ماه
  * [microtica.com](https://microtica.com/) - محیط‌های استارتاپ با اجزای زیرساخت آماده، استقرار اپ روی AWS به صورت رایگان و پشتیبانی از بار کاری تولیدی شما. پلن رایگان شامل ۱ محیط (روی اکانت AWS شما)، ۲ سرویس Kubernetes، ۱۰۰ دقیقه بیلد در ماه و ۲۰ استقرار ماهانه است.
  * [Nx Cloud](https://nx.dev/ci) - Nx Cloud سرعت مخازن مونوریپو شما را در CI با ویژگی‌هایی مانند کشینگ راه دور، توزیع وظایف بین ماشین‌ها و حتی تقسیم خودکار اجرای تست‌های e2e افزایش می‌دهد. پلن رایگان برای حداکثر ۳۰ مشارکت‌کننده با ۱۵۰ هزار اعتبار رایگان در دسترس است.
  * [blacksmith](https://www.blacksmith.sh/) - رانرهای مدیریت‌شده برای GitHub Actions که ماهانه ۳۰۰۰ دقیقه رایگان ارائه می‌دهد و نیاز به کارت اعتباری ندارد.
  * [Terramate](https://terramate.io/) - Terramate یک پلتفرم ارکستراسیون و مدیریت برای ابزارهای Infrastructure as Code (IaC) مانند Terraform، OpenTofu و Terragrunt است. رایگان برای حداکثر ۲ کاربر و شامل تمام امکانات.
  * [Terrateam](https://terrateam.io) - اتوماسیون Terraform با رویکرد GitOps و گردش‌کار مبتنی بر Pull Request، جداسازی پروژه‌ها از طریق رانرهای self-hosted و اجرای لایه‌ای برای عملیات مرتب. رایگان تا ۳ کاربر.

**[⬆️ بازگشت به بالا](#table-of-contents)**

## تست

  * [Applitools.com](https://applitools.com/) — اعتبارسنجی بصری هوشمند برای اپلیکیشن‌های وب، موبایل و دسکتاپ. ادغام با تقریباً تمام راهکارهای اتوماسیون (مانند Selenium و Karma) و رانرهای راه دور (Sauce Labs، Browser Stack). رایگان برای پروژه‌های متن‌باز. پلن رایگان برای یک کاربر با تعداد Checkpoint محدود در هفته.
  * [Appetize](https://appetize.io) — تست اپ‌های اندروید و iOS روی شبیه‌سازهای مبتنی بر ابر برای اندروید و آیفون/آیپد، مستقیماً در مرورگر. پلن رایگان شامل دو جلسه همزمان با ۳۰ دقیقه استفاده ماهانه است. محدودیت اندازه اپ ندارد.
  * [Apptim](https://apptim.com) — ابزار تست موبایل که به افراد بدون دانش مهندسی عملکرد اجازه ارزیابی عملکرد و تجربه کاربری (UX) یک اپ را می‌دهد. نسخه دسکتاپ با استفاده از دستگاه خودتان کاملاً رایگان است و تست نامحدود روی iOS و Android دارد.
  * [Argos](https://argos-ci.com) - تست بصری متن‌باز برای توسعه‌دهندگان. پروژه نامحدود، با ۵۰۰۰ اسکرین‌شات در ماه. رایگان برای پروژه‌های متن‌باز.
  * [Bencher](https://bencher.dev/) - مجموعه ابزار بنچمارکینگ مداوم برای شناسایی افت عملکرد در CI. رایگان برای تمام پروژه‌های عمومی.
  * [browserstack.com](https://www.browserstack.com/) — تست دستی و اتوماتیک مرورگر، [رایگان برای متن‌باز](https://www.browserstack.com/open-source?ref=pricing)
  * [BugBug](https://bugbug.io/) - ابزار سبک اتوماسیون تست برای اپلیکیشن‌های وب. یادگیری آسان و بدون نیاز به کدنویسی. اجرای تست نامحدود روی رایانه شخصی رایگان است. مانیتورینگ ابری و یکپارچه‌سازی CI/CD با هزینه اضافی ماهانه.
  * [Checkly](https://checklyhq.com) - مانیتورینگ سینتتیک با رویکرد کدنویسی برای DevOps مدرن. مانیتورینگ API و اپلیکیشن با قیمت بسیار کمتر از ارائه‌دهندگان قدیمی، مبتنی بر Workflow مانیتورینگ به عنوان کد و Playwright. پلن رایگان سخاوتمندانه برای توسعه‌دهندگان.
  * [checkbot.io](https://www.checkbot.io/) — افزونه مرورگر که وب‌سایت شما را بر اساس ۵۰+ بهترین روش سئو، سرعت و امنیت تست می‌کند. پلن رایگان برای وب‌سایت‌های کوچک.
  * [CORS-Tester](https://cors-error.dev/cors-tester/) - ابزار رایگان برای توسعه‌دهندگان و تست‌کنندگان API جهت بررسی فعال بودن CORS برای یک دامنه و شناسایی مشکلات. ارائه بینش عملیاتی.
  * [cypress.io](https://www.cypress.io/) - تست سریع، آسان و قابل‌اعتماد برای هرآنچه در مرورگر اجرا می‌شود. Cypress Test Runner همیشه رایگان و متن‌باز است بدون هیچ محدودیت. داشبورد Cypress برای پروژه‌های متن‌باز تا ۵ کاربر رایگان است.
  * [Cypress Recorder by Preflight](https://cypress.preflight.com/) - ساخت تست‌های Cypress مبتنی بر هوش مصنوعی و مدل‌های POM در مرورگر. متن‌باز (بجز بخش AI). رایگان برای پنج تست ماهانه با اسکریپت‌های خودترمیم، ایمیل و تست بصری.
  * [everystep-automation.com](https://www.everystep-automation.com/) — ضبط و پخش تمام مراحل انجام‌شده در مرورگر و ساخت اسکریپت، رایگان با امکانات کمتر
  * [Gremlin](https://www.gremlin.com/gremlin-free-software) — ابزارهای Chaos Engineering برای تزریق ایمن خطا به سیستم‌ها و شناسایی نقاط ضعف قبل از ایجاد مشکل برای مشتریان. پلن رایگان دسترسی به حملات Shutdown و CPU روی ۵ میزبان یا کانتینر را فراهم می‌کند.
  * [gridlastic.com](https://www.gridlastic.com/) — تست Selenium Grid با پلن رایگان تا ۴ نود همزمان/۱۰ استارت گرید/۴۰۰۰ دقیقه تست در ماه
  * [katalon.com](https://katalon.com) - پلتفرم تست برای تیم‌هایی با هر اندازه و هر سطح بلوغ تست، شامل Katalon Studio، TestOps (+ تست بصری رایگان)، TestCloud و Katalon Recorder.
  * [Keploy](https://keploy.io/) - مجموعه ابزار تست عملکردی برای توسعه‌دهندگان. ضبط تماس‌های API، تولید تست E2E برای API (KTests) و ساخت Mock یا Stub (KMocks). رایگان برای پروژه‌های متن‌باز.
  * [knapsackpro.com](https://knapsackpro.com) - افزایش سرعت تست‌ها با تقسیم بهینه مجموعه تست روی هر CI. تقسیم تست‌های Ruby و JavaScript روی نودهای CI موازی. پلن رایگان تا ۱۰ دقیقه فایل تست و پلن نامحدود رایگان برای پروژه‌های متن‌باز.
  * [lambdatest.com](https://www.lambdatest.com/) — تست مرورگر دستی، بصری، اسکرین‌شات و اتوماتیک روی selenium و cypress، [رایگان برای متن‌باز](https://www.lambdatest.com/open-source-cross-browser-testing-tool)
  * [loadmill.com](https://www.loadmill.com/) - ساخت خودکار تست‌های API و بارگذاری با تحلیل ترافیک شبکه. شبیه‌سازی تا ۵۰ کاربر همزمان و ۶۰ دقیقه در ماه رایگان.
  * [lost-pixel.com](https://lost-pixel.com) - تست رگرسیون بصری جامع برای Storybook، Ladle، Histoire و اپ‌های وب. اعضای تیم نامحدود، کاملاً رایگان برای متن‌باز، ۷۰۰۰ اسنپ‌شات در ماه.
  * [octomind.dev](https://www.octomind.dev/) - تست UI Playwright به صورت خودکار و نگهداری شده با تولید تست به کمک هوش مصنوعی
  * [percy.io](https://percy.io) - افزودن تست بصری به هر اپ وب، سایت ایستا، راهنمای استایل یا کتابخانه کامپوننت. اعضای تیم نامحدود، اپ دمو، پروژه نامحدود، ۵۰۰۰ اسنپ‌شات در ماه.
  * [preflight.com](https://preflight.com) - تست وب اتوماتیک بدون کد. ضبط تست در مرورگر که در برابر تغییرات UI مقاوم بوده و روی ماشین‌های ویندوز اجرا می‌شود. قابلیت یکپارچه‌سازی با CI/CD را دارد؟ پلن رایگان شامل ۵۰ تست ماهانه با ویدیو، جلسه HTML و امکانات بیشتر است.
  * [qase.io](https://qase.io) - سیستم مدیریت تست برای تیم‌های Dev و QA. مدیریت تست کیس، اجرای تست، ثبت خطا و اندازه‌گیری تاثیر. پلن رایگان شامل همه امکانات اصلی، ۵۰۰ مگابایت برای ضمیمه‌ها و تا ۳ کاربر.
  * [Repeato](https://repeato.app/) ابزار اتوماسیون تست اپ موبایل بدون کد مبتنی بر بینایی کامپیوتری و هوش مصنوعی. پشتیبانی از اپ بومی، flutter، react-native، وب، ionic و بسیاری فریمورک‌های دیگر. پلن رایگان محدود به ۱۰ تست برای iOS و ۱۰ تست برای Android، اما بیشتر امکانات پلن‌های پولی از جمله اجرای نامحدود تست را دارد.
  * [Requestly](https://requestly.com/) افزونه متن‌باز Chrome برای رهگیری، ریدایرکت و Mock درخواست‌های HTTP. دارای [Debugger](https://requestly.com/products/web-debugger/)، [Mock Server](https://requestly.com/products/mock-server/)، [API Client](https://requestly.com/products/api-client/) و [Session Recording](https://requestly.com/products/session-book/). ریدایرکت URL، تغییر هدرهای HTTP، Mock API، تزریق JS سفارشی، تغییر درخواست GraphQL، تولید Endpoint تستی، ضبط جلسه با Network و Console Logs. ساخت تا ۱۰ قانون در پلن رایگان. رایگان برای متن‌باز.
  * [seotest.me](https://seotest.me/) — تست رایگان سئوی داخلی سایت. ۱۰ خزش رایگان سایت در روز. منابع و پیشنهادات آموزشی مفید برای بهبود سئوی هر سایت بدون توجه به تکنولوژی.
  * [snippets.uilicious.com](https://snippets.uilicious.com) - مشابه CodePen اما برای تست متقابل مرورگر. UI-licious امکان نوشتن تست مانند داستان کاربر را می‌دهد و پلتفرم رایگان UI-licious Snippets اجازه می‌دهد تست نامحدود روی Chrome بدون ثبت‌نام تا ۳ دقیقه در هر اجرا داشته باشید. باگ پیدا کردید؟ می‌توانید لینک اختصاصی تست را برای نمایش نحوه بازتولید باگ به توسعه‌دهنده ارسال کنید.
  * [TestCollab](https://testcollab.com) - نرم‌افزار مدیریت تست کاربرپسند با پلن رایگان شامل یکپارچه‌سازی Jira، پروژه نامحدود، وارد کردن تست کیس با CSV/XLSx، ثبت زمان و ۱ گیگابایت فضای فایل.
  * [testingbot.com](https://testingbot.com/) — تست مرورگر و دستگاه Selenium، [رایگان برای متن‌باز](https://testingbot.com/open-source)
  * [Testspace.com](https://testspace.com/) - داشبورد برای انتشار نتایج تست اتوماتیک و فریمورکی برای پیاده‌سازی تست دستی به عنوان کد با GitHub. سرویس [رایگان برای متن‌باز](https://github.com/marketplace/testspace-com) و ۴۵۰ نتیجه ماهانه در اکانت رایگان.
  * [tesults.com](https://www.tesults.com) — گزارش‌دهی نتایج تست و مدیریت تست کیس. ادغام با فریمورک‌های تست محبوب. توسعه‌دهندگان متن‌باز، افراد، معلمان و تیم‌های کوچک می‌توانند فراتر از پروژه‌های رایگان، درخواست تخفیف و پلن رایگان دهند.
  * [UseWebhook.com](https://usewebhook.com) - دریافت و بررسی وب‌هوک‌ها از مرورگر. ارسال به localhost یا پخش مجدد از تاریخچه. رایگان برای استفاده.
  * [Vaadin](https://vaadin.com) — ساخت UIهای مقیاس‌پذیر با جاوا یا تایپ‌اسکریپت، همراه با ابزارها، کامپوننت‌ها و سیستم طراحی یکپارچه برای توسعه سریع‌تر، طراحی بهتر و ساده‌سازی فرآیند توسعه. پروژه نامحدود با پنج سال نگهداری رایگان.
  * [websitepulse.com](https://www.websitepulse.com/tools/) — ابزارهای رایگان مختلف برای شبکه و سرور.
  * [webhook-test.com](https://webhook-test.com) - دیباگ و بررسی وب‌هوک و درخواست‌های HTTP با URL اختصاصی حین ادغام. کاملاً رایگان، امکان ساخت URL نامحدود و دریافت پیشنهاد بهبود.
  * [webhook.site](https://webhook.site) - تایید وب‌هوک، درخواست‌های HTTP خروجی یا ایمیل با URL اختصاصی. URL و ایمیل موقت همیشه رایگان.
  * [webhookbeam.com](https://webhookbeam.com) - راه‌اندازی و مانیتورینگ وب‌هوک با اعلان و ایمیل.

**[⬆️ بازگشت به بالا](#table-of-contents)**

## امنیت و PKI

  * [aikido.dev](https://www.aikido.dev) — پلتفرم امنیتی یکپارچه شامل SCA، SAST، CSPM، DAST، Secrets، IaC، اسکن بدافزار، کانتینر و EOL. پلن رایگان شامل دو کاربر، اسکن ۱۰ ریپو، ۱ کلود، ۲ کانتینر و ۱ دامنه.
  * [alienvault.com](https://www.alienvault.com/open-threat-exchange/reputation-monitor) — کشف سیستم‌های آلوده در شبکه شما
  * [Altcha.org](https://altcha.org/anti-spam) - فیلتر اسپم برای وب‌سایت‌ها و APIها مبتنی بر پردازش زبان طبیعی و یادگیری ماشین. پلن رایگان شامل ۲۰۰ درخواست در روز برای هر دامنه.
  * [atomist.com](https://atomist.com/) — راهی سریع‌تر و راحت‌تر برای اتوماسیون وظایف توسعه. اکنون در حالت بتا.
  * [cloudsploit.com](https://cloudsploit.com/) — ممیزی و پایش امنیت و انطباق Amazon Web Services (AWS)
  * [Public Cloud Threat Intelligence](https://cloudintel.himanshuanand.com/) — Indicator of Compromise (IOC) با اطمینان بالا برای زیرساخت ابری عمومی، بخشی در گیت‌هاب موجود است (https://github.com/unknownhad/AWSAttacks). لیست کامل از طریق API در دسترس است.
  * [CodeNotary.io](https://www.codenotary.io/) — پلتفرم متن‌باز با اثبات غیرقابل تغییر برای تایید کد، فایل، دایرکتوری یا کانتینر
  * [crypteron.com](https://www.crypteron.com/) — پلتفرم امنیتی مبتنی بر ابر و دوستدار توسعه‌دهنده برای جلوگیری از نشت داده در اپلیکیشن‌های .NET و جاوا
  * [CyberChef](https://gchq.github.io/CyberChef/) — اپ وب ساده و شهودی برای تحلیل و رمزگشایی/رمزگذاری داده بدون نیاز به ابزارهای پیچیده یا زبان برنامه‌نویسی. مانند چاقوی سویسی رمزنگاری و رمزگذاری. همه امکانات رایگان و بدون محدودیت. متن‌باز برای نصب شخصی.
  * [DAS](https://signup.styra.com/) — Styra DAS Free، مدیریت چرخه کامل سیاست برای ساخت، استقرار و مدیریت مجوز OPA (Open Policy Agent)
  * [Datree](https://www.datree.io/) — ابزار CLI متن‌باز برای جلوگیری از Misconfiguration در Kubernetes با اطمینان از پیروی Manifest و Helm chartها از بهترین روال‌ها و سیاست‌های سازمان شما
  * [Dependabot](https://dependabot.com/) بروزرسانی خودکار وابستگی‌ها برای Ruby، JavaScript، Python، PHP، Elixir، Rust، Java (Maven و Gradle)، .NET، Go، Elm، Docker، Terraform، Git Submodules و GitHub Actions.
  * [DJ Checkup](https://djcheckup.com) — اسکن سایت Django شما برای یافتن آسیب‌پذیری‌های امنیتی با ابزار رایگان و خودکار. فورک شده از سایت Pony Checkup.
  * [Doppler](https://doppler.com/) — مدیر جامع Secrets برای اپلیکیشن و پیکربندی، با پشتیبانی از همگام‌سازی با ارائه‌دهندگان ابری مختلف. رایگان تا پنج کاربر با کنترل دسترسی پایه.
  * [Dotenv](https://dotenv.org/) — همگام‌سازی فایل‌های .env، سریع و ایمن. دیگر فایل .env خود را از طریق Slack و ایمیل ناامن ارسال نکنید و هیچ‌گاه فایل مهم .env را از دست ندهید. رایگان تا ۳ هم‌تیمی.
  * [GitGuardian](https://www.gitguardian.com) — جلوگیری از ورود Secrets به کد منبع با شناسایی و رفع خودکار Secrets. اسکن ریپوی git برای بیش از ۳۵۰ نوع Secret و فایل حساس – رایگان برای افراد و تیم‌های کمتر از ۲۵ توسعه‌دهنده.
  * [Have I been pwned?](https://haveibeenpwned.com) — API REST برای دریافت اطلاعات رخنه‌های امنیتی.
  * [hostedscan.com](https://hostedscan.com) — اسکنر آسیب‌پذیری آنلاین برای اپلیکیشن‌های وب، سرورها و شبکه‌ها. ۱۰ اسکن رایگان در ماه.
  * [Infisical](https://infisical.com/) — پلتفرم متن‌باز برای مدیریت Secrets توسعه‌دهنده در سراسر تیم و زیرساخت: از توسعه محلی تا سرویس‌های ۳rd-party محیط staging/production. رایگان تا ۵ توسعه‌دهنده.
  * [Internet.nl](https://internet.nl) — تست استانداردهای مدرن اینترنت مانند IPv6، DNSSEC، HTTPS، DMARC، STARTTLS و DANE
  * [keychest.net](https://keychest.net) - مدیریت انقضای SSL و خرید گواهی با پایگاه داده CT یکپارچه
  * [letsencrypt.org](https://letsencrypt.org/) — مرجع صدور گواهی SSL رایگان با گواهی‌های مورد اعتماد همه مرورگرهای اصلی
  * [meterian.io](https://www.meterian.io/) - پایش پروژه‌های Java، Javascript، .NET، Scala، Ruby و NodeJS برای آسیب‌پذیری‌های امنیتی وابستگی‌ها. رایگان برای یک پروژه خصوصی، نامحدود برای متن‌باز.
  * [Mozilla Observatory](https://observatory.mozilla.org/) — یافتن و رفع آسیب‌پذیری‌های امنیتی سایت شما.
  * [opswat.com](https://www.opswat.com/) — پایش امنیتی رایانه‌ها، دستگاه‌ها، اپلیکیشن‌ها و پیکربندی‌ها، رایگان برای ۲۵ کاربر و ۳۰ روز تاریخچه.
  * [openapi.security](https://openapi.security/) - ابزار رایگان برای بررسی سریع امنیت هر API مبتنی بر OpenAPI / Swagger. نیازی به ثبت‌نام نیست.
  * [pixee.ai](https://pixee.ai) - مهندس امنیت محصول خودکار به صورت بات رایگان GitHub که PRهایی برای حل خودکار آسیب‌پذیری‌های کد جاوا ارسال می‌کند. زبان‌های دیگر به‌زودی.
  * [pyup.io](https://pyup.io) — پایش وابستگی‌های Python برای آسیب‌پذیری و بروزرسانی خودکار. رایگان برای یک پروژه خصوصی، نامحدود برای متن‌باز.
  * [qualys.com](https://www.qualys.com/community-edition) — یافتن آسیب‌پذیری اپ وب و ممیزی خطرات OWASP
  * [report-uri.io](https://report-uri.io/) — گزارش تخلف CSP و HPKP
  * [ringcaptcha.com](https://ringcaptcha.com/) — ابزارهایی برای استفاده از شماره تلفن به عنوان شناسه، رایگان در دسترس
  * [seclookup.com](https://www.seclookup.com/) - APIهای Seclookup قابلیت غنی‌سازی Indicators حوزه تهدید در SIEM، اطلاعات جامع دامنه و بهبود کشف و پاسخ به تهدید را فراهم می‌کنند. ۵۰ هزار Lookup رایگان [اینجا](https://account.seclookup.com/).
  * [snyk.io](https://snyk.io) — یافتن و رفع آسیب‌پذیری‌های شناخته‌شده در وابستگی‌های متن‌باز. تست و رفع نامحدود برای پروژه‌های متن‌باز. محدود به ۲۰۰ تست در ماه برای پروژه‌های خصوصی.
  * [ssllabs.com](https://www.ssllabs.com/ssltest/) — تحلیل عمیق پیکربندی هر سرور وب SSL
  * [SOOS](https://soos.io) - اسکن SCA رایگان و نامحدود برای پروژه‌های متن‌باز. شناسایی و رفع تهدیدهای امنیتی قبل از انتشار. حفاظت از پروژه‌ها با راه‌حل ساده و مؤثر.
  * [StackHawk](https://www.stackhawk.com/) اسکن خودکار اپلیکیشن در کل خط لوله برای یافتن و رفع باگ‌های امنیتی قبل از رسیدن به تولید. اسکن و محیط نامحدود برای یک اپ.
  * [Sucuri SiteCheck](https://sitecheck.sucuri.net) - بررسی امنیت سایت و اسکن بدافزار رایگان
  * [Protectumus](https://protectumus.com) - بررسی امنیت سایت، آنتی‌ویروس سایت و فایروال سرور (WAF) رایگان برای PHP. اعلان ایمیل برای کاربران ثبت‌نامی در پلن رایگان.
  * [TestTLS.com](https://testtls.com) - تست سرویس SSL/TLS برای پیکربندی سرور امن، گواهی‌نامه‌ها، زنجیره‌ها و غیره. محدود به HTTPS نیست.
  * [threatconnect.com](https://threatconnect.com) — اطلاعات تهدید: مناسب برای پژوهشگران، تحلیل‌گران و سازمان‌هایی که تازه با اطلاعات تهدید سایبری آشنا می‌شوند. رایگان تا ۳ کاربر.
  * [tinfoilsecurity.com](https://www.tinfoilsecurity.com/) — اسکن خودکار آسیب‌پذیری. پلن رایگان اجازه اسکن هفتگی XSS را می‌دهد
  * [Ubiq Security](https://ubiqsecurity.com/) — رمزنگاری و رمزگشایی داده با سه خط کد و مدیریت کلید خودکار. رایگان برای یک اپلیکیشن و تا ۱٬۰۰۰٬۰۰۰ رمزنگاری در ماه.
  * [Virgil Security](https://virgilsecurity.com/) — ابزار و خدمات برای پیاده‌سازی رمزنگاری انتها به انتها، حفاظت دیتابیس، امنیت IoT و غیره در راهکار دیجیتال شما. رایگان برای اپلیکیشن‌های تا ۲۵۰ کاربر.
  * [Vulert](https://vulert.com) - Vulert وابستگی‌های متن‌باز شما را پیوسته برای آسیب‌پذیری‌های جدید پایش و رفع توصیه‌شده بدون نیاز به نصب یا دسترسی به کد بررسی می‌کند. رایگان برای پروژه‌های متن‌باز.
  * [Escape GraphQL Quickscan](https://escape.tech/) - اسکن امنیتی یک‌کلیکی برای Endpointهای GraphQL شما. رایگان و بدون نیاز به ورود.
  * [HasMySecretLeaked](https://gitguardian.com/hasmysecretleaked) - جستجو بین ۲۰ میلیون Secret افشا شده در ریپوهای عمومی، Gistها، Issueها و کامنت‌های GitHub به صورت رایگان
  * [Project Gatekeeper](https://gatekeeper.binarybiology.top/) - جعبه ابزار SSL جامع با امکاناتی مانند تولید Private Key و CSR، رمزگشای گواهی SSL، تطبیق گواهی و سفارش گواهی SSL. امکان تولید گواهی SSL رایگان از Let's Encrypt، Google Trust و BuyPass با استفاده از CNAME به جای TXT فراهم است.
**[⬆️ بازگشت به بالا](#table-of-contents)**

## احراز هویت، مجوزدهی و مدیریت کاربران

  * [Aserto](https://www.aserto.com) - مجوزدهی دقیق به عنوان سرویس برای برنامه‌ها و APIها. رایگان تا ۱۰۰۰ کاربر فعال ماهانه و ۱۰۰ نمونه Authorizer.
  * [asgardeo.io](https://wso2.com/asgardeo) - یکپارچه‌سازی بی‌دردسر SSO، MFA، احراز هویت بدون رمز عبور و بیشتر. شامل SDK برای برنامه‌های فرانت‌اند و بک‌اند. رایگان تا ۱۰۰۰ کاربر فعال ماهانه و پنج ارائه‌دهنده هویت.
  * [Auth0](https://auth0.com/) — SSO میزبانی‌شده. پلن رایگان شامل ۲۵,۰۰۰ کاربر فعال ماهانه، اتصالات اجتماعی نامحدود، دامنه سفارشی و بیشتر.
  * [Authgear](https://www.authgear.com) - افزودن احراز هویت بدون رمز عبور، OTP، ۲FA، SSO به برنامه‌هایتان در چند دقیقه. همه امکانات فرانت‌اند را شامل می‌شود. رایگان تا ۵۰۰۰ کاربر فعال ماهانه.
  * [Authress](https://authress.io/) — ورود احراز هویت و کنترل دسترسی، ارائه‌دهندگان هویت نامحدود برای هر پروژه. فیسبوک، گوگل، توییتر و غیره. اولین ۱۰۰۰ فراخوانی API رایگان.
  * [Authy](https://authy.com) - احراز هویت دومرحله‌ای (۲FA) روی چندین دستگاه با پشتیبان‌گیری. جایگزین سریع برای Google Authenticator. رایگان تا ۱۰۰ احراز هویت موفق.
  * [Cerbos Hub](https://www.cerbos.dev/product-cerbos-hub) - سیستم کامل مدیریت مجوزدهی برای تدوین، تست و استقرار سیاست‌های دسترسی. مجوزدهی دقیق و کنترل دسترسی، رایگان تا ۱۰۰ کاربر فعال ماهانه.
  * [Clerk](https://clerk.com) — مدیریت کاربر، احراز هویت، ۲FA/MFA، کامپوننت‌های آماده رابط کاربری برای ورود، ثبت‌نام، پروفایل کاربر و بیشتر. رایگان تا ۱۰,۰۰۰ کاربر فعال ماهانه.
  * [Cloud-IAM](https://www.cloud-iam.com/) — Keycloak مدیریت هویت و دسترسی به عنوان سرویس. رایگان تا ۱۰۰ کاربر و یک Realm.
  * [Corbado](https://www.corbado.com/) — افزودن احراز هویت Passkey-first به برنامه‌های جدید یا موجود. رایگان برای کاربران فعال نامحدود.
  * [Descope](https://www.descope.com/) — جریان‌های AuthN بسیار قابل تنظیم، شامل رویکرد بدون کدنویسی و API/SDK، رایگان تا ۷۵۰۰ کاربر فعال ماهانه، ۵۰ tenant (تا ۵ SAML/SSO tenant).
  * [duo.com](https://duo.com/) — احراز هویت دومرحله‌ای (۲FA) برای سایت یا برنامه. رایگان برای ۱۰ کاربر، همه روش‌های احراز هویت، ادغام نامحدود، توکن سخت‌افزاری.
  * [Kinde](https://kinde.com/) - احراز هویت ساده و قدرتمند که در چند دقیقه می‌توانید با محصول خود ادغام کنید. همه چیز برای شروع کار با ۷,۵۰۰ کاربر فعال ماهانه رایگان.
  * [logintc.com](https://www.logintc.com/) — احراز هویت دومرحله‌ای (۲FA) با نوتیفیکیشن پوش، رایگان برای ۱۰ کاربر، VPN، وب‌سایت‌ها و SSH.
  * [MojoAuth](https://mojoauth.com/) - اجرای آسان احراز هویت بدون رمز عبور بر روی وب، موبایل یا هر برنامه در عرض چند دقیقه.
  * [Okta](https://developer.okta.com/signup/) — مدیریت کاربر، احراز هویت و مجوزدهی. رایگان تا ۱۰۰ کاربر فعال ماهانه.
  * [onelogin.com](https://www.onelogin.com/) — هویت به عنوان سرویس (IDaaS)، ارائه‌دهنده Single Sign-On، Cloud SSO IdP، سه برنامه شرکتی و پنج برنامه شخصی، کاربران نامحدود.
  * [Ory](https://ory.sh/) - AuthN/AuthZ/OAuth2.0/Zero Trust پلتفرم مدیریت امنیت. حساب توسعه‌دهنده رایگان برای همیشه با همه ویژگی‌های امنیتی، اعضای نامحدود تیم، ۲۰۰ کاربر فعال روزانه و ۲۵ هزار بررسی مجوز ماهانه.
  * [Permit.io](https://permit.io) - ارائه‌دهنده Authorization-as-a-service با امکان RBAC، ABAC و ReBAC برای میکروسرویس‌های مقیاس‌پذیر با به‌روزرسانی‌های لحظه‌ای و رابط کاربری سیاست بدون کدنویسی. پلن رایگان تا ۱۰۰۰ کاربر فعال ماهانه.
  * [Phase Two](https://phasetwo.io) - Keycloak مدیریت هویت و دسترسی متن‌باز. Realm رایگان تا ۱۰۰۰ کاربر، تا ۱۰ اتصال SSO، مبتنی بر کانتینر بهبود یافته Phase Two که شامل [افزونه سازمان](https://phasetwo.io/product/organizations/) است.
  * [SSOJet](https://ssojet.com/) - افزودن SSO سازمانی بدون نیاز به بازنویسی احراز هویت. پلن رایگان شامل کاربران فعال ماهانه نامحدود، سازمان‌های نامحدود، ۲ اتصال SSO و ۲ اتصال SCIM.
  * [Stytch](https://www.stytch.com/) - پلتفرم جامع با API و SDK برای احراز هویت و پیشگیری از تقلب. پلن رایگان شامل ۱۰,۰۰۰ کاربر فعال ماهانه، سازمان‌های نامحدود، ۵ اتصال SSO یا SCIM و ۱,۰۰۰ توکن M2M.
  * [Stack Auth](https://stack-auth.com) — احراز هویت متن‌باز که توسعه‌دهنده‌پسند است. سریع‌ترین راه‌اندازی در پنج دقیقه. امکان میزبانی رایگان یا نسخه SaaS مدیریت‌شده با ۱۰k کاربر فعال ماهانه رایگان.
  * [SuperTokens](https://supertokens.com/) - احراز هویت کاربر متن‌باز که به طور بومی در برنامه شما ادغام می‌شود - راه‌اندازی سریع و کنترل کامل تجربه کاربر و توسعه‌دهنده. رایگان تا ۵,۰۰۰ کاربر فعال ماهانه.
  * [Warrant](https://warrant.dev/) — سرویس میزبانی‌شده مجوزدهی و کنترل دسترسی سطح سازمانی برای برنامه‌هایتان. پلن رایگان شامل ۱ میلیون درخواست API ماهانه و ۱,۰۰۰ قانون authz.
  * [ZITADEL Cloud](https://zitadel.com) — مدیریت کاربر و دسترسی آماده بهره‌برداری که از سناریوهای چندمستاجری (B2B) پشتیبانی می‌کند. رایگان تا ۲۵,۰۰۰ درخواست احراز هویت با همه ویژگی‌های امنیتی (بدون محدودیت برای OTP، بدون رمز عبور، سیاست‌ها و غیره).
  * [PropelAuth](https://propelauth.com) — فروش به شرکت‌ها با هر اندازه فقط با چند خط کد، رایگان تا ۲۰۰ کاربر و ۱۰k ایمیل تراکنشی (با واترمارک "Powered by PropelAuth").
  * [Logto](https://logto.io/) - توسعه، ایمن‌سازی و مدیریت هویت کاربران محصول شما - برای احراز هویت و مجوزدهی. رایگان تا ۵,۰۰۰ کاربر فعال ماهانه با گزینه متن‌باز self-hosted.
  * [WorkOS](https://workos.com/) - مدیریت کاربر و احراز هویت رایگان تا ۱ میلیون کاربر فعال ماهانه. پشتیبانی از ایمیل + رمز عبور، احراز هویت اجتماعی، Magic Auth، MFA و بیشتر.


**[⬆️ بازگشت به بالا](#table-of-contents)**

## توزیع و بازخورد اپلیکیشن موبایل

  * [TestApp.io](https://testapp.io) - پلتفرم تخصصی برای اطمینان از عملکرد صحیح اپلیکیشن‌های موبایل شما. پلن رایگان: یک اپلیکیشن، آنالیتیکس، نسخه‌ها و نصب‌های نامحدود، جمع‌آوری بازخورد.
  * [Loadly](https://loadly.io) - سرویس توزیع نسخه بتا اپلیکیشن‌های iOS و Android با خدمات کاملاً رایگان، دانلود نامحدود، سرعت بالا و بارگذاری نامحدود.
  * [Diawi](https://www.diawi.com) - استقرار مستقیم اپلیکیشن‌های iOS و Android روی دستگاه‌ها. پلن رایگان: آپلود برنامه، لینک محافظت‌شده با رمزعبور، انقضای ۱ روزه، ۱۰ نصب.
  * [InstallOnAir](https://www.installonair.com) - توزیع اپلیکیشن‌های iOS و Android به صورت OTA. پلن رایگان: آپلود نامحدود، لینک خصوصی، انقضای ۲ روزه برای مهمانان، ۶۰ روز برای کاربران ثبت‌نامی.
  * [GetUpdraft](https://www.getupdraft.com) - توزیع اپلیکیشن موبایل برای تست. پلن رایگان شامل یک پروژه، سه نسخه برنامه، ۵۰۰ مگابایت فضای ذخیره‌سازی و ۱۰۰ نصب ماهانه.
  * [Appho.st](https://appho.st) - پلتفرم میزبانی اپلیکیشن موبایل. پلن رایگان شامل پنج اپلیکیشن، ۵۰ دانلود ماهانه و حداکثر حجم فایل ۱۰۰ مگابایت.

**[⬆️ بازگشت به بالا](#table-of-contents)**

## سیستم مدیریت

  * [bitnami.com](https://bitnami.com/) — استقرار برنامه‌های آماده روی IaaS. مدیریت ۱ نمونه میکرو AWS رایگان
  * [Esper](https://esper.io) — MDM و MAM برای دستگاه‌های اندرویدی با DevOps. صد دستگاه رایگان با یک مجوز کاربری و ۲۵ مگابایت فضای ذخیره‌سازی برنامه.
  * [jamf.com](https://www.jamf.com/) — مدیریت دستگاه برای آیپد، آیفون و مک، سه دستگاه رایگان
  * [Miradore](https://miradore.com) — سرویس مدیریت دستگاه. بروز نگه داشتن ناوگان دستگاه‌ها و ایمن‌سازی نامحدود دستگاه‌ها به صورت رایگان. پلن رایگان امکانات پایه را ارائه می‌دهد.
  * [moss.sh](https://moss.sh) - کمک به توسعه‌دهندگان برای استقرار و مدیریت برنامه‌ها و سرورهای وب. رایگان تا ۲۵ استقرار گیت ماهانه
  * [runcloud.io](https://runcloud.io/) - مدیریت سرور با تمرکز ویژه روی پروژه‌های PHP. رایگان برای یک سرور.
  * [ploi.io](https://ploi.io/) - ابزار مدیریت سرور جهت مدیریت و استقرار آسان سرورها و سایت‌ها. رایگان برای یک سرور.
  * [xcloud.host](https://xcloud.host) — پلتفرم مدیریت و استقرار سرور با رابط کاربری آسان. پلن رایگان برای یک سرور ارائه می‌شود.
  * [serveravatar.com](https://serveravatar.com) — مدیریت و مانیتورینگ سرورهای وب مبتنی بر PHP با پیکربندی خودکار. رایگان برای یک سرور.

**[⬆️ بازگشت به بالا](#table-of-contents)**

## پیام‌رسانی و استریمینگ

  * [Ably](https://www.ably.com/) - سرویس پیام‌رسانی بلادرنگ با امکانات Presence، پایداری و تحویل تضمینی. پلن رایگان شامل ۳ میلیون پیام ماهانه، ۱۰۰ اتصال همزمان و ۱۰۰ کانال.
  * [cloudamqp.com](https://www.cloudamqp.com/) — RabbitMQ به عنوان سرویس. پلن Little Lemur: حداکثر ۱ میلیون پیام ماهانه، ۲۰ اتصال همزمان، ۱۰۰ صف، ۱۰,۰۰۰ پیام در صف، چندین نود در AZهای مختلف.
  * [courier.com](https://www.courier.com/) — API واحد برای Push، In-app، ایمیل، چت، SMS و سایر کانال‌های پیام‌رسانی با مدیریت قالب و امکانات دیگر. پلن رایگان شامل ۱۰,۰۰۰ پیام ماهانه.
  * [engagespot.co](https://engagespot.co/) — زیرساخت اعلان چندکاناله برای توسعه‌دهندگان با inbox درون‌برنامه‌ای آماده و ویرایشگر قالب بدون کدنویسی. پلن رایگان شامل ۱۰,۰۰۰ پیام ماهانه.
  * [HiveMQ](https://www.hivemq.com/mqtt-cloud-broker/) - اتصال دستگاه‌های MQTT به بروکر پیام‌رسان ابری. رایگان برای اتصال تا ۱۰۰ دستگاه (بدون نیاز به کارت بانکی) برای همیشه.
  * [knock.app](https://knock.app) – زیرساخت اعلان برای توسعه‌دهندگان. ارسال به کانال‌های مختلف مانند درون‌برنامه‌ای، ایمیل، SMS، Slack و Push با یک API. پلن رایگان شامل ۱۰,۰۰۰ پیام ماهانه.
  * [NotificationAPI.com](https://www.notificationapi.com/) — افزودن اعلان کاربری به هر نرم‌افزاری در ۵ دقیقه. پلن رایگان شامل ۱۰,۰۰۰ اعلان ماهانه + ۱۰۰ SMS و تماس خودکار.
  * [Novu.co](https://novu.co) — زیرساخت اعلان متن‌باز برای توسعه‌دهندگان. کامپوننت‌ها و API ساده برای مدیریت همه کانال‌های ارتباطی در یکجا: ایمیل، SMS، مستقیم، درون‌برنامه‌ای و Push. پلن رایگان شامل ۳۰,۰۰۰ اعلان ماهانه با ۹۰ روز نگهداری داده.
  * [pusher.com](https://pusher.com/) — سرویس پیام‌رسانی بلادرنگ. رایگان تا ۱۰۰ اتصال همزمان و ۲۰۰,۰۰۰ پیام روزانه
  * [scaledrone.com](https://www.scaledrone.com/) — سرویس پیام‌رسانی بلادرنگ. رایگان تا ۲۰ اتصال همزمان و ۱۰۰,۰۰۰ رویداد روزانه
  * [synadia.com](https://synadia.com/ngs) — [NATS.io](https://nats.io) به عنوان سرویس. سراسری، AWS، GCP و Azure. رایگان برای همیشه با ۴k سایز پیام، ۵۰ اتصال فعال و ۵ گیگابایت داده ماهانه.
  * [pubnub.com](https://www.pubnub.com/) - پیام‌رسانی Swift، Kotlin و React با ۱ میلیون تراکنش ماهانه. هر تراکنش می‌تواند چندین پیام داشته باشد.
  * [eyeson API](https://developers.eyeson.team/) - API ارتباط تصویری مبتنی بر WebRTC (SFU, MCU) برای ساخت پلتفرم ویدیو. امکاناتی مانند تزریق داده بلادرنگ، چیدمان ویدیو، ضبط، رابط کاربری وب میزبانی‌شده یا پکیج‌های UI سفارشی. [پلن رایگان توسعه‌دهندگان](https://apiservice.eyeson.com/api-pricing) با ۱۰۰۰ دقیقه جلسه ماهانه.
  * [webpushr](https://www.webpushr.com/) - Push Notification وب - رایگان تا ۱۰,۰۰۰ مشترک، اعلان نامحدود، پیام‌رسانی در مرورگر
  * [httpSMS](https://httpsms.com) - ارسال و دریافت پیامک با استفاده از گوشی اندرویدی به عنوان SMS Gateway. رایگان تا ۲۰۰ پیام ماهانه.
  * [EMQX Serverless](https://www.emqx.com/en/cloud/serverless-mqtt) - بروکر MQTT سرورلس مقیاس‌پذیر و امن در عرض چند ثانیه. ۱ میلیون دقیقه جلسه ماهانه رایگان برای همیشه (بدون نیاز به کارت بانکی).
  * [Pocket Alert](https://pocketalert.app) - ارسال اعلان Push به دستگاه‌های iOS و Android. یکپارچه‌سازی آسان از طریق API یا Webhook و کنترل کامل روی اعلان‌ها. پلن رایگان: ۵۰ پیام روزانه به یک دستگاه و یک برنامه.
  * [SuprSend](https://www.suprsend.com/) - زیرساخت اعلان با رویکرد API-first که اعلان‌های تراکنشی، کرون و تعامل را روی چند کانال با یک API ارسال می‌کند. پلن رایگان: ۱۰,۰۰۰ اعلان ماهانه با امکاناتی نظیر Digest، Batch، چندکاناله، تنظیمات ترجیحی، tenant، Broadcast و غیره.

**[⬆️ بازگشت به بالا](#table-of-contents)**

## مدیریت لاگ

  * [bugfender.com](https://bugfender.com/) — رایگان تا ۱۰۰ هزار خط لاگ روزانه با نگهداری ۲۴ ساعت
  * [logentries.com](https://logentries.com/) — رایگان تا ۵ گیگابایت در ماه با نگهداری ۷ روزه
  * [loggly.com](https://www.loggly.com/) — رایگان برای یک کاربر، ۲۰۰ مگابایت روزانه با نگهداری ۷ روزه
  * [logz.io](https://logz.io/) — رایگان تا ۱ گیگابایت در روز، نگهداری یک روزه
  * [ManageEngine Log360 Cloud](https://www.manageengine.com/cloud-siem/) — سرویس مدیریت لاگ مبتنی بر Manage Engine. پلن رایگان: ۵۰ گیگابایت ذخیره‌سازی با نگهداری ۱۵ روزه و جستجوی ۷ روزه.
  * [papertrailapp.com](https://papertrailapp.com/) — جستجوی ۴۸ ساعته، آرشیو ۷ روزه، ۵۰ مگابایت در ماه
  * [sematext.com](https://sematext.com/logsene) — رایگان تا ۵۰۰ مگابایت روزانه، نگهداری ۷ روزه
  * [sumologic.com](https://www.sumologic.com/) — رایگان تا ۵۰۰ مگابایت روزانه، نگهداری ۷ روزه
  * [logflare.app](https://logflare.app/) — رایگان تا ۱۲,۹۶۰,۰۰۰ ورودی به ازای هر برنامه در ماه، نگهداری ۳ روزه
  * [logtail.com](https://logtail.com/) — مدیریت لاگ مبتنی بر ClickHouse با پشتیبانی از SQL. رایگان تا ۱ گیگابایت در ماه، نگهداری سه روزه.
  * [logzab.com](https://logzab.com/) — سیستم مدیریت Audit Trail. رایگان تا ۱,۰۰۰ لاگ فعالیت کاربر در ماه، نگهداری ۱ ماهه، برای حداکثر ۵ پروژه.
  * [openobserve.ai](https://openobserve.ai/) - ۲۰۰ گیگابایت داده ingest ماهانه رایگان، نگهداری ۱۵ روزه
**[⬆️ بازگشت به بالا](#table-of-contents)**

## مدیریت ترجمه

  * [crowdin.com](https://crowdin.com/) — پروژه‌های نامحدود، رشته‌های نامحدود و همکاری‌کنندگان نامحدود برای پروژه‌های متن‌باز
  * [gitlocalize.com](https://gitlocalize.com) - رایگان و نامحدود برای مخازن خصوصی و عمومی
  * [Lecto](https://lecto.ai/) - API ترجمه ماشینی با پلن رایگان (۳۰ درخواست رایگان، ۱۰۰۰ کاراکتر ترجمه‌شده در هر درخواست). یکپارچه با افزونه Loco Translate وردپرس.
  * [lingohub.com](https://lingohub.com/) — رایگان تا ۳ کاربر، همیشه رایگان برای پروژه‌های متن‌باز
  * [localazy.com](https://localazy.com) - رایگان برای ۱۰۰۰ رشته زبان مبدا، زبان‌های نامحدود، مشارکت‌کنندگان نامحدود، پیشنهاد ویژه برای استارتاپ‌ها و پروژه‌های متن‌باز
  * [Localeum](https://localeum.com) - رایگان تا ۱۰۰۰ رشته، یک کاربر، زبان‌های نامحدود، پروژه‌های نامحدود
  * [localizely.com](https://localizely.com/) — رایگان برای پروژه‌های متن‌باز
  * [Loco](https://localise.biz/) — رایگان تا ۲۰۰۰ ترجمه، مترجمان نامحدود، ده زبان در هر پروژه، ۱۰۰۰ دارایی قابل ترجمه در هر پروژه
  * [oneskyapp.com](https://www.oneskyapp.com/) — نسخه رایگان محدود برای حداکثر ۵ کاربر، رایگان برای پروژه‌های متن‌باز
  * [POEditor](https://poeditor.com/) — رایگان تا ۱۰۰۰ رشته
  * [SimpleLocalize](https://simplelocalize.io/) - رایگان تا ۱۰۰ کلید ترجمه، رشته‌های نامحدود، زبان‌های نامحدود، پیشنهاد ویژه برای استارتاپ‌ها
  * [Texterify](https://texterify.com/) - رایگان برای یک کاربر
  * [Tolgee](https://tolgee.io) - ارائه SaaS رایگان با ترجمه‌های محدود، نسخه خود میزبانی همیشه رایگان
  * [transifex.com](https://www.transifex.com/) — رایگان برای پروژه‌های متن‌باز
  * [Translation.io](https://translation.io) - رایگان برای پروژه‌های متن‌باز
  * [Translized](https://translized.com) - رایگان تا ۱۰۰۰ رشته، یک کاربر، زبان‌های نامحدود، پروژه‌های نامحدود
  * [webtranslateit.com](https://webtranslateit.com/) — رایگان تا ۵۰۰ رشته
  * [weblate.org](https://weblate.org/) — رایگان برای پروژه‌های آزاد تا ۱۰٬۰۰۰ رشته در پلن رایگان و نسخه خود میزبانی نامحدود در محل.
  * [Free PO editor](https://pofile.net/free-po-editor) — رایگان برای همه
  * [Lingo.dev](https://lingo.dev) – CLI متن‌باز با قابلیت هوشمند مصنوعی برای بومی‌سازی وب و موبایل. امکان استفاده از LLM خودتان یا دریافت ۱۰٬۰۰۰ کلمه رایگان هر ماه با موتور بومی‌سازی مدیریت‌شده Lingo.dev.

**[⬆️ بازگشت به بالا](#table-of-contents)**

## پایش (مانیتورینگ)

  * [UptimeObserver.com](https://uptimeobserver.com) - دریافت ۲۰ مانیتور آپ‌تایم با بازه ۵ دقیقه و صفحه وضعیت قابل سفارشی‌سازی — حتی برای مصارف تجاری. اعلان‌های نامحدود و آنی از طریق ایمیل و تلگرام. بدون نیاز به کارت اعتباری برای شروع.
  * [Pingmeter.com](https://pingmeter.com/) - ۵ مانیتور آپ‌تایم با بازه ۱۰ دقیقه. مانیتورینگ SSH، HTTP، HTTPS و هر پورت TCP دلخواه.
  * [alerty.ai](https://www.alerty.ai) - APM رایگان و مانیتورینگ برای FE، BE، DB و غیره + اجرای رایگان ایجنت.
  * [appdynamics.com](https://www.appdynamics.com/) — رایگان برای ۲۴ ساعت داده، ایجنت مدیریت عملکرد برنامه محدود به یک Java، یک .NET، یک PHP و یک Node.js
  * [appneta.com](https://www.appneta.com/) — رایگان با نگهداری داده ۱ ساعته
  * [appspector.com](https://appspector.com/) - کنترل ماموریت برای اشکال‌زدایی از راه دور iOS/Android/Flutter. رایگان برای حجم ترافیک کم (۶۴MB لاگ).
  * [assertible.com](https://assertible.com) — تست خودکار API و مانیتورینگ. پلن‌های رایگان برای تیم‌ها و افراد.
  * [bleemeo.com](https://bleemeo.com) - رایگان برای ۳ سرور، ۵ مانیتور آپ‌تایم، کاربران نامحدود، داشبوردهای نامحدود، قوانین هشداردهی نامحدود.
  * [Core Web Vitals History](https://punits.dev/core-web-vitals-historical/) - مشاهده تاریخچه Core Web Vitals برای یک URL یا سایت.
  * [checklyhq.com](https://checklyhq.com) - مانیتورینگ E2E / Synthetic متن‌باز و مانیتورینگ عمیق API برای توسعه‌دهندگان. پلن رایگان با یک کاربر و ۱۰,۰۰۰ اجرای چک API و شبکه / ۱,۵۰۰ اجرای چک مرورگر.
  * [cloudsploit.com](https://cloudsploit.com) — مانیتورینگ امنیت و پیکربندی AWS. رایگان: اسکن نامحدود آنی، کاربران نامحدود، حساب‌های ذخیره‌شده نامحدود. اشتراکی: اسکن خودکار، دسترسی API و غیره.
  * [cronitor.io](https://cronitor.io/) - اطلاعات عملکرد و مانیتورینگ آپ‌تایم برای کرون‌جاب‌ها، وب‌سایت‌ها، APIها و غیره. پلن رایگان با پنج مانیتور.
  * [datadoghq.com](https://www.datadoghq.com/) — رایگان تا ۵ نود
  * [deadmanssnitch.com](https://deadmanssnitch.com/) — مانیتورینگ برای کرون‌جاب‌ها. یک اسنیچ (مانیتور) رایگان، بیشتر با دعوت دوستان
  * [downtimemonkey.com](https://downtimemonkey.com/) — ۶۰ مانیتور آپ‌تایم با بازه ۵ دقیقه. اعلان از طریق ایمیل و Slack.
  * [economize.cloud](https://economize.cloud) — مدیریت و بهینه‌سازی هزینه زیرساخت ابری. رایگان تا سقف ۵۰۰۰ دلار هزینه ماهانه در Google Cloud Platform.
  * [elastic.co](https://www.elastic.co/solutions/apm) — اطلاعات عملکرد فوری برای توسعه‌دهندگان JS. رایگان با نگهداری داده ۲۴ ساعته
  * [fivenines.io](https://fivenines.io/) — مانیتورینگ سرور لینوکس با داشبوردهای زنده و هشداردهی — رایگان برای همیشه تا ۵ سرور با بازه ۶۰ ثانیه‌ای. بدون نیاز به کارت اعتباری.
  * [Grafana Cloud](https://grafana.com/products/cloud/) - پلتفرم مشاهده‌پذیری ترکیبی که متریک‌ها و لاگ‌ها را با Grafana یکپارچه می‌کند. رایگان: ۳ کاربر، ده داشبورد، ۱۰۰ هشدار، ذخیره‌سازی متریک در Prometheus و Graphite (۱۰٬۰۰۰ سری، ۱۴ روز نگهداری)، ذخیره‌سازی لاگ در Loki (۵۰GB لاگ، ۱۴ روز نگهداری)
  * [healthchecks.io](https://healthchecks.io) — مانیتورینگ کرون‌جاب‌ها و وظایف پس‌زمینه. رایگان تا ۲۰ چک.
  * [Hydrozen.io](https://hydrozen.io) — مانیتورینگ آپ‌تایم و صفحات وضعیت، پلن رایگان: ۱۰ مانیتور آپ‌تایم، ۵ مانیتور هارت‌بیت، ۱ مانیتور دامنه و ۱ صفحه وضعیت رایگان.
  * [incidenthub.cloud](https://incidenthub.cloud/) — تجمیع‌گر صفحه وضعیت ابر و SaaS - ۲۰ مانیتور و ۲ کانال اعلان (Slack و Discord) برای همیشه رایگان.
  * [inspector.dev](https://www.inspector.dev) - داشبورد مانیتورینگ زنده کامل در کمتر از یک دقیقه با پلن رایگان برای همیشه.
  * [instrumentalapp.com](https://instrumentalapp.com) - مانیتورینگ آسان و زیبا برای برنامه و سرور با حداکثر ۵۰۰ متریک و ۳ ساعت نمایش داده رایگان
  * [keychest.net/speedtest](https://keychest.net/speedtest) - تست سرعت مستقل و تست تاخیر TLS handshake در Digital Ocean
  * [letsmonitor.org](https://letsmonitor.org) - مانیتورینگ SSL، رایگان تا ۵ مانیتور
  * [linkok.com](https://linkok.com) - چک‌کننده آنلاین لینک‌های خراب، رایگان برای سایت‌های کوچک تا ۱۰۰ صفحه، کاملاً رایگان برای پروژه‌های متن‌باز.
  * [loader.io](https://loader.io/) — ابزار تست بار رایگان با محدودیت‌هایی
  * [MonitorMonk](https://monitormonk.com) - مانیتورینگ آپ‌تایم مینیمال با صفحات وضعیت زیبا. پلن رایگان دائمی شامل مانیتورینگ HTTPS، کلیدواژه، SSL و زمان پاسخ برای ۱۰ وب‌سایت یا API و ۲ داشبورد/صفحه وضعیت.
  * [netdata.cloud](https://www.netdata.cloud/) — ابزار متن‌باز برای جمع‌آوری متریک‌های زنده. محصول در حال رشد و همچنین در GitHub موجود است!
  * [newrelic.com](https://www.newrelic.com) — پلتفرم مشاهده‌پذیری New Relic برای کمک به مهندسان در ساخت نرم‌افزار کامل‌تر. از مونولیت تا سرورلس، همه‌چیز را پایش، تحلیل، عیب‌یابی و بهینه کنید. پلن رایگان شامل ۱۰۰GB داده ماهانه رایگان، یک کاربر با دسترسی کامل رایگان و کاربران اصلی نامحدود رایگان.
  * [Middleware.io](https://middleware.io/) - پلتفرم مشاهده‌پذیری Middleware دید کامل به اپ‌ها و استک شما می‌دهد تا بتوانید مسائل را در مقیاس مانیتور و عیب‌یابی کنید. پلن رایگان دائمی برای جامعه توسعه‌دهندگان با مانیتورینگ لاگ تا ۱ میلیون رخداد، مانیتورینگ زیرساخت و APM برای تا ۲ میزبان.
  * [nixstats.com](https://nixstats.com) - رایگان برای یک سرور. اعلان ایمیلی، صفحه وضعیت عمومی، بازه ۶۰ ثانیه‌ای و غیره.
  * [OnlineOrNot.com](https://onlineornot.com/) - مانیتورینگ آپ‌تایم برای سایت‌ها و APIها، مانیتورینگ کرون‌جاب‌ها و وظایف زمان‌بندی‌شده. همچنین صفحات وضعیت ارائه می‌دهد. پنج چک اول با بازه ۳ دقیقه رایگان است. پلن رایگان ارسال اعلان از طریق Slack، Discord و ایمیل.
  * [OntarioNet.ca CN Test](https://cntest.ontarionet.ca) — بررسی مسدود بودن سایت‌ها در چین توسط دیوار آتش بزرگ. تشخیص آلودگی DNS با مقایسه نتایج DNS و اطلاعات ASN سرورهای چین و آمریکا.
  * [opsgenie.com](https://www.opsgenie.com/) — هشداردهی قدرتمند و مدیریت آنکال برای سرویس‌های همیشه فعال. رایگان تا ۵ کاربر.
  * [paessler.com](https://www.paessler.com/) — راهکار قدرتمند مانیتورینگ زیرساخت و شبکه، شامل هشداردهی، تجسم قوی و گزارش‌دهی پایه. رایگان تا ۱۰۰ سنسور.
  * [pagecrawl.io](https://pagecrawl.io/) - مانیتورینگ تغییرات سایت، رایگان تا ۶ مانیتور با چک روزانه.
  * [syagent.com](https://syagent.com/) — سرویس مانیتورینگ سرور رایگان غیرتجاری، هشدار و متریک‌ها.
  * [pagerly.io](https://pagerly.io/) - مدیریت آنکال در Slack (یکپارچه با Pagerduty، OpsGenie). رایگان تا ۱ تیم (هر تیم برابر با یک آنکال)
  * [pagertree.com](https://pagertree.com/) - رابط ساده برای هشداردهی و مدیریت آنکال. رایگان تا ۵ کاربر.
  * [phare.io](https://phare.io/) - مانیتورینگ آپ‌تایم رایگان تا ۱۰۰,۰۰۰ رویداد برای پروژه‌ها و صفحات وضعیت نامحدود.
  * [pingbreak.com](https://pingbreak.com/) — سرویس مدرن مانیتورینگ آپ‌تایم. بررسی نامحدود URL و دریافت اعلان قطعی از طریق Discord، Slack یا ایمیل.
  * [pingpong.one](https://pingpong.one/) — پلتفرم پیشرفته صفحه وضعیت با مانیتورینگ. پلن رایگان شامل یک صفحه وضعیت عمومی قابل سفارشی‌سازی با زیردامنه SSL است. پلن حرفه‌ای برای پروژه‌های متن‌باز و غیرانتفاعی رایگان است.
  * [robusta.dev](https://home.robusta.dev/) — مانیتورینگ قدرتمند Kubernetes مبتنی بر Prometheus. می‌توانید Prometheus خود را بیاورید یا پکیج همه‌در‌یک را نصب کنید. پلن رایگان شامل تا ۲۰ نود Kubernetes. هشدارها از طریق Slack، Microsoft Teams، Discord و غیره. ادغام با PagerDuty، OpsGenie، VictorOps، DataDog و بسیاری ابزار دیگر.
  * [sematext.com](https://sematext.com/) — رایگان برای متریک‌های ۲۴ ساعته، سرورهای نامحدود، ۱۰ متریک سفارشی، ۵۰۰٬۰۰۰ داده متریک سفارشی، داشبورد و کاربر نامحدود و غیره.
  * [sitemonki.com](https://sitemonki.com/) — مانیتورینگ سایت، دامنه، کرون و SSL، ۵ مانیتور در هر دسته رایگان
  * [sitesure.net](https://sitesure.net) - مانیتورینگ سایت و کرون - ۲ مانیتور رایگان
  * [skylight.io](https://www.skylight.io/) — رایگان برای ۱۰۰٬۰۰۰ درخواست اول (فقط Rails)
  * [speedchecker.xyz](https://probeapi.speedchecker.xyz/) — API مانیتورینگ عملکرد، بررسی Ping، DNS و غیره.
  * [stathat.com](https://www.stathat.com/) — شروع با ۱۰ آمار رایگان، بدون انقضا
  * [statuscake.com](https://www.statuscake.com/) — مانیتورینگ سایت، تست نامحدود رایگان با محدودیت‌هایی
  * [statusgator.com](https://statusgator.com/) — مانیتورینگ صفحه وضعیت، ۳ مانیتور رایگان
  * [SweetUptime](https://dicloud.net/sweetuptime-server-uptime-monitoring/) — مانیتورینگ سرور، آپ‌تایم، DNS و دامنه. مانیتور ۱۰ سرور، ۱۰ آپ‌تایم و ۱۰ دامنه رایگان.
  * [thousandeyes.com](https://www.thousandeyes.com/) — مانیتورینگ شبکه و تجربه کاربری. ۳ موقعیت و ۲۰ فید داده سرویس‌های وب بزرگ رایگان
  * [uptimetoolbox.com](https://uptimetoolbox.com/) — مانیتورینگ رایگان برای پنج سایت، بازه ۶۰ ثانیه‌ای، صفحه وضعیت عمومی.
  * [zenduty.com](https://www.zenduty.com/) — مدیریت رخداد سرتاسری، هشداردهی، مدیریت آنکال و ارکستراسیون پاسخ برای عملیات شبکه، مهندسی قابلیت اطمینان سایت و تیم‌های DevOps. رایگان تا ۵ کاربر.
  * [instatus.com](https://instatus.com) - ساخت صفحه وضعیت زیبا در ۱۰ ثانیه. برای همیشه رایگان با سابسکرایبر و تیم نامحدود.
  * [Squadcast.com](https://squadcast.com) - نرم‌افزار مدیریت رخداد سرتاسری برای ترویج بهترین روش‌های SRE. پلن رایگان دائمی تا ۱۰ کاربر.
  * [RoboMiri.com](https://robomiri.com/) - RoboMiri مانیتور آپ‌تایم پایدار با انواع مانیتور: کرون‌جاب، کلیدواژه، سایت، پورت، پینگ. ۲۵ چک آپ‌تایم با بازه ۳ دقیقه رایگان. اعلان از طریق تماس تلفنی، SMS، ایمیل و وب‌هوک.
  * [Better Stack](https://betterstack.com/better-uptime) - مانیتورینگ آپ‌تایم، مدیریت رخداد، زمان‌بندی/هشداردهی آنکال و صفحات وضعیت در یک محصول. پلن رایگان شامل ۱۰ مانیتور با بازه چک ۳ دقیقه و صفحات وضعیت.
  * [Pulsetic](https://pulsetic.com) - ۱۰ مانیتور، ۶ ماه سابقه آپ‌تایم/لاگ، صفحات وضعیت نامحدود و دامنه‌های سفارشی! برای همیشه و اعلان نامحدود ایمیلی رایگان. بدون نیاز به کارت اعتباری.
  * [Wachete](https://www.wachete.com) - مانیتورینگ ۵ صفحه با بازه چک ۲۴ ساعت.
  * [Xitoring.com](https://xitoring.com/) — مانیتورینگ آپ‌تایم: ۲۰ مانیتور رایگان، مانیتورینگ سرور لینوکس و ویندوز: ۵ رایگان، صفحه وضعیت: ۱ رایگان - اپ موبایل، کانال اعلان چندگانه و امکانات بیشتر!
  * [Servervana](https://servervana.com) - مانیتورینگ پیشرفته آپ‌تایم با پشتیبانی از پروژه‌ها و تیم‌های بزرگ. مانیتورینگ HTTP، مبتنی بر مرورگر، DNS، دامنه، صفحات وضعیت و غیره. پلن رایگان شامل ۱۰ مانیتور HTTP، ۱ مانیتور DNS و یک صفحه وضعیت.

**[⬆️ بازگشت به بالا](#table-of-contents)**

## مدیریت خطا و استثناها
  * [CatchJS.com](https://catchjs.com/) - ردیابی خطاهای جاوااسکریپت با اسکرین‌شات و مسیر کلیک. رایگان برای پروژه‌های متن‌باز.
  * [bugsnag.com](https://www.bugsnag.com/) — رایگان تا 2,000 خطا در ماه پس از دوره آزمایشی اولیه
  * [elmah.io](https://elmah.io/) — ثبت خطا و پایش آپتایم برای توسعه‌دهندگان وب. اشتراک کسب‌وکار کوچک رایگان برای پروژه‌های متن‌باز.
  * [Embrace](https://embrace.io/) — پایش اپلیکیشن موبایل. رایگان برای تیم‌های کوچک با حداکثر 1 میلیون نشست کاربر در سال.
  * [exceptionless](https://exceptionless.com) — گزارش‌گیری بلادرنگ خطا، ویژگی، لاگ و غیره. رایگان برای ۳ هزار رویداد در ماه/۱ کاربر. متن‌باز و قابل میزبانی شخصی برای استفاده نامحدود.
  * [GlitchTip](https://glitchtip.com/) — ردیابی خطای ساده و متن‌باز. سازگار با SDKهای متن‌باز Sentry. 1000 رویداد در ماه رایگان یا می‌توانید بدون محدودیت شخصی میزبانی کنید.
  * [honeybadger.io](https://www.honeybadger.io) - پایش استثنا، آپتایم و کرون. رایگان برای تیم‌های کوچک و پروژه‌های متن‌باز (12,000 خطا در ماه).
  * [memfault.com](https://memfault.com) — پلتفرم ابری مشاهده‌پذیری و اشکال‌زدایی دستگاه. 100 دستگاه رایگان برای دستگاه‌های [Nordic](https://app.memfault.com/register-nordic)، [NXP](https://app.memfault.com/register-nxp) و [Laird](https://app.memfault.com/register-laird).
  * [rollbar.com](https://rollbar.com/) — پایش استثنا و خطا، پلن رایگان با ۵,۰۰۰ خطا در ماه، کاربران نامحدود، نگهداری ۳۰ روزه
  * [sentry.io](https://sentry.io/) — Sentry استثناهای اپلیکیشن را بلادرنگ ردیابی می‌کند و پلن رایگان کوچکی دارد. رایگان برای ۵ هزار خطا در ماه/۱ کاربر، استفاده نامحدود در صورت میزبانی شخصی
  * [Axiom](https://axiom.co/) — ذخیره تا 0.5 ترابایت لاگ با نگهداری ۳۰ روزه. شامل یکپارچگی با پلتفرم‌هایی مانند Vercel و کوئری‌گیری پیشرفته داده با اعلان ایمیل/دیسکورد.
  * [Semaphr](https://semaphr.com) — سوییچ قطع یکپارچه رایگان برای اپلیکیشن‌های موبایل شما.
  * [Jam](https://jam.dev) - گزارش باگ مناسب توسعه‌دهنده تنها با یک کلیک. پلن رایگان با نامحدود Jam.
  * [Whitespace](https://whitespace.dev) – گزارش باگ با یک کلیک مستقیماً در مرورگر شما. پلن رایگان با ضبط‌های نامحدود برای استفاده شخصی.

**[⬆️ بازگشت به بالا](#table-of-contents)**

## جستجو

  * [algolia.com](https://www.algolia.com/) — راهکار جستجوی میزبانی‌شده با تحمل اشتباه تایپی، مرتبط‌سازی و کتابخانه‌های UI برای ساخت سریع تجربه جستجو. پلن رایگان "Build" شامل ۱ میلیون سند و ۱۰ هزار جستجو در ماه است. همچنین [جستجوی مستندات توسعه‌دهنده](https://docsearch.algolia.com/) را رایگان ارائه می‌دهد.
  * [bonsai.io](https://bonsai.io/) — ۱ گیگابایت حافظه و ۱ گیگابایت ذخیره‌سازی رایگان
  * [CommandBar](https://www.commandbar.com/) - نوار جستجوی یکپارچه به صورت سرویس، ویجت/پلاگین مبتنی بر وب که به کاربران امکان جستجوی محتوا، ناوبری، ویژگی‌ها و غیره را در محصول شما می‌دهد و به کشف قابلیت‌ها کمک می‌کند. رایگان تا ۱,۰۰۰ کاربر فعال ماهانه، دستورات نامحدود.
  * [Orama Cloud](https://orama.com/pricing) — ۳ ایندکس رایگان، ۱۰۰ هزار سند در هر ایندکس، جستجوی فول‌تکست/وکتور/هیبرید نامحدود، ۶۰ روز آنالیتیکس
  * [searchly.com](http://www.searchly.com/) — ۲ ایندکس و ۲۰ مگابایت ذخیره‌سازی رایگان
  * [easysitesearch.com](https://easysitesearch.com/) — ویجت جستجو و API با ایندکس‌دهی خودکار مبتنی بر وب‌کراولر. جستجوی نامحدود رایگان تا ۵۰ زیرصفحه.

**[⬆️ بازگشت به بالا](#table-of-contents)**

## آموزش و توسعه شغلی

  * [FreeCodeCamp](https://www.freecodecamp.org/) - پلتفرم متن‌باز ارائه‌دهنده دوره‌ها و گواهینامه‌های رایگان در زمینه تحلیل داده، امنیت اطلاعات، توسعه وب و موارد دیگر.
  * [The Odin Project](https://www.theodinproject.com/) - پلتفرم رایگان و متن‌باز با برنامه درسی متمرکز بر جاوااسکریپت و روبی برای توسعه وب.
  * [Free Professional Resume Templates & Editor](https://www.overleaf.com/latex/templates/tagged/cv) - پلتفرم رایگان با قالب‌های رزومه فراوان برای حرفه‌ای‌ها، آماده برای کپی، ویرایش کامل و دانلود، بهینه‌شده برای ATS.
  * [DeepLearning.AI Short Courses](https://www.deeplearning.ai/short-courses/) - دوره‌های کوتاه رایگان از متخصصان پیشرو برای کسب تجربه عملی با آخرین ابزارها و تکنیک‌های هوش مصنوعی مولد در یک ساعت یا کمتر.
  * [LabEx](https://labex.io) - توسعه مهارت‌ها در لینوکس، DevOps، امنیت سایبری، برنامه‌نویسی، علم داده و بیشتر از طریق آزمایشگاه‌های تعاملی و پروژه‌های واقعی.
  * [Roadmap.sh](https://roadmap.sh) - نقشه راه‌های آموزشی رایگان که تمام جنبه‌های توسعه را از بلاکچین تا طراحی UX پوشش می‌دهد.
  * [Cisco Networking Academy, Skills for All](https://skillsforall.com/) - ارائه دوره‌های رایگان مطابق با گواهینامه در موضوعاتی مانند امنیت سایبری، شبکه و پایتون.
  * [MIT OpenCourseWare](https://ocw.mit.edu/) - انتشار آنلاین مطالب بیش از ۲۵۰۰ دوره دانشگاه MIT که دانش را به صورت رایگان با یادگیرندگان و مدرسان سراسر جهان به اشتراک می‌گذارد. کانال یوتیوب در [@mitocw](https://www.youtube.com/@mitocw/featured) موجود است.
  * [W3Schools](https://www.w3schools.com/) - آموزش‌های رایگان درباره فناوری‌های توسعه وب مانند HTML، CSS، JavaScript و موارد دیگر را ارائه می‌دهد.
  * [Khan Academy](https://www.khanacademy.org/computing/computer-programming) - راهنماهای آنلاین رایگان برای یادگیری HTML/CSS، جاوااسکریپت و SQL در سطوح مبتدی و پیشرفته.
  * [Full Stack Open](https://fullstackopen.com/en/) – دوره رایگان در سطح دانشگاه در توسعه وب مدرن با React، Node.js، GraphQL، TypeScript و بیشتر. کاملاً آنلاین و خودآموز.
  * [edX](https://www.edx.org/) - دسترسی به بیش از ۴,۰۰۰ دوره آنلاین رایگان از ۲۵۰ موسسه پیشرو، از جمله هاروارد و MIT، با تخصص در علوم کامپیوتر، مهندسی و علم داده.
  * [Django-tutorial.dev](https://django-tutorial.dev) - راهنماهای آنلاین رایگان برای یادگیری جنگو به عنوان اولین فریمورک و ارائه بک‌لینک dofollow رایگان به مقالات نوشته‌شده توسط کاربران.

**[⬆️ بازگشت به بالا](#table-of-contents)**

## ایمیل

  * [10minutemail](https://10minutemail.com) - ایمیل موقت رایگان برای تست.
  * [AhaSend](https://ahasend.com) - سرویس ایمیل تراکنشی، رایگان برای ۱۰۰۰ ایمیل در ماه، با دامنه نامحدود، اعضای تیم، وب‌هوک و مسیر پیام در پلن رایگان.
  * [AnonAddy](https://anonaddy.com) - فورواردینگ ایمیل ناشناس متن‌باز، ایجاد نامحدود ایمیل مستعار رایگان
  * [Antideo](https://www.antideo.com) — ۱۰ درخواست API در ساعت برای اعتبارسنجی ایمیل، IP و شماره تلفن در پلن رایگان. بدون نیاز به کارت اعتباری.
  * [Brevo](https://www.brevo.com/) — ۹,۰۰۰ ایمیل در ماه، ۳۰۰ ایمیل در روز رایگان
  * [OneSignal](https://onesignal.com/) — ۱۰,۰۰۰ ایمیل در ماه، بدون نیاز به کارت اعتباری.
  * [Bump](https://bump.email/) - ۱۰ آدرس ایمیل Bump رایگان، یک دامنه اختصاصی
  * [Burnermail](https://burnermail.io/) – ۵ آدرس ایمیل موقت رایگان، ۱ صندوق پستی، ۷ روز تاریخچه صندوق پستی
  * [Buttondown](https://buttondown.email/) — سرویس خبرنامه. تا ۱۰۰ مشترک رایگان
  * [CloudMailin](https://www.cloudmailin.com/) - ایمیل ورودی از طریق HTTP POST و خروجی تراکنشی - ۱۰,۰۰۰ ایمیل رایگان در ماه
  * [Contact.do](https://contact.do/) — فرم تماس در یک لینک (مانند bitly برای فرم‌های تماس)
  * [debugmail.io](https://debugmail.io/) — سرور ایمیل تستی آسان برای توسعه‌دهندگان
  * [DNSExit](https://dnsexit.com/) - تا ۲ آدرس ایمیل زیر دامنه شما به صورت رایگان با ۱۰۰ مگابایت فضای ذخیره‌سازی. پشتیبانی از IMAP، POP3، SMTP، SPF/DKIM.
  * [EmailLabs.io](https://emaillabs.io/en) — ارسال تا ۹,۰۰۰ ایمیل رایگان در هر ماه، تا ۳۰۰ ایمیل روزانه.
  * [EmailOctopus](https://emailoctopus.com) - تا ۲,۵۰۰ مشترک و ۱۰,۰۰۰ ایمیل در ماه رایگان
  * [EmailJS](https://www.emailjs.com/) – این یک سرور ایمیل کامل نیست؛ تنها یک کلاینت ایمیل است که می‌توانید برای ارسال ایمیل مستقیماً از کلاینت بدون افشای اطلاعات کاربری خود استفاده کنید. پلن رایگان شامل ۲۰۰ درخواست ماهانه، ۲ قالب ایمیل، درخواست تا ۵۰ کیلوبایت، تاریخچه تماس محدود است.
  * [EtherealMail](https://ethereal.email) - Ethereal یک سرویس SMTP جعلی است که عمدتاً برای کاربران Nodemailer و EmailEngine طراحی شده (اما به این‌ها محدود نیست). کاملاً رایگان و یک سرویس ایمیل ضدتراکنشی است که پیام‌ها هرگز تحویل داده نمی‌شوند.
  * [Temp-Mail.org](https://temp-mail.org/en/) - تولید ایمیل موقت/یکبارمصرف با دامنه‌های متنوع. آدرس ایمیل با هر بار بارگذاری صفحه تازه می‌شود. کاملاً رایگان است و هیچ هزینه‌ای ندارد.
  * [TempMailDetector.com](https://tempmaildetector.com/) - اعتبارسنجی تا ۲۰۰ ایمیل در ماه به صورت رایگان و بررسی موقت بودن ایمیل.
  * [Emailvalidation.io](https://emailvalidation.io) - ۱۰۰ اعتبارسنجی ایمیل رایگان در ماه
  * [FakeMailGenerator.com](https://www.fakemailgenerator.com/) - تولیدکننده ایمیل موقت/یکبارمصرف آلمانی. پشتیبانی از ۱۰ دامنه، امکان ایجاد نامحدود آدرس ایمیل. (شامل تبلیغات) اما به جز این مورد، کاملاً رایگان است.
  * [forwardemail.net](https://forwardemail.net) — فورواردینگ رایگان ایمیل برای دامنه‌های سفارشی. ایجاد و فوروارد نامحدود ایمیل با نام دامنه شما (**توجه**: در صورت استفاده از TLDهای .casa، .cf، .click، .email، .fit، .ga، .gdn، .gq، .lat، .loan، .london، .men، .ml، .pl، .rest، .ru، .tk، .top، .work باید هزینه پرداخت کنید به دلیل اسپم)
  * [Imitate Email](https://imitate.email) - سرور ایمیل سندباکس برای تست عملکرد ایمیل در مراحل build/qa و ci/cd. حساب رایگان روزانه ۱۵ ایمیل برای همیشه دریافت می‌کند.
  * [ImprovMX](https://improvmx.com) – فورواردینگ رایگان ایمیل.
  * [EForw](https://www.eforw.com) – فورواردینگ رایگان ایمیل برای یک دامنه. دریافت و ارسال ایمیل از دامنه شما.
  * [Inboxes App](https://inboxesapp.com) — ایجاد تا ۳ ایمیل موقت در روز، سپس حذف آن‌ها از طریق افزونه کروم. مناسب برای تست جریان ثبت‌نام.
  * [inboxkitten.com](https://inboxkitten.com/) - صندوق ورودی ایمیل موقت/یکبارمصرف رایگان با حذف خودکار ایمیل تا ۳ روز. متن‌باز و قابل میزبانی شخصی.
  * [mail-tester.com](https://www.mail-tester.com) — تست تنظیمات DNS/SPF/DKIM/DMARC ایمیل، ۲۰ تست رایگان در ماه.
  * [dkimvalidator.com](https://dkimvalidator.com/) - تست تنظیمات DNS/SPF/DKIM/DMARC ایمیل، سرویس رایگان توسط roundsphere.com
  * [mailcatcher.me](https://mailcatcher.me/) — دریافت ایمیل و نمایش آن از طریق رابط وب.
  * [mailchannels.com](https://www.mailchannels.com) - API ایمیل با یکپارچه‌سازی REST API و SMTP، رایگان تا ۳,۰۰۰ ایمیل در ماه.
  * [Mailcheck.ai](https://www.mailcheck.ai/) - جلوگیری از ثبت‌نام کاربران با ایمیل موقت، ۱۲۰ درخواست در ساعت (~۸۶,۴۰۰ در ماه)
  * [Mailchimp](https://mailchimp.com/) — ۵۰۰ مشترک و ۱,۰۰۰ ایمیل در ماه رایگان.
  * [Maildroppa](https://maildroppa.com) - تا ۱۰۰ مشترک و ایمیل نامحدود و همچنین اتوماسیون رایگان.
  * [MailerLite.com](https://www.mailerlite.com) — ۱,۰۰۰ مشترک در ماه، ۱۲,۰۰۰ ایمیل در ماه رایگان
  * [MailerSend.com](https://www.mailersend.com) — API ایمیل، SMTP، ۳,۰۰۰ ایمیل در ماه رایگان برای ایمیل‌های تراکنشی
  * [mailinator.com](https://www.mailinator.com/) — سیستم ایمیل عمومی و رایگان که می‌توانید هر صندوق ورودی را انتخاب کنید
  * [Mailjet](https://www.mailjet.com/) — ۶,۰۰۰ ایمیل در ماه رایگان (محدودیت ارسال روزانه ۲۰۰ ایمیل)
  * [Mailnesia](https://mailnesia.com) - ایمیل موقت/یکبارمصرف رایگان با قابلیت بازدید خودکار از لینک ثبت‌نام.
  * [mailsac.com](https://mailsac.com) - API رایگان برای تست ایمیل موقت، میزبانی رایگان ایمیل عمومی، ضبط ارسال، ایمیل به slack/websocket/webhook (محدودیت ۱,۵۰۰ API ماهانه)
  * [Mailtrap.io](https://mailtrap.io/) — سرور SMTP جعلی برای توسعه، پلن رایگان با یک صندوق، ۱۰۰ پیام، بدون عضو تیم، دو ایمیل در ثانیه، بدون قوانین فوروارد.
  * [Mail7.io](https://www.mail7.io/) — آدرس ایمیل موقت رایگان برای توسعه‌دهندگان QA. ایجاد آدرس ایمیل فوری با رابط وب یا API.
  * [Momentary Email](https://www.momentaryemail.com/) — آدرس ایمیل موقت رایگان. دریافت ایمیل‌های ورودی از طریق وب‌سایت یا فید RSS.
  * [Mutant Mail](https://www.mutantmail.com/) – ۱۰ آیدی ایمیل رایگان، ۱ دامنه، ۱ صندوق پستی. صندوق پستی واحد برای همه آیدی‌های ایمیل.
  * [Outlook.com](https://outlook.live.com/owa/) - ایمیل شخصی و تقویم رایگان.
  * [Parsio.io](https://parsio.io) — پارسر ایمیل رایگان (فوروارد ایمیل، استخراج داده، ارسال به سرور شما)
  * [pepipost.com](https://pepipost.com) — ۳۰ هزار ایمیل رایگان در ماه اول، سپس ۱۰۰ ایمیل روزانه رایگان.
  * [Plunk](https://useplunk.com) - ۳ هزار ایمیل در ماه رایگان
  * [Postmark](https://postmarkapp.com/) - ۱۰۰ ایمیل در ماه رایگان، گزارش DMARC هفتگی نامحدود.
  * [Proton Mail](https://proton.me/mail) - سرویس ارائه‌دهنده حساب ایمیل امن رایگان با رمزنگاری سرتاسری داخلی. ۱ گیگابایت فضای رایگان.
  * [Queuemail.dev](https://queuemail.dev) — API ارسال ایمیل قابل اعتماد. پلن رایگان (۱۰,۰۰۰ ایمیل در ماه). ارسال غیرهمزمان. استفاده از چندین سرور SMTP. لیست سیاه، لاگ، ردیابی، وب‌هوک و غیره.
  * [QuickEmailVerification](https://quickemailverification.com) — تأیید ۱۰۰ ایمیل روزانه رایگان در پلن رایگان همراه با سایر APIهای رایگان مانند DEA Detector، DNS Lookup، SPF Detector و غیره.
* [Resend](https://resend.com) - API ارسال ایمیل تراکنشی برای توسعه‌دهندگان. ۳۰۰۰ ایمیل در ماه، ۱۰۰ ایمیل در روز رایگان، یک دامنه سفارشی.
* [Sender](https://www.sender.net) تا ۱۵٬۰۰۰ ایمیل در ماه، تا ۲٬۵۰۰ مشترک
* [Sendpulse](https://sendpulse.com) — ۵۰۰ مشترک در ماه، ۱۵٬۰۰۰ ایمیل در ماه رایگان
* [SimpleLogin](https://simplelogin.io/) – راهکار متن‌باز و قابل میزبانی شخصی برای ایجاد و فوروارد آدرس‌های مستعار ایمیل. ۵ آدرس مستعار رایگان، پهنای باند نامحدود، ارسال/پاسخ نامحدود. رایگان برای اعضای آموزشی (دانشجو، پژوهشگر و غیره).
* [Substack](https://substack.com) — سرویس خبرنامه رایگان نامحدود. زمانی که برای آن هزینه دریافت می‌کنید، باید پرداخت کنید.
* [Sweego](https://www.sweego.io/) - API ایمیل تراکنشی اروپایی برای توسعه‌دهندگان. ۵۰۰ ایمیل در روز رایگان.
* [Takeout](https://takeout.bysourfruit.com) - سرویس ایمیل دائماً به‌روز که ارسال ایمیل را آسان می‌کند. ۵۰۰ ایمیل تراکنشی در ماه رایگان.
* [temp-mail.io](https://temp-mail.io) — سرویس ایمیل موقت یکبارمصرف رایگان با امکان داشتن چند ایمیل همزمان و فوروارد
* [tinyletter.com](https://tinyletter.com/) — ۵٬۰۰۰ مشترک در ماه رایگان
* [Touchlead](https://touchlead.app) - ابزار اتوماسیون بازاریابی چندمنظوره با مدیریت لید، سازنده فرم و اتوماسیون. رایگان برای تعداد محدودی لید و اتوماسیون.
* [trashmail.com](https://www.trashmail.com) - آدرس ایمیل یکبارمصرف رایگان با قابلیت فوروارد و انقضای خودکار آدرس
* [Tuta](https://tuta.com/) - سرویس ارائه حساب ایمیل امن رایگان با رمزنگاری سرتاسری داخلی، بدون تبلیغات و بدون ردیابی. ۱ گیگابایت فضای ذخیره‌سازی رایگان، یک تقویم (Tuta همچنین دارای [پلن پولی](https://tuta.com/pricing) است). همچنین [متن‌باز](https://github.com/tutao/tutanota) است و قابلیت میزبانی شخصی دارد.
* [Verifalia](https://verifalia.com/email-verification-api) — API تأیید ایمیل در لحظه با تأیید صندوق پستی و شناسایی ایمیل‌های یکبارمصرف؛ ۲۵ تأیید رایگان ایمیل در روز.
* [verimail.io](https://verimail.io/) — سرویس تأیید ایمیل عمده و API. ۱۰۰ تأیید رایگان در ماه
* [Zoho](https://www.zoho.com) — در ابتدا ارائه‌دهنده ایمیل بود اما اکنون مجموعه‌ای از خدمات را ارائه می‌دهد که برخی از آن‌ها پلن رایگان دارند. لیست خدمات با پلن رایگان:
   - [Email](https://zoho.com/mail) رایگان برای ۵ کاربر. ۵ گیگابایت برای هر کاربر و محدودیت ضمیمه ۲۵ مگابایت، یک دامنه.
   - [Zoho Assist](https://www.zoho.com/assist) — پلن رایگان دائمی Zoho Assist شامل یک مجوز پشتیبانی از راه دور و دسترسی به ۵ رایانه بدون سرپرست برای مدت نامحدود، هم برای کاربرد حرفه‌ای و هم شخصی است.
   - [Sprints](https://zoho.com/sprints) رایگان برای ۵ کاربر، ۵ پروژه و ۵۰۰ مگابایت فضای ذخیره‌سازی.
   - [Docs](https://zoho.com/docs) — رایگان برای ۵ کاربر با محدودیت بارگذاری ۱ گیگابایت و ۵ گیگابایت فضای ذخیره‌سازی. مجموعه آفیس Zoho (Writer, Sheets & Show) به صورت یکجا ارائه می‌شود.
   - [Projects](https://zoho.com/projects) — رایگان برای ۳ کاربر، ۲ پروژه و محدودیت ضمیمه ۱۰ مگابایت. همین طرح برای [Bugtracker](https://zoho.com/bugtracker) نیز اعمال می‌شود.
   - [Connect](https://zoho.com/connect) — همکاری تیمی رایگان برای ۲۵ کاربر با سه گروه، سه اپلیکیشن سفارشی، ۳ برد، ۳ راهنما و ۱۰ ادغام همراه با کانال‌ها، رویدادها و انجمن‌ها.
   - [Meeting](https://zoho.com/meeting) — جلسات با حداکثر ۳ شرکت‌کننده و ۱۰ شرکت‌کننده وبینار.
   - [Vault](https://zoho.com/vault) — مدیریت رمز عبور در دسترس برای افراد.
   - [Showtime](https://zoho.com/showtime) — نرم‌افزار جلسات دیگر برای آموزش با حداکثر ۵ شرکت‌کننده در یک جلسه از راه دور.
   - [Notebook](https://zoho.com/notebook) — جایگزین رایگان برای Evernote.
   - [Wiki](https://zoho.com/wiki) — رایگان برای سه کاربر با ۵۰ مگابایت فضای ذخیره‌سازی، صفحات نامحدود، پشتیبان‌گیری zip، خوراک RSS و Atom، کنترل دسترسی و CSS قابل تنظیم.
   - [Subscriptions](https://zoho.com/subscriptions) — مدیریت صورتحساب تکرارشونده رایگان برای ۲۰ مشتری/اشتراک و ۱ کاربر با میزبانی پرداخت‌ها توسط Zoho. آخرین ۴۰ معیار اشتراک ذخیره می‌شود.
   - [Checkout](https://zoho.com/checkout) — مدیریت صورتحساب محصولات با ۳ صفحه و حداکثر ۵۰ پرداخت.
   - [Desk](https://zoho.com/desk) — مدیریت پشتیبانی مشتری با سه نماینده، پایگاه دانش خصوصی و تیکت ایمیلی. ادغام با [Assist](https://zoho.com/assist) برای یک تکنسین از راه دور و ۵ رایانه بدون سرپرست.
   - [Cliq](https://zoho.com/cliq) — نرم‌افزار چت تیمی با ۱۰۰ گیگابایت فضای ذخیره‌سازی، کاربران نامحدود، ۱۰۰ کاربر در هر کانال و SSO.
   - [Campaigns](https://zoho.com/campaigns) - بازاریابی ایمیلی
   - [Forms](https://zoho.com/forms) - سازنده فرم
   - [Sign](https://zoho.com/sign) - امضای بدون کاغذ
   - [Surveys](https://zoho.com/surveys) - نظرسنجی آنلاین
   - [Bookings](https://zoho.com/bookings) - زمان‌بندی قرار ملاقات
* [Maileroo](https://maileroo.com) - رله SMTP و API ایمیل برای توسعه‌دهندگان. ۵٬۰۰۰ ایمیل در ماه، دامنه نامحدود، تأیید رایگان ایمیل، پایش لیست سیاه، تستر ایمیل و بیشتر.

**[⬆️ بازگشت به بالا](#table-of-contents)**

## پلتفرم‌های مدیریت Feature Toggles

* [ConfigCat](https://configcat.com) - سرویس فلگ ویژگی مخصوص توسعه‌دهندگان با اندازه تیم نامحدود، پشتیبانی عالی و قیمت مناسب. پلن رایگان تا ۱۰ فلگ، دو محیط، ۱ محصول و ۵ میلیون درخواست در ماه.
* [Flagsmith](https://flagsmith.com) - انتشار ویژگی‌ها با اطمینان؛ مدیریت فلگ ویژگی در سراسر اپلیکیشن‌های وب، موبایل و سمت سرور. استفاده از API میزبانی‌شده یا استقرار در کلاد خصوصی یا نصب در محل.
* [GrowthBook](https://growthbook.io) - ارائه‌دهنده متن‌باز فلگ ویژگی و تست A/B با موتور تحلیل آماری بیزی داخلی. رایگان برای حداکثر ۳ کاربر، فلگ و آزمایش نامحدود.
* [Hypertune](https://www.hypertune.com) - فلگ ویژگی type-safe، تست A/B، تحلیل و پیکربندی برنامه با کنترل نسخه شبیه گیت و ارزیابی پرچم محلی، همزمان و در حافظه. رایگان تا ۵ عضو تیم و فلگ و تست A/B نامحدود.
* [Molasses](https://www.molasses.app) - فلگ ویژگی قدرتمند و تست A/B. رایگان تا ۳ محیط با پنج فلگ ویژگی در هرکدام.
* [Toggled.dev](https://www.toggled.dev) - پلتفرم مدیریت فلگ ویژگی چندمنطقه‌ای، مقیاس‌پذیر و آماده سازمانی. پلن رایگان تا ۱۰ فلگ، دو محیط، درخواست نامحدود. SDK، داشبورد تحلیلی، تقویم انتشار، اعلان Slack و همه قابلیت‌ها در پلن رایگان نامحدود گنجانده شده‌اند.
* [Statsig](https://www.statsig.com) - پلتفرم قدرتمند مدیریت ویژگی، تست A/B، تحلیل و بیشتر. پلن رایگان سخاوتمندانه با صندلی، فلگ، آزمایش و پیکربندی پویا نامحدود تا ۱ میلیون رویداد در ماه.
* [Abby](https://www.tryabby.com) - فلگ ویژگی و تست A/B متن‌باز. پیکربندی به صورت کد و SDK های Typescript کاملاً تایپ‌شده. ادغام قوی با فریمورک‌هایی مانند Next.js و React. پلن رایگان گسترده و گزینه‌های مقیاس ارزان.

**[⬆️ بازگشت به بالا](#table-of-contents)**

## فونت

* [dafont](https://www.dafont.com/) - فونت‌های ارائه‌شده در این وبسایت متعلق به نویسندگانشان است و یا رایگان، اشتراک‌افزار، نسخه دمو یا دامنه عمومی هستند.
* [Everything Fonts](https://everythingfonts.com/) - ارائه ابزارهای مختلف؛ @font-face، مبدل واحدها، Font Hinter و ارسال فونت.
* [Font Squirrel](https://www.fontsquirrel.com/) - فونت‌های رایگان با مجوز استفاده تجاری. این فونت‌ها به صورت دستی انتخاب و در قالبی آسان ارائه شده‌اند.
* [Google Fonts](https://fonts.google.com/) - بسیاری از فونت‌های رایگان به راحتی و سرعت از طریق دانلود یا لینک CDN گوگل روی وبسایت نصب می‌شوند.
* [FontGet](https://www.fontget.com/) - مجموعه‌ای متنوع از فونت‌ها برای دانلود، مرتب‌شده با تگ‌ها.
* [Fontshare](https://www.fontshare.com/) - سرویس فونت رایگان. مجموعه رو به رشد فونت‌های حرفه‌ای، ۱۰۰٪ رایگان برای استفاده شخصی و تجاری.
* [Befonts](https://befonts.com/) - چندین فونت منحصربه‌فرد برای استفاده شخصی یا تجاری ارائه می‌کند.
* [Font of web](https://fontofweb.com/) - شناسایی تمام فونت‌های استفاده‌شده در یک وبسایت و نحوه استفاده از آن‌ها.
* [Bunny](https://fonts.bunny.net) فونت‌های گوگل با رویکرد حفظ حریم خصوصی
* [FontsKey](https://www.fontskey.com/) - فونت‌های رایگان و پولی برای استفاده شخصی ارائه می‌کند و قابلیت وارد کردن متن برای فیلتر سریع.
* [fonts.xz.style](https://fonts.xz.style/) سرویس رایگان و متن‌باز برای ارائه خانواده فونت به وبسایت‌ها با استفاده از CSS.
* [Fontsensei](https://fontsensei.com/) فونت‌های گوگل اپن‌سورس شده توسط کاربران با تگ فونت‌های CJK (چینی، ژاپنی، کره‌ای).

**[⬆️ بازگشت به بالا](#table-of-contents)**

## فرم‌ها

* [Feathery](https://feathery.io) - سازنده فرم قدرتمند و دوستدار توسعه‌دهنده. ساخت فرم ثبت‌نام و ورود، آنبردینگ کاربر، پرداخت، اپلیکیشن‌های مالی پیچیده و غیره. پلن رایگان تا ۲۵۰ ارسال فرم در ماه و پنج فرم فعال را مجاز می‌کند.
* [Form-Data](https://form-data.com) - بک‌اند فرم بدون کدنویسی. فیلتر اسپم، اعلان ایمیل و پاسخ خودکار، webhook، zapier، ریدایرکت، AJAX یا POST و بیشتر. پلن رایگان فرم نامحدود، ۲۰ ارسال در ماه و ۲۰۰۰ ارسال اضافی با نشان Form-Data ارائه می‌دهد.
* [FabForm](https://fabform.io/) - پلتفرم بک‌اند فرم برای توسعه‌دهندگان هوشمند. پلن رایگان ۲۵۰ ارسال فرم در ماه را مجاز می‌داند. رابط کاربری مدرن و دوستانه. ادغام با Google Sheets، Airtable، Slack، ایمیل و دیگران.
* [Form.taxi](https://form.taxi/) — نقطه پایان برای ارسال فرم‌های HTML. با اعلان، بلاکر اسپم و پردازش داده مطابق GDPR. پلن رایگان برای استفاده پایه.
* [Formcarry.com](https://formcarry.com) - نقطه پایان فرم HTTP POST، پلن رایگان تا ۱۰۰ ارسال ماهانه را مجاز می‌داند.
* [formingo.co](https://www.formingo.co/)- فرم HTML آسان برای سایت‌های استاتیک. بدون نیاز به ثبت‌نام می‌توانید رایگان شروع کنید. پلن رایگان ۵۰۰ ارسال ماهانه و آدرس ایمیل reply-to قابل تنظیم را مجاز می‌کند.
* [FormKeep.com](https://www.formkeep.com/) - فرم نامحدود با ۵۰ ارسال ماهانه، محافظت در برابر اسپم، اعلان ایمیل و طراح کشیدن و رها کردن که خروجی HTML می‌دهد. امکانات بیشتر شامل قوانین سفارشی فیلد، تیم‌ها و ادغام با Google Sheets، Slack، ActiveCampaign و Zapier.
* [formlets.com](https://formlets.com/) — فرم آنلاین، فرم تک‌صفحه‌ای نامحدود در ماه، ۱۰۰ ارسال در ماه، اعلان ایمیل.
* [formspark.io](https://formspark.io/) - سرویس فرم به ایمیل، پلن رایگان فرم نامحدود، ۲۵۰ ارسال در ماه و پشتیبانی توسط تیم خدمات مشتری.
* [Formspree.io](https://formspree.io/) — ارسال ایمیل با درخواست HTTP POST. پلن رایگان به ۵۰ ارسال در هر فرم در ماه محدود است.
* [Formsubmit.co](https://formsubmit.co/) — نقطه پایان آسان برای فرم‌های HTML شما. برای همیشه رایگان. نیاز به ثبت‌نام ندارد.
* [Formlick.com](https://formlick.com) - جایگزین Typeform با پلن مادام‌العمر. کاربران می‌توانند یک فرم رایگان ایجاد و ارسال نامحدود دریافت کنند. در پلن پولی، فرم و ارسال نامحدود دارند.
* [getform.io](https://getform.io/) - پلتفرم بک‌اند فرم برای طراحان و توسعه‌دهندگان، ۱ فرم، ۵۰ ارسال، یک بارگذاری فایل، ۱۰۰ مگابایت فضای ذخیره‌سازی فایل.
* [HeroTofu.com](https://herotofu.com/) - بک‌اند فرم با شناسایی ربات و آرشیو رمزنگاری‌شده. ارسال فرم از طریق UI به ایمیل، Slack یا Zapier. از رابط کاربری خودتان استفاده کنید. نیاز به سرور ندارد. پلن رایگان فرم نامحدود و ۱۰۰ ارسال در ماه می‌دهد.
* [HeyForm.net](https://heyform.net/) - سازنده فرم آنلاین کشیدن و رها کردن. پلن رایگان اجازه ساخت فرم و دریافت ارسال نامحدود را می‌دهد. همراه با قالب‌های آماده، ضد اسپم و ۱۰۰ مگابایت فضای ذخیره‌سازی فایل.
* [Tally.so](https://tally.so/) - ۹۹٪ ویژگی‌ها رایگان هستند. پلن رایگان: فرم نامحدود، ارسال نامحدود، اعلان ایمیل، منطق فرم، دریافت پرداخت، بارگذاری فایل، صفحه تشکر سفارشی و بسیاری امکانات دیگر.
* [Hyperforms.app](https://hyperforms.app/) — ساخت سریع فرم به ایمیل و بیشتر بدون کد بک‌اند. حساب شخصی تا ۵۰ ارسال فرم ماهانه رایگان است.
* [Kwes.io](https://kwes.io/) - نقطه پایان فرم با امکانات زیاد. برای سایت‌های استاتیک عالی کار می‌کند. پلن رایگان تا ۱ سایت با ۵۰ ارسال ماهانه را شامل می‌شود.
* [Pageclip](https://pageclip.co/) - پلن رایگان یک سایت، یک فرم و ۱٬۰۰۰ ارسال ماهانه را مجاز می‌کند.
* [Qualtrics Survey](https://qualtrics.com/free-account) — ساخت فرم و نظرسنجی حرفه‌ای با این ابزار کلاس اول. ۵۰+ قالب نظرسنجی تخصصی. حساب رایگان محدود به ۱ نظرسنجی فعال، ۱۰۰ پاسخ در هر نظرسنجی و ۸ نوع پاسخ است.
* [Screeb](https://screeb.app/) - نظرسنجی درون‌اپ و تحلیل محصول برای رمزگشایی رفتار کاربر. پلن رایگان دائمی ۵۰۰ کاربر فعال ماهانه، پاسخ و رویداد نامحدود، ادغام‌های متعدد، خروجی، و گزارش‌های دوره‌ای را ارائه می‌دهد.
* [smartforms.dev](https://smartforms.dev/) - بک‌اند فرم قدرتمند و آسان برای سایت شما، پلن همیشه رایگان با ۵۰ ارسال ماهانه، ۲۵۰ مگابایت فضای فایل، ادغام Zapier، خروجی CSV/JSON، ریدایرکت سفارشی، صفحه پاسخ سفارشی، بات تلگرام و Slack، اعلان ایمیل تکی.
* [Survicate](https://survicate.com/) — جمع‌آوری بازخورد از تمام منابع و ارسال نظرسنجی پیگیری با یک ابزار. تحلیل خودکار بازخورد و استخراج بینش با هوش مصنوعی. نظرسنجی ایمیلی، وبسایت، داخل محصول یا موبایل رایگان، سازنده نظرسنجی AI و ۲۵ پاسخ ماهانه.
* [staticforms.xyz](https://www.staticforms.xyz/) - ادغام آسان فرم HTML بدون هیچ کد سمت سرور و رایگان. پس از ارسال فرم، ایمیلی با محتوای فرم به آدرس ثبت‌شده شما ارسال می‌شود.
* [stepFORM.io](https://stepform.io) - سازنده فرم و آزمون. پلن رایگان پنج فرم، حداکثر ۳ مرحله در هر فرم و ۵۰ پاسخ ماهانه دارد.
* [Typeform.com](https://www.typeform.com/) — افزودن فرم‌های زیبا به وبسایت. پلن رایگان فقط ۱۰ فیلد در هر فرم و ۱۰۰ پاسخ ماهانه مجاز می‌کند.
* [WaiverStevie.com](https://waiverstevie.com) - پلتفرم امضای الکترونیکی با REST API. می‌توانید اعلان‌ها را با webhook دریافت کنید. پلن رایگان اسناد امضاشده را واترمارک می‌کند اما پاکت و امضا نامحدود می‌دهد.
* [Web3Forms](https://web3forms.com) - فرم تماس برای سایت‌های استاتیک و JAMStack بدون نیاز به کد بک‌اند. پلن رایگان فرم نامحدود، دامنه نامحدود و ۲۵۰ ارسال در ماه را مجاز می‌کند.
  * [WebAsk](https://webask.io) - سازنده نظرسنجی و فرم. پلن رایگان شامل سه نظرسنجی برای هر حساب، ۱۰۰ پاسخ ماهانه و ده عنصر در هر نظرسنجی است.
  * [Wufoo](https://www.wufoo.com/) - فرم‌های سریع برای استفاده در وبسایت‌ها. پلن رایگان دارای محدودیت ۱۰۰ ارسال در هر ماه است.
  * [formpost.app](https://formpost.app) - سرویس فرم به ایمیل رایگان و نامحدود. تنظیم ریدایرکت سفارشی، پاسخ خودکار، وبهوک و غیره به صورت رایگان.
  * [Formester.com](https://formester.com) - اشتراک‌گذاری و جاسازی فرم‌های منحصر به فرد در وبسایت شما — بدون محدودیت در تعداد فرم‌های ایجاد شده یا ویژگی‌های محدود شده توسط پلن. ماهانه تا ۱۰۰ ارسال رایگان دریافت کنید.
  * [SimplePDF.eu](https://simplepdf.eu/embed) - ویرایشگر PDF را در وبسایت خود قرار دهید و هر PDF را به فرم قابل پر کردن تبدیل کنید. پلن رایگان اجازه استفاده نامحدود از PDF و سه ارسال برای هر PDF را می‌دهد.
  * [forms.app](https://forms.app/) — ساخت فرم‌های آنلاین با قابلیت‌هایی مانند منطق شرطی، محاسبه امتیاز خودکار و هوش مصنوعی. جمع‌آوری تا ۱۰۰ پاسخ با پلن رایگان، جاسازی فرم در وبسایت یا استفاده با لینک.
  * [Qualli](https://usequalli.com) - نظرسنجی‌های درون‌برنامه‌ای، ویژه موبایل. با Qualli AI سوالات عالی بسازید. پلن رایگان تا ۵۰۰ کاربر فعال ماهانه، ساخت فرم و تریگر نامحدود را ارائه می‌دهد.
  * [Sprig](https://sprig.com/) - ۱ نظرسنجی داخل محصول یا نظرسنجی با ریپلی در ماه، با تحلیل مبتنی بر هوش مصنوعی GPT.
  * [feedback.fish](https://feedback.fish/) - پلن رایگان امکان جمع‌آوری ۲۵ بازخورد را می‌دهد. ادغام آسان با کامپوننت‌های React و Vue فراهم شده است.
  * [Vidhook](https://vidhook.io/) - جمع‌آوری بازخورد با نظرسنجی‌های جذاب و نرخ پاسخ‌دهی بالا. پلن رایگان شامل ۱ نظرسنجی فعال، ۲۵ پاسخ به ازای هر نظرسنجی و قالب‌های قابل تنظیم است.

**[⬆️ بازگشت به بالا](#table-of-contents)**

## هوش مصنوعی مولد

  * [Zenable](https://zenable.io) - تصحیح خودکار خروجی ابزارهایی مانند Cursor، Windsurf و Copilot جهت انطباق با استانداردهای کیفیت و انطباق شرکت شما با استفاده از سیاست به عنوان کد. پلن رایگان شامل ۱۰۰ فراخوان ابزار در روز به سرور MCP و ۲۵ بازبینی خودکار pull request رایگان در روز از طریق اپلیکیشن GitHub است.
  * [Keywords AI](https://keywordsai.co) - بهترین پلتفرم پایش LLM. یک فرمت برای فراخوانی بیش از ۲۰۰ LLM با دو خط کد. ۱۰,۰۰۰ درخواست رایگان هر ماه و صفر دلار برای ویژگی‌های پلتفرم!
  * [Portkey](https://portkey.ai/) - پنل کنترل برای اپ‌های Gen AI با مجموعه مشاهده‌پذیری و دروازه هوش مصنوعی. ارسال و ثبت تا ۱۰,۰۰۰ درخواست در ماه رایگان.
  * [Braintrust](https://www.braintrustdata.com/) - ارزیابی‌ها، زمین بازی prompt و مدیریت داده برای Gen AI. پلن رایگان تا ۱,۰۰۰ ردیف ارزیابی خصوصی در هفته ارائه می‌دهد.
  * [Findr](https://www.usefindr.com/) - جستجوی جامع که به شما اجازه می‌دهد همه اپ‌های خود را همزمان جستجو کنید. دستیار جستجویی که با اطلاعات شما پاسخ می‌دهد. پلن رایگان، جستجوی یکپارچه نامحدود و ۵ کوئری روزانه co pilot رایگان را ارائه می‌دهد.
  * [ReportGPT](https://ReportGPT.app) - دستیار نویسندگی مبتنی بر هوش مصنوعی. کل پلتفرم رایگان است اگر کلید API خود را داشته باشید.
  * [Clair](https://askclair.ai/) - مرجع بالینی هوش مصنوعی. دانشجویان به مجموعه ابزار حرفه‌ای شامل جستجوی باز، خلاصه بالینی، بازبینی دارو، تداخل دارویی، کدهای ICD-10 و Stewardship به رایگان دسترسی دارند. همچنین، دوره آزمایشی رایگان برای مجموعه حرفه‌ای موجود است.
  * [Langtrace](https://langtrace.ai) - به توسعه‌دهندگان اجازه می‌دهد تا promptها، دیتاست‌ها و مشکلات مربوط به عملکرد اپلیکیشن LLM را رصد، ارزیابی، مدیریت و اشکال‌زدایی کنند. برای هر LLM ردیابی استاندارد تلومتری باز ایجاد می‌کند که به مشاهده‌پذیری کمک می‌کند و با هر کلاینت مشاهده‌پذیری کار می‌کند. پلن رایگان تا ۵۰,۰۰۰ ردیابی در ماه را ارائه می‌دهد.
  * [LangWatch](https://langwatch.ai) - پلتفرم LLMOps برای اندازه‌گیری، پایش و بهینه‌سازی اپلیکیشن‌های LLM در جهت قابلیت اطمینان، هزینه و عملکرد. با کامپوننت قدرتمند DSPy، همکاری بی‌دردسر بین مهندسان و تیم‌های غیر فنی جهت بهینه‌سازی و تولید محصولات GenAI را ممکن می‌سازد. پلن رایگان شامل همه ویژگی‌ها، ۱,۰۰۰ ردیابی در ماه و ۱ بهینه‌ساز DSPy است. [#opensource](https://github.com/langwatch/langwatch)
  * [Comet Opik](https://www.comet.com/site/products/opik/) - ارزیابی، تست و ارائه اپلیکیشن‌های LLM در سراسر چرخه توسعه و تولید. [#opensource](https://github.com/comet-ml/opik/)
  * [Langfuse](https://langfuse.com/) - پلتفرم متن‌باز مهندسی LLM که به تیم‌ها کمک می‌کند اپلیکیشن‌های LLM خود را به صورت مشارکتی اشکال‌زدایی، تحلیل و تکرار کنند. پلن رایگان برای همیشه شامل ۵۰,۰۰۰ مشاهده ماهانه و همه ویژگی‌های پلتفرم است. [#opensource](https://github.com/langfuse/langfuse)
  * [Pollinations.AI](https://pollinations.ai/) - هوش مصنوعی تولید تصویر رایگان و آسان با API رایگان. بدون نیاز به ثبت‌نام یا کلید API و گزینه‌های مختلف برای ادغام در وبسایت یا فرایند کاری. [#opensource](https://github.com/pollinations/pollinations)
  * [Othor AI](https://othor.ai/) - جایگزین سریع، ساده و امن مبتنی بر هوش مصنوعی برای راهکارهای هوش تجاری محبوب مانند Tableau، Power BI و Looker. Othor از مدل‌های زبان بزرگ (LLM) برای ارائه راهکارهای سفارشی هوش تجاری در چند دقیقه استفاده می‌کند. پلن رایگان برای همیشه یک workspace با پنج اتصال دیتاسورس برای یک کاربر و بدون محدودیت تحلیلی ارائه می‌کند. [#opensource](https://github.com/othorai/othor.ai)
  * [OpenRouter](https://openrouter.ai/models?q=free) - ارائه‌دهنده مدل‌های هوش مصنوعی رایگان مانند DeepSeek R1، V3، Llama و Moonshot AI. این مدل‌ها در پردازش زبان طبیعی عالی هستند و برای نیازهای توسعه متنوع مناسب‌اند. توجه داشته باشید که این مدل‌ها رایگان ولی دارای محدودیت نرخ هستند و مدل‌های پولی نیز برای نیازهای پیشرفته‌تر مانند Claude، OpenAI، Grok، Gemini و Nova ارائه می‌شود.

**[⬆️ بازگشت به بالا](#table-of-contents)**

## CDN و حفاظت

  * [bootstrapcdn.com](https://www.bootstrapcdn.com/) — CDN برای bootstrap، bootswatch و fontawesome.io
  * [cdnjs.com](https://cdnjs.com/) — ساده. سریع. قابل اعتماد. تحویل محتوا در بالاترین سطح. cdnjs یک سرویس رایگان و متن‌باز CDN است که بیش از ۱۱٪ وبسایت‌ها به آن اعتماد دارند و توسط Cloudflare پشتیبانی می‌شود.
  * [developers.google.com](https://developers.google.com/speed/libraries/) — Google Hosted Libraries یک شبکه توزیع محتوا برای محبوب‌ترین کتابخانه‌های جاوااسکریپت متن‌باز است.
  * [Stellate](https://stellate.co/) - Stellate یک CDN سریع و قابل اعتماد برای APIهای GraphQL شماست و برای دو سرویس رایگان است.
  * [jsdelivr.com](https://www.jsdelivr.com/) — CDN رایگان، سریع و قابل اعتماد متن‌باز. پشتیبانی از npm، GitHub، WordPress، Deno و غیره.
  * [Microsoft Ajax](https://docs.microsoft.com/en-us/aspnet/ajax/cdn/overview) — CDN مایکروسافت Ajax میزبان کتابخانه‌های جاوااسکریپت شخص ثالث محبوب مانند jQuery است و افزودن آن‌ها به وب‌اپلیکیشن شما را آسان می‌کند.
  * [ovh.ie](https://www.ovh.ie/ssl-gateway/) — حفاظت رایگان DDoS و گواهی SSL رایگان
  * [Skypack](https://www.skypack.dev/) — CDN جاوااسکریپت ۱۰۰٪ Native ES Module. رایگان برای ۱ میلیون درخواست در ماه به ازای هر دامنه.
  * [raw.githack.com](https://raw.githack.com/) — جایگزین مدرن **rawgit.com** که تنها با استفاده از Cloudflare فایل را میزبانی می‌کند.
  * [section.io](https://www.section.io/) — راهی ساده برای راه‌اندازی و مدیریت کامل راهکار Varnish Cache. ظاهراً برای همیشه برای یک سایت رایگان است.
  * [statically.io](https://statically.io/) — CDN برای ریپوی گیت (GitHub، GitLab، Bitbucket)، دارایی‌های مرتبط با WordPress و تصاویر
  * [toranproxy.com](https://toranproxy.com/) — پراکسی برای Packagist و GitHub. هیچ‌گاه CD شکست نمی‌خورد. رایگان برای استفاده شخصی، یک توسعه‌دهنده، بدون پشتیبانی
  * [UNPKG](https://unpkg.com/) — CDN برای هر چیزی روی npm
  * [weserv](https://images.weserv.nl/) — سرویس کش و تغییر اندازه تصویر. پردازش تصاویر به صورت لحظه‌ای با کش جهانی.
  * [Namecheap Supersonic](https://www.namecheap.com/supersonic-cdn/#free-plan) — حفاظت رایگان DDoS
  * [Gcore](https://gcorelabs.com/) شبکه توزیع محتوای جهانی، ۱ ترابایت و ۱ میلیون درخواست در ماه رایگان و میزبانی DNS رایگان
  * [CacheFly](https://portal.cachefly.com/signup/free2023) - تا ۵ ترابایت در ماه ترافیک رایگان CDN، ۱۹ نقطه حضور اصلی، ۱ دامنه و SSL یونیورسال.

**[⬆️ بازگشت به بالا](#table-of-contents)**

## PaaS

  * [anvil.works](https://anvil.works) - توسعه وب‌اپ با فقط پایتون. پلن رایگان با اپ‌های نامحدود و تایم‌اوت ۳۰ ثانیه‌ای.
  * [appwrite](https://appwrite.io) - پروژه‌های نامحدود بدون توقف پروژه (پشتیبانی از websockets) و سرویس احراز هویت. ۱ دیتابیس، ۳ باکت، ۵ فانکشن به ازای هر پروژه در پلن رایگان.
  * [configure.it](https://www.configure.it/) — پلتفرم توسعه اپ موبایل، رایگان برای دو پروژه، ویژگی‌های محدود اما بدون محدودیت منابع
  * [codenameone.com](https://www.codenameone.com/) — ابزار متن‌باز، چندسکویی و زنجیره توسعه موبایل برای توسعه‌دهندگان Java/Kotlin. رایگان برای استفاده تجاری با تعداد پروژه نامحدود
  * [deco.cx](https://www.deco.cx/en/dev) - پلتفرم فرانت‌اند لبه‌ای با CMS تصویری که از کد TypeScript تولید می‌شود. تست A/B، تفکیک محتوا و آنالیتیکس بلادرنگ داخلی. مناسب برای وبسایت‌های محتوایی و تجارت الکترونیک سازمانی. رایگان تا ۵ هزار بازدید صفحه در ماه یا پروژه‌های متن‌باز/شخصی.
  * [Deno Deploy](https://deno.com/deploy) - سیستم توزیع شده برای اجرای جاوااسکریپت، تایپ‌اسکریپت و WebAssembly در سراسر جهان و لبه. پلن رایگان شامل ۱۰۰,۰۰۰ درخواست روزانه و ۱۰۰ گیگابایت انتقال داده در ماه است.
  * [domcloud.co](https://domcloud.co) – سرویس هاست لینوکس با CI/CD از طریق GitHub، SSH و پایگاه داده MariaDB/Postgres. نسخه رایگان ۱ گیگابایت فضای ذخیره‌سازی و ۱ گیگابایت ترافیک شبکه در ماه و محدود به دامنه رایگان است.
  * [encore.dev](https://encore.dev/) — فریمورک بک‌اند با تحلیل ایستا جهت ارائه زیرساخت خودکار، کدنویسی بدون بولرپلیت و غیره. میزبانی ابری رایگان برای پروژه‌های سرگرمی.
  * [flightcontrol.dev](https://flightcontrol.dev/) - دیپلوی سرویس‌های وب، دیتابیس و غیره روی حساب AWS خودتان با فرایند Git push. پلن رایگان برای ۱ توسعه‌دهنده روی ریپوی شخصی GitHub. هزینه AWS جداگانه است، اما می‌توانید از اعتبارات و پلن رایگان AWS استفاده کنید.
  * [gigalixir.com](https://gigalixir.com/) - یک نمونه رایگان همیشه فعال و دیتابیس PostgreSQL رایگان با محدودیت ۲ اتصال، ۱۰,۰۰۰ سطر و بدون بکاپ برای اپ‌های Elixir/Phoenix ارائه می‌دهد.
  * [Glitch](https://glitch.com/) — میزبانی عمومی رایگان با اشتراک‌گذاری کد و همکاری بلادرنگ. پلن رایگان محدودیت ۱۰۰۰ ساعت در ماه دارد.
  * [leapcell](https://leapcell.io/) - پلتفرم توزیع‌شده قابل اعتماد برای اپلیکیشن‌ها، همراه با امکانات لازم برای رشد سریع شما. پلن رایگان شامل ۱۰۰ هزار فراخوان سرویس، ۱۰ هزار تسک غیرهمزمان و ۱۰۰ هزار دستور Redis است.
  * [pipedream.com](https://pipedream.com) - پلتفرم یکپارچه‌سازی ویژه توسعه‌دهندگان. توسعه هر جریان کاری بر پایه هر تریگر. جریان‌های کاری کدی که می‌توانید [رایگان اجرا](https://docs.pipedream.com/pricing/) کنید. بدون مدیریت سرور یا منابع ابری.
  * [pythonanywhere.com](https://www.pythonanywhere.com/) — میزبانی اپ پایتون ابری. حساب مبتدی رایگان، ۱ اپ وب پایتون روی دامنه your-username.pythonanywhere.com، ۵۱۲ مگابایت فضای خصوصی و یک دیتابیس MySQL
  * [ampt.dev](https://getampt.com/) - ساخت، دیپلوی و مقیاس‌دهی اپ‌های جاوااسکریپت روی AWS بدون پیکربندی پیچیده یا مدیریت زیرساخت. پلن پیش‌نمایش رایگان شامل ۵۰۰ فراخوان در ساعت، ۲۵۰۰ فراخوان روزانه و ۵۰,۰۰۰ فراخوان ماهانه است. دامین سفارشی فقط در پلن پولی مجاز است.
  * [Koyeb](https://www.koyeb.com) - پلتفرم سرورلس کاربرپسند برای دیپلوی اپ‌ها در سراسر جهان. اجرای کانتینر، اپ وب و API با دیپلوی مبتنی بر گیت، مقیاس‌پذیری خودکار، شبکه لبه جهانی و سرویس مش داخلی. نمونه رایگان با ۵۱۲ مگابایت رم، ۲ گیگابایت فضای ذخیره‌سازی و ۰.۱ CPU در فرانکفورت یا واشنگتن. دیتابیس مدیریت‌شده Postgres رایگان در فرانکفورت، واشنگتن و سنگاپور.
  * [Napkin](https://www.napkin.io/) - FaaS با ۵۰۰ مگابایت رم، تایم‌اوت پیش‌فرض ۱۵ ثانیه و ۵,۰۰۰ فراخوان API ماهانه با محدودیت ۵ فراخوان در ثانیه.
  * [Meteor Cloud](https://www.meteor.com/cloud) — میزبانی Galaxy. پلتفرم PaaS متئور شامل هاست اشتراکی رایگان MongoDB و SSL خودکار.
  * [Northflank](https://northflank.com) — ساخت و دیپلوی میکروسرویس‌ها، جاب‌ها و دیتابیس‌های مدیریت‌شده با UI، API و CLI قدرتمند. مقیاس‌دهی کانتینرها از کنترل نسخه و رجیستری داکر خارجی. پلن رایگان شامل دو سرویس، دو cron job و یک دیتابیس است.
  * [YepCode](https://yepcode.io) - پلتفرم همه‌کاره برای اتصال APIها و سرویس‌ها در محیط سرورلس. چابکی ابزارهای NoCode را با قدرت زبان‌های برنامه‌نویسی ترکیب می‌کند. پلن رایگان شامل [۱,۰۰۰ yep](https://yepcode.io/pricing/) است.
  * [WunderGraph](https://cloud.wundergraph.com) - پلتفرم متن‌باز برای ساخت و مدیریت سریع APIهای مدرن با CI/CD داخلی، ادغام GitHub و HTTPS خودکار. تا ۳ پروژه، ۱ گیگابایت ترافیک خروجی و ۳۰۰ دقیقه زمان build در ماه روی [پلن رایگان](https://wundergraph.com/pricing)
  * [Zeabur](https://zeabur.com) - دیپلوی سرویس‌ها با یک کلیک. رایگان برای سه سرویس، با ۵ دلار اعتبار رایگان ماهانه.
  * [mogenius](https://mogenius.com) - ساخت، دیپلوی و اجرای آسان سرویس‌ها روی Kubernetes. پلن رایگان امکان اتصال Kubernetes محلی با mogenius را می‌دهد و برای توسعه‌دهندگان فردی محیط تست شبیه تولید را روی کامپیوترشان فراهم می‌کند.
  * [genezio](https://genezio.com/) - ارائه‌دهنده فانکشن سرورلس با ۱ میلیون فراخوان فانکشن، ۱۰۰ گیگابایت پهنای باند و ۱۰ cron job در ماه رایگان، فقط برای مصارف غیرتجاری یا آکادمیک.

**[⬆️ بازگشت به بالا](#table-of-contents)**

## BaaS

  * [Activepieces](https://www.activepieces.com) - ساخت فلوهای اتوماسیون برای اتصال چندین اپ به هم در بک‌اند اپ شما. مثلاً، ارسال پیام Slack یا افزودن ردیف Google Sheet هنگام وقوع رویداد در اپ. تا ۵,۰۰۰ تسک در ماه رایگان.
  * [back4app.com](https://www.back4app.com) - Backend آسان، انعطاف‌پذیر و مقیاس‌پذیر مبتنی بر Parse Platform.
  * [backendless.com](https://backendless.com/) — BaaS موبایل و وب، با ۱ گیگابایت فضای فایل رایگان، ۵۰,۰۰۰ نوتیفیکیشن پوش ماهانه و ۱,۰۰۰ آبجکت داده در جدول.
  * [bismuth.cloud](https://www.bismuth.cloud/) — هوش مصنوعی ما API پایتون شما را روی runtime فانکشن و فضای ذخیره‌سازی می‌سازد و میزبانی می‌کند. رایگان بسازید و میزبانی کنید، چه در ویرایشگر آنلاین ما یا به صورت محلی با ابزار دلخواه.
  * [BMC Developer Program](https://developers.bmc.com/site/global/bmc_helix_platform/program/overview/index.gsp) — برنامه توسعه‌دهندگان BMC مستندات و منابع ساخت و دیپلوی نوآوری‌های دیجیتال برای سازمان شما را ارائه می‌دهد. دسترسی به sandbox شخصی جامع شامل پلتفرم، SDK و کتابخانه‌ای از کامپوننت‌ها جهت ساخت و سفارشی‌سازی اپ‌ها.
  * [connectycube.com](https://connectycube.com) - پیام‌رسانی نامحدود چت، تماس صوتی/تصویری p2p، پیوست فایل و پوش نوتیفیکیشن. رایگان برای اپ‌های تا ۱,۰۰۰ کاربر.
  * [convex.dev](https://convex.dev/) - بک‌اند واکنشی به عنوان سرویس، میزبانی داده شما (سند با رابطه و تراکنش ACID قابل سریال‌سازی)، فانکشن سرورلس و WebSocket برای استریم آپدیت به کلاینت‌ها. رایگان برای پروژه‌های کوچک — تا ۱ میلیون رکورد، ۵ میلیون فراخوان فانکشن ماهانه.
  * [darklang.com](https://darklang.com/) - زبان برنامه‌نویسی میزبانی شده همراه با ویرایشگر و زیرساخت. در دوره بتا قابل دسترسی است و بعد از بتا پلن رایگان سخاوتمندانه خواهد داشت.
  * [Firebase](https://firebase.com) — فایربیس به شما کمک می‌کند اپ موفق بسازید و اجرا کنید. پلن رایگان Spark شامل احراز هویت، هاستینگ، Firebase ML، دیتابیس بلادرنگ، فضای ابری، Testlab است. A/B Testing، آنالیتیکس، توزیع اپ، ایندکس اپ، پیام‌رسانی ابری (FCM)، Crashlytics، لینک‌های داینامیک، پیام‌رسانی درون‌اپ، پایش عملکرد، پیش‌بینی و تنظیمات ریموت همیشه رایگان هستند.
  * [Flutter Flow](https://flutterflow.io) — ساخت UI اپ Flutter بدون حتی یک خط کدنویسی. ادغام با Firebase نیز دارد. پلن رایگان دسترسی کامل به UI Builder و قالب‌های رایگان را فراهم می‌کند.
  * [getstream.io](https://getstream.io/) — ساخت چت درون‌برنامه‌ای، پیام‌رسانی، ویدئو و صوت و فیدهای مقیاس‌پذیر در چند ساعت به جای چند هفته
  * [hasura.io](https://hasura.io/) — Hasura دیتابیس‌های موجود شما را هر جا که میزبانی شده باشند گسترش داده و API گراف‌کیوال فوری و ایمن برای وب، موبایل و یکپارچه‌سازی داده ارائه می‌دهد. تا ۱ گیگابایت داده ماهانه رایگان.
  * [nhost.io](https://nhost.io) - بک‌اند سرورلس برای اپ‌های وب و موبایل. پلن رایگان شامل PostgreSQL، GraphQL (Hasura)، احراز هویت، ذخیره‌سازی و فانکشن سرورلس.
  * [onesignal.com](https://onesignal.com/) — پوش نوتیفیکیشن نامحدود رایگان. ۱۰,۰۰۰ ایمیل رایگان در ماه، با مخاطبین نامحدود و دسترسی به Auto Warm Up.
  * [paraio.com](https://paraio.com) — سرویس API بک‌اند با احراز هویت انعطاف‌پذیر، جستجوی متن کامل و کشینگ. رایگان برای یک اپ، ۱ گیگابایت داده اپ.
  * [pubnub.com](https://www.pubnub.com/) — اعلان‌های پوش (Push Notifications) رایگان برای حداکثر ۱ میلیون پیام در ماه و ۱۰۰ دستگاه فعال روزانه
  * [pushbots.com](https://pushbots.com/) — سرویس اعلان پوش. رایگان تا ۱.۵ میلیون پوش در ماه
  * [pushcrew.com](https://pushcrew.com/) — سرویس اعلان پوش. اعلان نامحدود برای حداکثر ۲۰۰۰ مشترک
  * [pusher.com](https://pusher.com/beams) — اعلان پوش نامحدود و رایگان برای ۲۰۰۰ کاربر فعال ماهانه. یک API واحد برای دستگاه‌های iOS و اندروید.
  * [quickblox.com](https://quickblox.com/) — بکند ارتباطی برای پیام‌رسانی فوری، تماس تصویری و صوتی و اعلان پوش
  * [restspace.io](https://restspace.io/) - پیکربندی یک سرور با سرویس‌هایی برای احراز هویت، داده، فایل، API ایمیل، قالب‌ها و موارد دیگر، سپس ترکیب در خطوط لوله و تبدیل داده‌ها.
  * [برنامه توسعه‌دهندگان Salesforce](https://developer.salesforce.com/signup) — ساخت اپلیکیشن‌ها با سرعت بالا با ابزارهای کشیدن و رها کردن. سفارشی‌سازی مدل داده با کلیک. توسعه بیشتر با کد Apex. یکپارچه‌سازی با هر چیزی با استفاده از APIهای قدرتمند. محافظت با امنیت سطح سازمانی. سفارشی‌سازی UI با کلیک یا هر فریم‌ورک وب پیشرفته. برنامه رایگان توسعه‌دهندگان دسترسی کامل به پلتفرم Lightning را فراهم می‌کند.
  * [simperium.com](https://simperium.com/) — انتقال داده به هرجا به‌صورت فوری و خودکار، چندسکویی، ارسال و ذخیره‌سازی ساخت‌یافته نامحدود، حداکثر ۲۵۰۰ کاربر در ماه
  * [Supabase](https://supabase.com) — جایگزین متن‌باز Firebase برای ساخت بکند. پلن رایگان شامل احراز هویت، پایگاه داده بلادرنگ و ذخیره‌سازی اشیاء.
  * [tyk.io](https://tyk.io/) — مدیریت API با احراز هویت، سهمیه‌بندی، مانیتورینگ و تحلیل. ارائه رایگان ابری
  * [zapier.com](https://zapier.com/) — اتصال اپلیکیشن‌های مورد استفاده برای خودکارسازی وظایف. پنج zap هر ۱۵ دقیقه و ۱۰۰ وظیفه در ماه
  * [IFTTT](https://ifttt.com) — خودکارسازی اپلیکیشن‌ها و دستگاه‌های مورد علاقه. رایگان تا ۲ اپلت
  * [Integrately](https://integrately.com) — خودکارسازی وظایف خسته‌کننده با یک کلیک. رایگان تا ۱۰۰ وظیفه، زمان بروزرسانی ۱۵ دقیقه، پنج اتوماسیون فعال، وبهوک.
  * [LeanCloud](https://leancloud.app/) — بکند موبایل. ۱ گیگابایت ذخیره‌سازی داده، ۲۵۶ مگابایت نمونه، ۳ هزار درخواست API در روز و ۱۰ هزار پوش در روز رایگان. (API بسیار مشابه Parse Platform)
  * [Claw.cloud](https://run.claw.cloud) - پلتفرم PaaS که برای کاربران با حساب GitHub قدیمی‌تر از ۱۸۰ روز، ۵ دلار اعتبار رایگان ماهانه ارائه می‌دهد. مناسب برای میزبانی اپلیکیشن، پایگاه داده و بیشتر. ([لینک ثبت‌نام با اعتبار رایگان](https://ap-southeast-1.run.claw.cloud/signin)).


**[⬆️ بازگشت به بالا](#table-of-contents)**

## پلتفرم کم‌کد (Low-code Platform)

  * [appsmith](https://www.appsmith.com/) — پروژه کم‌کد برای ساخت پنل مدیریت، ابزارهای داخلی و داشبورد. اتصال به بیش از ۱۵ پایگاه داده و هر API.
  * [Basedash](https://www.basedash.com) — پلتفرم کم‌کد برای ساخت پنل مدیریتی داخلی و داشبورد. پشتیبانی از پایگاه داده SQL و APIهای REST.
  * [BudiBase](https://budibase.com/) — Budibase یک پلتفرم کم‌کد متن‌باز برای ساخت اپلیکیشن‌های داخلی در چند دقیقه است. پشتیبانی از PostgreSQL، MySQL، MSSQL، MongoDB، Rest API، Docker، K8s
  * [Clappia](https://www.clappia.com) — پلتفرم کم‌کد طراحی شده برای ساخت اپلیکیشن‌های فرایندی کسب‌وکار با اپ موبایل و وب قابل سفارشی‌سازی. رابط کشیدن و رها کردن، ویژگی‌هایی مانند پشتیبانی آفلاین، ردیابی موقعیت مکانی بلادرنگ و ادغام با سرویس‌های شخص ثالث مختلف را ارائه می‌دهد.
  * [DronaHQ](https://www.dronahq.com/) — DronaHQ - پلتفرم کم‌کد که به تیم‌های مهندسی و مدیران محصول کمک می‌کند ابزارهای داخلی، سفر کاربری سفارشی، تجربه دیجیتال، اتوماسیون، پنل مدیریتی سفارشی و اپ‌های عملیاتی را ۱۰ برابر سریع‌تر بسازند.
  * [lil'bots](https://www.lilbots.io/) - اسکریپت‌نویسی و اجرای آنلاین با استفاده از APIهای داخلی رایگان مانند OpenAI، Anthropic، Firecrawl و دیگران. مناسب برای ساخت ایجنت‌های هوش مصنوعی / ابزار داخلی و اشتراک با تیم. پلن رایگان شامل دسترسی کامل به APIها، دستیار کدنویسی هوش مصنوعی و ۱۰,۰۰۰ اعتبار اجرا در ماه.
  * [Mendix](https://www.mendix.com/) — توسعه سریع اپلیکیشن برای سازمان‌ها، محیط‌های شن‌باکس نامحدود با پشتیبانی از تعداد کاربران کل، ۰.۵ گیگابایت ذخیره‌سازی و ۱ گیگابایت رم برای هر اپ. همچنین، IDEهای Studio و Studio Pro در پلن رایگان مجاز هستند.
  * [outsystems.com](https://www.outsystems.com/) — توسعه وب سازمانی PaaS برای لوکال یا ابر، ارائه محیط "شخصی" رایگان با کد نامحدود و پایگاه داده تا ۱ گیگابایت
  * [ReTool](https://retool.com/) — پلتفرم کم‌کد برای ساخت اپلیکیشن‌های داخلی. Retool بسیار قابل تغییر است. اگر بتوانید با جاوااسکریپت و یک API بنویسید، می‌توانید آن را در Retool بسازید. پلن رایگان تا ۵ کاربر در ماه، اپ‌ها و اتصال API نامحدود.
  * [Superblocks](https://superblocks.com/) — پلتفرم باز اپلیکیشن سازمانی طراحی‌شده برای توسعه‌دهندگان و تیم‌های نیمه‌فنی. استفاده از هوش مصنوعی برای تولید، ویرایش بصری و توسعه با کد. مدیریت متمرکز با ادغام‌ها، احراز هویت، مجوزها و لاگ‌های حسابرسی.
  * [ToolJet](https://www.tooljet.com/) — فریم‌ورک کم‌کد قابل توسعه برای ساخت اپلیکیشن‌های تجاری. اتصال به پایگاه داده، ذخیره‌سازی ابری، GraphQL، نقاط پایانی API، Airtable و غیره و ساخت اپ با سازنده اپلیکیشن کشیدن و رها کردن.
  * [UI Bakery](https://uibakery.io) — پلتفرم کم‌کد برای ساخت سریع‌تر اپلیکیشن‌های وب سفارشی. ساخت رابط کاربری با کشیدن و رها کردن و امکان سفارشی‌سازی بالا با جاوااسکریپت، پایتون و SQL. قابل ارائه به صورت ابری و خودمیزبان. رایگان تا ۵ کاربر.
  * [manubes](https://www.manubes.com) - پلتفرم ابری بدون‌کد قدرتمند با تمرکز بر مدیریت تولید صنعتی. رایگان برای یک کاربر با ۱ میلیون فعالیت کاری در ماه ([همچنین به زبان آلمانی موجود است](https://www.manubes.de)).

**[⬆️ بازگشت به بالا](#table-of-contents)**

## میزبانی وب (Web Hosting)

  * [Alwaysdata](https://www.alwaysdata.com/) — ۱۰۰ مگابایت میزبانی وب رایگان با پشتیبانی از MySQL، PostgreSQL، CouchDB، MongoDB، PHP، Python، Ruby، Node.js، Elixir، Java، Deno، وب‌سرورهای سفارشی، دسترسی از طریق FTP، WebDAV و SSH؛ صندوق پستی، لیست ایمیل و نصب‌کننده اپلیکیشن نیز شامل می‌شود.
  * [Awardspace.com](https://www.awardspace.com) — میزبانی وب رایگان + یک دامنه کوتاه رایگان، PHP، MySQL، نصب‌کننده اپلیکیشن، ارسال ایمیل و بدون تبلیغات.
  * [Bohr](https://bohr.io) — رایگان برای پروژه‌های غیرتجاری + پلتفرم توسعه و استقرار با رویکرد توسعه‌دهنده‌محور که دردسر زیرساخت را کاهش می‌دهد و راه‌اندازی را سریع می‌کند.
  * [Bubble](https://bubble.io/) — برنامه‌نویسی بصری برای ساخت اپلیکیشن‌های وب و موبایل بدون کد، رایگان با برند Bubble.
  * [dAppling Network](https://www.dappling.network/) - پلتفرم میزبانی وب غیرمتمرکز برای رابط‌های Web3 با تمرکز بر افزایش آپ‌تایم و امنیت و ارائه نقطه دسترسی اضافی برای کاربران.
  * [DigitalOcean](https://www.digitalocean.com/pricing) - ساخت و استقرار سه سایت استاتیک به صورت رایگان در پلن App Platform Starter.
  * [Drive To Web](https://drv.tw) — میزبانی مستقیم از Google Drive و OneDrive. فقط سایت‌های استاتیک. برای همیشه رایگان. یک سایت برای هر حساب Google/Microsoft.
  * [Fenix Web Server](https://preview.fenixwebserver.com) - اپ دسکتاپ توسعه‌دهنده برای میزبانی سایت‌ها به صورت محلی و اشتراک‌گذاری عمومی (به صورت بلادرنگ). کار به هر روشی که می‌خواهید، با رابط کاربری زیبا، API و/یا CLI.
  * [Fern](https://buildwithfern.com) - ساخت و میزبانی سایت مستندات مبتنی بر Markdown در پلن رایگان Fern. حتی می‌توانید مرجع API سایت خود را به طور خودکار از فایل‌های تعریف API تولید کنید. سایت در _yoursite_.docs.buildwithfern.com میزبانی می‌شود.
  * [Free Hosting](https://freehostingnoads.net/) — میزبانی رایگان با PHP 5، Perl، CGI، MySQL، FTP، فایل منیجر، ایمیل POP، زیر دامنه رایگان، میزبانی دامنه رایگان، ویرایشگر DNS Zone، آمار سایت، پشتیبانی آنلاین رایگان و بسیاری امکانات دیگر که سایر میزبان‌های رایگان ارائه نمی‌دهند.
  * [Freehostia](https://www.freehostia.com) — ارائه سرویس میزبانی رایگان شامل بهترین پنل کنترل صنعتی و نصب با یک کلیک بیش از ۵۰ اپ رایگان. راه‌اندازی فوری. بدون تبلیغات اجباری.
  * [HelioHost](https://heliohost.org) — میزبانی وب رایگان غیرانتفاعی با پنل کنترل Plesk، PHP، Node.js، Python، Django، Flask، .NET، Perl، CGI، MySQL، PostgreSQL، SQLite، ایمیل IMAP/POP3/SMTP، پهنای باند نامحدود، زیردامنه رایگان، ۱۰۰۰ مگابایت فضای رایگان با امکان ارتقاء.
  * [Kinsta Static Site Hosting](https://kinsta.com/static-site-hosting/) — استقرار تا ۱۰۰ سایت استاتیک رایگان، دامنه سفارشی با SSL، ۱۰۰ گیگابایت پهنای باند ماهانه، بیش از ۲۶۰ موقعیت CDN کلودفلر.
  * [Lecturify](https://www.lecturify.net/index.en.html) - میزبانی وب با دسترسی SFPT برای بارگذاری و دانلود فایل، php موجود است.
  * [Neocities](https://neocities.org) — سایت استاتیک، ۱ گیگابایت فضای رایگان با ۲۰۰ گیگابایت پهنای باند.
  * [Netlify](https://www.netlify.com/) — ساخت، استقرار و میزبانی سایت/اپ استاتیک رایگان تا ۱۰۰ گیگابایت داده و ۱۰۰ گیگابایت پهنای باند در ماه.
  * [pantheon.io](https://pantheon.io/) — میزبانی Drupal و WordPress، DevOps خودکار و زیرساخت مقیاس‌پذیر. رایگان برای توسعه‌دهندگان و آژانس‌ها. دامنه سفارشی ندارد.
  * [readthedocs.org](https://readthedocs.org/) — میزبانی مستندات رایگان با نسخه‌بندی، تولید PDF و امکانات بیشتر
  * [render.com](https://render.com) — ابر یکپارچه برای ساخت و اجرای اپ‌ها و سایت‌ها با SSL رایگان، CDN جهانی، شبکه خصوصی، استقرار خودکار از Git و پلن کاملاً رایگان برای سرویس‌های وب، پایگاه داده و صفحات استاتیک.
  * [SourceForge](https://sourceforge.net/) — پیدا کردن، ساخت و انتشار نرم‌افزار متن‌باز به صورت رایگان
  * [surge.sh](https://surge.sh/) — انتشار سایت استاتیک برای توسعه‌دهندگان Front-End. سایت نامحدود با پشتیبانی دامنه سفارشی
  * [telegra.ph](https://telegra.ph/) ساخت صفحه وب به سادگی با Quill
  * [tilda.cc](https://tilda.cc/) — یک سایت، ۵۰ صفحه، ۵۰ مگابایت فضا، فقط بلوک‌های اصلی از میان ۱۷۰+ بلوک موجود، بدون فونت، بدون فاوآیکون و بدون دامنه سفارشی
  * [Vercel](https://vercel.com/) — ساخت، استقرار و میزبانی اپلیکیشن‌های وب با SSL رایگان، CDN جهانی و URL پیش‌نمایش منحصر به فرد برای هر بار `git push`. ایده‌آل برای Next.js و سایر تولیدکننده‌های سایت استاتیک.
  * [Versoly](https://versoly.com/) — سازنده سایت متمرکز بر SaaS - سایت نامحدود، بیش از ۷۰ بلوک، پنج قالب، CSS سفارشی، فاوآیکون، SEO و فرم‌ها. بدون دامنه سفارشی.
  * [Qoddi](https://qoddi.com) - سرویس PaaS مشابه Heroku با رویکرد توسعه‌دهنده‌محور و امکانات جامع. پلن رایگان برای دارایی‌های استاتیک، استیجینگ و اپ‌های توسعه‌دهنده.
  * [FreeFlarum](https://freeflarum.com/) - میزبانی رایگان Flarum مبتنی بر جامعه برای حداکثر ۲۵۰ کاربر (برای حذف واترمارک پایین صفحه کمک مالی کنید).
  * [MDB GO](https://mdbgo.com/) - میزبانی رایگان برای یک پروژه با TTL کانتینر دو هفته، ۵۰۰ مگابایت RAM برای هر پروژه، SFTP - ۱ گیگابایت فضای دیسک.
  * [Patr Cloud](https://patr.cloud/) — پلتفرم ابری آسان برای استفاده که در کنار سرویس‌های پولی خود، میزبانی رایگان سه سایت استاتیک را ارائه می‌دهد.
  * [Serv00.com](https://serv00.com/) — ۳ گیگابایت میزبانی رایگان با بکاپ روزانه (۷ روز). پشتیبانی: کرون جاب، دسترسی SSH، مخازن (GIT، SVN و Mercurial)، پشتیبانی از: MySQL، PostgreSQL، MongoDB، PHP، Node.js، Python، Ruby، Java، Perl، TCL/TK، Lua، Erlang، Rust، Pascal، C، C++، D، R و بسیاری دیگر.
  - [Sevalla](https://sevalla.com/) - پلتفرم میزبانی برای ساده‌سازی استقرار و مدیریت اپلیکیشن‌ها، پایگاه داده‌ها و سایت‌های استاتیک - محدودیت ۱ گیگابایت برای هر سایت، ۱۰۰ گیگابایت پهنای باند رایگان، ۶۰۰ دقیقه ساخت رایگان، ۱۰۰ سایت برای هر حساب.

**[⬆️ بازگشت به بالا](#table-of-contents)**

## DNS

  * [1.1.1.1](https://developers.cloudflare.com/1.1.1.1/) - مفسر رایگان DNS عمومی که سریع و امن است (درخواست DNS شما را رمزنگاری می‌کند)، ارائه‌شده توسط Cloudflare. مناسب برای عبور از مسدودسازی DNS ارائه‌دهنده اینترنت، جلوگیری از جاسوسی در درخواست‌های DNS، و [فیلتر محتوای بزرگسالان و بدافزار](https://developers.cloudflare.com/1.1.1.1/1.1.1.1-for-families). همچنین [از طریق API](https://developers.cloudflare.com/1.1.1.1/encrypted-dns/dns-over-https/make-api-requests) قابل استفاده است. توجه: فقط مفسر DNS است، نه میزبان DNS.
  * [1984.is](https://www.1984.is/product/freedns/) — سرویس رایگان DNS با API و امکانات رایگان دیگر متعدد.
  * [cloudns.net](https://www.cloudns.net/) — میزبانی رایگان DNS تا ۱ دامنه با ۵۰ رکورد
  * [deSEC](https://desec.io) - میزبانی رایگان DNS با پشتیبانی API، طراحی‌شده با امنیت بالا. مبتنی بر نرم‌افزار متن‌باز و پشتیبانی‌شده توسط [SSE](https://www.securesystems.de/).
  * [dns.he.net](https://dns.he.net/) — میزبانی رایگان DNS با پشتیبانی از Dynamic DNS
  * [Zonomi](https://zonomi.com/) — سرویس میزبانی رایگان DNS با انتشار فوری DNS. پلن رایگان: ۱ منطقه DNS (نام دامنه) با حداکثر ۱۰ رکورد DNS.
  * [dnspod.com](https://www.dnspod.com/) — میزبانی رایگان DNS.
  * [duckdns.org](https://www.duckdns.org/) — DDNS رایگان با حداکثر ۵ دامنه در پلن رایگان. راهنمای پیکربندی برای تنظیمات مختلف.
  * [Dynv6.com](https://dynv6.com/) — سرویس DDNS رایگان با [پشتیبانی API](https://dynv6.com/docs/apis) و مدیریت انواع رکوردهای DNS (مانند CNAME، MX، SPF، SRV، TXT و غیره).
  * [freedns.afraid.org](https://freedns.afraid.org/) — میزبانی رایگان DNS. همچنین زیردامنه رایگان بر اساس دامنه‌های عمومی مشارکت‌شده کاربران [در دسترس است](https://freedns.afraid.org/domain/registry/). پس از ثبت‌نام، زیردامنه رایگان را از منوی "Subdomains" دریافت کنید.
  * [luadns.com](https://www.luadns.com/) — میزبانی رایگان DNS، سه دامنه، همه امکانات با محدودیت منطقی
  * [namecheap.com](https://www.namecheap.com/domains/freedns/) — DNS رایگان. بدون محدودیت در تعداد دامنه‌ها
  * [nextdns.io](https://nextdns.io) - فایروال مبتنی بر DNS، ۳۰۰ هزار درخواست رایگان ماهانه
  * [noip.at](https://noip.at/) — سرویس DDNS رایگان بدون ثبت‌نام، پیگیری، لاگ یا تبلیغ. بدون محدودیت دامنه.
  * [noip](https://www.noip.com/) — سرویس DDNS که اجازه می‌دهد تا ۳ نام میزبان رایگان با تأیید هر ۳۰ روز یکبار داشته باشید
  * [sslip.io](https://sslip.io/) — سرویس رایگان DNS که هنگام کوئری با نام میزبان حاوی IP جاسازی‌شده، همان IP را باز می‌گرداند.
  * [zilore.com](https://zilore.com/en/dns) — میزبانی رایگان DNS برای ۵ دامنه.
  * [zoneedit.com](https://www.zoneedit.com/free-dns/) — میزبانی رایگان DNS با پشتیبانی Dynamic DNS.
  * [zonewatcher.com](https://zonewatcher.com) — بکاپ خودکار و پایش تغییرات DNS. یک دامنه رایگان
  * [huaweicloud.com](https://www.huaweicloud.com/intl/en-us/product/dns.html) – میزبانی رایگان DNS توسط هواوی
  * [Hetzner](https://www.hetzner.com/dns-console) – میزبانی رایگان DNS توسط Hetzner با پشتیبانی API.
  * [Glauca](https://docs.glauca.digital/hexdns/) – میزبانی رایگان DNS برای حداکثر ۳ دامنه و پشتیبانی DNSSEC
  * [VolaryDDNS](https://volaryddns.net) - DDNS رایگان و پرسرعت بدون اشتراک یا تبلیغ
**[⬆️ بازگشت به بالا](#table-of-contents)**

## دامنه

  * [pp.ua](https://nic.ua/) — زیر دامنه‌های رایگان pp.ua.
  * [us.kg](https://nic.us.kg/) - زیر دامنه‌های رایگان us.kg.

**[⬆️ بازگشت به بالا](#table-of-contents)**

## IaaS

  * [4EVERLAND](https://www.4everland.org/) — سازگار با AWS S3 - APIها، عملیات رابط کاربری، CLI و سایر روش‌های آپلود؛ بارگذاری و ذخیره فایل‌ها از شبکه‌های IPFS و Arweave به صورت ایمن، راحت و کارآمد. کاربران ثبت‌نام‌شده می‌توانند ۶ گیگابایت فضای ذخیره‌سازی IPFS و ۳۰۰ مگابایت فضای ذخیره‌سازی Arweave رایگان دریافت کنند. هر فایل Arweave با حجم کمتر از ۱۵۰ کیلوبایت رایگان است.
  * [backblaze.com](https://www.backblaze.com/b2/) — فضای ذخیره‌سازی ابری Backblaze B2. ۱۰ گیگابایت فضای شی‌گرا (مشابه Amazon S3) رایگان برای مدت نامحدود
  * [filebase.com](https://filebase.com/) - فضای ذخیره‌سازی شی‌گرا سازگار با S3 مبتنی بر بلاک‌چین. ۵ گیگابایت فضای رایگان برای مدت نامحدود.
  * [Tebi](https://tebi.io/) - فضای ذخیره‌سازی شی‌گرا با سازگاری S3. ۲۵ گیگابایت فضای رایگان و ۲۵۰ گیگابایت انتقال خروجی رایگان.
  * [Idrive e2](https://www.idrive.com/e2/) - فضای ذخیره‌سازی شی‌گرا با سازگاری S3. ۱۰ گیگابایت فضای ذخیره‌سازی رایگان و ۱۰ گیگابایت پهنای باند دانلود ماهانه.
  * [C2 Object Storage](https://c2.synology.com/en-us/pricing/object-storage) - فضای ذخیره‌سازی شی‌گرا با سازگاری S3. ۱۵ گیگابایت فضای ذخیره‌سازی رایگان و ۱۵ گیگابایت دانلود ماهانه.

**[⬆️ بازگشت به بالا](#table-of-contents)**

## خدمات داده‌ای مدیریت‌شده

  * [Aiven](https://aiven.io/) - Aiven پلن‌های رایگان PostgreSQL، MySQL و Redis را روی پلتفرم داده‌ای متن‌باز خود ارائه می‌دهد. تک‌گره، ۱ پردازنده، ۱ گیگابایت RAM، و برای PostgreSQL و MySQL، ۵ گیگابایت فضای ذخیره‌سازی. مهاجرت آسان به پلن‌های گسترده‌تر یا بین ابرهای مختلف.
  * [airtable.com](https://airtable.com/) — ظاهر شبیه به صفحه گسترده، اما پایگاه داده رابطه‌ای. پایگاه‌های نامحدود، ۱۲۰۰ ردیف در هر پایگاه، و ۱۰۰۰ درخواست API در ماه
  * [Astra](https://www.datastax.com/products/datastax-astra/) — کاساندرا ابری به عنوان سرویس با [۸۰ گیگابایت پلن رایگان](https://www.datastax.com/products/datastax-astra/pricing)
  * [codehooks.io](https://codehooks.io/) — سرویس API/بک‌اند سرورلس جاوااسکریپت و پایگاه داده NoSQL با توابع، کوئری‌های شبیه MongoDB، جستجوی کلید/مقدار، سیستم کار، پیام‌های بلادرنگ، صف‌های کاری، CLI قدرتمند و مدیریت داده مبتنی بر وب. پلن رایگان شامل ۵ گیگابایت فضا و ۶۰ فراخوانی API در دقیقه. ۲ توسعه‌دهنده شامل می‌شود. نیاز به کارت اعتباری نیست.
  * [CrateDB](https://crate.io/) - پایگاه داده SQL توزیع‌شده متن‌باز برای تحلیل‌های بلادرنگ. [پلن رایگان CRFREE](https://crate.io/lp-crfree): تک‌گره با ۲ هسته پردازنده، ۲ گیگابایت رم، ۸ گیگابایت فضا. یک کلاستر برای هر سازمان، بدون نیاز به روش پرداخت.
  * [Upstash](https://upstash.com/) — ردیس سرورلس با پلن رایگان تا ۱۰,۰۰۰ درخواست در روز، ۲۵۶ مگابایت حداکثر اندازه پایگاه داده، و ۲۰ اتصال همزمان
  * [Couchbase Capella](https://www.couchbase.com/products/capella/) - استقرار یک کلاستر پایگاه داده مدیریت‌شده رایگان برای همیشه، مناسب برای توسعه‌دهندگان جهت ساخت نسل بعدی اپلیکیشن‌ها از IoT تا AI
  * [MongoDB Atlas](https://www.mongodb.com/cloud/atlas) — پلن رایگان ۵۱۲ مگابایت ارائه می‌دهد
  * [redsmin.com](https://www.redsmin.com/) — سرویس مانیتورینگ و مدیریت بلادرنگ آنلاین برای Redis، مانیتورینگ یک نمونه Redis رایگان
  * [redislabs](https://redislabs.com/try-free/) - نمونه رایگان Redis با ۳۰ مگابایت
  * [MemCachier](https://www.memcachier.com/) — سرویس مدیریت‌شده Memcache. رایگان تا ۲۵ مگابایت، ۱ سرور پروکسی، و آنالیز پایه
  * [scalingo.com](https://scalingo.com/) — عمدتاً PaaS اما پلن رایگان ۱۲۸ تا ۱۹۲ مگابایتی برای MySQL، PostgreSQL یا MongoDB ارائه می‌دهد
  * [SeaTable](https://seatable.io/) — پایگاه داده منعطف شبیه صفحه گسترده ساخته شده توسط تیم Seafile. جداول نامحدود، ۲۰۰۰ خط، نسخه‌بندی ۱ ماهه، تا ۲۵ عضو تیم.
  * [skyvia.com](https://skyvia.com/) — پلتفرم داده ابری با پلن رایگان و تمام پلن‌ها در حالت بتا کاملاً رایگان هستند
  * [StackBy](https://stackby.com/) — ابزاری که انعطاف‌پذیری صفحه گسترده، قدرت پایگاه داده و ادغام با اپلیکیشن‌های کسب‌وکار را در یک جا دارد. پلن رایگان شامل کاربران نامحدود، ده stack و ۲ گیگابایت پیوست در هر stack است.
  * [TiDB Cloud](https://en.pingcap.com/tidb-cloud/) — TiDB یک RDBMS توزیع‌شده و متن‌باز سازگار با MySQL است. TiDB Serverless هر ماه ۵ گیگابایت ذخیره ردیفی، ۵ گیگابایت ذخیره ستونی و ۵۰ میلیون Request Unit (RU) رایگان می‌دهد.
  * [Turso by ChiselStrike](https://chiselstrike.com/) - تجربه توسعه SQLite در یک پایگاه داده Edge. پلن رایگان برای همیشه، ۹ گیگابایت فضای کلی، تا ۵۰۰ پایگاه داده، تا ۳ موقعیت جغرافیایی، ۱ میلیارد خواندن ردیف در ماه و پشتیبانی توسعه محلی با SQLite.
  * [InfluxDB](https://www.influxdata.com/) — پایگاه داده سری زمانی، رایگان تا ۳ مگابایت در ۵ دقیقه نوشتن، ۳۰ مگابایت در ۵ دقیقه خواندن و ۱۰,۰۰۰ سری کاردینالیتی
  * [restdb.io](https://restdb.io/) - پایگاه داده NoSQL سریع و ساده ابری. با restdb.io اسکیمای داده، روابط، API خودکار REST (با کوئری‌های شبیه MongoDB)، و رابط کاربری چندکاربره مؤثر جهت مدیریت داده دریافت می‌کنید. پلن رایگان اجازه ۳ کاربر، ۲۵۰۰ رکورد و ۱ درخواست API بر ثانیه را می‌دهد.
  * [CockroachDB Cloud](https://www.cockroachlabs.com/pricing/) — پلن رایگان ماهانه ۵۰ میلیون RU و ۱۰ گیگابایت فضای ذخیره‌سازی (معادل ۱۵ دلار) رایگان ارائه می‌دهد. ([Request Unit چیست؟](https://www.cockroachlabs.com/docs/cockroachcloud/metrics-request-units.html))
  * [Neo4j Aura](https://neo4j.com/cloud/aura/) — پایگاه داده گراف بومی مدیریت‌شده / پلتفرم تحلیل با زبان Cypher و API REST. محدودیت اندازه گراف (۵۰ هزار گره، ۱۷۵ هزار رابطه).
  * [Neon](https://neon.tech/) — PostgreSQL مدیریت‌شده، ۰.۵ گیگابایت فضا (کلی)، ۱ پروژه، ۱۰ شاخه، پایگاه داده‌های نامحدود، شاخه اصلی همیشه فعال (تعلیق خودکار پس از ۵ دقیقه)، ۲۰ ساعت زمان فعال ماهانه (کلی) برای محاسبه شاخه غیر اصلی.
  * [Prisma Postgres](https://prisma.io/postgres) - هاست سریع Postgres مبتنی بر یونیکرنل و اجرا روی سرور فیزیکی، ۱ گیگابایت فضا، ۱۰ پایگاه داده، یکپارچه با Prisma ORM.
  * [Dgraph Cloud](https://cloud.dgraph.io/pricing?type=free) — پایگاه داده گراف بومی مدیریت‌شده با API گراف‌کیوال. محدود به ۱ مگابایت انتقال داده در روز.
  * [Tinybird](https://tinybird.co) - ClickHouse مدیریت‌شده سرورلس با ingest داده بدون اتصال از طریق HTTP و انتشار کوئری SQL به عنوان API مدیریت‌شده HTTP. بدون محدودیت زمانی در پلن رایگان، ۱۰ گیگابایت فضا + ۱۰۰۰ درخواست API روزانه.
  * [TigerGraph Cloud](https://www.tigergraph.com/cloud/) — پایگاه داده گراف بومی مدیریت‌شده / پلتفرم تحلیل با زبان کوئری شبیه SQL و API REST. یک نمونه رایگان با دو هسته پردازنده، ۸ گیگابایت رم و ۵۰ گیگابایت فضا که پس از ۱ ساعت عدم فعالیت به خواب می‌رود.
  * [TerminusCMS](https://terminusdb.com/pricing) — سرویس مدیریت‌شده رایگان برای TerminusDB، پایگاه داده سندی و گرافی نوشته‌شده با Prolog و Rust. رایگان برای توسعه‌دهنده، سرویس پولی برای استقرار سازمانی و پشتیبانی.
  * [filess.io](https://filess.io) - filess.io پلتفرمی است که می‌توانید دو پایگاه داده تا ۱۰ مگابایت برای هرکدام از DBMSهای زیر رایگان بسازید: MySQL، MariaDB، MongoDB و PostgreSQL.
  * [xata.io](https://xata.io) - پایگاه داده سرورلس با جستجو و آنالیز قدرتمند داخلی. یک API، چندین کتابخانه client type-safe، بهینه‌شده برای گردش کار توسعه شما. پلن رایگان برای همیشه برای توسعه‌دهندگان سرگرمی کافی است که شامل سه واحد از Xata است، برای تعریف واحد به سایت مراجعه کنید.
  * [8base.com](https://www.8base.com/) - 8base پلتفرم توسعه low-code فول‌استک برای توسعه‌دهندگان جاوااسکریپت روی MySQL و GraphQL و بک‌اند سرورلس است. امکان شروع سریع ساخت وب‌اپلیکیشن با app builder و مقیاس‌پذیری آسان؛ پلن رایگان شامل: ۲۵۰۰ ردیف، ۵۰۰ فضای ذخیره‌سازی، ۱ گیگابایت ساعت پردازش سرورلس، و ۵ کاربر اپلیکیشن کلاینت.
  * [Nile](https://www.thenile.dev/) — پلتفرم Postgres برای اپلیکیشن‌های B2B. پایگاه داده نامحدود، همیشه فعال بدون خاموشی، ۱ گیگابایت فضا (کلی)، ۵۰ میلیون توکن کوئری، مقیاس‌پذیری خودکار، embedding برداری نامحدود



**[⬆️ بازگشت به بالا](#table-of-contents)**

## تونلینگ، WebRTC، سرورهای Web Socket و سایر روترها

  * [Pinggy](https://pinggy.io) — آدرس عمومی برای localhost با یک دستور، بدون نیاز به دانلود. تونل HTTPS / TCP / TLS. پلن رایگان دارای مدت عمر تونل ۶۰ دقیقه است.
  * [conveyor.cloud](https://conveyor.cloud/) — افزونه Visual Studio برای نمایش IIS Express در شبکه محلی یا از طریق تونل به یک آدرس عمومی.
  * [Hamachi](https://www.vpn.net/) — سرویس میزبانی‌شده VPN از LogMeIn که امکان گسترش شبکه‌های شبیه LAN به تیم‌های توزیع‌شده را به صورت امن فراهم می‌کند؛ پلن رایگان با شبکه‌های نامحدود و حداکثر ۵ نفر.
  * [Mirna Sockets](https://mirna.cloud/) - پلتفرم رایگان Socket as a Service که هنگام استقرار کد سرور Web Socket به شما آدرس wss:// می‌دهد و امکان مانیتورینگ عملکرد آن را فراهم می‌کند.
  * [localhost.run](https://localhost.run/) — نمایش سرورهای محلی از طریق تونل به یک آدرس عمومی.
  * [localtunnel](https://theboroer.github.io/localtunnel-www/) — نمایش سرورهای محلی از طریق تونل به یک آدرس عمومی. نسخه میزبانی‌شده رایگان و [متن‌باز](https://github.com/localtunnel/localtunnel).
  * [ngrok.com](https://ngrok.com/) — نمایش سرورهای محلی از طریق تونل به یک آدرس عمومی.
  * [cname.dev](https://cname.dev/) — سرویس پراکسی معکوس پویا رایگان و ایمن.
  * [serveo](https://serveo.net/) — نمایش سرورهای محلی به اینترنت. بدون نصب، بدون ثبت‌نام. زیردامنه رایگان، بدون محدودیت.
  * [Radmin VPN](https://www.radmin-vpn.com/) — اتصال چندین رایانه از طریق VPN و ایجاد شبکه‌ای شبیه LAN. تعداد همتایان نامحدود. (جایگزین Hamachi)
  * [segment.com](https://segment.com/) — هاب ترجمه و مسیر‌دهی رویدادها به سرویس‌های ثالث. ۱۰۰,۰۰۰ رویداد در ماه رایگان
  * Google STUN — [stun:stun.l.google.com:19302](stun:stun.l.google.com:19302)
  * Twilio STUN — [stun:global.stun.twilio.com:3478?transport=udp](stun:global.stun.twilio.com:3478?transport=udp)
  * [Tailscale](https://tailscale.com/) — VPN بدون پیکربندی، مبتنی بر پروتکل متن‌باز WireGuard. نصب روی MacOS، iOS، ویندوز، لینوکس و اندروید. پلن رایگان شخصی با ۱۰۰ دستگاه و ۳ کاربر.
  * [webhookrelay.com](https://webhookrelay.com) — مدیریت، اشکال‌زدایی، fan-out و پراکسی کردن همه وب‌هوک‌ها به مقصدهای عمومی یا داخلی (یعنی localhost). همچنین نمایش سرورهای در شبکه خصوصی از طریق تونل به یک endpoint عمومی HTTP (`https://yoursubdomain.webrelay.io <----> http://localhost:8080`).
  * [Hookdeck](https://hookdeck.com/pricing) — توسعه، تست و مانیتورینگ وب‌هوک‌ها از هرجا. ۱۰۰ هزار درخواست و ۱۰۰ هزار تلاش در ماه با سه روز نگهداری داده.
  * [Xirsys](https://www.xirsys.com/pricing/) — استفاده نامحدود STUN + ۵۰۰ مگابایت پهنای باند TURN ماهانه، پهنای باند محدود، یک منطقه جغرافیایی.
  * [ZeroTier](https://www.zerotier.com) — اترنت مجازی مدیریت‌شده FOSS به عنوان سرویس. شبکه‌های رمزنگاری‌شده end-to-end نامحدود تا ۲۵ کلاینت در پلن رایگان. کلاینت برای دسکتاپ/موبایل/NA؛ رابط وب برای پیکربندی قوانین مسیریابی سفارشی و تأیید گره‌های جدید در شبکه خصوصی
  * [LocalXpose](https://localxpose.io) — پراکسی معکوس برای نمایش سرورهای محلی به اینترنت. پلن رایگان دارای عمر تونل ۱۵ دقیقه است.
  * [Traefik-Hub](https://traefik.io/traefik-hub/) - انتشار سرویس‌های محلی در حال اجرا از طریق تونل به URL عمومی سفارشی و ایمن‌سازی آن‌ها با کنترل دسترسی. رایگان برای ۵ سرویس در یک کلاستر.
  * [Expose](https://expose.dev/) - نمایش سایت‌های محلی از طریق تونل‌های ایمن. پلن رایگان شامل سرور EU، زیردامنه تصادفی و کاربر تک نفره.
  * [btunnel](https://www.btunnel.in/) — نمایش localhost و سرور محلی tcp به اینترنت. پلن رایگان شامل فایل سرور، هدرهای http سفارشی درخواست و پاسخ، حفاظت basic auth و تایم‌اوت تونل ۱ ساعته.

**[⬆️ بازگشت به بالا](#table-of-contents)**

## پیگیری باگ و مدیریت پروژه

  * [acunote.com](https://www.acunote.com/) — نرم‌افزار مدیریت پروژه و اسکرام رایگان برای تا ۵ عضو تیم
  * [asana.com](https://asana.com/) — رایگان برای پروژه خصوصی با همکاران
  * [Backlog](https://backlog.com) — هرآنچه تیم شما برای انتشار پروژه‌های عالی نیاز دارد در یک پلتفرم. پلن رایگان ۱ پروژه با ۱۰ کاربر و ۱۰۰ مگابایت فضا ارائه می‌دهد.
  * [Basecamp](https://basecamp.com/personal) - فهرست کارها، مدیریت مایلستون، پیام‌رسانی شبیه فروم، اشتراک فایل و پیگیری زمان. تا ۳ پروژه، ۲۰ کاربر و ۱ گیگابایت فضای ذخیره‌سازی.
  * [bitrix24.com](https://www.bitrix24.com/) — ابزار اینترانت و مدیریت پروژه. پلن رایگان با ۵ گیگابایت برای کاربران نامحدود.
  * [cacoo.com](https://cacoo.com/) — دیاگرام‌های آنلاین بلادرنگ: فلوچارت، UML، شبکه. رایگان برای حداکثر ۱۵ کاربر/دیاگرام و ۲۵ صفحه
  * [Chpokify](https://chpokify.com/) — Planning Poker تیمی که زمان تخمین اسپرینت را کاهش می‌دهد. رایگان تا ۵ کاربر، ادغام رایگان با Jira، تماس ویدیویی نامحدود، تیم نامحدود، جلسه نامحدود.
  * [clickup.com](https://clickup.com/) — مدیریت پروژه. رایگان، نسخه پرمیوم با فضای ابری. اپلیکیشن موبایل و ادغام با Git در دسترس است.
  * [Clockify](https://clockify.me) - ردیاب زمان و اپلیکیشن تایم‌شیت برای پیگیری ساعات کاری در پروژه‌ها. کاربران نامحدود، رایگان برای همیشه.
  * [Cloudcraft](https://cloudcraft.co/) — طراحی دیاگرام معماری حرفه‌ای در چند دقیقه با طراح بصری Cloudcraft، بهینه‌شده برای AWS با کامپوننت‌های هوشمندی که داده زنده نیز نشان می‌دهند. پلن رایگان دیاگرام‌های خصوصی نامحدود برای کاربر تکی دارد.
  * [Codegiant](https://codegiant.io) — مدیریت پروژه همراه با میزبانی ریپازیتوری و CI/CD. پلن رایگان شامل ریپازیتوری نامحدود، پروژه و سند با ۵ عضو تیم، ۵۰۰ دقیقه CI/CD در ماه، ۳۰۰۰۰ دقیقه اجرای کد سرورلس در ماه و ۱ گیگابایت فضای ریپازیتوری.
  * [Confluence](https://www.atlassian.com/software/confluence) - ابزار همکاری محتوا از Atlassian برای کمک به تیم‌ها جهت همکاری و به اشتراک‌گذاری دانش به طور مؤثر. پلن رایگان برای تا ۱۰ کاربر.
  * [contriber.com](https://www.contriber.com/) — پلتفرم مدیریت پروژه قابل سفارشی‌سازی، پلن استارتر رایگان، پنج workspace
  * [Crosswork](https://crosswork.app/) - پلتفرم مدیریت پروژه چندمنظوره. رایگان برای حداکثر ۳ پروژه، کاربران نامحدود، ۱ گیگابایت فضای ذخیره‌سازی.
  * [diagrams.net](https://app.diagrams.net/) — رسم دیاگرام آنلاین با ذخیره‌سازی محلی در Google Drive، OneDrive یا Dropbox. رایگان برای تمام قابلیت‌ها و سطوح ذخیره‌سازی.
  * [freedcamp.com](https://freedcamp.com/) - وظایف، بحث‌ها، اهداف، پیگیری زمان، تقویم، فایل‌ها و مدیریت رمز عبور. پلن رایگان با پروژه‌ها، کاربران و ذخیره‌سازی فایل نامحدود.
  * [easyretro.io](https://www.easyretro.io/) — ابزار ساده و شهودی برای بازنگری اسپرینت. پلن رایگان دارای سه برد عمومی و یک نظرسنجی در هر برد در هر ماه است.
  * [GForge](https://gforge.com) — ابزار مدیریت پروژه و پیگیری مسائل برای پروژه‌های پیچیده با گزینه‌های نصب در محل و SaaS. پلن رایگان SaaS برای پنج کاربر اول رایگان و برای پروژه‌های متن باز نیز رایگان است.
  * [gleek.io](https://www.gleek.io) — ابزار توصیف تا دیاگرام رایگان برای توسعه‌دهندگان. ایجاد دیاگرام‌های غیررسمی UML کلاس، شیء یا رابطه‌ای با استفاده از کلمه کلیدی شما.
  * [GraphQL Inspector](https://github.com/marketplace/graphql-inspector) - GraphQL Inspector فهرستی از تغییرات بین دو شِمای GraphQL ارائه می‌دهد. هر تفاوت به دقت توضیح داده شده و به عنوان شکسته، غیرشکسته یا خطرناک علامت‌گذاری می‌شود.
  * [huboard.com](https://huboard.com/) — مدیریت پروژه فوری برای مسائل GitHub شما، رایگان برای متن باز.
  * [Hygger](https://hygger.io) — پلتفرم مدیریت پروژه. پلن رایگان با کاربران، پروژه‌ها و بردهای نامحدود و ۱۰۰ مگابایت فضای ذخیره‌سازی.
  * [Instabug](https://instabug.com) — SDK جامع گزارش باگ و بازخورد درون‌برنامه برای اپ‌های موبایل. پلن رایگان تا ۱ اپ و یک عضو.
  * [WishKit](https://wishkit.io) — جمع‌آوری بازخورد کاربران درون‌برنامه برای اپ‌های iOS/macOS و اولویت‌بندی قابلیت‌ها بر اساس رأی کاربران. پلن رایگان تا ۱ اپ.
  * [Ilograph](https://www.ilograph.com/)  — دیاگرام‌های تعاملی که به کاربران اجازه می‌دهد زیرساخت خود را از دیدگاه‌ها و سطوح مختلف جزئیات ببینند. نمودارها قابل بیان در کد هستند. پلن رایگان دارای دیاگرام‌های خصوصی نامحدود با تا ۳ بیننده است.
  * [Jira](https://www.atlassian.com/software/jira) — ابزار پیشرفته مدیریت پروژه توسعه نرم‌افزار که در بسیاری از سازمان‌ها استفاده می‌شود. پلن رایگان تا ۱۰ کاربر.
  * [kanbanflow.com](https://kanbanflow.com/) — مدیریت پروژه مبتنی بر برد. رایگان، نسخه پریمیوم با گزینه‌های بیشتر.
  * [kanbantool.com](https://kanbantool.com/) — مدیریت پروژه مبتنی بر برد کانبان. پلن رایگان شامل دو برد و دو کاربر، بدون ضمیمه یا فایل.
  * [kan.bn](https://kan.bn/) - اپ کانبان قدرتمند و انعطاف‌پذیر برای سازماندهی کار، پیگیری پیشرفت و ارائه نتایج — همه در یک مکان. پلن رایگان تا ۱ کاربر با برد، لیست و کارت نامحدود.
  * [Kitemaker.co](https://kitemaker.co) - همکاری در تمام مراحل توسعه محصول و پیگیری کار در Slack، Discord، Figma و Github. کاربران و فضای نامحدود. پلن رایگان تا ۲۵۰ آیتم کاری.
  * [Kiter.app](https://www.kiter.app/) - اجازه دهید هرکسی جستجوی شغلی خود را سازماندهی و مصاحبه‌ها، فرصت‌ها و ارتباطات را پیگیری کند. اپ وب قدرتمند و افزونه Chrome. کاملاً رایگان.
  * [Kumu.io](https://kumu.io/)  — نقشه‌های رابطه با انیمیشن، دکوراسیون، فیلتر، خوشه‌بندی، واردات از صفحه‌گسترده و غیره. پلن رایگان پروژه‌های عمومی نامحدود. اندازه نمودار نامحدود. پروژه‌های خصوصی رایگان برای دانشجویان. حالت sandbox نیز برای نگهداری فایل‌ها به صورت خصوصی قابل استفاده است (آپلود، ویرایش، دانلود، حذف).
  * [Linear](https://linear.app/) — پیگیری مسائل با رابط کاربری روان. رایگان برای اعضای نامحدود، تا ۱۰ مگابایت بارگذاری فایل، ۲۵۰ مسئله (به جز آرشیو).
  * [leiga.com](https://www.leiga.com/) — Leiga یک محصول SaaS است که با استفاده از هوش مصنوعی به طور خودکار پروژه‌های شما را مدیریت می‌کند، به تیم شما کمک می‌کند متمرکز بماند و پتانسیل عظیم را آزاد کند و تضمین می‌کند پروژه‌ها طبق برنامه پیش بروند. رایگان تا ۱۰ کاربر، ۲۰ فیلد سفارشی، ۲ گیگابایت فضای ذخیره، ضبط ویدئو با هوش مصنوعی تا ۵ دقیقه در هر ویدئو، اجرای خودکار ۲۰ بار به ازای هر کاربر در ماه.
  * [Lucidchart](https://www.lucidchart.com/) - ابزار آنلاین رسم دیاگرام با قابلیت همکاری. پلن رایگان با سه سند قابل ویرایش، ۱۰۰ قالب حرفه‌ای و قابلیت همکاری پایه‌ای.
  * [MeisterTask](https://www.meistertask.com/) — مدیریت وظایف آنلاین برای تیم‌ها. رایگان تا ۳ پروژه و اعضای نامحدود در پروژه.
  * [MeuScrum](https://www.meuscrum.com/en) - ابزار اسکرام آنلاین رایگان با برد کانبان.
  * [nTask](https://www.ntaskmanager.com/) — نرم‌افزار مدیریت پروژه برای همکاری، برنامه‌ریزی، تحلیل و مدیریت وظایف روزانه تیم‌ها. پلن ضروری همیشه رایگان با ۱۰۰ مگابایت فضای ذخیره و پنج کاربر/تیم. فضای کار، جلسات، وظایف، برگه زمان و پیگیری مسائل نامحدود.
  * [Ora](https://ora.pm/) - مدیریت وظایف چابک و همکاری تیمی. رایگان تا ۳ کاربر و محدودیت فایل تا ۱۰ مگابایت.
  * [pivotaltracker.com](https://www.pivotaltracker.com/) — رایگان برای پروژه‌های عمومی نامحدود و دو پروژه خصوصی با سه کاربر فعال (خواندن و نوشتن) و کاربران منفعل نامحدود (فقط خواندن).
  * [plan.io](https://plan.io/) — مدیریت پروژه با میزبانی مخزن و گزینه‌های بیشتر. رایگان برای دو کاربر با ده مشتری و ۵۰۰ مگابایت فضای ذخیره‌سازی.
  * [Plane](https://plane.so/) - Plane ابزاری ساده، قابل توسعه و متن باز برای مدیریت پروژه و محصول است. رایگان برای اعضای نامحدود، تا ۵ مگابایت حجم آپلود فایل، ۱۰۰۰ مسئله.
  * [planitpoker.com](https://www.planitpoker.com/) — برنامه‌ریزی پوکر آنلاین رایگان (ابزار تخمین).
  * [point.poker](https://www.point.poker/) - برنامه‌ریزی پوکر آنلاین (ابزار تخمین اجماعی). رایگان برای کاربران، تیم‌ها، جلسات، دورها و رأی‌های نامحدود. نیازی به ثبت‌نام نیست.
  * [ScrumFast](https://www.scrumfast.com) - برد اسکرام با رابط کاربری بسیار شهودی، رایگان تا ۵ کاربر.
  * [Shake](https://www.shakebugs.com/) - ابزار گزارش باگ و بازخورد درون‌برنامه برای اپ‌های موبایل. پلن رایگان، ۱۰ گزارش باگ در هر اپ/ماه.
  * [Shortcut](https://shortcut.com/) - پلتفرم مدیریت پروژه. رایگان تا ۱۰ کاربر برای همیشه.
  * [Tadum](https://tadum.app) - اپ مدیریت دستور جلسه و صورتجلسه برای جلسات تکرارشونده، رایگان برای تیم‌های تا ۱۰ نفر.
  * [taiga.io](https://taiga.io/) — پلتفرم مدیریت پروژه برای استارتاپ‌ها و توسعه‌دهندگان چابک، رایگان برای متن باز.
  * [Tara AI](https://tara.ai/) — سرویس ساده مدیریت اسپرینت. پلن رایگان با وظایف، اسپرینت‌ها و فضای کاری نامحدود بدون محدودیت کاربر.
  * [targetprocess.com](https://www.targetprocess.com/) — مدیریت پروژه بصری، از کانبان و اسکرام تا تقریباً هر فرآیند عملیاتی. رایگان برای کاربران نامحدود، تا ۱۰۰۰ نهاد داده {[جزئیات بیشتر](https://www.targetprocess.com/pricing/)}
  * [taskade.com](https://www.taskade.com/) — فهرست وظایف مشارکتی و ساختاربندی تیمی به صورت بلادرنگ. پلن رایگان دارای یک workspace با وظایف و پروژه‌های نامحدود؛ ۱ گیگابایت فضای ذخیره‌سازی فایل؛ تاریخچه پروژه یک هفته؛ پنج شرکت‌کننده در هر جلسه ویدیویی.
  * [taskulu.com](https://taskulu.com/) — مدیریت پروژه مبتنی بر نقش. رایگان تا ۵ کاربر. یکپارچگی با GitHub/Trello/Dropbox/Google Drive.
  * [Teaminal](https://www.teaminal.com) - ابزار استندآپ، بازنگری و برنامه‌ریزی اسپرینت برای تیم‌های دورکار. رایگان تا ۱۵ کاربر.
  * [teamwork.com](https://teamwork.com/) — مدیریت پروژه و چت تیمی. رایگان برای پنج کاربر و دو پروژه. پلن‌های پریمیوم نیز در دسترس است.
  * [teleretro.com](https://www.teleretro.com/) — ابزار بازنگری ساده و سرگرم‌کننده با icebreaker، گیف و ایموجی. پلن رایگان شامل سه بازنگری و اعضای نامحدود است.
  * [testlio.com](https://testlio.com/) — پلتفرم پیگیری مسائل، مدیریت تست و تست بتا. رایگان برای استفاده خصوصی.
  * [terrastruct.com](https://terrastruct.com/) — ابزار آنلاین رسم دیاگرام مخصوص معماری نرم‌افزار. پلن رایگان تا ۴ لایه در هر دیاگرام.
  * [todoist.com](https://todoist.com/) — مدیریت وظایف فردی و تیمی. پلن رایگان: ۵ پروژه فعال، پنج کاربر در پروژه، آپلود فایل تا ۵ مگابایت، سه فیلتر و یک هفته تاریخچه فعالیت.
  * [trello.com](https://trello.com/) — مدیریت پروژه مبتنی بر برد. برد شخصی نامحدود، ۱۰ برد تیمی.
  * [Tweek](https://tweek.so/) — تقویم هفتگی ساده و مدیریت وظایف.
  * [ubertesters.com](https://ubertesters.com/) — پلتفرم تست، یکپارچه‌سازی و تسترهای جمعی، ۲ پروژه، پنج عضو.
  * [Wikifactory](https://wikifactory.com/) — سرویس طراحی محصول با پروژه، VCS و مسائل. پلن رایگان با پروژه‌ها و همکاران نامحدود و ۳ گیگابایت فضای ذخیره‌سازی.
  * [Yodiz](https://www.yodiz.com/) — توسعه چابک و پیگیری مسائل. رایگان تا ۳ کاربر، پروژه‌های نامحدود.
  * [YouTrack](https://www.jetbrains.com/youtrack/buy/#edition=incloud) — میزبانی رایگان YouTrack (InCloud) برای پروژه‌های FOSS و پروژه‌های خصوصی (رایگان تا سه کاربر). شامل پیگیری زمان و بردهای چابک.
  * [zenhub.com](https://www.zenhub.com) — تنها راهکار مدیریت پروژه درون GitHub. رایگان برای ریپوی عمومی، OSS و سازمان‌های غیرانتفاعی.
  * [zenkit.com](https://zenkit.com) — ابزار مدیریت پروژه و همکاری. رایگان تا ۵ عضو، ۵ گیگابایت پیوست.
  * [Zube](https://zube.io) — مدیریت پروژه با پلن رایگان برای ۴ پروژه و ۴ کاربر. یکپارچگی با GitHub در دسترس است.
  * [Toggl](https://toggl.com/) — ارائه‌دهنده دو ابزار رایگان بهره‌وری. [Toggl Track](https://toggl.com/track/) برای مدیریت و پیگیری زمان با پلن رایگان برای فریلنسرها، پیگیری زمان و گزارش‌گیری نامحدود، پروژه‌ها، مشتریان، تگ‌ها و غیره. و [Toggl Plan](https://toggl.com/plan/) برای برنامه‌ریزی وظایف با پلن رایگان برای توسعه‌دهندگان فردی با وظایف، نقاط عطف و تایم‌لاین نامحدود.
  * [Sflow](https://sflow.io) — sflow.io ابزار مدیریت پروژه برای توسعه نرم‌افزار چابک، بازاریابی، فروش و پشتیبانی مشتریان، به ویژه برای پروژه‌های برون‌سپاری و همکاری بین سازمانی است. پلن رایگان تا ۳ پروژه و پنج عضو.
  * [Pulse.red](https://pulse.red) — اپ رایگان و مینیمالیستی برای پیگیری زمان و برگه ساعات کاری پروژه‌ها.

**[⬆️ بازگشت به بالا](#table-of-contents)**

## ذخیره‌سازی و پردازش رسانه

  * [AndroidFileHost](https://androidfilehost.com/) - پلتفرم رایگان اشتراک‌گذاری فایل با سرعت، پهنای باند، تعداد فایل و تعداد دانلود نامحدود. عمدتاً برای فایل‌های مرتبط با توسعه اندروید مانند APK، رام سفارشی و تغییرات، اما ظاهراً سایر فایل‌ها را نیز می‌پذیرد.
  * [borgbase.com](https://www.borgbase.com/) — میزبانی بک‌آپ امن و ساده برای Borg Backup. ۱۰ گیگابایت فضای پشتیبان رایگان و دو مخزن.
  * [icedrive.net](https://www.icedrive.net/) - سرویس ذخیره‌سازی ابری ساده. ۱۰ گیگابایت فضای رایگان.
  * [sync.com](https://www.sync.com/) - سرویس ذخیره‌سازی ابری End-to-End. ۵ گیگابایت فضای رایگان.
  * [pcloud.com](https://www.pcloud.com/) - سرویس ذخیره‌سازی ابری. تا ۱۰ گیگابایت فضای رایگان.
  * [sirv.com](https://sirv.com/) — CDN هوشمند تصویر با بهینه‌سازی و تغییر اندازه آنی تصویر. پلن رایگان شامل ۵۰۰ مگابایت فضای ذخیره و ۲ گیگابایت پهنای باند است.
  * [cloudimage.io](https://www.cloudimage.io/en/home) — سرویس کامل بهینه‌سازی تصویر و CDN با بیش از ۱۵۰۰ نقطه حضور در سراسر جهان. انواع تغییر اندازه، فشرده‌سازی و افزودن واترمارک به تصویر. پلاگین‌های متن باز برای تصاویر ریسپانسیو، ساخت تصویر ۳۶۰ و ویرایش تصویر. پلن رایگان ماهانه با ۲۵ گیگابایت ترافیک CDN، ۲۵ گیگابایت فضای کش و تبدیل‌های نامحدود.
  * [cloudinary.com](https://cloudinary.com/) — آپلود تصویر، ویرایش قدرتمند، ذخیره‌سازی و تحویل برای سایت‌ها و اپ‌ها، با کتابخانه‌های Ruby، Python، Java، PHP، Objective-C و بیشتر. پلن رایگان شامل ۲۵ اعتبار ماهانه (هر اعتبار برابر با ۱۰۰۰ تبدیل تصویر، ۱ گیگابایت فضای ذخیره یا ۱ گیگابایت استفاده از CDN).
  * [embed.ly](https://embed.ly/) — ارائه API برای جاسازی رسانه در صفحه وب، مقیاس‌پذیری ریسپانسیو تصویر و استخراج عناصر از صفحه وب. رایگان تا ۵۰۰۰ آدرس URL در ماه با ۱۵ درخواست در ثانیه.
  * [filestack.com](https://www.filestack.com/) — انتخاب، تبدیل و تحویل فایل، رایگان برای ۲۵۰ فایل، ۵۰۰ تبدیل و ۳ گیگابایت پهنای باند.
  * [file.io](https://www.file.io) - ۲ گیگابایت فضای ذخیره فایل. فایل پس از یک بار دانلود به صورت خودکار حذف می‌شود. API REST برای ارتباط با فضای ذخیره. محدودیت سرعت یک درخواست در دقیقه.
  * [freetools.site](https://freetools.site/) — ابزارهای آنلاین رایگان. تبدیل یا ویرایش اسناد، تصاویر، صوت، ویدیو و بیشتر.
  * [GoFile.io](https://gofile.io/) - پلتفرم رایگان اشتراک‌گذاری و ذخیره‌سازی فایل که می‌توان از طریق رابط وب و API استفاده کرد. حجم فایل، پهنای باند و تعداد دانلود نامحدود. اما در صورت غیرفعال شدن فایل (عدم دانلود بیش از ۱۰ روز) حذف می‌شود.
  * [gumlet.com](https://www.gumlet.com/) — میزبانی، پردازش و پخش تصویر و ویدیو از طریق CDN. پلن رایگان سخاوتمندانه ۲۵۰ گیگابایت در ماه برای ویدیو و ۳۰ گیگابایت در ماه برای تصویر ارائه می‌دهد.
  * [image-charts.com](https://www.image-charts.com/) — تولید نامحدود نمودار تصویری با واترمارک.
  * [Imgbot](https://github.com/marketplace/imgbot) — Imgbot رباتی دوست‌داشتنی برای بهینه‌سازی تصاویر شماست و در وقت شما صرفه‌جویی می‌کند. تصاویر بهینه شده یعنی حجم کمتر بدون کاهش کیفیت. رایگان برای متن باز.
  * [ImgBB](https://imgbb.com/) — ImgBB سرویس میزبانی نامحدود تصویر است. تصویر خود را هرجای صفحه بکشید و رها کنید. محدودیت ۳۲ مگابایت برای هر تصویر. پس از بارگذاری لینک مستقیم تصویر، BBCode و تصویر بندانگشتی HTML دریافت کنید. برای مشاهده تاریخچه بارگذاری وارد شوید.
  * [imgen](https://www.jitbit.com/imgen/) - API رایگان و نامحدود ساخت تصویر کاور شبکه اجتماعی، بدون واترمارک.
  * [imgix](https://www.imgix.com/) - کش، مدیریت و CDN تصویر. پلن رایگان شامل ۱۰۰۰ تصویر مبدأ، تبدیل نامحدود و ۱۰۰ گیگابایت پهنای باند.
  * [kraken.io](https://kraken.io/) — بهینه‌سازی تصویر به عنوان سرویس برای بهبود عملکرد وبسایت، پلن رایگان تا ۱ مگابایت حجم فایل.
  * [kvstore.io](https://www.kvstore.io/) — سرویس ذخیره‌سازی کلید-مقدار. پلن رایگان تا ۱۰۰ کلید، ۱ کیلوبایت به ازای هر کلید، ۱۰۰ فراخوانی در ساعت.
  * [npoint.io](https://www.npoint.io/) — ذخیره JSON با ویرایش ساختار به صورت مشارکتی.
  * [nitropack.io](https://nitropack.io/) - افزایش سرعت سایت به طور خودکار با بهینه‌سازی کامل فرانت‌اند (کشینگ، تصویر و کد، CDN). رایگان تا ۵۰۰۰ بازدید صفحه در ماه.
  * [otixo.com](https://www.otixo.com/) — رمزگذاری، اشتراک‌گذاری، کپی و انتقال همه فایل‌های ابری شما از یک مکان. پلن پایه انتقال فایل نامحدود با حداکثر ۲۵۰ مگابایت حجم فایل و امکان رمزگذاری پنج فایل را ارائه می‌دهد.
  * [packagecloud.io](https://packagecloud.io/) — مخازن پکیج میزبانی شده برای YUM، APT، RubyGem و PyPI. پلن رایگان محدود و پلن‌های متن باز با درخواست ارائه می‌شود.
  * [getpantry.cloud](https://getpantry.cloud/) — API ساده ذخیره داده JSON، مناسب برای پروژه‌های شخصی، هکاتون‌ها و اپ‌های موبایل!
  * [Pinata IPFS](https://pinata.cloud) — ساده‌ترین راه برای آپلود و مدیریت فایل‌ها در IPFS. رابط کاربری دوست‌داشتنی و API IPFS، پیناتا را ساده‌ترین سرویس پینینگ IPFS برای پلتفرم‌ها، خالقان و کلکسیونرها می‌کند. ۱ گیگابایت فضای رایگان به همراه دسترسی به API.
  * [placekitten.com](https://placekitten.com/) — سرویس سریع و ساده برای دریافت تصاویر گربه به عنوان جایگزین تصاویر (placeholder).
  * [plot.ly](https://plot.ly/) — نمودار و به‌اشتراک‌گذاری داده‌ها. پلن رایگان شامل فایل‌های عمومی نامحدود و ده فایل خصوصی است.
  * [podio.com](https://podio.com/) — می‌توانید با تیمی تا پنج نفر از Podio استفاده کنید و ویژگی‌های پلن پایه را به جز مدیریت کاربر امتحان کنید.
  * [QRME.SH](https://qrme.sh) - تولیدگر سریع و زیبا کد QR به صورت انبوه – بدون ورود، بدون واترمارک، بدون تبلیغ. تا ۱۰۰ آدرس در هر خروجی انبوه.
  * [QuickChart](https://quickchart.io) — تولید نمودار تصویری، گراف و کد QR قابل قرارگیری (embed) به صورت آنلاین.
  * [redbooth.com](https://redbooth.com) — همگام‌سازی فایل P2P، رایگان تا ۲ کاربر.
  * [resmush.it](https://resmush.it) — reSmush.it یک API رایگان برای بهینه‌سازی تصویر است. reSmush.it روی رایج‌ترین CMSها مانند وردپرس، دروپال یا مجنتو پیاده‌سازی شده. reSmush.it پرکاربردترین API بهینه‌سازی تصویر با بیش از هفت میلیارد تصویر پردازش‌شده است و همچنان رایگان است.
  * [Shotstack](https://shotstack.io) - API برای تولید و ویرایش ویدیو در مقیاس. رایگان تا ۲۰ دقیقه ویدیو رندر شده در ماه.
  * [tinypng.com](https://tinypng.com/) — API برای فشرده‌سازی و تغییر اندازه تصاویر PNG و JPEG، ماهانه ۵۰۰ فشرده‌سازی رایگان.
  * [transloadit.com](https://transloadit.com/) — مدیریت آپلود فایل و کدگذاری ویدیو، صوت، تصویر و سند. رایگان برای متن باز، خیریه‌ها و دانشجویان از طریق GitHub Student Developer Pack. اپلیکیشن‌های تجاری ۲ گیگابایت رایگان برای تست دریافت می‌کنند.
  * [twicpics.com](https://www.twicpics.com) - تصاویر واکنش‌گرا به عنوان سرویس. این سرویس یک CDN تصویر، API پردازش رسانه و کتابخانه فرانت‌اند برای خودکارسازی بهینه‌سازی تصاویر ارائه می‌دهد. استفاده رایگان تا ۳ گیگابایت ترافیک در ماه.
  * [uploadcare.com](https://uploadcare.com/hub/developers/) — Uploadcare یک خط لوله رسانه‌ای با ابزار نهایی مبتنی بر الگوریتم‌های پیشرفته ارائه می‌دهد. همه قابلیت‌ها برای توسعه‌دهندگان کاملاً رایگان است: API و UI بارگذاری فایل، CDN تصویر و سرویس‌های Origin، تحویل تطبیقی و فشرده‌سازی هوشمند. پلن رایگان شامل ۳۰۰۰ بارگذاری، ۳ گیگابایت ترافیک و ۳ گیگابایت فضای ذخیره‌سازی است.
  * [imagekit.io](https://imagekit.io) – CDN تصویر با بهینه‌سازی خودکار، تبدیل آنی و فضای ذخیره‌سازی که در چند دقیقه با تنظیمات فعلی شما ادغام می‌شود. پلن رایگان شامل ۲۰ گیگابایت پهنای باند ماهانه است.
  * [internxt.com](https://internxt.com) – Internxt Drive یک سرویس ذخیره‌سازی فایل با دانش صفر است که بر اساس حریم خصوصی مطلق و امنیت بی‌نقص ساخته شده است. ثبت‌نام کنید و برای همیشه ۱۰ گیگابایت رایگان دریافت کنید!
  * [degoo.com](https://degoo.com/) – ذخیره‌سازی ابری مبتنی بر هوش مصنوعی با ۲۰ گیگابایت رایگان، سه دستگاه، ۵ گیگابایت پاداش معرفی (۹۰ روز عدم فعالیت حساب).
  * [MConverter.eu](https://mconverter.eu/) – تبدیل گروهی فایل‌ها. از فرمت‌های زیادی پشتیبانی می‌کند، از جمله فرمت‌های جدیدی مانند [AVIF](https://mconverter.eu/convert/to/avif/). استخراج تمام فریم‌های تصویر از ویدیوها. رایگان برای حداکثر ده فایل ۱۰۰ مگابایتی در روز، پردازش در دسته‌های دو تایی.
  * [ImageEngine](https://imageengine.io/) – ImageEngine یک CDN تصویر جهانی و آسان برای استفاده است. راه‌اندازی زیر ۶۰ ثانیه. پشتیبانی از AVIF و JPEGXL، افزونه‌های WordPress، Magento، React، Vue و ... . حساب توسعه‌دهنده رایگان خود را [اینجا](https://imageengine.io/developer-program/) دریافت کنید.
  * [DocsParse](https://docsparse.com/) – پردازش هوشمند PDF و تصاویر با GPT و خروجی داده ساختار یافته در فرمت‌های JSON، CSV، EXCEL. ماهانه ۳۰ اعتبار رایگان.
  * [VaocherApp QR Code Generator](https://www.vaocherapp.com/qr-code-generator) – ساخت آسان QR Code سفارشی برای کارت هدیه، کوپن و تبلیغات. پشتیبانی از استایل‌دهی، رنگ و لوگوی سفارشی...
  * [LibreQR](https://libreqr.com) — تولیدکننده رایگان QR Code با تمرکز بر حریم خصوصی و بدون ردیابی. رایگان و بدون جمع‌آوری داده.

**[⬆️ بازگشت به بالا](#table-of-contents)**

## طراحی و رابط کاربری

  * [AllTheFreeStock](https://allthefreestock.com) - فهرست منتخب تصاویر استوک، صدا و ویدیوی رایگان.
  * [Float UI](https://floatui.com/) - ابزار رایگان توسعه وب برای ساخت سریع سایت‌های مدرن و واکنش‌گرا با طراحی حرفه‌ای، حتی برای غیرطراحان.
  * [Ant Design Landing Page](https://landing.ant.design/) - صفحه فرود Ant Design یک قالب ساخته شده با اجزای متحرک Ant Motion ارائه می‌دهد. شامل قالب‌های صفحه اصلی متعدد و امکان دانلود بسته کد قالب برای استفاده سریع. همچنین می‌توانید با ویرایشگر، صفحه اختصاصی خود را به سرعت بسازید.
  * [Backlight](https://backlight.dev/) — با تمرکز بر همکاری میان توسعه‌دهندگان و طراحان، Backlight یک پلتفرم کامل کدنویسی برای ساخت، مستندسازی، انتشار، مقیاس‌دهی و نگهداری سیستم‌های طراحی است. پلن رایگان اجازه می‌دهد تا ۳ ویرایشگر روی یک سیستم طراحی با بینندگان نامحدود کار کنند.
  * [BoxySVG](https://boxy-svg.com/app) — اپلیکیشن وب قابل نصب و رایگان برای طراحی SVG و خروجی گرفتن در فرمت‌های SVG، PNG، jpeg و دیگر فرمت‌ها.
  * [Carousel Hero](https://carouselhero.com/) - ابزار رایگان آنلاین برای ساخت کاروسل شبکه‌های اجتماعی.
  * [Circum Icons](https://circumicons.com) - آیکون‌های متن باز و سازگار مثل SVG برای React، Vue و Svelte.
  * [clevebrush.com](https://www.cleverbrush.com/) — اپلیکیشن رایگان طراحی گرافیک / ساخت کلاژ عکس. همچنین امکان یکپارچه‌سازی پولی به عنوان کامپوننت را ارائه می‌دهد.
  * [cloudconvert.com](https://cloudconvert.com/) — تبدیل هر چیزی به هر چیزی. پشتیبانی از ۲۰۸ فرمت از جمله ویدیو و گیف.
  * [CodeMyUI](https://codemyui.com) - مجموعه منتخب الهام‌های طراحی وب و رابط کاربری همراه با قطعه کد.
  * [ColorKit](https://colorkit.co/) - ساخت پالت رنگ آنلاین یا گرفتن الهام از پالت‌های برتر.
  * [coolors](https://coolors.co/) - ژنراتور پالت رنگ. رایگان.
  * [CMYK Pantone](https://www.cmyktopantone.com/) - تبدیل آسان مقادیر CMYK به نزدیک‌ترین رنگ پنتون و مدل‌های رنگی دیگر در چند ثانیه، رایگان.
  * [Branition](https://branition.com/colors) - پالت‌های رنگی دست‌چین شده، مناسب برای برندها.
  * [css-gradient.com](https://www.css-gradient.com/) - ابزار رایگان برای ساخت سریع گرادینت سفارشی CSS سازگار با مرورگرهای مختلف، در قالب RGB و HEX.
  * [easyvectors.com](https://easyvectors.com/) — سایت استوک وکتور SVG رایگان. بهترین گرافیک‌های وکتور را کاملاً رایگان دانلود کنید.
  * [figma.com](https://www.figma.com) — ابزار طراحی آنلاین و تیمی؛ پلن رایگان شامل فایل‌ها و بینندگان نامحدود با حداکثر ۲ ویرایشگر و سه پروژه.
  * [Flyon UI](https://flyonui.com/)- آسان‌ترین کتابخانه کامپوننت برای Tailwind CSS.
  * [framer.com](https://www.framer.com/) - Framer به شما در تکرار و متحرک‌سازی ایده‌های رابط برای اپ، وب‌سایت یا محصول بعدی‌تان کمک می‌کند. برای تایید Framer به عنوان ابزار حرفه‌ای نمونه‌سازی: بینندگان نامحدود، تا ۲ ویرایشگر و ۳ پروژه.
  * [freeforcommercialuse.net](https://freeforcommercialuse.net/) — عکس‌های استوک با مجوز مدل/مالکیت بدون نگرانی FFCU
  * [Gradientos](https://www.gradientos.app) - انتخاب گرادینت را سریع و آسان می‌کند.
  * [Icon Horse](https://icon.horse) – گرفتن بهترین رزولوشن favicon هر سایت از طریق API ساده ما.
  * [Iconoir](https://iconoir.com) – کتابخانه آیکون متن باز با هزاران آیکون، پشتیبانی از React، React Native، Flutter، Vue، Figma و Framer.
  * [Icons8](https://icons8.com) — آیکون، تصویرسازی، عکس، موسیقی و ابزار طراحی. پلن رایگان فرمت‌های محدود و رزولوشن پایین ارائه می‌دهد. هنگام استفاده از دارایی‌ها، به Icons8 لینک دهید.
  * [landen.co](https://www.landen.co) — ساخت، ویرایش و انتشار سریع سایت و صفحه فرود بدون کدنویسی. پلن رایگان اجازه ساخت یک سایت کاملاً قابل تنظیم و انتشار آنلاین را می‌دهد.
  * [Quant Ux](https://quant-ux.com/) - ابزار نمونه‌سازی و طراحی Quant Ux. کاملاً رایگان و متن باز.
  * [lensdump.com](https://lensdump.com/) - میزبانی رایگان تصاویر ابری.
  * [Lorem Picsum](https://picsum.photos/) - ابزاری رایگان و آسان برای گرفتن تصاویر جایگزین شیک. بعد از URL، ابعاد مورد نظر را اضافه کنید تا تصویر تصادفی دریافت کنید.
  * [LottieFiles](https://lottiefiles.com/) - بزرگ‌ترین پلتفرم آنلاین برای فرمت انیمیشن کوچک Lottie برای طراحان و توسعه‌دهندگان. دسترسی به ابزارها و افزونه‌های Lottie برای اندروید، iOS و وب.
  * [MagicPattern](https://www.magicpattern.design/tools) — مجموعه‌ای از ژنراتورهای پس‌زمینه CSS و SVG و ابزارهایی برای گرادینت، پترن و بلاب.
  * [marvelapp.com](https://marvelapp.com/) — طراحی، نمونه‌سازی و همکاری؛ پلن رایگان محدود به یک کاربر و یک پروژه.
  * [Mindmup.com](https://www.mindmup.com/) — ساخت نامحدود نقشه ذهنی رایگان و ذخیره ابری. نقشه‌های ذهنی شما در همه‌جا و از هر دستگاهی در دسترس است.
  * [Mockplus iDoc](https://www.mockplus.com/idoc) - ابزار قدرتمند همکاری و تحویل طراحی Mockplus iDoc. پلن رایگان شامل سه کاربر و پنج پروژه با همه امکانات است.
  * [mockupmark.com](https://mockupmark.com/create/free) — ساخت موکاپ واقعی تی‌شرت و لباس برای شبکه‌های اجتماعی و فروشگاه آنلاین، ۴۰ موکاپ رایگان.
  * [Mossaik](https://mossaik.app) - ژنراتور رایگان تصویر SVG با ابزارهایی مثل موج، بلاب و پترن.
  * [movingpencils.com](https://movingpencils.com) — ویرایشگر وکتور سریع و مبتنی بر مرورگر. کاملاً رایگان.
  * [Octopus.do](https://octopus.do) — سازنده بصری نقشه سایت. ساختار وب‌سایت خود را به صورت زنده بسازید و به سرعت برای همکاری به اشتراک بگذارید.
  * [Pencil](https://github.com/evolus/pencil) - ابزار طراحی متن باز مبتنی بر Electron.
  * [Penpot](https://penpot.app) - ابزار طراحی و نمونه‌سازی مبتنی بر وب و متن باز. پشتیبانی از SVG. کاملاً رایگان.
  * [pexels.com](https://www.pexels.com/) - تصاویر استوک رایگان برای استفاده تجاری. API رایگان برای جستجوی عکس بر اساس کلیدواژه ارائه می‌دهد.
  * [photopea.com](https://www.photopea.com) — ویرایشگر پیشرفته و رایگان آنلاین با رابط کاربری مشابه فتوشاپ و پشتیبانی از فرمت‌های PSD، XCF و Sketch (فتوشاپ، Gimp و Sketch App).
  * [pixlr.com](https://pixlr.com/) — ویرایشگر رایگان مرورگر آنلاین در سطح نمونه‌های تجاری.
  * [Plasmic](https://www.plasmic.app/) - ابزار طراحی وب سریع، آسان و قدرتمند و سازنده صفحه که در کدبیس شما ادغام می‌شود. ساخت صفحات واکنش‌گرا یا کامپوننت‌های پیچیده، قابلیت توسعه با کد و انتشار به سایت و اپلیکیشن.
  * [Pravatar](https://pravatar.cc/) - ساخت آواتار تصادفی/جایگزین با امکان هات‌لینک مستقیم URL در وب/اپلیکیشن شما.
  * [Proto.io](https://www.proto.io) - ساخت نمونه‌های کاملاً تعاملی رابط کاربری بدون کدنویسی. پلن رایگان پس از پایان دوره آزمایشی فعال می‌شود. شامل یک کاربر، یک پروژه، پنج نمونه اولیه، ۱۰۰ مگابایت فضای آنلاین و پیش‌نمایش اپ proto.io.
  * [resizeappicon.com](https://resizeappicon.com/) — سرویس ساده برای تغییر اندازه و مدیریت آیکون‌های اپلیکیشن.
  * [Rive](https://rive.app) — ساخت و انتشار انیمیشن زیبا در هر پلتفرم. رایگان برای همیشه برای افراد. سرویس شامل ویرایشگر و میزبانی گرافیک‌ها بر روی سرورهای خودشان است. همچنین ران‌تایم برای بسیاری از پلتفرم‌ها برای اجرای خروجی‌های Rive ارائه می‌دهد.
  * [storyset.com](https://storyset.com/) — ساخت تصویرسازی رایگان و سفارشی برای پروژه با این ابزار.
  * [smartmockups.com](https://smartmockups.com/) — ساخت موکاپ محصول، ۲۰۰ موکاپ رایگان.
  * [Shadcn Studio](https://shadcnstudio.com/theme-editor) — پیش‌نمایش تغییرات تم در کامپوننت‌ها و چیدمان‌های مختلف.
  * [Tailark](https://tailark.com/) - مجموعه‌ای از بلاک‌های UI مدرن و واکنش‌گرا برای سایت‌های بازاریابی.
  * [tabler-icons.io](https://tabler-icons.io/) — بیش از ۱۵۰۰ آیکون SVG رایگان و قابل ویرایش با قابلیت کپی و پیست.
  * [tweakcn](https://tweakcn.com/) — تم‌های زیبا برای shadcn/ui. سفارشی‌سازی رنگ، تایپوگرافی و بیشتر به صورت زنده.
  * [UI Avatars](https://ui-avatars.com/) - ساخت آواتار با حروف اولیه نام‌ها. URLها قابل هات‌لینک مستقیم در وب/اپلیکیشن شما. پشتیبانی از پارامترهای پیکربندی از طریق URL.
  * [unDraw](https://undraw.co/) - مجموعه‌ای همیشه به‌روز از تصاویر SVG زیبا که کاملاً رایگان و بدون نیاز به ذکر منبع قابل استفاده هستند.
  * [unsplash.com](https://unsplash.com/) - تصاویر استوک رایگان برای اهداف تجاری و غیرتجاری (مجوز کاملاً آزاد).
  * [vectr.com](https://vectr.com/) — اپلیکیشن رایگان طراحی برای وب و دسکتاپ.
  * [walkme.com](https://www.walkme.com/) — پلتفرم راهبری و تعامل سازمانی، پلن رایگان شامل سه راهبر تا ۵ مرحله برای هر راهبر.
  * [Webflow](https://webflow.com) - سازنده سایت WYSIWYG با انیمیشن و میزبانی سایت. رایگان برای دو پروژه.
  * [Updrafts.app](https://updrafts.app) - سازنده سایت WYSIWYG برای طراحی‌های مبتنی بر tailwindcss. رایگان برای استفاده غیرتجاری.
  * [whimsical.com](https://whimsical.com/) - نمودار جریان، وایرفریم، یادداشت چسبان و نقشه ذهنی گروهی. ساخت تا ۴ برد رایگان.
  * [Zeplin](https://zeplin.io/) — پلتفرم همکاری طراح و توسعه‌دهنده. نمایش طراحی‌ها، دارایی‌ها و راهنمای سبک. رایگان برای یک پروژه.
  * [Pixelixe](https://pixelixe.com/) — ساخت و ویرایش گرافیک و تصاویر منحصربه‌فرد و جذاب آنلاین.
  * [Responsively App](https://responsively.app) - ابزار رایگان توسعه برای توسعه سریع‌تر و دقیق‌تر اپلیکیشن‌های وب واکنش‌گرا.
  * [SceneLab](https://scenelab.io) - ویرایشگر گرافیکی موکاپ آنلاین با مجموعه‌ای رو به رشد از قالب‌های طراحی رایگان.
  * [xLayers](https://xlayers.dev) - پیش‌نمایش و تبدیل فایل‌های Sketch به Angular، React، Vue، LitElement، Stencil، Xamarin و ... (رایگان و متن باز در https://github.com/xlayers/xlayers)
  * [Grapedrop](https://grapedrop.com/) — سازنده صفحه وب واکنش‌گرا، قدرتمند و بهینه برای SEO مبتنی بر فریم‌ورک GrapesJS. رایگان برای ۵ صفحه اول، دامنه اختصاصی نامحدود و همه امکانات.
  * [Mastershot](https://mastershot.app) - ویرایشگر ویدیویی مبتنی بر مرورگر، کاملاً رایگان. بدون واترمارک، خروجی تا رزولوشن ۱۰۸۰p.
  * [Unicorn Platform](https://unicornplatform.com/) - سازنده آسان صفحه فرود با میزبانی. یک سایت رایگان.
  * [SVGmix.com](https://www.svgmix.com/) - مخزن عظیم با بیش از ۳۰۰ هزار آیکون SVG رایگان، مجموعه‌ها و لوگوهای برند. دارای ویرایشگر وکتور ساده در مرورگر برای ویرایش سریع فایل.
  * [svgrepo.com](https://www.svgrepo.com/) - جستجو و یافتن بهترین آیکون یا وکتور برای پروژه‌ها با استفاده از کتابخانه‌های مختلف وکتور. دانلود رایگان SVG برای استفاده تجاری.
  * [haikei.app](https://www.haikei.app/) - اپلیکیشن وب برای تولید اشکال SVG، پس‌زمینه و پترن‌های منحصربه‌فرد، آماده استفاده در ابزار و جریان کاری طراحی شما.
  * [Canva](https://canva.com) - ابزار آنلاین رایگان طراحی برای ساخت محتوای بصری.
  * [Superdesigner](https://superdesigner.co) - مجموعه‌ای از ابزارهای رایگان طراحی برای ساخت پس‌زمینه، پترن، شکل، تصویر و ... منحصربه‌فرد با چند کلیک.
  * [TeleportHQ](https://teleporthq.io/) - پلتفرم طراحی و توسعه فرانت‌اند Low-code. امکان ساخت و انتشار فوری سایت‌های استاتیک Headless با ۳ پروژه رایگان، همکار نامحدود و خروجی کد رایگان.
  * [vector.express](https://vector.express) — تبدیل سریع و آسان وکتورهای AI، CDR، DWG، DXF، EPS، HPGL، PDF، PLT، PS و SVG.
  * [Vertopal](https://www.vertopal.com) - پلتفرم رایگان آنلاین برای تبدیل فایل‌ها به فرمت‌های مختلف. شامل تبدیل‌کننده‌های توسعه‌دهنده مانند JPG به SVG، GIF به APNG، PNG به WEBP، JSON به XML و غیره.
  * [okso.app](https://okso.app) - اپلیکیشن طراحی آنلاین مینیمالیستی. امکان ساخت سریع طرح و یادداشت تصویری. خروجی به PNG، JPG، SVG و WEBP. همچنین به عنوان PWA قابل نصب است. رایگان برای همه (بدون نیاز به ثبت‌نام).
  * [Wdrfree SVG](https://wdrfree.com/free-svg) - فایل‌های برش SVG رایگان سیاه و سفید.
  * [Lucide](https://lucide.dev) - مجموعه رایگان آیکون SVG قابل سفارشی‌سازی و سازگار.
  * [Logo.dev](https://www.logo.dev) - API لوگوی شرکت با بیش از ۴۴ میلیون برند، به سادگی با فراخوانی یک URL. ۱۰,۰۰۰ درخواست API اول رایگان.
  * [MDBootstrap](https://mdbootstrap.com/) - کیت رابط کاربری Bootstrap، Angular، React و Vue رایگان برای استفاده شخصی و تجاری با بیش از ۷۰۰ کامپوننت، قالب‌های چشمگیر، نصب یک دقیقه‌ای، آموزش‌های گسترده و جامعه بزرگ.
  * [TW Elements](https://tw-elements.com/) - کامپوننت‌های رایگان Bootstrap بازسازی شده با Tailwind CSS، با طراحی بهتر و قابلیت‌های بیشتر.
  * [DaisyUI](https://daisyui.com/) -- رایگان. "استفاده از Tailwind CSS با کلاس‌های کمتر" و ارائه کامپوننت‌هایی مانند دکمه‌ها.
  * [Scrollbar.app](https://scrollbar.app) -- اپلیکیشن وب ساده و رایگان برای طراحی اسکرول‌بارهای سفارشی برای وب.
  * [css.glass](https://css.glass/) -- اپلیکیشن وب رایگان برای ایجاد طرح‌های گلس‌مورفیک با استفاده از CSS.
  * [hypercolor.dev](https://hypercolor.dev/) -- مجموعه‌ای منتخب از گرادینت‌های رنگی Tailwind CSS، به همراه انواع ژنراتورها برای ساخت گرادینت‌های اختصاصی.
  * [iconify.design](https://icon-sets.iconify.design/) -- مجموعه‌ای از بیش از ۱۰۰ بسته آیکون با یک رابط یکپارچه. امکان جستجو بین بسته‌ها و خروجی گرفتن آیکون‌ها به صورت SVG یا برای فریم‌ورک‌های محبوب وب را فراهم می‌کند.
  * [NextUI](https://nextui.org/) -- رایگان. کتابخانه رابط کاربری زیبا، سریع و مدرن برای React و Next.js.
  * [Glyphs](https://glyphs.fyi/) -- رایگان، قدرتمندترین آیکون‌های وب، کاملاً قابل ویرایش و سیستم طراحی واقعاً متن‌باز.
  * [ShadcnUI](https://ui.shadcn.com/) -- کامپوننت‌های زیبا که می‌توانید آنها را کپی و در اپلیکیشن خود بچسبانید. دسترس‌پذیر. قابل سفارشی‌سازی. متن‌باز.
  * [HyperUI](https://www.hyperui.dev/) -- کامپوننت‌های رایگان و متن‌باز Tailwind CSS.
  * [Calendar Icons Generator](https://calendariconsgenerator.app/) -- تولید آیکون‌های منحصربه‌فرد برای کل یک سال تنها با یک کلیک، کاملاً رایگان
  * [Image BG Blurer](https://imagebgblurer.com/) -- ساخت پس‌زمینه بلور شده برای یک تصویر با استفاده از همان تصویر به عنوان منبع بلور، برای ابزارهایی مانند Notion، Trello، Jira و غیره
  * [Webstudio](https://webstudio.is/) -- جایگزین متن‌باز برای Webflow. پلن رایگان شامل وبسایت‌های نامحدود روی دامنه آنها، پنج وبسایت با دامنه سفارشی، ده هزار بازدید صفحه در ماه و ۲ گیگابایت فضای ذخیره‌سازی دارایی است.
  * [Nappy](https://nappy.co/) -- تصاویر زیبای افراد سیاه‌پوست و قهوه‌ای‌رنگ، رایگان. برای استفاده تجاری و شخصی.
  * [Tailkits](https://tailkits.com/) -- مجموعه‌ای منتخب از قالب‌ها، کامپوننت‌ها و ابزارهای Tailwind، به همراه ژنراتورهای کاربردی برای کد، گرید، سایه جعبه و بیشتر.
  * [Tailcolors](https://tailcolors.com/) -- پالت رنگی زیبا برای Tailwind CSS v4. پیش‌نمایش و کپی فوری کلاس رنگ مناسب Tailwind CSS.
  * [Excalidraw](https://excalidraw.com/) -- یک صفحه وب رسم آنلاین رایگان با امکان ذخیره رایگان محلی و خروجی گرفتن.
  * [Lunacy](https://icons8.com/lunacy) -- ابزار رایگان طراحی گرافیک با پشتیبانی آفلاین، دارایی‌های داخلی (آیکون، عکس، تصویرسازی) و همکاری همزمان. پلن رایگان شامل ۱۰ سند ابری، تاریخچه ۳۰ روزه، دارایی با کیفیت پایین و ابزارهای پایه طراحی است.

**[⬆️ بازگشت به بالا](#table-of-contents)**

## الهام‌بخش طراحی

  * [awwwards.](https://www.awwwards.com/) - [وب‌سایت‌های برتر] نمایش بهترین وب‌سایت‌های طراحی‌شده (با رأی طراحان).
  * [Behance](https://www.behance.net/) - [نمایشگاه طراحی] جایی که طراحان آثار خود را نمایش می‌دهند. قابل فیلتر با دسته‌بندی‌های پروژه‌های UI/UX.
  * [dribbble](https://dribbble.com/) - [نمایشگاه طراحی] الهام‌بخش طراحی منحصربه‌فرد، معمولاً برگرفته از اپلیکیشن‌های واقعی نیست.
  * [Landings](https://landings.dev/) - [تصاویر وب] پیدا کردن بهترین صفحات فرود برای الهام طراحی بر اساس سلیقه شما.
  * [Lapa Ninja](https://www.lapa.ninja/) - [صفحه فرود / کیت UI / تصاویر وب] گالری شامل ۶۰۲۵ نمونه برتر صفحه فرود، کتاب‌های رایگان برای طراحان و کیت‌های UI رایگان از سراسر وب.
  * [LovelyLanding.net](https://www.lovelylanding.net/) - [طرح‌های صفحه فرود] تصاویر صفحه فرود که مرتباً به‌روزرسانی می‌شوند. شامل اسکرین‌شات دسکتاپ، تبلت و موبایل.
  * [Mobbin](https://mobbin.design/) - [تصاویر موبایل] صرفه‌جویی در ساعت‌ها تحقیق UI و UX با کتابخانه‌ای شامل بیش از ۵۰٬۰۰۰ اسکرین‌شات قابل جستجو از اپلیکیشن‌های موبایل.
  * [Uiland Design](https://uiland.design/) - [تصاویر موبایل] مرور طراحی‌های UI موبایل و وب از شرکت‌های پیشرو در آفریقا و جهان.
  * [Mobile Patterns](https://www.mobile-patterns.com/) - [تصاویر موبایل] کتابخانه الهام‌بخش با بهترین الگوهای UI/UX (iOS و اندروید) برای ارجاع طراحان، توسعه‌دهندگان و سازندگان محصول.
  * [Page Flows](https://pageflows.com/) - [ویدئو و تصاویر موبایل/وب] ویدئوهایی از جریان کامل در بسیاری اپلیکیشن موبایل و وب. همچنین شامل اسکرین‌شات. جستجوی پیشرفته و فهرست‌بندی‌شده.
  * [Screenlane](https://screenlane.com/) - [تصاویر موبایل] الهام بگیرید و با آخرین روندهای طراحی UI اپلیکیشن‌های وب و موبایل همراه شوید. قابل فیلتر بر اساس الگو و اپلیکیشن.
  * [scrnshts](https://scrnshts.club/) - [تصاویر موبایل] مجموعه‌ای دست‌چین‌شده از بهترین تصاویر طراحی اپ استور.
  * [Refero](https://refero.design/) - [تصاویر وب] مجموعه برچسب‌خورده و قابل جستجو از رفرنس‌های طراحی از اپلیکیشن‌های وب عالی.

**[⬆️ بازگشت به بالا](#table-of-contents)**

## مصورسازی داده روی نقشه

  * [IP Geolocation](https://ipgeolocation.io/) — پلن DEVELOPER رایگان با ۳۰٬۰۰۰ درخواست در ماه.
  * [carto.com](https://carto.com/) — ساخت نقشه و APIهای ژئواسپشیال از داده‌های خودتان و داده‌های عمومی.
  * [Clockwork Micro](https://clockworkmicro.com/) — ابزارهای نقشه که همانند ساعت کار می‌کنند. پنجاه هزار کوئری رایگان ماهانه (کاشی نقشه، db2vector، ارتفاع).
  * [developers.arcgis.com](https://developers.arcgis.com) — APIها و SDKها برای نقشه، ذخیره‌سازی داده ژئواسپشیال، تحلیل، ژئوکدینگ، مسیر‌یابی و بیشتر، برای وب، دسکتاپ و موبایل. دو میلیون کاشی نقشه پایه رایگان، ۲۰٬۰۰۰ ژئوکد غیر ذخیره‌شده، ۲۰٬۰۰۰ مسیر ساده، ۵٬۰۰۰ محاسبه زمان رانندگی و ۵ گیگابایت ذخیره‌سازی رایگان داده+کاشی در ماه.
  * [Foursquare](https://developer.foursquare.com/) - کشف مکان، جستجوی مکان، و محتوای مبتنی بر زمینه با API Places و Pilgrim SDK.
  * [geoapify.com](https://www.geoapify.com/) - کاشی‌های نقشه وکتور و رستر، ژئوکدینگ، مکان‌ها، مسیر‌یابی، APIهای ایزولاین. سه هزار درخواست رایگان در روز.
  * [geocod.io](https://www.geocod.io/) — ژئوکدینگ از طریق API یا بارگذاری CSV. دو هزار و پانصد کوئری رایگان در روز.
  * [geocodify.com](https://geocodify.com/) — ژئوکدینگ و ژئوپارسینگ از طریق API یا بارگذاری CSV. ۱۰٬۰۰۰ کوئری رایگان در ماه.
  * [geojs.io](https://www.geojs.io/) - API جستجوی موقعیت IP بسیار قابل اطمینان با REST/JSON/JSONP.
  * [giscloud.com](https://www.giscloud.com/) — مصورسازی، تحلیل و به اشتراک‌گذاری داده جغرافیایی آنلاین.
  * [graphhopper.com](https://www.graphhopper.com/) پکیج توسعه‌دهنده رایگان برای مسیریابی، بهینه‌سازی مسیر، ماتریس فاصله، ژئوکدینگ و تطبیق نقشه.
  * [here](https://developer.here.com/) — APIها و SDKها برای نقشه و اپلیکیشن‌های موقعیت‌محور. ۲۵۰٬۰۰۰ تراکنش در ماه رایگان.
  * [locationiq.com](https://locationiq.com/) — API ژئوکدینگ، نقشه و مسیریابی. پنج هزار درخواست رایگان در روز.
  * [mapbox.com](https://www.mapbox.com/) — نقشه‌ها، سرویس‌های ژئواسپشیال و SDKها برای نمایش داده‌های نقشه.
  * [maptiler.com](https://www.maptiler.com/cloud/) — نقشه‌های وکتور، سرویس‌های نقشه و SDKها برای مصورسازی نقشه. کاشی وکتور رایگان با به‌روزرسانی هفتگی و چهار سبک نقشه.
  * [nominatim.org](https://nominatim.org/) — سرویس ژئوکدینگ رایگان OpenStreetMap با قابلیت جستجوی آدرس و ژئوکدینگ معکوس در سراسر جهان.
  * [nextbillion.ai](https://nextbillion.ai/) - خدمات مرتبط با نقشه: ژئوکدینگ، مسیر‌یابی (جهت‌یابی، مسیریابی، بهینه‌سازی مسیر، ماتریس فاصله)، SDK نقشه (وکتور، استاتیک، موبایل). [رایگان با سهمیه مشخص](https://nextbillion.ai/pricing) برای هر سرویس.
  * [opencagedata.com](https://opencagedata.com) — API ژئوکدینگ با جمع‌آوری داده از OpenStreetMap و سایر منابع آزاد. دو هزار و پانصد کوئری رایگان در روز.
  * [osmnames](https://osmnames.org/) — ژئوکدینگ با رتبه‌بندی نتایج جستجو بر اساس محبوبیت صفحه ویکی‌پدیا مرتبط.
  * [positionstack](https://positionstack.com/) - ژئوکدینگ رایگان برای مکان‌ها و مختصات جهانی. ۲۵٬۰۰۰ درخواست در ماه برای استفاده شخصی.
  * [stadiamaps.com](https://stadiamaps.com/) — کاشی‌های نقشه، مسیر‌یابی، ناوبری و سایر APIهای ژئواسپشیال. دو هزار و پانصد بازدید نقشه و درخواست API رایگان در روز برای استفاده غیرتجاری و تست.
  * [maps.stamen.com](http://maps.stamen.com/) - کاشی نقشه و میزبانی کاشی رایگان.
  * [ipstack](https://ipstack.com/) - شناسایی و مکان‌یابی بازدیدکنندگان وب‌سایت بر اساس آدرس IP
  * [Geokeo api](https://geokeo.com) - API ژئوکدینگ با تصحیح زبان و امکانات بیشتر. پوشش جهانی. ۲٬۵۰۰ کوئری رایگان روزانه

**[⬆️ بازگشت به بالا](#table-of-contents)**

## سیستم ساخت بسته

  * [build.opensuse.org](https://build.opensuse.org/) — سرویس ساخت بسته برای توزیع‌های مختلف (SUSE، EL، فدورا، دبیان و غیره).
  * [copr.fedorainfracloud.org](https://copr.fedorainfracloud.org) — سرویس ساخت RPM مبتنی بر Mock برای فدورا و EL.
  * [help.launchpad.net](https://help.launchpad.net/Packaging) — سرویس ساخت بسته برای اوبونتو و دبیان.

**[⬆️ بازگشت به بالا](#table-of-contents)**

## IDE و ویرایش کد

  * [3v4l](https://3v4l.org/) - شل PHP آنلاین و سایت اشتراک کد رایگان که کد شما را در بیش از ۳۰۰ نسخه PHP اجرا می‌کند
  * [Android Studio](https://developer.android.com/studio) — Android Studio سریع‌ترین ابزارها را برای ساخت برنامه‌های انواع دستگاه‌های اندرویدی فراهم می‌کند. IDE متن‌باز برای همه رایگان و بهترین گزینه برای توسعه اپ اندروید. قابل استفاده در ویندوز، مک، لینوکس و حتی ChromeOS!
  * [AndroidIDE](https://m.androidide.com/) — IDE متن‌باز برای توسعه اپلیکیشن‌های واقعی اندروید مبتنی بر Gradle روی دستگاه اندرویدی.
  * [Apache Netbeans](https://netbeans.apache.org/) — محیط توسعه، پلتفرم ابزار و فریم‌ورک اپلیکیشن.
  * [apiary.io](https://apiary.io/) — طراحی همکاری‌محور API با ماک فوری و مستندات تولیدی (رایگان برای بلوپرینت‌های API نامحدود و کاربران نامحدود با یک اکانت ادمین و مستندات میزبانی‌شده).
  * [BBEdit](https://www.barebones.com/) - ویرایشگر محبوب و قابل توسعه برای macOS. حالت رایگان [مجموعه‌ای از ویژگی‌های قدرتمند اصلی](https://www.barebones.com/products/bbedit/comparison.html) را ارائه می‌دهد و مسیر ارتقا به امکانات پیشرفته‌تر را فراهم می‌کند.
  * [Binder](https://mybinder.org/) - تبدیل یک مخزن گیت به مجموعه‌ای از نوت‌بوک‌های تعاملی. یک سرویس عمومی رایگان است.
  * [BlueJ](https://bluej.org) — محیط توسعه رایگان جاوا، طراحی‌شده برای مبتدیان و مورد استفاده میلیون‌ها نفر در سراسر جهان. توسط Oracle پشتیبانی می‌شود و رابط کاربری ساده برای کمک به تازه‌کارها دارد.
  * [Bootify.io](https://bootify.io/) - ژنراتور برنامه Spring Boot با پایگاه داده سفارشی و REST API.
  * [Brackets](http://brackets.io/) - ویرایشگر متن متن‌باز طراحی‌شده مخصوص توسعه وب. سبک، آسان برای استفاده و به‌شدت قابل سفارشی‌سازی.
  * [cacher.io](https://www.cacher.io) — سازماندهی کد اسنیپت‌ها با برچسب و پشتیبانی از بیش از ۱۰۰ زبان برنامه‌نویسی.
  * [Code::Blocks](https://codeblocks.org) — IDE رایگان Fortran و C/C++. متن‌باز و قابل اجرا روی ویندوز، مک و لینوکس.
  * [Cody](https://sourcegraph.com/cody) - دستیار کدنویسی رایگان مبتنی بر هوش مصنوعی که می‌تواند کد بنویسد (بلوک کد، تکمیل خودکار، تست واحد)، کد را بفهمد (دانش کامل کدبیس شما)، اصلاح کند و کد شما را پیدا کند. در VS Code، JetBrains و آنلاین موجود است.
  * [codiga.io](https://codiga.io/) — دستیار کدنویسی که امکان جستجو، تعریف و استفاده مجدد از اسنیپت‌های کد را مستقیماً در IDE شما فراهم می‌کند. رایگان برای افراد و سازمان‌های کوچک.
  * [codesnip.com.br](https://codesnip.com.br) — مدیریت ساده اسنیپت‌های کد با دسته‌بندی، جستجو و برچسب. رایگان و نامحدود.
  * [cocalc.com](https://cocalc.com/) — (قبلاً SageMathCloud با آدرس cloud.sagemath.com) — محاسبات مشارکتی در فضای ابری. دسترسی از طریق مرورگر به یک اوبونتو کامل با قابلیت همکاری و نرم‌افزارهای رایگان فراوان برای ریاضی، علم، داده‌کاوی؛ نصب‌شده: Python، LaTeX، Jupyter Notebooks، SageMath، scikitlearn و غیره.
  * [code.cs50.io](https://code.cs50.io/) - Visual Studio Code برای CS50، یک اپلیکیشن وب که GitHub Codespaces را برای دانش‌آموزان و معلمان تطبیق می‌دهد.
  * [codepen.io](https://codepen.io/) — CodePen یک زمین‌بازی برای بخش فرانت‌اند وب است.
  * [codesandbox.io](https://codesandbox.io/) — محیط آنلاین برای React، Vue، Angular، Preact و غیره.
  * [Components.studio](https://webcomponents.dev/) - کدنویسی کامپوننت‌ها به صورت ایزوله، نمایش آن‌ها در داستان‌ها، تست و انتشار در npm.
  * [Eclipse Che](https://www.eclipse.org/che/) - IDE مبتنی بر وب و بومی Kubernetes برای تیم‌های توسعه‌دهنده با پشتیبانی چند زبانه. متن‌باز و مبتنی بر جامعه. نمونه آنلاین توسط Red Hat در [workspaces.openshift.com](https://workspaces.openshift.com/) میزبانی می‌شود.
  * [fakejson.com](https://fakejson.com/) — FakeJSON به شما کمک می‌کند به سرعت داده جعلی از طریق API تولید کنید. کافی است درخواست API با توصیف نیاز خود بفرستید تا داده را به صورت JSON دریافت کنید. فرآیند تست ایده‌ها و سرعت ورود به بازار را تسهیل می‌کند.
  * [GetVM](https://getvm.io) — ماشین مجازی لینوکس و IDE رایگان فوری در سایدبار کروم. پلن رایگان شامل ۵ ماشین مجازی در روز است.
  * [GitPod](https://www.gitpod.io) — محیط‌های توسعه آماده کدنویسی فوری برای پروژه‌های GitHub. پلن رایگان شامل ۵۰ ساعت در ماه است.
  * [ide.goorm.io](https://ide.goorm.io) — goormIDE یک IDE کامل ابری است. پشتیبانی از چند زبان، کانتینر مبتنی بر لینوکس با ترمینال کامل مبتنی بر وب، انتقال پورت، URL سفارشی، همکاری و چت بلادرنگ، اشتراک‌گذاری لینک، پشتیبانی از Git/Subversion و بسیاری ویژگی دیگر (پلن رایگان شامل ۱ گیگ رم و ۱۰ گیگابایت حافظه به ازای هر کانتینر و ۵ اسلات کانتینر است).
  * [JDoodle](https://www.jdoodle.com) — کامپایلر و ویرایشگر آنلاین برای بیش از ۶۰ زبان برنامه‌نویسی با پلن رایگان برای کامپایل کد REST API تا ۲۰۰ اعتبار در روز.
  * [jetbrains.com](https://jetbrains.com/products.html) — ابزارهای بهره‌وری، IDEها و ابزارهای استقرار (مانند [IntelliJ IDEA](https://www.jetbrains.com/idea/)، [PyCharm](https://www.jetbrains.com/pycharm/) و غیره). لایسنس رایگان برای دانشجویان، معلمان، پروژه‌های متن‌باز و گروه‌های کاربری.
  * [jsbin.com](https://jsbin.com) — JS Bin یک محیط بازی و اشتراک‌گذاری کد فرانت‌اند وب (HTML، CSS و JavaScript) است. همچنین از Markdown، Jade و Sass پشتیبانی می‌کند.
  * [jsfiddle.net](https://jsfiddle.net/) — JS Fiddle یک محیط بازی و اشتراک‌گذاری کد فرانت‌اند وب است و از همکاری پشتیبانی می‌کند.
  * [JSONPlaceholder](https://jsonplaceholder.typicode.com/) — تعدادی نقطه انتهایی REST API که داده جعلی در قالب JSON برمی‌گردانند. سورس کد نیز برای اجرای محلی سرور در دسترس است.
  * [Lazarus](https://www.lazarus-ide.org/) — لازاروس یک IDE چندسکویی سازگار با Delphi برای توسعه سریع اپلیکیشن است.
  * [MarsCode](https://www.marscode.com/) - یک IDE ابری رایگان مبتنی بر هوش مصنوعی.
  * [micro-jaymock](https://micro-jaymock.now.sh/) - میکروسرویس کوچک برای ساخت داده‌های جعلی JSON به صورت API Mock.
  * [mockable.io](https://www.mockable.io/) — Mockable یک سرویس ساده و قابل پیکربندی برای ماک کردن سرویس‌های RESTful API یا SOAP است. به سرعت می‌توانید نقاط انتهایی REST API یا SOAP تعریف کرده و خروجی JSON یا XML بگیرید.
  * [mockaroo](https://mockaroo.com/) — Mockaroo به شما اجازه می‌دهد داده تست واقع‌گرایانه در قالب CSV، JSON، SQL و اکسل تولید کنید. همچنین می‌توانید برای API بک‌اند ماک بسازید.
  * [Mocklets](https://mocklets.com) - شبیه‌ساز API مبتنی بر HTTP برای توسعه موازی سریع‌تر و تست جامع‌تر، با پلن رایگان مادام‌العمر.
  * [Paiza](https://paiza.cloud/en/) — توسعه اپ‌های وب در مرورگر بدون نیاز به هیچ تنظیمی. پلن رایگان یک سرور با ۲۴ ساعت طول عمر و ۴ ساعت اجرای روزانه با ۲ هسته CPU، ۲ گیگ رم و ۱ گیگابایت حافظه ارائه می‌دهد.
  * [Prepros](https://prepros.io/) - Prepros می‌تواند Sass، Less، Stylus، Pug/Jade، Haml، Slim، CoffeeScript و TypeScript را کامپایل کند، مرورگرها را ری‌لود می‌کند و توسعه و تست سایت را آسان می‌سازد. همچنین می‌توانید ابزارهای خود را با چند کلیک اضافه کنید.
  * [Replit](https://replit.com/) — محیط برنامه‌نویسی ابری برای زبان‌های مختلف برنامه‌نویسی.
  * [SoloLearn](https://code.sololearn.com) — محیط برنامه‌نویسی ابری مناسب اجرای قطعات کد. از زبان‌های مختلف پشتیبانی می‌کند. برای اجرای کد نیازی به ثبت‌نام نیست اما برای ذخیره کد نیاز به ثبت‌نام دارید. همچنین دوره‌های رایگان برای مبتدیان و برنامه‌نویسان سطح متوسط ارائه می‌دهد.
  * [stackblitz.com](https://stackblitz.com/) — IDE کدنویسی آنلاین/ابری برای ساخت، ویرایش و استقرار اپلیکیشن‌های فول‌استک. پشتیبانی از همه فریم‌ورک‌های پرطرفدار NodeJs. برای ایجاد پروژه جدید [https://node.new](https://node.new) را امتحان کنید.
  * [Sublime Text](https://www.sublimetext.com/) - ادیتور متن محبوب، همه‌کاره و بسیار قابل تنظیم برای کدنویسی و ویرایش متن.
  * [Visual Studio Code](https://code.visualstudio.com/) - ویرایشگر کد بازتعریف‌شده و بهینه‌شده برای ساخت و اشکال‌زدایی اپلیکیشن‌های مدرن وب و ابری. توسعه یافته توسط مایکروسافت.
  * [Visual Studio Community](https://visualstudio.microsoft.com/vs/community/) — IDE کامل با هزاران افزونه، توسعه اپلیکیشن چندسکویی (افزونه‌های مایکروسافت برای دانلود iOS و اندروید)، توسعه دسکتاپ، وب و ابری، پشتیبانی از چند زبان (C#، C++، JavaScript، Python، PHP و غیره).
  * [VSCodium](https://vscodium.com/) - نسخه باینری آزاد و بدون تله‌متری/رهگیری و مبتنی بر جامعه از ویرایشگر VSCode مایکروسافت.
  * [wakatime.com](https://wakatime.com/) — متریک‌های خودکوانت‌شده درباره فعالیت کدنویسی شما با افزونه‌های ویرایشگر متن، پلن محدود رایگان.
  * [Wave Terminal](https://waveterm.dev/) - Wave یک ترمینال متن‌باز و چندسکویی برای گردش‌کار یکپارچه است. هر چیزی را به صورت خطی رندر کنید. نشست‌ها و تاریخچه را ذخیره کنید. مبتنی بر استانداردهای وب باز. برای MacOS و لینوکس.
  * [WebComponents.dev](https://webcomponents.dev/) — IDE درون مرورگر برای کدنویسی کامپوننت‌های وب به صورت ایزوله با ۵۸ قالب آماده، پشتیبانی از stories و تست‌ها.
  * [PHPSandbox](https://phpsandbox.io/) — محیط توسعه آنلاین برای PHP
  * [WebDB](https://webdb.app) - IDE دیتابیس رایگان و کارآمد. با قابلیت کشف سرور، ERD، تولید داده، هوش مصنوعی، مدیر ساختار NoSQL، ورژنینگ دیتابیس و امکانات بیشتر.
  * [Zed](https://zed.dev/) - ویرایشگر کد سریع، چندنفره، از سازندگان Atom و Tree-sitter.
  * [OneCompiler](https://onecompiler.com/) - کامپایلر آنلاین رایگان با پشتیبانی از بیش از ۷۰ زبان، از جمله جاوا، پایتون، C++، جاوااسکریپت.


**[⬆️ بازگشت به بالا](#table-of-contents)**

## تحلیل، رویداد و آمار

  * [Dwh.dev](https://dwh.dev) - راهکار مشاهده‌پذیری داده ابری (Snowflake). رایگان برای استفاده شخصی.
  * [Hightouch](https://hightouch.com/) - پلتفرم Reverse ETL برای همگام‌سازی داده‌های مشتری از انبار داده به CRM، ابزار بازاریابی و پشتیبانی. پلن رایگان اجازه همگام‌سازی یک مقصد را می‌دهد.
  * [Avo](https://avo.app/) — گردش‌کار انتشار تحلیل ساده‌شده. پلن ردیابی منسجم، کتابخانه ردیابی تحلیل type-safe، دیباگرهای درون‌برنامه‌ای و مشاهده‌پذیری داده برای کشف همه ایرادات پیش از انتشار. رایگان برای دو عضو workspace و ۱ ساعت نگاه به گذشته مشاهده‌پذیری داده.
  * [Branch](https://www.branch.io) — پلتفرم تحلیل موبایل. پلن رایگان تا ۱۰ هزار کاربر اپلیکیشن موبایل با deep-linking و سایر خدمات.
  * [Census](https://www.getcensus.com/) — پلتفرم Reverse ETL و تحلیل عملیاتی. همگام‌سازی ۱۰ فیلد از انبار داده به بیش از ۶۰ سرویس SaaS مانند Salesforce، Zendesk یا Amplitude.
  * [Clicky](https://clicky.com) — پلتفرم تحلیل وب‌سایت. پلن رایگان برای یک وب‌سایت با ۳۰۰۰ بازدید.
  * [Databox](https://databox.com) — بینش و تحلیل کسب‌وکار با ترکیب سایر پلتفرم‌های تحلیل و BI. پلن رایگان ۳ کاربر، داشبورد و منبع داده ارائه می‌دهد. ۱۱ میلیون رکورد داده تاریخی.
  * [Hitsteps.com](https://hitsteps.com/) — ۲,۰۰۰ بازدید صفحه در ماه برای ۱ وب‌سایت
  * [amplitude.com](https://amplitude.com/) — ۱ میلیون رویداد ماهانه، تا ۲ اپلیکیشن
  * [GoatCounter](https://www.goatcounter.com/) — پلتفرم تحلیل وب متن‌باز به‌صورت سرویس میزبانی‌شده (رایگان برای استفاده غیرتجاری) یا نرم‌افزار خودمیزبان. جایگزین ساده، معنادار و حریم‌محور برای Google Analytics یا Matomo. پلن رایگان برای استفاده غیرتجاری، سایت نامحدود، ۶ ماه نگهداری داده و ۱۰۰ هزار بازدید صفحه در ماه دارد.
  * [Google Analytics](https://analytics.google.com/) — گوگل آنالیتیکس
  * [MetricsWave](https://metricswave.com) — جایگزین حریم‌محور Google Analytics برای توسعه‌دهندگان. پلن رایگان تا ۲۰ هزار بازدید ماهانه بدون نیاز به کارت اعتباری.
  * [Expensify](https://www.expensify.com/) — گزارش هزینه، گردش‌کار تأیید گزارش شخصی رایگان
  * [getinsights.io](https://getinsights.io) - آنالیتیکس بدون کوکی و حریم‌محور، رایگان تا ۳ هزار رویداد در ماه.
  * [heap.io](https://heap.io) — به‌صورت خودکار همه اقدامات کاربر در اپ‌های iOS یا وب را ثبت می‌کند. رایگان تا ۱۰ هزار نشست ماهانه.
  * [Hotjar](https://hotjar.com) — تحلیل و گزارش وب‌سایت. پلن رایگان ۲۰۰۰ بازدید صفحه در روز، ۱۰۰ اسنپ‌شات در روز (حداکثر ۳۰۰)، ۳ heatmap قابل ذخیره برای ۳۶۵ روز، اعضای تیم نامحدود، ۳ نظرسنجی و ۳ ابزار بازخورد و جمع‌آوری ۲۰ پاسخ در ماه.
  * [Keen](https://keen.io/) — تحلیل سفارشی برای جمع‌آوری، تحلیل و مصورسازی داده. ۱,۰۰۰ رویداد در ماه رایگان
  * [Yandex.Datalens](https://datalens.yandex.com/) — سرویس تحلیل و مصورسازی داده یاندکس کلود. کاملاً رایگان و بدون محدودیت کاربر یا درخواست.
  * [Yandex.Metrica](https://metrica.yandex.com/) — تحلیل نامحدود رایگان
  * [Mixpanel](https://mixpanel.com/) — ۱۰۰,۰۰۰ کاربر ماهانه ردیابی شده، تاریخچه داده نامحدود و صندلی نامحدود، داده آمریکا یا اتحادیه اروپا
  * [Moesif](https://www.moesif.com) — تحلیل API برای REST و GraphQL. (رایگان تا ۵۰۰,۰۰۰ تماس API در ماه)
  * [optimizely.com](https://www.optimizely.com) — راهکار تست A/B، پلن شروع رایگان، یک وب‌سایت، ۱ اپ iOS و ۱ اپ اندروید
  * [Microsoft PowerBI](https://powerbi.com) — بینش و تحلیل کسب‌وکار توسط مایکروسافت. پلن رایگان با استفاده محدود و ۱ میلیون لایسنس کاربری.
  * [Row Zero](https://rowzero.io) - صفحه‌گسترده فوق سریع و متصل. اتصال مستقیم به دیتابیس‌ها، S3 و APIها. واردات، تحلیل، گراف و اشتراک‌گذاری میلیون‌ها سطر فوری. سه workbook رایگان (برای همیشه).
  * [sematext.com](https://sematext.com/cloud/) — رایگان تا ۵۰ هزار اکشن در ماه، ۱ روز نگهداری داده، داشبورد و کاربر نامحدود و غیره.
  * [Similar Web](https://similarweb.com) — تحلیل برای وب و اپ‌های موبایل. پلن رایگان پنج نتیجه به ازای هر معیار، یک ماه داده اپ موبایل و ۳ ماه داده وب‌سایت ارائه می‌دهد.
  * [StatCounter](https://statcounter.com/) — تحلیل بازدیدکنندگان وب‌سایت. پلن رایگان برای ۵۰۰ بازدیدکننده آخر.
  * [Statsig](https://statsig.com) - پلتفرم جامع برای تحلیل، feature flag و تست A/B. رایگان تا ۱ میلیون رویداد در ماه.
  * [Tableau Developer Program](https://www.tableau.com/developer) — نوآوری، ایجاد و سفارشی‌سازی Tableau برای سازمان شما. برنامه رایگان توسعه‌دهندگان، لایسنس sandbox شخصی برای Tableau Online ارائه می‌دهد (آخرین نسخه قبل از انتشار، مناسب برای تست ویژگی‌ها توسط توسعه‌دهندگان داده).
  * [usabilityhub.com](https://usabilityhub.com/) — تست طراحی و ماکاپ روی افراد واقعی و ردیابی بازدیدکنندگان. رایگان برای یک کاربر و تست نامحدود
  * [woopra.com](https://www.woopra.com/) — پلتفرم تحلیل کاربر رایگان برای ۵۰۰ هزار اکشن، ۹۰ روز نگهداری داده، بیش از ۳۰ ادغام یک‌کلیکی.
  * [counter.dev](https://counter.dev) — آنالیتیکس وب ساده و حریم‌محور. رایگان یا پرداخت به میزان دلخواه به صورت دونیشن.
  * [PostHog](https://posthog.com) - مجموعه کامل تحلیل محصول رایگان تا ۱ میلیون رویداد در ماه. همچنین نظرسنجی درون‌برنامه نامحدود با ۲۵۰ پاسخ در ماه ارائه می‌دهد.
  * [Uptrace](https://uptrace.dev) - ابزار ردیابی توزیع‌شده برای شناسایی خرابی‌ها و گلوگاه‌های عملکرد. پلن رایگان و اشتراک رایگان شخصی برای پروژه‌های متن‌باز و نسخه متن‌باز نیز دارد.
  * [Microsoft Clarity](https://clarity.microsoft.com/) - ابزار رایگان و آسان برای ثبت رفتار واقعی کاربران در سایت شما.
  * [Beampipe.io](https://beampipe.io) - Beampipe آنالیتیکس وب ساده و حریم‌محور. رایگان تا ۵ دامنه و ۱۰ هزار بازدید صفحه ماهانه.
  * [Aptabase](https://aptabase.com) — آنالیتیکس متن‌باز، حریم‌محور و ساده برای اپ‌های موبایل و دسکتاپ. SDK برای Swift، Kotlin، React Native، Flutter، Electron و غیره. رایگان تا ۲۰ هزار رویداد در ماه.
  * [Trackingplan](https://www.trackingplan.com/) - شناسایی خودکار مشکلات تحلیل دیجیتال، داده‌های بازاریابی و پیکسل‌ها، نگهداری پلن‌های ردیابی به‌روز و همکاری آسان. قابلیت استقرار در محیط تولید یا افزودن پوشش تحلیلی به تست‌های رگرسیون بدون نیاز به کدنویسی.
  * [LogSpot](https://logspot.io) - پلتفرم کامل و یکپارچه تحلیل وب و محصول، شامل ویجت‌های تعبیه‌شونده و ربات‌های خودکار (Slack، تلگرام و webhook). پلن رایگان شامل ۱۰ هزار رویداد در ماه است.
  * [Umami](https://umami.is/) - جایگزین ساده، سریع و حریم‌محور (متن‌باز) برای Google Analytics.
  * [TrackWith Dicloud](https://dicloud.net/trackwith-privacy-focused-analytics/) - جایگزین سبک و حریم‌محور Google Analytics. بازدید نامحدود، بازدیدکننده نامحدود، heatmap و goal tracking نامحدود. رایگان تا ۳ دامنه و ۶۰۰ بازپخش نشست به ازای هر دامنه.
  * [AppFit](https://appfit.io) - ابزار جامع تحلیل و مدیریت محصول برای مدیریت تحلیلی و به‌روزرسانی محصولات به صورت چندسکویی. پلن رایگان شامل ۱۰ هزار رویداد در ماه، ژورنال محصول و بینش هفتگی.
  * [Seline](https://seline.so) - آنالیتیکس ساده و خصوصی وب‌سایت و محصول، بدون کوکی، سبک و مستقل. پلن رایگان شامل ۳,۰۰۰ رویداد در ماه و دسترسی به همه ویژگی‌ها مثل داشبورد، سفر کاربر، قیف و غیره.
  * [Peasy](https://peasy.so) - ابزار آنالیتیکس سبک و حریم‌محور برای وب‌سایت و محصول. پلن رایگان شامل ۳,۰۰۰ رویداد در ماه است.
  * [Rybbit](https://rybbit.io) - جایگزین متن‌باز و بدون کوکی برای Google Analytics که ۱۰ برابر شهودی‌تر است. پلن رایگان ۳,۰۰۰ رویداد ماهانه دارد.

**[⬆️ بازگشت به بالا](#table-of-contents)**

## ضبط نشست بازدیدکننده

  * [Reactflow.com](https://www.reactflow.com/) — به ازای هر سایت: ۱,۰۰۰ بازدید صفحه در روز، سه heatmap، سه ویجت، ردیابی باگ رایگان
  * [OpenReplay.com](https://www.openreplay.com) - ضبط نشست متن‌باز با ابزارهای توسعه برای بازتولید باگ، نشست زنده برای پشتیبانی بلادرنگ و مجموعه تحلیل محصول. هزار نشست در ماه با دسترسی به همه ویژگی‌ها و نگهداری ۷ روزه.
  * [LogRocket.com](https://www.logrocket.com) - هزار نشست در ماه با ۳۰ روز نگهداری، ردیابی خطا و حالت زنده
  * [FullStory.com](https://www.fullstory.com) — هزار نشست در ماه با یک ماه نگهداری داده و سه کاربر. اطلاعات بیشتر [اینجا](https://help.fullstory.com/hc/en-us/articles/360020623354-FullStory-Free-Edition).
  * [hotjar.com](https://www.hotjar.com/) — به ازای هر سایت: ۱,۰۵۰ بازدید صفحه در ماه، heatmap نامحدود، داده به مدت سه ماه ذخیره می‌شود
  * [inspectlet.com](https://www.inspectlet.com/) — ۲,۵۰۰ نشست در ماه برای یک وب‌سایت رایگان
  * [Microsoft Clarity](https://clarity.microsoft.com/) - ضبط نشست کاملاً رایگان با «بدون محدودیت ترافیک»، بدون محدودیت پروژه و بدون نمونه‌گیری
  * [mouseflow.com](https://mouseflow.com/) — ۵۰۰ نشست در ماه برای یک وب‌سایت رایگان
  * [mousestats.com](https://www.mousestats.com/) — ۱۰۰ نشست در ماه برای یک وب‌سایت رایگان
  * [smartlook.com](https://www.smartlook.com/) — بسته رایگان برای وب و اپ موبایل (۱,۵۰۰ نشست در ماه)، سه heatmap، یک قیف، ۱ ماه تاریخچه داده
  * [howuku.com](https://howuku.com) — ردیابی تعامل کاربر، درگیری و رویداد. رایگان تا ۵,۰۰۰ بازدید در ماه
  * [UXtweak.com](https://www.uxtweak.com/) — ضبط و مشاهده نحوه استفاده کاربران از وب‌سایت یا اپلیکیشن. رایگان با زمان نامحدود برای پروژه‌های کوچک

**[⬆️ بازگشت به بالا](#table-of-contents)**
## API و SDK تأیید شماره موبایل بین‌المللی

  * [numverify](https://numverify.com/) — API اعتبارسنجی و جستجوی شماره تلفن جهانی با فرمت JSON. 100 درخواست API در ماه
  * [veriphone](https://veriphone.io/) — تأیید شماره تلفن جهانی در یک API JSON رایگان، سریع و قابل اعتماد. 1000 درخواست در ماه

**[⬆️ بازگشت به بالا](#table-of-contents)**

## یکپارچه‌سازی پرداخت و صورتحساب

  * [Qonversion](http://qonversion.io/) - پلتفرم مدیریت اشتراک چندسکویی همه‌کاره که آنالیتیکس، تست A/B، تبلیغات جست‌وجوی اپل، پیکربندی از راه دور و ابزارهای رشد برای بهینه‌سازی خرید درون‌برنامه‌ای و کسب درآمد را ارائه می‌دهد. سازگار با iOS، اندروید، React Native، Flutter، Unity، Cordova، Stripe و وب. رایگان تا سقف ۱۰ هزار دلار درآمد ماهانه رهگیری‌شده.
  * [ParityVend](https://www.ambeteco.com/ParityVend/) – تنظیم خودکار قیمت براساس موقعیت جغرافیایی بازدیدکننده برای گسترش کسب‌وکار جهانی و ورود به بازارهای جدید (برابری قدرت خرید). پلن رایگان شامل ۷۵۰۰ درخواست API در ماه است.
  * [Glassfy](https://glassfy.io/) – زیرساخت اشتراک درون‌برنامه‌ای، رویدادهای اشتراک بلادرنگ و ابزارهای کسب درآمد آماده برای iOS، اندروید، Stripe و Paddle. رایگان تا سقف ۱۰ هزار دلار درآمد ماهانه.
  * [Adapty.io](https://adapty.io/) – راهکار جامع با SDK متن‌باز برای یکپارچه‌سازی اشتراک درون‌برنامه‌ای موبایل برای iOS، اندروید، React Native، Flutter، Unity یا وب اپ. رایگان تا سقف ۱۰ هزار دلار درآمد ماهانه.
  * [CoinMarketCap](https://coinmarketcap.com/api/) — ارائه داده بازار رمزارزها شامل جدیدترین نرخ‌های تبدیل رمزارز و ارز فیات. پلن رایگان ۱۰ هزار اعتبار تماس API در ماه دارد.
  * [CurrencyFreaks](https://currencyfreaks.com/) — ارائه نرخ‌های تبدیل ارز جاری و تاریخی. پلن رایگان DEVELOPER با ۱۰۰۰ درخواست در ماه در دسترس است.
  * [CoinGecko](https://www.coingecko.com/en/api) — ارائه داده بازار رمزارزها شامل جدیدترین نرخ‌های تبدیل رمزارز و داده‌های تاریخی. API دمو با نرخ پایدار ۳۰ تماس در دقیقه و سقف ماهانه ۱۰,۰۰۰ تماس ارائه می‌شود.
  * [CurrencyApi](https://currencyapi.net/) — نرخ‌های زنده ارز برای ارزهای فیزیکی و رمزارزها، تحویل در قالب JSON و XML. پلن رایگان ۱,۲۵۰ درخواست API در ماه.
  * [currencylayer](https://currencylayer.com/) — نرخ‌های تبدیل قابل اعتماد برای کسب‌وکار شما، ۱۰۰ درخواست API در ماه رایگان.
  * [exchangerate-api.com](https://www.exchangerate-api.com) - API ساده تبدیل ارز با فرمت JSON. پلن رایگان یک بار در روز به‌روزرسانی می‌شود و سقف ۱۵۰۰ درخواست در ماه دارد.
  * [FraudLabsPRO](https://www.fraudlabspro.com) — کمک به بازرگانان برای جلوگیری از تقلب پرداخت و بازپرداخت‌ها. پلن Micro رایگان با ۵۰۰ پرس‌وجو در ماه.
  * [FxRatesAPI](https://fxratesapi.com) — ارائه نرخ‌های تبدیل ارز بلادرنگ و تاریخی. پلن رایگان نیازمند ذکر منبع است.
  * [Moesif API Monetization](https://www.moesif.com/) - کسب درآمد از APIها از طریق صورتحساب مبتنی بر مصرف. اتصال به Stripe، Chargebee و غیره. پلن رایگان ۳۰,۰۰۰ رویداد در ماه ارائه می‌دهد.
  * [Nami ML](https://www.namiml.com/) - پلتفرم کامل برای خرید درون‌برنامه‌ای و اشتراک در iOS و اندروید، شامل پرداخت‌وال بدون کدنویسی، CRM و آنالیتیکس. همه ویژگی‌های پایه رایگان برای راه‌اندازی کسب‌وکار IAP.
  * [RevenueCat](https://www.revenuecat.com/) — بک‌اند میزبانی‌شده برای خریدها و اشتراک‌های درون‌برنامه‌ای (iOS و اندروید). رایگان تا سقف ۲,۵۰۰ دلار درآمد رهگیری‌شده در ماه.
  * [vatlayer](https://vatlayer.com/) — API آنی اعتبارسنجی شماره VAT و نرخ‌های مالیات بر ارزش افزوده اتحادیه اروپا، ۱۰۰ درخواست API در ماه رایگان
  * [Currencyapi](https://currencyapi.com) — API رایگان تبدیل ارز و داده نرخ تبدیل. رایگان ۳۰۰ درخواست در ماه، ۱۰ درخواست در دقیقه برای استفاده خصوصی.

**[⬆️ بازگشت به بالا](#table-of-contents)**

## ابزارهای مرتبط با Docker

  * [canister.io](https://canister.io/) — ۲۰ مخزن خصوصی رایگان برای توسعه‌دهندگان، ۳۰ مخزن خصوصی رایگان برای تیم‌ها جهت ساخت و ذخیره تصاویر Docker
  * [Container Registry Service](https://container-registry.com/) - راهکار مدیریت کانتینر مبتنی بر Harbor. پلن رایگان ۱ گیگابایت فضای ذخیره‌سازی برای مخازن خصوصی ارائه می‌دهد.
  * [Docker Hub](https://hub.docker.com) — یک مخزن خصوصی رایگان و مخازن عمومی نامحدود برای ساخت و ذخیره تصاویر Docker
  * [Play with Docker](https://labs.play-with-docker.com/) — محیطی ساده، تعاملی و سرگرم‌کننده برای یادگیری Docker.
  * [quay.io](https://quay.io/) — ساخت و ذخیره تصاویر کانتینر با مخازن عمومی رایگان نامحدود
  * [ttl.sh](https://ttl.sh/) - رجیستری ناشناس و موقتی تصاویر Docker

**[⬆️ بازگشت به بالا](#table-of-contents)**

## ابزارهای مرتبط با Vagrant

  * [Vagrant Cloud](https://app.vagrantup.com) - Vagrant Cloud شرکت HashiCorp. میزبانی باکس Vagrant.
  * [Vagrantbox.es](https://www.vagrantbox.es/) — فهرست جایگزین عمومی باکس‌ها

**[⬆️ بازگشت به بالا](#table-of-contents)**

## سایت‌های وبلاگ‌نویسی توسعه‌دهندگان

  * [BearBlog](https://bearblog.dev/) - وبلاگ و سایت‌ساز مینیمال مبتنی بر Markdown.
  * [Dev.to](https://dev.to/) - جایی که برنامه‌نویسان ایده‌های خود را به اشتراک می‌گذارند و به رشد یکدیگر کمک می‌کنند.
  * [Hashnode](https://hashnode.com/) — نرم‌افزار وبلاگ‌نویسی بی‌دردسر برای توسعه‌دهندگان!
  * [Medium](https://medium.com/) — با موضوعات مهم برای خودتان عمیق‌تر و اندیشمندانه‌تر برخورد کنید.
  * [AyeDot](https://ayedot.com/) — ایده‌ها، دانش و داستان‌های خود را به‌صورت رایگان با دنیا در قالب مینی‌بلاگ‌های مدرن چندرسانه‌ای کوتاه به اشتراک بگذارید.

**[⬆️ بازگشت به بالا](#table-of-contents)**

## پلتفرم‌های نظردهی
  * [GraphComment](https://graphcomment.com/) - GraphComment یک پلتفرم نظردهی است که به شما کمک می‌کند از مخاطبان سایت خود یک جامعه فعال بسازید.
  * [Utterances](https://utteranc.es/) - ویجت نظردهی سبک مبتنی بر Issues گیت‌هاب. استفاده از Issues گیت‌هاب برای نظرات وبلاگ، صفحات ویکی و غیره!
  * [Disqus](https://disqus.com/) - Disqus یک پلتفرم جامعه شبکه‌ای است که توسط صدها هزار سایت در سراسر وب استفاده می‌شود.
  * [Remarkbox](https://www.remarkbox.com/) - پلتفرم نظردهی میزبانی‌شده متن‌باز، پرداخت به اندازه توان شما برای "یک مدیر در چند دامنه با کنترل کامل روی رفتار و ظاهر"
  * [IntenseDebate](https://intensedebate.com/) - سیستم نظردهی با امکانات فراوان برای WordPress، Tumblr، Blogger و بسیاری دیگر از پلتفرم‌های سایت.

**[⬆️ بازگشت به بالا](#table-of-contents)**

## APIهای اسکرین‌شات

  * [ApiFlash](https://apiflash.com) — API اسکرین‌شات مبتنی بر AWS Lambda و Chrome. پشتیبانی از اسکرین‌شات تمام‌صفحه، زمان‌بندی و ابعاد نمای صفحه.
  * [microlink.io](https://microlink.io/) – هر وب‌سایتی را به داده تبدیل می‌کند مانند نرمال‌سازی متاتگ‌ها، پیش‌نمایش زیبا، قابلیت اسکرپینگ یا اسکرین‌شات به‌عنوان سرویس. ۲۵۰ درخواست در روز رایگان.
  * [ScreenshotAPI.net](https://screenshotapi.net/) - API اسکرین‌شات با تماس API ساده برای تولید اسکرین‌شات از هر وب‌سایت. مقیاس‌پذیر و میزبانی‌شده بر روی Google Cloud. ۱۰۰ اسکرین‌شات رایگان در ماه ارائه می‌دهد.
  * [screenshotlayer.com](https://screenshotlayer.com/) — ثبت اسنپ‌شات‌های بسیار قابل تنظیم از هر وب‌سایت. ۱۰۰ اسنپ‌شات رایگان در ماه
  * [screenshotmachine.com](https://www.screenshotmachine.com/) — ثبت ۱۰۰ اسنپ‌شات در ماه، فرمت‌های png، gif و jpg، شامل ثبت کامل صفحات، نه فقط صفحه اصلی
  * [PhantomJsCloud](https://PhantomJsCloud.com) — اتوماسیون مرورگر و رندر صفحه. پلن رایگان تا ۵۰۰ صفحه در روز. رایگان از سال ۲۰۱۷.
  * [Webshrinker.com](https://webshrinker.com) — Web Shrinker سرویس API اسکرین‌شات و هوش دامنه ارائه می‌دهد. ۱۰۰ درخواست رایگان در ماه.
  * [Screenshots](https://screenshotson.click) — API شما برای اسکرین‌شات. با گزینه‌های بسیار قابل تنظیم برای ثبت تصویر. ۱۰۰ اسکرین‌شات رایگان در ماه.

**[⬆️ بازگشت به بالا](#table-of-contents)**

## ابزارهای مرتبط با Flutter و ساخت اپ‌های iOS بدون مک

  * [FlutLab](https://flutlab.io/) - FlutLab محیط توسعه آنلاین مدرن Flutter و بهترین مکان برای ایجاد، دیباگ و ساخت پروژه‌های کراس‌پلتفرم است. ساخت اپ‌های iOS (بدون نیاز به مک) و اندروید با Flutter.
  * [CodeMagic](https://codemagic.io/) - CodeMagic یک CI/CD کاملاً میزبانی‌شده و مدیریت‌شده برای اپ‌های موبایل است. می‌توانید با ابزار CI/CD مبتنی بر رابط کاربری گرافیکی، بیلد، تست و استقرار انجام دهید. پلن رایگان ۵۰۰ دقیقه رایگان در ماه و یک ماشین Mac Mini با پردازنده ۲.۳ گیگاهرتز و ۸ گیگابایت رم ارائه می‌دهد.
  * [FlutterFlow](https://flutterflow.io/) - FlutterFlow یک رابط کشیدن و رها کردن مبتنی بر مرورگر برای ساخت اپ موبایل با Flutter است.

**[⬆️ بازگشت به بالا](#table-of-contents)**

## شبیه‌سازی سخت‌افزاری مبتنی بر مرورگر با جاوااسکریپت

  * [JsLinux](https://bellard.org/jslinux) — ماشین مجازی x86 بسیار سریع که قادر به اجرای Linux و Windows 2k است.
  * [Jor1k](https://s-macke.github.io/jor1k/demos/main.html) — ماشین مجازی OpenRISC که قادر به اجرای لینوکس با پشتیبانی شبکه است.
  * [v86](https://copy.sh/v86) — ماشین مجازی x86 که قادر به اجرای Linux و سایر سیستم‌عامل‌ها مستقیماً در مرورگر است.

**[⬆️ بازگشت به بالا](#table-of-contents)**

## مدیریت حریم خصوصی
  * [Bearer](https://www.bearer.sh/) - کمک به پیاده‌سازی حفظ حریم خصوصی از طریق طراحی با ممیزی‌ها و گردش‌کارهای پیوسته تا سازمان‌ها مطابق با GDPR و سایر مقررات باشند. پلن رایگان محدود به تیم‌های کوچک‌تر و فقط نسخه SaaS است.
  * [Osano](https://www.osano.com/) - پلتفرم مدیریت رضایت و تطابق با همه چیز از نمایندگی GDPR تا بنرهای کوکی. پلن رایگان ویژگی‌های پایه را ارائه می‌دهد.
  * [Iubenda](https://www.iubenda.com/) - سیاست‌های حریم خصوصی و کوکی و مدیریت رضایت. پلن رایگان سیاست حریم خصوصی و کوکی محدود و همچنین بنر کوکی ارائه می‌دهد.
  * [Cookiefirst](https://cookiefirst.com/) - راهکار بنر کوکی، ممیزی و مدیریت رضایت چندزبانه. پلن رایگان شامل یک اسکن یک‌باره و یک بنر است.
  * [Ketch](https://www.ketch.com/) - ابزار مدیریت رضایت و چارچوب حفظ حریم خصوصی. پلن رایگان اکثر قابلیت‌ها را با تعداد بازدیدکننده محدود ارائه می‌دهد.
  * [Concord](https://www.concord.tech/) - پلتفرم کامل حفظ حریم خصوصی داده، شامل مدیریت رضایت، رسیدگی به درخواست‌های حریم خصوصی (DSARs) و نقشه‌برداری داده. پلن رایگان شامل ویژگی‌های اصلی مدیریت رضایت است و همچنین یک پلن پیشرفته‌تر را به پروژه‌های متن‌باز تأییدشده به صورت رایگان ارائه می‌دهند.

**[⬆️ بازگشت به بالا](#table-of-contents)**

## متفرقه

  * [BackgroundStyler.com](https://backgroundstyler.com) - ساخت اسکرین‌شات‌های زیبا از کد، متن یا تصاویر برای به اشتراک‌گذاری در شبکه‌های اجتماعی.
  * [BinShare.net](https://binshare.net) - ساخت و اشتراک‌گذاری کد یا فایل‌های باینری. قابلیت اشتراک به صورت تصویر زیبا (مثلاً برای پست توییتر/فیسبوک) یا به صورت لینک (برای چت یا انجمن‌ها).
  * [Blynk](https://blynk.io) — یک سرویس SaaS با API جهت کنترل، ساخت و ارزیابی دستگاه‌های IoT. پلن توسعه‌دهنده رایگان با ۵ دستگاه، فضای ذخیره‌سازی ابری رایگان و اپلیکیشن موبایل.
  * [Bricks Note Calculator](https://free.getbricks.app/) - اپ یادداشت‌برداری (PWA) با ماشین حساب قدرتمند و چندخطی داخلی.
  * [Carbon.now.sh](https://carbon.now.sh) - ساخت و اشتراک‌گذاری کد اسنیپت‌ها به صورت تصویر اسکرین‌شات زیبا. معمولاً برای به اشتراک‌گذاری/نمایش زیبای کدها در توییتر یا پست‌های وبلاگ استفاده می‌شود.
  * [Code Time](https://www.software.com/code-time) - افزونه‌ای برای پیگیری زمان و آمار برنامه‌نویسی در VS Code، Atom، IntelliJ، Sublime Text و غیره.
  * [Codepng](https://www.codepng.app) - ساخت اسکرین‌شات‌های عالی از کد منبع برای اشتراک‌گذاری در شبکه‌های اجتماعی.
  * [CodeToImage](https://codetoimage.com/) - ساخت اسکرین‌شات از کد یا متن برای اشتراک‌گذاری در شبکه‌های اجتماعی.
  * [Cronhooks](https://cronhooks.io/) - زمان‌بندی اجرای وب‌هوک‌های یک‌باره یا تکراری. پلن رایگان اجازه ۵ زمان‌بندی آگهانی را می‌دهد.
  * [cron-job.org](https://cron-job.org) - سرویس آنلاین کرون‌جاب. تعداد نامحدود جاب‌ها رایگان است.
  * [datelist.io](https://datelist.io) - سیستم رزرو آنلاین/برنامه‌ریزی قرار ملاقات. رایگان تا ۵ رزرو در ماه، شامل ۱ تقویم.
  * [Domain Forward](https://domain-forward.com/) - ابزاری ساده برای انتقال هر آدرس یا دامنه. رایگان تا ۵ دامنه و ۲۰۰ هزار درخواست در ماه.
  * [Elementor](https://elementor.com) — سازنده سایت وردپرس. پلن رایگان با بیش از ۴۰ ابزارک پایه.
  * [Exif Editor](https://exifeditor.io/) — مشاهده، ویرایش، پاکسازی و تحلیل متادیتای عکس/تصویر در مرورگر ـ شامل موقعیت GPS و متادیتا.
  * [Format Express](https://www.format-express.dev) - فرمت آنلاین فوری برای JSON / XML / SQL.
  * [FOSSA](https://fossa.com/) - مدیریت مقیاس‌پذیر انتها به انتها برای کد شخص ثالث، تطابق مجوز و آسیب‌پذیری‌ها.
  * [Hook Relay](https://www.hookrelay.dev/) - افزودن پشتیبانی وب‌هوک به اپ شما بدون دردسر: صف‌بندی، تلاش مجدد با تاخیر، و لاگ‌گیری آماده. پلن رایگان دارای ۱۰۰ تحویل در روز، نگهداری ۱۴ روزه و ۳ نقطه انتهایی هوک است.
  * [Hosting Checker](https://hostingchecker.co) - بررسی اطلاعات میزبانی مانند ASN، ISP، موقعیت و غیره برای هر دامنه، وبسایت یا IP. همچنین شامل ابزارهای متعدد مرتبط با میزبانی و DNS.
  * [http2.pro](https://http2.pro) — تست آمادگی پروتکل HTTP/2 و API شناسایی پشتیبانی کلاینت از HTTP/2.
  * [kandi](https://kandi.openweaver.com/) — شروع سریع توسعه اپلیکیشن: ساخت توابع سفارشی، سناریوها و اپلیکیشن‌های کامل سریع‌تر با استفاده از اسنیپت‌های کد و بازاستفاده از کتابخانه‌های متن‌باز.
  * [Base64 decoder/encoder](https://devpal.co/base64-decode/) — ابزار آنلاین رایگان برای رمزگشایی و رمزگذاری داده‌ها.
  * [newreleases.io](https://newreleases.io) - دریافت اعلان‌های ایمیلی، Slack، تلگرام، Discord و وب‌هوک برای نسخه‌های جدید از GitHub، GitLab، Bitbucket، Python PyPI، Java Maven، Node.js NPM، Node.js Yarn، Ruby Gems، PHP Packagist، .NET NuGet، Rust Cargo و Docker Hub.
  * [OnlineExifViewer](https://onlineexifviewer.com/) — مشاهده فوری داده‌های EXIF آنلاین برای عکس شامل موقعیت GPS و متادیتا.
  * [PDFMonkey](https://www.pdfmonkey.io/) — مدیریت قالب PDF در داشبورد، فراخوانی API با داده پویا و دانلود PDF. ماهانه تا ۳۰۰ سند رایگان ارائه می‌دهد.
  * [Pika Code Screenshots](https://pika.style/templates/code-image) — ساخت اسکرین‌شات‌های زیبا و سفارشی از کد و VSCode با استفاده از افزونه.
  * [QuickType.io](https://quicktype.io/) - تولید خودکار مدل/کلاس/نوع/اینترفیس و سریالایزر از JSON، اسکیما و GraphQL برای کار سریع و ایمن با داده‌ها در هر زبان برنامه‌نویسی. تبدیل JSON به کد تایپ‌سیف و زیبا در هر زبان.
  * [RandomKeygen](https://randomkeygen.com/) - ابزار رایگان و سازگار با موبایل برای تولید انواع کلیدها و رمزعبورهای تصادفی جهت ایمن‌سازی هر اپلیکیشن، سرویس یا دستگاه.
  * [ray.so](https://ray.so/) - ساخت تصاویر زیبا از اسنیپت‌های کد.
  * [readme.com](https://readme.com/) — ساخت آسان مستندات زیبا، رایگان برای متن‌باز.
  * [redirection.io](https://redirection.io/) — ابزار SaaS برای مدیریت ریدایرکت‌های HTTP برای کسب‌وکار، بازاریابی و سئو.
  * [redirect.ing](https://redirect.ing/) - انتقال سریع و امن دامنه بدون نیاز به مدیریت سرور یا گواهی SSL. پلن رایگان شامل ۱۰ دامنه و ۱۰۰,۰۰۰ درخواست در ماه.
  * [redirect.pizza](https://redirect.pizza/) - مدیریت آسان ریدایرکت‌ها با پشتیبانی HTTPS. پلن رایگان شامل ۱۰ منبع و ۱۰۰,۰۰۰ بازدید در ماه.
  * [ReqBin](https://reqbin.com/) — ارسال درخواست HTTP آنلاین. متدهای پرکاربرد شامل GET، POST، PUT، DELETE و HEAD. پشتیبانی از Header و احراز هویت توکن. دارای سیستم ورود پایه برای ذخیره درخواست‌ها.
  * [Smartcar API](https://smartcar.com) - API خودرو جهت موقعیت‌یابی، دریافت سطح باک سوخت، باتری، کیلومترشمار، قفل/باز کردن درب‌ها و غیره.
  * [snappify](https://snappify.com) - امکان ساخت ویژوال‌های چشمگیر برای توسعه‌دهندگان. از اسنیپت کدهای زیبا تا ارائه‌های فنی کامل. پلن رایگان تا ۳ اسنپ همزمان با دانلود نامحدود و ۵ توضیح کد با هوش مصنوعی در ماه.
  * [Sunrise and Sunset](https://sunrisesunset.io/api/) - دریافت زمان طلوع و غروب خورشید برای طول و عرض جغرافیایی مشخص.
  * [superfeedr.com](https://superfeedr.com/) — فیدهای لحظه‌ای مطابق PubSubHubbub، خروجی، آنالیز. رایگان با امکانات شخصی‌سازی کمتر
  * [SurveyMonkey.com](https://www.surveymonkey.com) — ساخت نظرسنجی آنلاین و تحلیل نتایج. پلن رایگان فقط تا ۱۰ سوال و ۱۰۰ پاسخ به ازای هر نظرسنجی را اجازه می‌دهد.
  * [Tiledesk](https://tiledesk.com) - ساخت چت‌بات و اپ‌های مکالمه‌محور. همه‌کاناله: از سایت (ویجت چت زنده) تا واتس‌اپ. پلن رایگان با چت‌بات نامحدود.
  * [Versionfeeds](https://versionfeeds.com) — فیدهای RSS سفارشی برای انتشار نسخه‌های نرم‌افزارهای محبوب شما. جدیدترین نسخه‌ها را در یک فید داشته باشید. (۳ فید اول رایگان است)
  * [videoinu](https://videoinu.com) — ساخت و ویرایش ضبط‌های صفحه نمایش و ویدیوهای دیگر به صورت آنلاین.
  * [Webacus](https://webacus.dev) — دسترسی به طیف وسیعی از ابزارهای رایگان برای توسعه‌دهندگان جهت رمزگذاری، رمزگشایی و دستکاری داده.

**[⬆️ بازگشت به بالا](#table-of-contents)**

## ابزارهای دسکتاپ از راه دور

  * [Getscreen.me](https://getscreen.me) — رایگان برای ۲ دستگاه، بدون محدودیت در تعداد و مدت جلسات
  * [Apache Guacamole™](https://guacamole.apache.org/) — دروازه دسکتاپ از راه دور بدون کلاینت و متن‌باز
  * [RemSupp](https://remsupp.com) — پشتیبانی در لحظه و دسترسی دائمی به دستگاه‌ها (۲ جلسه در روز رایگان)
  * [RustDesk](https://rustdesk.com/) - زیرساخت دسکتاپ مجازی/از راه دور متن‌باز برای همه!
  * [AnyDesk](https://anydesk.com) — رایگان برای ۳ دستگاه، بدون محدودیت در تعداد و مدت جلسات

**[⬆️ بازگشت به بالا](#table-of-contents)**

## توسعه بازی

  * [itch.io](https://itch.io/game-assets) — دارایی‌های رایگان/پولی مانند اسپریت، مجموعه کاشی و پکیج شخصیت.
  * [Gamefresco.com](https://gamefresco.com/) — کشف، جمع‌آوری و اشتراک‌گذاری دارایی‌های رایگان بازی از هنرمندان سراسر جهان.
  * [GameDevMarket](https://gamedevmarket.net) — دارایی‌های رایگان/پولی مثل ۲بعدی، ۳بعدی، صدا، رابط کاربری.
  * [OpenGameArt](https://opengameart.org) — دارایی‌های بازی متن‌باز مانند موسیقی، صدا، اسپریت و گیف.
  * [CraftPix](https://craftpix.net) — دارایی‌های رایگان/پولی مثل ۲بعدی، ۳بعدی، صدا، رابط کاربری، پس‌زمینه، آیکون، مجموعه کاشی، کیت بازی.
  * [Game Icons](https://game-icons.net/) - آیکون‌های SVG/PNG قابل استایل‌دهی رایگان با مجوز CC-BY.
  * [LoSpec](https://lospec.com/) — ابزار آنلاین برای ساخت پیکسل آرت و هنر دیجیتال محدودشده، آموزش‌ها و لیست پالت زیاد مناسب بازی‌ها.
  * [ArtStation](https://www.artstation.com/) - مارکت‌پلیس دارایی‌های ۲بعدی، ۳بعدی، صدا، آیکون، مجموعه کاشی، کیت بازی رایگان/پولی. همچنین برای نمایش نمونه‌کار هنری شما.
  * [Rive](https://rive.app/community/) - دارایی‌های جامعه و همچنین ساخت دارایی بازی خودتان با پلن رایگان.
  * [Poly Pizza](https://poly.pizza/) - دارایی سه‌بعدی Low Poly رایگان
  * [3Dassets.one](https://3dassets.one/) - بیش از ۸۰۰۰ مدل سه‌بعدی رایگان/پولی و متریال PBR برای ساخت تکسچر.
  * [Kenney](https://www.kenney.nl/assets/) - دارایی‌های ۲بعدی، ۳بعدی، صدا و رابط کاربری رایگان با مجوز CC0 1.0 Universal.
  * [Poliigon](https://www.poliigon.com/) - تکسچر، مدل، HDRI و براش رایگان و پولی (با رزولوشن متغیر). افزونه رایگان برای خروجی به نرم‌افزارهایی مانند Blender.
  * [Freesound](https://freesound.org/) - کتابخانه صداهای مشارکتی رایگان با مجوزهای مختلف CC.

**[⬆️ بازگشت به بالا](#table-of-contents)**

## سایر منابع رایگان

  * [Wikimint Developer](https://developer.wikimint.com/p/tools.html) - ابزارهای همیشه رایگان برای توسعه‌دهندگان وب شامل CSS minify/unminify، بهینه‌ساز تصویر، تغییر اندازه عکس، تبدیل حروف، اعتبارسنج CSS، کامپایلر جاوااسکریپت، ویرایشگر HTML و غیره.
  * [ElevateAI](https://www.elevateai.com) - ماهانه تا ۲۰۰ ساعت رونویسی صوتی رایگان دریافت کنید.
  * [get.localhost.direct](https://get.localhost.direct) — گواهی SSL عمومی امضا شده Wildcard با پشتیبانی از زیر دامنه‌ها برای توسعه لوکال‌هاست
  * [Framacloud](https://degooglisons-internet.org/en/) — فهرست نرم‌افزار و SaaS متن‌باز و رایگان توسط انجمن غیرانتفاعی فرانسوی [Framasoft](https://framasoft.org/en/).
  * [github.com — FOSS for Dev](https://github.com/tvvocold/FOSS-for-Dev) — مرکز نرم‌افزارهای رایگان و متن‌باز برای توسعه‌دهندگان.
  * [GitHub Education](https://education.github.com/pack) — مجموعه‌ای از خدمات رایگان برای دانشجویان. ثبت‌نام لازم است.
  * [Markdown Tools](https://markdowntools.com) - ابزارهایی برای تبدیل HTML، CSV، PDF، JSON و فایل‌های اکسل به و از Markdown
  * [Microsoft 365 Developer Program](https://developer.microsoft.com/microsoft-365/dev-program) — دریافت محیط آزمایشی رایگان، ابزارها و منابع مورد نیاز برای ساخت راهکار روی پلتفرم Microsoft 365. اشتراک ۹۰ روزه [Microsoft 365 E5 Subscription](https://www.microsoft.com/microsoft-365/enterprise/e5) (بدون ویندوز) که قابل تمدید است. در صورتی تمدید می‌شود که در توسعه فعال باشید (بر اساس داده‌های تله‌متری و الگوریتم‌ها).
  * [Pyrexp](https://pythonium.net/regex) — ابزار رایگان و مبتنی بر وب برای تست و تجسم Regex برای دیباگ عبارات منظم.
  * [RedHat for Developers](https://developers.redhat.com) — دسترسی رایگان به محصولات Red Hat از جمله RHEL، OpenShift، CodeReady و غیره فقط برای توسعه‌دهندگان. فقط پلن فردی. کتاب‌های الکترونیکی رایگان نیز ارائه می‌شود.
  * [smsreceivefree.com](https://smsreceivefree.com/) — ارائه شماره تلفن موقت و یک‌بارمصرف رایگان.
  * [sandbox.httpsms.com](https://sandbox.httpsms.com) — ارسال و دریافت پیامک تستی به صورت رایگان.
  * [SimpleBackups.com](https://simplebackups.com/) — سرویس خودکارسازی بکاپ برای سرورها و دیتابیس‌ها (MySQL، PostgreSQL، MongoDB) با ذخیره مستقیم در ارائه‌دهندگان فضای ابری (AWS، DigitalOcean، Backblaze). پلن رایگان برای ۱ بکاپ.
  * [SnapShooter](https://snapshooter.com/) — راهکار بکاپ برای DigitalOcean، AWS، LightSail، Hetzner و Exoscale با پشتیبانی از بکاپ مستقیم دیتابیس، فایل سیستم و اپلیکیشن روی فضای مبتنی بر s3. پلن رایگان با بکاپ روزانه برای یک منبع.
  * [Themeselection](https://themeselection.com/) — قالب‌های رایگان داشبورد ادمین با طراحی مدرن، حرفه‌ای و باکیفیت، تم‌های HTML و UI Kit برای ساخت سریع‌تر اپلیکیشن‌ها.
  * [Web.Dev](https://web.dev/measure/) — ابزار رایگان برای مشاهده عملکرد سایت و بهبود SEO جهت کسب رتبه بالاتر در موتورهای جستجو.
  * [SmallDev.tools](https://smalldev.tools/) — یک ابزار رایگان برای توسعه‌دهندگان که امکان رمزگذاری/رمزگشایی فرمت‌های مختلف، فشرده‌سازی HTML/CSS/Javascript، زیباسازی، تولید داده‌های جعلی/تست در فرمت‌های JSON/CSV و بسیاری دیگر را با یک رابط کاربری دلپذیر فراهم می‌کند.
  * [UseCSV by Layercode](https://layercode.com/usecsv) — در چند دقیقه امکان وارد کردن فایل‌های CSV و اکسل را به اپلیکیشن وب خود اضافه کنید. به کاربران خود تجربه‌ای لذت‌بخش و قدرتمند در وارد کردن داده‌ها ارائه دهید. بدون نیاز به اطلاعات کارت اعتباری به صورت رایگان شروع کنید و امروز UseCSV را یکپارچه‌سازی کنید. می‌توانید واردکننده‌های نامحدود ایجاد کنید و فایل‌هایی تا سقف ۱۰۰ مگابایت بارگذاری نمایید.
  * [Buttons Generator](https://markodenic.com/tools/buttons-generator/) — بیش از ۱۰۰ دکمه آماده برای استفاده در پروژه شما.
  * [WrapPixel](https://www.wrappixel.com/) — دانلود قالب‌های داشبورد مدیریتی رایگان و پریمیوم با کیفیت بالا ساخته شده با Angular، React، VueJs، NextJS و NuxtJS!
  * [Utils.fun](https://utils.fun/en) — تمام ابزارهای روزمره و توسعه‌ای آفلاین مبتنی بر قدرت محاسباتی مرورگر، شامل تولید واترمارک، ضبط صفحه، رمزگذاری و رمزگشایی، رمزنگاری و فرمت‌دهی کد به صورت کاملاً رایگان و بدون بارگذاری داده‌ها در فضای ابری.
  * [It tools](it-tools.tech) - ابزارهای مفید برای توسعه‌دهندگان و افرادی که در حوزه IT کار می‌کنند.
  * [Free Code Tools](https://freecodetools.org/) — ابزارهای کدنویسی مؤثر که ۱۰۰٪ رایگان هستند. ویرایشگر Markdown، فشرده‌ساز/زیباساز کد، تولیدکننده QR کد، تولیدکننده Open Graph، تولیدکننده کارت توییتر و موارد دیگر.
  * [regex101](https://regex101.com/) — این وب‌سایت رایگان به شما امکان می‌دهد عبارات باقاعده (regex) را تست و اشکال‌زدایی کنید. شامل ویرایشگر و تستر regex و مستندات و منابع آموزشی مفید.
  * [Kody Tools](https://www.kodytools.com/dev-tools) — بیش از ۱۰۰ ابزار توسعه شامل فرمت‌دهی، فشرده‌سازی و تبدیل‌گرها.
  * [AdminMart](https://adminmart.com/) — قالب‌های داشبورد مدیریتی و وب‌سایت رایگان و پریمیوم با کیفیت بالا ساخته شده با Angular، Bootstrap، React، VueJs، NextJS و NuxtJS!
  * [Glob tester](https://globster.xyz/) — سایتی برای طراحی و تست الگوهای glob. همچنین منابع آموزشی برای یادگیری الگوهای glob ارائه می‌دهد.
  * [SimpleRestore](https://simplerestore.io) - بازیابی پشتیبان MySQL بدون دردسر. بازیابی پشتیبان‌های MySQL به هر پایگاه داده راه دور بدون کدنویسی یا سرور.
  * [360Converter](https://www.360converter.com/) - وب‌سایت مفید با پلن رایگان برای تبدیل: ویدئو به متن، صوت به متن، گفتار به متن، صوت بلادرنگ به متن، ویدئوی یوتیوب به متن و افزودن زیرنویس به ویدئو. شاید برای تبدیل ویدئوی کوتاه یا آموزش کوتاه یوتیوب مفید باشد :)
  * [QRCodeBest](https://qrcode.best/) - ساخت QR کد سفارشی با ۱۳ قالب، حفظ کامل حریم خصوصی و برندینگ شخصی. شامل پیکسل‌های رهگیری، دسته‌بندی پروژه و تعداد نامحدود اعضای تیم در QRCode.Best.
  * [PostPulse](https://PostPulseAI.com) - حضور آنلاین خود را افزایش دهید، سئو و رتبه سایت خود را با پست‌های ماهانه تولیدشده توسط هوش مصنوعی برای دامنه‌های سئو شده تقویت کنید. پلن رایگان اجازه می‌دهد ماهانه یک پست به صورت دستی در سایت منتشر کنید.
  * [PageTools](https://pagetools.co/) - مجموعه‌ای از ابزارهای رایگان مبتنی بر هوش مصنوعی برای تولید سیاست‌های ضروری وب‌سایت، ساخت بیو و پست شبکه‌های اجتماعی و صفحات وب تنها با یک کلیک.
  * [MySQL Visual Explain](https://mysqlexplain.com) - ابزار رایگان و قابل فهم برای مصورسازی خروجی EXPLAIN در MySQL جهت بهینه‌سازی کوئری‌های کند.
  * [Killer Coda](https://killercoda.com/)  - محیط تعاملی در مرورگر برای یادگیری لینوکس، Kubernetes، کانتینرها، برنامه‌نویسی، DevOps و شبکه.
  * [Axonomy App](https://axonomy-app.com/) - ابزاری رایگان برای ایجاد، مدیریت و اشتراک‌گذاری فاکتورها با مشتریان. ۱۰ فاکتور رایگان در ماه.
  * [Table Format Converter](https://www.tableformatconverter.com) - ابزاری رایگان برای تبدیل داده‌های جدول به فرمت‌های مختلف مانند CSV، HTML، JSON، Markdown و دیگر فرمت‌ها.


**[⬆️ بازگشت به بالا](#table-of-contents)**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---