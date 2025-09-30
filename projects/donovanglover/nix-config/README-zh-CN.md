# nix-config

我的 [NixOS] 配置，结合了 [Nix Flakes]、[Home Manager]、[Stylix] 和 [Hyprland]。

![Pepper认真地看着用Nix声明式配置的fish shell Git缩写的截图。](https://raw.githubusercontent.com/donovanglover/nix-config/master/./cover.jpg)
<sub>背景艺术：[市场](https://www.peppercarrot.com/en/viewer/artworks__2022-02-21_The-market_by-David-Revoy.html)、[盛开](https://www.peppercarrot.com/en/viewer/artworks__2022-03-02_In-Bloom_by-David-Revoy.html) 和 [第二册垂直封面屏幕](https://www.peppercarrot.com/en/viewer/artworks__2016-11-14_vertical-cover-book-two_screen_by-David-Revoy.html)，作者 David Revoy − [CC-BY 4.0](https://creativecommons.org/licenses/by/4.0/deed.en)。</sub>

![Rust编程环境与Neovim、kitty和bacon的截图。](https://raw.githubusercontent.com/donovanglover/nix-config/master/./.github/screenshots/neovim.png)
<sub>背景艺术：[视频游戏创作活动](https://www.peppercarrot.com/en/viewer/misc__2023-06-12_video-game-jam_by-David-Revoy.html)，作者 David Revoy − [CC-BY 4.0](https://creativecommons.org/licenses/by/4.0/deed.en)。</sub>

## 功能

- 干净、易读的代码，便于根据需要轻松添加或删除功能。
- 由于NixOS，实现完全可重现和声明式的环境。
- 合理安全的容器，与个人文件和网络隔离。
- Nix Flakes + Home Manager + 使用LUKS的Btrfs。
- 简单而有效的Neovim配置，配合nvim-lspconfig。
- 使用Hyprland和master-stack布局的现代Wayland支持。
- 如需X环境，可轻松切换到类似的dwm配置。
- 完整的日语支持，包括字体、输入法和wine。
- 所有应用共享的统一配色方案。

## 使用方法

```fish
git clone https://github.com/donovanglover/nix-config && cd nix-config
nixos-rebuild build-vm --flake .#nixos
./result/bin/run-nixos-vm
```
代码库设计得很小巧，便于根据需要进行调整。玩得开心！

[NixOS]: https://nixos.org/
[Nix Flakes]: https://wiki.nixos.org/wiki/Flakes
[Home Manager]: https://nix-community.github.io/home-manager/
[Stylix]: https://danth.github.io/stylix/
[Hyprland]: https://hyprland.org/



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-30

---