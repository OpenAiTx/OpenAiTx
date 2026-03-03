
<div align="right">
  <details>
    <summary >🌐 ভাষা</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# ouch.yazi

[ouch](https://github.com/ouch-org/ouch) ৰ বাবে [Yazi](https://github.com/sxyazi/yazi) ৰ প্লাগইন।

![ouch.yazi](https://github.com/ndtoan96/ouch.yazi/assets/33489972/946397ec-b37b-4bf4-93f1-c676fc8e59f2)

## বৈশিষ্ট্যসমূহ
- আৰ্খাইভ পূৰ্বদৃশ্য
- সংকোচন

## স্থাপন

### Yazi পেকেজ মেনেজাৰ
```bash
ya pkg add ndtoan96/ouch
```

### Git
```bash
# Linux/macOS
git clone https://github.com/ndtoan96/ouch.yazi.git ~/.config/yazi/plugins/ouch.yazi

# Windows with cmd
git clone https://github.com/ndtoan96/ouch.yazi.git %AppData%\yazi\config\plugins\ouch.yazi

# Windows with powershell
git clone https://github.com/ndtoan96/ouch.yazi.git "$($env:APPDATA)\yazi\config\plugins\ouch.yazi"
```

আপুনি নিশ্চিত কৰক যে আপোনাৰ `PATH`-ত [ouch](https://github.com/ouch-org/ouch) ইনষ্টল কৰা আছে।

## ব্যৱহাৰ

### পূৰ্বদৃশ্য
আৰ্কাইভ পূৰ্বদৃশ্যৰ বাবে, এইটো আপোনাৰ `yazi.toml`-ত যোগ কৰক:

```toml
[[plugin.prepend_previewers]]
mime = "application/{*zip,tar,bzip2,7z*,rar,xz,zstd,java-archive}"
run  = "ouch"
```

এতিয়া Yazi-ত এখন সংৰক্ষণাগাৰত যাওক, আপুনি প্ৰিভিউ পেনত সংৰক্ষণাগাৰৰ বিষয়বস্তু চাব পৰা উচিত। আপুনি `J` আৰু `K` ব্যৱহাৰ কৰি প্ৰিভিউত ওপৰ-তললৈ স্ক্ৰল কৰিব পাৰে।

#### স্বনির্বাচন

প্ৰিভিউসমূহ `run` ষ্ট্ৰিঙত অতিৰিক্ত আৰ্গুমেন্ট যোগ কৰি স্বনির্বাচিত কৰিব পৰা যায়:

```toml
[plugin]
prepend_previewers = [
	# Change the top-level archive icon
	{ ..., run = "ouch --archive-icon='🗄️ '" },
	# Or remove it by setting it to ''
	{ ..., run = "ouch --archive-icon=''" },

	# Enable file icons
	{ ..., run = "ouch --show-file-icons" },

	# Disable tree view
	{ ..., run = "ouch --list-view" },

	# These can be combined
	{ ..., run = "ouch --archive-icon='🗄️ ' --show-file-icons --list-view" },
]
```

### সংকোচন
সংকোচনৰ বাবে, আপোনাৰ `keymap.toml`-ত এইটো যোগ কৰক:

```toml
[[mgr.prepend_keymap]]
on = ["C"]
run = "plugin ouch"
desc = "Compress with ouch"
```

প্লাগইনটো ডিফল্ট ৰূপত `zip` ফৰ্মেট ব্যৱহাৰ কৰে। আপুনি আউটপুট ফাইলটো নামাকৰণ কৰাৰ সময়ত ফৰ্মেটটো পৰিবৰ্তন কৰিব পাৰে, `ouch`-এ ফাইল এক্সটেনচনৰ ভিত্তিত ফৰ্মেট চিনাক্ত কৰিব।

উদাহৰণস্বৰূপে, যদি আপুনি `7z`ক ডিফল্ট ফৰ্মেট হিচাপে নিৰ্ধাৰণ কৰিব বিচাৰে, তেন্তে আপুনি `plugin ouch 7z` ব্যৱহাৰ কৰিব পাৰে।

### ডিকম্প্ৰেছন
এই প্লাগইনটোৱে ডিকম্প্ৰেছন সুবিধা প্ৰদান নকৰে কাৰণ ইয়াক Yazi-এ ইতিমধ্যে সমৰ্থন কৰিছে।
`ouch`ৰ সহায়ত ডিকম্প্ৰেছ কৰিবলৈ, `yazi.toml`ত ওপেনাৰ কনফিগাৰ কৰক।

```toml
[opener]
extract = [
	{ run = 'ouch d -y %*', desc = "Extract here with ouch", for = "windows" },
	{ run = 'ouch d -y "$@"', desc = "Extract here with ouch", for = "unix" },
]
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-03

---