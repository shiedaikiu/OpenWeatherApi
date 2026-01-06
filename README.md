این پروژه یک Web API مبتنی بر .NET 8 است که با استفاده از سرویس OpenWeatherMap اطلاعات محیطی یک شهر را بر اساس نام آن برمی‌گرداند.

✨ ویژگی‌ها

✔ دریافت موارد زیر بر اساس نام شهر:

🌡 دما (سلسیوس)

💧 رطوبت (درصد)

🌬 سرعت باد (m/s)

🏭 شاخص کیفیت هوا (AQI)

⚠ آلاینده‌های اصلی (PM2.5, PM10, CO, NO2, SO2, O3)

📍 موقعیت جغرافیایی (Latitude / Longitude)

✔ پیاده‌سازی تمیز و قابل نگهداری
✔ استفاده از DI و Service Layer
✔ دارای Unit Test
✔ مبتنی بر OpenWeatherMap API

🛠 پیش‌نیازها

برای اجرای پروژه نیاز دارید به:

.NET 8 SDK

یک API Key از سایت OpenWeatherMap
https://openweathermap.org/api

⚙️ تنظیم API Key

در فایل appsettings.json مقدار زیر را تنظیم کنید:

"OpenWeatherMap": {
  "ApiKey": "YOUR_API_KEY"
}


یا از Environment Variable استفاده کنید:

OpenWeatherMap__ApiKey=YOUR_API_KEY

🚀 اجرای پروژه
با CLI
dotnet restore
dotnet build
dotnet run

دسترسی به Swagger

پس از اجرا:

👉 http://localhost:5000/swagger

یا
👉 http://localhost:5100/swagger
 (در صورت استفاده از HTTPS)

📡 Endpoint
GET
/api/environment/{city}

مثال
/api/environment/Tehran

نمونه پاسخ
{
  "city": "Tehran",
  "latitude": 35.6892,
  "longitude": 51.389,
  "temperatureCelsius": 18.5,
  "humidity": 45,
  "windSpeed": 2.1,
  "airQualityIndex": 64,
  "pollutants": {
    "pm2_5": 12.4,
    "pm10": 20.1,
    "co": 0.3,
    "no2": 15.6,
    "so2": 4.2,
    "o3": 11.8
  }
}

🧪 Unit Tests

برای اجرای تست‌ها:

dotnet test


پوشش تست شامل:

✔ شبیه‌سازی پاسخ API
✔ بررسی رفتار در صورت عدم یافتن شهر
✔ پردازش JSON

🧱 معماری پروژه

پروژه شامل بخش‌های زیر است:

Controllers/
Services/
Models/

اصول رعایت‌شده

✔ Dependency Injection
✔ Clean Code
✔ جداسازی لایه‌ها
✔ تست‌پذیری بالا
