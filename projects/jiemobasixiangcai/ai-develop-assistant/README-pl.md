# 🚀 MCP AI开发助手

> Narzędzie MCP wspomagające programistów AI w inteligentnej analizie wymagań i projektowaniu architektury

## ✨ Kluczowe funkcje

- **Inteligentne doprecyzowanie wymagań**: Automatyczne rozpoznawanie typu projektu, generowanie ukierunkowanych pytań
- **Zarządzanie gałęziami z uwzględnieniem kontekstu**: Śledzenie celów projektu, projektowania funkcjonalności, preferencji technologicznych, projektu UI i innych aspektów
- **Automatyczne generowanie architektury**: Tworzenie rozwiązań architektury technicznej na podstawie kompletnych wymagań
- **Trwałe przechowywanie**: Automatyczne zapisywanie wyników analizy, obsługa eksportu dokumentów

## 📁 Szybka konfiguracja

### Konfiguracja starej wersji
1. **Klonowanie kodu**
   ```bash
   git clone https://github.com/jiemobasixiangcai/ai-develop-assistant.git
   ```
2. **Zalecane środowisko wirtualne**
   ```bash
   python -m venv venv
   source venv/bin/activate  # Unix/Linux/MacOS
   venv\Scripts\activate  # Windows
   ```
3. **Instalacja zależności**
   ```bash
   pip install -r requirements.txt
   ```

4. **Lokalizacja pliku konfiguracyjnego**
   ```
   Windows: %APPDATA%\Claude\claude_desktop_config.json
   macOS: ~/Library/Application Support/Claude/claude_desktop_config.json
   ```

5. **Dodanie konfiguracji**
   ```json
   {
     "mcpServers": {
       "ai-develop-assistant": {
         "command": "python",
         "args": ["path/to/AIDevlopStudy.py"],
         "env": {
           "MCP_STORAGE_DIR": "./mcp_data"
         }
       }
     }
   }
   ```

3. **Restart Claude Desktop**

### Konfiguracja nowej wersji
#### 🔧 Kluczowe narzędzia
1. **start_new_project** - Rozpocznij nowy projekt
2. **create_requirement_blueprint** - Utwórz szablon wymagań
3. **requirement_clarifier** - Uzyskaj podpowiedzi do doprecyzowania wymagań
4. **save_clarification_tasks** - Zapisz zadania doprecyzowujące
5. **update_branch_status** - Aktualizuj status gałęzi
6. **requirement_manager** - Menedżer dokumentów wymagań
7. **check_architecture_prerequisites** - Sprawdź warunki wstępne dla architektury
8. **get_architecture_design_prompt** - Uzyskaj podpowiedzi do projektowania architektury
9. **save_generated_architecture** - Zapisz wygenerowaną architekturę
10. **export_final_document** - Eksportuj kompletny dokument
11. **view_requirements_status** - Przeglądaj status wymagań

#### Konfiguracja (skopiuj bezpośrednio do swojego narzędzia, zamień MCP_STORAGE_DIR na swój lokalny katalog)
   ```json
   {
     "mcpServers": {
       "ai-develop-assistant": {
         "command": "uvx",
         "args": ["ai-develop-assistant@latest"],
         "env": {
           "MCP_STORAGE_DIR": "/path/to/your/storage"
         }
       }
     }
   }
   ```

## 🎯 Przebieg użytkowania

### Podstawowe kroki

1. **Doprecyzowanie wymagań**
   ```
   requirement_clarifier("Chcę stworzyć platformę edukacji online")
   ```

2. **Zarządzanie wymaganiami**
   ```
   requirement_manager("Docelowi użytkownicy: uczniowie i nauczyciele", "Opis projektu")
   ```

3. **Podgląd statusu**
   ```
   view_requirements_status()
   ```
4. **Projektowanie architektury**
   ```
   architecture_designer("Architektura platformy edukacji online")
   ```

5. **Eksportuj dokument**
   ```
   export_final_document()
   ```

## 🚀 Rozpocznij korzystanie

### Szybki start
1. **Skonfiguruj Claude Desktop** (patrz metoda konfiguracji powyżej)
2. **Zrestartuj Claude Desktop**
3. **Rozpocznij inteligentną analizę wymagań**:
   ```
   requirement_clarifier("Opisz swój pomysł na projekt")
   ```
4. **Podążaj za inteligentnym prowadzeniem AI**, stopniowo uzupełniając każdą gałąź wymagań
5. **Eksportuj pełny dokument**:
   ```
   export_final_document()
   ```

### Najlepsze praktyki
- 💬 **Zaufaj zarządzaniu gałęziami AI**: Pozwól AI poprowadzić Cię przez wszystkie gałęzie wymagań
- 🎯 **Wyrażaj jasno swoje preferencje**: Wyraźnie określ preferencje dotyczące wyboru technologii, stylu UI itp.
- 📊 **Regularnie sprawdzaj status**: Używaj `view_requirements_status`, aby monitorować postęp
- 🤖 **Odpowiednio upoważniaj AI**: W przypadku niepewnych kwestii możesz powiedzieć "użyj standardowego rozwiązania"

---

**🎯 Teraz masz prawdziwie inteligentnego asystenta AI do rozwoju, który zapamięta każdy szczegół i poprowadzi Cię przez kompletną analizę wymagań!**

## 💬 Grupa dyskusyjna

<div align="center">
<img src="https://raw.githubusercontent.com/jiemobasixiangcai/ai-develop-assistant/main/./assets/qr-code.jpg" width="200" alt="Grupa dyskusyjna">
<br>
Grupa dyskusyjna
</div>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---