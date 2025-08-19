
<div align="right">
  <details>
    <summary >🌐 ভাষা</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=en">ইংৰাজী</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN">সৰল চীনী</a>
        | <a href="#" title="Coming soon">পৰম্পৰাগত চীনী (শীঘ্ৰে আহিব)</a> |
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja">জাপানী</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko">কোৰিয়ান</a>
        | <a href="#" title="Coming soon">হিন্দী (শীঘ্ৰে আহিব)</a> |
        | <a href="#" title="Coming soon">থাই (শীঘ্ৰে আহিব)</a> |
        | <a href="#" title="Coming soon">ফৰাছী (শীঘ্ৰে আহিব)</a>
        | <a href="#" title="Coming soon">জাৰ্মান (শীঘ্ৰে আহিব)</a>
        | <a href="#" title="Coming soon">স্পেনীয় (শীঘ্ৰে আহিব)</a>
        | <a href="#" title="Coming soon">ইটালিয়ান (শীঘ্ৰে আহিব)</a>
        | <a href="#" title="Coming soon">ৰাছিয়ান (শীঘ্ৰে আহিব)</a>
        | <a href="#" title="Coming soon">পৰ্তুগীজ (শীঘ্ৰে আহিব)</a>
        | <a href="#" title="Coming soon">ডাচ (শীঘ্ৰে আহিব)</a>
        | <a href="#" title="Coming soon">পোলিশ (শীঘ্ৰে আহিব)</a>
        | <a href="#" title="Coming soon">আৰবী (শীঘ্ৰে আহিব)</a>
        | <a href="#" title="Coming soon">ফাৰ্সি (শীঘ্ৰে আহিব)</a>
        | <a href="#" title="Coming soon">তুৰ্কী (শীঘ্ৰে আহিব)</a>
        | <a href="#" title="Coming soon">ভিয়েতনামী (শীঘ্ৰে আহিব)</a>
        | <a href="#" title="Coming soon">ইনডোনেছিয়ান (শীঘ্ৰে আহিব)</a>

      </div>
    </div>
  </details>
</div>

# টাইমকেপছুল LLM

*এখন ভাষা মডেল যি **শূন্যৰ পৰা** কেৱল নিৰ্দিষ্ট স্থান আৰু সময়ৰ তথ্যত অভ্যাস কৰোৱা হৈছে, আধুনিক পক্ষপাত কমাবলৈ আৰু সেই যুগৰ স্বৰ, শব্দভঁৰাল, আৰু দৃষ্টিভংগী অনুকৰণ কৰিবলৈ।*

ভাবক, যদি এটা AI মডেল কেৱল ইতিহাসৰ অভিনয় নকৰিল, বাস্তৱতে ইতিহাসৰ আছিল।

