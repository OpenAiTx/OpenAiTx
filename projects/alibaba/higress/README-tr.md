<a name="readme-top"></a>
<h1 align="center">
    <img src="https://img.alicdn.com/imgextra/i2/O1CN01NwxLDd20nxfGBjxmZ_!!6000000006895-2-tps-960-290.png" alt="Higress" width="240" height="72.5">
  <br>
  AI Gateway
</h1>
<h4 align="center"> AI Doğal API Geçidi </h4>

<div align="center">
    
[![Build Status](https://github.com/alibaba/higress/actions/workflows/build-and-test.yaml/badge.svg?branch=main)](https://github.com/alibaba/higress/actions)
[![license](https://img.shields.io/github/license/alibaba/higress.svg)](https://www.apache.org/licenses/LICENSE-2.0.html)
[![discord](https://img.shields.io/discord/1364956090566971515?color=5865F2&label=discord&labelColor=black&logo=discord&logoColor=white&style=flat-square)](https://discord.gg/tSbww9VDaM)

<a href="https://trendshift.io/repositories/10918" target="_blank"><img src="https://trendshift.io/api/badge/repositories/10918" alt="alibaba%2Fhigress | Trendshift" style="width: 250px; height: 55px;" width="250" height="55"/></a> <a href="https://www.producthunt.com/posts/higress?embed=true&utm_source=badge-featured&utm_medium=badge&utm_souce=badge-higress" target="_blank"><img src="https://api.producthunt.com/widgets/embed-image/v1/featured.svg?post_id=951287&theme=light&t=1745492822283" alt="Higress - Global&#0032;APIs&#0032;as&#0032;MCP&#0032;powered&#0032;by&#0032;AI&#0032;Gateway | Product Hunt" style="width: 250px; height: 54px;" width="250" height="54" /></a>

</div>

[**Resmi Site**](https://higress.ai/en/) &nbsp; |
&nbsp; [**MCP Sunucu Hızlı Başlangıç**](https://higress.cn/en/ai/mcp-quick-start/) &nbsp; |
&nbsp; [**Wasm Eklenti Merkezi**](https://higress.cn/en/plugin/) &nbsp; |

<p>
   English | <a href="README_ZH.md">中文<a/> | <a href="README_JP.md">日本語<a/>
</p>

## Higress Nedir?

Higress, Go/Rust/JS ile yazılmış Wasm eklentileriyle genişletilebilen, Istio ve Envoy tabanlı bulut-yerel bir API geçididir. Kullanmaya hazır onlarca genel amaçlı eklenti ve kutudan çıktığı gibi kullanılabilen bir konsol sunar ([demoyu buradan deneyin](http://demo.higress.io/)).

### Temel Kullanım Alanları

Higress’in AI geçidi yetenekleri, [ana akım model sağlayıcılarını](https://raw.githubusercontent.com/alibaba/higress/main/plugins/wasm-go/extensions/ai-proxy/provider) hem yurtiçi hem de yurtdışında destekler. Ayrıca eklenti mekanizması sayesinde MCP (Model Context Protocol) Sunucularını barındırabilir, böylece AI Agent’lerin çeşitli araç ve servisleri kolayca çağırmasını sağlar. [openapi-to-mcp aracı](https://github.com/higress-group/openapi-to-mcpserver) ile OpenAPI tanımlarını uzaktaki MCP sunucularına hızla dönüştürebilirsiniz. Higress, hem LLM API hem de MCP API için birleşik yönetim sunar.

**🌟 Şimdi deneyin: [https://mcp.higress.ai/](https://mcp.higress.ai/)** ve Higress tarafından barındırılan Uzaktan MCP Sunucularını ilk elden deneyimleyin:

![Higress MCP Sunucu Platformu](https://img.alicdn.com/imgextra/i2/O1CN01nmVa0a1aChgpyyWOX_!!6000000003294-0-tps-3430-1742.jpg)

### Kurumsal Kullanım

Higress, Alibaba içerisinde Tengine yeniden yüklemesinin uzun bağlantılı servisleri etkilemesi ve gRPC/Dubbo için yetersiz yük dengeleme yeteneklerini çözmek amacıyla doğmuştur. Alibaba Cloud’da, Higress’in AI geçidi yetenekleri, Tongyi Bailian model stüdyosu, makine öğrenimi PAI platformu ve diğer kritik AI servisleri gibi çekirdek AI uygulamalarını destekler. Alibaba Cloud, Higress tabanlı bulut-yerel API geçidi ürünüyle, çok sayıda kurumsal müşterisine %99,99 geçit yüksek erişilebilirlik garantisi sağlar.

## Özet

- [**Hızlı Başlangıç**](#quick-start)    
- [**Özellik Tanıtımı**](#feature-showcase)
- [**Kullanım Senaryoları**](#use-cases)
- [**Temel Avantajlar**](#core-advantages)
- [**Topluluk**](#community)

## Hızlı Başlangıç

Higress, sadece Docker ile başlatılabilir, böylece bireysel geliştiriciler için yerelde öğrenme veya basit siteler kurmak için oldukça uygundur:

```bash
# Çalışma dizini oluşturun
mkdir higress; cd higress
# Higress'i başlatın, yapılandırma dosyaları çalışma dizinine yazılacaktır
docker run -d --rm --name higress-ai -v ${PWD}:/data \
        -p 8001:8001 -p 8080:8080 -p 8443:8443  \
        higress-registry.cn-hangzhou.cr.aliyuncs.com/higress/all-in-one:latest
```

Port açıklamaları:

- 8001 Portu: Higress UI konsol girişi
- 8080 Portu: Geçit HTTP protokol girişi
- 8443 Portu: Geçit HTTPS protokol girişi

> Tüm Higress Docker imajları, Higress’e ait imaj deposunu kullanır ve Docker Hub hız limitlerinden etkilenmez.
> Ayrıca, imajların yüklenmesi ve güncellenmesi, Alibaba Cloud ACR destekli bir güvenlik tarama mekanizması ile korunur ve bu da onları üretim ortamları için oldukça güvenli kılar.
> 
> Eğer `higress-registry.cn-hangzhou.cr.aliyuncs.com` adresinden imaj çekerken zaman aşımı yaşarsanız, aşağıdaki docker kayıt aynasını deneyebilirsiniz:
> 
> **Güneydoğu Asya**: `higress-registry.ap-southeast-7.cr.aliyuncs.com`

K8s altında Helm ile dağıtım gibi diğer kurulum yöntemleri için resmi [Hızlı Başlangıç dokümantasyonuna](https://higress.io/en-us/docs/user/quickstart) bakınız.

## Kullanım Senaryoları

- **MCP Sunucu Barındırma**:

  Higress, eklenti mekanizmasıyla MCP Sunucularını barındırır ve AI Agent’lerin çeşitli araç ve servislere kolayca erişmesini sağlar. [openapi-to-mcp aracı](https://github.com/higress-group/openapi-to-mcpserver) ile OpenAPI tanımlarını hızla uzaktaki MCP sunucularına dönüştürebilirsiniz.

  ![](https://img.alicdn.com/imgextra/i1/O1CN01wv8H4g1mS4MUzC1QC_!!6000000004952-2-tps-1764-597.png)

  Higress ile MCP Sunucusu barındırmanın temel avantajları:
  - Birleşik kimlik doğrulama ve yetkilendirme mekanizmaları
  - Kötüye kullanımı önlemek için ayrıntılı oran sınırlama
  - Tüm araç çağrıları için kapsamlı denetim kayıtları
  - Performans izleme için zengin gözlemlenebilirlik
  - Higress’in eklenti mekanizmasıyla basit dağıtım
  - Kesinti veya bağlantı kaybı olmadan dinamik güncellemeler

     [Daha fazla bilgi...](https://higress.cn/en/ai/mcp-quick-start/?spm=36971b57.7beea2de.0.0.d85f20a94jsWGm)

- **AI Geçidi**:

  Higress, tüm LLM model sağlayıcılarına birleşik bir protokolle bağlanır ve AI gözlemlenebilirliği, çoklu model yük dengeleme, token oran sınırlama ve önbellekleme yetenekleri sunar:

  ![](https://img.alicdn.com/imgextra/i2/O1CN01izmBNX1jbHT7lP3Yr_!!6000000004566-0-tps-1920-1080.jpg)

- **Kubernetes ingress controller**:

  Higress, zengin özelliklere sahip bir ingress controller olarak işlev görebilir ve K8s nginx ingress controller’ın birçok anotasyonuyla uyumludur.
  
  [Gateway API](https://gateway-api.sigs.k8s.io/) desteği yakında geliyor ve Ingress API’dan Gateway API’ya sorunsuz geçişi destekleyecek.
  
- **Mikroservis geçidi**:

  Higress, çeşitli servis kayıtlarından mikroservisleri keşfedebilen bir mikroservis geçidi olarak işlev görebilir; örneğin Nacos, ZooKeeper, Consul, Eureka, vb.
  
  [Dubbo](https://github.com/apache/dubbo), [Nacos](https://github.com/alibaba/nacos), [Sentinel](https://github.com/alibaba/Sentinel) ve diğer mikroservis teknoloji yığınlarıyla derin entegrasyon sağlar.
  
- **Güvenlik geçidi**:

  Higress, güvenlik geçidi olarak kullanılabilir; WAF ve anahtar-auth, hmac-auth, jwt-auth, basic-auth, oidc gibi çeşitli kimlik doğrulama stratejilerini destekler.


## Temel Avantajlar

- **Üretime Hazır**

  Alibaba’nın iç ürününden doğmuş, 2 yıldan fazla üretim doğrulamasına sahip, saniyede yüz binlerce isteği destekleyebilen büyük ölçekli senaryolar için uygundur.

  Nginx yeniden yüklemesinin neden olduğu trafik dalgalanmasını tamamen ortadan kaldırır, yapılandırma değişiklikleri milisaniyeler içinde etkili olur ve iş uygulamalarına şeffaftır. Özellikle AI gibi uzun bağlantı gerektiren senaryolar için çok uygundur.

- **Akış İşleme**

  İstek/yanıt gövdelerinin gerçek anlamda tam akış işlemesini destekler, Wasm eklentileri SSE (Server-Sent Events) gibi akış protokollerini kolayca özelleştirebilir.

  AI gibi yüksek bant genişliği gerektiren senaryolarda bellek kullanımını önemli ölçüde azaltır.
    
- **Kolay Genişletilebilir**
  
  AI, trafik yönetimi, güvenlik koruması ve diğer yaygın işlevleri kapsayan zengin bir resmi eklenti kitaplığı sunar, iş senaryolarının %90’ından fazlasının gereksinimlerini karşılar.

  Wasm eklenti genişletmelerine odaklanır, sandbox izolasyonu ile bellek güvenliğini garanti eder, çoklu programlama dili desteği sunar, eklenti sürümlerinin bağımsız yükseltilmesini sağlar ve geçit mantığında trafik kaybı olmadan sıcak güncellemeler gerçekleştirir.

- **Güvenli ve Kullanımı Kolay**
  
  Ingress API ve Gateway API standartlarına dayanır, kutudan çıktığı gibi kullanılabilen UI konsolu, WAF koruma eklentisi, IP/Cookie CC koruma eklentisi hazır gelir.

  Let's Encrypt ile otomatik ve ücretsiz sertifika çıkarma ve yenilemeyi destekler, K8s dışında dağıtılabilir, tek Docker komutuyla başlatılabilir, bireysel geliştiriciler için oldukça uygundur.

## Topluluk

Discord topluluğumuza katılın! Burada Higress’in geliştiricileri ve diğer ilgili kullanıcılarla bağlantı kurabilirsiniz.

[![discord](https://img.shields.io/discord/1364956090566971515?color=5865F2&label=discord&labelColor=black&logo=discord&logoColor=white&style=for-the-badge)](https://discord.gg/tSbww9VDaM)


### Teşekkürler

Higress, topluluktaki açık kaynaklı projelerin değerli çalışmaları olmadan mümkün olmazdı. Özellikle Envoy ve Istio'ya teşekkür ederiz.

### İlgili Depolar

- Higress Console: https://github.com/higress-group/higress-console
- Higress Standalone: https://github.com/higress-group/higress-standalone

### Katkıda Bulunanlar

<a href="https://github.com/alibaba/higress/graphs/contributors">
  <img alt="contributors" src="https://contrib.rocks/image?repo=alibaba/higress"/>
</a>

### Yıldız Geçmişi

[![Star History Chart](https://api.star-history.com/svg?repos=alibaba/higress&type=Date)](https://star-history.com/#alibaba/higress&Date)

<p align="right" style="font-size: 14px; color: #555; margin-top: 20px;">
    <a href="#readme-top" style="text-decoration: none; color: #007bff; font-weight: bold;">
        ↑ Başa Dön ↑
    </a>
</p>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---