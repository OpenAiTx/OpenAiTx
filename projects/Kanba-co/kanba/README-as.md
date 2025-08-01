<div align="right">
  <details>
    <summary >🌐 ভাষা</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=en">ইংৰাজী</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=zh-CN">সৰল চীনা</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=zh-TW">পৰম্পৰাগত চীনা</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ja">জাপানী</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ko">কোৰিয়ান</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=hi">হিন্দী</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=th">থাই</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=fr">ফ্ৰেঞ্চ</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=de">জার্মান</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=es">স্পেনিছ</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=it">ইটালিয়ান</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ru">ৰাছিয়ান</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=pt">পৰ্তুগীজ</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=nl">ডাচ</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=pl">পোলিশ</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ar">আৰবী</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=fa">ফাৰ্ছি</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=tr">তুৰ্কী</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=vi">ভিয়েতনামী</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=id">ইণ্ডোনেছিয়ান</a>
      </div>
    </div>
  </details>
</div>

<div align="center">
  <br />
<br />
<a href="https://kanba.co">
  <img alt="Kanba" src="https://www.kanba.co/dark-hero.png" style=" width: 800px " />
</a>
    <br />
<br />
</div>

<div align="center">
  <br />
<br />
<a href="https://vercel.com/oss">
  <img alt="Vercel OSS Program" src="https://vercel.com/oss/program-badge.svg" />
</a>
    <br />
<br />
</div>
# মেকাৰ আৰু ইণ্ডি হেকাৰসকলৰ বাবে ডিজাইন কৰা ওপেন-ছ’র্স, হালধীয়া Trello বিকল্প।

সৰলতা, দ্ৰুততা আৰু স্কেলেবিলিটিত গুৰুত্ব।
আধুনিক stack: Tailwind CSS, shadcn/ui, Supabase, Stripe integrationৰে নিৰ্মিত।
অসীম সংখ্যক প্ৰকল্প, দলেৰে সহযোগিতা, ডাৰ্ক/লাইট ম'ড, আৰু ন্যায্য ব্যৱহাৰকাৰী অভিজ্ঞতা সমৰ্থন কৰে।
সম্পূৰ্ণ নিয়ন্ত্ৰণ বিচৰা একক ডেভেলপাৰ আৰু সৰু দলেৰ বাবে উপযুক্ত, অপ্রয়োজনীয় জটিলতা নোহোৱা।

## 🌟 যদি আপুনি এই প্ৰকল্পটো উপযোগী বুলি ভাবেনে, অনুগ্ৰহ কৰি এটাৰ ষ্টাৰ দিয়ক! ই আনকো ইয়াক বিচাৰি পাবলৈ সহায় কৰে।

# ডিপ্লয়মেন্ট গাইড

## সংক্ষিপ্ত বিবৰণ
এই এপ্লিকেশ্বনটোৱে এতিয়া Stripe একত্ৰিকৰণৰ বাবে Supabase Edge Functionsৰ পৰিৱৰ্তে স্থানীয় Next.js API ৰুট ব্যৱহাৰ কৰে। ইয়াৰ ফলত ডিপ্লয়মেন্ট সহজ হয় আৰু আপুনি কনফিগাৰেচনৰ বাবে .env ফাইল ব্যৱহাৰ কৰিব পাৰে।

## পৰিবেশ ভেৰিয়েব্‌ল ছেটআপ

### ১. .env.local ফাইল সৃষ্টি কৰক
`.env.example` কপি কৰি `.env.local` বনাওক আৰু আপোনাৰ প্ৰকৃত মানসমূহ ভৰ্তি কৰক:


```bash
cp .env.example .env.local
```

### 2. প্ৰয়োজনীয় পৰিবেশ চলকসমূহ

#### Supabase সংৰূপণ
- `NEXT_PUBLIC_SUPABASE_URL` - আপোনাৰ Supabase প্ৰকল্পৰ URL
- `NEXT_PUBLIC_SUPABASE_ANON_KEY` - আপোনাৰ Supabase অজ্ঞাত চাবি
- `SUPABASE_SERVICE_ROLE_KEY` - আপোনাৰ Supabase সেৱা ভূমিকা চাবি (কেৱল ছাৰ্ভাৰ-ফালে)

#### Stripe সংৰূপণ (ঐচ্ছিক)
- `STRIPE_SECRET_KEY` - আপোনাৰ Stripe গোপন চাবি (কেৱল ছাৰ্ভাৰ-ফালে)
- `NEXT_PUBLIC_STRIPE_PUBLISHABLE_KEY` - আপোনাৰ Stripe প্ৰকাশযোগ্য চাবি
- `STRIPE_WEBHOOK_SECRET` - আপোনাৰ Stripe webhook গোপন চাবি

