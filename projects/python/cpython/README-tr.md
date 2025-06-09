Bu Python sürümü 3.15.0 alfa 0'dır
===================================

.. image:: https://github.com/python/cpython/actions/workflows/build.yml/badge.svg?branch=main&event=push
   :alt: CPython'ın GitHub Actions üzerindeki derleme durumu
   :target: https://github.com/python/cpython/actions

.. image:: https://dev.azure.com/python/cpython/_apis/build/status/Azure%20Pipelines%20CI?branchName=main
   :alt: CPython'ın Azure DevOps üzerindeki derleme durumu
   :target: https://dev.azure.com/python/cpython/_build/latest?definitionId=4&branchName=main

.. image:: https://img.shields.io/badge/discourse-join_chat-brightgreen.svg
   :alt: Python Discourse sohbeti
   :target: https://discuss.python.org/


Telif Hakkı © 2001 Python Software Foundation.  Tüm hakları saklıdır.

Daha fazla telif hakkı ve lisans bilgisi için bu dosyanın sonuna bakınız.

.. contents::

Genel Bilgiler
--------------

- Web sitesi: https://www.python.org
- Kaynak kodu: https://github.com/python/cpython
- Hata takipçisi: https://github.com/python/cpython/issues
- Dokümantasyon: https://docs.python.org
- Geliştirici Rehberi: https://devguide.python.org/

CPython’a Katkıda Bulunmak
--------------------------

CPython geliştirmesine katkıda bulunmakla ilgili daha ayrıntılı talimatlar için
`Geliştirici Rehberi`_’ne bakınız.

.. _Geliştirici Rehberi: https://devguide.python.org/

Python Kullanımı
----------------

Kurulabilir Python paketleri ve Python kullanımı hakkında bilgiler
`python.org`_ adresinde mevcuttur.

.. _python.org: https://www.python.org/

Derleme Talimatları
-------------------

Unix, Linux, BSD, macOS ve Cygwin'de::

    ./configure
    make
    make test
    sudo make install

Bu işlem Python’u ``python3`` olarak kuracaktır.

Configure betiğine birçok seçenek geçebilirsiniz; daha fazla bilgi için ``./configure --help`` komutunu çalıştırınız.  macOS büyük/küçük harf duyarsız dosya sistemlerinde ve Cygwin'de,
çalıştırılabilir dosya ``python.exe`` olarak adlandırılır; diğerlerinde ise sadece ``python``’dır.

Tam bir Python kurulumu oluşturmak için, derleme platformunuza ve
configure seçeneklerinize bağlı olarak çeşitli ek üçüncü parti kütüphanelerin kullanılması gerekir.  Tüm standart kütüphane modülleri tüm platformlarda derlenebilir veya kullanılabilir değildir.  Farklı Linux dağıtımları ve macOS için bağımlılıklarla ilgili güncel ve ayrıntılı bilgiler için `Geliştirici Rehberi`_’nin
`Bağımlılıkları Yükleme <https://devguide.python.org/getting-started/setup-building.html#build-dependencies>`_
bölümüne bakınız.

macOS'ta, macOS framework ve evrensel derlemelerle ilgili ek configure ve derleme seçenekleri vardır.  Bkz. `Mac/README.rst
<https://github.com/python/cpython/blob/main/Mac/README.rst>`_.

Windows’ta, bkz. `PCbuild/readme.txt
<https://github.com/python/cpython/blob/main/PCbuild/readme.txt>`_.

Windows yükleyici oluşturmak için, bkz. `Tools/msi/README.txt
<https://github.com/python/cpython/blob/main/Tools/msi/README.txt>`_.

İsterseniz, bir alt dizin oluşturup oradan configure komutunu çağırabilirsiniz.
Örneğin::

    mkdir debug
    cd debug
    ../configure --with-pydebug
    make
    make test

(Bu işlem, *ayrıca* üst düzey dizinde de derleme yaptıysanız başarısız olacaktır. Öncelikle üst düzeyde ``make clean`` yapmalısınız.)

