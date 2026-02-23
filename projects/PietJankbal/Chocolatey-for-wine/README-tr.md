
<div align="right">
  <details>
    <summary >🌐 Dil</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Chocolatey-for-wine

Chocolatey paket yöneticisi, wine içinde otomatik kurulum aracı; wine'da hızlıca program yüklemek için kullanışlıdır (ve ardından wine'da hataları bulmak için ;) )  
Bazı hatalar için Visual Studio Community 2022 ve nodejs gibi çözümler eklendi, daha fazla bilgi için devam edin.  

Karantina sırasında canım sıkıldığı için özel bir winetricks(.ps1) yazdım, kullanışlı bulduğum komutlarla. Sadece 'winetricks' komutunu çalıştırarak onları görebilirsiniz.
Bazı komutlar için wine'ın tamamen yeniden başlatılması gerekir (son wine değişiklikleri nedeniyle). Bir mesaj kutusu görürsünüz ve oturum sonlandırılır. Sadece powershell'i tekrar başlatıp komutu tekrar deneyin. Bu bir kez yapıldığında, herhangi bir komut için tekrar gerekmez.  

Örnek:  

'winetricks vs22_interactiveinstaller'  ( --> oturum sona erecek)  

'yine powershell' komutunu uygulayın  

'winetricks vs22_interactiveinstaller' komutunu uygulayın  


(Bu arada 'winetricks vs22_interactive_installer' ile Visual Studio 2022 yükleyicisi üzerinden ne yükleyeceğinizi seçebilirsiniz; 'winetricks vs22_interactive_installer' beni on dakika içinde ana programa ulaştırdı (C++ ile Masaüstü geliştirme seçildi)).

Kurulum :
- Sürüm zip dosyasını indirip çıkarın ve 'wine ChoCinstaller_0.5c.751.exe' komutunu uygulayın (tamamlanması yaklaşık bir dakika sürer)

Opsiyonel:
- Yükleyiciyi 'wine ChoCinstaller_0.5a.751.exe /s' şeklinde çalıştırın, böylece kurulum dosyaları (örneğin Powershell*.msi ve dotnet48) 
  Belgelerim'e kaydedilir ve yeni bir önek oluşturursanız tekrar indirmeniz gerekmez)
Opsiyonel:
- Yükleyiciyi 'wine ChoCinstaller_0.5a.751.exe /q' şeklinde çalıştırarak powershell penceresinin otomatik olarak açılmasını engelleyebilirsiniz (sadece kurulum yapılır). 

Opsiyonel:
- Her şeyin düzgün gidip gitmediğini kontrol edin: "choco install chromium" ve  "start chrome.exe (--no-sandbox artık wine-8,4 ile gerekli değil)" 

