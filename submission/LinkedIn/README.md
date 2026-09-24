# C# Technical LinkedIn Posts

---

## 📌 LinkedIn Post 1 — ref vs out

الفرق بين ref and out in C#
في بعض الاوقات بنكون عايزين نبعت variables ل method معينه وهنكون محتاجين التعديل ال هيتعمل ده يكون علي variables
فا يجيلك حد يقولك ابعت reference لل variables
في C# في حاجتين بيبعتوا reference
ref Vs out
ايه الفرق بين الاتنين بقا
1- ref
بنسخدم ref لما أكون عايز ابعت variables ل method عشان اعدل قيمته
فا معني كدا انه لازم يكون متخزن جوه قيمه قبل ما ابعته والا هيضرب معاك error
برضو function مش لازم تعدل علي قميه variable ممكن تستخدمه بس عادي
ممكن يكون لي افاده امتي لما أكون عايز اعمل swap
2- out
بنسخدم out لما أكون عايز ارجع قميه للمكان ال اتعمل فيه method calling
ال method هنا ملزمه انها تحط قميه لل variable ومش شرط يكون في قيم متخزنه فيه زي ال ref
بنستخدمها لما تكون الmethod بتعمل عملية تحويل (زي TryParse) وعايز الmethod ترجعلك حالة العملية (bool) وفي نفس الوقت ترجعلك القيمة الناتجة.

[LinkedIn Post](https://lnkd.in/p/eatZHW6G)
