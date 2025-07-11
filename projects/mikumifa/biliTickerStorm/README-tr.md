# 🎫 BiliTickerStorm

## ⚙️ Hizmet Açıklaması

| Hizmet Adı            | Açıklama                 | Not     |
| ------------------- | --------------------- | ------ |
| `ticket-master`     | Ana kontrol hizmeti, görevleri planlar | Tekli örnek dağıtımı |
| `ticket-worker`     | Bilet yakalama worker'ı, yatay ölçeklenebilir | Çoklu örnek destekler |
| `gt-python`         | Grafik doğrulama kodu işleme hizmeti       | Tekli örnek dağıtımı |

---

## 🚀 Hızlı Dağıtım Adımları

> Küme kurulumunu [Küme Kurulum Kılavuzu](https://raw.githubusercontent.com/mikumifa/biliTickerStorm/main/docs/集群搭建参考.md) adresinden inceleyebilirsiniz.

<details> <summary><strong>📦 Uzaktan Depo ile Kurulum (Tavsiye Edilir)</strong></summary>

```bash
helm repo add bili-ticker-storm https://mikumifa.github.io/biliTickerStorm/
helm repo update
```
### 2. Chart'ı Kurma

```bash
helm install bili-ticker-storm bili-ticker-storm/bili-ticker-storm \
  --set ticketMaster.hostDataPath=/your/host/data/path \
  --set ticketWorker.pushplusToken="your_token" \
  --set ticketWorker.ticketInterval="300" \
  --set ticketWorker.ticketTimeStart="2025-05-20T13:14"
  
```

> - `hostDataPath` bilet alma yapılandırma dosyası dizinidir, `ticket-master` konteynerine mount edilir. Bilet alma yapılandırma dosyası oluşturmak için https://github.com/mikumifa/biliTickerBuy kullanılır.
> - `ticketWorker.pushplusToken` pushplus bildirim yapılandırmasıdır, ayarlandığında bilet alma sonuç bildirimlerini alabilirsiniz.
> - `ticketWorker.ticketInterval` bilet alma aralığı saniyesidir, varsayılan olarak 300 milisaniyedir.
> - `ticketWorker.ticketTimeStart` zamanlanmış başlatma zamanıdır, formatı `2025-05-20T13:14` şeklindedir, boş bırakılırsa konteyner açılır açılmaz bilet alma başlar.

### 3. Chart'ı Yükseltme

```bash
helm upgrade bili-ticker-storm bili-ticker-storm/bili-ticker-storm --reuse-values \
  --set ticketWorker.ticketInterval="600"
```
</details> 
<details> <summary><strong>📦 Yerel Chart Kurulumu</strong></summary>


### 1. Chart'ı Kurma

```bash
# Depoyu klonlayın
git clone https://github.com/mikumifa/biliTickerStorm
# Yerel Chart paketini kullanın
helm install bili-ticker-storm ./helm \
  --set ticketMaster.hostDataPath=/your/host/data/path \
  --set ticketWorker.pushplusToken="your_token" \
  --set ticketWorker.ticketInterval="300" \
  --set ticketWorker.ticketTimeStart="2025-05-20T13:14"
```
### 2. Chart'ı Güncelleme

```bash
helm upgrade bili-ticker-storm ./helm --reuse-values
```
</details>
<details>
<summary><strong>📌 Genel Komutlar</strong></summary>

### ⏹ Kaldırma
```bash
helm uninstall bili-ticker-storm
```
</details>


## 📩 Sorumluluk Reddi

Bu proje MIT Lisansı altında lisanslanmıştır ve yalnızca kişisel öğrenme ve araştırma amaçlı kullanılmalıdır. Lütfen bu projeyi herhangi bir ticari kazanç amacıyla kullanmayınız; ayrıca, herhangi bir şekilde bilet kapma, yasa dışı faaliyetler veya ilgili platform kurallarını ihlal eden amaçlar için kullanılması kesinlikle yasaktır. Bu nedenle doğabilecek tüm sonuçlardan kullanıcı kendisi sorumludur, şahsımla hiçbir ilgisi yoktur.

Bu projeyi fork ediyorsanız veya kullanıyorsanız, lütfen ilgili yasa ve yönetmeliklere ve hedef platformun kurallarına mutlaka uyunuz.

## 💡 Erişim Sıklığı ve Eşzamanlılık Kontrolü Hakkında
Bu proje tasarlanırken kesinlikle “girişimsiz” ilkesine uyulmuş ve hedef sunucularda (örneğin Bilibili) herhangi bir rahatsızlığa neden olmamaya özen gösterilmiştir.

Tüm ağ isteklerinin zaman aralığı kullanıcı tarafından yapılandırılır; varsayılan değerler, normal bir kullanıcının manuel işlem hızını taklit eder. Program varsayılan olarak tek iş parçacığında çalışır ve eşzamanlı görev içermez. İstek başarısız olduğunda, program sınırlı sayıda yeniden deneme yapar ve yeniden denemeler arasında uygun gecikmeler ekler, böylece yüksek frekansta istek gönderilmesinin önüne geçer. Proje tamamen platformun halka açık arayüzleri ve web sayfası yapısına dayanır, risk kontrolünden kaçınma, API ele geçirme gibi zararlı yöntemler içermez.
## 🛡️ Platforma Saygı Beyanı

Bu program tasarlanırken istek sıklığı mümkün olduğunca kontrol edilmiştir, Bilibili sunucularına herhangi bir belirgin yük veya etki oluşturmaktan kaçınılmıştır. Proje yalnızca öğrenme amacıyla kullanılmaktadır, büyük ölçekli veya yüksek eşzamanlı kapasiteye sahip değildir ve herhangi bir kötü niyetli davranış veya hizmeti engelleme amacı bulunmamaktadır.

Eğer bu projede Bilibili şirketinin yasal haklarını ihlal eden bir içerik bulunuyorsa, lütfen [1055069518@qq.com](https://raw.githubusercontent.com/mikumifa/biliTickerStorm/main/mailto:1055069518@qq.com) adresinden benimle iletişime geçin. İlgili içeriği en kısa sürede kaldırıp bu depoyu sileceğim. Bu durumun neden olabileceği rahatsızlıktan dolayı içtenlikle özür diler, anlayışınız ve hoşgörünüz için teşekkür ederim.

## 📄 Lisans

[MIT Lisansı](LICENSE)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-11

---