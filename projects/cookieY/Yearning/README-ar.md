<div align="center">

<h1 style="border-bottom: none">
    <b><a href="https://next.yearning.io">Yearning</a></b><br />
</h1>
</div>

منصة قوية تُنشأ محليًا مصممة للكشف السلس عن أوامر SQL وتدقيق الاستعلامات، مُخصصة خصيصًا لمسؤولي قواعد البيانات والمطورين. مع التركيز على الخصوصية والكفاءة، توفر بيئة بديهية وآمنة لتدقيق MYSQL.

---
[![OSCS Status](https://www.oscs1024.com/platform/badge/cookieY/Yearning.svg?size=small)](https://www.murphysec.com/dr/nDuoncnUbuFMdrZsh7)
![Platform Support](https://img.shields.io/badge/-x86_x64%20ARM%20Supports%20%E2%86%92-rgb(84,56,255)?style=flat-square&logoColor=white&logo=linux)
[![][github-license-shield]][github-license-link]
![GitHub top language](https://img.shields.io/github/languages/top/cookieY/Yearning?color=369eff&label=golang&labelColor=black&logo=golang&logoColor=white&style=flat-square)
[![][github-forks-shield]][github-forks-link]
[![][github-stars-shield]][github-stars-link]
[![Downloads](https://img.shields.io/github/downloads/cookieY/Yearning/total?labelColor=black&logo=download&logoColor=white&style=flat-square)](https://github.com/cookieY/Yearning/releases/latest)

English | [简体中文](https://raw.githubusercontent.com/cookieY/Yearning/next/README.zh-CN.md) | [日本語](https://raw.githubusercontent.com/cookieY/Yearning/next/README.ja-JP.md)

## ✨ الميزات

- **المساعد الذكي (AI Assistant)**: يقدم مساعد الذكاء الاصطناعي لدينا اقتراحات فورية لتحسين أوامر SQL، مما يُعزز أداء SQL. كما يدعم تحويل النص إلى SQL، حيث يمكن للمستخدمين إدخال لغة طبيعية والحصول على أوامر SQL مُحسّنة.

- **تدقيق SQL**: أنشئ تذاكر تدقيق SQL مع سير عمل للموافقة وفحوصات تلقائية للصياغة. تحقق من صحة أوامر SQL من حيث الدقة، الأمان، والامتثال. يتم إنشاء أوامر الرجوع تلقائيًا لعمليات DDL/DML، مع سجل تاريخي شامل للتتبع.

- **تدقيق الاستعلامات**: دقق استعلامات المستخدمين، وقيّد مصادر البيانات وقواعد البيانات، وأخفي الحقول الحساسة. يتم حفظ سجلات الاستعلامات للرجوع إليها مستقبلاً.

- **قواعد الفحص**: يدعم الفاحص التلقائي للصياغة مجموعة واسعة من قواعد الفحص، مناسبة لمعظم سيناريوهات الفحص التلقائي.

- **الخصوصية أولاً**: Yearning هو حل مفتوح المصدر قابل للنشر محليًا يضمن أمان قاعدة بياناتك وأوامر SQL الخاصة بك. يتضمن آليات تشفير لحماية البيانات الحساسة، مما يضمن بقائها آمنة حتى في حال حدوث وصول غير مصرح به.

- **التحكم في الوصول المستند إلى الدور (RBAC)**: أنشئ وأدر الأدوار بصلاحيات محددة، وقيد الوصول إلى أوامر الاستعلام، ووظائف التدقيق، والعمليات الحساسة الأخرى بناءً على أدوار المستخدمين.

> \[!TIP]
> لمزيد من المعلومات التفصيلية، زر [دليل Yearning](https://next.yearning.io)


## ⚙️ التثبيت

حمّل [أحدث إصدار](https://github.com/cookieY/Yearning/releases/latest) وقم بفك ضغطه. تأكد من أنك قمت بتكوين `./config.toml` قبل المتابعة.

### التثبيت اليدوي

```bash
## تهيئة قاعدة البيانات
./Yearning install

## بدء Yearning
./Yearning run

## المساعدة
./Yearning --help
```

### 🚀 النشر باستخدام Docker
[![][docker-release-shield]][docker-release-link]
[![][docker-size-shield]][docker-size-link]
[![][docker-pulls-shield]][docker-pulls-link]
```bash
## تهيئة قاعدة البيانات
docker run --rm -it -p8000:8000 -e SECRET_KEY=$SECRET_KEY -e MYSQL_USER=$MYSQL_USER -e MYSQL_ADDR=$MYSQL_ADDR -e MYSQL_PASSWORD=$MYSQL_PASSWORD -e MYSQL_DB=$Yearning_DB -e Y_LANG=zh_CN yeelabs/yearning "/opt/Yearning install"

## بدء Yearning
docker run -d -it -p8000:8000 -e SECRET_KEY=$SECRET_KEY -e MYSQL_USER=$MYSQL_USER -e MYSQL_ADDR=$MYSQL_ADDR -e MYSQL_PASSWORD=$MYSQL_PASSWORD -e MYSQL_DB=$Yearning_DB -e Y_LANG=zh_CN yeelabs/yearning
```
## 🤖 المساعد الذكي (AI)

يستفيد مساعد الذكاء الاصطناعي لدينا من نموذج لغوي ضخم لتقديم اقتراحات لتحسين SQL وتحويل النص إلى SQL. سواء استخدمت العبارات الافتراضية أو المخصصة، يُعزز المساعد الذكي أداء SQL من خلال تحسين الأوامر وتحويل مدخلات اللغة الطبيعية إلى استعلامات SQL.

![Text to SQL](https://raw.githubusercontent.com/cookieY/Yearning/next/img/text2sql.jpg)

## 🔖 الفاحص التلقائي لأوامر SQL

يقيم الفاحص التلقائي لأوامر SQL الأوامر وفق قواعد وصياغة محددة مسبقًا. يضمن أن الأوامر تلتزم بمعايير الترميز المحددة وأفضل الممارسات ومتطلبات الأمان، موفرًا طبقة قوية من التحقق.

![SQL Audit](https://raw.githubusercontent.com/cookieY/Yearning/next/img/audit.png)

## 💡 تمييز صياغة SQL والإكمال التلقائي

عزز كفاءة كتابة الاستعلامات بتمييز صياغة SQL والإكمال التلقائي. تساعد هذه الميزات المستخدمين على التمييز بصريًا بين مكونات استعلام SQL المختلفة، مثل الكلمات المفتاحية، أسماء الجداول، أسماء الأعمدة، والعوامل، مما يسهل قراءة وفهم بنية الاستعلام.

![SQL Query](https://raw.githubusercontent.com/cookieY/Yearning/next/img/query.png)

## ⏺️ سجل الأوامر/الاستعلامات

تدعم منصتنا تدقيق أوامر واستعلامات المستخدمين. تتيح لك هذه الميزة تتبع وتسجيل جميع عمليات الاستعلام، بما في ذلك مصادر البيانات، قواعد البيانات، والتعامل مع الحقول الحساسة، مما يضمن الامتثال للوائح ويوفر إمكانية تتبع تاريخ الاستعلامات.

![Order/Query Record](https://raw.githubusercontent.com/cookieY/Yearning/next/img/record.png)

من خلال التركيز على هذه الميزات الرئيسية، يُحسّن Yearning تجربة المستخدم، ويُحسّن أداء SQL، ويضمن الامتثال القوي وإمكانية تتبع العمليات في قواعد البيانات.

## 🛠️ أدوات موصى بها

- [Spug - منصة عمليات أتمتة خفيفة الوزن مفتوحة المصدر](https://github.com/openspug/spug)

## ☎️ تواصل معنا

للاستفسارات، يرجى مراسلتنا عبر البريد الإلكتروني: henry@yearning.io
## 📋 الترخيص

يورننغ مرخص بموجب رخصة AGPL. راجع [LICENSE](LICENSE) لمزيد من التفاصيل.

2024 © هنري يي

---

مع يورننغ، اختبر طريقة مبسطة، وآمنة، وفعّالة لتدقيق وتحسين استعلامات SQL.


[docker-pulls-link]: https://hub.docker.com/r/yeelabs/yearning
[docker-pulls-shield]: https://img.shields.io/docker/pulls/yeelabs/yearning?color=45cc11&labelColor=black&style=flat-square
[docker-release-link]: https://hub.docker.com/r/yeelabs/yearning
[docker-release-shield]: https://img.shields.io/docker/v/yeelabs/yearning?color=369eff&label=docker&labelColor=black&logo=docker&logoColor=white&style=flat-square
[docker-size-link]: https://hub.docker.com/r/yeelabs/yearning
[docker-size-shield]: https://img.shields.io/docker/image-size/yeelabs/yearning?color=369eff&labelColor=black&style=flat-square
[github-forks-shield]: https://img.shields.io/github/forks/cookieY/Yearning?color=8ae8ff&labelColor=black&style=flat-square
[github-forks-link]: https://github.com/cookieY/Yearning/network/members
[github-stars-link]: https://github.com/cookieY/Yearning/network/stargazers
[github-stars-shield]: https://img.shields.io/github/stars/cookieY/Yearning?color=ffcb47&labelColor=black&style=flat-square
[github-license-link]: https://github.com/cookieY/Yearning/blob/main/LICENSE
[github-license-shield]: https://img.shields.io/badge/AGPL%203.0-white?labelColor=black&style=flat-square


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---