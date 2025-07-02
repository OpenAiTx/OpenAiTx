<div align="right">
  <details>
    <summary >🌐 Dil</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=it">Itapano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>

![](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/logo-no-background.png)
# Scheme-langserver
[![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/ufo5260987423/scheme-langserver)

[Makale](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf)'mi okuyabilir ve aşağıdaki gibi kaynak gösterebilirsiniz:
> WANG, Z. (2025, 12 Mayıs). Scheme-langserver: Scheme Kod Düzenlemeyi Birinci Sınıf Bir Konu Olarak Ele Almak. 18. Avrupa Lisp Sempozyumu (ELS`25), Zürih. https://doi.org/10.5281/zenodo.15384882

GitHub'un Çin IP adreslerini engelleyebileceği için, bu depoyu [buraya](https://codeberg.org/ufo5260987423/scheme-langserver) ve [buraya](https://gitee.com/ufo5260987423/scheme-langserver) kopyalamak zorunda kaldım. Tüm depoları güncellemeye devam edeceğim ama garanti veremem. Şu anda ayrıca [XmacsLabs](https://github.com/XmacsLabs) ile işbirliği yapıyorum, ayrıca bir çatallama [burada](https://github.com/XmacsLabs/scheme-langserver) bulabilirsiniz.

<video src="https://github.com/user-attachments/assets/893bba98-6709-4fac-a4d3-dc7b6aab46fb" controls="controls" width="500" height="300"></video>

**Artık VSCode, scheme-langserver kullanabilir!** Lütfen [BURAYA](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md) bakın.

>NOT: scheme-langserver'da çok fazla hata var. Şu anda düzeltme yapıyor ve topluluktan yardım istiyorum. Lütfen sabırlı olun.

>NOT: Otomatik olarak oluşturulan tip bilgisini [burada](https://ufo5260987423.github.io/scheme-langserver/doc/analysis/type-inference-result) bulabilirsiniz. Şu anda esas olarak bir sonraki geliştirme aşaması (belki AKKU dahil) ve hata ayıklama için kullanılmaktadır.

Otomatik tamamlama, tanıma gitme veya üzerine geldiğinde dokümantasyon gibi desteği uygulamak programlama için önemli bir çabadır. Ancak, java, python, javascript ve c gibi diğer dillere kıyasla, lisp dilleri için dil sunucusu protokolü uygulamaları neredeyse boşlukta yapılmaktadır. [Geiser](https://gitlab.com/emacs-geiser), [racket langserver](https://github.com/jeapostrophe/racket-langserver) ve [swish-lint](https://github.com/becls/swish-lint) gibi projelerin tüm çalışmaları `repl` (Read-Eval-Print Loop) veya anahtar kelime belirteçleyiciye dayanmaktadır, programlama değil. Örneğin, bir programcı tamamlanmamış bir projede kod yazıyorsa ve kodlar tamamen çalıştırılamıyorsa, [Geiser](https://gitlab.com/emacs-geiser) veya diğerleri yalnızca `environment-symbols` prosedürü (örneğin [Chez](https://cisco.github.io/ChezScheme/)) tarafından listelenen üst düzey bağlayıcı tanımlayıcıları tamamlar ya da tanımlayıcılar yerine sembolleri tamamlar. Yani yerel bağlayıcılarda ve tamamlanmamış kodlarda, programlama için çaba harcamak esasen önemli olmasına rağmen, [Geiser](https://gitlab.com/emacs-geiser) ve benzerleri tanımlayıcının geçerli kapsamını tanımada hiçbir işe yaramaz. Tanıma gitme ve birçok başka işlevde de benzer durumlar yaşanır.

Bunun başlıca nedeni, scheme ve diğer lisp lehçelerinde, bol veri kümeleri ve esnek kontrol yapılarının program analizini büyük bir zorluk haline getirmesidir. Özellikle makro konusunda, sanki scheme esasen dahi ve meta/makro programlama için kullanılıyormuş gibi görünüyor. Ama ben böyle düşünmüyorum. Daha iyi bir programlama ortamı sağlanırsa Scheme ile çok ilginç şeyler yapılabilir. Ve şimdi [**BURADAN BAŞLAYABİLİRSİNİZ**](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md).

Bu paket, scheme programlamasına yardımcı olan bir dil sunucu protokolü uygulamasıdır. Tamamlama, tanım ve tip çıkarımı sağlar. Bu işlevler, [r6rs standardı](http://www.r6rs.org/) ve tamamlanmamış kodlar için bazı açık kurallarla statik kod analizi üzerine inşa edilmiştir. Bu paket ve ilgili kütüphaneler [Akku](https://akkuscm.org/) ile yayınlanmış veya yayınlanacaktır; Akku, Scheme için bir paket yöneticisidir.

Bu paket ayrıca [Chez Scheme](https://cisco.github.io/ChezScheme/) 9.4 ve 9.5 sürümleriyle test edilmiştir. Bilgisayarımın işletim sistemini daha yeni bir sürüme yükselttikten sonra 10.0.0 sürümünde ayrıntılı bir test yapılacaktır.

Bu açık kaynak çalışmasını sadece boş zamanlarımda yapıyorum ve topluluğa scheme-langserver'a veri akış analizi gömmek gibi pek çok harika fikir sunabiliyorum. Ve sürekli daha fazla bağış veya fon talep ediyorum. [Bu patreon sayfası](https://www.patreon.com/PoorProgrammer/membership) veya [爱发电](https://afdian.com/a/ufo5260987423) ile bağış yapabilirsiniz.


## Derleme, Kurulum & Yapılandırma [BURADA](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md)

## Güncel Durum
Hataları düzeltmeye, kodu profil çıkarmaya ve kendi geliştirdiğim tip çıkarım sistemi üzerine dev bir kitap için bilgi toplamaya devam edeceğim. Bu yaklaşık 1 yılımı alacak. Daha ileri geliştirmeler arasında bir [VScode](https://code.visualstudio.com/) eklentisi ve veri akış analizi bulunuyor. Ancak aslında, bu açık kaynak işini artık yarı zamanlı bir iş olarak yapıyorum ve bir program garantisi veremem.

## Sürüm
1.2.9 Şimdi, tip çıkarımının tadını çıkarın!

Önceki sürümler için [bu dosyaya](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/release-log.md) bakınız.

### Özellikler
1. Üst düzey ve yerel tanımlayıcı bağlama tamamlama.
![Üst düzey ve yerel tanımlayıcı bağlama](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion.png "Üst düzey ve yerel tanımlayıcı bağlama")
2. Tanıma gitme.
![Tanıma gitme telescope.nvim ile](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/definition.png "Tanıma gitme telescope.nvim ile")
3. Paket yöneticisi Akku ile uyumlu.
4. Dosya değişikliklerini senkronize etme ve ilgili indeks değişikliği.
5. Üzerine gelindiğinde bilgi.
6. Referanslar ve doküman vurgulama (doküman kapsamlı referanslar).
![Referans bulma telescope.nvim ile](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/find-references.png "Referans bulma telescope.nvim ile")
7. Doküman sembolü.
![Doküman sembolleri bulma telescope.nvim ile](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/document-symbol.png "Doküman sembolleri bulma telescope.nvim ile")
8. *-syntax(define-syntax, let-syntax, vb.) tabanlı yerel tanımlayıcı bağlama yakalama.
9. Platformlar arası paralel indeksleme.
10. .sps dosyalarıyla uyumlu olacak şekilde kendi geliştirdiğim kaynak kodu açıklayıcı.
11. API istekleri için askıya alınabilir görevle peephole optimizasyonu.
12. Kendi geliştirdiğim DSL yorumlayıcısı ile tip çıkarımı (bununla çok gurur duyuyorum!). Ve şimdi otomatik tamamlama içine gömülmüş durumda. Aşağıdaki şekilde görüldüğü gibi, "<=" işleminin gerektirdiği parametre tipine uyabildikleri için "integer?" tipine sahip "length-b" ve "length-a" önerilen seçeneklerin başında yer alıyor.
![Tip çıkarımlı otomatik tamamlama](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion-with-type-inference.png "Tip çıkarımlı otomatik tamamlama")
Bunu kanıtlayan bir test için sadece `scheme --script tests/protocol/apis/test-completion.sps` komutunu çalıştırın ve `scheme-langserver.log` kayıt dosyası aşağıdakine benzer sonuçlar içerecektir:
```bash
send-message
2023 11 21 11 26 41 967266866
{"jsonrpc":"2.0","id":"3","result":[{"label":"length-a"},{"label":"length-b"},{"label":"lambda"},{"label":"latin-1-codec"},{"label":"lcm"},{"label":"least-fixnum"},{"label":"length"},{"label":"let"},{"label":"let*"},{"label":"let*-values"},{"label":"let-syntax"},{"label":"let-values"},{"label":"letrec"},{"label":"letrec*"},{"label":"letrec-syntax"},{"label":"lexical-violation?"},{"label":"list"},{"label":"list->string"},{"label":"list->vector"},{"label":"list-ref"},{"label":"list-sort"},{"label":"list-tail"},{"label":"list?"},{"label":"log"},{"label":"lookahead-char"},{"label":"lookahead-u8"}]}
```
13. scm, ss, sps, sls ve sld gibi farklı dosya uzantıları arasında tanımlayıcı yakalama için soyut yorumlayıcı.

### YAPILACAKLAR
14. Yeniden adlandırma.
15. [r6rs standardı](http://www.r6rs.org/) ile tam uyumluluk.
16. Adım adım makro genişletici: Aslında bir tane uyguladım ve bunu kendi tanımladığım makrolarda tanımlayıcı bağlama yakalamada anahtar bir adım yapmak istiyordum. Şimdi, bu yakalamanın düşündüğümden çok daha zor olduğunu fark ettim ve genişleticinin nerede işe yarayacağını bilmiyorum.
17. Kod çalıştırma.
18. Kod tanılaması.
19. Çapraz dil semantik desteği ekle. Peki, bir AST dönüştürücü ile java, c, python ve birçok başka dil desteklenebilir mi?
20. İfade/durumları bir prosedüre çıkar.

## YAPILACAKLAR: Katkıda Bulunma

## Hata Ayıklama

### Nasıl Hata Ayıklanır
https://www.scheme.com/debug/debug.html#g1

### Çıktı Günlüğü
[Derleme](#building), [Lunar Vim için Kurulum](#installation-for-lunarvim) ve [VScode için Kurulum](#todo-installation-for-vscode) başlıklarındaki ipuçlarını takiben, eğer biri geliştirme yapmak ve bir şeyleri günlüğe kaydetmek isterse, `path-to-log-file` eklemek ve `~/.local/share/lunarvim/site/pack/packer/start/nvim-lspconfig/lua/lspconfig/server_configurations/scheme_langserver.lua` dosyasını aşağıdaki gibi yeniden yazmak uygun olacaktır:
```lua
local util = require 'lspconfig.util'
local bin_name = '{path-to-run}'
local cmd = { bin_name ,"path-to-log-file"}

return {
  default_config = {
    cmd = cmd,
    filetypes = { 'scheme' },
    root_dir = util.find_git_ancestor,
    single_file_support = true,
  },
  docs = {
    description = [[
https://github.com/ufo5260987423/scheme-langserver
`scheme-langserver`, scheme için bir dil sunucu protokolü uygulamasıdır
]]   ,
  },
}
```
### Günlük ile Yineleme
Yukarıdaki [çıktı günlüğü](#output-log) ile, `tests/log-debug.sps` dosyasını kullanarak hataları yineleyebilirsiniz:
1. `{path-to-log}` dosyasının adını (genellikle `~/scheme-langserver.log`) `~/ready-for-analyse.log` olarak değiştirin;
2. `scheme --script tests/log-debug.sps` komutunu çalıştırın. Çoklu iş parçacığı ortamını yeniden üretmek isterseniz, `scheme --script tests/log-debug.sps` komutunu çalıştırmak da mümkündür.

## Test
Neredeyse tüm temel prosedürler ve API’ler test edilmiştir. Yaptığım işler oldukça kaba ama kullanışlı, belki `tests` dizininde neler yaptığımı bulmak isteyebilirsiniz veya `{scheme-langserver-root-directory}` içinde aşağıdaki komutu çalıştırabilirsiniz:
``` bash
bash test.sh
```
>NOT
Çoklu iş parçacıklı ortamda test yapmak zordur. Bu yüzden, mevcut testler tek iş parçacığına odaklanır.

## Scheme-langserver’ı Diğer Amaçlar İçin Kullanmak
### GIMP’te Script-Fu
Script-Fu, Scheme tabanlı yorumlanan bir dile dayanır ve GIMP’in dahili işlevleriyle etkileşime giren fonksiyonlar kullanır. [Bu sayfadaki](https://dalelane.co.uk/blog/?p=628) örnek bir script üzerinden, "SCM" uzantılı script dosyalarıyla scheme-langserver’ı uygulayabilirsiniz.

### Diğerleri

Ayrıca [OMN (Opusmodus Notation)](https://opusmodus.com/) ve AutoLisp ile de ilgileniyorum. Ama hâlâ yapacak çok işim var.

## Kod Sayısı
```bash
find . -name "*.sls" ! -path "./.akku/*" |xargs wc -l
```
## Detaylı Doküman
1. [Scheme-langserver: Scheme Kod Düzenlemeyi Birinci Sınıf Bir Konu Olarak Ele Almak](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf).
2. [Tanımlayıcı bağlarını yakalama](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/identifier.md)
3. [Senkronizasyon](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/util/synchronize.md)
4. [Tip çıkarımı](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.md),~~[类型推断](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.cn.md)~~(Kullanımdan kaldırıldı ve bunun için bir Çince kitap yazıyorum)
5. [API Analizi](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/protocol/analysis.md)
6. [Deepwiki](https://deepwiki.com/ufo5260987423/scheme-langserver)

## Yıldız Geçmişi

[![Star History Chart](https://api.star-history.com/svg?repos=ufo5260987423/scheme-langserver&type=Date)](https://star-history.com/#ufo5260987423/scheme-langserver)

## Katkıda Bulunanlar

![Katkıda Bulunanlar](https://contrib.rocks/image?repo=ufo5260987423/scheme-langserver)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---