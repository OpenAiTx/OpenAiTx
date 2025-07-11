# 🎫 BiliTickerStorm


## ⚙️ 서비스 설명

| 서비스명               | 설명                    | 비고         |
| ------------------ | ------------------- | --------- |
| `ticket-master`    | 메인 컨트롤 서비스, 작업 스케줄 담당 | 단일 인스턴스 배포 |
| `ticket-worker`    | 티켓 예매 워커, 수평 확장 가능      | 다중 인스턴스 지원 |
| `gt-python`        | 이미지 캡차 처리 서비스           | 단일 인스턴스 배포 |

---

## 🚀 빠른 배포 단계

> 클러스터 구축은 [클러스터 구축 가이드](https://raw.githubusercontent.com/mikumifa/biliTickerStorm/main/docs/集群搭建参考.md)를 참고하세요.

<details> <summary><strong>📦 원격 저장소 설치(추천)</strong></summary>

```bash
helm repo add bili-ticker-storm https://mikumifa.github.io/biliTickerStorm/
helm repo update
```
### 2. Chart 설치

```bash
helm install bili-ticker-storm bili-ticker-storm/bili-ticker-storm \
  --set ticketMaster.hostDataPath=/your/host/data/path \
  --set ticketWorker.pushplusToken="your_token" \
  --set ticketWorker.ticketInterval="300" \
  --set ticketWorker.ticketTimeStart="2025-05-20T13:14"
  
```

> - `hostDataPath`는 티켓 예매 설정 파일 디렉토리로, `ticket-master` 컨테이너에 마운트됩니다. 예매 설정 파일 생성은 https://github.com/mikumifa/biliTickerBuy 를 참고하세요.
> - `ticketWorker.pushplusToken`은 plusplus 푸시 알림 설정입니다. 설정 시 예매 결과 알림을 받을 수 있습니다.
> - `ticketWorker.ticketInterval`은 예매 요청 간격(초 단위)로, 기본값은 300밀리초입니다.
> - `ticketWorker.ticketTimeStart`는 예약 시작 시간으로, 형식은 `2025-05-20T13:14`입니다. 입력하지 않으면 컨테이너가 시작되자마자 바로 예매를 시작합니다.

### 3. Chart 업그레이드

```bash
helm upgrade bili-ticker-storm bili-ticker-storm/bili-ticker-storm --reuse-values \
  --set ticketWorker.ticketInterval="600"
```
</details> 
<details> <summary><strong>📦 로컬 Chart 설치</strong></summary>


### 1. Chart 설치

```bash
# 저장소 클론
git clone https://github.com/mikumifa/biliTickerStorm
# 로컬 Chart 패키지 사용
helm install bili-ticker-storm ./helm \
  --set ticketMaster.hostDataPath=/your/host/data/path \
  --set ticketWorker.pushplusToken="your_token" \
  --set ticketWorker.ticketInterval="300" \
  --set ticketWorker.ticketTimeStart="2025-05-20T13:14"
```
### 2. Chart 업그레이드

```bash
helm upgrade bili-ticker-storm ./helm --reuse-values
```
</details>
<details>
<summary><strong>📌 일반 명령어</strong></summary>

### ⏹ 제거
```bash
helm uninstall bili-ticker-storm
```
</details>


## 📩 면책 조항

본 프로젝트는 MIT License 라이선스 규정을 따르며, 개인적인 학습 및 연구 목적으로만 사용됩니다. 본 프로젝트를 어떠한 상업적 이익 활동에 사용하지 말아 주시고, 어떠한 형태의 대리 구매, 불법 행위 또는 관련 플랫폼 규칙을 위반하는 용도로 사용하는 것을 엄금합니다. 이로 인해 발생하는 모든 결과는 사용자 본인에게 책임이 있으며, 본인과는 무관합니다.

본 프로젝트를 fork하거나 사용할 경우 반드시 관련 법률 및 규정과 대상 플랫폼의 규칙을 준수해 주시기 바랍니다.

## 💡 접근 빈도 및 동시성 제어에 대하여
본 프로젝트는 설계 시 「비침투성」 원칙을 엄격히 준수하여, 대상 서버(예: Bilibili)에 어떠한 방해도 주지 않도록 하였습니다.

모든 네트워크 요청의 시간 간격은 사용자가 직접 설정할 수 있으며, 기본값은 일반 사용자의 수동 조작 속도를 모방합니다. 프로그램은 기본적으로 단일 스레드로 실행되며, 동시 작업이 없습니다. 요청 실패 시 프로그램은 제한된 횟수로 재시도하며, 재시도 사이에는 적절한 지연을 추가하여 고빈도 요청을 피합니다. 본 프로젝트는 오로지 플랫폼의 공개 API 및 웹 구조에만 의존하며, 리스크 회피, API 탈취 등 파괴적인 수단을 포함하지 않습니다.
## 🛡️ 플랫폼 존중 성명

본 프로그램은 설계 시 요청 빈도를 최대한 통제하여 Bilibili 서버에 어떠한 명백한 부하나 영향을 주지 않도록 하였습니다. 본 프로젝트는 학습 목적에만 사용되며, 대규모 또는 고동시 처리 능력을 갖추지 않았고, 어떠한 악의적 행위나 서비스 방해 의도도 없습니다.

만약 본 프로젝트에 Bilibili 회사의 합법적 권익을 침해하는 내용이 있을 경우, 이메일 [1055069518@qq.com](https://raw.githubusercontent.com/mikumifa/biliTickerStorm/main/mailto:1055069518@qq.com)로 연락해 주시기 바랍니다. 관련 내용을 즉시 내리고 본 저장소를 삭제하겠습니다. 이로 인해 불편을 드린 점 깊이 사과드리며, 너그러운 이해와 포용에 감사드립니다.

## 📄 라이선스

[MIT 라이선스](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-11

---