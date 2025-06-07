# kkTerminal

> kkTerminal, Web SSH bağlantısı için bir terminal
>
> Yazar: [zyyzyykk](https://github.com/zyyzyykk/)
>
> Kaynak Kodu: https://github.com/zyyzyykk/kkTerminal
>
> Docker Hub Adresi: https://hub.docker.com/repository/docker/zyyzyykk/kkterminal/general
>
> Önizleme: https://ssh.kkbpro.com/
>
> Güncelleme Zamanı: 2025-03-15
>

<p align="center"><a href="https://ssh.kkbpro.com/" target="_blank" rel="noopener noreferrer"><img width="100" src="https://kkbapps.oss-cn-shanghai.aliyuncs.com/logo/terminal.png" alt="kkTerminal"></a></p>

<p align="center">
  <a href="https://hub.docker.com/repository/docker/zyyzyykk/kkterminal/general"><img src="https://img.shields.io/docker/pulls/zyyzyykk/kkterminal?logo=docker" alt="Docker Image"></a>
  <a href="https://www.oracle.com/cn/java/technologies/downloads/#java8-windows"><img src="https://img.shields.io/badge/jdk-1.8-orange?logo=openjdk&logoColor=%23e3731c" alt="JDK Version"></a>
  <a href="https://spring.io/projects/spring-boot"><img src="https://img.shields.io/badge/springboot-2.7.15-green?color=6db33f&logo=springboot" alt="SpringBoot Version"></a>
  <a href="https://cn.vuejs.org/"><img src="https://img.shields.io/badge/vue-3.x-green?color=42b883&logo=vue.js" alt="Vue Version"></a>
  <a href="https://www.apache.org/licenses/"><img src="https://img.shields.io/badge/licence-Apache-red?logo=apache&logoColor=%23D22128" alt="Apache Licence"></a>
  <a href="https://github.com/zyyzyykk/kkTerminal"><img src="https://img.shields.io/github/stars/zyyzyykk/kkterminal" alt="GitHub"></a>
</p>
<p align="center">English ｜ <a href="https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/zh_CN/README.md" >简体中文</a></p>

### ⚡ Hızlı Entegrasyon

HTML web sayfalarında `iframe` etiketi kullanarak hızlı entegrasyon:

```html
<iframe src="https://ssh.kkbpro.com/" height="400px" width="600px" ></iframe>
```

### 🐳 Docker ile Dağıtım

1. İmajı çekin:

```bash
docker pull zyyzyykk/kkterminal
```

2. Port eşlemesiyle bir konteyner oluşturup çalıştırın: `-p port:3000`

```bash
docker run -d --name kkterminal -p 3000:3000 zyyzyykk/kkterminal
```

3. Özel sanat yazısı: `-e TITLE="ArtWord"`

```bash
docker run -d --name kkterminal -p 3000:3000 -e TITLE="kkbpro" zyyzyykk/kkterminal
```

4. Tarayıcıdan erişim: `http://server-ip:3000/`

### 🛸 Önizleme

Aşağıdaki web sitesini ziyaret edin: https://ssh.kkbpro.com/

![Connect](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/Connect.png)

![Preference](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/Preference.png)

![File](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/File.png)

![Editor](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/Editor.png)

[**Daha Fazla Modül Önizlemesi**](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/MODULE.md)

### 💡 Fonksiyon Açıklaması

1. kkTerminal, Web SSH bağlantısı için bir terminaldir. Sol üst köşedeki terminal simgesine tıklayın ve bağlantı ayarlarını seçerek bir SSH bağlantısı kurun

2. Web sayfalarında `iframe` etiketinin kullanılmasını destekler ve üçüncü parti sitelere hızlı entegrasyon sağlar

3. [URL Parametreleri](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/PARAMS.md) aracılığıyla terminal yapılandırmasının özelleştirilmesini destekler

4. Uluslararasılaştırma ve Çince-İngilizce dil geçişini destekler

5. Yerel PC kurulumunu destekler, başlatıldığında otomatik olarak tarayıcı penceresini açar

6. Uyumlu pencere boyutu ve Çince giriş desteği

7. Arka plan/ön plan rengi, yazı tipi boyutu, imleç gösterim stili, terminalde TCode etkinleştirme gibi özel tercihler ayarlanabilir

8. Yeniden başlatma desteği: SSH bağlantı ayarlarını veya özel tercihleri değiştirdikten sonra otomatik olarak yeniden başlatılır, veya SSH bağlantısı kesildikten sonra manuel olarak yeniden başlatılabilir

9. Kopyala ve yapıştır desteği:

   - Kopyala: `Git` terminalinde olduğu gibi, metni seçtiğinizde otomatik olarak kopyalanır

   - Yapıştır: `Cmd` terminalinde olduğu gibi, sağ tıklayarak yapıştırılır (tarayıcı erişim izni gerektirir)

9. Dosya yönetimini destekler, Dosya Yönetimi Modülünü açarak dosya/klasörleri görüntüleyin, sıkıştırmasını açın, yükleyin ve indirin

10. Birden çok/tüm dosya seçimi, kopyala & yapıştır, kes, seçim değiştir, aç gibi kısayol tuş işlemlerini destekler

11. Dosya gezintisi ve düzenlemesini destekler, dosyayı değiştirip `ctrl+s` ile uzak sunucuya kaydedin

12. [TCode (Terminal Code)](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/TCODE.md) desteği, Özelleştirilmiş TCode ile Shell betiklerine benzer otomatikleştirilmiş İş Akışı elde edilebilir

13. İşlem kaydı ve bulut senkronizasyon fonksiyonlarını destekler

14. İşbirliği, İzleme ve Docker fonksiyonlarını destekler

### 👨‍💻 Güncelleme Kayıtları

##### zyyzyykk/kkterminal:3.6.0: latest

- Gelişmiş İşbirliği fonksiyonu eklendi
- Gelişmiş İzleme fonksiyonu eklendi
- Gelişmiş Docker fonksiyonu eklendi
- Paket hacmi ve web sayfası gösterimi optimize edildi

##### zyyzyykk/kkterminal:3.5.6: 

- Daha fazla URL parametresi desteği eklendi
- Editör metni & görsel boyut yüzdesi eklendi
- Web sayfası gösterimi optimize edildi

##### zyyzyykk/kkterminal:3.5.3: 

- Terminal yapılandırmasını özelleştirmek için URL parametresi eklendi
- Çoklu pencere yeniden başlatma hatası düzeltildi
- İşlem kaydı ve bulut senkronizasyon fonksiyonları eklendi
- Bazı kod mantığı yeniden düzenlendi

[**Geçmiş Güncelleme Kayıtları**](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/UPDATE.md)

### 🧬 Mimari

```markdown
+---------+     http      +-------------+    ssh     +---------------+
| browser | <===========> | kk Terminal | <========> | remote server |
+---------+   websocket   +-------------+    sftp    +---------------+
Vue + Xterm              SpringBoot + SSHJ                Linux OS    
```

### 🏘️ Bu Proje Hakkında

Değerli Kullanıcılar,

Sınırlı zaman ve enerji nedeniyle, gelecekte `kkTerminal` üzerinde bakım yapamayacağımı üzülerek bildiriyorum.

`kkTerminal` ile ilgileniyorsanız veya bakımı devam ettirmek istiyorsanız, lütfen benimle iletişime geçin ya da bir issue oluşturun.

Hata bulursanız veya yeni özellikler geliştirmek isterseniz, lütfen issue açın.

Son olarak, `kkTerminal`e verdiğiniz destek için teşekkür ederim ve samimiyetle umuyorum ki `kkTerminal` size gerçekten yardımcı olur.

Saygılarımla,

[zyyzyykk](https://github.com/zyyzyykk/)

2025.03.15

### 🌟 Yıldızlar

[![Stars](https://starchart.cc/zyyzyykk/kkTerminal.svg?variant=adaptive)](https://starchart.cc/zyyzyykk/kkTerminal)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---