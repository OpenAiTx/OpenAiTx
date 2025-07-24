
<div align="right">
  <details>
    <summary >🌐 ভাষা</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# Nothing but Nix

**আপোনাৰ GitHub Actions ৰানাৰক এটা [Nix](https://zero-to-nix.com/concepts/nix/) ❄️ শক্তিশালী মেশিনলৈ ৰূপান্তৰ কৰক, অপ্রয়োজনীয় প্ৰি-ইনষ্টল কৰা সফ্টৱেৰ নিষ্ঠুৰভাৱে আঁতৰাই।**

GitHub Actions ৰানাৰসমূহত Nix ৰ বাবে অতি কম ডিস্ক স্পেছ থাকে - মাত্ৰ ~20GB।
*Nothing but Nix* **নিৰ্মমভাৱে অপ্রয়োজনীয় ছফ্টৱেৰ আঁতৰায়**, যাৰ ফলত আপুনি আপোনাৰ Nix ষ্ট’ৰৰ বাবে **65GB ৰ পৰা 130GB** পাব! 💪

## ব্যৱহাৰ কৰা প্ৰণালী 🔧

আপোনাৰ ৱৰ্কফ্ল’ত Nix ইনষ্টল কৰাৰ **আগতে** এই এক্সনটো যোগ কৰক:

```yaml
jobs:
  build:
    runs-on: ubuntu-latest
    permissions:
      contents: read
      id-token: write
    steps:
      - uses: actions/checkout@v4
      - uses: wimpysworld/nothing-but-nix@main
      - name: Install Nix
        uses: DeterminateSystems/nix-installer-action@main
      - name: Run Nix
        run: |
          nix --version
          # Your Nix-powered steps here...
```

### আৱশ্যকতা ️✔️

- কেৱল চৰকাৰী **Ubuntu** GitHub Actions ৰানাৰসমূহ সমৰ্থন কৰে
- **Nix** ইনষ্টল হোৱাৰ আগতে চলিব লাগিব

## সমস্যাটো: Nix ৰ উন্নতিৰ বাবে ঠাই সৃষ্টি কৰা 🌱

স্টেণ্ডাৰ্ড GitHub Actions ৰানাৰসমূহ *"ব্ল'টৱেৰ"* এ ঠাসি ভৰ্তি, যিবোৰ আপুনি Nix ৱৰ্কফ্লোত কেতিয়াও ব্যৱহাৰ নকৰিব:

- 🌍 ৱেব ব্ৰাউজাৰ। বহুত। সকলো লাগিবই!
- 🐳 Docker ইমেজসমূহ, অমূল্য ডিস্ক স্পেছৰ গিগাবাইটবোৰ খাই পেলায়
- 💻 অপ্ৰয়োজনীয় ভাষা ৰানটাইমসমূহ (.NET, Ruby, PHP, Java...)
- 📦 পেকেজ মেনেজাৰসমূহ, ডিজিটেল ধূলি জমাই থকাসকল
- 📚 ডকুমেণ্টেশন, যি কেতিয়াও কোনোবাই পঢ়িব নোৱাৰে

এই ব্ল'টৰ ফলত আপোনাৰ Nix ষ্ট'ৰৰ বাবে কেৱল ~20GB ঠাই থাকে - গম্ভীৰ Nix বিল্ডৰ বাবে যথেষ্ট নহয়! 😞

## সমাধান: কেৱল Nix ️❄️

**Nothing but Nix** GitHub Actions ৰানাৰসমূহত ভয়ংকৰভাৱে ডিস্ক স্পেছ উদ্ধাৰ কৰিবলৈ দুই পৰ্যায়ৰ আক্ৰমণৰে এক "scorched-earth" পদ্ধতি গ্ৰহণ কৰে:

1. **প্ৰাথমিক ছ্লেছ:** তৎক্ষণাৎ `/mnt` ৰ ফ্ৰী স্পেছ দাবী কৰি বৃহৎ `/nix` ভলিউম (~65GB) সৃষ্টি কৰে
2. **পটভূমিত ৰেম্পেজ:** আপোনাৰ ৱৰ্কফ্লো চলি থাকোতেই, আমি অপ্ৰয়োজনীয় ছফ্টৱেৰ নিষ্ঠুৰভাৱে ডিলিট কৰি আপোনাৰ `/nix` ভলিউম ~130GBলৈ বৃদ্ধি কৰোঁ
   - ৱেব ব্ৰাউজাৰ? নহয় ⛔
   - Docker ইমেজ? গ’ল 🗑️
   - ভাষা ৰানটাইম? ধ্বংস 💥
   - পেকেজ মেনেজাৰ? সম্পূৰ্ণ নিঃশেষ 💣
   - ডকুমেণ্টেশন? উধাও ️👻

ফাইল চিষ্টেম পৰিষ্কাৰক কাম কৰে `rmz` ( [Fast Unix Commands (FUC)](https://github.com/SUPERCILEX/fuc) প্ৰজেক্টৰ পৰা) - `rm`-ৰ তুলনাত উচ্চ-পাৰফৰ্মেন্স, যিয়ে স্পেছ উদ্ধাৰক বিষয়ে অত্যন্ত দ্ৰুত গতি প্ৰদান কৰে! ⚡
   - স্টেণ্ডাৰ্ড `rm`-তকৈ বহু গুণ দ্ৰুত
   - অধিক কার্যকৰিতাৰ বাবে সমান্তৰালভাৱে ডিলিট কৰে
   - **কিছু ছেকেণ্ডত ডিস্ক স্পেছ উদ্ধাৰ!** ️⏱️

অন্তিম ফলাফল? **65GB ৰ পৰা 130GB** Nix-ৰ বাবে প্রস্তুত GitHub Actions ৰানাৰ! 😁

### ডাইনামিক ভলিউম বৃদ্ধি

অন্যান্য সমাধানসমূহতকৈ বেলেগকৈ, **Nothing but Nix** আপোনাৰ `/nix` ভলিউম ডাইনামিকভাৱে বৃদ্ধি কৰে:

1. **প্ৰাথমিক ভলিউম সৃষ্টি (১-১০ ছেকেণ্ড):** (*Hatchet Protocol অনুসৰি*)
   - `/mnt`-ৰ ফ্ৰী স্পেছৰ পৰা এক লুপ ডিভাইচ সৃষ্টি কৰে
   - RAID0 কনফিগাৰেচনত BTRFS ফাইল চিষ্টেম সাজে
   - কম্প্ৰেছন আৰু পাৰফৰ্মেন্স টিউনিং সহ মাউণ্ট কৰে
   - পৰিষ্কাৰ আৰম্ভ হোৱাৰ আগতেই 65GB `/nix` তৎক্ষণাৎ প্ৰদান কৰে

2. **পটভূমি সম্প্রসাৰণ (৩০-১৮০ ছেকেণ্ড):** (*Hatchet Protocol অনুসৰি*)
   - পৰিষ্কাৰ অভিযান চলায়
   - ব্ল’ট অপসাৰিত হোৱাৰ লগে লগে নতুন স্পেছ মনিটৰ কৰে
   - `/nix` ভলিউমত এক্সপানচন ডিস্ক ডাইনামিকভাৱে যোগ কৰে
   - নতুন স্পেছ অন্তর্ভুক্ত কৰিবলৈ ফাইলচিষ্টেম ৰিবেলেন্স কৰে

আপোনাৰ ৱৰ্কফ্লো চলাৰ সময়ত `/nix` ভলিউম **স্বয়ংক্ৰিয়ভাৱে বৃদ্ধি পায়** 🎩🪄

### আপোনাৰ অস্ত্ৰ বাচক: Hatchet Protocol 🪓

`hatchet-protocol` ইনপুটৰ সহায়ত ধ্বংসৰ স্তৰ নিয়ন্ত্ৰণ কৰক 💥:

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    hatchet-protocol: 'cleave'  # Options: holster, carve, cleave (default), rampage
```

#### প্ৰট’কল তুলনা ⚖️

| প্ৰট’কল   | `/nix` | বিৱৰণ                                              | apt পৰিষ্কাৰ | docker পৰিষ্কাৰ | snap পৰিষ্কাৰ | পৰিষ্কাৰ কৰা ফাইল চিস্টেম     |
|----------|--------|-----------------------------------------------------|--------------|----------------|--------------|-------------------------------|
| Holster  | ~৬৫GB  | হেঠাৰ হাতিয়াৰ ৰাখক, `/mnt` ৰ পৰা ঠাই ব্যৱহাৰ কৰক  | নহয়         | নহয়           | নহয়         | একো নহয়                    |
| Carve    | ~৮৫GB  | `/` আৰু `/mnt` ৰ ফ্ৰী ঠাই মিলাই সাজু কৰক           | নহয়         | নহয়           | নহয়         | একো নহয়                    |
| Cleave   | ~১১৫GB | ডাঙৰ পেকেজত শক্তিশালী, নিৰ্ণায়ক কাট কৰা            | অতি কম       | হয়            | হয়           | `/opt` আৰু `/usr/local`       |
| Rampage  | ~১৩০GB | সকলো অপ্রয়োজনীয় জোৰদাৰভাৱে, নিৰ্মমভাৱে আঁতৰাও    | আক্রমণাত্মক   | হয়            | হয়           | মুআহাহাহা! 🔥🌎               |

বিচাৰকৈ বাছনি কৰক:
- **Holster** ব্যৱহাৰ কৰক যেতিয়া ৰানাৰৰ সকলো টুল সম্পূৰ্ণ কাৰ্যক্ষম থকাৰ প্ৰয়োজন
- **Carve** ব্যৱহাৰ কৰক যেতিয়া ৰানাৰৰ টুল সংৰক্ষণ কৰি Nix ৰ বাবে সকলো ফ্ৰী ঠাই বিচাৰে
- **Cleave** (*ডিফল্ট*) ব্যৱহাৰ কৰক ঠাই আৰু কার্যক্ষমতাৰ উত্তম সমন্বয়ৰ বাবে
- **Rampage** ব্যৱহাৰ কৰক যেতিয়া আপুনি অধিকতম Nix ঠাই বিচাৰে আৰু কি ভাঙে তাত পৰোয়া নকৰে `#nix-is-life`

### হত্যাকাণ্ডৰ সাক্ষী হওক 🩸

ডিফল্টভাৱে, পৰিষ্কাৰ প্ৰক্ৰিয়া আপোনাৰ ৱর্কফ্লো চলি থাকোঁতে পটভূমিত নিৰৱে সম্পাদিত হয়। কিন্তু আপোনি যদি বাস্তৱ সময়ত এই নাশাল দেখিব বিচাৰে:

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    ️hatchet-protocol: 'cleave'
    witness-carnage: true  # Default: false
```

### নিৰাপদ আশ্ৰয়বোৰ কাষ্টমাইজ কৰক 🛡️

নিক্স ষ্টোৰৰ স্থান অধিকাৰ পৰা কিমান অংশ অব্যাহতি দিব সেইটো কাষ্টম নিৰাপদ আশ্ৰয়ৰ আকাৰৰ জৰিয়তে নিয়ন্ত্ৰণ কৰক:

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    ️hatchet-protocol: 'cleave'
    root-safe-haven: '3072'   # Reserve 3GB on the / filesystem
    mnt-safe-haven: '2048'    # Reserve 2GB on the /mnt filesystem
```
এইবোৰ সুৰক্ষিত স্থানসমূহে নিৰ্ধাৰণ কৰে যে স্থান পুনৰুদ্ধাৰৰ সময়ত কিমান স্থান (MB-ত) দয়াপূৰ্বক সংৰক্ষিত থাকিব:
- ডিফল্ট `root-safe-haven` হৈছে 2048MB (2GB)
- ডিফল্ট `mnt-safe-haven` হৈছে 1024MB (1GB)

আপোনাৰ ফাইলচিষ্টেমত অধিক খালি ঠাইৰ প্ৰয়োজন হ’লে এই মানবোৰ বৃদ্ধি কৰক, বা ক্ৰুৰতা দেখাবলে কমাই দিয়ক! 😈

### /nix ৰ ব্যৱহাৰকাৰী মালিকানা প্ৰদান কৰক (Nix অনুমতি আদেশ) 🧑‍⚖️

কিছুমান Nix ইনষ্টলাৰ বা সংৰচনাই আশা কৰে যে `/nix` ডিৰেক্টৰীটো বৰ্তমান ব্যৱহাৰকাৰীয়ে লিখিব পৰা হ’ব লাগে। ডিফল্টভাৱে, `/nix` ৰ মালিক হৈছে root। যদি আপুনি ব্যৱহাৰকাৰী মালিকানা প্ৰয়োজন কৰে (উদাহৰণস্বৰূপে, কিছুমান Nix ইনষ্টলাৰ স্ক্ৰিপ্টৰ বাবে যিবোৰে `/nix` ৰ ভিতৰত সকলো কাৰ্যকলাপৰ বাবে `sudo` ব্যৱহাৰ নকৰে), তেন্তে আপুনি `nix-permission-edict` সক্ৰিয় কৰিব পাৰে:


```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    nix-permission-edict: true  # Default: false
```

যেতিয়া `nix-permission-edict` ক `true` হিচাপে ছেট কৰা হয়, একশনটোৱে `/nix` মাউন্ট কৰাৰ পাছত `sudo chown -R "$(id --user)":"$(id --group)" /nix` চলাব।

এতিয়া সেই গৌৰৱময় Nix ষ্টোৰ স্পেচৰ সৈতে কিছু আশ্চৰ্য্যকৰ বস্তু নিৰ্মাণ কৰক! ❄️

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---