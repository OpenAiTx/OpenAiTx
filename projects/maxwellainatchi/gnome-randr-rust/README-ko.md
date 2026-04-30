# gnome-randr-rust

Wayland에서 Gnome용 `xrandr`의 재구현으로, 특히 `wlr-output-management-unstable-v1`를 지원하지 않는 시스템(e.g. Manjaro)을 위해 설계되었습니다. 성능과 재미를 위해 Rust로 처음부터 작성되었습니다. 이것은 저의 첫 Rust 프로젝트이기도 하니, 어떤 제안이라도 환영합니다!

> [!NOTE]  
> 현재 작동하는 리눅스 머신에 접근할 수 없어 유지보수를 할 수 없습니다. 유지보수에 관심 있는 분이 있으면 알려주세요!
>
> Gnome 48+에서는 기본 제공되는 [gdctl](https://gitlab.gnome.org/GNOME/mutter/-/blob/main/doc/man/gdctl.rst) CLI를 사용해 보세요. 이 도구가 가장 최신 상태로 유지될 가능성이 높습니다.

(비-Gnome 컴포지터의 경우, https://arewewaylandyet.com/ 에서 디스플레이 구성 링크를 참조하세요.)

## 설치

설치에는 Rust 툴체인의 일부인 `pkg-config`와 `cargo`가 필요합니다. [Cargo/Rust 설치 안내](https://doc.rust-lang.org/cargo/getting-started/installation.html).

이 도구를 설치하려면 `cargo install gnome-randr`를 실행하세요. 다른 Rust 프로그램에서 사용할 수 있도록 라이브러리도 공개되어 있습니다.

## 방법

`gnome-randr-rust`는 `dbus` 객체 `org.gnome.Mutter.DisplayConfig`를 사용합니다. 원래 제안서는 https://wiki.gnome.org/Initiatives/Wayland/Gaps/DisplayConfig 를 참고하세요. 다만, 거기에 나와 있는 명세는 다소 오래된 상태입니다(Gnome shell 40.5에서 `dbus introspect`로 확인). Gnome은 진화하는 XML 파일을 [여기](https://gitlab.gnome.org/GNOME/mutter/-/blob/main/data/dbus-interfaces/org.gnome.Mutter.DisplayConfig.xml)에서 관리합니다.

`GetCurrentState` 메서드는 디스플레이 정보를 나열하는 데 사용되고, `ApplyMonitorsConfig`는 현재 구성을 수정하는 데 사용됩니다.

## 영감

이 프로젝트는 `xrandr`(당연히)와 [`gnome-randr`](https://gitlab.com/Oschowa/gnome-randr/)에서 많은 영감을 받았습니다. 안타깝게도 `gnome-randr.py`는 제 Gnome 버전(40.5)에서는 디스플레이 구성을 수정하려 할 때 작동하지 않는 것으로 보입니다.

`gnome-randr.py`는 또한 제 Rust 재구현보다 느립니다: 제 3모니터 시스템에서 파이썬 스크립트 쿼리는 약 30ms가 걸리지만, Rust 구현은 약 3ms가 걸립니다(`xrandr`는 약 1.5ms가 걸리지만, `xrandr` 브리지의 한계로 인해 다른 정보를 표시합니다).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-30

---