#### ছাইট সংৰূপণ
- `NEXT_PUBLIC_SITE_URL` - আপোনাৰ ছাইটৰ URL (প্ৰডাকচনৰ বাবে)
- `NEXTAUTH_URL` - আপোনাৰ ছাইটৰ URL (ওপৰৰ দৰে)
- `NEXTAUTH_SECRET` - NextAuth-ৰ বাবে এটা যাদুৰী গোপন চাবি

## স্থানীয় উন্নয়ন

1. নিৰ্ভরতাসমূহ ইনষ্টল কৰক:
```bash
npm install
```

2. আপোনাৰ পৰিবেশ ভেৰিয়েবলসমূহ `.env.local` ত ছেট কৰক

3. ডেভেলপমেণ্ট ছাৰ্ভাৰটো চলাও:
```bash
npm run dev
```

৪. Stripe CLI ব্যৱহাৰ কৰি স্থানীয়ভাৱে Stripe webhook সমূহ পৰীক্ষা কৰক:
```bash
stripe listen --forward-to localhost:3000/api/stripe/webhook
```

## প্ৰডাকশ্যন ডিপ্লয়মেণ্ট


### Vercel ডিপ্লয়মেণ্ট

1. **Vercel-ত ডিপ্লয় কৰক:**
```bash
npx vercel
```

2. **পৰিবেশ পৰিবৰ্তনশীলসমূহ:**
   সকলো পৰিবেশ পৰিবৰ্তনশীল Vercel ডেশবোর্ড বা CLI ৰ জৰিয়তে যোগ কৰক

3. **Stripe Webhook ছেটআপ:**
   - Webhook টি এই ঠিকনাত নিৰ্দেশ কৰক: `https://your-domain.vercel.app/api/stripe/webhook`

## API শেষবিন্দুসমূহ

এপ্লিকেছনটোৱে এতিয়া এই স্থানীয় API ৰুটসমূহ ব্যৱহাৰ কৰে:

- `POST /api/stripe/checkout` - Stripe চেকআউট ছেছন সৃষ্টি কৰে
- `POST /api/stripe/webhook` - Stripe webhook ইভেন্টসমূহ হেণ্ডল কৰে

## স্থানীয় API ৰুটৰ সুবিধাসমূহ

1. **সহজ ডিপ্লয়মেণ্ট** - পৃথক এজ ফাংক্সন ডিপ্লয় কৰাৰ প্ৰয়োজন নাই
2. **পৰিবেশ পৰিবৰ্তনশীলসমূহ** - মানক .env ফাইল সমৰ্থন
3. **উত্তম ডিবাগিং** - স্থানীয়ভাৱে ডিবাগ কৰা সহজ
4. **ফ্ৰেমৱৰ্ক ইন্টেগ্ৰেচন** - Next.js ৰ সৈতে উত্তম সংযুক্তি
5. **বিক্ৰেতা-নির্ভরতাহীনতা** - Next.js সমৰ্থিত যিকোনো প্লেটফৰ্মত ডিপ্লয় কৰিব পৰা যায়

## সমস্যাৰ সমাধান

1. **Webhook সমস্যা:**
   - `STRIPE_WEBHOOK_SECRET` আপোনাৰ Stripe webhook endpoint ৰ সৈতে মিল আছে নেকি নিশ্চিত কৰক
   - Stripe ডেশবোর্ডত webhook লগ চাওক
   - Webhook URL সঠিক নেকি নিশ্চিত কৰক

2. **পৰিবেশ পৰিবৰ্তনশীলসমূহ:**
   - সকলো প্ৰয়োজনীয় ভেৰিয়েবল ছেট আছে নে নিশ্চিত কৰক
   - ভেৰিয়েবুলৰ নামত বানান ভুল আছে নে চাওক
   - Supabase ছাৰ্ভিচ ৰ’ল কী-টোৰ যথাযথ অনুমতি আছে নে নিশ্চিত কৰক

3. **CORS সমস্যা:**
   - API ৰুটসমূহত উপযুক্ত CORS হেডাৰ আছে
   - প্ৰয়োজন হলে আপোনাৰ ডোমেইন হোৱাইটলিষ্টেড আছে নে নিশ্চিত কৰক

## সুৰক্ষা টোকা

- `STRIPE_SECRET_KEY` বা `SUPABASE_SERVICE_ROLE_KEY` কেতিয়াও ক্লায়েন্টলৈ প্ৰকাশ নকৰিব
- কেৱল ক্লায়েন্ট-চাইড ভেৰিয়েবুলৰ বাবে `NEXT_PUBLIC_` প্ৰিফিক্স ব্যৱহাৰ কৰক
- নিয়মিতভাৱে আপোনাৰ webhook গোপনীয়তা পৰিবৰ্তন কৰক
- Stripe ডেশবোর্ডত webhook ডেলিভাৰী মনিটৰ কৰক


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-01

---