
<div align="right">
  <details>
    <summary >🌐 Język</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Xbox_SMC
Zrzuty PIC16/Xyclops z oryginalnego Xboxa oraz bazy danych IDA wraz z częściowym reverse engineeringiem.

![Obraz PIC16LC63A z oryginalnego Xboxa](https://raw.githubusercontent.com/Prehistoricman/Xbox_SMC/master/pic16lc63a.jpg)

# Programowanie Xyclops (XycloMod)
Zobacz [katalog Xyclops oraz README](/Xyclops)

# Zrzuty
Plik .bin dla każdego zrzutu PIC ma zamienione bajty, aby poprawnie ładować go do IDA. Tak więc pierwsze słowo pamięci PIC to byte_0 + byte_1 << 8.

Bazy danych .idb IDA zawierają informacje o zmiennych i pewne obserwacje na notatniku bazy danych.

Zobacz tę stronę wiki, aby uzyskać podział wersji SMC: https://xboxdevwiki.net/Xboxen_Info

## B2A
Zrzucone z Xboxa DVT3. Ten sam słowo konfiguracyjne co P01. Ma również ID urządzenia wypalone w obszarze konfiguracyjnym jako 0000 0000 000B 002A, w przeciwieństwie do produkcyjnych PIC.

Całkowicie brakuje wyzwania rozruchowego.

## D01
Zrzucone z Xboxa XDK BETA 2. Identyczne z P01 oprócz braku wyzwania rozruchowego. Funkcja obliczająca oczekiwaną odpowiedź wyzwania rozruchowego nadal istnieje, ale nigdy nie jest wywoływana.

## DXF
Zrzucone z zestawu debugowania XDK D2. Bardzo podobne do D01, ale z nieco inną logiką tacki, przegrzania i rozruchu. Wyzwanie rozruchowe brakujące w ten sam sposób co w D01.

## D2E
Zrzucone z zestawu deweloperskiego Tuscany (v1.6). Układ Xyclops oznaczony jako X01202-001, i brak linii A-A02 lub A-B01, którą mają jednostki detaliczne.

Kod debugowania portu szeregowego przy FC00 pasuje do zrzutu detalicznego P2L. Od 0x4000 do 0xFBFF występuje dziwny wzór danych.

## P01
Zrzucone z Xboxa v1.0. Słowo konfiguracyjne to 0x86:
- CP1:CP0 = 0 (Ochrona kodu włączona dla całej pamięci)
- BODEN = 0 (Reset przy spadku napięcia wyłączony)
- ~PWRTE = 0 (Timer rozruchowy włączony)
- WDTE = 1 (Timer Watchdog włączony)
- FOSC1:FOSC0 = 2 (Oscylator HS)

Wartość konfiguracyjna 0x3FB6 jest odpowiednia dla klonów SMC, aby nie miały włączonej ochrony kodu.

## P11
Zrzucone z Xboxa v1.3. Ten sam słowo konfiguracyjne co P01.

W P11 względem P01 jest kilka drobnych zmian, w tym dodatkowa komenda SMBus (zapis 0x22), inne priorytety LED i bardziej elastyczne czasy rozruchu.

Sprawdziłem zaszyfrowane zrzuty v1.3 względem v1.4 i były zgodne. Oznacza to, że bardzo prawdopodobne, iż mają ten sam program.

## P2L
Zrzucone z Xboxa v1.6. Rewizja Xyclops A-A02. Zawiera kod Intel 8051, ale posiada wiele specjalnych rejestrów funkcyjnych o nieznanym przeznaczeniu.

Debugowanie przez port szeregowy jest zasilane przez kod pod adresem FC00. Wygląda na prymitywny debugger, który może zatrzymać wykonywanie, zrzucić dane i zapisywać do rejestrów/PAM.

# Zrzucanie Xyclops

Chip Xyclops posiada 3 piny do 'debugowania': TXD (pin 64), RXD (pin 63) oraz DEBUG (pin 29). Ustawienie pinu DEBUG na wysoki włącza port szeregowy na pinach TX i RX. Port szeregowy działa z prędkością 9600 bodów.

Protokół opiera się na 4-bajtowych poleceniach, które zazwyczaj mają format `<cmd>` `<adres MSByte>` `<adres LSByte>` `<dowolna wartość>`

Komenda 0x14 zrzuca 64 bajty danych BIOS na raz, a 0x15 zrzuca 64 bajty programu SMC na raz. Zrzut z Xyclops, P2L.bin, jest dołączony do repozytorium. [xyclops_dumper.py](/Xyclops/xyclops_dumper.py) również jest dostępny, abyś mógł zrzucić dane ze swojego urządzenia.

# Metodologia zrzutu PIC
Pełny opis na https://wiki.recessim.com/view/PIC_Burnout

PIC ma włączoną ochronę kodu, więc wszystkie dane odczytywane są jako 0000. Użyłem pewnej sztuczki, aby uzyskać zamiast tego zaszumione dane, odkryłem algorytm szyfrowania używając poświęconego chipa, a następnie zastosowałem exploit, by zmienić dane ROM i ustawić kilka bitów na znane wartości. Dzięki temu mogłem wyodrębnić potrzebne informacje z wielu zaszumionych zrzutów i odbudować oryginalne dane.

# PICProgrammer
PICProgrammer jest jednym z kilku projektów Arduino dla RP2040, których użyłem w swoich badaniach. Zapewnia prosty interfejs wiersza poleceń do wykonywania operacji ICSP (programowanie szeregowe w układzie) na PIC. Preferowane jest to nad używaniem dedykowanego programatora, takiego jak PICkit, ze względu na elastyczność oraz możliwość wykonywania działań nieprzewidzianych przez producenta.

Powinieneś dobrze znać elektronikę i programowanie przed użyciem tego narzędzia, oraz dokładnie przejrzeć, co robią polecenia przed ich wykonaniem.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-20

---