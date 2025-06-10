<h1 align="center">Lustre</h1>

<div align="center">
  ✨ <strong>Ön yüzünüzü parlatın</strong> ✨
</div>

<div align="center">
  Gleam ile Web uygulamaları geliştirmek için bir framework!
</div>

<br />

<div align="center">
  <a href="https://hex.pm/packages/lustre">
    <img src="https://img.shields.io/hexpm/v/lustre"
      alt="Hex'te Mevcut" />
  </a>
  <a href="https://hexdocs.pm/lustre">
    <img src="https://img.shields.io/badge/hex-docs-ffaff3"
      alt="Dokümantasyon" />
  </a>
</div>

<div align="center">
  <h3>
    <!--
    <a href="https://lustre.build">
      Web Sitesi
    </a>
    <span> | </span>
    -->
    <a href="https://hexdocs.pm/lustre/guide/01-quickstart.html">
      Hızlı Başlangıç
    </a>
    <span> | </span>
    <a href="https://hexdocs.pm/lustre">
      Referans
    </a>
    <span> | </span>
    <a href="https://discord.gg/Fm8Pwmy">
      Discord
    </a>
  </h3>
</div>

<div align="center">
  <sub>❤︎ ile geliştirilmiştir
  <a href="https://twitter.com/hayleighdotdev">Hayleigh Thompson</a> ve
  <a href="https://github.com/lustre-labs/lustre/graphs/contributors">
    katkıda bulunanlar
  </a>
</div>

---

## İçindekiler

- [Özellikler](#features)
- [Örnek](#example)
- [Felsefe](#philosophy)
- [Kurulum](#installation)
- [Sıradaki Adımlar](#where-next)
- [Destek](#support)

## Özellikler {#features}

- HTML oluşturmak için **deklaratif**, fonksiyonel bir API. Şablon yok, makro yok,
  sadece Gleam.

- **Durum yönetimi** için Erlang ve Elm'den ilham alan bir mimari.

- Öngörülebilir ve test edilebilir kod için **yönetilen yan etkiler**.

- Evrensel bileşenler. **Bir kez yaz, her yerde çalıştır**. Elm, Phoenix LiveView ile buluşuyor.

- Uygulamaları kolayca iskeletlemenizi ve oluşturmanızı sağlayan **her şey dahil bir CLI**.

- Statik HTML şablonlama için **sunucu tarafı renderlama**.

## Örnek {#example}

Lustre ile birlikte [20'den fazla örnek](https://hexdocs.pm/lustre/reference/examples.html) gelir!
İşte nasıl göründüğü:

```gleam
import gleam/int
import lustre
import lustre/element.{text}
import lustre/element/html.{div, button, p}
import lustre/event.{on_click}

pub fn main() {
  let app = lustre.simple(init, update, view)
  let assert Ok(_) = lustre.start(app, "#app", Nil)

  Nil
}

fn init(_flags) {
  0
}

type Msg {
  Incr
  Decr
}

fn update(model, msg) {
  case msg {
    Incr -> model + 1
    Decr -> model - 1
  }
}

fn view(model) {
  let count = int.to_string(model)

  div([], [
    button([on_click(Incr)], [text(" + ")]),
    p([], [text(count)]),
    button([on_click(Decr)], [text(" - ")])
  ])
}
```

## Felsefe {#philosophy}

Lustre, küçük ve orta boyutlu Web uygulamaları geliştirmek için _fikir sahibi_ bir framework'tür. Modern ön yüz geliştirme zordur ve karmaşıktır. Bu karmaşıklığın bir kısmı gereklidir, ancak çoğu tesadüfi ya da çok fazla seçenekten kaynaklanır. Lustre, Gleam ile aynı tasarım felsefesine sahiptir: mümkün olduğunca, bir şeyi yapmanın yalnızca bir yolu olmalı.

Bu, kutudan tek bir durum yönetim sistemiyle gelmek anlamına gelir; Elm ve Erlang/OTP'den esinlenmiştir. Herhangi bir Lustre uygulamasını açtığınızda kendinizi evinizde hissetmelisiniz.

Aynı zamanda, karmaşık yaklaşımlar yerine basit yaklaşımları teşvik ediyoruz. Lustre, kapsüllenmiş durumlu bileşenler oluşturmanın bir yoluna _sahiptir_ (Elm'de çok eksikliğini hissettiğimiz bir şey), ancak bu varsayılan olmamalıdır. Durumlu bileşenler yerine basit fonksiyonları tercih edin.

Bileşenlerin _gerekli_ olduğu durumlarda, Lustre bileşenlerinin _her yerde_ çalışabileceği gerçeğine odaklanın. Lustre size bir bileşeni mevcut bir Lustre uygulaması içinde çalıştırma, bağımsız bir Web Bileşeni olarak dışa aktarma veya minimum bir çalışma zamanı ile sunucuda çalıştırma araçlarını sunar. Lustre bunlara **evrensel bileşenler** der ve bunlar Gleam'in çoklu hedefleri göz önünde bulundurularak yazılmıştır.

## Kurulum {#installation}

Lustre, [Hex](https://hex.pm/packages/lustre) üzerinde yayınlanmıştır! Komut satırından Gleam projelerinize ekleyebilirsiniz:

```sh
gleam add lustre
```

Lustre ayrıca, kurmak isteyebileceğiniz geliştirme araçlarını içeren yardımcı bir pakete sahiptir:

> **Not**: lustre_dev_tools geliştirme sunucusu, dosya sisteminizdeki gleam kodundaki değişiklikleri izler ve tarayıcıyı otomatik olarak yeniden yükleyebilir. Linux kullanıcıları için bunun için [inotify-tools]() kurulu olmalıdır

```sh
gleam add --dev lustre_dev_tools
```

## Sıradaki Adımlar {#where-next}

Lustre ile hızlıca başlamak için [hızlı başlangıç rehberine](https://hexdocs.pm/lustre/guide/01-quickstart.html) göz atabilirsiniz.
Kod örnekleri görmek isterseniz, [examples](https://github.com/lustre-labs/lustre/tree/main/examples)
dizini frameworkün farklı yönlerini gösteren küçük uygulamalar içerir.

Ayrıca dokümantasyon ve API referansını
[HexDocs](https://hexdocs.pm/lustre) üzerinden okuyabilirsiniz.

## Destek {#support}

Lustre çoğunlukla sadece ben, [Hayleigh](https://github.com/hayleigh-dot-dev),
iki iş arasında geliştiriyorum. Çalışmamı desteklemek isterseniz, [GitHub üzerinden bana sponsor olabilirsiniz](https://github.com/sponsors/hayleigh-dot-dev).

Katkılar da çok memnuniyetle karşılanır! Bir hata bulduysanız veya bir özellik önermek istiyorsanız, lütfen bir issue açın veya pull request gönderin.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---