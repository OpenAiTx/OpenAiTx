# No-QAnon

Une liste de blocage de domaines antifasciste des sites QAnon, conspirationnistes, de fausses informations, d’extrême droite et discriminatoires.

En bloquant les sites liés aux groupes haineux et aux acteurs malveillants, elle vise à désamorcer le recrutement, la propagande et ralentir la propagation de la désinformation via des tactiques telles que les opérations psychologiques, l’astroturfing, les trolls, les fausses bannières, le sockpuppeting, le terrorisme stochastique, la peur, l’incertitude et le doute.

Une liste de blocage de domaines bloque uniquement des sites entiers : elle ne peut malheureusement pas bloquer quoi que ce soit sur les réseaux sociaux où la radicalisation a souvent lieu.
Elle réduira néanmoins définitivement l’exposition aux informations fausses et nuisibles.
Les fascistes s’attaquent aux vulnérables, alors restez vigilant et envisagez également d’utiliser une liste de blocage pour les réseaux sociaux si nécessaire.

Distribué sous la [licence antifasciste](https://github.com/rimu/no-qanon/blob/master/LICENSE.txt).

## Format Hosts

[Liste de blocage au format Hosts](https://raw.githubusercontent.com/rimu/no-qanon/master/hosts.txt) à utiliser dans un fichier [hosts](https://fr.wikipedia.org/wiki/Fichier_hosts) ou PiHole.

[Version IPV6](https://raw.githubusercontent.com/rimu/no-qanon/master/hosts.txt.ipv6).

- [Instructions pour installer sur un ordinateur Windows.](https://github.com/yui-konnu/qanon-block-guide)

- [Instructions pour installer sur un PiHole.](https://www.reddit.com/r/QAnonCasualties/comments/wekhem/how_to_use_pihole_to_block_q_related_websites/)

Problème connu : l’option DNS over HTTPS de Firefox contourne les règles du fichier hosts de l’ordinateur. https://bugzilla.mozilla.org/show_bug.cgi?id=1453207

## Format Dnsmasq

[Liste de blocage au format Dnsmasq](https://raw.githubusercontent.com/rimu/no-qanon/master/dnsmasq.txt) à utiliser avec le logiciel serveur DNS [Dnsmasq](https://thekelleys.org.uk/dnsmasq/doc.html).

## Extensions de navigateur

### Format Netsane

[Liste de blocage au format Netsane](https://raw.githubusercontent.com/rimu/no-qanon/master/netsane.txt) à utiliser avec le logiciel [Netsane](https://github.com/rimu/netsane).

### Syntaxe AdBlock Plus

[Liste de blocage au format AdBlock](https://raw.githubusercontent.com/rimu/no-qanon/master/adblock.txt) à utiliser avec un bloqueur de publicité ([uBlock Origin](https://ublockorigin.com), [Adguard](https://adguard.com)…) ou Adguard Home. Elle utilise une [règle de blocage stricte](https://github.com/gorhill/uBlock/wiki/Strict-blocking) pour bloquer l’accès à ces sites dans votre navigateur.

[Cliquer ici pour s’abonner.](https://subscribe.adblockplus.org/?location=https://raw.githubusercontent.com/rimu/no-qanon/master/adblock.txt&title=No-QAnon)

### Syntaxe uBlacklist

[Liste de blocage au format uBlacklist](https://raw.githubusercontent.com/rimu/no-qanon/master/ublacklist.txt) à utiliser avec [uBlacklist](https://github.com/iorate/ublacklist). Elle supprime les sites bloqués des résultats des moteurs de recherche.

[Cliquez ici pour vous abonner.](https://iorate.github.io/ublacklist/subscribe?name=No-QAnon&url=https://raw.githubusercontent.com/rimu/no-qanon/master/ublacklist.txt) (Ce lien d’abonnement automatique est uniquement compatible avec Chrome, vous devez l’ajouter vous-même sur d’autres navigateurs !)

### Liste des domaines

[Format de la liste des domaines](https://raw.githubusercontent.com/rimu/no-qanon/master/domains.txt) à utiliser avec [Search Engine Spam Blocker](https://github.com/no-cmyk/Search-Engine-Spam-Blocker). Elle supprime les sites bloqués des résultats des moteurs de recherche.

## Comment contribuer

Clonez ce dépôt et ajoutez de nouveaux domaines dans les fichiers `.txt` appropriés dans le dossier `sources`. Si vous ne souhaitez pas catégoriser, placez-les simplement dans le fichier `sources/default.txt` et ils seront bloqués.

> Pour le site `https://www.example.com`, ajoutez `example.com` dans le fichier `sources/default.txt`.

Ensuite, lorsque vous poussez vos modifications dans le dossier `sources`, les actions GitHub devraient se déclencher et générer automatiquement de nouvelles versions des listes de blocage. Si vous souhaitez les générer vous-même, vous pouvez exécuter le script `scripts/update.sh` (prérequis : bash, python).

Enfin, faites une pull request : nous la réviserons et l’approuverons sous quelques jours.

### Catégorisation

Les sites bloqués sont organisés à l’aide de sous-dossiers et de fichiers `.txt` dans le dossier `sources`. Utilisez des fichiers markdown (`.md`) et des commentaires (`#`) pour ajouter plus d’informations et de références.

### Comment contribuer (mode facile)

Si vous ne savez pas comment fonctionne Git, vous pouvez quand même contribuer ! Il suffit d’[ouvrir une issue](https://github.com/rimu/no-qanon/issues) avec les URL que vous souhaitez ajouter à la liste, en les regroupant par langue et catégories si possible. Nous les vérifierons et les ajouterons rapidement.

## Autres listes utiles

[Listes de blocage Jmdugan](https://github.com/jmdugan/blocklists/tree/master/corporations) : pensez à bloquer Twitter, YouTube et Facebook car ils publient beaucoup de fausses informations.

[Liste de blocage Antifa-n](https://github.com/antifa-n/pihole/blob/master/blocklist.txt) est également une excellente liste ciblant les sites fascistes.

[Liste de blocage des méthodes de contournement](https://github.com/nextdns/metadata/blob/master/parentalcontrol/bypass-methods) peut être utilisée pour bloquer les méthodes de contournement (VPN, proxies, DNS, etc.).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-13

---