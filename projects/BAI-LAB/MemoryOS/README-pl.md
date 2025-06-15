# MemoryOS
<div align="center">
  <img src="https://raw.githubusercontent.com/BAI-LAB/MemoryOS/main/logo_1.png" alt="logo" width="400"/>
</div>
<p align="center">
  <a href="https://arxiv.org/abs/2506.06326">
    <img src="https://img.shields.io/badge/Arxiv-paper-red" alt="Mem0 Discord">
  </a>
  <a href="https://github.com/user-attachments/assets/d195e740-1249-4eb1-962a-2c0d99a38c39">
    <img src="https://img.shields.io/badge/Wechat-群二维码-green" alt="Mem0 PyPI - Downloads">
  </a>
  <a href="https://youtu.be/y9Igs0FnX_M" target="blank">
    <img src="https://img.shields.io/badge/Demo-Video-red" alt="Npm package">
  </a>
    <a href="https://www.apache.org/licenses/LICENSE-2.0" target="_blank">
    <img src="https://img.shields.io/badge/License-Apache_2.0-blue" alt="License: Apache 2.0">
  </a>
</p>

<h5 align="center"> 🎉 Jeśli podoba Ci się nasz projekt, prosimy o zostawienie gwiazdki ⭐ na GitHub, aby być na bieżąco z najnowszymi aktualizacjami.</h5>
**MemoryOS** został zaprojektowany jako system operacyjny pamięci dla spersonalizowanych agentów AI, umożliwiając bardziej spójne, spersonalizowane i kontekstowe interakcje. Czerpiąc inspirację z zasad zarządzania pamięcią w systemach operacyjnych, wykorzystuje hierarchiczną architekturę przechowywania z czterema głównymi modułami: Storage, Updating, Retrieval i Generation, aby zapewnić kompleksowe i wydajne zarządzanie pamięcią. W benchmarku LoCoMo model osiągnął średnią poprawę **49,11%** i **46,18%** w wynikach F1 i BLEU-1.







