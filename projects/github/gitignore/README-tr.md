# `.gitignore` şablonlarının bir koleksiyonu

Bu, GitHub’ın [`.gitignore`][man] dosya şablonları koleksiyonudur.
Bu listeyi, yeni depo ve dosyalar oluştururken GitHub.com arayüzünde
mevcut olan `.gitignore` şablon seçicilerini doldurmak için kullanıyoruz.

`.gitignore` dosyalarının nasıl çalıştığı ve nasıl kullanılacağı hakkında
daha fazla bilgi için aşağıdaki kaynaklar başlamak için harika bir yerdir:

- [Pro Git][progit] kitabının [Dosyaları Yoksayma bölümü][chapter].
- GitHub Yardım sitesindeki [Dosyaları Yoksayma makalesi][help].
- [gitignore(5)][man] kılavuz sayfası.

[man]: https://git-scm.com/docs/gitignore
[help]: https://help.github.com/articles/ignoring-files
[chapter]: https://git-scm.com/book/en/v2/Git-Basics-Recording-Changes-to-the-Repository#_ignoring
[progit]: https://git-scm.com/book

## Klasör yapısı

Aşağıdaki şekilde düzenlenmiş bir şablon koleksiyonunu destekliyoruz:

- Ana dizin, yaygın olarak kullanılan şablonları içerir; bu, popüler programlama dilleri ve teknolojilerle başlamalarına yardımcı olmak içindir. Bunlar, başlamak için anlamlı bir dizi kural tanımlar ve önemsiz dosyaları deponuza göndermemenizi sağlar.
- [`Global`](./Global) farklı editörler, araçlar ve işletim sistemleri için şablonlar içerir ve çeşitli durumlarda kullanılabilir. Bunları kalıcı olarak kullanmak istiyorsanız ya [bunları genel şablonunuza eklemeniz](https://docs.github.com/en/get-started/getting-started-with-git/ignoring-files#configuring-ignored-files-for-all-repositories-on-your-computer) ya da proje-özel şablonlarınıza bu kuralları birleştirmeniz önerilir.
- [`community`](./community) şu anda ana akım şablonlara dahil olmayan diğer popüler diller, araçlar ve projeler için özelleşmiş şablonları içerir. Bir çerçeve veya aracı kullanmaya karar verdiğinizde, bunları proje-özel şablonlarınıza eklemelisiniz.

## İyi bir şablonu ne yapar?

Bir şablon, Git depolarının belirli bir programlama dili, çerçeve, araç veya ortam ile çalışmasına yardımcı olacak bir dizi kural içermelidir.

Bu durum için faydalı kuralların küçük bir kümesini derlemek mümkün değilse, o şablon bu koleksiyona uygun değildir.

Bir şablonun çoğu, belirli bir yazılımın belirli bir sürümü tarafından yüklenen dosyaların bir listesi ise (örneğin bir PHP çerçevesi), `community` dizininde bulunabilir. Daha fazla ayrıntı için [sürümlü şablonlara](#versioned-templates) bakınız.

Küçük bir kural kümeniz varsa veya yaygın olarak kullanılmayan bir teknolojiyi desteklemek istiyorsanız ve bunun başkalarına yardımcı olacağına inanıyorsanız, daha fazla ayrıntı için [özelleşmiş şablonlar](#specialized-templates) bölümünü okuyun.

Şablon önemli ve görünürse pull request açarken ayrıntıları ekleyin. Hemen kabul etmeyebiliriz, ancak ilgiye göre daha sonra ana dizine taşıyabiliriz.

Ayrıca, şimdiye kadar var olan her aracı listeleyemeyeceğimizi de anlamanızı rica ederiz.
Amacımız _en yaygın ve yardımcı_ şablonlardan oluşan bir koleksiyon oluşturmaktır, her olası projeyi kapsamak değil. Dilinizi, aracınızı veya projenizi dahil etmemeyi seçersek, bunun nedeni onun harika olmaması değildir.

## Katkı kuralları

Bu projeyi geliştirmemize yardım etmenizi çok isteriz. Bu koleksiyonun kalitesini yüksek tutmamıza yardımcı olmak için, katkıların aşağıdaki kurallara uymasını rica ediyoruz.

- **Uygulamanın veya projenin ana sayfasına bir bağlantı sağlayın**. Son derece popüler olmadıkça, değişikliğinizin uygulandığı dili, çerçeveyi, editörü, uygulamayı veya projeyi bakımcıların bilmemesi veya kullanmaması olasıdır.

- **Yaptığınız değişikliği destekleyen belgelere bağlantılar sağlayın**.
  Yoksayılan dosyaların belirtildiği güncel, kanonik belgeler en iyisidir.
  Eğer değişikliğinizi destekleyecek bir belge yoksa, yoksayılan dosyaların ne için kullanıldığını en iyi şekilde açıklayın.

- **Neden bir değişiklik yaptığınızı açıklayın**. Kendi kendine açık görünse bile, lütfen değişikliğinizin veya eklemenizin neden gerçekleşmesi gerektiğini bir iki cümleyle açıklayın.
  Özellikle bu değişikliğin yalnızca sizin veya ekibiniz için değil, ilgili teknolojiyle çalışan _herkes_ için neden geçerli olduğunu ifade etmek faydalıdır.

- **Değişikliğinizin kapsamını göz önünde bulundurun**. Değişikliğiniz belirli bir dil veya çerçeveye özgüyse, değişikliği o dil veya çerçevenin şablonuna yaptığınızdan emin olun; bir editör, araç veya işletim sistemi şablonuna değil.

- **Lütfen her pull request’te _yalnızca bir şablonu_ değiştirin**. Bu, pull request ve geri bildirimi belirli bir proje veya teknolojiye odaklı tutmaya yardımcı olur.

Genel olarak, yaptığınız değişikliği anlamamıza ne kadar çok yardımcı olursanız, katkınızı hızlıca kabul etme olasılığımız o kadar artar.

## Sürümlü şablonlar

Bazı şablonlar sürümler arasında büyük ölçüde değişebilir ve bu depoya katkıda bulunmak istiyorsanız belirli bir süreci takip etmemiz gerekir:

- ana dizindeki şablon mevcut desteklenen sürüm olmalı
- ana dizindeki şablonun dosya adında bir sürüm bulunmamalı (yani "her zaman güncel")
- önceki şablon sürümleri `community/` altında bulunmalı
- önceki şablon sürümleri okunabilirlik için dosya adında sürümü içermeli

Bu, kullanıcıların en güncel sürümü almasını sağlar (çünkü ana dizindekini kullanacaklardır) ancak bakımcıların halen kullanımda olan eski sürümleri desteklemesine yardımcı olur.

## Özelleşmiş şablonlar

Katkıda bulunmak istediğiniz ama tam anlamıyla ana akım olmayan bir şablonunuz varsa, lütfen bunu uygun bir klasör altında `community` dizinine eklemeyi düşünün.

Özelleşmiş şablonunuzdaki kurallar çerçeveye veya araca özgü olmalı ve ek şablonlar şablonun başındaki bir yorumda belirtilmelidir.

Örneğin, bu şablon `community/DotNet/InforCRM.gitignore` konumunda bulunabilir:

```
# InforCRM (eski adıyla SalesLogix) için gitignore şablonu
# web sitesi: https://www.infor.com/product-summary/cx/infor-crm/
#
# Önerilen: VisualStudio.gitignore

# Otomatik oluşturulan model dosyalarını yoksay
ModelIndex.xml
ExportedFiles.xml

# Dağıtım dosyalarını yoksay
[Mm]odel/[Dd]eployment

# Portal SupportFiles klasörünü dahil et
!Model/Portal/*/SupportFiles/[Bb]in/
!Model/Portal/PortalTemplates/*/SupportFiles/[Bb]in
```

## Katkı iş akışı

Bir değişiklik önermek için aşağıdaki adımları izlemenizi öneririz:

1. Bu projeyi kendi hesabınıza [fork’layın][fork].
2. Yapmak istediğiniz değişiklik için bir [dal oluşturun][branch].
3. Değişikliklerinizi fork’unuza yapın.
4. Fork’unuzdaki dal üzerinden bizim `main` dalımıza bir [pull request gönderin][pr].

Web tabanlı arayüzü kullanarak değişiklik yapmak da mümkündür ve bu, projeyi otomatik olarak fork’layıp pull request göndermeniz için sizi yönlendirecektir.

[fork]: https://help.github.com/articles/fork-a-repo/
[branch]: https://help.github.com/articles/creating-and-deleting-branches-within-your-repository
[pr]: https://help.github.com/articles/using-pull-requests/

## Lisans

[CC0-1.0](./LICENSE).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---