![2022-08-26 12-31-18 tarihli ekran görüntüsü](https://user-images.githubusercontent.com/26839562/186885380-d5a617c4-9cf4-4831-a475-2bd85a3b5784.png)
PowerShell Hakkında:

İpucu: Chocolatey genellikle bir programın en son sürümünü yükler, bu da yeni wine hatalarını ortaya çıkarabilir. Yazılımın eski bir sürümü ile daha şanslı olabilirsiniz.  
Örnek:  

choco search --exact microsoft-edge --all (--> tüm sürümleri listeler)  

choco install microsoft-edge --version --version='135.0.3179.98'

Genel bilgi:

- 'wine powershell.exe' PowerShell-Core konsolunu başlatır.

 
ConEmu Hakkında:

ConEmu konsolu birkaç wine-hatasından muzdariptir:
  - Konsola geri dönmeyen bir programı sonlandırmak için Ctrl^C çalışmaz. Bunun yerine Shift^Ctrl^C kullanın.
  - ConEmu penceresinde metin seçmek (kopyala/yapıştır için) seçimi vurgulamaz. Dahil edilen, son wine sürümlerine karşı çok temel bir geçici çözüm bu sorunu aşar, böylece vurgulamanın artık çalışması gerekir.
   
Winetricks(.ps1) hakkında:

- Eğer çağırmazsanız ('winetricks' powershell-konsolunda), hiçbir şey indirilmez; bu nedenle ek bir yük yoktur.
- Birçok fiil (ör. powershell 5.1) msu paketlerinden bir şeyler çıkarmak için birkaç temel dosyaya ihtiyaç duyar. Bu temel dosyaların kurulması ilk başta büyük indirmeler gerektirir ve ilk kullanımda çok zaman alır. Ancak dosyalar önbelleğe alındıktan sonra hızlıca devam eder. Örneğin, önce 'winetricks ps51' denemek isterseniz yaklaşık 15 dakika sürer. Diğer bazı fiiller ilk kullanımda 5 dakika sürebilir. Ancak bir fiili bir kez çağırdıktan sonra bu sıkıntı ortadan kalkar.
- Dosyalar MyDocuments dizininde önbelleğe alınır. Tüm fiilleri çağırırsanız orada yaklaşık 800 MB yer kaplar.
- Umarım çeşitli fiiller için daha iyi 64-bit desteği olur.
- Bir dosyayı çıkarma ve (deneme) bir msu dosyasından kurma imkanı. Nasıl yapıldığını görmek için 'winetricks install_dll_from_msu' komutunu kullanın.
- Temel bir Powershell 5.1.
- Deneysel dotnet481 kurulumu ve dotnet35 (mevcut dotnet48 kurulumundan memnun olmayan uygulamalar tarafından gerekebilir).
- Otomatik sekme-tamamlama. Not: Komut satırında birden fazla fiil kullanırken, artık bunlar virgülle ayrılmalı
  (powershell birden fazla argümanı böyle işler)
  Yani 'winetricks riched20 gdiplus' artık çalışmaz, bunun yerine 'winetricks riched20,gdiplus' kullanın
- Bazı programlar, Chocolatey üzerinden denediğinizde wine-hataları nedeniyle kurulamaz/çalışmaz. Onlar için winetricks içinde birkaç çözüm ekledim, aşağıya bakın.
- Çalışan Visual Studio Community 2019 ve 2022 kurmak için özel fiiller (winetricks vs19, vs22 ve vs22_interactive_installer) (ekran görüntüsüne bakın, kurulum >10 dk sürer ve yaklaşık 10GB gerektirir!, kurulumdan sonra c:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\IDE/ dizininden devenv.exe başlatın)
  ![ekran görüntüsü](https://github.com/PietJankbal/Chocolatey-for-wine/assets/26839562/d576a619-c752-4eb1-81c2-6f6b66b50ff6)
- grep, sed, file, less, curl vb. çeşitli unix komutlarına erişim sağlamak için özel fiil (winetricks git.portable, Feragat: bazı komutlar wine hataları nedeniyle henüz çalışmıyor)
- Ayrıca internette bulunan kod parçacıklarından uyarlanmış birkaç powershell betiği de dahil edilmiştir:
    - Invoke-ReflectivePEInjection ile bir exe'yi bir powershell betiğine nasıl gömeceğiniz (exe, görev listesinde görünmez).
    - Şık mesaj kutuları nasıl yapılır
    - Bir powershell betiğini (ps1) exe'ye dönüştürme.
    - Ve birkaç tane daha
 
     
Sistem programları hakkında:

setx.exe gibi basit sistem programlarını c:\\Program Files\Powershell\7\profile.ps1 dosyasında bir fonksiyonla değiştirmek için özellik eklendi.
Veya getmac.exe gibi eksik sistem programlarını ekleyin.
Programlar, olgunlaşmamış veya eksik sistem programları nedeniyle başarısız olursa, programın beklediği çıktıyı döndürecek bir fonksiyon yazılabilir.
profile.ps1 dosyasında (diğerlerinin yanında) biraz daha fazla seçeneği destekleyen bir wmic.exe
ve temel bir setx.exe ekledim.
Ya da sistem programına aktarılan argümanları manipüle edebilirsiniz. Bkz. profile.ps1 ve choc_install.ps1.
Daha karmaşık programlar için bunun da işe yarayacağına dair bir garanti yok...
 
Notlar:


  - Mevcut bir wineprefix üzerinde KULLANMAYIN, yalnızca yeni oluşturulmuş temiz bir prefix'te kullanın! Yükleyici sadece dotnet48'i kendisi aptalca yükler ve kayıt defteri anahtarlarıyla oynar.
    Eğer daha önce winetricks.sh ile herhangi bir dotnet sürümü yüklediyseniz, muhtemelen başarısız olacak ve başarılı olsa bile muhtemelen bozuk bir prefix ile karşılaşacaksınız.
    Programlar için winetricks.sh ile bir şeyler yüklemeniz gerekiyorsa, dotnet* fiillerinden hiçbirini KULLANMAYIN.
    Bu arada 'Arial' ve 'd3dcompiler_47' fiilleri zaten varsayılan olarak kurulu geliyor.
  - WINEARCH=win32 DESTEKLENMEMEKTEDİR!
  - Önceki bir sürümden güncelleme şimdilik (henüz) desteklenmiyor, belki ileride

Derleme:
  - Binarileri indirmek yerine kendiniz derlemek isterseniz: mainv1.c ve installer.c dosyalarındaki derleme talimatlarına bakın
  - Sonra choc_install.ps1 dosyasını aynı dizine kopyalayın
  - Sonra 'wine ChoCinstaller_0.5a.735.exe' komutunu çalıştırın
  


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-23

---