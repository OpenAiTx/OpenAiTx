# RISC-V 벡터 벤치마크

개발자가 이식 가능하고 성능이 뛰어난 RVV 코드를 작성할 수 있도록 돕는 RISC-V 벡터(RVV) 벤치마크 모음입니다.

벤치마크 결과는 다음에서 확인할 수 있습니다: https://camel-cdr.github.io/rvv-bench-results

## 벤치마크 ([./bench/](./bench/))

특정 알고리즘의 다양한 구현에 대한 여러 벤치마크를 포함합니다.

## 명령어 사이클 수 ([./instructions/](./instructions/))

주어진 명령어를 반복해서 풀고 루프를 돌며 RVV 명령어의 사이클 수를 측정합니다.

## 시작하기

먼저 [./config.mk](https://raw.githubusercontent.com/camel-cdr/rvv-bench/main/./config.mk)를 구성하여 `make`가 작동하도록 하고 선택적으로 [./run.sh](https://raw.githubusercontent.com/camel-cdr/rvv-bench/main/./run.sh)를 구성하면 `make run`으로 컴파일 및 실행할 수 있습니다.

기본 구성은 최신 clang 빌드 모두에서 작동하며, 완전한 크로스 컴파일 툴체인이 필요 없는데, freestanding 모드로 빌드하기 때문입니다.
즉, Linux 또는 Linux 시스템 콜 호환 OS에서만 작동합니다.

최신 Linux 버전에서는 성능 카운터가 기본적으로 노출되지 않으므로, `echo 2 >/proc/sys/kernel/perf_user_access`를 실행해야 할 수 있으며, [./config.mk](https://raw.githubusercontent.com/camel-cdr/rvv-bench/main/./config.mk)의 `CFLAGS=...` 줄에 `-DUSE_PERF_EVENT`를 추가해야 합니다 (만약 작동하지 않으면 `-DUSE_PERF_EVENT_SLOW`를 대신 시도하세요).

[./config.mk](https://raw.githubusercontent.com/camel-cdr/rvv-bench/main/./config.mk)를 호스티드 빌드로 설정하거나 사용자 맞춤 툴체인으로 구성할 수 있으며, `-DCUSTOM_HOST` 정의를 추가하고, [./nolibc.h](https://raw.githubusercontent.com/camel-cdr/rvv-bench/main/./nolibc.h)의 `#ifdef CUSTOM_HOST` 아래 미구현 함수를 구현하면 됩니다.

XTheadVector는 더 이상 지원되지 않습니다.

### 벤치마크 실행 ([./bench/](./bench/))

벤치마크를 실행하려면 먼저 ([./bench/config.h](https://raw.githubusercontent.com/camel-cdr/rvv-bench/main/./bench/config.h))를 열어 프로세서에 맞게 조정하세요(예: `HAS_E64` 설정). 실행 시간이 너무 길면 벤치마크 스케일 조정에 사용되는 `MAX_MEM` 값을 낮추고, 다른 상수들도 조절하여 적당한 시간 내에 실행되고 상대적으로 부드러운 그래프가 나오도록 하세요.

이제 ([./bench/](./bench/)) 디렉터리에서 `make run`으로 벤치마크를 실행하거나, 실행 파일만 빌드하려면 `make`를 실행하면 됩니다.

### 사이클 수 측정 ([./instructions/](./instructions/))

사이클 수 측정을 실행하려면 먼저 [instructions/rvv/config.h](https://raw.githubusercontent.com/camel-cdr/rvv-bench/main/instructions/rvv/config.h)를 프로세서에 맞게 구성하세요.

그 다음 ([./instructions/rvv/](./instructions/rvv/)) 디렉터리에서 `make run`으로 측정을 실행하거나, 실행 파일만 빌드하려면 `make`를 실행하면 됩니다.

XTheadVector의 경우 ([./instructions/xtheadvector/](./instructions/xtheadvector/)) 디렉터리를 대신 사용하세요. (더 이상 유지 관리되지 않습니다)
## Contributing

다음은 아직 완료해야 할 작업들에 대한 제안입니다.

* 새로운 CPU 측정을 다음에 기여하세요: https://github.com/camel-cdr/rvv-bench-results \
  단일 json 파일을 포함하는 이슈를 생성하면 됩니다. 이 파일은 모든 결합된 [./bench/](./bench/) 결과를 포함합니다. (적절한 설정 후, `make run > out.json` 명령어가 효과적입니다). \
* 메모리 바운드가 아닌 벤치마크 구현
* 더 많은 벤치마크 구현
* 더 나은 사이클 수 측정: 처리량 대 대기 시간 (또한: 실행 포트 구성을 파악할 수 있을까요?)
* 로드/스토어에 대한 사이클 수
* vsetvl에 대한 사이클 수

## License

이 저장소는 MIT [LICENSE](LICENSE) 하에 라이선스가 부여됩니다.




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-30

---