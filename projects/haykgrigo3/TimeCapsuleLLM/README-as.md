<div align="right">
  <details>
<summary>🌐 ভাষা</summary>

[English](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=en) | [简体中文](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN) | [繁體中文](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-TW) | [日本語](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja) | [한국어](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko) | [हिन्दी](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=hi) | [ไทย](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=th) | [Français](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fr) | [Deutsch](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=de) | [Español](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=es) | [Italiano](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=it) | [Русский](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ru) | [Português](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pt) | [Nederlands](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=nl) | [Polski](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pl) | [العربية](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ar) | [فارسی](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fa) | [Türkçe](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=tr) | [Tiếng Việt](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=vi) | [Bahasa Indonesia](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=id) | [অসমীয়া](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=as)
</details>
</div>


# TimeCapsule LLM

*এখন ভাষা ম'ডেল যি **শূন্যৰ পৰা** কেৱল নিৰ্দিষ্ট স্থান আৰু সময়ৰ তথ্যত আধাৰিত হৈ প্ৰশিক্ষিত কৰা হৈছে যাতে আধুনিক পক্ষপাত কমোৱা যায় আৰু সেই যুগৰ ভাষা, শব্দভঁৰালি আৰু দৃষ্টিভংগীক অনুকৰণ কৰিব পাৰে।*

কল্পনা কৰক যদি এটা AI ম'ডেলে কেৱল ঐতিহাসিক বুলি অভিনয় নকৰে, সেয়া বাস্তৱতে আছিল।

