
<div align="right">
  <details>
    <summary >🌐 ভাষা</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

[![Status](https://img.shields.io/badge/status-active-brightgreen)](https://github.com/seuusuario/wakeonweb)
[![License](https://img.shields.io/badge/license-MIT-blue)](LICENSE)

# আপোনাৰ LastFM

এখন কণ্টেইনাৰাইজড Node.js এপ্লিকেশ্যন যি **Last.fm**ৰ পৰা স্ক্ৰব্বলসমূহ ছিঙ্ক্ৰোনাইজ কৰে, সেইবোৰ স্থানীয় **SQLite** ডাটাবেচত সংৰক্ষণ কৰে, আৰু এটা ৱেব ডেছবোর্ডেৰে ছাৰ্ভ কৰে।

<img width="1718" height="1066" alt="image" src="https://github.com/user-attachments/assets/97d5a9f1-b39a-42ea-9acf-2b4546426a11" />
---

## প্ৰকল্প

**Your LastFM** এটা Node.js এপ্লিকেচন যি **স্বয়ংক্ৰিয়ভাৱে Last.fm ৰ পৰা সংগীত স্ক্ৰবল সমলয় কৰে**। ই আপোনাৰ শুনা সংগীতৰ ইতিহাস এখন স্থানীয় SQLite ডেটাবেছত সংৰক্ষণ কৰে আৰু তথ্য চিত্ৰাঙ্কনৰ বাবে এখন ৱেব ইণ্টাৰফেচ প্ৰদান কৰে।

এই প্ৰকল্পটো সম্পূৰ্ণৰূপে **Docker**ৰে কণ্টেইনাৰাইজ কৰা হৈছে, য'ত এটা স্বয়ংক্ৰিয় এণ্ট্ৰিপইণ্টে ডেটাবেছ আৰম্ভণি আৰু ক্ৰমাগত কাৰ্য্য (প্ৰথমে সমলয়, তাৰপিছত ৱেব API আৰম্ভ) সমলয় কৰে। ই কণ্টেইনাৰৰ ভিতৰত সেৱা সচল আৰু স্থিতিশীল ৰাখিবলৈ প্ৰক্ৰিয়া পৰিচালক হিচাপে **PM2** ব্যৱহাৰ কৰে।

## বৈশিষ্ট্যসমূহ
### ইন্টাৰেক্টিভ ৱেব ডেছবোর্ড

- আপোনাৰ সংগীত কাৰ্য্যকলাপ চিত্ৰাঙ্কনৰ বাবে পৰিষ্কাৰ, আধুনিক ৱেব ইণ্টাৰফেচ।

### স্বয়ংক্ৰিয় Last.fm স্ক্ৰবল সমলয়

- নিয়মিতভাৱে Last.fm ৰ পৰা আপোনাৰ শুনাৰ ইতিহাস (স্ক্ৰবল) আহৰণ আৰু সংৰক্ষণ কৰে।
- আপোনাৰ তথ্য সদায় আপডেট থাকে, কোনো মেনুৱেল কামৰ প্ৰয়োজন নাই।

### স্থানীয় সংগীত ইতিহাস ডেটাবেছ

- সকলো স্ক্ৰবল স্থানীয় SQLite ডেটাবেছত সংৰক্ষণ কৰে।
- দ্ৰুত অনুসন্ধান আৰু ইতিহাসৰ সংগীত ডেটাত অফলাইন এক্সেছ নিশ্চিত কৰে।

### সাম্প্ৰতিক স্ক্ৰবল দৃশ্য

- আপোনাৰ আটাইতকৈ সাম্প্ৰতিক সংগীতসমূহ দেখুৱায়।
- সংগীত, এলবাম, আৰু শিল্পীৰ বাবে বুদ্ধিমান ছবি বিকল্প যুক্তি।

### বন্ধু তুলনা (কম্পেটিবিলিটি দৃশ্য)

- Last.fm বন্ধুবোৰৰ সৈতে আপোনাৰ সংগীত ৰুচি তুলনা কৰক।
- কম্পেটিবিলিটি স্তৰ দেখুৱায় (অতি নিম্ন → অতি উন্নত)।
- সাধাৰণ শীৰ্ষ শিল্পী, এলবাম, আৰু সংগীতসমূহ দেখুৱায়।
- ৰিয়েল শুনাৰ তথ্যৰ ভিত্তিত কম্পেটিবিলিটি গণনা আৰু স্বাভাৱিকীকৰণ কৰে।

### শ্বেয়াৰ কৰিব পৰা সংগীত কাৰ্ড

- আপোনাৰ শুনাৰ তথ্যৰ ভিত্তিত ডাইনামিক ছবি সৃষ্টি কৰে।
- ফিড পোষ্ট আৰু ইনষ্টাগ্ৰাম ষ্টোৰী (9:16) ৰ বাবে উপযুক্ত লেআউট।

- চৰ্ভাৰ-পৃষ্ঠৰ ছবি ৰেণ্ডাৰিংৰ বাবে node-canvas ব্যৱহাৰ কৰি নিৰ্মিত।

## প্ৰাৰম্ভিক দাবীসমূহ

* [Docker](https://docs.docker.com/get-docker/)
* [Docker Compose](https://docs.docker.com/compose/install/)

## স্থাপন

### এটা `.env` ফাইল সৃষ্টি কৰক

```env
LASTFM_API_KEY=your_lastfm_api_key
LASTFM_USERNAME=your_lastfm_username
```

Last.fm: আপোনাৰ API Key পাবলৈ [ইয়াত](https://www.last.fm/api/account/create) এখন API একাউণ্ট সৃষ্টি কৰক।

### ডকৰ কম্প'জ

```yml
services:
  your-lastfm:
    image: gomaink/your-lastfm
    container_name: your-lastfm
    ports:
      - "1533:1533"
    env_file:
      - .env
    volumes:
      - ./data:/app/data
    restart: unless-stopped
```

টার্মিনেলত:
`docker compose up -d`

পিচত প্ৰৱেশ কৰক:
```
http://localhost:1533
```
(অথবা 'localhost'ক আপোনাৰ ছাৰ্ভাৰ IPৰ সৈতে পৰিৱর্তন কৰক)

## অনুজ্ঞাপত্ৰ

এই প্ৰকল্পটো MIT অনুজ্ঞাপত্ৰৰ অধীনত লাইচেঞ্চ কৰা হৈছে।



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-27

---