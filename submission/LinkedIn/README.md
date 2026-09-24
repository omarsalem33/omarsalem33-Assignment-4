# C# Technical LinkedIn Posts

---

## 📌 LinkedIn Post 1 — ref vs out

الفرق بين ref and out in C#

في بعض الأوقات بنكون عايزين نبعت variables لـ method معينه وهنكون محتاجين التعديل ال هيتعمل ده يكون علي variables نفسها.
فا يجيلك حد يقولك ابعت reference للـ variables.

في C# في حاجتين بيبعتوا reference:
**ref Vs out**

ايه الفرق بين الاتنين بقا؟

### 1- ref

بنسخدم ref لما أكون عايز ابعت variables لـ method عشان اعدل قيمته أو أستخدمها.

- فا معني كدا انه لازم يكون متخزن جوه قيمة قبل ما ابعته والا هيضرب معاك error.
- برضو الـ method مش لازم تعدل علي قيمة الـ variable ممكن تستخدمه بس عادي.
- ممكن يكون لي افاده امتي؟ لما أكون عايز اعمل swap بين متغيرين.

```csharp
void Swap(ref int x, ref int y)
{
    int temp = x;
    x = y;
    y = temp;
}

int a = 5, b = 10;
Swap(ref a, ref b);

```

[LinkedIn Post](https://lnkd.in/p/eatZHW6G)
