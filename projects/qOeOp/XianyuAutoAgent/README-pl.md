<div align="right">
  <details>
    <summary >🌐 Język</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# 🚀 Xianyu AutoAgent - Inteligentny system bota obsługi klienta Xianyu

[![Java Version](https://img.shields.io/badge/java21%2B-blue)](https://www.python.org/) [![LLM Powered](https://img.shields.io/badge/LLM-powered-FF6F61)](https://platform.openai.com/)

AI-owe rozwiązanie dyżuru stworzone specjalnie dla platformy Xianyu, umożliwiające 7×24 godziny automatycznego nadzoru, wspierające współpracę wielu ekspertów, inteligentne negocjacje cen i kontekstową rozmowę.

## 🎮 Playground - Szybkie demo (wersja bez konfiguracji)

Nie potrzebujesz lokalnego środowiska ani ustawiania sekretów! **Po prostu wprowadź parametry przez interfejs webowy GitHub Actions** i uruchom bota Xianyu jednym kliknięciem.

### Jak używać
1. **Forkuj to repozytorium** → Kliknij przycisk `Fork` w prawym górnym rogu
2. **Uruchom Action**:
   - Przejdź do zakładki `Actions` w swoim repozytorium
   - Wybierz workflow **`🚀 Run Service`**
   - Kliknij przycisk **`Run workflow`** i uzupełnij parametry:
      - `API Key`: Wklej swój klucz API dużego modelu (np. Aliyun DashScope)
      - `Cookies`: Wklej pełny ciąg Cookie z webowej wersji Xianyu
3. **Zobacz logi działania**:
   - Bot po uruchomieniu automatycznie nasłuchuje wiadomości Xianyu
   - W logach Action wyszukaj `🤖 Reply:` aby zobaczyć historię rozmów

### Uwagi
⚠️ Ograniczenia działania tymczasowego:
- Domyślne działanie **30 minut** (ograniczenie darmowego konta GitHub)
- Wrażliwe dane (np. Cookie) **nie są zapisywane**, obowiązują tylko w bieżącej sesji

<div align="center">
  <img src="https://raw.githubusercontent.com/qOeOp/XianyuAutoAgent/main/./screenshots/workflow.png" width="400px" alt="workflow">
</div>

## 🌟 Kluczowe funkcje

### Inteligentny silnik rozmów
| Moduł        | Technologia          | Kluczowe cechy                                                        |
| ------------ | ------------------- | --------------------------------------------------------------------- |
| Świadomość kontekstu | Przechowywanie historii rozmów | Lekki menedżer pamięci rozmów, pełna historia jako kontekst wejściowy LLM |
| Routing ekspertów | LLM prompt+routing regułowy     | Rozpoznawanie intencji na bazie promptów → dynamiczna dystrybucja do agentów-ekspertów, obsługa negocjacji/technicznych/klientów |

### Matryca funkcji biznesowych
| Moduł     | Zaimplementowane                 | W planach                    |
| --------- | -------------------------------- | ---------------------------- |
| Silnik    | ✅ Automatyczne odpowiedzi LLM<br>✅ Zarządzanie kontekstem | 🔄 Wzmocniona analiza emocji        |
| System negocjacji | ✅ Strategia stopniowego obniżania ceny | 🔄 Funkcja porównywania cen z rynkiem |
| Wsparcie techniczne | ✅ Integracja wyszukiwania internetowego | 🔄 Wzmocnienie bazy wiedzy RAG       |

## 🚴 Szybki start

### Wymagania środowiskowe
- JDK 21+
- Maven 3.9.10+

### Kroki instalacji

```bash
1. 克隆仓库
git clone https://github.com/qOeOp/XianyuAutoAgent.git
cd XianyuAutoAgent

2. 配置环境变量
- AI_DASHSCOPE_API_KEY : 阿里云大模型API-KEY
- COOKIES_STR : 闲鱼网页端Cookie

3. 执行命令
mvn spring-boot:run
注意：默认使用的模型是通义千问，如需使用其他API，请自行修改application.yml文件中的模型地址和模型名称；
COOKIES_STR自行在闲鱼网页端获取cookies(网页端F12打开控制台，选择Network，点击Fetch/XHR,点击一个请求，查看cookies)

4. (可选)创建提示词文件src/main/resources/*-prompt.txt
```
## 🤝 Udział w rozwoju

Zachęcamy do zgłaszania sugestii poprzez Issue lub wnoszenia kodu przez PR, prosimy o przestrzeganie [wytycznych dotyczących wkładu](https://contributing.md/).



## 🛡 Uwagi

⚠️ Uwaga: **Ten projekt służy wyłącznie do nauki i wymiany doświadczeń. W przypadku naruszenia praw autorskich prosimy o kontakt w celu usunięcia.**

Ze względu na szczególny charakter projektu, zespół deweloperski może w dowolnym momencie **zaprzestać aktualizacji** lub **usunąć projekt**.


## 🧸 Specjalne podziękowania

Projekt został zrekonstruowany na bazie poniższych projektów open source:
- [XianyuAutoAgent](https://github.com/shaxiu/XianyuAutoAgent) - Inteligentny system obsługi klienta Xianyu, opracowany przez [@shaxiu](https://github.com/shaxiu) i [@cv-cat](https://github.com/cv-cat)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---