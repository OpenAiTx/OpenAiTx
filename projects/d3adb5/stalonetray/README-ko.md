# STAnd aLONE TRAY [![Build][badge-build]][yaml-build] [![Lint][badge-lint]][yaml-lint]

[badge-build]: https://github.com/d3adb5/stalonetray/actions/workflows/build.yml/badge.svg
[yaml-build]: https://github.com/d3adb5/stalonetray/actions/workflows/build.yml
[badge-lint]: https://github.com/d3adb5/stalonetray/actions/workflows/lint.yml/badge.svg
[yaml-lint]: https://github.com/d3adb5/stalonetray/actions/workflows/lint.yml

Stalonetray는 X11 윈도잉 시스템을 사용하는 Unix 데스크톱용 STAnd-aLONE 시스템 트레이(알림 영역)입니다.  
최소한의 기본 빌드 및 실행 시간 의존성을 갖추고 있으며: Xlib와 libXinerama가 필요하지만,  
더욱 미니멀하게 사용하려면 후자를 비활성화하여 제거할 수 있습니다. Stalonetray는  
거의 모든 윈도우 매니저에서 실행됩니다.

stalonetray를 사용하려면 `stalonetrayrc.sample`을  
`~/.stalonetrayrc` 또는 `$XDG_CONFIG_HOME/stalonetrayrc`로 복사하세요.  
주석이 잘 달려 있어 빠른 시작에 충분합니다.

일부 기능은 기본적으로 비활성화되어 있으며, 패키지 관리자가 stalonetray를  
어떻게 빌드했는지에 따라 바로 작동하지 않을 수 있습니다. 필요한 기능으로  
직접 컴파일하려면 아래 "소스에서 빌드하기" 섹션을 참조하세요.

## 유지 관리 상태

이 프로젝트는 원래 [Roman Dubtsov (kolbusa)][gh-kolbusa]가 개발했으며  
최근에 소유권이 변경되었습니다. Roman은 여전히 프로젝트에 관여하지만  
더 이상 적극적으로 유지 관리하지는 않습니다.

**이 프로젝트를 수년간 창조하고 유지해 온 모든 공로는 그에게 있습니다. 고마워요, Roman!**

[gh-kolbusa]: https://github.com/kolbusa

## 설치

패키지 관리자는 stalonetray를 설치하는 가장 편리한 방법입니다.  
여러 Linux 배포판과 BSD 변종용으로 패키징되어 있습니다. Debian과  
Ubuntu에서는 다음 명령을 실행하세요:




```sh
sudo apt install stalonetray
```

Fedora에서 실행:

```sh
sudo dnf install stalonetray
```
## 소스에서 빌드하기

Stalonetray는 [Meson](https://mesonbuild.com/)을 사용합니다. 사용 가능한 빌드 옵션과 기본값은 `meson.options` 파일을 참조하십시오.

Meson을 사용하여 stalonetray를 빌드하려면 필요한 종속 항목이 설치되어 있는지 확인하십시오
--- 기본적으로 Xlib 및 libXinerama 개발 패키지만 필요하며 ---
표준 Meson 빌드 명령을 실행합니다:



```sh
meson setup builddir
meson compile -C builddir stalonetray
```

이 명령은 `builddir` 디렉토리에 `stalonetray` 바이너리를 빌드합니다.

stalonetray의 문서를 빌드하려면 먼저 `xsltproc`와 DocBook
스타일시트를 설치해야 합니다. 그런 다음 `manpage` 타겟을 빌드하세요:

```sh
meson compile -C builddir manpage
```

이 명령은 `builddir` 디렉토리에 `stalonetray.1` 파일을 생성합니다.

소스에서 설치는 다음과 같이 할 수 있습니다:

```sh
meson install -C builddir
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-11

---