
<div align="right">
  <details>
    <summary >🌐 ভাষা</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=en">ইংৰাজী</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=zh-CN">সৰল চীনা</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=zh-TW">জটিল চীনা</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=ja">জাপানী</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=ko">কোৰিয়ান</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=hi">হিন্দী</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=th">থাই</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=fr">ফৰাচী</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=de">জাৰ্মান</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=es">স্পেনিছ</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=it">ইটালিয়ান</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=ru">ৰাছিয়ান</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=pt">পৰ্তুগীজ</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=nl">ডাচ</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=pl">পোলিশ</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=ar">আৰবী</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=fa">ফাৰ্ছি</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=tr">তুৰ্কী</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=vi">ভিয়েটনামী</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=id">ইণ্ডোনেচিয়ান</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=as">অসমীয়া</
      </div>
    </div>
  </details>

</div>

# টাৰ্মিনাৰা

[![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/luyiourwong/Terminara)
![Python support](https://img.shields.io/badge/Python-3.10%20%7C%203.11%20%7C%203.12%20%7C%203.13-blue)

এটা টাৰ্মিনেল-ভিত্তিক ai অনুকৰণ গেম।

## ব্যৱহাৰ কৰিবলৈ কেনেকৈ

আপুনি [সৰ্বশেষ মুক্তি](https://github.com/luyiourwong/Terminara/releases/latest) ৰ পৰা এক্সিকিউটেবল এপ্লিকেশ্যন ডাউনলোড কৰিব পাৰে।

পূৰ্ণ সংকুচিত ফাইলত এক্সিকিউটেবল ফাইল আৰু ডিফল্ট ৱৰ্ল্ড ছেটিংছ ফাইল থাকে। আপুনি কেৱল এক্সিকিউটেবল ফাইল ডাউনলোড কৰিব পাৰে যদি গেমটো নতুন সংস্কৰণলৈ আপডেট কৰিছে।

| অপাৰেটিং ছিষ্টেম | সংস্কৰণ                                               |
|------------------|-------------------------------------------------------|
| Windows          | Windows 10, Windows 11                                |
| Linux            | (GLIBC 2.35+) Ubuntu 22.04 LTS, Ubuntu 24.04 LTS      |
| MacOS            | macOS 13, macOS 14, macOS 15, macOS 26                |

<details>
<summary><strong>ম্যানুৱেলভাৱে চলাওক</strong></summary>

### স্থাপন

1.  **ৰেপ’জিট’ৰী ক্লোন কৰক:**
    ```bash
    git clone https://github.com/luyiourwong/Terminara
    cd Terminara
    ```

2.  **এটা ভাৰ্চুৱেল পৰিবেশ সৃষ্টি কৰক:**
    ```bash
    python -m venv .venv
    source .venv/bin/activate
    ```
    Windows-ত `.venv\Scripts\activate` ব্যৱহাৰ কৰক

3.  **নির্ভৰশীলবোৰ স্থাপন কৰক:**
    ```bash
    pip install -e .
    ```

### আৰম্ভণি পদ্ধতি ১: সংস্থাপন কৰা আদেশ ব্যৱহাৰ কৰি (প্ৰস্তাৱিত)
সংস্থাপন শেষ হোৱাৰ পিছত, খেলটো চলাবলৈ এইটো ব্যৱহাৰ কৰক:
```bash
terminara
```

### আৰম্ভ কৰক পদ্ধতি ২: প্ৰত্যক্ষ ৰূপে সম্পাদন
প্লেটফৰ্ম-স্বতন্ত্ৰ উপায়
```bash
python -m terminara.main
```
or
```bash
python terminara/main.py
```
Windows-ত, `terminara\main.py` ব্যৱহাৰ কৰক

অধিক তথ্যৰ বাবে, [অংগ্ৰহণ কৰক আৰু বিকাশ গাইড](https://raw.githubusercontent.com/luyiourwong/Terminara/main/CONTRIBUTING.md) চাওক।
</details>

## AI সংস্থাপন

এপ্লিকেশ্বন আৰম্ভ কৰাৰ পিছত, আপোনাৰ AI ছেটিংছ মূল মেনুৰ পৰা সংহত কৰিব লাগিব।

![AI Settings](https://raw.githubusercontent.com/luyiourwong/Terminara/main/docs/assets/ai_settings.png)

আপোনি তলত উল্লেখ কৰা ক্ষেত্ৰসমূহ পূৰণ কৰিব লাগিব: (OpenAI Compatibility API)
- **Host**: API endpoint। ডিফল্ট OpenAI endpoint ব্যৱহাৰ কৰিবলৈ ফাক ৰাখক।
- **API Key**: AI সেৱাৰ বাবে আপোনাৰ API কী।
- **Model**: আপোনি ব্যৱহাৰ কৰিব বিচৰা মডেল।

ছেটিংছ সংৰক্ষণ কৰিবলৈ "Apply"ত ক্লিক কৰক।

### উদাহৰণসমূহ

#### ১. [OpenAI](https://platform.openai.com/) (ডিফল্ট)
- **Host**: (ফাক ৰাখক)
- **API Key**: `YOUR_OPENAI_API_KEY`
- **Model**: `gpt-4o-mini-2024-07-18`

#### ২. [Google AI Studio](http://aistudio.google.com/)
- **Host**: `https://generativelanguage.googleapis.com/v1beta/openai/`
- **API Key**: `YOUR_GEMINI_API_KEY`
- **Model**: `gemini-2.0-flash`

## World সংস্থাপন

### সংহতি সংৰক্ষণ
World ছেটিংছ `terminara/data/worlds` ডাইৰেক্টৰীত সংৰক্ষিত হয়। (সম্পূৰ্ণ সংস্কৰণত)
```
.
|-- terminara/
|   `-- data/
|       |-- schema/           # Json schema files for world settings
|       `-- worlds/           # Directory for world setting files
`-- terminara_platform_version        # Executable file
```

### নতুন এখন বিশ্ব সৃষ্টি কৰা
এটা উদাহৰণ বিশ্ব [aethelgard.json](https://raw.githubusercontent.com/luyiourwong/Terminara/main/terminara/data/worlds/aethelgard.json) উপলব্ধ। আপুনি [schema](https://raw.githubusercontent.com/luyiourwong/Terminara/main/terminara/data/schema/world_schema.json) অনুসৰণ কৰি নতুন বিশ্ব সৃষ্টি কৰিব পাৰে।

## লিংকসমূহ

- [GitHub Pages](https://luyiourwong.github.io/Terminara)
- [GitHub Repository](https://github.com/luyiourwong/Terminara)
- [অংশগ্ৰহণ আৰু উন্নয়ন গাইড](https://raw.githubusercontent.com/luyiourwong/Terminara/main/CONTRIBUTING.md)

## লাইচেন্স

এই প্ৰকল্পটো [MIT License](LICENSE) অনুযায়ী লাইচেন্সকৃত।


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-26

---