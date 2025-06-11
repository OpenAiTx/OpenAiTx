# Containerization

Containerization paketi, uygulamaların Linux konteynerlerini kullanmasına olanak tanır.  
Containerization, [Swift](https://www.swift.org) ile yazılmıştır ve Apple silikon üzerinde [Virtualization.framework](https://developer.apple.com/documentation/virtualization) kullanır.

Containerization aşağıdaki API'leri sağlar:

- [OCI imajlarını yönetme](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationOCI/).
- [Uzak kayıtlarla etkileşim](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationOCI/Client/).
- [ext4 dosya sistemleri oluşturma ve doldurma](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationEXT4/).
- [Netlink soket ailesi ile etkileşim](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationNetlink/).
- [Hızlı açılış zamanları için optimize edilmiş Linux çekirdeği oluşturma](https://raw.githubusercontent.com/apple/containerization/main/kernel/).
- [Hafif sanal makineler başlatma ve çalışma zamanı ortamını yönetme](https://raw.githubusercontent.com/apple/containerization/main/Sources/Containerization/LinuxContainer.swift).
- [Konteynerize edilmiş süreçleri başlatma ve onlarla etkileşim](https://raw.githubusercontent.com/apple/containerization/main/Sources/Containerization/LinuxProcess.swift).
- Apple silikon üzerinde linux/amd64 konteynerlerini çalıştırmak için Rosetta 2 kullanma.

Containerization'ın sağladığı Swift paketleri hakkında bilgi için lütfen [API dokümantasyonunu](https://apple.github.io/containerization/documentation/) inceleyin.

## Tasarım

Containerization, her Linux konteynerini kendi hafif sanal makinesi içinde çalıştırır.  
İstemciler, bireysel port yönlendirmesine gerek kalmadan her konteyner için ayrı IP adresleri oluşturabilir.  
Konteynerler, optimize edilmiş bir [Linux çekirdek yapılandırması](https://raw.githubusercontent.com/apple/containerization/main/kernel) ve hafif bir init sistemi ile minimal kök dosya sistemi kullanarak saniyenin altında başlatma sürelerine ulaşır.

[vminitd](https://raw.githubusercontent.com/apple/containerization/main/vminitd), Containerization içinde bir alt proje olan küçük bir init sistemidir.  
`vminitd`, sanal makine içinde ilk süreç olarak başlatılır ve vsock üzerinden GRPC API sağlar.  
Bu API, çalışma zamanı ortamının yapılandırılmasına ve konteynerize süreçlerin başlatılmasına olanak tanır.  
`vminitd`, bir süreç çalıştırıldığında çağıran sürece G/Ç, sinyaller ve olaylar sağlar.

## Gereksinimler

Containerization'ı derlemek ve çalıştırmak için Apple silikon Mac gerekir.

Containerization paketini derlemek için sisteminizin aşağıdakilerden biri olması gerekir:

- macOS 15 veya daha yeni ve Xcode 26 beta
- macOS 26 beta veya daha yeni

Paket kullanılarak oluşturulan uygulamalar macOS 15 veya sonrası sürümlerde çalışacaktır, ancak macOS 15'te aşağıdaki özellikler mevcut değildir:

- İzole edilmemiş konteyner ağ iletişimi - macOS 15 ile aynı vmnet ağı üzerindeki konteynerler birbirleriyle iletişim kuramazlar

## Örnek Kullanım

Kütüphanelerin bazı yüzeylerini nasıl kullanacağınıza dair örnekler için, `cctl` yürütülebilir dosyası iyi bir başlangıçtır. Bu aracın temel görevi API'yi denemek için bir oyun alanı sağlamaktır. Çeşitli ürünlerin bazı temel işlevlerini kullanan komutlar içerir, örneğin:

1. [OCI imajlarını manipüle etme](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/ImageCommand.swift)  
2. [Konteyner kayıtlarına giriş yapma](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/LoginCommand.swift)  
3. [Kök dosya sistemi blokları oluşturma](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/RootfsCommand.swift)  
4. [Basit Linux konteynerleri çalıştırma](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/RunCommand.swift)  

## Linux çekirdeği

macOS üzerinde hafif sanal makineler oluşturmak için bir Linux çekirdeği gereklidir.  
Containerization, [kernel](https://raw.githubusercontent.com/apple/containerization/main/kernel) dizininde bulunan optimize edilmiş bir çekirdek yapılandırması sağlar.

Bu dizin, Containerization ile kullanmak üzere çekirdek derlemek için kolaylıkla kullanılabilen konteynerize edilmiş bir derleme ortamı içerir.

Çekirdek yapılandırması, hızlı başlatma sürelerini ve hafif bir ortamı desteklemek için minimal özellik setinden oluşur.

Bu yapılandırma çoğu iş yükü için çalışacak olsa da, bazı iş yüklerinin ekstra özelliklere ihtiyacı olabileceğini anlıyoruz.  
Bunu çözmek için Containerization, konteyner bazında farklı çekirdek yapılandırmaları ve sürümleri kullanmak için birinci sınıf API'ler sağlar.  
Bu, konteynerlerin farklı çekirdek sürümleri arasında geliştirilip doğrulanmasını mümkün kılar.

Optimize edilmiş çekirdeğin nasıl derleneceği hakkında talimatlar için kernel dizinindeki [README](https://raw.githubusercontent.com/apple/containerization/main/kernel/README.md) dosyasına bakınız.

### Önceden Derlenmiş Çekirdek

Önceden derlenmiş bir çekirdek kullanmak isterseniz, `VIRTIO` sürücülerinin modül olarak değil, çekirdek içine derlenmiş olması gerekir.

[Kata Containers](https://github.com/kata-containers/kata-containers) projesi, tüm gerekli yapılandırma seçenekleri etkinleştirilmiş konteynerler için optimize edilmiş bir çekirdeği [releases](https://github.com/kata-containers/kata-containers/releases/) sayfasında sağlar.

`vmlinux.container` adlı çekirdek görüntüsü, sürüm dosyalarının `/opt/kata/share/kata-containers/` dizininde bulunabilir.

## Paketi derlemeye hazırlık

Swiftly, [Swift](https://www.swift.org) ve [Static Linux SDK](https://www.swift.org/documentation/articles/static-linux-getting-started.html) kurun:

```bash
make cross-prep
```

Özel bir terminal uygulaması kullanıyorsanız, bu komutu `.zprofile` dosyasından `.zshrc` dosyasına taşımanız gerekebilir ( `<USERNAME>` ile değiştirin):

```bash
# Swiftly tarafından eklendi
. "/Users/<USERNAME>/.swiftly/env.sh"
```

Terminal uygulamasını yeniden başlatın. Aşağıdaki komutun `/Users/<USERNAME>/.swiftly/bin/swift` döndürdüğünden emin olun (`<USERNAME>` değiştirin):

```bash
which swift
```

Önceden Static Linux SDK yüklediyseniz veya kullandıysanız, sistemden eski SDK sürümlerini kaldırmanız gerekebilir (`<SDK-ID>` ile değiştirin):

```bash
swift sdk list
swift sdk remove <SDK-ID>
```

## Paketi derleme

Kaynaklardan Containerization'ı derleyin:

```bash
make all
```

## Paketi test etme

Derlemeden sonra, temel ve entegrasyon testlerini çalıştırın:

```bash
make test integration
```

Entegrasyon testlerini çalıştırmak için bir çekirdek gereklidir.  
Yerel olarak kullanmak üzere bir çekirdeğiniz yoksa, varsayılan bir çekirdek `make fetch-default-kernel` hedefi kullanılarak indirilebilir.

Varsayılan çekirdeği indirmek yalnızca ilk derleme sonrası veya `make clean` sonrası yapılmalıdır.

```bash
make fetch-default-kernel
make all test integration
```

## Protobuflar

Containerization, belirli sürümlerde `grpc-swift` ve `swift-protobuf` bağımlılıklarına sahiptir. Bunları kurup RPC arayüzlerini yeniden üretmek için:

```bash
make protos
```

## Dokümantasyon

API dokümantasyonunu yerelde görüntülemek için oluşturun:

```bash
make docs
make serve-docs
```

Başka bir terminalde aşağıdaki komutu çalıştırarak dokümantasyonu önizleyin:

```bash
open http://localhost:8000/documentation/
```

## Katkıda Bulunma

Containerization'a katkılar memnuniyetle karşılanır ve teşvik edilir. Daha fazla bilgi için lütfen [CONTRIBUTING.md](https://raw.githubusercontent.com/apple/containerization/main/CONTRIBUTING.md) dosyasına bakınız.

## Proje Durumu

Sürüm 0.1.0, Containerization'ın ilk resmi sürümüdür. Önceki sürümlerde kaynak kararlılığı garantisi yoktur.

Containerization kütüphanesi aktif geliştirme aşamasında olduğundan, kaynak kararlılığı yalnızca küçük sürümler arasında (örneğin 0.1.1 ile 0.1.2 arasında) garantilenir.  
Potansiyel olarak kaynakları bozabilecek paket güncellemelerinden kaçınmak istiyorsanız, paket bağımlılığınızı `.upToNextMinorVersion(from: "0.1.0")` olarak belirtebilirsiniz.

Paketin gelecekteki küçük sürümleri, gerekirse bu kurallarda değişiklik yapabilir.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---