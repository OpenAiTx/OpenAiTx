[![Dockerhub](https://img.shields.io/docker/pulls/falkordb/falkordb?label=Docker)](https://hub.docker.com/r/falkordb/falkordb/)
[![Discord](https://img.shields.io/discord/1146782921294884966?style=flat-square)](https://discord.gg/6M4QwDXn2w)
[![codecov](https://codecov.io/gh/falkordb/falkordb/graph/badge.svg?token=0G4HBEJMW0)](https://codecov.io/gh/falkordb/falkordb)
[![Workflow](https://github.com/FalkorDB/FalkorDB/actions/workflows/build.yml/badge.svg?branch=master)](https://github.com/FalkorDB/FalkorDB/actions/workflows/build.yml)

# FalkorDB - قاعدة بيانات الرسم البياني لـ GraphRAG و GenAI

قاعدة بيانات رسم بياني قابلة للتوسع وذات زمن استجابة منخفض، مصممة لفرق التطوير التي تدير بيانات مترابطة منظمة وغير منظمة في البيئات التفاعلية أو الفورية.

[![جرب مجانًا](https://img.shields.io/badge/Try%20Free-FalkorDB%20Cloud-FF8101?labelColor=FDE900&style=for-the-badge&link=https://app.falkordb.cloud)](https://app.falkordb.cloud)<br>

![قاعدة بيانات رسم بياني FalkorDB](https://raw.githubusercontent.com/FalkorDB/FalkorDB/master/assets/header.jpg)

## الميزات الفريدة

هدفنا هو بناء رسم بياني معرفي عالي الأداء مصمم خصيصًا لنماذج اللغة الكبيرة (LLMs)، مع التركيز على تحقيق زمن استجابة منخفض للغاية لضمان توصيل سريع وفعال للمعلومات من خلال قاعدة بيانات الرسم البياني الخاصة بنا.

🆕 [FalkorDB](https://www.falkordb.com/) هي أول قاعدة بيانات **[رسم بياني بالخصائص](https://github.com/opencypher/openCypher/blob/master/docs/property-graph-model.adoc) قابلة للاستعلام تستخدم المصفوفات المتفرقة** لتمثيل [مصفوفة الجوار](https://en.wikipedia.org/wiki/Adjacency_matrix) في الرسوم البيانية و[الجبر الخطي](https://en.wikipedia.org/wiki/Adjacency_matrix) للاستعلام.

### الميزات الأساسية

* **تمثيل المصفوفة المتفرقة**: يستخدم مصفوفات متفرقة لتمثيل مصفوفات الجوار، مما يعزز الكفاءة التخزينية والأداء.

* **استعلام بالجبر الخطي**: يستخدم الجبر الخطي لتنفيذ الاستعلامات، مما يعزز الكفاءة الحسابية.

* **الامتثال لنموذج الرسم البياني بالخصائص**: يدعم العقد والعلاقات مع السمات، بما يتوافق مع نموذج الرسم البياني بالخصائص.

* **دعم OpenCypher:** متوافق مع لغة الاستعلام [OpenCypher](https://github.com/opencypher/openCypher/blob/master/docs/property-graph-model.adoc)، بما في ذلك الامتدادات الخاصة للإمكانات المتقدمة في الاستعلام.

> استكشف FalkorDB عمليًا من خلال زيارة [العروض التوضيحية](https://github.com/FalkorDB/FalkorDB/tree/master/demo).

## التوثيق

[التوثيق الرسمي](https://docs.falkordb.com/) | [العملاء](https://docs.falkordb.com/clients.html) | [الأوامر](https://docs.falkordb.com/commands/) | 📊 [أحدث نتائج اختبارات الأداء](https://benchmark.falkordb.com/)

### المجتمع والدعم

* **المناقشات**: انضم إلى مناقشات المجتمع على [مناقشات GitHub](https://github.com/FalkorDB/FalkorDB/discussions) لطرح الأسئلة، ومشاركة الأفكار، والتواصل مع مستخدمين آخرين.

* **المساهمة**: نرحب بالمساهمات! يرجى مراجعة [دليل المساهمة](https://github.com/FalkorDB/FalkorDB/blob/master/CONTRIBUTING.md) لمزيد من التفاصيل.

* **الترخيص**: هذا المشروع مرخص بموجب ترخيص Server Side Public License v1 (SSPLv1). راجع ملف [الترخيص](https://github.com/FalkorDB/FalkorDB/blob/master/LICENSE.txt) لمزيد من التفاصيل.

## البدء

### الخطوة 1

لتجربة FalkorDB بسرعة، قم بتشغيل نسخة باستخدام Docker:

```
docker run -p 6379:6379 -it --rm -v ./data:/var/lib/falkordb/data falkordb/falkordb:edge
```

أو، لاستخدام الواجهة المدمجة عبر المتصفح، نفذ:

```
docker run -p 6379:6379 -p 3000:3000 -it --rm -v ./data:/var/lib/falkordb/data falkordb/falkordb:edge
```

### الخطوة 2

بعد ذلك، افتح متصفحك وانتقل إلى `http://localhost:3000`.

يمكنك أيضًا التفاعل مع FalkorDB باستخدام أي من [مكتبات العملاء المدعومة](https://docs.falkordb.com/clients.html)

### مثال دوري MotoGP

في هذا المثال، سنستخدم [عميل بايثون لـ FalkorDB](https://pypi.org/project/FalkorDB/) لإنشاء رسم بياني صغير يمثل مجموعة من سائقي الدراجات النارية والفرق المشاركة في دوري MotoGP. بعد إنشاء الرسم البياني، سنستعلم عن البيانات لاستكشاف هيكلها والعلاقات بينها.

```python
from falkordb import FalkorDB

# الاتصال بـ FalkorDB
db = FalkorDB(host='localhost', port=6379)

# إنشاء رسم بياني باسم 'MotoGP'
g = db.select_graph('MotoGP')
g.query("""CREATE (:Rider {name:'Valentino Rossi'})-[:rides]->(:Team {name:'Yamaha'}),
                  (:Rider {name:'Dani Pedrosa'})-[:rides]->(:Team {name:'Honda'}),
                  (:Rider {name:'Andrea Dovizioso'})-[:rides]->(:Team {name:'Ducati'})""")

# الاستعلام: من هم السائقون الذين يمثلون Yamaha؟
res = g.query("""MATCH (r:Rider)-[:rides]->(t:Team)
                 WHERE t.name = 'Yamaha'
                 RETURN r.name""")

for row in res.result_set:
	print(row[0])

# يطبع: "Valentino Rossi"

# الاستعلام: كم عدد السائقين الذين يمثلون فريق Ducati ؟
res = g.query("""MATCH (r:Rider)-[:rides]->(t:Team {name:'Ducati'})
                 RETURN count(r)""")

print(res.result_set[0][0])
# يطبع: 1
```

## ابدأ البناء

### الترجمة

تأكد من استيفاء المتطلبات التالية:

1️⃣ مستودع FalkorDB: `git clone --recurse-submodules -j8 https://github.com/FalkorDB/FalkorDB.git`

> على أوبونتو لينكس، نفذ: `apt-get install build-essential cmake m4 automake peg libtool autoconf python3 python3-pip`
	
> على OS X، تأكد من وجود `homebrew` ونفذ: `brew install cmake m4 automake peg libtool autoconf`.
>> إصدار Clang المرفق مع أدوات OS X لا يدعم OpenMP، وهو متطلب أساسي لـ FalkorDB. يمكن حل ذلك بتثبيت `brew install gcc g++` واتباع التعليمات لتحديث الروابط الرمزية. لاحظ أن هذا تغيير على مستوى النظام - يمكن تعيين متغيرات البيئة `CC` و`CXX` كخيار بديل.

2️⃣ البناء بتنفيذ الأمر `make` في مجلد المشروع.

تهانينا! ستجد الملف التنفيذي المترجم في `bin/<arch>/src/falkordb.so`.

### تشغيل الاختبارات

ابدأ بتثبيت الحزم المطلوبة للبايثون بتنفيذ ```pip install -r requirements.txt``` من مجلد ```tests```.

> ملاحظة: إذا كان لديك ```redis-server``` في PATH، فقط نفذ ```make test```. وإلا، نفذ ```REDIS_SERVER=<redis-server-location> make test```. لمخرجات أكثر تفصيلًا، نفذ ```make test V=1```.

### البناء عبر docker

نظام بناء FalkorDB يعمل ضمن docker. للتعليمات التفصيلية حول البناء، يرجى [الاطلاع هنا](https://docs.falkordb.com/docker-examples/README.html).

## تحميل FalkorDB في Redis

يستضيف [Redis](https://redis.io) قاعدة بيانات FalkorDB، لذا يجب تحميلها كـ Module إلى خادم Redis أولاً.
> ملاحظة: [Redis 6.2](https://redis.io/download) مطلوب لـ FalkorDB 2.12.

💡 نوصي بتحميل FalkorDB تلقائيًا أثناء بدء Redis عبر إضافة السطر التالي إلى ملف redis.conf:

```
loadmodule /path/to/module/src/falkordb.so
```

استبدل `/path/to/module/src/falkordb.so` في السطر أعلاه بالمسار الفعلي لمكتبة FalkorDB.
إذا كان Redis يعمل كخدمة، يجب التأكد من أن المستخدم `redis` (الإعداد الافتراضي) يمتلك الصلاحيات المناسبة للوصول إلى ملف `falkordb.so`.

بديلًا عن ذلك، يمكنك تحميل FalkorDB إلى Redis باستخدام وسائط سطر الأوامر التالية:

```sh
~/$ redis-server --loadmodule /path/to/module/src/falkordb.so
```

وأخيرًا، يمكنك أيضًا استخدام أمر [`MODULE LOAD`](http://redis.io/commands/module-load). مع ذلك، يرجى الانتباه إلى أن `MODULE LOAD` أمر خطير وقد يتم حظره/إهماله مستقبلاً لأسباب أمنية.

بعد التحميل الناجح لـ FalkorDB، يجب أن ترى في سجل Redis أسطر مشابهة لـ:

```
...
30707:M 20 Jun 02:08:12.314 * Module 'graph' loaded from <redacted>/src/falkordb.so
...
```

إذا فشل الخادم في الإقلاع مع إخراج مشابه لـ:

```
# Module /usr/lib/redis/modules/falkordb.so failed to load: libgomp.so.1: cannot open shared object file: No such file or directory
# Can't load module from /usr/lib/redis/modules/falkordb.so: server aborting
```

فالنظام يفتقر لاعتماد وقت التشغيل OpenMP. يمكن تثبيته على أوبونتو باستخدام `apt-get install libgomp1`، وعلى RHEL/CentOS باستخدام `yum install libgomp`، وعلى OSX باستخدام `brew install libomp`.

## استخدام FalkorDB

يمكنك استدعاء أوامر FalkorDB من أي عميل Redis. فيما يلي بعض الطرق:

### باستخدام `redis-cli`

```sh
$ redis-cli
127.0.0.1:6379> GRAPH.QUERY social "CREATE (:person {name: 'roi', age: 33, gender: 'male', status: 'married'})"
```

### باستخدام أي عميل آخر

يمكنك التفاعل مع FalkorDB باستخدام قدرة عميلك على إرسال أوامر Redis الأولية.

>ملاحظة: حسب نوع عميلك، قد تختلف طريقة التنفيذ.

#### مثال: استخدام FalkorDB مع عميل بايثون

يعرض هذا المثال كيفية استخدام FalkorDB من بايثون باستخدام [falkordb-py](https://github.com/FalkorDB/falkordb-py):

```Python
from falkordb import FalkorDB

# الاتصال بـ FalkorDB
db = FalkorDB(host='localhost', port=6379)

# اختيار رسم بياني باسم social
g = db.select_graph('social')

reply = g.query("CREATE (:person {name:'roi', age:33, gender:'male', status:'married'})")
```

## مكتبات العملاء

>ملاحظة: بعض اللغات لديها مكتبات عملاء تدعم أوامر FalkorDB:

### العملاء الرسميون

| المشروع                                                   | اللغة      | الترخيص | المؤلف                                      | النجوم                                                             | الحزمة | التعليق    |
| --------------------------------------------------------- | ---------- | ------- | ------------------------------------------- | ----------------------------------------------------------------- | ------- | ---------- |
| [jfalkordb][jfalkordb-url] | Java | BSD | [FalkorDB][falkordb-url] | [![jfalkordb-stars]][jfalkordb-url] | [Maven][jfalkordb-package]||
| [falkordb-py][falkordb-py-url] | Python | MIT | [FalkorDB][falkordb-url] | [![falkordb-py-stars]][falkordb-py-url] | [pypi][falkordb-py-package]||
| [falkordb-ts][falkordb-ts-url] | Node.JS | MIT | [FalkorDB][falkordb-url] | [![falkordb-ts-stars]][falkordb-ts-url] | [npm][falkordb-ts-package]||
| [falkordb-rs][falkordb-rs-url] | Rust | MIT | [FalkorDB][falkordb-url] | [![falkordb-rs-stars]][falkordb-rs-url] | [Crate][falkordb-rs-package]||
| [falkordb-go][falkordb-go-url] | Go | BSD | [FalkorDB][falkordb-url] | [![falkordb-go-stars]][falkordb-go-url] | [GitHub][falkordb-go-url]||
| [NFalkorDB][nfalkordb-url]  |  C# | Apache-2.0 | [FalkorDB][falkordb-url] | [![nfalkordb-stars]][nfalkordb-url] | [nuget][nfalkordb-package] | |

### عملاء إضافيون

| المشروع                                                   | اللغة      | الترخيص | المؤلف                                      | النجوم                                                             | الحزمة | التعليق    |
| --------------------------------------------------------- | ---------- | ------- | ------------------------------------------- | ----------------------------------------------------------------- | ------- | ---------- |
| [nredisstack][nredisstack-url] | .NET | MIT | [Redis][redis-url] | [![nredisstack-stars]][nredisstack-url] | [nuget][nredisstack-package]||
| [redisgraph-rb][redisgraph-rb-url]                        | Ruby       | BSD     | [Redis][redisgraph-rb-author]          | [![redisgraph-rb-stars]][redisgraph-rb-url]                       | [GitHub][redisgraph-rb-url] ||
| [redgraph][redgraph-url]                                  | Ruby       | MIT     | [pzac][redgraph-author]                | [![redgraph-stars]][redgraph-url]                                 | [GitHub][redgraph-url] ||
| [redisgraph-go][redisgraph-go-url]                        | Go         | BSD     | [Redis][redisgraph-go-author]          | [![redisgraph-go-stars]][redisgraph-go-url]                       | [GitHub][redisgraph-go-url]||
| [rueidis][rueidis-url]                                    | Go         | Apache 2.0 | [Rueian][rueidis-author]          | [![rueidis-stars]][rueidis-url]                       | [GitHub][rueidis-url] ||
| [ioredisgraph][ioredisgraph-url]                          | JavaScript | ISC     | [Jonah][ioredisgraph-author]                | [![ioredisgraph-stars]][ioredisgraph-url]                         | [GitHub][ioredisgraph-url] ||
| [@hydre/rgraph][rgraph-url]                               | JavaScript | MIT     | [Sceat][rgraph-author]                      | [![rgraph-stars]][rgraph-url]                                     | [GitHub][rgraph-url] ||
| [php-redis-graph][php-redis-graph-url]                    | PHP        | MIT     | [KJDev][php-redis-graph-author]             | [![php-redis-graph-stars]][php-redis-graph-url]                   | [GitHub][php-redis-graph-url] ||
| [redisgraph_php][redisgraph_php-url]                      | PHP        | MIT     | [jpbourbon][redisgraph_php-author]          | [![redisgraph_php-stars]][redisgraph_php-url]                     | [GitHub][redisgraph_php-url] ||
| [redisgraph-ex][redisgraph-ex-url]                        | Elixir     | MIT     | [crflynn][redisgraph-ex-author]             | [![redisgraph-ex-stars]][redisgraph-ex-url]                       | [GitHub][redisgraph-ex-url] ||
| [redisgraph-rs][redisgraph-rs-url]                        | Rust       | MIT     | [malte-v][redisgraph-rs-author]             | [![redisgraph-rs-stars]][redisgraph-rs-url]                       | [GitHub][redisgraph-rs-url] ||
| [redis_graph][redis_graph-url]                            | Rust       | BSD     | [tompro][redis_graph-author]                | [![redis_graph-stars]][redis_graph-url]                           | [GitHub][redis_graph-url] ||
| [rustis][rustis-url]                                     | Rust       | MIT          | [Dahomey Technologies][rustis-author]       | [![rustis-stars]][rustis-url]    | [Crate](https://crates.io/crates/rustis) | [Documentation](https://docs.rs/rustis/latest/rustis/commands/trait.GraphCommands.html) |
| [NRedisGraph][NRedisGraph-url]                            | C#         | BSD     | [tombatron][NRedisGraph-author]             | [![NRedisGraph-stars]][NRedisGraph-url]                           | [GitHub][NRedisGraph-url] ||
| [RedisGraph.jl][RedisGraph.jl-url]                        | Julia      | MIT     | [xyxel][RedisGraph.jl-author]               | [![RedisGraph.jl-stars]][RedisGraph.jl-url]                       | [GitHub][RedisGraph.jl-url] ||

[redis-url]: https://redis.com
[falkordb-url]: https://www.falkordb.com

[falkordb-py-url]: http://github.com/falkorDB/falkordb-py
[falkordb-py-stars]: https://img.shields.io/github/stars/falkorDB/falkordb-py.svg?style=social&amp;label=Star&amp;maxAge=2592000
[falkordb-py-package]: https://pypi.org/project/FalkorDB

[jfalkordb-url]: https://github.com/falkordb/jfalkordb
[jfalkordb-stars]: https://img.shields.io/github/stars/falkordb/jfalkordb.svg?style=social&amp;label=Star&amp;maxAge=2592000
[jfalkordb-package]: https://search.maven.org/artifact/com.falkordb/jfalkordb

[nfalkordb-url]: https://github.com/falkordb/NFalkorDB
[nfalkordb-stars]: https://img.shields.io/github/stars/falkordb/nfalkordb.svg?style=social&label=Star&maxAge=2592000
[nfalkordb-package]: https://www.nuget.org/packages/NFalkorDB

[nredisstack-url]: https://github.com/redis/nredisstack
[nredisstack-stars]: https://img.shields.io/github/stars/redis/nredisstack.svg?style=social&amp;label=Star&amp;maxAge=2592000
[nredisstack-package]: https://www.nuget.org/packages/nredisstack/

[falkordb-ts-url]: https://github.com/falkordb/falkordb-ts
[falkordb-ts-stars]: https://img.shields.io/github/stars/falkordb/falkordb-ts.svg?style=social&amp;label=Star&amp;maxAge=2592000
[falkordb-ts-package]: https://www.npmjs.com/package/falkordb

[falkordb-rs-url]: https://github.com/falkordb/falkordb-rs
[falkordb-rs-stars]: https://img.shields.io/github/stars/falkordb/falkordb-rs.svg?style=social&amp;label=Star&amp;maxAge=2592000
[falkordb-rs-package]: https://crates.io/crates/falkordb

[falkordb-go-url]: https://github.com/falkordb/falkordb-go
[falkordb-go-stars]: https://img.shields.io/github/stars/falkordb/falkordb-go.svg?style=social&amp;label=Star&amp;maxAge=2592000
[falkordb-go-package]: https://github.com/falkordb/falkordb-go

[redisgraph-rb-author]: https://redislabs.com
[redisgraph-rb-url]: https://github.com/RedisGraph/redisgraph-rb
[redisgraph-rb-stars]: https://img.shields.io/github/stars/RedisGraph/redisgraph-rb.svg?style=social&amp;label=Star&amp;maxAge=2592000

[redgraph-author]: https://github.com/pzac
[redgraph-url]: https://github.com/pzac/redgraph
[redgraph-stars]: https://img.shields.io/github/stars/pzac/redgraph.svg?style=social&amp;label=Star&amp;maxAge=2592000

[redisgraph-go-author]: https://redislabs.com
[redisgraph-go-url]: https://github.com/RedisGraph/redisgraph-go
[redisgraph-go-stars]: https://img.shields.io/github/stars/RedisGraph/redisgraph-go.svg?style=social&amp;label=Star&amp;maxAge=2592000

[rueidis-url]: https://github.com/rueian/rueidis
[rueidis-author]: https://github.com/rueian
[rueidis-stars]: https://img.shields.io/github/stars/rueian/rueidis.svg?style=social&amp;label=Star&amp;maxAge=2592000

[rgraph-author]: https://github.com/Sceat
[rgraph-url]: https://github.com/HydreIO/rgraph
[rgraph-stars]: https://img.shields.io/github/stars/HydreIO/rgraph.svg?style=social&amp;label=Star&amp;maxAge=2592000

[ioredisgraph-author]: https://github.com/Jonahss
[ioredisgraph-url]: https://github.com/Jonahss/ioredisgraph
[ioredisgraph-stars]: https://img.shields.io/github/stars/Jonahss/ioredisgraph.svg?style=social&amp;label=Star&amp;maxAge=2592000

[php-redis-graph-author]: https://github.com/kjdev
[php-redis-graph-url]: https://github.com/kjdev/php-redis-graph
[php-redis-graph-stars]: https://img.shields.io/github/stars/kjdev/php-redis-graph.svg?style=social&amp;label=Star&amp;maxAge=2592000

[redisgraph_php-author]: https://github.com/jpbourbon
[redisgraph_php-url]: https://github.com/jpbourbon/redisgraph_php
[redisgraph_php-stars]: https://img.shields.io/github/stars/jpbourbon/redisgraph_php.svg?style=social&amp;label=Star&amp;maxAge=2592000

[redislabs-redisgraph-php-author]: https://github.com/mkorkmaz
[redislabs-redisgraph-php-url]: https://github.com/mkorkmaz/redislabs-redisgraph-php
[redislabs-redisgraph-php-stars]: https://img.shields.io/github/stars/mkorkmaz/redislabs-redisgraph-php.svg?style=social&amp;label=Star&amp;maxAge=2592000

[redisgraph-ex-author]: https://github.com/crflynn
[redisgraph-ex-url]: https://github.com/crflynn/redisgraph-ex
[redisgraph-ex-stars]: https://img.shields.io/github/stars/crflynn/redisgraph-ex.svg?style=social&amp;label=Star&amp;maxAge=2592000

[redisgraph-rs-author]: https://github.com/malte-v
[redisgraph-rs-url]: https://github.com/malte-v/redisgraph-rs
[redisgraph-rs-stars]: https://img.shields.io/github/stars/malte-v/redisgraph-rs.svg?style=social&amp;label=Star&amp;maxAge=2592000

[redis_graph-author]: https://github.com/tompro
[redis_graph-url]: https://github.com/tompro/redis_graph
[redis_graph-stars]: https://img.shields.io/github/stars/tompro/redis_graph.svg?style=social&amp;label=Star&amp;maxAge=2592000

[NRedisGraph-author]: https://github.com/tombatron
[NRedisGraph-url]: https://github.com/tombatron/NRedisGraph
[NRedisGraph-stars]: https://img.shields.io/github/stars/tombatron/NRedisGraph.svg?style=social&amp;label=Star&amp;maxAge=2592000

[RedisGraphDotNet.Client-author]: https://github.com/Sgawrys
[RedisGraphDotNet.Client-url]: https://github.com/Sgawrys/RedisGraphDotNet.Client
[RedisGraphDotNet.Client-stars]: https://img.shields.io/github/stars/Sgawrys/RedisGraphDotNet.Client.svg?style=social&amp;label=Star&amp;maxAge=2592000

[RedisGraph.jl-author]: https://github.com/xyxel
[RedisGraph.jl-url]: https://github.com/xyxel/RedisGraph.jl
[RedisGraph.jl-stars]: https://img.shields.io/github/stars/xyxel/RedisGraph.jl.svg?style=social&amp;label=Star&amp;maxAge=2592000

[rustis-url]: https://github.com/dahomey-technologies/rustis
[rustis-author]: https://github.com/dahomey-technologies
[rustis-stars]: https://img.shields.io/github/stars/dahomey-technologies/rustis.svg?style=social&amp;label=Star&amp;maxAge=2592000

## الترخيص

مرخص بموجب Server Side Public License v1 (SSPLv1). راجع [الترخيص](LICENSE.txt).

### دعم عملنا

⭐️ إذا وجدت هذا المستودع مفيدًا، يرجى منحه نجمة!

↗️ رسم بياني، قاعدة بيانات رسم بياني، RAG، graphrag، استرجاع معزز، استرجاع المعلومات، معالجة اللغة الطبيعية، LLM، تضمينات، بحث دلالي

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---