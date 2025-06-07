[![Dockerhub](https://img.shields.io/docker/pulls/falkordb/falkordb?label=Docker)](https://hub.docker.com/r/falkordb/falkordb/)
[![Discord](https://img.shields.io/discord/1146782921294884966?style=flat-square)](https://discord.gg/6M4QwDXn2w)
[![codecov](https://codecov.io/gh/falkordb/falkordb/graph/badge.svg?token=0G4HBEJMW0)](https://codecov.io/gh/falkordb/falkordb)
[![Workflow](https://github.com/FalkorDB/FalkorDB/actions/workflows/build.yml/badge.svg?branch=master)](https://github.com/FalkorDB/FalkorDB/actions/workflows/build.yml)

# FalkorDB - پایگاه داده گراف برای GraphRAG و GenAI

یک پایگاه داده گراف مقیاس‌پذیر با تأخیر پایین که برای تیم‌های توسعه‌دهنده جهت مدیریت داده‌های ساخت‌یافته و غیرساخت‌یافته‌ی به‌هم‌پیوسته در محیط‌های بلادرنگ یا تعاملی طراحی شده است.

[![Try Free](https://img.shields.io/badge/Try%20Free-FalkorDB%20Cloud-FF8101?labelColor=FDE900&style=for-the-badge&link=https://app.falkordb.cloud)](https://app.falkordb.cloud)<br>

![FalkorDB Graph Database](https://raw.githubusercontent.com/FalkorDB/FalkorDB/master/assets/header.jpg)

## ویژگی‌های منحصربه‌فرد

هدف ما ساخت یک گراف دانش با عملکرد بالا است که برای مدل‌های زبانی بزرگ (LLMها) بهینه شده و با اولویت‌بخشی به تأخیر بسیار پایین، تحویل سریع و کارآمد اطلاعات را از طریق پایگاه داده گراف خود تضمین می‌کند.

🆕 [FalkorDB](https://www.falkordb.com/) اولین **پایگاه داده [Property Graph](https://github.com/opencypher/openCypher/blob/master/docs/property-graph-model.adoc) قابل پرس‌وجو است که از ماتریس‌های پراکنده** برای نمایش [ماتریس مجاورت](https://en.wikipedia.org/wiki/Adjacency_matrix) در گراف‌ها و [جبر خطی](https://en.wikipedia.org/wiki/Adjacency_matrix) جهت پرس‌وجو استفاده می‌کند.

### ویژگی‌های کلیدی

* **نمایش ماتریس پراکنده**: استفاده از ماتریس‌های پراکنده برای نمایش ماتریس‌های مجاورت، بهینه‌سازی فضا و عملکرد.

* **پرس‌وجو با جبر خطی**: بهره‌گیری از جبر خطی برای اجرای پرس‌وجوها و افزایش بازده محاسباتی.

* **تطابق با مدل Property Graph**: پشتیبانی از گره‌ها و روابط با ویژگی‌ها مطابق مدل Property Graph.

* **پشتیبانی از OpenCypher**: سازگار با زبان پرس‌وجوی [OpenCypher](https://github.com/opencypher/openCypher/blob/master/docs/property-graph-model.adoc) و افزونه‌های اختصاصی برای قابلیت‌های پیشرفته‌تر.

> با مشاهده [دموها](https://github.com/FalkorDB/FalkorDB/tree/master/demo) عملکرد FalkorDB را در عمل ببینید.

## مستندات

[مستندات رسمی](https://docs.falkordb.com/) | [کلاینت‌ها](https://docs.falkordb.com/clients.html) | [فرمان‌ها](https://docs.falkordb.com/commands/) | 📊 [جدیدترین بنچمارک‌های عملکرد](https://benchmark.falkordb.com/)

### جامعه و پشتیبانی

* **بحث‌ها**: به بحث‌های جامعه ما در [GitHub Discussions](https://github.com/FalkorDB/FalkorDB/discussions) بپیوندید، سوال بپرسید، ایده‌ها را به اشتراک بگذارید و با کاربران دیگر ارتباط برقرار کنید.

* **مشارکت**: ما از مشارکت استقبال می‌کنیم! لطفاً برای جزئیات بیشتر [راهنمای مشارکت](https://github.com/FalkorDB/FalkorDB/blob/master/CONTRIBUTING.md) را ببینید.

* **مجوز**: این پروژه تحت مجوز Server Side Public License v1 (SSPLv1) منتشر شده است. برای جزئیات به فایل [LICENSE](https://github.com/FalkorDB/FalkorDB/blob/master/LICENSE.txt) مراجعه کنید.

## شروع به کار

### گام ۱

برای آزمایش سریع FalkorDB، یک نمونه را با داکر اجرا کنید:

```
docker run -p 6379:6379 -it --rm -v ./data:/var/lib/falkordb/data falkordb/falkordb:edge
```

یا برای استفاده از رابط کاربری تحت وب داخلی، اجرا کنید:

```
docker run -p 6379:6379 -p 3000:3000 -it --rm -v ./data:/var/lib/falkordb/data falkordb/falkordb:edge
```

### گام ۲

سپس، مرورگر خود را باز کرده و به `http://localhost:3000` بروید.

همچنین می‌توانید با استفاده از هر یک از [کتابخانه‌های کلاینت پشتیبانی شده](https://docs.falkordb.com/clients.html) با FalkorDB تعامل داشته باشید.

### مثال لیگ MotoGP

در این مثال، با استفاده از [کلاینت پایتون FalkorDB](https://pypi.org/project/FalkorDB/) یک گراف کوچک شامل تعدادی موتورسوار و تیم‌های شرکت‌کننده در لیگ MotoGP می‌سازیم. پس از ایجاد گراف، داده‌ها را برای بررسی ساختار و روابط آن پرس‌وجو می‌کنیم.

```python
from falkordb import FalkorDB

# اتصال به FalkorDB
db = FalkorDB(host='localhost', port=6379)

# ایجاد گراف 'MotoGP'
g = db.select_graph('MotoGP')
g.query("""CREATE (:Rider {name:'Valentino Rossi'})-[:rides]->(:Team {name:'Yamaha'}),
                  (:Rider {name:'Dani Pedrosa'})-[:rides]->(:Team {name:'Honda'}),
                  (:Rider {name:'Andrea Dovizioso'})-[:rides]->(:Team {name:'Ducati'})""")

# پرس‌وجو: کدام موتورسوار نماینده Yamaha است؟
res = g.query("""MATCH (r:Rider)-[:rides]->(t:Team)
                 WHERE t.name = 'Yamaha'
                 RETURN r.name""")

for row in res.result_set:
	print(row[0])

# خروجی: "Valentino Rossi"

# پرس‌وجو: چند موتورسوار نماینده تیم Ducati هستند؟
res = g.query("""MATCH (r:Rider)-[:rides]->(t:Team {name:'Ducati'})
                 RETURN count(r)""")

print(res.result_set[0][0])
# خروجی: 1
```

## شروع به ساخت

### کامپایل کردن

اطمینان حاصل کنید که موارد زیر را انجام داده‌اید:

1️⃣ مخزن FalkorDB:  
`git clone --recurse-submodules -j8 https://github.com/FalkorDB/FalkorDB.git`

>در اوبونتو لینوکس اجرا کنید:  
`apt-get install build-essential cmake m4 automake peg libtool autoconf python3 python3-pip`
	
>در OS X اطمینان حاصل کنید که `homebrew` نصب شده است و اجرا کنید:  
`brew install cmake m4 automake peg libtool autoconf`
>>نسخه Clang همراه با ابزار OS X از OpenMP پشتیبانی نمی‌کند که برای FalkorDB ضروری است. یکی از راه‌حل‌ها اجرای `brew install gcc g++` و دنبال کردن دستورالعمل‌های صفحه نمایش برای به‌روزرسانی symbolic linkها است. توجه داشته باشید که این یک تغییر سراسری در سیستم است - تنظیم متغیرهای محیطی `CC` و `CXX` نیز کار می‌کند.

2️⃣ با اجرای `make` در پوشه پروژه، ساخت را آغاز کنید.

تبریک! فایل باینری کامپایل‌شده را در مسیر `bin/<arch>/src/falkordb.so` خواهید یافت.

### اجرای تست‌ها

ابتدا بسته‌های پایتون مورد نیاز را با اجرای ```pip install -r requirements.txt``` از دایرکتوری ```tests``` نصب کنید.

> توجه: اگر ```redis-server``` در PATH شما موجود است، کافی است ```make test``` را اجرا کنید. در غیر این صورت، ```REDIS_SERVER=<redis-server-location> make test``` را اجرا کنید. برای خروجی مفصل‌تر، ```make test V=1``` را اجرا کنید.

### ساخت داخل داکر

سیستم ساخت FalkorDB درون داکر اجرا می‌شود. برای دستورالعمل‌های دقیق ساخت، [اینجا را ببینید](https://docs.falkordb.com/docker-examples/README.html).

## بارگذاری FalkorDB در Redis

FalkorDB توسط [Redis](https://redis.io) میزبانی می‌شود؛ بنابراین ابتدا باید آن را به عنوان یک ماژول در سرور Redis بارگذاری کنید.  
> توجه: [Redis 6.2](https://redis.io/download) برای FalkorDB نسخه 2.12 لازم است.

💡 توصیه می‌کنیم هنگام راه‌اندازی Redis، FalkorDB را با افزودن خط زیر به فایل redis.conf بارگذاری کنید:

```
loadmodule /path/to/module/src/falkordb.so
```

در خط بالا، `/path/to/module/src/falkordb.so` را با مسیر واقعی کتابخانه FalkorDB جایگزین کنید.  
اگر Redis به صورت سرویس اجرا می‌شود، باید مطمئن شوید که کاربر `redis` (پیش‌فرض) مجوزهای لازم برای دسترسی به فایل/پوشه `falkordb.so` را دارد.

همچنین می‌توانید Redis را با استفاده از آرگومان خط فرمان زیر مجبور به بارگذاری FalkorDB کنید:

```sh
~/$ redis-server --loadmodule /path/to/module/src/falkordb.so
```

در نهایت، می‌توانید از فرمان [`MODULE LOAD`](http://redis.io/commands/module-load) نیز استفاده کنید. اما توجه داشته باشید که `MODULE LOAD` یک فرمان پرخطر است و ممکن است به دلایل امنیتی در آینده مسدود/غیرفعال شود.

پس از بارگذاری موفق FalkorDB، باید خطوطی مشابه زیر را در لاگ Redis مشاهده کنید:

```
...
30707:M 20 Jun 02:08:12.314 * Module 'graph' loaded from <redacted>/src/falkordb.so
...
```

اگر سرور با خروجی مشابه زیر راه‌اندازی نشد:

```
# Module /usr/lib/redis/modules/falkordb.so failed to load: libgomp.so.1: cannot open shared object file: No such file or directory
# Can't load module from /usr/lib/redis/modules/falkordb.so: server aborting
```

سیستم شما به وابستگی زمان اجرا OpenMP نیاز دارد. در اوبونتو با `apt-get install libgomp1`، در RHEL/CentOS با `yum install libgomp` و در OSX با `brew install libomp` آن را نصب کنید.

## استفاده از FalkorDB

می‌توانید فرمان‌های FalkorDB را از طریق هر کلاینت Redis فراخوانی کنید. در اینجا چند روش آمده است:

### با `redis-cli`

```sh
$ redis-cli
127.0.0.1:6379> GRAPH.QUERY social "CREATE (:person {name: 'roi', age: 33, gender: 'male', status: 'married'})"
```

### با هر کلاینت دیگر

می‌توانید با استفاده از قابلیت ارسال دستورات خام Redis کلاینت خود، با FalkorDB تعامل داشته باشید.

>توجه: بسته به کلاینت مورد استفاده، روش دقیق ممکن است متفاوت باشد.

#### مثال: استفاده از FalkorDB در پایتون

این قطعه کد نشان می‌دهد که چگونه می‌توان با [falkordb-py](https://github.com/FalkorDB/falkordb-py) در پایتون از FalkorDB استفاده کرد:

```Python
from falkordb import FalkorDB

# اتصال به FalkorDB
db = FalkorDB(host='localhost', port=6379)

# انتخاب گراف social
g = db.select_graph('social')

reply = g.query("CREATE (:person {name:'roi', age:33, gender:'male', status:'married'})")
```

## کتابخانه‌های کلاینت

>توجه: برخی زبان‌ها دارای کتابخانه‌هایی هستند که از فرمان‌های FalkorDB پشتیبانی می‌کنند:

### کلاینت‌های رسمی

| پروژه                                                   | زبان       | مجوز    | نویسنده                                    | ستاره‌ها                                                         | بسته   | توضیح      |
| ------------------------------------------------------- | ---------- | ------- | ------------------------------------------- | --------------------------------------------------------------- | ------- | ---------- |
| [jfalkordb][jfalkordb-url] | Java | BSD | [FalkorDB][falkordb-url] | [![jfalkordb-stars]][jfalkordb-url] | [Maven][jfalkordb-package]||
| [falkordb-py][falkordb-py-url] | Python | MIT | [FalkorDB][falkordb-url] | [![falkordb-py-stars]][falkordb-py-url] | [pypi][falkordb-py-package]||
| [falkordb-ts][falkordb-ts-url] | Node.JS | MIT | [FalkorDB][falkordb-url] | [![falkordb-ts-stars]][falkordb-ts-url] | [npm][falkordb-ts-package]||
| [falkordb-rs][falkordb-rs-url] | Rust | MIT | [FalkorDB][falkordb-url] | [![falkordb-rs-stars]][falkordb-rs-url] | [Crate][falkordb-rs-package]||
| [falkordb-go][falkordb-go-url] | Go | BSD | [FalkorDB][falkordb-url] | [![falkordb-go-stars]][falkordb-go-url] | [GitHub][falkordb-go-url]||
| [NFalkorDB][nfalkordb-url]  |  C# | Apache-2.0 | [FalkorDB][falkordb-url] | [![nfalkordb-stars]][nfalkordb-url] | [nuget][nfalkordb-package] | |

### کلاینت‌های اضافی

| پروژه                                                   | زبان       | مجوز    | نویسنده                                    | ستاره‌ها                                                         | بسته   | توضیح      |
| ------------------------------------------------------- | ---------- | ------- | ------------------------------------------- | --------------------------------------------------------------- | ------- | ---------- |
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

## مجوز

تحت مجوز Server Side Public License v1 (SSPLv1). [LICENSE](LICENSE.txt) را ببینید.

### از کار ما حمایت کنید

⭐️ اگر این مخزن برای شما مفید بود، لطفاً به آن ستاره بدهید!

↗️ گراف، پایگاه داده گراف، RAG، graphrag، تولید بازیابی محور، بازیابی اطلاعات، پردازش زبان طبیعی، LLM، بردارها، جستجوی معنایی

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---