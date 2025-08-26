
<div align="right">
  <details>
    <summary >🌐 ভাষা</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# OCI2Git

এখন ৰাষ্ট (Rust) এপ্লিকেচন যি কণ্টেইনাৰ ইমেজ (Docker, আদিৰ) Git ৰিপ’জিটৰিত ৰূপান্তৰ কৰে। প্রতিটো কণ্টেইনাৰ স্তৰ Git কমিট হিচাপে প্ৰতিনিধিত্ব কৰে, মূল ইমেজৰ ইতিহাস আৰু গঠন সংৰক্ষণ কৰি।

![OCI2Git-এ nginx ইমেজ ৰূপান্তৰ কৰাৰ ডেমো](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/nginx.gif)

## বৈশিষ্ট্যসমূহ

- ডকাৰ ছবি বিশ্লেষণ কৰক আৰু স্তৰৰ তথ্য উলিয়াওক
- এটা গিট ৰেপ'জিট'ৰি সৃষ্টি কৰক য'ত প্ৰতিটো ছবি স্তৰক এটা কমিট হিচাপে উপস্থাপন কৰা হৈছে
- খালী স্তৰৰ (ENV, WORKDIR, আদি) বাবে খালী কমিটৰ সমৰ্থন
- সম্পূৰ্ণ মেটাডেটা Markdown ৰূপত উলিওৱা
- বিভিন্ন কন্টেইনাৰ ইঞ্জিনৰ সমৰ্থনৰ বাবে বিস্তৃত স্থাপত্য

## ব্যৱহাৰৰ ক্ষেত্ৰসমূহ

### স্তৰ তুলনা (Layer Diffing)
কন্টেইনাৰ সমস্যাৰ সমাধান কৰোঁতে, গিটৰ শক্তিশালী তুলনা (diffing) সক্ষমতা ব্যৱহাৰ কৰি যিকোনো দুটা স্তৰৰ মাজত ঠিক কি পৰিবর্তন হৈছে চিহ্নিত কৰিব পাৰে। `git diff` চলাই কমিটসমূহৰ মাজত ইঞ্জিনিয়াৰসকলে ঠিক কোন ফাইল যোগ, সংশোধন, বা মচি পেলোৱা হৈছে চাব পাৰে, যিয়ে প্ৰতিটো Dockerfile নিৰ্দেশনাৰ প্ৰভাৱ বুজিবলৈ আৰু সমস্যাজনক পৰিবর্তন বিচাৰি পাবলৈ অধিক সহজ কৰে।
![স্তৰ তুলনাৰ উদাহৰণ](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/layer-diff.png)

### উত্স অনুসৰণ (Origin Tracking)
`git blame` ব্যৱহাৰ কৰি, ডেভেলপাৰসকলে তৎক্ষণাত চাব পাৰে কোন স্তৰে নিৰ্দিষ্ট ফাইল বা কোডৰ শাৰী যোগ কৰিছে। এইটো বিশেষভাৱে মূল্যবান হয় কনফিগাৰেচন ফাইল বা নির্ভৰশীলতাসমূহৰ সমস্যাৰ নিৰ্ণয় কৰোঁতে। প্ৰতিটো স্তৰ হাতে হাতে পৰীক্ষা কৰাৰ সলনি, আপুনি যিকোনো ফাইলৰ উত্স স্তৰ আৰু সংশ্লিষ্ট Dockerfile নিৰ্দেশনালৈ তৎক্ষণাত অনুসৰণ কৰিব পাৰে।

### ফাইল জীৱনচৰ্যা অনুসৰণ (File Lifecycle Tracking)
OCI2Git এ আপোনাক এটা নিৰ্দিষ্ট ফাইলৰ কন্টেইনাৰ ছবিৰ ইতিহাসত যাত্ৰা অনুসৰণ কৰিবলৈ সক্ষম কৰে। আপুনি চাব পাৰে ফাইলটো কেতিয়া সৃষ্টি হৈছিল, কেনেদৰে স্তৰসমূহত সংশোধন হৈছিল, আৰু যদি/যেতিয়া অন্ততঃ মচি পেলোৱা হৈছিল। এই বিস্তৃত দৃশ্যই ফাইলৰ বিকাশ বুজিবলৈ সহায় কৰে, বহু স্তৰৰ মাজত পৰিবর্তন হাতে হাতে অনুসৰণ কৰাৰ প্ৰয়োজন নোহোৱাকৈ।

