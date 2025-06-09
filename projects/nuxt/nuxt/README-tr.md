[![Nuxt banner](https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/banner.svg)](https://nuxt.com)

# Nuxt

<p>
  <a href="https://www.npmjs.com/package/nuxt"><img src="https://img.shields.io/npm/v/nuxt.svg?style=flat&colorA=18181B&colorB=28CF8D" alt="Version"></a>
  <a href="https://www.npmjs.com/package/nuxt"><img src="https://img.shields.io/npm/dm/nuxt.svg?style=flat&colorA=18181B&colorB=28CF8D" alt="Downloads"></a>
  <a href="https://github.com/nuxt/nuxt/tree/main/LICENSE"><img src="https://img.shields.io/github/license/nuxt/nuxt.svg?style=flat&colorA=18181B&colorB=28CF8D" alt="License"></a>
  <a href="https://nuxt.com"><img src="https://img.shields.io/badge/Nuxt%20Docs-18181B?logo=nuxt" alt="Website"></a>
  <a href="https://chat.nuxt.dev"><img src="https://img.shields.io/badge/Nuxt%20Discord-18181B?logo=discord" alt="Discord"></a>
  <a href="https://securityscorecards.dev/"><img src="https://api.securityscorecards.dev/projects/github.com/nuxt/nuxt/badge" alt="Nuxt openssf scorecard score"></a>
</p>

Nuxt, Vue.js ile tip güvenli, yüksek performanslı ve üretim seviyesinde tam yığın web uygulamaları ve web siteleri oluşturmayı sezgisel ve genişletilebilir bir şekilde sağlayan ücretsiz ve açık kaynaklı bir framework'tür.

Hızlı, SEO dostu ve ölçeklenebilir web uygulamaları oluşturmayı kolaylaştıran bir dizi özellikle birlikte gelir, bunlar arasında:
- Sunucu tarafı renderlama, Statik Site Üretimi, Hibrit Renderlama ve Edge-Side Renderlama
- Kod bölme ve önceden getirme ile otomatik yönlendirme
- Veri çekme ve durum yönetimi
- SEO Optimizasyonu ve Meta etiket tanımlama
- Bileşenlerin, composable'ların ve yardımcıların otomatik içe aktarımı
- Sıfır yapılandırma ile TypeScript desteği
- server/ dizinimiz ile tam yığın geliştirme
- [200+ modül](https://nuxt.com/modules) ile genişletilebilir
- Çeşitli [barındırma platformlarına](https://nuxt.com/deploy) dağıtım
- ...[ve çok daha fazlası](https://nuxt.com) 🚀

### İçindekiler

- 🚀 [Başlangıç](#getting-started)
- 💻 [ Vue Geliştirme](#vue-development)
- 📖 [Dokümantasyon](#documentation)
- 🧩 [Modüller](#modules)
- ❤️  [Katkıda Bulunun](#contribute)
- 🏠 [Yerel Geliştirme](#local-development)
- 🛟 [Profesyonel Destek](#professional-support)
- 🔗 [Bizi Takip Edin](#follow-us)
- ⚖️ [Lisans](#license)

---

## <a name="getting-started">🚀 Başlangıç</a>

Yeni bir başlangıç projesi oluşturmak için aşağıdaki komutu kullanın. Bu komut, gerekli tüm dosya ve bağımlılıklarla birlikte bir başlangıç projesi oluşturacaktır:

```bash
npm create nuxt <my-project>
```

> [!IPUCU]
> [nuxt.new](https://nuxt.new)'u da keşfedin: Birkaç saniye içinde CodeSandbox, StackBlitz veya yerelde bir Nuxt başlangıç projesi açıp çalıştırabilirsiniz.

## <a name="vue-development">💻 Vue Geliştirme</a>

Basit, sezgisel ve güçlü: Nuxt, Vue bileşenlerini mantıklı bir şekilde yazmanızı sağlar. Her tekrarlayan görev otomatikleştirilir, böylece tam yığın Vue uygulamanızı güvenle yazmaya odaklanabilirsiniz.

Bir `app.vue` örneği:

```vue
<script setup lang="ts">
useSeoMeta({
  title: 'Meet Nuxt',
  description: 'The Intuitive Vue Framework.'
})
</script>

<template>
  <div id="app">
    <AppHeader />
    <NuxtPage />
    <AppFooter />
  </div>
</template>

<style scoped>
#app {
  background-color: #020420;
  color: #00DC82;
}
</style>
```

## <a name="documentation">📖 Dokümantasyon</a>

[Dökümantasyona](https://nuxt.com/docs) göz atmanızı şiddetle öneririz. Framework hakkında daha fazla bilgi edinmek ve kendinizi geliştirmek için harika bir kaynaktır. Başlangıçtan ileri seviye konulara kadar her şeyi kapsar.

## <a name="modules">🧩 Modüller</a>

Nuxt ekibi ve topluluğu tarafından oluşturulan [modül listemizi](https://nuxt.com/modules) keşfederek Nuxt projenizi güçlendirin.

## <a name="contribute">❤️ Katkıda Bulunun</a>

Nuxt’u geliştirmeye katkıda bulunmanızı ve yardımcı olmanızı bekliyoruz 💚

Katılabileceğiniz bazı yollar:
- **Hata Bildirimi:** Herhangi bir hata veya sorunla karşılaşırsanız, [hata bildirme rehberine](https://nuxt.com/docs/community/reporting-bugs) göz atarak nasıl hata bildirileceğini öğrenebilirsiniz.
- **Öneriler:** Nuxt’u geliştirmek için fikirleriniz mi var? Duymak isteriz! [Katkı rehberini](https://nuxt.com/docs/community/contribution) inceleyerek önerilerinizi paylaşabilirsiniz.
- **Sorular:** Sorularınız veya yardıma ihtiyacınız varsa, [yardım alma rehberi](https://nuxt.com/docs/community/getting-help) sizi destekleyecek kaynaklar sunar.

## <a name="local-development">🏠 Yerel Geliştirme</a>

Framework ve dökümantasyona katkıda bulunmak için [Yerel Geliştirme Ortamınızı Kurun](https://nuxt.com/docs/community/framework-contribution#setup) dökümantasyonunu takip edin.

## <a name="professional-support">🛟 Profesyonel Destek</a>

- Teknik denetim & danışmanlık: [Nuxt Uzmanları](https://nuxt.com/enterprise/support)
- Özel geliştirme & daha fazlası: [Nuxt Ajans Partnerleri](https://nuxt.com/enterprise/agencies)

## <a name="follow-us">🔗 Bizi Takip Edin</a>

<p valign="center">
  <a href="https://go.nuxt.com/discord"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/discord.svg" alt="Discord"></a>&nbsp;&nbsp;<a href="https://go.nuxt.com/x"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/twitter.svg" alt="Twitter"></a>&nbsp;&nbsp;<a href="https://go.nuxt.com/github"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/github.svg" alt="GitHub"></a>&nbsp;&nbsp;<a href="https://go.nuxt.com/bluesky"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/bluesky.svg" alt="Bluesky"></a>
</p>

## <a name="license">⚖️ Lisans</a>

[MIT](https://github.com/nuxt/nuxt/tree/main/LICENSE)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---