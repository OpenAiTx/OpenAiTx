![B2DVL Header](https://raw.githubusercontent.com/Thinklab-SJTU/Bench2Drive-VL/main/./assets/Bench2Drive-VL.png)

🚗 **Bench2Drive-VL**은 자율주행에서 비전-언어 모델(VLM)을 위한 클로즈드 루프 풀스택 벤치마크입니다. VQA 부분에서는 룰 기반 전문가 모델 DriveCommenter가 CARLA 시뮬레이터(또는 Bench2Drive 같은 정적 데이터셋)에서 VQA의 정답 생성을 위해 사용됩니다. 원래 Bench2Drive 지표는 계획 벤치마킹에 사용됩니다.

<h2 align="center">
  <a href="https://thinklab-sjtu.github.io/Bench2Drive-VL/"> 문서</a> |
  <a href="https://huggingface.co/datasets/Telkwevr/Bench2Drive-VL-base"> 데이터셋</a>
</h2>

![B2DVL Structure](https://raw.githubusercontent.com/Thinklab-SJTU/Bench2Drive-VL/main/./assets/struct_new.png)

📚 Docker 지원이 곧 제공됩니다...

![B2DVL Modules](https://raw.githubusercontent.com/Thinklab-SJTU/Bench2Drive-VL/main/./assets/modules_new.png)

## 사용 방법

### 환경 설정

1. CARLA 설치:

    ```bash
    mkdir carla
    cd carla
    wget https://carla-releases.s3.us-east-005.backblazeb2.com/Linux/CARLA_0.9.15.tar.gz
    tar -xvf CARLA_0.9.15.tar.gz
    cd Import && wget https://carla-releases.s3.us-east-005.backblazeb2.com/Linux/AdditionalMaps_0.9.15.tar.gz
    cd .. && bash ImportAssets.sh
    export CARLA_ROOT=YOUR_CARLA_PATH
    echo "$CARLA_ROOT/PythonAPI/carla/dist/carla-0.9.15-py3.7-linux-x86_64.egg" >> YOUR_CONDA_PATH/envs/YOUR_CONDA_ENV_NAME/lib/python3.7/site-packages/carla.pth # python 3.8 also works well, please set YOUR_CONDA_PATH and YOUR_CONDA_ENV_NAME
    ```
2. CARLA를 설치한 후, `env.sh`를 작성하십시오:


   ```bash
   export CARLA_ROOT=/path/to/your/carla

   export CARLA_SERVER=${CARLA_ROOT}/CarlaUE4.sh
   export PYTHONPATH=${CARLA_ROOT}/PythonAPI
   export PYTHONPATH=$PYTHONPATH:${CARLA_ROOT}/PythonAPI/carla
   export PYTHONPATH=$PYTHONPATH:$CARLA_ROOT/PythonAPI/carla/dist/carla-0.9.15-py3.7-linux-x86_64.egg

   export WORK_DIR=/path/to/this/repo
   export PYTHONPATH=$PYTHONPATH:${WORK_DIR}/scenario_runner
   export PYTHONPATH=$PYTHONPATH:${WORK_DIR}/leaderboard
   export PYTHONPATH=$PYTHONPATH:${WORK_DIR}/B2DVL_Adapter
   export SCENARIO_RUNNER_ROOT=${WORK_DIR}/scenario_runner
   export LEADERBOARD_ROOT=${WORK_DIR}/leaderboard

   export VQA_GEN=1
   export STRICT_MODE=1
   # DriveCommenter drives back the ego vehicle after circumventing obstacles if STRICT_MODE > 0,
   # must set to true if doing closed-loop eval.
   ```
3. 올바른 환경 변수가 설정되었는지 확인하십시오:


   ```shell
   source ./env.sh
   ```
### 폐쇄 루프 추론

1. vlm 구성 파일을 작성하세요 (예제는 `./vlm_config`에서 찾을 수 있습니다):
   
   *이것은 JSON 파일이므로, 모든 주석을 삭제하는 것을 잊지 마세요!*
   
   *질문 ID는 [문서](https://raw.githubusercontent.com/Thinklab-SJTU/Bench2Drive-VL/main/./docs/qids.md)를 참고하세요.*

   *액션 모듈이 답변을 필요로 하므로 질문 50을 반드시 포함해야 합니다.*


    ```java
    {
        "TASK_CONFIGS": {
            "FRAME_PER_SEC": 10 // sensor saving frequency
        },
        "INFERENCE_BASICS": {
            "INPUT_WINDOW": 1, // frame count of given image input
            "CONVERSATION_WINDOW": 1, // not used anymore, to be removed
            "USE_ALL_CAMERAS": false, // true if use all cameras as input
            "USE_BEV": false, // true if use bev as input
            "NO_HISTORY_MODE": false // do not inherit context of previous VQAs
        },
        "CHAIN": { // for inference
            "NODE": [19, 15, 7, 24, 13, 47, 8, 43, 50],
            "EDGE": { // "pred": succ
                "19": [24, 13, 8],
                "15": [7, 8],
                "7": [8],
                "24": [13, 47],
                "13": [47, 8, 43],
                "47": [8],
                "8": [43],
                "43": [50],
                "50": []
            },
            "INHERIT": { // inherit context from last frame
                "19": [43, 7],
                "15": [7]
            },
            "USE_GT": [24] // questions which use ground truth as answer
        },
        "CONTROL_RATE": 2.0, // intervene freq of vlm
        "MODEL_NAME": "api", // model name
        "MODEL_PATH": "../model_zoo/your_model", // model path
        "GPU_ID": 0, // the gpu model runs on
        "PORT": 7023, // web port
        "IN_CARLA": true,
        "USE_BASE64": true, // if false, local path is used for transmitting images
        "NO_PERC_INFO": false // do not pass extra perception info to vlm via prompt
    }
    ```
2. 시작 스크립트 작성:
   
    *빠른 시작을 원한다면 MINIMAL=1로 설정하여 VLM 없이 Bench2Drive-VL을 실행할 수 있습니다.*


    ```bash
    #!/bin/bash
    BASE_PORT=20082 # CARLA port
    BASE_TM_PORT=50000
    BASE_ROUTES=./leaderboard/data/bench2drive220
    TEAM_AGENT=leaderboard/team_code/data_agent.py
    BASE_CHECKPOINT_ENDPOINT=./my_checkpoint
    SAVE_PATH=./eval_v1/
    GPU_RANK=0 # the gpu carla runs on
    VLM_CONFIG=/path/to/your_vlm_config.json
    PORT=$BASE_PORT
    TM_PORT=$BASE_TM_PORT
    ROUTES="${BASE_ROUTES}.xml"
    CHECKPOINT_ENDPOINT="${BASE_CHECKPOINT_ENDPOINT}.json"
    export MINIMAL=0 # if MINIMAL > 0, DriveCommenter takes control of the ego vehicle,
    # and vlm server is not needed
    bash leaderboard/scripts/run_evaluation.sh $PORT $TM_PORT 1 $ROUTES $TEAM_AGENT "." $CHECKPOINT_ENDPOINT $SAVE_PATH "null" $GPU_RANK $VLM_CONFIG
    ```
3. VLM 서버 시작 (`MINIMAL`인 경우 필요 없음)


    ```shell
    python ./B2DVL_Adapter/web_interact_app.py --config /path/to/your/vlm_config.json
    ```
4. 메인 모듈 시작하기


    ```shell
    bash ./startup.sh
    ```
### DriveCommenter를 사용하여 정적 데이터셋에서 VQA 생성하기

1. `./B2DVL-Adapter` 하위에 시작 스크립트를 작성하세요


    ```bash
    #!/bin/bash
    export SUBSET=0 # generate from a subset of given dataset
    export STRICT_MODE=1
    # DriveCommenter drives back the ego vehicle after circumventing obstacles if STRICT_MODE > 0
    export SUBSET_PATH=./subset_0.txt # subset file
    export PROCESSED_PATH=./processed_paths_0.txt # checkpoint file
    export CACHE_PATH=./.worker_0_cache
    # DriveCommenter supports dataset in .tar.gz
    # it will unzip some of the dataset temporarily in cache dir
    python ./drive_commenter_main.py --data-directory=/path/to/Bench2Drive/dataset --output-graph-directory=./outgraph     --path-maps=${CARLA_ROOT}/CarlaUE4/Content/Carla/Maps     --worker-count=1
    # We do not recommend using multiple worker here since multi-thread in python is not very good.
    # You can run multiple DriveCommenter at the same time with different subset and checkpoint files to do the same.
    ```


2. 실행합니다.


    ```shell
    cd ./B2DVL-Adapter
    bash ./your_startup_script.sh
    ```
### 오픈 루프 추론

1. 설정 파일을 작성합니다.


    ```java
    {
        "TASK_CONFIGS": {
            "INFER_SUBSET": false, // inference a subset of given dataset
            "USE_CHECKPOINT": true, // record the process of inference
            "SUBSET_FILE": "./infer_configs/subset.txt", // subset file, leave blank if not used
            "CHECKPOINT_FILE": "./infer_configs/finished_scenarios.txt", // checkpoint file, leave blank if not used
            "ENTRY_EXIT_FILE": "./infer_configs/entry_exits.json", // the file which specifies entry and exit point of certain scenario, 
            // you can create a file with "{}" as content if do not specify
            "FRAME_PER_SEC": 10 // sensor frame
        },
        "INFERENCE_BASICS": {
            "INPUT_WINDOW": 1,
            "CONVERSATION_WINDOW": 2,
            "USE_ALL_CAMERAS": true,
            "NO_HISTORY_MODE": false,
            "APPEND_QUESTION": true,
            "APPENDIX_FILE": "./infer_configs/append_questions.json" // not used now, to be removed
        },
        "CHAIN": {
            "NODE": [43, 50],
            "EDGE": {
                "43": [50],
                "50": []
            },
            "INHERIT": {
                "19": [43, 7],
                "15": [7]
            },
            "USE_GT": []
        }
    }
    ```
2. 추론 스크립트 시작:


    ```shell
    cd ./B2DVL_Adapter
    python inference.py --model Qwen2.5VL --model_path /path/to/Qwen2.5VL-3B-Instruct --config_dir /path/to/your_infer_config.json --image_dir /path/to/Bench2Drive/dataset --vqa_dir /path/to/vqa/dataset --num_workers 4 --out_dir ./infer_outputs
    ```
### 평가

1. 평가를 위해 llm API를 사용하려면 `./B2DVL-Adapter` 아래에 `mytoken.py`를 생성하세요. deepseek를 예로 들면:


    ```python
    DEEPSEEK_TOKEN = [
        "your-token-1", # you can set multiple tokens, and they will be used in a round-robin way
        "your-token-2"...
    ]
    DEEPSEEK_URL = "https://api.deepseek.com/v1"
    ```
    그러면 우리 스크립트는 `openai` 템플릿을 사용하여 이 API를 호출할 것입니다.



2. 구성 파일 작성:


    ```java
    {
        "EVAL_SUBSET": true, // eval a subset of given infer result folder
        "USE_CHECKPOINT": false, // use a file to record evaluation process
        "SUBSET_FILE": "./eval_configs/subset.txt", // subset file
        "CHECKPOINT_FILE": "./eval_configs/finished_scenarios.txt", // checkpoint file
        "INFERENCE_RESULT_DIR": "./infer_results", // path to inference results
        // when doing closed-loop inference, this dir is ./output/infer_results/model_name+input_mode
        "B2D_DIR": "/path/to/Bench2Drive/dataset", // evaluation script uses annotations in b2d,
        // when doing closed-loop inference, this dir is ./eval_v1(SAVE_PATH you specified)/model_name+input_mode
        "ORIGINAL_VQA_DIR": "../Carla_Chain_QA/carla_vqa_gen/vqa_dataset/outgraph",
        // when doing closed-loop inference, this dir is ./output/vqagen/model_name+input_mode
        "FRAME_PER_SEC": 10, // sensor fps
        "LOOK_FUTURE": false // not used now, to be removed
    }
    ```
2. 평가 스크립트 실행:


    ```shell
    python eval.py --config_dir ./path/to/eval_config.json --num_workers 4 --out_dir ./eval_outputs
    ```
## 라이선스
모든 자산과 코드는 별도로 명시되지 않는 한 CC-BY-NC-ND 라이선스 하에 있습니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-15

---