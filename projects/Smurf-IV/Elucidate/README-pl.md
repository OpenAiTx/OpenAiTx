
<div align="right">
  <details>
    <summary >🌐 Język</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

﻿# Elucidate

- [Opis projektu](#project-description)
- [Wymagania systemowe:](#os-requirements)
- [Najczęściej zadawane pytania](#faqs)
- [Plan działania](#roadmap)
- [Zrzuty ekranu](#screenshots)

## Opis projektu

Elucidate to graficzny interfejs użytkownika dla aplikacji SnapRAID działającej z linii poleceń na Windows.

*Ten projekt kontynuuje połączenie świetnej pracy wykonanej przeze mnie i innych współtwórców.

## Wymagania systemowe

- System operacyjny Windows
- .Net Runtime 4.8.0
- SnapRaid w wersji 11.5 lub niższej
- 10MB wolnego miejsca na docelowym dysku

## Najczęściej zadawane pytania

**Q**: Czym jest SnapRAID?<br/>
**A**: SnapRAID to silnik snapshot-parity definiowany programowo dla systemów operacyjnych Windows i Linux. Na najbardziej podstawowym poziomie zapewnia ochronę zawartości systemu plików, obliczając hashe jego komponentów i zapisując wyniki w pliku parzystości. W przypadku całkowitej awarii dysku twardego plik parzystości może zostać użyty do odtworzenia utraconych danych. Szczegółowe informacje znajdziesz na [oficjalnej stronie porównania silników ochrony plików SnapRAID.](http://snapraid.sourceforge.net/compare.html)

**Q**: Po co GUI, przecież linia poleceń działa!<br/>
**A**: Głównym celem jest stworzenie kompletnego GUI z dodatkowymi funkcjami zarządzania, mającymi pomóc użytkownikowi w utrzymaniu funkcjonującego środowiska SnapRAID. Czasami „wskaż i kliknij” są łatwiejsze dla początkujących. Techniczna dokumentacja SnapRAID i głęboka konfigurowalność mogą zniechęcać osoby chcące wypróbować program!

**Q**: Nadal nie jestem pewien, czy jest coś więcej?<br/>
**A**: Tak, zobacz [dokumentację](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./docs/Documentation.md) ze zdjęciami itp.

**Q**: Jakie są więc „większe cele”?<br/>
**A**: Zobacz __Roadmap__ poniżej, aby uzyskać pełny podział.

## Roadmap

- [x] Faza I
  - [x] Utrzymanie minimalnego wsparcia dla najnowszej wersji SnapRAID. - __W toku.__
  - [x] Łatwość użycia
  - [x] SnapRAID ma trzy polecenia, więc zróbmy je łatwo dostępne dla początkującego 
  - [x] Wskaźnik postępu 
  - [x] Logowanie „Interaktywne” oraz bezpośrednio do logu. 
  - [x] Automatyczne uruchamianie przy logowaniu użytkownika 
  - [x] Podpowiedzi narzędziowe •	

- [x] Faza II Propozycje funkcji dla Fazy II
  - [x] Pauza, zmiana priorytetu, przerwanie.
  - [x] Rozszerzenie poleceń - "Pozwól na dodatkowe parametry do domyślnych ustawień."
  - [x] Harmonogramowanie
    - Usunięto, użyj CommandLine
  - [x] Widok graficzny chronionych danych.

- [ ] Faza III (Restart od 2017-03)
  - [x] Nowy kompilator i .Net 4.7.x	
  - [x] Interfejs wiersza poleceń
  - [ ] Nowy układ przez Krypton Toolkit / Navigator / itd.
    - W trakcie
  - [ ] Tłumaczenia
  - [x] Nowe polecenia
  - [ ] Mailer ze sprawozdaniami statusu
  - [ ] Dokumentacja kroków testowych
    - W trakcie
  - [ ] Dodanie do dokumentacji / aktualizacja obrazów
    - W trakcie
  - [ ] Dodanie raportowania błędów do _Windows EventLog_
  - [x] Dodanie _ExceptionLess_ do raportowania wyjątków online
  - [x] Pokazanie, co można odzyskać.

- [ ] Faza IV (nowe polecenia SnapRAID?)
  - [ ] Rozszerzona pomoc przy odzyskiwaniu dysku - interaktywne przewodniki itd.
  - [ ] Powiadom użytkownika, jeśli jego wersja SnapRAID jest nieaktualna
  - [ ] Interpretacja logów SnapRAID (wykorzystywanych przez zmiany poniżej)
  - [ ] Podanie statusu macierzy po wykonaniu polecenia
  - [ ] Modyfikacja polecenia sync, aby zawierało początkowy diff
  - [ ] Modyfikacja polecenia sync, aby zgłaszało ostrzeżenie, jeśli diff wykazał problemy powyżej progu
  - [ ] Dodanie konfigurowalnych ustawień dla wymagań progu synchronizacji


## Zrzuty ekranu

![Widok początkowy](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./Images/starting_view.png)

![Formularz ustawień](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./Images/Settings_Form.PNG)


## Czy możesz pomóc?
- Poszukiwani testerzy (wszystkie platformy .Net)
- Może pomóc w tłumaczeniu
- Pomoc / przewodniki interfejsu użytkownika
- Jakieś inne pomysły :-)
- Programiści do realizacji pomysłów


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-30

---