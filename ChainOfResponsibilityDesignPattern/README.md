<h1 align="center">Chain Of Responsibility</h1>
<h3 align="center">Sorumluluk Zinciri -Chain of Responsibility (CoR)- tasarım deseni (behavioral design patterns) davranışsal tasarım desenlerinden biridir. Davranışlar tasarım desenleri yazılım bileşenlerinin nasıl etkileşimde bulunacağını ve nasıl işbirliği yapacaklarını yöneten şablonlardır.</h3>

<br/>

<h2> Notlar :</h2>

- 🛠️ Gelen istek oluşturulan sıraya göre işleyicilere (handler) verilir ve eğer süreç bir işleyici tarafından sonlandırılmadıysa bir sonraki düğüm olmayana dek devam eder.
- 🛠️ Gerçek Hayattan Bir Örnek

- - Müşteri hizmetlerini aradığınızda sizi işlemleri sıralayarak ve sesli yanıt veya tuşlama ile ilgili kişiye ulaştırdığı senaryoda sorumluluk prensibi benzeri bir yapı işliyor. Çünkü sırayla kontroller sağlanarak eğer zincirin şuanki halkası isteğinizi karşılayabiliyorsa ona yönlendiriliyor eğer karşılayamıyorsa bir sonraki halkaya aktarılıyorsunuz ta ki isteğinizi karşılayabilecek yetkiliye ulaşana kadar.
