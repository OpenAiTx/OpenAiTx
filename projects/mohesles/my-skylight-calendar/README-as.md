
<div align="right">
  <details>
    <summary >🌐 ভাষা</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=hi">হিন্দী</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=th">থাই</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=fr">ফ্ৰান্সী</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=de">জার্মান</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=es">স্পেনিছ</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=it">ইটালিয়ান</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ru">ৰাছিয়ান</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=pt">পৰ্তুগীজ</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=nl">ডাচ</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=pl">প'লিশ</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ar">আৰবী</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=fa">ফাৰ্ছী</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=tr">টাৰ্কিশ</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=vi">ভিয়েটনামী</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=id">ইণ্ডোনেছিয়ান</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# ডি.আই.ওয়াই. স্মাৰ্ট হোম পৰিয়াল কেলেণ্ডাৰ (স্কাইলাইট ক্লোন)

![স্কাইলাইট কেলেণ্ডাৰ](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/assets/main_view.jpeg)
![ডি.আই.ওয়াই. স্কাইলাইট](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/assets/sky2.png)

## 📖 পৰিচয়

মোৰ পত্নীয়ে ছচিয়েল মিডিয়াত সম্প্রতি স্মাৰ্ট হোম কেলেণ্ডাৰৰ (স্কাইলাইট, কোজিলা, হাৰ্থ) বিজ্ঞাপনত আক্ৰান্ত হৈছিল আৰু এজনত $৩০০তকৈ অধিক খৰচ কৰিবলৈ প্ৰস্তুত আছিল। তেওঁক সবুজ সংকেত দিয়াৰ আগতে, মই তেওঁক এবাৰ এইবোৰ সম্পৰ্কে গৱেষণা কৰাৰ সুযোগ বিচাৰিলোঁ।
মই বুজিছোঁ যে অধিকাংশই একে ধৰণৰ কাৰ্যক্ষমতা আগবঢ়ায় যদিও মূল্যত যথেষ্ট পাৰ্থক্য থাকে। আটাইতকৈ গুৰুত্বপূর্ণভাৱে, মই এনে কোনো বিশেষ বৈশিষ্ট্য দেখিলোঁ নে যি মই **Home Assistant**-ত কাৰ্য্যন্বিত কৰিব নোৱাৰোঁ।

**লক্ষ্য:** এখন WAF-অনুমোদিত (Wife Acceptance Factor), কাউণ্টাৰ-ফ্ৰেণ্ডলী টাচস্ক্ৰিন কেলেণ্ডাৰ যি আমাৰ স্মাৰ্ট হোমৰ সৈতে গভীৰভাৱে সংহত হয় আৰু মাসিক মাচুল নালাগে।

## 💡 কিয় স্ব-নির্মিত (DIY)?

Home Assistant ব্যৱহাৰ কৰি স্ব-নির্মিত পথ বাচি লোৱাৰ বহুতো লাভ আছিল Skylight/Hearth ডিসপ্লে কিনাৰ তুলনাত:

* **কোনো মাসিক মাচুল নাই:** "প্ৰিমিয়াম" বৈশিষ্ট্যৰ বাবে চাবছক্ৰিপচন এৰাই যায়।
* **বিহীন সংহতি:** এইটো আমাৰ লাইট, কৰ্ম (Grocy), আৰু উপস্থিতি চেঞ্চৰৰ সৈতে কথা বলে।
* **পুৰণি হাৰ্ডৱেয়াৰ:** এটা Mini PC আৰু এটা সাধাৰণ মনিটৰ পুনৰ্ব্যৱহাৰ কৰা হৈছে।
* **গোপনীয়তা:** কোনো বিক্ৰেতাৰ লগত বন্ধা নোহোৱা বা কোম্পানী বন্ধ হোৱাৰ ভয় নাই।

## 🛠 হাৰ্ডৱেয়াৰ নিৰ্বাচন

