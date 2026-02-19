# Python-TLS-Client
Python-TLS-Clientはrequestsとtls-clientに基づく高度なHTTPライブラリです。

# インストール
```
pip install tls-client
```

# 例
この構文は[requests](https://github.com/psf/requests)に触発されているため、とても似ており、異なる点はごくわずかです。

例 1 - プリセット:
```python
import tls_client

# You can also use the following as `client_identifier`:
# Chrome --> chrome_103, chrome_104, chrome_105, chrome_106, chrome_107, chrome_108, chrome109, Chrome110,
#            chrome111, chrome112, chrome_116_PSK, chrome_116_PSK_PQ, chrome_117, chrome_120
# Firefox --> firefox_102, firefox_104, firefox108, Firefox110, firefox_117, firefox_120
# Opera --> opera_89, opera_90
# Safari --> safari_15_3, safari_15_6_1, safari_16_0
# iOS --> safari_ios_15_5, safari_ios_15_6, safari_ios_16_0
# iPadOS --> safari_ios_15_6
# Android --> okhttp4_android_7, okhttp4_android_8, okhttp4_android_9, okhttp4_android_10, okhttp4_android_11,
#             okhttp4_android_12, okhttp4_android_13
#
# more client identifiers can be found in settings.py

session = tls_client.Session(
    client_identifier="chrome112",
    random_tls_extension_order=True
)

res = session.get(
    "https://www.example.com/",
    headers={
        "key1": "value1",
    },
    proxy="http://user:password@host:port"
)
```

例 2 - カスタム:
```python
import tls_client

session = tls_client.Session(
    ja3_string="771,4865-4866-4867-49195-49199-49196-49200-52393-52392-49171-49172-156-157-47-53,0-23-65281-10-11-35-16-5-13-18-51-45-43-27-17513,29-23-24,0",
    h2_settings={
        "HEADER_TABLE_SIZE": 65536,
        "MAX_CONCURRENT_STREAMS": 1000,
        "INITIAL_WINDOW_SIZE": 6291456,
        "MAX_HEADER_LIST_SIZE": 262144
    },
    h2_settings_order=[
        "HEADER_TABLE_SIZE",
        "MAX_CONCURRENT_STREAMS",
        "INITIAL_WINDOW_SIZE",
        "MAX_HEADER_LIST_SIZE"
    ],
    supported_signature_algorithms=[
        "ECDSAWithP256AndSHA256",
        "PSSWithSHA256",
        "PKCS1WithSHA256",
        "ECDSAWithP384AndSHA384",
        "PSSWithSHA384",
        "PKCS1WithSHA384",
        "PSSWithSHA512",
        "PKCS1WithSHA512",
    ],
    supported_versions=["GREASE", "1.3", "1.2"],
    key_share_curves=["GREASE", "X25519"],
    cert_compression_algo="brotli",
    pseudo_header_order=[
        ":method",
        ":authority",
        ":scheme",
        ":path"
    ],
    connection_flow=15663105,
    header_order=[
        "accept",
        "user-agent",
        "accept-encoding",
        "accept-language"
    ]
)

res = session.post(
    "https://www.example.com/",
    headers={
        "key1": "value1",
    },
    json={
        "key1": "key2"
    }
)
```

# Pyinstaller / Pyarmor
**ライブラリをPyinstallerまたはPyarmorでパックしたい場合は、コマンドにこれを追加してください：**

Linux - Ubuntu / x86:
```
--add-binary '{path_to_library}/tls_client/dependencies/tls-client-x86.so:tls_client/dependencies'
```
Linux Alpine / AMD64:

```
--add-binary '{path_to_library}/tls_client/dependencies/tls-client-amd64.so:tls_client/dependencies'
```

MacOS M1およびそれ以前：
```
--add-binary '{path_to_library}/tls_client/dependencies/tls-client-x86.dylib:tls_client/dependencies'
```

MacOS M2:
```
--add-binary '{path_to_library}/tls_client/dependencies/tls-client-arm64.dylib:tls_client/dependencies'
```
Windows:

```
--add-binary '{path_to_library}/tls_client/dependencies/tls-client-64.dll;tls_client/dependencies'
```

# 謝辞
Golangで[tls-client](https://github.com/bogdanfinn/tls-client)をオープンソース化した[Bogdanfinn](https://github.com/bogdanfinn)に大きな感謝を。
また、ほとんどの人が使い慣れている[requests](https://github.com/psf/requests)とできるだけ似た構文を維持したかった！


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-19

---