using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Module1Exercise
{
    internal class Task
    {

        public string toDo { get; set; }
        public int priority { get; set; }

        public string description { get; set; }
        public bool status { get; set; }
        
       public Task(string task, int priority1, string description1, bool status1 ) { 
            toDo = task;
            priority = priority1;
            description = description1;
            status = status1;

        }


    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.Clear();
            List<Task> toDolist = new List<Task>();

            
            while (true)
            {
                Console.WriteLine("1. Khai bao to do list.");
                Console.WriteLine("2. Xoa 1 to do list.");
                Console.WriteLine("3. Update status to do list.");
                Console.WriteLine("4. Search task trong to do list.");
                Console.WriteLine("5. Show list task theo do uu tien giam dan.");
                Console.WriteLine("6. Show all tasks in to do list.");
                

                int input = int.Parse(Console.ReadLine());

                Console.Clear();

                switch (input)
                {
                    case 1:
                        add(toDolist);
                        break;
                    case 2:
                        delete(toDolist); break;
                    case 3:
                        updateStatus(toDolist); break;
                    case 4:
                        findByNameOrPriority(toDolist); break;
                    case 5:

                        showDecreasePriority(toDolist); break;
                    case 6:

                        show(toDolist); break;
                }
                Console.WriteLine("Nhan Y de tiep tuc");
                string inputAfter = Console.ReadLine(); 

                if (inputAfter.ToLower() == "y")
                {
                    
                    continue;
                    
                }
                



            }
            
        }

        static void add(List<Task> toDolist)
        {
            Console.WriteLine("Nhap vao task");
            string task2 = Console.ReadLine();
            Console.WriteLine("Nhap vao Priority");
            int priority2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap vao mo ta");
            string description2 = Console.ReadLine();
            Console.WriteLine("Nhap vao status");
            bool status2 = bool.Parse(Console.ReadLine());

            Task task = new Task(task2, priority2,description2, status2);

            toDolist.Add(task);

        }
        static void show (List<Task> toDolist)
        {
            if (toDolist.Count == 0)
            {
                return;
            }
            foreach (var item in toDolist)
            {
                Console.WriteLine(item.toDo);
                Console.WriteLine(item.priority);
                Console.WriteLine(item.description);
                Console.WriteLine(item.status);
            }
        }

        static void delete(List<Task> toDolist)
        {
            if (toDolist.Count == 0)
            {
                Console.WriteLine("List rong vui long nhap them");
                return;
                
            }
            Console.WriteLine("Nhap vao vi tri can xoa: ");
            int index = int.Parse(Console.ReadLine());
            toDolist.RemoveAt(index-1);
        }

        static void updateStatus(List<Task> toDolist)
        {
            if (toDolist.Count == 0)
            {
                Console.WriteLine("List rong vui long nhap them");
                return;

            }
            Console.WriteLine("Nhap vao ten task");
            string task = Console.ReadLine();
            

            foreach (var item in toDolist)
            {
                if (item.toDo == task)
                {
                    item.status = !item.status;
                }
            }
            

        }
        static void findByNameOrPriority(List<Task> toDolist)
        {
            if (toDolist.Count == 0)
            {
                Console.WriteLine("List rong vui long nhap them");
                return;
            }
            Console.WriteLine("1. Tim kiem theo viec");
            Console.WriteLine("2. Tim kiem theo do uu tien");

            int choice = int.Parse( Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Nhap vao viec can tim");
                    string input = Console.ReadLine();
                    foreach (var item in toDolist)
                    {
                        if (input == item.toDo)
                        {
                            Console.WriteLine(item.toDo);
                            Console.WriteLine(item.priority);
                            Console.WriteLine(item.description);
                            Console.WriteLine(item.status);

                        }

                    }
                    break;  
                case 2:
                    Console.WriteLine("Nhap vao do uu tien can tim");
                    int input1 = int.Parse(Console.ReadLine());
                    foreach (var item in toDolist)
                    {
                        if (input1 == item.priority)
                        {
                            Console.WriteLine(item.toDo);
                            Console.WriteLine(item.priority);
                            Console.WriteLine(item.description);
                            Console.WriteLine(item.status);

                        }

                    }
                    break;


            }

        }
        static void showDecreasePriority(List<Task> toDolist)
        {
            if (toDolist.Count == 0)
            {
                Console.WriteLine("List rong vui long nhap them");
                return;
            }
            foreach (var item in toDolist.OrderByDescending(t => t.priority))
            {
                Console.WriteLine(item.toDo);
                Console.WriteLine(item.priority);
                Console.WriteLine(item.description);
                Console.WriteLine(item.status);
            }
        }
        

    }
}