এয়া বৰ্তমান যিকোনো HD (1920x1080) ডিসপ্লেত ডেছব’ৰ্ড দেখুৱাবলৈ তৈয়াৰ কৰা হৈছে।

মোৰ ক্ষেত্ৰত, প্ৰয়োজন আছিল যাতে এইটো "Skylight"-ৰ দৰে দেখায়, টাচস্ক্ৰিন হয়, কাউণ্টাৰ-ফ্ৰেণ্ডলী হয়, আৰু বিভিন্ন স্থানলৈ সলনি কৰিবলৈ সক্ষম হয়। সেয়ে মই তলত বৰ্ণনা কৰা হাৰ্ডৱেয়াৰ বাচি ললোঁ।
তথাপিও, আপোনাৰ ক্ষেত্ৰ হয়তো বেলেগ হ’ব পাৰে আৰু আপোনাক আপোনাৰ প্ৰয়োজন অনুসৰি ইয়াত সলনি কৰিব লাগিব, যেনে আপোনিয়ে যদি টেবলেটত বা আন কিছুমানত দেখুৱাব বিচাৰে।

মই যি হাৰ্ডৱেয়াৰ প্ৰাথমিকভাৱে ব্যৱহাৰ কৰিছিলোঁ সেয়া মই ওপৰত উল্লেখ কৰা কাৰণসমূহৰ ভিত্তিত আৰু লগতে ৱেবকেম, স্পীকাৰ আৰু মাইক্ৰফোন ব্যৱহাৰ কৰি ফাংচনেলিটি বঢ়োৱাৰ আশা ৰাখি বাচিছিলোঁ। বৰ্তমানে মই হয়তো ইয়াক বেলেগকৈ তৈয়াৰ কৰিলোঁ হেতেন, কাৰণ এই অতিৰিক্ত হাৰ্ডৱেয়াৰ চিন্তাবোৰ সমাধান কৰিবলৈ সময় পোৱা নাই।