Python’un optimize edilmiş bir derlemesini elde etmek için, ``make`` komutunu çalıştırmadan önce ``configure --enable-optimizations`` kullanınız.  Bu, varsayılan make hedeflerini Profil Yönlendirmeli Optimizasyon (PGO) ile etkinleştirir ve bazı platformlarda Bağlantı Zamanı Optimizasyonu’nu (LTO) otomatik olarak etkinleştirmek için kullanılabilir.  Daha fazla ayrıntı için aşağıdaki bölümlere bakınız.

Profil Yönlendirmeli Optimizasyon
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

PGO, GCC veya Clang derleyicilerinin son sürümlerinden faydalanır.  Kullanıldığında,
ya ``configure --enable-optimizations`` ile ya da configure bayraklarından bağımsız olarak
``make profile-opt`` komutu elle çalıştırılarak, optimize derleme işlemi aşağıdaki adımları gerçekleştirir:

Önceki bir derlemeden kalmış olabilecek geçici dosyalar Python dizininden tamamen temizlenir.

Yorumlayıcının enstrümante edilmiş bir sürümü, her tür için uygun derleyici
bayrakları kullanılarak oluşturulur. Bu sadece ara bir adımdır.  Bu adımdan çıkan ikili dosya,
içinde profil oluşturma komutları bulunduğundan gerçek iş yükleri için uygun değildir.

Enstrümante yorumlayıcı oluşturulduktan sonra, Makefile bir eğitim iş yükü çalıştırır.
Bu, yorumlayıcının çalışmasını profillemek için gereklidir.  Ayrıca, bu adımda oluşabilecek stdout ve stderr dahil tüm çıktıların bastırıldığını unutmayın.

Son adım olarak, toplanan bilgiler kullanılarak gerçek yorumlayıcı inşa edilir.
Sonuç olarak, dağıtım veya üretim kurulumu için uygun, optimize edilmiş bir Python ikili dosyası elde edilir.


Bağlantı Zamanı Optimizasyonu
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

Configure’ın ``--with-lto`` bayrağı ile etkinleştirilir.  LTO, son derleyici araç zincirlerinin nihai çalıştırılabilir dosyaları veya paylaşımlı kütüphaneleri oluştururken aksi halde rastgele olan ``.o`` dosyası sınırlarının ötesinde da ek performans kazançları için optimize etme yeteneğinden yararlanır.


Yenilikler
----------

`Python 3.15’teki yenilikler <https://docs.python.org/3.15/whatsnew/3.15.html>`_ belgesinde değişikliklerin kapsamlı bir özeti vardır.  Daha ayrıntılı bir değişiklik günlüğü için `Misc/NEWS
<https://github.com/python/cpython/tree/main/Misc/NEWS.d>`_’yi okuyunuz, fakat tüm değişikliklerin tam hesabı yalnızca `taahhüt geçmişi
<https://github.com/python/cpython/commits/main>`_’nden elde edilebilir.

Birden fazla Python sürümü kurmak istiyorsanız, aşağıdaki "Birden fazla sürüm kurmak" başlıklı bölüme bakınız.


Dokümantasyon
-------------

`Python 3.15 için dokümantasyon <https://docs.python.org/3.15/>`_ çevrim içidir,
günlük olarak güncellenmektedir.

Daha hızlı erişim için birçok formatta indirilebilir.  Dokümantasyon
HTML, PDF ve reStructuredText formatlarında indirilebilir; son sürüm
özellikle dokümantasyon yazarları, çevirmenler ve özel biçimlendirme gereksinimi olanlar içindir.

Python’un dokümantasyonunu oluşturmak hakkında bilgi için bkz. `Doc/README.rst
<https://github.com/python/cpython/blob/main/Doc/README.rst>`_.


Test Etme
---------

