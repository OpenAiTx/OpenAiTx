[![Dockerhub](https://img.shields.io/docker/pulls/falkordb/falkordb?label=Docker)](https://hub.docker.com/r/falkordb/falkordb/)
[![Discord](https://img.shields.io/discord/1146782921294884966?style=flat-square)](https://discord.gg/6M4QwDXn2w)
[![codecov](https://codecov.io/gh/falkordb/falkordb/graph/badge.svg?token=0G4HBEJMW0)](https://codecov.io/gh/falkordb/falkordb)
[![Workflow](https://github.com/FalkorDB/FalkorDB/actions/workflows/build.yml/badge.svg?branch=master)](https://github.com/FalkorDB/FalkorDB/actions/workflows/build.yml)

# FalkorDB - GraphRAG और GenAI के लिए ग्राफ डाटाबेस

एक स्केलेबल, कम-विलंबता वाला ग्राफ डाटाबेस, जिसे विकास टीमों के लिए डिज़ाइन किया गया है जो संरचित और असंरचित आपस में जुड़े डेटा को रीयल-टाइम या इंटरेक्टिव परिवेश में प्रबंधित करती हैं।

[![Try Free](https://img.shields.io/badge/Try%20Free-FalkorDB%20Cloud-FF8101?labelColor=FDE900&style=for-the-badge&link=https://app.falkordb.cloud)](https://app.falkordb.cloud)<br>

![FalkorDB Graph Database](https://raw.githubusercontent.com/FalkorDB/FalkorDB/master/assets/header.jpg)

## विशेषताएं (UNIQUE FEATURES)

हमारा उद्देश्य उच्च-प्रदर्शन वाला नॉलेज ग्राफ बनाना है, जो बड़े भाषा मॉडल्स (LLMs) के लिए उपयुक्त हो, और अत्यंत कम विलंबता को प्राथमिकता देता हो, जिससे हमारी ग्राफ डाटाबेस के माध्यम से तेज़ और कुशल जानकारी प्रदान की जा सके।

🆕 [FalkorDB](https://www.falkordb.com/) पहला **प्रश्नयोग्य [Property Graph](https://github.com/opencypher/openCypher/blob/master/docs/property-graph-model.adoc) डाटाबेस है जो ग्राफ में [adjacency matrix](https://en.wikipedia.org/wiki/Adjacency_matrix) को प्रस्तुत करने के लिए sparse matrices** और क्वेरी के लिए [linear algebra](https://en.wikipedia.org/wiki/Adjacency_matrix) का उपयोग करता है।

### मुख्य विशेषताएं

* **Sparse Matrix Representation**: adjacency matrices को प्रस्तुत करने के लिए sparse matrices का उपयोग करता है, जिससे संग्रहण और प्रदर्शन में अनुकूलन होता है।

* **Linear Algebra Querying**: क्वेरी निष्पादन के लिए लीनियर अल्जेब्रा का उपयोग करता है, जिससे संगणनात्मक दक्षता बढ़ती है।

* **Property Graph Model Compliance**: नोड्स और रिश्तों के साथ विशेषताओं का समर्थन करता है, और प्रॉपर्टी ग्राफ मॉडल का पालन करता है।

* **OpenCypher Support:** [OpenCypher](ttps://github.com/opencypher/openCypher/blob/master/docs/property-graph-model.adoc) क्वेरी भाषा के साथ संगत, जिसमें उन्नत क्वेरी क्षमताओं के लिए स्वामित्व विस्तार शामिल हैं।

> FalkorDB को क्रियान्वित होते हुए देखने के लिए [Demos](https://github.com/FalkorDB/FalkorDB/tree/master/demo) देखें।

## प्रलेखन (DOCUMENTATION)

[आधिकारिक दस्तावेज़](https://docs.falkordb.com/) | [क्लाइंट्स](https://docs.falkordb.com/clients.html) | [कमांड्स](https://docs.falkordb.com/commands/) | 📊 [नवीनतम प्रदर्शन बेंचमार्क](https://benchmark.falkordb.com/)

### समुदाय और सहायता

* **चर्चाएँ**: प्रश्न पूछने, विचार साझा करने और अन्य उपयोगकर्ताओं से जुड़ने के लिए हमारे [GitHub Discussions](https://github.com/FalkorDB/FalkorDB/discussions) में शामिल हों।

* **योगदान**: हम योगदान का स्वागत करते हैं! अधिक जानकारी के लिए कृपया हमारा [Contributing Guide](https://github.com/FalkorDB/FalkorDB/blob/master/CONTRIBUTING.md) देखें।

* **लाइसेंस**: यह परियोजना Server Side Public License v1 (SSPLv1) के तहत लाइसेंस प्राप्त है। विवरण के लिए [LICENSE](https://github.com/FalkorDB/FalkorDB/blob/master/LICENSE.txt) फ़ाइल देखें।

## प्रारंभ करें (GET STARTED)

### चरण 1

FalkorDB को शीघ्रता से आज़माने के लिए, docker का उपयोग करके एक इंस्टेंस लॉन्च करें:

```
docker run -p 6379:6379 -it --rm -v ./data:/var/lib/falkordb/data falkordb/falkordb:edge
```

या, बिल्ट-इन ब्राउज़र-आधारित इंटरफेस का उपयोग करने के लिए, चलाएँ:

```
docker run -p 6379:6379 -p 3000:3000 -it --rm -v ./data:/var/lib/falkordb/data falkordb/falkordb:edge
```

### चरण 2

फिर, अपने ब्राउज़र को खोलें और `http://localhost:3000` पर जाएँ।

आप समर्थित किसी भी [क्लाइंट लाइब्रेरी](https://docs.falkordb.com/clients.html) का उपयोग करके भी FalkorDB के साथ इंटरैक्ट कर सकते हैं।

### MotoGP लीग उदाहरण

इस उदाहरण में, हम [FalkorDB Python client](https://pypi.org/project/FalkorDB/) का उपयोग करके एक छोटा ग्राफ बनाएंगे, जिसमें MotoGP लीग में भाग लेने वाले कुछ मोटरसाइकिल राइडर्स और टीमों का उपसमुच्चय दर्शाया गया है। ग्राफ बनाने के बाद, हम उसके संरचना और संबंधों का पता लगाने के लिए डेटा क्वेरी करेंगे।

```python
from falkordb import FalkorDB

# FalkorDB से कनेक्ट करें
db = FalkorDB(host='localhost', port=6379)

# 'MotoGP' ग्राफ बनाएं
g = db.select_graph('MotoGP')
g.query("""CREATE (:Rider {name:'Valentino Rossi'})-[:rides]->(:Team {name:'Yamaha'}),
                  (:Rider {name:'Dani Pedrosa'})-[:rides]->(:Team {name:'Honda'}),
                  (:Rider {name:'Andrea Dovizioso'})-[:rides]->(:Team {name:'Ducati'})""")

# क्वेरी: Yamaha का प्रतिनिधित्व कौन से राइडर करते हैं?
res = g.query("""MATCH (r:Rider)-[:rides]->(t:Team)
                 WHERE t.name = 'Yamaha'
                 RETURN r.name""")

for row in res.result_set:
	print(row[0])

# प्रिंट करेगा: "Valentino Rossi"

# क्वेरी: Ducati टीम का प्रतिनिधित्व कितने राइडर करते हैं?
res = g.query("""MATCH (r:Rider)-[:rides]->(t:Team {name:'Ducati'})
                 RETURN count(r)""")

print(res.result_set[0][0])
# प्रिंट करेगा: 1
```

## निर्माण प्रारंभ करें (START BUILDING)

### संकलन (Compiling)

इन आवश्यकताओं को पूरा करना सुनिश्चित करें:

1️⃣ FalkorDB रिपॉजिटरी: `git clone --recurse-submodules -j8 https://github.com/FalkorDB/FalkorDB.git`

> Ubuntu Linux पर चलाएँ: `apt-get install build-essential cmake m4 automake peg libtool autoconf python3 python3-pip`
	
> OS X पर, सुनिश्चित करें कि `homebrew` इंस्टॉल है और चलाएँ: `brew install cmake m4 automake peg libtool autoconf`.
>> OS X टूलचेन के साथ आने वाला Clang संस्करण OpenMP का समर्थन नहीं करता, जो FalkorDB के लिए आवश्यक है। इसे हल करने के लिए, `brew install gcc g++` चलाएँ और स्क्रीन पर दिए गए निर्देशों का पालन कर प्रतीकों के लिंक अपडेट करें। ध्यान दें कि यह एक सिस्टम-वाइड परिवर्तन है - यदि यह विकल्प नहीं है तो `CC` और `CXX` के लिए पर्यावरण चर सेट करना भी काम करेगा।

2️⃣ प्रोजेक्ट की डायरेक्टरी में `make` चलाकर बिल्ड करें।

बधाई हो! आप संकलित बाइनरी `bin/<arch>/src/falkordb.so` में पा सकते हैं।

### परीक्षण चलाना (Running tests)

आवश्यक Python पैकेज स्थापित करने के लिए ```tests``` डायरेक्टरी से ```pip install -r requirements.txt``` चलाएँ।

> नोट: यदि आपके PATH में ```redis-server``` है, तो केवल ```make test``` चलाएँ। अन्यथा, ```REDIS_SERVER=<redis-server-location> make test``` चलाएँ। अधिक विवरण के लिए ```make test V=1``` चलाएँ।

### डॉकर में निर्माण (Building in a docker)

FalkorDB का बिल्ड सिस्टम डॉकर के भीतर चलता है। विस्तार से निर्देशों के लिए कृपया [यहाँ देखें](https://docs.falkordb.com/docker-examples/README.html)।

## रेडिस में FalkorDB लोड करना (LOADING FALKORDB INTO REDIS)

FalkorDB [Redis](https://redis.io) द्वारा होस्ट किया जाता है, इसलिए आपको इसे पहले एक मॉड्यूल के रूप में Redis सर्वर में लोड करना होगा।
> नोट: FalkorDB 2.12 के लिए [Redis 6.2](https://redis.io/download) आवश्यक है।

💡 हम अनुशंसा करते हैं कि Redis को FalkorDB स्टार्टअप के समय लोड करने के लिए अपनी redis.conf फ़ाइल में निम्न जोड़ें:

```
loadmodule /path/to/module/src/falkordb.so
```

ऊपर दी गई लाइन में, `/path/to/module/src/falkordb.so` को FalkorDB की लाइब्रेरी के वास्तविक पथ से बदलें।
यदि Redis एक सेवा के रूप में चल रहा है, तो आपको यह सुनिश्चित करना होगा कि `redis` उपयोगकर्ता (डिफ़ॉल्ट) के पास `falkordb.so` को एक्सेस करने के लिए आवश्यक फ़ाइल/फोल्डर अनुमतियां हों।

वैकल्पिक रूप से, आप निम्न कमांड लाइन आर्ग्युमेंट सिंटैक्स का उपयोग करके Redis को FalkorDB लोड करा सकते हैं:

```sh
~/$ redis-server --loadmodule /path/to/module/src/falkordb.so
```

अंत में, आप [`MODULE LOAD`](http://redis.io/commands/module-load) कमांड का भी उपयोग कर सकते हैं। ध्यान दें कि `MODULE LOAD` एक खतरनाक कमांड है और सुरक्षा कारणों से भविष्य में अवरुद्ध/अप्रचलित हो सकता है।

एक बार जब आपने FalkorDB को सफलतापूर्वक लोड कर लिया, तो आपके Redis लॉग में इस तरह की लाइनें दिखनी चाहिए:

```
...
30707:M 20 Jun 02:08:12.314 * Module 'graph' loaded from <redacted>/src/falkordb.so
...
```

यदि सर्वर इस तरह के आउटपुट के साथ लॉन्च होने में विफल रहता है:

```
# Module /usr/lib/redis/modules/falkordb.so failed to load: libgomp.so.1: cannot open shared object file: No such file or directory
# Can't load module from /usr/lib/redis/modules/falkordb.so: server aborting
```

तो सिस्टम में रन-टाइम डिपेंडेंसी OpenMP अनुपस्थित है। इसे Ubuntu पर `apt-get install libgomp1`, RHEL/CentOS पर `yum install libgomp`, और OSX पर `brew install libomp` से इंस्टॉल किया जा सकता है।

## FalkorDB का उपयोग करना (USING FALKORDB)

आप किसी भी Redis क्लाइंट से FalkorDB के कमांड्स को कॉल कर सकते हैं। यहाँ कुछ तरीके दिए गए हैं:

### `redis-cli` के साथ

```sh
$ redis-cli
127.0.0.1:6379> GRAPH.QUERY social "CREATE (:person {name: 'roi', age: 33, gender: 'male', status: 'married'})"
```

### किसी अन्य क्लाइंट के साथ

आप अपने क्लाइंट की कच्ची Redis कमांड भेजने की क्षमता का उपयोग करके FalkorDB के साथ इंटरैक्ट कर सकते हैं।

>नोट: आपके चुने हुए क्लाइंट के आधार पर, यह करने का सटीक तरीका अलग हो सकता है।

#### उदाहरण: Python क्लाइंट के साथ FalkorDB का उपयोग

यह कोड स्निपेट दिखाता है कि Python से [falkordb-py](https://github.com/FalkorDB/falkordb-py) का उपयोग करके FalkorDB के साथ कैसे काम करें:

```Python
from falkordb import FalkorDB

# FalkorDB से कनेक्ट करें
db = FalkorDB(host='localhost', port=6379)

# social ग्राफ चुनें
g = db.select_graph('social')

reply = g.query("CREATE (:person {name:'roi', age:33, gender:'male', status:'married'})")
```

## क्लाइंट लाइब्रेरीज़ (CLIENT LIBRARIES)

>नोट: कुछ भाषाओं के पास FalkorDB के कमांड्स के लिए समर्थन देने वाली क्लाइंट लाइब्रेरीज़ हैं:

### आधिकारिक क्लाइंट्स

| Project                                                   | Language   | License | Author                                      | Stars                                                             | Package | Comment    |
| --------------------------------------------------------- | ---------- | ------- | ------------------------------------------- | ----------------------------------------------------------------- | ------- | ---------- |
| [jfalkordb][jfalkordb-url] | Java | BSD | [FalkorDB][falkordb-url] | [![jfalkordb-stars]][jfalkordb-url] | [Maven][jfalkordb-package]||
| [falkordb-py][falkordb-py-url] | Python | MIT | [FalkorDB][falkordb-url] | [![falkordb-py-stars]][falkordb-py-url] | [pypi][falkordb-py-package]||
| [falkordb-ts][falkordb-ts-url] | Node.JS | MIT | [FalkorDB][falkordb-url] | [![falkordb-ts-stars]][falkordb-ts-url] | [npm][falkordb-ts-package]||
| [falkordb-rs][falkordb-rs-url] | Rust | MIT | [FalkorDB][falkordb-url] | [![falkordb-rs-stars]][falkordb-rs-url] | [Crate][falkordb-rs-package]||
| [falkordb-go][falkordb-go-url] | Go | BSD | [FalkorDB][falkordb-url] | [![falkordb-go-stars]][falkordb-go-url] | [GitHub][falkordb-go-url]||
| [NFalkorDB][nfalkordb-url]  |  C# | Apache-2.0 | [FalkorDB][falkordb-url] | [![nfalkordb-stars]][nfalkordb-url] | [nuget][nfalkordb-package] | |


### अतिरिक्त क्लाइंट्स

| Project                                                   | Language   | License | Author                                      | Stars                                                             | Package | Comment    |
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

## लाइसेंस

Server Side Public License v1 (SSPLv1) के तहत लाइसेंस प्राप्त। विवरण के लिए [LICENSE](LICENSE.txt) देखें।

### हमारे कार्य का समर्थन करें

⭐️ यदि आपको यह रिपॉजिटरी उपयोगी लगे, तो कृपया इसे स्टार दें!

↗️ ग्राफ, ग्राफ डाटाबेस, RAG, graphrag, Retrieval-Augmented Generation,Information Retrieval, Natural Language Processing, LLM, Embeddings, Semantic Search

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---