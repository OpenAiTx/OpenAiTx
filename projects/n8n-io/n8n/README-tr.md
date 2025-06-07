![Banner image](https://user-images.githubusercontent.com/10284570/173569848-c624317f-42b1-45a6-ab09-f0ea3c247648.png)

# n8n - Teknik Ekipler için Güvenli İş Akışı Otomasyonu

n8n, teknik ekiplere kod esnekliği ile kodsuz hızını bir arada sunan bir iş akışı otomasyon platformudur. 400+ entegrasyon, yerleşik yapay zeka yetenekleri ve adil-kod lisansı ile n8n, güçlü otomasyonlar oluşturmanızı sağlarken verileriniz ve dağıtımlarınız üzerinde tam kontrol sahibi olmanızı sağlar.

![n8n.io - Ekran Görüntüsü](https://raw.githubusercontent.com/n8n-io/n8n/master/assets/n8n-screenshot-readme.png)

## Temel Özellikler

- **İhtiyacın Olduğunda Kod Yaz**: JavaScript/Python yaz, npm paketleri ekle veya görsel arayüzü kullan
- **Yapay Zeka-Tabanlı Platform**: Kendi verileriniz ve modellerinizle LangChain tabanlı yapay zeka ajan iş akışları oluşturun
- **Tam Kontrol**: Adil-kod lisansımız ile kendi sunucunuzda barındırın veya [bulut hizmetimizi](https://app.n8n.cloud/login) kullanın
- **Kurumsal Hazır**: Gelişmiş izinler, SSO ve izole dağıtımlar
- **Aktif Topluluk**: 400+ entegrasyon ve kullanıma hazır 900+ [şablon](https://n8n.io/workflows)

## Hızlı Başlangıç

[npx](https://docs.n8n.io/hosting/installation/npm/) ile n8n'i anında deneyin ([Node.js](https://nodejs.org/en/) gerektirir):

```
npx n8n
```

Veya [Docker](https://docs.n8n.io/hosting/installation/docker/) ile dağıtın:

```
docker volume create n8n_data
docker run -it --rm --name n8n -p 5678:5678 -v n8n_data:/home/node/.n8n docker.n8n.io/n8nio/n8n
```

Editöre http://localhost:5678 adresinden erişin

## Kaynaklar

- 📚 [Dokümantasyon](https://docs.n8n.io)
- 🔧 [400+ Entegrasyon](https://n8n.io/integrations)
- 💡 [Örnek İş Akışları](https://n8n.io/workflows)
- 🤖 [Yapay Zeka & LangChain Rehberi](https://docs.n8n.io/langchain/)
- 👥 [Topluluk Forumu](https://community.n8n.io)
- 📖 [Topluluk Eğitimleri](https://community.n8n.io/c/tutorials/28)

## Destek

Yardıma mı ihtiyacınız var? Topluluk forumumuzdan destek alabilir ve diğer kullanıcılarla bağlantı kurabilirsiniz:
[community.n8n.io](https://community.n8n.io)

## Lisans

n8n, [fair-code](https://faircode.io) kapsamında [Sürdürülebilir Kullanım Lisansı](https://github.com/n8n-io/n8n/blob/master/LICENSE.md) ve [n8n Enterprise Lisansı](https://github.com/n8n-io/n8n/blob/master/LICENSE_EE.md) ile dağıtılmaktadır.

- **Kaynak Kod Görünür**: Kaynak kodu her zaman görüntülenebilir
- **Kendi Sunucunda Barındır**: Her yerde dağıtılabilir
- **Genişletilebilir**: Kendi düğümlerinizi ve işlevlerinizi ekleyin

Ek özellikler ve destek için [kurumsal lisanslar](mailto:license@n8n.io) mevcuttur.

Lisans modeliyle ilgili ek bilgiye [dokümantasyon](https://docs.n8n.io/reference/license/) üzerinden ulaşabilirsiniz.

## Katkıda Bulunun

Bir hata mı buldunuz 🐛 veya bir özellik fikriniz mi var ✨? Başlamak için [Katkı Rehberimize](https://github.com/n8n-io/n8n/blob/master/CONTRIBUTING.md) göz atın.

## Ekibe Katılın

Otomasyonun geleceğini şekillendirmek ister misiniz? [İş ilanlarımıza](https://n8n.io/careers) göz atın ve ekibimize katılın!

## n8n ne anlama geliyor?

**Kısa cevap:** "nodemation" anlamına gelir ve "n-eight-n" şeklinde telaffuz edilir.

**Uzun cevap:** "Bu soruyu oldukça sık alıyorum (beklediğimden daha sık) bu yüzden en iyisi burada yanıtlamak diye düşündüm. Proje için iyi bir isim ve boş bir alan adı ararken, aklıma gelen tüm iyi isimlerin zaten alınmış olduğunu çok hızlı fark ettim. Sonunda, nodemation'ı seçtim. 'node-', Node-View kullandığı ve Node.js üzerine kurulu olduğu için, '-mation' ise 'automation' (otomasyon) kısmı, yani projenin yardımcı olmayı amaçladığı şey. Ancak, ismin uzunluğunu beğenmedim ve CLI'da her seferinde bu kadar uzun bir şey yazmayı hayal edemedim. Sonunda 'n8n' ismine böyle ulaştım." - **Jan Oberhauser, Kurucu ve CEO, n8n.io**

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---