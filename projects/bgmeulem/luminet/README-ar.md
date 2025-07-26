<div align="center">
  
# لومي نت
![ci-badge](https://img.shields.io/appveyor/build/bgmeulem/luminet?label=ci&style=flat-square) [![PyPI-badge](https://img.shields.io/pypi/v/luminet?pypiBaseUrl=https%3A%2F%2Fpypi.org&style=flat-square&logo=pypi&logoColor=white&link=https%3A%2F%2Fpypi.org%2Fproject%2Fluminet%2F)](https://pypi.org/project/luminet) [![Documentation Status](https://readthedocs.org/projects/luminet/badge/?version=latest&style=flat-square)](https://luminet.readthedocs.io/en/latest/?badge=latest) ![coverage](https://img.shields.io/codecov/c/github/bgmeulem/Luminet?style=flat-square) ![stars-badge](https://img.shields.io/github/stars/bgmeulem/Luminet?style=flat-square) ![license](https://img.shields.io/github/license/bgmeulem/Luminet?style=flat-square) [![Pixi Badge](https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/prefix-dev/pixi/main/assets/badge/v0.json&style=flat-square)](https://pixi.sh)

محاكاة وتصوير الثقوب السوداء شفارزشيلد، بالاعتماد على الطرق الموصوفة في Luminet (1979).

![مثال على رسم ثقب أسود](https://raw.githubusercontent.com/bgmeulem/luminet/master/assets/bh_plot.png)
</div>

## ⚡ التثبيت
`luminet` متوفر من خلال PyPI:

```shell
pip install luminet
```

## 📖 [التوثيق](https://luminet.readthedocs.io/en/latest/index.html)

## 🔩 الاستخدام

جميع المتغيرات في هذا المستودع بوحدات طبيعية: $G=c=1$

```python
from luminet.black_hole import BlackHole
bh = BlackHole(
    mass=1,
    incl=1.5,           # inclination in radians
    acc=1,              # accretion rate
    outer_edge=40
)
```
لإنشاء صورة:
```python
ax = bh.plot()          # Create image like above
```

لأخذ عينات من الفوتونات على قرص التراكم:
```python
bh.sample_photons(100)
bh.photons
```
```
radius  alpha   impact_parameter    z_factor    flux_o
10.2146 5.1946  1.8935              1.1290      1.8596e-05
... (99 more)
```

لاحظ أن أخذ العينات متحيز نحو مركز الثقب الأسود، حيث أن معظم اللمعان يأتي من هناك.


## 📝 خلفية
تحتوي الثقوب السوداء شفارتزشيلد على مدار مستقر داخلي عند $6M$، وكرة فوتونية عند $3M$. هذا يعني أن
قرص التراكم الذي يدور حول الثقب الأسود يصدر فوتونات عند أنصاف أقطار $r>6M$. طالما أن الحضيض الفوتوني في الفضاء المنحني يبقى أكبر من $3M$ (ويسمى أيضاً كرة الفوتون)، فلن يتم التقاط الفوتون بواسطة الثقب الأسود ويمكن نظرياً رؤيته من إطار مرجعي للمراقب $(b, \alpha)$. يمكن تفسير انحناء الزمكان بسهولة كظاهرة عدسية بين إطار الثقب الأسود $(r, \alpha)$ وإطار المراقب $(b, \alpha)$. الإحداثيات الأولى هي إحداثيات قطبية ثنائية الأبعاد تغطي مساحة قرص التراكم، والثانية هي إحداثيات قطبية ثنائية الأبعاد تغطي "لوحة التصوير" في إطار المراقب. فكر في الثانية على أنها كاميرا CCD حرفياً. حضيض مدار الفوتون ونصف القطر في إطار المراقب $b$ مرتبطان مباشرةً:

$$b^2 = \frac{P^3}{P-2M}$$

هذا يجعل العديد من المعادلات أكثر بساطة بشكل ملحوظ.
قد تلاحظ أن هذه المعادلة تحتوي على تربيع في الطرف الأيسر، على عكس لومينيه (1979). المخطوطة الأصلية تحتوي على بعض أخطاء التدوين. لقد تواصلت مع المؤلف بشأن هذا، ورد بلطف قائلاً:

> "[...] à l’époque je n'avais pas encore l’expérience de relire très soigneusement les épreuves. Mais mes calculs avaient  heureusement été faits avec les bonnes formules, sinon le résultat visuel n’aurait pas été correct!" 
>
>"في ذلك الوقت، لم تكن لدي عادة التحقق المزدوج بعناية من البراهين. لحسن الحظ، قمت بالحسابات بالمعادلات الصحيحة، وإلا لما كانت الصورة صحيحة!".

فقط لكي تعلم. حاولت أن أكون دقيقاً في الإشارة إلى أين يختلف هذا الكود عن الورقة.

العلاقة بين الزوايا في كلا نظامي الإحداثيات مباشرة، لكن العلاقة بين أنصاف الأقطار في الإطارين المرجعيين تعطى بالمعادلة الوحشية رقم 13:

$$\frac{1}{r} = - \frac{Q - P + 2M}{4MP} + \frac{Q-P+6M}{4MP}{sn}^2\left( \frac{\gamma}{2}\sqrt{\frac{Q}{P}} + F(\zeta_\infty, k) \right)$$

هنا، $F$ هو تكامل جاكوبي الإهليلجي غير الكامل من النوع الأول، و$k$ و$Q$ هما دالتان في الحضيض $P$، و$\zeta$ دوال مثلثية في $P$، و$\gamma$ تحقق:

$$\cos(\gamma) = \frac{\cos(\alpha)}{\sqrt{\cos^2\alpha + \cot^2\theta_0}}$$

في الزمكان المنحني، غالبًا ما توجد مدارات فوتونية متعددة تنشأ من نفس الإحداثيات وتُسقط إلى إطار المراقب (انظر مثلاً عدسات الجاذبية وصليب أينشتاين). المدارات الفوتونية التي تدور حول الثقب الأسود وتصل إلى إطار المراقب تُسمى "صور مرتبة أعلى"، أو "صور شبحية". في هذه الحالة، تحقق $\gamma$:

$$2n\pi - \gamma = 2\sqrt{\frac{Q}{P}} \left( 2K(k) - F(\zeta_\infty, k) - F(\zeta_r, k)  \right)$$

هذه الفوتونات الشبحية هي ما تراه في النصف السفلي من الصورة أعلاه، وكذلك الهالة الضوئية التي بالكاد يمكن رؤيتها والتي تحيط بكرة الفوتون بشكل رفيع. بالنسبة للميلان الأقل قرباً من الحافة، تكون هذه الصورة الشبحية أقل وضوحاً.

يستخدم هذا المستودع `scipy.optimize.brentq` لحل هذه المعادلات، ويوفر واجهة برمجية ملائمة للمفاهيم المعروضة في لومينيه (1979). تعتبر الفئة `BlackHole` هي الأوضح، لكن من المفيد أيضاً تجربة الفئة `Isoradial`: وهي خطوط في إطار المراقب تصف فوتونات صادرة من نفس نصف القطر في إطار الثقب الأسود. وتوفر الفئة `Isoredshift` خطوط التزحزح المتساوي في إطار المراقب.

## 📕 المراجع
[1] لومينيه، ج.-ب.، ["صورة ثقب أسود كروي مع قرص تراكم رقيق."](https://ui.adsabs.harvard.edu/abs/1979A%26A....75..228L/abstract)، <i>علم الفلك والفيزياء الفلكية</i>، المجلد 75، الصفحات 228–235، 1979.

[2] ج.-ب. لومينيه، ["تاريخ مصور لتصوير الثقوب السوداء: ذكريات شخصية (1972-2002)."](https://arxiv.org/abs/1902.11196) arXiv، 2019. doi: 10.48550/ARXIV.1902.11196. 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-26

---