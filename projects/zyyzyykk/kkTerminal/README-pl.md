# kkTerminal

> kkTerminal, terminal do połączeń Web SSH
>
> Autor: [zyyzyykk](https://github.com/zyyzyykk/)
>
> Kod źródłowy: https://github.com/zyyzyykk/kkTerminal
>
> Adres Docker Hub: https://hub.docker.com/repository/docker/zyyzyykk/kkterminal/general
>
> Podgląd: https://ssh.kkbpro.com/
>
> Data aktualizacji: 2025-03-15
>

<p align="center"><a href="https://ssh.kkbpro.com/" target="_blank" rel="noopener noreferrer"><img width="100" src="https://kkbapps.oss-cn-shanghai.aliyuncs.com/logo/terminal.png" alt="kkTerminal"></a></p>

<p align="center">
  <a href="https://hub.docker.com/repository/docker/zyyzyykk/kkterminal/general"><img src="https://img.shields.io/docker/pulls/zyyzyykk/kkterminal?logo=docker" alt="Docker Image"></a>
  <a href="https://www.oracle.com/cn/java/technologies/downloads/#java8-windows"><img src="https://img.shields.io/badge/jdk-1.8-orange?logo=openjdk&logoColor=%23e3731c" alt="JDK Version"></a>
  <a href="https://spring.io/projects/spring-boot"><img src="https://img.shields.io/badge/springboot-2.7.15-green?color=6db33f&logo=springboot" alt="SpringBoot Version"></a>
  <a href="https://cn.vuejs.org/"><img src="https://img.shields.io/badge/vue-3.x-green?color=42b883&logo=vue.js" alt="Vue Version"></a>
  <a href="https://www.apache.org/licenses/"><img src="https://img.shields.io/badge/licence-Apache-red?logo=apache&logoColor=%23D22128" alt="Apache Licence"></a>
  <a href="https://github.com/zyyzyykk/kkTerminal"><img src="https://img.shields.io/github/stars/zyyzyykk/kkterminal" alt="GitHub"></a>
</p>
<p align="center">English ｜ <a href="https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/zh_CN/README.md" >简体中文</a></p>

### ⚡ Szybka integracja

Do szybkiej integracji użyj znacznika `iframe` w stronach HTML:

```html
<iframe src="https://ssh.kkbpro.com/" height="400px" width="600px" ></iframe>
```

### 🐳 Wdrażanie przez Docker

1. Pobierz obraz:

```bash
docker pull zyyzyykk/kkterminal
```

2. Utwórz i uruchom kontener z mapowaniem portu: `-p port:3000`

```bash
docker run -d --name kkterminal -p 3000:3000 zyyzyykk/kkterminal
```

3. Własny napis artystyczny: `-e TITLE="ArtWord"`

```bash
docker run -d --name kkterminal -p 3000:3000 -e TITLE="kkbpro" zyyzyykk/kkterminal
```

4. Dostęp w przeglądarce: `http://server-ip:3000/`

### 🛸 Podgląd

Odwiedź stronę: https://ssh.kkbpro.com/

![Connect](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/Connect.png)

![Preference](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/Preference.png)

![File](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/File.png)

![Editor](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/Editor.png)

[**Więcej podglądów modułów**](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/MODULE.md)

### 💡 Opis funkcji

1. kkTerminal to terminal do połączeń Web SSH. Kliknij ikonę terminala w lewym górnym rogu i wybierz ustawienia połączenia, aby ustanowić połączenie SSH

2. Obsługa integracji na stronach internetowych przez znacznik `iframe`

3. Obsługa dostosowywania konfiguracji terminala przez [parametry URL](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/PARAMS.md)

4. Obsługa internacjonalizacji oraz przełączania języka między chińskim a angielskim

5. Obsługa lokalnego wdrożenia na komputerze PC, automatycznie otwiera okno przeglądarki po uruchomieniu

6. Obsługa adaptacyjnego rozmiaru okna i chińskiego wprowadzania znaków

7. Obsługa własnych ustawień preferencji, użytkownik może wybrać kolor tła/tekstu, rozmiar czcionki, styl wyświetlania kursora, włączyć TCode dla terminala itp.

8. Obsługa restartu: terminal automatycznie się zrestartuje po zmianie ustawień połączenia SSH lub własnych preferencji, lub można go ręcznie zrestartować po rozłączeniu SSH

9. Obsługa kopiowania i wklejania:

   - Kopiowanie: Jak w terminalu `Git`, zaznaczenie tekstu automatycznie go kopiuje

   - Wklejanie: Jak w terminalu `Cmd`, kliknięcie prawym przyciskiem myszy wkleja (wymaga zezwolenia przeglądarki)


9. Obsługa zarządzania plikami, otwórz moduł zarządzania plikami, aby przeglądać, rozpakowywać, wysyłać i pobierać pliki/foldery

10. Obsługa skrótów klawiszowych, takich jak wybieranie wielu/wszystkich plików, kopiowanie i wklejanie, wycinanie, przełączanie zaznaczenia, otwieranie itp.

11. Obsługa przeglądania i edycji plików, modyfikuj pliki i zapisuj je na zdalnym serwerze za pomocą `ctrl+s`

12. Obsługa [TCode (Terminal Code)](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/TCODE.md), który umożliwia zautomatyzowane przepływy pracy podobne do skryptów Shell poprzez własny TCode

13. Obsługa rejestracji operacji i synchronizacji w chmurze

14. Obsługa funkcji Cooperate, Monitor i Docker

### 👨‍💻 Historia aktualizacji

##### zyyzyykk/kkterminal:3.6.0: latest

- Dodano zaawansowaną funkcję Cooperate
- Dodano zaawansowaną funkcję Monitor
- Dodano zaawansowaną funkcję Docker
- Optymalizacja objętości paczki i wyświetlania strony

##### zyyzyykk/kkterminal:3.5.6: 

- Obsługa większej liczby parametrów URL
- Dodano edytor tekstu i procentowy rozmiar obrazu
- Optymalizacja wyświetlania strony

##### zyyzyykk/kkterminal:3.5.3: 

- Dodano parametr URL do dostosowania konfiguracji terminala
- Naprawiono błąd restartu wielu okien
- Dodano rejestrację operacji i synchronizację w chmurze
- Refaktoryzacja niektórych fragmentów kodu

[**Historia aktualizacji**](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/UPDATE.md)

### 🧬 Architektura

```markdown
+---------+     http      +-------------+    ssh     +---------------+
| browser | <===========> | kk Terminal | <========> | remote server |
+---------+   websocket   +-------------+    sftp    +---------------+
Vue + Xterm              SpringBoot + SSHJ                Linux OS    
```

### 🏘️ O projekcie

Drodzy Użytkownicy,

Z przykrością informuję, że z powodu ograniczonego czasu i energii nie będę w stanie dalej utrzymywać projektu `kkTerminal`.

Jeżeli jesteś zainteresowany `kkTerminal` lub chciałbyś go dalej utrzymywać, proszę skontaktuj się ze mną lub zgłoś issue.

Jeśli znajdziesz błędy lub chcesz dodać nowe funkcje, również zgłoś issue.

Na koniec dziękuję za wsparcie dla `kkTerminal` i szczerze mam nadzieję, że `kkTerminal` naprawdę Ci pomoże.

Z wyrazami szacunku,

[zyyzyykk](https://github.com/zyyzyykk/)

2025.03.15

### 🌟 Gwiazdki

[![Stars](https://starchart.cc/zyyzyykk/kkTerminal.svg?variant=adaptive)](https://starchart.cc/zyyzyykk/kkTerminal)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---