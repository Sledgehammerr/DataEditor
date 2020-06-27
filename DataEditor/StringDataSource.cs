using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Xml.Serialization;
using System.Data;
using System.Text.RegularExpressions;

namespace WpfApp3
{
    public class Student
    {
        public Student() {
            this.Admission = DateTime.Now;
            this.Group = new Group();
        }
        public Student(string name)
        {
            this.Name = name;
            this.Admission = DateTime.Now;
            this.Group = new Group();
        }

        public string Name { get; set; }
        public DateTime Admission { get; set; }
        public Group Group { get; set; }
    }

    public class Group
    {
        public int Number { get; set; }
        public int Course { get; set; }
        public string Track { get; set; }
    }

    [Serializable]
    public class StringDataSource
    {
        public ObservableCollection<Student> data = new ObservableCollection<Student>();
    }
}
