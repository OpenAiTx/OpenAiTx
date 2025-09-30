# nix-config

Ma configuration [NixOS] avec [Nix Flakes], [Home Manager], [Stylix], et [Hyprland].

![Une capture d'écran de Pepper regardant avec sérieux des abréviations Git configurées de manière déclarative pour le shell fish, écrites en Nix.](https://raw.githubusercontent.com/donovanglover/nix-config/master/./cover.jpg)
<sub>Art de fond : [Le marché](https://www.peppercarrot.com/en/viewer/artworks__2022-02-21_The-market_by-David-Revoy.html), [En fleur](https://www.peppercarrot.com/en/viewer/artworks__2022-03-02_In-Bloom_by-David-Revoy.html) et [Couverture verticale livre deux écran](https://www.peppercarrot.com/en/viewer/artworks__2016-11-14_vertical-cover-book-two_screen_by-David-Revoy.html) par David Revoy − [CC-BY 4.0](https://creativecommons.org/licenses/by/4.0/deed.en).</sub>

![Une capture d'écran d'un environnement de programmation Rust avec Neovim, kitty, et bacon.](https://raw.githubusercontent.com/donovanglover/nix-config/master/./.github/screenshots/neovim.png)
<sub>Art de fond : [Video game jam](https://www.peppercarrot.com/en/viewer/misc__2023-06-12_video-game-jam_by-David-Revoy.html) par David Revoy − [CC-BY 4.0](https://creativecommons.org/licenses/by/4.0/deed.en).</sub>

## Fonctionnalités

- Code propre et lisible pouvant être facilement modifié pour ajouter/supprimer des éléments selon les besoins.
- Environnement entièrement reproductible et déclaratif grâce à NixOS.
- Conteneurs raisonnablement sécurisés isolés de vos fichiers personnels et du réseau.
- Nix Flakes + Home Manager + Btrfs sur LUKS.
- Configuration Neovim simple mais efficace avec nvim-lspconfig.
- Support Wayland moderne avec Hyprland et le layout master-stack.
- Possibilité de basculer facilement vers une config dwm similaire si X est nécessaire.
- Support complet du japonais avec polices, méthode de saisie et wine pris en charge.
- Schéma de couleurs universel hérité par toutes les applications.

## Utilisation

```fish
git clone https://github.com/donovanglover/nix-config && cd nix-config
nixos-rebuild build-vm --flake .#nixos
./result/bin/run-nixos-vm
```

La base de code est conçue pour être petite afin qu'il soit facile d'ajuster les choses selon les besoins. Amusez-vous bien !

[NixOS] : https://nixos.org/
[Nix Flakes] : https://wiki.nixos.org/wiki/Flakes
[Home Manager] : https://nix-community.github.io/home-manager/
[Stylix] : https://danth.github.io/stylix/
[Hyprland] : https://hyprland.org/


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-30

---