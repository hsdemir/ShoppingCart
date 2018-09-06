# ShoppingCart
Shopping Cart Demo Web Projesi<br>

-Proje Amacı<br>
•	Proje genel olarak belli kategorilere ait ürünlerin seçilerek, sepete eklenmesi ve tanımlı olan kampanyalar ve kuponları kriterlere göre uygulayarak fiyat indirimi uygulanmasını sağlar.<br>
•	İstenen kriterlere göre teslimat tutarları hesaplanarak sepet ve ödeme bilgilerini ekrana yazdırır.<br>

-Kabul Kriterleri<br>
•	Ürünün bir başlığı ve fiyatı vardır.<br>
•	Ürün bir kategoriye aittir.<br>
•	Kategori bir üst kategoriye sahip olabilir veya olmayabilir.<br>
•	Kategorinin bir başlığı vardır.<br>
•	Ürünler sepete miktar bilgisi ile eklenir.<br>
•	Ürün fiyat indirimleri için kampanyalar vardır.<br>
•	Kampanyalar bir ürün kategorisine uygulanabilir.<br>
•	Kampanya indirimi, alışveriş sepetindeki ürün sayısına göre değişir.<br>
•	Kuponların minimum alışveriş sepeti tutarı kısıtlaması vardır. Alışveriş sepeti tutarı minimumdan az ise indirim uygulanmaz.<br>
•	Teslimat maliyeti dinamiktir. Teslimatların sayısına ve ürün sayısına göre.<br>

-İndirimler<br>
• Kampanyala tanımlı kategorilere göre uygulanmalıdır.<br>
•	Bir kategoride 3 ten fazla ürün alınırsa 20% indirim uygulanabilir.<br>
•	Başka bir kampanya kuralı, 5 ten fazla ürün alındığında bir kategoride 50% tutarında indirim uygulanır.<br>
•	Başka bir kampanya kuralı, 5 ten fazla ürün alındığında her bir ürün için 5TL tutarında indirim uygulanır.<br>
•	Sepet, maksimum indirim miktarını sepete uygulamalıdır.<br>
•	Sepete kupon da uygulanabilir.<br>
•	Sepetin toplam tutarı minimum tutardan düşükse, kupon geçerli değildir.<br>
•	Minimum 100 TL lik alışveriş için 10% indirim eklenebilir.<br>
•	İlk önce kampanya indirimleri uygulanır, ardından kuponlar.<br>

-Teslimat<br>
•	Alışveriş sepetindeki teslimat sayısına ve ürün sayısına göre dinamik kargo fiyatlandırma kuralları uygulanır.<br>
•Sepetteki farklı ürünlerin sayısına ve farklı kategorilerin sayısına göre teslimat tutarı hesaplanır.<br>
•Kategori başına teslimat tutarı : 1.25 TL<br>
•Ürün başına teslimat tutarı : 0.75 TL<br>
•Sabit Tutar : 2.99 TL<br>

-Teknik Özellikler<br>
•OOP,<br>
•SOLID Principles,<br>
•Design Patterns(Singleton)<br>
Dependency Injection (Autofac | Singleton Instance)<br>