v0 আৰু v0.5 [nanoGPT by Andrej Karpathy](https://github.com/karpathy/nanoGPT) ৰ ওপৰত নিৰ্মিত। মূল অভ্যাস স্ক্ৰিপ্ট আৰু মডেল স্থাপত্য তেওঁৰ কাম। 

v1 [Phi 1.5 by Microsoft](https://huggingface.co/microsoft/phi-1_5)ত নিৰ্মিত


##  মডেলৰ আচৰণ আৰু সীমাবদ্ধতা

### **v0**  

প্ৰাথমিক প্ৰম্প্টসমূহত মডেলটোৱে ১৮০০ দশকৰ ভাষা আৰু আচৰণৰে প্ৰতিক্ৰিয়া দেখুৱাইছে। 
উদাহৰণ: প্ৰম্প্ট: "Who art Henry?" আৰু ইয়াৰ উত্তৰ আছিল "I know that man, I have did not a black, the storm." 

![TimeLockLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- আধুনিক ধাৰণাৰ উল্লেখ নাই  
- প্ৰায় সময়তে যুগ-উপযুক্ত শব্দৰ ব্যৱহাৰ  
- বাক্যবোৰ অধিকাংশ সময়তে অসংলগ্ন (প্ৰায় ১৮৭MB প্ৰশিক্ষণ তথ্যৰ বাবে আশা কৰা হৈছিল)

### **v0.5** 

v0-ৰ তুলনাত উল্লেখযোগ্য উন্নতি।  
- ভিক্টোৰিয়ান লেখনীৰ শৈলী, সঠিক যত্নচিহ্ন, প্ৰায় সময়তে ব্যাকৰণগত বাক্য  
- তথ্যমূলক বিভ্ৰান্তিৰ হাৰ এতিয়াও উচ্চ  
- OCR-ৰ শব্দৰ বিঘ্ন (“Digitized by Google”) এতিয়াও আউটপুটত উপস্থিত

![TimeLockLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

প্ৰথম মডেল যি কোনো ঐতিহাসিক ঘটনাৰ লগত ডেটাসেটৰ প্রকৃত ব্যক্তিক সংযোগ কৰিব পাৰিছে।

উদাহৰণ: প্ৰম্প্ট: "It was the year of our Lord 1834" 

আউটপুট: "It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity" 

প্ৰথমতে মই ভাবিছিলোঁ কোনো প্ৰতিবাদ সেই বছৰত আকস্মিকভাৱে ঘটিছিল, কিন্তু ইয়াত চাওক: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### ইয়াৰ গুৰুত্ব

এইটো মোৰ মডেলবোৰৰ প্ৰথম উদাহৰণ য’ত এটা বছৰক বাস্তৱ ঐতিহাসিক ঘটনা আৰু সেই ঘটনাৰ সৈতে জড়িত বাস্তৱ ব্যক্তিৰ সৈতে সংযোগ কৰিছে (Lord Palmerston)। আগৰ মডেল (v0 আৰু v0.5) ১৯শ শতিকাৰ লেখনীৰ শৈলী অনুকৰণ কৰিব পাৰিছিল কিন্তু সদায় ঘটনা, ব্যক্তি আৰু তথ্য বিভ্ৰান্ত কৰিছিল। এইটো দেখুৱায় মডেলটো ডেটাসেটৰ পৰা বস্তু মনত ৰাখিবলৈ আৰম্ভ কৰিছে

## আগন্তুক পৰিকল্পনা 
- লণ্ডনত ১৮০০-১৮৭৫ সময়ছোৱাত প্ৰায় ১,৭৫০০০ টা পাঠ্য ইণ্টাৰনেট আৰ্কাইভত প্ৰকাশিত হৈছে
- মই কোৰ্পাছটো বৃদ্ধি কৰি আৰু ভাল যুক্তি ক্ষমতাৰ বাবে অধিক পৰিষ্কাৰ কৰাৰ পৰিকল্পনা কৰিছোঁ
- বিভিন্ন অঞ্চল আৰু সময়চোৱাত বিস্তাৰিত কৰি অধিক ঐতিহাসিক মডেলৰ বাবে


## কেনেকৈ ব্যৱহাৰ কৰিব

এই প্ৰকল্পটো প্ৰধানকৈ ঐতিহাসিক তথ্য সংগ্ৰহ, প্ৰশিক্ষণৰ বাবে প্রস্তুতকৰণ আৰু টোকেনাইজাৰ নিৰ্মাণত কেন্দ্ৰিত। মই সম্পূৰ্ণ LLM প্ৰশিক্ষণ প্ৰক্ৰিয়া আলোচনা নকৰোঁ, তাৰ বাবে Andrej Karpathyৰ nanoGPT চাওক।

### পদক্ষেপ ১: ঐতিহাসিক পাঠ্য সংগ্ৰহ আৰু প্রস্তুতকৰণ 

- আপোনাৰ নিৰ্বাচিত সময়চোৱা (উদাহৰণঃ লণ্ডন ১৮০০-১৮৫০) ৰ পৰা পাব্লিক ডোমেইনৰ কিতাপ, নথি আদি .txt ফাইল সংগ্ৰহ কৰক 
- সেইবোৰ আপোনাৰ নিৰ্বাচিত সময়/স্থানৰ ভিতৰত ৰাখক  
- পাঠ্য ফাইলসমূহ স্ক্ৰিপ্টেৰে বা হাতেদিয়ে পৰিষ্কাৰ কৰক, প্ৰজেক্ট গুটেনবাৰ্গৰ হেডাৰ/ফুটাৰ, আধুনিক টীকা বা OCR ত্ৰুটি আঁতৰাওক।

### পদক্ষেপ ২: কাষ্টম টোকেনাইজাৰ নিৰ্মাণ কৰক

- পৰিষ্কাৰ কৰা ডেটাত train_tokenizer.py বা train_tokenizer_hf.py চলাওক।
- ইয়াৰ পৰা আপোনাৰ vocab.json আৰু merges.txt পাব
- এই ফাইলবোৰে আপোনাৰ মডেলৰ বাবে শব্দসম্ভাৰ আৰু সংযুক্তি নিয়ম সংজ্ঞায়িত কৰে

### পদক্ষেপ ৩: আপোনাৰ মডেল প্ৰশিক্ষণ কৰক 

- প্ৰশিক্ষণ প্ৰক্ৰিয়া বা নিৰ্বাচিত স্থাপত্যৰ ডকুমেন্টেশ্যনৰ বাবে [nanoGPT by Andrej Karpathy](https://github.com/karpathy/nanoGPT) চাওক।

# FAQ

## Selective Temporal Training কি ?

Selective Temporal Training (STT) হৈছে এটা মেচিন লাৰ্নিং পদ্ধতি য'ত সকলো প্ৰশিক্ষণৰ তথ্য নিৰ্দিষ্ট ঐতিহাসিক সময়চোৱাৰ ভিতৰত সাজি লোৱা হয়। ইয়াৰ উদ্দেশ্য সেই যুগৰ ভাষা আৰু জ্ঞানক আধুনিক ধাৰণাৰ প্ৰভাৱৰ পৰা মুক্ত কৰি মডেল কৰা। উদাহৰণস্বৰূপ, বৰ্তমান মোৰ যি মডেল আছে (v0.5) তাত কেৱল ১৮০০-১৮৭৫ সময়চোৱাৰ তথ্য ব্যৱহৃত হৈছে, ফাইন টিউন কৰা নহয়, সম্পূৰ্ণ নতুনকৈ প্ৰশিক্ষণ দিয়া হৈছে, ফলস্বৰূপ সেই সময়চোৱাৰ ভাষা আৰু ঐতিহাসিক পৰিপ্ৰেক্ষিত প্ৰতিফলিত হয়।

## Fine-tuning বা LoRA ব্যৱহাৰ নকৰাৰ কাৰণ কি?

এই প্ৰকল্পত মই আধুনিক পক্ষপাতৰ পৰা মুক্ত ভাষা মডেল গঢ়িবলৈ চেষ্টা কৰিছোঁ। যদি মই GPT-2 যেনেকুৱা কিছুমান ফাইন-টিউন কৰোঁ, সেইটো ইতিমধ্যে প্ৰি-ট্ৰেইন কৰা, সেই তথ্য আঁতৰিব নোৱাৰে। যদি মই সম্পূৰ্ণ নতুনকৈ প্ৰশিক্ষণ দিওঁ, ভাষা মডেলটোৱে পুৰণি বুলি অভিনয় নকৰে, সেইটো নিজেই পুৰণি হৈ থাকিব। এই প্ৰকল্পৰ লক্ষ্য হৈছে ১৮০০-১৮৭৫ সময়চোৱাৰ লণ্ডনৰ কিতাপৰ জ্ঞানহে ব্যৱহাৰ কৰি যুক্তি কৰিব পৰা মডেল নিৰ্মাণ।

## প্ৰশিক্ষণৰ বাবে কিমান ধৰণৰ তথ্য ব্যৱহাৰ কৰা হৈছে?

মই কিতাপ, আইনগত নথি, সংবাদপত্র আৰু ১৮০০–১৮৭৫ লণ্ডনৰ অন্যান্য লেখনি ব্যৱহাৰ কৰিছোঁ। মই সংলগ্ন তালিকাত (v0) প্ৰায় ২০০ টা আছে, কিন্তু প্ৰথম প্ৰশিক্ষণৰ বাবে কেৱল ৫০ টা ফাইল, প্ৰায় ~১৮৭ MB ব্যৱহাৰ কৰিছোঁ। আপোনি নথিৰ তালিকা চাব পাৰে:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt


ডেটাসেটৰ আকাৰসমূহ:
v0: ~১৮৭MB
v0.5: ~৪৩৫MB
v1: ~৬.২৫GB

## মডেলসমূহৰ আকাৰ কিমান?

V0: ১৬M পৰামিত্ৰ

V0.5 ১২৩M পৰামিত্ৰ

V1: ৭০০M পৰামিত্ৰ

# প্ৰশিক্ষণ স্পেক্স?

# V0/V0.5
GPU: Geforce rtx 4060
CPU: i5-13400F
ৰেম: ১৬GB DDR5.

# V1
GPU: A100 ভাড়া কৰা














---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-19

---