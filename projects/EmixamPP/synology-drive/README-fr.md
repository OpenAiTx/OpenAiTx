# <p align=center>synology-drive</p>

Paquet RPM non officiel du client Synology Drive <https://www.synology.com>.

Comme le paquet fourni par FlatHub n’est pas 100 % fonctionnel et que la méthode de conversion deb en rpm par Alien nécessite beaucoup de manipulations,  
j’ai décidé de créer moi-même un paquet RPM propre et 100 % fonctionnel pour le client Synology Drive.

J’ai inclus l’explorateur de fichiers Nautilus en dépendance afin d’avoir accès au menu de partage et d’avoir l’indicateur de statut de synchronisation des fichiers (comme sous Windows ou Ubuntu).\
J’ai aussi inclus une extension GNOME shell en dépendance afin de voir l’icône dans la barre d’état (fonctionne nativement avec KDE).\
J’ai construit un second paquet pour les utilisateurs qui n’utilisent pas GNOME. Il ne contient pas les deux dépendances mentionnées ci-dessus (elles peuvent être installées plus tard si vous le souhaitez).



## Installation
Si vous avez déjà installé Synology Drive Client via Alien ou Flatpak (c’est-à-dire depuis une autre source que mon dépôt), veuillez vous assurer qu’ils sont désinstallés.

Si vous aimez ce projet, n’hésitez pas à étoiler le dépôt pour me soutenir, merci !

### Méthode 1 : installation depuis le dépôt COPR (recommandé pour les mises à jour)
Lien de la page : [paquet COPR](https://copr.fedorainfracloud.org/coprs/emixampp/synology-drive/).

1. `sudo dnf copr enable emixampp/synology-drive`
2. Pour GNOME : `sudo dnf --refresh install synology-drive`
3. Pour les autres environnements de bureau : `sudo dnf --refresh install synology-drive-noextra`

### Méthode 2 : construire le paquet localement (pas de mise à jour)
1. Installer les outils de compilation : `sudo dnf install rpm-build rpmdevtools`
2. `git clone https://github.com/EmixamPP/synology-drive.git`
3. `cd synology-drive`
4. Optionnel, si vous souhaitez changer la version :
   1. Consultez les [notes de version](https://www.synology.com/en-global/releaseNote/SynologyDriveClient) et choisissez la version désirée (>= 3.2.1-13271)
   2. Modifiez les deux premières lignes de `synology-drive.spec` ou `synology-drive-noextra.spec`, selon que vous utilisez GNOME ou un autre environnement de bureau.
5. Pour GNOME :
   1. `spectool -g -R synology-drive.spec`
   2. `rpmbuild -ba synology-drive.spec`
   3. `sudo dnf install ~/rpmbuild/RPMS/x86_64/synology-drive-*.x86_64.rpm`
6. Pour les autres environnements de bureau : 
   1. `spectool -g -R synology-drive-noextra.spec`
   2. `rpmbuild -ba synology-drive-noextra.spec`
   3. `sudo dnf install ~/rpmbuild/RPMS/x86_64/synology-drive-noextra-*.x86_64.rpm`
7. Nettoyer le répertoire de compilation : `rm -r ~/rpmbuild`
### Expérimental : construire le paquet localement pour les processeurs Aarch64/ARM64 (par ex. Apple Silicon, Qualcomm Snapdragon)
1. Installer les outils de construction : `sudo dnf install rpm-build rpmdevtools`
2. `git clone https://github.com/EmixamPP/synology-drive.git`
3. `cd synology-drive`
4. Optionnel, si vous souhaitez changer la version :
   1. Consultez les [notes de version](https://www.synology.com/en-global/releaseNote/SynologyDriveClient) et choisissez la version désirée (>= 3.2.1-13271)
   2. Modifiez les deux premières lignes de `synology-drive.spec` ou `synology-drive-noextra.spec`, selon que vous utilisez GNOME ou un autre environnement de bureau.
5. Pour GNOME :
   1. `spectool -g -R synology-drive-aarch64.spec`
   2. `rpmbuild -ba synology-drive-aarch64.spec`
   3. `sudo dnf install ~/rpmbuild/RPMS/x86_64/synology-drive-*.aarch64.rpm`
6. Pour d'autres environnements de bureau :
   1. `spectool -g -R synology-drive-aarch64-noextra.spec`
   2. `rpmbuild -ba synology-drive-aarch64-noextra.spec`
   3. `sudo dnf install ~/rpmbuild/RPMS/x86_64/synology-drive-noextra-*.aarch64.rpm`
7. Nettoyer le répertoire de construction : `rm -r ~/rpmbuild`
**Attention**_** : Cette solution utilise l'émulateur FEX. Si vous utilisez l'émulateur QEMU, cela cassera probablement car binfmt_misc ne permet qu’à un seul émulateur de s’enregistrer pour les binaires x86_64.

## Informations légales
Consultez la [LICENSE](https://github.com/EmixamPP/synology-drive/blob/main/LICENSE).

Ce projet a été autorisé par Synology Inc.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-29

---