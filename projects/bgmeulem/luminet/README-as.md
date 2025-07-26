<div align="center">
  
# লুমিনেট
![ci-badge](https://img.shields.io/appveyor/build/bgmeulem/luminet?label=ci&style=flat-square) [![PyPI-badge](https://img.shields.io/pypi/v/luminet?pypiBaseUrl=https%3A%2F%2Fpypi.org&style=flat-square&logo=pypi&logoColor=white&link=https%3A%2F%2Fpypi.org%2Fproject%2Fluminet%2F)](https://pypi.org/project/luminet) [![Documentation Status](https://readthedocs.org/projects/luminet/badge/?version=latest&style=flat-square)](https://luminet.readthedocs.io/en/latest/?badge=latest) ![coverage](https://img.shields.io/codecov/c/github/bgmeulem/Luminet?style=flat-square) ![stars-badge](https://img.shields.io/github/stars/bgmeulem/Luminet?style=flat-square) ![license](https://img.shields.io/github/license/bgmeulem/Luminet?style=flat-square) [![Pixi Badge](https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/prefix-dev/pixi/main/assets/badge/v0.json&style=flat-square)](https://pixi.sh)

লুমিনেট (১৯৭৯)ত বৰ্ণনা কৰা পদ্ধতিসমূহৰ আধাৰত, শ্বাৰ্জচাইল্ড ব্লেক হ'লসমূহক অনুকৰণ আৰু দৃশ্যায়ন কৰক।

![এটা ব্লেক হ'লৰ উদাহৰণ চিত্ৰ](https://raw.githubusercontent.com/bgmeulem/luminet/master/assets/bh_plot.png)
</div>

## ⚡ ইনষ্টল কৰক
`luminet` PyPI-ত উপলব্ধ:

```shell
pip install luminet
```

## 📖 [ডকুমেণ্টেছন](https://luminet.readthedocs.io/en/latest/index.html)

## 🔩 ব্যৱহাৰ

এই ৰিপ'ৰ সকলো ভেৰিয়েবল প্ৰাকৃতিক এককত আছে: $G=c=1$

```python
from luminet.black_hole import BlackHole
bh = BlackHole(
    mass=1,
    incl=1.5,           # inclination in radians
    acc=1,              # accretion rate
    outer_edge=40
)
```
এটা ছবি সৃষ্টি কৰিবলৈ:
```python
ax = bh.plot()          # Create image like above
```
অ্যাক্ৰেচন ডিস্কত ফ’টন নমুনা কৰিবলৈ:

```python
bh.sample_photons(100)
bh.photons
```
```
radius  alpha   impact_parameter    z_factor    flux_o
10.2146 5.1946  1.8935              1.1290      1.8596e-05
... (99 more)
```
লক্ষ্য কৰক যে নমুনাকৰণটো ব্লেক হ'লৰ কেন্দ্ৰৰ ফালে পক্ষপাতী, কাৰণ ইয়াৰ অধিকাংশ দীপ্তি ইয়াৰ পৰা আহে।


## 📝 পৃষ্ঠভূমি
স্বাৰ্জচিল্ড ব্লেক হ'লসমূহৰ আটাইতকৈ ভিতৰৰ স্থিতিশীল কক্ষপথ হৈছে $6M$, আৰু এক ফ'টন গোলক $3M$-ত। ইয়াৰ অৰ্থ হৈছে যে ব্লেক হ'লৰ চাৰিওফালে ঘূৰণি খোৱা এক্ৰেচন ডিস্কে $r>6M$ ত ফ'টন নিৰ্গত কৰে। যদি বাঁকা স্থানত ফ'টনৰ ন্যূনতম দূৰত্ব $3M$ (ফ'টন গোলক বুলিও কোৱা হয়)তকৈ ডাঙৰ হৈ থাকে, তেন্তে ফ'টনটো ব্লেক হ'লত ধৰা নপৰে আৰু তাত্বিকভাৱে কিছুমান পৰ্যবেক্ষক ফ্ৰেম $(b, \alpha)$ ৰ পৰা দেখা যাব পাৰে। স্থান-সময়ৰ বেঁকা সহজে এক লেন্সিং প্ৰভাৱ হিচাপে ব্যাখ্যা কৰিব পাৰি ব্লেক হ'ল ফ্ৰেম $(r, \alpha)$ আৰু পৰ্যবেক্ষক ফ্ৰেম $(b, \alpha)$ ৰ মাজত। প্ৰথমটো হৈছে ২-ডি পোলাৰ স্থানাংক যিয়ে এক্ৰেচন ডিস্কৰ এলাকা বিস্তাৰ কৰে, আৰু দ্বিতীয়টো হৈছে ২-ডি পোলাৰ স্থানাংক যিয়ে পৰ্যবেক্ষক ফ্ৰেমৰ "ফটোগ্ৰাফিক প্লেট" বিস্তাৰ কৰে। দ্বিতীয়টো প্ৰকৃততে এটা CCD কেমেৰাৰ দৰে ভাবিব পাৰি। ফ'টন কক্ষপথৰ ন্যূনতম দূৰত্ব আৰু পৰ্যবেক্ষক ফ্ৰেমত ব্ৰেডিয়াছ $b$ ৰ মাজত পোনপটীয়া সম্পৰ্ক আছে:

$$b^2 = \frac{P^3}{P-2M}$$

এইটো বহুতো সমীকৰণক যথেষ্ট সহজ কৰি তোলে।
আপুনি লক্ষ্য কৰিব পাৰে এই সমীকৰণৰ বাওঁফালে এখন স্কুৱাৰ আছে, Luminet (1979)-ৰ লগত তুলনা কৰিলে। মূল পাণ্ডুলিপিত কিছুমান চিহ্নৰ ভুল আছে। মই লেখকক এই সম্পৰ্কে যোগাযোগ কৰিছিলো, আৰু তেওঁ সদয়ভাৱে উত্তৰ দিছিল:

> "[...] à l’époque je n'avais pas encore l’expérience de relire très soigneusement les épreuves. Mais mes calculs avaient  heureusement été faits avec les bonnes formules, sinon le résultat visuel n’aurait pas été correct!" 
>
>"তেতিয়া মই এতিয়ালৈকে বেছি মনোযোগ সহকাৰে প্ৰুফ চাবলৈ অভ্যাস কৰা নাছিলো। সৌভাগ্যক্ৰমে মই সঠিক সূত্রৰে গণনা কৰিছিলো, নহলে চিত্ৰটো সঠিক হোৱা নাছিল!"।

আপোনালোকৰ জানিবৰ বাবে। মই যত্নসহকাৰে উল্লেখ কৰিছো ক'ত এই ক'ডটো কাগজৰ পৰা ভিন্ন।

দুয়োটা স্থানাংক পদ্ধতিৰ কোণৰ মাজত সম্পৰ্ক সহজ, কিন্তু দুইটো ৰেফাৰেন্স ফ্ৰেমৰ ব্ৰেডিয়াছৰ মাজত সম্পৰ্ক আছে ভয়ংকৰ Equation 13 দ্বাৰা:

$$\frac{1}{r} = - \frac{Q - P + 2M}{4MP} + \frac{Q-P+6M}{4MP}{sn}^2\left( \frac{\gamma}{2}\sqrt{\frac{Q}{P}} + F(\zeta_\infty, k) \right)$$

ইয়াত, $F$ হৈছে অসম্পূৰ্ণ জেকবিয়ান এলিপটিক ইন্টেগ্ৰেল (প্ৰথম প্ৰকাৰৰ), $k$ আৰু $Q$ হৈছে perigee $P$ ৰ ফাংশন, $\zeta$ হৈছে $P$ ৰ ত্ৰিকোণমিতিক ফাংশন, আৰু $\gamma$ অনুসৰি:

$$\cos(\gamma) = \frac{\cos(\alpha)}{\sqrt{\cos^2\alpha + \cot^2\theta_0}}$$

বাঁকা স্থান-সময়ত সাধাৰণতে একে স্থানাংকৰ পৰা উদ্ভূত বহু ফ'টন কক্ষপথ থাকে যিয়ে পৰ্যবেক্ষক ফ্ৰেমত প্ৰক্ষেপিত হয় (উদাহৰণ স্বৰূপ গ্ৰেভিটেচনাল লেন্সিং আৰু আইনষ্টাইন ক্ৰছ)। ফ'টন কক্ষপথ যিয়ে ব্লেক হ'লৰ চাৰিওফালে ঘূৰি পৰ্যবেক্ষক ফ্ৰেমত আহে, সেইবোৰক "higher order" images বা "ghost" images বোলা হয়। এই ক্ষেত্ৰত, $\gamma$ পূৰণ কৰে:

$$2n\pi - \gamma = 2\sqrt{\frac{Q}{P}} \left( 2K(k) - F(\zeta_\infty, k) - F(\zeta_r, k)  \right)$$

এইবোৰ ভূতীয়া ফ'টনসমূহেই ওপৰৰ চিত্ৰৰ তলৰ অংশত দেখা যায়, লগতে ফ'টন গোলকৰ চাৰিওফালে পাতলকৈ ঘূৰি থকা পোহৰৰ মৃদু আবৰণ। অধিক কোণীয় অৱস্থাত, এই ভূতীয়া চিত্ৰ কম দৃশ্যমান হয়।

এই ৰিপ'জিটৰীয়ে `scipy.optimize.brentq` ব্যৱহাৰ কৰি এই সমীকৰণসমূহ সমাধান কৰে, আৰু Luminet (1979)-ত উপস্থাপিত ধাৰণাসমূহৰ বাবে সুবিধাজনক API প্ৰদান কৰে। `BlackHole` শ্ৰেণীটো আটাইতকৈ স্পষ্ট, কিন্তু `Isoradial` শ্ৰেণীৰ সৈতে খেলি চাইও শিক্ষামূলক: পৰ্যবেক্ষক ফ্ৰেমত সেইবোৰ ৰেখা যিয়ে ব্লেক হ'ল ফ্ৰেমৰ একে ব্ৰেডিয়াছৰ পৰা নিৰ্গত ফ'টন বৰ্ণনা কৰে। `Isoredshift` শ্ৰেণীয়ে পৰ্যবেক্ষক ফ্ৰেমত সম-ৰেডশিফ্টৰ ৰেখা দিয়ে।

## 📕 গ্ৰন্থপঞ্জী
[1] Luminet, J.-P., [“Image of a spherical black hole with thin accretion disk.”](https://ui.adsabs.harvard.edu/abs/1979A%26A....75..228L/abstract), <i>Astronomy and Astrophysics</i>, vol. 75, pp. 228–235, 1979.

[2] J.-P. Luminet, [“An Illustrated History of Black Hole Imaging : Personal Recollections (1972-2002).”](https://arxiv.org/abs/1902.11196) arXiv, 2019. doi: 10.48550/ARXIV.1902.11196. 




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-26

---