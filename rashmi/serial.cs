using System;
using System.IO;
using System.Xml.Serialization;
namespace SerializationandDeserialization
{
 public class Employee
 {
  public int EmpID{ get; set;}
  public string EmpName{ get; set;}
  [XmlElement("EmpAddress")]
  public string Address{ get; set;}
  [XmlIgnore]
  public double Salary { get; set;}
}
class program
{
 public static void SerializeData(Employee emp)
 {
  FileStream fs=new FileStream(@"path",FileMode.Create);
  XmlSerializer xmlObj=new XmlSerializer(typeof(Employee));
  xmlObj.Serialize(fs,emp);
  fs.Close();
 }
 public static void DeSerializeData()
 {
  FileStream fs=new FileStream(@"path",FileMode.Open,FileAccess.Read);
  XmlSerializer xs =new XmlSerializer(typeof(Employee));
  Employee emp=(Employee)xs.Deserialize(fs);
  fs.Close();
  Console.WriteLine(emp.EmpID);
  Console.WriteLine(emp.EmpName);
  Console.WriteLine(emp.Address);
 }
 static void Main(string[] args)
 {
  Employee empObj=new Employee();
  empObj.EmpID=101;
  empObj.EmpName="xyz";
  empObj.Address="Bangalore";
  SerializeData(empObj);
  DeSerializeData(); 
  Console.ReadLine();
 }
 }
} 
 
 
