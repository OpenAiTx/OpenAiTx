warbleR: জৈৱ-ধ্বনি বিশ্লেষণ সহজ কৰক
================

🌐 **ভাষাসমূহ:**  
[ইংৰাজী](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=en) |
[স্পেনীশ](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=es) |
[ফৰাছী](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=fr) |
[জাৰ্মান](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=de) |
[পৰ্তুগীজ](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=pt) |
[ইটালিয়ান](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=it) |
[ৰাছিয়ান](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ru) |
[চাইনীজ (সৰল)](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=zh-CN) |
[চাইনীজ (প্ৰাচীন)](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=zh-TW) |
[জাপানীজ](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ja) |
[কোৰিয়ান](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ko) |
[হিন্দী](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=hi) |
[থাই](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=th) |
[ডাচ](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=nl) |
[পোলিশ](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=pl) |
[আৰবী](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ar) |
[ফাৰ্সী](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=fa) |
[তুৰ্কী](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=tr) |
[ভিয়েটনামী](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=vi) |
[ইন্দোনেশিয়ান](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=id) |
[অসমীয়া](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=as)

<!-- README.md README.Rmdৰ পৰা তৈয়াৰ কৰা হৈছে। অনুগ্ৰহ কৰি সেই ফাইলটো সম্পাদনা কৰক -->
<!-- badges: start -->

