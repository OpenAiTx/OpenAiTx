# 이더리움 스테이킹 가이드 #

## 소개 ##

환영합니다!

이더리움 네트워크에서 스테이킹의 **골드 스탠다드**인 솔로 스테이커가 되고 싶다면, 이 가이드가 도움이 될 것입니다!

필요한 사양은 Ubuntu (22.04 LTS 이상) 운영체제를 실행하는 머신이며, 최신 CPU, 16GB RAM (32GB가 더 좋음), 고품질 2TB SSD (4TB가 더 좋음)가 필요합니다.

시작하려면 아래의 [**메인넷 스테이킹 가이드**](https://github.com/SomerEsat/ethereum-staking-guides#mainnet-staking-guides) 중 하나를 참조하세요.

어떤 클라이언트를 사용할지 잘 모를 경우, 가장 낮은 점유율을 가진 클라이언트를 선택하세요. 여기에서 확인할 수 있습니다: https://clientdiversity.org. 아래 가이드들은 주요 **컨센서스 클라이언트**(Lighthouse, Lodestar, Prysm, Nimbus, Teku) 이름을 따서 작성되었으므로 먼저 하나를 선택해야 합니다. 각 가이드는 스테이킹에 필요한 **실행 클라이언트** 설치 지침도 포함하고 있습니다. 마찬가지로 가장 낮은 점유율을 가진 실행 클라이언트를 선택하는 것이 권장됩니다.

마지막으로, 메인넷에서 검증자 활동을 시작하려면 대기열이 있을 수 있으니 확인하세요: https://validator-queue-monitoring.vercel.app.

Somer Esat

<br/>

## 메인넷 스테이킹 가이드 ##

이 가이드는 이더리움 메인넷에서 스테이킹할 때 사용합니다.

| 가이드 <img width=150/> | 변경 로그 *(dd-mm-yy)* <img width=450/> |
| :--------- | :---------- |
| [Lighthouse](https://someresat.medium.com/guide-to-staking-on-ethereum-ubuntu-lighthouse-773f5d982e03) | <br> *20-08-24* - Reth 실행 클라이언트 추가. <br> *18-08-24* - Lighthouse 클라이언트를 5.3.0으로 업데이트. <br> *19-06-24* - Lighthouse 클라이언트를 5.2.0으로 업데이트. <br> *18-06-24* - Besu 클라이언트를 24.5.4로 업데이트. <br> *09-06-24* - Nethermind 설정에 가지치기(Pruning) 플래그 추가. <br> *09-06-24* - Nethermind 설정에서 Sync.AncientBodies/Receipts 플래그 제거. <br> *09-06-24* - Nethermind 클라이언트를 1.26.0으로 업데이트. <br> *09-06-24* - Geth 클라이언트를 1.14.5로 업데이트. <br> *09-06-24* - Erigon 클라이언트를 2.6.1로 업데이트. <br> *02-06-24* - Erigon 클라이언트를 2.6.0으로 업데이트. <br> *02-06-24* - [이슈 13](https://github.com/SomerEsat/ethereum-staking-guides/issues/13)에 따라 Erigon의 사용 중단된 설정 플래그 --externalcl 제거. <br> *02-06-24* - Erigon 설정을 사전 빌드된 바이너리 사용으로 업데이트. <br> *02-06-24* - 불필요한 Erigon 필수 항목 제거. <br> *30-05-24* - Besu 클라이언트를 24.5.2로 업데이트하고 Besu 설정 플래그 섹션의 깨진 링크 수정. <br> *30-05-24* - [#6405](https://github.com/hyperledger/besu/pull/6405)에 따라 Besu 설정에서 X_SNAP을 SNAP으로 이름 변경. <br> *30-05-24* - Besu 필수 항목을 Java Runtime v21 (헤드리스) 필요로 업데이트. <br> *14-04-24* - 목차 추가. <br> *14-04-24* - Ubuntu 서버 버전을 22.04로 상향 조정. <br> 변경 로그 아카이브 보기: [Change Log Archive](https://github.com/SomerEsat/ethereum-staking-guides/blob/master/ChangeLogArchive.md). |
| [Lodestar](https://someresat.medium.com/guide-to-staking-on-ethereum-ubuntu-lodestar-193a2553a161) | <br> *20-08-24* - Reth 실행 클라이언트 추가. <br> *11-08-24* - Lodestar 릴리스 링크 오류 수정. <br> *18-06-24* - Lodestar 불필요한 필수 항목(NodeJS 및 build-essential) 제거. <br> *18-06-24* - Lodestar 설정을 사전 빌드된 바이너리 사용으로 업데이트. <br> *18-06-24* - Lodestar 클라이언트를 1.19.0으로 업데이트. <br> *18-06-24* - Besu 클라이언트를 24.5.4로 업데이트. <br> *18-06-24* - Nethermind 설정에 가지치기 플래그 추가. <br> *18-06-24* - Nethermind 설정에서 Sync.AncientBodies/Receipts 플래그 제거. <br> *18-06-24* - Nethermind 클라이언트를 1.26.0으로 업데이트. <br> *18-06-24* - Geth 클라이언트를 1.14.5로 업데이트. <br> *18-06-24* - Erigon 클라이언트를 2.6.1로 업데이트. <br> *02-06-24* - Erigon 클라이언트를 2.6.0으로 업데이트. <br> *02-06-24* - [이슈 13](https://github.com/SomerEsat/ethereum-staking-guides/issues/13)에 따라 Erigon의 사용 중단된 설정 플래그 --externalcl 제거. <br> *02-06-24* - Erigon 설정을 사전 빌드된 바이너리 사용으로 업데이트. <br> *02-06-24* - 불필요한 Erigon 필수 항목 제거. <br> *30-05-24* - Besu 클라이언트를 24.5.2로 업데이트하고 Besu 설정 플래그 섹션의 깨진 링크 수정. <br> *30-05-24* - [#6405](https://github.com/hyperledger/besu/pull/6405)에 따라 Besu 설정에서 X_SNAP을 SNAP으로 이름 변경. <br> *30-05-24* - Besu 필수 항목을 Java Runtime v21 (헤드리스) 필요로 업데이트. <br> *27-04-24* - 목차 추가. <br> *27-04-24* - Ubuntu 서버 버전을 22.04로 상향 조정. <br> 변경 로그 아카이브 보기: [Change Log Archive](https://github.com/SomerEsat/ethereum-staking-guides/blob/master/ChangeLogArchive.md). |
| [Prysm](https://someresat.medium.com/guide-to-staking-on-ethereum-ubuntu-prysm-581fb1969460) | <br> *20-08-24* - Reth 실행 클라이언트 추가. <br> *24-06-24* - Prysm 클라이언트를 5.0.4로 업데이트. <br> *19-06-24* - Prysm 클라이언트를 5.0.3으로 업데이트. <br> *18-06-24* - Besu 클라이언트를 24.5.4로 업데이트. <br> *18-06-24* - Nethermind 설정에 가지치기 플래그 추가. <br> *18-06-24* - Nethermind 설정에서 Sync.AncientBodies/Receipts 플래그 제거. <br> *18-06-24* - Nethermind 클라이언트를 1.26.0으로 업데이트. <br> *18-06-24* - Geth 클라이언트를 1.14.5로 업데이트. <br> *18-06-24* - Erigon 클라이언트를 2.6.1로 업데이트. <br> *02-06-24* - Erigon 클라이언트를 2.6.0으로 업데이트. <br> *02-06-24* - [이슈 13](https://github.com/SomerEsat/ethereum-staking-guides/issues/13)에 따라 Erigon의 사용 중단된 설정 플래그 --externalcl 제거. <br> *02-06-24* - Erigon 설정을 사전 빌드된 바이너리 사용으로 업데이트. <br> *02-06-24* - 불필요한 Erigon 필수 항목 제거. <br> *30-05-24* - Besu 클라이언트를 24.5.2로 업데이트하고 Besu 설정 플래그 섹션의 깨진 링크 수정. <br> *30-05-24* - [#6405](https://github.com/hyperledger/besu/pull/6405)에 따라 Besu 설정에서 X_SNAP을 SNAP으로 이름 변경. <br> *30-05-24* - Besu 필수 항목을 Java Runtime v21 (헤드리스) 필요로 업데이트. <br> *27-04-24* - 목차 추가. <br> *27-04-24* - Ubuntu 서버 버전을 22.04로 상향 조정. <br> 변경 로그 아카이브 보기: [Change Log Archive](https://github.com/SomerEsat/ethereum-staking-guides/blob/master/ChangeLogArchive.md). |
| [Nimbus](https://someresat.medium.com/guide-to-staking-on-ethereum-ubuntu-nimbus-31f56657ea8f) | <br> *20-08-24* - Reth 실행 클라이언트 추가. <br> *24-06-24* - Nimbus 클라이언트를 24.6.0으로 업데이트. <br> *19-06-24* - Nimbus 클라이언트를 24.5.0으로 업데이트. <br> *18-06-24* - Besu 클라이언트를 24.5.4로 업데이트. <br> *18-06-24* - Nethermind 설정에 가지치기 플래그 추가. <br> *18-06-24* - Nethermind 설정에서 Sync.AncientBodies/Receipts 플래그 제거. <br> *18-06-24* - Nethermind 클라이언트를 1.26.0으로 업데이트. <br> *18-06-24* - Geth 클라이언트를 1.14.5로 업데이트. <br> *18-06-24* - Erigon 클라이언트를 2.6.1로 업데이트. <br> *02-06-24* - Erigon 클라이언트를 2.6.0으로 업데이트. <br> *02-06-24* - [이슈 13](https://github.com/SomerEsat/ethereum-staking-guides/issues/13)에 따라 Erigon의 사용 중단된 설정 플래그 --externalcl 제거. <br> *02-06-24* - Erigon 설정을 사전 빌드된 바이너리 사용으로 업데이트. <br> *02-06-24* - 불필요한 Erigon 필수 항목 제거. <br> *30-05-24* - Besu 클라이언트를 24.5.2로 업데이트하고 Besu 설정 플래그 섹션의 깨진 링크 수정. <br> *30-05-24* - [#6405](https://github.com/hyperledger/besu/pull/6405)에 따라 Besu 설정에서 X_SNAP을 SNAP으로 이름 변경. <br> *30-05-24* - Besu 필수 항목을 Java Runtime v21 (헤드리스) 필요로 업데이트. <br> *27-04-24* - 목차 추가. <br> *27-04-24* - Ubuntu 서버 버전을 22.04로 상향 조정. <br> 변경 로그 아카이브 보기: [Change Log Archive](https://github.com/SomerEsat/ethereum-staking-guides/blob/master/ChangeLogArchive.md). |
| [Teku](https://someresat.medium.com/guide-to-staking-on-ethereum-ubuntu-teku-f09ecd9ef2ee) | <br> *20-08-24* - Reth 실행 클라이언트 추가. <br> *19-06-24* - Teku 필수 항목을 Java Runtime v21 (헤드리스) 필요로 업데이트. <br> *19-06-24* - Teku 클라이언트를 24.6.0으로 업데이트. <br> *18-06-24* - Besu 클라이언트를 24.5.4로 업데이트. <br> *18-06-24* - Nethermind 설정에 가지치기 플래그 추가. <br> *18-06-24* - Nethermind 설정에서 Sync.AncientBodies/Receipts 플래그 제거. <br> *18-06-24* - Nethermind 클라이언트를 1.26.0으로 업데이트. <br> *18-06-24* - Geth 클라이언트를 1.14.5로 업데이트. <br> *18-06-24* - Erigon 클라이언트를 2.6.1로 업데이트. <br> *02-06-24* - Erigon 클라이언트를 2.6.0으로 업데이트. <br> *02-06-24* - [이슈 13](https://github.com/SomerEsat/ethereum-staking-guides/issues/13)에 따라 Erigon의 사용 중단된 설정 플래그 --externalcl 제거. <br> *02-06-24* - Erigon 설정을 사전 빌드된 바이너리 사용으로 업데이트. <br> *02-06-24* - 불필요한 Erigon 필수 항목 제거. <br> *30-05-24* - Besu 클라이언트를 24.5.2로 업데이트하고 Besu 설정 플래그 섹션의 깨진 링크 수정. <br> *30-05-24* - [#6405](https://github.com/hyperledger/besu/pull/6405)에 따라 Besu 설정에서 X_SNAP을 SNAP으로 이름 변경. <br> *30-05-24* - Besu 필수 항목을 Java Runtime v21 (헤드리스) 필요로 업데이트. <br> *18-05-24* - 목차 추가. <br> *18-05-24* - Ubuntu 서버 버전을 22.04로 상향 조정. <br> 변경 로그 아카이브 보기: [Change Log Archive](https://github.com/SomerEsat/ethereum-staking-guides/blob/master/ChangeLogArchive.md). |

<br/>

## 출금 자격 증명 업데이트 가이드 ##

스테이커는 이 가이드를 사용하여 검증자의 출금 자격 증명을 0x00에서 0x01로 업데이트할 수 있습니다.

| 가이드 | 변경 로그 *(dd-mm-yy)* <img width=450/> |
| :--------- | :---------- |
| [이더리움에서 출금 자격 증명 설정 가이드](https://someresat.medium.com/guide-to-configuring-withdrawal-credentials-on-ethereum-812dce3193a) | <br> *14-04-24* - 목차 추가. <br> *12-11-23* - 여러 깨진 링크 수정. <br> *16-04-23* - 오타 수정 및 제출 및 방송 전 추가 경고 문구 삽입. <br> *13-04-23* - 가독성 향상을 위한 다양한 업데이트. <br> *12-04-23* - 예시 Beaconcha.in 제출 성공 메시지 추가. <br> *11-04-23* - 공개. |

<br/>

## 기부 감사드립니다 ##

Somer.eth (0x32B74B90407309F6637245292cd90347DE658A37)

<br/>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-23

---