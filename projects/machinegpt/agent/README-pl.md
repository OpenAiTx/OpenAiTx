![2](https://github.com/user-attachments/assets/a18257a3-a678-4fd4-bf77-750dab4d99bb)

# Agent

Wysokowydajny, samowystarczalny framework Python AI agent, wykorzystujący OpenAI Python SDK do interpretacji poleceń w języku naturalnym, dynamicznego generowania i wykonywania kodu oraz zarządzania środowiskiem uruchomieniowym bez żadnych przeszkód. Oferuje automatyczną instalację zależności, bezpieczną konfigurację środowiska, strukturalne logowanie oraz minimalistyczny interfejs wtyczek do osadzania zaawansowanych narzędzi Pythona — wszystko to na liberalnej licencji Apache 2.0.

## ⭐ Historia Gwiazdek

<p align="center">
  <a href="https://star-history.com/#machinegpt/agent&Date">
    <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=machinegpt/agent&type=Date&theme=dark" onerror="this.src='https://api.star-history.com/svg?repos=machinegpt/agent&type=Date'" />
  </a>
</p>


## 🔧 Konfiguracja Środowiska

### Wirtualne Środowisko Pythona
Przed skonfigurowaniem projektu zaleca się utworzenie wirtualnego środowiska. Wykonaj następujące kroki:

Dowiedz się więcej o środowiskach wirtualnych: [Przewodnik po pakietowaniu Pythona](https://packaging.python.org/en/latest/guides/installing-using-pip-and-virtual-environments/)

Utwórz i aktywuj środowisko wirtualne:

**Windows:**

```
py -m venv .venv
.venv\Scripts\activate
```

**macOS/Linux:**
```
python3 -m venv .venv
source .venv/bin/activate
```

### Konfiguracja Projektu
Ten projekt wymaga klucza API OpenAI do działania. Aby go dostarczyć, utwórz plik .env w katalogu głównym z następującą zawartością:
```
OPENAI_API_KEY=
```
Alternatywnie możesz skopiować dostarczony plik .env.example i zaktualizować klucz:
```
cp .env.example .env
```

## 🧠 Start
Aby uruchomić agenta, wystarczy wykonać:
```
git clone https://github.com/machinegpt/agent.git
cd agent

python machine.py
```

## ✨ Wkład

Wkład, sugestie, zgłoszenia błędów i poprawki są mile widziane!

W przypadku nowych funkcji, komponentów lub rozszerzeń, otwórz zgłoszenie (issue) i przed wysłaniem PR omów zmiany.

## 💖 Projekt istnieje w obecnej formie dzięki wszystkim osobom, które wnoszą swój wkład
<a href="https://github.com/machinegpt/agent/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=machinegpt/agent" />
</a>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---