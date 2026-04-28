
<div align="right">
  <details>
    <summary >🌐 Dil</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# cq - CSV Dosyaları için Yüksek Performanslı SQL Sorgu Motoru

 [![Çapraz Derleme ve Test (zig build sistemi ile)](https://github.com/baldimario/cq/actions/workflows/build-zig-cross.yml/badge.svg)](https://github.com/baldimario/cq/actions/workflows/build-zig-cross.yml)

Veritabanı gerektirmeden SQL sorgularını doğrudan CSV dosyaları üzerinde çalıştırmanıza olanak tanıyan, C ile yazılmış hafif ve hızlı bir SQL sorgu işlemcisidir. Tam dokümantasyon için /doc dizinine bakınız.

 ![cq uygulamada](https://raw.githubusercontent.com/baldimario/cq/main/assets/cq.png)

## Dokümantasyon

- Başlangıç: `doc/GettingStarted.md`
- Kurulum: `doc/Installation.md`
- Komut Satırı Arayüzü: `doc/CLI.md`
- **TUI (Terminal Kullanıcı Arayüzü)**: `doc/TUI.md`
- Mimari: `doc/Architecture.md`
- Test: `doc/Testing.md`
- Yol Haritası: `doc/Roadmap.md`
- Katkıda Bulunma: `doc/Contributing.md`

## Hızlı Başlangıç

Derleme: `make`

### Komut Satırı

Örnek bir sorgu çalıştırın:
`./build/cq -q "SELECT name, age FROM 'data.csv' WHERE age > 25" -p`

### Terminal Arayüzü

Etkileşimli TUI başlatın:
`./build/cqtui data/`

Özellikler:
- CSV dosyalarını tablo olarak gezme ve açma
- SQL sorgularını etkileşimli olarak çalıştırma
- Birden fazla tablo için çoklu sekme arayüzü
- Klavye tabanlı gezinme
- Harici bağımlılık yok

## Örnek SQL Dosyaları

Depoda assets/ klasörü altında örnek SQL dosyaları bulunmaktadır (example_between.sql, example_aggregation.sql, vb.). Ayrıntılar için assets/ klasörüne bakınız.

## Veri & Özellikler Genel Bakış

- Veri tipleri, tarih formatları, CSV formatı ve daha fazlası için ayrıntılı bölümler /doc klasöründe bulunmaktadır.

## Lisans

MIT Lisansı. Ayrıntılar için LICENSE dosyasına bakınız.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-28

---