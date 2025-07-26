<div align="center">
  
# luminet
![ci-badge](https://img.shields.io/appveyor/build/bgmeulem/luminet?label=ci&style=flat-square) [![PyPI-badge](https://img.shields.io/pypi/v/luminet?pypiBaseUrl=https%3A%2F%2Fpypi.org&style=flat-square&logo=pypi&logoColor=white&link=https%3A%2F%2Fpypi.org%2Fproject%2Fluminet%2F)](https://pypi.org/project/luminet) [![Documentation Status](https://readthedocs.org/projects/luminet/badge/?version=latest&style=flat-square)](https://luminet.readthedocs.io/en/latest/?badge=latest) ![coverage](https://img.shields.io/codecov/c/github/bgmeulem/Luminet?style=flat-square) ![stars-badge](https://img.shields.io/github/stars/bgmeulem/Luminet?style=flat-square) ![license](https://img.shields.io/github/license/bgmeulem/Luminet?style=flat-square) [![Pixi Badge](https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/prefix-dev/pixi/main/assets/badge/v0.json&style=flat-square)](https://pixi.sh)

Mô phỏng và trực quan hóa lỗ đen Swarzschild, dựa trên các phương pháp được mô tả trong Luminet (1979).

![Ví dụ biểu đồ của một lỗ đen](https://raw.githubusercontent.com/bgmeulem/luminet/master/assets/bh_plot.png)
</div>

## ⚡ Cài đặt
`luminet` có sẵn trên PyPI:

```shell
pip install luminet
```

## 📖 [Tài liệu](https://luminet.readthedocs.io/en/latest/index.html)

## 🔩 Cách sử dụng

Tất cả các biến trong kho lưu trữ này đều sử dụng đơn vị tự nhiên: $G=c=1$

```python
from luminet.black_hole import BlackHole
bh = BlackHole(
    mass=1,
    incl=1.5,           # inclination in radians
    acc=1,              # accretion rate
    outer_edge=40
)
```
Để tạo một hình ảnh:
```python
ax = bh.plot()          # Create image like above
```
Để lấy mẫu các photon trên đĩa bồi tụ:

```python
bh.sample_photons(100)
bh.photons
```
```
radius  alpha   impact_parameter    z_factor    flux_o
10.2146 5.1946  1.8935              1.1290      1.8596e-05
... (99 more)
```
Lưu ý rằng việc lấy mẫu bị lệch về phía trung tâm của lỗ đen, vì đây là nơi phát ra phần lớn độ sáng.


## 📝 Bối cảnh
Lỗ đen Schwarzschild có quỹ đạo ổn định trong cùng ở $6M$, và có một mặt cầu photon tại $3M$. Điều này có nghĩa là
đĩa bồi tụ quay quanh lỗ đen phát ra photon tại bán kính $r>6M$. Miễn là cận điểm quỹ đạo của photon trong không-thời gian cong vẫn lớn hơn $3M$ (còn gọi là mặt cầu photon), photon sẽ không bị lỗ đen nuốt chửng và về mặt lý thuyết có thể được nhìn thấy từ một hệ quy chiếu của quan sát viên $(b, \alpha)$. Độ cong không-thời gian dễ dàng được hiểu là hiệu ứng thấu kính giữa hệ quy chiếu lỗ đen $(r, \alpha)$ và hệ quy chiếu quan sát viên $(b, \alpha)$. Hệ đầu tiên là tọa độ cực 2D trải rộng trên vùng đĩa bồi tụ, và hệ thứ hai là tọa độ cực 2D trải rộng trên "mặt ảnh" của hệ quy chiếu quan sát viên. Hãy tưởng tượng hệ thứ hai như một máy ảnh CCD thật sự. Cận điểm quỹ đạo photon và bán kính trong hệ quy chiếu quan sát viên $b$ có liên hệ trực tiếp:

$$b^2 = \frac{P^3}{P-2M}$$

Điều này làm cho nhiều phương trình trở nên đơn giản hơn đáng kể.
Bạn có thể nhận thấy phương trình này có bình phương ở vế trái, khác với Luminet (1979). Bản thảo gốc có một vài lỗi ký hiệu. Tôi đã liên hệ với tác giả về điều này, và ông ấy đã phản hồi thân thiện:

> "[...] à l’époque je n'avais pas encore l’expérience de relire très soigneusement les épreuves. Mais mes calculs avaient  heureusement été faits avec les bonnes formules, sinon le résultat visuel n’aurait pas été correct!" 
>
>"Ngày đó, tôi chưa có thói quen kiểm tra kỹ lưỡng các bản in thử. May mắn thay, tôi đã thực hiện các phép tính với công thức đúng, nếu không thì hình ảnh sẽ không đúng!"

Chỉ để bạn biết thôi. Tôi đã cố gắng ghi chú cẩn thận về những điểm mã này khác với bài báo.

Quan hệ giữa các góc của hai hệ tọa độ là đơn giản, nhưng quan hệ giữa các bán kính trong hai hệ quy chiếu được cho bởi Phương trình 13 khủng khiếp:

$$\frac{1}{r} = - \frac{Q - P + 2M}{4MP} + \frac{Q-P+6M}{4MP}{sn}^2\left( \frac{\gamma}{2}\sqrt{\frac{Q}{P}} + F(\zeta_\infty, k) \right)$$

Ở đây, $F$ là tích phân elliptic Jacobi chưa hoàn chỉnh loại một, $k$ và $Q$ là hàm của cận điểm $P$, $\zeta$ là các hàm lượng giác của $P$, và $\gamma$ thỏa mãn:

$$\cos(\gamma) = \frac{\cos(\alpha)}{\sqrt{\cos^2\alpha + \cot^2\theta_0}}$$

Trong không-thời gian cong, thường có nhiều quỹ đạo photon bắt đầu từ cùng một tọa độ và chiếu lên hệ quy chiếu quan sát viên (xem ví dụ: thấu kính hấp dẫn và thập tự Einstein). Quỹ đạo photon uốn quanh lỗ đen và đến được hệ quy chiếu quan sát viên được gọi là ảnh "bậc cao hơn" hoặc ảnh "ma". Trong trường hợp này, $\gamma$ thỏa mãn:

$$2n\pi - \gamma = 2\sqrt{\frac{Q}{P}} \left( 2K(k) - F(\zeta_\infty, k) - F(\zeta_r, k)  \right)$$

Những photon ma này là những gì bạn thấy ở nửa dưới của hình ảnh trên, cũng như quầng sáng mờ bao quanh sát mặt cầu photon. Với góc nghiêng ít nghiêng hơn, ảnh ma này cũng kém rõ nét hơn.

Repo này sử dụng `scipy.optimize.brentq` để giải các phương trình này, và cung cấp API thuận tiện cho các khái niệm được trình bày trong Luminet (1979). Lớp `BlackHole` là lớp rõ ràng nhất, nhưng cũng rất bổ ích khi thử nghiệm với ví dụ như lớp `Isoradial`: các đường trong hệ quy chiếu quan sát viên mô tả các photon phát ra từ cùng một bán kính trong hệ quy chiếu lỗ đen. Lớp `Isoredshift` cung cấp các đường cùng dịch chuyển đỏ trong hệ quy chiếu quan sát viên.

## 📕 Tài liệu tham khảo
[1] Luminet, J.-P., [“Image of a spherical black hole with thin accretion disk.”](https://ui.adsabs.harvard.edu/abs/1979A%26A....75..228L/abstract), <i>Astronomy and Astrophysics</i>, tập 75, trang 228–235, 1979.

[2] J.-P. Luminet, [“An Illustrated History of Black Hole Imaging : Personal Recollections (1972-2002).”](https://arxiv.org/abs/1902.11196) arXiv, 2019. doi: 10.48550/ARXIV.1902.11196. 



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-26

---