// Todo List (C#) Başlangıç Kısmı:
//
// Bu proje, C# ile geliştirilmiş basit bir “yapılacaklar listesi” (to-do list) uygulamasıdır. 
// Kullanıcıların görev eklemesine, bu görevleri listelemesine, tamamlamasına ve silmesine olanak tanır.
// Konsol tabanlı olduğu için hızlıca deneyimleyebilir ve iş mantığını basitçe görebilirsiniz.
//
// Nasıl Çalışır?
// 1. Program başlarken bir sonsuz döngü içerisine girer ve kullanıcıya bir menü sunar:
//      - Görev Ekle
//      - Görevleri Listele
//      - Görevi Tamamla
//      - Görev Sil
//      - Çıkış
// 2. Kullanıcı seçimi doğrultusunda ilgili metod (AddTask, ListTasks, CompleteTask, DeleteTask) çalıştırılır.
// 3. Görevler (TaskItem nesneleri) üzerinde çeşitli işlemler gerçekleştirilir:
//      - Eklenir, listelenir, tamamlanır veya silinir.
// 4. Eğer kullanıcı 5’i seçerse uygulamadan çıkılır.
----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- 
- Notlar ve Açıklamalar
// 1) Global List<TaskItem> tasks
//    - Uygulamadaki tüm görevleri saklar.
//    - Her yeni görev, 'tasks' listesine eklenir.
//
// 2) static int currentId
//    - Görev eklerken otomatik artan ID değeri sağlar.
//    - Her yeni görev oluşturulduğunda currentId bir artırılır.
//
// 3) int.TryParse(Console.ReadLine(), out int taskId)
//    - Kullanıcının girdiği değeri tamsayıya dönüştürmeye çalışır.
//    - Dönüştürme başarılı olursa taskId parametresine atanır ve true döndürür.
//    - Başarısız olursa taskId varsayılan değeri (0) alır ve false döndürür.
//
// 4) tasks.Find(t => t.Id == taskId)
//    - 'tasks' listesi içerisinde ID değeri 'taskId' eşleşen ilk elemanı döndürür.
//    - Bulunamazsa null döndürür.
//
// 5) task.IsCompleted
//    - Görevin tamamlanıp tamamlanmadığını gösterir.
//    - Kullanıcı tamamlandığını seçerse 'true' yapılır, listeye yansıtır.
//
// 6) tasks.Remove(task)
//    - Listeden ilgili 'task' nesnesini kaldırır.
//    - 'task' nesnesini kaldırdıktan sonra aynı ID ile yeni görev eklenmez.
//      (ID mantığı sadece artarak devam eder.)
// ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- 
// 5. Genişletme Fikirleri
//
// a) Verileri Kaydetme:
//    Uygulamayı kapatınca görevlerin kaybolmaması için bir dosyaya (JSON, CSV, XML) 
//    veya bir veritabanına (ör. SQLite, SQL Server) kaydetme mekanizması ekleyebilirsin.
//
// b) Düzenleme (Update) Özelliği:
//    Görevin açıklamasını güncellemek, görevle ilgili önemli tarih veya öncelik bilgisi gibi
//    ek alanlar eklemek isteyebilirsin.
//
// c) Filtreleme / Sıralama:
//    Tamamlanmış görevleri ayrı listeleyebilir veya görevleri alfabetik, tarihi veya önceliğine
//    göre sıralamak için filtre/sort ekleyebilirsin.
//
// d) Kullanıcı Arayüzü (GUI):
//    Konsol yerine Windows Forms, WPF ya da Blazor gibi bir görsel arabirimle uygulamayı
//    daha kullanıcı dostu hâle getirebilirsin.
//
// e) Birden Fazla Kullanıcı Desteği:
//    Her kullanıcının kendi görev listesini tutabileceği bir yapı kurmak mümkün.
//    Böylece farklı kişilerin görevlerini aynı uygulamada yönetebilirsin.
----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- 

