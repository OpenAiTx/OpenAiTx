<h1 align="center">
  <a href="https://paradedb.com"><img src="https://raw.githubusercontent.com/paradedb/paradedb/dev/docs/logo/readme.svg" alt="ParadeDB"></a>
<br>
</h1>

<p align="center">
  <b>Arama ve Analitik için Postgres</b> <br />
</p>

<h3 align="center">
  <a href="https://paradedb.com">Web Sitesi</a> &bull;
  <a href="https://docs.paradedb.com">Dokümantasyon</a> &bull;
  <a href="https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw">Topluluk</a> &bull;
  <a href="https://paradedb.com/blog/">Blog</a> &bull;
  <a href="https://docs.paradedb.com/changelog/">Değişiklik Günlüğü</a>
</h3>

---

[![Artifact Hub](https://img.shields.io/endpoint?url=https://artifacthub.io/badge/repository/paradedb)](https://artifacthub.io/packages/search?repo=paradedb)
[![Docker Pulls](https://img.shields.io/docker/pulls/paradedb/paradedb)](https://hub.docker.com/r/paradedb/paradedb)
[![License](https://img.shields.io/github/license/paradedb/paradedb?color=blue)](https://github.com/paradedb/paradedb?tab=AGPL-3.0-1-ov-file#readme)
[![Slack URL](https://img.shields.io/badge/Join%20Slack-purple?logo=slack&link=https%3A%2F%2Fjoin.slack.com%2Ft%2Fparadedbcommunity%2Fshared_invite%2Fzt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw)](https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw)
[![X URL](https://img.shields.io/twitter/url?url=https%3A%2F%2Ftwitter.com%2Fparadedb&label=Follow%20%40paradedb)](https://x.com/paradedb)

[ParadeDB](https://paradedb.com), Postgres üzerinde geliştirilen modern bir Elasticsearch alternatifidir. Gerçek zamanlı, güncellemeye yoğun iş yükleri için tasarlanmıştır.

## Yol Haritası

- [x] Arama
  - [x] [pg_search](https://github.com/paradedb/paradedb/tree/dev/pg_search#overview) ile BM25 tam metin arama
  - [x] [pgvector](https://github.com/pgvector/pgvector#pgvector) ile yoğun ve seyrek vektör arama
  - [ ] Dağıtık arama
- [ ] Analitik
  - [x] [pg_search](https://github.com/paradedb/paradedb/tree/dev/pg_search#overview) ile Postgres verisinde fasetli arama
  - [ ] Sütun odaklı Postgres tablo erişim yöntemi

Detaylı yol haritası için [2025 ParadeDB Yol Haritası](https://github.com/orgs/paradedb/discussions/2041) sayfasına bakınız.

## Başlarken

Başlamak için lütfen [dokümantasyonumuzu](https://docs.paradedb.com) ziyaret edin.

## ParadeDB'nin Dağıtımı

ParadeDB ve uzantıları iki şekilde dağıtılabilir:

- [Postgres](https://hub.docker.com/_/postgres) tabanlı Docker imajı ([dağıtım talimatlarına bakınız](https://docs.paradedb.com/deploy/aws))
- [CloudNativePG](https://artifacthub.io/packages/helm/cloudnative-pg/cloudnative-pg) tabanlı Kubernetes Helm chart ([dağıtım talimatlarına bakınız](https://docs.paradedb.com/deploy/helm))

Kurumsal özellikler ve destek dahil daha fazla bilgi için lütfen [bize e-posta ile ulaşın](mailto:sales@paradedb.com).

### Uzantılar

ParadeDB Postgres uzantıları için Debian 11, 12, Ubuntu 22.04 ve 24.04, Red Hat Enterprise Linux 8 ve 9, ve macOS 14 (Sonoma) ve 15 (Sequoia) için Postgres 14+ sürümlerine yönelik önceden derlenmiş ikili dosyaları [GitHub Releases](https://github.com/paradedb/paradedb/releases/latest) kısmında bulabilirsiniz.

ParadeDB, PostgreSQL Global Development Group tarafından desteklenen tüm sürümleri, yani PostgreSQL 14+’ı destekler ve uzantıları başka Postgres sürümleri için derlemek istiyorsanız, ilgili uzantının README dosyasındaki talimatları izleyebilirsiniz.

### Docker İmajı

ParadeDB örneğini hızlıca başlatmak için en güncel Docker imajını çekip çalıştırmanız yeterlidir:

```bash
docker run --name paradedb -e POSTGRES_PASSWORD=password paradedb/paradedb
```

Bu komut, varsayılan kullanıcı `postgres` ve şifre `password` ile bir ParadeDB örneği başlatır. Ardından veritabanına `psql` ile bağlanabilirsiniz:

```bash
docker exec -it paradedb psql -U postgres
```

ParadeDB’yi yerel veya şirket içinde kurmak için `docker-compose.yml` dosyamızı kullanmanızı öneririz. Alternatif olarak, `docker run` komutuna uygun ortam değişkenlerini ekleyerek <> alanlarını kendi istediğiniz değerlerle değiştirebilirsiniz:

```bash
docker run \
  --name paradedb \
  -e POSTGRES_USER=<kullanıcı> \
  -e POSTGRES_PASSWORD=<şifre> \
  -e POSTGRES_DB=<veritabanı_adı> \
  -v paradedb_data:/var/lib/postgresql/data/ \
  -p 5432:5432 \
  -d \
  paradedb/paradedb:latest
```

Bu komut, kök olmayan `<kullanıcı>` ve `<şifre>` ile bir ParadeDB örneği başlatır. `-v` bayrağı, ParadeDB verilerinizin `paradedb_data` isimli Docker hacminde kalıcı olmasını sağlar.

Daha sonra veritabanına `psql` ile şöyle bağlanabilirsiniz:

```bash
docker exec -it paradedb psql -U <kullanıcı> -d <veritabanı_adı> -p 5432 -W
```

### Helm Chart

ParadeDB, Helm chart ile Kubernetes üzerinde de kullanılabilir. Helm chart’ımızı [ParadeDB Helm Chart GitHub deposunda](https://github.com/paradedb/charts) bulabilir veya doğrudan [Artifact Hub](https://artifacthub.io/packages/helm/paradedb/paradedb) üzerinden indirebilirsiniz.

### ParadeDB Cloud

Şu anda ParadeDB, yönetilen bir bulut servisi olarak sunulmamaktadır. Bir ParadeDB Cloud hizmetiyle ilgileniyorsanız, lütfen [bekleme listemize](https://form.typeform.com/to/jHkLmIzx) katılarak bize bildirin.

## Destek

Eksik bir özellik mi arıyorsunuz ya da bir hata mı buldunuz? Lütfen bir
[GitHub Sorunu](https://github.com/paradedb/paradedb/issues/new/choose) açın.

Topluluk desteği almak için:

- [ParadeDB Slack Topluluğu](https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw) kanalına soru gönderebilirsiniz
- [GitHub Discussions](https://github.com/paradedb/paradedb/discussions) üzerinde yardım isteyebilirsiniz

Ticari destek ihtiyacınız varsa lütfen [ParadeDB ekibiyle iletişime geçin](mailto:sales@paradedb.com).

## Katkıda Bulunmak

Topluluk katkılarını, büyük ya da küçük, memnuniyetle karşılıyoruz ve size yol boyunca rehberlik etmeye hazırız. Katkıda bulunmaya başlamak için [ilk zamanlayıcı sorunlarımıza](https://github.com/paradedb/paradedb/labels/good%20first%20issue) göz atın veya [ParadeDB Community Slack](https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw) üzerinden bize yazın. Katkıda bulunduktan sonra Slack’te bize bildirin, size bazı ParadeDB hediyeleri gönderelim!

Katkı hakkında daha fazla bilgi için
[lütfen Katkı Rehberimizi](https://raw.githubusercontent.com/paradedb/paradedb/dev/CONTRIBUTING.md) inceleyin.

Bu proje, bir [Katılımcı Davranış Kuralları](https://raw.githubusercontent.com/paradedb/paradedb/dev/CODE_OF_CONDUCT.md) ile yayınlanmıştır.
Bu projeye katılarak kurallarına uymayı kabul etmiş olursunuz.

ParadeDB'yi herkes için daha iyi hale getirmemize yardımcı olduğunuz için teşekkür ederiz :heart:.

## Lisans

ParadeDB, [GNU Affero Genel Kamu Lisansı v3.0](https://raw.githubusercontent.com/paradedb/paradedb/dev/LICENSE) ve ticari yazılım olarak lisanslanmıştır. Ticari lisanslama için lütfen [sales@paradedb.com](mailto:sales@paradedb.com) adresiyle iletişime geçin.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---