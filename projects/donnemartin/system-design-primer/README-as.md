*[English](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/README.md) ∙ [日本語](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/README-ja.md) ∙ [简体中文](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/README-zh-Hans.md) ∙ [繁體中文](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/README-zh-TW.md) | [العَرَبِيَّة‎](https://github.com/donnemartin/system-design-primer/issues/170) ∙ [বাংলা](https://github.com/donnemartin/system-design-primer/issues/220) ∙ [Português do Brasil](https://github.com/donnemartin/system-design-primer/issues/40) ∙ [Deutsch](https://github.com/donnemartin/system-design-primer/issues/186) ∙ [ελληνικά](https://github.com/donnemartin/system-design-primer/issues/130) ∙ [עברית](https://github.com/donnemartin/system-design-primer/issues/272) ∙ [Italiano](https://github.com/donnemartin/system-design-primer/issues/104) ∙ [한국어](https://github.com/donnemartin/system-design-primer/issues/102) ∙ [فارسی](https://github.com/donnemartin/system-design-primer/issues/110) ∙ [Polski](https://github.com/donnemartin/system-design-primer/issues/68) ∙ [русский язык](https://github.com/donnemartin/system-design-primer/issues/87) ∙ [Español](https://github.com/donnemartin/system-design-primer/issues/136) ∙ [ภาษาไทย](https://github.com/donnemartin/system-design-primer/issues/187) ∙ [Türkçe](https://github.com/donnemartin/system-design-primer/issues/39) ∙ [tiếng Việt](https://github.com/donnemartin/system-design-primer/issues/127) ∙ [Français](https://github.com/donnemartin/system-design-primer/issues/250) | [Add Translation](https://github.com/donnemartin/system-design-primer/issues/28)*

**এই গাইডটো [অনুবাদ কৰক](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/TRANSLATIONS.md)!**

# ছিষ্টেম ডিজাইন প্ৰাইমাৰ

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/jj3A5N8.png">
  <br/>
</p>

## প্ৰেৰণা

> বৃহৎ পৰিসৰৰ ছিষ্টেম ডিজাইন কৰিবলৈ শিকক।
>
> ছিষ্টেম ডিজাইন সাক্ষাৎকাৰৰ বাবে প্ৰস্তুতি লওক।

### বৃহৎ পৰিসৰৰ ছিষ্টেম ডিজাইন কৰিবলৈ শিকক

স্কেলেবেল ছিষ্টেম ডিজাইন কৰিবলৈ শিকিলে আপোনাক এটি ভাল ইঞ্জিনিয়াৰ হ'বলৈ সহায় কৰিব।

ছিষ্টেম ডিজাইন এটা বিস্তৃত বিষয়। ছিষ্টেম ডিজাইন নীতিসমূহৰ ওপৰত **অসংখ্য উৎস ৱেবত ছৰিয়াই থকা আছে**।

এই ৰেপ'টো হৈছে **সংগঠিত সংকলন** যি আপোনাক স্কেলত ছিষ্টেম নিৰ্মাণ কৰিবলৈ শিকাত সহায় কৰে।

### মুক্ত উৎস সমুদায়ৰ পৰা শিকক

এইটো সদায় নবীকৃত হোৱা মুক্ত উৎস প্ৰকল্প।

[অংশগ্ৰহণ](#contributing) স্বাগতম!

### ছিষ্টেম ডিজাইন সাক্ষাৎকাৰৰ বাবে প্ৰস্তুতি লওক

কোডিং সাক্ষাৎকাৰৰ উপৰিও, ছিষ্টেম ডিজাইন হৈছে **প্ৰযুক্তিগত সাক্ষাৎকাৰ প্ৰক্ৰিয়াৰ** এটা **আৱশ্যকীয় অংশ** বহু টেক কোম্পানীত।

**সাধাৰণ ছিষ্টেম ডিজাইন সাক্ষাৎকাৰ প্ৰশ্ন অনুশীলন কৰক** আৰু **আপোনাৰ উত্তৰসমূহ** **নমুনা সমাধানৰ** সৈতে **তুলনা কৰক**: আলোচনা, কোড, আৰু চিত্ৰ।

সাক্ষাৎকাৰ প্ৰস্তুতিৰ বাবে অতিৰিক্ত বিষয়সমূহ:

* [অধ্যয়ন গাইড](#study-guide)
* [ছিষ্টেম ডিজাইন সাক্ষাৎকাৰ প্ৰশ্ন সমাধান কৰাৰ পদ্ধতি](#how-to-approach-a-system-design-interview-question)
* [চিষ্টেম ডিজাইন ইন্টাৰভিউ প্ৰশ্নসমূহ, **সমাধানৰ সৈতে**](#system-design-interview-questions-with-solutions)
* [অবজেক্ট-অৰিয়েন্টেড ডিজাইন ইন্টাৰভিউ প্ৰশ্নসমূহ, **সমাধানৰ সৈতে**](#object-oriented-design-interview-questions-with-solutions)
* [অতিৰিক্ত চিষ্টেম ডিজাইন ইন্টাৰভিউ প্ৰশ্নসমূহ](#additional-system-design-interview-questions)

## Anki ফ্লেশকাৰ্ডছ

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/zdCAkB3.png">
  <br/>
</p>

দান কৰা [Anki ফ্লেশকাৰ্ড ডেকসমূহ](https://apps.ankiweb.net/)-এ spaced repetition ব্যৱহাৰ কৰি মুখ্য চিষ্টেম ডিজাইন ধাৰণাসমূহ মনত ৰাখিবলৈ সহায় কৰে।

* [চিষ্টেম ডিজাইন ডেক](https://github.com/donnemartin/system-design-primer/tree/master/resources/flash_cards/System%20Design.apkg)
* [চিষ্টেম ডিজাইন অনুশীলনী ডেক](https://github.com/donnemartin/system-design-primer/tree/master/resources/flash_cards/System%20Design%20Exercises.apkg)
* [অবজেক্ট-অৰিয়েন্টেড ডিজাইন অনুশীলনী ডেক](https://github.com/donnemartin/system-design-primer/tree/master/resources/flash_cards/OO%20Design.apkg)

ভ্ৰমনকালত ব্যৱহাৰৰ বাবে উৎকৃষ্ট।

### কোডিং ৰিসৰ্চ: ইন্টাৰেক্টিভ কোডিং চেলেঞ্জসমূহ

[**কোডিং ইন্টাৰভিউ**](https://github.com/donnemartin/interactive-coding-challenges)-ৰ বাবে প্রস্তুতিৰ বাবে ৰিসৰ্চ বিচাৰি আছেনে?

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/b4YtAEN.png">
  <br/>
</p>

ভগ্নি ৰেপো [**ইন্টাৰেক্টিভ কোডিং চেলেঞ্জসমূহ**](https://github.com/donnemartin/interactive-coding-challenges) চাওক, য'ত এটা অতিৰিক্ত Anki ডেক আছে:

* [কোডিং ডেক](https://github.com/donnemartin/interactive-coding-challenges/tree/master/anki_cards/Coding.apkg)

## অৱদান আগবঢ়োৱা

> সমাজৰ পৰা শিকক।

সহায় কৰিবলৈ pull request জমা দিয়াৰ বাবে স্বতন্ত্ৰ অনুভৱ কৰক:

* ভুলসমূহ ঠিক কৰক
* বিভাগসমূহ উন্নত কৰক
* নতুন অংশবোৰ যোগ কৰক
* [অনুবাদ কৰক](https://github.com/donnemartin/system-design-primer/issues/28)

পলিছিংৰ প্ৰয়োজন থকা সমল [উন্নয়নাধীন](#under-development) হিচাপে সংৰক্ষিত হৈছে।

[অংগ্ৰহণৰ নিয়মাৱলী](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/CONTRIBUTING.md) পৰ্যালোচনা কৰক।

## চিষ্টেম ডিজাইন বিষয়বস্তুৰ সূচী

> বিভিন্ন চিষ্টেম ডিজাইন বিষয়বস্তুৰ সংক্ষিপ্তসাৰ, লাভ আৰু ক্ষতি সহ। **প্ৰত্যেকটো এটা সমঝোতা**।
>
> প্ৰত্যেক অংশত অধিক গভীৰ উৎসৰ লিংক থাকে।

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/jrUBAF7.png">
  <br/>
</p>

* [চিষ্টেম ডিজাইন বিষয়: ইয়াত আৰম্ভ কৰক](#system-design-topics-start-here)
    * [পদক্ষেপ ১: স্কেলেবিলিটি ভিডিঅ' লেকচার পৰ্যালোচনা কৰক](#step-1-review-the-scalability-video-lecture)
    * [পদক্ষেপ ২: স্কেলেবিলিটি প্ৰবন্ধ পৰ্যালোচনা কৰক](#step-2-review-the-scalability-article)
    * [পৰবর্তী পদক্ষেপ](#next-steps)
* [পাৰফৰ্মেন্স বনাম স্কেলেবিলিটি](#performance-vs-scalability)
* [লেটেন্সি বনাম থ্ৰু-পুট](#latency-vs-throughput)
* [উপলব্ধতা বনাম একৰূপতা](#availability-vs-consistency)
    * [CAP তত্ত্ব](#cap-theorem)
        * [CP - একৰূপতা আৰু বিভাজন সহনশীলতা](#cp---consistency-and-partition-tolerance)
        * [AP - উপলব্ধতা আৰু বিভাজন সহনশীলতা](#ap---availability-and-partition-tolerance)
* [একৰূপতা পেটাৰ্নসমূহ](#consistency-patterns)
    * [দুৰ্বল একৰূপতা](#weak-consistency)
    * [অৱশেষ একৰূপতা](#eventual-consistency)
    * [শক্তিশালী একৰূপতা](#strong-consistency)
* [উপলব্ধতা পেটাৰ্নসমূহ](#availability-patterns)
    * [ফেইল-ওভাৰ](#fail-over)
    * [প্ৰতিলিপি](#replication)
    * [সংখ্যাত উপলব্ধতা](#availability-in-numbers)
* [ড’মেইন নাম চিষ্টেম](#domain-name-system)
* [কণ্টেন্ট ডেলিভাৰী নেটৱৰ্ক](#content-delivery-network)
    * [পুশ CDN-সমূহ](#push-cdns)
    * [পুল CDN-সমূহ](#pull-cdns)
* [লোড বেলেন্সাৰ](#load-balancer)
    * [একটিভ-পেছিভ](#active-passive)
    * [একটিভ-একটিভ](#active-active)
    * [লেয়াৰ ৪ লোড বেলেন্সিং](#layer-4-load-balancing)
    * [লেয়াৰ ৭ লোড বেলেন্সিং](#layer-7-load-balancing)
    * [অংশভাগত স্কেলিং](#horizontal-scaling)
* [ৰিভাৰ্ছ প্ৰক্সি (ৱেব ছাৰ্ভাৰ)](#reverse-proxy-web-server)
    * [লোড বেলেন্সাৰ বনাম ৰিভাৰ্ছ প্ৰক্সি](#load-balancer-vs-reverse-proxy)
* [এপ্লিকেচন স্তৰ](#application-layer)
    * [মাইক্ৰ’চাৰ্ভিচ](#microservices)
    * [চাৰ্ভিচ ডিসকভাৰী](#service-discovery)
* [ডাটাবেছ](#database)
    * [ৰিলেচনেল ডাটাবেছ মেনেজমেণ্ট ছিষ্টেম (RDBMS)](#relational-database-management-system-rdbms)
        * [মাষ্টাৰ-চ্লেভ ৰিপ্লিকেচন](#master-slave-replication)
        * [মাষ্টাৰ-মাষ্টাৰ ৰিপ্লিকেচন](#master-master-replication)
        * [ফেডাৰেচন](#federation)
        * [শাৰ্ডিং](#sharding)
        * [ডিনৰ্মেলাইজেচন](#denormalization)
        * [SQL টিউনিং](#sql-tuning)
    * [NoSQL](#nosql)
        * [কি-ভেলিউ ষ্ট’ৰ](#key-value-store)
        * [ডকুমেণ্ট ষ্ট’ৰ](#document-store)
        * [ৱাইড কলাম ষ্ট’ৰ](#wide-column-store)
        * [গ্ৰাফ ডাটাবেছ](#graph-database)
    * [SQL অথবা NoSQL](#sql-or-nosql)
* [কেছ](#cache)
    * [ক্লায়েন্ট কেছিং](#client-caching)
    * [CDN কেছিং](#cdn-caching)
    * [ৱেব ছাৰ্ভাৰ কেছিং](#web-server-caching)
    * [ডাটাবেছ কেছিং](#database-caching)
    * [এপ্লিকেচন কেছিং](#application-caching)
    * [ডাটাবেছ কুৱাৰী স্তৰত কেছিং](#caching-at-the-database-query-level)
    * [অবজেক্ট স্তৰত কেছিং](#caching-at-the-object-level)
    * [কেতিয়া কেছ আপডেট কৰিব](#when-to-update-the-cache)
        * [কেছ-অ’ছাইড](#cache-aside)
        * [ৰাইট-থ্ৰু](#write-through)
        * [ৰাইট-বিহাইণ্ড (ৰাইট-বেক)](#write-behind-write-back)
        * [ৰিফ্ৰেছ-অ’হেড](#refresh-ahead)
* [অসিঙ্ক্ৰোনিজম](#asynchronism)
    * [মেছেজ কিউ](#message-queues)
    * [Task queues](#task-queues)
    * [Back pressure](#back-pressure)
* [Communication](#communication)
    * [Transmission control protocol (TCP)](#transmission-control-protocol-tcp)
    * [User datagram protocol (UDP)](#user-datagram-protocol-udp)
    * [Remote procedure call (RPC)](#remote-procedure-call-rpc)
    * [Representational state transfer (REST)](#representational-state-transfer-rest)
* [Security](#security)
* [Appendix](#appendix)
    * [Powers of two table](#powers-of-two-table)
    * [Latency numbers every programmer should know](#latency-numbers-every-programmer-should-know)
    * [Additional system design interview questions](#additional-system-design-interview-questions)
    * [Real world architectures](#real-world-architectures)
    * [Company architectures](#company-architectures)
    * [Company engineering blogs](#company-engineering-blogs)
* [Under development](#under-development)
* [Credits](#credits)
* [Contact info](#contact-info)
* [License](#license)

## অধ্যয়ন গাইড

> আপোনাৰ সাক্ষাৎকাৰৰ সময়সূচী (সৰু, মধ্যম, দীঘল) অনুসৰি পৰ্যালোচনাৰ বাবে পৰামৰ্শিত বিষয়সমূহ।

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/OfVllex.png)

**প্ৰঃ: সাক্ষাৎকাৰৰ বাবে, মই ইয়াত সকলো জানিব লাগেনে?**

**উঃ: নহয়, সাক্ষাৎকাৰৰ বাবে প্ৰস্তুতিৰ বাবে আপোনাৰ ইয়াত সকলো জানিব নালাগে।**

সাক্ষাৎকাৰত আপোনাক কি সোধা হ'ব তাৰ ওপৰত নিৰ্ভৰ কৰে এনেধৰণৰ পৰিৱৰ্তনশীলতাত:

* আপোনাৰ কিমান অভিজ্ঞতা আছে
* আপোনাৰ প্ৰযুক্তিগত পটভূমি কি
* কোন পজিশনৰ বাবে সাক্ষাৎকাৰ দিব
* কোন কোম্পানিত সাক্ষাৎকাৰ দিব
* ভাগ্য

অধিক অভিজ্ঞ প্ৰাৰ্থীৰ পৰা সাধাৰণতে ছিষ্টেম ডিজাইন সম্পৰ্কে অধিক জ্ঞান আশা কৰা হয়।  স্থপতি বা দলৰ নেতাসকলৰ পৰা একক অৱদানকাৰীৰ তুলনাত অধিক আশা কৰা হয়।  শীৰ্ষ প্ৰযুক্তি কোম্পানিসমূহত সাধাৰণতে এটা বা ততোধিক ডিজাইন সাক্ষাৎকাৰ পৰ্যায় থাকে।

ব্যাপকভাৱে আৰম্ভ কৰক আৰু কিছুমান ক্ষেত্ৰত গভীৰভাৱে যাওক।  বিভিন্ন মুখ্য চিষ্টেম ডিজাইন বিষয়সমূহৰ বিষয়ে অলপ জানিবলৈ সহায় কৰে।  তলত দিয়া গাইডটো আপোনাৰ সময়সীমা, অভিজ্ঞতা, যি পদৰ বাবে সাক্ষাৎকাৰ দিব, আৰু যি কোম্পানিত সাক্ষাৎকাৰ দিব, তাৰ ভিত্তিত সমন্বয় কৰক।

* **চুটি সময়সীমা** - চিষ্টেম ডিজাইন বিষয়সমূহত **ব্যাপকতা**ৰ লক্ষ্য ৰাখক।  **কিছুমান** সাক্ষাৎকাৰ প্ৰশ্নৰ সমাধান কৰি অনুশীলন কৰক।
* **মধ্যম সময়সীমা** - চিষ্টেম ডিজাইন বিষয়সমূহত **ব্যাপকতা** আৰু **কিছু গভীৰতা**ৰ লক্ষ্য ৰাখক।  **বহুত** সাক্ষাৎকাৰ প্ৰশ্নৰ সমাধান কৰি অনুশীলন কৰক।
* **দীঘল সময়সীমা** - চিষ্টেম ডিজাইন বিষয়সমূহত **ব্যাপকতা** আৰু **অধিক গভীৰতা**ৰ লক্ষ্য ৰাখক।  **বেছিভাগ** সাক্ষাৎকাৰ প্ৰশ্নৰ সমাধান কৰি অনুশীলন কৰক।

| | চুটি | মধ্যম | দীঘল |
|---|---|---|---|
| [চিষ্টেম ডিজাইন বিষয়সমূহ](#index-of-system-design-topics) পঢ়ি চিষ্টেমবোৰ কেনেকৈ কাম কৰে তাৰ ব্যাপক বুজ লওক | :+1: | :+1: | :+1: |
| যি কোম্পানিত সাক্ষাৎকাৰ দিব, সেইবোৰৰ [কোম্পানী ইঞ্জিনীয়াৰিং ব্লগ](#company-engineering-blogs)ৰ কিছুমান প্ৰবন্ধ পঢ়ক | :+1: | :+1: | :+1: |
| [বাস্তৱিক স্থাপত্যসমূহ](#real-world-architectures)ৰ কিছুমান পঢ়ক | :+1: | :+1: | :+1: |
| [চিষ্টেম ডিজাইন সাক্ষাৎকাৰ প্ৰশ্নৰ প্ৰৱেশ](#how-to-approach-a-system-design-interview-question) পোনপটীয়া কৰক | :+1: | :+1: | :+1: |
| [সমাধানসহ চিষ্টেম ডিজাইন সাক্ষাৎকাৰ প্ৰশ্ন](#system-design-interview-questions-with-solutions) অনুশীলন কৰক | কিছুমান | বহুত | বেছিভাগ |
| [সমাধানসহ অবজেক্ট-অৰিয়েন্টেড ডিজাইন সাক্ষাৎকাৰ প্ৰশ্ন](#object-oriented-design-interview-questions-with-solutions) অনুশীলন কৰক | কিছুমান | বহুত | বেছিভাগ |
| [অতিৰিক্ত চিষ্টেম ডিজাইন সাক্ষাৎকাৰ প্ৰশ্ন](#additional-system-design-interview-questions) পোনপটীয়া কৰক | কিছুমান | বহুত | বেছিভাগ |

## চিষ্টেম ডিজাইন সাক্ষাৎকাৰ প্ৰশ্নৰ প্ৰৱেশ কেনেকৈ কৰিব

> চিষ্টেম ডিজাইন সাক্ষাৎকাৰ প্ৰশ্ন কেনেকৈ সমাধান কৰিব।

চিষ্টেম ডিজাইন সাক্ষাৎকাৰ হৈছে এটা **উন্মুক্ত আলোচনা**।  আপোনাক ইয়াত নেতৃত্ব দিবলে আশা কৰা হয়।

আলোচনাটো পথ দেখুৱাবলৈ তলৰ পদক্ষেপবোৰ ব্যৱহাৰ কৰিব পাৰে।  এই প্ৰক্ৰিয়া দৃঢ় কৰিবলৈ, [সমাধানসহ চিষ্টেম ডিজাইন সাক্ষাৎকাৰ প্ৰশ্ন](#system-design-interview-questions-with-solutions) অংশটো তলৰ পদক্ষেপ ব্যৱহাৰ কৰি অনুশীলন কৰক।

### পদক্ষেপ ১: ব্যৱহাৰ ক্ষেত্ৰ, সীমাবদ্ধতা, আৰু অনুমানৰ সংক্ষিপ্তসাৰ

দৰকাৰী বিষয়বস্তু সংগ্ৰহ কৰক আৰু সমস্যাৰ সীমা স্থিৰ কৰক।  ব্যৱহাৰ ক্ষেত্ৰ আৰু সীমাবদ্ধতা স্পষ্ট কৰিবলৈ প্ৰশ্ন কৰক।  অনুমানসমূহ আলোচনা কৰক।

* কোনে ইয়াক ব্যৱহাৰ কৰিব?
* কেনেকৈ ব্যৱহাৰ কৰিব?
* কিমান ব্যৱহাৰকাৰী আছে?
* চিষ্টেমে কি কৰে?
* চিষ্টেমৰ ইনপুট আৰু আউটপুট কি?
* কিমান ডাটা আশা কৰা হৈছে?
* প্ৰতি ছেকেণ্ডত কিমান অনুৰোধ আশা কৰা হৈছে?
* আশা কৰা পঢ়া আৰু লিখা অনুপাত কিমান?

### পদক্ষেপ ২: উচ্চ স্তৰৰ ডিজাইন তৈয়াৰ কৰক

সমূহ গুৰুত্বপূর্ণ অংশসহ উচ্চ স্তৰৰ ডিজাইনৰ সংক্ষিপ্তসাৰ দিয়ক।

* মুখ্য উপাদানসমূহ আৰু সংযোগবোৰৰ স্কেচ আঁকা
* আপোনাৰ ধাৰণাসমূহৰ যুক্তি প্রদান কৰক

### পদক্ষেপ ৩: মূল উপাদানসমূহ ডিজাইন কৰক

প্ৰত্যেকটা মূল উপাদানৰ বাবে বিস্তারিতভাৱে আলোচনা কৰক। উদাহৰণস্বৰূপে, যদি আপোনাক [এটা URL সংক্ষিপ্তকৰণ সেৱা ডিজাইন কৰিবলৈ] (https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/pastebin/README.md) অনুৰোধ কৰা হয়, তেন্তে আলোচনা কৰক:

* সম্পূর্ণ URL-ৰ হাশ সৃষ্টি আৰু সংৰক্ষণ কৰা
    * [MD5](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/pastebin/README.md) আৰু [Base62](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/pastebin/README.md)
    * হাশ ক'লিজনসমূহ
    * SQL অথবা NoSQL
    * ডেটাবেছ স্কিমা
* হাশ কৰা URL-টো সম্পূর্ণ URL-লৈ অনুবাদ কৰা
    * ডেটাবেছ সন্ধান
* API আৰু অবজেক্ট-অৰিয়েন্টেড ডিজাইন

### পদক্ষেপ ৪: ডিজাইনটো স্কেল কৰক

বটলনেক চিনাক্ত কৰক আৰু সমাধান কৰক, দিয়া সীমাবদ্ধতাসমূহ অনুসৰি। উদাহৰণস্বৰূপে, scalability সমস্যা সমাধান কৰিবলৈ আপোনাৰ নিম্নলিখিতবোৰৰ প্ৰয়োজন আছে নেকি?

* লোড বেলেন্সাৰ
* হৰিজণ্টেল স্কেলিং
* কেচিং
* ডেটাবেছ শাৰ্ডিং

সম্ভৱপৰ সমাধান আৰু ট্রেড-অফসমূহ আলোচনা কৰক। প্ৰতিটো বিষয়েই এটা ট্রেড-অফ। [স্কেলেবল চিষ্টেম ডিজাইনৰ মূলনীতি] (#index-of-system-design-topics) ব্যৱহাৰ কৰি বটলনেক সমাধান কৰক।

### চটপট গণনা

আপোনাক হাতে-কলমে কিছুমান অনুমান কৰিব পৰা যায়। [Appendix](#appendix)ত নিম্নলিখিত উৎসসমূহত চাওক:

* [চটপট গণনা ব্যৱহাৰ কৰক](http://highscalability.com/blog/2011/1/26/google-pro-tip-use-back-of-the-envelope-calculations-to-choo.html)
* [দুইৰ শক্তি সূচী](#powers-of-two-table)
* [প্ৰতি প্ৰগ্ৰামাৰে জানিবলগীয়া লেটেন্সি সংখ্যাসমূহ](#latency-numbers-every-programmer-should-know)

### উৎস(সমূহ) আৰু অধিক পঢ়াৰ বাবে

তলত দিয়া লিংকসমূহ চাওক, কি আশা কৰিব পাৰি তাৰ ভাল ধাৰণা পাবলৈ:

* [কেনেদৰে এটা ছিষ্টেম ডিজাইন ইণ্টাৰ্ভিউত উৎকৃষ্ট কৰিব পাৰি](https://www.palantir.com/2011/10/how-to-rock-a-systems-design-interview/)
* [ছিষ্টেম ডিজাইন ইণ্টাৰ্ভিউ](http://www.hiredintech.com/system-design)
* [আৰ্কিটেকচাৰ আৰু ছিষ্টেম ডিজাইন ইণ্টাৰ্ভিউৰ পৰিচয়](https://www.youtube.com/watch?v=ZgdS0EUmn70)
* [ছিষ্টেম ডিজাইন টেমপ্লেট](https://leetcode.com/discuss/career/229177/My-System-Design-Template)

## ছিষ্টেম ডিজাইন ইণ্টাৰ্ভিউ প্ৰশ্নসমূহ উত্তৰৰ সৈতে

> সাধাৰণ ছিষ্টেম ডিজাইন ইণ্টাৰ্ভিউৰ প্ৰশ্নসমূহৰ উদাহৰণীয়া আলোচনা, ক’ড আৰু চিত্ৰ।
>
> উত্তৰসমূহ `solutions/` ফোল্ডাৰৰ সমলত সংলগ্ন।

| প্ৰশ্ন | |
|---|---|
| Pastebin.com (বা Bit.ly) ডিজাইন কৰক | [উত্তৰ](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/pastebin/README.md) |
| Twitter timeline আৰু search (বা Facebook feed আৰু search) ডিজাইন কৰক | [উত্তৰ](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/twitter/README.md) |
| এটা web crawler ডিজাইন কৰক | [উত্তৰ](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/web_crawler/README.md) |
| Mint.com ডিজাইন কৰক | [উত্তৰ](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/mint/README.md) |
| এজন সামাজিক জালৰ data structures ডিজাইন কৰক | [উত্তৰ](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/social_graph/README.md) |
| এটা search engine ৰ বাবে key-value store ডিজাইন কৰক | [উত্তৰ](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/query_cache/README.md) |
| Amazon ৰ sales ranking by category বৈশিষ্ট্য ডিজাইন কৰক | [উত্তৰ](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/sales_rank/README.md) |
| AWS-ত মিলিয়ন সংখ্যক ব্যৱহাৰকাৰীৰ বাবে scalable ছিষ্টেম ডিজাইন কৰক | [উত্তৰ](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/scaling_aws/README.md) |
| এটা ছিষ্টেম ডিজাইন প্ৰশ্ন যোগ কৰক | [অংদান কৰক](#contributing) |

### Pastebin.com (বা Bit.ly) ডিজাইন কৰক

[অভ্যাস আৰু উত্তৰ চাওক](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/pastebin/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/4edXG0T.png)

### Twitter timeline আৰু search (বা Facebook feed আৰু search) ডিজাইন কৰক

[অভ্যাস আৰু উত্তৰ চাওক](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/twitter/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/jrUBAF7.png)

### এটা web crawler ডিজাইন কৰক

[অভ্যাস আৰু উত্তৰ চাওক](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/web_crawler/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/bWxPtQA.png)

### Design Mint.com

[View exercise and solution](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/mint/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/V5q57vU.png)

### Design the data structures for a social network

[View exercise and solution](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/social_graph/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/cdCv5g7.png)

### Design a key-value store for a search engine

[View exercise and solution](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/query_cache/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/4j99mhe.png)

### Design Amazon's sales ranking by category feature

[View exercise and solution](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/sales_rank/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/MzExP06.png)

### Design a system that scales to millions of users on AWS

[View exercise and solution](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/scaling_aws/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/jj3A5N8.png)

## Object-oriented design interview questions with solutions

> Common object-oriented design interview questions with sample discussions, code, and diagrams.
>
> Solutions linked to content in the `solutions/` folder.

>**Note: This section is under development**

| Question | |
|---|---|
| এটা হেশ্‌ মেপ ডিজাইন কৰক | [সমাধান](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/object_oriented_design/hash_table/hash_map.ipynb)  |
| এটা লিষ্ট ৰিছেণ্টলি ইউজড কেছ ডিজাইন কৰক | [সমাধান](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/object_oriented_design/lru_cache/lru_cache.ipynb)  |
| এটা কল চেন্টাৰ ডিজাইন কৰক | [সমাধান](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/object_oriented_design/call_center/call_center.ipynb)  |
| এটা কাৰ্ডৰ ডেক ডিজাইন কৰক | [সমাধান](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/object_oriented_design/deck_of_cards/deck_of_cards.ipynb)  |
| এটা পাৰ্কিং লট ডিজাইন কৰক | [সমাধান](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/object_oriented_design/parking_lot/parking_lot.ipynb)  |
| এটা চেট ছাৰ্ভাৰ ডিজাইন কৰক | [সমাধান](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/object_oriented_design/online_chat/online_chat.ipynb)  |
| এটা চাৰ্কুলাৰ এৰে ডিজাইন কৰক | [অংশগ্ৰহণ কৰক](#contributing)  |
| এটা অবজেক্ট-অৰিয়েন্টেড ডিজাইন প্ৰশ্ন যোগ কৰক | [অংশগ্ৰহণ কৰক](#contributing) |

## ছিষ্টেম ডিজাইন বিষয়বস্তু: ইয়াৰে আৰম্ভ কৰক

ছিষ্টেম ডিজাইনত নতুন?

প্ৰথমে, সাধাৰণ নীতিসমূহৰ মূল কথা বুজিব লাগিব, কি সিহঁত, কেনেকৈ ব্যৱহাৰ কৰা হয়, আৰু সিহঁতৰ লাভ-অলাভ।

### পদক্ষেপ ১: স্কেলেবিলিটি ভিডিঅ' লেকচাৰ পৰ্যালোচনা কৰক

[হাৰ্ভাৰ্ডত স্কেলেবিলিটি লেকচাৰ](https://www.youtube.com/watch?v=-W9F__D3oY4)

* আলোচনা কৰা বিষয়বস্তু:
    * ভাৰ্টিকেল স্কেলিং
    * হৰিজণ্টেল স্কেলিং
    * কেছিং
    * লোড বেলেন্সিং
    * ডেটাবেচ ৰেপ্লিকেশন
    * ডেটাবেচ পাৰ্টিশ্বনিং

### পদক্ষেপ ২: স্কেলেবিলিটি প্ৰবন্ধ পৰ্যালোচনা কৰক

[স্কেলেবিলিটি](https://web.archive.org/web/20221030091841/http://www.lecloud.net/tagged/scalability/chrono)

* আলোচনা কৰা বিষয়বস্তু:
    * [ক্লোন](https://web.archive.org/web/20220530193911/https://www.lecloud.net/post/7295452622/scalability-for-dummies-part-1-clones)
    * [ডেটাবেচ](https://web.archive.org/web/20220602114024/https://www.lecloud.net/post/7994751381/scalability-for-dummies-part-2-database)
    * [কেছ](https://web.archive.org/web/20230126233752/https://www.lecloud.net/post/9246290032/scalability-for-dummies-part-3-cache)
    * [অ্যাসিঙ্ক্ৰনিজম](https://web.archive.org/web/20220926171507/https://www.lecloud.net/post/9699762917/scalability-for-dummies-part-4-asynchronism)

### পৰৱৰ্তী পদক্ষেপ

পিছত, আমি উচ্চ-স্তৰৰ বাণিজ্যিক সমঝোতা সমূহ চাওঁ:

* **কাৰ্যক্ষমতা (Performance)** বনাম **বিস্তাৰযোগ্যতা (scalability)**
* **বিলম্ব (latency)** বনাম **থ্ৰুপুট (throughput)**
* **উপলব্ধতা (availability)** বনাম **সুসংগতিতা (consistency)**

মনে ৰাখিব যে **সকলোবোৰে এটা সমঝোতা**।

তেতিয়া আমি অধিক নিৰ্দিষ্ট বিষয়সমূহ যেনে DNS, CDN আৰু লোড বেলেন্সাৰ চাম।

## কাৰ্যক্ষমতা বনাম বিস্তাৰযোগ্যতা

এটা সেৱা **বিস্তাৰযোগ্য** যদি ইয়াত সংযোজিত সম্পদৰ অনুপাতে **কাৰ্যক্ষমতা** বৃদ্ধি পায়। সাধাৰণতে, কার্যক্ষমতা বৃদ্ধি মানে অধিক কামৰ একক সেৱন কৰা, কিন্তু ই ডেটাসেট ডাঙৰ হ'লে ডাঙৰ কামৰ একক হেণ্ডেল কৰাটোও হ'ব পাৰে।<sup><a href=http://www.allthingsdistributed.com/2006/03/a_word_on_scalability.html>1</a></sup>

কাৰ্যক্ষমতা বনাম বিস্তাৰযোগ্যতা বুজাৰ আন এটা উপায়:

* যদি আপোনাৰ **কাৰ্যক্ষমতা** সমস্যা আছে, তেন্তে আপোনাৰ প্ৰণালী এটা ব্যৱহাৰকাৰীৰ বাবে ধীৰ।
* যদি আপোনাৰ **বিস্তাৰযোগ্যতা** সমস্যা আছে, তেন্তে আপোনাৰ প্ৰণালী এটা ব্যৱহাৰকাৰীৰ বাবে দ্ৰুত, কিন্তু অধিক লোডত ধীৰ।

### উৎস(সমূহ) আৰু অধিক পঢ়িবলৈ

* [বিস্তাৰযোগ্যতাৰ বিষয়ে এটা কথা](http://www.allthingsdistributed.com/2006/03/a_word_on_scalability.html)
* [বিস্তাৰযোগ্যতা, উপলব্ধতা, স্থিৰতা, পেটাৰ্নসমূহ](http://www.slideshare.net/jboner/scalability-availability-stability-patterns/)

## বিলম্ব বনাম থ্ৰুপুট

**বিলম্ব** হৈছে কোনো কাৰ্য্য সম্পাদন কৰিবলৈ বা ফলাফল উত্পন্ন কৰিবলৈ সময়ৰ প্ৰয়োজন।

**থ্ৰুপুট** হৈছে এই ধৰণৰ কার্য্য বা ফলাফলৰ সংখ্যা একক সময়ত।

সাধাৰণতে, আপোনাই **সৰ্বাধিক থ্ৰুপুট** লক্ষ্য কৰা উচিত **গ্ৰহণযোগ্য বিলম্ব**ৰ সৈতে।

### উৎস(সমূহ) আৰু অধিক পঢ়িবলৈ

* [বিলম্ব বনাম থ্ৰুপুট বুজা](https://community.cadence.com/cadence_blogs_8/b/fv/posts/understanding-latency-vs-throughput)

## উপলব্ধতা বনাম সুসংগতিতা

### CAP তত্ত্ব

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/bgLMI2u.png">
  <br/>
  <i><a href=http://robertgreiner.com/2014/08/cap-theorem-revisited>উৎস: CAP তত্ত্ব পুনৰ আলোচনা</a></i>
</p>

এখন বিতৰণ কৰা কম্পিউটাৰ প্ৰণালীত, আপুনি তলত দিয়া তিনিটা নিশ্চয়তাৰ ভিতৰত কেৱল দুটা মাত্ৰ সমৰ্থন কৰিব পাৰে:

* **সঙ্গততা (Consistency)** - প্ৰতিটো পঢ়াইয়ে আটাইতকৈ নতুন লিখন অথবা এটা ত্ৰুটি লাভ কৰে
* **উপলব্ধতা (Availability)** - প্ৰতিটো অনুৰোধে এটা প্ৰতিক্ৰিয়া লাভ কৰে, এতিয়া নিশ্চিত নহয় যে সেইটো আটাইতকৈ নতুন তথ্যৰ সংস্কৰণ
* **বিভাজন সহনশীলতা (Partition Tolerance)** - নেটৱৰ্ক বিফলতাৰ বাবে যিকোনো বিভাজন হোৱাৰ পিছতো প্ৰণালী চলি থাকে

*নেটৱৰ্ক অৱিশ্বাস্য, গতিকে আপোনাক বিভাজন সহনশীলতা সমৰ্থন কৰিব লাগিব।  আপোনাক ছফ্টৱেৰ হিচাপে সঙ্গততা আৰু উপলব্ধতাৰ মাজত বাণিজ্যিক সমঝোতা কৰিব লাগিব।*

#### CP - সঙ্গততা আৰু বিভাজন সহনশীলতা

বিভাজিত নোডৰ পৰা প্ৰতিক্ৰিয়া বিচাৰোতে সময় শেষৰ ত্ৰুটি দেখা দিব পাৰে।  আপোনাৰ ব্যৱসায়িক দাবীত যদিহে এটমিক পঢ়া আৰু লিখা প্ৰয়োজন, CP এটা ভাল বিকল্প।

#### AP - উপলব্ধতা আৰু বিভাজন সহনশীলতা

প্ৰতিক্ৰিয়াবোৰ যিকোনো নোডত উপলব্ধ থকা আটাইতকৈ সহজ তথ্যৰ সংস্কৰণ প্ৰদান কৰে, যি আটাইতকৈ নতুন নাও হ’ব পাৰে।  লিখাবোৰ বিভাজন সমাধান হোৱাৰ পিছত কিছু সময় লৈ প্ৰসাৰিত হ’ব পাৰে।

AP ভাল বিকল্প যদি ব্যৱসায়িক দাবীত [অৱশেষত সঙ্গততা](#eventual-consistency) অনুমোদন কৰিব লাগে বা প্ৰণালীয়ে বাহ্যিক ত্ৰুটিতো চলি থাকিব লাগে।

### উৎস(সমূহ) আৰু অধিক পঢ়িবলৈ

* [CAP তত্ত্ব পুনৰ আলোচনা](http://robertgreiner.com/2014/08/cap-theorem-revisited/)
* [CAP তত্ত্বৰ সহজ ভাষাত পৰিচয়](http://ksat.me/a-plain-english-introduction-to-cap-theorem)
* [CAP FAQ](https://github.com/henryr/cap-faq)
* [CAP তত্ত্ব](https://www.youtube.com/watch?v=k-Yaq8AHlFA)

## সঙ্গততাৰ পেটাৰ্নসমূহ

এটা তথ্যৰ একাধিক প্ৰতিলিপি থকা অৱস্থাত, আমাক সেইবোৰ কেনেকৈ সমন্বয় কৰিব লাগে যাতে গ্ৰাহকে তথ্যৰ সঙ্গত দৃশ্য পায়, সেই বাছনি কৰিব লাগে।  [CAP তত্ত্ব](#cap-theorem)-ৰ পৰা সঙ্গততাৰ সংজ্ঞা মনত ৰাখিব - প্ৰতিটো পঢ়াইয়ে আটাইতকৈ নতুন লিখন অথবা এটা ত্ৰুটি লাভ কৰে।

### দুর্বল সঙ্গততা

এটা লিখাৰ পিছত, পঢ়াবোৰে সেইটো দেখা পাব বা নাপাব পাৰে।  এটা সৰ্বোত্তম চেষ্টা কৰা হয়।

এই পদ্ধতি memcached আদিত দেখা যায়।  দুর্বল সঙ্গততা বাস্তৱ সময়ৰ ব্যৱহাৰৰ ক্ষেত্ৰত ভালদৰে কাম কৰে, যেনে VoIP, ভিডিঅ’ চেট, আৰু realtime multiplayer গেম।  উদাহৰণস্বৰূপ, যদি আপুনি ফোনত কথাবতৰা কৰি আছে আৰু কিছু সময়ৰ বাবে সংযোগ হেৰাই পেলায়, সংযোগ পুনৰ লাভ কৰোঁতে সংযোগ হেৰোৱাৰ সময়ত কোৱা কথা আপুনি শুনা নাপায়।

### অৱশেষত এক-ৰূপতা (Eventual consistency)

এখন লিখাৰ পিছত, পঢ়া-সমূহে শেষত সেইটো দেখিব (সাধাৰণতে মিলি ছেকেণ্ডৰ ভিতৰত)।  ডাটা অসমান্তৰালভাৱে প্ৰতিৰূপিত হয়।

এই পদ্ধতি DNS আৰু ই-মেইল দৰে ব্যৱস্থাত দেখা যায়।  অৱশেষত এক-ৰূপতা উচ্চ উপলভ্যতা থকা ব্যৱস্থাত ভালকৈ কাম কৰে।

### শক্তিশালী এক-ৰূপতা (Strong consistency)

এখন লিখাৰ পিছত, পঢ়া-সমূহে সেইটো দেখিব।  ডাটা সমান্তৰালভাৱে প্ৰতিৰূপিত হয়।

এই পদ্ধতি ফাইল চিস্টেম আৰু RDBMS-ত দেখা যায়।  শক্তিশালী এক-ৰূপতা লেন-দেনৰ প্ৰয়োজন থকা ব্যৱস্থাত ভালকৈ কাম কৰে।

### উৎস(সমূহ) আৰু অধিক পঢ়া

* [ডাটা চেন্টাৰত লেন-দেন](http://snarfed.org/transactions_across_datacenters_io.html)

## উপলভ্যতা পেটাৰ্ণসমূহ

উচ্চ উপলভ্যতা সহায় কৰিবলৈ দুটা সম্পূৰক পেটাৰ্ণ আছে: **ফেইল-ওভাৰ** আৰু **প্ৰতিৰূপণ**।

### ফেইল-ওভাৰ

#### সক্ৰিয়-নিষ্ক্ৰিয় (Active-passive)

সক্ৰিয়-নিষ্ক্ৰিয় ফেইল-ওভাৰত, হৃদস্পন্দন (heartbeat) সক্ৰিয় আৰু ষ্টেন্ডবাই থকা নিষ্ক্ৰিয় ছাৰ্ভাৰৰ মাজত পঠোৱা হয়।  যদি হৃদস্পন্দন বন্ধ হয়, নিষ্ক্ৰিয় ছাৰ্ভাৰ সক্ৰিয়ৰ IP ঠিকনা লৈ সেৱা আৰম্ভ কৰে।

ডাউনটাইমৰ দৈৰ্ঘ্য নিৰ্ধাৰণ কৰা হয় নিষ্ক্ৰিয় ছাৰ্ভাৰ 'হট' ষ্টেন্ডবাইত চলি আছে নে 'কোল্ড' ষ্টেন্ডবাইৰ পৰা আৰম্ভ কৰিব লাগিব।  কেৱল সক্ৰিয় ছাৰ্ভাৰেই ট্ৰাফিক ব্যৱস্থাপনা কৰে।

সক্ৰিয়-নিষ্ক্ৰিয় ফেইল-ওভাৰক মাষ্টাৰ-চ্লেভ ফেইল-ওভাৰ বুলি কোৱা হয়।

#### সক্ৰিয়-সক্ৰিয় (Active-active)

সক্ৰিয়-সক্ৰিয়ত, দুয়োটা ছাৰ্ভাৰেই ট্ৰাফিক ব্যৱস্থাপনা কৰে, লোডৰ ভাগ-বতৰা কৰে।

যদি ছাৰ্ভাৰসমূহ পাব্লিক-মুখী হয়, DNS-এ দুয়োটা ছাৰ্ভাৰৰ পাব্লিক IP জানিব লাগিব।  যদি ছাৰ্ভাৰসমূহ আন্তঃ-ৰূপে মুখী হয়, এপ্লিকেচন লজিক-এ দুয়োটা ছাৰ্ভাৰৰ বিষয়ে জানিব লাগিব।

সক্ৰিয়-সক্ৰিয় ফেইল-ওভাৰক মাষ্টাৰ-মাষ্টাৰ ফেইল-ওভাৰ বুলি কোৱা হয়।

### অপৰিসীম(সমূহ): ফেইল-ওভাৰ

* ফেইল-ওভাৰ অধিক হাৰ্ডৱেৰ আৰু অতিৰিক্ত জটিলতা যোগ কৰে।
* যদি সক্ৰিয় ব্যৱস্থা বিফল হয় আৰু কোনো নতুন লিখা তথ্য নিষ্ক্ৰিয়লৈ প্ৰতিলিপি কৰাৰ আগতে, তেতিয়া তথ্য হেৰুৱা সম্ভাৱনা থাকে।

### প্ৰতিলিপি

#### মাষ্টাৰ-চাকৰ আৰু মাষ্টাৰ-মাষ্টাৰ

এই বিষয়টো [ডাটাবেছ](#database) অনুচ্ছেদত অধিক আলোচনা কৰা হৈছে:

* [মাষ্টাৰ-চাকৰ প্ৰতিলিপি](#master-slave-replication)
* [মাষ্টাৰ-মাষ্টাৰ প্ৰতিলিপি](#master-master-replication)

### সংখ্যাত উপলভ্যতা

উপলভ্যতা সাধাৰণতে আপটাইম (বা ডাউনটাইম) হিচাপে শতাংশৰ দ্বাৰা পৰিমাপ কৰা হয়, অৰ্থাৎ সেৱা উপলভ্য থকা সময়ৰ শতাংশ। উপলভ্যতা সাধাৰণতে 9 সংখ্যাৰ দ্বাৰা মাপা হয়--99.99% উপলভ্যতা থকা সেৱা চাৰিটা 9 আছে বুলি বৰ্ণনা কৰা হয়।

#### 99.9% উপলভ্যতা - তিনি 9

| সময়কাল              | গ্ৰহণযোগ্য ডাউনটাইম|
|----------------------|--------------------|
| বছৰত ডাউনটাইম      | 8ঘণ্টা 45মিনিট 57ছেকেণ্ড       |
| মাহত ডাউনটাইম       | 43মিনিট 49.7ছেকেণ্ড           |
| সপ্তাহত ডাউনটাইম    | 10মিনিট 4.8ছেকেণ্ড           |
| দিনত ডাউনটাইম       | 1মিনিট 26.4ছেকেণ্ড           |

#### 99.99% উপলভ্যতা - চাৰি 9

| সময়কাল              | গ্ৰহণযোগ্য ডাউনটাইম|
|----------------------|--------------------|
| বছৰত ডাউনটাইম      | 52মিনিট 35.7ছেকেণ্ড        |
| মাহত ডাউনটাইম       | 4মিনিট 23ছেকেণ্ড             |
| সপ্তাহত ডাউনটাইম    | 1মিনিট 5ছেকেণ্ড              |
| দিনত ডাউনটাইম       | 8.6ছেকেণ্ড               |

#### সমান্তৰালত আৰু ক্ৰমান্বয়ে উপলভ্যতা

যদি এটা সেৱা বহুতো উপাদানৰে গঠিত যি বিফল হোৱাৰ সম্ভাৱনা আছে, তেন্তে সেৱাটোৰ সামগ্ৰিক উপলভ্যতা নিৰ্ভৰ কৰে উপাদানসমূহ ক্ৰমান্বয়ে বা সমান্তৰালত আছে নে নাই।

###### ক্ৰমান্বয়ে
যেতিয়া ১০০%তকৈ কম উপলব্ধতাৰ সৈতে দুটা উপাদান শৃংখলাবদ্ধভাৱে থাকে, তেতিয়া সামগ্ৰিক উপলব্ধতা হ্ৰাস হয়:


```
Availability (Total) = Availability (Foo) * Availability (Bar)
```

যদি `Foo` আৰু `Bar` দুয়োটা ৯৯.৯% উপলব্ধতা থকা হয়, তেন্তে তেওঁলোকৰ ক্ৰমিক মুঠ উপলব্ধতা ৯৯.৮% হ’ব।

###### সমান্তৰালভাৱে

যেতিয়া উপলব্ধতা < ১০০% থকা দুইটা অংশ সমান্তৰালভাৱে থাকে, মুঠ উপলব্ধতা বৃদ্ধি পায়:

```
Availability (Total) = 1 - (1 - Availability (Foo)) * (1 - Availability (Bar))
```
যদি `Foo` আৰু `Bar` দুয়োটাৰ ৯৯.৯% উপলব্ধতা থাকে, তেন্তে তেওঁলোকৰ মুঠ উপলব্ধতা সমান্তৰালভাৱে ৯৯.৯৯৯৯% হ’ব।

## ড’মেইন নাম ছিষ্টেম

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/IOyLj4i.jpg">
  <br/>
  <i><a href=http://www.slideshare.net/srikrupa5/dns-security-presentation-issa>উৎস: DNS সুৰক্ষা প্ৰেজেন্টেচন</a></i>
</p>

এটা ড’মেইন নাম ছিষ্টেম (DNS) এ www.example.com যেনে এটা ড’মেইন নামক এটা IP ঠিকনালৈ অনুবাদ কৰে।

DNS গঠনগতভাৱে হায়াৰাৰ্কিকেল, ওপৰৰ স্তৰত কিছুমান অথৰিটেটিভ ছাৰ্ভাৰ থাকে। আপোনাৰ ৰাউটাৰ বা ISP-এ DNS ছাৰ্ভাৰ(সমূহ)ৰ তথ্য দিয়ে lookup কৰাৰ সময়ত। তলৰ স্তৰৰ DNS ছাৰ্ভাৰসমূহে মেপিংসমূহ cache কৰে, যি DNS propagation বিলম্বৰ বাবে পুৰণি হ’ব পাৰে। DNS ফলাফলসমূহ আপোনাৰ ব্ৰাউজাৰ বা OS-এও এটা নিৰ্দিষ্ট সময়ৰ বাবে cache কৰিব পাৰে, যি [time to live (TTL)](https://en.wikipedia.org/wiki/Time_to_live) দ্বাৰা নিৰ্ধাৰিত।

* **NS ৰেকৰ্ড (name server)** - আপোনাৰ ড’মেইন/সাবড’মেইনৰ বাবে DNS ছাৰ্ভাৰ নিৰ্দিষ্ট কৰে।
* **MX ৰেকৰ্ড (mail exchange)** - বাৰ্তা গ্ৰহণৰ বাবে মেইল ছাৰ্ভাৰ নিৰ্দিষ্ট কৰে।
* **A ৰেকৰ্ড (address)** - এটা নামক এটা IP ঠিকনালৈ নির্দেশ কৰে।
* **CNAME (canonical)** - এটা নামক আন এটা নাম বা `CNAME` (example.com ৰ পৰা www.example.com) বা `A` ৰেকৰ্ডলৈ নির্দেশ কৰে।

[CloudFlare](https://www.cloudflare.com/dns/) আৰু [Route 53](https://aws.amazon.com/route53/) যেনে সেৱাসমূহে পৰিচালিত DNS সেৱা প্ৰদান কৰে। কিছুমান DNS সেৱাই বিভিন্ন পদ্ধতিৰে ট্ৰেফিক ৰাউট কৰিব পাৰে:

* [Weighted round robin](https://www.jscape.com/blog/load-balancing-algorithms)
    * ৰক্ষণাবেক্ষণত থকা ছাৰ্ভাৰসমূহলৈ ট্ৰেফিক যোৱাৰ পৰা ৰক্ষা কৰে
    * বিভিন্ন ক্লাষ্টাৰৰ আকাৰৰ মাজত বেলেন্স কৰে
    * A/B পৰীক্ষা
* [Latency-based](https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/routing-policy-latency.html)
* [Geolocation-based](https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/routing-policy-geo.html)

### অসুবিধা(সমূহ): DNS

* এটা DNS ছাৰ্ভাৰত প্ৰবেশ কৰোঁতে অলপ বিলম্ব হয়, যদিও ওপৰত বৰ্ণনা কৰা caching-এ এইটো হ্ৰাস কৰে।
* DNS ছাৰ্ভাৰ ব্যৱস্থাপনা জটিল হ’ব পাৰে আৰু সাধাৰণতে [সরকাৰ, ISP আৰু ডাঙৰ কোম্পানীসমূহে](http://superuser.com/questions/472695/who-controls-the-dns-servers/472729) ব্যৱস্থাপনা কৰে।
* DNS সেৱাসমূহে অলপতে [DDoS আক্ৰমণ](http://dyn.com/blog/dyn-analysis-summary-of-friday-october-21-attack/)ৰ সন্মুখীন হৈছে, যাৰ ফলত ব্যৱহাৰকাৰীসকলে Twitterৰ IP ঠিকনাসমূহ নাজানিলে Twitter যেনে ৱেবছাইটসমূহত প্ৰৱেশ কৰিব নোৱাৰে।

### উৎস(সমূহ) আৰু অধিক পঢ়িবলৈ

* [DNS স্থাপত্য](https://technet.microsoft.com/en-us/library/dd197427(v=ws.10).aspx)
* [উইকিপিডিয়া](https://en.wikipedia.org/wiki/Domain_Name_System)
* [DNS সম্পৰ্কীয় প্ৰবন্ধ](https://support.dnsimple.com/categories/dns/)

## কন্টেন্ট ডেলিভাৰী নেটৱৰ্ক

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/h9TAuGI.jpg">
  <br/>
  <i><a href=https://www.creative-artworks.eu/why-use-a-content-delivery-network-cdn/>উৎস: কিয় CDN ব্যৱহাৰ কৰিব</a></i>
</p>

এটা কন্টেন্ট ডেলিভাৰী নেটৱৰ্ক (CDN) হৈছে বিশ্বব্যাপী বিতৰিত প্ৰক্সি ছাৰ্ভাৰৰ এক নেটৱৰ্ক, যি ব্যৱহাৰকাৰীৰ ওচৰৰ স্থানসমূহৰ পৰা কন্টেন্ট প্ৰদান কৰে। সাধাৰণতে, HTML/CSS/JS, ফটো, আৰু ভিডিঅ'ৰ দৰে ষ্টেটিক ফাইল CDN ৰ পৰা প্ৰদান কৰা হয়, যদিও Amazon ৰ CloudFront ৰ দৰে কিছুমান CDN-এ ডাইনামিক কন্টেন্ট সমৰ্থন কৰে। চাইটৰ DNS ৰিজলিউচনে ক্লায়েন্টক কোন ছাৰ্ভাৰৰ সৈতে যোগাযোগ কৰিব সেইটো জনায়।

CDN ৰ পৰা কন্টেন্ট প্ৰদান কৰোঁতে দুটা উপায়ত কার্যক্ষমতা যথেষ্ট বৃদ্ধি কৰিব পাৰে:

* ব্যৱহাৰকাৰীয়ে তেওঁলোকৰ ওচৰৰ ডাটা চেন্টাৰৰ পৰা কন্টেন্ট লাভ কৰে
* আপোনাৰ ছাৰ্ভাৰে CDN-এ পূৰণ কৰা অনুৰোধসমূহ প্ৰদান কৰিব নালাগে

### পুশ CDN

পুশ CDN-এ আপোনাৰ ছাৰ্ভাৰত পৰিৱৰ্তন ঘটিলে নতুন কন্টেন্ট লাভ কৰে। আপুনি সম্পূৰ্ণ দায়িত্ব লৈ কন্টেন্ট প্ৰদান কৰে, CDN ত সোজাকৈ আপলোড কৰে আৰু URL সমূহ CDN ত নির্দেশ কৰে। আপুনি কন্টেন্ট কেতিয়া মেয়াদ উত্তীর্ণ হ'ব আৰু কেতিয়া আপডেট হ'ব, সেইটো নিৰ্ধাৰণ কৰিব পাৰে। কন্টেন্ট কেৱল নতুন বা পৰিৱৰ্তিত হ'লে আপলোড কৰা হয়, ফলত ট্ৰাফিক কম হয়, কিন্তু ষ্ট'ৰেজ বৃদ্ধি পায়।

অল্প পৰিমাণৰ ট্ৰাফিক থকা চাইট অথবা যি চাইটত কন্টেন্ট প্ৰায়ে আপডেট নহয়, সেইবোৰ পুশ CDN ৰ সৈতে ভালকৈ কাম কৰে। কন্টেন্ট এটা বাৰ CDN ত ৰাখা হয়, নিয়মীয়াকৈ পুনৰ-পুল কৰা নহয়।

### পুল CDN

পুল CDN-এ প্ৰথম ব্যৱহাৰকাৰীয়ে কন্টেন্ট অনুৰোধ কৰিলে আপোনাৰ ছাৰ্ভাৰৰ পৰা নতুন কন্টেন্ট গ্ৰহণ কৰে। আপুনি কন্টেন্ট আপোনাৰ ছাৰ্ভাৰত ৰাখে আৰু URL সমূহ CDN ত নির্দেশ কৰে। এইটোত CDN ত কেচ কৰা নোহোৱা পৰ্যন্ত অনুৰোধটো অলপ মন্থৰ হয়।

এটা [time-to-live (TTL)](https://en.wikipedia.org/wiki/Time_to_live) নিৰ্ধাৰণ কৰে কিমান সময় কন্টেন্ট কেচ কৰা হ'ব। পুল CDN-এ CDN ত ষ্ট'ৰেজ স্পেচ কম কৰে, কিন্তু যদি ফাইলসমূহ মেয়াদ উত্তীর্ণ হয় আৰু পুনৰ পুল কৰা হয়, তেন্তে অপ্ৰয়োজনীয় ট্ৰাফিক সৃষ্টি কৰিব পাৰে।

বেছি ট্ৰাফিক থকা চাইটসমূহ পুল CDN ৰ সৈতে ভাল কাম কৰে, কাৰণ ট্ৰাফিক অধিক সমভাৱে বিতৰণ হয় আৰু কেৱল নতুন অনুৰোধ কৰা কন্টেন্ট CDN ত থাকে।

### অসুবিধা(সমূহ): CDN

* CDN ৰ খৰচ ট্ৰাফিকৰ ওপৰত নিৰ্ভৰ কৰি উল্লেখযোগ্য হ’ব পাৰে, যদিও CDN ব্যৱহাৰ নকৰিলে হোৱা অতিৰিক্ত খৰচৰ সৈতে এইটো তুলনা কৰিব লাগে।
* TTL শেষ হোৱাৰ আগতে কন্টেন্ট আপডেট কৰিলে, CDN ত কন্টেন্ট পুৰণা হ’ব পাৰে।
* CDN ব্যৱহাৰ কৰিবলৈ ষ্টেটিক কন্টেন্টৰ URL CDN ত নির্দেশ কৰিব লগা হয়।

### উৎস(সমূহ) আৰু অধিক পঢ়িবলৈ

* [বিশ্বব্যাপী বিতৰিত কন্টেন্ট ডেলিভাৰী](https://figshare.com/articles/Globally_distributed_content_delivery/6605972)
* [পুশ আৰু পুল CDN ৰ মাজত পাৰ্থক্য](http://www.travelblogadvice.com/technical/the-differences-between-push-and-pull-cdns/)

* [ৱিকিপিডিয়া](https://en.wikipedia.org/wiki/Content_delivery_network)

## লোড বেলেন্সাৰ

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/h81n9iK.png">
  <br/>
  <i><a href=http://horicky.blogspot.com/2010/10/scalable-system-design-patterns.html>উৎস: স্কেলেবেল চিষ্টেম ডিজাইন প্যাটাৰ্ন</a></i>
</p>

লোড বেলেন্সাৰসমূহে আহি থকা ক্লায়েন্ট অনুৰোধসমূহ কম্পিউটিং ৰিসোৰ্চ যেনে এপ্লিকেশ্বন ছাৰ্ভাৰ আৰু ডেটাবেছলৈ বিতৰণ কৰে।  প্ৰতিটো ক্ষেত্ৰত, লোড বেলেন্সাৰে কম্পিউটিং ৰিসোৰ্চৰ পৰা উত্তৰ উপযুক্ত ক্লায়েন্টলৈ পঠিয়ায়।  লোড বেলেন্সাৰসমূহ ইয়াত কাৰ্যকৰী:

* অসুস্থ ছাৰ্ভাৰলৈ অনুৰোধ যোৱাৰ পৰা প্ৰতিষেধ কৰা
* ৰিসোৰ্চ অধিক ভৰাই পৰাৰ পৰা প্ৰতিষেধ কৰা
* এটা একক বিফলতাৰ বিন্দু দূৰ কৰা

লোড বেলেন্সাৰসমূহ হাৰ্ডৱেৰ (মূল্যবান) বা HAProxy সদৃশ ছফটৱেৰ ব্যৱহাৰ কৰি প্ৰয়োগ কৰিব পাৰি।

অতিৰিক্ত সুবিধাসমূহ অন্তর্ভুক্ত:

* **SSL টাৰ্মিনেচন** - আহি থকা অনুৰোধসমূহ ডিক্ৰিপ্ট কৰা আৰু ছাৰ্ভাৰৰ উত্তৰসমূহ এনক্ৰিপ্ট কৰা যাতে ব্যাকএণ্ড ছাৰ্ভাৰসমূহে এই সম্ভাৱ্য মূল্যবান অপাৰেশ্বনসমূহ কৰিব নালাগে
    * প্ৰতিটো ছাৰ্ভাৰত [X.509 চাৰ্টিফিকেট](https://en.wikipedia.org/wiki/X.509) ইনষ্টল কৰাৰ প্ৰয়োজন আঁতৰাই
* **চেছন স্থায়ীত্ব** - কুকি ইস্যু কৰা আৰু যদি ৱেব এপ্লিকেশ্বনসমূহে চেছন সংৰক্ষণ নকৰে, তেন্তে নিৰ্দিষ্ট ক্লায়েন্টৰ অনুৰোধ একে ইনষ্টেন্সলৈ ৰাউট কৰা

বিফলতাৰ পৰা সুৰক্ষিত থাকিবলৈ, সাধাৰণতে বহু লোড বেলেন্সাৰ সংস্থাপন কৰা হয়, [active-passive](#active-passive) বা [active-active](#active-active) মুডত।

লোড বেলেন্সাৰসমূহে বিভিন্ন মেট্ৰিকৰ আধাৰত ট্ৰাফিক ৰাউট কৰিব পাৰে, যেনে:

* ৰেণ্ডম
* আটাইতকৈ কম ভৰাই থকা
* চেছন/কুকি
* [Round robin বা weighted round robin](https://www.g33kinfo.com/info/round-robin-vs-weighted-round-robin-lb)
* [Layer 4](#layer-4-load-balancing)
* [Layer 7](#layer-7-load-balancing)

### Layer 4 লোড বেলেন্সিং

Layer 4 লোড বেলেন্সাৰসমূহে [ট্ৰান্সপৰ্ট স্তৰ](#communication)-ৰ তথ্য চাই অনুৰোধসমূহ কেনেদৰে বিতৰণ কৰিব সিদ্ধান্ত লয়।  সাধাৰণতে, ইয়াত উৎস, গন্তব্য IP ঠিকনা, আৰু হেডাৰত থকা পোৰ্ট অন্তর্ভুক্ত, কিন্তু পেকেটৰ বিষয়বস্তু নহয়।  Layer 4 লোড বেলেন্সাৰসমূহে নেটৱৰ্ক পেকেটসমূহ আপষ্ট্ৰিম ছাৰ্ভাৰলৈ আগবঢ়ায়, [Network Address Translation (NAT)](https://www.nginx.com/resources/glossary/layer-4-load-balancing/) সম্পাদন কৰে।

### Layer 7 লোড বেলেন্সিং

লেয়াৰ ৭ ল'ড বেলেন্সাৰসমূহে [এপ্লিকেশ্যন স্তৰ](#communication) চাই অনুৰোধসমূহ কেনেদৰে বিতৰণ কৰিব সেইটো সিদ্ধান্ত লয়। এইটোত হেডাৰ, মেছেজ, আৰু কুকীৰ বিষয়বস্তু অন্তর্ভুক্ত কৰিব পাৰে। লেয়াৰ ৭ ল'ড বেলেন্সাৰসমূহে নেটৱৰ্ক ট্ৰাফিক শেষ কৰে, মেছেজ পঢ়ে, ল'ড-বেলেন্সিং সিদ্ধান্ত লয়, তাৰপিছত নিৰ্বাচিত ছাৰ্ভাৰত সংযোগ খোল। উদাহৰণস্বৰূপে, এটা লেয়াৰ ৭ ল'ড বেলেন্সাৰে ভিডিঅ' ট্ৰাফিক ভিডিঅ' হোস্ট কৰা ছাৰ্ভাৰলৈ পঠিয়াব পাৰে আৰু অধিক সংবেদনশীল ইউজাৰ বিলিং ট্ৰাফিক সুৰক্ষিত ছাৰ্ভাৰলৈ পঠিয়াব পাৰে।

লচিলতাৰ মূল্যত, লেয়াৰ ৪ ল'ড বেলেন্সিংয়ে লেয়াৰ ৭তকৈ কম সময় আৰু কম কম্পিউটিং সম্পদৰ প্ৰয়োজন, যদিও আধুনিক কমোডিটি হার্ডৱেৰত প্ৰদৰ্শন প্ৰভাৱ ন্যূনতম হ’ব পাৰে।

### অনুভূমিক স্কেলিং

ল'ড বেলেন্সাৰসমূহে অনুভূমিক স্কেলিঙতো সহায় কৰিব পাৰে, যাৰ ফলত প্ৰদৰ্শন আৰু উপলভ্যতা বৃদ্ধি পায়। কমোডিটি মেচিন ব্যৱহাৰ কৰি স্কেল আউট কৰাটো অধিক ব্যয়-সাশ্ৰয়ী আৰু অধিক উপলভ্যতা প্রদান কৰে, একেটা ছাৰ্ভাৰৰ মূল্যবান হার্ডৱেৰত স্কেল আপ কৰাতকৈ, যাক **Vertical Scaling** বুলি কোৱা হয়। লগতে, কমোডিটি হার্ডৱেৰত কাম কৰা প্ৰতিভা নিয়োগ কৰাটো বিশেষজ্ঞ এণ্টাৰপ্ৰাইজ চিস্টেমতকৈ সহজ।

#### অসুবিধা(সমূহ): অনুভূমিক স্কেলিং

* অনুভূমিকভাৱে স্কেল কৰাটো জটিলতা বৃদ্ধি কৰে আৰু ছাৰ্ভাৰ ক্লোনিং জড়িত থাকে
    * ছাৰ্ভাৰসমূহে ষ্টেটলেছ হ’ব লাগে: ইয়াত ইউজাৰৰ সৈতে সম্পৰ্কিত তথ্য যেনে ছেছন বা প্ৰ'ফাইল ফটো থকা উচিত নহয়
    * ছেছনসমূহ কেন্দ্রীভূত ডাটা ষ্ট'ৰ যেনে [ডেটাবেইজ](#database) (SQL, NoSQL) বা স্থায়ী [কেশ](#cache) (Redis, Memcached)ত সংৰক্ষণ কৰিব পাৰি
* ডাউনষ্ট্ৰিম ছাৰ্ভাৰসমূহ যেনে কেশ আৰু ডেটাবেইজে অধিক একেলগে সংযোগ হেণ্ডল কৰিব লাগিব, যেতিয়া আপষ্ট্ৰিম ছাৰ্ভাৰসমূহ স্কেল আউট কৰে

### অসুবিধা(সমূহ): ল'ড বেলেন্সাৰ

* ল'ড বেলেন্সাৰটোৱে যথেষ্ট সম্পদ নাথাকিলে বা ঠিকমতে কনফিগাৰ কৰা নহ’লে প্ৰদৰ্শন ৰুদ্ধতা হ’ব পাৰে।
* এটা ল'ড বেলেন্সাৰ সংযোজন কৰিলে একক ব্যর্থতাৰ বিন্দু আঁতৰাবলৈ জটিলতা বৃদ্ধি পায়।
* এটা একক ল'ড বেলেন্সাৰ হৈছে একক ব্যর্থতাৰ বিন্দু, একাধিক ল'ড বেলেন্সাৰ কনফিগাৰ কৰিলে জটিলতা আৰু বৃদ্ধি পায়।

### উৎস(সমূহ) আৰু অধিক পঢ়িবলৈ

* [NGINX স্থাপত্য](https://www.nginx.com/blog/inside-nginx-how-we-designed-for-performance-scale/)
* [HAProxy স্থাপত্য গাইড](http://www.haproxy.org/download/1.2/doc/architecture.txt)
* [স্কেলেবিলিটি](https://web.archive.org/web/20220530193911/https://www.lecloud.net/post/7295452622/scalability-for-dummies-part-1-clones)
* [উইকিপিডিয়া](https://en.wikipedia.org/wiki/Load_balancing_(computing))
* [লেয়াৰ ৪ ল'ড বেলেন্সিং](https://www.nginx.com/resources/glossary/layer-4-load-balancing/)
* [লেয়াৰ ৭ ল'ড বেলেন্সিং](https://www.nginx.com/resources/glossary/layer-7-load-balancing/)
* [ELB listener config](http://docs.aws.amazon.com/elasticloadbalancing/latest/classic/elb-listener-config.html)

## ৰিভাৰ্ছ প্ৰক্সি (ৱেব ছাৰ্ভাৰ)

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/n41Azff.png">
  <br/>
  <i><a href=https://upload.wikimedia.org/wikipedia/commons/6/67/Reverse_proxy_h2g2bob.svg>উৎস: উইকিপিডিয়া</a></i>
  <br/>
</p>

এখন ৰিভাৰ্ছ প্ৰক্সি হৈছে এটা ৱেব ছাৰ্ভাৰ যি আন্তঃৰ্ভুক্ত সেৱাসমূহ কেন্দ্রীকৃত কৰে আৰু জনসাধাৰণৰ বাবে একত্ৰিত ইণ্টাৰফেছ প্ৰদান কৰে। ক্লায়েন্টৰ পৰা অহা অনুৰোধসমূহ ছাৰ্ভাৰলৈ আগবঢ়োৱা হয় যি সেই অনুৰোধ পূৰণ কৰিব পাৰে, তাৰ পিছত ৰিভাৰ্ছ প্ৰক্সিয়ে ছাৰ্ভাৰৰ প্ৰতিক্ৰিয়া ক্লায়েন্টলৈ ঘূৰাই দিয়ে।

অতিৰিক্ত লাভসমূহৰ ভিতৰত আছে:

* **নিৰাপত্তা বৃদ্ধি** - বেকএণ্ড ছাৰ্ভাৰৰ বিষয়ে তথ্য লুকুৱায়, IP ব্লেকলিষ্ট কৰে, প্ৰতিটো ক্লায়েন্টৰ বাবে সংযোগৰ সংখ্যা সীমিত কৰে
* **স্কেলেবিলিটি আৰু নমনীয়তা বৃদ্ধি** - ক্লায়েন্টসকলে কেৱল ৰিভাৰ্ছ প্ৰক্সিৰ IP দেখিব, আপোনাৰ ছাৰ্ভাৰসমূহ স্কেল বা কনফিগাৰেশ্যন সলনি কৰিবলৈ সুবিধা দিব
* **SSL টাৰ্মিনেচন** - আহি থকা অনুৰোধসমূহ ডিক্ৰিপ্ট কৰে আৰু ছাৰ্ভাৰৰ প্ৰতিক্ৰিয়াসমূহ এনক্ৰিপ্ট কৰে যাতে বেকএণ্ড ছাৰ্ভাৰসমূহে এই ব্যয়বহুল প্ৰক্ৰিয়াসমূহ কৰিব নালাগে
    * প্ৰতিটো ছাৰ্ভাৰত [X.509 চাৰ্টিফিকেট](https://en.wikipedia.org/wiki/X.509) ইনষ্টল কৰাৰ প্ৰয়োজন নোহোৱা হয়
* **কম্প্ৰেছন** - ছাৰ্ভাৰৰ প্ৰতিক্ৰিয়া কম্প্ৰেছ কৰে
* **কেছিং** - কেছ কৰা অনুৰোধৰ বাবে প্ৰতিক্ৰিয়া ঘূৰাই দিয়ে
* **ষ্টেটিক কনটেন্ট** - ষ্টেটিক কনটেন্ট ডাইৰেক্টলি পৰিসেৱন কৰে
    * HTML/CSS/JS
    * ফটো
    * ভিডিঅ’
    * আদি

### ল’ড বেলেন্সাৰ বনাম ৰিভাৰ্ছ প্ৰক্সি

* একাধিক ছাৰ্ভাৰ থকা অৱস্থাত ল’ড বেলেন্সাৰ স্থাপন কৰা লাভজনক। সাধাৰণতে, ল’ড বেলেন্সাৰসমূহে একেটা ফাংচন কৰা ছাৰ্ভাৰবোৰলৈ ট্ৰাফিক ৰাউট কৰে।
* কেৱল এটা ৱেব ছাৰ্ভাৰ বা এপ্লিকেশ্যন ছাৰ্ভাৰ থকা অৱস্থাতো ৰিভাৰ্ছ প্ৰক্সি উপযোগী, আগৰ অনুচ্ছেদত বৰ্ণনা কৰা লাভসমূহ উপলভ্য কৰে।
* NGINX আৰু HAProxy যেনে সমাধানসমূহে Layer 7 ৰিভাৰ্ছ প্ৰক্সি আৰু ল’ড বেলেন্সিং উভয়কে সমৰ্থন কৰে।

### অসুবিধা(সমূহ): ৰিভাৰ্ছ প্ৰক্সি

* ৰিভাৰ্ছ প্ৰক্সি ব্যৱহাৰ কৰাত জটিলতা বৃদ্ধি হয়।
* এটা ৰিভাৰ্ছ প্ৰক্সি একেটা ফেইলিয়ৰৰ পইণ্ট, একাধিক ৰিভাৰ্ছ প্ৰক্সি (অর্থাৎ [ফেইলোভাৰ](https://en.wikipedia.org/wiki/Failover)) কনফিগাৰ কৰাত অধিক জটিলতা বৃদ্ধি হয়।

### উৎস(সমূহ) আৰু অধিক পঢ়া

* [Reverse proxy vs load balancer](https://www.nginx.com/resources/glossary/reverse-proxy-vs-load-balancer/)
* [NGINX architecture](https://www.nginx.com/blog/inside-nginx-how-we-designed-for-performance-scale/)
* [HAProxy architecture guide](http://www.haproxy.org/download/1.2/doc/architecture.txt)
* [Wikipedia](https://en.wikipedia.org/wiki/Reverse_proxy)

## এপ্লিকেশ্যন স্তৰ

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/yB5SYwm.png">
  <br/>
  <i><a href=http://lethain.com/introduction-to-architecting-systems-for-scale/#platform_layer>উৎস: স্কেলৰ বাবে ছিষ্টেম আৰ্হি কৰোতে পৰিচয়</a></i>
</p>

ৱেব স্তৰটো এপ্লিকেশ্বন স্তৰৰ পৰা (যাক প্লেটফৰ্ম স্তৰো বুলি জনা যায়) পৃথক কৰা হ’লে আপুনি দুয়োটা স্তৰক স্বাধীনভাৱে স্কেল আৰু কনফিগাৰ কৰিব পাৰে। নতুন API যোগ কৰিলে, প্ৰয়োজনত নতুন ৱেব ছাৰ্ভাৰ যোগ নকৰাকৈ এপ্লিকেশ্বন ছাৰ্ভাৰ যোগ হয়। **একক দায়িত্ব নীতি** সৰু আৰু স্বায়ত্ত্বশাসিত সেৱাসমূহৰ বাবেই উৎসাহিত কৰে যি একেলগে কাম কৰে। সৰু দলে সৰু সেৱাসমূহৰ সৈতে দ্ৰুত বৃদ্ধি পোৱাৰ বাবে অধিক আগ্ৰাসীভাৱে পৰিকল্পনা কৰিব পাৰে।

এপ্লিকেশ্বন স্তৰৰ কৰ্মচাৰীয়ে [অসিঙ্ক্ৰনতা](#asynchronism) সক্ষম কৰাত সহায় কৰে।

### মাইক্ৰ’চাৰ্ভিচ

এই আলোচনা সংক্রান্ত [মাইক্ৰ’চাৰ্ভিচ](https://en.wikipedia.org/wiki/Microservices), যাক স্বাধীনভাৱে ডিপ্লয় কৰিব পৰা, সৰু, মডুলাৰ সেৱাসমূহৰ এক ছুট হিচাপে বৰ্ণনা কৰিব পাৰি। প্ৰতিটো সেৱাই এটা অনন্য প্ৰক্ৰিয়া চলায় আৰু এটা সু-সংজ্ঞায়িত, হালকা-ওজনৰ ব্যৱস্থাৰে যোগাযোগ কৰে যাতে ব্যৱসায়িক লক্ষ্য পূৰণ হয়। <sup><a href=https://smartbear.com/learn/api-design/what-are-microservices>1</a></sup>

Pinterest-ৰ উদাহৰণত, তলত দিয়া মাইক্ৰ’চাৰ্ভিচসমূহ থাকিব পাৰে: ব্যৱহাৰকাৰী প্ৰ’ফাইল, ফলোৱৰ, ফিড, সন্ধান, ফটো আপলোড, আদি।

### সেৱা সন্ধান

[Consul](https://www.consul.io/docs/index.html), [Etcd](https://coreos.com/etcd/docs/latest), আৰু [Zookeeper](http://www.slideshare.net/sauravhaloi/introduction-to-apache-zookeeper) যেনে ছিষ্টেমসমূহে নাম, ঠিকনা, আৰু পোৰ্টৰ ৰেজিষ্ট্ৰেশ্বন ৰখা কাৰ্যদ্বাৰা সেৱাসমূহে একে-অন্যক বিচাৰি পোৱাৰ সহায় কৰে। [Health checks](https://www.consul.io/intro/getting-started/checks.html)-এ সেৱা অখণ্ডতা যাচাই কৰাত সহায় কৰে আৰু সাধাৰণতে এটা [HTTP](#hypertext-transfer-protocol-http) এণ্ডপইণ্ট ব্যৱহাৰ কৰে। Consul আৰু Etcd-এ [key-value store](#key-value-store) অন্তর্নিহিত আছে যি কনফিগ মান আৰু অন্যান্য ভাগ-বতৰা ডাটা সংৰক্ষণত সহায়ক।

### অসুবিধাসমূহ: এপ্লিকেশ্বন স্তৰ

* সৰু-সৰু সংযুক্ত সেৱাসমূহৰ সৈতে এপ্লিকেশ্বন স্তৰ যোগ কৰিলে আৰ্হি, অপাৰেশ্বন আৰু প্ৰক্ৰিয়া দৃষ্টিকোণৰ পৰা (একত্ৰিত ছিষ্টেমৰ বিপৰীতে) এক ভিন্ন পদ্ধতিৰ প্ৰয়োজন।
* মাইক্ৰ’চাৰ্ভিচসমূহে ডিপ্লয়মেণ্ট আৰু অপাৰেশ্বনৰ ক্ষেত্ৰত জটিলতা বৃদ্ধি কৰিব পাৰে।

### উৎস আৰু অধিক পঢ়া

* [স্কেলৰ বাবে ছিষ্টেম আৰ্হি কৰোতে পৰিচয়](http://lethain.com/introduction-to-architecting-systems-for-scale)
* [ছিষ্টেম ডিজাইন সাক্ষাৎকাৰ ভাঙি উলিওৱা](http://www.puncsky.com/blog/2016-02-13-crack-the-system-design-interview)
* [চাৰ্ভিচ-অৰিয়েণ্টেড আৰ্কিটেকচাৰ](https://en.wikipedia.org/wiki/Service-oriented_architecture)
* [Zookeeper-ৰ পৰিচয়](http://www.slideshare.net/sauravhaloi/introduction-to-apache-zookeeper)
* [মাইক্ৰ’চাৰ্ভিচ গঢ়ি তুলিবলৈ কি জানিব লাগিব](https://cloudncode.wordpress.com/2016/07/22/msa-getting-started/)

## ডাটাবেছ

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/Xkm5CXz.png">
  <br/>
  <i><a href=https://www.youtube.com/watch?v=kKjm4ehYiMs>উৎস: আপোনাৰ প্ৰথম ১০ নিযুত ব্যৱহাৰকাৰীৰ বাবে স্কেলিং</a></i>
</p>

### ৰিলেচনেল ডাটাবেছ মেনেজমেণ্ট ছিষ্টেম (RDBMS)

এখন রিলেচনেল ডেটাবেছ যেনে SQL হৈছে টেবুলত সংগঠিত ডেটা আইটেমৰ এটা সংগ্ৰহ।

**ACID** হৈছে ৰিলেচনেল ডেটাবেছৰ [ট্ৰানজেকচন](https://en.wikipedia.org/wiki/Database_transaction)ৰ এটা গুণাবলী।

* **এটমিকতা** - প্ৰতিটো ট্ৰানজেকচন সম্পূৰ্ণ বা একো নহয়
* **কনছিষ্টেঞ্চি** - যিকোনো ট্ৰানজেকচনে ডেটাবেছক এটা বৈধ অৱস্থাৰ পৰা আন এটা বৈধ অৱস্থালৈ লৈ যায়
* **আইচলেচন** - একেলগে ট্ৰানজেকচন চলালে ফলাফল একে থাকে যেনে ট্ৰানজেকচনবোৰ একে একে চলোৱা হৈছিল
* **ডিউৰেবিলিটি** - এটা ট্ৰানজেকচন কমিট হোৱা পৰাহে, সেইটো স্থায়ী হৈ থাকে

ৰিলেচনেল ডেটাবেছ স্কেল কৰিবলৈ বহু প্ৰযুক্তি আছে: **মাষ্টাৰ-চ্লেভ ৰেপ্লিকেচন**, **মাষ্টাৰ-মাষ্টাৰ ৰেপ্লিকেচন**, **ফেডাৰেছন**, **শাৰ্ডিং**, **ডিনৰমেলাইজেচন**, আৰু **SQL টিউনিং**।

#### মাষ্টাৰ-চ্লেভ ৰেপ্লিকেচন

মাষ্টাৰে ৰিড আৰু ৰাইট কৰে, আৰু ৰাইটবোৰ চ্লেভলৈ ৰেপ্লিকেট কৰে, যিয়ে কেৱল ৰিড কৰে।  চ্লেভে আৰু অধিক চ্লেভলৈ ৰেপ্লিকেট কৰিব পাৰে গছৰ দৰে।  যদি মাষ্টাৰ অফলাইন হয়, চিস্টেমে কেৱল ৰিড মুডত চলি থাকে যেতিয়ালৈকে চ্লেভক মাষ্টাৰত উন্নীত কৰা নহয় বা নতুন মাষ্টাৰ দিয়াৰ ব্যৱস্থা কৰা নহয়।

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/C9ioGtn.png">
  <br/>
  <i><a href=http://www.slideshare.net/jboner/scalability-availability-stability-patterns/>উৎস: Scalability, availability, stability, patterns</a></i>
</p>

##### অসুবিধা(সমূহ): মাষ্টাৰ-চ্লেভ ৰেপ্লিকেচন

* চ্লেভক মাষ্টাৰত উন্নীত কৰিবলৈ অতিৰিক্ত যুক্তি লাগে।
* [অসুবিধা(সমূহ): ৰেপ্লিকেচন](#disadvantages-replication)ত উল্লেখিত পইণ্টবোৰ **উভয়** মাষ্টাৰ-চ্লেভ আৰু মাষ্টাৰ-মাষ্টাৰৰ ক্ষেত্ৰত প্ৰযোজ্য।

#### মাষ্টাৰ-মাষ্টাৰ ৰেপ্লিকেচন

উভয় মাষ্টাৰে ৰিড আৰু ৰাইট কৰে আৰু ৰাইটবোৰত পৰস্পৰে সমন্বয় কৰে।  যদি যিকোনো মাষ্টাৰ ডাউন হয়, চিস্টেমে ৰিড আৰু ৰাইট দুয়ো চলাই ৰাখিব পাৰে।

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/krAHLGg.png">
  <br/>
  <i><a href=http://www.slideshare.net/jboner/scalability-availability-stability-patterns/>উৎস: Scalability, availability, stability, patterns</a></i>
</p>

##### অসুবিধা(সমূহ): মাষ্টাৰ-মাষ্টাৰ ৰেপ্লিকেচন

* আপোনাৰ এটা লোড বেলেন্সাৰৰ প্ৰয়োজন হব বা আপোনাৰ এপ্লিকেচন যুক্তিত পৰিবর্তন আনিব লাগিব ক'ত ৰাইট কৰিব সেইটো নির্ধাৰণ কৰিবলৈ।
* বেছি ভাগ মাষ্টাৰ-মাষ্টাৰ চিস্টেম বা তলতকৈ কম কনছিষ্টেন্ট (ACID ভংগ কৰে) বা ছিঙ্ক্ৰনাইজেশ্যনৰ বাবে ৰাইট লেটেন্সি বৃদ্ধি হয়।
* অধিকসংখ্যক write node যোগ হোৱাৰ লগে লগে আৰু latency বাঢ়ি যোৱাৰ লগে লগে conflict resolution অধিক প্ৰাসংগিক হৈ পৰে।
* **Master-slave** আৰু **master-master** উভয়ৰ ক্ষেত্ৰত প্ৰযোজ্য point-সমূহৰ বাবে [অসুবিধা(সমূহ): প্ৰতিলিপি](#disadvantages-replication) চাওক।

##### অসুবিধা(সমূহ): প্ৰতিলিপি

* যদি master-এ ব্যৰ্থ হয় আৰু কোনো নতুন লিখা data অন্য node-সমূহলৈ প্ৰতিলিপি হোৱাৰ আগতে, data হেৰাই যাবৰ সম্ভাৱনা থাকে।
* লেখাসমূহ read replica-সমূহলৈ পুনৰ বাজোৱা হয়।  যদি বহুত write থাকে, তেন্তে read replica-সমূহ write-সমূহ পুনৰ বাজোৱাত ব্যস্ত হৈ পৰে আৰু যথেষ্ট সংখ্যক read কৰিব নোৱাৰে।
* অধিকসংখ্যক read slave থাকিলে, অধিক প্ৰতিলিপি কৰিব লাগিব, যাৰ ফলত প্ৰতিলিপি lag বাঢ়ে।
* কিছুমান ব্যৱস্থাত, master-লৈ লিখাৰ সময়ত একাধিক thread-এ সমান্তৰালভাৱে লিখাৰ কাজ আৰম্ভ কৰিব পাৰে, কিন্তু read replica-সমূহ কেৱল single thread-এ sequential লিখা সমৰ্থন কৰে।
* প্ৰতিলিপি কৰাত অধিক hardware আৰু অতিৰিক্ত জটিলতা যোগ হয়।

##### উৎস(সমূহ) আৰু অধিক পঢ়া: প্ৰতিলিপি

* [Scalability, availability, stability, patterns](http://www.slideshare.net/jboner/scalability-availability-stability-patterns/)
* [Multi-master replication](https://en.wikipedia.org/wiki/Multi-master_replication)

#### ফেডাৰেচন

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/U3qV33e.png">
  <br/>
  <i><a href=https://www.youtube.com/watch?v=kKjm4ehYiMs>উৎস: Scaling up to your first 10 million users</a></i>
</p>

ফেডাৰেচন (অথবা functional partitioning) ডাটাবেইজসমূহক function অনুসৰি বিভাজিত কৰে।  উদাহৰণস্বৰূপ, এটা single, monolithic ডাটাবেইজৰ পৰিৱর্তে, আপুনি তিনিটা ডাটাবেইজ ৰাখিব পাৰে: **forums**, **users**, আৰু **products**, যাৰ ফলত প্ৰতিটো ডাটাবেইজত read আৰু write traffic কম হয় আৰু সেই অনুসৰি প্ৰতিলিপি lag কম হয়।  সৰু ডাটাবেইজৰ বাবে অধিক data memory-ত সংৰক্ষণ কৰিব পাৰি, যাৰ ফলত cache locality উন্নত হোৱাৰ বাবে অধিক cache hit হয়।  কোনো এটা কেন্দ্ৰীয় master-এ write serialise নকৰাত আপুনি সমান্তৰালভাৱে লিখিব পাৰে, যাৰ ফলত throughput বাঢ়ে।

##### অসুবিধা(সমূহ): ফেডাৰেচন

* যদি আপোনাৰ schema-ত বৃহৎ function বা tableৰ প্ৰয়োজন হয়, তেন্তে ফেডাৰেচন প্ৰভাৱশালী নহয়।
* ক'ত read আৰু write কৰিব লাগিব, সেইটো নিৰ্ধাৰণ কৰিবলৈ আপোনাৰ application logic আপডেট কৰিব লাগিব।
* দুটা ডাটাবেইজৰ data join কৰাটো [server link](http://stackoverflow.com/questions/5145637/querying-data-by-joining-two-tables-in-two-database-on-different-servers)-ৰ সহায়ত অধিক জটিল।
* ফেডাৰেচন-এ অধিক hardware আৰু অতিৰিক্ত জটিলতা যোগ কৰে।

##### উৎস(সমূহ) আৰু অধিক পঢ়া: ফেডাৰেচন

* [Scaling up to your first 10 million users](https://www.youtube.com/watch?v=kKjm4ehYiMs)

#### শাৰ্ডিং

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/wU8x5Id.png">
  <br/>
  <i><a href=http://www.slideshare.net/jboner/scalability-availability-stability-patterns/>উৎস: Scalability, availability, stability, patterns</a></i>
</p>

Sharding-এ তথ্য বিৱিধ ডাটাবেছত বিতৰণ কৰা হয়, যাতে প্ৰতিটো ডাটাবেছ কেৱল তথ্যৰ এটা অংশহে পৰিচালনা কৰিব পাৰে।  উদাহৰণস্বৰূপে, যদি এটা users database লৈ ধৰা হয়, ব্যৱহাৰকাৰীৰ সংখ্যা বৃদ্ধি হোৱা অনুসৰি, ক্লাষ্টাৰত অধিক shard যোগ কৰা হয়।

[federation](#federation)-ৰ সুবিধাসমূহৰ দৰে, sharding-এ কম পঢ়া আৰু লিখা traffic, কম replication, আৰু অধিক cache hit ফলাফল কৰে।  Index-ৰ আকাৰো কম হয়, যাৰ ফলত সাধাৰণতে query অধিক দ্ৰুত হয়।  যদি এটা shard ডাউন হয়, আন shardবোৰ চলি থাকে, যদিও data loss ৰোধ কৰিবলৈ replication ব্যৱহাৰ কৰিব লাগিব।  Federation-ৰ দৰে, ইয়াতো লিখা serialization কৰা এটা কেন্দ্ৰীয় master নাই, ফলত সমান্তৰালভাৱে লিখা সম্ভব আৰু throughput বৃদ্ধি হয়।

ব্যৱহাৰকাৰীৰ table shard কৰাৰ সাধাৰণ পদ্ধতি হৈছে ব্যৱহাৰকাৰীৰ নামৰ আৰম্ভণি অক্ষৰ বা ভূগোলিক স্থান অনুসৰি।

##### অসুবিধা(সমূহ): sharding

* Shard-ৰ সৈতে কাম কৰিবলৈ আপোনাৰ application logic আপডেট কৰিব লাগিব, যাৰ বাবে জটিল SQL query হ’ব পাৰে।
* Shard-ত তথ্যৰ বিতৰণ অসমতল হ’ব পাৰে।  উদাহৰণস্বৰূপে, কোনো shard-ত অধিক শক্তিশালী ব্যৱহাৰকাৰী থাকিলে, সেই shard-ত অধিক লোড হব পাৰে।
    * Rebalancing-এ অধিক জটিলতা যোগায়। [consistent hashing](http://www.paperplanes.de/2011/12/9/the-magic-of-consistent-hashing.html)-ত আধাৰিত sharding function-এ স্থানান্তৰিত তথ্যৰ পৰিমাণ কমাব পাৰে।
* একাধিক shard-ৰ পৰা তথ্য যুক্ত কৰা অধিক জটিল।
* Sharding-এ অধিক hardware আৰু বৃদ্ধি হোৱা জটিলতা যোগায়।

##### উৎস(সমূহ) আৰু অধিক পঢ়াৰ বাবে: sharding

* [The coming of the shard](http://highscalability.com/blog/2009/8/6/an-unorthodox-approach-to-database-design-the-coming-of-the.html)
* [Shard database architecture](https://en.wikipedia.org/wiki/Shard_(database_architecture))
* [Consistent hashing](http://www.paperplanes.de/2011/12/9/the-magic-of-consistent-hashing.html)

#### Denormalization

Denormalization-এ কিছু লিখা performance-ৰ বিনিময়ত পঢ়াৰ performance উন্নত কৰিবলৈ চেষ্টা কৰে।  তথ্যৰ অতিৰিক্ত প্ৰতিলিপি বহুবিধ table-ত লিখা হয়, যাতে ব্যয়বহুল join এড়াই যায়।  [PostgreSQL](https://en.wikipedia.org/wiki/PostgreSQL) আৰু Oracle-ৰ দৰে কিছু RDBMS-এ [materialized views](https://en.wikipedia.org/wiki/Materialized_view) সমৰ্থন কৰে, যিয়ে অতিৰিক্ত তথ্য সংৰক্ষণ আৰু প্ৰতিলিপি একে ৰাখিবলৈ কাম কৰে।

[federation](#federation) আৰু [sharding](#sharding)-ৰ দৰে পদ্ধতিত তথ্য বিতৰণ হোৱাৰ পাছত, data center-ত join পৰিচালনা অধিক জটিল হয়।  Denormalization-এ এনে জটিল join-ৰ প্ৰয়োজনীয়তা এড়াই যাব পাৰে।

বেশিভাগ ব্যৱস্থাত, পঢ়া লিখাৰ তুলনাত ১০০:১ বা ১০০০:১ হ’ব পাৰে।  জটিল database join-ৰ ফলত পঢ়া খুব ব্যয়বহুল হ’ব পাৰে, আৰু disk operation-ত অধিক সময় ব্যয় হয়।

##### অসুবিধা(সমূহ): denormalization

* Data-ৰ প্ৰতিলিপি হয়।
* Constraint-এ অতিৰিক্ত প্ৰতিলিপি sync ৰখাত সহায় কৰে, যাৰ বাবে database design-ৰ জটিলতা বৃদ্ধি পায়।
* Heavy write load-ত denormalized database-এ normalized counterpart-তকৈ বেয়া performance দিব পাৰে।

###### উৎস(সমূহ) আৰু অধিক পঢ়াৰ বাবে: denormalization

* [ডিনৰ্মেলাইজেচন](https://en.wikipedia.org/wiki/Denormalization)

#### SQL টিউনিং

SQL টিউনিং এটা বিস্তৃত বিষয় আৰু বহু [কিতাপ](https://www.amazon.com/s/ref=nb_sb_noss_2?url=search-alias%3Daps&field-keywords=sql+tuning) ৰেফাৰেঞ্চ হিচাপে লিখা হৈছে।

**বেঞ্চমাৰ্ক** আৰু **প্ৰ’ফাইল** কৰা গুৰুত্বপূর্ণ যাতে বটলনেক চিহ্নিত আৰু অনুকৰণ কৰিব পাৰি।

* **বেঞ্চমাৰ্ক** - [ab](http://httpd.apache.org/docs/2.2/programs/ab.html) যেনে টুল ব্যৱহাৰ কৰি উচ্চ-লোড পৰিস্থিতি অনুকৰণ কৰক।
* **প্ৰ’ফাইল** - [slow query log](http://dev.mysql.com/doc/refman/5.7/en/slow-query-log.html) যেনে টুল সক্ৰিয় কৰক যাতে কার্যক্ষমতা সমস্যাসমূহ শনাক্ত কৰিব পাৰি।

বেঞ্চমাৰ্কিং আৰু প্ৰ’ফাইলিংয়ে নিম্নলিখিত অপ্টিমাইজেশ্যনসমূহৰ দিশে ইঙ্গিত দিব পাৰে।

##### স্কিমা আঁট কৰি লওক

* MySQL এ ডিস্কত সংলগ্ন ব্লকত ডাম্প কৰে যাতে দ্ৰুত এক্সেছ হয়।
* স্থায়ী দৈৰ্ঘ্যৰ ক্ষেত্ৰৰ বাবে `CHAR` ব্যৱহাৰ কৰক `VARCHAR`ৰ পৰিৱৰ্তে।
    * `CHAR` এ কার্যকৰীভাৱে দ্ৰুত, ৰেণ্ডম এক্সেছৰ সুবিধা দিয়ে, যেতিয়া `VARCHAR`ত, পাছত চাবলৈ আগতে ষ্ট্ৰিংৰ শেষটো বিচাৰি উলিয়াব লাগে।
* ব্লগ পোষ্টৰ দৰে ডাঙৰ টেক্সট ব্লকৰ বাবে `TEXT` ব্যৱহাৰ কৰক।  `TEXT` এ বুলিয়ান অনুসন্ধানৰ সুবিধা দিয়ে।  `TEXT` ক্ষেত্ৰ ব্যৱহাৰ কৰিলে ডিস্কত এটা পইণ্টাৰ সংৰক্ষণ হয় যি টেক্সট ব্লক লোকেট কৰিবলৈ ব্যৱহৃত হয়।
* ডাঙৰ সংখ্যাৰ বাবে `INT` ব্যৱহাৰ কৰক, 2^32 বা 4 বিলিয়ন পৰ্যন্ত।
* মুদ্ৰাৰ বাবে `DECIMAL` ব্যৱহাৰ কৰক যাতে ফ্লোটিং পইণ্ট প্ৰতিনিধিত্বৰ ভুল এড়ানো যায়।
* ডাঙৰ `BLOB` সংৰক্ষণ এড়াওক, তাৰ অৱস্থান সংৰক্ষণ কৰক।
* `VARCHAR(255)` হৈছে আটাইতকৈ ডাঙৰ সংখ্যক অক্ষৰ যি 8 বিট সংখ্যাত গণনা কৰিব পাৰি, বহু RDBMS-ত এটা বাইটৰ সদ্ব্যৱহাৰ সাধাৰণতে।
* প্ৰযোজ্য ক্ষেত্ৰত `NOT NULL` constraint সেট কৰক যাতে [search performance উন্নত হয়](http://stackoverflow.com/questions/1017239/how-do-null-values-affect-performance-in-a-database-search)।

##### ভাল ইনডেক্স ব্যৱহাৰ কৰক

* যি কলামত আপুনি query কৰিছে (`SELECT`, `GROUP BY`, `ORDER BY`, `JOIN`) সেইবোৰত ইনডেক্স থাকিলে অধিক দ্ৰুত হ’ব পাৰে।
* ইনডেক্স সাধাৰণতে আত্ম-সাম্যাবস্থাসম্পন্ন [B-tree](https://en.wikipedia.org/wiki/B-tree) হিচাপে প্ৰতিনিধিত্ব কৰা হয়, যি ডাটা sorted ৰাখে আৰু অনুসন্ধান, ক্রমিক এক্সেছ, insertion, আৰু deletion লগাৰিদমিক সময়ত কৰে।
* ইনডেক্স স্থাপন কৰিলে ডাটা মেম’ৰীত ৰাখিব পাৰে, অধিক স্থানৰ প্ৰয়োজন হয়।
* Write সমূহো মন্থৰ হ’ব পাৰে কাৰণ ইনডেক্সো আপডেট কৰিব লাগে।
* ডাঙৰ পৰিমাণৰ ডাটা লোড কৰাৰ সময়ত, ইনডেক্স নিষ্ক্ৰিয় কৰি, ডাটা লোড কৰি, তাৰ পিছত ইনডেক্স পুনঃনির্মাণ কৰাটো অধিক দ্ৰুত হ’ব পাৰে।

##### খৰছযুক্ত join এড়াওক

* [ডিনৰ্মেলাইজ](#denormalization) কৰক যেতিয়া কার্যক্ষমতাৰ দাবী থাকে।

##### টেবুলসমূহ partition কৰক

* এটা টেবুল ভাঙি দিয়া, হট স্পটবোৰ পৃথক টেবুলত ৰাখক যাতে ইয়াক মেমৰীত ৰখা সহজ হয়।

##### কুৱাৰী কেচ টিউন কৰক

* কেতবোৰ ক্ষেত্ৰত, [কুৱাৰী কেচ](https://dev.mysql.com/doc/refman/5.7/en/query-cache.html) এ [পাৰফৰ্মেন্স সমস্যা](https://www.percona.com/blog/2016/10/12/mysql-5-7-performance-tuning-immediately-after-installation/)ৰ সৃষ্টি কৰিব পাৰে।

##### উৎস(সমূহ) আৰু অধিক পঢ়া: SQL টিউনিং

* [MySQL কুৱাৰী অপ্টিমাইজ কৰাৰ টিপছ](http://aiddroid.com/10-tips-optimizing-mysql-queries-dont-suck/)
* [VARCHAR(255) কেনে বহু পৰিমাণে ব্যৱহাৰ কৰা হয় তাৰ ভাল কাৰণ আছে নেকি?](http://stackoverflow.com/questions/1217466/is-there-a-good-reason-i-see-varchar255-used-so-often-as-opposed-to-another-l)
* [NULL মানবোৰে পাৰফৰ্মেন্সত কেনেকৈ প্ৰভাৱ পেলায়?](http://stackoverflow.com/questions/1017239/how-do-null-values-affect-performance-in-a-database-search)
* [Slow query log](http://dev.mysql.com/doc/refman/5.7/en/slow-query-log.html)

### NoSQL

NoSQL হৈছে তথ্যবস্তুৰ এক সংগ্ৰহ, যি **key-value store**, **document store**, **wide column store**, অথবা **graph database**ৰ ৰূপত প্ৰতিনিধিত্ব কৰা হয়।  তথ্য ডিনৰ্মেলাইজ কৰা হয়, আৰু সাধাৰণতে যোগ (join)বোৰ এপ্লিকেচন ক’ডত কৰা হয়।  বেছিভাগ NoSQL ষ্টোৰত সত্যিকাৰ ACID লেন-দেন নাথাকে আৰু [eventual consistency](#eventual-consistency)ক প্ৰাধান্য দিয়ে।

**BASE** সাধাৰণতে NoSQL ডাটাবেছৰ গুণাবলী বৰ্ণনা কৰিবলৈ ব্যৱহাৰ হয়।  [CAP Theorem](#cap-theorem)ৰ লগত তুলনা কৰিলে, BASE-এ consistencyৰ তুলনাত availabilityক বেছি প্ৰাধান্য দিয়ে।

* **Basically available** - ব্যৱস্থাই উপলব্ধতা গেৰাণ্টি দিয়ে।
* **Soft state** - ব্যৱস্থাৰ অৱস্থা সময়ৰ লগত, ইনপুট নোহোৱাকৈয়ো, সলনি হ’ব পাৰে।
* **Eventual consistency** - ব্যৱস্থাই সময়ৰ লগত consistent হৈ যাব, যদি সেই সময়ছোৱাত ব্যৱস্থাই ইনপুট নাপায়।

[SQL বা NoSQL](#sql-or-nosql)ত নিৰ্বাচন কৰাৰ উপৰিও, কোন ধৰণৰ NoSQL ডাটাবেছ আপোনাৰ ব্যৱহাৰৰ ক্ষেত্ৰ(সমূহ)ৰ বাবে ঠিক হব তাক বুজা উপযোগী।  আমি পৰৱৰ্তী অংশত **key-value stores**, **document stores**, **wide column stores**, আৰু **graph databases** আলোচনা কৰিম।

#### Key-value store

> Abstraction: hash table

Key-value store সাধাৰণতে O(1) পঢ়া আৰু লিখাৰ অনুমতি দিয়ে আৰু সাধাৰণতে মেমৰি বা SSDত সংৰক্ষিত থাকে।  Data stores-এ [lexicographic order](https://en.wikipedia.org/wiki/Lexicographical_order)ত key সংৰক্ষণ কৰিব পাৰে, যাতে key ৰেঞ্জ সহজে উদ্ধাৰ কৰিব পৰা যায়।  Key-value store-এ মানৰ সৈতে metadata সংৰক্ষণৰ সুবিধা দিয়ে।

Key-value store-এ উচ্চ পাৰফৰ্মেন্স দিয়ে আৰু সাধাৰণ ডাটা মডেল বা দ্রুত পৰিবৰ্তন হোৱা তথ্য, যেনে in-memory cache layerৰ বাবে ব্যৱহাৰ কৰা হয়।  কাৰণ এইবোৰে কেৱল সীমিত অপাৰেশ্যন দিয়া, অতিরিক্ত অপাৰেশ্যনৰ প্ৰয়োজন হলে জটিলতা এপ্লিকেচন স্তৰত সৰিয়াই যায়।

Key-value store হৈছে অধিক জটিল ব্যৱস্থাৰ আধাৰ, যেনে document store, আৰু কেতবোৰ ক্ষেত্ৰত graph database।

##### উৎস(সমূহ) আৰু অধিক পঢ়া: key-value store

* [Key-value database](https://en.wikipedia.org/wiki/Key-value_database)
* [key-value store ব্যৱহাৰ কৰাৰ অসুবিধাসমূহ](http://stackoverflow.com/questions/4056093/what-are-the-disadvantages-of-using-a-key-value-table-over-nullable-columns-or)
* [Redis architecture](http://qnimate.com/overview-of-redis-architecture/)
* [Memcached স্থাপত্য](https://adayinthelifeof.nl/2011/02/06/memcache-internals/)

#### ডকুমেন্ট সংৰক্ষণাগাৰ

> বিমূর্ততা: কীৰ্তি-মূল্য সংৰক্ষণাগাৰ য'ত ডকুমেন্টসমূহ মূল্য হিচাপে সংৰক্ষিত

এটা ডকুমেন্ট সংৰক্ষণাগাৰ ডকুমেন্টক কেন্দ্ৰ কৰি গঠিত (XML, JSON, বাইনেৰী, আদি), য'ত এটা ডকুমেন্টে কোনো এটা অবজেক্টৰ সকলো তথ্য সংৰক্ষণ কৰে।  ডকুমেন্ট সংৰক্ষণাগাৰে API অথবা প্ৰশ্ন ভাষা প্ৰদান কৰে যাৰ সহায়ত ডকুমেন্টৰ আন্তঃ গঠন অনুসৰি সন্ধান কৰিব পৰা যায়।  *মন কৰিব, বহু কেইটি কীৰ্তি-মূল্য সংৰক্ষণাগাৰে মূল্যৰ মেটাডেটা ব্যৱহাৰৰ সুবিধা থাকে, যাৰ ফলত এই দুটা সংৰক্ষণ ধৰণৰ সীমা অস্পষ্ট হৈ পৰে।*

মৌলিক ৰূপত, ডকুমেন্টসমূহ সংগ্ৰহ, টেগ, মেটাডেটা, অথবা ডাইৰেক্টৰীৰ দ্বাৰা সজোৱা হয়।  যদিও ডকুমেন্টসমূহ সংগঠিত বা গোট কৰা যায়, ডকুমেন্টসমূহৰ ক্ষেত্ৰসমূহ সম্পূৰ্ণ ভিন্ন হ'ব পাৰে।

কিছু ডকুমেন্ট সংৰক্ষণাগাৰ যেনে [MongoDB](https://www.mongodb.com/mongodb-architecture) আৰু [CouchDB](https://blog.couchdb.org/2016/08/01/couchdb-2-0-architecture/) SQL সদৃশ ভাষা প্ৰদান কৰে জটিল সন্ধান কৰিবলৈ।  [DynamoDB](http://www.read.seas.harvard.edu/~kohler/class/cs239-w08/decandia07dynamo.pdf) কীৰ্তি-মূল্য আৰু ডকুমেন্ট দুয়োটা সমৰ্থন কৰে।

ডকুমেন্ট সংৰক্ষণাগাৰে উচ্চ নমনীয়তা প্ৰদান কৰে আৰু সাধাৰণতে কেতিয়াবা পৰিবৰ্তন হোৱা তথ্যৰ সৈতে কাম কৰিবলৈ ব্যৱহৃত হয়।

##### উৎস(সমূহ) আৰু অধিক পঢ়িবলৈ: ডকুমেন্ট সংৰক্ষণাগাৰ

* [ডকুমেন্ট-ভিত্তিক ডাটাবেছ](https://en.wikipedia.org/wiki/Document-oriented_database)
* [MongoDB স্থাপত্য](https://www.mongodb.com/mongodb-architecture)
* [CouchDB স্থাপত্য](https://blog.couchdb.org/2016/08/01/couchdb-2-0-architecture/)
* [Elasticsearch স্থাপত্য](https://www.elastic.co/blog/found-elasticsearch-from-the-bottom-up)

#### Wide column সংৰক্ষণাগাৰ

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/n16iOGk.png">
  <br/>
  <i><a href=http://blog.grio.com/2015/11/sql-nosql-a-brief-history.html>উৎস: SQL & NoSQL, এখন সংক্ষেপ ইতিহাস</a></i>
</p>

> বিমূর্ততা: nested map `ColumnFamily<RowKey, Columns<ColKey, Value, Timestamp>>`

Wide column সংৰক্ষণাগাৰৰ মূখ্য তথ্য একক হৈছে এটা কলাম (নাম/মূল্য জোৰ)।  এটা কলাম কলাম পৰিয়ালত গোট কৰিব পৰা যায় (SQL টেবুলৰ সদৃশ)।  Super column পৰিয়ালে আৰু অধিক কলাম পৰিয়াল গোট কৰে।  আপুনি প্ৰত্যেক কলামক ৰ' কীৰ্তিৰে স্বাধীনভাৱে লাভ কৰিব পাৰে, আৰু একে ৰ' কীৰ্তিৰ কলামসমূহে ৰ' গঠন কৰে।  প্ৰতিটো মূল্যত সংস্কৰণৰ বাবে আৰু দ্বন্দ্ব সমাধানৰ বাবে টাইমষ্টেম্প থাকে।

Google-এ [Bigtable](http://www.read.seas.harvard.edu/~kohler/class/cs239-w08/chang06bigtable.pdf) Wide column সংৰক্ষণাগাৰৰ প্ৰথম সংস্কৰণ হিচাপে উন্মোচন কৰিছিল, যিয়ে ওপেন-চ'র্স [HBase](https://www.edureka.co/blog/hbase-architecture/)ক প্ৰভাৱিত কৰিছে, যি সাধাৰণতে Hadoop ecosystem-ত ব্যৱহৃত হয়, আৰু [Cassandra](http://docs.datastax.com/en/cassandra/3.0/cassandra/architecture/archIntro.html) Facebook-ৰ পৰা।  BigTable, HBase, আৰু Cassandra-ৰ দৰে সংৰক্ষণাগাৰে কীৰ্তিসমূহ লেক্সিকোগ্ৰাফিক অনুক্ৰমত ৰাখে, যাৰ সহায়ত নিৰ্বাচিত কীৰ্তিৰ পৰিসৰ সহজে উদ্ধাৰ কৰিব পৰা যায়।

Wide column সংৰক্ষণাগাৰে উচ্চ উপলব্ধতা আৰু উচ্চ স্কেলেবিলিটি প্ৰদান কৰে।  ই সাধাৰণতে অতি বৃহৎ তথ্য সংগ্ৰহৰ বাবে ব্যৱহৃত হয়।

##### উৎস(সমূহ) আৰু অধিক পঢ়িবলৈ: wide column সংৰক্ষণাগাৰ

* [SQL & NoSQL, এখন সংক্ষেপ ইতিহাস](http://blog.grio.com/2015/11/sql-nosql-a-brief-history.html)
* [Bigtable স্থাপত্য](http://www.read.seas.harvard.edu/~kohler/class/cs239-w08/chang06bigtable.pdf)
* [HBase স্থাপত্য](https://www.edureka.co/blog/hbase-architecture/)
* [Cassandra স্থাপত্য](http://docs.datastax.com/en/cassandra/3.0/cassandra/architecture/archIntro.html)

#### গ্ৰাফ ডাটাবেচ

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/fNcl65g.png">
  <br/>
  <i><a href=https://en.wikipedia.org/wiki/File:GraphDatabase_PropertyGraph.png>উৎস: গ্ৰাফ ডাটাবেচ</a></i>
</p>

> বিমূর্তকৰণ: গ্ৰাফ

এটা গ্ৰাফ ডাটাবেচত, প্ৰতিটো নোড এটা ৰেকৰ্ড আৰু প্ৰতিটো আৰ্ক দুটা নোডৰ মাজত এখন সম্পৰ্ক।  গ্ৰাফ ডাটাবেচসমূহ জটিল সম্পৰ্ক, বহু বিদেশী চাবি অথবা বহু-ত-many সম্পৰ্ক দেখুওৱাত অপ্টিমাইজ কৰা।

গ্ৰাফ ডাটাবেচসমূহ জটিল সম্পৰ্ক থকা ডাটা মডেলত, যেনে এটা ছচিয়েল নেটৱৰ্কত, উচ্চ কাৰ্যক্ষমতা প্ৰদান কৰে।  এইবোৰ তুলনামূলকভাৱে নতুন আৰু এতিয়াও ব্যাপকভাৱে ব্যৱহৃত নহয়; বিকাশৰ সঁজুলি আৰু উৎস পোৱা কঠিন হ’ব পাৰে।  বহু গ্ৰাফ কেৱল [REST API](#representational-state-transfer-rest) ৰ জৰিয়তে এক্সেছ কৰিব পাৰি।

##### উৎস(সমূহ) আৰু অধিক পঢ়িবৰ বাবে: গ্ৰাফ

* [গ্ৰাফ ডাটাবেচ](https://en.wikipedia.org/wiki/Graph_database)
* [Neo4j](https://neo4j.com/)
* [FlockDB](https://blog.twitter.com/2010/introducing-flockdb)

#### উৎস(সমূহ) আৰু অধিক পঢ়িবৰ বাবে: NoSQL

* [বেইচ শব্দৰ ব্যাখ্যা](http://stackoverflow.com/questions/3342497/explanation-of-base-terminology)
* [NoSQL ডাটাবেচসমূহ: এটা সমীক্ষা আৰু সিদ্ধান্ত গাইডেন্স](https://medium.com/baqend-blog/nosql-databases-a-survey-and-decision-guidance-ea7823a822d#.wskogqenq)
* [স্কেলেবিলিটি](https://web.archive.org/web/20220602114024/https://www.lecloud.net/post/7994751381/scalability-for-dummies-part-2-database)
* [NoSQL ৰ পৰিচয়](https://www.youtube.com/watch?v=qI_g07C_Q5I)
* [NoSQL পেটাৰ্ন](http://horicky.blogspot.com/2009/11/nosql-patterns.html)

### SQL না NoSQL

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/wXGqG5f.png">
  <br/>
  <i><a href=https://www.infoq.com/articles/Transition-RDBMS-NoSQL/>উৎস: RDBMS ৰ পৰা NoSQL লৈ সলনি</a></i>
</p>

**SQL**-ৰ কাৰণসমূহ:

* গঠনযুক্ত ডাটা
* কঠোৰ স্কিমা
* সম্পৰ্কিত ডাটা
* জটিল জইন্‌ৰ আৱশ্যকতা
* লেনদেন
* স্কেলিংৰ বাবে স্পষ্ট পেটাৰ্ন
* অধিক প্ৰতিষ্ঠিত: ডেভেলপাৰ, কমিউনিটি, ক'ড, টুল আদি
* ইণ্ডেক্স দ্বাৰা লুকআপ অত্যন্ত দ্ৰুত

**NoSQL**-ৰ কাৰণসমূহ:

* আধা-গঠনযুক্ত ডাটা
* ডাইনামিক বা নমনীয় স্কিমা
* অসম্পৰ্কিত ডাটা
* জটিল জইন্‌ৰ আৱশ্যকতা নাই
* বহু TB (বা PB) ডাটা সংৰক্ষণ
* অত্যন্ত ডাটা-ইনটেন্সিভ ৱৰ্কলোড
* IOPS-ৰ বাবে অত্যাধিক উচ্চ থ্ৰুপুট

NoSQL-ৰ বাবে উপযুক্ত নমুনা ডাটা:

* ক্লিকষ্ট্ৰীম আৰু লগ ডাটাৰ দ্ৰুত ইনজেষ্ট
* লিডাৰব'ৰ্ড বা স্ক'ৰিং ডাটা
* অস্থায়ী ডাটা, যেনে শ্বপিং কাৰ্ট
* প্ৰায়েই ব্যৱহৃত ('হট') টেবুলসমূহ
* মেটাডাটা/লুকআপ টেবুলসমূহ

##### উৎস(সমূহ) আৰু অধিক পঢ়িবলৈ: SQL বা NoSQL

* [আপোনাৰ প্ৰথম ১০ নিযুত ব্যৱহাৰকাৰীলৈ স্কেলিং](https://www.youtube.com/watch?v=kKjm4ehYiMs)
* [SQL আৰু NoSQL-ৰ পাৰ্থক্যসমূহ](https://www.sitepoint.com/sql-vs-nosql-differences/)

## কেশ

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/Q6z24La.png">
  <br/>
  <i><a href=http://horicky.blogspot.com/2010/10/scalable-system-design-patterns.html>উৎস: স্কেলেবল চিষ্টেম ডিজাইন পেটাৰ্ন</a></i>
</p>

কেচিংয়ে পৃষ্ঠা লোড সময় উন্নত কৰে আৰু আপোনাৰ ছাৰ্ভাৰ আৰু ডেটাবেইচসমূহৰ ওপৰত লোড কমাই। এই মডেলত, ডিসপেচাৰে প্ৰথমে অনুৰোধ আগতে কৰা হৈছিল নে নাই চাব আৰু আগৰ ফলাফল উভতাই দিবলৈ চেষ্টা কৰিব, যাতে আসল এক্সিকিউশ্বন বচোৱা যায়।

ডেটাবেইচসমূহে প্ৰায়ে তাৰ পাৰ্টিশনসমূহত পঢ়া আৰু লিখাৰ একসাৰ সম্প্ৰচাৰিত হোৱাৰ পৰা লাভ কৰে। জনপ্ৰিয় আইটেমসমূহে সম্প্ৰচাৰিতত বিকৃতি ঘটাব পাৰে, যাৰ ফলত বটলনেক সৃষ্টি হয়। এখন ডেটাবেইচৰ আগত কেচ থৈ দিলে অসামান্য লোড আৰু ট্ৰাফিকৰ স্পাইকসমূহ শোষণ কৰাত সহায় কৰে।

### ক্লায়েন্ট কেচিং

কেচসমূহ ক্লায়েন্ট পাশত (অ' এছ বা ব্ৰাউজাৰ), [ছাৰ্ভাৰ পাশত](#reverse-proxy-web-server), অথবা পৃথক কেচ স্তৰত অৱস্থিত হ’ব পাৰে।

### CDN কেচিং

[CDN](#content-delivery-network) সমূহ কেচৰ এটা প্ৰকাৰ বুলি গণ্য কৰা হয়।

### ৱেব ছাৰ্ভাৰ কেচিং

[Reverse proxies](#reverse-proxy-web-server) আৰু [Varnish](https://www.varnish-cache.org/) যেনে কেচসমূহে স্থায়ী আৰু গতিশীল বিষয়বস্তু সিধাসলাই দাঙি দিব পাৰে। ৱেব ছাৰ্ভাৰসমূহেও অনুৰোধসমূহ কেচ কৰিব পাৰে, যাতে অ্যাপ্লিকেশ্যন ছাৰ্ভাৰসমূহক যোগাযোগ নকৰাকৈ প্ৰতিক্ৰিয়া উভতাই দিব পাৰে।

### ডেটাবেইচ কেচিং

আপোনাৰ ডেটাবেইচত সাধাৰণ ব্যৱহাৰৰ বাবে অপ্টিমাইজ কৰা ডিফল্ট কনফিগাৰেশ্যনত কিছু পৰিমাণৰ কেচিং থাকে। এই ছেটিংসমূহ বিশেষ ব্যৱহাৰ পেটাৰ্নৰ বাবে সলনি কৰিলে আরও অধিক পারফৰ্মেন্স বৃদ্ধি কৰিব পাৰে।

### অ্যাপ্লিকেশ্যন কেচিং

Memcached আৰু Redis যেনে ইন-মেম'ৰী কেচসমূহ হৈছে আপোনাৰ অ্যাপ্লিকেশ্যন আৰু ডেটা সংৰক্ষণৰ মাজত কী-ভেল্যু ষ্ট'ৰ। ডেটা RAM-ত সংৰক্ষণ কৰা হোৱাৰ বাবে, ই সাধাৰণ ডেটাবেইচতকৈ বহুত বেছি দ্ৰুত, য’ত ডেটা ডিস্কত সংৰক্ষণ কৰা হয়। RAM-ৰ স্থান সীমিত, সেয়ে [কেচ ইনভেলিডেশ্যন](https://en.wikipedia.org/wiki/Cache_algorithms) এলগৰিদম যেনে [least recently used (LRU)](https://en.wikipedia.org/wiki/Cache_replacement_policies#Least_recently_used_(LRU)) 'ঠাণ্ডা' এণ্ট্ৰিসমূহ ইনভেলিডেট কৰি 'গৰম' ডেটা RAM-ত ৰাখিবলৈ সহায় কৰে।

Redis-ত তলত দিয়া অতিৰিক্ত বৈশিষ্ট্যসমূহ আছে:

* স্থায়ীত্বৰ বিকল্প
* সাজি থকা ছেট আৰু তালিকা যেনে বিল্ট-ইন ডেটা ষ্ট্ৰাকচাৰ

আপুনি বহু স্তৰত কেচ কৰিব পাৰে, যি দুটা সাধাৰণ শ্ৰেণীভুক্তিত পৰে: **ডেটাবেইচ কুয়েরি** আৰু **অবজেক্টসমূহ**:

* ৰো স্তৰ
* কুয়েরি-স্তৰ
* সম্পূৰ্ণ গঠিত ছিৰিয়েলাইজযোগ্য অবজেক্টসমূহ
* সম্পূৰ্ণ-ৰেণ্ডাৰ কৰা HTML

সাধাৰণতে, আপুনি ফাইল-ভিত্তিক কেচিং এৰাই চলা উচিত, কাৰণ ই ক্লোনিং আৰু অটো-স্কেলিং অধিক কঠিন কৰি তোলে।

### ডাটাবেছ কুৱেৰীৰ স্তৰত কেছিং

যেতিয়া আপুনি ডাটাবেছ কুৱেৰী কৰে, কুৱেৰীক এটা কী হিচাপে হেছ কৰি ফলাফলটো কেছত সংৰক্ষণ কৰক।  এই পদ্ধতিটো মেয়াদ উত্তীৰ্ণ হোৱাৰ সমস্যাত ভুগে:

* জটিল কুৱেৰীৰ সৈতে কেছ কৰা ফলাফল ডিলিট কৰা কঠিন
* যদি এটা টেবুল চেলৰ দৰে এটা অংশৰ ডাটা সলনি হয়, তেন্তে সেই চেলটো সন্নিৱিষ্ট থকা সকলো কেছ কৰা কুৱেৰী ডিলিট কৰিব লাগিব

### অবজেক্ট স্তৰত কেছিং

আপোনাৰ ডাটাটো অবজেক্ট হিচাপে চাওক, আপোনাৰ এপ্লিকেচন ক’ডৰ দৰে।  আপোনাৰ এপ্লিকেচনে ডাটাবেছৰ পৰা ডাটাসেটটো ক্লাছ ইনষ্টেন্স বা ডাটা ষ্ট্ৰাকচাৰ(সমূহ)ত সংহত কৰক:

* যদি অবজেক্টটোৰ অন্তর্নিহিত ডাটা সলনি হয়, তেতিয়া কেছৰ পৰা অবজেক্টটো আঁতৰাওক
* অসমান্তৰাল প্ৰসেছিঙৰ সুবিধা: কৰ্মীৰে শেহতীয়া কেছ কৰা অবজেক্ট খাই অবজেক্ট সংহত কৰিব পাৰে

কি কেছ কৰিবলৈ পৰামৰ্শ:

* ব্যৱহাৰকাৰীৰ চেছন
* সম্পূৰ্ণ ৰূপে ৰেণ্ডাৰ কৰা ৱেব পৃষ্ঠা
* কাৰ্যকলাপ ষ্ট্ৰীম
* ব্যৱহাৰকাৰীৰ গ্ৰাফ ডাটা

### কেতিয়া কেছ আপডেট কৰিব

কেছত সীমিত পৰিমাণৰ ডাটা সংৰক্ষণ কৰিব পাৰি, সেইবাবে আপোনাৰ ব্যৱহাৰ ক্ষেত্ৰত কোনটো কেছ আপডেট কৌশল উত্তম সেইটো নিৰ্ধাৰণ কৰিব লাগিব।

#### কেছ-এছাইড

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/ONjORqk.png">
  <br/>
  <i><a href=http://www.slideshare.net/tmatyashovsky/from-cache-to-in-memory-data-grid-introduction-to-hazelcast>Source: From cache to in-memory data grid</a></i>
</p>

এপ্লিকেচনটোৱে ষ্ট’ৰেজৰ পৰা পঢ়া আৰু লিখাৰ দায়িত্ব লয়।  কেছটোৱে সোজাকৈ ষ্ট’ৰেজৰ সৈতে সম্পৰ্ক নেথাকে।  এপ্লিকেচনটোৱে তলত উল্লেখ কৰা কামবোৰ কৰে:

* কেছত প্ৰৱিষ্টিৰ সন্ধান কৰে, ফলত কেছ মিছ হয়
* ডাটাবেছৰ পৰা প্ৰৱিষ্টি লোড কৰে
* প্ৰৱিষ্টিটো কেছত যোগ কৰে
* প্ৰৱিষ্টিটো উভতি দিয়ে

```python
def get_user(self, user_id):
    user = cache.get("user.{0}", user_id)
    if user is None:
        user = db.query("SELECT * FROM users WHERE user_id = {0}", user_id)
        if user is not None:
            key = "user.{0}".format(user_id)
            cache.set(key, json.dumps(user))
    return user
```
[Memcached](https://memcached.org/) সাধাৰণতে এইদৰে ব্যৱহাৰ কৰা হয়।

কেশত যোগ কৰা ডেটা পুনৰ পঢ়া তীব্ৰ গতিত হয়।  কেশ-এছাইডক অলস লোডিং বুলি জনা যায়।  কেৱল অনুৰোধ কৰা ডেটাহে কেশত সংৰক্ষণ কৰা হয়, যাৰ ফলত অনুৰোধ নকৰা ডেটাৰে কেশ ভৰি নাযায়।

##### অসুবিধা(সমূহ): কেশ-এছাইড

* প্ৰতিটো কেশ মিছত তিনি বাৰ যাত্ৰা লাগে, যাৰ ফলত উল্লেখযোগ্য বিলম্ব হ’ব পাৰে।
* ডেটাবেছত আপডেট কৰিলে ডেটা পুৰণি হৈ পৰিব পাৰে।  এই সমস্যাটো সমাধান কৰিবলৈ টাইম-টু-লাইভ (TTL) নিৰ্ধাৰণ কৰা হয়, যিয়ে কেশ এণ্ট্ৰিটোৰ আপডেট বাধ্যতামূলক কৰে, অথবা ৰাইট-থ্ৰু ব্যৱহাৰ কৰা হয়।
* এটা নোড বিফল হ’লে, নতুন, খালী নোডে প্ৰতিস্থাপন হয়, যাৰ ফলত লেটেঞ্চি বৃদ্ধি পায়।

#### ৰাইট-থ্ৰু

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/0vBc0hN.png">
  <br/>
  <i><a href=http://www.slideshare.net/jboner/scalability-availability-stability-patterns/>উৎস: Scalability, availability, stability, patterns</a></i>
</p>

এপ্লিকেচনে কেশক মুখ্য ডেটা ষ্ট’ৰ হিচাপে ব্যৱহাৰ কৰে, ইয়াত ডেটা পঢ়া আৰু লিখাৰ কাম কৰে, আৰু কেশে ডেটাবেছত পঢ়া আৰু লিখাৰ দায়িত্ব লয়:

* এপ্লিকেচনে কেশত এণ্ট্রি যোগ/আপডেট কৰে
* কেশে ছিঁচ্ৰণভাৱে এণ্ট্রি ডেটা ষ্ট’ৰত লিখে
* উভতি আহে

এপ্লিকেচন ক’ড:


```python
set_user(12345, {"foo":"bar"})
```

কেশ ক'ড:

```python
def set_user(user_id, values):
    user = db.query("UPDATE Users WHERE id = {0}", user_id, values)
    cache.set(user_id, user)
```

Write-through এটা ধীৰ গতিৰ সামগ্ৰিক কাৰ্যপদ্ধতি, লিখা কাৰ্যপদ্ধতিৰ বাবে, কিন্তু মাত্ৰ লিখা হোৱা ডেটা পঢ়াৰ পিছৰ কাৰ্যপদ্ধতি তীব্ৰ।  ব্যৱহাৰকাৰীসকলে সাধাৰণতে ডেটা আপডেট কৰাৰ সময়ত অধিক বিঢ়তিৰ সহনশীল, ডেটা পঢ়াৰ সময়তকৈ।  ক্যাশত থকা ডেটা পুৰণি নহয়।

##### অপৰিসীম(s): write through

* কোনো নতুন নোড সৃষ্টি হ'লে, বিপৰ্যয় বা স্কেলিংৰ বাবে, নতুন নোডে ক্যাশত এণ্ট্রি সংৰক্ষণ নকৰে যতক্ষণ না সেই এণ্ট্রি ডেটাবেইচত আপডেট হয়।  Cache-aside write-throughৰ সৈতে একত্ৰিত কৰি এই সমস্যাটো কম কৰিব পাৰি।
* অধিকাংশ লিখা ডেটা হয়তো কেতিয়াও পঢ়া নহয়, যাক TTL ব্যৱহাৰ কৰি কম কৰিব পাৰি।

#### Write-behind (write-back)

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/rgSrvjG.png">
  <br/>
  <i><a href=http://www.slideshare.net/jboner/scalability-availability-stability-patterns/>উৎস: Scalability, availability, stability, patterns</a></i>
</p>

Write-behindত, এপ্লিকেশনে তলত দিয়া কামবোৰ কৰে:

* ক্যাশত এণ্ট্রি যোগ/আপডেট কৰা
* এণ্ট্রি ডেটা ষ্ট'ৰলৈ asynchronous ৰূপে লিখা, লিখা কর্মক্ষমতা উন্নত কৰা

##### অপৰিসীম(s): write-behind

* যদি ক্যাশ ডাউন হয় ডেটা ষ্ট'ৰলৈ সংৰক্ষণ কৰাৰ আগতে, তেন্তে ডেটা হেৰুৱা সম্ভৱ।
* Write-behind বাস্তৱায়ন কৰা cache-aside বা write-throughতকৈ অধিক জটিল।

#### Refresh-ahead

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/kxtjqgE.png">
  <br/>
  <i><a href=http://www.slideshare.net/tmatyashovsky/from-cache-to-in-memory-data-grid-introduction-to-hazelcast>উৎস: From cache to in-memory data grid</a></i>
</p>

আপুনি ক্যাশটো কনফিগাৰ কৰিব পাৰে যাতে যিকোনো নতুনকৈ এক্সেছ কৰা ক্যাশ এণ্ট্রি তাৰ মেয়াদ শেষ হোৱাৰ আগতে স্বয়ংক্ৰিয়ভাৱে ৰিফ্ৰেশ হয়।

Refresh-aheadত latency কম হ’ব পাৰে read-throughতকৈ, যদি ক্যাশে ঠিককৈ অনুমান কৰিব পাৰে যে কোন বস্তু আগলৈ প্ৰয়োজন হ’ব।

##### অপৰিসীম(s): refresh-ahead

* ভবিষ্যতে কোন বস্তুসমূহৰ প্ৰয়োজন হ’ব পাৰে, তাৰ সঠিকভাৱে পূৰ্বাভাস নকৰিলে refresh-ahead নথকা অৱস্থাতকৈ কম কাৰ্যক্ষমতা দেখা দিব পাৰে।

### অসুবিধা(সমূহ): কেশ

* কেশ আৰু মূল তথ্য উৎস যেনে ডেটাবেইচৰ মাজত সঙ্গতি বজাই ৰাখিব লাগিব [কেশ invalidation](https://en.wikipedia.org/wiki/Cache_algorithms)ৰ জৰিয়তে।
* কেশ invalidation এটা কঠিন সমস্যা, কেশ কেতিয়া আপডেট কৰিব লাগে, সেই বিষয়ত অতিৰিক্ত জটিলতা থাকে।
* Redis বা memcached যোগ কৰাৰ দৰে এপ্লিকেশ্যন পৰিবৰ্তন কৰিব লাগিব।

### উৎস(সমূহ) আৰু অধিক পঢ়া

* [কেশৰ পৰা ইন-মেমৰি ডাটা গ্ৰিডলৈ](http://www.slideshare.net/tmatyashovsky/from-cache-to-in-memory-data-grid-introduction-to-hazelcast)
* [স্কেলেবল ছিষ্টেম ডিজাইন পেটাৰ্ন](http://horicky.blogspot.com/2010/10/scalable-system-design-patterns.html)
* [স্কেলৰ বাবে ছিষ্টেম আৰ্কিটেক্টিংৰ পৰিচয়](http://lethain.com/introduction-to-architecting-systems-for-scale/)
* [স্কেলেবিলিটি, উপলব্ধতা, স্থিতিশীলতা, পেটাৰ্ন](http://www.slideshare.net/jboner/scalability-availability-stability-patterns/)
* [স্কেলেবিলিটি](https://web.archive.org/web/20230126233752/https://www.lecloud.net/post/9246290032/scalability-for-dummies-part-3-cache)
* [AWS ElastiCache কৌশল](http://docs.aws.amazon.com/AmazonElastiCache/latest/UserGuide/Strategies.html)
* [উইকিপিডিয়া](https://en.wikipedia.org/wiki/Cache_(computing))

## অসময়তাবাদ

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/54GYsSx.png">
  <br/>
  <i><a href=http://lethain.com/introduction-to-architecting-systems-for-scale/#platform_layer>উৎস: স্কেলৰ বাবে ছিষ্টেম আৰ্কিটেক্টিংৰ পৰিচয়</a></i>
</p>

অসময়তাবাদী workflow-এ মূল্যবান অপাৰেশ্যনসমূহৰ অনুৰোধ সময় কমাবলৈ সহায় কৰে, যিবোৰ সাধাৰণতে ইন-লাইনত কৰা হ’লেহেঁতেন।  এইবোৰে আগতীয়াকৈ সময়-খৰচী কাম আদায় কৰাৰ দ্বাৰাও সহায় কৰিব পাৰে, যেনে সময় সময়ত ডেটা aggregat কৰা।

### মেছেজ কিউসমূহ

মেছেজ কিউসমূহে মেছেজ গ্ৰহণ, সংৰক্ষণ আৰু বিতৰণ কৰে।  যদি এটা অপাৰেশ্যন ইন-লাইনত কৰা বাবে ধীৰ হয়, তেন্তে নিম্নলিখিত workflow-ৰ সৈতে মেছেজ কিউ ব্যৱহাৰ কৰিব পাৰে:

* এটা এপ্লিকেশ্যনে কিউত এটা চাকৰি প্ৰকাশ কৰে, তাৰ পিছত ব্যৱহাৰকাৰীক চাকৰি স্থিতি জানিবলৈ দিয়ে
* এটা worker-এ কিউৰ পৰা চাকৰি লৈ, প্ৰক্ৰিয়া কৰে, তাৰ পিছত চাকৰি সম্পূৰ্ণ হোৱাৰ সংকেত দিয়ে

ব্যৱহাৰকাৰী blocked নহয় আৰু চাকৰি background-ত সম্পাদিত হয়।  এই সময়ত, client-এ optionally অলপ processing কৰিব পাৰে যাতে কাম শেষ হোৱাৰ অনুভূতি হয়।  উদাহৰণস্বৰূপে, এটা tweet post কৰিলে, tweet-টো তৎক্ষণাত timeline-ত দেখুওৱা হ’ব পাৰে, কিন্তু সকলো follower-লৈ পৌঁছিবলৈ অলপ সময় লাগিব পাৰে।

**[Redis](https://redis.io/)** এটা সহজ মেছেজ broker হিচাপে উপযোগী, কিন্তু মেছেজ হেৰাই যাব পাৰে।

**[RabbitMQ](https://www.rabbitmq.com/)** জনপ্ৰিয়, কিন্তু 'AMQP' প্ৰ’টোকল অনুসৰণ কৰিব আৰু নিজৰ node-সমূহ পৰিচালনা কৰিব লাগিব।
**[Amazon SQS](https://aws.amazon.com/sqs/)** হোষ্ট কৰা হৈছে কিন্তু ইয়াত উচ্চ বিলম্বতা থাকিব পাৰে আৰু বাৰ্তা দুবাৰ প্ৰেৰণ হোৱাৰ সম্ভাৱনা আছে।

### Task queues

Task queues-এ কাৰ্য আৰু তাৰ লগত সংযুক্ত তথ্য গ্ৰহণ কৰে, সেইবোৰ চলায়, আৰু তাৰ ফলাফল প্ৰেৰণ কৰে।  এইবোৰে সময় নিৰ্ধাৰণৰ সমৰ্থন কৰে আৰু পটভূমিত পৰিসংখ্যা-ভিত্তিক কাম চলাবলৈ ব্যৱহাৰ কৰিব পৰা যায়।

**[Celery](https://docs.celeryproject.org/en/stable/)**-এ সময় নিৰ্ধাৰণৰ সমৰ্থন আছে আৰু প্ৰাথমিকভাৱে Python-ৰ সমৰ্থন আছে।

### Back pressure

যদি queues-ৰ আকাৰ উল্লেখযোগ্যভাৱে বৃদ্ধি পায়, তেন্তে queue-ৰ আকাৰ মেম'ৰিৰ তুলনাত বেছি হ'ব পাৰে, যাৰ ফলত cache misses, disk reads, আৰু অধিক ধীৰ গতিৰ কাৰ্যক্ষমতা দেখা যায়। [Back pressure](http://mechanical-sympathy.blogspot.com/2012/05/apply-back-pressure-when-overloaded.html)-এ queue-ৰ আকাৰ সীমিত কৰি উচ্চ throughput ৰেট আৰু ইতিমধ্যে queue-ত থকা কামৰ বাবে ভাল প্ৰতিক্ৰিয়া সময় বজাই ৰাখিবলৈ সহায় কৰে।  Queue পূৰ্ণ হৈ গ'লে, ক্লায়েন্টে server busy বা HTTP 503 status code পায় আৰু পাছত পুনৰ চেষ্টা কৰিবলৈ অনুৰোধ কৰা হয়।  ক্লায়েন্টে পিছত অনুৰোধ পুনৰ চেষ্টা কৰিব পাৰে, সম্ভৱত [exponential backoff](https://en.wikipedia.org/wiki/Exponential_backoff)-ৰ সৈতে।

### Disadvantage(s): asynchronism

* সস্তা গণনা আৰু realtime workflow-ৰ দৰে ব্যৱহাৰ ক্ষেত্ৰসমূহ synchronous কাৰ্যৰ বাবে অধিক উপযুক্ত হ'ব পাৰে, কিয়নো queue যোগ কৰাৰ ফলত বিলম্ব আৰু জটিলতা বৃদ্ধি পায়।

### উৎস(সমূহ) আৰু অধিক পঢ়িবলৈ

* [It's all a numbers game](https://www.youtube.com/watch?v=1KRYH75wgy4)
* [Applying back pressure when overloaded](http://mechanical-sympathy.blogspot.com/2012/05/apply-back-pressure-when-overloaded.html)
* [Little's law](https://en.wikipedia.org/wiki/Little%27s_law)
* [What is the difference between a message queue and a task queue?](https://www.quora.com/What-is-the-difference-between-a-message-queue-and-a-task-queue-Why-would-a-task-queue-require-a-message-broker-like-RabbitMQ-Redis-Celery-or-IronMQ-to-function)

## যোগাযোগ

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/5KeocQs.jpg">
  <br/>
  <i><a href=http://www.escotal.com/osilayer.html>উৎস: OSI 7 স্তৰ মডেল</a></i>
</p>

### Hypertext transfer protocol (HTTP)

HTTP হৈছে ক্লায়েন্ট আৰু ছাৰ্ভাৰৰ মাজত তথ্য সংহতি আৰু প্ৰেৰণৰ এটা পদ্ধতি।  এইটো এটা অনুৰোধ/প্ৰতিক্ৰিয়া প্ৰ'ট'কল: ক্লায়েন্টে অনুৰোধ পাঠায় আৰু ছাৰ্ভাৰে সংশ্লিষ্ট বিষয়বস্তু আৰু অনুৰোধৰ সম্পূৰ্ণতাৰ অৱস্থাৰ তথ্যৰ সৈতে প্ৰতিক্ৰিয়া প্ৰেৰণ কৰে।  HTTP স্ব-নিয়ন্ত্ৰিত, অনুৰোধ আৰু প্ৰতিক্ৰিয়া বহু মধ্যস্থ ৰাউটাৰ আৰু ছাৰ্ভাৰৰ মাজেৰে যাব পাৰে, যিবোৰে load balancing, caching, encryption, আৰু compression কৰে।

এটা সাধাৰণ HTTP অনুৰোধত এটা verb (method) আৰু এটা resource (endpoint) থাকে।  তলত সাধাৰণ HTTP verb-সমূহ দিয়া হৈছে:

| Verb | বিৱৰণ | Idempotent* | Safe | Cacheable |


| GET | এটা ৰিছৰ্চ পঢ়ে | হয় | হয় | হয় |
| POST | এটা ৰিছৰ্চ সৃষ্টি কৰে অথবা ডাটা ব্যৱহাৰ কৰি প্ৰক্ৰিয়া আৰম্ভ কৰে | নহয় | নহয় | হয় যদি প্ৰতিক্ৰিয়াত সতেজতাৰ তথ্য থাকে |
| PUT | এটা ৰিছৰ্চ সৃষ্টি কৰে বা প্ৰতিস্থাপন কৰে | হয় | নহয় | নহয় |
| PATCH | এটা ৰিছৰ্চ আংশিকভাৱে আপডেট কৰে | নহয় | নহয় | হয় যদি প্ৰতিক্ৰিয়াত সতেজতাৰ তথ্য থাকে |
| DELETE | এটা ৰিছৰ্চ ডিলিট কৰে | হয় | নহয় | নহয় |

*বহুবাৰ কল কৰিব পাৰি, ফলাফলত কোনো পাৰ্থক্য নহয়।*

HTTP এটা এপ্লিকেশ্বন লেয়াৰ প্ৰ'ট'কল, যি নিম্ন-স্তৰৰ প্ৰ'ট'কল যেনে **TCP** আৰু **UDP**-ৰ ওপৰত নিৰ্ভৰ কৰে।

#### উৎস(সমূহ) আৰু অধিক পঢ়িবলৈ: HTTP

* [HTTP কি?](https://www.nginx.com/resources/glossary/http/)
* [HTTP আৰু TCP-ৰ পাৰ্থক্য](https://www.quora.com/What-is-the-difference-between-HTTP-protocol-and-TCP-protocol)
* [PUT আৰু PATCH-ৰ পাৰ্থক্য](https://laracasts.com/discuss/channels/general-discussion/whats-the-differences-between-put-and-patch?page=1)

### Transmission control protocol (TCP)

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/JdAsdvG.jpg">
  <br/>
  <i><a href=http://www.wildbunny.co.uk/blog/2012/10/09/how-to-make-a-multi-player-game-part-1/>উৎস: কিদৰে মাল্টিপ্লেয়াৰ গেম বনাব</a></i>
</p>

TCP হৈছে এটা সংযোগ-ভিত্তিক প্ৰ'ট'কল [IP নেটৱৰ্ক](https://en.wikipedia.org/wiki/Internet_Protocol)-ৰ ওপৰত।  সংযোগ স্থাপন আৰু সমাপ্তি [handshake](https://en.wikipedia.org/wiki/Handshaking)-ৰ দ্বাৰা হয়।  সকলো পেকেট মূল অনুক্ৰম আৰু বিনা বিকৃতিৰ সৈতে গন্তব্যলৈ যাবলৈ নিশ্চিত কৰা হয়:

* প্ৰতিটো পেকেটৰ বাবে অনুক্ৰম সংখ্যা আৰু [checksum fields](https://en.wikipedia.org/wiki/Transmission_Control_Protocol#Checksum_computation)
* [Acknowledgement](https://en.wikipedia.org/wiki/Acknowledgement_(data_networks)) পেকেট আৰু স্বয়ংক্ৰিয় পুনঃপ্ৰেৰণ

যদি প্ৰেৰণকাৰীয়ে সঠিক প্ৰতিক্ৰিয়া লাভ নকৰে, তেতিয়া পেকেট পুনৰ প্ৰেৰণ কৰিব।  বহু বাৰ টাইমআউট হ’লে, সংযোগ বন্ধ হৈ যায়।  TCP-ত [flow control](https://en.wikipedia.org/wiki/Flow_control_(data)) আৰু [congestion control](https://en.wikipedia.org/wiki/Network_congestion#Congestion_control) থাকে।  এই নিশ্চয়তাসমূহে বিলম্ব ঘটায় আৰু সাধাৰণতে UDP-তকৈ কম দক্ষ প্ৰেৰণ হয়।

উচ্চ throughput নিশ্চিত কৰিবলৈ, ৱেব ছাৰ্ভাৰে বহুল TCP সংযোগ খোলা ৰাখিব পাৰে, যাৰ ফলত উচ্চ মেম'ৰি ব্যৱহাৰ হয়।  ৱেব ছাৰ্ভাৰ থ্ৰেড আৰু উদাহৰণস্বৰূপে [memcached](https://memcached.org/) ছাৰ্ভাৰৰ মাজত বহু সংযোগ খোলা ৰাখা ব্যয়বহুল হব পাৰে।  [Connection pooling](https://en.wikipedia.org/wiki/Connection_pool) সহায় কৰিব পাৰে, লগতে UDP-লৈ switch কৰাৰ চিন্তা কৰিব পাৰি।

TCP উপযোগী যেতিয়া উচ্চ reliability প্ৰয়োজন, কিন্তু সময় সংবেদনশীলতা কম।  কিছুমান উদাহৰণ হৈছে ৱেব ছাৰ্ভাৰ, ডাটাবেছ তথ্য, SMTP, FTP, আৰু SSH।

UDP-ৰ পৰিৱৰ্তে TCP ব্যৱহাৰ কৰক, যেতিয়া:

* আপোনাক সকলো ডাটা অক্ষতভাৱে আহি পোৱাৰ প্ৰয়োজন
* আপুনি নেটৱৰ্ক throughputৰ সৰ্বাধিক ব্যৱহাৰৰ স্বয়ংক্ৰিয় অনুমান কৰিব বিচাৰে

### ইউজাৰ ডাটাগ্ৰাম প্ৰ'ট'কল (UDP)

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/yzDrJtA.jpg">
  <br/>
  <i><a href=http://www.wildbunny.co.uk/blog/2012/10/09/how-to-make-a-multi-player-game-part-1/>উৎস: মাল্টি-প্লেয়াৰ গেম কেনেকৈ বনাব</a></i>
</p>

UDP সংযোগহীন।  ডাটাগ্ৰাম (পেকেটৰ সদৃশ) কেৱল ডাটাগ্ৰাম স্তৰত গ্যারাণ্টি কৰা হয়।  ডাটাগ্ৰামসমূহ গন্তব্যস্থানত অশৃঙ্খলভাৱে বা একেবাৰে নাও পোৱাৰ সম্ভাৱনা থাকে।  UDP-ত সংকুলন নিয়ন্ত্ৰণৰ সুবিধা নাই।  TCP-ৰ গ্যারাণ্টি নথকা বাবে, UDP সাধাৰণতে অধিক কাৰ্যকৰী।

UDP-এ সম্প্রচাৰ কৰিব পাৰে, অৰ্থাৎ ডাটাগ্ৰামসমূহ উপ-নেটৰ সকলো ডিভাইচলৈ পঠিয়াব পাৰে।  ই [DHCP](https://en.wikipedia.org/wiki/Dynamic_Host_Configuration_Protocol)-ৰ ক্ষেত্ৰত সহায়ক, কাৰণ ক্লায়েন্টে এতিয়াও IP ঠিকনা লাভ কৰা নাই, ফলত IP ঠিকনা নোহোৱাকৈ TCP-এ ষ্ট্ৰীম কৰিব নোৱাৰে।

UDP কম বিশ্বাসযোগ্য, কিন্তু VoIP, ভিডিঅ' চেট, ষ্ট্ৰীমিং, আৰু ৰিয়েলটাইম মাল্টিপ্লেয়াৰ গেমবোৰত ভাল কাম কৰে।

TCP-ৰ ওপৰত UDP ব্যৱহাৰ কৰক যেতিয়া:

* আপোনাৰ আটাইতকৈ কম বিলম্ব প্ৰয়োজন
* দেৰিতে অহা তথ্য হেৰুৱা তথ্যতকৈ বেয়া
* আপোনায়ে নিজৰ ত্ৰুটি সংশোধন ব্যৱস্থা কৰিব বিচাৰে

#### উৎস(সমূহ) আৰু অধিক পঢ়িবলৈ: TCP আৰু UDP

* [গেম প্ৰগ্ৰামিংৰ বাবে নেটৱৰ্কিং](http://gafferongames.com/networking-for-game-programmers/udp-vs-tcp/)
* [TCP আৰু UDP প্ৰ'ট'কলৰ মুখ্য পাৰ্থক্য](http://www.cyberciti.biz/faq/key-differences-between-tcp-and-udp-protocols/)
* [TCP আৰু UDP-ৰ পাৰ্থক্য](http://stackoverflow.com/questions/5970383/difference-between-tcp-and-udp)
* [ট্ৰান্সমিশন কণ্ট্ৰ'ল প্ৰ'ট'কল](https://en.wikipedia.org/wiki/Transmission_Control_Protocol)
* [ইউজাৰ ডাটাগ্ৰাম প্ৰ'ট'কল](https://en.wikipedia.org/wiki/User_Datagram_Protocol)
* [Facebook-ত Memcache স্কেলিং](http://www.cs.bu.edu/~jappavoo/jappavoo.github.com/451/papers/memcache-fb.pdf)

### ৰিম'ট প্ৰ'চিজাৰ কল (RPC)

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/iF4Mkb5.png">
  <br/>
  <i><a href=http://www.puncsky.com/blog/2016-02-13-crack-the-system-design-interview>উৎস: Crack the system design interview</a></i>
</p>

RPC-ত, ক্লায়েন্টে এটা প্ৰ'চিজাৰ এটা বেলেগ ঠিকনা স্থানত, সাধাৰণতে এটা ৰিম'ট চাৰ্ভাৰত চলায়।  প্ৰ'চিজাৰটো এনে ধৰণে কোড কৰা হয় যেন ই এটা স্থানীয় প্ৰ'চিজাৰ কল, আৰু ক্লায়েন্ট প্ৰগ্ৰামৰ পৰা চাৰ্ভাৰৰ সৈতে যোগাযোগৰ বিৱৰণবোৰ গোপন থাকে।  ৰিম'ট কলবোৰ সাধাৰণতে স্থানীয় কলতকৈ ধীৰ আৰু কম বিশ্বাসযোগ্য, সেয়ে RPC কলবোৰ স্থানীয় কলৰ পৰা পৃথক কৰি চিনাক্ত কৰা সহায়ক।  জনপ্ৰিয় RPC ফ্ৰেমৱাৰ্কত আছে [Protobuf](https://developers.google.com/protocol-buffers/), [Thrift](https://thrift.apache.org/), আৰু [Avro](https://avro.apache.org/docs/current/)।

RPC এটা অনুৰোধ-প্ৰতিক্ৰিয়া প্ৰ'ট'কল:

* **ক্লায়েন্ট প্ৰগ্ৰাম** - ক্লায়েন্ট ষ্টাব প্ৰক্ৰিয়া কল কৰে।  পেৰামিটাৰসমূহ স্থানীয় প্ৰক্ৰিয়া কলৰ দৰে ষ্টেকত পুশ কৰা হয়।
* **ক্লায়েন্ট ষ্টাব প্ৰক্ৰিয়া** - প্ৰক্ৰিয়া আইডি আৰু আৰ্গুমেন্টসমূহ অনুৰোধ বাৰ্তাত মাৰ্শেল (পেক) কৰে।
* **ক্লায়েন্ট কমিউনিকেশ্যন মডিউল** - OS-এ ক্লায়েন্টৰ পৰা ছাৰ্ভাৰলৈ বাৰ্তা পঠিয়ায়।
* **ছাৰ্ভাৰ কমিউনিকেশ্যন মডিউল** - OS-এ আহি থকা পেকেটসমূহ ছাৰ্ভাৰ ষ্টাব প্ৰক্ৰিয়ালৈ প্ৰেৰণ কৰে।
* **ছাৰ্ভাৰ ষ্টাব প্ৰক্ৰিয়া** - ফলাফলসমূহ আনমাৰ্শেল কৰে, প্ৰক্ৰিয়া আইডি মিলোৱা ছাৰ্ভাৰ প্ৰক্ৰিয়া কল কৰে আৰু দিয়া আৰ্গুমেন্টসমূহ প্ৰেৰণ কৰে।
* ছাৰ্ভাৰৰ প্ৰতিক্ৰিয়া ওপৰৰ পদক্ষেপসমূহ বিপৰীত ৰূপত পুনৰাবৃত্তি কৰে।

নমুনা RPC কলসমূহ:

```
GET /someoperation?data=anId

POST /anotheroperation
{
  "data":"anId";
  "anotherdata": "another value"
}
```

RPC ব্যৱহাৰ আচৰণবোৰ উন্মোচন কৰাত কেন্দ্ৰিত। RPC সাধাৰণতে কাৰ্যক্ষমতাৰ কাৰণে ভিতৰুৱা যোগাযোগত ব্যৱহাৰ কৰা হয়, কিয়নো আপুনি নিজৰ ব্যৱহাৰ ক্ষেত্ৰবোৰত ভালকৈ মিলাব পৰা দেশীয় কলবোৰ হাতৰে তৈয়াৰ কৰিব পাৰে।

দেশীয় গ্ৰন্থাগাৰ (অর্থাৎ SDK) বাছনি কৰক যেতিয়া:

* আপুনি নিজৰ লক্ষ্য প্লেটফৰ্ম জানে।
* আপুনি নিয়ন্ত্ৰণ কৰিব বিচাৰে কেনেকৈ আপোনাৰ "যুক্তি" প্রবেশযোগ্য হব।
* আপুনি নিয়ন্ত্ৰণ কৰিব বিচাৰে কেনেকৈ ত্ৰুটি নিয়ন্ত্ৰণ আপোনাৰ গ্ৰন্থাগাৰৰ বাহিৰত হব।
* কাৰ্যক্ষমতা আৰু শেষ ব্যৱহাৰকাৰীৰ অভিজ্ঞতা আপোনাৰ মুখ্য চিন্তা।

HTTP API যি **REST** অনুসৰণ কৰে, বেছিভাগ সময়ত ৰাজহুৱা API-ৰ বাবে ব্যৱহাৰ কৰা হয়।

#### অসুবিধা(সমূহ): RPC

* RPC ক্লায়েন্টবোৰ সেৱা বাস্তবায়নৰ সৈতে শক্তকৈ সংযুক্ত হৈ পৰে।
* প্ৰতিটো নতুন অপাৰেচন অথবা ব্যৱহাৰক্ষেত্ৰৰ বাবে এটা নতুন API সংজ্ঞায়িত কৰিব লগা হয়।
* RPC ডিবাগ কৰাটো কঠিন হ’ব পাৰে।
* আপুনি হয়তো বিদ্যমান প্ৰযুক্তিবোৰ সোজাকৈ ব্যৱহাৰ কৰিব নোৱাৰে। উদাহৰণস্বৰূপ, [RPC কলবোৰ সঠিকভাৱে কেছ কৰা হৈছে](https://web.archive.org/web/20170608193645/http://etherealbits.com/2012/12/debunking-the-myths-of-rpc-rest/) নিশ্চিত কৰিবলৈ, [Squid](http://www.squid-cache.org/) যেনে কেছিং ছাৰ্ভাৰত অৰ্থপূৰ্ণ অতিৰিক্ত প্ৰচেষ্টা কৰিব লাগিব পাৰে।

### প্ৰতিনিধিত্বমূলক অৱস্থা স্থানান্তৰ (REST)

REST হৈছে এটা স্থাপত্যিক শৈলী যিয়ে ক্লায়েন্ট/চাৰ্ভাৰ মডেলক বলবৎ কৰে, য’ত ক্লায়েন্টে চাৰ্ভাৰৰ দ্বাৰা পৰিচালিত একেটা সম্পদৰ ওপৰত কাৰ্য কৰে। চাৰ্ভাৰে সম্পদৰ প্ৰতিনিধিত্ব আৰু সেইবোৰক পৰিবৰ্তন অথবা নতুন প্ৰতিনিধিত্ব লাভ কৰিবলৈ ব্যৱস্থা প্ৰদান কৰে। সকলো যোগাযোগ অবস্থা-হীন আৰু কেছযোগ্য হ’ব লাগিব।

RESTful ইণ্টাৰফেছৰ চাৰিটা গুণ আছে:

* **সম্পদ চিনাক্ত কৰক (HTTP-ত URI)** - যিকোনো অপাৰেচনৰ বাবে একে URI ব্যৱহাৰ কৰক।
* **প্ৰতিনিধিত্বৰ সৈতে পৰিবৰ্তন কৰক (HTTP-ত Verb)** - verb, header আৰু body ব্যৱহাৰ কৰক।
* **স্ব-বৰ্ণনাত্মক ত্ৰুটি বার্তা (HTTP-ত status response)** - status code ব্যৱহাৰ কৰক, নতুনকৈ সৃষ্টি নকৰিব।
* **[HATEOAS](http://restcookbook.com/Basics/hateoas/) (HTTP-ৰ বাবে HTML ইণ্টাৰফেছ)** - আপোনাৰ ৱেব সেৱা সম্পূৰ্ণৰূপে ব্ৰাউজাৰত প্ৰৱেশযোগ্য হ’ব লাগিব।

REST কলৰ উদাহৰণ:

```
GET /someresources/anId

PUT /someresources/anId
{"anotherdata": "another value"}
```
REST ডাটা উন্মোচন কৰিবলৈ কেন্দ্ৰিত। ই ক্লায়েন্ট/চাৰ্ভাৰৰ মাজত সংযোগ কমাই দিয়ে আৰু সাধাৰণতে জনসাধাৰণ HTTP API-সমূহৰ বাবে ব্যৱহাৰ কৰা হয়। REST অধিক সাধাৰণ আৰু এক ৰূপত সম্পদসমূহ URIsৰ জৰিয়তে উন্মোচন কৰে, [হেডাৰৰ জৰিয়তে প্ৰতিনিধিত্ব](https://github.com/for-GET/know-your-http-well/blob/master/headers.md), আৰু GET, POST, PUT, DELETE, আৰু PATCH যেনে verb-সমূহৰ জৰিয়তে actionসমূহ কৰে। Stateless হোৱাৰ বাবে, REST horizontal scaling আৰু partitioning-ৰ বাবে অতি উত্তম।

#### অসুবিধা(সমূহ): REST

* REST ডাটা উন্মোচনলৈ কেন্দ্ৰিত হোৱাৰ বাবে, যদি সম্পদসমূহ স্বাভাৱিকভাৱে সহজ হায়াৰাৰ্কিত সংগঠিত বা প্ৰৱেশযোগ্য নহয়, তেন্তে ই ভাল বাছনি নহব পাৰে। উদাহৰণস্বৰূপ, বিগত এক ঘণ্টাত নিৰ্দিষ্ট ইভেন্টসমূহৰ সৈতে মিল থকা সকলো আপডেট কৰা ৰেকৰ্ডসমূহ উভতি দিয়াটো সহজে path হিচাপে প্ৰকাশ কৰিব নোৱাৰি। REST-ৰ সৈতে, ই URI path, query parameter, আৰু সম্ভৱপৰ অনুৰোধ বডিৰ সংমিশ্ৰণৰ জৰিয়তে বাস্তবায়িত হ’ব পাৰে।
* REST সাধাৰণতে কেইটামান verb (GET, POST, PUT, DELETE, আৰু PATCH)ত নিৰ্ভৰ কৰে যি কেতিয়াবা আপোনাৰ ব্যৱহাৰক্ষেত্ৰত ফিট নকৰে। উদাহৰণস্বৰূপ, মেয়াদ উত্তীর্ণ হোৱা নথিপত্ৰ archive folder-লৈ স্থানান্তৰ কৰা এই verb-সমূহৰ ভিতৰত নিখুঁতভাৱে ফিট নকৰে।
* Nested হায়াৰাৰ্কিত জটিল সম্পদসমূহ উদ্ধাৰ কৰিবলৈ ক্লায়েন্ট আৰু চাৰ্ভাৰৰ মাজত একাধিক round tripৰ প্ৰয়োজন হয় যাতে একেলগে ভিউসমূহ ৰেণ্ডাৰ কৰিব পাৰি, যেনে ব্লগ এণ্ট্ৰীৰ বিষয়বস্তু আৰু সেই এণ্ট্ৰীৰ কমেণ্টসমূহ উদ্ধাৰ কৰা। ভিন্ন নেটৱৰ্ক পৰিস্থিতিত চলা ম’বাইল এপ্লিকেশ্যনসমূহৰ বাবে এই একাধিক roundtrip অত্যন্ত অনাকাংক্ষিত।
* সময়ৰ সৈতে, API response-ত অধিক fields যোগ হ’ব পাৰে আৰু পুৰণি ক্লায়েন্টসমূহে সকলো নতুন data field লাভ কৰে, যিবোৰ তেওঁলোকে প্ৰয়োজন নকৰে, ফলস্বৰূপ payload size বৃদ্ধি পায় আৰু latencyও বেছি হয়।

### RPC আৰু REST কলৰ তুলনা

| কাৰ্য | RPC | REST |
|---|---|---|
| Signup    | **POST** /signup | **POST** /persons |
| Resign    | **POST** /resign<br/>{<br/>"personid": "1234"<br/>} | **DELETE** /persons/1234 |
| এজন ব্যক্তিক পঢ়া | **GET** /readPerson?personid=1234 | **GET** /persons/1234 |
| এজন ব্যক্তিৰ items list পঢ়া | **GET** /readUsersItemsList?personid=1234 | **GET** /persons/1234/items |
| এজন ব্যক্তিৰ itemsত item যোগ কৰা | **POST** /addItemToUsersItemsList<br/>{<br/>"personid": "1234";<br/>"itemid": "456"<br/>} | **POST** /persons/1234/items<br/>{<br/>"itemid": "456"<br/>} |
| এটা item আপডেট কৰা    | **POST** /modifyItem<br/>{<br/>"itemid": "456";<br/>"key": "value"<br/>} | **PUT** /items/456<br/>{<br/>"key": "value"<br/>} |
| এটা item ডিলিট কৰা | **POST** /removeItem<br/>{<br/>"itemid": "456"<br/>} | **DELETE** /items/456 |

<p align="center">
  <i><a href=https://apihandyman.io/do-you-really-know-why-you-prefer-rest-over-rpc/>উৎস: Do you really know why you prefer REST over RPC</a></i>
</p>

#### উৎস(সমূহ) আৰু অধিক পঢ়া: REST আৰু RPC

* [Do you really know why you prefer REST over RPC](https://apihandyman.io/do-you-really-know-why-you-prefer-rest-over-rpc/)
* [When are RPC-ish approaches more appropriate than REST?](http://programmers.stackexchange.com/a/181186)
* [REST vs JSON-RPC](http://stackoverflow.com/questions/15056878/rest-vs-json-rpc)
* [Debunking the myths of RPC and REST](https://web.archive.org/web/20170608193645/http://etherealbits.com/2012/12/debunking-the-myths-of-rpc-rest/)
* [What are the drawbacks of using REST](https://www.quora.com/What-are-the-drawbacks-of-using-RESTful-APIs)
* [Crack the system design interview](http://www.puncsky.com/blog/2016-02-13-crack-the-system-design-interview)
* [Thrift](https://code.facebook.com/posts/1468950976659943/)
* [Why REST for internal use and not RPC](http://arstechnica.com/civis/viewtopic.php?t=1190508)

## নিৰাপত্তা

এই অংশটো কিছু আপডেটৰ প্ৰয়োজন। [অংদান কৰক](#contributing) বিবেচনা কৰক!

সুৰক্ষা এটা বিস্তৃত বিষয়।  আপোনাৰ যথেষ্ট অভিজ্ঞতা, সুৰক্ষা ক্ষেত্ৰৰ পটভূমি, অথবা সুৰক্ষাৰ জ্ঞান আৱশ্যক হোৱা পদৰ বাবে আবেদন নকৰিলে, সম্ভৱতঃ আপোনাৰ আধাৰভূত জ্ঞানৰ বাহিৰে অধিক জানিব লাগিব নালাগে:

* পৰিবহণত আৰু বিশ্ৰামত সংকেত কৰক।
* [XSS](https://en.wikipedia.org/wiki/Cross-site_scripting) আৰু [SQL injection](https://en.wikipedia.org/wiki/SQL_injection) ৰোধ কৰিবলৈ সকলো ব্যৱহাৰকাৰীৰ ইনপুট অথবা ব্যৱহাৰকাৰীৰ বাবে উন্মুক্ত কৰা যিকোনো ইনপুট পেৰামিটাৰ পৰিষ্কাৰ কৰক।
* SQL injection ৰোধ কৰিবলৈ পাৰামেট্ৰাইজড কুৱেৰী ব্যৱহাৰ কৰক।
* [সৰ্বনিম্ন অধিকাৰৰ মূলনীতি](https://en.wikipedia.org/wiki/Principle_of_least_privilege) ব্যৱহাৰ কৰক।

### উৎস(সমূহ) আৰু অধিক পঢ়িবলৈ

* [API সুৰক্ষা চেকলিষ্ট](https://github.com/shieldfy/API-Security-Checklist)
* [বিকাশকাৰীসকলৰ বাবে সুৰক্ষা গাইড](https://github.com/FallibleInc/security-guide-for-developers)
* [OWASP শীৰ্ষ দশ](https://www.owasp.org/index.php/OWASP_Top_Ten_Cheat_Sheet)

## সংযোজন

কেতিয়াবা আপোনাক 'ব্যাক-অফ-দি-এনভেল' অনুমান কৰিবলৈ কৈছ।  উদাহৰণস্বৰূপে, আপোনাক ঠিক কৰিব লাগিব যে ১০০টা ছবি থাম্বনেইল ডিস্কৰ পৰা সৃষ্টি কৰিবলৈ কিমান সময় লাগিব বা এটা ডাটা গঠনত কিমান মেমৰী লাগিব।  **দুই শক্তিৰ তালিকা** আৰু **প্ৰত্যেক প্ৰগ্ৰামাৰে জানিবলগীয়া বিলম্বতা সংখ্যা** সহায়ক সংজ্ঞা।

### দুই শক্তিৰ তালিকা


```
Power           Exact Value         Approx Value        Bytes
---------------------------------------------------------------
7                             128
8                             256
10                           1024   1 thousand           1 KB
16                         65,536                       64 KB
20                      1,048,576   1 million            1 MB
30                  1,073,741,824   1 billion            1 GB
32                  4,294,967,296                        4 GB
40              1,099,511,627,776   1 trillion           1 TB
```

#### উৎস(সমূহ) আৰু অধিক পঢ়িবলৈ

* [দুইৰ শক্তি](https://en.wikipedia.org/wiki/Power_of_two)

### প্ৰতিটো প্ৰগ্ৰামাৰে জানিবলগীয়া লেটেন্সি সংখ্যা

```
Latency Comparison Numbers
--------------------------
L1 cache reference                           0.5 ns
Branch mispredict                            5   ns
L2 cache reference                           7   ns                      14x L1 cache
Mutex lock/unlock                           25   ns
Main memory reference                      100   ns                      20x L2 cache, 200x L1 cache
Compress 1K bytes with Zippy            10,000   ns       10 us
Send 1 KB bytes over 1 Gbps network     10,000   ns       10 us
Read 4 KB randomly from SSD*           150,000   ns      150 us          ~1GB/sec SSD
Read 1 MB sequentially from memory     250,000   ns      250 us
Round trip within same datacenter      500,000   ns      500 us
Read 1 MB sequentially from SSD*     1,000,000   ns    1,000 us    1 ms  ~1GB/sec SSD, 4X memory
HDD seek                            10,000,000   ns   10,000 us   10 ms  20x datacenter roundtrip
Read 1 MB sequentially from 1 Gbps  10,000,000   ns   10,000 us   10 ms  40x memory, 10X SSD
Read 1 MB sequentially from HDD     30,000,000   ns   30,000 us   30 ms 120x memory, 30X SSD
Send packet CA->Netherlands->CA    150,000,000   ns  150,000 us  150 ms

Notes
-----
1 ns = 10^-9 seconds
1 us = 10^-6 seconds = 1,000 ns
1 ms = 10^-3 seconds = 1,000 us = 1,000,000 ns
```
উপৰোক্ত সংখ্যাৰ আধাৰত কিছু সহায়ক মেট্ৰিক্স:

* HDD পৰা ক্রমিকভাৱে পঢ়ক ৩০ MB/s ত
* ১ Gbps ইথাৰনেটৰ পৰা ক্রমিকভাৱে পঢ়ক ১০০ MB/s ত
* SSD পৰা ক্রমিকভাৱে পঢ়ক ১ GB/s ত
* মুখ্য মেমৰীৰ পৰা ক্রমিকভাৱে পঢ়ক ৪ GB/s ত
* প্ৰতি ছেকেণ্ডত ৬-৭ গৰাকী বিশ্বব্যাপী ৰাউণ্ড-ট্ৰিপ
* এটা ডাটা চেন্টাৰৰ ভিতৰত প্ৰতি ছেকেণ্ডত ২,০০০ ৰাউণ্ড-ট্ৰিপ

#### লেটেন্সি সংখ্যাসমূহ দৃশ্যায়িত

![](https://camo.githubusercontent.com/77f72259e1eb58596b564d1ad823af1853bc60a3/687474703a2f2f692e696d6775722e636f6d2f6b307431652e706e67)

#### উৎস(সমূহ) আৰু অধিক পঢ়ক

* [Latency numbers every programmer should know - 1](https://gist.github.com/jboner/2841832)
* [Latency numbers every programmer should know - 2](https://gist.github.com/hellerbarde/2843375)
* [Designs, lessons, and advice from building large distributed systems](http://www.cs.cornell.edu/projects/ladis2009/talks/dean-keynote-ladis2009.pdf)
* [Software Engineering Advice from Building Large-Scale Distributed Systems](https://static.googleusercontent.com/media/research.google.com/en//people/jeff/stanford-295-talk.pdf)

### অতিৰিক্ত ছিষ্টেম ডিজাইন ইণ্টাৰভিউ প্ৰশ্ন

> সাধাৰণ ছিষ্টেম ডিজাইন ইণ্টাৰভিউ প্ৰশ্নসমূহ, প্রতিটো সমাধান কৰিবলৈ সংস্থানৰ সংযোগৰ সৈতে।

| প্ৰশ্ন | সংস্থান(সমূহ) |
|---|---|
| Dropbox দৰে ফাইল ছিঙ্ক সেৱা ডিজাইন কৰক | [youtube.com](https://www.youtube.com/watch?v=PE4gwstWhmc) |
| Google দৰে এখন চাৰ্চ ইঞ্জিন ডিজাইন কৰক | [queue.acm.org](http://queue.acm.org/detail.cfm?id=988407)<br/>[stackexchange.com](http://programmers.stackexchange.com/questions/38324/interview-question-how-would-you-implement-google-search)<br/>[ardendertat.com](http://www.ardendertat.com/2012/01/11/implementing-search-engines/)<br/>[stanford.edu](http://infolab.stanford.edu/~backrub/google.html) |
| Google দৰে স্কেলেবল ৱেব ক্ৰ’লাৰ ডিজাইন কৰক | [quora.com](https://www.quora.com/How-can-I-build-a-web-crawler-from-scratch) |
| Google docs ডিজাইন কৰক | [code.google.com](https://code.google.com/p/google-mobwrite/)<br/>[neil.fraser.name](https://neil.fraser.name/writing/sync/) |
| Redis দৰে কী-ভেলু ষ্ট’ৰ ডিজাইন কৰক | [slideshare.net](http://www.slideshare.net/dvirsky/introduction-to-redis) |
| Memcached দৰে কেছ ছিষ্টেম ডিজাইন কৰক | [slideshare.net](http://www.slideshare.net/oemebamo/introduction-to-memcached) |
| Amazon ৰ দৰে ৰেকমেণ্ডেচন ছিষ্টেম ডিজাইন কৰক | [hulu.com](https://web.archive.org/web/20170406065247/http://tech.hulu.com/blog/2011/09/19/recommendation-system.html)<br/>[ijcai13.org](http://ijcai13.org/files/tutorial_slides/td3.pdf) |
| Bitly ৰ দৰে tinyurl ছিষ্টেম ডিজাইন কৰক | [n00tc0d3r.blogspot.com](http://n00tc0d3r.blogspot.com/) |
| WhatsApp দৰে চেট এপ ডিজাইন কৰক | [highscalability.com](http://highscalability.com/blog/2014/2/26/the-whatsapp-architecture-facebook-bought-for-19-billion.html)
| Instagram ৰ দৰে ছবি শ্বেয়াৰিং ছিষ্টেম ডিজাইন কৰক | [highscalability.com](http://highscalability.com/flickr-architecture)<br/>[highscalability.com](http://highscalability.com/blog/2011/12/6/instagram-architecture-14-million-users-terabytes-of-photos.html) |
| Facebook news feed ফাংশন ডিজাইন কৰক | [quora.com](http://www.quora.com/What-are-best-practices-for-building-something-like-a-News-Feed)<br/>[quora.com](http://www.quora.com/Activity-Streams/What-are-the-scaling-issues-to-keep-in-mind-while-developing-a-social-network-feed)<br/>[slideshare.net](http://www.slideshare.net/danmckinley/etsy-activity-feeds-architecture) |
| Facebook timeline ফাংশন ডিজাইন কৰক | [facebook.com](https://www.facebook.com/note.php?note_id=10150468255628920)<br/>[highscalability.com](http://highscalability.com/blog/2012/1/23/facebook-timeline-brought-to-you-by-the-power-of-denormaliza.html) |
| Facebook chat ফাংশন ডিজাইন কৰক | [erlang-factory.com](http://www.erlang-factory.com/upload/presentations/31/EugeneLetuchy-ErlangatFacebook.pdf)<br/>[facebook.com](https://www.facebook.com/note.php?note_id=14218138919&id=9445547199&index=0) |

| ফেচবুকৰ দৰে এটা গ্ৰাফ সন্ধান ফাংশন ডিজাইন কৰক | [facebook.com](https://www.facebook.com/notes/facebook-engineering/under-the-hood-building-out-the-infrastructure-for-graph-search/10151347573598920)<br/>[facebook.com](https://www.facebook.com/notes/facebook-engineering/under-the-hood-indexing-and-ranking-in-graph-search/10151361720763920)<br/>[facebook.com](https://www.facebook.com/notes/facebook-engineering/under-the-hood-the-natural-language-interface-of-graph-search/10151432733048920) |
| CloudFlareৰ দৰে এটা কন্টেন্ট ডেলিভাৰী নেটৱৰ্ক ডিজাইন কৰক | [figshare.com](https://figshare.com/articles/Globally_distributed_content_delivery/6605972) |
| টুইটাৰৰ দৰে এটা ট্রেণ্ডিং টপিক ব্যৱস্থা ডিজাইন কৰক | [michael-noll.com](http://www.michael-noll.com/blog/2013/01/18/implementing-real-time-trending-topics-in-storm/)<br/>[snikolov .wordpress.com](http://snikolov.wordpress.com/2012/11/14/early-detection-of-twitter-trends/) |
| এটা ৰেণ্ডম ID উৎপাদন ব্যৱস্থা ডিজাইন কৰক | [blog.twitter.com](https://blog.twitter.com/2010/announcing-snowflake)<br/>[github.com](https://github.com/twitter/snowflake/) |
| এটা সময়সীমাৰ ভিতৰত শীৰ্ষ k অনুৰোধসমূহ উভতাই দিয়ক | [cs.ucsb.edu](https://www.cs.ucsb.edu/sites/default/files/documents/2005-23.pdf)<br/>[wpi.edu](http://davis.wpi.edu/xmdv/docs/EDBT11-diyang.pdf) |
| বহু ডাটা চেন্টাৰৰ পৰা ডাটা পৰিসেৱা কৰা ব্যৱস্থা ডিজাইন কৰক | [highscalability.com](http://highscalability.com/blog/2009/8/24/how-google-serves-data-from-multiple-datacenters.html) |
| অনলাইন মাল্টিপ্লেয়াৰ কাৰ্ড গেম ডিজাইন কৰক | [indieflashblog.com](https://web.archive.org/web/20180929181117/http://www.indieflashblog.com/how-to-create-an-asynchronous-multiplayer-game.html)<br/>[buildnewgames.com](http://buildnewgames.com/real-time-multiplayer/) |
| গাৰ্বেজ কালেকশ্বন ব্যৱস্থা ডিজাইন কৰক | [stuffwithstuff.com](http://journal.stuffwithstuff.com/2013/12/08/babys-first-garbage-collector/)<br/>[washington.edu](http://courses.cs.washington.edu/courses/csep521/07wi/prj/rick.pdf) |
| এটা API ৰেট লিমিটাৰ ডিজাইন কৰক | [https://stripe.com/blog/](https://stripe.com/blog/rate-limiters) |
| স্টক এক্সচেঞ্জ (NASDAQ বা Binanceৰ দৰে) ডিজাইন কৰক | [Jane Street](https://youtu.be/b1e4t2k2KJY)<br/>[Golang Implementation](https://around25.com/blog/building-a-trading-engine-for-a-crypto-exchange/)<br/>[Go Implementation](http://bhomnick.net/building-a-simple-limit-order-in-go/) |
| এটা ছিষ্টেম ডিজাইন প্ৰশ্ন যোগ কৰক | [Contribute](#contributing) |

### বাস্তৱিক বিশ্বৰ স্থাপত্যসমূহ

> বাস্তৱিক বিশ্বৰ ছিষ্টেম কিদৰে ডিজাইন কৰা হয় তাৰ বিষয়ে প্ৰবন্ধসমূহ।

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/TcUo2fw.png">
  <br/>
  <i><a href=https://www.infoq.com/presentations/Twitter-Timeline-Scalability>উৎস: Twitter timelines at scale</a></i>
</p>

**তলত থকা প্ৰবন্ধসমূহৰ বাবে সূক্ষ্ম বিষয়ত মন নিদিয়ক, তাৰ সলনি:**

* এই প্ৰবন্ধসমূহত ভাগ পোৱা সাধাৰণ মূলনীতি, প্ৰযুক্তি আৰু ধৰণসমূহ চিনাক্ত কৰক
* প্ৰতিটো উপাদান দ্বাৰা কি সমস্যাৰ সমাধান হয়, ক'ত কাম কৰে, ক'ত নকৰে, সেইবোৰ অধ্যয়ন কৰক
* শিকিব পৰা পাঠবোৰ পৰ্যালোচনা কৰক

|প্ৰকাৰ | ছিষ্টেম | উল্লেখ(সমূহ) |
|---|---|---|
| ডাটা প্ৰসেসিং | **MapReduce** - Googleৰ পৰা বিতৰণ কৰা ডাটা প্ৰসেসিং | [research.google.com](http://static.googleusercontent.com/media/research.google.com/zh-CN/us/archive/mapreduce-osdi04.pdf) |
| ডাটা প্ৰসেসিং | **Spark** - Databricksৰ পৰা বিতৰণ কৰা ডাটা প্ৰসেসিং | [slideshare.net](http://www.slideshare.net/AGrishchenko/apache-spark-architecture) |
| ডাটা প্ৰসেসিং | **Storm** - Twitterৰ পৰা বিতৰণ কৰা ডাটা প্ৰসেসিং | [slideshare.net](http://www.slideshare.net/previa/storm-16094009) |
| | | |
| ডাটা ষ্ট'ৰ | **Bigtable** - Googleৰ পৰা বিতৰণ কৰা কলাম-ভিত্তিক ডেটাবেইচ | [harvard.edu](http://www.read.seas.harvard.edu/~kohler/class/cs239-w08/chang06bigtable.pdf) |
| ডাটা ষ্ট'ৰ | **HBase** - Bigtableৰ মুক্ত উৎস ৰূপ | [slideshare.net](http://www.slideshare.net/alexbaranau/intro-to-hbase) |
| ডাটা ষ্ট'ৰ | **Cassandra** - Facebookৰ পৰা বিতৰণ কৰা কলাম-ভিত্তিক ডেটাবেইচ | [slideshare.net](http://www.slideshare.net/planetcassandra/cassandra-introduction-features-30103666)
| ডাটা ষ্ট'ৰ | **DynamoDB** - Amazonৰ পৰা ডকুমেন্ট-ভিত্তিক ডেটাবেইচ | [harvard.edu](http://www.read.seas.harvard.edu/~kohler/class/cs239-w08/decandia07dynamo.pdf) |
| ডাটা ষ্ট'ৰ | **MongoDB** - ডকুমেন্ট-ভিত্তিক ডেটাবেইচ | [slideshare.net](http://www.slideshare.net/mdirolf/introduction-to-mongodb) |
| ডাটা ষ্ট'ৰ | **Spanner** - Googleৰ পৰা বিশ্বব্যাপী বিতৰণ কৰা ডেটাবেইচ | [research.google.com](http://research.google.com/archive/spanner-osdi2012.pdf) |
| ডাটা ষ্ট'ৰ | **Memcached** - বিতৰিত মেম'ৰি কেছিং ব্যৱস্থা | [slideshare.net](http://www.slideshare.net/oemebamo/introduction-to-memcached) |
| ডাটা ষ্ট'ৰ | **Redis** - বিতৰিত মেম'ৰি কেছিং ব্যৱস্থা স্থায়িত্ব আৰু মানৰ ধৰণৰ সৈতে | [slideshare.net](http://www.slideshare.net/dvirsky/introduction-to-redis) |
| | | |
| ফাইল ছিষ্টেম | **Google File System (GFS)** - বিতৰিত ফাইল ছিষ্টেম | [research.google.com](http://static.googleusercontent.com/media/research.google.com/zh-CN/us/archive/gfs-sosp2003.pdf) |
| ফাইল ছিষ্টেম | **Hadoop File System (HDFS)** - GFS ৰ মুক্ত উৎস ৰূপ | [apache.org](http://hadoop.apache.org/docs/stable/hadoop-project-dist/hadoop-hdfs/HdfsDesign.html) |
| | | |
| বিভিন্ন | **Chubby** - Google ৰ পৰা কম সংযুক্ত বিতৰিত ছিষ্টেমৰ বাবে লক সেৱা | [research.google.com](http://static.googleusercontent.com/external_content/untrusted_dlcp/research.google.com/en/us/archive/chubby-osdi06.pdf) |
| বিভিন্ন | **Dapper** - বিতৰিত ছিষ্টেমৰ ট্রেচিং অবকাঠামো | [research.google.com](http://static.googleusercontent.com/media/research.google.com/en//pubs/archive/36356.pdf)
| বিভিন্ন | **Kafka** - LinkedIn ৰ পৰা Pub/sub বাৰ্তা কিউ | [slideshare.net](http://www.slideshare.net/mumrah/kafka-talk-tri-hug) |
| বিভিন্ন | **Zookeeper** - কেন্দ্রীভূত অবকাঠামো আৰু সেৱা যি ছিংক্ৰনাইজেচন সক্ষম কৰে | [slideshare.net](http://www.slideshare.net/sauravhaloi/introduction-to-apache-zookeeper) |
| | স্থাপত্য যোগ কৰক | [Contribute](#contributing) |

### কোম্পানী স্থাপত্যসমূহ

| কোম্পানী | উল্লেখ(সমূহ) |
|---|---|
| Amazon | [Amazon স্থাপত্য](http://highscalability.com/amazon-architecture) |
| Cinchcast | [প্ৰতি দিনত ১,৫০০ ঘণ্টা অডিঅ' উৎপাদন](http://highscalability.com/blog/2012/7/16/cinchcast-architecture-producing-1500-hours-of-audio-every-d.html) |
| DataSift | [প্ৰতি ছেকেণ্ডত ১২০,০০০ টুইট ৰিয়েলটাইম ডাটা মাইনিং](http://highscalability.com/blog/2011/11/29/datasift-architecture-realtime-datamining-at-120000-tweets-p.html) |
| Dropbox | [Dropbox কিদৰে স্কেল কৰা হৈছে](https://www.youtube.com/watch?v=PE4gwstWhmc) |
| ESPN | [প্ৰতি ছেকেণ্ডত ১,০০,০০০ duh nuh nuhs চলোৱা](http://highscalability.com/blog/2013/11/4/espns-architecture-at-scale-operating-at-100000-duh-nuh-nuhs.html) |
| Google | [Google স্থাপত্য](http://highscalability.com/google-architecture) |
| Instagram | [১৪ নিযুত ব্যৱহাৰকাৰী, টেৰাবাইট ফটো](http://highscalability.com/blog/2011/12/6/instagram-architecture-14-million-users-terabytes-of-photos.html)<br/>[Instagram কিদৰে চলি থাকে](http://instagram-engineering.tumblr.com/post/13649370142/what-powers-instagram-hundreds-of-instances) |
| Justin.tv | [Justin.tv ৰ লাইভ ভিডিঅ' সম্প্রচাৰ স্থাপত্য](http://highscalability.com/blog/2010/3/16/justintvs-live-video-broadcasting-architecture.html) |
| Facebook | [Facebook ত memcached স্কেলিং](https://cs.uwaterloo.ca/~brecht/courses/854-Emerging-2014/readings/key-value/fb-memcached-nsdi-2013.pdf)<br/>[TAO: Facebook ৰ বিতৰিত ডাটা ষ্ট'ৰ সামাজিক গ্ৰাফৰ বাবে](https://cs.uwaterloo.ca/~brecht/courses/854-Emerging-2014/readings/data-store/tao-facebook-distributed-datastore-atc-2013.pdf)<br/>[Facebook ৰ ফটো সংৰক্ষণ](https://www.usenix.org/legacy/event/osdi10/tech/full_papers/Beaver.pdf)<br/>[Facebook Live কিদৰে ৮০০,০০০ একেলগে দর্শকলৈ Streams কৰে](http://highscalability.com/blog/2016/6/27/how-facebook-live-streams-to-800000-simultaneous-viewers.html) |
| Flickr | [Flickr স্থাপত্য](http://highscalability.com/flickr-architecture) |
| Mailbox | [৬ সপ্তাহত ০ ৰ পৰা ১ নিযুত ব্যৱহাৰকাৰীলৈ স্কেলিং](http://highscalability.com/blog/2013/6/18/scaling-mailbox-from-0-to-one-million-users-in-6-weeks-and-1.html) |
| Netflix | [Netflix ষ্টেকৰ ৩৬০ ডিগ্ৰী দৃশ্য](http://highscalability.com/blog/2015/11/9/a-360-degree-view-of-the-entire-netflix-stack.html)<br/>[Netflix: Play টিপিলে কি হয়?](http://highscalability.com/blog/2017/12/11/netflix-what-happens-when-you-press-play.html) |
| Pinterest | [০ ৰ পৰা প্ৰতি মাহত ১০ বিলিয়ন পৃষ্ঠাৰ দৰ্শনলৈ](http://highscalability.com/blog/2013/4/15/scaling-pinterest-from-0-to-10s-of-billions-of-page-views-a.html)<br/>[১৮ নিযুত দর্শক, ১০x বৃদ্ধি, ১২ কৰ্মচাৰী](http://highscalability.com/blog/2012/5/21/pinterest-architecture-update-18-million-visitors-10x-growth.html) |
| Playfish | [প্ৰতি মাহত ৫০ নিযুত ব্যৱহাৰকাৰী আৰু বৃদ্ধি পাইছে](http://highscalability.com/blog/2010/9/21/playfishs-social-gaming-architecture-50-million-monthly-user.html) |
| PlentyOfFish | [PlentyOfFish স্থাপত্য](http://highscalability.com/plentyoffish-architecture) |
| Salesforce | [তেওঁলোকে দিনে ১.৩ বিলিয়ন লেনদেন কেনেকৈ সজা কৰে](http://highscalability.com/blog/2013/9/23/salesforce-architecture-how-they-handle-13-billion-transacti.html) |
| Stack Overflow | [Stack Overflow স্থাপত্য](http://highscalability.com/blog/2009/8/5/stack-overflow-architecture.html) |
| TripAdvisor | [৪০M দর্শক, ২০০M ডায়নামিক পৃষ্ঠা দৰ্শন, ৩০TB ডাটা](http://highscalability.com/blog/2011/6/27/tripadvisor-architecture-40m-visitors-200m-dynamic-page-view.html) |
| Tumblr | [প্ৰতি মাহত ১৫ বিলিয়ন পৃষ্ঠা দৰ্শন](http://highscalability.com/blog/2012/2/13/tumblr-architecture-15-billion-page-views-a-month-and-harder.html) |
| Twitter | [Twitter ১০০০০ শতাংশ তীব্ৰ কৰা](http://highscalability.com/scaling-twitter-making-twitter-10000-percent-faster)<br/>[Twitter কিদৰে প্ৰতি দিন ২৫০ নিযুত টুইট MySQL ৰে সংৰক্ষণ কৰে](http://highscalability.com/blog/2011/12/19/how-twitter-stores-250-million-tweets-a-day-using-mysql.html)<br/>[১৫০M সক্ৰিয় ব্যৱহাৰকাৰী, ৩০০K QPS, ২২ MB/S firehose](http://highscalability.com/blog/2013/7/8/the-architecture-twitter-uses-to-deal-with-150m-active-users.html)<br/>[স্কেলত টাইমলাইন](https://www.infoq.com/presentations/Twitter-Timeline-Scalability)<br/>[Twitter ত ডাঙৰ আৰু সৰু ডাটা](https://www.youtube.com/watch?v=5cKTP36HVgI)<br/>[Twitter ত অপাৰেশ্যন: ১০০ নিযুত ব্যৱহাৰকাৰীৰ উৰ্ধে স্কেলিং](https://www.youtube.com/watch?v=z8LU0Cj6BOU)<br/>[Twitter কিদৰে প্ৰতি ছেকেণ্ডত ৩,০০০ ছবি সজা কৰে](http://highscalability.com/blog/2016/4/20/how-twitter-handles-3000-images-per-second.html) |
| Uber | [Uber ৰ ৰিয়েলটাইম মাৰ্কেট প্লেটফৰ্ম কিদৰে স্কেল কৰা হয়](http://highscalability.com/blog/2015/9/14/how-uber-scales-their-real-time-market-platform.html)<br/>[Uber ক ২০০০ ইঞ্জিনিয়াৰ, ১০০০ সেৱা, আৰু ৮০০০ Git ৰেপ'জিটৰি লৈ স্কেলিংৰ পাঠ](http://highscalability.com/blog/2016/10/12/lessons-learned-from-scaling-uber-to-2000-engineers-1000-ser.html) |
| WhatsApp | [WhatsApp স্থাপত্য, Facebook এ $১৯ বিলিয়নত ক্ৰয় কৰিছিল](http://highscalability.com/blog/2014/2/26/the-whatsapp-architecture-facebook-bought-for-19-billion.html) |
| YouTube | [YouTube scalability](https://www.youtube.com/watch?v=w5WVu624fY8)<br/>[YouTube স্থাপত্য](http://highscalability.com/youtube-architecture) |

### কোম্পানী ইঞ্জিনিয়াৰিং ব্লগসমূহ

> আপোনি যিসকল কোম্পানীত সাক্ষাৎকাৰ দিব, তাত ব্যৱহৃত স্থাপত্যসমূহ।
>
> আপোনি সন্মুখীন হোৱা প্ৰশ্নবোৰ একে ক্ষেত্ৰৰ পৰা আহিব পাৰে।

* [এয়াৰবিএনবিএ ইঞ্জিনিয়াৰিং](http://nerds.airbnb.com/)
* [এট্লাছিয়ান ডেভেলপাৰ্চ](https://developer.atlassian.com/blog/)
* [এ.ডব্লিউ.এছ. ব্লগ](https://aws.amazon.com/blogs/aws/)
* [বিটলি ইঞ্জিনিয়াৰিং ব্লগ](http://word.bitly.com/)
* [বক্স ব্লগসমূহ](https://blog.box.com/blog/category/engineering)
* [ক্লাউডেৰ ডেভেলপাৰ ব্লগ](http://blog.cloudera.com/)
* [ড্ৰপবক্স টেক ব্লগ](https://tech.dropbox.com/)
* [কোয়ৰাত ইঞ্জিনিয়াৰিং](https://www.quora.com/q/quoraengineering)
* [ইবে টেক ব্লগ](http://www.ebaytechblog.com/)
* [এভাৰনোট টেক ব্লগ](https://blog.evernote.com/tech/)
* [এটচি কোড এজ ক্রাফট](http://codeascraft.com/)
* [ফেচবুক ইঞ্জিনিয়াৰিং](https://www.facebook.com/Engineering)
* [ফ্লিকাৰ কোড](http://code.flickr.net/)
* [ফোৰস্কুৱাৰ ইঞ্জিনিয়াৰিং ব্লগ](http://engineering.foursquare.com/)
* [গিটহাব ইঞ্জিনিয়াৰিং ব্লগ](https://github.blog/category/engineering)
* [গুগল ৰিসাৰ্চ ব্লগ](http://googleresearch.blogspot.com/)
* [গ্ৰুপন ইঞ্জিনিয়াৰিং ব্লগ](https://engineering.groupon.com/)
* [হেৰোকু ইঞ্জিনিয়াৰিং ব্লগ](https://engineering.heroku.com/)
* [হাবস্পট ইঞ্জিনিয়াৰিং ব্লগ](http://product.hubspot.com/blog/topic/engineering)
* [হাই স্কেলেবিলিটি](http://highscalability.com/)
* [ইনষ্টাগ্ৰাম ইঞ্জিনিয়াৰিং](http://instagram-engineering.tumblr.com/)
* [ইনটেল ছফ্টৱেৰ ব্লগ](https://software.intel.com/en-us/blogs/)
* [জেন ষ্ট্ৰিট টেক ব্লগ](https://blogs.janestreet.com/category/ocaml/)
* [লিঙ্কডইন ইঞ্জিনিয়াৰিং](http://engineering.linkedin.com/blog)
* [মাইক্র’চফ্ট ইঞ্জিনিয়াৰিং](https://engineering.microsoft.com/)
* [মাইক্র’চফ্ট পাইথন ইঞ্জিনিয়াৰিং](https://blogs.msdn.microsoft.com/pythonengineering/)
* [নেটফ্লিক্স টেক ব্লগ](http://techblog.netflix.com/)
* [পেপাল ডেভেলপাৰ ব্লগ](https://medium.com/paypal-engineering)
* [পিন্টাৰেষ্ট ইঞ্জিনিয়াৰিং ব্লগ](https://medium.com/@Pinterest_Engineering)
* [ৰেডিট ব্লগ](http://www.redditblog.com/)
* [চেলছফোৰ্স ইঞ্জিনিয়াৰিং ব্লগ](https://developer.salesforce.com/blogs/engineering/)
* [শ্লাক ইঞ্জিনিয়াৰিং ব্লগ](https://slack.engineering/)
* [স্পটিফাই লেবছ](https://labs.spotify.com/)
* [ষ্ট্ৰাইপ ইঞ্জিনিয়াৰিং ব্লগ](https://stripe.com/blog/engineering)
* [Twilio ইঞ্জিনিয়াৰিং ব্লগ](http://www.twilio.com/engineering)
* [Twitter ইঞ্জিনিয়াৰিং](https://blog.twitter.com/engineering/)
* [Uber ইঞ্জিনিয়াৰিং ব্লগ](http://eng.uber.com/)
* [Yahoo ইঞ্জিনিয়াৰিং ব্লগ](http://yahooeng.tumblr.com/)
* [Yelp ইঞ্জিনিয়াৰিং ব্লগ](http://engineeringblog.yelp.com/)
* [Zynga ইঞ্জিনিয়াৰিং ব্লগ](https://www.zynga.com/blogs/engineering)

#### উৎস(সমূহ) আৰু অধিক পঢ়িবলগীয়া

এটা ব্লগ যোগ কৰিবলৈ বিচাৰিছে নেকি?  পুনৰাবৃত্তি হোৱা কাম এৰাই, আপোনাৰ কোম্পানীৰ ব্লগ তলত দিয়া ৰেপ'ত যোগ কৰাৰ কথা ভাবিব পাৰে:

* [kilimchoi/engineering-blogs](https://github.com/kilimchoi/engineering-blogs)

## উন্নয়নৰ অধীন

এটা বিভাগ যোগ কৰিবলৈ অথবা চলি থকা এটা সম্পূৰ্ণ কৰিবলৈ আগ্ৰহী নেকি?  [অংশগ্ৰহণ কৰক](#contributing)!

* MapReduce সৈতে বিতৰিত কম্পিউটিং
* কনছিষ্টেণ্ট হেশিং
* স্কেটাৰ গেদাৰ
* [অংশগ্ৰহণ কৰক](#contributing)

## ক্ৰেডিট

এই ৰেপ'ত ক্ৰেডিট আৰু উৎসসমূহ দিয়া হৈছে।

বিশেষ ধন্যবাদ:

* [Hired in tech](http://www.hiredintech.com/system-design/the-system-design-process/)
* [Cracking the coding interview](https://www.amazon.com/dp/0984782850/)
* [High scalability](http://highscalability.com/)
* [checkcheckzz/system-design-interview](https://github.com/checkcheckzz/system-design-interview)
* [shashank88/system_design](https://github.com/shashank88/system_design)
* [mmcgrana/services-engineering](https://github.com/mmcgrana/services-engineering)
* [System design cheat sheet](https://gist.github.com/vasanthk/485d1c25737e8e72759f)
* [A distributed systems reading list](http://dancres.github.io/Pages/)
* [Cracking the system design interview](http://www.puncsky.com/blog/2016-02-13-crack-the-system-design-interview)

## যোগাযোগৰ তথ্য

যিকোনো সমস্যা, প্ৰশ্ন, বা মন্তব্য আলোচনা কৰিবলৈ মোক যোগাযোগ কৰিবলৈ স্বাধীন অনুভৱ কৰক।

মোৰ যোগাযোগ তথ্য মোৰ [GitHub পৃষ্ঠা](https://github.com/donnemartin)ত পাব।

## লাইচেঞ্চ

*মই এই ৰেপ'জিট'ৰীত থকা ক'ড আৰু উৎসসমূহ আপোনালোকলৈ এখন মুক্ত উৎস লাইচেঞ্চৰ অধীনত প্ৰদান কৰিছোঁ।  এইটো মোৰ ব্যক্তিগত ৰেপ'জিট'ৰি হোৱাৰ বাবে, আপোনালোকক মোৰ ক'ড আৰু উৎসসমূহৰ লাইচেঞ্চ মোৰ পৰা, মোৰ নিয়োগকর্তা (Facebook)ৰ পৰা নহয়।*

    Copyright 2017 Donne Martin

    Creative Commons Attribution 4.0 International License (CC BY 4.0)

    http://creativecommons.org/licenses/by/4.0/


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-09

---