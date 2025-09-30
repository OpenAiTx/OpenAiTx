# nix-config

Mi configuración de [NixOS] con [Nix Flakes], [Home Manager], [Stylix] y [Hyprland].

![Una captura de pantalla de Pepper mirando con atención a abreviaciones de Git configuradas declarativamente para el shell fish, escritas en Nix.](https://raw.githubusercontent.com/donovanglover/nix-config/master/./cover.jpg)
<sub>Arte de fondo: [El mercado](https://www.peppercarrot.com/en/viewer/artworks__2022-02-21_The-market_by-David-Revoy.html), [En flor](https://www.peppercarrot.com/en/viewer/artworks__2022-03-02_In-Bloom_by-David-Revoy.html) y [Portada vertical libro dos pantalla](https://www.peppercarrot.com/en/viewer/artworks__2016-11-14_vertical-cover-book-two_screen_by-David-Revoy.html) por David Revoy − [CC-BY 4.0](https://creativecommons.org/licenses/by/4.0/deed.es).</sub>

![Una captura de pantalla de un entorno de programación Rust con Neovim, kitty y bacon.](https://raw.githubusercontent.com/donovanglover/nix-config/master/./.github/screenshots/neovim.png)
<sub>Arte de fondo: [Video game jam](https://www.peppercarrot.com/en/viewer/misc__2023-06-12_video-game-jam_by-David-Revoy.html) por David Revoy − [CC-BY 4.0](https://creativecommons.org/licenses/by/4.0/deed.es).</sub>

## Características

- Código limpio y legible que puede modificarse fácilmente para añadir/eliminar cosas según sea necesario.
- Entorno totalmente reproducible y declarativo gracias a NixOS.
- Contenedores razonablemente seguros aislados de tus archivos personales y red.
- Nix Flakes + Home Manager + Btrfs sobre LUKS.
- Configuración simple pero efectiva de Neovim con nvim-lspconfig.
- Soporte moderno de Wayland con Hyprland y el diseño master-stack.
- Cambio sencillo a una configuración similar de dwm si X es necesario.
- Soporte completo para japonés con fuentes, método de entrada y wine cubiertos.
- Un esquema de colores universal heredado por todas las aplicaciones.

## Uso

```fish
git clone https://github.com/donovanglover/nix-config && cd nix-config
nixos-rebuild build-vm --flake .#nixos
./result/bin/run-nixos-vm
```

La base de código está diseñada para ser pequeña, por lo que es fácil ajustar las cosas según sea necesario. ¡Diviértete!

[NixOS]: https://nixos.org/
[Nix Flakes]: https://wiki.nixos.org/wiki/Flakes
[Home Manager]: https://nix-community.github.io/home-manager/
[Stylix]: https://danth.github.io/stylix/
[Hyprland]: https://hyprland.org/


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-30

---