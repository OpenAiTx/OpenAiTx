# Containerization

Containerization 패키지는 애플리케이션이 리눅스 컨테이너를 사용할 수 있게 합니다.  
Containerization은 [Swift](https://www.swift.org)로 작성되었으며 Apple 실리콘에서 [Virtualization.framework](https://developer.apple.com/documentation/virtualization)를 사용합니다.

Containerization은 다음 API를 제공합니다:

- [OCI 이미지 관리](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationOCI/).
- [원격 레지스트리와 상호작용](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationOCI/Client/).
- [ext4 파일 시스템 생성 및 채우기](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationEXT4/).
- [Netlink 소켓 패밀리와 상호작용](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationNetlink/).
- [빠른 부팅 시간을 위한 최적화된 리눅스 커널 생성](https://raw.githubusercontent.com/apple/containerization/main/kernel/).
- [경량 가상 머신 생성 및 런타임 환경 관리](https://raw.githubusercontent.com/apple/containerization/main/Sources/Containerization/LinuxContainer.swift).
- [컨테이너화된 프로세스 생성 및 상호작용](https://raw.githubusercontent.com/apple/containerization/main/Sources/Containerization/LinuxProcess.swift).
- Apple 실리콘에서 linux/amd64 컨테이너를 실행하기 위한 Rosetta 2 사용.

Containerization이 제공하는 Swift 패키지에 대한 정보는 [API 문서](https://apple.github.io/containerization/documentation/)를 참조하십시오.

## 설계

Containerization은 각 리눅스 컨테이너를 자체 경량 가상 머신 내에서 실행합니다.  
클라이언트는 각 컨테이너에 전용 IP 주소를 생성할 수 있어 개별 포트 포워딩이 필요 없습니다.  
컨테이너는 최적화된 [리눅스 커널 구성](https://raw.githubusercontent.com/apple/containerization/main/kernel)과 경량 init 시스템이 포함된 최소 루트 파일 시스템을 사용하여 1초 미만의 시작 시간을 달성합니다.

[vminitd](https://raw.githubusercontent.com/apple/containerization/main/vminitd)는 Containerization 내의 하위 프로젝트인 작은 init 시스템입니다.  
`vminitd`는 가상 머신 내에서 초기 프로세스로 생성되며 vsock을 통한 GRPC API를 제공합니다.  
이 API를 통해 런타임 환경을 구성하고 컨테이너화된 프로세스를 실행할 수 있습니다.  
`vminitd`는 프로세스 실행 시 호출 프로세스에 I/O, 신호 및 이벤트를 제공합니다.

## 요구 사항

Containerization을 빌드하고 실행하려면 Apple 실리콘 Mac이 필요합니다.

Containerization 패키지를 빌드하려면 시스템에 다음 중 하나가 있어야 합니다:

- macOS 15 이상 및 Xcode 26 베타
- macOS 26 베타 이상

패키지를 사용해 빌드된 애플리케이션은 macOS 15 이상에서 실행되지만, macOS 15에서는 다음 기능이 제공되지 않습니다:

- 비격리 컨테이너 네트워킹 - macOS 15에서는 동일 vmnet 네트워크 내 컨테이너끼리 통신할 수 없습니다.

## 사용 예시

라이브러리 사용법 예시는 cctl 실행 파일이 좋은 출발점입니다.  
이 도구는 API를 시험해 볼 수 있는 플레이그라운드 역할을 하며, 다양한 제품의 핵심 기능을 실행하는 명령어를 포함합니다:

1. [OCI 이미지 조작](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/ImageCommand.swift)
2. [컨테이너 레지스트리 로그인](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/LoginCommand.swift)
3. [루트 파일 시스템 블록 생성](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/RootfsCommand.swift)
4. [간단한 리눅스 컨테이너 실행](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/RunCommand.swift)

## 리눅스 커널

macOS에서 경량 가상 머신을 생성하려면 리눅스 커널이 필요합니다.  
Containerization은 [kernel](https://raw.githubusercontent.com/apple/containerization/main/kernel) 디렉터리에 최적화된 커널 구성을 제공합니다.

이 디렉터리는 Containerization과 함께 사용할 커널을 쉽게 컴파일할 수 있는 컨테이너화된 빌드 환경을 포함합니다.

커널 구성은 빠른 시작 시간과 경량 환경을 지원하기 위한 최소 기능 세트입니다.

대부분의 작업 부하에 적합하지만, 일부는 추가 기능이 필요할 수 있음을 이해합니다.  
이를 해결하기 위해 Containerization은 컨테이너별로 다양한 커널 구성 및 버전을 사용할 수 있는 1급 API를 제공합니다.  
이를 통해 컨테이너는 다양한 커널 버전에서 개발 및 검증될 수 있습니다.

최적화된 커널 컴파일 방법은 kernel 디렉터리 내 [README](https://raw.githubusercontent.com/apple/containerization/main/kernel/README.md)를 참고하십시오.

### 사전 빌드 커널

사전 빌드된 커널을 사용하려면 `VIRTIO` 드라이버가 모듈이 아닌 커널에 컴파일되어 있어야 합니다.

[Kata Containers](https://github.com/kata-containers/kata-containers) 프로젝트는 모든 필요한 구성 옵션이 활성화된 컨테이너용 최적화된 커널을 [릴리스](https://github.com/kata-containers/kata-containers/releases/) 페이지에서 제공합니다.

커널 이미지인 `vmlinux.container`는 릴리스 아티팩트의 `/opt/kata/share/kata-containers/` 디렉터리에서 찾을 수 있습니다.

## 패키지 빌드 준비

Swiftly, [Swift](https://www.swift.org), 및 [Static Linux SDK](https://www.swift.org/documentation/articles/static-linux-getting-started.html)를 설치합니다:

```bash
make cross-prep
```

커스텀 터미널 애플리케이션을 사용하는 경우, 이 명령을 `.zprofile`에서 `.zshrc`로 옮겨야 할 수도 있습니다 (`<USERNAME>` 대체):

```bash
# Added by swiftly
. "/Users/<USERNAME>/.swiftly/env.sh"
```

터미널 애플리케이션을 재시작하십시오. 다음 명령이 `/Users/<USERNAME>/.swiftly/bin/swift`를 반환하는지 확인하세요 (`<USERNAME>` 대체):

```bash
which swift
```

이전에 Static Linux SDK를 설치하거나 사용했다면, 시스템에서 이전 SDK 버전을 제거해야 할 수도 있습니다 (`<SDK-ID>` 대체):

```bash
swift sdk list
swift sdk remove <SDK-ID>
```

## 패키지 빌드

소스에서 Containerization 빌드:

```bash
make all
```

## 패키지 테스트

빌드 후 기본 테스트와 통합 테스트를 실행:

```bash
make test integration
```

통합 테스트를 실행하려면 커널이 필요합니다.  
로컬에 커널이 없으면 `make fetch-default-kernel` 타겟으로 기본 커널을 가져올 수 있습니다.

기본 커널은 초기 빌드 후 또는 `make clean` 후에만 가져오면 됩니다.

```bash
make fetch-default-kernel
make all test integration
```

## 프로토버프

Containerization은 특정 버전의 `grpc-swift` 및 `swift-protobuf`에 의존합니다.  
다음 명령으로 설치하고 RPC 인터페이스를 재생성할 수 있습니다:

```bash
make protos
```

## 문서화

로컬에서 API 문서를 생성하려면:

```bash
make docs
make serve-docs
```

다른 터미널에서 다음 명령어로 문서를 미리 보기:

```bash
open http://localhost:8000/documentation/
```

## 기여

Containerization에 대한 기여는 환영하며 권장됩니다. 자세한 내용은 [CONTRIBUTING.md](https://raw.githubusercontent.com/apple/containerization/main/CONTRIBUTING.md)를 참고하십시오.

## 프로젝트 상태

버전 0.1.0은 Containerization의 첫 공식 릴리스입니다. 이전 버전은 소스 안정성을 보장하지 않습니다.

Containerization 라이브러리는 활발히 개발 중이므로, 소스 안정성은 마이너 버전 내에서만 보장됩니다(예: 0.1.1과 0.1.2 사이).  
잠재적으로 소스 호환이 깨지는 패키지 업데이트를 원하지 않는 경우, 패키지 의존성을 `.upToNextMinorVersion(from: "0.1.0")`로 지정할 수 있습니다.

패키지의 향후 마이너 버전은 필요에 따라 이러한 규칙을 변경할 수 있습니다.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---