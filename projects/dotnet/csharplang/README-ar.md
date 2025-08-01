# تصميم لغة #C

[![انضم إلى الدردشة على https://gitter.im/dotnet/csharplang](https://badges.gitter.im/dotnet/csharplang.svg)](https://gitter.im/dotnet/csharplang?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge) [![الدردشة على Discord](https://discordapp.com/api/guilds/143867839282020352/widget.png)](https://aka.ms/dotnet-discord-csharp)

مرحبًا بك في المستودع الرسمي لتصميم لغة #C. هنا يتم تطوير، اعتماد، وتحديد ميزات لغة #C الجديدة.

يتم تصميم #C من قبل فريق تصميم لغة #C (LDT) بالتنسيق الوثيق مع مشروع [Roslyn](https://github.com/dotnet/roslyn)، الذي ينفذ اللغة.

يمكنك العثور على:

- مقترحات ميزات لغة #C النشطة في [مجلد المقترحات](proposals)
- ملاحظات اجتماعات تصميم لغة #C في [مجلد الاجتماعات](meetings)
- ملخص [تاريخ إصدار اللغة هنا](Language-Version-History.md).

إذا اكتشفت أخطاء أو نواقص فيما سبق، يرجى ترك قضية لرفعها، أو الأفضل من ذلك: طلب سحب لإصلاحها.

أما بالنسبة لـ *مقترحات الميزات الجديدة*، فيرجى طرحها للنقاش أولًا عبر [المناقشات](https://github.com/dotnet/csharplang/labels/Discussion)، و*فقط* قدم المقترح كقضية أو طلب سحب إذا تمت دعوتك للقيام بذلك من قبل أحد أعضاء فريق تصميم اللغة (ما يُسمى بـ"البطل").

عملية التصميم الكاملة موصوفة [هنا](Design-Process.md). نظرة عامة مختصرة أدناه.

## المناقشات

يتم النقاش حول ميزات اللغة في شكل [مناقشات](https://github.com/dotnet/csharplang/discussions) في هذا المستودع.

إذا كنت ترغب في اقتراح ميزة، أو مناقشة ملاحظات التصميم الحالية أو المقترحات، إلخ، يرجى [فتح موضوع مناقشة جديد](https://github.com/dotnet/csharplang/discussions/new).

المناقشات القصيرة والتي تظل ضمن الموضوع أكثر عرضة للقراءة. إذا تركت التعليق رقم خمسين، فغالبًا لن يقرأه سوى عدد قليل من الأشخاص. لجعل المناقشات أسهل في التصفح وأكثر فائدة، يرجى مراعاة بعض القواعد:

- يجب أن تكون المناقشة ذات صلة بتصميم لغة #C. إذا لم تكن كذلك، سيتم إغلاقها مباشرة.
- اختر موضوعًا وصفيًا يوضح بوضوح نطاق المناقشة.
- التزم بموضوع النقاش. إذا كان التعليق جانبيًا أو يتعمق في موضوع فرعي، ابدأ مناقشة جديدة واربطها بالأصل.
- هل تعليقك مفيد للآخرين لقراءته، أم يمكن التعبير عنه بشكل كافٍ برمز تعبيري على تعليق موجود؟

يمكن تحقيق المقترحات التي تمنع حدوث صياغة معينة عبر [محلل Roslyn](https://docs.microsoft.com/visualstudio/extensibility/getting-started-with-roslyn-analyzers). المقترحات التي تجعل بعض الصياغات الحالية محظورة اختياريًا فقط سيتم رفضها من قبل لجنة تصميم اللغة لتجنب زيادة تعقيد اللغة.

## المقترحات

عندما يجد أحد أعضاء LDM للغة #C أن مقترحًا يستحق النظر من قبل الفريق الأوسع، يمكنه [تبنيه كبطل](https://github.com/dotnet/csharplang/issues?q=is%3Aopen+is%3Aissue+label%3A%22Proposal+champion%22)، أي أنه سيطرحه في اجتماع تصميم لغة #C. تتم مناقشة المقترحات دائمًا في المناقشات المرتبطة، وليس في قضية البطل نفسها. لم نتبع هذه السياسة دائمًا، لذا ستجد أن العديد من قضايا البطل تحتوي على مناقشات؛ نحن الآن نقوم بإغلاق القضايا لمنع حدوث مناقشة جديدة عليها. كل قضية بطل سيكون بها رابط للمناقشة.

## عملية التصميم

تتطور [المقترحات](proposals) نتيجة قرارات تُتخذ في [اجتماعات تصميم اللغة](meetings)، والتي تستند إلى [المناقشات](https://github.com/dotnet/csharplang/discussions)، والتجارب، والعمل التصميمي غير المتصل.

في كثير من الحالات، سيكون من الضروري تنفيذ ومشاركة نموذج أولي للميزة للوصول إلى التصميم الصحيح، وفي النهاية اتخاذ قرار بشأن اعتماد الميزة. تساعد النماذج الأولية في اكتشاف مشكلات التنفيذ وقابلية الاستخدام للميزة. يجب تنفيذ النموذج الأولي في تفرع من [مستودع Roslyn](https://github.com/dotnet/roslyn) وأن يفي بالمعايير التالية:

- يجب أن يكون التحليل النحوي (إن أمكن) مرنًا للتجارب: يجب ألا يؤدي الكتابة إلى أعطال.
- تضمين اختبارات دنيا توضح عمل الميزة من البداية للنهاية.
- تضمين دعم بيئة تطوير متكاملة (IDE) بالحد الأدنى (تلوين الكلمات الرئيسية، التنسيق، الإكمال).

بمجرد الموافقة، يجب تنفيذ الميزة بالكامل في [Roslyn](https://github.com/dotnet/roslyn)، وتحديدها بالكامل في [مواصفة اللغة](spec)، ثم يتم نقل المقترح إلى المجلد المناسب للميزات المكتملة، مثل [مقترحات #C 7.1](proposals/csharp-7.1).

**إخلاء المسؤولية**: المقترح النشط هو قيد النظر الفعلي للإدراج في إصدار مستقبلي من لغة البرمجة #C، ولكن لا يوجد أي ضمان لإدراجه في الإصدار التالي أو أي إصدار لاحق من اللغة. قد يتم تأجيل أو رفض المقترح في أي وقت خلال أي مرحلة من المراحل المذكورة أعلاه بناءً على ملاحظات فريق التصميم أو المجتمع أو مراجعي الكود أو الاختبار.

### المعالم الرئيسية

لدينا عدة معالم مختلفة للقضايا في المستودع:
* [مجموعة العمل](https://github.com/dotnet/csharplang/milestone/19) هي مجموعة المقترحات التي تم تبنيها كبطل ويتم العمل عليها بنشاط حاليًا. ليس كل شيء في هذا المعلم سيظهر في الإصدار التالي من #C، لكنه سيحصل على وقت تصميم خلال الإصدار القادم.
* [قائمة الانتظار](https://github.com/dotnet/csharplang/milestone/10) هي مجموعة المقترحات التي تم تبنيها كبطل وتم تصنيفها، ولكن لا يتم العمل عليها بنشاط. بينما يُرحب بالنقاش والأفكار من المجتمع حول هذه المقترحات، فإن تكلفة العمل التصميمي والمراجعة البرمجية لهذه الميزات عالية جدًا بحيث لا يمكننا النظر في تنفيذها من قبل المجتمع حتى نكون مستعدين لذلك.
* [في أي وقت](https://github.com/dotnet/csharplang/milestone/14) هي مجموعة المقترحات التي تم تصنيفها وليست قيد العمل النشط ومفتوحة لتنفيذ المجتمع. يمكن أن تكون القضايا هنا في إحدى حالتين: تحتاج إلى مواصفة معتمدة، وتحتاج إلى تنفيذ. تلك التي تحتاج إلى مواصفة يجب عرضها خلال اجتماع LDM لاعتماد المواصفة، لكننا مستعدون لأخذ الوقت للقيام بذلك عند أول فرصة مناسبة.
* [من المحتمل ألا تُعتمد أبدًا](https://github.com/dotnet/csharplang/milestone/13) هي مجموعة المقترحات التي رفضها LDM من اللغة. بدون حاجة قوية أو ملاحظات من المجتمع، لن يتم النظر في هذه المقترحات في المستقبل.
* المعالم المرقمة هي مجموعة الميزات التي تم تنفيذها لذلك الإصدار من اللغة. بالنسبة للمعالم المغلقة، هذه هي الأشياء التي صدرت مع ذلك الإصدار. بالنسبة للمعالم المفتوحة، يمكن سحب الميزات لاحقًا إذا اكتشفنا مشكلات توافق أو غيرها مع اقتراب الإصدار.

## اجتماعات تصميم اللغة

تعقد اجتماعات تصميم اللغة (LDMs) من قبل LDT وضيوف مدعوين أحيانًا، ويتم توثيقها في ملاحظات اجتماعات التصميم في [مجلد الاجتماعات](meetings)، مرتبة في مجلدات حسب السنة. تم وصف دورة حياة ملاحظة اجتماع التصميم في [meetings/README.md](meetings/README.md). في اجتماعات LDM تتخذ قرارات حول إصدارات #C المستقبلية، بما في ذلك المقترحات التي سيجري العمل عليها، وكيفية تطويرها، وما إذا كان سيتم تبنيها ومتى.

## مواصفة اللغة

يمكن العثور على المواصفة الحالية ECMA-334 في صيغة Markdown على مستودع [معيار لغة #C](https://github.com/dotnet/csharpstandard/).

## التنفيذ

يمكن العثور على التنفيذ المرجعي للغة #C في [مستودع Roslyn](https://github.com/dotnet/roslyn). كما يتتبع هذا المستودع [حالة تنفيذ ميزات اللغة](https://github.com/dotnet/roslyn/blob/main/docs/Language%20Feature%20Status.md). حتى وقت قريب، كان هذا أيضًا مكان تتبع عناصر تصميم اللغة. يرجى السماح ببعض الوقت أثناء نقل المقترحات النشطة.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-15

---