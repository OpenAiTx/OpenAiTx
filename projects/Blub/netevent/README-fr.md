# netevent

Netevent est un outil qui peut être utilisé pour partager des périphériques d'événements linux avec d'autres
machines (soit via `/dev/uinput` soit en implémentant un client pour le même
protocole par d'autres moyens).

À l'origine, il se contentait d'afficher les capacités du périphérique sur stdout puis
se comportait comme un `cat /dev/input/eventX` dans un mode, et dans l'autre
transmettait les capacités analysées à `/dev/uinput` puis passait les événements
directement.

Comme gérer cela pour plusieurs périphériques peut devenir fastidieux lorsqu'on a plus
d'une destination (et puisque les mécanismes originaux de capture/bascule/touche de raccourci étaient
étranges et ciblaient littéralement mon cas d'utilisation personnel), netevent2 étend maintenant le
protocole pour contenir des paquets pouvant contenir plus d'un périphérique et pouvant ajouter
et retirer des périphériques à la volée.

Le comportement original de type `cat` (bien que actuellement sans support de raccourci)
est aussi disponible à des fins de débogage (et le mode `create` supporte les deux
versions du protocole).

L'outil principal est maintenant le `netevent daemon` qui dispose d'une socket de commande (une
socket unix abstraite optionnelle) via laquelle on peut ajouter des périphériques, sorties et
raccourcis à la volée. Voir les exemples ci-dessous.

## Compilation

* optionnellement : `./configure --prefix=/usr`
* `make`

Vous pouvez toujours simplement exécuter `make` comme avant. Cependant, pour supporter les flux
d'installation habituels, et pour distinguer les systèmes avec des noyaux plus récents
où `/dev/uinput` a été étendu avec un `ioctl` `UI_DEV_SETUP`, un
script `./configure` a été ajouté pour vérifier cela et créer un `config.h`
ainsi qu'un `config.mak` pour PREFIX/BINDIR/... (tous ces paramètres peuvent également être passés
directement à `make` en tant que variables, ainsi que le classique `DESTDIR`).

## Installation

* `make install` ou `make DESTDIR=/mon/repertoire/de/mise_en_scene install`
Ou : comme précédemment, placez simplement le binaire `netevent` où vous voulez.

## Utilisation

Voir la section COMMANDES DU DAEMON dans netevent(1) pour les détails sur les commandes utilisées
dans les scripts d’installation ci-dessous.

### Exemples

Voir le répertoire `examples/`. Lisez l’exemple d’installation ci-dessous pour voir comment adapter
les lignes de raccourcis clavier pour fonctionner avec vos appareils.

#### Exemple simple d’installation : partager clavier et souris avec une machine via ssh :

Côté hôte :

* Préparation : Assurez-vous que nous pouvons accéder aux périphériques event en tant qu’utilisateur

    Habituellement, cela signifie exécuter quelque chose comme `gpasswd -a monutilisateur input`

* Étape 1 : Décidez quels périphériques /dev/input/eventXY transmettre.

    Pour des noms de fichiers cohérents, utilisez quelque chose comme :
    `/dev/input/by-id/usb-MonClavierSuper-event-kbd`
    `/dev/input/by-id/usb-MeilleureSourisEver-event-mouse`

* Étape 2 : Choisissez un raccourci clavier et trouvez son code d’événement :

    Dans l’exemple ci-dessus, nous voulons utiliser une touche du clavier (à moins que vous
    n’ayez une quantité folle de boutons de souris...).
    `netevent` peut être utilisé pour afficher les événements de façon lisible, lancez la sous-commande `show`
    sur le périphérique et appuyez sur les touches que vous voulez utiliser pour les raccourcis.
    Si c’est le même clavier avec lequel vous tapez la commande, ajoutez un
    délai (sleep) pour éviter la confusion lorsque netevent détecte le relâchement de la touche entrée.


    ```
    $ sleep 0.3 && netevent show /dev/input/by-id/usb-...-event-kbd
    MSC:4:3829
    KEY:189:1
    SYN:0:0
    MSC:4:3829
    KEY:189:0
    SYN:0:0
    ```

* Étape 3 : Préparer un script d'installation pour le démon :

    ```
    # file: netevent-setup.ne2
    # Add mouse & keyboard
    device add mymouse /dev/input/by-id/usb-BestMouseEver-event-mouse
    device add mykbd /dev/input/by-id/usb-MyAwesomeKeyboard-event-kbd

    # Add toggle hotkey (on press, and ignore the release event)
    hotkey add mykbd key:189:1 grab-devices toggle\; write-events toggle
    hotkey add mykbd key:189:0 nop

    # Connect to the two devices via password-less ssh
    output add myremote exec:ssh user@other-host netevent create
    # Select the output to write to
    use myremote
    ```

* Étape 4 : Lancez le démon netevent :

    `$ netevent daemon -s netevent-setup.ne2 netevent-command.sock`

Vous pouvez maintenant envoyer des commandes supplémentaires au démon en vous connectant à la socket.
Par exemple via `socat READLINE UNIX-CONNECT:netevent-command.sock`.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-21

---