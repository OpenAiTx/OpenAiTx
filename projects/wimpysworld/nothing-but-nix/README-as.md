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

**আপোনাৰ GitHub Actions ৰানাৰক এটা [Nix](https://zero-to-nix.com/concepts/nix/) ❄️ শক্তিশালী ইঞ্জিনত ৰূপান্তৰ কৰক, আগতে সংস্থাপিত অনাবশ্যক ফাইলসমূহ নিষ্ঠুৰভাৱে আঁতৰাই।**

GitHub Actions ৰানাৰসমূহত Nix ৰ বাবে মাত্ৰ ~20GB ডিক্স স্থান উপলব্ধ।
*Nothing but Nix* **নিৰ্মমভাৱে অনাবশ্যক ছফ্টৱেৰ আঁতৰায়**, যাৰ ফলত আপোনাৰ Nix ষ্ট’ৰৰ বাবে **৬৫GBৰ পৰা ১৩০GB** পাব পাৰে! 💪

## ব্যৱহাৰ 🔧


আপোনাৰ workflow-ত Nix ইনস্টল কৰাৰ আগতে এই কাৰ্যটো **যোগ কৰক**:

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
### প্ৰয়োজনীয়তা ️✔️

- কেৱল চৰকাৰী **Ubuntu** GitHub Actions runner-সমূহক সমৰ্থন কৰে
- Nix স্থাপন কৰাৰ আগতে চলিব লাগে
- **macOS/Darwin runner-সমূহ**: এই action-এ macOS-ত চলিলে সতর্কতাৰে skip কৰে। macOS runner-সমূহে ইতিমধ্যে Nix-ৰ বাবে যথেষ্ট space প্ৰদান কৰে আৰু এই action-ৰ প্ৰয়োজন নাই
- **Windows runner-সমূহ**: এই action-এ Windows-ত চলিলে সতর্কতাৰে skip কৰে। Windows runner-সমূহৰ ফাইলচিস্টেম layout আৰু constraint আলাদা

## সমস্যা: Nix-ৰ বাবে স্থান তৈয়াৰ কৰা 🌱

GitHub Actions runner-সমূহত সাধাৰণতে *"bloatware"* থাকে যি Nix workflow-ত কেতিয়াও ব্যৱহাৰ নহয়:

- 🌍 Web browser-সমূহ। বহুতো। সকলো থাকিবই লাগিব!
- 🐳 Docker image-সমূহে মূল্যবান disk space gigabyte-এ খাই যায়
- 💻 অপ্রয়োজনীয় language runtime (.NET, Ruby, PHP, Java...)
- 📦 Package manager-সমূহে digital dust সংগ্ৰহ কৰে
- 📚 Documentation যি কেতিয়াও কোনোবাই নপঢ়িব

এই bloat-এ Nix store-ৰ বাবে কেৱল ~20GB মাত্ৰ থাকে - গম্ভীৰ Nix build-ৰ বাবে যথেষ্ট নহয়! 😞

## সমাধান: Nix-ৰ বাহিৰে কিছুমানো নহয় ️❄️

**Nix-ৰ বাহিৰে কিছুমানো নহয়** GitHub Actions runner-সমূহত শক্তিশালী disk space reclaim কৰিবলৈ দুটা phase-ৰ মাধ্যমে scorched-earth approach লৈছে:

1. **প্ৰাথমিক Slash:** তৎক্ষণাত `/mnt`-ৰ free space reclaim কৰি বৃহৎ `/nix` volume (~65GB) তৈয়াৰ কৰে
2. **Background Rampage:** আপোনাৰ workflow চলি থাকোতে, আমি অপ্রয়োজনীয় software-সমূহ নিষ্ঠুৰভাৱে নষ্ট কৰি `/nix` volume ~130GBলৈ বিস্তৃত কৰো
   - Web browser-সমূহ? নহয় ⛔
   - Docker image-সমূহ? শেষ 🗑️
   - Language runtime-সমূহ? ধ্বংস 💥
   - Package manager-সমূহ? উগ্ৰ 💣
   - Documentation? উৰাই দিয়া ️👻

File system purge `rmz`-এ powered ( [Fast Unix Commands (FUC)](https://github.com/SUPERCILEX/fuc) project-ৰ পৰা) - `rm`-ৰ উচ্চ-দক্ষতা বিকল্প যি space reclamation-এ অত্যন্ত দ্ৰুতগতি প্ৰদান কৰে! ⚡
   - সাধাৰণ `rm`-তকৈ বহুগুণে আগবাঢ়ে
   - Parallel-process-এ deletion-সমূহ efficiency-এ কৰে
   - **Disk space reclamation কিছুমান seconds-ত, minutes-ত নহয়!** ️⏱️

শেষ ফলাফল? GitHub Actions runner-ত **65GB ৰ পৰা 130GB** Nix-ready space! 😁

### Dynamic Volume Growth

অন্য সমাধানসমূহৰ তুলনাত, **Nothing but Nix** আপোনাৰ `/nix` ভলিউমটো ডাইনেমিকভাৱে বৃদ্ধি কৰে:

1. **প্ৰাৰম্ভিক ভলিউম সৃষ্টি (১-১০ ছেকেণ্ড):** (*Hatchet Protocol অনুসৰি*)
   - `/mnt` ত থকা মুক্ত স্থানৰ পৰা এটা লুপ ডিভাইচ সৃষ্টি কৰে
   - RAID0 কনফিগাৰেচনত এটা BTRFS ফাইলচিষ্টেম স্থাপন কৰে
   - কম্প্ৰেছন আৰু পাৰফৰ্মেন্স টিউনিঙৰ সৈতে মাউন্ট কৰে
   - পাছত পুৰ্জ আৰম্ভ হোৱাৰ আগতেই ৬৫GB `/nix` উপলব্ধ কৰে

2. **পটভূমি বিস্তাৰ (৩০-১৮০ ছেকেণ্ড):** (*Hatchet Protocol অনুসৰি*)
   - পুৰ্জ অভিযান সম্পাদন কৰে
   - অতিৰিক্ত বোজা আঁতৰোৱাৰ সময়ত মুক্ত হোৱা নতুন স্থান মনিটৰ কৰে
   - `/nix` ভলিউমত ডাইনেমিকভাৱে এটা বিস্তাৰ ডিস্ক যোগ কৰে
   - নতুন স্থান অন্তৰ্ভুক্ত কৰিবলৈ ফাইলচিষ্টেম ৰিবেলেন্স কৰে

`/nix` ভলিউমটো স্বয়ংক্ৰিয়ভাৱে **ওয়াৰ্কফ্লো চলা সময়ত বৃদ্ধি পায়** 🎩🪄

### আপোনাৰ অস্ত্ৰ বাছনি কৰক: The Hatchet Protocol 🪓

`hatchet-protocol` ইনপুট ব্যৱহাৰে ধ্বংসৰ স্তৰ নিয়ন্ত্ৰণ কৰক 💥:


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

যেতিয়া `nix-permission-edict` ক `true` হিচাপে ছেট কৰা হয়, এই কাৰ্যই `/nix` মাউণ্ট কৰাৰ পিছত `sudo chown -R "$(id --user)":"$(id --group)" /nix` চলাব।

### Nix ক /nix/build ব্যৱহাৰৰ বাবে সংৰূপ কৰক

এই কাৰ্যই Nix ডেৰিভেচন বিল্ডসমূহে পুনৰুদ্ধাৰ কৰা স্থান ব্যৱহাৰ কৰিবলৈ `/nix/build` সৃষ্টি কৰে। আপোনাৰ Nix সংৰূপত `build-dir` যোগ কৰক:

```yaml
- uses: cachix/install-nix-action@v31
  with:
    extra_nix_config: |
      build-dir = /nix/build
```
অথবা DeterminateSystemsৰ সৈতে:


```yaml
- uses: DeterminateSystems/nix-installer-action@main
  with:
    extra-conf: |
      build-dir = /nix/build
```

এইয়ে Nix ক বৃহৎ BTRFS ভলিউমত বিল্ড কৰিবলৈ নিৰ্দেশ দিয়ে, যাৰ ফলত ব্যৱস্থাৰ ডিফল্ট সাময়িক ডাইৰেক্টৰীত নহয়।

## সমস্যাৰ সমাধান 🔍

### ডাঙৰ বিল্ডৰ সময়ত "No space left on device"

যদি আপোনাৰ বিল্ডে ঠাই শেষ কৰে, যদিও Nothing but Nix ব্যৱহাৰ কৰিছে, তেন্তে সম্ভৱত পটভূমিত পুৰ্জিং শেষ হোৱা নাই, যাৰ আগতে আপোনাৰ বিল্ডে উপলব্ধ ঠাই খৰচ কৰিছে। এইটো সাধাৰণতে প্ৰভাৱিত কৰে:

- NixOS VM টেষ্ট যিয়ে ডাঙৰ ডিস্ক ইমেজ সংযোজন কৰে
- বহুতো ডিপেণ্ডেন্সিৰ সৈতে বিল্ড, যি কেশ্‌ড নহয়
- Rust টুলচেইন আৰু অন্যান্য ডাঙৰ কম্পাইলচন

**সমাধান:** `witness-carnage: true` ব্যৱহাৰ কৰক, যাতে সমলগ্ন পুৰ্জিং জোৰ কৰা হয়। এইয়ে নিশ্চিত কৰে যে সকলো ঠাই আপোনাৰ বিল্ড আৰম্ভ কৰাৰ আগতে পুনৰুদ্ধাৰ হয়:

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    hatchet-protocol: 'rampage'
    witness-carnage: true
```
এইটো আপোনাৰ ৱাৰ্কফ্ল' সেটআপত ৩০-১৮০ ছেকেণ্ড যোগ কৰে, কিন্তু আপোনাৰ বিল্ড আৰম্ভ হোৱাৰ সময়ত সর্বাধিক স্থান উপলব্ধ থাকিব বুলি নিশ্চিত কৰে।

এতিয়া সেই গৌৰৱময় Nix ষ্ট'ৰ স্পেছৰ সৈতে কিবা আশ্চৰ্যজনক নিৰ্মাণ কৰক! ❄️


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-18

---