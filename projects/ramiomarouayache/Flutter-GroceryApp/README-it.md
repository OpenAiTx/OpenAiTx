# GroceryApp Starter

Template semplificato per app di spesa, per un’esperienza di acquisto senza complicazioni. 🛒✨

Sentiti libero di aggiungere una stella ⭐ al repository se lo trovi utile.

## Design

**Clicca sull’immagine qui sotto per visualizzare il design Figma:**

[![Anteprima Design](https://github.com/ramiomarouayache/Flutter-GroceryApp/blob/main/screenshots/Cover.jpg)](https://www.figma.com/embed?embed_host=oembed&amp;url=https://www.figma.com/file/eyeYwe0hoEch31j6d3EXyE/GroceryApp-Starter-(Community)?type=design&amp;node-id=3-2&amp;mode=design&amp;t=LwLW2onM0GKLuFdU-0)



## ✨Requisiti

1. **Ambiente di sviluppo:**
   - Qualsiasi IDE con Flutter SDK installato (es. VSCode, Android Studio, IntelliJ...ecc.)

2. **Conoscenze richieste:**
   - Conoscenza base/intermedia di Dart e Flutter
   - Comprensione dell’architettura MVVM
   - Familiarità con la gestione delle API
   - Nozioni di base sulla gestione dello stato con GetX

## Test
* Puoi scaricare la versione pre-rilasciata per dispositivi Android da qui [releases](https://github.com/ramiomarouayache/Flutter-GroceryApp/releases/tag/v0.3.1).
<video src="https://github.com/ramiomarouayache/Flutter-GroceryApp/assets/98425058/5ae355c9-39e0-478e-9b3e-870953b566ca"></video>

  
## Configurazione
* Inizia configurando endpoint, credenziali e parametri del prodotto in `lib\constants\AppConstants`.
* **In alternativa**, utilizza l’endpoint gratuito fornito qui sotto (alla data di condivisione) per testare correttamente.
```dart
class AppConstants {
  // Sostituisci "YOUR_API_PREFIX" con la tua URL base dell’API.
  static const String BASE_URL = "YOUR_API_PREFIX";
  static const String API_KEY = "YOUR_API_KEY"; //SE_PRESENTE

  // Per i test, usa la URL base dell’API gratuita dalla versione rilasciata
  static const String BASE_URL = "https://world.openfoodfacts.org/api/v2";

  // Nome completo del proprietario del progetto.
  static const String projectOwnerName = "FULL_NAME";
}
```

## Avviso
* Per utilizzare i tuoi endpoint API, personalizza i livelli logici seguendo le linee guida dell’architettura MVVM in base alla documentazione delle tue API.
* Alcune immagini nella versione pre-rilasciata sono state rimosse per restrizioni di copyright.

## Contribuire

Per favore, effettua un fork di questo repository e contribuisci tramite
[pull requests](https://github.com/ramiomarouayache/Flutter-GroceryApp/pulls).

Ogni contributo, grande o piccolo, nuove funzionalità, correzioni di bug, è benvenuto e apprezzato,
ma sarà accuratamente revisionato.


## Per iniziare
Questo progetto è un punto di partenza per un’applicazione Flutter.

Alcune risorse utili per iniziare, se è il tuo primo progetto Flutter:

- [Lab: Scrivi la tua prima app Flutter](https://flutter.io/docs/get-started/codelab)
- [Cookbook: Esempi utili Flutter](https://flutter.io/docs/cookbook)

## Contatore Visite

<img align="left" src = "https://profile-counter.glitch.me/GroceryApp/count.svg" alt ="Loading">

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---