[![lifecycle](https://img.shields.io/badge/lifecycle-maturing-brightgreen.svg)](https://lifecycle.r-lib.org/articles/stages.html)
[![status](https://tinyverse.netlify.app/badge/warbleR)](https://CRAN.R-project.org/package=warbleR)
[![Project Status: Active The project has reached a stable, usable state
and is being actively
developed.](https://www.repostatus.org/badges/latest/active.svg)](https://www.repostatus.org/#active)
[![License: GPL
v3](https://img.shields.io/badge/License-GPLv3-blue.svg)](https://www.gnu.org/licenses/gpl-3.0)
[![CRAN_Status_Badge](https://www.r-pkg.org/badges/version/warbleR)](https://cran.r-project.org/package=warbleR)
[![Total
Downloads](https://cranlogs.r-pkg.org/badges/grand-total/warbleR)](https://cranlogs.r-pkg.org/badges/grand-total/warbleR)
[![Codecov test
coverage](https://codecov.io/gh/maRce10/warbleR/branch/master/graph/badge.svg)](https://app.codecov.io/gh/maRce10/warbleR?branch=master)
<!-- badges: end -->

<img src="https://raw.githubusercontent.com/maRce10/warbleR/master/man/figures/warbleR_sticker.png" alt="warbleR logo" align="right" width = "25%" height="25%"/>

[warbleR](https://cran.r-project.org/package=warbleR) হৈছে
জন্তুৰ ধ্বনি সংকেতৰ গঠন বিশ্লেষণত
R-ত সহায় কৰাৰ উদ্দেশ্যে তৈয়াৰ কৰা হৈছে। ব্যৱহাৰকাৰীসকলে মুক্ত-প্ৰৱেশাধিকাৰ থকা পক্ষী ৰেকৰ্ডিং সংগ্ৰহ কৰিব পাৰে বা নিজৰ
ডেটা এখন ৱাৰ্কফ্ল’ত দিব পাৰে যি স্পেক্ট্ৰ’গ্ৰাফিক ভিজুৱালাইজেশ্যন আৰু
ধ্বনি পৰামিতি মাপ লোৱাৰ সুবিধা দিয়ে।
[warbleR](https://cran.r-project.org/package=warbleR) seewave পেকেজৰ
মৌলিক ধ্বনি বিশ্লেষণ টুলবোৰ ব্যৱহাৰ কৰে, আৰু নতুন
ধ্বনি গঠন বিশ্লেষণৰ টুল আগবঢ়ায়। এই টুলবোৰ
ধ্বনি সংকেতৰ ব্যাচ বিশ্লেষণৰ বাবে উপলব্ধ।

পেকেজটোৰ মুখ্য বৈশিষ্ট্যসমূহ হৈছে:

- ধ্বনি গঠন মাপাৰ বাবে বহু ধৰণৰ টুল
- লুপ ব্যৱহাৰ কৰি ছেলেকশ্যন টেবুলত উল্লেখ থকা
  ধ্বনি সংকেতত কাম প্ৰয়োগ কৰা
- স্পেক্ট্ৰ’গ্ৰামৰ সৈতে চিত্ৰসমূহ কৰ্মক্ষেত্ৰ ডিৰেক্টৰীত সংৰক্ষণ কৰা
  যাতে ব্যৱহাৰকাৰীয়ে ডেটা সংগঠিত আৰু বিশ্লেষণ নিশ্চিত কৰিব পাৰে

পেকেজটোৱে নিম্নলিখিত ফাংচনসমূহ আগবঢ়ায়:

- [Xeno‐Canto](https://xeno-canto.org/) ৰেকৰ্ডিং অন্বেষণ আৰু ডাউনলোড কৰা
- বহুটা শব্দ ফাইল অন্বেষণ, সংগঠিত আৰু পৰিমার্জন কৰা
- সংকেত স্বয়ংক্ৰিয়ভাৱে চিনাক্ত কৰা (ফ্ৰিকুৱেঞ্চি আৰু সময়ত) (কিন্তু অধিক বিস্তৃত আৰু সুবিধাজনক ব্যৱহাৰৰ বাবে R
  পেকেজ [ohun](https://docs.ropensci.org/ohun/) চাওক)
- সম্পূৰ্ণ ৰেকৰ্ডিং বা পৃথক সংকেতৰ স্পেক্ট্ৰ’গ্ৰাম তৈয়াৰ কৰা
- ধ্বনি সংকেত গঠন বিচাৰৰ বিভিন্ন মাপ চলোৱা
- মাপ নিয়া পদ্ধতিৰ কার্যক্ষমতা মূল্যায়ন কৰা
- সংকেত ক্যাটালগ কৰা
- ধ্বনি সংকেতত বিভিন্ন গঠনস্তৰ বৰ্ণনা কৰা
- ডুৱেট সমন্বয়ৰ পৰিসংখ্যা বিশ্লেষণ
- ডেটাবেইচ আৰু অ্যানোটেশ্যন টেবুল সংহত কৰা

বেছিভাগ ফাংচনে কাৰ্যসমূহ সমান্তৰালভাৱে চলাব পাৰে, যাৰ ফলত
কাৰ্যসমূহ একাধিক প্ৰসেছৰত বিতৰণ কৰি গাণিতিক কার্যক্ষমতা উন্নত কৰে

দক্ষতা। বিশ্লেষণৰ প্ৰতিটো পৰ্যায়ত কাৰ্যক্ষমতা মূল্যাংকন কৰাৰ বাবে সহায়ক সামগ্রী উপলব্ধ আছে।

## স্থাপন

CRAN ৰ পৰা পেকেজটো ইনষ্টল/লোড কৰক তলত দিয়া মতে:


``` r
install.packages("warbleR")

# load package
library(warbleR)
```
সৰ্বশেষ উন্নয়ন সংস্কৰণটো
[github](https://github.com/) ৰ পৰা ইনষ্টল কৰিবলৈ আপোনাৰ
R পেকেজ [remotes](https://cran.r-project.org/package=remotes)ৰ
প্ৰয়োজন হ'ব:

``` r
remotes::install_github("maRce10/warbleR")

# load package
library(warbleR)
```

## ব্যৱহাৰ

পেকেজটোৱে ইয়াৰ মুখ্য বৈশিষ্ট্যসমূহ ব্যাখ্যা কৰা কেইবাটাও ভিগনেট অন্তর্ভুক্ত কৰে। [warbleR-ৰ
প্ৰবর্তনা](https://marce10.github.io/warbleR/articles/warbleR.html)
পেকেজৰ কাৰ্যক্ষমতাৰ সংক্ষিপ্ত বিবৰণ প্ৰদান কৰে। ভিগনেট
[অ্যনোটেশ্যন ডাটা
ফৰ্মেট](https://marce10.github.io/warbleR/articles/annotation_data_format.html)
ইনপুট অ্যনোটেশ্যনৰ বাবে প্ৰয়োজনীয় ফৰ্মেটৰ বিস্তৃত বিৱৰণ দিয়ে। তদুপৰি, তিনিটা [পেকেজ
ভিগনেট](https://marce10.github.io/warbleR/articles/) আছে, য’ত
শব্দ বিশ্লেষণ কর্মপ্ৰবাহত ফাংকশ্যনসমূহ কেনেকৈ সংগঠিত কৰিব পাৰি তাৰ উদাহৰণ দিয়া হৈছে।

পেকেজটোৰ সম্পূর্ণ বিৱৰণ (অল্প পৰিমাণে পুৰণি হ’ব পাৰে) এই [জাৰ্নাল
প্ৰবন্ধত](https://besjournals.onlinelibrary.wiley.com/doi/10.1111/2041-210X.12624) উপলব্ধ।

## অন্যান্য পেকেজ

[seewave](https://cran.r-project.org/package=seewave) আৰু
[tuneR](https://cran.r-project.org/package=seewave) পেকেজসমূহে
শব্দ বিশ্লেষণ আৰু পৰিচালনাৰ বাবে বহুবিধ ফাংকশ্যন প্ৰদান কৰে। এইবোৰ
মূলতঃ ইতিমধ্যে R পৰিবেশত ইম্পোৰ্ট কৰা wave অবজেক্টসমূহত কাম কৰে। 
[baRulho](https://cran.r-project.org/package=baRulho) পেকেজটো
আবাসস্থল-প্ৰভাবিত শব্দ সংকেতৰ অবনতি পৰিমাপকত কেন্দ্ৰিত, ইয়াৰ
ইনপুট আৰু আউটপুট ডাটা [warbleR](https://cran.r-project.org/package=warbleR) ৰ দৰে।
[Rraven](https://cran.r-project.org/package=Rraven) পেকেজে
R আৰু [Raven শব্দ বিশ্লেষণ
ছফটৱেৰ](https://www.ravensoundsoftware.com/) ([Cornell Lab of
Ornithology](https://www.birds.cornell.edu/home))-ৰ মাজত ডাটা আদান-প্ৰদান সহজ কৰে,
আৰু Raven-কে annotating tool হিচাপে R-ৰ শব্দ বিশ্লেষণ কর্মপ্ৰবাহত অন্তর্ভুক্ত কৰিবলৈ
অতি সহায়ক। 
[ohun](https://docs.ropensci.org/ohun/) পেকেজটো
স্বয়ংক্ৰিয় শব্দ ইভেন্ট চিনাক্তকৰণত কাম কৰে, আৰু চিনাক্তকৰণ ৰুটিনসমূহ
ডায়াগন’জ আৰু অপ্টিমাইজ কৰিবলৈ ফাংকশ্যনসমূহ প্ৰদান কৰে।
[dynaSpec](https://cran.r-project.org/package=seewave) পেকেজে
ডায়নামিক স্পেকট্ৰোগ্ৰাম (অর্থাৎ স্পেকট্ৰোগ্ৰাম ভিডিঅ’) সৃষ্টি কৰিবলৈ অনুমতি দিয়ে।

## উদ্ধৃতি




অনুগ্ৰহ কৰি [warbleR](https://cran.r-project.org/package=warbleR)ক তলত দিয়া দৰে উদ্ধৃত কৰক:

Araya-Salas, M. আৰু Smith-Vidaurre, G. (2017), *warbleR: an r package to
streamline analysis of animal acoustic signals*. Methods Ecol Evol. 8,
184-191.

টোকা: যদি আপুনি
[tuneR](https://cran.r-project.org/package=tuneR) আৰু
[seewave](https://cran.r-project.org/package=seewave) package ব্যৱহাৰ কৰে
spectrogram-তৈৰ কৰা বা acoustic-mেপিং functionসমূহ



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-13

---