# Kelp

Biblioteka UI dla osób, które kochają HTML, oparta na nowoczesnym CSS i Web Components.

**[Przeczytaj dokumentację &rarr;](https://kelpui.com)**

_**Uwaga:** Kelp jest obecnie w fazie alfa. Zachęcamy do korzystania, eksperymentowania i zgłaszania błędów, ale prosimy pamiętać, że z czasem rzeczy mogą się zmieniać._



## Szybki start

Kelp działa bez żadnego etapu budowania.

[CDN](https://cdn.jsdelivr.net/npm/kelpui/) to najszybszy i najprostszy sposób, aby zacząć, ale możesz też [pobrać pliki z GitHub](https://github.com/cferdinandi/kelp), jeśli wolisz.

```html
<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/kelpui@0/css/kelp.css">
```

Kelp używa wersjonowania semantycznego. Możesz pobrać główną, poboczną lub poprawkową wersję z CDN używając składni `@1.2.3`. Wszystkie dostępne wersje znajdziesz [w sekcji releases](https://github.com/cferdinandi/kelp/tags).



## Demo

Dołączony plik `index.html` to demo typu kitchen sink dla Kelp. Zawiera każdą funkcję i komponent w jednym dużym pliku.

W fazie beta Kelp nie posiada etapu kompilacji. Komponenty webowe używają importów ES i wymagają uruchomienia na lokalnym serwerze.

Użyj swojego ulubionego serwera lub dołączonego `http-server`, uruchamiając `npm run dev`.

```bash
npm install
npm run dev
```

W miarę zbliżania się Kelp do wersji v1, zostanie dodany etap kompilacji, aby to nie było konieczne.



## Testy

Kelp używa...

- [Playwright](https://playwright.dev) do testów
- [Biome](https://biomejs.dev) do lintowania i formatowania
- Procesu ciągłej integracji przy wdrożeniach i PR

```bash
# Uruchom testy
npm run test

# Uruchom linter
npm run lint
```



## Licencja

Darmowy do użycia na [Licencji Kelp Commons](https://github.com/cferdinandi/kelp/blob/main/LICENSE.md). Dostępne są również [opcje licencji komercyjnej](/license/).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---