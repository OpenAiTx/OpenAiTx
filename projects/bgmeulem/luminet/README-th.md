<div align="center">
  
# luminet
![ci-badge](https://img.shields.io/appveyor/build/bgmeulem/luminet?label=ci&style=flat-square) [![PyPI-badge](https://img.shields.io/pypi/v/luminet?pypiBaseUrl=https%3A%2F%2Fpypi.org&style=flat-square&logo=pypi&logoColor=white&link=https%3A%2F%2Fpypi.org%2Fproject%2Fluminet%2F)](https://pypi.org/project/luminet) [![Documentation Status](https://readthedocs.org/projects/luminet/badge/?version=latest&style=flat-square)](https://luminet.readthedocs.io/en/latest/?badge=latest) ![coverage](https://img.shields.io/codecov/c/github/bgmeulem/Luminet?style=flat-square) ![stars-badge](https://img.shields.io/github/stars/bgmeulem/Luminet?style=flat-square) ![license](https://img.shields.io/github/license/bgmeulem/Luminet?style=flat-square) [![Pixi Badge](https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/prefix-dev/pixi/main/assets/badge/v0.json&style=flat-square)](https://pixi.sh)

โปรแกรมจำลองและแสดงภาพหลุมดำชวาร์ซชิลด์ โดยอิงจากวิธีการที่อธิบายไว้ใน Luminet (1979)

![ตัวอย่างกราฟของหลุมดำ](https://raw.githubusercontent.com/bgmeulem/luminet/master/assets/bh_plot.png)
</div>

## ⚡ การติดตั้ง
`luminet` มีให้ใช้งานใน PyPI:

```shell
pip install luminet
```

## 📖 [เอกสารประกอบ](https://luminet.readthedocs.io/en/latest/index.html)

## 🔩 การใช้งาน

ตัวแปรทั้งหมดในที่เก็บนี้อยู่ในหน่วยธรรมชาติ: $G=c=1$

```python
from luminet.black_hole import BlackHole
bh = BlackHole(
    mass=1,
    incl=1.5,           # inclination in radians
    acc=1,              # accretion rate
    outer_edge=40
)
```
ในการสร้างภาพ:
```python
ax = bh.plot()          # Create image like above
```
เพื่อสุ่มโฟตอนบนจานสะสมมวล:

```python
bh.sample_photons(100)
bh.photons
```
```
radius  alpha   impact_parameter    z_factor    flux_o
10.2146 5.1946  1.8935              1.1290      1.8596e-05
... (99 more)
```
โปรดทราบว่าการสุ่มตัวอย่างจะมีความเอนเอียงไปยังศูนย์กลางของหลุมดำ เนื่องจากบริเวณนี้เป็นแหล่งกำเนิดความส่องสว่างส่วนใหญ่


## 📝 พื้นหลัง
หลุมดำชวาร์ซชิลด์มีวงโคจรเสถียรใกล้สุดที่ $6M$ และมีทรงกลมโฟตอนที่ $3M$ นี่หมายความว่า
จานสะสมมวลที่โคจรรอบหลุมดำจะปล่อยโฟตอนออกมาที่รัศมี $r>6M$ ตราบเท่าที่ระยะใกล้สุดของโฟตอนในปริภูมิโค้งยังมากกว่า $3M$ (หรือที่เรียกว่าทรงกลมโฟตอน) โฟตอนจะไม่ถูกหลุมดำจับไว้และในทางทฤษฎีสามารถถูกสังเกตได้จากกรอบผู้สังเกตการณ์ $(b, \alpha)$ ความโค้งของปริภูมิ-เวลาอธิบายง่ายที่สุดในฐานะเอฟเฟกต์เลนส์ระหว่างกรอบหลุมดำ $(r, \alpha)$ กับกรอบผู้สังเกตการณ์ $(b, \alpha)$ กรอบแรกคือพิกัดเชิงขั้ว 2D ที่ครอบคลุมพื้นที่ของจานสะสมมวล และกรอบหลังคือพิกัดเชิงขั้ว 2D ที่ครอบคลุม "แผ่นถ่ายภาพ" ของกรอบผู้สังเกตการณ์ ให้นึกถึงกรอบหลังเป็นกล้อง CCD จริงๆ จุดใกล้สุดของวงโคจรโฟตอนและรัศมีในกรอบผู้สังเกตการณ์ $b$ มีความสัมพันธ์กันโดยตรง:

$$b^2 = \frac{P^3}{P-2M}$$

สิ่งนี้ทำให้สมการหลายสมการง่ายขึ้นอย่างมีนัยสำคัญ
คุณอาจสังเกตว่าสมการนี้มีการยกกำลังสองที่ด้านซ้าย ซึ่งต่างจาก Luminet (1979) ต้นฉบับมีข้อผิดพลาดด้านสัญลักษณ์อยู่บ้าง ผมได้ติดต่อผู้เขียนเกี่ยวกับเรื่องนี้ ซึ่งเขาได้ตอบกลับมาอย่างสุภาพว่า:

> "[...] à l’époque je n'avais pas encore l’expérience de relire très soigneusement les épreuves. Mais mes calculs avaient  heureusement été faits avec les bonnes formules, sinon le résultat visuel n’aurait pas été correct!" 
>
>"ในสมัยนั้นผมยังไม่มีนิสัยตรวจทานงานอย่างละเอียด โชคดีที่ผมคำนวณด้วยสูตรที่ถูกต้อง มิฉะนั้นภาพที่ได้คงไม่ถูกต้อง!"

แจ้งไว้เพื่อทราบ ผมพยายามระบุไว้อย่างรอบคอบว่าโค้ดนี้ต่างจากบทความตรงไหน

ความสัมพันธ์ระหว่างมุมของทั้งสองระบบพิกัดนั้นตรงไปตรงมา แต่ความสัมพันธ์ระหว่างรัศมีในสองกรอบอ้างอิงจะให้โดยสมการที่ซับซ้อน Equation 13:

$$\frac{1}{r} = - \frac{Q - P + 2M}{4MP} + \frac{Q-P+6M}{4MP}{sn}^2\left( \frac{\gamma}{2}\sqrt{\frac{Q}{P}} + F(\zeta_\infty, k) \right)$$

ที่นี่ $F$ คืออินทิกรัลเอลลิปติกของจาโคเบียนชนิดไม่สมบูรณ์อันดับหนึ่ง, $k$ และ $Q$ เป็นฟังก์ชันของระยะใกล้สุด $P$, $\zeta$ เป็นฟังก์ชันตรีโกณของ $P$, และ $\gamma$ เป็นไปตาม:

$$\cos(\gamma) = \frac{\cos(\alpha)}{\sqrt{\cos^2\alpha + \cot^2\theta_0}}$$

ในปริภูมิโค้ง มักจะมีวงโคจรโฟตอนหลายวงที่มีจุดกำเนิดเดียวกันและฉายไปยังกรอบผู้สังเกตการณ์ (ดูเช่น เลนส์ความโน้มถ่วงและ Einstein crosses) วงโคจรโฟตอนที่โค้งรอบหลุมดำและไปถึงกรอบผู้สังเกตการณ์เรียกว่า "ภาพลำดับสูง" หรือ "ภาพผี" ในกรณีนี้ $\gamma$ เป็นไปตาม:

$$2n\pi - \gamma = 2\sqrt{\frac{Q}{P}} \left( 2K(k) - F(\zeta_\infty, k) - F(\zeta_r, k)  \right)$$

โฟตอนผีเหล่านี้คือสิ่งที่คุณเห็นในครึ่งล่างของภาพด้านบน รวมถึงเฮโล่ของแสงที่บางมากซึ่งล้อมรอบทรงกลมโฟตอน สำหรับมุมเอียงที่ไม่ขนานขอบมาก ภาพผีนี้จะไม่เด่นชัดนัก

รีโปนี้ใช้ `scipy.optimize.brentq` ในการแก้สมการเหล่านี้ และมี API ที่สะดวกสำหรับแนวคิดที่นำเสนอใน Luminet (1979) คลาส `BlackHole` เป็นคลาสหลักที่ชัดเจน แต่ก็ให้ความรู้หากลองใช้คลาสอื่นๆ เช่น `Isoradial` : เส้นในกรอบผู้สังเกตการณ์ที่อธิบายโฟตอนที่ปล่อยจากรัศมีเดียวกันในกรอบหลุมดำ คลาส `Isoredshift` ให้เส้นของเรดชิฟต์เท่ากันในกรอบผู้สังเกตการณ์

## 📕 บรรณานุกรม
[1] Luminet, J.-P., [“Image of a spherical black hole with thin accretion disk.”](https://ui.adsabs.harvard.edu/abs/1979A%26A....75..228L/abstract), <i>Astronomy and Astrophysics</i>, vol. 75, pp. 228–235, 1979.

[2] J.-P. Luminet, [“An Illustrated History of Black Hole Imaging : Personal Recollections (1972-2002).”](https://arxiv.org/abs/1902.11196) arXiv, 2019. doi: 10.48550/ARXIV.1902.11196. 



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-26

---