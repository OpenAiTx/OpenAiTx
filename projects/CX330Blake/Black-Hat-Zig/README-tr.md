# Black-Hat-Zig

<p align="center">
  <img alt="GitHub License" src="https://img.shields.io/github/license/CX330Blake/black-hat-zig">
  <img alt="GitHub top language" src="https://img.shields.io/github/languages/top/cx330blake/black-hat-zig">
  <img alt="GitHub repo size" src="https://img.shields.io/github/repo-size/cx330blake/black-hat-zig">
  <img alt="X (formerly Twitter) Follow" src="https://img.shields.io/twitter/follow/CX330Blake">
</p>

<p height="350px" align="center">
  <img src="https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Black-Hat-Zig.png">
  <br/>
  <b>Merhaba hackerlar. Merhaba maldevler. Merhaba reverserlar. Zig'in karanlık gücünü keşfetmek için burada olmanız harika!</b><br/><br/>
  <b><a href="https://github.com/cx330blake">@CX330Blake</a> tarafından yönetilmekte ve sürdürülmektedir</b>
</p>

---

## İçindekiler

- [Giriş](#giriş)
- [Neden Zig?](#neden-zig)
- [Kodların Derlenmesi](#kodların-derlenmesi)
- [Payload Yerleştirme](#payload-yerleştirme)
- [Payload Karmaşıklaştırma](#payload-karmaşıklaştırma)
- [Payload Şifreleme](#payload-şifreleme)
- [Payload Çalıştırma](#payload-çalıştırma)
- [Reverse Shell](#reverse-shell)
- [Zararlı Yazılım Teknikleri](#zararlı-yazılım-teknikleri)
- [Maldev Araçları](#maldev-araçları)
- [Katkıda Bulunanlar](#katkıda-bulunanlar)
- [Kaynaklar & Referanslar](#kaynaklar--referanslar)
- [Yıldız Geçmişi](#yıldız-geçmişi)
- [Feragatname](#feragatname)

## Giriş

> [!IMPORTANT]
> Bu proje sürekli olarak güncellenmektedir!

Bu proje, Zig dilini kullanarak birçok zararlı yazılım tekniğinin uygulanmasını sağlar çünkü ben onun büyük bir hayranıyım. Bu repoyu Zig'i silahlandırmak için kullanabilirsiniz. Black-Hat-Zig, olabildiğince fazla içerik barındırmasını sağlamak amacıyla sürekli güncellenmektedir. Bu proje için bir PR oluşturmak isterseniz harika olur.

Tamam, hadi gezegeni hackleyelim!

## Neden Zig?

- 🤝 C/C++ kaynak kodlarıyla kolay etkileşim
- 🔎 Daha yeni bir dil olduğu için tespiti daha zor
- 💪 Çok düşük seviyede kontrol, hatta C'den bile daha düşük
- 😱 Modern derleyici nedeniyle tersine mühendisliği daha zor
- 🛡️ Minimum çalışma zamanı bağımlılıkları - Büyük bir standart kütüphane izi yok
- 🎯 Tanımsız davranış yok - Kenar durumlarının açıkça ele alınması sayesinde çökme önlenir

## Kodların Derlenmesi

Her dizin içindeki kodları kontrol edebilirsiniz. Ayrıca, kod Windows API kullanıyorsa, ilgili proje dizinindeki `README.md` dosyasında bununla ilgili bir ipucu göreceksiniz, örneğin, [bu örnekteki gibi](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/bcrypt_aes/).

Windows API gerektirenler için varsayılan yapı hedefini `windows-x86_64` olarak ayarladım, böylece aşağıdaki komutu kolayca kopyalayıp yapıştırarak Linux, Windows, hatta MacOS üzerinde kodu derleyebilirsiniz! (Ama çalıştırılabilir dosyaları çalıştırmak için yine de bir Windows ortamına ihtiyacınız olacak)

```bash
zig build
```

## Payload Yerleştirme

Kötü amaçlı payloadların bir yürütülebilir dosyanın çeşitli bölümlerine yerleştirilmesi teknikleri.

- [.data Bölümü](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_data_section/)
- [.rdata Bölümü](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_rdata_section/)
- [.text Bölümü](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_text_section/)
- [.rsrc Bölümü](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_rsrc_section/)

## Payload Karmaşıklaştırma

Payloadları gizlemek ve statik analiz veya desen eşleştirme yoluyla tespitten kaçınmak için karmaşıklaştırma teknikleri.

- [IP Adresi Karmaşıklaştırma](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/)
  - [IPv4 Karmaşıklaştırma](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv4_obfuscation/)
  - [IPv4 Karmaşıklaştırma Çözme](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv4_deobfuscation/)
  - [IPv6 Karmaşıklaştırma](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv6_obfuscation/)
  - [IPv6 Karmaşıklaştırma Çözme](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv6_deobfuscation/)
- [MAC Adresi Karmaşıklaştırma](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/MAC-Address-Obfuscation/)
  - [MAC Adresi Karmaşıklaştırma](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/MAC-Address-Obfuscation/MACFuscation/)
  - [MAC Adresi Karmaşıklaştırma Çözme](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/MAC-Address-Obfuscation/MACDeobfuscation/)
- [UUID Karmaşıklaştırma](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/UUID-Obfuscation/)
  - [UUID Karmaşıklaştırma](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/UUID-Obfuscation/UUIDFuscation/)
  - [UUID Karmaşıklaştırma Çözme](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/UUID-Obfuscation/UUIDDeobfuscation/)

## Payload Şifreleme

Bir payload'un depolama veya iletim sırasında gerçek amacını gizlemek için kullanılan çeşitli şifreleme yöntemleri.

- [XOR Şifreleme](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/XOR/)
  - [Standart Kütüphane ile XOR](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/XOR/std_lib_xor/)
- [RC4 Şifreleme](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/RC4/)
  - [SystemFunction032 ile RC4](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/RC4/system_function_032_rc4/)
- [AES Şifreleme](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/)
  - [Bcrypt.h ile AES](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/bcrypt_aes/)
  - [Standart Kütüphane ile AES](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/std_aes/)
  - [TinyAES ile AES](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/tiny_aes/)

## Payload Çalıştırma

- [DLL](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Execution/dll/)
- [Shellcode](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Execution/shellcode/)

## Reverse Shell

C2 erişimi veya post-exploitation kontrolü için reverse shell kurulumuna yönelik ilkeler.

- [Standart Kütüphane ile Reverse Shell](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Reverse-Shell/std_reverse_shell/)

## Zararlı Yazılım Teknikleri

Zig'e uyarlanmış yaygın saldırgan teknikleri koleksiyonu.

- [Process Injection](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Injection/)
  - [DLL Enjeksiyonu](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Injection/dll_injection/)
  - [Shellcode Enjeksiyonu](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Injection/shellcode_injection/)
- [Payload Staging](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Payload-Staging/)
  - [Web Sunucusundan](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Payload-Staging/web_server/)
  - [Windows Kayıt Defterinden](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Payload-Staging/windows_registry/)
- [Process Enumeration](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/)
  - [CreateToolhelp32Snapshot Kullanarak](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/create_tool_help_32_snapshot/)
  - [EnumProcesses Kullanarak](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/enum_processes/)
  - [NtQuerySystemInformation Kullanarak](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/nt_query_system_information/)

## Maldev Araçları

- [ZYRA: Senin Çalışma Zırhın](https://github.com/cx330blake/zyra)
  - Zig ile yazılmış bir çalıştırılabilir dosya paketleyici
- [ZYPE: Senin Payload Şifreleyicin](https://github.com/cx330blake/zype)
  - Şifrelenmiş/karmaşıklaştırılmış payload'unu ve ilgili çözüm/şifre çözme fonksiyonunu içeren Zig kod şablonu üretir.

## Katkıda Bulunanlar

Bu proje ağırlıklı olarak [@CX330Blake](https://github.com/CX330Blake) tarafından yönetilmekte ve sürdürülmektedir. PR'lar kabul edilmektedir. Umarım daha fazla kişi Zig'i zararlı yazılım geliştirme için kullanır ve ekosistem daha olgun hale gelir.

Bu katkıcılar için büyük teşekkürler!

<a href="https://github.com/CX330Blake/black-hat-zig/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=CX330Blake/black-hat-zig" />
</a>

## Kaynaklar & Referanslar

- [Maldev Academy](https://maldevacademy.com/)
- [OffensiveNim](https://github.com/byt3bl33d3r/OffensiveNim)

## Yıldız Geçmişi

[![Star History Chart](https://api.star-history.com/svg?repos=CX330blake/black-hat-zig&type=Date)](https://www.star-history.com/#CX330blake/black-hat-zig&Date)

## Feragatname

Bu proje sadece etik ve eğitim amaçlıdır. Siber suçlu olmayın.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---