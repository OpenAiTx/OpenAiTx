
<div align="right">
  <details>
    <summary >🌐 ভাষা</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=en">ইংৰাজী</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=zh-CN">চিনীয়া (সৰলীকৃত)</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=zh-TW">চিনীয়া (প্ৰচলিত)</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=ja">জাপানী</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=ko">কোৰিয়ান</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=hi">হিন্দী</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=th">থাই</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=fr">ফ্ৰেঞ্চ</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=de">জাৰ্মান</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=es">স্পেনিছ</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=it">ইটালিয়ান</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=ru">ৰাছিয়ান</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=pt">পৰ্তুগীজ</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=nl">ডাচ</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=pl">প’লিশ</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=ar">আৰবী</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=fa">ফাৰ্চী</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=tr">তুৰ্কী</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=vi">ভিয়েটনামী</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=id">ইন্দোনেছিয়ান</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# SimpleLogin

এইটো হৈছে [SimpleLogin](https://simplelogin.io) ৰ বাবে এটা স্ব-হোষ্টেড ডকৰ-কম্প'জ কনফিগাৰেচন।

## প্ৰয়োজনীয় সামগ্ৰীসমূহ

- এটা লিনাক্স ছাৰ্ভাৰ (VM বা ডেডিকেটেড ছাৰ্ভাৰ যিকোনো এটা)। এই নথিপত্ৰত Ubuntu 18.04 LTS ৰ বাবে ছেটআপ দেখুওৱা হৈছে, কিন্তু বাকী জনপ্ৰিয় লিনাক্স ডিষ্ট্ৰিবিউচনসমূহৰ বাবে এই পদক্ষেপসমূহৰ ৰূপান্তৰ সম্ভৱ। অধিকাংশ কম্প’নেন্ট ডকৰ কণ্টেইনাৰ হিচাপে চলি থাকিব লাগে আৰু ডকৰ অলপ বেছি ৰিছ’ৰ্চ খাই, সেয়া মনত ৰাখি, কমেও 2 GB RAM থকাটো পৰামৰ্শ দিয়া হৈছে। ছাৰ্ভাৰটোত 25 (ইমেইল), 80, 443 (ৱেবএপৰ বাবে), 22 (ssh কৰিবলৈ) পোৰ্টসমূহ খোলা থকাটো প্ৰয়োজন।

- এটা ডোমেইন য'ত আপুনি DNS কনফিগাৰ কৰিব পাৰে। এইটো এটা ছাব-ডোমেইন হ’ব পাৰে। এই নথিৰ বাকী অংশত, ইমেইলৰ বাবে আমি `mydomain.com` আৰু SimpleLogin ৱেবএপৰ বাবে `app.mydomain.com` ধৰি ল’ম। অনুগ্ৰহ কৰি এই মানবোৰ আপোনাৰ ডোমেইন আৰু ছাবডোমেইনৰ নামৰে প্ৰতিস্থাপন কৰক যেতিয়া-যেতিয়া এই নথিত দেখা পায়। এটা উপায় হৈছে এই README ফাইলটো আপোনাৰ কম্পিউটাৰত ডাউনলোড কৰি সকলো `mydomain.com` আৰু `app.mydomain.com` স্থানত আপোনাৰ ডোমেইন প্রতিস্থাপন কৰা।

DNS ছেটআপ বাদে, যি সাধাৰণতে আপোনাৰ ডোমেইন ৰেজিষ্ট্ৰাৰ ইণ্টাৰফেচত কৰা হয়, তলৰ সকলো পদক্ষেপ আপোনাৰ চাৰ্ভাৰত কৰিব লাগিব। এই নিৰ্দেশবোৰ `bash` (অথবা `zsh` যেনে যিকোনো bash-অনুকূল shell) shell-এ চলাব লাগিব। যদি আপুনি `fish` যেনে অন্য shell ব্যৱহাৰ কৰে, অনুগ্ৰহ কৰি নিৰ্দেশবোৰ মানানসই কৰি ল’ব।

- ছেটআপ যাচাই কৰিবলৈ ব্যৱহাৰ হোৱা কিছুমান ইউটিলিটি পেকেজ। এইবোৰ ইনষ্টল কৰিবলৈ:

```bash
sudo apt update \
  && sudo apt install -y net-tools dnsutils
```

## DNS কনফিগাৰেচন

_অধিক তথ্যৰ বাবে [reference documentation](https://github.com/springcomp/self-hosted-simplelogin/wiki/DNS-Configuration) চাওক_

> **অনুগ্ৰহ কৰি মনত ৰাখক** DNS পৰিবর্তনবোৰ প্ৰসাৰিত হ'বলৈ ২৪ ঘণ্টা লৈ পাৰে। বাস্তৱত, ই বহুত দ্ৰুত হয় (~১ মিনিটৰ ভিতৰত আমাৰ পৰীক্ষাত)। DNS ছেটআপত, আমি সাধাৰণতে domainৰ শেষত dot (`.`) লগাই absolute domain ব্যৱহাৰ কৰিবলৈ বাধ্য কৰোঁ।

আপুনি নিম্নলিখিত DNS ৰেকৰ্ডবোৰ ছেটআপ কৰিব লাগিব:

- **A**: আপোনাৰ domainক আপোনাৰ serverৰ IPv4 ঠিকনাৰ সৈতে সংযোগ কৰে।
- **AAAA**: আপোনাৰ domainক আপোনাৰ serverৰ IPv6 ঠিকনাৰ সৈতে সংযোগ কৰে।
- **MX**: আহি থকা ইমেইলবোৰক আপোনাৰ mail serverলৈ নিৰ্দেশ কৰে (`*` wildcards সহ)।
- **PTR**: আপোনাৰ serverৰ IP ঠিকনাক পুনৰ আপোনাৰ domain নামৰ সৈতে সংযোগ কৰে।

আৱশ্যকীয় সুৰক্ষা নীতি ছেটআপ কৰক:

- **DKIM**: বাহিৰলৈ যোৱা ইমেইলবোৰ ডিজিটেলি চাইন কৰে প্ৰমাণিকতাৰ বাবে।
- **DMARC**: ইমেইল গ্ৰহণকাৰীসকলে authenticationত অসফল হোৱা মেছেজবোৰ কেনেকৈ হেণ্ডল কৰিব, সংজ্ঞা দিয়ে।
- **SPF**: আপোনাৰ domainৰ পৰা ইমেইল পঠিয়াবলৈ নির্দিষ্ট mail serverসমূহক অনুমোদন কৰে।

অতিৰিক্ত পদক্ষেপ:

- **CAA**: ক’ন certificate authorityসমূহক SSL certificate ইস্যু কৰিবলৈ অনুমতি দিয়ে।
- **MTA-STS**: mail serverসমূহৰ মাজত সুৰক্ষিত, encrypted সংযোগ নিশ্চিত কৰে।
- **TLS-RPT**: TLS সংযোগ বিফল হোৱাৰ প্ৰতিবেদন দিয়ে ইমেইল ডেলিভাৰী সুৰক্ষাৰ বাবে।

**সতৰ্কবাণী**: CAA ৰেকৰ্ড ছেটআপ কৰিলে কোন certificate authority আপোনাৰ domainৰ বাবে SSL certificate সফলভাৱে ইস্যু কৰিব পাৰিব, সীমিত কৰিব।
এইটো Let’s Encrypt staging serverসমূহৰ পৰা certificate ইস্যু হওঁতে বাধা দিব। আপোনাৰ domainৰ বাবে SSL certificate সফলভাৱে ইস্যু হোৱাৰ পিছত এই DNS ৰেকৰ্ডটো ছেটআপ কৰা ভাল।

## Docker

আপোনাৰ serverত Docker ইনষ্টল কৰা নাছিল, তেন্তে অনুগ্ৰহ কৰি [Docker CE for Ubuntu](https://docs.docker.com/v17.12/install/linux/docker-ce/ubuntu/)ত উল্লেখ কৰা পদক্ষেপ অনুসৰণ কৰি Docker ইনষ্টল কৰক।

আপুনি [docker-install](https://github.com/docker/docker-install) script ব্যৱহাৰ কৰি Docker ইনষ্টল কৰিব পাৰে যি

```bash
curl -fsSL https://get.docker.com | sh
```

ডিফল্ট ব্রিজ নেটৱৰ্কৰ বাবে IPv6 সক্ৰিয় কৰক [the default bridge network](https://docs.docker.com/config/daemon/ipv6/#use-ipv6-for-the-default-bridge-network)

```json
{
  "ipv6": true,
  "fixed-cidr-v6": "2001:db8:1::/64",
  "experimental": true,
  "ip6tables": true
}
```
এই প্ৰক্ৰিয়াটোৱে আপোনাক সমগ্ৰ ষ্টেকটো Docker কণ্টেইনাৰৰ সহায়ত চলোৱাৰ পথ প্ৰদৰ্শন কৰিব।
ইয়াত অন্তর্ভুক্ত:

- traefik
- [SimpleLogin app](https://github.com/simple-login/app) কণ্টেইনাৰসমূহ
- postfix

Docker কণ্টেইনাৰৰ পৰা SimpleLogin চলাওক:

1. এই ৰিপ’জিটৰি খন `/opt/simplelogin`-ত ক্লোন কৰক
1. `.env.example` কপি কৰি `.env` নামান্তৰ কৰক আৰু উপযুক্ত মানসমূহ সংহতি কৰক।

    - `DOMAIN` ভেৰিয়েবলটো আপোনাৰ ড’মেইনত সংহতি কৰক।
    - `SUBDOMAIN` ভেৰিয়েবলটো আপোনাৰ ড’মেইনত সংহতি কৰক। ডিফল্ট মান হৈছে `app`।
    - `POSTGRES_USER` ভেৰিয়েবলটো postgres চহি-পত্ৰৰ সৈতে মিলাওক (নতুনকৈ আৰম্ভ কৰিলে, `simplelogin` ব্যৱহাৰ কৰক)।
    - `POSTGRES_PASSWORD` ভেৰিয়েবলটো postgres চহি-পত্ৰৰ সৈতে মিলাওক (নতুনকৈ আৰম্ভ কৰিলে, এটি যিকোনো এলোমেলো কী সংহতি কৰক)।
    - `FLASK_SECRET` ভেৰিয়েবলটো যিকোনো গোপন কী সংহতি কৰক।

### Postgres SQL

এই ৰিপ’জিটৰি খনে Docker কণ্টেইনাৰত এখন postgres SQL চলায়।

**সাৱধানবাণী**: এই ৰিপ’জিটৰিৰ আগৰ সংস্কৰণসমূহে `12.1` সংস্কৰণ চলাইছিল।
অনুগ্ৰহ কৰি অধিক তথ্য আৰু
উন্নীতকৰণ নিৰ্দেশাবলীৰ বাবে [reference documentation](https://github.com/springcomp/self-hosted-simplelogin/wiki/PostgreSQL) চাওক।

### এপ্লিকেশ্বন চলোৱা

তলত দিয়া নিৰ্দেশনাবলী অনুসৰি এপ্লিকেশ্বনটো চলাওক:


```sh
docker compose up --detach --remove-orphans --build && docker compose logs -f
```

এই পৰ্যায়ত আপুনি [Certificate Authority Authorization (CAA)](https://github.com/springcomp/self-hosted-simplelogin/wiki/dns-caa) সংস্থাপন কৰিব বিচাৰিব পাৰে।

## পৰৱৰ্তী পদক্ষেপসমূহ

যদি ওপৰৰ সকলো পদক্ষেপ সফল হয়, তেন্তে <https://app.mydomain.com/> খোলক আৰু আপোনাৰ প্ৰথম একাউণ্টটো সৃষ্টি কৰক!

ডিফ’ল্ট স্বৰূপে, নতুন একাউণ্টসমূহ প্ৰিমিয়াম নহয়, সেয়া অৰ্থাৎ অসীম সংখ্যক উপনাম নাই। আপোনাৰ একাউণ্টটো প্ৰিমিয়াম কৰিবলৈ,
অনুগ্ৰহ কৰি ডাটাবেছলৈ যাওক, "users" টেবুলত "lifetime" কলামটো "1" নাইবা "TRUE" লৈ ছেট কৰক:

```bash
docker compose exec -it postgres psql -U myuser simplelogin
> UPDATE users SET lifetime = TRUE;
> \q
```

আপুনি আপোনাৰ সকলো প্ৰয়োজনীয় লগইন একাউণ্ট সৃষ্টি কৰি উঠিলেহি, `.env`-ত এই শাৰীসমূহ যোগ কৰক যাতে আগৰ পৰা অধিক পঞ্জীয়ন বন্ধ কৰিব পাৰে:

```env
DISABLE_REGISTRATION=1
DISABLE_ONBOARDING=true
```
তাৰ পিছত, ৱেব এপ্প পুনৰ আৰম্ভ কৰিবলৈ, এইটো প্ৰয়োগ কৰক: `docker compose restart app`

## বিবিধ

### Postfix কনফিগাৰেচন - Spamhaus

Spamhaus Project এ SPAM উৎসৰূপে চিনাক্ত হোৱা IP ঠিকনাৰ এটি নিৰ্ভৰযোগ্য তালিকা সংৰক্ষণ কৰে।
DNS অবকাঠামোত অনুসন্ধান জমা দিয়াৰ মাধ্যমে আপুনি কোনো IP ঠিকনা সেই তালিকাত আছে নে নাই চাব পাৰে।

Spamhaus এ জনসাধাৰণ (খোলা) DNS-Resolvers ৰ পৰা অহা অনুসন্ধানসমূহ ব্লক কৰে (চাওক: <https://check.spamhaus.org/returnc/pub>) আৰু আপোনাৰ postfix কনটেইনাৰে
ডিফল্ট ৰূপে জনসাধাৰণ resolver ব্যৱহাৰ কৰিব পাৰে, সেয়ে বিনামূলীয়া
[Spamhaus Data Query Service](https://www.spamhaus.com/free-trial/sign-up-for-a-free-data-query-service-account/)
ৰ বাবে চাইন আপ কৰাৰ আৰু Spamhaus DQS চাবি লাভ কৰাৰ পৰামৰ্শ দিয়া হৈছে।

এই চাবিটো আপোনাৰ `.env` ত `SPAMHAUS_DQS_KEY` হিচাপে পেষ্ট কৰক

যদি কোনো DQS-চাবি প্ৰদান কৰা নহয়, তেন্তে আপোনাৰ postfix কনটেইনাৰে Spamhaus ৰ জনসাধাৰণ মিৰৰসমূহে অনুসন্ধান গ্ৰহণ কৰিছে নে নাই চাব আৰু সেইবোৰ ব্যৱহাৰ কৰিব।
যদি Spamhaus এ জনসাধাৰণ মিৰৰসমূহলৈ আপোনাৰ postfix কনটেইনাৰৰ অনুসন্ধান প্ৰত্যাখ্যান কৰে, তেন্তে সম্পূর্ণৰূপে নিষ্ক্ৰিয় হব।

### Postfix কনফিগাৰেচন - Virtual aliases

postfix কনফিগাৰেচনে `postfix/conf.d/virtual` আৰু `postfix/conf.d/virtual-regexp` ফাইল ব্যৱহাৰ কৰি virtual aliases সমৰ্থন কৰে।
এই ফাইলসমূহ আৰম্ভণিত স্বয়ংক্ৰিয়ভাৱে সৃষ্টি হয় সংশ্লিষ্ট [`postfix/templates/virtual.tpl`](https://raw.githubusercontent.com/springcomp/self-hosted-simplelogin/main/./postfix/templates/virtual.tpl)
আৰু [`postfix/templates/virtual-regexp.tpl`](https://raw.githubusercontent.com/springcomp/self-hosted-simplelogin/main/./postfix/templates/virtual-regexp.tpl) টেমপ্লেট ফাইলসমূহৰ আধাৰত।

ডিফল্ট কনফিগাৰেচন এইদৰে:

#### virtual.tpl

`virtual` ফাইলটি postfix `virtual_alias_maps` ছেটিং সমৰ্থন কৰে।
ই `unknown@mydomain.com` ক `contact@mydomain.com` ত মেপ কৰা এটি নিয়ম অন্তৰ্ভুক্ত কৰে, যাতে দেখুৱায়
যে কোনো নিৰ্দিষ্ট ঠিকনাৰ পৰা অহা আৰু বিদ্যমান alias ৰ সৈতে মিল নোহোৱা ইমেইল অন্য এটাত গ্ৰহণ কৰা যায়।


```postfix-conf
unknown@mydomain.com  contact@mydomain.com
```

#### virtual-regexp.tpl

`virtual-regexp` ফাইলটোৱে postfix ৰ `virtual_alias_maps` ছেটিংসমূহ সমৰ্থন কৰে।
এইটোত এনে এটা নিয়ম থাকে যি যিকোনো অৱৈধ উপডোমেইনলৈ পঠিওৱা ইমেইলসমূহ পুনৰ লিখে,
যি এটা অস্তিত্ব থকা এলিয়াছৰ সৈতে মিল নাখায়, এক নতুন এলিয়াছলৈ যি উপডোমেইনৰ পৰা নাম লোৱা এটা ডাইৰেক্টৰীত অন্তৰ্ভুক্ত।
সেই এলিয়াছটো, যদি আগতে নাছিল, তেন্তে স্বয়ংক্ৰিয়ভাৱে সৃষ্টি কৰিব পৰা যায়।

```postfix-conf
/^([^@]+)@([^.]+)\.mydomain.com/   $2/$1@mydomain.com
```

উদাহৰণস্বৰূপে, `someone@directory.mydomain.com` লৈ পঠিওৱা ইমেইলসমূহ postfix দ্বাৰা `directory/someone@mydomain.com` ত ৰাউট কৰা হ’ব।

## 3.4.0 ৰ পৰা আপগ্ৰেড কেনেকৈ কৰিব

_এই অংশটো [reference documentation](https://github.com/springcomp/self-hosted-simplelogin/wiki/upgrade-sl) ত স্থানান্তৰ কৰা হৈছে_

## পূর্বৰ NGinx-ভিত্তিক ছেটআপৰ পৰা আপগ্ৰেড কেনেকৈ কৰিব

_এই অংশটো [reference documentation](https://github.com/springcomp/self-hosted-simplelogin/wiki/upgrade-from-nginx) ত স্থানান্তৰ কৰা হৈছে_


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-15

---