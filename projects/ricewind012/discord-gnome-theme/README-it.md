# Tema GNOME per Discord

Un tema GNOME per Discord, che segue lo stile Adwaita e le GNOME Human Interface Guidelines (per quanto concesso dal CSS di Discord).

## Requisiti

1. Vesktop

   Per abilitare la barra del titolo di Windows.

2. Impostazioni > Lingua > Scegli "English (US)"

   Questo permette l’uso di icone personalizzate grazie al modo in cui sono identificate in Discord. Puoi [localizzare](https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/src/global/icons.scss) il tema, ma leggi la nota sulla localizzazione.

3. Impostazioni > Plugin > Abilita "ThemeAttributes"

   Questo permette l’uso di icone nella finestra delle impostazioni.

4. Impostazioni > Vesktop Settings > Abilita "Discord Titlebar"

   Opzionale, ma consigliato se hai le barre del titolo.

### Aggiunte opzionali

1. Rimuovi i riferimenti a Nitro: https://github.com/CroissantDuNord/discord-adblock

## Filosofia del tema

### Human Interface Guidelines

Il tema potrebbe non rispettare completamente le HIG a causa di limitazioni del CSS o del design di Discord, oppure per mie scelte personali.

### Supporto

Non sono supportati:

- Esperimenti di Discord

  Non lavoro per Discord, quindi non posso sapere se questi esperimenti vengono modificati, deprecati, ecc., ovvero rappresentano un carico di manutenzione — gestisco anche altri progetti

- Nitro

  Eccezioni — tutto ciò che è accessibile tramite il plugin FakeNitro.

Puoi \*segnalare\* un problema relativo a questi elementi, ma verrà risolto solo se è una correzione semplice, ad esempio un’icona mancante.

## Installazione

### Senza configurazione

Copia quanto segue nella casella di testo che si trova in Impostazioni > Temi > Temi Online:

```
https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/gnome.theme.css
```

### Inclusa la configurazione

Metti [gnome.theme.css](https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/gnome.theme.css) in ~/.config/vesktop/themes. Rimane comunque aggiornato automaticamente.

## Anteprima

![first](https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/assets/preview/Screenshot%20from%202024-04-27%2011-55-58.png)
![cozy second](https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/assets/preview/Screenshot%20from%202024-04-27%2012-31-42.png)
![third](https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/assets/preview/Screenshot%20from%202024-04-27%2012-24-16.png)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---