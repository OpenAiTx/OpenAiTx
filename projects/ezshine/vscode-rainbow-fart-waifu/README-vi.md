# 🌈 Rainbow Fart Waifu
![](https://s1.ax1x.com/2020/08/21/dNvHfS.gif)

Trang web：[https://rfw.jnsii.com](https://rfw.jnsii.com/index_en.html)

Ngôn ngữ: [简体中文](./README.zh.md) | English

## Tóm tắt

----

Ý tưởng của extension này đến từ [@SaekiRaku](https://github.com/SaekiRaku/vscode-rainbow-fart), viết lại toàn bộ mã nguồn. Tương thích với tất cả các gói giọng nói, đồng thời thêm một số tính năng mới.

## Lời cảm ơn đặc biệt

---

1. Extension bao gồm gói giọng nói tiếng Trung của [@justkowalski](https://github.com/JustKowalski). Bạn có thể [tải thêm các gói giọng nói từ github](https://github.com/topics/rainbow-fart) 
2. Extension bao gồm cmdmp3win.exe, từ [@James K. Lawless](http://jiml.us) 
3. Mô hình waifu mặc định từ [@二夏](https://erxia207.lofter.com), nếu bạn muốn thiết kế một waifu chỉ riêng cho mình, hãy liên hệ với cô ấy. 
4. Extension còn bao gồm một mô hình waifu khác tên keysoban, mã nguồn mở bởi [@DenchiSoft](https://twitter.com/DenchiSoft/status/1036017773011525632).

[Tải thêm mô hình Waifu](https://github.com/ezshine/live2d-model-collections)

## Nền tảng hỗ trợ

---

~~~~
Chỉ hỗ trợ MacOS và Windows10
~~~~

## Hỏi & Đáp

---

#### _Waifu không hiển thị?_
> Đ: Bạn cần [tải về](https://github.com/ezshine/live2d-model-collections) container waifu. Sau khi giải nén toàn bộ file zip, chạy liv2dplayer.exe, gọi danh sách lệnh trong vscode, thử chuyển đổi mô hình waifu.

## Hướng dẫn sử dụng, Lệnh

---

🌈 Hiển thị lệnh Rainbow Fart Waifu

- "Chuyển đổi gói giọng nói"
- "Chuyển đổi mô hình Waifu"
- "Mở thư mục tài nguyên"

> Nếu bạn tải về gói giọng nói hoặc gói mô hình, bạn cần dùng lệnh này để mở thư mục tài nguyên và chuyển các gói đó vào đường dẫn này

- "Tải container Waifu và thêm tài nguyên"

## Tính năng

---

1. Đã loại bỏ WebUI, phát file âm thanh bằng 'afplay' trên MacOS và 'cmdmp3win' trên Windows10. 
2. Tương tác với WaifuContainer, đưa một waifu ảo lên desktop để đồng hành cùng lập trình của bạn.

## Lưu ý về VoicePackage

---

~~~~
Một số lưu ý khi tự tạo hoặc sử dụng gói giọng nói tải từ Internet
~~~~

1. Sử dụng 'contributes.json' thay vì 'manifest.json'.
2. Thêm texts trong 'contributes.json' để khớp với nội dung giọng nói.

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
            "Wow, callback của bạn viết hay quá!",
            "Đặt tên hàm này theo tên mình thì sao nhỉ?",
            "Hàm có mạnh mẽ đến đâu cũng không thể diễn tả hết tình cảm mình dành cho bạn!"
        ]
    }
]
~~~~

## Ủng hộ tôi

---

Nếu extension này giúp bạn lập trình vui vẻ hơn, bạn có thể mời tôi một lon coca không?

![](https://raw.githubusercontent.com/ezshine/vscode-rainbow-fart-waifu/master/resources/donate.jpg)
**Thưởng thức!**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---