# gnome-shell-extension-ideapad
Fonctionnalités Lenovo IdeaPad pour GNOME Shell

*Pour le moment, l’extension offre uniquement un moyen simple et convivial d’activer/désactiver le mode de conservation de la batterie disponible sur les ordinateurs portables Lenovo Ideapad et de visualiser son état actuel.*

# Installation
Installez simplement l’extension depuis le [site officiel des extensions GNOME](https://extensions.gnome.org/extension/2992/ideapad/) (recommandé). Alternativement, téléchargez ou clonez manuellement le dépôt sous `~/.local/share/gnome-shell/extensions/ideapad@laurento.frittella`

Dans les deux cas, quelques étapes supplémentaires sont nécessaires. Veuillez consulter la section dédiée suivante.

Si vous souhaitez consulter le code, sachez que la branche `master` cible la dernière version stable de GNOME Shell. Les versions antérieures sont toujours prises en charge dans des branches dédiées (par exemple `pre-43`).

# Utilisation
L’extension ajoute une nouvelle entrée *Basculer le mode de conservation* au panneau et affiche une icône dans le menu d’état pour indiquer lorsque le mode de conservation de la batterie est activé.

Si votre modèle d’ordinateur portable le supporte, le mode de conservation limite la charge de la batterie à 55-60 % de sa capacité pour prolonger sa durée de vie. Il est particulièrement utile lorsque l’ordinateur portable fonctionne principalement sur alimentation externe.

| GNOME Shell < 43    | GNOME Shell >= 43      |
|---------------------|------------------------|
| ![](https://raw.githubusercontent.com/laurento/gnome-shell-extension-ideapad/master/screenshot.png) | ![](https://raw.githubusercontent.com/laurento/gnome-shell-extension-ideapad/master/screenshot-43.png) |

# Paramètres supplémentaires requis
Votre utilisateur de bureau doit avoir un accès en lecture-écriture à un fichier sysfs spécifique normalement possédé par l’utilisateur root. Le moyen le plus simple d’y parvenir est d’utiliser `sudo`. Les étapes suivantes ont été testées sur Debian, mais elles devraient fonctionner sur tout système GNU/Linux moderne. En cas de doute, référez-vous à la documentation spécifique de votre distribution.

* Selon votre distribution, vous devez utiliser le groupe `sudo` (par exemple Debian et Ubuntu) ou `wheel` (par exemple Arch et Fedora). En cas de doute, exécutez la commande `groups` dans un terminal et voyez lequel des deux est listé dans la sortie.

  Ajoutez l’entrée suivante à la configuration sudoers de votre système (par exemple `/etc/sudoers.d/ideapad`). **Veillez à remplacer** `%sudo` par `%wheel` si nécessaire.
  ~~~
  %sudo ALL=(ALL) NOPASSWD: /usr/bin/tee /sys/bus/platform/drivers/ideapad_acpi/VPC????\:??/conservation_mode
  ~~~

* Pour s’assurer que le module noyau `ideapad_laptop` soit chargé automatiquement au démarrage, ajoutez-le simplement au fichier `/etc/modules`

Pour résumer et pour référence rapide...
~~~
# N’oubliez pas de remplacer %sudo par %wheel si nécessaire !
#
$ echo "%sudo ALL=(ALL) NOPASSWD: /usr/bin/tee /sys/bus/platform/drivers/ideapad_acpi/VPC????\:??/conservation_mode" | sudo tee /etc/sudoers.d/ideapad
$ echo "ideapad_laptop" | sudo tee -a /etc/modules
~~~

# Estimation incorrecte de la batterie affichée
Selon la version du noyau que vous utilisez, un petit problème esthétique peut encore exister. Cependant, si le statut permanent "Estimation en cours..." de la batterie affiché dans GNOME vous dérange, il existe également une solution.

En fait, ce problème devrait être corrigé dans les noyaux 5.19+. Si vous utilisez un noyau plus ancien, vous pouvez essayer d'appliquer [le correctif ici](https://git.kernel.org/pub/scm/linux/kernel/git/torvalds/linux.git/commit/?id=185d20694a8aceb4eda9fc1314cbaad0df0aab07). Merci à Martino Fontana de l'avoir signalé.

Sinon, vous pouvez utiliser le correctif que j'avais initialement suggéré dans [cette demande de fusion uPower](https://gitlab.freedesktop.org/upower/upower/-/merge_requests/46). Toutefois, je conseillerais personnellement d'opter pour le correctif du noyau. C'est une solution bien plus propre.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-21

---