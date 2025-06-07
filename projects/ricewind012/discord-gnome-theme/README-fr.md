# Thème Discord GNOME

Un thème GNOME pour Discord, suivant le style Adwaita et les directives de l’interface humaine GNOME (dans la mesure de ce que le CSS de Discord permet).

## Prérequis

1. Vesktop

   Pour activer la barre de titre Windows.

2. Paramètres > Langue > Choisir « English (US) »

   Cela permet l’utilisation d’icônes personnalisées en raison de la façon dont elles sont identifiées dans Discord. Vous pouvez [localiser](https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/src/global/icons.scss) le thème, mais veuillez lire la note sur la localisation.

3. Paramètres > Plugins > Activer « ThemeAttributes »

   Cela permet l’affichage des icônes dans la boîte de dialogue des paramètres.

4. Paramètres > Paramètres Vesktop > Activer « Discord Titlebar »

   Optionnel, mais recommandé si vous utilisez des barres de titre.

### Ajouts optionnels

1. Supprimer les références à Nitro : https://github.com/CroissantDuNord/discord-adblock

## Philosophie du thème

### Directives de l’interface humaine

Le thème peut ne pas entièrement respecter les HIG à cause des limitations CSS ou de design de Discord, ou de mes propres choix.

### Support

Les éléments suivants ne sont pas pris en charge :

- Expérimentations Discord

  Je ne travaille pas pour Discord, donc je n’ai aucun moyen de savoir si ces expérimentations sont modifiées, dépréciées, etc., c’est-à-dire un fardeau de maintenance — je maintiens plusieurs autres projets.

- Nitro

  Exceptions — tout ce qui est accessible avec le plugin FakeNitro.

Vous *pouvez* ouvrir un ticket concernant l’un de ces éléments, mais il ne sera corrigé que s’il s’agit d’une correction simple, par exemple une icône manquante.

## Installation

### Sans configuration

Copiez ce qui suit dans la boîte de texte située dans Paramètres > Thèmes > Thèmes en ligne :

```
https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/gnome.theme.css
```

### Avec configuration

Placez [gnome.theme.css](https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/gnome.theme.css) dans ~/.config/vesktop/themes. Il est toujours mis à jour automatiquement.

## Aperçu

![first](https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/assets/preview/Screenshot%20from%202024-04-27%2011-55-58.png)
![cozy second](https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/assets/preview/Screenshot%20from%202024-04-27%2012-31-42.png)
![third](https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/assets/preview/Screenshot%20from%202024-04-27%2012-24-16.png)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---