আপোনাৰ কন্টেইনাৰ ছবিত এটা ফাইলৰ ইতিহাস অনুসৰণ কৰিবলৈ — কেতিয়া প্ৰথম দেখা পাইছিল, পৰিবর্তিত হৈছিল, অথবা মচি পেলোৱা হৈছিল — ৰূপান্তৰৰ পাছত এই গিট কমাণ্ডসমূহ ব্যৱহাৰ কৰিব পাৰে:

```bash
# Full history of a file (including renames)
git log --follow -- /rootfs/my/file/path

# First appearance (i.e. creation) - see which layer introduced the file
git log --diff-filter=A -- /rootfs/my/file/path

# All changes made to the file (with diffs)
git log -p --follow -- /rootfs/my/file/path

# When the file was deleted
git log --diff-filter=D -- /rootfs/my/file/path

# Show short commit info (concise layer history)
git log --follow --oneline -- /rootfs/my/file/path
```

এই আদেশবোৰে যিকোনো ফাইলৰ সম্পূৰ্ণ ইতিহাসক কন্টেইনাৰ স্তৰৰ মাজেৰে সহজে অনুসৰণ কৰিবলৈ সক্ষম কৰে, স্তৰৰ টাৰবলসমূহ ম্যানুৱেলিভাৱে উলিয়াই তুলনা কৰাৰ জটিলতা নাথাকে।

### বহু-স্তৰ বিশ্লেষণ
কেতিয়াবা আটাইতকৈ গুৰুত্বপূর্ণ তুলনাবোৰ বহু অপৰ্যায়ী স্তৰৰ পৰিৱর্তন পৰীক্ষা কৰাৰ পৰা আহে। OCI2Git ব্যৱহাৰ কৰি, আপোনোৱে Git ৰ তুলনামূলক টুলসমূহ ব্যৱহাৰ কৰি বহু নিৰ্মাণ স্তৰৰ মাজত উপাদানসমূহ কেনেদৰে বিকাশ হৈছে বিশ্লেষণ কৰিব পাৰে, যি ধৰণৰ ধাৰণা কেৱল সংলগ্ন স্তৰৰ ক্ষেত্ৰত দেখিবলৈ নোৱাৰা।

### স্তৰ অন্বেষণ
`git checkout` ব্যৱহাৰ কৰি যিকোনো নিৰ্দিষ্ট কমিটলৈ গতি কৰিলে, আপুনি কন্টেইনাৰৰ ফাইল চিস্টেম ঠিক সেই স্তৰত যিদৰে আছিল পৰীক্ষা কৰিব পাৰে। এইটো ডেভেলপাৰসকলক ছবিৰ সৃষ্টি প্ৰক্ৰিয়াৰ যিকোনো বিন্দুত ফাইল আৰু ডাইৰেক্টৰীৰ নিৰ্দিষ্ট অৱস্থা পৰীক্ষা কৰিবলৈ সক্ষম কৰে, যি ডিবাগিং বা কন্টেইনাৰৰ আচৰণ পৰীক্ষা কৰোঁতে অমূল্য প্ৰেক্ষাপট যোগান ধৰিছে।
![পূৰ্বৰ কমিটলৈ চেকআউট](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/checkout.png)

### বহু-ছবি বিশ্লেষণ

যেতিয়া একাধিক কন্টেইনাৰ ছবিত সাধাৰণ বংশধৰ থাকে, OCI2Git কেৱল ছবিসমূহ প্ৰকৃততে বিভাজিত হ'লে ব্রাঞ্চ সৃষ্টি কৰে। এইটো আপোনাক একেটা ৰেপজিটৰিত বহু সম্পৰ্কিত ছবি বিশ্লেষণ কৰিবলৈ সক্ষম কৰে আৰু তেওঁলোকৰ সাধাৰণ ইতিহাস সংৰক্ষণ কৰে।

```bash
# Convert first image to create the base repository
oci2git postgres:16.9-alpine3.21 -o alp

# Convert second image to the same output folder
oci2git nginx:1.28.0-alpine-slim -o alp
```

