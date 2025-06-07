<img src=".github/splash.png" alt="Tauri" />

[![status](https://img.shields.io/badge/status-stable-blue.svg)](https://github.com/tauri-apps/tauri/tree/dev)
[![License](https://img.shields.io/badge/License-MIT%20or%20Apache%202-green.svg)](https://opencollective.com/tauri)
[![test core](https://img.shields.io/github/actions/workflow/status/tauri-apps/tauri/test-core.yml?label=test%20core&logo=github)](https://github.com/tauri-apps/tauri/actions/workflows/test-core.yml)
[![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri.svg?type=shield)](https://app.fossa.com/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri?ref=badge_shield)
[![Chat Server](https://img.shields.io/badge/chat-discord-7289da.svg)](https://discord.gg/SpmNs4S)
[![website](https://img.shields.io/badge/website-tauri.app-purple.svg)](https://tauri.app)
[![https://good-labs.github.io/greater-good-affirmation/assets/images/badge.svg](https://good-labs.github.io/greater-good-affirmation/assets/images/badge.svg)](https://good-labs.github.io/greater-good-affirmation)
[![support](https://img.shields.io/badge/sponsor-Open%20Collective-blue.svg)](https://opencollective.com/tauri)

## المقدمة

تاوري هو إطار عمل لبناء ملفات تنفيذية صغيرة وسريعة للغاية لجميع أنظمة سطح المكتب الرئيسية. يمكن للمطورين دمج أي إطار عمل للواجهة الأمامية يتم تحويله إلى HTML وJS وCSS لبناء واجهة المستخدم الخاصة بهم. أما الواجهة الخلفية للتطبيق فهي ملف تنفيذي مكتوب بلغة Rust مع واجهة برمجة تطبيقات (API) يمكن للواجهة الأمامية التفاعل معها.

تستفيد واجهة المستخدم في تطبيقات تاوري حالياً من مكتبة [`tao`](https://docs.rs/tao) لإدارة النوافذ على أنظمة macOS وWindows وLinux وAndroid وiOS. ولعرض تطبيقك، يستخدم تاوري مكتبة [WRY](https://github.com/tauri-apps/wry)، وهي مكتبة توفر واجهة موحدة لعرض صفحات الويب من خلال النظام، معتمدة على WKWebView في macOS وiOS، وWebView2 في Windows، وWebKitGTK في Linux، وAndroid System WebView في Android.

للمزيد من التفاصيل حول كيفية ترابط هذه المكونات معاً، يرجى مراجعة هذا المستند: [ARCHITECTURE.md](https://github.com/tauri-apps/tauri/blob/dev/ARCHITECTURE.md).

## البدء

إذا كنت مهتماً بإنشاء تطبيق تاوري، يرجى زيارة [موقع التوثيق](https://tauri.app).

أسرع طريقة للبدء هي تثبيت [المتطلبات الأساسية](https://v2.tauri.app/start/prerequisites/) لنظامك وإنشاء مشروع جديد باستخدام [`create-tauri-app`](https://github.com/tauri-apps/create-tauri-app/#usage). على سبيل المثال باستخدام `npm`:

```sh
npm create tauri-app@latest
```

## الميزات

تشمل قائمة ميزات تاوري، على سبيل المثال لا الحصر:

- أداة تجميع تطبيقات مدمجة لإنشاء حزم تطبيقات بصيغ مثل `.app`، `.dmg`، `.deb`، `.rpm`، `.AppImage` ومثبتات Windows مثل `.exe` (عن طريق NSIS) و`.msi` (عن طريق WiX).
- محدّث ذاتي مدمج (سطح المكتب فقط)
- أيقونات في صينية النظام
- إشعارات أصلية
- بروتوكول WebView أصلي (تاوري لا ينشئ خادماً محلياً http(s) لعرض محتوى WebView)
- إجراء GitHub مبسط للتكامل المستمر
- إضافة VS Code

### الأنظمة المدعومة

يدعم تاوري حالياً التطوير والتوزيع على الأنظمة التالية:

| النظام      | الإصدارات                                                                                                   |
| :---------- | :---------------------------------------------------------------------------------------------------------- |
| Windows     | 7 فأعلى                                                                                                     |
| macOS       | 10.15 فأعلى                                                                                                |
| Linux       | webkit2gtk 4.0 لتاوري v1 (مثال: Ubuntu 18.04). webkit2gtk 4.1 لتاوري v2 (مثال: Ubuntu 22.04).              |
| iOS/iPadOS  | 9 فأعلى                                                                                                     |
| Android     | 7 فأعلى (حالياً 8 فأعلى)                                                                                   |

## المساهمة

قبل أن تبدأ بالعمل على شيء ما، من الأفضل التأكد من عدم وجود مشكلة (issue) قائمة بالفعل. من الجيد أيضاً زيارة خادم Discord والتأكد مع الفريق إذا كان ذلك منطقياً أو إذا كان شخص آخر يعمل عليه بالفعل.

يرجى التأكد من قراءة [دليل المساهمة](./.github/CONTRIBUTING.md) قبل تقديم طلب سحب (pull request).

شكراً لكل من يساهم في تاوري!

### التوثيق

يعد التوثيق في نظام متعدد اللغات أمراً معقداً. ولهذا السبب، نفضل استخدام التوثيق المضمن في شيفرة Rust وJS قدر الإمكان. اطلع على مستودع استضافة موقع التوثيق لمزيد من المعلومات: <https://github.com/tauri-apps/tauri-docs>

## الشركاء

<table>
  <tbody>
    <tr>
      <td align="center" valign="middle">
        <a href="https://crabnebula.dev" target="_blank">
          <img src=".github/sponsors/crabnebula.svg" alt="CrabNebula" width="283">
        </a>
      </td>
    </tr>
  </tbody>
</table>

للاطلاع على القائمة الكاملة للجهات الراعية يرجى زيارة [الموقع الإلكتروني](https://tauri.app#sponsors) و[Open Collective](https://opencollective.com/tauri).

## المنظمة

يهدف تاوري إلى أن يكون مجموعة مستدامة تستند إلى مبادئ توجه [مجتمعات البرمجيات الحرة والمفتوحة المصدر المستدامة](https://sfosc.org). ولهذا الغرض أصبح برنامجاً ضمن [Commons Conservancy](https://commonsconservancy.org/)، ويمكنك المساهمة مالياً عبر [Open Collective](https://opencollective.com/tauri).

## التراخيص

الشفرة: (c) 2015 - الحاضر - برنامج تاوري ضمن The Commons Conservancy.

MIT أو MIT/Apache 2.0 حيثما ينطبق.

الشعار: CC-BY-NC-ND

- تصاميم الشعار الأصلي لتاوري من قبل [Alve Larsson](https://alve.io/)، [Daniel Thompson-Yvetot](https://github.com/nothingismagick) و[Guillaume Chau](https://github.com/akryum)

[![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri.svg?type=large)](https://app.fossa.com/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri?ref=badge_large)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---