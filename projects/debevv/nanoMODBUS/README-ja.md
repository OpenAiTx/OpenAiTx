<translate-content># nanoMODBUS - 組み込み/マイコン向けのコンパクトなMODBUS RTU/TCP Cライブラリ

**このライブラリが役に立ったら、コーヒーをおごってください**
[<img src='https://storage.ko-fi.com/cdn/brandasset/logo_white_stroke.png' width='80'>](https://ko-fi.com/B0B2LK779)

nanoMODBUSはModbusプロトコルを実装した小さなCライブラリです。特に組み込みや
リソース制約のあるマイコンのようなシステムで有用です。  
主な特徴は以下の通りです：

- コンパクトなサイズ
    - 約2000行のコードのみ
    - 必要に応じてクライアントとサーバーのコードを無効化可能
- 動的メモリアロケーションなし
- トランスポート：
    - RTU
    - TCP
- 役割：
    - クライアント
    - サーバー
- ファンクションコード：
    - 01 (0x01) コイルの読み取り
    - 02 (0x02) 離散入力の読み取り
    - 03 (0x03) ホールディングレジスタの読み取り
    - 04 (0x04) 入力レジスタの読み取り
    - 05 (0x05) 単一コイルの書き込み
    - 06 (0x06) 単一レジスタの書き込み
    - 15 (0x0F) 複数コイルの書き込み
    - 16 (0x10) 複数レジスタの書き込み
    - 20 (0x14) ファイルレコードの読み取り
    - 21 (0x15) ファイルレコードの書き込み
    - 23 (0x17) 複数レジスタの読み書き
    - 43/14 (0x2B/0x0E) デバイス識別情報の読み取り
- プラットフォーム非依存
    - C99と標準ライブラリのみを必要とする
    - データトランスポートの読み書き関数はユーザー実装
- 高速化のためのユーザー定義CRC関数対応
- ブロードキャスト要求および応答対応

## 一目でわかる特徴
</translate-content>
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
## インストール

### 手動

`nanomodbus.c` と `nanomodbus.h` をアプリケーションのコードベース内にコピーしてください。

### CMake プロジェクト

nanomodbus は CMake を使用したライブラリリンクをサポートしています。


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
## API リファレンス

API リファレンスはリポジトリの[GitHub Pages](https://debevv.github.io/nanoMODBUS/nanomodbus_8h.html)で利用可能です。

## プラットフォーム関数

nanoMODBUS はクライアント/サーバーインスタンス作成時に関数ポインタとして定義される
プラットフォーム固有の2つの関数の実装を必要とします。

### トランスポートの読み書き


```C
int32_t read(uint8_t* buf, uint16_t count, int32_t byte_timeout_ms, void* arg);
int32_t write(const uint8_t* buf, uint16_t count, int32_t byte_timeout_ms, void* arg);
```
これらはシリアルポートまたはTCP接続からデータを読み書きするプラットフォーム固有の関数です。  
両方のメソッドは次のいずれかが発生するまでブロックする必要があります:

- `count` バイトのデータが読み書きされる
- `byte_timeout_ms >= 0` のバイトタイムアウトが切れる

`byte_timeout_ms` に `< 0` の値は無限タイムアウトを意味します。  
`byte_timeout_ms` に `== 0` の値の場合、メソッドは非ブロッキング方式で一度だけ読み書きし、即座に返ります。

戻り値は実際に読み書きされたバイト数、またはエラー時に `< 0` であるべきです。  
`0` から `count - 1` の範囲の戻り値は、トランスポート側でタイムアウトが発生したものとして扱われます。  
その他の値はトランスポートエラーとして扱われます。

### コールバックとプラットフォーム関数の引数

サーバーのコールバックとプラットフォーム関数は `void* arg` 引数を通じて任意のユーザーデータにアクセスできます。  
この引数は、例えば関数が操作すべき接続を渡すのに便利です。  
初期値は `nmbs_set_callbacks_arg` および `nmbs_set_platform_arg` API メソッドで設定できます。

## テストと例

テストと例はCMakeを使ってLinux上でビルド・実行できます:



```sh
mkdir build && cd build
cmake ..
make
```
`examples/arduino/README.md` を参照して、Arduinoのサンプルのビルドと実行に関する詳細情報をご確認ください。

## その他

- コードサイズを削減するために、以下の `#define` を定義できます：
    - すべてのクライアントコードを無効にするには `NMBS_CLIENT_DISABLED`
    - すべてのサーバーコードを無効にするには `NMBS_SERVER_DISABLED`
    - 個別のサーバーコールバックを無効にするには、以下を定義してください：
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
    - `nmbs_error` を文字列に変換するコードを無効にするには `NMBS_STRERROR_DISABLED`
    - コイルの値を格納するために使用される `nmbs_bitfield` 型のサイズを設定するには `NMBS_BITFIELD_MAX` （デフォルトは `2000`）
- 受信および送信メッセージに関するデバッグ出力は `NMBS_DEBUG` を定義することで有効にできます



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-21

---