OCI2Git স্বয়ংক্ৰিয়ভাৱে ছবিসমূহৰ মাজত ভাগ বতৰা হোৱা স্তৰসমূহ চিনাক্ত কৰে আৰু তেওঁলোকৰ সাধাৰণ ভিত্তি প্ৰতিফলিত কৰা এক শাখা কাঠামো সৃষ্টি কৰে। Git ইতিহাসত দেখুওৱা হ'ব:
- সকলো ভাগ বতৰা হোৱা স্তৰসমূহৰ সৈতে এটি সাধাৰণ মূল শাখা
- পৃথক শাখাসমূহ যি কেৱল ছবিসমূহ বাস্তৱিকভাৱে ভিন্ন হ'লে মাত্ৰ বিভক্ত হয়
- ছবিসমূহে ক'ত সাধাৰণ বংশানুক্ৰম ভাগ বতৰা কৰিছে আৰু ক'ত তেওঁলোকে অনন্য হৈ পৰিছে তাৰ স্পষ্ট ভিজুৱালাইজেশ্বন
- বুদ্ধিমান নকল ব্যৱস্থাপনা: একেবাৰেই একে ছবি দুবাৰ প্ৰক্ৰিয়াকৰণ হ'লে, এলগৰিদমে চূড়ান্ত মেটাডাটা কমিটৰ আগতে এইটো চিনাক্ত কৰে আৰু নকল শাখা সৃষ্টি কৰা এৰি দিয়ে

এই পদ্ধতি বিশেষকৈ মূল্যবান:
- **ছবি পৰিয়াল বিশ্লেষণ**: এটা ছবিৰ বিভিন্ন ভেৰিয়েন্ট (বিভিন্ন সংস্কৰণ, স্থাপত্য, বা কনফিগাৰেশ্বন) কেনেকৈ একে আনৰ সৈতে সম্পৰ্কিত তাৰ বুজ
- **ভিত্তি ছবিৰ প্ৰভাৱ**: ভিত্তি ছবিত সলনি কৰিলে বহুতো উদ্ভূত ছবিত কিদৰে প্ৰভাৱ পেলায় সেয়া স্পষ্টকৈ দেখা
- **অপ্টিমাইজেশ্বন সুযোগ**: ভাগ বতৰা হোৱা উপাদানসমূহ চিনাক্ত কৰা যি ছবিৰ ভেৰিয়েন্টসমূহৰ মাজত ভালদৰে ব্যৱহাৰ কৰিব পাৰি

![ভাগ বতৰা হোৱা ভিত্তি আৰু বিভক্ত শাখাসমূহ দেখুওৱা বহু-ছবি ৰিপ'জিট'ৰি গঠন](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/multiimage.png)

### অতিৰিক্ত ব্যৱহাৰ ক্ষেত্ৰ

- **সুৰক্ষা অডিটিং**: সংৱেদনশীল পেকেজ বা কনফিগাৰেশ্বন কেতিয়া অন্তর্ভুক্ত হৈছিল ঠিক চিনাক্ত কৰা আৰু বিশেষ নিৰ্মাণ নিৰ্দেশনাসমূহলৈ উল্টাই পোৱা।
- **ছবি অপ্টিমাইজেশ্বন**: স্তৰৰ গঠন বিশ্লেষণ কৰি অপ্রয়োজনীয় অপাৰেশ্বন বা ডাঙৰ ফাইল চিনাক্ত কৰা, যি সংহত কৰি ছবিৰ আকাৰ কমাব পাৰে।
- **নির্ভৰশীলতা ব্যৱস্থাপনা**: ছবি ইতিহাসত নিৰ্ভৰশীলতা কেতিয়া যোগ, উন্নীত, বা আঁতৰ কৰা হৈছে মনিটৰ কৰা।
- **নির্মাণ প্ৰক্ৰিয়া উন্নতি**: স্তৰৰ সংযোজন পৰীক্ষা কৰি Dockerfile নিৰ্দেশনাসমূহ অপ্টিমাইজ কৰি ভাল ক্যাচিং আৰু সৰু ছবি আকাৰ নিশ্চিত কৰা।
- **আলাদা ছবিৰ তুলনা**: বহুতো সম্পৰ্কিত ছবিক Git ৰিপ'জিট'ৰিলৈ ৰূপান্তৰ কৰা আৰু Git ৰ তুলনা টুল ব্যৱহাৰ কৰি তফাৎ আৰু সাধাৰণতা বিশ্লেষণ কৰা।

