using System;
using System.Collections.Generic;

namespace TodoListApp
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        
        public override string ToString()
        {
            // Örnek çıktı: [1] - Alışveriş yap (Tamamlanmadı)
            return $"[{Id}] - {Description} " + (IsCompleted ? "(Tamamlandı)" : "(Tamamlanmadı)");
        }
    }
    class Program
    {
        // Global listemiz; tüm görevleri burada tutacağız
        static List<TaskItem> tasks = new List<TaskItem>();
        // Yeni görev eklendikçe artacak kimlik değeri
        static int currentId = 1; 
        
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n--- To-do List Uygulaması ---");
                Console.WriteLine("1) Görev Ekle");
                Console.WriteLine("2) Görevleri Listele");
                Console.WriteLine("3) Görevi Tamamla");
                Console.WriteLine("4) Görev Sil");
                Console.WriteLine("5) Çıkış");
                Console.Write("Seçiminiz: ");

                string choice = Console.ReadLine();
                
                switch (choice)
                {
                    case "1":
                        AddTask();
                        break;
                    case "2":
                        ListTasks();
                        break;
                    case "3":
                        CompleteTask();
                        break;
                    case "4":
                        DeleteTask();
                        break;
                    case "5":
                        Console.WriteLine("Uygulamadan çıkılıyor...");
                        return;
                    default:
                        Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                        break;
                }
            }
        }

        // 1) Görev Ekle
        static void AddTask()
        {
            Console.Write("Görev açıklaması: ");
            string description = Console.ReadLine();

            var newTask = new TaskItem
            {
                Id = currentId++,
                Description = description,
                IsCompleted = false
            };

            tasks.Add(newTask);
            Console.WriteLine($"Görev eklendi: {newTask}");
        }

        // 2) Görevleri Listele
        static void ListTasks()
        {
            Console.WriteLine("\n--- Görev Listesi ---");
            if (tasks.Count == 0)
            {
                Console.WriteLine("Hiç görev yok.");
                return;
            }

            foreach (var task in tasks)
            {
                Console.WriteLine(task); 
                // task.ToString() metodunu çağırır
            }
        }

        // 3) Görevi Tamamla
        static void CompleteTask()
        {
            Console.Write("Tamamlamak istediğiniz görevin ID'si: ");
            bool validInput = int.TryParse(Console.ReadLine(), out int taskId);

            if (!validInput)
            {
                Console.WriteLine("Geçersiz ID girişi.");
                return;
            }

            var task = tasks.Find(t => t.Id == taskId);
            if (task == null)
            {
                Console.WriteLine("Bu ID'ye sahip bir görev bulunamadı.");
                return;
            }

            task.IsCompleted = true;
            Console.WriteLine($"Görev tamamlandı: {task}");
        }

        // 4) Görev Sil
        static void DeleteTask()
        {
            Console.Write("Silmek istediğiniz görevin ID'si: ");
            bool validInput = int.TryParse(Console.ReadLine(), out int taskId);

            if (!validInput)
            {
                Console.WriteLine("Geçersiz ID girişi.");
                return;
            }

            var task = tasks.Find(t => t.Id == taskId);
            if (task == null)
            {
                Console.WriteLine("Bu ID'ye sahip bir görev bulunamadı.");
                return;
            }

            tasks.Remove(task);
            Console.WriteLine($"Görev silindi: {task}");
        }
    }
}
