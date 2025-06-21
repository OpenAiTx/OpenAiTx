# KestrelApp
Kestrel tabanlı ağ programlama uygulama örneği

### 1 Proje Amacı
1. Ağ programlamanın artık Socket ile başlamak zorunda olmadığını anlamak
2. Ağ programlamanın artık üçüncü parti çerçevelere (Dotnetty dahil) ihtiyaç duymadığını anlamak
3. `telnet` over `websocket` over `tls` over `xxx özel şifreleme` over `tcp` şeklindeki iç içe geçmiş ağ programlamayı anlamak
4. KestrelFramework tabanlı ağ uygulamaları geliştirebilmek

### 2 Dokümantasyon
**Dahili Dokümanlar**：[docs](https://raw.githubusercontent.com/xljiulang/KestrelApp/master/docs)

**Harici Dokümanlar**
* [Pipelines](https://learn.microsoft.com/zh-cn/dotnet/standard/io/pipelines)
* [Buffers](https://learn.microsoft.com/zh-cn/dotnet/standard/io/buffers)

### 3 KestrelFramework
Kestrel ağ programlaması için bazı gerekli temel kütüphaneler
1. Kestrel ara katman arayüzü ve ara katman kaydı
2. System.Buffers: Arabellek (buffer) işlemleri sınıfı
3. System.IO: Akış (stream) işlemleri sınıfı
4. System.IO.Pipelines: Çift yönlü boru hattı işlemleri sınıfı
5. Middleware: Kestrel’e ait bazı ara katmanlar

### 4 KestrelApp
Kestrel uygulaması, içeriği şunları kapsar
1. Dinlenecek EndPoint’in yapılandırılması
2. EndPoint’in kullanacağı protokolün yapılandırılması

### 5 KestrelApp.Middleware
KestrelApp’in ara katman sınıf kütüphanesi
#### 5.1 Echo
Basit Echo uygulama protokolü örneği

#### 5.2 FlowAnalyze
Taşıma katmanı trafik istatistikleri ara katman örneği

#### 5.3 FlowXor
Taşıma katmanı trafiği XOR işleme ara katman örneği

#### 5.4 HttpProxy
http proxy uygulama protokolü örneği

#### 5.5 Telnet
Basit Telnet uygulama protokolü örneği

#### 5.6 TelnetProxy
Trafiğin telnet sunucusuna yönlendirildiği örnek

#### 5.6 Redis
redis protokol sunucusu, uygulama ara katmanının nasıl kullanılacağını gösteren örnek

### Açık Kaynak Seninle Daha Güzel
![Bağış](https://raw.githubusercontent.com/xljiulang/KestrelApp/master/reward.png)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-21

---