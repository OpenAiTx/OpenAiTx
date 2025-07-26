<div align="center">
  
# luminet
![ci-badge](https://img.shields.io/appveyor/build/bgmeulem/luminet?label=ci&style=flat-square) [![PyPI-badge](https://img.shields.io/pypi/v/luminet?pypiBaseUrl=https%3A%2F%2Fpypi.org&style=flat-square&logo=pypi&logoColor=white&link=https%3A%2F%2Fpypi.org%2Fproject%2Fluminet%2F)](https://pypi.org/project/luminet) [![Documentation Status](https://readthedocs.org/projects/luminet/badge/?version=latest&style=flat-square)](https://luminet.readthedocs.io/en/latest/?badge=latest) ![coverage](https://img.shields.io/codecov/c/github/bgmeulem/Luminet?style=flat-square) ![stars-badge](https://img.shields.io/github/stars/bgmeulem/Luminet?style=flat-square) ![license](https://img.shields.io/github/license/bgmeulem/Luminet?style=flat-square) [![Pixi Badge](https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/prefix-dev/pixi/main/assets/badge/v0.json&style=flat-square)](https://pixi.sh)

Luminet (1979)'da açıklanan yöntemlere dayanarak Swarzschild kara deliklerini simüle edin ve görselleştirin.

![Bir kara deliğin örnek grafiği](https://raw.githubusercontent.com/bgmeulem/luminet/master/assets/bh_plot.png)
</div>

## ⚡ Kurulum
`luminet` PyPI üzerinden kullanılabilir:

```shell
pip install luminet
```

## 📖 [Dokümantasyon](https://luminet.readthedocs.io/en/latest/index.html)

## 🔩 Kullanım

Bu depodaki tüm değişkenler doğal birimlerle verilmiştir: $G=c=1$

```python
from luminet.black_hole import BlackHole
bh = BlackHole(
    mass=1,
    incl=1.5,           # inclination in radians
    acc=1,              # accretion rate
    outer_edge=40
)
```
Bir görüntü oluşturmak için:
```python
ax = bh.plot()          # Create image like above
```
Yığılma diski üzerinde foton örneklemek için:

```python
bh.sample_photons(100)
bh.photons
```
```
radius  alpha   impact_parameter    z_factor    flux_o
10.2146 5.1946  1.8935              1.1290      1.8596e-05
... (99 more)
```

Örneklemenin kara deliğin merkezine doğru önyargılı olduğunu unutmayın, çünkü ışınımın büyük kısmı buradan gelir.


## 📝 Arka Plan
Swarzschild kara deliklerinde en içteki kararlı yörünge $6M$'dir ve bir foton küresi $3M$'de bulunur. Bu, kara deliğin etrafında dönen akresyon diskinden fotonların $r>6M$ yarıçaplarında yayıldığı anlamına gelir. Eğri uzayda fotonun yerberi noktası $3M$'den (foton küresi de denir) büyük kaldığı sürece, foton kara delik tarafından yakalanmaz ve teorik olarak bir gözlemci çerçevesinden $(b, \alpha)$ görülebilir. Uzayzaman eğriliği, en kolay kara delik çerçevesi $(r, \alpha)$ ile gözlemci çerçevesi $(b, \alpha)$ arasındaki bir mercek etkisi olarak yorumlanabilir. İlki, akresyon diski alanını kapsayan 2 boyutlu kutupsal koordinatlardır ve ikincisi, gözlemci çerçevesinin "fotoğraf plakası"nı kapsayan 2 boyutlu kutupsal koordinatlardır. Bunu gerçek bir CCD kamera olarak düşünebilirsiniz. Foton yörüngesinin yerberi noktası ile gözlemci çerçevesindeki yarıçap $b$ doğrudan ilişkilidir:

$$b^2 = \frac{P^3}{P-2M}$$

Bu, birçok denklemi önemli ölçüde daha basit hale getirir.
Bu denklemin sol tarafında bir kare olduğunu fark edebilirsiniz, bu Luminet (1979)'dan farklıdır. Orijinal makalede bir dizi gösterim hatası vardır. Bununla ilgili olarak yazarla iletişime geçtim, kendisi nazikçe şöyle yanıtladı:

> "[...] à l’époque je n'avais pas encore l’expérience de relire très soigneusement les épreuves. Mais mes calculs avaient  heureusement été faits avec les bonnes formules, sinon le résultat visuel n’aurait pas été correct!" 
>
>"O zamanlar provaları dikkatlice tekrar kontrol etme alışkanlığım yoktu. Neyse ki sonuçları doğru formüllerle hesaplamıştım, aksi takdirde görsel sonuç doğru olmazdı!".

Bilginiz olsun. Bu kodun makaleden nerede farklılaştığını not etmeye özen gösterdim.

Her iki koordinat sisteminin açıları arasındaki ilişki önemsizdir, ancak iki referans çerçevesindeki yarıçaplar arasındaki ilişki, korkunç 13. Denklemle verilir:

$$\frac{1}{r} = - \frac{Q - P + 2M}{4MP} + \frac{Q-P+6M}{4MP}{sn}^2\left( \frac{\gamma}{2}\sqrt{\frac{Q}{P}} + F(\zeta_\infty, k) \right)$$

Burada $F$, birinci türden eksik Jacobian eliptik integralidir, $k$ ve $Q$ yerberi noktası $P$'nin bir fonksiyonudur, $\zeta$ ise $P$'nin trigonometrik fonksiyonlarıdır ve $\gamma$ şunu sağlar:

$$\cos(\gamma) = \frac{\cos(\alpha)}{\sqrt{\cos^2\alpha + \cot^2\theta_0}}$$

Eğri uzayzamanda, genellikle aynı koordinattan kaynaklanıp gözlemci çerçevesine yansıtılan birden fazla foton yörüngesi vardır (bkz. örn. kütleçekimsel merceklenme ve Einstein haçları). Kara deliğin etrafında kıvrılıp gözlemci çerçevesine ulaşan foton yörüngelerine "daha yüksek mertebeden" görüntüler veya "hayalet" görüntüler denir. Bu durumda, $\gamma$ şunu sağlar:

$$2n\pi - \gamma = 2\sqrt{\frac{Q}{P}} \left( 2K(k) - F(\zeta_\infty, k) - F(\zeta_r, k)  \right)$$

Bu hayalet fotonlar, yukarıdaki görüntünün alt yarısında gördüğünüz şeydir ve ayrıca foton küresinin etrafını ince bir şekilde saran zar zor görülebilen ışık halesidir. Daha az kenardan bakılan eğimlerde bu hayalet görüntü daha az belirgindir.

Bu depo, bu denklemleri çözmek için `scipy.optimize.brentq` kullanır ve Luminet (1979)'da sunulan kavramlara uygun API sağlar. En belirgin olanı `BlackHole` sınıfıdır, ancak örneğin `Isoradial` sınıfı ile oynamak da öğreticidir: kara delik çerçevesinde aynı yarıçaptan yayılan fotonları tanımlayan gözlemci çerçevesindeki çizgiler. `Isoredshift` sınıfı, gözlemci çerçevesinde eşit kırmızıya kayma çizgileri sağlar.

## 📕 Kaynakça
[1] Luminet, J.-P., [“Image of a spherical black hole with thin accretion disk.”](https://ui.adsabs.harvard.edu/abs/1979A%26A....75..228L/abstract), <i>Astronomy and Astrophysics</i>, cilt 75, ss. 228–235, 1979.

[2] J.-P. Luminet, [“An Illustrated History of Black Hole Imaging : Personal Recollections (1972-2002).”](https://arxiv.org/abs/1902.11196) arXiv, 2019. doi: 10.48550/ARXIV.1902.11196. 



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-26

---