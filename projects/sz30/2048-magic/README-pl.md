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

Ulepszona wersja klasycznej gry 2048, teraz z jeszcze większą ilością zabawnych funkcji! To mały projekt, który stworzyłem w wolnym czasie — mam nadzieję, że sprawi Ci radość!

## 🎯 Wprowadzenie do gry

2048 to prosta, ale wciągająca gra polegająca na łączeniu liczb. Na siatce 4x4 przesuwaj w górę, dół, w lewo lub w prawo, aby łączyć płytki o tych samych numerach. Cel? Osiągnąć 2048 (ale hej, możesz grać dalej, by zdobywać jeszcze wyższe wyniki)!

**Jak grać:**
- Używaj klawiszy strzałek lub WASD, aby przesuwać płytki.
- Gdy dwie płytki z tym samym numerem zderzą się, połączą się w jedną.
- Po każdym ruchu w losowym wolnym miejscu pojawi się nowa 2 lub 4.
- Gra kończy się, gdy nie można wykonać już żadnego ruchu.

## ✨ Specjalne funkcje

### 1. Funkcja Cofnij
- Zrobiłeś zły ruch? Bez obaw!
- Po prostu kliknij przycisk "Cofnij", aby wrócić o jeden krok.
- Możesz cofać tyle razy, ile chcesz, aż do początku gry.
- Już nigdy przypadkowe kliknięcie nie zrujnuje Twojej gry!

### 2. Sekretny Tryb Oszustwa
- Wpisz magiczną sekwencję: ←←→→ →→←← (lewo, lewo, prawo, prawo,  prawo, prawo, lewo, lewo)
- Wszystkie płytki magicznie zamienią się w 128!
- To Wielkanocna niespodzianka, tylko dla zabawy.
- Porada: Oszukiwanie jest fajne, ale nie przesadzaj! 😉

## 🎯 Demo

🎯 Graj tutaj: [2048.765431.xyz](https://2048.765431.xyz/)
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
## 🎨 Dostosowywanie

Chcesz dostosować do własnych potrzeb? Zmień `styles.css`, aby uzyskać nowy wygląd, lub zajrzyj do `script.js`, aby zmienić rozgrywkę. Cały kod jest dobrze skomentowany, co ułatwia modyfikacje!

## 📝 Licencja

Licencja GPL-2.0

## 🤝 Współtworzenie

Projekt jest nadal rozwijany! Zgłaszanie błędów i Pull Requesty są mile widziane—razem możemy uczynić tę grę jeszcze lepszą!


## 🙏 Podziękowania

Dziękujemy następującym sponsorom za wsparcie tego projektu:
- [IDC.REST](https://idc.rest/) za udostępnienie serwera
- [Serv00](https://www.serv00.com/) za udostępnienie serwera

---
_Ostatnia aktualizacja: czerwiec 2025_



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---