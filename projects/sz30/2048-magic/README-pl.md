<div align="right">
  <details>
    <summary >🌐 Inny język</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>


[English](https://raw.githubusercontent.com/sz30/2048-magic/main/README.md) | [简体中文](https://raw.githubusercontent.com/sz30/2048-magic/main/README.zh-CN.md) | [繁體中文](https://raw.githubusercontent.com/sz30/2048-magic/main/README.zh-TW.md)

# 🎮 2048++

Ulepszona wersja klasycznej gry 2048, teraz z jeszcze większą liczbą fajnych funkcji! To mały projekt, który stworzyłem w wolnym czasie — mam nadzieję, że sprawi Ci radość!

## 🎯 Wprowadzenie do gry

2048 to prosta, ale wciągająca gra polegająca na łączeniu liczb. Na siatce 4x4 przesuwaj w górę, w dół, w lewo lub w prawo, aby łączyć kafelki o tych samych numerach. Cel? Osiągnąć 2048 (ale hej, możesz grać dalej dla jeszcze wyższego wyniku)!

**Jak grać:**
- Użyj strzałek lub klawiszy WASD, aby przesuwać kafelki.
- Gdy dwa kafelki z tym samym numerem się zderzą, łączą się w jeden.
- Po każdym ruchu losowo pojawia się nowy kafelek 2 lub 4 w pustym miejscu.
- Gra kończy się, gdy nie ma już możliwych ruchów.

## ✨ Funkcje specjalne

### 1. Cofanie ruchu
- Wykonałeś zły ruch? Nie martw się!
- Wystarczy nacisnąć przycisk "Cofnij", aby wrócić o jeden krok.
- Możesz cofać się dowolnie wiele razy, aż do samego początku.
- Już nigdy przypadkowe dotknięcie nie zrujnuje Twojej gry!

### 2. Tajny tryb oszustwa
- Wpisz magiczną sekwencję: ←←→→ →→←← (lewo, lewo, prawo, prawo,  prawo, prawo, lewo, lewo)
- Wszystkie kafelki magicznie zamienią się w 128!
- To wielkanocne jajko, tylko dla zabawy.
- Wskazówka: Oszukiwanie jest fajne, ale nie przesadzaj! 😉

## 🎯 Demo

🎯 Zagraj tutaj: [http://2048.ct8.pl](http://2048.ct8.pl:9969/)
<img width="1279" alt="demo" src="https://github.com/user-attachments/assets/0df2c956-b6d9-4371-a916-f6ac3ae642be" />



## 📁 Struktura projektu
```
2048/
├── static/
│ ├── css/
│ │ └── styles.css # Game styles
│ └── js/
│ └── script.js # Frontend game logic
├── index.html # Main game page
└── 2048.py # Backend server
```
**Opis plików:**
- `2048.py`: Serwer backendowy napisany we Flasku, obsługuje logikę gry i żądania API.
- `script.js`: Logika gry po stronie frontendu, w tym ruchy, animacje i funkcje specjalne.
- `styles.css`: Style gry, dbające o estetykę i responsywność.
- `index.html`: Strona główna, która wszystko ze sobą łączy.

## 🚀 Szybki start

**Metoda 1: Pobierz wydanie**
1. Pobierz najnowsze wydanie.
2. Upewnij się, że masz zainstalowanego Pythona 3.x.
3. Zainstaluj zależności: `pip install flask`
4. Uruchom: `python 2048.py`
5. Otwórz przeglądarkę i przejdź do: [http://localhost:9969](http://localhost:9969)

**Metoda 2: Sklonuj z GitHub**
```bash
git clone https://github.com/sz30/2048.git
cd 2048
pip install flask
python 2048.py
```
## 🎨 Personalizacja

Chcesz dostosować grę do siebie? Edytuj `styles.css`, aby zmienić wygląd, lub zagłęb się w `script.js`, aby zmodyfikować rozgrywkę. Cały kod jest szczegółowo skomentowany dla łatwego modyfikowania!

## 📝 Licencja

Licencja GPL-2.0

## 🤝 Współtworzenie

Wciąż aktualizujemy! Zgłoszenia błędów i Pull Requesty są bardzo mile widziane — sprawmy, by ta gra była jeszcze lepsza razem!


## 🙏 Podziękowania

Dziękujemy następującym sponsorom za wsparcie tego projektu:
- [Serv00](https://www.serv00.com/) za udostępnienie serwera

---
_Ostatnia aktualizacja: czerwiec 2025_



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---