
<div align="right">
  <details>
    <summary >🌐 ভাষা</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# 🎯 MT7902 ড্ৰাইভাৰ MT7921 ড্ৰাইভাৰৰ উপ-অংশ হিচাপে (✅ কাৰ্যকৰী)
Mediatek mt7902 wifi 6E চিপ ব্লুটুথ আৰু WiFi সমৰ্থন

> [!IMPORTANT]
> Linux 7.1 Kernel এ MT7902 WIFI 6E চিপক চৰকাৰিভাৱে সমৰ্থন কৰে


## 📁 ৰিপ'জিট'ৰি ক্লোন কৰা
ৰিপ'জিট'ৰি খন আপোনাৰ স্থানীয় পি.চি. ত ক্লোন কৰক
  ```
  git clone https://github.com/OnlineLearningTutorials/mt7902_temp
  ```
যদি আপুনি অতীত ইতিহাস ক্লোন কৰিব নোখোজে তেন্তে
  ```
  git clone --depth 1 https://github.com/OnlineLearningTutorials/mt7902_temp
  ```

## স্থাপন


### 🚀 স্থাপন পথপ্ৰদর্শক স্ক্ৰিপ্ট (Ubuntu আধাৰিত প্ৰণালীলৈ পৰামৰ্শিত)
স্ক্ৰিপ্টটো কাৰ্যক্ষম কৰক যদি ইতিমধ্যে নহয়
```
chmod +x ./install_guide.sh
```
এতিয়া এই স্ক্ৰিপ্টটো চলাও
```
./install_guide.sh
```
যেতিয়া প্ৰয়োজন হয় তেতিয়া ই স্বতঃস্ফূর্তভাৱে পাছৱাৰ্ডৰ বাবে অনুৰোধ জনাব
* এই স্ক্ৰিপ্টটোৱে আপোনাক ফাৰ্মৱেৰ, ব্লুটুথ আৰু ৱাইফাই ড্ৰাইভাৰ এটা এটাকৈ ইনষ্টল কৰিবলৈ সুধিব
* Ubuntu-ত linux 7.0 kernelৰে পৰীক্ষা কৰা হৈছে

### 🚀 সহজ স্বয়ংক্ৰিয় সমাধান (Arch ভিত্তিক ছিষ্টেমৰ বাবে সুপারিশ)
যদি আপুনি যিকোনো আধুনিক কৰ্ণেলত আপোনাৰ WiFi আৰু Bluetooth তাড়াতাড়ি ঠিক কৰিব বিচাৰে, তেন্তে এই পদক্ষেপসমূহ অনুসৰণ কৰক:

স্ক্ৰিপ্টটো এক্সিকিউটেবল কৰক যদি এতিয়ালৈকে কৰা নহয়
```
chmod +x ./fix_my_wifi.sh
```

**স্বয়ংক্ৰিয় ঠিকনা স্ক্ৰিপ্ট**টো sudoৰ সৈতে চলাও:
```bash
sudo bash fix_my_wifi.sh
```

#### 📖 এই স্ক্ৰিপ্টটো কি কৰে:
* **নির্ভৰশীলতা পৰীক্ষা কৰে:** নিশ্চিত কৰে যে আপোনাৰ ওচৰত `gcc`/`clang`, `make`, `bc`, আৰু আপুনি বৰ্তমান ব্যৱহাৰ কৰা `kernel-headers` ইনষ্টল আছে। যদি নাথাকে - তেন্তে আপোনাৰ পছন্দৰ পেকেজ মেনেজাৰে ইনষ্টল কৰে
* **ড্ৰাইভাৰ কম্পাইল কৰে:** আপোনাৰ এক্সেক্ট কৰ্ণেল সংস্কৰণৰ বাবে WiFi আৰু Bluetooth ড্ৰাইভাৰ দুয়োটাই স্বয়ংক্ৰিয়ভাৱে বিল্ড কৰে।
* **স্থায়ী সমাধান:** এটা ছিষ্টেম সেৱা ইনষ্টল কৰে যি আপোনাৰ WiFi ৰিস্টাৰ্টৰ পাছতো সচল ৰখাত সহায় কৰে।
* **নিরাপত্তা:** মডিউলসমূহ কাষ্টম ডিৰেক্টৰিত (`/lib/modules/mt7902_custom`) ইনষ্টল কৰে যাতে আপোনাৰ ডিফল্ট ছিষ্টেম ফাইলসমূহৰ লগত সমস্যা নঘটে।

> [!NOTE]
> আপোনাক প্ৰথমবাৰৰ বাবে এইটো চলোৱাৰ সময়ত ইণ্টাৰনেট সংযোগ (Ethernet বা আপোনাৰ ফোনৰ পৰা USB tethering) লাগিব, যাতে প্ৰয়োজনীয় বিল্ড টুলসমূহ ডাউনলোড কৰিব পাৰে। (যেনে: কম্পাইলেটৰ, linux-headers, আদিৰ বাবে)


## ✅ পৰীক্ষা কৰা হৈছে (যাচিতভাৱে কাম কৰে)
এই সমাধানটো পৰীক্ষা কৰা হৈছে আৰু নিশ্চিতভাৱে কাম কৰি আছে:

* **ব্ৰেণ্ড:** ASUS
* **মডেল:** Vivobook Go (E1404FA), Vivobook 14 (X1404ZA)
* **চিপচেট:** MediaTek MT7902 (WiFi 6E)
* **কৰ্ণেল সংস্কৰণ:** 6.19.0 (Linux), 6.19.11, 7.0.7
* **OS:** Arch, Ubuntu
* **পেকেজ মেনেজাৰ:** pacman, apt

## উপলব্ধ:
* **OS**: যিকোনো OS যি PM সমূহৰ এটা সমৰ্থন কৰে
* **পছন্দৰ পেকেজ মেনেজাৰ:** apt, pacman, dnf, zypper, nix-shell
* **কৰ্ণেল সংস্কৰণ:** 6.14-7.0.7


## 🔧 ব্যৱহৃত ফাৰ্মৱেৰসমূহ
ফাৰ্মৱেৰসমূহ `firmware` ফোল্ডাৰত সংৰক্ষিত আছে।


## 📱 Bluetooth ✅ (কাম কৰি আছে)
> [!WARNING]
> যদি Bluetooth ড্ৰাইভাৰে `gen4-mt7902`ৰ সৈতে সংঘাত কৰে তেন্তে অনুগ্ৰহ কৰি Bluetooth ফাৰ্মৱেৰটো আঁতৰাওক যাতে এই ড্ৰাইভাৰৰ সৈতে বিঘ্ন নঘটে
> ``` sudo rm /lib/firmware/mediatek/mt7902/BT_RAM_CODE_MT7902_1_1_hdr.bin.zst ```
> এই প্ৰজেক্টত ব্যৱহাৰ কৰা হৈছে ফাৰ্মৱেৰ
> ``` /lib/firmware/mediatek/BT_RAM_CODE_MT7902_1_1_hdr.bin.zst ```

Bluetooth সক্ৰিয় কৰিবলৈ আপোনাৰ বৰ্তমান কৰ্ণেল সংস্কৰণৰ ডিৰেক্টৰিত যাওক। ``
যদি আপোনাৰ কৰ্ণেল linux-6.16 তেন্তে `./linux-6.16/drivers/bluetooth` ডিৰেক্টৰিত যাওক।
এই ডিৰেক্টৰীত টাৰ্মিনেল খুলি `make` কমাণ্ডৰ সৈতে কম্পাইল কৰক।
দুটি কৰ্ণেল মডিউল কম্পাইল হয় `btusb.ko` আৰু `btmtk.ko`।
আপোনাৰ ডিভাইচত ব্লুটুথ সক্ৰিয় কৰিবলৈ আপোনাৰ প্ৰণালীৰ btusb আৰু btmtk আঁতৰাই এই দুটা ফাইল ইনষ্টল কৰক, কমাণ্ডসমূহ ব্যৱহাৰ কৰক
```
sudo rmmod btusb 
sudo rmmod btmtk

sudo insmod btmtk.ko
sudo insmod btusb.ko

```
এতিয়া আপোনাৰ ব্লুটুথটো কাম কৰি আছে নে নাই চাওক।

## 💻 ৱাইফাই ✅ (কাম কৰি আছে)
> [!IMPORTANT]
> কিছুমান সীমাবদ্ধতাৰ সৈতে এটা কাম কৰা ৰেপ' [এয়া](https://github.com/hmtheboy154/gen4-mt7902) ত আছে

mt7902 ৰ বাবে ৱাইফাই ড্ৰাইভাৰ, যি অলপতে mediatek এ মুক্তি দিছে, `latest` ফ'ল্ডাৰত আছে।

আপুনি যদি Ubuntu ব্যৱহাৰ কৰি আছে তেন্তে `latest` ফ'ল্ডাৰত যাওক আৰু তলত দিয়া নিৰ্দেশটো টাৰ্মিনেলত চলাওক।
```
make
```
ইয়াৰ দ্বাৰা সকলো মডিউল সংকলন কৰা হ'ব, কম্প্ৰেছ কৰা হ'ব আৰু ইনষ্টল কৰা হ'ব (মূল কৰ্ণেল মডিউলক সংশোধিত মডিউলেৰে প্ৰতিস্থাপন কৰা হ'ব)। যদি আপুনি আন কোনো ডিষ্ট্ৰ' হয় বা সকলো পদক্ষেপ নকৰিব বিচাৰে আৰু কেৱল কোড সংকলন কৰিবলৈ বিচাৰে, তেন্তে টাৰ্মিনেলত চলাও 

```
make module_compile
```
আপুনি সংকলন কৰা মডিউলটো সংকুচিত কৰিবলৈ, তাৰ পিছত টাৰ্মিনেলত চলাও
```
make module_compress
```
সঙ্কুচিত মডিউলটো ব্যৱস্থাৰ কৰ্ণেল মডিউলত সংস্থাপন কৰিবলৈ, টাৰ্মিনেলত চলাও
```
make module_install
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-07

---