v0 আৰু v0.5 [Andrej Karpathy ৰ nanoGPT](https://github.com/karpathy/nanoGPT) ত নিৰ্মিত। মূল প্ৰশিক্ষণ স্ক্ৰিপ্ট আৰু ম'ডেলৰ স্থাপত্য তেওঁৰ কাম। 

v1 [Microsoft ৰ Phi 1.5](https://huggingface.co/microsoft/phi-1_5) ত নিৰ্মিত

v2 llamaforcausallm ত নিৰ্মিত

[হাগিং ফেচ লিংক](https://huggingface.co/collections/haykgrigorian/timecapsulellm-1800-1875-london)

## গৱেষণা স্থিতি
এই প্ৰকল্পটো স্বাধীনভাৱে আৰম্ভ আৰু উন্নয়ন কৰা হৈছে।

বৰ্তমানে এইটো একাডেমিক পৰ্যবেক্ষণত চলি আছে, Muhlenberg College ত সংলগ্ন গৱেষণা সহযোগিতাৰে।

## উদ্ধৃতি

আপুনি যদি এই ডেটাছেট বা ম'ডেলটো একাডেমিক কামত ব্যৱহাৰ কৰে, অনুগ্ৰহ কৰি উদ্ধৃতি দিয়ক:


```bibtex
@misc{london_llm_1800,
  author = {Grigorian, Hayk and Yaghoobian, Hamed},
  title = {Historic London English (1800–1875)},
  year = {2025},
  publisher = {Hugging Face},
  howpublished = {\url{https://huggingface.co/datasets/postgrammar/london-llm-1800}}
}
```

##  মডেলৰ আচৰণ আৰু সীমাবদ্ধতা

### **v0**  

প্ৰাথমিক প্ৰম্প্টসমূহত মডেলে ১৮০০ চনৰ ভাষা আৰু আচৰণত প্ৰতিক্ৰিয়া দেখুৱাইছে।
উদাহৰণ: প্ৰম্প্ট: "Who art Henry?" আৰু ইয়াৰ উত্তৰ আছিল "I know that man, I have did not a black, the storm."

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- আধুনিক ধাৰণাৰ উল্লেখ নাই  
- বেছিভাগ সময় শৈলীবদ্ধ যুগ-উপযোগী শব্দভাণ্ডাৰ  
- বাক্যসমূহ অধিকাংশ ক্ষেত্ৰত অসংলগ্ন (প্ৰায় ১৮৭MB ট্ৰেইনিং ডাটাৰ বাবে আশা কৰা হৈছিল)

### **v0.5** 

v0-ৰ তুলনাত উল্লেখযোগ্য উন্নতি।
- ভিক্টোৰীয় লেখা শৈলী, সঠিক যতি-চিহ্ন, বেছিভাগে ব্যাকৰণগত বাক্য  
- তথ্যমূলক ভুল দেখুওৱা হার এতিয়াও অধিক  
- OCR ৰ শব্দ-বিকৃতি (“Digitized by Google”) এতিয়াও আউটপুটত বিদ্যমান

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

ডেটাসেটৰ পৰা বাস্তৱ ঐতিহাসিক ঘটনা আৰু বাস্তৱ ব্যক্তি-সম্পৰ্কিত তথ্য উলিওৱা প্ৰথম মডেল।

উদাহৰণ: প্ৰম্প্ট: "It was the year of our Lord 1834" 

উত্তৰ: "It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity" 

প্ৰথমতে মই ভৱিছিলো ১৮৩৪ চনত কোৱা প্ৰতিবাদটো ক্ৰমে সংঘটিত হৈছিল, কিন্তু এইটো চাওক: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### **v2mini-eval1**

v2-ৰ ৯০GB ডাটাছেটৰ পৰা ১৫GB নমুনা ব্যৱহাৰ কৰি প্ৰশিক্ষণ দিয়া হৈছে।
মডেল কেৱল ১০,০০০ ষ্টেপলৈ প্ৰশিক্ষিত।

টোকেনাইজেশ্যন ত্ৰুটির বাবে আউটপুট এইদৰে দেখুওৱা হৈছে:

চাৰ্লছ ডিকেন্স কোন?



W ho is Charles D ic ens ? D oes that work more of h ise x cell ent st ir ring , in his pl ays , int he G reat C omp any 's f arm ? What I have y et to qu ote from J ack P ick ett ? D oy oun ot know th att hey were as pe cies of g all oping , ors aw ing oft heir bre asts , or what w ast ob ed one about the t im ew hen J acks on was looking ont hew ind ow ? What ist hes uccess of an English man , and which h isson has not be end is cover ing t ome , where by to acc omp lish such a we ight ? D idy ou ever m ake ap ass age int othe old road way , ort o an anch or - b ree ze att he foot of our boat , which you m ust le ave us ? The fact is , that whe ther the wind would rise up from the pl ain on S atur day night orn o ont ide , ort ill then orth , or other wise , wes hall be com pelled t od esc ribe af orm idable bar rier , with t hes ame e ffect s ast he p resent . In th iss itu ation , at le ast , itis not to omuch t os ay that we have le ft that room . I bel ieve there are three c op ies int he " F ive H undred - fold ," to bere fer red to , ast he first n umber of our read ers wh ow is ht
শুদ্ধ কৰা হৈছে:

"চাৰ্লছ ডিকেন্স কোন? তেওঁৰ উৎকৃষ্ট উত্সাহজনক কৰ্মবোৰ, তেওঁৰ নাটকসমূহত, দ্য গ্ৰেট কোম্পানীৰ খেতিত অধিক কাৰ্য আছে নেকি? মই এতিয়াও জেক পিকেটৰ পৰা কি উদ্ধৃত কৰিব লাগিব? আপুনি নাজানে নেকি যে সিহঁত এবিধ দৌৰি ফুৰা, বা বুকু চিৰি ফেলা জাতি আছিল, বা জেক্সনে খিৰিকীত চাই থকা সময়ত কি কৰা উচিত আছিল? এজন ইংৰাজৰ সফলতা কি, আৰু তেওঁৰ পুত্ৰই মোক এতিয়ালৈকে কি আৱিষ্কাৰ কৰা নাই, যাৰ দ্বাৰা এনে এখন গুৰুত্বপূৰ্ণ কাম সম্পাদন কৰিব পাৰি? আপুনি কেতিয়াবা পুৰণি ৰাস্তােদি পাৰ হৈ গৈছিলেনে, বা আমাৰ নাওখনৰ পাৰত এখন নোঙৰ-বতাহ পাইছিলেনে, যিখন আপোনালোকে এৰি যাব লাগিব? কথাটো হ'ল, বতাহখন শনিবাৰৰ ৰাতি বা দুপৰীয়া, বা উত্তৰফালে উঠিব নে উঠিব, বা আন কোনো সময়ত, আমি এটা ডাঙৰ বাধা বৰ্ণনা কৰিবলৈ বাধ্য হ'ম, বৰ্তমান পৰিস্থিতিৰ দৰে। এই অৱস্থাত, কমেও কৈব পৰা যায় যে আমি সেই কোঠাটো এৰি গৈছো। মই বিশ্বাস কৰোঁ যে 'ফাইভ হাণ্ড্ৰেড-ফোল্ড'ত তিনি প্ৰতিলিপি আছে, যাক উল্লেখ কৰিব পাৰি, যি আমাৰ পাঠকসকলৰ প্ৰথম সংখ্যাৰ বাবে...”

### **v2mini-eval2**

একেই ১৫ জিবি নমুনা ব্যৱহাৰ কৰি প্ৰশিক্ষিত, যি eval1-ৰ বাবে ব্যৱহাৰ হৈছিল।
মডেলটো আকৌ কেৱল ১০ হাজাৰ ষ্টেপলৈকে প্ৰশিক্ষণ দিয়া হৈছে।

প্ৰম্প্ট:চাৰ্লছ ডাৰৱিন

চাৰ্লছ ডাৰৱিনECCEMACY। ছাৰ, — তলত দিয়া ঘটনাটো মোৰ বাবে ৰোমাঞ্চকৰ: — মই লণ্ডনত এটা সপ্তাহ আছিলোঁ, আৰু গাঁঠিৰ বিষৰ আক্ৰমণত যথেষ্ট কষ্ট পাইছিলোঁ। প্ৰথম গাঁঠিৰ আক্ৰমণটো মই আপোনাক দেখাৰ এক সপ্তাহ আগতেই হৈছিল, আৰু দ্বিতীয়টো আপোনাক দেখাৰ সময়ত, আৰু তৃতীয়টো আক্ৰমণো সেই সময়ত হৈছিল। যদিও দ্বিতীয় গাঁঠিৰ আক্ৰমণৰ লগত কোনো জ্বৰজনিত লক্ষণ নাছিল, কিন্তু প্ৰস্ৰাৱৰ পৰিমাণ বৃদ্ধি পোৱা আৰু অধিক প্ৰস্ৰাৱ নিগৰাৰ লগত আছিল। তৃতীয় আক্ৰমণটো মই আপোনাক দেখাৰ এটা ঘণ্টা পাছত হৈছিল, আৰু তাৰ পাছত পুনৰ গাঁঠিৰ পীড়া আৰু অধিক তীব্ৰ আক্ৰমণ হৈছিল। চতুৰ্থ আক্ৰমণটোও জ্বৰ লৈ আছিল, কিন্তু সদায় জ্বৰজনিত লক্ষণ নাছিল। তৃতীয় গাঁঠিৰ আক্ৰমণটো আপুনি অসুস্থ হোৱা এহপ্তা পিছত হৈছিল, আৰু চতুৰ্থটো আক্ৰমণৰ পাছত গাঁঠিৰ পীড়া হৈছিল। চতুৰ্থ আক্ৰমণটো আপুনি আক্ৰমণৰ এটা সপ্তাহ পিছত হৈছিল, আৰু লগত এটা অনুভূতি আছিল

### **v2**

৯০ জিবি (১১২ জিবি টোকেনাইজড) ডেটাছেট ব্যৱহাৰ কৰি প্ৰশিক্ষিত
১,৮২,০০০ ষ্টেপলৈকে প্ৰশিক্ষিত

![TimeCapsuleLLM নমুনা আউটপুট](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output1.png)

![TimeCapsuleLLM নমুনা আউটপুট](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output2.png)

##  ডেটাছেটসমূহ

### **v2**

- ১৮০০-১৮৭৫ লণ্ডন পাঠ্যৰ ৯০ জিবি (কাঁচা)
- ১,৩৬,৩৪৪টা নথি
- সম্পূৰ্ণ টোকেনাইজড ডেটাছেট ইয়াত উপলব্ধ: https://huggingface.co/datasets/postgrammar/london-llm-1800

 ### পক্ষপাতি পৰিসংখ্যা
  ![সৰ্বনাম পক্ষপাতি](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/pronoun_bias.png)

  ![ভৌগোলিক পক্ষপাতি](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/geographic_bias.png)

  ![ক্ৰমগত পক্ষপাতি](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/temporal_bias.png)

অধিক তথ্যৰ বাবে [v2 পক্ষপাতি প্ৰতিবেদন](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/v2_bias_report.json) চাওক।



## ব্যৱহাৰৰ নিয়ম

এই প্ৰকল্পটো প্ৰধানকৈ ঐতিহাসিক তথ্য সংগ্ৰহ, সেইবোৰ প্ৰশিক্ষণৰ বাবে সাজু কৰা আৰু এখন ট'কেনাইজাৰ নিৰ্মাণ কৰাৰ ওপৰত কেন্দ্ৰিত। মই সম্পূৰ্ণ LLM প্ৰশিক্ষণ প্ৰক্ৰিয়া আলোচনা নকৰোঁ, তাৰ বাবে Andrej Karpathy ৰ nanoGPT চাওক।

### পদক্ষেপ ১: ঐতিহাসিক পাঠ্য সংগ্ৰহ আৰু প্ৰস্তুত কৰক

- আপোনাৰ নিৰ্বাচিত সময়কালৰ (যেনে, লণ্ডন ১৮০০-১৮৫০) ৰাজহুৱা ডোমেইনৰ কিতাপ, নথি আদিৰ .txt ফাইল সংগ্ৰহ কৰক
- সেইবোৰ আপোনাৰ নিৰ্বাচিত সময়/স্থানৰ ভিতৰত ৰাখক  
- স্ক্ৰিপ্ট ব্যৱহাৰ কৰি বা নিজে পৰিষ্কাৰ কৰি Project Gutenberg, আধুনিক মন্তব্য বা OCR ত্ৰুটিৰ দৰে হেডাৰ/ফুটাৰ আঁতৰাই পাঠ্য ফাইলসমূহ পৰিষ্কাৰ কৰক।

### পদক্ষেপ ২: কাষ্টম ট'কেনাইজাৰ নিৰ্মাণ কৰক

- পৰিষ্কৃত ডাটাত train_tokenizer.py বা train_tokenizer_hf.py চলাওক।
- এইয়ে আপোনাক vocab.json আৰু merges.txt দিব
- এই ফাইলবোৰে আপোনাৰ মডেলৰ বাবে শব্দভাণ্ডাৰ আৰু মাৰ্জ নিয়ম সংজ্ঞায়িত কৰে

### পদক্ষেপ ৩: আপোনাৰ মডেল প্ৰশিক্ষণ কৰক

- প্ৰশিক্ষণ প্ৰক্ৰিয়াৰ বাবে [Andrej Karpathy ৰ nanoGPT](https://github.com/karpathy/nanoGPT) চাওক বা আপোনাৰ নিৰ্বাচিত স্থাপত্যৰ নথিপত্র চাওক।

# FAQ

## Selective Temporal Training (STT) কি?

Selective Temporal Training (STT) হৈছে এটা যান্ত্রিক শিক্ষণ পদ্ধতি য'ত সকলো প্ৰশিক্ষণ তথ্য বিশেষকৈ নিৰ্দিষ্ট ঐতিহাসিক সময়ছোৱাৰ ভিতৰত পৰে বুলি নিৰ্বাচিত কৰা হয়। এইটো সেই যুগৰ ভাষা আৰু জ্ঞান মডেল কৰাৰ বাবে কৰা হয়, যাতে আধুনিক ধাৰণাৰ প্ৰভাৱ নাথাকে। উদাহৰণস্বৰূপে, মোৰ বৰ্তমান মডেল (v0.5) কেৱল ১৮০০-১৮৭৫ সময়ৰ তথ্যত প্ৰশিক্ষিত, ই fine-tune কৰা নহয়, একেবাৰে আৰম্ভণিৰ পৰা প্ৰশিক্ষণ কৰা, ফলত সেই সময়ছোৱাৰ ভাষাশৈলী আৰু ঐতিহাসিক প্ৰেক্ষাপট প্ৰতিফলিত হয়।

## মাত্ৰ fine-tuning বা LoRA কিয় ব্যৱহাৰ কৰা নহ'ল?

এই প্ৰকল্পৰ বাবে মই এটা এনে ভাষা মডেল তৈয়াৰ কৰিবলৈ চেষ্টা কৰিছোঁ, যি আধুনিক পক্ষপাতৰ পৰা মুক্ত। যদি মই GPT-2 মত দিছোঁ, তেন্তে ই ইতিমধ্যে আগতে প্ৰশিক্ষিত আৰু সেই তথ্য আঁতৰাব নোৱাৰি। যদি মই আৰম্ভণিৰ পৰা প্ৰশিক্ষণ দিওঁ, ভাষা মডেলে পুৰণি বুলি অভিনয় নকৰে, ই সঁচাকৈয়ে পুৰণি হ'ব। বৰ্তমান এই প্ৰকল্পৰ লক্ষ্য হৈছে ১৮০০-১৮৭৫ সময়ছোৱাৰ লণ্ডনৰ কিতাপৰ জ্ঞানহে ব্যৱহাৰ কৰি যুক্তি কৰিব পৰা এটা মডেল সৃষ্টি কৰা।

## প্ৰশিক্ষণৰ বাবে আপুনি কিহৰ পৰা তথ্য ললে?

মই ১৮০০-১৮৭৫ সময়ছোৱাৰ লণ্ডনৰ কিতাপ, আইনগত নথি, বাতৰিকাকত আৰু অন্যান্য লেখনি ব্যৱহাৰ কৰিছোঁ। মই যি তালিকা সংযোগ দিছোঁ (v0ৰ বাবে) প্ৰায় ২০০টা আছে, কিন্তু প্ৰথম প্ৰশিক্ষণত কেৱল ৫০টা ফাইল ~১৮৭ MB ব্যৱহাৰ কৰিছোঁ। আপুনি এই নথিসমূহৰ তালিকা চাব পাৰে:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

ডাটাসেটৰ আকাৰ:
- v0: ~১৮৭MB
- v0.5: ~৪৩৫MB 
- v1: ~৬.২৫GB 
- v2mini-eval1: 15GB (v2ৰ 90GB ৰ পৰা নমুনা)
- v2: 90GB

## মডেলবোৰ কিমান ডাঙৰ ?

v0: 16M পৰামিতি

v0.5: 123M পৰামিতি

v1: 700M পৰামিতি

v2mini-eval1: 300M পৰামিতি

v2mini-eval2: 200M পৰামিতি

v2: 1.2B পৰামিতি

## প্ৰশিক্ষণ স্পেক্‌স ?

### v0/v0.5
GPU: Geforce rtx 4060
CPU: i5-13400F 
Ram: 16GB DDR5.

### v1
GPU: A100 SXM ভাড়াত লোৱা

### v2mini-eval1/eval2
GPU: A100 SXM ভাড়াত লোৱা

### v2
GPU: H100 SXM ভাড়াত লোৱা

## কৃতজ্ঞতা

মই [ডাঃ হামেদ ইয়াঘুবিয়ান](https://hamedyaghoobian.com)ক ধন্যবাদ জনাইছোঁ, যি শৈক্ষিক পৰ্যবেক্ষণ, গৱেষণা গঠন আৰু মূল্যাংকনত পথপ্ৰদৰ্শন, আৰু v2 মুক্তিৰ বাবে টোকেনাইজাৰ প্ৰশিক্ষণ আৰু ডেটা ছেট প্ৰস্তুতিত সহায় কৰিছিল। তেওঁৰ মতামত আৰু অভিজ্ঞতা এই কামৰ উপস্থাপনাক উন্নত কৰিবলৈ অত্যন্ত সহায়ক হৈছিল।










































---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-03

---