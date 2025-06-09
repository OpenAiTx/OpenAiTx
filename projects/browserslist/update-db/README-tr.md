# Browserslist DB’yi Güncelle

<img width="120" height="120" alt="Anton Popov tarafından tasarlanan Browserslist logosu"
     src="https://browsersl.ist/logo.svg" align="right">

[Browserslist](https://github.com/browserslist/browserslist/) konfigürasyonundan
tarayıcılar veritabanı ile `caniuse-lite` güncellemek için CLI aracı.

`last 2 versions` veya `>1%` gibi bazı sorgular, `caniuse-lite` içindeki
gerçek verilere bağlıdır.

```sh
npx update-browserslist-db@latest
```

<a href="https://evilmartians.com/?utm_source=update-browserslist-db">
  <img src="https://evilmartians.com/badges/sponsored-by-evil-martians.svg"
       alt="Evil Martians tarafından sponsorlu" width="236" height="54">
</a>

## Neden düzenli olarak çalıştırmalısınız

`npx update-browserslist-db@latest`, npm, yarn veya pnpm kilit dosyanızdaki
`caniuse-lite` sürümünü günceller.

Bu güncelleme, Autoprefixer veya Babel gibi polyfill araçlarına yeni tarayıcılar
hakkında veri getirir ve artık gereksiz olan polyfill’leri azaltır.

Bunu düzenli olarak yapmanız için üç neden:

1. `last 2 versions` veya `>1%` gibi sorgularda en yeni tarayıcı sürümlerini
   ve istatistiklerini kullanmak için. Örneğin, projenizi 2 yıl önce oluşturduysanız
   ve bağımlılıklarınızı güncellemediyseniz, `last 1 version` 2 yıl öncesinin
   tarayıcılarını döndürür.
2. Güncel tarayıcı verileri daha az polyfill kullanımına yol açar. Böylece JS ve CSS dosyalarının
   boyutu küçülür ve web sitesi performansı artar.
3. `caniuse-lite` deduplikasyonu: Farklı araçlarda sürüm senkronizasyonu sağlamak için.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---