* **মনিটৰ:** [HP Engage 15-inch Touchscreen](https://computers.woot.com/offers/hp-engage-16t-fhd-monitor)। মই এইটো সাধাৰণ পোৰ্টেবল মনিটৰসমূহৰ ঠাইত বাচিলোঁ কাৰণ ইয়াত বিল্ট-ইন **Speaker, Webcam, আৰু Microphone** আছে, যাৰ দ্বাৰা ভবিষ্যতে ভয়েছ কন্ট্ৰ'ল বা ভিডিঅ' কল কৰিব পাৰি।
* **কম্পিউটাৰ:** এটা পুৰণি Mini PC (NUC/Tiny PC) যি Windows/Linux-ত Kiosk মোডত চলিছে, বা এটা Raspberry Pi 4.~~

## ✨ বৈশিষ্ট্যসমূহ

* **পৰিয়াল-ব্যাপী & ব্যক্তিগত দৃষ্টিভংগী:** নিৰ্দিষ্ট পৰিয়ালৰ সদস্যৰ কেলেণ্ডাৰ অন/অফ কৰক।
* **দুয়োপক্ষীয় Sync:** স্ক্ৰীনত বা আমাৰ ফোনত (Google Calendar) ইভেন্ট সম্পাদনা কৰক।
* **"Add Event" Popup:** স্ক্ৰীনৰ পৰা নিৰ্দিষ্ট কেলেণ্ডাৰত ইভেন্ট যোগ কৰিবলৈ কাষ্টম UI।
* **আবহাওয়া & তাৰিখ:** শোভন, চাবলগীয়া হেডাৰ।
* **Responsive:** স্ক্ৰীনৰ প্ৰস্থ অনুসৰি দিনৰ সংখ্যা স্বয়ংক্ৰিয়ভাৱে সমন্বয় কৰে (Mobile vs Desktop)।

---

## ⚙️ ইন্সটলেচন গাইড

*টোকা: এই ছেটআপত **YAML Package** ব্যৱহাৰ কৰা হৈছে যি আপোনাৰ বাবে সকলো সহায়ক, স্ক্ৰিপ্ট আৰু ভেৰিয়েবল স্বয়ংক্ৰিয়ভাৱে সৃষ্টি কৰে। আপোনাৰ হাতেৰে সৃষ্টি কৰাৰ প্ৰয়োজন নাই।*



### ১. প্ৰয়োজনীয়তা (HACS)

আপোনাৰ [HACS](https://hacs.xyz/) ইনষ্টল কৰা থাকিব লাগিব। অনুগ্ৰহ কৰি তলত দিয়া **Frontend** ইন্টেগ্ৰেচনসমূহ ইনষ্টল কৰক:

* `week-planner-card`
* `bubble-card`
* `config-template-card`
* `card-mod`
* `better-moment-card`
* `weather-card`
* `browser_mod` (পপআপসমূহ চলাবলৈ আবশ্যক)
* `layout-card` (Sections দৃষ্টিভংগীৰ বাবে আবশ্যক)
* `button-card` (ঘটনা যোগ কৰাৰ পপআপৰ বাবে আবশ্যক)

*টিপ: Settings → Devices & Services-ত, নিশ্চিত কৰক যে Browser Mod এটা Integration (tile) হিচাপে দেখুওৱা হৈছে, কেৱল HACS-ত নহয়।
যদি নাই দেখা যায়, Add Integration → Browser Mod ক্লিক কৰক আৰু প্ৰক্ৰিয়া সম্পূৰ্ণ কৰক, তাৰ পিছত HA পুনৰ আৰম্ভ কৰক।
HACS-ৰ জৰিয়তে কেৱল ফাইলসমূহ ডাউনলোড হয়; আপোনিয়ে ইনটেগ্ৰেচন যোগ কৰিব লাগিব যাতে HA-এ ইয়াৰ কাৰ্য/এন্টিটিসমূহ ৰেজিষ্টাৰ কৰে।

### ২. বেকএণ্ড (মস্তিষ্ক)

১. আপোনাৰ `configuration.yaml` ফাইলটো Home Assistant-ত খোলক।
২. `homeassistant:`-ৰ তলত এইটো লাইন যোগ কৰা আছে নিশ্চিত কৰক যাতে পেকেজ সক্ৰিয় হয়:

   ```yaml
   homeassistant:
     packages: !include_dir_named packages
   ```

3. আপোনাৰ HA কনফিগ ডিৰেক্টৰীত `packages` নামৰ এখন ফ'ল্ডাৰ সৃষ্টি কৰক (যদি আপোনাৰ নাই তেন্তে)।
4. এই ৰেপ'ৰ পৰা [packages/family_calendar.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/packages/family_calendar.yaml) ডাউনলোড কৰক।
5. [ #<--- UPDATE THIS ENTITY] স্ট্ৰিংটো বিচাৰি কেলেণ্ডাৰ entity ID আপোনাৰ পৰিবেশৰ সৈতে মিলাই আপডেট কৰক। অধিক তথ্যৰ বাবে চেকচন 3 চাওক।
6. ফাইলটো আপোনাৰ `packages/` ফ'ল্ডাৰটোত ৰাখক।
7. **Home Assistant পুনৰ আৰম্ভ কৰক**।

### 3. কেলেণ্ডাৰসমূহ

আপুনি **Google Calendars** অথবা **Local Calendars** ব্যৱহাৰ কৰিব পাৰে।

#### বিকল্প A: কেলেণ্ডাৰ নাম পুনৰ ব্যৱহাৰ কৰক (সৰ্বাধিক সহজ)


1. **Settings > Devices & Services** ত যাওক।
2. **Local Calendar** ইন্টেগ্ৰেশ্বন যোগ কৰক।
3. ঠিক এই নামবোৰেৰে কেলেণ্ডাৰ সৃষ্টি কৰক: `calendar1`, `calendar2`, `calendar3`, `calendar4`, `Family`.
    * *যদি আপুনি এই নামবোৰ ব্যৱহাৰ কৰে, কোডটো সোজাকৈ কাম কৰে!*

#### বিকল্প B: কাষ্টম কেলেণ্ডাৰ

1. **Settings > Devices & Services** ত যাওক।
2. **Local Calendar** ইন্টেগ্ৰেশ্বন অথবা **Google Calendar** যোগ কৰক।
3. **Configuration > Integrations > Local Calendar** অথবা **Google Calendar** ত নেভিগেট কৰক আৰু "Add Entry" বাছনি কৰক।
4. প্ৰতিটো সৃষ্টি কৰা এণ্ট্ৰীৰ বাবে, entity ID লৈ dashboard.yaml ফাইলটো আপডেট কৰক।
5. `dashboard.yaml` খুলক।
6. `# <--- UPDATE THIS ENTITY` বিচাৰি চাওক।
7. আপোনাৰ পৰিবেশৰ সৈতে মিলাই entity ID আপডেট কৰক।


#### ছুটীৰ দিনবোৰ ছেট আপ কৰা

Home Assistant আপডেটৰ পৰা, ছুটীৰ দিনবোৰ এতিয়া UI ৰ মাধ্যমে যোগ কৰিব পাৰি:

1. **Settings > Devices & Services > Add Integration > Holiday** ত যাওক।
2. আপোনাৰ দেশ বাছনি কৰক।
3. entity ID চাওক (যেনে, `calendar.holidays`)। যদি ডিফল্টৰ পৰা বেলেগ হয়, dashboard YAML ত আপডেট কৰক।

### 4. ড্যাশবোর্ড (দেখা)

1. **ছেটিংছ > ডেছব'ৰ্ড**লৈ যাওক
2. **ডেছব'ৰ্ড যোগ কৰক**ত ক্লিক কৰক ("নতুন ডেছব'ৰ্ড আৰম্ভণি পৰ্যায়ৰ পৰা" বিকল্প বাছনি কৰক, "ছাইডবাৰত যোগ কৰক" নিৰ্বাচন কৰা নিশ্চিত কৰক)।
3. বাঁওফালে থকা মেনুত, নতুন সৃষ্টি কৰা ডেছব'ৰ্ড বাছি পেঞ্চিল আইকনটোত ক্লিক কৰি সম্পাদনা কৰক।
5. ৩ টা বিন্দু আইকনটো বাছি "Raw configurator editor" বাছনি কৰক।
6. [dashboard.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/dashboard.yaml) ৰ পৰা ক'ডটো কপি আৰু পেষ্ট কৰক।

### পদক্ষেপ ৫: থীম (ঐচ্ছিক)

নিৰ্দিষ্ট ফন্ট (Ovo) পাবৰ বাবে:

1. আপোনাৰ `configuration.yaml` ত `frontend:` ৰ তলত এইটো লাইন আছে নিশ্চিত কৰক:

   ```yaml
   frontend:
     themes: !include_dir_merge_named themes
   ```
2. আপোনাৰ কনফিগ ডিৰেক্টৰীত `themes` নামৰ এখন ফ'ল্ডাৰ সৃষ্টি কৰক।
3. [themes/skylight.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/themes/skylight.yaml) ডাউনলোড কৰক আৰু সেই ফ'ল্ডাৰটোত ৰাখক।
4. File Editor ব্যৱহাৰ কৰি calbackgrd.png ফাইলটো /www/ ফ'ল্ডাৰত আপলোড কৰক, যি ডেশ্ব'ৰ্ডত আন্তঃভাৱে /local হিচাপে অনুবাদ হয়।
5. Home Assistant পুনৰ আৰম্ভ কৰক।
6. আপোনাৰ প্ৰ'ফাইললৈ যাওক (ব্যৱহাৰকাৰী আইকন তলৰ বাওঁফালে) আৰু **Theme** লৈ `Skylight` লৈ সলনি কৰক।
টোকা: থীমটো সম্পূৰ্ণ নহয়, সেয়ে মনত ৰাখক

---

## 📐 কেনেদৰে কাম কৰে (Under the Hood)

### Filter Logic

`week-planner-card`-এ স্বাভাৱিকভাৱে নিৰ্দিষ্ট কেলেণ্ডাৰসমূহ ফ্লাইত লুকুৱাব পৰা নাযায়। এইটো সমাধান কৰিবলৈ, মই **Input Texts** ব্যৱহাৰ কৰিছোঁ যি Regex ফিল্টাৰ হিচাপে কাম কৰে।

* আপুনি যেতিয়া কোনো ব্যক্তিৰ বুটামত ক্লিক কৰে, সেই ফিল্টাৰটো `.*` (সকলো দেখুৱাওক) আৰু `^$` (কিছু দেখুৱাব নালাগে) ৰ মাজত টগল কৰে।
* `config-template-card`-এ এই ভেৰিয়েবলসমূহ কেলেণ্ডাৰ কাৰ্ডত ডাইনেমিকভাৱে ইনজেক্ট কৰে।

### Event Creation Script

"Add Event" পপআপে এটা স্ক্ৰিপ্ট ব্যৱহাৰ কৰে যি বহুজন আৰু ইভেন্ট টাইপ (All Day বনাম Timed) ৰ লজিক সমলয় কৰে।


```yaml
# Simplified Logic Example
target_calendar: "{{ calendar_map.get(states('input_select.calendar_select')) }}"

choose:
  - conditions: "All Day Event is ON"
    action: calendar.create_event (start_date, end_date)
  - conditions: "All Day Event is OFF"
    action: calendar.create_event (start_date_time, end_date_time)
```

## টোকাসমূহ

মোৰ মূল পোষ্টটো কেৱল কেনেদৰে কৰিব পাৰি তাৰ এক উচ্চ স্তৰৰ দিশ দেখুৱাবলৈ আৰু মানুহে নিজৰ পৰিস্থিতিত কোডটো ঠিক কৰি ব্যৱহাৰ কৰিব পৰা যেনে ব্যৱস্থা কৰিবলৈ দিয়া হৈছিল।

বিশেষকৈ মই এইটো কৰিছিলোঁ কাৰণ প্ৰতিটো ডিসপ্লে আৰু প্ৰয়োজন একে নহয়। মই সকলো সম্ভাৱ্য ডিসপ্লে, ডেছব'ৰ্ড আদি বাবে বিকাশ কৰিব নোৱাৰোঁ। গতিকে এইটো মই উল্লেখ কৰা ডিসপ্লে বা যিকোনো (1920x1080) ত কাম কৰিব পৰা বাবে তৈয়াৰ কৰা হৈছে যদিও আন কোনো বাবে সম্পাদনা কৰিব পৰা যায়।

ডিসপ্লে সম্পৰ্কে ক'লে, মই মূলত সেইটো পৰামৰ্শ দিছিলোঁ কাৰণ সেইটো Woot-ত বিক্ৰীৰ বাবে আছিল আৰু সেই সময়ত টাচস্ক্ৰীন ডিসপ্লে পাবলৈ এটা অতি সস্তা উপায় আছিল। এইটো এতিয়া ঠিকেই নহব পাৰে, গতিকে আপোনাৰ বাবে যি ডিসপ্লে কাম কৰিব সেইটো ব্যৱহাৰ কৰক। টেবলেট, টাচস্ক্ৰীন, ফোন, যি নহওক। মুখ্য কথা হৈছে আপোনাক যি সম্পাদনা কৰিব লাগিব সেয়া হৈছে ডেছব'ৰ্ড।



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-08

---