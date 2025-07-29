# OBSOLÈTE
Cette extension a été dépréciée, mais une nouvelle extension Smart Home a été publiée pour la remplacer. Veuillez vous rendre sur https://github.com/vchlum/smart-home

# hue-lights
![capture d’écran](https://github.com/vchlum/hue-lights/blob/main/screenshot.png)

## Extension Gnome Shell
hue-lights est une extension Gnome Shell pour les lumières Philips Hue contrôlées par le Philips Hue Bridge sur le réseau local. L’extension regroupe les lumières en zones et en pièces. Il est possible de contrôler l’état, la luminosité, et la couleur ou la température. Les scènes peuvent être activées pour les zones ou les pièces. Plusieurs ponts peuvent être contrôlés. Il est également possible de définir des lumières qui clignoteront lors d’une notification.

## Zones Philips Hue Entertainment
Cette extension supporte les zones Entertainment. En utilisant l’application originale sur le téléphone, vous pouvez créer une zone Entertainment. Vous pouvez ensuite commencer à synchroniser vos lumières avec votre écran. La fonction de synchronisation nécessite une clé spéciale générée lors de l’appairage avec le pont. La mise à niveau depuis la version 8 ou antérieure nécessite de retirer et reconnecter le pont Philips Hue. Veuillez garder votre pont à jour. La fonction nécessite également la version API 1.22 ou plus récente.

## Support du Philips Hue HDMI sync box
Cette extension permet de contrôler la boîte de synchronisation HDMI Philips Hue sur le réseau local. Vous pouvez activer/désactiver la synchronisation, changer le mode, modifier l’intensité, ajuster la luminosité, sélectionner la zone Entertainment et choisir l’entrée HDMI.

## Dépannage
 1. Si vous rencontrez des problèmes avec la mise à niveau, essayez de vous déconnecter puis de vous reconnecter.
 1. Si vos problèmes persistent, réinitialisez cette extension en réinitialisant la clé : "/org/gnome/shell/extensions/hue-lights/" dans gnome.
    * Vous pouvez appeler : `dconf reset -f /org/gnome/shell/extensions/hue-lights/` ou utiliser `dconf-editor`.
 1. Si le problème persiste, veuillez déposer un rapport sur GitHub. Si possible, activez le mode debug dans les paramètres et joignez le fichier de log.
    * Vous pouvez obtenir le fichier de log ainsi : `journalctl -f /usr/bin/gnome-shell 2>&1 | grep -i hue > hue-lights.log`.

## Avertissement
Cette application utilise des effets lumineux à changements rapides seuls ou en combinaison avec certains contenus à l’écran, ce qui peut déclencher des symptômes épileptiques ou des crises chez des personnes sans antécédents de crises ou d’épilepsie.

## Versions supportées de Gnome Shell
Cette extension supporte la version 45 de Gnome Shell et les versions ultérieures.

## Installation depuis e.g.o
https://extensions.gnome.org/extension/3737/hue-lights

## Installation manuelle

 1. `git clone https://github.com/vchlum/hue-lights.git`
 1. `cd hue-lights`
 1. `make build`
 1. `make install`
 1. Déconnectez-vous & reconnectez-vous
 1. `gnome-extensions enable hue-lights@chlumskyvaclav.gmail.com`

## Installer les dépendances
  - Celles-ci sont requises uniquement pour l’installation depuis la source
  - `make`
  - `gnome-shell` (commande `gnome-extensions`)
  - `glib-compile-resources`
  - `libglib2.0-dev-bin`
  - `gettext`
  - Celles-ci sont recommandées pour exécuter l’extension
  - `avahi-tools` (commande `avahi-browse` pour découvrir les appareils sur le réseau local)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---