# Gemini CLI

[![Gemini CLI CI](https://github.com/google-gemini/gemini-cli/actions/workflows/ci.yml/badge.svg)](https://github.com/google-gemini/gemini-cli/actions/workflows/ci.yml)

![Gemini CLI Screenshot](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/assets/gemini-screenshot.png)

To repozytorium zawiera Gemini CLI, narzędzie do pracy z AI w wierszu poleceń, które łączy się z Twoimi
narzędziami, rozumie Twój kod i przyspiesza Twoje procesy pracy.

Dzięki Gemini CLI możesz:

- Zadawać pytania i edytować duże bazy kodu w obrębie i poza 1-milionowym oknem kontekstowym tokenów Gemini.
- Generować nowe aplikacje z plików PDF lub szkiców, wykorzystując multimodalne możliwości Gemini.
- Automatyzować zadania operacyjne, takie jak zapytania dotyczące pull requestów lub obsługa złożonych rebase'ów.
- Używać narzędzi i serwerów MCP do podłączania nowych funkcji, w tym [generowania mediów za pomocą Imagen,
  Veo lub Lyria](https://github.com/GoogleCloudPlatform/vertex-ai-creative-studio/tree/main/experiments/mcp-genmedia)
- Ugruntować swoje zapytania za pomocą narzędzia [Google Search](https://ai.google.dev/gemini-api/docs/grounding),
  wbudowanego w Gemini.

## Szybki start

1. **Wymagania wstępne:** Upewnij się, że masz zainstalowaną [Node.js w wersji 18](https://nodejs.org/en/download) lub wyższej.
2. **Uruchom CLI:** Wykonaj następujące polecenie w swoim terminalu:

   ```bash
   npx https://github.com/google-gemini/gemini-cli
   ```

   Lub zainstaluj za pomocą:

   ```bash
   npm install -g @google/gemini-cli
   gemini
   ```

3. **Wybierz motyw kolorystyczny**
4. **Uwierzytelnianie:** Po wyświetleniu monitu zaloguj się przy użyciu osobistego konta Google. Zapewni Ci to do 60 żądań modelu na minutę oraz 1 000 żądań modelu dziennie przy użyciu Gemini.

Teraz jesteś gotowy do korzystania z Gemini CLI!

### Dla zaawansowanych zastosowań lub zwiększonych limitów:

Jeśli potrzebujesz użyć konkretnego modelu lub wymagasz większej liczby żądań, możesz użyć klucza API:

1. Wygeneruj klucz w [Google AI Studio](https://aistudio.google.com/apikey).
2. Ustaw go jako zmienną środowiskową w swoim terminalu. Zamień `YOUR_API_KEY` na wygenerowany klucz.

   ```bash
   export GEMINI_API_KEY="YOUR_API_KEY"
   ```

Inne metody uwierzytelniania, w tym konta Google Workspace, znajdziesz w przewodniku [authentication](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/cli/authentication.md).

## Przykłady

Gdy CLI jest uruchomione, możesz zacząć interakcję z Gemini z poziomu swojego terminala.

Możesz rozpocząć projekt w nowym katalogu:

```sh
cd new-project/
gemini
> Napisz mi bota Discord Gemini, który odpowiada na pytania na podstawie pliku FAQ.md, który dostarczę
```

Lub pracować z istniejącym projektem:

```sh
git clone https://github.com/google-gemini/gemini-cli
cd gemini-cli
gemini
> Podaj mi podsumowanie wszystkich zmian, które zostały wprowadzone wczoraj
```

### Kolejne kroki

- Dowiedz się, jak [współtworzyć lub budować ze źródła](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/CONTRIBUTING.md).
- Przejrzyj dostępne **[Polecenia CLI](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/cli/commands.md)**.
- Jeśli napotkasz jakiekolwiek problemy, przejrzyj **[Przewodnik rozwiązywania problemów](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/troubleshooting.md)**.
- Po pełną dokumentację, zobacz [pełną dokumentację](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/index.md).
- Zainspiruj się, przeglądając [popularne zadania](#popular-tasks).

### Rozwiązywanie problemów

Jeśli masz problemy, przejdź do [przewodnika rozwiązywania problemów](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/troubleshooting.md).

## Popularne zadania

### Eksploracja nowej bazy kodu

Rozpocznij od wejścia (`cd`) do istniejącego lub nowo sklonowanego repozytorium i uruchomienia `gemini`.

```text
> Opisz główne elementy architektury tego systemu.
```

```text
> Jakie mechanizmy bezpieczeństwa są wdrożone?
```

### Praca z Twoim istniejącym kodem

```text
> Zaimplementuj pierwszy szkic dla zgłoszenia GitHub nr 123.
```

```text
> Pomóż mi przenieść tę bazę kodu do najnowszej wersji Javy. Zacznij od planu.
```

### Automatyzacja procesów pracy

Użyj serwerów MCP, aby zintegrować lokalne narzędzia systemowe z firmowym pakietem do współpracy.

```text
> Przygotuj dla mnie prezentację pokazującą historię git z ostatnich 7 dni, pogrupowaną według funkcji i członka zespołu.
```

```text
> Utwórz aplikację webową na pełnym ekranie do wyświetlania najczęściej komentowanych zgłoszeń GitHub.
```

### Interakcja z Twoim systemem

```text
> Przekonwertuj wszystkie obrazy w tym katalogu na png i nadaj im nazwy według dat z danych exif.
```

```text
> Posegreguj moje faktury PDF według miesiąca wydatku.
```

## Warunki korzystania i Polityka prywatności

Szczegóły dotyczące warunków korzystania oraz polityki prywatności obowiązujących podczas korzystania z Gemini CLI znajdziesz w dokumencie [Warunki korzystania i Polityka prywatności](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/tos-privacy.md).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---