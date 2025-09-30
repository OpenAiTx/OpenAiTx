# nix-config

내 [NixOS] 구성은 [Nix Flakes], [Home Manager], [Stylix], 그리고 [Hyprland]와 함께 사용됩니다.

![Nix로 작성된 fish 셸용 선언적 구성 Git 약어를 진지하게 바라보는 Pepper의 스크린샷입니다.](https://raw.githubusercontent.com/donovanglover/nix-config/master/./cover.jpg)
<sub>배경 아트: David Revoy의 [The market](https://www.peppercarrot.com/en/viewer/artworks__2022-02-21_The-market_by-David-Revoy.html), [In Bloom](https://www.peppercarrot.com/en/viewer/artworks__2022-03-02_In-Bloom_by-David-Revoy.html) 및 [Vertical cover book two screen](https://www.peppercarrot.com/en/viewer/artworks__2016-11-14_vertical-cover-book-two_screen_by-David-Revoy.html) − [CC-BY 4.0](https://creativecommons.org/licenses/by/4.0/deed.en).</sub>

![Neovim, kitty, bacon과 함께하는 Rust 프로그래밍 환경의 스크린샷입니다.](https://raw.githubusercontent.com/donovanglover/nix-config/master/./.github/screenshots/neovim.png)
<sub>배경 아트: David Revoy의 [Video game jam](https://www.peppercarrot.com/en/viewer/misc__2023-06-12_video-game-jam_by-David-Revoy.html) − [CC-BY 4.0](https://creativecommons.org/licenses/by/4.0/deed.en).</sub>

## 특징

- 필요에 따라 쉽게 수정할 수 있는 깔끔하고 읽기 쉬운 코드.
- NixOS 덕분에 완전히 재현 가능하고 선언적인 환경.
- 개인 파일과 네트워크로부터 격리된 적절히 안전한 컨테이너.
- Nix Flakes + Home Manager + LUKS 위의 Btrfs.
- nvim-lspconfig와 함께하는 간단하지만 효과적인 Neovim 설정.
- Hyprland와 master-stack 레이아웃을 통한 현대적인 Wayland 지원.
- X가 필요할 경우 유사한 dwm 구성으로 쉽게 전환 가능.
- 폰트, 입력 방법, 와인까지 완벽하게 지원하는 일본어 환경.
- 모든 애플리케이션이 상속받는 통합 색상 스킴.

## 사용법

```fish
git clone https://github.com/donovanglover/nix-config && cd nix-config
nixos-rebuild build-vm --flake .#nixos
./result/bin/run-nixos-vm
```
코드 베이스는 필요에 따라 쉽게 조정할 수 있도록 작게 설계되었습니다. 즐겁게 사용하세요!

[NixOS]: https://nixos.org/
[Nix Flakes]: https://wiki.nixos.org/wiki/Flakes
[Home Manager]: https://nix-community.github.io/home-manager/
[Stylix]: https://danth.github.io/stylix/
[Hyprland]: https://hyprland.org/



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-30

---