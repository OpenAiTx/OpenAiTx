
<div align="right">
  <details>
    <summary >🌐 ভাষা</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=en">ইংৰাজী</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=zh-CN">সৰল চীনা</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=zh-TW">প্ৰচলিত চীনা</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ja">জাপানী</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ko">কোৰিয়ান</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=hi">হিন্দী</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=th">থাই</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=fr">ফ্ৰেঞ্চ</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=de">জাৰ্মান</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=es">স্পেনী</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=it">ইটালীয়</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ru">ৰাছিয়ান</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=pt">পৰ্তুগীজ</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=nl">ডাচ</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=pl">পোলিশ</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ar">আৰবী</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=fa">ফাৰ্সী</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=tr">তুৰ্কী</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=vi">ভিয়েতনামী</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=id">ইণ্ডোনেশীয়</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# cq - CSV ফাইলৰ বাবে উচ্চ-ক্ৰিয়া SQL অনুসন্ধান ইঞ্জিন

 [![Cross-Build and Test (with zig build system)](https://github.com/baldimario/cq/actions/workflows/build-zig-cross.yml/badge.svg)](https://github.com/baldimario/cq/actions/workflows/build-zig-cross.yml)

এখন হালধীয়া, দ্ৰুত SQL অনুসন্ধান প্ৰসেছৰ যি C-ত লিখা হৈছে আৰু CSV ফাইলসমূহত ডাটাবেছৰ প্ৰয়োজন নোহোৱাকৈ SQL অনুসন্ধান চলাবলৈ সক্ষম। সম্পূৰ্ণ নথিপত্রৰ বাবে, /doc ডিৰেক্টৰি চাওক।

 ![cq ব্যৱহাৰত](https://raw.githubusercontent.com/baldimario/cq/main/assets/cq.png)

## নথিপত্ৰ

- আৰম্ভণি: `doc/GettingStarted.md`
- স্থাপন: `doc/Installation.md`
- কমাণ্ড লাইন ইণ্টাৰফেচ: `doc/CLI.md`
- **TUI (টার্মিনেল ইউজাৰ ইণ্টাৰফেচ)**: `doc/TUI.md`
- স্থাপত্য: `doc/Architecture.md`
- পৰীক্ষা: `doc/Testing.md`
- ৰোডমেপ: `doc/Roadmap.md`
- অৱদান: `doc/Contributing.md`

## তৎপৰ আৰম্ভণি

নির্মাণ: `make`

### কমাণ্ড লাইন

এটা নমুনা কুৱেৰী চলাও:
`./build/cq -q "SELECT name, age FROM 'data.csv' WHERE age > 25" -p`

### টাৰ্মিনেল UI

ইন্টাৰেক্টিভ TUI আৰম্ভ কৰক:
`./build/cqtui data/`

বৈশিষ্ট্যসমূহ:
- CSV ফাইলবোৰ টেবুল হিচাপে ব্ৰাউজ আৰু খুলিব পাৰে
- SQL কুৱেৰীসমূহ ইন্টাৰেক্টিভ ভাৱে চলাব পাৰে
- একাধিক টেবুলৰ বাবে মাল্টি-ট্যাব ইণ্টাৰফেচ
- কীবোৰ্ডৰ দ্বাৰা নেভিগেশ্যন
- বাহ্যিক নিৰ্ভৰতা নাই

## উদাহৰণ SQL ফাইলসমূহ

ৰিপজিটৰীত assets/ ত উদাহৰণ SQL সংৰক্ষিত আছে (example_between.sql, example_aggregation.sql, আদি)। অধিক তথ্যৰ বাবে assets/ চাওক।

## ডাটা & বৈশিষ্ট্যসমূহৰ সংক্ষিপ্ত বিবৰণ

- ডাটা টাইপ, তাৰিখৰ ফৰ্মেট, CSV ফৰ্মেট আৰু অন্যান্যৰ বিস্তারিত অংশৰ বাবে /doc ফোল্ডাৰ চাওক।

## লাইচেঞ্চ




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-28

---