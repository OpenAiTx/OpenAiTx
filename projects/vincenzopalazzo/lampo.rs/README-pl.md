<div align="center">
  <h1>Lampo</h1>

  <img src="https://github.com/saradurante/lampo.docs/blob/dc0dce971c3052f0e9dd668fdf0c7376b12fee7b/imgs/web/icon-512.png?raw=true"  width="150" height="150" />


  <p>
    <strong>Szybka i modułowa implementacja sieci Lightning do wszystkich zastosowań, napisana w Rust.</strong>
  </p>

  <h4>
    <a href="https://lampo.devcrew.cc">Strona projektu</a>
  </h4>
</div>

## Crates

Oto pełna lista obecnie wspieranych crate’ów:

| Crate       | Opis                                             | Wersja      |
|:------------|:------------------------------------------------:|------------:|
| lampod-cli  | Interfejs wiersza poleceń Lampo Daemon do uruchamiania demona | _unrelated_ |
| lampo-cli   | Prosty interfejs wiersza poleceń Lampo do komunikacji z demonem | _unrelated_ |

## Jak zainstalować

Aby zainstalować wszystkie wymagane zależności oraz binarkę Lampo, musisz
mieć zainstalowanego Rusta, a następnie uruchomić poniższe polecenie:

```
make install
```

Gdy masz już dostępne `lampod-cli` i `lampo-cli`, możesz
uruchomić poniższe polecenie, aby wystartować Lampo w trybie signet:

```
➜  ~ lampod-cli --network signet
✓ Portfel wygenerowany, proszę zapisz te słowa w bezpiecznym miejscu
 wallet-keys  maple have fitness decide food joy flame coast stereo front grab stumble
```

>[!NOTE]
Zapisz słowa portfela i użyj ich później do przywrócenia portfela z opcją `--restore-wallet`.
Jeśli nie zapiszesz słów, przy następnym uruchomieniu Lampo Twoje środki zostaną utracone!

Pamiętaj, że musisz mieć plik `lampo.conf` w ścieżce `~/.lampo/signet`. Uruchom
następujące polecenie, aby użyć przykładowego pliku konfiguracyjnego:

```
cp lampo.example.conf ~/.lampo/signet/lampo.conf
```

Następnie możesz zapytać node za pomocą poniższego polecenia:

``` 
➜  ~ lampo-cli --network signet getinfo
{
  "node_id": "035b889551a44e502cd0cd6657acf067336034986cd6639b222cd4be563a7fc205",
  "peers": 0,
  "channels": 0
}
```

### Aby uruchomić testy integracyjne z core lightning:

Upewnij się, że masz skompilowane core-lightning w trybie developerskim. Przewodnik instalacji znajdziesz [tutaj](https://docs.corelightning.org/docs/installation).

Testy integracyjne można uruchomić poleceniem:

```
make integration
```

## Wytyczne dotyczące współpracy

Prosimy o zapoznanie się z naszym [Przewodnikiem współpracy](https://raw.githubusercontent.com/vincenzopalazzo/lampo.rs/main/CONTRIBUTING.md).

## Społeczność

Dbając o przejrzystość, wybraliśmy konkretne kanały komunikacji:
- Deweloperzy, dołączcie do nas na [Zulip](https://lampo-dev.zulipchat.com/).
- Członkowie społeczności, nasza [społeczność na Twitterze](https://twitter.com/i/communities/1736414802849706087) czeka na Wasze spostrzeżenia.
- W przypadku pytań technicznych i propozycji funkcjonalności zapraszamy do dyskusji na GitHubie.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---