# Mamba: Hızlı Çoklu Platform Paket Yöneticisi

![mamba header image](https://raw.githubusercontent.com/mamba-org/mamba/main/docs/assets/mamba_header.png)

<!-- markdownlint-disable-file MD033 -->

<table>
<thead align="center" cellspacing="10">
  <tr>
    <th colspan="3" align="center" border="">mamba-org'un bir parçası</th>
  </tr>
</thead>
<tbody>
  <tr background="#FFF">
    <td align="center">Paket Yöneticisi <a href="https://github.com/mamba-org/mamba">mamba</a></td>
    <td align="center">Paket Sunucusu <a href="https://github.com/mamba-org/quetz">quetz</a></td>
  </tr>
</tbody>
</table>

## mamba

[![Build Status](https://github.com/mamba-org/mamba/actions/workflows/tests.yml/badge.svg)](https://github.com/mamba-org/mamba/actions/workflows/tests.yml?query=branch%3Amain)
[![Join the Gitter Chat](https://badges.gitter.im/Join%20Chat.svg)](https://gitter.im/mamba-org/Lobby?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
[![docs](https://readthedocs.org/projects/mamba/badge/?version=latest&style=flat)](https://mamba.readthedocs.io/en/latest)
[![Gurubase](https://img.shields.io/badge/Gurubase-Ask%20mamba%20Guru-006BFF)](https://gurubase.io/g/mamba)

`mamba`, conda paket yöneticisinin C++ ile yeniden uygulanmış bir sürümüdür.

- Çoklu iş parçacığı ile depo verilerinin ve paket dosyalarının paralel indirilmesi
- Red Hat, Fedora ve OpenSUSE'nin RPM paket yöneticisinde kullanılan, son teknoloji bir kütüphane olan libsolv ile çok daha hızlı bağımlılık çözümü
- `mamba`'nın çekirdek bölümleri, maksimum verimlilik için C++ ile yazılmıştır

Aynı zamanda, `mamba` mümkün olduğunca uyumlu kalmak için aynı komut satırı ayrıştırıcısını, paket yükleme ve kaldırma kodunu ve işlem doğrulama rutinlerini `conda` ile paylaşır.

`mamba`, açık kaynaklı bir `conda` paket sunucusu olan `quetz` ile birlikte [conda-forge](https://conda-forge.org/) ekosisteminin bir parçasıdır.

[duyuru blog yazımızı](https://medium.com/@QuantStack/open-software-packaging-for-science-61cecee7fc23) okuyabilirsiniz.

## micromamba

`micromamba`, `mamba`'nın statik olarak derlenmiş sürümüdür.

Herhangi bir bağımlılık olmadan tek başına çalıştırılabilir bir dosya olarak kurulabilir, bu da onu CI/CD süreçleri ve konteyner ortamları için mükemmel bir seçim yapar.

Ayrıntılar için [micromamba belgelerine](https://mamba.readthedocs.io/en/latest/user_guide/micromamba.html) bakınız.

## `mamba` ve `micromamba` Karşılaştırması

`mamba` şu durumlarda tercih edilmelidir:

- `libmambapy` veya `libmamba` aynı ortamda başka bir yazılım tarafından kullanılıyorsa.
- Kütüphanelerin düzenli olarak güncellenmesi gerekiyorsa (özellikle güvenlik için).
- Ortamlar, bağımlılıklar için disk alanı kullanımını azaltmaya odaklanıyorsa.

`micromamba` şu durumlarda tercih edilmelidir:

- Tek bir kendi içinde yeterli çalıştırılabilir dosyaya ihtiyaç varsa.
- Miniforge dağıtımı mevcut değilse.
- Kullanım minimum çalışma zamanı gerektiriyorsa.

## Kurulum

Lütfen belgelerdeki [mamba](https://mamba.readthedocs.io/en/latest/installation/mamba-installation.html)
ve [micromamba](https://mamba.readthedocs.io/en/latest/installation/micromamba-installation.html) kurulum kılavuzlarına başvurun.

## Mamba ve Micromamba'daki Ek Özellikler

`mamba` ve `micromamba`, temel `conda`'nın üstünde ek özelliklerle gelir.

### `repoquery`

Depoları verimli bir şekilde sorgulamak ve paket bağımlılıklarını sorgulamak için `mamba repoquery` veya `micromamba repoquery` kullanabilirsiniz.

Ayrıntılar için [repoquery belgelerine](https://mamba.readthedocs.io/en/latest/user_guide/mamba.html#repoquery) bakınız.

### Lock Dosyalarının Kurulumu

`micromamba`, [conda-lock](https://conda.github.io/conda-lock/) tarafından oluşturulan lock dosyalarını `conda-lock` kurmadan yüklemek için kullanılabilir.

Sadece, ismi `-lock.yml` veya `-lock.yaml` ile biten bir ortam lock dosyası belirterek `micromamba create` komutunu `-f` seçeneği ile çalıştırın; örneğin:

```bash
micromamba create -n my-env -f conda-lock.yml
```

### setup-micromamba (setup-miniconda yerine)

[setup-micromamba](https://github.com/marketplace/actions/setup-micromamba), `micromamba` kullanan [setup-miniconda](https://github.com/marketplace/actions/setup-miniconda) yerine kullanılabilen bir aksiyondur.

CI kurulum sürenizi önemli ölçüde kısaltabilir:

- Kurulumu yaklaşık 1 saniye süren `micromamba` kullanımı ile.
- Paket indirmelerini önbelleğe alarak.
- Tüm `conda` ortamlarını önbelleğe alarak.

## `conda` ile Farklılıklar

`mamba` ve `micromamba` genellikle `conda` için doğrudan bir yedek olsa da bazı farklılıklar vardır:

- `mamba` ve `micromamba` revizyonları desteklemez (tartışmalar için bkz: <https://github.com/mamba-org/mamba/issues/803>)
- `mamba` ve `micromamba`, `MatchSpec` dizelerini en basit forma normalize ederken, `conda` daha ayrıntılı bir biçim kullanır.
  Bu, `conda env export` ve `mamba env export` çıktılarında küçük farklara yol açabilir.

## Geliştirici kurulumu

Lütfen [resmi belgelerde](https://mamba.readthedocs.io/en/latest/developer_zone/dev_environment.html) verilen talimatlara bakınız.

## API ve ABI Kararlılığı

Mamba projesi, `MAJOR.MINOR.PATCH` biçiminde [anlamsal sürümleme](https://semver.org/) kullanır.
Kullanıcılar için işleri kararlı tutmaya çalışsak da, Mamba'yı geliştirmek ve teknik borcu azaltmak için kırıcı değişiklikler de yapmak zorundayız.
Mamba'nın gelecekteki sürümleri daha güçlü garantiler verebilir.

### `libmamba` (C++)

C++ API'sinin tüketicileri olduğunun farkında değiliz, bu nedenle kendimize geliştirme alanı bırakıyoruz.
`libmamba` için _geriye dönük uyumlu_ terimi aşağıdaki gibi anlaşılır:

- _ABI geriye dönük uyumlu_, kütüphane ikili dosyalarını, kodunuzu güncellenmiş başlık dosyalarıyla yeniden derlemeden değiştirebileceğiniz anlamına gelir.
  Gözlemlenen davranış aynı olacaktır, hatalar (umarız ortadan kalkar) ve performans hariç.
- _API geriye dönük uyumlu_, kodunuzu yeni kütüphane sürümü ile sadece yeniden derlemeniz gerektiği anlamına gelir, kodunuzu değiştirmenize gerek yoktur.
  Bu, özel olarak kabul edilen herhangi bir bildirimi (örneğin `detail` alt-ad alanlarındaki) kullanmadığınız sürece geçerlidir.
  Gözlemlenen davranış aynı olacaktır, hatalar (umarız ortadan kalkar) ve performans hariç.
  Bildirimler kaldırılmadan ancak kullanımdan kaldırılarak ve hala işlevsel olarak bırakıldığında, derleme sırasında gözlemlenen davranış değiştiği için bunu da geriye dönük uyumlu olarak kabul ederiz.

Bunu göz önünde bulundurarak, `libmamba` şu garantileri sunar:

- `PATCH` sürümler API ve ABI açısından geriye dönük uyumludur;
- `MINOR` sürümler `mamba/api` içindeki bildirimler için API uyumludur,
  Başka yerlerde API'yi ve her yerde ABI'yi bozabilirler;
- `MAJOR` sürümler herhangi bir garanti vermez.

### `libmambapy` (Python)

`libmambapy` için _API geriye dönük uyumlu_ terimi, Python kodunuzun `libmambapy`'nin yeni bir sürümüyle aynı şekilde çalışacağı anlamına gelir, tabii ki özel olarak kabul edilen, adı `_` ile başlayan bir bildirime erişmediğiniz sürece.
Gözlemlenen davranış aynı olacaktır, hatalar (umarız ortadan kalkar) ve performans hariç.
Bildirimler kaldırılmadan ancak kullanımdan kaldırılarak ve hala işlevsel olarak bırakıldığında, Python `DeprecationWarning` etkinleştirildiğinde gözlemlenebildiğinden, bunu da geriye dönük uyumlu olarak kabul ederiz (ki bu genellikle yalnızca geliştirme sırasında etkinleştirilir).

Bunu göz önünde bulundurarak, `libmambapy` şu garantileri sunar:

- `PATCH` sürümler API açısından geriye dönük uyumludur;
- `MINOR` sürümler API açısından geriye dönük uyumludur;
- `MAJOR` sürümler herhangi bir garanti vermez.

### `mamba` ve `micromamba` (çalıştırılabilir dosyalar)

Çalıştırılabilir dosyalar için _geriye dönük uyumlu_ terimi, programlanabilir giriş ve çıkışlar için geçerlidir ve kodunuzun (kabuk betikleri dahil) çalıştırılabilir dosyanın yeni sürümleriyle değişiklik yapmadan çalışacağı anlamına gelir.
Programlanabilir giriş/çıkışlar; çalıştırılabilir dosya adı, komut satırı argümanları, yapılandırma dosyaları, ortam değişkenleri, JSON komut satırı çıktıları ve oluşturulan dosyaları kapsar.
İnsan tarafından okunabilen çıktı ve hata mesajları ve dolayısıyla insan tarafından okunabilen çıktıdaki kullanımdan kaldırma uyarıları _hariçtir_.

Bunu göz önünde bulundurarak, `mamba` ve `micromamba` şu garantileri sunar:

- `PATCH` sürümler geriye dönük uyumludur;
- `MINOR` sürümler geriye dönük uyumludur;
- `MAJOR` sürümler herhangi bir garanti vermez.

## Bize Destek Olun

Sadece `mamba` ve `micromamba` 2.0 ve sonrası desteklenmekte ve aktif olarak geliştirilmektedir.

`1.x` dalı yalnızca CVE gibi güvenlik açıklarını gidermek için sürdürülmektedir.

Sorularınız için ayrıca [QuantStack Chat](https://gitter.im/QuantStack/Lobby)
veya [Conda kanalı](https://gitter.im/conda/conda) üzerinden bize katılabilirsiniz (bu projenin `conda` veya Anaconda Inc. ile resmi olarak ilişkili olmadığını unutmayın).

## Lisans

Tüm katkıda bulunanların katkıları üzerindeki telif haklarını koruyabilmesini sağlayan paylaşımlı bir telif hakkı modeli kullanıyoruz.

Bu yazılım BSD-3-Clause lisansı ile lisanslanmıştır. Ayrıntılar için [LICENSE](LICENSE) dosyasına bakınız.

---

### İki Haftada Bir Geliştirici Toplantısı

Her iki haftada bir, üzerinde çalıştıklarımızı tartıştığımız ve birbirimizden geri bildirim aldığımız video konferans toplantılarımız var.

Bir konuyu tartışmak veya sadece dinlemek isteyen herkes katılabilir.

- Ne zaman: Salı [16:00 CET (Avrupa)](https://calendar.google.com/calendar/u/0/embed?src=ab3jrfpede0kq0ubsroe82cd00@group.calendar.google.com&ctz=Europe/Paris)
- Nerede: [Mamba jitsi](https://meet.jit.si/mamba-org)
- Ne: [Toplantı notları](https://hackmd.io/@guj2k_aBSSyr1YHBG9raWw/HyHt-Ekzj)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---