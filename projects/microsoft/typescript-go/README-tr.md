# TypeScript 7

[Bunun ne olduğundan emin değil misiniz? Duyuru gönderisini okuyun!](https://devblogs.microsoft.com/typescript/typescript-native-port/)

## Önizleme

Bir önizleme derlemesi npm'de `@typescript/native-preview` olarak mevcuttur.

```sh
npm install @typescript/native-preview
npx tsgo # Bunu tsc gibi kullanın.
```

Bir önizleme VS Code eklentisi [VS Code Market'te mevcuttur](https://marketplace.visualstudio.com/items?itemName=TypeScriptTeam.native-preview).

Bunu kullanmak için, VS Code ayarlarınıza şunu ekleyin:

```json
{
    "typescript.experimental.useTsgo": true
}
```

## Nasıl Derlenir ve Çalıştırılır

Bu depo [Go 1.24 veya üstü](https://go.dev/dl/), [Rust 1.85 veya üstü](https://www.rust-lang.org/tools/install), [npm ile Node.js](https://nodejs.org/) ve [`hereby`](https://www.npmjs.com/package/hereby) kullanır.

Testler ve kod üretimi için, bu depoda ana TypeScript deposuna, taşınan commit'e işaret eden bir git alt modülü vardır.
Klonlama sırasında, alt modüllerle birlikte klonlamak isteyeceksiniz:

```sh
git clone --recurse-submodules https://github.com/microsoft/typescript-go.git
```

Depoyu zaten klonladıysanız, alt modülü aşağıdakiyle başlatabilirsiniz:

```sh
git submodule update --init --recursive
```

Alt modül ve `npm ci` ile, TypeScript deposunda olduğu gibi `hereby` aracılığıyla görevleri çalıştırabilirsiniz:

```sh
hereby build          # Projenin derlendiğini doğrular
hereby test           # Tüm testleri çalıştırır
hereby install-tools  # Linter gibi ek araçları yükler
hereby lint           # Tüm linter'ları çalıştırır
hereby format         # Tüm kodu biçimlendirir
hereby generate       # Tüm Go kodunu üretir (örn. tanılar, depoya işlenir)
```

Ek görevler üzerinde çalışılmaktadır.

Depoda çalışmak için `hereby` gerekli değildir; normal `go` araçları (örn. `go build`, `go test ./...`) beklendiği gibi çalışacaktır.
`hereby` görevleri, TypeScript deposuna aşina olanlar için kolaylık olarak sağlanır.

### `tsgo` Çalıştırma

`hereby build` çalıştırıldıktan sonra, çoğunlukla `tsc` ile aynı şekilde davranan `built/local/tsgo`'yu çalıştırabilirsiniz.

### LSP Prototipini Çalıştırma

VS Code eklentisini global olarak yüklemeden hata ayıklamak ve çalıştırmak için:

* Depo çalışma alanında VS Code'u başlatın (`code .`)
* `.vscode/launch.template.json` dosyasını `.vscode/launch.json` olarak kopyalayın
* <kbd>F5</kbd> (veya komut paletinden `Debug: Start Debugging`)

Bu, arka uç olarak Corsa LS kullanan yeni bir VS Code örneği başlatacaktır. Doğru kurulduysa, bir TypeScript veya JavaScript dosyası açıkken durum çubuğunda "tsgo"yu görmelisiniz:

![LSP Prototype Screenshot](.github/ls-screenshot.png)


## Şu Ana Kadar Neler Çalışıyor?

Bu hâlâ devam eden bir çalışmadır ve henüz TypeScript ile tam özellik eşitliğine sahip değildir. Hatalar olabilir. Lütfen yeni bir sorun bildirmeden veya kasıtlı bir değişiklik olduğunu varsaymadan önce bu listeyi dikkatlice kontrol edin.

| Özellik | Durum | Notlar |
|---------|--------|-------|
| Program oluşturma | tamamlandı | TS5.8 ile aynı dosya ve modül çözünürlüğü. Henüz tüm çözünürlük modları desteklenmiyor. |
| Ayrıştırma/tarama | tamamlandı | TS5.8 ile tamamen aynı sözdizimi hataları |
| Komut satırı ve `tsconfig.json` ayrıştırma | çoğunlukla tamam | Giriş noktası şimdilik biraz farklı |
| Tip çözümleme | tamamlandı | TS5.8 ile aynı tipler |
| Tip denetleme | tamamlandı | Aynı hatalar, konumlar ve mesajlar. Hatalarda tiplerin yazdırılması farklı görünebilir (devam ediyor) |
| JavaScript'e özgü çıkarım ve JS Doc | hazır değil | - |
| JSX | tamamlandı | - |
| Bildirim üretimi | devam ediyor | En yaygın özellikler mevcut, ancak bazı köşe durumları ve özellik bayrakları henüz ele alınmadı |
| Üretim (JS çıktısı) | devam ediyor | `target: esnext` iyi destekleniyor, diğer hedeflerde eksikler olabilir |
| İzleme modu | prototip | Dosyaları izler ve yeniden derler, ancak artımlı tekrar denetleme yok |
| Derleme modu / proje referansları | hazır değil | - |
| Artımlı derleme | hazır değil | - |
| Dil servisi (LSP) | prototip | Minimum işlevsellik (hatalar, üzerine gelince bilgi, tanıma git). Yakında daha fazla özellik eklenecek |
| API | hazır değil | - |

Tanımlar:

 * **tamamlandı** yani "tamamlandığına inanılıyor": Şu anda herhangi bir eksiklik veya büyük bir yapılacak iş bilmiyoruz. Hata bildirebilirsiniz
 * **devam ediyor**: şu anda üzerinde çalışılıyor; bazı özellikler çalışabilir, bazıları çalışmayabilir. Panik hatalarını bildirebilirsiniz, başka bir şey lütfen bildirmeyin
 * **prototip**: sadece kavram kanıtı; hata bildirmeyin
 * **hazır değil**: ya henüz hiç başlanmadı ya da tamamlanmaktan çok uzak, uğraşmaya değmez

## Diğer Notlar

Uzun vadede, bu deponun ve içeriğinin `microsoft/TypeScript` ile birleştirilmesini bekliyoruz.
Sonuç olarak, typescript-go için depo ve sorun izleyici sonunda kapatılacaktır, bu yüzden tartışmaları/sorunları buna göre ele alın.

TypeScript 5.7 ile ilgili kasıtlı değişikliklerin listesi için bkz. CHANGES.md.

## Katkıda Bulunmak

Bu proje katkıları ve önerileri memnuniyetle karşılar.  Çoğu katkı, bize katkınızı kullanma hakkı verdiğinizi ve gerçekten verdiğinizi beyan eden bir
Katılımcı Lisans Sözleşmesi'ni (CLA) kabul etmenizi gerektirir. Ayrıntılar için bkz. [Katılımcı Lisans Sözleşmeleri](https://cla.opensource.microsoft.com).

Bir pull request gönderdiğinizde, bir CLA botu otomatik olarak bir CLA sağlamanız gerekip gerekmediğini belirleyecek
ve PR'ı uygun şekilde işaretleyecektir (örn., durum kontrolü, yorum). Bot tarafından verilen talimatları izleyin.
Bunu, CLA'mızı kullanan tüm depolarda yalnızca bir kez yapmanız gerekir.

Bu proje [Microsoft Açık Kaynak Davranış Kuralları'nı](https://opensource.microsoft.com/codeofconduct/) benimsemiştir.
Daha fazla bilgi için [Davranış Kuralları SSS](https://opensource.microsoft.com/codeofconduct/faq/) veya
ek sorularınız veya yorumlarınız için [opencode@microsoft.com](mailto:opencode@microsoft.com) ile iletişime geçin.

## Ticari Markalar

Bu projede projelere, ürünlere veya hizmetlere ait ticari markalar veya logolar bulunabilir. Microsoft ticari markaları veya logolarının yetkili kullanımı
[Microsoft Ticari Marka & Marka Yönergeleri](https://www.microsoft.com/legal/intellectualproperty/trademarks/usage/general)'ne tabidir ve bunlara uymalıdır.
Bu projenin değiştirilmiş sürümlerinde Microsoft ticari markalarının veya logolarının kullanımı karışıklığa yol açmamalı veya Microsoft sponsorluğu ima etmemelidir.
Üçüncü taraf ticari markaların veya logoların kullanımı, ilgili üçüncü taraf politikalarına tabidir.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---