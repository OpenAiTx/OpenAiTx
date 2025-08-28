# scrapy-impersonate
[![version](https://img.shields.io/pypi/v/scrapy-impersonate.svg)](https://pypi.python.org/pypi/scrapy-impersonate)

`scrapy-impersonate` は Scrapy のダウンロードハンドラです。このプロジェクトは [curl_cffi](https://github.com/yifeikong/curl_cffi) を統合してHTTPリクエストを実行し、ブラウザのTLSシグネチャやJA3フィンガープリントを偽装できます。


## インストール

```
pip install scrapy-impersonate
```

## アクティベーション

このパッケージを使用するには、デフォルトの `http` および `https` ダウンロードハンドラーを置き換え、[`DOWNLOAD_HANDLERS`](https://docs.scrapy.org/en/latest/topics/settings.html#download-handlers) 設定を更新してください:

```python
DOWNLOAD_HANDLERS = {
    "http": "scrapy_impersonate.ImpersonateDownloadHandler",
    "https": "scrapy_impersonate.ImpersonateDownloadHandler",
}
```

`USER_AGENT = None` を設定すると、`curl_cffi` は偽装しているブラウザに基づいて適切な User-Agent を自動的に選択します:
```python
USER_AGENT = None
```

また、適切な非同期実行のために、[asyncioベースのTwistedリアクターをインストール](https://docs.scrapy.org/ja/latest/topics/asyncio.html#installing-the-asyncio-reactor)してください:

```python
TWISTED_REACTOR = "twisted.internet.asyncioreactor.AsyncioSelectorReactor"
```

## 使用法

`impersonate` [Request.meta](https://docs.scrapy.org/en/latest/topics/request-response.html#scrapy.http.Request.meta) キーを設定して、`curl_cffi` を使用してリクエストをダウンロードします:


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

必要な[引数](https://github.com/lexiforest/curl_cffi/blob/38a91f2e7b23d9c9bda1d8085b7e41e33767c768/curl_cffi/requests/session.py#L1189-L1222)を `impersonate_args` を通じて `curl_cffi` に渡すことができます。例えば:

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

## 対応ブラウザ

以下のブラウザを偽装可能です

| ブラウザ | バージョン | ビルド | OS | 名前 |
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
| ![Safari](https://github.com/alrra/browser-logos/blob/main/src/safari/safari_24x24.png "Safari") | 17.0 | 不明 | MacOS Sonoma | `safari17_0` |
| ![Safari](https://github.com/alrra/browser-logos/blob/main/src/safari/safari_24x24.png "Safari") | 17.2 | 不明 | iOS 17.2 | `safari17_2_ios` |
| ![Safari](https://github.com/alrra/browser-logos/blob/main/src/safari/safari_24x24.png "Safari") | 18.0 | 不明 | MacOS Sequoia | `safari18_0` |
| ![Safari](https://github.com/alrra/browser-logos/blob/main/src/safari/safari_24x24.png "Safari") | 18.0 | 不明 | iOS 18.0 | `safari18_0_ios` |
| ![Firefox](https://github.com/alrra/browser-logos/blob/main/src/firefox/firefox_24x24.png "Firefox") | 133.0 | 133.0.3 | macOS Sonoma | `firefox133` |
| ![Firefox](https://github.com/alrra/browser-logos/blob/main/src/firefox/firefox_24x24.png "Firefox") | 135.0 | 135.0.1 | macOS Sonoma	| `firefox135` |

## 感謝

このプロジェクトは以下のプロジェクトに触発されています：

+ [curl_cffi](https://github.com/yifeikong/curl_cffi) - cffi経由のcurl-impersonateのPythonバインディング。ブラウザのtls/ja3/http2フィンガープリントを偽装可能なHTTPクライアント。
+ [curl-impersonate](https://github.com/lwthiker/curl-impersonate) - ChromeとFirefoxを偽装可能なcurlの特別ビルド。

+ [scrapy-playwright](https://github.com/scrapy-plugins/scrapy-playwright) - Scrapy用のPlaywright統合機能


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-28

---