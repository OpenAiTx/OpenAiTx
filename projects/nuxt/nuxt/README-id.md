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

Nuxt adalah framework gratis dan open-source yang menawarkan cara intuitif dan dapat diperluas untuk membuat aplikasi web full-stack dan situs web berbasis Vue.js yang aman tipe, berperforma tinggi, dan siap produksi.

Nuxt menyediakan sejumlah fitur yang memudahkan pembuatan aplikasi web yang cepat, ramah SEO, dan skalabel, termasuk:
- Rendering sisi server, Generasi Situs Statis, Rendering Hibrida, dan Rendering Sisi Edge
- Routing otomatis dengan pemisahan kode (code-splitting) dan pre-fetching
- Pengambilan data dan manajemen status
- Optimasi SEO dan definisi tag Meta
- Impor otomatis komponen, composable, dan utilitas
- TypeScript tanpa konfigurasi
- Fullstack melalui direktori server/
- Dapat diperluas dengan [200+ modul](https://nuxt.com/modules)
- Deployment ke berbagai [platform hosting](https://nuxt.com/deploy)
- ...[dan masih banyak lagi](https://nuxt.com) 🚀

### Daftar Isi

- 🚀 [Memulai](#getting-started)
- 💻 [Pengembangan Vue](#vue-development)
- 📖 [Dokumentasi](#documentation)
- 🧩 [Modul](#modules)
- ❤️  [Berkontribusi](#contribute)
- 🏠 [Pengembangan Lokal](#local-development)
- 🛟 [Dukungan Profesional](#professional-support)
- 🔗 [Ikuti Kami](#follow-us)
- ⚖️ [Lisensi](#license)

---

## <a name="getting-started">🚀 Memulai</a>

Gunakan perintah berikut untuk membuat proyek starter baru. Ini akan membuat proyek starter beserta semua berkas dan dependensi yang diperlukan:

```bash
npm create nuxt <my-project>
```

> [!TIP]
> Temukan juga [nuxt.new](https://nuxt.new): Buka starter Nuxt di CodeSandbox, StackBlitz, atau secara lokal untuk memulai dalam hitungan detik.

## <a name="vue-development">💻 Pengembangan Vue</a>

Sederhana, intuitif, dan kuat, Nuxt memungkinkan Anda menulis komponen Vue dengan cara yang masuk akal. Setiap tugas berulang diotomatisasi, sehingga Anda dapat fokus menulis aplikasi Vue full-stack dengan percaya diri.

Contoh `app.vue`:

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

## <a name="documentation">📖 Dokumentasi</a>

Kami sangat menyarankan Anda untuk melihat [dokumentasi Nuxt](https://nuxt.com/docs) agar semakin mahir. Ini adalah sumber daya yang hebat untuk mempelajari lebih lanjut tentang framework ini, mulai dari langkah awal hingga topik tingkat lanjut.

## <a name="modules">🧩 Modul</a>

Temukan [daftar modul](https://nuxt.com/modules) untuk meningkatkan proyek Nuxt Anda, dibuat oleh tim dan komunitas Nuxt.

## <a name="contribute">❤️ Berkontribusi</a>

Kami mengundang Anda untuk berkontribusi dan membantu meningkatkan Nuxt 💚

Beberapa cara untuk terlibat:
- **Melaporkan Bug:** Jika Anda menemukan bug atau masalah, silakan lihat [panduan pelaporan bug](https://nuxt.com/docs/community/reporting-bugs) untuk mempelajari cara mengirimkan laporan bug.
- **Saran:** Punya ide untuk meningkatkan Nuxt? Kami ingin mendengarnya! Lihat [panduan kontribusi](https://nuxt.com/docs/community/contribution) untuk berbagi saran Anda.
- **Pertanyaan:** Jika Anda memiliki pertanyaan atau membutuhkan bantuan, [panduan mendapatkan bantuan](https://nuxt.com/docs/community/getting-help) menyediakan sumber daya untuk membantu Anda.

## <a name="local-development">🏠 Pengembangan Lokal</a>

Ikuti dokumentasi untuk [Menyiapkan Lingkungan Pengembangan Lokal Anda](https://nuxt.com/docs/community/framework-contribution#setup) agar dapat berkontribusi pada framework dan dokumentasi.

## <a name="professional-support">🛟 Dukungan Profesional</a>

- Audit teknis & konsultasi: [Nuxt Experts](https://nuxt.com/enterprise/support)
- Pengembangan kustom & lainnya: [Nuxt Agencies Partners](https://nuxt.com/enterprise/agencies)

## <a name="follow-us">🔗 Ikuti Kami</a>

<p valign="center">
  <a href="https://go.nuxt.com/discord"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/discord.svg" alt="Discord"></a>&nbsp;&nbsp;<a href="https://go.nuxt.com/x"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/twitter.svg" alt="Twitter"></a>&nbsp;&nbsp;<a href="https://go.nuxt.com/github"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/github.svg" alt="GitHub"></a>&nbsp;&nbsp;<a href="https://go.nuxt.com/bluesky"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/bluesky.svg" alt="Bluesky"></a>
</p>

## <a name="license">⚖️ Lisensi</a>

[MIT](https://github.com/nuxt/nuxt/tree/main/LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---