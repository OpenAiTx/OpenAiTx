# scrapy-impersonate
[![version](https://img.shields.io/pypi/v/scrapy-impersonate.svg)](https://pypi.python.org/pypi/scrapy-impersonate)

`scrapy-impersonate` est un gestionnaire de téléchargement Scrapy. Ce projet intègre [curl_cffi](https://github.com/yifeikong/curl_cffi) pour effectuer des requêtes HTTP, permettant ainsi d'imiter les signatures TLS ou les empreintes JA3 des navigateurs.


## Installation

```
pip install scrapy-impersonate
```

## Activation

Pour utiliser ce package, remplacez les gestionnaires de téléchargement par défaut `http` et `https` en mettant à jour le paramètre [`DOWNLOAD_HANDLERS`](https://docs.scrapy.org/en/latest/topics/settings.html#download-handlers) :

```python
DOWNLOAD_HANDLERS = {
    "http": "scrapy_impersonate.ImpersonateDownloadHandler",
    "https": "scrapy_impersonate.ImpersonateDownloadHandler",
}
```
En définissant `USER_AGENT = None`, `curl_cffi` choisira automatiquement l'User-Agent approprié en fonction du navigateur imité :

```python
USER_AGENT = None
```

Assurez-vous également de [installer le réacteur Twisted basé sur asyncio](https://docs.scrapy.org/en/latest/topics/asyncio.html#installing-the-asyncio-reactor) pour une exécution asynchrone correcte :

```python
TWISTED_REACTOR = "twisted.internet.asyncioreactor.AsyncioSelectorReactor"
```


## Utilisation

Définissez la clé `impersonate` de [Request.meta](https://docs.scrapy.org/en/latest/topics/request-response.html#scrapy.http.Request.meta) pour télécharger une requête en utilisant `curl_cffi` :

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

Vous pouvez passer tous les [arguments](https://github.com/lexiforest/curl_cffi/blob/38a91f2e7b23d9c9bda1d8085b7e41e33767c768/curl_cffi/requests/session.py#L1189-L1222) nécessaires à `curl_cffi` via `impersonate_args`. Par exemple :

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


## Navigateurs pris en charge

Les navigateurs suivants peuvent être impersonnés

| Navigateur | Version | Build | OS | Nom |
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
| ![Safari](https://github.com/alrra/browser-logos/blob/main/src/safari/safari_24x24.png "Safari") | 17.0 | incertain | MacOS Sonoma | `safari17_0` |
| ![Safari](https://github.com/alrra/browser-logos/blob/main/src/safari/safari_24x24.png "Safari") | 17.2 | incertain | iOS 17.2 | `safari17_2_ios` |
| ![Safari](https://github.com/alrra/browser-logos/blob/main/src/safari/safari_24x24.png "Safari") | 18.0 | incertain | MacOS Sequoia | `safari18_0` |
| ![Safari](https://github.com/alrra/browser-logos/blob/main/src/safari/safari_24x24.png "Safari") | 18.0 | incertain | iOS 18.0 | `safari18_0_ios` |
| ![Firefox](https://github.com/alrra/browser-logos/blob/main/src/firefox/firefox_24x24.png "Firefox") | 133.0 | 133.0.3 | macOS Sonoma | `firefox133` |
| ![Firefox](https://github.com/alrra/browser-logos/blob/main/src/firefox/firefox_24x24.png "Firefox") | 135.0 | 135.0.1 | macOS Sonoma	| `firefox135` |

## Remerciements

Ce projet est inspiré par les projets suivants :

+ [curl_cffi](https://github.com/yifeikong/curl_cffi) - Liaison Python pour curl-impersonate via cffi. Un client http capable d’imiter les empreintes tls/ja3/http2 des navigateurs.
+ [curl-impersonate](https://github.com/lwthiker/curl-impersonate) - Une version spéciale de curl qui peut imiter Chrome & Firefox
+ [scrapy-playwright](https://github.com/scrapy-plugins/scrapy-playwright) - Intégration de Playwright pour Scrapy


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-28

---