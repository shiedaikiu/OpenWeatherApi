# Answers to Technical Questions

## 🕒 How much time did you spend on this task?

تقریباً 4 ساعت برای طراحی معماری API، ادغام با سرویس OpenWeatherMap، مدیریت پیکربندی به صورت ایمن، نوشتن کد تمیز و قابل تست و ایجاد یک نمونه تست واحد بود.

اگر وقت بیشتری داشتم، موارد زیر را انجام می‌دادم:

افزودن حافظه پنهان (مثلاً استفاده از IMemoryCache یا Redis) برای کاهش فراخوانی‌های API.

اضافه کردن تست‌های یکپارچه‌سازی برای پاسخ‌های واقعی API.

بهبود مدیریت خطا و ثبت وقایع با لاگ‌های ساختاریافته (مثلاً Serilog).

استفاده از الگوی CQRS و Mediator برای مقیاس‌پذیری و تفکیک بهتر مسائل.

---

## 💡 What is the most useful feature recently added to your favorite programming language?

زبان مورد علاقه من **C#** است و یکی از مفیدترین ویژگی‌های اخیر، کلمه کلیدی **`required`** است (که در C# 11 معرفی شد).  
این ویژگی الزام می‌کند که ویژگی‌های یک شیء حتماً هنگام ایجاد مقداردهی شوند و بدون نیاز به سازنده اضافی، از ناسازگاری داده‌ها جلوگیری می‌کند.

---

## ⚙️ How do you identify and diagnose a performance issue in a production environment?

- پیدا کردن بخش کند با استفاده از ابزارهایی مانند **Application Insights** یا **New Relic** برای دیدن اینکه کدام API یا پرس‌وجو کند است.
- بررسی **لاگ‌ها و ردیابی‌ها** تا ببینیم هر درخواست از کجا شروع شده و در کدام بخش کند شده است.
- استفاده از **پروفایلرهایی** مانند `dotTrace` یا `BenchmarkDotNet` برای شناسایی متدها یا پرس‌وجوهای سنگین.
- بهینه‌سازی **پرس‌وجوهای پایگاه داده** یا اضافه کردن **ایندکس‌ها**.
- بهبود **منطق ناهمگام** یا افزودن **کشینگ** برای افزایش کارایی.

---

## 📚 What’s the last technical book you read or technical conference you attended?

آخرین کتاب فنی که خواندم **«C# 14 in Depth» نوشته‌ی جان اسکیت** بود.  
این کتاب کمک کرد تا ویژگی‌های جدید و مدرن سی‌شارپ مثل **الگوها (pattern matching)**، **رکوردها (records)** و **جریان‌های ناهمگام (async streams)** را بهتر درک کنم.  
همچنین فهمیدم که هدف نسخه‌های جدید زبان، **ساده‌تر کردن کدنویسی** در عین **حفظ سازگاری با نسخه‌های قبلی** است.  
در این کتاب نکات خوبی برای نوشتن **کدهای تمیز، کوتاه و قابل نگهداری** یاد گرفتم و بعضی از آن‌ها را در همین پروژه به کار بردم.

---

## 💬 What’s your opinion about this technical test?

به نظرم این آزمون فنی خیلی خوب بالانس داره.
هم مهارت‌های عملی برنامه‌نویسی رو می‌سنجه، هم روی کدنویسی تمیز تمرکز داره.
به نظرم واقعی و کاربردیه، چون دقیقا شبیه کاراییه که تو پروژه‌های واقعی انجام می‌دیم.
از طرفی هم خوب نشون می‌ده که طرف چقدر تو کار با API، تست واحد و معماری نرم‌افزار تو .NET مهارت داره.

---

## 👤 Please describe yourself using JSON format

```json
{
  "name": "Sheida Anbari",
  "role": "Software Developer",
  "specialization": [
    "Clean Architecture",
    "CQRS and Mediator Pattern",
    ".NET Core Backend Development",
    "SQL Optimization"
  ],
  "experienceYears": 5,
  "favoriteLanguage": "C#",
  "principles": [
    "Clean Code",
    "Test Driven Development",
    "SOLID",
    "Continuous Improvement"
  ],
  "interests": ["API Design", ".Net Core", "System Optimization"],
  "personality": {
    "traits": ["Analytical", "Curious", "Detail-Oriented", "Collaborative"]
  }
}
```

