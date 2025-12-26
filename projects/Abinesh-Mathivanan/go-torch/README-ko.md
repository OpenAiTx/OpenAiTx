# go-torch 

go-torch는 순수 Go로 처음부터 구축된 오픈 소스 딥러닝 프레임워크입니다. 안정적인 자동 미분 엔진과 함께 신경망을 구축하고 훈련하기 위한 모듈형 PyTorch 유사 API를 제공합니다.

mail - abineshmathivanan31@gmail.com 

blog - https://abinesh-mathivanan.vercel.app/en/posts/post-5/


## features 
- **동적 계산 그래프**: 텐서가 그들의 이력을 추적하여 역전파 시 자동으로 그래디언트를 계산할 수 있습니다.
- 확장 가능한 모듈 시스템 (nn.Layer, nn.Sequential): 유연한 Keras 스타일 순차 API로 복잡한 모델 아키텍처를 구축할 수 있습니다. 
- 레이어 및 함수 라이브러리: Conv2D, Linear, MaxPooling2D, Flatten, ReLU, CrossEntropyLoss, 그리고 SGD 포함
- **실시간 TUI 대시보드**: 배치별 손실과 에폭별 검증 정확도의 실시간 그래프, 메모리 사용량(Heap/Total Alloc), GC 사이클, 활성 고루틴 모니터링 및 Keras 스타일 요약 제공.
- 최적화된 성능: BLAS, 고루틴, 위상 자동미분 + 그래디언트 누적 사용

<br/>

**TUI Dashboard**

![alt text](https://raw.githubusercontent.com/Abinesh-Mathivanan/go-torch/main/dashboard.png)


<br>

## TODO
- [ ] RNN, LSTM, 트랜스포머 지원 추가
- [ ] Ga-lore 및 LORA 기법, RMSProp 등을 포함한 Adam 구현
- [ ] gob 없이 model.load() 및 model.save() 기능 구현
- [ ] 트랜스포머 구축 지원

<br/>

## pre-requisites 
- Go 1.18 이상.
- 최고 성능을 위해 시스템에 설치된 BLAS 라이브러리 권장하지만 필수는 아님.
- 일부 TODO는 파일 내에 작성되어 있습니다. 최고의 경험을 위해 'better comments' 확장 프로그램 사용 권장. 

<br/>

## 사용법 

### 저장소 복제하기
```bash
git clone https://github.com/abinesh-mathivanan/go-torch.git
cd go-torch
``` 
### 종속성 설치
``` bash
go mod tidy
```
### 실행  
기능을 테스트하기 위해 mnist 학습 파일을 실행합니다.  

```bash
go run ./cnn_benchmark/go_bench.go
```
<br>

## 벤치마크

| 벤치마크 세부사항                      | 128x128      | 512x512     | 1024x1024    |
|:------------------------------------------|:-------------|:------------|:-------------|
| **행렬 곱셈**                          | 510.33 µs    | 13.54 ms    | 130.50 ms    |
| 요소별 덧셈                            | 71.72 µs     | 1.29 ms     | 4.13 ms      |
| 요소별 곱셈                            | 47.83 µs     | 1.63 ms     | 3.91 ms      |
| ReLU 활성화                           | 121.18 µs    | 1.75 ms     | 6.45 ms      |
| **선형 계층 순전파 (B32,I128,O10)**     | 71.93 µs     |             |              |
| **교차 엔트로피 손실 (B32,C10)**       | 11.16 µs     |             |              |
| **전체 순전파-역전파 (Net:128-256-10, B32)** | 4.02 ms      |             |              |


<br>
<br>

[![별 히스토리 차트](https://api.star-history.com/svg?repos=Abinesh-Mathivanan/go-torch&type=Date)](https://www.star-history.com/#Abinesh-Mathivanan/go-torch&Date)




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-26

---