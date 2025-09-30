# nix-config

私の[NixOS]設定で、[Nix Flakes]、[Home Manager]、[Stylix]、および[Hyprland]を使用しています。

![Nixで記述されたfishシェル用の宣言的に設定されたGitの略語を真剣に見つめるPepperのスクリーンショット。](https://raw.githubusercontent.com/donovanglover/nix-config/master/./cover.jpg)
<sub>背景アート：[The market](https://www.peppercarrot.com/en/viewer/artworks__2022-02-21_The-market_by-David-Revoy.html)、[In Bloom](https://www.peppercarrot.com/en/viewer/artworks__2022-03-02_In-Bloom_by-David-Revoy.html)、および[Vertical cover book two screen](https://www.peppercarrot.com/en/viewer/artworks__2016-11-14_vertical-cover-book-two_screen_by-David-Revoy.html) by David Revoy − [CC-BY 4.0](https://creativecommons.org/licenses/by/4.0/deed.ja).</sub>

![Neovim、kitty、baconを使ったRustプログラミング環境のスクリーンショット。](https://raw.githubusercontent.com/donovanglover/nix-config/master/./.github/screenshots/neovim.png)
<sub>背景アート：[Video game jam](https://www.peppercarrot.com/en/viewer/misc__2023-06-12_video-game-jam_by-David-Revoy.html) by David Revoy − [CC-BY 4.0](https://creativecommons.org/licenses/by/4.0/deed.ja).</sub>

## 特徴

- 必要に応じて簡単に追加・削除できる、クリーンで読みやすいコード。
- NixOSによる完全に再現可能で宣言的な環境。
- 個人ファイルやネットワークから隔離された、適度に安全なコンテナ。
- Nix Flakes + Home Manager + LUKS上のBtrfs。
- nvim-lspconfigを使ったシンプルかつ効果的なNeovimセットアップ。
- Hyprlandとmaster-stackレイアウトによるモダンなWaylandサポート。
- Xが必要な場合には類似のdwm設定に簡単に切り替え可能。
- フォント、入力方式、Wineをカバーした完全な日本語対応。
- すべてのアプリケーションに継承されるユニバーサルカラースキーム。

## 使い方

```fish
git clone https://github.com/donovanglover/nix-config && cd nix-config
nixos-rebuild build-vm --flake .#nixos
./result/bin/run-nixos-vm
```

コードベースは小さく設計されているため、必要に応じて簡単に調整できます。楽しんでください！

[NixOS]: https://nixos.org/
[Nix Flakes]: https://wiki.nixos.org/wiki/Flakes
[Home Manager]: https://nix-community.github.io/home-manager/
[Stylix]: https://danth.github.io/stylix/
[Hyprland]: https://hyprland.org/


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-30

---