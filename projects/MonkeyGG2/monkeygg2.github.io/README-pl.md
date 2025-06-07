<p align="center"><img src="https://raw.githubusercontent.com/MonkeyGG2/monkeygg2.github.io/main/imgs/icon-256-256.png" height="200"></p>

<div align="center">
<a href="https://discord.com/invite/yPYyZ78qCB"><img alt="Discord" src="https://img.shields.io/discord/1051660971900407839?label=discord"></a>
<a href="https://github.com/MonkeyGG2/monkeygg2.github.io"><img alt="Github Repo stars" src="https://img.shields.io/github/stars/MonkeyGG2/monkeygg2.github.io?label=github%20stars"></a>
<a href="https://github.com/MonkeyGG2/monkeygg2.github.io"><img alt="GitHub Repo forks" src="https://img.shields.io/github/forks/MonkeyGG2/monkeygg2.github.io?label=github%20forks"></a>
<a href="https://codeberg.org/MonkeyGG2/pages"><img alt="Codeberg Repo stars" src="https://img.shields.io/badge/dynamic/json.svg?label=codeberg%20stars&url=https://codeberg.org/api/v1/repos/MonkeyGG2/pages&query=stars_count"></a>
<a href="https://codeberg.org/MonkeyGG2/pages"><img alt="Codeberg Repo forks" src="https://img.shields.io/badge/dynamic/json.svg?label=codeberg%20forks&url=https://codeberg.org/api/v1/repos/MonkeyGG2/pages&query=forks_count"></a>
<a href="http://www.wtfpl.net/about"><img alt="License: WTFPL" src="https://img.shields.io/badge/License-WTFPL-brightgreen.svg"></a>
</div>
<h1 align="center">MonkeyGG2</h1>
<p align="center" style="opacity: 0.65;">Twój Przyjazny Portal z Grami w Okolicy.</p>
<br>

Witamy w MonkeyGG2, rozbudowanym portalu z grami stworzonym specjalnie dla Ciebie! Z ponad 150 grami do wyboru, MonkeyGG2 oferuje unikalne i konfigurowalne doświadczenie rozgrywki. Niezależnie od tego, czy jesteś graczem, deweloperem, czy zwykłym użytkownikiem, MonkeyGG2 zapewnia płynne i przyjemne środowisko do grania.

> Rozważ zostawienie nam gwiazdki! Zwłaszcza jeśli sforkowałeś to repozytorium lub znalazłeś dla niego inne zastosowanie.

## Funkcje

-   Ponad 150 gier
-   Łatwy w użyciu
-   Łatwy do wdrożenia
-   Konfigurowalny
-   Proxy
-   I więcej...

## Dostosowywanie

### Ustawienia

#### Maskowanie

Maskowanie polega na otwarciu strony w karcie `about:blank`. To zachowanie jest domyślnie wymuszane, chociaż można je wyłączyć. Dostępne są gotowe ustawienia dla linku przekierowującego, ale można je również skonfigurować ręcznie.

#### Ukrywanie

Ukrywanie polega na zmianie ikony i tytułu karty about:blank. Dostępne są gotowe ustawienia dla ikony i tytułu karty, jednak można je także skonfigurować ręcznie.

#### Skróty

Można tworzyć własne skróty klawiszowe do wykonywania różnych zadań. Na przykład: wyjście z gry, ukrycie karty, wykonanie własnego kodu JavaScript – wszystko jest obsługiwane.
> Uwaga: jeśli chcesz wykonać własny kod JavaScript, upewnij się, że wiesz, co robisz. Jeśli coś zepsujesz, odświeżenie strony zawsze rozwiązuje problem.

#### Motyw

Obecnie obsługiwane są następujące opcje dostosowywania motywu:
- Włącz/wyłącz animację tła (jeśli martwisz się o wydajność w trakcie gry, nie martw się – jest automatycznie wyłączana podczas rozgrywki)
- Kolor tła
- Kolor bloków
- Kolor przycisków
- Kolor gier
- Kolor podświetlenia
- Kolor paska przewijania
- Kolor ścieżki przewijania
- Kolor czcionki

> Uwaga: jeśli przypadkowo zmienisz kolory tak, że strona stanie się nieużywalna, będziesz musiał(a) wyczyścić ciasteczka i lokalną pamięć.

### Zaawansowane dostosowywanie

> Zastrzeżenie: poniższe opcje dostępne są wyłącznie dla właścicieli repozytorium lub jego forków.

Plik `config.jsonc` zawiera konfigurację dla całej strony. Obecnie obsługiwane są następujące elementy:
- Gry
- Motywy (wkrótce)
- Konfiguracja proxy

#### Gry

