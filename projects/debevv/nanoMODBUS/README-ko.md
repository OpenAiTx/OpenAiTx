
# nanoMODBUS - 임베디드/마이크로컨트롤러용 소형 MODBUS RTU/TCP C 라이브러리

**이 라이브러리가 유용하다면, 저에게 커피 한잔 사주세요**
[<img src='https://storage.ko-fi.com/cdn/brandasset/logo_white_stroke.png' width='80'>](https://ko-fi.com/B0B2LK779)

nanoMODBUS는 Modbus 프로토콜을 구현한 소형 C 라이브러리입니다. 특히 임베디드 및
자원이 제한된 시스템, 예를 들어 마이크로컨트롤러에 유용합니다.  
주요 특징은 다음과 같습니다:

- 컴팩트한 크기
    - 약 2000 라인 코드만 사용
    - 클라이언트 및 서버 코드는 필요 없으면 비활성화 가능
- 동적 메모리 할당 없음
- 전송 방식:
    - RTU
    - TCP
- 역할:
    - 클라이언트
    - 서버
- 기능 코드:
    - 01 (0x01) 코일 읽기
    - 02 (0x02) 이산 입력 읽기
    - 03 (0x03) 유지 레지스터 읽기
    - 04 (0x04) 입력 레지스터 읽기
    - 05 (0x05) 단일 코일 쓰기
    - 06 (0x06) 단일 레지스터 쓰기
    - 15 (0x0F) 다중 코일 쓰기
    - 16 (0x10) 다중 레지스터 쓰기
    - 20 (0x14) 파일 레코드 읽기
    - 21 (0x15) 파일 레코드 쓰기
    - 23 (0x17) 다중 레지스터 읽기/쓰기
    - 43/14 (0x2B/0x0E) 장치 식별 읽기
- 플랫폼 독립적
    - C99 및 표준 라이브러리만 필요
    - 데이터 전송 읽기/쓰기 함수는 사용자가 구현
- 사용자 정의 CRC 함수로 성능 향상 가능
- 방송 요청 및 응답 지원

## 한눈에 보기


```C
#include <stdio.h>

#include "nanomodbus.h"
#include "my_platform_stuff.h"

int main(int argc, char* argv[]) {
    // Set up the TCP connection
    void* conn = my_connect_tcp(argv[1], argv[2]);
    if (!conn) {
        fprintf(stderr, "Error connecting to server\n");
        return 1;
    }

    // my_transport_read() and my_transport_write() are implemented by the user 
    nmbs_platform_conf platform_conf;
    nmbs_platform_conf_create(&platform_conf);
    platform_conf.transport = NMBS_TRANSPORT_TCP;
    platform_conf.read = my_transport_read;
    platform_conf.write = my_transport_write;
    platform_conf.arg = conn;    // Passing our TCP connection handle to the read/write functions

    // Create the modbus client
    nmbs_t nmbs;
    nmbs_error err = nmbs_client_create(&nmbs, &platform_conf);
    if (err != NMBS_ERROR_NONE) {
        fprintf(stderr, "Error creating modbus client\n");
        return 1;
    }

    // Set only the response timeout. Byte timeout will be handled by the TCP connection
    nmbs_set_read_timeout(&nmbs, 1000);

    // Write 2 holding registers at address 26
    uint16_t w_regs[2] = {123, 124};
    err = nmbs_write_multiple_registers(&nmbs, 26, 2, w_regs);
    if (err != NMBS_ERROR_NONE) {
        fprintf(stderr, "Error writing register at address 26 - %s", nmbs_strerror(err));
        return 1;
    }

    // Read 2 holding registers from address 26
    uint16_t r_regs[2];
    err = nmbs_read_holding_registers(&nmbs, 26, 2, r_regs);
    if (err != NMBS_ERROR_NONE) {
        fprintf(stderr, "Error reading 2 holding registers at address 26 - %s\n", nmbs_strerror(err));
        return 1;
    }
    
    // Close the TCP connection
    my_disconnect(conn);
    
    return 0;
}
```
## 설치

### 수동 설치

애플리케이션 코드베이스 내에 `nanomodbus.c`와 `nanomodbus.h`를 복사하세요.

### CMake 프로젝트

nanomodbus는 CMake를 사용한 라이브러리 링크를 지원합니다.


```cmake
FetchContent_Declare(
        nanomodbus
        GIT_REPOSITORY https://github.com/debevv/nanoMODBUS
        GIT_TAG master # or the version you want
        GIT_SHALLOW TRUE
)

FetchContent_MakeAvailable(nanomodbus)

#...

add_executable(your_program source_codes)
target_link_libraries(your_program nanomodbus)
```


## API 참조

API 참조는 저장소의 [GitHub Pages](https://debevv.github.io/nanoMODBUS/nanomodbus_8h.html)에서 확인할 수 있습니다.

## 플랫폼 함수

nanoMODBUS는 클라이언트/서버 인스턴스를 생성할 때 함수 포인터로 정의되는 2개의 플랫폼 별 함수 구현을 필요로 합니다.

### 전송 읽기/쓰기



```C
int32_t read(uint8_t* buf, uint16_t count, int32_t byte_timeout_ms, void* arg);
int32_t write(const uint8_t* buf, uint16_t count, int32_t byte_timeout_ms, void* arg);
```
이들은 직렬 포트 또는 TCP 연결에서 데이터를 읽거나 쓰는 플랫폼별 함수입니다.  
두 방법 모두 다음 중 하나가 발생할 때까지 차단(block)되어야 합니다:

- `count` 바이트의 데이터가 읽히거나 쓰여질 때
- `byte_timeout_ms >= 0`인 바이트 타임아웃이 만료될 때

`byte_timeout_ms` 값이 `< 0`이면 무한 타임아웃을 의미합니다.  
`byte_timeout_ms` 값이 `== 0`이면, 메서드는 논블로킹 방식으로 한 번 읽거나 쓰고 즉시 반환해야 합니다.

반환 값은 실제로 읽거나 쓴 바이트 수여야 하며, 오류가 발생하면 `< 0`이어야 합니다.  
`0`과 `count - 1` 사이의 반환 값은 전송 측에서 타임아웃이 발생한 것으로 처리됩니다.  
그 외의 값은 전송 오류로 간주됩니다.

### 콜백 및 플랫폼 함수 인자

서버 콜백 및 플랫폼 함수는 `void* arg` 인자를 통해 임의의 사용자 데이터를 접근할 수 있습니다. 이 인자는 예를 들어, 함수가 작동해야 하는 연결을 전달하는 데 유용합니다.  
초기 값은 `nmbs_set_callbacks_arg` 및 `nmbs_set_platform_arg` API 메서드를 통해 설정할 수 있습니다.

## 테스트 및 예제

테스트 및 예제는 CMake를 사용하여 Linux에서 빌드하고 실행할 수 있습니다:




```sh
mkdir build && cd build
cmake ..
make
```


자세한 Arduino 예제 빌드 및 실행 방법은 `examples/arduino/README.md`를 참고하세요.

## 기타

- 코드 크기를 줄이려면 다음 `#define`들을 정의할 수 있습니다:
    - 모든 클라이언트 코드를 비활성화하려면 `NMBS_CLIENT_DISABLED`
    - 모든 서버 코드를 비활성화하려면 `NMBS_SERVER_DISABLED`
    - 개별 서버 콜백을 비활성화하려면 다음을 정의하세요:
        - `NMBS_SERVER_READ_COILS_DISABLED`
        - `NMBS_SERVER_READ_DISCRETE_INPUTS_DISABLED`
        - `NMBS_SERVER_READ_HOLDING_REGISTERS_DISABLED`
        - `NMBS_SERVER_READ_INPUT_REGISTERS_DISABLED`
        - `NMBS_SERVER_WRITE_SINGLE_COIL_DISABLED`
        - `NMBS_SERVER_WRITE_SINGLE_REGISTER_DISABLED`
        - `NMBS_SERVER_WRITE_MULTIPLE_COILS_DISABLED`
        - `NMBS_SERVER_WRITE_MULTIPLE_REGISTERS_DISABLED`
        - `NMBS_SERVER_READ_FILE_RECORD_DISABLED`
        - `NMBS_SERVER_WRITE_FILE_RECORD_DISABLED`
        - `NMBS_SERVER_READ_WRITE_REGISTERS_DISABLED`
        - `NMBS_SERVER_READ_DEVICE_IDENTIFICATION_DISABLED`
    - `nmbs_error`를 문자열로 변환하는 코드를 비활성화하려면 `NMBS_STRERROR_DISABLED`
    - 코일 값을 저장하는 데 사용되는 `nmbs_bitfield` 타입 크기를 설정하려면 `NMBS_BITFIELD_MAX` (기본값은 `2000`)
- 수신 및 전송된 메시지에 대한 디버그 출력은 `NMBS_DEBUG`를 정의하여 활성화할 수 있습니다.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-21

---