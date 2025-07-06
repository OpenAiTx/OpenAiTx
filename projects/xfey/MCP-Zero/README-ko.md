## MCP-Zero: 자율 LLM 에이전트를 위한 능동형 툴 탐색

<div style="display: flex; align-items: center; gap: 10px; margin-bottom: 10px;">
  <!-- <img src="https://raw.githubusercontent.com/xfey/MCP-Zero/master/assets/robot.png" alt="MCP-Zero Robot" width="24" height="24"> -->
  <a href="https://arxiv.org/abs/2506.01056">
    <img src="https://img.shields.io/badge/Paper-arXiv-red">
  </a>
  <a href="https://arxiv.org/abs/2506.01056">
    https://arxiv.org/abs/2506.01056
  </a>
</div>


MCP-Zero에 관심을 가져주셔서 감사합니다! 🤗

현재 논문에 사용된 코드를 오픈소스화하였습니다. 앞으로도 지속적으로 연구를 업데이트하고, 산업계 적용을 탐색하며, 프로젝트를 확장해 나갈 예정입니다.


<div align="center">
  <img src="https://raw.githubusercontent.com/xfey/MCP-Zero/master/assets/fig1.png" alt="MCP-Zero workflow">
  <p> MCP-Zero를 활용하여 "훌륭한 식사 만들기"를 위한 툴체인을 능동적으로 구축하는 모습 </p>
</div>


### 방법: MCP-Zero

```
MCP-zero/
├── experiment_apibank.py       # 실험: APIBank
├── experiment_mcptools.py      # 실험: mcp_tools (needle test)
├── matcher.py                  # 유사도 매칭 코드
├── prompt_guide/               # 본 방법에 사용된 프롬프트
├── reformatter.py              # 툴 설명용 json 포매터
├── sampler.py                  # 대상 툴 선택 샘플러
├── test_cases.jsonl            # 매처용 테스트 케이스
├── test_matcher.py             # 매처 단위 테스트
└── utils.py                    # 유틸: grid_search
```

현재 논문에 사용된 코드를 공개하였습니다. 논문의 코드는 검색 기능을 구현하였으며, 실험에서 구체적인 결과를 달성하였습니다.

향후 작업에서는 MCP-zero를 산업계에 적용하는 것을 목표로 하며, 이를 위해 MCP 서버의 동적 배포, GAIA 테스트를 위한 환경 배포 등 추가 모듈이 필요합니다. 앞으로도 연구를 발전시켜나갈 예정이니 많은 관심 부탁드립니다. 별(star)🌟을 남겨주시면 소식을 받아보실 수 있습니다 :D



### 데이터셋: MCP-tools

- **Google Drive**: [다운로드 링크](https://drive.google.com/file/d/1RjBGU-AGdHdhUABoeYSztbfQlD0hjUBn/view?usp=sharing)
- **Huggingface 링크**: 곧 공개 예정
- **파일 위치**: `./MCP-tools/mcp_tools_with_embedding.json`


**소개**: MCP 공식 저장소에서 필터링된 모든 툴(총 308개 서버, 2,797개 툴)이 포함된 데이터셋입니다.

**데이터 구조**:
```
{
  "server_name": string, // MCP 서버 이름, README에서 추출 또는 유추
  "server_summary": string, // 서버 목적 및 기능 요약, README의 관련 부분 기반
  "server_description": string, // 메타데이터의 설명
  "description_embedding": float[3072], // text-embedding-3-large로 생성한 서버 설명 임베딩
  "summary_embedding": float[3072], // text-embedding-3-large로 생성한 서버 요약 임베딩
  "tools": [
    {
      "name": string, // 함수/툴 이름
      "description": string, // 툴의 기능에 대한 간결한 설명
      "description_embedding": float[3072], // 툴 설명의 text-embedding-3-large 임베딩
      "parameter": { // 입력 파라미터 딕셔너리, 명시적으로 정의된 경우 포함
        "param1": "(type) description1",
        "param2": "(Optional, type) description2"
      }
    }
  ]
}
```

**직접 데이터셋 구축하기**: MCP 서버에 대한 커스텀 데이터셋을 만들고자 한다면, `MCP-tools/build_data` 폴더 내 코드를 참고하실 수 있습니다.

```
MCP-tools/
├── build_data
│   ├── get_server_summary.py       # MCP 서버의 ReadMe 파일에서 구조화 데이터 추출 코드
│   ├── run_vllm.sh                 # Qwen2.5-72B-Instruct 모델을 VLLM으로 배포
│   └── server_summary.prompt       # 데이터셋 추출용 프롬프트
└── download_data.md
```


### 인용

> 인용해주시면 행복합니다.
>
>   --셰익스피어
>   ~~(장난입니다 :D)~~

```bibtex
@article{fei2025mcp,
  title={MCP-Zero: Active Tool Discovery for Autonomous LLM Agents},
  author={Fei, Xiang and Zheng, Xiawu and Feng, Hao},
  journal={arXiv preprint arXiv:2506.01056},
```
  year={2025}
}
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-06

---