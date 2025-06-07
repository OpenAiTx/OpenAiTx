# mimotion
![刷步数](https://github.com/xunichanghuan/mimotion-run/actions/workflows/run.yml/badge.svg)
[![GitHub forks](https://img.shields.io/github/forks/xunichanghuan/mimotion-run?style=flat-square)](https://github.com/xunichanghuan/mimotion-run/network)
[![GitHub stars](https://img.shields.io/github/stars/xunichanghuan/mimotion-run?style=flat-square)](https://github.com/xunichanghuan/mimotion-run/stargazers)
[![GitHub issues](https://img.shields.io/github/issues/xunichanghuan/mimotion-run?style=flat-square)](https://github.com/xunichanghuan/mimotion-run/issues)

# Automatyczne nabijanie kroków Xiaomi Mi Fit

> Automatyczne nabijanie kroków Xiaomi Mi Fit

## Instrukcja wdrożenia przez Github Actions

### 1. Fork tego repozytorium

### 2. Ustawienie konta i hasła
# Nowość z dnia 2023-02-24
Dodaj zmienną o nazwie **CONFIG**: Ustawienia --> Secrets --> New secret, skonfiguruj wiele kont według poniższego szablonu json, obsługuje email, numer telefonu
```
{
  "TG_BOT_TOKEN": "telegram TG_BOT_TOKEN, jeśli nie posiadasz, pozostaw puste",
  "TG_USER_ID": "telegram TG_USER_ID, jeśli nie posiadasz, pozostaw puste",
  "SKEY": "CoolPush skey, jeśli nie posiadasz, pozostaw puste",
  "SCKEY": "server酱 sckey, jeśli nie posiadasz, pozostaw puste",
  "POSITION": "Czy włączyć powiadomienia przez WeChat Work, jeśli nie posiadasz, pozostaw puste",
  "CORPID": "ID firmy, zaloguj się do WeChat Work, zobacz w Moja firma-->Informacje o firmie, jeśli nie posiadasz, pozostaw puste",
  "CORPSECRET": "WeChat Work własny secret aplikacji, każda aplikacja ma własny secret, jeśli nie posiadasz, pozostaw puste",
  "AGENTID": "Wpisz ID własnej aplikacji WeChat Work, bez cudzysłowu, liczba całkowita, AgentId, jeśli nie posiadasz, pozostaw puste",
  "TOUSER": "Określ odbiorców wiadomości, lista ID członków (wielu odbiorców rozdziel znakiem ”&#166;”, max 1000). Wyjątek: wpisz ”@all”, by wysłać do wszystkich, jeśli nie posiadasz, pozostaw puste",
  "TOPARTY": "Określ departamenty odbiorców, lista ID departamentów, wielu odbiorców rozdziel znakiem ”&#166;”, max 100. Jeśli touser to ”@all”, wpisz ”@all”, jeśli nie posiadasz, pozostaw puste",
  "TOTAG": "Określ tagi odbiorców, lista ID tagów, wielu odbiorców rozdziel znakiem ”&#166;”, max 100. Jeśli touser to ”@all”, wpisz ”@all”, jeśli nie posiadasz, pozostaw puste",
  "OPEN_GET_WEATHER": "Włącz zmniejszanie kroków w zależności od pogody, jeśli nie posiadasz, pozostaw puste",
  "AREA": "Ustaw region do pobierania pogody (wymagane jeśli wyżej włączone), np. Pekin, jeśli nie posiadasz, pozostaw puste",
  "QWEATHER": "Tutaj wpisz Private KEY z QWeather, załóż na https://console.qweather.com/#/apps, jeśli nie posiadasz, pozostaw puste",
  "MIMOTION": [
    {
      "max_step": "20000",
      "min_step": "10000",
      "password": "Sitoi",
      "user": "18888xxxxxx"
    },
    {
      "max_step": "Wpisz maksymalną liczbę kroków dla wielu kont, patrz wyżej",
      "min_step": "Wpisz minimalną liczbę kroków dla wielu kont, patrz wyżej",
      "password": "Wpisz hasło dla wielu kont, patrz wyżej",
      "user": "Wpisz numer telefonu dla wielu kont, patrz wyżej"
    }
  ]
}
```
> Dodaj zmienną o nazwie **PAT**: Settings-->Secrets-->New secret

| Secrets |  Format  |
| -------- | ----- |
| PAT |   **PAT** należy uzyskać, to token github, instrukcja: https://www.jianshu.com/p/bb82b3ad1d11 , wymagane uprawnienia repo i workflow, pozycja obowiązkowa, aby uniknąć błędów uprawnień git push. |

**Przykład CONFIG**
```
{
  "TG_BOT_TOKEN": "",
  "TG_USER_ID": "",
  "SKEY": "",
  "SCKEY": "",
  "POSITION": "",
  "CORPID": "",
  "CORPSECRET": "",
  "AGENTID": "",
  "TOUSER": "",
  "TOPARTY": "",
  "TOTAG": "",
  "OPEN_GET_WEATHER": "",
  "AREA": "",
  "QWEATHER": "",
  "MIMOTION": [
    {
      "max_step": "20000",
      "min_step": "10000",
      "password": "Sitoi",
      "user": "18888xxxxxx"
    },
    {
      "max_step": "Wpisz maksymalną liczbę kroków dla wielu kont, patrz wyżej",
      "min_step": "Wpisz minimalną liczbę kroków dla wielu kont, patrz wyżej",
      "password": "Wpisz hasło dla wielu kont, patrz wyżej",
      "user": "Wpisz numer telefonu dla wielu kont, patrz wyżej"
    }
  ]
}
```

### 3. Dostosowanie czasu uruchomienia

Edytuj **random_cron.sh**
Zmień czas w instrukcji **if** na czas UTC, czyli **czas pekiński - 8**. Przykładowo, 8:00 czasu pekińskiego to 0:00 UTC, więc czas działania -8 to czas UTC.



## Uwagi

1. Uruchamia się siedem razy dziennie, kontrolowane przez random_cron.sh, minuty są losowe

2. Liczba kont i haseł musi być zgodna, inaczej nie zadziała!!!

3. Czas uruchomienia musi być w UTC!

4. Rejestracja do server酱 [kliknij tutaj](https://sct.ftqq.com/)

5. Jeśli Alipay nie aktualizuje kroków, przejdź do Mi Fit->Ustawienia->Konto->Wyloguj się->Wyczyść dane, następnie zaloguj się ponownie i powiąż z aplikacją zewnętrzną

6. Mi Fit nie aktualizuje kroków, tylko powiązane aplikacje będą synchronizowane!!!!!!

7. Przy forku używaj [głównej gałęzi](https://github.com/xunichanghuan/mimotion-run/), aby uniknąć niepotrzebnych błędów.

8. Uwaga, konto to nie jest [konto Xiaomi], tylko konto [Xiaomi Mi Fit].

## Historia liczby gwiazdek

[![Stargazers over time](https://starchart.cc/xunichanghuan/mimotion-run.svg)](https://starchart.cc/xunichanghuan/mimotion-run)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx) - 2025-06-07

---