## 📣 Najnowsze wiadomości
*   *<mark>[nowość]</mark>* 🔥  **[2025-06-15]**:🛠️ Wydano open-source **MemoryOS-MCP**! Teraz możliwa konfiguracja po stronie klientów agenta dla płynnej integracji i personalizacji. [👉 Zobacz](#memoryos_mcp-getting-started)
*   **[2025-05-30]**: Wydano początkową wersję **MemoryOS**! Obsługuje pamięć krótkoterminową, średnioterminową i długoterminową persony z automatyczną aktualizacją profilu użytkownika i wiedzy.

## Demo
[![Obejrzyj wideo](https://img.youtube.com/vi/y9Igs0FnX_M/maxresdefault.jpg)](https://youtu.be/y9Igs0FnX_M)

## 	Architektura systemu
![image](https://github.com/user-attachments/assets/09200494-03a9-4b7d-9ffa-ef646d9d51f0)

## Struktura projektu

```
memoryos/
├── __init__.py            # Inicjalizuje pakiet MemoryOS
├── __pycache__/           # Katalog cache Pythona (generowany automatycznie)
├── long_term.py           # Zarządza długoterminową pamięcią persony (profil użytkownika, wiedza)
├── memoryos.py            # Główna klasa MemoryOS, orkiestruje wszystkie komponenty
├── mid_term.py            # Zarządza pamięcią średnioterminową, konsolidując interakcje krótkoterminowe
├── prompts.py             # Zawiera prompt'y używane do interakcji z LLM (np. podsumowanie, analiza)
├── retriever.py           # Wyszukuje istotne informacje ze wszystkich warstw pamięci
├── short_term.py          # Zarządza pamięcią krótkoterminową dla ostatnich interakcji
├── updater.py             # Przetwarza aktualizacje pamięci, w tym promowanie informacji między warstwami
└── utils.py               # Funkcje pomocnicze używane w całej bibliotece
```

## Jak to działa

1.  **Inicjalizacja:** `Memoryos` jest inicjalizowany z identyfikatorami użytkownika i asystenta, kluczami API, ścieżkami przechowywania danych oraz różnymi ustawieniami pojemności/progów. Tworzy dedykowaną przestrzeń pamięci dla każdego użytkownika i asystenta.
2.  **Dodawanie wspomnień:** Wprowadzane przez użytkownika dane oraz odpowiedzi agenta są dodawane jako pary QA. Początkowo są one przechowywane w pamięci krótkoterminowej.
3.  **Przetwarzanie z pamięci krótkoterminowej do średnioterminowej:** Gdy pamięć krótkoterminowa jest pełna, moduł `Updater` przetwarza te interakcje, konsolidując je w sensowne segmenty i zapisując w pamięci średnioterminowej.
4.  **Analiza pamięci średnioterminowej i aktualizacje LPM:** Segmenty pamięci średnioterminowej akumulują "ciepło" na podstawie takich czynników jak częstotliwość odwiedzin i długość interakcji. Gdy "ciepło" segmentu przekroczy próg, jego zawartość jest analizowana:
    *   Wnioski dotyczące profilu użytkownika są wyodrębniane i używane do aktualizacji długoterminowego profilu użytkownika.
    *   Określone fakty o użytkowniku dodawane są do jego długoterminowej wiedzy.
    *   Istotne informacje dla asystenta dodawane są do bazy wiedzy długoterminowej asystenta.
5.  **Generowanie odpowiedzi:** Gdy otrzymane zostanie zapytanie użytkownika:
    *   Moduł `Retriever` pobiera odpowiedni kontekst z historii krótkoterminowej, segmentów pamięci średnioterminowej, profilu i wiedzy użytkownika oraz bazy wiedzy asystenta.
    *   Ten kompleksowy kontekst jest następnie używany wraz z zapytaniem użytkownika do wygenerowania spójnej i trafnej odpowiedzi przez LLM.

## MemoryOS_PYPI - Pierwsze kroki

### Wymagania wstępne

*   Python >= 3.10
*   pip install -i https://pypi.org/simple/ MemoryOS-BaiJia

### Instalacja

```bash
conda create -n MemoryOS python=3.10
conda activate MemoryOS
pip install -i https://pypi.org/simple/ MemoryOS-BaiJia
```

### Podstawowe użycie

```python

import os
from memoryos import Memoryos

# --- Podstawowa konfiguracja ---
USER_ID = "demo_user"
ASSISTANT_ID = "demo_assistant"
API_KEY = "TWÓJ_OPENAI_API_KEY"  # Zamień na swój klucz
BASE_URL = ""  # Opcjonalnie: jeśli używasz własnego endpointu OpenAI
DATA_STORAGE_PATH = "./simple_demo_data"
LLM_MODEL = "gpt-4o-mini"

def simple_demo():
    print("MemoryOS - Prosta demonstracja")
    
    # 1. Inicjalizacja MemoryOS
    print("Inicjalizacja MemoryOS...")
    try:
        memo = Memoryos(
            user_id=USER_ID,
            openai_api_key=API_KEY,
            openai_base_url=BASE_URL,
            data_storage_path=DATA_STORAGE_PATH,
            llm_model=LLM_MODEL,
            assistant_id=ASSISTANT_ID,
            short_term_capacity=7,  
            mid_term_heat_threshold=5,  
            retrieval_queue_capacity=7,
            long_term_knowledge_capacity=100
        )
        print("MemoryOS zainicjowany pomyślnie!\n")
    except Exception as e:
        print(f"Błąd: {e}")
        return

    # 2. Dodanie kilku podstawowych wspomnień
    print("Dodawanie wspomnień...")
    
    memo.add_memory(
        user_input="Cześć! Jestem Tom, pracuję jako data scientist w San Francisco.",
        agent_response="Cześć Tom! Miło cię poznać. Data science to naprawdę ekscytująca dziedzina. Z jakimi danymi pracujesz?"
    )
     
    test_query = "Co pamiętasz o mojej pracy?"
    print(f"Użytkownik: {test_query}")
    
    response = memo.get_response(
        query=test_query,
    )
    
    print(f"Asystent: {response}")

if __name__ == "__main__":
    simple_demo()
```
## MemoryOS-MCP - Pierwsze kroki
### 🔧 Narzędzia główne

#### 1. `add_memory`
Zapisuje treść rozmowy pomiędzy użytkownikiem a asystentem AI w systemie pamięci w celu budowania trwałej historii dialogu i kontekstowego zapisu.

#### 2. `retrieve_memory`
Pobiera powiązane historyczne dialogi, preferencje użytkownika i informacje o wiedzy z systemu pamięci na podstawie zapytania, pomagając asystentowi AI zrozumieć potrzeby i tło użytkownika.

#### 3. `get_user_profile`
Uzyskuje profil użytkownika wygenerowany na podstawie analizy historycznych dialogów, w tym cech osobowości, preferencji i istotnego tła wiedzy.


### 1. Instalacja zależności
```bash
cd memoryos-mcp
pip install -r requirements.txt
```
### 2. Konfiguracja

Edytuj `config.json`：
```json
{
  "user_id": "Twój identyfikator użytkownika",
  "openai_api_key": "Twój klucz API OpenAI",
  "openai_base_url": "https://api.openai.com/v1",
  "data_storage_path": "./memoryos_data",
  "assistant_id": "assistant_id",
  "llm_model": "gpt-4o-mini"
}
```
### 3. Uruchomienie serwera
```bash
python server_new.py --config config.json
```
### 4. Testowanie
```bash
python test_comprehensive.py
```
### 5. Konfiguracja na Cline i innych klientach
Skopiuj plik mcp.json i upewnij się, że ścieżka do pliku jest poprawna.
```bash
command": "/root/miniconda3/envs/memos/bin/python"
# To powinno być zmienione na interpreter Pythona twojego środowiska wirtualnego
```
## Współtworzenie

Wszelkie kontrybucje są mile widziane! Zachęcamy do zgłaszania problemów lub pull requestów.

## Cytowanie
Jeśli chcesz przeczytać więcej szczegółów, kliknij tutaj: [Przeczytaj cały artykuł](https://arxiv.org/abs/2506.06326)

Jeśli uważasz ten projekt za przydatny, rozważ cytowanie naszej publikacji:

```bibtex
@misc{kang2025memoryosaiagent,
      title={Memory OS of AI Agent}, 
      author={Jiazheng Kang and Mingming Ji and Zhe Zhao and Ting Bai},
      year={2025},
      eprint={2506.06326},
```
## Kontakt

百家AI to grupa badawcza prowadzona przez profesor nadzwyczajną Bai Ting z Uniwersytetu Poczt i Telekomunikacji w Pekinie, która dąży do stworzenia pełnego emocji i niezwykłej pamięci mózgu dla krzemowych ludzi.<br>
Współpraca i sugestie: baiting@bupt.edu.cn<br>
Zapraszamy do śledzenia oficjalnego konta 百家Agent na WeChat oraz dołączenia do naszej grupy WeChat w celu wspólnej wymiany doświadczeń!  
<div style="display: flex; justify-content: center; gap: 20px;">
  <img src="https://github.com/user-attachments/assets/42651f49-f1f7-444d-9455-718e13ed75e9" alt="Oficjalne konto 百家Agent" width="250"/>
  <img src="https://github.com/user-attachments/assets/6b15a873-9e9a-44ee-b0b3-64f488fbd5d8" alt="Kod QR do grupy WeChat" width="300"/>
</div>
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-15

---