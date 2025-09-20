
<div align="right">
  <details>
    <summary >🌐 ভাষা</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Xbox_SMC
মূল Xbox আৰু IDA ডেটাবেছৰ পৰা PIC16/Xyclops ডাম্প আৰু কিছু ৰিভাৰ্ছ ইঞ্জিনিয়াৰিং কৰা হৈছে।

![মূল Xbox ৰ PIC16LC63A ৰ ছবি](https://raw.githubusercontent.com/Prehistoricman/Xbox_SMC/master/pic16lc63a.jpg)

# Xyclops ফ্লেশিং (XycloMod)
[the Xyclops directory আৰু README](/Xyclops) চাওক

# ডাম্পসমূহ
প্ৰত্যেকটা PIC ডাম্পৰ বাবে .bin ফাইলটোত বাইটবোৰ সলনি কৰা হৈছে যাতে IDA-ত সঠিকভাৱে ল'ড কৰা যায়। সুতৰাং PIC মেম'ৰীৰ প্ৰথমটো শব্দ হৈছে byte_0 + byte_1 << 8।

.idb IDA ডেটাবেছসমূহত ভেৰিয়েবল আৰু কিছু পৰ্যবেক্ষণৰ তথ্য ডেটাবেছ নোটপেডত আছে।

SMC সংস্কৰণসমূহৰ বিভাজনৰ বাবে এই ৱিকি পৃষ্ঠাটো চাওক: https://xboxdevwiki.net/Xboxen_Info

## B2A
DVT3 Xboxৰ পৰা ডাম্প কৰা হৈছে। P01ৰ দৰে একে কনফিগ শব্দ। ইয়াত কনফিগ এলেকাত device ID 0000 0000 000B 002A হিচাপে পোৰা আছে, উৎপাদন PICবোৰৰ বিপৰীতে।

ই সম্পূৰ্ণৰূপে boot challenge-টো নাই।

## D01
XDK BETA 2 Xboxৰ পৰা ডাম্প কৰা হৈছে। P01ৰ সৈতে একে, কিন্তু boot challenge-টো নাই। আশা কৰা boot challenge response গণনা কৰাৰ ফাংশনটো এতিয়াও আছে, কিন্তু কেতিয়াও কল কৰা নহয়।

## DXF
XDK D2 ডিবাগ কিটৰ পৰা ডাম্প কৰা হৈছে। D01ৰ সৈতে খুবেই সদৃশ, কিন্তু tray logic, overheat logic আৰু boot logic-ত অলপ পাৰ্থক্য আছে। D01ৰ দৰে boot challenge-টো নাই।

## D2E
Tuscany (v1.6) dev kitৰ পৰা ডাম্প কৰা হৈছে। Xyclops চিপটোত X01202-001 চিহ্ন আছে, আৰু A-A02 অথবা A-B01 লাইন নাই যি ৰিটেইল ইউনিটত থাকে।

FC00-ত থকা ডিবাগ ছিৰিয়েল কোডটো ৰিটেইল P2L ডাম্পৰ সৈতে মিল খায়। 0x4000ৰ পৰা 0xFBFFলৈ অদ্ভুত ডাটা পেটাৰ্ন আছে।

## P01
v1.0 Xboxৰ পৰা ডাম্প কৰা হৈছে। কনফিগ শব্দটো হৈছে 0x86:
- CP1:CP0 = 0 (সমগ্ৰ মেম'ৰীৰ বাবে Code Protection সক্ৰিয়)
- BODEN = 0 (Brown-out Reset নিষ্ক্ৰিয়)
- ~PWRTE = 0 (Power-up Timer সক্ৰিয়)
- WDTE = 1 (Watchdog Timer সক্ৰিয়)
- FOSC1:FOSC0 = 2 (HS oscillator)

SMC ক্লোনসমূহৰ বাবে 0x3FB6 কনফিগ মানটো উপযুক্ত যাতে code protection সক্ৰিয় নহয়।

## P11
v1.3 Xboxৰ পৰা ডাম্প কৰা হৈছে। P01ৰ দৰে একে কনফিগ শব্দ।

P11ত P01ৰ লগত তুলনাত অলপ সৰু পৰিৱর্তন আছে, যেনে এটা অতিৰিক্ত SMBus কমাণ্ড (write 0x22), LED প্ৰায়োৰিটিত পাৰ্থক্য, আৰু boot-ৰ বাবে অধিক নমনীয় টাইমিং।

v1.3ৰ scrambled dumps v1.4ৰ সৈতে পৰীক্ষা কৰিছিলো আৰু মিল পাইছিলো। ইয়াৰ অৰ্থ ই খুব সম্ভাৱনীয় যে একে প্ৰগ্ৰাম আছে।

## P2L
ভি১.৬ Xbox ৰ পৰা Dump কৰা। Xyclops revision A-A02। ইয়াত Intel 8051 ক'ড আছে কিন্তু বহুত বিশেষ ফাংশন ৰেজিষ্টাৰ আছে যাৰ কাৰ্য অজ্ঞাত।

ডিবাগ ছিৰিয়েলটো FC00-ত থকা ক'ডেৰে চালিত হয়। দেখিবলৈ এটা সাধাৰণ ডিবাগাৰ, যি এক্সিকিউশ্যন ৰখাই দিব পাৰে, ডাটা dump কৰে, আৰু ৰেজিষ্টাৰ/RAM-লৈ লিখে।

# Xyclops dumping

Xyclops চিপত 'debug'ৰ বাবে ৩টা পিন আছে: TXD (পিন ৬৪), RXD (পিন ৬৩), আৰু DEBUG (পিন ২৯)। TX আৰু RX পিনত ছিৰিয়েল প'ৰ্ট সক্ৰিয় কৰিবলৈ DEBUG পিনটো উচ্চ (high) কৰিব লাগিব। ছিৰিয়েল ৯৬০০ baud-ত চলি থাকে।

প্ৰ'ট'ক'লটো ৪-বাইট ক’মাণ্ডত আধাৰিত, সাধাৰণতে ইয়াৰ ফৰ্মেট হৈছে `<cmd>` `<address MSByte>` `<address LSByte>` `<don't care>`

ক’মাণ্ড 0x14 এ সময়ত ৬৪ বাইট BIOS ডাটা dump কৰে আৰু 0x15 এ সময়ত ৬৪ বাইট SMC প্ৰগ্ৰাম ডাটা dump কৰে। Xyclops ৰ পৰা dump কৰা P2L.bin ৰিপ’ত সংলগ্ন। [xyclops_dumper.py](/Xyclops/xyclops_dumper.py)ো সংলগ্ন, আপুনি নিজৰ মেচিন dump কৰিবলৈ ব্যৱহাৰ কৰিব পাৰে।

# PIC dumping methodology
সম্পূৰ্ণ writeup https://wiki.recessim.com/view/PIC_Burnout ত

PIC-ত ক’ড প্ৰ’টেকশ্যন সক্ৰিয়, সেইবাবে সকলো ডাটা 0000 হিচাপে পঢ়া যায়। মই কিছু trick ব্যৱহাৰ কৰি scrambled data output উলিয়াইছিলোঁ, এটা sacrificial chip ব্যৱহাৰ কৰি scrambling algorithm উলিয়াইছিলোঁ, আৰু তাৰ পাছত এটা exploit ব্যৱহাৰ কৰি ROM ডাটা modify কৰি কিছু bit জানিব পৰা value-লৈ ঠিক কৰিছিলোঁ। তাৰপিছত, বহু scrambled dump ৰ পৰা প্ৰয়োজনীয় তথ্য extract কৰি মূল ডাটা rebuild কৰিব পাৰোঁ।

# PICProgrammer
PICProgrammer হৈছে RP2040-ৰ বাবে কিছু Arduino প্ৰজেক্টৰ অন্যতম, যিটো মোৰ research-ত ব্যৱহাৰ কৰিছিলোঁ। ইয়াত ICSP (in-circuit serial programming) অপাৰেশ্যন চলাবলৈ এটা সহজ command-line interface আছে। ইয়াক PICkit-ৰ দৰে উদ্দেশ্য-নির্মিত programmer-ৰ তুলনাত ভাল মানা হয়, কাৰণ ইয়াত অধিক flexibility আছে আৰু manufacturer-এ অনুমতি নেদিয়া কাম কৰিব পৰা যায়।

এইটো ব্যৱহাৰ কৰাৰ আগতে আপোনাৰ ইলেকট্ৰনিক্স আৰু প্ৰগ্ৰামিংৰ ভাল বুজাবুজি থকা উচিত, আৰু কোনো command execute কৰাৰ আগতে তাৰ function ভালকৈ চাব লাগে।


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-20

---