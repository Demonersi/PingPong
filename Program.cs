using static System.Console;
using System.Collections.Generic;
List<Ping> list = new List<Ping>()
{
    new Ping
    {
        ping = "Ping"
    },

};
List<Pong> list1 = new List<Pong>()
{
    new Pong
    {
        pong = "Pong"
    },
};

Play_Ping_Pong ping_pong = new Play_Ping_Pong();

foreach (Ping item in list)
{
    ping_pong.ping_pongEvent += item.play_ping;
}
foreach (Pong item1 in list1)
{
    ping_pong.ping_pongEvent += item1.play_pong;
}
Ping ping = new Ping
{
    ping = "ping"
};
Pong pong = new Pong
{
    pong = "pong"
};
ping_pong.ping_pongEvent += ping.play_ping;
ping_pong.play_ping_pong("h");
ping_pong.ping_pongEvent += pong.play_pong;
ping_pong.play_ping_pong("p");
WriteLine();
WriteLine();
public delegate void ExamDelegate(string t);

class Ping
{
    public string ping { get; set; }
    public void play_ping(string pong)
    {
        WriteLine($"{ping} recieved {pong}");
    }
}
class Pong
{
    public string pong { get; set; }
    public void play_pong(string ping)
    {
        WriteLine($"{pong} recieved {ping}");
    }
}

class Play_Ping_Pong
{
    SortedList<int, ExamDelegate> _sortedEvents = new SortedList<int, ExamDelegate>();
    Random _rand = new Random();
    public event ExamDelegate ping_pongEvent
    {
        add
        {
            for (int key; ;)
            {
                key = _rand.Next();
                if (!_sortedEvents.ContainsKey(key))
                {
                    _sortedEvents.Add(key, value);
                    break;
                }
            }
        }
        remove
        {
            _sortedEvents.RemoveAt(_sortedEvents.IndexOfValue(value));
        }
    }
    public void play_ping_pong(string task)
    {
        foreach (int item in _sortedEvents.Keys)
            _sortedEvents[item](task);
    }
}
//using System.Collections.Generic;
//using static System.Console;
//List<Student> group = new List<Student>()
//{
//    new Student()
//    {
//        FirstName = "John",
//        LastName = "Smith",
//        BirthDate =new DateTime(1999,10,01)
//    },
//    new Student
//    {
//        FirstName ="Candice",
//        LastName="Leman",
//        BirthDate=new DateTime(1998,7,22)
//    },
//    new Student
//    {
//        FirstName="Joey",
//        LastName="Finch",
//        BirthDate=new DateTime(1996,11,30)
//    },
//    new Student {
//        FirstName="Nicole",
//        LastName="Taylor",
//        BirthDate=new DateTime(1996,5,10)
//    }
//};
//Teacher teacher = new Teacher();
//foreach (Student item in group)
//{
//    teacher.examEvent += item.Exam;
//}
//Student student = new Student
//{
//    FirstName = "John",
//    LastName = "Doe",
//    BirthDate = new DateTime(1996, 12, 10)
//};

//teacher.examEvent += student.Exam;
//teacher.Exam("Task #1");
//WriteLine();
//teacher.examEvent -= student.Exam;
//teacher.Exam("Task #2");
//WriteLine();

//public delegate void ExamDelegate(string t);
//class Student
//{
//    public string FirstName { get; set; }
//    public string LastName { get; set; }
//    public DateTime BirthDate { get; set; }
//    public void Exam(string task)
//    {
//        WriteLine($"Student: {LastName} solved the {task}");
//    }
//}
//class Teacher
//{
//    SortedList<int, ExamDelegate> _sortedEvents = new SortedList<int, ExamDelegate>();
//    Random _rand = new Random();
//    public event ExamDelegate examEvent
//    {
//        add
//        {
//            for (int key; ;)
//            {
//                key = _rand.Next();
//                if (!_sortedEvents.ContainsKey(key))
//                {
//                    _sortedEvents.Add(key, value);
//                    break;
//                }
//            }
//        }
//        remove
//        {
//            _sortedEvents.RemoveAt(_sortedEvents.IndexOfValue(value));
//        }
//    }
//    public void Exam(string task)
//    {
//        foreach (int item in _sortedEvents.Keys)
//            _sortedEvents[item](task);
//    }
//}