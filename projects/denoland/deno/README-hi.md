# Deno

[![](https://img.shields.io/crates/v/deno.svg)](https://crates.io/crates/deno)
[![Twitter badge][]][Twitter link] [![Bluesky badge][]][Bluesky link]
[![Discord badge][]][Discord link] [![YouTube badge][]][YouTube link]

<img align="right" src="https://deno.land/logo.svg" height="150px" alt="the deno mascot dinosaur standing in the rain">

[Deno](https://deno.com)
([/ˈdiːnoʊ/](https://ipa-reader.com/?text=%CB%88di%CB%90no%CA%8A), उच्चारण
`डी-नो`) एक JavaScript, TypeScript, और WebAssembly रनटाइम है जिसमें डिफ़ॉल्ट रूप से सुरक्षा होती है और यह डेवलपर्स के लिए शानदार अनुभव प्रदान करता है। यह [V8](https://v8.dev/),
[Rust](https://www.rust-lang.org/), और [Tokio](https://tokio.rs/) पर आधारित है।

Deno रनटाइम के बारे में अधिक जानें
[डॉक्युमेंटेशन में](https://docs.deno.com/runtime/manual)।

## स्थापना

अपने सिस्टम पर Deno रनटाइम स्थापित करने के लिए नीचे दिए गए किसी एक कमांड का उपयोग करें। ध्यान दें कि Deno को स्थापित करने के कई तरीके हैं - स्थापना विकल्पों की पूरी सूची
[यहाँ](https://docs.deno.com/runtime/manual/getting_started/installation) पाई जा सकती है।

शेल (Mac, Linux):

```sh
curl -fsSL https://deno.land/install.sh | sh
```

PowerShell (Windows):

```powershell
irm https://deno.land/install.ps1 | iex
```

[Homebrew](https://formulae.brew.sh/formula/deno) (Mac):

```sh
brew install deno
```

[Chocolatey](https://chocolatey.org/packages/deno) (Windows):

```powershell
choco install deno
```

[WinGet](https://winstall.app/apps/DenoLand.Deno) (Windows):

```powershell
winget install --id=DenoLand.Deno
```

### स्रोत से निर्माण और स्थापना

स्रोत से Deno बनाने के लिए पूरी निर्देशावली
[यहाँ](https://github.com/denoland/deno/blob/main/.github/CONTRIBUTING.md#building-from-source) पाई जा सकती है।

## आपका पहला Deno प्रोग्राम

Deno का उपयोग कई विभिन्न अनुप्रयोगों के लिए किया जा सकता है, लेकिन आमतौर पर इसका उपयोग वेब सर्वर बनाने के लिए किया जाता है। एक फ़ाइल बनाएं जिसका नाम `server.ts` हो और उसमें निम्नलिखित TypeScript कोड जोड़ें:

```ts
Deno.serve((_req: Request) => {
  return new Response("Hello, world!");
});
```

अपने सर्वर को निम्नलिखित कमांड से चलाएँ:

```sh
deno run --allow-net server.ts
```

इससे आपके लोकल सिस्टम पर एक वेब सर्वर
[http://localhost:8000](http://localhost:8000) पर शुरू हो जाना चाहिए।

Deno प्रोग्राम लिखने और चलाने के बारे में और जानें
[डॉक्स में](https://docs.deno.com/runtime/manual)।

## अतिरिक्त संसाधन

- **[Deno Docs](https://docs.deno.com)**: Deno रनटाइम, [Deno Deploy](https://deno.com/deploy), और अन्य के लिए आधिकारिक गाइड और संदर्भ दस्तावेज़।
- **[Deno Standard Library](https://jsr.io/@std)**: Deno प्रोग्रामों के लिए आधिकारिक रूप से समर्थित सामान्य यूटिलिटी।
- **[JSR](https://jsr.io/)**: आधुनिक JavaScript और TypeScript के लिए ओपन-सोर्स पैकेज रजिस्ट्री।
- **[Developer Blog](https://deno.com/blog)**: Deno टीम से उत्पाद अपडेट, ट्यूटोरियल्स, और बहुत कुछ।

## सहयोग

हम आपकी मदद की सराहना करते हैं! सहयोग करने के लिए, कृपया हमारे
[सहयोग निर्देश](.github/CONTRIBUTING.md) पढ़ें।

[Build status - Cirrus]: https://github.com/denoland/deno/workflows/ci/badge.svg?branch=main&event=push
[Build status]: https://github.com/denoland/deno/actions
[Twitter badge]: https://img.shields.io/twitter/follow/deno_land.svg?style=social&label=Follow
[Twitter link]: https://twitter.com/intent/follow?screen_name=deno_land
[Bluesky badge]: https://img.shields.io/badge/Follow-whitesmoke?logo=bluesky
[Bluesky link]: https://bsky.app/profile/deno.land
[YouTube badge]: https://img.shields.io/youtube/channel/subscribers/UCqC2G2M-rg4fzg1esKFLFIw?style=social
[YouTube link]: https://www.youtube.com/@deno_land
[Discord badge]: https://img.shields.io/discord/684898665143206084?logo=discord&style=social
[Discord link]: https://discord.gg/deno

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---