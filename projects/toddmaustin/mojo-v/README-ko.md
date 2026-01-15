<p align="center">
  <img src="https://raw.githubusercontent.com/toddmaustin/mojo-v/main/./docs/MojoV-logo1.png" alt="Mojo-V 로고" width="550"/>
</p>

# Mojo-V: RISC-V를 위한 비밀 연산

**Mojo-V** (발음: *“모조-파이브”*)는 RISC-V에 프라이버시 지향 프로그래밍 기능을 도입하는 새로운 RISC-V 확장입니다. Mojo-V는 비밀 연산을 구현하여, 취약한 소프트웨어나 프로그래머의 신뢰에 의존하지 않고 안전하고 효율적이며 데이터에 무관한 실행을 가능하게 합니다. 민감한 데이터를 전용 비밀 레지스터에 격리하고 제3자 키로 메모리를 암호화함으로써, Mojo-V는 정보 누출을 방지하고 직접적인 노출이 없는 블라인드(Blind) 연산과 부채널 누출이 없는 사일런트(Silent) 연산을 강제합니다. 설계는 모드 비트 하나와 네 개의 새로운 명령어만을 추가하여 기존 RISC-V ISA에 원활하게 통합되며, 완전히 디코드 단계에서 강제됩니다. 초기 결과는 거의 네이티브 실행 속도를 보여주며, 완전 동형 암호(FHE) 대비 5~7자리 이상의 성능 향상을 제공하며, CPU, GPU 및 특수 가속기 통합을 위한 명확한 로드맵을 제시합니다.

더 알아보기...
- Mojo-V를 설명하는 소개 영상: https://www.youtube.com/watch?v=HUT46TcNyyM
- Mojo-V 프로젝트 개요를 담은 슬라이드: https://drive.google.com/file/d/1VVzZqYHvQgnKMgXZjg7I_cX2GzF7awSN

