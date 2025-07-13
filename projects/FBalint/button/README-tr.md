# 3D Basılabilir Buton

HTML, CSS ve SVG ile oluşturulmuş, fiziksel bir düğmeye basma hissini simüle eden gerçekçi bir 3D buton bileşeni. Buton, akıcı animasyonlar, özelleştirilebilir renkler ve duyarlı etkileşimler sunar.

Oluşturan: [@BalintFerenczy](https://x.com/BalintFerenczy)

İlham kaynağı: [Resend](https://resend.com/) sitesindeki harika çalışmalar

## Özellikler

- **Gerçekçi 3D görünüm** katmanlı SVG grafikleriyle
- **Akıcı animasyonlar** özel kolaylaştırma fonksiyonları ile
- **Etkileşimli durumlar** - üzerine gelme ve basma efektleri
- **Özelleştirilebilir renkler** CSS değişkenleri ile
- **Duyarlı tasarım** konteyner boyutuna göre ölçeklenir

## Demo
Buton, kullanıcı etkileşimlerine üç farklı durumda yanıt verir:
- **Normal**: Butonun dinlenme pozisyonu
- **Üzerine Gelindiğinde (Hover)**: Fare butonun üzerine geldiğinde hafif bir aşağı hareket
- **Aktif**: Basıldığında/tıklandığında belirgin bir aşağı hareket

## Kullanım

### Özelleştirme

Buton, CSS özel değişkenleri kullanılarak kolayca özelleştirilebilir:

```css
.frame {
    /* Buton boyutları */
    width: 400px; 
    height: 400px; 

    /* Hareket mesafeleri */
    --hover-travel: 3px;
    --press-travel: 40px;
    
    /* Renk özelleştirme */
    --color: black;
    --brightness: 1;
    --blend-mode: color;

    /* Geçiş ayarları */
    --transition-duration: 0.4s;
    --transition-easing: ease-in-out;
}
```
#### Buton Metnini Değiştirme

Sadece metin içeriğini değiştirin:

```html
<p class="text">Bana Tıkla!</p>
```

#### Buton Boyutunu Değiştirme

Çerçeve boyutlarını ayarlayın:

```css
.frame {
    width: 200px;
    height: 200px;
}
```
## Lisans

Bu proje açık kaynaklıdır ve MIT Lisansı altında sunulmaktadır.

## Katkıda Bulunma

Bu projeyi çatallamaktan ve iyileştirmeler veya yeni özellikler için pull request göndermekten çekinmeyin!

## Yazar

Oluşturan: [@BalintFerenczy](https://x.com/BalintFerenczy)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---