<a href="https://buymeacoffee.com/koromix" target="_blank"><img src="https://cdn.buymeacoffee.com/buttons/default-orange.png" alt="Buy Me A Coffee" height="41" width="174"></a>

# 개요

Koffi는 Node.js용 빠르고 사용하기 쉬운 C FFI 모듈로, 다음과 같은 특징을 갖추고 있습니다:

* 낮은 오버헤드와 빠른 성능 ([벤치마크](https://koffi.dev/benchmarks) 참고)
* 원시 및 집합 데이터 타입(구조체 및 고정 크기 배열)을 참조(포인터) 및 값으로 지원
* 자바스크립트 함수는 C 콜백으로 사용 가능(1.2.0부터)
* 인기 있는 OS/아키텍처 조합에 대해 잘 테스트된 코드베이스

현재 __공식적으로 지원 및 테스트된__ OS와 아키텍처 조합은 다음과 같습니다:

ISA / OS           | Windows     | Linux    | macOS       | FreeBSD     | OpenBSD
------------------ | ----------- | -------- | ----------- | ----------- | --------
x86 (IA32) [^1]    | ✅ 예       | ✅ 예   | ⬜️ *해당 없음* | ✅ 예       | ✅ 예
x86_64 (AMD64)     | ✅ 예       | ✅ 예   | ✅ 예       | ✅ 예       | ✅ 예
ARM32 LE [^2]      | ⬜️ *해당 없음* | ✅ 예   | ⬜️ *해당 없음* | 🟨 아마도  | 🟨 아마도
ARM64 (AArch64) LE | ✅ 예       | ✅ 예   | ✅ 예       | ✅ 예       | 🟨 아마도
RISC-V 64 [^3]     | ⬜️ *해당 없음* | ✅ 예   | ⬜️ *해당 없음* | 🟨 아마도  | 🟨 아마도

[^1]: 다음 호출 규약을 지원합니다: cdecl, stdcall, MS fastcall, thiscall.
[^2]: 사전 빌드된 바이너리는 하드 플로트 ABI를 사용하며 VFP 코프로세서를 요구합니다. 다른 ABI(softfp, soft)를 사용하려면 소스에서 빌드하십시오.
[^3]: 사전 빌드된 바이너리는 LP64D(배정밀도 부동소수점) ABI를 사용합니다. LP64 ABI는 이론적으로 소스에서 빌드하면 지원되나 테스트되지 않았습니다. LP64F ABI는 지원하지 않습니다.

자세한 정보는 다음 링크를 참고하세요:

- 문서: https://koffi.dev/
- 변경 로그: https://koffi.dev/changelog
- 소스 코드: https://codeberg.org/Koromix/rygel/ (아래 설명 참조)

# 소스 코드

이 저장소는 Koffi 코드 자체를 포함하지 않고 프론트 역할만 합니다. 실용적인 이유로, 2018년부터 모든 프로젝트를 한 저장소에서 관리하는 방식을 사용하기 시작했습니다. 관리가 더 용이하기 때문입니다.

소스 코드는 여기에서 확인할 수 있습니다: https://codeberg.org/Koromix/rygel/ (*src/koffi* 하위 디렉터리).

모노레포지토리는 저에게 두 가지 강력한 기능을 제공합니다:

* 프로젝트 간 리팩토링
* 간소화된 의존성 관리

더 자세한 이유는 여기에서 확인할 수 있습니다: https://danluu.com/monorepo/

# 수동 빌드

Koffi는 CNoke라는 맞춤형 CMake 래퍼로 빌드되며, 이 래퍼 또한 모노레포지토리에 포함되어 있습니다. CMake를 직접 실행하려고 하면 실패하니 시도하지 마십시오.

[Koffi를 소스에서 빌드하는 문서화된 지침](https://koffi.dev/contribute#build-from-source)을 따라 빌드하십시오.

# 라이선스

이 프로그램은 자유 소프트웨어입니다: **MIT 라이선스** 조건에 따라 재배포 및 수정할 수 있습니다.

자세한 정보는 여기에서 확인하세요: https://choosealicense.com/licenses/mit/


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-21

---