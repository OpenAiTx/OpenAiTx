
<div align="right">
  <details>
    <summary >🌐 Język</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# AI Partner Chat

Projekt Claude Skills, który pozwala AI stać się Twoim spersonalizowanym partnerem do rozmów.

## Wprowadzenie do projektu

AI Partner Chat poprzez integrację profilu użytkownika, profilu AI i zwektoryzowanych osobistych notatek, oferuje spersonalizowane, kontekstowe doświadczenie rozmowy. Ta umiejętność pozwala AI zapamiętywać i przywoływać Twoje wcześniejsze pomysły, preferencje oraz bazę wiedzy, tworząc spójniejsze i bardziej indywidualne interakcje.

## Funkcje kluczowe

### 🎭 System podwójnych profili
- **Profil użytkownika**: Zdefiniuj swoje tło, specjalizacje, zainteresowania i preferencje komunikacyjne
- **Profil AI**: Dostosuj rolę AI, styl komunikacji i sposób interakcji

### 📝 Inteligentne wyszukiwanie notatek
- Automatycznie indeksuje Twoje notatki Markdown
- Inteligentnie wyszukuje powiązane zapisy historyczne na podstawie treści rozmowy
- Naturalnie cytuje Twoje wcześniejsze pomysły i notatki w trakcie rozmowy

### 💬 Spersonalizowana rozmowa
- Generuje spersonalizowane odpowiedzi w oparciu o Twój profil i notatki
- Utrzymuje spójny kontekst rozmowy
- Cytuje Twoje pomysły w naturalny sposób, jak przyjaciel, a nie mechanicznie „zgodnie z zapisem”

## Scenariusze użycia

Kiedy potrzebujesz:
- Spersonalizowanej komunikacji, a nie uniwersalnych odpowiedzi
- Odpowiedzi świadomych kontekstu, AI pamiętającego Twoje tło
- AI, które pamięta i cytuje Twoje wcześniejsze pomysły i notatki
- Ciągłego doświadczenia rozmowy, a nie każdorazowego nowego początku

## Instalacja i użycie

### Instalacja umiejętności

Skopiuj ten projekt do folderu `.claude/skills/` w swoim katalogu roboczym:

```
<你的项目根目录>/
└── .claude/
    └── skills/
        └── ai-partner-chat/    # 本技能包
            ├── assets/
            ├── scripts/
            ├── SKILL.md
            └── README.md
```

### Korzystanie z umiejętności

W Claude Code wystarczy wysłać następującą komendę, aby aktywować tę umiejętność:

```
遵循 ai-partner-chat 对话
```

Agent AI automatycznie:
- Odczytuje konfigurację umiejętności i wskazówki
- Tworzy niezbędną strukturę katalogów (`notes/`, `config/`, `vector_db/` itd.)
- Inicjuje zgodnie z Twoimi wymaganiami

### Proces inicjalizacji

#### Metoda 1: Pozwól AI automatycznie utworzyć i skonfigurować

Przy pierwszym użyciu po prostu powiedz AI:

```
我刚刚在 notes 里放入了对应的笔记，请根据笔记内容，进行向量化；并基于笔记内容，推测并更新 user-persona.md，以及最适合我的 ai-persona.md
```

Agent AI będzie:
1. Analizować zawartość notatek w katalogu `notes/`
2. Inteligentnie dzielić notatki na bloki według formatu i tworzyć bazę danych wektorowych
3. Na podstawie treści notatek wnioskować o Twoim tle i preferencjach
4. Automatycznie generować i aktualizować plik `config/user-persona.md`
5. Na podstawie Twoich cech rekomendować i tworzyć plik `config/ai-persona.md`

#### Sposób drugi: ręczna konfiguracja profilu

Jeśli chcesz samodzielnie zdefiniować profil:
1. Agent AI automatycznie utworzy pliki profilu z szablonu w katalogu `config/`
2. Możesz ręcznie edytować te pliki, aby dostosować profil
3. Następnie poinformuj AI o przetwarzaniu wektorowym

### Rozpocznij rozmowę

Po zakończeniu konfiguracji, przy każdym użyciu wystarczy wysłać:

```
遵循 ai-partner-chat 对话
```

AI będzie:
- Odczytywać Twój profil, aby poznać Twoje tło
- Wyszukiwać powiązane historyczne notatki
- Generować spersonalizowane, kontekstowo świadome odpowiedzi

## Struktura projektu

### Struktura pakietu umiejętności (znajduje się w `.claude/skills/ai-partner-chat/`)

```
ai-partner-chat/
├── assets/              # 画像模板
│   ├── user-persona-template.md
│   └── ai-persona-template.md
├── scripts/             # 核心脚本
│   ├── chunk_schema.py
│   ├── vector_indexer.py
│   ├── vector_utils.py
│   └── requirements.txt
├── SKILL.md            # 技能详细文档（AI agent 会读取此文件）
└── README.md           # 本文件
```

