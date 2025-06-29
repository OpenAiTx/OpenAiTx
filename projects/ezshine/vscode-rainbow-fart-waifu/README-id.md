# 🌈 Rainbow Fart Waifu
![](https://s1.ax1x.com/2020/08/21/dNvHfS.gif)

Website：[https://rfw.jnsii.com](https://rfw.jnsii.com/index_en.html)

Bahasa: [简体中文](./README.zh.md) | English

## Ringkasan

----

ide ekstensi ini berasal dari [@SaekiRaku](https://github.com/SaekiRaku/vscode-rainbow-fart), semua kode ditulis ulang. kompatibel dengan semua paket suara, dan menambahkan beberapa fitur baru.

## Terima Kasih Khusus

---

1. ekstensi ini sudah termasuk paket suara bahasa Tionghoa dari [@justkowalski](https://github.com/JustKowalski). kamu dapat [mendapatkan lebih banyak paket suara dari github](https://github.com/topics/rainbow-fart) 
2. ekstensi ini sudah termasuk cmdmp3win.exe, dari [@James K. Lawless](http://jiml.us) 
3. model waifu bawaan dari [@二夏](https://erxia207.lofter.com), jika kamu ingin mendesain waifu orisinil milikmu sendiri, hubungi dia. 
4. ekstensi ini termasuk model waifu lain bernama keysoban, open source oleh [@DenchiSoft](https://twitter.com/DenchiSoft/status/1036017773011525632).

[Dapatkan Lebih Banyak Model Waifu](https://github.com/ezshine/live2d-model-collections)

## Platform yang Didukung

---

~~~~
Hanya mendukung MacOS dan Windows10
~~~~

## Q&A

---

#### _Waifu tidak muncul?_
> A: Kamu perlu [unduh](https://github.com/ezshine/live2d-model-collections) waifu container. Setelah semua file zip diekstrak, jalankan liv2dplayer.exe, panggil daftar perintah di vscode, coba ganti model waifu.

## Manual, Perintah

---

🌈 Tampilkan Perintah Rainbow Fart Waifu

- "Ganti Paket Suara"
- "Ganti Model Waifu"
- "Buka Direktori Sumber Daya"

> jika kamu mengunduh paket suara atau model, kamu harus menggunakan perintah ini untuk membuka direktori sumber daya, pindahkan paket tersebut ke dalam path

- "Unduh Waifu Container dan Sumber Daya Lainnya"

## Fitur

---

1. WebUI dihapus, pemutaran file audio menggunakan 'afplay' di MacOS dan 'cmdmp3win' di Windows10. 
2. Berinteraksi dengan WaifuContainer, meletakkan waifu virtual di desktop kamu untuk menemani saat coding.

## Catatan Paket Suara

---

~~~~
beberapa catatan untuk kustomisasi paket suara atau menggunakan paket suara dari internet
~~~~

1. gunakan 'contributes.json' bukan 'manifest.json'.
2. tambahkan teks di 'contributes.json' untuk mencocokkan konten suara.

~~~~javascript
"contributes": [
    {
        "keywords": ["function", "=>", "func ", "def "],
        "voices":[
            "function_01.mp3",
            "function_02.mp3",
            "function_03.mp3"
        ],
        "texts":[
            "Wao, fungsi callback kamu keren banget ya!",
            "Bagaimana kalau nama fungsi ini pakai nama aku?",
            "Sekeren apapun fungsi, nggak bisa menjalankan rasa sukaku padamu!"
        ]
    }
]
~~~~

## Dukung Saya

---

Jika ekstensi ini membuat kegiatan programming kamu lebih menyenangkan, boleh minta traktir cola?

![](https://raw.githubusercontent.com/ezshine/vscode-rainbow-fart-waifu/master/resources/donate.jpg)


**Selamat menikmati!**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---