# نسخه 1.5.1 PSFree

PSFree مجموعه‌ای از اکسپلویت‌ها برای کنسول PS4 است. تمرکز اصلی این مخزن بر روی PS4 است، اما سعی داریم قابلیت حمل به PS5 را نیز فراهم کنیم.

## ویژگی‌ها

- **تشخیص خودکار:** به طور خودکار نوع کنسول و نسخه فریمور را تشخیص می‌دهد (از طریق [`src/config.mjs`](https://raw.githubusercontent.com/Al-Azif/psfree-lapse/main/src/config.mjs)).
- **اکسپلویت WebKit (PSFree):** نقطه ورود از طریق مرورگر وب کنسول.
- **اکسپلویت کرنل (Lapse):** ارتقای سطح دسترسی تا سطح کرنل.
- **لودر پیلود:** پس از موفقیت‌آمیز بودن اکسپلویت کرنل، در پورت 9020 منتظر دریافت پیلود می‌ماند.

## دامنه آسیب‌پذیری

|               | PSFree    | Lapse      |
| :------------ | :-------- | :--------- |
| PlayStation 4 | 6.00-9.60 | 1.01-12.02 |
| PlayStation 5 | 1.00-5.50 | 1.00-10.01 |

## پشتیبانی‌شده توسط این مخزن

این جدول نسخه‌های فریموری را نشان می‌دهد که _نسخه فعلی_ این مخزن زنجیره اکسپلویت کاربردی و تست شده‌ای برای آن‌ها فراهم می‌کند.

|               | PSFree    | Lapse     |
| :------------ | :-------- | :-------- |
| PlayStation 4 | 7.00-9.60 | 7.00-9.60 |
| PlayStation 5 | N/A       | N/A       |

_توجه: پشتیبانی از سایر فریمورها که در جدول "دامنه آسیب‌پذیری" ذکر شده‌اند ممکن است در حال حاضر در دست کار باشد یا در نسخه‌های قبلی این مخزن پشتیبانی شده باشد. لطفاً برای مشاهده پشتیبانی تاریخی [`CHANGELOG.md`](https://raw.githubusercontent.com/Al-Azif/psfree-lapse/main/CHANGELOG.md) را بررسی کنید._

## فهرست TODO

- [ ] مشکل صفحه سیاه/ذخیره با برخی بازی‌ها
- [ ] `lapse.mjs`: فقط بیت‌های مجوز JIT را تنظیم کند
- [ ] `view.mjs`: فرض بر PS4 است، از PS5 نیز پشتیبانی شود
- [ ] افزودن پشتیبانی از PS5

## حق نشر و نویسندگان:

AGPL-3.0-or-later (مشاهده [LICENSE](https://raw.githubusercontent.com/Al-Azif/psfree-lapse/main/LICENSE)). این مخزن متعلق به گروه `anonymous` است. به مشارکت‌کنندگان ناشناس نیز با عنوان "anonymous" اشاره می‌کنیم.

## تقدیر و تشکر:

- anonymous بابت دامپ‌های کرنل فریمور PS4
- برای مشاهده مشارکت‌کنندگان **اضافی**، فایل‌های مربوطه را بررسی کنید. مگر اینکه خلاف آن ذکر شده باشد، همه چیز در اینجا نیز به ما نسبت داده می‌شود.

## کمک‌های مالی

(مونرو/XMR): **86Fk3X9AE94EGKidzRbvyiVgGNYD3qZnuKNq1ZbsomFWXHYm6TtAgz9GNGitPWadkS3Wr9uXoT29U1SfdMtJ7QNKQpW1CVS**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---