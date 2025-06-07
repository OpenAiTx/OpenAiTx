<div align="center">
  <h1>Lampo</h1>

  <img src="https://github.com/saradurante/lampo.docs/blob/dc0dce971c3052f0e9dd668fdf0c7376b12fee7b/imgs/web/icon-512.png?raw=true"  width="150" height="150" />


  <p>
    <strong>تنفيذ شبكة Lightning سريع ومرن لجميع الاستخدامات، مكتوب بلغة Rust.</strong>
  </p>

  <h4>
    <a href="https://lampo.devcrew.cc">الصفحة الرئيسية للمشروع</a>
  </h4>
</div>

## الحزم (Crates)

هذه هي القائمة الكاملة للحزم المدعومة حالياً:

| الحزمة       | الوصف                                   | الإصدار     |
|:------------|:---------------------------------------------:|------------:|
| lampod-cli  | واجهة سطر أوامر لخادم Lampo لتشغيل الخادم | _غير مرتبط_ |
| lampo-cli   | واجهة سطر أوامر بسيطة للتفاعل مع الخادم | _غير مرتبط_ |

## كيفية التثبيت

لتثبيت جميع المتطلبات وثنائية Lampo، تحتاج إلى
وجود rust مثبتاً، ثم تشغيل الأمر التالي:

```
make install
```

بعد توفر `lampod-cli` و `lampo-cli` لديك، يمكنك
تشغيل الأمر التالي لإطلاق Lampo في وضع signet:

```
➜  ~ lampod-cli --network signet
✓ تم إنشاء المحفظة، يرجى حفظ هذه الكلمات في مكان آمن
 wallet-keys  maple have fitness decide food joy flame coast stereo front grab stumble
```

>[!NOTE]
قم بحفظ كلمات محفظتك، ثم أعد استخدامها لاستعادة المحفظة باستخدام `--restore-wallet`.
إذا لم تقم بحفظ كلماتك في أي مكان، ستفقد أموالك في المرة القادمة التي يبدأ فيها Lampo!

يرجى ملاحظة أنك تحتاج إلى وجود ملف `lampo.conf` في المسار `~/.lampo/signet`. قم بتشغيل
الأمر التالي لاستخدام ملف الإعدادات التجريبي:

```
cp lampo.example.conf ~/.lampo/signet/lampo.conf
```

بعد ذلك يمكنك الاستعلام عن العقدة بالأمر التالي:

``` 
➜  ~ lampo-cli --network signet getinfo
{
  "node_id": "035b889551a44e502cd0cd6657acf067336034986cd6639b222cd4be563a7fc205",
  "peers": 0,
  "channels": 0
}
```

### لتشغيل اختبارات التكامل مع core lightning:

تأكد من أنك قمت بترجمة core-lightning في وضع المطور. يمكنك العثور على دليل التثبيت [هنا](https://docs.corelightning.org/docs/installation).

يمكنك تشغيل اختبارات التكامل باستخدام الأمر التالي:

```
make integration
```

## إرشادات المساهمة

يرجى قراءة [دليل المساهمة](https://raw.githubusercontent.com/vincenzopalazzo/lampo.rs/main/CONTRIBUTING.md).

## المجتمع

حرصاً على الوضوح، اخترنا قنوات محددة للتواصل:
- للمطورين، انضموا إلينا على [Zulip](https://lampo-dev.zulipchat.com/).
- لأعضاء المجتمع، [مجتمع تويتر الخاص بنا](https://twitter.com/i/communities/1736414802849706087) في انتظار آرائكم.
- للأسئلة التقنية وطلبات الميزات، شاركوا في مناقشاتنا على GitHub.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---