![](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/logo-no-background.png)
# Scheme-langserver
[![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/ufo5260987423/scheme-langserver)

[Makale](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf)'mi okuyabilir ve şu şekilde atıf yapabilirsiniz:
> WANG, Z. (2025, 12 Mayıs). Scheme-langserver: Scheme Kod Düzenlemeyi Birinci Sınıf Bir Kaygı Olarak Ele Almak. 18. Avrupa Lisp Sempozyumu (ELS`25), Zürih. https://doi.org/10.5281/zenodo.15384882

GitHub'un Çin IP adreslerini engelleyebileceği nedeniyle bu deposunu [buraya](https://codeberg.org/ufo5260987423/scheme-langserver) ve [buraya](https://gitee.com/ufo5260987423/scheme-langserver) kopyalamak zorunda kaldım. Tüm depoları sürekli güncellemeye çalışacağım fakat garanti veremem. Şu anda [XmacsLabs](https://github.com/XmacsLabs) ile de işbirliği yapıyorum, ayrıca bir çatalı [burada](https://github.com/XmacsLabs/scheme-langserver) bulabilirsiniz.

<video src="https://github.com/user-attachments/assets/893bba98-6709-4fac-a4d3-dc7b6aab46fb" controls="controls" width="500" height="300"></video>

**Artık VSCode, scheme-langserver kullanabiliyor!** Lütfen [BURADAN](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md) bakınız.

>NOT: scheme-langserver'da çok fazla hata var. Şu anda düzeltmeler yapıyor ve topluluktan yardım istiyorum. Lütfen sabırlı olun.

>NOT: Otomatik oluşturulan tip bilgisini [buradan](https://ufo5260987423.github.io/scheme-langserver/doc/analysis/type-inference-result) bulabilirsiniz. Şu anda esas olarak sonraki aşama geliştirme (belki AKKU dahil) ve hata ayıklama için kullanılıyor.

Tamamlama, tanıma git veya üzerine gelindiğinde dokümantasyon gibi destekler sağlamak programlama için büyük bir çabadır. Ancak, java, python, javascript ve c gibi diğer dillere kıyasla, lisp dilleri için dil sunucusu protokolü uygulamaları adeta bir vakumda yapılmıştır. [Geiser](https://gitlab.com/emacs-geiser), [racket langserver](https://github.com/jeapostrophe/racket-langserver) ve [swish-lint](https://github.com/becls/swish-lint) gibi projelerin tamamı `repl` (Read-Eval-Print Loop) veya anahtar kelime belirteçleyiciye dayalıdır, programlamaya değil. Örneğin, bir programcı tamamlanmamış bir projede kod yazıyorsa ve kodlar tam olarak çalıştırılamıyorsa, [Geiser](https://gitlab.com/emacs-geiser) veya diğerleri yalnızca `environment-symbols` prosedürüyle ([Chez](https://cisco.github.io/ChezScheme/) için) listelenen üst düzey bağlayıcı tanımlayıcıları veya simgeleri tamamlayacaktır, tanımlayıcıları değil. Bu, yerel bağlayıcılar ve tamamlanmamış kodlar için, aslında programlama için çaba harcamak en önemli şey olmasına rağmen, [Geiser](https://gitlab.com/emacs-geiser) ve benzerlerinin tanımlayıcının geçerli kapsamını tanıma konusunda hiçbir işe yaramadığı anlamına gelir. Tanıma git ve birçok başka işlevde de benzer durumlar yaşanır.

Bunun başlıca nedeni, scheme ve diğer lisp lehçelerinde bol veri kümeleri ve esnek kontrol yapılarının program analizini büyük bir zorluk haline getirmesidir. Özellikle makro, scheme sanki esas olarak dahi ve meta/makro programlama için kullanılıyormuş gibi görünür. Ama ben hayır diyorum. Daha iyi bir programlama ortamı sağlanırsa Scheme ile çok ilginç şeyler yapılabilir. Ve şimdi [**BURADAN BAŞLAYABİLİRSİNİZ**](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md).

Bu paket, scheme programlamaya yardımcı olan bir dil sunucusu protokolü uygulamasıdır. Tamamlama, tanımlama ve tip çıkarımı sağlar. Bu işlevler, [r6rs standardı](http://www.r6rs.org/) ve tamamlanmamış kodlar için bazı belirgin kurallarla statik kod analizi üzerine kuruludur. Bu paket ve ilgili kütüphaneler [Akku](https://akkuscm.org/) ile yayınlanmış veya yayınlanacaktır; Akku, Scheme için bir paket yöneticisidir.

Bu paket ayrıca [Chez Scheme](https://cisco.github.io/ChezScheme/) 9.4 ve 9.5 sürümleriyle test edilmiştir. Dizüstü bilgisayarımın işletim sistemini daha yeni bir sürüme yükselttikten sonra 10.0.0 sürümü için ayrıntılı bir test yapılacaktır.

Bu açık kaynak çalışmasını sadece boş zamanlarımda yapıyorum ve topluluğa scheme-langserver'a veri akışı analizi gömme veya başka birçok konuda harika fikirler kazandırabilirim. Ve sürekli olarak daha fazla bağış veya fon istiyorum. [Bu patreon sayfası](https://www.patreon.com/PoorProgrammer/membership) veya [爱发电](https://afdian.com/a/ufo5260987423) ile bağış yapabilirsiniz.


## Derleme, Kurulum & Yapılandırma [BURADA](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md)

## Güncel Durum
Hataları düzeltmeye, kodu profillemeye ve kendi tip çıkarım sistemimle ilgili dev kitabım için bilgi toplamaya devam edeceğim. Bu bana yaklaşık 1 yıl sürecek. İleriye dönük geliştirmeler arasında bir [VScode](https://code.visualstudio.com/) eklentisi ve veri akışı analizi var. Ama aslında, şu anda bu açık kaynak işini yarı zamanlı bir iş olarak yapıyorum ve bir takvim garantisi veremem.

## Sürüm
1.2.9 Artık tip çıkarımının tadını çıkarın!

Önceki sürümler için lütfen [bu dosyaya](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/release-log.md) bakınız.

### Özellikler
1. Üst düzey ve yerel tanımlayıcı bağlama tamamlama.
![Üst düzey ve yerel tanımlayıcı bağlama](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion.png "Üst düzey ve yerel tanımlayıcı bağlama")
2. Tanıma git (goto definition).
![Telescope.nvim ile tanıma git](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/definition.png "Telescope.nvim ile tanıma git")
3. Paket yöneticisi ile uyumlu: Akku.
4. Dosya değişiklikleri senkronizasyonu ve ilgili indeks değişimi.
5. Üzerine gelme (hover).
6. Referanslar ve belge vurgulama (belge kapsamlı referanslar).
![Telescope.nvim ile referans bul](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/find-references.png "Telescope.nvim ile referans bul")
7. Belge simgesi.
![Telescope.nvim ile belge simgelerini bul](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/document-symbol.png "Telescope.nvim ile belge simgelerini bul")
8. *-syntax (define-syntax, let-syntax, vb.) tabanlı yerel tanımlayıcı bağlama yakalama.
9. Çoklu platformda paralel indeksleme.
10. .sps dosyalarıyla uyumlu kendi kaynak kodu açıklayıcısı.
11. API istekleri için askıya alınabilir görev ile peephole optimizasyonu.
12. Ev yapımı DSL yorumlayıcısı ile tip çıkarımı (bununla çok gurur duyuyorum!). Ve artık otomatik tamamlamaya entegre edildi. Aşağıdaki şekilde görüldüğü gibi, "integer?" tipine sahip "length-b" ve "length-a", "<=" tarafından istenen parametre tipiyle eşleşebildikleri için önerilen seçeneklerin önünde yer alıyor.
![Tip çıkarımıyla otomatik tamamlama](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion-with-type-inference.png "Tip çıkarımıyla otomatik tamamlama")
Bunu kanıtlamak için bir test yapılabilir, sadece `scheme --script tests/protocol/apis/test-completion.sps` komutunu çalıştırın ve `scheme-langserver.log` günlük dosyası aşağıdaki gibi sonuçlar içerecektir:
```bash
send-message
2023 11 21 11 26 41 967266866
{"jsonrpc":"2.0","id":"3","result":[{"label":"length-a"},{"label":"length-b"},{"label":"lambda"},{"label":"latin-1-codec"},{"label":"lcm"},{"label":"least-fixnum"},{"label":"length"},{"label":"let"},{"label":"let*"},{"label":"let*-values"},{"label":"let-syntax"},{"label":"let-values"},{"label":"letrec"},{"label":"letrec*"},{"label":"letrec-syntax"},{"label":"lexical-violation?"},{"label":"list"},{"label":"list->string"},{"label":"list->vector"},{"label":"list-ref"},{"label":"list-sort"},{"label":"list-tail"},{"label":"list?"},{"label":"log"},{"label":"lookahead-char"},{"label":"lookahead-u8"}]}
```
13. scm, ss, sps, sls ve sld gibi farklı dosya uzantıları arasında tanımlayıcı yakalama için soyut yorumlayıcı.

### YAPILACAKLAR
14. Yeniden adlandırma.
15. [r6rs standardı](http://www.r6rs.org/) ile tam uyumluluk.
16. Adım adım makro genişletici: Aslında bir tane uyguladım ve bunu kendi tanımladığım makrolarda tanımlayıcı bağlama yakalamada anahtar bir adım yapmak istedim. Şimdi, bu yakalamanın düşündüğümden çok daha zor olduğunu görüyorum ve genişleticinin nerede işe yarayacağını bilmiyorum.
17. Kod değerlendirme.
18. Kod teşhisi.
19. Çapraz dil semantik desteği ekleme. Peki, java, c, python ve diğer birçok dil bir AST dönüştürücü ile desteklenebilir mi?
20. İfade/durumları bir prosedüre dönüştürme.

## YAPILACAKLAR: Katkı Sağlama

## Hata Ayıklama

### Nasıl Hata Ayıklanır
https://www.scheme.com/debug/debug.html#g1

### Çıktı Günlüğü
[Derleme](#building), [Lunar Vim için Kurulum](#installation-for-lunarvim) ve [VScode için Kurulum](#todo-installation-for-vscode) bölümlerindeki ipuçlarını izleyerek, geliştirme yapmak ve bir şeyleri günlüğe kaydetmek isteyenler için, `path-to-log-file` eklemek ve `~/.local/share/lunarvim/site/pack/packer/start/nvim-lspconfig/lua/lspconfig/server_configurations/scheme_langserver.lua` dosyasını aşağıdaki gibi yeniden yazmak uygun olacaktır:
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
`scheme-langserver`, scheme için bir dil sunucusu protokolü uygulaması
]]   ,
  },
}
```
### Log ile Tekrarlama
Yukarıdaki [çıktı günlüğü](#output-log) ile, `tests/log-debug.sps` dosyasını kullanarak hataları tekrar edebilirsiniz:
1. `{path-to-log}`'un (genellikle `~/scheme-langserver.log`) adını `~/ready-for-analyse.log` olarak değiştirin;
2. `scheme --script tests/log-debug.sps` komutunu çalıştırın. Çoklu iş parçacıklı ortamı tekrar üretmek isterseniz, `scheme --script tests/log-debug.sps` komutunu da çalıştırabilirsiniz.

## Test
Neredeyse tüm ana prosedürler ve API'ler test edilmiştir. Yaptığım iş oldukça kaba ama faydalı; belki `tests` dizininde ne yaptığımı bulmak istersiniz veya `{scheme-langserver-root-directory}` içinde aşağıdaki komutu çalıştırabilirsiniz:
```bash
bash test.sh
```
>NOT
İş parçacıklı ortamda test yapmak zordur. Bu nedenle, mevcut testler tek iş parçacığına odaklanmıştır.

## Scheme-langserver'ı Diğer Amaçlar İçin Kullanmak
### GIMP'de Script-Fu
Script-Fu, Scheme adı verilen yorumlanmış bir dile dayanır ve GIMP'in dahili fonksiyonlarıyla etkileşime giren fonksiyonlar kullanır. [Bu sayfadaki](https://dalelane.co.uk/blog/?p=628) örnek script'te olduğu gibi, "SCM" uzantılı script dosyalarında scheme-langserver'ı kullanabilirsiniz.

### Diğerleri

Ayrıca [OMN (Opusmodus Notation)](https://opusmodus.com/) ve AutoLisp ile de ilgileniyorum. Ama yapacak daha çok işim var.

## Kod Sayısı
```bash
find . -name "*.sls" ! -path "./.akku/*" |xargs wc -l
```
## Detaylı Doküman
1. [Scheme-langserver: Scheme Kod Düzenlemeyi Birinci Sınıf Bir Konu Olarak Ele Almak](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf).
2. [Tanımlayıcı bağlamalarını yakalamak](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/identifier.md)
3. [Senkronizasyon](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/util/synchronize.md)
4. [Tür çıkarımı](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.md),~~[类型推断](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.cn.md)~~(Kullanımdan kaldırıldı, bunun için Çince bir kitap yazıyorum)
5. [API Analizi](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/protocol/analysis.md)
6. [Deepwiki](https://deepwiki.com/ufo5260987423/scheme-langserver)

## Star Geçmişi

[![Star History Chart](https://api.star-history.com/svg?repos=ufo5260987423/scheme-langserver&type=Date)](https://star-history.com/#ufo5260987423/scheme-langserver)

## Katkıda Bulunanlar

![Contributors](https://contrib.rocks/image?repo=ufo5260987423/scheme-langserver)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-01

---