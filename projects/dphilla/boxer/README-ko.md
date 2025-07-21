<translate-content># 복서(Boxer)

<p align="center">
  <p align="center">
    <a href="https://en.wikipedia.org/wiki/Mia_St._John" target="_blank">
      <img src="https://user-images.githubusercontent.com/20820229/164059786-8d082b44-59d6-431a-adf4-993116c8d492.png" alt="Mia St John" width="300"             height="400">
    </a>
  </p>
</p>

**이 프로젝트는 빠르게 개발 중입니다**

# 복서(Boxer)

## 개요
Boxer는 전통적인 컨테이너 기술에서 웹어셈블리(Wasm) 기반 배포판인 "박스(Boxes)" 또는 "Wasm-Boxes"로 전환하여 클라우드 컴퓨팅을 재구성하기 위해 설계된 오픈 소스 프로젝트입니다.

## 동기
컨테이너는 애플리케이션을 위한 격리된 환경을 제공하며 클라우드 컴퓨팅의 핵심이 되었지만, 상당한 단점도 존재합니다. 컨테이너는 종종 더 크고 비효율적인 배포와 느린 시작 시간을 초래하며, 보안을 위해 기본 운영체제/커널에 크게 의존하여 취약점과 플랫폼 종속성을 유발할 수 있습니다.

## 해결책: Boxer
Boxer는 기존 컨테이너화된 작업 부하 및 정의를 거의 보편적으로 배포 가능한 Wasm 배포판으로 변환하는 도구를 제공함으로써 새로운 해결책을 제시합니다. 이 "박스(Boxes)"는 컨테이너가 제공하는 환경과 유사하지만, 웹어셈블리의 경량화된 샌드박스 실행 기능 덕분에 훨씬 더 효율적입니다.

<p align="center">
  <p align="center">
    <a href="https://boxer.dev" target="_blank">
      <img src="https://github.com/dphilla/wasm-vfs/assets/20820229/4b0309d8-c8ae-427a-8af3-67857a8eebf3" alt="Container and Box" width="400"             height="400">
    </a>
  </p>
</p>


### 웹어셈블리의 주요 장점:
- **오버헤드 감소:** Wasm의 압축된 이진 명령어 형식은 경량 실행을 보장하여 전통적인 컨테이너에서 발생하는 오버헤드를 크게 줄입니다.
- **향상된 성능:** Wasm의 효율성은 성능 개선과 더 작고 효율적인 배포를 가능하게 하여 클라우드 컴퓨팅에 완벽히 적합합니다.
- **우수한 보안:** Wasm의 메모리 안전하고 격리된 실행 환경은 운영체제와 독립적으로 더 높은 수준의 보안을 제공합니다.
- **거의 모든 곳에서 실행 가능:** Wasm은 웹어셈블리 런타임이 있는 곳이라면 어디서든 실행할 수 있으며, 브라우저, 서버, 임베디드 장치를 포함합니다; 다양한 아키텍처에서 기존 런타임을 이용할 수 있습니다. [광범위한 아키텍처](https://github.com/appcypher/awesome-wasm-runtimes)

## 예제

### Dockerfile ➡ (Wasm)Box

다음 파일에 대해:

```Dockerfile
FROM scratch
RUN mkdir -p /app
COPY a.out /app
WORKDIR /app
CMD ["/app/a.out"]
```
run  `box build -f Dockerfile`

이 명령은 libc 인터페이스를 (임포트로서) 가져오고 필요한 파일 시스템 상태를 생성하여, 선언적으로 실행 준비가 된 Wasm 바이너리를 만듭니다.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---