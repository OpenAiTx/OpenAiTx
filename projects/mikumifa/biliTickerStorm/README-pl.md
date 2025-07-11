# 🎫 BiliTickerStorm

## ⚙️ Opis usługi

| Nazwa usługi         | Opis                  | Uwagi       |
| ------------------- | --------------------- | ----------- |
| `ticket-master`     | Usługa główna, odpowiada za harmonogramowanie zadań | Wdrażanie pojedynczej instancji |
| `ticket-worker`     | Worker do zdobywania biletów, skalowalny poziomo   | Obsługuje wiele instancji       |
| `gt-python`         | Usługa obsługi graficznych kodów CAPTCHA           | Wdrażanie pojedynczej instancji |

---

## 🚀 Szybkie kroki wdrożenia

> Budowę klastra można znaleźć w [Przewodnik po budowie klastra](https://raw.githubusercontent.com/mikumifa/biliTickerStorm/main/docs/集群搭建参考.md).

<details> <summary><strong>📦 Instalacja zdalnego repozytorium (zalecane)</strong></summary>

```bash
helm repo add bili-ticker-storm https://mikumifa.github.io/biliTickerStorm/
helm repo update
```
### 2. Instalacja Chart

```bash
helm install bili-ticker-storm bili-ticker-storm/bili-ticker-storm \
  --set ticketMaster.hostDataPath=/your/host/data/path \
  --set ticketWorker.pushplusToken="your_token" \
  --set ticketWorker.ticketInterval="300" \
  --set ticketWorker.ticketTimeStart="2025-05-20T13:14"
  
```

> - `hostDataPath` to katalog plików konfiguracyjnych do zakupu biletów, montowany do kontenera `ticket-master`. Pliki konfiguracyjne do zakupu biletów generuje się za pomocą https://github.com/mikumifa/biliTickerBuy
> - `ticketWorker.pushplusToken` to konfiguracja powiadomień pushplus, po ustawieniu można otrzymywać powiadomienia o wynikach zakupu biletów.
> - `ticketWorker.ticketInterval` to interwał zakupu biletów w sekundach, domyślnie 300 milisekund.
> - `ticketWorker.ticketTimeStart` to czas uruchomienia zaplanowanego zadania, format `2025-05-20T13:14`, jeśli nie ustawiono, po uruchomieniu kontenera zakup biletów rozpocznie się natychmiast.

### 3. Aktualizacja Chart

```bash
helm upgrade bili-ticker-storm bili-ticker-storm/bili-ticker-storm --reuse-values \
  --set ticketWorker.ticketInterval="600"
```
</details> 
<details> <summary><strong>📦 Instalacja Chart lokalnie</strong></summary>


### 1. Instalacja Chart

```bash
# Sklonuj repozytorium
git clone https://github.com/mikumifa/biliTickerStorm
# Użyj lokalnego pakietu Chart
helm install bili-ticker-storm ./helm \
  --set ticketMaster.hostDataPath=/your/host/data/path \
  --set ticketWorker.pushplusToken="your_token" \
  --set ticketWorker.ticketInterval="300" \
  --set ticketWorker.ticketTimeStart="2025-05-20T13:14"
```
### 2. Aktualizacja Chart

```bash
helm upgrade bili-ticker-storm ./helm --reuse-values
```
</details>
<details>
<summary><strong>📌 Uniwersalne polecenia</strong></summary>

### ⏹ Odinstalowanie
```bash
helm uninstall bili-ticker-storm
```
</details>


## 📩 Zastrzeżenie

Ten projekt jest objęty licencją MIT License i służy wyłącznie do celów nauki i badań osobistych. Zabrania się wykorzystywania tego projektu do jakiejkolwiek działalności komercyjnej, jak również do jakiejkolwiek formy nielegalnego działania, obejścia zasad platformy lub automatycznego zdobywania nagród. Wszelkie konsekwencje wynikające z użycia ponosi wyłącznie użytkownik, autor nie ponosi za nie odpowiedzialności.

Jeśli forkujesz lub korzystasz z tego projektu, koniecznie przestrzegaj obowiązujących przepisów prawa oraz regulaminu docelowej platformy.

## 💡 O częstotliwości dostępu i kontroli współbieżności
Projekt ten został zaprojektowany zgodnie z zasadą „nieinwazyjności”, aby uniknąć zakłócania działania serwera docelowego (np. Bilibili).

Wszystkie odstępy czasowe pomiędzy żądaniami sieciowymi są konfigurowane przez użytkownika; wartości domyślne naśladują prędkość ręcznego działania typowego użytkownika. Program domyślnie działa w jednym wątku, bez zadań współbieżnych. W przypadku niepowodzenia żądania program podejmuje ograniczoną liczbę prób ponownych, wprowadzając odpowiednie opóźnienia pomiędzy nimi, aby uniknąć nadmiernej częstotliwości. Projekt korzysta wyłącznie z publicznych interfejsów i struktury stron platformy, nie zawiera metod omijających zabezpieczenia ani przechwytywania API.
## 🛡️ Oświadczenie o szacunku dla platformy

Podczas projektowania tego programu dołożono wszelkich starań, aby kontrolować częstotliwość żądań i unikać wywierania jakiegokolwiek wyraźnego obciążenia lub wpływu na serwery Bilibili. Projekt służy wyłącznie celom edukacyjnym, nie posiada możliwości działania na dużą skalę ani przy wysokiej liczbie równoczesnych połączeń, a także nie ma żadnych złośliwych zamiarów ani zamiaru zakłócania usług.

Jeśli w tym projekcie znajdują się treści naruszające legalne prawa firmy Bilibili, proszę o kontakt mailowy pod adresem [1055069518@qq.com](https://raw.githubusercontent.com/mikumifa/biliTickerStorm/main/mailto:1055069518@qq.com). Natychmiast usunę sporne treści oraz skasuję to repozytorium. Przepraszam za wszelkie niedogodności i dziękuję za zrozumienie oraz wyrozumiałość.

## 📄 Licencja

[Licencja MIT](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-11

---