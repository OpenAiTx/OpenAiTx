<div align="center">
  <h1>Lampo</h1>

  <img src="https://github.com/saradurante/lampo.docs/blob/dc0dce971c3052f0e9dd668fdf0c7376b12fee7b/imgs/web/icon-512.png?raw=true"  width="150" height="150" />


  <p>
    <strong>Tüm kullanımlar için hızlı ve modüler lightning network implementasyonu, Rust ile yazılmıştır.</strong>
  </p>

  <h4>
    <a href="https://lampo.devcrew.cc">Proje Anasayfası</a>
  </h4>
</div>

## Crate’ler

Şu anda desteklenen tüm crate’lerin tam listesi:

| Crate       | Açıklama                                   | Sürüm     |
|:------------|:------------------------------------------:|----------:|
| lampod-cli  | Daemon’ı çalıştırmak için Lampo Daemon komut satırı arayüzü | _alakasız_ |
| lampo-cli   | Daemon ile etkileşim için basit Lampo komut satırı arayüzü | _alakasız_ |

## Nasıl Kurulur

Tüm gereksinimleri ve Lampo ikili dosyasını kurmak için,
Rust’ın kurulu olması gerekir ve ardından aşağıdaki komutu çalıştırmalısınız:

```
make install
```

`lampod-cli` ve `lampo-cli` hazır olduğunda, Lampo’yu signet modunda başlatmak için şu komutu çalıştırabilirsiniz:

```
➜  ~ lampod-cli --network signet
✓ Cüzdan Oluşturuldu, lütfen bu kelimeleri güvenli bir yerde saklayınız
 cüzdan-anahtarları  maple have fitness decide food joy flame coast stereo front grab stumble
```

>[!NOTE]
Cüzdan kelimelerinizi saklayın ve ardından cüzdanı `--restore-wallet` ile geri yüklemek için tekrar kullanın.
Eğer kelimelerinizi hiçbir yerde saklamazsanız, Lampo bir dahaki sefere başladığında fonlarınız kaybolacaktır!

Dikkat edin, `~/.lampo/signet` yolunda bir `lampo.conf` dosyanız olması gerekir. 
Örnek yapılandırma dosyasını kullanmak için aşağıdaki komutu çalıştırın:

```
cp lampo.example.conf ~/.lampo/signet/lampo.conf
```

Ardından düğümü aşağıdaki komutla sorgulayabilirsiniz:

``` 
➜  ~ lampo-cli --network signet getinfo
{
  "node_id": "035b889551a44e502cd0cd6657acf067336034986cd6639b222cd4be563a7fc205",
  "peers": 0,
  "channels": 0
}
```

### Core lightning ile entegrasyon testlerini çalıştırmak için:

Core-lightning’i geliştirici modunda derlediğinizden emin olun. Kurulum rehberini [burada](https://docs.corelightning.org/docs/installation) bulabilirsiniz.

Entegrasyon testleri aşağıdaki komutla çalıştırılabilir:

```
make integration
```

## Katkı Sağlama Kuralları

Lütfen [Katkı Sağlama rehberimizi](https://raw.githubusercontent.com/vincenzopalazzo/lampo.rs/main/CONTRIBUTING.md) okuyun.

## Topluluk

Açıklığı korumak için iletişimde belirli kanalları seçtik:
- Geliştiriciler, bize [Zulip](https://lampo-dev.zulipchat.com/) üzerinden katılabilir.
- Topluluk üyeleri, [Twitter topluluğumuz](https://twitter.com/i/communities/1736414802849706087) görüşlerinizi bekliyor.
- Teknik sorular ve özellik talepleri için GitHub tartışmalarımıza katılabilirsiniz.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---