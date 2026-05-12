<div align="right">
  <details>
    <summary >🌐 ভাষা</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=zh-CN">সৰল চীনা</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=zh-TW">পৰম্পৰাগত চীনা</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=ja">জাপানী</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=ko">কোৰিয়ান</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=hi">হিন্দী</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=th">থাই</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=fr">ফ্ৰেঞ্চ</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=de">জাৰ্মান</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=es">স্পেনিছ</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=it">ইটালিয়ান</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=ru">ৰাছিয়ান</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=pt">পৰ্তুগীজ</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=nl">ডাচ</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=pl">প'লিছ</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=ar">আৰবী</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=fa">ফাৰ্চী</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=tr">তুৰ্কী</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=vi">ভিয়েটনামী</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=id">ইণ্ডোনেছিয়ান</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

<div align="center" width="100%">
    <img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/upstat.png" width="128" alt="" />
</div>

# আপষ্টেট

> সহজ আৰু ব্যৱহাৰযোগ্য স্ব-হোষ্টেড স্থিতি মনিটৰিং টুল


![](https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/dashboard.png)

## 💻 লাইভ ডেম’ 

চেষ্টা কৰক।

ডেম’ ছাৰ্ভাৰ (অৱস্থান: ছিংগাপুৰ): [https://demo.upstat.com](https://upstat.chamanbudhathoki.com.np/)

ইউজাৰনেম: `demo`
পাছৱাৰ্ড: `demodemo`

## ⭐ বৈশিষ্ট্যসমূহ

অধিক বৈশিষ্ট্যৰ প্ৰয়োজন আছে, কিন্তু বৰ্তমানৰ বাবে...

- HTTP(s) ৰ বাবে আপটাইম মনিটৰিং
- ষ্টেটাছ আৰু লেটেন্সি চাৰ্ট
- Discord ৰ জৰিয়তে নটিফিকেশ্যন
- ৬০ ছেকেণ্ড ইণ্টাৰভেল
- চিত্তাকর্ষক, প্ৰতিক্ৰিয়াশীল, দ্ৰুত UI/UX
- বহুবিধ ষ্টেটাছ পৃষ্ঠা
- নিৰ্দিষ্ট ড’মেইনৰ সৈতে ষ্টেটাছ পৃষ্ঠা মেপ কৰক
- পিং চাৰ্ট
- চাৰ্টিফিকেট তথ্য
- PWA
- Sqlite আৰু Postgres ডাটাবেছ সমৰ্থন

আৰু বহুতো সৰু বৈশিষ্ট্য যোগ হ’বলৈ বাকী আছে।

## 🔧 কেনেকৈ ইন্সটল কৰিব

### 🐳 ডকৰ

Sqlite ৰ বাবে

```bash
curl https://raw.githubusercontent.com/chamanbravo/upstat/main/docker-compose-sqlite.yml -o docker-compose.yml
docker compose up
```

পোস্টগ্ৰেছৰ বাবে

```bash
curl -O https://raw.githubusercontent.com/chamanbravo/upstat/main/docker-compose.yml
docker compose up
```

Upstat এতিয়া http://localhost:3000 ত চলি আছে

> [!IMPORTANT]
> ডিপ্লয় কৰাৰ আগতে পৰিৱেশ মূল্যসমূহ সলনি কৰা নিশ্চিত কৰক।

### 💪🏻 নন-ডকৰ

আৱশ্যকতা:

- Node.js 14 / 16 / 18 / 20.4
- npm 9
- Golang 1.21+
- Postgres (ঐচ্ছিক)

```shell
cp .sample.env .env
```

```shell
air
cd web && npm run dev
```

## টেক ষ্ট্যাক

- React
- Shadcn
- Golang
- Postgres/Sqlite

## 🙌 অৱদান

মই অৱদানৰ স্বাগতম জনাইছোঁ! অৱদানবোৰেই মুক্ত উৎস কমিউনিটিক এনে আশ্চৰ্য্যজনক ঠাই কৰি তোলে য'ত শিকিব, অনুপ্ৰাণিত হ'ব আৰু সৃষ্টি কৰিব পাৰি। আপুনি কৰা যিকোনো অৱদান **বহুত মূল্যবান**।

আপোনাৰ কোনো পৰামৰ্শ থাকিলে যি এই প্ৰকল্পক উন্নত কৰিব পাৰে, অনুগ্ৰহ কৰি ৰেপ'টো ফৰ্ক কৰক, পৰিৱর্তন কৰক আৰু এটা পুল অনুৰোধ সৃষ্টি কৰক। আপুনি "enhancement" টেগৰ সৈতে এটা ইস্যু খুলি দিবও পাৰে।
প্ৰকল্পক এটা ষ্টাৰ দিব নাপাহৰিব! পুনৰ ধন্যবাদ!

1. প্ৰকল্পটো Fork কৰক
2. আপোনাৰ Feature Branch সৃষ্টি কৰক (`git checkout -b feature/AmazingFeature`)
3. আপোনাৰ পৰিৱর্তন Commit কৰক (`git commit -m 'Add some AmazingFeature'`)
4. শাখাত Push কৰক (`git push origin feature/AmazingFeature`)
5. এটা Pull Request খুলক

## অৱদানকাৰীসকল

<a href="https://github.com/chamanbravo/upstat/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=chamanbravo/upstat" />
</a>

## 📄 লাইচেঞ্চ

এই প্ৰকল্পটো [MIT লাইচেঞ্চ](https://opensource.org/license/mit/)ৰ অধীনত লাইচেঞ্চ কৰা হৈছে।

## 🖼 অধিক স্ক্ৰীনচট

এটা মনিটৰ সৃষ্টি কৰক

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/create.png" width="512" alt="" />

মনিটৰ পৃষ্ঠা

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/chart.png" width="512" alt="" />

Settings Page

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/settings.png" width="512" alt="" />

Notifications

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/notifications.png" width="512" alt="" />

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/discord_notification.png" width="512" alt="" />


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-12

---