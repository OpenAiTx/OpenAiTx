
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

v1 [Microsoft ৰ Phi 1.5](https://huggingface.co/microsoft/phi-1_5) ৰ ওপৰত নিৰ্মিত

[Hugging Face লিংক](https://huggingface.co/haykgrigorian/TimeCapsuleLLM)


##  মডেল আচৰণ আৰু সীমাবদ্ধতা

### **v0**  

প্ৰাৰম্ভিক প্ৰম্প্টসমূহত মডেলে ১৮০০ দশকৰ ভাষা আৰু আচৰণত প্ৰতিক্ৰিয়া দিছিল।
উদাহৰণ: প্ৰম্প্ট: "Who art Henry?" আৰু ইয়াৰ উত্তৰ আছিল "I know that man, I have did not a black, the storm."

![TimeLockLLM নমুনা আউটপুট](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- আধুনিক ধাৰণাৰ উল্লেখ নাই  
- প্ৰায়কৈ যুগ-উপযুক্ত শব্দভাণ্ডাৰ  
- বাক্যসমূহ প্ৰায় অসংহত (প্ৰায় ~১৮৭MB প্ৰশিক্ষণ ডাটা হিচাপে অনুমানযোগ্য)

### **v0.5** 

v0 ৰ তুলনাত উল্লেখযোগ্য উন্নতি।
- ভিক্টোৰিয়ান লেখন শৈলী, সঠিক যতিচিহ্ন, প্ৰায় ব্যাকৰণসম্মত বাক্য  
- তথ্যানুসন্ধানৰ ভুলৰ হাৰ এতিয়াও অধিক  
- OCR ৰ আওন (যেনে "Digitized by Google") এতিয়াও আউটপুটত উপস্থিত

![TimeLockLLM নমুনা আউটপুট](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

প্ৰথম মডেল যিয়ে ডেটাছেটৰ পৰা এটা বাস্তৱ ঐতিহাসিক ঘটনা আৰু সত্যিকাৰ ব্যক্তি সংযোগ কৰিব পাৰে।

উদাহৰণ: প্ৰম্প্ট: "It was the year of our Lord 1834"

আউটপুট: "It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity"

প্ৰথমতে মই ভাবিছিলোঁ যে এই বছৰটোত কাকতালীয়ভাৱে কোনো প্ৰতিবাদ হৈছিল, কিন্তু এইটো চাওক: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### এইটো কিয় গুৰুত্বপূর্ণ:

এইটো মোৰ মডেলসমূহৰ প্ৰথম উদাহৰণ, য'ত এটা বছৰক বাস্তৱ ঐতিহাসিক ঘটনা আৰু সেই ঘটনাৰ লগত জড়িত বাস্তৱ ব্যক্তিৰ সৈতে সংযোগ কৰিছে (Lord Palmerston)। আগৰ মডেলসমূহ (v0 আৰু v0.5) এ উনবিংশ শতিকাৰ লেখন শৈলী অনুকৰণ কৰিব পাৰিছিল, কিন্তু সদায় ঘটনা, ব্যক্তি আৰু তথ্য কল্পনা কৰিছিল। এইটোৱে দেখুৱাইছে যে মডেলটো ডেটাছেটৰ পৰা তথ্য মনত ৰাখিবলৈ আৰম্ভ কৰিছে

## আগন্তুক পৰিকল্পনা

- ১৮০০-১৮৭৫ চনৰ লণ্ডনত প্ৰকাশিত প্ৰায় ১,৭৫,০০০ টা পাঠ্য ইণ্টাৰনেট আৰ্কাইভত উপলব্ধ
- মই কৰ্পাছটো বিস্তৃত কৰাৰ লগতে আৰু ভাল যুক্তি-ক্ষমতাৰ বাবে অধিক পৰিষ্কাৰ কৰিম বুলি পৰিকল্পনা কৰিছোঁ
- বিৱিধ অঞ্চল আৰু সময়কাললৈ বিস্তৃত কৰি অধিক ঐতিহাসিক মডেল নিৰ্মাণৰ বাবে কাম কৰিব

## কেনেকৈ ব্যৱহাৰ কৰিব

এই প্ৰকল্পই মূলতঃ ঐতিহাসিক ডাটা সংগ্ৰহ, প্ৰস্তুত আৰু টোকেনাইজাৰ নিৰ্মাণত কেন্দ্ৰীভূত। মই সম্পূৰ্ণ LLM প্ৰশিক্ষণ প্ৰক্ৰিয়া কভার নকৰিম, তাৰ বাবে Andrej Karpathy-ৰ nanoGPT চাওক।

### পদক্ষেপ ১: ঐতিহাসিক পাঠ্য সংগ্ৰহ আৰু প্ৰস্তুত কৰক

- আপোনাৰ নিৰ্বাচিত সময়কালৰ (উদাঃ, লণ্ডন ১৮০০-১৮৫০) পাব্লিক ডোমেইন কিতাপ, নথি আদি .txt ফাইল সংগ্ৰহ কৰক
- এইবোৰ আপোনাৰ নিৰ্বাচিত সময়/স্থানৰ ভিতৰতে ৰাখক
- স্ক্ৰিপ্ট ব্যৱহাৰ কৰি বা হাতে-হাতে Project Gutenberg-ৰ হেডাৰ/ফুটাৰ, আধুনিক টীকা বা OCR ভুলবোৰ আঁতৰাই পাঠ্য ফাইলবোৰ পৰিষ্কাৰ কৰক

### পদক্ষেপ ২: নিজস্ব টোকেনাইজাৰ নিৰ্মাণ কৰক

- পৰিষ্কৃত ডাটাত train_tokenizer.py বা train_tokenizer_hf.py চলাওক
- ইয়াৰ দ্বাৰা আপুনি vocab.json আৰু merges.txt পাব
- এই ফাইলবোৰে আপোনাৰ মডেলৰ বাবে শব্দভাণ্ডাৰ আৰু সংযুক্তি নিয়ম সংজ্ঞায়িত কৰে

### পদক্ষেপ ৩: আপোনাৰ মডেলটো প্ৰশিক্ষণ কৰক

- প্ৰশিক্ষণ প্ৰক্ৰিয়া বা নিৰ্বাচিত আৰ্হিৰ ডকুমেণ্টেশ্যনৰ বাবে [Andrej Karpathy-ৰ nanoGPT](https://github.com/karpathy/nanoGPT) চাওক

# FAQ

## Selective Temporal Training (STT) কি?

Selective Temporal Training (STT) হৈছে এটা মেচিন লাৰ্নিং পদ্ধতি য’ত সকলো প্ৰশিক্ষণ ডাটা নিৰ্দিষ্টকৈ নিৰ্দিষ্ট ঐতিহাসিক সময়কালৰ ভিতৰত পৰে বুলি বাচি লোৱা হয়। ইয়াৰ উদ্দেশ্য হৈছে সেই সময়খিনিৰ ভাষা আৰু জ্ঞানক আধুনিক ধাৰণাৰ প্ৰভাৱৰ পৰা মুক্তভাৱে মডেল কৰা। উদাহৰণস্বৰূপ, মোৰ বৰ্তমান মডেল (v0.5) কেৱল ১৮০০-১৮৭৫ চনৰ ডাটাত প্ৰশিক্ষিত, ইয়াক ফাইন-টিউন কৰা হোৱা নাই বরঞ্চ একেবাৰে নতুনকৈ প্ৰশিক্ষণ দিয়া হৈছে, ফলত তাৰ আউটপুটত সেই সময়খিনিৰ ভাষাশৈলী আৰু ঐতিহাসিক পৰিপ্ৰেক্ষিত প্ৰতিফলিত হয়।

## কেৱল ফাইন-টিউনিং বা LoRA ব্যৱহাৰ নকৰাৰ কাৰণ কি?

এই প্ৰকল্পত মই আধুনিক পক্ষপাতৰ পৰা মুক্ত এটা ভাষা মডেল গঢ়ি তুলিবলৈ চেষ্টা কৰিছোঁ। যদি মই GPT-2-ৰ দৰে একো ফাইন-টিউন কৰোঁ, তেতিয়া সেয়া ইতিমধ্যে প্ৰশিক্ষিত আৰু সেই তথ্য আঁতৰাব নোৱাৰি। যদি মই একেবাৰে নতুনকৈ প্ৰশিক্ষণ দিওঁ, ভাষা মডেলটোৱে প্ৰাচীন বুলি অভিনয় নকৰে, ই সঁচাকৈয়ে প্ৰাচীন হ’ব। এই প্ৰকল্পৰ লক্ষ্য বৰ্তমানত হৈছে ১৮০০-১৮৭৫ চনৰ ভিতৰত লণ্ডনত প্ৰকাশিত কিতাপৰ জ্ঞানহে ব্যৱহাৰ কৰি যুক্তি কৰিবলৈ সক্ষম এক মডেল তৈয়াৰ কৰা।

## প্ৰশিক্ষণৰ বাবে কিমান ধৰণৰ ডাটা ব্যৱহাৰ কৰা হৈছিল?


মই 1800–1875 লণ্ডনৰ কিতাপ, আইনগত নথি, বাতৰিকাক, আৰু অন্যান্য লেখাসমূহ ব্যৱহাৰ কৰিছোঁ। মই সংযোগ দিয়া তালিকাখনত (v0 ৰ বাবে) প্ৰায় ২০০ আছে, কিন্তু প্ৰথম প্ৰশিক্ষণৰ বাবে মই কেৱল ৫০টা ফাইল ব্যৱহাৰ কৰিছিলোঁ, প্ৰায় ~১৮৭ এমবিৰ। আপুনি নথিসমূহৰ তালিকা চাব পাৰে:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

ডেটাছেটৰ আকাৰসমূহ:
v0: ~১৮৭MB
v0.5: ~৪৩৫MB 
v1: ~৬.২৫GB 

## মডেলসমূহৰ আকাৰ কিমান ?

V0: ১৬M পেৰামিটাৰ

V0.5 ১২৩M পেৰামিটাৰ

V1: ৭০০M পেৰামিটাৰ

# প্ৰশিক্ষণৰ স্পেচিফিকেচন ? 

# V0/V0.5
GPU: Geforce rtx 4060
CPU: i5-13400F 
ৰেম: ১৬GB DDR5.

# V1
GPU: A100 ভাড়াত লোৱা















---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-30

---