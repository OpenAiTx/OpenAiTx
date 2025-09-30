<div align="right">
  <details>
    <summary >🌐 Inne języki</summary>
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


[English](https://raw.githubusercontent.com/sz30/2048--/main/README.md) | [简体中文](https://raw.githubusercontent.com/sz30/2048--/main/README.zh-CN.md) | [繁體中文](https://raw.githubusercontent.com/sz30/2048--/main/README.zh-TW.md)

# 🎮 2048++

Ulepszona wersja klasycznej gry 2048, teraz z jeszcze większą ilością fajnych funkcji! To mały projekt, który stworzyłem w wolnym czasie—mam nadzieję, że sprawi Ci radość!

## 🎯 Wprowadzenie do gry

2048 to prosta, ale wciągająca gra polegająca na łączeniu liczb. Na planszy 4x4 przesuwaj kafelki w górę, dół, lewo lub prawo, aby łączyć te o tej samej wartości. Cel? Osiągnąć 2048 (a potem możesz grać dalej dla jeszcze wyższych wyników)!

**Jak grać:**
- Użyj strzałek lub klawiszy WASD, aby przesuwać kafelki.
- Gdy dwa kafelki z tym samym numerem się zderzą, łączą się w jeden.
- Po każdym ruchu w losowym pustym miejscu pojawi się nowa 2 lub 4.
- Gra kończy się, gdy nie ma już możliwych ruchów.

## ✨ Funkcje specjalne

### 1. Funkcja Cofania
- Wykonałeś zły ruch? Bez obaw!
- Po prostu naciśnij przycisk "Cofnij", aby wrócić o jeden krok.
- Możesz cofać się dowolną ilość razy, aż do początku gry.
- Nigdy więcej przypadkowy ruch nie zepsuje ci rozgrywki!

### 2. Sekretny Tryb Oszukiwania
- Wpisz magiczną sekwencję: ←←→→ →→←← (lewo, lewo, prawo, prawo, prawo, prawo, lewo, lewo)
- Wszystkie kafelki magicznie zamienią się w 128!
- To wielkanocna niespodzianka, tylko dla zabawy.
- Porada: Oszukiwanie jest fajne, ale nie przesadzaj! 😉

## 🎯 Demo

🎯 : [Zagraj tutaj](http://2048.765431.xyz/)
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
- `2048.py`: Serwer backendowy napisany we Flasku, obsługuje logikę gry oraz zapytania API.
- `script.js`: Logika gry po stronie frontend, w tym ruchy, animacje i funkcje specjalne.
- `styles.css`: Style gry, zapewniające estetyczny i responsywny wygląd.
- `index.html`: Strona główna, która łączy wszystkie elementy.

## 🚀 Pierwsze kroki

**Metoda 1: Pobierz wersję wydaną**
1. Pobierz najnowszą wersję wydania.
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

Chcesz dostosować do swoich potrzeb? Zmień `styles.css`, aby nadać nowy wygląd, lub zajrzyj do `script.js`, żeby zmodyfikować rozgrywkę. Cały kod jest dobrze skomentowany, więc łatwo go edytować!

## 📝 Licencja

Licencja GPL-2.0

## 🤝 Współtworzenie

Projekt jest stale aktualizowany! Zgłoszenia błędów i Pull Requesty są bardzo mile widziane—razem możemy uczynić tę grę jeszcze lepszą!


## 🙏 Podziękowania

Podziękowania dla następujących sponsorów za wsparcie projektu:
- [Aurora Cloud](https://www.free-vps.net/) za udostępnienie serwera

---
_Ostatnia aktualizacja: październik 2025_


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-29

---