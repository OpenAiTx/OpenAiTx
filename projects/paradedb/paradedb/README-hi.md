<h1 align="center">
  <a href="https://paradedb.com"><img src="https://raw.githubusercontent.com/paradedb/paradedb/dev/docs/logo/readme.svg" alt="ParadeDB"></a>
<br>
</h1>

<p align="center">
  <b>खोज और एनालिटिक्स के लिए पोस्टग्रेस</b> <br />
</p>

<h3 align="center">
  <a href="https://paradedb.com">वेबसाइट</a> &bull;
  <a href="https://docs.paradedb.com">दस्तावेज़</a> &bull;
  <a href="https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw">समुदाय</a> &bull;
  <a href="https://paradedb.com/blog/">ब्लॉग</a> &bull;
  <a href="https://docs.paradedb.com/changelog/">परिवर्तन लॉग</a>
</h3>

---

[![Artifact Hub](https://img.shields.io/endpoint?url=https://artifacthub.io/badge/repository/paradedb)](https://artifacthub.io/packages/search?repo=paradedb)
[![Docker Pulls](https://img.shields.io/docker/pulls/paradedb/paradedb)](https://hub.docker.com/r/paradedb/paradedb)
[![License](https://img.shields.io/github/license/paradedb/paradedb?color=blue)](https://github.com/paradedb/paradedb?tab=AGPL-3.0-1-ov-file#readme)
[![Slack URL](https://img.shields.io/badge/Join%20Slack-purple?logo=slack&link=https%3A%2F%2Fjoin.slack.com%2Ft%2Fparadedbcommunity%2Fshared_invite%2Fzt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw)](https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw)
[![X URL](https://img.shields.io/twitter/url?url=https%3A%2F%2Ftwitter.com%2Fparadedb&label=Follow%20%40paradedb)](https://x.com/paradedb)

[ParadeDB](https://paradedb.com) एक आधुनिक Elasticsearch विकल्प है जो Postgres पर आधारित है। इसे रियल-टाइम, बार-बार अपडेट होने वाले वर्कलोड्स के लिए बनाया गया है।

## रोडमैप

- [x] खोज
  - [x] [pg_search](https://github.com/paradedb/paradedb/tree/dev/pg_search#overview) के साथ BM25 द्वारा फुल-टेक्स्ट सर्च
  - [x] [pgvector](https://github.com/pgvector/pgvector#pgvector) के साथ डेंस और स्पार्स वेक्टर सर्च
  - [ ] वितरित (डिस्ट्रीब्यूटेड) सर्च
- [ ] एनालिटिक्स
  - [x] [pg_search](https://github.com/paradedb/paradedb/tree/dev/pg_search#overview) के साथ Postgres डेटा पर फेसिटेड सर्च
  - [ ] कॉलम-ओरिएंटेड Postgres टेबल एक्सेस मेथड

विस्तृत रोडमैप के लिए, देखें [ParadeDB रोडमैप 2025](https://github.com/orgs/paradedb/discussions/2041)।

## शुरुआत करें

शुरुआत करने के लिए कृपया हमारे [दस्तावेज़](https://docs.paradedb.com) देखें।

## ParadeDB को डिप्लॉय करना

ParadeDB और इसके एक्सटेंशन दो तरीकों से डिप्लॉय किए जा सकते हैं:

- [Postgres](https://hub.docker.com/_/postgres) आधारित डॉकर इमेज ([डिप्लॉयमेंट निर्देश देखें](https://docs.paradedb.com/deploy/aws))
- [CloudNativePG](https://artifacthub.io/packages/helm/cloudnative-pg/cloudnative-pg) आधारित Kubernetes Helm चार्ट ([डिप्लॉयमेंट निर्देश देखें](https://docs.paradedb.com/deploy/helm))

अधिक जानकारी, एंटरप्राइज फीचर्स और सपोर्ट के लिए, कृपया [हमें ईमेल करें](mailto:sales@paradedb.com)।

### एक्सटेंशन

Debian 11, 12, Ubuntu 22.04 और 24.04, Red Hat Enterprise Linux 8 और 9, और macOS 14 (Sonoma) व 15 (Sequoia) के लिए Postgres 14+ हेतु ParadeDB Postgres एक्सटेंशन के प्रीबिल्ट बायनरी आपको [GitHub Releases](https://github.com/paradedb/paradedb/releases/latest) में मिलेंगे।

ParadeDB, PostgreSQL Global Development Group द्वारा समर्थित सभी संस्करणों (PostgreSQL 14+) को सपोर्ट करता है, और आप संबंधित एक्सटेंशन के README में दिए निर्देशों के अनुसार अन्य संस्करणों के लिए एक्सटेंशन कंपाइल कर सकते हैं।

### डॉकर इमेज

ParadeDB इंस्टेंस को जल्दी से चालू करने के लिए, नवीनतम डॉकर इमेज को पुल और रन करें:

```bash
docker run --name paradedb -e POSTGRES_PASSWORD=password paradedb/paradedb
```

यह `postgres` यूज़र और `password` पासवर्ड के साथ एक ParadeDB इंस्टेंस शुरू करेगा। इसके बाद आप `psql` का उपयोग कर डेटाबेस से कनेक्ट कर सकते हैं:

```bash
docker exec -it paradedb psql -U postgres
```

स्थानीय या ऑन-प्रिमाइज़ इंस्टॉलेशन के लिए हम आपके `docker-compose.yml` फ़ाइल के उपयोग की सलाह देते हैं। वैकल्पिक रूप से, आप `docker run` कमांड में उपयुक्त एनवायरनमेंट वेरिएबल्स पास कर सकते हैं, जहां <> को अपनी पसंद के मान से बदलें:

```bash
docker run \
  --name paradedb \
  -e POSTGRES_USER=<user> \
  -e POSTGRES_PASSWORD=<password> \
  -e POSTGRES_DB=<dbname> \
  -v paradedb_data:/var/lib/postgresql/data/ \
  -p 5432:5432 \
  -d \
  paradedb/paradedb:latest
```

यह `<user>` यूज़र और `<password>` पासवर्ड के साथ नॉन-रूट ParadeDB इंस्टेंस शुरू करेगा। `-v` फ्लैग के साथ आपका ParadeDB डेटा डॉकर वॉल्यूम `paradedb_data` में रिस्टार्ट्स के बाद भी बना रहेगा।

अब आप डेटाबेस से ऐसे कनेक्ट कर सकते हैं:

```bash
docker exec -it paradedb psql -U <user> -d <dbname> -p 5432 -W
```

### Helm चार्ट

ParadeDB Kubernetes के लिए हमारे Helm चार्ट के माध्यम से भी उपलब्ध है। आप [ParadeDB Helm Chart GitHub रिपोजिटरी](https://github.com/paradedb/charts) में या सीधे [Artifact Hub](https://artifacthub.io/packages/helm/paradedb/paradedb) से चार्ट पा सकते हैं।

### ParadeDB क्लाउड

अभी के लिए, ParadeDB एक प्रबंधित क्लाउड सेवा के रूप में उपलब्ध नहीं है। यदि आप ParadeDB क्लाउड सेवा में रुचि रखते हैं, तो कृपया हमारे [वेटलिस्ट](https://form.typeform.com/to/jHkLmIzx) में शामिल हों।

## समर्थन

यदि कोई फीचर गायब है या आपने कोई बग पाया है, तो कृपया एक
[GitHub Issue](https://github.com/paradedb/paradedb/issues/new/choose) खोलें।

समुदाय से सहायता प्राप्त करने के लिए आप:

- [ParadeDB Slack Community](https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw) में प्रश्न पूछें
- हमारे [GitHub Discussions](https://github.com/paradedb/paradedb/discussions) में सहायता मांगें

यदि आपको व्यावसायिक सहायता चाहिए, तो कृपया [ParadeDB टीम से संपर्क करें](mailto:sales@paradedb.com)।

## योगदान

हम समुदाय के सभी योगदानों का स्वागत करते हैं, चाहे वे छोटे हों या बड़े, और इसमें आपकी मदद के लिए हमेशा तैयार हैं। योगदान शुरू करने के लिए हमारे [पहली बार योगदानकर्ताओं के मुद्दे](https://github.com/paradedb/paradedb/labels/good%20first%20issue) देखें या [ParadeDB Community Slack](https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw) पर हमें संदेश भेजें। योगदान करने के बाद, Slack में हमें सूचित करें और हम आपको कुछ ParadeDB swag भेजेंगे!

योगदान कैसे करें, इस पर अधिक जानकारी के लिए, कृपया हमारा
[योगदान गाइड](https://raw.githubusercontent.com/paradedb/paradedb/dev/CONTRIBUTING.md) देखें।

यह प्रोजेक्ट [Contributor Code of Conduct](https://raw.githubusercontent.com/paradedb/paradedb/dev/CODE_OF_CONDUCT.md) के साथ जारी किया गया है।
इस प्रोजेक्ट में भाग लेकर, आप इसकी शर्तों को मानते हैं।

हमारे साथ मिलकर ParadeDB को सभी के लिए बेहतर बनाने में मदद करने के लिए धन्यवाद :heart:।

## लाइसेंस

ParadeDB [GNU Affero General Public License v3.0](https://raw.githubusercontent.com/paradedb/paradedb/dev/LICENSE) और व्यावसायिक सॉफ़्टवेयर के रूप में लाइसेंस प्राप्त है। व्यावसायिक लाइसेंसिंग के लिए, कृपया हमसे [sales@paradedb.com](mailto:sales@paradedb.com) पर संपर्क करें।

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---