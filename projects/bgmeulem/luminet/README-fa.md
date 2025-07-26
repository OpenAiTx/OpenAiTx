<div align="center">
  
# لومینت
![ci-badge](https://img.shields.io/appveyor/build/bgmeulem/luminet?label=ci&style=flat-square) [![PyPI-badge](https://img.shields.io/pypi/v/luminet?pypiBaseUrl=https%3A%2F%2Fpypi.org&style=flat-square&logo=pypi&logoColor=white&link=https%3A%2F%2Fpypi.org%2Fproject%2Fluminet%2F)](https://pypi.org/project/luminet) [![Documentation Status](https://readthedocs.org/projects/luminet/badge/?version=latest&style=flat-square)](https://luminet.readthedocs.io/en/latest/?badge=latest) ![coverage](https://img.shields.io/codecov/c/github/bgmeulem/Luminet?style=flat-square) ![stars-badge](https://img.shields.io/github/stars/bgmeulem/Luminet?style=flat-square) ![license](https://img.shields.io/github/license/bgmeulem/Luminet?style=flat-square) [![Pixi Badge](https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/prefix-dev/pixi/main/assets/badge/v0.json&style=flat-square)](https://pixi.sh)

شبیه‌سازی و بصری‌سازی سیاه‌چاله‌های شوارتزشیلد، بر اساس روش‌های توصیف‌شده در لومینت (۱۹۷۹).

![نمونه نمودار سیاه‌چاله](https://raw.githubusercontent.com/bgmeulem/luminet/master/assets/bh_plot.png)
</div>

## ⚡ نصب
`luminet` از PyPI قابل دریافت است:

```shell
pip install luminet
```

## 📖 [مستندات](https://luminet.readthedocs.io/en/latest/index.html)

## 🔩 نحوه استفاده

تمام متغیرها در این مخزن در واحدهای طبیعی هستند: $G=c=1$

```python
from luminet.black_hole import BlackHole
bh = BlackHole(
    mass=1,
    incl=1.5,           # inclination in radians
    acc=1,              # accretion rate
    outer_edge=40
)
```
برای ایجاد یک تصویر:
```python
ax = bh.plot()          # Create image like above
```
برای نمونه‌برداری فوتون‌ها روی دیسک برافزایشی:

```python
bh.sample_photons(100)
bh.photons
```
```
radius  alpha   impact_parameter    z_factor    flux_o
10.2146 5.1946  1.8935              1.1290      1.8596e-05
... (99 more)
```
توجه داشته باشید که نمونه‌برداری به سمت مرکز سیاه‌چاله سوگیری دارد، زیرا بیشتر درخشندگی از این ناحیه می‌آید.

## 📝 پیش‌زمینه
سیاه‌چاله‌های شوارتزشیلد دارای نزدیک‌ترین مدار پایدار در فاصله $6M$ و یک کره فوتونی در $3M$ هستند. این بدان معناست که دیسک برافزایشی که به دور سیاه‌چاله می‌چرخد، فوتون‌ها را در شعاع‌های $r>6M$ منتشر می‌کند. تا زمانی که حضیض فوتون در فضازمان خمیده بزرگ‌تر از $3M$ (که به آن کره فوتونی نیز گفته می‌شود) باقی بماند، فوتون توسط سیاه‌چاله اسیر نمی‌شود و از برخی چارچوب ناظر $(b, \alpha)$ می‌تواند دیده شود. انحنای فضازمان به آسانی به عنوان یک اثر عدسی بین چارچوب سیاه‌چاله $(r, \alpha)$ و چارچوب ناظر $(b, \alpha)$ تفسیر می‌شود. اولی مختصات قطبی دوبعدی هستند که منطقه دیسک برافزایشی را پوشش می‌دهند و دومی مختصات قطبی دوبعدی هستند که «صفحه عکاسی» چارچوب ناظر را پوشش می‌دهند. دومی را مانند یک دوربین CCD واقعی تصور کنید. حضیض مدار فوتون و شعاع در چارچوب ناظر $b$ مستقیماً مرتبط هستند:

$$b^2 = \frac{P^3}{P-2M}$$

این معادله بسیاری از روابط را به طور قابل توجهی ساده‌تر می‌کند.
ممکن است متوجه شوید که این معادله در سمت چپ دارای توان دو است، برخلاف لومینه (۱۹۷۹). نسخه اصلی مقاله دارای چندین خطای نمادگذاری است. من با نویسنده تماس گرفتم که او با مهربانی پاسخ داد:

> "[...] à l’époque je n'avais pas encore l’expérience de relire très soigneusement les épreuves. Mais mes calculs avaient  heureusement été faits avec les bonnes formules, sinon le résultat visuel n’aurait pas été correct!" 
>
>"در آن زمان هنوز عادت نکرده بودم که خیلی دقیق بازبینی کنم. خوشبختانه محاسبات را با فرمول‌های درست انجام دادم، وگرنه نتیجه تصویری درست نمی‌شد!".

فقط خواستم بدانید. سعی کردم دقیقاً یادداشت کنم که کجا این کد با مقاله تفاوت دارد.

رابطه بین زوایای هر دو دستگاه مختصات بدیهی است، اما رابطه بین شعاع‌ها در دو چارچوب مرجع توسط معادله عظیم ۱۳ داده می‌شود:

$$\frac{1}{r} = - \frac{Q - P + 2M}{4MP} + \frac{Q-P+6M}{4MP}{sn}^2\left( \frac{\gamma}{2}\sqrt{\frac{Q}{P}} + F(\zeta_\infty, k) \right)$$

در اینجا، $F$ انتگرال بی‌کامل ژاکوبی بیضوی نوع اول است، $k$ و $Q$ تابعی از حضیض $P$ هستند، $\zeta$ توابع مثلثاتی از $P$ هستند و $\gamma$ برآورده می‌کند:

$$\cos(\gamma) = \frac{\cos(\alpha)}{\sqrt{\cos^2\alpha + \cot^2\theta_0}}$$

در فضازمان خمیده، معمولاً چندین مدار فوتونی وجود دارد که از یک مختصات آغاز می‌شوند و به چارچوب ناظر تصویر می‌شوند (مثلاً لنز گرانشی و صلیب اینشتین). مدارهای فوتونی که به دور سیاه‌چاله منحنی می‌شوند و به چارچوب ناظر می‌رسند، «تصاویر مرتبه بالاتر» یا تصاویر «شبح» نامیده می‌شوند. در این حالت، $\gamma$ برآورده می‌کند:

$$2n\pi - \gamma = 2\sqrt{\frac{Q}{P}} \left( 2K(k) - F(\zeta_\infty, k) - F(\zeta_r, k)  \right)$$

این فوتون‌های شبح همان چیزی هستند که در نیمه پایین تصویر بالا و همچنین هاله کم‌نوری که به صورت نازک اطراف کره فوتونی را می‌پوشاند، می‌بینید. برای میل‌هایی که کمتر لبه‌ای هستند، این تصویر شبح کمتر برجسته است.

این مخزن از `scipy.optimize.brentq` برای حل این معادلات استفاده می‌کند و API مناسبی را برای مفاهیم ارائه‌شده در لومینه (۱۹۷۹) فراهم می‌کند. کلاس `BlackHole` آشکارترین آن‌هاست، اما بازی با کلاس‌هایی مثل `Isoradial` هم آموزنده است: خطوطی در چارچوب ناظر که فوتون‌های گسیل‌شده از شعاع یکسان در چارچوب سیاه‌چاله را توصیف می‌کنند. کلاس `Isoredshift` خطوط انتقال‌به‌سرخ برابر را در چارچوب ناظر ارائه می‌دهد.

## 📕 کتابشناسی
[1] لومینه، ژ.-پ.، [“تصویر یک سیاه‌چاله کروی با دیسک برافزایشی نازک.”](https://ui.adsabs.harvard.edu/abs/1979A%26A....75..228L/abstract)، <i>اخترشناسی و اخترفیزیک</i>، جلد ۷۵، صفحات ۲۲۸–۲۳۵، ۱۹۷۹.

[2] ژ.-پ. لومینه، [“تاریخ مصور تصویربرداری سیاه‌چاله: خاطرات شخصی (۱۹۷۲-۲۰۰۲).”](https://arxiv.org/abs/1902.11196) arXiv، ۲۰۱۹. doi: 10.48550/ARXIV.1902.11196. 





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-26

---