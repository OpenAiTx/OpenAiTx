# Eric Lee의 도트파일

![Neovim 설정](https://raw.githubusercontent.com/ericlovesmath/dotfiles/master/./imgs/desktop.png)

- MacOS와 Fedora를 위한 이중 구성
- 개인 [Neovim](https://github.com/neovim/neovim) 설정
- `zsh`와 함께 사용하는 [Alacritty](https://github.com/alacritty/alacritty)

## 설치 (MacOS)

- 개요: [yabai](https://github.com/koekeishiya/yabai) + [skhd](https://github.com/koekeishiya/skhd) + [karabiner-elements](https://karabiner-elements.pqrs.org/)

    - 도트파일은 심볼릭 링크되어 있으며 [nix-darwin](github.com/LnL7/nix-darwin)과 home-manager로 애플리케이션 설치
    - Yabai: 타일링 윈도우 매니저는 Capslock을 `meh/hyper` 글로벌 접두사로 사용하여 vim 키 바인딩을 모방
    - Neovim: `Lazy`로 패키지 설치, `Mason`으로 LSP 설치
    - Alacritty: 직관적인 `cmd + _` 키 조합이 `tmux`와 작동하도록 키 바인딩 설정

- [Nix](https://github.com/DeterminateSystems/nix-installer): 주로 선언적 패키지 관리자 및 심볼릭 링크 도구로 사용

    - Nix가 옵션이 아닌 경우, 심볼릭 링크 내용을 보려면 `home-darwin.nix`와 `brew.nix` 파일 참고
- [Nix] 설치

```bash
mkdir ~/dotfiles & cd ~/dotfiles
git clone https://github.com/ericlovesmath/dotfiles.git ~/dotfiles
nix run nix-darwin -- switch --flake "$HOME/dotfiles\#macos"
```

## 설치 (Fedora, Sway 및 Hyprland)

`INSTALLATION_GUIDE.md`를 참조하세요, AMD Framework 13 노트북에서 테스트됨


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-01

---