Yorumlayıcıyı test etmek için, üst düzey dizinde ``make test`` yazınız.  Test
kümesi bazı çıktılar üretir.  Genellikle isteğe bağlı özelliklerin
içe aktarılamamasından kaynaklanan atlanan testlerle ilgili iletileri göz ardı edebilirsiniz.  Bir hata mesajı, traceback ya da çekirdek dökümü oluşursa,
bir sorun var demektir.

Varsayılan olarak, testlerin disk alanı ve bellek gibi kaynakları aşırı kullanması önlenir.  Bu testleri etkinleştirmek için ``make buildbottest`` çalıştırınız.

Herhangi bir test başarısız olursa, başarısız olan testi/ testleri ayrıntılı modda tekrar çalıştırabilirsiniz.  Örneğin, ``test_os`` ve ``test_gdb`` başarısız olduysa, şöyle çalıştırabilirsiniz::

    make test TESTOPTS="-v test_os test_gdb"

Eğer hata devam ederse ve Python’dan ziyade ortamınızla ilgili bir sorun değilse, `bir hata raporu oluşturabilir
<https://github.com/python/cpython/issues>`_ ve o komuttan aldığınız ilgili çıktıyı sorunu göstermek için ekleyebilirsiniz.

Test çalıştırma hakkında daha fazla bilgi için bkz. `Testleri Çalıştırma ve Yazma <https://devguide.python.org/testing/run-write-tests.html>`_.

Birden fazla sürüm kurmak
-------------------------

Unix ve Mac sistemlerinde, aynı kurulum önekiyle (``--prefix`` argümanı ile configure
betiğine) birden fazla Python sürümü kurmayı planlıyorsanız, ana python çalıştırılabilir dosyanızın farklı bir sürüm kurulumu ile üzerine yazılmamasına dikkat etmelisiniz.  ``make altinstall`` ile kurulan tüm dosyalar ve
dizinler ana ve yardımcı sürümü içerir ve bu nedenle yan yana bulunabilirler.  ``make install`` ayrıca ``${prefix}/bin/python3`` oluşturur ve bu, ``${prefix}/bin/python3.X``’e atıfta bulunur.  Aynı önekle birden fazla sürüm kurmayı planlıyorsanız, hangi sürümün (varsa) "birincil" sürümünüz olacağına karar vermelisiniz.  O sürümü şu şekilde kurunuz
``make install``.  Diğer tüm sürümleri ``make altinstall`` kullanarak kurun.

Örneğin, Python 2.7, 3.6 ve 3.15 sürümlerini kurmak istiyorsanız ve 3.15 ana sürüm olacaksa, 3.15 derleme dizininizde ``make install`` komutunu ve diğerlerinde ``make altinstall`` komutunu çalıştırırsınız.


Sürüm Takvimi
-------------

Python 3.15 sürüm detayları için `PEP 790 <https://peps.python.org/pep-0790/>`__ sayfasına bakınız.


Telif Hakkı ve Lisans Bilgisi
-----------------------------


Telif Hakkı © 2001 Python Software Foundation.  Tüm hakları saklıdır.

Telif Hakkı © 2000 BeOpen.com.  Tüm hakları saklıdır.

Telif Hakkı © 1995-2001 Corporation for National Research Initiatives.  Tüm hakları saklıdır.

Telif Hakkı © 1991-1995 Stichting Mathematisch Centrum.  Tüm hakları saklıdır.

Bu yazılımın geçmişi, kullanım koşulları ve TÜM GARANTİLERDEN FERAGAT beyanı için `LICENSE <https://github.com/python/cpython/blob/main/LICENSE>`_ dosyasına bakınız.

Bu Python dağıtımı *hiçbir* GNU Genel Kamu Lisansı (GPL) kodu içermez, bu nedenle tescilli projelerde kullanılabilir. Bazı GNU kodlarına arayüzler vardır, ancak bunlar tamamen isteğe bağlıdır.

Burada atıfta bulunulan tüm ticari markalar ilgili sahiplerinin mülkiyetindedir.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---