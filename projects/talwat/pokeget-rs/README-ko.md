# pokeget-rs

pokeget의 더 나은 러스트 버전입니다.

## 사용법

`pokeget <pokemon>`

자세한 정보는 `pokeget --help`를 실행하세요.

## 프로젝트 상태

버그 수정 등은 계속하겠지만,
심각한 문제가 아닌 한 더 이상 스프라이트가 추가되거나 수정되지 않습니다.
첫째로, 포켓몬이 픽셀 스프라이트에서 벗어나고 있고,
둘째로, pokesprite가 업데이트를 중단했으며
적절한 대안이 발견되지 않았기 때문입니다.

### .bashrc

`.bashrc`와 같이 셸 시작 시 pokeget을 사용한다면,
`pokeget <pokemon>`을 실행하는 대신 출력 결과를 파일로 저장할 수 있습니다:
`pokeget <pokemon> > file.txt`
그리고 bashrc에 `cat file.txt` 같은 명령을 넣으세요.

이렇게 하면 셸 초기화가 거의 즉시 이루어지지만,
무작위 포켓몬에는 당연히 작동하지 않습니다. pokeget은 이미 꽤 빠르므로,
셸 초기화 시 사용하는 것도 큰 병목 현상이 아닙니다.

### 예시

#### 여러 포켓몬 사용하기

`pokeget bulbasaur pikachu random`

#### 도감 번호 사용하기

`pokeget 1 2 3`

#### 대체 형태 사용하기

`pokeget raichu sandslash meowth --alolan`

#### 지역 사용하기

`pokeget kanto`

## 설치

### Cargo *(추천)*

추천 설치 방법은 cargo를 사용하는 것입니다:

```sh
cargo install pokeget
```

and making sure `$HOME/.cargo/bin` is added to `$PATH`.

### AUR

If you're on Arch, you can also use the AUR:

```sh
yay -S pokeget
```

### Git

You can also clone the repository and compile manually by doing:

```sh
git clone --recurse-submodules https://github.com/talwat/pokeget-rs.git
cd pokeget-rs
cargo build --release
mv target/release/pokeget ~/.local/bin
```

그리고 `$HOME/.local/bin`이 `$PATH`에 추가되었는지 확인합니다.

### 디렉토리를 $PATH에 추가하기

#### Bash & Zsh

이 내용을 `.bashrc` 또는 `.zshrc`에 추가하세요:

```sh
export PATH="<path>:$PATH"
```

#### 물고기

CLI에서 다음을 실행하세요:

```sh
fish_add_path <path>
```
## 업데이트

그냥 `cargo install pokeget`를 다시 실행하거나 저장소에서 `git pull`을 한 다음 다시 컴파일하세요.

## 왜?

첫 번째 pokeget은 느리고, 무겁고, 매우 복잡했기 때문에 더 나은 버전을 rust로 만들기로 결정했습니다.

이제 모든 스프라이트를 미리 계산하여 저장소에 업로드하는 대신, pokeget은
필요에 따라 계산할 수 있어 모든 것이 훨씬 유연해졌습니다.
Rust는 파이썬 같은 것보다 훨씬 빠르게 계산할 수 있게 해줍니다.

또한 반 크기 사각형을 사용하여 스프라이트를 2배 더 작게 그립니다.

## 다른 프로젝트는요?

pokeget-rs는 rust로 되어 있어서 이전 pokeget, pokeshell 등과 같은 프로젝트보다 우위에 있습니다.
또한 매우 유사한 다른 프로젝트인 krabby보다 상당히(5.5배) 빠릅니다.

자세한 내용은 [OTHER_PROJECTS.md](https://raw.githubusercontent.com/talwat/pokeget-rs/main/OTHER_PROJECTS.md)를 참조하세요.

## 큰 스프라이트는요?

없어졌습니다. 원자 단위로 축소되었습니다.

진지하게 말하면, 추가 작업량이 많아 다루지 않기로 결정했습니다.
큰 스프라이트는 거의 사용되지 않았고, 작은 터미널 창에서 보기에도 보기 싫었기 때문에
유지할 필요가 거의 없었습니다.

## 크레딧

이번에는 스프라이트가 [pokesprite](https://github.com/msikma/pokesprite)에서 왔으며 pokeget은 git 서브모듈로 사용합니다.

스프라이트는 바이너리에 내장되어 있어 pokeget이 다운로드하지 않습니다. 이는 좋은 타협점으로,
바이너리는 클 수 있지만 pokeget은 거의 즉시 실행되고 오프라인 상태에서도 작동합니다.

## 라이선스

pokeget은 MIT 라이선스를 사용하므로 자유롭게 포크하여 원하는 대로 커스터마이즈할 수 있습니다.

pokeget의 내부 작동 방식에 대해 확실하지 않은 점이 있으면, [이슈를 열어주세요](https://github.com/talwat/pokeget-rs/issues),  
질문하신 모든 내용에 답변해 드리겠습니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-19

---