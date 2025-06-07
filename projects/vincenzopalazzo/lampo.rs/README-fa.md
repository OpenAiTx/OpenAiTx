<div align="center">
  <h1>لامپو</h1>

  <img src="https://github.com/saradurante/lampo.docs/blob/dc0dce971c3052f0e9dd668fdf0c7376b12fee7b/imgs/web/icon-512.png?raw=true"  width="150" height="150" />


  <p>
    <strong>پیاده‌سازی سریع و ماژولار شبکه لایتنینگ برای همه کاربردها، نوشته‌شده با راست.</strong>
  </p>

  <h4>
    <a href="https://lampo.devcrew.cc">صفحه اصلی پروژه</a>
  </h4>
</div>

## کرِیت‌ها

این لیست کامل کرِیت‌هایی است که در حال حاضر پشتیبانی می‌شوند:

| کرِیت         | توضیحات                                      | نسخه        |
|:--------------|:---------------------------------------------:|------------:|
| lampod-cli    | رابط خط فرمان Lampo Daemon برای اجرای دیمون   | _غیرمرتبط_  |
| lampo-cli     | رابط خط فرمان ساده Lampo برای تعامل با دیمون  | _غیرمرتبط_  |

## روش نصب

برای نصب تمام پیش‌نیازها و باینری Lampo، باید rust نصب باشد و سپس فرمان زیر را اجرا کنید:

```
make install
```

پس از در دسترس بودن `lampod-cli` و `lampo-cli` می‌توانید فرمان زیر را برای اجرای Lampo در حالت signet اجرا کنید:

```
➜  ~ lampod-cli --network signet
✓ کیف پول ایجاد شد، لطفاً این کلمات را به صورت ایمن ذخیره کنید
 wallet-keys  maple have fitness decide food joy flame coast stereo front grab stumble
```

>[!NOTE]
کلمات کیف پول خود را ذخیره کنید و سپس برای بازیابی کیف پول با `--restore-wallet` از آن‌ها استفاده کنید.
اگر کلمات خود را جایی ذخیره نکنید، در اجرای بعدی Lampo دارایی‌های شما از دست خواهند رفت!

لطفاً توجه داشته باشید که باید یک فایل `lampo.conf` در مسیر `~/.lampo/signet` داشته باشید. برای استفاده از فایل پیکربندی نمونه، فرمان زیر را اجرا کنید:

```
cp lampo.example.conf ~/.lampo/signet/lampo.conf
```

سپس می‌توانید با فرمان زیر از نود پرس‌وجو کنید:

``` 
➜  ~ lampo-cli --network signet getinfo
{
  "node_id": "035b889551a44e502cd0cd6657acf067336034986cd6639b222cd4be563a7fc205",
  "peers": 0,
  "channels": 0
}
```

### برای اجرای تست‌های یکپارچه با Core Lightning:

اطمینان حاصل کنید که core-lightning را در حالت توسعه‌دهنده کامپایل کرده‌اید. راهنمای نصب را می‌توانید [اینجا](https://docs.corelightning.org/docs/installation) بیابید.

تست‌های یکپارچه با فرمان زیر قابل اجرا هستند:

```
make integration
```

## راهنمای مشارکت

لطفاً [راهنمای مشارکت](https://raw.githubusercontent.com/vincenzopalazzo/lampo.rs/main/CONTRIBUTING.md) ما را مطالعه کنید.

## جامعه

برای حفظ شفافیت، کانال‌های خاصی برای ارتباط انتخاب کرده‌ایم:
- توسعه‌دهندگان، به [Zulip](https://lampo-dev.zulipchat.com/) بپیوندید.
- اعضای جامعه، [جامعه توییتر ما](https://twitter.com/i/communities/1736414802849706087) منتظر دیدگاه‌های شماست.
- برای سؤالات فنی و درخواست ویژگی‌ها، به بحث‌های گیت‌هاب ما مراجعه کنید.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---