Każdy wpis gry posiada klucz będący nazwą wyświetlaną gry, a wartość powinna być obiektem z trzema parami klucz-wartość:
- `"path"`: Ścieżka do gry z katalogu `./games`
- `"aliases"`: Lista alternatywnych nazw gry, używanych do ułatwienia wyszukiwania
- `"categories"`: Lista kategorii, do których gra pasuje (wkrótce obsługa ikon)

Dodanie wpisu ręcznie jest możliwe, lecz żmudne, szczególnie jeśli chcesz posortować listę alfanumerycznie (nie jest to wymagane, aby konfiguracja działała!)
Dlatego powstał skrypt `add-game-entry.js`, który pozwala łatwo dodać nową grę do konfiguracji bez ręcznej edycji pliku.

```bash
# Możesz użyć dowolnego środowiska uruchomieniowego js, np. node.js, bun lub deno
# W tym przykładzie użyty zostanie bun, ponieważ automatycznie instaluje zależności
bun add-game-script.js
# Odpowiedz na pojawiające się pytania, a konfiguracja zostanie zaktualizowana
```

#### Motywy

Standard motywów nie został jeszcze zaimplementowany (TODO)

#### Proxy

Opcje konfiguracji proxy znajdują się pod kluczem **"config"**. 
Wartość dla klucza `"proxy"` to wartość boolean, która włącza lub wyłącza funkcję proxy. Jeśli `"proxy"` jest ustawione na false, użytkownik zobaczy okno dialogowe z błędem podczas próby użycia proxy.
Wartość dla klucza `"proxyPath"` to ścieżka do proxy. Może być ścieżką bezwzględną lub względną, ale proxy musi obsługiwać **CORS**, ponieważ strona proxy będzie wyświetlana jako iframe na stronie.

## Wdrożenie

### Bez proxy

[![Run on Replit](https://binbashbanana.github.io/deploy-buttons/buttons/remade/replit.svg)](https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Remix on Glitch](https://binbashbanana.github.io/deploy-buttons/buttons/remade/glitch.svg)](https://glitch.com/edit/#!/import/github/MonkeyGG2/monkeygg2.github.io)
[![Deploy to IBM Cloud](https://binbashbanana.github.io/deploy-buttons/buttons/remade/ibmcloud.svg)](https://cloud.ibm.com/devops/setup/deploy?repository=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Deploy to Amplify Console](https://binbashbanana.github.io/deploy-buttons/buttons/remade/amplifyconsole.svg)](https://console.aws.amazon.com/amplify/home#/deploy?repo=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Run on Google Cloud](https://binbashbanana.github.io/deploy-buttons/buttons/remade/googlecloud.svg)](https://deploy.cloud.run/?git_repo=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Deploy to Oracle Cloud](https://binbashbanana.github.io/deploy-buttons/buttons/remade/oraclecloud.svg)](https://cloud.oracle.com/resourcemanager/stacks/create?zipUrl=https://github.com/MonkeyGG2/monkeygg2.github.io/archive/refs/heads/main.zip)
[![Deploy with Vercel](https://binbashbanana.github.io/deploy-buttons/buttons/remade/vercel.svg)](https://vercel.com/new/clone?repository-url=https%3A%2F%2Fgithub.com%2FMonkeyGG2%2Fmonkeygg2.github.io)
[![Deploy with Netlify](https://binbashbanana.github.io/deploy-buttons/buttons/remade/netlify.svg)](https://app.netlify.com/start/deploy?repository=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Deploy to Render](https://binbashbanana.github.io/deploy-buttons/buttons/remade/render.svg)](https://render.com/deploy?repo=https://github.com/MonkeyGG2/monkeygg2.github.io)

Alternatywnie, możesz po prostu sforkować to repozytorium na [GitHubie](https://github.com/MonkeyGG2/monkeygg2.github.io) lub [Codebergu](https://codeberg.org/MonkeyGG2/pages) i wdrożyć odpowiednio na GitHub Pages lub Codeberg Pages.

### Z proxy

Odwiedź stronę [VioletGG2](https://github.com/MonkeyGG2/VioletGG2), aby dowiedzieć się więcej o hostowaniu MonkeyGG2 z użyciem proxy.

### Uruchomienie lokalne

```bash
# OSTRZEŻENIE: jeśli masz folder o nazwie "monkeygg2", to polecenie usunie wszystkie pliki z tego folderu
# zmień nazwę katalogu w poniższych dwóch poleceniach, jeśli to konieczne
git clone https://github.com/MonkeyGG2/monkeygg2.github.io.git monkeygg2
cd monkeygg2
# od tego momentu możesz użyć dowolnego narzędzia do uruchamiania serwera statycznego, tutaj użyjemy "live-server" z npm
npm install -g live-server # tylko jeśli nie masz już zainstalowanego
npx live-server
```

## Licencja

Rozprowadzane na licencji WTFPL. Zobacz [tutaj](https://github.com/MonkeyGG2/monkeygg2.github.io/blob/main/LICENSE), aby uzyskać więcej informacji.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---