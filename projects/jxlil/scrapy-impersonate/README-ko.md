# scrapy-impersonate
[![version](https://img.shields.io/pypi/v/scrapy-impersonate.svg)](https://pypi.python.org/pypi/scrapy-impersonate)

`scrapy-impersonate`는 Scrapy 다운로드 핸들러입니다. 이 프로젝트는 HTTP 요청을 수행하기 위해 [curl_cffi](https://github.com/yifeikong/curl_cffi)를 통합하여, 브라우저의 TLS 서명 또는 JA3 지문을 가장할 수 있습니다.


## 설치 방법

```
pip install scrapy-impersonate
```
## 활성화

이 패키지를 사용하려면 기본 `http` 및 `https` 다운로드 핸들러를 [`DOWNLOAD_HANDLERS`](https://docs.scrapy.org/en/latest/topics/settings.html#download-handlers) 설정을 업데이트하여 교체하십시오:


```python
DOWNLOAD_HANDLERS = {
    "http": "scrapy_impersonate.ImpersonateDownloadHandler",
    "https": "scrapy_impersonate.ImpersonateDownloadHandler",
}
```
`USER_AGENT = None`으로 설정하면, `curl_cffi`가 모방하는 브라우저에 따라 적절한 User-Agent를 자동으로 선택합니다:

```python
USER_AGENT = None
```
또한, 적절한 비동기 실행을 위해 [asyncio 기반 Twisted 리액터를 설치](https://docs.scrapy.org/en/latest/topics/asyncio.html#installing-the-asyncio-reactor)해야 합니다:


```python
TWISTED_REACTOR = "twisted.internet.asyncioreactor.AsyncioSelectorReactor"
```

## 사용법

`impersonate` [Request.meta](https://docs.scrapy.org/en/latest/topics/request-response.html#scrapy.http.Request.meta) 키를 설정하여 `curl_cffi`를 사용해 요청을 다운로드합니다:


```python
import scrapy


class ImpersonateSpider(scrapy.Spider):
    name = "impersonate_spider"
    custom_settings = {
        "TWISTED_REACTOR": "twisted.internet.asyncioreactor.AsyncioSelectorReactor",
        "USER_AGENT": None,
        "DOWNLOAD_HANDLERS": {
            "http": "scrapy_impersonate.ImpersonateDownloadHandler",
            "https": "scrapy_impersonate.ImpersonateDownloadHandler",
        },
        "DOWNLOADER_MIDDLEWARES": {
            "scrapy_impersonate.RandomBrowserMiddleware": 1000,
        },
    }

    def start_requests(self):
        for _ in range(5):
            yield scrapy.Request(
                "https://tls.browserleaks.com/json",
                dont_filter=True,
            )

    def parse(self, response):
        # ja3_hash: 98cc085d47985d3cca9ec1415bbbf0d1 (chrome133a)
        # ja3_hash: 2d692a4485ca2f5f2b10ecb2d2909ad3 (firefox133)
        # ja3_hash: c11ab92a9db8107e2a0b0486f35b80b9 (chrome124)
        # ja3_hash: 773906b0efdefa24a7f2b8eb6985bf37 (safari15_5)
        # ja3_hash: cd08e31494f9531f560d64c695473da9 (chrome99_android)

        yield {"ja3_hash": response.json()["ja3_hash"]}
```

### impersonate-args

필요한 모든 [인자들](https://github.com/lexiforest/curl_cffi/blob/38a91f2e7b23d9c9bda1d8085b7e41e33767c768/curl_cffi/requests/session.py#L1189-L1222)을 `impersonate_args`를 통해 `curl_cffi`에 전달할 수 있습니다. 예를 들어:

```python
yield scrapy.Request(
    "https://tls.browserleaks.com/json",
    dont_filter=True,
    meta={
        "impersonate": browser,
        "impersonate_args": {
            "verify": False,
            "timeout": 10,
        },
    },
)
```
## 지원되는 브라우저

다음 브라우저들을 가장할 수 있습니다

| 브라우저 | 버전 | 빌드 | 운영체제 | 이름 |
| --- | --- | --- | --- | --- |
| ![Chrome](https://raw.githubusercontent.com/alrra/browser-logos/main/src/chrome/chrome_24x24.png "Chrome") | 99 | 99.0.4844.51 | Windows 10 | `chrome99` |
| ![Chrome](https://raw.githubusercontent.com/alrra/browser-logos/main/src/chrome/chrome_24x24.png "Chrome") | 99 | 99.0.4844.73 | Android 12 | `chrome99_android` |
| ![Chrome](https://raw.githubusercontent.com/alrra/browser-logos/main/src/chrome/chrome_24x24.png "Chrome") | 100 | 100.0.4896.75 | Windows 10 | `chrome100` |
| ![Chrome](https://raw.githubusercontent.com/alrra/browser-logos/main/src/chrome/chrome_24x24.png "Chrome") | 101 | 101.0.4951.67 | Windows 10 | `chrome101` |
| ![Chrome](https://raw.githubusercontent.com/alrra/browser-logos/main/src/chrome/chrome_24x24.png "Chrome") | 104 | 104.0.5112.81 | Windows 10 | `chrome104` |
| ![Chrome](https://raw.githubusercontent.com/alrra/browser-logos/main/src/chrome/chrome_24x24.png "Chrome") | 107 | 107.0.5304.107 | Windows 10 | `chrome107` |
| ![Chrome](https://raw.githubusercontent.com/alrra/browser-logos/main/src/chrome/chrome_24x24.png "Chrome") | 110 | 110.0.5481.177 | Windows 10 | `chrome110` |
| ![Chrome](https://raw.githubusercontent.com/alrra/browser-logos/main/src/chrome/chrome_24x24.png "Chrome") | 116 | 116.0.5845.180 | Windows 10 | `chrome116` |
| ![Chrome](https://raw.githubusercontent.com/alrra/browser-logos/main/src/chrome/chrome_24x24.png "Chrome") | 119 | 119.0.6045.199 | macOS Sonoma | `chrome119` |
| ![Chrome](https://raw.githubusercontent.com/alrra/browser-logos/main/src/chrome/chrome_24x24.png "Chrome") | 120 | 120.0.6099.109 | macOS Sonoma | `chrome120` |
| ![Chrome](https://raw.githubusercontent.com/alrra/browser-logos/main/src/chrome/chrome_24x24.png "Chrome") | 123 | 123.0.6312.124 | macOS Sonoma | `chrome123` |
| ![Chrome](https://raw.githubusercontent.com/alrra/browser-logos/main/src/chrome/chrome_24x24.png "Chrome") | 124 | 124.0.6367.60 | macOS Sonoma | `chrome124` |
| ![Chrome](https://raw.githubusercontent.com/alrra/browser-logos/main/src/chrome/chrome_24x24.png "Chrome") | 131 | 131.0.6778.86 | macOS Sonoma | `chrome131` |
| ![Chrome](https://raw.githubusercontent.com/alrra/browser-logos/main/src/chrome/chrome_24x24.png "Chrome") | 131 | 131.0.6778.81 | Android 14	 | `chrome131_android` |
| ![Chrome](https://raw.githubusercontent.com/alrra/browser-logos/main/src/chrome/chrome_24x24.png "Chrome") | 133 | 133.0.6943.55 | macOS Sequoia | `chrome133a` |
| ![Edge](https://raw.githubusercontent.com/alrra/browser-logos/main/src/edge/edge_24x24.png "Edge") | 99 | 99.0.1150.30 | Windows 10 | `edge99` |
| ![Edge](https://raw.githubusercontent.com/alrra/browser-logos/main/src/edge/edge_24x24.png "Edge") | 101 | 101.0.1210.47 | Windows 10 | `edge101` |
| ![Safari](https://github.com/alrra/browser-logos/blob/main/src/safari/safari_24x24.png "Safari") | 15.3 | 16612.4.9.1.8 | MacOS Big Sur | `safari15_3` |
| ![Safari](https://github.com/alrra/browser-logos/blob/main/src/safari/safari_24x24.png "Safari") | 15.5 | 17613.2.7.1.8 | MacOS Monterey | `safari15_5` |
| ![Safari](https://github.com/alrra/browser-logos/blob/main/src/safari/safari_24x24.png "Safari") | 17.0 | 불명확 | MacOS Sonoma | `safari17_0` |
| ![Safari](https://github.com/alrra/browser-logos/blob/main/src/safari/safari_24x24.png "Safari") | 17.2 | 불명확 | iOS 17.2 | `safari17_2_ios` |
| ![Safari](https://github.com/alrra/browser-logos/blob/main/src/safari/safari_24x24.png "Safari") | 18.0 | 불명확 | MacOS Sequoia | `safari18_0` |
| ![Safari](https://github.com/alrra/browser-logos/blob/main/src/safari/safari_24x24.png "Safari") | 18.0 | 불명확 | iOS 18.0 | `safari18_0_ios` |
| ![Firefox](https://github.com/alrra/browser-logos/blob/main/src/firefox/firefox_24x24.png "Firefox") | 133.0 | 133.0.3 | macOS Sonoma | `firefox133` |
| ![Firefox](https://github.com/alrra/browser-logos/blob/main/src/firefox/firefox_24x24.png "Firefox") | 135.0 | 135.0.1 | macOS Sonoma	| `firefox135` |

## 감사의 말

이 프로젝트는 다음 프로젝트들에서 영감을 받았습니다:

+ [curl_cffi](https://github.com/yifeikong/curl_cffi) - cffi를 통해 curl-impersonate에 바인딩된 파이썬. 브라우저 tls/ja3/http2 지문을 가장할 수 있는 http 클라이언트입니다.
+ [curl-impersonate](https://github.com/lwthiker/curl-impersonate) - Chrome 및 Firefox를 가장할 수 있는 특별한 curl 빌드입니다.


+ [scrapy-playwright](https://github.com/scrapy-plugins/scrapy-playwright) - Scrapy용 Playwright 통합 기능


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-28

---