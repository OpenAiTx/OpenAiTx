# Monter Proton Drive sur Linux avec rclone et systemd

Ce guide automatise le processus de montage de [Proton Drive](https://proton.me/drive) sur un système Linux en utilisant [`rclone`](https://rclone.org/) et `systemd`.

Testé sur **Arch Linux**, mais devrait fonctionner sur la plupart des distributions Linux avec quelques ajustements mineurs.

---

## 🔧 Fonctionnalités

- Monte Proton Drive à la connexion via `systemd --user`
- Utilise `rclone` avec `--vfs-cache-mode writes` pour la compatibilité
- Active un service en arrière-plan avec journalisation
- Ajoute le support FUSE pour les montages `--allow-other`

---

## 🚀 Démarrage rapide

### 1. ✅ Installer les dépendances

#### Installer `fuse3` (nécessaire pour le montage) :
```bash
sudo pacman -S fuse3
````

#### Installer `rclone` (doit être v1.64.0 ou plus récent)

🔹 **Option 1 : Utiliser le binaire précompilé (recommandé)**

```bash
curl -O https://downloads.rclone.org/rclone-current-linux-amd64.zip
unzip rclone-current-linux-amd64.zip
cd rclone-*-linux-amd64
sudo cp rclone /usr/local/bin/
sudo chmod +x /usr/local/bin/rclone
```

Vérifier :

```bash
rclone version
# Must be v1.64.0 or higher
```

---

### 2. 🔐 Configure Proton Drive Remote

Run:

```bash
rclone config
```

Suivez les instructions :

* `n` → Nouveau remote
* Nom : `proton`
* Type : `protondrive`
* Connectez-vous via le navigateur lorsque demandé
* Acceptez et enregistrez

---

### 3. 📜 Exécuter le script d’installation

Exécutez le script fourni :

```bash
chmod +x setup-proton-mount.sh
./setup-proton-mount.sh
```

Le script va :

* Créer le point de montage : `~/ProtonDrive`
* Écrire le service utilisateur systemd
* Ajouter `user_allow_other` à `/etc/fuse.conf` (si manquant)
* Ajouter l'utilisateur au groupe `fuse` (si nécessaire)
* Activer et démarrer le service de montage

---

### 4. 🔁 Redémarrer ou Se Déconnecter/Reconnecter

Si le script vous a ajouté au groupe `fuse`, vous devez **vous déconnecter puis vous reconnecter** pour que le changement prenne effet.

---

## 🔍 Vérifier le montage

Vérifiez si Proton Drive est monté :

```bash
ls ~/ProtonDrive
```

Vérifier le service systemd :

```bash
systemctl --user status rclone-proton.mount.service
```

---

## 🔁 Remount

If unmounted the Proton Drive can be remounted by:

```bash
systemctl --user restart rclone-proton.mount.service
```

Notez que Proton Drive est monté automatiquement à chaque connexion.

## 🧼 Désinstallation

Pour supprimer la configuration de montage automatique :

```bash
systemctl --user disable --now rclone-proton.mount.service
rm ~/.config/systemd/user/rclone-proton.mount.service
```
(Optional) Supprimez `~/ProtonDrive` si vous n'avez plus besoin du point de montage.

---

## 📁 Fichiers

* `setup-proton-mount.sh` — script d'installation complet
* `~/.config/systemd/user/rclone-proton.mount.service` — unité systemd
* `~/ProtonDrive` — emplacement de montage
* `~/.cache/rclone/rclone-proton.log` — sortie du journal (optionnel)

---

## 📎 Exigences

* `rclone >= 1.64.0` avec support Proton Drive
* `fuse3`
* Un compte Proton Drive

---

## 🛟 Dépannage

Si le montage ne fonctionne pas :


```bash
journalctl --user -u rclone-proton.mount.service
```
Pour redémarrer le service manuellement :


```bash
systemctl --user restart rclone-proton.mount.service
```

---

## 📚 Références

* [rclone Proton Drive Docs](https://rclone.org/protondrive/)
* [services utilisateur systemd](https://wiki.archlinux.org/title/Systemd/User)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-06

---