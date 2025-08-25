# BPCells

BPCells는 대규모 RNA-seq 및 ATAC-seq 데이터셋의 고성능 단일 세포 분석을 위한 패키지입니다.  
1.3M 세포 데이터셋의 정규화 및 PCA를 2GB RAM으로 4분 내에 실행할 수 있으며, ArchR 또는 SnapATAC2보다 50배 적은 CPU 시간으로 조각 좌표에서 scATAC-seq 피크 행렬을 생성할 수 있습니다.  
BPCells는 전체 CELLxGENE 인구 조사 인간 데이터셋도 처리할 수 있으며, 44M 세포 x 60k 유전자 행렬에 대해 노트북에서 6시간, 서버에서는 1시간 미만으로 고정밀 PCA를 실행합니다. 자세한 내용은 [벤치마크 페이지](https://bnprks.github.io/BPCells/articles/web-only/benchmarks.html)를 참조하세요.

BPCells가 제공하는 기능:

  - 비트패킹 압축을 통한 단일 세포 데이터셋의 효율적 저장  
  - C++ 기반의 빠르고 디스크 지원 RNA-seq 및 ATAC-seq 데이터 처리  
  - 마커 유전자 및 클러스터링과 같은 후속 분석  
  - AnnData, 10x 데이터셋, R 희소 행렬, GRanges와의 상호 운용성  
  - 노트북에서 44M 세포까지 확장 가능성 입증  

또한, BPCells는 최적화된 데이터 처리 인프라를 노출하여 3자 단일 세포 도구(예: Seurat)의 확장에 활용할 수 있습니다.

## [웹사이트에서 자세히 알아보기](https://bnprks.github.io/BPCells/)

- [BioRxiv 사전출판](https://www.biorxiv.org/content/10.1101/2025.03.27.645853v1)  
- [Python 문서](https://bnprks.github.io/BPCells/python/index.html)  
- [벤치마크](https://bnprks.github.io/BPCells/articles/web-only/benchmarks.html)  
- [다중오믹스 분석 예제](https://bnprks.github.io/BPCells/articles/pbmc3k.html)  
- [BPCells 작동 원리](https://bnprks.github.io/BPCells/articles/web-only/how-it-works.html)  
- [추가 문서](https://bnprks.github.io/BPCells/articles/index.html)  
- [함수 문서](https://bnprks.github.io/BPCells/reference/index.html)  
- [뉴스](https://bnprks.github.io/BPCells/news/index.html)

## R 설치  
BPCells를 github에서 직접 설치하는 것을 권장합니다:

```R
remotes::install_github("bnprks/BPCells/r")
```
설치 전에, 시스템에 HDF5 라이브러리가 설치되어 있고 접근 가능해야 합니다.  
HDF5는 선택한 패키지 관리자를 통해 설치할 수 있습니다. 아래 운영 체제별 지침을 참조하세요.  

Mac 및 Windows 사용자가 github에서 설치하는 데 문제가 있는 경우, 사전 빌드된 바이너리 패키지 설치 지침은 [R-universe](https://bnprks.r-universe.dev/BPCells) 페이지를 확인하세요. 이 바이너리 패키지는 자동으로 최신 github 메인 브랜치를 추적합니다.  

BPCells는 Conda Forge R 팀의 [@mfansler](https://github.com/mfansler) 덕분에 conda를 통해 제공됩니다 (자세한 내용은 [이슈 #241](https://github.com/bnprks/BPCells/issues/241) 참조).  
bioconda 패키지 관련 문제는 [bioconda-recipes](https://github.com/bioconda/bioconda-recipes/)에 보고해야 합니다. 버전 업데이트는 bioconda 팀에서 관리합니다.  

<details>  
<summary>github 기반 설치에 대한 운영 체제별 설치 정보 보기</summary>  
<div>  

### Linux  
Linux에서 HDF5 의존성 확보는 보통 매우 간단합니다.  

- apt: `sudo apt-get install libhdf5-dev`  
- yum: `sudo yum install hdf5-devel`  
- conda: `conda install -c conda-forge hdf5`  
  - 참고: Linux 사용자는 가능하면 배포판의 패키지 관리자(e.g. `apt` 또는 `yum`)를 선호하는 것이 좋으며,  
    이는 좀 더 안정적인 설치 경험을 제공하는 것으로 보입니다.  

### Windows  
Windows에서 소스에서 R 패키지를 컴파일하려면 [Windows용 R 도구](https://cran.r-project.org/bin/windows/Rtools/)를 설치해야 합니다. 자세한 논의는 [이슈 #9](https://github.com/bnprks/BPCells/issues/9) 참조.  

### MacOS  
MacOS의 경우 homebrew를 통한 HDF5 설치가 가장 신뢰할 만합니다: `brew install hdf5`.  

**Mac 전용 문제 해결**:  

- **ARM CPU를 탑재한 Mac**: 흔한 오류는 ARM 기반 HDF5 설치와 x86 기반  
  R 설치가 혼합되는 것입니다. 이는 BPCells가 설치 중 HDF5에 접근할 때 오류를 일으킵니다.  
    - `sessionInfo()`를 실행하여 R 설치가 ARM인지 x86인지 "Platform"에서 확인하세요.  
    - 가장 쉬운 방법은 ARM R을 사용하는 것입니다. homebrew는 기본적으로 ARM hdf5 설치를 제공합니다.  
    - x86 버전의 hdf5에 접근하려면 x86 homebrew를 설치하는 것이 [가능합니다](https://codetinkering.com/switch-homebrew-arm-x86/) (단, 다소 까다롭습니다).  
- **구형 Mac(10.14 Mojave 또는 이전 버전)**: 구형 Mac의 기본 컴파일러는 필요한  
  C++17 파일 시스템 기능을 지원하지 않습니다. 자세한 내용은 [이슈 #3](https://github.com/bnprks/BPCells/issues/3#issuecomment-1375238635) 참조.




  홈브루를 통해 최신 컴파일러를 설정하는 팁.

### 지원되는 컴파일러
대부분의 경우, 이미 적절한 컴파일러가 설치되어 있을 것입니다. BPCells는
gcc >=9.1 또는 clang >= 9.0을 권장합니다.
이는 2018년 말 이후 버전에 해당합니다.
기본적인 C++17 지원이 있다면 구버전도 일부 경우에 작동할 수 있지만,
공식적으로 지원되지는 않습니다.

</div>
</details>
<details>
<summary>GitHub 기반 설치 문제 해결 정보는 여기를 클릭하세요</summary>

### 일반 설치 문제 해결
BPCells는 컴파일 중 문제 진단에 도움이 되는 유용한 오류 메시지를 출력하려고 합니다. 보다
자세한 정보를 원한다면, `remotes::install_github("bnprks/BPCells/r")` 실행 전에 `Sys.setenv(BPCELLS_DEBUG_INSTALL="true")`를 실행하세요. 추가 정보로도 문제를 해결하지 못하면, 자세한 설치 로그를 [접을 수 있는 섹션](https://docs.github.com/en/get-started/writing-on-github/working-with-advanced-formatting/organizing-information-with-collapsed-sections)으로 작성하여 Github 이슈를 등록해 주세요.

</details>

## 파이썬 설치

BPCells는 pip를 통해 직접 설치할 수 있습니다:


```shell
python -m pip install bpcells
```
## 기여하기
BPCells는 오픈 소스 프로젝트이며, 품질 좋은 기여를 환영합니다. 만약
기여에 관심이 있고 C++와 함께 Python 또는 R 경험이 있다면,
직접 구현하고 싶은 아이디어가 있으면 언제든지 연락해 주세요.
시간이 허락하는 한 시작하는 방법에 대한 조언을 기꺼이 제공해 드립니다.

C++에 익숙하지 않다면 코드를 기여하는 것이 어려울 수 있지만,
[재현 가능한 예제](https://reprex.tidyverse.org/articles/reprex-dos-and-donts.html)를
포함한 자세한 버그 리포트는 여전히 큰 도움이 됩니다.
Github 이슈가 이를 위한 최적의 포럼입니다.

단일 세포 분석 패키지를 유지 관리하며 BPCells를 사용해
확장성을 향상시키고 싶다면 조언을 기꺼이 제공하겠습니다.
지금까지 몇몇 연구실에서 시도해 보았으며, 유망한 성공을 거두고 있습니다.
연락은 이메일이 가장 좋습니다(연락처 정보는 github의 `DESCRIPTION` 파일을 참조하세요).
Python 개발자도 환영하며, 현재 Python 패키지는 아직 실험 단계입니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-25

---