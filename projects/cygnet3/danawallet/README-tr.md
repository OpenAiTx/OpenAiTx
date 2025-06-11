# Dana cüzdan

Dana, bitcoin bağışlarını kabul etmek için kullanılan bir flutter uygulamasıdır. Bağışları zincir üstü gizliliği koruyarak almak için yeni bir statik ödeme protokolü olan sessiz ödemeleri kullanır.

## Dana cüzdanı deneyin

**Dana cüzdan şu anda hala deneysel aşamadadır. Testnet/signet kullanmanızı öneririz. Gerçekten ana ağda cüzdanı test etmek istiyorsanız, yalnızca kaybetmeyi göze alabileceğiniz fonları kullanın. Kayıp fonlardan sorumlu değiliz.**

Uygulama daha stabil hale geldikten sonra Dana cüzdanı popüler uygulama mağazalarında yayınlamayı düşünüyoruz.

Bu arada, Dana cüzdanı denemenin iki yolu vardır:

- En son Dana cüzdan APK'sını [sürümler sayfasından](https://github.com/cygnet3/danawallet/releases) indirin
- Dana cüzdanı kendi barındırdığımız [F-Droid deposunu](https://fdroid.silentpayments.dev/fdroid/repo) kullanarak indirin

### F-Droid kullanarak indirme

Otomatik güncellemeleri desteklediği ve sadece bir kez kurulması gerektiği için F-Droid seçeneğini öneriyoruz.

- Android telefonunuzda F-Droid uygulamasını açın
- 'Ayarlar'a gidin
- 'Uygulamalarım' bölümünde 'Depolar'a tıklayın
- '+' simgesine tıklayarak yeni bir depo ekleyin
- Bu sayfadaki QR kodunu tarayın: https://fdroid.silentpayments.dev/fdroid/repo

Artık kendi barındırdığımız depoyu eklediniz. Uygulamayı indirmek için F-Droid mağaza bölümünde 'Dana Wallet' araması yapın (önce uygulama listesini yenilemek için F-Droid mağaza ekranında aşağı kaydırmanız gerekebilir).

## Dana cüzdanı kaynaktan derleme

Aşağıda Dana cüzdanını kaynaktan derlemek için bazı talimatlar bulunmaktadır. Bu, yalnızca Dana cüzdanın geliştirilmesine katkıda bulunmak istiyorsanız önerilir.

### Linux (masaüstü) için derleme

Linux için derleme ekstra çaba gerektirmez, sadece şu komutu çalıştırın:

```
flutter run
```

Bu komut diğer platformlarda (macOS, Windows) da çalışabilir, ancak biz test etmedik.

### Android için derleme

Android cihaz için derleme, bu mimariye özgü ikili dosyaların oluşturulması için bazı hazırlıklar gerektirir.

Öncelikle, `cargo-ndk` gerekir. Ayrıca istediğiniz araç zincirlerini eklemeniz gerekebilir:

```
cargo install cargo-ndk
rustup target add \
    aarch64-linux-android \
    armv7-linux-androideabi \
    x86_64-linux-android \
    i686-linux-android
```

Bunlar yüklendikten sonra, rust dizinine gidin ve `just build-android` komutunu çalıştırın.

```
cd rust
just build-android
```

Eğer `just` yüklü değilse, `justfile` içinde bulunan komutları kopyalayabilirsiniz. Bu ikili dosyaları oluşturur.

Sonra telefonunuzu bağlayın ve hata ayıklama modunu etkinleştirin. Telefonunuzun bağlı olup olmadığını kontrol etmek için:

```
flutter devices
```

Son olarak, android cihazınız için uygulamayı derleyip yüklemek için:

```
flutter run
```

## Dana'ya bağış yapın

Dana cüzdanına aşağıdaki adresi kullanarak bağış yapabilirsiniz:

> ₿donate@danawallet.app

veya aşağıdaki sessiz ödeme adresini kullanabilirsiniz:

> sp1qq0cygnetgn3rz2kla5cp05nj5uetlsrzez0l4p8g7wehf7ldr93lcqadw65upymwzvp5ed38l8ur2rznd6934xh95msevwrdwtrpk372hyz4vr6g

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---