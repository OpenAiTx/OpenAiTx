# Kelp

HTML sevenlerin beğeneceği, modern CSS ve Web Bileşenleri ile güçlendirilmiş bir UI kütüphanesi.

**[Dokümanları Oku &rarr;](https://kelpui.com)**

_**Not:** Kelp şu anda alpha aşamasında geliştirilme sürecindedir. Lütfen kullanmaktan, denemeler yapmaktan ve hataları bildirmekten çekinmeyin, ancak zamanla şeylerin değişebileceğini ve değişeceğini unutmayın._



## Hızlı Başlangıç

Kelp, herhangi bir derleme adımı olmadan çalışır.

[CDN](https://cdn.jsdelivr.net/npm/kelpui/) başlamak için en hızlı ve en basit yoldur, ancak isterseniz [dosyaları GitHub'dan indirebilirsiniz](https://github.com/cferdinandi/kelp).

```html
<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/kelpui@0/css/kelp.css">
```

Kelp semantik sürümleme kullanır. CDN üzerinden `@1.2.3` söz dizimiyle ana, ikincil veya yama sürümünü alabilirsiniz. Mevcut tüm sürümleri [sürümler altında](https://github.com/cferdinandi/kelp/tags) bulabilirsiniz.



## Demo

Dahil edilen `index.html` dosyası, Kelp'in tüm özelliklerini ve bileşenlerini içeren bir "kitchen sink" demosudur. Tüm özellikler ve bileşenler tek bir büyük dosyada bulunur.

Beta aşamasında, Kelp'in bir derleme adımı yoktur. Web bileşeni ES importları kullanır ve çalıştırmak için yerel bir sunucuya ihtiyaç duyar.

Tercih ettiğiniz sunucuyu kullanabilir veya dahil edilen `http-server` ile `npm run dev` komutunu çalıştırabilirsiniz.

```bash
npm install
npm run dev
```

Kelp v1'e yaklaştıkça, bu gereksiz hale gelecek bir derleme adımı kullanılacaktır.



## Testler

Kelp şu araçları kullanır...

- Testler için [Playwright](https://playwright.dev)
- Linting ve formatlama için [Biome](https://biomejs.dev)
- Dağıtımlarda ve PR'larda sürekli entegrasyon süreci

```bash
# Testleri çalıştır
npm run test

# Linter'ı çalıştır
npm run lint
```



## Lisans

[Kelp Commons License](https://github.com/cferdinandi/kelp/blob/main/LICENSE.md) altında ücretsiz olarak kullanılabilir. Ayrıca [ticari lisans seçenekleri](/license/) de mevcuttur.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---