## ইনষ্টলেশ্বন

### উৎসৰ পৰা

```bash
# Clone the repository
git clone https://github.com/virviil/oci2git.git
cd oci2git

# Install locally
cargo install --path .
```

### Crates.io ৰ পৰা

```bash
cargo install oci2git
```

## ব্যৱহাৰ

```bash
oci2git [OPTIONS] <IMAGE>
```

আৰ্গুমেন্টসমূহ:
  `<IMAGE>`  ৰূপান্তৰ কৰিবলৈ ছবি নাম (উদাহৰণস্বৰূপে, 'ubuntu:latest') অথবা টাৰ ইঞ্জিন ব্যৱহাৰ কৰাৰ সময়ত টাৰবলৰ পথ

বিকল্পসমূহ:
  `-o, --output <o>`  গিট ৰেপ'জিটৰীৰ বাবে আউটপুট ডাইৰেক্টৰি [ডিফল্ট: ./container_repo]
  `-e, --engine <ENGINE>`  ব্যৱহাৰ কৰিবলৈ কণ্টেইনাৰ ইঞ্জিন (docker, nerdctl, tar) [ডিফল্ট: docker]
  `-h, --help`            সহায় তথ্য ছাপ কৰক
  `-V, --version`         সংস্কৰণ তথ্য ছাপ কৰক

পৰিবেশ ভেৰিয়েব্‌লসমূহ:
  `TMPDIR`  ইন্টাৰমিডিয়েট ডাটা প্ৰসেছিংৰ বাবে ডিফল্ট স্থান সলনি কৰিবলৈ এই পৰিবেশ ভেৰিয়েব্‌লটো ছেট কৰক। এইটো প্লেটফৰ্ম-নির্ভৰ (উদাহৰণস্বৰূপে, ইউনিক্স/মেক'ত `TMPDIR`, উইণ্ড'জত `TEMP` বা `TMP`)।

## উদাহৰণসমূহ

ডকৰ ইঞ্জিন ব্যৱহাৰ কৰি (ডিফল্ট):
```bash
oci2git -o ./ubuntu-repo ubuntu:latest
```
আজি ডাউনলোড কৰা ইমেজ টাৰবল ব্যৱহাৰ কৰি:

```bash
oci2git -e tar -o ./ubuntu-repo /path/to/ubuntu-latest.tar
```

টাৰ ইঞ্জিনে এটা বৈধ OCI ফৰ্মেট টাৰবল আশা কৰে, যি সাধাৰণতে `docker save` ব্যৱহাৰ কৰি সৃষ্টি কৰা হয়:
```bash
# Create a tarball from a local Docker image
docker save -o ubuntu-latest.tar ubuntu:latest

# Convert the tarball to a Git repository
oci2git -e tar -o ./ubuntu-repo ubuntu-latest.tar
```

এইটো `./ubuntu-repo`-ত এটা Git ৰেপ'জিট'ৰি সৃষ্টি কৰিব:
- `Image.md` - Markdown ফৰ্মেটত চিত্ৰখনৰ সম্পূৰ্ণ মেটাডাটা
- `rootfs/` - কণ্টেইনাৰৰ পৰা ফাইলচিষ্টেমৰ সমগ্ৰ সামগ্ৰী

Git-ৰ ইতিহাসত কণ্টেইনাৰৰ লেয়াৰ ইতিহাস প্ৰদর্শিত হয়:
- প্ৰথম কমিটত কেৱল `Image.md` ফাইলটো থাকে, য'ত সম্পূৰ্ণ মেটাডাটা থাকে
- প্ৰতিটো পাছৰ কমিট মূল চিত্ৰৰ এটা লেয়াৰ প্ৰতিনিধিত্ব কৰে
- কমিটসমূহত Dockerfile-ৰ কমাণ্ড কমিট মেছেজ হিচাপে থাকে

## ৰেপ'জিট'ৰি গঠন

```
repository/
├── .git/
├── Image.md     # Complete image metadata
└── rootfs/      # Filesystem content from the container
```


## requirements

- ৰাষ্ট ২০২১ সংস্কৰণ
- ডকাৰৰ CLI (ডকাৰ ইঞ্জিন সমৰ্থনৰ বাবে)
- গিট

## অনুমতি পত্ৰ

MIT

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-26

---