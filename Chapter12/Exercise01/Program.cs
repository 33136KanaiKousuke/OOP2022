using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Exercise01 {
    [XmlRoot("novel")]
    public class Employee {
        [XmlElement(ElementName = "id")]
        public int Id { get; set; }
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "hiredate")]
        public DateTime HireDate{ get; set; }
    }

    [XmlRoot("novel")]
    class Program {
        static void Main(string[] args) {

            Exercise1_1("employee.xml");

            // これは確認用
            Console.WriteLine(File.ReadAllText("employee.xml"));
            Console.WriteLine();

            Exercise1_2("employees.xml");
            Exercise1_3("employees.xml");
            Console.WriteLine();

            Exercise1_4("employees.json");

            // これは確認用
            //Console.WriteLine(File.ReadAllText("employees.json"));
        }

        private static void Exercise1_1(string outfile) {
            var emp = new Employee {
                Id = 123,
                Name = "出井　秀行",
                HireDate = new DateTime(2001, 5, 10),
            };

            //シリアル化

            using (var writer = XmlWriter.Create("employee.xml")) {
                var serializer = new XmlSerializer(emp.GetType());
                serializer.Serialize(writer, emp);
            }

            //逆シリアル化
            using (var reader = XmlReader.Create("employee.xml")) {
                var serializer = new XmlSerializer(typeof(Employee));
                var employees = serializer.Deserialize(reader) as Employee;
                
                Console.WriteLine(employees);
            }

        }

        private static void Exercise1_2(string outfile) {
            var emps= new Employee[]{
               new Employee {
                  Id = 123,
                  Name = "出井　秀行",
                  HireDate = new DateTime(2001, 5, 10),
               },
               new Employee {
                  Id = 139,
                  Name = "",
                  HireDate = new DateTime(2001, 5, 10),
               },
            };

            //シリアル化
            using (var writer = XmlWriter.Create("employee.xml")) {
                var serializer = new XmlSerializer(emps.GetType());
                serializer.Serialize(writer, emps);
            }

            //逆シリアル化
            using (var reader = XmlReader.Create("novels.xml")) {
                var serializer = new XmlSerializer(typeof(Employee[]));
                var employees = serializer.Deserialize(reader) as Employee[];
                // 以下、内容を確認するコード
                //foreach (var employee in employees.) {
                //    Console.WriteLine(employee);
                //}

            }
        }

        private static void Exercise1_3(string v) {
            
        }

        private static void Exercise1_4(string v) {
            
        }
    }
}
