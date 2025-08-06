using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Collections
            #region Lists(Arrays) Clases
            #region ArrayList
            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(1);
            //arrayList.Add("any");
            //arrayList.Add(3);

            //Console.WriteLine(arrayList[1]); 
            #endregion

            #region List
            /// List<int> myList = new List<int>();
            /// 
            /// //Console.WriteLine($"myList.Capacity: {myList.Capacity}");
            /// //Console.WriteLine($"myList.Count: {myList.Count}");
            /// myList.Add(1);
            /// myList.Add(2);
            /// //Console.WriteLine($"myList.Capacity: {myList.Capacity}");
            /// //Console.WriteLine($"myList.Count: {myList.Count}");
            /// myList.Add(3);
            /// myList.Add(5);
            /// myList.Add(6);
            /// myList.Add(7);
            /// 
            /// myList.Insert(1, 6);
            /// myList[4] = 1;
            /// //Console.WriteLine(myList[1]);
            /// //myList.Insert(3, 4);
            /// foreach (int i in myList) Console.WriteLine(i);
            /// 
            /// Console.WriteLine($"myList.Capacity: {myList.Capacity}");
            /// Console.WriteLine($"myList.Count: {myList.Count}"); 
            #endregion

            #region Dictionary
            /// Dictionary<int, string> dic = new Dictionary<int, string>();
            /// 
            /// dic.Add(10, "Mena");
            /// dic.Add(20, "Erian");
            /// dic.Add(30, "Farouk");
            /// if (!dic.ContainsKey(30)) dic.Add(30, "Farouk");
            /// 
            /// /// string name = dic[20];
            /// /// //Console.WriteLine(name);
            /// /// //name = dic[40]; // Invaild will throw exsipiton
            /// 
            /// //foreach (var item in dic.Keys) Console.WriteLine(item);
            /// //foreach (var item in dic.Values) Console.WriteLine(item);
            /// 
            /// //foreach (int key in dic.Keys) Console.WriteLine($"Key: {key},Name: {dic[key]}");
            /// foreach (KeyValuePair<int,string> item in dic) Console.WriteLine(item); 
            #endregion
            #endregion

            #region LinkedList
            //LinkedList<>
            #endregion

            //EmployeeList employees = new EmployeeList();
            //employees.Add(new Employee() { Id = 1, Name = "Ali" });
            //employees.Add(new Employee() { Id = 2, Name = "sAli" });
            //employees.Add(new Employee() { Id = 3, Name = "Ali" });

            //List<Employee> employees = new List<Employee>()
            //{
            //    new Employee() { Id = 1, Name = "Ali" },
            //    new Employee() { Id = 2, Name = "sAli" },
            //    new Employee() { Id = 3, Name = "Ali" },
            //}; 
            #endregion

            #region Exciption Handeling
            //try
            //{
            //    test();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex);
            //}
            /// try
            /// {
            /// 
            ///     ValidateEmployeeData(new Employee() { Id = 200, Name = "Hamada" });
            /// }
            /// catch (Exception ex)
            /// {
            ///     Console.WriteLine($"{ex.Message}");
            ///     throw;
            /// } 
            #endregion

        }
        static void test()
        {
            try
            {
                int[] arr = { 1, 2, 3 };
                //arr[5] = 10;

                int x = int.Parse(Console.ReadLine());
                if (x == 0)
                {
                    throw new DivideByZeroException("Please enter a valid number");
                }
                int y = 10 / x;
                Console.WriteLine($"Result: {y}");

            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Error occured: {ex.Message}");
                //Console.WriteLine($"Error occured: {ex.StackTrace}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error occured: {ex.Message}");
            }
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error occured: {ex.Message}");
            //}
            finally // work wethear done try or done Catch
            {
                Console.WriteLine("Close connection");
            }
        }
        static void ValidateEmployeeData(Employee emp)
        {
            if (emp.Id > 100) throw new InvalidEmployeeValidData("Id Must Be Smaller than 100", emp);
        }
    }
}
