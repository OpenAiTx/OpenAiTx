# Node HL7 Client

> Czysty klient HL7 napisany w TypeScript dla Node.js umożliwiający bezproblemową komunikację z serwerami HL7.

`node-hl7-client` to lekka biblioteka bez zależności zewnętrznych, stworzona do wydajnej komunikacji z brokerami/serwerami HL7. Wspiera wysyłanie poprawnie sformatowanych wiadomości HL7, obsługę odpowiedzi oraz pracę zarówno z pojedynczymi, jak i zgrupowanymi formatami wiadomości HL7 (MSH, BHS i FHS).

## ✨ Funkcje

* ⚡ **Brak Zewnętrznych Zależności** – Ekstremalnie szybkie działanie bez zbędnych dodatków.
* 🔁 **Automatyczne Ponowne Połączenie i Próby** – Automatycznie obsługuje przerwy w połączeniu.
* 🧠 **TypeScript + Typowane Definicje** – W pełni typowane dla nowoczesnych środowisk developerskich.
* 🤝 **Pakiet Kompan** – Używaj razem z [`node-hl7-server`](https://www.npmjs.com/package/node-hl7-server) dla kompletnego rozwiązania HL7.
* 💻 **Wieloplatformowość** – Działa na Windows, macOS i Linux.
* 🧭 **Zgodność ze Standardami** – Typowane kreatory zapewniają, że segmenty MSH, BHS i FHS są zgodne ze specyfikacją HL7.org.

## 📦 Instalacja

```bash
npm install node-hl7-client
```

## 📚 Co zawiera?

* **Klient HL7** – Łączy się z zdalnym serwerem HL7, wysyła wiadomości i przetwarza odpowiedzi.
* **Parser HL7** – Przetwarza surowe ciągi wiadomości HL7 na dostępne segmenty.
* **Kreator HL7** – Tworzy poprawne wiadomości HL7, paczki lub kompletne pliki zbiorcze HL7.

## 🧾 Spis treści

1. [Definicje słów kluczowych](#keyword-definitions)
2. [Dokumentacja](#documentation)
3. [Podziękowania](#acknowledgements)
4. [Licencja](#license)

## Definicje słów kluczowych

Ten pakiet NPM został zaprojektowany do obsługi aplikacji medycznych mających potencjalny wpływ na opiekę nad pacjentem i diagnozowanie. Niniejsza dokumentacja, wraz z powiązanym pakietem [node-hl7-server](https://www.npmjs.com/package/node-hl7-server), używa następujących standardowych definicji dla jasności i interoperacyjności:

Słowa kluczowe takie jak **"MUSI"**, **"NIE MOŻE"**, **"WYMAGANE"**, **"BĘDZIE"**, **"NIE BĘDZIE"**, **"POWINNO"**, **"NIE POWINNO"**, **"ZALECANE"**, **"MOŻE"** oraz **"OPCJONALNE"** są używane konsekwentnie w całej dokumentacji. Terminy te zachowują swoje znaczenie nawet, gdy nie są zapisane wielkimi literami.

* **MUSI** – To słowo lub terminy **"WYMAGANE"** lub **"BĘDZIE"** wskazuje bezwzględny wymóg specyfikacji.
* **NIE MOŻE** – To wyrażenie lub fraza **"NIE BĘDZIE"** oznacza bezwzględny zakaz w specyfikacji.
* **POWINNO** – To słowo lub przymiotnik **"ZALECANE"**, oznacza, że w określonych okolicznościach mogą istnieć ważne powody do zignorowania danego elementu, ale pełne konsekwencje muszą być zrozumiane i dokładnie rozważone przed podjęciem decyzji.
* **NIE POWINNO** – To wyrażenie lub fraza **"NIE ZALECANE"** oznacza, że w określonych okolicznościach dane zachowanie może być akceptowalne lub nawet użyteczne. Pełne konsekwencje powinny być zrozumiane, a przypadek dokładnie rozważony przed wdrożeniem.
* **MOŻE** – To słowo lub przymiotnik **"OPCJONALNE"** oznacza, że dany element jest rzeczywiście opcjonalny. Implementacje, które nie zawierają danej opcji, MUSZĄ nadal współpracować z tymi, które ją zawierają, choć prawdopodobnie z ograniczoną funkcjonalnością. Podobnie, implementacje, które zawierają opcję, MUSZĄ współpracować z tymi, które jej nie zawierają (z wyjątkiem, oczywiście, konkretnej funkcji zapewnianej przez opcję).

## 📖 Dokumentacja

Pełna dokumentacja API, przykłady użycia oraz zaawansowane konfiguracje są dostępne na stronie projektu:
🔗 [https://bugs5382.github.io/node-hl7-client/](https://bugs5382.github.io/node-hl7-client/)

## 🙏 Podziękowania

* [`node-rabbitmq-client`](https://github.com/cody-greene/node-rabbitmq-client) – Inspiracja dla logiki połączeń.
* [`artifacthealth/hl7parser`](https://github.com/artifacthealth/hl7parser) – Wzorzec projektu parsera i kreatora.
* Moja żona i córeczka – za miłość, cierpliwość i inspirację.


## 📄 Licencja

MIT © [LICENSE](https://raw.githubusercontent.com/Bugs5382/node-hl7-client/main/LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---