### Katalog danych użytkownika (znajdujący się w katalogu głównym projektu)

Agent AI utworzy w katalogu głównym twojego projektu następującą strukturę:

```
<项目根目录>/
├── notes/              # 你的笔记（由你或 AI agent 创建）
├── config/             # 画像配置（由 AI agent 创建）
│   ├── user-persona.md
│   └── ai-persona.md
├── vector_db/          # 向量数据库（由 AI agent 创建）
└── venv/               # Python 虚拟环境（由 AI agent 创建）
```

**Ważne**: Dane użytkownika są oddzielone od pakietu umiejętności, co ułatwia tworzenie kopii zapasowych i migrację.

## Przepływ pracy

1. **Ładowanie profilu**: Odczytaj profil użytkownika i AI, aby zrozumieć kontekst interakcji
2. **Wyszukiwanie notatek**: Na podstawie zapytania użytkownika wyszukaj najbardziej powiązane notatki z bazy wektorowej
3. **Budowanie kontekstu**: Zintegruj informacje z profilu, powiązane notatki oraz historię rozmów
4. **Generowanie odpowiedzi**: Wygeneruj spersonalizowaną, naturalną odpowiedź na podstawie kontekstu

## Kluczowe cechy

### 🤖 Inteligentne dzielenie przez AI Agent
System analizuje rzeczywisty format każdej notatki i dynamicznie generuje najlepszą strategię podziału, zamiast używać szablonów. Oznacza to, że niezależnie od formatu notatek, zostaną one optymalnie przetworzone.

### 🎯 Naturalne przywołania
AI w naturalny sposób przywołuje Twoje wcześniejsze informacje, nie mówiąc sztywno "zgodnie z zapisem", lecz płynnie wplatając je w rozmowę.

### 📦 Niezależność danych
Wszystkie Twoje dane (notatki, profile, baza wektorowa) są przechowywane w katalogu głównym projektu, co ułatwia ich kopiowanie, przenoszenie lub współdzielenie między różnymi umiejętnościami.

## Najlepsze praktyki

### Projektowanie profilu
- **Konkretność**: Niejasny profil prowadzi do ogólnych odpowiedzi
- **Z przykładem**: Pokaż oczekiwany styl interakcji w profilu AI
- **Regularna aktualizacja**: Optymalizuj profil w oparciu o jakość rozmów

### Zarządzanie notatkami
- **Dowolny format**: System dostosowuje się do każdej struktury notatek
- **Bogata treść**: Im głębsze notatki, tym lepsze rezultaty wyszukiwania
- **Aktualizuj na bieżąco**: Dodawaj nowe notatki do indeksu

### Doświadczenie rozmowy
- **Naturalne przywołania**: Przywołuj notatki tylko wtedy, gdy naprawdę są związane z tematem
- **Płynność**: Nie pozwól, by cytaty zakłóciły naturalny rytm rozmowy
- **Jakość przede wszystkim**: Liczy się sensowne powiązanie, a nie liczba cytatów

## Utrzymanie i aktualizacja

### Dodaj nową notatkę
Po umieszczeniu nowej notatki w katalogu `notes/`, poinformuj AI:

```
我刚刚在 notes 里添加了新笔记，请更新向量数据库
```

Agent AI automatycznie analizuje nowe notatki i aktualizuje indeks.

### Aktualizacja profilu
Możesz bezpośrednio edytować plik profilu w katalogu `config/`, lub poinformować AI:

```
请根据我最近的笔记内容，更新 user-persona.md 和 ai-persona.md
```

### Przebuduj indeks
Gdy struktura notatki ulegnie istotnej zmianie, poinformuj AI:

```
请重新初始化向量数据库
```

Agent AI przeanalizuje wszystkie notatki na nowo i odbuduje indeks.

## Uwagi

- **Pierwsze uruchomienie**: Agent AI przy pierwszym tworzeniu bazy danych wektorów automatycznie pobierze model osadzający (około 4,3 GB), proszę cierpliwie poczekać
- **Środowisko Python**: Agent AI automatycznie utworzy środowisko wirtualne i zainstaluje wymagane zależności
- **Przechowywanie danych**: Wszystkie dane (notatki, profile, baza wektorowa) przechowywane są w katalogu głównym projektu, a nie w katalogu pakietu umiejętności
- **Lokalizacja umiejętności**: Upewnij się, że pakiet umiejętności znajduje się w katalogu `.claude/skills/ai-partner-chat/`

## Więcej informacji

Szczegółową dokumentację techniczną i instrukcję użytkowania znajdziesz w pliku `SKILL.md`.

---

Pozwól, aby AI stała się naprawdę rozumiejącym cię partnerem do rozmowy, a nie tylko narzędziem.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-15

---