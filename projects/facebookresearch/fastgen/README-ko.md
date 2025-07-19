<translate-content># Fastgen

**조밀한 트랜스포머로부터의 고처리량 추론.**

Fastgen은 다음과 같은 최첨단 기법을 갖춘 LLM 추론 라이브러리입니다: 배치 추론, cuda 그래프, 페이징 어텐션, 청크드 프리필, 호스트 측 kv-캐시, 텐서 병렬화, CPU/GPU 프로파일링.

이는 RL 루프나 합성 데이터 생성 파이프라인과 같은 더 큰 시스템에 쉽게 임포트할 수 있는 미니 (~3kloc) vLLM으로 볼 수 있습니다.

다음 HuggingFace 모델들이 지원되는 것으로 알려져 있습니다: Llama 3.1 8B, Mistral 7B, Ministral 8B, R1-Llama 8B 및 70B, R1-Qwen 14B, Qwen2.5 7B 및 14B; 더 많은 모델도 작동할 수 있습니다.

## 벤치마크

|                       | Fastgen      | vLLM (0.8.4) |
| --------------------- | ------------ | -----------  |
| Mistral 7B / 1x H100  | 3430 toks/s  | 3390 toks/s  |
| Qwen2.5 14B / 1x H100 | 1700 toks/s  | 1700 toks/s  |
| Llama 70B / 8x H100   | 2260 toks/s  | 2230 toks/s  |

이 표에 제시된 처리량은 `fgserve` (아래 참조)와 `vllm serve`를 사용하여 1024 토큰의 512 프롬프트에 대해 128 디코딩 스텝 부하로 수집되었습니다. 아래 그림은 Mistral 7B 모델에 대해 다양한 생성 부하에서의 더 상세한 결과를 보여줍니다.

![Mistral 7B Benchmark](https://raw.githubusercontent.com/facebookresearch/fastgen/main/scripts/data/mistral7-perf.png)

> [!NOTE]
> `fgserve`에 대해 테스트를 실행할 때 짧은 프롬프트에서 성능 저하가 관찰될 수 있습니다. 이 낮은 성능은 최적화되지 않은 스레드 HTTP 서비스 코드 때문이며 Fastgen이 작은 (비효율적인) 배치에서 실행되도록 만듭니다. Fastgen을 사용하는 프로덕션 애플리케이션은 프로세스 기반 병렬화를 채택해야 합니다.

## 데모 도구

이 라이브러리는 `fgchat`과 `fgserve` 두 가지 도구를 제공합니다. 첫 번째 도구는 커맨드라인 채팅을 구현한 기본 데모이며, 두 번째 도구는 최소한의 OpenAI 채팅 API를 제공합니다.

### fgchat



















```
$ # on an RTX A5000
$ # accelerate inference with '--tensor-parallel N' if you have N GPUs
$ fgchat mistralai/Mistral-7B-Instruct-v0.3  
loading: 100%|███████████████████████▉| 14.5G/14.5G [00:00<00:00, 75.9GB/s]
Ready to chat!
  Available commands:
    /r <N> -- reset conversation before round N
    /m     -- input a multiline message, end your input
              with a single line containing '.'
    /q     -- quit

---
1> hello
Hello! How can I help you today? [...]
--- [33 tokens, 26.554toks/s]
2> can you give me some makeup advice?
Of course! Here are some general makeup tips that might be helpful:

[...]
--- [489 tokens, 34.715toks/s]
3> /q
```
### fgserve


```
$ fgserve mistralai/Mistral-7B-Instruct-v0.3  
...
$ cat test.py
from openai import OpenAI
client = OpenAI(base_url="http://localhost:5678", api_key="foo")

completion = client.chat.completions.create(
    model="gpt-4o-mini",
    messages=[
        {"role": "system", "content": "You are a helpful assistant."},
    ] + [
        {
            "role": "user",
            "content": "Write a haiku about recursion in programming."
        }
    ]
)
print(completion.choices[0].message.content)

$ python test.py
Code dives within,
Echoes of self repeat,
Solving the unseen.
```
## 감사의 글

감사의 말씀:
- Fastgen에서 활용된 대부분의 혁신(페이징된 어텐션,
  청크 프리필 등)에 영감을 준 [vLLM 프로젝트](https://github.com/vllm-project/vllm).
- Daniel Haziza ([@danthe3rd](https://github.com/danthe3rd))에게
  초기 설계 논의와 높은 GPU 활용도 달성에 대한 지속적인 조언에 감사드립니다.

## 라이선스

Fastgen은 LICENSE 파일에 명시된 BSD 3-Clause 라이선스를 따릅니다.





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---