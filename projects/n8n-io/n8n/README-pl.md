![Obraz banerowy](https://user-images.githubusercontent.com/10284570/173569848-c624317f-42b1-45a6-ab09-f0ea3c247648.png)

# n8n – Bezpieczna automatyzacja procesów dla zespołów technicznych

n8n to platforma do automatyzacji procesów, która zapewnia zespołom technicznym elastyczność kodu przy szybkości rozwiązań no-code. Dzięki ponad 400 integracjom, natywnym możliwościom AI oraz licencji fair-code, n8n pozwala tworzyć zaawansowane automatyzacje z pełną kontrolą nad danymi i wdrożeniami.

![n8n.io - Zrzut ekranu](https://raw.githubusercontent.com/n8n-io/n8n/master/assets/n8n-screenshot-readme.png)

## Kluczowe możliwości

- **Koduj, kiedy potrzebujesz**: Pisz w JavaScript/Python, dodawaj paczki npm lub korzystaj z interfejsu wizualnego
- **Platforma natywna AI**: Twórz przepływy agentów AI oparte na LangChain z własnymi danymi i modelami
- **Pełna kontrola**: Samodzielnie hostuj dzięki licencji fair-code lub skorzystaj z naszej [oferty chmurowej](https://app.n8n.cloud/login)
- **Gotowy na przedsiębiorstwa**: Zaawansowane uprawnienia, SSO i wdrożenia typu air-gap
- **Aktywna społeczność**: Ponad 400 integracji i ponad 900 gotowych do użycia [szablonów](https://n8n.io/workflows)

## Szybki start

Wypróbuj n8n natychmiast za pomocą [npx](https://docs.n8n.io/hosting/installation/npm/) (wymaga [Node.js](https://nodejs.org/en/)):

```
npx n8n
```

Lub wdrażaj za pomocą [Dockera](https://docs.n8n.io/hosting/installation/docker/):

```
docker volume create n8n_data
docker run -it --rm --name n8n -p 5678:5678 -v n8n_data:/home/node/.n8n docker.n8n.io/n8nio/n8n
```

Dostęp do edytora pod adresem http://localhost:5678

## Zasoby

- 📚 [Dokumentacja](https://docs.n8n.io)
- 🔧 [Ponad 400 integracji](https://n8n.io/integrations)
- 💡 [Przykładowe przepływy](https://n8n.io/workflows)
- 🤖 [Przewodnik po AI & LangChain](https://docs.n8n.io/langchain/)
- 👥 [Forum społeczności](https://community.n8n.io)
- 📖 [Poradniki społeczności](https://community.n8n.io/c/tutorials/28)

## Wsparcie

Potrzebujesz pomocy? Nasze forum społeczności to miejsce, gdzie uzyskasz wsparcie i nawiążesz kontakt z innymi użytkownikami:
[community.n8n.io](https://community.n8n.io)

## Licencja

n8n jest [fair-code](https://faircode.io) i dystrybuowany na podstawie [Sustainable Use License](https://github.com/n8n-io/n8n/blob/master/LICENSE.md) oraz [n8n Enterprise License](https://github.com/n8n-io/n8n/blob/master/LICENSE_EE.md).

- **Otwarte źródło**: Kod źródłowy zawsze dostępny
- **Możliwość samodzielnego hostowania**: Wdróż gdziekolwiek chcesz
- **Rozszerzalność**: Dodawaj własne węzły i funkcjonalności

Licencje Enterprise ([kontakt mailowy](mailto:license@n8n.io)) dostępne dla dodatkowych funkcji i wsparcia.

Dodatkowe informacje o modelu licencyjnym znajdziesz w [dokumentacji](https://docs.n8n.io/reference/license/).

## Współtworzenie

Znalazłeś błąd 🐛 lub masz pomysł na nową funkcję ✨? Zapoznaj się z naszym [Przewodnikiem dla współtwórców](https://github.com/n8n-io/n8n/blob/master/CONTRIBUTING.md), aby rozpocząć.

## Dołącz do zespołu

Chcesz współtworzyć przyszłość automatyzacji? Sprawdź nasze [oferty pracy](https://n8n.io/careers) i dołącz do zespołu!

## Co oznacza n8n?

**Krótka odpowiedź:** Oznacza „nodemation” i wymawia się jako n-eight-n.

**Długa odpowiedź:** „To pytanie dostaję dość często (częściej, niż się spodziewałem), więc postanowiłem odpowiedzieć tutaj. Szukając dobrej nazwy dla projektu z wolną domeną, bardzo szybko zorientowałem się, że wszystkie dobre, na które wpadłem, były już zajęte. Ostatecznie wybrałem nodemation. 'node-' w sensie wykorzystania Node-View i Node.js oraz '-mation' od 'automation', czyli automatyzacji, do której ma służyć projekt. Jednak nie podobała mi się długość tej nazwy i nie wyobrażałem sobie wpisywania jej za każdym razem w CLI. Tak właśnie powstało 'n8n'.” – **Jan Oberhauser, Założyciel i CEO, n8n.io**

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---