현재 Mojo-V ISA 확장 사양 (버전 0.92):
- [PDF 형식.] (https://drive.google.com/file/d/1pargKATFoQdy94i6bI3P_9mfNA_GsYSw)

Mojo-V 개발자 연락처:
- 이메일: [mojov-devs@umich.edu](https://raw.githubusercontent.com/toddmaustin/mojo-v/main/mailto:mojov-devs@umich.edu)

# 🧩 Mojo-V 참조 플랫폼 — 버전 0.92

## 🚧 프로젝트 현황

Mojo-V 참조 플랫폼 버전 0.92는 고정 대칭 키 암호를 사용한 비밀 정수 및 부동소수점 연산을 구현합니다. Mojo-V는 빠름, 강력함, 증명 전달(proof-carrying)의 세 가지 암호화 모드를 지원합니다. 이번 버전에서는 64비트 비밀 연산이 완전히 비밀화되었으며, 이 초기 참조 플랫폼은 소프트웨어 개발 및 레드팀 테스트에 사용할 수 있습니다. 앞으로의 버전에서는 PKI 지원, LLVM 컴파일러 지원, 32비트 RISC-V 지원, VIP-Bench 벤치마크 지원 등 추가 기능이 제공될 예정입니다.

**사양 버전:** 0.92  (2025년 11월)  
**연락처:** [mojov-devs@umich.edu](https://raw.githubusercontent.com/toddmaustin/mojo-v/main/mailto:mojov-devs@umich.edu)

## 현재 구성 요소

1. **Mojo-V ISA 사양 v0.92**
   - `doc/`에 배포됨
2. **Spike (명령어 집합 시뮬레이터) 구현**
   - Mojo-V가 `riscv-isa-sim`에 통합되어 거의 완성 단계
   - 미지원 항목: 공개키 인프라(PKI) 지원 (현재 Simon-128 암호를 사용하는 고정 키 사용)
   - Mojo-V 확장 활성화 상태로 Spike 실행 시 `spike` 명령어에 `--isa=rv64gc_zicond_zkmojov_zicntr` 플래그 추가
3. **Mojo-V Bringup-Bench 벤치마크**
   - 수작업으로 코딩된 예제들(예: 버블 정렬)로 Mojo-V 비밀 연산 동작 시연
   - RV64GC+Mojo-V용 보안 테스트 전체 배터리

참고로 Bringup-bench 벤치마크의 나머지 부분은 아직 Mojo-V로 이식되지 않았습니다.
## ⚙️ Mojo-V 참조 플랫폼 빌드 및 실행

### A. RISC-V LLVM 컴파일러 설치
`RV64GC` 바이너리를 생성할 수 있는 LLVM 기반 RISC-V 크로스 컴파일러가 필요합니다.

시작하기 좋은 곳: https://clang.llvm.org/get_started.html

### B. Mojo-V 저장소 복제

```bash
git clone https://github.com/toddmaustin/mojo-v.git
cd mojo-v
```
### C. Mojo-V 지원을 포함한 RISC-V Spike 시뮬레이터 빌드하기

```bash
sudo apt-get install device-tree-compiler libboost-regex-dev libboost-system-dev
cd riscv-isa-sim
mkdir build
cd build
../configure --prefix=$RISCV
make
```

### D. Mojo-V 브링업 벤치마크 테스트 빌드 및 실행

1. **Spike 디바이스 드라이버 빌드**

   ```bash
   cd bringup-bench/target
   make
   ```
2. **컴파일러 구성하기**

   `../Makefile`을 편집하여 `mojov` 대상의 `TARGET_CC`를 LVM Clang 기반 RISC-V 컴파일러 위치로 설정합니다.

3. **빌드 및 테스트**


   ```bash
   cd ..                # go to the top-level bringup-bench directory
   make mojov-tests     # run all Mojo-V tests
   ```
대안으로, 해당 디렉터리로 이동하여 다음 명령어를 실행하여 개별 벤치마크를 수행할 수 있습니다.


   ```bash
   cd ../mojov-test
   make TARGET=mojov clean build test
   ```
## 🧪 Mojo-V Bringup-Bench 벤치마크 개요

| 프로그램 | 설명 |
|:---------|:-------------|
| `mojov-test` | 슬라이드에서 소개된 예제 |
| `mojov-test1` | 시크릿 레지스터 및 암호화 메모리 의미론 테스트 |
| `mojov-test2` | Mojo-V 빠른 암호화(int,fast)를 사용한 수작업 데이터 불투명 정수 버블 정렬 벤치마크 |
| `mojov-test3` | Mojo-V 빠른 암호화(fp,fast)를 사용한 수작업 데이터 불투명 부동 소수점 버블 정렬 벤치마크 |
| `mojov-test4` | Mojo-V 강력한 암호화(int,strong)를 사용한 수작업 데이터 불투명 정수 버블 정렬 벤치마크 |
| `mojov-test5` | Mojo-V 강력한 암호화(fp,strong)를 사용한 수작업 데이터 불투명 부동 소수점 버블 정렬 벤치마크 |
| `mojov-pctests` | Mojo-V의 증명 운반 암호화 형식(proofcarrying)에 대한 긍정 및 부정 테스트를 포함하는 RV64GC+Mojo-V용 수작업 무결성 검사 테스트 스위트 |
| `mojov-sectests` | 130개의 긍정 테스트와 245개의 부정 테스트 총 375개(int,fp,fast,strong)를 포함하는 RV64GC+Mojo-V용 수작업 보안 테스트 스위트 |

모든 테스트 벤치마크는 Mojo-V ISA 규칙과 보안 의미론을 보여주는 수작업 어셈블리 프로그램입니다. 다른 Bringup-Bench 벤치마크들은 아직 Mojo-V로 포팅되지 않았습니다.

---
## 코드 라이선스
이 저장소의 모든 Mojo-V 관련 코드는 수정된 도구(예: Spike, LLVM, Bringup-Bench)의 라이선스 하에 공개됩니다. 라이선스 세부사항은 각 도구의 해당 디렉터리를 참조하십시오.

---

## 💬 질문 및 피드백
기여, 버그 리포트 및 제안을 환영합니다!

📧 **이메일:** [mojov-devs@umich.edu](https://raw.githubusercontent.com/toddmaustin/mojo-v/main/mailto:mojov-devs@umich.edu)  
🌐 **프로젝트 홈:** [https://github.com/toddmaustin/mojo-v](https://github.com/toddmaustin/mojo-v)




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-15

---