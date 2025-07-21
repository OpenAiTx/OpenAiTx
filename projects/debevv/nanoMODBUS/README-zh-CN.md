<translate-content># nanoMODBUS - 一个用于嵌入式/微控制器的紧凑型 MODBUS RTU/TCP C 库

**如果您觉得这个库有用，请请我喝杯咖啡**
[<img src='https://storage.ko-fi.com/cdn/brandasset/logo_white_stroke.png' width='80'>](https://ko-fi.com/B0B2LK779)

nanoMODBUS 是一个实现 Modbus 协议的小型 C 库。它在嵌入式和资源受限的系统如微控制器中特别有用。  
其主要特点有：

- 体积紧凑
    - 仅约 2000 行代码
    - 如果不需要，客户端和服务器端代码可以禁用
- 无动态内存分配
- 传输方式：
    - RTU
    - TCP
- 角色：
    - 客户端
    - 服务器端
- 功能码：
    - 01 (0x01) 读取线圈
    - 02 (0x02) 读取离散输入
    - 03 (0x03) 读取保持寄存器
    - 04 (0x04) 读取输入寄存器
    - 05 (0x05) 写单个线圈
    - 06 (0x06) 写单个寄存器
    - 15 (0x0F) 写多个线圈
    - 16 (0x10) 写多个寄存器
    - 20 (0x14) 读取文件记录
    - 21 (0x15) 写文件记录
    - 23 (0x17) 读/写多个寄存器
    - 43/14 (0x2B/0x0E) 读取设备标识
- 平台无关
    - 仅需 C99 及其标准库
    - 数据传输读写函数由用户实现
- 用户可定义 CRC 函数以提升性能
- 支持广播请求和响应

## 一览</translate-content>


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
<translate-content>
## 安装

### 手动安装

只需将 `nanomodbus.c` 和 `nanomodbus.h` 复制到您的应用代码库中。

### CMake 项目

nanomodbus 支持通过 CMake 进行库链接。
</translate-content>
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
<translate-content>
## API 参考

API 参考可在仓库的 [GitHub Pages](https://debevv.github.io/nanoMODBUS/nanomodbus_8h.html) 中获得。

## 平台函数

nanoMODBUS 需要实现 2 个平台特定的函数，在创建客户端/服务器实例时作为函数指针定义。

### 传输读/写
</translate-content>

```C
int32_t read(uint8_t* buf, uint16_t count, int32_t byte_timeout_ms, void* arg);
int32_t write(const uint8_t* buf, uint16_t count, int32_t byte_timeout_ms, void* arg);
```
<translate-content>
这些是您的平台特定函数，用于从串口或TCP连接读取/写入数据。  
两种方法都应该阻塞，直到满足以下条件之一：

- 读取/写入了 `count` 字节数据
- 字节超时，且 `byte_timeout_ms >= 0`，超时发生

`byte_timeout_ms` 小于 0 表示无限超时。  
`byte_timeout_ms` 等于 0 时，该方法应以非阻塞方式执行一次读/写，并立即返回。

它们的返回值应为实际读取/写入的字节数，或在出错时返回小于 0。  
返回值在 `0` 到 `count - 1` 之间将被视为传输端发生超时。其他值将被视为传输错误。

### 回调和平台函数参数

服务器回调和平台函数可以通过它们的 `void* arg` 参数访问任意用户数据。该参数  
例如可用于传递函数应操作的连接对象。  
它们的初始值可以通过 `nmbs_set_callbacks_arg` 和 `nmbs_set_platform_arg` API 方法设置。

## 测试和示例

测试和示例可以在 Linux 上使用 CMake 构建和运行：
</translate-content>


```sh
mkdir build && cd build
cmake ..
make
```
请参阅 `examples/arduino/README.md` 以获取有关构建和运行 Arduino 示例的更多信息。

## 其他

- 为了减少代码大小，您可以定义以下 `#define`：
    - `NMBS_CLIENT_DISABLED` 以禁用所有客户端代码
    - `NMBS_SERVER_DISABLED` 以禁用所有服务器代码
    - 要禁用单个服务器回调，请定义以下宏：
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
    - `NMBS_STRERROR_DISABLED` 用于禁用将 `nmbs_error` 转换为字符串的代码
    - `NMBS_BITFIELD_MAX` 用于设置 `nmbs_bitfield` 类型的大小，该类型用于存储线圈值（默认值为 `2000`）
- 通过定义 `NMBS_DEBUG` 可以启用关于接收和发送消息的调试打印



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-21

---